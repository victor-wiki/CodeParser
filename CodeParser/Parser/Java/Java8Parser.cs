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
public partial class Java8Parser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		ABSTRACT=1, ASSERT=2, BOOLEAN=3, BREAK=4, BYTE=5, CASE=6, CATCH=7, CHAR=8, 
		CLASS=9, CONST=10, CONTINUE=11, DEFAULT=12, DO=13, DOUBLE=14, ELSE=15, 
		ENUM=16, EXTENDS=17, FINAL=18, FINALLY=19, FLOAT=20, FOR=21, IF=22, GOTO=23, 
		IMPLEMENTS=24, IMPORT=25, INSTANCEOF=26, INT=27, INTERFACE=28, LONG=29, 
		NATIVE=30, NEW=31, PACKAGE=32, PRIVATE=33, PROTECTED=34, PUBLIC=35, RETURN=36, 
		SHORT=37, STATIC=38, STRICTFP=39, SUPER=40, SWITCH=41, SYNCHRONIZED=42, 
		THIS=43, THROW=44, THROWS=45, TRANSIENT=46, TRY=47, VOID=48, VOLATILE=49, 
		WHILE=50, IntegerLiteral=51, FloatingPointLiteral=52, BooleanLiteral=53, 
		CharacterLiteral=54, StringLiteral=55, NullLiteral=56, LPAREN=57, RPAREN=58, 
		LBRACE=59, RBRACE=60, LBRACK=61, RBRACK=62, SEMI=63, COMMA=64, DOT=65, 
		ASSIGN=66, GT=67, LT=68, BANG=69, TILDE=70, QUESTION=71, COLON=72, EQUAL=73, 
		LE=74, GE=75, NOTEQUAL=76, AND=77, OR=78, INC=79, DEC=80, ADD=81, SUB=82, 
		MUL=83, DIV=84, BITAND=85, BITOR=86, CARET=87, MOD=88, ARROW=89, COLONCOLON=90, 
		ADD_ASSIGN=91, SUB_ASSIGN=92, MUL_ASSIGN=93, DIV_ASSIGN=94, AND_ASSIGN=95, 
		OR_ASSIGN=96, XOR_ASSIGN=97, MOD_ASSIGN=98, LSHIFT_ASSIGN=99, RSHIFT_ASSIGN=100, 
		URSHIFT_ASSIGN=101, Identifier=102, AT=103, ELLIPSIS=104, WS=105, COMMENT=106, 
		LINE_COMMENT=107;
	public const int
		RULE_literal = 0, RULE_primitiveType = 1, RULE_numericType = 2, RULE_integralType = 3, 
		RULE_floatingPointType = 4, RULE_referenceType = 5, RULE_classOrInterfaceType = 6, 
		RULE_classType = 7, RULE_classType_lf_classOrInterfaceType = 8, RULE_classType_lfno_classOrInterfaceType = 9, 
		RULE_interfaceType = 10, RULE_interfaceType_lf_classOrInterfaceType = 11, 
		RULE_interfaceType_lfno_classOrInterfaceType = 12, RULE_typeVariable = 13, 
		RULE_arrayType = 14, RULE_dims = 15, RULE_typeParameter = 16, RULE_typeParameterModifier = 17, 
		RULE_typeBound = 18, RULE_additionalBound = 19, RULE_typeArguments = 20, 
		RULE_typeArgumentList = 21, RULE_typeArgument = 22, RULE_wildcard = 23, 
		RULE_wildcardBounds = 24, RULE_packageName = 25, RULE_typeName = 26, RULE_packageOrTypeName = 27, 
		RULE_expressionName = 28, RULE_methodName = 29, RULE_ambiguousName = 30, 
		RULE_compilationUnit = 31, RULE_packageDeclaration = 32, RULE_packageModifier = 33, 
		RULE_importDeclaration = 34, RULE_singleTypeImportDeclaration = 35, RULE_typeImportOnDemandDeclaration = 36, 
		RULE_singleStaticImportDeclaration = 37, RULE_staticImportOnDemandDeclaration = 38, 
		RULE_typeDeclaration = 39, RULE_classDeclaration = 40, RULE_normalClassDeclaration = 41, 
		RULE_classModifier = 42, RULE_typeParameters = 43, RULE_typeParameterList = 44, 
		RULE_superclass = 45, RULE_superinterfaces = 46, RULE_interfaceTypeList = 47, 
		RULE_classBody = 48, RULE_classBodyDeclaration = 49, RULE_classMemberDeclaration = 50, 
		RULE_fieldDeclaration = 51, RULE_fieldModifier = 52, RULE_variableDeclaratorList = 53, 
		RULE_variableDeclarator = 54, RULE_variableDeclaratorId = 55, RULE_variableInitializer = 56, 
		RULE_unannType = 57, RULE_unannPrimitiveType = 58, RULE_unannReferenceType = 59, 
		RULE_unannClassOrInterfaceType = 60, RULE_unannClassType = 61, RULE_unannClassType_lf_unannClassOrInterfaceType = 62, 
		RULE_unannClassType_lfno_unannClassOrInterfaceType = 63, RULE_unannInterfaceType = 64, 
		RULE_unannInterfaceType_lf_unannClassOrInterfaceType = 65, RULE_unannInterfaceType_lfno_unannClassOrInterfaceType = 66, 
		RULE_unannTypeVariable = 67, RULE_unannArrayType = 68, RULE_methodDeclaration = 69, 
		RULE_methodModifier = 70, RULE_methodHeader = 71, RULE_result = 72, RULE_methodDeclarator = 73, 
		RULE_formalParameterList = 74, RULE_formalParameters = 75, RULE_formalParameter = 76, 
		RULE_variableModifier = 77, RULE_lastFormalParameter = 78, RULE_receiverParameter = 79, 
		RULE_throws_ = 80, RULE_exceptionTypeList = 81, RULE_exceptionType = 82, 
		RULE_methodBody = 83, RULE_instanceInitializer = 84, RULE_staticInitializer = 85, 
		RULE_constructorDeclaration = 86, RULE_constructorModifier = 87, RULE_constructorDeclarator = 88, 
		RULE_simpleTypeName = 89, RULE_constructorBody = 90, RULE_explicitConstructorInvocation = 91, 
		RULE_enumDeclaration = 92, RULE_enumBody = 93, RULE_enumConstantList = 94, 
		RULE_enumConstant = 95, RULE_enumConstantModifier = 96, RULE_enumBodyDeclarations = 97, 
		RULE_interfaceDeclaration = 98, RULE_normalInterfaceDeclaration = 99, 
		RULE_interfaceModifier = 100, RULE_extendsInterfaces = 101, RULE_interfaceBody = 102, 
		RULE_interfaceMemberDeclaration = 103, RULE_constantDeclaration = 104, 
		RULE_constantModifier = 105, RULE_interfaceMethodDeclaration = 106, RULE_interfaceMethodModifier = 107, 
		RULE_annotationTypeDeclaration = 108, RULE_annotationTypeBody = 109, RULE_annotationTypeMemberDeclaration = 110, 
		RULE_annotationTypeElementDeclaration = 111, RULE_annotationTypeElementModifier = 112, 
		RULE_defaultValue = 113, RULE_annotation = 114, RULE_normalAnnotation = 115, 
		RULE_elementValuePairList = 116, RULE_elementValuePair = 117, RULE_elementValue = 118, 
		RULE_elementValueArrayInitializer = 119, RULE_elementValueList = 120, 
		RULE_markerAnnotation = 121, RULE_singleElementAnnotation = 122, RULE_arrayInitializer = 123, 
		RULE_variableInitializerList = 124, RULE_block = 125, RULE_blockStatements = 126, 
		RULE_blockStatement = 127, RULE_localVariableDeclarationStatement = 128, 
		RULE_localVariableDeclaration = 129, RULE_statement = 130, RULE_statementNoShortIf = 131, 
		RULE_statementWithoutTrailingSubstatement = 132, RULE_emptyStatement_ = 133, 
		RULE_labeledStatement = 134, RULE_labeledStatementNoShortIf = 135, RULE_expressionStatement = 136, 
		RULE_statementExpression = 137, RULE_ifThenStatement = 138, RULE_ifThenElseStatement = 139, 
		RULE_ifThenElseStatementNoShortIf = 140, RULE_assertStatement = 141, RULE_switchStatement = 142, 
		RULE_switchBlock = 143, RULE_switchBlockStatementGroup = 144, RULE_switchLabels = 145, 
		RULE_switchLabel = 146, RULE_enumConstantName = 147, RULE_whileStatement = 148, 
		RULE_whileStatementNoShortIf = 149, RULE_doStatement = 150, RULE_forStatement = 151, 
		RULE_forStatementNoShortIf = 152, RULE_basicForStatement = 153, RULE_basicForStatementNoShortIf = 154, 
		RULE_forInit = 155, RULE_forUpdate = 156, RULE_statementExpressionList = 157, 
		RULE_enhancedForStatement = 158, RULE_enhancedForStatementNoShortIf = 159, 
		RULE_breakStatement = 160, RULE_continueStatement = 161, RULE_returnStatement = 162, 
		RULE_throwStatement = 163, RULE_synchronizedStatement = 164, RULE_tryStatement = 165, 
		RULE_catches = 166, RULE_catchClause = 167, RULE_catchFormalParameter = 168, 
		RULE_catchType = 169, RULE_finally_ = 170, RULE_tryWithResourcesStatement = 171, 
		RULE_resourceSpecification = 172, RULE_resourceList = 173, RULE_resource = 174, 
		RULE_primary = 175, RULE_primaryNoNewArray = 176, RULE_primaryNoNewArray_lf_arrayAccess = 177, 
		RULE_primaryNoNewArray_lfno_arrayAccess = 178, RULE_primaryNoNewArray_lf_primary = 179, 
		RULE_primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary = 180, RULE_primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary = 181, 
		RULE_primaryNoNewArray_lfno_primary = 182, RULE_primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary = 183, 
		RULE_primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary = 184, 
		RULE_classInstanceCreationExpression = 185, RULE_classInstanceCreationExpression_lf_primary = 186, 
		RULE_classInstanceCreationExpression_lfno_primary = 187, RULE_typeArgumentsOrDiamond = 188, 
		RULE_fieldAccess = 189, RULE_fieldAccess_lf_primary = 190, RULE_fieldAccess_lfno_primary = 191, 
		RULE_arrayAccess = 192, RULE_arrayAccess_lf_primary = 193, RULE_arrayAccess_lfno_primary = 194, 
		RULE_methodInvocation = 195, RULE_methodInvocation_lf_primary = 196, RULE_methodInvocation_lfno_primary = 197, 
		RULE_argumentList = 198, RULE_methodReference = 199, RULE_methodReference_lf_primary = 200, 
		RULE_methodReference_lfno_primary = 201, RULE_arrayCreationExpression = 202, 
		RULE_dimExprs = 203, RULE_dimExpr = 204, RULE_constantExpression = 205, 
		RULE_expression = 206, RULE_lambdaExpression = 207, RULE_lambdaParameters = 208, 
		RULE_inferredFormalParameterList = 209, RULE_lambdaBody = 210, RULE_assignmentExpression = 211, 
		RULE_assignment = 212, RULE_leftHandSide = 213, RULE_assignmentOperator = 214, 
		RULE_conditionalExpression = 215, RULE_conditionalOrExpression = 216, 
		RULE_conditionalAndExpression = 217, RULE_inclusiveOrExpression = 218, 
		RULE_exclusiveOrExpression = 219, RULE_andExpression = 220, RULE_equalityExpression = 221, 
		RULE_relationalExpression = 222, RULE_shiftExpression = 223, RULE_additiveExpression = 224, 
		RULE_multiplicativeExpression = 225, RULE_unaryExpression = 226, RULE_preIncrementExpression = 227, 
		RULE_preDecrementExpression = 228, RULE_unaryExpressionNotPlusMinus = 229, 
		RULE_postfixExpression = 230, RULE_postIncrementExpression = 231, RULE_postIncrementExpression_lf_postfixExpression = 232, 
		RULE_postDecrementExpression = 233, RULE_postDecrementExpression_lf_postfixExpression = 234, 
		RULE_castExpression = 235;
	public static readonly string[] ruleNames = {
		"literal", "primitiveType", "numericType", "integralType", "floatingPointType", 
		"referenceType", "classOrInterfaceType", "classType", "classType_lf_classOrInterfaceType", 
		"classType_lfno_classOrInterfaceType", "interfaceType", "interfaceType_lf_classOrInterfaceType", 
		"interfaceType_lfno_classOrInterfaceType", "typeVariable", "arrayType", 
		"dims", "typeParameter", "typeParameterModifier", "typeBound", "additionalBound", 
		"typeArguments", "typeArgumentList", "typeArgument", "wildcard", "wildcardBounds", 
		"packageName", "typeName", "packageOrTypeName", "expressionName", "methodName", 
		"ambiguousName", "compilationUnit", "packageDeclaration", "packageModifier", 
		"importDeclaration", "singleTypeImportDeclaration", "typeImportOnDemandDeclaration", 
		"singleStaticImportDeclaration", "staticImportOnDemandDeclaration", "typeDeclaration", 
		"classDeclaration", "normalClassDeclaration", "classModifier", "typeParameters", 
		"typeParameterList", "superclass", "superinterfaces", "interfaceTypeList", 
		"classBody", "classBodyDeclaration", "classMemberDeclaration", "fieldDeclaration", 
		"fieldModifier", "variableDeclaratorList", "variableDeclarator", "variableDeclaratorId", 
		"variableInitializer", "unannType", "unannPrimitiveType", "unannReferenceType", 
		"unannClassOrInterfaceType", "unannClassType", "unannClassType_lf_unannClassOrInterfaceType", 
		"unannClassType_lfno_unannClassOrInterfaceType", "unannInterfaceType", 
		"unannInterfaceType_lf_unannClassOrInterfaceType", "unannInterfaceType_lfno_unannClassOrInterfaceType", 
		"unannTypeVariable", "unannArrayType", "methodDeclaration", "methodModifier", 
		"methodHeader", "result", "methodDeclarator", "formalParameterList", "formalParameters", 
		"formalParameter", "variableModifier", "lastFormalParameter", "receiverParameter", 
		"throws_", "exceptionTypeList", "exceptionType", "methodBody", "instanceInitializer", 
		"staticInitializer", "constructorDeclaration", "constructorModifier", 
		"constructorDeclarator", "simpleTypeName", "constructorBody", "explicitConstructorInvocation", 
		"enumDeclaration", "enumBody", "enumConstantList", "enumConstant", "enumConstantModifier", 
		"enumBodyDeclarations", "interfaceDeclaration", "normalInterfaceDeclaration", 
		"interfaceModifier", "extendsInterfaces", "interfaceBody", "interfaceMemberDeclaration", 
		"constantDeclaration", "constantModifier", "interfaceMethodDeclaration", 
		"interfaceMethodModifier", "annotationTypeDeclaration", "annotationTypeBody", 
		"annotationTypeMemberDeclaration", "annotationTypeElementDeclaration", 
		"annotationTypeElementModifier", "defaultValue", "annotation", "normalAnnotation", 
		"elementValuePairList", "elementValuePair", "elementValue", "elementValueArrayInitializer", 
		"elementValueList", "markerAnnotation", "singleElementAnnotation", "arrayInitializer", 
		"variableInitializerList", "block", "blockStatements", "blockStatement", 
		"localVariableDeclarationStatement", "localVariableDeclaration", "statement", 
		"statementNoShortIf", "statementWithoutTrailingSubstatement", "emptyStatement_", 
		"labeledStatement", "labeledStatementNoShortIf", "expressionStatement", 
		"statementExpression", "ifThenStatement", "ifThenElseStatement", "ifThenElseStatementNoShortIf", 
		"assertStatement", "switchStatement", "switchBlock", "switchBlockStatementGroup", 
		"switchLabels", "switchLabel", "enumConstantName", "whileStatement", "whileStatementNoShortIf", 
		"doStatement", "forStatement", "forStatementNoShortIf", "basicForStatement", 
		"basicForStatementNoShortIf", "forInit", "forUpdate", "statementExpressionList", 
		"enhancedForStatement", "enhancedForStatementNoShortIf", "breakStatement", 
		"continueStatement", "returnStatement", "throwStatement", "synchronizedStatement", 
		"tryStatement", "catches", "catchClause", "catchFormalParameter", "catchType", 
		"finally_", "tryWithResourcesStatement", "resourceSpecification", "resourceList", 
		"resource", "primary", "primaryNoNewArray", "primaryNoNewArray_lf_arrayAccess", 
		"primaryNoNewArray_lfno_arrayAccess", "primaryNoNewArray_lf_primary", 
		"primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary", "primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary", 
		"primaryNoNewArray_lfno_primary", "primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary", 
		"primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary", "classInstanceCreationExpression", 
		"classInstanceCreationExpression_lf_primary", "classInstanceCreationExpression_lfno_primary", 
		"typeArgumentsOrDiamond", "fieldAccess", "fieldAccess_lf_primary", "fieldAccess_lfno_primary", 
		"arrayAccess", "arrayAccess_lf_primary", "arrayAccess_lfno_primary", "methodInvocation", 
		"methodInvocation_lf_primary", "methodInvocation_lfno_primary", "argumentList", 
		"methodReference", "methodReference_lf_primary", "methodReference_lfno_primary", 
		"arrayCreationExpression", "dimExprs", "dimExpr", "constantExpression", 
		"expression", "lambdaExpression", "lambdaParameters", "inferredFormalParameterList", 
		"lambdaBody", "assignmentExpression", "assignment", "leftHandSide", "assignmentOperator", 
		"conditionalExpression", "conditionalOrExpression", "conditionalAndExpression", 
		"inclusiveOrExpression", "exclusiveOrExpression", "andExpression", "equalityExpression", 
		"relationalExpression", "shiftExpression", "additiveExpression", "multiplicativeExpression", 
		"unaryExpression", "preIncrementExpression", "preDecrementExpression", 
		"unaryExpressionNotPlusMinus", "postfixExpression", "postIncrementExpression", 
		"postIncrementExpression_lf_postfixExpression", "postDecrementExpression", 
		"postDecrementExpression_lf_postfixExpression", "castExpression"
	};

	private static readonly string[] _LiteralNames = {
		null, "'abstract'", "'assert'", "'boolean'", "'break'", "'byte'", "'case'", 
		"'catch'", "'char'", "'class'", "'const'", "'continue'", "'default'", 
		"'do'", "'double'", "'else'", "'enum'", "'extends'", "'final'", "'finally'", 
		"'float'", "'for'", "'if'", "'goto'", "'implements'", "'import'", "'instanceof'", 
		"'int'", "'interface'", "'long'", "'native'", "'new'", "'package'", "'private'", 
		"'protected'", "'public'", "'return'", "'short'", "'static'", "'strictfp'", 
		"'super'", "'switch'", "'synchronized'", "'this'", "'throw'", "'throws'", 
		"'transient'", "'try'", "'void'", "'volatile'", "'while'", null, null, 
		null, null, null, "'null'", "'('", "')'", "'{'", "'}'", "'['", "']'", 
		"';'", "','", "'.'", "'='", "'>'", "'<'", "'!'", "'~'", "'?'", "':'", 
		"'=='", "'<='", "'>='", "'!='", "'&&'", "'||'", "'++'", "'--'", "'+'", 
		"'-'", "'*'", "'/'", "'&'", "'|'", "'^'", "'%'", "'->'", "'::'", "'+='", 
		"'-='", "'*='", "'/='", "'&='", "'|='", "'^='", "'%='", "'<<='", "'>>='", 
		"'>>>='", null, "'@'", "'...'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "ABSTRACT", "ASSERT", "BOOLEAN", "BREAK", "BYTE", "CASE", "CATCH", 
		"CHAR", "CLASS", "CONST", "CONTINUE", "DEFAULT", "DO", "DOUBLE", "ELSE", 
		"ENUM", "EXTENDS", "FINAL", "FINALLY", "FLOAT", "FOR", "IF", "GOTO", "IMPLEMENTS", 
		"IMPORT", "INSTANCEOF", "INT", "INTERFACE", "LONG", "NATIVE", "NEW", "PACKAGE", 
		"PRIVATE", "PROTECTED", "PUBLIC", "RETURN", "SHORT", "STATIC", "STRICTFP", 
		"SUPER", "SWITCH", "SYNCHRONIZED", "THIS", "THROW", "THROWS", "TRANSIENT", 
		"TRY", "VOID", "VOLATILE", "WHILE", "IntegerLiteral", "FloatingPointLiteral", 
		"BooleanLiteral", "CharacterLiteral", "StringLiteral", "NullLiteral", 
		"LPAREN", "RPAREN", "LBRACE", "RBRACE", "LBRACK", "RBRACK", "SEMI", "COMMA", 
		"DOT", "ASSIGN", "GT", "LT", "BANG", "TILDE", "QUESTION", "COLON", "EQUAL", 
		"LE", "GE", "NOTEQUAL", "AND", "OR", "INC", "DEC", "ADD", "SUB", "MUL", 
		"DIV", "BITAND", "BITOR", "CARET", "MOD", "ARROW", "COLONCOLON", "ADD_ASSIGN", 
		"SUB_ASSIGN", "MUL_ASSIGN", "DIV_ASSIGN", "AND_ASSIGN", "OR_ASSIGN", "XOR_ASSIGN", 
		"MOD_ASSIGN", "LSHIFT_ASSIGN", "RSHIFT_ASSIGN", "URSHIFT_ASSIGN", "Identifier", 
		"AT", "ELLIPSIS", "WS", "COMMENT", "LINE_COMMENT"
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

	public override string GrammarFileName { get { return "Java8Parser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static Java8Parser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public Java8Parser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public Java8Parser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class LiteralContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IntegerLiteral() { return GetToken(Java8Parser.IntegerLiteral, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FloatingPointLiteral() { return GetToken(Java8Parser.FloatingPointLiteral, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BooleanLiteral() { return GetToken(Java8Parser.BooleanLiteral, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CharacterLiteral() { return GetToken(Java8Parser.CharacterLiteral, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode StringLiteral() { return GetToken(Java8Parser.StringLiteral, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NullLiteral() { return GetToken(Java8Parser.NullLiteral, 0); }
		public LiteralContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_literal; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterLiteral(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitLiteral(this);
		}
	}

	[RuleVersion(0)]
	public LiteralContext literal() {
		LiteralContext _localctx = new LiteralContext(Context, State);
		EnterRule(_localctx, 0, RULE_literal);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 472;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral))) != 0)) ) {
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
		[System.Diagnostics.DebuggerNonUserCode] public NumericTypeContext numericType() {
			return GetRuleContext<NumericTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext[] annotation() {
			return GetRuleContexts<AnnotationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation(int i) {
			return GetRuleContext<AnnotationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BOOLEAN() { return GetToken(Java8Parser.BOOLEAN, 0); }
		public PrimitiveTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primitiveType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPrimitiveType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPrimitiveType(this);
		}
	}

	[RuleVersion(0)]
	public PrimitiveTypeContext primitiveType() {
		PrimitiveTypeContext _localctx = new PrimitiveTypeContext(Context, State);
		EnterRule(_localctx, 2, RULE_primitiveType);
		int _la;
		try {
			State = 488;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 477;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==AT) {
					{
					{
					State = 474;
					annotation();
					}
					}
					State = 479;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 480;
				numericType();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 484;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==AT) {
					{
					{
					State = 481;
					annotation();
					}
					}
					State = 486;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 487;
				Match(BOOLEAN);
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

	public partial class NumericTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IntegralTypeContext integralType() {
			return GetRuleContext<IntegralTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FloatingPointTypeContext floatingPointType() {
			return GetRuleContext<FloatingPointTypeContext>(0);
		}
		public NumericTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_numericType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterNumericType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitNumericType(this);
		}
	}

	[RuleVersion(0)]
	public NumericTypeContext numericType() {
		NumericTypeContext _localctx = new NumericTypeContext(Context, State);
		EnterRule(_localctx, 4, RULE_numericType);
		try {
			State = 492;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case BYTE:
			case CHAR:
			case INT:
			case LONG:
			case SHORT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 490;
				integralType();
				}
				break;
			case DOUBLE:
			case FLOAT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 491;
				floatingPointType();
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

	public partial class IntegralTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BYTE() { return GetToken(Java8Parser.BYTE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SHORT() { return GetToken(Java8Parser.SHORT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT() { return GetToken(Java8Parser.INT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LONG() { return GetToken(Java8Parser.LONG, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CHAR() { return GetToken(Java8Parser.CHAR, 0); }
		public IntegralTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_integralType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterIntegralType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitIntegralType(this);
		}
	}

	[RuleVersion(0)]
	public IntegralTypeContext integralType() {
		IntegralTypeContext _localctx = new IntegralTypeContext(Context, State);
		EnterRule(_localctx, 6, RULE_integralType);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 494;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BYTE) | (1L << CHAR) | (1L << INT) | (1L << LONG) | (1L << SHORT))) != 0)) ) {
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

	public partial class FloatingPointTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FLOAT() { return GetToken(Java8Parser.FLOAT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOUBLE() { return GetToken(Java8Parser.DOUBLE, 0); }
		public FloatingPointTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_floatingPointType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterFloatingPointType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitFloatingPointType(this);
		}
	}

	[RuleVersion(0)]
	public FloatingPointTypeContext floatingPointType() {
		FloatingPointTypeContext _localctx = new FloatingPointTypeContext(Context, State);
		EnterRule(_localctx, 8, RULE_floatingPointType);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 496;
			_la = TokenStream.LA(1);
			if ( !(_la==DOUBLE || _la==FLOAT) ) {
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

	public partial class ReferenceTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ClassOrInterfaceTypeContext classOrInterfaceType() {
			return GetRuleContext<ClassOrInterfaceTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeVariableContext typeVariable() {
			return GetRuleContext<TypeVariableContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArrayTypeContext arrayType() {
			return GetRuleContext<ArrayTypeContext>(0);
		}
		public ReferenceTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_referenceType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterReferenceType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitReferenceType(this);
		}
	}

	[RuleVersion(0)]
	public ReferenceTypeContext referenceType() {
		ReferenceTypeContext _localctx = new ReferenceTypeContext(Context, State);
		EnterRule(_localctx, 10, RULE_referenceType);
		try {
			State = 501;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,4,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 498;
				classOrInterfaceType();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 499;
				typeVariable();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 500;
				arrayType();
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

	public partial class ClassOrInterfaceTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ClassType_lfno_classOrInterfaceTypeContext classType_lfno_classOrInterfaceType() {
			return GetRuleContext<ClassType_lfno_classOrInterfaceTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceType_lfno_classOrInterfaceTypeContext interfaceType_lfno_classOrInterfaceType() {
			return GetRuleContext<InterfaceType_lfno_classOrInterfaceTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassType_lf_classOrInterfaceTypeContext[] classType_lf_classOrInterfaceType() {
			return GetRuleContexts<ClassType_lf_classOrInterfaceTypeContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassType_lf_classOrInterfaceTypeContext classType_lf_classOrInterfaceType(int i) {
			return GetRuleContext<ClassType_lf_classOrInterfaceTypeContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceType_lf_classOrInterfaceTypeContext[] interfaceType_lf_classOrInterfaceType() {
			return GetRuleContexts<InterfaceType_lf_classOrInterfaceTypeContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceType_lf_classOrInterfaceTypeContext interfaceType_lf_classOrInterfaceType(int i) {
			return GetRuleContext<InterfaceType_lf_classOrInterfaceTypeContext>(i);
		}
		public ClassOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classOrInterfaceType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterClassOrInterfaceType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitClassOrInterfaceType(this);
		}
	}

	[RuleVersion(0)]
	public ClassOrInterfaceTypeContext classOrInterfaceType() {
		ClassOrInterfaceTypeContext _localctx = new ClassOrInterfaceTypeContext(Context, State);
		EnterRule(_localctx, 12, RULE_classOrInterfaceType);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 505;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,5,Context) ) {
			case 1:
				{
				State = 503;
				classType_lfno_classOrInterfaceType();
				}
				break;
			case 2:
				{
				State = 504;
				interfaceType_lfno_classOrInterfaceType();
				}
				break;
			}
			State = 511;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					State = 509;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,6,Context) ) {
					case 1:
						{
						State = 507;
						classType_lf_classOrInterfaceType();
						}
						break;
					case 2:
						{
						State = 508;
						interfaceType_lf_classOrInterfaceType();
						}
						break;
					}
					} 
				}
				State = 513;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
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

	public partial class ClassTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext[] annotation() {
			return GetRuleContexts<AnnotationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation(int i) {
			return GetRuleContext<AnnotationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsContext typeArguments() {
			return GetRuleContext<TypeArgumentsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassOrInterfaceTypeContext classOrInterfaceType() {
			return GetRuleContext<ClassOrInterfaceTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		public ClassTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterClassType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitClassType(this);
		}
	}

	[RuleVersion(0)]
	public ClassTypeContext classType() {
		ClassTypeContext _localctx = new ClassTypeContext(Context, State);
		EnterRule(_localctx, 14, RULE_classType);
		int _la;
		try {
			State = 536;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,12,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 517;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==AT) {
					{
					{
					State = 514;
					annotation();
					}
					}
					State = 519;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 520;
				Match(Identifier);
				State = 522;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 521;
					typeArguments();
					}
				}

				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 524;
				classOrInterfaceType();
				State = 525;
				Match(DOT);
				State = 529;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==AT) {
					{
					{
					State = 526;
					annotation();
					}
					}
					State = 531;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 532;
				Match(Identifier);
				State = 534;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 533;
					typeArguments();
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

	public partial class ClassType_lf_classOrInterfaceTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext[] annotation() {
			return GetRuleContexts<AnnotationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation(int i) {
			return GetRuleContext<AnnotationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsContext typeArguments() {
			return GetRuleContext<TypeArgumentsContext>(0);
		}
		public ClassType_lf_classOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classType_lf_classOrInterfaceType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterClassType_lf_classOrInterfaceType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitClassType_lf_classOrInterfaceType(this);
		}
	}

	[RuleVersion(0)]
	public ClassType_lf_classOrInterfaceTypeContext classType_lf_classOrInterfaceType() {
		ClassType_lf_classOrInterfaceTypeContext _localctx = new ClassType_lf_classOrInterfaceTypeContext(Context, State);
		EnterRule(_localctx, 16, RULE_classType_lf_classOrInterfaceType);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 538;
			Match(DOT);
			State = 542;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==AT) {
				{
				{
				State = 539;
				annotation();
				}
				}
				State = 544;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 545;
			Match(Identifier);
			State = 547;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,14,Context) ) {
			case 1:
				{
				State = 546;
				typeArguments();
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

	public partial class ClassType_lfno_classOrInterfaceTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext[] annotation() {
			return GetRuleContexts<AnnotationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation(int i) {
			return GetRuleContext<AnnotationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsContext typeArguments() {
			return GetRuleContext<TypeArgumentsContext>(0);
		}
		public ClassType_lfno_classOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classType_lfno_classOrInterfaceType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterClassType_lfno_classOrInterfaceType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitClassType_lfno_classOrInterfaceType(this);
		}
	}

	[RuleVersion(0)]
	public ClassType_lfno_classOrInterfaceTypeContext classType_lfno_classOrInterfaceType() {
		ClassType_lfno_classOrInterfaceTypeContext _localctx = new ClassType_lfno_classOrInterfaceTypeContext(Context, State);
		EnterRule(_localctx, 18, RULE_classType_lfno_classOrInterfaceType);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 552;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==AT) {
				{
				{
				State = 549;
				annotation();
				}
				}
				State = 554;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 555;
			Match(Identifier);
			State = 557;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,16,Context) ) {
			case 1:
				{
				State = 556;
				typeArguments();
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

	public partial class InterfaceTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ClassTypeContext classType() {
			return GetRuleContext<ClassTypeContext>(0);
		}
		public InterfaceTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interfaceType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterInterfaceType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitInterfaceType(this);
		}
	}

	[RuleVersion(0)]
	public InterfaceTypeContext interfaceType() {
		InterfaceTypeContext _localctx = new InterfaceTypeContext(Context, State);
		EnterRule(_localctx, 20, RULE_interfaceType);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 559;
			classType();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InterfaceType_lf_classOrInterfaceTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ClassType_lf_classOrInterfaceTypeContext classType_lf_classOrInterfaceType() {
			return GetRuleContext<ClassType_lf_classOrInterfaceTypeContext>(0);
		}
		public InterfaceType_lf_classOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interfaceType_lf_classOrInterfaceType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterInterfaceType_lf_classOrInterfaceType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitInterfaceType_lf_classOrInterfaceType(this);
		}
	}

	[RuleVersion(0)]
	public InterfaceType_lf_classOrInterfaceTypeContext interfaceType_lf_classOrInterfaceType() {
		InterfaceType_lf_classOrInterfaceTypeContext _localctx = new InterfaceType_lf_classOrInterfaceTypeContext(Context, State);
		EnterRule(_localctx, 22, RULE_interfaceType_lf_classOrInterfaceType);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 561;
			classType_lf_classOrInterfaceType();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InterfaceType_lfno_classOrInterfaceTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ClassType_lfno_classOrInterfaceTypeContext classType_lfno_classOrInterfaceType() {
			return GetRuleContext<ClassType_lfno_classOrInterfaceTypeContext>(0);
		}
		public InterfaceType_lfno_classOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interfaceType_lfno_classOrInterfaceType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterInterfaceType_lfno_classOrInterfaceType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitInterfaceType_lfno_classOrInterfaceType(this);
		}
	}

	[RuleVersion(0)]
	public InterfaceType_lfno_classOrInterfaceTypeContext interfaceType_lfno_classOrInterfaceType() {
		InterfaceType_lfno_classOrInterfaceTypeContext _localctx = new InterfaceType_lfno_classOrInterfaceTypeContext(Context, State);
		EnterRule(_localctx, 24, RULE_interfaceType_lfno_classOrInterfaceType);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 563;
			classType_lfno_classOrInterfaceType();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TypeVariableContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext[] annotation() {
			return GetRuleContexts<AnnotationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation(int i) {
			return GetRuleContext<AnnotationContext>(i);
		}
		public TypeVariableContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeVariable; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterTypeVariable(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitTypeVariable(this);
		}
	}

	[RuleVersion(0)]
	public TypeVariableContext typeVariable() {
		TypeVariableContext _localctx = new TypeVariableContext(Context, State);
		EnterRule(_localctx, 26, RULE_typeVariable);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 568;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==AT) {
				{
				{
				State = 565;
				annotation();
				}
				}
				State = 570;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 571;
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

	public partial class ArrayTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PrimitiveTypeContext primitiveType() {
			return GetRuleContext<PrimitiveTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DimsContext dims() {
			return GetRuleContext<DimsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassOrInterfaceTypeContext classOrInterfaceType() {
			return GetRuleContext<ClassOrInterfaceTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeVariableContext typeVariable() {
			return GetRuleContext<TypeVariableContext>(0);
		}
		public ArrayTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_arrayType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterArrayType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitArrayType(this);
		}
	}

	[RuleVersion(0)]
	public ArrayTypeContext arrayType() {
		ArrayTypeContext _localctx = new ArrayTypeContext(Context, State);
		EnterRule(_localctx, 28, RULE_arrayType);
		try {
			State = 582;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,18,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 573;
				primitiveType();
				State = 574;
				dims();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 576;
				classOrInterfaceType();
				State = 577;
				dims();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 579;
				typeVariable();
				State = 580;
				dims();
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

	public partial class DimsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LBRACK() { return GetTokens(Java8Parser.LBRACK); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACK(int i) {
			return GetToken(Java8Parser.LBRACK, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RBRACK() { return GetTokens(Java8Parser.RBRACK); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACK(int i) {
			return GetToken(Java8Parser.RBRACK, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext[] annotation() {
			return GetRuleContexts<AnnotationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation(int i) {
			return GetRuleContext<AnnotationContext>(i);
		}
		public DimsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dims; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterDims(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitDims(this);
		}
	}

	[RuleVersion(0)]
	public DimsContext dims() {
		DimsContext _localctx = new DimsContext(Context, State);
		EnterRule(_localctx, 30, RULE_dims);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 587;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==AT) {
				{
				{
				State = 584;
				annotation();
				}
				}
				State = 589;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 590;
			Match(LBRACK);
			State = 591;
			Match(RBRACK);
			State = 602;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,21,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 595;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==AT) {
						{
						{
						State = 592;
						annotation();
						}
						}
						State = 597;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					State = 598;
					Match(LBRACK);
					State = 599;
					Match(RBRACK);
					}
					} 
				}
				State = 604;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,21,Context);
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

	public partial class TypeParameterContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeParameterModifierContext[] typeParameterModifier() {
			return GetRuleContexts<TypeParameterModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeParameterModifierContext typeParameterModifier(int i) {
			return GetRuleContext<TypeParameterModifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeBoundContext typeBound() {
			return GetRuleContext<TypeBoundContext>(0);
		}
		public TypeParameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeParameter; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterTypeParameter(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitTypeParameter(this);
		}
	}

	[RuleVersion(0)]
	public TypeParameterContext typeParameter() {
		TypeParameterContext _localctx = new TypeParameterContext(Context, State);
		EnterRule(_localctx, 32, RULE_typeParameter);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 608;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==AT) {
				{
				{
				State = 605;
				typeParameterModifier();
				}
				}
				State = 610;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 611;
			Match(Identifier);
			State = 613;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==EXTENDS) {
				{
				State = 612;
				typeBound();
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

	public partial class TypeParameterModifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation() {
			return GetRuleContext<AnnotationContext>(0);
		}
		public TypeParameterModifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeParameterModifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterTypeParameterModifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitTypeParameterModifier(this);
		}
	}

	[RuleVersion(0)]
	public TypeParameterModifierContext typeParameterModifier() {
		TypeParameterModifierContext _localctx = new TypeParameterModifierContext(Context, State);
		EnterRule(_localctx, 34, RULE_typeParameterModifier);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 615;
			annotation();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TypeBoundContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXTENDS() { return GetToken(Java8Parser.EXTENDS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeVariableContext typeVariable() {
			return GetRuleContext<TypeVariableContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassOrInterfaceTypeContext classOrInterfaceType() {
			return GetRuleContext<ClassOrInterfaceTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AdditionalBoundContext[] additionalBound() {
			return GetRuleContexts<AdditionalBoundContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AdditionalBoundContext additionalBound(int i) {
			return GetRuleContext<AdditionalBoundContext>(i);
		}
		public TypeBoundContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeBound; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterTypeBound(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitTypeBound(this);
		}
	}

	[RuleVersion(0)]
	public TypeBoundContext typeBound() {
		TypeBoundContext _localctx = new TypeBoundContext(Context, State);
		EnterRule(_localctx, 36, RULE_typeBound);
		int _la;
		try {
			State = 627;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,25,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 617;
				Match(EXTENDS);
				State = 618;
				typeVariable();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 619;
				Match(EXTENDS);
				State = 620;
				classOrInterfaceType();
				State = 624;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==BITAND) {
					{
					{
					State = 621;
					additionalBound();
					}
					}
					State = 626;
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

	public partial class AdditionalBoundContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BITAND() { return GetToken(Java8Parser.BITAND, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceTypeContext interfaceType() {
			return GetRuleContext<InterfaceTypeContext>(0);
		}
		public AdditionalBoundContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_additionalBound; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterAdditionalBound(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitAdditionalBound(this);
		}
	}

	[RuleVersion(0)]
	public AdditionalBoundContext additionalBound() {
		AdditionalBoundContext _localctx = new AdditionalBoundContext(Context, State);
		EnterRule(_localctx, 38, RULE_additionalBound);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 629;
			Match(BITAND);
			State = 630;
			interfaceType();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TypeArgumentsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LT() { return GetToken(Java8Parser.LT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentListContext typeArgumentList() {
			return GetRuleContext<TypeArgumentListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT() { return GetToken(Java8Parser.GT, 0); }
		public TypeArgumentsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeArguments; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterTypeArguments(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitTypeArguments(this);
		}
	}

	[RuleVersion(0)]
	public TypeArgumentsContext typeArguments() {
		TypeArgumentsContext _localctx = new TypeArgumentsContext(Context, State);
		EnterRule(_localctx, 40, RULE_typeArguments);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 632;
			Match(LT);
			State = 633;
			typeArgumentList();
			State = 634;
			Match(GT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TypeArgumentListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentContext[] typeArgument() {
			return GetRuleContexts<TypeArgumentContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentContext typeArgument(int i) {
			return GetRuleContext<TypeArgumentContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java8Parser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(Java8Parser.COMMA, i);
		}
		public TypeArgumentListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeArgumentList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterTypeArgumentList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitTypeArgumentList(this);
		}
	}

	[RuleVersion(0)]
	public TypeArgumentListContext typeArgumentList() {
		TypeArgumentListContext _localctx = new TypeArgumentListContext(Context, State);
		EnterRule(_localctx, 42, RULE_typeArgumentList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 636;
			typeArgument();
			State = 641;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 637;
				Match(COMMA);
				State = 638;
				typeArgument();
				}
				}
				State = 643;
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

	public partial class TypeArgumentContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ReferenceTypeContext referenceType() {
			return GetRuleContext<ReferenceTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public WildcardContext wildcard() {
			return GetRuleContext<WildcardContext>(0);
		}
		public TypeArgumentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeArgument; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterTypeArgument(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitTypeArgument(this);
		}
	}

	[RuleVersion(0)]
	public TypeArgumentContext typeArgument() {
		TypeArgumentContext _localctx = new TypeArgumentContext(Context, State);
		EnterRule(_localctx, 44, RULE_typeArgument);
		try {
			State = 646;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,27,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 644;
				referenceType();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 645;
				wildcard();
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

	public partial class WildcardContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode QUESTION() { return GetToken(Java8Parser.QUESTION, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext[] annotation() {
			return GetRuleContexts<AnnotationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation(int i) {
			return GetRuleContext<AnnotationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public WildcardBoundsContext wildcardBounds() {
			return GetRuleContext<WildcardBoundsContext>(0);
		}
		public WildcardContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_wildcard; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterWildcard(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitWildcard(this);
		}
	}

	[RuleVersion(0)]
	public WildcardContext wildcard() {
		WildcardContext _localctx = new WildcardContext(Context, State);
		EnterRule(_localctx, 46, RULE_wildcard);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 651;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==AT) {
				{
				{
				State = 648;
				annotation();
				}
				}
				State = 653;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 654;
			Match(QUESTION);
			State = 656;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==EXTENDS || _la==SUPER) {
				{
				State = 655;
				wildcardBounds();
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

	public partial class WildcardBoundsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXTENDS() { return GetToken(Java8Parser.EXTENDS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ReferenceTypeContext referenceType() {
			return GetRuleContext<ReferenceTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUPER() { return GetToken(Java8Parser.SUPER, 0); }
		public WildcardBoundsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_wildcardBounds; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterWildcardBounds(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitWildcardBounds(this);
		}
	}

	[RuleVersion(0)]
	public WildcardBoundsContext wildcardBounds() {
		WildcardBoundsContext _localctx = new WildcardBoundsContext(Context, State);
		EnterRule(_localctx, 48, RULE_wildcardBounds);
		try {
			State = 662;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case EXTENDS:
				EnterOuterAlt(_localctx, 1);
				{
				State = 658;
				Match(EXTENDS);
				State = 659;
				referenceType();
				}
				break;
			case SUPER:
				EnterOuterAlt(_localctx, 2);
				{
				State = 660;
				Match(SUPER);
				State = 661;
				referenceType();
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

	public partial class PackageNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public PackageNameContext packageName() {
			return GetRuleContext<PackageNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		public PackageNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_packageName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPackageName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPackageName(this);
		}
	}

	[RuleVersion(0)]
	public PackageNameContext packageName() {
		return packageName(0);
	}

	private PackageNameContext packageName(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		PackageNameContext _localctx = new PackageNameContext(Context, _parentState);
		PackageNameContext _prevctx = _localctx;
		int _startState = 50;
		EnterRecursionRule(_localctx, 50, RULE_packageName, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 665;
			Match(Identifier);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 672;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,31,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new PackageNameContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_packageName);
					State = 667;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 668;
					Match(DOT);
					State = 669;
					Match(Identifier);
					}
					} 
				}
				State = 674;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,31,Context);
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

	public partial class TypeNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public PackageOrTypeNameContext packageOrTypeName() {
			return GetRuleContext<PackageOrTypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		public TypeNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterTypeName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitTypeName(this);
		}
	}

	[RuleVersion(0)]
	public TypeNameContext typeName() {
		TypeNameContext _localctx = new TypeNameContext(Context, State);
		EnterRule(_localctx, 52, RULE_typeName);
		try {
			State = 680;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,32,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 675;
				Match(Identifier);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 676;
				packageOrTypeName(0);
				State = 677;
				Match(DOT);
				State = 678;
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

	public partial class PackageOrTypeNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public PackageOrTypeNameContext packageOrTypeName() {
			return GetRuleContext<PackageOrTypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		public PackageOrTypeNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_packageOrTypeName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPackageOrTypeName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPackageOrTypeName(this);
		}
	}

	[RuleVersion(0)]
	public PackageOrTypeNameContext packageOrTypeName() {
		return packageOrTypeName(0);
	}

	private PackageOrTypeNameContext packageOrTypeName(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		PackageOrTypeNameContext _localctx = new PackageOrTypeNameContext(Context, _parentState);
		PackageOrTypeNameContext _prevctx = _localctx;
		int _startState = 54;
		EnterRecursionRule(_localctx, 54, RULE_packageOrTypeName, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 683;
			Match(Identifier);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 690;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,33,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new PackageOrTypeNameContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_packageOrTypeName);
					State = 685;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 686;
					Match(DOT);
					State = 687;
					Match(Identifier);
					}
					} 
				}
				State = 692;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,33,Context);
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

	public partial class ExpressionNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AmbiguousNameContext ambiguousName() {
			return GetRuleContext<AmbiguousNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		public ExpressionNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expressionName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterExpressionName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitExpressionName(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionNameContext expressionName() {
		ExpressionNameContext _localctx = new ExpressionNameContext(Context, State);
		EnterRule(_localctx, 56, RULE_expressionName);
		try {
			State = 698;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,34,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 693;
				Match(Identifier);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 694;
				ambiguousName(0);
				State = 695;
				Match(DOT);
				State = 696;
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

	public partial class MethodNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		public MethodNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterMethodName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitMethodName(this);
		}
	}

	[RuleVersion(0)]
	public MethodNameContext methodName() {
		MethodNameContext _localctx = new MethodNameContext(Context, State);
		EnterRule(_localctx, 58, RULE_methodName);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 700;
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

	public partial class AmbiguousNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AmbiguousNameContext ambiguousName() {
			return GetRuleContext<AmbiguousNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		public AmbiguousNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ambiguousName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterAmbiguousName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitAmbiguousName(this);
		}
	}

	[RuleVersion(0)]
	public AmbiguousNameContext ambiguousName() {
		return ambiguousName(0);
	}

	private AmbiguousNameContext ambiguousName(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		AmbiguousNameContext _localctx = new AmbiguousNameContext(Context, _parentState);
		AmbiguousNameContext _prevctx = _localctx;
		int _startState = 60;
		EnterRecursionRule(_localctx, 60, RULE_ambiguousName, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 703;
			Match(Identifier);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 710;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,35,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new AmbiguousNameContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_ambiguousName);
					State = 705;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 706;
					Match(DOT);
					State = 707;
					Match(Identifier);
					}
					} 
				}
				State = 712;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,35,Context);
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

	public partial class CompilationUnitContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(Java8Parser.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public PackageDeclarationContext packageDeclaration() {
			return GetRuleContext<PackageDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ImportDeclarationContext[] importDeclaration() {
			return GetRuleContexts<ImportDeclarationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ImportDeclarationContext importDeclaration(int i) {
			return GetRuleContext<ImportDeclarationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeDeclarationContext[] typeDeclaration() {
			return GetRuleContexts<TypeDeclarationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeDeclarationContext typeDeclaration(int i) {
			return GetRuleContext<TypeDeclarationContext>(i);
		}
		public CompilationUnitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compilationUnit; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterCompilationUnit(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitCompilationUnit(this);
		}
	}

	[RuleVersion(0)]
	public CompilationUnitContext compilationUnit() {
		CompilationUnitContext _localctx = new CompilationUnitContext(Context, State);
		EnterRule(_localctx, 62, RULE_compilationUnit);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 714;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,36,Context) ) {
			case 1:
				{
				State = 713;
				packageDeclaration();
				}
				break;
			}
			State = 719;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==IMPORT) {
				{
				{
				State = 716;
				importDeclaration();
				}
				}
				State = 721;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 725;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << CLASS) | (1L << ENUM) | (1L << FINAL) | (1L << INTERFACE) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << STATIC) | (1L << STRICTFP) | (1L << SEMI))) != 0) || _la==AT) {
				{
				{
				State = 722;
				typeDeclaration();
				}
				}
				State = 727;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 728;
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

	public partial class PackageDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PACKAGE() { return GetToken(Java8Parser.PACKAGE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public PackageNameContext packageName() {
			return GetRuleContext<PackageNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public PackageModifierContext[] packageModifier() {
			return GetRuleContexts<PackageModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public PackageModifierContext packageModifier(int i) {
			return GetRuleContext<PackageModifierContext>(i);
		}
		public PackageDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_packageDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPackageDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPackageDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public PackageDeclarationContext packageDeclaration() {
		PackageDeclarationContext _localctx = new PackageDeclarationContext(Context, State);
		EnterRule(_localctx, 64, RULE_packageDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 733;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==AT) {
				{
				{
				State = 730;
				packageModifier();
				}
				}
				State = 735;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 736;
			Match(PACKAGE);
			State = 737;
			packageName(0);
			State = 738;
			Match(SEMI);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PackageModifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation() {
			return GetRuleContext<AnnotationContext>(0);
		}
		public PackageModifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_packageModifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPackageModifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPackageModifier(this);
		}
	}

	[RuleVersion(0)]
	public PackageModifierContext packageModifier() {
		PackageModifierContext _localctx = new PackageModifierContext(Context, State);
		EnterRule(_localctx, 66, RULE_packageModifier);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 740;
			annotation();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ImportDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public SingleTypeImportDeclarationContext singleTypeImportDeclaration() {
			return GetRuleContext<SingleTypeImportDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeImportOnDemandDeclarationContext typeImportOnDemandDeclaration() {
			return GetRuleContext<TypeImportOnDemandDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SingleStaticImportDeclarationContext singleStaticImportDeclaration() {
			return GetRuleContext<SingleStaticImportDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StaticImportOnDemandDeclarationContext staticImportOnDemandDeclaration() {
			return GetRuleContext<StaticImportOnDemandDeclarationContext>(0);
		}
		public ImportDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_importDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterImportDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitImportDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public ImportDeclarationContext importDeclaration() {
		ImportDeclarationContext _localctx = new ImportDeclarationContext(Context, State);
		EnterRule(_localctx, 68, RULE_importDeclaration);
		try {
			State = 746;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,40,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 742;
				singleTypeImportDeclaration();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 743;
				typeImportOnDemandDeclaration();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 744;
				singleStaticImportDeclaration();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 745;
				staticImportOnDemandDeclaration();
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

	public partial class SingleTypeImportDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IMPORT() { return GetToken(Java8Parser.IMPORT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		public SingleTypeImportDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_singleTypeImportDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterSingleTypeImportDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitSingleTypeImportDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public SingleTypeImportDeclarationContext singleTypeImportDeclaration() {
		SingleTypeImportDeclarationContext _localctx = new SingleTypeImportDeclarationContext(Context, State);
		EnterRule(_localctx, 70, RULE_singleTypeImportDeclaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 748;
			Match(IMPORT);
			State = 749;
			typeName();
			State = 750;
			Match(SEMI);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TypeImportOnDemandDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IMPORT() { return GetToken(Java8Parser.IMPORT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public PackageOrTypeNameContext packageOrTypeName() {
			return GetRuleContext<PackageOrTypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MUL() { return GetToken(Java8Parser.MUL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		public TypeImportOnDemandDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeImportOnDemandDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterTypeImportOnDemandDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitTypeImportOnDemandDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public TypeImportOnDemandDeclarationContext typeImportOnDemandDeclaration() {
		TypeImportOnDemandDeclarationContext _localctx = new TypeImportOnDemandDeclarationContext(Context, State);
		EnterRule(_localctx, 72, RULE_typeImportOnDemandDeclaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 752;
			Match(IMPORT);
			State = 753;
			packageOrTypeName(0);
			State = 754;
			Match(DOT);
			State = 755;
			Match(MUL);
			State = 756;
			Match(SEMI);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SingleStaticImportDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IMPORT() { return GetToken(Java8Parser.IMPORT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java8Parser.STATIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		public SingleStaticImportDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_singleStaticImportDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterSingleStaticImportDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitSingleStaticImportDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public SingleStaticImportDeclarationContext singleStaticImportDeclaration() {
		SingleStaticImportDeclarationContext _localctx = new SingleStaticImportDeclarationContext(Context, State);
		EnterRule(_localctx, 74, RULE_singleStaticImportDeclaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 758;
			Match(IMPORT);
			State = 759;
			Match(STATIC);
			State = 760;
			typeName();
			State = 761;
			Match(DOT);
			State = 762;
			Match(Identifier);
			State = 763;
			Match(SEMI);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StaticImportOnDemandDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IMPORT() { return GetToken(Java8Parser.IMPORT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java8Parser.STATIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MUL() { return GetToken(Java8Parser.MUL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		public StaticImportOnDemandDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_staticImportOnDemandDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterStaticImportOnDemandDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitStaticImportOnDemandDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public StaticImportOnDemandDeclarationContext staticImportOnDemandDeclaration() {
		StaticImportOnDemandDeclarationContext _localctx = new StaticImportOnDemandDeclarationContext(Context, State);
		EnterRule(_localctx, 76, RULE_staticImportOnDemandDeclaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 765;
			Match(IMPORT);
			State = 766;
			Match(STATIC);
			State = 767;
			typeName();
			State = 768;
			Match(DOT);
			State = 769;
			Match(MUL);
			State = 770;
			Match(SEMI);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TypeDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ClassDeclarationContext classDeclaration() {
			return GetRuleContext<ClassDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceDeclarationContext interfaceDeclaration() {
			return GetRuleContext<InterfaceDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		public TypeDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterTypeDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitTypeDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public TypeDeclarationContext typeDeclaration() {
		TypeDeclarationContext _localctx = new TypeDeclarationContext(Context, State);
		EnterRule(_localctx, 78, RULE_typeDeclaration);
		try {
			State = 775;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,41,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 772;
				classDeclaration();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 773;
				interfaceDeclaration();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 774;
				Match(SEMI);
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

	public partial class ClassDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public NormalClassDeclarationContext normalClassDeclaration() {
			return GetRuleContext<NormalClassDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EnumDeclarationContext enumDeclaration() {
			return GetRuleContext<EnumDeclarationContext>(0);
		}
		public ClassDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterClassDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitClassDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public ClassDeclarationContext classDeclaration() {
		ClassDeclarationContext _localctx = new ClassDeclarationContext(Context, State);
		EnterRule(_localctx, 80, RULE_classDeclaration);
		try {
			State = 779;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,42,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 777;
				normalClassDeclaration();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 778;
				enumDeclaration();
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

	public partial class NormalClassDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLASS() { return GetToken(Java8Parser.CLASS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ClassBodyContext classBody() {
			return GetRuleContext<ClassBodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassModifierContext[] classModifier() {
			return GetRuleContexts<ClassModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassModifierContext classModifier(int i) {
			return GetRuleContext<ClassModifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeParametersContext typeParameters() {
			return GetRuleContext<TypeParametersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SuperclassContext superclass() {
			return GetRuleContext<SuperclassContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SuperinterfacesContext superinterfaces() {
			return GetRuleContext<SuperinterfacesContext>(0);
		}
		public NormalClassDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_normalClassDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterNormalClassDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitNormalClassDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public NormalClassDeclarationContext normalClassDeclaration() {
		NormalClassDeclarationContext _localctx = new NormalClassDeclarationContext(Context, State);
		EnterRule(_localctx, 82, RULE_normalClassDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 784;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << FINAL) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << STATIC) | (1L << STRICTFP))) != 0) || _la==AT) {
				{
				{
				State = 781;
				classModifier();
				}
				}
				State = 786;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 787;
			Match(CLASS);
			State = 788;
			Match(Identifier);
			State = 790;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LT) {
				{
				State = 789;
				typeParameters();
				}
			}

			State = 793;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==EXTENDS) {
				{
				State = 792;
				superclass();
				}
			}

			State = 796;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==IMPLEMENTS) {
				{
				State = 795;
				superinterfaces();
				}
			}

			State = 798;
			classBody();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ClassModifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation() {
			return GetRuleContext<AnnotationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLIC() { return GetToken(Java8Parser.PUBLIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PROTECTED() { return GetToken(Java8Parser.PROTECTED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRIVATE() { return GetToken(Java8Parser.PRIVATE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ABSTRACT() { return GetToken(Java8Parser.ABSTRACT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java8Parser.STATIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FINAL() { return GetToken(Java8Parser.FINAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRICTFP() { return GetToken(Java8Parser.STRICTFP, 0); }
		public ClassModifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classModifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterClassModifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitClassModifier(this);
		}
	}

	[RuleVersion(0)]
	public ClassModifierContext classModifier() {
		ClassModifierContext _localctx = new ClassModifierContext(Context, State);
		EnterRule(_localctx, 84, RULE_classModifier);
		try {
			State = 808;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case AT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 800;
				annotation();
				}
				break;
			case PUBLIC:
				EnterOuterAlt(_localctx, 2);
				{
				State = 801;
				Match(PUBLIC);
				}
				break;
			case PROTECTED:
				EnterOuterAlt(_localctx, 3);
				{
				State = 802;
				Match(PROTECTED);
				}
				break;
			case PRIVATE:
				EnterOuterAlt(_localctx, 4);
				{
				State = 803;
				Match(PRIVATE);
				}
				break;
			case ABSTRACT:
				EnterOuterAlt(_localctx, 5);
				{
				State = 804;
				Match(ABSTRACT);
				}
				break;
			case STATIC:
				EnterOuterAlt(_localctx, 6);
				{
				State = 805;
				Match(STATIC);
				}
				break;
			case FINAL:
				EnterOuterAlt(_localctx, 7);
				{
				State = 806;
				Match(FINAL);
				}
				break;
			case STRICTFP:
				EnterOuterAlt(_localctx, 8);
				{
				State = 807;
				Match(STRICTFP);
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

	public partial class TypeParametersContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LT() { return GetToken(Java8Parser.LT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeParameterListContext typeParameterList() {
			return GetRuleContext<TypeParameterListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT() { return GetToken(Java8Parser.GT, 0); }
		public TypeParametersContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeParameters; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterTypeParameters(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitTypeParameters(this);
		}
	}

	[RuleVersion(0)]
	public TypeParametersContext typeParameters() {
		TypeParametersContext _localctx = new TypeParametersContext(Context, State);
		EnterRule(_localctx, 86, RULE_typeParameters);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 810;
			Match(LT);
			State = 811;
			typeParameterList();
			State = 812;
			Match(GT);
			}
		}
		catch (RecognitionException re) {
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
		[System.Diagnostics.DebuggerNonUserCode] public TypeParameterContext[] typeParameter() {
			return GetRuleContexts<TypeParameterContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeParameterContext typeParameter(int i) {
			return GetRuleContext<TypeParameterContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java8Parser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(Java8Parser.COMMA, i);
		}
		public TypeParameterListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeParameterList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterTypeParameterList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitTypeParameterList(this);
		}
	}

	[RuleVersion(0)]
	public TypeParameterListContext typeParameterList() {
		TypeParameterListContext _localctx = new TypeParameterListContext(Context, State);
		EnterRule(_localctx, 88, RULE_typeParameterList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 814;
			typeParameter();
			State = 819;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 815;
				Match(COMMA);
				State = 816;
				typeParameter();
				}
				}
				State = 821;
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

	public partial class SuperclassContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXTENDS() { return GetToken(Java8Parser.EXTENDS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ClassTypeContext classType() {
			return GetRuleContext<ClassTypeContext>(0);
		}
		public SuperclassContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_superclass; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterSuperclass(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitSuperclass(this);
		}
	}

	[RuleVersion(0)]
	public SuperclassContext superclass() {
		SuperclassContext _localctx = new SuperclassContext(Context, State);
		EnterRule(_localctx, 90, RULE_superclass);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 822;
			Match(EXTENDS);
			State = 823;
			classType();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SuperinterfacesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IMPLEMENTS() { return GetToken(Java8Parser.IMPLEMENTS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceTypeListContext interfaceTypeList() {
			return GetRuleContext<InterfaceTypeListContext>(0);
		}
		public SuperinterfacesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_superinterfaces; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterSuperinterfaces(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitSuperinterfaces(this);
		}
	}

	[RuleVersion(0)]
	public SuperinterfacesContext superinterfaces() {
		SuperinterfacesContext _localctx = new SuperinterfacesContext(Context, State);
		EnterRule(_localctx, 92, RULE_superinterfaces);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 825;
			Match(IMPLEMENTS);
			State = 826;
			interfaceTypeList();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InterfaceTypeListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceTypeContext[] interfaceType() {
			return GetRuleContexts<InterfaceTypeContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceTypeContext interfaceType(int i) {
			return GetRuleContext<InterfaceTypeContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java8Parser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(Java8Parser.COMMA, i);
		}
		public InterfaceTypeListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interfaceTypeList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterInterfaceTypeList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitInterfaceTypeList(this);
		}
	}

	[RuleVersion(0)]
	public InterfaceTypeListContext interfaceTypeList() {
		InterfaceTypeListContext _localctx = new InterfaceTypeListContext(Context, State);
		EnterRule(_localctx, 94, RULE_interfaceTypeList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 828;
			interfaceType();
			State = 833;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 829;
				Match(COMMA);
				State = 830;
				interfaceType();
				}
				}
				State = 835;
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

	public partial class ClassBodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java8Parser.LBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java8Parser.RBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ClassBodyDeclarationContext[] classBodyDeclaration() {
			return GetRuleContexts<ClassBodyDeclarationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassBodyDeclarationContext classBodyDeclaration(int i) {
			return GetRuleContext<ClassBodyDeclarationContext>(i);
		}
		public ClassBodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classBody; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterClassBody(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitClassBody(this);
		}
	}

	[RuleVersion(0)]
	public ClassBodyContext classBody() {
		ClassBodyContext _localctx = new ClassBodyContext(Context, State);
		EnterRule(_localctx, 96, RULE_classBody);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 836;
			Match(LBRACE);
			State = 840;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << CLASS) | (1L << DOUBLE) | (1L << ENUM) | (1L << FINAL) | (1L << FLOAT) | (1L << INT) | (1L << INTERFACE) | (1L << LONG) | (1L << NATIVE) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << SHORT) | (1L << STATIC) | (1L << STRICTFP) | (1L << SYNCHRONIZED) | (1L << TRANSIENT) | (1L << VOID) | (1L << VOLATILE) | (1L << LBRACE) | (1L << SEMI))) != 0) || ((((_la - 68)) & ~0x3f) == 0 && ((1L << (_la - 68)) & ((1L << (LT - 68)) | (1L << (Identifier - 68)) | (1L << (AT - 68)))) != 0)) {
				{
				{
				State = 837;
				classBodyDeclaration();
				}
				}
				State = 842;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 843;
			Match(RBRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ClassBodyDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ClassMemberDeclarationContext classMemberDeclaration() {
			return GetRuleContext<ClassMemberDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InstanceInitializerContext instanceInitializer() {
			return GetRuleContext<InstanceInitializerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StaticInitializerContext staticInitializer() {
			return GetRuleContext<StaticInitializerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConstructorDeclarationContext constructorDeclaration() {
			return GetRuleContext<ConstructorDeclarationContext>(0);
		}
		public ClassBodyDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classBodyDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterClassBodyDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitClassBodyDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public ClassBodyDeclarationContext classBodyDeclaration() {
		ClassBodyDeclarationContext _localctx = new ClassBodyDeclarationContext(Context, State);
		EnterRule(_localctx, 98, RULE_classBodyDeclaration);
		try {
			State = 849;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,51,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 845;
				classMemberDeclaration();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 846;
				instanceInitializer();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 847;
				staticInitializer();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 848;
				constructorDeclaration();
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

	public partial class ClassMemberDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public FieldDeclarationContext fieldDeclaration() {
			return GetRuleContext<FieldDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodDeclarationContext methodDeclaration() {
			return GetRuleContext<MethodDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassDeclarationContext classDeclaration() {
			return GetRuleContext<ClassDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceDeclarationContext interfaceDeclaration() {
			return GetRuleContext<InterfaceDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		public ClassMemberDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classMemberDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterClassMemberDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitClassMemberDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public ClassMemberDeclarationContext classMemberDeclaration() {
		ClassMemberDeclarationContext _localctx = new ClassMemberDeclarationContext(Context, State);
		EnterRule(_localctx, 100, RULE_classMemberDeclaration);
		try {
			State = 856;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,52,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 851;
				fieldDeclaration();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 852;
				methodDeclaration();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 853;
				classDeclaration();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 854;
				interfaceDeclaration();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 855;
				Match(SEMI);
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

	public partial class FieldDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnannTypeContext unannType() {
			return GetRuleContext<UnannTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableDeclaratorListContext variableDeclaratorList() {
			return GetRuleContext<VariableDeclaratorListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public FieldModifierContext[] fieldModifier() {
			return GetRuleContexts<FieldModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public FieldModifierContext fieldModifier(int i) {
			return GetRuleContext<FieldModifierContext>(i);
		}
		public FieldDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fieldDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterFieldDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitFieldDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public FieldDeclarationContext fieldDeclaration() {
		FieldDeclarationContext _localctx = new FieldDeclarationContext(Context, State);
		EnterRule(_localctx, 102, RULE_fieldDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 861;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << FINAL) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << STATIC) | (1L << TRANSIENT) | (1L << VOLATILE))) != 0) || _la==AT) {
				{
				{
				State = 858;
				fieldModifier();
				}
				}
				State = 863;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 864;
			unannType();
			State = 865;
			variableDeclaratorList();
			State = 866;
			Match(SEMI);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FieldModifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation() {
			return GetRuleContext<AnnotationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLIC() { return GetToken(Java8Parser.PUBLIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PROTECTED() { return GetToken(Java8Parser.PROTECTED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRIVATE() { return GetToken(Java8Parser.PRIVATE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java8Parser.STATIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FINAL() { return GetToken(Java8Parser.FINAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRANSIENT() { return GetToken(Java8Parser.TRANSIENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOLATILE() { return GetToken(Java8Parser.VOLATILE, 0); }
		public FieldModifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fieldModifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterFieldModifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitFieldModifier(this);
		}
	}

	[RuleVersion(0)]
	public FieldModifierContext fieldModifier() {
		FieldModifierContext _localctx = new FieldModifierContext(Context, State);
		EnterRule(_localctx, 104, RULE_fieldModifier);
		try {
			State = 876;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case AT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 868;
				annotation();
				}
				break;
			case PUBLIC:
				EnterOuterAlt(_localctx, 2);
				{
				State = 869;
				Match(PUBLIC);
				}
				break;
			case PROTECTED:
				EnterOuterAlt(_localctx, 3);
				{
				State = 870;
				Match(PROTECTED);
				}
				break;
			case PRIVATE:
				EnterOuterAlt(_localctx, 4);
				{
				State = 871;
				Match(PRIVATE);
				}
				break;
			case STATIC:
				EnterOuterAlt(_localctx, 5);
				{
				State = 872;
				Match(STATIC);
				}
				break;
			case FINAL:
				EnterOuterAlt(_localctx, 6);
				{
				State = 873;
				Match(FINAL);
				}
				break;
			case TRANSIENT:
				EnterOuterAlt(_localctx, 7);
				{
				State = 874;
				Match(TRANSIENT);
				}
				break;
			case VOLATILE:
				EnterOuterAlt(_localctx, 8);
				{
				State = 875;
				Match(VOLATILE);
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

	public partial class VariableDeclaratorListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public VariableDeclaratorContext[] variableDeclarator() {
			return GetRuleContexts<VariableDeclaratorContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableDeclaratorContext variableDeclarator(int i) {
			return GetRuleContext<VariableDeclaratorContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java8Parser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(Java8Parser.COMMA, i);
		}
		public VariableDeclaratorListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variableDeclaratorList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterVariableDeclaratorList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitVariableDeclaratorList(this);
		}
	}

	[RuleVersion(0)]
	public VariableDeclaratorListContext variableDeclaratorList() {
		VariableDeclaratorListContext _localctx = new VariableDeclaratorListContext(Context, State);
		EnterRule(_localctx, 106, RULE_variableDeclaratorList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 878;
			variableDeclarator();
			State = 883;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 879;
				Match(COMMA);
				State = 880;
				variableDeclarator();
				}
				}
				State = 885;
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

	public partial class VariableDeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public VariableDeclaratorIdContext variableDeclaratorId() {
			return GetRuleContext<VariableDeclaratorIdContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGN() { return GetToken(Java8Parser.ASSIGN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public VariableInitializerContext variableInitializer() {
			return GetRuleContext<VariableInitializerContext>(0);
		}
		public VariableDeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variableDeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterVariableDeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitVariableDeclarator(this);
		}
	}

	[RuleVersion(0)]
	public VariableDeclaratorContext variableDeclarator() {
		VariableDeclaratorContext _localctx = new VariableDeclaratorContext(Context, State);
		EnterRule(_localctx, 108, RULE_variableDeclarator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 886;
			variableDeclaratorId();
			State = 889;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==ASSIGN) {
				{
				State = 887;
				Match(ASSIGN);
				State = 888;
				variableInitializer();
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

	public partial class VariableDeclaratorIdContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public DimsContext dims() {
			return GetRuleContext<DimsContext>(0);
		}
		public VariableDeclaratorIdContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variableDeclaratorId; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterVariableDeclaratorId(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitVariableDeclaratorId(this);
		}
	}

	[RuleVersion(0)]
	public VariableDeclaratorIdContext variableDeclaratorId() {
		VariableDeclaratorIdContext _localctx = new VariableDeclaratorIdContext(Context, State);
		EnterRule(_localctx, 110, RULE_variableDeclaratorId);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 891;
			Match(Identifier);
			State = 893;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LBRACK || _la==AT) {
				{
				State = 892;
				dims();
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

	public partial class VariableInitializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArrayInitializerContext arrayInitializer() {
			return GetRuleContext<ArrayInitializerContext>(0);
		}
		public VariableInitializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variableInitializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterVariableInitializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitVariableInitializer(this);
		}
	}

	[RuleVersion(0)]
	public VariableInitializerContext variableInitializer() {
		VariableInitializerContext _localctx = new VariableInitializerContext(Context, State);
		EnterRule(_localctx, 112, RULE_variableInitializer);
		try {
			State = 897;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case BOOLEAN:
			case BYTE:
			case CHAR:
			case DOUBLE:
			case FLOAT:
			case INT:
			case LONG:
			case NEW:
			case SHORT:
			case SUPER:
			case THIS:
			case VOID:
			case IntegerLiteral:
			case FloatingPointLiteral:
			case BooleanLiteral:
			case CharacterLiteral:
			case StringLiteral:
			case NullLiteral:
			case LPAREN:
			case BANG:
			case TILDE:
			case INC:
			case DEC:
			case ADD:
			case SUB:
			case Identifier:
			case AT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 895;
				expression();
				}
				break;
			case LBRACE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 896;
				arrayInitializer();
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

	public partial class UnannTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnannPrimitiveTypeContext unannPrimitiveType() {
			return GetRuleContext<UnannPrimitiveTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnannReferenceTypeContext unannReferenceType() {
			return GetRuleContext<UnannReferenceTypeContext>(0);
		}
		public UnannTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unannType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterUnannType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitUnannType(this);
		}
	}

	[RuleVersion(0)]
	public UnannTypeContext unannType() {
		UnannTypeContext _localctx = new UnannTypeContext(Context, State);
		EnterRule(_localctx, 114, RULE_unannType);
		try {
			State = 901;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,59,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 899;
				unannPrimitiveType();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 900;
				unannReferenceType();
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

	public partial class UnannPrimitiveTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public NumericTypeContext numericType() {
			return GetRuleContext<NumericTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BOOLEAN() { return GetToken(Java8Parser.BOOLEAN, 0); }
		public UnannPrimitiveTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unannPrimitiveType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterUnannPrimitiveType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitUnannPrimitiveType(this);
		}
	}

	[RuleVersion(0)]
	public UnannPrimitiveTypeContext unannPrimitiveType() {
		UnannPrimitiveTypeContext _localctx = new UnannPrimitiveTypeContext(Context, State);
		EnterRule(_localctx, 116, RULE_unannPrimitiveType);
		try {
			State = 905;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case BYTE:
			case CHAR:
			case DOUBLE:
			case FLOAT:
			case INT:
			case LONG:
			case SHORT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 903;
				numericType();
				}
				break;
			case BOOLEAN:
				EnterOuterAlt(_localctx, 2);
				{
				State = 904;
				Match(BOOLEAN);
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

	public partial class UnannReferenceTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnannClassOrInterfaceTypeContext unannClassOrInterfaceType() {
			return GetRuleContext<UnannClassOrInterfaceTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnannTypeVariableContext unannTypeVariable() {
			return GetRuleContext<UnannTypeVariableContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnannArrayTypeContext unannArrayType() {
			return GetRuleContext<UnannArrayTypeContext>(0);
		}
		public UnannReferenceTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unannReferenceType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterUnannReferenceType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitUnannReferenceType(this);
		}
	}

	[RuleVersion(0)]
	public UnannReferenceTypeContext unannReferenceType() {
		UnannReferenceTypeContext _localctx = new UnannReferenceTypeContext(Context, State);
		EnterRule(_localctx, 118, RULE_unannReferenceType);
		try {
			State = 910;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,61,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 907;
				unannClassOrInterfaceType();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 908;
				unannTypeVariable();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 909;
				unannArrayType();
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

	public partial class UnannClassOrInterfaceTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnannClassType_lfno_unannClassOrInterfaceTypeContext unannClassType_lfno_unannClassOrInterfaceType() {
			return GetRuleContext<UnannClassType_lfno_unannClassOrInterfaceTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext unannInterfaceType_lfno_unannClassOrInterfaceType() {
			return GetRuleContext<UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnannClassType_lf_unannClassOrInterfaceTypeContext[] unannClassType_lf_unannClassOrInterfaceType() {
			return GetRuleContexts<UnannClassType_lf_unannClassOrInterfaceTypeContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnannClassType_lf_unannClassOrInterfaceTypeContext unannClassType_lf_unannClassOrInterfaceType(int i) {
			return GetRuleContext<UnannClassType_lf_unannClassOrInterfaceTypeContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnannInterfaceType_lf_unannClassOrInterfaceTypeContext[] unannInterfaceType_lf_unannClassOrInterfaceType() {
			return GetRuleContexts<UnannInterfaceType_lf_unannClassOrInterfaceTypeContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnannInterfaceType_lf_unannClassOrInterfaceTypeContext unannInterfaceType_lf_unannClassOrInterfaceType(int i) {
			return GetRuleContext<UnannInterfaceType_lf_unannClassOrInterfaceTypeContext>(i);
		}
		public UnannClassOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unannClassOrInterfaceType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterUnannClassOrInterfaceType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitUnannClassOrInterfaceType(this);
		}
	}

	[RuleVersion(0)]
	public UnannClassOrInterfaceTypeContext unannClassOrInterfaceType() {
		UnannClassOrInterfaceTypeContext _localctx = new UnannClassOrInterfaceTypeContext(Context, State);
		EnterRule(_localctx, 120, RULE_unannClassOrInterfaceType);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 914;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,62,Context) ) {
			case 1:
				{
				State = 912;
				unannClassType_lfno_unannClassOrInterfaceType();
				}
				break;
			case 2:
				{
				State = 913;
				unannInterfaceType_lfno_unannClassOrInterfaceType();
				}
				break;
			}
			State = 920;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,64,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					State = 918;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,63,Context) ) {
					case 1:
						{
						State = 916;
						unannClassType_lf_unannClassOrInterfaceType();
						}
						break;
					case 2:
						{
						State = 917;
						unannInterfaceType_lf_unannClassOrInterfaceType();
						}
						break;
					}
					} 
				}
				State = 922;
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
			ExitRule();
		}
		return _localctx;
	}

	public partial class UnannClassTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsContext typeArguments() {
			return GetRuleContext<TypeArgumentsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnannClassOrInterfaceTypeContext unannClassOrInterfaceType() {
			return GetRuleContext<UnannClassOrInterfaceTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext[] annotation() {
			return GetRuleContexts<AnnotationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation(int i) {
			return GetRuleContext<AnnotationContext>(i);
		}
		public UnannClassTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unannClassType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterUnannClassType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitUnannClassType(this);
		}
	}

	[RuleVersion(0)]
	public UnannClassTypeContext unannClassType() {
		UnannClassTypeContext _localctx = new UnannClassTypeContext(Context, State);
		EnterRule(_localctx, 122, RULE_unannClassType);
		int _la;
		try {
			State = 939;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,68,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 923;
				Match(Identifier);
				State = 925;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 924;
					typeArguments();
					}
				}

				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 927;
				unannClassOrInterfaceType();
				State = 928;
				Match(DOT);
				State = 932;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==AT) {
					{
					{
					State = 929;
					annotation();
					}
					}
					State = 934;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 935;
				Match(Identifier);
				State = 937;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 936;
					typeArguments();
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

	public partial class UnannClassType_lf_unannClassOrInterfaceTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext[] annotation() {
			return GetRuleContexts<AnnotationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation(int i) {
			return GetRuleContext<AnnotationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsContext typeArguments() {
			return GetRuleContext<TypeArgumentsContext>(0);
		}
		public UnannClassType_lf_unannClassOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unannClassType_lf_unannClassOrInterfaceType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterUnannClassType_lf_unannClassOrInterfaceType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitUnannClassType_lf_unannClassOrInterfaceType(this);
		}
	}

	[RuleVersion(0)]
	public UnannClassType_lf_unannClassOrInterfaceTypeContext unannClassType_lf_unannClassOrInterfaceType() {
		UnannClassType_lf_unannClassOrInterfaceTypeContext _localctx = new UnannClassType_lf_unannClassOrInterfaceTypeContext(Context, State);
		EnterRule(_localctx, 124, RULE_unannClassType_lf_unannClassOrInterfaceType);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 941;
			Match(DOT);
			State = 945;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==AT) {
				{
				{
				State = 942;
				annotation();
				}
				}
				State = 947;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 948;
			Match(Identifier);
			State = 950;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LT) {
				{
				State = 949;
				typeArguments();
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

	public partial class UnannClassType_lfno_unannClassOrInterfaceTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsContext typeArguments() {
			return GetRuleContext<TypeArgumentsContext>(0);
		}
		public UnannClassType_lfno_unannClassOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unannClassType_lfno_unannClassOrInterfaceType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterUnannClassType_lfno_unannClassOrInterfaceType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitUnannClassType_lfno_unannClassOrInterfaceType(this);
		}
	}

	[RuleVersion(0)]
	public UnannClassType_lfno_unannClassOrInterfaceTypeContext unannClassType_lfno_unannClassOrInterfaceType() {
		UnannClassType_lfno_unannClassOrInterfaceTypeContext _localctx = new UnannClassType_lfno_unannClassOrInterfaceTypeContext(Context, State);
		EnterRule(_localctx, 126, RULE_unannClassType_lfno_unannClassOrInterfaceType);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 952;
			Match(Identifier);
			State = 954;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LT) {
				{
				State = 953;
				typeArguments();
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

	public partial class UnannInterfaceTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnannClassTypeContext unannClassType() {
			return GetRuleContext<UnannClassTypeContext>(0);
		}
		public UnannInterfaceTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unannInterfaceType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterUnannInterfaceType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitUnannInterfaceType(this);
		}
	}

	[RuleVersion(0)]
	public UnannInterfaceTypeContext unannInterfaceType() {
		UnannInterfaceTypeContext _localctx = new UnannInterfaceTypeContext(Context, State);
		EnterRule(_localctx, 128, RULE_unannInterfaceType);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 956;
			unannClassType();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class UnannInterfaceType_lf_unannClassOrInterfaceTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnannClassType_lf_unannClassOrInterfaceTypeContext unannClassType_lf_unannClassOrInterfaceType() {
			return GetRuleContext<UnannClassType_lf_unannClassOrInterfaceTypeContext>(0);
		}
		public UnannInterfaceType_lf_unannClassOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unannInterfaceType_lf_unannClassOrInterfaceType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterUnannInterfaceType_lf_unannClassOrInterfaceType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitUnannInterfaceType_lf_unannClassOrInterfaceType(this);
		}
	}

	[RuleVersion(0)]
	public UnannInterfaceType_lf_unannClassOrInterfaceTypeContext unannInterfaceType_lf_unannClassOrInterfaceType() {
		UnannInterfaceType_lf_unannClassOrInterfaceTypeContext _localctx = new UnannInterfaceType_lf_unannClassOrInterfaceTypeContext(Context, State);
		EnterRule(_localctx, 130, RULE_unannInterfaceType_lf_unannClassOrInterfaceType);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 958;
			unannClassType_lf_unannClassOrInterfaceType();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnannClassType_lfno_unannClassOrInterfaceTypeContext unannClassType_lfno_unannClassOrInterfaceType() {
			return GetRuleContext<UnannClassType_lfno_unannClassOrInterfaceTypeContext>(0);
		}
		public UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unannInterfaceType_lfno_unannClassOrInterfaceType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterUnannInterfaceType_lfno_unannClassOrInterfaceType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitUnannInterfaceType_lfno_unannClassOrInterfaceType(this);
		}
	}

	[RuleVersion(0)]
	public UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext unannInterfaceType_lfno_unannClassOrInterfaceType() {
		UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext _localctx = new UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext(Context, State);
		EnterRule(_localctx, 132, RULE_unannInterfaceType_lfno_unannClassOrInterfaceType);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 960;
			unannClassType_lfno_unannClassOrInterfaceType();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class UnannTypeVariableContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		public UnannTypeVariableContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unannTypeVariable; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterUnannTypeVariable(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitUnannTypeVariable(this);
		}
	}

	[RuleVersion(0)]
	public UnannTypeVariableContext unannTypeVariable() {
		UnannTypeVariableContext _localctx = new UnannTypeVariableContext(Context, State);
		EnterRule(_localctx, 134, RULE_unannTypeVariable);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 962;
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

	public partial class UnannArrayTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnannPrimitiveTypeContext unannPrimitiveType() {
			return GetRuleContext<UnannPrimitiveTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DimsContext dims() {
			return GetRuleContext<DimsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnannClassOrInterfaceTypeContext unannClassOrInterfaceType() {
			return GetRuleContext<UnannClassOrInterfaceTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnannTypeVariableContext unannTypeVariable() {
			return GetRuleContext<UnannTypeVariableContext>(0);
		}
		public UnannArrayTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unannArrayType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterUnannArrayType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitUnannArrayType(this);
		}
	}

	[RuleVersion(0)]
	public UnannArrayTypeContext unannArrayType() {
		UnannArrayTypeContext _localctx = new UnannArrayTypeContext(Context, State);
		EnterRule(_localctx, 136, RULE_unannArrayType);
		try {
			State = 973;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,72,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 964;
				unannPrimitiveType();
				State = 965;
				dims();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 967;
				unannClassOrInterfaceType();
				State = 968;
				dims();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 970;
				unannTypeVariable();
				State = 971;
				dims();
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

	public partial class MethodDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public MethodHeaderContext methodHeader() {
			return GetRuleContext<MethodHeaderContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodBodyContext methodBody() {
			return GetRuleContext<MethodBodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodModifierContext[] methodModifier() {
			return GetRuleContexts<MethodModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodModifierContext methodModifier(int i) {
			return GetRuleContext<MethodModifierContext>(i);
		}
		public MethodDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterMethodDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitMethodDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public MethodDeclarationContext methodDeclaration() {
		MethodDeclarationContext _localctx = new MethodDeclarationContext(Context, State);
		EnterRule(_localctx, 138, RULE_methodDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 978;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << FINAL) | (1L << NATIVE) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << STATIC) | (1L << STRICTFP) | (1L << SYNCHRONIZED))) != 0) || _la==AT) {
				{
				{
				State = 975;
				methodModifier();
				}
				}
				State = 980;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 981;
			methodHeader();
			State = 982;
			methodBody();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MethodModifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation() {
			return GetRuleContext<AnnotationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLIC() { return GetToken(Java8Parser.PUBLIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PROTECTED() { return GetToken(Java8Parser.PROTECTED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRIVATE() { return GetToken(Java8Parser.PRIVATE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ABSTRACT() { return GetToken(Java8Parser.ABSTRACT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java8Parser.STATIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FINAL() { return GetToken(Java8Parser.FINAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SYNCHRONIZED() { return GetToken(Java8Parser.SYNCHRONIZED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NATIVE() { return GetToken(Java8Parser.NATIVE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRICTFP() { return GetToken(Java8Parser.STRICTFP, 0); }
		public MethodModifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodModifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterMethodModifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitMethodModifier(this);
		}
	}

	[RuleVersion(0)]
	public MethodModifierContext methodModifier() {
		MethodModifierContext _localctx = new MethodModifierContext(Context, State);
		EnterRule(_localctx, 140, RULE_methodModifier);
		try {
			State = 994;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case AT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 984;
				annotation();
				}
				break;
			case PUBLIC:
				EnterOuterAlt(_localctx, 2);
				{
				State = 985;
				Match(PUBLIC);
				}
				break;
			case PROTECTED:
				EnterOuterAlt(_localctx, 3);
				{
				State = 986;
				Match(PROTECTED);
				}
				break;
			case PRIVATE:
				EnterOuterAlt(_localctx, 4);
				{
				State = 987;
				Match(PRIVATE);
				}
				break;
			case ABSTRACT:
				EnterOuterAlt(_localctx, 5);
				{
				State = 988;
				Match(ABSTRACT);
				}
				break;
			case STATIC:
				EnterOuterAlt(_localctx, 6);
				{
				State = 989;
				Match(STATIC);
				}
				break;
			case FINAL:
				EnterOuterAlt(_localctx, 7);
				{
				State = 990;
				Match(FINAL);
				}
				break;
			case SYNCHRONIZED:
				EnterOuterAlt(_localctx, 8);
				{
				State = 991;
				Match(SYNCHRONIZED);
				}
				break;
			case NATIVE:
				EnterOuterAlt(_localctx, 9);
				{
				State = 992;
				Match(NATIVE);
				}
				break;
			case STRICTFP:
				EnterOuterAlt(_localctx, 10);
				{
				State = 993;
				Match(STRICTFP);
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

	public partial class MethodHeaderContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ResultContext result() {
			return GetRuleContext<ResultContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodDeclaratorContext methodDeclarator() {
			return GetRuleContext<MethodDeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Throws_Context throws_() {
			return GetRuleContext<Throws_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeParametersContext typeParameters() {
			return GetRuleContext<TypeParametersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext[] annotation() {
			return GetRuleContexts<AnnotationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation(int i) {
			return GetRuleContext<AnnotationContext>(i);
		}
		public MethodHeaderContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodHeader; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterMethodHeader(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitMethodHeader(this);
		}
	}

	[RuleVersion(0)]
	public MethodHeaderContext methodHeader() {
		MethodHeaderContext _localctx = new MethodHeaderContext(Context, State);
		EnterRule(_localctx, 142, RULE_methodHeader);
		int _la;
		try {
			State = 1013;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case BOOLEAN:
			case BYTE:
			case CHAR:
			case DOUBLE:
			case FLOAT:
			case INT:
			case LONG:
			case SHORT:
			case VOID:
			case Identifier:
				EnterOuterAlt(_localctx, 1);
				{
				State = 996;
				result();
				State = 997;
				methodDeclarator();
				State = 999;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==THROWS) {
					{
					State = 998;
					throws_();
					}
				}

				}
				break;
			case LT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1001;
				typeParameters();
				State = 1005;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==AT) {
					{
					{
					State = 1002;
					annotation();
					}
					}
					State = 1007;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 1008;
				result();
				State = 1009;
				methodDeclarator();
				State = 1011;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==THROWS) {
					{
					State = 1010;
					throws_();
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

	public partial class ResultContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnannTypeContext unannType() {
			return GetRuleContext<UnannTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOID() { return GetToken(Java8Parser.VOID, 0); }
		public ResultContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_result; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterResult(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitResult(this);
		}
	}

	[RuleVersion(0)]
	public ResultContext result() {
		ResultContext _localctx = new ResultContext(Context, State);
		EnterRule(_localctx, 144, RULE_result);
		try {
			State = 1017;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case BOOLEAN:
			case BYTE:
			case CHAR:
			case DOUBLE:
			case FLOAT:
			case INT:
			case LONG:
			case SHORT:
			case Identifier:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1015;
				unannType();
				}
				break;
			case VOID:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1016;
				Match(VOID);
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

	public partial class MethodDeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public FormalParameterListContext formalParameterList() {
			return GetRuleContext<FormalParameterListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DimsContext dims() {
			return GetRuleContext<DimsContext>(0);
		}
		public MethodDeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodDeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterMethodDeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitMethodDeclarator(this);
		}
	}

	[RuleVersion(0)]
	public MethodDeclaratorContext methodDeclarator() {
		MethodDeclaratorContext _localctx = new MethodDeclaratorContext(Context, State);
		EnterRule(_localctx, 146, RULE_methodDeclarator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1019;
			Match(Identifier);
			State = 1020;
			Match(LPAREN);
			State = 1022;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FINAL) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << SHORT))) != 0) || _la==Identifier || _la==AT) {
				{
				State = 1021;
				formalParameterList();
				}
			}

			State = 1024;
			Match(RPAREN);
			State = 1026;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LBRACK || _la==AT) {
				{
				State = 1025;
				dims();
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

	public partial class FormalParameterListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ReceiverParameterContext receiverParameter() {
			return GetRuleContext<ReceiverParameterContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FormalParametersContext formalParameters() {
			return GetRuleContext<FormalParametersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(Java8Parser.COMMA, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public LastFormalParameterContext lastFormalParameter() {
			return GetRuleContext<LastFormalParameterContext>(0);
		}
		public FormalParameterListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_formalParameterList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterFormalParameterList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitFormalParameterList(this);
		}
	}

	[RuleVersion(0)]
	public FormalParameterListContext formalParameterList() {
		FormalParameterListContext _localctx = new FormalParameterListContext(Context, State);
		EnterRule(_localctx, 148, RULE_formalParameterList);
		try {
			State = 1034;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,82,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1028;
				receiverParameter();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1029;
				formalParameters();
				State = 1030;
				Match(COMMA);
				State = 1031;
				lastFormalParameter();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1033;
				lastFormalParameter();
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

	public partial class FormalParametersContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public FormalParameterContext[] formalParameter() {
			return GetRuleContexts<FormalParameterContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public FormalParameterContext formalParameter(int i) {
			return GetRuleContext<FormalParameterContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java8Parser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(Java8Parser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ReceiverParameterContext receiverParameter() {
			return GetRuleContext<ReceiverParameterContext>(0);
		}
		public FormalParametersContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_formalParameters; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterFormalParameters(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitFormalParameters(this);
		}
	}

	[RuleVersion(0)]
	public FormalParametersContext formalParameters() {
		FormalParametersContext _localctx = new FormalParametersContext(Context, State);
		EnterRule(_localctx, 150, RULE_formalParameters);
		try {
			int _alt;
			State = 1052;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,85,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1036;
				formalParameter();
				State = 1041;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,83,Context);
				while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						State = 1037;
						Match(COMMA);
						State = 1038;
						formalParameter();
						}
						} 
					}
					State = 1043;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,83,Context);
				}
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1044;
				receiverParameter();
				State = 1049;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,84,Context);
				while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						State = 1045;
						Match(COMMA);
						State = 1046;
						formalParameter();
						}
						} 
					}
					State = 1051;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,84,Context);
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

	public partial class FormalParameterContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnannTypeContext unannType() {
			return GetRuleContext<UnannTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableDeclaratorIdContext variableDeclaratorId() {
			return GetRuleContext<VariableDeclaratorIdContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableModifierContext[] variableModifier() {
			return GetRuleContexts<VariableModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableModifierContext variableModifier(int i) {
			return GetRuleContext<VariableModifierContext>(i);
		}
		public FormalParameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_formalParameter; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterFormalParameter(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitFormalParameter(this);
		}
	}

	[RuleVersion(0)]
	public FormalParameterContext formalParameter() {
		FormalParameterContext _localctx = new FormalParameterContext(Context, State);
		EnterRule(_localctx, 152, RULE_formalParameter);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1057;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==FINAL || _la==AT) {
				{
				{
				State = 1054;
				variableModifier();
				}
				}
				State = 1059;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1060;
			unannType();
			State = 1061;
			variableDeclaratorId();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class VariableModifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation() {
			return GetRuleContext<AnnotationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FINAL() { return GetToken(Java8Parser.FINAL, 0); }
		public VariableModifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variableModifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterVariableModifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitVariableModifier(this);
		}
	}

	[RuleVersion(0)]
	public VariableModifierContext variableModifier() {
		VariableModifierContext _localctx = new VariableModifierContext(Context, State);
		EnterRule(_localctx, 154, RULE_variableModifier);
		try {
			State = 1065;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case AT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1063;
				annotation();
				}
				break;
			case FINAL:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1064;
				Match(FINAL);
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

	public partial class LastFormalParameterContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnannTypeContext unannType() {
			return GetRuleContext<UnannTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ELLIPSIS() { return GetToken(Java8Parser.ELLIPSIS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public VariableDeclaratorIdContext variableDeclaratorId() {
			return GetRuleContext<VariableDeclaratorIdContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableModifierContext[] variableModifier() {
			return GetRuleContexts<VariableModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableModifierContext variableModifier(int i) {
			return GetRuleContext<VariableModifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext[] annotation() {
			return GetRuleContexts<AnnotationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation(int i) {
			return GetRuleContext<AnnotationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FormalParameterContext formalParameter() {
			return GetRuleContext<FormalParameterContext>(0);
		}
		public LastFormalParameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lastFormalParameter; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterLastFormalParameter(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitLastFormalParameter(this);
		}
	}

	[RuleVersion(0)]
	public LastFormalParameterContext lastFormalParameter() {
		LastFormalParameterContext _localctx = new LastFormalParameterContext(Context, State);
		EnterRule(_localctx, 156, RULE_lastFormalParameter);
		int _la;
		try {
			State = 1084;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,90,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1070;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==FINAL || _la==AT) {
					{
					{
					State = 1067;
					variableModifier();
					}
					}
					State = 1072;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 1073;
				unannType();
				State = 1077;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==AT) {
					{
					{
					State = 1074;
					annotation();
					}
					}
					State = 1079;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 1080;
				Match(ELLIPSIS);
				State = 1081;
				variableDeclaratorId();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1083;
				formalParameter();
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

	public partial class ReceiverParameterContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnannTypeContext unannType() {
			return GetRuleContext<UnannTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THIS() { return GetToken(Java8Parser.THIS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext[] annotation() {
			return GetRuleContexts<AnnotationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation(int i) {
			return GetRuleContext<AnnotationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		public ReceiverParameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_receiverParameter; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterReceiverParameter(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitReceiverParameter(this);
		}
	}

	[RuleVersion(0)]
	public ReceiverParameterContext receiverParameter() {
		ReceiverParameterContext _localctx = new ReceiverParameterContext(Context, State);
		EnterRule(_localctx, 158, RULE_receiverParameter);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1089;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==AT) {
				{
				{
				State = 1086;
				annotation();
				}
				}
				State = 1091;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1092;
			unannType();
			State = 1095;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Identifier) {
				{
				State = 1093;
				Match(Identifier);
				State = 1094;
				Match(DOT);
				}
			}

			State = 1097;
			Match(THIS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Throws_Context : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THROWS() { return GetToken(Java8Parser.THROWS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExceptionTypeListContext exceptionTypeList() {
			return GetRuleContext<ExceptionTypeListContext>(0);
		}
		public Throws_Context(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_throws_; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterThrows_(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitThrows_(this);
		}
	}

	[RuleVersion(0)]
	public Throws_Context throws_() {
		Throws_Context _localctx = new Throws_Context(Context, State);
		EnterRule(_localctx, 160, RULE_throws_);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1099;
			Match(THROWS);
			State = 1100;
			exceptionTypeList();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExceptionTypeListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExceptionTypeContext[] exceptionType() {
			return GetRuleContexts<ExceptionTypeContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExceptionTypeContext exceptionType(int i) {
			return GetRuleContext<ExceptionTypeContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java8Parser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(Java8Parser.COMMA, i);
		}
		public ExceptionTypeListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exceptionTypeList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterExceptionTypeList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitExceptionTypeList(this);
		}
	}

	[RuleVersion(0)]
	public ExceptionTypeListContext exceptionTypeList() {
		ExceptionTypeListContext _localctx = new ExceptionTypeListContext(Context, State);
		EnterRule(_localctx, 162, RULE_exceptionTypeList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1102;
			exceptionType();
			State = 1107;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1103;
				Match(COMMA);
				State = 1104;
				exceptionType();
				}
				}
				State = 1109;
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

	public partial class ExceptionTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ClassTypeContext classType() {
			return GetRuleContext<ClassTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeVariableContext typeVariable() {
			return GetRuleContext<TypeVariableContext>(0);
		}
		public ExceptionTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exceptionType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterExceptionType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitExceptionType(this);
		}
	}

	[RuleVersion(0)]
	public ExceptionTypeContext exceptionType() {
		ExceptionTypeContext _localctx = new ExceptionTypeContext(Context, State);
		EnterRule(_localctx, 164, RULE_exceptionType);
		try {
			State = 1112;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,94,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1110;
				classType();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1111;
				typeVariable();
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

	public partial class MethodBodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		public MethodBodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodBody; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterMethodBody(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitMethodBody(this);
		}
	}

	[RuleVersion(0)]
	public MethodBodyContext methodBody() {
		MethodBodyContext _localctx = new MethodBodyContext(Context, State);
		EnterRule(_localctx, 166, RULE_methodBody);
		try {
			State = 1116;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case LBRACE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1114;
				block();
				}
				break;
			case SEMI:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1115;
				Match(SEMI);
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

	public partial class InstanceInitializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public InstanceInitializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_instanceInitializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterInstanceInitializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitInstanceInitializer(this);
		}
	}

	[RuleVersion(0)]
	public InstanceInitializerContext instanceInitializer() {
		InstanceInitializerContext _localctx = new InstanceInitializerContext(Context, State);
		EnterRule(_localctx, 168, RULE_instanceInitializer);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1118;
			block();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StaticInitializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java8Parser.STATIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public StaticInitializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_staticInitializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterStaticInitializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitStaticInitializer(this);
		}
	}

	[RuleVersion(0)]
	public StaticInitializerContext staticInitializer() {
		StaticInitializerContext _localctx = new StaticInitializerContext(Context, State);
		EnterRule(_localctx, 170, RULE_staticInitializer);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1120;
			Match(STATIC);
			State = 1121;
			block();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ConstructorDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ConstructorDeclaratorContext constructorDeclarator() {
			return GetRuleContext<ConstructorDeclaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConstructorBodyContext constructorBody() {
			return GetRuleContext<ConstructorBodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConstructorModifierContext[] constructorModifier() {
			return GetRuleContexts<ConstructorModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConstructorModifierContext constructorModifier(int i) {
			return GetRuleContext<ConstructorModifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Throws_Context throws_() {
			return GetRuleContext<Throws_Context>(0);
		}
		public ConstructorDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constructorDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterConstructorDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitConstructorDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public ConstructorDeclarationContext constructorDeclaration() {
		ConstructorDeclarationContext _localctx = new ConstructorDeclarationContext(Context, State);
		EnterRule(_localctx, 172, RULE_constructorDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1126;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC))) != 0) || _la==AT) {
				{
				{
				State = 1123;
				constructorModifier();
				}
				}
				State = 1128;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1129;
			constructorDeclarator();
			State = 1131;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==THROWS) {
				{
				State = 1130;
				throws_();
				}
			}

			State = 1133;
			constructorBody();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ConstructorModifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation() {
			return GetRuleContext<AnnotationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLIC() { return GetToken(Java8Parser.PUBLIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PROTECTED() { return GetToken(Java8Parser.PROTECTED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRIVATE() { return GetToken(Java8Parser.PRIVATE, 0); }
		public ConstructorModifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constructorModifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterConstructorModifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitConstructorModifier(this);
		}
	}

	[RuleVersion(0)]
	public ConstructorModifierContext constructorModifier() {
		ConstructorModifierContext _localctx = new ConstructorModifierContext(Context, State);
		EnterRule(_localctx, 174, RULE_constructorModifier);
		try {
			State = 1139;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case AT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1135;
				annotation();
				}
				break;
			case PUBLIC:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1136;
				Match(PUBLIC);
				}
				break;
			case PROTECTED:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1137;
				Match(PROTECTED);
				}
				break;
			case PRIVATE:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1138;
				Match(PRIVATE);
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

	public partial class ConstructorDeclaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public SimpleTypeNameContext simpleTypeName() {
			return GetRuleContext<SimpleTypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeParametersContext typeParameters() {
			return GetRuleContext<TypeParametersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FormalParameterListContext formalParameterList() {
			return GetRuleContext<FormalParameterListContext>(0);
		}
		public ConstructorDeclaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constructorDeclarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterConstructorDeclarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitConstructorDeclarator(this);
		}
	}

	[RuleVersion(0)]
	public ConstructorDeclaratorContext constructorDeclarator() {
		ConstructorDeclaratorContext _localctx = new ConstructorDeclaratorContext(Context, State);
		EnterRule(_localctx, 176, RULE_constructorDeclarator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1142;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LT) {
				{
				State = 1141;
				typeParameters();
				}
			}

			State = 1144;
			simpleTypeName();
			State = 1145;
			Match(LPAREN);
			State = 1147;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FINAL) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << SHORT))) != 0) || _la==Identifier || _la==AT) {
				{
				State = 1146;
				formalParameterList();
				}
			}

			State = 1149;
			Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SimpleTypeNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		public SimpleTypeNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_simpleTypeName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterSimpleTypeName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitSimpleTypeName(this);
		}
	}

	[RuleVersion(0)]
	public SimpleTypeNameContext simpleTypeName() {
		SimpleTypeNameContext _localctx = new SimpleTypeNameContext(Context, State);
		EnterRule(_localctx, 178, RULE_simpleTypeName);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1151;
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

	public partial class ConstructorBodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java8Parser.LBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java8Parser.RBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExplicitConstructorInvocationContext explicitConstructorInvocation() {
			return GetRuleContext<ExplicitConstructorInvocationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BlockStatementsContext blockStatements() {
			return GetRuleContext<BlockStatementsContext>(0);
		}
		public ConstructorBodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constructorBody; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterConstructorBody(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitConstructorBody(this);
		}
	}

	[RuleVersion(0)]
	public ConstructorBodyContext constructorBody() {
		ConstructorBodyContext _localctx = new ConstructorBodyContext(Context, State);
		EnterRule(_localctx, 180, RULE_constructorBody);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1153;
			Match(LBRACE);
			State = 1155;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,101,Context) ) {
			case 1:
				{
				State = 1154;
				explicitConstructorInvocation();
				}
				break;
			}
			State = 1158;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << ASSERT) | (1L << BOOLEAN) | (1L << BREAK) | (1L << BYTE) | (1L << CHAR) | (1L << CLASS) | (1L << CONTINUE) | (1L << DO) | (1L << DOUBLE) | (1L << ENUM) | (1L << FINAL) | (1L << FLOAT) | (1L << FOR) | (1L << IF) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << RETURN) | (1L << SHORT) | (1L << STATIC) | (1L << STRICTFP) | (1L << SUPER) | (1L << SWITCH) | (1L << SYNCHRONIZED) | (1L << THIS) | (1L << THROW) | (1L << TRY) | (1L << VOID) | (1L << WHILE) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN) | (1L << LBRACE) | (1L << SEMI))) != 0) || ((((_la - 79)) & ~0x3f) == 0 && ((1L << (_la - 79)) & ((1L << (INC - 79)) | (1L << (DEC - 79)) | (1L << (Identifier - 79)) | (1L << (AT - 79)))) != 0)) {
				{
				State = 1157;
				blockStatements();
				}
			}

			State = 1160;
			Match(RBRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExplicitConstructorInvocationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THIS() { return GetToken(Java8Parser.THIS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsContext typeArguments() {
			return GetRuleContext<TypeArgumentsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentListContext argumentList() {
			return GetRuleContext<ArgumentListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUPER() { return GetToken(Java8Parser.SUPER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionNameContext expressionName() {
			return GetRuleContext<ExpressionNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryContext primary() {
			return GetRuleContext<PrimaryContext>(0);
		}
		public ExplicitConstructorInvocationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_explicitConstructorInvocation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterExplicitConstructorInvocation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitExplicitConstructorInvocation(this);
		}
	}

	[RuleVersion(0)]
	public ExplicitConstructorInvocationContext explicitConstructorInvocation() {
		ExplicitConstructorInvocationContext _localctx = new ExplicitConstructorInvocationContext(Context, State);
		EnterRule(_localctx, 182, RULE_explicitConstructorInvocation);
		int _la;
		try {
			State = 1208;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,111,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1163;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 1162;
					typeArguments();
					}
				}

				State = 1165;
				Match(THIS);
				State = 1166;
				Match(LPAREN);
				State = 1168;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 1167;
					argumentList();
					}
				}

				State = 1170;
				Match(RPAREN);
				State = 1171;
				Match(SEMI);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1173;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 1172;
					typeArguments();
					}
				}

				State = 1175;
				Match(SUPER);
				State = 1176;
				Match(LPAREN);
				State = 1178;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 1177;
					argumentList();
					}
				}

				State = 1180;
				Match(RPAREN);
				State = 1181;
				Match(SEMI);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1182;
				expressionName();
				State = 1183;
				Match(DOT);
				State = 1185;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 1184;
					typeArguments();
					}
				}

				State = 1187;
				Match(SUPER);
				State = 1188;
				Match(LPAREN);
				State = 1190;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 1189;
					argumentList();
					}
				}

				State = 1192;
				Match(RPAREN);
				State = 1193;
				Match(SEMI);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1195;
				primary();
				State = 1196;
				Match(DOT);
				State = 1198;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 1197;
					typeArguments();
					}
				}

				State = 1200;
				Match(SUPER);
				State = 1201;
				Match(LPAREN);
				State = 1203;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 1202;
					argumentList();
					}
				}

				State = 1205;
				Match(RPAREN);
				State = 1206;
				Match(SEMI);
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

	public partial class EnumDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ENUM() { return GetToken(Java8Parser.ENUM, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public EnumBodyContext enumBody() {
			return GetRuleContext<EnumBodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassModifierContext[] classModifier() {
			return GetRuleContexts<ClassModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassModifierContext classModifier(int i) {
			return GetRuleContext<ClassModifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SuperinterfacesContext superinterfaces() {
			return GetRuleContext<SuperinterfacesContext>(0);
		}
		public EnumDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterEnumDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitEnumDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public EnumDeclarationContext enumDeclaration() {
		EnumDeclarationContext _localctx = new EnumDeclarationContext(Context, State);
		EnterRule(_localctx, 184, RULE_enumDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1213;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << FINAL) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << STATIC) | (1L << STRICTFP))) != 0) || _la==AT) {
				{
				{
				State = 1210;
				classModifier();
				}
				}
				State = 1215;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1216;
			Match(ENUM);
			State = 1217;
			Match(Identifier);
			State = 1219;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==IMPLEMENTS) {
				{
				State = 1218;
				superinterfaces();
				}
			}

			State = 1221;
			enumBody();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EnumBodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java8Parser.LBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java8Parser.RBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public EnumConstantListContext enumConstantList() {
			return GetRuleContext<EnumConstantListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(Java8Parser.COMMA, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public EnumBodyDeclarationsContext enumBodyDeclarations() {
			return GetRuleContext<EnumBodyDeclarationsContext>(0);
		}
		public EnumBodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumBody; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterEnumBody(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitEnumBody(this);
		}
	}

	[RuleVersion(0)]
	public EnumBodyContext enumBody() {
		EnumBodyContext _localctx = new EnumBodyContext(Context, State);
		EnterRule(_localctx, 186, RULE_enumBody);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1223;
			Match(LBRACE);
			State = 1225;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Identifier || _la==AT) {
				{
				State = 1224;
				enumConstantList();
				}
			}

			State = 1228;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==COMMA) {
				{
				State = 1227;
				Match(COMMA);
				}
			}

			State = 1231;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SEMI) {
				{
				State = 1230;
				enumBodyDeclarations();
				}
			}

			State = 1233;
			Match(RBRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EnumConstantListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public EnumConstantContext[] enumConstant() {
			return GetRuleContexts<EnumConstantContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public EnumConstantContext enumConstant(int i) {
			return GetRuleContext<EnumConstantContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java8Parser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(Java8Parser.COMMA, i);
		}
		public EnumConstantListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumConstantList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterEnumConstantList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitEnumConstantList(this);
		}
	}

	[RuleVersion(0)]
	public EnumConstantListContext enumConstantList() {
		EnumConstantListContext _localctx = new EnumConstantListContext(Context, State);
		EnterRule(_localctx, 188, RULE_enumConstantList);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1235;
			enumConstant();
			State = 1240;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,117,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1236;
					Match(COMMA);
					State = 1237;
					enumConstant();
					}
					} 
				}
				State = 1242;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,117,Context);
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

	public partial class EnumConstantContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public EnumConstantModifierContext[] enumConstantModifier() {
			return GetRuleContexts<EnumConstantModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public EnumConstantModifierContext enumConstantModifier(int i) {
			return GetRuleContext<EnumConstantModifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ClassBodyContext classBody() {
			return GetRuleContext<ClassBodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentListContext argumentList() {
			return GetRuleContext<ArgumentListContext>(0);
		}
		public EnumConstantContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumConstant; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterEnumConstant(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitEnumConstant(this);
		}
	}

	[RuleVersion(0)]
	public EnumConstantContext enumConstant() {
		EnumConstantContext _localctx = new EnumConstantContext(Context, State);
		EnterRule(_localctx, 190, RULE_enumConstant);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1246;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==AT) {
				{
				{
				State = 1243;
				enumConstantModifier();
				}
				}
				State = 1248;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1249;
			Match(Identifier);
			State = 1255;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LPAREN) {
				{
				State = 1250;
				Match(LPAREN);
				State = 1252;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 1251;
					argumentList();
					}
				}

				State = 1254;
				Match(RPAREN);
				}
			}

			State = 1258;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LBRACE) {
				{
				State = 1257;
				classBody();
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

	public partial class EnumConstantModifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation() {
			return GetRuleContext<AnnotationContext>(0);
		}
		public EnumConstantModifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumConstantModifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterEnumConstantModifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitEnumConstantModifier(this);
		}
	}

	[RuleVersion(0)]
	public EnumConstantModifierContext enumConstantModifier() {
		EnumConstantModifierContext _localctx = new EnumConstantModifierContext(Context, State);
		EnterRule(_localctx, 192, RULE_enumConstantModifier);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1260;
			annotation();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EnumBodyDeclarationsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ClassBodyDeclarationContext[] classBodyDeclaration() {
			return GetRuleContexts<ClassBodyDeclarationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassBodyDeclarationContext classBodyDeclaration(int i) {
			return GetRuleContext<ClassBodyDeclarationContext>(i);
		}
		public EnumBodyDeclarationsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumBodyDeclarations; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterEnumBodyDeclarations(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitEnumBodyDeclarations(this);
		}
	}

	[RuleVersion(0)]
	public EnumBodyDeclarationsContext enumBodyDeclarations() {
		EnumBodyDeclarationsContext _localctx = new EnumBodyDeclarationsContext(Context, State);
		EnterRule(_localctx, 194, RULE_enumBodyDeclarations);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1262;
			Match(SEMI);
			State = 1266;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << CLASS) | (1L << DOUBLE) | (1L << ENUM) | (1L << FINAL) | (1L << FLOAT) | (1L << INT) | (1L << INTERFACE) | (1L << LONG) | (1L << NATIVE) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << SHORT) | (1L << STATIC) | (1L << STRICTFP) | (1L << SYNCHRONIZED) | (1L << TRANSIENT) | (1L << VOID) | (1L << VOLATILE) | (1L << LBRACE) | (1L << SEMI))) != 0) || ((((_la - 68)) & ~0x3f) == 0 && ((1L << (_la - 68)) & ((1L << (LT - 68)) | (1L << (Identifier - 68)) | (1L << (AT - 68)))) != 0)) {
				{
				{
				State = 1263;
				classBodyDeclaration();
				}
				}
				State = 1268;
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

	public partial class InterfaceDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public NormalInterfaceDeclarationContext normalInterfaceDeclaration() {
			return GetRuleContext<NormalInterfaceDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationTypeDeclarationContext annotationTypeDeclaration() {
			return GetRuleContext<AnnotationTypeDeclarationContext>(0);
		}
		public InterfaceDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interfaceDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterInterfaceDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitInterfaceDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public InterfaceDeclarationContext interfaceDeclaration() {
		InterfaceDeclarationContext _localctx = new InterfaceDeclarationContext(Context, State);
		EnterRule(_localctx, 196, RULE_interfaceDeclaration);
		try {
			State = 1271;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,123,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1269;
				normalInterfaceDeclaration();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1270;
				annotationTypeDeclaration();
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

	public partial class NormalInterfaceDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERFACE() { return GetToken(Java8Parser.INTERFACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceBodyContext interfaceBody() {
			return GetRuleContext<InterfaceBodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceModifierContext[] interfaceModifier() {
			return GetRuleContexts<InterfaceModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceModifierContext interfaceModifier(int i) {
			return GetRuleContext<InterfaceModifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeParametersContext typeParameters() {
			return GetRuleContext<TypeParametersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExtendsInterfacesContext extendsInterfaces() {
			return GetRuleContext<ExtendsInterfacesContext>(0);
		}
		public NormalInterfaceDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_normalInterfaceDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterNormalInterfaceDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitNormalInterfaceDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public NormalInterfaceDeclarationContext normalInterfaceDeclaration() {
		NormalInterfaceDeclarationContext _localctx = new NormalInterfaceDeclarationContext(Context, State);
		EnterRule(_localctx, 198, RULE_normalInterfaceDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1276;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << STATIC) | (1L << STRICTFP))) != 0) || _la==AT) {
				{
				{
				State = 1273;
				interfaceModifier();
				}
				}
				State = 1278;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1279;
			Match(INTERFACE);
			State = 1280;
			Match(Identifier);
			State = 1282;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LT) {
				{
				State = 1281;
				typeParameters();
				}
			}

			State = 1285;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==EXTENDS) {
				{
				State = 1284;
				extendsInterfaces();
				}
			}

			State = 1287;
			interfaceBody();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InterfaceModifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation() {
			return GetRuleContext<AnnotationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLIC() { return GetToken(Java8Parser.PUBLIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PROTECTED() { return GetToken(Java8Parser.PROTECTED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRIVATE() { return GetToken(Java8Parser.PRIVATE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ABSTRACT() { return GetToken(Java8Parser.ABSTRACT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java8Parser.STATIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRICTFP() { return GetToken(Java8Parser.STRICTFP, 0); }
		public InterfaceModifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interfaceModifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterInterfaceModifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitInterfaceModifier(this);
		}
	}

	[RuleVersion(0)]
	public InterfaceModifierContext interfaceModifier() {
		InterfaceModifierContext _localctx = new InterfaceModifierContext(Context, State);
		EnterRule(_localctx, 200, RULE_interfaceModifier);
		try {
			State = 1296;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case AT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1289;
				annotation();
				}
				break;
			case PUBLIC:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1290;
				Match(PUBLIC);
				}
				break;
			case PROTECTED:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1291;
				Match(PROTECTED);
				}
				break;
			case PRIVATE:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1292;
				Match(PRIVATE);
				}
				break;
			case ABSTRACT:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1293;
				Match(ABSTRACT);
				}
				break;
			case STATIC:
				EnterOuterAlt(_localctx, 6);
				{
				State = 1294;
				Match(STATIC);
				}
				break;
			case STRICTFP:
				EnterOuterAlt(_localctx, 7);
				{
				State = 1295;
				Match(STRICTFP);
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

	public partial class ExtendsInterfacesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXTENDS() { return GetToken(Java8Parser.EXTENDS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceTypeListContext interfaceTypeList() {
			return GetRuleContext<InterfaceTypeListContext>(0);
		}
		public ExtendsInterfacesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_extendsInterfaces; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterExtendsInterfaces(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitExtendsInterfaces(this);
		}
	}

	[RuleVersion(0)]
	public ExtendsInterfacesContext extendsInterfaces() {
		ExtendsInterfacesContext _localctx = new ExtendsInterfacesContext(Context, State);
		EnterRule(_localctx, 202, RULE_extendsInterfaces);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1298;
			Match(EXTENDS);
			State = 1299;
			interfaceTypeList();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InterfaceBodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java8Parser.LBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java8Parser.RBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceMemberDeclarationContext[] interfaceMemberDeclaration() {
			return GetRuleContexts<InterfaceMemberDeclarationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceMemberDeclarationContext interfaceMemberDeclaration(int i) {
			return GetRuleContext<InterfaceMemberDeclarationContext>(i);
		}
		public InterfaceBodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interfaceBody; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterInterfaceBody(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitInterfaceBody(this);
		}
	}

	[RuleVersion(0)]
	public InterfaceBodyContext interfaceBody() {
		InterfaceBodyContext _localctx = new InterfaceBodyContext(Context, State);
		EnterRule(_localctx, 204, RULE_interfaceBody);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1301;
			Match(LBRACE);
			State = 1305;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << CLASS) | (1L << DEFAULT) | (1L << DOUBLE) | (1L << ENUM) | (1L << FINAL) | (1L << FLOAT) | (1L << INT) | (1L << INTERFACE) | (1L << LONG) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << SHORT) | (1L << STATIC) | (1L << STRICTFP) | (1L << VOID) | (1L << SEMI))) != 0) || ((((_la - 68)) & ~0x3f) == 0 && ((1L << (_la - 68)) & ((1L << (LT - 68)) | (1L << (Identifier - 68)) | (1L << (AT - 68)))) != 0)) {
				{
				{
				State = 1302;
				interfaceMemberDeclaration();
				}
				}
				State = 1307;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1308;
			Match(RBRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InterfaceMemberDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ConstantDeclarationContext constantDeclaration() {
			return GetRuleContext<ConstantDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceMethodDeclarationContext interfaceMethodDeclaration() {
			return GetRuleContext<InterfaceMethodDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassDeclarationContext classDeclaration() {
			return GetRuleContext<ClassDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceDeclarationContext interfaceDeclaration() {
			return GetRuleContext<InterfaceDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		public InterfaceMemberDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interfaceMemberDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterInterfaceMemberDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitInterfaceMemberDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public InterfaceMemberDeclarationContext interfaceMemberDeclaration() {
		InterfaceMemberDeclarationContext _localctx = new InterfaceMemberDeclarationContext(Context, State);
		EnterRule(_localctx, 206, RULE_interfaceMemberDeclaration);
		try {
			State = 1315;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,129,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1310;
				constantDeclaration();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1311;
				interfaceMethodDeclaration();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1312;
				classDeclaration();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1313;
				interfaceDeclaration();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1314;
				Match(SEMI);
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

	public partial class ConstantDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnannTypeContext unannType() {
			return GetRuleContext<UnannTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableDeclaratorListContext variableDeclaratorList() {
			return GetRuleContext<VariableDeclaratorListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantModifierContext[] constantModifier() {
			return GetRuleContexts<ConstantModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConstantModifierContext constantModifier(int i) {
			return GetRuleContext<ConstantModifierContext>(i);
		}
		public ConstantDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constantDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterConstantDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitConstantDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public ConstantDeclarationContext constantDeclaration() {
		ConstantDeclarationContext _localctx = new ConstantDeclarationContext(Context, State);
		EnterRule(_localctx, 208, RULE_constantDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1320;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << FINAL) | (1L << PUBLIC) | (1L << STATIC))) != 0) || _la==AT) {
				{
				{
				State = 1317;
				constantModifier();
				}
				}
				State = 1322;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1323;
			unannType();
			State = 1324;
			variableDeclaratorList();
			State = 1325;
			Match(SEMI);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ConstantModifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation() {
			return GetRuleContext<AnnotationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLIC() { return GetToken(Java8Parser.PUBLIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java8Parser.STATIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FINAL() { return GetToken(Java8Parser.FINAL, 0); }
		public ConstantModifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constantModifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterConstantModifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitConstantModifier(this);
		}
	}

	[RuleVersion(0)]
	public ConstantModifierContext constantModifier() {
		ConstantModifierContext _localctx = new ConstantModifierContext(Context, State);
		EnterRule(_localctx, 210, RULE_constantModifier);
		try {
			State = 1331;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case AT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1327;
				annotation();
				}
				break;
			case PUBLIC:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1328;
				Match(PUBLIC);
				}
				break;
			case STATIC:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1329;
				Match(STATIC);
				}
				break;
			case FINAL:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1330;
				Match(FINAL);
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

	public partial class InterfaceMethodDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public MethodHeaderContext methodHeader() {
			return GetRuleContext<MethodHeaderContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodBodyContext methodBody() {
			return GetRuleContext<MethodBodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceMethodModifierContext[] interfaceMethodModifier() {
			return GetRuleContexts<InterfaceMethodModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceMethodModifierContext interfaceMethodModifier(int i) {
			return GetRuleContext<InterfaceMethodModifierContext>(i);
		}
		public InterfaceMethodDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interfaceMethodDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterInterfaceMethodDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitInterfaceMethodDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public InterfaceMethodDeclarationContext interfaceMethodDeclaration() {
		InterfaceMethodDeclarationContext _localctx = new InterfaceMethodDeclarationContext(Context, State);
		EnterRule(_localctx, 212, RULE_interfaceMethodDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1336;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << DEFAULT) | (1L << PUBLIC) | (1L << STATIC) | (1L << STRICTFP))) != 0) || _la==AT) {
				{
				{
				State = 1333;
				interfaceMethodModifier();
				}
				}
				State = 1338;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1339;
			methodHeader();
			State = 1340;
			methodBody();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InterfaceMethodModifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation() {
			return GetRuleContext<AnnotationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLIC() { return GetToken(Java8Parser.PUBLIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ABSTRACT() { return GetToken(Java8Parser.ABSTRACT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFAULT() { return GetToken(Java8Parser.DEFAULT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java8Parser.STATIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRICTFP() { return GetToken(Java8Parser.STRICTFP, 0); }
		public InterfaceMethodModifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interfaceMethodModifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterInterfaceMethodModifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitInterfaceMethodModifier(this);
		}
	}

	[RuleVersion(0)]
	public InterfaceMethodModifierContext interfaceMethodModifier() {
		InterfaceMethodModifierContext _localctx = new InterfaceMethodModifierContext(Context, State);
		EnterRule(_localctx, 214, RULE_interfaceMethodModifier);
		try {
			State = 1348;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case AT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1342;
				annotation();
				}
				break;
			case PUBLIC:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1343;
				Match(PUBLIC);
				}
				break;
			case ABSTRACT:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1344;
				Match(ABSTRACT);
				}
				break;
			case DEFAULT:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1345;
				Match(DEFAULT);
				}
				break;
			case STATIC:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1346;
				Match(STATIC);
				}
				break;
			case STRICTFP:
				EnterOuterAlt(_localctx, 6);
				{
				State = 1347;
				Match(STRICTFP);
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

	public partial class AnnotationTypeDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AT() { return GetToken(Java8Parser.AT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERFACE() { return GetToken(Java8Parser.INTERFACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationTypeBodyContext annotationTypeBody() {
			return GetRuleContext<AnnotationTypeBodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceModifierContext[] interfaceModifier() {
			return GetRuleContexts<InterfaceModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceModifierContext interfaceModifier(int i) {
			return GetRuleContext<InterfaceModifierContext>(i);
		}
		public AnnotationTypeDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_annotationTypeDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterAnnotationTypeDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitAnnotationTypeDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public AnnotationTypeDeclarationContext annotationTypeDeclaration() {
		AnnotationTypeDeclarationContext _localctx = new AnnotationTypeDeclarationContext(Context, State);
		EnterRule(_localctx, 216, RULE_annotationTypeDeclaration);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1353;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,134,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1350;
					interfaceModifier();
					}
					} 
				}
				State = 1355;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,134,Context);
			}
			State = 1356;
			Match(AT);
			State = 1357;
			Match(INTERFACE);
			State = 1358;
			Match(Identifier);
			State = 1359;
			annotationTypeBody();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AnnotationTypeBodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java8Parser.LBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java8Parser.RBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationTypeMemberDeclarationContext[] annotationTypeMemberDeclaration() {
			return GetRuleContexts<AnnotationTypeMemberDeclarationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationTypeMemberDeclarationContext annotationTypeMemberDeclaration(int i) {
			return GetRuleContext<AnnotationTypeMemberDeclarationContext>(i);
		}
		public AnnotationTypeBodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_annotationTypeBody; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterAnnotationTypeBody(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitAnnotationTypeBody(this);
		}
	}

	[RuleVersion(0)]
	public AnnotationTypeBodyContext annotationTypeBody() {
		AnnotationTypeBodyContext _localctx = new AnnotationTypeBodyContext(Context, State);
		EnterRule(_localctx, 218, RULE_annotationTypeBody);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1361;
			Match(LBRACE);
			State = 1365;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << CLASS) | (1L << DOUBLE) | (1L << ENUM) | (1L << FINAL) | (1L << FLOAT) | (1L << INT) | (1L << INTERFACE) | (1L << LONG) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << SHORT) | (1L << STATIC) | (1L << STRICTFP) | (1L << SEMI))) != 0) || _la==Identifier || _la==AT) {
				{
				{
				State = 1362;
				annotationTypeMemberDeclaration();
				}
				}
				State = 1367;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1368;
			Match(RBRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AnnotationTypeMemberDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationTypeElementDeclarationContext annotationTypeElementDeclaration() {
			return GetRuleContext<AnnotationTypeElementDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConstantDeclarationContext constantDeclaration() {
			return GetRuleContext<ConstantDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassDeclarationContext classDeclaration() {
			return GetRuleContext<ClassDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InterfaceDeclarationContext interfaceDeclaration() {
			return GetRuleContext<InterfaceDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		public AnnotationTypeMemberDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_annotationTypeMemberDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterAnnotationTypeMemberDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitAnnotationTypeMemberDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public AnnotationTypeMemberDeclarationContext annotationTypeMemberDeclaration() {
		AnnotationTypeMemberDeclarationContext _localctx = new AnnotationTypeMemberDeclarationContext(Context, State);
		EnterRule(_localctx, 220, RULE_annotationTypeMemberDeclaration);
		try {
			State = 1375;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,136,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1370;
				annotationTypeElementDeclaration();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1371;
				constantDeclaration();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1372;
				classDeclaration();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1373;
				interfaceDeclaration();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1374;
				Match(SEMI);
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

	public partial class AnnotationTypeElementDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnannTypeContext unannType() {
			return GetRuleContext<UnannTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationTypeElementModifierContext[] annotationTypeElementModifier() {
			return GetRuleContexts<AnnotationTypeElementModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationTypeElementModifierContext annotationTypeElementModifier(int i) {
			return GetRuleContext<AnnotationTypeElementModifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DimsContext dims() {
			return GetRuleContext<DimsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DefaultValueContext defaultValue() {
			return GetRuleContext<DefaultValueContext>(0);
		}
		public AnnotationTypeElementDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_annotationTypeElementDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterAnnotationTypeElementDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitAnnotationTypeElementDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public AnnotationTypeElementDeclarationContext annotationTypeElementDeclaration() {
		AnnotationTypeElementDeclarationContext _localctx = new AnnotationTypeElementDeclarationContext(Context, State);
		EnterRule(_localctx, 222, RULE_annotationTypeElementDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1380;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==ABSTRACT || _la==PUBLIC || _la==AT) {
				{
				{
				State = 1377;
				annotationTypeElementModifier();
				}
				}
				State = 1382;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1383;
			unannType();
			State = 1384;
			Match(Identifier);
			State = 1385;
			Match(LPAREN);
			State = 1386;
			Match(RPAREN);
			State = 1388;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LBRACK || _la==AT) {
				{
				State = 1387;
				dims();
				}
			}

			State = 1391;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==DEFAULT) {
				{
				State = 1390;
				defaultValue();
				}
			}

			State = 1393;
			Match(SEMI);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AnnotationTypeElementModifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation() {
			return GetRuleContext<AnnotationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLIC() { return GetToken(Java8Parser.PUBLIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ABSTRACT() { return GetToken(Java8Parser.ABSTRACT, 0); }
		public AnnotationTypeElementModifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_annotationTypeElementModifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterAnnotationTypeElementModifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitAnnotationTypeElementModifier(this);
		}
	}

	[RuleVersion(0)]
	public AnnotationTypeElementModifierContext annotationTypeElementModifier() {
		AnnotationTypeElementModifierContext _localctx = new AnnotationTypeElementModifierContext(Context, State);
		EnterRule(_localctx, 224, RULE_annotationTypeElementModifier);
		try {
			State = 1398;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case AT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1395;
				annotation();
				}
				break;
			case PUBLIC:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1396;
				Match(PUBLIC);
				}
				break;
			case ABSTRACT:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1397;
				Match(ABSTRACT);
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

	public partial class DefaultValueContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFAULT() { return GetToken(Java8Parser.DEFAULT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ElementValueContext elementValue() {
			return GetRuleContext<ElementValueContext>(0);
		}
		public DefaultValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_defaultValue; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterDefaultValue(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitDefaultValue(this);
		}
	}

	[RuleVersion(0)]
	public DefaultValueContext defaultValue() {
		DefaultValueContext _localctx = new DefaultValueContext(Context, State);
		EnterRule(_localctx, 226, RULE_defaultValue);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1400;
			Match(DEFAULT);
			State = 1401;
			elementValue();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AnnotationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public NormalAnnotationContext normalAnnotation() {
			return GetRuleContext<NormalAnnotationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MarkerAnnotationContext markerAnnotation() {
			return GetRuleContext<MarkerAnnotationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SingleElementAnnotationContext singleElementAnnotation() {
			return GetRuleContext<SingleElementAnnotationContext>(0);
		}
		public AnnotationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_annotation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterAnnotation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitAnnotation(this);
		}
	}

	[RuleVersion(0)]
	public AnnotationContext annotation() {
		AnnotationContext _localctx = new AnnotationContext(Context, State);
		EnterRule(_localctx, 228, RULE_annotation);
		try {
			State = 1406;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,141,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1403;
				normalAnnotation();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1404;
				markerAnnotation();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1405;
				singleElementAnnotation();
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

	public partial class NormalAnnotationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AT() { return GetToken(Java8Parser.AT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ElementValuePairListContext elementValuePairList() {
			return GetRuleContext<ElementValuePairListContext>(0);
		}
		public NormalAnnotationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_normalAnnotation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterNormalAnnotation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitNormalAnnotation(this);
		}
	}

	[RuleVersion(0)]
	public NormalAnnotationContext normalAnnotation() {
		NormalAnnotationContext _localctx = new NormalAnnotationContext(Context, State);
		EnterRule(_localctx, 230, RULE_normalAnnotation);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1408;
			Match(AT);
			State = 1409;
			typeName();
			State = 1410;
			Match(LPAREN);
			State = 1412;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Identifier) {
				{
				State = 1411;
				elementValuePairList();
				}
			}

			State = 1414;
			Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ElementValuePairListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ElementValuePairContext[] elementValuePair() {
			return GetRuleContexts<ElementValuePairContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ElementValuePairContext elementValuePair(int i) {
			return GetRuleContext<ElementValuePairContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java8Parser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(Java8Parser.COMMA, i);
		}
		public ElementValuePairListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_elementValuePairList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterElementValuePairList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitElementValuePairList(this);
		}
	}

	[RuleVersion(0)]
	public ElementValuePairListContext elementValuePairList() {
		ElementValuePairListContext _localctx = new ElementValuePairListContext(Context, State);
		EnterRule(_localctx, 232, RULE_elementValuePairList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1416;
			elementValuePair();
			State = 1421;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1417;
				Match(COMMA);
				State = 1418;
				elementValuePair();
				}
				}
				State = 1423;
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

	public partial class ElementValuePairContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGN() { return GetToken(Java8Parser.ASSIGN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ElementValueContext elementValue() {
			return GetRuleContext<ElementValueContext>(0);
		}
		public ElementValuePairContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_elementValuePair; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterElementValuePair(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitElementValuePair(this);
		}
	}

	[RuleVersion(0)]
	public ElementValuePairContext elementValuePair() {
		ElementValuePairContext _localctx = new ElementValuePairContext(Context, State);
		EnterRule(_localctx, 234, RULE_elementValuePair);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1424;
			Match(Identifier);
			State = 1425;
			Match(ASSIGN);
			State = 1426;
			elementValue();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ElementValueContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ConditionalExpressionContext conditionalExpression() {
			return GetRuleContext<ConditionalExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ElementValueArrayInitializerContext elementValueArrayInitializer() {
			return GetRuleContext<ElementValueArrayInitializerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation() {
			return GetRuleContext<AnnotationContext>(0);
		}
		public ElementValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_elementValue; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterElementValue(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitElementValue(this);
		}
	}

	[RuleVersion(0)]
	public ElementValueContext elementValue() {
		ElementValueContext _localctx = new ElementValueContext(Context, State);
		EnterRule(_localctx, 236, RULE_elementValue);
		try {
			State = 1431;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,144,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1428;
				conditionalExpression();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1429;
				elementValueArrayInitializer();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1430;
				annotation();
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

	public partial class ElementValueArrayInitializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java8Parser.LBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java8Parser.RBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ElementValueListContext elementValueList() {
			return GetRuleContext<ElementValueListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(Java8Parser.COMMA, 0); }
		public ElementValueArrayInitializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_elementValueArrayInitializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterElementValueArrayInitializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitElementValueArrayInitializer(this);
		}
	}

	[RuleVersion(0)]
	public ElementValueArrayInitializerContext elementValueArrayInitializer() {
		ElementValueArrayInitializerContext _localctx = new ElementValueArrayInitializerContext(Context, State);
		EnterRule(_localctx, 238, RULE_elementValueArrayInitializer);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1433;
			Match(LBRACE);
			State = 1435;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN) | (1L << LBRACE))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
				{
				State = 1434;
				elementValueList();
				}
			}

			State = 1438;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==COMMA) {
				{
				State = 1437;
				Match(COMMA);
				}
			}

			State = 1440;
			Match(RBRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ElementValueListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ElementValueContext[] elementValue() {
			return GetRuleContexts<ElementValueContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ElementValueContext elementValue(int i) {
			return GetRuleContext<ElementValueContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java8Parser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(Java8Parser.COMMA, i);
		}
		public ElementValueListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_elementValueList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterElementValueList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitElementValueList(this);
		}
	}

	[RuleVersion(0)]
	public ElementValueListContext elementValueList() {
		ElementValueListContext _localctx = new ElementValueListContext(Context, State);
		EnterRule(_localctx, 240, RULE_elementValueList);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1442;
			elementValue();
			State = 1447;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,147,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1443;
					Match(COMMA);
					State = 1444;
					elementValue();
					}
					} 
				}
				State = 1449;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,147,Context);
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

	public partial class MarkerAnnotationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AT() { return GetToken(Java8Parser.AT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		public MarkerAnnotationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_markerAnnotation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterMarkerAnnotation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitMarkerAnnotation(this);
		}
	}

	[RuleVersion(0)]
	public MarkerAnnotationContext markerAnnotation() {
		MarkerAnnotationContext _localctx = new MarkerAnnotationContext(Context, State);
		EnterRule(_localctx, 242, RULE_markerAnnotation);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1450;
			Match(AT);
			State = 1451;
			typeName();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SingleElementAnnotationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AT() { return GetToken(Java8Parser.AT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ElementValueContext elementValue() {
			return GetRuleContext<ElementValueContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		public SingleElementAnnotationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_singleElementAnnotation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterSingleElementAnnotation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitSingleElementAnnotation(this);
		}
	}

	[RuleVersion(0)]
	public SingleElementAnnotationContext singleElementAnnotation() {
		SingleElementAnnotationContext _localctx = new SingleElementAnnotationContext(Context, State);
		EnterRule(_localctx, 244, RULE_singleElementAnnotation);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1453;
			Match(AT);
			State = 1454;
			typeName();
			State = 1455;
			Match(LPAREN);
			State = 1456;
			elementValue();
			State = 1457;
			Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ArrayInitializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java8Parser.LBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java8Parser.RBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public VariableInitializerListContext variableInitializerList() {
			return GetRuleContext<VariableInitializerListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(Java8Parser.COMMA, 0); }
		public ArrayInitializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_arrayInitializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterArrayInitializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitArrayInitializer(this);
		}
	}

	[RuleVersion(0)]
	public ArrayInitializerContext arrayInitializer() {
		ArrayInitializerContext _localctx = new ArrayInitializerContext(Context, State);
		EnterRule(_localctx, 246, RULE_arrayInitializer);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1459;
			Match(LBRACE);
			State = 1461;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN) | (1L << LBRACE))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
				{
				State = 1460;
				variableInitializerList();
				}
			}

			State = 1464;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==COMMA) {
				{
				State = 1463;
				Match(COMMA);
				}
			}

			State = 1466;
			Match(RBRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class VariableInitializerListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public VariableInitializerContext[] variableInitializer() {
			return GetRuleContexts<VariableInitializerContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableInitializerContext variableInitializer(int i) {
			return GetRuleContext<VariableInitializerContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java8Parser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(Java8Parser.COMMA, i);
		}
		public VariableInitializerListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variableInitializerList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterVariableInitializerList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitVariableInitializerList(this);
		}
	}

	[RuleVersion(0)]
	public VariableInitializerListContext variableInitializerList() {
		VariableInitializerListContext _localctx = new VariableInitializerListContext(Context, State);
		EnterRule(_localctx, 248, RULE_variableInitializerList);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1468;
			variableInitializer();
			State = 1473;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,150,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1469;
					Match(COMMA);
					State = 1470;
					variableInitializer();
					}
					} 
				}
				State = 1475;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,150,Context);
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

	public partial class BlockContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java8Parser.LBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java8Parser.RBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockStatementsContext blockStatements() {
			return GetRuleContext<BlockStatementsContext>(0);
		}
		public BlockContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_block; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterBlock(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitBlock(this);
		}
	}

	[RuleVersion(0)]
	public BlockContext block() {
		BlockContext _localctx = new BlockContext(Context, State);
		EnterRule(_localctx, 250, RULE_block);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1476;
			Match(LBRACE);
			State = 1478;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << ASSERT) | (1L << BOOLEAN) | (1L << BREAK) | (1L << BYTE) | (1L << CHAR) | (1L << CLASS) | (1L << CONTINUE) | (1L << DO) | (1L << DOUBLE) | (1L << ENUM) | (1L << FINAL) | (1L << FLOAT) | (1L << FOR) | (1L << IF) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << RETURN) | (1L << SHORT) | (1L << STATIC) | (1L << STRICTFP) | (1L << SUPER) | (1L << SWITCH) | (1L << SYNCHRONIZED) | (1L << THIS) | (1L << THROW) | (1L << TRY) | (1L << VOID) | (1L << WHILE) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN) | (1L << LBRACE) | (1L << SEMI))) != 0) || ((((_la - 79)) & ~0x3f) == 0 && ((1L << (_la - 79)) & ((1L << (INC - 79)) | (1L << (DEC - 79)) | (1L << (Identifier - 79)) | (1L << (AT - 79)))) != 0)) {
				{
				State = 1477;
				blockStatements();
				}
			}

			State = 1480;
			Match(RBRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BlockStatementsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BlockStatementContext[] blockStatement() {
			return GetRuleContexts<BlockStatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public BlockStatementContext blockStatement(int i) {
			return GetRuleContext<BlockStatementContext>(i);
		}
		public BlockStatementsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_blockStatements; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterBlockStatements(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitBlockStatements(this);
		}
	}

	[RuleVersion(0)]
	public BlockStatementsContext blockStatements() {
		BlockStatementsContext _localctx = new BlockStatementsContext(Context, State);
		EnterRule(_localctx, 252, RULE_blockStatements);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1483;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 1482;
				blockStatement();
				}
				}
				State = 1485;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << ASSERT) | (1L << BOOLEAN) | (1L << BREAK) | (1L << BYTE) | (1L << CHAR) | (1L << CLASS) | (1L << CONTINUE) | (1L << DO) | (1L << DOUBLE) | (1L << ENUM) | (1L << FINAL) | (1L << FLOAT) | (1L << FOR) | (1L << IF) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << RETURN) | (1L << SHORT) | (1L << STATIC) | (1L << STRICTFP) | (1L << SUPER) | (1L << SWITCH) | (1L << SYNCHRONIZED) | (1L << THIS) | (1L << THROW) | (1L << TRY) | (1L << VOID) | (1L << WHILE) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN) | (1L << LBRACE) | (1L << SEMI))) != 0) || ((((_la - 79)) & ~0x3f) == 0 && ((1L << (_la - 79)) & ((1L << (INC - 79)) | (1L << (DEC - 79)) | (1L << (Identifier - 79)) | (1L << (AT - 79)))) != 0) );
			}
		}
		catch (RecognitionException re) {
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
		[System.Diagnostics.DebuggerNonUserCode] public LocalVariableDeclarationStatementContext localVariableDeclarationStatement() {
			return GetRuleContext<LocalVariableDeclarationStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassDeclarationContext classDeclaration() {
			return GetRuleContext<ClassDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		public BlockStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_blockStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterBlockStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitBlockStatement(this);
		}
	}

	[RuleVersion(0)]
	public BlockStatementContext blockStatement() {
		BlockStatementContext _localctx = new BlockStatementContext(Context, State);
		EnterRule(_localctx, 254, RULE_blockStatement);
		try {
			State = 1490;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,153,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1487;
				localVariableDeclarationStatement();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1488;
				classDeclaration();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1489;
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

	public partial class LocalVariableDeclarationStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public LocalVariableDeclarationContext localVariableDeclaration() {
			return GetRuleContext<LocalVariableDeclarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		public LocalVariableDeclarationStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_localVariableDeclarationStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterLocalVariableDeclarationStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitLocalVariableDeclarationStatement(this);
		}
	}

	[RuleVersion(0)]
	public LocalVariableDeclarationStatementContext localVariableDeclarationStatement() {
		LocalVariableDeclarationStatementContext _localctx = new LocalVariableDeclarationStatementContext(Context, State);
		EnterRule(_localctx, 256, RULE_localVariableDeclarationStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1492;
			localVariableDeclaration();
			State = 1493;
			Match(SEMI);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LocalVariableDeclarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnannTypeContext unannType() {
			return GetRuleContext<UnannTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableDeclaratorListContext variableDeclaratorList() {
			return GetRuleContext<VariableDeclaratorListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableModifierContext[] variableModifier() {
			return GetRuleContexts<VariableModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableModifierContext variableModifier(int i) {
			return GetRuleContext<VariableModifierContext>(i);
		}
		public LocalVariableDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_localVariableDeclaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterLocalVariableDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitLocalVariableDeclaration(this);
		}
	}

	[RuleVersion(0)]
	public LocalVariableDeclarationContext localVariableDeclaration() {
		LocalVariableDeclarationContext _localctx = new LocalVariableDeclarationContext(Context, State);
		EnterRule(_localctx, 258, RULE_localVariableDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1498;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==FINAL || _la==AT) {
				{
				{
				State = 1495;
				variableModifier();
				}
				}
				State = 1500;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1501;
			unannType();
			State = 1502;
			variableDeclaratorList();
			}
		}
		catch (RecognitionException re) {
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
		[System.Diagnostics.DebuggerNonUserCode] public StatementWithoutTrailingSubstatementContext statementWithoutTrailingSubstatement() {
			return GetRuleContext<StatementWithoutTrailingSubstatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public LabeledStatementContext labeledStatement() {
			return GetRuleContext<LabeledStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IfThenStatementContext ifThenStatement() {
			return GetRuleContext<IfThenStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IfThenElseStatementContext ifThenElseStatement() {
			return GetRuleContext<IfThenElseStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public WhileStatementContext whileStatement() {
			return GetRuleContext<WhileStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ForStatementContext forStatement() {
			return GetRuleContext<ForStatementContext>(0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 260, RULE_statement);
		try {
			State = 1510;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,155,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1504;
				statementWithoutTrailingSubstatement();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1505;
				labeledStatement();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1506;
				ifThenStatement();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1507;
				ifThenElseStatement();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1508;
				whileStatement();
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 1509;
				forStatement();
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

	public partial class StatementNoShortIfContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StatementWithoutTrailingSubstatementContext statementWithoutTrailingSubstatement() {
			return GetRuleContext<StatementWithoutTrailingSubstatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public LabeledStatementNoShortIfContext labeledStatementNoShortIf() {
			return GetRuleContext<LabeledStatementNoShortIfContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IfThenElseStatementNoShortIfContext ifThenElseStatementNoShortIf() {
			return GetRuleContext<IfThenElseStatementNoShortIfContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public WhileStatementNoShortIfContext whileStatementNoShortIf() {
			return GetRuleContext<WhileStatementNoShortIfContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ForStatementNoShortIfContext forStatementNoShortIf() {
			return GetRuleContext<ForStatementNoShortIfContext>(0);
		}
		public StatementNoShortIfContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statementNoShortIf; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterStatementNoShortIf(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitStatementNoShortIf(this);
		}
	}

	[RuleVersion(0)]
	public StatementNoShortIfContext statementNoShortIf() {
		StatementNoShortIfContext _localctx = new StatementNoShortIfContext(Context, State);
		EnterRule(_localctx, 262, RULE_statementNoShortIf);
		try {
			State = 1517;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,156,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1512;
				statementWithoutTrailingSubstatement();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1513;
				labeledStatementNoShortIf();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1514;
				ifThenElseStatementNoShortIf();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1515;
				whileStatementNoShortIf();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1516;
				forStatementNoShortIf();
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

	public partial class StatementWithoutTrailingSubstatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EmptyStatement_Context emptyStatement_() {
			return GetRuleContext<EmptyStatement_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionStatementContext expressionStatement() {
			return GetRuleContext<ExpressionStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssertStatementContext assertStatement() {
			return GetRuleContext<AssertStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SwitchStatementContext switchStatement() {
			return GetRuleContext<SwitchStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DoStatementContext doStatement() {
			return GetRuleContext<DoStatementContext>(0);
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
		[System.Diagnostics.DebuggerNonUserCode] public SynchronizedStatementContext synchronizedStatement() {
			return GetRuleContext<SynchronizedStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ThrowStatementContext throwStatement() {
			return GetRuleContext<ThrowStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TryStatementContext tryStatement() {
			return GetRuleContext<TryStatementContext>(0);
		}
		public StatementWithoutTrailingSubstatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statementWithoutTrailingSubstatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterStatementWithoutTrailingSubstatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitStatementWithoutTrailingSubstatement(this);
		}
	}

	[RuleVersion(0)]
	public StatementWithoutTrailingSubstatementContext statementWithoutTrailingSubstatement() {
		StatementWithoutTrailingSubstatementContext _localctx = new StatementWithoutTrailingSubstatementContext(Context, State);
		EnterRule(_localctx, 264, RULE_statementWithoutTrailingSubstatement);
		try {
			State = 1531;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case LBRACE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1519;
				block();
				}
				break;
			case SEMI:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1520;
				emptyStatement_();
				}
				break;
			case BOOLEAN:
			case BYTE:
			case CHAR:
			case DOUBLE:
			case FLOAT:
			case INT:
			case LONG:
			case NEW:
			case SHORT:
			case SUPER:
			case THIS:
			case VOID:
			case IntegerLiteral:
			case FloatingPointLiteral:
			case BooleanLiteral:
			case CharacterLiteral:
			case StringLiteral:
			case NullLiteral:
			case LPAREN:
			case INC:
			case DEC:
			case Identifier:
			case AT:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1521;
				expressionStatement();
				}
				break;
			case ASSERT:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1522;
				assertStatement();
				}
				break;
			case SWITCH:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1523;
				switchStatement();
				}
				break;
			case DO:
				EnterOuterAlt(_localctx, 6);
				{
				State = 1524;
				doStatement();
				}
				break;
			case BREAK:
				EnterOuterAlt(_localctx, 7);
				{
				State = 1525;
				breakStatement();
				}
				break;
			case CONTINUE:
				EnterOuterAlt(_localctx, 8);
				{
				State = 1526;
				continueStatement();
				}
				break;
			case RETURN:
				EnterOuterAlt(_localctx, 9);
				{
				State = 1527;
				returnStatement();
				}
				break;
			case SYNCHRONIZED:
				EnterOuterAlt(_localctx, 10);
				{
				State = 1528;
				synchronizedStatement();
				}
				break;
			case THROW:
				EnterOuterAlt(_localctx, 11);
				{
				State = 1529;
				throwStatement();
				}
				break;
			case TRY:
				EnterOuterAlt(_localctx, 12);
				{
				State = 1530;
				tryStatement();
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

	public partial class EmptyStatement_Context : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		public EmptyStatement_Context(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_emptyStatement_; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterEmptyStatement_(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitEmptyStatement_(this);
		}
	}

	[RuleVersion(0)]
	public EmptyStatement_Context emptyStatement_() {
		EmptyStatement_Context _localctx = new EmptyStatement_Context(Context, State);
		EnterRule(_localctx, 266, RULE_emptyStatement_);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1533;
			Match(SEMI);
			}
		}
		catch (RecognitionException re) {
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
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(Java8Parser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		public LabeledStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_labeledStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterLabeledStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitLabeledStatement(this);
		}
	}

	[RuleVersion(0)]
	public LabeledStatementContext labeledStatement() {
		LabeledStatementContext _localctx = new LabeledStatementContext(Context, State);
		EnterRule(_localctx, 268, RULE_labeledStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1535;
			Match(Identifier);
			State = 1536;
			Match(COLON);
			State = 1537;
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

	public partial class LabeledStatementNoShortIfContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(Java8Parser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementNoShortIfContext statementNoShortIf() {
			return GetRuleContext<StatementNoShortIfContext>(0);
		}
		public LabeledStatementNoShortIfContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_labeledStatementNoShortIf; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterLabeledStatementNoShortIf(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitLabeledStatementNoShortIf(this);
		}
	}

	[RuleVersion(0)]
	public LabeledStatementNoShortIfContext labeledStatementNoShortIf() {
		LabeledStatementNoShortIfContext _localctx = new LabeledStatementNoShortIfContext(Context, State);
		EnterRule(_localctx, 270, RULE_labeledStatementNoShortIf);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1539;
			Match(Identifier);
			State = 1540;
			Match(COLON);
			State = 1541;
			statementNoShortIf();
			}
		}
		catch (RecognitionException re) {
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
		[System.Diagnostics.DebuggerNonUserCode] public StatementExpressionContext statementExpression() {
			return GetRuleContext<StatementExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		public ExpressionStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expressionStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterExpressionStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitExpressionStatement(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionStatementContext expressionStatement() {
		ExpressionStatementContext _localctx = new ExpressionStatementContext(Context, State);
		EnterRule(_localctx, 272, RULE_expressionStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1543;
			statementExpression();
			State = 1544;
			Match(SEMI);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentContext assignment() {
			return GetRuleContext<AssignmentContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PreIncrementExpressionContext preIncrementExpression() {
			return GetRuleContext<PreIncrementExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PreDecrementExpressionContext preDecrementExpression() {
			return GetRuleContext<PreDecrementExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PostIncrementExpressionContext postIncrementExpression() {
			return GetRuleContext<PostIncrementExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PostDecrementExpressionContext postDecrementExpression() {
			return GetRuleContext<PostDecrementExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodInvocationContext methodInvocation() {
			return GetRuleContext<MethodInvocationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassInstanceCreationExpressionContext classInstanceCreationExpression() {
			return GetRuleContext<ClassInstanceCreationExpressionContext>(0);
		}
		public StatementExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statementExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterStatementExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitStatementExpression(this);
		}
	}

	[RuleVersion(0)]
	public StatementExpressionContext statementExpression() {
		StatementExpressionContext _localctx = new StatementExpressionContext(Context, State);
		EnterRule(_localctx, 274, RULE_statementExpression);
		try {
			State = 1553;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,158,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1546;
				assignment();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1547;
				preIncrementExpression();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1548;
				preDecrementExpression();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1549;
				postIncrementExpression();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1550;
				postDecrementExpression();
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 1551;
				methodInvocation();
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 1552;
				classInstanceCreationExpression();
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

	public partial class IfThenStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IF() { return GetToken(Java8Parser.IF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		public IfThenStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ifThenStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterIfThenStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitIfThenStatement(this);
		}
	}

	[RuleVersion(0)]
	public IfThenStatementContext ifThenStatement() {
		IfThenStatementContext _localctx = new IfThenStatementContext(Context, State);
		EnterRule(_localctx, 276, RULE_ifThenStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1555;
			Match(IF);
			State = 1556;
			Match(LPAREN);
			State = 1557;
			expression();
			State = 1558;
			Match(RPAREN);
			State = 1559;
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

	public partial class IfThenElseStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IF() { return GetToken(Java8Parser.IF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementNoShortIfContext statementNoShortIf() {
			return GetRuleContext<StatementNoShortIfContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ELSE() { return GetToken(Java8Parser.ELSE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		public IfThenElseStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ifThenElseStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterIfThenElseStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitIfThenElseStatement(this);
		}
	}

	[RuleVersion(0)]
	public IfThenElseStatementContext ifThenElseStatement() {
		IfThenElseStatementContext _localctx = new IfThenElseStatementContext(Context, State);
		EnterRule(_localctx, 278, RULE_ifThenElseStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1561;
			Match(IF);
			State = 1562;
			Match(LPAREN);
			State = 1563;
			expression();
			State = 1564;
			Match(RPAREN);
			State = 1565;
			statementNoShortIf();
			State = 1566;
			Match(ELSE);
			State = 1567;
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

	public partial class IfThenElseStatementNoShortIfContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IF() { return GetToken(Java8Parser.IF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementNoShortIfContext[] statementNoShortIf() {
			return GetRuleContexts<StatementNoShortIfContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementNoShortIfContext statementNoShortIf(int i) {
			return GetRuleContext<StatementNoShortIfContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ELSE() { return GetToken(Java8Parser.ELSE, 0); }
		public IfThenElseStatementNoShortIfContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ifThenElseStatementNoShortIf; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterIfThenElseStatementNoShortIf(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitIfThenElseStatementNoShortIf(this);
		}
	}

	[RuleVersion(0)]
	public IfThenElseStatementNoShortIfContext ifThenElseStatementNoShortIf() {
		IfThenElseStatementNoShortIfContext _localctx = new IfThenElseStatementNoShortIfContext(Context, State);
		EnterRule(_localctx, 280, RULE_ifThenElseStatementNoShortIf);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1569;
			Match(IF);
			State = 1570;
			Match(LPAREN);
			State = 1571;
			expression();
			State = 1572;
			Match(RPAREN);
			State = 1573;
			statementNoShortIf();
			State = 1574;
			Match(ELSE);
			State = 1575;
			statementNoShortIf();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AssertStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSERT() { return GetToken(Java8Parser.ASSERT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(Java8Parser.COLON, 0); }
		public AssertStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assertStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterAssertStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitAssertStatement(this);
		}
	}

	[RuleVersion(0)]
	public AssertStatementContext assertStatement() {
		AssertStatementContext _localctx = new AssertStatementContext(Context, State);
		EnterRule(_localctx, 282, RULE_assertStatement);
		try {
			State = 1587;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,159,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1577;
				Match(ASSERT);
				State = 1578;
				expression();
				State = 1579;
				Match(SEMI);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1581;
				Match(ASSERT);
				State = 1582;
				expression();
				State = 1583;
				Match(COLON);
				State = 1584;
				expression();
				State = 1585;
				Match(SEMI);
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

	public partial class SwitchStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SWITCH() { return GetToken(Java8Parser.SWITCH, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public SwitchBlockContext switchBlock() {
			return GetRuleContext<SwitchBlockContext>(0);
		}
		public SwitchStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_switchStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterSwitchStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitSwitchStatement(this);
		}
	}

	[RuleVersion(0)]
	public SwitchStatementContext switchStatement() {
		SwitchStatementContext _localctx = new SwitchStatementContext(Context, State);
		EnterRule(_localctx, 284, RULE_switchStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1589;
			Match(SWITCH);
			State = 1590;
			Match(LPAREN);
			State = 1591;
			expression();
			State = 1592;
			Match(RPAREN);
			State = 1593;
			switchBlock();
			}
		}
		catch (RecognitionException re) {
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
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java8Parser.LBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java8Parser.RBRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public SwitchBlockStatementGroupContext[] switchBlockStatementGroup() {
			return GetRuleContexts<SwitchBlockStatementGroupContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public SwitchBlockStatementGroupContext switchBlockStatementGroup(int i) {
			return GetRuleContext<SwitchBlockStatementGroupContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public SwitchLabelContext[] switchLabel() {
			return GetRuleContexts<SwitchLabelContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public SwitchLabelContext switchLabel(int i) {
			return GetRuleContext<SwitchLabelContext>(i);
		}
		public SwitchBlockContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_switchBlock; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterSwitchBlock(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitSwitchBlock(this);
		}
	}

	[RuleVersion(0)]
	public SwitchBlockContext switchBlock() {
		SwitchBlockContext _localctx = new SwitchBlockContext(Context, State);
		EnterRule(_localctx, 286, RULE_switchBlock);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1595;
			Match(LBRACE);
			State = 1599;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,160,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1596;
					switchBlockStatementGroup();
					}
					} 
				}
				State = 1601;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,160,Context);
			}
			State = 1605;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==CASE || _la==DEFAULT) {
				{
				{
				State = 1602;
				switchLabel();
				}
				}
				State = 1607;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1608;
			Match(RBRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SwitchBlockStatementGroupContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public SwitchLabelsContext switchLabels() {
			return GetRuleContext<SwitchLabelsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BlockStatementsContext blockStatements() {
			return GetRuleContext<BlockStatementsContext>(0);
		}
		public SwitchBlockStatementGroupContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_switchBlockStatementGroup; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterSwitchBlockStatementGroup(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitSwitchBlockStatementGroup(this);
		}
	}

	[RuleVersion(0)]
	public SwitchBlockStatementGroupContext switchBlockStatementGroup() {
		SwitchBlockStatementGroupContext _localctx = new SwitchBlockStatementGroupContext(Context, State);
		EnterRule(_localctx, 288, RULE_switchBlockStatementGroup);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1610;
			switchLabels();
			State = 1611;
			blockStatements();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SwitchLabelsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public SwitchLabelContext[] switchLabel() {
			return GetRuleContexts<SwitchLabelContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public SwitchLabelContext switchLabel(int i) {
			return GetRuleContext<SwitchLabelContext>(i);
		}
		public SwitchLabelsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_switchLabels; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterSwitchLabels(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitSwitchLabels(this);
		}
	}

	[RuleVersion(0)]
	public SwitchLabelsContext switchLabels() {
		SwitchLabelsContext _localctx = new SwitchLabelsContext(Context, State);
		EnterRule(_localctx, 290, RULE_switchLabels);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1613;
			switchLabel();
			State = 1617;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==CASE || _la==DEFAULT) {
				{
				{
				State = 1614;
				switchLabel();
				}
				}
				State = 1619;
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

	public partial class SwitchLabelContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CASE() { return GetToken(Java8Parser.CASE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConstantExpressionContext constantExpression() {
			return GetRuleContext<ConstantExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(Java8Parser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public EnumConstantNameContext enumConstantName() {
			return GetRuleContext<EnumConstantNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFAULT() { return GetToken(Java8Parser.DEFAULT, 0); }
		public SwitchLabelContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_switchLabel; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterSwitchLabel(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitSwitchLabel(this);
		}
	}

	[RuleVersion(0)]
	public SwitchLabelContext switchLabel() {
		SwitchLabelContext _localctx = new SwitchLabelContext(Context, State);
		EnterRule(_localctx, 292, RULE_switchLabel);
		try {
			State = 1630;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,163,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1620;
				Match(CASE);
				State = 1621;
				constantExpression();
				State = 1622;
				Match(COLON);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1624;
				Match(CASE);
				State = 1625;
				enumConstantName();
				State = 1626;
				Match(COLON);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1628;
				Match(DEFAULT);
				State = 1629;
				Match(COLON);
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

	public partial class EnumConstantNameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		public EnumConstantNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enumConstantName; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterEnumConstantName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitEnumConstantName(this);
		}
	}

	[RuleVersion(0)]
	public EnumConstantNameContext enumConstantName() {
		EnumConstantNameContext _localctx = new EnumConstantNameContext(Context, State);
		EnterRule(_localctx, 294, RULE_enumConstantName);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1632;
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

	public partial class WhileStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHILE() { return GetToken(Java8Parser.WHILE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		public WhileStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_whileStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterWhileStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitWhileStatement(this);
		}
	}

	[RuleVersion(0)]
	public WhileStatementContext whileStatement() {
		WhileStatementContext _localctx = new WhileStatementContext(Context, State);
		EnterRule(_localctx, 296, RULE_whileStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1634;
			Match(WHILE);
			State = 1635;
			Match(LPAREN);
			State = 1636;
			expression();
			State = 1637;
			Match(RPAREN);
			State = 1638;
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

	public partial class WhileStatementNoShortIfContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHILE() { return GetToken(Java8Parser.WHILE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementNoShortIfContext statementNoShortIf() {
			return GetRuleContext<StatementNoShortIfContext>(0);
		}
		public WhileStatementNoShortIfContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_whileStatementNoShortIf; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterWhileStatementNoShortIf(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitWhileStatementNoShortIf(this);
		}
	}

	[RuleVersion(0)]
	public WhileStatementNoShortIfContext whileStatementNoShortIf() {
		WhileStatementNoShortIfContext _localctx = new WhileStatementNoShortIfContext(Context, State);
		EnterRule(_localctx, 298, RULE_whileStatementNoShortIf);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1640;
			Match(WHILE);
			State = 1641;
			Match(LPAREN);
			State = 1642;
			expression();
			State = 1643;
			Match(RPAREN);
			State = 1644;
			statementNoShortIf();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DoStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DO() { return GetToken(Java8Parser.DO, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHILE() { return GetToken(Java8Parser.WHILE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		public DoStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_doStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterDoStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitDoStatement(this);
		}
	}

	[RuleVersion(0)]
	public DoStatementContext doStatement() {
		DoStatementContext _localctx = new DoStatementContext(Context, State);
		EnterRule(_localctx, 300, RULE_doStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1646;
			Match(DO);
			State = 1647;
			statement();
			State = 1648;
			Match(WHILE);
			State = 1649;
			Match(LPAREN);
			State = 1650;
			expression();
			State = 1651;
			Match(RPAREN);
			State = 1652;
			Match(SEMI);
			}
		}
		catch (RecognitionException re) {
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
		[System.Diagnostics.DebuggerNonUserCode] public BasicForStatementContext basicForStatement() {
			return GetRuleContext<BasicForStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EnhancedForStatementContext enhancedForStatement() {
			return GetRuleContext<EnhancedForStatementContext>(0);
		}
		public ForStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_forStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterForStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitForStatement(this);
		}
	}

	[RuleVersion(0)]
	public ForStatementContext forStatement() {
		ForStatementContext _localctx = new ForStatementContext(Context, State);
		EnterRule(_localctx, 302, RULE_forStatement);
		try {
			State = 1656;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,164,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1654;
				basicForStatement();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1655;
				enhancedForStatement();
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

	public partial class ForStatementNoShortIfContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BasicForStatementNoShortIfContext basicForStatementNoShortIf() {
			return GetRuleContext<BasicForStatementNoShortIfContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EnhancedForStatementNoShortIfContext enhancedForStatementNoShortIf() {
			return GetRuleContext<EnhancedForStatementNoShortIfContext>(0);
		}
		public ForStatementNoShortIfContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_forStatementNoShortIf; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterForStatementNoShortIf(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitForStatementNoShortIf(this);
		}
	}

	[RuleVersion(0)]
	public ForStatementNoShortIfContext forStatementNoShortIf() {
		ForStatementNoShortIfContext _localctx = new ForStatementNoShortIfContext(Context, State);
		EnterRule(_localctx, 304, RULE_forStatementNoShortIf);
		try {
			State = 1660;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,165,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1658;
				basicForStatementNoShortIf();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1659;
				enhancedForStatementNoShortIf();
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

	public partial class BasicForStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOR() { return GetToken(Java8Parser.FOR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SEMI() { return GetTokens(Java8Parser.SEMI); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI(int i) {
			return GetToken(Java8Parser.SEMI, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ForInitContext forInit() {
			return GetRuleContext<ForInitContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ForUpdateContext forUpdate() {
			return GetRuleContext<ForUpdateContext>(0);
		}
		public BasicForStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_basicForStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterBasicForStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitBasicForStatement(this);
		}
	}

	[RuleVersion(0)]
	public BasicForStatementContext basicForStatement() {
		BasicForStatementContext _localctx = new BasicForStatementContext(Context, State);
		EnterRule(_localctx, 306, RULE_basicForStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1662;
			Match(FOR);
			State = 1663;
			Match(LPAREN);
			State = 1665;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FINAL) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 79)) & ~0x3f) == 0 && ((1L << (_la - 79)) & ((1L << (INC - 79)) | (1L << (DEC - 79)) | (1L << (Identifier - 79)) | (1L << (AT - 79)))) != 0)) {
				{
				State = 1664;
				forInit();
				}
			}

			State = 1667;
			Match(SEMI);
			State = 1669;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
				{
				State = 1668;
				expression();
				}
			}

			State = 1671;
			Match(SEMI);
			State = 1673;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 79)) & ~0x3f) == 0 && ((1L << (_la - 79)) & ((1L << (INC - 79)) | (1L << (DEC - 79)) | (1L << (Identifier - 79)) | (1L << (AT - 79)))) != 0)) {
				{
				State = 1672;
				forUpdate();
				}
			}

			State = 1675;
			Match(RPAREN);
			State = 1676;
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

	public partial class BasicForStatementNoShortIfContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOR() { return GetToken(Java8Parser.FOR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SEMI() { return GetTokens(Java8Parser.SEMI); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI(int i) {
			return GetToken(Java8Parser.SEMI, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementNoShortIfContext statementNoShortIf() {
			return GetRuleContext<StatementNoShortIfContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ForInitContext forInit() {
			return GetRuleContext<ForInitContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ForUpdateContext forUpdate() {
			return GetRuleContext<ForUpdateContext>(0);
		}
		public BasicForStatementNoShortIfContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_basicForStatementNoShortIf; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterBasicForStatementNoShortIf(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitBasicForStatementNoShortIf(this);
		}
	}

	[RuleVersion(0)]
	public BasicForStatementNoShortIfContext basicForStatementNoShortIf() {
		BasicForStatementNoShortIfContext _localctx = new BasicForStatementNoShortIfContext(Context, State);
		EnterRule(_localctx, 308, RULE_basicForStatementNoShortIf);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1678;
			Match(FOR);
			State = 1679;
			Match(LPAREN);
			State = 1681;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FINAL) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 79)) & ~0x3f) == 0 && ((1L << (_la - 79)) & ((1L << (INC - 79)) | (1L << (DEC - 79)) | (1L << (Identifier - 79)) | (1L << (AT - 79)))) != 0)) {
				{
				State = 1680;
				forInit();
				}
			}

			State = 1683;
			Match(SEMI);
			State = 1685;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
				{
				State = 1684;
				expression();
				}
			}

			State = 1687;
			Match(SEMI);
			State = 1689;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 79)) & ~0x3f) == 0 && ((1L << (_la - 79)) & ((1L << (INC - 79)) | (1L << (DEC - 79)) | (1L << (Identifier - 79)) | (1L << (AT - 79)))) != 0)) {
				{
				State = 1688;
				forUpdate();
				}
			}

			State = 1691;
			Match(RPAREN);
			State = 1692;
			statementNoShortIf();
			}
		}
		catch (RecognitionException re) {
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
		[System.Diagnostics.DebuggerNonUserCode] public StatementExpressionListContext statementExpressionList() {
			return GetRuleContext<StatementExpressionListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public LocalVariableDeclarationContext localVariableDeclaration() {
			return GetRuleContext<LocalVariableDeclarationContext>(0);
		}
		public ForInitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_forInit; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterForInit(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitForInit(this);
		}
	}

	[RuleVersion(0)]
	public ForInitContext forInit() {
		ForInitContext _localctx = new ForInitContext(Context, State);
		EnterRule(_localctx, 310, RULE_forInit);
		try {
			State = 1696;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,172,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1694;
				statementExpressionList();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1695;
				localVariableDeclaration();
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

	public partial class ForUpdateContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StatementExpressionListContext statementExpressionList() {
			return GetRuleContext<StatementExpressionListContext>(0);
		}
		public ForUpdateContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_forUpdate; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterForUpdate(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitForUpdate(this);
		}
	}

	[RuleVersion(0)]
	public ForUpdateContext forUpdate() {
		ForUpdateContext _localctx = new ForUpdateContext(Context, State);
		EnterRule(_localctx, 312, RULE_forUpdate);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1698;
			statementExpressionList();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementExpressionListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StatementExpressionContext[] statementExpression() {
			return GetRuleContexts<StatementExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementExpressionContext statementExpression(int i) {
			return GetRuleContext<StatementExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java8Parser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(Java8Parser.COMMA, i);
		}
		public StatementExpressionListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statementExpressionList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterStatementExpressionList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitStatementExpressionList(this);
		}
	}

	[RuleVersion(0)]
	public StatementExpressionListContext statementExpressionList() {
		StatementExpressionListContext _localctx = new StatementExpressionListContext(Context, State);
		EnterRule(_localctx, 314, RULE_statementExpressionList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1700;
			statementExpression();
			State = 1705;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1701;
				Match(COMMA);
				State = 1702;
				statementExpression();
				}
				}
				State = 1707;
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

	public partial class EnhancedForStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOR() { return GetToken(Java8Parser.FOR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public UnannTypeContext unannType() {
			return GetRuleContext<UnannTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableDeclaratorIdContext variableDeclaratorId() {
			return GetRuleContext<VariableDeclaratorIdContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(Java8Parser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableModifierContext[] variableModifier() {
			return GetRuleContexts<VariableModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableModifierContext variableModifier(int i) {
			return GetRuleContext<VariableModifierContext>(i);
		}
		public EnhancedForStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enhancedForStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterEnhancedForStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitEnhancedForStatement(this);
		}
	}

	[RuleVersion(0)]
	public EnhancedForStatementContext enhancedForStatement() {
		EnhancedForStatementContext _localctx = new EnhancedForStatementContext(Context, State);
		EnterRule(_localctx, 316, RULE_enhancedForStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1708;
			Match(FOR);
			State = 1709;
			Match(LPAREN);
			State = 1713;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==FINAL || _la==AT) {
				{
				{
				State = 1710;
				variableModifier();
				}
				}
				State = 1715;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1716;
			unannType();
			State = 1717;
			variableDeclaratorId();
			State = 1718;
			Match(COLON);
			State = 1719;
			expression();
			State = 1720;
			Match(RPAREN);
			State = 1721;
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

	public partial class EnhancedForStatementNoShortIfContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOR() { return GetToken(Java8Parser.FOR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public UnannTypeContext unannType() {
			return GetRuleContext<UnannTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableDeclaratorIdContext variableDeclaratorId() {
			return GetRuleContext<VariableDeclaratorIdContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(Java8Parser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementNoShortIfContext statementNoShortIf() {
			return GetRuleContext<StatementNoShortIfContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableModifierContext[] variableModifier() {
			return GetRuleContexts<VariableModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableModifierContext variableModifier(int i) {
			return GetRuleContext<VariableModifierContext>(i);
		}
		public EnhancedForStatementNoShortIfContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enhancedForStatementNoShortIf; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterEnhancedForStatementNoShortIf(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitEnhancedForStatementNoShortIf(this);
		}
	}

	[RuleVersion(0)]
	public EnhancedForStatementNoShortIfContext enhancedForStatementNoShortIf() {
		EnhancedForStatementNoShortIfContext _localctx = new EnhancedForStatementNoShortIfContext(Context, State);
		EnterRule(_localctx, 318, RULE_enhancedForStatementNoShortIf);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1723;
			Match(FOR);
			State = 1724;
			Match(LPAREN);
			State = 1728;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==FINAL || _la==AT) {
				{
				{
				State = 1725;
				variableModifier();
				}
				}
				State = 1730;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1731;
			unannType();
			State = 1732;
			variableDeclaratorId();
			State = 1733;
			Match(COLON);
			State = 1734;
			expression();
			State = 1735;
			Match(RPAREN);
			State = 1736;
			statementNoShortIf();
			}
		}
		catch (RecognitionException re) {
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
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BREAK() { return GetToken(Java8Parser.BREAK, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		public BreakStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_breakStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterBreakStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitBreakStatement(this);
		}
	}

	[RuleVersion(0)]
	public BreakStatementContext breakStatement() {
		BreakStatementContext _localctx = new BreakStatementContext(Context, State);
		EnterRule(_localctx, 320, RULE_breakStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1738;
			Match(BREAK);
			State = 1740;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Identifier) {
				{
				State = 1739;
				Match(Identifier);
				}
			}

			State = 1742;
			Match(SEMI);
			}
		}
		catch (RecognitionException re) {
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
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CONTINUE() { return GetToken(Java8Parser.CONTINUE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		public ContinueStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_continueStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterContinueStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitContinueStatement(this);
		}
	}

	[RuleVersion(0)]
	public ContinueStatementContext continueStatement() {
		ContinueStatementContext _localctx = new ContinueStatementContext(Context, State);
		EnterRule(_localctx, 322, RULE_continueStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1744;
			Match(CONTINUE);
			State = 1746;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==Identifier) {
				{
				State = 1745;
				Match(Identifier);
				}
			}

			State = 1748;
			Match(SEMI);
			}
		}
		catch (RecognitionException re) {
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
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RETURN() { return GetToken(Java8Parser.RETURN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
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
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterReturnStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitReturnStatement(this);
		}
	}

	[RuleVersion(0)]
	public ReturnStatementContext returnStatement() {
		ReturnStatementContext _localctx = new ReturnStatementContext(Context, State);
		EnterRule(_localctx, 324, RULE_returnStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1750;
			Match(RETURN);
			State = 1752;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
				{
				State = 1751;
				expression();
				}
			}

			State = 1754;
			Match(SEMI);
			}
		}
		catch (RecognitionException re) {
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
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THROW() { return GetToken(Java8Parser.THROW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		public ThrowStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_throwStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterThrowStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitThrowStatement(this);
		}
	}

	[RuleVersion(0)]
	public ThrowStatementContext throwStatement() {
		ThrowStatementContext _localctx = new ThrowStatementContext(Context, State);
		EnterRule(_localctx, 326, RULE_throwStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1756;
			Match(THROW);
			State = 1757;
			expression();
			State = 1758;
			Match(SEMI);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SynchronizedStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SYNCHRONIZED() { return GetToken(Java8Parser.SYNCHRONIZED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public SynchronizedStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_synchronizedStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterSynchronizedStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitSynchronizedStatement(this);
		}
	}

	[RuleVersion(0)]
	public SynchronizedStatementContext synchronizedStatement() {
		SynchronizedStatementContext _localctx = new SynchronizedStatementContext(Context, State);
		EnterRule(_localctx, 328, RULE_synchronizedStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1760;
			Match(SYNCHRONIZED);
			State = 1761;
			Match(LPAREN);
			State = 1762;
			expression();
			State = 1763;
			Match(RPAREN);
			State = 1764;
			block();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TryStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRY() { return GetToken(Java8Parser.TRY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CatchesContext catches() {
			return GetRuleContext<CatchesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Finally_Context finally_() {
			return GetRuleContext<Finally_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TryWithResourcesStatementContext tryWithResourcesStatement() {
			return GetRuleContext<TryWithResourcesStatementContext>(0);
		}
		public TryStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tryStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterTryStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitTryStatement(this);
		}
	}

	[RuleVersion(0)]
	public TryStatementContext tryStatement() {
		TryStatementContext _localctx = new TryStatementContext(Context, State);
		EnterRule(_localctx, 330, RULE_tryStatement);
		int _la;
		try {
			State = 1778;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,180,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1766;
				Match(TRY);
				State = 1767;
				block();
				State = 1768;
				catches();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1770;
				Match(TRY);
				State = 1771;
				block();
				State = 1773;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==CATCH) {
					{
					State = 1772;
					catches();
					}
				}

				State = 1775;
				finally_();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1777;
				tryWithResourcesStatement();
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

	public partial class CatchesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public CatchClauseContext[] catchClause() {
			return GetRuleContexts<CatchClauseContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public CatchClauseContext catchClause(int i) {
			return GetRuleContext<CatchClauseContext>(i);
		}
		public CatchesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_catches; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterCatches(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitCatches(this);
		}
	}

	[RuleVersion(0)]
	public CatchesContext catches() {
		CatchesContext _localctx = new CatchesContext(Context, State);
		EnterRule(_localctx, 332, RULE_catches);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1780;
			catchClause();
			State = 1784;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==CATCH) {
				{
				{
				State = 1781;
				catchClause();
				}
				}
				State = 1786;
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

	public partial class CatchClauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CATCH() { return GetToken(Java8Parser.CATCH, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public CatchFormalParameterContext catchFormalParameter() {
			return GetRuleContext<CatchFormalParameterContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public CatchClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_catchClause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterCatchClause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitCatchClause(this);
		}
	}

	[RuleVersion(0)]
	public CatchClauseContext catchClause() {
		CatchClauseContext _localctx = new CatchClauseContext(Context, State);
		EnterRule(_localctx, 334, RULE_catchClause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1787;
			Match(CATCH);
			State = 1788;
			Match(LPAREN);
			State = 1789;
			catchFormalParameter();
			State = 1790;
			Match(RPAREN);
			State = 1791;
			block();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CatchFormalParameterContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public CatchTypeContext catchType() {
			return GetRuleContext<CatchTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableDeclaratorIdContext variableDeclaratorId() {
			return GetRuleContext<VariableDeclaratorIdContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableModifierContext[] variableModifier() {
			return GetRuleContexts<VariableModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableModifierContext variableModifier(int i) {
			return GetRuleContext<VariableModifierContext>(i);
		}
		public CatchFormalParameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_catchFormalParameter; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterCatchFormalParameter(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitCatchFormalParameter(this);
		}
	}

	[RuleVersion(0)]
	public CatchFormalParameterContext catchFormalParameter() {
		CatchFormalParameterContext _localctx = new CatchFormalParameterContext(Context, State);
		EnterRule(_localctx, 336, RULE_catchFormalParameter);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1796;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==FINAL || _la==AT) {
				{
				{
				State = 1793;
				variableModifier();
				}
				}
				State = 1798;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1799;
			catchType();
			State = 1800;
			variableDeclaratorId();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CatchTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnannClassTypeContext unannClassType() {
			return GetRuleContext<UnannClassTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] BITOR() { return GetTokens(Java8Parser.BITOR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BITOR(int i) {
			return GetToken(Java8Parser.BITOR, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassTypeContext[] classType() {
			return GetRuleContexts<ClassTypeContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassTypeContext classType(int i) {
			return GetRuleContext<ClassTypeContext>(i);
		}
		public CatchTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_catchType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterCatchType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitCatchType(this);
		}
	}

	[RuleVersion(0)]
	public CatchTypeContext catchType() {
		CatchTypeContext _localctx = new CatchTypeContext(Context, State);
		EnterRule(_localctx, 338, RULE_catchType);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1802;
			unannClassType();
			State = 1807;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==BITOR) {
				{
				{
				State = 1803;
				Match(BITOR);
				State = 1804;
				classType();
				}
				}
				State = 1809;
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

	public partial class Finally_Context : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FINALLY() { return GetToken(Java8Parser.FINALLY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public Finally_Context(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_finally_; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterFinally_(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitFinally_(this);
		}
	}

	[RuleVersion(0)]
	public Finally_Context finally_() {
		Finally_Context _localctx = new Finally_Context(Context, State);
		EnterRule(_localctx, 340, RULE_finally_);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1810;
			Match(FINALLY);
			State = 1811;
			block();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TryWithResourcesStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRY() { return GetToken(Java8Parser.TRY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ResourceSpecificationContext resourceSpecification() {
			return GetRuleContext<ResourceSpecificationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CatchesContext catches() {
			return GetRuleContext<CatchesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Finally_Context finally_() {
			return GetRuleContext<Finally_Context>(0);
		}
		public TryWithResourcesStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tryWithResourcesStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterTryWithResourcesStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitTryWithResourcesStatement(this);
		}
	}

	[RuleVersion(0)]
	public TryWithResourcesStatementContext tryWithResourcesStatement() {
		TryWithResourcesStatementContext _localctx = new TryWithResourcesStatementContext(Context, State);
		EnterRule(_localctx, 342, RULE_tryWithResourcesStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1813;
			Match(TRY);
			State = 1814;
			resourceSpecification();
			State = 1815;
			block();
			State = 1817;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==CATCH) {
				{
				State = 1816;
				catches();
				}
			}

			State = 1820;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==FINALLY) {
				{
				State = 1819;
				finally_();
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

	public partial class ResourceSpecificationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ResourceListContext resourceList() {
			return GetRuleContext<ResourceListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java8Parser.SEMI, 0); }
		public ResourceSpecificationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_resourceSpecification; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterResourceSpecification(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitResourceSpecification(this);
		}
	}

	[RuleVersion(0)]
	public ResourceSpecificationContext resourceSpecification() {
		ResourceSpecificationContext _localctx = new ResourceSpecificationContext(Context, State);
		EnterRule(_localctx, 344, RULE_resourceSpecification);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1822;
			Match(LPAREN);
			State = 1823;
			resourceList();
			State = 1825;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SEMI) {
				{
				State = 1824;
				Match(SEMI);
				}
			}

			State = 1827;
			Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ResourceListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ResourceContext[] resource() {
			return GetRuleContexts<ResourceContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ResourceContext resource(int i) {
			return GetRuleContext<ResourceContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SEMI() { return GetTokens(Java8Parser.SEMI); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI(int i) {
			return GetToken(Java8Parser.SEMI, i);
		}
		public ResourceListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_resourceList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterResourceList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitResourceList(this);
		}
	}

	[RuleVersion(0)]
	public ResourceListContext resourceList() {
		ResourceListContext _localctx = new ResourceListContext(Context, State);
		EnterRule(_localctx, 346, RULE_resourceList);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1829;
			resource();
			State = 1834;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,187,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1830;
					Match(SEMI);
					State = 1831;
					resource();
					}
					} 
				}
				State = 1836;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,187,Context);
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

	public partial class ResourceContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnannTypeContext unannType() {
			return GetRuleContext<UnannTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableDeclaratorIdContext variableDeclaratorId() {
			return GetRuleContext<VariableDeclaratorIdContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGN() { return GetToken(Java8Parser.ASSIGN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableModifierContext[] variableModifier() {
			return GetRuleContexts<VariableModifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public VariableModifierContext variableModifier(int i) {
			return GetRuleContext<VariableModifierContext>(i);
		}
		public ResourceContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_resource; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterResource(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitResource(this);
		}
	}

	[RuleVersion(0)]
	public ResourceContext resource() {
		ResourceContext _localctx = new ResourceContext(Context, State);
		EnterRule(_localctx, 348, RULE_resource);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1840;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==FINAL || _la==AT) {
				{
				{
				State = 1837;
				variableModifier();
				}
				}
				State = 1842;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1843;
			unannType();
			State = 1844;
			variableDeclaratorId();
			State = 1845;
			Match(ASSIGN);
			State = 1846;
			expression();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PrimaryContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryNoNewArray_lfno_primaryContext primaryNoNewArray_lfno_primary() {
			return GetRuleContext<PrimaryNoNewArray_lfno_primaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArrayCreationExpressionContext arrayCreationExpression() {
			return GetRuleContext<ArrayCreationExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryNoNewArray_lf_primaryContext[] primaryNoNewArray_lf_primary() {
			return GetRuleContexts<PrimaryNoNewArray_lf_primaryContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryNoNewArray_lf_primaryContext primaryNoNewArray_lf_primary(int i) {
			return GetRuleContext<PrimaryNoNewArray_lf_primaryContext>(i);
		}
		public PrimaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primary; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPrimary(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPrimary(this);
		}
	}

	[RuleVersion(0)]
	public PrimaryContext primary() {
		PrimaryContext _localctx = new PrimaryContext(Context, State);
		EnterRule(_localctx, 350, RULE_primary);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1850;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,189,Context) ) {
			case 1:
				{
				State = 1848;
				primaryNoNewArray_lfno_primary();
				}
				break;
			case 2:
				{
				State = 1849;
				arrayCreationExpression();
				}
				break;
			}
			State = 1855;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,190,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1852;
					primaryNoNewArray_lf_primary();
					}
					} 
				}
				State = 1857;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,190,Context);
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

	public partial class PrimaryNoNewArrayContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public LiteralContext literal() {
			return GetRuleContext<LiteralContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLASS() { return GetToken(Java8Parser.CLASS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LBRACK() { return GetTokens(Java8Parser.LBRACK); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACK(int i) {
			return GetToken(Java8Parser.LBRACK, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RBRACK() { return GetTokens(Java8Parser.RBRACK); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACK(int i) {
			return GetToken(Java8Parser.RBRACK, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOID() { return GetToken(Java8Parser.VOID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THIS() { return GetToken(Java8Parser.THIS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ClassInstanceCreationExpressionContext classInstanceCreationExpression() {
			return GetRuleContext<ClassInstanceCreationExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FieldAccessContext fieldAccess() {
			return GetRuleContext<FieldAccessContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArrayAccessContext arrayAccess() {
			return GetRuleContext<ArrayAccessContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodInvocationContext methodInvocation() {
			return GetRuleContext<MethodInvocationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodReferenceContext methodReference() {
			return GetRuleContext<MethodReferenceContext>(0);
		}
		public PrimaryNoNewArrayContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primaryNoNewArray; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPrimaryNoNewArray(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPrimaryNoNewArray(this);
		}
	}

	[RuleVersion(0)]
	public PrimaryNoNewArrayContext primaryNoNewArray() {
		PrimaryNoNewArrayContext _localctx = new PrimaryNoNewArrayContext(Context, State);
		EnterRule(_localctx, 352, RULE_primaryNoNewArray);
		int _la;
		try {
			State = 1887;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,192,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1858;
				literal();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1859;
				typeName();
				State = 1864;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==LBRACK) {
					{
					{
					State = 1860;
					Match(LBRACK);
					State = 1861;
					Match(RBRACK);
					}
					}
					State = 1866;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 1867;
				Match(DOT);
				State = 1868;
				Match(CLASS);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1870;
				Match(VOID);
				State = 1871;
				Match(DOT);
				State = 1872;
				Match(CLASS);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1873;
				Match(THIS);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1874;
				typeName();
				State = 1875;
				Match(DOT);
				State = 1876;
				Match(THIS);
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 1878;
				Match(LPAREN);
				State = 1879;
				expression();
				State = 1880;
				Match(RPAREN);
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 1882;
				classInstanceCreationExpression();
				}
				break;
			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 1883;
				fieldAccess();
				}
				break;
			case 9:
				EnterOuterAlt(_localctx, 9);
				{
				State = 1884;
				arrayAccess();
				}
				break;
			case 10:
				EnterOuterAlt(_localctx, 10);
				{
				State = 1885;
				methodInvocation();
				}
				break;
			case 11:
				EnterOuterAlt(_localctx, 11);
				{
				State = 1886;
				methodReference();
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

	public partial class PrimaryNoNewArray_lf_arrayAccessContext : ParserRuleContext {
		public PrimaryNoNewArray_lf_arrayAccessContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primaryNoNewArray_lf_arrayAccess; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPrimaryNoNewArray_lf_arrayAccess(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPrimaryNoNewArray_lf_arrayAccess(this);
		}
	}

	[RuleVersion(0)]
	public PrimaryNoNewArray_lf_arrayAccessContext primaryNoNewArray_lf_arrayAccess() {
		PrimaryNoNewArray_lf_arrayAccessContext _localctx = new PrimaryNoNewArray_lf_arrayAccessContext(Context, State);
		EnterRule(_localctx, 354, RULE_primaryNoNewArray_lf_arrayAccess);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PrimaryNoNewArray_lfno_arrayAccessContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public LiteralContext literal() {
			return GetRuleContext<LiteralContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLASS() { return GetToken(Java8Parser.CLASS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LBRACK() { return GetTokens(Java8Parser.LBRACK); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACK(int i) {
			return GetToken(Java8Parser.LBRACK, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RBRACK() { return GetTokens(Java8Parser.RBRACK); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACK(int i) {
			return GetToken(Java8Parser.RBRACK, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOID() { return GetToken(Java8Parser.VOID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THIS() { return GetToken(Java8Parser.THIS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ClassInstanceCreationExpressionContext classInstanceCreationExpression() {
			return GetRuleContext<ClassInstanceCreationExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FieldAccessContext fieldAccess() {
			return GetRuleContext<FieldAccessContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodInvocationContext methodInvocation() {
			return GetRuleContext<MethodInvocationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodReferenceContext methodReference() {
			return GetRuleContext<MethodReferenceContext>(0);
		}
		public PrimaryNoNewArray_lfno_arrayAccessContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primaryNoNewArray_lfno_arrayAccess; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPrimaryNoNewArray_lfno_arrayAccess(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPrimaryNoNewArray_lfno_arrayAccess(this);
		}
	}

	[RuleVersion(0)]
	public PrimaryNoNewArray_lfno_arrayAccessContext primaryNoNewArray_lfno_arrayAccess() {
		PrimaryNoNewArray_lfno_arrayAccessContext _localctx = new PrimaryNoNewArray_lfno_arrayAccessContext(Context, State);
		EnterRule(_localctx, 356, RULE_primaryNoNewArray_lfno_arrayAccess);
		int _la;
		try {
			State = 1919;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,194,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1891;
				literal();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1892;
				typeName();
				State = 1897;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==LBRACK) {
					{
					{
					State = 1893;
					Match(LBRACK);
					State = 1894;
					Match(RBRACK);
					}
					}
					State = 1899;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 1900;
				Match(DOT);
				State = 1901;
				Match(CLASS);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1903;
				Match(VOID);
				State = 1904;
				Match(DOT);
				State = 1905;
				Match(CLASS);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1906;
				Match(THIS);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1907;
				typeName();
				State = 1908;
				Match(DOT);
				State = 1909;
				Match(THIS);
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 1911;
				Match(LPAREN);
				State = 1912;
				expression();
				State = 1913;
				Match(RPAREN);
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 1915;
				classInstanceCreationExpression();
				}
				break;
			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 1916;
				fieldAccess();
				}
				break;
			case 9:
				EnterOuterAlt(_localctx, 9);
				{
				State = 1917;
				methodInvocation();
				}
				break;
			case 10:
				EnterOuterAlt(_localctx, 10);
				{
				State = 1918;
				methodReference();
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

	public partial class PrimaryNoNewArray_lf_primaryContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ClassInstanceCreationExpression_lf_primaryContext classInstanceCreationExpression_lf_primary() {
			return GetRuleContext<ClassInstanceCreationExpression_lf_primaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FieldAccess_lf_primaryContext fieldAccess_lf_primary() {
			return GetRuleContext<FieldAccess_lf_primaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArrayAccess_lf_primaryContext arrayAccess_lf_primary() {
			return GetRuleContext<ArrayAccess_lf_primaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodInvocation_lf_primaryContext methodInvocation_lf_primary() {
			return GetRuleContext<MethodInvocation_lf_primaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodReference_lf_primaryContext methodReference_lf_primary() {
			return GetRuleContext<MethodReference_lf_primaryContext>(0);
		}
		public PrimaryNoNewArray_lf_primaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primaryNoNewArray_lf_primary; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPrimaryNoNewArray_lf_primary(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPrimaryNoNewArray_lf_primary(this);
		}
	}

	[RuleVersion(0)]
	public PrimaryNoNewArray_lf_primaryContext primaryNoNewArray_lf_primary() {
		PrimaryNoNewArray_lf_primaryContext _localctx = new PrimaryNoNewArray_lf_primaryContext(Context, State);
		EnterRule(_localctx, 358, RULE_primaryNoNewArray_lf_primary);
		try {
			State = 1926;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,195,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1921;
				classInstanceCreationExpression_lf_primary();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1922;
				fieldAccess_lf_primary();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1923;
				arrayAccess_lf_primary();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1924;
				methodInvocation_lf_primary();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1925;
				methodReference_lf_primary();
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

	public partial class PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext : ParserRuleContext {
		public PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary(this);
		}
	}

	[RuleVersion(0)]
	public PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary() {
		PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext _localctx = new PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext(Context, State);
		EnterRule(_localctx, 360, RULE_primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ClassInstanceCreationExpression_lf_primaryContext classInstanceCreationExpression_lf_primary() {
			return GetRuleContext<ClassInstanceCreationExpression_lf_primaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FieldAccess_lf_primaryContext fieldAccess_lf_primary() {
			return GetRuleContext<FieldAccess_lf_primaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodInvocation_lf_primaryContext methodInvocation_lf_primary() {
			return GetRuleContext<MethodInvocation_lf_primaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodReference_lf_primaryContext methodReference_lf_primary() {
			return GetRuleContext<MethodReference_lf_primaryContext>(0);
		}
		public PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary(this);
		}
	}

	[RuleVersion(0)]
	public PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary() {
		PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext _localctx = new PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext(Context, State);
		EnterRule(_localctx, 362, RULE_primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary);
		try {
			State = 1934;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,196,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1930;
				classInstanceCreationExpression_lf_primary();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1931;
				fieldAccess_lf_primary();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1932;
				methodInvocation_lf_primary();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1933;
				methodReference_lf_primary();
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

	public partial class PrimaryNoNewArray_lfno_primaryContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public LiteralContext literal() {
			return GetRuleContext<LiteralContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLASS() { return GetToken(Java8Parser.CLASS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LBRACK() { return GetTokens(Java8Parser.LBRACK); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACK(int i) {
			return GetToken(Java8Parser.LBRACK, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RBRACK() { return GetTokens(Java8Parser.RBRACK); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACK(int i) {
			return GetToken(Java8Parser.RBRACK, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnannPrimitiveTypeContext unannPrimitiveType() {
			return GetRuleContext<UnannPrimitiveTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOID() { return GetToken(Java8Parser.VOID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THIS() { return GetToken(Java8Parser.THIS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ClassInstanceCreationExpression_lfno_primaryContext classInstanceCreationExpression_lfno_primary() {
			return GetRuleContext<ClassInstanceCreationExpression_lfno_primaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FieldAccess_lfno_primaryContext fieldAccess_lfno_primary() {
			return GetRuleContext<FieldAccess_lfno_primaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArrayAccess_lfno_primaryContext arrayAccess_lfno_primary() {
			return GetRuleContext<ArrayAccess_lfno_primaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodInvocation_lfno_primaryContext methodInvocation_lfno_primary() {
			return GetRuleContext<MethodInvocation_lfno_primaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodReference_lfno_primaryContext methodReference_lfno_primary() {
			return GetRuleContext<MethodReference_lfno_primaryContext>(0);
		}
		public PrimaryNoNewArray_lfno_primaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primaryNoNewArray_lfno_primary; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPrimaryNoNewArray_lfno_primary(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPrimaryNoNewArray_lfno_primary(this);
		}
	}

	[RuleVersion(0)]
	public PrimaryNoNewArray_lfno_primaryContext primaryNoNewArray_lfno_primary() {
		PrimaryNoNewArray_lfno_primaryContext _localctx = new PrimaryNoNewArray_lfno_primaryContext(Context, State);
		EnterRule(_localctx, 364, RULE_primaryNoNewArray_lfno_primary);
		int _la;
		try {
			State = 1976;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,199,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1936;
				literal();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1937;
				typeName();
				State = 1942;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==LBRACK) {
					{
					{
					State = 1938;
					Match(LBRACK);
					State = 1939;
					Match(RBRACK);
					}
					}
					State = 1944;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 1945;
				Match(DOT);
				State = 1946;
				Match(CLASS);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1948;
				unannPrimitiveType();
				State = 1953;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==LBRACK) {
					{
					{
					State = 1949;
					Match(LBRACK);
					State = 1950;
					Match(RBRACK);
					}
					}
					State = 1955;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 1956;
				Match(DOT);
				State = 1957;
				Match(CLASS);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1959;
				Match(VOID);
				State = 1960;
				Match(DOT);
				State = 1961;
				Match(CLASS);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1962;
				Match(THIS);
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 1963;
				typeName();
				State = 1964;
				Match(DOT);
				State = 1965;
				Match(THIS);
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 1967;
				Match(LPAREN);
				State = 1968;
				expression();
				State = 1969;
				Match(RPAREN);
				}
				break;
			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 1971;
				classInstanceCreationExpression_lfno_primary();
				}
				break;
			case 9:
				EnterOuterAlt(_localctx, 9);
				{
				State = 1972;
				fieldAccess_lfno_primary();
				}
				break;
			case 10:
				EnterOuterAlt(_localctx, 10);
				{
				State = 1973;
				arrayAccess_lfno_primary();
				}
				break;
			case 11:
				EnterOuterAlt(_localctx, 11);
				{
				State = 1974;
				methodInvocation_lfno_primary();
				}
				break;
			case 12:
				EnterOuterAlt(_localctx, 12);
				{
				State = 1975;
				methodReference_lfno_primary();
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

	public partial class PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext : ParserRuleContext {
		public PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary(this);
		}
	}

	[RuleVersion(0)]
	public PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary() {
		PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext _localctx = new PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext(Context, State);
		EnterRule(_localctx, 366, RULE_primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public LiteralContext literal() {
			return GetRuleContext<LiteralContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLASS() { return GetToken(Java8Parser.CLASS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LBRACK() { return GetTokens(Java8Parser.LBRACK); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACK(int i) {
			return GetToken(Java8Parser.LBRACK, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RBRACK() { return GetTokens(Java8Parser.RBRACK); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACK(int i) {
			return GetToken(Java8Parser.RBRACK, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnannPrimitiveTypeContext unannPrimitiveType() {
			return GetRuleContext<UnannPrimitiveTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOID() { return GetToken(Java8Parser.VOID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THIS() { return GetToken(Java8Parser.THIS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ClassInstanceCreationExpression_lfno_primaryContext classInstanceCreationExpression_lfno_primary() {
			return GetRuleContext<ClassInstanceCreationExpression_lfno_primaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FieldAccess_lfno_primaryContext fieldAccess_lfno_primary() {
			return GetRuleContext<FieldAccess_lfno_primaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodInvocation_lfno_primaryContext methodInvocation_lfno_primary() {
			return GetRuleContext<MethodInvocation_lfno_primaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MethodReference_lfno_primaryContext methodReference_lfno_primary() {
			return GetRuleContext<MethodReference_lfno_primaryContext>(0);
		}
		public PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary(this);
		}
	}

	[RuleVersion(0)]
	public PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary() {
		PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext _localctx = new PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext(Context, State);
		EnterRule(_localctx, 368, RULE_primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary);
		int _la;
		try {
			State = 2019;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,202,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1980;
				literal();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1981;
				typeName();
				State = 1986;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==LBRACK) {
					{
					{
					State = 1982;
					Match(LBRACK);
					State = 1983;
					Match(RBRACK);
					}
					}
					State = 1988;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 1989;
				Match(DOT);
				State = 1990;
				Match(CLASS);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1992;
				unannPrimitiveType();
				State = 1997;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==LBRACK) {
					{
					{
					State = 1993;
					Match(LBRACK);
					State = 1994;
					Match(RBRACK);
					}
					}
					State = 1999;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 2000;
				Match(DOT);
				State = 2001;
				Match(CLASS);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 2003;
				Match(VOID);
				State = 2004;
				Match(DOT);
				State = 2005;
				Match(CLASS);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 2006;
				Match(THIS);
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 2007;
				typeName();
				State = 2008;
				Match(DOT);
				State = 2009;
				Match(THIS);
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 2011;
				Match(LPAREN);
				State = 2012;
				expression();
				State = 2013;
				Match(RPAREN);
				}
				break;
			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 2015;
				classInstanceCreationExpression_lfno_primary();
				}
				break;
			case 9:
				EnterOuterAlt(_localctx, 9);
				{
				State = 2016;
				fieldAccess_lfno_primary();
				}
				break;
			case 10:
				EnterOuterAlt(_localctx, 10);
				{
				State = 2017;
				methodInvocation_lfno_primary();
				}
				break;
			case 11:
				EnterOuterAlt(_localctx, 11);
				{
				State = 2018;
				methodReference_lfno_primary();
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

	public partial class ClassInstanceCreationExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEW() { return GetToken(Java8Parser.NEW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Identifier() { return GetTokens(Java8Parser.Identifier); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier(int i) {
			return GetToken(Java8Parser.Identifier, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsContext typeArguments() {
			return GetRuleContext<TypeArgumentsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext[] annotation() {
			return GetRuleContexts<AnnotationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation(int i) {
			return GetRuleContext<AnnotationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DOT() { return GetTokens(Java8Parser.DOT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT(int i) {
			return GetToken(Java8Parser.DOT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsOrDiamondContext typeArgumentsOrDiamond() {
			return GetRuleContext<TypeArgumentsOrDiamondContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentListContext argumentList() {
			return GetRuleContext<ArgumentListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassBodyContext classBody() {
			return GetRuleContext<ClassBodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionNameContext expressionName() {
			return GetRuleContext<ExpressionNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryContext primary() {
			return GetRuleContext<PrimaryContext>(0);
		}
		public ClassInstanceCreationExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classInstanceCreationExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterClassInstanceCreationExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitClassInstanceCreationExpression(this);
		}
	}

	[RuleVersion(0)]
	public ClassInstanceCreationExpressionContext classInstanceCreationExpression() {
		ClassInstanceCreationExpressionContext _localctx = new ClassInstanceCreationExpressionContext(Context, State);
		EnterRule(_localctx, 370, RULE_classInstanceCreationExpression);
		int _la;
		try {
			State = 2104;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,220,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2021;
				Match(NEW);
				State = 2023;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2022;
					typeArguments();
					}
				}

				State = 2028;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==AT) {
					{
					{
					State = 2025;
					annotation();
					}
					}
					State = 2030;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 2031;
				Match(Identifier);
				State = 2042;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==DOT) {
					{
					{
					State = 2032;
					Match(DOT);
					State = 2036;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==AT) {
						{
						{
						State = 2033;
						annotation();
						}
						}
						State = 2038;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					State = 2039;
					Match(Identifier);
					}
					}
					State = 2044;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 2046;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2045;
					typeArgumentsOrDiamond();
					}
				}

				State = 2048;
				Match(LPAREN);
				State = 2050;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 2049;
					argumentList();
					}
				}

				State = 2052;
				Match(RPAREN);
				State = 2054;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LBRACE) {
					{
					State = 2053;
					classBody();
					}
				}

				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2056;
				expressionName();
				State = 2057;
				Match(DOT);
				State = 2058;
				Match(NEW);
				State = 2060;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2059;
					typeArguments();
					}
				}

				State = 2065;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==AT) {
					{
					{
					State = 2062;
					annotation();
					}
					}
					State = 2067;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 2068;
				Match(Identifier);
				State = 2070;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2069;
					typeArgumentsOrDiamond();
					}
				}

				State = 2072;
				Match(LPAREN);
				State = 2074;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 2073;
					argumentList();
					}
				}

				State = 2076;
				Match(RPAREN);
				State = 2078;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LBRACE) {
					{
					State = 2077;
					classBody();
					}
				}

				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2080;
				primary();
				State = 2081;
				Match(DOT);
				State = 2082;
				Match(NEW);
				State = 2084;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2083;
					typeArguments();
					}
				}

				State = 2089;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==AT) {
					{
					{
					State = 2086;
					annotation();
					}
					}
					State = 2091;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 2092;
				Match(Identifier);
				State = 2094;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2093;
					typeArgumentsOrDiamond();
					}
				}

				State = 2096;
				Match(LPAREN);
				State = 2098;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 2097;
					argumentList();
					}
				}

				State = 2100;
				Match(RPAREN);
				State = 2102;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LBRACE) {
					{
					State = 2101;
					classBody();
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

	public partial class ClassInstanceCreationExpression_lf_primaryContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEW() { return GetToken(Java8Parser.NEW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsContext typeArguments() {
			return GetRuleContext<TypeArgumentsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext[] annotation() {
			return GetRuleContexts<AnnotationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation(int i) {
			return GetRuleContext<AnnotationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsOrDiamondContext typeArgumentsOrDiamond() {
			return GetRuleContext<TypeArgumentsOrDiamondContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentListContext argumentList() {
			return GetRuleContext<ArgumentListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassBodyContext classBody() {
			return GetRuleContext<ClassBodyContext>(0);
		}
		public ClassInstanceCreationExpression_lf_primaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classInstanceCreationExpression_lf_primary; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterClassInstanceCreationExpression_lf_primary(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitClassInstanceCreationExpression_lf_primary(this);
		}
	}

	[RuleVersion(0)]
	public ClassInstanceCreationExpression_lf_primaryContext classInstanceCreationExpression_lf_primary() {
		ClassInstanceCreationExpression_lf_primaryContext _localctx = new ClassInstanceCreationExpression_lf_primaryContext(Context, State);
		EnterRule(_localctx, 372, RULE_classInstanceCreationExpression_lf_primary);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2106;
			Match(DOT);
			State = 2107;
			Match(NEW);
			State = 2109;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LT) {
				{
				State = 2108;
				typeArguments();
				}
			}

			State = 2114;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==AT) {
				{
				{
				State = 2111;
				annotation();
				}
				}
				State = 2116;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 2117;
			Match(Identifier);
			State = 2119;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LT) {
				{
				State = 2118;
				typeArgumentsOrDiamond();
				}
			}

			State = 2121;
			Match(LPAREN);
			State = 2123;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
				{
				State = 2122;
				argumentList();
				}
			}

			State = 2125;
			Match(RPAREN);
			State = 2127;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,225,Context) ) {
			case 1:
				{
				State = 2126;
				classBody();
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

	public partial class ClassInstanceCreationExpression_lfno_primaryContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEW() { return GetToken(Java8Parser.NEW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Identifier() { return GetTokens(Java8Parser.Identifier); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier(int i) {
			return GetToken(Java8Parser.Identifier, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsContext typeArguments() {
			return GetRuleContext<TypeArgumentsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext[] annotation() {
			return GetRuleContexts<AnnotationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation(int i) {
			return GetRuleContext<AnnotationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DOT() { return GetTokens(Java8Parser.DOT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT(int i) {
			return GetToken(Java8Parser.DOT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsOrDiamondContext typeArgumentsOrDiamond() {
			return GetRuleContext<TypeArgumentsOrDiamondContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentListContext argumentList() {
			return GetRuleContext<ArgumentListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassBodyContext classBody() {
			return GetRuleContext<ClassBodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionNameContext expressionName() {
			return GetRuleContext<ExpressionNameContext>(0);
		}
		public ClassInstanceCreationExpression_lfno_primaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_classInstanceCreationExpression_lfno_primary; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterClassInstanceCreationExpression_lfno_primary(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitClassInstanceCreationExpression_lfno_primary(this);
		}
	}

	[RuleVersion(0)]
	public ClassInstanceCreationExpression_lfno_primaryContext classInstanceCreationExpression_lfno_primary() {
		ClassInstanceCreationExpression_lfno_primaryContext _localctx = new ClassInstanceCreationExpression_lfno_primaryContext(Context, State);
		EnterRule(_localctx, 374, RULE_classInstanceCreationExpression_lfno_primary);
		int _la;
		try {
			State = 2188;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case NEW:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2129;
				Match(NEW);
				State = 2131;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2130;
					typeArguments();
					}
				}

				State = 2136;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==AT) {
					{
					{
					State = 2133;
					annotation();
					}
					}
					State = 2138;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 2139;
				Match(Identifier);
				State = 2150;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==DOT) {
					{
					{
					State = 2140;
					Match(DOT);
					State = 2144;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==AT) {
						{
						{
						State = 2141;
						annotation();
						}
						}
						State = 2146;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					State = 2147;
					Match(Identifier);
					}
					}
					State = 2152;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 2154;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2153;
					typeArgumentsOrDiamond();
					}
				}

				State = 2156;
				Match(LPAREN);
				State = 2158;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 2157;
					argumentList();
					}
				}

				State = 2160;
				Match(RPAREN);
				State = 2162;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,232,Context) ) {
				case 1:
					{
					State = 2161;
					classBody();
					}
					break;
				}
				}
				break;
			case Identifier:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2164;
				expressionName();
				State = 2165;
				Match(DOT);
				State = 2166;
				Match(NEW);
				State = 2168;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2167;
					typeArguments();
					}
				}

				State = 2173;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==AT) {
					{
					{
					State = 2170;
					annotation();
					}
					}
					State = 2175;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 2176;
				Match(Identifier);
				State = 2178;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2177;
					typeArgumentsOrDiamond();
					}
				}

				State = 2180;
				Match(LPAREN);
				State = 2182;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 2181;
					argumentList();
					}
				}

				State = 2184;
				Match(RPAREN);
				State = 2186;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,237,Context) ) {
				case 1:
					{
					State = 2185;
					classBody();
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

	public partial class TypeArgumentsOrDiamondContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsContext typeArguments() {
			return GetRuleContext<TypeArgumentsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LT() { return GetToken(Java8Parser.LT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT() { return GetToken(Java8Parser.GT, 0); }
		public TypeArgumentsOrDiamondContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typeArgumentsOrDiamond; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterTypeArgumentsOrDiamond(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitTypeArgumentsOrDiamond(this);
		}
	}

	[RuleVersion(0)]
	public TypeArgumentsOrDiamondContext typeArgumentsOrDiamond() {
		TypeArgumentsOrDiamondContext _localctx = new TypeArgumentsOrDiamondContext(Context, State);
		EnterRule(_localctx, 376, RULE_typeArgumentsOrDiamond);
		try {
			State = 2193;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,239,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2190;
				typeArguments();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2191;
				Match(LT);
				State = 2192;
				Match(GT);
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

	public partial class FieldAccessContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryContext primary() {
			return GetRuleContext<PrimaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DOT() { return GetTokens(Java8Parser.DOT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT(int i) {
			return GetToken(Java8Parser.DOT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUPER() { return GetToken(Java8Parser.SUPER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		public FieldAccessContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fieldAccess; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterFieldAccess(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitFieldAccess(this);
		}
	}

	[RuleVersion(0)]
	public FieldAccessContext fieldAccess() {
		FieldAccessContext _localctx = new FieldAccessContext(Context, State);
		EnterRule(_localctx, 378, RULE_fieldAccess);
		try {
			State = 2208;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,240,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2195;
				primary();
				State = 2196;
				Match(DOT);
				State = 2197;
				Match(Identifier);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2199;
				Match(SUPER);
				State = 2200;
				Match(DOT);
				State = 2201;
				Match(Identifier);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2202;
				typeName();
				State = 2203;
				Match(DOT);
				State = 2204;
				Match(SUPER);
				State = 2205;
				Match(DOT);
				State = 2206;
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

	public partial class FieldAccess_lf_primaryContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		public FieldAccess_lf_primaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fieldAccess_lf_primary; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterFieldAccess_lf_primary(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitFieldAccess_lf_primary(this);
		}
	}

	[RuleVersion(0)]
	public FieldAccess_lf_primaryContext fieldAccess_lf_primary() {
		FieldAccess_lf_primaryContext _localctx = new FieldAccess_lf_primaryContext(Context, State);
		EnterRule(_localctx, 380, RULE_fieldAccess_lf_primary);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2210;
			Match(DOT);
			State = 2211;
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

	public partial class FieldAccess_lfno_primaryContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUPER() { return GetToken(Java8Parser.SUPER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DOT() { return GetTokens(Java8Parser.DOT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT(int i) {
			return GetToken(Java8Parser.DOT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		public FieldAccess_lfno_primaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fieldAccess_lfno_primary; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterFieldAccess_lfno_primary(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitFieldAccess_lfno_primary(this);
		}
	}

	[RuleVersion(0)]
	public FieldAccess_lfno_primaryContext fieldAccess_lfno_primary() {
		FieldAccess_lfno_primaryContext _localctx = new FieldAccess_lfno_primaryContext(Context, State);
		EnterRule(_localctx, 382, RULE_fieldAccess_lfno_primary);
		try {
			State = 2222;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case SUPER:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2213;
				Match(SUPER);
				State = 2214;
				Match(DOT);
				State = 2215;
				Match(Identifier);
				}
				break;
			case Identifier:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2216;
				typeName();
				State = 2217;
				Match(DOT);
				State = 2218;
				Match(SUPER);
				State = 2219;
				Match(DOT);
				State = 2220;
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

	public partial class ArrayAccessContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionNameContext expressionName() {
			return GetRuleContext<ExpressionNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LBRACK() { return GetTokens(Java8Parser.LBRACK); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACK(int i) {
			return GetToken(Java8Parser.LBRACK, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RBRACK() { return GetTokens(Java8Parser.RBRACK); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACK(int i) {
			return GetToken(Java8Parser.RBRACK, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryNoNewArray_lfno_arrayAccessContext primaryNoNewArray_lfno_arrayAccess() {
			return GetRuleContext<PrimaryNoNewArray_lfno_arrayAccessContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryNoNewArray_lf_arrayAccessContext[] primaryNoNewArray_lf_arrayAccess() {
			return GetRuleContexts<PrimaryNoNewArray_lf_arrayAccessContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryNoNewArray_lf_arrayAccessContext primaryNoNewArray_lf_arrayAccess(int i) {
			return GetRuleContext<PrimaryNoNewArray_lf_arrayAccessContext>(i);
		}
		public ArrayAccessContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_arrayAccess; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterArrayAccess(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitArrayAccess(this);
		}
	}

	[RuleVersion(0)]
	public ArrayAccessContext arrayAccess() {
		ArrayAccessContext _localctx = new ArrayAccessContext(Context, State);
		EnterRule(_localctx, 384, RULE_arrayAccess);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2234;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,242,Context) ) {
			case 1:
				{
				State = 2224;
				expressionName();
				State = 2225;
				Match(LBRACK);
				State = 2226;
				expression();
				State = 2227;
				Match(RBRACK);
				}
				break;
			case 2:
				{
				State = 2229;
				primaryNoNewArray_lfno_arrayAccess();
				State = 2230;
				Match(LBRACK);
				State = 2231;
				expression();
				State = 2232;
				Match(RBRACK);
				}
				break;
			}
			State = 2243;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==LBRACK) {
				{
				{
				State = 2236;
				primaryNoNewArray_lf_arrayAccess();
				State = 2237;
				Match(LBRACK);
				State = 2238;
				expression();
				State = 2239;
				Match(RBRACK);
				}
				}
				State = 2245;
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

	public partial class ArrayAccess_lf_primaryContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary() {
			return GetRuleContext<PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LBRACK() { return GetTokens(Java8Parser.LBRACK); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACK(int i) {
			return GetToken(Java8Parser.LBRACK, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RBRACK() { return GetTokens(Java8Parser.RBRACK); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACK(int i) {
			return GetToken(Java8Parser.RBRACK, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext[] primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary() {
			return GetRuleContexts<PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary(int i) {
			return GetRuleContext<PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext>(i);
		}
		public ArrayAccess_lf_primaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_arrayAccess_lf_primary; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterArrayAccess_lf_primary(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitArrayAccess_lf_primary(this);
		}
	}

	[RuleVersion(0)]
	public ArrayAccess_lf_primaryContext arrayAccess_lf_primary() {
		ArrayAccess_lf_primaryContext _localctx = new ArrayAccess_lf_primaryContext(Context, State);
		EnterRule(_localctx, 386, RULE_arrayAccess_lf_primary);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 2246;
			primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary();
			State = 2247;
			Match(LBRACK);
			State = 2248;
			expression();
			State = 2249;
			Match(RBRACK);
			}
			State = 2258;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,244,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 2251;
					primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary();
					State = 2252;
					Match(LBRACK);
					State = 2253;
					expression();
					State = 2254;
					Match(RBRACK);
					}
					} 
				}
				State = 2260;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,244,Context);
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

	public partial class ArrayAccess_lfno_primaryContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionNameContext expressionName() {
			return GetRuleContext<ExpressionNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LBRACK() { return GetTokens(Java8Parser.LBRACK); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACK(int i) {
			return GetToken(Java8Parser.LBRACK, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RBRACK() { return GetTokens(Java8Parser.RBRACK); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACK(int i) {
			return GetToken(Java8Parser.RBRACK, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary() {
			return GetRuleContext<PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext[] primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary() {
			return GetRuleContexts<PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary(int i) {
			return GetRuleContext<PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext>(i);
		}
		public ArrayAccess_lfno_primaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_arrayAccess_lfno_primary; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterArrayAccess_lfno_primary(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitArrayAccess_lfno_primary(this);
		}
	}

	[RuleVersion(0)]
	public ArrayAccess_lfno_primaryContext arrayAccess_lfno_primary() {
		ArrayAccess_lfno_primaryContext _localctx = new ArrayAccess_lfno_primaryContext(Context, State);
		EnterRule(_localctx, 388, RULE_arrayAccess_lfno_primary);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 2271;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,245,Context) ) {
			case 1:
				{
				State = 2261;
				expressionName();
				State = 2262;
				Match(LBRACK);
				State = 2263;
				expression();
				State = 2264;
				Match(RBRACK);
				}
				break;
			case 2:
				{
				State = 2266;
				primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary();
				State = 2267;
				Match(LBRACK);
				State = 2268;
				expression();
				State = 2269;
				Match(RBRACK);
				}
				break;
			}
			State = 2280;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,246,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 2273;
					primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary();
					State = 2274;
					Match(LBRACK);
					State = 2275;
					expression();
					State = 2276;
					Match(RBRACK);
					}
					} 
				}
				State = 2282;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,246,Context);
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

	public partial class MethodInvocationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public MethodNameContext methodName() {
			return GetRuleContext<MethodNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentListContext argumentList() {
			return GetRuleContext<ArgumentListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DOT() { return GetTokens(Java8Parser.DOT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT(int i) {
			return GetToken(Java8Parser.DOT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsContext typeArguments() {
			return GetRuleContext<TypeArgumentsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionNameContext expressionName() {
			return GetRuleContext<ExpressionNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryContext primary() {
			return GetRuleContext<PrimaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUPER() { return GetToken(Java8Parser.SUPER, 0); }
		public MethodInvocationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodInvocation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterMethodInvocation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitMethodInvocation(this);
		}
	}

	[RuleVersion(0)]
	public MethodInvocationContext methodInvocation() {
		MethodInvocationContext _localctx = new MethodInvocationContext(Context, State);
		EnterRule(_localctx, 390, RULE_methodInvocation);
		int _la;
		try {
			State = 2351;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,258,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2283;
				methodName();
				State = 2284;
				Match(LPAREN);
				State = 2286;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 2285;
					argumentList();
					}
				}

				State = 2288;
				Match(RPAREN);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2290;
				typeName();
				State = 2291;
				Match(DOT);
				State = 2293;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2292;
					typeArguments();
					}
				}

				State = 2295;
				Match(Identifier);
				State = 2296;
				Match(LPAREN);
				State = 2298;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 2297;
					argumentList();
					}
				}

				State = 2300;
				Match(RPAREN);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2302;
				expressionName();
				State = 2303;
				Match(DOT);
				State = 2305;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2304;
					typeArguments();
					}
				}

				State = 2307;
				Match(Identifier);
				State = 2308;
				Match(LPAREN);
				State = 2310;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 2309;
					argumentList();
					}
				}

				State = 2312;
				Match(RPAREN);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 2314;
				primary();
				State = 2315;
				Match(DOT);
				State = 2317;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2316;
					typeArguments();
					}
				}

				State = 2319;
				Match(Identifier);
				State = 2320;
				Match(LPAREN);
				State = 2322;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 2321;
					argumentList();
					}
				}

				State = 2324;
				Match(RPAREN);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 2326;
				Match(SUPER);
				State = 2327;
				Match(DOT);
				State = 2329;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2328;
					typeArguments();
					}
				}

				State = 2331;
				Match(Identifier);
				State = 2332;
				Match(LPAREN);
				State = 2334;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 2333;
					argumentList();
					}
				}

				State = 2336;
				Match(RPAREN);
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 2337;
				typeName();
				State = 2338;
				Match(DOT);
				State = 2339;
				Match(SUPER);
				State = 2340;
				Match(DOT);
				State = 2342;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2341;
					typeArguments();
					}
				}

				State = 2344;
				Match(Identifier);
				State = 2345;
				Match(LPAREN);
				State = 2347;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 2346;
					argumentList();
					}
				}

				State = 2349;
				Match(RPAREN);
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

	public partial class MethodInvocation_lf_primaryContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsContext typeArguments() {
			return GetRuleContext<TypeArgumentsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentListContext argumentList() {
			return GetRuleContext<ArgumentListContext>(0);
		}
		public MethodInvocation_lf_primaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodInvocation_lf_primary; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterMethodInvocation_lf_primary(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitMethodInvocation_lf_primary(this);
		}
	}

	[RuleVersion(0)]
	public MethodInvocation_lf_primaryContext methodInvocation_lf_primary() {
		MethodInvocation_lf_primaryContext _localctx = new MethodInvocation_lf_primaryContext(Context, State);
		EnterRule(_localctx, 392, RULE_methodInvocation_lf_primary);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2353;
			Match(DOT);
			State = 2355;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LT) {
				{
				State = 2354;
				typeArguments();
				}
			}

			State = 2357;
			Match(Identifier);
			State = 2358;
			Match(LPAREN);
			State = 2360;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
				{
				State = 2359;
				argumentList();
				}
			}

			State = 2362;
			Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MethodInvocation_lfno_primaryContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public MethodNameContext methodName() {
			return GetRuleContext<MethodNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentListContext argumentList() {
			return GetRuleContext<ArgumentListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DOT() { return GetTokens(Java8Parser.DOT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT(int i) {
			return GetToken(Java8Parser.DOT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsContext typeArguments() {
			return GetRuleContext<TypeArgumentsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionNameContext expressionName() {
			return GetRuleContext<ExpressionNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUPER() { return GetToken(Java8Parser.SUPER, 0); }
		public MethodInvocation_lfno_primaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodInvocation_lfno_primary; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterMethodInvocation_lfno_primary(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitMethodInvocation_lfno_primary(this);
		}
	}

	[RuleVersion(0)]
	public MethodInvocation_lfno_primaryContext methodInvocation_lfno_primary() {
		MethodInvocation_lfno_primaryContext _localctx = new MethodInvocation_lfno_primaryContext(Context, State);
		EnterRule(_localctx, 394, RULE_methodInvocation_lfno_primary);
		int _la;
		try {
			State = 2420;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,270,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2364;
				methodName();
				State = 2365;
				Match(LPAREN);
				State = 2367;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 2366;
					argumentList();
					}
				}

				State = 2369;
				Match(RPAREN);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2371;
				typeName();
				State = 2372;
				Match(DOT);
				State = 2374;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2373;
					typeArguments();
					}
				}

				State = 2376;
				Match(Identifier);
				State = 2377;
				Match(LPAREN);
				State = 2379;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 2378;
					argumentList();
					}
				}

				State = 2381;
				Match(RPAREN);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2383;
				expressionName();
				State = 2384;
				Match(DOT);
				State = 2386;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2385;
					typeArguments();
					}
				}

				State = 2388;
				Match(Identifier);
				State = 2389;
				Match(LPAREN);
				State = 2391;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 2390;
					argumentList();
					}
				}

				State = 2393;
				Match(RPAREN);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 2395;
				Match(SUPER);
				State = 2396;
				Match(DOT);
				State = 2398;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2397;
					typeArguments();
					}
				}

				State = 2400;
				Match(Identifier);
				State = 2401;
				Match(LPAREN);
				State = 2403;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 2402;
					argumentList();
					}
				}

				State = 2405;
				Match(RPAREN);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 2406;
				typeName();
				State = 2407;
				Match(DOT);
				State = 2408;
				Match(SUPER);
				State = 2409;
				Match(DOT);
				State = 2411;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2410;
					typeArguments();
					}
				}

				State = 2413;
				Match(Identifier);
				State = 2414;
				Match(LPAREN);
				State = 2416;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral) | (1L << BooleanLiteral) | (1L << CharacterLiteral) | (1L << StringLiteral) | (1L << NullLiteral) | (1L << LPAREN))) != 0) || ((((_la - 69)) & ~0x3f) == 0 && ((1L << (_la - 69)) & ((1L << (BANG - 69)) | (1L << (TILDE - 69)) | (1L << (INC - 69)) | (1L << (DEC - 69)) | (1L << (ADD - 69)) | (1L << (SUB - 69)) | (1L << (Identifier - 69)) | (1L << (AT - 69)))) != 0)) {
					{
					State = 2415;
					argumentList();
					}
				}

				State = 2418;
				Match(RPAREN);
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

	public partial class ArgumentListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java8Parser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(Java8Parser.COMMA, i);
		}
		public ArgumentListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_argumentList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterArgumentList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitArgumentList(this);
		}
	}

	[RuleVersion(0)]
	public ArgumentListContext argumentList() {
		ArgumentListContext _localctx = new ArgumentListContext(Context, State);
		EnterRule(_localctx, 396, RULE_argumentList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2422;
			expression();
			State = 2427;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 2423;
				Match(COMMA);
				State = 2424;
				expression();
				}
				}
				State = 2429;
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

	public partial class MethodReferenceContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionNameContext expressionName() {
			return GetRuleContext<ExpressionNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLONCOLON() { return GetToken(Java8Parser.COLONCOLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsContext typeArguments() {
			return GetRuleContext<TypeArgumentsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ReferenceTypeContext referenceType() {
			return GetRuleContext<ReferenceTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryContext primary() {
			return GetRuleContext<PrimaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUPER() { return GetToken(Java8Parser.SUPER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ClassTypeContext classType() {
			return GetRuleContext<ClassTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEW() { return GetToken(Java8Parser.NEW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ArrayTypeContext arrayType() {
			return GetRuleContext<ArrayTypeContext>(0);
		}
		public MethodReferenceContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodReference; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterMethodReference(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitMethodReference(this);
		}
	}

	[RuleVersion(0)]
	public MethodReferenceContext methodReference() {
		MethodReferenceContext _localctx = new MethodReferenceContext(Context, State);
		EnterRule(_localctx, 398, RULE_methodReference);
		int _la;
		try {
			State = 2477;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,278,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2430;
				expressionName();
				State = 2431;
				Match(COLONCOLON);
				State = 2433;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2432;
					typeArguments();
					}
				}

				State = 2435;
				Match(Identifier);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2437;
				referenceType();
				State = 2438;
				Match(COLONCOLON);
				State = 2440;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2439;
					typeArguments();
					}
				}

				State = 2442;
				Match(Identifier);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2444;
				primary();
				State = 2445;
				Match(COLONCOLON);
				State = 2447;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2446;
					typeArguments();
					}
				}

				State = 2449;
				Match(Identifier);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 2451;
				Match(SUPER);
				State = 2452;
				Match(COLONCOLON);
				State = 2454;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2453;
					typeArguments();
					}
				}

				State = 2456;
				Match(Identifier);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 2457;
				typeName();
				State = 2458;
				Match(DOT);
				State = 2459;
				Match(SUPER);
				State = 2460;
				Match(COLONCOLON);
				State = 2462;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2461;
					typeArguments();
					}
				}

				State = 2464;
				Match(Identifier);
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 2466;
				classType();
				State = 2467;
				Match(COLONCOLON);
				State = 2469;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2468;
					typeArguments();
					}
				}

				State = 2471;
				Match(NEW);
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 2473;
				arrayType();
				State = 2474;
				Match(COLONCOLON);
				State = 2475;
				Match(NEW);
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

	public partial class MethodReference_lf_primaryContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLONCOLON() { return GetToken(Java8Parser.COLONCOLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsContext typeArguments() {
			return GetRuleContext<TypeArgumentsContext>(0);
		}
		public MethodReference_lf_primaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodReference_lf_primary; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterMethodReference_lf_primary(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitMethodReference_lf_primary(this);
		}
	}

	[RuleVersion(0)]
	public MethodReference_lf_primaryContext methodReference_lf_primary() {
		MethodReference_lf_primaryContext _localctx = new MethodReference_lf_primaryContext(Context, State);
		EnterRule(_localctx, 400, RULE_methodReference_lf_primary);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2479;
			Match(COLONCOLON);
			State = 2481;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LT) {
				{
				State = 2480;
				typeArguments();
				}
			}

			State = 2483;
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

	public partial class MethodReference_lfno_primaryContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionNameContext expressionName() {
			return GetRuleContext<ExpressionNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLONCOLON() { return GetToken(Java8Parser.COLONCOLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeArgumentsContext typeArguments() {
			return GetRuleContext<TypeArgumentsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ReferenceTypeContext referenceType() {
			return GetRuleContext<ReferenceTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUPER() { return GetToken(Java8Parser.SUPER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TypeNameContext typeName() {
			return GetRuleContext<TypeNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java8Parser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ClassTypeContext classType() {
			return GetRuleContext<ClassTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEW() { return GetToken(Java8Parser.NEW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ArrayTypeContext arrayType() {
			return GetRuleContext<ArrayTypeContext>(0);
		}
		public MethodReference_lfno_primaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodReference_lfno_primary; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterMethodReference_lfno_primary(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitMethodReference_lfno_primary(this);
		}
	}

	[RuleVersion(0)]
	public MethodReference_lfno_primaryContext methodReference_lfno_primary() {
		MethodReference_lfno_primaryContext _localctx = new MethodReference_lfno_primaryContext(Context, State);
		EnterRule(_localctx, 402, RULE_methodReference_lfno_primary);
		int _la;
		try {
			State = 2525;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,285,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2485;
				expressionName();
				State = 2486;
				Match(COLONCOLON);
				State = 2488;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2487;
					typeArguments();
					}
				}

				State = 2490;
				Match(Identifier);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2492;
				referenceType();
				State = 2493;
				Match(COLONCOLON);
				State = 2495;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2494;
					typeArguments();
					}
				}

				State = 2497;
				Match(Identifier);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2499;
				Match(SUPER);
				State = 2500;
				Match(COLONCOLON);
				State = 2502;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2501;
					typeArguments();
					}
				}

				State = 2504;
				Match(Identifier);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 2505;
				typeName();
				State = 2506;
				Match(DOT);
				State = 2507;
				Match(SUPER);
				State = 2508;
				Match(COLONCOLON);
				State = 2510;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2509;
					typeArguments();
					}
				}

				State = 2512;
				Match(Identifier);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 2514;
				classType();
				State = 2515;
				Match(COLONCOLON);
				State = 2517;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2516;
					typeArguments();
					}
				}

				State = 2519;
				Match(NEW);
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 2521;
				arrayType();
				State = 2522;
				Match(COLONCOLON);
				State = 2523;
				Match(NEW);
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

	public partial class ArrayCreationExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEW() { return GetToken(Java8Parser.NEW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public PrimitiveTypeContext primitiveType() {
			return GetRuleContext<PrimitiveTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DimExprsContext dimExprs() {
			return GetRuleContext<DimExprsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DimsContext dims() {
			return GetRuleContext<DimsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ClassOrInterfaceTypeContext classOrInterfaceType() {
			return GetRuleContext<ClassOrInterfaceTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArrayInitializerContext arrayInitializer() {
			return GetRuleContext<ArrayInitializerContext>(0);
		}
		public ArrayCreationExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_arrayCreationExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterArrayCreationExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitArrayCreationExpression(this);
		}
	}

	[RuleVersion(0)]
	public ArrayCreationExpressionContext arrayCreationExpression() {
		ArrayCreationExpressionContext _localctx = new ArrayCreationExpressionContext(Context, State);
		EnterRule(_localctx, 404, RULE_arrayCreationExpression);
		try {
			State = 2549;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,288,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2527;
				Match(NEW);
				State = 2528;
				primitiveType();
				State = 2529;
				dimExprs();
				State = 2531;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,286,Context) ) {
				case 1:
					{
					State = 2530;
					dims();
					}
					break;
				}
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2533;
				Match(NEW);
				State = 2534;
				classOrInterfaceType();
				State = 2535;
				dimExprs();
				State = 2537;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,287,Context) ) {
				case 1:
					{
					State = 2536;
					dims();
					}
					break;
				}
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2539;
				Match(NEW);
				State = 2540;
				primitiveType();
				State = 2541;
				dims();
				State = 2542;
				arrayInitializer();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 2544;
				Match(NEW);
				State = 2545;
				classOrInterfaceType();
				State = 2546;
				dims();
				State = 2547;
				arrayInitializer();
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

	public partial class DimExprsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public DimExprContext[] dimExpr() {
			return GetRuleContexts<DimExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public DimExprContext dimExpr(int i) {
			return GetRuleContext<DimExprContext>(i);
		}
		public DimExprsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dimExprs; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterDimExprs(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitDimExprs(this);
		}
	}

	[RuleVersion(0)]
	public DimExprsContext dimExprs() {
		DimExprsContext _localctx = new DimExprsContext(Context, State);
		EnterRule(_localctx, 406, RULE_dimExprs);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 2551;
			dimExpr();
			State = 2555;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,289,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 2552;
					dimExpr();
					}
					} 
				}
				State = 2557;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,289,Context);
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

	public partial class DimExprContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACK() { return GetToken(Java8Parser.LBRACK, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACK() { return GetToken(Java8Parser.RBRACK, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext[] annotation() {
			return GetRuleContexts<AnnotationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AnnotationContext annotation(int i) {
			return GetRuleContext<AnnotationContext>(i);
		}
		public DimExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dimExpr; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterDimExpr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitDimExpr(this);
		}
	}

	[RuleVersion(0)]
	public DimExprContext dimExpr() {
		DimExprContext _localctx = new DimExprContext(Context, State);
		EnterRule(_localctx, 408, RULE_dimExpr);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2561;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==AT) {
				{
				{
				State = 2558;
				annotation();
				}
				}
				State = 2563;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 2564;
			Match(LBRACK);
			State = 2565;
			expression();
			State = 2566;
			Match(RBRACK);
			}
		}
		catch (RecognitionException re) {
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
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ConstantExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constantExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterConstantExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitConstantExpression(this);
		}
	}

	[RuleVersion(0)]
	public ConstantExpressionContext constantExpression() {
		ConstantExpressionContext _localctx = new ConstantExpressionContext(Context, State);
		EnterRule(_localctx, 410, RULE_constantExpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2568;
			expression();
			}
		}
		catch (RecognitionException re) {
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
		[System.Diagnostics.DebuggerNonUserCode] public LambdaExpressionContext lambdaExpression() {
			return GetRuleContext<LambdaExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentExpressionContext assignmentExpression() {
			return GetRuleContext<AssignmentExpressionContext>(0);
		}
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitExpression(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		ExpressionContext _localctx = new ExpressionContext(Context, State);
		EnterRule(_localctx, 412, RULE_expression);
		try {
			State = 2572;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,291,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2570;
				lambdaExpression();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2571;
				assignmentExpression();
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

	public partial class LambdaExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public LambdaParametersContext lambdaParameters() {
			return GetRuleContext<LambdaParametersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ARROW() { return GetToken(Java8Parser.ARROW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public LambdaBodyContext lambdaBody() {
			return GetRuleContext<LambdaBodyContext>(0);
		}
		public LambdaExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lambdaExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterLambdaExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitLambdaExpression(this);
		}
	}

	[RuleVersion(0)]
	public LambdaExpressionContext lambdaExpression() {
		LambdaExpressionContext _localctx = new LambdaExpressionContext(Context, State);
		EnterRule(_localctx, 414, RULE_lambdaExpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2574;
			lambdaParameters();
			State = 2575;
			Match(ARROW);
			State = 2576;
			lambdaBody();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LambdaParametersContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java8Parser.Identifier, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public FormalParameterListContext formalParameterList() {
			return GetRuleContext<FormalParameterListContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InferredFormalParameterListContext inferredFormalParameterList() {
			return GetRuleContext<InferredFormalParameterListContext>(0);
		}
		public LambdaParametersContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lambdaParameters; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterLambdaParameters(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitLambdaParameters(this);
		}
	}

	[RuleVersion(0)]
	public LambdaParametersContext lambdaParameters() {
		LambdaParametersContext _localctx = new LambdaParametersContext(Context, State);
		EnterRule(_localctx, 416, RULE_lambdaParameters);
		int _la;
		try {
			State = 2588;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,293,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2578;
				Match(Identifier);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2579;
				Match(LPAREN);
				State = 2581;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FINAL) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << SHORT))) != 0) || _la==Identifier || _la==AT) {
					{
					State = 2580;
					formalParameterList();
					}
				}

				State = 2583;
				Match(RPAREN);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2584;
				Match(LPAREN);
				State = 2585;
				inferredFormalParameterList();
				State = 2586;
				Match(RPAREN);
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

	public partial class InferredFormalParameterListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] Identifier() { return GetTokens(Java8Parser.Identifier); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier(int i) {
			return GetToken(Java8Parser.Identifier, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java8Parser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(Java8Parser.COMMA, i);
		}
		public InferredFormalParameterListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_inferredFormalParameterList; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterInferredFormalParameterList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitInferredFormalParameterList(this);
		}
	}

	[RuleVersion(0)]
	public InferredFormalParameterListContext inferredFormalParameterList() {
		InferredFormalParameterListContext _localctx = new InferredFormalParameterListContext(Context, State);
		EnterRule(_localctx, 418, RULE_inferredFormalParameterList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2590;
			Match(Identifier);
			State = 2595;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 2591;
				Match(COMMA);
				State = 2592;
				Match(Identifier);
				}
				}
				State = 2597;
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

	public partial class LambdaBodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public LambdaBodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lambdaBody; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterLambdaBody(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitLambdaBody(this);
		}
	}

	[RuleVersion(0)]
	public LambdaBodyContext lambdaBody() {
		LambdaBodyContext _localctx = new LambdaBodyContext(Context, State);
		EnterRule(_localctx, 420, RULE_lambdaBody);
		try {
			State = 2600;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case BOOLEAN:
			case BYTE:
			case CHAR:
			case DOUBLE:
			case FLOAT:
			case INT:
			case LONG:
			case NEW:
			case SHORT:
			case SUPER:
			case THIS:
			case VOID:
			case IntegerLiteral:
			case FloatingPointLiteral:
			case BooleanLiteral:
			case CharacterLiteral:
			case StringLiteral:
			case NullLiteral:
			case LPAREN:
			case BANG:
			case TILDE:
			case INC:
			case DEC:
			case ADD:
			case SUB:
			case Identifier:
			case AT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2598;
				expression();
				}
				break;
			case LBRACE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2599;
				block();
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

	public partial class AssignmentExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ConditionalExpressionContext conditionalExpression() {
			return GetRuleContext<ConditionalExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentContext assignment() {
			return GetRuleContext<AssignmentContext>(0);
		}
		public AssignmentExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignmentExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterAssignmentExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitAssignmentExpression(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentExpressionContext assignmentExpression() {
		AssignmentExpressionContext _localctx = new AssignmentExpressionContext(Context, State);
		EnterRule(_localctx, 422, RULE_assignmentExpression);
		try {
			State = 2604;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,296,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2602;
				conditionalExpression();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2603;
				assignment();
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

	public partial class AssignmentContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public LeftHandSideContext leftHandSide() {
			return GetRuleContext<LeftHandSideContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentOperatorContext assignmentOperator() {
			return GetRuleContext<AssignmentOperatorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public AssignmentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignment; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterAssignment(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitAssignment(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentContext assignment() {
		AssignmentContext _localctx = new AssignmentContext(Context, State);
		EnterRule(_localctx, 424, RULE_assignment);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2606;
			leftHandSide();
			State = 2607;
			assignmentOperator();
			State = 2608;
			expression();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LeftHandSideContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionNameContext expressionName() {
			return GetRuleContext<ExpressionNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public FieldAccessContext fieldAccess() {
			return GetRuleContext<FieldAccessContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArrayAccessContext arrayAccess() {
			return GetRuleContext<ArrayAccessContext>(0);
		}
		public LeftHandSideContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_leftHandSide; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterLeftHandSide(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitLeftHandSide(this);
		}
	}

	[RuleVersion(0)]
	public LeftHandSideContext leftHandSide() {
		LeftHandSideContext _localctx = new LeftHandSideContext(Context, State);
		EnterRule(_localctx, 426, RULE_leftHandSide);
		try {
			State = 2613;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,297,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2610;
				expressionName();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2611;
				fieldAccess();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2612;
				arrayAccess();
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
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGN() { return GetToken(Java8Parser.ASSIGN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MUL_ASSIGN() { return GetToken(Java8Parser.MUL_ASSIGN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIV_ASSIGN() { return GetToken(Java8Parser.DIV_ASSIGN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MOD_ASSIGN() { return GetToken(Java8Parser.MOD_ASSIGN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ADD_ASSIGN() { return GetToken(Java8Parser.ADD_ASSIGN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUB_ASSIGN() { return GetToken(Java8Parser.SUB_ASSIGN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LSHIFT_ASSIGN() { return GetToken(Java8Parser.LSHIFT_ASSIGN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RSHIFT_ASSIGN() { return GetToken(Java8Parser.RSHIFT_ASSIGN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode URSHIFT_ASSIGN() { return GetToken(Java8Parser.URSHIFT_ASSIGN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AND_ASSIGN() { return GetToken(Java8Parser.AND_ASSIGN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode XOR_ASSIGN() { return GetToken(Java8Parser.XOR_ASSIGN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OR_ASSIGN() { return GetToken(Java8Parser.OR_ASSIGN, 0); }
		public AssignmentOperatorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignmentOperator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterAssignmentOperator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitAssignmentOperator(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentOperatorContext assignmentOperator() {
		AssignmentOperatorContext _localctx = new AssignmentOperatorContext(Context, State);
		EnterRule(_localctx, 428, RULE_assignmentOperator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2615;
			_la = TokenStream.LA(1);
			if ( !(((((_la - 66)) & ~0x3f) == 0 && ((1L << (_la - 66)) & ((1L << (ASSIGN - 66)) | (1L << (ADD_ASSIGN - 66)) | (1L << (SUB_ASSIGN - 66)) | (1L << (MUL_ASSIGN - 66)) | (1L << (DIV_ASSIGN - 66)) | (1L << (AND_ASSIGN - 66)) | (1L << (OR_ASSIGN - 66)) | (1L << (XOR_ASSIGN - 66)) | (1L << (MOD_ASSIGN - 66)) | (1L << (LSHIFT_ASSIGN - 66)) | (1L << (RSHIFT_ASSIGN - 66)) | (1L << (URSHIFT_ASSIGN - 66)))) != 0)) ) {
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

	public partial class ConditionalExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ConditionalOrExpressionContext conditionalOrExpression() {
			return GetRuleContext<ConditionalOrExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode QUESTION() { return GetToken(Java8Parser.QUESTION, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(Java8Parser.COLON, 0); }
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
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterConditionalExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitConditionalExpression(this);
		}
	}

	[RuleVersion(0)]
	public ConditionalExpressionContext conditionalExpression() {
		ConditionalExpressionContext _localctx = new ConditionalExpressionContext(Context, State);
		EnterRule(_localctx, 430, RULE_conditionalExpression);
		try {
			State = 2624;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,298,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2617;
				conditionalOrExpression(0);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2618;
				conditionalOrExpression(0);
				State = 2619;
				Match(QUESTION);
				State = 2620;
				expression();
				State = 2621;
				Match(COLON);
				State = 2622;
				conditionalExpression();
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

	public partial class ConditionalOrExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ConditionalAndExpressionContext conditionalAndExpression() {
			return GetRuleContext<ConditionalAndExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConditionalOrExpressionContext conditionalOrExpression() {
			return GetRuleContext<ConditionalOrExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OR() { return GetToken(Java8Parser.OR, 0); }
		public ConditionalOrExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_conditionalOrExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterConditionalOrExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitConditionalOrExpression(this);
		}
	}

	[RuleVersion(0)]
	public ConditionalOrExpressionContext conditionalOrExpression() {
		return conditionalOrExpression(0);
	}

	private ConditionalOrExpressionContext conditionalOrExpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ConditionalOrExpressionContext _localctx = new ConditionalOrExpressionContext(Context, _parentState);
		ConditionalOrExpressionContext _prevctx = _localctx;
		int _startState = 432;
		EnterRecursionRule(_localctx, 432, RULE_conditionalOrExpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 2627;
			conditionalAndExpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 2634;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,299,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new ConditionalOrExpressionContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_conditionalOrExpression);
					State = 2629;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 2630;
					Match(OR);
					State = 2631;
					conditionalAndExpression(0);
					}
					} 
				}
				State = 2636;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,299,Context);
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

	public partial class ConditionalAndExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public InclusiveOrExpressionContext inclusiveOrExpression() {
			return GetRuleContext<InclusiveOrExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConditionalAndExpressionContext conditionalAndExpression() {
			return GetRuleContext<ConditionalAndExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AND() { return GetToken(Java8Parser.AND, 0); }
		public ConditionalAndExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_conditionalAndExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterConditionalAndExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitConditionalAndExpression(this);
		}
	}

	[RuleVersion(0)]
	public ConditionalAndExpressionContext conditionalAndExpression() {
		return conditionalAndExpression(0);
	}

	private ConditionalAndExpressionContext conditionalAndExpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ConditionalAndExpressionContext _localctx = new ConditionalAndExpressionContext(Context, _parentState);
		ConditionalAndExpressionContext _prevctx = _localctx;
		int _startState = 434;
		EnterRecursionRule(_localctx, 434, RULE_conditionalAndExpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 2638;
			inclusiveOrExpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 2645;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,300,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new ConditionalAndExpressionContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_conditionalAndExpression);
					State = 2640;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 2641;
					Match(AND);
					State = 2642;
					inclusiveOrExpression(0);
					}
					} 
				}
				State = 2647;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,300,Context);
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

	public partial class InclusiveOrExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExclusiveOrExpressionContext exclusiveOrExpression() {
			return GetRuleContext<ExclusiveOrExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public InclusiveOrExpressionContext inclusiveOrExpression() {
			return GetRuleContext<InclusiveOrExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BITOR() { return GetToken(Java8Parser.BITOR, 0); }
		public InclusiveOrExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_inclusiveOrExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterInclusiveOrExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitInclusiveOrExpression(this);
		}
	}

	[RuleVersion(0)]
	public InclusiveOrExpressionContext inclusiveOrExpression() {
		return inclusiveOrExpression(0);
	}

	private InclusiveOrExpressionContext inclusiveOrExpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		InclusiveOrExpressionContext _localctx = new InclusiveOrExpressionContext(Context, _parentState);
		InclusiveOrExpressionContext _prevctx = _localctx;
		int _startState = 436;
		EnterRecursionRule(_localctx, 436, RULE_inclusiveOrExpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 2649;
			exclusiveOrExpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 2656;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,301,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new InclusiveOrExpressionContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_inclusiveOrExpression);
					State = 2651;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 2652;
					Match(BITOR);
					State = 2653;
					exclusiveOrExpression(0);
					}
					} 
				}
				State = 2658;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,301,Context);
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

	public partial class ExclusiveOrExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AndExpressionContext andExpression() {
			return GetRuleContext<AndExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExclusiveOrExpressionContext exclusiveOrExpression() {
			return GetRuleContext<ExclusiveOrExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CARET() { return GetToken(Java8Parser.CARET, 0); }
		public ExclusiveOrExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exclusiveOrExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterExclusiveOrExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitExclusiveOrExpression(this);
		}
	}

	[RuleVersion(0)]
	public ExclusiveOrExpressionContext exclusiveOrExpression() {
		return exclusiveOrExpression(0);
	}

	private ExclusiveOrExpressionContext exclusiveOrExpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExclusiveOrExpressionContext _localctx = new ExclusiveOrExpressionContext(Context, _parentState);
		ExclusiveOrExpressionContext _prevctx = _localctx;
		int _startState = 438;
		EnterRecursionRule(_localctx, 438, RULE_exclusiveOrExpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 2660;
			andExpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 2667;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,302,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new ExclusiveOrExpressionContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_exclusiveOrExpression);
					State = 2662;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 2663;
					Match(CARET);
					State = 2664;
					andExpression(0);
					}
					} 
				}
				State = 2669;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,302,Context);
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

	public partial class AndExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public EqualityExpressionContext equalityExpression() {
			return GetRuleContext<EqualityExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AndExpressionContext andExpression() {
			return GetRuleContext<AndExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BITAND() { return GetToken(Java8Parser.BITAND, 0); }
		public AndExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_andExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterAndExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitAndExpression(this);
		}
	}

	[RuleVersion(0)]
	public AndExpressionContext andExpression() {
		return andExpression(0);
	}

	private AndExpressionContext andExpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		AndExpressionContext _localctx = new AndExpressionContext(Context, _parentState);
		AndExpressionContext _prevctx = _localctx;
		int _startState = 440;
		EnterRecursionRule(_localctx, 440, RULE_andExpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 2671;
			equalityExpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 2678;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,303,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new AndExpressionContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_andExpression);
					State = 2673;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 2674;
					Match(BITAND);
					State = 2675;
					equalityExpression(0);
					}
					} 
				}
				State = 2680;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,303,Context);
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

	public partial class EqualityExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public RelationalExpressionContext relationalExpression() {
			return GetRuleContext<RelationalExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EqualityExpressionContext equalityExpression() {
			return GetRuleContext<EqualityExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EQUAL() { return GetToken(Java8Parser.EQUAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOTEQUAL() { return GetToken(Java8Parser.NOTEQUAL, 0); }
		public EqualityExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_equalityExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterEqualityExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitEqualityExpression(this);
		}
	}

	[RuleVersion(0)]
	public EqualityExpressionContext equalityExpression() {
		return equalityExpression(0);
	}

	private EqualityExpressionContext equalityExpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		EqualityExpressionContext _localctx = new EqualityExpressionContext(Context, _parentState);
		EqualityExpressionContext _prevctx = _localctx;
		int _startState = 442;
		EnterRecursionRule(_localctx, 442, RULE_equalityExpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 2682;
			relationalExpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 2692;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,305,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 2690;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,304,Context) ) {
					case 1:
						{
						_localctx = new EqualityExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_equalityExpression);
						State = 2684;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 2685;
						Match(EQUAL);
						State = 2686;
						relationalExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new EqualityExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_equalityExpression);
						State = 2687;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 2688;
						Match(NOTEQUAL);
						State = 2689;
						relationalExpression(0);
						}
						break;
					}
					} 
				}
				State = 2694;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,305,Context);
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

	public partial class RelationalExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ShiftExpressionContext shiftExpression() {
			return GetRuleContext<ShiftExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public RelationalExpressionContext relationalExpression() {
			return GetRuleContext<RelationalExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LT() { return GetToken(Java8Parser.LT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT() { return GetToken(Java8Parser.GT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LE() { return GetToken(Java8Parser.LE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GE() { return GetToken(Java8Parser.GE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INSTANCEOF() { return GetToken(Java8Parser.INSTANCEOF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ReferenceTypeContext referenceType() {
			return GetRuleContext<ReferenceTypeContext>(0);
		}
		public RelationalExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_relationalExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterRelationalExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitRelationalExpression(this);
		}
	}

	[RuleVersion(0)]
	public RelationalExpressionContext relationalExpression() {
		return relationalExpression(0);
	}

	private RelationalExpressionContext relationalExpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		RelationalExpressionContext _localctx = new RelationalExpressionContext(Context, _parentState);
		RelationalExpressionContext _prevctx = _localctx;
		int _startState = 444;
		EnterRecursionRule(_localctx, 444, RULE_relationalExpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 2696;
			shiftExpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 2715;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,307,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 2713;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,306,Context) ) {
					case 1:
						{
						_localctx = new RelationalExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_relationalExpression);
						State = 2698;
						if (!(Precpred(Context, 5))) throw new FailedPredicateException(this, "Precpred(Context, 5)");
						State = 2699;
						Match(LT);
						State = 2700;
						shiftExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new RelationalExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_relationalExpression);
						State = 2701;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 2702;
						Match(GT);
						State = 2703;
						shiftExpression(0);
						}
						break;
					case 3:
						{
						_localctx = new RelationalExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_relationalExpression);
						State = 2704;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 2705;
						Match(LE);
						State = 2706;
						shiftExpression(0);
						}
						break;
					case 4:
						{
						_localctx = new RelationalExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_relationalExpression);
						State = 2707;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 2708;
						Match(GE);
						State = 2709;
						shiftExpression(0);
						}
						break;
					case 5:
						{
						_localctx = new RelationalExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_relationalExpression);
						State = 2710;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 2711;
						Match(INSTANCEOF);
						State = 2712;
						referenceType();
						}
						break;
					}
					} 
				}
				State = 2717;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,307,Context);
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

	public partial class ShiftExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AdditiveExpressionContext additiveExpression() {
			return GetRuleContext<AdditiveExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ShiftExpressionContext shiftExpression() {
			return GetRuleContext<ShiftExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LT() { return GetTokens(Java8Parser.LT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LT(int i) {
			return GetToken(Java8Parser.LT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] GT() { return GetTokens(Java8Parser.GT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT(int i) {
			return GetToken(Java8Parser.GT, i);
		}
		public ShiftExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_shiftExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterShiftExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitShiftExpression(this);
		}
	}

	[RuleVersion(0)]
	public ShiftExpressionContext shiftExpression() {
		return shiftExpression(0);
	}

	private ShiftExpressionContext shiftExpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ShiftExpressionContext _localctx = new ShiftExpressionContext(Context, _parentState);
		ShiftExpressionContext _prevctx = _localctx;
		int _startState = 446;
		EnterRecursionRule(_localctx, 446, RULE_shiftExpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 2719;
			additiveExpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 2736;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,309,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 2734;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,308,Context) ) {
					case 1:
						{
						_localctx = new ShiftExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_shiftExpression);
						State = 2721;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 2722;
						Match(LT);
						State = 2723;
						Match(LT);
						State = 2724;
						additiveExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new ShiftExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_shiftExpression);
						State = 2725;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 2726;
						Match(GT);
						State = 2727;
						Match(GT);
						State = 2728;
						additiveExpression(0);
						}
						break;
					case 3:
						{
						_localctx = new ShiftExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_shiftExpression);
						State = 2729;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 2730;
						Match(GT);
						State = 2731;
						Match(GT);
						State = 2732;
						Match(GT);
						State = 2733;
						additiveExpression(0);
						}
						break;
					}
					} 
				}
				State = 2738;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,309,Context);
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

	public partial class AdditiveExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public MultiplicativeExpressionContext multiplicativeExpression() {
			return GetRuleContext<MultiplicativeExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AdditiveExpressionContext additiveExpression() {
			return GetRuleContext<AdditiveExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ADD() { return GetToken(Java8Parser.ADD, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUB() { return GetToken(Java8Parser.SUB, 0); }
		public AdditiveExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_additiveExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterAdditiveExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitAdditiveExpression(this);
		}
	}

	[RuleVersion(0)]
	public AdditiveExpressionContext additiveExpression() {
		return additiveExpression(0);
	}

	private AdditiveExpressionContext additiveExpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		AdditiveExpressionContext _localctx = new AdditiveExpressionContext(Context, _parentState);
		AdditiveExpressionContext _prevctx = _localctx;
		int _startState = 448;
		EnterRecursionRule(_localctx, 448, RULE_additiveExpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 2740;
			multiplicativeExpression(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 2750;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,311,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 2748;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,310,Context) ) {
					case 1:
						{
						_localctx = new AdditiveExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_additiveExpression);
						State = 2742;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 2743;
						Match(ADD);
						State = 2744;
						multiplicativeExpression(0);
						}
						break;
					case 2:
						{
						_localctx = new AdditiveExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_additiveExpression);
						State = 2745;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 2746;
						Match(SUB);
						State = 2747;
						multiplicativeExpression(0);
						}
						break;
					}
					} 
				}
				State = 2752;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,311,Context);
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

	public partial class MultiplicativeExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public UnaryExpressionContext unaryExpression() {
			return GetRuleContext<UnaryExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MultiplicativeExpressionContext multiplicativeExpression() {
			return GetRuleContext<MultiplicativeExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MUL() { return GetToken(Java8Parser.MUL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIV() { return GetToken(Java8Parser.DIV, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MOD() { return GetToken(Java8Parser.MOD, 0); }
		public MultiplicativeExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_multiplicativeExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterMultiplicativeExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitMultiplicativeExpression(this);
		}
	}

	[RuleVersion(0)]
	public MultiplicativeExpressionContext multiplicativeExpression() {
		return multiplicativeExpression(0);
	}

	private MultiplicativeExpressionContext multiplicativeExpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		MultiplicativeExpressionContext _localctx = new MultiplicativeExpressionContext(Context, _parentState);
		MultiplicativeExpressionContext _prevctx = _localctx;
		int _startState = 450;
		EnterRecursionRule(_localctx, 450, RULE_multiplicativeExpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 2754;
			unaryExpression();
			}
			Context.Stop = TokenStream.LT(-1);
			State = 2767;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,313,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 2765;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,312,Context) ) {
					case 1:
						{
						_localctx = new MultiplicativeExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_multiplicativeExpression);
						State = 2756;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 2757;
						Match(MUL);
						State = 2758;
						unaryExpression();
						}
						break;
					case 2:
						{
						_localctx = new MultiplicativeExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_multiplicativeExpression);
						State = 2759;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 2760;
						Match(DIV);
						State = 2761;
						unaryExpression();
						}
						break;
					case 3:
						{
						_localctx = new MultiplicativeExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_multiplicativeExpression);
						State = 2762;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 2763;
						Match(MOD);
						State = 2764;
						unaryExpression();
						}
						break;
					}
					} 
				}
				State = 2769;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,313,Context);
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

	public partial class UnaryExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PreIncrementExpressionContext preIncrementExpression() {
			return GetRuleContext<PreIncrementExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PreDecrementExpressionContext preDecrementExpression() {
			return GetRuleContext<PreDecrementExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ADD() { return GetToken(Java8Parser.ADD, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public UnaryExpressionContext unaryExpression() {
			return GetRuleContext<UnaryExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUB() { return GetToken(Java8Parser.SUB, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public UnaryExpressionNotPlusMinusContext unaryExpressionNotPlusMinus() {
			return GetRuleContext<UnaryExpressionNotPlusMinusContext>(0);
		}
		public UnaryExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unaryExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterUnaryExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitUnaryExpression(this);
		}
	}

	[RuleVersion(0)]
	public UnaryExpressionContext unaryExpression() {
		UnaryExpressionContext _localctx = new UnaryExpressionContext(Context, State);
		EnterRule(_localctx, 452, RULE_unaryExpression);
		try {
			State = 2777;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case INC:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2770;
				preIncrementExpression();
				}
				break;
			case DEC:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2771;
				preDecrementExpression();
				}
				break;
			case ADD:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2772;
				Match(ADD);
				State = 2773;
				unaryExpression();
				}
				break;
			case SUB:
				EnterOuterAlt(_localctx, 4);
				{
				State = 2774;
				Match(SUB);
				State = 2775;
				unaryExpression();
				}
				break;
			case BOOLEAN:
			case BYTE:
			case CHAR:
			case DOUBLE:
			case FLOAT:
			case INT:
			case LONG:
			case NEW:
			case SHORT:
			case SUPER:
			case THIS:
			case VOID:
			case IntegerLiteral:
			case FloatingPointLiteral:
			case BooleanLiteral:
			case CharacterLiteral:
			case StringLiteral:
			case NullLiteral:
			case LPAREN:
			case BANG:
			case TILDE:
			case Identifier:
			case AT:
				EnterOuterAlt(_localctx, 5);
				{
				State = 2776;
				unaryExpressionNotPlusMinus();
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

	public partial class PreIncrementExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INC() { return GetToken(Java8Parser.INC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public UnaryExpressionContext unaryExpression() {
			return GetRuleContext<UnaryExpressionContext>(0);
		}
		public PreIncrementExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_preIncrementExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPreIncrementExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPreIncrementExpression(this);
		}
	}

	[RuleVersion(0)]
	public PreIncrementExpressionContext preIncrementExpression() {
		PreIncrementExpressionContext _localctx = new PreIncrementExpressionContext(Context, State);
		EnterRule(_localctx, 454, RULE_preIncrementExpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2779;
			Match(INC);
			State = 2780;
			unaryExpression();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PreDecrementExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEC() { return GetToken(Java8Parser.DEC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public UnaryExpressionContext unaryExpression() {
			return GetRuleContext<UnaryExpressionContext>(0);
		}
		public PreDecrementExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_preDecrementExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPreDecrementExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPreDecrementExpression(this);
		}
	}

	[RuleVersion(0)]
	public PreDecrementExpressionContext preDecrementExpression() {
		PreDecrementExpressionContext _localctx = new PreDecrementExpressionContext(Context, State);
		EnterRule(_localctx, 456, RULE_preDecrementExpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2782;
			Match(DEC);
			State = 2783;
			unaryExpression();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class UnaryExpressionNotPlusMinusContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PostfixExpressionContext postfixExpression() {
			return GetRuleContext<PostfixExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TILDE() { return GetToken(Java8Parser.TILDE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public UnaryExpressionContext unaryExpression() {
			return GetRuleContext<UnaryExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BANG() { return GetToken(Java8Parser.BANG, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public CastExpressionContext castExpression() {
			return GetRuleContext<CastExpressionContext>(0);
		}
		public UnaryExpressionNotPlusMinusContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unaryExpressionNotPlusMinus; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterUnaryExpressionNotPlusMinus(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitUnaryExpressionNotPlusMinus(this);
		}
	}

	[RuleVersion(0)]
	public UnaryExpressionNotPlusMinusContext unaryExpressionNotPlusMinus() {
		UnaryExpressionNotPlusMinusContext _localctx = new UnaryExpressionNotPlusMinusContext(Context, State);
		EnterRule(_localctx, 458, RULE_unaryExpressionNotPlusMinus);
		try {
			State = 2791;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,315,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2785;
				postfixExpression();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2786;
				Match(TILDE);
				State = 2787;
				unaryExpression();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2788;
				Match(BANG);
				State = 2789;
				unaryExpression();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 2790;
				castExpression();
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

	public partial class PostfixExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PrimaryContext primary() {
			return GetRuleContext<PrimaryContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionNameContext expressionName() {
			return GetRuleContext<ExpressionNameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PostIncrementExpression_lf_postfixExpressionContext[] postIncrementExpression_lf_postfixExpression() {
			return GetRuleContexts<PostIncrementExpression_lf_postfixExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public PostIncrementExpression_lf_postfixExpressionContext postIncrementExpression_lf_postfixExpression(int i) {
			return GetRuleContext<PostIncrementExpression_lf_postfixExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PostDecrementExpression_lf_postfixExpressionContext[] postDecrementExpression_lf_postfixExpression() {
			return GetRuleContexts<PostDecrementExpression_lf_postfixExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public PostDecrementExpression_lf_postfixExpressionContext postDecrementExpression_lf_postfixExpression(int i) {
			return GetRuleContext<PostDecrementExpression_lf_postfixExpressionContext>(i);
		}
		public PostfixExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_postfixExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPostfixExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPostfixExpression(this);
		}
	}

	[RuleVersion(0)]
	public PostfixExpressionContext postfixExpression() {
		PostfixExpressionContext _localctx = new PostfixExpressionContext(Context, State);
		EnterRule(_localctx, 460, RULE_postfixExpression);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 2795;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,316,Context) ) {
			case 1:
				{
				State = 2793;
				primary();
				}
				break;
			case 2:
				{
				State = 2794;
				expressionName();
				}
				break;
			}
			State = 2801;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,318,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					State = 2799;
					ErrorHandler.Sync(this);
					switch (TokenStream.LA(1)) {
					case INC:
						{
						State = 2797;
						postIncrementExpression_lf_postfixExpression();
						}
						break;
					case DEC:
						{
						State = 2798;
						postDecrementExpression_lf_postfixExpression();
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					} 
				}
				State = 2803;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,318,Context);
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

	public partial class PostIncrementExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PostfixExpressionContext postfixExpression() {
			return GetRuleContext<PostfixExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INC() { return GetToken(Java8Parser.INC, 0); }
		public PostIncrementExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_postIncrementExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPostIncrementExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPostIncrementExpression(this);
		}
	}

	[RuleVersion(0)]
	public PostIncrementExpressionContext postIncrementExpression() {
		PostIncrementExpressionContext _localctx = new PostIncrementExpressionContext(Context, State);
		EnterRule(_localctx, 462, RULE_postIncrementExpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2804;
			postfixExpression();
			State = 2805;
			Match(INC);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PostIncrementExpression_lf_postfixExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INC() { return GetToken(Java8Parser.INC, 0); }
		public PostIncrementExpression_lf_postfixExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_postIncrementExpression_lf_postfixExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPostIncrementExpression_lf_postfixExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPostIncrementExpression_lf_postfixExpression(this);
		}
	}

	[RuleVersion(0)]
	public PostIncrementExpression_lf_postfixExpressionContext postIncrementExpression_lf_postfixExpression() {
		PostIncrementExpression_lf_postfixExpressionContext _localctx = new PostIncrementExpression_lf_postfixExpressionContext(Context, State);
		EnterRule(_localctx, 464, RULE_postIncrementExpression_lf_postfixExpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2807;
			Match(INC);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PostDecrementExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public PostfixExpressionContext postfixExpression() {
			return GetRuleContext<PostfixExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEC() { return GetToken(Java8Parser.DEC, 0); }
		public PostDecrementExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_postDecrementExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPostDecrementExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPostDecrementExpression(this);
		}
	}

	[RuleVersion(0)]
	public PostDecrementExpressionContext postDecrementExpression() {
		PostDecrementExpressionContext _localctx = new PostDecrementExpressionContext(Context, State);
		EnterRule(_localctx, 466, RULE_postDecrementExpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2809;
			postfixExpression();
			State = 2810;
			Match(DEC);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PostDecrementExpression_lf_postfixExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEC() { return GetToken(Java8Parser.DEC, 0); }
		public PostDecrementExpression_lf_postfixExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_postDecrementExpression_lf_postfixExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterPostDecrementExpression_lf_postfixExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitPostDecrementExpression_lf_postfixExpression(this);
		}
	}

	[RuleVersion(0)]
	public PostDecrementExpression_lf_postfixExpressionContext postDecrementExpression_lf_postfixExpression() {
		PostDecrementExpression_lf_postfixExpressionContext _localctx = new PostDecrementExpression_lf_postfixExpressionContext(Context, State);
		EnterRule(_localctx, 468, RULE_postDecrementExpression_lf_postfixExpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2812;
			Match(DEC);
			}
		}
		catch (RecognitionException re) {
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
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java8Parser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public PrimitiveTypeContext primitiveType() {
			return GetRuleContext<PrimitiveTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java8Parser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public UnaryExpressionContext unaryExpression() {
			return GetRuleContext<UnaryExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ReferenceTypeContext referenceType() {
			return GetRuleContext<ReferenceTypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public UnaryExpressionNotPlusMinusContext unaryExpressionNotPlusMinus() {
			return GetRuleContext<UnaryExpressionNotPlusMinusContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AdditionalBoundContext[] additionalBound() {
			return GetRuleContexts<AdditionalBoundContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AdditionalBoundContext additionalBound(int i) {
			return GetRuleContext<AdditionalBoundContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public LambdaExpressionContext lambdaExpression() {
			return GetRuleContext<LambdaExpressionContext>(0);
		}
		public CastExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_castExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.EnterCastExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IJava8ParserListener typedListener = listener as IJava8ParserListener;
			if (typedListener != null) typedListener.ExitCastExpression(this);
		}
	}

	[RuleVersion(0)]
	public CastExpressionContext castExpression() {
		CastExpressionContext _localctx = new CastExpressionContext(Context, State);
		EnterRule(_localctx, 470, RULE_castExpression);
		int _la;
		try {
			State = 2841;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,321,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2814;
				Match(LPAREN);
				State = 2815;
				primitiveType();
				State = 2816;
				Match(RPAREN);
				State = 2817;
				unaryExpression();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2819;
				Match(LPAREN);
				State = 2820;
				referenceType();
				State = 2824;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==BITAND) {
					{
					{
					State = 2821;
					additionalBound();
					}
					}
					State = 2826;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 2827;
				Match(RPAREN);
				State = 2828;
				unaryExpressionNotPlusMinus();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2830;
				Match(LPAREN);
				State = 2831;
				referenceType();
				State = 2835;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==BITAND) {
					{
					{
					State = 2832;
					additionalBound();
					}
					}
					State = 2837;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 2838;
				Match(RPAREN);
				State = 2839;
				lambdaExpression();
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

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 25: return packageName_sempred((PackageNameContext)_localctx, predIndex);
		case 27: return packageOrTypeName_sempred((PackageOrTypeNameContext)_localctx, predIndex);
		case 30: return ambiguousName_sempred((AmbiguousNameContext)_localctx, predIndex);
		case 216: return conditionalOrExpression_sempred((ConditionalOrExpressionContext)_localctx, predIndex);
		case 217: return conditionalAndExpression_sempred((ConditionalAndExpressionContext)_localctx, predIndex);
		case 218: return inclusiveOrExpression_sempred((InclusiveOrExpressionContext)_localctx, predIndex);
		case 219: return exclusiveOrExpression_sempred((ExclusiveOrExpressionContext)_localctx, predIndex);
		case 220: return andExpression_sempred((AndExpressionContext)_localctx, predIndex);
		case 221: return equalityExpression_sempred((EqualityExpressionContext)_localctx, predIndex);
		case 222: return relationalExpression_sempred((RelationalExpressionContext)_localctx, predIndex);
		case 223: return shiftExpression_sempred((ShiftExpressionContext)_localctx, predIndex);
		case 224: return additiveExpression_sempred((AdditiveExpressionContext)_localctx, predIndex);
		case 225: return multiplicativeExpression_sempred((MultiplicativeExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool packageName_sempred(PackageNameContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 1);
		}
		return true;
	}
	private bool packageOrTypeName_sempred(PackageOrTypeNameContext _localctx, int predIndex) {
		switch (predIndex) {
		case 1: return Precpred(Context, 1);
		}
		return true;
	}
	private bool ambiguousName_sempred(AmbiguousNameContext _localctx, int predIndex) {
		switch (predIndex) {
		case 2: return Precpred(Context, 1);
		}
		return true;
	}
	private bool conditionalOrExpression_sempred(ConditionalOrExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 3: return Precpred(Context, 1);
		}
		return true;
	}
	private bool conditionalAndExpression_sempred(ConditionalAndExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 4: return Precpred(Context, 1);
		}
		return true;
	}
	private bool inclusiveOrExpression_sempred(InclusiveOrExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 5: return Precpred(Context, 1);
		}
		return true;
	}
	private bool exclusiveOrExpression_sempred(ExclusiveOrExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 6: return Precpred(Context, 1);
		}
		return true;
	}
	private bool andExpression_sempred(AndExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 7: return Precpred(Context, 1);
		}
		return true;
	}
	private bool equalityExpression_sempred(EqualityExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 8: return Precpred(Context, 2);
		case 9: return Precpred(Context, 1);
		}
		return true;
	}
	private bool relationalExpression_sempred(RelationalExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 10: return Precpred(Context, 5);
		case 11: return Precpred(Context, 4);
		case 12: return Precpred(Context, 3);
		case 13: return Precpred(Context, 2);
		case 14: return Precpred(Context, 1);
		}
		return true;
	}
	private bool shiftExpression_sempred(ShiftExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 15: return Precpred(Context, 3);
		case 16: return Precpred(Context, 2);
		case 17: return Precpred(Context, 1);
		}
		return true;
	}
	private bool additiveExpression_sempred(AdditiveExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 18: return Precpred(Context, 2);
		case 19: return Precpred(Context, 1);
		}
		return true;
	}
	private bool multiplicativeExpression_sempred(MultiplicativeExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 20: return Precpred(Context, 3);
		case 21: return Precpred(Context, 2);
		case 22: return Precpred(Context, 1);
		}
		return true;
	}

	private static int[] _serializedATN = {
		4,1,107,2844,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,
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
		2,195,7,195,2,196,7,196,2,197,7,197,2,198,7,198,2,199,7,199,2,200,7,200,
		2,201,7,201,2,202,7,202,2,203,7,203,2,204,7,204,2,205,7,205,2,206,7,206,
		2,207,7,207,2,208,7,208,2,209,7,209,2,210,7,210,2,211,7,211,2,212,7,212,
		2,213,7,213,2,214,7,214,2,215,7,215,2,216,7,216,2,217,7,217,2,218,7,218,
		2,219,7,219,2,220,7,220,2,221,7,221,2,222,7,222,2,223,7,223,2,224,7,224,
		2,225,7,225,2,226,7,226,2,227,7,227,2,228,7,228,2,229,7,229,2,230,7,230,
		2,231,7,231,2,232,7,232,2,233,7,233,2,234,7,234,2,235,7,235,1,0,1,0,1,
		1,5,1,476,8,1,10,1,12,1,479,9,1,1,1,1,1,5,1,483,8,1,10,1,12,1,486,9,1,
		1,1,3,1,489,8,1,1,2,1,2,3,2,493,8,2,1,3,1,3,1,4,1,4,1,5,1,5,1,5,3,5,502,
		8,5,1,6,1,6,3,6,506,8,6,1,6,1,6,5,6,510,8,6,10,6,12,6,513,9,6,1,7,5,7,
		516,8,7,10,7,12,7,519,9,7,1,7,1,7,3,7,523,8,7,1,7,1,7,1,7,5,7,528,8,7,
		10,7,12,7,531,9,7,1,7,1,7,3,7,535,8,7,3,7,537,8,7,1,8,1,8,5,8,541,8,8,
		10,8,12,8,544,9,8,1,8,1,8,3,8,548,8,8,1,9,5,9,551,8,9,10,9,12,9,554,9,
		9,1,9,1,9,3,9,558,8,9,1,10,1,10,1,11,1,11,1,12,1,12,1,13,5,13,567,8,13,
		10,13,12,13,570,9,13,1,13,1,13,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,
		1,14,3,14,583,8,14,1,15,5,15,586,8,15,10,15,12,15,589,9,15,1,15,1,15,1,
		15,5,15,594,8,15,10,15,12,15,597,9,15,1,15,1,15,5,15,601,8,15,10,15,12,
		15,604,9,15,1,16,5,16,607,8,16,10,16,12,16,610,9,16,1,16,1,16,3,16,614,
		8,16,1,17,1,17,1,18,1,18,1,18,1,18,1,18,5,18,623,8,18,10,18,12,18,626,
		9,18,3,18,628,8,18,1,19,1,19,1,19,1,20,1,20,1,20,1,20,1,21,1,21,1,21,5,
		21,640,8,21,10,21,12,21,643,9,21,1,22,1,22,3,22,647,8,22,1,23,5,23,650,
		8,23,10,23,12,23,653,9,23,1,23,1,23,3,23,657,8,23,1,24,1,24,1,24,1,24,
		3,24,663,8,24,1,25,1,25,1,25,1,25,1,25,1,25,5,25,671,8,25,10,25,12,25,
		674,9,25,1,26,1,26,1,26,1,26,1,26,3,26,681,8,26,1,27,1,27,1,27,1,27,1,
		27,1,27,5,27,689,8,27,10,27,12,27,692,9,27,1,28,1,28,1,28,1,28,1,28,3,
		28,699,8,28,1,29,1,29,1,30,1,30,1,30,1,30,1,30,1,30,5,30,709,8,30,10,30,
		12,30,712,9,30,1,31,3,31,715,8,31,1,31,5,31,718,8,31,10,31,12,31,721,9,
		31,1,31,5,31,724,8,31,10,31,12,31,727,9,31,1,31,1,31,1,32,5,32,732,8,32,
		10,32,12,32,735,9,32,1,32,1,32,1,32,1,32,1,33,1,33,1,34,1,34,1,34,1,34,
		3,34,747,8,34,1,35,1,35,1,35,1,35,1,36,1,36,1,36,1,36,1,36,1,36,1,37,1,
		37,1,37,1,37,1,37,1,37,1,37,1,38,1,38,1,38,1,38,1,38,1,38,1,38,1,39,1,
		39,1,39,3,39,776,8,39,1,40,1,40,3,40,780,8,40,1,41,5,41,783,8,41,10,41,
		12,41,786,9,41,1,41,1,41,1,41,3,41,791,8,41,1,41,3,41,794,8,41,1,41,3,
		41,797,8,41,1,41,1,41,1,42,1,42,1,42,1,42,1,42,1,42,1,42,1,42,3,42,809,
		8,42,1,43,1,43,1,43,1,43,1,44,1,44,1,44,5,44,818,8,44,10,44,12,44,821,
		9,44,1,45,1,45,1,45,1,46,1,46,1,46,1,47,1,47,1,47,5,47,832,8,47,10,47,
		12,47,835,9,47,1,48,1,48,5,48,839,8,48,10,48,12,48,842,9,48,1,48,1,48,
		1,49,1,49,1,49,1,49,3,49,850,8,49,1,50,1,50,1,50,1,50,1,50,3,50,857,8,
		50,1,51,5,51,860,8,51,10,51,12,51,863,9,51,1,51,1,51,1,51,1,51,1,52,1,
		52,1,52,1,52,1,52,1,52,1,52,1,52,3,52,877,8,52,1,53,1,53,1,53,5,53,882,
		8,53,10,53,12,53,885,9,53,1,54,1,54,1,54,3,54,890,8,54,1,55,1,55,3,55,
		894,8,55,1,56,1,56,3,56,898,8,56,1,57,1,57,3,57,902,8,57,1,58,1,58,3,58,
		906,8,58,1,59,1,59,1,59,3,59,911,8,59,1,60,1,60,3,60,915,8,60,1,60,1,60,
		5,60,919,8,60,10,60,12,60,922,9,60,1,61,1,61,3,61,926,8,61,1,61,1,61,1,
		61,5,61,931,8,61,10,61,12,61,934,9,61,1,61,1,61,3,61,938,8,61,3,61,940,
		8,61,1,62,1,62,5,62,944,8,62,10,62,12,62,947,9,62,1,62,1,62,3,62,951,8,
		62,1,63,1,63,3,63,955,8,63,1,64,1,64,1,65,1,65,1,66,1,66,1,67,1,67,1,68,
		1,68,1,68,1,68,1,68,1,68,1,68,1,68,1,68,3,68,974,8,68,1,69,5,69,977,8,
		69,10,69,12,69,980,9,69,1,69,1,69,1,69,1,70,1,70,1,70,1,70,1,70,1,70,1,
		70,1,70,1,70,1,70,3,70,995,8,70,1,71,1,71,1,71,3,71,1000,8,71,1,71,1,71,
		5,71,1004,8,71,10,71,12,71,1007,9,71,1,71,1,71,1,71,3,71,1012,8,71,3,71,
		1014,8,71,1,72,1,72,3,72,1018,8,72,1,73,1,73,1,73,3,73,1023,8,73,1,73,
		1,73,3,73,1027,8,73,1,74,1,74,1,74,1,74,1,74,1,74,3,74,1035,8,74,1,75,
		1,75,1,75,5,75,1040,8,75,10,75,12,75,1043,9,75,1,75,1,75,1,75,5,75,1048,
		8,75,10,75,12,75,1051,9,75,3,75,1053,8,75,1,76,5,76,1056,8,76,10,76,12,
		76,1059,9,76,1,76,1,76,1,76,1,77,1,77,3,77,1066,8,77,1,78,5,78,1069,8,
		78,10,78,12,78,1072,9,78,1,78,1,78,5,78,1076,8,78,10,78,12,78,1079,9,78,
		1,78,1,78,1,78,1,78,3,78,1085,8,78,1,79,5,79,1088,8,79,10,79,12,79,1091,
		9,79,1,79,1,79,1,79,3,79,1096,8,79,1,79,1,79,1,80,1,80,1,80,1,81,1,81,
		1,81,5,81,1106,8,81,10,81,12,81,1109,9,81,1,82,1,82,3,82,1113,8,82,1,83,
		1,83,3,83,1117,8,83,1,84,1,84,1,85,1,85,1,85,1,86,5,86,1125,8,86,10,86,
		12,86,1128,9,86,1,86,1,86,3,86,1132,8,86,1,86,1,86,1,87,1,87,1,87,1,87,
		3,87,1140,8,87,1,88,3,88,1143,8,88,1,88,1,88,1,88,3,88,1148,8,88,1,88,
		1,88,1,89,1,89,1,90,1,90,3,90,1156,8,90,1,90,3,90,1159,8,90,1,90,1,90,
		1,91,3,91,1164,8,91,1,91,1,91,1,91,3,91,1169,8,91,1,91,1,91,1,91,3,91,
		1174,8,91,1,91,1,91,1,91,3,91,1179,8,91,1,91,1,91,1,91,1,91,1,91,3,91,
		1186,8,91,1,91,1,91,1,91,3,91,1191,8,91,1,91,1,91,1,91,1,91,1,91,1,91,
		3,91,1199,8,91,1,91,1,91,1,91,3,91,1204,8,91,1,91,1,91,1,91,3,91,1209,
		8,91,1,92,5,92,1212,8,92,10,92,12,92,1215,9,92,1,92,1,92,1,92,3,92,1220,
		8,92,1,92,1,92,1,93,1,93,3,93,1226,8,93,1,93,3,93,1229,8,93,1,93,3,93,
		1232,8,93,1,93,1,93,1,94,1,94,1,94,5,94,1239,8,94,10,94,12,94,1242,9,94,
		1,95,5,95,1245,8,95,10,95,12,95,1248,9,95,1,95,1,95,1,95,3,95,1253,8,95,
		1,95,3,95,1256,8,95,1,95,3,95,1259,8,95,1,96,1,96,1,97,1,97,5,97,1265,
		8,97,10,97,12,97,1268,9,97,1,98,1,98,3,98,1272,8,98,1,99,5,99,1275,8,99,
		10,99,12,99,1278,9,99,1,99,1,99,1,99,3,99,1283,8,99,1,99,3,99,1286,8,99,
		1,99,1,99,1,100,1,100,1,100,1,100,1,100,1,100,1,100,3,100,1297,8,100,1,
		101,1,101,1,101,1,102,1,102,5,102,1304,8,102,10,102,12,102,1307,9,102,
		1,102,1,102,1,103,1,103,1,103,1,103,1,103,3,103,1316,8,103,1,104,5,104,
		1319,8,104,10,104,12,104,1322,9,104,1,104,1,104,1,104,1,104,1,105,1,105,
		1,105,1,105,3,105,1332,8,105,1,106,5,106,1335,8,106,10,106,12,106,1338,
		9,106,1,106,1,106,1,106,1,107,1,107,1,107,1,107,1,107,1,107,3,107,1349,
		8,107,1,108,5,108,1352,8,108,10,108,12,108,1355,9,108,1,108,1,108,1,108,
		1,108,1,108,1,109,1,109,5,109,1364,8,109,10,109,12,109,1367,9,109,1,109,
		1,109,1,110,1,110,1,110,1,110,1,110,3,110,1376,8,110,1,111,5,111,1379,
		8,111,10,111,12,111,1382,9,111,1,111,1,111,1,111,1,111,1,111,3,111,1389,
		8,111,1,111,3,111,1392,8,111,1,111,1,111,1,112,1,112,1,112,3,112,1399,
		8,112,1,113,1,113,1,113,1,114,1,114,1,114,3,114,1407,8,114,1,115,1,115,
		1,115,1,115,3,115,1413,8,115,1,115,1,115,1,116,1,116,1,116,5,116,1420,
		8,116,10,116,12,116,1423,9,116,1,117,1,117,1,117,1,117,1,118,1,118,1,118,
		3,118,1432,8,118,1,119,1,119,3,119,1436,8,119,1,119,3,119,1439,8,119,1,
		119,1,119,1,120,1,120,1,120,5,120,1446,8,120,10,120,12,120,1449,9,120,
		1,121,1,121,1,121,1,122,1,122,1,122,1,122,1,122,1,122,1,123,1,123,3,123,
		1462,8,123,1,123,3,123,1465,8,123,1,123,1,123,1,124,1,124,1,124,5,124,
		1472,8,124,10,124,12,124,1475,9,124,1,125,1,125,3,125,1479,8,125,1,125,
		1,125,1,126,4,126,1484,8,126,11,126,12,126,1485,1,127,1,127,1,127,3,127,
		1491,8,127,1,128,1,128,1,128,1,129,5,129,1497,8,129,10,129,12,129,1500,
		9,129,1,129,1,129,1,129,1,130,1,130,1,130,1,130,1,130,1,130,3,130,1511,
		8,130,1,131,1,131,1,131,1,131,1,131,3,131,1518,8,131,1,132,1,132,1,132,
		1,132,1,132,1,132,1,132,1,132,1,132,1,132,1,132,1,132,3,132,1532,8,132,
		1,133,1,133,1,134,1,134,1,134,1,134,1,135,1,135,1,135,1,135,1,136,1,136,
		1,136,1,137,1,137,1,137,1,137,1,137,1,137,1,137,3,137,1554,8,137,1,138,
		1,138,1,138,1,138,1,138,1,138,1,139,1,139,1,139,1,139,1,139,1,139,1,139,
		1,139,1,140,1,140,1,140,1,140,1,140,1,140,1,140,1,140,1,141,1,141,1,141,
		1,141,1,141,1,141,1,141,1,141,1,141,1,141,3,141,1588,8,141,1,142,1,142,
		1,142,1,142,1,142,1,142,1,143,1,143,5,143,1598,8,143,10,143,12,143,1601,
		9,143,1,143,5,143,1604,8,143,10,143,12,143,1607,9,143,1,143,1,143,1,144,
		1,144,1,144,1,145,1,145,5,145,1616,8,145,10,145,12,145,1619,9,145,1,146,
		1,146,1,146,1,146,1,146,1,146,1,146,1,146,1,146,1,146,3,146,1631,8,146,
		1,147,1,147,1,148,1,148,1,148,1,148,1,148,1,148,1,149,1,149,1,149,1,149,
		1,149,1,149,1,150,1,150,1,150,1,150,1,150,1,150,1,150,1,150,1,151,1,151,
		3,151,1657,8,151,1,152,1,152,3,152,1661,8,152,1,153,1,153,1,153,3,153,
		1666,8,153,1,153,1,153,3,153,1670,8,153,1,153,1,153,3,153,1674,8,153,1,
		153,1,153,1,153,1,154,1,154,1,154,3,154,1682,8,154,1,154,1,154,3,154,1686,
		8,154,1,154,1,154,3,154,1690,8,154,1,154,1,154,1,154,1,155,1,155,3,155,
		1697,8,155,1,156,1,156,1,157,1,157,1,157,5,157,1704,8,157,10,157,12,157,
		1707,9,157,1,158,1,158,1,158,5,158,1712,8,158,10,158,12,158,1715,9,158,
		1,158,1,158,1,158,1,158,1,158,1,158,1,158,1,159,1,159,1,159,5,159,1727,
		8,159,10,159,12,159,1730,9,159,1,159,1,159,1,159,1,159,1,159,1,159,1,159,
		1,160,1,160,3,160,1741,8,160,1,160,1,160,1,161,1,161,3,161,1747,8,161,
		1,161,1,161,1,162,1,162,3,162,1753,8,162,1,162,1,162,1,163,1,163,1,163,
		1,163,1,164,1,164,1,164,1,164,1,164,1,164,1,165,1,165,1,165,1,165,1,165,
		1,165,1,165,3,165,1774,8,165,1,165,1,165,1,165,3,165,1779,8,165,1,166,
		1,166,5,166,1783,8,166,10,166,12,166,1786,9,166,1,167,1,167,1,167,1,167,
		1,167,1,167,1,168,5,168,1795,8,168,10,168,12,168,1798,9,168,1,168,1,168,
		1,168,1,169,1,169,1,169,5,169,1806,8,169,10,169,12,169,1809,9,169,1,170,
		1,170,1,170,1,171,1,171,1,171,1,171,3,171,1818,8,171,1,171,3,171,1821,
		8,171,1,172,1,172,1,172,3,172,1826,8,172,1,172,1,172,1,173,1,173,1,173,
		5,173,1833,8,173,10,173,12,173,1836,9,173,1,174,5,174,1839,8,174,10,174,
		12,174,1842,9,174,1,174,1,174,1,174,1,174,1,174,1,175,1,175,3,175,1851,
		8,175,1,175,5,175,1854,8,175,10,175,12,175,1857,9,175,1,176,1,176,1,176,
		1,176,5,176,1863,8,176,10,176,12,176,1866,9,176,1,176,1,176,1,176,1,176,
		1,176,1,176,1,176,1,176,1,176,1,176,1,176,1,176,1,176,1,176,1,176,1,176,
		1,176,1,176,1,176,1,176,3,176,1888,8,176,1,177,1,177,1,178,1,178,1,178,
		1,178,5,178,1896,8,178,10,178,12,178,1899,9,178,1,178,1,178,1,178,1,178,
		1,178,1,178,1,178,1,178,1,178,1,178,1,178,1,178,1,178,1,178,1,178,1,178,
		1,178,1,178,1,178,3,178,1920,8,178,1,179,1,179,1,179,1,179,1,179,3,179,
		1927,8,179,1,180,1,180,1,181,1,181,1,181,1,181,3,181,1935,8,181,1,182,
		1,182,1,182,1,182,5,182,1941,8,182,10,182,12,182,1944,9,182,1,182,1,182,
		1,182,1,182,1,182,1,182,5,182,1952,8,182,10,182,12,182,1955,9,182,1,182,
		1,182,1,182,1,182,1,182,1,182,1,182,1,182,1,182,1,182,1,182,1,182,1,182,
		1,182,1,182,1,182,1,182,1,182,1,182,1,182,3,182,1977,8,182,1,183,1,183,
		1,184,1,184,1,184,1,184,5,184,1985,8,184,10,184,12,184,1988,9,184,1,184,
		1,184,1,184,1,184,1,184,1,184,5,184,1996,8,184,10,184,12,184,1999,9,184,
		1,184,1,184,1,184,1,184,1,184,1,184,1,184,1,184,1,184,1,184,1,184,1,184,
		1,184,1,184,1,184,1,184,1,184,1,184,1,184,3,184,2020,8,184,1,185,1,185,
		3,185,2024,8,185,1,185,5,185,2027,8,185,10,185,12,185,2030,9,185,1,185,
		1,185,1,185,5,185,2035,8,185,10,185,12,185,2038,9,185,1,185,5,185,2041,
		8,185,10,185,12,185,2044,9,185,1,185,3,185,2047,8,185,1,185,1,185,3,185,
		2051,8,185,1,185,1,185,3,185,2055,8,185,1,185,1,185,1,185,1,185,3,185,
		2061,8,185,1,185,5,185,2064,8,185,10,185,12,185,2067,9,185,1,185,1,185,
		3,185,2071,8,185,1,185,1,185,3,185,2075,8,185,1,185,1,185,3,185,2079,8,
		185,1,185,1,185,1,185,1,185,3,185,2085,8,185,1,185,5,185,2088,8,185,10,
		185,12,185,2091,9,185,1,185,1,185,3,185,2095,8,185,1,185,1,185,3,185,2099,
		8,185,1,185,1,185,3,185,2103,8,185,3,185,2105,8,185,1,186,1,186,1,186,
		3,186,2110,8,186,1,186,5,186,2113,8,186,10,186,12,186,2116,9,186,1,186,
		1,186,3,186,2120,8,186,1,186,1,186,3,186,2124,8,186,1,186,1,186,3,186,
		2128,8,186,1,187,1,187,3,187,2132,8,187,1,187,5,187,2135,8,187,10,187,
		12,187,2138,9,187,1,187,1,187,1,187,5,187,2143,8,187,10,187,12,187,2146,
		9,187,1,187,5,187,2149,8,187,10,187,12,187,2152,9,187,1,187,3,187,2155,
		8,187,1,187,1,187,3,187,2159,8,187,1,187,1,187,3,187,2163,8,187,1,187,
		1,187,1,187,1,187,3,187,2169,8,187,1,187,5,187,2172,8,187,10,187,12,187,
		2175,9,187,1,187,1,187,3,187,2179,8,187,1,187,1,187,3,187,2183,8,187,1,
		187,1,187,3,187,2187,8,187,3,187,2189,8,187,1,188,1,188,1,188,3,188,2194,
		8,188,1,189,1,189,1,189,1,189,1,189,1,189,1,189,1,189,1,189,1,189,1,189,
		1,189,1,189,3,189,2209,8,189,1,190,1,190,1,190,1,191,1,191,1,191,1,191,
		1,191,1,191,1,191,1,191,1,191,3,191,2223,8,191,1,192,1,192,1,192,1,192,
		1,192,1,192,1,192,1,192,1,192,1,192,3,192,2235,8,192,1,192,1,192,1,192,
		1,192,1,192,5,192,2242,8,192,10,192,12,192,2245,9,192,1,193,1,193,1,193,
		1,193,1,193,1,193,1,193,1,193,1,193,1,193,5,193,2257,8,193,10,193,12,193,
		2260,9,193,1,194,1,194,1,194,1,194,1,194,1,194,1,194,1,194,1,194,1,194,
		3,194,2272,8,194,1,194,1,194,1,194,1,194,1,194,5,194,2279,8,194,10,194,
		12,194,2282,9,194,1,195,1,195,1,195,3,195,2287,8,195,1,195,1,195,1,195,
		1,195,1,195,3,195,2294,8,195,1,195,1,195,1,195,3,195,2299,8,195,1,195,
		1,195,1,195,1,195,1,195,3,195,2306,8,195,1,195,1,195,1,195,3,195,2311,
		8,195,1,195,1,195,1,195,1,195,1,195,3,195,2318,8,195,1,195,1,195,1,195,
		3,195,2323,8,195,1,195,1,195,1,195,1,195,1,195,3,195,2330,8,195,1,195,
		1,195,1,195,3,195,2335,8,195,1,195,1,195,1,195,1,195,1,195,1,195,3,195,
		2343,8,195,1,195,1,195,1,195,3,195,2348,8,195,1,195,1,195,3,195,2352,8,
		195,1,196,1,196,3,196,2356,8,196,1,196,1,196,1,196,3,196,2361,8,196,1,
		196,1,196,1,197,1,197,1,197,3,197,2368,8,197,1,197,1,197,1,197,1,197,1,
		197,3,197,2375,8,197,1,197,1,197,1,197,3,197,2380,8,197,1,197,1,197,1,
		197,1,197,1,197,3,197,2387,8,197,1,197,1,197,1,197,3,197,2392,8,197,1,
		197,1,197,1,197,1,197,1,197,3,197,2399,8,197,1,197,1,197,1,197,3,197,2404,
		8,197,1,197,1,197,1,197,1,197,1,197,1,197,3,197,2412,8,197,1,197,1,197,
		1,197,3,197,2417,8,197,1,197,1,197,3,197,2421,8,197,1,198,1,198,1,198,
		5,198,2426,8,198,10,198,12,198,2429,9,198,1,199,1,199,1,199,3,199,2434,
		8,199,1,199,1,199,1,199,1,199,1,199,3,199,2441,8,199,1,199,1,199,1,199,
		1,199,1,199,3,199,2448,8,199,1,199,1,199,1,199,1,199,1,199,3,199,2455,
		8,199,1,199,1,199,1,199,1,199,1,199,1,199,3,199,2463,8,199,1,199,1,199,
		1,199,1,199,1,199,3,199,2470,8,199,1,199,1,199,1,199,1,199,1,199,1,199,
		3,199,2478,8,199,1,200,1,200,3,200,2482,8,200,1,200,1,200,1,201,1,201,
		1,201,3,201,2489,8,201,1,201,1,201,1,201,1,201,1,201,3,201,2496,8,201,
		1,201,1,201,1,201,1,201,1,201,3,201,2503,8,201,1,201,1,201,1,201,1,201,
		1,201,1,201,3,201,2511,8,201,1,201,1,201,1,201,1,201,1,201,3,201,2518,
		8,201,1,201,1,201,1,201,1,201,1,201,1,201,3,201,2526,8,201,1,202,1,202,
		1,202,1,202,3,202,2532,8,202,1,202,1,202,1,202,1,202,3,202,2538,8,202,
		1,202,1,202,1,202,1,202,1,202,1,202,1,202,1,202,1,202,1,202,3,202,2550,
		8,202,1,203,1,203,5,203,2554,8,203,10,203,12,203,2557,9,203,1,204,5,204,
		2560,8,204,10,204,12,204,2563,9,204,1,204,1,204,1,204,1,204,1,205,1,205,
		1,206,1,206,3,206,2573,8,206,1,207,1,207,1,207,1,207,1,208,1,208,1,208,
		3,208,2582,8,208,1,208,1,208,1,208,1,208,1,208,3,208,2589,8,208,1,209,
		1,209,1,209,5,209,2594,8,209,10,209,12,209,2597,9,209,1,210,1,210,3,210,
		2601,8,210,1,211,1,211,3,211,2605,8,211,1,212,1,212,1,212,1,212,1,213,
		1,213,1,213,3,213,2614,8,213,1,214,1,214,1,215,1,215,1,215,1,215,1,215,
		1,215,1,215,3,215,2625,8,215,1,216,1,216,1,216,1,216,1,216,1,216,5,216,
		2633,8,216,10,216,12,216,2636,9,216,1,217,1,217,1,217,1,217,1,217,1,217,
		5,217,2644,8,217,10,217,12,217,2647,9,217,1,218,1,218,1,218,1,218,1,218,
		1,218,5,218,2655,8,218,10,218,12,218,2658,9,218,1,219,1,219,1,219,1,219,
		1,219,1,219,5,219,2666,8,219,10,219,12,219,2669,9,219,1,220,1,220,1,220,
		1,220,1,220,1,220,5,220,2677,8,220,10,220,12,220,2680,9,220,1,221,1,221,
		1,221,1,221,1,221,1,221,1,221,1,221,1,221,5,221,2691,8,221,10,221,12,221,
		2694,9,221,1,222,1,222,1,222,1,222,1,222,1,222,1,222,1,222,1,222,1,222,
		1,222,1,222,1,222,1,222,1,222,1,222,1,222,1,222,5,222,2714,8,222,10,222,
		12,222,2717,9,222,1,223,1,223,1,223,1,223,1,223,1,223,1,223,1,223,1,223,
		1,223,1,223,1,223,1,223,1,223,1,223,1,223,5,223,2735,8,223,10,223,12,223,
		2738,9,223,1,224,1,224,1,224,1,224,1,224,1,224,1,224,1,224,1,224,5,224,
		2749,8,224,10,224,12,224,2752,9,224,1,225,1,225,1,225,1,225,1,225,1,225,
		1,225,1,225,1,225,1,225,1,225,1,225,5,225,2766,8,225,10,225,12,225,2769,
		9,225,1,226,1,226,1,226,1,226,1,226,1,226,1,226,3,226,2778,8,226,1,227,
		1,227,1,227,1,228,1,228,1,228,1,229,1,229,1,229,1,229,1,229,1,229,3,229,
		2792,8,229,1,230,1,230,3,230,2796,8,230,1,230,1,230,5,230,2800,8,230,10,
		230,12,230,2803,9,230,1,231,1,231,1,231,1,232,1,232,1,233,1,233,1,233,
		1,234,1,234,1,235,1,235,1,235,1,235,1,235,1,235,1,235,1,235,5,235,2823,
		8,235,10,235,12,235,2826,9,235,1,235,1,235,1,235,1,235,1,235,1,235,5,235,
		2834,8,235,10,235,12,235,2837,9,235,1,235,1,235,1,235,3,235,2842,8,235,
		1,235,0,13,50,54,60,432,434,436,438,440,442,444,446,448,450,236,0,2,4,
		6,8,10,12,14,16,18,20,22,24,26,28,30,32,34,36,38,40,42,44,46,48,50,52,
		54,56,58,60,62,64,66,68,70,72,74,76,78,80,82,84,86,88,90,92,94,96,98,100,
		102,104,106,108,110,112,114,116,118,120,122,124,126,128,130,132,134,136,
		138,140,142,144,146,148,150,152,154,156,158,160,162,164,166,168,170,172,
		174,176,178,180,182,184,186,188,190,192,194,196,198,200,202,204,206,208,
		210,212,214,216,218,220,222,224,226,228,230,232,234,236,238,240,242,244,
		246,248,250,252,254,256,258,260,262,264,266,268,270,272,274,276,278,280,
		282,284,286,288,290,292,294,296,298,300,302,304,306,308,310,312,314,316,
		318,320,322,324,326,328,330,332,334,336,338,340,342,344,346,348,350,352,
		354,356,358,360,362,364,366,368,370,372,374,376,378,380,382,384,386,388,
		390,392,394,396,398,400,402,404,406,408,410,412,414,416,418,420,422,424,
		426,428,430,432,434,436,438,440,442,444,446,448,450,452,454,456,458,460,
		462,464,466,468,470,0,4,1,0,51,56,5,0,5,5,8,8,27,27,29,29,37,37,2,0,14,
		14,20,20,2,0,66,66,91,101,3085,0,472,1,0,0,0,2,488,1,0,0,0,4,492,1,0,0,
		0,6,494,1,0,0,0,8,496,1,0,0,0,10,501,1,0,0,0,12,505,1,0,0,0,14,536,1,0,
		0,0,16,538,1,0,0,0,18,552,1,0,0,0,20,559,1,0,0,0,22,561,1,0,0,0,24,563,
		1,0,0,0,26,568,1,0,0,0,28,582,1,0,0,0,30,587,1,0,0,0,32,608,1,0,0,0,34,
		615,1,0,0,0,36,627,1,0,0,0,38,629,1,0,0,0,40,632,1,0,0,0,42,636,1,0,0,
		0,44,646,1,0,0,0,46,651,1,0,0,0,48,662,1,0,0,0,50,664,1,0,0,0,52,680,1,
		0,0,0,54,682,1,0,0,0,56,698,1,0,0,0,58,700,1,0,0,0,60,702,1,0,0,0,62,714,
		1,0,0,0,64,733,1,0,0,0,66,740,1,0,0,0,68,746,1,0,0,0,70,748,1,0,0,0,72,
		752,1,0,0,0,74,758,1,0,0,0,76,765,1,0,0,0,78,775,1,0,0,0,80,779,1,0,0,
		0,82,784,1,0,0,0,84,808,1,0,0,0,86,810,1,0,0,0,88,814,1,0,0,0,90,822,1,
		0,0,0,92,825,1,0,0,0,94,828,1,0,0,0,96,836,1,0,0,0,98,849,1,0,0,0,100,
		856,1,0,0,0,102,861,1,0,0,0,104,876,1,0,0,0,106,878,1,0,0,0,108,886,1,
		0,0,0,110,891,1,0,0,0,112,897,1,0,0,0,114,901,1,0,0,0,116,905,1,0,0,0,
		118,910,1,0,0,0,120,914,1,0,0,0,122,939,1,0,0,0,124,941,1,0,0,0,126,952,
		1,0,0,0,128,956,1,0,0,0,130,958,1,0,0,0,132,960,1,0,0,0,134,962,1,0,0,
		0,136,973,1,0,0,0,138,978,1,0,0,0,140,994,1,0,0,0,142,1013,1,0,0,0,144,
		1017,1,0,0,0,146,1019,1,0,0,0,148,1034,1,0,0,0,150,1052,1,0,0,0,152,1057,
		1,0,0,0,154,1065,1,0,0,0,156,1084,1,0,0,0,158,1089,1,0,0,0,160,1099,1,
		0,0,0,162,1102,1,0,0,0,164,1112,1,0,0,0,166,1116,1,0,0,0,168,1118,1,0,
		0,0,170,1120,1,0,0,0,172,1126,1,0,0,0,174,1139,1,0,0,0,176,1142,1,0,0,
		0,178,1151,1,0,0,0,180,1153,1,0,0,0,182,1208,1,0,0,0,184,1213,1,0,0,0,
		186,1223,1,0,0,0,188,1235,1,0,0,0,190,1246,1,0,0,0,192,1260,1,0,0,0,194,
		1262,1,0,0,0,196,1271,1,0,0,0,198,1276,1,0,0,0,200,1296,1,0,0,0,202,1298,
		1,0,0,0,204,1301,1,0,0,0,206,1315,1,0,0,0,208,1320,1,0,0,0,210,1331,1,
		0,0,0,212,1336,1,0,0,0,214,1348,1,0,0,0,216,1353,1,0,0,0,218,1361,1,0,
		0,0,220,1375,1,0,0,0,222,1380,1,0,0,0,224,1398,1,0,0,0,226,1400,1,0,0,
		0,228,1406,1,0,0,0,230,1408,1,0,0,0,232,1416,1,0,0,0,234,1424,1,0,0,0,
		236,1431,1,0,0,0,238,1433,1,0,0,0,240,1442,1,0,0,0,242,1450,1,0,0,0,244,
		1453,1,0,0,0,246,1459,1,0,0,0,248,1468,1,0,0,0,250,1476,1,0,0,0,252,1483,
		1,0,0,0,254,1490,1,0,0,0,256,1492,1,0,0,0,258,1498,1,0,0,0,260,1510,1,
		0,0,0,262,1517,1,0,0,0,264,1531,1,0,0,0,266,1533,1,0,0,0,268,1535,1,0,
		0,0,270,1539,1,0,0,0,272,1543,1,0,0,0,274,1553,1,0,0,0,276,1555,1,0,0,
		0,278,1561,1,0,0,0,280,1569,1,0,0,0,282,1587,1,0,0,0,284,1589,1,0,0,0,
		286,1595,1,0,0,0,288,1610,1,0,0,0,290,1613,1,0,0,0,292,1630,1,0,0,0,294,
		1632,1,0,0,0,296,1634,1,0,0,0,298,1640,1,0,0,0,300,1646,1,0,0,0,302,1656,
		1,0,0,0,304,1660,1,0,0,0,306,1662,1,0,0,0,308,1678,1,0,0,0,310,1696,1,
		0,0,0,312,1698,1,0,0,0,314,1700,1,0,0,0,316,1708,1,0,0,0,318,1723,1,0,
		0,0,320,1738,1,0,0,0,322,1744,1,0,0,0,324,1750,1,0,0,0,326,1756,1,0,0,
		0,328,1760,1,0,0,0,330,1778,1,0,0,0,332,1780,1,0,0,0,334,1787,1,0,0,0,
		336,1796,1,0,0,0,338,1802,1,0,0,0,340,1810,1,0,0,0,342,1813,1,0,0,0,344,
		1822,1,0,0,0,346,1829,1,0,0,0,348,1840,1,0,0,0,350,1850,1,0,0,0,352,1887,
		1,0,0,0,354,1889,1,0,0,0,356,1919,1,0,0,0,358,1926,1,0,0,0,360,1928,1,
		0,0,0,362,1934,1,0,0,0,364,1976,1,0,0,0,366,1978,1,0,0,0,368,2019,1,0,
		0,0,370,2104,1,0,0,0,372,2106,1,0,0,0,374,2188,1,0,0,0,376,2193,1,0,0,
		0,378,2208,1,0,0,0,380,2210,1,0,0,0,382,2222,1,0,0,0,384,2234,1,0,0,0,
		386,2246,1,0,0,0,388,2271,1,0,0,0,390,2351,1,0,0,0,392,2353,1,0,0,0,394,
		2420,1,0,0,0,396,2422,1,0,0,0,398,2477,1,0,0,0,400,2479,1,0,0,0,402,2525,
		1,0,0,0,404,2549,1,0,0,0,406,2551,1,0,0,0,408,2561,1,0,0,0,410,2568,1,
		0,0,0,412,2572,1,0,0,0,414,2574,1,0,0,0,416,2588,1,0,0,0,418,2590,1,0,
		0,0,420,2600,1,0,0,0,422,2604,1,0,0,0,424,2606,1,0,0,0,426,2613,1,0,0,
		0,428,2615,1,0,0,0,430,2624,1,0,0,0,432,2626,1,0,0,0,434,2637,1,0,0,0,
		436,2648,1,0,0,0,438,2659,1,0,0,0,440,2670,1,0,0,0,442,2681,1,0,0,0,444,
		2695,1,0,0,0,446,2718,1,0,0,0,448,2739,1,0,0,0,450,2753,1,0,0,0,452,2777,
		1,0,0,0,454,2779,1,0,0,0,456,2782,1,0,0,0,458,2791,1,0,0,0,460,2795,1,
		0,0,0,462,2804,1,0,0,0,464,2807,1,0,0,0,466,2809,1,0,0,0,468,2812,1,0,
		0,0,470,2841,1,0,0,0,472,473,7,0,0,0,473,1,1,0,0,0,474,476,3,228,114,0,
		475,474,1,0,0,0,476,479,1,0,0,0,477,475,1,0,0,0,477,478,1,0,0,0,478,480,
		1,0,0,0,479,477,1,0,0,0,480,489,3,4,2,0,481,483,3,228,114,0,482,481,1,
		0,0,0,483,486,1,0,0,0,484,482,1,0,0,0,484,485,1,0,0,0,485,487,1,0,0,0,
		486,484,1,0,0,0,487,489,5,3,0,0,488,477,1,0,0,0,488,484,1,0,0,0,489,3,
		1,0,0,0,490,493,3,6,3,0,491,493,3,8,4,0,492,490,1,0,0,0,492,491,1,0,0,
		0,493,5,1,0,0,0,494,495,7,1,0,0,495,7,1,0,0,0,496,497,7,2,0,0,497,9,1,
		0,0,0,498,502,3,12,6,0,499,502,3,26,13,0,500,502,3,28,14,0,501,498,1,0,
		0,0,501,499,1,0,0,0,501,500,1,0,0,0,502,11,1,0,0,0,503,506,3,18,9,0,504,
		506,3,24,12,0,505,503,1,0,0,0,505,504,1,0,0,0,506,511,1,0,0,0,507,510,
		3,16,8,0,508,510,3,22,11,0,509,507,1,0,0,0,509,508,1,0,0,0,510,513,1,0,
		0,0,511,509,1,0,0,0,511,512,1,0,0,0,512,13,1,0,0,0,513,511,1,0,0,0,514,
		516,3,228,114,0,515,514,1,0,0,0,516,519,1,0,0,0,517,515,1,0,0,0,517,518,
		1,0,0,0,518,520,1,0,0,0,519,517,1,0,0,0,520,522,5,102,0,0,521,523,3,40,
		20,0,522,521,1,0,0,0,522,523,1,0,0,0,523,537,1,0,0,0,524,525,3,12,6,0,
		525,529,5,65,0,0,526,528,3,228,114,0,527,526,1,0,0,0,528,531,1,0,0,0,529,
		527,1,0,0,0,529,530,1,0,0,0,530,532,1,0,0,0,531,529,1,0,0,0,532,534,5,
		102,0,0,533,535,3,40,20,0,534,533,1,0,0,0,534,535,1,0,0,0,535,537,1,0,
		0,0,536,517,1,0,0,0,536,524,1,0,0,0,537,15,1,0,0,0,538,542,5,65,0,0,539,
		541,3,228,114,0,540,539,1,0,0,0,541,544,1,0,0,0,542,540,1,0,0,0,542,543,
		1,0,0,0,543,545,1,0,0,0,544,542,1,0,0,0,545,547,5,102,0,0,546,548,3,40,
		20,0,547,546,1,0,0,0,547,548,1,0,0,0,548,17,1,0,0,0,549,551,3,228,114,
		0,550,549,1,0,0,0,551,554,1,0,0,0,552,550,1,0,0,0,552,553,1,0,0,0,553,
		555,1,0,0,0,554,552,1,0,0,0,555,557,5,102,0,0,556,558,3,40,20,0,557,556,
		1,0,0,0,557,558,1,0,0,0,558,19,1,0,0,0,559,560,3,14,7,0,560,21,1,0,0,0,
		561,562,3,16,8,0,562,23,1,0,0,0,563,564,3,18,9,0,564,25,1,0,0,0,565,567,
		3,228,114,0,566,565,1,0,0,0,567,570,1,0,0,0,568,566,1,0,0,0,568,569,1,
		0,0,0,569,571,1,0,0,0,570,568,1,0,0,0,571,572,5,102,0,0,572,27,1,0,0,0,
		573,574,3,2,1,0,574,575,3,30,15,0,575,583,1,0,0,0,576,577,3,12,6,0,577,
		578,3,30,15,0,578,583,1,0,0,0,579,580,3,26,13,0,580,581,3,30,15,0,581,
		583,1,0,0,0,582,573,1,0,0,0,582,576,1,0,0,0,582,579,1,0,0,0,583,29,1,0,
		0,0,584,586,3,228,114,0,585,584,1,0,0,0,586,589,1,0,0,0,587,585,1,0,0,
		0,587,588,1,0,0,0,588,590,1,0,0,0,589,587,1,0,0,0,590,591,5,61,0,0,591,
		602,5,62,0,0,592,594,3,228,114,0,593,592,1,0,0,0,594,597,1,0,0,0,595,593,
		1,0,0,0,595,596,1,0,0,0,596,598,1,0,0,0,597,595,1,0,0,0,598,599,5,61,0,
		0,599,601,5,62,0,0,600,595,1,0,0,0,601,604,1,0,0,0,602,600,1,0,0,0,602,
		603,1,0,0,0,603,31,1,0,0,0,604,602,1,0,0,0,605,607,3,34,17,0,606,605,1,
		0,0,0,607,610,1,0,0,0,608,606,1,0,0,0,608,609,1,0,0,0,609,611,1,0,0,0,
		610,608,1,0,0,0,611,613,5,102,0,0,612,614,3,36,18,0,613,612,1,0,0,0,613,
		614,1,0,0,0,614,33,1,0,0,0,615,616,3,228,114,0,616,35,1,0,0,0,617,618,
		5,17,0,0,618,628,3,26,13,0,619,620,5,17,0,0,620,624,3,12,6,0,621,623,3,
		38,19,0,622,621,1,0,0,0,623,626,1,0,0,0,624,622,1,0,0,0,624,625,1,0,0,
		0,625,628,1,0,0,0,626,624,1,0,0,0,627,617,1,0,0,0,627,619,1,0,0,0,628,
		37,1,0,0,0,629,630,5,85,0,0,630,631,3,20,10,0,631,39,1,0,0,0,632,633,5,
		68,0,0,633,634,3,42,21,0,634,635,5,67,0,0,635,41,1,0,0,0,636,641,3,44,
		22,0,637,638,5,64,0,0,638,640,3,44,22,0,639,637,1,0,0,0,640,643,1,0,0,
		0,641,639,1,0,0,0,641,642,1,0,0,0,642,43,1,0,0,0,643,641,1,0,0,0,644,647,
		3,10,5,0,645,647,3,46,23,0,646,644,1,0,0,0,646,645,1,0,0,0,647,45,1,0,
		0,0,648,650,3,228,114,0,649,648,1,0,0,0,650,653,1,0,0,0,651,649,1,0,0,
		0,651,652,1,0,0,0,652,654,1,0,0,0,653,651,1,0,0,0,654,656,5,71,0,0,655,
		657,3,48,24,0,656,655,1,0,0,0,656,657,1,0,0,0,657,47,1,0,0,0,658,659,5,
		17,0,0,659,663,3,10,5,0,660,661,5,40,0,0,661,663,3,10,5,0,662,658,1,0,
		0,0,662,660,1,0,0,0,663,49,1,0,0,0,664,665,6,25,-1,0,665,666,5,102,0,0,
		666,672,1,0,0,0,667,668,10,1,0,0,668,669,5,65,0,0,669,671,5,102,0,0,670,
		667,1,0,0,0,671,674,1,0,0,0,672,670,1,0,0,0,672,673,1,0,0,0,673,51,1,0,
		0,0,674,672,1,0,0,0,675,681,5,102,0,0,676,677,3,54,27,0,677,678,5,65,0,
		0,678,679,5,102,0,0,679,681,1,0,0,0,680,675,1,0,0,0,680,676,1,0,0,0,681,
		53,1,0,0,0,682,683,6,27,-1,0,683,684,5,102,0,0,684,690,1,0,0,0,685,686,
		10,1,0,0,686,687,5,65,0,0,687,689,5,102,0,0,688,685,1,0,0,0,689,692,1,
		0,0,0,690,688,1,0,0,0,690,691,1,0,0,0,691,55,1,0,0,0,692,690,1,0,0,0,693,
		699,5,102,0,0,694,695,3,60,30,0,695,696,5,65,0,0,696,697,5,102,0,0,697,
		699,1,0,0,0,698,693,1,0,0,0,698,694,1,0,0,0,699,57,1,0,0,0,700,701,5,102,
		0,0,701,59,1,0,0,0,702,703,6,30,-1,0,703,704,5,102,0,0,704,710,1,0,0,0,
		705,706,10,1,0,0,706,707,5,65,0,0,707,709,5,102,0,0,708,705,1,0,0,0,709,
		712,1,0,0,0,710,708,1,0,0,0,710,711,1,0,0,0,711,61,1,0,0,0,712,710,1,0,
		0,0,713,715,3,64,32,0,714,713,1,0,0,0,714,715,1,0,0,0,715,719,1,0,0,0,
		716,718,3,68,34,0,717,716,1,0,0,0,718,721,1,0,0,0,719,717,1,0,0,0,719,
		720,1,0,0,0,720,725,1,0,0,0,721,719,1,0,0,0,722,724,3,78,39,0,723,722,
		1,0,0,0,724,727,1,0,0,0,725,723,1,0,0,0,725,726,1,0,0,0,726,728,1,0,0,
		0,727,725,1,0,0,0,728,729,5,0,0,1,729,63,1,0,0,0,730,732,3,66,33,0,731,
		730,1,0,0,0,732,735,1,0,0,0,733,731,1,0,0,0,733,734,1,0,0,0,734,736,1,
		0,0,0,735,733,1,0,0,0,736,737,5,32,0,0,737,738,3,50,25,0,738,739,5,63,
		0,0,739,65,1,0,0,0,740,741,3,228,114,0,741,67,1,0,0,0,742,747,3,70,35,
		0,743,747,3,72,36,0,744,747,3,74,37,0,745,747,3,76,38,0,746,742,1,0,0,
		0,746,743,1,0,0,0,746,744,1,0,0,0,746,745,1,0,0,0,747,69,1,0,0,0,748,749,
		5,25,0,0,749,750,3,52,26,0,750,751,5,63,0,0,751,71,1,0,0,0,752,753,5,25,
		0,0,753,754,3,54,27,0,754,755,5,65,0,0,755,756,5,83,0,0,756,757,5,63,0,
		0,757,73,1,0,0,0,758,759,5,25,0,0,759,760,5,38,0,0,760,761,3,52,26,0,761,
		762,5,65,0,0,762,763,5,102,0,0,763,764,5,63,0,0,764,75,1,0,0,0,765,766,
		5,25,0,0,766,767,5,38,0,0,767,768,3,52,26,0,768,769,5,65,0,0,769,770,5,
		83,0,0,770,771,5,63,0,0,771,77,1,0,0,0,772,776,3,80,40,0,773,776,3,196,
		98,0,774,776,5,63,0,0,775,772,1,0,0,0,775,773,1,0,0,0,775,774,1,0,0,0,
		776,79,1,0,0,0,777,780,3,82,41,0,778,780,3,184,92,0,779,777,1,0,0,0,779,
		778,1,0,0,0,780,81,1,0,0,0,781,783,3,84,42,0,782,781,1,0,0,0,783,786,1,
		0,0,0,784,782,1,0,0,0,784,785,1,0,0,0,785,787,1,0,0,0,786,784,1,0,0,0,
		787,788,5,9,0,0,788,790,5,102,0,0,789,791,3,86,43,0,790,789,1,0,0,0,790,
		791,1,0,0,0,791,793,1,0,0,0,792,794,3,90,45,0,793,792,1,0,0,0,793,794,
		1,0,0,0,794,796,1,0,0,0,795,797,3,92,46,0,796,795,1,0,0,0,796,797,1,0,
		0,0,797,798,1,0,0,0,798,799,3,96,48,0,799,83,1,0,0,0,800,809,3,228,114,
		0,801,809,5,35,0,0,802,809,5,34,0,0,803,809,5,33,0,0,804,809,5,1,0,0,805,
		809,5,38,0,0,806,809,5,18,0,0,807,809,5,39,0,0,808,800,1,0,0,0,808,801,
		1,0,0,0,808,802,1,0,0,0,808,803,1,0,0,0,808,804,1,0,0,0,808,805,1,0,0,
		0,808,806,1,0,0,0,808,807,1,0,0,0,809,85,1,0,0,0,810,811,5,68,0,0,811,
		812,3,88,44,0,812,813,5,67,0,0,813,87,1,0,0,0,814,819,3,32,16,0,815,816,
		5,64,0,0,816,818,3,32,16,0,817,815,1,0,0,0,818,821,1,0,0,0,819,817,1,0,
		0,0,819,820,1,0,0,0,820,89,1,0,0,0,821,819,1,0,0,0,822,823,5,17,0,0,823,
		824,3,14,7,0,824,91,1,0,0,0,825,826,5,24,0,0,826,827,3,94,47,0,827,93,
		1,0,0,0,828,833,3,20,10,0,829,830,5,64,0,0,830,832,3,20,10,0,831,829,1,
		0,0,0,832,835,1,0,0,0,833,831,1,0,0,0,833,834,1,0,0,0,834,95,1,0,0,0,835,
		833,1,0,0,0,836,840,5,59,0,0,837,839,3,98,49,0,838,837,1,0,0,0,839,842,
		1,0,0,0,840,838,1,0,0,0,840,841,1,0,0,0,841,843,1,0,0,0,842,840,1,0,0,
		0,843,844,5,60,0,0,844,97,1,0,0,0,845,850,3,100,50,0,846,850,3,168,84,
		0,847,850,3,170,85,0,848,850,3,172,86,0,849,845,1,0,0,0,849,846,1,0,0,
		0,849,847,1,0,0,0,849,848,1,0,0,0,850,99,1,0,0,0,851,857,3,102,51,0,852,
		857,3,138,69,0,853,857,3,80,40,0,854,857,3,196,98,0,855,857,5,63,0,0,856,
		851,1,0,0,0,856,852,1,0,0,0,856,853,1,0,0,0,856,854,1,0,0,0,856,855,1,
		0,0,0,857,101,1,0,0,0,858,860,3,104,52,0,859,858,1,0,0,0,860,863,1,0,0,
		0,861,859,1,0,0,0,861,862,1,0,0,0,862,864,1,0,0,0,863,861,1,0,0,0,864,
		865,3,114,57,0,865,866,3,106,53,0,866,867,5,63,0,0,867,103,1,0,0,0,868,
		877,3,228,114,0,869,877,5,35,0,0,870,877,5,34,0,0,871,877,5,33,0,0,872,
		877,5,38,0,0,873,877,5,18,0,0,874,877,5,46,0,0,875,877,5,49,0,0,876,868,
		1,0,0,0,876,869,1,0,0,0,876,870,1,0,0,0,876,871,1,0,0,0,876,872,1,0,0,
		0,876,873,1,0,0,0,876,874,1,0,0,0,876,875,1,0,0,0,877,105,1,0,0,0,878,
		883,3,108,54,0,879,880,5,64,0,0,880,882,3,108,54,0,881,879,1,0,0,0,882,
		885,1,0,0,0,883,881,1,0,0,0,883,884,1,0,0,0,884,107,1,0,0,0,885,883,1,
		0,0,0,886,889,3,110,55,0,887,888,5,66,0,0,888,890,3,112,56,0,889,887,1,
		0,0,0,889,890,1,0,0,0,890,109,1,0,0,0,891,893,5,102,0,0,892,894,3,30,15,
		0,893,892,1,0,0,0,893,894,1,0,0,0,894,111,1,0,0,0,895,898,3,412,206,0,
		896,898,3,246,123,0,897,895,1,0,0,0,897,896,1,0,0,0,898,113,1,0,0,0,899,
		902,3,116,58,0,900,902,3,118,59,0,901,899,1,0,0,0,901,900,1,0,0,0,902,
		115,1,0,0,0,903,906,3,4,2,0,904,906,5,3,0,0,905,903,1,0,0,0,905,904,1,
		0,0,0,906,117,1,0,0,0,907,911,3,120,60,0,908,911,3,134,67,0,909,911,3,
		136,68,0,910,907,1,0,0,0,910,908,1,0,0,0,910,909,1,0,0,0,911,119,1,0,0,
		0,912,915,3,126,63,0,913,915,3,132,66,0,914,912,1,0,0,0,914,913,1,0,0,
		0,915,920,1,0,0,0,916,919,3,124,62,0,917,919,3,130,65,0,918,916,1,0,0,
		0,918,917,1,0,0,0,919,922,1,0,0,0,920,918,1,0,0,0,920,921,1,0,0,0,921,
		121,1,0,0,0,922,920,1,0,0,0,923,925,5,102,0,0,924,926,3,40,20,0,925,924,
		1,0,0,0,925,926,1,0,0,0,926,940,1,0,0,0,927,928,3,120,60,0,928,932,5,65,
		0,0,929,931,3,228,114,0,930,929,1,0,0,0,931,934,1,0,0,0,932,930,1,0,0,
		0,932,933,1,0,0,0,933,935,1,0,0,0,934,932,1,0,0,0,935,937,5,102,0,0,936,
		938,3,40,20,0,937,936,1,0,0,0,937,938,1,0,0,0,938,940,1,0,0,0,939,923,
		1,0,0,0,939,927,1,0,0,0,940,123,1,0,0,0,941,945,5,65,0,0,942,944,3,228,
		114,0,943,942,1,0,0,0,944,947,1,0,0,0,945,943,1,0,0,0,945,946,1,0,0,0,
		946,948,1,0,0,0,947,945,1,0,0,0,948,950,5,102,0,0,949,951,3,40,20,0,950,
		949,1,0,0,0,950,951,1,0,0,0,951,125,1,0,0,0,952,954,5,102,0,0,953,955,
		3,40,20,0,954,953,1,0,0,0,954,955,1,0,0,0,955,127,1,0,0,0,956,957,3,122,
		61,0,957,129,1,0,0,0,958,959,3,124,62,0,959,131,1,0,0,0,960,961,3,126,
		63,0,961,133,1,0,0,0,962,963,5,102,0,0,963,135,1,0,0,0,964,965,3,116,58,
		0,965,966,3,30,15,0,966,974,1,0,0,0,967,968,3,120,60,0,968,969,3,30,15,
		0,969,974,1,0,0,0,970,971,3,134,67,0,971,972,3,30,15,0,972,974,1,0,0,0,
		973,964,1,0,0,0,973,967,1,0,0,0,973,970,1,0,0,0,974,137,1,0,0,0,975,977,
		3,140,70,0,976,975,1,0,0,0,977,980,1,0,0,0,978,976,1,0,0,0,978,979,1,0,
		0,0,979,981,1,0,0,0,980,978,1,0,0,0,981,982,3,142,71,0,982,983,3,166,83,
		0,983,139,1,0,0,0,984,995,3,228,114,0,985,995,5,35,0,0,986,995,5,34,0,
		0,987,995,5,33,0,0,988,995,5,1,0,0,989,995,5,38,0,0,990,995,5,18,0,0,991,
		995,5,42,0,0,992,995,5,30,0,0,993,995,5,39,0,0,994,984,1,0,0,0,994,985,
		1,0,0,0,994,986,1,0,0,0,994,987,1,0,0,0,994,988,1,0,0,0,994,989,1,0,0,
		0,994,990,1,0,0,0,994,991,1,0,0,0,994,992,1,0,0,0,994,993,1,0,0,0,995,
		141,1,0,0,0,996,997,3,144,72,0,997,999,3,146,73,0,998,1000,3,160,80,0,
		999,998,1,0,0,0,999,1000,1,0,0,0,1000,1014,1,0,0,0,1001,1005,3,86,43,0,
		1002,1004,3,228,114,0,1003,1002,1,0,0,0,1004,1007,1,0,0,0,1005,1003,1,
		0,0,0,1005,1006,1,0,0,0,1006,1008,1,0,0,0,1007,1005,1,0,0,0,1008,1009,
		3,144,72,0,1009,1011,3,146,73,0,1010,1012,3,160,80,0,1011,1010,1,0,0,0,
		1011,1012,1,0,0,0,1012,1014,1,0,0,0,1013,996,1,0,0,0,1013,1001,1,0,0,0,
		1014,143,1,0,0,0,1015,1018,3,114,57,0,1016,1018,5,48,0,0,1017,1015,1,0,
		0,0,1017,1016,1,0,0,0,1018,145,1,0,0,0,1019,1020,5,102,0,0,1020,1022,5,
		57,0,0,1021,1023,3,148,74,0,1022,1021,1,0,0,0,1022,1023,1,0,0,0,1023,1024,
		1,0,0,0,1024,1026,5,58,0,0,1025,1027,3,30,15,0,1026,1025,1,0,0,0,1026,
		1027,1,0,0,0,1027,147,1,0,0,0,1028,1035,3,158,79,0,1029,1030,3,150,75,
		0,1030,1031,5,64,0,0,1031,1032,3,156,78,0,1032,1035,1,0,0,0,1033,1035,
		3,156,78,0,1034,1028,1,0,0,0,1034,1029,1,0,0,0,1034,1033,1,0,0,0,1035,
		149,1,0,0,0,1036,1041,3,152,76,0,1037,1038,5,64,0,0,1038,1040,3,152,76,
		0,1039,1037,1,0,0,0,1040,1043,1,0,0,0,1041,1039,1,0,0,0,1041,1042,1,0,
		0,0,1042,1053,1,0,0,0,1043,1041,1,0,0,0,1044,1049,3,158,79,0,1045,1046,
		5,64,0,0,1046,1048,3,152,76,0,1047,1045,1,0,0,0,1048,1051,1,0,0,0,1049,
		1047,1,0,0,0,1049,1050,1,0,0,0,1050,1053,1,0,0,0,1051,1049,1,0,0,0,1052,
		1036,1,0,0,0,1052,1044,1,0,0,0,1053,151,1,0,0,0,1054,1056,3,154,77,0,1055,
		1054,1,0,0,0,1056,1059,1,0,0,0,1057,1055,1,0,0,0,1057,1058,1,0,0,0,1058,
		1060,1,0,0,0,1059,1057,1,0,0,0,1060,1061,3,114,57,0,1061,1062,3,110,55,
		0,1062,153,1,0,0,0,1063,1066,3,228,114,0,1064,1066,5,18,0,0,1065,1063,
		1,0,0,0,1065,1064,1,0,0,0,1066,155,1,0,0,0,1067,1069,3,154,77,0,1068,1067,
		1,0,0,0,1069,1072,1,0,0,0,1070,1068,1,0,0,0,1070,1071,1,0,0,0,1071,1073,
		1,0,0,0,1072,1070,1,0,0,0,1073,1077,3,114,57,0,1074,1076,3,228,114,0,1075,
		1074,1,0,0,0,1076,1079,1,0,0,0,1077,1075,1,0,0,0,1077,1078,1,0,0,0,1078,
		1080,1,0,0,0,1079,1077,1,0,0,0,1080,1081,5,104,0,0,1081,1082,3,110,55,
		0,1082,1085,1,0,0,0,1083,1085,3,152,76,0,1084,1070,1,0,0,0,1084,1083,1,
		0,0,0,1085,157,1,0,0,0,1086,1088,3,228,114,0,1087,1086,1,0,0,0,1088,1091,
		1,0,0,0,1089,1087,1,0,0,0,1089,1090,1,0,0,0,1090,1092,1,0,0,0,1091,1089,
		1,0,0,0,1092,1095,3,114,57,0,1093,1094,5,102,0,0,1094,1096,5,65,0,0,1095,
		1093,1,0,0,0,1095,1096,1,0,0,0,1096,1097,1,0,0,0,1097,1098,5,43,0,0,1098,
		159,1,0,0,0,1099,1100,5,45,0,0,1100,1101,3,162,81,0,1101,161,1,0,0,0,1102,
		1107,3,164,82,0,1103,1104,5,64,0,0,1104,1106,3,164,82,0,1105,1103,1,0,
		0,0,1106,1109,1,0,0,0,1107,1105,1,0,0,0,1107,1108,1,0,0,0,1108,163,1,0,
		0,0,1109,1107,1,0,0,0,1110,1113,3,14,7,0,1111,1113,3,26,13,0,1112,1110,
		1,0,0,0,1112,1111,1,0,0,0,1113,165,1,0,0,0,1114,1117,3,250,125,0,1115,
		1117,5,63,0,0,1116,1114,1,0,0,0,1116,1115,1,0,0,0,1117,167,1,0,0,0,1118,
		1119,3,250,125,0,1119,169,1,0,0,0,1120,1121,5,38,0,0,1121,1122,3,250,125,
		0,1122,171,1,0,0,0,1123,1125,3,174,87,0,1124,1123,1,0,0,0,1125,1128,1,
		0,0,0,1126,1124,1,0,0,0,1126,1127,1,0,0,0,1127,1129,1,0,0,0,1128,1126,
		1,0,0,0,1129,1131,3,176,88,0,1130,1132,3,160,80,0,1131,1130,1,0,0,0,1131,
		1132,1,0,0,0,1132,1133,1,0,0,0,1133,1134,3,180,90,0,1134,173,1,0,0,0,1135,
		1140,3,228,114,0,1136,1140,5,35,0,0,1137,1140,5,34,0,0,1138,1140,5,33,
		0,0,1139,1135,1,0,0,0,1139,1136,1,0,0,0,1139,1137,1,0,0,0,1139,1138,1,
		0,0,0,1140,175,1,0,0,0,1141,1143,3,86,43,0,1142,1141,1,0,0,0,1142,1143,
		1,0,0,0,1143,1144,1,0,0,0,1144,1145,3,178,89,0,1145,1147,5,57,0,0,1146,
		1148,3,148,74,0,1147,1146,1,0,0,0,1147,1148,1,0,0,0,1148,1149,1,0,0,0,
		1149,1150,5,58,0,0,1150,177,1,0,0,0,1151,1152,5,102,0,0,1152,179,1,0,0,
		0,1153,1155,5,59,0,0,1154,1156,3,182,91,0,1155,1154,1,0,0,0,1155,1156,
		1,0,0,0,1156,1158,1,0,0,0,1157,1159,3,252,126,0,1158,1157,1,0,0,0,1158,
		1159,1,0,0,0,1159,1160,1,0,0,0,1160,1161,5,60,0,0,1161,181,1,0,0,0,1162,
		1164,3,40,20,0,1163,1162,1,0,0,0,1163,1164,1,0,0,0,1164,1165,1,0,0,0,1165,
		1166,5,43,0,0,1166,1168,5,57,0,0,1167,1169,3,396,198,0,1168,1167,1,0,0,
		0,1168,1169,1,0,0,0,1169,1170,1,0,0,0,1170,1171,5,58,0,0,1171,1209,5,63,
		0,0,1172,1174,3,40,20,0,1173,1172,1,0,0,0,1173,1174,1,0,0,0,1174,1175,
		1,0,0,0,1175,1176,5,40,0,0,1176,1178,5,57,0,0,1177,1179,3,396,198,0,1178,
		1177,1,0,0,0,1178,1179,1,0,0,0,1179,1180,1,0,0,0,1180,1181,5,58,0,0,1181,
		1209,5,63,0,0,1182,1183,3,56,28,0,1183,1185,5,65,0,0,1184,1186,3,40,20,
		0,1185,1184,1,0,0,0,1185,1186,1,0,0,0,1186,1187,1,0,0,0,1187,1188,5,40,
		0,0,1188,1190,5,57,0,0,1189,1191,3,396,198,0,1190,1189,1,0,0,0,1190,1191,
		1,0,0,0,1191,1192,1,0,0,0,1192,1193,5,58,0,0,1193,1194,5,63,0,0,1194,1209,
		1,0,0,0,1195,1196,3,350,175,0,1196,1198,5,65,0,0,1197,1199,3,40,20,0,1198,
		1197,1,0,0,0,1198,1199,1,0,0,0,1199,1200,1,0,0,0,1200,1201,5,40,0,0,1201,
		1203,5,57,0,0,1202,1204,3,396,198,0,1203,1202,1,0,0,0,1203,1204,1,0,0,
		0,1204,1205,1,0,0,0,1205,1206,5,58,0,0,1206,1207,5,63,0,0,1207,1209,1,
		0,0,0,1208,1163,1,0,0,0,1208,1173,1,0,0,0,1208,1182,1,0,0,0,1208,1195,
		1,0,0,0,1209,183,1,0,0,0,1210,1212,3,84,42,0,1211,1210,1,0,0,0,1212,1215,
		1,0,0,0,1213,1211,1,0,0,0,1213,1214,1,0,0,0,1214,1216,1,0,0,0,1215,1213,
		1,0,0,0,1216,1217,5,16,0,0,1217,1219,5,102,0,0,1218,1220,3,92,46,0,1219,
		1218,1,0,0,0,1219,1220,1,0,0,0,1220,1221,1,0,0,0,1221,1222,3,186,93,0,
		1222,185,1,0,0,0,1223,1225,5,59,0,0,1224,1226,3,188,94,0,1225,1224,1,0,
		0,0,1225,1226,1,0,0,0,1226,1228,1,0,0,0,1227,1229,5,64,0,0,1228,1227,1,
		0,0,0,1228,1229,1,0,0,0,1229,1231,1,0,0,0,1230,1232,3,194,97,0,1231,1230,
		1,0,0,0,1231,1232,1,0,0,0,1232,1233,1,0,0,0,1233,1234,5,60,0,0,1234,187,
		1,0,0,0,1235,1240,3,190,95,0,1236,1237,5,64,0,0,1237,1239,3,190,95,0,1238,
		1236,1,0,0,0,1239,1242,1,0,0,0,1240,1238,1,0,0,0,1240,1241,1,0,0,0,1241,
		189,1,0,0,0,1242,1240,1,0,0,0,1243,1245,3,192,96,0,1244,1243,1,0,0,0,1245,
		1248,1,0,0,0,1246,1244,1,0,0,0,1246,1247,1,0,0,0,1247,1249,1,0,0,0,1248,
		1246,1,0,0,0,1249,1255,5,102,0,0,1250,1252,5,57,0,0,1251,1253,3,396,198,
		0,1252,1251,1,0,0,0,1252,1253,1,0,0,0,1253,1254,1,0,0,0,1254,1256,5,58,
		0,0,1255,1250,1,0,0,0,1255,1256,1,0,0,0,1256,1258,1,0,0,0,1257,1259,3,
		96,48,0,1258,1257,1,0,0,0,1258,1259,1,0,0,0,1259,191,1,0,0,0,1260,1261,
		3,228,114,0,1261,193,1,0,0,0,1262,1266,5,63,0,0,1263,1265,3,98,49,0,1264,
		1263,1,0,0,0,1265,1268,1,0,0,0,1266,1264,1,0,0,0,1266,1267,1,0,0,0,1267,
		195,1,0,0,0,1268,1266,1,0,0,0,1269,1272,3,198,99,0,1270,1272,3,216,108,
		0,1271,1269,1,0,0,0,1271,1270,1,0,0,0,1272,197,1,0,0,0,1273,1275,3,200,
		100,0,1274,1273,1,0,0,0,1275,1278,1,0,0,0,1276,1274,1,0,0,0,1276,1277,
		1,0,0,0,1277,1279,1,0,0,0,1278,1276,1,0,0,0,1279,1280,5,28,0,0,1280,1282,
		5,102,0,0,1281,1283,3,86,43,0,1282,1281,1,0,0,0,1282,1283,1,0,0,0,1283,
		1285,1,0,0,0,1284,1286,3,202,101,0,1285,1284,1,0,0,0,1285,1286,1,0,0,0,
		1286,1287,1,0,0,0,1287,1288,3,204,102,0,1288,199,1,0,0,0,1289,1297,3,228,
		114,0,1290,1297,5,35,0,0,1291,1297,5,34,0,0,1292,1297,5,33,0,0,1293,1297,
		5,1,0,0,1294,1297,5,38,0,0,1295,1297,5,39,0,0,1296,1289,1,0,0,0,1296,1290,
		1,0,0,0,1296,1291,1,0,0,0,1296,1292,1,0,0,0,1296,1293,1,0,0,0,1296,1294,
		1,0,0,0,1296,1295,1,0,0,0,1297,201,1,0,0,0,1298,1299,5,17,0,0,1299,1300,
		3,94,47,0,1300,203,1,0,0,0,1301,1305,5,59,0,0,1302,1304,3,206,103,0,1303,
		1302,1,0,0,0,1304,1307,1,0,0,0,1305,1303,1,0,0,0,1305,1306,1,0,0,0,1306,
		1308,1,0,0,0,1307,1305,1,0,0,0,1308,1309,5,60,0,0,1309,205,1,0,0,0,1310,
		1316,3,208,104,0,1311,1316,3,212,106,0,1312,1316,3,80,40,0,1313,1316,3,
		196,98,0,1314,1316,5,63,0,0,1315,1310,1,0,0,0,1315,1311,1,0,0,0,1315,1312,
		1,0,0,0,1315,1313,1,0,0,0,1315,1314,1,0,0,0,1316,207,1,0,0,0,1317,1319,
		3,210,105,0,1318,1317,1,0,0,0,1319,1322,1,0,0,0,1320,1318,1,0,0,0,1320,
		1321,1,0,0,0,1321,1323,1,0,0,0,1322,1320,1,0,0,0,1323,1324,3,114,57,0,
		1324,1325,3,106,53,0,1325,1326,5,63,0,0,1326,209,1,0,0,0,1327,1332,3,228,
		114,0,1328,1332,5,35,0,0,1329,1332,5,38,0,0,1330,1332,5,18,0,0,1331,1327,
		1,0,0,0,1331,1328,1,0,0,0,1331,1329,1,0,0,0,1331,1330,1,0,0,0,1332,211,
		1,0,0,0,1333,1335,3,214,107,0,1334,1333,1,0,0,0,1335,1338,1,0,0,0,1336,
		1334,1,0,0,0,1336,1337,1,0,0,0,1337,1339,1,0,0,0,1338,1336,1,0,0,0,1339,
		1340,3,142,71,0,1340,1341,3,166,83,0,1341,213,1,0,0,0,1342,1349,3,228,
		114,0,1343,1349,5,35,0,0,1344,1349,5,1,0,0,1345,1349,5,12,0,0,1346,1349,
		5,38,0,0,1347,1349,5,39,0,0,1348,1342,1,0,0,0,1348,1343,1,0,0,0,1348,1344,
		1,0,0,0,1348,1345,1,0,0,0,1348,1346,1,0,0,0,1348,1347,1,0,0,0,1349,215,
		1,0,0,0,1350,1352,3,200,100,0,1351,1350,1,0,0,0,1352,1355,1,0,0,0,1353,
		1351,1,0,0,0,1353,1354,1,0,0,0,1354,1356,1,0,0,0,1355,1353,1,0,0,0,1356,
		1357,5,103,0,0,1357,1358,5,28,0,0,1358,1359,5,102,0,0,1359,1360,3,218,
		109,0,1360,217,1,0,0,0,1361,1365,5,59,0,0,1362,1364,3,220,110,0,1363,1362,
		1,0,0,0,1364,1367,1,0,0,0,1365,1363,1,0,0,0,1365,1366,1,0,0,0,1366,1368,
		1,0,0,0,1367,1365,1,0,0,0,1368,1369,5,60,0,0,1369,219,1,0,0,0,1370,1376,
		3,222,111,0,1371,1376,3,208,104,0,1372,1376,3,80,40,0,1373,1376,3,196,
		98,0,1374,1376,5,63,0,0,1375,1370,1,0,0,0,1375,1371,1,0,0,0,1375,1372,
		1,0,0,0,1375,1373,1,0,0,0,1375,1374,1,0,0,0,1376,221,1,0,0,0,1377,1379,
		3,224,112,0,1378,1377,1,0,0,0,1379,1382,1,0,0,0,1380,1378,1,0,0,0,1380,
		1381,1,0,0,0,1381,1383,1,0,0,0,1382,1380,1,0,0,0,1383,1384,3,114,57,0,
		1384,1385,5,102,0,0,1385,1386,5,57,0,0,1386,1388,5,58,0,0,1387,1389,3,
		30,15,0,1388,1387,1,0,0,0,1388,1389,1,0,0,0,1389,1391,1,0,0,0,1390,1392,
		3,226,113,0,1391,1390,1,0,0,0,1391,1392,1,0,0,0,1392,1393,1,0,0,0,1393,
		1394,5,63,0,0,1394,223,1,0,0,0,1395,1399,3,228,114,0,1396,1399,5,35,0,
		0,1397,1399,5,1,0,0,1398,1395,1,0,0,0,1398,1396,1,0,0,0,1398,1397,1,0,
		0,0,1399,225,1,0,0,0,1400,1401,5,12,0,0,1401,1402,3,236,118,0,1402,227,
		1,0,0,0,1403,1407,3,230,115,0,1404,1407,3,242,121,0,1405,1407,3,244,122,
		0,1406,1403,1,0,0,0,1406,1404,1,0,0,0,1406,1405,1,0,0,0,1407,229,1,0,0,
		0,1408,1409,5,103,0,0,1409,1410,3,52,26,0,1410,1412,5,57,0,0,1411,1413,
		3,232,116,0,1412,1411,1,0,0,0,1412,1413,1,0,0,0,1413,1414,1,0,0,0,1414,
		1415,5,58,0,0,1415,231,1,0,0,0,1416,1421,3,234,117,0,1417,1418,5,64,0,
		0,1418,1420,3,234,117,0,1419,1417,1,0,0,0,1420,1423,1,0,0,0,1421,1419,
		1,0,0,0,1421,1422,1,0,0,0,1422,233,1,0,0,0,1423,1421,1,0,0,0,1424,1425,
		5,102,0,0,1425,1426,5,66,0,0,1426,1427,3,236,118,0,1427,235,1,0,0,0,1428,
		1432,3,430,215,0,1429,1432,3,238,119,0,1430,1432,3,228,114,0,1431,1428,
		1,0,0,0,1431,1429,1,0,0,0,1431,1430,1,0,0,0,1432,237,1,0,0,0,1433,1435,
		5,59,0,0,1434,1436,3,240,120,0,1435,1434,1,0,0,0,1435,1436,1,0,0,0,1436,
		1438,1,0,0,0,1437,1439,5,64,0,0,1438,1437,1,0,0,0,1438,1439,1,0,0,0,1439,
		1440,1,0,0,0,1440,1441,5,60,0,0,1441,239,1,0,0,0,1442,1447,3,236,118,0,
		1443,1444,5,64,0,0,1444,1446,3,236,118,0,1445,1443,1,0,0,0,1446,1449,1,
		0,0,0,1447,1445,1,0,0,0,1447,1448,1,0,0,0,1448,241,1,0,0,0,1449,1447,1,
		0,0,0,1450,1451,5,103,0,0,1451,1452,3,52,26,0,1452,243,1,0,0,0,1453,1454,
		5,103,0,0,1454,1455,3,52,26,0,1455,1456,5,57,0,0,1456,1457,3,236,118,0,
		1457,1458,5,58,0,0,1458,245,1,0,0,0,1459,1461,5,59,0,0,1460,1462,3,248,
		124,0,1461,1460,1,0,0,0,1461,1462,1,0,0,0,1462,1464,1,0,0,0,1463,1465,
		5,64,0,0,1464,1463,1,0,0,0,1464,1465,1,0,0,0,1465,1466,1,0,0,0,1466,1467,
		5,60,0,0,1467,247,1,0,0,0,1468,1473,3,112,56,0,1469,1470,5,64,0,0,1470,
		1472,3,112,56,0,1471,1469,1,0,0,0,1472,1475,1,0,0,0,1473,1471,1,0,0,0,
		1473,1474,1,0,0,0,1474,249,1,0,0,0,1475,1473,1,0,0,0,1476,1478,5,59,0,
		0,1477,1479,3,252,126,0,1478,1477,1,0,0,0,1478,1479,1,0,0,0,1479,1480,
		1,0,0,0,1480,1481,5,60,0,0,1481,251,1,0,0,0,1482,1484,3,254,127,0,1483,
		1482,1,0,0,0,1484,1485,1,0,0,0,1485,1483,1,0,0,0,1485,1486,1,0,0,0,1486,
		253,1,0,0,0,1487,1491,3,256,128,0,1488,1491,3,80,40,0,1489,1491,3,260,
		130,0,1490,1487,1,0,0,0,1490,1488,1,0,0,0,1490,1489,1,0,0,0,1491,255,1,
		0,0,0,1492,1493,3,258,129,0,1493,1494,5,63,0,0,1494,257,1,0,0,0,1495,1497,
		3,154,77,0,1496,1495,1,0,0,0,1497,1500,1,0,0,0,1498,1496,1,0,0,0,1498,
		1499,1,0,0,0,1499,1501,1,0,0,0,1500,1498,1,0,0,0,1501,1502,3,114,57,0,
		1502,1503,3,106,53,0,1503,259,1,0,0,0,1504,1511,3,264,132,0,1505,1511,
		3,268,134,0,1506,1511,3,276,138,0,1507,1511,3,278,139,0,1508,1511,3,296,
		148,0,1509,1511,3,302,151,0,1510,1504,1,0,0,0,1510,1505,1,0,0,0,1510,1506,
		1,0,0,0,1510,1507,1,0,0,0,1510,1508,1,0,0,0,1510,1509,1,0,0,0,1511,261,
		1,0,0,0,1512,1518,3,264,132,0,1513,1518,3,270,135,0,1514,1518,3,280,140,
		0,1515,1518,3,298,149,0,1516,1518,3,304,152,0,1517,1512,1,0,0,0,1517,1513,
		1,0,0,0,1517,1514,1,0,0,0,1517,1515,1,0,0,0,1517,1516,1,0,0,0,1518,263,
		1,0,0,0,1519,1532,3,250,125,0,1520,1532,3,266,133,0,1521,1532,3,272,136,
		0,1522,1532,3,282,141,0,1523,1532,3,284,142,0,1524,1532,3,300,150,0,1525,
		1532,3,320,160,0,1526,1532,3,322,161,0,1527,1532,3,324,162,0,1528,1532,
		3,328,164,0,1529,1532,3,326,163,0,1530,1532,3,330,165,0,1531,1519,1,0,
		0,0,1531,1520,1,0,0,0,1531,1521,1,0,0,0,1531,1522,1,0,0,0,1531,1523,1,
		0,0,0,1531,1524,1,0,0,0,1531,1525,1,0,0,0,1531,1526,1,0,0,0,1531,1527,
		1,0,0,0,1531,1528,1,0,0,0,1531,1529,1,0,0,0,1531,1530,1,0,0,0,1532,265,
		1,0,0,0,1533,1534,5,63,0,0,1534,267,1,0,0,0,1535,1536,5,102,0,0,1536,1537,
		5,72,0,0,1537,1538,3,260,130,0,1538,269,1,0,0,0,1539,1540,5,102,0,0,1540,
		1541,5,72,0,0,1541,1542,3,262,131,0,1542,271,1,0,0,0,1543,1544,3,274,137,
		0,1544,1545,5,63,0,0,1545,273,1,0,0,0,1546,1554,3,424,212,0,1547,1554,
		3,454,227,0,1548,1554,3,456,228,0,1549,1554,3,462,231,0,1550,1554,3,466,
		233,0,1551,1554,3,390,195,0,1552,1554,3,370,185,0,1553,1546,1,0,0,0,1553,
		1547,1,0,0,0,1553,1548,1,0,0,0,1553,1549,1,0,0,0,1553,1550,1,0,0,0,1553,
		1551,1,0,0,0,1553,1552,1,0,0,0,1554,275,1,0,0,0,1555,1556,5,22,0,0,1556,
		1557,5,57,0,0,1557,1558,3,412,206,0,1558,1559,5,58,0,0,1559,1560,3,260,
		130,0,1560,277,1,0,0,0,1561,1562,5,22,0,0,1562,1563,5,57,0,0,1563,1564,
		3,412,206,0,1564,1565,5,58,0,0,1565,1566,3,262,131,0,1566,1567,5,15,0,
		0,1567,1568,3,260,130,0,1568,279,1,0,0,0,1569,1570,5,22,0,0,1570,1571,
		5,57,0,0,1571,1572,3,412,206,0,1572,1573,5,58,0,0,1573,1574,3,262,131,
		0,1574,1575,5,15,0,0,1575,1576,3,262,131,0,1576,281,1,0,0,0,1577,1578,
		5,2,0,0,1578,1579,3,412,206,0,1579,1580,5,63,0,0,1580,1588,1,0,0,0,1581,
		1582,5,2,0,0,1582,1583,3,412,206,0,1583,1584,5,72,0,0,1584,1585,3,412,
		206,0,1585,1586,5,63,0,0,1586,1588,1,0,0,0,1587,1577,1,0,0,0,1587,1581,
		1,0,0,0,1588,283,1,0,0,0,1589,1590,5,41,0,0,1590,1591,5,57,0,0,1591,1592,
		3,412,206,0,1592,1593,5,58,0,0,1593,1594,3,286,143,0,1594,285,1,0,0,0,
		1595,1599,5,59,0,0,1596,1598,3,288,144,0,1597,1596,1,0,0,0,1598,1601,1,
		0,0,0,1599,1597,1,0,0,0,1599,1600,1,0,0,0,1600,1605,1,0,0,0,1601,1599,
		1,0,0,0,1602,1604,3,292,146,0,1603,1602,1,0,0,0,1604,1607,1,0,0,0,1605,
		1603,1,0,0,0,1605,1606,1,0,0,0,1606,1608,1,0,0,0,1607,1605,1,0,0,0,1608,
		1609,5,60,0,0,1609,287,1,0,0,0,1610,1611,3,290,145,0,1611,1612,3,252,126,
		0,1612,289,1,0,0,0,1613,1617,3,292,146,0,1614,1616,3,292,146,0,1615,1614,
		1,0,0,0,1616,1619,1,0,0,0,1617,1615,1,0,0,0,1617,1618,1,0,0,0,1618,291,
		1,0,0,0,1619,1617,1,0,0,0,1620,1621,5,6,0,0,1621,1622,3,410,205,0,1622,
		1623,5,72,0,0,1623,1631,1,0,0,0,1624,1625,5,6,0,0,1625,1626,3,294,147,
		0,1626,1627,5,72,0,0,1627,1631,1,0,0,0,1628,1629,5,12,0,0,1629,1631,5,
		72,0,0,1630,1620,1,0,0,0,1630,1624,1,0,0,0,1630,1628,1,0,0,0,1631,293,
		1,0,0,0,1632,1633,5,102,0,0,1633,295,1,0,0,0,1634,1635,5,50,0,0,1635,1636,
		5,57,0,0,1636,1637,3,412,206,0,1637,1638,5,58,0,0,1638,1639,3,260,130,
		0,1639,297,1,0,0,0,1640,1641,5,50,0,0,1641,1642,5,57,0,0,1642,1643,3,412,
		206,0,1643,1644,5,58,0,0,1644,1645,3,262,131,0,1645,299,1,0,0,0,1646,1647,
		5,13,0,0,1647,1648,3,260,130,0,1648,1649,5,50,0,0,1649,1650,5,57,0,0,1650,
		1651,3,412,206,0,1651,1652,5,58,0,0,1652,1653,5,63,0,0,1653,301,1,0,0,
		0,1654,1657,3,306,153,0,1655,1657,3,316,158,0,1656,1654,1,0,0,0,1656,1655,
		1,0,0,0,1657,303,1,0,0,0,1658,1661,3,308,154,0,1659,1661,3,318,159,0,1660,
		1658,1,0,0,0,1660,1659,1,0,0,0,1661,305,1,0,0,0,1662,1663,5,21,0,0,1663,
		1665,5,57,0,0,1664,1666,3,310,155,0,1665,1664,1,0,0,0,1665,1666,1,0,0,
		0,1666,1667,1,0,0,0,1667,1669,5,63,0,0,1668,1670,3,412,206,0,1669,1668,
		1,0,0,0,1669,1670,1,0,0,0,1670,1671,1,0,0,0,1671,1673,5,63,0,0,1672,1674,
		3,312,156,0,1673,1672,1,0,0,0,1673,1674,1,0,0,0,1674,1675,1,0,0,0,1675,
		1676,5,58,0,0,1676,1677,3,260,130,0,1677,307,1,0,0,0,1678,1679,5,21,0,
		0,1679,1681,5,57,0,0,1680,1682,3,310,155,0,1681,1680,1,0,0,0,1681,1682,
		1,0,0,0,1682,1683,1,0,0,0,1683,1685,5,63,0,0,1684,1686,3,412,206,0,1685,
		1684,1,0,0,0,1685,1686,1,0,0,0,1686,1687,1,0,0,0,1687,1689,5,63,0,0,1688,
		1690,3,312,156,0,1689,1688,1,0,0,0,1689,1690,1,0,0,0,1690,1691,1,0,0,0,
		1691,1692,5,58,0,0,1692,1693,3,262,131,0,1693,309,1,0,0,0,1694,1697,3,
		314,157,0,1695,1697,3,258,129,0,1696,1694,1,0,0,0,1696,1695,1,0,0,0,1697,
		311,1,0,0,0,1698,1699,3,314,157,0,1699,313,1,0,0,0,1700,1705,3,274,137,
		0,1701,1702,5,64,0,0,1702,1704,3,274,137,0,1703,1701,1,0,0,0,1704,1707,
		1,0,0,0,1705,1703,1,0,0,0,1705,1706,1,0,0,0,1706,315,1,0,0,0,1707,1705,
		1,0,0,0,1708,1709,5,21,0,0,1709,1713,5,57,0,0,1710,1712,3,154,77,0,1711,
		1710,1,0,0,0,1712,1715,1,0,0,0,1713,1711,1,0,0,0,1713,1714,1,0,0,0,1714,
		1716,1,0,0,0,1715,1713,1,0,0,0,1716,1717,3,114,57,0,1717,1718,3,110,55,
		0,1718,1719,5,72,0,0,1719,1720,3,412,206,0,1720,1721,5,58,0,0,1721,1722,
		3,260,130,0,1722,317,1,0,0,0,1723,1724,5,21,0,0,1724,1728,5,57,0,0,1725,
		1727,3,154,77,0,1726,1725,1,0,0,0,1727,1730,1,0,0,0,1728,1726,1,0,0,0,
		1728,1729,1,0,0,0,1729,1731,1,0,0,0,1730,1728,1,0,0,0,1731,1732,3,114,
		57,0,1732,1733,3,110,55,0,1733,1734,5,72,0,0,1734,1735,3,412,206,0,1735,
		1736,5,58,0,0,1736,1737,3,262,131,0,1737,319,1,0,0,0,1738,1740,5,4,0,0,
		1739,1741,5,102,0,0,1740,1739,1,0,0,0,1740,1741,1,0,0,0,1741,1742,1,0,
		0,0,1742,1743,5,63,0,0,1743,321,1,0,0,0,1744,1746,5,11,0,0,1745,1747,5,
		102,0,0,1746,1745,1,0,0,0,1746,1747,1,0,0,0,1747,1748,1,0,0,0,1748,1749,
		5,63,0,0,1749,323,1,0,0,0,1750,1752,5,36,0,0,1751,1753,3,412,206,0,1752,
		1751,1,0,0,0,1752,1753,1,0,0,0,1753,1754,1,0,0,0,1754,1755,5,63,0,0,1755,
		325,1,0,0,0,1756,1757,5,44,0,0,1757,1758,3,412,206,0,1758,1759,5,63,0,
		0,1759,327,1,0,0,0,1760,1761,5,42,0,0,1761,1762,5,57,0,0,1762,1763,3,412,
		206,0,1763,1764,5,58,0,0,1764,1765,3,250,125,0,1765,329,1,0,0,0,1766,1767,
		5,47,0,0,1767,1768,3,250,125,0,1768,1769,3,332,166,0,1769,1779,1,0,0,0,
		1770,1771,5,47,0,0,1771,1773,3,250,125,0,1772,1774,3,332,166,0,1773,1772,
		1,0,0,0,1773,1774,1,0,0,0,1774,1775,1,0,0,0,1775,1776,3,340,170,0,1776,
		1779,1,0,0,0,1777,1779,3,342,171,0,1778,1766,1,0,0,0,1778,1770,1,0,0,0,
		1778,1777,1,0,0,0,1779,331,1,0,0,0,1780,1784,3,334,167,0,1781,1783,3,334,
		167,0,1782,1781,1,0,0,0,1783,1786,1,0,0,0,1784,1782,1,0,0,0,1784,1785,
		1,0,0,0,1785,333,1,0,0,0,1786,1784,1,0,0,0,1787,1788,5,7,0,0,1788,1789,
		5,57,0,0,1789,1790,3,336,168,0,1790,1791,5,58,0,0,1791,1792,3,250,125,
		0,1792,335,1,0,0,0,1793,1795,3,154,77,0,1794,1793,1,0,0,0,1795,1798,1,
		0,0,0,1796,1794,1,0,0,0,1796,1797,1,0,0,0,1797,1799,1,0,0,0,1798,1796,
		1,0,0,0,1799,1800,3,338,169,0,1800,1801,3,110,55,0,1801,337,1,0,0,0,1802,
		1807,3,122,61,0,1803,1804,5,86,0,0,1804,1806,3,14,7,0,1805,1803,1,0,0,
		0,1806,1809,1,0,0,0,1807,1805,1,0,0,0,1807,1808,1,0,0,0,1808,339,1,0,0,
		0,1809,1807,1,0,0,0,1810,1811,5,19,0,0,1811,1812,3,250,125,0,1812,341,
		1,0,0,0,1813,1814,5,47,0,0,1814,1815,3,344,172,0,1815,1817,3,250,125,0,
		1816,1818,3,332,166,0,1817,1816,1,0,0,0,1817,1818,1,0,0,0,1818,1820,1,
		0,0,0,1819,1821,3,340,170,0,1820,1819,1,0,0,0,1820,1821,1,0,0,0,1821,343,
		1,0,0,0,1822,1823,5,57,0,0,1823,1825,3,346,173,0,1824,1826,5,63,0,0,1825,
		1824,1,0,0,0,1825,1826,1,0,0,0,1826,1827,1,0,0,0,1827,1828,5,58,0,0,1828,
		345,1,0,0,0,1829,1834,3,348,174,0,1830,1831,5,63,0,0,1831,1833,3,348,174,
		0,1832,1830,1,0,0,0,1833,1836,1,0,0,0,1834,1832,1,0,0,0,1834,1835,1,0,
		0,0,1835,347,1,0,0,0,1836,1834,1,0,0,0,1837,1839,3,154,77,0,1838,1837,
		1,0,0,0,1839,1842,1,0,0,0,1840,1838,1,0,0,0,1840,1841,1,0,0,0,1841,1843,
		1,0,0,0,1842,1840,1,0,0,0,1843,1844,3,114,57,0,1844,1845,3,110,55,0,1845,
		1846,5,66,0,0,1846,1847,3,412,206,0,1847,349,1,0,0,0,1848,1851,3,364,182,
		0,1849,1851,3,404,202,0,1850,1848,1,0,0,0,1850,1849,1,0,0,0,1851,1855,
		1,0,0,0,1852,1854,3,358,179,0,1853,1852,1,0,0,0,1854,1857,1,0,0,0,1855,
		1853,1,0,0,0,1855,1856,1,0,0,0,1856,351,1,0,0,0,1857,1855,1,0,0,0,1858,
		1888,3,0,0,0,1859,1864,3,52,26,0,1860,1861,5,61,0,0,1861,1863,5,62,0,0,
		1862,1860,1,0,0,0,1863,1866,1,0,0,0,1864,1862,1,0,0,0,1864,1865,1,0,0,
		0,1865,1867,1,0,0,0,1866,1864,1,0,0,0,1867,1868,5,65,0,0,1868,1869,5,9,
		0,0,1869,1888,1,0,0,0,1870,1871,5,48,0,0,1871,1872,5,65,0,0,1872,1888,
		5,9,0,0,1873,1888,5,43,0,0,1874,1875,3,52,26,0,1875,1876,5,65,0,0,1876,
		1877,5,43,0,0,1877,1888,1,0,0,0,1878,1879,5,57,0,0,1879,1880,3,412,206,
		0,1880,1881,5,58,0,0,1881,1888,1,0,0,0,1882,1888,3,370,185,0,1883,1888,
		3,378,189,0,1884,1888,3,384,192,0,1885,1888,3,390,195,0,1886,1888,3,398,
		199,0,1887,1858,1,0,0,0,1887,1859,1,0,0,0,1887,1870,1,0,0,0,1887,1873,
		1,0,0,0,1887,1874,1,0,0,0,1887,1878,1,0,0,0,1887,1882,1,0,0,0,1887,1883,
		1,0,0,0,1887,1884,1,0,0,0,1887,1885,1,0,0,0,1887,1886,1,0,0,0,1888,353,
		1,0,0,0,1889,1890,1,0,0,0,1890,355,1,0,0,0,1891,1920,3,0,0,0,1892,1897,
		3,52,26,0,1893,1894,5,61,0,0,1894,1896,5,62,0,0,1895,1893,1,0,0,0,1896,
		1899,1,0,0,0,1897,1895,1,0,0,0,1897,1898,1,0,0,0,1898,1900,1,0,0,0,1899,
		1897,1,0,0,0,1900,1901,5,65,0,0,1901,1902,5,9,0,0,1902,1920,1,0,0,0,1903,
		1904,5,48,0,0,1904,1905,5,65,0,0,1905,1920,5,9,0,0,1906,1920,5,43,0,0,
		1907,1908,3,52,26,0,1908,1909,5,65,0,0,1909,1910,5,43,0,0,1910,1920,1,
		0,0,0,1911,1912,5,57,0,0,1912,1913,3,412,206,0,1913,1914,5,58,0,0,1914,
		1920,1,0,0,0,1915,1920,3,370,185,0,1916,1920,3,378,189,0,1917,1920,3,390,
		195,0,1918,1920,3,398,199,0,1919,1891,1,0,0,0,1919,1892,1,0,0,0,1919,1903,
		1,0,0,0,1919,1906,1,0,0,0,1919,1907,1,0,0,0,1919,1911,1,0,0,0,1919,1915,
		1,0,0,0,1919,1916,1,0,0,0,1919,1917,1,0,0,0,1919,1918,1,0,0,0,1920,357,
		1,0,0,0,1921,1927,3,372,186,0,1922,1927,3,380,190,0,1923,1927,3,386,193,
		0,1924,1927,3,392,196,0,1925,1927,3,400,200,0,1926,1921,1,0,0,0,1926,1922,
		1,0,0,0,1926,1923,1,0,0,0,1926,1924,1,0,0,0,1926,1925,1,0,0,0,1927,359,
		1,0,0,0,1928,1929,1,0,0,0,1929,361,1,0,0,0,1930,1935,3,372,186,0,1931,
		1935,3,380,190,0,1932,1935,3,392,196,0,1933,1935,3,400,200,0,1934,1930,
		1,0,0,0,1934,1931,1,0,0,0,1934,1932,1,0,0,0,1934,1933,1,0,0,0,1935,363,
		1,0,0,0,1936,1977,3,0,0,0,1937,1942,3,52,26,0,1938,1939,5,61,0,0,1939,
		1941,5,62,0,0,1940,1938,1,0,0,0,1941,1944,1,0,0,0,1942,1940,1,0,0,0,1942,
		1943,1,0,0,0,1943,1945,1,0,0,0,1944,1942,1,0,0,0,1945,1946,5,65,0,0,1946,
		1947,5,9,0,0,1947,1977,1,0,0,0,1948,1953,3,116,58,0,1949,1950,5,61,0,0,
		1950,1952,5,62,0,0,1951,1949,1,0,0,0,1952,1955,1,0,0,0,1953,1951,1,0,0,
		0,1953,1954,1,0,0,0,1954,1956,1,0,0,0,1955,1953,1,0,0,0,1956,1957,5,65,
		0,0,1957,1958,5,9,0,0,1958,1977,1,0,0,0,1959,1960,5,48,0,0,1960,1961,5,
		65,0,0,1961,1977,5,9,0,0,1962,1977,5,43,0,0,1963,1964,3,52,26,0,1964,1965,
		5,65,0,0,1965,1966,5,43,0,0,1966,1977,1,0,0,0,1967,1968,5,57,0,0,1968,
		1969,3,412,206,0,1969,1970,5,58,0,0,1970,1977,1,0,0,0,1971,1977,3,374,
		187,0,1972,1977,3,382,191,0,1973,1977,3,388,194,0,1974,1977,3,394,197,
		0,1975,1977,3,402,201,0,1976,1936,1,0,0,0,1976,1937,1,0,0,0,1976,1948,
		1,0,0,0,1976,1959,1,0,0,0,1976,1962,1,0,0,0,1976,1963,1,0,0,0,1976,1967,
		1,0,0,0,1976,1971,1,0,0,0,1976,1972,1,0,0,0,1976,1973,1,0,0,0,1976,1974,
		1,0,0,0,1976,1975,1,0,0,0,1977,365,1,0,0,0,1978,1979,1,0,0,0,1979,367,
		1,0,0,0,1980,2020,3,0,0,0,1981,1986,3,52,26,0,1982,1983,5,61,0,0,1983,
		1985,5,62,0,0,1984,1982,1,0,0,0,1985,1988,1,0,0,0,1986,1984,1,0,0,0,1986,
		1987,1,0,0,0,1987,1989,1,0,0,0,1988,1986,1,0,0,0,1989,1990,5,65,0,0,1990,
		1991,5,9,0,0,1991,2020,1,0,0,0,1992,1997,3,116,58,0,1993,1994,5,61,0,0,
		1994,1996,5,62,0,0,1995,1993,1,0,0,0,1996,1999,1,0,0,0,1997,1995,1,0,0,
		0,1997,1998,1,0,0,0,1998,2000,1,0,0,0,1999,1997,1,0,0,0,2000,2001,5,65,
		0,0,2001,2002,5,9,0,0,2002,2020,1,0,0,0,2003,2004,5,48,0,0,2004,2005,5,
		65,0,0,2005,2020,5,9,0,0,2006,2020,5,43,0,0,2007,2008,3,52,26,0,2008,2009,
		5,65,0,0,2009,2010,5,43,0,0,2010,2020,1,0,0,0,2011,2012,5,57,0,0,2012,
		2013,3,412,206,0,2013,2014,5,58,0,0,2014,2020,1,0,0,0,2015,2020,3,374,
		187,0,2016,2020,3,382,191,0,2017,2020,3,394,197,0,2018,2020,3,402,201,
		0,2019,1980,1,0,0,0,2019,1981,1,0,0,0,2019,1992,1,0,0,0,2019,2003,1,0,
		0,0,2019,2006,1,0,0,0,2019,2007,1,0,0,0,2019,2011,1,0,0,0,2019,2015,1,
		0,0,0,2019,2016,1,0,0,0,2019,2017,1,0,0,0,2019,2018,1,0,0,0,2020,369,1,
		0,0,0,2021,2023,5,31,0,0,2022,2024,3,40,20,0,2023,2022,1,0,0,0,2023,2024,
		1,0,0,0,2024,2028,1,0,0,0,2025,2027,3,228,114,0,2026,2025,1,0,0,0,2027,
		2030,1,0,0,0,2028,2026,1,0,0,0,2028,2029,1,0,0,0,2029,2031,1,0,0,0,2030,
		2028,1,0,0,0,2031,2042,5,102,0,0,2032,2036,5,65,0,0,2033,2035,3,228,114,
		0,2034,2033,1,0,0,0,2035,2038,1,0,0,0,2036,2034,1,0,0,0,2036,2037,1,0,
		0,0,2037,2039,1,0,0,0,2038,2036,1,0,0,0,2039,2041,5,102,0,0,2040,2032,
		1,0,0,0,2041,2044,1,0,0,0,2042,2040,1,0,0,0,2042,2043,1,0,0,0,2043,2046,
		1,0,0,0,2044,2042,1,0,0,0,2045,2047,3,376,188,0,2046,2045,1,0,0,0,2046,
		2047,1,0,0,0,2047,2048,1,0,0,0,2048,2050,5,57,0,0,2049,2051,3,396,198,
		0,2050,2049,1,0,0,0,2050,2051,1,0,0,0,2051,2052,1,0,0,0,2052,2054,5,58,
		0,0,2053,2055,3,96,48,0,2054,2053,1,0,0,0,2054,2055,1,0,0,0,2055,2105,
		1,0,0,0,2056,2057,3,56,28,0,2057,2058,5,65,0,0,2058,2060,5,31,0,0,2059,
		2061,3,40,20,0,2060,2059,1,0,0,0,2060,2061,1,0,0,0,2061,2065,1,0,0,0,2062,
		2064,3,228,114,0,2063,2062,1,0,0,0,2064,2067,1,0,0,0,2065,2063,1,0,0,0,
		2065,2066,1,0,0,0,2066,2068,1,0,0,0,2067,2065,1,0,0,0,2068,2070,5,102,
		0,0,2069,2071,3,376,188,0,2070,2069,1,0,0,0,2070,2071,1,0,0,0,2071,2072,
		1,0,0,0,2072,2074,5,57,0,0,2073,2075,3,396,198,0,2074,2073,1,0,0,0,2074,
		2075,1,0,0,0,2075,2076,1,0,0,0,2076,2078,5,58,0,0,2077,2079,3,96,48,0,
		2078,2077,1,0,0,0,2078,2079,1,0,0,0,2079,2105,1,0,0,0,2080,2081,3,350,
		175,0,2081,2082,5,65,0,0,2082,2084,5,31,0,0,2083,2085,3,40,20,0,2084,2083,
		1,0,0,0,2084,2085,1,0,0,0,2085,2089,1,0,0,0,2086,2088,3,228,114,0,2087,
		2086,1,0,0,0,2088,2091,1,0,0,0,2089,2087,1,0,0,0,2089,2090,1,0,0,0,2090,
		2092,1,0,0,0,2091,2089,1,0,0,0,2092,2094,5,102,0,0,2093,2095,3,376,188,
		0,2094,2093,1,0,0,0,2094,2095,1,0,0,0,2095,2096,1,0,0,0,2096,2098,5,57,
		0,0,2097,2099,3,396,198,0,2098,2097,1,0,0,0,2098,2099,1,0,0,0,2099,2100,
		1,0,0,0,2100,2102,5,58,0,0,2101,2103,3,96,48,0,2102,2101,1,0,0,0,2102,
		2103,1,0,0,0,2103,2105,1,0,0,0,2104,2021,1,0,0,0,2104,2056,1,0,0,0,2104,
		2080,1,0,0,0,2105,371,1,0,0,0,2106,2107,5,65,0,0,2107,2109,5,31,0,0,2108,
		2110,3,40,20,0,2109,2108,1,0,0,0,2109,2110,1,0,0,0,2110,2114,1,0,0,0,2111,
		2113,3,228,114,0,2112,2111,1,0,0,0,2113,2116,1,0,0,0,2114,2112,1,0,0,0,
		2114,2115,1,0,0,0,2115,2117,1,0,0,0,2116,2114,1,0,0,0,2117,2119,5,102,
		0,0,2118,2120,3,376,188,0,2119,2118,1,0,0,0,2119,2120,1,0,0,0,2120,2121,
		1,0,0,0,2121,2123,5,57,0,0,2122,2124,3,396,198,0,2123,2122,1,0,0,0,2123,
		2124,1,0,0,0,2124,2125,1,0,0,0,2125,2127,5,58,0,0,2126,2128,3,96,48,0,
		2127,2126,1,0,0,0,2127,2128,1,0,0,0,2128,373,1,0,0,0,2129,2131,5,31,0,
		0,2130,2132,3,40,20,0,2131,2130,1,0,0,0,2131,2132,1,0,0,0,2132,2136,1,
		0,0,0,2133,2135,3,228,114,0,2134,2133,1,0,0,0,2135,2138,1,0,0,0,2136,2134,
		1,0,0,0,2136,2137,1,0,0,0,2137,2139,1,0,0,0,2138,2136,1,0,0,0,2139,2150,
		5,102,0,0,2140,2144,5,65,0,0,2141,2143,3,228,114,0,2142,2141,1,0,0,0,2143,
		2146,1,0,0,0,2144,2142,1,0,0,0,2144,2145,1,0,0,0,2145,2147,1,0,0,0,2146,
		2144,1,0,0,0,2147,2149,5,102,0,0,2148,2140,1,0,0,0,2149,2152,1,0,0,0,2150,
		2148,1,0,0,0,2150,2151,1,0,0,0,2151,2154,1,0,0,0,2152,2150,1,0,0,0,2153,
		2155,3,376,188,0,2154,2153,1,0,0,0,2154,2155,1,0,0,0,2155,2156,1,0,0,0,
		2156,2158,5,57,0,0,2157,2159,3,396,198,0,2158,2157,1,0,0,0,2158,2159,1,
		0,0,0,2159,2160,1,0,0,0,2160,2162,5,58,0,0,2161,2163,3,96,48,0,2162,2161,
		1,0,0,0,2162,2163,1,0,0,0,2163,2189,1,0,0,0,2164,2165,3,56,28,0,2165,2166,
		5,65,0,0,2166,2168,5,31,0,0,2167,2169,3,40,20,0,2168,2167,1,0,0,0,2168,
		2169,1,0,0,0,2169,2173,1,0,0,0,2170,2172,3,228,114,0,2171,2170,1,0,0,0,
		2172,2175,1,0,0,0,2173,2171,1,0,0,0,2173,2174,1,0,0,0,2174,2176,1,0,0,
		0,2175,2173,1,0,0,0,2176,2178,5,102,0,0,2177,2179,3,376,188,0,2178,2177,
		1,0,0,0,2178,2179,1,0,0,0,2179,2180,1,0,0,0,2180,2182,5,57,0,0,2181,2183,
		3,396,198,0,2182,2181,1,0,0,0,2182,2183,1,0,0,0,2183,2184,1,0,0,0,2184,
		2186,5,58,0,0,2185,2187,3,96,48,0,2186,2185,1,0,0,0,2186,2187,1,0,0,0,
		2187,2189,1,0,0,0,2188,2129,1,0,0,0,2188,2164,1,0,0,0,2189,375,1,0,0,0,
		2190,2194,3,40,20,0,2191,2192,5,68,0,0,2192,2194,5,67,0,0,2193,2190,1,
		0,0,0,2193,2191,1,0,0,0,2194,377,1,0,0,0,2195,2196,3,350,175,0,2196,2197,
		5,65,0,0,2197,2198,5,102,0,0,2198,2209,1,0,0,0,2199,2200,5,40,0,0,2200,
		2201,5,65,0,0,2201,2209,5,102,0,0,2202,2203,3,52,26,0,2203,2204,5,65,0,
		0,2204,2205,5,40,0,0,2205,2206,5,65,0,0,2206,2207,5,102,0,0,2207,2209,
		1,0,0,0,2208,2195,1,0,0,0,2208,2199,1,0,0,0,2208,2202,1,0,0,0,2209,379,
		1,0,0,0,2210,2211,5,65,0,0,2211,2212,5,102,0,0,2212,381,1,0,0,0,2213,2214,
		5,40,0,0,2214,2215,5,65,0,0,2215,2223,5,102,0,0,2216,2217,3,52,26,0,2217,
		2218,5,65,0,0,2218,2219,5,40,0,0,2219,2220,5,65,0,0,2220,2221,5,102,0,
		0,2221,2223,1,0,0,0,2222,2213,1,0,0,0,2222,2216,1,0,0,0,2223,383,1,0,0,
		0,2224,2225,3,56,28,0,2225,2226,5,61,0,0,2226,2227,3,412,206,0,2227,2228,
		5,62,0,0,2228,2235,1,0,0,0,2229,2230,3,356,178,0,2230,2231,5,61,0,0,2231,
		2232,3,412,206,0,2232,2233,5,62,0,0,2233,2235,1,0,0,0,2234,2224,1,0,0,
		0,2234,2229,1,0,0,0,2235,2243,1,0,0,0,2236,2237,3,354,177,0,2237,2238,
		5,61,0,0,2238,2239,3,412,206,0,2239,2240,5,62,0,0,2240,2242,1,0,0,0,2241,
		2236,1,0,0,0,2242,2245,1,0,0,0,2243,2241,1,0,0,0,2243,2244,1,0,0,0,2244,
		385,1,0,0,0,2245,2243,1,0,0,0,2246,2247,3,362,181,0,2247,2248,5,61,0,0,
		2248,2249,3,412,206,0,2249,2250,5,62,0,0,2250,2258,1,0,0,0,2251,2252,3,
		360,180,0,2252,2253,5,61,0,0,2253,2254,3,412,206,0,2254,2255,5,62,0,0,
		2255,2257,1,0,0,0,2256,2251,1,0,0,0,2257,2260,1,0,0,0,2258,2256,1,0,0,
		0,2258,2259,1,0,0,0,2259,387,1,0,0,0,2260,2258,1,0,0,0,2261,2262,3,56,
		28,0,2262,2263,5,61,0,0,2263,2264,3,412,206,0,2264,2265,5,62,0,0,2265,
		2272,1,0,0,0,2266,2267,3,368,184,0,2267,2268,5,61,0,0,2268,2269,3,412,
		206,0,2269,2270,5,62,0,0,2270,2272,1,0,0,0,2271,2261,1,0,0,0,2271,2266,
		1,0,0,0,2272,2280,1,0,0,0,2273,2274,3,366,183,0,2274,2275,5,61,0,0,2275,
		2276,3,412,206,0,2276,2277,5,62,0,0,2277,2279,1,0,0,0,2278,2273,1,0,0,
		0,2279,2282,1,0,0,0,2280,2278,1,0,0,0,2280,2281,1,0,0,0,2281,389,1,0,0,
		0,2282,2280,1,0,0,0,2283,2284,3,58,29,0,2284,2286,5,57,0,0,2285,2287,3,
		396,198,0,2286,2285,1,0,0,0,2286,2287,1,0,0,0,2287,2288,1,0,0,0,2288,2289,
		5,58,0,0,2289,2352,1,0,0,0,2290,2291,3,52,26,0,2291,2293,5,65,0,0,2292,
		2294,3,40,20,0,2293,2292,1,0,0,0,2293,2294,1,0,0,0,2294,2295,1,0,0,0,2295,
		2296,5,102,0,0,2296,2298,5,57,0,0,2297,2299,3,396,198,0,2298,2297,1,0,
		0,0,2298,2299,1,0,0,0,2299,2300,1,0,0,0,2300,2301,5,58,0,0,2301,2352,1,
		0,0,0,2302,2303,3,56,28,0,2303,2305,5,65,0,0,2304,2306,3,40,20,0,2305,
		2304,1,0,0,0,2305,2306,1,0,0,0,2306,2307,1,0,0,0,2307,2308,5,102,0,0,2308,
		2310,5,57,0,0,2309,2311,3,396,198,0,2310,2309,1,0,0,0,2310,2311,1,0,0,
		0,2311,2312,1,0,0,0,2312,2313,5,58,0,0,2313,2352,1,0,0,0,2314,2315,3,350,
		175,0,2315,2317,5,65,0,0,2316,2318,3,40,20,0,2317,2316,1,0,0,0,2317,2318,
		1,0,0,0,2318,2319,1,0,0,0,2319,2320,5,102,0,0,2320,2322,5,57,0,0,2321,
		2323,3,396,198,0,2322,2321,1,0,0,0,2322,2323,1,0,0,0,2323,2324,1,0,0,0,
		2324,2325,5,58,0,0,2325,2352,1,0,0,0,2326,2327,5,40,0,0,2327,2329,5,65,
		0,0,2328,2330,3,40,20,0,2329,2328,1,0,0,0,2329,2330,1,0,0,0,2330,2331,
		1,0,0,0,2331,2332,5,102,0,0,2332,2334,5,57,0,0,2333,2335,3,396,198,0,2334,
		2333,1,0,0,0,2334,2335,1,0,0,0,2335,2336,1,0,0,0,2336,2352,5,58,0,0,2337,
		2338,3,52,26,0,2338,2339,5,65,0,0,2339,2340,5,40,0,0,2340,2342,5,65,0,
		0,2341,2343,3,40,20,0,2342,2341,1,0,0,0,2342,2343,1,0,0,0,2343,2344,1,
		0,0,0,2344,2345,5,102,0,0,2345,2347,5,57,0,0,2346,2348,3,396,198,0,2347,
		2346,1,0,0,0,2347,2348,1,0,0,0,2348,2349,1,0,0,0,2349,2350,5,58,0,0,2350,
		2352,1,0,0,0,2351,2283,1,0,0,0,2351,2290,1,0,0,0,2351,2302,1,0,0,0,2351,
		2314,1,0,0,0,2351,2326,1,0,0,0,2351,2337,1,0,0,0,2352,391,1,0,0,0,2353,
		2355,5,65,0,0,2354,2356,3,40,20,0,2355,2354,1,0,0,0,2355,2356,1,0,0,0,
		2356,2357,1,0,0,0,2357,2358,5,102,0,0,2358,2360,5,57,0,0,2359,2361,3,396,
		198,0,2360,2359,1,0,0,0,2360,2361,1,0,0,0,2361,2362,1,0,0,0,2362,2363,
		5,58,0,0,2363,393,1,0,0,0,2364,2365,3,58,29,0,2365,2367,5,57,0,0,2366,
		2368,3,396,198,0,2367,2366,1,0,0,0,2367,2368,1,0,0,0,2368,2369,1,0,0,0,
		2369,2370,5,58,0,0,2370,2421,1,0,0,0,2371,2372,3,52,26,0,2372,2374,5,65,
		0,0,2373,2375,3,40,20,0,2374,2373,1,0,0,0,2374,2375,1,0,0,0,2375,2376,
		1,0,0,0,2376,2377,5,102,0,0,2377,2379,5,57,0,0,2378,2380,3,396,198,0,2379,
		2378,1,0,0,0,2379,2380,1,0,0,0,2380,2381,1,0,0,0,2381,2382,5,58,0,0,2382,
		2421,1,0,0,0,2383,2384,3,56,28,0,2384,2386,5,65,0,0,2385,2387,3,40,20,
		0,2386,2385,1,0,0,0,2386,2387,1,0,0,0,2387,2388,1,0,0,0,2388,2389,5,102,
		0,0,2389,2391,5,57,0,0,2390,2392,3,396,198,0,2391,2390,1,0,0,0,2391,2392,
		1,0,0,0,2392,2393,1,0,0,0,2393,2394,5,58,0,0,2394,2421,1,0,0,0,2395,2396,
		5,40,0,0,2396,2398,5,65,0,0,2397,2399,3,40,20,0,2398,2397,1,0,0,0,2398,
		2399,1,0,0,0,2399,2400,1,0,0,0,2400,2401,5,102,0,0,2401,2403,5,57,0,0,
		2402,2404,3,396,198,0,2403,2402,1,0,0,0,2403,2404,1,0,0,0,2404,2405,1,
		0,0,0,2405,2421,5,58,0,0,2406,2407,3,52,26,0,2407,2408,5,65,0,0,2408,2409,
		5,40,0,0,2409,2411,5,65,0,0,2410,2412,3,40,20,0,2411,2410,1,0,0,0,2411,
		2412,1,0,0,0,2412,2413,1,0,0,0,2413,2414,5,102,0,0,2414,2416,5,57,0,0,
		2415,2417,3,396,198,0,2416,2415,1,0,0,0,2416,2417,1,0,0,0,2417,2418,1,
		0,0,0,2418,2419,5,58,0,0,2419,2421,1,0,0,0,2420,2364,1,0,0,0,2420,2371,
		1,0,0,0,2420,2383,1,0,0,0,2420,2395,1,0,0,0,2420,2406,1,0,0,0,2421,395,
		1,0,0,0,2422,2427,3,412,206,0,2423,2424,5,64,0,0,2424,2426,3,412,206,0,
		2425,2423,1,0,0,0,2426,2429,1,0,0,0,2427,2425,1,0,0,0,2427,2428,1,0,0,
		0,2428,397,1,0,0,0,2429,2427,1,0,0,0,2430,2431,3,56,28,0,2431,2433,5,90,
		0,0,2432,2434,3,40,20,0,2433,2432,1,0,0,0,2433,2434,1,0,0,0,2434,2435,
		1,0,0,0,2435,2436,5,102,0,0,2436,2478,1,0,0,0,2437,2438,3,10,5,0,2438,
		2440,5,90,0,0,2439,2441,3,40,20,0,2440,2439,1,0,0,0,2440,2441,1,0,0,0,
		2441,2442,1,0,0,0,2442,2443,5,102,0,0,2443,2478,1,0,0,0,2444,2445,3,350,
		175,0,2445,2447,5,90,0,0,2446,2448,3,40,20,0,2447,2446,1,0,0,0,2447,2448,
		1,0,0,0,2448,2449,1,0,0,0,2449,2450,5,102,0,0,2450,2478,1,0,0,0,2451,2452,
		5,40,0,0,2452,2454,5,90,0,0,2453,2455,3,40,20,0,2454,2453,1,0,0,0,2454,
		2455,1,0,0,0,2455,2456,1,0,0,0,2456,2478,5,102,0,0,2457,2458,3,52,26,0,
		2458,2459,5,65,0,0,2459,2460,5,40,0,0,2460,2462,5,90,0,0,2461,2463,3,40,
		20,0,2462,2461,1,0,0,0,2462,2463,1,0,0,0,2463,2464,1,0,0,0,2464,2465,5,
		102,0,0,2465,2478,1,0,0,0,2466,2467,3,14,7,0,2467,2469,5,90,0,0,2468,2470,
		3,40,20,0,2469,2468,1,0,0,0,2469,2470,1,0,0,0,2470,2471,1,0,0,0,2471,2472,
		5,31,0,0,2472,2478,1,0,0,0,2473,2474,3,28,14,0,2474,2475,5,90,0,0,2475,
		2476,5,31,0,0,2476,2478,1,0,0,0,2477,2430,1,0,0,0,2477,2437,1,0,0,0,2477,
		2444,1,0,0,0,2477,2451,1,0,0,0,2477,2457,1,0,0,0,2477,2466,1,0,0,0,2477,
		2473,1,0,0,0,2478,399,1,0,0,0,2479,2481,5,90,0,0,2480,2482,3,40,20,0,2481,
		2480,1,0,0,0,2481,2482,1,0,0,0,2482,2483,1,0,0,0,2483,2484,5,102,0,0,2484,
		401,1,0,0,0,2485,2486,3,56,28,0,2486,2488,5,90,0,0,2487,2489,3,40,20,0,
		2488,2487,1,0,0,0,2488,2489,1,0,0,0,2489,2490,1,0,0,0,2490,2491,5,102,
		0,0,2491,2526,1,0,0,0,2492,2493,3,10,5,0,2493,2495,5,90,0,0,2494,2496,
		3,40,20,0,2495,2494,1,0,0,0,2495,2496,1,0,0,0,2496,2497,1,0,0,0,2497,2498,
		5,102,0,0,2498,2526,1,0,0,0,2499,2500,5,40,0,0,2500,2502,5,90,0,0,2501,
		2503,3,40,20,0,2502,2501,1,0,0,0,2502,2503,1,0,0,0,2503,2504,1,0,0,0,2504,
		2526,5,102,0,0,2505,2506,3,52,26,0,2506,2507,5,65,0,0,2507,2508,5,40,0,
		0,2508,2510,5,90,0,0,2509,2511,3,40,20,0,2510,2509,1,0,0,0,2510,2511,1,
		0,0,0,2511,2512,1,0,0,0,2512,2513,5,102,0,0,2513,2526,1,0,0,0,2514,2515,
		3,14,7,0,2515,2517,5,90,0,0,2516,2518,3,40,20,0,2517,2516,1,0,0,0,2517,
		2518,1,0,0,0,2518,2519,1,0,0,0,2519,2520,5,31,0,0,2520,2526,1,0,0,0,2521,
		2522,3,28,14,0,2522,2523,5,90,0,0,2523,2524,5,31,0,0,2524,2526,1,0,0,0,
		2525,2485,1,0,0,0,2525,2492,1,0,0,0,2525,2499,1,0,0,0,2525,2505,1,0,0,
		0,2525,2514,1,0,0,0,2525,2521,1,0,0,0,2526,403,1,0,0,0,2527,2528,5,31,
		0,0,2528,2529,3,2,1,0,2529,2531,3,406,203,0,2530,2532,3,30,15,0,2531,2530,
		1,0,0,0,2531,2532,1,0,0,0,2532,2550,1,0,0,0,2533,2534,5,31,0,0,2534,2535,
		3,12,6,0,2535,2537,3,406,203,0,2536,2538,3,30,15,0,2537,2536,1,0,0,0,2537,
		2538,1,0,0,0,2538,2550,1,0,0,0,2539,2540,5,31,0,0,2540,2541,3,2,1,0,2541,
		2542,3,30,15,0,2542,2543,3,246,123,0,2543,2550,1,0,0,0,2544,2545,5,31,
		0,0,2545,2546,3,12,6,0,2546,2547,3,30,15,0,2547,2548,3,246,123,0,2548,
		2550,1,0,0,0,2549,2527,1,0,0,0,2549,2533,1,0,0,0,2549,2539,1,0,0,0,2549,
		2544,1,0,0,0,2550,405,1,0,0,0,2551,2555,3,408,204,0,2552,2554,3,408,204,
		0,2553,2552,1,0,0,0,2554,2557,1,0,0,0,2555,2553,1,0,0,0,2555,2556,1,0,
		0,0,2556,407,1,0,0,0,2557,2555,1,0,0,0,2558,2560,3,228,114,0,2559,2558,
		1,0,0,0,2560,2563,1,0,0,0,2561,2559,1,0,0,0,2561,2562,1,0,0,0,2562,2564,
		1,0,0,0,2563,2561,1,0,0,0,2564,2565,5,61,0,0,2565,2566,3,412,206,0,2566,
		2567,5,62,0,0,2567,409,1,0,0,0,2568,2569,3,412,206,0,2569,411,1,0,0,0,
		2570,2573,3,414,207,0,2571,2573,3,422,211,0,2572,2570,1,0,0,0,2572,2571,
		1,0,0,0,2573,413,1,0,0,0,2574,2575,3,416,208,0,2575,2576,5,89,0,0,2576,
		2577,3,420,210,0,2577,415,1,0,0,0,2578,2589,5,102,0,0,2579,2581,5,57,0,
		0,2580,2582,3,148,74,0,2581,2580,1,0,0,0,2581,2582,1,0,0,0,2582,2583,1,
		0,0,0,2583,2589,5,58,0,0,2584,2585,5,57,0,0,2585,2586,3,418,209,0,2586,
		2587,5,58,0,0,2587,2589,1,0,0,0,2588,2578,1,0,0,0,2588,2579,1,0,0,0,2588,
		2584,1,0,0,0,2589,417,1,0,0,0,2590,2595,5,102,0,0,2591,2592,5,64,0,0,2592,
		2594,5,102,0,0,2593,2591,1,0,0,0,2594,2597,1,0,0,0,2595,2593,1,0,0,0,2595,
		2596,1,0,0,0,2596,419,1,0,0,0,2597,2595,1,0,0,0,2598,2601,3,412,206,0,
		2599,2601,3,250,125,0,2600,2598,1,0,0,0,2600,2599,1,0,0,0,2601,421,1,0,
		0,0,2602,2605,3,430,215,0,2603,2605,3,424,212,0,2604,2602,1,0,0,0,2604,
		2603,1,0,0,0,2605,423,1,0,0,0,2606,2607,3,426,213,0,2607,2608,3,428,214,
		0,2608,2609,3,412,206,0,2609,425,1,0,0,0,2610,2614,3,56,28,0,2611,2614,
		3,378,189,0,2612,2614,3,384,192,0,2613,2610,1,0,0,0,2613,2611,1,0,0,0,
		2613,2612,1,0,0,0,2614,427,1,0,0,0,2615,2616,7,3,0,0,2616,429,1,0,0,0,
		2617,2625,3,432,216,0,2618,2619,3,432,216,0,2619,2620,5,71,0,0,2620,2621,
		3,412,206,0,2621,2622,5,72,0,0,2622,2623,3,430,215,0,2623,2625,1,0,0,0,
		2624,2617,1,0,0,0,2624,2618,1,0,0,0,2625,431,1,0,0,0,2626,2627,6,216,-1,
		0,2627,2628,3,434,217,0,2628,2634,1,0,0,0,2629,2630,10,1,0,0,2630,2631,
		5,78,0,0,2631,2633,3,434,217,0,2632,2629,1,0,0,0,2633,2636,1,0,0,0,2634,
		2632,1,0,0,0,2634,2635,1,0,0,0,2635,433,1,0,0,0,2636,2634,1,0,0,0,2637,
		2638,6,217,-1,0,2638,2639,3,436,218,0,2639,2645,1,0,0,0,2640,2641,10,1,
		0,0,2641,2642,5,77,0,0,2642,2644,3,436,218,0,2643,2640,1,0,0,0,2644,2647,
		1,0,0,0,2645,2643,1,0,0,0,2645,2646,1,0,0,0,2646,435,1,0,0,0,2647,2645,
		1,0,0,0,2648,2649,6,218,-1,0,2649,2650,3,438,219,0,2650,2656,1,0,0,0,2651,
		2652,10,1,0,0,2652,2653,5,86,0,0,2653,2655,3,438,219,0,2654,2651,1,0,0,
		0,2655,2658,1,0,0,0,2656,2654,1,0,0,0,2656,2657,1,0,0,0,2657,437,1,0,0,
		0,2658,2656,1,0,0,0,2659,2660,6,219,-1,0,2660,2661,3,440,220,0,2661,2667,
		1,0,0,0,2662,2663,10,1,0,0,2663,2664,5,87,0,0,2664,2666,3,440,220,0,2665,
		2662,1,0,0,0,2666,2669,1,0,0,0,2667,2665,1,0,0,0,2667,2668,1,0,0,0,2668,
		439,1,0,0,0,2669,2667,1,0,0,0,2670,2671,6,220,-1,0,2671,2672,3,442,221,
		0,2672,2678,1,0,0,0,2673,2674,10,1,0,0,2674,2675,5,85,0,0,2675,2677,3,
		442,221,0,2676,2673,1,0,0,0,2677,2680,1,0,0,0,2678,2676,1,0,0,0,2678,2679,
		1,0,0,0,2679,441,1,0,0,0,2680,2678,1,0,0,0,2681,2682,6,221,-1,0,2682,2683,
		3,444,222,0,2683,2692,1,0,0,0,2684,2685,10,2,0,0,2685,2686,5,73,0,0,2686,
		2691,3,444,222,0,2687,2688,10,1,0,0,2688,2689,5,76,0,0,2689,2691,3,444,
		222,0,2690,2684,1,0,0,0,2690,2687,1,0,0,0,2691,2694,1,0,0,0,2692,2690,
		1,0,0,0,2692,2693,1,0,0,0,2693,443,1,0,0,0,2694,2692,1,0,0,0,2695,2696,
		6,222,-1,0,2696,2697,3,446,223,0,2697,2715,1,0,0,0,2698,2699,10,5,0,0,
		2699,2700,5,68,0,0,2700,2714,3,446,223,0,2701,2702,10,4,0,0,2702,2703,
		5,67,0,0,2703,2714,3,446,223,0,2704,2705,10,3,0,0,2705,2706,5,74,0,0,2706,
		2714,3,446,223,0,2707,2708,10,2,0,0,2708,2709,5,75,0,0,2709,2714,3,446,
		223,0,2710,2711,10,1,0,0,2711,2712,5,26,0,0,2712,2714,3,10,5,0,2713,2698,
		1,0,0,0,2713,2701,1,0,0,0,2713,2704,1,0,0,0,2713,2707,1,0,0,0,2713,2710,
		1,0,0,0,2714,2717,1,0,0,0,2715,2713,1,0,0,0,2715,2716,1,0,0,0,2716,445,
		1,0,0,0,2717,2715,1,0,0,0,2718,2719,6,223,-1,0,2719,2720,3,448,224,0,2720,
		2736,1,0,0,0,2721,2722,10,3,0,0,2722,2723,5,68,0,0,2723,2724,5,68,0,0,
		2724,2735,3,448,224,0,2725,2726,10,2,0,0,2726,2727,5,67,0,0,2727,2728,
		5,67,0,0,2728,2735,3,448,224,0,2729,2730,10,1,0,0,2730,2731,5,67,0,0,2731,
		2732,5,67,0,0,2732,2733,5,67,0,0,2733,2735,3,448,224,0,2734,2721,1,0,0,
		0,2734,2725,1,0,0,0,2734,2729,1,0,0,0,2735,2738,1,0,0,0,2736,2734,1,0,
		0,0,2736,2737,1,0,0,0,2737,447,1,0,0,0,2738,2736,1,0,0,0,2739,2740,6,224,
		-1,0,2740,2741,3,450,225,0,2741,2750,1,0,0,0,2742,2743,10,2,0,0,2743,2744,
		5,81,0,0,2744,2749,3,450,225,0,2745,2746,10,1,0,0,2746,2747,5,82,0,0,2747,
		2749,3,450,225,0,2748,2742,1,0,0,0,2748,2745,1,0,0,0,2749,2752,1,0,0,0,
		2750,2748,1,0,0,0,2750,2751,1,0,0,0,2751,449,1,0,0,0,2752,2750,1,0,0,0,
		2753,2754,6,225,-1,0,2754,2755,3,452,226,0,2755,2767,1,0,0,0,2756,2757,
		10,3,0,0,2757,2758,5,83,0,0,2758,2766,3,452,226,0,2759,2760,10,2,0,0,2760,
		2761,5,84,0,0,2761,2766,3,452,226,0,2762,2763,10,1,0,0,2763,2764,5,88,
		0,0,2764,2766,3,452,226,0,2765,2756,1,0,0,0,2765,2759,1,0,0,0,2765,2762,
		1,0,0,0,2766,2769,1,0,0,0,2767,2765,1,0,0,0,2767,2768,1,0,0,0,2768,451,
		1,0,0,0,2769,2767,1,0,0,0,2770,2778,3,454,227,0,2771,2778,3,456,228,0,
		2772,2773,5,81,0,0,2773,2778,3,452,226,0,2774,2775,5,82,0,0,2775,2778,
		3,452,226,0,2776,2778,3,458,229,0,2777,2770,1,0,0,0,2777,2771,1,0,0,0,
		2777,2772,1,0,0,0,2777,2774,1,0,0,0,2777,2776,1,0,0,0,2778,453,1,0,0,0,
		2779,2780,5,79,0,0,2780,2781,3,452,226,0,2781,455,1,0,0,0,2782,2783,5,
		80,0,0,2783,2784,3,452,226,0,2784,457,1,0,0,0,2785,2792,3,460,230,0,2786,
		2787,5,70,0,0,2787,2792,3,452,226,0,2788,2789,5,69,0,0,2789,2792,3,452,
		226,0,2790,2792,3,470,235,0,2791,2785,1,0,0,0,2791,2786,1,0,0,0,2791,2788,
		1,0,0,0,2791,2790,1,0,0,0,2792,459,1,0,0,0,2793,2796,3,350,175,0,2794,
		2796,3,56,28,0,2795,2793,1,0,0,0,2795,2794,1,0,0,0,2796,2801,1,0,0,0,2797,
		2800,3,464,232,0,2798,2800,3,468,234,0,2799,2797,1,0,0,0,2799,2798,1,0,
		0,0,2800,2803,1,0,0,0,2801,2799,1,0,0,0,2801,2802,1,0,0,0,2802,461,1,0,
		0,0,2803,2801,1,0,0,0,2804,2805,3,460,230,0,2805,2806,5,79,0,0,2806,463,
		1,0,0,0,2807,2808,5,79,0,0,2808,465,1,0,0,0,2809,2810,3,460,230,0,2810,
		2811,5,80,0,0,2811,467,1,0,0,0,2812,2813,5,80,0,0,2813,469,1,0,0,0,2814,
		2815,5,57,0,0,2815,2816,3,2,1,0,2816,2817,5,58,0,0,2817,2818,3,452,226,
		0,2818,2842,1,0,0,0,2819,2820,5,57,0,0,2820,2824,3,10,5,0,2821,2823,3,
		38,19,0,2822,2821,1,0,0,0,2823,2826,1,0,0,0,2824,2822,1,0,0,0,2824,2825,
		1,0,0,0,2825,2827,1,0,0,0,2826,2824,1,0,0,0,2827,2828,5,58,0,0,2828,2829,
		3,458,229,0,2829,2842,1,0,0,0,2830,2831,5,57,0,0,2831,2835,3,10,5,0,2832,
		2834,3,38,19,0,2833,2832,1,0,0,0,2834,2837,1,0,0,0,2835,2833,1,0,0,0,2835,
		2836,1,0,0,0,2836,2838,1,0,0,0,2837,2835,1,0,0,0,2838,2839,5,58,0,0,2839,
		2840,3,414,207,0,2840,2842,1,0,0,0,2841,2814,1,0,0,0,2841,2819,1,0,0,0,
		2841,2830,1,0,0,0,2842,471,1,0,0,0,322,477,484,488,492,501,505,509,511,
		517,522,529,534,536,542,547,552,557,568,582,587,595,602,608,613,624,627,
		641,646,651,656,662,672,680,690,698,710,714,719,725,733,746,775,779,784,
		790,793,796,808,819,833,840,849,856,861,876,883,889,893,897,901,905,910,
		914,918,920,925,932,937,939,945,950,954,973,978,994,999,1005,1011,1013,
		1017,1022,1026,1034,1041,1049,1052,1057,1065,1070,1077,1084,1089,1095,
		1107,1112,1116,1126,1131,1139,1142,1147,1155,1158,1163,1168,1173,1178,
		1185,1190,1198,1203,1208,1213,1219,1225,1228,1231,1240,1246,1252,1255,
		1258,1266,1271,1276,1282,1285,1296,1305,1315,1320,1331,1336,1348,1353,
		1365,1375,1380,1388,1391,1398,1406,1412,1421,1431,1435,1438,1447,1461,
		1464,1473,1478,1485,1490,1498,1510,1517,1531,1553,1587,1599,1605,1617,
		1630,1656,1660,1665,1669,1673,1681,1685,1689,1696,1705,1713,1728,1740,
		1746,1752,1773,1778,1784,1796,1807,1817,1820,1825,1834,1840,1850,1855,
		1864,1887,1897,1919,1926,1934,1942,1953,1976,1986,1997,2019,2023,2028,
		2036,2042,2046,2050,2054,2060,2065,2070,2074,2078,2084,2089,2094,2098,
		2102,2104,2109,2114,2119,2123,2127,2131,2136,2144,2150,2154,2158,2162,
		2168,2173,2178,2182,2186,2188,2193,2208,2222,2234,2243,2258,2271,2280,
		2286,2293,2298,2305,2310,2317,2322,2329,2334,2342,2347,2351,2355,2360,
		2367,2374,2379,2386,2391,2398,2403,2411,2416,2420,2427,2433,2440,2447,
		2454,2462,2469,2477,2481,2488,2495,2502,2510,2517,2525,2531,2537,2549,
		2555,2561,2572,2581,2588,2595,2600,2604,2613,2624,2634,2645,2656,2667,
		2678,2690,2692,2713,2715,2734,2736,2748,2750,2765,2767,2777,2791,2795,
		2799,2801,2824,2835,2841
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
