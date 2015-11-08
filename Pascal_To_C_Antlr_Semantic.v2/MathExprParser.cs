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

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

using Antlr.Runtime.Tree;

namespace  MathExpr 
{
public partial class MathExprParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"UNKNOWN", 
		"BLOCK", 
		"PARAMS", 
		"CALL", 
		"CONVERT", 
		"IF", 
		"ELSE", 
		"FOR", 
		"WHILE", 
		"REPEAT", 
		"UNTIL", 
		"BEGIN", 
		"END", 
		"AND", 
		"OR", 
		"NOT", 
		"XOR", 
		"INT_DIV", 
		"INT_MOD", 
		"SHR", 
		"SHL", 
		"IN", 
		"VAR", 
		"RETURN", 
		"PROCEDURE", 
		"FUNCTION", 
		"PROGRAM", 
		"TRUE", 
		"FALSE", 
		"WS", 
		"ML_COMMENT", 
		"NUMBER", 
		"IDENT", 
		"ADD", 
		"SUB", 
		"MUL", 
		"DIV", 
		"BIT_AND", 
		"BIT_OR", 
		"ASSIGN", 
		"GE", 
		"LE", 
		"NEQUALS", 
		"EQUALS", 
		"GT", 
		"LT", 
		"','", 
		"'('", 
		"')'", 
		"'{'", 
		"'}'", 
		"';'"
    };

    public const int SHR = 23;
    public const int FUNCTION = 29;
    public const int LT = 49;
    public const int BIT_AND = 41;
    public const int WHILE = 12;
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



        public MathExprParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public MathExprParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[75+1];
             
             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return MathExprParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "MathExpr.g"; }
    }


    public class ident_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "ident"
    // MathExpr.g:84:1: ident : IDENT ;
    public MathExprParser.ident_return ident() // throws RecognitionException [1]
    {   
        MathExprParser.ident_return retval = new MathExprParser.ident_return();
        retval.Start = input.LT(1);
        int ident_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken IDENT1 = null;

        AstNode IDENT1_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 1) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:84:6: ( IDENT )
            // MathExpr.g:84:8: IDENT
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	IDENT1=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_ident876); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{IDENT1_tree = (AstNode)adaptor.Create(IDENT1);
            		adaptor.AddChild(root_0, IDENT1_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 1, ident_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "ident"

    public class params__return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "params_"
    // MathExpr.g:87:1: params_ : ( term ( ',' term )* )? ;
    public MathExprParser.params__return params_() // throws RecognitionException [1]
    {   
        MathExprParser.params__return retval = new MathExprParser.params__return();
        retval.Start = input.LT(1);
        int params__StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal3 = null;
        MathExprParser.term_return term2 = default(MathExprParser.term_return);

        MathExprParser.term_return term4 = default(MathExprParser.term_return);


        AstNode char_literal3_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:87:8: ( ( term ( ',' term )* )? )
            // MathExpr.g:87:10: ( term ( ',' term )* )?
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	// MathExpr.g:87:10: ( term ( ',' term )* )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == NOT || (LA2_0 >= TRUE && LA2_0 <= FALSE) || (LA2_0 >= NUMBER && LA2_0 <= IDENT) || LA2_0 == 51) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // MathExpr.g:87:12: term ( ',' term )*
            	        {
            	        	PushFollow(FOLLOW_term_in_params_887);
            	        	term2 = term();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term2.Tree);
            	        	// MathExpr.g:87:17: ( ',' term )*
            	        	do 
            	        	{
            	        	    int alt1 = 2;
            	        	    int LA1_0 = input.LA(1);

            	        	    if ( (LA1_0 == 50) )
            	        	    {
            	        	        alt1 = 1;
            	        	    }


            	        	    switch (alt1) 
            	        		{
            	        			case 1 :
            	        			    // MathExpr.g:87:18: ',' term
            	        			    {
            	        			    	char_literal3=(IToken)Match(input,50,FOLLOW_50_in_params_890); if (state.failed) return retval;
            	        			    	PushFollow(FOLLOW_term_in_params_893);
            	        			    	term4 = term();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term4.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop1;
            	        	    }
            	        	} while (true);

            	        	loop1:
            	        		;	// Stops C# compiler whining that label 'loop1' has no statements


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 2, params__StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "params_"

    public class call_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "call"
    // MathExpr.g:88:1: call : ident '(' params_ ')' -> ^( CALL ident ^( PARAMS ( params_ )? ) ) ;
    public MathExprParser.call_return call() // throws RecognitionException [1]
    {   
        MathExprParser.call_return retval = new MathExprParser.call_return();
        retval.Start = input.LT(1);
        int call_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal6 = null;
        IToken char_literal8 = null;
        MathExprParser.ident_return ident5 = default(MathExprParser.ident_return);

        MathExprParser.params__return params_7 = default(MathExprParser.params__return);


        AstNode char_literal6_tree=null;
        AstNode char_literal8_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_params_ = new RewriteRuleSubtreeStream(adaptor,"rule params_");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:88:5: ( ident '(' params_ ')' -> ^( CALL ident ^( PARAMS ( params_ )? ) ) )
            // MathExpr.g:88:7: ident '(' params_ ')'
            {
            	PushFollow(FOLLOW_ident_in_call906);
            	ident5 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident5.Tree);
            	char_literal6=(IToken)Match(input,51,FOLLOW_51_in_call908); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_51.Add(char_literal6);

            	PushFollow(FOLLOW_params__in_call910);
            	params_7 = params_();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_params_.Add(params_7.Tree);
            	char_literal8=(IToken)Match(input,52,FOLLOW_52_in_call912); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal8);



            	// AST REWRITE
            	// elements:          params_, ident
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 88:30: -> ^( CALL ident ^( PARAMS ( params_ )? ) )
            	{
            	    // MathExpr.g:88:33: ^( CALL ident ^( PARAMS ( params_ )? ) )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(CALL, "CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_ident.NextTree());
            	    // MathExpr.g:88:46: ^( PARAMS ( params_ )? )
            	    {
            	    AstNode root_2 = (AstNode)adaptor.GetNilNode();
            	    root_2 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(PARAMS, "PARAMS"), root_2);

            	    // MathExpr.g:88:55: ( params_ )?
            	    if ( stream_params_.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_params_.NextTree());

            	    }
            	    stream_params_.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 3, call_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "call"

    public class group_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "group"
    // MathExpr.g:90:1: group : ( '(' term ')' | NUMBER | TRUE | FALSE | ident | call );
    public MathExprParser.group_return group() // throws RecognitionException [1]
    {   
        MathExprParser.group_return retval = new MathExprParser.group_return();
        retval.Start = input.LT(1);
        int group_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal9 = null;
        IToken char_literal11 = null;
        IToken NUMBER12 = null;
        IToken TRUE13 = null;
        IToken FALSE14 = null;
        MathExprParser.term_return term10 = default(MathExprParser.term_return);

        MathExprParser.ident_return ident15 = default(MathExprParser.ident_return);

        MathExprParser.call_return call16 = default(MathExprParser.call_return);


        AstNode char_literal9_tree=null;
        AstNode char_literal11_tree=null;
        AstNode NUMBER12_tree=null;
        AstNode TRUE13_tree=null;
        AstNode FALSE14_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:90:6: ( '(' term ')' | NUMBER | TRUE | FALSE | ident | call )
            int alt3 = 6;
            switch ( input.LA(1) ) 
            {
            case 51:
            	{
                alt3 = 1;
                }
                break;
            case NUMBER:
            	{
                alt3 = 2;
                }
                break;
            case TRUE:
            	{
                alt3 = 3;
                }
                break;
            case FALSE:
            	{
                alt3 = 4;
                }
                break;
            case IDENT:
            	{
                int LA3_5 = input.LA(2);

                if ( (LA3_5 == EOF || (LA3_5 >= IF && LA3_5 <= UNTIL) || (LA3_5 >= AND && LA3_5 <= OR) || (LA3_5 >= INT_DIV && LA3_5 <= INT_MOD) || LA3_5 == RETURN || (LA3_5 >= IDENT && LA3_5 <= BIT_OR) || (LA3_5 >= GE && LA3_5 <= 50) || (LA3_5 >= 52 && LA3_5 <= 55)) )
                {
                    alt3 = 5;
                }
                else if ( (LA3_5 == 51) )
                {
                    alt3 = 6;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d3s5 =
                        new NoViableAltException("", 3, 5, input);

                    throw nvae_d3s5;
                }
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("", 3, 0, input);

            	    throw nvae_d3s0;
            }

            switch (alt3) 
            {
                case 1 :
                    // MathExpr.g:91:3: '(' term ')'
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	char_literal9=(IToken)Match(input,51,FOLLOW_51_in_group938); if (state.failed) return retval;
                    	PushFollow(FOLLOW_term_in_group941);
                    	term10 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term10.Tree);
                    	char_literal11=(IToken)Match(input,52,FOLLOW_52_in_group943); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // MathExpr.g:92:3: NUMBER
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	NUMBER12=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_group948); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NUMBER12_tree = (AstNode)adaptor.Create(NUMBER12);
                    		adaptor.AddChild(root_0, NUMBER12_tree);
                    	}

                    }
                    break;
                case 3 :
                    // MathExpr.g:93:3: TRUE
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	TRUE13=(IToken)Match(input,TRUE,FOLLOW_TRUE_in_group952); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{TRUE13_tree = (AstNode)adaptor.Create(TRUE13);
                    		adaptor.AddChild(root_0, TRUE13_tree);
                    	}

                    }
                    break;
                case 4 :
                    // MathExpr.g:94:3: FALSE
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	FALSE14=(IToken)Match(input,FALSE,FOLLOW_FALSE_in_group956); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FALSE14_tree = (AstNode)adaptor.Create(FALSE14);
                    		adaptor.AddChild(root_0, FALSE14_tree);
                    	}

                    }
                    break;
                case 5 :
                    // MathExpr.g:95:3: ident
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_group960);
                    	ident15 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident15.Tree);

                    }
                    break;
                case 6 :
                    // MathExpr.g:96:3: call
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_call_in_group964);
                    	call16 = call();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, call16.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 4, group_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "group"

    public class not_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "not"
    // MathExpr.g:100:1: not : ( group | NOT not );
    public MathExprParser.not_return not() // throws RecognitionException [1]
    {   
        MathExprParser.not_return retval = new MathExprParser.not_return();
        retval.Start = input.LT(1);
        int not_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken NOT18 = null;
        MathExprParser.group_return group17 = default(MathExprParser.group_return);

        MathExprParser.not_return not19 = default(MathExprParser.not_return);


        AstNode NOT18_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:100:4: ( group | NOT not )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( ((LA4_0 >= TRUE && LA4_0 <= FALSE) || (LA4_0 >= NUMBER && LA4_0 <= IDENT) || LA4_0 == 51) )
            {
                alt4 = 1;
            }
            else if ( (LA4_0 == NOT) )
            {
                alt4 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d4s0 =
                    new NoViableAltException("", 4, 0, input);

                throw nvae_d4s0;
            }
            switch (alt4) 
            {
                case 1 :
                    // MathExpr.g:100:8: group
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_group_in_not975);
                    	group17 = group();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group17.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:100:16: NOT not
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	NOT18=(IToken)Match(input,NOT,FOLLOW_NOT_in_not979); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NOT18_tree = (AstNode)adaptor.Create(NOT18);
                    		root_0 = (AstNode)adaptor.BecomeRoot(NOT18_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_not_in_not982);
                    	not19 = not();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, not19.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 5, not_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "not"

    public class mult_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "mult"
    // MathExpr.g:101:1: mult : not ( ( MUL | DIV | BIT_AND | INT_DIV | INT_MOD ) not )* ;
    public MathExprParser.mult_return mult() // throws RecognitionException [1]
    {   
        MathExprParser.mult_return retval = new MathExprParser.mult_return();
        retval.Start = input.LT(1);
        int mult_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken set21 = null;
        MathExprParser.not_return not20 = default(MathExprParser.not_return);

        MathExprParser.not_return not22 = default(MathExprParser.not_return);


        AstNode set21_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:101:5: ( not ( ( MUL | DIV | BIT_AND | INT_DIV | INT_MOD ) not )* )
            // MathExpr.g:101:8: not ( ( MUL | DIV | BIT_AND | INT_DIV | INT_MOD ) not )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_not_in_mult990);
            	not20 = not();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, not20.Tree);
            	// MathExpr.g:101:12: ( ( MUL | DIV | BIT_AND | INT_DIV | INT_MOD ) not )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= INT_DIV && LA5_0 <= INT_MOD) || (LA5_0 >= MUL && LA5_0 <= BIT_AND)) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // MathExpr.g:101:14: ( MUL | DIV | BIT_AND | INT_DIV | INT_MOD ) not
            			    {
            			    	set21=(IToken)input.LT(1);
            			    	set21 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= INT_DIV && input.LA(1) <= INT_MOD) || (input.LA(1) >= MUL && input.LA(1) <= BIT_AND) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(set21), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_not_in_mult1017);
            			    	not22 = not();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, not22.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 6, mult_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "mult"

    public class add_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "add"
    // MathExpr.g:102:1: add : mult ( ( ADD | SUB | BIT_OR ) mult )* ;
    public MathExprParser.add_return add() // throws RecognitionException [1]
    {   
        MathExprParser.add_return retval = new MathExprParser.add_return();
        retval.Start = input.LT(1);
        int add_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken set24 = null;
        MathExprParser.mult_return mult23 = default(MathExprParser.mult_return);

        MathExprParser.mult_return mult25 = default(MathExprParser.mult_return);


        AstNode set24_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:102:4: ( mult ( ( ADD | SUB | BIT_OR ) mult )* )
            // MathExpr.g:102:8: mult ( ( ADD | SUB | BIT_OR ) mult )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mult_in_add1030);
            	mult23 = mult();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult23.Tree);
            	// MathExpr.g:102:14: ( ( ADD | SUB | BIT_OR ) mult )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= ADD && LA6_0 <= SUB) || LA6_0 == BIT_OR) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // MathExpr.g:102:16: ( ADD | SUB | BIT_OR ) mult
            			    {
            			    	set24=(IToken)input.LT(1);
            			    	set24 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= ADD && input.LA(1) <= SUB) || input.LA(1) == BIT_OR ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(set24), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_mult_in_add1050);
            			    	mult25 = mult();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult25.Tree);

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 7, add_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "add"

    public class compare_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "compare"
    // MathExpr.g:103:1: compare : add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? ;
    public MathExprParser.compare_return compare() // throws RecognitionException [1]
    {   
        MathExprParser.compare_return retval = new MathExprParser.compare_return();
        retval.Start = input.LT(1);
        int compare_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken set27 = null;
        MathExprParser.add_return add26 = default(MathExprParser.add_return);

        MathExprParser.add_return add28 = default(MathExprParser.add_return);


        AstNode set27_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:103:8: ( add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? )
            // MathExpr.g:103:10: add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_add_in_compare1079);
            	add26 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add26.Tree);
            	// MathExpr.g:103:14: ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( ((LA7_0 >= GE && LA7_0 <= LT)) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // MathExpr.g:103:16: ( GE | LE | NEQUALS | EQUALS | GT | LT ) add
            	        {
            	        	set27=(IToken)input.LT(1);
            	        	set27 = (IToken)input.LT(1);
            	        	if ( (input.LA(1) >= GE && input.LA(1) <= LT) ) 
            	        	{
            	        	    input.Consume();
            	        	    if ( state.backtracking == 0 ) root_0 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(set27), root_0);
            	        	    state.errorRecovery = false;state.failed = false;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    throw mse;
            	        	}

            	        	PushFollow(FOLLOW_add_in_compare1110);
            	        	add28 = add();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add28.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 8, compare_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "compare"

    public class and_logic_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "and_logic"
    // MathExpr.g:104:1: and_logic : compare ( AND compare )* ;
    public MathExprParser.and_logic_return and_logic() // throws RecognitionException [1]
    {   
        MathExprParser.and_logic_return retval = new MathExprParser.and_logic_return();
        retval.Start = input.LT(1);
        int and_logic_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken AND30 = null;
        MathExprParser.compare_return compare29 = default(MathExprParser.compare_return);

        MathExprParser.compare_return compare31 = default(MathExprParser.compare_return);


        AstNode AND30_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:104:10: ( compare ( AND compare )* )
            // MathExpr.g:104:12: compare ( AND compare )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_compare_in_and_logic1122);
            	compare29 = compare();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare29.Tree);
            	// MathExpr.g:104:20: ( AND compare )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == AND) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // MathExpr.g:104:22: AND compare
            			    {
            			    	AND30=(IToken)Match(input,AND,FOLLOW_AND_in_and_logic1126); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{AND30_tree = (AstNode)adaptor.Create(AND30);
            			    		root_0 = (AstNode)adaptor.BecomeRoot(AND30_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_compare_in_and_logic1129);
            			    	compare31 = compare();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare31.Tree);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 9, and_logic_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "and_logic"

    public class or_logic_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "or_logic"
    // MathExpr.g:105:1: or_logic : and_logic ( OR and_logic )* ;
    public MathExprParser.or_logic_return or_logic() // throws RecognitionException [1]
    {   
        MathExprParser.or_logic_return retval = new MathExprParser.or_logic_return();
        retval.Start = input.LT(1);
        int or_logic_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken OR33 = null;
        MathExprParser.and_logic_return and_logic32 = default(MathExprParser.and_logic_return);

        MathExprParser.and_logic_return and_logic34 = default(MathExprParser.and_logic_return);


        AstNode OR33_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:105:9: ( and_logic ( OR and_logic )* )
            // MathExpr.g:105:11: and_logic ( OR and_logic )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_and_logic_in_or_logic1142);
            	and_logic32 = and_logic();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and_logic32.Tree);
            	// MathExpr.g:105:21: ( OR and_logic )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == OR) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // MathExpr.g:105:23: OR and_logic
            			    {
            			    	OR33=(IToken)Match(input,OR,FOLLOW_OR_in_or_logic1146); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{OR33_tree = (AstNode)adaptor.Create(OR33);
            			    		root_0 = (AstNode)adaptor.BecomeRoot(OR33_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_and_logic_in_or_logic1149);
            			    	and_logic34 = and_logic();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and_logic34.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 10, or_logic_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "or_logic"

    public class term_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "term"
    // MathExpr.g:106:1: term : or_logic ;
    public MathExprParser.term_return term() // throws RecognitionException [1]
    {   
        MathExprParser.term_return retval = new MathExprParser.term_return();
        retval.Start = input.LT(1);
        int term_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.or_logic_return or_logic35 = default(MathExprParser.or_logic_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:106:5: ( or_logic )
            // MathExpr.g:106:7: or_logic
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_or_logic_in_term1160);
            	or_logic35 = or_logic();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or_logic35.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 11, term_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "term"

    public class varDecl_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "varDecl"
    // MathExpr.g:108:1: varDecl : ident ( ASSIGN term )? ;
    public MathExprParser.varDecl_return varDecl() // throws RecognitionException [1]
    {   
        MathExprParser.varDecl_return retval = new MathExprParser.varDecl_return();
        retval.Start = input.LT(1);
        int varDecl_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken ASSIGN37 = null;
        MathExprParser.ident_return ident36 = default(MathExprParser.ident_return);

        MathExprParser.term_return term38 = default(MathExprParser.term_return);


        AstNode ASSIGN37_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:108:8: ( ident ( ASSIGN term )? )
            // MathExpr.g:108:10: ident ( ASSIGN term )?
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_ident_in_varDecl1169);
            	ident36 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident36.Tree);
            	// MathExpr.g:108:16: ( ASSIGN term )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == ASSIGN) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // MathExpr.g:108:17: ASSIGN term
            	        {
            	        	ASSIGN37=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_varDecl1172); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{ASSIGN37_tree = (AstNode)adaptor.Create(ASSIGN37);
            	        		root_0 = (AstNode)adaptor.BecomeRoot(ASSIGN37_tree, root_0);
            	        	}
            	        	PushFollow(FOLLOW_term_in_varDecl1175);
            	        	term38 = term();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term38.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 12, varDecl_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "varDecl"

    public class varsDecl_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "varsDecl"
    // MathExpr.g:109:1: varsDecl : ident varDecl ( ',' varDecl )* -> ^( VAR ^( ident ( varDecl )+ ) ) ;
    public MathExprParser.varsDecl_return varsDecl() // throws RecognitionException [1]
    {   
        MathExprParser.varsDecl_return retval = new MathExprParser.varsDecl_return();
        retval.Start = input.LT(1);
        int varsDecl_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal41 = null;
        MathExprParser.ident_return ident39 = default(MathExprParser.ident_return);

        MathExprParser.varDecl_return varDecl40 = default(MathExprParser.varDecl_return);

        MathExprParser.varDecl_return varDecl42 = default(MathExprParser.varDecl_return);


        AstNode char_literal41_tree=null;
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_varDecl = new RewriteRuleSubtreeStream(adaptor,"rule varDecl");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:109:9: ( ident varDecl ( ',' varDecl )* -> ^( VAR ^( ident ( varDecl )+ ) ) )
            // MathExpr.g:109:11: ident varDecl ( ',' varDecl )*
            {
            	PushFollow(FOLLOW_ident_in_varsDecl1183);
            	ident39 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident39.Tree);
            	PushFollow(FOLLOW_varDecl_in_varsDecl1185);
            	varDecl40 = varDecl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_varDecl.Add(varDecl40.Tree);
            	// MathExpr.g:109:25: ( ',' varDecl )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == 50) )
            	    {
            	        int LA11_2 = input.LA(2);

            	        if ( (LA11_2 == IDENT) )
            	        {
            	            int LA11_3 = input.LA(3);

            	            if ( (synpred26_MathExpr()) )
            	            {
            	                alt11 = 1;
            	            }


            	        }


            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // MathExpr.g:109:27: ',' varDecl
            			    {
            			    	char_literal41=(IToken)Match(input,50,FOLLOW_50_in_varsDecl1189); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_50.Add(char_literal41);

            			    	PushFollow(FOLLOW_varDecl_in_varsDecl1191);
            			    	varDecl42 = varDecl();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_varDecl.Add(varDecl42.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements



            	// AST REWRITE
            	// elements:          ident, varDecl
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 109:42: -> ^( VAR ^( ident ( varDecl )+ ) )
            	{
            	    // MathExpr.g:109:45: ^( VAR ^( ident ( varDecl )+ ) )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(VAR, "VAR"), root_1);

            	    // MathExpr.g:109:51: ^( ident ( varDecl )+ )
            	    {
            	    AstNode root_2 = (AstNode)adaptor.GetNilNode();
            	    root_2 = (AstNode)adaptor.BecomeRoot(stream_ident.NextNode(), root_2);

            	    if ( !(stream_varDecl.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_varDecl.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_varDecl.NextTree());

            	    }
            	    stream_varDecl.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 13, varsDecl_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "varsDecl"

    public class expr0_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "expr0"
    // MathExpr.g:113:1: expr0 : ( ident ASSIGN term | ident -> ^( CALL ident PARAMS ) | call | varsDecl );
    public MathExprParser.expr0_return expr0() // throws RecognitionException [1]
    {   
        MathExprParser.expr0_return retval = new MathExprParser.expr0_return();
        retval.Start = input.LT(1);
        int expr0_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken ASSIGN44 = null;
        MathExprParser.ident_return ident43 = default(MathExprParser.ident_return);

        MathExprParser.term_return term45 = default(MathExprParser.term_return);

        MathExprParser.ident_return ident46 = default(MathExprParser.ident_return);

        MathExprParser.call_return call47 = default(MathExprParser.call_return);

        MathExprParser.varsDecl_return varsDecl48 = default(MathExprParser.varsDecl_return);


        AstNode ASSIGN44_tree=null;
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:113:6: ( ident ASSIGN term | ident -> ^( CALL ident PARAMS ) | call | varsDecl )
            int alt12 = 4;
            int LA12_0 = input.LA(1);

            if ( (LA12_0 == IDENT) )
            {
                switch ( input.LA(2) ) 
                {
                case IDENT:
                	{
                    alt12 = 4;
                    }
                    break;
                case EOF:
                case 50:
                case 52:
                case 55:
                	{
                    alt12 = 2;
                    }
                    break;
                case ASSIGN:
                	{
                    alt12 = 1;
                    }
                    break;
                case 51:
                	{
                    alt12 = 3;
                    }
                    break;
                	default:
                	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                	    NoViableAltException nvae_d12s1 =
                	        new NoViableAltException("", 12, 1, input);

                	    throw nvae_d12s1;
                }

            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d12s0 =
                    new NoViableAltException("", 12, 0, input);

                throw nvae_d12s0;
            }
            switch (alt12) 
            {
                case 1 :
                    // MathExpr.g:114:3: ident ASSIGN term
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_expr01219);
                    	ident43 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident43.Tree);
                    	ASSIGN44=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr01221); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN44_tree = (AstNode)adaptor.Create(ASSIGN44);
                    		root_0 = (AstNode)adaptor.BecomeRoot(ASSIGN44_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_term_in_expr01224);
                    	term45 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term45.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:115:3: ident
                    {
                    	PushFollow(FOLLOW_ident_in_expr01228);
                    	ident46 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_ident.Add(ident46.Tree);


                    	// AST REWRITE
                    	// elements:          ident
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 115:9: -> ^( CALL ident PARAMS )
                    	{
                    	    // MathExpr.g:115:12: ^( CALL ident PARAMS )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(CALL, "CALL"), root_1);

                    	    adaptor.AddChild(root_1, stream_ident.NextTree());
                    	    adaptor.AddChild(root_1, (AstNode)adaptor.Create(PARAMS, "PARAMS"));

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // MathExpr.g:116:3: call
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_call_in_expr01242);
                    	call47 = call();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, call47.Tree);

                    }
                    break;
                case 4 :
                    // MathExpr.g:117:3: varsDecl
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varsDecl_in_expr01246);
                    	varsDecl48 = varsDecl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varsDecl48.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 14, expr0_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "expr0"

    public class blockExpr_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "blockExpr"
    // MathExpr.g:119:1: blockExpr : '{' exprList '}' ;
    public MathExprParser.blockExpr_return blockExpr() // throws RecognitionException [1]
    {   
        MathExprParser.blockExpr_return retval = new MathExprParser.blockExpr_return();
        retval.Start = input.LT(1);
        int blockExpr_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal49 = null;
        IToken char_literal51 = null;
        MathExprParser.exprList_return exprList50 = default(MathExprParser.exprList_return);


        AstNode char_literal49_tree=null;
        AstNode char_literal51_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:119:10: ( '{' exprList '}' )
            // MathExpr.g:119:12: '{' exprList '}'
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	char_literal49=(IToken)Match(input,53,FOLLOW_53_in_blockExpr1253); if (state.failed) return retval;
            	PushFollow(FOLLOW_exprList_in_blockExpr1256);
            	exprList50 = exprList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList50.Tree);
            	char_literal51=(IToken)Match(input,54,FOLLOW_54_in_blockExpr1258); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 15, blockExpr_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "blockExpr"

    public class termOrTrue_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "termOrTrue"
    // MathExpr.g:120:1: termOrTrue : ( term | () -> TRUE );
    public MathExprParser.termOrTrue_return termOrTrue() // throws RecognitionException [1]
    {   
        MathExprParser.termOrTrue_return retval = new MathExprParser.termOrTrue_return();
        retval.Start = input.LT(1);
        int termOrTrue_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.term_return term52 = default(MathExprParser.term_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:120:11: ( term | () -> TRUE )
            int alt13 = 2;
            int LA13_0 = input.LA(1);

            if ( (LA13_0 == NOT || (LA13_0 >= TRUE && LA13_0 <= FALSE) || (LA13_0 >= NUMBER && LA13_0 <= IDENT) || LA13_0 == 51) )
            {
                alt13 = 1;
            }
            else if ( (LA13_0 == 55) )
            {
                alt13 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d13s0 =
                    new NoViableAltException("", 13, 0, input);

                throw nvae_d13s0;
            }
            switch (alt13) 
            {
                case 1 :
                    // MathExpr.g:121:3: term
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_term_in_termOrTrue1269);
                    	term52 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term52.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:122:3: ()
                    {
                    	// MathExpr.g:122:3: ()
                    	// MathExpr.g:122:5: 
                    	{
                    	}



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 122:7: -> TRUE
                    	{
                    	    adaptor.AddChild(root_0, (AstNode)adaptor.Create(TRUE, "TRUE"));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 16, termOrTrue_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "termOrTrue"

    public class expr_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "expr"
    // MathExpr.g:124:1: expr : ( expr0 ';' | IF '(' term ')' expr ( ELSE expr )? | WHILE '(' term ')' expr | FOR '(' exprList2 ';' termOrTrue ';' exprList2 ')' expr | REPEAT expr UNTIL term | RETURN term ';' | call ';' | blockExpr );
    public MathExprParser.expr_return expr() // throws RecognitionException [1]
    {   
        MathExprParser.expr_return retval = new MathExprParser.expr_return();
        retval.Start = input.LT(1);
        int expr_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal54 = null;
        IToken IF55 = null;
        IToken char_literal56 = null;
        IToken char_literal58 = null;
        IToken ELSE60 = null;
        IToken WHILE62 = null;
        IToken char_literal63 = null;
        IToken char_literal65 = null;
        IToken FOR67 = null;
        IToken char_literal68 = null;
        IToken char_literal70 = null;
        IToken char_literal72 = null;
        IToken char_literal74 = null;
        IToken REPEAT76 = null;
        IToken UNTIL78 = null;
        IToken RETURN80 = null;
        IToken char_literal82 = null;
        IToken char_literal84 = null;
        MathExprParser.expr0_return expr053 = default(MathExprParser.expr0_return);

        MathExprParser.term_return term57 = default(MathExprParser.term_return);

        MathExprParser.expr_return expr59 = default(MathExprParser.expr_return);

        MathExprParser.expr_return expr61 = default(MathExprParser.expr_return);

        MathExprParser.term_return term64 = default(MathExprParser.term_return);

        MathExprParser.expr_return expr66 = default(MathExprParser.expr_return);

        MathExprParser.exprList2_return exprList269 = default(MathExprParser.exprList2_return);

        MathExprParser.termOrTrue_return termOrTrue71 = default(MathExprParser.termOrTrue_return);

        MathExprParser.exprList2_return exprList273 = default(MathExprParser.exprList2_return);

        MathExprParser.expr_return expr75 = default(MathExprParser.expr_return);

        MathExprParser.expr_return expr77 = default(MathExprParser.expr_return);

        MathExprParser.term_return term79 = default(MathExprParser.term_return);

        MathExprParser.term_return term81 = default(MathExprParser.term_return);

        MathExprParser.call_return call83 = default(MathExprParser.call_return);

        MathExprParser.blockExpr_return blockExpr85 = default(MathExprParser.blockExpr_return);


        AstNode char_literal54_tree=null;
        AstNode IF55_tree=null;
        AstNode char_literal56_tree=null;
        AstNode char_literal58_tree=null;
        AstNode ELSE60_tree=null;
        AstNode WHILE62_tree=null;
        AstNode char_literal63_tree=null;
        AstNode char_literal65_tree=null;
        AstNode FOR67_tree=null;
        AstNode char_literal68_tree=null;
        AstNode char_literal70_tree=null;
        AstNode char_literal72_tree=null;
        AstNode char_literal74_tree=null;
        AstNode REPEAT76_tree=null;
        AstNode UNTIL78_tree=null;
        AstNode RETURN80_tree=null;
        AstNode char_literal82_tree=null;
        AstNode char_literal84_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:124:5: ( expr0 ';' | IF '(' term ')' expr ( ELSE expr )? | WHILE '(' term ')' expr | FOR '(' exprList2 ';' termOrTrue ';' exprList2 ')' expr | REPEAT expr UNTIL term | RETURN term ';' | call ';' | blockExpr )
            int alt15 = 8;
            alt15 = dfa15.Predict(input);
            switch (alt15) 
            {
                case 1 :
                    // MathExpr.g:125:3: expr0 ';'
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expr0_in_expr1288);
                    	expr053 = expr0();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr053.Tree);
                    	char_literal54=(IToken)Match(input,55,FOLLOW_55_in_expr1290); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // MathExpr.g:126:3: IF '(' term ')' expr ( ELSE expr )?
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	IF55=(IToken)Match(input,IF,FOLLOW_IF_in_expr1295); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IF55_tree = (AstNode)adaptor.Create(IF55);
                    		root_0 = (AstNode)adaptor.BecomeRoot(IF55_tree, root_0);
                    	}
                    	char_literal56=(IToken)Match(input,51,FOLLOW_51_in_expr1298); if (state.failed) return retval;
                    	PushFollow(FOLLOW_term_in_expr1301);
                    	term57 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term57.Tree);
                    	char_literal58=(IToken)Match(input,52,FOLLOW_52_in_expr1303); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr1306);
                    	expr59 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr59.Tree);
                    	// MathExpr.g:126:27: ( ELSE expr )?
                    	int alt14 = 2;
                    	int LA14_0 = input.LA(1);

                    	if ( (LA14_0 == ELSE) )
                    	{
                    	    int LA14_1 = input.LA(2);

                    	    if ( (synpred32_MathExpr()) )
                    	    {
                    	        alt14 = 1;
                    	    }
                    	}
                    	switch (alt14) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:126:28: ELSE expr
                    	        {
                    	        	ELSE60=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_expr1309); if (state.failed) return retval;
                    	        	PushFollow(FOLLOW_expr_in_expr1312);
                    	        	expr61 = expr();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr61.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // MathExpr.g:127:3: WHILE '(' term ')' expr
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	WHILE62=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_expr1318); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{WHILE62_tree = (AstNode)adaptor.Create(WHILE62);
                    		root_0 = (AstNode)adaptor.BecomeRoot(WHILE62_tree, root_0);
                    	}
                    	char_literal63=(IToken)Match(input,51,FOLLOW_51_in_expr1321); if (state.failed) return retval;
                    	PushFollow(FOLLOW_term_in_expr1324);
                    	term64 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term64.Tree);
                    	char_literal65=(IToken)Match(input,52,FOLLOW_52_in_expr1326); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr1329);
                    	expr66 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr66.Tree);

                    }
                    break;
                case 4 :
                    // MathExpr.g:128:3: FOR '(' exprList2 ';' termOrTrue ';' exprList2 ')' expr
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	FOR67=(IToken)Match(input,FOR,FOLLOW_FOR_in_expr1333); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FOR67_tree = (AstNode)adaptor.Create(FOR67);
                    		root_0 = (AstNode)adaptor.BecomeRoot(FOR67_tree, root_0);
                    	}
                    	char_literal68=(IToken)Match(input,51,FOLLOW_51_in_expr1336); if (state.failed) return retval;
                    	PushFollow(FOLLOW_exprList2_in_expr1339);
                    	exprList269 = exprList2();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList269.Tree);
                    	char_literal70=(IToken)Match(input,55,FOLLOW_55_in_expr1341); if (state.failed) return retval;
                    	PushFollow(FOLLOW_termOrTrue_in_expr1344);
                    	termOrTrue71 = termOrTrue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, termOrTrue71.Tree);
                    	char_literal72=(IToken)Match(input,55,FOLLOW_55_in_expr1346); if (state.failed) return retval;
                    	PushFollow(FOLLOW_exprList2_in_expr1349);
                    	exprList273 = exprList2();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList273.Tree);
                    	char_literal74=(IToken)Match(input,52,FOLLOW_52_in_expr1351); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr1354);
                    	expr75 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr75.Tree);

                    }
                    break;
                case 5 :
                    // MathExpr.g:129:3: REPEAT expr UNTIL term
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	REPEAT76=(IToken)Match(input,REPEAT,FOLLOW_REPEAT_in_expr1358); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{REPEAT76_tree = (AstNode)adaptor.Create(REPEAT76);
                    		root_0 = (AstNode)adaptor.BecomeRoot(REPEAT76_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_expr_in_expr1361);
                    	expr77 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr77.Tree);
                    	UNTIL78=(IToken)Match(input,UNTIL,FOLLOW_UNTIL_in_expr1363); if (state.failed) return retval;
                    	PushFollow(FOLLOW_term_in_expr1366);
                    	term79 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term79.Tree);

                    }
                    break;
                case 6 :
                    // MathExpr.g:130:3: RETURN term ';'
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	RETURN80=(IToken)Match(input,RETURN,FOLLOW_RETURN_in_expr1370); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{RETURN80_tree = (AstNode)adaptor.Create(RETURN80);
                    		root_0 = (AstNode)adaptor.BecomeRoot(RETURN80_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_term_in_expr1373);
                    	term81 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term81.Tree);
                    	char_literal82=(IToken)Match(input,55,FOLLOW_55_in_expr1375); if (state.failed) return retval;

                    }
                    break;
                case 7 :
                    // MathExpr.g:131:3: call ';'
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_call_in_expr1380);
                    	call83 = call();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, call83.Tree);
                    	char_literal84=(IToken)Match(input,55,FOLLOW_55_in_expr1382); if (state.failed) return retval;

                    }
                    break;
                case 8 :
                    // MathExpr.g:132:3: blockExpr
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_blockExpr_in_expr1388);
                    	blockExpr85 = blockExpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, blockExpr85.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 17, expr_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "expr"

    public class exprList_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "exprList"
    // MathExpr.g:135:1: exprList : ( expr ( ( ';' )* expr )* )? ( ';' )* -> ^( BLOCK ( expr )* ) ;
    public MathExprParser.exprList_return exprList() // throws RecognitionException [1]
    {   
        MathExprParser.exprList_return retval = new MathExprParser.exprList_return();
        retval.Start = input.LT(1);
        int exprList_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal87 = null;
        IToken char_literal89 = null;
        MathExprParser.expr_return expr86 = default(MathExprParser.expr_return);

        MathExprParser.expr_return expr88 = default(MathExprParser.expr_return);


        AstNode char_literal87_tree=null;
        AstNode char_literal89_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:135:9: ( ( expr ( ( ';' )* expr )* )? ( ';' )* -> ^( BLOCK ( expr )* ) )
            // MathExpr.g:135:11: ( expr ( ( ';' )* expr )* )? ( ';' )*
            {
            	// MathExpr.g:135:11: ( expr ( ( ';' )* expr )* )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == IF || (LA18_0 >= FOR && LA18_0 <= REPEAT) || LA18_0 == RETURN || LA18_0 == IDENT || LA18_0 == 53) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // MathExpr.g:135:13: expr ( ( ';' )* expr )*
            	        {
            	        	PushFollow(FOLLOW_expr_in_exprList1400);
            	        	expr86 = expr();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expr.Add(expr86.Tree);
            	        	// MathExpr.g:135:18: ( ( ';' )* expr )*
            	        	do 
            	        	{
            	        	    int alt17 = 2;
            	        	    alt17 = dfa17.Predict(input);
            	        	    switch (alt17) 
            	        		{
            	        			case 1 :
            	        			    // MathExpr.g:135:20: ( ';' )* expr
            	        			    {
            	        			    	// MathExpr.g:135:20: ( ';' )*
            	        			    	do 
            	        			    	{
            	        			    	    int alt16 = 2;
            	        			    	    int LA16_0 = input.LA(1);

            	        			    	    if ( (LA16_0 == 55) )
            	        			    	    {
            	        			    	        alt16 = 1;
            	        			    	    }


            	        			    	    switch (alt16) 
            	        			    		{
            	        			    			case 1 :
            	        			    			    // MathExpr.g:0:0: ';'
            	        			    			    {
            	        			    			    	char_literal87=(IToken)Match(input,55,FOLLOW_55_in_exprList1404); if (state.failed) return retval; 
            	        			    			    	if ( (state.backtracking==0) ) stream_55.Add(char_literal87);


            	        			    			    }
            	        			    			    break;

            	        			    			default:
            	        			    			    goto loop16;
            	        			    	    }
            	        			    	} while (true);

            	        			    	loop16:
            	        			    		;	// Stops C# compiler whining that label 'loop16' has no statements

            	        			    	PushFollow(FOLLOW_expr_in_exprList1407);
            	        			    	expr88 = expr();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_expr.Add(expr88.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop17;
            	        	    }
            	        	} while (true);

            	        	loop17:
            	        		;	// Stops C# compiler whining that label 'loop17' has no statements


            	        }
            	        break;

            	}

            	// MathExpr.g:135:36: ( ';' )*
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( (LA19_0 == 55) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // MathExpr.g:0:0: ';'
            			    {
            			    	char_literal89=(IToken)Match(input,55,FOLLOW_55_in_exprList1415); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_55.Add(char_literal89);


            			    }
            			    break;

            			default:
            			    goto loop19;
            	    }
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whining that label 'loop19' has no statements



            	// AST REWRITE
            	// elements:          expr
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 135:42: -> ^( BLOCK ( expr )* )
            	{
            	    // MathExpr.g:135:46: ^( BLOCK ( expr )* )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // MathExpr.g:135:54: ( expr )*
            	    while ( stream_expr.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_expr.NextTree());

            	    }
            	    stream_expr.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 18, exprList_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "exprList"

    public class exprList2_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "exprList2"
    // MathExpr.g:136:1: exprList2 : ( expr0 ( ',' expr0 )* )? -> ^( BLOCK ( expr0 )* ) ;
    public MathExprParser.exprList2_return exprList2() // throws RecognitionException [1]
    {   
        MathExprParser.exprList2_return retval = new MathExprParser.exprList2_return();
        retval.Start = input.LT(1);
        int exprList2_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal91 = null;
        MathExprParser.expr0_return expr090 = default(MathExprParser.expr0_return);

        MathExprParser.expr0_return expr092 = default(MathExprParser.expr0_return);


        AstNode char_literal91_tree=null;
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_expr0 = new RewriteRuleSubtreeStream(adaptor,"rule expr0");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:136:10: ( ( expr0 ( ',' expr0 )* )? -> ^( BLOCK ( expr0 )* ) )
            // MathExpr.g:136:12: ( expr0 ( ',' expr0 )* )?
            {
            	// MathExpr.g:136:12: ( expr0 ( ',' expr0 )* )?
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);

            	if ( (LA21_0 == IDENT) )
            	{
            	    alt21 = 1;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // MathExpr.g:136:14: expr0 ( ',' expr0 )*
            	        {
            	        	PushFollow(FOLLOW_expr0_in_exprList21437);
            	        	expr090 = expr0();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expr0.Add(expr090.Tree);
            	        	// MathExpr.g:136:20: ( ',' expr0 )*
            	        	do 
            	        	{
            	        	    int alt20 = 2;
            	        	    int LA20_0 = input.LA(1);

            	        	    if ( (LA20_0 == 50) )
            	        	    {
            	        	        alt20 = 1;
            	        	    }


            	        	    switch (alt20) 
            	        		{
            	        			case 1 :
            	        			    // MathExpr.g:136:22: ',' expr0
            	        			    {
            	        			    	char_literal91=(IToken)Match(input,50,FOLLOW_50_in_exprList21441); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_50.Add(char_literal91);

            	        			    	PushFollow(FOLLOW_expr0_in_exprList21443);
            	        			    	expr092 = expr0();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_expr0.Add(expr092.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop20;
            	        	    }
            	        	} while (true);

            	        	loop20:
            	        		;	// Stops C# compiler whining that label 'loop20' has no statements


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          expr0
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 136:39: -> ^( BLOCK ( expr0 )* )
            	{
            	    // MathExpr.g:136:43: ^( BLOCK ( expr0 )* )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // MathExpr.g:136:51: ( expr0 )*
            	    while ( stream_expr0.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_expr0.NextTree());

            	    }
            	    stream_expr0.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 19, exprList2_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "exprList2"

    public class paramDecl_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "paramDecl"
    // MathExpr.g:138:1: paramDecl : ident ident ;
    public MathExprParser.paramDecl_return paramDecl() // throws RecognitionException [1]
    {   
        MathExprParser.paramDecl_return retval = new MathExprParser.paramDecl_return();
        retval.Start = input.LT(1);
        int paramDecl_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.ident_return ident93 = default(MathExprParser.ident_return);

        MathExprParser.ident_return ident94 = default(MathExprParser.ident_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:138:10: ( ident ident )
            // MathExpr.g:138:12: ident ident
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_ident_in_paramDecl1469);
            	ident93 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) root_0 = (AstNode)adaptor.BecomeRoot(ident93.Tree, root_0);
            	PushFollow(FOLLOW_ident_in_paramDecl1472);
            	ident94 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident94.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 20, paramDecl_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "paramDecl"

    public class paramsDecl_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "paramsDecl"
    // MathExpr.g:139:1: paramsDecl : paramDecl ( ',' paramDecl )* ;
    public MathExprParser.paramsDecl_return paramsDecl() // throws RecognitionException [1]
    {   
        MathExprParser.paramsDecl_return retval = new MathExprParser.paramsDecl_return();
        retval.Start = input.LT(1);
        int paramsDecl_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal96 = null;
        MathExprParser.paramDecl_return paramDecl95 = default(MathExprParser.paramDecl_return);

        MathExprParser.paramDecl_return paramDecl97 = default(MathExprParser.paramDecl_return);


        AstNode char_literal96_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:139:11: ( paramDecl ( ',' paramDecl )* )
            // MathExpr.g:139:13: paramDecl ( ',' paramDecl )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_paramDecl_in_paramsDecl1479);
            	paramDecl95 = paramDecl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, paramDecl95.Tree);
            	// MathExpr.g:139:23: ( ',' paramDecl )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == 50) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // MathExpr.g:139:25: ',' paramDecl
            			    {
            			    	char_literal96=(IToken)Match(input,50,FOLLOW_50_in_paramsDecl1483); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_paramDecl_in_paramsDecl1486);
            			    	paramDecl97 = paramDecl();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, paramDecl97.Tree);

            			    }
            			    break;

            			default:
            			    goto loop22;
            	    }
            	} while (true);

            	loop22:
            		;	// Stops C# compiler whining that label 'loop22' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 21, paramsDecl_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "paramsDecl"

    public class funcDecl_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "funcDecl"
    // MathExpr.g:140:1: funcDecl : t= ident n= ident '(' ( paramsDecl )? ')' '{' exprList '}' -> ^( FUNCTION $t $n ^( PARAMS ( paramsDecl )* ) exprList ) ;
    public MathExprParser.funcDecl_return funcDecl() // throws RecognitionException [1]
    {   
        MathExprParser.funcDecl_return retval = new MathExprParser.funcDecl_return();
        retval.Start = input.LT(1);
        int funcDecl_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal98 = null;
        IToken char_literal100 = null;
        IToken char_literal101 = null;
        IToken char_literal103 = null;
        MathExprParser.ident_return t = default(MathExprParser.ident_return);

        MathExprParser.ident_return n = default(MathExprParser.ident_return);

        MathExprParser.paramsDecl_return paramsDecl99 = default(MathExprParser.paramsDecl_return);

        MathExprParser.exprList_return exprList102 = default(MathExprParser.exprList_return);


        AstNode char_literal98_tree=null;
        AstNode char_literal100_tree=null;
        AstNode char_literal101_tree=null;
        AstNode char_literal103_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_paramsDecl = new RewriteRuleSubtreeStream(adaptor,"rule paramsDecl");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_exprList = new RewriteRuleSubtreeStream(adaptor,"rule exprList");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:140:9: (t= ident n= ident '(' ( paramsDecl )? ')' '{' exprList '}' -> ^( FUNCTION $t $n ^( PARAMS ( paramsDecl )* ) exprList ) )
            // MathExpr.g:141:3: t= ident n= ident '(' ( paramsDecl )? ')' '{' exprList '}'
            {
            	PushFollow(FOLLOW_ident_in_funcDecl1500);
            	t = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(t.Tree);
            	PushFollow(FOLLOW_ident_in_funcDecl1504);
            	n = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(n.Tree);
            	char_literal98=(IToken)Match(input,51,FOLLOW_51_in_funcDecl1506); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_51.Add(char_literal98);

            	// MathExpr.g:141:23: ( paramsDecl )?
            	int alt23 = 2;
            	int LA23_0 = input.LA(1);

            	if ( (LA23_0 == IDENT) )
            	{
            	    alt23 = 1;
            	}
            	switch (alt23) 
            	{
            	    case 1 :
            	        // MathExpr.g:0:0: paramsDecl
            	        {
            	        	PushFollow(FOLLOW_paramsDecl_in_funcDecl1508);
            	        	paramsDecl99 = paramsDecl();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_paramsDecl.Add(paramsDecl99.Tree);

            	        }
            	        break;

            	}

            	char_literal100=(IToken)Match(input,52,FOLLOW_52_in_funcDecl1511); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal100);

            	char_literal101=(IToken)Match(input,53,FOLLOW_53_in_funcDecl1515); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_53.Add(char_literal101);

            	PushFollow(FOLLOW_exprList_in_funcDecl1517);
            	exprList102 = exprList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_exprList.Add(exprList102.Tree);
            	char_literal103=(IToken)Match(input,54,FOLLOW_54_in_funcDecl1519); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_54.Add(char_literal103);



            	// AST REWRITE
            	// elements:          exprList, t, paramsDecl, n
            	// token labels:      
            	// rule labels:       retval, t, n
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_t = new RewriteRuleSubtreeStream(adaptor, "rule t", t!=null ? t.Tree : null);
            	RewriteRuleSubtreeStream stream_n = new RewriteRuleSubtreeStream(adaptor, "rule n", n!=null ? n.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 143:3: -> ^( FUNCTION $t $n ^( PARAMS ( paramsDecl )* ) exprList )
            	{
            	    // MathExpr.g:143:6: ^( FUNCTION $t $n ^( PARAMS ( paramsDecl )* ) exprList )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(FUNCTION, "FUNCTION"), root_1);

            	    adaptor.AddChild(root_1, stream_t.NextTree());
            	    adaptor.AddChild(root_1, stream_n.NextTree());
            	    // MathExpr.g:143:23: ^( PARAMS ( paramsDecl )* )
            	    {
            	    AstNode root_2 = (AstNode)adaptor.GetNilNode();
            	    root_2 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(PARAMS, "PARAMS"), root_2);

            	    // MathExpr.g:143:32: ( paramsDecl )*
            	    while ( stream_paramsDecl.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_paramsDecl.NextTree());

            	    }
            	    stream_paramsDecl.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_exprList.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 22, funcDecl_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "funcDecl"

    public class exprOrFuncDecl_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "exprOrFuncDecl"
    // MathExpr.g:146:1: exprOrFuncDecl : ( funcDecl | expr );
    public MathExprParser.exprOrFuncDecl_return exprOrFuncDecl() // throws RecognitionException [1]
    {   
        MathExprParser.exprOrFuncDecl_return retval = new MathExprParser.exprOrFuncDecl_return();
        retval.Start = input.LT(1);
        int exprOrFuncDecl_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.funcDecl_return funcDecl104 = default(MathExprParser.funcDecl_return);

        MathExprParser.expr_return expr105 = default(MathExprParser.expr_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:146:15: ( funcDecl | expr )
            int alt24 = 2;
            int LA24_0 = input.LA(1);

            if ( (LA24_0 == IDENT) )
            {
                int LA24_1 = input.LA(2);

                if ( (LA24_1 == ASSIGN || LA24_1 == 51 || LA24_1 == 55) )
                {
                    alt24 = 2;
                }
                else if ( (LA24_1 == IDENT) )
                {
                    int LA24_3 = input.LA(3);

                    if ( (LA24_3 == ASSIGN || LA24_3 == 50 || LA24_3 == 55) )
                    {
                        alt24 = 2;
                    }
                    else if ( (LA24_3 == 51) )
                    {
                        alt24 = 1;
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                        NoViableAltException nvae_d24s3 =
                            new NoViableAltException("", 24, 3, input);

                        throw nvae_d24s3;
                    }
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d24s1 =
                        new NoViableAltException("", 24, 1, input);

                    throw nvae_d24s1;
                }
            }
            else if ( (LA24_0 == IF || (LA24_0 >= FOR && LA24_0 <= REPEAT) || LA24_0 == RETURN || LA24_0 == 53) )
            {
                alt24 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d24s0 =
                    new NoViableAltException("", 24, 0, input);

                throw nvae_d24s0;
            }
            switch (alt24) 
            {
                case 1 :
                    // MathExpr.g:146:17: funcDecl
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_funcDecl_in_exprOrFuncDecl1550);
                    	funcDecl104 = funcDecl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funcDecl104.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:146:28: expr
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expr_in_exprOrFuncDecl1554);
                    	expr105 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr105.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 23, exprOrFuncDecl_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "exprOrFuncDecl"

    public class program_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "program"
    // MathExpr.g:148:1: program : ( exprOrFuncDecl ( ';' )* )* ;
    public MathExprParser.program_return program() // throws RecognitionException [1]
    {   
        MathExprParser.program_return retval = new MathExprParser.program_return();
        retval.Start = input.LT(1);
        int program_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal107 = null;
        MathExprParser.exprOrFuncDecl_return exprOrFuncDecl106 = default(MathExprParser.exprOrFuncDecl_return);


        AstNode char_literal107_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:148:8: ( ( exprOrFuncDecl ( ';' )* )* )
            // MathExpr.g:148:10: ( exprOrFuncDecl ( ';' )* )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	// MathExpr.g:148:10: ( exprOrFuncDecl ( ';' )* )*
            	do 
            	{
            	    int alt26 = 2;
            	    int LA26_0 = input.LA(1);

            	    if ( (LA26_0 == IF || (LA26_0 >= FOR && LA26_0 <= REPEAT) || LA26_0 == RETURN || LA26_0 == IDENT || LA26_0 == 53) )
            	    {
            	        alt26 = 1;
            	    }


            	    switch (alt26) 
            		{
            			case 1 :
            			    // MathExpr.g:148:12: exprOrFuncDecl ( ';' )*
            			    {
            			    	PushFollow(FOLLOW_exprOrFuncDecl_in_program1564);
            			    	exprOrFuncDecl106 = exprOrFuncDecl();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprOrFuncDecl106.Tree);
            			    	// MathExpr.g:148:30: ( ';' )*
            			    	do 
            			    	{
            			    	    int alt25 = 2;
            			    	    int LA25_0 = input.LA(1);

            			    	    if ( (LA25_0 == 55) )
            			    	    {
            			    	        alt25 = 1;
            			    	    }


            			    	    switch (alt25) 
            			    		{
            			    			case 1 :
            			    			    // MathExpr.g:0:0: ';'
            			    			    {
            			    			    	char_literal107=(IToken)Match(input,55,FOLLOW_55_in_program1566); if (state.failed) return retval;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop25;
            			    	    }
            			    	} while (true);

            			    	loop25:
            			    		;	// Stops C# compiler whining that label 'loop25' has no statements


            			    }
            			    break;

            			default:
            			    goto loop26;
            	    }
            	} while (true);

            	loop26:
            		;	// Stops C# compiler whining that label 'loop26' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 24, program_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "program"

    public class result_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "result"
    // MathExpr.g:150:1: result : program -> ^( PROGRAM program ) ;
    public MathExprParser.result_return result() // throws RecognitionException [1]
    {   
        MathExprParser.result_return retval = new MathExprParser.result_return();
        retval.Start = input.LT(1);
        int result_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.program_return program108 = default(MathExprParser.program_return);


        RewriteRuleSubtreeStream stream_program = new RewriteRuleSubtreeStream(adaptor,"rule program");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:150:7: ( program -> ^( PROGRAM program ) )
            // MathExpr.g:150:9: program
            {
            	PushFollow(FOLLOW_program_in_result1579);
            	program108 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_program.Add(program108.Tree);


            	// AST REWRITE
            	// elements:          program
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 150:17: -> ^( PROGRAM program )
            	{
            	    // MathExpr.g:150:20: ^( PROGRAM program )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

            	    adaptor.AddChild(root_1, stream_program.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 25, result_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "result"

    public class execute_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "execute"
    // MathExpr.g:152:1: execute : result ;
    public MathExprParser.execute_return execute() // throws RecognitionException [1]
    {   
        MathExprParser.execute_return retval = new MathExprParser.execute_return();
        retval.Start = input.LT(1);
        int execute_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.result_return result109 = default(MathExprParser.result_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:152:8: ( result )
            // MathExpr.g:153:3: result
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_result_in_execute1597);
            	result109 = result();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, result109.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 26, execute_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "execute"

    // $ANTLR start "synpred26_MathExpr"
    public void synpred26_MathExpr_fragment() {
        // MathExpr.g:109:27: ( ',' varDecl )
        // MathExpr.g:109:27: ',' varDecl
        {
        	Match(input,50,FOLLOW_50_in_synpred26_MathExpr1189); if (state.failed) return ;
        	PushFollow(FOLLOW_varDecl_in_synpred26_MathExpr1191);
        	varDecl();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred26_MathExpr"

    // $ANTLR start "synpred31_MathExpr"
    public void synpred31_MathExpr_fragment() {
        // MathExpr.g:125:3: ( expr0 ';' )
        // MathExpr.g:125:3: expr0 ';'
        {
        	PushFollow(FOLLOW_expr0_in_synpred31_MathExpr1288);
        	expr0();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,55,FOLLOW_55_in_synpred31_MathExpr1290); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred31_MathExpr"

    // $ANTLR start "synpred32_MathExpr"
    public void synpred32_MathExpr_fragment() {
        // MathExpr.g:126:28: ( ELSE expr )
        // MathExpr.g:126:28: ELSE expr
        {
        	Match(input,ELSE,FOLLOW_ELSE_in_synpred32_MathExpr1309); if (state.failed) return ;
        	PushFollow(FOLLOW_expr_in_synpred32_MathExpr1312);
        	expr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred32_MathExpr"

    // $ANTLR start "synpred38_MathExpr"
    public void synpred38_MathExpr_fragment() {
        // MathExpr.g:131:3: ( call ';' )
        // MathExpr.g:131:3: call ';'
        {
        	PushFollow(FOLLOW_call_in_synpred38_MathExpr1380);
        	call();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,55,FOLLOW_55_in_synpred38_MathExpr1382); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred38_MathExpr"

    // Delegated rules

   	public bool synpred26_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred26_MathExpr_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred32_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred32_MathExpr_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred31_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred31_MathExpr_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred38_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred38_MathExpr_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA15 dfa15;
   	protected DFA17 dfa17;
	private void InitializeCyclicDFAs()
	{
    	this.dfa15 = new DFA15(this);
    	this.dfa17 = new DFA17(this);
	    this.dfa15.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA15_SpecialStateTransition);
	}

    const string DFA15_eotS =
        "\x0a\uffff";
    const string DFA15_eofS =
        "\x0a\uffff";
    const string DFA15_minS =
        "\x01\x09\x01\x00\x08\uffff";
    const string DFA15_maxS =
        "\x01\x35\x01\x00\x08\uffff";
    const string DFA15_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x08\x01"+
        "\x01\x01\x07";
    const string DFA15_specialS =
        "\x01\uffff\x01\x00\x08\uffff}>";
    static readonly string[] DFA15_transitionS = {
            "\x01\x02\x01\uffff\x01\x04\x01\x03\x01\x05\x0d\uffff\x01\x06"+
            "\x08\uffff\x01\x01\x10\uffff\x01\x07",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA15_eot = DFA.UnpackEncodedString(DFA15_eotS);
    static readonly short[] DFA15_eof = DFA.UnpackEncodedString(DFA15_eofS);
    static readonly char[] DFA15_min = DFA.UnpackEncodedStringToUnsignedChars(DFA15_minS);
    static readonly char[] DFA15_max = DFA.UnpackEncodedStringToUnsignedChars(DFA15_maxS);
    static readonly short[] DFA15_accept = DFA.UnpackEncodedString(DFA15_acceptS);
    static readonly short[] DFA15_special = DFA.UnpackEncodedString(DFA15_specialS);
    static readonly short[][] DFA15_transition = DFA.UnpackEncodedStringArray(DFA15_transitionS);

    protected class DFA15 : DFA
    {
        public DFA15(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 15;
            this.eot = DFA15_eot;
            this.eof = DFA15_eof;
            this.min = DFA15_min;
            this.max = DFA15_max;
            this.accept = DFA15_accept;
            this.special = DFA15_special;
            this.transition = DFA15_transition;

        }

        override public string Description
        {
            get { return "124:1: expr : ( expr0 ';' | IF '(' term ')' expr ( ELSE expr )? | WHILE '(' term ')' expr | FOR '(' exprList2 ';' termOrTrue ';' exprList2 ')' expr | REPEAT expr UNTIL term | RETURN term ';' | call ';' | blockExpr );"; }
        }

    }


    protected internal int DFA15_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA15_1 = input.LA(1);

                   	 
                   	int index15_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred31_MathExpr()) ) { s = 8; }

                   	else if ( (synpred38_MathExpr()) ) { s = 9; }

                   	 
                   	input.Seek(index15_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae15 =
            new NoViableAltException(dfa.Description, 15, _s, input);
        dfa.Error(nvae15);
        throw nvae15;
    }
    const string DFA17_eotS =
        "\x04\uffff";
    const string DFA17_eofS =
        "\x04\uffff";
    const string DFA17_minS =
        "\x02\x09\x02\uffff";
    const string DFA17_maxS =
        "\x02\x37\x02\uffff";
    const string DFA17_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA17_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA17_transitionS = {
            "\x01\x03\x01\uffff\x03\x03\x0d\uffff\x01\x03\x08\uffff\x01"+
            "\x03\x10\uffff\x01\x03\x01\x02\x01\x01",
            "\x01\x03\x01\uffff\x03\x03\x0d\uffff\x01\x03\x08\uffff\x01"+
            "\x03\x10\uffff\x01\x03\x01\x02\x01\x01",
            "",
            ""
    };

    static readonly short[] DFA17_eot = DFA.UnpackEncodedString(DFA17_eotS);
    static readonly short[] DFA17_eof = DFA.UnpackEncodedString(DFA17_eofS);
    static readonly char[] DFA17_min = DFA.UnpackEncodedStringToUnsignedChars(DFA17_minS);
    static readonly char[] DFA17_max = DFA.UnpackEncodedStringToUnsignedChars(DFA17_maxS);
    static readonly short[] DFA17_accept = DFA.UnpackEncodedString(DFA17_acceptS);
    static readonly short[] DFA17_special = DFA.UnpackEncodedString(DFA17_specialS);
    static readonly short[][] DFA17_transition = DFA.UnpackEncodedStringArray(DFA17_transitionS);

    protected class DFA17 : DFA
    {
        public DFA17(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 17;
            this.eot = DFA17_eot;
            this.eof = DFA17_eof;
            this.min = DFA17_min;
            this.max = DFA17_max;
            this.accept = DFA17_accept;
            this.special = DFA17_special;
            this.transition = DFA17_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 135:18: ( ( ';' )* expr )*"; }
        }

    }

 

    public static readonly BitSet FOLLOW_IDENT_in_ident876 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_term_in_params_887 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_50_in_params_890 = new BitSet(new ulong[]{0x0008001980080000UL});
    public static readonly BitSet FOLLOW_term_in_params_893 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_call906 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_call908 = new BitSet(new ulong[]{0x0018001980080000UL});
    public static readonly BitSet FOLLOW_params__in_call910 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_call912 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_group938 = new BitSet(new ulong[]{0x0008001980080000UL});
    public static readonly BitSet FOLLOW_term_in_group941 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_group943 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_group948 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRUE_in_group952 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FALSE_in_group956 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_group960 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_call_in_group964 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_group_in_not975 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NOT_in_not979 = new BitSet(new ulong[]{0x0008001980080000UL});
    public static readonly BitSet FOLLOW_not_in_not982 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_not_in_mult990 = new BitSet(new ulong[]{0x0000038000600002UL});
    public static readonly BitSet FOLLOW_set_in_mult994 = new BitSet(new ulong[]{0x0008001980080000UL});
    public static readonly BitSet FOLLOW_not_in_mult1017 = new BitSet(new ulong[]{0x0000038000600002UL});
    public static readonly BitSet FOLLOW_mult_in_add1030 = new BitSet(new ulong[]{0x0000046000000002UL});
    public static readonly BitSet FOLLOW_set_in_add1035 = new BitSet(new ulong[]{0x0008001980080000UL});
    public static readonly BitSet FOLLOW_mult_in_add1050 = new BitSet(new ulong[]{0x0000046000000002UL});
    public static readonly BitSet FOLLOW_add_in_compare1079 = new BitSet(new ulong[]{0x0003F00000000002UL});
    public static readonly BitSet FOLLOW_set_in_compare1083 = new BitSet(new ulong[]{0x0008001980080000UL});
    public static readonly BitSet FOLLOW_add_in_compare1110 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_compare_in_and_logic1122 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_AND_in_and_logic1126 = new BitSet(new ulong[]{0x0008001980080000UL});
    public static readonly BitSet FOLLOW_compare_in_and_logic1129 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_and_logic_in_or_logic1142 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_OR_in_or_logic1146 = new BitSet(new ulong[]{0x0008001980080000UL});
    public static readonly BitSet FOLLOW_and_logic_in_or_logic1149 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_or_logic_in_term1160 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_varDecl1169 = new BitSet(new ulong[]{0x0000080000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_varDecl1172 = new BitSet(new ulong[]{0x0008001980080000UL});
    public static readonly BitSet FOLLOW_term_in_varDecl1175 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_varsDecl1183 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_varDecl_in_varsDecl1185 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_50_in_varsDecl1189 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_varDecl_in_varsDecl1191 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_expr01219 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr01221 = new BitSet(new ulong[]{0x0008001980080000UL});
    public static readonly BitSet FOLLOW_term_in_expr01224 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_expr01228 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_call_in_expr01242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varsDecl_in_expr01246 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_blockExpr1253 = new BitSet(new ulong[]{0x00E8001988003A00UL});
    public static readonly BitSet FOLLOW_exprList_in_blockExpr1256 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_blockExpr1258 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_term_in_termOrTrue1269 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr0_in_expr1288 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_expr1290 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_expr1295 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_expr1298 = new BitSet(new ulong[]{0x0008001980080000UL});
    public static readonly BitSet FOLLOW_term_in_expr1301 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_expr1303 = new BitSet(new ulong[]{0x0028001988003A00UL});
    public static readonly BitSet FOLLOW_expr_in_expr1306 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_ELSE_in_expr1309 = new BitSet(new ulong[]{0x0028001988003A00UL});
    public static readonly BitSet FOLLOW_expr_in_expr1312 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_expr1318 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_expr1321 = new BitSet(new ulong[]{0x0008001980080000UL});
    public static readonly BitSet FOLLOW_term_in_expr1324 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_expr1326 = new BitSet(new ulong[]{0x0028001988003A00UL});
    public static readonly BitSet FOLLOW_expr_in_expr1329 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_expr1333 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_expr1336 = new BitSet(new ulong[]{0x0088001980000000UL});
    public static readonly BitSet FOLLOW_exprList2_in_expr1339 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_expr1341 = new BitSet(new ulong[]{0x0088001980080000UL});
    public static readonly BitSet FOLLOW_termOrTrue_in_expr1344 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_expr1346 = new BitSet(new ulong[]{0x0018001980000000UL});
    public static readonly BitSet FOLLOW_exprList2_in_expr1349 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_expr1351 = new BitSet(new ulong[]{0x0028001988003A00UL});
    public static readonly BitSet FOLLOW_expr_in_expr1354 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_REPEAT_in_expr1358 = new BitSet(new ulong[]{0x0028001988003A00UL});
    public static readonly BitSet FOLLOW_expr_in_expr1361 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_UNTIL_in_expr1363 = new BitSet(new ulong[]{0x0008001980080000UL});
    public static readonly BitSet FOLLOW_term_in_expr1366 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RETURN_in_expr1370 = new BitSet(new ulong[]{0x0008001980080000UL});
    public static readonly BitSet FOLLOW_term_in_expr1373 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_expr1375 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_call_in_expr1380 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_expr1382 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_blockExpr_in_expr1388 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_exprList1400 = new BitSet(new ulong[]{0x00A8001988003A02UL});
    public static readonly BitSet FOLLOW_55_in_exprList1404 = new BitSet(new ulong[]{0x00A8001988003A00UL});
    public static readonly BitSet FOLLOW_expr_in_exprList1407 = new BitSet(new ulong[]{0x00A8001988003A02UL});
    public static readonly BitSet FOLLOW_55_in_exprList1415 = new BitSet(new ulong[]{0x0080000000000002UL});
    public static readonly BitSet FOLLOW_expr0_in_exprList21437 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_50_in_exprList21441 = new BitSet(new ulong[]{0x0008001980000000UL});
    public static readonly BitSet FOLLOW_expr0_in_exprList21443 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_paramDecl1469 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_ident_in_paramDecl1472 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_paramDecl_in_paramsDecl1479 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_50_in_paramsDecl1483 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_paramDecl_in_paramsDecl1486 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_funcDecl1500 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_ident_in_funcDecl1504 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_funcDecl1506 = new BitSet(new ulong[]{0x0010001000000000UL});
    public static readonly BitSet FOLLOW_paramsDecl_in_funcDecl1508 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_funcDecl1511 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_funcDecl1515 = new BitSet(new ulong[]{0x00E8001988003A00UL});
    public static readonly BitSet FOLLOW_exprList_in_funcDecl1517 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_funcDecl1519 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_funcDecl_in_exprOrFuncDecl1550 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_exprOrFuncDecl1554 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_exprOrFuncDecl_in_program1564 = new BitSet(new ulong[]{0x00A8001988003A02UL});
    public static readonly BitSet FOLLOW_55_in_program1566 = new BitSet(new ulong[]{0x00A8001988003A02UL});
    public static readonly BitSet FOLLOW_program_in_result1579 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_result_in_execute1597 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_synpred26_MathExpr1189 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_varDecl_in_synpred26_MathExpr1191 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr0_in_synpred31_MathExpr1288 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_synpred31_MathExpr1290 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ELSE_in_synpred32_MathExpr1309 = new BitSet(new ulong[]{0x0028001988003A00UL});
    public static readonly BitSet FOLLOW_expr_in_synpred32_MathExpr1312 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_call_in_synpred38_MathExpr1380 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_synpred38_MathExpr1382 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}