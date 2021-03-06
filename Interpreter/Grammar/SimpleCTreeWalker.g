﻿tree grammar SimpleCTreeWalker;

options {
	language=CSharp3;
	tokenVocab=SimpleC;
	ASTLabelType=CommonTree;
}

@namespace { SimpleC.Grammar }

@header {
#pragma warning disable 3021
using SimpleC.Tree;
}

public
walk returns [RootNode node]
@init {
	node = new RootNode();
}	:

	^(PROGRAM (programStatement { node.Children.Add($programStatement.node); })*)
;

programStatement returns [ISCNode node]
	: varDef { node = $varDef.node; }
	| funcDecl {
		FuncDeclNode funcDeclNode = $funcDecl.node;
		node = funcDeclNode; 
		FuncDeclsContainer.Add(funcDeclNode);
	}
	| funcDef {	
		FuncDefNode funcDefNode = $funcDef.node;
		node = funcDefNode; 
		FuncDeclsContainer.Add(funcDefNode);
	}
	/*
	| macroDecl { 
		FuncDeclNode funcDeclNode = $funcDecl.node;
		node = funcDeclNode; 
		FuncDeclsContainer.Add(funcDeclNode);
	}*/
;

varDef returns [VarDefNode node]:
	^(VAR_DEF varSpec) { node = new VarDefNode($varSpec.node); }
;

funcDecl returns [FuncDeclNode node]
@init {
	node = new FuncDeclNode();
}	:
	^(FUNC_DECL 
		typeSpec { node.ReturnTypeSpec = $typeSpec.node; } 
		IDENT { node.Name = $IDENT.Text; }
		^(PARAM_SPEC_LIST (varSpec { node.Parameters.Add($varSpec.node); })*)
	)
;

macroDecl returns [FuncDeclNode node]
@init {
	node = new FuncDeclNode();
}	:
	^(FUNC_DECL 
		typeSpec { node.ReturnTypeSpec = $typeSpec.node; } 
		IDENT { node.Name = $IDENT.Text; }
		^(PARAM_SPEC_LIST (varSpec { node.Parameters.Add($varSpec.node); })*)
	)
;

funcDef returns [FuncDefNode node]
@init {
	node = new FuncDefNode();
}	:
	^(FUNC_DEF 
		typeSpec { node.ReturnTypeSpec = $typeSpec.node; }
		IDENT { node.Name = $IDENT.Text; }
		^(PARAM_SPEC_LIST (varSpec { node.Parameters.Add($varSpec.node); })*) 
		funcBody { node.Body = $funcBody.node; })
;

varSpec returns [VarSpecNode node]
@init {
	node = new VarSpecNode();
}	:
	^(VAR_SPEC typeSpec IDENT) { 
		node.TypeSpec = $typeSpec.node; 
		node.Name = $IDENT.Text;
	}
;

typeSpec returns [TypeSpecNode node]
@init {
	node = new TypeSpecNode();
}	:
	^(TYPE_SPEC IDENT) { 
		node.PrimaryTypeName = $IDENT.Text; 
	}
;

funcBody returns [CompoundStatementNode node]
@init {
	node = new CompoundStatementNode();
}	:
	^(FUNC_BODY (statement { node.Statements.Add($statement.node); })*)
;

statement returns [ISCNode node]:
	varDef { node = $varDef.node; }
	| STATEMENT { node = new CompoundStatementNode(); } // This simulates an empty statement
	| ^(STATEMENT expression) { node = $expression.node; }
	| ^(STATEMENT { 
		node = new CompoundStatementNode(); 
		CompoundStatementNode compoundNode = (CompoundStatementNode)node; }	
				(st=statement { compoundNode.Statements.Add($st.node); })+)
;	

expression returns [IExprNode node]:
	// Binary expressions
	(
		^(type=ADD left=expression right=expression)
		| ^(type=SUB left=expression right=expression)
		| ^(type=MUL left=expression right=expression)
		| ^(type=DIV left=expression right=expression)
		| ^(type=MOD left=expression right=expression)
		| ^(type=SHIFT_LEFT left=expression right=expression)
		| ^(type=SHIFT_RIGHT left=expression right=expression)
		| ^(type=ASSIGN left=expression right=expression)
		| ^(type=GREATER left=expression right=expression)
		| ^(type=GREATER_OR_EQUAL left=expression right=expression)
		| ^(type=LESS left=expression right=expression)
		| ^(type=LESS_OR_EQUAL left=expression right=expression)
		| ^(type=EQUAL left=expression right=expression)
		| ^(type=NOT_EQUAL left=expression right=expression)
		| ^(type=BOOL_AND left=expression right=expression)
		| ^(type=BOOL_OR left=expression right=expression)
		| ^(type=BIT_AND left=expression right=expression)
		| ^(type=BIT_OR left=expression right=expression)
		| ^(type=BIT_XOR left=expression right=expression)
	) { node = new BinaryExprNode($type.Type, $left.node, $right.node); }

/*
	// Unary expressions
	| ^(DEREF expression)
	| ^(REF expression)
	| ^(U_PLUS expression)
	| ^(U_MINUS expression)
	| ^(BOOL_NOT expression)
	| ^(BIT_NOT expression)
	| ^(INC_PRE expression)
	| ^(DEC_PRE expression)
	| ^(TYPECAST expression IDENT)
	| ^(SIZEOF_EXPR expression)
	| ^(SIZEOF_TYPE typeSpec)

	// Primary expressions
	| ^(SUBSCRIPT expression expression)
	| ^(STRUCT_MEMBER expression IDENT)
	| ^(STRUCT_DEREF expression IDENT)
	| ^(INC_POST expression)
	| ^(DEC_POST expression)

	// Basic expressions
*/
	| IDENT { 
		node = new IdentNode();
		(node as IdentNode).Name = $IDENT.Text;
	}
	| INTEGER {
		node = new IntegerNode($INTEGER.Text);
	}
	| STRING {
		node = new StringNode($STRING.Text);
	}
	| ^(FUNC_CALL {
			List<IExprNode> parameters = new List<IExprNode>();
		} 
			IDENT {
				if (!FuncDeclsContainer.Contains(new FuncDeclEquatable($IDENT.Text)))
			} 
			^(PARAM_LIST (parameter=expression { parameters.Add($parameter.node); })*)) {

		FuncCallNode funcCallNode = new FuncCallNode();
		node = funcCallNode;
		funcCallNode.Function = FuncDeclsContainer.Get(new FuncDeclEquatable($IDENT.Text));

		// Check parameters
		switch(FuncCallNode.ParameterListMatches(funcCallNode.Function.Parameters, parameters))
		{
			case FuncCallNode.ParameterMatching.ParameterCountMismatch:
				break;
			case FuncCallNode.ParameterMatching.ParameterTypeMismatch:
				break;
			default:
				// There is no error so do nothing
				break;
		}

		funcCallNode.Parameters = parameters;
	}
;