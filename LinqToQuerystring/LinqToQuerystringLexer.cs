//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4.1.9004
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4.1.9004 D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g 2013-03-25 18:03:05

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;

namespace  LinqToQuerystring 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4.1.9004")]
[System.CLSCompliant(false)]
public partial class LinqToQuerystringLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int AND=4;
	public const int ASC=5;
	public const int ASSIGN=6;
	public const int BOOL=7;
	public const int DESC=8;
	public const int EQUALS=9;
	public const int FILTER=10;
	public const int FILTEROPERATOR=11;
	public const int IDENTIFIER=12;
	public const int INT=13;
	public const int NEWLINE=14;
	public const int NOT=15;
	public const int OR=16;
	public const int ORDERBY=17;
	public const int SKIP=18;
	public const int SPACE=19;
	public const int STRING=20;
	public const int TOP=21;
	public const int T__22=22;
	public const int T__23=23;
	public const int T__24=24;

    // delegates
    // delegators

	public LinqToQuerystringLexer()
	{
		OnCreated();
	}

	public LinqToQuerystringLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public LinqToQuerystringLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}
	public override string GrammarFileName { get { return "D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void EnterRule_T__22();
	partial void LeaveRule_T__22();

	// $ANTLR start "T__22"
	[GrammarRule("T__22")]
	private void mT__22()
	{
		EnterRule_T__22();
		EnterRule("T__22", 1);
		TraceIn("T__22", 1);
		try
		{
			int _type = T__22;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:9:7: ( '&' )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:9:9: '&'
			{
			DebugLocation(9, 9);
			Match('&'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__22", 1);
			LeaveRule("T__22", 1);
			LeaveRule_T__22();
		}
	}
	// $ANTLR end "T__22"

	partial void EnterRule_T__23();
	partial void LeaveRule_T__23();

	// $ANTLR start "T__23"
	[GrammarRule("T__23")]
	private void mT__23()
	{
		EnterRule_T__23();
		EnterRule("T__23", 2);
		TraceIn("T__23", 2);
		try
		{
			int _type = T__23;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:10:7: ( ',' )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:10:9: ','
			{
			DebugLocation(10, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__23", 2);
			LeaveRule("T__23", 2);
			LeaveRule_T__23();
		}
	}
	// $ANTLR end "T__23"

	partial void EnterRule_T__24();
	partial void LeaveRule_T__24();

	// $ANTLR start "T__24"
	[GrammarRule("T__24")]
	private void mT__24()
	{
		EnterRule_T__24();
		EnterRule("T__24", 3);
		TraceIn("T__24", 3);
		try
		{
			int _type = T__24;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:11:7: ( '/' )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:11:9: '/'
			{
			DebugLocation(11, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__24", 3);
			LeaveRule("T__24", 3);
			LeaveRule_T__24();
		}
	}
	// $ANTLR end "T__24"

	partial void EnterRule_ASSIGN();
	partial void LeaveRule_ASSIGN();

	// $ANTLR start "ASSIGN"
	[GrammarRule("ASSIGN")]
	private void mASSIGN()
	{
		EnterRule_ASSIGN();
		EnterRule("ASSIGN", 4);
		TraceIn("ASSIGN", 4);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:52:2: ( '=' )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:52:5: '='
			{
			DebugLocation(52, 5);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 4);
			LeaveRule("ASSIGN", 4);
			LeaveRule_ASSIGN();
		}
	}
	// $ANTLR end "ASSIGN"

	partial void EnterRule_FILTEROPERATOR();
	partial void LeaveRule_FILTEROPERATOR();

	// $ANTLR start "FILTEROPERATOR"
	[GrammarRule("FILTEROPERATOR")]
	private void mFILTEROPERATOR()
	{
		EnterRule_FILTEROPERATOR();
		EnterRule("FILTEROPERATOR", 5);
		TraceIn("FILTEROPERATOR", 5);
		try
		{
			int _type = FILTEROPERATOR;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:55:2: ( 'ne' | 'gt' | 'ge' | 'lt' | 'le' )
			int alt1=5;
			try { DebugEnterDecision(1, false);
			switch (input.LA(1))
			{
			case 'n':
				{
				alt1 = 1;
				}
				break;
			case 'g':
				{
				int LA1_2 = input.LA(2);

				if ((LA1_2=='t'))
				{
					alt1 = 2;
				}
				else if ((LA1_2=='e'))
				{
					alt1 = 3;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 1, 2, input, 2);
					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case 'l':
				{
				int LA1_2 = input.LA(2);

				if ((LA1_2=='t'))
				{
					alt1 = 4;
				}
				else if ((LA1_2=='e'))
				{
					alt1 = 5;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 1, 3, input, 2);
					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 1, 0, input, 1);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:55:4: 'ne'
				{
				DebugLocation(55, 4);
				Match("ne"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:55:11: 'gt'
				{
				DebugLocation(55, 11);
				Match("gt"); 


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:55:18: 'ge'
				{
				DebugLocation(55, 18);
				Match("ge"); 


				}
				break;
			case 4:
				DebugEnterAlt(4);
				// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:55:25: 'lt'
				{
				DebugLocation(55, 25);
				Match("lt"); 


				}
				break;
			case 5:
				DebugEnterAlt(5);
				// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:55:32: 'le'
				{
				DebugLocation(55, 32);
				Match("le"); 


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FILTEROPERATOR", 5);
			LeaveRule("FILTEROPERATOR", 5);
			LeaveRule_FILTEROPERATOR();
		}
	}
	// $ANTLR end "FILTEROPERATOR"

	partial void EnterRule_EQUALS();
	partial void LeaveRule_EQUALS();

	// $ANTLR start "EQUALS"
	[GrammarRule("EQUALS")]
	private void mEQUALS()
	{
		EnterRule_EQUALS();
		EnterRule("EQUALS", 6);
		TraceIn("EQUALS", 6);
		try
		{
			int _type = EQUALS;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:58:2: ( 'eq' )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:58:4: 'eq'
			{
			DebugLocation(58, 4);
			Match("eq"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQUALS", 6);
			LeaveRule("EQUALS", 6);
			LeaveRule_EQUALS();
		}
	}
	// $ANTLR end "EQUALS"

	partial void EnterRule_NOT();
	partial void LeaveRule_NOT();

	// $ANTLR start "NOT"
	[GrammarRule("NOT")]
	private void mNOT()
	{
		EnterRule_NOT();
		EnterRule("NOT", 7);
		TraceIn("NOT", 7);
		try
		{
			int _type = NOT;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:61:2: ( 'not' )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:61:4: 'not'
			{
			DebugLocation(61, 4);
			Match("not"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOT", 7);
			LeaveRule("NOT", 7);
			LeaveRule_NOT();
		}
	}
	// $ANTLR end "NOT"

	partial void EnterRule_OR();
	partial void LeaveRule_OR();

	// $ANTLR start "OR"
	[GrammarRule("OR")]
	private void mOR()
	{
		EnterRule_OR();
		EnterRule("OR", 8);
		TraceIn("OR", 8);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:64:2: ( 'or' )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:64:4: 'or'
			{
			DebugLocation(64, 4);
			Match("or"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 8);
			LeaveRule("OR", 8);
			LeaveRule_OR();
		}
	}
	// $ANTLR end "OR"

	partial void EnterRule_AND();
	partial void LeaveRule_AND();

	// $ANTLR start "AND"
	[GrammarRule("AND")]
	private void mAND()
	{
		EnterRule_AND();
		EnterRule("AND", 9);
		TraceIn("AND", 9);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:67:2: ( 'and' )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:67:5: 'and'
			{
			DebugLocation(67, 5);
			Match("and"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 9);
			LeaveRule("AND", 9);
			LeaveRule_AND();
		}
	}
	// $ANTLR end "AND"

	partial void EnterRule_ASC();
	partial void LeaveRule_ASC();

	// $ANTLR start "ASC"
	[GrammarRule("ASC")]
	private void mASC()
	{
		EnterRule_ASC();
		EnterRule("ASC", 10);
		TraceIn("ASC", 10);
		try
		{
			int _type = ASC;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:70:2: ( 'asc' )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:70:4: 'asc'
			{
			DebugLocation(70, 4);
			Match("asc"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASC", 10);
			LeaveRule("ASC", 10);
			LeaveRule_ASC();
		}
	}
	// $ANTLR end "ASC"

	partial void EnterRule_DESC();
	partial void LeaveRule_DESC();

	// $ANTLR start "DESC"
	[GrammarRule("DESC")]
	private void mDESC()
	{
		EnterRule_DESC();
		EnterRule("DESC", 11);
		TraceIn("DESC", 11);
		try
		{
			int _type = DESC;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:73:2: ( 'desc' )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:73:4: 'desc'
			{
			DebugLocation(73, 4);
			Match("desc"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DESC", 11);
			LeaveRule("DESC", 11);
			LeaveRule_DESC();
		}
	}
	// $ANTLR end "DESC"

	partial void EnterRule_SKIP();
	partial void LeaveRule_SKIP();

	// $ANTLR start "SKIP"
	[GrammarRule("SKIP")]
	private void mSKIP()
	{
		EnterRule_SKIP();
		EnterRule("SKIP", 12);
		TraceIn("SKIP", 12);
		try
		{
			int _type = SKIP;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:76:2: ( '$skip=' )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:76:4: '$skip='
			{
			DebugLocation(76, 4);
			Match("$skip="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SKIP", 12);
			LeaveRule("SKIP", 12);
			LeaveRule_SKIP();
		}
	}
	// $ANTLR end "SKIP"

	partial void EnterRule_TOP();
	partial void LeaveRule_TOP();

	// $ANTLR start "TOP"
	[GrammarRule("TOP")]
	private void mTOP()
	{
		EnterRule_TOP();
		EnterRule("TOP", 13);
		TraceIn("TOP", 13);
		try
		{
			int _type = TOP;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:79:2: ( '$top=' )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:79:4: '$top='
			{
			DebugLocation(79, 4);
			Match("$top="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TOP", 13);
			LeaveRule("TOP", 13);
			LeaveRule_TOP();
		}
	}
	// $ANTLR end "TOP"

	partial void EnterRule_FILTER();
	partial void LeaveRule_FILTER();

	// $ANTLR start "FILTER"
	[GrammarRule("FILTER")]
	private void mFILTER()
	{
		EnterRule_FILTER();
		EnterRule("FILTER", 14);
		TraceIn("FILTER", 14);
		try
		{
			int _type = FILTER;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:82:2: ( '$filter=' )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:82:4: '$filter='
			{
			DebugLocation(82, 4);
			Match("$filter="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FILTER", 14);
			LeaveRule("FILTER", 14);
			LeaveRule_FILTER();
		}
	}
	// $ANTLR end "FILTER"

	partial void EnterRule_ORDERBY();
	partial void LeaveRule_ORDERBY();

	// $ANTLR start "ORDERBY"
	[GrammarRule("ORDERBY")]
	private void mORDERBY()
	{
		EnterRule_ORDERBY();
		EnterRule("ORDERBY", 15);
		TraceIn("ORDERBY", 15);
		try
		{
			int _type = ORDERBY;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:85:2: ( '$orderby=' )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:85:4: '$orderby='
			{
			DebugLocation(85, 4);
			Match("$orderby="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ORDERBY", 15);
			LeaveRule("ORDERBY", 15);
			LeaveRule_ORDERBY();
		}
	}
	// $ANTLR end "ORDERBY"

	partial void EnterRule_INT();
	partial void LeaveRule_INT();

	// $ANTLR start "INT"
	[GrammarRule("INT")]
	private void mINT()
	{
		EnterRule_INT();
		EnterRule("INT", 16);
		TraceIn("INT", 16);
		try
		{
			int _type = INT;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:88:2: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:88:4: ( '0' .. '9' )+
			{
			DebugLocation(88, 4);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:88:4: ( '0' .. '9' )+
			int cnt2=0;
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, false);
				int LA2_1 = input.LA(1);

				if (((LA2_1>='0' && LA2_1<='9')))
				{
					alt2 = 1;
				}


				} finally { DebugExitDecision(2); }
				switch (alt2)
				{
				case 1:
					DebugEnterAlt(1);
					// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:
					{
					DebugLocation(88, 4);
					input.Consume();


					}
					break;

				default:
					if (cnt2 >= 1)
						goto loop2;

					EarlyExitException eee2 = new EarlyExitException( 2, input );
					DebugRecognitionException(eee2);
					throw eee2;
				}
				cnt2++;
			}
			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INT", 16);
			LeaveRule("INT", 16);
			LeaveRule_INT();
		}
	}
	// $ANTLR end "INT"

	partial void EnterRule_BOOL();
	partial void LeaveRule_BOOL();

	// $ANTLR start "BOOL"
	[GrammarRule("BOOL")]
	private void mBOOL()
	{
		EnterRule_BOOL();
		EnterRule("BOOL", 17);
		TraceIn("BOOL", 17);
		try
		{
			int _type = BOOL;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:91:2: ( ( 'true' | 'false' ) )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:91:4: ( 'true' | 'false' )
			{
			DebugLocation(91, 4);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:91:4: ( 'true' | 'false' )
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, false);
			int LA3_1 = input.LA(1);

			if ((LA3_1=='t'))
			{
				alt3 = 1;
			}
			else if ((LA3_1=='f'))
			{
				alt3 = 2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 3, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:91:5: 'true'
				{
				DebugLocation(91, 5);
				Match("true"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:91:14: 'false'
				{
				DebugLocation(91, 14);
				Match("false"); 


				}
				break;

			}
			} finally { DebugExitSubRule(3); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BOOL", 17);
			LeaveRule("BOOL", 17);
			LeaveRule_BOOL();
		}
	}
	// $ANTLR end "BOOL"

	partial void EnterRule_SPACE();
	partial void LeaveRule_SPACE();

	// $ANTLR start "SPACE"
	[GrammarRule("SPACE")]
	private void mSPACE()
	{
		EnterRule_SPACE();
		EnterRule("SPACE", 18);
		TraceIn("SPACE", 18);
		try
		{
			int _type = SPACE;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:94:2: ( ( ' ' | '\\t' )+ )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:94:4: ( ' ' | '\\t' )+
			{
			DebugLocation(94, 4);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:94:4: ( ' ' | '\\t' )+
			int cnt4=0;
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, false);
				int LA4_1 = input.LA(1);

				if ((LA4_1=='\t'||LA4_1==' '))
				{
					alt4 = 1;
				}


				} finally { DebugExitDecision(4); }
				switch (alt4)
				{
				case 1:
					DebugEnterAlt(1);
					// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:
					{
					DebugLocation(94, 4);
					input.Consume();


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

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SPACE", 18);
			LeaveRule("SPACE", 18);
			LeaveRule_SPACE();
		}
	}
	// $ANTLR end "SPACE"

	partial void EnterRule_NEWLINE();
	partial void LeaveRule_NEWLINE();

	// $ANTLR start "NEWLINE"
	[GrammarRule("NEWLINE")]
	private void mNEWLINE()
	{
		EnterRule_NEWLINE();
		EnterRule("NEWLINE", 19);
		TraceIn("NEWLINE", 19);
		try
		{
			int _type = NEWLINE;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:97:2: ( ( '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:97:4: ( '\\r' | '\\n' )+
			{
			DebugLocation(97, 4);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:97:4: ( '\\r' | '\\n' )+
			int cnt5=0;
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, false);
				int LA5_1 = input.LA(1);

				if ((LA5_1=='\n'||LA5_1=='\r'))
				{
					alt5 = 1;
				}


				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:
					{
					DebugLocation(97, 4);
					input.Consume();


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


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEWLINE", 19);
			LeaveRule("NEWLINE", 19);
			LeaveRule_NEWLINE();
		}
	}
	// $ANTLR end "NEWLINE"

	partial void EnterRule_IDENTIFIER();
	partial void LeaveRule_IDENTIFIER();

	// $ANTLR start "IDENTIFIER"
	[GrammarRule("IDENTIFIER")]
	private void mIDENTIFIER()
	{
		EnterRule_IDENTIFIER();
		EnterRule("IDENTIFIER", 20);
		TraceIn("IDENTIFIER", 20);
		try
		{
			int _type = IDENTIFIER;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:100:2: ( ( '<' | '>' | 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )+ )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:100:4: ( '<' | '>' | 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )+
			{
			DebugLocation(100, 4);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:100:4: ( '<' | '>' | 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )+
			int cnt6=0;
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, false);
				int LA6_1 = input.LA(1);

				if (((LA6_1>='0' && LA6_1<='9')||LA6_1=='<'||LA6_1=='>'||(LA6_1>='A' && LA6_1<='Z')||LA6_1=='_'||(LA6_1>='a' && LA6_1<='z')))
				{
					alt6 = 1;
				}


				} finally { DebugExitDecision(6); }
				switch (alt6)
				{
				case 1:
					DebugEnterAlt(1);
					// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:
					{
					DebugLocation(100, 4);
					input.Consume();


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

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IDENTIFIER", 20);
			LeaveRule("IDENTIFIER", 20);
			LeaveRule_IDENTIFIER();
		}
	}
	// $ANTLR end "IDENTIFIER"

	partial void EnterRule_STRING();
	partial void LeaveRule_STRING();

	// $ANTLR start "STRING"
	[GrammarRule("STRING")]
	private void mSTRING()
	{
		EnterRule_STRING();
		EnterRule("STRING", 21);
		TraceIn("STRING", 21);
		try
		{
			int _type = STRING;
			int _channel = DefaultTokenChannel;
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:103:2: ( '\\'' ( '<' | '>' | 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | ' ' | '\\t' )+ '\\'' )
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:103:4: '\\'' ( '<' | '>' | 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | ' ' | '\\t' )+ '\\''
			{
			DebugLocation(103, 4);
			Match('\''); 
			DebugLocation(103, 9);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:103:9: ( '<' | '>' | 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | ' ' | '\\t' )+
			int cnt7=0;
			try { DebugEnterSubRule(7);
			while (true)
			{
				int alt7=2;
				try { DebugEnterDecision(7, false);
				int LA7_1 = input.LA(1);

				if ((LA7_1=='\t'||LA7_1==' '||(LA7_1>='0' && LA7_1<='9')||LA7_1=='<'||LA7_1=='>'||(LA7_1>='A' && LA7_1<='Z')||LA7_1=='_'||(LA7_1>='a' && LA7_1<='z')))
				{
					alt7 = 1;
				}


				} finally { DebugExitDecision(7); }
				switch (alt7)
				{
				case 1:
					DebugEnterAlt(1);
					// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:
					{
					DebugLocation(103, 9);
					input.Consume();


					}
					break;

				default:
					if (cnt7 >= 1)
						goto loop7;

					EarlyExitException eee7 = new EarlyExitException( 7, input );
					DebugRecognitionException(eee7);
					throw eee7;
				}
				cnt7++;
			}
			loop7:
				;

			} finally { DebugExitSubRule(7); }

			DebugLocation(103, 60);
			Match('\''); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STRING", 21);
			LeaveRule("STRING", 21);
			LeaveRule_STRING();
		}
	}
	// $ANTLR end "STRING"

	public override void mTokens()
	{
		// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:8: ( T__22 | T__23 | T__24 | ASSIGN | FILTEROPERATOR | EQUALS | NOT | OR | AND | ASC | DESC | SKIP | TOP | FILTER | ORDERBY | INT | BOOL | SPACE | NEWLINE | IDENTIFIER | STRING )
		int alt8=21;
		try { DebugEnterDecision(8, false);
		try
		{
			alt8 = dfa8.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(8); }
		switch (alt8)
		{
		case 1:
			DebugEnterAlt(1);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:10: T__22
			{
			DebugLocation(1, 10);
			mT__22(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:16: T__23
			{
			DebugLocation(1, 16);
			mT__23(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:22: T__24
			{
			DebugLocation(1, 22);
			mT__24(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:28: ASSIGN
			{
			DebugLocation(1, 28);
			mASSIGN(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:35: FILTEROPERATOR
			{
			DebugLocation(1, 35);
			mFILTEROPERATOR(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:50: EQUALS
			{
			DebugLocation(1, 50);
			mEQUALS(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:57: NOT
			{
			DebugLocation(1, 57);
			mNOT(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:61: OR
			{
			DebugLocation(1, 61);
			mOR(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:64: AND
			{
			DebugLocation(1, 64);
			mAND(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:68: ASC
			{
			DebugLocation(1, 68);
			mASC(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:72: DESC
			{
			DebugLocation(1, 72);
			mDESC(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:77: SKIP
			{
			DebugLocation(1, 77);
			mSKIP(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:82: TOP
			{
			DebugLocation(1, 82);
			mTOP(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:86: FILTER
			{
			DebugLocation(1, 86);
			mFILTER(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:93: ORDERBY
			{
			DebugLocation(1, 93);
			mORDERBY(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:101: INT
			{
			DebugLocation(1, 101);
			mINT(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:105: BOOL
			{
			DebugLocation(1, 105);
			mBOOL(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:110: SPACE
			{
			DebugLocation(1, 110);
			mSPACE(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:116: NEWLINE
			{
			DebugLocation(1, 116);
			mNEWLINE(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:124: IDENTIFIER
			{
			DebugLocation(1, 124);
			mIDENTIFIER(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// D:\\Code\\LinqToQuerystring\\LinqToQuerystring\\LinqToQuerystring.g:1:135: STRING
			{
			DebugLocation(1, 135);
			mSTRING(); 

			}
			break;

		}

	}


	#region DFA
	DFA8 dfa8;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa8 = new DFA8(this);
	}

	private class DFA8 : DFA
	{
		private const string DFA8_eotS =
			"\x5\xFFFF\x7\x12\x1\xFFFF\x1\x23\x2\x12\x4\xFFFF\x1\x26\x1\x12\x4\x26"+
			"\x1\x28\x1\x29\x3\x12\x5\xFFFF\x2\x12\x1\xFFFF\x1\x2F\x2\xFFFF\x1\x30"+
			"\x1\x31\x3\x12\x3\xFFFF\x1\x35\x1\x36\x1\x12\x2\xFFFF\x1\x36";
		private const string DFA8_eofS =
			"\x38\xFFFF";
		private const string DFA8_minS =
			"\x1\x9\x4\xFFFF\x3\x65\x1\x71\x1\x72\x1\x6E\x1\x65\x1\x66\x1\x30\x1\x72"+
			"\x1\x61\x4\xFFFF\x1\x30\x1\x74\x6\x30\x1\x64\x1\x63\x1\x73\x5\xFFFF\x1"+
			"\x75\x1\x6C\x1\xFFFF\x1\x30\x2\xFFFF\x2\x30\x1\x63\x1\x65\x1\x73\x3\xFFFF"+
			"\x2\x30\x1\x65\x2\xFFFF\x1\x30";
		private const string DFA8_maxS =
			"\x1\x7A\x4\xFFFF\x1\x6F\x2\x74\x1\x71\x1\x72\x1\x73\x1\x65\x1\x74\x1"+
			"\x7A\x1\x72\x1\x61\x4\xFFFF\x1\x7A\x1\x74\x6\x7A\x1\x64\x1\x63\x1\x73"+
			"\x5\xFFFF\x1\x75\x1\x6C\x1\xFFFF\x1\x7A\x2\xFFFF\x2\x7A\x1\x63\x1\x65"+
			"\x1\x73\x3\xFFFF\x2\x7A\x1\x65\x2\xFFFF\x1\x7A";
		private const string DFA8_acceptS =
			"\x1\xFFFF\x1\x1\x1\x2\x1\x3\x1\x4\xB\xFFFF\x1\x12\x1\x13\x1\x14\x1\x15"+
			"\xB\xFFFF\x1\xC\x1\xD\x1\xE\x1\xF\x1\x10\x2\xFFFF\x1\x5\x1\xFFFF\x1\x6"+
			"\x1\x8\x5\xFFFF\x1\x7\x1\x9\x1\xA\x3\xFFFF\x1\xB\x1\x11\x1\xFFFF";
		private const string DFA8_specialS =
			"\x38\xFFFF}>";
		private static readonly string[] DFA8_transitionS =
			{
				"\x1\x10\x1\x11\x2\xFFFF\x1\x11\x12\xFFFF\x1\x10\x3\xFFFF\x1\xC\x1\xFFFF"+
				"\x1\x1\x1\x13\x4\xFFFF\x1\x2\x2\xFFFF\x1\x3\xA\xD\x2\xFFFF\x1\x12\x1"+
				"\x4\x1\x12\x2\xFFFF\x1A\x12\x4\xFFFF\x1\x12\x1\xFFFF\x1\xA\x2\x12\x1"+
				"\xB\x1\x8\x1\xF\x1\x6\x4\x12\x1\x7\x1\x12\x1\x5\x1\x9\x4\x12\x1\xE\x6"+
				"\x12",
				"",
				"",
				"",
				"",
				"\x1\x14\x9\xFFFF\x1\x15",
				"\x1\x17\xE\xFFFF\x1\x16",
				"\x1\x19\xE\xFFFF\x1\x18",
				"\x1\x1A",
				"\x1\x1B",
				"\x1\x1C\x4\xFFFF\x1\x1D",
				"\x1\x1E",
				"\x1\x21\x8\xFFFF\x1\x22\x3\xFFFF\x1\x1F\x1\x20",
				"\xA\xD\x2\xFFFF\x1\x12\x1\xFFFF\x1\x12\x2\xFFFF\x1A\x12\x4\xFFFF\x1"+
				"\x12\x1\xFFFF\x1A\x12",
				"\x1\x24",
				"\x1\x25",
				"",
				"",
				"",
				"",
				"\xA\x12\x2\xFFFF\x1\x12\x1\xFFFF\x1\x12\x2\xFFFF\x1A\x12\x4\xFFFF\x1"+
				"\x12\x1\xFFFF\x1A\x12",
				"\x1\x27",
				"\xA\x12\x2\xFFFF\x1\x12\x1\xFFFF\x1\x12\x2\xFFFF\x1A\x12\x4\xFFFF\x1"+
				"\x12\x1\xFFFF\x1A\x12",
				"\xA\x12\x2\xFFFF\x1\x12\x1\xFFFF\x1\x12\x2\xFFFF\x1A\x12\x4\xFFFF\x1"+
				"\x12\x1\xFFFF\x1A\x12",
				"\xA\x12\x2\xFFFF\x1\x12\x1\xFFFF\x1\x12\x2\xFFFF\x1A\x12\x4\xFFFF\x1"+
				"\x12\x1\xFFFF\x1A\x12",
				"\xA\x12\x2\xFFFF\x1\x12\x1\xFFFF\x1\x12\x2\xFFFF\x1A\x12\x4\xFFFF\x1"+
				"\x12\x1\xFFFF\x1A\x12",
				"\xA\x12\x2\xFFFF\x1\x12\x1\xFFFF\x1\x12\x2\xFFFF\x1A\x12\x4\xFFFF\x1"+
				"\x12\x1\xFFFF\x1A\x12",
				"\xA\x12\x2\xFFFF\x1\x12\x1\xFFFF\x1\x12\x2\xFFFF\x1A\x12\x4\xFFFF\x1"+
				"\x12\x1\xFFFF\x1A\x12",
				"\x1\x2A",
				"\x1\x2B",
				"\x1\x2C",
				"",
				"",
				"",
				"",
				"",
				"\x1\x2D",
				"\x1\x2E",
				"",
				"\xA\x12\x2\xFFFF\x1\x12\x1\xFFFF\x1\x12\x2\xFFFF\x1A\x12\x4\xFFFF\x1"+
				"\x12\x1\xFFFF\x1A\x12",
				"",
				"",
				"\xA\x12\x2\xFFFF\x1\x12\x1\xFFFF\x1\x12\x2\xFFFF\x1A\x12\x4\xFFFF\x1"+
				"\x12\x1\xFFFF\x1A\x12",
				"\xA\x12\x2\xFFFF\x1\x12\x1\xFFFF\x1\x12\x2\xFFFF\x1A\x12\x4\xFFFF\x1"+
				"\x12\x1\xFFFF\x1A\x12",
				"\x1\x32",
				"\x1\x33",
				"\x1\x34",
				"",
				"",
				"",
				"\xA\x12\x2\xFFFF\x1\x12\x1\xFFFF\x1\x12\x2\xFFFF\x1A\x12\x4\xFFFF\x1"+
				"\x12\x1\xFFFF\x1A\x12",
				"\xA\x12\x2\xFFFF\x1\x12\x1\xFFFF\x1\x12\x2\xFFFF\x1A\x12\x4\xFFFF\x1"+
				"\x12\x1\xFFFF\x1A\x12",
				"\x1\x37",
				"",
				"",
				"\xA\x12\x2\xFFFF\x1\x12\x1\xFFFF\x1\x12\x2\xFFFF\x1A\x12\x4\xFFFF\x1"+
				"\x12\x1\xFFFF\x1A\x12"
			};

		private static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
		private static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
		private static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
		private static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
		private static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
		private static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
		private static readonly short[][] DFA8_transition;

		static DFA8()
		{
			int numStates = DFA8_transitionS.Length;
			DFA8_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA8_transition[i] = DFA.UnpackEncodedString(DFA8_transitionS[i]);
			}
		}

		public DFA8( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 8;
			this.eot = DFA8_eot;
			this.eof = DFA8_eof;
			this.min = DFA8_min;
			this.max = DFA8_max;
			this.accept = DFA8_accept;
			this.special = DFA8_special;
			this.transition = DFA8_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( T__22 | T__23 | T__24 | ASSIGN | FILTEROPERATOR | EQUALS | NOT | OR | AND | ASC | DESC | SKIP | TOP | FILTER | ORDERBY | INT | BOOL | SPACE | NEWLINE | IDENTIFIER | STRING );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  LinqToQuerystring 
