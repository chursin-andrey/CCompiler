﻿grammar SimpleC;

options {
	language=CSharp3;
	TokenLabelType=CommonToken;
	output=AST;
	ASTLabelType=CommonTree;
}

tokens {
    INTEGER             ;
    IDENT               ;

    PROGRAM             ;
    
    VAR_DECL            ;
    VAR_DEF             ;
    VAR_CALL            ;
    FUNC_DECL           ;
    FUNC_DEF            ;
    FUNC_CALL           ;

    VAR_SPEC            ;
	TYPE_SPEC           ;

    PARAM_SPEC_LIST     ;
    PARAM_LIST          ;
    FUNC_BODY           ;

	STATEMENT           ;
    EXPRESSION          ;

	TYPECAST            ;
	SIZEOF_EXPR         ;
	SIZEOF_TYPE         ;

	REF			        ;
	DEREF		        ;
	STRUCT_MEMBER       ;
	STRUCT_DEREF        ;
	SUBSCRIPT           ;

    U_PLUS              ;
    U_MINUS             ;

    ADD           = '+' ;
    SUB           = '-' ;
    MUL           = '*' ;
    DIV           = '/' ;
	MOD           = '%' ;

    INC_PRE             ;
    INC_POST            ;
    DEC_PRE             ;
    DEC_POST            ;

    ASSIGN        = '=' ;


    EQUAL         = '==';
    NOT_EQUAL     = '!=';
    LESS          = '<' ;
    LESS_OR_EQUAL = '<=';
    GREATER       = '>' ;
    GREATER_OR_EQUAL = '>=';

    BOOL_NOT            ;
    BOOL_AND      = '&&';
    BOOL_OR       = '||';

    BIT_NOT             ;
    BIT_AND       = '&' ;
    BIT_OR        = '|' ;
    BIT_XOR       = '^' ;

	SHIFT_LEFT    = '<<';
	SHIFT_RIGHT   = '>>';
}

@lexer::namespace { SimpleC.Grammar }
@parser::namespace { SimpleC.Grammar }

@lexer::header {
#pragma warning disable 3021
}

@parser::header {
#pragma warning disable 3021
}

public
program: 
	programStatement* EOF
	-> ^(PROGRAM programStatement*)
;

programStatement:
	varDef | funcDecl | funcDef
;

varDef:
	varSpec ';'
		-> ^(VAR_DEF varSpec)
;

funcDecl: 
	typeSpec identifier '(' paramSpecList ')'';' 
		-> ^(FUNC_DECL typeSpec identifier paramSpecList)
;

funcDef:
	typeSpec identifier '(' paramSpecList ')''{' funcBody '}' 
		-> ^(FUNC_DEF typeSpec identifier paramSpecList funcBody)
;

paramSpecList:
	(varSpec (',' varSpec)*)? -> ^(PARAM_SPEC_LIST varSpec*)
;

funcBody:
	statements -> ^(FUNC_BODY statements?)
;

statements:
	statement*
;

statement:
	varDef
	| expr? ';' -> ^(STATEMENT expr?)
	| '{' statements '}' -> ^(STATEMENT statements?)
;

varSpec:
    typeSpec identifier
		-> ^(VAR_SPEC typeSpec identifier)
;

typeSpec:
	(tn=Int | tn=Void) -> ^(TYPE_SPEC { adaptor.BecomeRoot(new CommonToken(IDENT, $tn.Text), adaptor.Nil()) })
;

paramList:
	(expr (',' expr)*)? -> ^(PARAM_LIST expr*)
;

expr:
	binaryExpr
;

binaryExpr
@init {
	List<ITree> expressions = new List<ITree>();
	List<IToken> operators = new List<IToken>();
}	:
	left=unaryExpr { expressions.Add((ITree)left.Tree); }
	(op=binaryOperator right=unaryExpr {
		operators.Add(((CommonTree)op.Tree).Token);
		expressions.Add((ITree)right.Tree);
	})*
	/*-> { CreatePrecedenceTree(expressions, operators) }*/
;

