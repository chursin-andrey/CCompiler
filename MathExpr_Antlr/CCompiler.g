grammar CCompiler;

options {
  language=CSharp3;
  output=AST;
  backtrack=true;
  memoize=true;
}

tokens {
  DO    =  'do'		;
  RETURN = 'return' ;
  IF     = 'if'     ;
  ELSE   = 'else'   ;
  WHILE  = 'while'  ;
  TRUE   = 'true'	;
  FALSE  = 'false'	;
  FOR	 = 'for'	;
  VAR	 = 'var'	;
  AND     = '&&'    ;
  OR      = '||'    ;

  PROGRAM           ;
  INCLUDE			;
  TYPE              ;
  ARGS_DECL         ;
  FUNC_DECL         ;
  ARGS              ;
  CALL              ;
  BLOCK             ;
  INDEX             ;
  UNKNOWN           ;
}


NOT:	 '!'	;
ADD:     '+'    ;
SUB:     '-'    ;
MUL:     '*'    ;
DIV:     '/'    ;
BIT_AND: '&'    ;
BIT_OR:  '|'    ;
ASSIGN : '='
	| '*='
	| '/='
	| '%='
	| '+='
	| '-='
	| '<<='
	| '>>='
	| '&='
	| '^='
	| '|='
	;
GE:       '>='  ;
LE:       '<='  ;
NE:  '!='  ;
EQ:   '=='   ;
GT:       '>'   ;
LT:       '<'   ;
 

WS  :  (' '|'\r'|'\t'|'\u000C'|'\n') {$channel=Hidden;}
    ;


ML_COMMENT:
  '/*' ( options { greedy=false; } : . )* '*/' {
    $channel=Hidden;
  }
;

LINE_COMMENT
    : '//' ~('\n'|'\r')* '\r'? '\n' {$channel=Hidden;}
    ;
 
fragment DIGIT:
  '0'..'9'
;
 
fragment LETTER:
  'a'..'z' | 'A'..'Z' | '_'
;
 
NUMBER:
  DIGIT+ ('.' DIGIT+)?
;
 
fragment
EscapeSequence
    :   '\\' ('b'|'t'|'n'|'f'|'r'|'\"'|'\''|'\\')
    |   OctalEscape
    ;
	
fragment
OctalEscape
    :   '\\' ('0'..'3') ('0'..'7') ('0'..'7')
    |   '\\' ('0'..'7') ('0'..'7')
    |   '\\' ('0'..'7')
    ;


STRING:
  '"' ( EscapeSequence | ~('\\'|'"') )* '"'
;

INCLUDE_STRING:
  '<' ~'>'* '>'
;

SEMI: ';';
COMMA: ',';


IDENT:
  LETTER (LETTER | DIGIT)*
;

ident: IDENT ;

/*
MACRO_TEXT:  ( ~'\n' )*   ;
DEFINE_TOKEN: '#define' WS IDENT WS MACRO_TEXT;
INCLUDE_TOKEN:  '#include' (WS)? STRING;
IFDEF_TOKEN: ('ifdef' | '#ifndef') WS IDENT;
ELSE_TOKEN: ('else' | 'elsif' WS IDENT);            
*/



type0:
  IDENT ('[' ']')*
;
type:
  type0  ->  TYPE[$type0.text]
;
 

/*
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
*/

args:
  (term (',' term)*)?  ->  ^(ARGS term*)
;

funcCall:
  IDENT '(' args ')'  ->  ^(CALL IDENT args)
;

arrayIndex0:
  '['  ->  INDEX["[]"]
;

params_: ( term (','! term)* )?  ;
call: ident '(' params_ ')'  -> ^(CALL ident ^(ARGS params_?)) ;


group:
  '('! term ')'!
| NUMBER
| TRUE
| FALSE
| ident
| call
;

not:   group | NOT^ not ;
mult:  not ( ( MUL)^ not )*  ;
add:   mult  ( ( ADD | SUB | BIT_OR )^ mult  )*                   ;
compare: add ( ( GE | LE | NE | EQ | GT | LT )^ add )?   ;
and_logic: compare ( AND^ compare )*    ;
or_logic: and_logic ( OR^ and_logic )*  ;
term: or_logic  ;


/*
lvalue:  
  IDENT (arrayIndex0^ rvalue ']'!)*
| IDENT
| call
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
*/
 
varDecl: ident (ASSIGN^ term)?;
varsDecl: ident varDecl ( ',' varDecl )* -> ^(VAR ^(ident varDecl+)) ;


expr0:
  ident ASSIGN^ term
| ident -> ^(CALL ident ARGS)
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
| DO^ expr WHILE! term
| RETURN^ term ';'!
| call ';'! 
| blockExpr
;

/*
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
*/

exprList: ( expr ( ';'* expr )* )? ';'*  ->  ^(BLOCK expr*)  ;
exprList2: ( expr0 ( ',' expr0 )* )?  ->  ^(BLOCK expr0*)  ;

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
  ( funcDecl | macroDecl)
;				   
 
declList:
  decl*
;
 
program:
  declList
;
 
public execute:
  program
  EOF
    ->  ^(PROGRAM program)
;

