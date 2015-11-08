grammar MathExpr;

options {
  language=CSharp2;
  output=AST;
  ASTLabelType = AstNode;

  backtrack=true;
  memoize=true;
}


tokens {
  UNKNOWN             ;
  BLOCK               ;
  PARAMS              ;
  CALL                ;
  CONVERT             ;
  IF      = 'if'      ;
  ELSE    = 'else'    ;
  FOR     = 'for'     ;
  WHILE   = 'while'   ;
  REPEAT  = 'repeat'  ;
  UNTIL   = 'until'   ;
  BEGIN   = 'begin'   ;
  END     = 'end'     ;
  AND     = 'and'     ;
  OR      = 'or'      ;
  NOT     = 'not'     ;
  XOR     = 'xor'     ;
  INT_DIV = 'div'     ;
  INT_MOD = 'mod'     ;
  SHR     = 'shr'     ;
  SHL     = 'shl'     ;
  IN      = 'in'      ;
  VAR     = 'var'     ;
  RETURN  = 'return'  ;
  PROCEDURE = 'procedure' ;
  FUNCTION  = 'function'  ;
  PROGRAM   = 'program'   ;
  TRUE    = 'true'        ;
  FALSE   = 'false'       ;
}


@lexer::namespace { MathExpr }
@parser::namespace { MathExpr }


WS:
  ( ' ' | '\t' | '\f' | '\r' | '\n' )+ {
    $channel=HIDDEN;
  }
;


ML_COMMENT:
  '/*' ( options { greedy=false; } : . )* '*/' {
    $channel=HIDDEN;
  }
;


NUMBER: ('0'..'9')+ ('.' ('0'..'9')+)?
;
IDENT:  ( 'a'..'z' | 'A'..'Z' | '_' )
        ( 'a'..'z' | 'A'..'Z' | '_' | '0'..'9' )*
;
ADD:     '+'    ;
SUB:     '-'    ;
MUL:     '*'    ;
DIV:     '/'    ;
BIT_AND: '&'    ;
BIT_OR:  '|'    ;
ASSIGN:	'='    ;
GE:       '>='  ;
LE:       '<='  ;
NEQUALS:  '<>'  ;
EQUALS:   '=='   ;
GT:       '>'   ;
LT:       '<'   ;


ident: IDENT ;


params_: ( term (','! term)* )?  ;
call: ident '(' params_ ')'  -> ^(CALL ident ^(PARAMS params_?)) ;

group:
  '('! term ')'!
| NUMBER
| TRUE
| FALSE
| ident
| call
;


not:   group | NOT^ not ;
mult:  not ( ( MUL | DIV | BIT_AND | INT_DIV | INT_MOD )^ not )*  ;
add:   mult  ( ( ADD | SUB | BIT_OR )^ mult  )*                   ;
compare: add ( ( GE | LE | NEQUALS | EQUALS | GT | LT )^ add )?   ;
and_logic: compare ( AND^ compare )*    ;
or_logic: and_logic ( OR^ and_logic )*  ;
term: or_logic  ;

varDecl: ident (ASSIGN^ term)?;
varsDecl: ident varDecl ( ',' varDecl )* -> ^(VAR ^(ident varDecl+)) ;



expr0:
  ident ASSIGN^ term
| ident -> ^(CALL ident PARAMS)
| call
| varsDecl
;
blockExpr: '{'! exprList '}'! ;
termOrTrue: 
  term
| ( ) -> TRUE
;
expr:
  expr0 ';'!
| IF^ '('! term ')'! expr (ELSE! expr)?
| WHILE^ '('! term ')'! expr
| FOR^ '('! exprList2 ';'! termOrTrue ';'! exprList2 ')'! expr
| REPEAT^ expr UNTIL! term
| RETURN^ term ';'!
| call ';'! 
| blockExpr
;
  
exprList: ( expr ( ';'* expr )* )? ';'*  ->  ^(BLOCK expr*)  ;
exprList2: ( expr0 ( ',' expr0 )* )?  ->  ^(BLOCK expr0*)  ;

paramDecl: ident^ ident ;
paramsDecl: paramDecl ( ','! paramDecl )* ;
funcDecl:
  t=ident n=ident '(' paramsDecl? ')'
  '{' exprList '}'
  -> ^(FUNCTION $t $n ^(PARAMS paramsDecl*) exprList)
;

exprOrFuncDecl: funcDecl | expr ;

program: ( exprOrFuncDecl ';'!* )* ;

result: program -> ^(PROGRAM program) ;

execute:
  result
;
