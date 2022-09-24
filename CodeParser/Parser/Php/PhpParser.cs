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
public partial class PhpParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		SeaWhitespace=1, HtmlText=2, XmlStart=3, PHPStart=4, HtmlScriptOpen=5, 
		HtmlStyleOpen=6, HtmlComment=7, HtmlDtd=8, HtmlOpen=9, Shebang=10, Error=11, 
		XmlText=12, XmlClose=13, PHPStartInside=14, HtmlClose=15, HtmlSlashClose=16, 
		HtmlSlash=17, HtmlEquals=18, HtmlStartQuoteString=19, HtmlStartDoubleQuoteString=20, 
		HtmlHex=21, HtmlDecimal=22, HtmlSpace=23, HtmlName=24, ErrorInside=25, 
		PHPStartInsideQuoteString=26, HtmlEndQuoteString=27, HtmlQuoteString=28, 
		ErrorHtmlQuote=29, PHPStartDoubleQuoteString=30, HtmlEndDoubleQuoteString=31, 
		HtmlDoubleQuoteString=32, ErrorHtmlDoubleQuote=33, ScriptText=34, HtmlScriptClose=35, 
		PHPStartInsideScript=36, StyleBody=37, PHPEnd=38, Whitespace=39, MultiLineComment=40, 
		SingleLineComment=41, ShellStyleComment=42, AttributeStart=43, Abstract=44, 
		Array=45, As=46, BinaryCast=47, BoolType=48, BooleanConstant=49, Break=50, 
		Callable=51, Case=52, Catch=53, Class=54, Clone=55, Const=56, Continue=57, 
		Declare=58, Default=59, Do=60, DoubleCast=61, DoubleType=62, Echo=63, 
		Else=64, ElseIf=65, Empty=66, EndDeclare=67, EndFor=68, EndForeach=69, 
		EndIf=70, EndSwitch=71, EndWhile=72, Eval=73, Exit=74, Extends=75, Final=76, 
		Finally=77, FloatCast=78, For=79, Foreach=80, Function_=81, Global=82, 
		Goto=83, If=84, Implements=85, Import=86, Include=87, IncludeOnce=88, 
		InstanceOf=89, InsteadOf=90, Int8Cast=91, Int16Cast=92, Int64Type=93, 
		IntType=94, Interface=95, IsSet=96, List=97, LogicalAnd=98, LogicalOr=99, 
		LogicalXor=100, Match_=101, Namespace=102, New=103, Null=104, ObjectType=105, 
		Parent_=106, Partial=107, Print=108, Private=109, Protected=110, Public=111, 
		Require=112, RequireOnce=113, Resource=114, Return=115, Static=116, StringType=117, 
		Switch=118, Throw=119, Trait=120, Try=121, Typeof=122, UintCast=123, UnicodeCast=124, 
		Unset=125, Use=126, Var=127, While=128, Yield=129, From=130, LambdaFn=131, 
		Get=132, Set=133, Call=134, CallStatic=135, Constructor=136, Destruct=137, 
		Wakeup=138, Sleep=139, Autoload=140, IsSet__=141, Unset__=142, ToString__=143, 
		Invoke=144, SetState=145, Clone__=146, DebugInfo=147, Namespace__=148, 
		Class__=149, Traic__=150, Function__=151, Method__=152, Line__=153, File__=154, 
		Dir__=155, Spaceship=156, Lgeneric=157, Rgeneric=158, DoubleArrow=159, 
		Inc=160, Dec=161, IsIdentical=162, IsNoidentical=163, IsEqual=164, IsNotEq=165, 
		IsSmallerOrEqual=166, IsGreaterOrEqual=167, PlusEqual=168, MinusEqual=169, 
		MulEqual=170, Pow=171, PowEqual=172, DivEqual=173, Concaequal=174, ModEqual=175, 
		ShiftLeftEqual=176, ShiftRightEqual=177, AndEqual=178, OrEqual=179, XorEqual=180, 
		BooleanOr=181, BooleanAnd=182, NullCoalescing=183, NullCoalescingEqual=184, 
		ShiftLeft=185, ShiftRight=186, DoubleColon=187, ObjectOperator=188, NamespaceSeparator=189, 
		Ellipsis=190, Less=191, Greater=192, Ampersand=193, Pipe=194, Bang=195, 
		Caret=196, Plus=197, Minus=198, Asterisk=199, Percent=200, Divide=201, 
		Tilde=202, SuppressWarnings=203, Dollar=204, Dot=205, QuestionMark=206, 
		OpenRoundBracket=207, CloseRoundBracket=208, OpenSquareBracket=209, CloseSquareBracket=210, 
		OpenCurlyBracket=211, CloseCurlyBracket=212, Comma=213, Colon=214, SemiColon=215, 
		Eq=216, Quote=217, BackQuote=218, VarName=219, Label=220, Octal=221, Decimal=222, 
		Real=223, Hex=224, Binary=225, BackQuoteString=226, SingleQuoteString=227, 
		DoubleQuote=228, StartNowDoc=229, StartHereDoc=230, ErrorPhp=231, CurlyDollar=232, 
		UnicodeEscape=233, StringPart=234, Comment=235, PHPEndSingleLineComment=236, 
		CommentEnd=237, HereDocText=238, XmlText2=239;
	public const int
		RULE_htmlDocument = 0, RULE_inlineHtml = 1, RULE_htmlElement = 2, RULE_scriptText = 3, 
		RULE_phpBlock = 4, RULE_importStatement = 5, RULE_topStatement = 6, RULE_useDeclaration = 7, 
		RULE_useDeclarationContentList = 8, RULE_useDeclarationContent = 9, RULE_namespaceDeclaration = 10, 
		RULE_namespaceStatement = 11, RULE_functionDeclaration = 12, RULE_classDeclaration = 13, 
		RULE_classEntryType = 14, RULE_interfaceList = 15, RULE_typeParameterListInBrackets = 16, 
		RULE_typeParameterList = 17, RULE_typeParameterWithDefaultsList = 18, 
		RULE_typeParameterDecl = 19, RULE_typeParameterWithDefaultDecl = 20, RULE_genericDynamicArgs = 21, 
		RULE_attributes = 22, RULE_attributeGroup = 23, RULE_attribute = 24, RULE_innerStatementList = 25, 
		RULE_innerStatement = 26, RULE_statement = 27, RULE_emptyStatement_ = 28, 
		RULE_blockStatement = 29, RULE_ifStatement = 30, RULE_elseIfStatement = 31, 
		RULE_elseIfColonStatement = 32, RULE_elseStatement = 33, RULE_elseColonStatement = 34, 
		RULE_whileStatement = 35, RULE_doWhileStatement = 36, RULE_forStatement = 37, 
		RULE_forInit = 38, RULE_forUpdate = 39, RULE_switchStatement = 40, RULE_switchBlock = 41, 
		RULE_breakStatement = 42, RULE_continueStatement = 43, RULE_returnStatement = 44, 
		RULE_expressionStatement = 45, RULE_unsetStatement = 46, RULE_foreachStatement = 47, 
		RULE_tryCatchFinally = 48, RULE_catchClause = 49, RULE_finallyStatement = 50, 
		RULE_throwStatement = 51, RULE_gotoStatement = 52, RULE_declareStatement = 53, 
		RULE_inlineHtmlStatement = 54, RULE_declareList = 55, RULE_formalParameterList = 56, 
		RULE_formalParameter = 57, RULE_typeHint = 58, RULE_globalStatement = 59, 
		RULE_globalVar = 60, RULE_echoStatement = 61, RULE_staticVariableStatement = 62, 
		RULE_classStatement = 63, RULE_traitAdaptations = 64, RULE_traitAdaptationStatement = 65, 
		RULE_traitPrecedence = 66, RULE_traitAlias = 67, RULE_traitMethodReference = 68, 
		RULE_baseCtorCall = 69, RULE_methodBody = 70, RULE_propertyModifiers = 71, 
		RULE_memberModifiers = 72, RULE_variableInitializer = 73, RULE_identifierInitializer = 74, 
		RULE_globalConstantDeclaration = 75, RULE_expressionList = 76, RULE_parentheses = 77, 
		RULE_expression = 78, RULE_assignable = 79, RULE_arrayCreation = 80, RULE_lambdaFunctionExpr = 81, 
		RULE_matchExpr = 82, RULE_matchItem = 83, RULE_newExpr = 84, RULE_assignmentOperator = 85, 
		RULE_yieldExpression = 86, RULE_arrayItemList = 87, RULE_arrayItem = 88, 
		RULE_lambdaFunctionUseVars = 89, RULE_lambdaFunctionUseVar = 90, RULE_qualifiedStaticTypeRef = 91, 
		RULE_typeRef = 92, RULE_anonymousClass = 93, RULE_indirectTypeRef = 94, 
		RULE_qualifiedNamespaceName = 95, RULE_namespaceNameList = 96, RULE_namespaceNameTail = 97, 
		RULE_qualifiedNamespaceNameList = 98, RULE_arguments = 99, RULE_actualArgument = 100, 
		RULE_argumentName = 101, RULE_constantInitializer = 102, RULE_constant = 103, 
		RULE_literalConstant = 104, RULE_numericConstant = 105, RULE_classConstant = 106, 
		RULE_stringConstant = 107, RULE_string = 108, RULE_interpolatedStringPart = 109, 
		RULE_chainList = 110, RULE_chain = 111, RULE_chainOrigin = 112, RULE_memberAccess = 113, 
		RULE_functionCall = 114, RULE_functionCallName = 115, RULE_actualArguments = 116, 
		RULE_chainBase = 117, RULE_keyedFieldName = 118, RULE_keyedSimpleFieldName = 119, 
		RULE_keyedVariable = 120, RULE_squareCurlyExpression = 121, RULE_assignmentList = 122, 
		RULE_assignmentListElement = 123, RULE_modifier = 124, RULE_identifier = 125, 
		RULE_memberModifier = 126, RULE_magicConstant = 127, RULE_magicMethod = 128, 
		RULE_primitiveType = 129, RULE_castOperation = 130;
	public static readonly string[] ruleNames = {
		"htmlDocument", "inlineHtml", "htmlElement", "scriptText", "phpBlock", 
		"importStatement", "topStatement", "useDeclaration", "useDeclarationContentList", 
		"useDeclarationContent", "namespaceDeclaration", "namespaceStatement", 
		"functionDeclaration", "classDeclaration", "classEntryType", "interfaceList", 
		"typeParameterListInBrackets", "typeParameterList", "typeParameterWithDefaultsList", 
		"typeParameterDecl", "typeParameterWithDefaultDecl", "genericDynamicArgs", 
		"attributes", "attributeGroup", "attribute", "innerStatementList", "innerStatement", 
		"statement", "emptyStatement_", "blockStatement", "ifStatement", "elseIfStatement", 
		"elseIfColonStatement", "elseStatement", "elseColonStatement", "whileStatement", 
		"doWhileStatement", "forStatement", "forInit", "forUpdate", "switchStatement", 
		"switchBlock", "breakStatement", "continueStatement", "returnStatement", 
		"expressionStatement", "unsetStatement", "foreachStatement", "tryCatchFinally", 
		"catchClause", "finallyStatement", "throwStatement", "gotoStatement", 
		"declareStatement", "inlineHtmlStatement", "declareList", "formalParameterList", 
		"formalParameter", "typeHint", "globalStatement", "globalVar", "echoStatement", 
		"staticVariableStatement", "classStatement", "traitAdaptations", "traitAdaptationStatement", 
		"traitPrecedence", "traitAlias", "traitMethodReference", "baseCtorCall", 
		"methodBody", "propertyModifiers", "memberModifiers", "variableInitializer", 
		"identifierInitializer", "globalConstantDeclaration", "expressionList", 
		"parentheses", "expression", "assignable", "arrayCreation", "lambdaFunctionExpr", 
		"matchExpr", "matchItem", "newExpr", "assignmentOperator", "yieldExpression", 
		"arrayItemList", "arrayItem", "lambdaFunctionUseVars", "lambdaFunctionUseVar", 
		"qualifiedStaticTypeRef", "typeRef", "anonymousClass", "indirectTypeRef", 
		"qualifiedNamespaceName", "namespaceNameList", "namespaceNameTail", "qualifiedNamespaceNameList", 
		"arguments", "actualArgument", "argumentName", "constantInitializer", 
		"constant", "literalConstant", "numericConstant", "classConstant", "stringConstant", 
		"string", "interpolatedStringPart", "chainList", "chain", "chainOrigin", 
		"memberAccess", "functionCall", "functionCallName", "actualArguments", 
		"chainBase", "keyedFieldName", "keyedSimpleFieldName", "keyedVariable", 
		"squareCurlyExpression", "assignmentList", "assignmentListElement", "modifier", 
		"identifier", "memberModifier", "magicConstant", "magicMethod", "primitiveType", 
		"castOperation"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, "'<?xml'", null, null, null, null, null, null, null, 
		null, null, "'?>'", null, null, "'/>'", null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, "'#['", "'abstract'", 
		"'array'", "'as'", "'binary'", null, null, "'break'", "'callable'", "'case'", 
		"'catch'", "'class'", "'clone'", "'const'", "'continue'", "'declare'", 
		"'default'", "'do'", "'real'", "'double'", "'echo'", "'else'", "'elseif'", 
		"'empty'", "'enddeclare'", "'endfor'", "'endforeach'", "'endif'", "'endswitch'", 
		"'endwhile'", "'eval'", "'die'", "'extends'", "'final'", "'finally'", 
		"'float'", "'for'", "'foreach'", "'function'", "'global'", "'goto'", "'if'", 
		"'implements'", "'import'", "'include'", "'include_once'", "'instanceof'", 
		"'insteadof'", "'int8'", "'int16'", "'int64'", null, "'interface'", "'isset'", 
		"'list'", "'and'", "'or'", "'xor'", "'match'", "'namespace'", "'new'", 
		"'null'", "'object'", "'parent'", "'partial'", "'print'", "'private'", 
		"'protected'", "'public'", "'require'", "'require_once'", "'resource'", 
		"'return'", "'static'", "'string'", "'switch'", "'throw'", "'trait'", 
		"'try'", "'clrtypeof'", null, "'unicode'", "'unset'", "'use'", "'var'", 
		"'while'", "'yield'", "'from'", "'fn'", "'__get'", "'__set'", "'__call'", 
		"'__callstatic'", "'__construct'", "'__destruct'", "'__wakeup'", "'__sleep'", 
		"'__autoload'", "'__isset'", "'__unset'", "'__tostring'", "'__invoke'", 
		"'__set_state'", "'__clone'", "'__debuginfo'", "'__namespace__'", "'__class__'", 
		"'__trait__'", "'__function__'", "'__method__'", "'__line__'", "'__file__'", 
		"'__dir__'", "'<=>'", "'<:'", "':>'", "'=>'", "'++'", "'--'", "'==='", 
		"'!=='", "'=='", null, "'<='", "'>='", "'+='", "'-='", "'*='", "'**'", 
		"'**='", "'/='", "'.='", "'%='", "'<<='", "'>>='", "'&='", "'|='", "'^='", 
		"'||'", "'&&'", "'??'", "'??='", "'<<'", "'>>'", "'::'", "'->'", "'\\'", 
		"'...'", null, null, "'&'", "'|'", "'!'", "'^'", "'+'", "'-'", "'*'", 
		"'%'", null, "'~'", "'@'", null, "'.'", null, "'('", "')'", "'['", "']'", 
		null, "'}'", "','", "':'", "';'", null, "'''", "'`'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "SeaWhitespace", "HtmlText", "XmlStart", "PHPStart", "HtmlScriptOpen", 
		"HtmlStyleOpen", "HtmlComment", "HtmlDtd", "HtmlOpen", "Shebang", "Error", 
		"XmlText", "XmlClose", "PHPStartInside", "HtmlClose", "HtmlSlashClose", 
		"HtmlSlash", "HtmlEquals", "HtmlStartQuoteString", "HtmlStartDoubleQuoteString", 
		"HtmlHex", "HtmlDecimal", "HtmlSpace", "HtmlName", "ErrorInside", "PHPStartInsideQuoteString", 
		"HtmlEndQuoteString", "HtmlQuoteString", "ErrorHtmlQuote", "PHPStartDoubleQuoteString", 
		"HtmlEndDoubleQuoteString", "HtmlDoubleQuoteString", "ErrorHtmlDoubleQuote", 
		"ScriptText", "HtmlScriptClose", "PHPStartInsideScript", "StyleBody", 
		"PHPEnd", "Whitespace", "MultiLineComment", "SingleLineComment", "ShellStyleComment", 
		"AttributeStart", "Abstract", "Array", "As", "BinaryCast", "BoolType", 
		"BooleanConstant", "Break", "Callable", "Case", "Catch", "Class", "Clone", 
		"Const", "Continue", "Declare", "Default", "Do", "DoubleCast", "DoubleType", 
		"Echo", "Else", "ElseIf", "Empty", "EndDeclare", "EndFor", "EndForeach", 
		"EndIf", "EndSwitch", "EndWhile", "Eval", "Exit", "Extends", "Final", 
		"Finally", "FloatCast", "For", "Foreach", "Function_", "Global", "Goto", 
		"If", "Implements", "Import", "Include", "IncludeOnce", "InstanceOf", 
		"InsteadOf", "Int8Cast", "Int16Cast", "Int64Type", "IntType", "Interface", 
		"IsSet", "List", "LogicalAnd", "LogicalOr", "LogicalXor", "Match_", "Namespace", 
		"New", "Null", "ObjectType", "Parent_", "Partial", "Print", "Private", 
		"Protected", "Public", "Require", "RequireOnce", "Resource", "Return", 
		"Static", "StringType", "Switch", "Throw", "Trait", "Try", "Typeof", "UintCast", 
		"UnicodeCast", "Unset", "Use", "Var", "While", "Yield", "From", "LambdaFn", 
		"Get", "Set", "Call", "CallStatic", "Constructor", "Destruct", "Wakeup", 
		"Sleep", "Autoload", "IsSet__", "Unset__", "ToString__", "Invoke", "SetState", 
		"Clone__", "DebugInfo", "Namespace__", "Class__", "Traic__", "Function__", 
		"Method__", "Line__", "File__", "Dir__", "Spaceship", "Lgeneric", "Rgeneric", 
		"DoubleArrow", "Inc", "Dec", "IsIdentical", "IsNoidentical", "IsEqual", 
		"IsNotEq", "IsSmallerOrEqual", "IsGreaterOrEqual", "PlusEqual", "MinusEqual", 
		"MulEqual", "Pow", "PowEqual", "DivEqual", "Concaequal", "ModEqual", "ShiftLeftEqual", 
		"ShiftRightEqual", "AndEqual", "OrEqual", "XorEqual", "BooleanOr", "BooleanAnd", 
		"NullCoalescing", "NullCoalescingEqual", "ShiftLeft", "ShiftRight", "DoubleColon", 
		"ObjectOperator", "NamespaceSeparator", "Ellipsis", "Less", "Greater", 
		"Ampersand", "Pipe", "Bang", "Caret", "Plus", "Minus", "Asterisk", "Percent", 
		"Divide", "Tilde", "SuppressWarnings", "Dollar", "Dot", "QuestionMark", 
		"OpenRoundBracket", "CloseRoundBracket", "OpenSquareBracket", "CloseSquareBracket", 
		"OpenCurlyBracket", "CloseCurlyBracket", "Comma", "Colon", "SemiColon", 
		"Eq", "Quote", "BackQuote", "VarName", "Label", "Octal", "Decimal", "Real", 
		"Hex", "Binary", "BackQuoteString", "SingleQuoteString", "DoubleQuote", 
		"StartNowDoc", "StartHereDoc", "ErrorPhp", "CurlyDollar", "UnicodeEscape", 
		"StringPart", "Comment", "PHPEndSingleLineComment", "CommentEnd", "HereDocText", 
		"XmlText2"
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

	public override string GrammarFileName { get { return "PhpParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static PhpParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public PhpParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public PhpParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class HtmlDocumentContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(PhpParser.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Shebang() { return GetToken(PhpParser.Shebang, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InlineHtmlContext[] inlineHtml() {
			return GetRuleContexts<InlineHtmlContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public InlineHtmlContext inlineHtml(int i) {
			return GetRuleContext<InlineHtmlContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PhpBlockContext[] phpBlock() {
			return GetRuleContexts<PhpBlockContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public PhpBlockContext phpBlock(int i) {
			return GetRuleContext<PhpBlockContext>(i);
		}
		public HtmlDocumentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_htmlDocument; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterHtmlDocument(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitHtmlDocument(this);
		}
	}

	[RuleVersion(0)]
	public HtmlDocumentContext htmlDocument() {
		HtmlDocumentContext _localctx = new HtmlDocumentContext(Context, State);
		EnterRule(_localctx, 0, RULE_htmlDocument);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 263;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Shebang) {
				{
				State = 262;
				Match(Shebang);
				}
			}

			State = 269;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << HtmlText) | (1L << XmlStart) | (1L << HtmlScriptOpen) | (1L << HtmlStyleOpen) | (1L << HtmlDtd) | (1L << HtmlOpen) | (1L << HtmlClose) | (1L << HtmlSlashClose) | (1L << HtmlSlash) | (1L << HtmlEquals) | (1L << HtmlStartQuoteString) | (1L << HtmlStartDoubleQuoteString) | (1L << HtmlHex) | (1L << HtmlDecimal) | (1L << HtmlName) | (1L << HtmlEndQuoteString) | (1L << HtmlQuoteString) | (1L << HtmlEndDoubleQuoteString) | (1L << HtmlDoubleQuoteString) | (1L << ScriptText) | (1L << HtmlScriptClose) | (1L << StyleBody) | (1L << AttributeStart) | (1L << Abstract) | (1L << Array) | (1L << As) | (1L << BinaryCast) | (1L << BoolType) | (1L << BooleanConstant) | (1L << Break) | (1L << Callable) | (1L << Case) | (1L << Catch) | (1L << Class) | (1L << Clone) | (1L << Const) | (1L << Continue) | (1L << Declare) | (1L << Default) | (1L << Do) | (1L << DoubleCast) | (1L << DoubleType) | (1L << Echo))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Else - 64)) | (1L << (ElseIf - 64)) | (1L << (Empty - 64)) | (1L << (EndDeclare - 64)) | (1L << (EndFor - 64)) | (1L << (EndForeach - 64)) | (1L << (EndIf - 64)) | (1L << (EndSwitch - 64)) | (1L << (EndWhile - 64)) | (1L << (Eval - 64)) | (1L << (Exit - 64)) | (1L << (Extends - 64)) | (1L << (Final - 64)) | (1L << (Finally - 64)) | (1L << (FloatCast - 64)) | (1L << (For - 64)) | (1L << (Foreach - 64)) | (1L << (Function_ - 64)) | (1L << (Global - 64)) | (1L << (Goto - 64)) | (1L << (If - 64)) | (1L << (Implements - 64)) | (1L << (Import - 64)) | (1L << (Include - 64)) | (1L << (IncludeOnce - 64)) | (1L << (InstanceOf - 64)) | (1L << (InsteadOf - 64)) | (1L << (Int8Cast - 64)) | (1L << (Int16Cast - 64)) | (1L << (Int64Type - 64)) | (1L << (IntType - 64)) | (1L << (Interface - 64)) | (1L << (IsSet - 64)) | (1L << (List - 64)) | (1L << (LogicalAnd - 64)) | (1L << (LogicalOr - 64)) | (1L << (LogicalXor - 64)) | (1L << (Match_ - 64)) | (1L << (Namespace - 64)) | (1L << (New - 64)) | (1L << (Null - 64)) | (1L << (ObjectType - 64)) | (1L << (Parent_ - 64)) | (1L << (Partial - 64)) | (1L << (Print - 64)) | (1L << (Private - 64)) | (1L << (Protected - 64)) | (1L << (Public - 64)) | (1L << (Require - 64)) | (1L << (RequireOnce - 64)) | (1L << (Resource - 64)) | (1L << (Return - 64)) | (1L << (Static - 64)) | (1L << (StringType - 64)) | (1L << (Switch - 64)) | (1L << (Throw - 64)) | (1L << (Trait - 64)) | (1L << (Try - 64)) | (1L << (Typeof - 64)) | (1L << (UintCast - 64)) | (1L << (UnicodeCast - 64)) | (1L << (Unset - 64)) | (1L << (Use - 64)) | (1L << (Var - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (While - 128)) | (1L << (Yield - 128)) | (1L << (From - 128)) | (1L << (LambdaFn - 128)) | (1L << (Get - 128)) | (1L << (Set - 128)) | (1L << (Call - 128)) | (1L << (CallStatic - 128)) | (1L << (Constructor - 128)) | (1L << (Destruct - 128)) | (1L << (Wakeup - 128)) | (1L << (Sleep - 128)) | (1L << (Autoload - 128)) | (1L << (IsSet__ - 128)) | (1L << (Unset__ - 128)) | (1L << (ToString__ - 128)) | (1L << (Invoke - 128)) | (1L << (SetState - 128)) | (1L << (Clone__ - 128)) | (1L << (DebugInfo - 128)) | (1L << (Namespace__ - 128)) | (1L << (Class__ - 128)) | (1L << (Traic__ - 128)) | (1L << (Function__ - 128)) | (1L << (Method__ - 128)) | (1L << (Line__ - 128)) | (1L << (File__ - 128)) | (1L << (Dir__ - 128)) | (1L << (Inc - 128)) | (1L << (Dec - 128)) | (1L << (NamespaceSeparator - 128)))) != 0) || ((((_la - 195)) & ~0x3f) == 0 && ((1L << (_la - 195)) & ((1L << (Bang - 195)) | (1L << (Plus - 195)) | (1L << (Minus - 195)) | (1L << (Tilde - 195)) | (1L << (SuppressWarnings - 195)) | (1L << (Dollar - 195)) | (1L << (OpenRoundBracket - 195)) | (1L << (OpenSquareBracket - 195)) | (1L << (OpenCurlyBracket - 195)) | (1L << (SemiColon - 195)) | (1L << (VarName - 195)) | (1L << (Label - 195)) | (1L << (Octal - 195)) | (1L << (Decimal - 195)) | (1L << (Real - 195)) | (1L << (Hex - 195)) | (1L << (Binary - 195)) | (1L << (BackQuoteString - 195)) | (1L << (SingleQuoteString - 195)) | (1L << (DoubleQuote - 195)) | (1L << (StartNowDoc - 195)) | (1L << (StartHereDoc - 195)))) != 0)) {
				{
				State = 267;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
				case 1:
					{
					State = 265;
					inlineHtml();
					}
					break;
				case 2:
					{
					State = 266;
					phpBlock();
					}
					break;
				}
				}
				State = 271;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 272;
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

	public partial class InlineHtmlContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public HtmlElementContext[] htmlElement() {
			return GetRuleContexts<HtmlElementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public HtmlElementContext htmlElement(int i) {
			return GetRuleContext<HtmlElementContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ScriptTextContext scriptText() {
			return GetRuleContext<ScriptTextContext>(0);
		}
		public InlineHtmlContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_inlineHtml; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterInlineHtml(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitInlineHtml(this);
		}
	}

	[RuleVersion(0)]
	public InlineHtmlContext inlineHtml() {
		InlineHtmlContext _localctx = new InlineHtmlContext(Context, State);
		EnterRule(_localctx, 2, RULE_inlineHtml);
		try {
			int _alt;
			State = 280;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case HtmlText:
			case XmlStart:
			case HtmlScriptOpen:
			case HtmlStyleOpen:
			case HtmlDtd:
			case HtmlOpen:
			case HtmlClose:
			case HtmlSlashClose:
			case HtmlSlash:
			case HtmlEquals:
			case HtmlStartQuoteString:
			case HtmlStartDoubleQuoteString:
			case HtmlHex:
			case HtmlDecimal:
			case HtmlName:
			case HtmlEndQuoteString:
			case HtmlQuoteString:
			case HtmlEndDoubleQuoteString:
			case HtmlDoubleQuoteString:
			case HtmlScriptClose:
			case StyleBody:
				EnterOuterAlt(_localctx, 1);
				{
				State = 275;
				ErrorHandler.Sync(this);
				_alt = 1;
				do {
					switch (_alt) {
					case 1:
						{
						{
						State = 274;
						htmlElement();
						}
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					State = 277;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,3,Context);
				} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
				}
				break;
			case ScriptText:
				EnterOuterAlt(_localctx, 2);
				{
				State = 279;
				scriptText();
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

	public partial class HtmlElementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlDtd() { return GetToken(PhpParser.HtmlDtd, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlClose() { return GetToken(PhpParser.HtmlClose, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlStyleOpen() { return GetToken(PhpParser.HtmlStyleOpen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlOpen() { return GetToken(PhpParser.HtmlOpen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlName() { return GetToken(PhpParser.HtmlName, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlSlashClose() { return GetToken(PhpParser.HtmlSlashClose, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlSlash() { return GetToken(PhpParser.HtmlSlash, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlText() { return GetToken(PhpParser.HtmlText, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlEquals() { return GetToken(PhpParser.HtmlEquals, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlStartQuoteString() { return GetToken(PhpParser.HtmlStartQuoteString, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlEndQuoteString() { return GetToken(PhpParser.HtmlEndQuoteString, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlStartDoubleQuoteString() { return GetToken(PhpParser.HtmlStartDoubleQuoteString, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlEndDoubleQuoteString() { return GetToken(PhpParser.HtmlEndDoubleQuoteString, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlHex() { return GetToken(PhpParser.HtmlHex, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlDecimal() { return GetToken(PhpParser.HtmlDecimal, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlQuoteString() { return GetToken(PhpParser.HtmlQuoteString, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlDoubleQuoteString() { return GetToken(PhpParser.HtmlDoubleQuoteString, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode StyleBody() { return GetToken(PhpParser.StyleBody, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlScriptOpen() { return GetToken(PhpParser.HtmlScriptOpen, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HtmlScriptClose() { return GetToken(PhpParser.HtmlScriptClose, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode XmlStart() { return GetToken(PhpParser.XmlStart, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode XmlClose() { return GetToken(PhpParser.XmlClose, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] XmlText() { return GetTokens(PhpParser.XmlText); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode XmlText(int i) {
			return GetToken(PhpParser.XmlText, i);
		}
		public HtmlElementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_htmlElement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterHtmlElement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitHtmlElement(this);
		}
	}

	[RuleVersion(0)]
	public HtmlElementContext htmlElement() {
		HtmlElementContext _localctx = new HtmlElementContext(Context, State);
		EnterRule(_localctx, 4, RULE_htmlElement);
		int _la;
		try {
			State = 310;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case HtmlDtd:
				EnterOuterAlt(_localctx, 1);
				{
				State = 282;
				Match(HtmlDtd);
				}
				break;
			case HtmlClose:
				EnterOuterAlt(_localctx, 2);
				{
				State = 283;
				Match(HtmlClose);
				}
				break;
			case HtmlStyleOpen:
				EnterOuterAlt(_localctx, 3);
				{
				State = 284;
				Match(HtmlStyleOpen);
				}
				break;
			case HtmlOpen:
				EnterOuterAlt(_localctx, 4);
				{
				State = 285;
				Match(HtmlOpen);
				}
				break;
			case HtmlName:
				EnterOuterAlt(_localctx, 5);
				{
				State = 286;
				Match(HtmlName);
				}
				break;
			case HtmlSlashClose:
				EnterOuterAlt(_localctx, 6);
				{
				State = 287;
				Match(HtmlSlashClose);
				}
				break;
			case HtmlSlash:
				EnterOuterAlt(_localctx, 7);
				{
				State = 288;
				Match(HtmlSlash);
				}
				break;
			case HtmlText:
				EnterOuterAlt(_localctx, 8);
				{
				State = 289;
				Match(HtmlText);
				}
				break;
			case HtmlEquals:
				EnterOuterAlt(_localctx, 9);
				{
				State = 290;
				Match(HtmlEquals);
				}
				break;
			case HtmlStartQuoteString:
				EnterOuterAlt(_localctx, 10);
				{
				State = 291;
				Match(HtmlStartQuoteString);
				}
				break;
			case HtmlEndQuoteString:
				EnterOuterAlt(_localctx, 11);
				{
				State = 292;
				Match(HtmlEndQuoteString);
				}
				break;
			case HtmlStartDoubleQuoteString:
				EnterOuterAlt(_localctx, 12);
				{
				State = 293;
				Match(HtmlStartDoubleQuoteString);
				}
				break;
			case HtmlEndDoubleQuoteString:
				EnterOuterAlt(_localctx, 13);
				{
				State = 294;
				Match(HtmlEndDoubleQuoteString);
				}
				break;
			case HtmlHex:
				EnterOuterAlt(_localctx, 14);
				{
				State = 295;
				Match(HtmlHex);
				}
				break;
			case HtmlDecimal:
				EnterOuterAlt(_localctx, 15);
				{
				State = 296;
				Match(HtmlDecimal);
				}
				break;
			case HtmlQuoteString:
				EnterOuterAlt(_localctx, 16);
				{
				State = 297;
				Match(HtmlQuoteString);
				}
				break;
			case HtmlDoubleQuoteString:
				EnterOuterAlt(_localctx, 17);
				{
				State = 298;
				Match(HtmlDoubleQuoteString);
				}
				break;
			case StyleBody:
				EnterOuterAlt(_localctx, 18);
				{
				State = 299;
				Match(StyleBody);
				}
				break;
			case HtmlScriptOpen:
				EnterOuterAlt(_localctx, 19);
				{
				State = 300;
				Match(HtmlScriptOpen);
				}
				break;
			case HtmlScriptClose:
				EnterOuterAlt(_localctx, 20);
				{
				State = 301;
				Match(HtmlScriptClose);
				}
				break;
			case XmlStart:
				EnterOuterAlt(_localctx, 21);
				{
				State = 302;
				Match(XmlStart);
				State = 306;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==XmlText) {
					{
					{
					State = 303;
					Match(XmlText);
					}
					}
					State = 308;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 309;
				Match(XmlClose);
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

	public partial class ScriptTextContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ScriptText() { return GetTokens(PhpParser.ScriptText); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ScriptText(int i) {
			return GetToken(PhpParser.ScriptText, i);
		}
		public ScriptTextContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_scriptText; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterScriptText(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitScriptText(this);
		}
	}

	[RuleVersion(0)]
	public ScriptTextContext scriptText() {
		ScriptTextContext _localctx = new ScriptTextContext(Context, State);
		EnterRule(_localctx, 6, RULE_scriptText);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 313;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 312;
					Match(ScriptText);
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 315;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
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

	public partial class PhpBlockContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ImportStatementContext[] importStatement() {
			return GetRuleContexts<ImportStatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ImportStatementContext importStatement(int i) {
			return GetRuleContext<ImportStatementContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TopStatementContext[] topStatement() {
			return GetRuleContexts<TopStatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TopStatementContext topStatement(int i) {
			return GetRuleContext<TopStatementContext>(i);
		}
		public PhpBlockContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_phpBlock; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterPhpBlock(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitPhpBlock(this);
		}
	}

	[RuleVersion(0)]
	public PhpBlockContext phpBlock() {
		PhpBlockContext _localctx = new PhpBlockContext(Context, State);
		EnterRule(_localctx, 8, RULE_phpBlock);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 320;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,8,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 317;
					importStatement();
					}
					} 
				}
				State = 322;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,8,Context);
			}
			State = 324;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 323;
					topStatement();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 326;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,9,Context);
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

	public partial class ImportStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Import() { return GetToken(PhpParser.Import, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Namespace() { return GetToken(PhpParser.Namespace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NamespaceNameListContext namespaceNameList() {
			return GetRuleContext<NamespaceNameListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		public ImportStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_importStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterImportStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitImportStatement(this);
		}
	}

	[RuleVersion(0)]
	public ImportStatementContext importStatement() {
		ImportStatementContext _localctx = new ImportStatementContext(Context, State);
		EnterRule(_localctx, 10, RULE_importStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 328;
			Match(Import);
			State = 329;
			Match(Namespace);
			State = 330;
			namespaceNameList();
			State = 331;
			Match(SemiColon);
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

	public partial class TopStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UseDeclarationContext useDeclaration() {
			return GetRuleContext<UseDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NamespaceDeclarationContext namespaceDeclaration() {
			return GetRuleContext<NamespaceDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FunctionDeclarationContext functionDeclaration() {
			return GetRuleContext<FunctionDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassDeclarationContext classDeclaration() {
			return GetRuleContext<ClassDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public GlobalConstantDeclarationContext globalConstantDeclaration() {
			return GetRuleContext<GlobalConstantDeclarationContext>(0);
		}
		public TopStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_topStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterTopStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitTopStatement(this);
		}
	}

	[RuleVersion(0)]
	public TopStatementContext topStatement() {
		TopStatementContext _localctx = new TopStatementContext(Context, State);
		EnterRule(_localctx, 12, RULE_topStatement);
		try {
			State = 339;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,10,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 333;
				statement();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 334;
				useDeclaration();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 335;
				namespaceDeclaration();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 336;
				functionDeclaration();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 337;
				classDeclaration();
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 338;
				globalConstantDeclaration();
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

	public partial class UseDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Use() { return GetToken(PhpParser.Use, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public UseDeclarationContentListContext useDeclarationContentList() {
			return GetRuleContext<UseDeclarationContentListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Function_() { return GetToken(PhpParser.Function_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Const() { return GetToken(PhpParser.Const, 0); }
		public UseDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_useDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterUseDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitUseDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public UseDeclarationContext useDeclaration() {
		UseDeclarationContext _localctx = new UseDeclarationContext(Context, State);
		EnterRule(_localctx, 14, RULE_useDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 341;
			Match(Use);
			State = 343;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,11,Context) ) {
			case 1:
				{
				State = 342;
				_la = TokenStream.LA(1);
				if ( !(_la==Const || _la==Function_) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
				break;
			}
			State = 345;
			useDeclarationContentList();
			State = 346;
			Match(SemiColon);
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

	public partial class UseDeclarationContentListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UseDeclarationContentContext[] useDeclarationContent() {
			return GetRuleContexts<UseDeclarationContentContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public UseDeclarationContentContext useDeclarationContent(int i) {
			return GetRuleContext<UseDeclarationContentContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] NamespaceSeparator() { return GetTokens(PhpParser.NamespaceSeparator); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NamespaceSeparator(int i) {
			return GetToken(PhpParser.NamespaceSeparator, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public UseDeclarationContentListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_useDeclarationContentList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterUseDeclarationContentList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitUseDeclarationContentList(this);
		}
	}

	[RuleVersion(0)]
	public UseDeclarationContentListContext useDeclarationContentList() {
		UseDeclarationContentListContext _localctx = new UseDeclarationContentListContext(Context, State);
		EnterRule(_localctx, 16, RULE_useDeclarationContentList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 349;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==NamespaceSeparator) {
				{
				State = 348;
				Match(NamespaceSeparator);
				}
			}

			State = 351;
			useDeclarationContent();
			State = 359;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 352;
				Match(Comma);
				State = 354;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==NamespaceSeparator) {
					{
					State = 353;
					Match(NamespaceSeparator);
					}
				}

				State = 356;
				useDeclarationContent();
				}
				}
				State = 361;
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

	public partial class UseDeclarationContentContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public NamespaceNameListContext namespaceNameList() {
			return GetRuleContext<NamespaceNameListContext>(0);
		}
		public UseDeclarationContentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_useDeclarationContent; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterUseDeclarationContent(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitUseDeclarationContent(this);
		}
	}

	[RuleVersion(0)]
	public UseDeclarationContentContext useDeclarationContent() {
		UseDeclarationContentContext _localctx = new UseDeclarationContentContext(Context, State);
		EnterRule(_localctx, 18, RULE_useDeclarationContent);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 362;
			namespaceNameList();
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

	public partial class NamespaceDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Namespace() { return GetToken(PhpParser.Namespace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenCurlyBracket() { return GetToken(PhpParser.OpenCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseCurlyBracket() { return GetToken(PhpParser.CloseCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NamespaceNameListContext namespaceNameList() {
			return GetRuleContext<NamespaceNameListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NamespaceStatementContext[] namespaceStatement() {
			return GetRuleContexts<NamespaceStatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public NamespaceStatementContext namespaceStatement(int i) {
			return GetRuleContext<NamespaceStatementContext>(i);
		}
		public NamespaceDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namespaceDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterNamespaceDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitNamespaceDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public NamespaceDeclarationContext namespaceDeclaration() {
		NamespaceDeclarationContext _localctx = new NamespaceDeclarationContext(Context, State);
		EnterRule(_localctx, 20, RULE_namespaceDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 364;
			Match(Namespace);
			State = 379;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,17,Context) ) {
			case 1:
				{
				State = 366;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)))) != 0) || _la==Label) {
					{
					State = 365;
					namespaceNameList();
					}
				}

				State = 368;
				Match(OpenCurlyBracket);
				State = 372;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << HtmlText) | (1L << XmlStart) | (1L << HtmlScriptOpen) | (1L << HtmlStyleOpen) | (1L << HtmlDtd) | (1L << HtmlOpen) | (1L << HtmlClose) | (1L << HtmlSlashClose) | (1L << HtmlSlash) | (1L << HtmlEquals) | (1L << HtmlStartQuoteString) | (1L << HtmlStartDoubleQuoteString) | (1L << HtmlHex) | (1L << HtmlDecimal) | (1L << HtmlName) | (1L << HtmlEndQuoteString) | (1L << HtmlQuoteString) | (1L << HtmlEndDoubleQuoteString) | (1L << HtmlDoubleQuoteString) | (1L << ScriptText) | (1L << HtmlScriptClose) | (1L << StyleBody) | (1L << AttributeStart) | (1L << Abstract) | (1L << Array) | (1L << As) | (1L << BinaryCast) | (1L << BoolType) | (1L << BooleanConstant) | (1L << Break) | (1L << Callable) | (1L << Case) | (1L << Catch) | (1L << Class) | (1L << Clone) | (1L << Const) | (1L << Continue) | (1L << Declare) | (1L << Default) | (1L << Do) | (1L << DoubleCast) | (1L << DoubleType) | (1L << Echo))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (Else - 64)) | (1L << (ElseIf - 64)) | (1L << (Empty - 64)) | (1L << (EndDeclare - 64)) | (1L << (EndFor - 64)) | (1L << (EndForeach - 64)) | (1L << (EndIf - 64)) | (1L << (EndSwitch - 64)) | (1L << (EndWhile - 64)) | (1L << (Eval - 64)) | (1L << (Exit - 64)) | (1L << (Extends - 64)) | (1L << (Final - 64)) | (1L << (Finally - 64)) | (1L << (FloatCast - 64)) | (1L << (For - 64)) | (1L << (Foreach - 64)) | (1L << (Function_ - 64)) | (1L << (Global - 64)) | (1L << (Goto - 64)) | (1L << (If - 64)) | (1L << (Implements - 64)) | (1L << (Import - 64)) | (1L << (Include - 64)) | (1L << (IncludeOnce - 64)) | (1L << (InstanceOf - 64)) | (1L << (InsteadOf - 64)) | (1L << (Int8Cast - 64)) | (1L << (Int16Cast - 64)) | (1L << (Int64Type - 64)) | (1L << (IntType - 64)) | (1L << (Interface - 64)) | (1L << (IsSet - 64)) | (1L << (List - 64)) | (1L << (LogicalAnd - 64)) | (1L << (LogicalOr - 64)) | (1L << (LogicalXor - 64)) | (1L << (Match_ - 64)) | (1L << (Namespace - 64)) | (1L << (New - 64)) | (1L << (Null - 64)) | (1L << (ObjectType - 64)) | (1L << (Parent_ - 64)) | (1L << (Partial - 64)) | (1L << (Print - 64)) | (1L << (Private - 64)) | (1L << (Protected - 64)) | (1L << (Public - 64)) | (1L << (Require - 64)) | (1L << (RequireOnce - 64)) | (1L << (Resource - 64)) | (1L << (Return - 64)) | (1L << (Static - 64)) | (1L << (StringType - 64)) | (1L << (Switch - 64)) | (1L << (Throw - 64)) | (1L << (Trait - 64)) | (1L << (Try - 64)) | (1L << (Typeof - 64)) | (1L << (UintCast - 64)) | (1L << (UnicodeCast - 64)) | (1L << (Unset - 64)) | (1L << (Use - 64)) | (1L << (Var - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (While - 128)) | (1L << (Yield - 128)) | (1L << (From - 128)) | (1L << (LambdaFn - 128)) | (1L << (Get - 128)) | (1L << (Set - 128)) | (1L << (Call - 128)) | (1L << (CallStatic - 128)) | (1L << (Constructor - 128)) | (1L << (Destruct - 128)) | (1L << (Wakeup - 128)) | (1L << (Sleep - 128)) | (1L << (Autoload - 128)) | (1L << (IsSet__ - 128)) | (1L << (Unset__ - 128)) | (1L << (ToString__ - 128)) | (1L << (Invoke - 128)) | (1L << (SetState - 128)) | (1L << (Clone__ - 128)) | (1L << (DebugInfo - 128)) | (1L << (Namespace__ - 128)) | (1L << (Class__ - 128)) | (1L << (Traic__ - 128)) | (1L << (Function__ - 128)) | (1L << (Method__ - 128)) | (1L << (Line__ - 128)) | (1L << (File__ - 128)) | (1L << (Dir__ - 128)) | (1L << (Inc - 128)) | (1L << (Dec - 128)) | (1L << (NamespaceSeparator - 128)))) != 0) || ((((_la - 195)) & ~0x3f) == 0 && ((1L << (_la - 195)) & ((1L << (Bang - 195)) | (1L << (Plus - 195)) | (1L << (Minus - 195)) | (1L << (Tilde - 195)) | (1L << (SuppressWarnings - 195)) | (1L << (Dollar - 195)) | (1L << (OpenRoundBracket - 195)) | (1L << (OpenSquareBracket - 195)) | (1L << (OpenCurlyBracket - 195)) | (1L << (SemiColon - 195)) | (1L << (VarName - 195)) | (1L << (Label - 195)) | (1L << (Octal - 195)) | (1L << (Decimal - 195)) | (1L << (Real - 195)) | (1L << (Hex - 195)) | (1L << (Binary - 195)) | (1L << (BackQuoteString - 195)) | (1L << (SingleQuoteString - 195)) | (1L << (DoubleQuote - 195)) | (1L << (StartNowDoc - 195)) | (1L << (StartHereDoc - 195)))) != 0)) {
					{
					{
					State = 369;
					namespaceStatement();
					}
					}
					State = 374;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 375;
				Match(CloseCurlyBracket);
				}
				break;
			case 2:
				{
				State = 376;
				namespaceNameList();
				State = 377;
				Match(SemiColon);
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

	public partial class NamespaceStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UseDeclarationContext useDeclaration() {
			return GetRuleContext<UseDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FunctionDeclarationContext functionDeclaration() {
			return GetRuleContext<FunctionDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassDeclarationContext classDeclaration() {
			return GetRuleContext<ClassDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public GlobalConstantDeclarationContext globalConstantDeclaration() {
			return GetRuleContext<GlobalConstantDeclarationContext>(0);
		}
		public NamespaceStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namespaceStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterNamespaceStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitNamespaceStatement(this);
		}
	}

	[RuleVersion(0)]
	public NamespaceStatementContext namespaceStatement() {
		NamespaceStatementContext _localctx = new NamespaceStatementContext(Context, State);
		EnterRule(_localctx, 22, RULE_namespaceStatement);
		try {
			State = 386;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,18,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 381;
				statement();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 382;
				useDeclaration();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 383;
				functionDeclaration();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 384;
				classDeclaration();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 385;
				globalConstantDeclaration();
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

	public partial class FunctionDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Function_() { return GetToken(PhpParser.Function_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenRoundBracket() { return GetToken(PhpParser.OpenRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public FormalParameterListContext formalParameterList() {
			return GetRuleContext<FormalParameterListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseRoundBracket() { return GetToken(PhpParser.CloseRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockStatementContext blockStatement() {
			return GetRuleContext<BlockStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ampersand() { return GetToken(PhpParser.Ampersand, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeParameterListInBracketsContext typeParameterListInBrackets() {
			return GetRuleContext<TypeParameterListInBracketsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(PhpParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeHintContext typeHint() {
			return GetRuleContext<TypeHintContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode QuestionMark() { return GetToken(PhpParser.QuestionMark, 0); }
		public FunctionDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_functionDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterFunctionDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitFunctionDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public FunctionDeclarationContext functionDeclaration() {
		FunctionDeclarationContext _localctx = new FunctionDeclarationContext(Context, State);
		EnterRule(_localctx, 24, RULE_functionDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 389;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==AttributeStart) {
				{
				State = 388;
				attributes();
				}
			}

			State = 391;
			Match(Function_);
			State = 393;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Ampersand) {
				{
				State = 392;
				Match(Ampersand);
				}
			}

			State = 395;
			identifier();
			State = 397;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Lgeneric) {
				{
				State = 396;
				typeParameterListInBrackets();
				}
			}

			State = 399;
			Match(OpenRoundBracket);
			State = 400;
			formalParameterList();
			State = 401;
			Match(CloseRoundBracket);
			State = 407;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Colon) {
				{
				State = 402;
				Match(Colon);
				State = 404;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==QuestionMark) {
					{
					State = 403;
					Match(QuestionMark);
					}
				}

				State = 406;
				typeHint(0);
				}
			}

			State = 409;
			blockStatement();
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

	public partial class ClassDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenCurlyBracket() { return GetToken(PhpParser.OpenCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseCurlyBracket() { return GetToken(PhpParser.CloseCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ClassEntryTypeContext classEntryType() {
			return GetRuleContext<ClassEntryTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Interface() { return GetToken(PhpParser.Interface, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Private() { return GetToken(PhpParser.Private, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ModifierContext modifier() {
			return GetRuleContext<ModifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Partial() { return GetToken(PhpParser.Partial, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ClassStatementContext[] classStatement() {
			return GetRuleContexts<ClassStatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassStatementContext classStatement(int i) {
			return GetRuleContext<ClassStatementContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeParameterListInBracketsContext typeParameterListInBrackets() {
			return GetRuleContext<TypeParameterListInBracketsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Extends() { return GetToken(PhpParser.Extends, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedStaticTypeRefContext qualifiedStaticTypeRef() {
			return GetRuleContext<QualifiedStaticTypeRefContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Implements() { return GetToken(PhpParser.Implements, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceListContext interfaceList() {
			return GetRuleContext<InterfaceListContext>(0);
		}
		public ClassDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterClassDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitClassDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public ClassDeclarationContext classDeclaration() {
		ClassDeclarationContext _localctx = new ClassDeclarationContext(Context, State);
		EnterRule(_localctx, 26, RULE_classDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 412;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==AttributeStart) {
				{
				State = 411;
				attributes();
				}
			}

			State = 415;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Private) {
				{
				State = 414;
				Match(Private);
				}
			}

			State = 418;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Abstract || _la==Final) {
				{
				State = 417;
				modifier();
				}
			}

			State = 421;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Partial) {
				{
				State = 420;
				Match(Partial);
				}
			}

			State = 445;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Class:
			case Trait:
				{
				State = 423;
				classEntryType();
				State = 424;
				identifier();
				State = 426;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Lgeneric) {
					{
					State = 425;
					typeParameterListInBrackets();
					}
				}

				State = 430;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Extends) {
					{
					State = 428;
					Match(Extends);
					State = 429;
					qualifiedStaticTypeRef();
					}
				}

				State = 434;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Implements) {
					{
					State = 432;
					Match(Implements);
					State = 433;
					interfaceList();
					}
				}

				}
				break;
			case Interface:
				{
				State = 436;
				Match(Interface);
				State = 437;
				identifier();
				State = 439;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Lgeneric) {
					{
					State = 438;
					typeParameterListInBrackets();
					}
				}

				State = 443;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Extends) {
					{
					State = 441;
					Match(Extends);
					State = 442;
					interfaceList();
					}
				}

				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 447;
			Match(OpenCurlyBracket);
			State = 451;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << AttributeStart) | (1L << Abstract) | (1L << Const))) != 0) || ((((_la - 76)) & ~0x3f) == 0 && ((1L << (_la - 76)) & ((1L << (Final - 76)) | (1L << (Function_ - 76)) | (1L << (Private - 76)) | (1L << (Protected - 76)) | (1L << (Public - 76)) | (1L << (Static - 76)) | (1L << (Use - 76)) | (1L << (Var - 76)))) != 0)) {
				{
				{
				State = 448;
				classStatement();
				}
				}
				State = 453;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 454;
			Match(CloseCurlyBracket);
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

	public partial class ClassEntryTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Class() { return GetToken(PhpParser.Class, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Trait() { return GetToken(PhpParser.Trait, 0); }
		public ClassEntryTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classEntryType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterClassEntryType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitClassEntryType(this);
		}
	}

	[RuleVersion(0)]
	public ClassEntryTypeContext classEntryType() {
		ClassEntryTypeContext _localctx = new ClassEntryTypeContext(Context, State);
		EnterRule(_localctx, 28, RULE_classEntryType);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 456;
			_la = TokenStream.LA(1);
			if ( !(_la==Class || _la==Trait) ) {
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

	public partial class InterfaceListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedStaticTypeRefContext[] qualifiedStaticTypeRef() {
			return GetRuleContexts<QualifiedStaticTypeRefContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedStaticTypeRefContext qualifiedStaticTypeRef(int i) {
			return GetRuleContext<QualifiedStaticTypeRefContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public InterfaceListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interfaceList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterInterfaceList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitInterfaceList(this);
		}
	}

	[RuleVersion(0)]
	public InterfaceListContext interfaceList() {
		InterfaceListContext _localctx = new InterfaceListContext(Context, State);
		EnterRule(_localctx, 30, RULE_interfaceList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 458;
			qualifiedStaticTypeRef();
			State = 463;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 459;
				Match(Comma);
				State = 460;
				qualifiedStaticTypeRef();
				}
				}
				State = 465;
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

	public partial class TypeParameterListInBracketsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Lgeneric() { return GetToken(PhpParser.Lgeneric, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeParameterListContext typeParameterList() {
			return GetRuleContext<TypeParameterListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Rgeneric() { return GetToken(PhpParser.Rgeneric, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeParameterWithDefaultsListContext typeParameterWithDefaultsList() {
			return GetRuleContext<TypeParameterWithDefaultsListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(PhpParser.Comma, 0); }
		public TypeParameterListInBracketsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeParameterListInBrackets; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterTypeParameterListInBrackets(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitTypeParameterListInBrackets(this);
		}
	}

	[RuleVersion(0)]
	public TypeParameterListInBracketsContext typeParameterListInBrackets() {
		TypeParameterListInBracketsContext _localctx = new TypeParameterListInBracketsContext(Context, State);
		EnterRule(_localctx, 32, RULE_typeParameterListInBrackets);
		try {
			State = 480;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,36,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 466;
				Match(Lgeneric);
				State = 467;
				typeParameterList();
				State = 468;
				Match(Rgeneric);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 470;
				Match(Lgeneric);
				State = 471;
				typeParameterWithDefaultsList();
				State = 472;
				Match(Rgeneric);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 474;
				Match(Lgeneric);
				State = 475;
				typeParameterList();
				State = 476;
				Match(Comma);
				State = 477;
				typeParameterWithDefaultsList();
				State = 478;
				Match(Rgeneric);
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

	public partial class TypeParameterListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TypeParameterDeclContext[] typeParameterDecl() {
			return GetRuleContexts<TypeParameterDeclContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeParameterDeclContext typeParameterDecl(int i) {
			return GetRuleContext<TypeParameterDeclContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public TypeParameterListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeParameterList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterTypeParameterList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitTypeParameterList(this);
		}
	}

	[RuleVersion(0)]
	public TypeParameterListContext typeParameterList() {
		TypeParameterListContext _localctx = new TypeParameterListContext(Context, State);
		EnterRule(_localctx, 34, RULE_typeParameterList);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 482;
			typeParameterDecl();
			State = 487;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,37,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 483;
					Match(Comma);
					State = 484;
					typeParameterDecl();
					}
					} 
				}
				State = 489;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,37,Context);
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

	public partial class TypeParameterWithDefaultsListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TypeParameterWithDefaultDeclContext[] typeParameterWithDefaultDecl() {
			return GetRuleContexts<TypeParameterWithDefaultDeclContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeParameterWithDefaultDeclContext typeParameterWithDefaultDecl(int i) {
			return GetRuleContext<TypeParameterWithDefaultDeclContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public TypeParameterWithDefaultsListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeParameterWithDefaultsList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterTypeParameterWithDefaultsList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitTypeParameterWithDefaultsList(this);
		}
	}

	[RuleVersion(0)]
	public TypeParameterWithDefaultsListContext typeParameterWithDefaultsList() {
		TypeParameterWithDefaultsListContext _localctx = new TypeParameterWithDefaultsListContext(Context, State);
		EnterRule(_localctx, 36, RULE_typeParameterWithDefaultsList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 490;
			typeParameterWithDefaultDecl();
			State = 495;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 491;
				Match(Comma);
				State = 492;
				typeParameterWithDefaultDecl();
				}
				}
				State = 497;
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

	public partial class TypeParameterDeclContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		public TypeParameterDeclContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeParameterDecl; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterTypeParameterDecl(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitTypeParameterDecl(this);
		}
	}

	[RuleVersion(0)]
	public TypeParameterDeclContext typeParameterDecl() {
		TypeParameterDeclContext _localctx = new TypeParameterDeclContext(Context, State);
		EnterRule(_localctx, 38, RULE_typeParameterDecl);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 499;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==AttributeStart) {
				{
				State = 498;
				attributes();
				}
			}

			State = 501;
			identifier();
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

	public partial class TypeParameterWithDefaultDeclContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eq() { return GetToken(PhpParser.Eq, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedStaticTypeRefContext qualifiedStaticTypeRef() {
			return GetRuleContext<QualifiedStaticTypeRefContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PrimitiveTypeContext primitiveType() {
			return GetRuleContext<PrimitiveTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		public TypeParameterWithDefaultDeclContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeParameterWithDefaultDecl; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterTypeParameterWithDefaultDecl(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitTypeParameterWithDefaultDecl(this);
		}
	}

	[RuleVersion(0)]
	public TypeParameterWithDefaultDeclContext typeParameterWithDefaultDecl() {
		TypeParameterWithDefaultDeclContext _localctx = new TypeParameterWithDefaultDeclContext(Context, State);
		EnterRule(_localctx, 40, RULE_typeParameterWithDefaultDecl);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 504;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==AttributeStart) {
				{
				State = 503;
				attributes();
				}
			}

			State = 506;
			identifier();
			State = 507;
			Match(Eq);
			State = 510;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,41,Context) ) {
			case 1:
				{
				State = 508;
				qualifiedStaticTypeRef();
				}
				break;
			case 2:
				{
				State = 509;
				primitiveType();
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

	public partial class GenericDynamicArgsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Lgeneric() { return GetToken(PhpParser.Lgeneric, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeRefContext[] typeRef() {
			return GetRuleContexts<TypeRefContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeRefContext typeRef(int i) {
			return GetRuleContext<TypeRefContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Rgeneric() { return GetToken(PhpParser.Rgeneric, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public GenericDynamicArgsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_genericDynamicArgs; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterGenericDynamicArgs(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitGenericDynamicArgs(this);
		}
	}

	[RuleVersion(0)]
	public GenericDynamicArgsContext genericDynamicArgs() {
		GenericDynamicArgsContext _localctx = new GenericDynamicArgsContext(Context, State);
		EnterRule(_localctx, 42, RULE_genericDynamicArgs);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 512;
			Match(Lgeneric);
			State = 513;
			typeRef();
			State = 518;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 514;
				Match(Comma);
				State = 515;
				typeRef();
				}
				}
				State = 520;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 521;
			Match(Rgeneric);
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

	public partial class AttributesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AttributeGroupContext[] attributeGroup() {
			return GetRuleContexts<AttributeGroupContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributeGroupContext attributeGroup(int i) {
			return GetRuleContext<AttributeGroupContext>(i);
		}
		public AttributesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attributes; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterAttributes(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitAttributes(this);
		}
	}

	[RuleVersion(0)]
	public AttributesContext attributes() {
		AttributesContext _localctx = new AttributesContext(Context, State);
		EnterRule(_localctx, 44, RULE_attributes);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 524;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 523;
				attributeGroup();
				}
				}
				State = 526;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==AttributeStart );
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

	public partial class AttributeGroupContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AttributeStart() { return GetToken(PhpParser.AttributeStart, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AttributeContext[] attribute() {
			return GetRuleContexts<AttributeContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributeContext attribute(int i) {
			return GetRuleContext<AttributeContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseSquareBracket() { return GetToken(PhpParser.CloseSquareBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(PhpParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public AttributeGroupContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attributeGroup; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterAttributeGroup(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitAttributeGroup(this);
		}
	}

	[RuleVersion(0)]
	public AttributeGroupContext attributeGroup() {
		AttributeGroupContext _localctx = new AttributeGroupContext(Context, State);
		EnterRule(_localctx, 46, RULE_attributeGroup);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 528;
			Match(AttributeStart);
			State = 532;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,44,Context) ) {
			case 1:
				{
				State = 529;
				identifier();
				State = 530;
				Match(Colon);
				}
				break;
			}
			State = 534;
			attribute();
			State = 539;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 535;
				Match(Comma);
				State = 536;
				attribute();
				}
				}
				State = 541;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 542;
			Match(CloseSquareBracket);
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

	public partial class AttributeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedNamespaceNameContext qualifiedNamespaceName() {
			return GetRuleContext<QualifiedNamespaceNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentsContext arguments() {
			return GetRuleContext<ArgumentsContext>(0);
		}
		public AttributeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attribute; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterAttribute(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitAttribute(this);
		}
	}

	[RuleVersion(0)]
	public AttributeContext attribute() {
		AttributeContext _localctx = new AttributeContext(Context, State);
		EnterRule(_localctx, 48, RULE_attribute);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 544;
			qualifiedNamespaceName();
			State = 546;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OpenRoundBracket) {
				{
				State = 545;
				arguments();
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

	public partial class InnerStatementListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public InnerStatementContext[] innerStatement() {
			return GetRuleContexts<InnerStatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public InnerStatementContext innerStatement(int i) {
			return GetRuleContext<InnerStatementContext>(i);
		}
		public InnerStatementListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_innerStatementList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterInnerStatementList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitInnerStatementList(this);
		}
	}

	[RuleVersion(0)]
	public InnerStatementListContext innerStatementList() {
		InnerStatementListContext _localctx = new InnerStatementListContext(Context, State);
		EnterRule(_localctx, 50, RULE_innerStatementList);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 551;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,47,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 548;
					innerStatement();
					}
					} 
				}
				State = 553;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,47,Context);
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

	public partial class InnerStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FunctionDeclarationContext functionDeclaration() {
			return GetRuleContext<FunctionDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassDeclarationContext classDeclaration() {
			return GetRuleContext<ClassDeclarationContext>(0);
		}
		public InnerStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_innerStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterInnerStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitInnerStatement(this);
		}
	}

	[RuleVersion(0)]
	public InnerStatementContext innerStatement() {
		InnerStatementContext _localctx = new InnerStatementContext(Context, State);
		EnterRule(_localctx, 52, RULE_innerStatement);
		try {
			State = 557;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,48,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 554;
				statement();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 555;
				functionDeclaration();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 556;
				classDeclaration();
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

	public partial class StatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(PhpParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockStatementContext blockStatement() {
			return GetRuleContext<BlockStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IfStatementContext ifStatement() {
			return GetRuleContext<IfStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public WhileStatementContext whileStatement() {
			return GetRuleContext<WhileStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DoWhileStatementContext doWhileStatement() {
			return GetRuleContext<DoWhileStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ForStatementContext forStatement() {
			return GetRuleContext<ForStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SwitchStatementContext switchStatement() {
			return GetRuleContext<SwitchStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BreakStatementContext breakStatement() {
			return GetRuleContext<BreakStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ContinueStatementContext continueStatement() {
			return GetRuleContext<ContinueStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ReturnStatementContext returnStatement() {
			return GetRuleContext<ReturnStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public YieldExpressionContext yieldExpression() {
			return GetRuleContext<YieldExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public GlobalStatementContext globalStatement() {
			return GetRuleContext<GlobalStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StaticVariableStatementContext staticVariableStatement() {
			return GetRuleContext<StaticVariableStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EchoStatementContext echoStatement() {
			return GetRuleContext<EchoStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionStatementContext expressionStatement() {
			return GetRuleContext<ExpressionStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnsetStatementContext unsetStatement() {
			return GetRuleContext<UnsetStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ForeachStatementContext foreachStatement() {
			return GetRuleContext<ForeachStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TryCatchFinallyContext tryCatchFinally() {
			return GetRuleContext<TryCatchFinallyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ThrowStatementContext throwStatement() {
			return GetRuleContext<ThrowStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public GotoStatementContext gotoStatement() {
			return GetRuleContext<GotoStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclareStatementContext declareStatement() {
			return GetRuleContext<DeclareStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EmptyStatement_Context emptyStatement_() {
			return GetRuleContext<EmptyStatement_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InlineHtmlStatementContext inlineHtmlStatement() {
			return GetRuleContext<InlineHtmlStatementContext>(0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 54, RULE_statement);
		try {
			State = 586;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,49,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 559;
				identifier();
				State = 560;
				Match(Colon);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 562;
				blockStatement();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 563;
				ifStatement();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 564;
				whileStatement();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 565;
				doWhileStatement();
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 566;
				forStatement();
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 567;
				switchStatement();
				}
				break;
			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 568;
				breakStatement();
				}
				break;
			case 9:
				EnterOuterAlt(_localctx, 9);
				{
				State = 569;
				continueStatement();
				}
				break;
			case 10:
				EnterOuterAlt(_localctx, 10);
				{
				State = 570;
				returnStatement();
				}
				break;
			case 11:
				EnterOuterAlt(_localctx, 11);
				{
				State = 571;
				yieldExpression();
				State = 572;
				Match(SemiColon);
				}
				break;
			case 12:
				EnterOuterAlt(_localctx, 12);
				{
				State = 574;
				globalStatement();
				}
				break;
			case 13:
				EnterOuterAlt(_localctx, 13);
				{
				State = 575;
				staticVariableStatement();
				}
				break;
			case 14:
				EnterOuterAlt(_localctx, 14);
				{
				State = 576;
				echoStatement();
				}
				break;
			case 15:
				EnterOuterAlt(_localctx, 15);
				{
				State = 577;
				expressionStatement();
				}
				break;
			case 16:
				EnterOuterAlt(_localctx, 16);
				{
				State = 578;
				unsetStatement();
				}
				break;
			case 17:
				EnterOuterAlt(_localctx, 17);
				{
				State = 579;
				foreachStatement();
				}
				break;
			case 18:
				EnterOuterAlt(_localctx, 18);
				{
				State = 580;
				tryCatchFinally();
				}
				break;
			case 19:
				EnterOuterAlt(_localctx, 19);
				{
				State = 581;
				throwStatement();
				}
				break;
			case 20:
				EnterOuterAlt(_localctx, 20);
				{
				State = 582;
				gotoStatement();
				}
				break;
			case 21:
				EnterOuterAlt(_localctx, 21);
				{
				State = 583;
				declareStatement();
				}
				break;
			case 22:
				EnterOuterAlt(_localctx, 22);
				{
				State = 584;
				emptyStatement_();
				}
				break;
			case 23:
				EnterOuterAlt(_localctx, 23);
				{
				State = 585;
				inlineHtmlStatement();
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

	public partial class EmptyStatement_Context : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		public EmptyStatement_Context(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_emptyStatement_; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterEmptyStatement_(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitEmptyStatement_(this);
		}
	}

	[RuleVersion(0)]
	public EmptyStatement_Context emptyStatement_() {
		EmptyStatement_Context _localctx = new EmptyStatement_Context(Context, State);
		EnterRule(_localctx, 56, RULE_emptyStatement_);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 588;
			Match(SemiColon);
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

	public partial class BlockStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenCurlyBracket() { return GetToken(PhpParser.OpenCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InnerStatementListContext innerStatementList() {
			return GetRuleContext<InnerStatementListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseCurlyBracket() { return GetToken(PhpParser.CloseCurlyBracket, 0); }
		public BlockStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_blockStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterBlockStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitBlockStatement(this);
		}
	}

	[RuleVersion(0)]
	public BlockStatementContext blockStatement() {
		BlockStatementContext _localctx = new BlockStatementContext(Context, State);
		EnterRule(_localctx, 58, RULE_blockStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 590;
			Match(OpenCurlyBracket);
			State = 591;
			innerStatementList();
			State = 592;
			Match(CloseCurlyBracket);
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

	public partial class IfStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode If() { return GetToken(PhpParser.If, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ParenthesesContext parentheses() {
			return GetRuleContext<ParenthesesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ElseIfStatementContext[] elseIfStatement() {
			return GetRuleContexts<ElseIfStatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ElseIfStatementContext elseIfStatement(int i) {
			return GetRuleContext<ElseIfStatementContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ElseStatementContext elseStatement() {
			return GetRuleContext<ElseStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(PhpParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InnerStatementListContext innerStatementList() {
			return GetRuleContext<InnerStatementListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EndIf() { return GetToken(PhpParser.EndIf, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ElseIfColonStatementContext[] elseIfColonStatement() {
			return GetRuleContexts<ElseIfColonStatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ElseIfColonStatementContext elseIfColonStatement(int i) {
			return GetRuleContext<ElseIfColonStatementContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ElseColonStatementContext elseColonStatement() {
			return GetRuleContext<ElseColonStatementContext>(0);
		}
		public IfStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ifStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterIfStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitIfStatement(this);
		}
	}

	[RuleVersion(0)]
	public IfStatementContext ifStatement() {
		IfStatementContext _localctx = new IfStatementContext(Context, State);
		EnterRule(_localctx, 60, RULE_ifStatement);
		int _la;
		try {
			int _alt;
			State = 622;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,54,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 594;
				Match(If);
				State = 595;
				parentheses();
				State = 596;
				statement();
				State = 600;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,50,Context);
				while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						State = 597;
						elseIfStatement();
						}
						} 
					}
					State = 602;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,50,Context);
				}
				State = 604;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,51,Context) ) {
				case 1:
					{
					State = 603;
					elseStatement();
					}
					break;
				}
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 606;
				Match(If);
				State = 607;
				parentheses();
				State = 608;
				Match(Colon);
				State = 609;
				innerStatementList();
				State = 613;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==ElseIf) {
					{
					{
					State = 610;
					elseIfColonStatement();
					}
					}
					State = 615;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 617;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Else) {
					{
					State = 616;
					elseColonStatement();
					}
				}

				State = 619;
				Match(EndIf);
				State = 620;
				Match(SemiColon);
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

	public partial class ElseIfStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ElseIf() { return GetToken(PhpParser.ElseIf, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ParenthesesContext parentheses() {
			return GetRuleContext<ParenthesesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		public ElseIfStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_elseIfStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterElseIfStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitElseIfStatement(this);
		}
	}

	[RuleVersion(0)]
	public ElseIfStatementContext elseIfStatement() {
		ElseIfStatementContext _localctx = new ElseIfStatementContext(Context, State);
		EnterRule(_localctx, 62, RULE_elseIfStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 624;
			Match(ElseIf);
			State = 625;
			parentheses();
			State = 626;
			statement();
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

	public partial class ElseIfColonStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ElseIf() { return GetToken(PhpParser.ElseIf, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ParenthesesContext parentheses() {
			return GetRuleContext<ParenthesesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(PhpParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InnerStatementListContext innerStatementList() {
			return GetRuleContext<InnerStatementListContext>(0);
		}
		public ElseIfColonStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_elseIfColonStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterElseIfColonStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitElseIfColonStatement(this);
		}
	}

	[RuleVersion(0)]
	public ElseIfColonStatementContext elseIfColonStatement() {
		ElseIfColonStatementContext _localctx = new ElseIfColonStatementContext(Context, State);
		EnterRule(_localctx, 64, RULE_elseIfColonStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 628;
			Match(ElseIf);
			State = 629;
			parentheses();
			State = 630;
			Match(Colon);
			State = 631;
			innerStatementList();
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

	public partial class ElseStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Else() { return GetToken(PhpParser.Else, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		public ElseStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_elseStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterElseStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitElseStatement(this);
		}
	}

	[RuleVersion(0)]
	public ElseStatementContext elseStatement() {
		ElseStatementContext _localctx = new ElseStatementContext(Context, State);
		EnterRule(_localctx, 66, RULE_elseStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 633;
			Match(Else);
			State = 634;
			statement();
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

	public partial class ElseColonStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Else() { return GetToken(PhpParser.Else, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(PhpParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InnerStatementListContext innerStatementList() {
			return GetRuleContext<InnerStatementListContext>(0);
		}
		public ElseColonStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_elseColonStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterElseColonStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitElseColonStatement(this);
		}
	}

	[RuleVersion(0)]
	public ElseColonStatementContext elseColonStatement() {
		ElseColonStatementContext _localctx = new ElseColonStatementContext(Context, State);
		EnterRule(_localctx, 68, RULE_elseColonStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 636;
			Match(Else);
			State = 637;
			Match(Colon);
			State = 638;
			innerStatementList();
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

	public partial class WhileStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode While() { return GetToken(PhpParser.While, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ParenthesesContext parentheses() {
			return GetRuleContext<ParenthesesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(PhpParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InnerStatementListContext innerStatementList() {
			return GetRuleContext<InnerStatementListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EndWhile() { return GetToken(PhpParser.EndWhile, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		public WhileStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_whileStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterWhileStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitWhileStatement(this);
		}
	}

	[RuleVersion(0)]
	public WhileStatementContext whileStatement() {
		WhileStatementContext _localctx = new WhileStatementContext(Context, State);
		EnterRule(_localctx, 70, RULE_whileStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 640;
			Match(While);
			State = 641;
			parentheses();
			State = 648;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case HtmlText:
			case XmlStart:
			case HtmlScriptOpen:
			case HtmlStyleOpen:
			case HtmlDtd:
			case HtmlOpen:
			case HtmlClose:
			case HtmlSlashClose:
			case HtmlSlash:
			case HtmlEquals:
			case HtmlStartQuoteString:
			case HtmlStartDoubleQuoteString:
			case HtmlHex:
			case HtmlDecimal:
			case HtmlName:
			case HtmlEndQuoteString:
			case HtmlQuoteString:
			case HtmlEndDoubleQuoteString:
			case HtmlDoubleQuoteString:
			case ScriptText:
			case HtmlScriptClose:
			case StyleBody:
			case Abstract:
			case Array:
			case As:
			case BinaryCast:
			case BoolType:
			case BooleanConstant:
			case Break:
			case Callable:
			case Case:
			case Catch:
			case Class:
			case Clone:
			case Const:
			case Continue:
			case Declare:
			case Default:
			case Do:
			case DoubleCast:
			case DoubleType:
			case Echo:
			case Else:
			case ElseIf:
			case Empty:
			case EndDeclare:
			case EndFor:
			case EndForeach:
			case EndIf:
			case EndSwitch:
			case EndWhile:
			case Eval:
			case Exit:
			case Extends:
			case Final:
			case Finally:
			case FloatCast:
			case For:
			case Foreach:
			case Function_:
			case Global:
			case Goto:
			case If:
			case Implements:
			case Import:
			case Include:
			case IncludeOnce:
			case InstanceOf:
			case InsteadOf:
			case Int8Cast:
			case Int16Cast:
			case Int64Type:
			case IntType:
			case Interface:
			case IsSet:
			case List:
			case LogicalAnd:
			case LogicalOr:
			case LogicalXor:
			case Match_:
			case Namespace:
			case New:
			case Null:
			case ObjectType:
			case Parent_:
			case Partial:
			case Print:
			case Private:
			case Protected:
			case Public:
			case Require:
			case RequireOnce:
			case Resource:
			case Return:
			case Static:
			case StringType:
			case Switch:
			case Throw:
			case Trait:
			case Try:
			case Typeof:
			case UintCast:
			case UnicodeCast:
			case Unset:
			case Use:
			case Var:
			case While:
			case Yield:
			case From:
			case LambdaFn:
			case Get:
			case Set:
			case Call:
			case CallStatic:
			case Constructor:
			case Destruct:
			case Wakeup:
			case Sleep:
			case Autoload:
			case IsSet__:
			case Unset__:
			case ToString__:
			case Invoke:
			case SetState:
			case Clone__:
			case DebugInfo:
			case Namespace__:
			case Class__:
			case Traic__:
			case Function__:
			case Method__:
			case Line__:
			case File__:
			case Dir__:
			case Inc:
			case Dec:
			case NamespaceSeparator:
			case Bang:
			case Plus:
			case Minus:
			case Tilde:
			case SuppressWarnings:
			case Dollar:
			case OpenRoundBracket:
			case OpenSquareBracket:
			case OpenCurlyBracket:
			case SemiColon:
			case VarName:
			case Label:
			case Octal:
			case Decimal:
			case Real:
			case Hex:
			case Binary:
			case BackQuoteString:
			case SingleQuoteString:
			case DoubleQuote:
			case StartNowDoc:
			case StartHereDoc:
				{
				State = 642;
				statement();
				}
				break;
			case Colon:
				{
				State = 643;
				Match(Colon);
				State = 644;
				innerStatementList();
				State = 645;
				Match(EndWhile);
				State = 646;
				Match(SemiColon);
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

	public partial class DoWhileStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Do() { return GetToken(PhpParser.Do, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode While() { return GetToken(PhpParser.While, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ParenthesesContext parentheses() {
			return GetRuleContext<ParenthesesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		public DoWhileStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_doWhileStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterDoWhileStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitDoWhileStatement(this);
		}
	}

	[RuleVersion(0)]
	public DoWhileStatementContext doWhileStatement() {
		DoWhileStatementContext _localctx = new DoWhileStatementContext(Context, State);
		EnterRule(_localctx, 72, RULE_doWhileStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 650;
			Match(Do);
			State = 651;
			statement();
			State = 652;
			Match(While);
			State = 653;
			parentheses();
			State = 654;
			Match(SemiColon);
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

	public partial class ForStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode For() { return GetToken(PhpParser.For, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenRoundBracket() { return GetToken(PhpParser.OpenRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SemiColon() { return GetTokens(PhpParser.SemiColon); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon(int i) {
			return GetToken(PhpParser.SemiColon, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseRoundBracket() { return GetToken(PhpParser.CloseRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(PhpParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InnerStatementListContext innerStatementList() {
			return GetRuleContext<InnerStatementListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EndFor() { return GetToken(PhpParser.EndFor, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ForInitContext forInit() {
			return GetRuleContext<ForInitContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionListContext expressionList() {
			return GetRuleContext<ExpressionListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ForUpdateContext forUpdate() {
			return GetRuleContext<ForUpdateContext>(0);
		}
		public ForStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_forStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterForStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitForStatement(this);
		}
	}

	[RuleVersion(0)]
	public ForStatementContext forStatement() {
		ForStatementContext _localctx = new ForStatementContext(Context, State);
		EnterRule(_localctx, 74, RULE_forStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 656;
			Match(For);
			State = 657;
			Match(OpenRoundBracket);
			State = 659;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Match_ - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (LambdaFn - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)) | (1L << (Inc - 108)) | (1L << (Dec - 108)))) != 0) || ((((_la - 189)) & ~0x3f) == 0 && ((1L << (_la - 189)) & ((1L << (NamespaceSeparator - 189)) | (1L << (Bang - 189)) | (1L << (Plus - 189)) | (1L << (Minus - 189)) | (1L << (Tilde - 189)) | (1L << (SuppressWarnings - 189)) | (1L << (Dollar - 189)) | (1L << (OpenRoundBracket - 189)) | (1L << (OpenSquareBracket - 189)) | (1L << (VarName - 189)) | (1L << (Label - 189)) | (1L << (Octal - 189)) | (1L << (Decimal - 189)) | (1L << (Real - 189)) | (1L << (Hex - 189)) | (1L << (Binary - 189)) | (1L << (BackQuoteString - 189)) | (1L << (SingleQuoteString - 189)) | (1L << (DoubleQuote - 189)) | (1L << (StartNowDoc - 189)) | (1L << (StartHereDoc - 189)))) != 0)) {
				{
				State = 658;
				forInit();
				}
			}

			State = 661;
			Match(SemiColon);
			State = 663;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Match_ - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (LambdaFn - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)) | (1L << (Inc - 108)) | (1L << (Dec - 108)))) != 0) || ((((_la - 189)) & ~0x3f) == 0 && ((1L << (_la - 189)) & ((1L << (NamespaceSeparator - 189)) | (1L << (Bang - 189)) | (1L << (Plus - 189)) | (1L << (Minus - 189)) | (1L << (Tilde - 189)) | (1L << (SuppressWarnings - 189)) | (1L << (Dollar - 189)) | (1L << (OpenRoundBracket - 189)) | (1L << (OpenSquareBracket - 189)) | (1L << (VarName - 189)) | (1L << (Label - 189)) | (1L << (Octal - 189)) | (1L << (Decimal - 189)) | (1L << (Real - 189)) | (1L << (Hex - 189)) | (1L << (Binary - 189)) | (1L << (BackQuoteString - 189)) | (1L << (SingleQuoteString - 189)) | (1L << (DoubleQuote - 189)) | (1L << (StartNowDoc - 189)) | (1L << (StartHereDoc - 189)))) != 0)) {
				{
				State = 662;
				expressionList();
				}
			}

			State = 665;
			Match(SemiColon);
			State = 667;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Match_ - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (LambdaFn - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)) | (1L << (Inc - 108)) | (1L << (Dec - 108)))) != 0) || ((((_la - 189)) & ~0x3f) == 0 && ((1L << (_la - 189)) & ((1L << (NamespaceSeparator - 189)) | (1L << (Bang - 189)) | (1L << (Plus - 189)) | (1L << (Minus - 189)) | (1L << (Tilde - 189)) | (1L << (SuppressWarnings - 189)) | (1L << (Dollar - 189)) | (1L << (OpenRoundBracket - 189)) | (1L << (OpenSquareBracket - 189)) | (1L << (VarName - 189)) | (1L << (Label - 189)) | (1L << (Octal - 189)) | (1L << (Decimal - 189)) | (1L << (Real - 189)) | (1L << (Hex - 189)) | (1L << (Binary - 189)) | (1L << (BackQuoteString - 189)) | (1L << (SingleQuoteString - 189)) | (1L << (DoubleQuote - 189)) | (1L << (StartNowDoc - 189)) | (1L << (StartHereDoc - 189)))) != 0)) {
				{
				State = 666;
				forUpdate();
				}
			}

			State = 669;
			Match(CloseRoundBracket);
			State = 676;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case HtmlText:
			case XmlStart:
			case HtmlScriptOpen:
			case HtmlStyleOpen:
			case HtmlDtd:
			case HtmlOpen:
			case HtmlClose:
			case HtmlSlashClose:
			case HtmlSlash:
			case HtmlEquals:
			case HtmlStartQuoteString:
			case HtmlStartDoubleQuoteString:
			case HtmlHex:
			case HtmlDecimal:
			case HtmlName:
			case HtmlEndQuoteString:
			case HtmlQuoteString:
			case HtmlEndDoubleQuoteString:
			case HtmlDoubleQuoteString:
			case ScriptText:
			case HtmlScriptClose:
			case StyleBody:
			case Abstract:
			case Array:
			case As:
			case BinaryCast:
			case BoolType:
			case BooleanConstant:
			case Break:
			case Callable:
			case Case:
			case Catch:
			case Class:
			case Clone:
			case Const:
			case Continue:
			case Declare:
			case Default:
			case Do:
			case DoubleCast:
			case DoubleType:
			case Echo:
			case Else:
			case ElseIf:
			case Empty:
			case EndDeclare:
			case EndFor:
			case EndForeach:
			case EndIf:
			case EndSwitch:
			case EndWhile:
			case Eval:
			case Exit:
			case Extends:
			case Final:
			case Finally:
			case FloatCast:
			case For:
			case Foreach:
			case Function_:
			case Global:
			case Goto:
			case If:
			case Implements:
			case Import:
			case Include:
			case IncludeOnce:
			case InstanceOf:
			case InsteadOf:
			case Int8Cast:
			case Int16Cast:
			case Int64Type:
			case IntType:
			case Interface:
			case IsSet:
			case List:
			case LogicalAnd:
			case LogicalOr:
			case LogicalXor:
			case Match_:
			case Namespace:
			case New:
			case Null:
			case ObjectType:
			case Parent_:
			case Partial:
			case Print:
			case Private:
			case Protected:
			case Public:
			case Require:
			case RequireOnce:
			case Resource:
			case Return:
			case Static:
			case StringType:
			case Switch:
			case Throw:
			case Trait:
			case Try:
			case Typeof:
			case UintCast:
			case UnicodeCast:
			case Unset:
			case Use:
			case Var:
			case While:
			case Yield:
			case From:
			case LambdaFn:
			case Get:
			case Set:
			case Call:
			case CallStatic:
			case Constructor:
			case Destruct:
			case Wakeup:
			case Sleep:
			case Autoload:
			case IsSet__:
			case Unset__:
			case ToString__:
			case Invoke:
			case SetState:
			case Clone__:
			case DebugInfo:
			case Namespace__:
			case Class__:
			case Traic__:
			case Function__:
			case Method__:
			case Line__:
			case File__:
			case Dir__:
			case Inc:
			case Dec:
			case NamespaceSeparator:
			case Bang:
			case Plus:
			case Minus:
			case Tilde:
			case SuppressWarnings:
			case Dollar:
			case OpenRoundBracket:
			case OpenSquareBracket:
			case OpenCurlyBracket:
			case SemiColon:
			case VarName:
			case Label:
			case Octal:
			case Decimal:
			case Real:
			case Hex:
			case Binary:
			case BackQuoteString:
			case SingleQuoteString:
			case DoubleQuote:
			case StartNowDoc:
			case StartHereDoc:
				{
				State = 670;
				statement();
				}
				break;
			case Colon:
				{
				State = 671;
				Match(Colon);
				State = 672;
				innerStatementList();
				State = 673;
				Match(EndFor);
				State = 674;
				Match(SemiColon);
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

	public partial class ForInitContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionListContext expressionList() {
			return GetRuleContext<ExpressionListContext>(0);
		}
		public ForInitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_forInit; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterForInit(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitForInit(this);
		}
	}

	[RuleVersion(0)]
	public ForInitContext forInit() {
		ForInitContext _localctx = new ForInitContext(Context, State);
		EnterRule(_localctx, 76, RULE_forInit);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 678;
			expressionList();
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

	public partial class ForUpdateContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionListContext expressionList() {
			return GetRuleContext<ExpressionListContext>(0);
		}
		public ForUpdateContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_forUpdate; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterForUpdate(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitForUpdate(this);
		}
	}

	[RuleVersion(0)]
	public ForUpdateContext forUpdate() {
		ForUpdateContext _localctx = new ForUpdateContext(Context, State);
		EnterRule(_localctx, 78, RULE_forUpdate);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 680;
			expressionList();
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

	public partial class SwitchStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Switch() { return GetToken(PhpParser.Switch, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ParenthesesContext parentheses() {
			return GetRuleContext<ParenthesesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenCurlyBracket() { return GetToken(PhpParser.OpenCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseCurlyBracket() { return GetToken(PhpParser.CloseCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(PhpParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EndSwitch() { return GetToken(PhpParser.EndSwitch, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SemiColon() { return GetTokens(PhpParser.SemiColon); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon(int i) {
			return GetToken(PhpParser.SemiColon, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SwitchBlockContext[] switchBlock() {
			return GetRuleContexts<SwitchBlockContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public SwitchBlockContext switchBlock(int i) {
			return GetRuleContext<SwitchBlockContext>(i);
		}
		public SwitchStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_switchStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterSwitchStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitSwitchStatement(this);
		}
	}

	[RuleVersion(0)]
	public SwitchStatementContext switchStatement() {
		SwitchStatementContext _localctx = new SwitchStatementContext(Context, State);
		EnterRule(_localctx, 80, RULE_switchStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 682;
			Match(Switch);
			State = 683;
			parentheses();
			State = 707;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case OpenCurlyBracket:
				{
				State = 684;
				Match(OpenCurlyBracket);
				State = 686;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==SemiColon) {
					{
					State = 685;
					Match(SemiColon);
					}
				}

				State = 691;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==Case || _la==Default) {
					{
					{
					State = 688;
					switchBlock();
					}
					}
					State = 693;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 694;
				Match(CloseCurlyBracket);
				}
				break;
			case Colon:
				{
				State = 695;
				Match(Colon);
				State = 697;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==SemiColon) {
					{
					State = 696;
					Match(SemiColon);
					}
				}

				State = 702;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==Case || _la==Default) {
					{
					{
					State = 699;
					switchBlock();
					}
					}
					State = 704;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 705;
				Match(EndSwitch);
				State = 706;
				Match(SemiColon);
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

	public partial class SwitchBlockContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public InnerStatementListContext innerStatementList() {
			return GetRuleContext<InnerStatementListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Colon() { return GetTokens(PhpParser.Colon); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon(int i) {
			return GetToken(PhpParser.Colon, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SemiColon() { return GetTokens(PhpParser.SemiColon); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon(int i) {
			return GetToken(PhpParser.SemiColon, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Case() { return GetTokens(PhpParser.Case); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Case(int i) {
			return GetToken(PhpParser.Case, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Default() { return GetTokens(PhpParser.Default); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Default(int i) {
			return GetToken(PhpParser.Default, i);
		}
		public SwitchBlockContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_switchBlock; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterSwitchBlock(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitSwitchBlock(this);
		}
	}

	[RuleVersion(0)]
	public SwitchBlockContext switchBlock() {
		SwitchBlockContext _localctx = new SwitchBlockContext(Context, State);
		EnterRule(_localctx, 82, RULE_switchBlock);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 715;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 712;
					ErrorHandler.Sync(this);
					switch (TokenStream.LA(1)) {
					case Case:
						{
						State = 709;
						Match(Case);
						State = 710;
						expression(0);
						}
						break;
					case Default:
						{
						State = 711;
						Match(Default);
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					State = 714;
					_la = TokenStream.LA(1);
					if ( !(_la==Colon || _la==SemiColon) ) {
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
				State = 717;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,66,Context);
			} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
			State = 719;
			innerStatementList();
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

	public partial class BreakStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Break() { return GetToken(PhpParser.Break, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public BreakStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_breakStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterBreakStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitBreakStatement(this);
		}
	}

	[RuleVersion(0)]
	public BreakStatementContext breakStatement() {
		BreakStatementContext _localctx = new BreakStatementContext(Context, State);
		EnterRule(_localctx, 84, RULE_breakStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 721;
			Match(Break);
			State = 723;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Match_ - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (LambdaFn - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)) | (1L << (Inc - 108)) | (1L << (Dec - 108)))) != 0) || ((((_la - 189)) & ~0x3f) == 0 && ((1L << (_la - 189)) & ((1L << (NamespaceSeparator - 189)) | (1L << (Bang - 189)) | (1L << (Plus - 189)) | (1L << (Minus - 189)) | (1L << (Tilde - 189)) | (1L << (SuppressWarnings - 189)) | (1L << (Dollar - 189)) | (1L << (OpenRoundBracket - 189)) | (1L << (OpenSquareBracket - 189)) | (1L << (VarName - 189)) | (1L << (Label - 189)) | (1L << (Octal - 189)) | (1L << (Decimal - 189)) | (1L << (Real - 189)) | (1L << (Hex - 189)) | (1L << (Binary - 189)) | (1L << (BackQuoteString - 189)) | (1L << (SingleQuoteString - 189)) | (1L << (DoubleQuote - 189)) | (1L << (StartNowDoc - 189)) | (1L << (StartHereDoc - 189)))) != 0)) {
				{
				State = 722;
				expression(0);
				}
			}

			State = 725;
			Match(SemiColon);
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

	public partial class ContinueStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Continue() { return GetToken(PhpParser.Continue, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ContinueStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_continueStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterContinueStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitContinueStatement(this);
		}
	}

	[RuleVersion(0)]
	public ContinueStatementContext continueStatement() {
		ContinueStatementContext _localctx = new ContinueStatementContext(Context, State);
		EnterRule(_localctx, 86, RULE_continueStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 727;
			Match(Continue);
			State = 729;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Match_ - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (LambdaFn - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)) | (1L << (Inc - 108)) | (1L << (Dec - 108)))) != 0) || ((((_la - 189)) & ~0x3f) == 0 && ((1L << (_la - 189)) & ((1L << (NamespaceSeparator - 189)) | (1L << (Bang - 189)) | (1L << (Plus - 189)) | (1L << (Minus - 189)) | (1L << (Tilde - 189)) | (1L << (SuppressWarnings - 189)) | (1L << (Dollar - 189)) | (1L << (OpenRoundBracket - 189)) | (1L << (OpenSquareBracket - 189)) | (1L << (VarName - 189)) | (1L << (Label - 189)) | (1L << (Octal - 189)) | (1L << (Decimal - 189)) | (1L << (Real - 189)) | (1L << (Hex - 189)) | (1L << (Binary - 189)) | (1L << (BackQuoteString - 189)) | (1L << (SingleQuoteString - 189)) | (1L << (DoubleQuote - 189)) | (1L << (StartNowDoc - 189)) | (1L << (StartHereDoc - 189)))) != 0)) {
				{
				State = 728;
				expression(0);
				}
			}

			State = 731;
			Match(SemiColon);
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

	public partial class ReturnStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Return() { return GetToken(PhpParser.Return, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ReturnStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_returnStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterReturnStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitReturnStatement(this);
		}
	}

	[RuleVersion(0)]
	public ReturnStatementContext returnStatement() {
		ReturnStatementContext _localctx = new ReturnStatementContext(Context, State);
		EnterRule(_localctx, 88, RULE_returnStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 733;
			Match(Return);
			State = 735;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Match_ - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (LambdaFn - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)) | (1L << (Inc - 108)) | (1L << (Dec - 108)))) != 0) || ((((_la - 189)) & ~0x3f) == 0 && ((1L << (_la - 189)) & ((1L << (NamespaceSeparator - 189)) | (1L << (Bang - 189)) | (1L << (Plus - 189)) | (1L << (Minus - 189)) | (1L << (Tilde - 189)) | (1L << (SuppressWarnings - 189)) | (1L << (Dollar - 189)) | (1L << (OpenRoundBracket - 189)) | (1L << (OpenSquareBracket - 189)) | (1L << (VarName - 189)) | (1L << (Label - 189)) | (1L << (Octal - 189)) | (1L << (Decimal - 189)) | (1L << (Real - 189)) | (1L << (Hex - 189)) | (1L << (Binary - 189)) | (1L << (BackQuoteString - 189)) | (1L << (SingleQuoteString - 189)) | (1L << (DoubleQuote - 189)) | (1L << (StartNowDoc - 189)) | (1L << (StartHereDoc - 189)))) != 0)) {
				{
				State = 734;
				expression(0);
				}
			}

			State = 737;
			Match(SemiColon);
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
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		public ExpressionStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expressionStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterExpressionStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitExpressionStatement(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionStatementContext expressionStatement() {
		ExpressionStatementContext _localctx = new ExpressionStatementContext(Context, State);
		EnterRule(_localctx, 90, RULE_expressionStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 739;
			expression(0);
			State = 740;
			Match(SemiColon);
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

	public partial class UnsetStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Unset() { return GetToken(PhpParser.Unset, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenRoundBracket() { return GetToken(PhpParser.OpenRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ChainListContext chainList() {
			return GetRuleContext<ChainListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseRoundBracket() { return GetToken(PhpParser.CloseRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		public UnsetStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unsetStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterUnsetStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitUnsetStatement(this);
		}
	}

	[RuleVersion(0)]
	public UnsetStatementContext unsetStatement() {
		UnsetStatementContext _localctx = new UnsetStatementContext(Context, State);
		EnterRule(_localctx, 92, RULE_unsetStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 742;
			Match(Unset);
			State = 743;
			Match(OpenRoundBracket);
			State = 744;
			chainList();
			State = 745;
			Match(CloseRoundBracket);
			State = 746;
			Match(SemiColon);
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

	public partial class ForeachStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Foreach() { return GetToken(PhpParser.Foreach, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OpenRoundBracket() { return GetTokens(PhpParser.OpenRoundBracket); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenRoundBracket(int i) {
			return GetToken(PhpParser.OpenRoundBracket, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ChainContext[] chain() {
			return GetRuleContexts<ChainContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ChainContext chain(int i) {
			return GetRuleContext<ChainContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode As() { return GetToken(PhpParser.As, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AssignableContext assignable() {
			return GetRuleContext<AssignableContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] CloseRoundBracket() { return GetTokens(PhpParser.CloseRoundBracket); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseRoundBracket(int i) {
			return GetToken(PhpParser.CloseRoundBracket, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode List() { return GetToken(PhpParser.List, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentListContext assignmentList() {
			return GetRuleContext<AssignmentListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(PhpParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InnerStatementListContext innerStatementList() {
			return GetRuleContext<InnerStatementListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EndForeach() { return GetToken(PhpParser.EndForeach, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Ampersand() { return GetTokens(PhpParser.Ampersand); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ampersand(int i) {
			return GetToken(PhpParser.Ampersand, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DoubleArrow() { return GetToken(PhpParser.DoubleArrow, 0); }
		public ForeachStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_foreachStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterForeachStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitForeachStatement(this);
		}
	}

	[RuleVersion(0)]
	public ForeachStatementContext foreachStatement() {
		ForeachStatementContext _localctx = new ForeachStatementContext(Context, State);
		EnterRule(_localctx, 94, RULE_foreachStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 748;
			Match(Foreach);
			State = 787;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,75,Context) ) {
			case 1:
				{
				State = 749;
				Match(OpenRoundBracket);
				State = 750;
				chain();
				State = 751;
				Match(As);
				State = 753;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Ampersand) {
					{
					State = 752;
					Match(Ampersand);
					}
				}

				State = 755;
				assignable();
				State = 761;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==DoubleArrow) {
					{
					State = 756;
					Match(DoubleArrow);
					State = 758;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==Ampersand) {
						{
						State = 757;
						Match(Ampersand);
						}
					}

					State = 760;
					chain();
					}
				}

				State = 763;
				Match(CloseRoundBracket);
				}
				break;
			case 2:
				{
				State = 765;
				Match(OpenRoundBracket);
				State = 766;
				expression(0);
				State = 767;
				Match(As);
				State = 768;
				assignable();
				State = 774;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==DoubleArrow) {
					{
					State = 769;
					Match(DoubleArrow);
					State = 771;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==Ampersand) {
						{
						State = 770;
						Match(Ampersand);
						}
					}

					State = 773;
					chain();
					}
				}

				State = 776;
				Match(CloseRoundBracket);
				}
				break;
			case 3:
				{
				State = 778;
				Match(OpenRoundBracket);
				State = 779;
				chain();
				State = 780;
				Match(As);
				State = 781;
				Match(List);
				State = 782;
				Match(OpenRoundBracket);
				State = 783;
				assignmentList();
				State = 784;
				Match(CloseRoundBracket);
				State = 785;
				Match(CloseRoundBracket);
				}
				break;
			}
			State = 795;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case HtmlText:
			case XmlStart:
			case HtmlScriptOpen:
			case HtmlStyleOpen:
			case HtmlDtd:
			case HtmlOpen:
			case HtmlClose:
			case HtmlSlashClose:
			case HtmlSlash:
			case HtmlEquals:
			case HtmlStartQuoteString:
			case HtmlStartDoubleQuoteString:
			case HtmlHex:
			case HtmlDecimal:
			case HtmlName:
			case HtmlEndQuoteString:
			case HtmlQuoteString:
			case HtmlEndDoubleQuoteString:
			case HtmlDoubleQuoteString:
			case ScriptText:
			case HtmlScriptClose:
			case StyleBody:
			case Abstract:
			case Array:
			case As:
			case BinaryCast:
			case BoolType:
			case BooleanConstant:
			case Break:
			case Callable:
			case Case:
			case Catch:
			case Class:
			case Clone:
			case Const:
			case Continue:
			case Declare:
			case Default:
			case Do:
			case DoubleCast:
			case DoubleType:
			case Echo:
			case Else:
			case ElseIf:
			case Empty:
			case EndDeclare:
			case EndFor:
			case EndForeach:
			case EndIf:
			case EndSwitch:
			case EndWhile:
			case Eval:
			case Exit:
			case Extends:
			case Final:
			case Finally:
			case FloatCast:
			case For:
			case Foreach:
			case Function_:
			case Global:
			case Goto:
			case If:
			case Implements:
			case Import:
			case Include:
			case IncludeOnce:
			case InstanceOf:
			case InsteadOf:
			case Int8Cast:
			case Int16Cast:
			case Int64Type:
			case IntType:
			case Interface:
			case IsSet:
			case List:
			case LogicalAnd:
			case LogicalOr:
			case LogicalXor:
			case Match_:
			case Namespace:
			case New:
			case Null:
			case ObjectType:
			case Parent_:
			case Partial:
			case Print:
			case Private:
			case Protected:
			case Public:
			case Require:
			case RequireOnce:
			case Resource:
			case Return:
			case Static:
			case StringType:
			case Switch:
			case Throw:
			case Trait:
			case Try:
			case Typeof:
			case UintCast:
			case UnicodeCast:
			case Unset:
			case Use:
			case Var:
			case While:
			case Yield:
			case From:
			case LambdaFn:
			case Get:
			case Set:
			case Call:
			case CallStatic:
			case Constructor:
			case Destruct:
			case Wakeup:
			case Sleep:
			case Autoload:
			case IsSet__:
			case Unset__:
			case ToString__:
			case Invoke:
			case SetState:
			case Clone__:
			case DebugInfo:
			case Namespace__:
			case Class__:
			case Traic__:
			case Function__:
			case Method__:
			case Line__:
			case File__:
			case Dir__:
			case Inc:
			case Dec:
			case NamespaceSeparator:
			case Bang:
			case Plus:
			case Minus:
			case Tilde:
			case SuppressWarnings:
			case Dollar:
			case OpenRoundBracket:
			case OpenSquareBracket:
			case OpenCurlyBracket:
			case SemiColon:
			case VarName:
			case Label:
			case Octal:
			case Decimal:
			case Real:
			case Hex:
			case Binary:
			case BackQuoteString:
			case SingleQuoteString:
			case DoubleQuote:
			case StartNowDoc:
			case StartHereDoc:
				{
				State = 789;
				statement();
				}
				break;
			case Colon:
				{
				State = 790;
				Match(Colon);
				State = 791;
				innerStatementList();
				State = 792;
				Match(EndForeach);
				State = 793;
				Match(SemiColon);
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

	public partial class TryCatchFinallyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Try() { return GetToken(PhpParser.Try, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockStatementContext blockStatement() {
			return GetRuleContext<BlockStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FinallyStatementContext finallyStatement() {
			return GetRuleContext<FinallyStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CatchClauseContext[] catchClause() {
			return GetRuleContexts<CatchClauseContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public CatchClauseContext catchClause(int i) {
			return GetRuleContext<CatchClauseContext>(i);
		}
		public TryCatchFinallyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tryCatchFinally; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterTryCatchFinally(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitTryCatchFinally(this);
		}
	}

	[RuleVersion(0)]
	public TryCatchFinallyContext tryCatchFinally() {
		TryCatchFinallyContext _localctx = new TryCatchFinallyContext(Context, State);
		EnterRule(_localctx, 96, RULE_tryCatchFinally);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 797;
			Match(Try);
			State = 798;
			blockStatement();
			State = 814;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,80,Context) ) {
			case 1:
				{
				State = 800;
				ErrorHandler.Sync(this);
				_alt = 1;
				do {
					switch (_alt) {
					case 1:
						{
						{
						State = 799;
						catchClause();
						}
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					State = 802;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,77,Context);
				} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
				State = 805;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,78,Context) ) {
				case 1:
					{
					State = 804;
					finallyStatement();
					}
					break;
				}
				}
				break;
			case 2:
				{
				State = 810;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==Catch) {
					{
					{
					State = 807;
					catchClause();
					}
					}
					State = 812;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 813;
				finallyStatement();
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

	public partial class CatchClauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Catch() { return GetToken(PhpParser.Catch, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenRoundBracket() { return GetToken(PhpParser.OpenRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedStaticTypeRefContext[] qualifiedStaticTypeRef() {
			return GetRuleContexts<QualifiedStaticTypeRefContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedStaticTypeRefContext qualifiedStaticTypeRef(int i) {
			return GetRuleContext<QualifiedStaticTypeRefContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VarName() { return GetToken(PhpParser.VarName, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseRoundBracket() { return GetToken(PhpParser.CloseRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockStatementContext blockStatement() {
			return GetRuleContext<BlockStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Pipe() { return GetTokens(PhpParser.Pipe); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Pipe(int i) {
			return GetToken(PhpParser.Pipe, i);
		}
		public CatchClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_catchClause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterCatchClause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitCatchClause(this);
		}
	}

	[RuleVersion(0)]
	public CatchClauseContext catchClause() {
		CatchClauseContext _localctx = new CatchClauseContext(Context, State);
		EnterRule(_localctx, 98, RULE_catchClause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 816;
			Match(Catch);
			State = 817;
			Match(OpenRoundBracket);
			State = 818;
			qualifiedStaticTypeRef();
			State = 823;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Pipe) {
				{
				{
				State = 819;
				Match(Pipe);
				State = 820;
				qualifiedStaticTypeRef();
				}
				}
				State = 825;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 826;
			Match(VarName);
			State = 827;
			Match(CloseRoundBracket);
			State = 828;
			blockStatement();
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

	public partial class FinallyStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Finally() { return GetToken(PhpParser.Finally, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockStatementContext blockStatement() {
			return GetRuleContext<BlockStatementContext>(0);
		}
		public FinallyStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_finallyStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterFinallyStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitFinallyStatement(this);
		}
	}

	[RuleVersion(0)]
	public FinallyStatementContext finallyStatement() {
		FinallyStatementContext _localctx = new FinallyStatementContext(Context, State);
		EnterRule(_localctx, 100, RULE_finallyStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 830;
			Match(Finally);
			State = 831;
			blockStatement();
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

	public partial class ThrowStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Throw() { return GetToken(PhpParser.Throw, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		public ThrowStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_throwStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterThrowStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitThrowStatement(this);
		}
	}

	[RuleVersion(0)]
	public ThrowStatementContext throwStatement() {
		ThrowStatementContext _localctx = new ThrowStatementContext(Context, State);
		EnterRule(_localctx, 102, RULE_throwStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 833;
			Match(Throw);
			State = 834;
			expression(0);
			State = 835;
			Match(SemiColon);
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

	public partial class GotoStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Goto() { return GetToken(PhpParser.Goto, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		public GotoStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_gotoStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterGotoStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitGotoStatement(this);
		}
	}

	[RuleVersion(0)]
	public GotoStatementContext gotoStatement() {
		GotoStatementContext _localctx = new GotoStatementContext(Context, State);
		EnterRule(_localctx, 104, RULE_gotoStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 837;
			Match(Goto);
			State = 838;
			identifier();
			State = 839;
			Match(SemiColon);
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

	public partial class DeclareStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Declare() { return GetToken(PhpParser.Declare, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenRoundBracket() { return GetToken(PhpParser.OpenRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public DeclareListContext declareList() {
			return GetRuleContext<DeclareListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseRoundBracket() { return GetToken(PhpParser.CloseRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(PhpParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InnerStatementListContext innerStatementList() {
			return GetRuleContext<InnerStatementListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EndDeclare() { return GetToken(PhpParser.EndDeclare, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		public DeclareStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declareStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterDeclareStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitDeclareStatement(this);
		}
	}

	[RuleVersion(0)]
	public DeclareStatementContext declareStatement() {
		DeclareStatementContext _localctx = new DeclareStatementContext(Context, State);
		EnterRule(_localctx, 106, RULE_declareStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 841;
			Match(Declare);
			State = 842;
			Match(OpenRoundBracket);
			State = 843;
			declareList();
			State = 844;
			Match(CloseRoundBracket);
			State = 851;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case HtmlText:
			case XmlStart:
			case HtmlScriptOpen:
			case HtmlStyleOpen:
			case HtmlDtd:
			case HtmlOpen:
			case HtmlClose:
			case HtmlSlashClose:
			case HtmlSlash:
			case HtmlEquals:
			case HtmlStartQuoteString:
			case HtmlStartDoubleQuoteString:
			case HtmlHex:
			case HtmlDecimal:
			case HtmlName:
			case HtmlEndQuoteString:
			case HtmlQuoteString:
			case HtmlEndDoubleQuoteString:
			case HtmlDoubleQuoteString:
			case ScriptText:
			case HtmlScriptClose:
			case StyleBody:
			case Abstract:
			case Array:
			case As:
			case BinaryCast:
			case BoolType:
			case BooleanConstant:
			case Break:
			case Callable:
			case Case:
			case Catch:
			case Class:
			case Clone:
			case Const:
			case Continue:
			case Declare:
			case Default:
			case Do:
			case DoubleCast:
			case DoubleType:
			case Echo:
			case Else:
			case ElseIf:
			case Empty:
			case EndDeclare:
			case EndFor:
			case EndForeach:
			case EndIf:
			case EndSwitch:
			case EndWhile:
			case Eval:
			case Exit:
			case Extends:
			case Final:
			case Finally:
			case FloatCast:
			case For:
			case Foreach:
			case Function_:
			case Global:
			case Goto:
			case If:
			case Implements:
			case Import:
			case Include:
			case IncludeOnce:
			case InstanceOf:
			case InsteadOf:
			case Int8Cast:
			case Int16Cast:
			case Int64Type:
			case IntType:
			case Interface:
			case IsSet:
			case List:
			case LogicalAnd:
			case LogicalOr:
			case LogicalXor:
			case Match_:
			case Namespace:
			case New:
			case Null:
			case ObjectType:
			case Parent_:
			case Partial:
			case Print:
			case Private:
			case Protected:
			case Public:
			case Require:
			case RequireOnce:
			case Resource:
			case Return:
			case Static:
			case StringType:
			case Switch:
			case Throw:
			case Trait:
			case Try:
			case Typeof:
			case UintCast:
			case UnicodeCast:
			case Unset:
			case Use:
			case Var:
			case While:
			case Yield:
			case From:
			case LambdaFn:
			case Get:
			case Set:
			case Call:
			case CallStatic:
			case Constructor:
			case Destruct:
			case Wakeup:
			case Sleep:
			case Autoload:
			case IsSet__:
			case Unset__:
			case ToString__:
			case Invoke:
			case SetState:
			case Clone__:
			case DebugInfo:
			case Namespace__:
			case Class__:
			case Traic__:
			case Function__:
			case Method__:
			case Line__:
			case File__:
			case Dir__:
			case Inc:
			case Dec:
			case NamespaceSeparator:
			case Bang:
			case Plus:
			case Minus:
			case Tilde:
			case SuppressWarnings:
			case Dollar:
			case OpenRoundBracket:
			case OpenSquareBracket:
			case OpenCurlyBracket:
			case SemiColon:
			case VarName:
			case Label:
			case Octal:
			case Decimal:
			case Real:
			case Hex:
			case Binary:
			case BackQuoteString:
			case SingleQuoteString:
			case DoubleQuote:
			case StartNowDoc:
			case StartHereDoc:
				{
				State = 845;
				statement();
				}
				break;
			case Colon:
				{
				State = 846;
				Match(Colon);
				State = 847;
				innerStatementList();
				State = 848;
				Match(EndDeclare);
				State = 849;
				Match(SemiColon);
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

	public partial class InlineHtmlStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public InlineHtmlContext[] inlineHtml() {
			return GetRuleContexts<InlineHtmlContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public InlineHtmlContext inlineHtml(int i) {
			return GetRuleContext<InlineHtmlContext>(i);
		}
		public InlineHtmlStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_inlineHtmlStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterInlineHtmlStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitInlineHtmlStatement(this);
		}
	}

	[RuleVersion(0)]
	public InlineHtmlStatementContext inlineHtmlStatement() {
		InlineHtmlStatementContext _localctx = new InlineHtmlStatementContext(Context, State);
		EnterRule(_localctx, 108, RULE_inlineHtmlStatement);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 854;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 853;
					inlineHtml();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 856;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,83,Context);
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

	public partial class DeclareListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierInitializerContext[] identifierInitializer() {
			return GetRuleContexts<IdentifierInitializerContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierInitializerContext identifierInitializer(int i) {
			return GetRuleContext<IdentifierInitializerContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public DeclareListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declareList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterDeclareList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitDeclareList(this);
		}
	}

	[RuleVersion(0)]
	public DeclareListContext declareList() {
		DeclareListContext _localctx = new DeclareListContext(Context, State);
		EnterRule(_localctx, 110, RULE_declareList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 858;
			identifierInitializer();
			State = 863;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 859;
				Match(Comma);
				State = 860;
				identifierInitializer();
				}
				}
				State = 865;
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

	public partial class FormalParameterListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public FormalParameterContext[] formalParameter() {
			return GetRuleContexts<FormalParameterContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public FormalParameterContext formalParameter(int i) {
			return GetRuleContext<FormalParameterContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public FormalParameterListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_formalParameterList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterFormalParameterList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitFormalParameterList(this);
		}
	}

	[RuleVersion(0)]
	public FormalParameterListContext formalParameterList() {
		FormalParameterListContext _localctx = new FormalParameterListContext(Context, State);
		EnterRule(_localctx, 112, RULE_formalParameterList);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 867;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 43)) & ~0x3f) == 0 && ((1L << (_la - 43)) & ((1L << (AttributeStart - 43)) | (1L << (Abstract - 43)) | (1L << (Array - 43)) | (1L << (As - 43)) | (1L << (BinaryCast - 43)) | (1L << (BoolType - 43)) | (1L << (BooleanConstant - 43)) | (1L << (Break - 43)) | (1L << (Callable - 43)) | (1L << (Case - 43)) | (1L << (Catch - 43)) | (1L << (Class - 43)) | (1L << (Clone - 43)) | (1L << (Const - 43)) | (1L << (Continue - 43)) | (1L << (Declare - 43)) | (1L << (Default - 43)) | (1L << (Do - 43)) | (1L << (DoubleCast - 43)) | (1L << (DoubleType - 43)) | (1L << (Echo - 43)) | (1L << (Else - 43)) | (1L << (ElseIf - 43)) | (1L << (Empty - 43)) | (1L << (EndDeclare - 43)) | (1L << (EndFor - 43)) | (1L << (EndForeach - 43)) | (1L << (EndIf - 43)) | (1L << (EndSwitch - 43)) | (1L << (EndWhile - 43)) | (1L << (Eval - 43)) | (1L << (Exit - 43)) | (1L << (Extends - 43)) | (1L << (Final - 43)) | (1L << (Finally - 43)) | (1L << (FloatCast - 43)) | (1L << (For - 43)) | (1L << (Foreach - 43)) | (1L << (Function_ - 43)) | (1L << (Global - 43)) | (1L << (Goto - 43)) | (1L << (If - 43)) | (1L << (Implements - 43)) | (1L << (Import - 43)) | (1L << (Include - 43)) | (1L << (IncludeOnce - 43)) | (1L << (InstanceOf - 43)) | (1L << (InsteadOf - 43)) | (1L << (Int8Cast - 43)) | (1L << (Int16Cast - 43)) | (1L << (Int64Type - 43)) | (1L << (IntType - 43)) | (1L << (Interface - 43)) | (1L << (IsSet - 43)) | (1L << (List - 43)) | (1L << (LogicalAnd - 43)) | (1L << (LogicalOr - 43)) | (1L << (LogicalXor - 43)) | (1L << (Namespace - 43)) | (1L << (New - 43)) | (1L << (Null - 43)) | (1L << (ObjectType - 43)) | (1L << (Parent_ - 43)))) != 0) || ((((_la - 107)) & ~0x3f) == 0 && ((1L << (_la - 107)) & ((1L << (Partial - 107)) | (1L << (Print - 107)) | (1L << (Private - 107)) | (1L << (Protected - 107)) | (1L << (Public - 107)) | (1L << (Require - 107)) | (1L << (RequireOnce - 107)) | (1L << (Resource - 107)) | (1L << (Return - 107)) | (1L << (Static - 107)) | (1L << (StringType - 107)) | (1L << (Switch - 107)) | (1L << (Throw - 107)) | (1L << (Trait - 107)) | (1L << (Try - 107)) | (1L << (Typeof - 107)) | (1L << (UintCast - 107)) | (1L << (UnicodeCast - 107)) | (1L << (Unset - 107)) | (1L << (Use - 107)) | (1L << (Var - 107)) | (1L << (While - 107)) | (1L << (Yield - 107)) | (1L << (From - 107)) | (1L << (Get - 107)) | (1L << (Set - 107)) | (1L << (Call - 107)) | (1L << (CallStatic - 107)) | (1L << (Constructor - 107)) | (1L << (Destruct - 107)) | (1L << (Wakeup - 107)) | (1L << (Sleep - 107)) | (1L << (Autoload - 107)) | (1L << (IsSet__ - 107)) | (1L << (Unset__ - 107)) | (1L << (ToString__ - 107)) | (1L << (Invoke - 107)) | (1L << (SetState - 107)) | (1L << (Clone__ - 107)) | (1L << (DebugInfo - 107)) | (1L << (Namespace__ - 107)) | (1L << (Class__ - 107)) | (1L << (Traic__ - 107)) | (1L << (Function__ - 107)) | (1L << (Method__ - 107)) | (1L << (Line__ - 107)) | (1L << (File__ - 107)) | (1L << (Dir__ - 107)))) != 0) || ((((_la - 189)) & ~0x3f) == 0 && ((1L << (_la - 189)) & ((1L << (NamespaceSeparator - 189)) | (1L << (Ellipsis - 189)) | (1L << (Ampersand - 189)) | (1L << (QuestionMark - 189)) | (1L << (VarName - 189)) | (1L << (Label - 189)))) != 0)) {
				{
				State = 866;
				formalParameter();
				}
			}

			State = 873;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,86,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 869;
					Match(Comma);
					State = 870;
					formalParameter();
					}
					} 
				}
				State = 875;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,86,Context);
			}
			State = 877;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Comma) {
				{
				State = 876;
				Match(Comma);
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

	public partial class FormalParameterContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public VariableInitializerContext variableInitializer() {
			return GetRuleContext<VariableInitializerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MemberModifierContext memberModifier() {
			return GetRuleContext<MemberModifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode QuestionMark() { return GetToken(PhpParser.QuestionMark, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeHintContext typeHint() {
			return GetRuleContext<TypeHintContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ampersand() { return GetToken(PhpParser.Ampersand, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ellipsis() { return GetToken(PhpParser.Ellipsis, 0); }
		public FormalParameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_formalParameter; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterFormalParameter(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitFormalParameter(this);
		}
	}

	[RuleVersion(0)]
	public FormalParameterContext formalParameter() {
		FormalParameterContext _localctx = new FormalParameterContext(Context, State);
		EnterRule(_localctx, 114, RULE_formalParameter);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 880;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==AttributeStart) {
				{
				State = 879;
				attributes();
				}
			}

			State = 883;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,89,Context) ) {
			case 1:
				{
				State = 882;
				memberModifier();
				}
				break;
			}
			State = 886;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==QuestionMark) {
				{
				State = 885;
				Match(QuestionMark);
				}
			}

			State = 889;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)))) != 0) || _la==NamespaceSeparator || _la==Label) {
				{
				State = 888;
				typeHint(0);
				}
			}

			State = 892;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Ampersand) {
				{
				State = 891;
				Match(Ampersand);
				}
			}

			State = 895;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Ellipsis) {
				{
				State = 894;
				Match(Ellipsis);
				}
			}

			State = 897;
			variableInitializer();
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

	public partial class TypeHintContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedStaticTypeRefContext qualifiedStaticTypeRef() {
			return GetRuleContext<QualifiedStaticTypeRefContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Callable() { return GetToken(PhpParser.Callable, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public PrimitiveTypeContext primitiveType() {
			return GetRuleContext<PrimitiveTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeHintContext[] typeHint() {
			return GetRuleContexts<TypeHintContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeHintContext typeHint(int i) {
			return GetRuleContext<TypeHintContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Pipe() { return GetToken(PhpParser.Pipe, 0); }
		public TypeHintContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeHint; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterTypeHint(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitTypeHint(this);
		}
	}

	[RuleVersion(0)]
	public TypeHintContext typeHint() {
		return typeHint(0);
	}

	private TypeHintContext typeHint(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		TypeHintContext _localctx = new TypeHintContext(Context, _parentState);
		TypeHintContext _prevctx = _localctx;
		int _startState = 116;
		EnterRecursionRule(_localctx, 116, RULE_typeHint, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 903;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,94,Context) ) {
			case 1:
				{
				State = 900;
				qualifiedStaticTypeRef();
				}
				break;
			case 2:
				{
				State = 901;
				Match(Callable);
				}
				break;
			case 3:
				{
				State = 902;
				primitiveType();
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 910;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,95,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new TypeHintContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_typeHint);
					State = 905;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 906;
					Match(Pipe);
					State = 907;
					typeHint(2);
					}
					} 
				}
				State = 912;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,95,Context);
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

	public partial class GlobalStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Global() { return GetToken(PhpParser.Global, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public GlobalVarContext[] globalVar() {
			return GetRuleContexts<GlobalVarContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public GlobalVarContext globalVar(int i) {
			return GetRuleContext<GlobalVarContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public GlobalStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_globalStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterGlobalStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitGlobalStatement(this);
		}
	}

	[RuleVersion(0)]
	public GlobalStatementContext globalStatement() {
		GlobalStatementContext _localctx = new GlobalStatementContext(Context, State);
		EnterRule(_localctx, 118, RULE_globalStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 913;
			Match(Global);
			State = 914;
			globalVar();
			State = 919;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 915;
				Match(Comma);
				State = 916;
				globalVar();
				}
				}
				State = 921;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 922;
			Match(SemiColon);
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

	public partial class GlobalVarContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VarName() { return GetToken(PhpParser.VarName, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Dollar() { return GetToken(PhpParser.Dollar, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ChainContext chain() {
			return GetRuleContext<ChainContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenCurlyBracket() { return GetToken(PhpParser.OpenCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseCurlyBracket() { return GetToken(PhpParser.CloseCurlyBracket, 0); }
		public GlobalVarContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_globalVar; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterGlobalVar(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitGlobalVar(this);
		}
	}

	[RuleVersion(0)]
	public GlobalVarContext globalVar() {
		GlobalVarContext _localctx = new GlobalVarContext(Context, State);
		EnterRule(_localctx, 120, RULE_globalVar);
		try {
			State = 932;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,97,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 924;
				Match(VarName);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 925;
				Match(Dollar);
				State = 926;
				chain();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 927;
				Match(Dollar);
				State = 928;
				Match(OpenCurlyBracket);
				State = 929;
				expression(0);
				State = 930;
				Match(CloseCurlyBracket);
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

	public partial class EchoStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Echo() { return GetToken(PhpParser.Echo, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionListContext expressionList() {
			return GetRuleContext<ExpressionListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		public EchoStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_echoStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterEchoStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitEchoStatement(this);
		}
	}

	[RuleVersion(0)]
	public EchoStatementContext echoStatement() {
		EchoStatementContext _localctx = new EchoStatementContext(Context, State);
		EnterRule(_localctx, 122, RULE_echoStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 934;
			Match(Echo);
			State = 935;
			expressionList();
			State = 936;
			Match(SemiColon);
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

	public partial class StaticVariableStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Static() { return GetToken(PhpParser.Static, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public VariableInitializerContext[] variableInitializer() {
			return GetRuleContexts<VariableInitializerContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableInitializerContext variableInitializer(int i) {
			return GetRuleContext<VariableInitializerContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public StaticVariableStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_staticVariableStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterStaticVariableStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitStaticVariableStatement(this);
		}
	}

	[RuleVersion(0)]
	public StaticVariableStatementContext staticVariableStatement() {
		StaticVariableStatementContext _localctx = new StaticVariableStatementContext(Context, State);
		EnterRule(_localctx, 124, RULE_staticVariableStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 938;
			Match(Static);
			State = 939;
			variableInitializer();
			State = 944;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 940;
				Match(Comma);
				State = 941;
				variableInitializer();
				}
				}
				State = 946;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 947;
			Match(SemiColon);
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

	public partial class ClassStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PropertyModifiersContext propertyModifiers() {
			return GetRuleContext<PropertyModifiersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableInitializerContext[] variableInitializer() {
			return GetRuleContexts<VariableInitializerContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableInitializerContext variableInitializer(int i) {
			return GetRuleContext<VariableInitializerContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Const() { return GetToken(PhpParser.Const, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierInitializerContext[] identifierInitializer() {
			return GetRuleContexts<IdentifierInitializerContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierInitializerContext identifierInitializer(int i) {
			return GetRuleContext<IdentifierInitializerContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Function_() { return GetToken(PhpParser.Function_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenRoundBracket() { return GetToken(PhpParser.OpenRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public FormalParameterListContext formalParameterList() {
			return GetRuleContext<FormalParameterListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseRoundBracket() { return GetToken(PhpParser.CloseRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public MethodBodyContext methodBody() {
			return GetRuleContext<MethodBodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeHintContext typeHint() {
			return GetRuleContext<TypeHintContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MemberModifiersContext memberModifiers() {
			return GetRuleContext<MemberModifiersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ampersand() { return GetToken(PhpParser.Ampersand, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeParameterListInBracketsContext typeParameterListInBrackets() {
			return GetRuleContext<TypeParameterListInBracketsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BaseCtorCallContext baseCtorCall() {
			return GetRuleContext<BaseCtorCallContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Use() { return GetToken(PhpParser.Use, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedNamespaceNameListContext qualifiedNamespaceNameList() {
			return GetRuleContext<QualifiedNamespaceNameListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TraitAdaptationsContext traitAdaptations() {
			return GetRuleContext<TraitAdaptationsContext>(0);
		}
		public ClassStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterClassStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitClassStatement(this);
		}
	}

	[RuleVersion(0)]
	public ClassStatementContext classStatement() {
		ClassStatementContext _localctx = new ClassStatementContext(Context, State);
		EnterRule(_localctx, 126, RULE_classStatement);
		int _la;
		try {
			State = 1007;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case AttributeStart:
			case Abstract:
			case Const:
			case Final:
			case Function_:
			case Private:
			case Protected:
			case Public:
			case Static:
			case Var:
				EnterOuterAlt(_localctx, 1);
				{
				State = 950;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==AttributeStart) {
					{
					State = 949;
					attributes();
					}
				}

				State = 1001;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,109,Context) ) {
				case 1:
					{
					State = 952;
					propertyModifiers();
					State = 954;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)))) != 0) || _la==NamespaceSeparator || _la==Label) {
						{
						State = 953;
						typeHint(0);
						}
					}

					State = 956;
					variableInitializer();
					State = 961;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==Comma) {
						{
						{
						State = 957;
						Match(Comma);
						State = 958;
						variableInitializer();
						}
						}
						State = 963;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					State = 964;
					Match(SemiColon);
					}
					break;
				case 2:
					{
					State = 967;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==Abstract || ((((_la - 76)) & ~0x3f) == 0 && ((1L << (_la - 76)) & ((1L << (Final - 76)) | (1L << (Private - 76)) | (1L << (Protected - 76)) | (1L << (Public - 76)) | (1L << (Static - 76)))) != 0)) {
						{
						State = 966;
						memberModifiers();
						}
					}

					State = 999;
					ErrorHandler.Sync(this);
					switch (TokenStream.LA(1)) {
					case Const:
						{
						State = 969;
						Match(Const);
						State = 971;
						ErrorHandler.Sync(this);
						switch ( Interpreter.AdaptivePredict(TokenStream,103,Context) ) {
						case 1:
							{
							State = 970;
							typeHint(0);
							}
							break;
						}
						State = 973;
						identifierInitializer();
						State = 978;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						while (_la==Comma) {
							{
							{
							State = 974;
							Match(Comma);
							State = 975;
							identifierInitializer();
							}
							}
							State = 980;
							ErrorHandler.Sync(this);
							_la = TokenStream.LA(1);
						}
						State = 981;
						Match(SemiColon);
						}
						break;
					case Function_:
						{
						State = 983;
						Match(Function_);
						State = 985;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if (_la==Ampersand) {
							{
							State = 984;
							Match(Ampersand);
							}
						}

						State = 987;
						identifier();
						State = 989;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if (_la==Lgeneric) {
							{
							State = 988;
							typeParameterListInBrackets();
							}
						}

						State = 991;
						Match(OpenRoundBracket);
						State = 992;
						formalParameterList();
						State = 993;
						Match(CloseRoundBracket);
						State = 995;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if (_la==Colon) {
							{
							State = 994;
							baseCtorCall();
							}
						}

						State = 997;
						methodBody();
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					}
					break;
				}
				}
				break;
			case Use:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1003;
				Match(Use);
				State = 1004;
				qualifiedNamespaceNameList();
				State = 1005;
				traitAdaptations();
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

	public partial class TraitAdaptationsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenCurlyBracket() { return GetToken(PhpParser.OpenCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseCurlyBracket() { return GetToken(PhpParser.CloseCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TraitAdaptationStatementContext[] traitAdaptationStatement() {
			return GetRuleContexts<TraitAdaptationStatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TraitAdaptationStatementContext traitAdaptationStatement(int i) {
			return GetRuleContext<TraitAdaptationStatementContext>(i);
		}
		public TraitAdaptationsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_traitAdaptations; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterTraitAdaptations(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitTraitAdaptations(this);
		}
	}

	[RuleVersion(0)]
	public TraitAdaptationsContext traitAdaptations() {
		TraitAdaptationsContext _localctx = new TraitAdaptationsContext(Context, State);
		EnterRule(_localctx, 128, RULE_traitAdaptations);
		int _la;
		try {
			State = 1018;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case SemiColon:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1009;
				Match(SemiColon);
				}
				break;
			case OpenCurlyBracket:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1010;
				Match(OpenCurlyBracket);
				State = 1014;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)))) != 0) || _la==NamespaceSeparator || _la==Label) {
					{
					{
					State = 1011;
					traitAdaptationStatement();
					}
					}
					State = 1016;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 1017;
				Match(CloseCurlyBracket);
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

	public partial class TraitAdaptationStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TraitPrecedenceContext traitPrecedence() {
			return GetRuleContext<TraitPrecedenceContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TraitAliasContext traitAlias() {
			return GetRuleContext<TraitAliasContext>(0);
		}
		public TraitAdaptationStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_traitAdaptationStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterTraitAdaptationStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitTraitAdaptationStatement(this);
		}
	}

	[RuleVersion(0)]
	public TraitAdaptationStatementContext traitAdaptationStatement() {
		TraitAdaptationStatementContext _localctx = new TraitAdaptationStatementContext(Context, State);
		EnterRule(_localctx, 130, RULE_traitAdaptationStatement);
		try {
			State = 1022;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,113,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1020;
				traitPrecedence();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1021;
				traitAlias();
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

	public partial class TraitPrecedenceContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedNamespaceNameContext qualifiedNamespaceName() {
			return GetRuleContext<QualifiedNamespaceNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DoubleColon() { return GetToken(PhpParser.DoubleColon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode InsteadOf() { return GetToken(PhpParser.InsteadOf, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedNamespaceNameListContext qualifiedNamespaceNameList() {
			return GetRuleContext<QualifiedNamespaceNameListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		public TraitPrecedenceContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_traitPrecedence; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterTraitPrecedence(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitTraitPrecedence(this);
		}
	}

	[RuleVersion(0)]
	public TraitPrecedenceContext traitPrecedence() {
		TraitPrecedenceContext _localctx = new TraitPrecedenceContext(Context, State);
		EnterRule(_localctx, 132, RULE_traitPrecedence);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1024;
			qualifiedNamespaceName();
			State = 1025;
			Match(DoubleColon);
			State = 1026;
			identifier();
			State = 1027;
			Match(InsteadOf);
			State = 1028;
			qualifiedNamespaceNameList();
			State = 1029;
			Match(SemiColon);
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

	public partial class TraitAliasContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TraitMethodReferenceContext traitMethodReference() {
			return GetRuleContext<TraitMethodReferenceContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode As() { return GetToken(PhpParser.As, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public MemberModifierContext memberModifier() {
			return GetRuleContext<MemberModifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public TraitAliasContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_traitAlias; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterTraitAlias(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitTraitAlias(this);
		}
	}

	[RuleVersion(0)]
	public TraitAliasContext traitAlias() {
		TraitAliasContext _localctx = new TraitAliasContext(Context, State);
		EnterRule(_localctx, 134, RULE_traitAlias);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1031;
			traitMethodReference();
			State = 1032;
			Match(As);
			State = 1038;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,115,Context) ) {
			case 1:
				{
				State = 1033;
				memberModifier();
				}
				break;
			case 2:
				{
				State = 1035;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,114,Context) ) {
				case 1:
					{
					State = 1034;
					memberModifier();
					}
					break;
				}
				State = 1037;
				identifier();
				}
				break;
			}
			State = 1040;
			Match(SemiColon);
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

	public partial class TraitMethodReferenceContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedNamespaceNameContext qualifiedNamespaceName() {
			return GetRuleContext<QualifiedNamespaceNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DoubleColon() { return GetToken(PhpParser.DoubleColon, 0); }
		public TraitMethodReferenceContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_traitMethodReference; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterTraitMethodReference(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitTraitMethodReference(this);
		}
	}

	[RuleVersion(0)]
	public TraitMethodReferenceContext traitMethodReference() {
		TraitMethodReferenceContext _localctx = new TraitMethodReferenceContext(Context, State);
		EnterRule(_localctx, 136, RULE_traitMethodReference);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1045;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,116,Context) ) {
			case 1:
				{
				State = 1042;
				qualifiedNamespaceName();
				State = 1043;
				Match(DoubleColon);
				}
				break;
			}
			State = 1047;
			identifier();
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

	public partial class BaseCtorCallContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(PhpParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentsContext arguments() {
			return GetRuleContext<ArgumentsContext>(0);
		}
		public BaseCtorCallContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_baseCtorCall; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterBaseCtorCall(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitBaseCtorCall(this);
		}
	}

	[RuleVersion(0)]
	public BaseCtorCallContext baseCtorCall() {
		BaseCtorCallContext _localctx = new BaseCtorCallContext(Context, State);
		EnterRule(_localctx, 138, RULE_baseCtorCall);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1049;
			Match(Colon);
			State = 1050;
			identifier();
			State = 1052;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OpenRoundBracket) {
				{
				State = 1051;
				arguments();
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

	public partial class MethodBodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockStatementContext blockStatement() {
			return GetRuleContext<BlockStatementContext>(0);
		}
		public MethodBodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodBody; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterMethodBody(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitMethodBody(this);
		}
	}

	[RuleVersion(0)]
	public MethodBodyContext methodBody() {
		MethodBodyContext _localctx = new MethodBodyContext(Context, State);
		EnterRule(_localctx, 140, RULE_methodBody);
		try {
			State = 1056;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case SemiColon:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1054;
				Match(SemiColon);
				}
				break;
			case OpenCurlyBracket:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1055;
				blockStatement();
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

	public partial class PropertyModifiersContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public MemberModifiersContext memberModifiers() {
			return GetRuleContext<MemberModifiersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Var() { return GetToken(PhpParser.Var, 0); }
		public PropertyModifiersContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_propertyModifiers; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterPropertyModifiers(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitPropertyModifiers(this);
		}
	}

	[RuleVersion(0)]
	public PropertyModifiersContext propertyModifiers() {
		PropertyModifiersContext _localctx = new PropertyModifiersContext(Context, State);
		EnterRule(_localctx, 142, RULE_propertyModifiers);
		try {
			State = 1060;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Abstract:
			case Final:
			case Private:
			case Protected:
			case Public:
			case Static:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1058;
				memberModifiers();
				}
				break;
			case Var:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1059;
				Match(Var);
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

	public partial class MemberModifiersContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public MemberModifierContext[] memberModifier() {
			return GetRuleContexts<MemberModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public MemberModifierContext memberModifier(int i) {
			return GetRuleContext<MemberModifierContext>(i);
		}
		public MemberModifiersContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_memberModifiers; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterMemberModifiers(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitMemberModifiers(this);
		}
	}

	[RuleVersion(0)]
	public MemberModifiersContext memberModifiers() {
		MemberModifiersContext _localctx = new MemberModifiersContext(Context, State);
		EnterRule(_localctx, 144, RULE_memberModifiers);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1063;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 1062;
					memberModifier();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 1065;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,120,Context);
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

	public partial class VariableInitializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VarName() { return GetToken(PhpParser.VarName, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eq() { return GetToken(PhpParser.Eq, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantInitializerContext constantInitializer() {
			return GetRuleContext<ConstantInitializerContext>(0);
		}
		public VariableInitializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variableInitializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterVariableInitializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitVariableInitializer(this);
		}
	}

	[RuleVersion(0)]
	public VariableInitializerContext variableInitializer() {
		VariableInitializerContext _localctx = new VariableInitializerContext(Context, State);
		EnterRule(_localctx, 146, RULE_variableInitializer);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1067;
			Match(VarName);
			State = 1070;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Eq) {
				{
				State = 1068;
				Match(Eq);
				State = 1069;
				constantInitializer();
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

	public partial class IdentifierInitializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eq() { return GetToken(PhpParser.Eq, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantInitializerContext constantInitializer() {
			return GetRuleContext<ConstantInitializerContext>(0);
		}
		public IdentifierInitializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_identifierInitializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterIdentifierInitializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitIdentifierInitializer(this);
		}
	}

	[RuleVersion(0)]
	public IdentifierInitializerContext identifierInitializer() {
		IdentifierInitializerContext _localctx = new IdentifierInitializerContext(Context, State);
		EnterRule(_localctx, 148, RULE_identifierInitializer);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1072;
			identifier();
			State = 1073;
			Match(Eq);
			State = 1074;
			constantInitializer();
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

	public partial class GlobalConstantDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Const() { return GetToken(PhpParser.Const, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierInitializerContext[] identifierInitializer() {
			return GetRuleContexts<IdentifierInitializerContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierInitializerContext identifierInitializer(int i) {
			return GetRuleContext<IdentifierInitializerContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SemiColon() { return GetToken(PhpParser.SemiColon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public GlobalConstantDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_globalConstantDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterGlobalConstantDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitGlobalConstantDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public GlobalConstantDeclarationContext globalConstantDeclaration() {
		GlobalConstantDeclarationContext _localctx = new GlobalConstantDeclarationContext(Context, State);
		EnterRule(_localctx, 150, RULE_globalConstantDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1077;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==AttributeStart) {
				{
				State = 1076;
				attributes();
				}
			}

			State = 1079;
			Match(Const);
			State = 1080;
			identifierInitializer();
			State = 1085;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 1081;
				Match(Comma);
				State = 1082;
				identifierInitializer();
				}
				}
				State = 1087;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1088;
			Match(SemiColon);
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

	public partial class ExpressionListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public ExpressionListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expressionList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterExpressionList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitExpressionList(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionListContext expressionList() {
		ExpressionListContext _localctx = new ExpressionListContext(Context, State);
		EnterRule(_localctx, 152, RULE_expressionList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1090;
			expression(0);
			State = 1095;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 1091;
				Match(Comma);
				State = 1092;
				expression(0);
				}
				}
				State = 1097;
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

	public partial class ParenthesesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenRoundBracket() { return GetToken(PhpParser.OpenRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseRoundBracket() { return GetToken(PhpParser.CloseRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public YieldExpressionContext yieldExpression() {
			return GetRuleContext<YieldExpressionContext>(0);
		}
		public ParenthesesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parentheses; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterParentheses(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitParentheses(this);
		}
	}

	[RuleVersion(0)]
	public ParenthesesContext parentheses() {
		ParenthesesContext _localctx = new ParenthesesContext(Context, State);
		EnterRule(_localctx, 154, RULE_parentheses);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1098;
			Match(OpenRoundBracket);
			State = 1101;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,125,Context) ) {
			case 1:
				{
				State = 1099;
				expression(0);
				}
				break;
			case 2:
				{
				State = 1100;
				yieldExpression();
				}
				break;
			}
			State = 1103;
			Match(CloseRoundBracket);
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
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
	 
		public ExpressionContext() { }
		public virtual void CopyFrom(ExpressionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class ChainExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ChainContext chain() {
			return GetRuleContext<ChainContext>(0);
		}
		public ChainExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterChainExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitChainExpression(this);
		}
	}
	public partial class SpecialWordExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Yield() { return GetToken(PhpParser.Yield, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode List() { return GetToken(PhpParser.List, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenRoundBracket() { return GetToken(PhpParser.OpenRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentListContext assignmentList() {
			return GetRuleContext<AssignmentListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseRoundBracket() { return GetToken(PhpParser.CloseRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eq() { return GetToken(PhpParser.Eq, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IsSet() { return GetToken(PhpParser.IsSet, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ChainListContext chainList() {
			return GetRuleContext<ChainListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Empty() { return GetToken(PhpParser.Empty, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ChainContext chain() {
			return GetRuleContext<ChainContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eval() { return GetToken(PhpParser.Eval, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Exit() { return GetToken(PhpParser.Exit, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ParenthesesContext parentheses() {
			return GetRuleContext<ParenthesesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Include() { return GetToken(PhpParser.Include, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IncludeOnce() { return GetToken(PhpParser.IncludeOnce, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Require() { return GetToken(PhpParser.Require, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RequireOnce() { return GetToken(PhpParser.RequireOnce, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Throw() { return GetToken(PhpParser.Throw, 0); }
		public SpecialWordExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterSpecialWordExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitSpecialWordExpression(this);
		}
	}
	public partial class ArrayCreationExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ArrayCreationContext arrayCreation() {
			return GetRuleContext<ArrayCreationContext>(0);
		}
		public ArrayCreationExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterArrayCreationExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitArrayCreationExpression(this);
		}
	}
	public partial class BackQuoteStringExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BackQuoteString() { return GetToken(PhpParser.BackQuoteString, 0); }
		public BackQuoteStringExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterBackQuoteStringExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitBackQuoteStringExpression(this);
		}
	}
	public partial class MatchExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public MatchExprContext matchExpr() {
			return GetRuleContext<MatchExprContext>(0);
		}
		public MatchExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterMatchExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitMatchExpression(this);
		}
	}
	public partial class LogicalExpressionContext : ExpressionContext {
		public IToken op;
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LogicalAnd() { return GetToken(PhpParser.LogicalAnd, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LogicalXor() { return GetToken(PhpParser.LogicalXor, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LogicalOr() { return GetToken(PhpParser.LogicalOr, 0); }
		public LogicalExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterLogicalExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitLogicalExpression(this);
		}
	}
	public partial class PrintExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Print() { return GetToken(PhpParser.Print, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public PrintExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterPrintExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitPrintExpression(this);
		}
	}
	public partial class AssignmentExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public AssignableContext assignable() {
			return GetRuleContext<AssignableContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentOperatorContext assignmentOperator() {
			return GetRuleContext<AssignmentOperatorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eq() { return GetToken(PhpParser.Eq, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ampersand() { return GetToken(PhpParser.Ampersand, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ChainContext chain() {
			return GetRuleContext<ChainContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NewExprContext newExpr() {
			return GetRuleContext<NewExprContext>(0);
		}
		public AssignmentExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterAssignmentExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitAssignmentExpression(this);
		}
	}
	public partial class PostfixIncDecExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ChainContext chain() {
			return GetRuleContext<ChainContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Inc() { return GetToken(PhpParser.Inc, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Dec() { return GetToken(PhpParser.Dec, 0); }
		public PostfixIncDecExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterPostfixIncDecExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitPostfixIncDecExpression(this);
		}
	}
	public partial class CloneExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Clone() { return GetToken(PhpParser.Clone, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public CloneExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterCloneExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitCloneExpression(this);
		}
	}
	public partial class UnaryOperatorExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Tilde() { return GetToken(PhpParser.Tilde, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SuppressWarnings() { return GetToken(PhpParser.SuppressWarnings, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Bang() { return GetToken(PhpParser.Bang, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Plus() { return GetToken(PhpParser.Plus, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Minus() { return GetToken(PhpParser.Minus, 0); }
		public UnaryOperatorExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterUnaryOperatorExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitUnaryOperatorExpression(this);
		}
	}
	public partial class NewExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public NewExprContext newExpr() {
			return GetRuleContext<NewExprContext>(0);
		}
		public NewExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterNewExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitNewExpression(this);
		}
	}
	public partial class ParenthesisExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ParenthesesContext parentheses() {
			return GetRuleContext<ParenthesesContext>(0);
		}
		public ParenthesisExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterParenthesisExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitParenthesisExpression(this);
		}
	}
	public partial class SpaceshipExpressionContext : ExpressionContext {
		public IToken op;
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Spaceship() { return GetToken(PhpParser.Spaceship, 0); }
		public SpaceshipExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterSpaceshipExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitSpaceshipExpression(this);
		}
	}
	public partial class ConditionalExpressionContext : ExpressionContext {
		public IToken op;
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(PhpParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode QuestionMark() { return GetToken(PhpParser.QuestionMark, 0); }
		public ConditionalExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterConditionalExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitConditionalExpression(this);
		}
	}
	public partial class NullCoalescingExpressionContext : ExpressionContext {
		public IToken op;
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NullCoalescing() { return GetToken(PhpParser.NullCoalescing, 0); }
		public NullCoalescingExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterNullCoalescingExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitNullCoalescingExpression(this);
		}
	}
	public partial class ArithmeticExpressionContext : ExpressionContext {
		public IToken op;
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Pow() { return GetToken(PhpParser.Pow, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Asterisk() { return GetToken(PhpParser.Asterisk, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Divide() { return GetToken(PhpParser.Divide, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Percent() { return GetToken(PhpParser.Percent, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Plus() { return GetToken(PhpParser.Plus, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Minus() { return GetToken(PhpParser.Minus, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Dot() { return GetToken(PhpParser.Dot, 0); }
		public ArithmeticExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterArithmeticExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitArithmeticExpression(this);
		}
	}
	public partial class IndexerExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public StringConstantContext stringConstant() {
			return GetRuleContext<StringConstantContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenSquareBracket() { return GetToken(PhpParser.OpenSquareBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseSquareBracket() { return GetToken(PhpParser.CloseSquareBracket, 0); }
		public IndexerExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterIndexerExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitIndexerExpression(this);
		}
	}
	public partial class ScalarExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ConstantContext constant() {
			return GetRuleContext<ConstantContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StringContext @string() {
			return GetRuleContext<StringContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Label() { return GetToken(PhpParser.Label, 0); }
		public ScalarExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterScalarExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitScalarExpression(this);
		}
	}
	public partial class PrefixIncDecExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ChainContext chain() {
			return GetRuleContext<ChainContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Inc() { return GetToken(PhpParser.Inc, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Dec() { return GetToken(PhpParser.Dec, 0); }
		public PrefixIncDecExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterPrefixIncDecExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitPrefixIncDecExpression(this);
		}
	}
	public partial class ComparisonExpressionContext : ExpressionContext {
		public IToken op;
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ShiftLeft() { return GetToken(PhpParser.ShiftLeft, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ShiftRight() { return GetToken(PhpParser.ShiftRight, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Less() { return GetToken(PhpParser.Less, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IsSmallerOrEqual() { return GetToken(PhpParser.IsSmallerOrEqual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Greater() { return GetToken(PhpParser.Greater, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IsGreaterOrEqual() { return GetToken(PhpParser.IsGreaterOrEqual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IsIdentical() { return GetToken(PhpParser.IsIdentical, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IsNoidentical() { return GetToken(PhpParser.IsNoidentical, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IsEqual() { return GetToken(PhpParser.IsEqual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IsNotEq() { return GetToken(PhpParser.IsNotEq, 0); }
		public ComparisonExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterComparisonExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitComparisonExpression(this);
		}
	}
	public partial class CastExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenRoundBracket() { return GetToken(PhpParser.OpenRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public CastOperationContext castOperation() {
			return GetRuleContext<CastOperationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseRoundBracket() { return GetToken(PhpParser.CloseRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public CastExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterCastExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitCastExpression(this);
		}
	}
	public partial class InstanceOfExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode InstanceOf() { return GetToken(PhpParser.InstanceOf, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeRefContext typeRef() {
			return GetRuleContext<TypeRefContext>(0);
		}
		public InstanceOfExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterInstanceOfExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitInstanceOfExpression(this);
		}
	}
	public partial class LambdaFunctionExpressionContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public LambdaFunctionExprContext lambdaFunctionExpr() {
			return GetRuleContext<LambdaFunctionExprContext>(0);
		}
		public LambdaFunctionExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterLambdaFunctionExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitLambdaFunctionExpression(this);
		}
	}
	public partial class BitwiseExpressionContext : ExpressionContext {
		public IToken op;
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ampersand() { return GetToken(PhpParser.Ampersand, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Caret() { return GetToken(PhpParser.Caret, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Pipe() { return GetToken(PhpParser.Pipe, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BooleanAnd() { return GetToken(PhpParser.BooleanAnd, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BooleanOr() { return GetToken(PhpParser.BooleanOr, 0); }
		public BitwiseExpressionContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterBitwiseExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitBitwiseExpression(this);
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
		int _startState = 156;
		EnterRecursionRule(_localctx, 156, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1191;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,130,Context) ) {
			case 1:
				{
				_localctx = new CloneExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 1106;
				Match(Clone);
				State = 1107;
				expression(47);
				}
				break;
			case 2:
				{
				_localctx = new NewExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1108;
				newExpr();
				}
				break;
			case 3:
				{
				_localctx = new IndexerExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1109;
				stringConstant();
				State = 1110;
				Match(OpenSquareBracket);
				State = 1111;
				expression(0);
				State = 1112;
				Match(CloseSquareBracket);
				}
				break;
			case 4:
				{
				_localctx = new CastExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1114;
				Match(OpenRoundBracket);
				State = 1115;
				castOperation();
				State = 1116;
				Match(CloseRoundBracket);
				State = 1117;
				expression(44);
				}
				break;
			case 5:
				{
				_localctx = new UnaryOperatorExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1119;
				_la = TokenStream.LA(1);
				if ( !(_la==Tilde || _la==SuppressWarnings) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 1120;
				expression(43);
				}
				break;
			case 6:
				{
				_localctx = new UnaryOperatorExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1121;
				_la = TokenStream.LA(1);
				if ( !(((((_la - 195)) & ~0x3f) == 0 && ((1L << (_la - 195)) & ((1L << (Bang - 195)) | (1L << (Plus - 195)) | (1L << (Minus - 195)))) != 0)) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 1122;
				expression(42);
				}
				break;
			case 7:
				{
				_localctx = new PrefixIncDecExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1123;
				_la = TokenStream.LA(1);
				if ( !(_la==Inc || _la==Dec) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 1124;
				chain();
				}
				break;
			case 8:
				{
				_localctx = new PostfixIncDecExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1125;
				chain();
				State = 1126;
				_la = TokenStream.LA(1);
				if ( !(_la==Inc || _la==Dec) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
				break;
			case 9:
				{
				_localctx = new PrintExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1128;
				Match(Print);
				State = 1129;
				expression(39);
				}
				break;
			case 10:
				{
				_localctx = new ArrayCreationExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1130;
				arrayCreation();
				}
				break;
			case 11:
				{
				_localctx = new ChainExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1131;
				chain();
				}
				break;
			case 12:
				{
				_localctx = new ScalarExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1132;
				constant();
				}
				break;
			case 13:
				{
				_localctx = new ScalarExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1133;
				@string();
				}
				break;
			case 14:
				{
				_localctx = new ScalarExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1134;
				Match(Label);
				}
				break;
			case 15:
				{
				_localctx = new BackQuoteStringExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1135;
				Match(BackQuoteString);
				}
				break;
			case 16:
				{
				_localctx = new ParenthesisExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1136;
				parentheses();
				}
				break;
			case 17:
				{
				_localctx = new SpecialWordExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1137;
				Match(Yield);
				}
				break;
			case 18:
				{
				_localctx = new SpecialWordExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1138;
				Match(List);
				State = 1139;
				Match(OpenRoundBracket);
				State = 1140;
				assignmentList();
				State = 1141;
				Match(CloseRoundBracket);
				State = 1142;
				Match(Eq);
				State = 1143;
				expression(30);
				}
				break;
			case 19:
				{
				_localctx = new SpecialWordExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1145;
				Match(IsSet);
				State = 1146;
				Match(OpenRoundBracket);
				State = 1147;
				chainList();
				State = 1148;
				Match(CloseRoundBracket);
				}
				break;
			case 20:
				{
				_localctx = new SpecialWordExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1150;
				Match(Empty);
				State = 1151;
				Match(OpenRoundBracket);
				State = 1152;
				chain();
				State = 1153;
				Match(CloseRoundBracket);
				}
				break;
			case 21:
				{
				_localctx = new SpecialWordExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1155;
				Match(Eval);
				State = 1156;
				Match(OpenRoundBracket);
				State = 1157;
				expression(0);
				State = 1158;
				Match(CloseRoundBracket);
				}
				break;
			case 22:
				{
				_localctx = new SpecialWordExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1160;
				Match(Exit);
				State = 1164;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,126,Context) ) {
				case 1:
					{
					State = 1161;
					Match(OpenRoundBracket);
					State = 1162;
					Match(CloseRoundBracket);
					}
					break;
				case 2:
					{
					State = 1163;
					parentheses();
					}
					break;
				}
				}
				break;
			case 23:
				{
				_localctx = new SpecialWordExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1166;
				_la = TokenStream.LA(1);
				if ( !(_la==Include || _la==IncludeOnce) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 1167;
				expression(25);
				}
				break;
			case 24:
				{
				_localctx = new SpecialWordExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1168;
				_la = TokenStream.LA(1);
				if ( !(_la==Require || _la==RequireOnce) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 1169;
				expression(24);
				}
				break;
			case 25:
				{
				_localctx = new LambdaFunctionExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1170;
				lambdaFunctionExpr();
				}
				break;
			case 26:
				{
				_localctx = new MatchExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1171;
				matchExpr();
				}
				break;
			case 27:
				{
				_localctx = new SpecialWordExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1172;
				Match(Throw);
				State = 1173;
				expression(6);
				}
				break;
			case 28:
				{
				_localctx = new AssignmentExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1174;
				assignable();
				State = 1175;
				assignmentOperator();
				State = 1177;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==AttributeStart) {
					{
					State = 1176;
					attributes();
					}
				}

				State = 1179;
				expression(5);
				}
				break;
			case 29:
				{
				_localctx = new AssignmentExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 1181;
				assignable();
				State = 1182;
				Match(Eq);
				State = 1184;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==AttributeStart) {
					{
					State = 1183;
					attributes();
					}
				}

				State = 1186;
				Match(Ampersand);
				State = 1189;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,129,Context) ) {
				case 1:
					{
					State = 1187;
					chain();
					}
					break;
				case 2:
					{
					State = 1188;
					newExpr();
					}
					break;
				}
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 1253;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,133,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 1251;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,132,Context) ) {
					case 1:
						{
						_localctx = new ArithmeticExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 1193;
						if (!(Precpred(Context, 21))) throw new FailedPredicateException(this, "Precpred(Context, 21)");
						State = 1194;
						((ArithmeticExpressionContext)_localctx).op = Match(Pow);
						State = 1195;
						expression(21);
						}
						break;
					case 2:
						{
						_localctx = new ArithmeticExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 1196;
						if (!(Precpred(Context, 19))) throw new FailedPredicateException(this, "Precpred(Context, 19)");
						State = 1197;
						((ArithmeticExpressionContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(((((_la - 199)) & ~0x3f) == 0 && ((1L << (_la - 199)) & ((1L << (Asterisk - 199)) | (1L << (Percent - 199)) | (1L << (Divide - 199)))) != 0)) ) {
							((ArithmeticExpressionContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 1198;
						expression(20);
						}
						break;
					case 3:
						{
						_localctx = new ArithmeticExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 1199;
						if (!(Precpred(Context, 18))) throw new FailedPredicateException(this, "Precpred(Context, 18)");
						State = 1200;
						((ArithmeticExpressionContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(((((_la - 197)) & ~0x3f) == 0 && ((1L << (_la - 197)) & ((1L << (Plus - 197)) | (1L << (Minus - 197)) | (1L << (Dot - 197)))) != 0)) ) {
							((ArithmeticExpressionContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 1201;
						expression(19);
						}
						break;
					case 4:
						{
						_localctx = new ComparisonExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 1202;
						if (!(Precpred(Context, 17))) throw new FailedPredicateException(this, "Precpred(Context, 17)");
						State = 1203;
						((ComparisonExpressionContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==ShiftLeft || _la==ShiftRight) ) {
							((ComparisonExpressionContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 1204;
						expression(18);
						}
						break;
					case 5:
						{
						_localctx = new ComparisonExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 1205;
						if (!(Precpred(Context, 16))) throw new FailedPredicateException(this, "Precpred(Context, 16)");
						State = 1206;
						((ComparisonExpressionContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(((((_la - 166)) & ~0x3f) == 0 && ((1L << (_la - 166)) & ((1L << (IsSmallerOrEqual - 166)) | (1L << (IsGreaterOrEqual - 166)) | (1L << (Less - 166)) | (1L << (Greater - 166)))) != 0)) ) {
							((ComparisonExpressionContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 1207;
						expression(17);
						}
						break;
					case 6:
						{
						_localctx = new ComparisonExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 1208;
						if (!(Precpred(Context, 15))) throw new FailedPredicateException(this, "Precpred(Context, 15)");
						State = 1209;
						((ComparisonExpressionContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(((((_la - 162)) & ~0x3f) == 0 && ((1L << (_la - 162)) & ((1L << (IsIdentical - 162)) | (1L << (IsNoidentical - 162)) | (1L << (IsEqual - 162)) | (1L << (IsNotEq - 162)))) != 0)) ) {
							((ComparisonExpressionContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 1210;
						expression(16);
						}
						break;
					case 7:
						{
						_localctx = new BitwiseExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 1211;
						if (!(Precpred(Context, 14))) throw new FailedPredicateException(this, "Precpred(Context, 14)");
						State = 1212;
						((BitwiseExpressionContext)_localctx).op = Match(Ampersand);
						State = 1213;
						expression(15);
						}
						break;
					case 8:
						{
						_localctx = new BitwiseExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 1214;
						if (!(Precpred(Context, 13))) throw new FailedPredicateException(this, "Precpred(Context, 13)");
						State = 1215;
						((BitwiseExpressionContext)_localctx).op = Match(Caret);
						State = 1216;
						expression(14);
						}
						break;
					case 9:
						{
						_localctx = new BitwiseExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 1217;
						if (!(Precpred(Context, 12))) throw new FailedPredicateException(this, "Precpred(Context, 12)");
						State = 1218;
						((BitwiseExpressionContext)_localctx).op = Match(Pipe);
						State = 1219;
						expression(13);
						}
						break;
					case 10:
						{
						_localctx = new BitwiseExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 1220;
						if (!(Precpred(Context, 11))) throw new FailedPredicateException(this, "Precpred(Context, 11)");
						State = 1221;
						((BitwiseExpressionContext)_localctx).op = Match(BooleanAnd);
						State = 1222;
						expression(12);
						}
						break;
					case 11:
						{
						_localctx = new BitwiseExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 1223;
						if (!(Precpred(Context, 10))) throw new FailedPredicateException(this, "Precpred(Context, 10)");
						State = 1224;
						((BitwiseExpressionContext)_localctx).op = Match(BooleanOr);
						State = 1225;
						expression(11);
						}
						break;
					case 12:
						{
						_localctx = new ConditionalExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 1226;
						if (!(Precpred(Context, 9))) throw new FailedPredicateException(this, "Precpred(Context, 9)");
						State = 1227;
						((ConditionalExpressionContext)_localctx).op = Match(QuestionMark);
						State = 1229;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Match_ - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (LambdaFn - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)) | (1L << (Inc - 108)) | (1L << (Dec - 108)))) != 0) || ((((_la - 189)) & ~0x3f) == 0 && ((1L << (_la - 189)) & ((1L << (NamespaceSeparator - 189)) | (1L << (Bang - 189)) | (1L << (Plus - 189)) | (1L << (Minus - 189)) | (1L << (Tilde - 189)) | (1L << (SuppressWarnings - 189)) | (1L << (Dollar - 189)) | (1L << (OpenRoundBracket - 189)) | (1L << (OpenSquareBracket - 189)) | (1L << (VarName - 189)) | (1L << (Label - 189)) | (1L << (Octal - 189)) | (1L << (Decimal - 189)) | (1L << (Real - 189)) | (1L << (Hex - 189)) | (1L << (Binary - 189)) | (1L << (BackQuoteString - 189)) | (1L << (SingleQuoteString - 189)) | (1L << (DoubleQuote - 189)) | (1L << (StartNowDoc - 189)) | (1L << (StartHereDoc - 189)))) != 0)) {
							{
							State = 1228;
							expression(0);
							}
						}

						State = 1231;
						Match(Colon);
						State = 1232;
						expression(10);
						}
						break;
					case 13:
						{
						_localctx = new NullCoalescingExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 1233;
						if (!(Precpred(Context, 8))) throw new FailedPredicateException(this, "Precpred(Context, 8)");
						State = 1234;
						((NullCoalescingExpressionContext)_localctx).op = Match(NullCoalescing);
						State = 1235;
						expression(9);
						}
						break;
					case 14:
						{
						_localctx = new SpaceshipExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 1236;
						if (!(Precpred(Context, 7))) throw new FailedPredicateException(this, "Precpred(Context, 7)");
						State = 1237;
						((SpaceshipExpressionContext)_localctx).op = Match(Spaceship);
						State = 1238;
						expression(8);
						}
						break;
					case 15:
						{
						_localctx = new LogicalExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 1239;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 1240;
						((LogicalExpressionContext)_localctx).op = Match(LogicalAnd);
						State = 1241;
						expression(4);
						}
						break;
					case 16:
						{
						_localctx = new LogicalExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 1242;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 1243;
						((LogicalExpressionContext)_localctx).op = Match(LogicalXor);
						State = 1244;
						expression(3);
						}
						break;
					case 17:
						{
						_localctx = new LogicalExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 1245;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 1246;
						((LogicalExpressionContext)_localctx).op = Match(LogicalOr);
						State = 1247;
						expression(2);
						}
						break;
					case 18:
						{
						_localctx = new InstanceOfExpressionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 1248;
						if (!(Precpred(Context, 20))) throw new FailedPredicateException(this, "Precpred(Context, 20)");
						State = 1249;
						Match(InstanceOf);
						State = 1250;
						typeRef();
						}
						break;
					}
					} 
				}
				State = 1255;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,133,Context);
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

	public partial class AssignableContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ChainContext chain() {
			return GetRuleContext<ChainContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArrayCreationContext arrayCreation() {
			return GetRuleContext<ArrayCreationContext>(0);
		}
		public AssignableContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignable; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterAssignable(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitAssignable(this);
		}
	}

	[RuleVersion(0)]
	public AssignableContext assignable() {
		AssignableContext _localctx = new AssignableContext(Context, State);
		EnterRule(_localctx, 158, RULE_assignable);
		try {
			State = 1258;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,134,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1256;
				chain();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1257;
				arrayCreation();
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

	public partial class ArrayCreationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Array() { return GetToken(PhpParser.Array, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenRoundBracket() { return GetToken(PhpParser.OpenRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseRoundBracket() { return GetToken(PhpParser.CloseRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OpenSquareBracket() { return GetTokens(PhpParser.OpenSquareBracket); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenSquareBracket(int i) {
			return GetToken(PhpParser.OpenSquareBracket, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] CloseSquareBracket() { return GetTokens(PhpParser.CloseSquareBracket); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseSquareBracket(int i) {
			return GetToken(PhpParser.CloseSquareBracket, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArrayItemListContext arrayItemList() {
			return GetRuleContext<ArrayItemListContext>(0);
		}
		public ArrayCreationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_arrayCreation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterArrayCreation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitArrayCreation(this);
		}
	}

	[RuleVersion(0)]
	public ArrayCreationContext arrayCreation() {
		ArrayCreationContext _localctx = new ArrayCreationContext(Context, State);
		EnterRule(_localctx, 160, RULE_arrayCreation);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1271;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Array:
				{
				State = 1260;
				Match(Array);
				State = 1261;
				Match(OpenRoundBracket);
				State = 1263;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Match_ - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (LambdaFn - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)) | (1L << (Inc - 108)) | (1L << (Dec - 108)))) != 0) || ((((_la - 189)) & ~0x3f) == 0 && ((1L << (_la - 189)) & ((1L << (NamespaceSeparator - 189)) | (1L << (Ampersand - 189)) | (1L << (Bang - 189)) | (1L << (Plus - 189)) | (1L << (Minus - 189)) | (1L << (Tilde - 189)) | (1L << (SuppressWarnings - 189)) | (1L << (Dollar - 189)) | (1L << (OpenRoundBracket - 189)) | (1L << (OpenSquareBracket - 189)) | (1L << (VarName - 189)) | (1L << (Label - 189)) | (1L << (Octal - 189)) | (1L << (Decimal - 189)) | (1L << (Real - 189)) | (1L << (Hex - 189)) | (1L << (Binary - 189)) | (1L << (BackQuoteString - 189)) | (1L << (SingleQuoteString - 189)) | (1L << (DoubleQuote - 189)) | (1L << (StartNowDoc - 189)) | (1L << (StartHereDoc - 189)))) != 0)) {
					{
					State = 1262;
					arrayItemList();
					}
				}

				State = 1265;
				Match(CloseRoundBracket);
				}
				break;
			case OpenSquareBracket:
				{
				State = 1266;
				Match(OpenSquareBracket);
				State = 1268;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Match_ - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (LambdaFn - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)) | (1L << (Inc - 108)) | (1L << (Dec - 108)))) != 0) || ((((_la - 189)) & ~0x3f) == 0 && ((1L << (_la - 189)) & ((1L << (NamespaceSeparator - 189)) | (1L << (Ampersand - 189)) | (1L << (Bang - 189)) | (1L << (Plus - 189)) | (1L << (Minus - 189)) | (1L << (Tilde - 189)) | (1L << (SuppressWarnings - 189)) | (1L << (Dollar - 189)) | (1L << (OpenRoundBracket - 189)) | (1L << (OpenSquareBracket - 189)) | (1L << (VarName - 189)) | (1L << (Label - 189)) | (1L << (Octal - 189)) | (1L << (Decimal - 189)) | (1L << (Real - 189)) | (1L << (Hex - 189)) | (1L << (Binary - 189)) | (1L << (BackQuoteString - 189)) | (1L << (SingleQuoteString - 189)) | (1L << (DoubleQuote - 189)) | (1L << (StartNowDoc - 189)) | (1L << (StartHereDoc - 189)))) != 0)) {
					{
					State = 1267;
					arrayItemList();
					}
				}

				State = 1270;
				Match(CloseSquareBracket);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 1277;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,138,Context) ) {
			case 1:
				{
				State = 1273;
				Match(OpenSquareBracket);
				State = 1274;
				expression(0);
				State = 1275;
				Match(CloseSquareBracket);
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

	public partial class LambdaFunctionExprContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Function_() { return GetToken(PhpParser.Function_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenRoundBracket() { return GetToken(PhpParser.OpenRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public FormalParameterListContext formalParameterList() {
			return GetRuleContext<FormalParameterListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseRoundBracket() { return GetToken(PhpParser.CloseRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockStatementContext blockStatement() {
			return GetRuleContext<BlockStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Static() { return GetToken(PhpParser.Static, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ampersand() { return GetToken(PhpParser.Ampersand, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public LambdaFunctionUseVarsContext lambdaFunctionUseVars() {
			return GetRuleContext<LambdaFunctionUseVarsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(PhpParser.Colon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeHintContext typeHint() {
			return GetRuleContext<TypeHintContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LambdaFn() { return GetToken(PhpParser.LambdaFn, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DoubleArrow() { return GetToken(PhpParser.DoubleArrow, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public LambdaFunctionExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lambdaFunctionExpr; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterLambdaFunctionExpr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitLambdaFunctionExpr(this);
		}
	}

	[RuleVersion(0)]
	public LambdaFunctionExprContext lambdaFunctionExpr() {
		LambdaFunctionExprContext _localctx = new LambdaFunctionExprContext(Context, State);
		EnterRule(_localctx, 162, RULE_lambdaFunctionExpr);
		int _la;
		try {
			State = 1305;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Function_:
			case Static:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1280;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Static) {
					{
					State = 1279;
					Match(Static);
					}
				}

				State = 1282;
				Match(Function_);
				State = 1284;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Ampersand) {
					{
					State = 1283;
					Match(Ampersand);
					}
				}

				State = 1286;
				Match(OpenRoundBracket);
				State = 1287;
				formalParameterList();
				State = 1288;
				Match(CloseRoundBracket);
				State = 1290;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Use) {
					{
					State = 1289;
					lambdaFunctionUseVars();
					}
				}

				State = 1294;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Colon) {
					{
					State = 1292;
					Match(Colon);
					State = 1293;
					typeHint(0);
					}
				}

				State = 1296;
				blockStatement();
				}
				break;
			case LambdaFn:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1298;
				Match(LambdaFn);
				State = 1299;
				Match(OpenRoundBracket);
				State = 1300;
				formalParameterList();
				State = 1301;
				Match(CloseRoundBracket);
				State = 1302;
				Match(DoubleArrow);
				State = 1303;
				expression(0);
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

	public partial class MatchExprContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Match_() { return GetToken(PhpParser.Match_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenRoundBracket() { return GetToken(PhpParser.OpenRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseRoundBracket() { return GetToken(PhpParser.CloseRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenCurlyBracket() { return GetToken(PhpParser.OpenCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public MatchItemContext[] matchItem() {
			return GetRuleContexts<MatchItemContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public MatchItemContext matchItem(int i) {
			return GetRuleContext<MatchItemContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseCurlyBracket() { return GetToken(PhpParser.CloseCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public MatchExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_matchExpr; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterMatchExpr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitMatchExpr(this);
		}
	}

	[RuleVersion(0)]
	public MatchExprContext matchExpr() {
		MatchExprContext _localctx = new MatchExprContext(Context, State);
		EnterRule(_localctx, 164, RULE_matchExpr);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1307;
			Match(Match_);
			State = 1308;
			Match(OpenRoundBracket);
			State = 1309;
			expression(0);
			State = 1310;
			Match(CloseRoundBracket);
			State = 1311;
			Match(OpenCurlyBracket);
			State = 1312;
			matchItem();
			State = 1317;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,144,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1313;
					Match(Comma);
					State = 1314;
					matchItem();
					}
					} 
				}
				State = 1319;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,144,Context);
			}
			State = 1321;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Comma) {
				{
				State = 1320;
				Match(Comma);
				}
			}

			State = 1323;
			Match(CloseCurlyBracket);
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

	public partial class MatchItemContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DoubleArrow() { return GetToken(PhpParser.DoubleArrow, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public MatchItemContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_matchItem; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterMatchItem(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitMatchItem(this);
		}
	}

	[RuleVersion(0)]
	public MatchItemContext matchItem() {
		MatchItemContext _localctx = new MatchItemContext(Context, State);
		EnterRule(_localctx, 166, RULE_matchItem);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1325;
			expression(0);
			State = 1330;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 1326;
				Match(Comma);
				State = 1327;
				expression(0);
				}
				}
				State = 1332;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1333;
			Match(DoubleArrow);
			State = 1334;
			expression(0);
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

	public partial class NewExprContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode New() { return GetToken(PhpParser.New, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeRefContext typeRef() {
			return GetRuleContext<TypeRefContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentsContext arguments() {
			return GetRuleContext<ArgumentsContext>(0);
		}
		public NewExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_newExpr; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterNewExpr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitNewExpr(this);
		}
	}

	[RuleVersion(0)]
	public NewExprContext newExpr() {
		NewExprContext _localctx = new NewExprContext(Context, State);
		EnterRule(_localctx, 168, RULE_newExpr);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1336;
			Match(New);
			State = 1337;
			typeRef();
			State = 1339;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,147,Context) ) {
			case 1:
				{
				State = 1338;
				arguments();
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

	public partial class AssignmentOperatorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eq() { return GetToken(PhpParser.Eq, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PlusEqual() { return GetToken(PhpParser.PlusEqual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MinusEqual() { return GetToken(PhpParser.MinusEqual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MulEqual() { return GetToken(PhpParser.MulEqual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PowEqual() { return GetToken(PhpParser.PowEqual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DivEqual() { return GetToken(PhpParser.DivEqual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Concaequal() { return GetToken(PhpParser.Concaequal, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ModEqual() { return GetToken(PhpParser.ModEqual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AndEqual() { return GetToken(PhpParser.AndEqual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OrEqual() { return GetToken(PhpParser.OrEqual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode XorEqual() { return GetToken(PhpParser.XorEqual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ShiftLeftEqual() { return GetToken(PhpParser.ShiftLeftEqual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ShiftRightEqual() { return GetToken(PhpParser.ShiftRightEqual, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NullCoalescingEqual() { return GetToken(PhpParser.NullCoalescingEqual, 0); }
		public AssignmentOperatorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignmentOperator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterAssignmentOperator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitAssignmentOperator(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentOperatorContext assignmentOperator() {
		AssignmentOperatorContext _localctx = new AssignmentOperatorContext(Context, State);
		EnterRule(_localctx, 170, RULE_assignmentOperator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1341;
			_la = TokenStream.LA(1);
			if ( !(((((_la - 168)) & ~0x3f) == 0 && ((1L << (_la - 168)) & ((1L << (PlusEqual - 168)) | (1L << (MinusEqual - 168)) | (1L << (MulEqual - 168)) | (1L << (PowEqual - 168)) | (1L << (DivEqual - 168)) | (1L << (Concaequal - 168)) | (1L << (ModEqual - 168)) | (1L << (ShiftLeftEqual - 168)) | (1L << (ShiftRightEqual - 168)) | (1L << (AndEqual - 168)) | (1L << (OrEqual - 168)) | (1L << (XorEqual - 168)) | (1L << (NullCoalescingEqual - 168)) | (1L << (Eq - 168)))) != 0)) ) {
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

	public partial class YieldExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Yield() { return GetToken(PhpParser.Yield, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode From() { return GetToken(PhpParser.From, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DoubleArrow() { return GetToken(PhpParser.DoubleArrow, 0); }
		public YieldExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_yieldExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterYieldExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitYieldExpression(this);
		}
	}

	[RuleVersion(0)]
	public YieldExpressionContext yieldExpression() {
		YieldExpressionContext _localctx = new YieldExpressionContext(Context, State);
		EnterRule(_localctx, 172, RULE_yieldExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1343;
			Match(Yield);
			State = 1351;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,149,Context) ) {
			case 1:
				{
				State = 1344;
				expression(0);
				State = 1347;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==DoubleArrow) {
					{
					State = 1345;
					Match(DoubleArrow);
					State = 1346;
					expression(0);
					}
				}

				}
				break;
			case 2:
				{
				State = 1349;
				Match(From);
				State = 1350;
				expression(0);
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

	public partial class ArrayItemListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ArrayItemContext[] arrayItem() {
			return GetRuleContexts<ArrayItemContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArrayItemContext arrayItem(int i) {
			return GetRuleContext<ArrayItemContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public ArrayItemListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_arrayItemList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterArrayItemList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitArrayItemList(this);
		}
	}

	[RuleVersion(0)]
	public ArrayItemListContext arrayItemList() {
		ArrayItemListContext _localctx = new ArrayItemListContext(Context, State);
		EnterRule(_localctx, 174, RULE_arrayItemList);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1353;
			arrayItem();
			State = 1358;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,150,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1354;
					Match(Comma);
					State = 1355;
					arrayItem();
					}
					} 
				}
				State = 1360;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,150,Context);
			}
			State = 1362;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,151,Context) ) {
			case 1:
				{
				State = 1361;
				Match(Comma);
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

	public partial class ArrayItemContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DoubleArrow() { return GetToken(PhpParser.DoubleArrow, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ampersand() { return GetToken(PhpParser.Ampersand, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ChainContext chain() {
			return GetRuleContext<ChainContext>(0);
		}
		public ArrayItemContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_arrayItem; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterArrayItem(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitArrayItem(this);
		}
	}

	[RuleVersion(0)]
	public ArrayItemContext arrayItem() {
		ArrayItemContext _localctx = new ArrayItemContext(Context, State);
		EnterRule(_localctx, 176, RULE_arrayItem);
		int _la;
		try {
			State = 1376;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,154,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1364;
				expression(0);
				State = 1367;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==DoubleArrow) {
					{
					State = 1365;
					Match(DoubleArrow);
					State = 1366;
					expression(0);
					}
				}

				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1372;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Match_ - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (LambdaFn - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)) | (1L << (Inc - 108)) | (1L << (Dec - 108)))) != 0) || ((((_la - 189)) & ~0x3f) == 0 && ((1L << (_la - 189)) & ((1L << (NamespaceSeparator - 189)) | (1L << (Bang - 189)) | (1L << (Plus - 189)) | (1L << (Minus - 189)) | (1L << (Tilde - 189)) | (1L << (SuppressWarnings - 189)) | (1L << (Dollar - 189)) | (1L << (OpenRoundBracket - 189)) | (1L << (OpenSquareBracket - 189)) | (1L << (VarName - 189)) | (1L << (Label - 189)) | (1L << (Octal - 189)) | (1L << (Decimal - 189)) | (1L << (Real - 189)) | (1L << (Hex - 189)) | (1L << (Binary - 189)) | (1L << (BackQuoteString - 189)) | (1L << (SingleQuoteString - 189)) | (1L << (DoubleQuote - 189)) | (1L << (StartNowDoc - 189)) | (1L << (StartHereDoc - 189)))) != 0)) {
					{
					State = 1369;
					expression(0);
					State = 1370;
					Match(DoubleArrow);
					}
				}

				State = 1374;
				Match(Ampersand);
				State = 1375;
				chain();
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

	public partial class LambdaFunctionUseVarsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Use() { return GetToken(PhpParser.Use, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenRoundBracket() { return GetToken(PhpParser.OpenRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public LambdaFunctionUseVarContext[] lambdaFunctionUseVar() {
			return GetRuleContexts<LambdaFunctionUseVarContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public LambdaFunctionUseVarContext lambdaFunctionUseVar(int i) {
			return GetRuleContext<LambdaFunctionUseVarContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseRoundBracket() { return GetToken(PhpParser.CloseRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public LambdaFunctionUseVarsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lambdaFunctionUseVars; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterLambdaFunctionUseVars(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitLambdaFunctionUseVars(this);
		}
	}

	[RuleVersion(0)]
	public LambdaFunctionUseVarsContext lambdaFunctionUseVars() {
		LambdaFunctionUseVarsContext _localctx = new LambdaFunctionUseVarsContext(Context, State);
		EnterRule(_localctx, 178, RULE_lambdaFunctionUseVars);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1378;
			Match(Use);
			State = 1379;
			Match(OpenRoundBracket);
			State = 1380;
			lambdaFunctionUseVar();
			State = 1385;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 1381;
				Match(Comma);
				State = 1382;
				lambdaFunctionUseVar();
				}
				}
				State = 1387;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1388;
			Match(CloseRoundBracket);
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

	public partial class LambdaFunctionUseVarContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VarName() { return GetToken(PhpParser.VarName, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ampersand() { return GetToken(PhpParser.Ampersand, 0); }
		public LambdaFunctionUseVarContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lambdaFunctionUseVar; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterLambdaFunctionUseVar(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitLambdaFunctionUseVar(this);
		}
	}

	[RuleVersion(0)]
	public LambdaFunctionUseVarContext lambdaFunctionUseVar() {
		LambdaFunctionUseVarContext _localctx = new LambdaFunctionUseVarContext(Context, State);
		EnterRule(_localctx, 180, RULE_lambdaFunctionUseVar);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1391;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Ampersand) {
				{
				State = 1390;
				Match(Ampersand);
				}
			}

			State = 1393;
			Match(VarName);
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

	public partial class QualifiedStaticTypeRefContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedNamespaceNameContext qualifiedNamespaceName() {
			return GetRuleContext<QualifiedNamespaceNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public GenericDynamicArgsContext genericDynamicArgs() {
			return GetRuleContext<GenericDynamicArgsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Static() { return GetToken(PhpParser.Static, 0); }
		public QualifiedStaticTypeRefContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_qualifiedStaticTypeRef; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterQualifiedStaticTypeRef(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitQualifiedStaticTypeRef(this);
		}
	}

	[RuleVersion(0)]
	public QualifiedStaticTypeRefContext qualifiedStaticTypeRef() {
		QualifiedStaticTypeRefContext _localctx = new QualifiedStaticTypeRefContext(Context, State);
		EnterRule(_localctx, 182, RULE_qualifiedStaticTypeRef);
		try {
			State = 1400;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,158,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1395;
				qualifiedNamespaceName();
				State = 1397;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,157,Context) ) {
				case 1:
					{
					State = 1396;
					genericDynamicArgs();
					}
					break;
				}
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1399;
				Match(Static);
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

	public partial class TypeRefContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedNamespaceNameContext qualifiedNamespaceName() {
			return GetRuleContext<QualifiedNamespaceNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IndirectTypeRefContext indirectTypeRef() {
			return GetRuleContext<IndirectTypeRefContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public GenericDynamicArgsContext genericDynamicArgs() {
			return GetRuleContext<GenericDynamicArgsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PrimitiveTypeContext primitiveType() {
			return GetRuleContext<PrimitiveTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Static() { return GetToken(PhpParser.Static, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AnonymousClassContext anonymousClass() {
			return GetRuleContext<AnonymousClassContext>(0);
		}
		public TypeRefContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeRef; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterTypeRef(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitTypeRef(this);
		}
	}

	[RuleVersion(0)]
	public TypeRefContext typeRef() {
		TypeRefContext _localctx = new TypeRefContext(Context, State);
		EnterRule(_localctx, 184, RULE_typeRef);
		try {
			State = 1412;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,161,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1404;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,159,Context) ) {
				case 1:
					{
					State = 1402;
					qualifiedNamespaceName();
					}
					break;
				case 2:
					{
					State = 1403;
					indirectTypeRef();
					}
					break;
				}
				State = 1407;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,160,Context) ) {
				case 1:
					{
					State = 1406;
					genericDynamicArgs();
					}
					break;
				}
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1409;
				primitiveType();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1410;
				Match(Static);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1411;
				anonymousClass();
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

	public partial class AnonymousClassContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenCurlyBracket() { return GetToken(PhpParser.OpenCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseCurlyBracket() { return GetToken(PhpParser.CloseCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ClassEntryTypeContext classEntryType() {
			return GetRuleContext<ClassEntryTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Interface() { return GetToken(PhpParser.Interface, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Private() { return GetToken(PhpParser.Private, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ModifierContext modifier() {
			return GetRuleContext<ModifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Partial() { return GetToken(PhpParser.Partial, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ClassStatementContext[] classStatement() {
			return GetRuleContexts<ClassStatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassStatementContext classStatement(int i) {
			return GetRuleContext<ClassStatementContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeParameterListInBracketsContext typeParameterListInBrackets() {
			return GetRuleContext<TypeParameterListInBracketsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Extends() { return GetToken(PhpParser.Extends, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedStaticTypeRefContext qualifiedStaticTypeRef() {
			return GetRuleContext<QualifiedStaticTypeRefContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Implements() { return GetToken(PhpParser.Implements, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceListContext interfaceList() {
			return GetRuleContext<InterfaceListContext>(0);
		}
		public AnonymousClassContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_anonymousClass; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterAnonymousClass(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitAnonymousClass(this);
		}
	}

	[RuleVersion(0)]
	public AnonymousClassContext anonymousClass() {
		AnonymousClassContext _localctx = new AnonymousClassContext(Context, State);
		EnterRule(_localctx, 186, RULE_anonymousClass);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1415;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==AttributeStart) {
				{
				State = 1414;
				attributes();
				}
			}

			State = 1418;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Private) {
				{
				State = 1417;
				Match(Private);
				}
			}

			State = 1421;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Abstract || _la==Final) {
				{
				State = 1420;
				modifier();
				}
			}

			State = 1424;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Partial) {
				{
				State = 1423;
				Match(Partial);
				}
			}

			State = 1447;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Class:
			case Trait:
				{
				State = 1426;
				classEntryType();
				State = 1428;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Lgeneric) {
					{
					State = 1427;
					typeParameterListInBrackets();
					}
				}

				State = 1432;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Extends) {
					{
					State = 1430;
					Match(Extends);
					State = 1431;
					qualifiedStaticTypeRef();
					}
				}

				State = 1436;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Implements) {
					{
					State = 1434;
					Match(Implements);
					State = 1435;
					interfaceList();
					}
				}

				}
				break;
			case Interface:
				{
				State = 1438;
				Match(Interface);
				State = 1439;
				identifier();
				State = 1441;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Lgeneric) {
					{
					State = 1440;
					typeParameterListInBrackets();
					}
				}

				State = 1445;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Extends) {
					{
					State = 1443;
					Match(Extends);
					State = 1444;
					interfaceList();
					}
				}

				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 1449;
			Match(OpenCurlyBracket);
			State = 1453;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << AttributeStart) | (1L << Abstract) | (1L << Const))) != 0) || ((((_la - 76)) & ~0x3f) == 0 && ((1L << (_la - 76)) & ((1L << (Final - 76)) | (1L << (Function_ - 76)) | (1L << (Private - 76)) | (1L << (Protected - 76)) | (1L << (Public - 76)) | (1L << (Static - 76)) | (1L << (Use - 76)) | (1L << (Var - 76)))) != 0)) {
				{
				{
				State = 1450;
				classStatement();
				}
				}
				State = 1455;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1456;
			Match(CloseCurlyBracket);
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

	public partial class IndirectTypeRefContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ChainBaseContext chainBase() {
			return GetRuleContext<ChainBaseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ObjectOperator() { return GetTokens(PhpParser.ObjectOperator); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ObjectOperator(int i) {
			return GetToken(PhpParser.ObjectOperator, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public KeyedFieldNameContext[] keyedFieldName() {
			return GetRuleContexts<KeyedFieldNameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public KeyedFieldNameContext keyedFieldName(int i) {
			return GetRuleContext<KeyedFieldNameContext>(i);
		}
		public IndirectTypeRefContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_indirectTypeRef; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterIndirectTypeRef(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitIndirectTypeRef(this);
		}
	}

	[RuleVersion(0)]
	public IndirectTypeRefContext indirectTypeRef() {
		IndirectTypeRefContext _localctx = new IndirectTypeRefContext(Context, State);
		EnterRule(_localctx, 188, RULE_indirectTypeRef);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1458;
			chainBase();
			State = 1463;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,173,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1459;
					Match(ObjectOperator);
					State = 1460;
					keyedFieldName();
					}
					} 
				}
				State = 1465;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,173,Context);
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

	public partial class QualifiedNamespaceNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public NamespaceNameListContext namespaceNameList() {
			return GetRuleContext<NamespaceNameListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Namespace() { return GetToken(PhpParser.Namespace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NamespaceSeparator() { return GetToken(PhpParser.NamespaceSeparator, 0); }
		public QualifiedNamespaceNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_qualifiedNamespaceName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterQualifiedNamespaceName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitQualifiedNamespaceName(this);
		}
	}

	[RuleVersion(0)]
	public QualifiedNamespaceNameContext qualifiedNamespaceName() {
		QualifiedNamespaceNameContext _localctx = new QualifiedNamespaceNameContext(Context, State);
		EnterRule(_localctx, 190, RULE_qualifiedNamespaceName);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1467;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,174,Context) ) {
			case 1:
				{
				State = 1466;
				Match(Namespace);
				}
				break;
			}
			State = 1470;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==NamespaceSeparator) {
				{
				State = 1469;
				Match(NamespaceSeparator);
				}
			}

			State = 1472;
			namespaceNameList();
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

	public partial class NamespaceNameListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] NamespaceSeparator() { return GetTokens(PhpParser.NamespaceSeparator); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NamespaceSeparator(int i) {
			return GetToken(PhpParser.NamespaceSeparator, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NamespaceNameTailContext namespaceNameTail() {
			return GetRuleContext<NamespaceNameTailContext>(0);
		}
		public NamespaceNameListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namespaceNameList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterNamespaceNameList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitNamespaceNameList(this);
		}
	}

	[RuleVersion(0)]
	public NamespaceNameListContext namespaceNameList() {
		NamespaceNameListContext _localctx = new NamespaceNameListContext(Context, State);
		EnterRule(_localctx, 192, RULE_namespaceNameList);
		try {
			int _alt;
			State = 1487;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,178,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1474;
				identifier();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1475;
				identifier();
				State = 1480;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,176,Context);
				while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						State = 1476;
						Match(NamespaceSeparator);
						State = 1477;
						identifier();
						}
						} 
					}
					State = 1482;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,176,Context);
				}
				State = 1485;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,177,Context) ) {
				case 1:
					{
					State = 1483;
					Match(NamespaceSeparator);
					State = 1484;
					namespaceNameTail();
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

	public partial class NamespaceNameTailContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode As() { return GetToken(PhpParser.As, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenCurlyBracket() { return GetToken(PhpParser.OpenCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NamespaceNameTailContext[] namespaceNameTail() {
			return GetRuleContexts<NamespaceNameTailContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public NamespaceNameTailContext namespaceNameTail(int i) {
			return GetRuleContext<NamespaceNameTailContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseCurlyBracket() { return GetToken(PhpParser.CloseCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public NamespaceNameTailContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namespaceNameTail; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterNamespaceNameTail(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitNamespaceNameTail(this);
		}
	}

	[RuleVersion(0)]
	public NamespaceNameTailContext namespaceNameTail() {
		NamespaceNameTailContext _localctx = new NamespaceNameTailContext(Context, State);
		EnterRule(_localctx, 194, RULE_namespaceNameTail);
		int _la;
		try {
			int _alt;
			State = 1508;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Abstract:
			case Array:
			case As:
			case BinaryCast:
			case BoolType:
			case BooleanConstant:
			case Break:
			case Callable:
			case Case:
			case Catch:
			case Class:
			case Clone:
			case Const:
			case Continue:
			case Declare:
			case Default:
			case Do:
			case DoubleCast:
			case DoubleType:
			case Echo:
			case Else:
			case ElseIf:
			case Empty:
			case EndDeclare:
			case EndFor:
			case EndForeach:
			case EndIf:
			case EndSwitch:
			case EndWhile:
			case Eval:
			case Exit:
			case Extends:
			case Final:
			case Finally:
			case FloatCast:
			case For:
			case Foreach:
			case Function_:
			case Global:
			case Goto:
			case If:
			case Implements:
			case Import:
			case Include:
			case IncludeOnce:
			case InstanceOf:
			case InsteadOf:
			case Int8Cast:
			case Int16Cast:
			case Int64Type:
			case IntType:
			case Interface:
			case IsSet:
			case List:
			case LogicalAnd:
			case LogicalOr:
			case LogicalXor:
			case Namespace:
			case New:
			case Null:
			case ObjectType:
			case Parent_:
			case Partial:
			case Print:
			case Private:
			case Protected:
			case Public:
			case Require:
			case RequireOnce:
			case Resource:
			case Return:
			case Static:
			case StringType:
			case Switch:
			case Throw:
			case Trait:
			case Try:
			case Typeof:
			case UintCast:
			case UnicodeCast:
			case Unset:
			case Use:
			case Var:
			case While:
			case Yield:
			case From:
			case Get:
			case Set:
			case Call:
			case CallStatic:
			case Constructor:
			case Destruct:
			case Wakeup:
			case Sleep:
			case Autoload:
			case IsSet__:
			case Unset__:
			case ToString__:
			case Invoke:
			case SetState:
			case Clone__:
			case DebugInfo:
			case Namespace__:
			case Class__:
			case Traic__:
			case Function__:
			case Method__:
			case Line__:
			case File__:
			case Dir__:
			case Label:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1489;
				identifier();
				State = 1492;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,179,Context) ) {
				case 1:
					{
					State = 1490;
					Match(As);
					State = 1491;
					identifier();
					}
					break;
				}
				}
				break;
			case OpenCurlyBracket:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1494;
				Match(OpenCurlyBracket);
				State = 1495;
				namespaceNameTail();
				State = 1500;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,180,Context);
				while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						State = 1496;
						Match(Comma);
						State = 1497;
						namespaceNameTail();
						}
						} 
					}
					State = 1502;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,180,Context);
				}
				State = 1504;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Comma) {
					{
					State = 1503;
					Match(Comma);
					}
				}

				State = 1506;
				Match(CloseCurlyBracket);
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

	public partial class QualifiedNamespaceNameListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedNamespaceNameContext[] qualifiedNamespaceName() {
			return GetRuleContexts<QualifiedNamespaceNameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedNamespaceNameContext qualifiedNamespaceName(int i) {
			return GetRuleContext<QualifiedNamespaceNameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public QualifiedNamespaceNameListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_qualifiedNamespaceNameList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterQualifiedNamespaceNameList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitQualifiedNamespaceNameList(this);
		}
	}

	[RuleVersion(0)]
	public QualifiedNamespaceNameListContext qualifiedNamespaceNameList() {
		QualifiedNamespaceNameListContext _localctx = new QualifiedNamespaceNameListContext(Context, State);
		EnterRule(_localctx, 196, RULE_qualifiedNamespaceNameList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1510;
			qualifiedNamespaceName();
			State = 1515;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 1511;
				Match(Comma);
				State = 1512;
				qualifiedNamespaceName();
				}
				}
				State = 1517;
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

	public partial class ArgumentsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenRoundBracket() { return GetToken(PhpParser.OpenRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseRoundBracket() { return GetToken(PhpParser.CloseRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ActualArgumentContext[] actualArgument() {
			return GetRuleContexts<ActualArgumentContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ActualArgumentContext actualArgument(int i) {
			return GetRuleContext<ActualArgumentContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public YieldExpressionContext yieldExpression() {
			return GetRuleContext<YieldExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public ArgumentsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_arguments; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterArguments(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitArguments(this);
		}
	}

	[RuleVersion(0)]
	public ArgumentsContext arguments() {
		ArgumentsContext _localctx = new ArgumentsContext(Context, State);
		EnterRule(_localctx, 198, RULE_arguments);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1518;
			Match(OpenRoundBracket);
			State = 1528;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,185,Context) ) {
			case 1:
				{
				State = 1519;
				actualArgument();
				State = 1524;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,184,Context);
				while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						State = 1520;
						Match(Comma);
						State = 1521;
						actualArgument();
						}
						} 
					}
					State = 1526;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,184,Context);
				}
				}
				break;
			case 2:
				{
				State = 1527;
				yieldExpression();
				}
				break;
			}
			State = 1531;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Comma) {
				{
				State = 1530;
				Match(Comma);
				}
			}

			State = 1533;
			Match(CloseRoundBracket);
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

	public partial class ActualArgumentContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentNameContext argumentName() {
			return GetRuleContext<ArgumentNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ellipsis() { return GetToken(PhpParser.Ellipsis, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Ampersand() { return GetToken(PhpParser.Ampersand, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ChainContext chain() {
			return GetRuleContext<ChainContext>(0);
		}
		public ActualArgumentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_actualArgument; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterActualArgument(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitActualArgument(this);
		}
	}

	[RuleVersion(0)]
	public ActualArgumentContext actualArgument() {
		ActualArgumentContext _localctx = new ActualArgumentContext(Context, State);
		EnterRule(_localctx, 200, RULE_actualArgument);
		int _la;
		try {
			State = 1544;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Abstract:
			case Array:
			case As:
			case BinaryCast:
			case BoolType:
			case BooleanConstant:
			case Break:
			case Callable:
			case Case:
			case Catch:
			case Class:
			case Clone:
			case Const:
			case Continue:
			case Declare:
			case Default:
			case Do:
			case DoubleCast:
			case DoubleType:
			case Echo:
			case Else:
			case ElseIf:
			case Empty:
			case EndDeclare:
			case EndFor:
			case EndForeach:
			case EndIf:
			case EndSwitch:
			case EndWhile:
			case Eval:
			case Exit:
			case Extends:
			case Final:
			case Finally:
			case FloatCast:
			case For:
			case Foreach:
			case Function_:
			case Global:
			case Goto:
			case If:
			case Implements:
			case Import:
			case Include:
			case IncludeOnce:
			case InstanceOf:
			case InsteadOf:
			case Int8Cast:
			case Int16Cast:
			case Int64Type:
			case IntType:
			case Interface:
			case IsSet:
			case List:
			case LogicalAnd:
			case LogicalOr:
			case LogicalXor:
			case Match_:
			case Namespace:
			case New:
			case Null:
			case ObjectType:
			case Parent_:
			case Partial:
			case Print:
			case Private:
			case Protected:
			case Public:
			case Require:
			case RequireOnce:
			case Resource:
			case Return:
			case Static:
			case StringType:
			case Switch:
			case Throw:
			case Trait:
			case Try:
			case Typeof:
			case UintCast:
			case UnicodeCast:
			case Unset:
			case Use:
			case Var:
			case While:
			case Yield:
			case From:
			case LambdaFn:
			case Get:
			case Set:
			case Call:
			case CallStatic:
			case Constructor:
			case Destruct:
			case Wakeup:
			case Sleep:
			case Autoload:
			case IsSet__:
			case Unset__:
			case ToString__:
			case Invoke:
			case SetState:
			case Clone__:
			case DebugInfo:
			case Namespace__:
			case Class__:
			case Traic__:
			case Function__:
			case Method__:
			case Line__:
			case File__:
			case Dir__:
			case Inc:
			case Dec:
			case NamespaceSeparator:
			case Ellipsis:
			case Bang:
			case Plus:
			case Minus:
			case Tilde:
			case SuppressWarnings:
			case Dollar:
			case OpenRoundBracket:
			case OpenSquareBracket:
			case VarName:
			case Label:
			case Octal:
			case Decimal:
			case Real:
			case Hex:
			case Binary:
			case BackQuoteString:
			case SingleQuoteString:
			case DoubleQuote:
			case StartNowDoc:
			case StartHereDoc:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1536;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,187,Context) ) {
				case 1:
					{
					State = 1535;
					argumentName();
					}
					break;
				}
				State = 1539;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==Ellipsis) {
					{
					State = 1538;
					Match(Ellipsis);
					}
				}

				State = 1541;
				expression(0);
				}
				break;
			case Ampersand:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1542;
				Match(Ampersand);
				State = 1543;
				chain();
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

	public partial class ArgumentNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Colon() { return GetToken(PhpParser.Colon, 0); }
		public ArgumentNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_argumentName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterArgumentName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitArgumentName(this);
		}
	}

	[RuleVersion(0)]
	public ArgumentNameContext argumentName() {
		ArgumentNameContext _localctx = new ArgumentNameContext(Context, State);
		EnterRule(_localctx, 202, RULE_argumentName);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1546;
			identifier();
			State = 1547;
			Match(Colon);
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

	public partial class ConstantInitializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ConstantContext constant() {
			return GetRuleContext<ConstantContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StringContext @string() {
			return GetRuleContext<StringContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Array() { return GetToken(PhpParser.Array, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenRoundBracket() { return GetToken(PhpParser.OpenRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseRoundBracket() { return GetToken(PhpParser.CloseRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ArrayItemListContext arrayItemList() {
			return GetRuleContext<ArrayItemListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma() { return GetToken(PhpParser.Comma, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenSquareBracket() { return GetToken(PhpParser.OpenSquareBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseSquareBracket() { return GetToken(PhpParser.CloseSquareBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantInitializerContext constantInitializer() {
			return GetRuleContext<ConstantInitializerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Plus() { return GetToken(PhpParser.Plus, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Minus() { return GetToken(PhpParser.Minus, 0); }
		public ConstantInitializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constantInitializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterConstantInitializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitConstantInitializer(this);
		}
	}

	[RuleVersion(0)]
	public ConstantInitializerContext constantInitializer() {
		ConstantInitializerContext _localctx = new ConstantInitializerContext(Context, State);
		EnterRule(_localctx, 204, RULE_constantInitializer);
		int _la;
		try {
			State = 1570;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,194,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1549;
				constant();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1550;
				@string();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1551;
				Match(Array);
				State = 1552;
				Match(OpenRoundBracket);
				State = 1557;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Match_ - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (LambdaFn - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)) | (1L << (Inc - 108)) | (1L << (Dec - 108)))) != 0) || ((((_la - 189)) & ~0x3f) == 0 && ((1L << (_la - 189)) & ((1L << (NamespaceSeparator - 189)) | (1L << (Ampersand - 189)) | (1L << (Bang - 189)) | (1L << (Plus - 189)) | (1L << (Minus - 189)) | (1L << (Tilde - 189)) | (1L << (SuppressWarnings - 189)) | (1L << (Dollar - 189)) | (1L << (OpenRoundBracket - 189)) | (1L << (OpenSquareBracket - 189)) | (1L << (VarName - 189)) | (1L << (Label - 189)) | (1L << (Octal - 189)) | (1L << (Decimal - 189)) | (1L << (Real - 189)) | (1L << (Hex - 189)) | (1L << (Binary - 189)) | (1L << (BackQuoteString - 189)) | (1L << (SingleQuoteString - 189)) | (1L << (DoubleQuote - 189)) | (1L << (StartNowDoc - 189)) | (1L << (StartHereDoc - 189)))) != 0)) {
					{
					State = 1553;
					arrayItemList();
					State = 1555;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==Comma) {
						{
						State = 1554;
						Match(Comma);
						}
					}

					}
				}

				State = 1559;
				Match(CloseRoundBracket);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1560;
				Match(OpenSquareBracket);
				State = 1565;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Match_ - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (LambdaFn - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)) | (1L << (Inc - 108)) | (1L << (Dec - 108)))) != 0) || ((((_la - 189)) & ~0x3f) == 0 && ((1L << (_la - 189)) & ((1L << (NamespaceSeparator - 189)) | (1L << (Ampersand - 189)) | (1L << (Bang - 189)) | (1L << (Plus - 189)) | (1L << (Minus - 189)) | (1L << (Tilde - 189)) | (1L << (SuppressWarnings - 189)) | (1L << (Dollar - 189)) | (1L << (OpenRoundBracket - 189)) | (1L << (OpenSquareBracket - 189)) | (1L << (VarName - 189)) | (1L << (Label - 189)) | (1L << (Octal - 189)) | (1L << (Decimal - 189)) | (1L << (Real - 189)) | (1L << (Hex - 189)) | (1L << (Binary - 189)) | (1L << (BackQuoteString - 189)) | (1L << (SingleQuoteString - 189)) | (1L << (DoubleQuote - 189)) | (1L << (StartNowDoc - 189)) | (1L << (StartHereDoc - 189)))) != 0)) {
					{
					State = 1561;
					arrayItemList();
					State = 1563;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==Comma) {
						{
						State = 1562;
						Match(Comma);
						}
					}

					}
				}

				State = 1567;
				Match(CloseSquareBracket);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1568;
				_la = TokenStream.LA(1);
				if ( !(_la==Plus || _la==Minus) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 1569;
				constantInitializer();
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

	public partial class ConstantContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Null() { return GetToken(PhpParser.Null, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public LiteralConstantContext literalConstant() {
			return GetRuleContext<LiteralConstantContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MagicConstantContext magicConstant() {
			return GetRuleContext<MagicConstantContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassConstantContext classConstant() {
			return GetRuleContext<ClassConstantContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedNamespaceNameContext qualifiedNamespaceName() {
			return GetRuleContext<QualifiedNamespaceNameContext>(0);
		}
		public ConstantContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constant; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterConstant(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitConstant(this);
		}
	}

	[RuleVersion(0)]
	public ConstantContext constant() {
		ConstantContext _localctx = new ConstantContext(Context, State);
		EnterRule(_localctx, 206, RULE_constant);
		try {
			State = 1577;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,195,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1572;
				Match(Null);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1573;
				literalConstant();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1574;
				magicConstant();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1575;
				classConstant();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1576;
				qualifiedNamespaceName();
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

	public partial class LiteralConstantContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Real() { return GetToken(PhpParser.Real, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BooleanConstant() { return GetToken(PhpParser.BooleanConstant, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NumericConstantContext numericConstant() {
			return GetRuleContext<NumericConstantContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StringConstantContext stringConstant() {
			return GetRuleContext<StringConstantContext>(0);
		}
		public LiteralConstantContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_literalConstant; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterLiteralConstant(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitLiteralConstant(this);
		}
	}

	[RuleVersion(0)]
	public LiteralConstantContext literalConstant() {
		LiteralConstantContext _localctx = new LiteralConstantContext(Context, State);
		EnterRule(_localctx, 208, RULE_literalConstant);
		try {
			State = 1583;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Real:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1579;
				Match(Real);
				}
				break;
			case BooleanConstant:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1580;
				Match(BooleanConstant);
				}
				break;
			case Octal:
			case Decimal:
			case Hex:
			case Binary:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1581;
				numericConstant();
				}
				break;
			case Label:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1582;
				stringConstant();
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

	public partial class NumericConstantContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Octal() { return GetToken(PhpParser.Octal, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Decimal() { return GetToken(PhpParser.Decimal, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Hex() { return GetToken(PhpParser.Hex, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Binary() { return GetToken(PhpParser.Binary, 0); }
		public NumericConstantContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_numericConstant; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterNumericConstant(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitNumericConstant(this);
		}
	}

	[RuleVersion(0)]
	public NumericConstantContext numericConstant() {
		NumericConstantContext _localctx = new NumericConstantContext(Context, State);
		EnterRule(_localctx, 210, RULE_numericConstant);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1585;
			_la = TokenStream.LA(1);
			if ( !(((((_la - 221)) & ~0x3f) == 0 && ((1L << (_la - 221)) & ((1L << (Octal - 221)) | (1L << (Decimal - 221)) | (1L << (Hex - 221)) | (1L << (Binary - 221)))) != 0)) ) {
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

	public partial class ClassConstantContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DoubleColon() { return GetToken(PhpParser.DoubleColon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Class() { return GetToken(PhpParser.Class, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Parent_() { return GetToken(PhpParser.Parent_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Constructor() { return GetToken(PhpParser.Constructor, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Get() { return GetToken(PhpParser.Get, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Set() { return GetToken(PhpParser.Set, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedStaticTypeRefContext qualifiedStaticTypeRef() {
			return GetRuleContext<QualifiedStaticTypeRefContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public KeyedVariableContext[] keyedVariable() {
			return GetRuleContexts<KeyedVariableContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public KeyedVariableContext keyedVariable(int i) {
			return GetRuleContext<KeyedVariableContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StringContext @string() {
			return GetRuleContext<StringContext>(0);
		}
		public ClassConstantContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classConstant; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterClassConstant(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitClassConstant(this);
		}
	}

	[RuleVersion(0)]
	public ClassConstantContext classConstant() {
		ClassConstantContext _localctx = new ClassConstantContext(Context, State);
		EnterRule(_localctx, 212, RULE_classConstant);
		int _la;
		try {
			State = 1605;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,200,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1587;
				_la = TokenStream.LA(1);
				if ( !(_la==Class || _la==Parent_) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 1588;
				Match(DoubleColon);
				State = 1593;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,197,Context) ) {
				case 1:
					{
					State = 1589;
					identifier();
					}
					break;
				case 2:
					{
					State = 1590;
					Match(Constructor);
					}
					break;
				case 3:
					{
					State = 1591;
					Match(Get);
					}
					break;
				case 4:
					{
					State = 1592;
					Match(Set);
					}
					break;
				}
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1598;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case Abstract:
				case Array:
				case As:
				case BinaryCast:
				case BoolType:
				case BooleanConstant:
				case Break:
				case Callable:
				case Case:
				case Catch:
				case Class:
				case Clone:
				case Const:
				case Continue:
				case Declare:
				case Default:
				case Do:
				case DoubleCast:
				case DoubleType:
				case Echo:
				case Else:
				case ElseIf:
				case Empty:
				case EndDeclare:
				case EndFor:
				case EndForeach:
				case EndIf:
				case EndSwitch:
				case EndWhile:
				case Eval:
				case Exit:
				case Extends:
				case Final:
				case Finally:
				case FloatCast:
				case For:
				case Foreach:
				case Function_:
				case Global:
				case Goto:
				case If:
				case Implements:
				case Import:
				case Include:
				case IncludeOnce:
				case InstanceOf:
				case InsteadOf:
				case Int8Cast:
				case Int16Cast:
				case Int64Type:
				case IntType:
				case Interface:
				case IsSet:
				case List:
				case LogicalAnd:
				case LogicalOr:
				case LogicalXor:
				case Namespace:
				case New:
				case Null:
				case ObjectType:
				case Parent_:
				case Partial:
				case Print:
				case Private:
				case Protected:
				case Public:
				case Require:
				case RequireOnce:
				case Resource:
				case Return:
				case Static:
				case StringType:
				case Switch:
				case Throw:
				case Trait:
				case Try:
				case Typeof:
				case UintCast:
				case UnicodeCast:
				case Unset:
				case Use:
				case Var:
				case While:
				case Yield:
				case From:
				case Get:
				case Set:
				case Call:
				case CallStatic:
				case Constructor:
				case Destruct:
				case Wakeup:
				case Sleep:
				case Autoload:
				case IsSet__:
				case Unset__:
				case ToString__:
				case Invoke:
				case SetState:
				case Clone__:
				case DebugInfo:
				case Namespace__:
				case Class__:
				case Traic__:
				case Function__:
				case Method__:
				case Line__:
				case File__:
				case Dir__:
				case NamespaceSeparator:
				case Label:
					{
					State = 1595;
					qualifiedStaticTypeRef();
					}
					break;
				case Dollar:
				case VarName:
					{
					State = 1596;
					keyedVariable();
					}
					break;
				case SingleQuoteString:
				case DoubleQuote:
				case StartNowDoc:
				case StartHereDoc:
					{
					State = 1597;
					@string();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 1600;
				Match(DoubleColon);
				State = 1603;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case Abstract:
				case Array:
				case As:
				case BinaryCast:
				case BoolType:
				case BooleanConstant:
				case Break:
				case Callable:
				case Case:
				case Catch:
				case Class:
				case Clone:
				case Const:
				case Continue:
				case Declare:
				case Default:
				case Do:
				case DoubleCast:
				case DoubleType:
				case Echo:
				case Else:
				case ElseIf:
				case Empty:
				case EndDeclare:
				case EndFor:
				case EndForeach:
				case EndIf:
				case EndSwitch:
				case EndWhile:
				case Eval:
				case Exit:
				case Extends:
				case Final:
				case Finally:
				case FloatCast:
				case For:
				case Foreach:
				case Function_:
				case Global:
				case Goto:
				case If:
				case Implements:
				case Import:
				case Include:
				case IncludeOnce:
				case InstanceOf:
				case InsteadOf:
				case Int8Cast:
				case Int16Cast:
				case Int64Type:
				case IntType:
				case Interface:
				case IsSet:
				case List:
				case LogicalAnd:
				case LogicalOr:
				case LogicalXor:
				case Namespace:
				case New:
				case Null:
				case ObjectType:
				case Parent_:
				case Partial:
				case Print:
				case Private:
				case Protected:
				case Public:
				case Require:
				case RequireOnce:
				case Resource:
				case Return:
				case Static:
				case StringType:
				case Switch:
				case Throw:
				case Trait:
				case Try:
				case Typeof:
				case UintCast:
				case UnicodeCast:
				case Unset:
				case Use:
				case Var:
				case While:
				case Yield:
				case From:
				case Get:
				case Set:
				case Call:
				case CallStatic:
				case Constructor:
				case Destruct:
				case Wakeup:
				case Sleep:
				case Autoload:
				case IsSet__:
				case Unset__:
				case ToString__:
				case Invoke:
				case SetState:
				case Clone__:
				case DebugInfo:
				case Namespace__:
				case Class__:
				case Traic__:
				case Function__:
				case Method__:
				case Line__:
				case File__:
				case Dir__:
				case Label:
					{
					State = 1601;
					identifier();
					}
					break;
				case Dollar:
				case VarName:
					{
					State = 1602;
					keyedVariable();
					}
					break;
				default:
					throw new NoViableAltException(this);
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

	public partial class StringConstantContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Label() { return GetToken(PhpParser.Label, 0); }
		public StringConstantContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_stringConstant; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterStringConstant(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitStringConstant(this);
		}
	}

	[RuleVersion(0)]
	public StringConstantContext stringConstant() {
		StringConstantContext _localctx = new StringConstantContext(Context, State);
		EnterRule(_localctx, 214, RULE_stringConstant);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1607;
			Match(Label);
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

	public partial class StringContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode StartHereDoc() { return GetToken(PhpParser.StartHereDoc, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] HereDocText() { return GetTokens(PhpParser.HereDocText); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HereDocText(int i) {
			return GetToken(PhpParser.HereDocText, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode StartNowDoc() { return GetToken(PhpParser.StartNowDoc, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SingleQuoteString() { return GetToken(PhpParser.SingleQuoteString, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DoubleQuote() { return GetTokens(PhpParser.DoubleQuote); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DoubleQuote(int i) {
			return GetToken(PhpParser.DoubleQuote, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InterpolatedStringPartContext[] interpolatedStringPart() {
			return GetRuleContexts<InterpolatedStringPartContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public InterpolatedStringPartContext interpolatedStringPart(int i) {
			return GetRuleContext<InterpolatedStringPartContext>(i);
		}
		public StringContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_string; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterString(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitString(this);
		}
	}

	[RuleVersion(0)]
	public StringContext @string() {
		StringContext _localctx = new StringContext(Context, State);
		EnterRule(_localctx, 216, RULE_string);
		try {
			int _alt;
			State = 1630;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case StartHereDoc:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1609;
				Match(StartHereDoc);
				State = 1611;
				ErrorHandler.Sync(this);
				_alt = 1;
				do {
					switch (_alt) {
					case 1:
						{
						{
						State = 1610;
						Match(HereDocText);
						}
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					State = 1613;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,201,Context);
				} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
				}
				break;
			case StartNowDoc:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1615;
				Match(StartNowDoc);
				State = 1617;
				ErrorHandler.Sync(this);
				_alt = 1;
				do {
					switch (_alt) {
					case 1:
						{
						{
						State = 1616;
						Match(HereDocText);
						}
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					State = 1619;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,202,Context);
				} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
				}
				break;
			case SingleQuoteString:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1621;
				Match(SingleQuoteString);
				}
				break;
			case DoubleQuote:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1622;
				Match(DoubleQuote);
				State = 1626;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,203,Context);
				while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						State = 1623;
						interpolatedStringPart();
						}
						} 
					}
					State = 1628;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,203,Context);
				}
				State = 1629;
				Match(DoubleQuote);
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

	public partial class InterpolatedStringPartContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode StringPart() { return GetToken(PhpParser.StringPart, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UnicodeEscape() { return GetToken(PhpParser.UnicodeEscape, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ChainContext chain() {
			return GetRuleContext<ChainContext>(0);
		}
		public InterpolatedStringPartContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interpolatedStringPart; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterInterpolatedStringPart(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitInterpolatedStringPart(this);
		}
	}

	[RuleVersion(0)]
	public InterpolatedStringPartContext interpolatedStringPart() {
		InterpolatedStringPartContext _localctx = new InterpolatedStringPartContext(Context, State);
		EnterRule(_localctx, 218, RULE_interpolatedStringPart);
		try {
			State = 1635;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case StringPart:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1632;
				Match(StringPart);
				}
				break;
			case UnicodeEscape:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1633;
				Match(UnicodeEscape);
				}
				break;
			case Abstract:
			case Array:
			case As:
			case BinaryCast:
			case BoolType:
			case BooleanConstant:
			case Break:
			case Callable:
			case Case:
			case Catch:
			case Class:
			case Clone:
			case Const:
			case Continue:
			case Declare:
			case Default:
			case Do:
			case DoubleCast:
			case DoubleType:
			case Echo:
			case Else:
			case ElseIf:
			case Empty:
			case EndDeclare:
			case EndFor:
			case EndForeach:
			case EndIf:
			case EndSwitch:
			case EndWhile:
			case Eval:
			case Exit:
			case Extends:
			case Final:
			case Finally:
			case FloatCast:
			case For:
			case Foreach:
			case Function_:
			case Global:
			case Goto:
			case If:
			case Implements:
			case Import:
			case Include:
			case IncludeOnce:
			case InstanceOf:
			case InsteadOf:
			case Int8Cast:
			case Int16Cast:
			case Int64Type:
			case IntType:
			case Interface:
			case IsSet:
			case List:
			case LogicalAnd:
			case LogicalOr:
			case LogicalXor:
			case Namespace:
			case New:
			case Null:
			case ObjectType:
			case Parent_:
			case Partial:
			case Print:
			case Private:
			case Protected:
			case Public:
			case Require:
			case RequireOnce:
			case Resource:
			case Return:
			case Static:
			case StringType:
			case Switch:
			case Throw:
			case Trait:
			case Try:
			case Typeof:
			case UintCast:
			case UnicodeCast:
			case Unset:
			case Use:
			case Var:
			case While:
			case Yield:
			case From:
			case Get:
			case Set:
			case Call:
			case CallStatic:
			case Constructor:
			case Destruct:
			case Wakeup:
			case Sleep:
			case Autoload:
			case IsSet__:
			case Unset__:
			case ToString__:
			case Invoke:
			case SetState:
			case Clone__:
			case DebugInfo:
			case Namespace__:
			case Class__:
			case Traic__:
			case Function__:
			case Method__:
			case Line__:
			case File__:
			case Dir__:
			case NamespaceSeparator:
			case Dollar:
			case OpenRoundBracket:
			case VarName:
			case Label:
			case SingleQuoteString:
			case DoubleQuote:
			case StartNowDoc:
			case StartHereDoc:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1634;
				chain();
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

	public partial class ChainListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ChainContext[] chain() {
			return GetRuleContexts<ChainContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ChainContext chain(int i) {
			return GetRuleContext<ChainContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public ChainListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_chainList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterChainList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitChainList(this);
		}
	}

	[RuleVersion(0)]
	public ChainListContext chainList() {
		ChainListContext _localctx = new ChainListContext(Context, State);
		EnterRule(_localctx, 220, RULE_chainList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1637;
			chain();
			State = 1642;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 1638;
				Match(Comma);
				State = 1639;
				chain();
				}
				}
				State = 1644;
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

	public partial class ChainContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ChainOriginContext chainOrigin() {
			return GetRuleContext<ChainOriginContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MemberAccessContext[] memberAccess() {
			return GetRuleContexts<MemberAccessContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public MemberAccessContext memberAccess(int i) {
			return GetRuleContext<MemberAccessContext>(i);
		}
		public ChainContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_chain; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterChain(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitChain(this);
		}
	}

	[RuleVersion(0)]
	public ChainContext chain() {
		ChainContext _localctx = new ChainContext(Context, State);
		EnterRule(_localctx, 222, RULE_chain);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1645;
			chainOrigin();
			State = 1649;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,207,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1646;
					memberAccess();
					}
					} 
				}
				State = 1651;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,207,Context);
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

	public partial class ChainOriginContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ChainBaseContext chainBase() {
			return GetRuleContext<ChainBaseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FunctionCallContext functionCall() {
			return GetRuleContext<FunctionCallContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenRoundBracket() { return GetToken(PhpParser.OpenRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NewExprContext newExpr() {
			return GetRuleContext<NewExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseRoundBracket() { return GetToken(PhpParser.CloseRoundBracket, 0); }
		public ChainOriginContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_chainOrigin; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterChainOrigin(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitChainOrigin(this);
		}
	}

	[RuleVersion(0)]
	public ChainOriginContext chainOrigin() {
		ChainOriginContext _localctx = new ChainOriginContext(Context, State);
		EnterRule(_localctx, 224, RULE_chainOrigin);
		try {
			State = 1658;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,208,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1652;
				chainBase();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1653;
				functionCall();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1654;
				Match(OpenRoundBracket);
				State = 1655;
				newExpr();
				State = 1656;
				Match(CloseRoundBracket);
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

	public partial class MemberAccessContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ObjectOperator() { return GetToken(PhpParser.ObjectOperator, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public KeyedFieldNameContext keyedFieldName() {
			return GetRuleContext<KeyedFieldNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ActualArgumentsContext actualArguments() {
			return GetRuleContext<ActualArgumentsContext>(0);
		}
		public MemberAccessContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_memberAccess; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterMemberAccess(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitMemberAccess(this);
		}
	}

	[RuleVersion(0)]
	public MemberAccessContext memberAccess() {
		MemberAccessContext _localctx = new MemberAccessContext(Context, State);
		EnterRule(_localctx, 226, RULE_memberAccess);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1660;
			Match(ObjectOperator);
			State = 1661;
			keyedFieldName();
			State = 1663;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,209,Context) ) {
			case 1:
				{
				State = 1662;
				actualArguments();
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

	public partial class FunctionCallContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public FunctionCallNameContext functionCallName() {
			return GetRuleContext<FunctionCallNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ActualArgumentsContext actualArguments() {
			return GetRuleContext<ActualArgumentsContext>(0);
		}
		public FunctionCallContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_functionCall; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterFunctionCall(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitFunctionCall(this);
		}
	}

	[RuleVersion(0)]
	public FunctionCallContext functionCall() {
		FunctionCallContext _localctx = new FunctionCallContext(Context, State);
		EnterRule(_localctx, 228, RULE_functionCall);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1665;
			functionCallName();
			State = 1666;
			actualArguments();
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

	public partial class FunctionCallNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedNamespaceNameContext qualifiedNamespaceName() {
			return GetRuleContext<QualifiedNamespaceNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassConstantContext classConstant() {
			return GetRuleContext<ClassConstantContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ChainBaseContext chainBase() {
			return GetRuleContext<ChainBaseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ParenthesesContext parentheses() {
			return GetRuleContext<ParenthesesContext>(0);
		}
		public FunctionCallNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_functionCallName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterFunctionCallName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitFunctionCallName(this);
		}
	}

	[RuleVersion(0)]
	public FunctionCallNameContext functionCallName() {
		FunctionCallNameContext _localctx = new FunctionCallNameContext(Context, State);
		EnterRule(_localctx, 230, RULE_functionCallName);
		try {
			State = 1672;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,210,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1668;
				qualifiedNamespaceName();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1669;
				classConstant();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1670;
				chainBase();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1671;
				parentheses();
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

	public partial class ActualArgumentsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentsContext arguments() {
			return GetRuleContext<ArgumentsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public GenericDynamicArgsContext genericDynamicArgs() {
			return GetRuleContext<GenericDynamicArgsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SquareCurlyExpressionContext[] squareCurlyExpression() {
			return GetRuleContexts<SquareCurlyExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public SquareCurlyExpressionContext squareCurlyExpression(int i) {
			return GetRuleContext<SquareCurlyExpressionContext>(i);
		}
		public ActualArgumentsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_actualArguments; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterActualArguments(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitActualArguments(this);
		}
	}

	[RuleVersion(0)]
	public ActualArgumentsContext actualArguments() {
		ActualArgumentsContext _localctx = new ActualArgumentsContext(Context, State);
		EnterRule(_localctx, 232, RULE_actualArguments);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1675;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Lgeneric) {
				{
				State = 1674;
				genericDynamicArgs();
				}
			}

			State = 1677;
			arguments();
			State = 1681;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,212,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1678;
					squareCurlyExpression();
					}
					} 
				}
				State = 1683;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,212,Context);
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

	public partial class ChainBaseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public KeyedVariableContext[] keyedVariable() {
			return GetRuleContexts<KeyedVariableContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public KeyedVariableContext keyedVariable(int i) {
			return GetRuleContext<KeyedVariableContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DoubleColon() { return GetToken(PhpParser.DoubleColon, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public QualifiedStaticTypeRefContext qualifiedStaticTypeRef() {
			return GetRuleContext<QualifiedStaticTypeRefContext>(0);
		}
		public ChainBaseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_chainBase; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterChainBase(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitChainBase(this);
		}
	}

	[RuleVersion(0)]
	public ChainBaseContext chainBase() {
		ChainBaseContext _localctx = new ChainBaseContext(Context, State);
		EnterRule(_localctx, 234, RULE_chainBase);
		try {
			State = 1693;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Dollar:
			case VarName:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1684;
				keyedVariable();
				State = 1687;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,213,Context) ) {
				case 1:
					{
					State = 1685;
					Match(DoubleColon);
					State = 1686;
					keyedVariable();
					}
					break;
				}
				}
				break;
			case Abstract:
			case Array:
			case As:
			case BinaryCast:
			case BoolType:
			case BooleanConstant:
			case Break:
			case Callable:
			case Case:
			case Catch:
			case Class:
			case Clone:
			case Const:
			case Continue:
			case Declare:
			case Default:
			case Do:
			case DoubleCast:
			case DoubleType:
			case Echo:
			case Else:
			case ElseIf:
			case Empty:
			case EndDeclare:
			case EndFor:
			case EndForeach:
			case EndIf:
			case EndSwitch:
			case EndWhile:
			case Eval:
			case Exit:
			case Extends:
			case Final:
			case Finally:
			case FloatCast:
			case For:
			case Foreach:
			case Function_:
			case Global:
			case Goto:
			case If:
			case Implements:
			case Import:
			case Include:
			case IncludeOnce:
			case InstanceOf:
			case InsteadOf:
			case Int8Cast:
			case Int16Cast:
			case Int64Type:
			case IntType:
			case Interface:
			case IsSet:
			case List:
			case LogicalAnd:
			case LogicalOr:
			case LogicalXor:
			case Namespace:
			case New:
			case Null:
			case ObjectType:
			case Parent_:
			case Partial:
			case Print:
			case Private:
			case Protected:
			case Public:
			case Require:
			case RequireOnce:
			case Resource:
			case Return:
			case Static:
			case StringType:
			case Switch:
			case Throw:
			case Trait:
			case Try:
			case Typeof:
			case UintCast:
			case UnicodeCast:
			case Unset:
			case Use:
			case Var:
			case While:
			case Yield:
			case From:
			case Get:
			case Set:
			case Call:
			case CallStatic:
			case Constructor:
			case Destruct:
			case Wakeup:
			case Sleep:
			case Autoload:
			case IsSet__:
			case Unset__:
			case ToString__:
			case Invoke:
			case SetState:
			case Clone__:
			case DebugInfo:
			case Namespace__:
			case Class__:
			case Traic__:
			case Function__:
			case Method__:
			case Line__:
			case File__:
			case Dir__:
			case NamespaceSeparator:
			case Label:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1689;
				qualifiedStaticTypeRef();
				State = 1690;
				Match(DoubleColon);
				State = 1691;
				keyedVariable();
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

	public partial class KeyedFieldNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public KeyedSimpleFieldNameContext keyedSimpleFieldName() {
			return GetRuleContext<KeyedSimpleFieldNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public KeyedVariableContext keyedVariable() {
			return GetRuleContext<KeyedVariableContext>(0);
		}
		public KeyedFieldNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_keyedFieldName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterKeyedFieldName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitKeyedFieldName(this);
		}
	}

	[RuleVersion(0)]
	public KeyedFieldNameContext keyedFieldName() {
		KeyedFieldNameContext _localctx = new KeyedFieldNameContext(Context, State);
		EnterRule(_localctx, 236, RULE_keyedFieldName);
		try {
			State = 1697;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Abstract:
			case Array:
			case As:
			case BinaryCast:
			case BoolType:
			case BooleanConstant:
			case Break:
			case Callable:
			case Case:
			case Catch:
			case Class:
			case Clone:
			case Const:
			case Continue:
			case Declare:
			case Default:
			case Do:
			case DoubleCast:
			case DoubleType:
			case Echo:
			case Else:
			case ElseIf:
			case Empty:
			case EndDeclare:
			case EndFor:
			case EndForeach:
			case EndIf:
			case EndSwitch:
			case EndWhile:
			case Eval:
			case Exit:
			case Extends:
			case Final:
			case Finally:
			case FloatCast:
			case For:
			case Foreach:
			case Function_:
			case Global:
			case Goto:
			case If:
			case Implements:
			case Import:
			case Include:
			case IncludeOnce:
			case InstanceOf:
			case InsteadOf:
			case Int8Cast:
			case Int16Cast:
			case Int64Type:
			case IntType:
			case Interface:
			case IsSet:
			case List:
			case LogicalAnd:
			case LogicalOr:
			case LogicalXor:
			case Namespace:
			case New:
			case Null:
			case ObjectType:
			case Parent_:
			case Partial:
			case Print:
			case Private:
			case Protected:
			case Public:
			case Require:
			case RequireOnce:
			case Resource:
			case Return:
			case Static:
			case StringType:
			case Switch:
			case Throw:
			case Trait:
			case Try:
			case Typeof:
			case UintCast:
			case UnicodeCast:
			case Unset:
			case Use:
			case Var:
			case While:
			case Yield:
			case From:
			case Get:
			case Set:
			case Call:
			case CallStatic:
			case Constructor:
			case Destruct:
			case Wakeup:
			case Sleep:
			case Autoload:
			case IsSet__:
			case Unset__:
			case ToString__:
			case Invoke:
			case SetState:
			case Clone__:
			case DebugInfo:
			case Namespace__:
			case Class__:
			case Traic__:
			case Function__:
			case Method__:
			case Line__:
			case File__:
			case Dir__:
			case OpenCurlyBracket:
			case Label:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1695;
				keyedSimpleFieldName();
				}
				break;
			case Dollar:
			case VarName:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1696;
				keyedVariable();
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

	public partial class KeyedSimpleFieldNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenCurlyBracket() { return GetToken(PhpParser.OpenCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseCurlyBracket() { return GetToken(PhpParser.CloseCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public SquareCurlyExpressionContext[] squareCurlyExpression() {
			return GetRuleContexts<SquareCurlyExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public SquareCurlyExpressionContext squareCurlyExpression(int i) {
			return GetRuleContext<SquareCurlyExpressionContext>(i);
		}
		public KeyedSimpleFieldNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_keyedSimpleFieldName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterKeyedSimpleFieldName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitKeyedSimpleFieldName(this);
		}
	}

	[RuleVersion(0)]
	public KeyedSimpleFieldNameContext keyedSimpleFieldName() {
		KeyedSimpleFieldNameContext _localctx = new KeyedSimpleFieldNameContext(Context, State);
		EnterRule(_localctx, 238, RULE_keyedSimpleFieldName);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1704;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Abstract:
			case Array:
			case As:
			case BinaryCast:
			case BoolType:
			case BooleanConstant:
			case Break:
			case Callable:
			case Case:
			case Catch:
			case Class:
			case Clone:
			case Const:
			case Continue:
			case Declare:
			case Default:
			case Do:
			case DoubleCast:
			case DoubleType:
			case Echo:
			case Else:
			case ElseIf:
			case Empty:
			case EndDeclare:
			case EndFor:
			case EndForeach:
			case EndIf:
			case EndSwitch:
			case EndWhile:
			case Eval:
			case Exit:
			case Extends:
			case Final:
			case Finally:
			case FloatCast:
			case For:
			case Foreach:
			case Function_:
			case Global:
			case Goto:
			case If:
			case Implements:
			case Import:
			case Include:
			case IncludeOnce:
			case InstanceOf:
			case InsteadOf:
			case Int8Cast:
			case Int16Cast:
			case Int64Type:
			case IntType:
			case Interface:
			case IsSet:
			case List:
			case LogicalAnd:
			case LogicalOr:
			case LogicalXor:
			case Namespace:
			case New:
			case Null:
			case ObjectType:
			case Parent_:
			case Partial:
			case Print:
			case Private:
			case Protected:
			case Public:
			case Require:
			case RequireOnce:
			case Resource:
			case Return:
			case Static:
			case StringType:
			case Switch:
			case Throw:
			case Trait:
			case Try:
			case Typeof:
			case UintCast:
			case UnicodeCast:
			case Unset:
			case Use:
			case Var:
			case While:
			case Yield:
			case From:
			case Get:
			case Set:
			case Call:
			case CallStatic:
			case Constructor:
			case Destruct:
			case Wakeup:
			case Sleep:
			case Autoload:
			case IsSet__:
			case Unset__:
			case ToString__:
			case Invoke:
			case SetState:
			case Clone__:
			case DebugInfo:
			case Namespace__:
			case Class__:
			case Traic__:
			case Function__:
			case Method__:
			case Line__:
			case File__:
			case Dir__:
			case Label:
				{
				State = 1699;
				identifier();
				}
				break;
			case OpenCurlyBracket:
				{
				State = 1700;
				Match(OpenCurlyBracket);
				State = 1701;
				expression(0);
				State = 1702;
				Match(CloseCurlyBracket);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 1709;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,217,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1706;
					squareCurlyExpression();
					}
					} 
				}
				State = 1711;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,217,Context);
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

	public partial class KeyedVariableContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VarName() { return GetToken(PhpParser.VarName, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Dollar() { return GetTokens(PhpParser.Dollar); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Dollar(int i) {
			return GetToken(PhpParser.Dollar, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenCurlyBracket() { return GetToken(PhpParser.OpenCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseCurlyBracket() { return GetToken(PhpParser.CloseCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public SquareCurlyExpressionContext[] squareCurlyExpression() {
			return GetRuleContexts<SquareCurlyExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public SquareCurlyExpressionContext squareCurlyExpression(int i) {
			return GetRuleContext<SquareCurlyExpressionContext>(i);
		}
		public KeyedVariableContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_keyedVariable; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterKeyedVariable(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitKeyedVariable(this);
		}
	}

	[RuleVersion(0)]
	public KeyedVariableContext keyedVariable() {
		KeyedVariableContext _localctx = new KeyedVariableContext(Context, State);
		EnterRule(_localctx, 240, RULE_keyedVariable);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1715;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,218,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1712;
					Match(Dollar);
					}
					} 
				}
				State = 1717;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,218,Context);
			}
			State = 1724;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case VarName:
				{
				State = 1718;
				Match(VarName);
				}
				break;
			case Dollar:
				{
				State = 1719;
				Match(Dollar);
				State = 1720;
				Match(OpenCurlyBracket);
				State = 1721;
				expression(0);
				State = 1722;
				Match(CloseCurlyBracket);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 1729;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,220,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1726;
					squareCurlyExpression();
					}
					} 
				}
				State = 1731;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,220,Context);
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

	public partial class SquareCurlyExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenSquareBracket() { return GetToken(PhpParser.OpenSquareBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseSquareBracket() { return GetToken(PhpParser.CloseSquareBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenCurlyBracket() { return GetToken(PhpParser.OpenCurlyBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseCurlyBracket() { return GetToken(PhpParser.CloseCurlyBracket, 0); }
		public SquareCurlyExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_squareCurlyExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterSquareCurlyExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitSquareCurlyExpression(this);
		}
	}

	[RuleVersion(0)]
	public SquareCurlyExpressionContext squareCurlyExpression() {
		SquareCurlyExpressionContext _localctx = new SquareCurlyExpressionContext(Context, State);
		EnterRule(_localctx, 242, RULE_squareCurlyExpression);
		int _la;
		try {
			State = 1741;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case OpenSquareBracket:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1732;
				Match(OpenSquareBracket);
				State = 1734;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Match_ - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (LambdaFn - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)) | (1L << (Inc - 108)) | (1L << (Dec - 108)))) != 0) || ((((_la - 189)) & ~0x3f) == 0 && ((1L << (_la - 189)) & ((1L << (NamespaceSeparator - 189)) | (1L << (Bang - 189)) | (1L << (Plus - 189)) | (1L << (Minus - 189)) | (1L << (Tilde - 189)) | (1L << (SuppressWarnings - 189)) | (1L << (Dollar - 189)) | (1L << (OpenRoundBracket - 189)) | (1L << (OpenSquareBracket - 189)) | (1L << (VarName - 189)) | (1L << (Label - 189)) | (1L << (Octal - 189)) | (1L << (Decimal - 189)) | (1L << (Real - 189)) | (1L << (Hex - 189)) | (1L << (Binary - 189)) | (1L << (BackQuoteString - 189)) | (1L << (SingleQuoteString - 189)) | (1L << (DoubleQuote - 189)) | (1L << (StartNowDoc - 189)) | (1L << (StartHereDoc - 189)))) != 0)) {
					{
					State = 1733;
					expression(0);
					}
				}

				State = 1736;
				Match(CloseSquareBracket);
				}
				break;
			case OpenCurlyBracket:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1737;
				Match(OpenCurlyBracket);
				State = 1738;
				expression(0);
				State = 1739;
				Match(CloseCurlyBracket);
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

	public partial class AssignmentListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentListElementContext[] assignmentListElement() {
			return GetRuleContexts<AssignmentListElementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentListElementContext assignmentListElement(int i) {
			return GetRuleContext<AssignmentListElementContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Comma() { return GetTokens(PhpParser.Comma); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Comma(int i) {
			return GetToken(PhpParser.Comma, i);
		}
		public AssignmentListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignmentList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterAssignmentList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitAssignmentList(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentListContext assignmentList() {
		AssignmentListContext _localctx = new AssignmentListContext(Context, State);
		EnterRule(_localctx, 244, RULE_assignmentList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1744;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Match_ - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (LambdaFn - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)) | (1L << (Inc - 108)) | (1L << (Dec - 108)))) != 0) || ((((_la - 189)) & ~0x3f) == 0 && ((1L << (_la - 189)) & ((1L << (NamespaceSeparator - 189)) | (1L << (Ampersand - 189)) | (1L << (Bang - 189)) | (1L << (Plus - 189)) | (1L << (Minus - 189)) | (1L << (Tilde - 189)) | (1L << (SuppressWarnings - 189)) | (1L << (Dollar - 189)) | (1L << (OpenRoundBracket - 189)) | (1L << (OpenSquareBracket - 189)) | (1L << (VarName - 189)) | (1L << (Label - 189)) | (1L << (Octal - 189)) | (1L << (Decimal - 189)) | (1L << (Real - 189)) | (1L << (Hex - 189)) | (1L << (Binary - 189)) | (1L << (BackQuoteString - 189)) | (1L << (SingleQuoteString - 189)) | (1L << (DoubleQuote - 189)) | (1L << (StartNowDoc - 189)) | (1L << (StartHereDoc - 189)))) != 0)) {
				{
				State = 1743;
				assignmentListElement();
				}
			}

			State = 1752;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==Comma) {
				{
				{
				State = 1746;
				Match(Comma);
				State = 1748;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Match_ - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (LambdaFn - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)) | (1L << (Inc - 108)) | (1L << (Dec - 108)))) != 0) || ((((_la - 189)) & ~0x3f) == 0 && ((1L << (_la - 189)) & ((1L << (NamespaceSeparator - 189)) | (1L << (Ampersand - 189)) | (1L << (Bang - 189)) | (1L << (Plus - 189)) | (1L << (Minus - 189)) | (1L << (Tilde - 189)) | (1L << (SuppressWarnings - 189)) | (1L << (Dollar - 189)) | (1L << (OpenRoundBracket - 189)) | (1L << (OpenSquareBracket - 189)) | (1L << (VarName - 189)) | (1L << (Label - 189)) | (1L << (Octal - 189)) | (1L << (Decimal - 189)) | (1L << (Real - 189)) | (1L << (Hex - 189)) | (1L << (Binary - 189)) | (1L << (BackQuoteString - 189)) | (1L << (SingleQuoteString - 189)) | (1L << (DoubleQuote - 189)) | (1L << (StartNowDoc - 189)) | (1L << (StartHereDoc - 189)))) != 0)) {
					{
					State = 1747;
					assignmentListElement();
					}
				}

				}
				}
				State = 1754;
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

	public partial class AssignmentListElementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ChainContext chain() {
			return GetRuleContext<ChainContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode List() { return GetToken(PhpParser.List, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OpenRoundBracket() { return GetToken(PhpParser.OpenRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentListContext assignmentList() {
			return GetRuleContext<AssignmentListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CloseRoundBracket() { return GetToken(PhpParser.CloseRoundBracket, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ArrayItemContext arrayItem() {
			return GetRuleContext<ArrayItemContext>(0);
		}
		public AssignmentListElementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignmentListElement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterAssignmentListElement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitAssignmentListElement(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentListElementContext assignmentListElement() {
		AssignmentListElementContext _localctx = new AssignmentListElementContext(Context, State);
		EnterRule(_localctx, 246, RULE_assignmentListElement);
		try {
			State = 1762;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,226,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1755;
				chain();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1756;
				Match(List);
				State = 1757;
				Match(OpenRoundBracket);
				State = 1758;
				assignmentList();
				State = 1759;
				Match(CloseRoundBracket);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1761;
				arrayItem();
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

	public partial class ModifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Abstract() { return GetToken(PhpParser.Abstract, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Final() { return GetToken(PhpParser.Final, 0); }
		public ModifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_modifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterModifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitModifier(this);
		}
	}

	[RuleVersion(0)]
	public ModifierContext modifier() {
		ModifierContext _localctx = new ModifierContext(Context, State);
		EnterRule(_localctx, 248, RULE_modifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1764;
			_la = TokenStream.LA(1);
			if ( !(_la==Abstract || _la==Final) ) {
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

	public partial class IdentifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Label() { return GetToken(PhpParser.Label, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Abstract() { return GetToken(PhpParser.Abstract, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Array() { return GetToken(PhpParser.Array, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode As() { return GetToken(PhpParser.As, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BinaryCast() { return GetToken(PhpParser.BinaryCast, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BoolType() { return GetToken(PhpParser.BoolType, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BooleanConstant() { return GetToken(PhpParser.BooleanConstant, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Break() { return GetToken(PhpParser.Break, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Callable() { return GetToken(PhpParser.Callable, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Case() { return GetToken(PhpParser.Case, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Catch() { return GetToken(PhpParser.Catch, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Class() { return GetToken(PhpParser.Class, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Clone() { return GetToken(PhpParser.Clone, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Const() { return GetToken(PhpParser.Const, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Continue() { return GetToken(PhpParser.Continue, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Declare() { return GetToken(PhpParser.Declare, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Default() { return GetToken(PhpParser.Default, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Do() { return GetToken(PhpParser.Do, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DoubleCast() { return GetToken(PhpParser.DoubleCast, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DoubleType() { return GetToken(PhpParser.DoubleType, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Echo() { return GetToken(PhpParser.Echo, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Else() { return GetToken(PhpParser.Else, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ElseIf() { return GetToken(PhpParser.ElseIf, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Empty() { return GetToken(PhpParser.Empty, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EndDeclare() { return GetToken(PhpParser.EndDeclare, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EndFor() { return GetToken(PhpParser.EndFor, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EndForeach() { return GetToken(PhpParser.EndForeach, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EndIf() { return GetToken(PhpParser.EndIf, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EndSwitch() { return GetToken(PhpParser.EndSwitch, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EndWhile() { return GetToken(PhpParser.EndWhile, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eval() { return GetToken(PhpParser.Eval, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Exit() { return GetToken(PhpParser.Exit, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Extends() { return GetToken(PhpParser.Extends, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Final() { return GetToken(PhpParser.Final, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Finally() { return GetToken(PhpParser.Finally, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FloatCast() { return GetToken(PhpParser.FloatCast, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode For() { return GetToken(PhpParser.For, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Foreach() { return GetToken(PhpParser.Foreach, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Function_() { return GetToken(PhpParser.Function_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Global() { return GetToken(PhpParser.Global, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Goto() { return GetToken(PhpParser.Goto, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode If() { return GetToken(PhpParser.If, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Implements() { return GetToken(PhpParser.Implements, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Import() { return GetToken(PhpParser.Import, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Include() { return GetToken(PhpParser.Include, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IncludeOnce() { return GetToken(PhpParser.IncludeOnce, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode InstanceOf() { return GetToken(PhpParser.InstanceOf, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode InsteadOf() { return GetToken(PhpParser.InsteadOf, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Int16Cast() { return GetToken(PhpParser.Int16Cast, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Int64Type() { return GetToken(PhpParser.Int64Type, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Int8Cast() { return GetToken(PhpParser.Int8Cast, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Interface() { return GetToken(PhpParser.Interface, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IntType() { return GetToken(PhpParser.IntType, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IsSet() { return GetToken(PhpParser.IsSet, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode List() { return GetToken(PhpParser.List, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LogicalAnd() { return GetToken(PhpParser.LogicalAnd, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LogicalOr() { return GetToken(PhpParser.LogicalOr, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LogicalXor() { return GetToken(PhpParser.LogicalXor, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Namespace() { return GetToken(PhpParser.Namespace, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode New() { return GetToken(PhpParser.New, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Null() { return GetToken(PhpParser.Null, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ObjectType() { return GetToken(PhpParser.ObjectType, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Parent_() { return GetToken(PhpParser.Parent_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Partial() { return GetToken(PhpParser.Partial, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Print() { return GetToken(PhpParser.Print, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Private() { return GetToken(PhpParser.Private, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Protected() { return GetToken(PhpParser.Protected, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Public() { return GetToken(PhpParser.Public, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Require() { return GetToken(PhpParser.Require, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RequireOnce() { return GetToken(PhpParser.RequireOnce, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Resource() { return GetToken(PhpParser.Resource, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Return() { return GetToken(PhpParser.Return, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Static() { return GetToken(PhpParser.Static, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode StringType() { return GetToken(PhpParser.StringType, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Switch() { return GetToken(PhpParser.Switch, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Throw() { return GetToken(PhpParser.Throw, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Trait() { return GetToken(PhpParser.Trait, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Try() { return GetToken(PhpParser.Try, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Typeof() { return GetToken(PhpParser.Typeof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UintCast() { return GetToken(PhpParser.UintCast, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UnicodeCast() { return GetToken(PhpParser.UnicodeCast, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Unset() { return GetToken(PhpParser.Unset, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Use() { return GetToken(PhpParser.Use, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Var() { return GetToken(PhpParser.Var, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode While() { return GetToken(PhpParser.While, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Yield() { return GetToken(PhpParser.Yield, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode From() { return GetToken(PhpParser.From, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Get() { return GetToken(PhpParser.Get, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Set() { return GetToken(PhpParser.Set, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Call() { return GetToken(PhpParser.Call, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CallStatic() { return GetToken(PhpParser.CallStatic, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Constructor() { return GetToken(PhpParser.Constructor, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Destruct() { return GetToken(PhpParser.Destruct, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Wakeup() { return GetToken(PhpParser.Wakeup, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Sleep() { return GetToken(PhpParser.Sleep, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Autoload() { return GetToken(PhpParser.Autoload, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IsSet__() { return GetToken(PhpParser.IsSet__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Unset__() { return GetToken(PhpParser.Unset__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ToString__() { return GetToken(PhpParser.ToString__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Invoke() { return GetToken(PhpParser.Invoke, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SetState() { return GetToken(PhpParser.SetState, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Clone__() { return GetToken(PhpParser.Clone__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DebugInfo() { return GetToken(PhpParser.DebugInfo, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Namespace__() { return GetToken(PhpParser.Namespace__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Class__() { return GetToken(PhpParser.Class__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Traic__() { return GetToken(PhpParser.Traic__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Function__() { return GetToken(PhpParser.Function__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Method__() { return GetToken(PhpParser.Method__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Line__() { return GetToken(PhpParser.Line__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode File__() { return GetToken(PhpParser.File__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Dir__() { return GetToken(PhpParser.Dir__, 0); }
		public IdentifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_identifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterIdentifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitIdentifier(this);
		}
	}

	[RuleVersion(0)]
	public IdentifierContext identifier() {
		IdentifierContext _localctx = new IdentifierContext(Context, State);
		EnterRule(_localctx, 250, RULE_identifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1766;
			_la = TokenStream.LA(1);
			if ( !(((((_la - 44)) & ~0x3f) == 0 && ((1L << (_la - 44)) & ((1L << (Abstract - 44)) | (1L << (Array - 44)) | (1L << (As - 44)) | (1L << (BinaryCast - 44)) | (1L << (BoolType - 44)) | (1L << (BooleanConstant - 44)) | (1L << (Break - 44)) | (1L << (Callable - 44)) | (1L << (Case - 44)) | (1L << (Catch - 44)) | (1L << (Class - 44)) | (1L << (Clone - 44)) | (1L << (Const - 44)) | (1L << (Continue - 44)) | (1L << (Declare - 44)) | (1L << (Default - 44)) | (1L << (Do - 44)) | (1L << (DoubleCast - 44)) | (1L << (DoubleType - 44)) | (1L << (Echo - 44)) | (1L << (Else - 44)) | (1L << (ElseIf - 44)) | (1L << (Empty - 44)) | (1L << (EndDeclare - 44)) | (1L << (EndFor - 44)) | (1L << (EndForeach - 44)) | (1L << (EndIf - 44)) | (1L << (EndSwitch - 44)) | (1L << (EndWhile - 44)) | (1L << (Eval - 44)) | (1L << (Exit - 44)) | (1L << (Extends - 44)) | (1L << (Final - 44)) | (1L << (Finally - 44)) | (1L << (FloatCast - 44)) | (1L << (For - 44)) | (1L << (Foreach - 44)) | (1L << (Function_ - 44)) | (1L << (Global - 44)) | (1L << (Goto - 44)) | (1L << (If - 44)) | (1L << (Implements - 44)) | (1L << (Import - 44)) | (1L << (Include - 44)) | (1L << (IncludeOnce - 44)) | (1L << (InstanceOf - 44)) | (1L << (InsteadOf - 44)) | (1L << (Int8Cast - 44)) | (1L << (Int16Cast - 44)) | (1L << (Int64Type - 44)) | (1L << (IntType - 44)) | (1L << (Interface - 44)) | (1L << (IsSet - 44)) | (1L << (List - 44)) | (1L << (LogicalAnd - 44)) | (1L << (LogicalOr - 44)) | (1L << (LogicalXor - 44)) | (1L << (Namespace - 44)) | (1L << (New - 44)) | (1L << (Null - 44)) | (1L << (ObjectType - 44)) | (1L << (Parent_ - 44)) | (1L << (Partial - 44)))) != 0) || ((((_la - 108)) & ~0x3f) == 0 && ((1L << (_la - 108)) & ((1L << (Print - 108)) | (1L << (Private - 108)) | (1L << (Protected - 108)) | (1L << (Public - 108)) | (1L << (Require - 108)) | (1L << (RequireOnce - 108)) | (1L << (Resource - 108)) | (1L << (Return - 108)) | (1L << (Static - 108)) | (1L << (StringType - 108)) | (1L << (Switch - 108)) | (1L << (Throw - 108)) | (1L << (Trait - 108)) | (1L << (Try - 108)) | (1L << (Typeof - 108)) | (1L << (UintCast - 108)) | (1L << (UnicodeCast - 108)) | (1L << (Unset - 108)) | (1L << (Use - 108)) | (1L << (Var - 108)) | (1L << (While - 108)) | (1L << (Yield - 108)) | (1L << (From - 108)) | (1L << (Get - 108)) | (1L << (Set - 108)) | (1L << (Call - 108)) | (1L << (CallStatic - 108)) | (1L << (Constructor - 108)) | (1L << (Destruct - 108)) | (1L << (Wakeup - 108)) | (1L << (Sleep - 108)) | (1L << (Autoload - 108)) | (1L << (IsSet__ - 108)) | (1L << (Unset__ - 108)) | (1L << (ToString__ - 108)) | (1L << (Invoke - 108)) | (1L << (SetState - 108)) | (1L << (Clone__ - 108)) | (1L << (DebugInfo - 108)) | (1L << (Namespace__ - 108)) | (1L << (Class__ - 108)) | (1L << (Traic__ - 108)) | (1L << (Function__ - 108)) | (1L << (Method__ - 108)) | (1L << (Line__ - 108)) | (1L << (File__ - 108)) | (1L << (Dir__ - 108)))) != 0) || _la==Label) ) {
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

	public partial class MemberModifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Public() { return GetToken(PhpParser.Public, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Protected() { return GetToken(PhpParser.Protected, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Private() { return GetToken(PhpParser.Private, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Static() { return GetToken(PhpParser.Static, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Abstract() { return GetToken(PhpParser.Abstract, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Final() { return GetToken(PhpParser.Final, 0); }
		public MemberModifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_memberModifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterMemberModifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitMemberModifier(this);
		}
	}

	[RuleVersion(0)]
	public MemberModifierContext memberModifier() {
		MemberModifierContext _localctx = new MemberModifierContext(Context, State);
		EnterRule(_localctx, 252, RULE_memberModifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1768;
			_la = TokenStream.LA(1);
			if ( !(_la==Abstract || ((((_la - 76)) & ~0x3f) == 0 && ((1L << (_la - 76)) & ((1L << (Final - 76)) | (1L << (Private - 76)) | (1L << (Protected - 76)) | (1L << (Public - 76)) | (1L << (Static - 76)))) != 0)) ) {
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

	public partial class MagicConstantContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Namespace__() { return GetToken(PhpParser.Namespace__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Class__() { return GetToken(PhpParser.Class__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Traic__() { return GetToken(PhpParser.Traic__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Function__() { return GetToken(PhpParser.Function__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Method__() { return GetToken(PhpParser.Method__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Line__() { return GetToken(PhpParser.Line__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode File__() { return GetToken(PhpParser.File__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Dir__() { return GetToken(PhpParser.Dir__, 0); }
		public MagicConstantContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_magicConstant; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterMagicConstant(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitMagicConstant(this);
		}
	}

	[RuleVersion(0)]
	public MagicConstantContext magicConstant() {
		MagicConstantContext _localctx = new MagicConstantContext(Context, State);
		EnterRule(_localctx, 254, RULE_magicConstant);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1770;
			_la = TokenStream.LA(1);
			if ( !(((((_la - 148)) & ~0x3f) == 0 && ((1L << (_la - 148)) & ((1L << (Namespace__ - 148)) | (1L << (Class__ - 148)) | (1L << (Traic__ - 148)) | (1L << (Function__ - 148)) | (1L << (Method__ - 148)) | (1L << (Line__ - 148)) | (1L << (File__ - 148)) | (1L << (Dir__ - 148)))) != 0)) ) {
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

	public partial class MagicMethodContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Get() { return GetToken(PhpParser.Get, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Set() { return GetToken(PhpParser.Set, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Call() { return GetToken(PhpParser.Call, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CallStatic() { return GetToken(PhpParser.CallStatic, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Constructor() { return GetToken(PhpParser.Constructor, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Destruct() { return GetToken(PhpParser.Destruct, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Wakeup() { return GetToken(PhpParser.Wakeup, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Sleep() { return GetToken(PhpParser.Sleep, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Autoload() { return GetToken(PhpParser.Autoload, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IsSet__() { return GetToken(PhpParser.IsSet__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Unset__() { return GetToken(PhpParser.Unset__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ToString__() { return GetToken(PhpParser.ToString__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Invoke() { return GetToken(PhpParser.Invoke, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SetState() { return GetToken(PhpParser.SetState, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Clone__() { return GetToken(PhpParser.Clone__, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DebugInfo() { return GetToken(PhpParser.DebugInfo, 0); }
		public MagicMethodContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_magicMethod; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterMagicMethod(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitMagicMethod(this);
		}
	}

	[RuleVersion(0)]
	public MagicMethodContext magicMethod() {
		MagicMethodContext _localctx = new MagicMethodContext(Context, State);
		EnterRule(_localctx, 256, RULE_magicMethod);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1772;
			_la = TokenStream.LA(1);
			if ( !(((((_la - 132)) & ~0x3f) == 0 && ((1L << (_la - 132)) & ((1L << (Get - 132)) | (1L << (Set - 132)) | (1L << (Call - 132)) | (1L << (CallStatic - 132)) | (1L << (Constructor - 132)) | (1L << (Destruct - 132)) | (1L << (Wakeup - 132)) | (1L << (Sleep - 132)) | (1L << (Autoload - 132)) | (1L << (IsSet__ - 132)) | (1L << (Unset__ - 132)) | (1L << (ToString__ - 132)) | (1L << (Invoke - 132)) | (1L << (SetState - 132)) | (1L << (Clone__ - 132)) | (1L << (DebugInfo - 132)))) != 0)) ) {
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

	public partial class PrimitiveTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BoolType() { return GetToken(PhpParser.BoolType, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IntType() { return GetToken(PhpParser.IntType, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Int64Type() { return GetToken(PhpParser.Int64Type, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DoubleType() { return GetToken(PhpParser.DoubleType, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode StringType() { return GetToken(PhpParser.StringType, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Resource() { return GetToken(PhpParser.Resource, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ObjectType() { return GetToken(PhpParser.ObjectType, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Array() { return GetToken(PhpParser.Array, 0); }
		public PrimitiveTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primitiveType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterPrimitiveType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitPrimitiveType(this);
		}
	}

	[RuleVersion(0)]
	public PrimitiveTypeContext primitiveType() {
		PrimitiveTypeContext _localctx = new PrimitiveTypeContext(Context, State);
		EnterRule(_localctx, 258, RULE_primitiveType);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1774;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Array) | (1L << BoolType) | (1L << DoubleType))) != 0) || ((((_la - 93)) & ~0x3f) == 0 && ((1L << (_la - 93)) & ((1L << (Int64Type - 93)) | (1L << (IntType - 93)) | (1L << (ObjectType - 93)) | (1L << (Resource - 93)) | (1L << (StringType - 93)))) != 0)) ) {
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

	public partial class CastOperationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BoolType() { return GetToken(PhpParser.BoolType, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Int8Cast() { return GetToken(PhpParser.Int8Cast, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Int16Cast() { return GetToken(PhpParser.Int16Cast, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IntType() { return GetToken(PhpParser.IntType, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Int64Type() { return GetToken(PhpParser.Int64Type, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UintCast() { return GetToken(PhpParser.UintCast, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DoubleCast() { return GetToken(PhpParser.DoubleCast, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DoubleType() { return GetToken(PhpParser.DoubleType, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FloatCast() { return GetToken(PhpParser.FloatCast, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode StringType() { return GetToken(PhpParser.StringType, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BinaryCast() { return GetToken(PhpParser.BinaryCast, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UnicodeCast() { return GetToken(PhpParser.UnicodeCast, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Array() { return GetToken(PhpParser.Array, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ObjectType() { return GetToken(PhpParser.ObjectType, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Resource() { return GetToken(PhpParser.Resource, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Unset() { return GetToken(PhpParser.Unset, 0); }
		public CastOperationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_castOperation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.EnterCastOperation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPhpParserListener typedListener = listener as IPhpParserListener;
			if (typedListener != null) typedListener.ExitCastOperation(this);
		}
	}

	[RuleVersion(0)]
	public CastOperationContext castOperation() {
		CastOperationContext _localctx = new CastOperationContext(Context, State);
		EnterRule(_localctx, 260, RULE_castOperation);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1776;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Array) | (1L << BinaryCast) | (1L << BoolType) | (1L << DoubleCast) | (1L << DoubleType))) != 0) || ((((_la - 78)) & ~0x3f) == 0 && ((1L << (_la - 78)) & ((1L << (FloatCast - 78)) | (1L << (Int8Cast - 78)) | (1L << (Int16Cast - 78)) | (1L << (Int64Type - 78)) | (1L << (IntType - 78)) | (1L << (ObjectType - 78)) | (1L << (Resource - 78)) | (1L << (StringType - 78)) | (1L << (UintCast - 78)) | (1L << (UnicodeCast - 78)) | (1L << (Unset - 78)))) != 0)) ) {
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
		case 58: return typeHint_sempred((TypeHintContext)_localctx, predIndex);
		case 78: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool typeHint_sempred(TypeHintContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 1);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 1: return Precpred(Context, 21);
		case 2: return Precpred(Context, 19);
		case 3: return Precpred(Context, 18);
		case 4: return Precpred(Context, 17);
		case 5: return Precpred(Context, 16);
		case 6: return Precpred(Context, 15);
		case 7: return Precpred(Context, 14);
		case 8: return Precpred(Context, 13);
		case 9: return Precpred(Context, 12);
		case 10: return Precpred(Context, 11);
		case 11: return Precpred(Context, 10);
		case 12: return Precpred(Context, 9);
		case 13: return Precpred(Context, 8);
		case 14: return Precpred(Context, 7);
		case 15: return Precpred(Context, 3);
		case 16: return Precpred(Context, 2);
		case 17: return Precpred(Context, 1);
		case 18: return Precpred(Context, 20);
		}
		return true;
	}

	private static int[] _serializedATN = {
		4,1,239,1779,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,
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
		2,129,7,129,2,130,7,130,1,0,3,0,264,8,0,1,0,1,0,5,0,268,8,0,10,0,12,0,
		271,9,0,1,0,1,0,1,1,4,1,276,8,1,11,1,12,1,277,1,1,3,1,281,8,1,1,2,1,2,
		1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,
		2,1,2,1,2,5,2,305,8,2,10,2,12,2,308,9,2,1,2,3,2,311,8,2,1,3,4,3,314,8,
		3,11,3,12,3,315,1,4,5,4,319,8,4,10,4,12,4,322,9,4,1,4,4,4,325,8,4,11,4,
		12,4,326,1,5,1,5,1,5,1,5,1,5,1,6,1,6,1,6,1,6,1,6,1,6,3,6,340,8,6,1,7,1,
		7,3,7,344,8,7,1,7,1,7,1,7,1,8,3,8,350,8,8,1,8,1,8,1,8,3,8,355,8,8,1,8,
		5,8,358,8,8,10,8,12,8,361,9,8,1,9,1,9,1,10,1,10,3,10,367,8,10,1,10,1,10,
		5,10,371,8,10,10,10,12,10,374,9,10,1,10,1,10,1,10,1,10,3,10,380,8,10,1,
		11,1,11,1,11,1,11,1,11,3,11,387,8,11,1,12,3,12,390,8,12,1,12,1,12,3,12,
		394,8,12,1,12,1,12,3,12,398,8,12,1,12,1,12,1,12,1,12,1,12,3,12,405,8,12,
		1,12,3,12,408,8,12,1,12,1,12,1,13,3,13,413,8,13,1,13,3,13,416,8,13,1,13,
		3,13,419,8,13,1,13,3,13,422,8,13,1,13,1,13,1,13,3,13,427,8,13,1,13,1,13,
		3,13,431,8,13,1,13,1,13,3,13,435,8,13,1,13,1,13,1,13,3,13,440,8,13,1,13,
		1,13,3,13,444,8,13,3,13,446,8,13,1,13,1,13,5,13,450,8,13,10,13,12,13,453,
		9,13,1,13,1,13,1,14,1,14,1,15,1,15,1,15,5,15,462,8,15,10,15,12,15,465,
		9,15,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,
		1,16,3,16,481,8,16,1,17,1,17,1,17,5,17,486,8,17,10,17,12,17,489,9,17,1,
		18,1,18,1,18,5,18,494,8,18,10,18,12,18,497,9,18,1,19,3,19,500,8,19,1,19,
		1,19,1,20,3,20,505,8,20,1,20,1,20,1,20,1,20,3,20,511,8,20,1,21,1,21,1,
		21,1,21,5,21,517,8,21,10,21,12,21,520,9,21,1,21,1,21,1,22,4,22,525,8,22,
		11,22,12,22,526,1,23,1,23,1,23,1,23,3,23,533,8,23,1,23,1,23,1,23,5,23,
		538,8,23,10,23,12,23,541,9,23,1,23,1,23,1,24,1,24,3,24,547,8,24,1,25,5,
		25,550,8,25,10,25,12,25,553,9,25,1,26,1,26,1,26,3,26,558,8,26,1,27,1,27,
		1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,27,
		1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,27,1,27,3,27,587,8,27,1,
		28,1,28,1,29,1,29,1,29,1,29,1,30,1,30,1,30,1,30,5,30,599,8,30,10,30,12,
		30,602,9,30,1,30,3,30,605,8,30,1,30,1,30,1,30,1,30,1,30,5,30,612,8,30,
		10,30,12,30,615,9,30,1,30,3,30,618,8,30,1,30,1,30,1,30,3,30,623,8,30,1,
		31,1,31,1,31,1,31,1,32,1,32,1,32,1,32,1,32,1,33,1,33,1,33,1,34,1,34,1,
		34,1,34,1,35,1,35,1,35,1,35,1,35,1,35,1,35,1,35,3,35,649,8,35,1,36,1,36,
		1,36,1,36,1,36,1,36,1,37,1,37,1,37,3,37,660,8,37,1,37,1,37,3,37,664,8,
		37,1,37,1,37,3,37,668,8,37,1,37,1,37,1,37,1,37,1,37,1,37,1,37,3,37,677,
		8,37,1,38,1,38,1,39,1,39,1,40,1,40,1,40,1,40,3,40,687,8,40,1,40,5,40,690,
		8,40,10,40,12,40,693,9,40,1,40,1,40,1,40,3,40,698,8,40,1,40,5,40,701,8,
		40,10,40,12,40,704,9,40,1,40,1,40,3,40,708,8,40,1,41,1,41,1,41,3,41,713,
		8,41,1,41,4,41,716,8,41,11,41,12,41,717,1,41,1,41,1,42,1,42,3,42,724,8,
		42,1,42,1,42,1,43,1,43,3,43,730,8,43,1,43,1,43,1,44,1,44,3,44,736,8,44,
		1,44,1,44,1,45,1,45,1,45,1,46,1,46,1,46,1,46,1,46,1,46,1,47,1,47,1,47,
		1,47,1,47,3,47,754,8,47,1,47,1,47,1,47,3,47,759,8,47,1,47,3,47,762,8,47,
		1,47,1,47,1,47,1,47,1,47,1,47,1,47,1,47,3,47,772,8,47,1,47,3,47,775,8,
		47,1,47,1,47,1,47,1,47,1,47,1,47,1,47,1,47,1,47,1,47,1,47,3,47,788,8,47,
		1,47,1,47,1,47,1,47,1,47,1,47,3,47,796,8,47,1,48,1,48,1,48,4,48,801,8,
		48,11,48,12,48,802,1,48,3,48,806,8,48,1,48,5,48,809,8,48,10,48,12,48,812,
		9,48,1,48,3,48,815,8,48,1,49,1,49,1,49,1,49,1,49,5,49,822,8,49,10,49,12,
		49,825,9,49,1,49,1,49,1,49,1,49,1,50,1,50,1,50,1,51,1,51,1,51,1,51,1,52,
		1,52,1,52,1,52,1,53,1,53,1,53,1,53,1,53,1,53,1,53,1,53,1,53,1,53,3,53,
		852,8,53,1,54,4,54,855,8,54,11,54,12,54,856,1,55,1,55,1,55,5,55,862,8,
		55,10,55,12,55,865,9,55,1,56,3,56,868,8,56,1,56,1,56,5,56,872,8,56,10,
		56,12,56,875,9,56,1,56,3,56,878,8,56,1,57,3,57,881,8,57,1,57,3,57,884,
		8,57,1,57,3,57,887,8,57,1,57,3,57,890,8,57,1,57,3,57,893,8,57,1,57,3,57,
		896,8,57,1,57,1,57,1,58,1,58,1,58,1,58,3,58,904,8,58,1,58,1,58,1,58,5,
		58,909,8,58,10,58,12,58,912,9,58,1,59,1,59,1,59,1,59,5,59,918,8,59,10,
		59,12,59,921,9,59,1,59,1,59,1,60,1,60,1,60,1,60,1,60,1,60,1,60,1,60,3,
		60,933,8,60,1,61,1,61,1,61,1,61,1,62,1,62,1,62,1,62,5,62,943,8,62,10,62,
		12,62,946,9,62,1,62,1,62,1,63,3,63,951,8,63,1,63,1,63,3,63,955,8,63,1,
		63,1,63,1,63,5,63,960,8,63,10,63,12,63,963,9,63,1,63,1,63,1,63,3,63,968,
		8,63,1,63,1,63,3,63,972,8,63,1,63,1,63,1,63,5,63,977,8,63,10,63,12,63,
		980,9,63,1,63,1,63,1,63,1,63,3,63,986,8,63,1,63,1,63,3,63,990,8,63,1,63,
		1,63,1,63,1,63,3,63,996,8,63,1,63,1,63,3,63,1000,8,63,3,63,1002,8,63,1,
		63,1,63,1,63,1,63,3,63,1008,8,63,1,64,1,64,1,64,5,64,1013,8,64,10,64,12,
		64,1016,9,64,1,64,3,64,1019,8,64,1,65,1,65,3,65,1023,8,65,1,66,1,66,1,
		66,1,66,1,66,1,66,1,66,1,67,1,67,1,67,1,67,3,67,1036,8,67,1,67,3,67,1039,
		8,67,1,67,1,67,1,68,1,68,1,68,3,68,1046,8,68,1,68,1,68,1,69,1,69,1,69,
		3,69,1053,8,69,1,70,1,70,3,70,1057,8,70,1,71,1,71,3,71,1061,8,71,1,72,
		4,72,1064,8,72,11,72,12,72,1065,1,73,1,73,1,73,3,73,1071,8,73,1,74,1,74,
		1,74,1,74,1,75,3,75,1078,8,75,1,75,1,75,1,75,1,75,5,75,1084,8,75,10,75,
		12,75,1087,9,75,1,75,1,75,1,76,1,76,1,76,5,76,1094,8,76,10,76,12,76,1097,
		9,76,1,77,1,77,1,77,3,77,1102,8,77,1,77,1,77,1,78,1,78,1,78,1,78,1,78,
		1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,
		1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,
		1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,
		1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,3,78,1165,
		8,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,3,78,1178,
		8,78,1,78,1,78,1,78,1,78,1,78,3,78,1185,8,78,1,78,1,78,1,78,3,78,1190,
		8,78,3,78,1192,8,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,
		1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,
		1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,3,78,1230,
		8,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,1,78,
		1,78,1,78,1,78,1,78,1,78,1,78,1,78,5,78,1252,8,78,10,78,12,78,1255,9,78,
		1,79,1,79,3,79,1259,8,79,1,80,1,80,1,80,3,80,1264,8,80,1,80,1,80,1,80,
		3,80,1269,8,80,1,80,3,80,1272,8,80,1,80,1,80,1,80,1,80,3,80,1278,8,80,
		1,81,3,81,1281,8,81,1,81,1,81,3,81,1285,8,81,1,81,1,81,1,81,1,81,3,81,
		1291,8,81,1,81,1,81,3,81,1295,8,81,1,81,1,81,1,81,1,81,1,81,1,81,1,81,
		1,81,1,81,3,81,1306,8,81,1,82,1,82,1,82,1,82,1,82,1,82,1,82,1,82,5,82,
		1316,8,82,10,82,12,82,1319,9,82,1,82,3,82,1322,8,82,1,82,1,82,1,83,1,83,
		1,83,5,83,1329,8,83,10,83,12,83,1332,9,83,1,83,1,83,1,83,1,84,1,84,1,84,
		3,84,1340,8,84,1,85,1,85,1,86,1,86,1,86,1,86,3,86,1348,8,86,1,86,1,86,
		3,86,1352,8,86,1,87,1,87,1,87,5,87,1357,8,87,10,87,12,87,1360,9,87,1,87,
		3,87,1363,8,87,1,88,1,88,1,88,3,88,1368,8,88,1,88,1,88,1,88,3,88,1373,
		8,88,1,88,1,88,3,88,1377,8,88,1,89,1,89,1,89,1,89,1,89,5,89,1384,8,89,
		10,89,12,89,1387,9,89,1,89,1,89,1,90,3,90,1392,8,90,1,90,1,90,1,91,1,91,
		3,91,1398,8,91,1,91,3,91,1401,8,91,1,92,1,92,3,92,1405,8,92,1,92,3,92,
		1408,8,92,1,92,1,92,1,92,3,92,1413,8,92,1,93,3,93,1416,8,93,1,93,3,93,
		1419,8,93,1,93,3,93,1422,8,93,1,93,3,93,1425,8,93,1,93,1,93,3,93,1429,
		8,93,1,93,1,93,3,93,1433,8,93,1,93,1,93,3,93,1437,8,93,1,93,1,93,1,93,
		3,93,1442,8,93,1,93,1,93,3,93,1446,8,93,3,93,1448,8,93,1,93,1,93,5,93,
		1452,8,93,10,93,12,93,1455,9,93,1,93,1,93,1,94,1,94,1,94,5,94,1462,8,94,
		10,94,12,94,1465,9,94,1,95,3,95,1468,8,95,1,95,3,95,1471,8,95,1,95,1,95,
		1,96,1,96,1,96,1,96,5,96,1479,8,96,10,96,12,96,1482,9,96,1,96,1,96,3,96,
		1486,8,96,3,96,1488,8,96,1,97,1,97,1,97,3,97,1493,8,97,1,97,1,97,1,97,
		1,97,5,97,1499,8,97,10,97,12,97,1502,9,97,1,97,3,97,1505,8,97,1,97,1,97,
		3,97,1509,8,97,1,98,1,98,1,98,5,98,1514,8,98,10,98,12,98,1517,9,98,1,99,
		1,99,1,99,1,99,5,99,1523,8,99,10,99,12,99,1526,9,99,1,99,3,99,1529,8,99,
		1,99,3,99,1532,8,99,1,99,1,99,1,100,3,100,1537,8,100,1,100,3,100,1540,
		8,100,1,100,1,100,1,100,3,100,1545,8,100,1,101,1,101,1,101,1,102,1,102,
		1,102,1,102,1,102,1,102,3,102,1556,8,102,3,102,1558,8,102,1,102,1,102,
		1,102,1,102,3,102,1564,8,102,3,102,1566,8,102,1,102,1,102,1,102,3,102,
		1571,8,102,1,103,1,103,1,103,1,103,1,103,3,103,1578,8,103,1,104,1,104,
		1,104,1,104,3,104,1584,8,104,1,105,1,105,1,106,1,106,1,106,1,106,1,106,
		1,106,3,106,1594,8,106,1,106,1,106,1,106,3,106,1599,8,106,1,106,1,106,
		1,106,3,106,1604,8,106,3,106,1606,8,106,1,107,1,107,1,108,1,108,4,108,
		1612,8,108,11,108,12,108,1613,1,108,1,108,4,108,1618,8,108,11,108,12,108,
		1619,1,108,1,108,1,108,5,108,1625,8,108,10,108,12,108,1628,9,108,1,108,
		3,108,1631,8,108,1,109,1,109,1,109,3,109,1636,8,109,1,110,1,110,1,110,
		5,110,1641,8,110,10,110,12,110,1644,9,110,1,111,1,111,5,111,1648,8,111,
		10,111,12,111,1651,9,111,1,112,1,112,1,112,1,112,1,112,1,112,3,112,1659,
		8,112,1,113,1,113,1,113,3,113,1664,8,113,1,114,1,114,1,114,1,115,1,115,
		1,115,1,115,3,115,1673,8,115,1,116,3,116,1676,8,116,1,116,1,116,5,116,
		1680,8,116,10,116,12,116,1683,9,116,1,117,1,117,1,117,3,117,1688,8,117,
		1,117,1,117,1,117,1,117,3,117,1694,8,117,1,118,1,118,3,118,1698,8,118,
		1,119,1,119,1,119,1,119,1,119,3,119,1705,8,119,1,119,5,119,1708,8,119,
		10,119,12,119,1711,9,119,1,120,5,120,1714,8,120,10,120,12,120,1717,9,120,
		1,120,1,120,1,120,1,120,1,120,1,120,3,120,1725,8,120,1,120,5,120,1728,
		8,120,10,120,12,120,1731,9,120,1,121,1,121,3,121,1735,8,121,1,121,1,121,
		1,121,1,121,1,121,3,121,1742,8,121,1,122,3,122,1745,8,122,1,122,1,122,
		3,122,1749,8,122,5,122,1751,8,122,10,122,12,122,1754,9,122,1,123,1,123,
		1,123,1,123,1,123,1,123,1,123,3,123,1763,8,123,1,124,1,124,1,125,1,125,
		1,126,1,126,1,127,1,127,1,128,1,128,1,129,1,129,1,130,1,130,1,130,0,2,
		116,156,131,0,2,4,6,8,10,12,14,16,18,20,22,24,26,28,30,32,34,36,38,40,
		42,44,46,48,50,52,54,56,58,60,62,64,66,68,70,72,74,76,78,80,82,84,86,88,
		90,92,94,96,98,100,102,104,106,108,110,112,114,116,118,120,122,124,126,
		128,130,132,134,136,138,140,142,144,146,148,150,152,154,156,158,160,162,
		164,166,168,170,172,174,176,178,180,182,184,186,188,190,192,194,196,198,
		200,202,204,206,208,210,212,214,216,218,220,222,224,226,228,230,232,234,
		236,238,240,242,244,246,248,250,252,254,256,258,260,0,24,2,0,56,56,81,
		81,2,0,54,54,120,120,1,0,214,215,1,0,202,203,2,0,195,195,197,198,1,0,160,
		161,1,0,87,88,1,0,112,113,1,0,199,201,2,0,197,198,205,205,1,0,185,186,
		2,0,166,167,191,192,1,0,162,165,4,0,168,170,172,180,184,184,216,216,1,
		0,197,198,2,0,221,222,224,225,2,0,54,54,106,106,2,0,44,44,76,76,4,0,44,
		100,102,130,132,155,220,220,4,0,44,44,76,76,109,111,116,116,1,0,148,155,
		1,0,132,147,7,0,45,45,48,48,62,62,93,94,105,105,114,114,117,117,9,0,45,
		45,47,48,61,62,78,78,91,94,105,105,114,114,117,117,123,125,1991,0,263,
		1,0,0,0,2,280,1,0,0,0,4,310,1,0,0,0,6,313,1,0,0,0,8,320,1,0,0,0,10,328,
		1,0,0,0,12,339,1,0,0,0,14,341,1,0,0,0,16,349,1,0,0,0,18,362,1,0,0,0,20,
		364,1,0,0,0,22,386,1,0,0,0,24,389,1,0,0,0,26,412,1,0,0,0,28,456,1,0,0,
		0,30,458,1,0,0,0,32,480,1,0,0,0,34,482,1,0,0,0,36,490,1,0,0,0,38,499,1,
		0,0,0,40,504,1,0,0,0,42,512,1,0,0,0,44,524,1,0,0,0,46,528,1,0,0,0,48,544,
		1,0,0,0,50,551,1,0,0,0,52,557,1,0,0,0,54,586,1,0,0,0,56,588,1,0,0,0,58,
		590,1,0,0,0,60,622,1,0,0,0,62,624,1,0,0,0,64,628,1,0,0,0,66,633,1,0,0,
		0,68,636,1,0,0,0,70,640,1,0,0,0,72,650,1,0,0,0,74,656,1,0,0,0,76,678,1,
		0,0,0,78,680,1,0,0,0,80,682,1,0,0,0,82,715,1,0,0,0,84,721,1,0,0,0,86,727,
		1,0,0,0,88,733,1,0,0,0,90,739,1,0,0,0,92,742,1,0,0,0,94,748,1,0,0,0,96,
		797,1,0,0,0,98,816,1,0,0,0,100,830,1,0,0,0,102,833,1,0,0,0,104,837,1,0,
		0,0,106,841,1,0,0,0,108,854,1,0,0,0,110,858,1,0,0,0,112,867,1,0,0,0,114,
		880,1,0,0,0,116,903,1,0,0,0,118,913,1,0,0,0,120,932,1,0,0,0,122,934,1,
		0,0,0,124,938,1,0,0,0,126,1007,1,0,0,0,128,1018,1,0,0,0,130,1022,1,0,0,
		0,132,1024,1,0,0,0,134,1031,1,0,0,0,136,1045,1,0,0,0,138,1049,1,0,0,0,
		140,1056,1,0,0,0,142,1060,1,0,0,0,144,1063,1,0,0,0,146,1067,1,0,0,0,148,
		1072,1,0,0,0,150,1077,1,0,0,0,152,1090,1,0,0,0,154,1098,1,0,0,0,156,1191,
		1,0,0,0,158,1258,1,0,0,0,160,1271,1,0,0,0,162,1305,1,0,0,0,164,1307,1,
		0,0,0,166,1325,1,0,0,0,168,1336,1,0,0,0,170,1341,1,0,0,0,172,1343,1,0,
		0,0,174,1353,1,0,0,0,176,1376,1,0,0,0,178,1378,1,0,0,0,180,1391,1,0,0,
		0,182,1400,1,0,0,0,184,1412,1,0,0,0,186,1415,1,0,0,0,188,1458,1,0,0,0,
		190,1467,1,0,0,0,192,1487,1,0,0,0,194,1508,1,0,0,0,196,1510,1,0,0,0,198,
		1518,1,0,0,0,200,1544,1,0,0,0,202,1546,1,0,0,0,204,1570,1,0,0,0,206,1577,
		1,0,0,0,208,1583,1,0,0,0,210,1585,1,0,0,0,212,1605,1,0,0,0,214,1607,1,
		0,0,0,216,1630,1,0,0,0,218,1635,1,0,0,0,220,1637,1,0,0,0,222,1645,1,0,
		0,0,224,1658,1,0,0,0,226,1660,1,0,0,0,228,1665,1,0,0,0,230,1672,1,0,0,
		0,232,1675,1,0,0,0,234,1693,1,0,0,0,236,1697,1,0,0,0,238,1704,1,0,0,0,
		240,1715,1,0,0,0,242,1741,1,0,0,0,244,1744,1,0,0,0,246,1762,1,0,0,0,248,
		1764,1,0,0,0,250,1766,1,0,0,0,252,1768,1,0,0,0,254,1770,1,0,0,0,256,1772,
		1,0,0,0,258,1774,1,0,0,0,260,1776,1,0,0,0,262,264,5,10,0,0,263,262,1,0,
		0,0,263,264,1,0,0,0,264,269,1,0,0,0,265,268,3,2,1,0,266,268,3,8,4,0,267,
		265,1,0,0,0,267,266,1,0,0,0,268,271,1,0,0,0,269,267,1,0,0,0,269,270,1,
		0,0,0,270,272,1,0,0,0,271,269,1,0,0,0,272,273,5,0,0,1,273,1,1,0,0,0,274,
		276,3,4,2,0,275,274,1,0,0,0,276,277,1,0,0,0,277,275,1,0,0,0,277,278,1,
		0,0,0,278,281,1,0,0,0,279,281,3,6,3,0,280,275,1,0,0,0,280,279,1,0,0,0,
		281,3,1,0,0,0,282,311,5,8,0,0,283,311,5,15,0,0,284,311,5,6,0,0,285,311,
		5,9,0,0,286,311,5,24,0,0,287,311,5,16,0,0,288,311,5,17,0,0,289,311,5,2,
		0,0,290,311,5,18,0,0,291,311,5,19,0,0,292,311,5,27,0,0,293,311,5,20,0,
		0,294,311,5,31,0,0,295,311,5,21,0,0,296,311,5,22,0,0,297,311,5,28,0,0,
		298,311,5,32,0,0,299,311,5,37,0,0,300,311,5,5,0,0,301,311,5,35,0,0,302,
		306,5,3,0,0,303,305,5,12,0,0,304,303,1,0,0,0,305,308,1,0,0,0,306,304,1,
		0,0,0,306,307,1,0,0,0,307,309,1,0,0,0,308,306,1,0,0,0,309,311,5,13,0,0,
		310,282,1,0,0,0,310,283,1,0,0,0,310,284,1,0,0,0,310,285,1,0,0,0,310,286,
		1,0,0,0,310,287,1,0,0,0,310,288,1,0,0,0,310,289,1,0,0,0,310,290,1,0,0,
		0,310,291,1,0,0,0,310,292,1,0,0,0,310,293,1,0,0,0,310,294,1,0,0,0,310,
		295,1,0,0,0,310,296,1,0,0,0,310,297,1,0,0,0,310,298,1,0,0,0,310,299,1,
		0,0,0,310,300,1,0,0,0,310,301,1,0,0,0,310,302,1,0,0,0,311,5,1,0,0,0,312,
		314,5,34,0,0,313,312,1,0,0,0,314,315,1,0,0,0,315,313,1,0,0,0,315,316,1,
		0,0,0,316,7,1,0,0,0,317,319,3,10,5,0,318,317,1,0,0,0,319,322,1,0,0,0,320,
		318,1,0,0,0,320,321,1,0,0,0,321,324,1,0,0,0,322,320,1,0,0,0,323,325,3,
		12,6,0,324,323,1,0,0,0,325,326,1,0,0,0,326,324,1,0,0,0,326,327,1,0,0,0,
		327,9,1,0,0,0,328,329,5,86,0,0,329,330,5,102,0,0,330,331,3,192,96,0,331,
		332,5,215,0,0,332,11,1,0,0,0,333,340,3,54,27,0,334,340,3,14,7,0,335,340,
		3,20,10,0,336,340,3,24,12,0,337,340,3,26,13,0,338,340,3,150,75,0,339,333,
		1,0,0,0,339,334,1,0,0,0,339,335,1,0,0,0,339,336,1,0,0,0,339,337,1,0,0,
		0,339,338,1,0,0,0,340,13,1,0,0,0,341,343,5,126,0,0,342,344,7,0,0,0,343,
		342,1,0,0,0,343,344,1,0,0,0,344,345,1,0,0,0,345,346,3,16,8,0,346,347,5,
		215,0,0,347,15,1,0,0,0,348,350,5,189,0,0,349,348,1,0,0,0,349,350,1,0,0,
		0,350,351,1,0,0,0,351,359,3,18,9,0,352,354,5,213,0,0,353,355,5,189,0,0,
		354,353,1,0,0,0,354,355,1,0,0,0,355,356,1,0,0,0,356,358,3,18,9,0,357,352,
		1,0,0,0,358,361,1,0,0,0,359,357,1,0,0,0,359,360,1,0,0,0,360,17,1,0,0,0,
		361,359,1,0,0,0,362,363,3,192,96,0,363,19,1,0,0,0,364,379,5,102,0,0,365,
		367,3,192,96,0,366,365,1,0,0,0,366,367,1,0,0,0,367,368,1,0,0,0,368,372,
		5,211,0,0,369,371,3,22,11,0,370,369,1,0,0,0,371,374,1,0,0,0,372,370,1,
		0,0,0,372,373,1,0,0,0,373,375,1,0,0,0,374,372,1,0,0,0,375,380,5,212,0,
		0,376,377,3,192,96,0,377,378,5,215,0,0,378,380,1,0,0,0,379,366,1,0,0,0,
		379,376,1,0,0,0,380,21,1,0,0,0,381,387,3,54,27,0,382,387,3,14,7,0,383,
		387,3,24,12,0,384,387,3,26,13,0,385,387,3,150,75,0,386,381,1,0,0,0,386,
		382,1,0,0,0,386,383,1,0,0,0,386,384,1,0,0,0,386,385,1,0,0,0,387,23,1,0,
		0,0,388,390,3,44,22,0,389,388,1,0,0,0,389,390,1,0,0,0,390,391,1,0,0,0,
		391,393,5,81,0,0,392,394,5,193,0,0,393,392,1,0,0,0,393,394,1,0,0,0,394,
		395,1,0,0,0,395,397,3,250,125,0,396,398,3,32,16,0,397,396,1,0,0,0,397,
		398,1,0,0,0,398,399,1,0,0,0,399,400,5,207,0,0,400,401,3,112,56,0,401,407,
		5,208,0,0,402,404,5,214,0,0,403,405,5,206,0,0,404,403,1,0,0,0,404,405,
		1,0,0,0,405,406,1,0,0,0,406,408,3,116,58,0,407,402,1,0,0,0,407,408,1,0,
		0,0,408,409,1,0,0,0,409,410,3,58,29,0,410,25,1,0,0,0,411,413,3,44,22,0,
		412,411,1,0,0,0,412,413,1,0,0,0,413,415,1,0,0,0,414,416,5,109,0,0,415,
		414,1,0,0,0,415,416,1,0,0,0,416,418,1,0,0,0,417,419,3,248,124,0,418,417,
		1,0,0,0,418,419,1,0,0,0,419,421,1,0,0,0,420,422,5,107,0,0,421,420,1,0,
		0,0,421,422,1,0,0,0,422,445,1,0,0,0,423,424,3,28,14,0,424,426,3,250,125,
		0,425,427,3,32,16,0,426,425,1,0,0,0,426,427,1,0,0,0,427,430,1,0,0,0,428,
		429,5,75,0,0,429,431,3,182,91,0,430,428,1,0,0,0,430,431,1,0,0,0,431,434,
		1,0,0,0,432,433,5,85,0,0,433,435,3,30,15,0,434,432,1,0,0,0,434,435,1,0,
		0,0,435,446,1,0,0,0,436,437,5,95,0,0,437,439,3,250,125,0,438,440,3,32,
		16,0,439,438,1,0,0,0,439,440,1,0,0,0,440,443,1,0,0,0,441,442,5,75,0,0,
		442,444,3,30,15,0,443,441,1,0,0,0,443,444,1,0,0,0,444,446,1,0,0,0,445,
		423,1,0,0,0,445,436,1,0,0,0,446,447,1,0,0,0,447,451,5,211,0,0,448,450,
		3,126,63,0,449,448,1,0,0,0,450,453,1,0,0,0,451,449,1,0,0,0,451,452,1,0,
		0,0,452,454,1,0,0,0,453,451,1,0,0,0,454,455,5,212,0,0,455,27,1,0,0,0,456,
		457,7,1,0,0,457,29,1,0,0,0,458,463,3,182,91,0,459,460,5,213,0,0,460,462,
		3,182,91,0,461,459,1,0,0,0,462,465,1,0,0,0,463,461,1,0,0,0,463,464,1,0,
		0,0,464,31,1,0,0,0,465,463,1,0,0,0,466,467,5,157,0,0,467,468,3,34,17,0,
		468,469,5,158,0,0,469,481,1,0,0,0,470,471,5,157,0,0,471,472,3,36,18,0,
		472,473,5,158,0,0,473,481,1,0,0,0,474,475,5,157,0,0,475,476,3,34,17,0,
		476,477,5,213,0,0,477,478,3,36,18,0,478,479,5,158,0,0,479,481,1,0,0,0,
		480,466,1,0,0,0,480,470,1,0,0,0,480,474,1,0,0,0,481,33,1,0,0,0,482,487,
		3,38,19,0,483,484,5,213,0,0,484,486,3,38,19,0,485,483,1,0,0,0,486,489,
		1,0,0,0,487,485,1,0,0,0,487,488,1,0,0,0,488,35,1,0,0,0,489,487,1,0,0,0,
		490,495,3,40,20,0,491,492,5,213,0,0,492,494,3,40,20,0,493,491,1,0,0,0,
		494,497,1,0,0,0,495,493,1,0,0,0,495,496,1,0,0,0,496,37,1,0,0,0,497,495,
		1,0,0,0,498,500,3,44,22,0,499,498,1,0,0,0,499,500,1,0,0,0,500,501,1,0,
		0,0,501,502,3,250,125,0,502,39,1,0,0,0,503,505,3,44,22,0,504,503,1,0,0,
		0,504,505,1,0,0,0,505,506,1,0,0,0,506,507,3,250,125,0,507,510,5,216,0,
		0,508,511,3,182,91,0,509,511,3,258,129,0,510,508,1,0,0,0,510,509,1,0,0,
		0,511,41,1,0,0,0,512,513,5,157,0,0,513,518,3,184,92,0,514,515,5,213,0,
		0,515,517,3,184,92,0,516,514,1,0,0,0,517,520,1,0,0,0,518,516,1,0,0,0,518,
		519,1,0,0,0,519,521,1,0,0,0,520,518,1,0,0,0,521,522,5,158,0,0,522,43,1,
		0,0,0,523,525,3,46,23,0,524,523,1,0,0,0,525,526,1,0,0,0,526,524,1,0,0,
		0,526,527,1,0,0,0,527,45,1,0,0,0,528,532,5,43,0,0,529,530,3,250,125,0,
		530,531,5,214,0,0,531,533,1,0,0,0,532,529,1,0,0,0,532,533,1,0,0,0,533,
		534,1,0,0,0,534,539,3,48,24,0,535,536,5,213,0,0,536,538,3,48,24,0,537,
		535,1,0,0,0,538,541,1,0,0,0,539,537,1,0,0,0,539,540,1,0,0,0,540,542,1,
		0,0,0,541,539,1,0,0,0,542,543,5,210,0,0,543,47,1,0,0,0,544,546,3,190,95,
		0,545,547,3,198,99,0,546,545,1,0,0,0,546,547,1,0,0,0,547,49,1,0,0,0,548,
		550,3,52,26,0,549,548,1,0,0,0,550,553,1,0,0,0,551,549,1,0,0,0,551,552,
		1,0,0,0,552,51,1,0,0,0,553,551,1,0,0,0,554,558,3,54,27,0,555,558,3,24,
		12,0,556,558,3,26,13,0,557,554,1,0,0,0,557,555,1,0,0,0,557,556,1,0,0,0,
		558,53,1,0,0,0,559,560,3,250,125,0,560,561,5,214,0,0,561,587,1,0,0,0,562,
		587,3,58,29,0,563,587,3,60,30,0,564,587,3,70,35,0,565,587,3,72,36,0,566,
		587,3,74,37,0,567,587,3,80,40,0,568,587,3,84,42,0,569,587,3,86,43,0,570,
		587,3,88,44,0,571,572,3,172,86,0,572,573,5,215,0,0,573,587,1,0,0,0,574,
		587,3,118,59,0,575,587,3,124,62,0,576,587,3,122,61,0,577,587,3,90,45,0,
		578,587,3,92,46,0,579,587,3,94,47,0,580,587,3,96,48,0,581,587,3,102,51,
		0,582,587,3,104,52,0,583,587,3,106,53,0,584,587,3,56,28,0,585,587,3,108,
		54,0,586,559,1,0,0,0,586,562,1,0,0,0,586,563,1,0,0,0,586,564,1,0,0,0,586,
		565,1,0,0,0,586,566,1,0,0,0,586,567,1,0,0,0,586,568,1,0,0,0,586,569,1,
		0,0,0,586,570,1,0,0,0,586,571,1,0,0,0,586,574,1,0,0,0,586,575,1,0,0,0,
		586,576,1,0,0,0,586,577,1,0,0,0,586,578,1,0,0,0,586,579,1,0,0,0,586,580,
		1,0,0,0,586,581,1,0,0,0,586,582,1,0,0,0,586,583,1,0,0,0,586,584,1,0,0,
		0,586,585,1,0,0,0,587,55,1,0,0,0,588,589,5,215,0,0,589,57,1,0,0,0,590,
		591,5,211,0,0,591,592,3,50,25,0,592,593,5,212,0,0,593,59,1,0,0,0,594,595,
		5,84,0,0,595,596,3,154,77,0,596,600,3,54,27,0,597,599,3,62,31,0,598,597,
		1,0,0,0,599,602,1,0,0,0,600,598,1,0,0,0,600,601,1,0,0,0,601,604,1,0,0,
		0,602,600,1,0,0,0,603,605,3,66,33,0,604,603,1,0,0,0,604,605,1,0,0,0,605,
		623,1,0,0,0,606,607,5,84,0,0,607,608,3,154,77,0,608,609,5,214,0,0,609,
		613,3,50,25,0,610,612,3,64,32,0,611,610,1,0,0,0,612,615,1,0,0,0,613,611,
		1,0,0,0,613,614,1,0,0,0,614,617,1,0,0,0,615,613,1,0,0,0,616,618,3,68,34,
		0,617,616,1,0,0,0,617,618,1,0,0,0,618,619,1,0,0,0,619,620,5,70,0,0,620,
		621,5,215,0,0,621,623,1,0,0,0,622,594,1,0,0,0,622,606,1,0,0,0,623,61,1,
		0,0,0,624,625,5,65,0,0,625,626,3,154,77,0,626,627,3,54,27,0,627,63,1,0,
		0,0,628,629,5,65,0,0,629,630,3,154,77,0,630,631,5,214,0,0,631,632,3,50,
		25,0,632,65,1,0,0,0,633,634,5,64,0,0,634,635,3,54,27,0,635,67,1,0,0,0,
		636,637,5,64,0,0,637,638,5,214,0,0,638,639,3,50,25,0,639,69,1,0,0,0,640,
		641,5,128,0,0,641,648,3,154,77,0,642,649,3,54,27,0,643,644,5,214,0,0,644,
		645,3,50,25,0,645,646,5,72,0,0,646,647,5,215,0,0,647,649,1,0,0,0,648,642,
		1,0,0,0,648,643,1,0,0,0,649,71,1,0,0,0,650,651,5,60,0,0,651,652,3,54,27,
		0,652,653,5,128,0,0,653,654,3,154,77,0,654,655,5,215,0,0,655,73,1,0,0,
		0,656,657,5,79,0,0,657,659,5,207,0,0,658,660,3,76,38,0,659,658,1,0,0,0,
		659,660,1,0,0,0,660,661,1,0,0,0,661,663,5,215,0,0,662,664,3,152,76,0,663,
		662,1,0,0,0,663,664,1,0,0,0,664,665,1,0,0,0,665,667,5,215,0,0,666,668,
		3,78,39,0,667,666,1,0,0,0,667,668,1,0,0,0,668,669,1,0,0,0,669,676,5,208,
		0,0,670,677,3,54,27,0,671,672,5,214,0,0,672,673,3,50,25,0,673,674,5,68,
		0,0,674,675,5,215,0,0,675,677,1,0,0,0,676,670,1,0,0,0,676,671,1,0,0,0,
		677,75,1,0,0,0,678,679,3,152,76,0,679,77,1,0,0,0,680,681,3,152,76,0,681,
		79,1,0,0,0,682,683,5,118,0,0,683,707,3,154,77,0,684,686,5,211,0,0,685,
		687,5,215,0,0,686,685,1,0,0,0,686,687,1,0,0,0,687,691,1,0,0,0,688,690,
		3,82,41,0,689,688,1,0,0,0,690,693,1,0,0,0,691,689,1,0,0,0,691,692,1,0,
		0,0,692,694,1,0,0,0,693,691,1,0,0,0,694,708,5,212,0,0,695,697,5,214,0,
		0,696,698,5,215,0,0,697,696,1,0,0,0,697,698,1,0,0,0,698,702,1,0,0,0,699,
		701,3,82,41,0,700,699,1,0,0,0,701,704,1,0,0,0,702,700,1,0,0,0,702,703,
		1,0,0,0,703,705,1,0,0,0,704,702,1,0,0,0,705,706,5,71,0,0,706,708,5,215,
		0,0,707,684,1,0,0,0,707,695,1,0,0,0,708,81,1,0,0,0,709,710,5,52,0,0,710,
		713,3,156,78,0,711,713,5,59,0,0,712,709,1,0,0,0,712,711,1,0,0,0,713,714,
		1,0,0,0,714,716,7,2,0,0,715,712,1,0,0,0,716,717,1,0,0,0,717,715,1,0,0,
		0,717,718,1,0,0,0,718,719,1,0,0,0,719,720,3,50,25,0,720,83,1,0,0,0,721,
		723,5,50,0,0,722,724,3,156,78,0,723,722,1,0,0,0,723,724,1,0,0,0,724,725,
		1,0,0,0,725,726,5,215,0,0,726,85,1,0,0,0,727,729,5,57,0,0,728,730,3,156,
		78,0,729,728,1,0,0,0,729,730,1,0,0,0,730,731,1,0,0,0,731,732,5,215,0,0,
		732,87,1,0,0,0,733,735,5,115,0,0,734,736,3,156,78,0,735,734,1,0,0,0,735,
		736,1,0,0,0,736,737,1,0,0,0,737,738,5,215,0,0,738,89,1,0,0,0,739,740,3,
		156,78,0,740,741,5,215,0,0,741,91,1,0,0,0,742,743,5,125,0,0,743,744,5,
		207,0,0,744,745,3,220,110,0,745,746,5,208,0,0,746,747,5,215,0,0,747,93,
		1,0,0,0,748,787,5,80,0,0,749,750,5,207,0,0,750,751,3,222,111,0,751,753,
		5,46,0,0,752,754,5,193,0,0,753,752,1,0,0,0,753,754,1,0,0,0,754,755,1,0,
		0,0,755,761,3,158,79,0,756,758,5,159,0,0,757,759,5,193,0,0,758,757,1,0,
		0,0,758,759,1,0,0,0,759,760,1,0,0,0,760,762,3,222,111,0,761,756,1,0,0,
		0,761,762,1,0,0,0,762,763,1,0,0,0,763,764,5,208,0,0,764,788,1,0,0,0,765,
		766,5,207,0,0,766,767,3,156,78,0,767,768,5,46,0,0,768,774,3,158,79,0,769,
		771,5,159,0,0,770,772,5,193,0,0,771,770,1,0,0,0,771,772,1,0,0,0,772,773,
		1,0,0,0,773,775,3,222,111,0,774,769,1,0,0,0,774,775,1,0,0,0,775,776,1,
		0,0,0,776,777,5,208,0,0,777,788,1,0,0,0,778,779,5,207,0,0,779,780,3,222,
		111,0,780,781,5,46,0,0,781,782,5,97,0,0,782,783,5,207,0,0,783,784,3,244,
		122,0,784,785,5,208,0,0,785,786,5,208,0,0,786,788,1,0,0,0,787,749,1,0,
		0,0,787,765,1,0,0,0,787,778,1,0,0,0,788,795,1,0,0,0,789,796,3,54,27,0,
		790,791,5,214,0,0,791,792,3,50,25,0,792,793,5,69,0,0,793,794,5,215,0,0,
		794,796,1,0,0,0,795,789,1,0,0,0,795,790,1,0,0,0,796,95,1,0,0,0,797,798,
		5,121,0,0,798,814,3,58,29,0,799,801,3,98,49,0,800,799,1,0,0,0,801,802,
		1,0,0,0,802,800,1,0,0,0,802,803,1,0,0,0,803,805,1,0,0,0,804,806,3,100,
		50,0,805,804,1,0,0,0,805,806,1,0,0,0,806,815,1,0,0,0,807,809,3,98,49,0,
		808,807,1,0,0,0,809,812,1,0,0,0,810,808,1,0,0,0,810,811,1,0,0,0,811,813,
		1,0,0,0,812,810,1,0,0,0,813,815,3,100,50,0,814,800,1,0,0,0,814,810,1,0,
		0,0,815,97,1,0,0,0,816,817,5,53,0,0,817,818,5,207,0,0,818,823,3,182,91,
		0,819,820,5,194,0,0,820,822,3,182,91,0,821,819,1,0,0,0,822,825,1,0,0,0,
		823,821,1,0,0,0,823,824,1,0,0,0,824,826,1,0,0,0,825,823,1,0,0,0,826,827,
		5,219,0,0,827,828,5,208,0,0,828,829,3,58,29,0,829,99,1,0,0,0,830,831,5,
		77,0,0,831,832,3,58,29,0,832,101,1,0,0,0,833,834,5,119,0,0,834,835,3,156,
		78,0,835,836,5,215,0,0,836,103,1,0,0,0,837,838,5,83,0,0,838,839,3,250,
		125,0,839,840,5,215,0,0,840,105,1,0,0,0,841,842,5,58,0,0,842,843,5,207,
		0,0,843,844,3,110,55,0,844,851,5,208,0,0,845,852,3,54,27,0,846,847,5,214,
		0,0,847,848,3,50,25,0,848,849,5,67,0,0,849,850,5,215,0,0,850,852,1,0,0,
		0,851,845,1,0,0,0,851,846,1,0,0,0,852,107,1,0,0,0,853,855,3,2,1,0,854,
		853,1,0,0,0,855,856,1,0,0,0,856,854,1,0,0,0,856,857,1,0,0,0,857,109,1,
		0,0,0,858,863,3,148,74,0,859,860,5,213,0,0,860,862,3,148,74,0,861,859,
		1,0,0,0,862,865,1,0,0,0,863,861,1,0,0,0,863,864,1,0,0,0,864,111,1,0,0,
		0,865,863,1,0,0,0,866,868,3,114,57,0,867,866,1,0,0,0,867,868,1,0,0,0,868,
		873,1,0,0,0,869,870,5,213,0,0,870,872,3,114,57,0,871,869,1,0,0,0,872,875,
		1,0,0,0,873,871,1,0,0,0,873,874,1,0,0,0,874,877,1,0,0,0,875,873,1,0,0,
		0,876,878,5,213,0,0,877,876,1,0,0,0,877,878,1,0,0,0,878,113,1,0,0,0,879,
		881,3,44,22,0,880,879,1,0,0,0,880,881,1,0,0,0,881,883,1,0,0,0,882,884,
		3,252,126,0,883,882,1,0,0,0,883,884,1,0,0,0,884,886,1,0,0,0,885,887,5,
		206,0,0,886,885,1,0,0,0,886,887,1,0,0,0,887,889,1,0,0,0,888,890,3,116,
		58,0,889,888,1,0,0,0,889,890,1,0,0,0,890,892,1,0,0,0,891,893,5,193,0,0,
		892,891,1,0,0,0,892,893,1,0,0,0,893,895,1,0,0,0,894,896,5,190,0,0,895,
		894,1,0,0,0,895,896,1,0,0,0,896,897,1,0,0,0,897,898,3,146,73,0,898,115,
		1,0,0,0,899,900,6,58,-1,0,900,904,3,182,91,0,901,904,5,51,0,0,902,904,
		3,258,129,0,903,899,1,0,0,0,903,901,1,0,0,0,903,902,1,0,0,0,904,910,1,
		0,0,0,905,906,10,1,0,0,906,907,5,194,0,0,907,909,3,116,58,2,908,905,1,
		0,0,0,909,912,1,0,0,0,910,908,1,0,0,0,910,911,1,0,0,0,911,117,1,0,0,0,
		912,910,1,0,0,0,913,914,5,82,0,0,914,919,3,120,60,0,915,916,5,213,0,0,
		916,918,3,120,60,0,917,915,1,0,0,0,918,921,1,0,0,0,919,917,1,0,0,0,919,
		920,1,0,0,0,920,922,1,0,0,0,921,919,1,0,0,0,922,923,5,215,0,0,923,119,
		1,0,0,0,924,933,5,219,0,0,925,926,5,204,0,0,926,933,3,222,111,0,927,928,
		5,204,0,0,928,929,5,211,0,0,929,930,3,156,78,0,930,931,5,212,0,0,931,933,
		1,0,0,0,932,924,1,0,0,0,932,925,1,0,0,0,932,927,1,0,0,0,933,121,1,0,0,
		0,934,935,5,63,0,0,935,936,3,152,76,0,936,937,5,215,0,0,937,123,1,0,0,
		0,938,939,5,116,0,0,939,944,3,146,73,0,940,941,5,213,0,0,941,943,3,146,
		73,0,942,940,1,0,0,0,943,946,1,0,0,0,944,942,1,0,0,0,944,945,1,0,0,0,945,
		947,1,0,0,0,946,944,1,0,0,0,947,948,5,215,0,0,948,125,1,0,0,0,949,951,
		3,44,22,0,950,949,1,0,0,0,950,951,1,0,0,0,951,1001,1,0,0,0,952,954,3,142,
		71,0,953,955,3,116,58,0,954,953,1,0,0,0,954,955,1,0,0,0,955,956,1,0,0,
		0,956,961,3,146,73,0,957,958,5,213,0,0,958,960,3,146,73,0,959,957,1,0,
		0,0,960,963,1,0,0,0,961,959,1,0,0,0,961,962,1,0,0,0,962,964,1,0,0,0,963,
		961,1,0,0,0,964,965,5,215,0,0,965,1002,1,0,0,0,966,968,3,144,72,0,967,
		966,1,0,0,0,967,968,1,0,0,0,968,999,1,0,0,0,969,971,5,56,0,0,970,972,3,
		116,58,0,971,970,1,0,0,0,971,972,1,0,0,0,972,973,1,0,0,0,973,978,3,148,
		74,0,974,975,5,213,0,0,975,977,3,148,74,0,976,974,1,0,0,0,977,980,1,0,
		0,0,978,976,1,0,0,0,978,979,1,0,0,0,979,981,1,0,0,0,980,978,1,0,0,0,981,
		982,5,215,0,0,982,1000,1,0,0,0,983,985,5,81,0,0,984,986,5,193,0,0,985,
		984,1,0,0,0,985,986,1,0,0,0,986,987,1,0,0,0,987,989,3,250,125,0,988,990,
		3,32,16,0,989,988,1,0,0,0,989,990,1,0,0,0,990,991,1,0,0,0,991,992,5,207,
		0,0,992,993,3,112,56,0,993,995,5,208,0,0,994,996,3,138,69,0,995,994,1,
		0,0,0,995,996,1,0,0,0,996,997,1,0,0,0,997,998,3,140,70,0,998,1000,1,0,
		0,0,999,969,1,0,0,0,999,983,1,0,0,0,1000,1002,1,0,0,0,1001,952,1,0,0,0,
		1001,967,1,0,0,0,1002,1008,1,0,0,0,1003,1004,5,126,0,0,1004,1005,3,196,
		98,0,1005,1006,3,128,64,0,1006,1008,1,0,0,0,1007,950,1,0,0,0,1007,1003,
		1,0,0,0,1008,127,1,0,0,0,1009,1019,5,215,0,0,1010,1014,5,211,0,0,1011,
		1013,3,130,65,0,1012,1011,1,0,0,0,1013,1016,1,0,0,0,1014,1012,1,0,0,0,
		1014,1015,1,0,0,0,1015,1017,1,0,0,0,1016,1014,1,0,0,0,1017,1019,5,212,
		0,0,1018,1009,1,0,0,0,1018,1010,1,0,0,0,1019,129,1,0,0,0,1020,1023,3,132,
		66,0,1021,1023,3,134,67,0,1022,1020,1,0,0,0,1022,1021,1,0,0,0,1023,131,
		1,0,0,0,1024,1025,3,190,95,0,1025,1026,5,187,0,0,1026,1027,3,250,125,0,
		1027,1028,5,90,0,0,1028,1029,3,196,98,0,1029,1030,5,215,0,0,1030,133,1,
		0,0,0,1031,1032,3,136,68,0,1032,1038,5,46,0,0,1033,1039,3,252,126,0,1034,
		1036,3,252,126,0,1035,1034,1,0,0,0,1035,1036,1,0,0,0,1036,1037,1,0,0,0,
		1037,1039,3,250,125,0,1038,1033,1,0,0,0,1038,1035,1,0,0,0,1039,1040,1,
		0,0,0,1040,1041,5,215,0,0,1041,135,1,0,0,0,1042,1043,3,190,95,0,1043,1044,
		5,187,0,0,1044,1046,1,0,0,0,1045,1042,1,0,0,0,1045,1046,1,0,0,0,1046,1047,
		1,0,0,0,1047,1048,3,250,125,0,1048,137,1,0,0,0,1049,1050,5,214,0,0,1050,
		1052,3,250,125,0,1051,1053,3,198,99,0,1052,1051,1,0,0,0,1052,1053,1,0,
		0,0,1053,139,1,0,0,0,1054,1057,5,215,0,0,1055,1057,3,58,29,0,1056,1054,
		1,0,0,0,1056,1055,1,0,0,0,1057,141,1,0,0,0,1058,1061,3,144,72,0,1059,1061,
		5,127,0,0,1060,1058,1,0,0,0,1060,1059,1,0,0,0,1061,143,1,0,0,0,1062,1064,
		3,252,126,0,1063,1062,1,0,0,0,1064,1065,1,0,0,0,1065,1063,1,0,0,0,1065,
		1066,1,0,0,0,1066,145,1,0,0,0,1067,1070,5,219,0,0,1068,1069,5,216,0,0,
		1069,1071,3,204,102,0,1070,1068,1,0,0,0,1070,1071,1,0,0,0,1071,147,1,0,
		0,0,1072,1073,3,250,125,0,1073,1074,5,216,0,0,1074,1075,3,204,102,0,1075,
		149,1,0,0,0,1076,1078,3,44,22,0,1077,1076,1,0,0,0,1077,1078,1,0,0,0,1078,
		1079,1,0,0,0,1079,1080,5,56,0,0,1080,1085,3,148,74,0,1081,1082,5,213,0,
		0,1082,1084,3,148,74,0,1083,1081,1,0,0,0,1084,1087,1,0,0,0,1085,1083,1,
		0,0,0,1085,1086,1,0,0,0,1086,1088,1,0,0,0,1087,1085,1,0,0,0,1088,1089,
		5,215,0,0,1089,151,1,0,0,0,1090,1095,3,156,78,0,1091,1092,5,213,0,0,1092,
		1094,3,156,78,0,1093,1091,1,0,0,0,1094,1097,1,0,0,0,1095,1093,1,0,0,0,
		1095,1096,1,0,0,0,1096,153,1,0,0,0,1097,1095,1,0,0,0,1098,1101,5,207,0,
		0,1099,1102,3,156,78,0,1100,1102,3,172,86,0,1101,1099,1,0,0,0,1101,1100,
		1,0,0,0,1102,1103,1,0,0,0,1103,1104,5,208,0,0,1104,155,1,0,0,0,1105,1106,
		6,78,-1,0,1106,1107,5,55,0,0,1107,1192,3,156,78,47,1108,1192,3,168,84,
		0,1109,1110,3,214,107,0,1110,1111,5,209,0,0,1111,1112,3,156,78,0,1112,
		1113,5,210,0,0,1113,1192,1,0,0,0,1114,1115,5,207,0,0,1115,1116,3,260,130,
		0,1116,1117,5,208,0,0,1117,1118,3,156,78,44,1118,1192,1,0,0,0,1119,1120,
		7,3,0,0,1120,1192,3,156,78,43,1121,1122,7,4,0,0,1122,1192,3,156,78,42,
		1123,1124,7,5,0,0,1124,1192,3,222,111,0,1125,1126,3,222,111,0,1126,1127,
		7,5,0,0,1127,1192,1,0,0,0,1128,1129,5,108,0,0,1129,1192,3,156,78,39,1130,
		1192,3,160,80,0,1131,1192,3,222,111,0,1132,1192,3,206,103,0,1133,1192,
		3,216,108,0,1134,1192,5,220,0,0,1135,1192,5,226,0,0,1136,1192,3,154,77,
		0,1137,1192,5,129,0,0,1138,1139,5,97,0,0,1139,1140,5,207,0,0,1140,1141,
		3,244,122,0,1141,1142,5,208,0,0,1142,1143,5,216,0,0,1143,1144,3,156,78,
		30,1144,1192,1,0,0,0,1145,1146,5,96,0,0,1146,1147,5,207,0,0,1147,1148,
		3,220,110,0,1148,1149,5,208,0,0,1149,1192,1,0,0,0,1150,1151,5,66,0,0,1151,
		1152,5,207,0,0,1152,1153,3,222,111,0,1153,1154,5,208,0,0,1154,1192,1,0,
		0,0,1155,1156,5,73,0,0,1156,1157,5,207,0,0,1157,1158,3,156,78,0,1158,1159,
		5,208,0,0,1159,1192,1,0,0,0,1160,1164,5,74,0,0,1161,1162,5,207,0,0,1162,
		1165,5,208,0,0,1163,1165,3,154,77,0,1164,1161,1,0,0,0,1164,1163,1,0,0,
		0,1164,1165,1,0,0,0,1165,1192,1,0,0,0,1166,1167,7,6,0,0,1167,1192,3,156,
		78,25,1168,1169,7,7,0,0,1169,1192,3,156,78,24,1170,1192,3,162,81,0,1171,
		1192,3,164,82,0,1172,1173,5,119,0,0,1173,1192,3,156,78,6,1174,1175,3,158,
		79,0,1175,1177,3,170,85,0,1176,1178,3,44,22,0,1177,1176,1,0,0,0,1177,1178,
		1,0,0,0,1178,1179,1,0,0,0,1179,1180,3,156,78,5,1180,1192,1,0,0,0,1181,
		1182,3,158,79,0,1182,1184,5,216,0,0,1183,1185,3,44,22,0,1184,1183,1,0,
		0,0,1184,1185,1,0,0,0,1185,1186,1,0,0,0,1186,1189,5,193,0,0,1187,1190,
		3,222,111,0,1188,1190,3,168,84,0,1189,1187,1,0,0,0,1189,1188,1,0,0,0,1190,
		1192,1,0,0,0,1191,1105,1,0,0,0,1191,1108,1,0,0,0,1191,1109,1,0,0,0,1191,
		1114,1,0,0,0,1191,1119,1,0,0,0,1191,1121,1,0,0,0,1191,1123,1,0,0,0,1191,
		1125,1,0,0,0,1191,1128,1,0,0,0,1191,1130,1,0,0,0,1191,1131,1,0,0,0,1191,
		1132,1,0,0,0,1191,1133,1,0,0,0,1191,1134,1,0,0,0,1191,1135,1,0,0,0,1191,
		1136,1,0,0,0,1191,1137,1,0,0,0,1191,1138,1,0,0,0,1191,1145,1,0,0,0,1191,
		1150,1,0,0,0,1191,1155,1,0,0,0,1191,1160,1,0,0,0,1191,1166,1,0,0,0,1191,
		1168,1,0,0,0,1191,1170,1,0,0,0,1191,1171,1,0,0,0,1191,1172,1,0,0,0,1191,
		1174,1,0,0,0,1191,1181,1,0,0,0,1192,1253,1,0,0,0,1193,1194,10,21,0,0,1194,
		1195,5,171,0,0,1195,1252,3,156,78,21,1196,1197,10,19,0,0,1197,1198,7,8,
		0,0,1198,1252,3,156,78,20,1199,1200,10,18,0,0,1200,1201,7,9,0,0,1201,1252,
		3,156,78,19,1202,1203,10,17,0,0,1203,1204,7,10,0,0,1204,1252,3,156,78,
		18,1205,1206,10,16,0,0,1206,1207,7,11,0,0,1207,1252,3,156,78,17,1208,1209,
		10,15,0,0,1209,1210,7,12,0,0,1210,1252,3,156,78,16,1211,1212,10,14,0,0,
		1212,1213,5,193,0,0,1213,1252,3,156,78,15,1214,1215,10,13,0,0,1215,1216,
		5,196,0,0,1216,1252,3,156,78,14,1217,1218,10,12,0,0,1218,1219,5,194,0,
		0,1219,1252,3,156,78,13,1220,1221,10,11,0,0,1221,1222,5,182,0,0,1222,1252,
		3,156,78,12,1223,1224,10,10,0,0,1224,1225,5,181,0,0,1225,1252,3,156,78,
		11,1226,1227,10,9,0,0,1227,1229,5,206,0,0,1228,1230,3,156,78,0,1229,1228,
		1,0,0,0,1229,1230,1,0,0,0,1230,1231,1,0,0,0,1231,1232,5,214,0,0,1232,1252,
		3,156,78,10,1233,1234,10,8,0,0,1234,1235,5,183,0,0,1235,1252,3,156,78,
		9,1236,1237,10,7,0,0,1237,1238,5,156,0,0,1238,1252,3,156,78,8,1239,1240,
		10,3,0,0,1240,1241,5,98,0,0,1241,1252,3,156,78,4,1242,1243,10,2,0,0,1243,
		1244,5,100,0,0,1244,1252,3,156,78,3,1245,1246,10,1,0,0,1246,1247,5,99,
		0,0,1247,1252,3,156,78,2,1248,1249,10,20,0,0,1249,1250,5,89,0,0,1250,1252,
		3,184,92,0,1251,1193,1,0,0,0,1251,1196,1,0,0,0,1251,1199,1,0,0,0,1251,
		1202,1,0,0,0,1251,1205,1,0,0,0,1251,1208,1,0,0,0,1251,1211,1,0,0,0,1251,
		1214,1,0,0,0,1251,1217,1,0,0,0,1251,1220,1,0,0,0,1251,1223,1,0,0,0,1251,
		1226,1,0,0,0,1251,1233,1,0,0,0,1251,1236,1,0,0,0,1251,1239,1,0,0,0,1251,
		1242,1,0,0,0,1251,1245,1,0,0,0,1251,1248,1,0,0,0,1252,1255,1,0,0,0,1253,
		1251,1,0,0,0,1253,1254,1,0,0,0,1254,157,1,0,0,0,1255,1253,1,0,0,0,1256,
		1259,3,222,111,0,1257,1259,3,160,80,0,1258,1256,1,0,0,0,1258,1257,1,0,
		0,0,1259,159,1,0,0,0,1260,1261,5,45,0,0,1261,1263,5,207,0,0,1262,1264,
		3,174,87,0,1263,1262,1,0,0,0,1263,1264,1,0,0,0,1264,1265,1,0,0,0,1265,
		1272,5,208,0,0,1266,1268,5,209,0,0,1267,1269,3,174,87,0,1268,1267,1,0,
		0,0,1268,1269,1,0,0,0,1269,1270,1,0,0,0,1270,1272,5,210,0,0,1271,1260,
		1,0,0,0,1271,1266,1,0,0,0,1272,1277,1,0,0,0,1273,1274,5,209,0,0,1274,1275,
		3,156,78,0,1275,1276,5,210,0,0,1276,1278,1,0,0,0,1277,1273,1,0,0,0,1277,
		1278,1,0,0,0,1278,161,1,0,0,0,1279,1281,5,116,0,0,1280,1279,1,0,0,0,1280,
		1281,1,0,0,0,1281,1282,1,0,0,0,1282,1284,5,81,0,0,1283,1285,5,193,0,0,
		1284,1283,1,0,0,0,1284,1285,1,0,0,0,1285,1286,1,0,0,0,1286,1287,5,207,
		0,0,1287,1288,3,112,56,0,1288,1290,5,208,0,0,1289,1291,3,178,89,0,1290,
		1289,1,0,0,0,1290,1291,1,0,0,0,1291,1294,1,0,0,0,1292,1293,5,214,0,0,1293,
		1295,3,116,58,0,1294,1292,1,0,0,0,1294,1295,1,0,0,0,1295,1296,1,0,0,0,
		1296,1297,3,58,29,0,1297,1306,1,0,0,0,1298,1299,5,131,0,0,1299,1300,5,
		207,0,0,1300,1301,3,112,56,0,1301,1302,5,208,0,0,1302,1303,5,159,0,0,1303,
		1304,3,156,78,0,1304,1306,1,0,0,0,1305,1280,1,0,0,0,1305,1298,1,0,0,0,
		1306,163,1,0,0,0,1307,1308,5,101,0,0,1308,1309,5,207,0,0,1309,1310,3,156,
		78,0,1310,1311,5,208,0,0,1311,1312,5,211,0,0,1312,1317,3,166,83,0,1313,
		1314,5,213,0,0,1314,1316,3,166,83,0,1315,1313,1,0,0,0,1316,1319,1,0,0,
		0,1317,1315,1,0,0,0,1317,1318,1,0,0,0,1318,1321,1,0,0,0,1319,1317,1,0,
		0,0,1320,1322,5,213,0,0,1321,1320,1,0,0,0,1321,1322,1,0,0,0,1322,1323,
		1,0,0,0,1323,1324,5,212,0,0,1324,165,1,0,0,0,1325,1330,3,156,78,0,1326,
		1327,5,213,0,0,1327,1329,3,156,78,0,1328,1326,1,0,0,0,1329,1332,1,0,0,
		0,1330,1328,1,0,0,0,1330,1331,1,0,0,0,1331,1333,1,0,0,0,1332,1330,1,0,
		0,0,1333,1334,5,159,0,0,1334,1335,3,156,78,0,1335,167,1,0,0,0,1336,1337,
		5,103,0,0,1337,1339,3,184,92,0,1338,1340,3,198,99,0,1339,1338,1,0,0,0,
		1339,1340,1,0,0,0,1340,169,1,0,0,0,1341,1342,7,13,0,0,1342,171,1,0,0,0,
		1343,1351,5,129,0,0,1344,1347,3,156,78,0,1345,1346,5,159,0,0,1346,1348,
		3,156,78,0,1347,1345,1,0,0,0,1347,1348,1,0,0,0,1348,1352,1,0,0,0,1349,
		1350,5,130,0,0,1350,1352,3,156,78,0,1351,1344,1,0,0,0,1351,1349,1,0,0,
		0,1352,173,1,0,0,0,1353,1358,3,176,88,0,1354,1355,5,213,0,0,1355,1357,
		3,176,88,0,1356,1354,1,0,0,0,1357,1360,1,0,0,0,1358,1356,1,0,0,0,1358,
		1359,1,0,0,0,1359,1362,1,0,0,0,1360,1358,1,0,0,0,1361,1363,5,213,0,0,1362,
		1361,1,0,0,0,1362,1363,1,0,0,0,1363,175,1,0,0,0,1364,1367,3,156,78,0,1365,
		1366,5,159,0,0,1366,1368,3,156,78,0,1367,1365,1,0,0,0,1367,1368,1,0,0,
		0,1368,1377,1,0,0,0,1369,1370,3,156,78,0,1370,1371,5,159,0,0,1371,1373,
		1,0,0,0,1372,1369,1,0,0,0,1372,1373,1,0,0,0,1373,1374,1,0,0,0,1374,1375,
		5,193,0,0,1375,1377,3,222,111,0,1376,1364,1,0,0,0,1376,1372,1,0,0,0,1377,
		177,1,0,0,0,1378,1379,5,126,0,0,1379,1380,5,207,0,0,1380,1385,3,180,90,
		0,1381,1382,5,213,0,0,1382,1384,3,180,90,0,1383,1381,1,0,0,0,1384,1387,
		1,0,0,0,1385,1383,1,0,0,0,1385,1386,1,0,0,0,1386,1388,1,0,0,0,1387,1385,
		1,0,0,0,1388,1389,5,208,0,0,1389,179,1,0,0,0,1390,1392,5,193,0,0,1391,
		1390,1,0,0,0,1391,1392,1,0,0,0,1392,1393,1,0,0,0,1393,1394,5,219,0,0,1394,
		181,1,0,0,0,1395,1397,3,190,95,0,1396,1398,3,42,21,0,1397,1396,1,0,0,0,
		1397,1398,1,0,0,0,1398,1401,1,0,0,0,1399,1401,5,116,0,0,1400,1395,1,0,
		0,0,1400,1399,1,0,0,0,1401,183,1,0,0,0,1402,1405,3,190,95,0,1403,1405,
		3,188,94,0,1404,1402,1,0,0,0,1404,1403,1,0,0,0,1405,1407,1,0,0,0,1406,
		1408,3,42,21,0,1407,1406,1,0,0,0,1407,1408,1,0,0,0,1408,1413,1,0,0,0,1409,
		1413,3,258,129,0,1410,1413,5,116,0,0,1411,1413,3,186,93,0,1412,1404,1,
		0,0,0,1412,1409,1,0,0,0,1412,1410,1,0,0,0,1412,1411,1,0,0,0,1413,185,1,
		0,0,0,1414,1416,3,44,22,0,1415,1414,1,0,0,0,1415,1416,1,0,0,0,1416,1418,
		1,0,0,0,1417,1419,5,109,0,0,1418,1417,1,0,0,0,1418,1419,1,0,0,0,1419,1421,
		1,0,0,0,1420,1422,3,248,124,0,1421,1420,1,0,0,0,1421,1422,1,0,0,0,1422,
		1424,1,0,0,0,1423,1425,5,107,0,0,1424,1423,1,0,0,0,1424,1425,1,0,0,0,1425,
		1447,1,0,0,0,1426,1428,3,28,14,0,1427,1429,3,32,16,0,1428,1427,1,0,0,0,
		1428,1429,1,0,0,0,1429,1432,1,0,0,0,1430,1431,5,75,0,0,1431,1433,3,182,
		91,0,1432,1430,1,0,0,0,1432,1433,1,0,0,0,1433,1436,1,0,0,0,1434,1435,5,
		85,0,0,1435,1437,3,30,15,0,1436,1434,1,0,0,0,1436,1437,1,0,0,0,1437,1448,
		1,0,0,0,1438,1439,5,95,0,0,1439,1441,3,250,125,0,1440,1442,3,32,16,0,1441,
		1440,1,0,0,0,1441,1442,1,0,0,0,1442,1445,1,0,0,0,1443,1444,5,75,0,0,1444,
		1446,3,30,15,0,1445,1443,1,0,0,0,1445,1446,1,0,0,0,1446,1448,1,0,0,0,1447,
		1426,1,0,0,0,1447,1438,1,0,0,0,1448,1449,1,0,0,0,1449,1453,5,211,0,0,1450,
		1452,3,126,63,0,1451,1450,1,0,0,0,1452,1455,1,0,0,0,1453,1451,1,0,0,0,
		1453,1454,1,0,0,0,1454,1456,1,0,0,0,1455,1453,1,0,0,0,1456,1457,5,212,
		0,0,1457,187,1,0,0,0,1458,1463,3,234,117,0,1459,1460,5,188,0,0,1460,1462,
		3,236,118,0,1461,1459,1,0,0,0,1462,1465,1,0,0,0,1463,1461,1,0,0,0,1463,
		1464,1,0,0,0,1464,189,1,0,0,0,1465,1463,1,0,0,0,1466,1468,5,102,0,0,1467,
		1466,1,0,0,0,1467,1468,1,0,0,0,1468,1470,1,0,0,0,1469,1471,5,189,0,0,1470,
		1469,1,0,0,0,1470,1471,1,0,0,0,1471,1472,1,0,0,0,1472,1473,3,192,96,0,
		1473,191,1,0,0,0,1474,1488,3,250,125,0,1475,1480,3,250,125,0,1476,1477,
		5,189,0,0,1477,1479,3,250,125,0,1478,1476,1,0,0,0,1479,1482,1,0,0,0,1480,
		1478,1,0,0,0,1480,1481,1,0,0,0,1481,1485,1,0,0,0,1482,1480,1,0,0,0,1483,
		1484,5,189,0,0,1484,1486,3,194,97,0,1485,1483,1,0,0,0,1485,1486,1,0,0,
		0,1486,1488,1,0,0,0,1487,1474,1,0,0,0,1487,1475,1,0,0,0,1488,193,1,0,0,
		0,1489,1492,3,250,125,0,1490,1491,5,46,0,0,1491,1493,3,250,125,0,1492,
		1490,1,0,0,0,1492,1493,1,0,0,0,1493,1509,1,0,0,0,1494,1495,5,211,0,0,1495,
		1500,3,194,97,0,1496,1497,5,213,0,0,1497,1499,3,194,97,0,1498,1496,1,0,
		0,0,1499,1502,1,0,0,0,1500,1498,1,0,0,0,1500,1501,1,0,0,0,1501,1504,1,
		0,0,0,1502,1500,1,0,0,0,1503,1505,5,213,0,0,1504,1503,1,0,0,0,1504,1505,
		1,0,0,0,1505,1506,1,0,0,0,1506,1507,5,212,0,0,1507,1509,1,0,0,0,1508,1489,
		1,0,0,0,1508,1494,1,0,0,0,1509,195,1,0,0,0,1510,1515,3,190,95,0,1511,1512,
		5,213,0,0,1512,1514,3,190,95,0,1513,1511,1,0,0,0,1514,1517,1,0,0,0,1515,
		1513,1,0,0,0,1515,1516,1,0,0,0,1516,197,1,0,0,0,1517,1515,1,0,0,0,1518,
		1528,5,207,0,0,1519,1524,3,200,100,0,1520,1521,5,213,0,0,1521,1523,3,200,
		100,0,1522,1520,1,0,0,0,1523,1526,1,0,0,0,1524,1522,1,0,0,0,1524,1525,
		1,0,0,0,1525,1529,1,0,0,0,1526,1524,1,0,0,0,1527,1529,3,172,86,0,1528,
		1519,1,0,0,0,1528,1527,1,0,0,0,1528,1529,1,0,0,0,1529,1531,1,0,0,0,1530,
		1532,5,213,0,0,1531,1530,1,0,0,0,1531,1532,1,0,0,0,1532,1533,1,0,0,0,1533,
		1534,5,208,0,0,1534,199,1,0,0,0,1535,1537,3,202,101,0,1536,1535,1,0,0,
		0,1536,1537,1,0,0,0,1537,1539,1,0,0,0,1538,1540,5,190,0,0,1539,1538,1,
		0,0,0,1539,1540,1,0,0,0,1540,1541,1,0,0,0,1541,1545,3,156,78,0,1542,1543,
		5,193,0,0,1543,1545,3,222,111,0,1544,1536,1,0,0,0,1544,1542,1,0,0,0,1545,
		201,1,0,0,0,1546,1547,3,250,125,0,1547,1548,5,214,0,0,1548,203,1,0,0,0,
		1549,1571,3,206,103,0,1550,1571,3,216,108,0,1551,1552,5,45,0,0,1552,1557,
		5,207,0,0,1553,1555,3,174,87,0,1554,1556,5,213,0,0,1555,1554,1,0,0,0,1555,
		1556,1,0,0,0,1556,1558,1,0,0,0,1557,1553,1,0,0,0,1557,1558,1,0,0,0,1558,
		1559,1,0,0,0,1559,1571,5,208,0,0,1560,1565,5,209,0,0,1561,1563,3,174,87,
		0,1562,1564,5,213,0,0,1563,1562,1,0,0,0,1563,1564,1,0,0,0,1564,1566,1,
		0,0,0,1565,1561,1,0,0,0,1565,1566,1,0,0,0,1566,1567,1,0,0,0,1567,1571,
		5,210,0,0,1568,1569,7,14,0,0,1569,1571,3,204,102,0,1570,1549,1,0,0,0,1570,
		1550,1,0,0,0,1570,1551,1,0,0,0,1570,1560,1,0,0,0,1570,1568,1,0,0,0,1571,
		205,1,0,0,0,1572,1578,5,104,0,0,1573,1578,3,208,104,0,1574,1578,3,254,
		127,0,1575,1578,3,212,106,0,1576,1578,3,190,95,0,1577,1572,1,0,0,0,1577,
		1573,1,0,0,0,1577,1574,1,0,0,0,1577,1575,1,0,0,0,1577,1576,1,0,0,0,1578,
		207,1,0,0,0,1579,1584,5,223,0,0,1580,1584,5,49,0,0,1581,1584,3,210,105,
		0,1582,1584,3,214,107,0,1583,1579,1,0,0,0,1583,1580,1,0,0,0,1583,1581,
		1,0,0,0,1583,1582,1,0,0,0,1584,209,1,0,0,0,1585,1586,7,15,0,0,1586,211,
		1,0,0,0,1587,1588,7,16,0,0,1588,1593,5,187,0,0,1589,1594,3,250,125,0,1590,
		1594,5,136,0,0,1591,1594,5,132,0,0,1592,1594,5,133,0,0,1593,1589,1,0,0,
		0,1593,1590,1,0,0,0,1593,1591,1,0,0,0,1593,1592,1,0,0,0,1594,1606,1,0,
		0,0,1595,1599,3,182,91,0,1596,1599,3,240,120,0,1597,1599,3,216,108,0,1598,
		1595,1,0,0,0,1598,1596,1,0,0,0,1598,1597,1,0,0,0,1599,1600,1,0,0,0,1600,
		1603,5,187,0,0,1601,1604,3,250,125,0,1602,1604,3,240,120,0,1603,1601,1,
		0,0,0,1603,1602,1,0,0,0,1604,1606,1,0,0,0,1605,1587,1,0,0,0,1605,1598,
		1,0,0,0,1606,213,1,0,0,0,1607,1608,5,220,0,0,1608,215,1,0,0,0,1609,1611,
		5,230,0,0,1610,1612,5,238,0,0,1611,1610,1,0,0,0,1612,1613,1,0,0,0,1613,
		1611,1,0,0,0,1613,1614,1,0,0,0,1614,1631,1,0,0,0,1615,1617,5,229,0,0,1616,
		1618,5,238,0,0,1617,1616,1,0,0,0,1618,1619,1,0,0,0,1619,1617,1,0,0,0,1619,
		1620,1,0,0,0,1620,1631,1,0,0,0,1621,1631,5,227,0,0,1622,1626,5,228,0,0,
		1623,1625,3,218,109,0,1624,1623,1,0,0,0,1625,1628,1,0,0,0,1626,1624,1,
		0,0,0,1626,1627,1,0,0,0,1627,1629,1,0,0,0,1628,1626,1,0,0,0,1629,1631,
		5,228,0,0,1630,1609,1,0,0,0,1630,1615,1,0,0,0,1630,1621,1,0,0,0,1630,1622,
		1,0,0,0,1631,217,1,0,0,0,1632,1636,5,234,0,0,1633,1636,5,233,0,0,1634,
		1636,3,222,111,0,1635,1632,1,0,0,0,1635,1633,1,0,0,0,1635,1634,1,0,0,0,
		1636,219,1,0,0,0,1637,1642,3,222,111,0,1638,1639,5,213,0,0,1639,1641,3,
		222,111,0,1640,1638,1,0,0,0,1641,1644,1,0,0,0,1642,1640,1,0,0,0,1642,1643,
		1,0,0,0,1643,221,1,0,0,0,1644,1642,1,0,0,0,1645,1649,3,224,112,0,1646,
		1648,3,226,113,0,1647,1646,1,0,0,0,1648,1651,1,0,0,0,1649,1647,1,0,0,0,
		1649,1650,1,0,0,0,1650,223,1,0,0,0,1651,1649,1,0,0,0,1652,1659,3,234,117,
		0,1653,1659,3,228,114,0,1654,1655,5,207,0,0,1655,1656,3,168,84,0,1656,
		1657,5,208,0,0,1657,1659,1,0,0,0,1658,1652,1,0,0,0,1658,1653,1,0,0,0,1658,
		1654,1,0,0,0,1659,225,1,0,0,0,1660,1661,5,188,0,0,1661,1663,3,236,118,
		0,1662,1664,3,232,116,0,1663,1662,1,0,0,0,1663,1664,1,0,0,0,1664,227,1,
		0,0,0,1665,1666,3,230,115,0,1666,1667,3,232,116,0,1667,229,1,0,0,0,1668,
		1673,3,190,95,0,1669,1673,3,212,106,0,1670,1673,3,234,117,0,1671,1673,
		3,154,77,0,1672,1668,1,0,0,0,1672,1669,1,0,0,0,1672,1670,1,0,0,0,1672,
		1671,1,0,0,0,1673,231,1,0,0,0,1674,1676,3,42,21,0,1675,1674,1,0,0,0,1675,
		1676,1,0,0,0,1676,1677,1,0,0,0,1677,1681,3,198,99,0,1678,1680,3,242,121,
		0,1679,1678,1,0,0,0,1680,1683,1,0,0,0,1681,1679,1,0,0,0,1681,1682,1,0,
		0,0,1682,233,1,0,0,0,1683,1681,1,0,0,0,1684,1687,3,240,120,0,1685,1686,
		5,187,0,0,1686,1688,3,240,120,0,1687,1685,1,0,0,0,1687,1688,1,0,0,0,1688,
		1694,1,0,0,0,1689,1690,3,182,91,0,1690,1691,5,187,0,0,1691,1692,3,240,
		120,0,1692,1694,1,0,0,0,1693,1684,1,0,0,0,1693,1689,1,0,0,0,1694,235,1,
		0,0,0,1695,1698,3,238,119,0,1696,1698,3,240,120,0,1697,1695,1,0,0,0,1697,
		1696,1,0,0,0,1698,237,1,0,0,0,1699,1705,3,250,125,0,1700,1701,5,211,0,
		0,1701,1702,3,156,78,0,1702,1703,5,212,0,0,1703,1705,1,0,0,0,1704,1699,
		1,0,0,0,1704,1700,1,0,0,0,1705,1709,1,0,0,0,1706,1708,3,242,121,0,1707,
		1706,1,0,0,0,1708,1711,1,0,0,0,1709,1707,1,0,0,0,1709,1710,1,0,0,0,1710,
		239,1,0,0,0,1711,1709,1,0,0,0,1712,1714,5,204,0,0,1713,1712,1,0,0,0,1714,
		1717,1,0,0,0,1715,1713,1,0,0,0,1715,1716,1,0,0,0,1716,1724,1,0,0,0,1717,
		1715,1,0,0,0,1718,1725,5,219,0,0,1719,1720,5,204,0,0,1720,1721,5,211,0,
		0,1721,1722,3,156,78,0,1722,1723,5,212,0,0,1723,1725,1,0,0,0,1724,1718,
		1,0,0,0,1724,1719,1,0,0,0,1725,1729,1,0,0,0,1726,1728,3,242,121,0,1727,
		1726,1,0,0,0,1728,1731,1,0,0,0,1729,1727,1,0,0,0,1729,1730,1,0,0,0,1730,
		241,1,0,0,0,1731,1729,1,0,0,0,1732,1734,5,209,0,0,1733,1735,3,156,78,0,
		1734,1733,1,0,0,0,1734,1735,1,0,0,0,1735,1736,1,0,0,0,1736,1742,5,210,
		0,0,1737,1738,5,211,0,0,1738,1739,3,156,78,0,1739,1740,5,212,0,0,1740,
		1742,1,0,0,0,1741,1732,1,0,0,0,1741,1737,1,0,0,0,1742,243,1,0,0,0,1743,
		1745,3,246,123,0,1744,1743,1,0,0,0,1744,1745,1,0,0,0,1745,1752,1,0,0,0,
		1746,1748,5,213,0,0,1747,1749,3,246,123,0,1748,1747,1,0,0,0,1748,1749,
		1,0,0,0,1749,1751,1,0,0,0,1750,1746,1,0,0,0,1751,1754,1,0,0,0,1752,1750,
		1,0,0,0,1752,1753,1,0,0,0,1753,245,1,0,0,0,1754,1752,1,0,0,0,1755,1763,
		3,222,111,0,1756,1757,5,97,0,0,1757,1758,5,207,0,0,1758,1759,3,244,122,
		0,1759,1760,5,208,0,0,1760,1763,1,0,0,0,1761,1763,3,176,88,0,1762,1755,
		1,0,0,0,1762,1756,1,0,0,0,1762,1761,1,0,0,0,1763,247,1,0,0,0,1764,1765,
		7,17,0,0,1765,249,1,0,0,0,1766,1767,7,18,0,0,1767,251,1,0,0,0,1768,1769,
		7,19,0,0,1769,253,1,0,0,0,1770,1771,7,20,0,0,1771,255,1,0,0,0,1772,1773,
		7,21,0,0,1773,257,1,0,0,0,1774,1775,7,22,0,0,1775,259,1,0,0,0,1776,1777,
		7,23,0,0,1777,261,1,0,0,0,227,263,267,269,277,280,306,310,315,320,326,
		339,343,349,354,359,366,372,379,386,389,393,397,404,407,412,415,418,421,
		426,430,434,439,443,445,451,463,480,487,495,499,504,510,518,526,532,539,
		546,551,557,586,600,604,613,617,622,648,659,663,667,676,686,691,697,702,
		707,712,717,723,729,735,753,758,761,771,774,787,795,802,805,810,814,823,
		851,856,863,867,873,877,880,883,886,889,892,895,903,910,919,932,944,950,
		954,961,967,971,978,985,989,995,999,1001,1007,1014,1018,1022,1035,1038,
		1045,1052,1056,1060,1065,1070,1077,1085,1095,1101,1164,1177,1184,1189,
		1191,1229,1251,1253,1258,1263,1268,1271,1277,1280,1284,1290,1294,1305,
		1317,1321,1330,1339,1347,1351,1358,1362,1367,1372,1376,1385,1391,1397,
		1400,1404,1407,1412,1415,1418,1421,1424,1428,1432,1436,1441,1445,1447,
		1453,1463,1467,1470,1480,1485,1487,1492,1500,1504,1508,1515,1524,1528,
		1531,1536,1539,1544,1555,1557,1563,1565,1570,1577,1583,1593,1598,1603,
		1605,1613,1619,1626,1630,1635,1642,1649,1658,1663,1672,1675,1681,1687,
		1693,1697,1704,1709,1715,1724,1729,1734,1741,1744,1748,1752,1762
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
