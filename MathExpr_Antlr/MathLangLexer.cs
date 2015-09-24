// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2015-09-24 20:12:56

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;

namespace  MathLang 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class MathLangLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__34=34;
	public const int T__35=35;
	public const int T__36=36;
	public const int T__37=37;
	public const int UNKNOWN=4;
	public const int BLOCK=5;
	public const int PROGRAM=6;
	public const int AND=7;
	public const int OR=8;
	public const int BEGIN=9;
	public const int END=10;
	public const int IF=11;
	public const int THEN=12;
	public const int ELSE=13;
	public const int WHILE=14;
	public const int DO=15;
	public const int REPEAT=16;
	public const int UNTIL=17;
	public const int WS=18;
	public const int SL_COMMENT=19;
	public const int ML_COMMENT=20;
	public const int NUMBER=21;
	public const int IDENT=22;
	public const int ADD=23;
	public const int SUB=24;
	public const int MUL=25;
	public const int DIV=26;
	public const int ASSIGN=27;
	public const int GE=28;
	public const int LE=29;
	public const int NE=30;
	public const int EQ=31;
	public const int GT=32;
	public const int LT=33;

    // delegates
    // delegators

	public MathLangLexer()
	{
		OnCreated();
	}

	public MathLangLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public MathLangLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "MathLang.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_PROGRAM();
	partial void Leave_PROGRAM();

	// $ANTLR start "PROGRAM"
	[GrammarRule("PROGRAM")]
	private void mPROGRAM()
	{
		Enter_PROGRAM();
		EnterRule("PROGRAM", 1);
		TraceIn("PROGRAM", 1);
		try
		{
			int _type = PROGRAM;
			int _channel = DefaultTokenChannel;
			// MathLang.g:9:9: ( 'program' )
			DebugEnterAlt(1);
			// MathLang.g:9:11: 'program'
			{
			DebugLocation(9, 11);
			Match("program"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PROGRAM", 1);
			LeaveRule("PROGRAM", 1);
			Leave_PROGRAM();
		}
	}
	// $ANTLR end "PROGRAM"

	partial void Enter_AND();
	partial void Leave_AND();

	// $ANTLR start "AND"
	[GrammarRule("AND")]
	private void mAND()
	{
		Enter_AND();
		EnterRule("AND", 2);
		TraceIn("AND", 2);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// MathLang.g:10:5: ( 'and' )
			DebugEnterAlt(1);
			// MathLang.g:10:7: 'and'
			{
			DebugLocation(10, 7);
			Match("and"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 2);
			LeaveRule("AND", 2);
			Leave_AND();
		}
	}
	// $ANTLR end "AND"

	partial void Enter_OR();
	partial void Leave_OR();

	// $ANTLR start "OR"
	[GrammarRule("OR")]
	private void mOR()
	{
		Enter_OR();
		EnterRule("OR", 3);
		TraceIn("OR", 3);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:11:4: ( 'or' )
			DebugEnterAlt(1);
			// MathLang.g:11:6: 'or'
			{
			DebugLocation(11, 6);
			Match("or"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 3);
			LeaveRule("OR", 3);
			Leave_OR();
		}
	}
	// $ANTLR end "OR"

	partial void Enter_BEGIN();
	partial void Leave_BEGIN();

	// $ANTLR start "BEGIN"
	[GrammarRule("BEGIN")]
	private void mBEGIN()
	{
		Enter_BEGIN();
		EnterRule("BEGIN", 4);
		TraceIn("BEGIN", 4);
		try
		{
			int _type = BEGIN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:12:7: ( 'begin' )
			DebugEnterAlt(1);
			// MathLang.g:12:9: 'begin'
			{
			DebugLocation(12, 9);
			Match("begin"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BEGIN", 4);
			LeaveRule("BEGIN", 4);
			Leave_BEGIN();
		}
	}
	// $ANTLR end "BEGIN"

	partial void Enter_END();
	partial void Leave_END();

	// $ANTLR start "END"
	[GrammarRule("END")]
	private void mEND()
	{
		Enter_END();
		EnterRule("END", 5);
		TraceIn("END", 5);
		try
		{
			int _type = END;
			int _channel = DefaultTokenChannel;
			// MathLang.g:13:5: ( 'end' )
			DebugEnterAlt(1);
			// MathLang.g:13:7: 'end'
			{
			DebugLocation(13, 7);
			Match("end"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("END", 5);
			LeaveRule("END", 5);
			Leave_END();
		}
	}
	// $ANTLR end "END"

	partial void Enter_IF();
	partial void Leave_IF();

	// $ANTLR start "IF"
	[GrammarRule("IF")]
	private void mIF()
	{
		Enter_IF();
		EnterRule("IF", 6);
		TraceIn("IF", 6);
		try
		{
			int _type = IF;
			int _channel = DefaultTokenChannel;
			// MathLang.g:14:4: ( 'if' )
			DebugEnterAlt(1);
			// MathLang.g:14:6: 'if'
			{
			DebugLocation(14, 6);
			Match("if"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IF", 6);
			LeaveRule("IF", 6);
			Leave_IF();
		}
	}
	// $ANTLR end "IF"

	partial void Enter_THEN();
	partial void Leave_THEN();

	// $ANTLR start "THEN"
	[GrammarRule("THEN")]
	private void mTHEN()
	{
		Enter_THEN();
		EnterRule("THEN", 7);
		TraceIn("THEN", 7);
		try
		{
			int _type = THEN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:15:6: ( 'then' )
			DebugEnterAlt(1);
			// MathLang.g:15:8: 'then'
			{
			DebugLocation(15, 8);
			Match("then"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("THEN", 7);
			LeaveRule("THEN", 7);
			Leave_THEN();
		}
	}
	// $ANTLR end "THEN"

	partial void Enter_ELSE();
	partial void Leave_ELSE();

	// $ANTLR start "ELSE"
	[GrammarRule("ELSE")]
	private void mELSE()
	{
		Enter_ELSE();
		EnterRule("ELSE", 8);
		TraceIn("ELSE", 8);
		try
		{
			int _type = ELSE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:16:6: ( 'else' )
			DebugEnterAlt(1);
			// MathLang.g:16:8: 'else'
			{
			DebugLocation(16, 8);
			Match("else"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ELSE", 8);
			LeaveRule("ELSE", 8);
			Leave_ELSE();
		}
	}
	// $ANTLR end "ELSE"

	partial void Enter_WHILE();
	partial void Leave_WHILE();

	// $ANTLR start "WHILE"
	[GrammarRule("WHILE")]
	private void mWHILE()
	{
		Enter_WHILE();
		EnterRule("WHILE", 9);
		TraceIn("WHILE", 9);
		try
		{
			int _type = WHILE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:17:7: ( 'while' )
			DebugEnterAlt(1);
			// MathLang.g:17:9: 'while'
			{
			DebugLocation(17, 9);
			Match("while"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHILE", 9);
			LeaveRule("WHILE", 9);
			Leave_WHILE();
		}
	}
	// $ANTLR end "WHILE"

	partial void Enter_DO();
	partial void Leave_DO();

	// $ANTLR start "DO"
	[GrammarRule("DO")]
	private void mDO()
	{
		Enter_DO();
		EnterRule("DO", 10);
		TraceIn("DO", 10);
		try
		{
			int _type = DO;
			int _channel = DefaultTokenChannel;
			// MathLang.g:18:4: ( 'do' )
			DebugEnterAlt(1);
			// MathLang.g:18:6: 'do'
			{
			DebugLocation(18, 6);
			Match("do"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DO", 10);
			LeaveRule("DO", 10);
			Leave_DO();
		}
	}
	// $ANTLR end "DO"

	partial void Enter_REPEAT();
	partial void Leave_REPEAT();

	// $ANTLR start "REPEAT"
	[GrammarRule("REPEAT")]
	private void mREPEAT()
	{
		Enter_REPEAT();
		EnterRule("REPEAT", 11);
		TraceIn("REPEAT", 11);
		try
		{
			int _type = REPEAT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:19:8: ( 'repeat' )
			DebugEnterAlt(1);
			// MathLang.g:19:10: 'repeat'
			{
			DebugLocation(19, 10);
			Match("repeat"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("REPEAT", 11);
			LeaveRule("REPEAT", 11);
			Leave_REPEAT();
		}
	}
	// $ANTLR end "REPEAT"

	partial void Enter_UNTIL();
	partial void Leave_UNTIL();

	// $ANTLR start "UNTIL"
	[GrammarRule("UNTIL")]
	private void mUNTIL()
	{
		Enter_UNTIL();
		EnterRule("UNTIL", 12);
		TraceIn("UNTIL", 12);
		try
		{
			int _type = UNTIL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:20:7: ( 'until' )
			DebugEnterAlt(1);
			// MathLang.g:20:9: 'until'
			{
			DebugLocation(20, 9);
			Match("until"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("UNTIL", 12);
			LeaveRule("UNTIL", 12);
			Leave_UNTIL();
		}
	}
	// $ANTLR end "UNTIL"

	partial void Enter_T__34();
	partial void Leave_T__34();

	// $ANTLR start "T__34"
	[GrammarRule("T__34")]
	private void mT__34()
	{
		Enter_T__34();
		EnterRule("T__34", 13);
		TraceIn("T__34", 13);
		try
		{
			int _type = T__34;
			int _channel = DefaultTokenChannel;
			// MathLang.g:21:7: ( '(' )
			DebugEnterAlt(1);
			// MathLang.g:21:9: '('
			{
			DebugLocation(21, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__34", 13);
			LeaveRule("T__34", 13);
			Leave_T__34();
		}
	}
	// $ANTLR end "T__34"

	partial void Enter_T__35();
	partial void Leave_T__35();

	// $ANTLR start "T__35"
	[GrammarRule("T__35")]
	private void mT__35()
	{
		Enter_T__35();
		EnterRule("T__35", 14);
		TraceIn("T__35", 14);
		try
		{
			int _type = T__35;
			int _channel = DefaultTokenChannel;
			// MathLang.g:22:7: ( ')' )
			DebugEnterAlt(1);
			// MathLang.g:22:9: ')'
			{
			DebugLocation(22, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__35", 14);
			LeaveRule("T__35", 14);
			Leave_T__35();
		}
	}
	// $ANTLR end "T__35"

	partial void Enter_T__36();
	partial void Leave_T__36();

	// $ANTLR start "T__36"
	[GrammarRule("T__36")]
	private void mT__36()
	{
		Enter_T__36();
		EnterRule("T__36", 15);
		TraceIn("T__36", 15);
		try
		{
			int _type = T__36;
			int _channel = DefaultTokenChannel;
			// MathLang.g:23:7: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:23:9: ';'
			{
			DebugLocation(23, 9);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__36", 15);
			LeaveRule("T__36", 15);
			Leave_T__36();
		}
	}
	// $ANTLR end "T__36"

	partial void Enter_T__37();
	partial void Leave_T__37();

	// $ANTLR start "T__37"
	[GrammarRule("T__37")]
	private void mT__37()
	{
		Enter_T__37();
		EnterRule("T__37", 16);
		TraceIn("T__37", 16);
		try
		{
			int _type = T__37;
			int _channel = DefaultTokenChannel;
			// MathLang.g:24:7: ( '.' )
			DebugEnterAlt(1);
			// MathLang.g:24:9: '.'
			{
			DebugLocation(24, 9);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__37", 16);
			LeaveRule("T__37", 16);
			Leave_T__37();
		}
	}
	// $ANTLR end "T__37"

	partial void Enter_WS();
	partial void Leave_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		Enter_WS();
		EnterRule("WS", 17);
		TraceIn("WS", 17);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:45:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// MathLang.g:46:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(46, 3);
			// MathLang.g:46:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if (((LA1_0>='\t' && LA1_0<='\n')||(LA1_0>='\f' && LA1_0<='\r')||LA1_0==' '))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(46, 3);
					if ((input.LA(1)>='\t' && input.LA(1)<='\n')||(input.LA(1)>='\f' && input.LA(1)<='\r')||input.LA(1)==' ')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					if (cnt1 >= 1)
						goto loop1;

					EarlyExitException eee1 = new EarlyExitException( 1, input );
					DebugRecognitionException(eee1);
					throw eee1;
				}
				cnt1++;
			}
			loop1:
				;

			} finally { DebugExitSubRule(1); }

			DebugLocation(46, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 17);
			LeaveRule("WS", 17);
			Leave_WS();
		}
	}
	// $ANTLR end "WS"

	partial void Enter_SL_COMMENT();
	partial void Leave_SL_COMMENT();

	// $ANTLR start "SL_COMMENT"
	[GrammarRule("SL_COMMENT")]
	private void mSL_COMMENT()
	{
		Enter_SL_COMMENT();
		EnterRule("SL_COMMENT", 18);
		TraceIn("SL_COMMENT", 18);
		try
		{
			int _type = SL_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:51:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// MathLang.g:52:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
			{
			DebugLocation(52, 3);
			Match("//"); 

			DebugLocation(52, 8);
			// MathLang.g:52:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if ((LA2_0=='\r'))
				{
					alt2=2;
				}
				else if ((LA2_0=='\n'))
				{
					alt2=2;
				}
				else if (((LA2_0>='\u0000' && LA2_0<='\t')||(LA2_0>='\u000B' && LA2_0<='\f')||(LA2_0>='\u000E' && LA2_0<='\uFFFF')))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:52:36: .
					{
					DebugLocation(52, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }

			DebugLocation(52, 40);
			// MathLang.g:52:40: ( '\\r' )?
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0=='\r'))
			{
				alt3=1;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:52:40: '\\r'
				{
				DebugLocation(52, 40);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(3); }

			DebugLocation(52, 46);
			Match('\n'); 
			DebugLocation(52, 51);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SL_COMMENT", 18);
			LeaveRule("SL_COMMENT", 18);
			Leave_SL_COMMENT();
		}
	}
	// $ANTLR end "SL_COMMENT"

	partial void Enter_ML_COMMENT();
	partial void Leave_ML_COMMENT();

	// $ANTLR start "ML_COMMENT"
	[GrammarRule("ML_COMMENT")]
	private void mML_COMMENT()
	{
		Enter_ML_COMMENT();
		EnterRule("ML_COMMENT", 19);
		TraceIn("ML_COMMENT", 19);
		try
		{
			int _type = ML_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:56:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// MathLang.g:57:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(57, 3);
			Match("/*"); 

			DebugLocation(57, 8);
			// MathLang.g:57:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0=='*'))
				{
					int LA4_1 = input.LA(2);

					if ((LA4_1=='/'))
					{
						alt4=2;
					}
					else if (((LA4_1>='\u0000' && LA4_1<='.')||(LA4_1>='0' && LA4_1<='\uFFFF')))
					{
						alt4=1;
					}


				}
				else if (((LA4_0>='\u0000' && LA4_0<=')')||(LA4_0>='+' && LA4_0<='\uFFFF')))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:57:36: .
					{
					DebugLocation(57, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(57, 40);
			Match("*/"); 

			DebugLocation(57, 45);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ML_COMMENT", 19);
			LeaveRule("ML_COMMENT", 19);
			Leave_ML_COMMENT();
		}
	}
	// $ANTLR end "ML_COMMENT"

	partial void Enter_NUMBER();
	partial void Leave_NUMBER();

	// $ANTLR start "NUMBER"
	[GrammarRule("NUMBER")]
	private void mNUMBER()
	{
		Enter_NUMBER();
		EnterRule("NUMBER", 20);
		TraceIn("NUMBER", 20);
		try
		{
			int _type = NUMBER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:63:7: ( ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )? )
			DebugEnterAlt(1);
			// MathLang.g:63:9: ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )?
			{
			DebugLocation(63, 9);
			// MathLang.g:63:9: ( '0' .. '9' )+
			int cnt5=0;
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if (((LA5_0>='0' && LA5_0<='9')))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:63:10: '0' .. '9'
					{
					DebugLocation(63, 10);
					MatchRange('0','9'); 

					}
					break;

				default:
					if (cnt5 >= 1)
						goto loop5;

					EarlyExitException eee5 = new EarlyExitException( 5, input );
					DebugRecognitionException(eee5);
					throw eee5;
				}
				cnt5++;
			}
			loop5:
				;

			} finally { DebugExitSubRule(5); }

			DebugLocation(63, 21);
			// MathLang.g:63:21: ( '.' ( '0' .. '9' )+ )?
			int alt7=2;
			try { DebugEnterSubRule(7);
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if ((LA7_0=='.'))
			{
				alt7=1;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:63:22: '.' ( '0' .. '9' )+
				{
				DebugLocation(63, 22);
				Match('.'); 
				DebugLocation(63, 26);
				// MathLang.g:63:26: ( '0' .. '9' )+
				int cnt6=0;
				try { DebugEnterSubRule(6);
				while (true)
				{
					int alt6=2;
					try { DebugEnterDecision(6, decisionCanBacktrack[6]);
					int LA6_0 = input.LA(1);

					if (((LA6_0>='0' && LA6_0<='9')))
					{
						alt6=1;
					}


					} finally { DebugExitDecision(6); }
					switch (alt6)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:63:27: '0' .. '9'
						{
						DebugLocation(63, 27);
						MatchRange('0','9'); 

						}
						break;

					default:
						if (cnt6 >= 1)
							goto loop6;

						EarlyExitException eee6 = new EarlyExitException( 6, input );
						DebugRecognitionException(eee6);
						throw eee6;
					}
					cnt6++;
				}
				loop6:
					;

				} finally { DebugExitSubRule(6); }


				}
				break;

			}
			} finally { DebugExitSubRule(7); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NUMBER", 20);
			LeaveRule("NUMBER", 20);
			Leave_NUMBER();
		}
	}
	// $ANTLR end "NUMBER"

	partial void Enter_IDENT();
	partial void Leave_IDENT();

	// $ANTLR start "IDENT"
	[GrammarRule("IDENT")]
	private void mIDENT()
	{
		Enter_IDENT();
		EnterRule("IDENT", 21);
		TraceIn("IDENT", 21);
		try
		{
			int _type = IDENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:65:6: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )* )
			DebugEnterAlt(1);
			// MathLang.g:65:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
			{
			DebugLocation(65, 9);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}

			DebugLocation(66, 9);
			// MathLang.g:66:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if (((LA8_0>='0' && LA8_0<='9')||(LA8_0>='A' && LA8_0<='Z')||LA8_0=='_'||(LA8_0>='a' && LA8_0<='z')))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(66, 9);
					if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IDENT", 21);
			LeaveRule("IDENT", 21);
			Leave_IDENT();
		}
	}
	// $ANTLR end "IDENT"

	partial void Enter_ADD();
	partial void Leave_ADD();

	// $ANTLR start "ADD"
	[GrammarRule("ADD")]
	private void mADD()
	{
		Enter_ADD();
		EnterRule("ADD", 22);
		TraceIn("ADD", 22);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:68:4: ( '+' )
			DebugEnterAlt(1);
			// MathLang.g:68:9: '+'
			{
			DebugLocation(68, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 22);
			LeaveRule("ADD", 22);
			Leave_ADD();
		}
	}
	// $ANTLR end "ADD"

	partial void Enter_SUB();
	partial void Leave_SUB();

	// $ANTLR start "SUB"
	[GrammarRule("SUB")]
	private void mSUB()
	{
		Enter_SUB();
		EnterRule("SUB", 23);
		TraceIn("SUB", 23);
		try
		{
			int _type = SUB;
			int _channel = DefaultTokenChannel;
			// MathLang.g:69:4: ( '-' )
			DebugEnterAlt(1);
			// MathLang.g:69:9: '-'
			{
			DebugLocation(69, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SUB", 23);
			LeaveRule("SUB", 23);
			Leave_SUB();
		}
	}
	// $ANTLR end "SUB"

	partial void Enter_MUL();
	partial void Leave_MUL();

	// $ANTLR start "MUL"
	[GrammarRule("MUL")]
	private void mMUL()
	{
		Enter_MUL();
		EnterRule("MUL", 24);
		TraceIn("MUL", 24);
		try
		{
			int _type = MUL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:70:4: ( '*' )
			DebugEnterAlt(1);
			// MathLang.g:70:9: '*'
			{
			DebugLocation(70, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MUL", 24);
			LeaveRule("MUL", 24);
			Leave_MUL();
		}
	}
	// $ANTLR end "MUL"

	partial void Enter_DIV();
	partial void Leave_DIV();

	// $ANTLR start "DIV"
	[GrammarRule("DIV")]
	private void mDIV()
	{
		Enter_DIV();
		EnterRule("DIV", 25);
		TraceIn("DIV", 25);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// MathLang.g:71:4: ( '/' )
			DebugEnterAlt(1);
			// MathLang.g:71:9: '/'
			{
			DebugLocation(71, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 25);
			LeaveRule("DIV", 25);
			Leave_DIV();
		}
	}
	// $ANTLR end "DIV"

	partial void Enter_ASSIGN();
	partial void Leave_ASSIGN();

	// $ANTLR start "ASSIGN"
	[GrammarRule("ASSIGN")]
	private void mASSIGN()
	{
		Enter_ASSIGN();
		EnterRule("ASSIGN", 26);
		TraceIn("ASSIGN", 26);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:72:7: ( ':=' )
			DebugEnterAlt(1);
			// MathLang.g:72:9: ':='
			{
			DebugLocation(72, 9);
			Match(":="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 26);
			LeaveRule("ASSIGN", 26);
			Leave_ASSIGN();
		}
	}
	// $ANTLR end "ASSIGN"

	partial void Enter_GE();
	partial void Leave_GE();

	// $ANTLR start "GE"
	[GrammarRule("GE")]
	private void mGE()
	{
		Enter_GE();
		EnterRule("GE", 27);
		TraceIn("GE", 27);
		try
		{
			int _type = GE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:74:3: ( '>=' )
			DebugEnterAlt(1);
			// MathLang.g:74:9: '>='
			{
			DebugLocation(74, 9);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GE", 27);
			LeaveRule("GE", 27);
			Leave_GE();
		}
	}
	// $ANTLR end "GE"

	partial void Enter_LE();
	partial void Leave_LE();

	// $ANTLR start "LE"
	[GrammarRule("LE")]
	private void mLE()
	{
		Enter_LE();
		EnterRule("LE", 28);
		TraceIn("LE", 28);
		try
		{
			int _type = LE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:75:3: ( '<=' )
			DebugEnterAlt(1);
			// MathLang.g:75:9: '<='
			{
			DebugLocation(75, 9);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LE", 28);
			LeaveRule("LE", 28);
			Leave_LE();
		}
	}
	// $ANTLR end "LE"

	partial void Enter_NE();
	partial void Leave_NE();

	// $ANTLR start "NE"
	[GrammarRule("NE")]
	private void mNE()
	{
		Enter_NE();
		EnterRule("NE", 29);
		TraceIn("NE", 29);
		try
		{
			int _type = NE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:76:3: ( '<>' )
			DebugEnterAlt(1);
			// MathLang.g:76:9: '<>'
			{
			DebugLocation(76, 9);
			Match("<>"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NE", 29);
			LeaveRule("NE", 29);
			Leave_NE();
		}
	}
	// $ANTLR end "NE"

	partial void Enter_EQ();
	partial void Leave_EQ();

	// $ANTLR start "EQ"
	[GrammarRule("EQ")]
	private void mEQ()
	{
		Enter_EQ();
		EnterRule("EQ", 30);
		TraceIn("EQ", 30);
		try
		{
			int _type = EQ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:77:3: ( '=' )
			DebugEnterAlt(1);
			// MathLang.g:77:9: '='
			{
			DebugLocation(77, 9);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQ", 30);
			LeaveRule("EQ", 30);
			Leave_EQ();
		}
	}
	// $ANTLR end "EQ"

	partial void Enter_GT();
	partial void Leave_GT();

	// $ANTLR start "GT"
	[GrammarRule("GT")]
	private void mGT()
	{
		Enter_GT();
		EnterRule("GT", 31);
		TraceIn("GT", 31);
		try
		{
			int _type = GT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:78:3: ( '>' )
			DebugEnterAlt(1);
			// MathLang.g:78:9: '>'
			{
			DebugLocation(78, 9);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GT", 31);
			LeaveRule("GT", 31);
			Leave_GT();
		}
	}
	// $ANTLR end "GT"

	partial void Enter_LT();
	partial void Leave_LT();

	// $ANTLR start "LT"
	[GrammarRule("LT")]
	private void mLT()
	{
		Enter_LT();
		EnterRule("LT", 32);
		TraceIn("LT", 32);
		try
		{
			int _type = LT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:79:3: ( '<' )
			DebugEnterAlt(1);
			// MathLang.g:79:9: '<'
			{
			DebugLocation(79, 9);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LT", 32);
			LeaveRule("LT", 32);
			Leave_LT();
		}
	}
	// $ANTLR end "LT"

	public override void mTokens()
	{
		// MathLang.g:1:8: ( PROGRAM | AND | OR | BEGIN | END | IF | THEN | ELSE | WHILE | DO | REPEAT | UNTIL | T__34 | T__35 | T__36 | T__37 | WS | SL_COMMENT | ML_COMMENT | NUMBER | IDENT | ADD | SUB | MUL | DIV | ASSIGN | GE | LE | NE | EQ | GT | LT )
		int alt9=32;
		try { DebugEnterDecision(9, decisionCanBacktrack[9]);
		try
		{
			alt9 = dfa9.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(9); }
		switch (alt9)
		{
		case 1:
			DebugEnterAlt(1);
			// MathLang.g:1:10: PROGRAM
			{
			DebugLocation(1, 10);
			mPROGRAM(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// MathLang.g:1:18: AND
			{
			DebugLocation(1, 18);
			mAND(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// MathLang.g:1:22: OR
			{
			DebugLocation(1, 22);
			mOR(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// MathLang.g:1:25: BEGIN
			{
			DebugLocation(1, 25);
			mBEGIN(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// MathLang.g:1:31: END
			{
			DebugLocation(1, 31);
			mEND(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// MathLang.g:1:35: IF
			{
			DebugLocation(1, 35);
			mIF(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// MathLang.g:1:38: THEN
			{
			DebugLocation(1, 38);
			mTHEN(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// MathLang.g:1:43: ELSE
			{
			DebugLocation(1, 43);
			mELSE(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// MathLang.g:1:48: WHILE
			{
			DebugLocation(1, 48);
			mWHILE(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// MathLang.g:1:54: DO
			{
			DebugLocation(1, 54);
			mDO(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// MathLang.g:1:57: REPEAT
			{
			DebugLocation(1, 57);
			mREPEAT(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// MathLang.g:1:64: UNTIL
			{
			DebugLocation(1, 64);
			mUNTIL(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// MathLang.g:1:70: T__34
			{
			DebugLocation(1, 70);
			mT__34(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// MathLang.g:1:76: T__35
			{
			DebugLocation(1, 76);
			mT__35(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// MathLang.g:1:82: T__36
			{
			DebugLocation(1, 82);
			mT__36(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// MathLang.g:1:88: T__37
			{
			DebugLocation(1, 88);
			mT__37(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// MathLang.g:1:94: WS
			{
			DebugLocation(1, 94);
			mWS(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// MathLang.g:1:97: SL_COMMENT
			{
			DebugLocation(1, 97);
			mSL_COMMENT(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// MathLang.g:1:108: ML_COMMENT
			{
			DebugLocation(1, 108);
			mML_COMMENT(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// MathLang.g:1:119: NUMBER
			{
			DebugLocation(1, 119);
			mNUMBER(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// MathLang.g:1:126: IDENT
			{
			DebugLocation(1, 126);
			mIDENT(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MathLang.g:1:132: ADD
			{
			DebugLocation(1, 132);
			mADD(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// MathLang.g:1:136: SUB
			{
			DebugLocation(1, 136);
			mSUB(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// MathLang.g:1:140: MUL
			{
			DebugLocation(1, 140);
			mMUL(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// MathLang.g:1:144: DIV
			{
			DebugLocation(1, 144);
			mDIV(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// MathLang.g:1:148: ASSIGN
			{
			DebugLocation(1, 148);
			mASSIGN(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// MathLang.g:1:155: GE
			{
			DebugLocation(1, 155);
			mGE(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// MathLang.g:1:158: LE
			{
			DebugLocation(1, 158);
			mLE(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// MathLang.g:1:161: NE
			{
			DebugLocation(1, 161);
			mNE(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// MathLang.g:1:164: EQ
			{
			DebugLocation(1, 164);
			mEQ(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// MathLang.g:1:167: GT
			{
			DebugLocation(1, 167);
			mGT(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// MathLang.g:1:170: LT
			{
			DebugLocation(1, 170);
			mLT(); 

			}
			break;

		}

	}


	#region DFA
	DFA9 dfa9;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa9 = new DFA9(this);
	}

	private class DFA9 : DFA
	{
		private const string DFA9_eotS =
			"\x1\xFFFF\xB\x13\x5\xFFFF\x1\x29\x6\xFFFF\x1\x2B\x1\x2E\x1\xFFFF\x2"+
			"\x13\x1\x31\x3\x13\x1\x35\x2\x13\x1\x38\x2\x13\x8\xFFFF\x1\x13\x1\x3C"+
			"\x1\xFFFF\x1\x13\x1\x3E\x1\x13\x1\xFFFF\x2\x13\x1\xFFFF\x3\x13\x1\xFFFF"+
			"\x1\x13\x1\xFFFF\x1\x46\x1\x47\x4\x13\x1\x4C\x2\xFFFF\x1\x4D\x1\x13\x1"+
			"\x4F\x1\x13\x2\xFFFF\x1\x51\x1\xFFFF\x1\x52\x2\xFFFF";
		private const string DFA9_eofS =
			"\x53\xFFFF";
		private const string DFA9_minS =
			"\x1\x9\x1\x72\x1\x6E\x1\x72\x1\x65\x1\x6C\x1\x66\x2\x68\x1\x6F\x1\x65"+
			"\x1\x6E\x5\xFFFF\x1\x2A\x6\xFFFF\x2\x3D\x1\xFFFF\x1\x6F\x1\x64\x1\x30"+
			"\x1\x67\x1\x64\x1\x73\x1\x30\x1\x65\x1\x69\x1\x30\x1\x70\x1\x74\x8\xFFFF"+
			"\x1\x67\x1\x30\x1\xFFFF\x1\x69\x1\x30\x1\x65\x1\xFFFF\x1\x6E\x1\x6C\x1"+
			"\xFFFF\x1\x65\x1\x69\x1\x72\x1\xFFFF\x1\x6E\x1\xFFFF\x2\x30\x1\x65\x1"+
			"\x61\x1\x6C\x1\x61\x1\x30\x2\xFFFF\x1\x30\x1\x74\x1\x30\x1\x6D\x2\xFFFF"+
			"\x1\x30\x1\xFFFF\x1\x30\x2\xFFFF";
		private const string DFA9_maxS =
			"\x1\x7A\x1\x72\x1\x6E\x1\x72\x1\x65\x1\x6E\x1\x66\x2\x68\x1\x6F\x1\x65"+
			"\x1\x6E\x5\xFFFF\x1\x2F\x6\xFFFF\x1\x3D\x1\x3E\x1\xFFFF\x1\x6F\x1\x64"+
			"\x1\x7A\x1\x67\x1\x64\x1\x73\x1\x7A\x1\x65\x1\x69\x1\x7A\x1\x70\x1\x74"+
			"\x8\xFFFF\x1\x67\x1\x7A\x1\xFFFF\x1\x69\x1\x7A\x1\x65\x1\xFFFF\x1\x6E"+
			"\x1\x6C\x1\xFFFF\x1\x65\x1\x69\x1\x72\x1\xFFFF\x1\x6E\x1\xFFFF\x2\x7A"+
			"\x1\x65\x1\x61\x1\x6C\x1\x61\x1\x7A\x2\xFFFF\x1\x7A\x1\x74\x1\x7A\x1"+
			"\x6D\x2\xFFFF\x1\x7A\x1\xFFFF\x1\x7A\x2\xFFFF";
		private const string DFA9_acceptS =
			"\xC\xFFFF\x1\xD\x1\xE\x1\xF\x1\x10\x1\x11\x1\xFFFF\x1\x14\x1\x15\x1"+
			"\x16\x1\x17\x1\x18\x1\x1A\x2\xFFFF\x1\x1E\xC\xFFFF\x1\x12\x1\x13\x1\x19"+
			"\x1\x1B\x1\x1F\x1\x1C\x1\x1D\x1\x20\x2\xFFFF\x1\x3\x3\xFFFF\x1\x6\x2"+
			"\xFFFF\x1\xA\x3\xFFFF\x1\x2\x1\xFFFF\x1\x5\x7\xFFFF\x1\x8\x1\x7\x4\xFFFF"+
			"\x1\x4\x1\x9\x1\xFFFF\x1\xC\x1\xFFFF\x1\xB\x1\x1";
		private const string DFA9_specialS =
			"\x53\xFFFF}>";
		private static readonly string[] DFA9_transitionS =
			{
				"\x2\x10\x1\xFFFF\x2\x10\x12\xFFFF\x1\x10\x7\xFFFF\x1\xC\x1\xD\x1\x16"+
				"\x1\x14\x1\xFFFF\x1\x15\x1\xF\x1\x11\xA\x12\x1\x17\x1\xE\x1\x19\x1\x1A"+
				"\x1\x18\x2\xFFFF\x1A\x13\x4\xFFFF\x1\x13\x1\xFFFF\x1\x2\x1\x4\x1\x13"+
				"\x1\x9\x1\x5\x3\x13\x1\x6\x5\x13\x1\x3\x1\x1\x1\x13\x1\xA\x1\x13\x1"+
				"\x7\x1\xB\x1\x13\x1\x8\x3\x13",
				"\x1\x1B",
				"\x1\x1C",
				"\x1\x1D",
				"\x1\x1E",
				"\x1\x20\x1\xFFFF\x1\x1F",
				"\x1\x21",
				"\x1\x22",
				"\x1\x23",
				"\x1\x24",
				"\x1\x25",
				"\x1\x26",
				"",
				"",
				"",
				"",
				"",
				"\x1\x28\x4\xFFFF\x1\x27",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x2A",
				"\x1\x2C\x1\x2D",
				"",
				"\x1\x2F",
				"\x1\x30",
				"\xA\x13\x7\xFFFF\x1A\x13\x4\xFFFF\x1\x13\x1\xFFFF\x1A\x13",
				"\x1\x32",
				"\x1\x33",
				"\x1\x34",
				"\xA\x13\x7\xFFFF\x1A\x13\x4\xFFFF\x1\x13\x1\xFFFF\x1A\x13",
				"\x1\x36",
				"\x1\x37",
				"\xA\x13\x7\xFFFF\x1A\x13\x4\xFFFF\x1\x13\x1\xFFFF\x1A\x13",
				"\x1\x39",
				"\x1\x3A",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x3B",
				"\xA\x13\x7\xFFFF\x1A\x13\x4\xFFFF\x1\x13\x1\xFFFF\x1A\x13",
				"",
				"\x1\x3D",
				"\xA\x13\x7\xFFFF\x1A\x13\x4\xFFFF\x1\x13\x1\xFFFF\x1A\x13",
				"\x1\x3F",
				"",
				"\x1\x40",
				"\x1\x41",
				"",
				"\x1\x42",
				"\x1\x43",
				"\x1\x44",
				"",
				"\x1\x45",
				"",
				"\xA\x13\x7\xFFFF\x1A\x13\x4\xFFFF\x1\x13\x1\xFFFF\x1A\x13",
				"\xA\x13\x7\xFFFF\x1A\x13\x4\xFFFF\x1\x13\x1\xFFFF\x1A\x13",
				"\x1\x48",
				"\x1\x49",
				"\x1\x4A",
				"\x1\x4B",
				"\xA\x13\x7\xFFFF\x1A\x13\x4\xFFFF\x1\x13\x1\xFFFF\x1A\x13",
				"",
				"",
				"\xA\x13\x7\xFFFF\x1A\x13\x4\xFFFF\x1\x13\x1\xFFFF\x1A\x13",
				"\x1\x4E",
				"\xA\x13\x7\xFFFF\x1A\x13\x4\xFFFF\x1\x13\x1\xFFFF\x1A\x13",
				"\x1\x50",
				"",
				"",
				"\xA\x13\x7\xFFFF\x1A\x13\x4\xFFFF\x1\x13\x1\xFFFF\x1A\x13",
				"",
				"\xA\x13\x7\xFFFF\x1A\x13\x4\xFFFF\x1\x13\x1\xFFFF\x1A\x13",
				"",
				""
			};

		private static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
		private static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
		private static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
		private static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
		private static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
		private static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
		private static readonly short[][] DFA9_transition;

		static DFA9()
		{
			int numStates = DFA9_transitionS.Length;
			DFA9_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA9_transition[i] = DFA.UnpackEncodedString(DFA9_transitionS[i]);
			}
		}

		public DFA9( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 9;
			this.eot = DFA9_eot;
			this.eof = DFA9_eof;
			this.min = DFA9_min;
			this.max = DFA9_max;
			this.accept = DFA9_accept;
			this.special = DFA9_special;
			this.transition = DFA9_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( PROGRAM | AND | OR | BEGIN | END | IF | THEN | ELSE | WHILE | DO | REPEAT | UNTIL | T__34 | T__35 | T__36 | T__37 | WS | SL_COMMENT | ML_COMMENT | NUMBER | IDENT | ADD | SUB | MUL | DIV | ASSIGN | GE | LE | NE | EQ | GT | LT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MathLang 
