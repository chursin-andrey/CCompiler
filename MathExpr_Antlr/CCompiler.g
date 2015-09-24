grammar CCompiler;

options {
  language=CSharp3;
  output=AST;
  backtrack=true;
}


tokens {
  DO	 = 'do'		  ;
  UNKNOWN             ;
  BLOCK               ;
  PARAMETERS          ;
  CALL                ;
  CONVERT             ;
  IF      = 'if'      ;
  ELSE    = 'else'    ;
  FOR     = 'for'     ;
  WHILE   = 'while'   ;
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
  ( ' ' | '\t' | '\f' | '\r' | '\n' )+ {
    $channel=Hidden;
  }
;


ML_COMMENT:
  '/*' ( options { greedy=false; } : . )* '*/' {
    $channel=Hidden;
  }
;


NUMBER: ('0'..'9')+ ('.' ('0'..'9')+)?
;
IDENTIFIER:  ( 'a'..'z' | 'A'..'Z' | '_' )
        ( 'a'..'z' | 'A'..'Z' | '_' | '0'..'9' )*
;

/*
declaration_specifiers
	:   (   storage_class_specifier
		|   type_specifier
        |   type_qualifier
        )+
	;

init_declarator
	: declarator ('=' initializer)?
	;

init_declarator_list
	: init_declarator (',' init_declarator)*
	;

storage_class_specifier
	: 'extern'
	| 'static'
	| 'auto'
	| 'register'
	;

type_specifier
	: 'void'
	| 'char'
	| 'short'
	| 'int'
	| 'long'
	| 'float'
	| 'double'
	| 'signed'
	| 'unsigned'
	| struct_or_union
	| enum_specifier
	;

struct_or_union
	: 'struct'
	| 'union'
	;

struct_declaration_list
	: struct_declaration+
	;
struct_declaration
	: specifier_qualifier_list struct_declarator_list ';'
	;
specifier_qualifier_list
	: ( type_qualifier | type_specifier )+
	;
struct_declarator_list
	: struct_declarator (',' struct_declarator)*
	;
struct_declarator
	: declarator (':' constant_expression)?
	| ':' constant_expression
	;

enum_specifier
options {k=3;}
	: 'enum' '{' enumerator_list '}'
	| 'enum' IDENTIFIER '{' enumerator_list '}'
	| 'enum' IDENTIFIER
	;
enumerator_list
	: enumerator (',' enumerator)*
	;
enumerator
	: IDENTIFIER ('=' constant_expression)?
	;

type_qualifier
	: 'const'
	| 'volatile'
	;

declarator
	: pointer? direct_declarator
	| pointer
	;

direct_declarator
	:   (	IDENTIFIER
		|	'(' declarator ')'
		)
        declarator_suffix*
	;

declarator_suffix
	:   '[' constant_expression ']'
    |   '[' ']'
    |   '(' parameter_type_list ')'
    |   '(' identifier_list ')'
    |   '(' ')'
	;

pointer
	: '*' type_qualifier+ pointer?
	| '*' pointer
	| '*'
	;

abstract_declarator
	: pointer direct_abstract_declarator?
	| direct_abstract_declarator
	;

parameter_type_list
	: parameter_list (',' '...')?
	;
parameter_list
	: parameter_declaration (',' parameter_declaration)*
	;

parameter_declaration
	: declaration_specifiers (declarator|abstract_declarator)*
	;

identifier_list
	: IDENTIFIER (',' IDENTIFIER)*
	;

type_name
	: specifier_qualifier_list abstract_declarator?
	;

abstract_declarator_suffix
	:	'[' ']'
	|	'[' constant_expression ']'
	|	'(' ')'
	|	'(' parameter_type_list ')'
	;

initializer
	: assignment_expression
	| '{' initializer_list ','? '}'
	;

initializer_list
	: initializer (',' initializer)*
	;

// E x p r e s s i o n s

argument_expression_list
	:   assignment_expression (',' assignment_expression)*
	;

direct_abstract_declarator
	:	( '(' abstract_declarator ')' | abstract_declarator_suffix ) abstract_declarator_suffix*
	;

constant_expression
	: conditional_expression
	;

additive_expression
	: (multiplicative_expression) ('+' multiplicative_expression | '-' multiplicative_expression)*
	;

multiplicative_expression
	: (cast_expression) ('*' cast_expression | '/' cast_expression | '%' cast_expression)*
	;

cast_expression
	: '(' type_name ')' cast_expression
	| unary_expression
	;

unary_expression
	: postfix_expression
	| '++' unary_expression
	| '--' unary_expression
	| unary_operator cast_expression
	| 'sizeof' unary_expression
	| 'sizeof' '(' type_name ')'
	;

postfix_expression
	:   primary_expression
        (   '[' expression ']'
        |   '(' ')'
        |   '(' argument_expression_list ')'
        |   '.' IDENTIFIER
        |   '->' IDENTIFIER
        |   '++'
        |   '--'
        )*
	;

unary_operator
	: '&'
	| '*'
	| '+'
	| '-'
	| '~'
	| '!'
	;

primary_expression
	: IDENTIFIER
	| constant
	| '(' expression ')'
	;

expression
	: assignment_expression (',' assignment_expression)*
	;

assignment_expression
	: lvalue assignment_operator assignment_expression
	| conditional_expression
	;
	
lvalue
	:	unary_expression
	;
assignment_operator
	: '='
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

conditional_expression
	: logical_or_expression ('?' expression ':' conditional_expression)?
	;

logical_or_expression
	: logical_and_expression ('||' logical_and_expression)*
	;

logical_and_expression
	: inclusive_or_expression ('&&' inclusive_or_expression)*
	;

inclusive_or_expression
	: exclusive_or_expression ('|' exclusive_or_expression)*
	;

exclusive_or_expression
	: and_expression ('^' and_expression)*
	;
and_expression
	: equality_expression ('&' equality_expression)*
	;
equality_expression
	: relational_expression (('=='|'!=') relational_expression)*
	;
relational_expression
	: shift_expression (('<'|'>'|'<='|'>=') shift_expression)*
	;
shift_expression
	: additive_expression (('<<'|'>>') additive_expression)*
	;

// S t a t e m e n t s
statement
	: labeled_statement
	| expression_statement
	| selection_statement
	| iteration_statement
	| jump_statement
	;
labeled_statement
	: IDENTIFIER ':' statement
	| 'case' constant_expression ':' statement
	| 'default' ':' statement
	;

statement_list
	: statement+
	;

expression_statement
	: ';'
	| expression ';'
	;

selection_statement
	: 'if' '(' expression ')' statement (options {k=1; backtrack=false;}:'else' statement)?
	| 'switch' '(' expression ')' statement
	;

iteration_statement
	: 'while' '(' expression ')' statement
	| 'do' statement 'while' '(' expression ')' ';'
	| 'for' '(' expression_statement expression_statement expression? ')' statement
	;

jump_statement
	: 'goto' IDENTIFIER ';'
	| 'continue' ';'
	| 'break' ';'
	| 'return' ';'
	| 'return' expression ';'
	;

constant
    :   HEX_LITERAL
    |   OCTAL_LITERAL
    |   DECIMAL_LITERAL
    |	CHARACTER_LITERAL
	|	STRING_LITERAL
    |   FLOATING_POINT_LITERAL
    ;

CHARACTER_LITERAL
    :   '\'' ( EscapeSequence | ~('\''|'\\') ) '\''
    ;

STRING_LITERAL
    :  '"' ( EscapeSequence | ~('\\'|'"') )* '"'
    ;

HEX_LITERAL : '0' ('x'|'X') HexDigit+ IntegerTypeSuffix? ;

DECIMAL_LITERAL : ('0' | '1'..'9' '0'..'9'*) IntegerTypeSuffix? ;

OCTAL_LITERAL : '0' ('0'..'7')+ IntegerTypeSuffix? ;

fragment
HexDigit : ('0'..'9'|'a'..'f'|'A'..'F') ;

fragment
IntegerTypeSuffix
	:	('u'|'U')? ('l'|'L')
	|	('u'|'U')  ('l'|'L')?
	;

FLOATING_POINT_LITERAL
    :   ('0'..'9')+ '.' ('0'..'9')* Exponent? FloatTypeSuffix?
    |   '.' ('0'..'9')+ Exponent? FloatTypeSuffix?
    |   ('0'..'9')+ Exponent FloatTypeSuffix?
    |   ('0'..'9')+ Exponent? FloatTypeSuffix
	;

fragment
Exponent : ('e'|'E') ('+'|'-')? ('0'..'9')+ ;

fragment
FloatTypeSuffix : ('f'|'F'|'d'|'D') ;

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

fragment
UnicodeEscape
    :   '\\' 'u' HexDigit HexDigit HexDigit HexDigit
    ;

*/

ADD:     '+'    ;
SUB:     '-'    ;
MUL:     '*'    ;
DIV:     '/'    ;
BIT_AND: '&'    ;
BIT_OR:  '|'    ;
ASSIGN: '='		;
GE:       '>='  ;
LE:       '<='  ;
NOTEQUALS:  '!='  ;
EQUALS:   '=='   ;
GT:       '>'   ;
LT:       '<'   ;


identifier: IDENTIFIER ;


parameters: ( term (','! term)* )?  ;
call: identifier '(' parameters ')'  -> ^(CALL identifier ^(PARAMETERS parameters?)) ;

group:
  '('! term ')'!
| NUMBER
| TRUE
| FALSE
| identifier
| call
;


not:   group | NOT^ not ;
multiplex:  not ( ( MUL | DIV | BIT_AND | INT_DIV | INT_MOD )^ not )*  ;
add:   multiplex  ( ( ADD | SUB | BIT_OR )^ multiplex  )*                   ;
compare: add ( ( GE | LE | NOTEQUALS | EQUALS | GT | LT )^ add )?   ;
and_logic: compare ( AND^ compare )*    ;
or_logic: and_logic ( OR^ and_logic )*  ;
term: or_logic  ;

variableDeclaration: identifier (ASSIGN^ term)?;
variablesDeclaration: identifier variableDeclaration ( ',' variableDeclaration )* -> ^(VAR ^(identifier variableDeclaration+)) ;

expr0:
  identifier ASSIGN^ term
  | call
  | variablesDeclaration
;
blockExpr: '{'! expressionsList '}'! ;

termOrTrue:
  term
  | ( ) -> TRUE
;
expr:
  expr0 ';'!
| IF^ '('! term ')'! expr (ELSE! expr)?
| WHILE^ '('! term ')'! expr
| FOR^ '('! expressionsList2 ';'! termOrTrue ';'! expressionsList2 ')'! expr
| DO^ expr WHILE '(' term ')'
| RETURN^ term ';'!
| call ';'!
| blockExpr
| array_declaration
;


expressionsList: ( expr ( ';'* expr )* )? ';'*  ->  ^(BLOCK expr*)  ;
expressionsList2: ( expr0 ( ',' expr0 )* )?  ->  ^(BLOCK expr0*)  ;

array_type: identifier '[' term? ']' -> ^(ARRAY identifier ^(CAPACITY term?) );
array_initialising: identifier ('<' term (',' term)* '>')? -> ^(identifier term*);
array_declaration:
  array_type array_initialising (',' array_initialising)* -> ^(array_type array_initialising+)
;

parametersDeclaration: identifier^ identifier ;
parametersDeclarations: parametersDeclaration ( ','! parametersDeclaration )* ;
func_return_type: identifier;
functionDeclarations:
 func_return_type identifier '(' parametersDeclarations? ')'
  '{' expressionsList '}'
  -> ^(FUNCTION func_return_type identifier ^(PARAMETERS parametersDeclarations?) expressionsList)
;

/*
macroDecl:
  '#include' (s1=STRING | s2=INCLUDE_STRING);
*/

exprOrFuncDeclaration: functionDeclarations | expr /*| macroDecl */;

program: ( exprOrFuncDeclaration ';'!* )* ;

result: program -> ^(PROGRAM program) ;

public execute:
  result
;