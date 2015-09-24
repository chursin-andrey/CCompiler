grammar CCompiler;

options {
  language=CSharp3;
  output=AST;
  backtrack=true;
  memoize=true;
}
 

tokens {
  RETURN = 'return' ;
  IF     = 'if'     ;
  ELSE   = 'else'   ;
  WHILE  = 'while'  ;
  DO	 = 'do'		;
  
  INCLUDE           ;
  TYPE              ;
  ARGS_DECL         ;
  FUNC_DECL         ;
  ARGS              ;
  CALL              ;
  BLOCK             ;
  INDEX             ;
  
  DO	= 'do'		  ;
  UNKNOWN             ;
  BLOCK               ;
  PARAMETERS          ;
  CALL                ;
  CONVERT             ;
  AND     = '&&'     ;
  OR      = '||'      ;
  NOT     = '!'     ;
  XOR     = 'xor'     ;
  INT_DIV = 'div'     ;
  INT_MOD = 'mod'     ;
  SHR     = 'shr'     ;
  SHL     = 'shl'     ;
  IN      = 'in'      ;
  VAR     = 'var'     ;
  RETURN  = 'return'  ;
  ARRAY = 'array'	;
  CAPACITY = 'capacity'	;
  FUNCTION  = 'function'  ;
  PROGRAM   = 'program'   ;
  TRUE    = 'true'        ;
  FALSE   = 'false'       ;
}
 

WS:
  (' ' | '\t' | '\f' | '\r' | '\n')+ { $channel=HIDDEN; }
;

ML_COMMENT:
  '/*' ( options { greedy=false; } : . )* '*/' {
    $channel=HIDDEN;
  }
;

NUMBER: ('0'..'9')+ ('.' ('0'..'9')+)?
;
IDENTIFIER:  ( 'a'..'z' | 'A'..'Z' | '_' )
        ( 'a'..'z' | 'A'..'Z' | '_' | '0'..'9' )*
;

/*
fragment DIGIT:
  '0'..'9'
;
 
fragment LETTER:
  'a'..'z' | 'A'..'Z' | '_';
 
NUMBER:
  DIGIT+ ('.' DIGIT+)?;
*/

STRING:
  '"' ('\\"' | '\\\\' | ~'"')* '"';

INCLUDE_STRING:
  '<' ~'>'* '>';

/* 
IDENT:
  LETTER (LETTER | DIGIT)*;
*
 
type0:
  IDENT ('[' ']')*;
type:
  type0  ->  TYPE[$type0.text];
*/

ADD:     '+'    ;
SUB:     '-'    ;
MUL:     '*'    ;
DIV:     '/'    ;
BIT_AND: '&'    ;
BIT_OR:  '|'    ;
ASSIGN:	 '='    ;
GE:       '>='  ;
LE:       '<='  ;
NOTEQUALS:  '!='  ;
EQUALS:   '=='   ;
GT:       '>'   ;
LT:       '<'   ;
 
identifier: IDENTIFIER ;

term:
  NUMBER
| STRING
| lvalue
| funcCall
| '('! logic ')'!
;
 
args:
  (rvalue (',' rvalue)*)?  ->  ^(ARGS rvalue*)
;
funcCall:
  IDENT '(' args ')'  ->  ^(CALL IDENT args)
;

arrayIndex0:
  '['  ->  INDEX["[]"]
;
lvalue:  
  IDENT (arrayIndex0^ rvalue ']'!)*
| IDENT
;
 
rvalue:
  logic
;
 
mult:
  term (( '*' | '/' )^ term)*
;
 
add:
  mult (('+' | '-')^ mult)*
;
 
logic:
  add (('==' | '!=' | '>' | '<' | '>=' | '<=')^ add)?
; 
 
expr:
  lvalue '='^ rvalue ';'!
| funcCall ';'!
| RETURN^ rvalue ';'!
| IF^ '('! rvalue ')'! expr (ELSE! expr)?
| WHILE^ '('! rvalue ')'! expr
| '{'! exprList '}'!
;
 
exprList:
  (expr ';'*)*  ->  ^(BLOCK expr*)
;

argDecl:
  type IDENT^
;
argsDecl:
  (argDecl (',' argDecl)*)?  ->  ^(ARGS_DECL argDecl*)
;
funcDecl:
  type IDENT '(' argsDecl ')' '{' exprList '}' ';'*
    ->  ^(FUNC_DECL IDENT type argsDecl exprList)
;
 
macroDecl:
  '#include' (s1=STRING | s2=INCLUDE_STRING)  ->  ^(INCLUDE $s1? $s2?)
;
 
decl:
  ( funcDecl | macroDecl )
;
 
declList:
  decl*
;
 
program:
  declList
;
 
start:
  program
  EOF
    ->  ^(PROGRAM program)
;
