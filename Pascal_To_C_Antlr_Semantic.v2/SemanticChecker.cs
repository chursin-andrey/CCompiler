﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MathExpr
{
    public enum IdentType
    {
        GlobalVar,
        LocalVar,
        Param,
        Function
    }

    public enum DataType
    {
        Void,
        Int,
        Double,
        Bool
    }

    public class Ident
    {
        public string Name { get; set; }
        public IdentType IdentType { get; set; }
        public DataType DataType { get; set; }

        public AstNode Node { get; set; }

        public Ident(string name, IdentType identType, DataType dataType, AstNode node)
        {
            Name = name;
            IdentType = identType;
            DataType = dataType;
            Node = node;
        }
    }


    public class Context
    {
        private Context parentContext;

        private Dictionary<string, Ident> idents = new Dictionary<string, Ident>();

        public Context(Context parentContext)
        {
            this.parentContext = parentContext;
        }

        public Ident this[string name]
        {
            get
            {
                return idents.ContainsKey(name) ? idents[name] :
                           parentContext != null ? parentContext[name] : null;
            }
            set
            {
                idents[name] = value;
            }
        }

        public Ident InThisContext(string name)
        {
            return idents.ContainsKey(name) ? idents[name] : null;
        }

        private Ident function = null;

        public Ident Function {
            get {
                return function != null ? function :
                           parentContext != null ? parentContext.Function : null;
            }
            set
            {
                function = value;
            }
        }

        public Context ParentContext
        {
            get
            {
                return parentContext;
            }
        }
    }


    public class SemanticChecker
    {
        private static DataType strToDataType(string type)
        {
            switch (type)
            {
                case "int":
                    return DataType.Int;
                case "double":
                    return DataType.Double;
                case "bool":
                    return DataType.Bool;
                case "void":
                case "":
                    return DataType.Void;
                default:
                    throw new ApplicationException("Invalid data type");
            }
        }

        public static string dataTypeToStr(DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Int:
                    return "int";
                case DataType.Double:
                    return "double";
                case DataType.Bool:
                    return "bool";
                case DataType.Void:
                    return "void";
                default:
                    return "unknown";
            }
        } 

        private static void convert(AstNode node, DataType dataType)
        {
            AstNode convert = new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.CALL, "CONVERT"));
            node.Parent.SetChild(node.ChildIndex, convert);
            convert.DataType = dataType;
            convert.AddChild(node);
            convert.AddChild(new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.IDENT, dataTypeToStr(dataType))));
        }

        public static void CheckBlock(AstNode node, Context context)
        {
            for (int i = 0; i < node.ChildCount; i++)
                Check((AstNode)node.GetChild(i), context);
        }

        public static DataType Check(AstNode node, Context context)
        {
            switch (node.Type)
            {
                case MathExprLexer.PROGRAM:
                {
                    if (context == null)
                        context = new Context(context);
                    CheckBlock(node, context);
                    return DataType.Void;
                }
                case MathExprLexer.BLOCK:
                {
                    context = new Context(context);
                    CheckBlock(node, context);
                    return DataType.Void;
                }

                case MathExprLexer.VAR: {
                    List<AstNode> nodes = new List<AstNode>();
                    DataType dataType = strToDataType(node.GetChild(0).Text);
                    for (int i = 0; i < node.GetChild(0).ChildCount; i++)
                    {
                        AstNode temp = (AstNode) node.GetChild(0).GetChild(i);
                        if (temp.Token.Type == MathExprLexer.ASSIGN)
                        {
                            Ident ident = context.InThisContext(temp.GetChild(0).Text);
                            if (ident != null)
                                throw new ApplicationException(string.Format("Identifier {0} already exists", temp.GetChild(0).Text));
                            AstNode var = new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.VAR, "VAR"));
                            var.AddChild(new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.IDENT, dataTypeToStr(dataType))));
                            var.GetChild(0).AddChild(new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.IDENT, temp.GetChild(0).Text)));
                            nodes.Add(var);
                            nodes.Add(temp);
                        }
                        else
                        {
                            Ident ident = context.InThisContext(temp.Text);
                            if (ident != null)
                                throw new ApplicationException(string.Format("Identifier {0} already exists", temp.Text));
                            AstNode var = new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.VAR, "VAR"));
                            var.AddChild(new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.IDENT, dataTypeToStr(dataType))));
                            var.GetChild(0).AddChild(temp);
                            nodes.Add(var);
                        }
                        string name = nodes[0].GetChild(0).GetChild(0).Text;
                        context[name] = new Ident(name, context.ParentContext == null ? IdentType.GlobalVar : IdentType.LocalVar, dataType, nodes[0]);

                        Antlr.Runtime.Tree.CommonTree tree = new Antlr.Runtime.Tree.CommonTree();
                        foreach (AstNode n in nodes)
                            tree.AddChild(n);
                        node.Parent.ReplaceChildren(node.ChildIndex, node.ChildIndex, tree);
                    }

                    return DataType.Void;