unaryExpr options {
	backtrack=true;
}	:
	'*' unaryExpr -> ^(DEREF unaryExpr)
	| '&' unaryExpr -> ^(REF unaryExpr)
	| '+' unaryExpr -> ^(U_PLUS unaryExpr)
	| '-' unaryExpr -> ^(U_MINUS unaryExpr)
	| '!' unaryExpr -> ^(BOOL_NOT unaryExpr)
	| '~' unaryExpr -> ^(BIT_NOT unaryExpr)
	| '++' unaryExpr -> ^(INC_PRE unaryExpr)
	| '--' unaryExpr -> ^(DEC_PRE unaryExpr)
	| '(' typeSpec ')' unaryExpr -> ^(TYPECAST unaryExpr typeSpec)
	| SizeOf unaryExpr -> ^(SIZEOF_EXPR unaryExpr)
	| SizeOf '(' typeSpec ')' -> ^(SIZEOF_TYPE typeSpec)
	| primaryExpr

;

primaryExpr
@init {
	List<ITree> expressions = new List<ITree>();
	List<IToken> operators = new List<IToken>();
}	:
	basic=basicExpr { 
		expressions.Add((ITree)basic.Tree);
	}
	(
			'[' idx=expr ']' { 
				operators.Add(new CommonToken(SUBSCRIPT, tokenNames[SUBSCRIPT]));
				expressions.Add((ITree)idx.Tree);
			} 
		|	'.' member=identifier {
				operators.Add(new CommonToken(STRUCT_MEMBER, tokenNames[STRUCT_MEMBER]));
				expressions.Add((ITree)member.Tree);
			}
		|	'->' member=identifier {
				operators.Add(new CommonToken(STRUCT_DEREF, tokenNames[STRUCT_DEREF]));
				expressions.Add((ITree)member.Tree);
			}
		|	'++' { 
				operators.Add(new CommonToken(INC_POST, tokenNames[INC_POST]));
				expressions.Add(null);
			}
		|	'--' {
				operators.Add(new CommonToken(DEC_POST, tokenNames[DEC_POST]));
				expressions.Add(null);
			}
	)* /*-> { CreatePrimaryPrecedenceTree(expressions, operators) }*/
;

/*
primaryExpr:
	basicExpr ('[' idx=expr ']' //-> ^(SUBSCRIPT basicExpr $idx) 
		| '.' member=identifier //-> ^(STRUCT_MEMBER basicExpr $member)
		| '->' member=identifier //-> ^(STRUCT_DEREF basicExpr $member) 
		| '++' //-> ^(INC_POST basicExpr) 
		| '--' //-> ^(DEC_POST basicExpr)
	)*
;
*/

basicExpr:
	'('! expr ')'!
	| identifier 
	| integer 
	| funcCall
;

funcCall:
	identifier '(' paramList ')' -> ^(FUNC_CALL identifier paramList)
;

binaryOperator:
	ADD
	| SUB
	| MUL
	| DIV
	| MOD
//	| SHIFT_LEFT
//	| SHIFT_RIGHT
	| ASSIGN
//	| GREATER
//	| GREATER_OR_EQUAL
//	| LESS
//	| LESS_OR_EQUAL
//	| EQUAL
//	| NOT_EQUAL
//	| BOOL_AND
//	| BOOL_OR
//	| BIT_AND
//	| BIT_OR
//	| BIT_XOR
;


identifier:
	Identifier -> { 
		adaptor.BecomeRoot(new CommonToken(IDENT, $Identifier.Text), adaptor.Nil()) 
	}
;

integer:
	Integer -> {
		adaptor.BecomeRoot(new CommonToken(INTEGER, $Integer.Text), adaptor.Nil()) 
	}
;

Whitespace:
	( ' ' | '\t' | '\f' | '\r' | '\n' )+ {
		$channel=Hidden;
	}
;

Integer: 
	('0'..'9')+
;

SizeOf: 'sizeof';

Int: 'int';

Void: 'void';

Identifier:  
	( 'a'..'z' | 'A'..'Z' | '_' )
	( 'a'..'z' | 'A'..'Z' | '_' | '0'..'9' )*
;
//ADD:    '+'     ;
//SUB:    '-'     ;
//MUL:    '*'     ;
//DIV:    '/'     ;
//ASSIGN: '='     ;


