// $ANTLR 3.2 Sep 23, 2009 12:02:23 MathExpr.g 2015-10-06 15:46:43

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


namespace  MathExpr 
{
public partial class MathExprLexer : Lexer {
    public const int SHR = 23;
    public const int FUNCTION = 29;
    public const int LT = 49;
    public const int WHILE = 12;
    public const int BIT_AND = 41;
    public const int SHL = 24;
    public const int FOR = 11;
    public const int SUB = 38;
    public const int EQUALS = 47;
    public const int NOT = 19;
    public const int AND = 17;
    public const int EOF = -1;
    public const int NEQUALS = 46;
    public const int IF = 9;
    public const int T__55 = 55;
    public const int ML_COMMENT = 34;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int IN = 25;
    public const int T__53 = 53;
    public const int BIT_OR = 42;
    public const int UNKNOWN = 4;
    public const int T__54 = 54;
    public const int BEGIN = 15;
    public const int INT_DIV = 21;
    public const int RETURN = 27;
    public const int IDENT = 36;
    public const int VAR = 26;
    public const int T__50 = 50;
    public const int ADD = 37;
    public const int PARAMS = 6;
    public const int INT_MOD = 22;
    public const int GE = 44;
    public const int XOR = 20;
    public const int CONVERT = 8;
    public const int ELSE = 10;
    public const int NUMBER = 35;
    public const int MUL = 39;
    public const int TRUE = 31;
    public const int PROCEDURE = 28;
    public const int WS = 33;
    public const int UNTIL = 14;
    public const int BLOCK = 5;
    public const int OR = 18;
    public const int ASSIGN = 43;
    public const int GT = 48;
    public const int PROGRAM = 30;
    public const int REPEAT = 13;
    public const int CALL = 7;
    public const int DIV = 40;
    public const int END = 16;
    public const int FALSE = 32;
    public const int LE = 45;

    // delegates
    // delegators