; 
                }

                case MathExprLexer.FUNCTION:
                {
                    DataType dataType = strToDataType(node.GetChild(0).Text);
                    string name = node.GetChild(1).Text;
                    Ident ident = context[name];
                    if (ident != null)
                        throw new ApplicationException(string.Format("Identifier {0} already exists", name));
                    Ident func = new Ident(name, IdentType.Function, dataType, node);
                    context[name] = func;
                    context = new Context(context);
                    AstNode _params = (AstNode) node.GetChild(2);
                    for (int i = 0; i < _params.ChildCount; i++)
                    {
                        DataType paramDataType = strToDataType(_params.GetChild(i).Text);
                        string paramName = _params.GetChild(i).GetChild(0).Text;
                        if (paramDataType == DataType.Void)
                            throw new ApplicationException(string.Format("In function {0} void param {1}", name, paramName));
                        context[paramName] = new Ident(paramName, IdentType.Param, paramDataType, (AstNode) _params.GetChild(i));
                    }
                    context.Function = func;
                    Check((AstNode) node.GetChild(3), context);
                    return DataType.Void;
                }

                case MathExprLexer.CALL:
                {
                    Ident ident = context[node.GetChild(0).Text];
                    if (ident == null)
                        throw new ApplicationException(string.Format("Unknown identifier {0}", node.GetChild(0).Text));
                    if (ident.IdentType != IdentType.Function)
                        throw new ApplicationException(string.Format("Identifier {0} is not function", node.GetChild(0).Text));
                    if (node.GetChild(1).ChildCount != ident.Node.GetChild(2).ChildCount)
                        throw new ApplicationException(string.Format("Not equals params count in function {0}", node.GetChild(0).Text));
                    for (int i = 0; i < ident.Node.GetChild(2).ChildCount; i++) {
                        DataType formalDataType = strToDataType(ident.Node.GetChild(2).GetChild(i).Text);
                        DataType factDataType = Check((AstNode)node.GetChild(1).GetChild(i), context);
                        if (formalDataType != factDataType)
                        {
                            if (formalDataType == DataType.Double && factDataType == DataType.Int)
                                convert((AstNode)node.GetChild(1).GetChild(i), DataType.Double);
                            else
                                throw new ApplicationException(string.Format("In function {0} param {1} incopotible types {2} {3}", node.GetChild(0).Text, i, dataTypeToStr(formalDataType), dataTypeToStr(factDataType)));
                        }
                    }
                    return strToDataType(ident.Node.GetChild(0).Text);
                }

                case MathExprLexer.IDENT:
                {
                    Ident ident = context[node.Text];
                    if (ident == null)
                        throw new ApplicationException(string.Format("Unknown identifier {0}", node.Text));
                    if (ident.IdentType == IdentType.Function)
                    {
                        if (ident.DataType == DataType.Void)
                            throw new ApplicationException(string.Format("Function {0} returns void", ident.Name));
                        if (ident.Node.GetChild(1).ChildCount > 0)
                            throw new ApplicationException(string.Format("No params for function {0} call", ident.Name));
                        AstNode call = new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.CALL));
                        call.AddChild(node);
                        call.AddChild(new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.PARAMS)));
                        node.Parent.SetChild(node.ChildIndex, call);

                        node.DataType = ident.DataType;
                        return node.DataType;
                    }
                    else
                    {
                        node.DataType = ident.DataType;
                        return node.DataType;
                    }
                }

                case MathExprLexer.NUMBER:
                {
                    node.DataType = node.Text.Contains(".") ? DataType.Double : DataType.Int;
                    return node.DataType;
                }

                case MathExprLexer.TRUE:
                case MathExprLexer.FALSE:
                {
                    node.DataType = DataType.Bool;
                    return node.DataType;
                }

                case MathExprLexer.ASSIGN:
                {
                    Ident ident = context[node.GetChild(0).Text];
                    if (ident == null)
                        throw new ApplicationException(string.Format("Unknown identifier {0}", node.GetChild(0).Text));
                    if (ident.IdentType == IdentType.Function)
                        throw new ApplicationException(string.Format("Assign to function {0}", node.GetChild(0).Text));
                    DataType rightDataType = Check((AstNode) node.GetChild(1), context);
                    if (ident.DataType != rightDataType)
                    {
                        if (ident.DataType == DataType.Double && rightDataType == DataType.Int)
                            convert((AstNode) node.GetChild(1), DataType.Double);
                        else
                            throw new ApplicationException(string.Format("Assign incopotible types {0} {1}", dataTypeToStr(ident.DataType), dataTypeToStr(rightDataType)));
                    }
                    return DataType.Void;
                }

                case MathExprLexer.RETURN:
                {
                    if (context.Function == null)
                        throw new ApplicationException(string.Format("Return not in function in line {0}", node.Line));

                    DataType returnDataType = Check((AstNode) node.GetChild(0), context);
                    if (context.Function.DataType != returnDataType)
                    {
                        if (context.Function.DataType == DataType.Double && returnDataType == DataType.Int)
                            convert((AstNode) node.GetChild(0), DataType.Double);
                        else
                            throw new ApplicationException(string.Format("Return incopotible types {0} {1}", dataTypeToStr(context.Function.DataType), dataTypeToStr(returnDataType)));
                    }
                    return DataType.Void;
                }

                case MathExprLexer.ADD:
                case MathExprLexer.SUB:
                case MathExprLexer.MUL:
                case MathExprLexer.DIV:
                case MathExprLexer.GE:
                case MathExprLexer.LE:
                case MathExprLexer.NEQUALS:
                case MathExprLexer.EQUALS:
                case MathExprLexer.GT:
                case MathExprLexer.LT:
                {
                    bool compareOperation = true;
                    switch (node.Type) {
                        case MathExprLexer.ADD:
                        case MathExprLexer.SUB:
                        case MathExprLexer.MUL:
                        case MathExprLexer.DIV:
                            compareOperation = false;
                            break;
                    }

                    DataType leftDataType = Check((AstNode) node.GetChild(0), context);
                    DataType rightDataType = Check((AstNode) node.GetChild(1), context);
                    if (leftDataType != DataType.Double && leftDataType != DataType.Int)
                        throw new ApplicationException(string.Format("Left operand invalid type for operation {0}, line = {1}, pos = {2}", node.Text, node.Line, node.TokenStartIndex));
                    if (rightDataType != DataType.Double && rightDataType != DataType.Int)
                        throw new ApplicationException(string.Format("Right operand invalid type for operation {0}, line = {1}, pos = {2}", node.Text, node.Line, node.TokenStartIndex));
                    if (leftDataType == DataType.Double)
                    {
                        if (rightDataType == DataType.Int)
                            convert((AstNode)node.GetChild(1), DataType.Double);
                        node.DataType = compareOperation ? DataType.Bool : DataType.Double;
                        return node.DataType;
                    }
                    if (rightDataType == DataType.Double)
                    {
                        if (leftDataType == DataType.Int)
                            convert((AstNode)node.GetChild(0), DataType.Double);
                        node.DataType = compareOperation ? DataType.Bool : DataType.Double;
                        return node.DataType;
                    }
                    node.DataType = compareOperation ? DataType.Bool : DataType.Int;
                    return node.DataType;
                }

                case MathExprLexer.NOT:
                {
                    DataType dataType = Check((AstNode) node.GetChild(0), context);
                    if (dataType != DataType.Bool)
                        throw new ApplicationException(string.Format("Not operator with type {0}", dataTypeToStr(dataType)));
                    node.DataType = DataType.Bool;
                    return node.DataType;
                }

                case MathExprLexer.AND:
                case MathExprLexer.OR:
                case MathExprLexer.XOR:
                {
                    DataType leftDataType = Check((AstNode) node.GetChild(0), context);
                    DataType rightDataType = Check((AstNode) node.GetChild(1), context);
                    if (leftDataType != DataType.Bool && rightDataType != DataType.Bool)
                        throw new ApplicationException(string.Format("{0} operator with type {1}, {2}", node.Text, dataTypeToStr(leftDataType), dataTypeToStr(rightDataType)));
                    node.DataType = DataType.Bool;
                    return node.DataType;
                }

                case MathExprLexer.WHILE:
                {
                    DataType condDataType = Check((AstNode)node.GetChild(0), context);
                    if (condDataType != DataType.Bool)
                        throw new ApplicationException(string.Format("In while condition type is {0}", dataTypeToStr(condDataType)));
                    // context = new Context(context);
                    Check((AstNode)node.GetChild(1), context);
                    return DataType.Void;
                }

                case MathExprLexer.IF:
                {
                    DataType condDataType = Check((AstNode)node.GetChild(0), context);
                    if (condDataType != DataType.Bool)
                        throw new ApplicationException(string.Format("In if condition type is {0}", dataTypeToStr(condDataType)));
                    // context = new Context(context);
                    Check((AstNode)node.GetChild(1), context);
                    if (node.ChildCount == 3)
                        Check((AstNode)node.GetChild(2), context);
                    return DataType.Void;
                }
                
                case MathExprLexer.FOR:
                {
                    context = new Context(context);
                    CheckBlock((AstNode) node.GetChild(0), context);
                    DataType condDataType = Check((AstNode)node.GetChild(1), context);
                    if (condDataType != DataType.Bool)
                        throw new ApplicationException(string.Format("In while condition type is {0}", dataTypeToStr(condDataType)));
                    CheckBlock((AstNode)node.GetChild(2), context);
                    Check((AstNode)node.GetChild(3), context);
                    return DataType.Void;
                }

                default:
                {
                    throw new ApplicationException("Unknown token type");
                }
                break;
            }
        }
    }
}
