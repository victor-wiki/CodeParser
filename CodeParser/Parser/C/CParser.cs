using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
public partial class CParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, Auto=20, Break=21, Case=22, Char=23, Const=24, Continue=25, 
		Default=26, Do=27, Double=28, Else=29, Enum=30, Extern=31, Float=32, For=33, 
		Goto=34, If=35, Inline=36, Int=37, Long=38, Register=39, Restrict=40, 
		Return=41, Short=42, Signed=43, Sizeof=44, Static=45, Struct=46, Switch=47, 
		Typedef=48, Union=49, Unsigned=50, Void=51, Volatile=52, While=53, Alignas=54, 
		Alignof=55, Atomic=56, Bool=57, Complex=58, Generic=59, Imaginary=60, 
		Noreturn=61, StaticAssert=62, ThreadLocal=63, LeftParen=64, RightParen=65, 
		LeftBracket=66, RightBracket=67, LeftBrace=68, RightBrace=69, Less=70, 
		LessEqual=71, Greater=72, GreaterEqual=73, LeftShift=74, RightShift=75, 
		Plus=76, PlusPlus=77, Minus=78, MinusMinus=79, Star=80, Div=81, Mod=82, 
		And=83, Or=84, AndAnd=85, OrOr=86, Caret=87, Not=88, Tilde=89, Question=90, 
		Colon=91, Semi=92, Comma=93, Assign=94, StarAssign=95, DivAssign=96, ModAssign=97, 
		PlusAssign=98, MinusAssign=99, LeftShiftAssign=100, RightShiftAssign=101, 
		AndAssign=102, XorAssign=103, OrAssign=104, Equal=105, NotEqual=106, Arrow=107, 
		Dot=108, Ellipsis=109, Identifier=110, Constant=111, DigitSequence=112, 
		StringLiteral=113, ComplexDefine=114, IncludeDirective=115, AsmBlock=116, 
		LineAfterPreprocessing=117, LineDirective=118, PragmaDirective=119, Whitespace=120, 
		Newline=121, BlockComment=122, LineComment=123;
	public const int
		RULE_primaryExpression = 0, RULE_genericSelection = 1, RULE_genericAssocList = 2, 
		RULE_genericAssociation = 3, RULE_postfixExpression = 4, RULE_argumentExpressionList = 5, 
		RULE_unaryExpression = 6, RULE_unaryOperator = 7, RULE_castExpression = 8, 
		RULE_multiplicativeExpression = 9, RULE_additiveExpression = 10, RULE_shiftExpression = 11, 
		RULE_relationalExpression = 12, RULE_equalityExpression = 13, RULE_andExpression = 14, 
		RULE_exclusiveOrExpression = 15, RULE_inclusiveOrExpression = 16, RULE_logicalAndExpression = 17, 
		RULE_logicalOrExpression = 18, RULE_conditionalExpression = 19, RULE_assignmentExpression = 20, 
		RULE_assignmentOperator = 21, RULE_expression = 22, RULE_constantExpression = 23, 
		RULE_declaration = 24, RULE_declarationSpecifiers = 25, RULE_declarationSpecifiers2 = 26, 
		RULE_declarationSpecifier = 27, RULE_initDeclaratorList = 28, RULE_initDeclarator = 29, 
		RULE_storageClassSpecifier = 30, RULE_typeSpecifier = 31, RULE_structOrUnionSpecifier = 32, 
		RULE_structOrUnion = 33, RULE_structDeclarationList = 34, RULE_structDeclaration = 35, 
		RULE_specifierQualifierList = 36, RULE_structDeclaratorList = 37, RULE_structDeclarator = 38, 
		RULE_enumSpecifier = 39, RULE_enumeratorList = 40, RULE_enumerator = 41, 
		RULE_enumerationConstant = 42, RULE_atomicTypeSpecifier = 43, RULE_typeQualifier = 44, 
		RULE_functionSpecifier = 45, RULE_alignmentSpecifier = 46, RULE_declarator = 47, 
		RULE_directDeclarator = 48, RULE_vcSpecificModifer = 49, RULE_gccDeclaratorExtension = 50, 
		RULE_gccAttributeSpecifier = 51, RULE_gccAttributeList = 52, RULE_gccAttribute = 53, 
		RULE_nestedParenthesesBlock = 54, RULE_pointer = 55, RULE_typeQualifierList = 56, 
		RULE_parameterTypeList = 57, RULE_parameterList = 58, RULE_parameterDeclaration = 59, 
		RULE_identifierList = 60, RULE_typeName = 61, RULE_abstractDeclarator = 62, 
		RULE_directAbstractDeclarator = 63, RULE_typedefName = 64, RULE_initializer = 65, 
		RULE_initializerList = 66, RULE_designation = 67, RULE_designatorList = 68, 
		RULE_designator = 69, RULE_staticAssertDeclaration = 70, RULE_statement = 71, 
		RULE_labeledStatement = 72, RULE_compoundStatement = 73, RULE_blockItemList = 74, 
		RULE_blockItem = 75, RULE_expressionStatement = 76, RULE_selectionStatement = 77, 
		RULE_iterationStatement = 78, RULE_forCondition = 79, RULE_forDeclaration = 80, 
		RULE_forExpression = 81, RULE_jumpStatement = 82, RULE_compilationUnit = 83, 
		RULE_translationUnit = 84, RULE_externalDeclaration = 85, RULE_functionDefinition = 86, 
		RULE_declarationList = 87;
	public static readonly string[] ruleNames = {
		"primaryExpression", "genericSelection", "genericAssocList", "genericAssociation", 
		"postfixExpression", "argumentExpressionList", "unaryExpression", "unaryOperator", 
		"castExpression", "multiplicativeExpression", "additiveExpression", "shiftExpression", 
		"relationalExpression", "equalityExpression", "andExpression", "exclusiveOrExpression", 
		"inclusiveOrExpression", "logicalAndExpression", "logicalOrExpression", 
		"conditionalExpression", "assignmentExpression", "assignmentOperator", 
		"expression", "constantExpression", "declaration", "declarationSpecifiers", 
		"declarationSpecifiers2", "declarationSpecifier", "initDeclaratorList", 
		"initDeclarator", "storageClassSpecifier", "typeSpecifier", "structOrUnionSpecifier", 
		"structOrUnion", "structDeclarationList", "structDeclaration", "specifierQualifierList", 
		"structDeclaratorList", "structDeclarator", "enumSpecifier", "enumeratorList", 
		"enumerator", "enumerationConstant", "atomicTypeSpecifier", "typeQualifier", 
		"functionSpecifier", "alignmentSpecifier", "declarator", "directDeclarator", 
		"vcSpecificModifer", "gccDeclaratorExtension", "gccAttributeSpecifier", 
		"gccAttributeList", "gccAttribute", "nestedParenthesesBlock", "pointer", 
		"typeQualifierList", "parameterTypeList", "parameterList", "parameterDeclaration", 
		"identifierList", "typeName", "abstractDeclarator", "directAbstractDeclarator", 
		"typedefName", "initializer", "initializerList", "designation", "designatorList", 
		"designator", "staticAssertDeclaration", "statement", "labeledStatement", 
		"compoundStatement", "blockItemList", "blockItem", "expressionStatement", 
		"selectionStatement", "iterationStatement", "forCondition", "forDeclaration", 
		"forExpression", "jumpStatement", "compilationUnit", "translationUnit", 
		"externalDeclaration", "functionDefinition", "declarationList"
	};

	private static readonly string[] _LiteralNames = {
		null, "'__extension__'", "'__builtin_va_arg'", "'__builtin_offsetof'", 
		"'__m128'", "'__m128d'", "'__m128i'", "'__typeof__'", "'__inline__'", 
		"'__stdcall'", "'__declspec'", "'__cdecl'", "'__clrcall'", "'__fastcall'", 
		"'__thiscall'", "'__vectorcall'", "'__asm'", "'__attribute__'", "'__asm__'", 
		"'__volatile__'", "'auto'", "'break'", "'case'", "'char'", "'const'", 
		"'continue'", "'default'", "'do'", "'double'", "'else'", "'enum'", "'extern'", 
		"'float'", "'for'", "'goto'", "'if'", "'inline'", "'int'", "'long'", "'register'", 
		"'restrict'", "'return'", "'short'", "'signed'", "'sizeof'", "'static'", 
		"'struct'", "'switch'", "'typedef'", "'union'", "'unsigned'", "'void'", 
		"'volatile'", "'while'", "'_Alignas'", "'_Alignof'", "'_Atomic'", "'_Bool'", 
		"'_Complex'", "'_Generic'", "'_Imaginary'", "'_Noreturn'", "'_Static_assert'", 
		"'_Thread_local'", "'('", "')'", "'['", "']'", "'{'", "'}'", "'<'", "'<='", 
		"'>'", "'>='", "'<<'", "'>>'", "'+'", "'++'", "'-'", "'--'", "'*'", "'/'", 
		"'%'", "'&'", "'|'", "'&&'", "'||'", "'^'", "'!'", "'~'", "'?'", "':'", 
		"';'", "','", "'='", "'*='", "'/='", "'%='", "'+='", "'-='", "'<<='", 
		"'>>='", "'&='", "'^='", "'|='", "'=='", "'!='", "'->'", "'.'", "'...'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, "Auto", "Break", "Case", 
		"Char", "Const", "Continue", "Default", "Do", "Double", "Else", "Enum", 
		"Extern", "Float", "For", "Goto", "If", "Inline", "Int", "Long", "Register", 
		"Restrict", "Return", "Short", "Signed", "Sizeof", "Static", "Struct", 
		"Switch", "Typedef", "Union", "Unsigned", "Void", "Volatile", "While", 
		"Alignas", "Alignof", "Atomic", "Bool", "Complex", "Generic", "Imaginary", 
		"Noreturn", "StaticAssert", "ThreadLocal", "LeftParen", "RightParen", 
		"LeftBracket", "RightBracket", "LeftBrace", "RightBrace", "Less", "LessEqual", 
		"Greater", "GreaterEqual", "LeftShift", "RightShift", "Plus", "PlusPlus", 
		"Minus", "MinusMinus", "Star", "Div", "Mod", "And", "Or", "AndAnd", "OrOr", 
		"Caret", "Not", "Tilde", "Question", "Colon", "Semi", "Comma", "Assign", 
		"StarAssign", "DivAssign", "ModAssign", "PlusAssign", "MinusAssign", "LeftShiftAssign", 
		"RightShiftAssign", "AndAssign", "XorAssign", "OrAssign", "Equal", "NotEqual", 
		"Arrow", "Dot", "Ellipsis", "Identifier", "Constant", "DigitSequence", 
		"StringLiteral", "ComplexDefine", "IncludeDirective", "AsmBlock", "LineAfterPreprocessing", 
		"LineDirective", "PragmaDirective", "Whitespace", "Newline", "BlockComment", 
		"LineComment"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "C.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static CParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public CParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public CParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class PrimaryExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CParser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Constant() { return GetToken(CParser.Constant, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] StringLiteral() { return GetTokens(CParser.StringLiteral); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode StringLiteral(int i) {
			return GetToken(CParser.StringLiteral, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CParser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CParser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public GenericSelectionContext genericSelection() {
			return GetRuleContext<GenericSelectionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CompoundStatementContext compoundStatement() {
			return GetRuleContext<CompoundStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnaryExpressionContext unaryExpression() {
			return GetRuleContext<UnaryExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CParser.Comma, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		public PrimaryExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primaryExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterPrimaryExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitPrimaryExpression(this);
		}
	}

	[RuleVersion(0)]
	public PrimaryExpressionContext primaryExpression() {
		PrimaryExpressionContext _localctx = new PrimaryExpressionContext(Context, State);
		EnterRule(_localctx, 0, RULE_primaryExpression);
		int _la;
		try {
			State = 209;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 176;
				Match(Identifier);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 177;
				Match(Constant);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 179;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				do {
					{
					{
					State = 178;
					Match(StringLiteral);
					}
					}
					State = 181;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				} while ( _la==StringLiteral );
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 183;
				Match(LeftParen);
				State = 184;
				expression();
				State = 185;
				Match(RightParen);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 187;
				genericSelection();
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 189;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==T__0) {
					{
					State = 188;
					Match(T__0);
					}
				}

				State = 191;
				Match(LeftParen);
				State = 192;
				compoundStatement();
				State = 193;
				Match(RightParen);
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 195;
				Match(T__1);
				State = 196;
				Match(LeftParen);
				State = 197;
				unaryExpression();
				State = 198;
				Match(Comma);
				State = 199;
				typeName();
				State = 200;
				Match(RightParen);
				}
				break;
			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 202;
				Match(T__2);
				State = 203;
				Match(LeftParen);
				State = 204;
				typeName();
				State = 205;
				Match(Comma);
				State = 206;
				unaryExpression();
				State = 207;
				Match(RightParen);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class GenericSelectionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Generic() { return GetToken(CParser.Generic, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CParser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentExpressionContext assignmentExpression() {
			return GetRuleContext<AssignmentExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CParser.Comma, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public GenericAssocListContext genericAssocList() {
			return GetRuleContext<GenericAssocListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CParser.RightParen, 0); }
		public GenericSelectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_genericSelection; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterGenericSelection(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitGenericSelection(this);
		}
	}

	[RuleVersion(0)]
	public GenericSelectionContext genericSelection() {
		GenericSelectionContext _localctx = new GenericSelectionContext(Context, State);
		EnterRule(_localctx, 2, RULE_genericSelection);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 211;
			Match(Generic);
			State = 212;
			Match(LeftParen);
			State = 213;
			assignmentExpression();
			State = 214;
			Match(Comma);
			State = 215;
			genericAssocList();
			State = 216;
			Match(RightParen);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class GenericAssocListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public GenericAssociationContext[] genericAssociation() {
			return GetRuleContexts<GenericAssociationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public GenericAssociationContext genericAssociation(int i) {
			return GetRuleContext<GenericAssociationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(CParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(CParser.Comma, i);
		}
		public GenericAssocListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_genericAssocList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterGenericAssocList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitGenericAssocList(this);
		}
	}

	[RuleVersion(0)]
	public GenericAssocListContext genericAssocList() {
		GenericAssocListContext _localctx = new GenericAssocListContext(Context, State);
		EnterRule(_localctx, 4, RULE_genericAssocList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 218;
			genericAssociation();
			State = 223;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 219;
				Match(Comma);
				State = 220;
				genericAssociation();
				}
				}
				State = 225;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class GenericAssociationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(CParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentExpressionContext assignmentExpression() {
			return GetRuleContext<AssignmentExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Default() { return GetToken(CParser.Default, 0); }
		public GenericAssociationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_genericAssociation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterGenericAssociation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitGenericAssociation(this);
		}
	}

	[RuleVersion(0)]
	public GenericAssociationContext genericAssociation() {
		GenericAssociationContext _localctx = new GenericAssociationContext(Context, State);
		EnterRule(_localctx, 6, RULE_genericAssociation);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 228;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__0:
			case T__3:
			case T__4:
			case T__5:
			case T__6:
			case Char:
			case Const:
			case Double:
			case Enum:
			case Float:
			case Int:
			case Long:
			case Restrict:
			case Short:
			case Signed:
			case Struct:
			case Union:
			case Unsigned:
			case Void:
			case Volatile:
			case Atomic:
			case Bool:
			case Complex:
			case Identifier:
				{
				State = 226;
				typeName();
				}
				break;
			case Default:
				{
				State = 227;
				Match(Default);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 230;
			Match(Colon);
			State = 231;
			assignmentExpression();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PostfixExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryExpressionContext primaryExpression() {
			return GetRuleContext<PrimaryExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LeftParen() { return GetTokens(CParser.LeftParen); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen(int i) {
			return GetToken(CParser.LeftParen, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RightParen() { return GetTokens(CParser.RightParen); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen(int i) {
			return GetToken(CParser.RightParen, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBrace() { return GetToken(CParser.LeftBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InitializerListContext initializerList() {
			return GetRuleContext<InitializerListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBrace() { return GetToken(CParser.RightBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LeftBracket() { return GetTokens(CParser.LeftBracket); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBracket(int i) {
			return GetToken(CParser.LeftBracket, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RightBracket() { return GetTokens(CParser.RightBracket); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBracket(int i) {
			return GetToken(CParser.RightBracket, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Identifier() { return GetTokens(CParser.Identifier); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier(int i) {
			return GetToken(CParser.Identifier, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Dot() { return GetTokens(CParser.Dot); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Dot(int i) {
			return GetToken(CParser.Dot, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Arrow() { return GetTokens(CParser.Arrow); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Arrow(int i) {
			return GetToken(CParser.Arrow, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] PlusPlus() { return GetTokens(CParser.PlusPlus); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PlusPlus(int i) {
			return GetToken(CParser.PlusPlus, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] MinusMinus() { return GetTokens(CParser.MinusMinus); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MinusMinus(int i) {
			return GetToken(CParser.MinusMinus, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CParser.Comma, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentExpressionListContext[] argumentExpressionList() {
			return GetRuleContexts<ArgumentExpressionListContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentExpressionListContext argumentExpressionList(int i) {
			return GetRuleContext<ArgumentExpressionListContext>(i);
		}
		public PostfixExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_postfixExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterPostfixExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitPostfixExpression(this);
		}
	}

	[RuleVersion(0)]
	public PostfixExpressionContext postfixExpression() {
		PostfixExpressionContext _localctx = new PostfixExpressionContext(Context, State);
		EnterRule(_localctx, 8, RULE_postfixExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 247;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,7,Context) ) {
			case 1:
				{
				State = 233;
				primaryExpression();
				}
				break;
			case 2:
				{
				State = 235;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==T__0) {
					{
					State = 234;
					Match(T__0);
					}
				}

				State = 237;
				Match(LeftParen);
				State = 238;
				typeName();
				State = 239;
				Match(RightParen);
				State = 240;
				Match(LeftBrace);
				State = 241;
				initializerList();
				State = 243;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Comma) {
					{
					State = 242;
					Match(Comma);
					}
				}

				State = 245;
				Match(RightBrace);
				}
				break;
			}
			State = 263;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (PlusPlus - 64)) | (1L << (MinusMinus - 64)) | (1L << (Arrow - 64)) | (1L << (Dot - 64)))) != 0)) {
				{
				State = 261;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case LeftBracket:
					{
					State = 249;
					Match(LeftBracket);
					State = 250;
					expression();
					State = 251;
					Match(RightBracket);
					}
					break;
				case LeftParen:
					{
					State = 253;
					Match(LeftParen);
					State = 255;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << Sizeof) | (1L << Alignof) | (1L << Generic))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (Plus - 64)) | (1L << (PlusPlus - 64)) | (1L << (Minus - 64)) | (1L << (MinusMinus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (AndAnd - 64)) | (1L << (Not - 64)) | (1L << (Tilde - 64)) | (1L << (Identifier - 64)) | (1L << (Constant - 64)) | (1L << (DigitSequence - 64)) | (1L << (StringLiteral - 64)))) != 0)) {
						{
						State = 254;
						argumentExpressionList();
						}
					}

					State = 257;
					Match(RightParen);
					}
					break;
				case Arrow:
				case Dot:
					{
					State = 258;
					_la = TokenStream.LA(1);
					if ( !(_la==Arrow || _la==Dot) ) {
					ErrorHandler.RecoverInline(this);
					}
					else {
						ErrorHandler.ReportMatch(this);
					    Consume();
					}
					State = 259;
					Match(Identifier);
					}
					break;
				case PlusPlus:
				case MinusMinus:
					{
					State = 260;
					_la = TokenStream.LA(1);
					if ( !(_la==PlusPlus || _la==MinusMinus) ) {
					ErrorHandler.RecoverInline(this);
					}
					else {
						ErrorHandler.ReportMatch(this);
					    Consume();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 265;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ArgumentExpressionListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentExpressionContext[] assignmentExpression() {
			return GetRuleContexts<AssignmentExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentExpressionContext assignmentExpression(int i) {
			return GetRuleContext<AssignmentExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(CParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(CParser.Comma, i);
		}
		public ArgumentExpressionListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_argumentExpressionList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterArgumentExpressionList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitArgumentExpressionList(this);
		}
	}

	[RuleVersion(0)]
	public ArgumentExpressionListContext argumentExpressionList() {
		ArgumentExpressionListContext _localctx = new ArgumentExpressionListContext(Context, State);
		EnterRule(_localctx, 10, RULE_argumentExpressionList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 266;
			assignmentExpression();
			State = 271;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 267;
				Match(Comma);
				State = 268;
				assignmentExpression();
				}
				}
				State = 273;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class UnaryExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PostfixExpressionContext postfixExpression() {
			return GetRuleContext<PostfixExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnaryOperatorContext unaryOperator() {
			return GetRuleContext<UnaryOperatorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CastExpressionContext castExpression() {
			return GetRuleContext<CastExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CParser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CParser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AndAnd() { return GetToken(CParser.AndAnd, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CParser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Sizeof() { return GetTokens(CParser.Sizeof); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Sizeof(int i) {
			return GetToken(CParser.Sizeof, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Alignof() { return GetToken(CParser.Alignof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] PlusPlus() { return GetTokens(CParser.PlusPlus); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PlusPlus(int i) {
			return GetToken(CParser.PlusPlus, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] MinusMinus() { return GetTokens(CParser.MinusMinus); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MinusMinus(int i) {
			return GetToken(CParser.MinusMinus, i);
		}
		public UnaryExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unaryExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterUnaryExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitUnaryExpression(this);
		}
	}

	[RuleVersion(0)]
	public UnaryExpressionContext unaryExpression() {
		UnaryExpressionContext _localctx = new UnaryExpressionContext(Context, State);
		EnterRule(_localctx, 12, RULE_unaryExpression);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 277;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,12,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 274;
					_la = TokenStream.LA(1);
					if ( !(((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Sizeof - 44)) | (1L << (PlusPlus - 44)) | (1L << (MinusMinus - 44)))) != 0)) ) {
					ErrorHandler.RecoverInline(this);
					}
					else {
						ErrorHandler.ReportMatch(this);
					    Consume();
					}
					}
					} 
				}
				State = 279;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,12,Context);
			}
			State = 291;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__0:
			case T__1:
			case T__2:
			case Generic:
			case LeftParen:
			case Identifier:
			case Constant:
			case StringLiteral:
				{
				State = 280;
				postfixExpression();
				}
				break;
			case Plus:
			case Minus:
			case Star:
			case And:
			case Not:
			case Tilde:
				{
				State = 281;
				unaryOperator();
				State = 282;
				castExpression();
				}
				break;
			case Sizeof:
			case Alignof:
				{
				State = 284;
				_la = TokenStream.LA(1);
				if ( !(_la==Sizeof || _la==Alignof) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 285;
				Match(LeftParen);
				State = 286;
				typeName();
				State = 287;
				Match(RightParen);
				}
				break;
			case AndAnd:
				{
				State = 289;
				Match(AndAnd);
				State = 290;
				Match(Identifier);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class UnaryOperatorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode And() { return GetToken(CParser.And, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Star() { return GetToken(CParser.Star, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Plus() { return GetToken(CParser.Plus, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Minus() { return GetToken(CParser.Minus, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Tilde() { return GetToken(CParser.Tilde, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Not() { return GetToken(CParser.Not, 0); }
		public UnaryOperatorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unaryOperator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterUnaryOperator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitUnaryOperator(this);
		}
	}

	[RuleVersion(0)]
	public UnaryOperatorContext unaryOperator() {
		UnaryOperatorContext _localctx = new UnaryOperatorContext(Context, State);
		EnterRule(_localctx, 14, RULE_unaryOperator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 293;
			_la = TokenStream.LA(1);
			if ( !(((((_la - 76)) & ~0x3f) == 0 && ((1L << (_la - 76)) & ((1L << (Plus - 76)) | (1L << (Minus - 76)) | (1L << (Star - 76)) | (1L << (And - 76)) | (1L << (Not - 76)) | (1L << (Tilde - 76)))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CastExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CParser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CParser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public CastExpressionContext castExpression() {
			return GetRuleContext<CastExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnaryExpressionContext unaryExpression() {
			return GetRuleContext<UnaryExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DigitSequence() { return GetToken(CParser.DigitSequence, 0); }
		public CastExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_castExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterCastExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitCastExpression(this);
		}
	}

	[RuleVersion(0)]
	public CastExpressionContext castExpression() {
		CastExpressionContext _localctx = new CastExpressionContext(Context, State);
		EnterRule(_localctx, 16, RULE_castExpression);
		int _la;
		try {
			State = 305;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,15,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 296;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==T__0) {
					{
					State = 295;
					Match(T__0);
					}
				}

				State = 298;
				Match(LeftParen);
				State = 299;
				typeName();
				State = 300;
				Match(RightParen);
				State = 301;
				castExpression();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 303;
				unaryExpression();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 304;
				Match(DigitSequence);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MultiplicativeExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public CastExpressionContext[] castExpression() {
			return GetRuleContexts<CastExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public CastExpressionContext castExpression(int i) {
			return GetRuleContext<CastExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Star() { return GetTokens(CParser.Star); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Star(int i) {
			return GetToken(CParser.Star, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Div() { return GetTokens(CParser.Div); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Div(int i) {
			return GetToken(CParser.Div, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Mod() { return GetTokens(CParser.Mod); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Mod(int i) {
			return GetToken(CParser.Mod, i);
		}
		public MultiplicativeExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_multiplicativeExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterMultiplicativeExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitMultiplicativeExpression(this);
		}
	}

	[RuleVersion(0)]
	public MultiplicativeExpressionContext multiplicativeExpression() {
		MultiplicativeExpressionContext _localctx = new MultiplicativeExpressionContext(Context, State);
		EnterRule(_localctx, 18, RULE_multiplicativeExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 307;
			castExpression();
			State = 312;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (((((_la - 80)) & ~0x3f) == 0 && ((1L << (_la - 80)) & ((1L << (Star - 80)) | (1L << (Div - 80)) | (1L << (Mod - 80)))) != 0)) {
				{
				{
				State = 308;
				_la = TokenStream.LA(1);
				if ( !(((((_la - 80)) & ~0x3f) == 0 && ((1L << (_la - 80)) & ((1L << (Star - 80)) | (1L << (Div - 80)) | (1L << (Mod - 80)))) != 0)) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 309;
				castExpression();
				}
				}
				State = 314;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AdditiveExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public MultiplicativeExpressionContext[] multiplicativeExpression() {
			return GetRuleContexts<MultiplicativeExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public MultiplicativeExpressionContext multiplicativeExpression(int i) {
			return GetRuleContext<MultiplicativeExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Plus() { return GetTokens(CParser.Plus); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Plus(int i) {
			return GetToken(CParser.Plus, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Minus() { return GetTokens(CParser.Minus); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Minus(int i) {
			return GetToken(CParser.Minus, i);
		}
		public AdditiveExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_additiveExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterAdditiveExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitAdditiveExpression(this);
		}
	}

	[RuleVersion(0)]
	public AdditiveExpressionContext additiveExpression() {
		AdditiveExpressionContext _localctx = new AdditiveExpressionContext(Context, State);
		EnterRule(_localctx, 20, RULE_additiveExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 315;
			multiplicativeExpression();
			State = 320;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Plus || _la==Minus) {
				{
				{
				State = 316;
				_la = TokenStream.LA(1);
				if ( !(_la==Plus || _la==Minus) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 317;
				multiplicativeExpression();
				}
				}
				State = 322;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ShiftExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AdditiveExpressionContext[] additiveExpression() {
			return GetRuleContexts<AdditiveExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AdditiveExpressionContext additiveExpression(int i) {
			return GetRuleContext<AdditiveExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LeftShift() { return GetTokens(CParser.LeftShift); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftShift(int i) {
			return GetToken(CParser.LeftShift, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RightShift() { return GetTokens(CParser.RightShift); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightShift(int i) {
			return GetToken(CParser.RightShift, i);
		}
		public ShiftExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_shiftExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterShiftExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitShiftExpression(this);
		}
	}

	[RuleVersion(0)]
	public ShiftExpressionContext shiftExpression() {
		ShiftExpressionContext _localctx = new ShiftExpressionContext(Context, State);
		EnterRule(_localctx, 22, RULE_shiftExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 323;
			additiveExpression();
			State = 328;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==LeftShift || _la==RightShift) {
				{
				{
				State = 324;
				_la = TokenStream.LA(1);
				if ( !(_la==LeftShift || _la==RightShift) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 325;
				additiveExpression();
				}
				}
				State = 330;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class RelationalExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ShiftExpressionContext[] shiftExpression() {
			return GetRuleContexts<ShiftExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ShiftExpressionContext shiftExpression(int i) {
			return GetRuleContext<ShiftExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Less() { return GetTokens(CParser.Less); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Less(int i) {
			return GetToken(CParser.Less, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Greater() { return GetTokens(CParser.Greater); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Greater(int i) {
			return GetToken(CParser.Greater, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LessEqual() { return GetTokens(CParser.LessEqual); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LessEqual(int i) {
			return GetToken(CParser.LessEqual, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] GreaterEqual() { return GetTokens(CParser.GreaterEqual); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GreaterEqual(int i) {
			return GetToken(CParser.GreaterEqual, i);
		}
		public RelationalExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_relationalExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterRelationalExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitRelationalExpression(this);
		}
	}

	[RuleVersion(0)]
	public RelationalExpressionContext relationalExpression() {
		RelationalExpressionContext _localctx = new RelationalExpressionContext(Context, State);
		EnterRule(_localctx, 24, RULE_relationalExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 331;
			shiftExpression();
			State = 336;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (((((_la - 70)) & ~0x3f) == 0 && ((1L << (_la - 70)) & ((1L << (Less - 70)) | (1L << (LessEqual - 70)) | (1L << (Greater - 70)) | (1L << (GreaterEqual - 70)))) != 0)) {
				{
				{
				State = 332;
				_la = TokenStream.LA(1);
				if ( !(((((_la - 70)) & ~0x3f) == 0 && ((1L << (_la - 70)) & ((1L << (Less - 70)) | (1L << (LessEqual - 70)) | (1L << (Greater - 70)) | (1L << (GreaterEqual - 70)))) != 0)) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 333;
				shiftExpression();
				}
				}
				State = 338;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EqualityExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public RelationalExpressionContext[] relationalExpression() {
			return GetRuleContexts<RelationalExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public RelationalExpressionContext relationalExpression(int i) {
			return GetRuleContext<RelationalExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Equal() { return GetTokens(CParser.Equal); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Equal(int i) {
			return GetToken(CParser.Equal, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] NotEqual() { return GetTokens(CParser.NotEqual); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NotEqual(int i) {
			return GetToken(CParser.NotEqual, i);
		}
		public EqualityExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_equalityExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterEqualityExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitEqualityExpression(this);
		}
	}

	[RuleVersion(0)]
	public EqualityExpressionContext equalityExpression() {
		EqualityExpressionContext _localctx = new EqualityExpressionContext(Context, State);
		EnterRule(_localctx, 26, RULE_equalityExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 339;
			relationalExpression();
			State = 344;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Equal || _la==NotEqual) {
				{
				{
				State = 340;
				_la = TokenStream.LA(1);
				if ( !(_la==Equal || _la==NotEqual) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 341;
				relationalExpression();
				}
				}
				State = 346;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AndExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public EqualityExpressionContext[] equalityExpression() {
			return GetRuleContexts<EqualityExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public EqualityExpressionContext equalityExpression(int i) {
			return GetRuleContext<EqualityExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] And() { return GetTokens(CParser.And); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode And(int i) {
			return GetToken(CParser.And, i);
		}
		public AndExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_andExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterAndExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitAndExpression(this);
		}
	}

	[RuleVersion(0)]
	public AndExpressionContext andExpression() {
		AndExpressionContext _localctx = new AndExpressionContext(Context, State);
		EnterRule(_localctx, 28, RULE_andExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 347;
			equalityExpression();
			State = 352;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==And) {
				{
				{
				State = 348;
				Match(And);
				State = 349;
				equalityExpression();
				}
				}
				State = 354;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExclusiveOrExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AndExpressionContext[] andExpression() {
			return GetRuleContexts<AndExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AndExpressionContext andExpression(int i) {
			return GetRuleContext<AndExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Caret() { return GetTokens(CParser.Caret); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Caret(int i) {
			return GetToken(CParser.Caret, i);
		}
		public ExclusiveOrExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exclusiveOrExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterExclusiveOrExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitExclusiveOrExpression(this);
		}
	}

	[RuleVersion(0)]
	public ExclusiveOrExpressionContext exclusiveOrExpression() {
		ExclusiveOrExpressionContext _localctx = new ExclusiveOrExpressionContext(Context, State);
		EnterRule(_localctx, 30, RULE_exclusiveOrExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 355;
			andExpression();
			State = 360;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Caret) {
				{
				{
				State = 356;
				Match(Caret);
				State = 357;
				andExpression();
				}
				}
				State = 362;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InclusiveOrExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExclusiveOrExpressionContext[] exclusiveOrExpression() {
			return GetRuleContexts<ExclusiveOrExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExclusiveOrExpressionContext exclusiveOrExpression(int i) {
			return GetRuleContext<ExclusiveOrExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Or() { return GetTokens(CParser.Or); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Or(int i) {
			return GetToken(CParser.Or, i);
		}
		public InclusiveOrExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_inclusiveOrExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterInclusiveOrExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitInclusiveOrExpression(this);
		}
	}

	[RuleVersion(0)]
	public InclusiveOrExpressionContext inclusiveOrExpression() {
		InclusiveOrExpressionContext _localctx = new InclusiveOrExpressionContext(Context, State);
		EnterRule(_localctx, 32, RULE_inclusiveOrExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 363;
			exclusiveOrExpression();
			State = 368;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Or) {
				{
				{
				State = 364;
				Match(Or);
				State = 365;
				exclusiveOrExpression();
				}
				}
				State = 370;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LogicalAndExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public InclusiveOrExpressionContext[] inclusiveOrExpression() {
			return GetRuleContexts<InclusiveOrExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public InclusiveOrExpressionContext inclusiveOrExpression(int i) {
			return GetRuleContext<InclusiveOrExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] AndAnd() { return GetTokens(CParser.AndAnd); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AndAnd(int i) {
			return GetToken(CParser.AndAnd, i);
		}
		public LogicalAndExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_logicalAndExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterLogicalAndExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitLogicalAndExpression(this);
		}
	}

	[RuleVersion(0)]
	public LogicalAndExpressionContext logicalAndExpression() {
		LogicalAndExpressionContext _localctx = new LogicalAndExpressionContext(Context, State);
		EnterRule(_localctx, 34, RULE_logicalAndExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 371;
			inclusiveOrExpression();
			State = 376;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==AndAnd) {
				{
				{
				State = 372;
				Match(AndAnd);
				State = 373;
				inclusiveOrExpression();
				}
				}
				State = 378;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LogicalOrExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public LogicalAndExpressionContext[] logicalAndExpression() {
			return GetRuleContexts<LogicalAndExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public LogicalAndExpressionContext logicalAndExpression(int i) {
			return GetRuleContext<LogicalAndExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OrOr() { return GetTokens(CParser.OrOr); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OrOr(int i) {
			return GetToken(CParser.OrOr, i);
		}
		public LogicalOrExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_logicalOrExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterLogicalOrExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitLogicalOrExpression(this);
		}
	}

	[RuleVersion(0)]
	public LogicalOrExpressionContext logicalOrExpression() {
		LogicalOrExpressionContext _localctx = new LogicalOrExpressionContext(Context, State);
		EnterRule(_localctx, 36, RULE_logicalOrExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 379;
			logicalAndExpression();
			State = 384;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==OrOr) {
				{
				{
				State = 380;
				Match(OrOr);
				State = 381;
				logicalAndExpression();
				}
				}
				State = 386;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ConditionalExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public LogicalOrExpressionContext logicalOrExpression() {
			return GetRuleContext<LogicalOrExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Question() { return GetToken(CParser.Question, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(CParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConditionalExpressionContext conditionalExpression() {
			return GetRuleContext<ConditionalExpressionContext>(0);
		}
		public ConditionalExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_conditionalExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterConditionalExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitConditionalExpression(this);
		}
	}

	[RuleVersion(0)]
	public ConditionalExpressionContext conditionalExpression() {
		ConditionalExpressionContext _localctx = new ConditionalExpressionContext(Context, State);
		EnterRule(_localctx, 38, RULE_conditionalExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 387;
			logicalOrExpression();
			State = 393;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Question) {
				{
				State = 388;
				Match(Question);
				State = 389;
				expression();
				State = 390;
				Match(Colon);
				State = 391;
				conditionalExpression();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AssignmentExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ConditionalExpressionContext conditionalExpression() {
			return GetRuleContext<ConditionalExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnaryExpressionContext unaryExpression() {
			return GetRuleContext<UnaryExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentOperatorContext assignmentOperator() {
			return GetRuleContext<AssignmentOperatorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentExpressionContext assignmentExpression() {
			return GetRuleContext<AssignmentExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DigitSequence() { return GetToken(CParser.DigitSequence, 0); }
		public AssignmentExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignmentExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterAssignmentExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitAssignmentExpression(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentExpressionContext assignmentExpression() {
		AssignmentExpressionContext _localctx = new AssignmentExpressionContext(Context, State);
		EnterRule(_localctx, 40, RULE_assignmentExpression);
		try {
			State = 401;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,27,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 395;
				conditionalExpression();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 396;
				unaryExpression();
				State = 397;
				assignmentOperator();
				State = 398;
				assignmentExpression();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 400;
				Match(DigitSequence);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AssignmentOperatorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Assign() { return GetToken(CParser.Assign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode StarAssign() { return GetToken(CParser.StarAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DivAssign() { return GetToken(CParser.DivAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ModAssign() { return GetToken(CParser.ModAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PlusAssign() { return GetToken(CParser.PlusAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MinusAssign() { return GetToken(CParser.MinusAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftShiftAssign() { return GetToken(CParser.LeftShiftAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightShiftAssign() { return GetToken(CParser.RightShiftAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AndAssign() { return GetToken(CParser.AndAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode XorAssign() { return GetToken(CParser.XorAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OrAssign() { return GetToken(CParser.OrAssign, 0); }
		public AssignmentOperatorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignmentOperator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterAssignmentOperator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitAssignmentOperator(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentOperatorContext assignmentOperator() {
		AssignmentOperatorContext _localctx = new AssignmentOperatorContext(Context, State);
		EnterRule(_localctx, 42, RULE_assignmentOperator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 403;
			_la = TokenStream.LA(1);
			if ( !(((((_la - 94)) & ~0x3f) == 0 && ((1L << (_la - 94)) & ((1L << (Assign - 94)) | (1L << (StarAssign - 94)) | (1L << (DivAssign - 94)) | (1L << (ModAssign - 94)) | (1L << (PlusAssign - 94)) | (1L << (MinusAssign - 94)) | (1L << (LeftShiftAssign - 94)) | (1L << (RightShiftAssign - 94)) | (1L << (AndAssign - 94)) | (1L << (XorAssign - 94)) | (1L << (OrAssign - 94)))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentExpressionContext[] assignmentExpression() {
			return GetRuleContexts<AssignmentExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentExpressionContext assignmentExpression(int i) {
			return GetRuleContext<AssignmentExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(CParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(CParser.Comma, i);
		}
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitExpression(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		ExpressionContext _localctx = new ExpressionContext(Context, State);
		EnterRule(_localctx, 44, RULE_expression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 405;
			assignmentExpression();
			State = 410;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 406;
				Match(Comma);
				State = 407;
				assignmentExpression();
				}
				}
				State = 412;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ConstantExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ConditionalExpressionContext conditionalExpression() {
			return GetRuleContext<ConditionalExpressionContext>(0);
		}
		public ConstantExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constantExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterConstantExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitConstantExpression(this);
		}
	}

	[RuleVersion(0)]
	public ConstantExpressionContext constantExpression() {
		ConstantExpressionContext _localctx = new ConstantExpressionContext(Context, State);
		EnterRule(_localctx, 46, RULE_constantExpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 413;
			conditionalExpression();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationSpecifiersContext declarationSpecifiers() {
			return GetRuleContext<DeclarationSpecifiersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CParser.Semi, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InitDeclaratorListContext initDeclaratorList() {
			return GetRuleContext<InitDeclaratorListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StaticAssertDeclarationContext staticAssertDeclaration() {
			return GetRuleContext<StaticAssertDeclarationContext>(0);
		}
		public DeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public DeclarationContext declaration() {
		DeclarationContext _localctx = new DeclarationContext(Context, State);
		EnterRule(_localctx, 48, RULE_declaration);
		int _la;
		try {
			State = 422;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__0:
			case T__3:
			case T__4:
			case T__5:
			case T__6:
			case T__7:
			case T__8:
			case T__9:
			case T__16:
			case Auto:
			case Char:
			case Const:
			case Double:
			case Enum:
			case Extern:
			case Float:
			case Inline:
			case Int:
			case Long:
			case Register:
			case Restrict:
			case Short:
			case Signed:
			case Static:
			case Struct:
			case Typedef:
			case Union:
			case Unsigned:
			case Void:
			case Volatile:
			case Alignas:
			case Atomic:
			case Bool:
			case Complex:
			case Noreturn:
			case ThreadLocal:
			case Identifier:
				EnterOuterAlt(_localctx, 1);
				{
				State = 415;
				declarationSpecifiers();
				State = 417;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__8) | (1L << T__10) | (1L << T__11) | (1L << T__12) | (1L << T__13) | (1L << T__14))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (Star - 64)) | (1L << (Caret - 64)) | (1L << (Identifier - 64)))) != 0)) {
					{
					State = 416;
					initDeclaratorList();
					}
				}

				State = 419;
				Match(Semi);
				}
				break;
			case StaticAssert:
				EnterOuterAlt(_localctx, 2);
				{
				State = 421;
				staticAssertDeclaration();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DeclarationSpecifiersContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationSpecifierContext[] declarationSpecifier() {
			return GetRuleContexts<DeclarationSpecifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationSpecifierContext declarationSpecifier(int i) {
			return GetRuleContext<DeclarationSpecifierContext>(i);
		}
		public DeclarationSpecifiersContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declarationSpecifiers; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterDeclarationSpecifiers(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitDeclarationSpecifiers(this);
		}
	}

	[RuleVersion(0)]
	public DeclarationSpecifiersContext declarationSpecifiers() {
		DeclarationSpecifiersContext _localctx = new DeclarationSpecifiersContext(Context, State);
		EnterRule(_localctx, 50, RULE_declarationSpecifiers);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 425;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 424;
					declarationSpecifier();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 427;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,31,Context);
			} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DeclarationSpecifiers2Context : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationSpecifierContext[] declarationSpecifier() {
			return GetRuleContexts<DeclarationSpecifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationSpecifierContext declarationSpecifier(int i) {
			return GetRuleContext<DeclarationSpecifierContext>(i);
		}
		public DeclarationSpecifiers2Context(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declarationSpecifiers2; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterDeclarationSpecifiers2(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitDeclarationSpecifiers2(this);
		}
	}

	[RuleVersion(0)]
	public DeclarationSpecifiers2Context declarationSpecifiers2() {
		DeclarationSpecifiers2Context _localctx = new DeclarationSpecifiers2Context(Context, State);
		EnterRule(_localctx, 52, RULE_declarationSpecifiers2);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 430;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 429;
				declarationSpecifier();
				}
				}
				State = 432;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__16) | (1L << Auto) | (1L << Char) | (1L << Const) | (1L << Double) | (1L << Enum) | (1L << Extern) | (1L << Float) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Register) | (1L << Restrict) | (1L << Short) | (1L << Signed) | (1L << Static) | (1L << Struct) | (1L << Typedef) | (1L << Union) | (1L << Unsigned) | (1L << Void) | (1L << Volatile) | (1L << Alignas) | (1L << Atomic) | (1L << Bool) | (1L << Complex) | (1L << Noreturn) | (1L << ThreadLocal))) != 0) || _la==Identifier );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DeclarationSpecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StorageClassSpecifierContext storageClassSpecifier() {
			return GetRuleContext<StorageClassSpecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeSpecifierContext typeSpecifier() {
			return GetRuleContext<TypeSpecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeQualifierContext typeQualifier() {
			return GetRuleContext<TypeQualifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FunctionSpecifierContext functionSpecifier() {
			return GetRuleContext<FunctionSpecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AlignmentSpecifierContext alignmentSpecifier() {
			return GetRuleContext<AlignmentSpecifierContext>(0);
		}
		public DeclarationSpecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declarationSpecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterDeclarationSpecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitDeclarationSpecifier(this);
		}
	}

	[RuleVersion(0)]
	public DeclarationSpecifierContext declarationSpecifier() {
		DeclarationSpecifierContext _localctx = new DeclarationSpecifierContext(Context, State);
		EnterRule(_localctx, 54, RULE_declarationSpecifier);
		try {
			State = 439;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,33,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 434;
				storageClassSpecifier();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 435;
				typeSpecifier();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 436;
				typeQualifier();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 437;
				functionSpecifier();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 438;
				alignmentSpecifier();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InitDeclaratorListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public InitDeclaratorContext[] initDeclarator() {
			return GetRuleContexts<InitDeclaratorContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public InitDeclaratorContext initDeclarator(int i) {
			return GetRuleContext<InitDeclaratorContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(CParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(CParser.Comma, i);
		}
		public InitDeclaratorListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_initDeclaratorList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterInitDeclaratorList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitInitDeclaratorList(this);
		}
	}

	[RuleVersion(0)]
	public InitDeclaratorListContext initDeclaratorList() {
		InitDeclaratorListContext _localctx = new InitDeclaratorListContext(Context, State);
		EnterRule(_localctx, 56, RULE_initDeclaratorList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 441;
			initDeclarator();
			State = 446;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 442;
				Match(Comma);
				State = 443;
				initDeclarator();
				}
				}
				State = 448;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InitDeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclaratorContext declarator() {
			return GetRuleContext<DeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Assign() { return GetToken(CParser.Assign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InitializerContext initializer() {
			return GetRuleContext<InitializerContext>(0);
		}
		public InitDeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_initDeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterInitDeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitInitDeclarator(this);
		}
	}

	[RuleVersion(0)]
	public InitDeclaratorContext initDeclarator() {
		InitDeclaratorContext _localctx = new InitDeclaratorContext(Context, State);
		EnterRule(_localctx, 58, RULE_initDeclarator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 449;
			declarator();
			State = 452;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Assign) {
				{
				State = 450;
				Match(Assign);
				State = 451;
				initializer();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StorageClassSpecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Typedef() { return GetToken(CParser.Typedef, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Extern() { return GetToken(CParser.Extern, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Static() { return GetToken(CParser.Static, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ThreadLocal() { return GetToken(CParser.ThreadLocal, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Auto() { return GetToken(CParser.Auto, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Register() { return GetToken(CParser.Register, 0); }
		public StorageClassSpecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_storageClassSpecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterStorageClassSpecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitStorageClassSpecifier(this);
		}
	}

	[RuleVersion(0)]
	public StorageClassSpecifierContext storageClassSpecifier() {
		StorageClassSpecifierContext _localctx = new StorageClassSpecifierContext(Context, State);
		EnterRule(_localctx, 60, RULE_storageClassSpecifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 454;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Auto) | (1L << Extern) | (1L << Register) | (1L << Static) | (1L << Typedef) | (1L << ThreadLocal))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TypeSpecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Void() { return GetToken(CParser.Void, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Char() { return GetToken(CParser.Char, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Short() { return GetToken(CParser.Short, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Int() { return GetToken(CParser.Int, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Long() { return GetToken(CParser.Long, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Float() { return GetToken(CParser.Float, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Double() { return GetToken(CParser.Double, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Signed() { return GetToken(CParser.Signed, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Unsigned() { return GetToken(CParser.Unsigned, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Bool() { return GetToken(CParser.Bool, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Complex() { return GetToken(CParser.Complex, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CParser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CParser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AtomicTypeSpecifierContext atomicTypeSpecifier() {
			return GetRuleContext<AtomicTypeSpecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StructOrUnionSpecifierContext structOrUnionSpecifier() {
			return GetRuleContext<StructOrUnionSpecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EnumSpecifierContext enumSpecifier() {
			return GetRuleContext<EnumSpecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypedefNameContext typedefName() {
			return GetRuleContext<TypedefNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConstantExpressionContext constantExpression() {
			return GetRuleContext<ConstantExpressionContext>(0);
		}
		public TypeSpecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeSpecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterTypeSpecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitTypeSpecifier(this);
		}
	}

	[RuleVersion(0)]
	public TypeSpecifierContext typeSpecifier() {
		TypeSpecifierContext _localctx = new TypeSpecifierContext(Context, State);
		EnterRule(_localctx, 62, RULE_typeSpecifier);
		int _la;
		try {
			State = 470;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__3:
			case T__4:
			case T__5:
			case Char:
			case Double:
			case Float:
			case Int:
			case Long:
			case Short:
			case Signed:
			case Unsigned:
			case Void:
			case Bool:
			case Complex:
				EnterOuterAlt(_localctx, 1);
				{
				State = 456;
				_la = TokenStream.LA(1);
				if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << Char) | (1L << Double) | (1L << Float) | (1L << Int) | (1L << Long) | (1L << Short) | (1L << Signed) | (1L << Unsigned) | (1L << Void) | (1L << Bool) | (1L << Complex))) != 0)) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
				break;
			case T__0:
				EnterOuterAlt(_localctx, 2);
				{
				State = 457;
				Match(T__0);
				State = 458;
				Match(LeftParen);
				State = 459;
				_la = TokenStream.LA(1);
				if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__3) | (1L << T__4) | (1L << T__5))) != 0)) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 460;
				Match(RightParen);
				}
				break;
			case Atomic:
				EnterOuterAlt(_localctx, 3);
				{
				State = 461;
				atomicTypeSpecifier();
				}
				break;
			case Struct:
			case Union:
				EnterOuterAlt(_localctx, 4);
				{
				State = 462;
				structOrUnionSpecifier();
				}
				break;
			case Enum:
				EnterOuterAlt(_localctx, 5);
				{
				State = 463;
				enumSpecifier();
				}
				break;
			case Identifier:
				EnterOuterAlt(_localctx, 6);
				{
				State = 464;
				typedefName();
				}
				break;
			case T__6:
				EnterOuterAlt(_localctx, 7);
				{
				State = 465;
				Match(T__6);
				State = 466;
				Match(LeftParen);
				State = 467;
				constantExpression();
				State = 468;
				Match(RightParen);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StructOrUnionSpecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StructOrUnionContext structOrUnion() {
			return GetRuleContext<StructOrUnionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBrace() { return GetToken(CParser.LeftBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StructDeclarationListContext structDeclarationList() {
			return GetRuleContext<StructDeclarationListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBrace() { return GetToken(CParser.RightBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CParser.Identifier, 0); }
		public StructOrUnionSpecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_structOrUnionSpecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterStructOrUnionSpecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitStructOrUnionSpecifier(this);
		}
	}

	[RuleVersion(0)]
	public StructOrUnionSpecifierContext structOrUnionSpecifier() {
		StructOrUnionSpecifierContext _localctx = new StructOrUnionSpecifierContext(Context, State);
		EnterRule(_localctx, 64, RULE_structOrUnionSpecifier);
		int _la;
		try {
			State = 483;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,38,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 472;
				structOrUnion();
				State = 474;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Identifier) {
					{
					State = 473;
					Match(Identifier);
					}
				}

				State = 476;
				Match(LeftBrace);
				State = 477;
				structDeclarationList();
				State = 478;
				Match(RightBrace);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 480;
				structOrUnion();
				State = 481;
				Match(Identifier);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StructOrUnionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Struct() { return GetToken(CParser.Struct, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Union() { return GetToken(CParser.Union, 0); }
		public StructOrUnionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_structOrUnion; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterStructOrUnion(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitStructOrUnion(this);
		}
	}

	[RuleVersion(0)]
	public StructOrUnionContext structOrUnion() {
		StructOrUnionContext _localctx = new StructOrUnionContext(Context, State);
		EnterRule(_localctx, 66, RULE_structOrUnion);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 485;
			_la = TokenStream.LA(1);
			if ( !(_la==Struct || _la==Union) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StructDeclarationListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StructDeclarationContext[] structDeclaration() {
			return GetRuleContexts<StructDeclarationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public StructDeclarationContext structDeclaration(int i) {
			return GetRuleContext<StructDeclarationContext>(i);
		}
		public StructDeclarationListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_structDeclarationList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterStructDeclarationList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitStructDeclarationList(this);
		}
	}

	[RuleVersion(0)]
	public StructDeclarationListContext structDeclarationList() {
		StructDeclarationListContext _localctx = new StructDeclarationListContext(Context, State);
		EnterRule(_localctx, 68, RULE_structDeclarationList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 488;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 487;
				structDeclaration();
				}
				}
				State = 490;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << Char) | (1L << Const) | (1L << Double) | (1L << Enum) | (1L << Float) | (1L << Int) | (1L << Long) | (1L << Restrict) | (1L << Short) | (1L << Signed) | (1L << Struct) | (1L << Union) | (1L << Unsigned) | (1L << Void) | (1L << Volatile) | (1L << Atomic) | (1L << Bool) | (1L << Complex) | (1L << StaticAssert))) != 0) || _la==Identifier );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StructDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public SpecifierQualifierListContext specifierQualifierList() {
			return GetRuleContext<SpecifierQualifierListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StructDeclaratorListContext structDeclaratorList() {
			return GetRuleContext<StructDeclaratorListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CParser.Semi, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StaticAssertDeclarationContext staticAssertDeclaration() {
			return GetRuleContext<StaticAssertDeclarationContext>(0);
		}
		public StructDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_structDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterStructDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitStructDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public StructDeclarationContext structDeclaration() {
		StructDeclarationContext _localctx = new StructDeclarationContext(Context, State);
		EnterRule(_localctx, 70, RULE_structDeclaration);
		try {
			State = 500;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,40,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 492;
				specifierQualifierList();
				State = 493;
				structDeclaratorList();
				State = 494;
				Match(Semi);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 496;
				specifierQualifierList();
				State = 497;
				Match(Semi);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 499;
				staticAssertDeclaration();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SpecifierQualifierListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TypeSpecifierContext typeSpecifier() {
			return GetRuleContext<TypeSpecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeQualifierContext typeQualifier() {
			return GetRuleContext<TypeQualifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SpecifierQualifierListContext specifierQualifierList() {
			return GetRuleContext<SpecifierQualifierListContext>(0);
		}
		public SpecifierQualifierListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_specifierQualifierList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterSpecifierQualifierList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitSpecifierQualifierList(this);
		}
	}

	[RuleVersion(0)]
	public SpecifierQualifierListContext specifierQualifierList() {
		SpecifierQualifierListContext _localctx = new SpecifierQualifierListContext(Context, State);
		EnterRule(_localctx, 72, RULE_specifierQualifierList);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 504;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,41,Context) ) {
			case 1:
				{
				State = 502;
				typeSpecifier();
				}
				break;
			case 2:
				{
				State = 503;
				typeQualifier();
				}
				break;
			}
			State = 507;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,42,Context) ) {
			case 1:
				{
				State = 506;
				specifierQualifierList();
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StructDeclaratorListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StructDeclaratorContext[] structDeclarator() {
			return GetRuleContexts<StructDeclaratorContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public StructDeclaratorContext structDeclarator(int i) {
			return GetRuleContext<StructDeclaratorContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(CParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(CParser.Comma, i);
		}
		public StructDeclaratorListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_structDeclaratorList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterStructDeclaratorList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitStructDeclaratorList(this);
		}
	}

	[RuleVersion(0)]
	public StructDeclaratorListContext structDeclaratorList() {
		StructDeclaratorListContext _localctx = new StructDeclaratorListContext(Context, State);
		EnterRule(_localctx, 74, RULE_structDeclaratorList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 509;
			structDeclarator();
			State = 514;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 510;
				Match(Comma);
				State = 511;
				structDeclarator();
				}
				}
				State = 516;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StructDeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclaratorContext declarator() {
			return GetRuleContext<DeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(CParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantExpressionContext constantExpression() {
			return GetRuleContext<ConstantExpressionContext>(0);
		}
		public StructDeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_structDeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterStructDeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitStructDeclarator(this);
		}
	}

	[RuleVersion(0)]
	public StructDeclaratorContext structDeclarator() {
		StructDeclaratorContext _localctx = new StructDeclaratorContext(Context, State);
		EnterRule(_localctx, 76, RULE_structDeclarator);
		int _la;
		try {
			State = 523;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,45,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 517;
				declarator();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 519;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__8) | (1L << T__10) | (1L << T__11) | (1L << T__12) | (1L << T__13) | (1L << T__14))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (Star - 64)) | (1L << (Caret - 64)) | (1L << (Identifier - 64)))) != 0)) {
					{
					State = 518;
					declarator();
					}
				}

				State = 521;
				Match(Colon);
				State = 522;
				constantExpression();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EnumSpecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Enum() { return GetToken(CParser.Enum, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBrace() { return GetToken(CParser.LeftBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public EnumeratorListContext enumeratorList() {
			return GetRuleContext<EnumeratorListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBrace() { return GetToken(CParser.RightBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CParser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CParser.Comma, 0); }
		public EnumSpecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumSpecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterEnumSpecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitEnumSpecifier(this);
		}
	}

	[RuleVersion(0)]
	public EnumSpecifierContext enumSpecifier() {
		EnumSpecifierContext _localctx = new EnumSpecifierContext(Context, State);
		EnterRule(_localctx, 78, RULE_enumSpecifier);
		int _la;
		try {
			State = 538;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,48,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 525;
				Match(Enum);
				State = 527;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Identifier) {
					{
					State = 526;
					Match(Identifier);
					}
				}

				State = 529;
				Match(LeftBrace);
				State = 530;
				enumeratorList();
				State = 532;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Comma) {
					{
					State = 531;
					Match(Comma);
					}
				}

				State = 534;
				Match(RightBrace);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 536;
				Match(Enum);
				State = 537;
				Match(Identifier);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EnumeratorListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public EnumeratorContext[] enumerator() {
			return GetRuleContexts<EnumeratorContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public EnumeratorContext enumerator(int i) {
			return GetRuleContext<EnumeratorContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(CParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(CParser.Comma, i);
		}
		public EnumeratorListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumeratorList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterEnumeratorList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitEnumeratorList(this);
		}
	}

	[RuleVersion(0)]
	public EnumeratorListContext enumeratorList() {
		EnumeratorListContext _localctx = new EnumeratorListContext(Context, State);
		EnterRule(_localctx, 80, RULE_enumeratorList);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 540;
			enumerator();
			State = 545;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,49,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 541;
					Match(Comma);
					State = 542;
					enumerator();
					}
					} 
				}
				State = 547;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,49,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EnumeratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public EnumerationConstantContext enumerationConstant() {
			return GetRuleContext<EnumerationConstantContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Assign() { return GetToken(CParser.Assign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantExpressionContext constantExpression() {
			return GetRuleContext<ConstantExpressionContext>(0);
		}
		public EnumeratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumerator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterEnumerator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitEnumerator(this);
		}
	}

	[RuleVersion(0)]
	public EnumeratorContext enumerator() {
		EnumeratorContext _localctx = new EnumeratorContext(Context, State);
		EnterRule(_localctx, 82, RULE_enumerator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 548;
			enumerationConstant();
			State = 551;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Assign) {
				{
				State = 549;
				Match(Assign);
				State = 550;
				constantExpression();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EnumerationConstantContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CParser.Identifier, 0); }
		public EnumerationConstantContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumerationConstant; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterEnumerationConstant(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitEnumerationConstant(this);
		}
	}

	[RuleVersion(0)]
	public EnumerationConstantContext enumerationConstant() {
		EnumerationConstantContext _localctx = new EnumerationConstantContext(Context, State);
		EnterRule(_localctx, 84, RULE_enumerationConstant);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 553;
			Match(Identifier);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AtomicTypeSpecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Atomic() { return GetToken(CParser.Atomic, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CParser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CParser.RightParen, 0); }
		public AtomicTypeSpecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_atomicTypeSpecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterAtomicTypeSpecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitAtomicTypeSpecifier(this);
		}
	}

	[RuleVersion(0)]
	public AtomicTypeSpecifierContext atomicTypeSpecifier() {
		AtomicTypeSpecifierContext _localctx = new AtomicTypeSpecifierContext(Context, State);
		EnterRule(_localctx, 86, RULE_atomicTypeSpecifier);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 555;
			Match(Atomic);
			State = 556;
			Match(LeftParen);
			State = 557;
			typeName();
			State = 558;
			Match(RightParen);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TypeQualifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Const() { return GetToken(CParser.Const, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Restrict() { return GetToken(CParser.Restrict, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Volatile() { return GetToken(CParser.Volatile, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Atomic() { return GetToken(CParser.Atomic, 0); }
		public TypeQualifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeQualifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterTypeQualifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitTypeQualifier(this);
		}
	}

	[RuleVersion(0)]
	public TypeQualifierContext typeQualifier() {
		TypeQualifierContext _localctx = new TypeQualifierContext(Context, State);
		EnterRule(_localctx, 88, RULE_typeQualifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 560;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Const) | (1L << Restrict) | (1L << Volatile) | (1L << Atomic))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FunctionSpecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Inline() { return GetToken(CParser.Inline, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Noreturn() { return GetToken(CParser.Noreturn, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public GccAttributeSpecifierContext gccAttributeSpecifier() {
			return GetRuleContext<GccAttributeSpecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CParser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CParser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CParser.RightParen, 0); }
		public FunctionSpecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_functionSpecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterFunctionSpecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitFunctionSpecifier(this);
		}
	}

	[RuleVersion(0)]
	public FunctionSpecifierContext functionSpecifier() {
		FunctionSpecifierContext _localctx = new FunctionSpecifierContext(Context, State);
		EnterRule(_localctx, 90, RULE_functionSpecifier);
		int _la;
		try {
			State = 568;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__7:
			case T__8:
			case Inline:
			case Noreturn:
				EnterOuterAlt(_localctx, 1);
				{
				State = 562;
				_la = TokenStream.LA(1);
				if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__7) | (1L << T__8) | (1L << Inline) | (1L << Noreturn))) != 0)) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
				break;
			case T__16:
				EnterOuterAlt(_localctx, 2);
				{
				State = 563;
				gccAttributeSpecifier();
				}
				break;
			case T__9:
				EnterOuterAlt(_localctx, 3);
				{
				State = 564;
				Match(T__9);
				State = 565;
				Match(LeftParen);
				State = 566;
				Match(Identifier);
				State = 567;
				Match(RightParen);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AlignmentSpecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Alignas() { return GetToken(CParser.Alignas, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CParser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CParser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConstantExpressionContext constantExpression() {
			return GetRuleContext<ConstantExpressionContext>(0);
		}
		public AlignmentSpecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_alignmentSpecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterAlignmentSpecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitAlignmentSpecifier(this);
		}
	}

	[RuleVersion(0)]
	public AlignmentSpecifierContext alignmentSpecifier() {
		AlignmentSpecifierContext _localctx = new AlignmentSpecifierContext(Context, State);
		EnterRule(_localctx, 92, RULE_alignmentSpecifier);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 570;
			Match(Alignas);
			State = 571;
			Match(LeftParen);
			State = 574;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,52,Context) ) {
			case 1:
				{
				State = 572;
				typeName();
				}
				break;
			case 2:
				{
				State = 573;
				constantExpression();
				}
				break;
			}
			State = 576;
			Match(RightParen);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DirectDeclaratorContext directDeclarator() {
			return GetRuleContext<DirectDeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PointerContext pointer() {
			return GetRuleContext<PointerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public GccDeclaratorExtensionContext[] gccDeclaratorExtension() {
			return GetRuleContexts<GccDeclaratorExtensionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public GccDeclaratorExtensionContext gccDeclaratorExtension(int i) {
			return GetRuleContext<GccDeclaratorExtensionContext>(i);
		}
		public DeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterDeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitDeclarator(this);
		}
	}

	[RuleVersion(0)]
	public DeclaratorContext declarator() {
		DeclaratorContext _localctx = new DeclaratorContext(Context, State);
		EnterRule(_localctx, 94, RULE_declarator);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 579;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Star || _la==Caret) {
				{
				State = 578;
				pointer();
				}
			}

			State = 581;
			directDeclarator(0);
			State = 585;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,54,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 582;
					gccDeclaratorExtension();
					}
					} 
				}
				State = 587;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,54,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DirectDeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CParser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CParser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public DeclaratorContext declarator() {
			return GetRuleContext<DeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CParser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(CParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DigitSequence() { return GetToken(CParser.DigitSequence, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public VcSpecificModiferContext vcSpecificModifer() {
			return GetRuleContext<VcSpecificModiferContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DirectDeclaratorContext directDeclarator() {
			return GetRuleContext<DirectDeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBracket() { return GetToken(CParser.LeftBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBracket() { return GetToken(CParser.RightBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeQualifierListContext typeQualifierList() {
			return GetRuleContext<TypeQualifierListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentExpressionContext assignmentExpression() {
			return GetRuleContext<AssignmentExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Static() { return GetToken(CParser.Static, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Star() { return GetToken(CParser.Star, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ParameterTypeListContext parameterTypeList() {
			return GetRuleContext<ParameterTypeListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierListContext identifierList() {
			return GetRuleContext<IdentifierListContext>(0);
		}
		public DirectDeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_directDeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterDirectDeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitDirectDeclarator(this);
		}
	}

	[RuleVersion(0)]
	public DirectDeclaratorContext directDeclarator() {
		return directDeclarator(0);
	}

	private DirectDeclaratorContext directDeclarator(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		DirectDeclaratorContext _localctx = new DirectDeclaratorContext(Context, _parentState);
		DirectDeclaratorContext _prevctx = _localctx;
		int _startState = 96;
		EnterRecursionRule(_localctx, 96, RULE_directDeclarator, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 605;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,55,Context) ) {
			case 1:
				{
				State = 589;
				Match(Identifier);
				}
				break;
			case 2:
				{
				State = 590;
				Match(LeftParen);
				State = 591;
				declarator();
				State = 592;
				Match(RightParen);
				}
				break;
			case 3:
				{
				State = 594;
				Match(Identifier);
				State = 595;
				Match(Colon);
				State = 596;
				Match(DigitSequence);
				}
				break;
			case 4:
				{
				State = 597;
				vcSpecificModifer();
				State = 598;
				Match(Identifier);
				}
				break;
			case 5:
				{
				State = 600;
				Match(LeftParen);
				State = 601;
				vcSpecificModifer();
				State = 602;
				declarator();
				State = 603;
				Match(RightParen);
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 652;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,62,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 650;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,61,Context) ) {
					case 1:
						{
						_localctx = new DirectDeclaratorContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_directDeclarator);
						State = 607;
						if (!(Precpred(Context, 9))) throw new FailedPredicateException(this, "Precpred(Context, 9)");
						State = 608;
						Match(LeftBracket);
						State = 610;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Const) | (1L << Restrict) | (1L << Volatile) | (1L << Atomic))) != 0)) {
							{
							State = 609;
							typeQualifierList();
							}
						}

						State = 613;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << Sizeof) | (1L << Alignof) | (1L << Generic))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (Plus - 64)) | (1L << (PlusPlus - 64)) | (1L << (Minus - 64)) | (1L << (MinusMinus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (AndAnd - 64)) | (1L << (Not - 64)) | (1L << (Tilde - 64)) | (1L << (Identifier - 64)) | (1L << (Constant - 64)) | (1L << (DigitSequence - 64)) | (1L << (StringLiteral - 64)))) != 0)) {
							{
							State = 612;
							assignmentExpression();
							}
						}

						State = 615;
						Match(RightBracket);
						}
						break;
					case 2:
						{
						_localctx = new DirectDeclaratorContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_directDeclarator);
						State = 616;
						if (!(Precpred(Context, 8))) throw new FailedPredicateException(this, "Precpred(Context, 8)");
						State = 617;
						Match(LeftBracket);
						State = 618;
						Match(Static);
						State = 620;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Const) | (1L << Restrict) | (1L << Volatile) | (1L << Atomic))) != 0)) {
							{
							State = 619;
							typeQualifierList();
							}
						}

						State = 622;
						assignmentExpression();
						State = 623;
						Match(RightBracket);
						}
						break;
					case 3:
						{
						_localctx = new DirectDeclaratorContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_directDeclarator);
						State = 625;
						if (!(Precpred(Context, 7))) throw new FailedPredicateException(this, "Precpred(Context, 7)");
						State = 626;
						Match(LeftBracket);
						State = 627;
						typeQualifierList();
						State = 628;
						Match(Static);
						State = 629;
						assignmentExpression();
						State = 630;
						Match(RightBracket);
						}
						break;
					case 4:
						{
						_localctx = new DirectDeclaratorContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_directDeclarator);
						State = 632;
						if (!(Precpred(Context, 6))) throw new FailedPredicateException(this, "Precpred(Context, 6)");
						State = 633;
						Match(LeftBracket);
						State = 635;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Const) | (1L << Restrict) | (1L << Volatile) | (1L << Atomic))) != 0)) {
							{
							State = 634;
							typeQualifierList();
							}
						}

						State = 637;
						Match(Star);
						State = 638;
						Match(RightBracket);
						}
						break;
					case 5:
						{
						_localctx = new DirectDeclaratorContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_directDeclarator);
						State = 639;
						if (!(Precpred(Context, 5))) throw new FailedPredicateException(this, "Precpred(Context, 5)");
						State = 640;
						Match(LeftParen);
						State = 641;
						parameterTypeList();
						State = 642;
						Match(RightParen);
						}
						break;
					case 6:
						{
						_localctx = new DirectDeclaratorContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_directDeclarator);
						State = 644;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 645;
						Match(LeftParen);
						State = 647;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if (_la==Identifier) {
							{
							State = 646;
							identifierList();
							}
						}

						State = 649;
						Match(RightParen);
						}
						break;
					}
					} 
				}
				State = 654;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,62,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class VcSpecificModiferContext : ParserRuleContext {
		public VcSpecificModiferContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_vcSpecificModifer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterVcSpecificModifer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitVcSpecificModifer(this);
		}
	}

	[RuleVersion(0)]
	public VcSpecificModiferContext vcSpecificModifer() {
		VcSpecificModiferContext _localctx = new VcSpecificModiferContext(Context, State);
		EnterRule(_localctx, 98, RULE_vcSpecificModifer);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 655;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__8) | (1L << T__10) | (1L << T__11) | (1L << T__12) | (1L << T__13) | (1L << T__14))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class GccDeclaratorExtensionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CParser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CParser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] StringLiteral() { return GetTokens(CParser.StringLiteral); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode StringLiteral(int i) {
			return GetToken(CParser.StringLiteral, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public GccAttributeSpecifierContext gccAttributeSpecifier() {
			return GetRuleContext<GccAttributeSpecifierContext>(0);
		}
		public GccDeclaratorExtensionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_gccDeclaratorExtension; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterGccDeclaratorExtension(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitGccDeclaratorExtension(this);
		}
	}

	[RuleVersion(0)]
	public GccDeclaratorExtensionContext gccDeclaratorExtension() {
		GccDeclaratorExtensionContext _localctx = new GccDeclaratorExtensionContext(Context, State);
		EnterRule(_localctx, 100, RULE_gccDeclaratorExtension);
		int _la;
		try {
			State = 666;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__15:
				EnterOuterAlt(_localctx, 1);
				{
				State = 657;
				Match(T__15);
				State = 658;
				Match(LeftParen);
				State = 660;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				do {
					{
					{
					State = 659;
					Match(StringLiteral);
					}
					}
					State = 662;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				} while ( _la==StringLiteral );
				State = 664;
				Match(RightParen);
				}
				break;
			case T__16:
				EnterOuterAlt(_localctx, 2);
				{
				State = 665;
				gccAttributeSpecifier();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class GccAttributeSpecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LeftParen() { return GetTokens(CParser.LeftParen); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen(int i) {
			return GetToken(CParser.LeftParen, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public GccAttributeListContext gccAttributeList() {
			return GetRuleContext<GccAttributeListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RightParen() { return GetTokens(CParser.RightParen); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen(int i) {
			return GetToken(CParser.RightParen, i);
		}
		public GccAttributeSpecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_gccAttributeSpecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterGccAttributeSpecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitGccAttributeSpecifier(this);
		}
	}

	[RuleVersion(0)]
	public GccAttributeSpecifierContext gccAttributeSpecifier() {
		GccAttributeSpecifierContext _localctx = new GccAttributeSpecifierContext(Context, State);
		EnterRule(_localctx, 102, RULE_gccAttributeSpecifier);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 668;
			Match(T__16);
			State = 669;
			Match(LeftParen);
			State = 670;
			Match(LeftParen);
			State = 671;
			gccAttributeList();
			State = 672;
			Match(RightParen);
			State = 673;
			Match(RightParen);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class GccAttributeListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public GccAttributeContext[] gccAttribute() {
			return GetRuleContexts<GccAttributeContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public GccAttributeContext gccAttribute(int i) {
			return GetRuleContext<GccAttributeContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(CParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(CParser.Comma, i);
		}
		public GccAttributeListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_gccAttributeList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterGccAttributeList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitGccAttributeList(this);
		}
	}

	[RuleVersion(0)]
	public GccAttributeListContext gccAttributeList() {
		GccAttributeListContext _localctx = new GccAttributeListContext(Context, State);
		EnterRule(_localctx, 104, RULE_gccAttributeList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 676;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__10) | (1L << T__11) | (1L << T__12) | (1L << T__13) | (1L << T__14) | (1L << T__15) | (1L << T__16) | (1L << T__17) | (1L << T__18) | (1L << Auto) | (1L << Break) | (1L << Case) | (1L << Char) | (1L << Const) | (1L << Continue) | (1L << Default) | (1L << Do) | (1L << Double) | (1L << Else) | (1L << Enum) | (1L << Extern) | (1L << Float) | (1L << For) | (1L << Goto) | (1L << If) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Register) | (1L << Restrict) | (1L << Return) | (1L << Short) | (1L << Signed) | (1L << Sizeof) | (1L << Static) | (1L << Struct) | (1L << Switch) | (1L << Typedef) | (1L << Union) | (1L << Unsigned) | (1L << Void) | (1L << Volatile) | (1L << While) | (1L << Alignas) | (1L << Alignof) | (1L << Atomic) | (1L << Bool) | (1L << Complex) | (1L << Generic) | (1L << Imaginary) | (1L << Noreturn) | (1L << StaticAssert) | (1L << ThreadLocal))) != 0) || ((((_la - 66)) & ~0x3f) == 0 && ((1L << (_la - 66)) & ((1L << (LeftBracket - 66)) | (1L << (RightBracket - 66)) | (1L << (LeftBrace - 66)) | (1L << (RightBrace - 66)) | (1L << (Less - 66)) | (1L << (LessEqual - 66)) | (1L << (Greater - 66)) | (1L << (GreaterEqual - 66)) | (1L << (LeftShift - 66)) | (1L << (RightShift - 66)) | (1L << (Plus - 66)) | (1L << (PlusPlus - 66)) | (1L << (Minus - 66)) | (1L << (MinusMinus - 66)) | (1L << (Star - 66)) | (1L << (Div - 66)) | (1L << (Mod - 66)) | (1L << (And - 66)) | (1L << (Or - 66)) | (1L << (AndAnd - 66)) | (1L << (OrOr - 66)) | (1L << (Caret - 66)) | (1L << (Not - 66)) | (1L << (Tilde - 66)) | (1L << (Question - 66)) | (1L << (Colon - 66)) | (1L << (Semi - 66)) | (1L << (Assign - 66)) | (1L << (StarAssign - 66)) | (1L << (DivAssign - 66)) | (1L << (ModAssign - 66)) | (1L << (PlusAssign - 66)) | (1L << (MinusAssign - 66)) | (1L << (LeftShiftAssign - 66)) | (1L << (RightShiftAssign - 66)) | (1L << (AndAssign - 66)) | (1L << (XorAssign - 66)) | (1L << (OrAssign - 66)) | (1L << (Equal - 66)) | (1L << (NotEqual - 66)) | (1L << (Arrow - 66)) | (1L << (Dot - 66)) | (1L << (Ellipsis - 66)) | (1L << (Identifier - 66)) | (1L << (Constant - 66)) | (1L << (DigitSequence - 66)) | (1L << (StringLiteral - 66)) | (1L << (ComplexDefine - 66)) | (1L << (IncludeDirective - 66)) | (1L << (AsmBlock - 66)) | (1L << (LineAfterPreprocessing - 66)) | (1L << (LineDirective - 66)) | (1L << (PragmaDirective - 66)) | (1L << (Whitespace - 66)) | (1L << (Newline - 66)) | (1L << (BlockComment - 66)) | (1L << (LineComment - 66)))) != 0)) {
				{
				State = 675;
				gccAttribute();
				}
			}

			State = 684;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 678;
				Match(Comma);
				State = 680;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__10) | (1L << T__11) | (1L << T__12) | (1L << T__13) | (1L << T__14) | (1L << T__15) | (1L << T__16) | (1L << T__17) | (1L << T__18) | (1L << Auto) | (1L << Break) | (1L << Case) | (1L << Char) | (1L << Const) | (1L << Continue) | (1L << Default) | (1L << Do) | (1L << Double) | (1L << Else) | (1L << Enum) | (1L << Extern) | (1L << Float) | (1L << For) | (1L << Goto) | (1L << If) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Register) | (1L << Restrict) | (1L << Return) | (1L << Short) | (1L << Signed) | (1L << Sizeof) | (1L << Static) | (1L << Struct) | (1L << Switch) | (1L << Typedef) | (1L << Union) | (1L << Unsigned) | (1L << Void) | (1L << Volatile) | (1L << While) | (1L << Alignas) | (1L << Alignof) | (1L << Atomic) | (1L << Bool) | (1L << Complex) | (1L << Generic) | (1L << Imaginary) | (1L << Noreturn) | (1L << StaticAssert) | (1L << ThreadLocal))) != 0) || ((((_la - 66)) & ~0x3f) == 0 && ((1L << (_la - 66)) & ((1L << (LeftBracket - 66)) | (1L << (RightBracket - 66)) | (1L << (LeftBrace - 66)) | (1L << (RightBrace - 66)) | (1L << (Less - 66)) | (1L << (LessEqual - 66)) | (1L << (Greater - 66)) | (1L << (GreaterEqual - 66)) | (1L << (LeftShift - 66)) | (1L << (RightShift - 66)) | (1L << (Plus - 66)) | (1L << (PlusPlus - 66)) | (1L << (Minus - 66)) | (1L << (MinusMinus - 66)) | (1L << (Star - 66)) | (1L << (Div - 66)) | (1L << (Mod - 66)) | (1L << (And - 66)) | (1L << (Or - 66)) | (1L << (AndAnd - 66)) | (1L << (OrOr - 66)) | (1L << (Caret - 66)) | (1L << (Not - 66)) | (1L << (Tilde - 66)) | (1L << (Question - 66)) | (1L << (Colon - 66)) | (1L << (Semi - 66)) | (1L << (Assign - 66)) | (1L << (StarAssign - 66)) | (1L << (DivAssign - 66)) | (1L << (ModAssign - 66)) | (1L << (PlusAssign - 66)) | (1L << (MinusAssign - 66)) | (1L << (LeftShiftAssign - 66)) | (1L << (RightShiftAssign - 66)) | (1L << (AndAssign - 66)) | (1L << (XorAssign - 66)) | (1L << (OrAssign - 66)) | (1L << (Equal - 66)) | (1L << (NotEqual - 66)) | (1L << (Arrow - 66)) | (1L << (Dot - 66)) | (1L << (Ellipsis - 66)) | (1L << (Identifier - 66)) | (1L << (Constant - 66)) | (1L << (DigitSequence - 66)) | (1L << (StringLiteral - 66)) | (1L << (ComplexDefine - 66)) | (1L << (IncludeDirective - 66)) | (1L << (AsmBlock - 66)) | (1L << (LineAfterPreprocessing - 66)) | (1L << (LineDirective - 66)) | (1L << (PragmaDirective - 66)) | (1L << (Whitespace - 66)) | (1L << (Newline - 66)) | (1L << (BlockComment - 66)) | (1L << (LineComment - 66)))) != 0)) {
					{
					State = 679;
					gccAttribute();
					}
				}

				}
				}
				State = 686;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class GccAttributeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CParser.Comma, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LeftParen() { return GetTokens(CParser.LeftParen); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen(int i) {
			return GetToken(CParser.LeftParen, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RightParen() { return GetTokens(CParser.RightParen); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen(int i) {
			return GetToken(CParser.RightParen, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentExpressionListContext argumentExpressionList() {
			return GetRuleContext<ArgumentExpressionListContext>(0);
		}
		public GccAttributeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_gccAttribute; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterGccAttribute(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitGccAttribute(this);
		}
	}

	[RuleVersion(0)]
	public GccAttributeContext gccAttribute() {
		GccAttributeContext _localctx = new GccAttributeContext(Context, State);
		EnterRule(_localctx, 106, RULE_gccAttribute);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 687;
			_la = TokenStream.LA(1);
			if ( _la <= 0 || (((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (RightParen - 64)) | (1L << (Comma - 64)))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			State = 693;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LeftParen) {
				{
				State = 688;
				Match(LeftParen);
				State = 690;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << Sizeof) | (1L << Alignof) | (1L << Generic))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (Plus - 64)) | (1L << (PlusPlus - 64)) | (1L << (Minus - 64)) | (1L << (MinusMinus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (AndAnd - 64)) | (1L << (Not - 64)) | (1L << (Tilde - 64)) | (1L << (Identifier - 64)) | (1L << (Constant - 64)) | (1L << (DigitSequence - 64)) | (1L << (StringLiteral - 64)))) != 0)) {
					{
					State = 689;
					argumentExpressionList();
					}
				}

				State = 692;
				Match(RightParen);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NestedParenthesesBlockContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LeftParen() { return GetTokens(CParser.LeftParen); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen(int i) {
			return GetToken(CParser.LeftParen, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NestedParenthesesBlockContext[] nestedParenthesesBlock() {
			return GetRuleContexts<NestedParenthesesBlockContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public NestedParenthesesBlockContext nestedParenthesesBlock(int i) {
			return GetRuleContext<NestedParenthesesBlockContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RightParen() { return GetTokens(CParser.RightParen); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen(int i) {
			return GetToken(CParser.RightParen, i);
		}
		public NestedParenthesesBlockContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_nestedParenthesesBlock; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterNestedParenthesesBlock(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitNestedParenthesesBlock(this);
		}
	}

	[RuleVersion(0)]
	public NestedParenthesesBlockContext nestedParenthesesBlock() {
		NestedParenthesesBlockContext _localctx = new NestedParenthesesBlockContext(Context, State);
		EnterRule(_localctx, 108, RULE_nestedParenthesesBlock);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 702;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__10) | (1L << T__11) | (1L << T__12) | (1L << T__13) | (1L << T__14) | (1L << T__15) | (1L << T__16) | (1L << T__17) | (1L << T__18) | (1L << Auto) | (1L << Break) | (1L << Case) | (1L << Char) | (1L << Const) | (1L << Continue) | (1L << Default) | (1L << Do) | (1L << Double) | (1L << Else) | (1L << Enum) | (1L << Extern) | (1L << Float) | (1L << For) | (1L << Goto) | (1L << If) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Register) | (1L << Restrict) | (1L << Return) | (1L << Short) | (1L << Signed) | (1L << Sizeof) | (1L << Static) | (1L << Struct) | (1L << Switch) | (1L << Typedef) | (1L << Union) | (1L << Unsigned) | (1L << Void) | (1L << Volatile) | (1L << While) | (1L << Alignas) | (1L << Alignof) | (1L << Atomic) | (1L << Bool) | (1L << Complex) | (1L << Generic) | (1L << Imaginary) | (1L << Noreturn) | (1L << StaticAssert) | (1L << ThreadLocal))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (RightBracket - 64)) | (1L << (LeftBrace - 64)) | (1L << (RightBrace - 64)) | (1L << (Less - 64)) | (1L << (LessEqual - 64)) | (1L << (Greater - 64)) | (1L << (GreaterEqual - 64)) | (1L << (LeftShift - 64)) | (1L << (RightShift - 64)) | (1L << (Plus - 64)) | (1L << (PlusPlus - 64)) | (1L << (Minus - 64)) | (1L << (MinusMinus - 64)) | (1L << (Star - 64)) | (1L << (Div - 64)) | (1L << (Mod - 64)) | (1L << (And - 64)) | (1L << (Or - 64)) | (1L << (AndAnd - 64)) | (1L << (OrOr - 64)) | (1L << (Caret - 64)) | (1L << (Not - 64)) | (1L << (Tilde - 64)) | (1L << (Question - 64)) | (1L << (Colon - 64)) | (1L << (Semi - 64)) | (1L << (Comma - 64)) | (1L << (Assign - 64)) | (1L << (StarAssign - 64)) | (1L << (DivAssign - 64)) | (1L << (ModAssign - 64)) | (1L << (PlusAssign - 64)) | (1L << (MinusAssign - 64)) | (1L << (LeftShiftAssign - 64)) | (1L << (RightShiftAssign - 64)) | (1L << (AndAssign - 64)) | (1L << (XorAssign - 64)) | (1L << (OrAssign - 64)) | (1L << (Equal - 64)) | (1L << (NotEqual - 64)) | (1L << (Arrow - 64)) | (1L << (Dot - 64)) | (1L << (Ellipsis - 64)) | (1L << (Identifier - 64)) | (1L << (Constant - 64)) | (1L << (DigitSequence - 64)) | (1L << (StringLiteral - 64)) | (1L << (ComplexDefine - 64)) | (1L << (IncludeDirective - 64)) | (1L << (AsmBlock - 64)) | (1L << (LineAfterPreprocessing - 64)) | (1L << (LineDirective - 64)) | (1L << (PragmaDirective - 64)) | (1L << (Whitespace - 64)) | (1L << (Newline - 64)) | (1L << (BlockComment - 64)) | (1L << (LineComment - 64)))) != 0)) {
				{
				State = 700;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case T__0:
				case T__1:
				case T__2:
				case T__3:
				case T__4:
				case T__5:
				case T__6:
				case T__7:
				case T__8:
				case T__9:
				case T__10:
				case T__11:
				case T__12:
				case T__13:
				case T__14:
				case T__15:
				case T__16:
				case T__17:
				case T__18:
				case Auto:
				case Break:
				case Case:
				case Char:
				case Const:
				case Continue:
				case Default:
				case Do:
				case Double:
				case Else:
				case Enum:
				case Extern:
				case Float:
				case For:
				case Goto:
				case If:
				case Inline:
				case Int:
				case Long:
				case Register:
				case Restrict:
				case Return:
				case Short:
				case Signed:
				case Sizeof:
				case Static:
				case Struct:
				case Switch:
				case Typedef:
				case Union:
				case Unsigned:
				case Void:
				case Volatile:
				case While:
				case Alignas:
				case Alignof:
				case Atomic:
				case Bool:
				case Complex:
				case Generic:
				case Imaginary:
				case Noreturn:
				case StaticAssert:
				case ThreadLocal:
				case LeftBracket:
				case RightBracket:
				case LeftBrace:
				case RightBrace:
				case Less:
				case LessEqual:
				case Greater:
				case GreaterEqual:
				case LeftShift:
				case RightShift:
				case Plus:
				case PlusPlus:
				case Minus:
				case MinusMinus:
				case Star:
				case Div:
				case Mod:
				case And:
				case Or:
				case AndAnd:
				case OrOr:
				case Caret:
				case Not:
				case Tilde:
				case Question:
				case Colon:
				case Semi:
				case Comma:
				case Assign:
				case StarAssign:
				case DivAssign:
				case ModAssign:
				case PlusAssign:
				case MinusAssign:
				case LeftShiftAssign:
				case RightShiftAssign:
				case AndAssign:
				case XorAssign:
				case OrAssign:
				case Equal:
				case NotEqual:
				case Arrow:
				case Dot:
				case Ellipsis:
				case Identifier:
				case Constant:
				case DigitSequence:
				case StringLiteral:
				case ComplexDefine:
				case IncludeDirective:
				case AsmBlock:
				case LineAfterPreprocessing:
				case LineDirective:
				case PragmaDirective:
				case Whitespace:
				case Newline:
				case BlockComment:
				case LineComment:
					{
					State = 695;
					_la = TokenStream.LA(1);
					if ( _la <= 0 || (_la==LeftParen || _la==RightParen) ) {
					ErrorHandler.RecoverInline(this);
					}
					else {
						ErrorHandler.ReportMatch(this);
					    Consume();
					}
					}
					break;
				case LeftParen:
					{
					State = 696;
					Match(LeftParen);
					State = 697;
					nestedParenthesesBlock();
					State = 698;
					Match(RightParen);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 704;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PointerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Star() { return GetTokens(CParser.Star); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Star(int i) {
			return GetToken(CParser.Star, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Caret() { return GetTokens(CParser.Caret); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Caret(int i) {
			return GetToken(CParser.Caret, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeQualifierListContext[] typeQualifierList() {
			return GetRuleContexts<TypeQualifierListContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeQualifierListContext typeQualifierList(int i) {
			return GetRuleContext<TypeQualifierListContext>(i);
		}
		public PointerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_pointer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterPointer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitPointer(this);
		}
	}

	[RuleVersion(0)]
	public PointerContext pointer() {
		PointerContext _localctx = new PointerContext(Context, State);
		EnterRule(_localctx, 110, RULE_pointer);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 709;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 705;
				_la = TokenStream.LA(1);
				if ( !(_la==Star || _la==Caret) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 707;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Const) | (1L << Restrict) | (1L << Volatile) | (1L << Atomic))) != 0)) {
					{
					State = 706;
					typeQualifierList();
					}
				}

				}
				}
				State = 711;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==Star || _la==Caret );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TypeQualifierListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TypeQualifierContext[] typeQualifier() {
			return GetRuleContexts<TypeQualifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeQualifierContext typeQualifier(int i) {
			return GetRuleContext<TypeQualifierContext>(i);
		}
		public TypeQualifierListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeQualifierList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterTypeQualifierList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitTypeQualifierList(this);
		}
	}

	[RuleVersion(0)]
	public TypeQualifierListContext typeQualifierList() {
		TypeQualifierListContext _localctx = new TypeQualifierListContext(Context, State);
		EnterRule(_localctx, 112, RULE_typeQualifierList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 714;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 713;
				typeQualifier();
				}
				}
				State = 716;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Const) | (1L << Restrict) | (1L << Volatile) | (1L << Atomic))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ParameterTypeListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ParameterListContext parameterList() {
			return GetRuleContext<ParameterListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CParser.Comma, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ellipsis() { return GetToken(CParser.Ellipsis, 0); }
		public ParameterTypeListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parameterTypeList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterParameterTypeList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitParameterTypeList(this);
		}
	}

	[RuleVersion(0)]
	public ParameterTypeListContext parameterTypeList() {
		ParameterTypeListContext _localctx = new ParameterTypeListContext(Context, State);
		EnterRule(_localctx, 114, RULE_parameterTypeList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 718;
			parameterList();
			State = 721;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Comma) {
				{
				State = 719;
				Match(Comma);
				State = 720;
				Match(Ellipsis);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ParameterListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ParameterDeclarationContext[] parameterDeclaration() {
			return GetRuleContexts<ParameterDeclarationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ParameterDeclarationContext parameterDeclaration(int i) {
			return GetRuleContext<ParameterDeclarationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(CParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(CParser.Comma, i);
		}
		public ParameterListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parameterList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterParameterList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitParameterList(this);
		}
	}

	[RuleVersion(0)]
	public ParameterListContext parameterList() {
		ParameterListContext _localctx = new ParameterListContext(Context, State);
		EnterRule(_localctx, 116, RULE_parameterList);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 723;
			parameterDeclaration();
			State = 728;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,76,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 724;
					Match(Comma);
					State = 725;
					parameterDeclaration();
					}
					} 
				}
				State = 730;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,76,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ParameterDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationSpecifiersContext declarationSpecifiers() {
			return GetRuleContext<DeclarationSpecifiersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclaratorContext declarator() {
			return GetRuleContext<DeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationSpecifiers2Context declarationSpecifiers2() {
			return GetRuleContext<DeclarationSpecifiers2Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AbstractDeclaratorContext abstractDeclarator() {
			return GetRuleContext<AbstractDeclaratorContext>(0);
		}
		public ParameterDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parameterDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterParameterDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitParameterDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public ParameterDeclarationContext parameterDeclaration() {
		ParameterDeclarationContext _localctx = new ParameterDeclarationContext(Context, State);
		EnterRule(_localctx, 118, RULE_parameterDeclaration);
		int _la;
		try {
			State = 738;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,78,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 731;
				declarationSpecifiers();
				State = 732;
				declarator();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 734;
				declarationSpecifiers2();
				State = 736;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (Star - 64)) | (1L << (Caret - 64)))) != 0)) {
					{
					State = 735;
					abstractDeclarator();
					}
				}

				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IdentifierListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Identifier() { return GetTokens(CParser.Identifier); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier(int i) {
			return GetToken(CParser.Identifier, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(CParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(CParser.Comma, i);
		}
		public IdentifierListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_identifierList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterIdentifierList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitIdentifierList(this);
		}
	}

	[RuleVersion(0)]
	public IdentifierListContext identifierList() {
		IdentifierListContext _localctx = new IdentifierListContext(Context, State);
		EnterRule(_localctx, 120, RULE_identifierList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 740;
			Match(Identifier);
			State = 745;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 741;
				Match(Comma);
				State = 742;
				Match(Identifier);
				}
				}
				State = 747;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TypeNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public SpecifierQualifierListContext specifierQualifierList() {
			return GetRuleContext<SpecifierQualifierListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AbstractDeclaratorContext abstractDeclarator() {
			return GetRuleContext<AbstractDeclaratorContext>(0);
		}
		public TypeNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterTypeName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitTypeName(this);
		}
	}

	[RuleVersion(0)]
	public TypeNameContext typeName() {
		TypeNameContext _localctx = new TypeNameContext(Context, State);
		EnterRule(_localctx, 122, RULE_typeName);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 748;
			specifierQualifierList();
			State = 750;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (Star - 64)) | (1L << (Caret - 64)))) != 0)) {
				{
				State = 749;
				abstractDeclarator();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AbstractDeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PointerContext pointer() {
			return GetRuleContext<PointerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DirectAbstractDeclaratorContext directAbstractDeclarator() {
			return GetRuleContext<DirectAbstractDeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public GccDeclaratorExtensionContext[] gccDeclaratorExtension() {
			return GetRuleContexts<GccDeclaratorExtensionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public GccDeclaratorExtensionContext gccDeclaratorExtension(int i) {
			return GetRuleContext<GccDeclaratorExtensionContext>(i);
		}
		public AbstractDeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_abstractDeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterAbstractDeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitAbstractDeclarator(this);
		}
	}

	[RuleVersion(0)]
	public AbstractDeclaratorContext abstractDeclarator() {
		AbstractDeclaratorContext _localctx = new AbstractDeclaratorContext(Context, State);
		EnterRule(_localctx, 124, RULE_abstractDeclarator);
		int _la;
		try {
			State = 763;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,83,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 752;
				pointer();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 754;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Star || _la==Caret) {
					{
					State = 753;
					pointer();
					}
				}

				State = 756;
				directAbstractDeclarator(0);
				State = 760;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==T__15 || _la==T__16) {
					{
					{
					State = 757;
					gccDeclaratorExtension();
					}
					}
					State = 762;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DirectAbstractDeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CParser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AbstractDeclaratorContext abstractDeclarator() {
			return GetRuleContext<AbstractDeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CParser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public GccDeclaratorExtensionContext[] gccDeclaratorExtension() {
			return GetRuleContexts<GccDeclaratorExtensionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public GccDeclaratorExtensionContext gccDeclaratorExtension(int i) {
			return GetRuleContext<GccDeclaratorExtensionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBracket() { return GetToken(CParser.LeftBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBracket() { return GetToken(CParser.RightBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeQualifierListContext typeQualifierList() {
			return GetRuleContext<TypeQualifierListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentExpressionContext assignmentExpression() {
			return GetRuleContext<AssignmentExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Static() { return GetToken(CParser.Static, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Star() { return GetToken(CParser.Star, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ParameterTypeListContext parameterTypeList() {
			return GetRuleContext<ParameterTypeListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DirectAbstractDeclaratorContext directAbstractDeclarator() {
			return GetRuleContext<DirectAbstractDeclaratorContext>(0);
		}
		public DirectAbstractDeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_directAbstractDeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterDirectAbstractDeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitDirectAbstractDeclarator(this);
		}
	}

	[RuleVersion(0)]
	public DirectAbstractDeclaratorContext directAbstractDeclarator() {
		return directAbstractDeclarator(0);
	}

	private DirectAbstractDeclaratorContext directAbstractDeclarator(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		DirectAbstractDeclaratorContext _localctx = new DirectAbstractDeclaratorContext(Context, _parentState);
		DirectAbstractDeclaratorContext _prevctx = _localctx;
		int _startState = 126;
		EnterRecursionRule(_localctx, 126, RULE_directAbstractDeclarator, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 811;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,90,Context) ) {
			case 1:
				{
				State = 766;
				Match(LeftParen);
				State = 767;
				abstractDeclarator();
				State = 768;
				Match(RightParen);
				State = 772;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,84,Context);
				while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						State = 769;
						gccDeclaratorExtension();
						}
						} 
					}
					State = 774;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,84,Context);
				}
				}
				break;
			case 2:
				{
				State = 775;
				Match(LeftBracket);
				State = 777;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Const) | (1L << Restrict) | (1L << Volatile) | (1L << Atomic))) != 0)) {
					{
					State = 776;
					typeQualifierList();
					}
				}

				State = 780;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << Sizeof) | (1L << Alignof) | (1L << Generic))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (Plus - 64)) | (1L << (PlusPlus - 64)) | (1L << (Minus - 64)) | (1L << (MinusMinus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (AndAnd - 64)) | (1L << (Not - 64)) | (1L << (Tilde - 64)) | (1L << (Identifier - 64)) | (1L << (Constant - 64)) | (1L << (DigitSequence - 64)) | (1L << (StringLiteral - 64)))) != 0)) {
					{
					State = 779;
					assignmentExpression();
					}
				}

				State = 782;
				Match(RightBracket);
				}
				break;
			case 3:
				{
				State = 783;
				Match(LeftBracket);
				State = 784;
				Match(Static);
				State = 786;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Const) | (1L << Restrict) | (1L << Volatile) | (1L << Atomic))) != 0)) {
					{
					State = 785;
					typeQualifierList();
					}
				}

				State = 788;
				assignmentExpression();
				State = 789;
				Match(RightBracket);
				}
				break;
			case 4:
				{
				State = 791;
				Match(LeftBracket);
				State = 792;
				typeQualifierList();
				State = 793;
				Match(Static);
				State = 794;
				assignmentExpression();
				State = 795;
				Match(RightBracket);
				}
				break;
			case 5:
				{
				State = 797;
				Match(LeftBracket);
				State = 798;
				Match(Star);
				State = 799;
				Match(RightBracket);
				}
				break;
			case 6:
				{
				State = 800;
				Match(LeftParen);
				State = 802;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__16) | (1L << Auto) | (1L << Char) | (1L << Const) | (1L << Double) | (1L << Enum) | (1L << Extern) | (1L << Float) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Register) | (1L << Restrict) | (1L << Short) | (1L << Signed) | (1L << Static) | (1L << Struct) | (1L << Typedef) | (1L << Union) | (1L << Unsigned) | (1L << Void) | (1L << Volatile) | (1L << Alignas) | (1L << Atomic) | (1L << Bool) | (1L << Complex) | (1L << Noreturn) | (1L << ThreadLocal))) != 0) || _la==Identifier) {
					{
					State = 801;
					parameterTypeList();
					}
				}

				State = 804;
				Match(RightParen);
				State = 808;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,89,Context);
				while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						State = 805;
						gccDeclaratorExtension();
						}
						} 
					}
					State = 810;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,89,Context);
				}
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 856;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,97,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 854;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,96,Context) ) {
					case 1:
						{
						_localctx = new DirectAbstractDeclaratorContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_directAbstractDeclarator);
						State = 813;
						if (!(Precpred(Context, 5))) throw new FailedPredicateException(this, "Precpred(Context, 5)");
						State = 814;
						Match(LeftBracket);
						State = 816;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Const) | (1L << Restrict) | (1L << Volatile) | (1L << Atomic))) != 0)) {
							{
							State = 815;
							typeQualifierList();
							}
						}

						State = 819;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << Sizeof) | (1L << Alignof) | (1L << Generic))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (Plus - 64)) | (1L << (PlusPlus - 64)) | (1L << (Minus - 64)) | (1L << (MinusMinus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (AndAnd - 64)) | (1L << (Not - 64)) | (1L << (Tilde - 64)) | (1L << (Identifier - 64)) | (1L << (Constant - 64)) | (1L << (DigitSequence - 64)) | (1L << (StringLiteral - 64)))) != 0)) {
							{
							State = 818;
							assignmentExpression();
							}
						}

						State = 821;
						Match(RightBracket);
						}
						break;
					case 2:
						{
						_localctx = new DirectAbstractDeclaratorContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_directAbstractDeclarator);
						State = 822;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 823;
						Match(LeftBracket);
						State = 824;
						Match(Static);
						State = 826;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Const) | (1L << Restrict) | (1L << Volatile) | (1L << Atomic))) != 0)) {
							{
							State = 825;
							typeQualifierList();
							}
						}

						State = 828;
						assignmentExpression();
						State = 829;
						Match(RightBracket);
						}
						break;
					case 3:
						{
						_localctx = new DirectAbstractDeclaratorContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_directAbstractDeclarator);
						State = 831;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 832;
						Match(LeftBracket);
						State = 833;
						typeQualifierList();
						State = 834;
						Match(Static);
						State = 835;
						assignmentExpression();
						State = 836;
						Match(RightBracket);
						}
						break;
					case 4:
						{
						_localctx = new DirectAbstractDeclaratorContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_directAbstractDeclarator);
						State = 838;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 839;
						Match(LeftBracket);
						State = 840;
						Match(Star);
						State = 841;
						Match(RightBracket);
						}
						break;
					case 5:
						{
						_localctx = new DirectAbstractDeclaratorContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_directAbstractDeclarator);
						State = 842;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 843;
						Match(LeftParen);
						State = 845;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__16) | (1L << Auto) | (1L << Char) | (1L << Const) | (1L << Double) | (1L << Enum) | (1L << Extern) | (1L << Float) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Register) | (1L << Restrict) | (1L << Short) | (1L << Signed) | (1L << Static) | (1L << Struct) | (1L << Typedef) | (1L << Union) | (1L << Unsigned) | (1L << Void) | (1L << Volatile) | (1L << Alignas) | (1L << Atomic) | (1L << Bool) | (1L << Complex) | (1L << Noreturn) | (1L << ThreadLocal))) != 0) || _la==Identifier) {
							{
							State = 844;
							parameterTypeList();
							}
						}

						State = 847;
						Match(RightParen);
						State = 851;
						ErrorHandler.Sync(this);
						_alt = Interpreter.AdaptivePredict(TokenStream,95,Context);
						while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
							if ( _alt==1 ) {
								{
								{
								State = 848;
								gccDeclaratorExtension();
								}
								} 
							}
							State = 853;
							ErrorHandler.Sync(this);
							_alt = Interpreter.AdaptivePredict(TokenStream,95,Context);
						}
						}
						break;
					}
					} 
				}
				State = 858;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,97,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class TypedefNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CParser.Identifier, 0); }
		public TypedefNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typedefName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterTypedefName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitTypedefName(this);
		}
	}

	[RuleVersion(0)]
	public TypedefNameContext typedefName() {
		TypedefNameContext _localctx = new TypedefNameContext(Context, State);
		EnterRule(_localctx, 128, RULE_typedefName);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 859;
			Match(Identifier);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InitializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentExpressionContext assignmentExpression() {
			return GetRuleContext<AssignmentExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBrace() { return GetToken(CParser.LeftBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InitializerListContext initializerList() {
			return GetRuleContext<InitializerListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBrace() { return GetToken(CParser.RightBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CParser.Comma, 0); }
		public InitializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_initializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterInitializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitInitializer(this);
		}
	}

	[RuleVersion(0)]
	public InitializerContext initializer() {
		InitializerContext _localctx = new InitializerContext(Context, State);
		EnterRule(_localctx, 130, RULE_initializer);
		int _la;
		try {
			State = 869;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__0:
			case T__1:
			case T__2:
			case Sizeof:
			case Alignof:
			case Generic:
			case LeftParen:
			case Plus:
			case PlusPlus:
			case Minus:
			case MinusMinus:
			case Star:
			case And:
			case AndAnd:
			case Not:
			case Tilde:
			case Identifier:
			case Constant:
			case DigitSequence:
			case StringLiteral:
				EnterOuterAlt(_localctx, 1);
				{
				State = 861;
				assignmentExpression();
				}
				break;
			case LeftBrace:
				EnterOuterAlt(_localctx, 2);
				{
				State = 862;
				Match(LeftBrace);
				State = 863;
				initializerList();
				State = 865;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Comma) {
					{
					State = 864;
					Match(Comma);
					}
				}

				State = 867;
				Match(RightBrace);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InitializerListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public InitializerContext[] initializer() {
			return GetRuleContexts<InitializerContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public InitializerContext initializer(int i) {
			return GetRuleContext<InitializerContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DesignationContext[] designation() {
			return GetRuleContexts<DesignationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public DesignationContext designation(int i) {
			return GetRuleContext<DesignationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(CParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(CParser.Comma, i);
		}
		public InitializerListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_initializerList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterInitializerList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitInitializerList(this);
		}
	}

	[RuleVersion(0)]
	public InitializerListContext initializerList() {
		InitializerListContext _localctx = new InitializerListContext(Context, State);
		EnterRule(_localctx, 132, RULE_initializerList);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 872;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LeftBracket || _la==Dot) {
				{
				State = 871;
				designation();
				}
			}

			State = 874;
			initializer();
			State = 882;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,102,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 875;
					Match(Comma);
					State = 877;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==LeftBracket || _la==Dot) {
						{
						State = 876;
						designation();
						}
					}

					State = 879;
					initializer();
					}
					} 
				}
				State = 884;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,102,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DesignationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DesignatorListContext designatorList() {
			return GetRuleContext<DesignatorListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Assign() { return GetToken(CParser.Assign, 0); }
		public DesignationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_designation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterDesignation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitDesignation(this);
		}
	}

	[RuleVersion(0)]
	public DesignationContext designation() {
		DesignationContext _localctx = new DesignationContext(Context, State);
		EnterRule(_localctx, 134, RULE_designation);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 885;
			designatorList();
			State = 886;
			Match(Assign);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DesignatorListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DesignatorContext[] designator() {
			return GetRuleContexts<DesignatorContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public DesignatorContext designator(int i) {
			return GetRuleContext<DesignatorContext>(i);
		}
		public DesignatorListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_designatorList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterDesignatorList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitDesignatorList(this);
		}
	}

	[RuleVersion(0)]
	public DesignatorListContext designatorList() {
		DesignatorListContext _localctx = new DesignatorListContext(Context, State);
		EnterRule(_localctx, 136, RULE_designatorList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 889;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 888;
				designator();
				}
				}
				State = 891;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==LeftBracket || _la==Dot );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DesignatorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBracket() { return GetToken(CParser.LeftBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantExpressionContext constantExpression() {
			return GetRuleContext<ConstantExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBracket() { return GetToken(CParser.RightBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Dot() { return GetToken(CParser.Dot, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CParser.Identifier, 0); }
		public DesignatorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_designator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterDesignator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitDesignator(this);
		}
	}

	[RuleVersion(0)]
	public DesignatorContext designator() {
		DesignatorContext _localctx = new DesignatorContext(Context, State);
		EnterRule(_localctx, 138, RULE_designator);
		try {
			State = 899;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case LeftBracket:
				EnterOuterAlt(_localctx, 1);
				{
				State = 893;
				Match(LeftBracket);
				State = 894;
				constantExpression();
				State = 895;
				Match(RightBracket);
				}
				break;
			case Dot:
				EnterOuterAlt(_localctx, 2);
				{
				State = 897;
				Match(Dot);
				State = 898;
				Match(Identifier);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StaticAssertDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode StaticAssert() { return GetToken(CParser.StaticAssert, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CParser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantExpressionContext constantExpression() {
			return GetRuleContext<ConstantExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CParser.Comma, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CParser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CParser.Semi, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] StringLiteral() { return GetTokens(CParser.StringLiteral); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode StringLiteral(int i) {
			return GetToken(CParser.StringLiteral, i);
		}
		public StaticAssertDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_staticAssertDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterStaticAssertDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitStaticAssertDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public StaticAssertDeclarationContext staticAssertDeclaration() {
		StaticAssertDeclarationContext _localctx = new StaticAssertDeclarationContext(Context, State);
		EnterRule(_localctx, 140, RULE_staticAssertDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 901;
			Match(StaticAssert);
			State = 902;
			Match(LeftParen);
			State = 903;
			constantExpression();
			State = 904;
			Match(Comma);
			State = 906;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 905;
				Match(StringLiteral);
				}
				}
				State = 908;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==StringLiteral );
			State = 910;
			Match(RightParen);
			State = 911;
			Match(Semi);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public LabeledStatementContext labeledStatement() {
			return GetRuleContext<LabeledStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CompoundStatementContext compoundStatement() {
			return GetRuleContext<CompoundStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionStatementContext expressionStatement() {
			return GetRuleContext<ExpressionStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SelectionStatementContext selectionStatement() {
			return GetRuleContext<SelectionStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IterationStatementContext iterationStatement() {
			return GetRuleContext<IterationStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public JumpStatementContext jumpStatement() {
			return GetRuleContext<JumpStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CParser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CParser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CParser.Semi, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Volatile() { return GetToken(CParser.Volatile, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public LogicalOrExpressionContext[] logicalOrExpression() {
			return GetRuleContexts<LogicalOrExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public LogicalOrExpressionContext logicalOrExpression(int i) {
			return GetRuleContext<LogicalOrExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Colon() { return GetTokens(CParser.Colon); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon(int i) {
			return GetToken(CParser.Colon, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(CParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(CParser.Comma, i);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 142, RULE_statement);
		int _la;
		try {
			State = 950;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,111,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 913;
				labeledStatement();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 914;
				compoundStatement();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 915;
				expressionStatement();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 916;
				selectionStatement();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 917;
				iterationStatement();
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 918;
				jumpStatement();
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 919;
				_la = TokenStream.LA(1);
				if ( !(_la==T__15 || _la==T__17) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 920;
				_la = TokenStream.LA(1);
				if ( !(_la==T__18 || _la==Volatile) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 921;
				Match(LeftParen);
				State = 930;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << Sizeof) | (1L << Alignof) | (1L << Generic))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (Plus - 64)) | (1L << (PlusPlus - 64)) | (1L << (Minus - 64)) | (1L << (MinusMinus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (AndAnd - 64)) | (1L << (Not - 64)) | (1L << (Tilde - 64)) | (1L << (Identifier - 64)) | (1L << (Constant - 64)) | (1L << (DigitSequence - 64)) | (1L << (StringLiteral - 64)))) != 0)) {
					{
					State = 922;
					logicalOrExpression();
					State = 927;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==Comma) {
						{
						{
						State = 923;
						Match(Comma);
						State = 924;
						logicalOrExpression();
						}
						}
						State = 929;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					}
				}

				State = 945;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==Colon) {
					{
					{
					State = 932;
					Match(Colon);
					State = 941;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << Sizeof) | (1L << Alignof) | (1L << Generic))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (Plus - 64)) | (1L << (PlusPlus - 64)) | (1L << (Minus - 64)) | (1L << (MinusMinus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (AndAnd - 64)) | (1L << (Not - 64)) | (1L << (Tilde - 64)) | (1L << (Identifier - 64)) | (1L << (Constant - 64)) | (1L << (DigitSequence - 64)) | (1L << (StringLiteral - 64)))) != 0)) {
						{
						State = 933;
						logicalOrExpression();
						State = 938;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						while (_la==Comma) {
							{
							{
							State = 934;
							Match(Comma);
							State = 935;
							logicalOrExpression();
							}
							}
							State = 940;
							ErrorHandler.Sync(this);
							_la = TokenStream.LA(1);
						}
						}
					}

					}
					}
					State = 947;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 948;
				Match(RightParen);
				State = 949;
				Match(Semi);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LabeledStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CParser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(CParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Case() { return GetToken(CParser.Case, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantExpressionContext constantExpression() {
			return GetRuleContext<ConstantExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Default() { return GetToken(CParser.Default, 0); }
		public LabeledStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_labeledStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterLabeledStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitLabeledStatement(this);
		}
	}

	[RuleVersion(0)]
	public LabeledStatementContext labeledStatement() {
		LabeledStatementContext _localctx = new LabeledStatementContext(Context, State);
		EnterRule(_localctx, 144, RULE_labeledStatement);
		try {
			State = 963;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Identifier:
				EnterOuterAlt(_localctx, 1);
				{
				State = 952;
				Match(Identifier);
				State = 953;
				Match(Colon);
				State = 954;
				statement();
				}
				break;
			case Case:
				EnterOuterAlt(_localctx, 2);
				{
				State = 955;
				Match(Case);
				State = 956;
				constantExpression();
				State = 957;
				Match(Colon);
				State = 958;
				statement();
				}
				break;
			case Default:
				EnterOuterAlt(_localctx, 3);
				{
				State = 960;
				Match(Default);
				State = 961;
				Match(Colon);
				State = 962;
				statement();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CompoundStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBrace() { return GetToken(CParser.LeftBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBrace() { return GetToken(CParser.RightBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockItemListContext blockItemList() {
			return GetRuleContext<BlockItemListContext>(0);
		}
		public CompoundStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compoundStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterCompoundStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitCompoundStatement(this);
		}
	}

	[RuleVersion(0)]
	public CompoundStatementContext compoundStatement() {
		CompoundStatementContext _localctx = new CompoundStatementContext(Context, State);
		EnterRule(_localctx, 146, RULE_compoundStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 965;
			Match(LeftBrace);
			State = 967;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__15) | (1L << T__16) | (1L << T__17) | (1L << Auto) | (1L << Break) | (1L << Case) | (1L << Char) | (1L << Const) | (1L << Continue) | (1L << Default) | (1L << Do) | (1L << Double) | (1L << Enum) | (1L << Extern) | (1L << Float) | (1L << For) | (1L << Goto) | (1L << If) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Register) | (1L << Restrict) | (1L << Return) | (1L << Short) | (1L << Signed) | (1L << Sizeof) | (1L << Static) | (1L << Struct) | (1L << Switch) | (1L << Typedef) | (1L << Union) | (1L << Unsigned) | (1L << Void) | (1L << Volatile) | (1L << While) | (1L << Alignas) | (1L << Alignof) | (1L << Atomic) | (1L << Bool) | (1L << Complex) | (1L << Generic) | (1L << Noreturn) | (1L << StaticAssert) | (1L << ThreadLocal))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (LeftBrace - 64)) | (1L << (Plus - 64)) | (1L << (PlusPlus - 64)) | (1L << (Minus - 64)) | (1L << (MinusMinus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (AndAnd - 64)) | (1L << (Not - 64)) | (1L << (Tilde - 64)) | (1L << (Semi - 64)) | (1L << (Identifier - 64)) | (1L << (Constant - 64)) | (1L << (DigitSequence - 64)) | (1L << (StringLiteral - 64)))) != 0)) {
				{
				State = 966;
				blockItemList();
				}
			}

			State = 969;
			Match(RightBrace);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BlockItemListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BlockItemContext[] blockItem() {
			return GetRuleContexts<BlockItemContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public BlockItemContext blockItem(int i) {
			return GetRuleContext<BlockItemContext>(i);
		}
		public BlockItemListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_blockItemList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterBlockItemList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitBlockItemList(this);
		}
	}

	[RuleVersion(0)]
	public BlockItemListContext blockItemList() {
		BlockItemListContext _localctx = new BlockItemListContext(Context, State);
		EnterRule(_localctx, 148, RULE_blockItemList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 972;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 971;
				blockItem();
				}
				}
				State = 974;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__15) | (1L << T__16) | (1L << T__17) | (1L << Auto) | (1L << Break) | (1L << Case) | (1L << Char) | (1L << Const) | (1L << Continue) | (1L << Default) | (1L << Do) | (1L << Double) | (1L << Enum) | (1L << Extern) | (1L << Float) | (1L << For) | (1L << Goto) | (1L << If) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Register) | (1L << Restrict) | (1L << Return) | (1L << Short) | (1L << Signed) | (1L << Sizeof) | (1L << Static) | (1L << Struct) | (1L << Switch) | (1L << Typedef) | (1L << Union) | (1L << Unsigned) | (1L << Void) | (1L << Volatile) | (1L << While) | (1L << Alignas) | (1L << Alignof) | (1L << Atomic) | (1L << Bool) | (1L << Complex) | (1L << Generic) | (1L << Noreturn) | (1L << StaticAssert) | (1L << ThreadLocal))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (LeftBrace - 64)) | (1L << (Plus - 64)) | (1L << (PlusPlus - 64)) | (1L << (Minus - 64)) | (1L << (MinusMinus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (AndAnd - 64)) | (1L << (Not - 64)) | (1L << (Tilde - 64)) | (1L << (Semi - 64)) | (1L << (Identifier - 64)) | (1L << (Constant - 64)) | (1L << (DigitSequence - 64)) | (1L << (StringLiteral - 64)))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BlockItemContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationContext declaration() {
			return GetRuleContext<DeclarationContext>(0);
		}
		public BlockItemContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_blockItem; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterBlockItem(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitBlockItem(this);
		}
	}

	[RuleVersion(0)]
	public BlockItemContext blockItem() {
		BlockItemContext _localctx = new BlockItemContext(Context, State);
		EnterRule(_localctx, 150, RULE_blockItem);
		try {
			State = 978;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,115,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 976;
				statement();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 977;
				declaration();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CParser.Semi, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ExpressionStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expressionStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterExpressionStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitExpressionStatement(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionStatementContext expressionStatement() {
		ExpressionStatementContext _localctx = new ExpressionStatementContext(Context, State);
		EnterRule(_localctx, 152, RULE_expressionStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 981;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << Sizeof) | (1L << Alignof) | (1L << Generic))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (Plus - 64)) | (1L << (PlusPlus - 64)) | (1L << (Minus - 64)) | (1L << (MinusMinus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (AndAnd - 64)) | (1L << (Not - 64)) | (1L << (Tilde - 64)) | (1L << (Identifier - 64)) | (1L << (Constant - 64)) | (1L << (DigitSequence - 64)) | (1L << (StringLiteral - 64)))) != 0)) {
				{
				State = 980;
				expression();
				}
			}

			State = 983;
			Match(Semi);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SelectionStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode If() { return GetToken(CParser.If, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CParser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CParser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Else() { return GetToken(CParser.Else, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Switch() { return GetToken(CParser.Switch, 0); }
		public SelectionStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_selectionStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterSelectionStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitSelectionStatement(this);
		}
	}

	[RuleVersion(0)]
	public SelectionStatementContext selectionStatement() {
		SelectionStatementContext _localctx = new SelectionStatementContext(Context, State);
		EnterRule(_localctx, 154, RULE_selectionStatement);
		try {
			State = 1000;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case If:
				EnterOuterAlt(_localctx, 1);
				{
				State = 985;
				Match(If);
				State = 986;
				Match(LeftParen);
				State = 987;
				expression();
				State = 988;
				Match(RightParen);
				State = 989;
				statement();
				State = 992;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,117,Context) ) {
				case 1:
					{
					State = 990;
					Match(Else);
					State = 991;
					statement();
					}
					break;
				}
				}
				break;
			case Switch:
				EnterOuterAlt(_localctx, 2);
				{
				State = 994;
				Match(Switch);
				State = 995;
				Match(LeftParen);
				State = 996;
				expression();
				State = 997;
				Match(RightParen);
				State = 998;
				statement();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IterationStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode While() { return GetToken(CParser.While, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CParser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CParser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Do() { return GetToken(CParser.Do, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CParser.Semi, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode For() { return GetToken(CParser.For, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ForConditionContext forCondition() {
			return GetRuleContext<ForConditionContext>(0);
		}
		public IterationStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_iterationStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterIterationStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitIterationStatement(this);
		}
	}

	[RuleVersion(0)]
	public IterationStatementContext iterationStatement() {
		IterationStatementContext _localctx = new IterationStatementContext(Context, State);
		EnterRule(_localctx, 156, RULE_iterationStatement);
		try {
			State = 1022;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case While:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1002;
				Match(While);
				State = 1003;
				Match(LeftParen);
				State = 1004;
				expression();
				State = 1005;
				Match(RightParen);
				State = 1006;
				statement();
				}
				break;
			case Do:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1008;
				Match(Do);
				State = 1009;
				statement();
				State = 1010;
				Match(While);
				State = 1011;
				Match(LeftParen);
				State = 1012;
				expression();
				State = 1013;
				Match(RightParen);
				State = 1014;
				Match(Semi);
				}
				break;
			case For:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1016;
				Match(For);
				State = 1017;
				Match(LeftParen);
				State = 1018;
				forCondition();
				State = 1019;
				Match(RightParen);
				State = 1020;
				statement();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ForConditionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Semi() { return GetTokens(CParser.Semi); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi(int i) {
			return GetToken(CParser.Semi, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ForDeclarationContext forDeclaration() {
			return GetRuleContext<ForDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ForExpressionContext[] forExpression() {
			return GetRuleContexts<ForExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ForExpressionContext forExpression(int i) {
			return GetRuleContext<ForExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ForConditionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_forCondition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterForCondition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitForCondition(this);
		}
	}

	[RuleVersion(0)]
	public ForConditionContext forCondition() {
		ForConditionContext _localctx = new ForConditionContext(Context, State);
		EnterRule(_localctx, 158, RULE_forCondition);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1028;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,121,Context) ) {
			case 1:
				{
				State = 1024;
				forDeclaration();
				}
				break;
			case 2:
				{
				State = 1026;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << Sizeof) | (1L << Alignof) | (1L << Generic))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (Plus - 64)) | (1L << (PlusPlus - 64)) | (1L << (Minus - 64)) | (1L << (MinusMinus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (AndAnd - 64)) | (1L << (Not - 64)) | (1L << (Tilde - 64)) | (1L << (Identifier - 64)) | (1L << (Constant - 64)) | (1L << (DigitSequence - 64)) | (1L << (StringLiteral - 64)))) != 0)) {
					{
					State = 1025;
					expression();
					}
				}

				}
				break;
			}
			State = 1030;
			Match(Semi);
			State = 1032;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << Sizeof) | (1L << Alignof) | (1L << Generic))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (Plus - 64)) | (1L << (PlusPlus - 64)) | (1L << (Minus - 64)) | (1L << (MinusMinus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (AndAnd - 64)) | (1L << (Not - 64)) | (1L << (Tilde - 64)) | (1L << (Identifier - 64)) | (1L << (Constant - 64)) | (1L << (DigitSequence - 64)) | (1L << (StringLiteral - 64)))) != 0)) {
				{
				State = 1031;
				forExpression();
				}
			}

			State = 1034;
			Match(Semi);
			State = 1036;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << Sizeof) | (1L << Alignof) | (1L << Generic))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (Plus - 64)) | (1L << (PlusPlus - 64)) | (1L << (Minus - 64)) | (1L << (MinusMinus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (AndAnd - 64)) | (1L << (Not - 64)) | (1L << (Tilde - 64)) | (1L << (Identifier - 64)) | (1L << (Constant - 64)) | (1L << (DigitSequence - 64)) | (1L << (StringLiteral - 64)))) != 0)) {
				{
				State = 1035;
				forExpression();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ForDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationSpecifiersContext declarationSpecifiers() {
			return GetRuleContext<DeclarationSpecifiersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InitDeclaratorListContext initDeclaratorList() {
			return GetRuleContext<InitDeclaratorListContext>(0);
		}
		public ForDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_forDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterForDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitForDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public ForDeclarationContext forDeclaration() {
		ForDeclarationContext _localctx = new ForDeclarationContext(Context, State);
		EnterRule(_localctx, 160, RULE_forDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1038;
			declarationSpecifiers();
			State = 1040;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__8) | (1L << T__10) | (1L << T__11) | (1L << T__12) | (1L << T__13) | (1L << T__14))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (Star - 64)) | (1L << (Caret - 64)) | (1L << (Identifier - 64)))) != 0)) {
				{
				State = 1039;
				initDeclaratorList();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ForExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentExpressionContext[] assignmentExpression() {
			return GetRuleContexts<AssignmentExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentExpressionContext assignmentExpression(int i) {
			return GetRuleContext<AssignmentExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(CParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(CParser.Comma, i);
		}
		public ForExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_forExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterForExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitForExpression(this);
		}
	}

	[RuleVersion(0)]
	public ForExpressionContext forExpression() {
		ForExpressionContext _localctx = new ForExpressionContext(Context, State);
		EnterRule(_localctx, 162, RULE_forExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1042;
			assignmentExpression();
			State = 1047;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 1043;
				Match(Comma);
				State = 1044;
				assignmentExpression();
				}
				}
				State = 1049;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class JumpStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CParser.Semi, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Goto() { return GetToken(CParser.Goto, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CParser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Return() { return GetToken(CParser.Return, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public UnaryExpressionContext unaryExpression() {
			return GetRuleContext<UnaryExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Continue() { return GetToken(CParser.Continue, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Break() { return GetToken(CParser.Break, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public JumpStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_jumpStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterJumpStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitJumpStatement(this);
		}
	}

	[RuleVersion(0)]
	public JumpStatementContext jumpStatement() {
		JumpStatementContext _localctx = new JumpStatementContext(Context, State);
		EnterRule(_localctx, 164, RULE_jumpStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1059;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,127,Context) ) {
			case 1:
				{
				State = 1050;
				Match(Goto);
				State = 1051;
				Match(Identifier);
				}
				break;
			case 2:
				{
				State = 1052;
				_la = TokenStream.LA(1);
				if ( !(_la==Break || _la==Continue) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
				break;
			case 3:
				{
				State = 1053;
				Match(Return);
				State = 1055;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << Sizeof) | (1L << Alignof) | (1L << Generic))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (Plus - 64)) | (1L << (PlusPlus - 64)) | (1L << (Minus - 64)) | (1L << (MinusMinus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (AndAnd - 64)) | (1L << (Not - 64)) | (1L << (Tilde - 64)) | (1L << (Identifier - 64)) | (1L << (Constant - 64)) | (1L << (DigitSequence - 64)) | (1L << (StringLiteral - 64)))) != 0)) {
					{
					State = 1054;
					expression();
					}
				}

				}
				break;
			case 4:
				{
				State = 1057;
				Match(Goto);
				State = 1058;
				unaryExpression();
				}
				break;
			}
			State = 1061;
			Match(Semi);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CompilationUnitContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(CParser.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TranslationUnitContext translationUnit() {
			return GetRuleContext<TranslationUnitContext>(0);
		}
		public CompilationUnitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compilationUnit; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterCompilationUnit(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitCompilationUnit(this);
		}
	}

	[RuleVersion(0)]
	public CompilationUnitContext compilationUnit() {
		CompilationUnitContext _localctx = new CompilationUnitContext(Context, State);
		EnterRule(_localctx, 166, RULE_compilationUnit);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1064;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__10) | (1L << T__11) | (1L << T__12) | (1L << T__13) | (1L << T__14) | (1L << T__16) | (1L << Auto) | (1L << Char) | (1L << Const) | (1L << Double) | (1L << Enum) | (1L << Extern) | (1L << Float) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Register) | (1L << Restrict) | (1L << Short) | (1L << Signed) | (1L << Static) | (1L << Struct) | (1L << Typedef) | (1L << Union) | (1L << Unsigned) | (1L << Void) | (1L << Volatile) | (1L << Alignas) | (1L << Atomic) | (1L << Bool) | (1L << Complex) | (1L << Noreturn) | (1L << StaticAssert) | (1L << ThreadLocal))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (Star - 64)) | (1L << (Caret - 64)) | (1L << (Semi - 64)) | (1L << (Identifier - 64)))) != 0)) {
				{
				State = 1063;
				translationUnit();
				}
			}

			State = 1066;
			Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TranslationUnitContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExternalDeclarationContext[] externalDeclaration() {
			return GetRuleContexts<ExternalDeclarationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExternalDeclarationContext externalDeclaration(int i) {
			return GetRuleContext<ExternalDeclarationContext>(i);
		}
		public TranslationUnitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_translationUnit; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterTranslationUnit(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitTranslationUnit(this);
		}
	}

	[RuleVersion(0)]
	public TranslationUnitContext translationUnit() {
		TranslationUnitContext _localctx = new TranslationUnitContext(Context, State);
		EnterRule(_localctx, 168, RULE_translationUnit);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1069;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 1068;
				externalDeclaration();
				}
				}
				State = 1071;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__10) | (1L << T__11) | (1L << T__12) | (1L << T__13) | (1L << T__14) | (1L << T__16) | (1L << Auto) | (1L << Char) | (1L << Const) | (1L << Double) | (1L << Enum) | (1L << Extern) | (1L << Float) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Register) | (1L << Restrict) | (1L << Short) | (1L << Signed) | (1L << Static) | (1L << Struct) | (1L << Typedef) | (1L << Union) | (1L << Unsigned) | (1L << Void) | (1L << Volatile) | (1L << Alignas) | (1L << Atomic) | (1L << Bool) | (1L << Complex) | (1L << Noreturn) | (1L << StaticAssert) | (1L << ThreadLocal))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (LeftParen - 64)) | (1L << (Star - 64)) | (1L << (Caret - 64)) | (1L << (Semi - 64)) | (1L << (Identifier - 64)))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExternalDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public FunctionDefinitionContext functionDefinition() {
			return GetRuleContext<FunctionDefinitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationContext declaration() {
			return GetRuleContext<DeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CParser.Semi, 0); }
		public ExternalDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_externalDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterExternalDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitExternalDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public ExternalDeclarationContext externalDeclaration() {
		ExternalDeclarationContext _localctx = new ExternalDeclarationContext(Context, State);
		EnterRule(_localctx, 170, RULE_externalDeclaration);
		try {
			State = 1076;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,130,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1073;
				functionDefinition();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1074;
				declaration();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1075;
				Match(Semi);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FunctionDefinitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclaratorContext declarator() {
			return GetRuleContext<DeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CompoundStatementContext compoundStatement() {
			return GetRuleContext<CompoundStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationSpecifiersContext declarationSpecifiers() {
			return GetRuleContext<DeclarationSpecifiersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationListContext declarationList() {
			return GetRuleContext<DeclarationListContext>(0);
		}
		public FunctionDefinitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_functionDefinition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterFunctionDefinition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitFunctionDefinition(this);
		}
	}

	[RuleVersion(0)]
	public FunctionDefinitionContext functionDefinition() {
		FunctionDefinitionContext _localctx = new FunctionDefinitionContext(Context, State);
		EnterRule(_localctx, 172, RULE_functionDefinition);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1079;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,131,Context) ) {
			case 1:
				{
				State = 1078;
				declarationSpecifiers();
				}
				break;
			}
			State = 1081;
			declarator();
			State = 1083;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__16) | (1L << Auto) | (1L << Char) | (1L << Const) | (1L << Double) | (1L << Enum) | (1L << Extern) | (1L << Float) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Register) | (1L << Restrict) | (1L << Short) | (1L << Signed) | (1L << Static) | (1L << Struct) | (1L << Typedef) | (1L << Union) | (1L << Unsigned) | (1L << Void) | (1L << Volatile) | (1L << Alignas) | (1L << Atomic) | (1L << Bool) | (1L << Complex) | (1L << Noreturn) | (1L << StaticAssert) | (1L << ThreadLocal))) != 0) || _la==Identifier) {
				{
				State = 1082;
				declarationList();
				}
			}

			State = 1085;
			compoundStatement();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DeclarationListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationContext[] declaration() {
			return GetRuleContexts<DeclarationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationContext declaration(int i) {
			return GetRuleContext<DeclarationContext>(i);
		}
		public DeclarationListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declarationList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.EnterDeclarationList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICListener typedListener = listener as ICListener;
			if (typedListener != null) typedListener.ExitDeclarationList(this);
		}
	}

	[RuleVersion(0)]
	public DeclarationListContext declarationList() {
		DeclarationListContext _localctx = new DeclarationListContext(Context, State);
		EnterRule(_localctx, 174, RULE_declarationList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1088;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 1087;
				declaration();
				}
				}
				State = 1090;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__16) | (1L << Auto) | (1L << Char) | (1L << Const) | (1L << Double) | (1L << Enum) | (1L << Extern) | (1L << Float) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Register) | (1L << Restrict) | (1L << Short) | (1L << Signed) | (1L << Static) | (1L << Struct) | (1L << Typedef) | (1L << Union) | (1L << Unsigned) | (1L << Void) | (1L << Volatile) | (1L << Alignas) | (1L << Atomic) | (1L << Bool) | (1L << Complex) | (1L << Noreturn) | (1L << StaticAssert) | (1L << ThreadLocal))) != 0) || _la==Identifier );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 48: return directDeclarator_sempred((DirectDeclaratorContext)_localctx, predIndex);
		case 63: return directAbstractDeclarator_sempred((DirectAbstractDeclaratorContext)_localctx, predIndex);
		}
		return true;
	}
	private bool directDeclarator_sempred(DirectDeclaratorContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 9);
		case 1: return Precpred(Context, 8);
		case 2: return Precpred(Context, 7);
		case 3: return Precpred(Context, 6);
		case 4: return Precpred(Context, 5);
		case 5: return Precpred(Context, 4);
		}
		return true;
	}
	private bool directAbstractDeclarator_sempred(DirectAbstractDeclaratorContext _localctx, int predIndex) {
		switch (predIndex) {
		case 6: return Precpred(Context, 5);
		case 7: return Precpred(Context, 4);
		case 8: return Precpred(Context, 3);
		case 9: return Precpred(Context, 2);
		case 10: return Precpred(Context, 1);
		}
		return true;
	}

	private static int[] _serializedATN = {
		4,1,123,1093,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,
		7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,7,14,
		2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,7,21,
		2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,7,28,
		2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,7,35,
		2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,7,42,
		2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,7,49,
		2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,2,56,7,56,
		2,57,7,57,2,58,7,58,2,59,7,59,2,60,7,60,2,61,7,61,2,62,7,62,2,63,7,63,
		2,64,7,64,2,65,7,65,2,66,7,66,2,67,7,67,2,68,7,68,2,69,7,69,2,70,7,70,
		2,71,7,71,2,72,7,72,2,73,7,73,2,74,7,74,2,75,7,75,2,76,7,76,2,77,7,77,
		2,78,7,78,2,79,7,79,2,80,7,80,2,81,7,81,2,82,7,82,2,83,7,83,2,84,7,84,
		2,85,7,85,2,86,7,86,2,87,7,87,1,0,1,0,1,0,4,0,180,8,0,11,0,12,0,181,1,
		0,1,0,1,0,1,0,1,0,1,0,3,0,190,8,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,
		1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,3,0,210,8,0,1,1,1,1,1,1,1,1,1,1,1,
		1,1,1,1,2,1,2,1,2,5,2,222,8,2,10,2,12,2,225,9,2,1,3,1,3,3,3,229,8,3,1,
		3,1,3,1,3,1,4,1,4,3,4,236,8,4,1,4,1,4,1,4,1,4,1,4,1,4,3,4,244,8,4,1,4,
		1,4,3,4,248,8,4,1,4,1,4,1,4,1,4,1,4,1,4,3,4,256,8,4,1,4,1,4,1,4,1,4,5,
		4,262,8,4,10,4,12,4,265,9,4,1,5,1,5,1,5,5,5,270,8,5,10,5,12,5,273,9,5,
		1,6,5,6,276,8,6,10,6,12,6,279,9,6,1,6,1,6,1,6,1,6,1,6,1,6,1,6,1,6,1,6,
		1,6,1,6,3,6,292,8,6,1,7,1,7,1,8,3,8,297,8,8,1,8,1,8,1,8,1,8,1,8,1,8,1,
		8,3,8,306,8,8,1,9,1,9,1,9,5,9,311,8,9,10,9,12,9,314,9,9,1,10,1,10,1,10,
		5,10,319,8,10,10,10,12,10,322,9,10,1,11,1,11,1,11,5,11,327,8,11,10,11,
		12,11,330,9,11,1,12,1,12,1,12,5,12,335,8,12,10,12,12,12,338,9,12,1,13,
		1,13,1,13,5,13,343,8,13,10,13,12,13,346,9,13,1,14,1,14,1,14,5,14,351,8,
		14,10,14,12,14,354,9,14,1,15,1,15,1,15,5,15,359,8,15,10,15,12,15,362,9,
		15,1,16,1,16,1,16,5,16,367,8,16,10,16,12,16,370,9,16,1,17,1,17,1,17,5,
		17,375,8,17,10,17,12,17,378,9,17,1,18,1,18,1,18,5,18,383,8,18,10,18,12,
		18,386,9,18,1,19,1,19,1,19,1,19,1,19,1,19,3,19,394,8,19,1,20,1,20,1,20,
		1,20,1,20,1,20,3,20,402,8,20,1,21,1,21,1,22,1,22,1,22,5,22,409,8,22,10,
		22,12,22,412,9,22,1,23,1,23,1,24,1,24,3,24,418,8,24,1,24,1,24,1,24,3,24,
		423,8,24,1,25,4,25,426,8,25,11,25,12,25,427,1,26,4,26,431,8,26,11,26,12,
		26,432,1,27,1,27,1,27,1,27,1,27,3,27,440,8,27,1,28,1,28,1,28,5,28,445,
		8,28,10,28,12,28,448,9,28,1,29,1,29,1,29,3,29,453,8,29,1,30,1,30,1,31,
		1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,3,31,
		471,8,31,1,32,1,32,3,32,475,8,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,3,
		32,484,8,32,1,33,1,33,1,34,4,34,489,8,34,11,34,12,34,490,1,35,1,35,1,35,
		1,35,1,35,1,35,1,35,1,35,3,35,501,8,35,1,36,1,36,3,36,505,8,36,1,36,3,
		36,508,8,36,1,37,1,37,1,37,5,37,513,8,37,10,37,12,37,516,9,37,1,38,1,38,
		3,38,520,8,38,1,38,1,38,3,38,524,8,38,1,39,1,39,3,39,528,8,39,1,39,1,39,
		1,39,3,39,533,8,39,1,39,1,39,1,39,1,39,3,39,539,8,39,1,40,1,40,1,40,5,
		40,544,8,40,10,40,12,40,547,9,40,1,41,1,41,1,41,3,41,552,8,41,1,42,1,42,
		1,43,1,43,1,43,1,43,1,43,1,44,1,44,1,45,1,45,1,45,1,45,1,45,1,45,3,45,
		569,8,45,1,46,1,46,1,46,1,46,3,46,575,8,46,1,46,1,46,1,47,3,47,580,8,47,
		1,47,1,47,5,47,584,8,47,10,47,12,47,587,9,47,1,48,1,48,1,48,1,48,1,48,
		1,48,1,48,1,48,1,48,1,48,1,48,1,48,1,48,1,48,1,48,1,48,1,48,3,48,606,8,
		48,1,48,1,48,1,48,3,48,611,8,48,1,48,3,48,614,8,48,1,48,1,48,1,48,1,48,
		1,48,3,48,621,8,48,1,48,1,48,1,48,1,48,1,48,1,48,1,48,1,48,1,48,1,48,1,
		48,1,48,1,48,3,48,636,8,48,1,48,1,48,1,48,1,48,1,48,1,48,1,48,1,48,1,48,
		1,48,3,48,648,8,48,1,48,5,48,651,8,48,10,48,12,48,654,9,48,1,49,1,49,1,
		50,1,50,1,50,4,50,661,8,50,11,50,12,50,662,1,50,1,50,3,50,667,8,50,1,51,
		1,51,1,51,1,51,1,51,1,51,1,51,1,52,3,52,677,8,52,1,52,1,52,3,52,681,8,
		52,5,52,683,8,52,10,52,12,52,686,9,52,1,53,1,53,1,53,3,53,691,8,53,1,53,
		3,53,694,8,53,1,54,1,54,1,54,1,54,1,54,5,54,701,8,54,10,54,12,54,704,9,
		54,1,55,1,55,3,55,708,8,55,4,55,710,8,55,11,55,12,55,711,1,56,4,56,715,
		8,56,11,56,12,56,716,1,57,1,57,1,57,3,57,722,8,57,1,58,1,58,1,58,5,58,
		727,8,58,10,58,12,58,730,9,58,1,59,1,59,1,59,1,59,1,59,3,59,737,8,59,3,
		59,739,8,59,1,60,1,60,1,60,5,60,744,8,60,10,60,12,60,747,9,60,1,61,1,61,
		3,61,751,8,61,1,62,1,62,3,62,755,8,62,1,62,1,62,5,62,759,8,62,10,62,12,
		62,762,9,62,3,62,764,8,62,1,63,1,63,1,63,1,63,1,63,5,63,771,8,63,10,63,
		12,63,774,9,63,1,63,1,63,3,63,778,8,63,1,63,3,63,781,8,63,1,63,1,63,1,
		63,1,63,3,63,787,8,63,1,63,1,63,1,63,1,63,1,63,1,63,1,63,1,63,1,63,1,63,
		1,63,1,63,1,63,1,63,3,63,803,8,63,1,63,1,63,5,63,807,8,63,10,63,12,63,
		810,9,63,3,63,812,8,63,1,63,1,63,1,63,3,63,817,8,63,1,63,3,63,820,8,63,
		1,63,1,63,1,63,1,63,1,63,3,63,827,8,63,1,63,1,63,1,63,1,63,1,63,1,63,1,
		63,1,63,1,63,1,63,1,63,1,63,1,63,1,63,1,63,1,63,1,63,3,63,846,8,63,1,63,
		1,63,5,63,850,8,63,10,63,12,63,853,9,63,5,63,855,8,63,10,63,12,63,858,
		9,63,1,64,1,64,1,65,1,65,1,65,1,65,3,65,866,8,65,1,65,1,65,3,65,870,8,
		65,1,66,3,66,873,8,66,1,66,1,66,1,66,3,66,878,8,66,1,66,5,66,881,8,66,
		10,66,12,66,884,9,66,1,67,1,67,1,67,1,68,4,68,890,8,68,11,68,12,68,891,
		1,69,1,69,1,69,1,69,1,69,1,69,3,69,900,8,69,1,70,1,70,1,70,1,70,1,70,4,
		70,907,8,70,11,70,12,70,908,1,70,1,70,1,70,1,71,1,71,1,71,1,71,1,71,1,
		71,1,71,1,71,1,71,1,71,1,71,1,71,5,71,926,8,71,10,71,12,71,929,9,71,3,
		71,931,8,71,1,71,1,71,1,71,1,71,5,71,937,8,71,10,71,12,71,940,9,71,3,71,
		942,8,71,5,71,944,8,71,10,71,12,71,947,9,71,1,71,1,71,3,71,951,8,71,1,
		72,1,72,1,72,1,72,1,72,1,72,1,72,1,72,1,72,1,72,1,72,3,72,964,8,72,1,73,
		1,73,3,73,968,8,73,1,73,1,73,1,74,4,74,973,8,74,11,74,12,74,974,1,75,1,
		75,3,75,979,8,75,1,76,3,76,982,8,76,1,76,1,76,1,77,1,77,1,77,1,77,1,77,
		1,77,1,77,3,77,993,8,77,1,77,1,77,1,77,1,77,1,77,1,77,3,77,1001,8,77,1,
		78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,
		78,1,78,1,78,1,78,1,78,1,78,3,78,1023,8,78,1,79,1,79,3,79,1027,8,79,3,
		79,1029,8,79,1,79,1,79,3,79,1033,8,79,1,79,1,79,3,79,1037,8,79,1,80,1,
		80,3,80,1041,8,80,1,81,1,81,1,81,5,81,1046,8,81,10,81,12,81,1049,9,81,
		1,82,1,82,1,82,1,82,1,82,3,82,1056,8,82,1,82,1,82,3,82,1060,8,82,1,82,
		1,82,1,83,3,83,1065,8,83,1,83,1,83,1,84,4,84,1070,8,84,11,84,12,84,1071,
		1,85,1,85,1,85,3,85,1077,8,85,1,86,3,86,1080,8,86,1,86,1,86,3,86,1084,
		8,86,1,86,1,86,1,87,4,87,1089,8,87,11,87,12,87,1090,1,87,0,2,96,126,88,
		0,2,4,6,8,10,12,14,16,18,20,22,24,26,28,30,32,34,36,38,40,42,44,46,48,
		50,52,54,56,58,60,62,64,66,68,70,72,74,76,78,80,82,84,86,88,90,92,94,96,
		98,100,102,104,106,108,110,112,114,116,118,120,122,124,126,128,130,132,
		134,136,138,140,142,144,146,148,150,152,154,156,158,160,162,164,166,168,
		170,172,174,0,24,1,0,107,108,2,0,77,77,79,79,3,0,44,44,77,77,79,79,2,0,
		44,44,55,55,5,0,76,76,78,78,80,80,83,83,88,89,1,0,80,82,2,0,76,76,78,78,
		1,0,74,75,1,0,70,73,1,0,105,106,1,0,94,104,6,0,20,20,31,31,39,39,45,45,
		48,48,63,63,8,0,4,6,23,23,28,28,32,32,37,38,42,43,50,51,57,58,1,0,4,6,
		2,0,46,46,49,49,4,0,24,24,40,40,52,52,56,56,3,0,8,9,36,36,61,61,2,0,9,
		9,11,15,2,0,64,65,93,93,1,0,64,65,2,0,80,80,87,87,2,0,16,16,18,18,2,0,
		19,19,52,52,2,0,21,21,25,25,1184,0,209,1,0,0,0,2,211,1,0,0,0,4,218,1,0,
		0,0,6,228,1,0,0,0,8,247,1,0,0,0,10,266,1,0,0,0,12,277,1,0,0,0,14,293,1,
		0,0,0,16,305,1,0,0,0,18,307,1,0,0,0,20,315,1,0,0,0,22,323,1,0,0,0,24,331,
		1,0,0,0,26,339,1,0,0,0,28,347,1,0,0,0,30,355,1,0,0,0,32,363,1,0,0,0,34,
		371,1,0,0,0,36,379,1,0,0,0,38,387,1,0,0,0,40,401,1,0,0,0,42,403,1,0,0,
		0,44,405,1,0,0,0,46,413,1,0,0,0,48,422,1,0,0,0,50,425,1,0,0,0,52,430,1,
		0,0,0,54,439,1,0,0,0,56,441,1,0,0,0,58,449,1,0,0,0,60,454,1,0,0,0,62,470,
		1,0,0,0,64,483,1,0,0,0,66,485,1,0,0,0,68,488,1,0,0,0,70,500,1,0,0,0,72,
		504,1,0,0,0,74,509,1,0,0,0,76,523,1,0,0,0,78,538,1,0,0,0,80,540,1,0,0,
		0,82,548,1,0,0,0,84,553,1,0,0,0,86,555,1,0,0,0,88,560,1,0,0,0,90,568,1,
		0,0,0,92,570,1,0,0,0,94,579,1,0,0,0,96,605,1,0,0,0,98,655,1,0,0,0,100,
		666,1,0,0,0,102,668,1,0,0,0,104,676,1,0,0,0,106,687,1,0,0,0,108,702,1,
		0,0,0,110,709,1,0,0,0,112,714,1,0,0,0,114,718,1,0,0,0,116,723,1,0,0,0,
		118,738,1,0,0,0,120,740,1,0,0,0,122,748,1,0,0,0,124,763,1,0,0,0,126,811,
		1,0,0,0,128,859,1,0,0,0,130,869,1,0,0,0,132,872,1,0,0,0,134,885,1,0,0,
		0,136,889,1,0,0,0,138,899,1,0,0,0,140,901,1,0,0,0,142,950,1,0,0,0,144,
		963,1,0,0,0,146,965,1,0,0,0,148,972,1,0,0,0,150,978,1,0,0,0,152,981,1,
		0,0,0,154,1000,1,0,0,0,156,1022,1,0,0,0,158,1028,1,0,0,0,160,1038,1,0,
		0,0,162,1042,1,0,0,0,164,1059,1,0,0,0,166,1064,1,0,0,0,168,1069,1,0,0,
		0,170,1076,1,0,0,0,172,1079,1,0,0,0,174,1088,1,0,0,0,176,210,5,110,0,0,
		177,210,5,111,0,0,178,180,5,113,0,0,179,178,1,0,0,0,180,181,1,0,0,0,181,
		179,1,0,0,0,181,182,1,0,0,0,182,210,1,0,0,0,183,184,5,64,0,0,184,185,3,
		44,22,0,185,186,5,65,0,0,186,210,1,0,0,0,187,210,3,2,1,0,188,190,5,1,0,
		0,189,188,1,0,0,0,189,190,1,0,0,0,190,191,1,0,0,0,191,192,5,64,0,0,192,
		193,3,146,73,0,193,194,5,65,0,0,194,210,1,0,0,0,195,196,5,2,0,0,196,197,
		5,64,0,0,197,198,3,12,6,0,198,199,5,93,0,0,199,200,3,122,61,0,200,201,
		5,65,0,0,201,210,1,0,0,0,202,203,5,3,0,0,203,204,5,64,0,0,204,205,3,122,
		61,0,205,206,5,93,0,0,206,207,3,12,6,0,207,208,5,65,0,0,208,210,1,0,0,
		0,209,176,1,0,0,0,209,177,1,0,0,0,209,179,1,0,0,0,209,183,1,0,0,0,209,
		187,1,0,0,0,209,189,1,0,0,0,209,195,1,0,0,0,209,202,1,0,0,0,210,1,1,0,
		0,0,211,212,5,59,0,0,212,213,5,64,0,0,213,214,3,40,20,0,214,215,5,93,0,
		0,215,216,3,4,2,0,216,217,5,65,0,0,217,3,1,0,0,0,218,223,3,6,3,0,219,220,
		5,93,0,0,220,222,3,6,3,0,221,219,1,0,0,0,222,225,1,0,0,0,223,221,1,0,0,
		0,223,224,1,0,0,0,224,5,1,0,0,0,225,223,1,0,0,0,226,229,3,122,61,0,227,
		229,5,26,0,0,228,226,1,0,0,0,228,227,1,0,0,0,229,230,1,0,0,0,230,231,5,
		91,0,0,231,232,3,40,20,0,232,7,1,0,0,0,233,248,3,0,0,0,234,236,5,1,0,0,
		235,234,1,0,0,0,235,236,1,0,0,0,236,237,1,0,0,0,237,238,5,64,0,0,238,239,
		3,122,61,0,239,240,5,65,0,0,240,241,5,68,0,0,241,243,3,132,66,0,242,244,
		5,93,0,0,243,242,1,0,0,0,243,244,1,0,0,0,244,245,1,0,0,0,245,246,5,69,
		0,0,246,248,1,0,0,0,247,233,1,0,0,0,247,235,1,0,0,0,248,263,1,0,0,0,249,
		250,5,66,0,0,250,251,3,44,22,0,251,252,5,67,0,0,252,262,1,0,0,0,253,255,
		5,64,0,0,254,256,3,10,5,0,255,254,1,0,0,0,255,256,1,0,0,0,256,257,1,0,
		0,0,257,262,5,65,0,0,258,259,7,0,0,0,259,262,5,110,0,0,260,262,7,1,0,0,
		261,249,1,0,0,0,261,253,1,0,0,0,261,258,1,0,0,0,261,260,1,0,0,0,262,265,
		1,0,0,0,263,261,1,0,0,0,263,264,1,0,0,0,264,9,1,0,0,0,265,263,1,0,0,0,
		266,271,3,40,20,0,267,268,5,93,0,0,268,270,3,40,20,0,269,267,1,0,0,0,270,
		273,1,0,0,0,271,269,1,0,0,0,271,272,1,0,0,0,272,11,1,0,0,0,273,271,1,0,
		0,0,274,276,7,2,0,0,275,274,1,0,0,0,276,279,1,0,0,0,277,275,1,0,0,0,277,
		278,1,0,0,0,278,291,1,0,0,0,279,277,1,0,0,0,280,292,3,8,4,0,281,282,3,
		14,7,0,282,283,3,16,8,0,283,292,1,0,0,0,284,285,7,3,0,0,285,286,5,64,0,
		0,286,287,3,122,61,0,287,288,5,65,0,0,288,292,1,0,0,0,289,290,5,85,0,0,
		290,292,5,110,0,0,291,280,1,0,0,0,291,281,1,0,0,0,291,284,1,0,0,0,291,
		289,1,0,0,0,292,13,1,0,0,0,293,294,7,4,0,0,294,15,1,0,0,0,295,297,5,1,
		0,0,296,295,1,0,0,0,296,297,1,0,0,0,297,298,1,0,0,0,298,299,5,64,0,0,299,
		300,3,122,61,0,300,301,5,65,0,0,301,302,3,16,8,0,302,306,1,0,0,0,303,306,
		3,12,6,0,304,306,5,112,0,0,305,296,1,0,0,0,305,303,1,0,0,0,305,304,1,0,
		0,0,306,17,1,0,0,0,307,312,3,16,8,0,308,309,7,5,0,0,309,311,3,16,8,0,310,
		308,1,0,0,0,311,314,1,0,0,0,312,310,1,0,0,0,312,313,1,0,0,0,313,19,1,0,
		0,0,314,312,1,0,0,0,315,320,3,18,9,0,316,317,7,6,0,0,317,319,3,18,9,0,
		318,316,1,0,0,0,319,322,1,0,0,0,320,318,1,0,0,0,320,321,1,0,0,0,321,21,
		1,0,0,0,322,320,1,0,0,0,323,328,3,20,10,0,324,325,7,7,0,0,325,327,3,20,
		10,0,326,324,1,0,0,0,327,330,1,0,0,0,328,326,1,0,0,0,328,329,1,0,0,0,329,
		23,1,0,0,0,330,328,1,0,0,0,331,336,3,22,11,0,332,333,7,8,0,0,333,335,3,
		22,11,0,334,332,1,0,0,0,335,338,1,0,0,0,336,334,1,0,0,0,336,337,1,0,0,
		0,337,25,1,0,0,0,338,336,1,0,0,0,339,344,3,24,12,0,340,341,7,9,0,0,341,
		343,3,24,12,0,342,340,1,0,0,0,343,346,1,0,0,0,344,342,1,0,0,0,344,345,
		1,0,0,0,345,27,1,0,0,0,346,344,1,0,0,0,347,352,3,26,13,0,348,349,5,83,
		0,0,349,351,3,26,13,0,350,348,1,0,0,0,351,354,1,0,0,0,352,350,1,0,0,0,
		352,353,1,0,0,0,353,29,1,0,0,0,354,352,1,0,0,0,355,360,3,28,14,0,356,357,
		5,87,0,0,357,359,3,28,14,0,358,356,1,0,0,0,359,362,1,0,0,0,360,358,1,0,
		0,0,360,361,1,0,0,0,361,31,1,0,0,0,362,360,1,0,0,0,363,368,3,30,15,0,364,
		365,5,84,0,0,365,367,3,30,15,0,366,364,1,0,0,0,367,370,1,0,0,0,368,366,
		1,0,0,0,368,369,1,0,0,0,369,33,1,0,0,0,370,368,1,0,0,0,371,376,3,32,16,
		0,372,373,5,85,0,0,373,375,3,32,16,0,374,372,1,0,0,0,375,378,1,0,0,0,376,
		374,1,0,0,0,376,377,1,0,0,0,377,35,1,0,0,0,378,376,1,0,0,0,379,384,3,34,
		17,0,380,381,5,86,0,0,381,383,3,34,17,0,382,380,1,0,0,0,383,386,1,0,0,
		0,384,382,1,0,0,0,384,385,1,0,0,0,385,37,1,0,0,0,386,384,1,0,0,0,387,393,
		3,36,18,0,388,389,5,90,0,0,389,390,3,44,22,0,390,391,5,91,0,0,391,392,
		3,38,19,0,392,394,1,0,0,0,393,388,1,0,0,0,393,394,1,0,0,0,394,39,1,0,0,
		0,395,402,3,38,19,0,396,397,3,12,6,0,397,398,3,42,21,0,398,399,3,40,20,
		0,399,402,1,0,0,0,400,402,5,112,0,0,401,395,1,0,0,0,401,396,1,0,0,0,401,
		400,1,0,0,0,402,41,1,0,0,0,403,404,7,10,0,0,404,43,1,0,0,0,405,410,3,40,
		20,0,406,407,5,93,0,0,407,409,3,40,20,0,408,406,1,0,0,0,409,412,1,0,0,
		0,410,408,1,0,0,0,410,411,1,0,0,0,411,45,1,0,0,0,412,410,1,0,0,0,413,414,
		3,38,19,0,414,47,1,0,0,0,415,417,3,50,25,0,416,418,3,56,28,0,417,416,1,
		0,0,0,417,418,1,0,0,0,418,419,1,0,0,0,419,420,5,92,0,0,420,423,1,0,0,0,
		421,423,3,140,70,0,422,415,1,0,0,0,422,421,1,0,0,0,423,49,1,0,0,0,424,
		426,3,54,27,0,425,424,1,0,0,0,426,427,1,0,0,0,427,425,1,0,0,0,427,428,
		1,0,0,0,428,51,1,0,0,0,429,431,3,54,27,0,430,429,1,0,0,0,431,432,1,0,0,
		0,432,430,1,0,0,0,432,433,1,0,0,0,433,53,1,0,0,0,434,440,3,60,30,0,435,
		440,3,62,31,0,436,440,3,88,44,0,437,440,3,90,45,0,438,440,3,92,46,0,439,
		434,1,0,0,0,439,435,1,0,0,0,439,436,1,0,0,0,439,437,1,0,0,0,439,438,1,
		0,0,0,440,55,1,0,0,0,441,446,3,58,29,0,442,443,5,93,0,0,443,445,3,58,29,
		0,444,442,1,0,0,0,445,448,1,0,0,0,446,444,1,0,0,0,446,447,1,0,0,0,447,
		57,1,0,0,0,448,446,1,0,0,0,449,452,3,94,47,0,450,451,5,94,0,0,451,453,
		3,130,65,0,452,450,1,0,0,0,452,453,1,0,0,0,453,59,1,0,0,0,454,455,7,11,
		0,0,455,61,1,0,0,0,456,471,7,12,0,0,457,458,5,1,0,0,458,459,5,64,0,0,459,
		460,7,13,0,0,460,471,5,65,0,0,461,471,3,86,43,0,462,471,3,64,32,0,463,
		471,3,78,39,0,464,471,3,128,64,0,465,466,5,7,0,0,466,467,5,64,0,0,467,
		468,3,46,23,0,468,469,5,65,0,0,469,471,1,0,0,0,470,456,1,0,0,0,470,457,
		1,0,0,0,470,461,1,0,0,0,470,462,1,0,0,0,470,463,1,0,0,0,470,464,1,0,0,
		0,470,465,1,0,0,0,471,63,1,0,0,0,472,474,3,66,33,0,473,475,5,110,0,0,474,
		473,1,0,0,0,474,475,1,0,0,0,475,476,1,0,0,0,476,477,5,68,0,0,477,478,3,
		68,34,0,478,479,5,69,0,0,479,484,1,0,0,0,480,481,3,66,33,0,481,482,5,110,
		0,0,482,484,1,0,0,0,483,472,1,0,0,0,483,480,1,0,0,0,484,65,1,0,0,0,485,
		486,7,14,0,0,486,67,1,0,0,0,487,489,3,70,35,0,488,487,1,0,0,0,489,490,
		1,0,0,0,490,488,1,0,0,0,490,491,1,0,0,0,491,69,1,0,0,0,492,493,3,72,36,
		0,493,494,3,74,37,0,494,495,5,92,0,0,495,501,1,0,0,0,496,497,3,72,36,0,
		497,498,5,92,0,0,498,501,1,0,0,0,499,501,3,140,70,0,500,492,1,0,0,0,500,
		496,1,0,0,0,500,499,1,0,0,0,501,71,1,0,0,0,502,505,3,62,31,0,503,505,3,
		88,44,0,504,502,1,0,0,0,504,503,1,0,0,0,505,507,1,0,0,0,506,508,3,72,36,
		0,507,506,1,0,0,0,507,508,1,0,0,0,508,73,1,0,0,0,509,514,3,76,38,0,510,
		511,5,93,0,0,511,513,3,76,38,0,512,510,1,0,0,0,513,516,1,0,0,0,514,512,
		1,0,0,0,514,515,1,0,0,0,515,75,1,0,0,0,516,514,1,0,0,0,517,524,3,94,47,
		0,518,520,3,94,47,0,519,518,1,0,0,0,519,520,1,0,0,0,520,521,1,0,0,0,521,
		522,5,91,0,0,522,524,3,46,23,0,523,517,1,0,0,0,523,519,1,0,0,0,524,77,
		1,0,0,0,525,527,5,30,0,0,526,528,5,110,0,0,527,526,1,0,0,0,527,528,1,0,
		0,0,528,529,1,0,0,0,529,530,5,68,0,0,530,532,3,80,40,0,531,533,5,93,0,
		0,532,531,1,0,0,0,532,533,1,0,0,0,533,534,1,0,0,0,534,535,5,69,0,0,535,
		539,1,0,0,0,536,537,5,30,0,0,537,539,5,110,0,0,538,525,1,0,0,0,538,536,
		1,0,0,0,539,79,1,0,0,0,540,545,3,82,41,0,541,542,5,93,0,0,542,544,3,82,
		41,0,543,541,1,0,0,0,544,547,1,0,0,0,545,543,1,0,0,0,545,546,1,0,0,0,546,
		81,1,0,0,0,547,545,1,0,0,0,548,551,3,84,42,0,549,550,5,94,0,0,550,552,
		3,46,23,0,551,549,1,0,0,0,551,552,1,0,0,0,552,83,1,0,0,0,553,554,5,110,
		0,0,554,85,1,0,0,0,555,556,5,56,0,0,556,557,5,64,0,0,557,558,3,122,61,
		0,558,559,5,65,0,0,559,87,1,0,0,0,560,561,7,15,0,0,561,89,1,0,0,0,562,
		569,7,16,0,0,563,569,3,102,51,0,564,565,5,10,0,0,565,566,5,64,0,0,566,
		567,5,110,0,0,567,569,5,65,0,0,568,562,1,0,0,0,568,563,1,0,0,0,568,564,
		1,0,0,0,569,91,1,0,0,0,570,571,5,54,0,0,571,574,5,64,0,0,572,575,3,122,
		61,0,573,575,3,46,23,0,574,572,1,0,0,0,574,573,1,0,0,0,575,576,1,0,0,0,
		576,577,5,65,0,0,577,93,1,0,0,0,578,580,3,110,55,0,579,578,1,0,0,0,579,
		580,1,0,0,0,580,581,1,0,0,0,581,585,3,96,48,0,582,584,3,100,50,0,583,582,
		1,0,0,0,584,587,1,0,0,0,585,583,1,0,0,0,585,586,1,0,0,0,586,95,1,0,0,0,
		587,585,1,0,0,0,588,589,6,48,-1,0,589,606,5,110,0,0,590,591,5,64,0,0,591,
		592,3,94,47,0,592,593,5,65,0,0,593,606,1,0,0,0,594,595,5,110,0,0,595,596,
		5,91,0,0,596,606,5,112,0,0,597,598,3,98,49,0,598,599,5,110,0,0,599,606,
		1,0,0,0,600,601,5,64,0,0,601,602,3,98,49,0,602,603,3,94,47,0,603,604,5,
		65,0,0,604,606,1,0,0,0,605,588,1,0,0,0,605,590,1,0,0,0,605,594,1,0,0,0,
		605,597,1,0,0,0,605,600,1,0,0,0,606,652,1,0,0,0,607,608,10,9,0,0,608,610,
		5,66,0,0,609,611,3,112,56,0,610,609,1,0,0,0,610,611,1,0,0,0,611,613,1,
		0,0,0,612,614,3,40,20,0,613,612,1,0,0,0,613,614,1,0,0,0,614,615,1,0,0,
		0,615,651,5,67,0,0,616,617,10,8,0,0,617,618,5,66,0,0,618,620,5,45,0,0,
		619,621,3,112,56,0,620,619,1,0,0,0,620,621,1,0,0,0,621,622,1,0,0,0,622,
		623,3,40,20,0,623,624,5,67,0,0,624,651,1,0,0,0,625,626,10,7,0,0,626,627,
		5,66,0,0,627,628,3,112,56,0,628,629,5,45,0,0,629,630,3,40,20,0,630,631,
		5,67,0,0,631,651,1,0,0,0,632,633,10,6,0,0,633,635,5,66,0,0,634,636,3,112,
		56,0,635,634,1,0,0,0,635,636,1,0,0,0,636,637,1,0,0,0,637,638,5,80,0,0,
		638,651,5,67,0,0,639,640,10,5,0,0,640,641,5,64,0,0,641,642,3,114,57,0,
		642,643,5,65,0,0,643,651,1,0,0,0,644,645,10,4,0,0,645,647,5,64,0,0,646,
		648,3,120,60,0,647,646,1,0,0,0,647,648,1,0,0,0,648,649,1,0,0,0,649,651,
		5,65,0,0,650,607,1,0,0,0,650,616,1,0,0,0,650,625,1,0,0,0,650,632,1,0,0,
		0,650,639,1,0,0,0,650,644,1,0,0,0,651,654,1,0,0,0,652,650,1,0,0,0,652,
		653,1,0,0,0,653,97,1,0,0,0,654,652,1,0,0,0,655,656,7,17,0,0,656,99,1,0,
		0,0,657,658,5,16,0,0,658,660,5,64,0,0,659,661,5,113,0,0,660,659,1,0,0,
		0,661,662,1,0,0,0,662,660,1,0,0,0,662,663,1,0,0,0,663,664,1,0,0,0,664,
		667,5,65,0,0,665,667,3,102,51,0,666,657,1,0,0,0,666,665,1,0,0,0,667,101,
		1,0,0,0,668,669,5,17,0,0,669,670,5,64,0,0,670,671,5,64,0,0,671,672,3,104,
		52,0,672,673,5,65,0,0,673,674,5,65,0,0,674,103,1,0,0,0,675,677,3,106,53,
		0,676,675,1,0,0,0,676,677,1,0,0,0,677,684,1,0,0,0,678,680,5,93,0,0,679,
		681,3,106,53,0,680,679,1,0,0,0,680,681,1,0,0,0,681,683,1,0,0,0,682,678,
		1,0,0,0,683,686,1,0,0,0,684,682,1,0,0,0,684,685,1,0,0,0,685,105,1,0,0,
		0,686,684,1,0,0,0,687,693,8,18,0,0,688,690,5,64,0,0,689,691,3,10,5,0,690,
		689,1,0,0,0,690,691,1,0,0,0,691,692,1,0,0,0,692,694,5,65,0,0,693,688,1,
		0,0,0,693,694,1,0,0,0,694,107,1,0,0,0,695,701,8,19,0,0,696,697,5,64,0,
		0,697,698,3,108,54,0,698,699,5,65,0,0,699,701,1,0,0,0,700,695,1,0,0,0,
		700,696,1,0,0,0,701,704,1,0,0,0,702,700,1,0,0,0,702,703,1,0,0,0,703,109,
		1,0,0,0,704,702,1,0,0,0,705,707,7,20,0,0,706,708,3,112,56,0,707,706,1,
		0,0,0,707,708,1,0,0,0,708,710,1,0,0,0,709,705,1,0,0,0,710,711,1,0,0,0,
		711,709,1,0,0,0,711,712,1,0,0,0,712,111,1,0,0,0,713,715,3,88,44,0,714,
		713,1,0,0,0,715,716,1,0,0,0,716,714,1,0,0,0,716,717,1,0,0,0,717,113,1,
		0,0,0,718,721,3,116,58,0,719,720,5,93,0,0,720,722,5,109,0,0,721,719,1,
		0,0,0,721,722,1,0,0,0,722,115,1,0,0,0,723,728,3,118,59,0,724,725,5,93,
		0,0,725,727,3,118,59,0,726,724,1,0,0,0,727,730,1,0,0,0,728,726,1,0,0,0,
		728,729,1,0,0,0,729,117,1,0,0,0,730,728,1,0,0,0,731,732,3,50,25,0,732,
		733,3,94,47,0,733,739,1,0,0,0,734,736,3,52,26,0,735,737,3,124,62,0,736,
		735,1,0,0,0,736,737,1,0,0,0,737,739,1,0,0,0,738,731,1,0,0,0,738,734,1,
		0,0,0,739,119,1,0,0,0,740,745,5,110,0,0,741,742,5,93,0,0,742,744,5,110,
		0,0,743,741,1,0,0,0,744,747,1,0,0,0,745,743,1,0,0,0,745,746,1,0,0,0,746,
		121,1,0,0,0,747,745,1,0,0,0,748,750,3,72,36,0,749,751,3,124,62,0,750,749,
		1,0,0,0,750,751,1,0,0,0,751,123,1,0,0,0,752,764,3,110,55,0,753,755,3,110,
		55,0,754,753,1,0,0,0,754,755,1,0,0,0,755,756,1,0,0,0,756,760,3,126,63,
		0,757,759,3,100,50,0,758,757,1,0,0,0,759,762,1,0,0,0,760,758,1,0,0,0,760,
		761,1,0,0,0,761,764,1,0,0,0,762,760,1,0,0,0,763,752,1,0,0,0,763,754,1,
		0,0,0,764,125,1,0,0,0,765,766,6,63,-1,0,766,767,5,64,0,0,767,768,3,124,
		62,0,768,772,5,65,0,0,769,771,3,100,50,0,770,769,1,0,0,0,771,774,1,0,0,
		0,772,770,1,0,0,0,772,773,1,0,0,0,773,812,1,0,0,0,774,772,1,0,0,0,775,
		777,5,66,0,0,776,778,3,112,56,0,777,776,1,0,0,0,777,778,1,0,0,0,778,780,
		1,0,0,0,779,781,3,40,20,0,780,779,1,0,0,0,780,781,1,0,0,0,781,782,1,0,
		0,0,782,812,5,67,0,0,783,784,5,66,0,0,784,786,5,45,0,0,785,787,3,112,56,
		0,786,785,1,0,0,0,786,787,1,0,0,0,787,788,1,0,0,0,788,789,3,40,20,0,789,
		790,5,67,0,0,790,812,1,0,0,0,791,792,5,66,0,0,792,793,3,112,56,0,793,794,
		5,45,0,0,794,795,3,40,20,0,795,796,5,67,0,0,796,812,1,0,0,0,797,798,5,
		66,0,0,798,799,5,80,0,0,799,812,5,67,0,0,800,802,5,64,0,0,801,803,3,114,
		57,0,802,801,1,0,0,0,802,803,1,0,0,0,803,804,1,0,0,0,804,808,5,65,0,0,
		805,807,3,100,50,0,806,805,1,0,0,0,807,810,1,0,0,0,808,806,1,0,0,0,808,
		809,1,0,0,0,809,812,1,0,0,0,810,808,1,0,0,0,811,765,1,0,0,0,811,775,1,
		0,0,0,811,783,1,0,0,0,811,791,1,0,0,0,811,797,1,0,0,0,811,800,1,0,0,0,
		812,856,1,0,0,0,813,814,10,5,0,0,814,816,5,66,0,0,815,817,3,112,56,0,816,
		815,1,0,0,0,816,817,1,0,0,0,817,819,1,0,0,0,818,820,3,40,20,0,819,818,
		1,0,0,0,819,820,1,0,0,0,820,821,1,0,0,0,821,855,5,67,0,0,822,823,10,4,
		0,0,823,824,5,66,0,0,824,826,5,45,0,0,825,827,3,112,56,0,826,825,1,0,0,
		0,826,827,1,0,0,0,827,828,1,0,0,0,828,829,3,40,20,0,829,830,5,67,0,0,830,
		855,1,0,0,0,831,832,10,3,0,0,832,833,5,66,0,0,833,834,3,112,56,0,834,835,
		5,45,0,0,835,836,3,40,20,0,836,837,5,67,0,0,837,855,1,0,0,0,838,839,10,
		2,0,0,839,840,5,66,0,0,840,841,5,80,0,0,841,855,5,67,0,0,842,843,10,1,
		0,0,843,845,5,64,0,0,844,846,3,114,57,0,845,844,1,0,0,0,845,846,1,0,0,
		0,846,847,1,0,0,0,847,851,5,65,0,0,848,850,3,100,50,0,849,848,1,0,0,0,
		850,853,1,0,0,0,851,849,1,0,0,0,851,852,1,0,0,0,852,855,1,0,0,0,853,851,
		1,0,0,0,854,813,1,0,0,0,854,822,1,0,0,0,854,831,1,0,0,0,854,838,1,0,0,
		0,854,842,1,0,0,0,855,858,1,0,0,0,856,854,1,0,0,0,856,857,1,0,0,0,857,
		127,1,0,0,0,858,856,1,0,0,0,859,860,5,110,0,0,860,129,1,0,0,0,861,870,
		3,40,20,0,862,863,5,68,0,0,863,865,3,132,66,0,864,866,5,93,0,0,865,864,
		1,0,0,0,865,866,1,0,0,0,866,867,1,0,0,0,867,868,5,69,0,0,868,870,1,0,0,
		0,869,861,1,0,0,0,869,862,1,0,0,0,870,131,1,0,0,0,871,873,3,134,67,0,872,
		871,1,0,0,0,872,873,1,0,0,0,873,874,1,0,0,0,874,882,3,130,65,0,875,877,
		5,93,0,0,876,878,3,134,67,0,877,876,1,0,0,0,877,878,1,0,0,0,878,879,1,
		0,0,0,879,881,3,130,65,0,880,875,1,0,0,0,881,884,1,0,0,0,882,880,1,0,0,
		0,882,883,1,0,0,0,883,133,1,0,0,0,884,882,1,0,0,0,885,886,3,136,68,0,886,
		887,5,94,0,0,887,135,1,0,0,0,888,890,3,138,69,0,889,888,1,0,0,0,890,891,
		1,0,0,0,891,889,1,0,0,0,891,892,1,0,0,0,892,137,1,0,0,0,893,894,5,66,0,
		0,894,895,3,46,23,0,895,896,5,67,0,0,896,900,1,0,0,0,897,898,5,108,0,0,
		898,900,5,110,0,0,899,893,1,0,0,0,899,897,1,0,0,0,900,139,1,0,0,0,901,
		902,5,62,0,0,902,903,5,64,0,0,903,904,3,46,23,0,904,906,5,93,0,0,905,907,
		5,113,0,0,906,905,1,0,0,0,907,908,1,0,0,0,908,906,1,0,0,0,908,909,1,0,
		0,0,909,910,1,0,0,0,910,911,5,65,0,0,911,912,5,92,0,0,912,141,1,0,0,0,
		913,951,3,144,72,0,914,951,3,146,73,0,915,951,3,152,76,0,916,951,3,154,
		77,0,917,951,3,156,78,0,918,951,3,164,82,0,919,920,7,21,0,0,920,921,7,
		22,0,0,921,930,5,64,0,0,922,927,3,36,18,0,923,924,5,93,0,0,924,926,3,36,
		18,0,925,923,1,0,0,0,926,929,1,0,0,0,927,925,1,0,0,0,927,928,1,0,0,0,928,
		931,1,0,0,0,929,927,1,0,0,0,930,922,1,0,0,0,930,931,1,0,0,0,931,945,1,
		0,0,0,932,941,5,91,0,0,933,938,3,36,18,0,934,935,5,93,0,0,935,937,3,36,
		18,0,936,934,1,0,0,0,937,940,1,0,0,0,938,936,1,0,0,0,938,939,1,0,0,0,939,
		942,1,0,0,0,940,938,1,0,0,0,941,933,1,0,0,0,941,942,1,0,0,0,942,944,1,
		0,0,0,943,932,1,0,0,0,944,947,1,0,0,0,945,943,1,0,0,0,945,946,1,0,0,0,
		946,948,1,0,0,0,947,945,1,0,0,0,948,949,5,65,0,0,949,951,5,92,0,0,950,
		913,1,0,0,0,950,914,1,0,0,0,950,915,1,0,0,0,950,916,1,0,0,0,950,917,1,
		0,0,0,950,918,1,0,0,0,950,919,1,0,0,0,951,143,1,0,0,0,952,953,5,110,0,
		0,953,954,5,91,0,0,954,964,3,142,71,0,955,956,5,22,0,0,956,957,3,46,23,
		0,957,958,5,91,0,0,958,959,3,142,71,0,959,964,1,0,0,0,960,961,5,26,0,0,
		961,962,5,91,0,0,962,964,3,142,71,0,963,952,1,0,0,0,963,955,1,0,0,0,963,
		960,1,0,0,0,964,145,1,0,0,0,965,967,5,68,0,0,966,968,3,148,74,0,967,966,
		1,0,0,0,967,968,1,0,0,0,968,969,1,0,0,0,969,970,5,69,0,0,970,147,1,0,0,
		0,971,973,3,150,75,0,972,971,1,0,0,0,973,974,1,0,0,0,974,972,1,0,0,0,974,
		975,1,0,0,0,975,149,1,0,0,0,976,979,3,142,71,0,977,979,3,48,24,0,978,976,
		1,0,0,0,978,977,1,0,0,0,979,151,1,0,0,0,980,982,3,44,22,0,981,980,1,0,
		0,0,981,982,1,0,0,0,982,983,1,0,0,0,983,984,5,92,0,0,984,153,1,0,0,0,985,
		986,5,35,0,0,986,987,5,64,0,0,987,988,3,44,22,0,988,989,5,65,0,0,989,992,
		3,142,71,0,990,991,5,29,0,0,991,993,3,142,71,0,992,990,1,0,0,0,992,993,
		1,0,0,0,993,1001,1,0,0,0,994,995,5,47,0,0,995,996,5,64,0,0,996,997,3,44,
		22,0,997,998,5,65,0,0,998,999,3,142,71,0,999,1001,1,0,0,0,1000,985,1,0,
		0,0,1000,994,1,0,0,0,1001,155,1,0,0,0,1002,1003,5,53,0,0,1003,1004,5,64,
		0,0,1004,1005,3,44,22,0,1005,1006,5,65,0,0,1006,1007,3,142,71,0,1007,1023,
		1,0,0,0,1008,1009,5,27,0,0,1009,1010,3,142,71,0,1010,1011,5,53,0,0,1011,
		1012,5,64,0,0,1012,1013,3,44,22,0,1013,1014,5,65,0,0,1014,1015,5,92,0,
		0,1015,1023,1,0,0,0,1016,1017,5,33,0,0,1017,1018,5,64,0,0,1018,1019,3,
		158,79,0,1019,1020,5,65,0,0,1020,1021,3,142,71,0,1021,1023,1,0,0,0,1022,
		1002,1,0,0,0,1022,1008,1,0,0,0,1022,1016,1,0,0,0,1023,157,1,0,0,0,1024,
		1029,3,160,80,0,1025,1027,3,44,22,0,1026,1025,1,0,0,0,1026,1027,1,0,0,
		0,1027,1029,1,0,0,0,1028,1024,1,0,0,0,1028,1026,1,0,0,0,1029,1030,1,0,
		0,0,1030,1032,5,92,0,0,1031,1033,3,162,81,0,1032,1031,1,0,0,0,1032,1033,
		1,0,0,0,1033,1034,1,0,0,0,1034,1036,5,92,0,0,1035,1037,3,162,81,0,1036,
		1035,1,0,0,0,1036,1037,1,0,0,0,1037,159,1,0,0,0,1038,1040,3,50,25,0,1039,
		1041,3,56,28,0,1040,1039,1,0,0,0,1040,1041,1,0,0,0,1041,161,1,0,0,0,1042,
		1047,3,40,20,0,1043,1044,5,93,0,0,1044,1046,3,40,20,0,1045,1043,1,0,0,
		0,1046,1049,1,0,0,0,1047,1045,1,0,0,0,1047,1048,1,0,0,0,1048,163,1,0,0,
		0,1049,1047,1,0,0,0,1050,1051,5,34,0,0,1051,1060,5,110,0,0,1052,1060,7,
		23,0,0,1053,1055,5,41,0,0,1054,1056,3,44,22,0,1055,1054,1,0,0,0,1055,1056,
		1,0,0,0,1056,1060,1,0,0,0,1057,1058,5,34,0,0,1058,1060,3,12,6,0,1059,1050,
		1,0,0,0,1059,1052,1,0,0,0,1059,1053,1,0,0,0,1059,1057,1,0,0,0,1060,1061,
		1,0,0,0,1061,1062,5,92,0,0,1062,165,1,0,0,0,1063,1065,3,168,84,0,1064,
		1063,1,0,0,0,1064,1065,1,0,0,0,1065,1066,1,0,0,0,1066,1067,5,0,0,1,1067,
		167,1,0,0,0,1068,1070,3,170,85,0,1069,1068,1,0,0,0,1070,1071,1,0,0,0,1071,
		1069,1,0,0,0,1071,1072,1,0,0,0,1072,169,1,0,0,0,1073,1077,3,172,86,0,1074,
		1077,3,48,24,0,1075,1077,5,92,0,0,1076,1073,1,0,0,0,1076,1074,1,0,0,0,
		1076,1075,1,0,0,0,1077,171,1,0,0,0,1078,1080,3,50,25,0,1079,1078,1,0,0,
		0,1079,1080,1,0,0,0,1080,1081,1,0,0,0,1081,1083,3,94,47,0,1082,1084,3,
		174,87,0,1083,1082,1,0,0,0,1083,1084,1,0,0,0,1084,1085,1,0,0,0,1085,1086,
		3,146,73,0,1086,173,1,0,0,0,1087,1089,3,48,24,0,1088,1087,1,0,0,0,1089,
		1090,1,0,0,0,1090,1088,1,0,0,0,1090,1091,1,0,0,0,1091,175,1,0,0,0,134,
		181,189,209,223,228,235,243,247,255,261,263,271,277,291,296,305,312,320,
		328,336,344,352,360,368,376,384,393,401,410,417,422,427,432,439,446,452,
		470,474,483,490,500,504,507,514,519,523,527,532,538,545,551,568,574,579,
		585,605,610,613,620,635,647,650,652,662,666,676,680,684,690,693,700,702,
		707,711,716,721,728,736,738,745,750,754,760,763,772,777,780,786,802,808,
		811,816,819,826,845,851,854,856,865,869,872,877,882,891,899,908,927,930,
		938,941,945,950,963,967,974,978,981,992,1000,1022,1026,1028,1032,1036,
		1040,1047,1055,1059,1064,1071,1076,1079,1083,1090
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
