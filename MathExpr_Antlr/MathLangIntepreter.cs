using System;
using System.Collections.Generic;
using System.Globalization;

using Antlr.Runtime.Tree;

using AstNodeType = CCompilerParser;
using AstNode = Antlr.Runtime.Tree.ITree;


namespace MathLang
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

        private Dictionary<string, Ident> varTable = new Dictionary<string, Ident>();

        public Context(Context parentContext)
        {
            this.parentContext = parentContext;
        }

        public Ident this[string name]
        {
            get
            {
                return varTable.ContainsKey(name) ? varTable[name] :
                           parentContext != null ? parentContext[name] : null;
            }
            set
            {
                varTable[name] = value;
            }
        }

        public Ident InThisContext(string name)
        {
            return varTable.ContainsKey(name) ? varTable[name] : null;
        }

        private Ident function = null;

        public Ident Function
        {
            get
            {
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

  public class MathLangIntepreter
  {
      private static DataType StrToDataType(string type)
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
                  return DataType.Void;
              case "":
                  return DataType.Void;
              default:
                  throw new ApplicationException("Invalid data type");
          }
      }

      public static string DataTypeToStr(DataType dataType)
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
          AstNode convert = new AstNode(new Antlr.Runtime.CommonToken(CCompilerLexer.CALL, "CONVERT"));
          node.Parent.SetChild(node.ChildIndex, convert);
          convert.DataType = dataType;
          convert.AddChild(node);
          convert.AddChild(new AstNode(new Antlr.Runtime.CommonToken(CCompilerLexer.IDENT, DataTypeToStr(dataType))));
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
              case CCompilerLexer.PROGRAM:
                  {
                      if (context == null)
                          context = new Context(context);
                      CheckBlock(node, context);
                      return DataType.Void;
                  }
              case CCompilerLexer.BLOCK:
                  {
                      context = new Context(context);
                      CheckBlock(node, context);
                      return DataType.Void;
                  }

              case CCompilerLexer.VAR:
                  {
                      List<AstNode> nodes = new List<AstNode>();
                      DataType dataType = StrToDataType(node.GetChild(0).Text);
                      for (int i = 0; i < node.GetChild(0).ChildCount; i++)
                      {
                          AstNode temp = (AstNode)node.GetChild(0).GetChild(i);
                          if (temp.Token.Type == CCompilerLexer.ASSIGN)
                          {
                              Ident ident = context.InThisContext(temp.GetChild(0).Text);
                              if (ident != null)
                                  throw new ApplicationException(string.Format("Identifier {0} already exists", temp.GetChild(0).Text));
                              AstNode var = new AstNode(new Antlr.Runtime.CommonToken(CCompilerLexer.VAR, "VAR"));
                              var.AddChild(new AstNode(new Antlr.Runtime.CommonToken(CCompilerLexer.IDENT, DataTypeToStr(dataType))));
                              var.GetChild(0).AddChild(new AstNode(new Antlr.Runtime.CommonToken(CCompilerLexer.IDENT, temp.GetChild(0).Text)));
                              nodes.Add(var);
                              nodes.Add(temp);
                          }
                          else
                          {
                              Ident ident = context.InThisContext(temp.Text);
                              if (ident != null)
                                  throw new IntepreterException(string.Format("Identifier {0} already exists", temp.Text));
                              AstNode var = new AstNode(new Antlr.Runtime.CommonToken(CCompilerLexer.VAR, "VAR"));
                              var.AddChild(new AstNode(new Antlr.Runtime.CommonToken(CCompilerLexer.IDENT, DataTypeToStr(dataType))));
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
                     
                  }

              case CCompilerLexer.FUNC_DECL:
                  {
                      DataType dataType = StrToDataType(node.GetChild(0).Text);
                      string name = node.GetChild(1).Text;
                      Ident ident = context[name];
                      if (ident != null)
                          throw new IntepreterException(string.Format("Identifier {0} already exists", name));
                      Ident func = new Ident(name, IdentType.Function, dataType, node);
                      context[name] = func;
                      context = new Context(context);
                      AstNode _params = (AstNode)node.GetChild(2);
                      for (int i = 0; i < _params.ChildCount; i++)
                      {
                          DataType paramDataType = StrToDataType(_params.GetChild(i).Text);
                          string paramName = _params.GetChild(i).GetChild(0).Text;
                          if (paramDataType == DataType.Void)
                              throw new IntepreterException(string.Format("In function {0} void param {1}", name, paramName));
                          context[paramName] = new Ident(paramName, IdentType.Param, paramDataType, (AstNode)_params.GetChild(i));
                      }
                      context.Function = func;
                      Check((AstNode)node.GetChild(3), context);
                      return DataType.Void;
                  }

              case CCompilerLexer.CALL:
                  {
                      Ident ident = context[node.GetChild(0).Text];
                      if (ident == null)
                          throw new IntepreterException(string.Format("Unknown identifier {0}", node.GetChild(0).Text));
                      if (ident.IdentType != IdentType.Function)
                          throw new IntepreterException(string.Format("Identifier {0} is not function", node.GetChild(0).Text));
                      if (node.GetChild(1).ChildCount != ident.Node.GetChild(2).ChildCount)
                          throw new IntepreterException(string.Format("Not equals params count in function {0}", node.GetChild(0).Text));
                      for (int i = 0; i < ident.Node.GetChild(2).ChildCount; i++)
                      {
                          DataType formalDataType = StrToDataType(ident.Node.GetChild(2).GetChild(i).Text);
                          DataType factDataType = Check((AstNode)node.GetChild(1).GetChild(i), context);
                          if (formalDataType != factDataType)
                          {
                              if (formalDataType == DataType.Double && factDataType == DataType.Int)
                                  convert((AstNode)node.GetChild(1).GetChild(i), DataType.Double);
                              else
                                  throw new IntepreterException(string.Format("In function {0} param {1} incopotible types {2} {3}", node.GetChild(0).Text, i, DataTypeToStr(formalDataType), DataTypeToStr(factDataType)));
                          }
                      }
                      return StrToDataType(ident.Node.GetChild(0).Text);
                  }

              case CCompilerLexer.IDENT:
                  {
                      Ident ident = context[node.Text];
                      if (ident == null)
                          throw new ApplicationException(string.Format("Unknown identifier {0}", node.Text));
                      if (ident.IdentType == IdentType.Function)
                      {
                          if (ident.DataType == DataType.Void)
                              throw new IntepreterException(string.Format("Function {0} returns void", ident.Name));
                          if (ident.Node.GetChild(1).ChildCount > 0)
                              throw new IntepreterException(string.Format("No params for function {0} call", ident.Name));
                          AstNode call = new AstNode(new Antlr.Runtime.CommonToken(CCompilerLexer.CALL));
                          call.AddChild(node);
                          call.AddChild(new AstNode(new Antlr.Runtime.CommonToken(CCompilerLexer.ARGS)));
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

              case CCompilerLexer.NUMBER:
                  {
                      node.DataType = node.Text.Contains(".") ? DataType.Double : DataType.Int;
                      return node.DataType;
                  }

              case CCompilerLexer.TRUE:
              case CCompilerLexer.FALSE:
                  {
                      node.DataType = DataType.Bool;
                      return node.DataType;
                  }

              case CCompilerLexer.ASSIGN:
                  {
                      Ident ident = context[node.GetChild(0).Text];
                      if (ident == null)
                          throw new IntepreterException(string.Format("Unknown identifier {0}", node.GetChild(0).Text));
                      if (ident.IdentType == IdentType.Function)
                          throw new IntepreterException(string.Format("Assign to function {0}", node.GetChild(0).Text));
                      DataType rightDataType = Check((AstNode)node.GetChild(1), context);
                      if (ident.DataType != rightDataType)
                      {
                          if (ident.DataType == DataType.Double && rightDataType == DataType.Int)
                              convert((AstNode)node.GetChild(1), DataType.Double);
                          else
                              throw new IntepreterException(string.Format("Assign incopotible types {0} {1}", DataTypeToStr(ident.DataType), DataTypeToStr(rightDataType)));
                      }
                      return DataType.Void;
                  }

              case CCompilerLexer.RETURN:
                  {
                      if (context.Function == null)
                          throw new ApplicationException(string.Format("Return not in function in line {0}", node.Line));

                      DataType returnDataType = Check((AstNode)node.GetChild(0), context);
                      if (context.Function.DataType != returnDataType)
                      {
                          if (context.Function.DataType == DataType.Double && returnDataType == DataType.Int)
                              convert((AstNode)node.GetChild(0), DataType.Double);
                          else
                              throw new IntepreterException(string.Format("Return incopotible types {0} {1}", DataTypeToStr(context.Function.DataType), DataTypeToStr(returnDataType)));
                      }
                      return DataType.Void;
                  }

              case CCompilerLexer.ADD:
              case CCompilerLexer.SUB:
              case CCompilerLexer.MUL:
              case CCompilerLexer.DIV:
              case CCompilerLexer.GE:
              case CCompilerLexer.LE:
              case CCompilerLexer.NE:
              case CCompilerLexer.EQ:
              case CCompilerLexer.GT:
              case CCompilerLexer.LT:
                  {
                      bool compareOperation = true;
                      switch (node.Type)
                      {
                          case CCompilerLexer.ADD:
                          case CCompilerLexer.SUB:
                          case CCompilerLexer.MUL:
                          case CCompilerLexer.DIV:
                              compareOperation = false;
                              break;
                      }

                      DataType leftDataType = Check((AstNode)node.GetChild(0), context);
                      DataType rightDataType = Check((AstNode)node.GetChild(1), context);
                      if (leftDataType != DataType.Double && leftDataType != DataType.Int)
                          throw new IntepreterException(string.Format("Left operand invalid type for operation {0}, line = {1}, pos = {2}", node.Text, node.Line, node.TokenStartIndex));
                      if (rightDataType != DataType.Double && rightDataType != DataType.Int)
                          throw new IntepreterException(string.Format("Right operand invalid type for operation {0}, line = {1}, pos = {2}", node.Text, node.Line, node.TokenStartIndex));
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

              case CCompilerLexer.NOT:
                  {
                      DataType dataType = Check((AstNode)node.GetChild(0), context);
                      if (dataType != DataType.Bool)
                          throw new IntepreterException(string.Format("Not operator with type {0}", DataTypeToStr(dataType)));
                      node.DataType = DataType.Bool;
                      return node.DataType;
                  }

              case CCompilerLexer.AND:
              case CCompilerLexer.OR:
              case CCompilerLexer.WHILE:
                  {
                      DataType condDataType = Check((AstNode)node.GetChild(0), context);
                      if (condDataType != DataType.Bool)
                          throw new IntepreterException(string.Format("In while condition type is {0}", DataTypeToStr(condDataType)));
                      Check((AstNode)node.GetChild(1), context);
                      return DataType.Void;
                  }

              case CCompilerLexer.IF:
                  {
                      DataType condDataType = Check((AstNode)node.GetChild(0), context);
                      if (condDataType != DataType.Bool)
                          throw new IntepreterException(string.Format("In if condition type is {0}", DataTypeToStr(condDataType)));
                      Check((AstNode)node.GetChild(1), context);
                      if (node.ChildCount == 3)
                          Check((AstNode)node.GetChild(2), context);
                      return DataType.Void;
                  }

              case CCompilerLexer.FOR:
                  {
                      context = new Context(context);
                      CheckBlock((AstNode)node.GetChild(0), context);
                      DataType condDataType = Check((AstNode)node.GetChild(1), context);
                      if (condDataType != DataType.Bool)
                          throw new IntepreterException(string.Format("In while condition type is {0}", DataTypeToStr(condDataType)));
                      CheckBlock((AstNode)node.GetChild(2), context);
                      Check((AstNode)node.GetChild(3), context);
                      return DataType.Void;
                  }

              default:
                  {
                      return DataType.Void;
                      //throw new IntepreterException("Unknown token type");
                  }
          }
      }

      // "культуронезависимый" формат для чисел (с разделителем точкой)
    public static readonly NumberFormatInfo NFI = new NumberFormatInfo();
    // таблица переменных
    //private static IDictionary<string, double> varTable = new Dictionary<string, double>();

    private AstNode programNode = null;


    public MathLangIntepreter(AstNode programNode) {
      if (programNode.Type != AstNodeType.PROGRAM)
          throw new IntepreterException("AST-дерево не является программой");

      this.programNode = programNode;
    }

    /*
    private double ExecuteNode(AstNode node) {
      switch (node.Type) {
        case AstNodeType.UNKNOWN:
              throw new IntepreterException("Неизвестный тип узла AST-дерева");

        case AstNodeType.NUMBER:
          return double.Parse(node.Text, NFI);

          case AstNodeType.TRUE:

        case AstNodeType.IDENT:
          if (varTable.ContainsKey(node.Text))
            return varTable[node.Text];
          else
              throw new ParserBaseException(string.Format("Значение {0} не определено", node.Text));

        case AstNodeType.ADD:
          return ExecuteNode(node.GetChild(0)) + ExecuteNode(node.GetChild(1));

        case AstNodeType.SUB:
          return ExecuteNode(node.GetChild(0)) - ExecuteNode(node.GetChild(1));

        case AstNodeType.MUL:
          return ExecuteNode(node.GetChild(0)) * ExecuteNode(node.GetChild(1));

        case AstNodeType.DIV:
          return ExecuteNode(node.GetChild(0)) / ExecuteNode(node.GetChild(1));

        case AstNodeType.ASSIGN:
          varTable[node.GetChild(0).Text] = ExecuteNode(node.GetChild(1));
          break;

       

        case AstNodeType.BLOCK:
        case AstNodeType.PROGRAM:
          for (int i = 0; i < node.ChildCount; i++)
            ExecuteNode(node.GetChild(i));
          break;
      }

      return 0;
    }


    public void Execute() {
      ExecuteNode(programNode);
    }


    public static void Execute(AstNode programNode) {
      MathLangIntepreter mei=new MathLangIntepreter(programNode);
      mei.Execute();
    }
    */
  }
}
