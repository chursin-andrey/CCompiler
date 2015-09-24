// $ANTLR 3.3 Nov 30, 2010 12:50:56 CCompiler.g 2015-09-24 21:56:58

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class CCompilerLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__48=48;
	public const int T__49=49;
	public const int T__50=50;
	public const int T__51=51;
	public const int T__52=52;
	public const int T__53=53;
	public const int T__54=54;
	public const int T__55=55;
	public const int DO=4;
	public const int UNKNOWN=5;
	public const int BLOCK=6;
	public const int PARAMETERS=7;
	public const int CALL=8;
	public const int CONVERT=9;
	public const int IF=10;
	public const int ELSE=11;
	public const int FOR=12;
	public const int WHILE=13;
	public const int AND=14;
	public const int OR=15;
	public const int NOT=16;
	public const int XOR=17;
	public const int INT_DIV=18;
	public const int INT_MOD=19;
	public const int SHR=20;
	public const int SHL=21;
	public const int IN=22;
	public const int VAR=23;
	public const int RETURN=24;
	public const int ARRAY=25;
	public const int CAPACITY=26;
	public const int FUNCTION=27;
	public const int PROGRAM=28;
	public const int TRUE=29;
	public const int FALSE=30;
	public const int WS=31;
	public const int ML_COMMENT=32;
	public const int NUMBER=33;
	public const int IDENTIFIER=34;
	public const int ADD=35;
	public const int SUB=36;
	public const int MUL=37;
	public const int DIV=38;
	public const int BIT_AND=39;
	public const int BIT_OR=40;
	public const int ASSIGN=41;
	public const int GE=42;
	public const int LE=43;
	public const int NOTEQUALS=44;
	public const int EQUALS=45;
	public const int GT=46;
	public const int LT=47;

    // delegates
    // delegators

	public CCompilerLexer()
	{
		OnCreated();
	}

	public CCompilerLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public CCompilerLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "CCompiler.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_DO();
	partial void Leave_DO();

	// $ANTLR start "DO"
	[GrammarRule("DO")]
	private void mDO()
	{
		Enter_DO();
		EnterRule("DO", 1);
		TraceIn("DO", 1);
		try
		{
			int _type = DO;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:7:4: ( 'do' )
			DebugEnterAlt(1);
			// CCompiler.g:7:6: 'do'
			{
			DebugLocation(7, 6);
			Match("do"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DO", 1);
			LeaveRule("DO", 1);
			Leave_DO();
		}
	}
	// $ANTLR end "DO"

	partial void Enter_IF();
	partial void Leave_IF();

	// $ANTLR start "IF"
	[GrammarRule("IF")]
	private void mIF()
	{
		Enter_IF();
		EnterRule("IF", 2);
		TraceIn("IF", 2);
		try
		{
			int _type = IF;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:8:4: ( 'if' )
			DebugEnterAlt(1);
			// CCompiler.g:8:6: 'if'
			{
			DebugLocation(8, 6);
			Match("if"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IF", 2);
			LeaveRule("IF", 2);
			Leave_IF();
		}
	}
	// $ANTLR end "IF"

	partial void Enter_ELSE();
	partial void Leave_ELSE();

	// $ANTLR start "ELSE"
	[GrammarRule("ELSE")]
	private void mELSE()
	{
		Enter_ELSE();
		EnterRule("ELSE", 3);
		TraceIn("ELSE", 3);
		try
		{
			int _type = ELSE;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:9:6: ( 'else' )
			DebugEnterAlt(1);
			// CCompiler.g:9:8: 'else'
			{
			DebugLocation(9, 8);
			Match("else"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ELSE", 3);
			LeaveRule("ELSE", 3);
			Leave_ELSE();
		}
	}
	// $ANTLR end "ELSE"

	partial void Enter_FOR();
	partial void Leave_FOR();

	// $ANTLR start "FOR"
	[GrammarRule("FOR")]
	private void mFOR()
	{
		Enter_FOR();
		EnterRule("FOR", 4);
		TraceIn("FOR", 4);
		try
		{
			int _type = FOR;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:10:5: ( 'for' )
			DebugEnterAlt(1);
			// CCompiler.g:10:7: 'for'
			{
			DebugLocation(10, 7);
			Match("for"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FOR", 4);
			LeaveRule("FOR", 4);
			Leave_FOR();
		}
	}
	// $ANTLR end "FOR"

	partial void Enter_WHILE();
	partial void Leave_WHILE();

	// $ANTLR start "WHILE"
	[GrammarRule("WHILE")]
	private void mWHILE()
	{
		Enter_WHILE();
		EnterRule("WHILE", 5);
		TraceIn("WHILE", 5);
		try
		{
			int _type = WHILE;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:11:7: ( 'while' )
			DebugEnterAlt(1);
			// CCompiler.g:11:9: 'while'
			{
			DebugLocation(11, 9);
			Match("while"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHILE", 5);
			LeaveRule("WHILE", 5);
			Leave_WHILE();
		}
	}
	// $ANTLR end "WHILE"

	partial void Enter_AND();
	partial void Leave_AND();

	// $ANTLR start "AND"
	[GrammarRule("AND")]
	private void mAND()
	{
		Enter_AND();
		EnterRule("AND", 6);
		TraceIn("AND", 6);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:12:5: ( '&&' )
			DebugEnterAlt(1);
			// CCompiler.g:12:7: '&&'
			{
			DebugLocation(12, 7);
			Match("&&"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 6);
			LeaveRule("AND", 6);
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
		EnterRule("OR", 7);
		TraceIn("OR", 7);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:13:4: ( '||' )
			DebugEnterAlt(1);
			// CCompiler.g:13:6: '||'
			{
			DebugLocation(13, 6);
			Match("||"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 7);
			LeaveRule("OR", 7);
			Leave_OR();
		}
	}
	// $ANTLR end "OR"

	partial void Enter_NOT();
	partial void Leave_NOT();

	// $ANTLR start "NOT"
	[GrammarRule("NOT")]
	private void mNOT()
	{
		Enter_NOT();
		EnterRule("NOT", 8);
		TraceIn("NOT", 8);
		try
		{
			int _type = NOT;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:14:5: ( '!' )
			DebugEnterAlt(1);
			// CCompiler.g:14:7: '!'
			{
			DebugLocation(14, 7);
			Match('!'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOT", 8);
			LeaveRule("NOT", 8);
			Leave_NOT();
		}
	}
	// $ANTLR end "NOT"

	partial void Enter_XOR();
	partial void Leave_XOR();

	// $ANTLR start "XOR"
	[GrammarRule("XOR")]
	private void mXOR()
	{
		Enter_XOR();
		EnterRule("XOR", 9);
		TraceIn("XOR", 9);
		try
		{
			int _type = XOR;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:15:5: ( 'xor' )
			DebugEnterAlt(1);
			// CCompiler.g:15:7: 'xor'
			{
			DebugLocation(15, 7);
			Match("xor"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("XOR", 9);
			LeaveRule("XOR", 9);
			Leave_XOR();
		}
	}
	// $ANTLR end "XOR"

	partial void Enter_INT_DIV();
	partial void Leave_INT_DIV();

	// $ANTLR start "INT_DIV"
	[GrammarRule("INT_DIV")]
	private void mINT_DIV()
	{
		Enter_INT_DIV();
		EnterRule("INT_DIV", 10);
		TraceIn("INT_DIV", 10);
		try
		{
			int _type = INT_DIV;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:16:9: ( 'div' )
			DebugEnterAlt(1);
			// CCompiler.g:16:11: 'div'
			{
			DebugLocation(16, 11);
			Match("div"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INT_DIV", 10);
			LeaveRule("INT_DIV", 10);
			Leave_INT_DIV();
		}
	}
	// $ANTLR end "INT_DIV"

	partial void Enter_INT_MOD();
	partial void Leave_INT_MOD();

	// $ANTLR start "INT_MOD"
	[GrammarRule("INT_MOD")]
	private void mINT_MOD()
	{
		Enter_INT_MOD();
		EnterRule("INT_MOD", 11);
		TraceIn("INT_MOD", 11);
		try
		{
			int _type = INT_MOD;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:17:9: ( 'mod' )
			DebugEnterAlt(1);
			// CCompiler.g:17:11: 'mod'
			{
			DebugLocation(17, 11);
			Match("mod"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INT_MOD", 11);
			LeaveRule("INT_MOD", 11);
			Leave_INT_MOD();
		}
	}
	// $ANTLR end "INT_MOD"

	partial void Enter_SHR();
	partial void Leave_SHR();

	// $ANTLR start "SHR"
	[GrammarRule("SHR")]
	private void mSHR()
	{
		Enter_SHR();
		EnterRule("SHR", 12);
		TraceIn("SHR", 12);
		try
		{
			int _type = SHR;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:18:5: ( 'shr' )
			DebugEnterAlt(1);
			// CCompiler.g:18:7: 'shr'
			{
			DebugLocation(18, 7);
			Match("shr"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SHR", 12);
			LeaveRule("SHR", 12);
			Leave_SHR();
		}
	}
	// $ANTLR end "SHR"

	partial void Enter_SHL();
	partial void Leave_SHL();

	// $ANTLR start "SHL"
	[GrammarRule("SHL")]
	private void mSHL()
	{
		Enter_SHL();
		EnterRule("SHL", 13);
		TraceIn("SHL", 13);
		try
		{
			int _type = SHL;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:19:5: ( 'shl' )
			DebugEnterAlt(1);
			// CCompiler.g:19:7: 'shl'
			{
			DebugLocation(19, 7);
			Match("shl"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SHL", 13);
			LeaveRule("SHL", 13);
			Leave_SHL();
		}
	}
	// $ANTLR end "SHL"

	partial void Enter_IN();
	partial void Leave_IN();

	// $ANTLR start "IN"
	[GrammarRule("IN")]
	private void mIN()
	{
		Enter_IN();
		EnterRule("IN", 14);
		TraceIn("IN", 14);
		try
		{
			int _type = IN;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:20:4: ( 'in' )
			DebugEnterAlt(1);
			// CCompiler.g:20:6: 'in'
			{
			DebugLocation(20, 6);
			Match("in"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IN", 14);
			LeaveRule("IN", 14);
			Leave_IN();
		}
	}
	// $ANTLR end "IN"

	partial void Enter_VAR();
	partial void Leave_VAR();

	// $ANTLR start "VAR"
	[GrammarRule("VAR")]
	private void mVAR()
	{
		Enter_VAR();
		EnterRule("VAR", 15);
		TraceIn("VAR", 15);
		try
		{
			int _type = VAR;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:21:5: ( 'var' )
			DebugEnterAlt(1);
			// CCompiler.g:21:7: 'var'
			{
			DebugLocation(21, 7);
			Match("var"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VAR", 15);
			LeaveRule("VAR", 15);
			Leave_VAR();
		}
	}
	// $ANTLR end "VAR"

	partial void Enter_RETURN();
	partial void Leave_RETURN();

	// $ANTLR start "RETURN"
	[GrammarRule("RETURN")]
	private void mRETURN()
	{
		Enter_RETURN();
		EnterRule("RETURN", 16);
		TraceIn("RETURN", 16);
		try
		{
			int _type = RETURN;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:22:8: ( 'return' )
			DebugEnterAlt(1);
			// CCompiler.g:22:10: 'return'
			{
			DebugLocation(22, 10);
			Match("return"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RETURN", 16);
			LeaveRule("RETURN", 16);
			Leave_RETURN();
		}
	}
	// $ANTLR end "RETURN"

	partial void Enter_ARRAY();
	partial void Leave_ARRAY();

	// $ANTLR start "ARRAY"
	[GrammarRule("ARRAY")]
	private void mARRAY()
	{
		Enter_ARRAY();
		EnterRule("ARRAY", 17);
		TraceIn("ARRAY", 17);
		try
		{
			int _type = ARRAY;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:23:7: ( 'array' )
			DebugEnterAlt(1);
			// CCompiler.g:23:9: 'array'
			{
			DebugLocation(23, 9);
			Match("array"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAY", 17);
			LeaveRule("ARRAY", 17);
			Leave_ARRAY();
		}
	}
	// $ANTLR end "ARRAY"

	partial void Enter_CAPACITY();
	partial void Leave_CAPACITY();

	// $ANTLR start "CAPACITY"
	[GrammarRule("CAPACITY")]
	private void mCAPACITY()
	{
		Enter_CAPACITY();
		EnterRule("CAPACITY", 18);
		TraceIn("CAPACITY", 18);
		try
		{
			int _type = CAPACITY;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:24:10: ( 'capacity' )
			DebugEnterAlt(1);
			// CCompiler.g:24:12: 'capacity'
			{
			DebugLocation(24, 12);
			Match("capacity"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CAPACITY", 18);
			LeaveRule("CAPACITY", 18);
			Leave_CAPACITY();
		}
	}
	// $ANTLR end "CAPACITY"

	partial void Enter_FUNCTION();
	partial void Leave_FUNCTION();

	// $ANTLR start "FUNCTION"
	[GrammarRule("FUNCTION")]
	private void mFUNCTION()
	{
		Enter_FUNCTION();
		EnterRule("FUNCTION", 19);
		TraceIn("FUNCTION", 19);
		try
		{
			int _type = FUNCTION;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:25:10: ( 'function' )
			DebugEnterAlt(1);
			// CCompiler.g:25:12: 'function'
			{
			DebugLocation(25, 12);
			Match("function"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FUNCTION", 19);
			LeaveRule("FUNCTION", 19);
			Leave_FUNCTION();
		}
	}
	// $ANTLR end "FUNCTION"

	partial void Enter_PROGRAM();
	partial void Leave_PROGRAM();

	// $ANTLR start "PROGRAM"
	[GrammarRule("PROGRAM")]
	private void mPROGRAM()
	{
		Enter_PROGRAM();
		EnterRule("PROGRAM", 20);
		TraceIn("PROGRAM", 20);
		try
		{
			int _type = PROGRAM;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:26:9: ( 'program' )
			DebugEnterAlt(1);
			// CCompiler.g:26:11: 'program'
			{
			DebugLocation(26, 11);
			Match("program"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PROGRAM", 20);
			LeaveRule("PROGRAM", 20);
			Leave_PROGRAM();
		}
	}
	// $ANTLR end "PROGRAM"

	partial void Enter_TRUE();
	partial void Leave_TRUE();

	// $ANTLR start "TRUE"
	[GrammarRule("TRUE")]
	private void mTRUE()
	{
		Enter_TRUE();
		EnterRule("TRUE", 21);
		TraceIn("TRUE", 21);
		try
		{
			int _type = TRUE;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:27:6: ( 'true' )
			DebugEnterAlt(1);
			// CCompiler.g:27:8: 'true'
			{
			DebugLocation(27, 8);
			Match("true"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TRUE", 21);
			LeaveRule("TRUE", 21);
			Leave_TRUE();
		}
	}
	// $ANTLR end "TRUE"

	partial void Enter_FALSE();
	partial void Leave_FALSE();

	// $ANTLR start "FALSE"
	[GrammarRule("FALSE")]
	private void mFALSE()
	{
		Enter_FALSE();
		EnterRule("FALSE", 22);
		TraceIn("FALSE", 22);
		try
		{
			int _type = FALSE;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:28:7: ( 'false' )
			DebugEnterAlt(1);
			// CCompiler.g:28:9: 'false'
			{
			DebugLocation(28, 9);
			Match("false"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FALSE", 22);
			LeaveRule("FALSE", 22);
			Leave_FALSE();
		}
	}
	// $ANTLR end "FALSE"

	partial void Enter_T__48();
	partial void Leave_T__48();

	// $ANTLR start "T__48"
	[GrammarRule("T__48")]
	private void mT__48()
	{
		Enter_T__48();
		EnterRule("T__48", 23);
		TraceIn("T__48", 23);
		try
		{
			int _type = T__48;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:29:7: ( ',' )
			DebugEnterAlt(1);
			// CCompiler.g:29:9: ','
			{
			DebugLocation(29, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__48", 23);
			LeaveRule("T__48", 23);
			Leave_T__48();
		}
	}
	// $ANTLR end "T__48"

	partial void Enter_T__49();
	partial void Leave_T__49();

	// $ANTLR start "T__49"
	[GrammarRule("T__49")]
	private void mT__49()
	{
		Enter_T__49();
		EnterRule("T__49", 24);
		TraceIn("T__49", 24);
		try
		{
			int _type = T__49;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:30:7: ( '(' )
			DebugEnterAlt(1);
			// CCompiler.g:30:9: '('
			{
			DebugLocation(30, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__49", 24);
			LeaveRule("T__49", 24);
			Leave_T__49();
		}
	}
	// $ANTLR end "T__49"

	partial void Enter_T__50();
	partial void Leave_T__50();

	// $ANTLR start "T__50"
	[GrammarRule("T__50")]
	private void mT__50()
	{
		Enter_T__50();
		EnterRule("T__50", 25);
		TraceIn("T__50", 25);
		try
		{
			int _type = T__50;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:31:7: ( ')' )
			DebugEnterAlt(1);
			// CCompiler.g:31:9: ')'
			{
			DebugLocation(31, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__50", 25);
			LeaveRule("T__50", 25);
			Leave_T__50();
		}
	}
	// $ANTLR end "T__50"

	partial void Enter_T__51();
	partial void Leave_T__51();

	// $ANTLR start "T__51"
	[GrammarRule("T__51")]
	private void mT__51()
	{
		Enter_T__51();
		EnterRule("T__51", 26);
		TraceIn("T__51", 26);
		try
		{
			int _type = T__51;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:32:7: ( '{' )
			DebugEnterAlt(1);
			// CCompiler.g:32:9: '{'
			{
			DebugLocation(32, 9);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__51", 26);
			LeaveRule("T__51", 26);
			Leave_T__51();
		}
	}
	// $ANTLR end "T__51"

	partial void Enter_T__52();
	partial void Leave_T__52();

	// $ANTLR start "T__52"
	[GrammarRule("T__52")]
	private void mT__52()
	{
		Enter_T__52();
		EnterRule("T__52", 27);
		TraceIn("T__52", 27);
		try
		{
			int _type = T__52;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:33:7: ( '}' )
			DebugEnterAlt(1);
			// CCompiler.g:33:9: '}'
			{
			DebugLocation(33, 9);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__52", 27);
			LeaveRule("T__52", 27);
			Leave_T__52();
		}
	}
	// $ANTLR end "T__52"

	partial void Enter_T__53();
	partial void Leave_T__53();

	// $ANTLR start "T__53"
	[GrammarRule("T__53")]
	private void mT__53()
	{
		Enter_T__53();
		EnterRule("T__53", 28);
		TraceIn("T__53", 28);
		try
		{
			int _type = T__53;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:34:7: ( ';' )
			DebugEnterAlt(1);
			// CCompiler.g:34:9: ';'
			{
			DebugLocation(34, 9);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__53", 28);
			LeaveRule("T__53", 28);
			Leave_T__53();
		}
	}
	// $ANTLR end "T__53"

	partial void Enter_T__54();
	partial void Leave_T__54();

	// $ANTLR start "T__54"
	[GrammarRule("T__54")]
	private void mT__54()
	{
		Enter_T__54();
		EnterRule("T__54", 29);
		TraceIn("T__54", 29);
		try
		{
			int _type = T__54;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:35:7: ( '[' )
			DebugEnterAlt(1);
			// CCompiler.g:35:9: '['
			{
			DebugLocation(35, 9);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__54", 29);
			LeaveRule("T__54", 29);
			Leave_T__54();
		}
	}
	// $ANTLR end "T__54"

	partial void Enter_T__55();
	partial void Leave_T__55();

	// $ANTLR start "T__55"
	[GrammarRule("T__55")]
	private void mT__55()
	{
		Enter_T__55();
		EnterRule("T__55", 30);
		TraceIn("T__55", 30);
		try
		{
			int _type = T__55;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:36:7: ( ']' )
			DebugEnterAlt(1);
			// CCompiler.g:36:9: ']'
			{
			DebugLocation(36, 9);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__55", 30);
			LeaveRule("T__55", 30);
			Leave_T__55();
		}
	}
	// $ANTLR end "T__55"

	partial void Enter_WS();
	partial void Leave_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		Enter_WS();
		EnterRule("WS", 31);
		TraceIn("WS", 31);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:41:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// CCompiler.g:42:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(42, 3);
			// CCompiler.g:42:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
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
					// CCompiler.g:
					{
					DebugLocation(42, 3);
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

			DebugLocation(42, 40);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 31);
			LeaveRule("WS", 31);
			Leave_WS();
		}
	}
	// $ANTLR end "WS"

	partial void Enter_ML_COMMENT();
	partial void Leave_ML_COMMENT();

	// $ANTLR start "ML_COMMENT"
	[GrammarRule("ML_COMMENT")]
	private void mML_COMMENT()
	{
		Enter_ML_COMMENT();
		EnterRule("ML_COMMENT", 32);
		TraceIn("ML_COMMENT", 32);
		try
		{
			int _type = ML_COMMENT;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:48:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// CCompiler.g:49:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(49, 3);
			Match("/*"); 

			DebugLocation(49, 8);
			// CCompiler.g:49:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if ((LA2_0=='*'))
				{
					int LA2_1 = input.LA(2);

					if ((LA2_1=='/'))
					{
						alt2=2;
					}
					else if (((LA2_1>='\u0000' && LA2_1<='.')||(LA2_1>='0' && LA2_1<='\uFFFF')))
					{
						alt2=1;
					}


				}
				else if (((LA2_0>='\u0000' && LA2_0<=')')||(LA2_0>='+' && LA2_0<='\uFFFF')))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// CCompiler.g:49:38: .
					{
					DebugLocation(49, 38);
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

			DebugLocation(49, 43);
			Match("*/"); 

			DebugLocation(49, 48);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ML_COMMENT", 32);
			LeaveRule("ML_COMMENT", 32);
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
		EnterRule("NUMBER", 33);
		TraceIn("NUMBER", 33);
		try
		{
			int _type = NUMBER;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:55:7: ( ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )? )
			DebugEnterAlt(1);
			// CCompiler.g:55:9: ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )?
			{
			DebugLocation(55, 9);
			// CCompiler.g:55:9: ( '0' .. '9' )+
			int cnt3=0;
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if (((LA3_0>='0' && LA3_0<='9')))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch (alt3)
				{
				case 1:
					DebugEnterAlt(1);
					// CCompiler.g:55:10: '0' .. '9'
					{
					DebugLocation(55, 10);
					MatchRange('0','9'); 

					}
					break;

				default:
					if (cnt3 >= 1)
						goto loop3;

					EarlyExitException eee3 = new EarlyExitException( 3, input );
					DebugRecognitionException(eee3);
					throw eee3;
				}
				cnt3++;
			}
			loop3:
				;

			} finally { DebugExitSubRule(3); }

			DebugLocation(55, 21);
			// CCompiler.g:55:21: ( '.' ( '0' .. '9' )+ )?
			int alt5=2;
			try { DebugEnterSubRule(5);
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			int LA5_0 = input.LA(1);

			if ((LA5_0=='.'))
			{
				alt5=1;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// CCompiler.g:55:22: '.' ( '0' .. '9' )+
				{
				DebugLocation(55, 22);
				Match('.'); 
				DebugLocation(55, 26);
				// CCompiler.g:55:26: ( '0' .. '9' )+
				int cnt4=0;
				try { DebugEnterSubRule(4);
				while (true)
				{
					int alt4=2;
					try { DebugEnterDecision(4, decisionCanBacktrack[4]);
					int LA4_0 = input.LA(1);

					if (((LA4_0>='0' && LA4_0<='9')))
					{
						alt4=1;
					}


					} finally { DebugExitDecision(4); }
					switch (alt4)
					{
					case 1:
						DebugEnterAlt(1);
						// CCompiler.g:55:27: '0' .. '9'
						{
						DebugLocation(55, 27);
						MatchRange('0','9'); 

						}
						break;

					default:
						if (cnt4 >= 1)
							goto loop4;

						EarlyExitException eee4 = new EarlyExitException( 4, input );
						DebugRecognitionException(eee4);
						throw eee4;
					}
					cnt4++;
				}
				loop4:
					;

				} finally { DebugExitSubRule(4); }


				}
				break;

			}
			} finally { DebugExitSubRule(5); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NUMBER", 33);
			LeaveRule("NUMBER", 33);
			Leave_NUMBER();
		}
	}
	// $ANTLR end "NUMBER"

	partial void Enter_IDENTIFIER();
	partial void Leave_IDENTIFIER();

	// $ANTLR start "IDENTIFIER"
	[GrammarRule("IDENTIFIER")]
	private void mIDENTIFIER()
	{
		Enter_IDENTIFIER();
		EnterRule("IDENTIFIER", 34);
		TraceIn("IDENTIFIER", 34);
		try
		{
			int _type = IDENTIFIER;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:57:11: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )* )
			DebugEnterAlt(1);
			// CCompiler.g:57:14: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
			{
			DebugLocation(57, 14);
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

			DebugLocation(58, 9);
			// CCompiler.g:58:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, decisionCanBacktrack[6]);
				int LA6_0 = input.LA(1);

				if (((LA6_0>='0' && LA6_0<='9')||(LA6_0>='A' && LA6_0<='Z')||LA6_0=='_'||(LA6_0>='a' && LA6_0<='z')))
				{
					alt6=1;
				}


				} finally { DebugExitDecision(6); }
				switch ( alt6 )
				{
				case 1:
					DebugEnterAlt(1);
					// CCompiler.g:
					{
					DebugLocation(58, 9);
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
					goto loop6;
				}
			}

			loop6:
				;

			} finally { DebugExitSubRule(6); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IDENTIFIER", 34);
			LeaveRule("IDENTIFIER", 34);
			Leave_IDENTIFIER();
		}
	}
	// $ANTLR end "IDENTIFIER"

	partial void Enter_ADD();
	partial void Leave_ADD();

	// $ANTLR start "ADD"
	[GrammarRule("ADD")]
	private void mADD()
	{
		Enter_ADD();
		EnterRule("ADD", 35);
		TraceIn("ADD", 35);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:60:4: ( '+' )
			DebugEnterAlt(1);
			// CCompiler.g:60:10: '+'
			{
			DebugLocation(60, 10);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 35);
			LeaveRule("ADD", 35);
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
		EnterRule("SUB", 36);
		TraceIn("SUB", 36);
		try
		{
			int _type = SUB;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:61:4: ( '-' )
			DebugEnterAlt(1);
			// CCompiler.g:61:10: '-'
			{
			DebugLocation(61, 10);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SUB", 36);
			LeaveRule("SUB", 36);
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
		EnterRule("MUL", 37);
		TraceIn("MUL", 37);
		try
		{
			int _type = MUL;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:62:4: ( '*' )
			DebugEnterAlt(1);
			// CCompiler.g:62:10: '*'
			{
			DebugLocation(62, 10);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MUL", 37);
			LeaveRule("MUL", 37);
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
		EnterRule("DIV", 38);
		TraceIn("DIV", 38);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:63:4: ( '/' )
			DebugEnterAlt(1);
			// CCompiler.g:63:10: '/'
			{
			DebugLocation(63, 10);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 38);
			LeaveRule("DIV", 38);
			Leave_DIV();
		}
	}
	// $ANTLR end "DIV"

	partial void Enter_BIT_AND();
	partial void Leave_BIT_AND();

	// $ANTLR start "BIT_AND"
	[GrammarRule("BIT_AND")]
	private void mBIT_AND()
	{
		Enter_BIT_AND();
		EnterRule("BIT_AND", 39);
		TraceIn("BIT_AND", 39);
		try
		{
			int _type = BIT_AND;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:64:8: ( '&' )
			DebugEnterAlt(1);
			// CCompiler.g:64:10: '&'
			{
			DebugLocation(64, 10);
			Match('&'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BIT_AND", 39);
			LeaveRule("BIT_AND", 39);
			Leave_BIT_AND();
		}
	}
	// $ANTLR end "BIT_AND"

	partial void Enter_BIT_OR();
	partial void Leave_BIT_OR();

	// $ANTLR start "BIT_OR"
	[GrammarRule("BIT_OR")]
	private void mBIT_OR()
	{
		Enter_BIT_OR();
		EnterRule("BIT_OR", 40);
		TraceIn("BIT_OR", 40);
		try
		{
			int _type = BIT_OR;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:65:7: ( '|' )
			DebugEnterAlt(1);
			// CCompiler.g:65:10: '|'
			{
			DebugLocation(65, 10);
			Match('|'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BIT_OR", 40);
			LeaveRule("BIT_OR", 40);
			Leave_BIT_OR();
		}
	}
	// $ANTLR end "BIT_OR"

	partial void Enter_ASSIGN();
	partial void Leave_ASSIGN();

	// $ANTLR start "ASSIGN"
	[GrammarRule("ASSIGN")]
	private void mASSIGN()
	{
		Enter_ASSIGN();
		EnterRule("ASSIGN", 41);
		TraceIn("ASSIGN", 41);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:66:7: ( '=' )
			DebugEnterAlt(1);
			// CCompiler.g:66:10: '='
			{
			DebugLocation(66, 10);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 41);
			LeaveRule("ASSIGN", 41);
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
		EnterRule("GE", 42);
		TraceIn("GE", 42);
		try
		{
			int _type = GE;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:67:3: ( '>=' )
			DebugEnterAlt(1);
			// CCompiler.g:67:11: '>='
			{
			DebugLocation(67, 11);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GE", 42);
			LeaveRule("GE", 42);
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
		EnterRule("LE", 43);
		TraceIn("LE", 43);
		try
		{
			int _type = LE;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:68:3: ( '<=' )
			DebugEnterAlt(1);
			// CCompiler.g:68:11: '<='
			{
			DebugLocation(68, 11);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LE", 43);
			LeaveRule("LE", 43);
			Leave_LE();
		}
	}
	// $ANTLR end "LE"

	partial void Enter_NOTEQUALS();
	partial void Leave_NOTEQUALS();

	// $ANTLR start "NOTEQUALS"
	[GrammarRule("NOTEQUALS")]
	private void mNOTEQUALS()
	{
		Enter_NOTEQUALS();
		EnterRule("NOTEQUALS", 44);
		TraceIn("NOTEQUALS", 44);
		try
		{
			int _type = NOTEQUALS;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:69:10: ( '!=' )
			DebugEnterAlt(1);
			// CCompiler.g:69:13: '!='
			{
			DebugLocation(69, 13);
			Match("!="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOTEQUALS", 44);
			LeaveRule("NOTEQUALS", 44);
			Leave_NOTEQUALS();
		}
	}
	// $ANTLR end "NOTEQUALS"

	partial void Enter_EQUALS();
	partial void Leave_EQUALS();

	// $ANTLR start "EQUALS"
	[GrammarRule("EQUALS")]
	private void mEQUALS()
	{
		Enter_EQUALS();
		EnterRule("EQUALS", 45);
		TraceIn("EQUALS", 45);
		try
		{
			int _type = EQUALS;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:70:7: ( '==' )
			DebugEnterAlt(1);
			// CCompiler.g:70:11: '=='
			{
			DebugLocation(70, 11);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQUALS", 45);
			LeaveRule("EQUALS", 45);
			Leave_EQUALS();
		}
	}
	// $ANTLR end "EQUALS"

	partial void Enter_GT();
	partial void Leave_GT();

	// $ANTLR start "GT"
	[GrammarRule("GT")]
	private void mGT()
	{
		Enter_GT();
		EnterRule("GT", 46);
		TraceIn("GT", 46);
		try
		{
			int _type = GT;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:71:3: ( '>' )
			DebugEnterAlt(1);
			// CCompiler.g:71:11: '>'
			{
			DebugLocation(71, 11);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GT", 46);
			LeaveRule("GT", 46);
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
		EnterRule("LT", 47);
		TraceIn("LT", 47);
		try
		{
			int _type = LT;
			int _channel = DefaultTokenChannel;
			// CCompiler.g:72:3: ( '<' )
			DebugEnterAlt(1);
			// CCompiler.g:72:11: '<'
			{
			DebugLocation(72, 11);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LT", 47);
			LeaveRule("LT", 47);
			Leave_LT();
		}
	}
	// $ANTLR end "LT"

	public override void mTokens()
	{
		// CCompiler.g:1:8: ( DO | IF | ELSE | FOR | WHILE | AND | OR | NOT | XOR | INT_DIV | INT_MOD | SHR | SHL | IN | VAR | RETURN | ARRAY | CAPACITY | FUNCTION | PROGRAM | TRUE | FALSE | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | WS | ML_COMMENT | NUMBER | IDENTIFIER | ADD | SUB | MUL | DIV | BIT_AND | BIT_OR | ASSIGN | GE | LE | NOTEQUALS | EQUALS | GT | LT )
		int alt7=47;
		try { DebugEnterDecision(7, decisionCanBacktrack[7]);
		try
		{
			alt7 = dfa7.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(7); }
		switch (alt7)
		{
		case 1:
			DebugEnterAlt(1);
			// CCompiler.g:1:10: DO
			{
			DebugLocation(1, 10);
			mDO(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// CCompiler.g:1:13: IF
			{
			DebugLocation(1, 13);
			mIF(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// CCompiler.g:1:16: ELSE
			{
			DebugLocation(1, 16);
			mELSE(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// CCompiler.g:1:21: FOR
			{
			DebugLocation(1, 21);
			mFOR(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// CCompiler.g:1:25: WHILE
			{
			DebugLocation(1, 25);
			mWHILE(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// CCompiler.g:1:31: AND
			{
			DebugLocation(1, 31);
			mAND(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// CCompiler.g:1:35: OR
			{
			DebugLocation(1, 35);
			mOR(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// CCompiler.g:1:38: NOT
			{
			DebugLocation(1, 38);
			mNOT(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// CCompiler.g:1:42: XOR
			{
			DebugLocation(1, 42);
			mXOR(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// CCompiler.g:1:46: INT_DIV
			{
			DebugLocation(1, 46);
			mINT_DIV(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// CCompiler.g:1:54: INT_MOD
			{
			DebugLocation(1, 54);
			mINT_MOD(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// CCompiler.g:1:62: SHR
			{
			DebugLocation(1, 62);
			mSHR(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// CCompiler.g:1:66: SHL
			{
			DebugLocation(1, 66);
			mSHL(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// CCompiler.g:1:70: IN
			{
			DebugLocation(1, 70);
			mIN(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// CCompiler.g:1:73: VAR
			{
			DebugLocation(1, 73);
			mVAR(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// CCompiler.g:1:77: RETURN
			{
			DebugLocation(1, 77);
			mRETURN(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// CCompiler.g:1:84: ARRAY
			{
			DebugLocation(1, 84);
			mARRAY(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// CCompiler.g:1:90: CAPACITY
			{
			DebugLocation(1, 90);
			mCAPACITY(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// CCompiler.g:1:99: FUNCTION
			{
			DebugLocation(1, 99);
			mFUNCTION(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// CCompiler.g:1:108: PROGRAM
			{
			DebugLocation(1, 108);
			mPROGRAM(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// CCompiler.g:1:116: TRUE
			{
			DebugLocation(1, 116);
			mTRUE(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// CCompiler.g:1:121: FALSE
			{
			DebugLocation(1, 121);
			mFALSE(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// CCompiler.g:1:127: T__48
			{
			DebugLocation(1, 127);
			mT__48(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// CCompiler.g:1:133: T__49
			{
			DebugLocation(1, 133);
			mT__49(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// CCompiler.g:1:139: T__50
			{
			DebugLocation(1, 139);
			mT__50(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// CCompiler.g:1:145: T__51
			{
			DebugLocation(1, 145);
			mT__51(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// CCompiler.g:1:151: T__52
			{
			DebugLocation(1, 151);
			mT__52(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// CCompiler.g:1:157: T__53
			{
			DebugLocation(1, 157);
			mT__53(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// CCompiler.g:1:163: T__54
			{
			DebugLocation(1, 163);
			mT__54(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// CCompiler.g:1:169: T__55
			{
			DebugLocation(1, 169);
			mT__55(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// CCompiler.g:1:175: WS
			{
			DebugLocation(1, 175);
			mWS(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// CCompiler.g:1:178: ML_COMMENT
			{
			DebugLocation(1, 178);
			mML_COMMENT(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// CCompiler.g:1:189: NUMBER
			{
			DebugLocation(1, 189);
			mNUMBER(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// CCompiler.g:1:196: IDENTIFIER
			{
			DebugLocation(1, 196);
			mIDENTIFIER(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// CCompiler.g:1:207: ADD
			{
			DebugLocation(1, 207);
			mADD(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// CCompiler.g:1:211: SUB
			{
			DebugLocation(1, 211);
			mSUB(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// CCompiler.g:1:215: MUL
			{
			DebugLocation(1, 215);
			mMUL(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// CCompiler.g:1:219: DIV
			{
			DebugLocation(1, 219);
			mDIV(); 

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// CCompiler.g:1:223: BIT_AND
			{
			DebugLocation(1, 223);
			mBIT_AND(); 

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// CCompiler.g:1:231: BIT_OR
			{
			DebugLocation(1, 231);
			mBIT_OR(); 

			}
			break;
		case 41:
			DebugEnterAlt(41);
			// CCompiler.g:1:238: ASSIGN
			{
			DebugLocation(1, 238);
			mASSIGN(); 

			}
			break;
		case 42:
			DebugEnterAlt(42);
			// CCompiler.g:1:245: GE
			{
			DebugLocation(1, 245);
			mGE(); 

			}
			break;
		case 43:
			DebugEnterAlt(43);
			// CCompiler.g:1:248: LE
			{
			DebugLocation(1, 248);
			mLE(); 

			}
			break;
		case 44:
			DebugEnterAlt(44);
			// CCompiler.g:1:251: NOTEQUALS
			{
			DebugLocation(1, 251);
			mNOTEQUALS(); 

			}
			break;
		case 45:
			DebugEnterAlt(45);
			// CCompiler.g:1:261: EQUALS
			{
			DebugLocation(1, 261);
			mEQUALS(); 

			}
			break;
		case 46:
			DebugEnterAlt(46);
			// CCompiler.g:1:268: GT
			{
			DebugLocation(1, 268);
			mGT(); 

			}
			break;
		case 47:
			DebugEnterAlt(47);
			// CCompiler.g:1:271: LT
			{
			DebugLocation(1, 271);
			mLT(); 

			}
			break;

		}

	}


	#region DFA
	DFA7 dfa7;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa7 = new DFA7(this);
	}

	private class DFA7 : DFA
	{
		private const string DFA7_eotS =
			"\x1\xFFFF\x5\x1D\x1\x2E\x1\x30\x1\x32\x9\x1D\x9\xFFFF\x1\x3D\x5\xFFFF"+
			"\x1\x3F\x1\x41\x1\x43\x1\x44\x1\x1D\x1\x46\x1\x47\x5\x1D\x6\xFFFF\x9"+
			"\x1D\x9\xFFFF\x1\x57\x2\xFFFF\x1\x1D\x1\x59\x3\x1D\x1\x5D\x1\x5E\x1\x5F"+
			"\x1\x60\x1\x61\x5\x1D\x1\xFFFF\x1\x67\x1\xFFFF\x3\x1D\x5\xFFFF\x4\x1D"+
			"\x1\x6F\x1\xFFFF\x1\x1D\x1\x71\x1\x72\x1\x1D\x1\x74\x2\x1D\x1\xFFFF\x1"+
			"\x1D\x2\xFFFF\x1\x78\x1\xFFFF\x3\x1D\x1\xFFFF\x1\x1D\x1\x7D\x1\x7E\x1"+
			"\x7F\x3\xFFFF";
		private const string DFA7_eofS =
			"\x80\xFFFF";
		private const string DFA7_minS =
			"\x1\x9\x1\x69\x1\x66\x1\x6C\x1\x61\x1\x68\x1\x26\x1\x7C\x1\x3D\x2\x6F"+
			"\x1\x68\x1\x61\x1\x65\x1\x72\x1\x61\x2\x72\x9\xFFFF\x1\x2A\x5\xFFFF\x3"+
			"\x3D\x1\x30\x1\x76\x2\x30\x1\x73\x1\x72\x1\x6E\x1\x6C\x1\x69\x6\xFFFF"+
			"\x1\x72\x1\x64\x1\x6C\x1\x72\x1\x74\x1\x72\x1\x70\x1\x6F\x1\x75\x9\xFFFF"+
			"\x1\x30\x2\xFFFF\x1\x65\x1\x30\x1\x63\x1\x73\x1\x6C\x5\x30\x1\x75\x2"+
			"\x61\x1\x67\x1\x65\x1\xFFFF\x1\x30\x1\xFFFF\x1\x74\x2\x65\x5\xFFFF\x1"+
			"\x72\x1\x79\x1\x63\x1\x72\x1\x30\x1\xFFFF\x1\x69\x2\x30\x1\x6E\x1\x30"+
			"\x1\x69\x1\x61\x1\xFFFF\x1\x6F\x2\xFFFF\x1\x30\x1\xFFFF\x1\x74\x1\x6D"+
			"\x1\x6E\x1\xFFFF\x1\x79\x3\x30\x3\xFFFF";
		private const string DFA7_maxS =
			"\x1\x7D\x1\x6F\x1\x6E\x1\x6C\x1\x75\x1\x68\x1\x26\x1\x7C\x1\x3D\x2\x6F"+
			"\x1\x68\x1\x61\x1\x65\x1\x72\x1\x61\x2\x72\x9\xFFFF\x1\x2A\x5\xFFFF\x3"+
			"\x3D\x1\x7A\x1\x76\x2\x7A\x1\x73\x1\x72\x1\x6E\x1\x6C\x1\x69\x6\xFFFF"+
			"\x1\x72\x1\x64\x2\x72\x1\x74\x1\x72\x1\x70\x1\x6F\x1\x75\x9\xFFFF\x1"+
			"\x7A\x2\xFFFF\x1\x65\x1\x7A\x1\x63\x1\x73\x1\x6C\x5\x7A\x1\x75\x2\x61"+
			"\x1\x67\x1\x65\x1\xFFFF\x1\x7A\x1\xFFFF\x1\x74\x2\x65\x5\xFFFF\x1\x72"+
			"\x1\x79\x1\x63\x1\x72\x1\x7A\x1\xFFFF\x1\x69\x2\x7A\x1\x6E\x1\x7A\x1"+
			"\x69\x1\x61\x1\xFFFF\x1\x6F\x2\xFFFF\x1\x7A\x1\xFFFF\x1\x74\x1\x6D\x1"+
			"\x6E\x1\xFFFF\x1\x79\x3\x7A\x3\xFFFF";
		private const string DFA7_acceptS =
			"\x12\xFFFF\x1\x17\x1\x18\x1\x19\x1\x1A\x1\x1B\x1\x1C\x1\x1D\x1\x1E\x1"+
			"\x1F\x1\xFFFF\x1\x21\x1\x22\x1\x23\x1\x24\x1\x25\xC\xFFFF\x1\x6\x1\x27"+
			"\x1\x7\x1\x28\x1\x2C\x1\x8\x9\xFFFF\x1\x20\x1\x26\x1\x2D\x1\x29\x1\x2A"+
			"\x1\x2E\x1\x2B\x1\x2F\x1\x1\x1\xFFFF\x1\x2\x1\xE\xF\xFFFF\x1\xA\x1\xFFFF"+
			"\x1\x4\x3\xFFFF\x1\x9\x1\xB\x1\xC\x1\xD\x1\xF\x5\xFFFF\x1\x3\x7\xFFFF"+
			"\x1\x15\x1\xFFFF\x1\x16\x1\x5\x1\xFFFF\x1\x11\x3\xFFFF\x1\x10\x4\xFFFF"+
			"\x1\x14\x1\x13\x1\x12";
		private const string DFA7_specialS =
			"\x80\xFFFF}>";
		private static readonly string[] DFA7_transitionS =
			{
				"\x2\x1A\x1\xFFFF\x2\x1A\x12\xFFFF\x1\x1A\x1\x8\x4\xFFFF\x1\x6\x1\xFFFF"+
				"\x1\x13\x1\x14\x1\x20\x1\x1E\x1\x12\x1\x1F\x1\xFFFF\x1\x1B\xA\x1C\x1"+
				"\xFFFF\x1\x17\x1\x23\x1\x21\x1\x22\x2\xFFFF\x1A\x1D\x1\x18\x1\xFFFF"+
				"\x1\x19\x1\xFFFF\x1\x1D\x1\xFFFF\x1\xE\x1\x1D\x1\xF\x1\x1\x1\x3\x1\x4"+
				"\x2\x1D\x1\x2\x3\x1D\x1\xA\x2\x1D\x1\x10\x1\x1D\x1\xD\x1\xB\x1\x11\x1"+
				"\x1D\x1\xC\x1\x5\x1\x9\x2\x1D\x1\x15\x1\x7\x1\x16",
				"\x1\x25\x5\xFFFF\x1\x24",
				"\x1\x26\x7\xFFFF\x1\x27",
				"\x1\x28",
				"\x1\x2B\xD\xFFFF\x1\x29\x5\xFFFF\x1\x2A",
				"\x1\x2C",
				"\x1\x2D",
				"\x1\x2F",
				"\x1\x31",
				"\x1\x33",
				"\x1\x34",
				"\x1\x35",
				"\x1\x36",
				"\x1\x37",
				"\x1\x38",
				"\x1\x39",
				"\x1\x3A",
				"\x1\x3B",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x3C",
				"",
				"",
				"",
				"",
				"",
				"\x1\x3E",
				"\x1\x40",
				"\x1\x42",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"\x1\x45",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"\x1\x48",
				"\x1\x49",
				"\x1\x4A",
				"\x1\x4B",
				"\x1\x4C",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x4D",
				"\x1\x4E",
				"\x1\x50\x5\xFFFF\x1\x4F",
				"\x1\x51",
				"\x1\x52",
				"\x1\x53",
				"\x1\x54",
				"\x1\x55",
				"\x1\x56",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"",
				"",
				"\x1\x58",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"\x1\x5A",
				"\x1\x5B",
				"\x1\x5C",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"\x1\x62",
				"\x1\x63",
				"\x1\x64",
				"\x1\x65",
				"\x1\x66",
				"",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"",
				"\x1\x68",
				"\x1\x69",
				"\x1\x6A",
				"",
				"",
				"",
				"",
				"",
				"\x1\x6B",
				"\x1\x6C",
				"\x1\x6D",
				"\x1\x6E",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"",
				"\x1\x70",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"\x1\x73",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"\x1\x75",
				"\x1\x76",
				"",
				"\x1\x77",
				"",
				"",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"",
				"\x1\x79",
				"\x1\x7A",
				"\x1\x7B",
				"",
				"\x1\x7C",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"\xA\x1D\x7\xFFFF\x1A\x1D\x4\xFFFF\x1\x1D\x1\xFFFF\x1A\x1D",
				"",
				"",
				""
			};

		private static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
		private static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
		private static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
		private static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
		private static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
		private static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
		private static readonly short[][] DFA7_transition;

		static DFA7()
		{
			int numStates = DFA7_transitionS.Length;
			DFA7_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA7_transition[i] = DFA.UnpackEncodedString(DFA7_transitionS[i]);
			}
		}

		public DFA7( BaseRecognizer recognizer )
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

		public override string Description { get { return "1:1: Tokens : ( DO | IF | ELSE | FOR | WHILE | AND | OR | NOT | XOR | INT_DIV | INT_MOD | SHR | SHL | IN | VAR | RETURN | ARRAY | CAPACITY | FUNCTION | PROGRAM | TRUE | FALSE | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | WS | ML_COMMENT | NUMBER | IDENTIFIER | ADD | SUB | MUL | DIV | BIT_AND | BIT_OR | ASSIGN | GE | LE | NOTEQUALS | EQUALS | GT | LT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}
