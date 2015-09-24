grammar CCompiler;

options {
  language=CSharp3;
  output=AST;
  backtrack=true;
}


tokens {
  UNKNOWN             ;
  BLOCK               ;
  PROGRAM = 'program' ;
  AND = 'and'         ;
  OR = 'or'           ;
  BEGIN = 'begin'     ;
  END = 'end'         ;
  IF = 'if'           ;
  THEN = 'then'       ;
  ELSE = 'else'       ;
  WHILE = 'while'     ;
  DO = 'do'           ;
  REPEAT = 'repeat'   ;
  UNTIL = 'until'     ;
}


/*
@header {
  using System.IO;
  using System.Globalization;
}

@lexer::members {
  // default number format with "." delimiter
  public static readonly NumberFormatInfo NFI = new NumberFormatInfo();
}
*/


@lexer::namespace { MathLang }
@parser::namespace { MathLang }


WS:
  ( ' ' | '\t' |  '\f' | '\r' | '\n' )+ {
    $channel=Hidden;
  }
;

SL_COMMENT:
  '//' (options { greedy=false; }: .)* '\r'? '\n' {
    $channel=Hidden;
  }
;
ML_COMMENT:
  '/*' (options { greedy=false; }: .)* '*/' {
    $channel=Hidden;
  }
;


NUMBER: ('0'..'9')+ ('.' ('0'..'9')+)?
;
IDENT:  ( 'a'..'z' | 'A'..'Z' | '_' )
        ( 'a'..'z' | 'A'..'Z' | '_' | '0'..'9' )*
;
ADD:    '+'     ;
SUB:    '-'     ;
MUL:    '*'     ;
DIV:    '/'     ;
ASSIGN: ':='    ;

GE:     '>='  ;
LE:     '<='  ;
NE:     '<>'  ;
EQ:     '='   ;
GT:     '>'   ;
LT:     '<'   ;


group:
  '('! term ')'!
| NUMBER
| IDENT
;


mult: group ( ( MUL | DIV )^ group )*  ;
add:  mult  ( ( ADD | SUB )^ mult  )*  ;
term: add  ;
logic: term ( GE | LE | NE | EQ | GT | LT )^ term ;
and: logic (AND^ logic)* ;
or: and (OR^ and)* ;

expr:
  IF^ or THEN! expr ( ELSE! expr )?
| block
| IDENT ASSIGN^ term
| WHILE^ or DO! expr
| REPEAT expr UNTIL or -> ^(REPEAT or expr)
;

exprList: ( expr (';'!)+ )* expr? ;
block: BEGIN exprList END -> ^(BLOCK exprList) ;

program: PROGRAM^ IDENT ';'! block '.'!;

result: program EOF!;

public execute:
  result
;
