// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2015-09-24 20:12:55

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;
using Map = System.Collections.IDictionary;
using HashMap = System.Collections.Generic.Dictionary<object, object>;

using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace  MathLang 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class MathLangParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "BLOCK", "PROGRAM", "AND", "OR", "BEGIN", "END", "IF", "THEN", "ELSE", "WHILE", "DO", "REPEAT", "UNTIL", "WS", "SL_COMMENT", "ML_COMMENT", "NUMBER", "IDENT", "ADD", "SUB", "MUL", "DIV", "ASSIGN", "GE", "LE", "NE", "EQ", "GT", "LT", "'('", "')'", "';'", "'.'"
	};
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

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, true, false, false, true, false, 
				, false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public MathLangParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public MathLangParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return MathLangParser.tokenNames; } }
	public override string GrammarFileName { get { return "MathLang.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public class group_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_group();
	partial void Leave_group();

	// $ANTLR start "group"
	// MathLang.g:82:1: group : ( '(' term ')' | NUMBER | IDENT );
	[GrammarRule("group")]
	private MathLangParser.group_return group()
	{
		Enter_group();
		EnterRule("group", 1);
		TraceIn("group", 1);
		MathLangParser.group_return retval = new MathLangParser.group_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal1=null;
		IToken char_literal3=null;
		IToken NUMBER4=null;
		IToken IDENT5=null;
		MathLangParser.term_return term2 = default(MathLangParser.term_return);

		object char_literal1_tree=null;
		object char_literal3_tree=null;
		object NUMBER4_tree=null;
		object IDENT5_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(82, 0);
		try
		{
			// MathLang.g:82:6: ( '(' term ')' | NUMBER | IDENT )
			int alt1=3;
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			switch (input.LA(1))
			{
			case 34:
				{
				alt1=1;
				}
				break;
			case NUMBER:
				{
				alt1=2;
				}
				break;
			case IDENT:
				{
				alt1=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 1, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:83:3: '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(83, 6);
				char_literal1=(IToken)Match(input,34,Follow._34_in_group616); if (state.failed) return retval;
				DebugLocation(83, 8);
				PushFollow(Follow._term_in_group619);
				term2=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term2.Tree);
				DebugLocation(83, 16);
				char_literal3=(IToken)Match(input,35,Follow._35_in_group621); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:84:3: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(84, 3);
				NUMBER4=(IToken)Match(input,NUMBER,Follow._NUMBER_in_group626); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER4_tree = (object)adaptor.Create(NUMBER4);
				adaptor.AddChild(root_0, NUMBER4_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:85:3: IDENT
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(85, 3);
				IDENT5=(IToken)Match(input,IDENT,Follow._IDENT_in_group630); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				IDENT5_tree = (object)adaptor.Create(IDENT5);
				adaptor.AddChild(root_0, IDENT5_tree);
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("group", 1);
			LeaveRule("group", 1);
			Leave_group();
		}
		DebugLocation(86, 0);
		} finally { DebugExitRule(GrammarFileName, "group"); }
		return retval;

	}
	// $ANTLR end "group"

	public class mult_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mult();
	partial void Leave_mult();

	// $ANTLR start "mult"
	// MathLang.g:89:1: mult : group ( ( MUL | DIV ) group )* ;
	[GrammarRule("mult")]
	private MathLangParser.mult_return mult()
	{
		Enter_mult();
		EnterRule("mult", 2);
		TraceIn("mult", 2);
		MathLangParser.mult_return retval = new MathLangParser.mult_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set7=null;
		MathLangParser.group_return group6 = default(MathLangParser.group_return);
		MathLangParser.group_return group8 = default(MathLangParser.group_return);

		object set7_tree=null;

		try { DebugEnterRule(GrammarFileName, "mult");
		DebugLocation(89, 39);
		try
		{
			// MathLang.g:89:5: ( group ( ( MUL | DIV ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:89:7: group ( ( MUL | DIV ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(89, 7);
			PushFollow(Follow._group_in_mult639);
			group6=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group6.Tree);
			DebugLocation(89, 13);
			// MathLang.g:89:13: ( ( MUL | DIV ) group )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if (((LA2_0>=MUL && LA2_0<=DIV)))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:89:15: ( MUL | DIV ) group
					{
					DebugLocation(89, 15);
					set7=(IToken)input.LT(1);
					set7=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set7), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(89, 30);
					PushFollow(Follow._group_in_mult654);
					group8=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group8.Tree);

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mult", 2);
			LeaveRule("mult", 2);
			Leave_mult();
		}
		DebugLocation(89, 39);
		} finally { DebugExitRule(GrammarFileName, "mult"); }
		return retval;

	}
	// $ANTLR end "mult"

	public class add_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_add();
	partial void Leave_add();

	// $ANTLR start "add"
	// MathLang.g:90:1: add : mult ( ( ADD | SUB ) mult )* ;
	[GrammarRule("add")]
	private MathLangParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 3);
		TraceIn("add", 3);
		MathLangParser.add_return retval = new MathLangParser.add_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set10=null;
		MathLangParser.mult_return mult9 = default(MathLangParser.mult_return);
		MathLangParser.mult_return mult11 = default(MathLangParser.mult_return);

		object set10_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(90, 39);
		try
		{
			// MathLang.g:90:4: ( mult ( ( ADD | SUB ) mult )* )
			DebugEnterAlt(1);
			// MathLang.g:90:7: mult ( ( ADD | SUB ) mult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(90, 7);
			PushFollow(Follow._mult_in_add666);
			mult9=mult();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult9.Tree);
			DebugLocation(90, 13);
			// MathLang.g:90:13: ( ( ADD | SUB ) mult )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if (((LA3_0>=ADD && LA3_0<=SUB)))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:90:15: ( ADD | SUB ) mult
					{
					DebugLocation(90, 15);
					set10=(IToken)input.LT(1);
					set10=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set10), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(90, 30);
					PushFollow(Follow._mult_in_add682);
					mult11=mult();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult11.Tree);

					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("add", 3);
			LeaveRule("add", 3);
			Leave_add();
		}
		DebugLocation(90, 39);
		} finally { DebugExitRule(GrammarFileName, "add"); }
		return retval;

	}
	// $ANTLR end "add"

	public class term_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_term();
	partial void Leave_term();

	// $ANTLR start "term"
	// MathLang.g:91:1: term : add ;
	[GrammarRule("term")]
	private MathLangParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 4);
		TraceIn("term", 4);
		MathLangParser.term_return retval = new MathLangParser.term_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		MathLangParser.add_return add12 = default(MathLangParser.add_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(91, 11);
		try
		{
			// MathLang.g:91:5: ( add )
			DebugEnterAlt(1);
			// MathLang.g:91:7: add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(91, 7);
			PushFollow(Follow._add_in_term694);
			add12=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add12.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 4);
			LeaveRule("term", 4);
			Leave_term();
		}
		DebugLocation(91, 11);
		} finally { DebugExitRule(GrammarFileName, "term"); }
		return retval;

	}
	// $ANTLR end "term"

	public class logic_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_logic();
	partial void Leave_logic();

	// $ANTLR start "logic"
	// MathLang.g:92:1: logic : term ( GE | LE | NE | EQ | GT | LT ) term ;
	[GrammarRule("logic")]
	private MathLangParser.logic_return logic()
	{
		Enter_logic();
		EnterRule("logic", 5);
		TraceIn("logic", 5);
		MathLangParser.logic_return retval = new MathLangParser.logic_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set14=null;
		MathLangParser.term_return term13 = default(MathLangParser.term_return);
		MathLangParser.term_return term15 = default(MathLangParser.term_return);

		object set14_tree=null;

		try { DebugEnterRule(GrammarFileName, "logic");
		DebugLocation(92, 50);
		try
		{
			// MathLang.g:92:6: ( term ( GE | LE | NE | EQ | GT | LT ) term )
			DebugEnterAlt(1);
			// MathLang.g:92:8: term ( GE | LE | NE | EQ | GT | LT ) term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(92, 8);
			PushFollow(Follow._term_in_logic702);
			term13=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term13.Tree);
			DebugLocation(92, 13);
			set14=(IToken)input.LT(1);
			set14=(IToken)input.LT(1);
			if ((input.LA(1)>=GE && input.LA(1)<=LT))
			{
				input.Consume();
				if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set14), root_0);
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}

			DebugLocation(92, 46);
			PushFollow(Follow._term_in_logic731);
			term15=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term15.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("logic", 5);
			LeaveRule("logic", 5);
			Leave_logic();
		}
		DebugLocation(92, 50);
		} finally { DebugExitRule(GrammarFileName, "logic"); }
		return retval;

	}
	// $ANTLR end "logic"

	public class and_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_and();
	partial void Leave_and();

	// $ANTLR start "and"
	// MathLang.g:93:1: and : logic ( AND logic )* ;
	[GrammarRule("and")]
	private MathLangParser.and_return and()
	{
		Enter_and();
		EnterRule("and", 6);
		TraceIn("and", 6);
		MathLangParser.and_return retval = new MathLangParser.and_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken AND17=null;
		MathLangParser.logic_return logic16 = default(MathLangParser.logic_return);
		MathLangParser.logic_return logic18 = default(MathLangParser.logic_return);

		object AND17_tree=null;

		try { DebugEnterRule(GrammarFileName, "and");
		DebugLocation(93, 25);
		try
		{
			// MathLang.g:93:4: ( logic ( AND logic )* )
			DebugEnterAlt(1);
			// MathLang.g:93:6: logic ( AND logic )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(93, 6);
			PushFollow(Follow._logic_in_and738);
			logic16=logic();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logic16.Tree);
			DebugLocation(93, 12);
			// MathLang.g:93:12: ( AND logic )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0==AND))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:93:13: AND logic
					{
					DebugLocation(93, 16);
					AND17=(IToken)Match(input,AND,Follow._AND_in_and741); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND17_tree = (object)adaptor.Create(AND17);
					root_0 = (object)adaptor.BecomeRoot(AND17_tree, root_0);
					}
					DebugLocation(93, 18);
					PushFollow(Follow._logic_in_and744);
					logic18=logic();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logic18.Tree);

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("and", 6);
			LeaveRule("and", 6);
			Leave_and();
		}
		DebugLocation(93, 25);
		} finally { DebugExitRule(GrammarFileName, "and"); }
		return retval;

	}
	// $ANTLR end "and"

	public class or_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_or();
	partial void Leave_or();

	// $ANTLR start "or"
	// MathLang.g:94:1: or : and ( OR and )* ;
	[GrammarRule("or")]
	private MathLangParser.or_return or()
	{
		Enter_or();
		EnterRule("or", 7);
		TraceIn("or", 7);
		MathLangParser.or_return retval = new MathLangParser.or_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken OR20=null;
		MathLangParser.and_return and19 = default(MathLangParser.and_return);
		MathLangParser.and_return and21 = default(MathLangParser.and_return);

		object OR20_tree=null;

		try { DebugEnterRule(GrammarFileName, "or");
		DebugLocation(94, 19);
		try
		{
			// MathLang.g:94:3: ( and ( OR and )* )
			DebugEnterAlt(1);
			// MathLang.g:94:5: and ( OR and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(94, 5);
			PushFollow(Follow._and_in_or753);
			and19=and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and19.Tree);
			DebugLocation(94, 9);
			// MathLang.g:94:9: ( OR and )*
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if ((LA5_0==OR))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch ( alt5 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:94:10: OR and
					{
					DebugLocation(94, 12);
					OR20=(IToken)Match(input,OR,Follow._OR_in_or756); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR20_tree = (object)adaptor.Create(OR20);
					root_0 = (object)adaptor.BecomeRoot(OR20_tree, root_0);
					}
					DebugLocation(94, 14);
					PushFollow(Follow._and_in_or759);
					and21=and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and21.Tree);

					}
					break;

				default:
					goto loop5;
				}
			}

			loop5:
				;

			} finally { DebugExitSubRule(5); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("or", 7);
			LeaveRule("or", 7);
			Leave_or();
		}
		DebugLocation(94, 19);
		} finally { DebugExitRule(GrammarFileName, "or"); }
		return retval;

	}
	// $ANTLR end "or"

	public class expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr();
	partial void Leave_expr();

	// $ANTLR start "expr"
	// MathLang.g:96:1: expr : ( IF or THEN expr ( ELSE expr )? | block | IDENT ASSIGN term | WHILE or DO expr | REPEAT expr UNTIL or -> ^( REPEAT or expr ) );
	[GrammarRule("expr")]
	private MathLangParser.expr_return expr()
	{
		Enter_expr();
		EnterRule("expr", 8);
		TraceIn("expr", 8);
		MathLangParser.expr_return retval = new MathLangParser.expr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IF22=null;
		IToken THEN24=null;
		IToken ELSE26=null;
		IToken IDENT29=null;
		IToken ASSIGN30=null;
		IToken WHILE32=null;
		IToken DO34=null;
		IToken REPEAT36=null;
		IToken UNTIL38=null;
		MathLangParser.or_return or23 = default(MathLangParser.or_return);
		MathLangParser.expr_return expr25 = default(MathLangParser.expr_return);
		MathLangParser.expr_return expr27 = default(MathLangParser.expr_return);
		MathLangParser.block_return block28 = default(MathLangParser.block_return);
		MathLangParser.term_return term31 = default(MathLangParser.term_return);
		MathLangParser.or_return or33 = default(MathLangParser.or_return);
		MathLangParser.expr_return expr35 = default(MathLangParser.expr_return);
		MathLangParser.expr_return expr37 = default(MathLangParser.expr_return);
		MathLangParser.or_return or39 = default(MathLangParser.or_return);

		object IF22_tree=null;
		object THEN24_tree=null;
		object ELSE26_tree=null;
		object IDENT29_tree=null;
		object ASSIGN30_tree=null;
		object WHILE32_tree=null;
		object DO34_tree=null;
		object REPEAT36_tree=null;
		object UNTIL38_tree=null;
		RewriteRuleITokenStream stream_REPEAT=new RewriteRuleITokenStream(adaptor,"token REPEAT");
		RewriteRuleITokenStream stream_UNTIL=new RewriteRuleITokenStream(adaptor,"token UNTIL");
		RewriteRuleSubtreeStream stream_or=new RewriteRuleSubtreeStream(adaptor,"rule or");
		RewriteRuleSubtreeStream stream_expr=new RewriteRuleSubtreeStream(adaptor,"rule expr");
		try { DebugEnterRule(GrammarFileName, "expr");
		DebugLocation(96, 0);
		try
		{
			// MathLang.g:96:5: ( IF or THEN expr ( ELSE expr )? | block | IDENT ASSIGN term | WHILE or DO expr | REPEAT expr UNTIL or -> ^( REPEAT or expr ) )
			int alt7=5;
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			switch (input.LA(1))
			{
			case IF:
				{
				alt7=1;
				}
				break;
			case BEGIN:
				{
				alt7=2;
				}
				break;
			case IDENT:
				{
				alt7=3;
				}
				break;
			case WHILE:
				{
				alt7=4;
				}
				break;
			case REPEAT:
				{
				alt7=5;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 7, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:97:3: IF or THEN expr ( ELSE expr )?
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(97, 5);
				IF22=(IToken)Match(input,IF,Follow._IF_in_expr771); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				IF22_tree = (object)adaptor.Create(IF22);
				root_0 = (object)adaptor.BecomeRoot(IF22_tree, root_0);
				}
				DebugLocation(97, 7);
				PushFollow(Follow._or_in_expr774);
				or23=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or23.Tree);
				DebugLocation(97, 14);
				THEN24=(IToken)Match(input,THEN,Follow._THEN_in_expr776); if (state.failed) return retval;
				DebugLocation(97, 16);
				PushFollow(Follow._expr_in_expr779);
				expr25=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr25.Tree);
				DebugLocation(97, 21);
				// MathLang.g:97:21: ( ELSE expr )?
				int alt6=2;
				try { DebugEnterSubRule(6);
				try { DebugEnterDecision(6, decisionCanBacktrack[6]);
				int LA6_0 = input.LA(1);

				if ((LA6_0==ELSE))
				{
					int LA6_1 = input.LA(2);

					if ((EvaluatePredicate(synpred14_MathLang_fragment)))
					{
						alt6=1;
					}
				}
				} finally { DebugExitDecision(6); }
				switch (alt6)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:97:23: ELSE expr
					{
					DebugLocation(97, 27);
					ELSE26=(IToken)Match(input,ELSE,Follow._ELSE_in_expr783); if (state.failed) return retval;
					DebugLocation(97, 29);
					PushFollow(Follow._expr_in_expr786);
					expr27=expr();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr27.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(6); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:98:3: block
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(98, 3);
				PushFollow(Follow._block_in_expr793);
				block28=block();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block28.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:99:3: IDENT ASSIGN term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(99, 3);
				IDENT29=(IToken)Match(input,IDENT,Follow._IDENT_in_expr797); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				IDENT29_tree = (object)adaptor.Create(IDENT29);
				adaptor.AddChild(root_0, IDENT29_tree);
				}
				DebugLocation(99, 15);
				ASSIGN30=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_expr799); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				ASSIGN30_tree = (object)adaptor.Create(ASSIGN30);
				root_0 = (object)adaptor.BecomeRoot(ASSIGN30_tree, root_0);
				}
				DebugLocation(99, 17);
				PushFollow(Follow._term_in_expr802);
				term31=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term31.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:100:3: WHILE or DO expr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(100, 8);
				WHILE32=(IToken)Match(input,WHILE,Follow._WHILE_in_expr806); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				WHILE32_tree = (object)adaptor.Create(WHILE32);
				root_0 = (object)adaptor.BecomeRoot(WHILE32_tree, root_0);
				}
				DebugLocation(100, 10);
				PushFollow(Follow._or_in_expr809);
				or33=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or33.Tree);
				DebugLocation(100, 15);
				DO34=(IToken)Match(input,DO,Follow._DO_in_expr811); if (state.failed) return retval;
				DebugLocation(100, 17);
				PushFollow(Follow._expr_in_expr814);
				expr35=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr35.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:101:3: REPEAT expr UNTIL or
				{
				DebugLocation(101, 3);
				REPEAT36=(IToken)Match(input,REPEAT,Follow._REPEAT_in_expr818); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_REPEAT.Add(REPEAT36);

				DebugLocation(101, 10);
				PushFollow(Follow._expr_in_expr820);
				expr37=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr.Add(expr37.Tree);
				DebugLocation(101, 15);
				UNTIL38=(IToken)Match(input,UNTIL,Follow._UNTIL_in_expr822); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_UNTIL.Add(UNTIL38);

				DebugLocation(101, 21);
				PushFollow(Follow._or_in_expr824);
				or39=or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_or.Add(or39.Tree);


				{
				// AST REWRITE
				// elements: expr, REPEAT, or
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 101:24: -> ^( REPEAT or expr )
				{
					DebugLocation(101, 27);
					// MathLang.g:101:27: ^( REPEAT or expr )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(101, 29);
					root_1 = (object)adaptor.BecomeRoot(stream_REPEAT.NextNode(), root_1);

					DebugLocation(101, 36);
					adaptor.AddChild(root_1, stream_or.NextTree());
					DebugLocation(101, 39);
					adaptor.AddChild(root_1, stream_expr.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr", 8);
			LeaveRule("expr", 8);
			Leave_expr();
		}
		DebugLocation(102, 0);
		} finally { DebugExitRule(GrammarFileName, "expr"); }
		return retval;

	}
	// $ANTLR end "expr"

	public class exprList_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_exprList();
	partial void Leave_exprList();

	// $ANTLR start "exprList"
	// MathLang.g:104:1: exprList : ( expr ( ';' )+ )* ( expr )? ;
	[GrammarRule("exprList")]
	private MathLangParser.exprList_return exprList()
	{
		Enter_exprList();
		EnterRule("exprList", 9);
		TraceIn("exprList", 9);
		MathLangParser.exprList_return retval = new MathLangParser.exprList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal41=null;
		MathLangParser.expr_return expr40 = default(MathLangParser.expr_return);
		MathLangParser.expr_return expr42 = default(MathLangParser.expr_return);

		object char_literal41_tree=null;

		try { DebugEnterRule(GrammarFileName, "exprList");
		DebugLocation(104, 34);
		try
		{
			// MathLang.g:104:9: ( ( expr ( ';' )+ )* ( expr )? )
			DebugEnterAlt(1);
			// MathLang.g:104:11: ( expr ( ';' )+ )* ( expr )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(104, 11);
			// MathLang.g:104:11: ( expr ( ';' )+ )*
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				switch (input.LA(1))
				{
				case IF:
					{
					int LA9_1 = input.LA(2);

					if ((EvaluatePredicate(synpred20_MathLang_fragment)))
					{
						alt9=1;
					}


					}
					break;
				case BEGIN:
					{
					int LA9_2 = input.LA(2);

					if ((EvaluatePredicate(synpred20_MathLang_fragment)))
					{
						alt9=1;
					}


					}
					break;
				case IDENT:
					{
					int LA9_3 = input.LA(2);

					if ((EvaluatePredicate(synpred20_MathLang_fragment)))
					{
						alt9=1;
					}


					}
					break;
				case WHILE:
					{
					int LA9_4 = input.LA(2);

					if ((EvaluatePredicate(synpred20_MathLang_fragment)))
					{
						alt9=1;
					}


					}
					break;
				case REPEAT:
					{
					int LA9_5 = input.LA(2);

					if ((EvaluatePredicate(synpred20_MathLang_fragment)))
					{
						alt9=1;
					}


					}
					break;

				}

				} finally { DebugExitDecision(9); }
				switch ( alt9 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:104:13: expr ( ';' )+
					{
					DebugLocation(104, 13);
					PushFollow(Follow._expr_in_exprList844);
					expr40=expr();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr40.Tree);
					DebugLocation(104, 18);
					// MathLang.g:104:18: ( ';' )+
					int cnt8=0;
					try { DebugEnterSubRule(8);
					while (true)
					{
						int alt8=2;
						try { DebugEnterDecision(8, decisionCanBacktrack[8]);
						int LA8_0 = input.LA(1);

						if ((LA8_0==36))
						{
							alt8=1;
						}


						} finally { DebugExitDecision(8); }
						switch (alt8)
						{
						case 1:
							DebugEnterAlt(1);
							// MathLang.g:104:19: ';'
							{
							DebugLocation(104, 22);
							char_literal41=(IToken)Match(input,36,Follow._36_in_exprList847); if (state.failed) return retval;

							}
							break;

						default:
							if (cnt8 >= 1)
								goto loop8;

							if (state.backtracking>0) {state.failed=true; return retval;}
							EarlyExitException eee8 = new EarlyExitException( 8, input );
							DebugRecognitionException(eee8);
							throw eee8;
						}
						cnt8++;
					}
					loop8:
						;

					} finally { DebugExitSubRule(8); }


					}
					break;

				default:
					goto loop9;
				}
			}

			loop9:
				;

			} finally { DebugExitSubRule(9); }

			DebugLocation(104, 29);
			// MathLang.g:104:29: ( expr )?
			int alt10=2;
			try { DebugEnterSubRule(10);
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			int LA10_0 = input.LA(1);

			if ((LA10_0==BEGIN||LA10_0==IF||LA10_0==WHILE||LA10_0==REPEAT||LA10_0==IDENT))
			{
				alt10=1;
			}
			} finally { DebugExitDecision(10); }
			switch (alt10)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: expr
				{
				DebugLocation(104, 29);
				PushFollow(Follow._expr_in_exprList855);
				expr42=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr42.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(10); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("exprList", 9);
			LeaveRule("exprList", 9);
			Leave_exprList();
		}
		DebugLocation(104, 34);
		} finally { DebugExitRule(GrammarFileName, "exprList"); }
		return retval;

	}
	// $ANTLR end "exprList"

	public class block_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_block();
	partial void Leave_block();

	// $ANTLR start "block"
	// MathLang.g:105:1: block : BEGIN exprList END -> ^( BLOCK exprList ) ;
	[GrammarRule("block")]
	private MathLangParser.block_return block()
	{
		Enter_block();
		EnterRule("block", 10);
		TraceIn("block", 10);
		MathLangParser.block_return retval = new MathLangParser.block_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken BEGIN43=null;
		IToken END45=null;
		MathLangParser.exprList_return exprList44 = default(MathLangParser.exprList_return);

		object BEGIN43_tree=null;
		object END45_tree=null;
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleSubtreeStream stream_exprList=new RewriteRuleSubtreeStream(adaptor,"rule exprList");
		try { DebugEnterRule(GrammarFileName, "block");
		DebugLocation(105, 47);
		try
		{
			// MathLang.g:105:6: ( BEGIN exprList END -> ^( BLOCK exprList ) )
			DebugEnterAlt(1);
			// MathLang.g:105:8: BEGIN exprList END
			{
			DebugLocation(105, 8);
			BEGIN43=(IToken)Match(input,BEGIN,Follow._BEGIN_in_block863); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN43);

			DebugLocation(105, 14);
			PushFollow(Follow._exprList_in_block865);
			exprList44=exprList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_exprList.Add(exprList44.Tree);
			DebugLocation(105, 23);
			END45=(IToken)Match(input,END,Follow._END_in_block867); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END45);



			{
			// AST REWRITE
			// elements: exprList
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 105:27: -> ^( BLOCK exprList )
			{
				DebugLocation(105, 30);
				// MathLang.g:105:30: ^( BLOCK exprList )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(105, 32);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(105, 38);
				adaptor.AddChild(root_1, stream_exprList.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("block", 10);
			LeaveRule("block", 10);
			Leave_block();
		}
		DebugLocation(105, 47);
		} finally { DebugExitRule(GrammarFileName, "block"); }
		return retval;

	}
	// $ANTLR end "block"

	public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_program();
	partial void Leave_program();

	// $ANTLR start "program"
	// MathLang.g:107:1: program : PROGRAM IDENT ';' block '.' ;
	[GrammarRule("program")]
	private MathLangParser.program_return program()
	{
		Enter_program();
		EnterRule("program", 11);
		TraceIn("program", 11);
		MathLangParser.program_return retval = new MathLangParser.program_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken PROGRAM46=null;
		IToken IDENT47=null;
		IToken char_literal48=null;
		IToken char_literal50=null;
		MathLangParser.block_return block49 = default(MathLangParser.block_return);

		object PROGRAM46_tree=null;
		object IDENT47_tree=null;
		object char_literal48_tree=null;
		object char_literal50_tree=null;

		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(107, 39);
		try
		{
			// MathLang.g:107:8: ( PROGRAM IDENT ';' block '.' )
			DebugEnterAlt(1);
			// MathLang.g:107:10: PROGRAM IDENT ';' block '.'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(107, 17);
			PROGRAM46=(IToken)Match(input,PROGRAM,Follow._PROGRAM_in_program883); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			PROGRAM46_tree = (object)adaptor.Create(PROGRAM46);
			root_0 = (object)adaptor.BecomeRoot(PROGRAM46_tree, root_0);
			}
			DebugLocation(107, 19);
			IDENT47=(IToken)Match(input,IDENT,Follow._IDENT_in_program886); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			IDENT47_tree = (object)adaptor.Create(IDENT47);
			adaptor.AddChild(root_0, IDENT47_tree);
			}
			DebugLocation(107, 28);
			char_literal48=(IToken)Match(input,36,Follow._36_in_program888); if (state.failed) return retval;
			DebugLocation(107, 30);
			PushFollow(Follow._block_in_program891);
			block49=block();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block49.Tree);
			DebugLocation(107, 39);
			char_literal50=(IToken)Match(input,37,Follow._37_in_program893); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("program", 11);
			LeaveRule("program", 11);
			Leave_program();
		}
		DebugLocation(107, 39);
		} finally { DebugExitRule(GrammarFileName, "program"); }
		return retval;

	}
	// $ANTLR end "program"

	public class result_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_result();
	partial void Leave_result();

	// $ANTLR start "result"
	// MathLang.g:109:1: result : program EOF ;
	[GrammarRule("result")]
	private MathLangParser.result_return result()
	{
		Enter_result();
		EnterRule("result", 12);
		TraceIn("result", 12);
		MathLangParser.result_return retval = new MathLangParser.result_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EOF52=null;
		MathLangParser.program_return program51 = default(MathLangParser.program_return);

		object EOF52_tree=null;

		try { DebugEnterRule(GrammarFileName, "result");
		DebugLocation(109, 20);
		try
		{
			// MathLang.g:109:7: ( program EOF )
			DebugEnterAlt(1);
			// MathLang.g:109:9: program EOF
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(109, 9);
			PushFollow(Follow._program_in_result901);
			program51=program();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program51.Tree);
			DebugLocation(109, 20);
			EOF52=(IToken)Match(input,EOF,Follow._EOF_in_result903); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("result", 12);
			LeaveRule("result", 12);
			Leave_result();
		}
		DebugLocation(109, 20);
		} finally { DebugExitRule(GrammarFileName, "result"); }
		return retval;

	}
	// $ANTLR end "result"

	public class execute_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_execute();
	partial void Leave_execute();

	// $ANTLR start "execute"
	// MathLang.g:111:8: public execute : result ;
	[GrammarRule("execute")]
	public MathLangParser.execute_return execute()
	{
		Enter_execute();
		EnterRule("execute", 13);
		TraceIn("execute", 13);
		MathLangParser.execute_return retval = new MathLangParser.execute_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		MathLangParser.result_return result53 = default(MathLangParser.result_return);


		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(111, 0);
		try
		{
			// MathLang.g:111:15: ( result )
			DebugEnterAlt(1);
			// MathLang.g:112:3: result
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(112, 3);
			PushFollow(Follow._result_in_execute915);
			result53=result();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, result53.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("execute", 13);
			LeaveRule("execute", 13);
			Leave_execute();
		}
		DebugLocation(113, 0);
		} finally { DebugExitRule(GrammarFileName, "execute"); }
		return retval;

	}
	// $ANTLR end "execute"

	partial void Enter_synpred14_MathLang_fragment();
	partial void Leave_synpred14_MathLang_fragment();

	// $ANTLR start synpred14_MathLang
	public void synpred14_MathLang_fragment()
	{
		Enter_synpred14_MathLang_fragment();
		EnterRule("synpred14_MathLang_fragment", 27);
		TraceIn("synpred14_MathLang_fragment", 27);
		try
		{
			// MathLang.g:97:23: ( ELSE expr )
			DebugEnterAlt(1);
			// MathLang.g:97:23: ELSE expr
			{
			DebugLocation(97, 23);
			Match(input,ELSE,Follow._ELSE_in_synpred14_MathLang783); if (state.failed) return;
			DebugLocation(97, 29);
			PushFollow(Follow._expr_in_synpred14_MathLang786);
			expr();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred14_MathLang_fragment", 27);
			LeaveRule("synpred14_MathLang_fragment", 27);
			Leave_synpred14_MathLang_fragment();
		}
	}
	// $ANTLR end synpred14_MathLang

	partial void Enter_synpred20_MathLang_fragment();
	partial void Leave_synpred20_MathLang_fragment();

	// $ANTLR start synpred20_MathLang
	public void synpred20_MathLang_fragment()
	{
		Enter_synpred20_MathLang_fragment();
		EnterRule("synpred20_MathLang_fragment", 33);
		TraceIn("synpred20_MathLang_fragment", 33);
		try
		{
			// MathLang.g:104:13: ( expr ( ';' )+ )
			DebugEnterAlt(1);
			// MathLang.g:104:13: expr ( ';' )+
			{
			DebugLocation(104, 13);
			PushFollow(Follow._expr_in_synpred20_MathLang844);
			expr();
			PopFollow();
			if (state.failed) return;
			DebugLocation(104, 18);
			// MathLang.g:104:18: ( ';' )+
			int cnt12=0;
			try { DebugEnterSubRule(12);
			while (true)
			{
				int alt12=2;
				try { DebugEnterDecision(12, decisionCanBacktrack[12]);
				int LA12_0 = input.LA(1);

				if ((LA12_0==36))
				{
					alt12=1;
				}


				} finally { DebugExitDecision(12); }
				switch (alt12)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:104:19: ';'
					{
					DebugLocation(104, 19);
					Match(input,36,Follow._36_in_synpred20_MathLang847); if (state.failed) return;

					}
					break;

				default:
					if (cnt12 >= 1)
						goto loop12;

					if (state.backtracking>0) {state.failed=true; return;}
					EarlyExitException eee12 = new EarlyExitException( 12, input );
					DebugRecognitionException(eee12);
					throw eee12;
				}
				cnt12++;
			}
			loop12:
				;

			} finally { DebugExitSubRule(12); }


			}

		}
		finally
		{
			TraceOut("synpred20_MathLang_fragment", 33);
			LeaveRule("synpred20_MathLang_fragment", 33);
			Leave_synpred20_MathLang_fragment();
		}
	}
	// $ANTLR end synpred20_MathLang
	#endregion Rules

	#region Synpreds
	private bool EvaluatePredicate(System.Action fragment)
	{
		bool success = false;
		state.backtracking++;
		try { DebugBeginBacktrack(state.backtracking);
		int start = input.Mark();
		try
		{
			fragment();
		}
		catch ( RecognitionException re )
		{
			System.Console.Error.WriteLine("impossible: "+re);
		}
		success = !state.failed;
		input.Rewind(start);
		} finally { DebugEndBacktrack(state.backtracking, success); }
		state.backtracking--;
		state.failed=false;
		return success;
	}
	#endregion Synpreds


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _34_in_group616 = new BitSet(new ulong[]{0x400600000UL});
		public static readonly BitSet _term_in_group619 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _35_in_group621 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_group626 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_group630 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _group_in_mult639 = new BitSet(new ulong[]{0x6000002UL});
		public static readonly BitSet _set_in_mult643 = new BitSet(new ulong[]{0x400600000UL});
		public static readonly BitSet _group_in_mult654 = new BitSet(new ulong[]{0x6000002UL});
		public static readonly BitSet _mult_in_add666 = new BitSet(new ulong[]{0x1800002UL});
		public static readonly BitSet _set_in_add671 = new BitSet(new ulong[]{0x400600000UL});
		public static readonly BitSet _mult_in_add682 = new BitSet(new ulong[]{0x1800002UL});
		public static readonly BitSet _add_in_term694 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_logic702 = new BitSet(new ulong[]{0x3F0000000UL});
		public static readonly BitSet _set_in_logic704 = new BitSet(new ulong[]{0x400600000UL});
		public static readonly BitSet _term_in_logic731 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _logic_in_and738 = new BitSet(new ulong[]{0x82UL});
		public static readonly BitSet _AND_in_and741 = new BitSet(new ulong[]{0x400600000UL});
		public static readonly BitSet _logic_in_and744 = new BitSet(new ulong[]{0x82UL});
		public static readonly BitSet _and_in_or753 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _OR_in_or756 = new BitSet(new ulong[]{0x400600000UL});
		public static readonly BitSet _and_in_or759 = new BitSet(new ulong[]{0x102UL});
		public static readonly BitSet _IF_in_expr771 = new BitSet(new ulong[]{0x400600000UL});
		public static readonly BitSet _or_in_expr774 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _THEN_in_expr776 = new BitSet(new ulong[]{0x414A00UL});
		public static readonly BitSet _expr_in_expr779 = new BitSet(new ulong[]{0x2002UL});
		public static readonly BitSet _ELSE_in_expr783 = new BitSet(new ulong[]{0x414A00UL});
		public static readonly BitSet _expr_in_expr786 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _block_in_expr793 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_expr797 = new BitSet(new ulong[]{0x8000000UL});
		public static readonly BitSet _ASSIGN_in_expr799 = new BitSet(new ulong[]{0x400600000UL});
		public static readonly BitSet _term_in_expr802 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_expr806 = new BitSet(new ulong[]{0x400600000UL});
		public static readonly BitSet _or_in_expr809 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _DO_in_expr811 = new BitSet(new ulong[]{0x414A00UL});
		public static readonly BitSet _expr_in_expr814 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _REPEAT_in_expr818 = new BitSet(new ulong[]{0x414A00UL});
		public static readonly BitSet _expr_in_expr820 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _UNTIL_in_expr822 = new BitSet(new ulong[]{0x400600000UL});
		public static readonly BitSet _or_in_expr824 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_in_exprList844 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _36_in_exprList847 = new BitSet(new ulong[]{0x1000414A02UL});
		public static readonly BitSet _expr_in_exprList855 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _BEGIN_in_block863 = new BitSet(new ulong[]{0x414E00UL});
		public static readonly BitSet _exprList_in_block865 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _END_in_block867 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PROGRAM_in_program883 = new BitSet(new ulong[]{0x400000UL});
		public static readonly BitSet _IDENT_in_program886 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _36_in_program888 = new BitSet(new ulong[]{0x200UL});
		public static readonly BitSet _block_in_program891 = new BitSet(new ulong[]{0x2000000000UL});
		public static readonly BitSet _37_in_program893 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _program_in_result901 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_result903 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _result_in_execute915 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred14_MathLang783 = new BitSet(new ulong[]{0x414A00UL});
		public static readonly BitSet _expr_in_synpred14_MathLang786 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_in_synpred20_MathLang844 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _36_in_synpred20_MathLang847 = new BitSet(new ulong[]{0x1000000002UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 