    public MathExprLexer() 
    {
		InitializeCyclicDFAs();
    }
    public MathExprLexer(ICharStream input)
		: this(input, null) {
    }
    public MathExprLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "MathExpr.g";} 
    }

    // $ANTLR start "IF"
    public void mIF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:9:4: ( 'if' )
            // MathExpr.g:9:6: 'if'
            {
            	Match("if"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IF"

    // $ANTLR start "ELSE"
    public void mELSE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ELSE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:10:6: ( 'else' )
            // MathExpr.g:10:8: 'else'
            {
            	Match("else"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ELSE"

    // $ANTLR start "FOR"
    public void mFOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:11:5: ( 'for' )
            // MathExpr.g:11:7: 'for'
            {
            	Match("for"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FOR"

    // $ANTLR start "WHILE"
    public void mWHILE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHILE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:12:7: ( 'while' )
            // MathExpr.g:12:9: 'while'
            {
            	Match("while"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHILE"

    // $ANTLR start "REPEAT"
    public void mREPEAT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = REPEAT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:13:8: ( 'repeat' )
            // MathExpr.g:13:10: 'repeat'
            {
            	Match("repeat"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "REPEAT"

    // $ANTLR start "UNTIL"
    public void mUNTIL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UNTIL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:14:7: ( 'until' )
            // MathExpr.g:14:9: 'until'
            {
            	Match("until"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UNTIL"

    // $ANTLR start "BEGIN"
    public void mBEGIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BEGIN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:15:7: ( 'begin' )
            // MathExpr.g:15:9: 'begin'
            {
            	Match("begin"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BEGIN"

    // $ANTLR start "END"
    public void mEND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:16:5: ( 'end' )
            // MathExpr.g:16:7: 'end'
            {
            	Match("end"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "END"

    // $ANTLR start "AND"
    public void mAND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:17:5: ( 'and' )
            // MathExpr.g:17:7: 'and'
            {
            	Match("and"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AND"

    // $ANTLR start "OR"
    public void mOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:18:4: ( 'or' )
            // MathExpr.g:18:6: 'or'
            {
            	Match("or"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OR"

    // $ANTLR start "NOT"
    public void mNOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:19:5: ( 'not' )
            // MathExpr.g:19:7: 'not'
            {
            	Match("not"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NOT"

    // $ANTLR start "XOR"
    public void mXOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = XOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:20:5: ( 'xor' )
            // MathExpr.g:20:7: 'xor'
            {
            	Match("xor"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "XOR"

    // $ANTLR start "INT_DIV"
    public void mINT_DIV() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT_DIV;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:21:9: ( 'div' )
            // MathExpr.g:21:11: 'div'
            {
            	Match("div"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT_DIV"

    // $ANTLR start "INT_MOD"
    public void mINT_MOD() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT_MOD;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:22:9: ( 'mod' )
            // MathExpr.g:22:11: 'mod'
            {
            	Match("mod"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT_MOD"

    // $ANTLR start "SHR"
    public void mSHR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SHR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:23:5: ( 'shr' )
            // MathExpr.g:23:7: 'shr'
            {
            	Match("shr"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SHR"

    // $ANTLR start "SHL"
    public void mSHL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SHL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:24:5: ( 'shl' )
            // MathExpr.g:24:7: 'shl'
            {
            	Match("shl"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SHL"

    // $ANTLR start "IN"
    public void mIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:25:4: ( 'in' )
            // MathExpr.g:25:6: 'in'
            {
            	Match("in"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IN"

    // $ANTLR start "VAR"
    public void mVAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:26:5: ( 'var' )
            // MathExpr.g:26:7: 'var'
            {
            	Match("var"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "VAR"

    // $ANTLR start "RETURN"
    public void mRETURN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RETURN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:27:8: ( 'return' )
            // MathExpr.g:27:10: 'return'
            {
            	Match("return"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RETURN"

    // $ANTLR start "PROCEDURE"
    public void mPROCEDURE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PROCEDURE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:28:11: ( 'procedure' )
            // MathExpr.g:28:13: 'procedure'
            {
            	Match("procedure"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PROCEDURE"

    // $ANTLR start "FUNCTION"
    public void mFUNCTION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FUNCTION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:29:10: ( 'function' )
            // MathExpr.g:29:12: 'function'
            {
            	Match("function"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FUNCTION"

    // $ANTLR start "PROGRAM"
    public void mPROGRAM() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PROGRAM;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:30:9: ( 'program' )
            // MathExpr.g:30:11: 'program'
            {
            	Match("program"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PROGRAM"

    // $ANTLR start "TRUE"
    public void mTRUE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TRUE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:31:6: ( 'true' )
            // MathExpr.g:31:8: 'true'
            {
            	Match("true"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TRUE"

    // $ANTLR start "FALSE"
    public void mFALSE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FALSE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:32:7: ( 'false' )
            // MathExpr.g:32:9: 'false'
            {
            	Match("false"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FALSE"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:33:7: ( ',' )
            // MathExpr.g:33:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:34:7: ( '(' )
            // MathExpr.g:34:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:35:7: ( ')' )
            // MathExpr.g:35:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:36:7: ( '{' )
            // MathExpr.g:36:9: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public void mT__54() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__54;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:37:7: ( '}' )
            // MathExpr.g:37:9: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:38:7: ( ';' )
            // MathExpr.g:38:9: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__55"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:50:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
            // MathExpr.g:51:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
            {
            	// MathExpr.g:51:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '\t' && LA1_0 <= '\n') || (LA1_0 >= '\f' && LA1_0 <= '\r') || LA1_0 == ' ') )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // MathExpr.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || (input.LA(1) >= '\f' && input.LA(1) <= '\r') || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            	    _channel=HIDDEN;
            	  

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "ML_COMMENT"
    public void mML_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ML_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:57:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
            // MathExpr.g:58:3: '/*' ( options {greedy=false; } : . )* '*/'
            {
            	Match("/*"); 

            	// MathExpr.g:58:8: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == '*') )
            	    {
            	        int LA2_1 = input.LA(2);

            	        if ( (LA2_1 == '/') )
            	        {
            	            alt2 = 2;
            	        }
            	        else if ( ((LA2_1 >= '\u0000' && LA2_1 <= '.') || (LA2_1 >= '0' && LA2_1 <= '\uFFFF')) )
            	        {
            	            alt2 = 1;
            	        }


            	    }
            	    else if ( ((LA2_0 >= '\u0000' && LA2_0 <= ')') || (LA2_0 >= '+' && LA2_0 <= '\uFFFF')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // MathExpr.g:58:38: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	Match("*/"); 


            	    _channel=HIDDEN;
            	  

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ML_COMMENT"

    // $ANTLR start "NUMBER"
    public void mNUMBER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NUMBER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:64:7: ( ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )? )
            // MathExpr.g:64:9: ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )?
            {
            	// MathExpr.g:64:9: ( '0' .. '9' )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // MathExpr.g:64:10: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt3 >= 1 ) goto loop3;
            		            EarlyExitException eee3 =
            		                new EarlyExitException(3, input);
            		            throw eee3;
            	    }
            	    cnt3++;
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	// MathExpr.g:64:21: ( '.' ( '0' .. '9' )+ )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == '.') )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // MathExpr.g:64:22: '.' ( '0' .. '9' )+
            	        {
            	        	Match('.'); 
            	        	// MathExpr.g:64:26: ( '0' .. '9' )+
            	        	int cnt4 = 0;
            	        	do 
            	        	{
            	        	    int alt4 = 2;
            	        	    int LA4_0 = input.LA(1);

            	        	    if ( ((LA4_0 >= '0' && LA4_0 <= '9')) )
            	        	    {
            	        	        alt4 = 1;
            	        	    }


            	        	    switch (alt4) 
            	        		{
            	        			case 1 :
            	        			    // MathExpr.g:64:27: '0' .. '9'
            	        			    {
            	        			    	MatchRange('0','9'); 

            	        			    }
            	        			    break;

            	        			default:
            	        			    if ( cnt4 >= 1 ) goto loop4;
            	        		            EarlyExitException eee4 =
            	        		                new EarlyExitException(4, input);
            	        		            throw eee4;
            	        	    }
            	        	    cnt4++;
            	        	} while (true);

            	        	loop4:
            	        		;	// Stops C# compiler whining that label 'loop4' has no statements


            	        }
            	        break;

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NUMBER"

    // $ANTLR start "IDENT"
    public void mIDENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IDENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:66:6: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )* )
            // MathExpr.g:66:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// MathExpr.g:67:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= '0' && LA6_0 <= '9') || (LA6_0 >= 'A' && LA6_0 <= 'Z') || LA6_0 == '_' || (LA6_0 >= 'a' && LA6_0 <= 'z')) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // MathExpr.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IDENT"

    // $ANTLR start "ADD"
    public void mADD() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ADD;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:69:4: ( '+' )
            // MathExpr.g:69:10: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ADD"

    // $ANTLR start "SUB"
    public void mSUB() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SUB;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:70:4: ( '-' )
            // MathExpr.g:70:10: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SUB"

    // $ANTLR start "MUL"
    public void mMUL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MUL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:71:4: ( '*' )
            // MathExpr.g:71:10: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MUL"

    // $ANTLR start "DIV"
    public void mDIV() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIV;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:72:4: ( '/' )
            // MathExpr.g:72:10: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIV"

    // $ANTLR start "BIT_AND"
    public void mBIT_AND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BIT_AND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:73:8: ( '&' )
            // MathExpr.g:73:10: '&'
            {
            	Match('&'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BIT_AND"

    // $ANTLR start "BIT_OR"
    public void mBIT_OR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BIT_OR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:74:7: ( '|' )
            // MathExpr.g:74:10: '|'
            {
            	Match('|'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BIT_OR"

    // $ANTLR start "ASSIGN"
    public void mASSIGN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASSIGN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:75:7: ( '=' )
            // MathExpr.g:75:9: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ASSIGN"

    // $ANTLR start "GE"
    public void mGE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:76:3: ( '>=' )
            // MathExpr.g:76:11: '>='
            {
            	Match(">="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GE"

    // $ANTLR start "LE"
    public void mLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:77:3: ( '<=' )
            // MathExpr.g:77:11: '<='
            {
            	Match("<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LE"

    // $ANTLR start "NEQUALS"
    public void mNEQUALS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEQUALS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:78:8: ( '<>' )
            // MathExpr.g:78:11: '<>'
            {
            	Match("<>"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEQUALS"

    // $ANTLR start "EQUALS"
    public void mEQUALS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EQUALS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:79:7: ( '==' )
            // MathExpr.g:79:11: '=='
            {
            	Match("=="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EQUALS"

    // $ANTLR start "GT"
    public void mGT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:80:3: ( '>' )
            // MathExpr.g:80:11: '>'
            {
            	Match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GT"

    // $ANTLR start "LT"
    public void mLT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:81:3: ( '<' )
            // MathExpr.g:81:11: '<'
            {
            	Match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LT"

    override public void mTokens() // throws RecognitionException 
    {
        // MathExpr.g:1:8: ( IF | ELSE | FOR | WHILE | REPEAT | UNTIL | BEGIN | END | AND | OR | NOT | XOR | INT_DIV | INT_MOD | SHR | SHL | IN | VAR | RETURN | PROCEDURE | FUNCTION | PROGRAM | TRUE | FALSE | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | WS | ML_COMMENT | NUMBER | IDENT | ADD | SUB | MUL | DIV | BIT_AND | BIT_OR | ASSIGN | GE | LE | NEQUALS | EQUALS | GT | LT )
        int alt7 = 47;
        alt7 = dfa7.Predict(input);
        switch (alt7) 
        {
            case 1 :
                // MathExpr.g:1:10: IF
                {
                	mIF(); 

                }
                break;
            case 2 :
                // MathExpr.g:1:13: ELSE
                {
                	mELSE(); 

                }
                break;
            case 3 :
                // MathExpr.g:1:18: FOR
                {
                	mFOR(); 

                }
                break;
            case 4 :
                // MathExpr.g:1:22: WHILE
                {
                	mWHILE(); 

                }
                break;
            case 5 :
                // MathExpr.g:1:28: REPEAT
                {
                	mREPEAT(); 

                }
                break;
            case 6 :
                // MathExpr.g:1:35: UNTIL
                {
                	mUNTIL(); 

                }
                break;
            case 7 :
                // MathExpr.g:1:41: BEGIN
                {
                	mBEGIN(); 

                }
                break;
            case 8 :
                // MathExpr.g:1:47: END
                {
                	mEND(); 

                }
                break;
            case 9 :
                // MathExpr.g:1:51: AND
                {
                	mAND(); 

                }
                break;
            case 10 :
                // MathExpr.g:1:55: OR
                {
                	mOR(); 

                }
                break;
            case 11 :
                // MathExpr.g:1:58: NOT
                {
                	mNOT(); 

                }
                break;
            case 12 :
                // MathExpr.g:1:62: XOR
                {
                	mXOR(); 

                }
                break;
            case 13 :
                // MathExpr.g:1:66: INT_DIV
                {
                	mINT_DIV(); 

                }
                break;
            case 14 :
                // MathExpr.g:1:74: INT_MOD
                {
                	mINT_MOD(); 

                }
                break;
            case 15 :
                // MathExpr.g:1:82: SHR
                {
                	mSHR(); 

                }
                break;
            case 16 :
                // MathExpr.g:1:86: SHL
                {
                	mSHL(); 

                }
                break;
            case 17 :
                // MathExpr.g:1:90: IN
                {
                	mIN(); 

                }
                break;
            case 18 :
                // MathExpr.g:1:93: VAR
                {
                	mVAR(); 

                }
                break;
            case 19 :
                // MathExpr.g:1:97: RETURN
                {
                	mRETURN(); 

                }
                break;
            case 20 :
                // MathExpr.g:1:104: PROCEDURE
                {
                	mPROCEDURE(); 

                }
                break;
            case 21 :
                // MathExpr.g:1:114: FUNCTION
                {
                	mFUNCTION(); 

                }
                break;
            case 22 :
                // MathExpr.g:1:123: PROGRAM
                {
                	mPROGRAM(); 

                }
                break;
            case 23 :
                // MathExpr.g:1:131: TRUE
                {
                	mTRUE(); 

                }
                break;
            case 24 :
                // MathExpr.g:1:136: FALSE
                {
                	mFALSE(); 

                }
                break;
            case 25 :
                // MathExpr.g:1:142: T__50
                {
                	mT__50(); 

                }
                break;
            case 26 :
                // MathExpr.g:1:148: T__51
                {
                	mT__51(); 

                }
                break;
            case 27 :
                // MathExpr.g:1:154: T__52
                {
                	mT__52(); 

                }
                break;
            case 28 :
                // MathExpr.g:1:160: T__53
                {
                	mT__53(); 

                }
                break;
            case 29 :
                // MathExpr.g:1:166: T__54
                {
                	mT__54(); 

                }
                break;
            case 30 :
                // MathExpr.g:1:172: T__55
                {
                	mT__55(); 

                }
                break;
            case 31 :
                // MathExpr.g:1:178: WS
                {
                	mWS(); 

                }
                break;
            case 32 :
                // MathExpr.g:1:181: ML_COMMENT
                {
                	mML_COMMENT(); 

                }
                break;
            case 33 :
                // MathExpr.g:1:192: NUMBER
                {
                	mNUMBER(); 

                }
                break;
            case 34 :
                // MathExpr.g:1:199: IDENT
                {
                	mIDENT(); 

                }
                break;
            case 35 :
                // MathExpr.g:1:205: ADD
                {
                	mADD(); 

                }
                break;
            case 36 :
                // MathExpr.g:1:209: SUB
                {
                	mSUB(); 

                }
                break;
            case 37 :
                // MathExpr.g:1:213: MUL
                {
                	mMUL(); 

                }
                break;
            case 38 :
                // MathExpr.g:1:217: DIV
                {
                	mDIV(); 

                }
                break;
            case 39 :
                // MathExpr.g:1:221: BIT_AND
                {
                	mBIT_AND(); 

                }
                break;
            case 40 :
                // MathExpr.g:1:229: BIT_OR
                {
                	mBIT_OR(); 

                }
                break;
            case 41 :
                // MathExpr.g:1:236: ASSIGN
                {
                	mASSIGN(); 

                }
                break;
            case 42 :
                // MathExpr.g:1:243: GE
                {
                	mGE(); 

                }
                break;
            case 43 :
                // MathExpr.g:1:246: LE
                {
                	mLE(); 

                }
                break;
            case 44 :
                // MathExpr.g:1:249: NEQUALS
                {
                	mNEQUALS(); 

                }
                break;
            case 45 :
                // MathExpr.g:1:257: EQUALS
                {
                	mEQUALS(); 

                }
                break;
            case 46 :
                // MathExpr.g:1:264: GT
                {
                	mGT(); 

                }
                break;
            case 47 :
                // MathExpr.g:1:267: LT
                {
                	mLT(); 

                }
                break;

        }

    }


    protected DFA7 dfa7;
	private void InitializeCyclicDFAs()
	{
	    this.dfa7 = new DFA7(this);
	}

    const string DFA7_eotS =
        "\x01\uffff\x11\x1b\x07\uffff\x01\x3a\x07\uffff\x01\x3c\x01\x3e"+
        "\x01\x41\x01\x42\x01\x43\x0a\x1b\x01\x4f\x08\x1b\x0b\uffff\x01\x1b"+
        "\x01\x5a\x01\x5b\x07\x1b\x01\x63\x01\uffff\x01\x64\x01\x65\x01\x66"+
        "\x01\x67\x01\x68\x01\x69\x01\x6a\x02\x1b\x01\x6e\x02\uffff\x07\x1b"+
        "\x08\uffff\x02\x1b\x01\x78\x01\uffff\x01\x1b\x01\x7a\x01\x7b\x02"+
        "\x1b\x01\x7e\x01\x7f\x02\x1b\x01\uffff\x01\x1b\x02\uffff\x01\u0083"+
        "\x01\u0084\x02\uffff\x03\x1b\x02\uffff\x01\x1b\x01\u0089\x01\u008a"+
        "\x01\x1b\x02\uffff\x01\u008c\x01\uffff";
    const string DFA7_eofS =
        "\u008d\uffff";
    const string DFA7_minS =
        "\x01\x09\x01\x66\x01\x6c\x01\x61\x01\x68\x01\x65\x01\x6e\x01\x65"+
        "\x01\x6e\x01\x72\x02\x6f\x01\x69\x01\x6f\x01\x68\x01\x61\x02\x72"+
        "\x07\uffff\x01\x2a\x07\uffff\x03\x3d\x02\x30\x01\x73\x01\x64\x01"+
        "\x72\x01\x6e\x01\x6c\x01\x69\x01\x70\x01\x74\x01\x67\x01\x64\x01"+
        "\x30\x01\x74\x01\x72\x01\x76\x01\x64\x01\x6c\x01\x72\x01\x6f\x01"+
        "\x75\x0b\uffff\x01\x65\x02\x30\x01\x63\x01\x73\x01\x6c\x01\x65\x01"+
        "\x75\x02\x69\x01\x30\x01\uffff\x07\x30\x01\x63\x01\x65\x01\x30\x02"+
        "\uffff\x01\x74\x02\x65\x01\x61\x01\x72\x01\x6c\x01\x6e\x08\uffff"+
        "\x01\x65\x01\x72\x01\x30\x01\uffff\x01\x69\x02\x30\x01\x74\x01\x6e"+
        "\x02\x30\x01\x64\x01\x61\x01\uffff\x01\x6f\x02\uffff\x02\x30\x02"+
        "\uffff\x01\x75\x01\x6d\x01\x6e\x02\uffff\x01\x72\x02\x30\x01\x65"+
        "\x02\uffff\x01\x30\x01\uffff";
    const string DFA7_maxS =
        "\x01\x7d\x02\x6e\x01\x75\x01\x68\x01\x65\x01\x6e\x01\x65\x01\x6e"+
        "\x01\x72\x02\x6f\x01\x69\x01\x6f\x01\x68\x01\x61\x02\x72\x07\uffff"+
        "\x01\x2a\x07\uffff\x02\x3d\x01\x3e\x02\x7a\x01\x73\x01\x64\x01\x72"+
        "\x01\x6e\x01\x6c\x01\x69\x02\x74\x01\x67\x01\x64\x01\x7a\x01\x74"+
        "\x01\x72\x01\x76\x01\x64\x02\x72\x01\x6f\x01\x75\x0b\uffff\x01\x65"+
        "\x02\x7a\x01\x63\x01\x73\x01\x6c\x01\x65\x01\x75\x02\x69\x01\x7a"+
        "\x01\uffff\x07\x7a\x01\x67\x01\x65\x01\x7a\x02\uffff\x01\x74\x02"+
        "\x65\x01\x61\x01\x72\x01\x6c\x01\x6e\x08\uffff\x01\x65\x01\x72\x01"+
        "\x7a\x01\uffff\x01\x69\x02\x7a\x01\x74\x01\x6e\x02\x7a\x01\x64\x01"+
        "\x61\x01\uffff\x01\x6f\x02\uffff\x02\x7a\x02\uffff\x01\x75\x01\x6d"+
        "\x01\x6e\x02\uffff\x01\x72\x02\x7a\x01\x65\x02\uffff\x01\x7a\x01"+
        "\uffff";
    const string DFA7_acceptS =
        "\x12\uffff\x01\x19\x01\x1a\x01\x1b\x01\x1c\x01\x1d\x01\x1e\x01"+
        "\x1f\x01\uffff\x01\x21\x01\x22\x01\x23\x01\x24\x01\x25\x01\x27\x01"+
        "\x28\x18\uffff\x01\x20\x01\x26\x01\x2d\x01\x29\x01\x2a\x01\x2e\x01"+
        "\x2b\x01\x2c\x01\x2f\x01\x01\x01\x11\x0b\uffff\x01\x0a\x0a\uffff"+
        "\x01\x08\x01\x03\x07\uffff\x01\x09\x01\x0b\x01\x0c\x01\x0d\x01\x0e"+
        "\x01\x0f\x01\x10\x01\x12\x03\uffff\x01\x02\x09\uffff\x01\x17\x01"+
        "\uffff\x01\x18\x01\x04\x02\uffff\x01\x06\x01\x07\x03\uffff\x01\x05"+
        "\x01\x13\x04\uffff\x01\x16\x01\x15\x01\uffff\x01\x14";
    const string DFA7_specialS =
        "\u008d\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x02\x18\x01\uffff\x02\x18\x12\uffff\x01\x18\x05\uffff\x01"+
            "\x1f\x01\uffff\x01\x13\x01\x14\x01\x1e\x01\x1c\x01\x12\x01\x1d"+
            "\x01\uffff\x01\x19\x0a\x1a\x01\uffff\x01\x17\x01\x23\x01\x21"+
            "\x01\x22\x02\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x01\x08"+
            "\x01\x07\x01\x1b\x01\x0c\x01\x02\x01\x03\x02\x1b\x01\x01\x03"+
            "\x1b\x01\x0d\x01\x0a\x01\x09\x01\x10\x01\x1b\x01\x05\x01\x0e"+
            "\x01\x11\x01\x06\x01\x0f\x01\x04\x01\x0b\x02\x1b\x01\x15\x01"+
            "\x20\x01\x16",
            "\x01\x24\x07\uffff\x01\x25",
            "\x01\x26\x01\uffff\x01\x27",
            "\x01\x2a\x0d\uffff\x01\x28\x05\uffff\x01\x29",
            "\x01\x2b",
            "\x01\x2c",
            "\x01\x2d",
            "\x01\x2e",
            "\x01\x2f",
            "\x01\x30",
            "\x01\x31",
            "\x01\x32",
            "\x01\x33",
            "\x01\x34",
            "\x01\x35",
            "\x01\x36",
            "\x01\x37",
            "\x01\x38",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x39",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x3b",
            "\x01\x3d",
            "\x01\x3f\x01\x40",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x44",
            "\x01\x45",
            "\x01\x46",
            "\x01\x47",
            "\x01\x48",
            "\x01\x49",
            "\x01\x4a\x03\uffff\x01\x4b",
            "\x01\x4c",
            "\x01\x4d",
            "\x01\x4e",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x50",
            "\x01\x51",
            "\x01\x52",
            "\x01\x53",
            "\x01\x55\x05\uffff\x01\x54",
            "\x01\x56",
            "\x01\x57",
            "\x01\x58",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x59",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x5c",
            "\x01\x5d",
            "\x01\x5e",
            "\x01\x5f",
            "\x01\x60",
            "\x01\x61",
            "\x01\x62",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x6b\x03\uffff\x01\x6c",
            "\x01\x6d",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "",
            "",
            "\x01\x6f",
            "\x01\x70",
            "\x01\x71",
            "\x01\x72",
            "\x01\x73",
            "\x01\x74",
            "\x01\x75",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x76",
            "\x01\x77",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "",
            "\x01\x79",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x7c",
            "\x01\x7d",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\u0080",
            "\x01\u0081",
            "",
            "\x01\u0082",
            "",
            "",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "",
            "",
            "\x01\u0085",
            "\x01\u0086",
            "\x01\u0087",
            "",
            "",
            "\x01\u0088",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\u008b",
            "",
            "",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            ""
    };

    static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
    static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
    static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
    static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
    static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
    static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
    static readonly short[][] DFA7_transition = DFA.UnpackEncodedStringArray(DFA7_transitionS);

    protected class DFA7 : DFA
    {
        public DFA7(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 7;
            this.eot = DFA7_eot;
            this.eof = DFA7_eof;
            this.min = DFA7_min;
            this.max = DFA7_max;
            this.accept = DFA7_accept;
            this.special = DFA7_special;
            this.transition = DFA7_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( IF | ELSE | FOR | WHILE | REPEAT | UNTIL | BEGIN | END | AND | OR | NOT | XOR | INT_DIV | INT_MOD | SHR | SHL | IN | VAR | RETURN | PROCEDURE | FUNCTION | PROGRAM | TRUE | FALSE | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | WS | ML_COMMENT | NUMBER | IDENT | ADD | SUB | MUL | DIV | BIT_AND | BIT_OR | ASSIGN | GE | LE | NEQUALS | EQUALS | GT | LT );"; }
        }

    }

 
    
}
}