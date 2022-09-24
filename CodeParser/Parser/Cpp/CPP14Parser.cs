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
public partial class CPP14Parser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, MultiLineMacro=7, Directive=8, 
		Alignas=9, Alignof=10, Asm=11, Auto=12, Bool=13, Break=14, Case=15, Catch=16, 
		Char=17, Char16=18, Char32=19, Class=20, Const=21, Constexpr=22, Const_cast=23, 
		Continue=24, Decltype=25, Default=26, Delete=27, Do=28, Double=29, Dynamic_cast=30, 
		Else=31, Enum=32, Explicit=33, Export=34, Extern=35, False=36, Final=37, 
		Float=38, For=39, Friend=40, Goto=41, If=42, Inline=43, Int=44, Long=45, 
		Mutable=46, Namespace=47, New=48, Noexcept=49, Nullptr=50, Operator=51, 
		Override=52, Private=53, Protected=54, Public=55, Register=56, Reinterpret_cast=57, 
		Return=58, Short=59, Signed=60, Sizeof=61, Static=62, Static_assert=63, 
		Static_cast=64, Struct=65, Switch=66, Template=67, This=68, Thread_local=69, 
		Throw=70, True=71, Try=72, Typedef=73, Typeid_=74, Typename_=75, Union=76, 
		Unsigned=77, Using=78, Virtual=79, Void=80, Volatile=81, Wchar=82, While=83, 
		LeftParen=84, RightParen=85, LeftBracket=86, RightBracket=87, LeftBrace=88, 
		RightBrace=89, Plus=90, Minus=91, Star=92, Div=93, Mod=94, Caret=95, And=96, 
		Or=97, Tilde=98, Not=99, Assign=100, Less=101, Greater=102, PlusAssign=103, 
		MinusAssign=104, StarAssign=105, DivAssign=106, ModAssign=107, XorAssign=108, 
		AndAssign=109, OrAssign=110, LeftShift=111, RightShift=112, LeftShiftAssign=113, 
		RightShiftAssign=114, Equal=115, NotEqual=116, LessEqual=117, GreaterEqual=118, 
		AndAnd=119, OrOr=120, PlusPlus=121, MinusMinus=122, Comma=123, ArrowStar=124, 
		Arrow=125, Question=126, Colon=127, Doublecolon=128, Semi=129, Dot=130, 
		DotStar=131, Ellipsis=132, Identifier=133, Integerliteral=134, Decimalliteral=135, 
		Octalliteral=136, Hexadecimalliteral=137, Binaryliteral=138, Integersuffix=139, 
		Characterliteral=140, Floatingliteral=141, Stringliteral=142, Userdefinedintegerliteral=143, 
		Userdefinedfloatingliteral=144, Userdefinedstringliteral=145, Userdefinedcharacterliteral=146, 
		Whitespace=147, Newline=148, BlockComment=149, LineComment=150;
	public const int
		RULE_translationunit = 0, RULE_primaryexpression = 1, RULE_idexpression = 2, 
		RULE_unqualifiedid = 3, RULE_qualifiedid = 4, RULE_nestednamespecifier = 5, 
		RULE_lambdaexpression = 6, RULE_lambdaintroducer = 7, RULE_lambdacapture = 8, 
		RULE_capturedefault = 9, RULE_capturelist = 10, RULE_capture = 11, RULE_simplecapture = 12, 
		RULE_initcapture = 13, RULE_lambdadeclarator = 14, RULE_postfixexpression = 15, 
		RULE_typeidofexpr = 16, RULE_typeidofthetypeid = 17, RULE_expressionlist = 18, 
		RULE_pseudodestructorname = 19, RULE_unaryexpression = 20, RULE_unaryoperator = 21, 
		RULE_newexpression = 22, RULE_newplacement = 23, RULE_newtypeid = 24, 
		RULE_newdeclarator = 25, RULE_noptrnewdeclarator = 26, RULE_newinitializer = 27, 
		RULE_deleteexpression = 28, RULE_noexceptexpression = 29, RULE_castexpression = 30, 
		RULE_pmexpression = 31, RULE_multiplicativeexpression = 32, RULE_additiveexpression = 33, 
		RULE_shiftexpression = 34, RULE_shiftoperator = 35, RULE_relationalexpression = 36, 
		RULE_equalityexpression = 37, RULE_andexpression = 38, RULE_exclusiveorexpression = 39, 
		RULE_inclusiveorexpression = 40, RULE_logicalandexpression = 41, RULE_logicalorexpression = 42, 
		RULE_conditionalexpression = 43, RULE_assignmentexpression = 44, RULE_assignmentoperator = 45, 
		RULE_expression = 46, RULE_constantexpression = 47, RULE_statement = 48, 
		RULE_labeledstatement = 49, RULE_expressionstatement = 50, RULE_compoundstatement = 51, 
		RULE_statementseq = 52, RULE_selectionstatement = 53, RULE_condition = 54, 
		RULE_iterationstatement = 55, RULE_forinitstatement = 56, RULE_forrangedeclaration = 57, 
		RULE_forrangeinitializer = 58, RULE_jumpstatement = 59, RULE_declarationstatement = 60, 
		RULE_declarationseq = 61, RULE_declaration = 62, RULE_blockdeclaration = 63, 
		RULE_aliasdeclaration = 64, RULE_simpledeclaration = 65, RULE_static_assertdeclaration = 66, 
		RULE_emptydeclaration = 67, RULE_attributedeclaration = 68, RULE_declspecifier = 69, 
		RULE_declspecifierseq = 70, RULE_storageclassspecifier = 71, RULE_functionspecifier = 72, 
		RULE_typedefname = 73, RULE_typespecifier = 74, RULE_trailingtypespecifier = 75, 
		RULE_typespecifierseq = 76, RULE_trailingtypespecifierseq = 77, RULE_simpletypespecifier = 78, 
		RULE_thetypename = 79, RULE_decltypespecifier = 80, RULE_elaboratedtypespecifier = 81, 
		RULE_enumname = 82, RULE_enumspecifier = 83, RULE_enumhead = 84, RULE_opaqueenumdeclaration = 85, 
		RULE_enumkey = 86, RULE_enumbase = 87, RULE_enumeratorlist = 88, RULE_enumeratordefinition = 89, 
		RULE_enumerator = 90, RULE_namespacename = 91, RULE_originalnamespacename = 92, 
		RULE_namespacedefinition = 93, RULE_namednamespacedefinition = 94, RULE_originalnamespacedefinition = 95, 
		RULE_extensionnamespacedefinition = 96, RULE_unnamednamespacedefinition = 97, 
		RULE_namespacebody = 98, RULE_namespacealias = 99, RULE_namespacealiasdefinition = 100, 
		RULE_qualifiednamespacespecifier = 101, RULE_usingdeclaration = 102, RULE_usingdirective = 103, 
		RULE_asmdefinition = 104, RULE_linkagespecification = 105, RULE_attributespecifierseq = 106, 
		RULE_attributespecifier = 107, RULE_alignmentspecifier = 108, RULE_attributelist = 109, 
		RULE_attribute = 110, RULE_attributetoken = 111, RULE_attributescopedtoken = 112, 
		RULE_attributenamespace = 113, RULE_attributeargumentclause = 114, RULE_balancedtokenseq = 115, 
		RULE_balancedtoken = 116, RULE_initdeclaratorlist = 117, RULE_initdeclarator = 118, 
		RULE_declarator = 119, RULE_ptrdeclarator = 120, RULE_noptrdeclarator = 121, 
		RULE_parametersandqualifiers = 122, RULE_trailingreturntype = 123, RULE_ptroperator = 124, 
		RULE_cvqualifierseq = 125, RULE_cvqualifier = 126, RULE_refqualifier = 127, 
		RULE_declaratorid = 128, RULE_thetypeid = 129, RULE_abstractdeclarator = 130, 
		RULE_ptrabstractdeclarator = 131, RULE_noptrabstractdeclarator = 132, 
		RULE_abstractpackdeclarator = 133, RULE_noptrabstractpackdeclarator = 134, 
		RULE_parameterdeclarationclause = 135, RULE_parameterdeclarationlist = 136, 
		RULE_parameterdeclaration = 137, RULE_functiondefinition = 138, RULE_functionbody = 139, 
		RULE_initializer = 140, RULE_braceorequalinitializer = 141, RULE_initializerclause = 142, 
		RULE_initializerlist = 143, RULE_bracedinitlist = 144, RULE_classname = 145, 
		RULE_classspecifier = 146, RULE_classhead = 147, RULE_classheadname = 148, 
		RULE_classvirtspecifier = 149, RULE_classkey = 150, RULE_memberspecification = 151, 
		RULE_memberdeclaration = 152, RULE_memberdeclaratorlist = 153, RULE_memberdeclarator = 154, 
		RULE_virtspecifierseq = 155, RULE_virtspecifier = 156, RULE_purespecifier = 157, 
		RULE_baseclause = 158, RULE_basespecifierlist = 159, RULE_basespecifier = 160, 
		RULE_classordecltype = 161, RULE_basetypespecifier = 162, RULE_accessspecifier = 163, 
		RULE_conversionfunctionid = 164, RULE_conversiontypeid = 165, RULE_conversiondeclarator = 166, 
		RULE_ctorinitializer = 167, RULE_meminitializerlist = 168, RULE_meminitializer = 169, 
		RULE_meminitializerid = 170, RULE_operatorfunctionid = 171, RULE_literaloperatorid = 172, 
		RULE_templatedeclaration = 173, RULE_templateparameterlist = 174, RULE_templateparameter = 175, 
		RULE_typeparameter = 176, RULE_simpletemplateid = 177, RULE_templateid = 178, 
		RULE_templatename = 179, RULE_templateargumentlist = 180, RULE_templateargument = 181, 
		RULE_typenamespecifier = 182, RULE_explicitinstantiation = 183, RULE_explicitspecialization = 184, 
		RULE_tryblock = 185, RULE_functiontryblock = 186, RULE_handlerseq = 187, 
		RULE_handler = 188, RULE_exceptiondeclaration = 189, RULE_throwexpression = 190, 
		RULE_exceptionspecification = 191, RULE_dynamicexceptionspecification = 192, 
		RULE_typeidlist = 193, RULE_noexceptspecification = 194, RULE_theoperator = 195, 
		RULE_literal = 196, RULE_booleanliteral = 197, RULE_pointerliteral = 198, 
		RULE_userdefinedliteral = 199;
	public static readonly string[] ruleNames = {
		"translationunit", "primaryexpression", "idexpression", "unqualifiedid", 
		"qualifiedid", "nestednamespecifier", "lambdaexpression", "lambdaintroducer", 
		"lambdacapture", "capturedefault", "capturelist", "capture", "simplecapture", 
		"initcapture", "lambdadeclarator", "postfixexpression", "typeidofexpr", 
		"typeidofthetypeid", "expressionlist", "pseudodestructorname", "unaryexpression", 
		"unaryoperator", "newexpression", "newplacement", "newtypeid", "newdeclarator", 
		"noptrnewdeclarator", "newinitializer", "deleteexpression", "noexceptexpression", 
		"castexpression", "pmexpression", "multiplicativeexpression", "additiveexpression", 
		"shiftexpression", "shiftoperator", "relationalexpression", "equalityexpression", 
		"andexpression", "exclusiveorexpression", "inclusiveorexpression", "logicalandexpression", 
		"logicalorexpression", "conditionalexpression", "assignmentexpression", 
		"assignmentoperator", "expression", "constantexpression", "statement", 
		"labeledstatement", "expressionstatement", "compoundstatement", "statementseq", 
		"selectionstatement", "condition", "iterationstatement", "forinitstatement", 
		"forrangedeclaration", "forrangeinitializer", "jumpstatement", "declarationstatement", 
		"declarationseq", "declaration", "blockdeclaration", "aliasdeclaration", 
		"simpledeclaration", "static_assertdeclaration", "emptydeclaration", "attributedeclaration", 
		"declspecifier", "declspecifierseq", "storageclassspecifier", "functionspecifier", 
		"typedefname", "typespecifier", "trailingtypespecifier", "typespecifierseq", 
		"trailingtypespecifierseq", "simpletypespecifier", "thetypename", "decltypespecifier", 
		"elaboratedtypespecifier", "enumname", "enumspecifier", "enumhead", "opaqueenumdeclaration", 
		"enumkey", "enumbase", "enumeratorlist", "enumeratordefinition", "enumerator", 
		"namespacename", "originalnamespacename", "namespacedefinition", "namednamespacedefinition", 
		"originalnamespacedefinition", "extensionnamespacedefinition", "unnamednamespacedefinition", 
		"namespacebody", "namespacealias", "namespacealiasdefinition", "qualifiednamespacespecifier", 
		"usingdeclaration", "usingdirective", "asmdefinition", "linkagespecification", 
		"attributespecifierseq", "attributespecifier", "alignmentspecifier", "attributelist", 
		"attribute", "attributetoken", "attributescopedtoken", "attributenamespace", 
		"attributeargumentclause", "balancedtokenseq", "balancedtoken", "initdeclaratorlist", 
		"initdeclarator", "declarator", "ptrdeclarator", "noptrdeclarator", "parametersandqualifiers", 
		"trailingreturntype", "ptroperator", "cvqualifierseq", "cvqualifier", 
		"refqualifier", "declaratorid", "thetypeid", "abstractdeclarator", "ptrabstractdeclarator", 
		"noptrabstractdeclarator", "abstractpackdeclarator", "noptrabstractpackdeclarator", 
		"parameterdeclarationclause", "parameterdeclarationlist", "parameterdeclaration", 
		"functiondefinition", "functionbody", "initializer", "braceorequalinitializer", 
		"initializerclause", "initializerlist", "bracedinitlist", "classname", 
		"classspecifier", "classhead", "classheadname", "classvirtspecifier", 
		"classkey", "memberspecification", "memberdeclaration", "memberdeclaratorlist", 
		"memberdeclarator", "virtspecifierseq", "virtspecifier", "purespecifier", 
		"baseclause", "basespecifierlist", "basespecifier", "classordecltype", 
		"basetypespecifier", "accessspecifier", "conversionfunctionid", "conversiontypeid", 
		"conversiondeclarator", "ctorinitializer", "meminitializerlist", "meminitializer", 
		"meminitializerid", "operatorfunctionid", "literaloperatorid", "templatedeclaration", 
		"templateparameterlist", "templateparameter", "typeparameter", "simpletemplateid", 
		"templateid", "templatename", "templateargumentlist", "templateargument", 
		"typenamespecifier", "explicitinstantiation", "explicitspecialization", 
		"tryblock", "functiontryblock", "handlerseq", "handler", "exceptiondeclaration", 
		"throwexpression", "exceptionspecification", "dynamicexceptionspecification", 
		"typeidlist", "noexceptspecification", "theoperator", "literal", "booleanliteral", 
		"pointerliteral", "userdefinedliteral"
	};

	private static readonly string[] _LiteralNames = {
		null, "'!'", "'not'", "'&&'", "'and'", "'||'", "'or'", null, null, "'alignas'", 
		"'alignof'", "'asm'", "'auto'", "'bool'", "'break'", "'case'", "'catch'", 
		"'char'", "'char16_t'", "'char32_t'", "'class'", "'const'", "'constexpr'", 
		"'const_cast'", "'continue'", "'decltype'", "'default'", "'delete'", "'do'", 
		"'double'", "'dynamic_cast'", "'else'", "'enum'", "'explicit'", "'export'", 
		"'extern'", "'false'", "'final'", "'float'", "'for'", "'friend'", "'goto'", 
		"'if'", "'inline'", "'int'", "'long'", "'mutable'", "'namespace'", "'new'", 
		"'noexcept'", "'nullptr'", "'operator'", "'override'", "'private'", "'protected'", 
		"'public'", "'register'", "'reinterpret_cast'", "'return'", "'short'", 
		"'signed'", "'sizeof'", "'static'", "'static_assert'", "'static_cast'", 
		"'struct'", "'switch'", "'template'", "'this'", "'thread_local'", "'throw'", 
		"'true'", "'try'", "'typedef'", "'typeid'", "'typename'", "'union'", "'unsigned'", 
		"'using'", "'virtual'", "'void'", "'volatile'", "'wchar_t'", "'while'", 
		"'('", "')'", "'['", "']'", "'{'", "'}'", "'+'", "'-'", "'*'", "'/'", 
		"'%'", "'^'", "'&'", "'|'", "'~'", null, "'='", "'<'", "'>'", "'+='", 
		"'-='", "'*='", "'/='", "'%='", "'^='", "'&='", "'|='", "'<<'", "'>>'", 
		"'<<='", "'>>='", "'=='", "'!='", "'<='", "'>='", null, null, "'++'", 
		"'--'", "','", "'->*'", "'->'", "'?'", "':'", "'::'", "';'", "'.'", "'.*'", 
		"'...'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, "MultiLineMacro", "Directive", 
		"Alignas", "Alignof", "Asm", "Auto", "Bool", "Break", "Case", "Catch", 
		"Char", "Char16", "Char32", "Class", "Const", "Constexpr", "Const_cast", 
		"Continue", "Decltype", "Default", "Delete", "Do", "Double", "Dynamic_cast", 
		"Else", "Enum", "Explicit", "Export", "Extern", "False", "Final", "Float", 
		"For", "Friend", "Goto", "If", "Inline", "Int", "Long", "Mutable", "Namespace", 
		"New", "Noexcept", "Nullptr", "Operator", "Override", "Private", "Protected", 
		"Public", "Register", "Reinterpret_cast", "Return", "Short", "Signed", 
		"Sizeof", "Static", "Static_assert", "Static_cast", "Struct", "Switch", 
		"Template", "This", "Thread_local", "Throw", "True", "Try", "Typedef", 
		"Typeid_", "Typename_", "Union", "Unsigned", "Using", "Virtual", "Void", 
		"Volatile", "Wchar", "While", "LeftParen", "RightParen", "LeftBracket", 
		"RightBracket", "LeftBrace", "RightBrace", "Plus", "Minus", "Star", "Div", 
		"Mod", "Caret", "And", "Or", "Tilde", "Not", "Assign", "Less", "Greater", 
		"PlusAssign", "MinusAssign", "StarAssign", "DivAssign", "ModAssign", "XorAssign", 
		"AndAssign", "OrAssign", "LeftShift", "RightShift", "LeftShiftAssign", 
		"RightShiftAssign", "Equal", "NotEqual", "LessEqual", "GreaterEqual", 
		"AndAnd", "OrOr", "PlusPlus", "MinusMinus", "Comma", "ArrowStar", "Arrow", 
		"Question", "Colon", "Doublecolon", "Semi", "Dot", "DotStar", "Ellipsis", 
		"Identifier", "Integerliteral", "Decimalliteral", "Octalliteral", "Hexadecimalliteral", 
		"Binaryliteral", "Integersuffix", "Characterliteral", "Floatingliteral", 
		"Stringliteral", "Userdefinedintegerliteral", "Userdefinedfloatingliteral", 
		"Userdefinedstringliteral", "Userdefinedcharacterliteral", "Whitespace", 
		"Newline", "BlockComment", "LineComment"
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

	public override string GrammarFileName { get { return "CPP14.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static CPP14Parser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public CPP14Parser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public CPP14Parser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class TranslationunitContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(CPP14Parser.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationseqContext declarationseq() {
			return GetRuleContext<DeclarationseqContext>(0);
		}
		public TranslationunitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_translationunit; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTranslationunit(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTranslationunit(this);
		}
	}

	[RuleVersion(0)]
	public TranslationunitContext translationunit() {
		TranslationunitContext _localctx = new TranslationunitContext(Context, State);
		EnterRule(_localctx, 0, RULE_translationunit);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 401;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << Alignas) | (1L << Asm) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Class) | (1L << Const) | (1L << Constexpr) | (1L << Decltype) | (1L << Double) | (1L << Enum) | (1L << Explicit) | (1L << Extern) | (1L << Float) | (1L << Friend) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Mutable) | (1L << Namespace) | (1L << Operator) | (1L << Register) | (1L << Short) | (1L << Signed) | (1L << Static) | (1L << Static_assert))) != 0) || ((((_la - 65)) & ~0x3f) == 0 && ((1L << (_la - 65)) & ((1L << (Struct - 65)) | (1L << (Template - 65)) | (1L << (Thread_local - 65)) | (1L << (Typedef - 65)) | (1L << (Typename_ - 65)) | (1L << (Union - 65)) | (1L << (Unsigned - 65)) | (1L << (Using - 65)) | (1L << (Virtual - 65)) | (1L << (Void - 65)) | (1L << (Volatile - 65)) | (1L << (Wchar - 65)) | (1L << (LeftParen - 65)) | (1L << (LeftBracket - 65)) | (1L << (Star - 65)) | (1L << (And - 65)) | (1L << (Tilde - 65)) | (1L << (Doublecolon - 65)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (Semi - 129)) | (1L << (Ellipsis - 129)) | (1L << (Identifier - 129)))) != 0)) {
				{
				State = 400;
				declarationseq(0);
				}
			}

			State = 403;
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

	public partial class PrimaryexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public LiteralContext literal() {
			return GetRuleContext<LiteralContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode This() { return GetToken(CPP14Parser.This, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdexpressionContext idexpression() {
			return GetRuleContext<IdexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public LambdaexpressionContext lambdaexpression() {
			return GetRuleContext<LambdaexpressionContext>(0);
		}
		public PrimaryexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primaryexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterPrimaryexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitPrimaryexpression(this);
		}
	}

	[RuleVersion(0)]
	public PrimaryexpressionContext primaryexpression() {
		PrimaryexpressionContext _localctx = new PrimaryexpressionContext(Context, State);
		EnterRule(_localctx, 2, RULE_primaryexpression);
		try {
			State = 413;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case False:
			case Nullptr:
			case True:
			case Integerliteral:
			case Characterliteral:
			case Floatingliteral:
			case Stringliteral:
			case Userdefinedintegerliteral:
			case Userdefinedfloatingliteral:
			case Userdefinedstringliteral:
			case Userdefinedcharacterliteral:
				EnterOuterAlt(_localctx, 1);
				{
				State = 405;
				literal();
				}
				break;
			case This:
				EnterOuterAlt(_localctx, 2);
				{
				State = 406;
				Match(This);
				}
				break;
			case LeftParen:
				EnterOuterAlt(_localctx, 3);
				{
				State = 407;
				Match(LeftParen);
				State = 408;
				expression(0);
				State = 409;
				Match(RightParen);
				}
				break;
			case Decltype:
			case Operator:
			case Tilde:
			case Doublecolon:
			case Identifier:
				EnterOuterAlt(_localctx, 4);
				{
				State = 411;
				idexpression();
				}
				break;
			case LeftBracket:
				EnterOuterAlt(_localctx, 5);
				{
				State = 412;
				lambdaexpression();
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

	public partial class IdexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnqualifiedidContext unqualifiedid() {
			return GetRuleContext<UnqualifiedidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedidContext qualifiedid() {
			return GetRuleContext<QualifiedidContext>(0);
		}
		public IdexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_idexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterIdexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitIdexpression(this);
		}
	}

	[RuleVersion(0)]
	public IdexpressionContext idexpression() {
		IdexpressionContext _localctx = new IdexpressionContext(Context, State);
		EnterRule(_localctx, 4, RULE_idexpression);
		try {
			State = 417;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 415;
				unqualifiedid();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 416;
				qualifiedid();
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

	public partial class UnqualifiedidContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public OperatorfunctionidContext operatorfunctionid() {
			return GetRuleContext<OperatorfunctionidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConversionfunctionidContext conversionfunctionid() {
			return GetRuleContext<ConversionfunctionidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public LiteraloperatoridContext literaloperatorid() {
			return GetRuleContext<LiteraloperatoridContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Tilde() { return GetToken(CPP14Parser.Tilde, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ClassnameContext classname() {
			return GetRuleContext<ClassnameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DecltypespecifierContext decltypespecifier() {
			return GetRuleContext<DecltypespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TemplateidContext templateid() {
			return GetRuleContext<TemplateidContext>(0);
		}
		public UnqualifiedidContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unqualifiedid; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterUnqualifiedid(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitUnqualifiedid(this);
		}
	}

	[RuleVersion(0)]
	public UnqualifiedidContext unqualifiedid() {
		UnqualifiedidContext _localctx = new UnqualifiedidContext(Context, State);
		EnterRule(_localctx, 6, RULE_unqualifiedid);
		try {
			State = 428;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 419;
				Match(Identifier);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 420;
				operatorfunctionid();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 421;
				conversionfunctionid();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 422;
				literaloperatorid();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 423;
				Match(Tilde);
				State = 424;
				classname();
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 425;
				Match(Tilde);
				State = 426;
				decltypespecifier();
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 427;
				templateid();
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

	public partial class QualifiedidContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public NestednamespecifierContext nestednamespecifier() {
			return GetRuleContext<NestednamespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnqualifiedidContext unqualifiedid() {
			return GetRuleContext<UnqualifiedidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Template() { return GetToken(CPP14Parser.Template, 0); }
		public QualifiedidContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_qualifiedid; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterQualifiedid(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitQualifiedid(this);
		}
	}

	[RuleVersion(0)]
	public QualifiedidContext qualifiedid() {
		QualifiedidContext _localctx = new QualifiedidContext(Context, State);
		EnterRule(_localctx, 8, RULE_qualifiedid);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 430;
			nestednamespecifier(0);
			State = 432;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Template) {
				{
				State = 431;
				Match(Template);
				}
			}

			State = 434;
			unqualifiedid();
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

	public partial class NestednamespecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Doublecolon() { return GetToken(CPP14Parser.Doublecolon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ThetypenameContext thetypename() {
			return GetRuleContext<ThetypenameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NamespacenameContext namespacename() {
			return GetRuleContext<NamespacenameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DecltypespecifierContext decltypespecifier() {
			return GetRuleContext<DecltypespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NestednamespecifierContext nestednamespecifier() {
			return GetRuleContext<NestednamespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public SimpletemplateidContext simpletemplateid() {
			return GetRuleContext<SimpletemplateidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Template() { return GetToken(CPP14Parser.Template, 0); }
		public NestednamespecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_nestednamespecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterNestednamespecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitNestednamespecifier(this);
		}
	}

	[RuleVersion(0)]
	public NestednamespecifierContext nestednamespecifier() {
		return nestednamespecifier(0);
	}

	private NestednamespecifierContext nestednamespecifier(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		NestednamespecifierContext _localctx = new NestednamespecifierContext(Context, _parentState);
		NestednamespecifierContext _prevctx = _localctx;
		int _startState = 10;
		EnterRecursionRule(_localctx, 10, RULE_nestednamespecifier, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 447;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,5,Context) ) {
			case 1:
				{
				State = 437;
				Match(Doublecolon);
				}
				break;
			case 2:
				{
				State = 438;
				thetypename();
				State = 439;
				Match(Doublecolon);
				}
				break;
			case 3:
				{
				State = 441;
				namespacename();
				State = 442;
				Match(Doublecolon);
				}
				break;
			case 4:
				{
				State = 444;
				decltypespecifier();
				State = 445;
				Match(Doublecolon);
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 461;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,8,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 459;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,7,Context) ) {
					case 1:
						{
						_localctx = new NestednamespecifierContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_nestednamespecifier);
						State = 449;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 450;
						Match(Identifier);
						State = 451;
						Match(Doublecolon);
						}
						break;
					case 2:
						{
						_localctx = new NestednamespecifierContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_nestednamespecifier);
						State = 452;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 454;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if (_la==Template) {
							{
							State = 453;
							Match(Template);
							}
						}

						State = 456;
						simpletemplateid();
						State = 457;
						Match(Doublecolon);
						}
						break;
					}
					} 
				}
				State = 463;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,8,Context);
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

	public partial class LambdaexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public LambdaintroducerContext lambdaintroducer() {
			return GetRuleContext<LambdaintroducerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CompoundstatementContext compoundstatement() {
			return GetRuleContext<CompoundstatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public LambdadeclaratorContext lambdadeclarator() {
			return GetRuleContext<LambdadeclaratorContext>(0);
		}
		public LambdaexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lambdaexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterLambdaexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitLambdaexpression(this);
		}
	}

	[RuleVersion(0)]
	public LambdaexpressionContext lambdaexpression() {
		LambdaexpressionContext _localctx = new LambdaexpressionContext(Context, State);
		EnterRule(_localctx, 12, RULE_lambdaexpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 464;
			lambdaintroducer();
			State = 466;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LeftParen) {
				{
				State = 465;
				lambdadeclarator();
				}
			}

			State = 468;
			compoundstatement();
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

	public partial class LambdaintroducerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBracket() { return GetToken(CPP14Parser.LeftBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBracket() { return GetToken(CPP14Parser.RightBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public LambdacaptureContext lambdacapture() {
			return GetRuleContext<LambdacaptureContext>(0);
		}
		public LambdaintroducerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lambdaintroducer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterLambdaintroducer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitLambdaintroducer(this);
		}
	}

	[RuleVersion(0)]
	public LambdaintroducerContext lambdaintroducer() {
		LambdaintroducerContext _localctx = new LambdaintroducerContext(Context, State);
		EnterRule(_localctx, 14, RULE_lambdaintroducer);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 470;
			Match(LeftBracket);
			State = 472;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 68)) & ~0x3f) == 0 && ((1L << (_la - 68)) & ((1L << (This - 68)) | (1L << (And - 68)) | (1L << (Assign - 68)))) != 0) || _la==Identifier) {
				{
				State = 471;
				lambdacapture();
				}
			}

			State = 474;
			Match(RightBracket);
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

	public partial class LambdacaptureContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public CapturedefaultContext capturedefault() {
			return GetRuleContext<CapturedefaultContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CapturelistContext capturelist() {
			return GetRuleContext<CapturelistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		public LambdacaptureContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lambdacapture; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterLambdacapture(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitLambdacapture(this);
		}
	}

	[RuleVersion(0)]
	public LambdacaptureContext lambdacapture() {
		LambdacaptureContext _localctx = new LambdacaptureContext(Context, State);
		EnterRule(_localctx, 16, RULE_lambdacapture);
		try {
			State = 482;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,11,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 476;
				capturedefault();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 477;
				capturelist(0);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 478;
				capturedefault();
				State = 479;
				Match(Comma);
				State = 480;
				capturelist(0);
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

	public partial class CapturedefaultContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode And() { return GetToken(CPP14Parser.And, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Assign() { return GetToken(CPP14Parser.Assign, 0); }
		public CapturedefaultContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_capturedefault; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterCapturedefault(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitCapturedefault(this);
		}
	}

	[RuleVersion(0)]
	public CapturedefaultContext capturedefault() {
		CapturedefaultContext _localctx = new CapturedefaultContext(Context, State);
		EnterRule(_localctx, 18, RULE_capturedefault);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 484;
			_la = TokenStream.LA(1);
			if ( !(_la==And || _la==Assign) ) {
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

	public partial class CapturelistContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public CaptureContext capture() {
			return GetRuleContext<CaptureContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ellipsis() { return GetToken(CPP14Parser.Ellipsis, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public CapturelistContext capturelist() {
			return GetRuleContext<CapturelistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		public CapturelistContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_capturelist; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterCapturelist(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitCapturelist(this);
		}
	}

	[RuleVersion(0)]
	public CapturelistContext capturelist() {
		return capturelist(0);
	}

	private CapturelistContext capturelist(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		CapturelistContext _localctx = new CapturelistContext(Context, _parentState);
		CapturelistContext _prevctx = _localctx;
		int _startState = 20;
		EnterRecursionRule(_localctx, 20, RULE_capturelist, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 487;
			capture();
			State = 489;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,12,Context) ) {
			case 1:
				{
				State = 488;
				Match(Ellipsis);
				}
				break;
			}
			}
			Context.Stop = TokenStream.LT(-1);
			State = 499;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,14,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new CapturelistContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_capturelist);
					State = 491;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 492;
					Match(Comma);
					State = 493;
					capture();
					State = 495;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,13,Context) ) {
					case 1:
						{
						State = 494;
						Match(Ellipsis);
						}
						break;
					}
					}
					} 
				}
				State = 501;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,14,Context);
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

	public partial class CaptureContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public SimplecaptureContext simplecapture() {
			return GetRuleContext<SimplecaptureContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InitcaptureContext initcapture() {
			return GetRuleContext<InitcaptureContext>(0);
		}
		public CaptureContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_capture; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterCapture(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitCapture(this);
		}
	}

	[RuleVersion(0)]
	public CaptureContext capture() {
		CaptureContext _localctx = new CaptureContext(Context, State);
		EnterRule(_localctx, 22, RULE_capture);
		try {
			State = 504;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,15,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 502;
				simplecapture();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 503;
				initcapture();
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

	public partial class SimplecaptureContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode And() { return GetToken(CPP14Parser.And, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode This() { return GetToken(CPP14Parser.This, 0); }
		public SimplecaptureContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_simplecapture; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterSimplecapture(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitSimplecapture(this);
		}
	}

	[RuleVersion(0)]
	public SimplecaptureContext simplecapture() {
		SimplecaptureContext _localctx = new SimplecaptureContext(Context, State);
		EnterRule(_localctx, 24, RULE_simplecapture);
		try {
			State = 510;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Identifier:
				EnterOuterAlt(_localctx, 1);
				{
				State = 506;
				Match(Identifier);
				}
				break;
			case And:
				EnterOuterAlt(_localctx, 2);
				{
				State = 507;
				Match(And);
				State = 508;
				Match(Identifier);
				}
				break;
			case This:
				EnterOuterAlt(_localctx, 3);
				{
				State = 509;
				Match(This);
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

	public partial class InitcaptureContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InitializerContext initializer() {
			return GetRuleContext<InitializerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode And() { return GetToken(CPP14Parser.And, 0); }
		public InitcaptureContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_initcapture; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterInitcapture(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitInitcapture(this);
		}
	}

	[RuleVersion(0)]
	public InitcaptureContext initcapture() {
		InitcaptureContext _localctx = new InitcaptureContext(Context, State);
		EnterRule(_localctx, 26, RULE_initcapture);
		try {
			State = 517;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Identifier:
				EnterOuterAlt(_localctx, 1);
				{
				State = 512;
				Match(Identifier);
				State = 513;
				initializer();
				}
				break;
			case And:
				EnterOuterAlt(_localctx, 2);
				{
				State = 514;
				Match(And);
				State = 515;
				Match(Identifier);
				State = 516;
				initializer();
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

	public partial class LambdadeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ParameterdeclarationclauseContext parameterdeclarationclause() {
			return GetRuleContext<ParameterdeclarationclauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Mutable() { return GetToken(CPP14Parser.Mutable, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExceptionspecificationContext exceptionspecification() {
			return GetRuleContext<ExceptionspecificationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TrailingreturntypeContext trailingreturntype() {
			return GetRuleContext<TrailingreturntypeContext>(0);
		}
		public LambdadeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lambdadeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterLambdadeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitLambdadeclarator(this);
		}
	}

	[RuleVersion(0)]
	public LambdadeclaratorContext lambdadeclarator() {
		LambdadeclaratorContext _localctx = new LambdadeclaratorContext(Context, State);
		EnterRule(_localctx, 28, RULE_lambdadeclarator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 519;
			Match(LeftParen);
			State = 520;
			parameterdeclarationclause();
			State = 521;
			Match(RightParen);
			State = 523;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Mutable) {
				{
				State = 522;
				Match(Mutable);
				}
			}

			State = 526;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Noexcept || _la==Throw) {
				{
				State = 525;
				exceptionspecification();
				}
			}

			State = 529;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Alignas || _la==LeftBracket) {
				{
				State = 528;
				attributespecifierseq(0);
				}
			}

			State = 532;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Arrow) {
				{
				State = 531;
				trailingreturntype();
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

	public partial class PostfixexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryexpressionContext primaryexpression() {
			return GetRuleContext<PrimaryexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SimpletypespecifierContext simpletypespecifier() {
			return GetRuleContext<SimpletypespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionlistContext expressionlist() {
			return GetRuleContext<ExpressionlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypenamespecifierContext typenamespecifier() {
			return GetRuleContext<TypenamespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BracedinitlistContext bracedinitlist() {
			return GetRuleContext<BracedinitlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Dynamic_cast() { return GetToken(CPP14Parser.Dynamic_cast, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Less() { return GetToken(CPP14Parser.Less, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ThetypeidContext thetypeid() {
			return GetRuleContext<ThetypeidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Greater() { return GetToken(CPP14Parser.Greater, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Static_cast() { return GetToken(CPP14Parser.Static_cast, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Reinterpret_cast() { return GetToken(CPP14Parser.Reinterpret_cast, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Const_cast() { return GetToken(CPP14Parser.Const_cast, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeidofthetypeidContext typeidofthetypeid() {
			return GetRuleContext<TypeidofthetypeidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PostfixexpressionContext postfixexpression() {
			return GetRuleContext<PostfixexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBracket() { return GetToken(CPP14Parser.LeftBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBracket() { return GetToken(CPP14Parser.RightBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Dot() { return GetToken(CPP14Parser.Dot, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdexpressionContext idexpression() {
			return GetRuleContext<IdexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Template() { return GetToken(CPP14Parser.Template, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Arrow() { return GetToken(CPP14Parser.Arrow, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public PseudodestructornameContext pseudodestructorname() {
			return GetRuleContext<PseudodestructornameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PlusPlus() { return GetToken(CPP14Parser.PlusPlus, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MinusMinus() { return GetToken(CPP14Parser.MinusMinus, 0); }
		public PostfixexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_postfixexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterPostfixexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitPostfixexpression(this);
		}
	}

	[RuleVersion(0)]
	public PostfixexpressionContext postfixexpression() {
		return postfixexpression(0);
	}

	private PostfixexpressionContext postfixexpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		PostfixexpressionContext _localctx = new PostfixexpressionContext(Context, _parentState);
		PostfixexpressionContext _prevctx = _localctx;
		int _startState = 30;
		EnterRecursionRule(_localctx, 30, RULE_postfixexpression, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 598;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,24,Context) ) {
			case 1:
				{
				State = 535;
				primaryexpression();
				}
				break;
			case 2:
				{
				State = 536;
				simpletypespecifier();
				State = 537;
				Match(LeftParen);
				State = 539;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << Alignof) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Const_cast) | (1L << Decltype) | (1L << Delete) | (1L << Double) | (1L << Dynamic_cast) | (1L << False) | (1L << Float) | (1L << Int) | (1L << Long) | (1L << New) | (1L << Noexcept) | (1L << Nullptr) | (1L << Operator) | (1L << Reinterpret_cast) | (1L << Short) | (1L << Signed) | (1L << Sizeof))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Static_cast - 64)) | (1L << (This - 64)) | (1L << (Throw - 64)) | (1L << (True - 64)) | (1L << (Typeid_ - 64)) | (1L << (Typename_ - 64)) | (1L << (Unsigned - 64)) | (1L << (Void - 64)) | (1L << (Wchar - 64)) | (1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (LeftBrace - 64)) | (1L << (Plus - 64)) | (1L << (Minus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (Or - 64)) | (1L << (Tilde - 64)) | (1L << (PlusPlus - 64)) | (1L << (MinusMinus - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (Doublecolon - 128)) | (1L << (Identifier - 128)) | (1L << (Integerliteral - 128)) | (1L << (Characterliteral - 128)) | (1L << (Floatingliteral - 128)) | (1L << (Stringliteral - 128)) | (1L << (Userdefinedintegerliteral - 128)) | (1L << (Userdefinedfloatingliteral - 128)) | (1L << (Userdefinedstringliteral - 128)) | (1L << (Userdefinedcharacterliteral - 128)))) != 0)) {
					{
					State = 538;
					expressionlist();
					}
				}

				State = 541;
				Match(RightParen);
				}
				break;
			case 3:
				{
				State = 543;
				typenamespecifier();
				State = 544;
				Match(LeftParen);
				State = 546;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << Alignof) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Const_cast) | (1L << Decltype) | (1L << Delete) | (1L << Double) | (1L << Dynamic_cast) | (1L << False) | (1L << Float) | (1L << Int) | (1L << Long) | (1L << New) | (1L << Noexcept) | (1L << Nullptr) | (1L << Operator) | (1L << Reinterpret_cast) | (1L << Short) | (1L << Signed) | (1L << Sizeof))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Static_cast - 64)) | (1L << (This - 64)) | (1L << (Throw - 64)) | (1L << (True - 64)) | (1L << (Typeid_ - 64)) | (1L << (Typename_ - 64)) | (1L << (Unsigned - 64)) | (1L << (Void - 64)) | (1L << (Wchar - 64)) | (1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (LeftBrace - 64)) | (1L << (Plus - 64)) | (1L << (Minus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (Or - 64)) | (1L << (Tilde - 64)) | (1L << (PlusPlus - 64)) | (1L << (MinusMinus - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (Doublecolon - 128)) | (1L << (Identifier - 128)) | (1L << (Integerliteral - 128)) | (1L << (Characterliteral - 128)) | (1L << (Floatingliteral - 128)) | (1L << (Stringliteral - 128)) | (1L << (Userdefinedintegerliteral - 128)) | (1L << (Userdefinedfloatingliteral - 128)) | (1L << (Userdefinedstringliteral - 128)) | (1L << (Userdefinedcharacterliteral - 128)))) != 0)) {
					{
					State = 545;
					expressionlist();
					}
				}

				State = 548;
				Match(RightParen);
				}
				break;
			case 4:
				{
				State = 550;
				simpletypespecifier();
				State = 551;
				bracedinitlist();
				}
				break;
			case 5:
				{
				State = 553;
				typenamespecifier();
				State = 554;
				bracedinitlist();
				}
				break;
			case 6:
				{
				State = 556;
				Match(Dynamic_cast);
				State = 557;
				Match(Less);
				State = 558;
				thetypeid();
				State = 559;
				Match(Greater);
				State = 560;
				Match(LeftParen);
				State = 561;
				expression(0);
				State = 562;
				Match(RightParen);
				}
				break;
			case 7:
				{
				State = 564;
				Match(Static_cast);
				State = 565;
				Match(Less);
				State = 566;
				thetypeid();
				State = 567;
				Match(Greater);
				State = 568;
				Match(LeftParen);
				State = 569;
				expression(0);
				State = 570;
				Match(RightParen);
				}
				break;
			case 8:
				{
				State = 572;
				Match(Reinterpret_cast);
				State = 573;
				Match(Less);
				State = 574;
				thetypeid();
				State = 575;
				Match(Greater);
				State = 576;
				Match(LeftParen);
				State = 577;
				expression(0);
				State = 578;
				Match(RightParen);
				}
				break;
			case 9:
				{
				State = 580;
				Match(Const_cast);
				State = 581;
				Match(Less);
				State = 582;
				thetypeid();
				State = 583;
				Match(Greater);
				State = 584;
				Match(LeftParen);
				State = 585;
				expression(0);
				State = 586;
				Match(RightParen);
				}
				break;
			case 10:
				{
				State = 588;
				typeidofthetypeid();
				State = 589;
				Match(LeftParen);
				State = 590;
				expression(0);
				State = 591;
				Match(RightParen);
				}
				break;
			case 11:
				{
				State = 593;
				typeidofthetypeid();
				State = 594;
				Match(LeftParen);
				State = 595;
				thetypeid();
				State = 596;
				Match(RightParen);
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 640;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,29,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 638;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,28,Context) ) {
					case 1:
						{
						_localctx = new PostfixexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_postfixexpression);
						State = 600;
						if (!(Precpred(Context, 19))) throw new FailedPredicateException(this, "Precpred(Context, 19)");
						State = 601;
						Match(LeftBracket);
						State = 602;
						expression(0);
						State = 603;
						Match(RightBracket);
						}
						break;
					case 2:
						{
						_localctx = new PostfixexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_postfixexpression);
						State = 605;
						if (!(Precpred(Context, 18))) throw new FailedPredicateException(this, "Precpred(Context, 18)");
						State = 606;
						Match(LeftBracket);
						State = 607;
						bracedinitlist();
						State = 608;
						Match(RightBracket);
						}
						break;
					case 3:
						{
						_localctx = new PostfixexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_postfixexpression);
						State = 610;
						if (!(Precpred(Context, 17))) throw new FailedPredicateException(this, "Precpred(Context, 17)");
						State = 611;
						Match(LeftParen);
						State = 613;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << Alignof) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Const_cast) | (1L << Decltype) | (1L << Delete) | (1L << Double) | (1L << Dynamic_cast) | (1L << False) | (1L << Float) | (1L << Int) | (1L << Long) | (1L << New) | (1L << Noexcept) | (1L << Nullptr) | (1L << Operator) | (1L << Reinterpret_cast) | (1L << Short) | (1L << Signed) | (1L << Sizeof))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Static_cast - 64)) | (1L << (This - 64)) | (1L << (Throw - 64)) | (1L << (True - 64)) | (1L << (Typeid_ - 64)) | (1L << (Typename_ - 64)) | (1L << (Unsigned - 64)) | (1L << (Void - 64)) | (1L << (Wchar - 64)) | (1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (LeftBrace - 64)) | (1L << (Plus - 64)) | (1L << (Minus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (Or - 64)) | (1L << (Tilde - 64)) | (1L << (PlusPlus - 64)) | (1L << (MinusMinus - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (Doublecolon - 128)) | (1L << (Identifier - 128)) | (1L << (Integerliteral - 128)) | (1L << (Characterliteral - 128)) | (1L << (Floatingliteral - 128)) | (1L << (Stringliteral - 128)) | (1L << (Userdefinedintegerliteral - 128)) | (1L << (Userdefinedfloatingliteral - 128)) | (1L << (Userdefinedstringliteral - 128)) | (1L << (Userdefinedcharacterliteral - 128)))) != 0)) {
							{
							State = 612;
							expressionlist();
							}
						}

						State = 615;
						Match(RightParen);
						}
						break;
					case 4:
						{
						_localctx = new PostfixexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_postfixexpression);
						State = 616;
						if (!(Precpred(Context, 12))) throw new FailedPredicateException(this, "Precpred(Context, 12)");
						State = 617;
						Match(Dot);
						State = 619;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if (_la==Template) {
							{
							State = 618;
							Match(Template);
							}
						}

						State = 621;
						idexpression();
						}
						break;
					case 5:
						{
						_localctx = new PostfixexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_postfixexpression);
						State = 622;
						if (!(Precpred(Context, 11))) throw new FailedPredicateException(this, "Precpred(Context, 11)");
						State = 623;
						Match(Arrow);
						State = 625;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if (_la==Template) {
							{
							State = 624;
							Match(Template);
							}
						}

						State = 627;
						idexpression();
						}
						break;
					case 6:
						{
						_localctx = new PostfixexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_postfixexpression);
						State = 628;
						if (!(Precpred(Context, 10))) throw new FailedPredicateException(this, "Precpred(Context, 10)");
						State = 629;
						Match(Dot);
						State = 630;
						pseudodestructorname();
						}
						break;
					case 7:
						{
						_localctx = new PostfixexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_postfixexpression);
						State = 631;
						if (!(Precpred(Context, 9))) throw new FailedPredicateException(this, "Precpred(Context, 9)");
						State = 632;
						Match(Arrow);
						State = 633;
						pseudodestructorname();
						}
						break;
					case 8:
						{
						_localctx = new PostfixexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_postfixexpression);
						State = 634;
						if (!(Precpred(Context, 8))) throw new FailedPredicateException(this, "Precpred(Context, 8)");
						State = 635;
						Match(PlusPlus);
						}
						break;
					case 9:
						{
						_localctx = new PostfixexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_postfixexpression);
						State = 636;
						if (!(Precpred(Context, 7))) throw new FailedPredicateException(this, "Precpred(Context, 7)");
						State = 637;
						Match(MinusMinus);
						}
						break;
					}
					} 
				}
				State = 642;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,29,Context);
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

	public partial class TypeidofexprContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Typeid_() { return GetToken(CPP14Parser.Typeid_, 0); }
		public TypeidofexprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeidofexpr; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTypeidofexpr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTypeidofexpr(this);
		}
	}

	[RuleVersion(0)]
	public TypeidofexprContext typeidofexpr() {
		TypeidofexprContext _localctx = new TypeidofexprContext(Context, State);
		EnterRule(_localctx, 32, RULE_typeidofexpr);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 643;
			Match(Typeid_);
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

	public partial class TypeidofthetypeidContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Typeid_() { return GetToken(CPP14Parser.Typeid_, 0); }
		public TypeidofthetypeidContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeidofthetypeid; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTypeidofthetypeid(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTypeidofthetypeid(this);
		}
	}

	[RuleVersion(0)]
	public TypeidofthetypeidContext typeidofthetypeid() {
		TypeidofthetypeidContext _localctx = new TypeidofthetypeidContext(Context, State);
		EnterRule(_localctx, 34, RULE_typeidofthetypeid);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 645;
			Match(Typeid_);
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

	public partial class ExpressionlistContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public InitializerlistContext initializerlist() {
			return GetRuleContext<InitializerlistContext>(0);
		}
		public ExpressionlistContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expressionlist; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterExpressionlist(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitExpressionlist(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionlistContext expressionlist() {
		ExpressionlistContext _localctx = new ExpressionlistContext(Context, State);
		EnterRule(_localctx, 36, RULE_expressionlist);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 647;
			initializerlist(0);
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

	public partial class PseudodestructornameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ThetypenameContext[] thetypename() {
			return GetRuleContexts<ThetypenameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ThetypenameContext thetypename(int i) {
			return GetRuleContext<ThetypenameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Doublecolon() { return GetToken(CPP14Parser.Doublecolon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Tilde() { return GetToken(CPP14Parser.Tilde, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NestednamespecifierContext nestednamespecifier() {
			return GetRuleContext<NestednamespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Template() { return GetToken(CPP14Parser.Template, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public SimpletemplateidContext simpletemplateid() {
			return GetRuleContext<SimpletemplateidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DecltypespecifierContext decltypespecifier() {
			return GetRuleContext<DecltypespecifierContext>(0);
		}
		public PseudodestructornameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_pseudodestructorname; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterPseudodestructorname(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitPseudodestructorname(this);
		}
	}

	[RuleVersion(0)]
	public PseudodestructornameContext pseudodestructorname() {
		PseudodestructornameContext _localctx = new PseudodestructornameContext(Context, State);
		EnterRule(_localctx, 38, RULE_pseudodestructorname);
		int _la;
		try {
			State = 671;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,32,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 650;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,30,Context) ) {
				case 1:
					{
					State = 649;
					nestednamespecifier(0);
					}
					break;
				}
				State = 652;
				thetypename();
				State = 653;
				Match(Doublecolon);
				State = 654;
				Match(Tilde);
				State = 655;
				thetypename();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 657;
				nestednamespecifier(0);
				State = 658;
				Match(Template);
				State = 659;
				simpletemplateid();
				State = 660;
				Match(Doublecolon);
				State = 661;
				Match(Tilde);
				State = 662;
				thetypename();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 665;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Decltype || _la==Doublecolon || _la==Identifier) {
					{
					State = 664;
					nestednamespecifier(0);
					}
				}

				State = 667;
				Match(Tilde);
				State = 668;
				thetypename();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 669;
				Match(Tilde);
				State = 670;
				decltypespecifier();
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

	public partial class UnaryexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PostfixexpressionContext postfixexpression() {
			return GetRuleContext<PostfixexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PlusPlus() { return GetToken(CPP14Parser.PlusPlus, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public CastexpressionContext castexpression() {
			return GetRuleContext<CastexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MinusMinus() { return GetToken(CPP14Parser.MinusMinus, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public UnaryoperatorContext unaryoperator() {
			return GetRuleContext<UnaryoperatorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Sizeof() { return GetToken(CPP14Parser.Sizeof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public UnaryexpressionContext unaryexpression() {
			return GetRuleContext<UnaryexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ThetypeidContext thetypeid() {
			return GetRuleContext<ThetypeidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ellipsis() { return GetToken(CPP14Parser.Ellipsis, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Alignof() { return GetToken(CPP14Parser.Alignof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NoexceptexpressionContext noexceptexpression() {
			return GetRuleContext<NoexceptexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NewexpressionContext newexpression() {
			return GetRuleContext<NewexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeleteexpressionContext deleteexpression() {
			return GetRuleContext<DeleteexpressionContext>(0);
		}
		public UnaryexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unaryexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterUnaryexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitUnaryexpression(this);
		}
	}

	[RuleVersion(0)]
	public UnaryexpressionContext unaryexpression() {
		UnaryexpressionContext _localctx = new UnaryexpressionContext(Context, State);
		EnterRule(_localctx, 40, RULE_unaryexpression);
		try {
			State = 701;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,33,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 673;
				postfixexpression(0);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 674;
				Match(PlusPlus);
				State = 675;
				castexpression();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 676;
				Match(MinusMinus);
				State = 677;
				castexpression();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 678;
				unaryoperator();
				State = 679;
				castexpression();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 681;
				Match(Sizeof);
				State = 682;
				unaryexpression();
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 683;
				Match(Sizeof);
				State = 684;
				Match(LeftParen);
				State = 685;
				thetypeid();
				State = 686;
				Match(RightParen);
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 688;
				Match(Sizeof);
				State = 689;
				Match(Ellipsis);
				State = 690;
				Match(LeftParen);
				State = 691;
				Match(Identifier);
				State = 692;
				Match(RightParen);
				}
				break;
			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 693;
				Match(Alignof);
				State = 694;
				Match(LeftParen);
				State = 695;
				thetypeid();
				State = 696;
				Match(RightParen);
				}
				break;
			case 9:
				EnterOuterAlt(_localctx, 9);
				{
				State = 698;
				noexceptexpression();
				}
				break;
			case 10:
				EnterOuterAlt(_localctx, 10);
				{
				State = 699;
				newexpression();
				}
				break;
			case 11:
				EnterOuterAlt(_localctx, 11);
				{
				State = 700;
				deleteexpression();
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

	public partial class UnaryoperatorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Or() { return GetToken(CPP14Parser.Or, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Star() { return GetToken(CPP14Parser.Star, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode And() { return GetToken(CPP14Parser.And, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Plus() { return GetToken(CPP14Parser.Plus, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Tilde() { return GetToken(CPP14Parser.Tilde, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Minus() { return GetToken(CPP14Parser.Minus, 0); }
		public UnaryoperatorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unaryoperator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterUnaryoperator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitUnaryoperator(this);
		}
	}

	[RuleVersion(0)]
	public UnaryoperatorContext unaryoperator() {
		UnaryoperatorContext _localctx = new UnaryoperatorContext(Context, State);
		EnterRule(_localctx, 42, RULE_unaryoperator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 703;
			_la = TokenStream.LA(1);
			if ( !(_la==T__0 || _la==T__1 || ((((_la - 90)) & ~0x3f) == 0 && ((1L << (_la - 90)) & ((1L << (Plus - 90)) | (1L << (Minus - 90)) | (1L << (Star - 90)) | (1L << (And - 90)) | (1L << (Or - 90)) | (1L << (Tilde - 90)))) != 0)) ) {
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

	public partial class NewexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode New() { return GetToken(CPP14Parser.New, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NewtypeidContext newtypeid() {
			return GetRuleContext<NewtypeidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Doublecolon() { return GetToken(CPP14Parser.Doublecolon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NewplacementContext newplacement() {
			return GetRuleContext<NewplacementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NewinitializerContext newinitializer() {
			return GetRuleContext<NewinitializerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ThetypeidContext thetypeid() {
			return GetRuleContext<ThetypeidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		public NewexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_newexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterNewexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitNewexpression(this);
		}
	}

	[RuleVersion(0)]
	public NewexpressionContext newexpression() {
		NewexpressionContext _localctx = new NewexpressionContext(Context, State);
		EnterRule(_localctx, 44, RULE_newexpression);
		int _la;
		try {
			State = 729;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,40,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 706;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Doublecolon) {
					{
					State = 705;
					Match(Doublecolon);
					}
				}

				State = 708;
				Match(New);
				State = 710;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LeftParen) {
					{
					State = 709;
					newplacement();
					}
				}

				State = 712;
				newtypeid();
				State = 714;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,36,Context) ) {
				case 1:
					{
					State = 713;
					newinitializer();
					}
					break;
				}
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 717;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Doublecolon) {
					{
					State = 716;
					Match(Doublecolon);
					}
				}

				State = 719;
				Match(New);
				State = 721;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,38,Context) ) {
				case 1:
					{
					State = 720;
					newplacement();
					}
					break;
				}
				State = 723;
				Match(LeftParen);
				State = 724;
				thetypeid();
				State = 725;
				Match(RightParen);
				State = 727;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,39,Context) ) {
				case 1:
					{
					State = 726;
					newinitializer();
					}
					break;
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

	public partial class NewplacementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionlistContext expressionlist() {
			return GetRuleContext<ExpressionlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		public NewplacementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_newplacement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterNewplacement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitNewplacement(this);
		}
	}

	[RuleVersion(0)]
	public NewplacementContext newplacement() {
		NewplacementContext _localctx = new NewplacementContext(Context, State);
		EnterRule(_localctx, 46, RULE_newplacement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 731;
			Match(LeftParen);
			State = 732;
			expressionlist();
			State = 733;
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

	public partial class NewtypeidContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TypespecifierseqContext typespecifierseq() {
			return GetRuleContext<TypespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NewdeclaratorContext newdeclarator() {
			return GetRuleContext<NewdeclaratorContext>(0);
		}
		public NewtypeidContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_newtypeid; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterNewtypeid(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitNewtypeid(this);
		}
	}

	[RuleVersion(0)]
	public NewtypeidContext newtypeid() {
		NewtypeidContext _localctx = new NewtypeidContext(Context, State);
		EnterRule(_localctx, 48, RULE_newtypeid);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 735;
			typespecifierseq();
			State = 737;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,41,Context) ) {
			case 1:
				{
				State = 736;
				newdeclarator();
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

	public partial class NewdeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PtroperatorContext ptroperator() {
			return GetRuleContext<PtroperatorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NewdeclaratorContext newdeclarator() {
			return GetRuleContext<NewdeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NoptrnewdeclaratorContext noptrnewdeclarator() {
			return GetRuleContext<NoptrnewdeclaratorContext>(0);
		}
		public NewdeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_newdeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterNewdeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitNewdeclarator(this);
		}
	}

	[RuleVersion(0)]
	public NewdeclaratorContext newdeclarator() {
		NewdeclaratorContext _localctx = new NewdeclaratorContext(Context, State);
		EnterRule(_localctx, 50, RULE_newdeclarator);
		try {
			State = 744;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__2:
			case Decltype:
			case Star:
			case And:
			case Doublecolon:
			case Identifier:
				EnterOuterAlt(_localctx, 1);
				{
				State = 739;
				ptroperator();
				State = 741;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,42,Context) ) {
				case 1:
					{
					State = 740;
					newdeclarator();
					}
					break;
				}
				}
				break;
			case LeftBracket:
				EnterOuterAlt(_localctx, 2);
				{
				State = 743;
				noptrnewdeclarator(0);
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

	public partial class NoptrnewdeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBracket() { return GetToken(CPP14Parser.LeftBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBracket() { return GetToken(CPP14Parser.RightBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NoptrnewdeclaratorContext noptrnewdeclarator() {
			return GetRuleContext<NoptrnewdeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConstantexpressionContext constantexpression() {
			return GetRuleContext<ConstantexpressionContext>(0);
		}
		public NoptrnewdeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_noptrnewdeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterNoptrnewdeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitNoptrnewdeclarator(this);
		}
	}

	[RuleVersion(0)]
	public NoptrnewdeclaratorContext noptrnewdeclarator() {
		return noptrnewdeclarator(0);
	}

	private NoptrnewdeclaratorContext noptrnewdeclarator(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		NoptrnewdeclaratorContext _localctx = new NoptrnewdeclaratorContext(Context, _parentState);
		NoptrnewdeclaratorContext _prevctx = _localctx;
		int _startState = 52;
		EnterRecursionRule(_localctx, 52, RULE_noptrnewdeclarator, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 747;
			Match(LeftBracket);
			State = 748;
			expression(0);
			State = 749;
			Match(RightBracket);
			State = 751;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,44,Context) ) {
			case 1:
				{
				State = 750;
				attributespecifierseq(0);
				}
				break;
			}
			}
			Context.Stop = TokenStream.LT(-1);
			State = 762;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,46,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new NoptrnewdeclaratorContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_noptrnewdeclarator);
					State = 753;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 754;
					Match(LeftBracket);
					State = 755;
					constantexpression();
					State = 756;
					Match(RightBracket);
					State = 758;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,45,Context) ) {
					case 1:
						{
						State = 757;
						attributespecifierseq(0);
						}
						break;
					}
					}
					} 
				}
				State = 764;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,46,Context);
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

	public partial class NewinitializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionlistContext expressionlist() {
			return GetRuleContext<ExpressionlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BracedinitlistContext bracedinitlist() {
			return GetRuleContext<BracedinitlistContext>(0);
		}
		public NewinitializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_newinitializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterNewinitializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitNewinitializer(this);
		}
	}

	[RuleVersion(0)]
	public NewinitializerContext newinitializer() {
		NewinitializerContext _localctx = new NewinitializerContext(Context, State);
		EnterRule(_localctx, 54, RULE_newinitializer);
		int _la;
		try {
			State = 771;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case LeftParen:
				EnterOuterAlt(_localctx, 1);
				{
				State = 765;
				Match(LeftParen);
				State = 767;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << Alignof) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Const_cast) | (1L << Decltype) | (1L << Delete) | (1L << Double) | (1L << Dynamic_cast) | (1L << False) | (1L << Float) | (1L << Int) | (1L << Long) | (1L << New) | (1L << Noexcept) | (1L << Nullptr) | (1L << Operator) | (1L << Reinterpret_cast) | (1L << Short) | (1L << Signed) | (1L << Sizeof))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Static_cast - 64)) | (1L << (This - 64)) | (1L << (Throw - 64)) | (1L << (True - 64)) | (1L << (Typeid_ - 64)) | (1L << (Typename_ - 64)) | (1L << (Unsigned - 64)) | (1L << (Void - 64)) | (1L << (Wchar - 64)) | (1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (LeftBrace - 64)) | (1L << (Plus - 64)) | (1L << (Minus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (Or - 64)) | (1L << (Tilde - 64)) | (1L << (PlusPlus - 64)) | (1L << (MinusMinus - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (Doublecolon - 128)) | (1L << (Identifier - 128)) | (1L << (Integerliteral - 128)) | (1L << (Characterliteral - 128)) | (1L << (Floatingliteral - 128)) | (1L << (Stringliteral - 128)) | (1L << (Userdefinedintegerliteral - 128)) | (1L << (Userdefinedfloatingliteral - 128)) | (1L << (Userdefinedstringliteral - 128)) | (1L << (Userdefinedcharacterliteral - 128)))) != 0)) {
					{
					State = 766;
					expressionlist();
					}
				}

				State = 769;
				Match(RightParen);
				}
				break;
			case LeftBrace:
				EnterOuterAlt(_localctx, 2);
				{
				State = 770;
				bracedinitlist();
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

	public partial class DeleteexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Delete() { return GetToken(CPP14Parser.Delete, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public CastexpressionContext castexpression() {
			return GetRuleContext<CastexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Doublecolon() { return GetToken(CPP14Parser.Doublecolon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBracket() { return GetToken(CPP14Parser.LeftBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBracket() { return GetToken(CPP14Parser.RightBracket, 0); }
		public DeleteexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_deleteexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterDeleteexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitDeleteexpression(this);
		}
	}

	[RuleVersion(0)]
	public DeleteexpressionContext deleteexpression() {
		DeleteexpressionContext _localctx = new DeleteexpressionContext(Context, State);
		EnterRule(_localctx, 56, RULE_deleteexpression);
		int _la;
		try {
			State = 785;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,51,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 774;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Doublecolon) {
					{
					State = 773;
					Match(Doublecolon);
					}
				}

				State = 776;
				Match(Delete);
				State = 777;
				castexpression();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 779;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Doublecolon) {
					{
					State = 778;
					Match(Doublecolon);
					}
				}

				State = 781;
				Match(Delete);
				State = 782;
				Match(LeftBracket);
				State = 783;
				Match(RightBracket);
				State = 784;
				castexpression();
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

	public partial class NoexceptexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Noexcept() { return GetToken(CPP14Parser.Noexcept, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		public NoexceptexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_noexceptexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterNoexceptexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitNoexceptexpression(this);
		}
	}

	[RuleVersion(0)]
	public NoexceptexpressionContext noexceptexpression() {
		NoexceptexpressionContext _localctx = new NoexceptexpressionContext(Context, State);
		EnterRule(_localctx, 58, RULE_noexceptexpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 787;
			Match(Noexcept);
			State = 788;
			Match(LeftParen);
			State = 789;
			expression(0);
			State = 790;
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

	public partial class CastexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnaryexpressionContext unaryexpression() {
			return GetRuleContext<UnaryexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ThetypeidContext thetypeid() {
			return GetRuleContext<ThetypeidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public CastexpressionContext castexpression() {
			return GetRuleContext<CastexpressionContext>(0);
		}
		public CastexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_castexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterCastexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitCastexpression(this);
		}
	}

	[RuleVersion(0)]
	public CastexpressionContext castexpression() {
		CastexpressionContext _localctx = new CastexpressionContext(Context, State);
		EnterRule(_localctx, 60, RULE_castexpression);
		try {
			State = 798;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,52,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 792;
				unaryexpression();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 793;
				Match(LeftParen);
				State = 794;
				thetypeid();
				State = 795;
				Match(RightParen);
				State = 796;
				castexpression();
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

	public partial class PmexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public CastexpressionContext castexpression() {
			return GetRuleContext<CastexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PmexpressionContext pmexpression() {
			return GetRuleContext<PmexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DotStar() { return GetToken(CPP14Parser.DotStar, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ArrowStar() { return GetToken(CPP14Parser.ArrowStar, 0); }
		public PmexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_pmexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterPmexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitPmexpression(this);
		}
	}

	[RuleVersion(0)]
	public PmexpressionContext pmexpression() {
		return pmexpression(0);
	}

	private PmexpressionContext pmexpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		PmexpressionContext _localctx = new PmexpressionContext(Context, _parentState);
		PmexpressionContext _prevctx = _localctx;
		int _startState = 62;
		EnterRecursionRule(_localctx, 62, RULE_pmexpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 801;
			castexpression();
			}
			Context.Stop = TokenStream.LT(-1);
			State = 811;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,54,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 809;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,53,Context) ) {
					case 1:
						{
						_localctx = new PmexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_pmexpression);
						State = 803;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 804;
						Match(DotStar);
						State = 805;
						castexpression();
						}
						break;
					case 2:
						{
						_localctx = new PmexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_pmexpression);
						State = 806;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 807;
						Match(ArrowStar);
						State = 808;
						castexpression();
						}
						break;
					}
					} 
				}
				State = 813;
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
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class MultiplicativeexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PmexpressionContext pmexpression() {
			return GetRuleContext<PmexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MultiplicativeexpressionContext multiplicativeexpression() {
			return GetRuleContext<MultiplicativeexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Star() { return GetToken(CPP14Parser.Star, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Div() { return GetToken(CPP14Parser.Div, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Mod() { return GetToken(CPP14Parser.Mod, 0); }
		public MultiplicativeexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_multiplicativeexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterMultiplicativeexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitMultiplicativeexpression(this);
		}
	}

	[RuleVersion(0)]
	public MultiplicativeexpressionContext multiplicativeexpression() {
		return multiplicativeexpression(0);
	}

	private MultiplicativeexpressionContext multiplicativeexpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		MultiplicativeexpressionContext _localctx = new MultiplicativeexpressionContext(Context, _parentState);
		MultiplicativeexpressionContext _prevctx = _localctx;
		int _startState = 64;
		EnterRecursionRule(_localctx, 64, RULE_multiplicativeexpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 815;
			pmexpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 828;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,56,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 826;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,55,Context) ) {
					case 1:
						{
						_localctx = new MultiplicativeexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_multiplicativeexpression);
						State = 817;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 818;
						Match(Star);
						State = 819;
						pmexpression(0);
						}
						break;
					case 2:
						{
						_localctx = new MultiplicativeexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_multiplicativeexpression);
						State = 820;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 821;
						Match(Div);
						State = 822;
						pmexpression(0);
						}
						break;
					case 3:
						{
						_localctx = new MultiplicativeexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_multiplicativeexpression);
						State = 823;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 824;
						Match(Mod);
						State = 825;
						pmexpression(0);
						}
						break;
					}
					} 
				}
				State = 830;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,56,Context);
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

	public partial class AdditiveexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public MultiplicativeexpressionContext multiplicativeexpression() {
			return GetRuleContext<MultiplicativeexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AdditiveexpressionContext additiveexpression() {
			return GetRuleContext<AdditiveexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Plus() { return GetToken(CPP14Parser.Plus, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Minus() { return GetToken(CPP14Parser.Minus, 0); }
		public AdditiveexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_additiveexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAdditiveexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAdditiveexpression(this);
		}
	}

	[RuleVersion(0)]
	public AdditiveexpressionContext additiveexpression() {
		return additiveexpression(0);
	}

	private AdditiveexpressionContext additiveexpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		AdditiveexpressionContext _localctx = new AdditiveexpressionContext(Context, _parentState);
		AdditiveexpressionContext _prevctx = _localctx;
		int _startState = 66;
		EnterRecursionRule(_localctx, 66, RULE_additiveexpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 832;
			multiplicativeexpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 842;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,58,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 840;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,57,Context) ) {
					case 1:
						{
						_localctx = new AdditiveexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_additiveexpression);
						State = 834;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 835;
						Match(Plus);
						State = 836;
						multiplicativeexpression(0);
						}
						break;
					case 2:
						{
						_localctx = new AdditiveexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_additiveexpression);
						State = 837;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 838;
						Match(Minus);
						State = 839;
						multiplicativeexpression(0);
						}
						break;
					}
					} 
				}
				State = 844;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,58,Context);
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

	public partial class ShiftexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AdditiveexpressionContext additiveexpression() {
			return GetRuleContext<AdditiveexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ShiftexpressionContext shiftexpression() {
			return GetRuleContext<ShiftexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ShiftoperatorContext shiftoperator() {
			return GetRuleContext<ShiftoperatorContext>(0);
		}
		public ShiftexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_shiftexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterShiftexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitShiftexpression(this);
		}
	}

	[RuleVersion(0)]
	public ShiftexpressionContext shiftexpression() {
		return shiftexpression(0);
	}

	private ShiftexpressionContext shiftexpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ShiftexpressionContext _localctx = new ShiftexpressionContext(Context, _parentState);
		ShiftexpressionContext _prevctx = _localctx;
		int _startState = 68;
		EnterRecursionRule(_localctx, 68, RULE_shiftexpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 846;
			additiveexpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 854;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,59,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new ShiftexpressionContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_shiftexpression);
					State = 848;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 849;
					shiftoperator();
					State = 850;
					additiveexpression(0);
					}
					} 
				}
				State = 856;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,59,Context);
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

	public partial class ShiftoperatorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightShift() { return GetToken(CPP14Parser.RightShift, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftShift() { return GetToken(CPP14Parser.LeftShift, 0); }
		public ShiftoperatorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_shiftoperator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterShiftoperator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitShiftoperator(this);
		}
	}

	[RuleVersion(0)]
	public ShiftoperatorContext shiftoperator() {
		ShiftoperatorContext _localctx = new ShiftoperatorContext(Context, State);
		EnterRule(_localctx, 70, RULE_shiftoperator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 857;
			_la = TokenStream.LA(1);
			if ( !(_la==LeftShift || _la==RightShift) ) {
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

	public partial class RelationalexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ShiftexpressionContext shiftexpression() {
			return GetRuleContext<ShiftexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public RelationalexpressionContext relationalexpression() {
			return GetRuleContext<RelationalexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Less() { return GetToken(CPP14Parser.Less, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Greater() { return GetToken(CPP14Parser.Greater, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LessEqual() { return GetToken(CPP14Parser.LessEqual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GreaterEqual() { return GetToken(CPP14Parser.GreaterEqual, 0); }
		public RelationalexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_relationalexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterRelationalexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitRelationalexpression(this);
		}
	}

	[RuleVersion(0)]
	public RelationalexpressionContext relationalexpression() {
		return relationalexpression(0);
	}

	private RelationalexpressionContext relationalexpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		RelationalexpressionContext _localctx = new RelationalexpressionContext(Context, _parentState);
		RelationalexpressionContext _prevctx = _localctx;
		int _startState = 72;
		EnterRecursionRule(_localctx, 72, RULE_relationalexpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 860;
			shiftexpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 876;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,61,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 874;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,60,Context) ) {
					case 1:
						{
						_localctx = new RelationalexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_relationalexpression);
						State = 862;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 863;
						Match(Less);
						State = 864;
						shiftexpression(0);
						}
						break;
					case 2:
						{
						_localctx = new RelationalexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_relationalexpression);
						State = 865;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 866;
						Match(Greater);
						State = 867;
						shiftexpression(0);
						}
						break;
					case 3:
						{
						_localctx = new RelationalexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_relationalexpression);
						State = 868;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 869;
						Match(LessEqual);
						State = 870;
						shiftexpression(0);
						}
						break;
					case 4:
						{
						_localctx = new RelationalexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_relationalexpression);
						State = 871;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 872;
						Match(GreaterEqual);
						State = 873;
						shiftexpression(0);
						}
						break;
					}
					} 
				}
				State = 878;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,61,Context);
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

	public partial class EqualityexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public RelationalexpressionContext relationalexpression() {
			return GetRuleContext<RelationalexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EqualityexpressionContext equalityexpression() {
			return GetRuleContext<EqualityexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Equal() { return GetToken(CPP14Parser.Equal, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NotEqual() { return GetToken(CPP14Parser.NotEqual, 0); }
		public EqualityexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_equalityexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterEqualityexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitEqualityexpression(this);
		}
	}

	[RuleVersion(0)]
	public EqualityexpressionContext equalityexpression() {
		return equalityexpression(0);
	}

	private EqualityexpressionContext equalityexpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		EqualityexpressionContext _localctx = new EqualityexpressionContext(Context, _parentState);
		EqualityexpressionContext _prevctx = _localctx;
		int _startState = 74;
		EnterRecursionRule(_localctx, 74, RULE_equalityexpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 880;
			relationalexpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 890;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,63,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 888;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,62,Context) ) {
					case 1:
						{
						_localctx = new EqualityexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_equalityexpression);
						State = 882;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 883;
						Match(Equal);
						State = 884;
						relationalexpression(0);
						}
						break;
					case 2:
						{
						_localctx = new EqualityexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_equalityexpression);
						State = 885;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 886;
						Match(NotEqual);
						State = 887;
						relationalexpression(0);
						}
						break;
					}
					} 
				}
				State = 892;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,63,Context);
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

	public partial class AndexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public EqualityexpressionContext equalityexpression() {
			return GetRuleContext<EqualityexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AndexpressionContext andexpression() {
			return GetRuleContext<AndexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode And() { return GetToken(CPP14Parser.And, 0); }
		public AndexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_andexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAndexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAndexpression(this);
		}
	}

	[RuleVersion(0)]
	public AndexpressionContext andexpression() {
		return andexpression(0);
	}

	private AndexpressionContext andexpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		AndexpressionContext _localctx = new AndexpressionContext(Context, _parentState);
		AndexpressionContext _prevctx = _localctx;
		int _startState = 76;
		EnterRecursionRule(_localctx, 76, RULE_andexpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 894;
			equalityexpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 901;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,64,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new AndexpressionContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_andexpression);
					State = 896;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 897;
					Match(And);
					State = 898;
					equalityexpression(0);
					}
					} 
				}
				State = 903;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,64,Context);
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

	public partial class ExclusiveorexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AndexpressionContext andexpression() {
			return GetRuleContext<AndexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExclusiveorexpressionContext exclusiveorexpression() {
			return GetRuleContext<ExclusiveorexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Caret() { return GetToken(CPP14Parser.Caret, 0); }
		public ExclusiveorexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exclusiveorexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterExclusiveorexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitExclusiveorexpression(this);
		}
	}

	[RuleVersion(0)]
	public ExclusiveorexpressionContext exclusiveorexpression() {
		return exclusiveorexpression(0);
	}

	private ExclusiveorexpressionContext exclusiveorexpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExclusiveorexpressionContext _localctx = new ExclusiveorexpressionContext(Context, _parentState);
		ExclusiveorexpressionContext _prevctx = _localctx;
		int _startState = 78;
		EnterRecursionRule(_localctx, 78, RULE_exclusiveorexpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 905;
			andexpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 912;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,65,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new ExclusiveorexpressionContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_exclusiveorexpression);
					State = 907;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 908;
					Match(Caret);
					State = 909;
					andexpression(0);
					}
					} 
				}
				State = 914;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,65,Context);
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

	public partial class InclusiveorexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExclusiveorexpressionContext exclusiveorexpression() {
			return GetRuleContext<ExclusiveorexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InclusiveorexpressionContext inclusiveorexpression() {
			return GetRuleContext<InclusiveorexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Or() { return GetToken(CPP14Parser.Or, 0); }
		public InclusiveorexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_inclusiveorexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterInclusiveorexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitInclusiveorexpression(this);
		}
	}

	[RuleVersion(0)]
	public InclusiveorexpressionContext inclusiveorexpression() {
		return inclusiveorexpression(0);
	}

	private InclusiveorexpressionContext inclusiveorexpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		InclusiveorexpressionContext _localctx = new InclusiveorexpressionContext(Context, _parentState);
		InclusiveorexpressionContext _prevctx = _localctx;
		int _startState = 80;
		EnterRecursionRule(_localctx, 80, RULE_inclusiveorexpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 916;
			exclusiveorexpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 923;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,66,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new InclusiveorexpressionContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_inclusiveorexpression);
					State = 918;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 919;
					Match(Or);
					State = 920;
					exclusiveorexpression(0);
					}
					} 
				}
				State = 925;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,66,Context);
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

	public partial class LogicalandexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public InclusiveorexpressionContext inclusiveorexpression() {
			return GetRuleContext<InclusiveorexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public LogicalandexpressionContext logicalandexpression() {
			return GetRuleContext<LogicalandexpressionContext>(0);
		}
		public LogicalandexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_logicalandexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterLogicalandexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitLogicalandexpression(this);
		}
	}

	[RuleVersion(0)]
	public LogicalandexpressionContext logicalandexpression() {
		return logicalandexpression(0);
	}

	private LogicalandexpressionContext logicalandexpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		LogicalandexpressionContext _localctx = new LogicalandexpressionContext(Context, _parentState);
		LogicalandexpressionContext _prevctx = _localctx;
		int _startState = 82;
		EnterRecursionRule(_localctx, 82, RULE_logicalandexpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 927;
			inclusiveorexpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 937;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,68,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 935;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,67,Context) ) {
					case 1:
						{
						_localctx = new LogicalandexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_logicalandexpression);
						State = 929;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 930;
						Match(T__2);
						State = 931;
						inclusiveorexpression(0);
						}
						break;
					case 2:
						{
						_localctx = new LogicalandexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_logicalandexpression);
						State = 932;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 933;
						Match(T__3);
						State = 934;
						inclusiveorexpression(0);
						}
						break;
					}
					} 
				}
				State = 939;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,68,Context);
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

	public partial class LogicalorexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public LogicalandexpressionContext logicalandexpression() {
			return GetRuleContext<LogicalandexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public LogicalorexpressionContext logicalorexpression() {
			return GetRuleContext<LogicalorexpressionContext>(0);
		}
		public LogicalorexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_logicalorexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterLogicalorexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitLogicalorexpression(this);
		}
	}

	[RuleVersion(0)]
	public LogicalorexpressionContext logicalorexpression() {
		return logicalorexpression(0);
	}

	private LogicalorexpressionContext logicalorexpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		LogicalorexpressionContext _localctx = new LogicalorexpressionContext(Context, _parentState);
		LogicalorexpressionContext _prevctx = _localctx;
		int _startState = 84;
		EnterRecursionRule(_localctx, 84, RULE_logicalorexpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 941;
			logicalandexpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 951;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,70,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 949;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,69,Context) ) {
					case 1:
						{
						_localctx = new LogicalorexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_logicalorexpression);
						State = 943;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 944;
						Match(T__4);
						State = 945;
						logicalandexpression(0);
						}
						break;
					case 2:
						{
						_localctx = new LogicalorexpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_logicalorexpression);
						State = 946;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 947;
						Match(T__5);
						State = 948;
						logicalandexpression(0);
						}
						break;
					}
					} 
				}
				State = 953;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,70,Context);
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

	public partial class ConditionalexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public LogicalorexpressionContext logicalorexpression() {
			return GetRuleContext<LogicalorexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Question() { return GetToken(CPP14Parser.Question, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(CPP14Parser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentexpressionContext assignmentexpression() {
			return GetRuleContext<AssignmentexpressionContext>(0);
		}
		public ConditionalexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_conditionalexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterConditionalexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitConditionalexpression(this);
		}
	}

	[RuleVersion(0)]
	public ConditionalexpressionContext conditionalexpression() {
		ConditionalexpressionContext _localctx = new ConditionalexpressionContext(Context, State);
		EnterRule(_localctx, 86, RULE_conditionalexpression);
		try {
			State = 961;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,71,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 954;
				logicalorexpression(0);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 955;
				logicalorexpression(0);
				State = 956;
				Match(Question);
				State = 957;
				expression(0);
				State = 958;
				Match(Colon);
				State = 959;
				assignmentexpression();
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

	public partial class AssignmentexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ConditionalexpressionContext conditionalexpression() {
			return GetRuleContext<ConditionalexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public LogicalorexpressionContext logicalorexpression() {
			return GetRuleContext<LogicalorexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentoperatorContext assignmentoperator() {
			return GetRuleContext<AssignmentoperatorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InitializerclauseContext initializerclause() {
			return GetRuleContext<InitializerclauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ThrowexpressionContext throwexpression() {
			return GetRuleContext<ThrowexpressionContext>(0);
		}
		public AssignmentexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignmentexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAssignmentexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAssignmentexpression(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentexpressionContext assignmentexpression() {
		AssignmentexpressionContext _localctx = new AssignmentexpressionContext(Context, State);
		EnterRule(_localctx, 88, RULE_assignmentexpression);
		try {
			State = 969;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,72,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 963;
				conditionalexpression();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 964;
				logicalorexpression(0);
				State = 965;
				assignmentoperator();
				State = 966;
				initializerclause();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 968;
				throwexpression();
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

	public partial class AssignmentoperatorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Assign() { return GetToken(CPP14Parser.Assign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode StarAssign() { return GetToken(CPP14Parser.StarAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DivAssign() { return GetToken(CPP14Parser.DivAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ModAssign() { return GetToken(CPP14Parser.ModAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PlusAssign() { return GetToken(CPP14Parser.PlusAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MinusAssign() { return GetToken(CPP14Parser.MinusAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightShiftAssign() { return GetToken(CPP14Parser.RightShiftAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftShiftAssign() { return GetToken(CPP14Parser.LeftShiftAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AndAssign() { return GetToken(CPP14Parser.AndAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode XorAssign() { return GetToken(CPP14Parser.XorAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OrAssign() { return GetToken(CPP14Parser.OrAssign, 0); }
		public AssignmentoperatorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignmentoperator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAssignmentoperator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAssignmentoperator(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentoperatorContext assignmentoperator() {
		AssignmentoperatorContext _localctx = new AssignmentoperatorContext(Context, State);
		EnterRule(_localctx, 90, RULE_assignmentoperator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 971;
			_la = TokenStream.LA(1);
			if ( !(((((_la - 100)) & ~0x3f) == 0 && ((1L << (_la - 100)) & ((1L << (Assign - 100)) | (1L << (PlusAssign - 100)) | (1L << (MinusAssign - 100)) | (1L << (StarAssign - 100)) | (1L << (DivAssign - 100)) | (1L << (ModAssign - 100)) | (1L << (XorAssign - 100)) | (1L << (AndAssign - 100)) | (1L << (OrAssign - 100)) | (1L << (LeftShiftAssign - 100)) | (1L << (RightShiftAssign - 100)))) != 0)) ) {
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
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentexpressionContext assignmentexpression() {
			return GetRuleContext<AssignmentexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitExpression(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(Context, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 92;
		EnterRecursionRule(_localctx, 92, RULE_expression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 974;
			assignmentexpression();
			}
			Context.Stop = TokenStream.LT(-1);
			State = 981;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,73,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new ExpressionContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_expression);
					State = 976;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 977;
					Match(Comma);
					State = 978;
					assignmentexpression();
					}
					} 
				}
				State = 983;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,73,Context);
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

	public partial class ConstantexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ConditionalexpressionContext conditionalexpression() {
			return GetRuleContext<ConditionalexpressionContext>(0);
		}
		public ConstantexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constantexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterConstantexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitConstantexpression(this);
		}
	}

	[RuleVersion(0)]
	public ConstantexpressionContext constantexpression() {
		ConstantexpressionContext _localctx = new ConstantexpressionContext(Context, State);
		EnterRule(_localctx, 94, RULE_constantexpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 984;
			conditionalexpression();
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
		[System.Diagnostics.DebuggerNonUserCode] public LabeledstatementContext labeledstatement() {
			return GetRuleContext<LabeledstatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionstatementContext expressionstatement() {
			return GetRuleContext<ExpressionstatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CompoundstatementContext compoundstatement() {
			return GetRuleContext<CompoundstatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SelectionstatementContext selectionstatement() {
			return GetRuleContext<SelectionstatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IterationstatementContext iterationstatement() {
			return GetRuleContext<IterationstatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public JumpstatementContext jumpstatement() {
			return GetRuleContext<JumpstatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationstatementContext declarationstatement() {
			return GetRuleContext<DeclarationstatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TryblockContext tryblock() {
			return GetRuleContext<TryblockContext>(0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 96, RULE_statement);
		int _la;
		try {
			State = 1012;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,80,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 986;
				labeledstatement();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 988;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,74,Context) ) {
				case 1:
					{
					State = 987;
					attributespecifierseq(0);
					}
					break;
				}
				State = 990;
				expressionstatement();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 992;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 991;
					attributespecifierseq(0);
					}
				}

				State = 994;
				compoundstatement();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 996;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 995;
					attributespecifierseq(0);
					}
				}

				State = 998;
				selectionstatement();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1000;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 999;
					attributespecifierseq(0);
					}
				}

				State = 1002;
				iterationstatement();
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 1004;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 1003;
					attributespecifierseq(0);
					}
				}

				State = 1006;
				jumpstatement();
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 1007;
				declarationstatement();
				}
				break;
			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 1009;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 1008;
					attributespecifierseq(0);
					}
				}

				State = 1011;
				tryblock();
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

	public partial class LabeledstatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(CPP14Parser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Case() { return GetToken(CPP14Parser.Case, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantexpressionContext constantexpression() {
			return GetRuleContext<ConstantexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Default() { return GetToken(CPP14Parser.Default, 0); }
		public LabeledstatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_labeledstatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterLabeledstatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitLabeledstatement(this);
		}
	}

	[RuleVersion(0)]
	public LabeledstatementContext labeledstatement() {
		LabeledstatementContext _localctx = new LabeledstatementContext(Context, State);
		EnterRule(_localctx, 98, RULE_labeledstatement);
		int _la;
		try {
			State = 1034;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,84,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1015;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 1014;
					attributespecifierseq(0);
					}
				}

				State = 1017;
				Match(Identifier);
				State = 1018;
				Match(Colon);
				State = 1019;
				statement();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1021;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 1020;
					attributespecifierseq(0);
					}
				}

				State = 1023;
				Match(Case);
				State = 1024;
				constantexpression();
				State = 1025;
				Match(Colon);
				State = 1026;
				statement();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1029;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 1028;
					attributespecifierseq(0);
					}
				}

				State = 1031;
				Match(Default);
				State = 1032;
				Match(Colon);
				State = 1033;
				statement();
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

	public partial class ExpressionstatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CPP14Parser.Semi, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ExpressionstatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expressionstatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterExpressionstatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitExpressionstatement(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionstatementContext expressionstatement() {
		ExpressionstatementContext _localctx = new ExpressionstatementContext(Context, State);
		EnterRule(_localctx, 100, RULE_expressionstatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1037;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << Alignof) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Const_cast) | (1L << Decltype) | (1L << Delete) | (1L << Double) | (1L << Dynamic_cast) | (1L << False) | (1L << Float) | (1L << Int) | (1L << Long) | (1L << New) | (1L << Noexcept) | (1L << Nullptr) | (1L << Operator) | (1L << Reinterpret_cast) | (1L << Short) | (1L << Signed) | (1L << Sizeof))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Static_cast - 64)) | (1L << (This - 64)) | (1L << (Throw - 64)) | (1L << (True - 64)) | (1L << (Typeid_ - 64)) | (1L << (Typename_ - 64)) | (1L << (Unsigned - 64)) | (1L << (Void - 64)) | (1L << (Wchar - 64)) | (1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (Plus - 64)) | (1L << (Minus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (Or - 64)) | (1L << (Tilde - 64)) | (1L << (PlusPlus - 64)) | (1L << (MinusMinus - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (Doublecolon - 128)) | (1L << (Identifier - 128)) | (1L << (Integerliteral - 128)) | (1L << (Characterliteral - 128)) | (1L << (Floatingliteral - 128)) | (1L << (Stringliteral - 128)) | (1L << (Userdefinedintegerliteral - 128)) | (1L << (Userdefinedfloatingliteral - 128)) | (1L << (Userdefinedstringliteral - 128)) | (1L << (Userdefinedcharacterliteral - 128)))) != 0)) {
				{
				State = 1036;
				expression(0);
				}
			}

			State = 1039;
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

	public partial class CompoundstatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBrace() { return GetToken(CPP14Parser.LeftBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBrace() { return GetToken(CPP14Parser.RightBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementseqContext statementseq() {
			return GetRuleContext<StatementseqContext>(0);
		}
		public CompoundstatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compoundstatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterCompoundstatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitCompoundstatement(this);
		}
	}

	[RuleVersion(0)]
	public CompoundstatementContext compoundstatement() {
		CompoundstatementContext _localctx = new CompoundstatementContext(Context, State);
		EnterRule(_localctx, 102, RULE_compoundstatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1041;
			Match(LeftBrace);
			State = 1043;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << Alignas) | (1L << Alignof) | (1L << Asm) | (1L << Auto) | (1L << Bool) | (1L << Break) | (1L << Case) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Class) | (1L << Const) | (1L << Constexpr) | (1L << Const_cast) | (1L << Continue) | (1L << Decltype) | (1L << Default) | (1L << Delete) | (1L << Do) | (1L << Double) | (1L << Dynamic_cast) | (1L << Enum) | (1L << Explicit) | (1L << Extern) | (1L << False) | (1L << Float) | (1L << For) | (1L << Friend) | (1L << Goto) | (1L << If) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Mutable) | (1L << Namespace) | (1L << New) | (1L << Noexcept) | (1L << Nullptr) | (1L << Operator) | (1L << Register) | (1L << Reinterpret_cast) | (1L << Return) | (1L << Short) | (1L << Signed) | (1L << Sizeof) | (1L << Static) | (1L << Static_assert))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Static_cast - 64)) | (1L << (Struct - 64)) | (1L << (Switch - 64)) | (1L << (This - 64)) | (1L << (Thread_local - 64)) | (1L << (Throw - 64)) | (1L << (True - 64)) | (1L << (Try - 64)) | (1L << (Typedef - 64)) | (1L << (Typeid_ - 64)) | (1L << (Typename_ - 64)) | (1L << (Union - 64)) | (1L << (Unsigned - 64)) | (1L << (Using - 64)) | (1L << (Virtual - 64)) | (1L << (Void - 64)) | (1L << (Volatile - 64)) | (1L << (Wchar - 64)) | (1L << (While - 64)) | (1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (LeftBrace - 64)) | (1L << (Plus - 64)) | (1L << (Minus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (Or - 64)) | (1L << (Tilde - 64)) | (1L << (PlusPlus - 64)) | (1L << (MinusMinus - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (Doublecolon - 128)) | (1L << (Semi - 128)) | (1L << (Ellipsis - 128)) | (1L << (Identifier - 128)) | (1L << (Integerliteral - 128)) | (1L << (Characterliteral - 128)) | (1L << (Floatingliteral - 128)) | (1L << (Stringliteral - 128)) | (1L << (Userdefinedintegerliteral - 128)) | (1L << (Userdefinedfloatingliteral - 128)) | (1L << (Userdefinedstringliteral - 128)) | (1L << (Userdefinedcharacterliteral - 128)))) != 0)) {
				{
				State = 1042;
				statementseq(0);
				}
			}

			State = 1045;
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

	public partial class StatementseqContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementseqContext statementseq() {
			return GetRuleContext<StatementseqContext>(0);
		}
		public StatementseqContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statementseq; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterStatementseq(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitStatementseq(this);
		}
	}

	[RuleVersion(0)]
	public StatementseqContext statementseq() {
		return statementseq(0);
	}

	private StatementseqContext statementseq(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		StatementseqContext _localctx = new StatementseqContext(Context, _parentState);
		StatementseqContext _prevctx = _localctx;
		int _startState = 104;
		EnterRecursionRule(_localctx, 104, RULE_statementseq, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 1048;
			statement();
			}
			Context.Stop = TokenStream.LT(-1);
			State = 1054;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,87,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new StatementseqContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_statementseq);
					State = 1050;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 1051;
					statement();
					}
					} 
				}
				State = 1056;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,87,Context);
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

	public partial class SelectionstatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode If() { return GetToken(CPP14Parser.If, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConditionContext condition() {
			return GetRuleContext<ConditionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Else() { return GetToken(CPP14Parser.Else, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Switch() { return GetToken(CPP14Parser.Switch, 0); }
		public SelectionstatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_selectionstatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterSelectionstatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitSelectionstatement(this);
		}
	}

	[RuleVersion(0)]
	public SelectionstatementContext selectionstatement() {
		SelectionstatementContext _localctx = new SelectionstatementContext(Context, State);
		EnterRule(_localctx, 106, RULE_selectionstatement);
		try {
			State = 1077;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,88,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1057;
				Match(If);
				State = 1058;
				Match(LeftParen);
				State = 1059;
				condition();
				State = 1060;
				Match(RightParen);
				State = 1061;
				statement();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1063;
				Match(If);
				State = 1064;
				Match(LeftParen);
				State = 1065;
				condition();
				State = 1066;
				Match(RightParen);
				State = 1067;
				statement();
				State = 1068;
				Match(Else);
				State = 1069;
				statement();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1071;
				Match(Switch);
				State = 1072;
				Match(LeftParen);
				State = 1073;
				condition();
				State = 1074;
				Match(RightParen);
				State = 1075;
				statement();
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

	public partial class ConditionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclspecifierseqContext declspecifierseq() {
			return GetRuleContext<DeclspecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclaratorContext declarator() {
			return GetRuleContext<DeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Assign() { return GetToken(CPP14Parser.Assign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InitializerclauseContext initializerclause() {
			return GetRuleContext<InitializerclauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BracedinitlistContext bracedinitlist() {
			return GetRuleContext<BracedinitlistContext>(0);
		}
		public ConditionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_condition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterCondition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitCondition(this);
		}
	}

	[RuleVersion(0)]
	public ConditionContext condition() {
		ConditionContext _localctx = new ConditionContext(Context, State);
		EnterRule(_localctx, 108, RULE_condition);
		int _la;
		try {
			State = 1095;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,91,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1079;
				expression(0);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1081;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 1080;
					attributespecifierseq(0);
					}
				}

				State = 1083;
				declspecifierseq();
				State = 1084;
				declarator();
				State = 1085;
				Match(Assign);
				State = 1086;
				initializerclause();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1089;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 1088;
					attributespecifierseq(0);
					}
				}

				State = 1091;
				declspecifierseq();
				State = 1092;
				declarator();
				State = 1093;
				bracedinitlist();
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

	public partial class IterationstatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode While() { return GetToken(CPP14Parser.While, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConditionContext condition() {
			return GetRuleContext<ConditionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Do() { return GetToken(CPP14Parser.Do, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CPP14Parser.Semi, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode For() { return GetToken(CPP14Parser.For, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ForinitstatementContext forinitstatement() {
			return GetRuleContext<ForinitstatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ForrangedeclarationContext forrangedeclaration() {
			return GetRuleContext<ForrangedeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(CPP14Parser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ForrangeinitializerContext forrangeinitializer() {
			return GetRuleContext<ForrangeinitializerContext>(0);
		}
		public IterationstatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_iterationstatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterIterationstatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitIterationstatement(this);
		}
	}

	[RuleVersion(0)]
	public IterationstatementContext iterationstatement() {
		IterationstatementContext _localctx = new IterationstatementContext(Context, State);
		EnterRule(_localctx, 110, RULE_iterationstatement);
		int _la;
		try {
			State = 1132;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,94,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1097;
				Match(While);
				State = 1098;
				Match(LeftParen);
				State = 1099;
				condition();
				State = 1100;
				Match(RightParen);
				State = 1101;
				statement();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1103;
				Match(Do);
				State = 1104;
				statement();
				State = 1105;
				Match(While);
				State = 1106;
				Match(LeftParen);
				State = 1107;
				expression(0);
				State = 1108;
				Match(RightParen);
				State = 1109;
				Match(Semi);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1111;
				Match(For);
				State = 1112;
				Match(LeftParen);
				State = 1113;
				forinitstatement();
				State = 1115;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << Alignas) | (1L << Alignof) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Class) | (1L << Const) | (1L << Constexpr) | (1L << Const_cast) | (1L << Decltype) | (1L << Delete) | (1L << Double) | (1L << Dynamic_cast) | (1L << Enum) | (1L << Explicit) | (1L << Extern) | (1L << False) | (1L << Float) | (1L << Friend) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Mutable) | (1L << New) | (1L << Noexcept) | (1L << Nullptr) | (1L << Operator) | (1L << Register) | (1L << Reinterpret_cast) | (1L << Short) | (1L << Signed) | (1L << Sizeof) | (1L << Static))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Static_cast - 64)) | (1L << (Struct - 64)) | (1L << (This - 64)) | (1L << (Thread_local - 64)) | (1L << (Throw - 64)) | (1L << (True - 64)) | (1L << (Typedef - 64)) | (1L << (Typeid_ - 64)) | (1L << (Typename_ - 64)) | (1L << (Union - 64)) | (1L << (Unsigned - 64)) | (1L << (Virtual - 64)) | (1L << (Void - 64)) | (1L << (Volatile - 64)) | (1L << (Wchar - 64)) | (1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (Plus - 64)) | (1L << (Minus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (Or - 64)) | (1L << (Tilde - 64)) | (1L << (PlusPlus - 64)) | (1L << (MinusMinus - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (Doublecolon - 128)) | (1L << (Identifier - 128)) | (1L << (Integerliteral - 128)) | (1L << (Characterliteral - 128)) | (1L << (Floatingliteral - 128)) | (1L << (Stringliteral - 128)) | (1L << (Userdefinedintegerliteral - 128)) | (1L << (Userdefinedfloatingliteral - 128)) | (1L << (Userdefinedstringliteral - 128)) | (1L << (Userdefinedcharacterliteral - 128)))) != 0)) {
					{
					State = 1114;
					condition();
					}
				}

				State = 1117;
				Match(Semi);
				State = 1119;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << Alignof) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Const_cast) | (1L << Decltype) | (1L << Delete) | (1L << Double) | (1L << Dynamic_cast) | (1L << False) | (1L << Float) | (1L << Int) | (1L << Long) | (1L << New) | (1L << Noexcept) | (1L << Nullptr) | (1L << Operator) | (1L << Reinterpret_cast) | (1L << Short) | (1L << Signed) | (1L << Sizeof))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Static_cast - 64)) | (1L << (This - 64)) | (1L << (Throw - 64)) | (1L << (True - 64)) | (1L << (Typeid_ - 64)) | (1L << (Typename_ - 64)) | (1L << (Unsigned - 64)) | (1L << (Void - 64)) | (1L << (Wchar - 64)) | (1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (Plus - 64)) | (1L << (Minus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (Or - 64)) | (1L << (Tilde - 64)) | (1L << (PlusPlus - 64)) | (1L << (MinusMinus - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (Doublecolon - 128)) | (1L << (Identifier - 128)) | (1L << (Integerliteral - 128)) | (1L << (Characterliteral - 128)) | (1L << (Floatingliteral - 128)) | (1L << (Stringliteral - 128)) | (1L << (Userdefinedintegerliteral - 128)) | (1L << (Userdefinedfloatingliteral - 128)) | (1L << (Userdefinedstringliteral - 128)) | (1L << (Userdefinedcharacterliteral - 128)))) != 0)) {
					{
					State = 1118;
					expression(0);
					}
				}

				State = 1121;
				Match(RightParen);
				State = 1122;
				statement();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1124;
				Match(For);
				State = 1125;
				Match(LeftParen);
				State = 1126;
				forrangedeclaration();
				State = 1127;
				Match(Colon);
				State = 1128;
				forrangeinitializer();
				State = 1129;
				Match(RightParen);
				State = 1130;
				statement();
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

	public partial class ForinitstatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionstatementContext expressionstatement() {
			return GetRuleContext<ExpressionstatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SimpledeclarationContext simpledeclaration() {
			return GetRuleContext<SimpledeclarationContext>(0);
		}
		public ForinitstatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_forinitstatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterForinitstatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitForinitstatement(this);
		}
	}

	[RuleVersion(0)]
	public ForinitstatementContext forinitstatement() {
		ForinitstatementContext _localctx = new ForinitstatementContext(Context, State);
		EnterRule(_localctx, 112, RULE_forinitstatement);
		try {
			State = 1136;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,95,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1134;
				expressionstatement();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1135;
				simpledeclaration();
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

	public partial class ForrangedeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclspecifierseqContext declspecifierseq() {
			return GetRuleContext<DeclspecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclaratorContext declarator() {
			return GetRuleContext<DeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		public ForrangedeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_forrangedeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterForrangedeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitForrangedeclaration(this);
		}
	}

	[RuleVersion(0)]
	public ForrangedeclarationContext forrangedeclaration() {
		ForrangedeclarationContext _localctx = new ForrangedeclarationContext(Context, State);
		EnterRule(_localctx, 114, RULE_forrangedeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1139;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Alignas || _la==LeftBracket) {
				{
				State = 1138;
				attributespecifierseq(0);
				}
			}

			State = 1141;
			declspecifierseq();
			State = 1142;
			declarator();
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

	public partial class ForrangeinitializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BracedinitlistContext bracedinitlist() {
			return GetRuleContext<BracedinitlistContext>(0);
		}
		public ForrangeinitializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_forrangeinitializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterForrangeinitializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitForrangeinitializer(this);
		}
	}

	[RuleVersion(0)]
	public ForrangeinitializerContext forrangeinitializer() {
		ForrangeinitializerContext _localctx = new ForrangeinitializerContext(Context, State);
		EnterRule(_localctx, 116, RULE_forrangeinitializer);
		try {
			State = 1146;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__0:
			case T__1:
			case Alignof:
			case Auto:
			case Bool:
			case Char:
			case Char16:
			case Char32:
			case Const_cast:
			case Decltype:
			case Delete:
			case Double:
			case Dynamic_cast:
			case False:
			case Float:
			case Int:
			case Long:
			case New:
			case Noexcept:
			case Nullptr:
			case Operator:
			case Reinterpret_cast:
			case Short:
			case Signed:
			case Sizeof:
			case Static_cast:
			case This:
			case Throw:
			case True:
			case Typeid_:
			case Typename_:
			case Unsigned:
			case Void:
			case Wchar:
			case LeftParen:
			case LeftBracket:
			case Plus:
			case Minus:
			case Star:
			case And:
			case Or:
			case Tilde:
			case PlusPlus:
			case MinusMinus:
			case Doublecolon:
			case Identifier:
			case Integerliteral:
			case Characterliteral:
			case Floatingliteral:
			case Stringliteral:
			case Userdefinedintegerliteral:
			case Userdefinedfloatingliteral:
			case Userdefinedstringliteral:
			case Userdefinedcharacterliteral:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1144;
				expression(0);
				}
				break;
			case LeftBrace:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1145;
				bracedinitlist();
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

	public partial class JumpstatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Break() { return GetToken(CPP14Parser.Break, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CPP14Parser.Semi, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Continue() { return GetToken(CPP14Parser.Continue, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Return() { return GetToken(CPP14Parser.Return, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BracedinitlistContext bracedinitlist() {
			return GetRuleContext<BracedinitlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Goto() { return GetToken(CPP14Parser.Goto, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		public JumpstatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_jumpstatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterJumpstatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitJumpstatement(this);
		}
	}

	[RuleVersion(0)]
	public JumpstatementContext jumpstatement() {
		JumpstatementContext _localctx = new JumpstatementContext(Context, State);
		EnterRule(_localctx, 118, RULE_jumpstatement);
		int _la;
		try {
			State = 1164;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,99,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1148;
				Match(Break);
				State = 1149;
				Match(Semi);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1150;
				Match(Continue);
				State = 1151;
				Match(Semi);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1152;
				Match(Return);
				State = 1154;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << Alignof) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Const_cast) | (1L << Decltype) | (1L << Delete) | (1L << Double) | (1L << Dynamic_cast) | (1L << False) | (1L << Float) | (1L << Int) | (1L << Long) | (1L << New) | (1L << Noexcept) | (1L << Nullptr) | (1L << Operator) | (1L << Reinterpret_cast) | (1L << Short) | (1L << Signed) | (1L << Sizeof))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Static_cast - 64)) | (1L << (This - 64)) | (1L << (Throw - 64)) | (1L << (True - 64)) | (1L << (Typeid_ - 64)) | (1L << (Typename_ - 64)) | (1L << (Unsigned - 64)) | (1L << (Void - 64)) | (1L << (Wchar - 64)) | (1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (Plus - 64)) | (1L << (Minus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (Or - 64)) | (1L << (Tilde - 64)) | (1L << (PlusPlus - 64)) | (1L << (MinusMinus - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (Doublecolon - 128)) | (1L << (Identifier - 128)) | (1L << (Integerliteral - 128)) | (1L << (Characterliteral - 128)) | (1L << (Floatingliteral - 128)) | (1L << (Stringliteral - 128)) | (1L << (Userdefinedintegerliteral - 128)) | (1L << (Userdefinedfloatingliteral - 128)) | (1L << (Userdefinedstringliteral - 128)) | (1L << (Userdefinedcharacterliteral - 128)))) != 0)) {
					{
					State = 1153;
					expression(0);
					}
				}

				State = 1156;
				Match(Semi);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1157;
				Match(Return);
				State = 1158;
				bracedinitlist();
				State = 1159;
				Match(Semi);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1161;
				Match(Goto);
				State = 1162;
				Match(Identifier);
				State = 1163;
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

	public partial class DeclarationstatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BlockdeclarationContext blockdeclaration() {
			return GetRuleContext<BlockdeclarationContext>(0);
		}
		public DeclarationstatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declarationstatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterDeclarationstatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitDeclarationstatement(this);
		}
	}

	[RuleVersion(0)]
	public DeclarationstatementContext declarationstatement() {
		DeclarationstatementContext _localctx = new DeclarationstatementContext(Context, State);
		EnterRule(_localctx, 120, RULE_declarationstatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1166;
			blockdeclaration();
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

	public partial class DeclarationseqContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationContext declaration() {
			return GetRuleContext<DeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationseqContext declarationseq() {
			return GetRuleContext<DeclarationseqContext>(0);
		}
		public DeclarationseqContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declarationseq; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterDeclarationseq(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitDeclarationseq(this);
		}
	}

	[RuleVersion(0)]
	public DeclarationseqContext declarationseq() {
		return declarationseq(0);
	}

	private DeclarationseqContext declarationseq(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		DeclarationseqContext _localctx = new DeclarationseqContext(Context, _parentState);
		DeclarationseqContext _prevctx = _localctx;
		int _startState = 122;
		EnterRecursionRule(_localctx, 122, RULE_declarationseq, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 1169;
			declaration();
			}
			Context.Stop = TokenStream.LT(-1);
			State = 1175;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,100,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new DeclarationseqContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_declarationseq);
					State = 1171;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 1172;
					declaration();
					}
					} 
				}
				State = 1177;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,100,Context);
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

	public partial class DeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BlockdeclarationContext blockdeclaration() {
			return GetRuleContext<BlockdeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FunctiondefinitionContext functiondefinition() {
			return GetRuleContext<FunctiondefinitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TemplatedeclarationContext templatedeclaration() {
			return GetRuleContext<TemplatedeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExplicitinstantiationContext explicitinstantiation() {
			return GetRuleContext<ExplicitinstantiationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExplicitspecializationContext explicitspecialization() {
			return GetRuleContext<ExplicitspecializationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public LinkagespecificationContext linkagespecification() {
			return GetRuleContext<LinkagespecificationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NamespacedefinitionContext namespacedefinition() {
			return GetRuleContext<NamespacedefinitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EmptydeclarationContext emptydeclaration() {
			return GetRuleContext<EmptydeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributedeclarationContext attributedeclaration() {
			return GetRuleContext<AttributedeclarationContext>(0);
		}
		public DeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public DeclarationContext declaration() {
		DeclarationContext _localctx = new DeclarationContext(Context, State);
		EnterRule(_localctx, 124, RULE_declaration);
		try {
			State = 1187;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,101,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1178;
				blockdeclaration();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1179;
				functiondefinition();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1180;
				templatedeclaration();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1181;
				explicitinstantiation();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1182;
				explicitspecialization();
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 1183;
				linkagespecification();
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 1184;
				namespacedefinition();
				}
				break;
			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 1185;
				emptydeclaration();
				}
				break;
			case 9:
				EnterOuterAlt(_localctx, 9);
				{
				State = 1186;
				attributedeclaration();
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

	public partial class BlockdeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public SimpledeclarationContext simpledeclaration() {
			return GetRuleContext<SimpledeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AsmdefinitionContext asmdefinition() {
			return GetRuleContext<AsmdefinitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NamespacealiasdefinitionContext namespacealiasdefinition() {
			return GetRuleContext<NamespacealiasdefinitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UsingdeclarationContext usingdeclaration() {
			return GetRuleContext<UsingdeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UsingdirectiveContext usingdirective() {
			return GetRuleContext<UsingdirectiveContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Static_assertdeclarationContext static_assertdeclaration() {
			return GetRuleContext<Static_assertdeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AliasdeclarationContext aliasdeclaration() {
			return GetRuleContext<AliasdeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public OpaqueenumdeclarationContext opaqueenumdeclaration() {
			return GetRuleContext<OpaqueenumdeclarationContext>(0);
		}
		public BlockdeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_blockdeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterBlockdeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitBlockdeclaration(this);
		}
	}

	[RuleVersion(0)]
	public BlockdeclarationContext blockdeclaration() {
		BlockdeclarationContext _localctx = new BlockdeclarationContext(Context, State);
		EnterRule(_localctx, 126, RULE_blockdeclaration);
		try {
			State = 1197;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,102,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1189;
				simpledeclaration();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1190;
				asmdefinition();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1191;
				namespacealiasdefinition();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1192;
				usingdeclaration();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1193;
				usingdirective();
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 1194;
				static_assertdeclaration();
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 1195;
				aliasdeclaration();
				}
				break;
			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 1196;
				opaqueenumdeclaration();
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

	public partial class AliasdeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Using() { return GetToken(CPP14Parser.Using, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Assign() { return GetToken(CPP14Parser.Assign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ThetypeidContext thetypeid() {
			return GetRuleContext<ThetypeidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CPP14Parser.Semi, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		public AliasdeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_aliasdeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAliasdeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAliasdeclaration(this);
		}
	}

	[RuleVersion(0)]
	public AliasdeclarationContext aliasdeclaration() {
		AliasdeclarationContext _localctx = new AliasdeclarationContext(Context, State);
		EnterRule(_localctx, 128, RULE_aliasdeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1199;
			Match(Using);
			State = 1200;
			Match(Identifier);
			State = 1202;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Alignas || _la==LeftBracket) {
				{
				State = 1201;
				attributespecifierseq(0);
				}
			}

			State = 1204;
			Match(Assign);
			State = 1205;
			thetypeid();
			State = 1206;
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

	public partial class SimpledeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CPP14Parser.Semi, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public DeclspecifierseqContext declspecifierseq() {
			return GetRuleContext<DeclspecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InitdeclaratorlistContext initdeclaratorlist() {
			return GetRuleContext<InitdeclaratorlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		public SimpledeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_simpledeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterSimpledeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitSimpledeclaration(this);
		}
	}

	[RuleVersion(0)]
	public SimpledeclarationContext simpledeclaration() {
		SimpledeclarationContext _localctx = new SimpledeclarationContext(Context, State);
		EnterRule(_localctx, 130, RULE_simpledeclaration);
		int _la;
		try {
			State = 1222;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__2:
			case Auto:
			case Bool:
			case Char:
			case Char16:
			case Char32:
			case Class:
			case Const:
			case Constexpr:
			case Decltype:
			case Double:
			case Enum:
			case Explicit:
			case Extern:
			case Float:
			case Friend:
			case Inline:
			case Int:
			case Long:
			case Mutable:
			case Operator:
			case Register:
			case Short:
			case Signed:
			case Static:
			case Struct:
			case Thread_local:
			case Typedef:
			case Typename_:
			case Union:
			case Unsigned:
			case Virtual:
			case Void:
			case Volatile:
			case Wchar:
			case LeftParen:
			case Star:
			case And:
			case Tilde:
			case Doublecolon:
			case Semi:
			case Ellipsis:
			case Identifier:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1209;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,104,Context) ) {
				case 1:
					{
					State = 1208;
					declspecifierseq();
					}
					break;
				}
				State = 1212;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << Decltype) | (1L << Operator))) != 0) || ((((_la - 84)) & ~0x3f) == 0 && ((1L << (_la - 84)) & ((1L << (LeftParen - 84)) | (1L << (Star - 84)) | (1L << (And - 84)) | (1L << (Tilde - 84)) | (1L << (Doublecolon - 84)) | (1L << (Ellipsis - 84)) | (1L << (Identifier - 84)))) != 0)) {
					{
					State = 1211;
					initdeclaratorlist(0);
					}
				}

				State = 1214;
				Match(Semi);
				}
				break;
			case Alignas:
			case LeftBracket:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1215;
				attributespecifierseq(0);
				State = 1217;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,106,Context) ) {
				case 1:
					{
					State = 1216;
					declspecifierseq();
					}
					break;
				}
				State = 1219;
				initdeclaratorlist(0);
				State = 1220;
				Match(Semi);
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

	public partial class Static_assertdeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Static_assert() { return GetToken(CPP14Parser.Static_assert, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantexpressionContext constantexpression() {
			return GetRuleContext<ConstantexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Stringliteral() { return GetToken(CPP14Parser.Stringliteral, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CPP14Parser.Semi, 0); }
		public Static_assertdeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_static_assertdeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterStatic_assertdeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitStatic_assertdeclaration(this);
		}
	}

	[RuleVersion(0)]
	public Static_assertdeclarationContext static_assertdeclaration() {
		Static_assertdeclarationContext _localctx = new Static_assertdeclarationContext(Context, State);
		EnterRule(_localctx, 132, RULE_static_assertdeclaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1224;
			Match(Static_assert);
			State = 1225;
			Match(LeftParen);
			State = 1226;
			constantexpression();
			State = 1227;
			Match(Comma);
			State = 1228;
			Match(Stringliteral);
			State = 1229;
			Match(RightParen);
			State = 1230;
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

	public partial class EmptydeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CPP14Parser.Semi, 0); }
		public EmptydeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_emptydeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterEmptydeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitEmptydeclaration(this);
		}
	}

	[RuleVersion(0)]
	public EmptydeclarationContext emptydeclaration() {
		EmptydeclarationContext _localctx = new EmptydeclarationContext(Context, State);
		EnterRule(_localctx, 134, RULE_emptydeclaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1232;
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

	public partial class AttributedeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CPP14Parser.Semi, 0); }
		public AttributedeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attributedeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAttributedeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAttributedeclaration(this);
		}
	}

	[RuleVersion(0)]
	public AttributedeclarationContext attributedeclaration() {
		AttributedeclarationContext _localctx = new AttributedeclarationContext(Context, State);
		EnterRule(_localctx, 136, RULE_attributedeclaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1234;
			attributespecifierseq(0);
			State = 1235;
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

	public partial class DeclspecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StorageclassspecifierContext storageclassspecifier() {
			return GetRuleContext<StorageclassspecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypespecifierContext typespecifier() {
			return GetRuleContext<TypespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FunctionspecifierContext functionspecifier() {
			return GetRuleContext<FunctionspecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Friend() { return GetToken(CPP14Parser.Friend, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Typedef() { return GetToken(CPP14Parser.Typedef, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Constexpr() { return GetToken(CPP14Parser.Constexpr, 0); }
		public DeclspecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declspecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterDeclspecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitDeclspecifier(this);
		}
	}

	[RuleVersion(0)]
	public DeclspecifierContext declspecifier() {
		DeclspecifierContext _localctx = new DeclspecifierContext(Context, State);
		EnterRule(_localctx, 138, RULE_declspecifier);
		try {
			State = 1243;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Extern:
			case Mutable:
			case Register:
			case Static:
			case Thread_local:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1237;
				storageclassspecifier();
				}
				break;
			case Auto:
			case Bool:
			case Char:
			case Char16:
			case Char32:
			case Class:
			case Const:
			case Decltype:
			case Double:
			case Enum:
			case Float:
			case Int:
			case Long:
			case Short:
			case Signed:
			case Struct:
			case Typename_:
			case Union:
			case Unsigned:
			case Void:
			case Volatile:
			case Wchar:
			case Doublecolon:
			case Identifier:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1238;
				typespecifier();
				}
				break;
			case Explicit:
			case Inline:
			case Virtual:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1239;
				functionspecifier();
				}
				break;
			case Friend:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1240;
				Match(Friend);
				}
				break;
			case Typedef:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1241;
				Match(Typedef);
				}
				break;
			case Constexpr:
				EnterOuterAlt(_localctx, 6);
				{
				State = 1242;
				Match(Constexpr);
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

	public partial class DeclspecifierseqContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclspecifierContext declspecifier() {
			return GetRuleContext<DeclspecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclspecifierseqContext declspecifierseq() {
			return GetRuleContext<DeclspecifierseqContext>(0);
		}
		public DeclspecifierseqContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declspecifierseq; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterDeclspecifierseq(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitDeclspecifierseq(this);
		}
	}

	[RuleVersion(0)]
	public DeclspecifierseqContext declspecifierseq() {
		DeclspecifierseqContext _localctx = new DeclspecifierseqContext(Context, State);
		EnterRule(_localctx, 140, RULE_declspecifierseq);
		try {
			State = 1252;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,110,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1245;
				declspecifier();
				State = 1247;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,109,Context) ) {
				case 1:
					{
					State = 1246;
					attributespecifierseq(0);
					}
					break;
				}
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1249;
				declspecifier();
				State = 1250;
				declspecifierseq();
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

	public partial class StorageclassspecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Register() { return GetToken(CPP14Parser.Register, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Static() { return GetToken(CPP14Parser.Static, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Thread_local() { return GetToken(CPP14Parser.Thread_local, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Extern() { return GetToken(CPP14Parser.Extern, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Mutable() { return GetToken(CPP14Parser.Mutable, 0); }
		public StorageclassspecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_storageclassspecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterStorageclassspecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitStorageclassspecifier(this);
		}
	}

	[RuleVersion(0)]
	public StorageclassspecifierContext storageclassspecifier() {
		StorageclassspecifierContext _localctx = new StorageclassspecifierContext(Context, State);
		EnterRule(_localctx, 142, RULE_storageclassspecifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1254;
			_la = TokenStream.LA(1);
			if ( !(((((_la - 35)) & ~0x3f) == 0 && ((1L << (_la - 35)) & ((1L << (Extern - 35)) | (1L << (Mutable - 35)) | (1L << (Register - 35)) | (1L << (Static - 35)) | (1L << (Thread_local - 35)))) != 0)) ) {
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

	public partial class FunctionspecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Inline() { return GetToken(CPP14Parser.Inline, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Virtual() { return GetToken(CPP14Parser.Virtual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Explicit() { return GetToken(CPP14Parser.Explicit, 0); }
		public FunctionspecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_functionspecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterFunctionspecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitFunctionspecifier(this);
		}
	}

	[RuleVersion(0)]
	public FunctionspecifierContext functionspecifier() {
		FunctionspecifierContext _localctx = new FunctionspecifierContext(Context, State);
		EnterRule(_localctx, 144, RULE_functionspecifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1256;
			_la = TokenStream.LA(1);
			if ( !(((((_la - 33)) & ~0x3f) == 0 && ((1L << (_la - 33)) & ((1L << (Explicit - 33)) | (1L << (Inline - 33)) | (1L << (Virtual - 33)))) != 0)) ) {
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

	public partial class TypedefnameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		public TypedefnameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typedefname; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTypedefname(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTypedefname(this);
		}
	}

	[RuleVersion(0)]
	public TypedefnameContext typedefname() {
		TypedefnameContext _localctx = new TypedefnameContext(Context, State);
		EnterRule(_localctx, 146, RULE_typedefname);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1258;
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

	public partial class TypespecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TrailingtypespecifierContext trailingtypespecifier() {
			return GetRuleContext<TrailingtypespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassspecifierContext classspecifier() {
			return GetRuleContext<ClassspecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EnumspecifierContext enumspecifier() {
			return GetRuleContext<EnumspecifierContext>(0);
		}
		public TypespecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typespecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTypespecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTypespecifier(this);
		}
	}

	[RuleVersion(0)]
	public TypespecifierContext typespecifier() {
		TypespecifierContext _localctx = new TypespecifierContext(Context, State);
		EnterRule(_localctx, 148, RULE_typespecifier);
		try {
			State = 1263;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,111,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1260;
				trailingtypespecifier();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1261;
				classspecifier();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1262;
				enumspecifier();
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

	public partial class TrailingtypespecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public SimpletypespecifierContext simpletypespecifier() {
			return GetRuleContext<SimpletypespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ElaboratedtypespecifierContext elaboratedtypespecifier() {
			return GetRuleContext<ElaboratedtypespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypenamespecifierContext typenamespecifier() {
			return GetRuleContext<TypenamespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CvqualifierContext cvqualifier() {
			return GetRuleContext<CvqualifierContext>(0);
		}
		public TrailingtypespecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_trailingtypespecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTrailingtypespecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTrailingtypespecifier(this);
		}
	}

	[RuleVersion(0)]
	public TrailingtypespecifierContext trailingtypespecifier() {
		TrailingtypespecifierContext _localctx = new TrailingtypespecifierContext(Context, State);
		EnterRule(_localctx, 150, RULE_trailingtypespecifier);
		try {
			State = 1269;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Auto:
			case Bool:
			case Char:
			case Char16:
			case Char32:
			case Decltype:
			case Double:
			case Float:
			case Int:
			case Long:
			case Short:
			case Signed:
			case Unsigned:
			case Void:
			case Wchar:
			case Doublecolon:
			case Identifier:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1265;
				simpletypespecifier();
				}
				break;
			case Class:
			case Enum:
			case Struct:
			case Union:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1266;
				elaboratedtypespecifier();
				}
				break;
			case Typename_:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1267;
				typenamespecifier();
				}
				break;
			case Const:
			case Volatile:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1268;
				cvqualifier();
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

	public partial class TypespecifierseqContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TypespecifierContext typespecifier() {
			return GetRuleContext<TypespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypespecifierseqContext typespecifierseq() {
			return GetRuleContext<TypespecifierseqContext>(0);
		}
		public TypespecifierseqContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typespecifierseq; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTypespecifierseq(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTypespecifierseq(this);
		}
	}

	[RuleVersion(0)]
	public TypespecifierseqContext typespecifierseq() {
		TypespecifierseqContext _localctx = new TypespecifierseqContext(Context, State);
		EnterRule(_localctx, 152, RULE_typespecifierseq);
		try {
			State = 1278;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,114,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1271;
				typespecifier();
				State = 1273;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,113,Context) ) {
				case 1:
					{
					State = 1272;
					attributespecifierseq(0);
					}
					break;
				}
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1275;
				typespecifier();
				State = 1276;
				typespecifierseq();
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

	public partial class TrailingtypespecifierseqContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TrailingtypespecifierContext trailingtypespecifier() {
			return GetRuleContext<TrailingtypespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TrailingtypespecifierseqContext trailingtypespecifierseq() {
			return GetRuleContext<TrailingtypespecifierseqContext>(0);
		}
		public TrailingtypespecifierseqContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_trailingtypespecifierseq; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTrailingtypespecifierseq(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTrailingtypespecifierseq(this);
		}
	}

	[RuleVersion(0)]
	public TrailingtypespecifierseqContext trailingtypespecifierseq() {
		TrailingtypespecifierseqContext _localctx = new TrailingtypespecifierseqContext(Context, State);
		EnterRule(_localctx, 154, RULE_trailingtypespecifierseq);
		try {
			State = 1287;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,116,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1280;
				trailingtypespecifier();
				State = 1282;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,115,Context) ) {
				case 1:
					{
					State = 1281;
					attributespecifierseq(0);
					}
					break;
				}
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1284;
				trailingtypespecifier();
				State = 1285;
				trailingtypespecifierseq();
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

	public partial class SimpletypespecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ThetypenameContext thetypename() {
			return GetRuleContext<ThetypenameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NestednamespecifierContext nestednamespecifier() {
			return GetRuleContext<NestednamespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Template() { return GetToken(CPP14Parser.Template, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public SimpletemplateidContext simpletemplateid() {
			return GetRuleContext<SimpletemplateidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Char() { return GetToken(CPP14Parser.Char, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Char16() { return GetToken(CPP14Parser.Char16, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Char32() { return GetToken(CPP14Parser.Char32, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Wchar() { return GetToken(CPP14Parser.Wchar, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Bool() { return GetToken(CPP14Parser.Bool, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Short() { return GetToken(CPP14Parser.Short, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Int() { return GetToken(CPP14Parser.Int, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Long() { return GetToken(CPP14Parser.Long, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Signed() { return GetToken(CPP14Parser.Signed, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Unsigned() { return GetToken(CPP14Parser.Unsigned, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Float() { return GetToken(CPP14Parser.Float, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Double() { return GetToken(CPP14Parser.Double, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Void() { return GetToken(CPP14Parser.Void, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Auto() { return GetToken(CPP14Parser.Auto, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public DecltypespecifierContext decltypespecifier() {
			return GetRuleContext<DecltypespecifierContext>(0);
		}
		public SimpletypespecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_simpletypespecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterSimpletypespecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitSimpletypespecifier(this);
		}
	}

	[RuleVersion(0)]
	public SimpletypespecifierContext simpletypespecifier() {
		SimpletypespecifierContext _localctx = new SimpletypespecifierContext(Context, State);
		EnterRule(_localctx, 156, RULE_simpletypespecifier);
		try {
			State = 1312;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,118,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1290;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,117,Context) ) {
				case 1:
					{
					State = 1289;
					nestednamespecifier(0);
					}
					break;
				}
				State = 1292;
				thetypename();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1293;
				nestednamespecifier(0);
				State = 1294;
				Match(Template);
				State = 1295;
				simpletemplateid();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1297;
				Match(Char);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1298;
				Match(Char16);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1299;
				Match(Char32);
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 1300;
				Match(Wchar);
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 1301;
				Match(Bool);
				}
				break;
			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 1302;
				Match(Short);
				}
				break;
			case 9:
				EnterOuterAlt(_localctx, 9);
				{
				State = 1303;
				Match(Int);
				}
				break;
			case 10:
				EnterOuterAlt(_localctx, 10);
				{
				State = 1304;
				Match(Long);
				}
				break;
			case 11:
				EnterOuterAlt(_localctx, 11);
				{
				State = 1305;
				Match(Signed);
				}
				break;
			case 12:
				EnterOuterAlt(_localctx, 12);
				{
				State = 1306;
				Match(Unsigned);
				}
				break;
			case 13:
				EnterOuterAlt(_localctx, 13);
				{
				State = 1307;
				Match(Float);
				}
				break;
			case 14:
				EnterOuterAlt(_localctx, 14);
				{
				State = 1308;
				Match(Double);
				}
				break;
			case 15:
				EnterOuterAlt(_localctx, 15);
				{
				State = 1309;
				Match(Void);
				}
				break;
			case 16:
				EnterOuterAlt(_localctx, 16);
				{
				State = 1310;
				Match(Auto);
				}
				break;
			case 17:
				EnterOuterAlt(_localctx, 17);
				{
				State = 1311;
				decltypespecifier();
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

	public partial class ThetypenameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ClassnameContext classname() {
			return GetRuleContext<ClassnameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EnumnameContext enumname() {
			return GetRuleContext<EnumnameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypedefnameContext typedefname() {
			return GetRuleContext<TypedefnameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SimpletemplateidContext simpletemplateid() {
			return GetRuleContext<SimpletemplateidContext>(0);
		}
		public ThetypenameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_thetypename; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterThetypename(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitThetypename(this);
		}
	}

	[RuleVersion(0)]
	public ThetypenameContext thetypename() {
		ThetypenameContext _localctx = new ThetypenameContext(Context, State);
		EnterRule(_localctx, 158, RULE_thetypename);
		try {
			State = 1318;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,119,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1314;
				classname();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1315;
				enumname();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1316;
				typedefname();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1317;
				simpletemplateid();
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

	public partial class DecltypespecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Decltype() { return GetToken(CPP14Parser.Decltype, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Auto() { return GetToken(CPP14Parser.Auto, 0); }
		public DecltypespecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_decltypespecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterDecltypespecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitDecltypespecifier(this);
		}
	}

	[RuleVersion(0)]
	public DecltypespecifierContext decltypespecifier() {
		DecltypespecifierContext _localctx = new DecltypespecifierContext(Context, State);
		EnterRule(_localctx, 160, RULE_decltypespecifier);
		try {
			State = 1329;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,120,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1320;
				Match(Decltype);
				State = 1321;
				Match(LeftParen);
				State = 1322;
				expression(0);
				State = 1323;
				Match(RightParen);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1325;
				Match(Decltype);
				State = 1326;
				Match(LeftParen);
				State = 1327;
				Match(Auto);
				State = 1328;
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

	public partial class ElaboratedtypespecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ClasskeyContext classkey() {
			return GetRuleContext<ClasskeyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NestednamespecifierContext nestednamespecifier() {
			return GetRuleContext<NestednamespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SimpletemplateidContext simpletemplateid() {
			return GetRuleContext<SimpletemplateidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Template() { return GetToken(CPP14Parser.Template, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Enum() { return GetToken(CPP14Parser.Enum, 0); }
		public ElaboratedtypespecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_elaboratedtypespecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterElaboratedtypespecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitElaboratedtypespecifier(this);
		}
	}

	[RuleVersion(0)]
	public ElaboratedtypespecifierContext elaboratedtypespecifier() {
		ElaboratedtypespecifierContext _localctx = new ElaboratedtypespecifierContext(Context, State);
		EnterRule(_localctx, 162, RULE_elaboratedtypespecifier);
		int _la;
		try {
			State = 1355;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,125,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1331;
				classkey();
				State = 1333;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 1332;
					attributespecifierseq(0);
					}
				}

				State = 1336;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,122,Context) ) {
				case 1:
					{
					State = 1335;
					nestednamespecifier(0);
					}
					break;
				}
				State = 1338;
				Match(Identifier);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1340;
				classkey();
				State = 1341;
				simpletemplateid();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1343;
				classkey();
				State = 1344;
				nestednamespecifier(0);
				State = 1346;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Template) {
					{
					State = 1345;
					Match(Template);
					}
				}

				State = 1348;
				simpletemplateid();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1350;
				Match(Enum);
				State = 1352;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,124,Context) ) {
				case 1:
					{
					State = 1351;
					nestednamespecifier(0);
					}
					break;
				}
				State = 1354;
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

	public partial class EnumnameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		public EnumnameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumname; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterEnumname(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitEnumname(this);
		}
	}

	[RuleVersion(0)]
	public EnumnameContext enumname() {
		EnumnameContext _localctx = new EnumnameContext(Context, State);
		EnterRule(_localctx, 164, RULE_enumname);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1357;
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

	public partial class EnumspecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public EnumheadContext enumhead() {
			return GetRuleContext<EnumheadContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBrace() { return GetToken(CPP14Parser.LeftBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBrace() { return GetToken(CPP14Parser.RightBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public EnumeratorlistContext enumeratorlist() {
			return GetRuleContext<EnumeratorlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		public EnumspecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumspecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterEnumspecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitEnumspecifier(this);
		}
	}

	[RuleVersion(0)]
	public EnumspecifierContext enumspecifier() {
		EnumspecifierContext _localctx = new EnumspecifierContext(Context, State);
		EnterRule(_localctx, 166, RULE_enumspecifier);
		int _la;
		try {
			State = 1372;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,127,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1359;
				enumhead();
				State = 1360;
				Match(LeftBrace);
				State = 1362;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Identifier) {
					{
					State = 1361;
					enumeratorlist(0);
					}
				}

				State = 1364;
				Match(RightBrace);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1366;
				enumhead();
				State = 1367;
				Match(LeftBrace);
				State = 1368;
				enumeratorlist(0);
				State = 1369;
				Match(Comma);
				State = 1370;
				Match(RightBrace);
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

	public partial class EnumheadContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public EnumkeyContext enumkey() {
			return GetRuleContext<EnumkeyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public EnumbaseContext enumbase() {
			return GetRuleContext<EnumbaseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NestednamespecifierContext nestednamespecifier() {
			return GetRuleContext<NestednamespecifierContext>(0);
		}
		public EnumheadContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumhead; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterEnumhead(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitEnumhead(this);
		}
	}

	[RuleVersion(0)]
	public EnumheadContext enumhead() {
		EnumheadContext _localctx = new EnumheadContext(Context, State);
		EnterRule(_localctx, 168, RULE_enumhead);
		int _la;
		try {
			State = 1393;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,133,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1374;
				enumkey();
				State = 1376;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 1375;
					attributespecifierseq(0);
					}
				}

				State = 1379;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Identifier) {
					{
					State = 1378;
					Match(Identifier);
					}
				}

				State = 1382;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Colon) {
					{
					State = 1381;
					enumbase();
					}
				}

				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1384;
				enumkey();
				State = 1386;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 1385;
					attributespecifierseq(0);
					}
				}

				State = 1388;
				nestednamespecifier(0);
				State = 1389;
				Match(Identifier);
				State = 1391;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Colon) {
					{
					State = 1390;
					enumbase();
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

	public partial class OpaqueenumdeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public EnumkeyContext enumkey() {
			return GetRuleContext<EnumkeyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CPP14Parser.Semi, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EnumbaseContext enumbase() {
			return GetRuleContext<EnumbaseContext>(0);
		}
		public OpaqueenumdeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_opaqueenumdeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterOpaqueenumdeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitOpaqueenumdeclaration(this);
		}
	}

	[RuleVersion(0)]
	public OpaqueenumdeclarationContext opaqueenumdeclaration() {
		OpaqueenumdeclarationContext _localctx = new OpaqueenumdeclarationContext(Context, State);
		EnterRule(_localctx, 170, RULE_opaqueenumdeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1395;
			enumkey();
			State = 1397;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Alignas || _la==LeftBracket) {
				{
				State = 1396;
				attributespecifierseq(0);
				}
			}

			State = 1399;
			Match(Identifier);
			State = 1401;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Colon) {
				{
				State = 1400;
				enumbase();
				}
			}

			State = 1403;
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

	public partial class EnumkeyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Enum() { return GetToken(CPP14Parser.Enum, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Class() { return GetToken(CPP14Parser.Class, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Struct() { return GetToken(CPP14Parser.Struct, 0); }
		public EnumkeyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumkey; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterEnumkey(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitEnumkey(this);
		}
	}

	[RuleVersion(0)]
	public EnumkeyContext enumkey() {
		EnumkeyContext _localctx = new EnumkeyContext(Context, State);
		EnterRule(_localctx, 172, RULE_enumkey);
		try {
			State = 1410;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,136,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1405;
				Match(Enum);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1406;
				Match(Enum);
				State = 1407;
				Match(Class);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1408;
				Match(Enum);
				State = 1409;
				Match(Struct);
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

	public partial class EnumbaseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(CPP14Parser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypespecifierseqContext typespecifierseq() {
			return GetRuleContext<TypespecifierseqContext>(0);
		}
		public EnumbaseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumbase; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterEnumbase(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitEnumbase(this);
		}
	}

	[RuleVersion(0)]
	public EnumbaseContext enumbase() {
		EnumbaseContext _localctx = new EnumbaseContext(Context, State);
		EnterRule(_localctx, 174, RULE_enumbase);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1412;
			Match(Colon);
			State = 1413;
			typespecifierseq();
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

	public partial class EnumeratorlistContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public EnumeratordefinitionContext enumeratordefinition() {
			return GetRuleContext<EnumeratordefinitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EnumeratorlistContext enumeratorlist() {
			return GetRuleContext<EnumeratorlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		public EnumeratorlistContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumeratorlist; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterEnumeratorlist(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitEnumeratorlist(this);
		}
	}

	[RuleVersion(0)]
	public EnumeratorlistContext enumeratorlist() {
		return enumeratorlist(0);
	}

	private EnumeratorlistContext enumeratorlist(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		EnumeratorlistContext _localctx = new EnumeratorlistContext(Context, _parentState);
		EnumeratorlistContext _prevctx = _localctx;
		int _startState = 176;
		EnterRecursionRule(_localctx, 176, RULE_enumeratorlist, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 1416;
			enumeratordefinition();
			}
			Context.Stop = TokenStream.LT(-1);
			State = 1423;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,137,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new EnumeratorlistContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_enumeratorlist);
					State = 1418;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 1419;
					Match(Comma);
					State = 1420;
					enumeratordefinition();
					}
					} 
				}
				State = 1425;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,137,Context);
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

	public partial class EnumeratordefinitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public EnumeratorContext enumerator() {
			return GetRuleContext<EnumeratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Assign() { return GetToken(CPP14Parser.Assign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantexpressionContext constantexpression() {
			return GetRuleContext<ConstantexpressionContext>(0);
		}
		public EnumeratordefinitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumeratordefinition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterEnumeratordefinition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitEnumeratordefinition(this);
		}
	}

	[RuleVersion(0)]
	public EnumeratordefinitionContext enumeratordefinition() {
		EnumeratordefinitionContext _localctx = new EnumeratordefinitionContext(Context, State);
		EnterRule(_localctx, 178, RULE_enumeratordefinition);
		try {
			State = 1431;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,138,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1426;
				enumerator();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1427;
				enumerator();
				State = 1428;
				Match(Assign);
				State = 1429;
				constantexpression();
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

	public partial class EnumeratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		public EnumeratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumerator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterEnumerator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitEnumerator(this);
		}
	}

	[RuleVersion(0)]
	public EnumeratorContext enumerator() {
		EnumeratorContext _localctx = new EnumeratorContext(Context, State);
		EnterRule(_localctx, 180, RULE_enumerator);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1433;
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

	public partial class NamespacenameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public OriginalnamespacenameContext originalnamespacename() {
			return GetRuleContext<OriginalnamespacenameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NamespacealiasContext namespacealias() {
			return GetRuleContext<NamespacealiasContext>(0);
		}
		public NamespacenameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namespacename; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterNamespacename(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitNamespacename(this);
		}
	}

	[RuleVersion(0)]
	public NamespacenameContext namespacename() {
		NamespacenameContext _localctx = new NamespacenameContext(Context, State);
		EnterRule(_localctx, 182, RULE_namespacename);
		try {
			State = 1437;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,139,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1435;
				originalnamespacename();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1436;
				namespacealias();
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

	public partial class OriginalnamespacenameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		public OriginalnamespacenameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_originalnamespacename; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterOriginalnamespacename(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitOriginalnamespacename(this);
		}
	}

	[RuleVersion(0)]
	public OriginalnamespacenameContext originalnamespacename() {
		OriginalnamespacenameContext _localctx = new OriginalnamespacenameContext(Context, State);
		EnterRule(_localctx, 184, RULE_originalnamespacename);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1439;
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

	public partial class NamespacedefinitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public NamednamespacedefinitionContext namednamespacedefinition() {
			return GetRuleContext<NamednamespacedefinitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnnamednamespacedefinitionContext unnamednamespacedefinition() {
			return GetRuleContext<UnnamednamespacedefinitionContext>(0);
		}
		public NamespacedefinitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namespacedefinition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterNamespacedefinition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitNamespacedefinition(this);
		}
	}

	[RuleVersion(0)]
	public NamespacedefinitionContext namespacedefinition() {
		NamespacedefinitionContext _localctx = new NamespacedefinitionContext(Context, State);
		EnterRule(_localctx, 186, RULE_namespacedefinition);
		try {
			State = 1443;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,140,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1441;
				namednamespacedefinition();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1442;
				unnamednamespacedefinition();
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

	public partial class NamednamespacedefinitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public OriginalnamespacedefinitionContext originalnamespacedefinition() {
			return GetRuleContext<OriginalnamespacedefinitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExtensionnamespacedefinitionContext extensionnamespacedefinition() {
			return GetRuleContext<ExtensionnamespacedefinitionContext>(0);
		}
		public NamednamespacedefinitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namednamespacedefinition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterNamednamespacedefinition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitNamednamespacedefinition(this);
		}
	}

	[RuleVersion(0)]
	public NamednamespacedefinitionContext namednamespacedefinition() {
		NamednamespacedefinitionContext _localctx = new NamednamespacedefinitionContext(Context, State);
		EnterRule(_localctx, 188, RULE_namednamespacedefinition);
		try {
			State = 1447;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,141,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1445;
				originalnamespacedefinition();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1446;
				extensionnamespacedefinition();
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

	public partial class OriginalnamespacedefinitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Namespace() { return GetToken(CPP14Parser.Namespace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBrace() { return GetToken(CPP14Parser.LeftBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NamespacebodyContext namespacebody() {
			return GetRuleContext<NamespacebodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBrace() { return GetToken(CPP14Parser.RightBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Inline() { return GetToken(CPP14Parser.Inline, 0); }
		public OriginalnamespacedefinitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_originalnamespacedefinition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterOriginalnamespacedefinition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitOriginalnamespacedefinition(this);
		}
	}

	[RuleVersion(0)]
	public OriginalnamespacedefinitionContext originalnamespacedefinition() {
		OriginalnamespacedefinitionContext _localctx = new OriginalnamespacedefinitionContext(Context, State);
		EnterRule(_localctx, 190, RULE_originalnamespacedefinition);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1450;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Inline) {
				{
				State = 1449;
				Match(Inline);
				}
			}

			State = 1452;
			Match(Namespace);
			State = 1453;
			Match(Identifier);
			State = 1454;
			Match(LeftBrace);
			State = 1455;
			namespacebody();
			State = 1456;
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

	public partial class ExtensionnamespacedefinitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Namespace() { return GetToken(CPP14Parser.Namespace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public OriginalnamespacenameContext originalnamespacename() {
			return GetRuleContext<OriginalnamespacenameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBrace() { return GetToken(CPP14Parser.LeftBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NamespacebodyContext namespacebody() {
			return GetRuleContext<NamespacebodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBrace() { return GetToken(CPP14Parser.RightBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Inline() { return GetToken(CPP14Parser.Inline, 0); }
		public ExtensionnamespacedefinitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_extensionnamespacedefinition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterExtensionnamespacedefinition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitExtensionnamespacedefinition(this);
		}
	}

	[RuleVersion(0)]
	public ExtensionnamespacedefinitionContext extensionnamespacedefinition() {
		ExtensionnamespacedefinitionContext _localctx = new ExtensionnamespacedefinitionContext(Context, State);
		EnterRule(_localctx, 192, RULE_extensionnamespacedefinition);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1459;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Inline) {
				{
				State = 1458;
				Match(Inline);
				}
			}

			State = 1461;
			Match(Namespace);
			State = 1462;
			originalnamespacename();
			State = 1463;
			Match(LeftBrace);
			State = 1464;
			namespacebody();
			State = 1465;
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

	public partial class UnnamednamespacedefinitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Namespace() { return GetToken(CPP14Parser.Namespace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBrace() { return GetToken(CPP14Parser.LeftBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NamespacebodyContext namespacebody() {
			return GetRuleContext<NamespacebodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBrace() { return GetToken(CPP14Parser.RightBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Inline() { return GetToken(CPP14Parser.Inline, 0); }
		public UnnamednamespacedefinitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unnamednamespacedefinition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterUnnamednamespacedefinition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitUnnamednamespacedefinition(this);
		}
	}

	[RuleVersion(0)]
	public UnnamednamespacedefinitionContext unnamednamespacedefinition() {
		UnnamednamespacedefinitionContext _localctx = new UnnamednamespacedefinitionContext(Context, State);
		EnterRule(_localctx, 194, RULE_unnamednamespacedefinition);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1468;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Inline) {
				{
				State = 1467;
				Match(Inline);
				}
			}

			State = 1470;
			Match(Namespace);
			State = 1471;
			Match(LeftBrace);
			State = 1472;
			namespacebody();
			State = 1473;
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

	public partial class NamespacebodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationseqContext declarationseq() {
			return GetRuleContext<DeclarationseqContext>(0);
		}
		public NamespacebodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namespacebody; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterNamespacebody(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitNamespacebody(this);
		}
	}

	[RuleVersion(0)]
	public NamespacebodyContext namespacebody() {
		NamespacebodyContext _localctx = new NamespacebodyContext(Context, State);
		EnterRule(_localctx, 196, RULE_namespacebody);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1476;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << Alignas) | (1L << Asm) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Class) | (1L << Const) | (1L << Constexpr) | (1L << Decltype) | (1L << Double) | (1L << Enum) | (1L << Explicit) | (1L << Extern) | (1L << Float) | (1L << Friend) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Mutable) | (1L << Namespace) | (1L << Operator) | (1L << Register) | (1L << Short) | (1L << Signed) | (1L << Static) | (1L << Static_assert))) != 0) || ((((_la - 65)) & ~0x3f) == 0 && ((1L << (_la - 65)) & ((1L << (Struct - 65)) | (1L << (Template - 65)) | (1L << (Thread_local - 65)) | (1L << (Typedef - 65)) | (1L << (Typename_ - 65)) | (1L << (Union - 65)) | (1L << (Unsigned - 65)) | (1L << (Using - 65)) | (1L << (Virtual - 65)) | (1L << (Void - 65)) | (1L << (Volatile - 65)) | (1L << (Wchar - 65)) | (1L << (LeftParen - 65)) | (1L << (LeftBracket - 65)) | (1L << (Star - 65)) | (1L << (And - 65)) | (1L << (Tilde - 65)) | (1L << (Doublecolon - 65)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (Semi - 129)) | (1L << (Ellipsis - 129)) | (1L << (Identifier - 129)))) != 0)) {
				{
				State = 1475;
				declarationseq(0);
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

	public partial class NamespacealiasContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		public NamespacealiasContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namespacealias; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterNamespacealias(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitNamespacealias(this);
		}
	}

	[RuleVersion(0)]
	public NamespacealiasContext namespacealias() {
		NamespacealiasContext _localctx = new NamespacealiasContext(Context, State);
		EnterRule(_localctx, 198, RULE_namespacealias);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1478;
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

	public partial class NamespacealiasdefinitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Namespace() { return GetToken(CPP14Parser.Namespace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Assign() { return GetToken(CPP14Parser.Assign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public QualifiednamespacespecifierContext qualifiednamespacespecifier() {
			return GetRuleContext<QualifiednamespacespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CPP14Parser.Semi, 0); }
		public NamespacealiasdefinitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namespacealiasdefinition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterNamespacealiasdefinition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitNamespacealiasdefinition(this);
		}
	}

	[RuleVersion(0)]
	public NamespacealiasdefinitionContext namespacealiasdefinition() {
		NamespacealiasdefinitionContext _localctx = new NamespacealiasdefinitionContext(Context, State);
		EnterRule(_localctx, 200, RULE_namespacealiasdefinition);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1480;
			Match(Namespace);
			State = 1481;
			Match(Identifier);
			State = 1482;
			Match(Assign);
			State = 1483;
			qualifiednamespacespecifier();
			State = 1484;
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

	public partial class QualifiednamespacespecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public NamespacenameContext namespacename() {
			return GetRuleContext<NamespacenameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NestednamespecifierContext nestednamespecifier() {
			return GetRuleContext<NestednamespecifierContext>(0);
		}
		public QualifiednamespacespecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_qualifiednamespacespecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterQualifiednamespacespecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitQualifiednamespacespecifier(this);
		}
	}

	[RuleVersion(0)]
	public QualifiednamespacespecifierContext qualifiednamespacespecifier() {
		QualifiednamespacespecifierContext _localctx = new QualifiednamespacespecifierContext(Context, State);
		EnterRule(_localctx, 202, RULE_qualifiednamespacespecifier);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1487;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,146,Context) ) {
			case 1:
				{
				State = 1486;
				nestednamespecifier(0);
				}
				break;
			}
			State = 1489;
			namespacename();
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

	public partial class UsingdeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Using() { return GetToken(CPP14Parser.Using, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NestednamespecifierContext nestednamespecifier() {
			return GetRuleContext<NestednamespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnqualifiedidContext unqualifiedid() {
			return GetRuleContext<UnqualifiedidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CPP14Parser.Semi, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Typename_() { return GetToken(CPP14Parser.Typename_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Doublecolon() { return GetToken(CPP14Parser.Doublecolon, 0); }
		public UsingdeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_usingdeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterUsingdeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitUsingdeclaration(this);
		}
	}

	[RuleVersion(0)]
	public UsingdeclarationContext usingdeclaration() {
		UsingdeclarationContext _localctx = new UsingdeclarationContext(Context, State);
		EnterRule(_localctx, 204, RULE_usingdeclaration);
		int _la;
		try {
			State = 1504;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,148,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1491;
				Match(Using);
				State = 1493;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Typename_) {
					{
					State = 1492;
					Match(Typename_);
					}
				}

				State = 1495;
				nestednamespecifier(0);
				State = 1496;
				unqualifiedid();
				State = 1497;
				Match(Semi);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1499;
				Match(Using);
				State = 1500;
				Match(Doublecolon);
				State = 1501;
				unqualifiedid();
				State = 1502;
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

	public partial class UsingdirectiveContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Using() { return GetToken(CPP14Parser.Using, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Namespace() { return GetToken(CPP14Parser.Namespace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NamespacenameContext namespacename() {
			return GetRuleContext<NamespacenameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CPP14Parser.Semi, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NestednamespecifierContext nestednamespecifier() {
			return GetRuleContext<NestednamespecifierContext>(0);
		}
		public UsingdirectiveContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_usingdirective; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterUsingdirective(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitUsingdirective(this);
		}
	}

	[RuleVersion(0)]
	public UsingdirectiveContext usingdirective() {
		UsingdirectiveContext _localctx = new UsingdirectiveContext(Context, State);
		EnterRule(_localctx, 206, RULE_usingdirective);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1507;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Alignas || _la==LeftBracket) {
				{
				State = 1506;
				attributespecifierseq(0);
				}
			}

			State = 1509;
			Match(Using);
			State = 1510;
			Match(Namespace);
			State = 1512;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,150,Context) ) {
			case 1:
				{
				State = 1511;
				nestednamespecifier(0);
				}
				break;
			}
			State = 1514;
			namespacename();
			State = 1515;
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

	public partial class AsmdefinitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Asm() { return GetToken(CPP14Parser.Asm, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Stringliteral() { return GetToken(CPP14Parser.Stringliteral, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CPP14Parser.Semi, 0); }
		public AsmdefinitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_asmdefinition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAsmdefinition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAsmdefinition(this);
		}
	}

	[RuleVersion(0)]
	public AsmdefinitionContext asmdefinition() {
		AsmdefinitionContext _localctx = new AsmdefinitionContext(Context, State);
		EnterRule(_localctx, 208, RULE_asmdefinition);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1517;
			Match(Asm);
			State = 1518;
			Match(LeftParen);
			State = 1519;
			Match(Stringliteral);
			State = 1520;
			Match(RightParen);
			State = 1521;
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

	public partial class LinkagespecificationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Extern() { return GetToken(CPP14Parser.Extern, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Stringliteral() { return GetToken(CPP14Parser.Stringliteral, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBrace() { return GetToken(CPP14Parser.LeftBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBrace() { return GetToken(CPP14Parser.RightBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationseqContext declarationseq() {
			return GetRuleContext<DeclarationseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationContext declaration() {
			return GetRuleContext<DeclarationContext>(0);
		}
		public LinkagespecificationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_linkagespecification; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterLinkagespecification(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitLinkagespecification(this);
		}
	}

	[RuleVersion(0)]
	public LinkagespecificationContext linkagespecification() {
		LinkagespecificationContext _localctx = new LinkagespecificationContext(Context, State);
		EnterRule(_localctx, 210, RULE_linkagespecification);
		int _la;
		try {
			State = 1533;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,152,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1523;
				Match(Extern);
				State = 1524;
				Match(Stringliteral);
				State = 1525;
				Match(LeftBrace);
				State = 1527;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << Alignas) | (1L << Asm) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Class) | (1L << Const) | (1L << Constexpr) | (1L << Decltype) | (1L << Double) | (1L << Enum) | (1L << Explicit) | (1L << Extern) | (1L << Float) | (1L << Friend) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Mutable) | (1L << Namespace) | (1L << Operator) | (1L << Register) | (1L << Short) | (1L << Signed) | (1L << Static) | (1L << Static_assert))) != 0) || ((((_la - 65)) & ~0x3f) == 0 && ((1L << (_la - 65)) & ((1L << (Struct - 65)) | (1L << (Template - 65)) | (1L << (Thread_local - 65)) | (1L << (Typedef - 65)) | (1L << (Typename_ - 65)) | (1L << (Union - 65)) | (1L << (Unsigned - 65)) | (1L << (Using - 65)) | (1L << (Virtual - 65)) | (1L << (Void - 65)) | (1L << (Volatile - 65)) | (1L << (Wchar - 65)) | (1L << (LeftParen - 65)) | (1L << (LeftBracket - 65)) | (1L << (Star - 65)) | (1L << (And - 65)) | (1L << (Tilde - 65)) | (1L << (Doublecolon - 65)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (Semi - 129)) | (1L << (Ellipsis - 129)) | (1L << (Identifier - 129)))) != 0)) {
					{
					State = 1526;
					declarationseq(0);
					}
				}

				State = 1529;
				Match(RightBrace);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1530;
				Match(Extern);
				State = 1531;
				Match(Stringliteral);
				State = 1532;
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

	public partial class AttributespecifierseqContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierContext attributespecifier() {
			return GetRuleContext<AttributespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		public AttributespecifierseqContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attributespecifierseq; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAttributespecifierseq(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAttributespecifierseq(this);
		}
	}

	[RuleVersion(0)]
	public AttributespecifierseqContext attributespecifierseq() {
		return attributespecifierseq(0);
	}

	private AttributespecifierseqContext attributespecifierseq(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		AttributespecifierseqContext _localctx = new AttributespecifierseqContext(Context, _parentState);
		AttributespecifierseqContext _prevctx = _localctx;
		int _startState = 212;
		EnterRecursionRule(_localctx, 212, RULE_attributespecifierseq, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 1536;
			attributespecifier();
			}
			Context.Stop = TokenStream.LT(-1);
			State = 1542;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,153,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new AttributespecifierseqContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_attributespecifierseq);
					State = 1538;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 1539;
					attributespecifier();
					}
					} 
				}
				State = 1544;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,153,Context);
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

	public partial class AttributespecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LeftBracket() { return GetTokens(CPP14Parser.LeftBracket); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBracket(int i) {
			return GetToken(CPP14Parser.LeftBracket, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributelistContext attributelist() {
			return GetRuleContext<AttributelistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RightBracket() { return GetTokens(CPP14Parser.RightBracket); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBracket(int i) {
			return GetToken(CPP14Parser.RightBracket, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AlignmentspecifierContext alignmentspecifier() {
			return GetRuleContext<AlignmentspecifierContext>(0);
		}
		public AttributespecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attributespecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAttributespecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAttributespecifier(this);
		}
	}

	[RuleVersion(0)]
	public AttributespecifierContext attributespecifier() {
		AttributespecifierContext _localctx = new AttributespecifierContext(Context, State);
		EnterRule(_localctx, 214, RULE_attributespecifier);
		try {
			State = 1552;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case LeftBracket:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1545;
				Match(LeftBracket);
				State = 1546;
				Match(LeftBracket);
				State = 1547;
				attributelist(0);
				State = 1548;
				Match(RightBracket);
				State = 1549;
				Match(RightBracket);
				}
				break;
			case Alignas:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1551;
				alignmentspecifier();
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

	public partial class AlignmentspecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Alignas() { return GetToken(CPP14Parser.Alignas, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ThetypeidContext thetypeid() {
			return GetRuleContext<ThetypeidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ellipsis() { return GetToken(CPP14Parser.Ellipsis, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantexpressionContext constantexpression() {
			return GetRuleContext<ConstantexpressionContext>(0);
		}
		public AlignmentspecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_alignmentspecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAlignmentspecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAlignmentspecifier(this);
		}
	}

	[RuleVersion(0)]
	public AlignmentspecifierContext alignmentspecifier() {
		AlignmentspecifierContext _localctx = new AlignmentspecifierContext(Context, State);
		EnterRule(_localctx, 216, RULE_alignmentspecifier);
		int _la;
		try {
			State = 1570;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,157,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1554;
				Match(Alignas);
				State = 1555;
				Match(LeftParen);
				State = 1556;
				thetypeid();
				State = 1558;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Ellipsis) {
					{
					State = 1557;
					Match(Ellipsis);
					}
				}

				State = 1560;
				Match(RightParen);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1562;
				Match(Alignas);
				State = 1563;
				Match(LeftParen);
				State = 1564;
				constantexpression();
				State = 1566;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Ellipsis) {
					{
					State = 1565;
					Match(Ellipsis);
					}
				}

				State = 1568;
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

	public partial class AttributelistContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AttributeContext attribute() {
			return GetRuleContext<AttributeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ellipsis() { return GetToken(CPP14Parser.Ellipsis, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AttributelistContext attributelist() {
			return GetRuleContext<AttributelistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		public AttributelistContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attributelist; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAttributelist(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAttributelist(this);
		}
	}

	[RuleVersion(0)]
	public AttributelistContext attributelist() {
		return attributelist(0);
	}

	private AttributelistContext attributelist(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		AttributelistContext _localctx = new AttributelistContext(Context, _parentState);
		AttributelistContext _prevctx = _localctx;
		int _startState = 218;
		EnterRecursionRule(_localctx, 218, RULE_attributelist, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1579;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,159,Context) ) {
			case 1:
				{
				State = 1574;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,158,Context) ) {
				case 1:
					{
					State = 1573;
					attribute();
					}
					break;
				}
				}
				break;
			case 2:
				{
				State = 1576;
				attribute();
				State = 1577;
				Match(Ellipsis);
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 1593;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,162,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 1591;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,161,Context) ) {
					case 1:
						{
						_localctx = new AttributelistContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_attributelist);
						State = 1581;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 1582;
						Match(Comma);
						State = 1584;
						ErrorHandler.Sync(this);
						switch ( Interpreter.AdaptivePredict(TokenStream,160,Context) ) {
						case 1:
							{
							State = 1583;
							attribute();
							}
							break;
						}
						}
						break;
					case 2:
						{
						_localctx = new AttributelistContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_attributelist);
						State = 1586;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 1587;
						Match(Comma);
						State = 1588;
						attribute();
						State = 1589;
						Match(Ellipsis);
						}
						break;
					}
					} 
				}
				State = 1595;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,162,Context);
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

	public partial class AttributeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AttributetokenContext attributetoken() {
			return GetRuleContext<AttributetokenContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributeargumentclauseContext attributeargumentclause() {
			return GetRuleContext<AttributeargumentclauseContext>(0);
		}
		public AttributeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attribute; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAttribute(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAttribute(this);
		}
	}

	[RuleVersion(0)]
	public AttributeContext attribute() {
		AttributeContext _localctx = new AttributeContext(Context, State);
		EnterRule(_localctx, 220, RULE_attribute);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1596;
			attributetoken();
			State = 1598;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,163,Context) ) {
			case 1:
				{
				State = 1597;
				attributeargumentclause();
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

	public partial class AttributetokenContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AttributescopedtokenContext attributescopedtoken() {
			return GetRuleContext<AttributescopedtokenContext>(0);
		}
		public AttributetokenContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attributetoken; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAttributetoken(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAttributetoken(this);
		}
	}

	[RuleVersion(0)]
	public AttributetokenContext attributetoken() {
		AttributetokenContext _localctx = new AttributetokenContext(Context, State);
		EnterRule(_localctx, 222, RULE_attributetoken);
		try {
			State = 1602;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,164,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1600;
				Match(Identifier);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1601;
				attributescopedtoken();
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

	public partial class AttributescopedtokenContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AttributenamespaceContext attributenamespace() {
			return GetRuleContext<AttributenamespaceContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Doublecolon() { return GetToken(CPP14Parser.Doublecolon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		public AttributescopedtokenContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attributescopedtoken; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAttributescopedtoken(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAttributescopedtoken(this);
		}
	}

	[RuleVersion(0)]
	public AttributescopedtokenContext attributescopedtoken() {
		AttributescopedtokenContext _localctx = new AttributescopedtokenContext(Context, State);
		EnterRule(_localctx, 224, RULE_attributescopedtoken);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1604;
			attributenamespace();
			State = 1605;
			Match(Doublecolon);
			State = 1606;
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

	public partial class AttributenamespaceContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		public AttributenamespaceContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attributenamespace; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAttributenamespace(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAttributenamespace(this);
		}
	}

	[RuleVersion(0)]
	public AttributenamespaceContext attributenamespace() {
		AttributenamespaceContext _localctx = new AttributenamespaceContext(Context, State);
		EnterRule(_localctx, 226, RULE_attributenamespace);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1608;
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

	public partial class AttributeargumentclauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BalancedtokenseqContext balancedtokenseq() {
			return GetRuleContext<BalancedtokenseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		public AttributeargumentclauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attributeargumentclause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAttributeargumentclause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAttributeargumentclause(this);
		}
	}

	[RuleVersion(0)]
	public AttributeargumentclauseContext attributeargumentclause() {
		AttributeargumentclauseContext _localctx = new AttributeargumentclauseContext(Context, State);
		EnterRule(_localctx, 228, RULE_attributeargumentclause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1610;
			Match(LeftParen);
			State = 1611;
			balancedtokenseq(0);
			State = 1612;
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

	public partial class BalancedtokenseqContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BalancedtokenContext balancedtoken() {
			return GetRuleContext<BalancedtokenContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BalancedtokenseqContext balancedtokenseq() {
			return GetRuleContext<BalancedtokenseqContext>(0);
		}
		public BalancedtokenseqContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_balancedtokenseq; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterBalancedtokenseq(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitBalancedtokenseq(this);
		}
	}

	[RuleVersion(0)]
	public BalancedtokenseqContext balancedtokenseq() {
		return balancedtokenseq(0);
	}

	private BalancedtokenseqContext balancedtokenseq(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		BalancedtokenseqContext _localctx = new BalancedtokenseqContext(Context, _parentState);
		BalancedtokenseqContext _prevctx = _localctx;
		int _startState = 230;
		EnterRecursionRule(_localctx, 230, RULE_balancedtokenseq, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 1616;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,165,Context) ) {
			case 1:
				{
				State = 1615;
				balancedtoken();
				}
				break;
			}
			}
			Context.Stop = TokenStream.LT(-1);
			State = 1622;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,166,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new BalancedtokenseqContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_balancedtokenseq);
					State = 1618;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 1619;
					balancedtoken();
					}
					} 
				}
				State = 1624;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,166,Context);
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

	public partial class BalancedtokenContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LeftParen() { return GetTokens(CPP14Parser.LeftParen); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen(int i) {
			return GetToken(CPP14Parser.LeftParen, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BalancedtokenseqContext balancedtokenseq() {
			return GetRuleContext<BalancedtokenseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RightParen() { return GetTokens(CPP14Parser.RightParen); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen(int i) {
			return GetToken(CPP14Parser.RightParen, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LeftBracket() { return GetTokens(CPP14Parser.LeftBracket); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBracket(int i) {
			return GetToken(CPP14Parser.LeftBracket, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RightBracket() { return GetTokens(CPP14Parser.RightBracket); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBracket(int i) {
			return GetToken(CPP14Parser.RightBracket, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LeftBrace() { return GetTokens(CPP14Parser.LeftBrace); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBrace(int i) {
			return GetToken(CPP14Parser.LeftBrace, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RightBrace() { return GetTokens(CPP14Parser.RightBrace); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBrace(int i) {
			return GetToken(CPP14Parser.RightBrace, i);
		}
		public BalancedtokenContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_balancedtoken; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterBalancedtoken(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitBalancedtoken(this);
		}
	}

	[RuleVersion(0)]
	public BalancedtokenContext balancedtoken() {
		BalancedtokenContext _localctx = new BalancedtokenContext(Context, State);
		EnterRule(_localctx, 232, RULE_balancedtoken);
		int _la;
		try {
			int _alt;
			State = 1642;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case LeftParen:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1625;
				Match(LeftParen);
				State = 1626;
				balancedtokenseq(0);
				State = 1627;
				Match(RightParen);
				}
				break;
			case LeftBracket:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1629;
				Match(LeftBracket);
				State = 1630;
				balancedtokenseq(0);
				State = 1631;
				Match(RightBracket);
				}
				break;
			case LeftBrace:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1633;
				Match(LeftBrace);
				State = 1634;
				balancedtokenseq(0);
				State = 1635;
				Match(RightBrace);
				}
				break;
			case T__0:
			case T__1:
			case T__2:
			case T__3:
			case T__4:
			case T__5:
			case MultiLineMacro:
			case Directive:
			case Alignas:
			case Alignof:
			case Asm:
			case Auto:
			case Bool:
			case Break:
			case Case:
			case Catch:
			case Char:
			case Char16:
			case Char32:
			case Class:
			case Const:
			case Constexpr:
			case Const_cast:
			case Continue:
			case Decltype:
			case Default:
			case Delete:
			case Do:
			case Double:
			case Dynamic_cast:
			case Else:
			case Enum:
			case Explicit:
			case Export:
			case Extern:
			case False:
			case Final:
			case Float:
			case For:
			case Friend:
			case Goto:
			case If:
			case Inline:
			case Int:
			case Long:
			case Mutable:
			case Namespace:
			case New:
			case Noexcept:
			case Nullptr:
			case Operator:
			case Override:
			case Private:
			case Protected:
			case Public:
			case Register:
			case Reinterpret_cast:
			case Return:
			case Short:
			case Signed:
			case Sizeof:
			case Static:
			case Static_assert:
			case Static_cast:
			case Struct:
			case Switch:
			case Template:
			case This:
			case Thread_local:
			case Throw:
			case True:
			case Try:
			case Typedef:
			case Typeid_:
			case Typename_:
			case Union:
			case Unsigned:
			case Using:
			case Virtual:
			case Void:
			case Volatile:
			case Wchar:
			case While:
			case Plus:
			case Minus:
			case Star:
			case Div:
			case Mod:
			case Caret:
			case And:
			case Or:
			case Tilde:
			case Not:
			case Assign:
			case Less:
			case Greater:
			case PlusAssign:
			case MinusAssign:
			case StarAssign:
			case DivAssign:
			case ModAssign:
			case XorAssign:
			case AndAssign:
			case OrAssign:
			case LeftShift:
			case RightShift:
			case LeftShiftAssign:
			case RightShiftAssign:
			case Equal:
			case NotEqual:
			case LessEqual:
			case GreaterEqual:
			case AndAnd:
			case OrOr:
			case PlusPlus:
			case MinusMinus:
			case Comma:
			case ArrowStar:
			case Arrow:
			case Question:
			case Colon:
			case Doublecolon:
			case Semi:
			case Dot:
			case DotStar:
			case Ellipsis:
			case Identifier:
			case Integerliteral:
			case Decimalliteral:
			case Octalliteral:
			case Hexadecimalliteral:
			case Binaryliteral:
			case Integersuffix:
			case Characterliteral:
			case Floatingliteral:
			case Stringliteral:
			case Userdefinedintegerliteral:
			case Userdefinedfloatingliteral:
			case Userdefinedstringliteral:
			case Userdefinedcharacterliteral:
			case Whitespace:
			case Newline:
			case BlockComment:
			case LineComment:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1638;
				ErrorHandler.Sync(this);
				_alt = 1;
				do {
					switch (_alt) {
					case 1:
						{
						{
						State = 1637;
						_la = TokenStream.LA(1);
						if ( _la <= 0 || (((((_la - 84)) & ~0x3f) == 0 && ((1L << (_la - 84)) & ((1L << (LeftParen - 84)) | (1L << (RightParen - 84)) | (1L << (LeftBracket - 84)) | (1L << (RightBracket - 84)) | (1L << (LeftBrace - 84)) | (1L << (RightBrace - 84)))) != 0)) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						}
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					State = 1640;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,167,Context);
				} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
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

	public partial class InitdeclaratorlistContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public InitdeclaratorContext initdeclarator() {
			return GetRuleContext<InitdeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InitdeclaratorlistContext initdeclaratorlist() {
			return GetRuleContext<InitdeclaratorlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		public InitdeclaratorlistContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_initdeclaratorlist; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterInitdeclaratorlist(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitInitdeclaratorlist(this);
		}
	}

	[RuleVersion(0)]
	public InitdeclaratorlistContext initdeclaratorlist() {
		return initdeclaratorlist(0);
	}

	private InitdeclaratorlistContext initdeclaratorlist(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		InitdeclaratorlistContext _localctx = new InitdeclaratorlistContext(Context, _parentState);
		InitdeclaratorlistContext _prevctx = _localctx;
		int _startState = 234;
		EnterRecursionRule(_localctx, 234, RULE_initdeclaratorlist, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 1645;
			initdeclarator();
			}
			Context.Stop = TokenStream.LT(-1);
			State = 1652;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,169,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new InitdeclaratorlistContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_initdeclaratorlist);
					State = 1647;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 1648;
					Match(Comma);
					State = 1649;
					initdeclarator();
					}
					} 
				}
				State = 1654;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,169,Context);
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

	public partial class InitdeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclaratorContext declarator() {
			return GetRuleContext<DeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InitializerContext initializer() {
			return GetRuleContext<InitializerContext>(0);
		}
		public InitdeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_initdeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterInitdeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitInitdeclarator(this);
		}
	}

	[RuleVersion(0)]
	public InitdeclaratorContext initdeclarator() {
		InitdeclaratorContext _localctx = new InitdeclaratorContext(Context, State);
		EnterRule(_localctx, 236, RULE_initdeclarator);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1655;
			declarator();
			State = 1657;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,170,Context) ) {
			case 1:
				{
				State = 1656;
				initializer();
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

	public partial class DeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PtrdeclaratorContext ptrdeclarator() {
			return GetRuleContext<PtrdeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NoptrdeclaratorContext noptrdeclarator() {
			return GetRuleContext<NoptrdeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ParametersandqualifiersContext parametersandqualifiers() {
			return GetRuleContext<ParametersandqualifiersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TrailingreturntypeContext trailingreturntype() {
			return GetRuleContext<TrailingreturntypeContext>(0);
		}
		public DeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterDeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitDeclarator(this);
		}
	}

	[RuleVersion(0)]
	public DeclaratorContext declarator() {
		DeclaratorContext _localctx = new DeclaratorContext(Context, State);
		EnterRule(_localctx, 238, RULE_declarator);
		try {
			State = 1664;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,171,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1659;
				ptrdeclarator();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1660;
				noptrdeclarator(0);
				State = 1661;
				parametersandqualifiers();
				State = 1662;
				trailingreturntype();
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

	public partial class PtrdeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public NoptrdeclaratorContext noptrdeclarator() {
			return GetRuleContext<NoptrdeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PtroperatorContext ptroperator() {
			return GetRuleContext<PtroperatorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PtrdeclaratorContext ptrdeclarator() {
			return GetRuleContext<PtrdeclaratorContext>(0);
		}
		public PtrdeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ptrdeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterPtrdeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitPtrdeclarator(this);
		}
	}

	[RuleVersion(0)]
	public PtrdeclaratorContext ptrdeclarator() {
		PtrdeclaratorContext _localctx = new PtrdeclaratorContext(Context, State);
		EnterRule(_localctx, 240, RULE_ptrdeclarator);
		try {
			State = 1670;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,172,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1666;
				noptrdeclarator(0);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1667;
				ptroperator();
				State = 1668;
				ptrdeclarator();
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

	public partial class NoptrdeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclaratoridContext declaratorid() {
			return GetRuleContext<DeclaratoridContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public PtrdeclaratorContext ptrdeclarator() {
			return GetRuleContext<PtrdeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NoptrdeclaratorContext noptrdeclarator() {
			return GetRuleContext<NoptrdeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ParametersandqualifiersContext parametersandqualifiers() {
			return GetRuleContext<ParametersandqualifiersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBracket() { return GetToken(CPP14Parser.LeftBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBracket() { return GetToken(CPP14Parser.RightBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantexpressionContext constantexpression() {
			return GetRuleContext<ConstantexpressionContext>(0);
		}
		public NoptrdeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_noptrdeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterNoptrdeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitNoptrdeclarator(this);
		}
	}

	[RuleVersion(0)]
	public NoptrdeclaratorContext noptrdeclarator() {
		return noptrdeclarator(0);
	}

	private NoptrdeclaratorContext noptrdeclarator(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		NoptrdeclaratorContext _localctx = new NoptrdeclaratorContext(Context, _parentState);
		NoptrdeclaratorContext _prevctx = _localctx;
		int _startState = 242;
		EnterRecursionRule(_localctx, 242, RULE_noptrdeclarator, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1681;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Decltype:
			case Operator:
			case Tilde:
			case Doublecolon:
			case Ellipsis:
			case Identifier:
				{
				State = 1673;
				declaratorid();
				State = 1675;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,173,Context) ) {
				case 1:
					{
					State = 1674;
					attributespecifierseq(0);
					}
					break;
				}
				}
				break;
			case LeftParen:
				{
				State = 1677;
				Match(LeftParen);
				State = 1678;
				ptrdeclarator();
				State = 1679;
				Match(RightParen);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 1696;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,178,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 1694;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,177,Context) ) {
					case 1:
						{
						_localctx = new NoptrdeclaratorContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_noptrdeclarator);
						State = 1683;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 1684;
						parametersandqualifiers();
						}
						break;
					case 2:
						{
						_localctx = new NoptrdeclaratorContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_noptrdeclarator);
						State = 1685;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 1686;
						Match(LeftBracket);
						State = 1688;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << Alignof) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Const_cast) | (1L << Decltype) | (1L << Delete) | (1L << Double) | (1L << Dynamic_cast) | (1L << False) | (1L << Float) | (1L << Int) | (1L << Long) | (1L << New) | (1L << Noexcept) | (1L << Nullptr) | (1L << Operator) | (1L << Reinterpret_cast) | (1L << Short) | (1L << Signed) | (1L << Sizeof))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Static_cast - 64)) | (1L << (This - 64)) | (1L << (True - 64)) | (1L << (Typeid_ - 64)) | (1L << (Typename_ - 64)) | (1L << (Unsigned - 64)) | (1L << (Void - 64)) | (1L << (Wchar - 64)) | (1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (Plus - 64)) | (1L << (Minus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (Or - 64)) | (1L << (Tilde - 64)) | (1L << (PlusPlus - 64)) | (1L << (MinusMinus - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (Doublecolon - 128)) | (1L << (Identifier - 128)) | (1L << (Integerliteral - 128)) | (1L << (Characterliteral - 128)) | (1L << (Floatingliteral - 128)) | (1L << (Stringliteral - 128)) | (1L << (Userdefinedintegerliteral - 128)) | (1L << (Userdefinedfloatingliteral - 128)) | (1L << (Userdefinedstringliteral - 128)) | (1L << (Userdefinedcharacterliteral - 128)))) != 0)) {
							{
							State = 1687;
							constantexpression();
							}
						}

						State = 1690;
						Match(RightBracket);
						State = 1692;
						ErrorHandler.Sync(this);
						switch ( Interpreter.AdaptivePredict(TokenStream,176,Context) ) {
						case 1:
							{
							State = 1691;
							attributespecifierseq(0);
							}
							break;
						}
						}
						break;
					}
					} 
				}
				State = 1698;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,178,Context);
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

	public partial class ParametersandqualifiersContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ParameterdeclarationclauseContext parameterdeclarationclause() {
			return GetRuleContext<ParameterdeclarationclauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public CvqualifierseqContext cvqualifierseq() {
			return GetRuleContext<CvqualifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public RefqualifierContext refqualifier() {
			return GetRuleContext<RefqualifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExceptionspecificationContext exceptionspecification() {
			return GetRuleContext<ExceptionspecificationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		public ParametersandqualifiersContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parametersandqualifiers; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterParametersandqualifiers(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitParametersandqualifiers(this);
		}
	}

	[RuleVersion(0)]
	public ParametersandqualifiersContext parametersandqualifiers() {
		ParametersandqualifiersContext _localctx = new ParametersandqualifiersContext(Context, State);
		EnterRule(_localctx, 244, RULE_parametersandqualifiers);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1699;
			Match(LeftParen);
			State = 1700;
			parameterdeclarationclause();
			State = 1701;
			Match(RightParen);
			State = 1703;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,179,Context) ) {
			case 1:
				{
				State = 1702;
				cvqualifierseq();
				}
				break;
			}
			State = 1706;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,180,Context) ) {
			case 1:
				{
				State = 1705;
				refqualifier();
				}
				break;
			}
			State = 1709;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,181,Context) ) {
			case 1:
				{
				State = 1708;
				exceptionspecification();
				}
				break;
			}
			State = 1712;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,182,Context) ) {
			case 1:
				{
				State = 1711;
				attributespecifierseq(0);
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

	public partial class TrailingreturntypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Arrow() { return GetToken(CPP14Parser.Arrow, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TrailingtypespecifierseqContext trailingtypespecifierseq() {
			return GetRuleContext<TrailingtypespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AbstractdeclaratorContext abstractdeclarator() {
			return GetRuleContext<AbstractdeclaratorContext>(0);
		}
		public TrailingreturntypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_trailingreturntype; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTrailingreturntype(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTrailingreturntype(this);
		}
	}

	[RuleVersion(0)]
	public TrailingreturntypeContext trailingreturntype() {
		TrailingreturntypeContext _localctx = new TrailingreturntypeContext(Context, State);
		EnterRule(_localctx, 246, RULE_trailingreturntype);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1714;
			Match(Arrow);
			State = 1715;
			trailingtypespecifierseq();
			State = 1717;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,183,Context) ) {
			case 1:
				{
				State = 1716;
				abstractdeclarator();
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

	public partial class PtroperatorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Star() { return GetToken(CPP14Parser.Star, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CvqualifierseqContext cvqualifierseq() {
			return GetRuleContext<CvqualifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode And() { return GetToken(CPP14Parser.And, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NestednamespecifierContext nestednamespecifier() {
			return GetRuleContext<NestednamespecifierContext>(0);
		}
		public PtroperatorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ptroperator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterPtroperator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitPtroperator(this);
		}
	}

	[RuleVersion(0)]
	public PtroperatorContext ptroperator() {
		PtroperatorContext _localctx = new PtroperatorContext(Context, State);
		EnterRule(_localctx, 248, RULE_ptroperator);
		try {
			State = 1742;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Star:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1719;
				Match(Star);
				State = 1721;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,184,Context) ) {
				case 1:
					{
					State = 1720;
					attributespecifierseq(0);
					}
					break;
				}
				State = 1724;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,185,Context) ) {
				case 1:
					{
					State = 1723;
					cvqualifierseq();
					}
					break;
				}
				}
				break;
			case And:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1726;
				Match(And);
				State = 1728;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,186,Context) ) {
				case 1:
					{
					State = 1727;
					attributespecifierseq(0);
					}
					break;
				}
				}
				break;
			case T__2:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1730;
				Match(T__2);
				State = 1732;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,187,Context) ) {
				case 1:
					{
					State = 1731;
					attributespecifierseq(0);
					}
					break;
				}
				}
				break;
			case Decltype:
			case Doublecolon:
			case Identifier:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1734;
				nestednamespecifier(0);
				State = 1735;
				Match(Star);
				State = 1737;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,188,Context) ) {
				case 1:
					{
					State = 1736;
					attributespecifierseq(0);
					}
					break;
				}
				State = 1740;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,189,Context) ) {
				case 1:
					{
					State = 1739;
					cvqualifierseq();
					}
					break;
				}
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

	public partial class CvqualifierseqContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public CvqualifierContext cvqualifier() {
			return GetRuleContext<CvqualifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CvqualifierseqContext cvqualifierseq() {
			return GetRuleContext<CvqualifierseqContext>(0);
		}
		public CvqualifierseqContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_cvqualifierseq; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterCvqualifierseq(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitCvqualifierseq(this);
		}
	}

	[RuleVersion(0)]
	public CvqualifierseqContext cvqualifierseq() {
		CvqualifierseqContext _localctx = new CvqualifierseqContext(Context, State);
		EnterRule(_localctx, 250, RULE_cvqualifierseq);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1744;
			cvqualifier();
			State = 1746;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,191,Context) ) {
			case 1:
				{
				State = 1745;
				cvqualifierseq();
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

	public partial class CvqualifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Const() { return GetToken(CPP14Parser.Const, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Volatile() { return GetToken(CPP14Parser.Volatile, 0); }
		public CvqualifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_cvqualifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterCvqualifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitCvqualifier(this);
		}
	}

	[RuleVersion(0)]
	public CvqualifierContext cvqualifier() {
		CvqualifierContext _localctx = new CvqualifierContext(Context, State);
		EnterRule(_localctx, 252, RULE_cvqualifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1748;
			_la = TokenStream.LA(1);
			if ( !(_la==Const || _la==Volatile) ) {
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

	public partial class RefqualifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode And() { return GetToken(CPP14Parser.And, 0); }
		public RefqualifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_refqualifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterRefqualifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitRefqualifier(this);
		}
	}

	[RuleVersion(0)]
	public RefqualifierContext refqualifier() {
		RefqualifierContext _localctx = new RefqualifierContext(Context, State);
		EnterRule(_localctx, 254, RULE_refqualifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1750;
			_la = TokenStream.LA(1);
			if ( !(_la==T__2 || _la==And) ) {
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

	public partial class DeclaratoridContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdexpressionContext idexpression() {
			return GetRuleContext<IdexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ellipsis() { return GetToken(CPP14Parser.Ellipsis, 0); }
		public DeclaratoridContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declaratorid; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterDeclaratorid(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitDeclaratorid(this);
		}
	}

	[RuleVersion(0)]
	public DeclaratoridContext declaratorid() {
		DeclaratoridContext _localctx = new DeclaratoridContext(Context, State);
		EnterRule(_localctx, 256, RULE_declaratorid);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1753;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Ellipsis) {
				{
				State = 1752;
				Match(Ellipsis);
				}
			}

			State = 1755;
			idexpression();
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

	public partial class ThetypeidContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TypespecifierseqContext typespecifierseq() {
			return GetRuleContext<TypespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AbstractdeclaratorContext abstractdeclarator() {
			return GetRuleContext<AbstractdeclaratorContext>(0);
		}
		public ThetypeidContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_thetypeid; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterThetypeid(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitThetypeid(this);
		}
	}

	[RuleVersion(0)]
	public ThetypeidContext thetypeid() {
		ThetypeidContext _localctx = new ThetypeidContext(Context, State);
		EnterRule(_localctx, 258, RULE_thetypeid);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1757;
			typespecifierseq();
			State = 1759;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,193,Context) ) {
			case 1:
				{
				State = 1758;
				abstractdeclarator();
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

	public partial class AbstractdeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PtrabstractdeclaratorContext ptrabstractdeclarator() {
			return GetRuleContext<PtrabstractdeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ParametersandqualifiersContext parametersandqualifiers() {
			return GetRuleContext<ParametersandqualifiersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TrailingreturntypeContext trailingreturntype() {
			return GetRuleContext<TrailingreturntypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NoptrabstractdeclaratorContext noptrabstractdeclarator() {
			return GetRuleContext<NoptrabstractdeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AbstractpackdeclaratorContext abstractpackdeclarator() {
			return GetRuleContext<AbstractpackdeclaratorContext>(0);
		}
		public AbstractdeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_abstractdeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAbstractdeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAbstractdeclarator(this);
		}
	}

	[RuleVersion(0)]
	public AbstractdeclaratorContext abstractdeclarator() {
		AbstractdeclaratorContext _localctx = new AbstractdeclaratorContext(Context, State);
		EnterRule(_localctx, 260, RULE_abstractdeclarator);
		try {
			State = 1769;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,195,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1761;
				ptrabstractdeclarator();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1763;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,194,Context) ) {
				case 1:
					{
					State = 1762;
					noptrabstractdeclarator(0);
					}
					break;
				}
				State = 1765;
				parametersandqualifiers();
				State = 1766;
				trailingreturntype();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1768;
				abstractpackdeclarator();
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

	public partial class PtrabstractdeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public NoptrabstractdeclaratorContext noptrabstractdeclarator() {
			return GetRuleContext<NoptrabstractdeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PtroperatorContext ptroperator() {
			return GetRuleContext<PtroperatorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PtrabstractdeclaratorContext ptrabstractdeclarator() {
			return GetRuleContext<PtrabstractdeclaratorContext>(0);
		}
		public PtrabstractdeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ptrabstractdeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterPtrabstractdeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitPtrabstractdeclarator(this);
		}
	}

	[RuleVersion(0)]
	public PtrabstractdeclaratorContext ptrabstractdeclarator() {
		PtrabstractdeclaratorContext _localctx = new PtrabstractdeclaratorContext(Context, State);
		EnterRule(_localctx, 262, RULE_ptrabstractdeclarator);
		try {
			State = 1776;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case LeftParen:
			case LeftBracket:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1771;
				noptrabstractdeclarator(0);
				}
				break;
			case T__2:
			case Decltype:
			case Star:
			case And:
			case Doublecolon:
			case Identifier:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1772;
				ptroperator();
				State = 1774;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,196,Context) ) {
				case 1:
					{
					State = 1773;
					ptrabstractdeclarator();
					}
					break;
				}
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

	public partial class NoptrabstractdeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ParametersandqualifiersContext parametersandqualifiers() {
			return GetRuleContext<ParametersandqualifiersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBracket() { return GetToken(CPP14Parser.LeftBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBracket() { return GetToken(CPP14Parser.RightBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantexpressionContext constantexpression() {
			return GetRuleContext<ConstantexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public PtrabstractdeclaratorContext ptrabstractdeclarator() {
			return GetRuleContext<PtrabstractdeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NoptrabstractdeclaratorContext noptrabstractdeclarator() {
			return GetRuleContext<NoptrabstractdeclaratorContext>(0);
		}
		public NoptrabstractdeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_noptrabstractdeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterNoptrabstractdeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitNoptrabstractdeclarator(this);
		}
	}

	[RuleVersion(0)]
	public NoptrabstractdeclaratorContext noptrabstractdeclarator() {
		return noptrabstractdeclarator(0);
	}

	private NoptrabstractdeclaratorContext noptrabstractdeclarator(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		NoptrabstractdeclaratorContext _localctx = new NoptrabstractdeclaratorContext(Context, _parentState);
		NoptrabstractdeclaratorContext _prevctx = _localctx;
		int _startState = 264;
		EnterRecursionRule(_localctx, 264, RULE_noptrabstractdeclarator, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1792;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,200,Context) ) {
			case 1:
				{
				State = 1779;
				parametersandqualifiers();
				}
				break;
			case 2:
				{
				State = 1780;
				Match(LeftBracket);
				State = 1782;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << Alignof) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Const_cast) | (1L << Decltype) | (1L << Delete) | (1L << Double) | (1L << Dynamic_cast) | (1L << False) | (1L << Float) | (1L << Int) | (1L << Long) | (1L << New) | (1L << Noexcept) | (1L << Nullptr) | (1L << Operator) | (1L << Reinterpret_cast) | (1L << Short) | (1L << Signed) | (1L << Sizeof))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Static_cast - 64)) | (1L << (This - 64)) | (1L << (True - 64)) | (1L << (Typeid_ - 64)) | (1L << (Typename_ - 64)) | (1L << (Unsigned - 64)) | (1L << (Void - 64)) | (1L << (Wchar - 64)) | (1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (Plus - 64)) | (1L << (Minus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (Or - 64)) | (1L << (Tilde - 64)) | (1L << (PlusPlus - 64)) | (1L << (MinusMinus - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (Doublecolon - 128)) | (1L << (Identifier - 128)) | (1L << (Integerliteral - 128)) | (1L << (Characterliteral - 128)) | (1L << (Floatingliteral - 128)) | (1L << (Stringliteral - 128)) | (1L << (Userdefinedintegerliteral - 128)) | (1L << (Userdefinedfloatingliteral - 128)) | (1L << (Userdefinedstringliteral - 128)) | (1L << (Userdefinedcharacterliteral - 128)))) != 0)) {
					{
					State = 1781;
					constantexpression();
					}
				}

				State = 1784;
				Match(RightBracket);
				State = 1786;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,199,Context) ) {
				case 1:
					{
					State = 1785;
					attributespecifierseq(0);
					}
					break;
				}
				}
				break;
			case 3:
				{
				State = 1788;
				Match(LeftParen);
				State = 1789;
				ptrabstractdeclarator();
				State = 1790;
				Match(RightParen);
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 1807;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,204,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 1805;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,203,Context) ) {
					case 1:
						{
						_localctx = new NoptrabstractdeclaratorContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_noptrabstractdeclarator);
						State = 1794;
						if (!(Precpred(Context, 5))) throw new FailedPredicateException(this, "Precpred(Context, 5)");
						State = 1795;
						parametersandqualifiers();
						}
						break;
					case 2:
						{
						_localctx = new NoptrabstractdeclaratorContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_noptrabstractdeclarator);
						State = 1796;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 1797;
						Match(LeftBracket);
						State = 1799;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << Alignof) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Const_cast) | (1L << Decltype) | (1L << Delete) | (1L << Double) | (1L << Dynamic_cast) | (1L << False) | (1L << Float) | (1L << Int) | (1L << Long) | (1L << New) | (1L << Noexcept) | (1L << Nullptr) | (1L << Operator) | (1L << Reinterpret_cast) | (1L << Short) | (1L << Signed) | (1L << Sizeof))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Static_cast - 64)) | (1L << (This - 64)) | (1L << (True - 64)) | (1L << (Typeid_ - 64)) | (1L << (Typename_ - 64)) | (1L << (Unsigned - 64)) | (1L << (Void - 64)) | (1L << (Wchar - 64)) | (1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (Plus - 64)) | (1L << (Minus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (Or - 64)) | (1L << (Tilde - 64)) | (1L << (PlusPlus - 64)) | (1L << (MinusMinus - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (Doublecolon - 128)) | (1L << (Identifier - 128)) | (1L << (Integerliteral - 128)) | (1L << (Characterliteral - 128)) | (1L << (Floatingliteral - 128)) | (1L << (Stringliteral - 128)) | (1L << (Userdefinedintegerliteral - 128)) | (1L << (Userdefinedfloatingliteral - 128)) | (1L << (Userdefinedstringliteral - 128)) | (1L << (Userdefinedcharacterliteral - 128)))) != 0)) {
							{
							State = 1798;
							constantexpression();
							}
						}

						State = 1801;
						Match(RightBracket);
						State = 1803;
						ErrorHandler.Sync(this);
						switch ( Interpreter.AdaptivePredict(TokenStream,202,Context) ) {
						case 1:
							{
							State = 1802;
							attributespecifierseq(0);
							}
							break;
						}
						}
						break;
					}
					} 
				}
				State = 1809;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,204,Context);
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

	public partial class AbstractpackdeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public NoptrabstractpackdeclaratorContext noptrabstractpackdeclarator() {
			return GetRuleContext<NoptrabstractpackdeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PtroperatorContext ptroperator() {
			return GetRuleContext<PtroperatorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AbstractpackdeclaratorContext abstractpackdeclarator() {
			return GetRuleContext<AbstractpackdeclaratorContext>(0);
		}
		public AbstractpackdeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_abstractpackdeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAbstractpackdeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAbstractpackdeclarator(this);
		}
	}

	[RuleVersion(0)]
	public AbstractpackdeclaratorContext abstractpackdeclarator() {
		AbstractpackdeclaratorContext _localctx = new AbstractpackdeclaratorContext(Context, State);
		EnterRule(_localctx, 266, RULE_abstractpackdeclarator);
		try {
			State = 1814;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Ellipsis:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1810;
				noptrabstractpackdeclarator(0);
				}
				break;
			case T__2:
			case Decltype:
			case Star:
			case And:
			case Doublecolon:
			case Identifier:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1811;
				ptroperator();
				State = 1812;
				abstractpackdeclarator();
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

	public partial class NoptrabstractpackdeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ellipsis() { return GetToken(CPP14Parser.Ellipsis, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NoptrabstractpackdeclaratorContext noptrabstractpackdeclarator() {
			return GetRuleContext<NoptrabstractpackdeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ParametersandqualifiersContext parametersandqualifiers() {
			return GetRuleContext<ParametersandqualifiersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBracket() { return GetToken(CPP14Parser.LeftBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBracket() { return GetToken(CPP14Parser.RightBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantexpressionContext constantexpression() {
			return GetRuleContext<ConstantexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		public NoptrabstractpackdeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_noptrabstractpackdeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterNoptrabstractpackdeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitNoptrabstractpackdeclarator(this);
		}
	}

	[RuleVersion(0)]
	public NoptrabstractpackdeclaratorContext noptrabstractpackdeclarator() {
		return noptrabstractpackdeclarator(0);
	}

	private NoptrabstractpackdeclaratorContext noptrabstractpackdeclarator(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		NoptrabstractpackdeclaratorContext _localctx = new NoptrabstractpackdeclaratorContext(Context, _parentState);
		NoptrabstractpackdeclaratorContext _prevctx = _localctx;
		int _startState = 268;
		EnterRecursionRule(_localctx, 268, RULE_noptrabstractpackdeclarator, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 1817;
			Match(Ellipsis);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 1832;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,209,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 1830;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,208,Context) ) {
					case 1:
						{
						_localctx = new NoptrabstractpackdeclaratorContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_noptrabstractpackdeclarator);
						State = 1819;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 1820;
						parametersandqualifiers();
						}
						break;
					case 2:
						{
						_localctx = new NoptrabstractpackdeclaratorContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_noptrabstractpackdeclarator);
						State = 1821;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 1822;
						Match(LeftBracket);
						State = 1824;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << Alignof) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Const_cast) | (1L << Decltype) | (1L << Delete) | (1L << Double) | (1L << Dynamic_cast) | (1L << False) | (1L << Float) | (1L << Int) | (1L << Long) | (1L << New) | (1L << Noexcept) | (1L << Nullptr) | (1L << Operator) | (1L << Reinterpret_cast) | (1L << Short) | (1L << Signed) | (1L << Sizeof))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Static_cast - 64)) | (1L << (This - 64)) | (1L << (True - 64)) | (1L << (Typeid_ - 64)) | (1L << (Typename_ - 64)) | (1L << (Unsigned - 64)) | (1L << (Void - 64)) | (1L << (Wchar - 64)) | (1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (Plus - 64)) | (1L << (Minus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (Or - 64)) | (1L << (Tilde - 64)) | (1L << (PlusPlus - 64)) | (1L << (MinusMinus - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (Doublecolon - 128)) | (1L << (Identifier - 128)) | (1L << (Integerliteral - 128)) | (1L << (Characterliteral - 128)) | (1L << (Floatingliteral - 128)) | (1L << (Stringliteral - 128)) | (1L << (Userdefinedintegerliteral - 128)) | (1L << (Userdefinedfloatingliteral - 128)) | (1L << (Userdefinedstringliteral - 128)) | (1L << (Userdefinedcharacterliteral - 128)))) != 0)) {
							{
							State = 1823;
							constantexpression();
							}
						}

						State = 1826;
						Match(RightBracket);
						State = 1828;
						ErrorHandler.Sync(this);
						switch ( Interpreter.AdaptivePredict(TokenStream,207,Context) ) {
						case 1:
							{
							State = 1827;
							attributespecifierseq(0);
							}
							break;
						}
						}
						break;
					}
					} 
				}
				State = 1834;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,209,Context);
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

	public partial class ParameterdeclarationclauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ParameterdeclarationlistContext parameterdeclarationlist() {
			return GetRuleContext<ParameterdeclarationlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ellipsis() { return GetToken(CPP14Parser.Ellipsis, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		public ParameterdeclarationclauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parameterdeclarationclause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterParameterdeclarationclause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitParameterdeclarationclause(this);
		}
	}

	[RuleVersion(0)]
	public ParameterdeclarationclauseContext parameterdeclarationclause() {
		ParameterdeclarationclauseContext _localctx = new ParameterdeclarationclauseContext(Context, State);
		EnterRule(_localctx, 270, RULE_parameterdeclarationclause);
		int _la;
		try {
			State = 1845;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,212,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1836;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (((((_la - 9)) & ~0x3f) == 0 && ((1L << (_la - 9)) & ((1L << (Alignas - 9)) | (1L << (Auto - 9)) | (1L << (Bool - 9)) | (1L << (Char - 9)) | (1L << (Char16 - 9)) | (1L << (Char32 - 9)) | (1L << (Class - 9)) | (1L << (Const - 9)) | (1L << (Constexpr - 9)) | (1L << (Decltype - 9)) | (1L << (Double - 9)) | (1L << (Enum - 9)) | (1L << (Explicit - 9)) | (1L << (Extern - 9)) | (1L << (Float - 9)) | (1L << (Friend - 9)) | (1L << (Inline - 9)) | (1L << (Int - 9)) | (1L << (Long - 9)) | (1L << (Mutable - 9)) | (1L << (Register - 9)) | (1L << (Short - 9)) | (1L << (Signed - 9)) | (1L << (Static - 9)) | (1L << (Struct - 9)) | (1L << (Thread_local - 9)))) != 0) || ((((_la - 73)) & ~0x3f) == 0 && ((1L << (_la - 73)) & ((1L << (Typedef - 73)) | (1L << (Typename_ - 73)) | (1L << (Union - 73)) | (1L << (Unsigned - 73)) | (1L << (Virtual - 73)) | (1L << (Void - 73)) | (1L << (Volatile - 73)) | (1L << (Wchar - 73)) | (1L << (LeftBracket - 73)) | (1L << (Doublecolon - 73)) | (1L << (Identifier - 73)))) != 0)) {
					{
					State = 1835;
					parameterdeclarationlist(0);
					}
				}

				State = 1839;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Ellipsis) {
					{
					State = 1838;
					Match(Ellipsis);
					}
				}

				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1841;
				parameterdeclarationlist(0);
				State = 1842;
				Match(Comma);
				State = 1843;
				Match(Ellipsis);
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

	public partial class ParameterdeclarationlistContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ParameterdeclarationContext parameterdeclaration() {
			return GetRuleContext<ParameterdeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ParameterdeclarationlistContext parameterdeclarationlist() {
			return GetRuleContext<ParameterdeclarationlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		public ParameterdeclarationlistContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parameterdeclarationlist; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterParameterdeclarationlist(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitParameterdeclarationlist(this);
		}
	}

	[RuleVersion(0)]
	public ParameterdeclarationlistContext parameterdeclarationlist() {
		return parameterdeclarationlist(0);
	}

	private ParameterdeclarationlistContext parameterdeclarationlist(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ParameterdeclarationlistContext _localctx = new ParameterdeclarationlistContext(Context, _parentState);
		ParameterdeclarationlistContext _prevctx = _localctx;
		int _startState = 272;
		EnterRecursionRule(_localctx, 272, RULE_parameterdeclarationlist, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 1848;
			parameterdeclaration();
			}
			Context.Stop = TokenStream.LT(-1);
			State = 1855;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,213,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new ParameterdeclarationlistContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_parameterdeclarationlist);
					State = 1850;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 1851;
					Match(Comma);
					State = 1852;
					parameterdeclaration();
					}
					} 
				}
				State = 1857;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,213,Context);
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

	public partial class ParameterdeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclspecifierseqContext declspecifierseq() {
			return GetRuleContext<DeclspecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclaratorContext declarator() {
			return GetRuleContext<DeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Assign() { return GetToken(CPP14Parser.Assign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InitializerclauseContext initializerclause() {
			return GetRuleContext<InitializerclauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AbstractdeclaratorContext abstractdeclarator() {
			return GetRuleContext<AbstractdeclaratorContext>(0);
		}
		public ParameterdeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parameterdeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterParameterdeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitParameterdeclaration(this);
		}
	}

	[RuleVersion(0)]
	public ParameterdeclarationContext parameterdeclaration() {
		ParameterdeclarationContext _localctx = new ParameterdeclarationContext(Context, State);
		EnterRule(_localctx, 274, RULE_parameterdeclaration);
		int _la;
		try {
			State = 1889;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,220,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1859;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 1858;
					attributespecifierseq(0);
					}
				}

				State = 1861;
				declspecifierseq();
				State = 1862;
				declarator();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1865;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 1864;
					attributespecifierseq(0);
					}
				}

				State = 1867;
				declspecifierseq();
				State = 1868;
				declarator();
				State = 1869;
				Match(Assign);
				State = 1870;
				initializerclause();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1873;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 1872;
					attributespecifierseq(0);
					}
				}

				State = 1875;
				declspecifierseq();
				State = 1877;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,217,Context) ) {
				case 1:
					{
					State = 1876;
					abstractdeclarator();
					}
					break;
				}
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1880;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 1879;
					attributespecifierseq(0);
					}
				}

				State = 1882;
				declspecifierseq();
				State = 1884;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==T__2 || _la==Decltype || ((((_la - 84)) & ~0x3f) == 0 && ((1L << (_la - 84)) & ((1L << (LeftParen - 84)) | (1L << (LeftBracket - 84)) | (1L << (Star - 84)) | (1L << (And - 84)) | (1L << (Doublecolon - 84)) | (1L << (Ellipsis - 84)) | (1L << (Identifier - 84)))) != 0)) {
					{
					State = 1883;
					abstractdeclarator();
					}
				}

				State = 1886;
				Match(Assign);
				State = 1887;
				initializerclause();
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

	public partial class FunctiondefinitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclaratorContext declarator() {
			return GetRuleContext<DeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FunctionbodyContext functionbody() {
			return GetRuleContext<FunctionbodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclspecifierseqContext declspecifierseq() {
			return GetRuleContext<DeclspecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VirtspecifierseqContext virtspecifierseq() {
			return GetRuleContext<VirtspecifierseqContext>(0);
		}
		public FunctiondefinitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_functiondefinition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterFunctiondefinition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitFunctiondefinition(this);
		}
	}

	[RuleVersion(0)]
	public FunctiondefinitionContext functiondefinition() {
		FunctiondefinitionContext _localctx = new FunctiondefinitionContext(Context, State);
		EnterRule(_localctx, 276, RULE_functiondefinition);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1892;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Alignas || _la==LeftBracket) {
				{
				State = 1891;
				attributespecifierseq(0);
				}
			}

			State = 1895;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,222,Context) ) {
			case 1:
				{
				State = 1894;
				declspecifierseq();
				}
				break;
			}
			State = 1897;
			declarator();
			State = 1899;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Final || _la==Override) {
				{
				State = 1898;
				virtspecifierseq(0);
				}
			}

			State = 1901;
			functionbody();
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

	public partial class FunctionbodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public CompoundstatementContext compoundstatement() {
			return GetRuleContext<CompoundstatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CtorinitializerContext ctorinitializer() {
			return GetRuleContext<CtorinitializerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FunctiontryblockContext functiontryblock() {
			return GetRuleContext<FunctiontryblockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Assign() { return GetToken(CPP14Parser.Assign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Default() { return GetToken(CPP14Parser.Default, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CPP14Parser.Semi, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Delete() { return GetToken(CPP14Parser.Delete, 0); }
		public FunctionbodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_functionbody; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterFunctionbody(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitFunctionbody(this);
		}
	}

	[RuleVersion(0)]
	public FunctionbodyContext functionbody() {
		FunctionbodyContext _localctx = new FunctionbodyContext(Context, State);
		EnterRule(_localctx, 278, RULE_functionbody);
		int _la;
		try {
			State = 1914;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,225,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1904;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Colon) {
					{
					State = 1903;
					ctorinitializer();
					}
				}

				State = 1906;
				compoundstatement();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1907;
				functiontryblock();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1908;
				Match(Assign);
				State = 1909;
				Match(Default);
				State = 1910;
				Match(Semi);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1911;
				Match(Assign);
				State = 1912;
				Match(Delete);
				State = 1913;
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

	public partial class InitializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BraceorequalinitializerContext braceorequalinitializer() {
			return GetRuleContext<BraceorequalinitializerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionlistContext expressionlist() {
			return GetRuleContext<ExpressionlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		public InitializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_initializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterInitializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitInitializer(this);
		}
	}

	[RuleVersion(0)]
	public InitializerContext initializer() {
		InitializerContext _localctx = new InitializerContext(Context, State);
		EnterRule(_localctx, 280, RULE_initializer);
		try {
			State = 1921;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case LeftBrace:
			case Assign:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1916;
				braceorequalinitializer();
				}
				break;
			case LeftParen:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1917;
				Match(LeftParen);
				State = 1918;
				expressionlist();
				State = 1919;
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

	public partial class BraceorequalinitializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Assign() { return GetToken(CPP14Parser.Assign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InitializerclauseContext initializerclause() {
			return GetRuleContext<InitializerclauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BracedinitlistContext bracedinitlist() {
			return GetRuleContext<BracedinitlistContext>(0);
		}
		public BraceorequalinitializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_braceorequalinitializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterBraceorequalinitializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitBraceorequalinitializer(this);
		}
	}

	[RuleVersion(0)]
	public BraceorequalinitializerContext braceorequalinitializer() {
		BraceorequalinitializerContext _localctx = new BraceorequalinitializerContext(Context, State);
		EnterRule(_localctx, 282, RULE_braceorequalinitializer);
		try {
			State = 1926;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Assign:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1923;
				Match(Assign);
				State = 1924;
				initializerclause();
				}
				break;
			case LeftBrace:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1925;
				bracedinitlist();
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

	public partial class InitializerclauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentexpressionContext assignmentexpression() {
			return GetRuleContext<AssignmentexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BracedinitlistContext bracedinitlist() {
			return GetRuleContext<BracedinitlistContext>(0);
		}
		public InitializerclauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_initializerclause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterInitializerclause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitInitializerclause(this);
		}
	}

	[RuleVersion(0)]
	public InitializerclauseContext initializerclause() {
		InitializerclauseContext _localctx = new InitializerclauseContext(Context, State);
		EnterRule(_localctx, 284, RULE_initializerclause);
		try {
			State = 1930;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__0:
			case T__1:
			case Alignof:
			case Auto:
			case Bool:
			case Char:
			case Char16:
			case Char32:
			case Const_cast:
			case Decltype:
			case Delete:
			case Double:
			case Dynamic_cast:
			case False:
			case Float:
			case Int:
			case Long:
			case New:
			case Noexcept:
			case Nullptr:
			case Operator:
			case Reinterpret_cast:
			case Short:
			case Signed:
			case Sizeof:
			case Static_cast:
			case This:
			case Throw:
			case True:
			case Typeid_:
			case Typename_:
			case Unsigned:
			case Void:
			case Wchar:
			case LeftParen:
			case LeftBracket:
			case Plus:
			case Minus:
			case Star:
			case And:
			case Or:
			case Tilde:
			case PlusPlus:
			case MinusMinus:
			case Doublecolon:
			case Identifier:
			case Integerliteral:
			case Characterliteral:
			case Floatingliteral:
			case Stringliteral:
			case Userdefinedintegerliteral:
			case Userdefinedfloatingliteral:
			case Userdefinedstringliteral:
			case Userdefinedcharacterliteral:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1928;
				assignmentexpression();
				}
				break;
			case LeftBrace:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1929;
				bracedinitlist();
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

	public partial class InitializerlistContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public InitializerclauseContext initializerclause() {
			return GetRuleContext<InitializerclauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ellipsis() { return GetToken(CPP14Parser.Ellipsis, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InitializerlistContext initializerlist() {
			return GetRuleContext<InitializerlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		public InitializerlistContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_initializerlist; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterInitializerlist(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitInitializerlist(this);
		}
	}

	[RuleVersion(0)]
	public InitializerlistContext initializerlist() {
		return initializerlist(0);
	}

	private InitializerlistContext initializerlist(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		InitializerlistContext _localctx = new InitializerlistContext(Context, _parentState);
		InitializerlistContext _prevctx = _localctx;
		int _startState = 286;
		EnterRecursionRule(_localctx, 286, RULE_initializerlist, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 1933;
			initializerclause();
			State = 1935;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,229,Context) ) {
			case 1:
				{
				State = 1934;
				Match(Ellipsis);
				}
				break;
			}
			}
			Context.Stop = TokenStream.LT(-1);
			State = 1945;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,231,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new InitializerlistContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_initializerlist);
					State = 1937;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 1938;
					Match(Comma);
					State = 1939;
					initializerclause();
					State = 1941;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,230,Context) ) {
					case 1:
						{
						State = 1940;
						Match(Ellipsis);
						}
						break;
					}
					}
					} 
				}
				State = 1947;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,231,Context);
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

	public partial class BracedinitlistContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBrace() { return GetToken(CPP14Parser.LeftBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InitializerlistContext initializerlist() {
			return GetRuleContext<InitializerlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBrace() { return GetToken(CPP14Parser.RightBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		public BracedinitlistContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_bracedinitlist; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterBracedinitlist(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitBracedinitlist(this);
		}
	}

	[RuleVersion(0)]
	public BracedinitlistContext bracedinitlist() {
		BracedinitlistContext _localctx = new BracedinitlistContext(Context, State);
		EnterRule(_localctx, 288, RULE_bracedinitlist);
		int _la;
		try {
			State = 1957;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,233,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1948;
				Match(LeftBrace);
				State = 1949;
				initializerlist(0);
				State = 1951;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Comma) {
					{
					State = 1950;
					Match(Comma);
					}
				}

				State = 1953;
				Match(RightBrace);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1955;
				Match(LeftBrace);
				State = 1956;
				Match(RightBrace);
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

	public partial class ClassnameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public SimpletemplateidContext simpletemplateid() {
			return GetRuleContext<SimpletemplateidContext>(0);
		}
		public ClassnameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classname; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterClassname(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitClassname(this);
		}
	}

	[RuleVersion(0)]
	public ClassnameContext classname() {
		ClassnameContext _localctx = new ClassnameContext(Context, State);
		EnterRule(_localctx, 290, RULE_classname);
		try {
			State = 1961;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,234,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1959;
				Match(Identifier);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1960;
				simpletemplateid();
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

	public partial class ClassspecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ClassheadContext classhead() {
			return GetRuleContext<ClassheadContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBrace() { return GetToken(CPP14Parser.LeftBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBrace() { return GetToken(CPP14Parser.RightBrace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public MemberspecificationContext memberspecification() {
			return GetRuleContext<MemberspecificationContext>(0);
		}
		public ClassspecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classspecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterClassspecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitClassspecifier(this);
		}
	}

	[RuleVersion(0)]
	public ClassspecifierContext classspecifier() {
		ClassspecifierContext _localctx = new ClassspecifierContext(Context, State);
		EnterRule(_localctx, 292, RULE_classspecifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1963;
			classhead();
			State = 1964;
			Match(LeftBrace);
			State = 1966;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << Alignas) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Class) | (1L << Const) | (1L << Constexpr) | (1L << Decltype) | (1L << Double) | (1L << Enum) | (1L << Explicit) | (1L << Extern) | (1L << Float) | (1L << Friend) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Mutable) | (1L << Operator) | (1L << Private) | (1L << Protected) | (1L << Public) | (1L << Register) | (1L << Short) | (1L << Signed) | (1L << Static) | (1L << Static_assert))) != 0) || ((((_la - 65)) & ~0x3f) == 0 && ((1L << (_la - 65)) & ((1L << (Struct - 65)) | (1L << (Template - 65)) | (1L << (Thread_local - 65)) | (1L << (Typedef - 65)) | (1L << (Typename_ - 65)) | (1L << (Union - 65)) | (1L << (Unsigned - 65)) | (1L << (Using - 65)) | (1L << (Virtual - 65)) | (1L << (Void - 65)) | (1L << (Volatile - 65)) | (1L << (Wchar - 65)) | (1L << (LeftParen - 65)) | (1L << (LeftBracket - 65)) | (1L << (Star - 65)) | (1L << (And - 65)) | (1L << (Tilde - 65)) | (1L << (Colon - 65)) | (1L << (Doublecolon - 65)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (Semi - 129)) | (1L << (Ellipsis - 129)) | (1L << (Identifier - 129)))) != 0)) {
				{
				State = 1965;
				memberspecification();
				}
			}

			State = 1968;
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

	public partial class ClassheadContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ClasskeyContext classkey() {
			return GetRuleContext<ClasskeyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassheadnameContext classheadname() {
			return GetRuleContext<ClassheadnameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassvirtspecifierContext classvirtspecifier() {
			return GetRuleContext<ClassvirtspecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BaseclauseContext baseclause() {
			return GetRuleContext<BaseclauseContext>(0);
		}
		public ClassheadContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classhead; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterClasshead(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitClasshead(this);
		}
	}

	[RuleVersion(0)]
	public ClassheadContext classhead() {
		ClassheadContext _localctx = new ClassheadContext(Context, State);
		EnterRule(_localctx, 294, RULE_classhead);
		int _la;
		try {
			State = 1988;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,241,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1970;
				classkey();
				State = 1972;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 1971;
					attributespecifierseq(0);
					}
				}

				State = 1974;
				classheadname();
				State = 1976;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Final) {
					{
					State = 1975;
					classvirtspecifier();
					}
				}

				State = 1979;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Colon) {
					{
					State = 1978;
					baseclause();
					}
				}

				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1981;
				classkey();
				State = 1983;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 1982;
					attributespecifierseq(0);
					}
				}

				State = 1986;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Colon) {
					{
					State = 1985;
					baseclause();
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

	public partial class ClassheadnameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ClassnameContext classname() {
			return GetRuleContext<ClassnameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NestednamespecifierContext nestednamespecifier() {
			return GetRuleContext<NestednamespecifierContext>(0);
		}
		public ClassheadnameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classheadname; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterClassheadname(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitClassheadname(this);
		}
	}

	[RuleVersion(0)]
	public ClassheadnameContext classheadname() {
		ClassheadnameContext _localctx = new ClassheadnameContext(Context, State);
		EnterRule(_localctx, 296, RULE_classheadname);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1991;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,242,Context) ) {
			case 1:
				{
				State = 1990;
				nestednamespecifier(0);
				}
				break;
			}
			State = 1993;
			classname();
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

	public partial class ClassvirtspecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Final() { return GetToken(CPP14Parser.Final, 0); }
		public ClassvirtspecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classvirtspecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterClassvirtspecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitClassvirtspecifier(this);
		}
	}

	[RuleVersion(0)]
	public ClassvirtspecifierContext classvirtspecifier() {
		ClassvirtspecifierContext _localctx = new ClassvirtspecifierContext(Context, State);
		EnterRule(_localctx, 298, RULE_classvirtspecifier);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1995;
			Match(Final);
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

	public partial class ClasskeyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Class() { return GetToken(CPP14Parser.Class, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Struct() { return GetToken(CPP14Parser.Struct, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Union() { return GetToken(CPP14Parser.Union, 0); }
		public ClasskeyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classkey; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterClasskey(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitClasskey(this);
		}
	}

	[RuleVersion(0)]
	public ClasskeyContext classkey() {
		ClasskeyContext _localctx = new ClasskeyContext(Context, State);
		EnterRule(_localctx, 300, RULE_classkey);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1997;
			_la = TokenStream.LA(1);
			if ( !(((((_la - 20)) & ~0x3f) == 0 && ((1L << (_la - 20)) & ((1L << (Class - 20)) | (1L << (Struct - 20)) | (1L << (Union - 20)))) != 0)) ) {
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

	public partial class MemberspecificationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public MemberdeclarationContext memberdeclaration() {
			return GetRuleContext<MemberdeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MemberspecificationContext memberspecification() {
			return GetRuleContext<MemberspecificationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AccessspecifierContext accessspecifier() {
			return GetRuleContext<AccessspecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(CPP14Parser.Colon, 0); }
		public MemberspecificationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_memberspecification; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterMemberspecification(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitMemberspecification(this);
		}
	}

	[RuleVersion(0)]
	public MemberspecificationContext memberspecification() {
		MemberspecificationContext _localctx = new MemberspecificationContext(Context, State);
		EnterRule(_localctx, 302, RULE_memberspecification);
		int _la;
		try {
			State = 2008;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__2:
			case Alignas:
			case Auto:
			case Bool:
			case Char:
			case Char16:
			case Char32:
			case Class:
			case Const:
			case Constexpr:
			case Decltype:
			case Double:
			case Enum:
			case Explicit:
			case Extern:
			case Float:
			case Friend:
			case Inline:
			case Int:
			case Long:
			case Mutable:
			case Operator:
			case Register:
			case Short:
			case Signed:
			case Static:
			case Static_assert:
			case Struct:
			case Template:
			case Thread_local:
			case Typedef:
			case Typename_:
			case Union:
			case Unsigned:
			case Using:
			case Virtual:
			case Void:
			case Volatile:
			case Wchar:
			case LeftParen:
			case LeftBracket:
			case Star:
			case And:
			case Tilde:
			case Colon:
			case Doublecolon:
			case Semi:
			case Ellipsis:
			case Identifier:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1999;
				memberdeclaration();
				State = 2001;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << Alignas) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Class) | (1L << Const) | (1L << Constexpr) | (1L << Decltype) | (1L << Double) | (1L << Enum) | (1L << Explicit) | (1L << Extern) | (1L << Float) | (1L << Friend) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Mutable) | (1L << Operator) | (1L << Private) | (1L << Protected) | (1L << Public) | (1L << Register) | (1L << Short) | (1L << Signed) | (1L << Static) | (1L << Static_assert))) != 0) || ((((_la - 65)) & ~0x3f) == 0 && ((1L << (_la - 65)) & ((1L << (Struct - 65)) | (1L << (Template - 65)) | (1L << (Thread_local - 65)) | (1L << (Typedef - 65)) | (1L << (Typename_ - 65)) | (1L << (Union - 65)) | (1L << (Unsigned - 65)) | (1L << (Using - 65)) | (1L << (Virtual - 65)) | (1L << (Void - 65)) | (1L << (Volatile - 65)) | (1L << (Wchar - 65)) | (1L << (LeftParen - 65)) | (1L << (LeftBracket - 65)) | (1L << (Star - 65)) | (1L << (And - 65)) | (1L << (Tilde - 65)) | (1L << (Colon - 65)) | (1L << (Doublecolon - 65)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (Semi - 129)) | (1L << (Ellipsis - 129)) | (1L << (Identifier - 129)))) != 0)) {
					{
					State = 2000;
					memberspecification();
					}
				}

				}
				break;
			case Private:
			case Protected:
			case Public:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2003;
				accessspecifier();
				State = 2004;
				Match(Colon);
				State = 2006;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << Alignas) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Class) | (1L << Const) | (1L << Constexpr) | (1L << Decltype) | (1L << Double) | (1L << Enum) | (1L << Explicit) | (1L << Extern) | (1L << Float) | (1L << Friend) | (1L << Inline) | (1L << Int) | (1L << Long) | (1L << Mutable) | (1L << Operator) | (1L << Private) | (1L << Protected) | (1L << Public) | (1L << Register) | (1L << Short) | (1L << Signed) | (1L << Static) | (1L << Static_assert))) != 0) || ((((_la - 65)) & ~0x3f) == 0 && ((1L << (_la - 65)) & ((1L << (Struct - 65)) | (1L << (Template - 65)) | (1L << (Thread_local - 65)) | (1L << (Typedef - 65)) | (1L << (Typename_ - 65)) | (1L << (Union - 65)) | (1L << (Unsigned - 65)) | (1L << (Using - 65)) | (1L << (Virtual - 65)) | (1L << (Void - 65)) | (1L << (Volatile - 65)) | (1L << (Wchar - 65)) | (1L << (LeftParen - 65)) | (1L << (LeftBracket - 65)) | (1L << (Star - 65)) | (1L << (And - 65)) | (1L << (Tilde - 65)) | (1L << (Colon - 65)) | (1L << (Doublecolon - 65)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (Semi - 129)) | (1L << (Ellipsis - 129)) | (1L << (Identifier - 129)))) != 0)) {
					{
					State = 2005;
					memberspecification();
					}
				}

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

	public partial class MemberdeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Semi() { return GetToken(CPP14Parser.Semi, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclspecifierseqContext declspecifierseq() {
			return GetRuleContext<DeclspecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MemberdeclaratorlistContext memberdeclaratorlist() {
			return GetRuleContext<MemberdeclaratorlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FunctiondefinitionContext functiondefinition() {
			return GetRuleContext<FunctiondefinitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UsingdeclarationContext usingdeclaration() {
			return GetRuleContext<UsingdeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Static_assertdeclarationContext static_assertdeclaration() {
			return GetRuleContext<Static_assertdeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TemplatedeclarationContext templatedeclaration() {
			return GetRuleContext<TemplatedeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AliasdeclarationContext aliasdeclaration() {
			return GetRuleContext<AliasdeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EmptydeclarationContext emptydeclaration() {
			return GetRuleContext<EmptydeclarationContext>(0);
		}
		public MemberdeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_memberdeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterMemberdeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitMemberdeclaration(this);
		}
	}

	[RuleVersion(0)]
	public MemberdeclarationContext memberdeclaration() {
		MemberdeclarationContext _localctx = new MemberdeclarationContext(Context, State);
		EnterRule(_localctx, 304, RULE_memberdeclaration);
		int _la;
		try {
			State = 2026;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,249,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2011;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,246,Context) ) {
				case 1:
					{
					State = 2010;
					attributespecifierseq(0);
					}
					break;
				}
				State = 2014;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,247,Context) ) {
				case 1:
					{
					State = 2013;
					declspecifierseq();
					}
					break;
				}
				State = 2017;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << Alignas) | (1L << Decltype) | (1L << Operator))) != 0) || ((((_la - 84)) & ~0x3f) == 0 && ((1L << (_la - 84)) & ((1L << (LeftParen - 84)) | (1L << (LeftBracket - 84)) | (1L << (Star - 84)) | (1L << (And - 84)) | (1L << (Tilde - 84)) | (1L << (Colon - 84)) | (1L << (Doublecolon - 84)) | (1L << (Ellipsis - 84)) | (1L << (Identifier - 84)))) != 0)) {
					{
					State = 2016;
					memberdeclaratorlist(0);
					}
				}

				State = 2019;
				Match(Semi);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2020;
				functiondefinition();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2021;
				usingdeclaration();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 2022;
				static_assertdeclaration();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 2023;
				templatedeclaration();
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 2024;
				aliasdeclaration();
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 2025;
				emptydeclaration();
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

	public partial class MemberdeclaratorlistContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public MemberdeclaratorContext memberdeclarator() {
			return GetRuleContext<MemberdeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MemberdeclaratorlistContext memberdeclaratorlist() {
			return GetRuleContext<MemberdeclaratorlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		public MemberdeclaratorlistContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_memberdeclaratorlist; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterMemberdeclaratorlist(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitMemberdeclaratorlist(this);
		}
	}

	[RuleVersion(0)]
	public MemberdeclaratorlistContext memberdeclaratorlist() {
		return memberdeclaratorlist(0);
	}

	private MemberdeclaratorlistContext memberdeclaratorlist(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		MemberdeclaratorlistContext _localctx = new MemberdeclaratorlistContext(Context, _parentState);
		MemberdeclaratorlistContext _prevctx = _localctx;
		int _startState = 306;
		EnterRecursionRule(_localctx, 306, RULE_memberdeclaratorlist, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 2029;
			memberdeclarator();
			}
			Context.Stop = TokenStream.LT(-1);
			State = 2036;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,250,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new MemberdeclaratorlistContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_memberdeclaratorlist);
					State = 2031;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 2032;
					Match(Comma);
					State = 2033;
					memberdeclarator();
					}
					} 
				}
				State = 2038;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,250,Context);
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

	public partial class MemberdeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DeclaratorContext declarator() {
			return GetRuleContext<DeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VirtspecifierseqContext virtspecifierseq() {
			return GetRuleContext<VirtspecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PurespecifierContext purespecifier() {
			return GetRuleContext<PurespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BraceorequalinitializerContext braceorequalinitializer() {
			return GetRuleContext<BraceorequalinitializerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(CPP14Parser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantexpressionContext constantexpression() {
			return GetRuleContext<ConstantexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		public MemberdeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_memberdeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterMemberdeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitMemberdeclarator(this);
		}
	}

	[RuleVersion(0)]
	public MemberdeclaratorContext memberdeclarator() {
		MemberdeclaratorContext _localctx = new MemberdeclaratorContext(Context, State);
		EnterRule(_localctx, 308, RULE_memberdeclarator);
		int _la;
		try {
			State = 2058;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,256,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2039;
				declarator();
				State = 2041;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,251,Context) ) {
				case 1:
					{
					State = 2040;
					virtspecifierseq(0);
					}
					break;
				}
				State = 2044;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,252,Context) ) {
				case 1:
					{
					State = 2043;
					purespecifier();
					}
					break;
				}
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2046;
				declarator();
				State = 2048;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,253,Context) ) {
				case 1:
					{
					State = 2047;
					braceorequalinitializer();
					}
					break;
				}
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2051;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Identifier) {
					{
					State = 2050;
					Match(Identifier);
					}
				}

				State = 2054;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 2053;
					attributespecifierseq(0);
					}
				}

				State = 2056;
				Match(Colon);
				State = 2057;
				constantexpression();
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

	public partial class VirtspecifierseqContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public VirtspecifierContext virtspecifier() {
			return GetRuleContext<VirtspecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VirtspecifierseqContext virtspecifierseq() {
			return GetRuleContext<VirtspecifierseqContext>(0);
		}
		public VirtspecifierseqContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_virtspecifierseq; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterVirtspecifierseq(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitVirtspecifierseq(this);
		}
	}

	[RuleVersion(0)]
	public VirtspecifierseqContext virtspecifierseq() {
		return virtspecifierseq(0);
	}

	private VirtspecifierseqContext virtspecifierseq(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		VirtspecifierseqContext _localctx = new VirtspecifierseqContext(Context, _parentState);
		VirtspecifierseqContext _prevctx = _localctx;
		int _startState = 310;
		EnterRecursionRule(_localctx, 310, RULE_virtspecifierseq, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 2061;
			virtspecifier();
			}
			Context.Stop = TokenStream.LT(-1);
			State = 2067;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,257,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new VirtspecifierseqContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_virtspecifierseq);
					State = 2063;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 2064;
					virtspecifier();
					}
					} 
				}
				State = 2069;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,257,Context);
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

	public partial class VirtspecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Override() { return GetToken(CPP14Parser.Override, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Final() { return GetToken(CPP14Parser.Final, 0); }
		public VirtspecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_virtspecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterVirtspecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitVirtspecifier(this);
		}
	}

	[RuleVersion(0)]
	public VirtspecifierContext virtspecifier() {
		VirtspecifierContext _localctx = new VirtspecifierContext(Context, State);
		EnterRule(_localctx, 312, RULE_virtspecifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2070;
			_la = TokenStream.LA(1);
			if ( !(_la==Final || _la==Override) ) {
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

	public partial class PurespecifierContext : ParserRuleContext {
		public IToken val;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Assign() { return GetToken(CPP14Parser.Assign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Octalliteral() { return GetToken(CPP14Parser.Octalliteral, 0); }
		public PurespecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_purespecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterPurespecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitPurespecifier(this);
		}
	}

	[RuleVersion(0)]
	public PurespecifierContext purespecifier() {
		PurespecifierContext _localctx = new PurespecifierContext(Context, State);
		EnterRule(_localctx, 314, RULE_purespecifier);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2072;
			Match(Assign);
			State = 2073;
			_localctx.val = Match(Octalliteral);
			if((_localctx.val!=null?_localctx.val.Text:null).CompareTo("0")!=0) throw new InputMismatchException(this);
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

	public partial class BaseclauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(CPP14Parser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BasespecifierlistContext basespecifierlist() {
			return GetRuleContext<BasespecifierlistContext>(0);
		}
		public BaseclauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_baseclause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterBaseclause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitBaseclause(this);
		}
	}

	[RuleVersion(0)]
	public BaseclauseContext baseclause() {
		BaseclauseContext _localctx = new BaseclauseContext(Context, State);
		EnterRule(_localctx, 316, RULE_baseclause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2076;
			Match(Colon);
			State = 2077;
			basespecifierlist(0);
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

	public partial class BasespecifierlistContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BasespecifierContext basespecifier() {
			return GetRuleContext<BasespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ellipsis() { return GetToken(CPP14Parser.Ellipsis, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BasespecifierlistContext basespecifierlist() {
			return GetRuleContext<BasespecifierlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		public BasespecifierlistContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_basespecifierlist; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterBasespecifierlist(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitBasespecifierlist(this);
		}
	}

	[RuleVersion(0)]
	public BasespecifierlistContext basespecifierlist() {
		return basespecifierlist(0);
	}

	private BasespecifierlistContext basespecifierlist(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		BasespecifierlistContext _localctx = new BasespecifierlistContext(Context, _parentState);
		BasespecifierlistContext _prevctx = _localctx;
		int _startState = 318;
		EnterRecursionRule(_localctx, 318, RULE_basespecifierlist, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 2080;
			basespecifier();
			State = 2082;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,258,Context) ) {
			case 1:
				{
				State = 2081;
				Match(Ellipsis);
				}
				break;
			}
			}
			Context.Stop = TokenStream.LT(-1);
			State = 2092;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,260,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new BasespecifierlistContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_basespecifierlist);
					State = 2084;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 2085;
					Match(Comma);
					State = 2086;
					basespecifier();
					State = 2088;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,259,Context) ) {
					case 1:
						{
						State = 2087;
						Match(Ellipsis);
						}
						break;
					}
					}
					} 
				}
				State = 2094;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,260,Context);
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

	public partial class BasespecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BasetypespecifierContext basetypespecifier() {
			return GetRuleContext<BasetypespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Virtual() { return GetToken(CPP14Parser.Virtual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AccessspecifierContext accessspecifier() {
			return GetRuleContext<AccessspecifierContext>(0);
		}
		public BasespecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_basespecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterBasespecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitBasespecifier(this);
		}
	}

	[RuleVersion(0)]
	public BasespecifierContext basespecifier() {
		BasespecifierContext _localctx = new BasespecifierContext(Context, State);
		EnterRule(_localctx, 320, RULE_basespecifier);
		int _la;
		try {
			State = 2116;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,266,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2096;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 2095;
					attributespecifierseq(0);
					}
				}

				State = 2098;
				basetypespecifier();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2100;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 2099;
					attributespecifierseq(0);
					}
				}

				State = 2102;
				Match(Virtual);
				State = 2104;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Private) | (1L << Protected) | (1L << Public))) != 0)) {
					{
					State = 2103;
					accessspecifier();
					}
				}

				State = 2106;
				basetypespecifier();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2108;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 2107;
					attributespecifierseq(0);
					}
				}

				State = 2110;
				accessspecifier();
				State = 2112;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Virtual) {
					{
					State = 2111;
					Match(Virtual);
					}
				}

				State = 2114;
				basetypespecifier();
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

	public partial class ClassordecltypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ClassnameContext classname() {
			return GetRuleContext<ClassnameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NestednamespecifierContext nestednamespecifier() {
			return GetRuleContext<NestednamespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DecltypespecifierContext decltypespecifier() {
			return GetRuleContext<DecltypespecifierContext>(0);
		}
		public ClassordecltypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classordecltype; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterClassordecltype(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitClassordecltype(this);
		}
	}

	[RuleVersion(0)]
	public ClassordecltypeContext classordecltype() {
		ClassordecltypeContext _localctx = new ClassordecltypeContext(Context, State);
		EnterRule(_localctx, 322, RULE_classordecltype);
		try {
			State = 2123;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,268,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2119;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,267,Context) ) {
				case 1:
					{
					State = 2118;
					nestednamespecifier(0);
					}
					break;
				}
				State = 2121;
				classname();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2122;
				decltypespecifier();
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

	public partial class BasetypespecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ClassordecltypeContext classordecltype() {
			return GetRuleContext<ClassordecltypeContext>(0);
		}
		public BasetypespecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_basetypespecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterBasetypespecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitBasetypespecifier(this);
		}
	}

	[RuleVersion(0)]
	public BasetypespecifierContext basetypespecifier() {
		BasetypespecifierContext _localctx = new BasetypespecifierContext(Context, State);
		EnterRule(_localctx, 324, RULE_basetypespecifier);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2125;
			classordecltype();
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

	public partial class AccessspecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Private() { return GetToken(CPP14Parser.Private, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Protected() { return GetToken(CPP14Parser.Protected, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Public() { return GetToken(CPP14Parser.Public, 0); }
		public AccessspecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_accessspecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterAccessspecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitAccessspecifier(this);
		}
	}

	[RuleVersion(0)]
	public AccessspecifierContext accessspecifier() {
		AccessspecifierContext _localctx = new AccessspecifierContext(Context, State);
		EnterRule(_localctx, 326, RULE_accessspecifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2127;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Private) | (1L << Protected) | (1L << Public))) != 0)) ) {
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

	public partial class ConversionfunctionidContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Operator() { return GetToken(CPP14Parser.Operator, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConversiontypeidContext conversiontypeid() {
			return GetRuleContext<ConversiontypeidContext>(0);
		}
		public ConversionfunctionidContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_conversionfunctionid; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterConversionfunctionid(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitConversionfunctionid(this);
		}
	}

	[RuleVersion(0)]
	public ConversionfunctionidContext conversionfunctionid() {
		ConversionfunctionidContext _localctx = new ConversionfunctionidContext(Context, State);
		EnterRule(_localctx, 328, RULE_conversionfunctionid);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2129;
			Match(Operator);
			State = 2130;
			conversiontypeid();
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

	public partial class ConversiontypeidContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TypespecifierseqContext typespecifierseq() {
			return GetRuleContext<TypespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConversiondeclaratorContext conversiondeclarator() {
			return GetRuleContext<ConversiondeclaratorContext>(0);
		}
		public ConversiontypeidContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_conversiontypeid; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterConversiontypeid(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitConversiontypeid(this);
		}
	}

	[RuleVersion(0)]
	public ConversiontypeidContext conversiontypeid() {
		ConversiontypeidContext _localctx = new ConversiontypeidContext(Context, State);
		EnterRule(_localctx, 330, RULE_conversiontypeid);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2132;
			typespecifierseq();
			State = 2134;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,269,Context) ) {
			case 1:
				{
				State = 2133;
				conversiondeclarator();
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

	public partial class ConversiondeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PtroperatorContext ptroperator() {
			return GetRuleContext<PtroperatorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConversiondeclaratorContext conversiondeclarator() {
			return GetRuleContext<ConversiondeclaratorContext>(0);
		}
		public ConversiondeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_conversiondeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterConversiondeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitConversiondeclarator(this);
		}
	}

	[RuleVersion(0)]
	public ConversiondeclaratorContext conversiondeclarator() {
		ConversiondeclaratorContext _localctx = new ConversiondeclaratorContext(Context, State);
		EnterRule(_localctx, 332, RULE_conversiondeclarator);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2136;
			ptroperator();
			State = 2138;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,270,Context) ) {
			case 1:
				{
				State = 2137;
				conversiondeclarator();
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

	public partial class CtorinitializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(CPP14Parser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public MeminitializerlistContext meminitializerlist() {
			return GetRuleContext<MeminitializerlistContext>(0);
		}
		public CtorinitializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ctorinitializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterCtorinitializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitCtorinitializer(this);
		}
	}

	[RuleVersion(0)]
	public CtorinitializerContext ctorinitializer() {
		CtorinitializerContext _localctx = new CtorinitializerContext(Context, State);
		EnterRule(_localctx, 334, RULE_ctorinitializer);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2140;
			Match(Colon);
			State = 2141;
			meminitializerlist();
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

	public partial class MeminitializerlistContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public MeminitializerContext meminitializer() {
			return GetRuleContext<MeminitializerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ellipsis() { return GetToken(CPP14Parser.Ellipsis, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public MeminitializerlistContext meminitializerlist() {
			return GetRuleContext<MeminitializerlistContext>(0);
		}
		public MeminitializerlistContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_meminitializerlist; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterMeminitializerlist(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitMeminitializerlist(this);
		}
	}

	[RuleVersion(0)]
	public MeminitializerlistContext meminitializerlist() {
		MeminitializerlistContext _localctx = new MeminitializerlistContext(Context, State);
		EnterRule(_localctx, 336, RULE_meminitializerlist);
		int _la;
		try {
			State = 2154;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,273,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2143;
				meminitializer();
				State = 2145;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Ellipsis) {
					{
					State = 2144;
					Match(Ellipsis);
					}
				}

				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2147;
				meminitializer();
				State = 2149;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Ellipsis) {
					{
					State = 2148;
					Match(Ellipsis);
					}
				}

				State = 2151;
				Match(Comma);
				State = 2152;
				meminitializerlist();
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

	public partial class MeminitializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public MeminitializeridContext meminitializerid() {
			return GetRuleContext<MeminitializeridContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionlistContext expressionlist() {
			return GetRuleContext<ExpressionlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BracedinitlistContext bracedinitlist() {
			return GetRuleContext<BracedinitlistContext>(0);
		}
		public MeminitializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_meminitializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterMeminitializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitMeminitializer(this);
		}
	}

	[RuleVersion(0)]
	public MeminitializerContext meminitializer() {
		MeminitializerContext _localctx = new MeminitializerContext(Context, State);
		EnterRule(_localctx, 338, RULE_meminitializer);
		int _la;
		try {
			State = 2166;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,275,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2156;
				meminitializerid();
				State = 2157;
				Match(LeftParen);
				State = 2159;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << Alignof) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Const_cast) | (1L << Decltype) | (1L << Delete) | (1L << Double) | (1L << Dynamic_cast) | (1L << False) | (1L << Float) | (1L << Int) | (1L << Long) | (1L << New) | (1L << Noexcept) | (1L << Nullptr) | (1L << Operator) | (1L << Reinterpret_cast) | (1L << Short) | (1L << Signed) | (1L << Sizeof))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Static_cast - 64)) | (1L << (This - 64)) | (1L << (Throw - 64)) | (1L << (True - 64)) | (1L << (Typeid_ - 64)) | (1L << (Typename_ - 64)) | (1L << (Unsigned - 64)) | (1L << (Void - 64)) | (1L << (Wchar - 64)) | (1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (LeftBrace - 64)) | (1L << (Plus - 64)) | (1L << (Minus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (Or - 64)) | (1L << (Tilde - 64)) | (1L << (PlusPlus - 64)) | (1L << (MinusMinus - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (Doublecolon - 128)) | (1L << (Identifier - 128)) | (1L << (Integerliteral - 128)) | (1L << (Characterliteral - 128)) | (1L << (Floatingliteral - 128)) | (1L << (Stringliteral - 128)) | (1L << (Userdefinedintegerliteral - 128)) | (1L << (Userdefinedfloatingliteral - 128)) | (1L << (Userdefinedstringliteral - 128)) | (1L << (Userdefinedcharacterliteral - 128)))) != 0)) {
					{
					State = 2158;
					expressionlist();
					}
				}

				State = 2161;
				Match(RightParen);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2163;
				meminitializerid();
				State = 2164;
				bracedinitlist();
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

	public partial class MeminitializeridContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ClassordecltypeContext classordecltype() {
			return GetRuleContext<ClassordecltypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		public MeminitializeridContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_meminitializerid; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterMeminitializerid(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitMeminitializerid(this);
		}
	}

	[RuleVersion(0)]
	public MeminitializeridContext meminitializerid() {
		MeminitializeridContext _localctx = new MeminitializeridContext(Context, State);
		EnterRule(_localctx, 340, RULE_meminitializerid);
		try {
			State = 2170;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,276,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2168;
				classordecltype();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2169;
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

	public partial class OperatorfunctionidContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Operator() { return GetToken(CPP14Parser.Operator, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TheoperatorContext theoperator() {
			return GetRuleContext<TheoperatorContext>(0);
		}
		public OperatorfunctionidContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_operatorfunctionid; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterOperatorfunctionid(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitOperatorfunctionid(this);
		}
	}

	[RuleVersion(0)]
	public OperatorfunctionidContext operatorfunctionid() {
		OperatorfunctionidContext _localctx = new OperatorfunctionidContext(Context, State);
		EnterRule(_localctx, 342, RULE_operatorfunctionid);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2172;
			Match(Operator);
			State = 2173;
			theoperator();
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

	public partial class LiteraloperatoridContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Operator() { return GetToken(CPP14Parser.Operator, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Stringliteral() { return GetToken(CPP14Parser.Stringliteral, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Userdefinedstringliteral() { return GetToken(CPP14Parser.Userdefinedstringliteral, 0); }
		public LiteraloperatoridContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_literaloperatorid; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterLiteraloperatorid(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitLiteraloperatorid(this);
		}
	}

	[RuleVersion(0)]
	public LiteraloperatoridContext literaloperatorid() {
		LiteraloperatoridContext _localctx = new LiteraloperatoridContext(Context, State);
		EnterRule(_localctx, 344, RULE_literaloperatorid);
		try {
			State = 2180;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,277,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2175;
				Match(Operator);
				State = 2176;
				Match(Stringliteral);
				State = 2177;
				Match(Identifier);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2178;
				Match(Operator);
				State = 2179;
				Match(Userdefinedstringliteral);
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

	public partial class TemplatedeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Template() { return GetToken(CPP14Parser.Template, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Less() { return GetToken(CPP14Parser.Less, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TemplateparameterlistContext templateparameterlist() {
			return GetRuleContext<TemplateparameterlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Greater() { return GetToken(CPP14Parser.Greater, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationContext declaration() {
			return GetRuleContext<DeclarationContext>(0);
		}
		public TemplatedeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_templatedeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTemplatedeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTemplatedeclaration(this);
		}
	}

	[RuleVersion(0)]
	public TemplatedeclarationContext templatedeclaration() {
		TemplatedeclarationContext _localctx = new TemplatedeclarationContext(Context, State);
		EnterRule(_localctx, 346, RULE_templatedeclaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2182;
			Match(Template);
			State = 2183;
			Match(Less);
			State = 2184;
			templateparameterlist(0);
			State = 2185;
			Match(Greater);
			State = 2186;
			declaration();
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

	public partial class TemplateparameterlistContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TemplateparameterContext templateparameter() {
			return GetRuleContext<TemplateparameterContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TemplateparameterlistContext templateparameterlist() {
			return GetRuleContext<TemplateparameterlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		public TemplateparameterlistContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_templateparameterlist; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTemplateparameterlist(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTemplateparameterlist(this);
		}
	}

	[RuleVersion(0)]
	public TemplateparameterlistContext templateparameterlist() {
		return templateparameterlist(0);
	}

	private TemplateparameterlistContext templateparameterlist(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		TemplateparameterlistContext _localctx = new TemplateparameterlistContext(Context, _parentState);
		TemplateparameterlistContext _prevctx = _localctx;
		int _startState = 348;
		EnterRecursionRule(_localctx, 348, RULE_templateparameterlist, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 2189;
			templateparameter();
			}
			Context.Stop = TokenStream.LT(-1);
			State = 2196;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,278,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new TemplateparameterlistContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_templateparameterlist);
					State = 2191;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 2192;
					Match(Comma);
					State = 2193;
					templateparameter();
					}
					} 
				}
				State = 2198;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,278,Context);
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

	public partial class TemplateparameterContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TypeparameterContext typeparameter() {
			return GetRuleContext<TypeparameterContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ParameterdeclarationContext parameterdeclaration() {
			return GetRuleContext<ParameterdeclarationContext>(0);
		}
		public TemplateparameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_templateparameter; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTemplateparameter(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTemplateparameter(this);
		}
	}

	[RuleVersion(0)]
	public TemplateparameterContext templateparameter() {
		TemplateparameterContext _localctx = new TemplateparameterContext(Context, State);
		EnterRule(_localctx, 350, RULE_templateparameter);
		try {
			State = 2201;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,279,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2199;
				typeparameter();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2200;
				parameterdeclaration();
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

	public partial class TypeparameterContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Class() { return GetToken(CPP14Parser.Class, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ellipsis() { return GetToken(CPP14Parser.Ellipsis, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Assign() { return GetToken(CPP14Parser.Assign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ThetypeidContext thetypeid() {
			return GetRuleContext<ThetypeidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Typename_() { return GetToken(CPP14Parser.Typename_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Template() { return GetToken(CPP14Parser.Template, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Less() { return GetToken(CPP14Parser.Less, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TemplateparameterlistContext templateparameterlist() {
			return GetRuleContext<TemplateparameterlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Greater() { return GetToken(CPP14Parser.Greater, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdexpressionContext idexpression() {
			return GetRuleContext<IdexpressionContext>(0);
		}
		public TypeparameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeparameter; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTypeparameter(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTypeparameter(this);
		}
	}

	[RuleVersion(0)]
	public TypeparameterContext typeparameter() {
		TypeparameterContext _localctx = new TypeparameterContext(Context, State);
		EnterRule(_localctx, 352, RULE_typeparameter);
		int _la;
		try {
			State = 2251;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,289,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2203;
				Match(Class);
				State = 2205;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,280,Context) ) {
				case 1:
					{
					State = 2204;
					Match(Ellipsis);
					}
					break;
				}
				State = 2208;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,281,Context) ) {
				case 1:
					{
					State = 2207;
					Match(Identifier);
					}
					break;
				}
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2210;
				Match(Class);
				State = 2212;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Identifier) {
					{
					State = 2211;
					Match(Identifier);
					}
				}

				State = 2214;
				Match(Assign);
				State = 2215;
				thetypeid();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2216;
				Match(Typename_);
				State = 2218;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,283,Context) ) {
				case 1:
					{
					State = 2217;
					Match(Ellipsis);
					}
					break;
				}
				State = 2221;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,284,Context) ) {
				case 1:
					{
					State = 2220;
					Match(Identifier);
					}
					break;
				}
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 2223;
				Match(Typename_);
				State = 2225;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Identifier) {
					{
					State = 2224;
					Match(Identifier);
					}
				}

				State = 2227;
				Match(Assign);
				State = 2228;
				thetypeid();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 2229;
				Match(Template);
				State = 2230;
				Match(Less);
				State = 2231;
				templateparameterlist(0);
				State = 2232;
				Match(Greater);
				State = 2233;
				Match(Class);
				State = 2235;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,286,Context) ) {
				case 1:
					{
					State = 2234;
					Match(Ellipsis);
					}
					break;
				}
				State = 2238;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,287,Context) ) {
				case 1:
					{
					State = 2237;
					Match(Identifier);
					}
					break;
				}
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 2240;
				Match(Template);
				State = 2241;
				Match(Less);
				State = 2242;
				templateparameterlist(0);
				State = 2243;
				Match(Greater);
				State = 2244;
				Match(Class);
				State = 2246;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Identifier) {
					{
					State = 2245;
					Match(Identifier);
					}
				}

				State = 2248;
				Match(Assign);
				State = 2249;
				idexpression();
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

	public partial class SimpletemplateidContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TemplatenameContext templatename() {
			return GetRuleContext<TemplatenameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Less() { return GetToken(CPP14Parser.Less, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Greater() { return GetToken(CPP14Parser.Greater, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TemplateargumentlistContext templateargumentlist() {
			return GetRuleContext<TemplateargumentlistContext>(0);
		}
		public SimpletemplateidContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_simpletemplateid; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterSimpletemplateid(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitSimpletemplateid(this);
		}
	}

	[RuleVersion(0)]
	public SimpletemplateidContext simpletemplateid() {
		SimpletemplateidContext _localctx = new SimpletemplateidContext(Context, State);
		EnterRule(_localctx, 354, RULE_simpletemplateid);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2253;
			templatename();
			State = 2254;
			Match(Less);
			State = 2256;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << Alignof) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Class) | (1L << Const) | (1L << Const_cast) | (1L << Decltype) | (1L << Delete) | (1L << Double) | (1L << Dynamic_cast) | (1L << Enum) | (1L << False) | (1L << Float) | (1L << Int) | (1L << Long) | (1L << New) | (1L << Noexcept) | (1L << Nullptr) | (1L << Operator) | (1L << Reinterpret_cast) | (1L << Short) | (1L << Signed) | (1L << Sizeof))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Static_cast - 64)) | (1L << (Struct - 64)) | (1L << (This - 64)) | (1L << (True - 64)) | (1L << (Typeid_ - 64)) | (1L << (Typename_ - 64)) | (1L << (Union - 64)) | (1L << (Unsigned - 64)) | (1L << (Void - 64)) | (1L << (Volatile - 64)) | (1L << (Wchar - 64)) | (1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (Plus - 64)) | (1L << (Minus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (Or - 64)) | (1L << (Tilde - 64)) | (1L << (PlusPlus - 64)) | (1L << (MinusMinus - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (Doublecolon - 128)) | (1L << (Identifier - 128)) | (1L << (Integerliteral - 128)) | (1L << (Characterliteral - 128)) | (1L << (Floatingliteral - 128)) | (1L << (Stringliteral - 128)) | (1L << (Userdefinedintegerliteral - 128)) | (1L << (Userdefinedfloatingliteral - 128)) | (1L << (Userdefinedstringliteral - 128)) | (1L << (Userdefinedcharacterliteral - 128)))) != 0)) {
				{
				State = 2255;
				templateargumentlist(0);
				}
			}

			State = 2258;
			Match(Greater);
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

	public partial class TemplateidContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public SimpletemplateidContext simpletemplateid() {
			return GetRuleContext<SimpletemplateidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public OperatorfunctionidContext operatorfunctionid() {
			return GetRuleContext<OperatorfunctionidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Less() { return GetToken(CPP14Parser.Less, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Greater() { return GetToken(CPP14Parser.Greater, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TemplateargumentlistContext templateargumentlist() {
			return GetRuleContext<TemplateargumentlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public LiteraloperatoridContext literaloperatorid() {
			return GetRuleContext<LiteraloperatoridContext>(0);
		}
		public TemplateidContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_templateid; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTemplateid(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTemplateid(this);
		}
	}

	[RuleVersion(0)]
	public TemplateidContext templateid() {
		TemplateidContext _localctx = new TemplateidContext(Context, State);
		EnterRule(_localctx, 356, RULE_templateid);
		int _la;
		try {
			State = 2275;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,293,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2260;
				simpletemplateid();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2261;
				operatorfunctionid();
				State = 2262;
				Match(Less);
				State = 2264;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << Alignof) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Class) | (1L << Const) | (1L << Const_cast) | (1L << Decltype) | (1L << Delete) | (1L << Double) | (1L << Dynamic_cast) | (1L << Enum) | (1L << False) | (1L << Float) | (1L << Int) | (1L << Long) | (1L << New) | (1L << Noexcept) | (1L << Nullptr) | (1L << Operator) | (1L << Reinterpret_cast) | (1L << Short) | (1L << Signed) | (1L << Sizeof))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Static_cast - 64)) | (1L << (Struct - 64)) | (1L << (This - 64)) | (1L << (True - 64)) | (1L << (Typeid_ - 64)) | (1L << (Typename_ - 64)) | (1L << (Union - 64)) | (1L << (Unsigned - 64)) | (1L << (Void - 64)) | (1L << (Volatile - 64)) | (1L << (Wchar - 64)) | (1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (Plus - 64)) | (1L << (Minus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (Or - 64)) | (1L << (Tilde - 64)) | (1L << (PlusPlus - 64)) | (1L << (MinusMinus - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (Doublecolon - 128)) | (1L << (Identifier - 128)) | (1L << (Integerliteral - 128)) | (1L << (Characterliteral - 128)) | (1L << (Floatingliteral - 128)) | (1L << (Stringliteral - 128)) | (1L << (Userdefinedintegerliteral - 128)) | (1L << (Userdefinedfloatingliteral - 128)) | (1L << (Userdefinedstringliteral - 128)) | (1L << (Userdefinedcharacterliteral - 128)))) != 0)) {
					{
					State = 2263;
					templateargumentlist(0);
					}
				}

				State = 2266;
				Match(Greater);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2268;
				literaloperatorid();
				State = 2269;
				Match(Less);
				State = 2271;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << Alignof) | (1L << Auto) | (1L << Bool) | (1L << Char) | (1L << Char16) | (1L << Char32) | (1L << Class) | (1L << Const) | (1L << Const_cast) | (1L << Decltype) | (1L << Delete) | (1L << Double) | (1L << Dynamic_cast) | (1L << Enum) | (1L << False) | (1L << Float) | (1L << Int) | (1L << Long) | (1L << New) | (1L << Noexcept) | (1L << Nullptr) | (1L << Operator) | (1L << Reinterpret_cast) | (1L << Short) | (1L << Signed) | (1L << Sizeof))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Static_cast - 64)) | (1L << (Struct - 64)) | (1L << (This - 64)) | (1L << (True - 64)) | (1L << (Typeid_ - 64)) | (1L << (Typename_ - 64)) | (1L << (Union - 64)) | (1L << (Unsigned - 64)) | (1L << (Void - 64)) | (1L << (Volatile - 64)) | (1L << (Wchar - 64)) | (1L << (LeftParen - 64)) | (1L << (LeftBracket - 64)) | (1L << (Plus - 64)) | (1L << (Minus - 64)) | (1L << (Star - 64)) | (1L << (And - 64)) | (1L << (Or - 64)) | (1L << (Tilde - 64)) | (1L << (PlusPlus - 64)) | (1L << (MinusMinus - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (Doublecolon - 128)) | (1L << (Identifier - 128)) | (1L << (Integerliteral - 128)) | (1L << (Characterliteral - 128)) | (1L << (Floatingliteral - 128)) | (1L << (Stringliteral - 128)) | (1L << (Userdefinedintegerliteral - 128)) | (1L << (Userdefinedfloatingliteral - 128)) | (1L << (Userdefinedstringliteral - 128)) | (1L << (Userdefinedcharacterliteral - 128)))) != 0)) {
					{
					State = 2270;
					templateargumentlist(0);
					}
				}

				State = 2273;
				Match(Greater);
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

	public partial class TemplatenameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		public TemplatenameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_templatename; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTemplatename(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTemplatename(this);
		}
	}

	[RuleVersion(0)]
	public TemplatenameContext templatename() {
		TemplatenameContext _localctx = new TemplatenameContext(Context, State);
		EnterRule(_localctx, 358, RULE_templatename);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2277;
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

	public partial class TemplateargumentlistContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TemplateargumentContext templateargument() {
			return GetRuleContext<TemplateargumentContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ellipsis() { return GetToken(CPP14Parser.Ellipsis, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TemplateargumentlistContext templateargumentlist() {
			return GetRuleContext<TemplateargumentlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		public TemplateargumentlistContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_templateargumentlist; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTemplateargumentlist(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTemplateargumentlist(this);
		}
	}

	[RuleVersion(0)]
	public TemplateargumentlistContext templateargumentlist() {
		return templateargumentlist(0);
	}

	private TemplateargumentlistContext templateargumentlist(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		TemplateargumentlistContext _localctx = new TemplateargumentlistContext(Context, _parentState);
		TemplateargumentlistContext _prevctx = _localctx;
		int _startState = 360;
		EnterRecursionRule(_localctx, 360, RULE_templateargumentlist, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 2280;
			templateargument();
			State = 2282;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,294,Context) ) {
			case 1:
				{
				State = 2281;
				Match(Ellipsis);
				}
				break;
			}
			}
			Context.Stop = TokenStream.LT(-1);
			State = 2292;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,296,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new TemplateargumentlistContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_templateargumentlist);
					State = 2284;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 2285;
					Match(Comma);
					State = 2286;
					templateargument();
					State = 2288;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,295,Context) ) {
					case 1:
						{
						State = 2287;
						Match(Ellipsis);
						}
						break;
					}
					}
					} 
				}
				State = 2294;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,296,Context);
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

	public partial class TemplateargumentContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ThetypeidContext thetypeid() {
			return GetRuleContext<ThetypeidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConstantexpressionContext constantexpression() {
			return GetRuleContext<ConstantexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdexpressionContext idexpression() {
			return GetRuleContext<IdexpressionContext>(0);
		}
		public TemplateargumentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_templateargument; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTemplateargument(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTemplateargument(this);
		}
	}

	[RuleVersion(0)]
	public TemplateargumentContext templateargument() {
		TemplateargumentContext _localctx = new TemplateargumentContext(Context, State);
		EnterRule(_localctx, 362, RULE_templateargument);
		try {
			State = 2298;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,297,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2295;
				thetypeid();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2296;
				constantexpression();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2297;
				idexpression();
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

	public partial class TypenamespecifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Typename_() { return GetToken(CPP14Parser.Typename_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NestednamespecifierContext nestednamespecifier() {
			return GetRuleContext<NestednamespecifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(CPP14Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public SimpletemplateidContext simpletemplateid() {
			return GetRuleContext<SimpletemplateidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Template() { return GetToken(CPP14Parser.Template, 0); }
		public TypenamespecifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typenamespecifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTypenamespecifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTypenamespecifier(this);
		}
	}

	[RuleVersion(0)]
	public TypenamespecifierContext typenamespecifier() {
		TypenamespecifierContext _localctx = new TypenamespecifierContext(Context, State);
		EnterRule(_localctx, 364, RULE_typenamespecifier);
		int _la;
		try {
			State = 2311;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,299,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2300;
				Match(Typename_);
				State = 2301;
				nestednamespecifier(0);
				State = 2302;
				Match(Identifier);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2304;
				Match(Typename_);
				State = 2305;
				nestednamespecifier(0);
				State = 2307;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Template) {
					{
					State = 2306;
					Match(Template);
					}
				}

				State = 2309;
				simpletemplateid();
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

	public partial class ExplicitinstantiationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Template() { return GetToken(CPP14Parser.Template, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationContext declaration() {
			return GetRuleContext<DeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Extern() { return GetToken(CPP14Parser.Extern, 0); }
		public ExplicitinstantiationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_explicitinstantiation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterExplicitinstantiation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitExplicitinstantiation(this);
		}
	}

	[RuleVersion(0)]
	public ExplicitinstantiationContext explicitinstantiation() {
		ExplicitinstantiationContext _localctx = new ExplicitinstantiationContext(Context, State);
		EnterRule(_localctx, 366, RULE_explicitinstantiation);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2314;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Extern) {
				{
				State = 2313;
				Match(Extern);
				}
			}

			State = 2316;
			Match(Template);
			State = 2317;
			declaration();
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

	public partial class ExplicitspecializationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Template() { return GetToken(CPP14Parser.Template, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Less() { return GetToken(CPP14Parser.Less, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Greater() { return GetToken(CPP14Parser.Greater, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationContext declaration() {
			return GetRuleContext<DeclarationContext>(0);
		}
		public ExplicitspecializationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_explicitspecialization; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterExplicitspecialization(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitExplicitspecialization(this);
		}
	}

	[RuleVersion(0)]
	public ExplicitspecializationContext explicitspecialization() {
		ExplicitspecializationContext _localctx = new ExplicitspecializationContext(Context, State);
		EnterRule(_localctx, 368, RULE_explicitspecialization);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2319;
			Match(Template);
			State = 2320;
			Match(Less);
			State = 2321;
			Match(Greater);
			State = 2322;
			declaration();
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

	public partial class TryblockContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Try() { return GetToken(CPP14Parser.Try, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public CompoundstatementContext compoundstatement() {
			return GetRuleContext<CompoundstatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public HandlerseqContext handlerseq() {
			return GetRuleContext<HandlerseqContext>(0);
		}
		public TryblockContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tryblock; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTryblock(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTryblock(this);
		}
	}

	[RuleVersion(0)]
	public TryblockContext tryblock() {
		TryblockContext _localctx = new TryblockContext(Context, State);
		EnterRule(_localctx, 370, RULE_tryblock);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2324;
			Match(Try);
			State = 2325;
			compoundstatement();
			State = 2326;
			handlerseq();
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

	public partial class FunctiontryblockContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Try() { return GetToken(CPP14Parser.Try, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public CompoundstatementContext compoundstatement() {
			return GetRuleContext<CompoundstatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public HandlerseqContext handlerseq() {
			return GetRuleContext<HandlerseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CtorinitializerContext ctorinitializer() {
			return GetRuleContext<CtorinitializerContext>(0);
		}
		public FunctiontryblockContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_functiontryblock; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterFunctiontryblock(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitFunctiontryblock(this);
		}
	}

	[RuleVersion(0)]
	public FunctiontryblockContext functiontryblock() {
		FunctiontryblockContext _localctx = new FunctiontryblockContext(Context, State);
		EnterRule(_localctx, 372, RULE_functiontryblock);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2328;
			Match(Try);
			State = 2330;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Colon) {
				{
				State = 2329;
				ctorinitializer();
				}
			}

			State = 2332;
			compoundstatement();
			State = 2333;
			handlerseq();
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

	public partial class HandlerseqContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public HandlerContext handler() {
			return GetRuleContext<HandlerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public HandlerseqContext handlerseq() {
			return GetRuleContext<HandlerseqContext>(0);
		}
		public HandlerseqContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_handlerseq; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterHandlerseq(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitHandlerseq(this);
		}
	}

	[RuleVersion(0)]
	public HandlerseqContext handlerseq() {
		HandlerseqContext _localctx = new HandlerseqContext(Context, State);
		EnterRule(_localctx, 374, RULE_handlerseq);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2335;
			handler();
			State = 2337;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,302,Context) ) {
			case 1:
				{
				State = 2336;
				handlerseq();
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

	public partial class HandlerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Catch() { return GetToken(CPP14Parser.Catch, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExceptiondeclarationContext exceptiondeclaration() {
			return GetRuleContext<ExceptiondeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public CompoundstatementContext compoundstatement() {
			return GetRuleContext<CompoundstatementContext>(0);
		}
		public HandlerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_handler; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterHandler(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitHandler(this);
		}
	}

	[RuleVersion(0)]
	public HandlerContext handler() {
		HandlerContext _localctx = new HandlerContext(Context, State);
		EnterRule(_localctx, 376, RULE_handler);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2339;
			Match(Catch);
			State = 2340;
			Match(LeftParen);
			State = 2341;
			exceptiondeclaration();
			State = 2342;
			Match(RightParen);
			State = 2343;
			compoundstatement();
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

	public partial class ExceptiondeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TypespecifierseqContext typespecifierseq() {
			return GetRuleContext<TypespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclaratorContext declarator() {
			return GetRuleContext<DeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributespecifierseqContext attributespecifierseq() {
			return GetRuleContext<AttributespecifierseqContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AbstractdeclaratorContext abstractdeclarator() {
			return GetRuleContext<AbstractdeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ellipsis() { return GetToken(CPP14Parser.Ellipsis, 0); }
		public ExceptiondeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exceptiondeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterExceptiondeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitExceptiondeclaration(this);
		}
	}

	[RuleVersion(0)]
	public ExceptiondeclarationContext exceptiondeclaration() {
		ExceptiondeclarationContext _localctx = new ExceptiondeclarationContext(Context, State);
		EnterRule(_localctx, 378, RULE_exceptiondeclaration);
		int _la;
		try {
			State = 2359;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,306,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2346;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 2345;
					attributespecifierseq(0);
					}
				}

				State = 2348;
				typespecifierseq();
				State = 2349;
				declarator();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2352;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Alignas || _la==LeftBracket) {
					{
					State = 2351;
					attributespecifierseq(0);
					}
				}

				State = 2354;
				typespecifierseq();
				State = 2356;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==T__2 || _la==Decltype || ((((_la - 84)) & ~0x3f) == 0 && ((1L << (_la - 84)) & ((1L << (LeftParen - 84)) | (1L << (LeftBracket - 84)) | (1L << (Star - 84)) | (1L << (And - 84)) | (1L << (Doublecolon - 84)) | (1L << (Ellipsis - 84)) | (1L << (Identifier - 84)))) != 0)) {
					{
					State = 2355;
					abstractdeclarator();
					}
				}

				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2358;
				Match(Ellipsis);
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

	public partial class ThrowexpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Throw() { return GetToken(CPP14Parser.Throw, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentexpressionContext assignmentexpression() {
			return GetRuleContext<AssignmentexpressionContext>(0);
		}
		public ThrowexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_throwexpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterThrowexpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitThrowexpression(this);
		}
	}

	[RuleVersion(0)]
	public ThrowexpressionContext throwexpression() {
		ThrowexpressionContext _localctx = new ThrowexpressionContext(Context, State);
		EnterRule(_localctx, 380, RULE_throwexpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2361;
			Match(Throw);
			State = 2363;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,307,Context) ) {
			case 1:
				{
				State = 2362;
				assignmentexpression();
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

	public partial class ExceptionspecificationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DynamicexceptionspecificationContext dynamicexceptionspecification() {
			return GetRuleContext<DynamicexceptionspecificationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NoexceptspecificationContext noexceptspecification() {
			return GetRuleContext<NoexceptspecificationContext>(0);
		}
		public ExceptionspecificationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exceptionspecification; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterExceptionspecification(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitExceptionspecification(this);
		}
	}

	[RuleVersion(0)]
	public ExceptionspecificationContext exceptionspecification() {
		ExceptionspecificationContext _localctx = new ExceptionspecificationContext(Context, State);
		EnterRule(_localctx, 382, RULE_exceptionspecification);
		try {
			State = 2367;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Throw:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2365;
				dynamicexceptionspecification();
				}
				break;
			case Noexcept:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2366;
				noexceptspecification();
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

	public partial class DynamicexceptionspecificationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Throw() { return GetToken(CPP14Parser.Throw, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeidlistContext typeidlist() {
			return GetRuleContext<TypeidlistContext>(0);
		}
		public DynamicexceptionspecificationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dynamicexceptionspecification; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterDynamicexceptionspecification(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitDynamicexceptionspecification(this);
		}
	}

	[RuleVersion(0)]
	public DynamicexceptionspecificationContext dynamicexceptionspecification() {
		DynamicexceptionspecificationContext _localctx = new DynamicexceptionspecificationContext(Context, State);
		EnterRule(_localctx, 384, RULE_dynamicexceptionspecification);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2369;
			Match(Throw);
			State = 2370;
			Match(LeftParen);
			State = 2372;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 12)) & ~0x3f) == 0 && ((1L << (_la - 12)) & ((1L << (Auto - 12)) | (1L << (Bool - 12)) | (1L << (Char - 12)) | (1L << (Char16 - 12)) | (1L << (Char32 - 12)) | (1L << (Class - 12)) | (1L << (Const - 12)) | (1L << (Decltype - 12)) | (1L << (Double - 12)) | (1L << (Enum - 12)) | (1L << (Float - 12)) | (1L << (Int - 12)) | (1L << (Long - 12)) | (1L << (Short - 12)) | (1L << (Signed - 12)) | (1L << (Struct - 12)) | (1L << (Typename_ - 12)))) != 0) || ((((_la - 76)) & ~0x3f) == 0 && ((1L << (_la - 76)) & ((1L << (Union - 76)) | (1L << (Unsigned - 76)) | (1L << (Void - 76)) | (1L << (Volatile - 76)) | (1L << (Wchar - 76)) | (1L << (Doublecolon - 76)) | (1L << (Identifier - 76)))) != 0)) {
				{
				State = 2371;
				typeidlist(0);
				}
			}

			State = 2374;
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

	public partial class TypeidlistContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ThetypeidContext thetypeid() {
			return GetRuleContext<ThetypeidContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ellipsis() { return GetToken(CPP14Parser.Ellipsis, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeidlistContext typeidlist() {
			return GetRuleContext<TypeidlistContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		public TypeidlistContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeidlist; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTypeidlist(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTypeidlist(this);
		}
	}

	[RuleVersion(0)]
	public TypeidlistContext typeidlist() {
		return typeidlist(0);
	}

	private TypeidlistContext typeidlist(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		TypeidlistContext _localctx = new TypeidlistContext(Context, _parentState);
		TypeidlistContext _prevctx = _localctx;
		int _startState = 386;
		EnterRecursionRule(_localctx, 386, RULE_typeidlist, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 2377;
			thetypeid();
			State = 2379;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,310,Context) ) {
			case 1:
				{
				State = 2378;
				Match(Ellipsis);
				}
				break;
			}
			}
			Context.Stop = TokenStream.LT(-1);
			State = 2389;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,312,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new TypeidlistContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_typeidlist);
					State = 2381;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 2382;
					Match(Comma);
					State = 2383;
					thetypeid();
					State = 2385;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,311,Context) ) {
					case 1:
						{
						State = 2384;
						Match(Ellipsis);
						}
						break;
					}
					}
					} 
				}
				State = 2391;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,312,Context);
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

	public partial class NoexceptspecificationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Noexcept() { return GetToken(CPP14Parser.Noexcept, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantexpressionContext constantexpression() {
			return GetRuleContext<ConstantexpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		public NoexceptspecificationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_noexceptspecification; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterNoexceptspecification(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitNoexceptspecification(this);
		}
	}

	[RuleVersion(0)]
	public NoexceptspecificationContext noexceptspecification() {
		NoexceptspecificationContext _localctx = new NoexceptspecificationContext(Context, State);
		EnterRule(_localctx, 388, RULE_noexceptspecification);
		try {
			State = 2398;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,313,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2392;
				Match(Noexcept);
				State = 2393;
				Match(LeftParen);
				State = 2394;
				constantexpression();
				State = 2395;
				Match(RightParen);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2397;
				Match(Noexcept);
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

	public partial class TheoperatorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode New() { return GetToken(CPP14Parser.New, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Delete() { return GetToken(CPP14Parser.Delete, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftBracket() { return GetToken(CPP14Parser.LeftBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightBracket() { return GetToken(CPP14Parser.RightBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Plus() { return GetToken(CPP14Parser.Plus, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Minus() { return GetToken(CPP14Parser.Minus, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Star() { return GetToken(CPP14Parser.Star, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Div() { return GetToken(CPP14Parser.Div, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Mod() { return GetToken(CPP14Parser.Mod, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Caret() { return GetToken(CPP14Parser.Caret, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode And() { return GetToken(CPP14Parser.And, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Or() { return GetToken(CPP14Parser.Or, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Tilde() { return GetToken(CPP14Parser.Tilde, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Assign() { return GetToken(CPP14Parser.Assign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Less() { return GetToken(CPP14Parser.Less, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Greater() { return GetToken(CPP14Parser.Greater, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PlusAssign() { return GetToken(CPP14Parser.PlusAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MinusAssign() { return GetToken(CPP14Parser.MinusAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode StarAssign() { return GetToken(CPP14Parser.StarAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DivAssign() { return GetToken(CPP14Parser.DivAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ModAssign() { return GetToken(CPP14Parser.ModAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode XorAssign() { return GetToken(CPP14Parser.XorAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AndAssign() { return GetToken(CPP14Parser.AndAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OrAssign() { return GetToken(CPP14Parser.OrAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftShift() { return GetToken(CPP14Parser.LeftShift, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightShift() { return GetToken(CPP14Parser.RightShift, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightShiftAssign() { return GetToken(CPP14Parser.RightShiftAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftShiftAssign() { return GetToken(CPP14Parser.LeftShiftAssign, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Equal() { return GetToken(CPP14Parser.Equal, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NotEqual() { return GetToken(CPP14Parser.NotEqual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LessEqual() { return GetToken(CPP14Parser.LessEqual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GreaterEqual() { return GetToken(CPP14Parser.GreaterEqual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PlusPlus() { return GetToken(CPP14Parser.PlusPlus, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MinusMinus() { return GetToken(CPP14Parser.MinusMinus, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(CPP14Parser.Comma, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ArrowStar() { return GetToken(CPP14Parser.ArrowStar, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Arrow() { return GetToken(CPP14Parser.Arrow, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LeftParen() { return GetToken(CPP14Parser.LeftParen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RightParen() { return GetToken(CPP14Parser.RightParen, 0); }
		public TheoperatorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_theoperator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterTheoperator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitTheoperator(this);
		}
	}

	[RuleVersion(0)]
	public TheoperatorContext theoperator() {
		TheoperatorContext _localctx = new TheoperatorContext(Context, State);
		EnterRule(_localctx, 390, RULE_theoperator);
		try {
			State = 2451;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,314,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2400;
				Match(New);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2401;
				Match(Delete);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2402;
				Match(New);
				State = 2403;
				Match(LeftBracket);
				State = 2404;
				Match(RightBracket);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 2405;
				Match(Delete);
				State = 2406;
				Match(LeftBracket);
				State = 2407;
				Match(RightBracket);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 2408;
				Match(Plus);
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 2409;
				Match(Minus);
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 2410;
				Match(Star);
				}
				break;
			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 2411;
				Match(Div);
				}
				break;
			case 9:
				EnterOuterAlt(_localctx, 9);
				{
				State = 2412;
				Match(Mod);
				}
				break;
			case 10:
				EnterOuterAlt(_localctx, 10);
				{
				State = 2413;
				Match(Caret);
				}
				break;
			case 11:
				EnterOuterAlt(_localctx, 11);
				{
				State = 2414;
				Match(And);
				}
				break;
			case 12:
				EnterOuterAlt(_localctx, 12);
				{
				State = 2415;
				Match(Or);
				}
				break;
			case 13:
				EnterOuterAlt(_localctx, 13);
				{
				State = 2416;
				Match(Tilde);
				}
				break;
			case 14:
				EnterOuterAlt(_localctx, 14);
				{
				State = 2417;
				Match(T__0);
				}
				break;
			case 15:
				EnterOuterAlt(_localctx, 15);
				{
				State = 2418;
				Match(T__1);
				}
				break;
			case 16:
				EnterOuterAlt(_localctx, 16);
				{
				State = 2419;
				Match(Assign);
				}
				break;
			case 17:
				EnterOuterAlt(_localctx, 17);
				{
				State = 2420;
				Match(Less);
				}
				break;
			case 18:
				EnterOuterAlt(_localctx, 18);
				{
				State = 2421;
				Match(Greater);
				}
				break;
			case 19:
				EnterOuterAlt(_localctx, 19);
				{
				State = 2422;
				Match(PlusAssign);
				}
				break;
			case 20:
				EnterOuterAlt(_localctx, 20);
				{
				State = 2423;
				Match(MinusAssign);
				}
				break;
			case 21:
				EnterOuterAlt(_localctx, 21);
				{
				State = 2424;
				Match(StarAssign);
				}
				break;
			case 22:
				EnterOuterAlt(_localctx, 22);
				{
				State = 2425;
				Match(DivAssign);
				}
				break;
			case 23:
				EnterOuterAlt(_localctx, 23);
				{
				State = 2426;
				Match(ModAssign);
				}
				break;
			case 24:
				EnterOuterAlt(_localctx, 24);
				{
				State = 2427;
				Match(XorAssign);
				}
				break;
			case 25:
				EnterOuterAlt(_localctx, 25);
				{
				State = 2428;
				Match(AndAssign);
				}
				break;
			case 26:
				EnterOuterAlt(_localctx, 26);
				{
				State = 2429;
				Match(OrAssign);
				}
				break;
			case 27:
				EnterOuterAlt(_localctx, 27);
				{
				State = 2430;
				Match(LeftShift);
				}
				break;
			case 28:
				EnterOuterAlt(_localctx, 28);
				{
				State = 2431;
				Match(RightShift);
				}
				break;
			case 29:
				EnterOuterAlt(_localctx, 29);
				{
				State = 2432;
				Match(RightShiftAssign);
				}
				break;
			case 30:
				EnterOuterAlt(_localctx, 30);
				{
				State = 2433;
				Match(LeftShiftAssign);
				}
				break;
			case 31:
				EnterOuterAlt(_localctx, 31);
				{
				State = 2434;
				Match(Equal);
				}
				break;
			case 32:
				EnterOuterAlt(_localctx, 32);
				{
				State = 2435;
				Match(NotEqual);
				}
				break;
			case 33:
				EnterOuterAlt(_localctx, 33);
				{
				State = 2436;
				Match(LessEqual);
				}
				break;
			case 34:
				EnterOuterAlt(_localctx, 34);
				{
				State = 2437;
				Match(GreaterEqual);
				}
				break;
			case 35:
				EnterOuterAlt(_localctx, 35);
				{
				State = 2438;
				Match(T__2);
				}
				break;
			case 36:
				EnterOuterAlt(_localctx, 36);
				{
				State = 2439;
				Match(T__3);
				}
				break;
			case 37:
				EnterOuterAlt(_localctx, 37);
				{
				State = 2440;
				Match(T__4);
				}
				break;
			case 38:
				EnterOuterAlt(_localctx, 38);
				{
				State = 2441;
				Match(T__5);
				}
				break;
			case 39:
				EnterOuterAlt(_localctx, 39);
				{
				State = 2442;
				Match(PlusPlus);
				}
				break;
			case 40:
				EnterOuterAlt(_localctx, 40);
				{
				State = 2443;
				Match(MinusMinus);
				}
				break;
			case 41:
				EnterOuterAlt(_localctx, 41);
				{
				State = 2444;
				Match(Comma);
				}
				break;
			case 42:
				EnterOuterAlt(_localctx, 42);
				{
				State = 2445;
				Match(ArrowStar);
				}
				break;
			case 43:
				EnterOuterAlt(_localctx, 43);
				{
				State = 2446;
				Match(Arrow);
				}
				break;
			case 44:
				EnterOuterAlt(_localctx, 44);
				{
				State = 2447;
				Match(LeftParen);
				State = 2448;
				Match(RightParen);
				}
				break;
			case 45:
				EnterOuterAlt(_localctx, 45);
				{
				State = 2449;
				Match(LeftBracket);
				State = 2450;
				Match(RightBracket);
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

	public partial class LiteralContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Integerliteral() { return GetToken(CPP14Parser.Integerliteral, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Characterliteral() { return GetToken(CPP14Parser.Characterliteral, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Floatingliteral() { return GetToken(CPP14Parser.Floatingliteral, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Stringliteral() { return GetToken(CPP14Parser.Stringliteral, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BooleanliteralContext booleanliteral() {
			return GetRuleContext<BooleanliteralContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PointerliteralContext pointerliteral() {
			return GetRuleContext<PointerliteralContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UserdefinedliteralContext userdefinedliteral() {
			return GetRuleContext<UserdefinedliteralContext>(0);
		}
		public LiteralContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_literal; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterLiteral(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitLiteral(this);
		}
	}

	[RuleVersion(0)]
	public LiteralContext literal() {
		LiteralContext _localctx = new LiteralContext(Context, State);
		EnterRule(_localctx, 392, RULE_literal);
		try {
			State = 2460;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Integerliteral:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2453;
				Match(Integerliteral);
				}
				break;
			case Characterliteral:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2454;
				Match(Characterliteral);
				}
				break;
			case Floatingliteral:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2455;
				Match(Floatingliteral);
				}
				break;
			case Stringliteral:
				EnterOuterAlt(_localctx, 4);
				{
				State = 2456;
				Match(Stringliteral);
				}
				break;
			case False:
			case True:
				EnterOuterAlt(_localctx, 5);
				{
				State = 2457;
				booleanliteral();
				}
				break;
			case Nullptr:
				EnterOuterAlt(_localctx, 6);
				{
				State = 2458;
				pointerliteral();
				}
				break;
			case Userdefinedintegerliteral:
			case Userdefinedfloatingliteral:
			case Userdefinedstringliteral:
			case Userdefinedcharacterliteral:
				EnterOuterAlt(_localctx, 7);
				{
				State = 2459;
				userdefinedliteral();
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

	public partial class BooleanliteralContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode False() { return GetToken(CPP14Parser.False, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode True() { return GetToken(CPP14Parser.True, 0); }
		public BooleanliteralContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_booleanliteral; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterBooleanliteral(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitBooleanliteral(this);
		}
	}

	[RuleVersion(0)]
	public BooleanliteralContext booleanliteral() {
		BooleanliteralContext _localctx = new BooleanliteralContext(Context, State);
		EnterRule(_localctx, 394, RULE_booleanliteral);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2462;
			_la = TokenStream.LA(1);
			if ( !(_la==False || _la==True) ) {
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

	public partial class PointerliteralContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Nullptr() { return GetToken(CPP14Parser.Nullptr, 0); }
		public PointerliteralContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_pointerliteral; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterPointerliteral(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitPointerliteral(this);
		}
	}

	[RuleVersion(0)]
	public PointerliteralContext pointerliteral() {
		PointerliteralContext _localctx = new PointerliteralContext(Context, State);
		EnterRule(_localctx, 396, RULE_pointerliteral);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2464;
			Match(Nullptr);
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

	public partial class UserdefinedliteralContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Userdefinedintegerliteral() { return GetToken(CPP14Parser.Userdefinedintegerliteral, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Userdefinedfloatingliteral() { return GetToken(CPP14Parser.Userdefinedfloatingliteral, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Userdefinedstringliteral() { return GetToken(CPP14Parser.Userdefinedstringliteral, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Userdefinedcharacterliteral() { return GetToken(CPP14Parser.Userdefinedcharacterliteral, 0); }
		public UserdefinedliteralContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_userdefinedliteral; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.EnterUserdefinedliteral(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICPP14Listener typedListener = listener as ICPP14Listener;
			if (typedListener != null) typedListener.ExitUserdefinedliteral(this);
		}
	}

	[RuleVersion(0)]
	public UserdefinedliteralContext userdefinedliteral() {
		UserdefinedliteralContext _localctx = new UserdefinedliteralContext(Context, State);
		EnterRule(_localctx, 398, RULE_userdefinedliteral);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2466;
			_la = TokenStream.LA(1);
			if ( !(((((_la - 143)) & ~0x3f) == 0 && ((1L << (_la - 143)) & ((1L << (Userdefinedintegerliteral - 143)) | (1L << (Userdefinedfloatingliteral - 143)) | (1L << (Userdefinedstringliteral - 143)) | (1L << (Userdefinedcharacterliteral - 143)))) != 0)) ) {
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

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 5: return nestednamespecifier_sempred((NestednamespecifierContext)_localctx, predIndex);
		case 10: return capturelist_sempred((CapturelistContext)_localctx, predIndex);
		case 15: return postfixexpression_sempred((PostfixexpressionContext)_localctx, predIndex);
		case 26: return noptrnewdeclarator_sempred((NoptrnewdeclaratorContext)_localctx, predIndex);
		case 31: return pmexpression_sempred((PmexpressionContext)_localctx, predIndex);
		case 32: return multiplicativeexpression_sempred((MultiplicativeexpressionContext)_localctx, predIndex);
		case 33: return additiveexpression_sempred((AdditiveexpressionContext)_localctx, predIndex);
		case 34: return shiftexpression_sempred((ShiftexpressionContext)_localctx, predIndex);
		case 36: return relationalexpression_sempred((RelationalexpressionContext)_localctx, predIndex);
		case 37: return equalityexpression_sempred((EqualityexpressionContext)_localctx, predIndex);
		case 38: return andexpression_sempred((AndexpressionContext)_localctx, predIndex);
		case 39: return exclusiveorexpression_sempred((ExclusiveorexpressionContext)_localctx, predIndex);
		case 40: return inclusiveorexpression_sempred((InclusiveorexpressionContext)_localctx, predIndex);
		case 41: return logicalandexpression_sempred((LogicalandexpressionContext)_localctx, predIndex);
		case 42: return logicalorexpression_sempred((LogicalorexpressionContext)_localctx, predIndex);
		case 46: return expression_sempred((ExpressionContext)_localctx, predIndex);
		case 52: return statementseq_sempred((StatementseqContext)_localctx, predIndex);
		case 61: return declarationseq_sempred((DeclarationseqContext)_localctx, predIndex);
		case 88: return enumeratorlist_sempred((EnumeratorlistContext)_localctx, predIndex);
		case 106: return attributespecifierseq_sempred((AttributespecifierseqContext)_localctx, predIndex);
		case 109: return attributelist_sempred((AttributelistContext)_localctx, predIndex);
		case 115: return balancedtokenseq_sempred((BalancedtokenseqContext)_localctx, predIndex);
		case 117: return initdeclaratorlist_sempred((InitdeclaratorlistContext)_localctx, predIndex);
		case 121: return noptrdeclarator_sempred((NoptrdeclaratorContext)_localctx, predIndex);
		case 132: return noptrabstractdeclarator_sempred((NoptrabstractdeclaratorContext)_localctx, predIndex);
		case 134: return noptrabstractpackdeclarator_sempred((NoptrabstractpackdeclaratorContext)_localctx, predIndex);
		case 136: return parameterdeclarationlist_sempred((ParameterdeclarationlistContext)_localctx, predIndex);
		case 143: return initializerlist_sempred((InitializerlistContext)_localctx, predIndex);
		case 153: return memberdeclaratorlist_sempred((MemberdeclaratorlistContext)_localctx, predIndex);
		case 155: return virtspecifierseq_sempred((VirtspecifierseqContext)_localctx, predIndex);
		case 159: return basespecifierlist_sempred((BasespecifierlistContext)_localctx, predIndex);
		case 174: return templateparameterlist_sempred((TemplateparameterlistContext)_localctx, predIndex);
		case 180: return templateargumentlist_sempred((TemplateargumentlistContext)_localctx, predIndex);
		case 193: return typeidlist_sempred((TypeidlistContext)_localctx, predIndex);
		}
		return true;
	}
	private bool nestednamespecifier_sempred(NestednamespecifierContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 2);
		case 1: return Precpred(Context, 1);
		}
		return true;
	}
	private bool capturelist_sempred(CapturelistContext _localctx, int predIndex) {
		switch (predIndex) {
		case 2: return Precpred(Context, 1);
		}
		return true;
	}
	private bool postfixexpression_sempred(PostfixexpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 3: return Precpred(Context, 19);
		case 4: return Precpred(Context, 18);
		case 5: return Precpred(Context, 17);
		case 6: return Precpred(Context, 12);
		case 7: return Precpred(Context, 11);
		case 8: return Precpred(Context, 10);
		case 9: return Precpred(Context, 9);
		case 10: return Precpred(Context, 8);
		case 11: return Precpred(Context, 7);
		}
		return true;
	}
	private bool noptrnewdeclarator_sempred(NoptrnewdeclaratorContext _localctx, int predIndex) {
		switch (predIndex) {
		case 12: return Precpred(Context, 1);
		}
		return true;
	}
	private bool pmexpression_sempred(PmexpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 13: return Precpred(Context, 2);
		case 14: return Precpred(Context, 1);
		}
		return true;
	}
	private bool multiplicativeexpression_sempred(MultiplicativeexpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 15: return Precpred(Context, 3);
		case 16: return Precpred(Context, 2);
		case 17: return Precpred(Context, 1);
		}
		return true;
	}
	private bool additiveexpression_sempred(AdditiveexpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 18: return Precpred(Context, 2);
		case 19: return Precpred(Context, 1);
		}
		return true;
	}
	private bool shiftexpression_sempred(ShiftexpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 20: return Precpred(Context, 1);
		}
		return true;
	}
	private bool relationalexpression_sempred(RelationalexpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 21: return Precpred(Context, 4);
		case 22: return Precpred(Context, 3);
		case 23: return Precpred(Context, 2);
		case 24: return Precpred(Context, 1);
		}
		return true;
	}
	private bool equalityexpression_sempred(EqualityexpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 25: return Precpred(Context, 2);
		case 26: return Precpred(Context, 1);
		}
		return true;
	}
	private bool andexpression_sempred(AndexpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 27: return Precpred(Context, 1);
		}
		return true;
	}
	private bool exclusiveorexpression_sempred(ExclusiveorexpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 28: return Precpred(Context, 1);
		}
		return true;
	}
	private bool inclusiveorexpression_sempred(InclusiveorexpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 29: return Precpred(Context, 1);
		}
		return true;
	}
	private bool logicalandexpression_sempred(LogicalandexpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 30: return Precpred(Context, 2);
		case 31: return Precpred(Context, 1);
		}
		return true;
	}
	private bool logicalorexpression_sempred(LogicalorexpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 32: return Precpred(Context, 2);
		case 33: return Precpred(Context, 1);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 34: return Precpred(Context, 1);
		}
		return true;
	}
	private bool statementseq_sempred(StatementseqContext _localctx, int predIndex) {
		switch (predIndex) {
		case 35: return Precpred(Context, 1);
		}
		return true;
	}
	private bool declarationseq_sempred(DeclarationseqContext _localctx, int predIndex) {
		switch (predIndex) {
		case 36: return Precpred(Context, 1);
		}
		return true;
	}
	private bool enumeratorlist_sempred(EnumeratorlistContext _localctx, int predIndex) {
		switch (predIndex) {
		case 37: return Precpred(Context, 1);
		}
		return true;
	}
	private bool attributespecifierseq_sempred(AttributespecifierseqContext _localctx, int predIndex) {
		switch (predIndex) {
		case 38: return Precpred(Context, 1);
		}
		return true;
	}
	private bool attributelist_sempred(AttributelistContext _localctx, int predIndex) {
		switch (predIndex) {
		case 39: return Precpred(Context, 3);
		case 40: return Precpred(Context, 1);
		}
		return true;
	}
	private bool balancedtokenseq_sempred(BalancedtokenseqContext _localctx, int predIndex) {
		switch (predIndex) {
		case 41: return Precpred(Context, 1);
		}
		return true;
	}
	private bool initdeclaratorlist_sempred(InitdeclaratorlistContext _localctx, int predIndex) {
		switch (predIndex) {
		case 42: return Precpred(Context, 1);
		}
		return true;
	}
	private bool noptrdeclarator_sempred(NoptrdeclaratorContext _localctx, int predIndex) {
		switch (predIndex) {
		case 43: return Precpred(Context, 3);
		case 44: return Precpred(Context, 2);
		}
		return true;
	}
	private bool noptrabstractdeclarator_sempred(NoptrabstractdeclaratorContext _localctx, int predIndex) {
		switch (predIndex) {
		case 45: return Precpred(Context, 5);
		case 46: return Precpred(Context, 3);
		}
		return true;
	}
	private bool noptrabstractpackdeclarator_sempred(NoptrabstractpackdeclaratorContext _localctx, int predIndex) {
		switch (predIndex) {
		case 47: return Precpred(Context, 3);
		case 48: return Precpred(Context, 2);
		}
		return true;
	}
	private bool parameterdeclarationlist_sempred(ParameterdeclarationlistContext _localctx, int predIndex) {
		switch (predIndex) {
		case 49: return Precpred(Context, 1);
		}
		return true;
	}
	private bool initializerlist_sempred(InitializerlistContext _localctx, int predIndex) {
		switch (predIndex) {
		case 50: return Precpred(Context, 1);
		}
		return true;
	}
	private bool memberdeclaratorlist_sempred(MemberdeclaratorlistContext _localctx, int predIndex) {
		switch (predIndex) {
		case 51: return Precpred(Context, 1);
		}
		return true;
	}
	private bool virtspecifierseq_sempred(VirtspecifierseqContext _localctx, int predIndex) {
		switch (predIndex) {
		case 52: return Precpred(Context, 1);
		}
		return true;
	}
	private bool basespecifierlist_sempred(BasespecifierlistContext _localctx, int predIndex) {
		switch (predIndex) {
		case 53: return Precpred(Context, 1);
		}
		return true;
	}
	private bool templateparameterlist_sempred(TemplateparameterlistContext _localctx, int predIndex) {
		switch (predIndex) {
		case 54: return Precpred(Context, 1);
		}
		return true;
	}
	private bool templateargumentlist_sempred(TemplateargumentlistContext _localctx, int predIndex) {
		switch (predIndex) {
		case 55: return Precpred(Context, 1);
		}
		return true;
	}
	private bool typeidlist_sempred(TypeidlistContext _localctx, int predIndex) {
		switch (predIndex) {
		case 56: return Precpred(Context, 1);
		}
		return true;
	}

	private static int[] _serializedATN = {
		4,1,150,2469,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,
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
		2,85,7,85,2,86,7,86,2,87,7,87,2,88,7,88,2,89,7,89,2,90,7,90,2,91,7,91,
		2,92,7,92,2,93,7,93,2,94,7,94,2,95,7,95,2,96,7,96,2,97,7,97,2,98,7,98,
		2,99,7,99,2,100,7,100,2,101,7,101,2,102,7,102,2,103,7,103,2,104,7,104,
		2,105,7,105,2,106,7,106,2,107,7,107,2,108,7,108,2,109,7,109,2,110,7,110,
		2,111,7,111,2,112,7,112,2,113,7,113,2,114,7,114,2,115,7,115,2,116,7,116,
		2,117,7,117,2,118,7,118,2,119,7,119,2,120,7,120,2,121,7,121,2,122,7,122,
		2,123,7,123,2,124,7,124,2,125,7,125,2,126,7,126,2,127,7,127,2,128,7,128,
		2,129,7,129,2,130,7,130,2,131,7,131,2,132,7,132,2,133,7,133,2,134,7,134,
		2,135,7,135,2,136,7,136,2,137,7,137,2,138,7,138,2,139,7,139,2,140,7,140,
		2,141,7,141,2,142,7,142,2,143,7,143,2,144,7,144,2,145,7,145,2,146,7,146,
		2,147,7,147,2,148,7,148,2,149,7,149,2,150,7,150,2,151,7,151,2,152,7,152,
		2,153,7,153,2,154,7,154,2,155,7,155,2,156,7,156,2,157,7,157,2,158,7,158,
		2,159,7,159,2,160,7,160,2,161,7,161,2,162,7,162,2,163,7,163,2,164,7,164,
		2,165,7,165,2,166,7,166,2,167,7,167,2,168,7,168,2,169,7,169,2,170,7,170,
		2,171,7,171,2,172,7,172,2,173,7,173,2,174,7,174,2,175,7,175,2,176,7,176,
		2,177,7,177,2,178,7,178,2,179,7,179,2,180,7,180,2,181,7,181,2,182,7,182,
		2,183,7,183,2,184,7,184,2,185,7,185,2,186,7,186,2,187,7,187,2,188,7,188,
		2,189,7,189,2,190,7,190,2,191,7,191,2,192,7,192,2,193,7,193,2,194,7,194,
		2,195,7,195,2,196,7,196,2,197,7,197,2,198,7,198,2,199,7,199,1,0,3,0,402,
		8,0,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,3,1,414,8,1,1,2,1,2,3,2,418,
		8,2,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,3,3,429,8,3,1,4,1,4,3,4,433,8,
		4,1,4,1,4,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,3,5,448,8,5,1,5,
		1,5,1,5,1,5,1,5,3,5,455,8,5,1,5,1,5,1,5,5,5,460,8,5,10,5,12,5,463,9,5,
		1,6,1,6,3,6,467,8,6,1,6,1,6,1,7,1,7,3,7,473,8,7,1,7,1,7,1,8,1,8,1,8,1,
		8,1,8,1,8,3,8,483,8,8,1,9,1,9,1,10,1,10,1,10,3,10,490,8,10,1,10,1,10,1,
		10,1,10,3,10,496,8,10,5,10,498,8,10,10,10,12,10,501,9,10,1,11,1,11,3,11,
		505,8,11,1,12,1,12,1,12,1,12,3,12,511,8,12,1,13,1,13,1,13,1,13,1,13,3,
		13,518,8,13,1,14,1,14,1,14,1,14,3,14,524,8,14,1,14,3,14,527,8,14,1,14,
		3,14,530,8,14,1,14,3,14,533,8,14,1,15,1,15,1,15,1,15,1,15,3,15,540,8,15,
		1,15,1,15,1,15,1,15,1,15,3,15,547,8,15,1,15,1,15,1,15,1,15,1,15,1,15,1,
		15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,
		15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,
		15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,
		15,1,15,3,15,599,8,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,
		1,15,1,15,1,15,3,15,614,8,15,1,15,1,15,1,15,1,15,3,15,620,8,15,1,15,1,
		15,1,15,1,15,3,15,626,8,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,
		1,15,1,15,5,15,639,8,15,10,15,12,15,642,9,15,1,16,1,16,1,17,1,17,1,18,
		1,18,1,19,3,19,651,8,19,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,
		19,1,19,1,19,1,19,3,19,666,8,19,1,19,1,19,1,19,1,19,3,19,672,8,19,1,20,
		1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,20,
		1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,20,1,20,3,20,
		702,8,20,1,21,1,21,1,22,3,22,707,8,22,1,22,1,22,3,22,711,8,22,1,22,1,22,
		3,22,715,8,22,1,22,3,22,718,8,22,1,22,1,22,3,22,722,8,22,1,22,1,22,1,22,
		1,22,3,22,728,8,22,3,22,730,8,22,1,23,1,23,1,23,1,23,1,24,1,24,3,24,738,
		8,24,1,25,1,25,3,25,742,8,25,1,25,3,25,745,8,25,1,26,1,26,1,26,1,26,1,
		26,3,26,752,8,26,1,26,1,26,1,26,1,26,1,26,3,26,759,8,26,5,26,761,8,26,
		10,26,12,26,764,9,26,1,27,1,27,3,27,768,8,27,1,27,1,27,3,27,772,8,27,1,
		28,3,28,775,8,28,1,28,1,28,1,28,3,28,780,8,28,1,28,1,28,1,28,1,28,3,28,
		786,8,28,1,29,1,29,1,29,1,29,1,29,1,30,1,30,1,30,1,30,1,30,1,30,3,30,799,
		8,30,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,5,31,810,8,31,10,31,
		12,31,813,9,31,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,
		1,32,5,32,827,8,32,10,32,12,32,830,9,32,1,33,1,33,1,33,1,33,1,33,1,33,
		1,33,1,33,1,33,5,33,841,8,33,10,33,12,33,844,9,33,1,34,1,34,1,34,1,34,
		1,34,1,34,1,34,5,34,853,8,34,10,34,12,34,856,9,34,1,35,1,35,1,36,1,36,
		1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,5,36,
		875,8,36,10,36,12,36,878,9,36,1,37,1,37,1,37,1,37,1,37,1,37,1,37,1,37,
		1,37,5,37,889,8,37,10,37,12,37,892,9,37,1,38,1,38,1,38,1,38,1,38,1,38,
		5,38,900,8,38,10,38,12,38,903,9,38,1,39,1,39,1,39,1,39,1,39,1,39,5,39,
		911,8,39,10,39,12,39,914,9,39,1,40,1,40,1,40,1,40,1,40,1,40,5,40,922,8,
		40,10,40,12,40,925,9,40,1,41,1,41,1,41,1,41,1,41,1,41,1,41,1,41,1,41,5,
		41,936,8,41,10,41,12,41,939,9,41,1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,
		42,1,42,5,42,950,8,42,10,42,12,42,953,9,42,1,43,1,43,1,43,1,43,1,43,1,
		43,1,43,3,43,962,8,43,1,44,1,44,1,44,1,44,1,44,1,44,3,44,970,8,44,1,45,
		1,45,1,46,1,46,1,46,1,46,1,46,1,46,5,46,980,8,46,10,46,12,46,983,9,46,
		1,47,1,47,1,48,1,48,3,48,989,8,48,1,48,1,48,3,48,993,8,48,1,48,1,48,3,
		48,997,8,48,1,48,1,48,3,48,1001,8,48,1,48,1,48,3,48,1005,8,48,1,48,1,48,
		1,48,3,48,1010,8,48,1,48,3,48,1013,8,48,1,49,3,49,1016,8,49,1,49,1,49,
		1,49,1,49,3,49,1022,8,49,1,49,1,49,1,49,1,49,1,49,1,49,3,49,1030,8,49,
		1,49,1,49,1,49,3,49,1035,8,49,1,50,3,50,1038,8,50,1,50,1,50,1,51,1,51,
		3,51,1044,8,51,1,51,1,51,1,52,1,52,1,52,1,52,1,52,5,52,1053,8,52,10,52,
		12,52,1056,9,52,1,53,1,53,1,53,1,53,1,53,1,53,1,53,1,53,1,53,1,53,1,53,
		1,53,1,53,1,53,1,53,1,53,1,53,1,53,1,53,1,53,3,53,1078,8,53,1,54,1,54,
		3,54,1082,8,54,1,54,1,54,1,54,1,54,1,54,1,54,3,54,1090,8,54,1,54,1,54,
		1,54,1,54,3,54,1096,8,54,1,55,1,55,1,55,1,55,1,55,1,55,1,55,1,55,1,55,
		1,55,1,55,1,55,1,55,1,55,1,55,1,55,1,55,1,55,3,55,1116,8,55,1,55,1,55,
		3,55,1120,8,55,1,55,1,55,1,55,1,55,1,55,1,55,1,55,1,55,1,55,1,55,1,55,
		3,55,1133,8,55,1,56,1,56,3,56,1137,8,56,1,57,3,57,1140,8,57,1,57,1,57,
		1,57,1,58,1,58,3,58,1147,8,58,1,59,1,59,1,59,1,59,1,59,1,59,3,59,1155,
		8,59,1,59,1,59,1,59,1,59,1,59,1,59,1,59,1,59,3,59,1165,8,59,1,60,1,60,
		1,61,1,61,1,61,1,61,1,61,5,61,1174,8,61,10,61,12,61,1177,9,61,1,62,1,62,
		1,62,1,62,1,62,1,62,1,62,1,62,1,62,3,62,1188,8,62,1,63,1,63,1,63,1,63,
		1,63,1,63,1,63,1,63,3,63,1198,8,63,1,64,1,64,1,64,3,64,1203,8,64,1,64,
		1,64,1,64,1,64,1,65,3,65,1210,8,65,1,65,3,65,1213,8,65,1,65,1,65,1,65,
		3,65,1218,8,65,1,65,1,65,1,65,3,65,1223,8,65,1,66,1,66,1,66,1,66,1,66,
		1,66,1,66,1,66,1,67,1,67,1,68,1,68,1,68,1,69,1,69,1,69,1,69,1,69,1,69,
		3,69,1244,8,69,1,70,1,70,3,70,1248,8,70,1,70,1,70,1,70,3,70,1253,8,70,
		1,71,1,71,1,72,1,72,1,73,1,73,1,74,1,74,1,74,3,74,1264,8,74,1,75,1,75,
		1,75,1,75,3,75,1270,8,75,1,76,1,76,3,76,1274,8,76,1,76,1,76,1,76,3,76,
		1279,8,76,1,77,1,77,3,77,1283,8,77,1,77,1,77,1,77,3,77,1288,8,77,1,78,
		3,78,1291,8,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,
		1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,3,78,1313,8,78,1,79,1,79,
		1,79,1,79,3,79,1319,8,79,1,80,1,80,1,80,1,80,1,80,1,80,1,80,1,80,1,80,
		3,80,1330,8,80,1,81,1,81,3,81,1334,8,81,1,81,3,81,1337,8,81,1,81,1,81,
		1,81,1,81,1,81,1,81,1,81,1,81,3,81,1347,8,81,1,81,1,81,1,81,1,81,3,81,
		1353,8,81,1,81,3,81,1356,8,81,1,82,1,82,1,83,1,83,1,83,3,83,1363,8,83,
		1,83,1,83,1,83,1,83,1,83,1,83,1,83,1,83,3,83,1373,8,83,1,84,1,84,3,84,
		1377,8,84,1,84,3,84,1380,8,84,1,84,3,84,1383,8,84,1,84,1,84,3,84,1387,
		8,84,1,84,1,84,1,84,3,84,1392,8,84,3,84,1394,8,84,1,85,1,85,3,85,1398,
		8,85,1,85,1,85,3,85,1402,8,85,1,85,1,85,1,86,1,86,1,86,1,86,1,86,3,86,
		1411,8,86,1,87,1,87,1,87,1,88,1,88,1,88,1,88,1,88,1,88,5,88,1422,8,88,
		10,88,12,88,1425,9,88,1,89,1,89,1,89,1,89,1,89,3,89,1432,8,89,1,90,1,90,
		1,91,1,91,3,91,1438,8,91,1,92,1,92,1,93,1,93,3,93,1444,8,93,1,94,1,94,
		3,94,1448,8,94,1,95,3,95,1451,8,95,1,95,1,95,1,95,1,95,1,95,1,95,1,96,
		3,96,1460,8,96,1,96,1,96,1,96,1,96,1,96,1,96,1,97,3,97,1469,8,97,1,97,
		1,97,1,97,1,97,1,97,1,98,3,98,1477,8,98,1,99,1,99,1,100,1,100,1,100,1,
		100,1,100,1,100,1,101,3,101,1488,8,101,1,101,1,101,1,102,1,102,3,102,1494,
		8,102,1,102,1,102,1,102,1,102,1,102,1,102,1,102,1,102,1,102,3,102,1505,
		8,102,1,103,3,103,1508,8,103,1,103,1,103,1,103,3,103,1513,8,103,1,103,
		1,103,1,103,1,104,1,104,1,104,1,104,1,104,1,104,1,105,1,105,1,105,1,105,
		3,105,1528,8,105,1,105,1,105,1,105,1,105,3,105,1534,8,105,1,106,1,106,
		1,106,1,106,1,106,5,106,1541,8,106,10,106,12,106,1544,9,106,1,107,1,107,
		1,107,1,107,1,107,1,107,1,107,3,107,1553,8,107,1,108,1,108,1,108,1,108,
		3,108,1559,8,108,1,108,1,108,1,108,1,108,1,108,1,108,3,108,1567,8,108,
		1,108,1,108,3,108,1571,8,108,1,109,1,109,3,109,1575,8,109,1,109,1,109,
		1,109,3,109,1580,8,109,1,109,1,109,1,109,3,109,1585,8,109,1,109,1,109,
		1,109,1,109,1,109,5,109,1592,8,109,10,109,12,109,1595,9,109,1,110,1,110,
		3,110,1599,8,110,1,111,1,111,3,111,1603,8,111,1,112,1,112,1,112,1,112,
		1,113,1,113,1,114,1,114,1,114,1,114,1,115,1,115,3,115,1617,8,115,1,115,
		1,115,5,115,1621,8,115,10,115,12,115,1624,9,115,1,116,1,116,1,116,1,116,
		1,116,1,116,1,116,1,116,1,116,1,116,1,116,1,116,1,116,4,116,1639,8,116,
		11,116,12,116,1640,3,116,1643,8,116,1,117,1,117,1,117,1,117,1,117,1,117,
		5,117,1651,8,117,10,117,12,117,1654,9,117,1,118,1,118,3,118,1658,8,118,
		1,119,1,119,1,119,1,119,1,119,3,119,1665,8,119,1,120,1,120,1,120,1,120,
		3,120,1671,8,120,1,121,1,121,1,121,3,121,1676,8,121,1,121,1,121,1,121,
		1,121,3,121,1682,8,121,1,121,1,121,1,121,1,121,1,121,3,121,1689,8,121,
		1,121,1,121,3,121,1693,8,121,5,121,1695,8,121,10,121,12,121,1698,9,121,
		1,122,1,122,1,122,1,122,3,122,1704,8,122,1,122,3,122,1707,8,122,1,122,
		3,122,1710,8,122,1,122,3,122,1713,8,122,1,123,1,123,1,123,3,123,1718,8,
		123,1,124,1,124,3,124,1722,8,124,1,124,3,124,1725,8,124,1,124,1,124,3,
		124,1729,8,124,1,124,1,124,3,124,1733,8,124,1,124,1,124,1,124,3,124,1738,
		8,124,1,124,3,124,1741,8,124,3,124,1743,8,124,1,125,1,125,3,125,1747,8,
		125,1,126,1,126,1,127,1,127,1,128,3,128,1754,8,128,1,128,1,128,1,129,1,
		129,3,129,1760,8,129,1,130,1,130,3,130,1764,8,130,1,130,1,130,1,130,1,
		130,3,130,1770,8,130,1,131,1,131,1,131,3,131,1775,8,131,3,131,1777,8,131,
		1,132,1,132,1,132,1,132,3,132,1783,8,132,1,132,1,132,3,132,1787,8,132,
		1,132,1,132,1,132,1,132,3,132,1793,8,132,1,132,1,132,1,132,1,132,1,132,
		3,132,1800,8,132,1,132,1,132,3,132,1804,8,132,5,132,1806,8,132,10,132,
		12,132,1809,9,132,1,133,1,133,1,133,1,133,3,133,1815,8,133,1,134,1,134,
		1,134,1,134,1,134,1,134,1,134,1,134,3,134,1825,8,134,1,134,1,134,3,134,
		1829,8,134,5,134,1831,8,134,10,134,12,134,1834,9,134,1,135,3,135,1837,
		8,135,1,135,3,135,1840,8,135,1,135,1,135,1,135,1,135,3,135,1846,8,135,
		1,136,1,136,1,136,1,136,1,136,1,136,5,136,1854,8,136,10,136,12,136,1857,
		9,136,1,137,3,137,1860,8,137,1,137,1,137,1,137,1,137,3,137,1866,8,137,
		1,137,1,137,1,137,1,137,1,137,1,137,3,137,1874,8,137,1,137,1,137,3,137,
		1878,8,137,1,137,3,137,1881,8,137,1,137,1,137,3,137,1885,8,137,1,137,1,
		137,1,137,3,137,1890,8,137,1,138,3,138,1893,8,138,1,138,3,138,1896,8,138,
		1,138,1,138,3,138,1900,8,138,1,138,1,138,1,139,3,139,1905,8,139,1,139,
		1,139,1,139,1,139,1,139,1,139,1,139,1,139,3,139,1915,8,139,1,140,1,140,
		1,140,1,140,1,140,3,140,1922,8,140,1,141,1,141,1,141,3,141,1927,8,141,
		1,142,1,142,3,142,1931,8,142,1,143,1,143,1,143,3,143,1936,8,143,1,143,
		1,143,1,143,1,143,3,143,1942,8,143,5,143,1944,8,143,10,143,12,143,1947,
		9,143,1,144,1,144,1,144,3,144,1952,8,144,1,144,1,144,1,144,1,144,3,144,
		1958,8,144,1,145,1,145,3,145,1962,8,145,1,146,1,146,1,146,3,146,1967,8,
		146,1,146,1,146,1,147,1,147,3,147,1973,8,147,1,147,1,147,3,147,1977,8,
		147,1,147,3,147,1980,8,147,1,147,1,147,3,147,1984,8,147,1,147,3,147,1987,
		8,147,3,147,1989,8,147,1,148,3,148,1992,8,148,1,148,1,148,1,149,1,149,
		1,150,1,150,1,151,1,151,3,151,2002,8,151,1,151,1,151,1,151,3,151,2007,
		8,151,3,151,2009,8,151,1,152,3,152,2012,8,152,1,152,3,152,2015,8,152,1,
		152,3,152,2018,8,152,1,152,1,152,1,152,1,152,1,152,1,152,1,152,3,152,2027,
		8,152,1,153,1,153,1,153,1,153,1,153,1,153,5,153,2035,8,153,10,153,12,153,
		2038,9,153,1,154,1,154,3,154,2042,8,154,1,154,3,154,2045,8,154,1,154,1,
		154,3,154,2049,8,154,1,154,3,154,2052,8,154,1,154,3,154,2055,8,154,1,154,
		1,154,3,154,2059,8,154,1,155,1,155,1,155,1,155,1,155,5,155,2066,8,155,
		10,155,12,155,2069,9,155,1,156,1,156,1,157,1,157,1,157,1,157,1,158,1,158,
		1,158,1,159,1,159,1,159,3,159,2083,8,159,1,159,1,159,1,159,1,159,3,159,
		2089,8,159,5,159,2091,8,159,10,159,12,159,2094,9,159,1,160,3,160,2097,
		8,160,1,160,1,160,3,160,2101,8,160,1,160,1,160,3,160,2105,8,160,1,160,
		1,160,3,160,2109,8,160,1,160,1,160,3,160,2113,8,160,1,160,1,160,3,160,
		2117,8,160,1,161,3,161,2120,8,161,1,161,1,161,3,161,2124,8,161,1,162,1,
		162,1,163,1,163,1,164,1,164,1,164,1,165,1,165,3,165,2135,8,165,1,166,1,
		166,3,166,2139,8,166,1,167,1,167,1,167,1,168,1,168,3,168,2146,8,168,1,
		168,1,168,3,168,2150,8,168,1,168,1,168,1,168,3,168,2155,8,168,1,169,1,
		169,1,169,3,169,2160,8,169,1,169,1,169,1,169,1,169,1,169,3,169,2167,8,
		169,1,170,1,170,3,170,2171,8,170,1,171,1,171,1,171,1,172,1,172,1,172,1,
		172,1,172,3,172,2181,8,172,1,173,1,173,1,173,1,173,1,173,1,173,1,174,1,
		174,1,174,1,174,1,174,1,174,5,174,2195,8,174,10,174,12,174,2198,9,174,
		1,175,1,175,3,175,2202,8,175,1,176,1,176,3,176,2206,8,176,1,176,3,176,
		2209,8,176,1,176,1,176,3,176,2213,8,176,1,176,1,176,1,176,1,176,3,176,
		2219,8,176,1,176,3,176,2222,8,176,1,176,1,176,3,176,2226,8,176,1,176,1,
		176,1,176,1,176,1,176,1,176,1,176,1,176,3,176,2236,8,176,1,176,3,176,2239,
		8,176,1,176,1,176,1,176,1,176,1,176,1,176,3,176,2247,8,176,1,176,1,176,
		1,176,3,176,2252,8,176,1,177,1,177,1,177,3,177,2257,8,177,1,177,1,177,
		1,178,1,178,1,178,1,178,3,178,2265,8,178,1,178,1,178,1,178,1,178,1,178,
		3,178,2272,8,178,1,178,1,178,3,178,2276,8,178,1,179,1,179,1,180,1,180,
		1,180,3,180,2283,8,180,1,180,1,180,1,180,1,180,3,180,2289,8,180,5,180,
		2291,8,180,10,180,12,180,2294,9,180,1,181,1,181,1,181,3,181,2299,8,181,
		1,182,1,182,1,182,1,182,1,182,1,182,1,182,3,182,2308,8,182,1,182,1,182,
		3,182,2312,8,182,1,183,3,183,2315,8,183,1,183,1,183,1,183,1,184,1,184,
		1,184,1,184,1,184,1,185,1,185,1,185,1,185,1,186,1,186,3,186,2331,8,186,
		1,186,1,186,1,186,1,187,1,187,3,187,2338,8,187,1,188,1,188,1,188,1,188,
		1,188,1,188,1,189,3,189,2347,8,189,1,189,1,189,1,189,1,189,3,189,2353,
		8,189,1,189,1,189,3,189,2357,8,189,1,189,3,189,2360,8,189,1,190,1,190,
		3,190,2364,8,190,1,191,1,191,3,191,2368,8,191,1,192,1,192,1,192,3,192,
		2373,8,192,1,192,1,192,1,193,1,193,1,193,3,193,2380,8,193,1,193,1,193,
		1,193,1,193,3,193,2386,8,193,5,193,2388,8,193,10,193,12,193,2391,9,193,
		1,194,1,194,1,194,1,194,1,194,1,194,3,194,2399,8,194,1,195,1,195,1,195,
		1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,
		1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,
		1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,
		1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,1,195,
		3,195,2452,8,195,1,196,1,196,1,196,1,196,1,196,1,196,1,196,3,196,2461,
		8,196,1,197,1,197,1,198,1,198,1,199,1,199,1,199,0,34,10,20,30,52,62,64,
		66,68,72,74,76,78,80,82,84,92,104,122,176,212,218,230,234,242,264,268,
		272,286,306,310,318,348,360,386,200,0,2,4,6,8,10,12,14,16,18,20,22,24,
		26,28,30,32,34,36,38,40,42,44,46,48,50,52,54,56,58,60,62,64,66,68,70,72,
		74,76,78,80,82,84,86,88,90,92,94,96,98,100,102,104,106,108,110,112,114,
		116,118,120,122,124,126,128,130,132,134,136,138,140,142,144,146,148,150,
		152,154,156,158,160,162,164,166,168,170,172,174,176,178,180,182,184,186,
		188,190,192,194,196,198,200,202,204,206,208,210,212,214,216,218,220,222,
		224,226,228,230,232,234,236,238,240,242,244,246,248,250,252,254,256,258,
		260,262,264,266,268,270,272,274,276,278,280,282,284,286,288,290,292,294,
		296,298,300,302,304,306,308,310,312,314,316,318,320,322,324,326,328,330,
		332,334,336,338,340,342,344,346,348,350,352,354,356,358,360,362,364,366,
		368,370,372,374,376,378,380,382,384,386,388,390,392,394,396,398,0,14,2,
		0,96,96,100,100,3,0,1,2,90,92,96,98,1,0,111,112,3,0,100,100,103,110,113,
		114,5,0,35,35,46,46,56,56,62,62,69,69,3,0,33,33,43,43,79,79,1,0,84,89,
		2,0,21,21,81,81,2,0,3,3,96,96,3,0,20,20,65,65,76,76,2,0,37,37,52,52,1,
		0,53,55,2,0,36,36,71,71,1,0,143,146,2753,0,401,1,0,0,0,2,413,1,0,0,0,4,
		417,1,0,0,0,6,428,1,0,0,0,8,430,1,0,0,0,10,447,1,0,0,0,12,464,1,0,0,0,
		14,470,1,0,0,0,16,482,1,0,0,0,18,484,1,0,0,0,20,486,1,0,0,0,22,504,1,0,
		0,0,24,510,1,0,0,0,26,517,1,0,0,0,28,519,1,0,0,0,30,598,1,0,0,0,32,643,
		1,0,0,0,34,645,1,0,0,0,36,647,1,0,0,0,38,671,1,0,0,0,40,701,1,0,0,0,42,
		703,1,0,0,0,44,729,1,0,0,0,46,731,1,0,0,0,48,735,1,0,0,0,50,744,1,0,0,
		0,52,746,1,0,0,0,54,771,1,0,0,0,56,785,1,0,0,0,58,787,1,0,0,0,60,798,1,
		0,0,0,62,800,1,0,0,0,64,814,1,0,0,0,66,831,1,0,0,0,68,845,1,0,0,0,70,857,
		1,0,0,0,72,859,1,0,0,0,74,879,1,0,0,0,76,893,1,0,0,0,78,904,1,0,0,0,80,
		915,1,0,0,0,82,926,1,0,0,0,84,940,1,0,0,0,86,961,1,0,0,0,88,969,1,0,0,
		0,90,971,1,0,0,0,92,973,1,0,0,0,94,984,1,0,0,0,96,1012,1,0,0,0,98,1034,
		1,0,0,0,100,1037,1,0,0,0,102,1041,1,0,0,0,104,1047,1,0,0,0,106,1077,1,
		0,0,0,108,1095,1,0,0,0,110,1132,1,0,0,0,112,1136,1,0,0,0,114,1139,1,0,
		0,0,116,1146,1,0,0,0,118,1164,1,0,0,0,120,1166,1,0,0,0,122,1168,1,0,0,
		0,124,1187,1,0,0,0,126,1197,1,0,0,0,128,1199,1,0,0,0,130,1222,1,0,0,0,
		132,1224,1,0,0,0,134,1232,1,0,0,0,136,1234,1,0,0,0,138,1243,1,0,0,0,140,
		1252,1,0,0,0,142,1254,1,0,0,0,144,1256,1,0,0,0,146,1258,1,0,0,0,148,1263,
		1,0,0,0,150,1269,1,0,0,0,152,1278,1,0,0,0,154,1287,1,0,0,0,156,1312,1,
		0,0,0,158,1318,1,0,0,0,160,1329,1,0,0,0,162,1355,1,0,0,0,164,1357,1,0,
		0,0,166,1372,1,0,0,0,168,1393,1,0,0,0,170,1395,1,0,0,0,172,1410,1,0,0,
		0,174,1412,1,0,0,0,176,1415,1,0,0,0,178,1431,1,0,0,0,180,1433,1,0,0,0,
		182,1437,1,0,0,0,184,1439,1,0,0,0,186,1443,1,0,0,0,188,1447,1,0,0,0,190,
		1450,1,0,0,0,192,1459,1,0,0,0,194,1468,1,0,0,0,196,1476,1,0,0,0,198,1478,
		1,0,0,0,200,1480,1,0,0,0,202,1487,1,0,0,0,204,1504,1,0,0,0,206,1507,1,
		0,0,0,208,1517,1,0,0,0,210,1533,1,0,0,0,212,1535,1,0,0,0,214,1552,1,0,
		0,0,216,1570,1,0,0,0,218,1579,1,0,0,0,220,1596,1,0,0,0,222,1602,1,0,0,
		0,224,1604,1,0,0,0,226,1608,1,0,0,0,228,1610,1,0,0,0,230,1614,1,0,0,0,
		232,1642,1,0,0,0,234,1644,1,0,0,0,236,1655,1,0,0,0,238,1664,1,0,0,0,240,
		1670,1,0,0,0,242,1681,1,0,0,0,244,1699,1,0,0,0,246,1714,1,0,0,0,248,1742,
		1,0,0,0,250,1744,1,0,0,0,252,1748,1,0,0,0,254,1750,1,0,0,0,256,1753,1,
		0,0,0,258,1757,1,0,0,0,260,1769,1,0,0,0,262,1776,1,0,0,0,264,1792,1,0,
		0,0,266,1814,1,0,0,0,268,1816,1,0,0,0,270,1845,1,0,0,0,272,1847,1,0,0,
		0,274,1889,1,0,0,0,276,1892,1,0,0,0,278,1914,1,0,0,0,280,1921,1,0,0,0,
		282,1926,1,0,0,0,284,1930,1,0,0,0,286,1932,1,0,0,0,288,1957,1,0,0,0,290,
		1961,1,0,0,0,292,1963,1,0,0,0,294,1988,1,0,0,0,296,1991,1,0,0,0,298,1995,
		1,0,0,0,300,1997,1,0,0,0,302,2008,1,0,0,0,304,2026,1,0,0,0,306,2028,1,
		0,0,0,308,2058,1,0,0,0,310,2060,1,0,0,0,312,2070,1,0,0,0,314,2072,1,0,
		0,0,316,2076,1,0,0,0,318,2079,1,0,0,0,320,2116,1,0,0,0,322,2123,1,0,0,
		0,324,2125,1,0,0,0,326,2127,1,0,0,0,328,2129,1,0,0,0,330,2132,1,0,0,0,
		332,2136,1,0,0,0,334,2140,1,0,0,0,336,2154,1,0,0,0,338,2166,1,0,0,0,340,
		2170,1,0,0,0,342,2172,1,0,0,0,344,2180,1,0,0,0,346,2182,1,0,0,0,348,2188,
		1,0,0,0,350,2201,1,0,0,0,352,2251,1,0,0,0,354,2253,1,0,0,0,356,2275,1,
		0,0,0,358,2277,1,0,0,0,360,2279,1,0,0,0,362,2298,1,0,0,0,364,2311,1,0,
		0,0,366,2314,1,0,0,0,368,2319,1,0,0,0,370,2324,1,0,0,0,372,2328,1,0,0,
		0,374,2335,1,0,0,0,376,2339,1,0,0,0,378,2359,1,0,0,0,380,2361,1,0,0,0,
		382,2367,1,0,0,0,384,2369,1,0,0,0,386,2376,1,0,0,0,388,2398,1,0,0,0,390,
		2451,1,0,0,0,392,2460,1,0,0,0,394,2462,1,0,0,0,396,2464,1,0,0,0,398,2466,
		1,0,0,0,400,402,3,122,61,0,401,400,1,0,0,0,401,402,1,0,0,0,402,403,1,0,
		0,0,403,404,5,0,0,1,404,1,1,0,0,0,405,414,3,392,196,0,406,414,5,68,0,0,
		407,408,5,84,0,0,408,409,3,92,46,0,409,410,5,85,0,0,410,414,1,0,0,0,411,
		414,3,4,2,0,412,414,3,12,6,0,413,405,1,0,0,0,413,406,1,0,0,0,413,407,1,
		0,0,0,413,411,1,0,0,0,413,412,1,0,0,0,414,3,1,0,0,0,415,418,3,6,3,0,416,
		418,3,8,4,0,417,415,1,0,0,0,417,416,1,0,0,0,418,5,1,0,0,0,419,429,5,133,
		0,0,420,429,3,342,171,0,421,429,3,328,164,0,422,429,3,344,172,0,423,424,
		5,98,0,0,424,429,3,290,145,0,425,426,5,98,0,0,426,429,3,160,80,0,427,429,
		3,356,178,0,428,419,1,0,0,0,428,420,1,0,0,0,428,421,1,0,0,0,428,422,1,
		0,0,0,428,423,1,0,0,0,428,425,1,0,0,0,428,427,1,0,0,0,429,7,1,0,0,0,430,
		432,3,10,5,0,431,433,5,67,0,0,432,431,1,0,0,0,432,433,1,0,0,0,433,434,
		1,0,0,0,434,435,3,6,3,0,435,9,1,0,0,0,436,437,6,5,-1,0,437,448,5,128,0,
		0,438,439,3,158,79,0,439,440,5,128,0,0,440,448,1,0,0,0,441,442,3,182,91,
		0,442,443,5,128,0,0,443,448,1,0,0,0,444,445,3,160,80,0,445,446,5,128,0,
		0,446,448,1,0,0,0,447,436,1,0,0,0,447,438,1,0,0,0,447,441,1,0,0,0,447,
		444,1,0,0,0,448,461,1,0,0,0,449,450,10,2,0,0,450,451,5,133,0,0,451,460,
		5,128,0,0,452,454,10,1,0,0,453,455,5,67,0,0,454,453,1,0,0,0,454,455,1,
		0,0,0,455,456,1,0,0,0,456,457,3,354,177,0,457,458,5,128,0,0,458,460,1,
		0,0,0,459,449,1,0,0,0,459,452,1,0,0,0,460,463,1,0,0,0,461,459,1,0,0,0,
		461,462,1,0,0,0,462,11,1,0,0,0,463,461,1,0,0,0,464,466,3,14,7,0,465,467,
		3,28,14,0,466,465,1,0,0,0,466,467,1,0,0,0,467,468,1,0,0,0,468,469,3,102,
		51,0,469,13,1,0,0,0,470,472,5,86,0,0,471,473,3,16,8,0,472,471,1,0,0,0,
		472,473,1,0,0,0,473,474,1,0,0,0,474,475,5,87,0,0,475,15,1,0,0,0,476,483,
		3,18,9,0,477,483,3,20,10,0,478,479,3,18,9,0,479,480,5,123,0,0,480,481,
		3,20,10,0,481,483,1,0,0,0,482,476,1,0,0,0,482,477,1,0,0,0,482,478,1,0,
		0,0,483,17,1,0,0,0,484,485,7,0,0,0,485,19,1,0,0,0,486,487,6,10,-1,0,487,
		489,3,22,11,0,488,490,5,132,0,0,489,488,1,0,0,0,489,490,1,0,0,0,490,499,
		1,0,0,0,491,492,10,1,0,0,492,493,5,123,0,0,493,495,3,22,11,0,494,496,5,
		132,0,0,495,494,1,0,0,0,495,496,1,0,0,0,496,498,1,0,0,0,497,491,1,0,0,
		0,498,501,1,0,0,0,499,497,1,0,0,0,499,500,1,0,0,0,500,21,1,0,0,0,501,499,
		1,0,0,0,502,505,3,24,12,0,503,505,3,26,13,0,504,502,1,0,0,0,504,503,1,
		0,0,0,505,23,1,0,0,0,506,511,5,133,0,0,507,508,5,96,0,0,508,511,5,133,
		0,0,509,511,5,68,0,0,510,506,1,0,0,0,510,507,1,0,0,0,510,509,1,0,0,0,511,
		25,1,0,0,0,512,513,5,133,0,0,513,518,3,280,140,0,514,515,5,96,0,0,515,
		516,5,133,0,0,516,518,3,280,140,0,517,512,1,0,0,0,517,514,1,0,0,0,518,
		27,1,0,0,0,519,520,5,84,0,0,520,521,3,270,135,0,521,523,5,85,0,0,522,524,
		5,46,0,0,523,522,1,0,0,0,523,524,1,0,0,0,524,526,1,0,0,0,525,527,3,382,
		191,0,526,525,1,0,0,0,526,527,1,0,0,0,527,529,1,0,0,0,528,530,3,212,106,
		0,529,528,1,0,0,0,529,530,1,0,0,0,530,532,1,0,0,0,531,533,3,246,123,0,
		532,531,1,0,0,0,532,533,1,0,0,0,533,29,1,0,0,0,534,535,6,15,-1,0,535,599,
		3,2,1,0,536,537,3,156,78,0,537,539,5,84,0,0,538,540,3,36,18,0,539,538,
		1,0,0,0,539,540,1,0,0,0,540,541,1,0,0,0,541,542,5,85,0,0,542,599,1,0,0,
		0,543,544,3,364,182,0,544,546,5,84,0,0,545,547,3,36,18,0,546,545,1,0,0,
		0,546,547,1,0,0,0,547,548,1,0,0,0,548,549,5,85,0,0,549,599,1,0,0,0,550,
		551,3,156,78,0,551,552,3,288,144,0,552,599,1,0,0,0,553,554,3,364,182,0,
		554,555,3,288,144,0,555,599,1,0,0,0,556,557,5,30,0,0,557,558,5,101,0,0,
		558,559,3,258,129,0,559,560,5,102,0,0,560,561,5,84,0,0,561,562,3,92,46,
		0,562,563,5,85,0,0,563,599,1,0,0,0,564,565,5,64,0,0,565,566,5,101,0,0,
		566,567,3,258,129,0,567,568,5,102,0,0,568,569,5,84,0,0,569,570,3,92,46,
		0,570,571,5,85,0,0,571,599,1,0,0,0,572,573,5,57,0,0,573,574,5,101,0,0,
		574,575,3,258,129,0,575,576,5,102,0,0,576,577,5,84,0,0,577,578,3,92,46,
		0,578,579,5,85,0,0,579,599,1,0,0,0,580,581,5,23,0,0,581,582,5,101,0,0,
		582,583,3,258,129,0,583,584,5,102,0,0,584,585,5,84,0,0,585,586,3,92,46,
		0,586,587,5,85,0,0,587,599,1,0,0,0,588,589,3,34,17,0,589,590,5,84,0,0,
		590,591,3,92,46,0,591,592,5,85,0,0,592,599,1,0,0,0,593,594,3,34,17,0,594,
		595,5,84,0,0,595,596,3,258,129,0,596,597,5,85,0,0,597,599,1,0,0,0,598,
		534,1,0,0,0,598,536,1,0,0,0,598,543,1,0,0,0,598,550,1,0,0,0,598,553,1,
		0,0,0,598,556,1,0,0,0,598,564,1,0,0,0,598,572,1,0,0,0,598,580,1,0,0,0,
		598,588,1,0,0,0,598,593,1,0,0,0,599,640,1,0,0,0,600,601,10,19,0,0,601,
		602,5,86,0,0,602,603,3,92,46,0,603,604,5,87,0,0,604,639,1,0,0,0,605,606,
		10,18,0,0,606,607,5,86,0,0,607,608,3,288,144,0,608,609,5,87,0,0,609,639,
		1,0,0,0,610,611,10,17,0,0,611,613,5,84,0,0,612,614,3,36,18,0,613,612,1,
		0,0,0,613,614,1,0,0,0,614,615,1,0,0,0,615,639,5,85,0,0,616,617,10,12,0,
		0,617,619,5,130,0,0,618,620,5,67,0,0,619,618,1,0,0,0,619,620,1,0,0,0,620,
		621,1,0,0,0,621,639,3,4,2,0,622,623,10,11,0,0,623,625,5,125,0,0,624,626,
		5,67,0,0,625,624,1,0,0,0,625,626,1,0,0,0,626,627,1,0,0,0,627,639,3,4,2,
		0,628,629,10,10,0,0,629,630,5,130,0,0,630,639,3,38,19,0,631,632,10,9,0,
		0,632,633,5,125,0,0,633,639,3,38,19,0,634,635,10,8,0,0,635,639,5,121,0,
		0,636,637,10,7,0,0,637,639,5,122,0,0,638,600,1,0,0,0,638,605,1,0,0,0,638,
		610,1,0,0,0,638,616,1,0,0,0,638,622,1,0,0,0,638,628,1,0,0,0,638,631,1,
		0,0,0,638,634,1,0,0,0,638,636,1,0,0,0,639,642,1,0,0,0,640,638,1,0,0,0,
		640,641,1,0,0,0,641,31,1,0,0,0,642,640,1,0,0,0,643,644,5,74,0,0,644,33,
		1,0,0,0,645,646,5,74,0,0,646,35,1,0,0,0,647,648,3,286,143,0,648,37,1,0,
		0,0,649,651,3,10,5,0,650,649,1,0,0,0,650,651,1,0,0,0,651,652,1,0,0,0,652,
		653,3,158,79,0,653,654,5,128,0,0,654,655,5,98,0,0,655,656,3,158,79,0,656,
		672,1,0,0,0,657,658,3,10,5,0,658,659,5,67,0,0,659,660,3,354,177,0,660,
		661,5,128,0,0,661,662,5,98,0,0,662,663,3,158,79,0,663,672,1,0,0,0,664,
		666,3,10,5,0,665,664,1,0,0,0,665,666,1,0,0,0,666,667,1,0,0,0,667,668,5,
		98,0,0,668,672,3,158,79,0,669,670,5,98,0,0,670,672,3,160,80,0,671,650,
		1,0,0,0,671,657,1,0,0,0,671,665,1,0,0,0,671,669,1,0,0,0,672,39,1,0,0,0,
		673,702,3,30,15,0,674,675,5,121,0,0,675,702,3,60,30,0,676,677,5,122,0,
		0,677,702,3,60,30,0,678,679,3,42,21,0,679,680,3,60,30,0,680,702,1,0,0,
		0,681,682,5,61,0,0,682,702,3,40,20,0,683,684,5,61,0,0,684,685,5,84,0,0,
		685,686,3,258,129,0,686,687,5,85,0,0,687,702,1,0,0,0,688,689,5,61,0,0,
		689,690,5,132,0,0,690,691,5,84,0,0,691,692,5,133,0,0,692,702,5,85,0,0,
		693,694,5,10,0,0,694,695,5,84,0,0,695,696,3,258,129,0,696,697,5,85,0,0,
		697,702,1,0,0,0,698,702,3,58,29,0,699,702,3,44,22,0,700,702,3,56,28,0,
		701,673,1,0,0,0,701,674,1,0,0,0,701,676,1,0,0,0,701,678,1,0,0,0,701,681,
		1,0,0,0,701,683,1,0,0,0,701,688,1,0,0,0,701,693,1,0,0,0,701,698,1,0,0,
		0,701,699,1,0,0,0,701,700,1,0,0,0,702,41,1,0,0,0,703,704,7,1,0,0,704,43,
		1,0,0,0,705,707,5,128,0,0,706,705,1,0,0,0,706,707,1,0,0,0,707,708,1,0,
		0,0,708,710,5,48,0,0,709,711,3,46,23,0,710,709,1,0,0,0,710,711,1,0,0,0,
		711,712,1,0,0,0,712,714,3,48,24,0,713,715,3,54,27,0,714,713,1,0,0,0,714,
		715,1,0,0,0,715,730,1,0,0,0,716,718,5,128,0,0,717,716,1,0,0,0,717,718,
		1,0,0,0,718,719,1,0,0,0,719,721,5,48,0,0,720,722,3,46,23,0,721,720,1,0,
		0,0,721,722,1,0,0,0,722,723,1,0,0,0,723,724,5,84,0,0,724,725,3,258,129,
		0,725,727,5,85,0,0,726,728,3,54,27,0,727,726,1,0,0,0,727,728,1,0,0,0,728,
		730,1,0,0,0,729,706,1,0,0,0,729,717,1,0,0,0,730,45,1,0,0,0,731,732,5,84,
		0,0,732,733,3,36,18,0,733,734,5,85,0,0,734,47,1,0,0,0,735,737,3,152,76,
		0,736,738,3,50,25,0,737,736,1,0,0,0,737,738,1,0,0,0,738,49,1,0,0,0,739,
		741,3,248,124,0,740,742,3,50,25,0,741,740,1,0,0,0,741,742,1,0,0,0,742,
		745,1,0,0,0,743,745,3,52,26,0,744,739,1,0,0,0,744,743,1,0,0,0,745,51,1,
		0,0,0,746,747,6,26,-1,0,747,748,5,86,0,0,748,749,3,92,46,0,749,751,5,87,
		0,0,750,752,3,212,106,0,751,750,1,0,0,0,751,752,1,0,0,0,752,762,1,0,0,
		0,753,754,10,1,0,0,754,755,5,86,0,0,755,756,3,94,47,0,756,758,5,87,0,0,
		757,759,3,212,106,0,758,757,1,0,0,0,758,759,1,0,0,0,759,761,1,0,0,0,760,
		753,1,0,0,0,761,764,1,0,0,0,762,760,1,0,0,0,762,763,1,0,0,0,763,53,1,0,
		0,0,764,762,1,0,0,0,765,767,5,84,0,0,766,768,3,36,18,0,767,766,1,0,0,0,
		767,768,1,0,0,0,768,769,1,0,0,0,769,772,5,85,0,0,770,772,3,288,144,0,771,
		765,1,0,0,0,771,770,1,0,0,0,772,55,1,0,0,0,773,775,5,128,0,0,774,773,1,
		0,0,0,774,775,1,0,0,0,775,776,1,0,0,0,776,777,5,27,0,0,777,786,3,60,30,
		0,778,780,5,128,0,0,779,778,1,0,0,0,779,780,1,0,0,0,780,781,1,0,0,0,781,
		782,5,27,0,0,782,783,5,86,0,0,783,784,5,87,0,0,784,786,3,60,30,0,785,774,
		1,0,0,0,785,779,1,0,0,0,786,57,1,0,0,0,787,788,5,49,0,0,788,789,5,84,0,
		0,789,790,3,92,46,0,790,791,5,85,0,0,791,59,1,0,0,0,792,799,3,40,20,0,
		793,794,5,84,0,0,794,795,3,258,129,0,795,796,5,85,0,0,796,797,3,60,30,
		0,797,799,1,0,0,0,798,792,1,0,0,0,798,793,1,0,0,0,799,61,1,0,0,0,800,801,
		6,31,-1,0,801,802,3,60,30,0,802,811,1,0,0,0,803,804,10,2,0,0,804,805,5,
		131,0,0,805,810,3,60,30,0,806,807,10,1,0,0,807,808,5,124,0,0,808,810,3,
		60,30,0,809,803,1,0,0,0,809,806,1,0,0,0,810,813,1,0,0,0,811,809,1,0,0,
		0,811,812,1,0,0,0,812,63,1,0,0,0,813,811,1,0,0,0,814,815,6,32,-1,0,815,
		816,3,62,31,0,816,828,1,0,0,0,817,818,10,3,0,0,818,819,5,92,0,0,819,827,
		3,62,31,0,820,821,10,2,0,0,821,822,5,93,0,0,822,827,3,62,31,0,823,824,
		10,1,0,0,824,825,5,94,0,0,825,827,3,62,31,0,826,817,1,0,0,0,826,820,1,
		0,0,0,826,823,1,0,0,0,827,830,1,0,0,0,828,826,1,0,0,0,828,829,1,0,0,0,
		829,65,1,0,0,0,830,828,1,0,0,0,831,832,6,33,-1,0,832,833,3,64,32,0,833,
		842,1,0,0,0,834,835,10,2,0,0,835,836,5,90,0,0,836,841,3,64,32,0,837,838,
		10,1,0,0,838,839,5,91,0,0,839,841,3,64,32,0,840,834,1,0,0,0,840,837,1,
		0,0,0,841,844,1,0,0,0,842,840,1,0,0,0,842,843,1,0,0,0,843,67,1,0,0,0,844,
		842,1,0,0,0,845,846,6,34,-1,0,846,847,3,66,33,0,847,854,1,0,0,0,848,849,
		10,1,0,0,849,850,3,70,35,0,850,851,3,66,33,0,851,853,1,0,0,0,852,848,1,
		0,0,0,853,856,1,0,0,0,854,852,1,0,0,0,854,855,1,0,0,0,855,69,1,0,0,0,856,
		854,1,0,0,0,857,858,7,2,0,0,858,71,1,0,0,0,859,860,6,36,-1,0,860,861,3,
		68,34,0,861,876,1,0,0,0,862,863,10,4,0,0,863,864,5,101,0,0,864,875,3,68,
		34,0,865,866,10,3,0,0,866,867,5,102,0,0,867,875,3,68,34,0,868,869,10,2,
		0,0,869,870,5,117,0,0,870,875,3,68,34,0,871,872,10,1,0,0,872,873,5,118,
		0,0,873,875,3,68,34,0,874,862,1,0,0,0,874,865,1,0,0,0,874,868,1,0,0,0,
		874,871,1,0,0,0,875,878,1,0,0,0,876,874,1,0,0,0,876,877,1,0,0,0,877,73,
		1,0,0,0,878,876,1,0,0,0,879,880,6,37,-1,0,880,881,3,72,36,0,881,890,1,
		0,0,0,882,883,10,2,0,0,883,884,5,115,0,0,884,889,3,72,36,0,885,886,10,
		1,0,0,886,887,5,116,0,0,887,889,3,72,36,0,888,882,1,0,0,0,888,885,1,0,
		0,0,889,892,1,0,0,0,890,888,1,0,0,0,890,891,1,0,0,0,891,75,1,0,0,0,892,
		890,1,0,0,0,893,894,6,38,-1,0,894,895,3,74,37,0,895,901,1,0,0,0,896,897,
		10,1,0,0,897,898,5,96,0,0,898,900,3,74,37,0,899,896,1,0,0,0,900,903,1,
		0,0,0,901,899,1,0,0,0,901,902,1,0,0,0,902,77,1,0,0,0,903,901,1,0,0,0,904,
		905,6,39,-1,0,905,906,3,76,38,0,906,912,1,0,0,0,907,908,10,1,0,0,908,909,
		5,95,0,0,909,911,3,76,38,0,910,907,1,0,0,0,911,914,1,0,0,0,912,910,1,0,
		0,0,912,913,1,0,0,0,913,79,1,0,0,0,914,912,1,0,0,0,915,916,6,40,-1,0,916,
		917,3,78,39,0,917,923,1,0,0,0,918,919,10,1,0,0,919,920,5,97,0,0,920,922,
		3,78,39,0,921,918,1,0,0,0,922,925,1,0,0,0,923,921,1,0,0,0,923,924,1,0,
		0,0,924,81,1,0,0,0,925,923,1,0,0,0,926,927,6,41,-1,0,927,928,3,80,40,0,
		928,937,1,0,0,0,929,930,10,2,0,0,930,931,5,3,0,0,931,936,3,80,40,0,932,
		933,10,1,0,0,933,934,5,4,0,0,934,936,3,80,40,0,935,929,1,0,0,0,935,932,
		1,0,0,0,936,939,1,0,0,0,937,935,1,0,0,0,937,938,1,0,0,0,938,83,1,0,0,0,
		939,937,1,0,0,0,940,941,6,42,-1,0,941,942,3,82,41,0,942,951,1,0,0,0,943,
		944,10,2,0,0,944,945,5,5,0,0,945,950,3,82,41,0,946,947,10,1,0,0,947,948,
		5,6,0,0,948,950,3,82,41,0,949,943,1,0,0,0,949,946,1,0,0,0,950,953,1,0,
		0,0,951,949,1,0,0,0,951,952,1,0,0,0,952,85,1,0,0,0,953,951,1,0,0,0,954,
		962,3,84,42,0,955,956,3,84,42,0,956,957,5,126,0,0,957,958,3,92,46,0,958,
		959,5,127,0,0,959,960,3,88,44,0,960,962,1,0,0,0,961,954,1,0,0,0,961,955,
		1,0,0,0,962,87,1,0,0,0,963,970,3,86,43,0,964,965,3,84,42,0,965,966,3,90,
		45,0,966,967,3,284,142,0,967,970,1,0,0,0,968,970,3,380,190,0,969,963,1,
		0,0,0,969,964,1,0,0,0,969,968,1,0,0,0,970,89,1,0,0,0,971,972,7,3,0,0,972,
		91,1,0,0,0,973,974,6,46,-1,0,974,975,3,88,44,0,975,981,1,0,0,0,976,977,
		10,1,0,0,977,978,5,123,0,0,978,980,3,88,44,0,979,976,1,0,0,0,980,983,1,
		0,0,0,981,979,1,0,0,0,981,982,1,0,0,0,982,93,1,0,0,0,983,981,1,0,0,0,984,
		985,3,86,43,0,985,95,1,0,0,0,986,1013,3,98,49,0,987,989,3,212,106,0,988,
		987,1,0,0,0,988,989,1,0,0,0,989,990,1,0,0,0,990,1013,3,100,50,0,991,993,
		3,212,106,0,992,991,1,0,0,0,992,993,1,0,0,0,993,994,1,0,0,0,994,1013,3,
		102,51,0,995,997,3,212,106,0,996,995,1,0,0,0,996,997,1,0,0,0,997,998,1,
		0,0,0,998,1013,3,106,53,0,999,1001,3,212,106,0,1000,999,1,0,0,0,1000,1001,
		1,0,0,0,1001,1002,1,0,0,0,1002,1013,3,110,55,0,1003,1005,3,212,106,0,1004,
		1003,1,0,0,0,1004,1005,1,0,0,0,1005,1006,1,0,0,0,1006,1013,3,118,59,0,
		1007,1013,3,120,60,0,1008,1010,3,212,106,0,1009,1008,1,0,0,0,1009,1010,
		1,0,0,0,1010,1011,1,0,0,0,1011,1013,3,370,185,0,1012,986,1,0,0,0,1012,
		988,1,0,0,0,1012,992,1,0,0,0,1012,996,1,0,0,0,1012,1000,1,0,0,0,1012,1004,
		1,0,0,0,1012,1007,1,0,0,0,1012,1009,1,0,0,0,1013,97,1,0,0,0,1014,1016,
		3,212,106,0,1015,1014,1,0,0,0,1015,1016,1,0,0,0,1016,1017,1,0,0,0,1017,
		1018,5,133,0,0,1018,1019,5,127,0,0,1019,1035,3,96,48,0,1020,1022,3,212,
		106,0,1021,1020,1,0,0,0,1021,1022,1,0,0,0,1022,1023,1,0,0,0,1023,1024,
		5,15,0,0,1024,1025,3,94,47,0,1025,1026,5,127,0,0,1026,1027,3,96,48,0,1027,
		1035,1,0,0,0,1028,1030,3,212,106,0,1029,1028,1,0,0,0,1029,1030,1,0,0,0,
		1030,1031,1,0,0,0,1031,1032,5,26,0,0,1032,1033,5,127,0,0,1033,1035,3,96,
		48,0,1034,1015,1,0,0,0,1034,1021,1,0,0,0,1034,1029,1,0,0,0,1035,99,1,0,
		0,0,1036,1038,3,92,46,0,1037,1036,1,0,0,0,1037,1038,1,0,0,0,1038,1039,
		1,0,0,0,1039,1040,5,129,0,0,1040,101,1,0,0,0,1041,1043,5,88,0,0,1042,1044,
		3,104,52,0,1043,1042,1,0,0,0,1043,1044,1,0,0,0,1044,1045,1,0,0,0,1045,
		1046,5,89,0,0,1046,103,1,0,0,0,1047,1048,6,52,-1,0,1048,1049,3,96,48,0,
		1049,1054,1,0,0,0,1050,1051,10,1,0,0,1051,1053,3,96,48,0,1052,1050,1,0,
		0,0,1053,1056,1,0,0,0,1054,1052,1,0,0,0,1054,1055,1,0,0,0,1055,105,1,0,
		0,0,1056,1054,1,0,0,0,1057,1058,5,42,0,0,1058,1059,5,84,0,0,1059,1060,
		3,108,54,0,1060,1061,5,85,0,0,1061,1062,3,96,48,0,1062,1078,1,0,0,0,1063,
		1064,5,42,0,0,1064,1065,5,84,0,0,1065,1066,3,108,54,0,1066,1067,5,85,0,
		0,1067,1068,3,96,48,0,1068,1069,5,31,0,0,1069,1070,3,96,48,0,1070,1078,
		1,0,0,0,1071,1072,5,66,0,0,1072,1073,5,84,0,0,1073,1074,3,108,54,0,1074,
		1075,5,85,0,0,1075,1076,3,96,48,0,1076,1078,1,0,0,0,1077,1057,1,0,0,0,
		1077,1063,1,0,0,0,1077,1071,1,0,0,0,1078,107,1,0,0,0,1079,1096,3,92,46,
		0,1080,1082,3,212,106,0,1081,1080,1,0,0,0,1081,1082,1,0,0,0,1082,1083,
		1,0,0,0,1083,1084,3,140,70,0,1084,1085,3,238,119,0,1085,1086,5,100,0,0,
		1086,1087,3,284,142,0,1087,1096,1,0,0,0,1088,1090,3,212,106,0,1089,1088,
		1,0,0,0,1089,1090,1,0,0,0,1090,1091,1,0,0,0,1091,1092,3,140,70,0,1092,
		1093,3,238,119,0,1093,1094,3,288,144,0,1094,1096,1,0,0,0,1095,1079,1,0,
		0,0,1095,1081,1,0,0,0,1095,1089,1,0,0,0,1096,109,1,0,0,0,1097,1098,5,83,
		0,0,1098,1099,5,84,0,0,1099,1100,3,108,54,0,1100,1101,5,85,0,0,1101,1102,
		3,96,48,0,1102,1133,1,0,0,0,1103,1104,5,28,0,0,1104,1105,3,96,48,0,1105,
		1106,5,83,0,0,1106,1107,5,84,0,0,1107,1108,3,92,46,0,1108,1109,5,85,0,
		0,1109,1110,5,129,0,0,1110,1133,1,0,0,0,1111,1112,5,39,0,0,1112,1113,5,
		84,0,0,1113,1115,3,112,56,0,1114,1116,3,108,54,0,1115,1114,1,0,0,0,1115,
		1116,1,0,0,0,1116,1117,1,0,0,0,1117,1119,5,129,0,0,1118,1120,3,92,46,0,
		1119,1118,1,0,0,0,1119,1120,1,0,0,0,1120,1121,1,0,0,0,1121,1122,5,85,0,
		0,1122,1123,3,96,48,0,1123,1133,1,0,0,0,1124,1125,5,39,0,0,1125,1126,5,
		84,0,0,1126,1127,3,114,57,0,1127,1128,5,127,0,0,1128,1129,3,116,58,0,1129,
		1130,5,85,0,0,1130,1131,3,96,48,0,1131,1133,1,0,0,0,1132,1097,1,0,0,0,
		1132,1103,1,0,0,0,1132,1111,1,0,0,0,1132,1124,1,0,0,0,1133,111,1,0,0,0,
		1134,1137,3,100,50,0,1135,1137,3,130,65,0,1136,1134,1,0,0,0,1136,1135,
		1,0,0,0,1137,113,1,0,0,0,1138,1140,3,212,106,0,1139,1138,1,0,0,0,1139,
		1140,1,0,0,0,1140,1141,1,0,0,0,1141,1142,3,140,70,0,1142,1143,3,238,119,
		0,1143,115,1,0,0,0,1144,1147,3,92,46,0,1145,1147,3,288,144,0,1146,1144,
		1,0,0,0,1146,1145,1,0,0,0,1147,117,1,0,0,0,1148,1149,5,14,0,0,1149,1165,
		5,129,0,0,1150,1151,5,24,0,0,1151,1165,5,129,0,0,1152,1154,5,58,0,0,1153,
		1155,3,92,46,0,1154,1153,1,0,0,0,1154,1155,1,0,0,0,1155,1156,1,0,0,0,1156,
		1165,5,129,0,0,1157,1158,5,58,0,0,1158,1159,3,288,144,0,1159,1160,5,129,
		0,0,1160,1165,1,0,0,0,1161,1162,5,41,0,0,1162,1163,5,133,0,0,1163,1165,
		5,129,0,0,1164,1148,1,0,0,0,1164,1150,1,0,0,0,1164,1152,1,0,0,0,1164,1157,
		1,0,0,0,1164,1161,1,0,0,0,1165,119,1,0,0,0,1166,1167,3,126,63,0,1167,121,
		1,0,0,0,1168,1169,6,61,-1,0,1169,1170,3,124,62,0,1170,1175,1,0,0,0,1171,
		1172,10,1,0,0,1172,1174,3,124,62,0,1173,1171,1,0,0,0,1174,1177,1,0,0,0,
		1175,1173,1,0,0,0,1175,1176,1,0,0,0,1176,123,1,0,0,0,1177,1175,1,0,0,0,
		1178,1188,3,126,63,0,1179,1188,3,276,138,0,1180,1188,3,346,173,0,1181,
		1188,3,366,183,0,1182,1188,3,368,184,0,1183,1188,3,210,105,0,1184,1188,
		3,186,93,0,1185,1188,3,134,67,0,1186,1188,3,136,68,0,1187,1178,1,0,0,0,
		1187,1179,1,0,0,0,1187,1180,1,0,0,0,1187,1181,1,0,0,0,1187,1182,1,0,0,
		0,1187,1183,1,0,0,0,1187,1184,1,0,0,0,1187,1185,1,0,0,0,1187,1186,1,0,
		0,0,1188,125,1,0,0,0,1189,1198,3,130,65,0,1190,1198,3,208,104,0,1191,1198,
		3,200,100,0,1192,1198,3,204,102,0,1193,1198,3,206,103,0,1194,1198,3,132,
		66,0,1195,1198,3,128,64,0,1196,1198,3,170,85,0,1197,1189,1,0,0,0,1197,
		1190,1,0,0,0,1197,1191,1,0,0,0,1197,1192,1,0,0,0,1197,1193,1,0,0,0,1197,
		1194,1,0,0,0,1197,1195,1,0,0,0,1197,1196,1,0,0,0,1198,127,1,0,0,0,1199,
		1200,5,78,0,0,1200,1202,5,133,0,0,1201,1203,3,212,106,0,1202,1201,1,0,
		0,0,1202,1203,1,0,0,0,1203,1204,1,0,0,0,1204,1205,5,100,0,0,1205,1206,
		3,258,129,0,1206,1207,5,129,0,0,1207,129,1,0,0,0,1208,1210,3,140,70,0,
		1209,1208,1,0,0,0,1209,1210,1,0,0,0,1210,1212,1,0,0,0,1211,1213,3,234,
		117,0,1212,1211,1,0,0,0,1212,1213,1,0,0,0,1213,1214,1,0,0,0,1214,1223,
		5,129,0,0,1215,1217,3,212,106,0,1216,1218,3,140,70,0,1217,1216,1,0,0,0,
		1217,1218,1,0,0,0,1218,1219,1,0,0,0,1219,1220,3,234,117,0,1220,1221,5,
		129,0,0,1221,1223,1,0,0,0,1222,1209,1,0,0,0,1222,1215,1,0,0,0,1223,131,
		1,0,0,0,1224,1225,5,63,0,0,1225,1226,5,84,0,0,1226,1227,3,94,47,0,1227,
		1228,5,123,0,0,1228,1229,5,142,0,0,1229,1230,5,85,0,0,1230,1231,5,129,
		0,0,1231,133,1,0,0,0,1232,1233,5,129,0,0,1233,135,1,0,0,0,1234,1235,3,
		212,106,0,1235,1236,5,129,0,0,1236,137,1,0,0,0,1237,1244,3,142,71,0,1238,
		1244,3,148,74,0,1239,1244,3,144,72,0,1240,1244,5,40,0,0,1241,1244,5,73,
		0,0,1242,1244,5,22,0,0,1243,1237,1,0,0,0,1243,1238,1,0,0,0,1243,1239,1,
		0,0,0,1243,1240,1,0,0,0,1243,1241,1,0,0,0,1243,1242,1,0,0,0,1244,139,1,
		0,0,0,1245,1247,3,138,69,0,1246,1248,3,212,106,0,1247,1246,1,0,0,0,1247,
		1248,1,0,0,0,1248,1253,1,0,0,0,1249,1250,3,138,69,0,1250,1251,3,140,70,
		0,1251,1253,1,0,0,0,1252,1245,1,0,0,0,1252,1249,1,0,0,0,1253,141,1,0,0,
		0,1254,1255,7,4,0,0,1255,143,1,0,0,0,1256,1257,7,5,0,0,1257,145,1,0,0,
		0,1258,1259,5,133,0,0,1259,147,1,0,0,0,1260,1264,3,150,75,0,1261,1264,
		3,292,146,0,1262,1264,3,166,83,0,1263,1260,1,0,0,0,1263,1261,1,0,0,0,1263,
		1262,1,0,0,0,1264,149,1,0,0,0,1265,1270,3,156,78,0,1266,1270,3,162,81,
		0,1267,1270,3,364,182,0,1268,1270,3,252,126,0,1269,1265,1,0,0,0,1269,1266,
		1,0,0,0,1269,1267,1,0,0,0,1269,1268,1,0,0,0,1270,151,1,0,0,0,1271,1273,
		3,148,74,0,1272,1274,3,212,106,0,1273,1272,1,0,0,0,1273,1274,1,0,0,0,1274,
		1279,1,0,0,0,1275,1276,3,148,74,0,1276,1277,3,152,76,0,1277,1279,1,0,0,
		0,1278,1271,1,0,0,0,1278,1275,1,0,0,0,1279,153,1,0,0,0,1280,1282,3,150,
		75,0,1281,1283,3,212,106,0,1282,1281,1,0,0,0,1282,1283,1,0,0,0,1283,1288,
		1,0,0,0,1284,1285,3,150,75,0,1285,1286,3,154,77,0,1286,1288,1,0,0,0,1287,
		1280,1,0,0,0,1287,1284,1,0,0,0,1288,155,1,0,0,0,1289,1291,3,10,5,0,1290,
		1289,1,0,0,0,1290,1291,1,0,0,0,1291,1292,1,0,0,0,1292,1313,3,158,79,0,
		1293,1294,3,10,5,0,1294,1295,5,67,0,0,1295,1296,3,354,177,0,1296,1313,
		1,0,0,0,1297,1313,5,17,0,0,1298,1313,5,18,0,0,1299,1313,5,19,0,0,1300,
		1313,5,82,0,0,1301,1313,5,13,0,0,1302,1313,5,59,0,0,1303,1313,5,44,0,0,
		1304,1313,5,45,0,0,1305,1313,5,60,0,0,1306,1313,5,77,0,0,1307,1313,5,38,
		0,0,1308,1313,5,29,0,0,1309,1313,5,80,0,0,1310,1313,5,12,0,0,1311,1313,
		3,160,80,0,1312,1290,1,0,0,0,1312,1293,1,0,0,0,1312,1297,1,0,0,0,1312,
		1298,1,0,0,0,1312,1299,1,0,0,0,1312,1300,1,0,0,0,1312,1301,1,0,0,0,1312,
		1302,1,0,0,0,1312,1303,1,0,0,0,1312,1304,1,0,0,0,1312,1305,1,0,0,0,1312,
		1306,1,0,0,0,1312,1307,1,0,0,0,1312,1308,1,0,0,0,1312,1309,1,0,0,0,1312,
		1310,1,0,0,0,1312,1311,1,0,0,0,1313,157,1,0,0,0,1314,1319,3,290,145,0,
		1315,1319,3,164,82,0,1316,1319,3,146,73,0,1317,1319,3,354,177,0,1318,1314,
		1,0,0,0,1318,1315,1,0,0,0,1318,1316,1,0,0,0,1318,1317,1,0,0,0,1319,159,
		1,0,0,0,1320,1321,5,25,0,0,1321,1322,5,84,0,0,1322,1323,3,92,46,0,1323,
		1324,5,85,0,0,1324,1330,1,0,0,0,1325,1326,5,25,0,0,1326,1327,5,84,0,0,
		1327,1328,5,12,0,0,1328,1330,5,85,0,0,1329,1320,1,0,0,0,1329,1325,1,0,
		0,0,1330,161,1,0,0,0,1331,1333,3,300,150,0,1332,1334,3,212,106,0,1333,
		1332,1,0,0,0,1333,1334,1,0,0,0,1334,1336,1,0,0,0,1335,1337,3,10,5,0,1336,
		1335,1,0,0,0,1336,1337,1,0,0,0,1337,1338,1,0,0,0,1338,1339,5,133,0,0,1339,
		1356,1,0,0,0,1340,1341,3,300,150,0,1341,1342,3,354,177,0,1342,1356,1,0,
		0,0,1343,1344,3,300,150,0,1344,1346,3,10,5,0,1345,1347,5,67,0,0,1346,1345,
		1,0,0,0,1346,1347,1,0,0,0,1347,1348,1,0,0,0,1348,1349,3,354,177,0,1349,
		1356,1,0,0,0,1350,1352,5,32,0,0,1351,1353,3,10,5,0,1352,1351,1,0,0,0,1352,
		1353,1,0,0,0,1353,1354,1,0,0,0,1354,1356,5,133,0,0,1355,1331,1,0,0,0,1355,
		1340,1,0,0,0,1355,1343,1,0,0,0,1355,1350,1,0,0,0,1356,163,1,0,0,0,1357,
		1358,5,133,0,0,1358,165,1,0,0,0,1359,1360,3,168,84,0,1360,1362,5,88,0,
		0,1361,1363,3,176,88,0,1362,1361,1,0,0,0,1362,1363,1,0,0,0,1363,1364,1,
		0,0,0,1364,1365,5,89,0,0,1365,1373,1,0,0,0,1366,1367,3,168,84,0,1367,1368,
		5,88,0,0,1368,1369,3,176,88,0,1369,1370,5,123,0,0,1370,1371,5,89,0,0,1371,
		1373,1,0,0,0,1372,1359,1,0,0,0,1372,1366,1,0,0,0,1373,167,1,0,0,0,1374,
		1376,3,172,86,0,1375,1377,3,212,106,0,1376,1375,1,0,0,0,1376,1377,1,0,
		0,0,1377,1379,1,0,0,0,1378,1380,5,133,0,0,1379,1378,1,0,0,0,1379,1380,
		1,0,0,0,1380,1382,1,0,0,0,1381,1383,3,174,87,0,1382,1381,1,0,0,0,1382,
		1383,1,0,0,0,1383,1394,1,0,0,0,1384,1386,3,172,86,0,1385,1387,3,212,106,
		0,1386,1385,1,0,0,0,1386,1387,1,0,0,0,1387,1388,1,0,0,0,1388,1389,3,10,
		5,0,1389,1391,5,133,0,0,1390,1392,3,174,87,0,1391,1390,1,0,0,0,1391,1392,
		1,0,0,0,1392,1394,1,0,0,0,1393,1374,1,0,0,0,1393,1384,1,0,0,0,1394,169,
		1,0,0,0,1395,1397,3,172,86,0,1396,1398,3,212,106,0,1397,1396,1,0,0,0,1397,
		1398,1,0,0,0,1398,1399,1,0,0,0,1399,1401,5,133,0,0,1400,1402,3,174,87,
		0,1401,1400,1,0,0,0,1401,1402,1,0,0,0,1402,1403,1,0,0,0,1403,1404,5,129,
		0,0,1404,171,1,0,0,0,1405,1411,5,32,0,0,1406,1407,5,32,0,0,1407,1411,5,
		20,0,0,1408,1409,5,32,0,0,1409,1411,5,65,0,0,1410,1405,1,0,0,0,1410,1406,
		1,0,0,0,1410,1408,1,0,0,0,1411,173,1,0,0,0,1412,1413,5,127,0,0,1413,1414,
		3,152,76,0,1414,175,1,0,0,0,1415,1416,6,88,-1,0,1416,1417,3,178,89,0,1417,
		1423,1,0,0,0,1418,1419,10,1,0,0,1419,1420,5,123,0,0,1420,1422,3,178,89,
		0,1421,1418,1,0,0,0,1422,1425,1,0,0,0,1423,1421,1,0,0,0,1423,1424,1,0,
		0,0,1424,177,1,0,0,0,1425,1423,1,0,0,0,1426,1432,3,180,90,0,1427,1428,
		3,180,90,0,1428,1429,5,100,0,0,1429,1430,3,94,47,0,1430,1432,1,0,0,0,1431,
		1426,1,0,0,0,1431,1427,1,0,0,0,1432,179,1,0,0,0,1433,1434,5,133,0,0,1434,
		181,1,0,0,0,1435,1438,3,184,92,0,1436,1438,3,198,99,0,1437,1435,1,0,0,
		0,1437,1436,1,0,0,0,1438,183,1,0,0,0,1439,1440,5,133,0,0,1440,185,1,0,
		0,0,1441,1444,3,188,94,0,1442,1444,3,194,97,0,1443,1441,1,0,0,0,1443,1442,
		1,0,0,0,1444,187,1,0,0,0,1445,1448,3,190,95,0,1446,1448,3,192,96,0,1447,
		1445,1,0,0,0,1447,1446,1,0,0,0,1448,189,1,0,0,0,1449,1451,5,43,0,0,1450,
		1449,1,0,0,0,1450,1451,1,0,0,0,1451,1452,1,0,0,0,1452,1453,5,47,0,0,1453,
		1454,5,133,0,0,1454,1455,5,88,0,0,1455,1456,3,196,98,0,1456,1457,5,89,
		0,0,1457,191,1,0,0,0,1458,1460,5,43,0,0,1459,1458,1,0,0,0,1459,1460,1,
		0,0,0,1460,1461,1,0,0,0,1461,1462,5,47,0,0,1462,1463,3,184,92,0,1463,1464,
		5,88,0,0,1464,1465,3,196,98,0,1465,1466,5,89,0,0,1466,193,1,0,0,0,1467,
		1469,5,43,0,0,1468,1467,1,0,0,0,1468,1469,1,0,0,0,1469,1470,1,0,0,0,1470,
		1471,5,47,0,0,1471,1472,5,88,0,0,1472,1473,3,196,98,0,1473,1474,5,89,0,
		0,1474,195,1,0,0,0,1475,1477,3,122,61,0,1476,1475,1,0,0,0,1476,1477,1,
		0,0,0,1477,197,1,0,0,0,1478,1479,5,133,0,0,1479,199,1,0,0,0,1480,1481,
		5,47,0,0,1481,1482,5,133,0,0,1482,1483,5,100,0,0,1483,1484,3,202,101,0,
		1484,1485,5,129,0,0,1485,201,1,0,0,0,1486,1488,3,10,5,0,1487,1486,1,0,
		0,0,1487,1488,1,0,0,0,1488,1489,1,0,0,0,1489,1490,3,182,91,0,1490,203,
		1,0,0,0,1491,1493,5,78,0,0,1492,1494,5,75,0,0,1493,1492,1,0,0,0,1493,1494,
		1,0,0,0,1494,1495,1,0,0,0,1495,1496,3,10,5,0,1496,1497,3,6,3,0,1497,1498,
		5,129,0,0,1498,1505,1,0,0,0,1499,1500,5,78,0,0,1500,1501,5,128,0,0,1501,
		1502,3,6,3,0,1502,1503,5,129,0,0,1503,1505,1,0,0,0,1504,1491,1,0,0,0,1504,
		1499,1,0,0,0,1505,205,1,0,0,0,1506,1508,3,212,106,0,1507,1506,1,0,0,0,
		1507,1508,1,0,0,0,1508,1509,1,0,0,0,1509,1510,5,78,0,0,1510,1512,5,47,
		0,0,1511,1513,3,10,5,0,1512,1511,1,0,0,0,1512,1513,1,0,0,0,1513,1514,1,
		0,0,0,1514,1515,3,182,91,0,1515,1516,5,129,0,0,1516,207,1,0,0,0,1517,1518,
		5,11,0,0,1518,1519,5,84,0,0,1519,1520,5,142,0,0,1520,1521,5,85,0,0,1521,
		1522,5,129,0,0,1522,209,1,0,0,0,1523,1524,5,35,0,0,1524,1525,5,142,0,0,
		1525,1527,5,88,0,0,1526,1528,3,122,61,0,1527,1526,1,0,0,0,1527,1528,1,
		0,0,0,1528,1529,1,0,0,0,1529,1534,5,89,0,0,1530,1531,5,35,0,0,1531,1532,
		5,142,0,0,1532,1534,3,124,62,0,1533,1523,1,0,0,0,1533,1530,1,0,0,0,1534,
		211,1,0,0,0,1535,1536,6,106,-1,0,1536,1537,3,214,107,0,1537,1542,1,0,0,
		0,1538,1539,10,1,0,0,1539,1541,3,214,107,0,1540,1538,1,0,0,0,1541,1544,
		1,0,0,0,1542,1540,1,0,0,0,1542,1543,1,0,0,0,1543,213,1,0,0,0,1544,1542,
		1,0,0,0,1545,1546,5,86,0,0,1546,1547,5,86,0,0,1547,1548,3,218,109,0,1548,
		1549,5,87,0,0,1549,1550,5,87,0,0,1550,1553,1,0,0,0,1551,1553,3,216,108,
		0,1552,1545,1,0,0,0,1552,1551,1,0,0,0,1553,215,1,0,0,0,1554,1555,5,9,0,
		0,1555,1556,5,84,0,0,1556,1558,3,258,129,0,1557,1559,5,132,0,0,1558,1557,
		1,0,0,0,1558,1559,1,0,0,0,1559,1560,1,0,0,0,1560,1561,5,85,0,0,1561,1571,
		1,0,0,0,1562,1563,5,9,0,0,1563,1564,5,84,0,0,1564,1566,3,94,47,0,1565,
		1567,5,132,0,0,1566,1565,1,0,0,0,1566,1567,1,0,0,0,1567,1568,1,0,0,0,1568,
		1569,5,85,0,0,1569,1571,1,0,0,0,1570,1554,1,0,0,0,1570,1562,1,0,0,0,1571,
		217,1,0,0,0,1572,1574,6,109,-1,0,1573,1575,3,220,110,0,1574,1573,1,0,0,
		0,1574,1575,1,0,0,0,1575,1580,1,0,0,0,1576,1577,3,220,110,0,1577,1578,
		5,132,0,0,1578,1580,1,0,0,0,1579,1572,1,0,0,0,1579,1576,1,0,0,0,1580,1593,
		1,0,0,0,1581,1582,10,3,0,0,1582,1584,5,123,0,0,1583,1585,3,220,110,0,1584,
		1583,1,0,0,0,1584,1585,1,0,0,0,1585,1592,1,0,0,0,1586,1587,10,1,0,0,1587,
		1588,5,123,0,0,1588,1589,3,220,110,0,1589,1590,5,132,0,0,1590,1592,1,0,
		0,0,1591,1581,1,0,0,0,1591,1586,1,0,0,0,1592,1595,1,0,0,0,1593,1591,1,
		0,0,0,1593,1594,1,0,0,0,1594,219,1,0,0,0,1595,1593,1,0,0,0,1596,1598,3,
		222,111,0,1597,1599,3,228,114,0,1598,1597,1,0,0,0,1598,1599,1,0,0,0,1599,
		221,1,0,0,0,1600,1603,5,133,0,0,1601,1603,3,224,112,0,1602,1600,1,0,0,
		0,1602,1601,1,0,0,0,1603,223,1,0,0,0,1604,1605,3,226,113,0,1605,1606,5,
		128,0,0,1606,1607,5,133,0,0,1607,225,1,0,0,0,1608,1609,5,133,0,0,1609,
		227,1,0,0,0,1610,1611,5,84,0,0,1611,1612,3,230,115,0,1612,1613,5,85,0,
		0,1613,229,1,0,0,0,1614,1616,6,115,-1,0,1615,1617,3,232,116,0,1616,1615,
		1,0,0,0,1616,1617,1,0,0,0,1617,1622,1,0,0,0,1618,1619,10,1,0,0,1619,1621,
		3,232,116,0,1620,1618,1,0,0,0,1621,1624,1,0,0,0,1622,1620,1,0,0,0,1622,
		1623,1,0,0,0,1623,231,1,0,0,0,1624,1622,1,0,0,0,1625,1626,5,84,0,0,1626,
		1627,3,230,115,0,1627,1628,5,85,0,0,1628,1643,1,0,0,0,1629,1630,5,86,0,
		0,1630,1631,3,230,115,0,1631,1632,5,87,0,0,1632,1643,1,0,0,0,1633,1634,
		5,88,0,0,1634,1635,3,230,115,0,1635,1636,5,89,0,0,1636,1643,1,0,0,0,1637,
		1639,8,6,0,0,1638,1637,1,0,0,0,1639,1640,1,0,0,0,1640,1638,1,0,0,0,1640,
		1641,1,0,0,0,1641,1643,1,0,0,0,1642,1625,1,0,0,0,1642,1629,1,0,0,0,1642,
		1633,1,0,0,0,1642,1638,1,0,0,0,1643,233,1,0,0,0,1644,1645,6,117,-1,0,1645,
		1646,3,236,118,0,1646,1652,1,0,0,0,1647,1648,10,1,0,0,1648,1649,5,123,
		0,0,1649,1651,3,236,118,0,1650,1647,1,0,0,0,1651,1654,1,0,0,0,1652,1650,
		1,0,0,0,1652,1653,1,0,0,0,1653,235,1,0,0,0,1654,1652,1,0,0,0,1655,1657,
		3,238,119,0,1656,1658,3,280,140,0,1657,1656,1,0,0,0,1657,1658,1,0,0,0,
		1658,237,1,0,0,0,1659,1665,3,240,120,0,1660,1661,3,242,121,0,1661,1662,
		3,244,122,0,1662,1663,3,246,123,0,1663,1665,1,0,0,0,1664,1659,1,0,0,0,
		1664,1660,1,0,0,0,1665,239,1,0,0,0,1666,1671,3,242,121,0,1667,1668,3,248,
		124,0,1668,1669,3,240,120,0,1669,1671,1,0,0,0,1670,1666,1,0,0,0,1670,1667,
		1,0,0,0,1671,241,1,0,0,0,1672,1673,6,121,-1,0,1673,1675,3,256,128,0,1674,
		1676,3,212,106,0,1675,1674,1,0,0,0,1675,1676,1,0,0,0,1676,1682,1,0,0,0,
		1677,1678,5,84,0,0,1678,1679,3,240,120,0,1679,1680,5,85,0,0,1680,1682,
		1,0,0,0,1681,1672,1,0,0,0,1681,1677,1,0,0,0,1682,1696,1,0,0,0,1683,1684,
		10,3,0,0,1684,1695,3,244,122,0,1685,1686,10,2,0,0,1686,1688,5,86,0,0,1687,
		1689,3,94,47,0,1688,1687,1,0,0,0,1688,1689,1,0,0,0,1689,1690,1,0,0,0,1690,
		1692,5,87,0,0,1691,1693,3,212,106,0,1692,1691,1,0,0,0,1692,1693,1,0,0,
		0,1693,1695,1,0,0,0,1694,1683,1,0,0,0,1694,1685,1,0,0,0,1695,1698,1,0,
		0,0,1696,1694,1,0,0,0,1696,1697,1,0,0,0,1697,243,1,0,0,0,1698,1696,1,0,
		0,0,1699,1700,5,84,0,0,1700,1701,3,270,135,0,1701,1703,5,85,0,0,1702,1704,
		3,250,125,0,1703,1702,1,0,0,0,1703,1704,1,0,0,0,1704,1706,1,0,0,0,1705,
		1707,3,254,127,0,1706,1705,1,0,0,0,1706,1707,1,0,0,0,1707,1709,1,0,0,0,
		1708,1710,3,382,191,0,1709,1708,1,0,0,0,1709,1710,1,0,0,0,1710,1712,1,
		0,0,0,1711,1713,3,212,106,0,1712,1711,1,0,0,0,1712,1713,1,0,0,0,1713,245,
		1,0,0,0,1714,1715,5,125,0,0,1715,1717,3,154,77,0,1716,1718,3,260,130,0,
		1717,1716,1,0,0,0,1717,1718,1,0,0,0,1718,247,1,0,0,0,1719,1721,5,92,0,
		0,1720,1722,3,212,106,0,1721,1720,1,0,0,0,1721,1722,1,0,0,0,1722,1724,
		1,0,0,0,1723,1725,3,250,125,0,1724,1723,1,0,0,0,1724,1725,1,0,0,0,1725,
		1743,1,0,0,0,1726,1728,5,96,0,0,1727,1729,3,212,106,0,1728,1727,1,0,0,
		0,1728,1729,1,0,0,0,1729,1743,1,0,0,0,1730,1732,5,3,0,0,1731,1733,3,212,
		106,0,1732,1731,1,0,0,0,1732,1733,1,0,0,0,1733,1743,1,0,0,0,1734,1735,
		3,10,5,0,1735,1737,5,92,0,0,1736,1738,3,212,106,0,1737,1736,1,0,0,0,1737,
		1738,1,0,0,0,1738,1740,1,0,0,0,1739,1741,3,250,125,0,1740,1739,1,0,0,0,
		1740,1741,1,0,0,0,1741,1743,1,0,0,0,1742,1719,1,0,0,0,1742,1726,1,0,0,
		0,1742,1730,1,0,0,0,1742,1734,1,0,0,0,1743,249,1,0,0,0,1744,1746,3,252,
		126,0,1745,1747,3,250,125,0,1746,1745,1,0,0,0,1746,1747,1,0,0,0,1747,251,
		1,0,0,0,1748,1749,7,7,0,0,1749,253,1,0,0,0,1750,1751,7,8,0,0,1751,255,
		1,0,0,0,1752,1754,5,132,0,0,1753,1752,1,0,0,0,1753,1754,1,0,0,0,1754,1755,
		1,0,0,0,1755,1756,3,4,2,0,1756,257,1,0,0,0,1757,1759,3,152,76,0,1758,1760,
		3,260,130,0,1759,1758,1,0,0,0,1759,1760,1,0,0,0,1760,259,1,0,0,0,1761,
		1770,3,262,131,0,1762,1764,3,264,132,0,1763,1762,1,0,0,0,1763,1764,1,0,
		0,0,1764,1765,1,0,0,0,1765,1766,3,244,122,0,1766,1767,3,246,123,0,1767,
		1770,1,0,0,0,1768,1770,3,266,133,0,1769,1761,1,0,0,0,1769,1763,1,0,0,0,
		1769,1768,1,0,0,0,1770,261,1,0,0,0,1771,1777,3,264,132,0,1772,1774,3,248,
		124,0,1773,1775,3,262,131,0,1774,1773,1,0,0,0,1774,1775,1,0,0,0,1775,1777,
		1,0,0,0,1776,1771,1,0,0,0,1776,1772,1,0,0,0,1777,263,1,0,0,0,1778,1779,
		6,132,-1,0,1779,1793,3,244,122,0,1780,1782,5,86,0,0,1781,1783,3,94,47,
		0,1782,1781,1,0,0,0,1782,1783,1,0,0,0,1783,1784,1,0,0,0,1784,1786,5,87,
		0,0,1785,1787,3,212,106,0,1786,1785,1,0,0,0,1786,1787,1,0,0,0,1787,1793,
		1,0,0,0,1788,1789,5,84,0,0,1789,1790,3,262,131,0,1790,1791,5,85,0,0,1791,
		1793,1,0,0,0,1792,1778,1,0,0,0,1792,1780,1,0,0,0,1792,1788,1,0,0,0,1793,
		1807,1,0,0,0,1794,1795,10,5,0,0,1795,1806,3,244,122,0,1796,1797,10,3,0,
		0,1797,1799,5,86,0,0,1798,1800,3,94,47,0,1799,1798,1,0,0,0,1799,1800,1,
		0,0,0,1800,1801,1,0,0,0,1801,1803,5,87,0,0,1802,1804,3,212,106,0,1803,
		1802,1,0,0,0,1803,1804,1,0,0,0,1804,1806,1,0,0,0,1805,1794,1,0,0,0,1805,
		1796,1,0,0,0,1806,1809,1,0,0,0,1807,1805,1,0,0,0,1807,1808,1,0,0,0,1808,
		265,1,0,0,0,1809,1807,1,0,0,0,1810,1815,3,268,134,0,1811,1812,3,248,124,
		0,1812,1813,3,266,133,0,1813,1815,1,0,0,0,1814,1810,1,0,0,0,1814,1811,
		1,0,0,0,1815,267,1,0,0,0,1816,1817,6,134,-1,0,1817,1818,5,132,0,0,1818,
		1832,1,0,0,0,1819,1820,10,3,0,0,1820,1831,3,244,122,0,1821,1822,10,2,0,
		0,1822,1824,5,86,0,0,1823,1825,3,94,47,0,1824,1823,1,0,0,0,1824,1825,1,
		0,0,0,1825,1826,1,0,0,0,1826,1828,5,87,0,0,1827,1829,3,212,106,0,1828,
		1827,1,0,0,0,1828,1829,1,0,0,0,1829,1831,1,0,0,0,1830,1819,1,0,0,0,1830,
		1821,1,0,0,0,1831,1834,1,0,0,0,1832,1830,1,0,0,0,1832,1833,1,0,0,0,1833,
		269,1,0,0,0,1834,1832,1,0,0,0,1835,1837,3,272,136,0,1836,1835,1,0,0,0,
		1836,1837,1,0,0,0,1837,1839,1,0,0,0,1838,1840,5,132,0,0,1839,1838,1,0,
		0,0,1839,1840,1,0,0,0,1840,1846,1,0,0,0,1841,1842,3,272,136,0,1842,1843,
		5,123,0,0,1843,1844,5,132,0,0,1844,1846,1,0,0,0,1845,1836,1,0,0,0,1845,
		1841,1,0,0,0,1846,271,1,0,0,0,1847,1848,6,136,-1,0,1848,1849,3,274,137,
		0,1849,1855,1,0,0,0,1850,1851,10,1,0,0,1851,1852,5,123,0,0,1852,1854,3,
		274,137,0,1853,1850,1,0,0,0,1854,1857,1,0,0,0,1855,1853,1,0,0,0,1855,1856,
		1,0,0,0,1856,273,1,0,0,0,1857,1855,1,0,0,0,1858,1860,3,212,106,0,1859,
		1858,1,0,0,0,1859,1860,1,0,0,0,1860,1861,1,0,0,0,1861,1862,3,140,70,0,
		1862,1863,3,238,119,0,1863,1890,1,0,0,0,1864,1866,3,212,106,0,1865,1864,
		1,0,0,0,1865,1866,1,0,0,0,1866,1867,1,0,0,0,1867,1868,3,140,70,0,1868,
		1869,3,238,119,0,1869,1870,5,100,0,0,1870,1871,3,284,142,0,1871,1890,1,
		0,0,0,1872,1874,3,212,106,0,1873,1872,1,0,0,0,1873,1874,1,0,0,0,1874,1875,
		1,0,0,0,1875,1877,3,140,70,0,1876,1878,3,260,130,0,1877,1876,1,0,0,0,1877,
		1878,1,0,0,0,1878,1890,1,0,0,0,1879,1881,3,212,106,0,1880,1879,1,0,0,0,
		1880,1881,1,0,0,0,1881,1882,1,0,0,0,1882,1884,3,140,70,0,1883,1885,3,260,
		130,0,1884,1883,1,0,0,0,1884,1885,1,0,0,0,1885,1886,1,0,0,0,1886,1887,
		5,100,0,0,1887,1888,3,284,142,0,1888,1890,1,0,0,0,1889,1859,1,0,0,0,1889,
		1865,1,0,0,0,1889,1873,1,0,0,0,1889,1880,1,0,0,0,1890,275,1,0,0,0,1891,
		1893,3,212,106,0,1892,1891,1,0,0,0,1892,1893,1,0,0,0,1893,1895,1,0,0,0,
		1894,1896,3,140,70,0,1895,1894,1,0,0,0,1895,1896,1,0,0,0,1896,1897,1,0,
		0,0,1897,1899,3,238,119,0,1898,1900,3,310,155,0,1899,1898,1,0,0,0,1899,
		1900,1,0,0,0,1900,1901,1,0,0,0,1901,1902,3,278,139,0,1902,277,1,0,0,0,
		1903,1905,3,334,167,0,1904,1903,1,0,0,0,1904,1905,1,0,0,0,1905,1906,1,
		0,0,0,1906,1915,3,102,51,0,1907,1915,3,372,186,0,1908,1909,5,100,0,0,1909,
		1910,5,26,0,0,1910,1915,5,129,0,0,1911,1912,5,100,0,0,1912,1913,5,27,0,
		0,1913,1915,5,129,0,0,1914,1904,1,0,0,0,1914,1907,1,0,0,0,1914,1908,1,
		0,0,0,1914,1911,1,0,0,0,1915,279,1,0,0,0,1916,1922,3,282,141,0,1917,1918,
		5,84,0,0,1918,1919,3,36,18,0,1919,1920,5,85,0,0,1920,1922,1,0,0,0,1921,
		1916,1,0,0,0,1921,1917,1,0,0,0,1922,281,1,0,0,0,1923,1924,5,100,0,0,1924,
		1927,3,284,142,0,1925,1927,3,288,144,0,1926,1923,1,0,0,0,1926,1925,1,0,
		0,0,1927,283,1,0,0,0,1928,1931,3,88,44,0,1929,1931,3,288,144,0,1930,1928,
		1,0,0,0,1930,1929,1,0,0,0,1931,285,1,0,0,0,1932,1933,6,143,-1,0,1933,1935,
		3,284,142,0,1934,1936,5,132,0,0,1935,1934,1,0,0,0,1935,1936,1,0,0,0,1936,
		1945,1,0,0,0,1937,1938,10,1,0,0,1938,1939,5,123,0,0,1939,1941,3,284,142,
		0,1940,1942,5,132,0,0,1941,1940,1,0,0,0,1941,1942,1,0,0,0,1942,1944,1,
		0,0,0,1943,1937,1,0,0,0,1944,1947,1,0,0,0,1945,1943,1,0,0,0,1945,1946,
		1,0,0,0,1946,287,1,0,0,0,1947,1945,1,0,0,0,1948,1949,5,88,0,0,1949,1951,
		3,286,143,0,1950,1952,5,123,0,0,1951,1950,1,0,0,0,1951,1952,1,0,0,0,1952,
		1953,1,0,0,0,1953,1954,5,89,0,0,1954,1958,1,0,0,0,1955,1956,5,88,0,0,1956,
		1958,5,89,0,0,1957,1948,1,0,0,0,1957,1955,1,0,0,0,1958,289,1,0,0,0,1959,
		1962,5,133,0,0,1960,1962,3,354,177,0,1961,1959,1,0,0,0,1961,1960,1,0,0,
		0,1962,291,1,0,0,0,1963,1964,3,294,147,0,1964,1966,5,88,0,0,1965,1967,
		3,302,151,0,1966,1965,1,0,0,0,1966,1967,1,0,0,0,1967,1968,1,0,0,0,1968,
		1969,5,89,0,0,1969,293,1,0,0,0,1970,1972,3,300,150,0,1971,1973,3,212,106,
		0,1972,1971,1,0,0,0,1972,1973,1,0,0,0,1973,1974,1,0,0,0,1974,1976,3,296,
		148,0,1975,1977,3,298,149,0,1976,1975,1,0,0,0,1976,1977,1,0,0,0,1977,1979,
		1,0,0,0,1978,1980,3,316,158,0,1979,1978,1,0,0,0,1979,1980,1,0,0,0,1980,
		1989,1,0,0,0,1981,1983,3,300,150,0,1982,1984,3,212,106,0,1983,1982,1,0,
		0,0,1983,1984,1,0,0,0,1984,1986,1,0,0,0,1985,1987,3,316,158,0,1986,1985,
		1,0,0,0,1986,1987,1,0,0,0,1987,1989,1,0,0,0,1988,1970,1,0,0,0,1988,1981,
		1,0,0,0,1989,295,1,0,0,0,1990,1992,3,10,5,0,1991,1990,1,0,0,0,1991,1992,
		1,0,0,0,1992,1993,1,0,0,0,1993,1994,3,290,145,0,1994,297,1,0,0,0,1995,
		1996,5,37,0,0,1996,299,1,0,0,0,1997,1998,7,9,0,0,1998,301,1,0,0,0,1999,
		2001,3,304,152,0,2000,2002,3,302,151,0,2001,2000,1,0,0,0,2001,2002,1,0,
		0,0,2002,2009,1,0,0,0,2003,2004,3,326,163,0,2004,2006,5,127,0,0,2005,2007,
		3,302,151,0,2006,2005,1,0,0,0,2006,2007,1,0,0,0,2007,2009,1,0,0,0,2008,
		1999,1,0,0,0,2008,2003,1,0,0,0,2009,303,1,0,0,0,2010,2012,3,212,106,0,
		2011,2010,1,0,0,0,2011,2012,1,0,0,0,2012,2014,1,0,0,0,2013,2015,3,140,
		70,0,2014,2013,1,0,0,0,2014,2015,1,0,0,0,2015,2017,1,0,0,0,2016,2018,3,
		306,153,0,2017,2016,1,0,0,0,2017,2018,1,0,0,0,2018,2019,1,0,0,0,2019,2027,
		5,129,0,0,2020,2027,3,276,138,0,2021,2027,3,204,102,0,2022,2027,3,132,
		66,0,2023,2027,3,346,173,0,2024,2027,3,128,64,0,2025,2027,3,134,67,0,2026,
		2011,1,0,0,0,2026,2020,1,0,0,0,2026,2021,1,0,0,0,2026,2022,1,0,0,0,2026,
		2023,1,0,0,0,2026,2024,1,0,0,0,2026,2025,1,0,0,0,2027,305,1,0,0,0,2028,
		2029,6,153,-1,0,2029,2030,3,308,154,0,2030,2036,1,0,0,0,2031,2032,10,1,
		0,0,2032,2033,5,123,0,0,2033,2035,3,308,154,0,2034,2031,1,0,0,0,2035,2038,
		1,0,0,0,2036,2034,1,0,0,0,2036,2037,1,0,0,0,2037,307,1,0,0,0,2038,2036,
		1,0,0,0,2039,2041,3,238,119,0,2040,2042,3,310,155,0,2041,2040,1,0,0,0,
		2041,2042,1,0,0,0,2042,2044,1,0,0,0,2043,2045,3,314,157,0,2044,2043,1,
		0,0,0,2044,2045,1,0,0,0,2045,2059,1,0,0,0,2046,2048,3,238,119,0,2047,2049,
		3,282,141,0,2048,2047,1,0,0,0,2048,2049,1,0,0,0,2049,2059,1,0,0,0,2050,
		2052,5,133,0,0,2051,2050,1,0,0,0,2051,2052,1,0,0,0,2052,2054,1,0,0,0,2053,
		2055,3,212,106,0,2054,2053,1,0,0,0,2054,2055,1,0,0,0,2055,2056,1,0,0,0,
		2056,2057,5,127,0,0,2057,2059,3,94,47,0,2058,2039,1,0,0,0,2058,2046,1,
		0,0,0,2058,2051,1,0,0,0,2059,309,1,0,0,0,2060,2061,6,155,-1,0,2061,2062,
		3,312,156,0,2062,2067,1,0,0,0,2063,2064,10,1,0,0,2064,2066,3,312,156,0,
		2065,2063,1,0,0,0,2066,2069,1,0,0,0,2067,2065,1,0,0,0,2067,2068,1,0,0,
		0,2068,311,1,0,0,0,2069,2067,1,0,0,0,2070,2071,7,10,0,0,2071,313,1,0,0,
		0,2072,2073,5,100,0,0,2073,2074,5,136,0,0,2074,2075,6,157,-1,0,2075,315,
		1,0,0,0,2076,2077,5,127,0,0,2077,2078,3,318,159,0,2078,317,1,0,0,0,2079,
		2080,6,159,-1,0,2080,2082,3,320,160,0,2081,2083,5,132,0,0,2082,2081,1,
		0,0,0,2082,2083,1,0,0,0,2083,2092,1,0,0,0,2084,2085,10,1,0,0,2085,2086,
		5,123,0,0,2086,2088,3,320,160,0,2087,2089,5,132,0,0,2088,2087,1,0,0,0,
		2088,2089,1,0,0,0,2089,2091,1,0,0,0,2090,2084,1,0,0,0,2091,2094,1,0,0,
		0,2092,2090,1,0,0,0,2092,2093,1,0,0,0,2093,319,1,0,0,0,2094,2092,1,0,0,
		0,2095,2097,3,212,106,0,2096,2095,1,0,0,0,2096,2097,1,0,0,0,2097,2098,
		1,0,0,0,2098,2117,3,324,162,0,2099,2101,3,212,106,0,2100,2099,1,0,0,0,
		2100,2101,1,0,0,0,2101,2102,1,0,0,0,2102,2104,5,79,0,0,2103,2105,3,326,
		163,0,2104,2103,1,0,0,0,2104,2105,1,0,0,0,2105,2106,1,0,0,0,2106,2117,
		3,324,162,0,2107,2109,3,212,106,0,2108,2107,1,0,0,0,2108,2109,1,0,0,0,
		2109,2110,1,0,0,0,2110,2112,3,326,163,0,2111,2113,5,79,0,0,2112,2111,1,
		0,0,0,2112,2113,1,0,0,0,2113,2114,1,0,0,0,2114,2115,3,324,162,0,2115,2117,
		1,0,0,0,2116,2096,1,0,0,0,2116,2100,1,0,0,0,2116,2108,1,0,0,0,2117,321,
		1,0,0,0,2118,2120,3,10,5,0,2119,2118,1,0,0,0,2119,2120,1,0,0,0,2120,2121,
		1,0,0,0,2121,2124,3,290,145,0,2122,2124,3,160,80,0,2123,2119,1,0,0,0,2123,
		2122,1,0,0,0,2124,323,1,0,0,0,2125,2126,3,322,161,0,2126,325,1,0,0,0,2127,
		2128,7,11,0,0,2128,327,1,0,0,0,2129,2130,5,51,0,0,2130,2131,3,330,165,
		0,2131,329,1,0,0,0,2132,2134,3,152,76,0,2133,2135,3,332,166,0,2134,2133,
		1,0,0,0,2134,2135,1,0,0,0,2135,331,1,0,0,0,2136,2138,3,248,124,0,2137,
		2139,3,332,166,0,2138,2137,1,0,0,0,2138,2139,1,0,0,0,2139,333,1,0,0,0,
		2140,2141,5,127,0,0,2141,2142,3,336,168,0,2142,335,1,0,0,0,2143,2145,3,
		338,169,0,2144,2146,5,132,0,0,2145,2144,1,0,0,0,2145,2146,1,0,0,0,2146,
		2155,1,0,0,0,2147,2149,3,338,169,0,2148,2150,5,132,0,0,2149,2148,1,0,0,
		0,2149,2150,1,0,0,0,2150,2151,1,0,0,0,2151,2152,5,123,0,0,2152,2153,3,
		336,168,0,2153,2155,1,0,0,0,2154,2143,1,0,0,0,2154,2147,1,0,0,0,2155,337,
		1,0,0,0,2156,2157,3,340,170,0,2157,2159,5,84,0,0,2158,2160,3,36,18,0,2159,
		2158,1,0,0,0,2159,2160,1,0,0,0,2160,2161,1,0,0,0,2161,2162,5,85,0,0,2162,
		2167,1,0,0,0,2163,2164,3,340,170,0,2164,2165,3,288,144,0,2165,2167,1,0,
		0,0,2166,2156,1,0,0,0,2166,2163,1,0,0,0,2167,339,1,0,0,0,2168,2171,3,322,
		161,0,2169,2171,5,133,0,0,2170,2168,1,0,0,0,2170,2169,1,0,0,0,2171,341,
		1,0,0,0,2172,2173,5,51,0,0,2173,2174,3,390,195,0,2174,343,1,0,0,0,2175,
		2176,5,51,0,0,2176,2177,5,142,0,0,2177,2181,5,133,0,0,2178,2179,5,51,0,
		0,2179,2181,5,145,0,0,2180,2175,1,0,0,0,2180,2178,1,0,0,0,2181,345,1,0,
		0,0,2182,2183,5,67,0,0,2183,2184,5,101,0,0,2184,2185,3,348,174,0,2185,
		2186,5,102,0,0,2186,2187,3,124,62,0,2187,347,1,0,0,0,2188,2189,6,174,-1,
		0,2189,2190,3,350,175,0,2190,2196,1,0,0,0,2191,2192,10,1,0,0,2192,2193,
		5,123,0,0,2193,2195,3,350,175,0,2194,2191,1,0,0,0,2195,2198,1,0,0,0,2196,
		2194,1,0,0,0,2196,2197,1,0,0,0,2197,349,1,0,0,0,2198,2196,1,0,0,0,2199,
		2202,3,352,176,0,2200,2202,3,274,137,0,2201,2199,1,0,0,0,2201,2200,1,0,
		0,0,2202,351,1,0,0,0,2203,2205,5,20,0,0,2204,2206,5,132,0,0,2205,2204,
		1,0,0,0,2205,2206,1,0,0,0,2206,2208,1,0,0,0,2207,2209,5,133,0,0,2208,2207,
		1,0,0,0,2208,2209,1,0,0,0,2209,2252,1,0,0,0,2210,2212,5,20,0,0,2211,2213,
		5,133,0,0,2212,2211,1,0,0,0,2212,2213,1,0,0,0,2213,2214,1,0,0,0,2214,2215,
		5,100,0,0,2215,2252,3,258,129,0,2216,2218,5,75,0,0,2217,2219,5,132,0,0,
		2218,2217,1,0,0,0,2218,2219,1,0,0,0,2219,2221,1,0,0,0,2220,2222,5,133,
		0,0,2221,2220,1,0,0,0,2221,2222,1,0,0,0,2222,2252,1,0,0,0,2223,2225,5,
		75,0,0,2224,2226,5,133,0,0,2225,2224,1,0,0,0,2225,2226,1,0,0,0,2226,2227,
		1,0,0,0,2227,2228,5,100,0,0,2228,2252,3,258,129,0,2229,2230,5,67,0,0,2230,
		2231,5,101,0,0,2231,2232,3,348,174,0,2232,2233,5,102,0,0,2233,2235,5,20,
		0,0,2234,2236,5,132,0,0,2235,2234,1,0,0,0,2235,2236,1,0,0,0,2236,2238,
		1,0,0,0,2237,2239,5,133,0,0,2238,2237,1,0,0,0,2238,2239,1,0,0,0,2239,2252,
		1,0,0,0,2240,2241,5,67,0,0,2241,2242,5,101,0,0,2242,2243,3,348,174,0,2243,
		2244,5,102,0,0,2244,2246,5,20,0,0,2245,2247,5,133,0,0,2246,2245,1,0,0,
		0,2246,2247,1,0,0,0,2247,2248,1,0,0,0,2248,2249,5,100,0,0,2249,2250,3,
		4,2,0,2250,2252,1,0,0,0,2251,2203,1,0,0,0,2251,2210,1,0,0,0,2251,2216,
		1,0,0,0,2251,2223,1,0,0,0,2251,2229,1,0,0,0,2251,2240,1,0,0,0,2252,353,
		1,0,0,0,2253,2254,3,358,179,0,2254,2256,5,101,0,0,2255,2257,3,360,180,
		0,2256,2255,1,0,0,0,2256,2257,1,0,0,0,2257,2258,1,0,0,0,2258,2259,5,102,
		0,0,2259,355,1,0,0,0,2260,2276,3,354,177,0,2261,2262,3,342,171,0,2262,
		2264,5,101,0,0,2263,2265,3,360,180,0,2264,2263,1,0,0,0,2264,2265,1,0,0,
		0,2265,2266,1,0,0,0,2266,2267,5,102,0,0,2267,2276,1,0,0,0,2268,2269,3,
		344,172,0,2269,2271,5,101,0,0,2270,2272,3,360,180,0,2271,2270,1,0,0,0,
		2271,2272,1,0,0,0,2272,2273,1,0,0,0,2273,2274,5,102,0,0,2274,2276,1,0,
		0,0,2275,2260,1,0,0,0,2275,2261,1,0,0,0,2275,2268,1,0,0,0,2276,357,1,0,
		0,0,2277,2278,5,133,0,0,2278,359,1,0,0,0,2279,2280,6,180,-1,0,2280,2282,
		3,362,181,0,2281,2283,5,132,0,0,2282,2281,1,0,0,0,2282,2283,1,0,0,0,2283,
		2292,1,0,0,0,2284,2285,10,1,0,0,2285,2286,5,123,0,0,2286,2288,3,362,181,
		0,2287,2289,5,132,0,0,2288,2287,1,0,0,0,2288,2289,1,0,0,0,2289,2291,1,
		0,0,0,2290,2284,1,0,0,0,2291,2294,1,0,0,0,2292,2290,1,0,0,0,2292,2293,
		1,0,0,0,2293,361,1,0,0,0,2294,2292,1,0,0,0,2295,2299,3,258,129,0,2296,
		2299,3,94,47,0,2297,2299,3,4,2,0,2298,2295,1,0,0,0,2298,2296,1,0,0,0,2298,
		2297,1,0,0,0,2299,363,1,0,0,0,2300,2301,5,75,0,0,2301,2302,3,10,5,0,2302,
		2303,5,133,0,0,2303,2312,1,0,0,0,2304,2305,5,75,0,0,2305,2307,3,10,5,0,
		2306,2308,5,67,0,0,2307,2306,1,0,0,0,2307,2308,1,0,0,0,2308,2309,1,0,0,
		0,2309,2310,3,354,177,0,2310,2312,1,0,0,0,2311,2300,1,0,0,0,2311,2304,
		1,0,0,0,2312,365,1,0,0,0,2313,2315,5,35,0,0,2314,2313,1,0,0,0,2314,2315,
		1,0,0,0,2315,2316,1,0,0,0,2316,2317,5,67,0,0,2317,2318,3,124,62,0,2318,
		367,1,0,0,0,2319,2320,5,67,0,0,2320,2321,5,101,0,0,2321,2322,5,102,0,0,
		2322,2323,3,124,62,0,2323,369,1,0,0,0,2324,2325,5,72,0,0,2325,2326,3,102,
		51,0,2326,2327,3,374,187,0,2327,371,1,0,0,0,2328,2330,5,72,0,0,2329,2331,
		3,334,167,0,2330,2329,1,0,0,0,2330,2331,1,0,0,0,2331,2332,1,0,0,0,2332,
		2333,3,102,51,0,2333,2334,3,374,187,0,2334,373,1,0,0,0,2335,2337,3,376,
		188,0,2336,2338,3,374,187,0,2337,2336,1,0,0,0,2337,2338,1,0,0,0,2338,375,
		1,0,0,0,2339,2340,5,16,0,0,2340,2341,5,84,0,0,2341,2342,3,378,189,0,2342,
		2343,5,85,0,0,2343,2344,3,102,51,0,2344,377,1,0,0,0,2345,2347,3,212,106,
		0,2346,2345,1,0,0,0,2346,2347,1,0,0,0,2347,2348,1,0,0,0,2348,2349,3,152,
		76,0,2349,2350,3,238,119,0,2350,2360,1,0,0,0,2351,2353,3,212,106,0,2352,
		2351,1,0,0,0,2352,2353,1,0,0,0,2353,2354,1,0,0,0,2354,2356,3,152,76,0,
		2355,2357,3,260,130,0,2356,2355,1,0,0,0,2356,2357,1,0,0,0,2357,2360,1,
		0,0,0,2358,2360,5,132,0,0,2359,2346,1,0,0,0,2359,2352,1,0,0,0,2359,2358,
		1,0,0,0,2360,379,1,0,0,0,2361,2363,5,70,0,0,2362,2364,3,88,44,0,2363,2362,
		1,0,0,0,2363,2364,1,0,0,0,2364,381,1,0,0,0,2365,2368,3,384,192,0,2366,
		2368,3,388,194,0,2367,2365,1,0,0,0,2367,2366,1,0,0,0,2368,383,1,0,0,0,
		2369,2370,5,70,0,0,2370,2372,5,84,0,0,2371,2373,3,386,193,0,2372,2371,
		1,0,0,0,2372,2373,1,0,0,0,2373,2374,1,0,0,0,2374,2375,5,85,0,0,2375,385,
		1,0,0,0,2376,2377,6,193,-1,0,2377,2379,3,258,129,0,2378,2380,5,132,0,0,
		2379,2378,1,0,0,0,2379,2380,1,0,0,0,2380,2389,1,0,0,0,2381,2382,10,1,0,
		0,2382,2383,5,123,0,0,2383,2385,3,258,129,0,2384,2386,5,132,0,0,2385,2384,
		1,0,0,0,2385,2386,1,0,0,0,2386,2388,1,0,0,0,2387,2381,1,0,0,0,2388,2391,
		1,0,0,0,2389,2387,1,0,0,0,2389,2390,1,0,0,0,2390,387,1,0,0,0,2391,2389,
		1,0,0,0,2392,2393,5,49,0,0,2393,2394,5,84,0,0,2394,2395,3,94,47,0,2395,
		2396,5,85,0,0,2396,2399,1,0,0,0,2397,2399,5,49,0,0,2398,2392,1,0,0,0,2398,
		2397,1,0,0,0,2399,389,1,0,0,0,2400,2452,5,48,0,0,2401,2452,5,27,0,0,2402,
		2403,5,48,0,0,2403,2404,5,86,0,0,2404,2452,5,87,0,0,2405,2406,5,27,0,0,
		2406,2407,5,86,0,0,2407,2452,5,87,0,0,2408,2452,5,90,0,0,2409,2452,5,91,
		0,0,2410,2452,5,92,0,0,2411,2452,5,93,0,0,2412,2452,5,94,0,0,2413,2452,
		5,95,0,0,2414,2452,5,96,0,0,2415,2452,5,97,0,0,2416,2452,5,98,0,0,2417,
		2452,5,1,0,0,2418,2452,5,2,0,0,2419,2452,5,100,0,0,2420,2452,5,101,0,0,
		2421,2452,5,102,0,0,2422,2452,5,103,0,0,2423,2452,5,104,0,0,2424,2452,
		5,105,0,0,2425,2452,5,106,0,0,2426,2452,5,107,0,0,2427,2452,5,108,0,0,
		2428,2452,5,109,0,0,2429,2452,5,110,0,0,2430,2452,5,111,0,0,2431,2452,
		5,112,0,0,2432,2452,5,114,0,0,2433,2452,5,113,0,0,2434,2452,5,115,0,0,
		2435,2452,5,116,0,0,2436,2452,5,117,0,0,2437,2452,5,118,0,0,2438,2452,
		5,3,0,0,2439,2452,5,4,0,0,2440,2452,5,5,0,0,2441,2452,5,6,0,0,2442,2452,
		5,121,0,0,2443,2452,5,122,0,0,2444,2452,5,123,0,0,2445,2452,5,124,0,0,
		2446,2452,5,125,0,0,2447,2448,5,84,0,0,2448,2452,5,85,0,0,2449,2450,5,
		86,0,0,2450,2452,5,87,0,0,2451,2400,1,0,0,0,2451,2401,1,0,0,0,2451,2402,
		1,0,0,0,2451,2405,1,0,0,0,2451,2408,1,0,0,0,2451,2409,1,0,0,0,2451,2410,
		1,0,0,0,2451,2411,1,0,0,0,2451,2412,1,0,0,0,2451,2413,1,0,0,0,2451,2414,
		1,0,0,0,2451,2415,1,0,0,0,2451,2416,1,0,0,0,2451,2417,1,0,0,0,2451,2418,
		1,0,0,0,2451,2419,1,0,0,0,2451,2420,1,0,0,0,2451,2421,1,0,0,0,2451,2422,
		1,0,0,0,2451,2423,1,0,0,0,2451,2424,1,0,0,0,2451,2425,1,0,0,0,2451,2426,
		1,0,0,0,2451,2427,1,0,0,0,2451,2428,1,0,0,0,2451,2429,1,0,0,0,2451,2430,
		1,0,0,0,2451,2431,1,0,0,0,2451,2432,1,0,0,0,2451,2433,1,0,0,0,2451,2434,
		1,0,0,0,2451,2435,1,0,0,0,2451,2436,1,0,0,0,2451,2437,1,0,0,0,2451,2438,
		1,0,0,0,2451,2439,1,0,0,0,2451,2440,1,0,0,0,2451,2441,1,0,0,0,2451,2442,
		1,0,0,0,2451,2443,1,0,0,0,2451,2444,1,0,0,0,2451,2445,1,0,0,0,2451,2446,
		1,0,0,0,2451,2447,1,0,0,0,2451,2449,1,0,0,0,2452,391,1,0,0,0,2453,2461,
		5,134,0,0,2454,2461,5,140,0,0,2455,2461,5,141,0,0,2456,2461,5,142,0,0,
		2457,2461,3,394,197,0,2458,2461,3,396,198,0,2459,2461,3,398,199,0,2460,
		2453,1,0,0,0,2460,2454,1,0,0,0,2460,2455,1,0,0,0,2460,2456,1,0,0,0,2460,
		2457,1,0,0,0,2460,2458,1,0,0,0,2460,2459,1,0,0,0,2461,393,1,0,0,0,2462,
		2463,7,12,0,0,2463,395,1,0,0,0,2464,2465,5,50,0,0,2465,397,1,0,0,0,2466,
		2467,7,13,0,0,2467,399,1,0,0,0,316,401,413,417,428,432,447,454,459,461,
		466,472,482,489,495,499,504,510,517,523,526,529,532,539,546,598,613,619,
		625,638,640,650,665,671,701,706,710,714,717,721,727,729,737,741,744,751,
		758,762,767,771,774,779,785,798,809,811,826,828,840,842,854,874,876,888,
		890,901,912,923,935,937,949,951,961,969,981,988,992,996,1000,1004,1009,
		1012,1015,1021,1029,1034,1037,1043,1054,1077,1081,1089,1095,1115,1119,
		1132,1136,1139,1146,1154,1164,1175,1187,1197,1202,1209,1212,1217,1222,
		1243,1247,1252,1263,1269,1273,1278,1282,1287,1290,1312,1318,1329,1333,
		1336,1346,1352,1355,1362,1372,1376,1379,1382,1386,1391,1393,1397,1401,
		1410,1423,1431,1437,1443,1447,1450,1459,1468,1476,1487,1493,1504,1507,
		1512,1527,1533,1542,1552,1558,1566,1570,1574,1579,1584,1591,1593,1598,
		1602,1616,1622,1640,1642,1652,1657,1664,1670,1675,1681,1688,1692,1694,
		1696,1703,1706,1709,1712,1717,1721,1724,1728,1732,1737,1740,1742,1746,
		1753,1759,1763,1769,1774,1776,1782,1786,1792,1799,1803,1805,1807,1814,
		1824,1828,1830,1832,1836,1839,1845,1855,1859,1865,1873,1877,1880,1884,
		1889,1892,1895,1899,1904,1914,1921,1926,1930,1935,1941,1945,1951,1957,
		1961,1966,1972,1976,1979,1983,1986,1988,1991,2001,2006,2008,2011,2014,
		2017,2026,2036,2041,2044,2048,2051,2054,2058,2067,2082,2088,2092,2096,
		2100,2104,2108,2112,2116,2119,2123,2134,2138,2145,2149,2154,2159,2166,
		2170,2180,2196,2201,2205,2208,2212,2218,2221,2225,2235,2238,2246,2251,
		2256,2264,2271,2275,2282,2288,2292,2298,2307,2311,2314,2330,2337,2346,
		2352,2356,2359,2363,2367,2372,2379,2385,2389,2398,2451,2460
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
