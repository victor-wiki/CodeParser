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
public partial class Java9Parser : Parser
{
    protected static DFA[] decisionToDFA;
    protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
    public const int
        T__0 = 1, T__1 = 2, T__2 = 3, T__3 = 4, T__4 = 5, T__5 = 6, T__6 = 7, T__7 = 8, T__8 = 9,
        T__9 = 10, ABSTRACT = 11, ASSERT = 12, BOOLEAN = 13, BREAK = 14, BYTE = 15, CASE = 16,
        CATCH = 17, CHAR = 18, CLASS = 19, CONST = 20, CONTINUE = 21, DEFAULT = 22, DO = 23,
        DOUBLE = 24, ELSE = 25, ENUM = 26, EXTENDS = 27, FINAL = 28, FINALLY = 29, FLOAT = 30,
        FOR = 31, IF = 32, GOTO = 33, IMPLEMENTS = 34, IMPORT = 35, INSTANCEOF = 36, INT = 37,
        INTERFACE = 38, LONG = 39, NATIVE = 40, NEW = 41, PACKAGE = 42, PRIVATE = 43, PROTECTED = 44,
        PUBLIC = 45, RETURN = 46, SHORT = 47, STATIC = 48, STRICTFP = 49, SUPER = 50, SWITCH = 51,
        SYNCHRONIZED = 52, THIS = 53, THROW = 54, THROWS = 55, TRANSIENT = 56, TRY = 57, VOID = 58,
        VOLATILE = 59, WHILE = 60, UNDER_SCORE = 61, IntegerLiteral = 62, FloatingPointLiteral = 63,
        BooleanLiteral = 64, CharacterLiteral = 65, StringLiteral = 66, NullLiteral = 67,
        LPAREN = 68, RPAREN = 69, LBRACE = 70, RBRACE = 71, LBRACK = 72, RBRACK = 73, SEMI = 74,
        COMMA = 75, DOT = 76, ELLIPSIS = 77, AT = 78, COLONCOLON = 79, ASSIGN = 80, GT = 81,
        LT = 82, BANG = 83, TILDE = 84, QUESTION = 85, COLON = 86, ARROW = 87, EQUAL = 88, LE = 89,
        GE = 90, NOTEQUAL = 91, AND = 92, OR = 93, INC = 94, DEC = 95, ADD = 96, SUB = 97, MUL = 98,
        DIV = 99, BITAND = 100, BITOR = 101, CARET = 102, MOD = 103, ADD_ASSIGN = 104, SUB_ASSIGN = 105,
        MUL_ASSIGN = 106, DIV_ASSIGN = 107, AND_ASSIGN = 108, OR_ASSIGN = 109, XOR_ASSIGN = 110,
        MOD_ASSIGN = 111, LSHIFT_ASSIGN = 112, RSHIFT_ASSIGN = 113, URSHIFT_ASSIGN = 114,
        Identifier = 115, WS = 116, COMMENT = 117, LINE_COMMENT = 118;
    public const int
        RULE_literal = 0, RULE_primitiveType = 1, RULE_numericType = 2, RULE_integralType = 3,
        RULE_floatingPointType = 4, RULE_referenceType = 5, RULE_classOrInterfaceType = 6,
        RULE_classType = 7, RULE_classType_lf_classOrInterfaceType = 8, RULE_classType_lfno_classOrInterfaceType = 9,
        RULE_interfaceType = 10, RULE_interfaceType_lf_classOrInterfaceType = 11,
        RULE_interfaceType_lfno_classOrInterfaceType = 12, RULE_typeVariable = 13,
        RULE_arrayType = 14, RULE_dims = 15, RULE_typeParameter = 16, RULE_typeParameterModifier = 17,
        RULE_typeBound = 18, RULE_additionalBound = 19, RULE_typeArguments = 20,
        RULE_typeArgumentList = 21, RULE_typeArgument = 22, RULE_wildcard = 23,
        RULE_wildcardBounds = 24, RULE_moduleName = 25, RULE_packageName = 26,
        RULE_typeName = 27, RULE_packageOrTypeName = 28, RULE_expressionName = 29,
        RULE_methodName = 30, RULE_ambiguousName = 31, RULE_compilationUnit = 32,
        RULE_ordinaryCompilation = 33, RULE_modularCompilation = 34, RULE_packageDeclaration = 35,
        RULE_packageModifier = 36, RULE_importDeclaration = 37, RULE_singleTypeImportDeclaration = 38,
        RULE_typeImportOnDemandDeclaration = 39, RULE_singleStaticImportDeclaration = 40,
        RULE_staticImportOnDemandDeclaration = 41, RULE_typeDeclaration = 42,
        RULE_moduleDeclaration = 43, RULE_moduleDirective = 44, RULE_requiresModifier = 45,
        RULE_classDeclaration = 46, RULE_normalClassDeclaration = 47, RULE_classModifier = 48,
        RULE_typeParameters = 49, RULE_typeParameterList = 50, RULE_superclass = 51,
        RULE_superinterfaces = 52, RULE_interfaceTypeList = 53, RULE_classBody = 54,
        RULE_classBodyDeclaration = 55, RULE_classMemberDeclaration = 56, RULE_fieldDeclaration = 57,
        RULE_fieldModifier = 58, RULE_variableDeclaratorList = 59, RULE_variableDeclarator = 60,
        RULE_variableDeclaratorId = 61, RULE_variableInitializer = 62, RULE_unannType = 63,
        RULE_unannPrimitiveType = 64, RULE_unannReferenceType = 65, RULE_unannClassOrInterfaceType = 66,
        RULE_unannClassType = 67, RULE_unannClassType_lf_unannClassOrInterfaceType = 68,
        RULE_unannClassType_lfno_unannClassOrInterfaceType = 69, RULE_unannInterfaceType = 70,
        RULE_unannInterfaceType_lf_unannClassOrInterfaceType = 71, RULE_unannInterfaceType_lfno_unannClassOrInterfaceType = 72,
        RULE_unannTypeVariable = 73, RULE_unannArrayType = 74, RULE_methodDeclaration = 75,
        RULE_methodModifier = 76, RULE_methodHeader = 77, RULE_result = 78, RULE_methodDeclarator = 79,
        RULE_formalParameterList = 80, RULE_formalParameters = 81, RULE_formalParameter = 82,
        RULE_variableModifier = 83, RULE_lastFormalParameter = 84, RULE_receiverParameter = 85,
        RULE_throws_ = 86, RULE_exceptionTypeList = 87, RULE_exceptionType = 88,
        RULE_methodBody = 89, RULE_instanceInitializer = 90, RULE_staticInitializer = 91,
        RULE_constructorDeclaration = 92, RULE_constructorModifier = 93, RULE_constructorDeclarator = 94,
        RULE_simpleTypeName = 95, RULE_constructorBody = 96, RULE_explicitConstructorInvocation = 97,
        RULE_enumDeclaration = 98, RULE_enumBody = 99, RULE_enumConstantList = 100,
        RULE_enumConstant = 101, RULE_enumConstantModifier = 102, RULE_enumBodyDeclarations = 103,
        RULE_interfaceDeclaration = 104, RULE_normalInterfaceDeclaration = 105,
        RULE_interfaceModifier = 106, RULE_extendsInterfaces = 107, RULE_interfaceBody = 108,
        RULE_interfaceMemberDeclaration = 109, RULE_constantDeclaration = 110,
        RULE_constantModifier = 111, RULE_interfaceMethodDeclaration = 112, RULE_interfaceMethodModifier = 113,
        RULE_annotationTypeDeclaration = 114, RULE_annotationTypeBody = 115, RULE_annotationTypeMemberDeclaration = 116,
        RULE_annotationTypeElementDeclaration = 117, RULE_annotationTypeElementModifier = 118,
        RULE_defaultValue = 119, RULE_annotation = 120, RULE_normalAnnotation = 121,
        RULE_elementValuePairList = 122, RULE_elementValuePair = 123, RULE_elementValue = 124,
        RULE_elementValueArrayInitializer = 125, RULE_elementValueList = 126,
        RULE_markerAnnotation = 127, RULE_singleElementAnnotation = 128, RULE_arrayInitializer = 129,
        RULE_variableInitializerList = 130, RULE_block = 131, RULE_blockStatements = 132,
        RULE_blockStatement = 133, RULE_localVariableDeclarationStatement = 134,
        RULE_localVariableDeclaration = 135, RULE_statement = 136, RULE_statementNoShortIf = 137,
        RULE_statementWithoutTrailingSubstatement = 138, RULE_emptyStatement = 139,
        RULE_labeledStatement = 140, RULE_labeledStatementNoShortIf = 141, RULE_expressionStatement = 142,
        RULE_statementExpression = 143, RULE_ifThenStatement = 144, RULE_ifThenElseStatement = 145,
        RULE_ifThenElseStatementNoShortIf = 146, RULE_assertStatement = 147, RULE_switchStatement = 148,
        RULE_switchBlock = 149, RULE_switchBlockStatementGroup = 150, RULE_switchLabels = 151,
        RULE_switchLabel = 152, RULE_enumConstantName = 153, RULE_whileStatement = 154,
        RULE_whileStatementNoShortIf = 155, RULE_doStatement = 156, RULE_forStatement = 157,
        RULE_forStatementNoShortIf = 158, RULE_basicForStatement = 159, RULE_basicForStatementNoShortIf = 160,
        RULE_forInit = 161, RULE_forUpdate = 162, RULE_statementExpressionList = 163,
        RULE_enhancedForStatement = 164, RULE_enhancedForStatementNoShortIf = 165,
        RULE_breakStatement = 166, RULE_continueStatement = 167, RULE_returnStatement = 168,
        RULE_throwStatement = 169, RULE_synchronizedStatement = 170, RULE_tryStatement = 171,
        RULE_catches = 172, RULE_catchClause = 173, RULE_catchFormalParameter = 174,
        RULE_catchType = 175, RULE_finally_ = 176, RULE_tryWithResourcesStatement = 177,
        RULE_resourceSpecification = 178, RULE_resourceList = 179, RULE_resource = 180,
        RULE_variableAccess = 181, RULE_primary = 182, RULE_primaryNoNewArray = 183,
        RULE_primaryNoNewArray_lf_arrayAccess = 184, RULE_primaryNoNewArray_lfno_arrayAccess = 185,
        RULE_primaryNoNewArray_lf_primary = 186, RULE_primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary = 187,
        RULE_primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary = 188, RULE_primaryNoNewArray_lfno_primary = 189,
        RULE_primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary = 190,
        RULE_primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary = 191,
        RULE_classLiteral = 192, RULE_classInstanceCreationExpression = 193, RULE_classInstanceCreationExpression_lf_primary = 194,
        RULE_classInstanceCreationExpression_lfno_primary = 195, RULE_typeArgumentsOrDiamond = 196,
        RULE_fieldAccess = 197, RULE_fieldAccess_lf_primary = 198, RULE_fieldAccess_lfno_primary = 199,
        RULE_arrayAccess = 200, RULE_arrayAccess_lf_primary = 201, RULE_arrayAccess_lfno_primary = 202,
        RULE_methodInvocation = 203, RULE_methodInvocation_lf_primary = 204, RULE_methodInvocation_lfno_primary = 205,
        RULE_argumentList = 206, RULE_methodReference = 207, RULE_methodReference_lf_primary = 208,
        RULE_methodReference_lfno_primary = 209, RULE_arrayCreationExpression = 210,
        RULE_dimExprs = 211, RULE_dimExpr = 212, RULE_constantExpression = 213,
        RULE_expression = 214, RULE_lambdaExpression = 215, RULE_lambdaParameters = 216,
        RULE_inferredFormalParameterList = 217, RULE_lambdaBody = 218, RULE_assignmentExpression = 219,
        RULE_assignment = 220, RULE_leftHandSide = 221, RULE_assignmentOperator = 222,
        RULE_conditionalExpression = 223, RULE_conditionalOrExpression = 224,
        RULE_conditionalAndExpression = 225, RULE_inclusiveOrExpression = 226,
        RULE_exclusiveOrExpression = 227, RULE_andExpression = 228, RULE_equalityExpression = 229,
        RULE_relationalExpression = 230, RULE_shiftExpression = 231, RULE_additiveExpression = 232,
        RULE_multiplicativeExpression = 233, RULE_unaryExpression = 234, RULE_preIncrementExpression = 235,
        RULE_preDecrementExpression = 236, RULE_unaryExpressionNotPlusMinus = 237,
        RULE_postfixExpression = 238, RULE_postIncrementExpression = 239, RULE_postIncrementExpression_lf_postfixExpression = 240,
        RULE_postDecrementExpression = 241, RULE_postDecrementExpression_lf_postfixExpression = 242,
        RULE_castExpression = 243, RULE_identifier = 244;
    public static readonly string[] ruleNames = {
        "literal", "primitiveType", "numericType", "integralType", "floatingPointType",
        "referenceType", "classOrInterfaceType", "classType", "classType_lf_classOrInterfaceType",
        "classType_lfno_classOrInterfaceType", "interfaceType", "interfaceType_lf_classOrInterfaceType",
        "interfaceType_lfno_classOrInterfaceType", "typeVariable", "arrayType",
        "dims", "typeParameter", "typeParameterModifier", "typeBound", "additionalBound",
        "typeArguments", "typeArgumentList", "typeArgument", "wildcard", "wildcardBounds",
        "moduleName", "packageName", "typeName", "packageOrTypeName", "expressionName",
        "methodName", "ambiguousName", "compilationUnit", "ordinaryCompilation",
        "modularCompilation", "packageDeclaration", "packageModifier", "importDeclaration",
        "singleTypeImportDeclaration", "typeImportOnDemandDeclaration", "singleStaticImportDeclaration",
        "staticImportOnDemandDeclaration", "typeDeclaration", "moduleDeclaration",
        "moduleDirective", "requiresModifier", "classDeclaration", "normalClassDeclaration",
        "classModifier", "typeParameters", "typeParameterList", "superclass",
        "superinterfaces", "interfaceTypeList", "classBody", "classBodyDeclaration",
        "classMemberDeclaration", "fieldDeclaration", "fieldModifier", "variableDeclaratorList",
        "variableDeclarator", "variableDeclaratorId", "variableInitializer", "unannType",
        "unannPrimitiveType", "unannReferenceType", "unannClassOrInterfaceType",
        "unannClassType", "unannClassType_lf_unannClassOrInterfaceType", "unannClassType_lfno_unannClassOrInterfaceType",
        "unannInterfaceType", "unannInterfaceType_lf_unannClassOrInterfaceType",
        "unannInterfaceType_lfno_unannClassOrInterfaceType", "unannTypeVariable",
        "unannArrayType", "methodDeclaration", "methodModifier", "methodHeader",
        "result", "methodDeclarator", "formalParameterList", "formalParameters",
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
        "statementNoShortIf", "statementWithoutTrailingSubstatement", "emptyStatement",
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
        "resource", "variableAccess", "primary", "primaryNoNewArray", "primaryNoNewArray_lf_arrayAccess",
        "primaryNoNewArray_lfno_arrayAccess", "primaryNoNewArray_lf_primary",
        "primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary", "primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary",
        "primaryNoNewArray_lfno_primary", "primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary",
        "primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary", "classLiteral",
        "classInstanceCreationExpression", "classInstanceCreationExpression_lf_primary",
        "classInstanceCreationExpression_lfno_primary", "typeArgumentsOrDiamond",
        "fieldAccess", "fieldAccess_lf_primary", "fieldAccess_lfno_primary", "arrayAccess",
        "arrayAccess_lf_primary", "arrayAccess_lfno_primary", "methodInvocation",
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
        "postDecrementExpression_lf_postfixExpression", "castExpression", "identifier"
    };

    private static readonly string[] _LiteralNames = {
        null, "'open'", "'module'", "'requires'", "'exports'", "'to'", "'opens'",
        "'uses'", "'provides'", "'with'", "'transitive'", "'abstract'", "'assert'",
        "'boolean'", "'break'", "'byte'", "'case'", "'catch'", "'char'", "'class'",
        "'const'", "'continue'", "'default'", "'do'", "'double'", "'else'", "'enum'",
        "'extends'", "'final'", "'finally'", "'float'", "'for'", "'if'", "'goto'",
        "'implements'", "'import'", "'instanceof'", "'int'", "'interface'", "'long'",
        "'native'", "'new'", "'package'", "'private'", "'protected'", "'public'",
        "'return'", "'short'", "'static'", "'strictfp'", "'super'", "'switch'",
        "'synchronized'", "'this'", "'throw'", "'throws'", "'transient'", "'try'",
        "'void'", "'volatile'", "'while'", "'_'", null, null, null, null, null,
        "'null'", "'('", "')'", "'{'", "'}'", "'['", "']'", "';'", "','", "'.'",
        "'...'", "'@'", "'::'", "'='", "'>'", "'<'", "'!'", "'~'", "'?'", "':'",
        "'->'", "'=='", "'<='", "'>='", "'!='", "'&&'", "'||'", "'++'", "'--'",
        "'+'", "'-'", "'*'", "'/'", "'&'", "'|'", "'^'", "'%'", "'+='", "'-='",
        "'*='", "'/='", "'&='", "'|='", "'^='", "'%='", "'<<='", "'>>='", "'>>>='"
    };
    private static readonly string[] _SymbolicNames = {
        null, null, null, null, null, null, null, null, null, null, null, "ABSTRACT",
        "ASSERT", "BOOLEAN", "BREAK", "BYTE", "CASE", "CATCH", "CHAR", "CLASS",
        "CONST", "CONTINUE", "DEFAULT", "DO", "DOUBLE", "ELSE", "ENUM", "EXTENDS",
        "FINAL", "FINALLY", "FLOAT", "FOR", "IF", "GOTO", "IMPLEMENTS", "IMPORT",
        "INSTANCEOF", "INT", "INTERFACE", "LONG", "NATIVE", "NEW", "PACKAGE",
        "PRIVATE", "PROTECTED", "PUBLIC", "RETURN", "SHORT", "STATIC", "STRICTFP",
        "SUPER", "SWITCH", "SYNCHRONIZED", "THIS", "THROW", "THROWS", "TRANSIENT",
        "TRY", "VOID", "VOLATILE", "WHILE", "UNDER_SCORE", "IntegerLiteral", "FloatingPointLiteral",
        "BooleanLiteral", "CharacterLiteral", "StringLiteral", "NullLiteral",
        "LPAREN", "RPAREN", "LBRACE", "RBRACE", "LBRACK", "RBRACK", "SEMI", "COMMA",
        "DOT", "ELLIPSIS", "AT", "COLONCOLON", "ASSIGN", "GT", "LT", "BANG", "TILDE",
        "QUESTION", "COLON", "ARROW", "EQUAL", "LE", "GE", "NOTEQUAL", "AND",
        "OR", "INC", "DEC", "ADD", "SUB", "MUL", "DIV", "BITAND", "BITOR", "CARET",
        "MOD", "ADD_ASSIGN", "SUB_ASSIGN", "MUL_ASSIGN", "DIV_ASSIGN", "AND_ASSIGN",
        "OR_ASSIGN", "XOR_ASSIGN", "MOD_ASSIGN", "LSHIFT_ASSIGN", "RSHIFT_ASSIGN",
        "URSHIFT_ASSIGN", "Identifier", "WS", "COMMENT", "LINE_COMMENT"
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

    public override string GrammarFileName { get { return "Java9.g4"; } }

    public override string[] RuleNames { get { return ruleNames; } }

    public override int[] SerializedAtn { get { return _serializedATN; } }

    static Java9Parser()
    {
        decisionToDFA = new DFA[_ATN.NumberOfDecisions];
        for (int i = 0; i < _ATN.NumberOfDecisions; i++)
        {
            decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
        }
    }

    public Java9Parser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

    public Java9Parser(ITokenStream input, TextWriter output, TextWriter errorOutput)
    : base(input, output, errorOutput)
    {
        Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
    }

    public partial class LiteralContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IntegerLiteral() { return GetToken(Java9Parser.IntegerLiteral, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FloatingPointLiteral() { return GetToken(Java9Parser.FloatingPointLiteral, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BooleanLiteral() { return GetToken(Java9Parser.BooleanLiteral, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CharacterLiteral() { return GetToken(Java9Parser.CharacterLiteral, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode StringLiteral() { return GetToken(Java9Parser.StringLiteral, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NullLiteral() { return GetToken(Java9Parser.NullLiteral, 0); }
        public LiteralContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_literal; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterLiteral(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitLiteral(this);
        }
    }

    [RuleVersion(0)]
    public LiteralContext literal()
    {
        LiteralContext _localctx = new LiteralContext(Context, State);
        EnterRule(_localctx, 0, RULE_literal);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 490;
                _la = TokenStream.LA(1);
                if (!(((((_la - 62)) & ~0x3f) == 0 && ((1L << (_la - 62)) & ((1L << (IntegerLiteral - 62)) | (1L << (FloatingPointLiteral - 62)) | (1L << (BooleanLiteral - 62)) | (1L << (CharacterLiteral - 62)) | (1L << (StringLiteral - 62)) | (1L << (NullLiteral - 62)))) != 0)))
                {
                    ErrorHandler.RecoverInline(this);
                }
                else
                {
                    ErrorHandler.ReportMatch(this);
                    Consume();
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PrimitiveTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public NumericTypeContext numericType()
        {
            return GetRuleContext<NumericTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext[] annotation()
        {
            return GetRuleContexts<AnnotationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation(int i)
        {
            return GetRuleContext<AnnotationContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BOOLEAN() { return GetToken(Java9Parser.BOOLEAN, 0); }
        public PrimitiveTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_primitiveType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPrimitiveType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPrimitiveType(this);
        }
    }

    [RuleVersion(0)]
    public PrimitiveTypeContext primitiveType()
    {
        PrimitiveTypeContext _localctx = new PrimitiveTypeContext(Context, State);
        EnterRule(_localctx, 2, RULE_primitiveType);
        int _la;
        try
        {
            State = 506;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 2, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 495;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == AT)
                        {
                            {
                                {
                                    State = 492;
                                    annotation();
                                }
                            }
                            State = 497;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 498;
                        numericType();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 502;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == AT)
                        {
                            {
                                {
                                    State = 499;
                                    annotation();
                                }
                            }
                            State = 504;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 505;
                        Match(BOOLEAN);
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class NumericTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IntegralTypeContext integralType()
        {
            return GetRuleContext<IntegralTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public FloatingPointTypeContext floatingPointType()
        {
            return GetRuleContext<FloatingPointTypeContext>(0);
        }
        public NumericTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_numericType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterNumericType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitNumericType(this);
        }
    }

    [RuleVersion(0)]
    public NumericTypeContext numericType()
    {
        NumericTypeContext _localctx = new NumericTypeContext(Context, State);
        EnterRule(_localctx, 4, RULE_numericType);
        try
        {
            State = 510;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case BYTE:
                case CHAR:
                case INT:
                case LONG:
                case SHORT:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 508;
                        integralType();
                    }
                    break;
                case DOUBLE:
                case FLOAT:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 509;
                        floatingPointType();
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class IntegralTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BYTE() { return GetToken(Java9Parser.BYTE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SHORT() { return GetToken(Java9Parser.SHORT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT() { return GetToken(Java9Parser.INT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LONG() { return GetToken(Java9Parser.LONG, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CHAR() { return GetToken(Java9Parser.CHAR, 0); }
        public IntegralTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_integralType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterIntegralType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitIntegralType(this);
        }
    }

    [RuleVersion(0)]
    public IntegralTypeContext integralType()
    {
        IntegralTypeContext _localctx = new IntegralTypeContext(Context, State);
        EnterRule(_localctx, 6, RULE_integralType);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 512;
                _la = TokenStream.LA(1);
                if (!((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BYTE) | (1L << CHAR) | (1L << INT) | (1L << LONG) | (1L << SHORT))) != 0)))
                {
                    ErrorHandler.RecoverInline(this);
                }
                else
                {
                    ErrorHandler.ReportMatch(this);
                    Consume();
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class FloatingPointTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FLOAT() { return GetToken(Java9Parser.FLOAT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOUBLE() { return GetToken(Java9Parser.DOUBLE, 0); }
        public FloatingPointTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_floatingPointType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterFloatingPointType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitFloatingPointType(this);
        }
    }

    [RuleVersion(0)]
    public FloatingPointTypeContext floatingPointType()
    {
        FloatingPointTypeContext _localctx = new FloatingPointTypeContext(Context, State);
        EnterRule(_localctx, 8, RULE_floatingPointType);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 514;
                _la = TokenStream.LA(1);
                if (!(_la == DOUBLE || _la == FLOAT))
                {
                    ErrorHandler.RecoverInline(this);
                }
                else
                {
                    ErrorHandler.ReportMatch(this);
                    Consume();
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ReferenceTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassOrInterfaceTypeContext classOrInterfaceType()
        {
            return GetRuleContext<ClassOrInterfaceTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeVariableContext typeVariable()
        {
            return GetRuleContext<TypeVariableContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ArrayTypeContext arrayType()
        {
            return GetRuleContext<ArrayTypeContext>(0);
        }
        public ReferenceTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_referenceType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterReferenceType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitReferenceType(this);
        }
    }

    [RuleVersion(0)]
    public ReferenceTypeContext referenceType()
    {
        ReferenceTypeContext _localctx = new ReferenceTypeContext(Context, State);
        EnterRule(_localctx, 10, RULE_referenceType);
        try
        {
            State = 519;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 4, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 516;
                        classOrInterfaceType();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 517;
                        typeVariable();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 518;
                        arrayType();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ClassOrInterfaceTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassType_lfno_classOrInterfaceTypeContext classType_lfno_classOrInterfaceType()
        {
            return GetRuleContext<ClassType_lfno_classOrInterfaceTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceType_lfno_classOrInterfaceTypeContext interfaceType_lfno_classOrInterfaceType()
        {
            return GetRuleContext<InterfaceType_lfno_classOrInterfaceTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassType_lf_classOrInterfaceTypeContext[] classType_lf_classOrInterfaceType()
        {
            return GetRuleContexts<ClassType_lf_classOrInterfaceTypeContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassType_lf_classOrInterfaceTypeContext classType_lf_classOrInterfaceType(int i)
        {
            return GetRuleContext<ClassType_lf_classOrInterfaceTypeContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceType_lf_classOrInterfaceTypeContext[] interfaceType_lf_classOrInterfaceType()
        {
            return GetRuleContexts<InterfaceType_lf_classOrInterfaceTypeContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceType_lf_classOrInterfaceTypeContext interfaceType_lf_classOrInterfaceType(int i)
        {
            return GetRuleContext<InterfaceType_lf_classOrInterfaceTypeContext>(i);
        }
        public ClassOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_classOrInterfaceType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterClassOrInterfaceType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitClassOrInterfaceType(this);
        }
    }

    [RuleVersion(0)]
    public ClassOrInterfaceTypeContext classOrInterfaceType()
    {
        ClassOrInterfaceTypeContext _localctx = new ClassOrInterfaceTypeContext(Context, State);
        EnterRule(_localctx, 12, RULE_classOrInterfaceType);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                State = 523;
                ErrorHandler.Sync(this);
                switch (Interpreter.AdaptivePredict(TokenStream, 5, Context))
                {
                    case 1:
                        {
                            State = 521;
                            classType_lfno_classOrInterfaceType();
                        }
                        break;
                    case 2:
                        {
                            State = 522;
                            interfaceType_lfno_classOrInterfaceType();
                        }
                        break;
                }
                State = 529;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 7, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        {
                            State = 527;
                            ErrorHandler.Sync(this);
                            switch (Interpreter.AdaptivePredict(TokenStream, 6, Context))
                            {
                                case 1:
                                    {
                                        State = 525;
                                        classType_lf_classOrInterfaceType();
                                    }
                                    break;
                                case 2:
                                    {
                                        State = 526;
                                        interfaceType_lf_classOrInterfaceType();
                                    }
                                    break;
                            }
                        }
                    }
                    State = 531;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 7, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ClassTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext[] annotation()
        {
            return GetRuleContexts<AnnotationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation(int i)
        {
            return GetRuleContext<AnnotationContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsContext typeArguments()
        {
            return GetRuleContext<TypeArgumentsContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassOrInterfaceTypeContext classOrInterfaceType()
        {
            return GetRuleContext<ClassOrInterfaceTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        public ClassTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_classType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterClassType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitClassType(this);
        }
    }

    [RuleVersion(0)]
    public ClassTypeContext classType()
    {
        ClassTypeContext _localctx = new ClassTypeContext(Context, State);
        EnterRule(_localctx, 14, RULE_classType);
        int _la;
        try
        {
            State = 554;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 12, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 535;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == AT)
                        {
                            {
                                {
                                    State = 532;
                                    annotation();
                                }
                            }
                            State = 537;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 538;
                        identifier();
                        State = 540;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 539;
                                typeArguments();
                            }
                        }

                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 542;
                        classOrInterfaceType();
                        State = 543;
                        Match(DOT);
                        State = 547;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == AT)
                        {
                            {
                                {
                                    State = 544;
                                    annotation();
                                }
                            }
                            State = 549;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 550;
                        identifier();
                        State = 552;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 551;
                                typeArguments();
                            }
                        }

                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ClassType_lf_classOrInterfaceTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext[] annotation()
        {
            return GetRuleContexts<AnnotationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation(int i)
        {
            return GetRuleContext<AnnotationContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsContext typeArguments()
        {
            return GetRuleContext<TypeArgumentsContext>(0);
        }
        public ClassType_lf_classOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_classType_lf_classOrInterfaceType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterClassType_lf_classOrInterfaceType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitClassType_lf_classOrInterfaceType(this);
        }
    }

    [RuleVersion(0)]
    public ClassType_lf_classOrInterfaceTypeContext classType_lf_classOrInterfaceType()
    {
        ClassType_lf_classOrInterfaceTypeContext _localctx = new ClassType_lf_classOrInterfaceTypeContext(Context, State);
        EnterRule(_localctx, 16, RULE_classType_lf_classOrInterfaceType);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 556;
                Match(DOT);
                State = 560;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == AT)
                {
                    {
                        {
                            State = 557;
                            annotation();
                        }
                    }
                    State = 562;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 563;
                identifier();
                State = 565;
                ErrorHandler.Sync(this);
                switch (Interpreter.AdaptivePredict(TokenStream, 14, Context))
                {
                    case 1:
                        {
                            State = 564;
                            typeArguments();
                        }
                        break;
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ClassType_lfno_classOrInterfaceTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext[] annotation()
        {
            return GetRuleContexts<AnnotationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation(int i)
        {
            return GetRuleContext<AnnotationContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsContext typeArguments()
        {
            return GetRuleContext<TypeArgumentsContext>(0);
        }
        public ClassType_lfno_classOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_classType_lfno_classOrInterfaceType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterClassType_lfno_classOrInterfaceType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitClassType_lfno_classOrInterfaceType(this);
        }
    }

    [RuleVersion(0)]
    public ClassType_lfno_classOrInterfaceTypeContext classType_lfno_classOrInterfaceType()
    {
        ClassType_lfno_classOrInterfaceTypeContext _localctx = new ClassType_lfno_classOrInterfaceTypeContext(Context, State);
        EnterRule(_localctx, 18, RULE_classType_lfno_classOrInterfaceType);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 570;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == AT)
                {
                    {
                        {
                            State = 567;
                            annotation();
                        }
                    }
                    State = 572;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 573;
                identifier();
                State = 575;
                ErrorHandler.Sync(this);
                switch (Interpreter.AdaptivePredict(TokenStream, 16, Context))
                {
                    case 1:
                        {
                            State = 574;
                            typeArguments();
                        }
                        break;
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class InterfaceTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassTypeContext classType()
        {
            return GetRuleContext<ClassTypeContext>(0);
        }
        public InterfaceTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_interfaceType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterInterfaceType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitInterfaceType(this);
        }
    }

    [RuleVersion(0)]
    public InterfaceTypeContext interfaceType()
    {
        InterfaceTypeContext _localctx = new InterfaceTypeContext(Context, State);
        EnterRule(_localctx, 20, RULE_interfaceType);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 577;
                classType();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class InterfaceType_lf_classOrInterfaceTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassType_lf_classOrInterfaceTypeContext classType_lf_classOrInterfaceType()
        {
            return GetRuleContext<ClassType_lf_classOrInterfaceTypeContext>(0);
        }
        public InterfaceType_lf_classOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_interfaceType_lf_classOrInterfaceType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterInterfaceType_lf_classOrInterfaceType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitInterfaceType_lf_classOrInterfaceType(this);
        }
    }

    [RuleVersion(0)]
    public InterfaceType_lf_classOrInterfaceTypeContext interfaceType_lf_classOrInterfaceType()
    {
        InterfaceType_lf_classOrInterfaceTypeContext _localctx = new InterfaceType_lf_classOrInterfaceTypeContext(Context, State);
        EnterRule(_localctx, 22, RULE_interfaceType_lf_classOrInterfaceType);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 579;
                classType_lf_classOrInterfaceType();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class InterfaceType_lfno_classOrInterfaceTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassType_lfno_classOrInterfaceTypeContext classType_lfno_classOrInterfaceType()
        {
            return GetRuleContext<ClassType_lfno_classOrInterfaceTypeContext>(0);
        }
        public InterfaceType_lfno_classOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_interfaceType_lfno_classOrInterfaceType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterInterfaceType_lfno_classOrInterfaceType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitInterfaceType_lfno_classOrInterfaceType(this);
        }
    }

    [RuleVersion(0)]
    public InterfaceType_lfno_classOrInterfaceTypeContext interfaceType_lfno_classOrInterfaceType()
    {
        InterfaceType_lfno_classOrInterfaceTypeContext _localctx = new InterfaceType_lfno_classOrInterfaceTypeContext(Context, State);
        EnterRule(_localctx, 24, RULE_interfaceType_lfno_classOrInterfaceType);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 581;
                classType_lfno_classOrInterfaceType();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class TypeVariableContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext[] annotation()
        {
            return GetRuleContexts<AnnotationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation(int i)
        {
            return GetRuleContext<AnnotationContext>(i);
        }
        public TypeVariableContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_typeVariable; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterTypeVariable(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitTypeVariable(this);
        }
    }

    [RuleVersion(0)]
    public TypeVariableContext typeVariable()
    {
        TypeVariableContext _localctx = new TypeVariableContext(Context, State);
        EnterRule(_localctx, 26, RULE_typeVariable);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 586;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == AT)
                {
                    {
                        {
                            State = 583;
                            annotation();
                        }
                    }
                    State = 588;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 589;
                identifier();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ArrayTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimitiveTypeContext primitiveType()
        {
            return GetRuleContext<PrimitiveTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public DimsContext dims()
        {
            return GetRuleContext<DimsContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassOrInterfaceTypeContext classOrInterfaceType()
        {
            return GetRuleContext<ClassOrInterfaceTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeVariableContext typeVariable()
        {
            return GetRuleContext<TypeVariableContext>(0);
        }
        public ArrayTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_arrayType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterArrayType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitArrayType(this);
        }
    }

    [RuleVersion(0)]
    public ArrayTypeContext arrayType()
    {
        ArrayTypeContext _localctx = new ArrayTypeContext(Context, State);
        EnterRule(_localctx, 28, RULE_arrayType);
        try
        {
            State = 600;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 18, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 591;
                        primitiveType();
                        State = 592;
                        dims();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 594;
                        classOrInterfaceType();
                        State = 595;
                        dims();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 597;
                        typeVariable();
                        State = 598;
                        dims();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class DimsContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LBRACK() { return GetTokens(Java9Parser.LBRACK); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode LBRACK(int i)
        {
            return GetToken(Java9Parser.LBRACK, i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RBRACK() { return GetTokens(Java9Parser.RBRACK); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode RBRACK(int i)
        {
            return GetToken(Java9Parser.RBRACK, i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext[] annotation()
        {
            return GetRuleContexts<AnnotationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation(int i)
        {
            return GetRuleContext<AnnotationContext>(i);
        }
        public DimsContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_dims; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterDims(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitDims(this);
        }
    }

    [RuleVersion(0)]
    public DimsContext dims()
    {
        DimsContext _localctx = new DimsContext(Context, State);
        EnterRule(_localctx, 30, RULE_dims);
        int _la;
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                State = 605;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == AT)
                {
                    {
                        {
                            State = 602;
                            annotation();
                        }
                    }
                    State = 607;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 608;
                Match(LBRACK);
                State = 609;
                Match(RBRACK);
                State = 620;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 21, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        {
                            {
                                State = 613;
                                ErrorHandler.Sync(this);
                                _la = TokenStream.LA(1);
                                while (_la == AT)
                                {
                                    {
                                        {
                                            State = 610;
                                            annotation();
                                        }
                                    }
                                    State = 615;
                                    ErrorHandler.Sync(this);
                                    _la = TokenStream.LA(1);
                                }
                                State = 616;
                                Match(LBRACK);
                                State = 617;
                                Match(RBRACK);
                            }
                        }
                    }
                    State = 622;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 21, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class TypeParameterContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeParameterModifierContext[] typeParameterModifier()
        {
            return GetRuleContexts<TypeParameterModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeParameterModifierContext typeParameterModifier(int i)
        {
            return GetRuleContext<TypeParameterModifierContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeBoundContext typeBound()
        {
            return GetRuleContext<TypeBoundContext>(0);
        }
        public TypeParameterContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_typeParameter; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterTypeParameter(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitTypeParameter(this);
        }
    }

    [RuleVersion(0)]
    public TypeParameterContext typeParameter()
    {
        TypeParameterContext _localctx = new TypeParameterContext(Context, State);
        EnterRule(_localctx, 32, RULE_typeParameter);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 626;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == AT)
                {
                    {
                        {
                            State = 623;
                            typeParameterModifier();
                        }
                    }
                    State = 628;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 629;
                identifier();
                State = 631;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == EXTENDS)
                {
                    {
                        State = 630;
                        typeBound();
                    }
                }

            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class TypeParameterModifierContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation()
        {
            return GetRuleContext<AnnotationContext>(0);
        }
        public TypeParameterModifierContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_typeParameterModifier; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterTypeParameterModifier(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitTypeParameterModifier(this);
        }
    }

    [RuleVersion(0)]
    public TypeParameterModifierContext typeParameterModifier()
    {
        TypeParameterModifierContext _localctx = new TypeParameterModifierContext(Context, State);
        EnterRule(_localctx, 34, RULE_typeParameterModifier);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 633;
                annotation();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class TypeBoundContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXTENDS() { return GetToken(Java9Parser.EXTENDS, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeVariableContext typeVariable()
        {
            return GetRuleContext<TypeVariableContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassOrInterfaceTypeContext classOrInterfaceType()
        {
            return GetRuleContext<ClassOrInterfaceTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AdditionalBoundContext[] additionalBound()
        {
            return GetRuleContexts<AdditionalBoundContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AdditionalBoundContext additionalBound(int i)
        {
            return GetRuleContext<AdditionalBoundContext>(i);
        }
        public TypeBoundContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_typeBound; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterTypeBound(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitTypeBound(this);
        }
    }

    [RuleVersion(0)]
    public TypeBoundContext typeBound()
    {
        TypeBoundContext _localctx = new TypeBoundContext(Context, State);
        EnterRule(_localctx, 36, RULE_typeBound);
        int _la;
        try
        {
            State = 645;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 25, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 635;
                        Match(EXTENDS);
                        State = 636;
                        typeVariable();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 637;
                        Match(EXTENDS);
                        State = 638;
                        classOrInterfaceType();
                        State = 642;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == BITAND)
                        {
                            {
                                {
                                    State = 639;
                                    additionalBound();
                                }
                            }
                            State = 644;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class AdditionalBoundContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BITAND() { return GetToken(Java9Parser.BITAND, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceTypeContext interfaceType()
        {
            return GetRuleContext<InterfaceTypeContext>(0);
        }
        public AdditionalBoundContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_additionalBound; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterAdditionalBound(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitAdditionalBound(this);
        }
    }

    [RuleVersion(0)]
    public AdditionalBoundContext additionalBound()
    {
        AdditionalBoundContext _localctx = new AdditionalBoundContext(Context, State);
        EnterRule(_localctx, 38, RULE_additionalBound);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 647;
                Match(BITAND);
                State = 648;
                interfaceType();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class TypeArgumentsContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LT() { return GetToken(Java9Parser.LT, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentListContext typeArgumentList()
        {
            return GetRuleContext<TypeArgumentListContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT() { return GetToken(Java9Parser.GT, 0); }
        public TypeArgumentsContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_typeArguments; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterTypeArguments(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitTypeArguments(this);
        }
    }

    [RuleVersion(0)]
    public TypeArgumentsContext typeArguments()
    {
        TypeArgumentsContext _localctx = new TypeArgumentsContext(Context, State);
        EnterRule(_localctx, 40, RULE_typeArguments);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 650;
                Match(LT);
                State = 651;
                typeArgumentList();
                State = 652;
                Match(GT);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class TypeArgumentListContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentContext[] typeArgument()
        {
            return GetRuleContexts<TypeArgumentContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentContext typeArgument(int i)
        {
            return GetRuleContext<TypeArgumentContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java9Parser.COMMA); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode COMMA(int i)
        {
            return GetToken(Java9Parser.COMMA, i);
        }
        public TypeArgumentListContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_typeArgumentList; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterTypeArgumentList(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitTypeArgumentList(this);
        }
    }

    [RuleVersion(0)]
    public TypeArgumentListContext typeArgumentList()
    {
        TypeArgumentListContext _localctx = new TypeArgumentListContext(Context, State);
        EnterRule(_localctx, 42, RULE_typeArgumentList);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 654;
                typeArgument();
                State = 659;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == COMMA)
                {
                    {
                        {
                            State = 655;
                            Match(COMMA);
                            State = 656;
                            typeArgument();
                        }
                    }
                    State = 661;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class TypeArgumentContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ReferenceTypeContext referenceType()
        {
            return GetRuleContext<ReferenceTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public WildcardContext wildcard()
        {
            return GetRuleContext<WildcardContext>(0);
        }
        public TypeArgumentContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_typeArgument; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterTypeArgument(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitTypeArgument(this);
        }
    }

    [RuleVersion(0)]
    public TypeArgumentContext typeArgument()
    {
        TypeArgumentContext _localctx = new TypeArgumentContext(Context, State);
        EnterRule(_localctx, 44, RULE_typeArgument);
        try
        {
            State = 664;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 27, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 662;
                        referenceType();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 663;
                        wildcard();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class WildcardContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode QUESTION() { return GetToken(Java9Parser.QUESTION, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext[] annotation()
        {
            return GetRuleContexts<AnnotationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation(int i)
        {
            return GetRuleContext<AnnotationContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public WildcardBoundsContext wildcardBounds()
        {
            return GetRuleContext<WildcardBoundsContext>(0);
        }
        public WildcardContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_wildcard; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterWildcard(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitWildcard(this);
        }
    }

    [RuleVersion(0)]
    public WildcardContext wildcard()
    {
        WildcardContext _localctx = new WildcardContext(Context, State);
        EnterRule(_localctx, 46, RULE_wildcard);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 669;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == AT)
                {
                    {
                        {
                            State = 666;
                            annotation();
                        }
                    }
                    State = 671;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 672;
                Match(QUESTION);
                State = 674;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == EXTENDS || _la == SUPER)
                {
                    {
                        State = 673;
                        wildcardBounds();
                    }
                }

            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class WildcardBoundsContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXTENDS() { return GetToken(Java9Parser.EXTENDS, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ReferenceTypeContext referenceType()
        {
            return GetRuleContext<ReferenceTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUPER() { return GetToken(Java9Parser.SUPER, 0); }
        public WildcardBoundsContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_wildcardBounds; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterWildcardBounds(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitWildcardBounds(this);
        }
    }

    [RuleVersion(0)]
    public WildcardBoundsContext wildcardBounds()
    {
        WildcardBoundsContext _localctx = new WildcardBoundsContext(Context, State);
        EnterRule(_localctx, 48, RULE_wildcardBounds);
        try
        {
            State = 680;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case EXTENDS:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 676;
                        Match(EXTENDS);
                        State = 677;
                        referenceType();
                    }
                    break;
                case SUPER:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 678;
                        Match(SUPER);
                        State = 679;
                        referenceType();
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ModuleNameContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ModuleNameContext moduleName()
        {
            return GetRuleContext<ModuleNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        public ModuleNameContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_moduleName; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterModuleName(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitModuleName(this);
        }
    }

    [RuleVersion(0)]
    public ModuleNameContext moduleName()
    {
        return moduleName(0);
    }

    private ModuleNameContext moduleName(int _p)
    {
        ParserRuleContext _parentctx = Context;
        int _parentState = State;
        ModuleNameContext _localctx = new ModuleNameContext(Context, _parentState);
        ModuleNameContext _prevctx = _localctx;
        int _startState = 50;
        EnterRecursionRule(_localctx, 50, RULE_moduleName, _p);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                {
                    State = 683;
                    identifier();
                }
                Context.Stop = TokenStream.LT(-1);
                State = 690;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 31, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        if (ParseListeners != null)
                            TriggerExitRuleEvent();
                        _prevctx = _localctx;
                        {
                            {
                                _localctx = new ModuleNameContext(_parentctx, _parentState);
                                PushNewRecursionContext(_localctx, _startState, RULE_moduleName);
                                State = 685;
                                if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
                                State = 686;
                                Match(DOT);
                                State = 687;
                                identifier();
                            }
                        }
                    }
                    State = 692;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 31, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            UnrollRecursionContexts(_parentctx);
        }
        return _localctx;
    }

    public partial class PackageNameContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PackageNameContext packageName()
        {
            return GetRuleContext<PackageNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        public PackageNameContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_packageName; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPackageName(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPackageName(this);
        }
    }

    [RuleVersion(0)]
    public PackageNameContext packageName()
    {
        return packageName(0);
    }

    private PackageNameContext packageName(int _p)
    {
        ParserRuleContext _parentctx = Context;
        int _parentState = State;
        PackageNameContext _localctx = new PackageNameContext(Context, _parentState);
        PackageNameContext _prevctx = _localctx;
        int _startState = 52;
        EnterRecursionRule(_localctx, 52, RULE_packageName, _p);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                {
                    State = 694;
                    identifier();
                }
                Context.Stop = TokenStream.LT(-1);
                State = 701;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 32, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        if (ParseListeners != null)
                            TriggerExitRuleEvent();
                        _prevctx = _localctx;
                        {
                            {
                                _localctx = new PackageNameContext(_parentctx, _parentState);
                                PushNewRecursionContext(_localctx, _startState, RULE_packageName);
                                State = 696;
                                if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
                                State = 697;
                                Match(DOT);
                                State = 698;
                                identifier();
                            }
                        }
                    }
                    State = 703;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 32, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            UnrollRecursionContexts(_parentctx);
        }
        return _localctx;
    }

    public partial class TypeNameContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PackageOrTypeNameContext packageOrTypeName()
        {
            return GetRuleContext<PackageOrTypeNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        public TypeNameContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_typeName; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterTypeName(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitTypeName(this);
        }
    }

    [RuleVersion(0)]
    public TypeNameContext typeName()
    {
        TypeNameContext _localctx = new TypeNameContext(Context, State);
        EnterRule(_localctx, 54, RULE_typeName);
        try
        {
            State = 709;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 33, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 704;
                        identifier();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 705;
                        packageOrTypeName(0);
                        State = 706;
                        Match(DOT);
                        State = 707;
                        identifier();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PackageOrTypeNameContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PackageOrTypeNameContext packageOrTypeName()
        {
            return GetRuleContext<PackageOrTypeNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        public PackageOrTypeNameContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_packageOrTypeName; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPackageOrTypeName(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPackageOrTypeName(this);
        }
    }

    [RuleVersion(0)]
    public PackageOrTypeNameContext packageOrTypeName()
    {
        return packageOrTypeName(0);
    }

    private PackageOrTypeNameContext packageOrTypeName(int _p)
    {
        ParserRuleContext _parentctx = Context;
        int _parentState = State;
        PackageOrTypeNameContext _localctx = new PackageOrTypeNameContext(Context, _parentState);
        PackageOrTypeNameContext _prevctx = _localctx;
        int _startState = 56;
        EnterRecursionRule(_localctx, 56, RULE_packageOrTypeName, _p);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                {
                    State = 712;
                    identifier();
                }
                Context.Stop = TokenStream.LT(-1);
                State = 719;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 34, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        if (ParseListeners != null)
                            TriggerExitRuleEvent();
                        _prevctx = _localctx;
                        {
                            {
                                _localctx = new PackageOrTypeNameContext(_parentctx, _parentState);
                                PushNewRecursionContext(_localctx, _startState, RULE_packageOrTypeName);
                                State = 714;
                                if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
                                State = 715;
                                Match(DOT);
                                State = 716;
                                identifier();
                            }
                        }
                    }
                    State = 721;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 34, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            UnrollRecursionContexts(_parentctx);
        }
        return _localctx;
    }

    public partial class ExpressionNameContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AmbiguousNameContext ambiguousName()
        {
            return GetRuleContext<AmbiguousNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        public ExpressionNameContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_expressionName; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterExpressionName(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitExpressionName(this);
        }
    }

    [RuleVersion(0)]
    public ExpressionNameContext expressionName()
    {
        ExpressionNameContext _localctx = new ExpressionNameContext(Context, State);
        EnterRule(_localctx, 58, RULE_expressionName);
        try
        {
            State = 727;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 35, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 722;
                        identifier();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 723;
                        ambiguousName(0);
                        State = 724;
                        Match(DOT);
                        State = 725;
                        identifier();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class MethodNameContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        public MethodNameContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_methodName; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterMethodName(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitMethodName(this);
        }
    }

    [RuleVersion(0)]
    public MethodNameContext methodName()
    {
        MethodNameContext _localctx = new MethodNameContext(Context, State);
        EnterRule(_localctx, 60, RULE_methodName);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 729;
                identifier();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class AmbiguousNameContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AmbiguousNameContext ambiguousName()
        {
            return GetRuleContext<AmbiguousNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        public AmbiguousNameContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_ambiguousName; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterAmbiguousName(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitAmbiguousName(this);
        }
    }

    [RuleVersion(0)]
    public AmbiguousNameContext ambiguousName()
    {
        return ambiguousName(0);
    }

    private AmbiguousNameContext ambiguousName(int _p)
    {
        ParserRuleContext _parentctx = Context;
        int _parentState = State;
        AmbiguousNameContext _localctx = new AmbiguousNameContext(Context, _parentState);
        AmbiguousNameContext _prevctx = _localctx;
        int _startState = 62;
        EnterRecursionRule(_localctx, 62, RULE_ambiguousName, _p);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                {
                    State = 732;
                    identifier();
                }
                Context.Stop = TokenStream.LT(-1);
                State = 739;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 36, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        if (ParseListeners != null)
                            TriggerExitRuleEvent();
                        _prevctx = _localctx;
                        {
                            {
                                _localctx = new AmbiguousNameContext(_parentctx, _parentState);
                                PushNewRecursionContext(_localctx, _startState, RULE_ambiguousName);
                                State = 734;
                                if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
                                State = 735;
                                Match(DOT);
                                State = 736;
                                identifier();
                            }
                        }
                    }
                    State = 741;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 36, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            UnrollRecursionContexts(_parentctx);
        }
        return _localctx;
    }

    public partial class CompilationUnitContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public OrdinaryCompilationContext ordinaryCompilation()
        {
            return GetRuleContext<OrdinaryCompilationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ModularCompilationContext modularCompilation()
        {
            return GetRuleContext<ModularCompilationContext>(0);
        }
        public CompilationUnitContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_compilationUnit; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterCompilationUnit(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitCompilationUnit(this);
        }
    }

    [RuleVersion(0)]
    public CompilationUnitContext compilationUnit()
    {
        CompilationUnitContext _localctx = new CompilationUnitContext(Context, State);
        EnterRule(_localctx, 64, RULE_compilationUnit);
        try
        {
            State = 744;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 37, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 742;
                        ordinaryCompilation();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 743;
                        modularCompilation();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class OrdinaryCompilationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(Java9Parser.Eof, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public PackageDeclarationContext packageDeclaration()
        {
            return GetRuleContext<PackageDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ImportDeclarationContext[] importDeclaration()
        {
            return GetRuleContexts<ImportDeclarationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ImportDeclarationContext importDeclaration(int i)
        {
            return GetRuleContext<ImportDeclarationContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeDeclarationContext[] typeDeclaration()
        {
            return GetRuleContexts<TypeDeclarationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeDeclarationContext typeDeclaration(int i)
        {
            return GetRuleContext<TypeDeclarationContext>(i);
        }
        public OrdinaryCompilationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_ordinaryCompilation; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterOrdinaryCompilation(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitOrdinaryCompilation(this);
        }
    }

    [RuleVersion(0)]
    public OrdinaryCompilationContext ordinaryCompilation()
    {
        OrdinaryCompilationContext _localctx = new OrdinaryCompilationContext(Context, State);
        EnterRule(_localctx, 66, RULE_ordinaryCompilation);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 747;
                ErrorHandler.Sync(this);
                switch (Interpreter.AdaptivePredict(TokenStream, 38, Context))
                {
                    case 1:
                        {
                            State = 746;
                            packageDeclaration();
                        }
                        break;
                }
                State = 752;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == IMPORT)
                {
                    {
                        {
                            State = 749;
                            importDeclaration();
                        }
                    }
                    State = 754;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 758;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << CLASS) | (1L << ENUM) | (1L << FINAL) | (1L << INTERFACE) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << STATIC) | (1L << STRICTFP))) != 0) || _la == SEMI || _la == AT)
                {
                    {
                        {
                            State = 755;
                            typeDeclaration();
                        }
                    }
                    State = 760;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 761;
                Match(Eof);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ModularCompilationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ModuleDeclarationContext moduleDeclaration()
        {
            return GetRuleContext<ModuleDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ImportDeclarationContext[] importDeclaration()
        {
            return GetRuleContexts<ImportDeclarationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ImportDeclarationContext importDeclaration(int i)
        {
            return GetRuleContext<ImportDeclarationContext>(i);
        }
        public ModularCompilationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_modularCompilation; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterModularCompilation(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitModularCompilation(this);
        }
    }

    [RuleVersion(0)]
    public ModularCompilationContext modularCompilation()
    {
        ModularCompilationContext _localctx = new ModularCompilationContext(Context, State);
        EnterRule(_localctx, 68, RULE_modularCompilation);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 766;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == IMPORT)
                {
                    {
                        {
                            State = 763;
                            importDeclaration();
                        }
                    }
                    State = 768;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 769;
                moduleDeclaration();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PackageDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PACKAGE() { return GetToken(Java9Parser.PACKAGE, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public PackageNameContext packageName()
        {
            return GetRuleContext<PackageNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public PackageModifierContext[] packageModifier()
        {
            return GetRuleContexts<PackageModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PackageModifierContext packageModifier(int i)
        {
            return GetRuleContext<PackageModifierContext>(i);
        }
        public PackageDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_packageDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPackageDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPackageDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public PackageDeclarationContext packageDeclaration()
    {
        PackageDeclarationContext _localctx = new PackageDeclarationContext(Context, State);
        EnterRule(_localctx, 70, RULE_packageDeclaration);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 774;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == AT)
                {
                    {
                        {
                            State = 771;
                            packageModifier();
                        }
                    }
                    State = 776;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 777;
                Match(PACKAGE);
                State = 778;
                packageName(0);
                State = 779;
                Match(SEMI);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PackageModifierContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation()
        {
            return GetRuleContext<AnnotationContext>(0);
        }
        public PackageModifierContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_packageModifier; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPackageModifier(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPackageModifier(this);
        }
    }

    [RuleVersion(0)]
    public PackageModifierContext packageModifier()
    {
        PackageModifierContext _localctx = new PackageModifierContext(Context, State);
        EnterRule(_localctx, 72, RULE_packageModifier);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 781;
                annotation();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ImportDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public SingleTypeImportDeclarationContext singleTypeImportDeclaration()
        {
            return GetRuleContext<SingleTypeImportDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeImportOnDemandDeclarationContext typeImportOnDemandDeclaration()
        {
            return GetRuleContext<TypeImportOnDemandDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public SingleStaticImportDeclarationContext singleStaticImportDeclaration()
        {
            return GetRuleContext<SingleStaticImportDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public StaticImportOnDemandDeclarationContext staticImportOnDemandDeclaration()
        {
            return GetRuleContext<StaticImportOnDemandDeclarationContext>(0);
        }
        public ImportDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_importDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterImportDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitImportDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public ImportDeclarationContext importDeclaration()
    {
        ImportDeclarationContext _localctx = new ImportDeclarationContext(Context, State);
        EnterRule(_localctx, 74, RULE_importDeclaration);
        try
        {
            State = 787;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 43, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 783;
                        singleTypeImportDeclaration();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 784;
                        typeImportOnDemandDeclaration();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 785;
                        singleStaticImportDeclaration();
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 786;
                        staticImportOnDemandDeclaration();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class SingleTypeImportDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IMPORT() { return GetToken(Java9Parser.IMPORT, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext typeName()
        {
            return GetRuleContext<TypeNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        public SingleTypeImportDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_singleTypeImportDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterSingleTypeImportDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitSingleTypeImportDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public SingleTypeImportDeclarationContext singleTypeImportDeclaration()
    {
        SingleTypeImportDeclarationContext _localctx = new SingleTypeImportDeclarationContext(Context, State);
        EnterRule(_localctx, 76, RULE_singleTypeImportDeclaration);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 789;
                Match(IMPORT);
                State = 790;
                typeName();
                State = 791;
                Match(SEMI);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class TypeImportOnDemandDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IMPORT() { return GetToken(Java9Parser.IMPORT, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public PackageOrTypeNameContext packageOrTypeName()
        {
            return GetRuleContext<PackageOrTypeNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MUL() { return GetToken(Java9Parser.MUL, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        public TypeImportOnDemandDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_typeImportOnDemandDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterTypeImportOnDemandDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitTypeImportOnDemandDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public TypeImportOnDemandDeclarationContext typeImportOnDemandDeclaration()
    {
        TypeImportOnDemandDeclarationContext _localctx = new TypeImportOnDemandDeclarationContext(Context, State);
        EnterRule(_localctx, 78, RULE_typeImportOnDemandDeclaration);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 793;
                Match(IMPORT);
                State = 794;
                packageOrTypeName(0);
                State = 795;
                Match(DOT);
                State = 796;
                Match(MUL);
                State = 797;
                Match(SEMI);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class SingleStaticImportDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IMPORT() { return GetToken(Java9Parser.IMPORT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java9Parser.STATIC, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext typeName()
        {
            return GetRuleContext<TypeNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        public SingleStaticImportDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_singleStaticImportDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterSingleStaticImportDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitSingleStaticImportDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public SingleStaticImportDeclarationContext singleStaticImportDeclaration()
    {
        SingleStaticImportDeclarationContext _localctx = new SingleStaticImportDeclarationContext(Context, State);
        EnterRule(_localctx, 80, RULE_singleStaticImportDeclaration);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 799;
                Match(IMPORT);
                State = 800;
                Match(STATIC);
                State = 801;
                typeName();
                State = 802;
                Match(DOT);
                State = 803;
                identifier();
                State = 804;
                Match(SEMI);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class StaticImportOnDemandDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IMPORT() { return GetToken(Java9Parser.IMPORT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java9Parser.STATIC, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext typeName()
        {
            return GetRuleContext<TypeNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MUL() { return GetToken(Java9Parser.MUL, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        public StaticImportOnDemandDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_staticImportOnDemandDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterStaticImportOnDemandDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitStaticImportOnDemandDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public StaticImportOnDemandDeclarationContext staticImportOnDemandDeclaration()
    {
        StaticImportOnDemandDeclarationContext _localctx = new StaticImportOnDemandDeclarationContext(Context, State);
        EnterRule(_localctx, 82, RULE_staticImportOnDemandDeclaration);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 806;
                Match(IMPORT);
                State = 807;
                Match(STATIC);
                State = 808;
                typeName();
                State = 809;
                Match(DOT);
                State = 810;
                Match(MUL);
                State = 811;
                Match(SEMI);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class TypeDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassDeclarationContext classDeclaration()
        {
            return GetRuleContext<ClassDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceDeclarationContext interfaceDeclaration()
        {
            return GetRuleContext<InterfaceDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        public TypeDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_typeDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterTypeDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitTypeDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public TypeDeclarationContext typeDeclaration()
    {
        TypeDeclarationContext _localctx = new TypeDeclarationContext(Context, State);
        EnterRule(_localctx, 84, RULE_typeDeclaration);
        try
        {
            State = 816;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 44, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 813;
                        classDeclaration();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 814;
                        interfaceDeclaration();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 815;
                        Match(SEMI);
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ModuleDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ModuleNameContext moduleName()
        {
            return GetRuleContext<ModuleNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java9Parser.LBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java9Parser.RBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext[] annotation()
        {
            return GetRuleContexts<AnnotationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation(int i)
        {
            return GetRuleContext<AnnotationContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ModuleDirectiveContext[] moduleDirective()
        {
            return GetRuleContexts<ModuleDirectiveContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ModuleDirectiveContext moduleDirective(int i)
        {
            return GetRuleContext<ModuleDirectiveContext>(i);
        }
        public ModuleDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_moduleDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterModuleDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitModuleDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public ModuleDeclarationContext moduleDeclaration()
    {
        ModuleDeclarationContext _localctx = new ModuleDeclarationContext(Context, State);
        EnterRule(_localctx, 86, RULE_moduleDeclaration);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 821;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == AT)
                {
                    {
                        {
                            State = 818;
                            annotation();
                        }
                    }
                    State = 823;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 825;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == T__0)
                {
                    {
                        State = 824;
                        Match(T__0);
                    }
                }

                State = 827;
                Match(T__1);
                State = 828;
                moduleName(0);
                State = 829;
                Match(LBRACE);
                State = 833;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << T__3) | (1L << T__5) | (1L << T__6) | (1L << T__7))) != 0))
                {
                    {
                        {
                            State = 830;
                            moduleDirective();
                        }
                    }
                    State = 835;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 836;
                Match(RBRACE);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ModuleDirectiveContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ModuleNameContext[] moduleName()
        {
            return GetRuleContexts<ModuleNameContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ModuleNameContext moduleName(int i)
        {
            return GetRuleContext<ModuleNameContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public RequiresModifierContext[] requiresModifier()
        {
            return GetRuleContexts<RequiresModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public RequiresModifierContext requiresModifier(int i)
        {
            return GetRuleContext<RequiresModifierContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PackageNameContext packageName()
        {
            return GetRuleContext<PackageNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java9Parser.COMMA); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode COMMA(int i)
        {
            return GetToken(Java9Parser.COMMA, i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext[] typeName()
        {
            return GetRuleContexts<TypeNameContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext typeName(int i)
        {
            return GetRuleContext<TypeNameContext>(i);
        }
        public ModuleDirectiveContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_moduleDirective; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterModuleDirective(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitModuleDirective(this);
        }
    }

    [RuleVersion(0)]
    public ModuleDirectiveContext moduleDirective()
    {
        ModuleDirectiveContext _localctx = new ModuleDirectiveContext(Context, State);
        EnterRule(_localctx, 88, RULE_moduleDirective);
        int _la;
        try
        {
            State = 895;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case T__2:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 838;
                        Match(T__2);
                        State = 842;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == T__9 || _la == STATIC)
                        {
                            {
                                {
                                    State = 839;
                                    requiresModifier();
                                }
                            }
                            State = 844;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 845;
                        moduleName(0);
                        State = 846;
                        Match(SEMI);
                    }
                    break;
                case T__3:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 848;
                        Match(T__3);
                        State = 849;
                        packageName(0);
                        State = 859;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == T__4)
                        {
                            {
                                State = 850;
                                Match(T__4);
                                State = 851;
                                moduleName(0);
                                State = 856;
                                ErrorHandler.Sync(this);
                                _la = TokenStream.LA(1);
                                while (_la == COMMA)
                                {
                                    {
                                        {
                                            State = 852;
                                            Match(COMMA);
                                            State = 853;
                                            moduleName(0);
                                        }
                                    }
                                    State = 858;
                                    ErrorHandler.Sync(this);
                                    _la = TokenStream.LA(1);
                                }
                            }
                        }

                        State = 861;
                        Match(SEMI);
                    }
                    break;
                case T__5:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 863;
                        Match(T__5);
                        State = 864;
                        packageName(0);
                        State = 874;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == T__4)
                        {
                            {
                                State = 865;
                                Match(T__4);
                                State = 866;
                                moduleName(0);
                                State = 871;
                                ErrorHandler.Sync(this);
                                _la = TokenStream.LA(1);
                                while (_la == COMMA)
                                {
                                    {
                                        {
                                            State = 867;
                                            Match(COMMA);
                                            State = 868;
                                            moduleName(0);
                                        }
                                    }
                                    State = 873;
                                    ErrorHandler.Sync(this);
                                    _la = TokenStream.LA(1);
                                }
                            }
                        }

                        State = 876;
                        Match(SEMI);
                    }
                    break;
                case T__6:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 878;
                        Match(T__6);
                        State = 879;
                        typeName();
                        State = 880;
                        Match(SEMI);
                    }
                    break;
                case T__7:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 882;
                        Match(T__7);
                        State = 883;
                        typeName();
                        State = 884;
                        Match(T__8);
                        State = 885;
                        typeName();
                        State = 890;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == COMMA)
                        {
                            {
                                {
                                    State = 886;
                                    Match(COMMA);
                                    State = 887;
                                    typeName();
                                }
                            }
                            State = 892;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 893;
                        Match(SEMI);
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class RequiresModifierContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java9Parser.STATIC, 0); }
        public RequiresModifierContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_requiresModifier; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterRequiresModifier(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitRequiresModifier(this);
        }
    }

    [RuleVersion(0)]
    public RequiresModifierContext requiresModifier()
    {
        RequiresModifierContext _localctx = new RequiresModifierContext(Context, State);
        EnterRule(_localctx, 90, RULE_requiresModifier);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 897;
                _la = TokenStream.LA(1);
                if (!(_la == T__9 || _la == STATIC))
                {
                    ErrorHandler.RecoverInline(this);
                }
                else
                {
                    ErrorHandler.ReportMatch(this);
                    Consume();
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ClassDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public NormalClassDeclarationContext normalClassDeclaration()
        {
            return GetRuleContext<NormalClassDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public EnumDeclarationContext enumDeclaration()
        {
            return GetRuleContext<EnumDeclarationContext>(0);
        }
        public ClassDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_classDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterClassDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitClassDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public ClassDeclarationContext classDeclaration()
    {
        ClassDeclarationContext _localctx = new ClassDeclarationContext(Context, State);
        EnterRule(_localctx, 92, RULE_classDeclaration);
        try
        {
            State = 901;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 55, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 899;
                        normalClassDeclaration();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 900;
                        enumDeclaration();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class NormalClassDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLASS() { return GetToken(Java9Parser.CLASS, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassBodyContext classBody()
        {
            return GetRuleContext<ClassBodyContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassModifierContext[] classModifier()
        {
            return GetRuleContexts<ClassModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassModifierContext classModifier(int i)
        {
            return GetRuleContext<ClassModifierContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeParametersContext typeParameters()
        {
            return GetRuleContext<TypeParametersContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public SuperclassContext superclass()
        {
            return GetRuleContext<SuperclassContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public SuperinterfacesContext superinterfaces()
        {
            return GetRuleContext<SuperinterfacesContext>(0);
        }
        public NormalClassDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_normalClassDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterNormalClassDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitNormalClassDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public NormalClassDeclarationContext normalClassDeclaration()
    {
        NormalClassDeclarationContext _localctx = new NormalClassDeclarationContext(Context, State);
        EnterRule(_localctx, 94, RULE_normalClassDeclaration);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 906;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << FINAL) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << STATIC) | (1L << STRICTFP))) != 0) || _la == AT)
                {
                    {
                        {
                            State = 903;
                            classModifier();
                        }
                    }
                    State = 908;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 909;
                Match(CLASS);
                State = 910;
                identifier();
                State = 912;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == LT)
                {
                    {
                        State = 911;
                        typeParameters();
                    }
                }

                State = 915;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == EXTENDS)
                {
                    {
                        State = 914;
                        superclass();
                    }
                }

                State = 918;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == IMPLEMENTS)
                {
                    {
                        State = 917;
                        superinterfaces();
                    }
                }

                State = 920;
                classBody();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ClassModifierContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation()
        {
            return GetRuleContext<AnnotationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLIC() { return GetToken(Java9Parser.PUBLIC, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PROTECTED() { return GetToken(Java9Parser.PROTECTED, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRIVATE() { return GetToken(Java9Parser.PRIVATE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ABSTRACT() { return GetToken(Java9Parser.ABSTRACT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java9Parser.STATIC, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FINAL() { return GetToken(Java9Parser.FINAL, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRICTFP() { return GetToken(Java9Parser.STRICTFP, 0); }
        public ClassModifierContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_classModifier; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterClassModifier(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitClassModifier(this);
        }
    }

    [RuleVersion(0)]
    public ClassModifierContext classModifier()
    {
        ClassModifierContext _localctx = new ClassModifierContext(Context, State);
        EnterRule(_localctx, 96, RULE_classModifier);
        try
        {
            State = 930;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case AT:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 922;
                        annotation();
                    }
                    break;
                case PUBLIC:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 923;
                        Match(PUBLIC);
                    }
                    break;
                case PROTECTED:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 924;
                        Match(PROTECTED);
                    }
                    break;
                case PRIVATE:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 925;
                        Match(PRIVATE);
                    }
                    break;
                case ABSTRACT:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 926;
                        Match(ABSTRACT);
                    }
                    break;
                case STATIC:
                    EnterOuterAlt(_localctx, 6);
                    {
                        State = 927;
                        Match(STATIC);
                    }
                    break;
                case FINAL:
                    EnterOuterAlt(_localctx, 7);
                    {
                        State = 928;
                        Match(FINAL);
                    }
                    break;
                case STRICTFP:
                    EnterOuterAlt(_localctx, 8);
                    {
                        State = 929;
                        Match(STRICTFP);
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class TypeParametersContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LT() { return GetToken(Java9Parser.LT, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeParameterListContext typeParameterList()
        {
            return GetRuleContext<TypeParameterListContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT() { return GetToken(Java9Parser.GT, 0); }
        public TypeParametersContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_typeParameters; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterTypeParameters(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitTypeParameters(this);
        }
    }

    [RuleVersion(0)]
    public TypeParametersContext typeParameters()
    {
        TypeParametersContext _localctx = new TypeParametersContext(Context, State);
        EnterRule(_localctx, 98, RULE_typeParameters);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 932;
                Match(LT);
                State = 933;
                typeParameterList();
                State = 934;
                Match(GT);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class TypeParameterListContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeParameterContext[] typeParameter()
        {
            return GetRuleContexts<TypeParameterContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeParameterContext typeParameter(int i)
        {
            return GetRuleContext<TypeParameterContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java9Parser.COMMA); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode COMMA(int i)
        {
            return GetToken(Java9Parser.COMMA, i);
        }
        public TypeParameterListContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_typeParameterList; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterTypeParameterList(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitTypeParameterList(this);
        }
    }

    [RuleVersion(0)]
    public TypeParameterListContext typeParameterList()
    {
        TypeParameterListContext _localctx = new TypeParameterListContext(Context, State);
        EnterRule(_localctx, 100, RULE_typeParameterList);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 936;
                typeParameter();
                State = 941;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == COMMA)
                {
                    {
                        {
                            State = 937;
                            Match(COMMA);
                            State = 938;
                            typeParameter();
                        }
                    }
                    State = 943;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class SuperclassContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXTENDS() { return GetToken(Java9Parser.EXTENDS, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassTypeContext classType()
        {
            return GetRuleContext<ClassTypeContext>(0);
        }
        public SuperclassContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_superclass; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterSuperclass(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitSuperclass(this);
        }
    }

    [RuleVersion(0)]
    public SuperclassContext superclass()
    {
        SuperclassContext _localctx = new SuperclassContext(Context, State);
        EnterRule(_localctx, 102, RULE_superclass);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 944;
                Match(EXTENDS);
                State = 945;
                classType();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class SuperinterfacesContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IMPLEMENTS() { return GetToken(Java9Parser.IMPLEMENTS, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceTypeListContext interfaceTypeList()
        {
            return GetRuleContext<InterfaceTypeListContext>(0);
        }
        public SuperinterfacesContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_superinterfaces; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterSuperinterfaces(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitSuperinterfaces(this);
        }
    }

    [RuleVersion(0)]
    public SuperinterfacesContext superinterfaces()
    {
        SuperinterfacesContext _localctx = new SuperinterfacesContext(Context, State);
        EnterRule(_localctx, 104, RULE_superinterfaces);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 947;
                Match(IMPLEMENTS);
                State = 948;
                interfaceTypeList();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class InterfaceTypeListContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceTypeContext[] interfaceType()
        {
            return GetRuleContexts<InterfaceTypeContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceTypeContext interfaceType(int i)
        {
            return GetRuleContext<InterfaceTypeContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java9Parser.COMMA); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode COMMA(int i)
        {
            return GetToken(Java9Parser.COMMA, i);
        }
        public InterfaceTypeListContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_interfaceTypeList; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterInterfaceTypeList(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitInterfaceTypeList(this);
        }
    }

    [RuleVersion(0)]
    public InterfaceTypeListContext interfaceTypeList()
    {
        InterfaceTypeListContext _localctx = new InterfaceTypeListContext(Context, State);
        EnterRule(_localctx, 106, RULE_interfaceTypeList);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 950;
                interfaceType();
                State = 955;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == COMMA)
                {
                    {
                        {
                            State = 951;
                            Match(COMMA);
                            State = 952;
                            interfaceType();
                        }
                    }
                    State = 957;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ClassBodyContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java9Parser.LBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java9Parser.RBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassBodyDeclarationContext[] classBodyDeclaration()
        {
            return GetRuleContexts<ClassBodyDeclarationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassBodyDeclarationContext classBodyDeclaration(int i)
        {
            return GetRuleContext<ClassBodyDeclarationContext>(i);
        }
        public ClassBodyContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_classBody; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterClassBody(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitClassBody(this);
        }
    }

    [RuleVersion(0)]
    public ClassBodyContext classBody()
    {
        ClassBodyContext _localctx = new ClassBodyContext(Context, State);
        EnterRule(_localctx, 108, RULE_classBody);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 958;
                Match(LBRACE);
                State = 962;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << ABSTRACT) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << CLASS) | (1L << DOUBLE) | (1L << ENUM) | (1L << FINAL) | (1L << FLOAT) | (1L << INT) | (1L << INTERFACE) | (1L << LONG) | (1L << NATIVE) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << SHORT) | (1L << STATIC) | (1L << STRICTFP) | (1L << SYNCHRONIZED) | (1L << TRANSIENT) | (1L << VOID) | (1L << VOLATILE))) != 0) || ((((_la - 70)) & ~0x3f) == 0 && ((1L << (_la - 70)) & ((1L << (LBRACE - 70)) | (1L << (SEMI - 70)) | (1L << (AT - 70)) | (1L << (LT - 70)) | (1L << (Identifier - 70)))) != 0))
                {
                    {
                        {
                            State = 959;
                            classBodyDeclaration();
                        }
                    }
                    State = 964;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 965;
                Match(RBRACE);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ClassBodyDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassMemberDeclarationContext classMemberDeclaration()
        {
            return GetRuleContext<ClassMemberDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InstanceInitializerContext instanceInitializer()
        {
            return GetRuleContext<InstanceInitializerContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public StaticInitializerContext staticInitializer()
        {
            return GetRuleContext<StaticInitializerContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ConstructorDeclarationContext constructorDeclaration()
        {
            return GetRuleContext<ConstructorDeclarationContext>(0);
        }
        public ClassBodyDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_classBodyDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterClassBodyDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitClassBodyDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public ClassBodyDeclarationContext classBodyDeclaration()
    {
        ClassBodyDeclarationContext _localctx = new ClassBodyDeclarationContext(Context, State);
        EnterRule(_localctx, 110, RULE_classBodyDeclaration);
        try
        {
            State = 971;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 64, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 967;
                        classMemberDeclaration();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 968;
                        instanceInitializer();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 969;
                        staticInitializer();
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 970;
                        constructorDeclaration();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ClassMemberDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public FieldDeclarationContext fieldDeclaration()
        {
            return GetRuleContext<FieldDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodDeclarationContext methodDeclaration()
        {
            return GetRuleContext<MethodDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassDeclarationContext classDeclaration()
        {
            return GetRuleContext<ClassDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceDeclarationContext interfaceDeclaration()
        {
            return GetRuleContext<InterfaceDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        public ClassMemberDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_classMemberDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterClassMemberDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitClassMemberDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public ClassMemberDeclarationContext classMemberDeclaration()
    {
        ClassMemberDeclarationContext _localctx = new ClassMemberDeclarationContext(Context, State);
        EnterRule(_localctx, 112, RULE_classMemberDeclaration);
        try
        {
            State = 978;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 65, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 973;
                        fieldDeclaration();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 974;
                        methodDeclaration();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 975;
                        classDeclaration();
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 976;
                        interfaceDeclaration();
                    }
                    break;
                case 5:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 977;
                        Match(SEMI);
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class FieldDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannTypeContext unannType()
        {
            return GetRuleContext<UnannTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableDeclaratorListContext variableDeclaratorList()
        {
            return GetRuleContext<VariableDeclaratorListContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public FieldModifierContext[] fieldModifier()
        {
            return GetRuleContexts<FieldModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public FieldModifierContext fieldModifier(int i)
        {
            return GetRuleContext<FieldModifierContext>(i);
        }
        public FieldDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_fieldDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterFieldDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitFieldDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public FieldDeclarationContext fieldDeclaration()
    {
        FieldDeclarationContext _localctx = new FieldDeclarationContext(Context, State);
        EnterRule(_localctx, 114, RULE_fieldDeclaration);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 983;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (((((_la - 28)) & ~0x3f) == 0 && ((1L << (_la - 28)) & ((1L << (FINAL - 28)) | (1L << (PRIVATE - 28)) | (1L << (PROTECTED - 28)) | (1L << (PUBLIC - 28)) | (1L << (STATIC - 28)) | (1L << (TRANSIENT - 28)) | (1L << (VOLATILE - 28)) | (1L << (AT - 28)))) != 0))
                {
                    {
                        {
                            State = 980;
                            fieldModifier();
                        }
                    }
                    State = 985;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 986;
                unannType();
                State = 987;
                variableDeclaratorList();
                State = 988;
                Match(SEMI);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class FieldModifierContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation()
        {
            return GetRuleContext<AnnotationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLIC() { return GetToken(Java9Parser.PUBLIC, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PROTECTED() { return GetToken(Java9Parser.PROTECTED, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRIVATE() { return GetToken(Java9Parser.PRIVATE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java9Parser.STATIC, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FINAL() { return GetToken(Java9Parser.FINAL, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRANSIENT() { return GetToken(Java9Parser.TRANSIENT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOLATILE() { return GetToken(Java9Parser.VOLATILE, 0); }
        public FieldModifierContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_fieldModifier; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterFieldModifier(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitFieldModifier(this);
        }
    }

    [RuleVersion(0)]
    public FieldModifierContext fieldModifier()
    {
        FieldModifierContext _localctx = new FieldModifierContext(Context, State);
        EnterRule(_localctx, 116, RULE_fieldModifier);
        try
        {
            State = 998;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case AT:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 990;
                        annotation();
                    }
                    break;
                case PUBLIC:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 991;
                        Match(PUBLIC);
                    }
                    break;
                case PROTECTED:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 992;
                        Match(PROTECTED);
                    }
                    break;
                case PRIVATE:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 993;
                        Match(PRIVATE);
                    }
                    break;
                case STATIC:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 994;
                        Match(STATIC);
                    }
                    break;
                case FINAL:
                    EnterOuterAlt(_localctx, 6);
                    {
                        State = 995;
                        Match(FINAL);
                    }
                    break;
                case TRANSIENT:
                    EnterOuterAlt(_localctx, 7);
                    {
                        State = 996;
                        Match(TRANSIENT);
                    }
                    break;
                case VOLATILE:
                    EnterOuterAlt(_localctx, 8);
                    {
                        State = 997;
                        Match(VOLATILE);
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class VariableDeclaratorListContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableDeclaratorContext[] variableDeclarator()
        {
            return GetRuleContexts<VariableDeclaratorContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableDeclaratorContext variableDeclarator(int i)
        {
            return GetRuleContext<VariableDeclaratorContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java9Parser.COMMA); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode COMMA(int i)
        {
            return GetToken(Java9Parser.COMMA, i);
        }
        public VariableDeclaratorListContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_variableDeclaratorList; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterVariableDeclaratorList(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitVariableDeclaratorList(this);
        }
    }

    [RuleVersion(0)]
    public VariableDeclaratorListContext variableDeclaratorList()
    {
        VariableDeclaratorListContext _localctx = new VariableDeclaratorListContext(Context, State);
        EnterRule(_localctx, 118, RULE_variableDeclaratorList);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1000;
                variableDeclarator();
                State = 1005;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == COMMA)
                {
                    {
                        {
                            State = 1001;
                            Match(COMMA);
                            State = 1002;
                            variableDeclarator();
                        }
                    }
                    State = 1007;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class VariableDeclaratorContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableDeclaratorIdContext variableDeclaratorId()
        {
            return GetRuleContext<VariableDeclaratorIdContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGN() { return GetToken(Java9Parser.ASSIGN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableInitializerContext variableInitializer()
        {
            return GetRuleContext<VariableInitializerContext>(0);
        }
        public VariableDeclaratorContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_variableDeclarator; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterVariableDeclarator(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitVariableDeclarator(this);
        }
    }

    [RuleVersion(0)]
    public VariableDeclaratorContext variableDeclarator()
    {
        VariableDeclaratorContext _localctx = new VariableDeclaratorContext(Context, State);
        EnterRule(_localctx, 120, RULE_variableDeclarator);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1008;
                variableDeclaratorId();
                State = 1011;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == ASSIGN)
                {
                    {
                        State = 1009;
                        Match(ASSIGN);
                        State = 1010;
                        variableInitializer();
                    }
                }

            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class VariableDeclaratorIdContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public DimsContext dims()
        {
            return GetRuleContext<DimsContext>(0);
        }
        public VariableDeclaratorIdContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_variableDeclaratorId; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterVariableDeclaratorId(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitVariableDeclaratorId(this);
        }
    }

    [RuleVersion(0)]
    public VariableDeclaratorIdContext variableDeclaratorId()
    {
        VariableDeclaratorIdContext _localctx = new VariableDeclaratorIdContext(Context, State);
        EnterRule(_localctx, 122, RULE_variableDeclaratorId);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1013;
                identifier();
                State = 1015;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == LBRACK || _la == AT)
                {
                    {
                        State = 1014;
                        dims();
                    }
                }

            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class VariableInitializerContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ArrayInitializerContext arrayInitializer()
        {
            return GetRuleContext<ArrayInitializerContext>(0);
        }
        public VariableInitializerContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_variableInitializer; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterVariableInitializer(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitVariableInitializer(this);
        }
    }

    [RuleVersion(0)]
    public VariableInitializerContext variableInitializer()
    {
        VariableInitializerContext _localctx = new VariableInitializerContext(Context, State);
        EnterRule(_localctx, 124, RULE_variableInitializer);
        try
        {
            State = 1019;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case T__0:
                case T__1:
                case T__2:
                case T__3:
                case T__4:
                case T__5:
                case T__6:
                case T__7:
                case T__8:
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
                case AT:
                case BANG:
                case TILDE:
                case INC:
                case DEC:
                case ADD:
                case SUB:
                case Identifier:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1017;
                        expression();
                    }
                    break;
                case LBRACE:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1018;
                        arrayInitializer();
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class UnannTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannPrimitiveTypeContext unannPrimitiveType()
        {
            return GetRuleContext<UnannPrimitiveTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannReferenceTypeContext unannReferenceType()
        {
            return GetRuleContext<UnannReferenceTypeContext>(0);
        }
        public UnannTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_unannType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterUnannType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitUnannType(this);
        }
    }

    [RuleVersion(0)]
    public UnannTypeContext unannType()
    {
        UnannTypeContext _localctx = new UnannTypeContext(Context, State);
        EnterRule(_localctx, 126, RULE_unannType);
        try
        {
            State = 1023;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 72, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1021;
                        unannPrimitiveType();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1022;
                        unannReferenceType();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class UnannPrimitiveTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public NumericTypeContext numericType()
        {
            return GetRuleContext<NumericTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BOOLEAN() { return GetToken(Java9Parser.BOOLEAN, 0); }
        public UnannPrimitiveTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_unannPrimitiveType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterUnannPrimitiveType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitUnannPrimitiveType(this);
        }
    }

    [RuleVersion(0)]
    public UnannPrimitiveTypeContext unannPrimitiveType()
    {
        UnannPrimitiveTypeContext _localctx = new UnannPrimitiveTypeContext(Context, State);
        EnterRule(_localctx, 128, RULE_unannPrimitiveType);
        try
        {
            State = 1027;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case BYTE:
                case CHAR:
                case DOUBLE:
                case FLOAT:
                case INT:
                case LONG:
                case SHORT:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1025;
                        numericType();
                    }
                    break;
                case BOOLEAN:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1026;
                        Match(BOOLEAN);
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class UnannReferenceTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannClassOrInterfaceTypeContext unannClassOrInterfaceType()
        {
            return GetRuleContext<UnannClassOrInterfaceTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannTypeVariableContext unannTypeVariable()
        {
            return GetRuleContext<UnannTypeVariableContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannArrayTypeContext unannArrayType()
        {
            return GetRuleContext<UnannArrayTypeContext>(0);
        }
        public UnannReferenceTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_unannReferenceType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterUnannReferenceType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitUnannReferenceType(this);
        }
    }

    [RuleVersion(0)]
    public UnannReferenceTypeContext unannReferenceType()
    {
        UnannReferenceTypeContext _localctx = new UnannReferenceTypeContext(Context, State);
        EnterRule(_localctx, 130, RULE_unannReferenceType);
        try
        {
            State = 1032;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 74, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1029;
                        unannClassOrInterfaceType();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1030;
                        unannTypeVariable();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1031;
                        unannArrayType();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class UnannClassOrInterfaceTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannClassType_lfno_unannClassOrInterfaceTypeContext unannClassType_lfno_unannClassOrInterfaceType()
        {
            return GetRuleContext<UnannClassType_lfno_unannClassOrInterfaceTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext unannInterfaceType_lfno_unannClassOrInterfaceType()
        {
            return GetRuleContext<UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannClassType_lf_unannClassOrInterfaceTypeContext[] unannClassType_lf_unannClassOrInterfaceType()
        {
            return GetRuleContexts<UnannClassType_lf_unannClassOrInterfaceTypeContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannClassType_lf_unannClassOrInterfaceTypeContext unannClassType_lf_unannClassOrInterfaceType(int i)
        {
            return GetRuleContext<UnannClassType_lf_unannClassOrInterfaceTypeContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannInterfaceType_lf_unannClassOrInterfaceTypeContext[] unannInterfaceType_lf_unannClassOrInterfaceType()
        {
            return GetRuleContexts<UnannInterfaceType_lf_unannClassOrInterfaceTypeContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannInterfaceType_lf_unannClassOrInterfaceTypeContext unannInterfaceType_lf_unannClassOrInterfaceType(int i)
        {
            return GetRuleContext<UnannInterfaceType_lf_unannClassOrInterfaceTypeContext>(i);
        }
        public UnannClassOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_unannClassOrInterfaceType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterUnannClassOrInterfaceType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitUnannClassOrInterfaceType(this);
        }
    }

    [RuleVersion(0)]
    public UnannClassOrInterfaceTypeContext unannClassOrInterfaceType()
    {
        UnannClassOrInterfaceTypeContext _localctx = new UnannClassOrInterfaceTypeContext(Context, State);
        EnterRule(_localctx, 132, RULE_unannClassOrInterfaceType);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                State = 1036;
                ErrorHandler.Sync(this);
                switch (Interpreter.AdaptivePredict(TokenStream, 75, Context))
                {
                    case 1:
                        {
                            State = 1034;
                            unannClassType_lfno_unannClassOrInterfaceType();
                        }
                        break;
                    case 2:
                        {
                            State = 1035;
                            unannInterfaceType_lfno_unannClassOrInterfaceType();
                        }
                        break;
                }
                State = 1042;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 77, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        {
                            State = 1040;
                            ErrorHandler.Sync(this);
                            switch (Interpreter.AdaptivePredict(TokenStream, 76, Context))
                            {
                                case 1:
                                    {
                                        State = 1038;
                                        unannClassType_lf_unannClassOrInterfaceType();
                                    }
                                    break;
                                case 2:
                                    {
                                        State = 1039;
                                        unannInterfaceType_lf_unannClassOrInterfaceType();
                                    }
                                    break;
                            }
                        }
                    }
                    State = 1044;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 77, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class UnannClassTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsContext typeArguments()
        {
            return GetRuleContext<TypeArgumentsContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannClassOrInterfaceTypeContext unannClassOrInterfaceType()
        {
            return GetRuleContext<UnannClassOrInterfaceTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext[] annotation()
        {
            return GetRuleContexts<AnnotationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation(int i)
        {
            return GetRuleContext<AnnotationContext>(i);
        }
        public UnannClassTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_unannClassType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterUnannClassType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitUnannClassType(this);
        }
    }

    [RuleVersion(0)]
    public UnannClassTypeContext unannClassType()
    {
        UnannClassTypeContext _localctx = new UnannClassTypeContext(Context, State);
        EnterRule(_localctx, 134, RULE_unannClassType);
        int _la;
        try
        {
            State = 1061;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 81, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1045;
                        identifier();
                        State = 1047;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 1046;
                                typeArguments();
                            }
                        }

                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1049;
                        unannClassOrInterfaceType();
                        State = 1050;
                        Match(DOT);
                        State = 1054;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == AT)
                        {
                            {
                                {
                                    State = 1051;
                                    annotation();
                                }
                            }
                            State = 1056;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 1057;
                        identifier();
                        State = 1059;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 1058;
                                typeArguments();
                            }
                        }

                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class UnannClassType_lf_unannClassOrInterfaceTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext[] annotation()
        {
            return GetRuleContexts<AnnotationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation(int i)
        {
            return GetRuleContext<AnnotationContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsContext typeArguments()
        {
            return GetRuleContext<TypeArgumentsContext>(0);
        }
        public UnannClassType_lf_unannClassOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_unannClassType_lf_unannClassOrInterfaceType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterUnannClassType_lf_unannClassOrInterfaceType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitUnannClassType_lf_unannClassOrInterfaceType(this);
        }
    }

    [RuleVersion(0)]
    public UnannClassType_lf_unannClassOrInterfaceTypeContext unannClassType_lf_unannClassOrInterfaceType()
    {
        UnannClassType_lf_unannClassOrInterfaceTypeContext _localctx = new UnannClassType_lf_unannClassOrInterfaceTypeContext(Context, State);
        EnterRule(_localctx, 136, RULE_unannClassType_lf_unannClassOrInterfaceType);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1063;
                Match(DOT);
                State = 1067;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == AT)
                {
                    {
                        {
                            State = 1064;
                            annotation();
                        }
                    }
                    State = 1069;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 1070;
                identifier();
                State = 1072;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == LT)
                {
                    {
                        State = 1071;
                        typeArguments();
                    }
                }

            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class UnannClassType_lfno_unannClassOrInterfaceTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsContext typeArguments()
        {
            return GetRuleContext<TypeArgumentsContext>(0);
        }
        public UnannClassType_lfno_unannClassOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_unannClassType_lfno_unannClassOrInterfaceType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterUnannClassType_lfno_unannClassOrInterfaceType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitUnannClassType_lfno_unannClassOrInterfaceType(this);
        }
    }

    [RuleVersion(0)]
    public UnannClassType_lfno_unannClassOrInterfaceTypeContext unannClassType_lfno_unannClassOrInterfaceType()
    {
        UnannClassType_lfno_unannClassOrInterfaceTypeContext _localctx = new UnannClassType_lfno_unannClassOrInterfaceTypeContext(Context, State);
        EnterRule(_localctx, 138, RULE_unannClassType_lfno_unannClassOrInterfaceType);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1074;
                identifier();
                State = 1076;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == LT)
                {
                    {
                        State = 1075;
                        typeArguments();
                    }
                }

            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class UnannInterfaceTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannClassTypeContext unannClassType()
        {
            return GetRuleContext<UnannClassTypeContext>(0);
        }
        public UnannInterfaceTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_unannInterfaceType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterUnannInterfaceType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitUnannInterfaceType(this);
        }
    }

    [RuleVersion(0)]
    public UnannInterfaceTypeContext unannInterfaceType()
    {
        UnannInterfaceTypeContext _localctx = new UnannInterfaceTypeContext(Context, State);
        EnterRule(_localctx, 140, RULE_unannInterfaceType);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1078;
                unannClassType();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class UnannInterfaceType_lf_unannClassOrInterfaceTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannClassType_lf_unannClassOrInterfaceTypeContext unannClassType_lf_unannClassOrInterfaceType()
        {
            return GetRuleContext<UnannClassType_lf_unannClassOrInterfaceTypeContext>(0);
        }
        public UnannInterfaceType_lf_unannClassOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_unannInterfaceType_lf_unannClassOrInterfaceType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterUnannInterfaceType_lf_unannClassOrInterfaceType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitUnannInterfaceType_lf_unannClassOrInterfaceType(this);
        }
    }

    [RuleVersion(0)]
    public UnannInterfaceType_lf_unannClassOrInterfaceTypeContext unannInterfaceType_lf_unannClassOrInterfaceType()
    {
        UnannInterfaceType_lf_unannClassOrInterfaceTypeContext _localctx = new UnannInterfaceType_lf_unannClassOrInterfaceTypeContext(Context, State);
        EnterRule(_localctx, 142, RULE_unannInterfaceType_lf_unannClassOrInterfaceType);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1080;
                unannClassType_lf_unannClassOrInterfaceType();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannClassType_lfno_unannClassOrInterfaceTypeContext unannClassType_lfno_unannClassOrInterfaceType()
        {
            return GetRuleContext<UnannClassType_lfno_unannClassOrInterfaceTypeContext>(0);
        }
        public UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_unannInterfaceType_lfno_unannClassOrInterfaceType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterUnannInterfaceType_lfno_unannClassOrInterfaceType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitUnannInterfaceType_lfno_unannClassOrInterfaceType(this);
        }
    }

    [RuleVersion(0)]
    public UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext unannInterfaceType_lfno_unannClassOrInterfaceType()
    {
        UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext _localctx = new UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext(Context, State);
        EnterRule(_localctx, 144, RULE_unannInterfaceType_lfno_unannClassOrInterfaceType);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1082;
                unannClassType_lfno_unannClassOrInterfaceType();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class UnannTypeVariableContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        public UnannTypeVariableContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_unannTypeVariable; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterUnannTypeVariable(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitUnannTypeVariable(this);
        }
    }

    [RuleVersion(0)]
    public UnannTypeVariableContext unannTypeVariable()
    {
        UnannTypeVariableContext _localctx = new UnannTypeVariableContext(Context, State);
        EnterRule(_localctx, 146, RULE_unannTypeVariable);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1084;
                identifier();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class UnannArrayTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannPrimitiveTypeContext unannPrimitiveType()
        {
            return GetRuleContext<UnannPrimitiveTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public DimsContext dims()
        {
            return GetRuleContext<DimsContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannClassOrInterfaceTypeContext unannClassOrInterfaceType()
        {
            return GetRuleContext<UnannClassOrInterfaceTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannTypeVariableContext unannTypeVariable()
        {
            return GetRuleContext<UnannTypeVariableContext>(0);
        }
        public UnannArrayTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_unannArrayType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterUnannArrayType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitUnannArrayType(this);
        }
    }

    [RuleVersion(0)]
    public UnannArrayTypeContext unannArrayType()
    {
        UnannArrayTypeContext _localctx = new UnannArrayTypeContext(Context, State);
        EnterRule(_localctx, 148, RULE_unannArrayType);
        try
        {
            State = 1095;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 85, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1086;
                        unannPrimitiveType();
                        State = 1087;
                        dims();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1089;
                        unannClassOrInterfaceType();
                        State = 1090;
                        dims();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1092;
                        unannTypeVariable();
                        State = 1093;
                        dims();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class MethodDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodHeaderContext methodHeader()
        {
            return GetRuleContext<MethodHeaderContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodBodyContext methodBody()
        {
            return GetRuleContext<MethodBodyContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodModifierContext[] methodModifier()
        {
            return GetRuleContexts<MethodModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodModifierContext methodModifier(int i)
        {
            return GetRuleContext<MethodModifierContext>(i);
        }
        public MethodDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_methodDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterMethodDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitMethodDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public MethodDeclarationContext methodDeclaration()
    {
        MethodDeclarationContext _localctx = new MethodDeclarationContext(Context, State);
        EnterRule(_localctx, 150, RULE_methodDeclaration);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1100;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << FINAL) | (1L << NATIVE) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << STATIC) | (1L << STRICTFP) | (1L << SYNCHRONIZED))) != 0) || _la == AT)
                {
                    {
                        {
                            State = 1097;
                            methodModifier();
                        }
                    }
                    State = 1102;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 1103;
                methodHeader();
                State = 1104;
                methodBody();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class MethodModifierContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation()
        {
            return GetRuleContext<AnnotationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLIC() { return GetToken(Java9Parser.PUBLIC, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PROTECTED() { return GetToken(Java9Parser.PROTECTED, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRIVATE() { return GetToken(Java9Parser.PRIVATE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ABSTRACT() { return GetToken(Java9Parser.ABSTRACT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java9Parser.STATIC, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FINAL() { return GetToken(Java9Parser.FINAL, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SYNCHRONIZED() { return GetToken(Java9Parser.SYNCHRONIZED, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NATIVE() { return GetToken(Java9Parser.NATIVE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRICTFP() { return GetToken(Java9Parser.STRICTFP, 0); }
        public MethodModifierContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_methodModifier; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterMethodModifier(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitMethodModifier(this);
        }
    }

    [RuleVersion(0)]
    public MethodModifierContext methodModifier()
    {
        MethodModifierContext _localctx = new MethodModifierContext(Context, State);
        EnterRule(_localctx, 152, RULE_methodModifier);
        try
        {
            State = 1116;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case AT:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1106;
                        annotation();
                    }
                    break;
                case PUBLIC:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1107;
                        Match(PUBLIC);
                    }
                    break;
                case PROTECTED:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1108;
                        Match(PROTECTED);
                    }
                    break;
                case PRIVATE:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 1109;
                        Match(PRIVATE);
                    }
                    break;
                case ABSTRACT:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 1110;
                        Match(ABSTRACT);
                    }
                    break;
                case STATIC:
                    EnterOuterAlt(_localctx, 6);
                    {
                        State = 1111;
                        Match(STATIC);
                    }
                    break;
                case FINAL:
                    EnterOuterAlt(_localctx, 7);
                    {
                        State = 1112;
                        Match(FINAL);
                    }
                    break;
                case SYNCHRONIZED:
                    EnterOuterAlt(_localctx, 8);
                    {
                        State = 1113;
                        Match(SYNCHRONIZED);
                    }
                    break;
                case NATIVE:
                    EnterOuterAlt(_localctx, 9);
                    {
                        State = 1114;
                        Match(NATIVE);
                    }
                    break;
                case STRICTFP:
                    EnterOuterAlt(_localctx, 10);
                    {
                        State = 1115;
                        Match(STRICTFP);
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class MethodHeaderContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ResultContext result()
        {
            return GetRuleContext<ResultContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodDeclaratorContext methodDeclarator()
        {
            return GetRuleContext<MethodDeclaratorContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public Throws_Context throws_()
        {
            return GetRuleContext<Throws_Context>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeParametersContext typeParameters()
        {
            return GetRuleContext<TypeParametersContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext[] annotation()
        {
            return GetRuleContexts<AnnotationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation(int i)
        {
            return GetRuleContext<AnnotationContext>(i);
        }
        public MethodHeaderContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_methodHeader; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterMethodHeader(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitMethodHeader(this);
        }
    }

    [RuleVersion(0)]
    public MethodHeaderContext methodHeader()
    {
        MethodHeaderContext _localctx = new MethodHeaderContext(Context, State);
        EnterRule(_localctx, 154, RULE_methodHeader);
        int _la;
        try
        {
            State = 1135;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case T__0:
                case T__1:
                case T__2:
                case T__3:
                case T__4:
                case T__5:
                case T__6:
                case T__7:
                case T__8:
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
                        State = 1118;
                        result();
                        State = 1119;
                        methodDeclarator();
                        State = 1121;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == THROWS)
                        {
                            {
                                State = 1120;
                                throws_();
                            }
                        }

                    }
                    break;
                case LT:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1123;
                        typeParameters();
                        State = 1127;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == AT)
                        {
                            {
                                {
                                    State = 1124;
                                    annotation();
                                }
                            }
                            State = 1129;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 1130;
                        result();
                        State = 1131;
                        methodDeclarator();
                        State = 1133;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == THROWS)
                        {
                            {
                                State = 1132;
                                throws_();
                            }
                        }

                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ResultContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannTypeContext unannType()
        {
            return GetRuleContext<UnannTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOID() { return GetToken(Java9Parser.VOID, 0); }
        public ResultContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_result; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterResult(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitResult(this);
        }
    }

    [RuleVersion(0)]
    public ResultContext result()
    {
        ResultContext _localctx = new ResultContext(Context, State);
        EnterRule(_localctx, 156, RULE_result);
        try
        {
            State = 1139;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case T__0:
                case T__1:
                case T__2:
                case T__3:
                case T__4:
                case T__5:
                case T__6:
                case T__7:
                case T__8:
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
                        State = 1137;
                        unannType();
                    }
                    break;
                case VOID:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1138;
                        Match(VOID);
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class MethodDeclaratorContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public FormalParameterListContext formalParameterList()
        {
            return GetRuleContext<FormalParameterListContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public DimsContext dims()
        {
            return GetRuleContext<DimsContext>(0);
        }
        public MethodDeclaratorContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_methodDeclarator; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterMethodDeclarator(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitMethodDeclarator(this);
        }
    }

    [RuleVersion(0)]
    public MethodDeclaratorContext methodDeclarator()
    {
        MethodDeclaratorContext _localctx = new MethodDeclaratorContext(Context, State);
        EnterRule(_localctx, 158, RULE_methodDeclarator);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1141;
                identifier();
                State = 1142;
                Match(LPAREN);
                State = 1144;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FINAL) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << SHORT))) != 0) || _la == AT || _la == Identifier)
                {
                    {
                        State = 1143;
                        formalParameterList();
                    }
                }

                State = 1146;
                Match(RPAREN);
                State = 1148;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == LBRACK || _la == AT)
                {
                    {
                        State = 1147;
                        dims();
                    }
                }

            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class FormalParameterListContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public FormalParametersContext formalParameters()
        {
            return GetRuleContext<FormalParametersContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(Java9Parser.COMMA, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public LastFormalParameterContext lastFormalParameter()
        {
            return GetRuleContext<LastFormalParameterContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ReceiverParameterContext receiverParameter()
        {
            return GetRuleContext<ReceiverParameterContext>(0);
        }
        public FormalParameterListContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_formalParameterList; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterFormalParameterList(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitFormalParameterList(this);
        }
    }

    [RuleVersion(0)]
    public FormalParameterListContext formalParameterList()
    {
        FormalParameterListContext _localctx = new FormalParameterListContext(Context, State);
        EnterRule(_localctx, 160, RULE_formalParameterList);
        try
        {
            State = 1156;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 95, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1150;
                        formalParameters();
                        State = 1151;
                        Match(COMMA);
                        State = 1152;
                        lastFormalParameter();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1154;
                        lastFormalParameter();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1155;
                        receiverParameter();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class FormalParametersContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public FormalParameterContext[] formalParameter()
        {
            return GetRuleContexts<FormalParameterContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public FormalParameterContext formalParameter(int i)
        {
            return GetRuleContext<FormalParameterContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java9Parser.COMMA); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode COMMA(int i)
        {
            return GetToken(Java9Parser.COMMA, i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ReceiverParameterContext receiverParameter()
        {
            return GetRuleContext<ReceiverParameterContext>(0);
        }
        public FormalParametersContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_formalParameters; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterFormalParameters(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitFormalParameters(this);
        }
    }

    [RuleVersion(0)]
    public FormalParametersContext formalParameters()
    {
        FormalParametersContext _localctx = new FormalParametersContext(Context, State);
        EnterRule(_localctx, 162, RULE_formalParameters);
        try
        {
            int _alt;
            State = 1174;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 98, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1158;
                        formalParameter();
                        State = 1163;
                        ErrorHandler.Sync(this);
                        _alt = Interpreter.AdaptivePredict(TokenStream, 96, Context);
                        while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                        {
                            if (_alt == 1)
                            {
                                {
                                    {
                                        State = 1159;
                                        Match(COMMA);
                                        State = 1160;
                                        formalParameter();
                                    }
                                }
                            }
                            State = 1165;
                            ErrorHandler.Sync(this);
                            _alt = Interpreter.AdaptivePredict(TokenStream, 96, Context);
                        }
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1166;
                        receiverParameter();
                        State = 1171;
                        ErrorHandler.Sync(this);
                        _alt = Interpreter.AdaptivePredict(TokenStream, 97, Context);
                        while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                        {
                            if (_alt == 1)
                            {
                                {
                                    {
                                        State = 1167;
                                        Match(COMMA);
                                        State = 1168;
                                        formalParameter();
                                    }
                                }
                            }
                            State = 1173;
                            ErrorHandler.Sync(this);
                            _alt = Interpreter.AdaptivePredict(TokenStream, 97, Context);
                        }
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class FormalParameterContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannTypeContext unannType()
        {
            return GetRuleContext<UnannTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableDeclaratorIdContext variableDeclaratorId()
        {
            return GetRuleContext<VariableDeclaratorIdContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableModifierContext[] variableModifier()
        {
            return GetRuleContexts<VariableModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableModifierContext variableModifier(int i)
        {
            return GetRuleContext<VariableModifierContext>(i);
        }
        public FormalParameterContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_formalParameter; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterFormalParameter(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitFormalParameter(this);
        }
    }

    [RuleVersion(0)]
    public FormalParameterContext formalParameter()
    {
        FormalParameterContext _localctx = new FormalParameterContext(Context, State);
        EnterRule(_localctx, 164, RULE_formalParameter);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1179;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == FINAL || _la == AT)
                {
                    {
                        {
                            State = 1176;
                            variableModifier();
                        }
                    }
                    State = 1181;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 1182;
                unannType();
                State = 1183;
                variableDeclaratorId();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class VariableModifierContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation()
        {
            return GetRuleContext<AnnotationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FINAL() { return GetToken(Java9Parser.FINAL, 0); }
        public VariableModifierContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_variableModifier; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterVariableModifier(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitVariableModifier(this);
        }
    }

    [RuleVersion(0)]
    public VariableModifierContext variableModifier()
    {
        VariableModifierContext _localctx = new VariableModifierContext(Context, State);
        EnterRule(_localctx, 166, RULE_variableModifier);
        try
        {
            State = 1187;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case AT:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1185;
                        annotation();
                    }
                    break;
                case FINAL:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1186;
                        Match(FINAL);
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class LastFormalParameterContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannTypeContext unannType()
        {
            return GetRuleContext<UnannTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ELLIPSIS() { return GetToken(Java9Parser.ELLIPSIS, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableDeclaratorIdContext variableDeclaratorId()
        {
            return GetRuleContext<VariableDeclaratorIdContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableModifierContext[] variableModifier()
        {
            return GetRuleContexts<VariableModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableModifierContext variableModifier(int i)
        {
            return GetRuleContext<VariableModifierContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext[] annotation()
        {
            return GetRuleContexts<AnnotationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation(int i)
        {
            return GetRuleContext<AnnotationContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public FormalParameterContext formalParameter()
        {
            return GetRuleContext<FormalParameterContext>(0);
        }
        public LastFormalParameterContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_lastFormalParameter; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterLastFormalParameter(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitLastFormalParameter(this);
        }
    }

    [RuleVersion(0)]
    public LastFormalParameterContext lastFormalParameter()
    {
        LastFormalParameterContext _localctx = new LastFormalParameterContext(Context, State);
        EnterRule(_localctx, 168, RULE_lastFormalParameter);
        int _la;
        try
        {
            State = 1206;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 103, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1192;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == FINAL || _la == AT)
                        {
                            {
                                {
                                    State = 1189;
                                    variableModifier();
                                }
                            }
                            State = 1194;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 1195;
                        unannType();
                        State = 1199;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == AT)
                        {
                            {
                                {
                                    State = 1196;
                                    annotation();
                                }
                            }
                            State = 1201;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 1202;
                        Match(ELLIPSIS);
                        State = 1203;
                        variableDeclaratorId();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1205;
                        formalParameter();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ReceiverParameterContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannTypeContext unannType()
        {
            return GetRuleContext<UnannTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THIS() { return GetToken(Java9Parser.THIS, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext[] annotation()
        {
            return GetRuleContexts<AnnotationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation(int i)
        {
            return GetRuleContext<AnnotationContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        public ReceiverParameterContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_receiverParameter; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterReceiverParameter(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitReceiverParameter(this);
        }
    }

    [RuleVersion(0)]
    public ReceiverParameterContext receiverParameter()
    {
        ReceiverParameterContext _localctx = new ReceiverParameterContext(Context, State);
        EnterRule(_localctx, 170, RULE_receiverParameter);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1211;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == AT)
                {
                    {
                        {
                            State = 1208;
                            annotation();
                        }
                    }
                    State = 1213;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 1214;
                unannType();
                State = 1218;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8))) != 0) || _la == Identifier)
                {
                    {
                        State = 1215;
                        identifier();
                        State = 1216;
                        Match(DOT);
                    }
                }

                State = 1220;
                Match(THIS);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class Throws_Context : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THROWS() { return GetToken(Java9Parser.THROWS, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExceptionTypeListContext exceptionTypeList()
        {
            return GetRuleContext<ExceptionTypeListContext>(0);
        }
        public Throws_Context(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_throws_; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterThrows_(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitThrows_(this);
        }
    }

    [RuleVersion(0)]
    public Throws_Context throws_()
    {
        Throws_Context _localctx = new Throws_Context(Context, State);
        EnterRule(_localctx, 172, RULE_throws_);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1222;
                Match(THROWS);
                State = 1223;
                exceptionTypeList();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ExceptionTypeListContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ExceptionTypeContext[] exceptionType()
        {
            return GetRuleContexts<ExceptionTypeContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExceptionTypeContext exceptionType(int i)
        {
            return GetRuleContext<ExceptionTypeContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java9Parser.COMMA); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode COMMA(int i)
        {
            return GetToken(Java9Parser.COMMA, i);
        }
        public ExceptionTypeListContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_exceptionTypeList; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterExceptionTypeList(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitExceptionTypeList(this);
        }
    }

    [RuleVersion(0)]
    public ExceptionTypeListContext exceptionTypeList()
    {
        ExceptionTypeListContext _localctx = new ExceptionTypeListContext(Context, State);
        EnterRule(_localctx, 174, RULE_exceptionTypeList);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1225;
                exceptionType();
                State = 1230;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == COMMA)
                {
                    {
                        {
                            State = 1226;
                            Match(COMMA);
                            State = 1227;
                            exceptionType();
                        }
                    }
                    State = 1232;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ExceptionTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassTypeContext classType()
        {
            return GetRuleContext<ClassTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeVariableContext typeVariable()
        {
            return GetRuleContext<TypeVariableContext>(0);
        }
        public ExceptionTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_exceptionType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterExceptionType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitExceptionType(this);
        }
    }

    [RuleVersion(0)]
    public ExceptionTypeContext exceptionType()
    {
        ExceptionTypeContext _localctx = new ExceptionTypeContext(Context, State);
        EnterRule(_localctx, 176, RULE_exceptionType);
        try
        {
            State = 1235;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 107, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1233;
                        classType();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1234;
                        typeVariable();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class MethodBodyContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public BlockContext block()
        {
            return GetRuleContext<BlockContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        public MethodBodyContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_methodBody; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterMethodBody(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitMethodBody(this);
        }
    }

    [RuleVersion(0)]
    public MethodBodyContext methodBody()
    {
        MethodBodyContext _localctx = new MethodBodyContext(Context, State);
        EnterRule(_localctx, 178, RULE_methodBody);
        try
        {
            State = 1239;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case LBRACE:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1237;
                        block();
                    }
                    break;
                case SEMI:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1238;
                        Match(SEMI);
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class InstanceInitializerContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public BlockContext block()
        {
            return GetRuleContext<BlockContext>(0);
        }
        public InstanceInitializerContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_instanceInitializer; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterInstanceInitializer(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitInstanceInitializer(this);
        }
    }

    [RuleVersion(0)]
    public InstanceInitializerContext instanceInitializer()
    {
        InstanceInitializerContext _localctx = new InstanceInitializerContext(Context, State);
        EnterRule(_localctx, 180, RULE_instanceInitializer);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1241;
                block();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class StaticInitializerContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java9Parser.STATIC, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public BlockContext block()
        {
            return GetRuleContext<BlockContext>(0);
        }
        public StaticInitializerContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_staticInitializer; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterStaticInitializer(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitStaticInitializer(this);
        }
    }

    [RuleVersion(0)]
    public StaticInitializerContext staticInitializer()
    {
        StaticInitializerContext _localctx = new StaticInitializerContext(Context, State);
        EnterRule(_localctx, 182, RULE_staticInitializer);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1243;
                Match(STATIC);
                State = 1244;
                block();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ConstructorDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ConstructorDeclaratorContext constructorDeclarator()
        {
            return GetRuleContext<ConstructorDeclaratorContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ConstructorBodyContext constructorBody()
        {
            return GetRuleContext<ConstructorBodyContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ConstructorModifierContext[] constructorModifier()
        {
            return GetRuleContexts<ConstructorModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ConstructorModifierContext constructorModifier(int i)
        {
            return GetRuleContext<ConstructorModifierContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public Throws_Context throws_()
        {
            return GetRuleContext<Throws_Context>(0);
        }
        public ConstructorDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_constructorDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterConstructorDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitConstructorDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public ConstructorDeclarationContext constructorDeclaration()
    {
        ConstructorDeclarationContext _localctx = new ConstructorDeclarationContext(Context, State);
        EnterRule(_localctx, 184, RULE_constructorDeclaration);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1249;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (((((_la - 43)) & ~0x3f) == 0 && ((1L << (_la - 43)) & ((1L << (PRIVATE - 43)) | (1L << (PROTECTED - 43)) | (1L << (PUBLIC - 43)) | (1L << (AT - 43)))) != 0))
                {
                    {
                        {
                            State = 1246;
                            constructorModifier();
                        }
                    }
                    State = 1251;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 1252;
                constructorDeclarator();
                State = 1254;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == THROWS)
                {
                    {
                        State = 1253;
                        throws_();
                    }
                }

                State = 1256;
                constructorBody();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ConstructorModifierContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation()
        {
            return GetRuleContext<AnnotationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLIC() { return GetToken(Java9Parser.PUBLIC, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PROTECTED() { return GetToken(Java9Parser.PROTECTED, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRIVATE() { return GetToken(Java9Parser.PRIVATE, 0); }
        public ConstructorModifierContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_constructorModifier; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterConstructorModifier(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitConstructorModifier(this);
        }
    }

    [RuleVersion(0)]
    public ConstructorModifierContext constructorModifier()
    {
        ConstructorModifierContext _localctx = new ConstructorModifierContext(Context, State);
        EnterRule(_localctx, 186, RULE_constructorModifier);
        try
        {
            State = 1262;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case AT:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1258;
                        annotation();
                    }
                    break;
                case PUBLIC:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1259;
                        Match(PUBLIC);
                    }
                    break;
                case PROTECTED:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1260;
                        Match(PROTECTED);
                    }
                    break;
                case PRIVATE:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 1261;
                        Match(PRIVATE);
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ConstructorDeclaratorContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public SimpleTypeNameContext simpleTypeName()
        {
            return GetRuleContext<SimpleTypeNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeParametersContext typeParameters()
        {
            return GetRuleContext<TypeParametersContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public FormalParameterListContext formalParameterList()
        {
            return GetRuleContext<FormalParameterListContext>(0);
        }
        public ConstructorDeclaratorContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_constructorDeclarator; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterConstructorDeclarator(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitConstructorDeclarator(this);
        }
    }

    [RuleVersion(0)]
    public ConstructorDeclaratorContext constructorDeclarator()
    {
        ConstructorDeclaratorContext _localctx = new ConstructorDeclaratorContext(Context, State);
        EnterRule(_localctx, 188, RULE_constructorDeclarator);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1265;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == LT)
                {
                    {
                        State = 1264;
                        typeParameters();
                    }
                }

                State = 1267;
                simpleTypeName();
                State = 1268;
                Match(LPAREN);
                State = 1270;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FINAL) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << SHORT))) != 0) || _la == AT || _la == Identifier)
                {
                    {
                        State = 1269;
                        formalParameterList();
                    }
                }

                State = 1272;
                Match(RPAREN);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class SimpleTypeNameContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        public SimpleTypeNameContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_simpleTypeName; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterSimpleTypeName(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitSimpleTypeName(this);
        }
    }

    [RuleVersion(0)]
    public SimpleTypeNameContext simpleTypeName()
    {
        SimpleTypeNameContext _localctx = new SimpleTypeNameContext(Context, State);
        EnterRule(_localctx, 190, RULE_simpleTypeName);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1274;
                identifier();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ConstructorBodyContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java9Parser.LBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java9Parser.RBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExplicitConstructorInvocationContext explicitConstructorInvocation()
        {
            return GetRuleContext<ExplicitConstructorInvocationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public BlockStatementsContext blockStatements()
        {
            return GetRuleContext<BlockStatementsContext>(0);
        }
        public ConstructorBodyContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_constructorBody; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterConstructorBody(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitConstructorBody(this);
        }
    }

    [RuleVersion(0)]
    public ConstructorBodyContext constructorBody()
    {
        ConstructorBodyContext _localctx = new ConstructorBodyContext(Context, State);
        EnterRule(_localctx, 192, RULE_constructorBody);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1276;
                Match(LBRACE);
                State = 1278;
                ErrorHandler.Sync(this);
                switch (Interpreter.AdaptivePredict(TokenStream, 114, Context))
                {
                    case 1:
                        {
                            State = 1277;
                            explicitConstructorInvocation();
                        }
                        break;
                }
                State = 1281;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << ABSTRACT) | (1L << ASSERT) | (1L << BOOLEAN) | (1L << BREAK) | (1L << BYTE) | (1L << CHAR) | (1L << CLASS) | (1L << CONTINUE) | (1L << DO) | (1L << DOUBLE) | (1L << ENUM) | (1L << FINAL) | (1L << FLOAT) | (1L << FOR) | (1L << IF) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << RETURN) | (1L << SHORT) | (1L << STATIC) | (1L << STRICTFP) | (1L << SUPER) | (1L << SWITCH) | (1L << SYNCHRONIZED) | (1L << THIS) | (1L << THROW) | (1L << TRY) | (1L << VOID) | (1L << WHILE) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (LBRACE - 64)) | (1L << (SEMI - 64)) | (1L << (AT - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (Identifier - 64)))) != 0))
                {
                    {
                        State = 1280;
                        blockStatements();
                    }
                }

                State = 1283;
                Match(RBRACE);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ExplicitConstructorInvocationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THIS() { return GetToken(Java9Parser.THIS, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsContext typeArguments()
        {
            return GetRuleContext<TypeArgumentsContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ArgumentListContext argumentList()
        {
            return GetRuleContext<ArgumentListContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUPER() { return GetToken(Java9Parser.SUPER, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionNameContext expressionName()
        {
            return GetRuleContext<ExpressionNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimaryContext primary()
        {
            return GetRuleContext<PrimaryContext>(0);
        }
        public ExplicitConstructorInvocationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_explicitConstructorInvocation; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterExplicitConstructorInvocation(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitExplicitConstructorInvocation(this);
        }
    }

    [RuleVersion(0)]
    public ExplicitConstructorInvocationContext explicitConstructorInvocation()
    {
        ExplicitConstructorInvocationContext _localctx = new ExplicitConstructorInvocationContext(Context, State);
        EnterRule(_localctx, 194, RULE_explicitConstructorInvocation);
        int _la;
        try
        {
            State = 1331;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 124, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1286;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 1285;
                                typeArguments();
                            }
                        }

                        State = 1288;
                        Match(THIS);
                        State = 1289;
                        Match(LPAREN);
                        State = 1291;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 1290;
                                argumentList();
                            }
                        }

                        State = 1293;
                        Match(RPAREN);
                        State = 1294;
                        Match(SEMI);
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1296;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 1295;
                                typeArguments();
                            }
                        }

                        State = 1298;
                        Match(SUPER);
                        State = 1299;
                        Match(LPAREN);
                        State = 1301;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 1300;
                                argumentList();
                            }
                        }

                        State = 1303;
                        Match(RPAREN);
                        State = 1304;
                        Match(SEMI);
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1305;
                        expressionName();
                        State = 1306;
                        Match(DOT);
                        State = 1308;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 1307;
                                typeArguments();
                            }
                        }

                        State = 1310;
                        Match(SUPER);
                        State = 1311;
                        Match(LPAREN);
                        State = 1313;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 1312;
                                argumentList();
                            }
                        }

                        State = 1315;
                        Match(RPAREN);
                        State = 1316;
                        Match(SEMI);
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 1318;
                        primary();
                        State = 1319;
                        Match(DOT);
                        State = 1321;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 1320;
                                typeArguments();
                            }
                        }

                        State = 1323;
                        Match(SUPER);
                        State = 1324;
                        Match(LPAREN);
                        State = 1326;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 1325;
                                argumentList();
                            }
                        }

                        State = 1328;
                        Match(RPAREN);
                        State = 1329;
                        Match(SEMI);
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class EnumDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ENUM() { return GetToken(Java9Parser.ENUM, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public EnumBodyContext enumBody()
        {
            return GetRuleContext<EnumBodyContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassModifierContext[] classModifier()
        {
            return GetRuleContexts<ClassModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassModifierContext classModifier(int i)
        {
            return GetRuleContext<ClassModifierContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public SuperinterfacesContext superinterfaces()
        {
            return GetRuleContext<SuperinterfacesContext>(0);
        }
        public EnumDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_enumDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterEnumDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitEnumDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public EnumDeclarationContext enumDeclaration()
    {
        EnumDeclarationContext _localctx = new EnumDeclarationContext(Context, State);
        EnterRule(_localctx, 196, RULE_enumDeclaration);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1336;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << FINAL) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << STATIC) | (1L << STRICTFP))) != 0) || _la == AT)
                {
                    {
                        {
                            State = 1333;
                            classModifier();
                        }
                    }
                    State = 1338;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 1339;
                Match(ENUM);
                State = 1340;
                identifier();
                State = 1342;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == IMPLEMENTS)
                {
                    {
                        State = 1341;
                        superinterfaces();
                    }
                }

                State = 1344;
                enumBody();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class EnumBodyContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java9Parser.LBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java9Parser.RBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public EnumConstantListContext enumConstantList()
        {
            return GetRuleContext<EnumConstantListContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(Java9Parser.COMMA, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public EnumBodyDeclarationsContext enumBodyDeclarations()
        {
            return GetRuleContext<EnumBodyDeclarationsContext>(0);
        }
        public EnumBodyContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_enumBody; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterEnumBody(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitEnumBody(this);
        }
    }

    [RuleVersion(0)]
    public EnumBodyContext enumBody()
    {
        EnumBodyContext _localctx = new EnumBodyContext(Context, State);
        EnterRule(_localctx, 198, RULE_enumBody);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1346;
                Match(LBRACE);
                State = 1348;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8))) != 0) || _la == AT || _la == Identifier)
                {
                    {
                        State = 1347;
                        enumConstantList();
                    }
                }

                State = 1351;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == COMMA)
                {
                    {
                        State = 1350;
                        Match(COMMA);
                    }
                }

                State = 1354;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == SEMI)
                {
                    {
                        State = 1353;
                        enumBodyDeclarations();
                    }
                }

                State = 1356;
                Match(RBRACE);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class EnumConstantListContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public EnumConstantContext[] enumConstant()
        {
            return GetRuleContexts<EnumConstantContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public EnumConstantContext enumConstant(int i)
        {
            return GetRuleContext<EnumConstantContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java9Parser.COMMA); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode COMMA(int i)
        {
            return GetToken(Java9Parser.COMMA, i);
        }
        public EnumConstantListContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_enumConstantList; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterEnumConstantList(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitEnumConstantList(this);
        }
    }

    [RuleVersion(0)]
    public EnumConstantListContext enumConstantList()
    {
        EnumConstantListContext _localctx = new EnumConstantListContext(Context, State);
        EnterRule(_localctx, 200, RULE_enumConstantList);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                State = 1358;
                enumConstant();
                State = 1363;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 130, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        {
                            {
                                State = 1359;
                                Match(COMMA);
                                State = 1360;
                                enumConstant();
                            }
                        }
                    }
                    State = 1365;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 130, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class EnumConstantContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public EnumConstantModifierContext[] enumConstantModifier()
        {
            return GetRuleContexts<EnumConstantModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public EnumConstantModifierContext enumConstantModifier(int i)
        {
            return GetRuleContext<EnumConstantModifierContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassBodyContext classBody()
        {
            return GetRuleContext<ClassBodyContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ArgumentListContext argumentList()
        {
            return GetRuleContext<ArgumentListContext>(0);
        }
        public EnumConstantContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_enumConstant; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterEnumConstant(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitEnumConstant(this);
        }
    }

    [RuleVersion(0)]
    public EnumConstantContext enumConstant()
    {
        EnumConstantContext _localctx = new EnumConstantContext(Context, State);
        EnterRule(_localctx, 202, RULE_enumConstant);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1369;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == AT)
                {
                    {
                        {
                            State = 1366;
                            enumConstantModifier();
                        }
                    }
                    State = 1371;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 1372;
                identifier();
                State = 1378;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == LPAREN)
                {
                    {
                        State = 1373;
                        Match(LPAREN);
                        State = 1375;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 1374;
                                argumentList();
                            }
                        }

                        State = 1377;
                        Match(RPAREN);
                    }
                }

                State = 1381;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == LBRACE)
                {
                    {
                        State = 1380;
                        classBody();
                    }
                }

            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class EnumConstantModifierContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation()
        {
            return GetRuleContext<AnnotationContext>(0);
        }
        public EnumConstantModifierContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_enumConstantModifier; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterEnumConstantModifier(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitEnumConstantModifier(this);
        }
    }

    [RuleVersion(0)]
    public EnumConstantModifierContext enumConstantModifier()
    {
        EnumConstantModifierContext _localctx = new EnumConstantModifierContext(Context, State);
        EnterRule(_localctx, 204, RULE_enumConstantModifier);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1383;
                annotation();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class EnumBodyDeclarationsContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassBodyDeclarationContext[] classBodyDeclaration()
        {
            return GetRuleContexts<ClassBodyDeclarationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassBodyDeclarationContext classBodyDeclaration(int i)
        {
            return GetRuleContext<ClassBodyDeclarationContext>(i);
        }
        public EnumBodyDeclarationsContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_enumBodyDeclarations; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterEnumBodyDeclarations(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitEnumBodyDeclarations(this);
        }
    }

    [RuleVersion(0)]
    public EnumBodyDeclarationsContext enumBodyDeclarations()
    {
        EnumBodyDeclarationsContext _localctx = new EnumBodyDeclarationsContext(Context, State);
        EnterRule(_localctx, 206, RULE_enumBodyDeclarations);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1385;
                Match(SEMI);
                State = 1389;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << ABSTRACT) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << CLASS) | (1L << DOUBLE) | (1L << ENUM) | (1L << FINAL) | (1L << FLOAT) | (1L << INT) | (1L << INTERFACE) | (1L << LONG) | (1L << NATIVE) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << SHORT) | (1L << STATIC) | (1L << STRICTFP) | (1L << SYNCHRONIZED) | (1L << TRANSIENT) | (1L << VOID) | (1L << VOLATILE))) != 0) || ((((_la - 70)) & ~0x3f) == 0 && ((1L << (_la - 70)) & ((1L << (LBRACE - 70)) | (1L << (SEMI - 70)) | (1L << (AT - 70)) | (1L << (LT - 70)) | (1L << (Identifier - 70)))) != 0))
                {
                    {
                        {
                            State = 1386;
                            classBodyDeclaration();
                        }
                    }
                    State = 1391;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class InterfaceDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public NormalInterfaceDeclarationContext normalInterfaceDeclaration()
        {
            return GetRuleContext<NormalInterfaceDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationTypeDeclarationContext annotationTypeDeclaration()
        {
            return GetRuleContext<AnnotationTypeDeclarationContext>(0);
        }
        public InterfaceDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_interfaceDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterInterfaceDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitInterfaceDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public InterfaceDeclarationContext interfaceDeclaration()
    {
        InterfaceDeclarationContext _localctx = new InterfaceDeclarationContext(Context, State);
        EnterRule(_localctx, 208, RULE_interfaceDeclaration);
        try
        {
            State = 1394;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 136, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1392;
                        normalInterfaceDeclaration();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1393;
                        annotationTypeDeclaration();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class NormalInterfaceDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERFACE() { return GetToken(Java9Parser.INTERFACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceBodyContext interfaceBody()
        {
            return GetRuleContext<InterfaceBodyContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceModifierContext[] interfaceModifier()
        {
            return GetRuleContexts<InterfaceModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceModifierContext interfaceModifier(int i)
        {
            return GetRuleContext<InterfaceModifierContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeParametersContext typeParameters()
        {
            return GetRuleContext<TypeParametersContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExtendsInterfacesContext extendsInterfaces()
        {
            return GetRuleContext<ExtendsInterfacesContext>(0);
        }
        public NormalInterfaceDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_normalInterfaceDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterNormalInterfaceDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitNormalInterfaceDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public NormalInterfaceDeclarationContext normalInterfaceDeclaration()
    {
        NormalInterfaceDeclarationContext _localctx = new NormalInterfaceDeclarationContext(Context, State);
        EnterRule(_localctx, 210, RULE_normalInterfaceDeclaration);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1399;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << STATIC) | (1L << STRICTFP))) != 0) || _la == AT)
                {
                    {
                        {
                            State = 1396;
                            interfaceModifier();
                        }
                    }
                    State = 1401;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 1402;
                Match(INTERFACE);
                State = 1403;
                identifier();
                State = 1405;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == LT)
                {
                    {
                        State = 1404;
                        typeParameters();
                    }
                }

                State = 1408;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == EXTENDS)
                {
                    {
                        State = 1407;
                        extendsInterfaces();
                    }
                }

                State = 1410;
                interfaceBody();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class InterfaceModifierContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation()
        {
            return GetRuleContext<AnnotationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLIC() { return GetToken(Java9Parser.PUBLIC, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PROTECTED() { return GetToken(Java9Parser.PROTECTED, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRIVATE() { return GetToken(Java9Parser.PRIVATE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ABSTRACT() { return GetToken(Java9Parser.ABSTRACT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java9Parser.STATIC, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRICTFP() { return GetToken(Java9Parser.STRICTFP, 0); }
        public InterfaceModifierContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_interfaceModifier; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterInterfaceModifier(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitInterfaceModifier(this);
        }
    }

    [RuleVersion(0)]
    public InterfaceModifierContext interfaceModifier()
    {
        InterfaceModifierContext _localctx = new InterfaceModifierContext(Context, State);
        EnterRule(_localctx, 212, RULE_interfaceModifier);
        try
        {
            State = 1419;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case AT:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1412;
                        annotation();
                    }
                    break;
                case PUBLIC:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1413;
                        Match(PUBLIC);
                    }
                    break;
                case PROTECTED:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1414;
                        Match(PROTECTED);
                    }
                    break;
                case PRIVATE:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 1415;
                        Match(PRIVATE);
                    }
                    break;
                case ABSTRACT:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 1416;
                        Match(ABSTRACT);
                    }
                    break;
                case STATIC:
                    EnterOuterAlt(_localctx, 6);
                    {
                        State = 1417;
                        Match(STATIC);
                    }
                    break;
                case STRICTFP:
                    EnterOuterAlt(_localctx, 7);
                    {
                        State = 1418;
                        Match(STRICTFP);
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ExtendsInterfacesContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXTENDS() { return GetToken(Java9Parser.EXTENDS, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceTypeListContext interfaceTypeList()
        {
            return GetRuleContext<InterfaceTypeListContext>(0);
        }
        public ExtendsInterfacesContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_extendsInterfaces; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterExtendsInterfaces(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitExtendsInterfaces(this);
        }
    }

    [RuleVersion(0)]
    public ExtendsInterfacesContext extendsInterfaces()
    {
        ExtendsInterfacesContext _localctx = new ExtendsInterfacesContext(Context, State);
        EnterRule(_localctx, 214, RULE_extendsInterfaces);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1421;
                Match(EXTENDS);
                State = 1422;
                interfaceTypeList();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class InterfaceBodyContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java9Parser.LBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java9Parser.RBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceMemberDeclarationContext[] interfaceMemberDeclaration()
        {
            return GetRuleContexts<InterfaceMemberDeclarationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceMemberDeclarationContext interfaceMemberDeclaration(int i)
        {
            return GetRuleContext<InterfaceMemberDeclarationContext>(i);
        }
        public InterfaceBodyContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_interfaceBody; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterInterfaceBody(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitInterfaceBody(this);
        }
    }

    [RuleVersion(0)]
    public InterfaceBodyContext interfaceBody()
    {
        InterfaceBodyContext _localctx = new InterfaceBodyContext(Context, State);
        EnterRule(_localctx, 216, RULE_interfaceBody);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1424;
                Match(LBRACE);
                State = 1428;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << ABSTRACT) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << CLASS) | (1L << DEFAULT) | (1L << DOUBLE) | (1L << ENUM) | (1L << FINAL) | (1L << FLOAT) | (1L << INT) | (1L << INTERFACE) | (1L << LONG) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << SHORT) | (1L << STATIC) | (1L << STRICTFP) | (1L << VOID))) != 0) || ((((_la - 74)) & ~0x3f) == 0 && ((1L << (_la - 74)) & ((1L << (SEMI - 74)) | (1L << (AT - 74)) | (1L << (LT - 74)) | (1L << (Identifier - 74)))) != 0))
                {
                    {
                        {
                            State = 1425;
                            interfaceMemberDeclaration();
                        }
                    }
                    State = 1430;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 1431;
                Match(RBRACE);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class InterfaceMemberDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ConstantDeclarationContext constantDeclaration()
        {
            return GetRuleContext<ConstantDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceMethodDeclarationContext interfaceMethodDeclaration()
        {
            return GetRuleContext<InterfaceMethodDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassDeclarationContext classDeclaration()
        {
            return GetRuleContext<ClassDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceDeclarationContext interfaceDeclaration()
        {
            return GetRuleContext<InterfaceDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        public InterfaceMemberDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_interfaceMemberDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterInterfaceMemberDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitInterfaceMemberDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public InterfaceMemberDeclarationContext interfaceMemberDeclaration()
    {
        InterfaceMemberDeclarationContext _localctx = new InterfaceMemberDeclarationContext(Context, State);
        EnterRule(_localctx, 218, RULE_interfaceMemberDeclaration);
        try
        {
            State = 1438;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 142, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1433;
                        constantDeclaration();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1434;
                        interfaceMethodDeclaration();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1435;
                        classDeclaration();
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 1436;
                        interfaceDeclaration();
                    }
                    break;
                case 5:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 1437;
                        Match(SEMI);
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ConstantDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannTypeContext unannType()
        {
            return GetRuleContext<UnannTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableDeclaratorListContext variableDeclaratorList()
        {
            return GetRuleContext<VariableDeclaratorListContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ConstantModifierContext[] constantModifier()
        {
            return GetRuleContexts<ConstantModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ConstantModifierContext constantModifier(int i)
        {
            return GetRuleContext<ConstantModifierContext>(i);
        }
        public ConstantDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_constantDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterConstantDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitConstantDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public ConstantDeclarationContext constantDeclaration()
    {
        ConstantDeclarationContext _localctx = new ConstantDeclarationContext(Context, State);
        EnterRule(_localctx, 220, RULE_constantDeclaration);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1443;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (((((_la - 28)) & ~0x3f) == 0 && ((1L << (_la - 28)) & ((1L << (FINAL - 28)) | (1L << (PUBLIC - 28)) | (1L << (STATIC - 28)) | (1L << (AT - 28)))) != 0))
                {
                    {
                        {
                            State = 1440;
                            constantModifier();
                        }
                    }
                    State = 1445;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 1446;
                unannType();
                State = 1447;
                variableDeclaratorList();
                State = 1448;
                Match(SEMI);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ConstantModifierContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation()
        {
            return GetRuleContext<AnnotationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLIC() { return GetToken(Java9Parser.PUBLIC, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java9Parser.STATIC, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FINAL() { return GetToken(Java9Parser.FINAL, 0); }
        public ConstantModifierContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_constantModifier; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterConstantModifier(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitConstantModifier(this);
        }
    }

    [RuleVersion(0)]
    public ConstantModifierContext constantModifier()
    {
        ConstantModifierContext _localctx = new ConstantModifierContext(Context, State);
        EnterRule(_localctx, 222, RULE_constantModifier);
        try
        {
            State = 1454;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case AT:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1450;
                        annotation();
                    }
                    break;
                case PUBLIC:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1451;
                        Match(PUBLIC);
                    }
                    break;
                case STATIC:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1452;
                        Match(STATIC);
                    }
                    break;
                case FINAL:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 1453;
                        Match(FINAL);
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class InterfaceMethodDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodHeaderContext methodHeader()
        {
            return GetRuleContext<MethodHeaderContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodBodyContext methodBody()
        {
            return GetRuleContext<MethodBodyContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceMethodModifierContext[] interfaceMethodModifier()
        {
            return GetRuleContexts<InterfaceMethodModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceMethodModifierContext interfaceMethodModifier(int i)
        {
            return GetRuleContext<InterfaceMethodModifierContext>(i);
        }
        public InterfaceMethodDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_interfaceMethodDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterInterfaceMethodDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitInterfaceMethodDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public InterfaceMethodDeclarationContext interfaceMethodDeclaration()
    {
        InterfaceMethodDeclarationContext _localctx = new InterfaceMethodDeclarationContext(Context, State);
        EnterRule(_localctx, 224, RULE_interfaceMethodDeclaration);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1459;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << DEFAULT) | (1L << PRIVATE) | (1L << PUBLIC) | (1L << STATIC) | (1L << STRICTFP))) != 0) || _la == AT)
                {
                    {
                        {
                            State = 1456;
                            interfaceMethodModifier();
                        }
                    }
                    State = 1461;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 1462;
                methodHeader();
                State = 1463;
                methodBody();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class InterfaceMethodModifierContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation()
        {
            return GetRuleContext<AnnotationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLIC() { return GetToken(Java9Parser.PUBLIC, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRIVATE() { return GetToken(Java9Parser.PRIVATE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ABSTRACT() { return GetToken(Java9Parser.ABSTRACT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFAULT() { return GetToken(Java9Parser.DEFAULT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(Java9Parser.STATIC, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRICTFP() { return GetToken(Java9Parser.STRICTFP, 0); }
        public InterfaceMethodModifierContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_interfaceMethodModifier; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterInterfaceMethodModifier(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitInterfaceMethodModifier(this);
        }
    }

    [RuleVersion(0)]
    public InterfaceMethodModifierContext interfaceMethodModifier()
    {
        InterfaceMethodModifierContext _localctx = new InterfaceMethodModifierContext(Context, State);
        EnterRule(_localctx, 226, RULE_interfaceMethodModifier);
        try
        {
            State = 1472;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case AT:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1465;
                        annotation();
                    }
                    break;
                case PUBLIC:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1466;
                        Match(PUBLIC);
                    }
                    break;
                case PRIVATE:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1467;
                        Match(PRIVATE);
                    }
                    break;
                case ABSTRACT:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 1468;
                        Match(ABSTRACT);
                    }
                    break;
                case DEFAULT:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 1469;
                        Match(DEFAULT);
                    }
                    break;
                case STATIC:
                    EnterOuterAlt(_localctx, 6);
                    {
                        State = 1470;
                        Match(STATIC);
                    }
                    break;
                case STRICTFP:
                    EnterOuterAlt(_localctx, 7);
                    {
                        State = 1471;
                        Match(STRICTFP);
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class AnnotationTypeDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AT() { return GetToken(Java9Parser.AT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERFACE() { return GetToken(Java9Parser.INTERFACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationTypeBodyContext annotationTypeBody()
        {
            return GetRuleContext<AnnotationTypeBodyContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceModifierContext[] interfaceModifier()
        {
            return GetRuleContexts<InterfaceModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceModifierContext interfaceModifier(int i)
        {
            return GetRuleContext<InterfaceModifierContext>(i);
        }
        public AnnotationTypeDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_annotationTypeDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterAnnotationTypeDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitAnnotationTypeDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public AnnotationTypeDeclarationContext annotationTypeDeclaration()
    {
        AnnotationTypeDeclarationContext _localctx = new AnnotationTypeDeclarationContext(Context, State);
        EnterRule(_localctx, 228, RULE_annotationTypeDeclaration);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                State = 1477;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 147, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        {
                            {
                                State = 1474;
                                interfaceModifier();
                            }
                        }
                    }
                    State = 1479;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 147, Context);
                }
                State = 1480;
                Match(AT);
                State = 1481;
                Match(INTERFACE);
                State = 1482;
                identifier();
                State = 1483;
                annotationTypeBody();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class AnnotationTypeBodyContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java9Parser.LBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java9Parser.RBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationTypeMemberDeclarationContext[] annotationTypeMemberDeclaration()
        {
            return GetRuleContexts<AnnotationTypeMemberDeclarationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationTypeMemberDeclarationContext annotationTypeMemberDeclaration(int i)
        {
            return GetRuleContext<AnnotationTypeMemberDeclarationContext>(i);
        }
        public AnnotationTypeBodyContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_annotationTypeBody; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterAnnotationTypeBody(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitAnnotationTypeBody(this);
        }
    }

    [RuleVersion(0)]
    public AnnotationTypeBodyContext annotationTypeBody()
    {
        AnnotationTypeBodyContext _localctx = new AnnotationTypeBodyContext(Context, State);
        EnterRule(_localctx, 230, RULE_annotationTypeBody);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1485;
                Match(LBRACE);
                State = 1489;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << ABSTRACT) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << CLASS) | (1L << DOUBLE) | (1L << ENUM) | (1L << FINAL) | (1L << FLOAT) | (1L << INT) | (1L << INTERFACE) | (1L << LONG) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << SHORT) | (1L << STATIC) | (1L << STRICTFP))) != 0) || ((((_la - 74)) & ~0x3f) == 0 && ((1L << (_la - 74)) & ((1L << (SEMI - 74)) | (1L << (AT - 74)) | (1L << (Identifier - 74)))) != 0))
                {
                    {
                        {
                            State = 1486;
                            annotationTypeMemberDeclaration();
                        }
                    }
                    State = 1491;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 1492;
                Match(RBRACE);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class AnnotationTypeMemberDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationTypeElementDeclarationContext annotationTypeElementDeclaration()
        {
            return GetRuleContext<AnnotationTypeElementDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ConstantDeclarationContext constantDeclaration()
        {
            return GetRuleContext<ConstantDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassDeclarationContext classDeclaration()
        {
            return GetRuleContext<ClassDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InterfaceDeclarationContext interfaceDeclaration()
        {
            return GetRuleContext<InterfaceDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        public AnnotationTypeMemberDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_annotationTypeMemberDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterAnnotationTypeMemberDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitAnnotationTypeMemberDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public AnnotationTypeMemberDeclarationContext annotationTypeMemberDeclaration()
    {
        AnnotationTypeMemberDeclarationContext _localctx = new AnnotationTypeMemberDeclarationContext(Context, State);
        EnterRule(_localctx, 232, RULE_annotationTypeMemberDeclaration);
        try
        {
            State = 1499;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 149, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1494;
                        annotationTypeElementDeclaration();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1495;
                        constantDeclaration();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1496;
                        classDeclaration();
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 1497;
                        interfaceDeclaration();
                    }
                    break;
                case 5:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 1498;
                        Match(SEMI);
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class AnnotationTypeElementDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannTypeContext unannType()
        {
            return GetRuleContext<UnannTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationTypeElementModifierContext[] annotationTypeElementModifier()
        {
            return GetRuleContexts<AnnotationTypeElementModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationTypeElementModifierContext annotationTypeElementModifier(int i)
        {
            return GetRuleContext<AnnotationTypeElementModifierContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public DimsContext dims()
        {
            return GetRuleContext<DimsContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public DefaultValueContext defaultValue()
        {
            return GetRuleContext<DefaultValueContext>(0);
        }
        public AnnotationTypeElementDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_annotationTypeElementDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterAnnotationTypeElementDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitAnnotationTypeElementDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public AnnotationTypeElementDeclarationContext annotationTypeElementDeclaration()
    {
        AnnotationTypeElementDeclarationContext _localctx = new AnnotationTypeElementDeclarationContext(Context, State);
        EnterRule(_localctx, 234, RULE_annotationTypeElementDeclaration);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1504;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == ABSTRACT || _la == PUBLIC || _la == AT)
                {
                    {
                        {
                            State = 1501;
                            annotationTypeElementModifier();
                        }
                    }
                    State = 1506;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 1507;
                unannType();
                State = 1508;
                identifier();
                State = 1509;
                Match(LPAREN);
                State = 1510;
                Match(RPAREN);
                State = 1512;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == LBRACK || _la == AT)
                {
                    {
                        State = 1511;
                        dims();
                    }
                }

                State = 1515;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == DEFAULT)
                {
                    {
                        State = 1514;
                        defaultValue();
                    }
                }

                State = 1517;
                Match(SEMI);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class AnnotationTypeElementModifierContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation()
        {
            return GetRuleContext<AnnotationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLIC() { return GetToken(Java9Parser.PUBLIC, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ABSTRACT() { return GetToken(Java9Parser.ABSTRACT, 0); }
        public AnnotationTypeElementModifierContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_annotationTypeElementModifier; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterAnnotationTypeElementModifier(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitAnnotationTypeElementModifier(this);
        }
    }

    [RuleVersion(0)]
    public AnnotationTypeElementModifierContext annotationTypeElementModifier()
    {
        AnnotationTypeElementModifierContext _localctx = new AnnotationTypeElementModifierContext(Context, State);
        EnterRule(_localctx, 236, RULE_annotationTypeElementModifier);
        try
        {
            State = 1522;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case AT:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1519;
                        annotation();
                    }
                    break;
                case PUBLIC:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1520;
                        Match(PUBLIC);
                    }
                    break;
                case ABSTRACT:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1521;
                        Match(ABSTRACT);
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class DefaultValueContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFAULT() { return GetToken(Java9Parser.DEFAULT, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ElementValueContext elementValue()
        {
            return GetRuleContext<ElementValueContext>(0);
        }
        public DefaultValueContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_defaultValue; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterDefaultValue(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitDefaultValue(this);
        }
    }

    [RuleVersion(0)]
    public DefaultValueContext defaultValue()
    {
        DefaultValueContext _localctx = new DefaultValueContext(Context, State);
        EnterRule(_localctx, 238, RULE_defaultValue);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1524;
                Match(DEFAULT);
                State = 1525;
                elementValue();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class AnnotationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public NormalAnnotationContext normalAnnotation()
        {
            return GetRuleContext<NormalAnnotationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MarkerAnnotationContext markerAnnotation()
        {
            return GetRuleContext<MarkerAnnotationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public SingleElementAnnotationContext singleElementAnnotation()
        {
            return GetRuleContext<SingleElementAnnotationContext>(0);
        }
        public AnnotationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_annotation; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterAnnotation(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitAnnotation(this);
        }
    }

    [RuleVersion(0)]
    public AnnotationContext annotation()
    {
        AnnotationContext _localctx = new AnnotationContext(Context, State);
        EnterRule(_localctx, 240, RULE_annotation);
        try
        {
            State = 1530;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 154, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1527;
                        normalAnnotation();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1528;
                        markerAnnotation();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1529;
                        singleElementAnnotation();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class NormalAnnotationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AT() { return GetToken(Java9Parser.AT, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext typeName()
        {
            return GetRuleContext<TypeNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ElementValuePairListContext elementValuePairList()
        {
            return GetRuleContext<ElementValuePairListContext>(0);
        }
        public NormalAnnotationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_normalAnnotation; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterNormalAnnotation(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitNormalAnnotation(this);
        }
    }

    [RuleVersion(0)]
    public NormalAnnotationContext normalAnnotation()
    {
        NormalAnnotationContext _localctx = new NormalAnnotationContext(Context, State);
        EnterRule(_localctx, 242, RULE_normalAnnotation);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1532;
                Match(AT);
                State = 1533;
                typeName();
                State = 1534;
                Match(LPAREN);
                State = 1536;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8))) != 0) || _la == Identifier)
                {
                    {
                        State = 1535;
                        elementValuePairList();
                    }
                }

                State = 1538;
                Match(RPAREN);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ElementValuePairListContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ElementValuePairContext[] elementValuePair()
        {
            return GetRuleContexts<ElementValuePairContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ElementValuePairContext elementValuePair(int i)
        {
            return GetRuleContext<ElementValuePairContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java9Parser.COMMA); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode COMMA(int i)
        {
            return GetToken(Java9Parser.COMMA, i);
        }
        public ElementValuePairListContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_elementValuePairList; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterElementValuePairList(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitElementValuePairList(this);
        }
    }

    [RuleVersion(0)]
    public ElementValuePairListContext elementValuePairList()
    {
        ElementValuePairListContext _localctx = new ElementValuePairListContext(Context, State);
        EnterRule(_localctx, 244, RULE_elementValuePairList);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1540;
                elementValuePair();
                State = 1545;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == COMMA)
                {
                    {
                        {
                            State = 1541;
                            Match(COMMA);
                            State = 1542;
                            elementValuePair();
                        }
                    }
                    State = 1547;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ElementValuePairContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGN() { return GetToken(Java9Parser.ASSIGN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ElementValueContext elementValue()
        {
            return GetRuleContext<ElementValueContext>(0);
        }
        public ElementValuePairContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_elementValuePair; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterElementValuePair(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitElementValuePair(this);
        }
    }

    [RuleVersion(0)]
    public ElementValuePairContext elementValuePair()
    {
        ElementValuePairContext _localctx = new ElementValuePairContext(Context, State);
        EnterRule(_localctx, 246, RULE_elementValuePair);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1548;
                identifier();
                State = 1549;
                Match(ASSIGN);
                State = 1550;
                elementValue();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ElementValueContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ConditionalExpressionContext conditionalExpression()
        {
            return GetRuleContext<ConditionalExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ElementValueArrayInitializerContext elementValueArrayInitializer()
        {
            return GetRuleContext<ElementValueArrayInitializerContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation()
        {
            return GetRuleContext<AnnotationContext>(0);
        }
        public ElementValueContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_elementValue; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterElementValue(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitElementValue(this);
        }
    }

    [RuleVersion(0)]
    public ElementValueContext elementValue()
    {
        ElementValueContext _localctx = new ElementValueContext(Context, State);
        EnterRule(_localctx, 248, RULE_elementValue);
        try
        {
            State = 1555;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 157, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1552;
                        conditionalExpression();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1553;
                        elementValueArrayInitializer();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1554;
                        annotation();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ElementValueArrayInitializerContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java9Parser.LBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java9Parser.RBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ElementValueListContext elementValueList()
        {
            return GetRuleContext<ElementValueListContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(Java9Parser.COMMA, 0); }
        public ElementValueArrayInitializerContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_elementValueArrayInitializer; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterElementValueArrayInitializer(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitElementValueArrayInitializer(this);
        }
    }

    [RuleVersion(0)]
    public ElementValueArrayInitializerContext elementValueArrayInitializer()
    {
        ElementValueArrayInitializerContext _localctx = new ElementValueArrayInitializerContext(Context, State);
        EnterRule(_localctx, 250, RULE_elementValueArrayInitializer);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1557;
                Match(LBRACE);
                State = 1559;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (LBRACE - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                {
                    {
                        State = 1558;
                        elementValueList();
                    }
                }

                State = 1562;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == COMMA)
                {
                    {
                        State = 1561;
                        Match(COMMA);
                    }
                }

                State = 1564;
                Match(RBRACE);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ElementValueListContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ElementValueContext[] elementValue()
        {
            return GetRuleContexts<ElementValueContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ElementValueContext elementValue(int i)
        {
            return GetRuleContext<ElementValueContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java9Parser.COMMA); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode COMMA(int i)
        {
            return GetToken(Java9Parser.COMMA, i);
        }
        public ElementValueListContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_elementValueList; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterElementValueList(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitElementValueList(this);
        }
    }

    [RuleVersion(0)]
    public ElementValueListContext elementValueList()
    {
        ElementValueListContext _localctx = new ElementValueListContext(Context, State);
        EnterRule(_localctx, 252, RULE_elementValueList);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                State = 1566;
                elementValue();
                State = 1571;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 160, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        {
                            {
                                State = 1567;
                                Match(COMMA);
                                State = 1568;
                                elementValue();
                            }
                        }
                    }
                    State = 1573;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 160, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class MarkerAnnotationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AT() { return GetToken(Java9Parser.AT, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext typeName()
        {
            return GetRuleContext<TypeNameContext>(0);
        }
        public MarkerAnnotationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_markerAnnotation; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterMarkerAnnotation(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitMarkerAnnotation(this);
        }
    }

    [RuleVersion(0)]
    public MarkerAnnotationContext markerAnnotation()
    {
        MarkerAnnotationContext _localctx = new MarkerAnnotationContext(Context, State);
        EnterRule(_localctx, 254, RULE_markerAnnotation);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1574;
                Match(AT);
                State = 1575;
                typeName();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class SingleElementAnnotationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AT() { return GetToken(Java9Parser.AT, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext typeName()
        {
            return GetRuleContext<TypeNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ElementValueContext elementValue()
        {
            return GetRuleContext<ElementValueContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        public SingleElementAnnotationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_singleElementAnnotation; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterSingleElementAnnotation(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitSingleElementAnnotation(this);
        }
    }

    [RuleVersion(0)]
    public SingleElementAnnotationContext singleElementAnnotation()
    {
        SingleElementAnnotationContext _localctx = new SingleElementAnnotationContext(Context, State);
        EnterRule(_localctx, 256, RULE_singleElementAnnotation);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1577;
                Match(AT);
                State = 1578;
                typeName();
                State = 1579;
                Match(LPAREN);
                State = 1580;
                elementValue();
                State = 1581;
                Match(RPAREN);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ArrayInitializerContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java9Parser.LBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java9Parser.RBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableInitializerListContext variableInitializerList()
        {
            return GetRuleContext<VariableInitializerListContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(Java9Parser.COMMA, 0); }
        public ArrayInitializerContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_arrayInitializer; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterArrayInitializer(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitArrayInitializer(this);
        }
    }

    [RuleVersion(0)]
    public ArrayInitializerContext arrayInitializer()
    {
        ArrayInitializerContext _localctx = new ArrayInitializerContext(Context, State);
        EnterRule(_localctx, 258, RULE_arrayInitializer);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1583;
                Match(LBRACE);
                State = 1585;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (LBRACE - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                {
                    {
                        State = 1584;
                        variableInitializerList();
                    }
                }

                State = 1588;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == COMMA)
                {
                    {
                        State = 1587;
                        Match(COMMA);
                    }
                }

                State = 1590;
                Match(RBRACE);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class VariableInitializerListContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableInitializerContext[] variableInitializer()
        {
            return GetRuleContexts<VariableInitializerContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableInitializerContext variableInitializer(int i)
        {
            return GetRuleContext<VariableInitializerContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java9Parser.COMMA); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode COMMA(int i)
        {
            return GetToken(Java9Parser.COMMA, i);
        }
        public VariableInitializerListContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_variableInitializerList; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterVariableInitializerList(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitVariableInitializerList(this);
        }
    }

    [RuleVersion(0)]
    public VariableInitializerListContext variableInitializerList()
    {
        VariableInitializerListContext _localctx = new VariableInitializerListContext(Context, State);
        EnterRule(_localctx, 260, RULE_variableInitializerList);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                State = 1592;
                variableInitializer();
                State = 1597;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 163, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        {
                            {
                                State = 1593;
                                Match(COMMA);
                                State = 1594;
                                variableInitializer();
                            }
                        }
                    }
                    State = 1599;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 163, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class BlockContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java9Parser.LBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java9Parser.RBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public BlockStatementsContext blockStatements()
        {
            return GetRuleContext<BlockStatementsContext>(0);
        }
        public BlockContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_block; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterBlock(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitBlock(this);
        }
    }

    [RuleVersion(0)]
    public BlockContext block()
    {
        BlockContext _localctx = new BlockContext(Context, State);
        EnterRule(_localctx, 262, RULE_block);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1600;
                Match(LBRACE);
                State = 1602;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << ABSTRACT) | (1L << ASSERT) | (1L << BOOLEAN) | (1L << BREAK) | (1L << BYTE) | (1L << CHAR) | (1L << CLASS) | (1L << CONTINUE) | (1L << DO) | (1L << DOUBLE) | (1L << ENUM) | (1L << FINAL) | (1L << FLOAT) | (1L << FOR) | (1L << IF) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << RETURN) | (1L << SHORT) | (1L << STATIC) | (1L << STRICTFP) | (1L << SUPER) | (1L << SWITCH) | (1L << SYNCHRONIZED) | (1L << THIS) | (1L << THROW) | (1L << TRY) | (1L << VOID) | (1L << WHILE) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (LBRACE - 64)) | (1L << (SEMI - 64)) | (1L << (AT - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (Identifier - 64)))) != 0))
                {
                    {
                        State = 1601;
                        blockStatements();
                    }
                }

                State = 1604;
                Match(RBRACE);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class BlockStatementsContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public BlockStatementContext[] blockStatement()
        {
            return GetRuleContexts<BlockStatementContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public BlockStatementContext blockStatement(int i)
        {
            return GetRuleContext<BlockStatementContext>(i);
        }
        public BlockStatementsContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_blockStatements; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterBlockStatements(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitBlockStatements(this);
        }
    }

    [RuleVersion(0)]
    public BlockStatementsContext blockStatements()
    {
        BlockStatementsContext _localctx = new BlockStatementsContext(Context, State);
        EnterRule(_localctx, 264, RULE_blockStatements);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1607;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                do
                {
                    {
                        {
                            State = 1606;
                            blockStatement();
                        }
                    }
                    State = 1609;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                } while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << ABSTRACT) | (1L << ASSERT) | (1L << BOOLEAN) | (1L << BREAK) | (1L << BYTE) | (1L << CHAR) | (1L << CLASS) | (1L << CONTINUE) | (1L << DO) | (1L << DOUBLE) | (1L << ENUM) | (1L << FINAL) | (1L << FLOAT) | (1L << FOR) | (1L << IF) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << PRIVATE) | (1L << PROTECTED) | (1L << PUBLIC) | (1L << RETURN) | (1L << SHORT) | (1L << STATIC) | (1L << STRICTFP) | (1L << SUPER) | (1L << SWITCH) | (1L << SYNCHRONIZED) | (1L << THIS) | (1L << THROW) | (1L << TRY) | (1L << VOID) | (1L << WHILE) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (LBRACE - 64)) | (1L << (SEMI - 64)) | (1L << (AT - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (Identifier - 64)))) != 0));
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class BlockStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public LocalVariableDeclarationStatementContext localVariableDeclarationStatement()
        {
            return GetRuleContext<LocalVariableDeclarationStatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassDeclarationContext classDeclaration()
        {
            return GetRuleContext<ClassDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementContext statement()
        {
            return GetRuleContext<StatementContext>(0);
        }
        public BlockStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_blockStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterBlockStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitBlockStatement(this);
        }
    }

    [RuleVersion(0)]
    public BlockStatementContext blockStatement()
    {
        BlockStatementContext _localctx = new BlockStatementContext(Context, State);
        EnterRule(_localctx, 266, RULE_blockStatement);
        try
        {
            State = 1614;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 166, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1611;
                        localVariableDeclarationStatement();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1612;
                        classDeclaration();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1613;
                        statement();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class LocalVariableDeclarationStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public LocalVariableDeclarationContext localVariableDeclaration()
        {
            return GetRuleContext<LocalVariableDeclarationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        public LocalVariableDeclarationStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_localVariableDeclarationStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterLocalVariableDeclarationStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitLocalVariableDeclarationStatement(this);
        }
    }

    [RuleVersion(0)]
    public LocalVariableDeclarationStatementContext localVariableDeclarationStatement()
    {
        LocalVariableDeclarationStatementContext _localctx = new LocalVariableDeclarationStatementContext(Context, State);
        EnterRule(_localctx, 268, RULE_localVariableDeclarationStatement);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1616;
                localVariableDeclaration();
                State = 1617;
                Match(SEMI);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class LocalVariableDeclarationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannTypeContext unannType()
        {
            return GetRuleContext<UnannTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableDeclaratorListContext variableDeclaratorList()
        {
            return GetRuleContext<VariableDeclaratorListContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableModifierContext[] variableModifier()
        {
            return GetRuleContexts<VariableModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableModifierContext variableModifier(int i)
        {
            return GetRuleContext<VariableModifierContext>(i);
        }
        public LocalVariableDeclarationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_localVariableDeclaration; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterLocalVariableDeclaration(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitLocalVariableDeclaration(this);
        }
    }

    [RuleVersion(0)]
    public LocalVariableDeclarationContext localVariableDeclaration()
    {
        LocalVariableDeclarationContext _localctx = new LocalVariableDeclarationContext(Context, State);
        EnterRule(_localctx, 270, RULE_localVariableDeclaration);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1622;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == FINAL || _la == AT)
                {
                    {
                        {
                            State = 1619;
                            variableModifier();
                        }
                    }
                    State = 1624;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 1625;
                unannType();
                State = 1626;
                variableDeclaratorList();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class StatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementWithoutTrailingSubstatementContext statementWithoutTrailingSubstatement()
        {
            return GetRuleContext<StatementWithoutTrailingSubstatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public LabeledStatementContext labeledStatement()
        {
            return GetRuleContext<LabeledStatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public IfThenStatementContext ifThenStatement()
        {
            return GetRuleContext<IfThenStatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public IfThenElseStatementContext ifThenElseStatement()
        {
            return GetRuleContext<IfThenElseStatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public WhileStatementContext whileStatement()
        {
            return GetRuleContext<WhileStatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ForStatementContext forStatement()
        {
            return GetRuleContext<ForStatementContext>(0);
        }
        public StatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_statement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitStatement(this);
        }
    }

    [RuleVersion(0)]
    public StatementContext statement()
    {
        StatementContext _localctx = new StatementContext(Context, State);
        EnterRule(_localctx, 272, RULE_statement);
        try
        {
            State = 1634;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 168, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1628;
                        statementWithoutTrailingSubstatement();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1629;
                        labeledStatement();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1630;
                        ifThenStatement();
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 1631;
                        ifThenElseStatement();
                    }
                    break;
                case 5:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 1632;
                        whileStatement();
                    }
                    break;
                case 6:
                    EnterOuterAlt(_localctx, 6);
                    {
                        State = 1633;
                        forStatement();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class StatementNoShortIfContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementWithoutTrailingSubstatementContext statementWithoutTrailingSubstatement()
        {
            return GetRuleContext<StatementWithoutTrailingSubstatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public LabeledStatementNoShortIfContext labeledStatementNoShortIf()
        {
            return GetRuleContext<LabeledStatementNoShortIfContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public IfThenElseStatementNoShortIfContext ifThenElseStatementNoShortIf()
        {
            return GetRuleContext<IfThenElseStatementNoShortIfContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public WhileStatementNoShortIfContext whileStatementNoShortIf()
        {
            return GetRuleContext<WhileStatementNoShortIfContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ForStatementNoShortIfContext forStatementNoShortIf()
        {
            return GetRuleContext<ForStatementNoShortIfContext>(0);
        }
        public StatementNoShortIfContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_statementNoShortIf; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterStatementNoShortIf(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitStatementNoShortIf(this);
        }
    }

    [RuleVersion(0)]
    public StatementNoShortIfContext statementNoShortIf()
    {
        StatementNoShortIfContext _localctx = new StatementNoShortIfContext(Context, State);
        EnterRule(_localctx, 274, RULE_statementNoShortIf);
        try
        {
            State = 1641;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 169, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1636;
                        statementWithoutTrailingSubstatement();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1637;
                        labeledStatementNoShortIf();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1638;
                        ifThenElseStatementNoShortIf();
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 1639;
                        whileStatementNoShortIf();
                    }
                    break;
                case 5:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 1640;
                        forStatementNoShortIf();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class StatementWithoutTrailingSubstatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public BlockContext block()
        {
            return GetRuleContext<BlockContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public EmptyStatementContext emptyStatement()
        {
            return GetRuleContext<EmptyStatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionStatementContext expressionStatement()
        {
            return GetRuleContext<ExpressionStatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AssertStatementContext assertStatement()
        {
            return GetRuleContext<AssertStatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public SwitchStatementContext switchStatement()
        {
            return GetRuleContext<SwitchStatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public DoStatementContext doStatement()
        {
            return GetRuleContext<DoStatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public BreakStatementContext breakStatement()
        {
            return GetRuleContext<BreakStatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ContinueStatementContext continueStatement()
        {
            return GetRuleContext<ContinueStatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ReturnStatementContext returnStatement()
        {
            return GetRuleContext<ReturnStatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public SynchronizedStatementContext synchronizedStatement()
        {
            return GetRuleContext<SynchronizedStatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ThrowStatementContext throwStatement()
        {
            return GetRuleContext<ThrowStatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TryStatementContext tryStatement()
        {
            return GetRuleContext<TryStatementContext>(0);
        }
        public StatementWithoutTrailingSubstatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_statementWithoutTrailingSubstatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterStatementWithoutTrailingSubstatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitStatementWithoutTrailingSubstatement(this);
        }
    }

    [RuleVersion(0)]
    public StatementWithoutTrailingSubstatementContext statementWithoutTrailingSubstatement()
    {
        StatementWithoutTrailingSubstatementContext _localctx = new StatementWithoutTrailingSubstatementContext(Context, State);
        EnterRule(_localctx, 276, RULE_statementWithoutTrailingSubstatement);
        try
        {
            State = 1655;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case LBRACE:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1643;
                        block();
                    }
                    break;
                case SEMI:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1644;
                        emptyStatement();
                    }
                    break;
                case T__0:
                case T__1:
                case T__2:
                case T__3:
                case T__4:
                case T__5:
                case T__6:
                case T__7:
                case T__8:
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
                case AT:
                case INC:
                case DEC:
                case Identifier:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1645;
                        expressionStatement();
                    }
                    break;
                case ASSERT:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 1646;
                        assertStatement();
                    }
                    break;
                case SWITCH:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 1647;
                        switchStatement();
                    }
                    break;
                case DO:
                    EnterOuterAlt(_localctx, 6);
                    {
                        State = 1648;
                        doStatement();
                    }
                    break;
                case BREAK:
                    EnterOuterAlt(_localctx, 7);
                    {
                        State = 1649;
                        breakStatement();
                    }
                    break;
                case CONTINUE:
                    EnterOuterAlt(_localctx, 8);
                    {
                        State = 1650;
                        continueStatement();
                    }
                    break;
                case RETURN:
                    EnterOuterAlt(_localctx, 9);
                    {
                        State = 1651;
                        returnStatement();
                    }
                    break;
                case SYNCHRONIZED:
                    EnterOuterAlt(_localctx, 10);
                    {
                        State = 1652;
                        synchronizedStatement();
                    }
                    break;
                case THROW:
                    EnterOuterAlt(_localctx, 11);
                    {
                        State = 1653;
                        throwStatement();
                    }
                    break;
                case TRY:
                    EnterOuterAlt(_localctx, 12);
                    {
                        State = 1654;
                        tryStatement();
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class EmptyStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        public EmptyStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_emptyStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterEmptyStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitEmptyStatement(this);
        }
    }

    [RuleVersion(0)]
    public EmptyStatementContext emptyStatement()
    {
        EmptyStatementContext _localctx = new EmptyStatementContext(Context, State);
        EnterRule(_localctx, 278, RULE_emptyStatement);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1657;
                Match(SEMI);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class LabeledStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(Java9Parser.COLON, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementContext statement()
        {
            return GetRuleContext<StatementContext>(0);
        }
        public LabeledStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_labeledStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterLabeledStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitLabeledStatement(this);
        }
    }

    [RuleVersion(0)]
    public LabeledStatementContext labeledStatement()
    {
        LabeledStatementContext _localctx = new LabeledStatementContext(Context, State);
        EnterRule(_localctx, 280, RULE_labeledStatement);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1659;
                identifier();
                State = 1660;
                Match(COLON);
                State = 1661;
                statement();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class LabeledStatementNoShortIfContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(Java9Parser.COLON, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementNoShortIfContext statementNoShortIf()
        {
            return GetRuleContext<StatementNoShortIfContext>(0);
        }
        public LabeledStatementNoShortIfContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_labeledStatementNoShortIf; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterLabeledStatementNoShortIf(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitLabeledStatementNoShortIf(this);
        }
    }

    [RuleVersion(0)]
    public LabeledStatementNoShortIfContext labeledStatementNoShortIf()
    {
        LabeledStatementNoShortIfContext _localctx = new LabeledStatementNoShortIfContext(Context, State);
        EnterRule(_localctx, 282, RULE_labeledStatementNoShortIf);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1663;
                identifier();
                State = 1664;
                Match(COLON);
                State = 1665;
                statementNoShortIf();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ExpressionStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementExpressionContext statementExpression()
        {
            return GetRuleContext<StatementExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        public ExpressionStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_expressionStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterExpressionStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitExpressionStatement(this);
        }
    }

    [RuleVersion(0)]
    public ExpressionStatementContext expressionStatement()
    {
        ExpressionStatementContext _localctx = new ExpressionStatementContext(Context, State);
        EnterRule(_localctx, 284, RULE_expressionStatement);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1667;
                statementExpression();
                State = 1668;
                Match(SEMI);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class StatementExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public AssignmentContext assignment()
        {
            return GetRuleContext<AssignmentContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PreIncrementExpressionContext preIncrementExpression()
        {
            return GetRuleContext<PreIncrementExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PreDecrementExpressionContext preDecrementExpression()
        {
            return GetRuleContext<PreDecrementExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PostIncrementExpressionContext postIncrementExpression()
        {
            return GetRuleContext<PostIncrementExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PostDecrementExpressionContext postDecrementExpression()
        {
            return GetRuleContext<PostDecrementExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodInvocationContext methodInvocation()
        {
            return GetRuleContext<MethodInvocationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassInstanceCreationExpressionContext classInstanceCreationExpression()
        {
            return GetRuleContext<ClassInstanceCreationExpressionContext>(0);
        }
        public StatementExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_statementExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterStatementExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitStatementExpression(this);
        }
    }

    [RuleVersion(0)]
    public StatementExpressionContext statementExpression()
    {
        StatementExpressionContext _localctx = new StatementExpressionContext(Context, State);
        EnterRule(_localctx, 286, RULE_statementExpression);
        try
        {
            State = 1677;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 171, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1670;
                        assignment();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1671;
                        preIncrementExpression();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1672;
                        preDecrementExpression();
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 1673;
                        postIncrementExpression();
                    }
                    break;
                case 5:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 1674;
                        postDecrementExpression();
                    }
                    break;
                case 6:
                    EnterOuterAlt(_localctx, 6);
                    {
                        State = 1675;
                        methodInvocation();
                    }
                    break;
                case 7:
                    EnterOuterAlt(_localctx, 7);
                    {
                        State = 1676;
                        classInstanceCreationExpression();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class IfThenStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IF() { return GetToken(Java9Parser.IF, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementContext statement()
        {
            return GetRuleContext<StatementContext>(0);
        }
        public IfThenStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_ifThenStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterIfThenStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitIfThenStatement(this);
        }
    }

    [RuleVersion(0)]
    public IfThenStatementContext ifThenStatement()
    {
        IfThenStatementContext _localctx = new IfThenStatementContext(Context, State);
        EnterRule(_localctx, 288, RULE_ifThenStatement);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1679;
                Match(IF);
                State = 1680;
                Match(LPAREN);
                State = 1681;
                expression();
                State = 1682;
                Match(RPAREN);
                State = 1683;
                statement();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class IfThenElseStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IF() { return GetToken(Java9Parser.IF, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementNoShortIfContext statementNoShortIf()
        {
            return GetRuleContext<StatementNoShortIfContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ELSE() { return GetToken(Java9Parser.ELSE, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementContext statement()
        {
            return GetRuleContext<StatementContext>(0);
        }
        public IfThenElseStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_ifThenElseStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterIfThenElseStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitIfThenElseStatement(this);
        }
    }

    [RuleVersion(0)]
    public IfThenElseStatementContext ifThenElseStatement()
    {
        IfThenElseStatementContext _localctx = new IfThenElseStatementContext(Context, State);
        EnterRule(_localctx, 290, RULE_ifThenElseStatement);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1685;
                Match(IF);
                State = 1686;
                Match(LPAREN);
                State = 1687;
                expression();
                State = 1688;
                Match(RPAREN);
                State = 1689;
                statementNoShortIf();
                State = 1690;
                Match(ELSE);
                State = 1691;
                statement();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class IfThenElseStatementNoShortIfContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IF() { return GetToken(Java9Parser.IF, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementNoShortIfContext[] statementNoShortIf()
        {
            return GetRuleContexts<StatementNoShortIfContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementNoShortIfContext statementNoShortIf(int i)
        {
            return GetRuleContext<StatementNoShortIfContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ELSE() { return GetToken(Java9Parser.ELSE, 0); }
        public IfThenElseStatementNoShortIfContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_ifThenElseStatementNoShortIf; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterIfThenElseStatementNoShortIf(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitIfThenElseStatementNoShortIf(this);
        }
    }

    [RuleVersion(0)]
    public IfThenElseStatementNoShortIfContext ifThenElseStatementNoShortIf()
    {
        IfThenElseStatementNoShortIfContext _localctx = new IfThenElseStatementNoShortIfContext(Context, State);
        EnterRule(_localctx, 292, RULE_ifThenElseStatementNoShortIf);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1693;
                Match(IF);
                State = 1694;
                Match(LPAREN);
                State = 1695;
                expression();
                State = 1696;
                Match(RPAREN);
                State = 1697;
                statementNoShortIf();
                State = 1698;
                Match(ELSE);
                State = 1699;
                statementNoShortIf();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class AssertStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSERT() { return GetToken(Java9Parser.ASSERT, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext[] expression()
        {
            return GetRuleContexts<ExpressionContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression(int i)
        {
            return GetRuleContext<ExpressionContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(Java9Parser.COLON, 0); }
        public AssertStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_assertStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterAssertStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitAssertStatement(this);
        }
    }

    [RuleVersion(0)]
    public AssertStatementContext assertStatement()
    {
        AssertStatementContext _localctx = new AssertStatementContext(Context, State);
        EnterRule(_localctx, 294, RULE_assertStatement);
        try
        {
            State = 1711;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 172, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1701;
                        Match(ASSERT);
                        State = 1702;
                        expression();
                        State = 1703;
                        Match(SEMI);
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1705;
                        Match(ASSERT);
                        State = 1706;
                        expression();
                        State = 1707;
                        Match(COLON);
                        State = 1708;
                        expression();
                        State = 1709;
                        Match(SEMI);
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class SwitchStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SWITCH() { return GetToken(Java9Parser.SWITCH, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public SwitchBlockContext switchBlock()
        {
            return GetRuleContext<SwitchBlockContext>(0);
        }
        public SwitchStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_switchStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterSwitchStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitSwitchStatement(this);
        }
    }

    [RuleVersion(0)]
    public SwitchStatementContext switchStatement()
    {
        SwitchStatementContext _localctx = new SwitchStatementContext(Context, State);
        EnterRule(_localctx, 296, RULE_switchStatement);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1713;
                Match(SWITCH);
                State = 1714;
                Match(LPAREN);
                State = 1715;
                expression();
                State = 1716;
                Match(RPAREN);
                State = 1717;
                switchBlock();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class SwitchBlockContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACE() { return GetToken(Java9Parser.LBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACE() { return GetToken(Java9Parser.RBRACE, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public SwitchBlockStatementGroupContext[] switchBlockStatementGroup()
        {
            return GetRuleContexts<SwitchBlockStatementGroupContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public SwitchBlockStatementGroupContext switchBlockStatementGroup(int i)
        {
            return GetRuleContext<SwitchBlockStatementGroupContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public SwitchLabelContext[] switchLabel()
        {
            return GetRuleContexts<SwitchLabelContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public SwitchLabelContext switchLabel(int i)
        {
            return GetRuleContext<SwitchLabelContext>(i);
        }
        public SwitchBlockContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_switchBlock; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterSwitchBlock(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitSwitchBlock(this);
        }
    }

    [RuleVersion(0)]
    public SwitchBlockContext switchBlock()
    {
        SwitchBlockContext _localctx = new SwitchBlockContext(Context, State);
        EnterRule(_localctx, 298, RULE_switchBlock);
        int _la;
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                State = 1719;
                Match(LBRACE);
                State = 1723;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 173, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        {
                            {
                                State = 1720;
                                switchBlockStatementGroup();
                            }
                        }
                    }
                    State = 1725;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 173, Context);
                }
                State = 1729;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == CASE || _la == DEFAULT)
                {
                    {
                        {
                            State = 1726;
                            switchLabel();
                        }
                    }
                    State = 1731;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 1732;
                Match(RBRACE);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class SwitchBlockStatementGroupContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public SwitchLabelsContext switchLabels()
        {
            return GetRuleContext<SwitchLabelsContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public BlockStatementsContext blockStatements()
        {
            return GetRuleContext<BlockStatementsContext>(0);
        }
        public SwitchBlockStatementGroupContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_switchBlockStatementGroup; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterSwitchBlockStatementGroup(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitSwitchBlockStatementGroup(this);
        }
    }

    [RuleVersion(0)]
    public SwitchBlockStatementGroupContext switchBlockStatementGroup()
    {
        SwitchBlockStatementGroupContext _localctx = new SwitchBlockStatementGroupContext(Context, State);
        EnterRule(_localctx, 300, RULE_switchBlockStatementGroup);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1734;
                switchLabels();
                State = 1735;
                blockStatements();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class SwitchLabelsContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public SwitchLabelContext[] switchLabel()
        {
            return GetRuleContexts<SwitchLabelContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public SwitchLabelContext switchLabel(int i)
        {
            return GetRuleContext<SwitchLabelContext>(i);
        }
        public SwitchLabelsContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_switchLabels; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterSwitchLabels(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitSwitchLabels(this);
        }
    }

    [RuleVersion(0)]
    public SwitchLabelsContext switchLabels()
    {
        SwitchLabelsContext _localctx = new SwitchLabelsContext(Context, State);
        EnterRule(_localctx, 302, RULE_switchLabels);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1738;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                do
                {
                    {
                        {
                            State = 1737;
                            switchLabel();
                        }
                    }
                    State = 1740;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                } while (_la == CASE || _la == DEFAULT);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class SwitchLabelContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CASE() { return GetToken(Java9Parser.CASE, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ConstantExpressionContext constantExpression()
        {
            return GetRuleContext<ConstantExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(Java9Parser.COLON, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public EnumConstantNameContext enumConstantName()
        {
            return GetRuleContext<EnumConstantNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFAULT() { return GetToken(Java9Parser.DEFAULT, 0); }
        public SwitchLabelContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_switchLabel; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterSwitchLabel(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitSwitchLabel(this);
        }
    }

    [RuleVersion(0)]
    public SwitchLabelContext switchLabel()
    {
        SwitchLabelContext _localctx = new SwitchLabelContext(Context, State);
        EnterRule(_localctx, 304, RULE_switchLabel);
        try
        {
            State = 1752;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 176, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1742;
                        Match(CASE);
                        State = 1743;
                        constantExpression();
                        State = 1744;
                        Match(COLON);
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1746;
                        Match(CASE);
                        State = 1747;
                        enumConstantName();
                        State = 1748;
                        Match(COLON);
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1750;
                        Match(DEFAULT);
                        State = 1751;
                        Match(COLON);
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class EnumConstantNameContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        public EnumConstantNameContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_enumConstantName; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterEnumConstantName(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitEnumConstantName(this);
        }
    }

    [RuleVersion(0)]
    public EnumConstantNameContext enumConstantName()
    {
        EnumConstantNameContext _localctx = new EnumConstantNameContext(Context, State);
        EnterRule(_localctx, 306, RULE_enumConstantName);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1754;
                identifier();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class WhileStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHILE() { return GetToken(Java9Parser.WHILE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementContext statement()
        {
            return GetRuleContext<StatementContext>(0);
        }
        public WhileStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_whileStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterWhileStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitWhileStatement(this);
        }
    }

    [RuleVersion(0)]
    public WhileStatementContext whileStatement()
    {
        WhileStatementContext _localctx = new WhileStatementContext(Context, State);
        EnterRule(_localctx, 308, RULE_whileStatement);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1756;
                Match(WHILE);
                State = 1757;
                Match(LPAREN);
                State = 1758;
                expression();
                State = 1759;
                Match(RPAREN);
                State = 1760;
                statement();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class WhileStatementNoShortIfContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHILE() { return GetToken(Java9Parser.WHILE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementNoShortIfContext statementNoShortIf()
        {
            return GetRuleContext<StatementNoShortIfContext>(0);
        }
        public WhileStatementNoShortIfContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_whileStatementNoShortIf; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterWhileStatementNoShortIf(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitWhileStatementNoShortIf(this);
        }
    }

    [RuleVersion(0)]
    public WhileStatementNoShortIfContext whileStatementNoShortIf()
    {
        WhileStatementNoShortIfContext _localctx = new WhileStatementNoShortIfContext(Context, State);
        EnterRule(_localctx, 310, RULE_whileStatementNoShortIf);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1762;
                Match(WHILE);
                State = 1763;
                Match(LPAREN);
                State = 1764;
                expression();
                State = 1765;
                Match(RPAREN);
                State = 1766;
                statementNoShortIf();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class DoStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DO() { return GetToken(Java9Parser.DO, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementContext statement()
        {
            return GetRuleContext<StatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHILE() { return GetToken(Java9Parser.WHILE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        public DoStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_doStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterDoStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitDoStatement(this);
        }
    }

    [RuleVersion(0)]
    public DoStatementContext doStatement()
    {
        DoStatementContext _localctx = new DoStatementContext(Context, State);
        EnterRule(_localctx, 312, RULE_doStatement);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1768;
                Match(DO);
                State = 1769;
                statement();
                State = 1770;
                Match(WHILE);
                State = 1771;
                Match(LPAREN);
                State = 1772;
                expression();
                State = 1773;
                Match(RPAREN);
                State = 1774;
                Match(SEMI);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ForStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public BasicForStatementContext basicForStatement()
        {
            return GetRuleContext<BasicForStatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public EnhancedForStatementContext enhancedForStatement()
        {
            return GetRuleContext<EnhancedForStatementContext>(0);
        }
        public ForStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_forStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterForStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitForStatement(this);
        }
    }

    [RuleVersion(0)]
    public ForStatementContext forStatement()
    {
        ForStatementContext _localctx = new ForStatementContext(Context, State);
        EnterRule(_localctx, 314, RULE_forStatement);
        try
        {
            State = 1778;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 177, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1776;
                        basicForStatement();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1777;
                        enhancedForStatement();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ForStatementNoShortIfContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public BasicForStatementNoShortIfContext basicForStatementNoShortIf()
        {
            return GetRuleContext<BasicForStatementNoShortIfContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public EnhancedForStatementNoShortIfContext enhancedForStatementNoShortIf()
        {
            return GetRuleContext<EnhancedForStatementNoShortIfContext>(0);
        }
        public ForStatementNoShortIfContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_forStatementNoShortIf; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterForStatementNoShortIf(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitForStatementNoShortIf(this);
        }
    }

    [RuleVersion(0)]
    public ForStatementNoShortIfContext forStatementNoShortIf()
    {
        ForStatementNoShortIfContext _localctx = new ForStatementNoShortIfContext(Context, State);
        EnterRule(_localctx, 316, RULE_forStatementNoShortIf);
        try
        {
            State = 1782;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 178, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1780;
                        basicForStatementNoShortIf();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1781;
                        enhancedForStatementNoShortIf();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class BasicForStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOR() { return GetToken(Java9Parser.FOR, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SEMI() { return GetTokens(Java9Parser.SEMI); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode SEMI(int i)
        {
            return GetToken(Java9Parser.SEMI, i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementContext statement()
        {
            return GetRuleContext<StatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ForInitContext forInit()
        {
            return GetRuleContext<ForInitContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ForUpdateContext forUpdate()
        {
            return GetRuleContext<ForUpdateContext>(0);
        }
        public BasicForStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_basicForStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterBasicForStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitBasicForStatement(this);
        }
    }

    [RuleVersion(0)]
    public BasicForStatementContext basicForStatement()
    {
        BasicForStatementContext _localctx = new BasicForStatementContext(Context, State);
        EnterRule(_localctx, 318, RULE_basicForStatement);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1784;
                Match(FOR);
                State = 1785;
                Match(LPAREN);
                State = 1787;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FINAL) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (Identifier - 64)))) != 0))
                {
                    {
                        State = 1786;
                        forInit();
                    }
                }

                State = 1789;
                Match(SEMI);
                State = 1791;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                {
                    {
                        State = 1790;
                        expression();
                    }
                }

                State = 1793;
                Match(SEMI);
                State = 1795;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (Identifier - 64)))) != 0))
                {
                    {
                        State = 1794;
                        forUpdate();
                    }
                }

                State = 1797;
                Match(RPAREN);
                State = 1798;
                statement();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class BasicForStatementNoShortIfContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOR() { return GetToken(Java9Parser.FOR, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SEMI() { return GetTokens(Java9Parser.SEMI); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode SEMI(int i)
        {
            return GetToken(Java9Parser.SEMI, i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementNoShortIfContext statementNoShortIf()
        {
            return GetRuleContext<StatementNoShortIfContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ForInitContext forInit()
        {
            return GetRuleContext<ForInitContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ForUpdateContext forUpdate()
        {
            return GetRuleContext<ForUpdateContext>(0);
        }
        public BasicForStatementNoShortIfContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_basicForStatementNoShortIf; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterBasicForStatementNoShortIf(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitBasicForStatementNoShortIf(this);
        }
    }

    [RuleVersion(0)]
    public BasicForStatementNoShortIfContext basicForStatementNoShortIf()
    {
        BasicForStatementNoShortIfContext _localctx = new BasicForStatementNoShortIfContext(Context, State);
        EnterRule(_localctx, 320, RULE_basicForStatementNoShortIf);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1800;
                Match(FOR);
                State = 1801;
                Match(LPAREN);
                State = 1803;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FINAL) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (Identifier - 64)))) != 0))
                {
                    {
                        State = 1802;
                        forInit();
                    }
                }

                State = 1805;
                Match(SEMI);
                State = 1807;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                {
                    {
                        State = 1806;
                        expression();
                    }
                }

                State = 1809;
                Match(SEMI);
                State = 1811;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (Identifier - 64)))) != 0))
                {
                    {
                        State = 1810;
                        forUpdate();
                    }
                }

                State = 1813;
                Match(RPAREN);
                State = 1814;
                statementNoShortIf();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ForInitContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementExpressionListContext statementExpressionList()
        {
            return GetRuleContext<StatementExpressionListContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public LocalVariableDeclarationContext localVariableDeclaration()
        {
            return GetRuleContext<LocalVariableDeclarationContext>(0);
        }
        public ForInitContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_forInit; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterForInit(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitForInit(this);
        }
    }

    [RuleVersion(0)]
    public ForInitContext forInit()
    {
        ForInitContext _localctx = new ForInitContext(Context, State);
        EnterRule(_localctx, 322, RULE_forInit);
        try
        {
            State = 1818;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 185, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1816;
                        statementExpressionList();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1817;
                        localVariableDeclaration();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ForUpdateContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementExpressionListContext statementExpressionList()
        {
            return GetRuleContext<StatementExpressionListContext>(0);
        }
        public ForUpdateContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_forUpdate; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterForUpdate(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitForUpdate(this);
        }
    }

    [RuleVersion(0)]
    public ForUpdateContext forUpdate()
    {
        ForUpdateContext _localctx = new ForUpdateContext(Context, State);
        EnterRule(_localctx, 324, RULE_forUpdate);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1820;
                statementExpressionList();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class StatementExpressionListContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementExpressionContext[] statementExpression()
        {
            return GetRuleContexts<StatementExpressionContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementExpressionContext statementExpression(int i)
        {
            return GetRuleContext<StatementExpressionContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java9Parser.COMMA); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode COMMA(int i)
        {
            return GetToken(Java9Parser.COMMA, i);
        }
        public StatementExpressionListContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_statementExpressionList; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterStatementExpressionList(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitStatementExpressionList(this);
        }
    }

    [RuleVersion(0)]
    public StatementExpressionListContext statementExpressionList()
    {
        StatementExpressionListContext _localctx = new StatementExpressionListContext(Context, State);
        EnterRule(_localctx, 326, RULE_statementExpressionList);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1822;
                statementExpression();
                State = 1827;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == COMMA)
                {
                    {
                        {
                            State = 1823;
                            Match(COMMA);
                            State = 1824;
                            statementExpression();
                        }
                    }
                    State = 1829;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class EnhancedForStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOR() { return GetToken(Java9Parser.FOR, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannTypeContext unannType()
        {
            return GetRuleContext<UnannTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableDeclaratorIdContext variableDeclaratorId()
        {
            return GetRuleContext<VariableDeclaratorIdContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(Java9Parser.COLON, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementContext statement()
        {
            return GetRuleContext<StatementContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableModifierContext[] variableModifier()
        {
            return GetRuleContexts<VariableModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableModifierContext variableModifier(int i)
        {
            return GetRuleContext<VariableModifierContext>(i);
        }
        public EnhancedForStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_enhancedForStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterEnhancedForStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitEnhancedForStatement(this);
        }
    }

    [RuleVersion(0)]
    public EnhancedForStatementContext enhancedForStatement()
    {
        EnhancedForStatementContext _localctx = new EnhancedForStatementContext(Context, State);
        EnterRule(_localctx, 328, RULE_enhancedForStatement);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1830;
                Match(FOR);
                State = 1831;
                Match(LPAREN);
                State = 1835;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == FINAL || _la == AT)
                {
                    {
                        {
                            State = 1832;
                            variableModifier();
                        }
                    }
                    State = 1837;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 1838;
                unannType();
                State = 1839;
                variableDeclaratorId();
                State = 1840;
                Match(COLON);
                State = 1841;
                expression();
                State = 1842;
                Match(RPAREN);
                State = 1843;
                statement();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class EnhancedForStatementNoShortIfContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOR() { return GetToken(Java9Parser.FOR, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannTypeContext unannType()
        {
            return GetRuleContext<UnannTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableDeclaratorIdContext variableDeclaratorId()
        {
            return GetRuleContext<VariableDeclaratorIdContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(Java9Parser.COLON, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public StatementNoShortIfContext statementNoShortIf()
        {
            return GetRuleContext<StatementNoShortIfContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableModifierContext[] variableModifier()
        {
            return GetRuleContexts<VariableModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableModifierContext variableModifier(int i)
        {
            return GetRuleContext<VariableModifierContext>(i);
        }
        public EnhancedForStatementNoShortIfContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_enhancedForStatementNoShortIf; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterEnhancedForStatementNoShortIf(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitEnhancedForStatementNoShortIf(this);
        }
    }

    [RuleVersion(0)]
    public EnhancedForStatementNoShortIfContext enhancedForStatementNoShortIf()
    {
        EnhancedForStatementNoShortIfContext _localctx = new EnhancedForStatementNoShortIfContext(Context, State);
        EnterRule(_localctx, 330, RULE_enhancedForStatementNoShortIf);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1845;
                Match(FOR);
                State = 1846;
                Match(LPAREN);
                State = 1850;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == FINAL || _la == AT)
                {
                    {
                        {
                            State = 1847;
                            variableModifier();
                        }
                    }
                    State = 1852;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 1853;
                unannType();
                State = 1854;
                variableDeclaratorId();
                State = 1855;
                Match(COLON);
                State = 1856;
                expression();
                State = 1857;
                Match(RPAREN);
                State = 1858;
                statementNoShortIf();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class BreakStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BREAK() { return GetToken(Java9Parser.BREAK, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        public BreakStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_breakStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterBreakStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitBreakStatement(this);
        }
    }

    [RuleVersion(0)]
    public BreakStatementContext breakStatement()
    {
        BreakStatementContext _localctx = new BreakStatementContext(Context, State);
        EnterRule(_localctx, 332, RULE_breakStatement);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1860;
                Match(BREAK);
                State = 1862;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8))) != 0) || _la == Identifier)
                {
                    {
                        State = 1861;
                        identifier();
                    }
                }

                State = 1864;
                Match(SEMI);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ContinueStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CONTINUE() { return GetToken(Java9Parser.CONTINUE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        public ContinueStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_continueStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterContinueStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitContinueStatement(this);
        }
    }

    [RuleVersion(0)]
    public ContinueStatementContext continueStatement()
    {
        ContinueStatementContext _localctx = new ContinueStatementContext(Context, State);
        EnterRule(_localctx, 334, RULE_continueStatement);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1866;
                Match(CONTINUE);
                State = 1868;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8))) != 0) || _la == Identifier)
                {
                    {
                        State = 1867;
                        identifier();
                    }
                }

                State = 1870;
                Match(SEMI);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ReturnStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RETURN() { return GetToken(Java9Parser.RETURN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        public ReturnStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_returnStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterReturnStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitReturnStatement(this);
        }
    }

    [RuleVersion(0)]
    public ReturnStatementContext returnStatement()
    {
        ReturnStatementContext _localctx = new ReturnStatementContext(Context, State);
        EnterRule(_localctx, 336, RULE_returnStatement);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1872;
                Match(RETURN);
                State = 1874;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                {
                    {
                        State = 1873;
                        expression();
                    }
                }

                State = 1876;
                Match(SEMI);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ThrowStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THROW() { return GetToken(Java9Parser.THROW, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        public ThrowStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_throwStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterThrowStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitThrowStatement(this);
        }
    }

    [RuleVersion(0)]
    public ThrowStatementContext throwStatement()
    {
        ThrowStatementContext _localctx = new ThrowStatementContext(Context, State);
        EnterRule(_localctx, 338, RULE_throwStatement);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1878;
                Match(THROW);
                State = 1879;
                expression();
                State = 1880;
                Match(SEMI);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class SynchronizedStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SYNCHRONIZED() { return GetToken(Java9Parser.SYNCHRONIZED, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public BlockContext block()
        {
            return GetRuleContext<BlockContext>(0);
        }
        public SynchronizedStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_synchronizedStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterSynchronizedStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitSynchronizedStatement(this);
        }
    }

    [RuleVersion(0)]
    public SynchronizedStatementContext synchronizedStatement()
    {
        SynchronizedStatementContext _localctx = new SynchronizedStatementContext(Context, State);
        EnterRule(_localctx, 340, RULE_synchronizedStatement);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1882;
                Match(SYNCHRONIZED);
                State = 1883;
                Match(LPAREN);
                State = 1884;
                expression();
                State = 1885;
                Match(RPAREN);
                State = 1886;
                block();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class TryStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRY() { return GetToken(Java9Parser.TRY, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public BlockContext block()
        {
            return GetRuleContext<BlockContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public CatchesContext catches()
        {
            return GetRuleContext<CatchesContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public Finally_Context finally_()
        {
            return GetRuleContext<Finally_Context>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TryWithResourcesStatementContext tryWithResourcesStatement()
        {
            return GetRuleContext<TryWithResourcesStatementContext>(0);
        }
        public TryStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_tryStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterTryStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitTryStatement(this);
        }
    }

    [RuleVersion(0)]
    public TryStatementContext tryStatement()
    {
        TryStatementContext _localctx = new TryStatementContext(Context, State);
        EnterRule(_localctx, 342, RULE_tryStatement);
        int _la;
        try
        {
            State = 1900;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 193, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1888;
                        Match(TRY);
                        State = 1889;
                        block();
                        State = 1890;
                        catches();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1892;
                        Match(TRY);
                        State = 1893;
                        block();
                        State = 1895;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == CATCH)
                        {
                            {
                                State = 1894;
                                catches();
                            }
                        }

                        State = 1897;
                        finally_();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1899;
                        tryWithResourcesStatement();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class CatchesContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public CatchClauseContext[] catchClause()
        {
            return GetRuleContexts<CatchClauseContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public CatchClauseContext catchClause(int i)
        {
            return GetRuleContext<CatchClauseContext>(i);
        }
        public CatchesContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_catches; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterCatches(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitCatches(this);
        }
    }

    [RuleVersion(0)]
    public CatchesContext catches()
    {
        CatchesContext _localctx = new CatchesContext(Context, State);
        EnterRule(_localctx, 344, RULE_catches);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1903;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                do
                {
                    {
                        {
                            State = 1902;
                            catchClause();
                        }
                    }
                    State = 1905;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                } while (_la == CATCH);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class CatchClauseContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CATCH() { return GetToken(Java9Parser.CATCH, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public CatchFormalParameterContext catchFormalParameter()
        {
            return GetRuleContext<CatchFormalParameterContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public BlockContext block()
        {
            return GetRuleContext<BlockContext>(0);
        }
        public CatchClauseContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_catchClause; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterCatchClause(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitCatchClause(this);
        }
    }

    [RuleVersion(0)]
    public CatchClauseContext catchClause()
    {
        CatchClauseContext _localctx = new CatchClauseContext(Context, State);
        EnterRule(_localctx, 346, RULE_catchClause);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1907;
                Match(CATCH);
                State = 1908;
                Match(LPAREN);
                State = 1909;
                catchFormalParameter();
                State = 1910;
                Match(RPAREN);
                State = 1911;
                block();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class CatchFormalParameterContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public CatchTypeContext catchType()
        {
            return GetRuleContext<CatchTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableDeclaratorIdContext variableDeclaratorId()
        {
            return GetRuleContext<VariableDeclaratorIdContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableModifierContext[] variableModifier()
        {
            return GetRuleContexts<VariableModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableModifierContext variableModifier(int i)
        {
            return GetRuleContext<VariableModifierContext>(i);
        }
        public CatchFormalParameterContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_catchFormalParameter; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterCatchFormalParameter(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitCatchFormalParameter(this);
        }
    }

    [RuleVersion(0)]
    public CatchFormalParameterContext catchFormalParameter()
    {
        CatchFormalParameterContext _localctx = new CatchFormalParameterContext(Context, State);
        EnterRule(_localctx, 348, RULE_catchFormalParameter);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1916;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == FINAL || _la == AT)
                {
                    {
                        {
                            State = 1913;
                            variableModifier();
                        }
                    }
                    State = 1918;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 1919;
                catchType();
                State = 1920;
                variableDeclaratorId();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class CatchTypeContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannClassTypeContext unannClassType()
        {
            return GetRuleContext<UnannClassTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] BITOR() { return GetTokens(Java9Parser.BITOR); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode BITOR(int i)
        {
            return GetToken(Java9Parser.BITOR, i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassTypeContext[] classType()
        {
            return GetRuleContexts<ClassTypeContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassTypeContext classType(int i)
        {
            return GetRuleContext<ClassTypeContext>(i);
        }
        public CatchTypeContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_catchType; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterCatchType(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitCatchType(this);
        }
    }

    [RuleVersion(0)]
    public CatchTypeContext catchType()
    {
        CatchTypeContext _localctx = new CatchTypeContext(Context, State);
        EnterRule(_localctx, 350, RULE_catchType);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1922;
                unannClassType();
                State = 1927;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == BITOR)
                {
                    {
                        {
                            State = 1923;
                            Match(BITOR);
                            State = 1924;
                            classType();
                        }
                    }
                    State = 1929;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class Finally_Context : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FINALLY() { return GetToken(Java9Parser.FINALLY, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public BlockContext block()
        {
            return GetRuleContext<BlockContext>(0);
        }
        public Finally_Context(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_finally_; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterFinally_(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitFinally_(this);
        }
    }

    [RuleVersion(0)]
    public Finally_Context finally_()
    {
        Finally_Context _localctx = new Finally_Context(Context, State);
        EnterRule(_localctx, 352, RULE_finally_);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1930;
                Match(FINALLY);
                State = 1931;
                block();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class TryWithResourcesStatementContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRY() { return GetToken(Java9Parser.TRY, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ResourceSpecificationContext resourceSpecification()
        {
            return GetRuleContext<ResourceSpecificationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public BlockContext block()
        {
            return GetRuleContext<BlockContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public CatchesContext catches()
        {
            return GetRuleContext<CatchesContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public Finally_Context finally_()
        {
            return GetRuleContext<Finally_Context>(0);
        }
        public TryWithResourcesStatementContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_tryWithResourcesStatement; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterTryWithResourcesStatement(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitTryWithResourcesStatement(this);
        }
    }

    [RuleVersion(0)]
    public TryWithResourcesStatementContext tryWithResourcesStatement()
    {
        TryWithResourcesStatementContext _localctx = new TryWithResourcesStatementContext(Context, State);
        EnterRule(_localctx, 354, RULE_tryWithResourcesStatement);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1933;
                Match(TRY);
                State = 1934;
                resourceSpecification();
                State = 1935;
                block();
                State = 1937;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == CATCH)
                {
                    {
                        State = 1936;
                        catches();
                    }
                }

                State = 1940;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == FINALLY)
                {
                    {
                        State = 1939;
                        finally_();
                    }
                }

            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ResourceSpecificationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ResourceListContext resourceList()
        {
            return GetRuleContext<ResourceListContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMI() { return GetToken(Java9Parser.SEMI, 0); }
        public ResourceSpecificationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_resourceSpecification; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterResourceSpecification(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitResourceSpecification(this);
        }
    }

    [RuleVersion(0)]
    public ResourceSpecificationContext resourceSpecification()
    {
        ResourceSpecificationContext _localctx = new ResourceSpecificationContext(Context, State);
        EnterRule(_localctx, 356, RULE_resourceSpecification);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 1942;
                Match(LPAREN);
                State = 1943;
                resourceList();
                State = 1945;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == SEMI)
                {
                    {
                        State = 1944;
                        Match(SEMI);
                    }
                }

                State = 1947;
                Match(RPAREN);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ResourceListContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ResourceContext[] resource()
        {
            return GetRuleContexts<ResourceContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ResourceContext resource(int i)
        {
            return GetRuleContext<ResourceContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SEMI() { return GetTokens(Java9Parser.SEMI); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode SEMI(int i)
        {
            return GetToken(Java9Parser.SEMI, i);
        }
        public ResourceListContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_resourceList; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterResourceList(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitResourceList(this);
        }
    }

    [RuleVersion(0)]
    public ResourceListContext resourceList()
    {
        ResourceListContext _localctx = new ResourceListContext(Context, State);
        EnterRule(_localctx, 358, RULE_resourceList);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                State = 1949;
                resource();
                State = 1954;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 200, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        {
                            {
                                State = 1950;
                                Match(SEMI);
                                State = 1951;
                                resource();
                            }
                        }
                    }
                    State = 1956;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 200, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ResourceContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannTypeContext unannType()
        {
            return GetRuleContext<UnannTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableDeclaratorIdContext variableDeclaratorId()
        {
            return GetRuleContext<VariableDeclaratorIdContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGN() { return GetToken(Java9Parser.ASSIGN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableModifierContext[] variableModifier()
        {
            return GetRuleContexts<VariableModifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableModifierContext variableModifier(int i)
        {
            return GetRuleContext<VariableModifierContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public VariableAccessContext variableAccess()
        {
            return GetRuleContext<VariableAccessContext>(0);
        }
        public ResourceContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_resource; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterResource(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitResource(this);
        }
    }

    [RuleVersion(0)]
    public ResourceContext resource()
    {
        ResourceContext _localctx = new ResourceContext(Context, State);
        EnterRule(_localctx, 360, RULE_resource);
        int _la;
        try
        {
            State = 1969;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 202, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1960;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == FINAL || _la == AT)
                        {
                            {
                                {
                                    State = 1957;
                                    variableModifier();
                                }
                            }
                            State = 1962;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 1963;
                        unannType();
                        State = 1964;
                        variableDeclaratorId();
                        State = 1965;
                        Match(ASSIGN);
                        State = 1966;
                        expression();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1968;
                        variableAccess();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class VariableAccessContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionNameContext expressionName()
        {
            return GetRuleContext<ExpressionNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public FieldAccessContext fieldAccess()
        {
            return GetRuleContext<FieldAccessContext>(0);
        }
        public VariableAccessContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_variableAccess; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterVariableAccess(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitVariableAccess(this);
        }
    }

    [RuleVersion(0)]
    public VariableAccessContext variableAccess()
    {
        VariableAccessContext _localctx = new VariableAccessContext(Context, State);
        EnterRule(_localctx, 362, RULE_variableAccess);
        try
        {
            State = 1973;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 203, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1971;
                        expressionName();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1972;
                        fieldAccess();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PrimaryContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimaryNoNewArray_lfno_primaryContext primaryNoNewArray_lfno_primary()
        {
            return GetRuleContext<PrimaryNoNewArray_lfno_primaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ArrayCreationExpressionContext arrayCreationExpression()
        {
            return GetRuleContext<ArrayCreationExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimaryNoNewArray_lf_primaryContext[] primaryNoNewArray_lf_primary()
        {
            return GetRuleContexts<PrimaryNoNewArray_lf_primaryContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimaryNoNewArray_lf_primaryContext primaryNoNewArray_lf_primary(int i)
        {
            return GetRuleContext<PrimaryNoNewArray_lf_primaryContext>(i);
        }
        public PrimaryContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_primary; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPrimary(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPrimary(this);
        }
    }

    [RuleVersion(0)]
    public PrimaryContext primary()
    {
        PrimaryContext _localctx = new PrimaryContext(Context, State);
        EnterRule(_localctx, 364, RULE_primary);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                State = 1977;
                ErrorHandler.Sync(this);
                switch (Interpreter.AdaptivePredict(TokenStream, 204, Context))
                {
                    case 1:
                        {
                            State = 1975;
                            primaryNoNewArray_lfno_primary();
                        }
                        break;
                    case 2:
                        {
                            State = 1976;
                            arrayCreationExpression();
                        }
                        break;
                }
                State = 1982;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 205, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        {
                            {
                                State = 1979;
                                primaryNoNewArray_lf_primary();
                            }
                        }
                    }
                    State = 1984;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 205, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PrimaryNoNewArrayContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public LiteralContext literal()
        {
            return GetRuleContext<LiteralContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassLiteralContext classLiteral()
        {
            return GetRuleContext<ClassLiteralContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THIS() { return GetToken(Java9Parser.THIS, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext typeName()
        {
            return GetRuleContext<TypeNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassInstanceCreationExpressionContext classInstanceCreationExpression()
        {
            return GetRuleContext<ClassInstanceCreationExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public FieldAccessContext fieldAccess()
        {
            return GetRuleContext<FieldAccessContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ArrayAccessContext arrayAccess()
        {
            return GetRuleContext<ArrayAccessContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodInvocationContext methodInvocation()
        {
            return GetRuleContext<MethodInvocationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodReferenceContext methodReference()
        {
            return GetRuleContext<MethodReferenceContext>(0);
        }
        public PrimaryNoNewArrayContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_primaryNoNewArray; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPrimaryNoNewArray(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPrimaryNoNewArray(this);
        }
    }

    [RuleVersion(0)]
    public PrimaryNoNewArrayContext primaryNoNewArray()
    {
        PrimaryNoNewArrayContext _localctx = new PrimaryNoNewArrayContext(Context, State);
        EnterRule(_localctx, 366, RULE_primaryNoNewArray);
        try
        {
            State = 2001;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 206, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 1985;
                        literal();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 1986;
                        classLiteral();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 1987;
                        Match(THIS);
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 1988;
                        typeName();
                        State = 1989;
                        Match(DOT);
                        State = 1990;
                        Match(THIS);
                    }
                    break;
                case 5:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 1992;
                        Match(LPAREN);
                        State = 1993;
                        expression();
                        State = 1994;
                        Match(RPAREN);
                    }
                    break;
                case 6:
                    EnterOuterAlt(_localctx, 6);
                    {
                        State = 1996;
                        classInstanceCreationExpression();
                    }
                    break;
                case 7:
                    EnterOuterAlt(_localctx, 7);
                    {
                        State = 1997;
                        fieldAccess();
                    }
                    break;
                case 8:
                    EnterOuterAlt(_localctx, 8);
                    {
                        State = 1998;
                        arrayAccess();
                    }
                    break;
                case 9:
                    EnterOuterAlt(_localctx, 9);
                    {
                        State = 1999;
                        methodInvocation();
                    }
                    break;
                case 10:
                    EnterOuterAlt(_localctx, 10);
                    {
                        State = 2000;
                        methodReference();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PrimaryNoNewArray_lf_arrayAccessContext : ParserRuleContext
    {
        public PrimaryNoNewArray_lf_arrayAccessContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_primaryNoNewArray_lf_arrayAccess; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPrimaryNoNewArray_lf_arrayAccess(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPrimaryNoNewArray_lf_arrayAccess(this);
        }
    }

    [RuleVersion(0)]
    public PrimaryNoNewArray_lf_arrayAccessContext primaryNoNewArray_lf_arrayAccess()
    {
        PrimaryNoNewArray_lf_arrayAccessContext _localctx = new PrimaryNoNewArray_lf_arrayAccessContext(Context, State);
        EnterRule(_localctx, 368, RULE_primaryNoNewArray_lf_arrayAccess);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PrimaryNoNewArray_lfno_arrayAccessContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public LiteralContext literal()
        {
            return GetRuleContext<LiteralContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext typeName()
        {
            return GetRuleContext<TypeNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLASS() { return GetToken(Java9Parser.CLASS, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LBRACK() { return GetTokens(Java9Parser.LBRACK); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode LBRACK(int i)
        {
            return GetToken(Java9Parser.LBRACK, i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RBRACK() { return GetTokens(Java9Parser.RBRACK); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode RBRACK(int i)
        {
            return GetToken(Java9Parser.RBRACK, i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOID() { return GetToken(Java9Parser.VOID, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THIS() { return GetToken(Java9Parser.THIS, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassInstanceCreationExpressionContext classInstanceCreationExpression()
        {
            return GetRuleContext<ClassInstanceCreationExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public FieldAccessContext fieldAccess()
        {
            return GetRuleContext<FieldAccessContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodInvocationContext methodInvocation()
        {
            return GetRuleContext<MethodInvocationContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodReferenceContext methodReference()
        {
            return GetRuleContext<MethodReferenceContext>(0);
        }
        public PrimaryNoNewArray_lfno_arrayAccessContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_primaryNoNewArray_lfno_arrayAccess; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPrimaryNoNewArray_lfno_arrayAccess(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPrimaryNoNewArray_lfno_arrayAccess(this);
        }
    }

    [RuleVersion(0)]
    public PrimaryNoNewArray_lfno_arrayAccessContext primaryNoNewArray_lfno_arrayAccess()
    {
        PrimaryNoNewArray_lfno_arrayAccessContext _localctx = new PrimaryNoNewArray_lfno_arrayAccessContext(Context, State);
        EnterRule(_localctx, 370, RULE_primaryNoNewArray_lfno_arrayAccess);
        int _la;
        try
        {
            State = 2033;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 208, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2005;
                        literal();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2006;
                        typeName();
                        State = 2011;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == LBRACK)
                        {
                            {
                                {
                                    State = 2007;
                                    Match(LBRACK);
                                    State = 2008;
                                    Match(RBRACK);
                                }
                            }
                            State = 2013;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 2014;
                        Match(DOT);
                        State = 2015;
                        Match(CLASS);
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 2017;
                        Match(VOID);
                        State = 2018;
                        Match(DOT);
                        State = 2019;
                        Match(CLASS);
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 2020;
                        Match(THIS);
                    }
                    break;
                case 5:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 2021;
                        typeName();
                        State = 2022;
                        Match(DOT);
                        State = 2023;
                        Match(THIS);
                    }
                    break;
                case 6:
                    EnterOuterAlt(_localctx, 6);
                    {
                        State = 2025;
                        Match(LPAREN);
                        State = 2026;
                        expression();
                        State = 2027;
                        Match(RPAREN);
                    }
                    break;
                case 7:
                    EnterOuterAlt(_localctx, 7);
                    {
                        State = 2029;
                        classInstanceCreationExpression();
                    }
                    break;
                case 8:
                    EnterOuterAlt(_localctx, 8);
                    {
                        State = 2030;
                        fieldAccess();
                    }
                    break;
                case 9:
                    EnterOuterAlt(_localctx, 9);
                    {
                        State = 2031;
                        methodInvocation();
                    }
                    break;
                case 10:
                    EnterOuterAlt(_localctx, 10);
                    {
                        State = 2032;
                        methodReference();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PrimaryNoNewArray_lf_primaryContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassInstanceCreationExpression_lf_primaryContext classInstanceCreationExpression_lf_primary()
        {
            return GetRuleContext<ClassInstanceCreationExpression_lf_primaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public FieldAccess_lf_primaryContext fieldAccess_lf_primary()
        {
            return GetRuleContext<FieldAccess_lf_primaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ArrayAccess_lf_primaryContext arrayAccess_lf_primary()
        {
            return GetRuleContext<ArrayAccess_lf_primaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodInvocation_lf_primaryContext methodInvocation_lf_primary()
        {
            return GetRuleContext<MethodInvocation_lf_primaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodReference_lf_primaryContext methodReference_lf_primary()
        {
            return GetRuleContext<MethodReference_lf_primaryContext>(0);
        }
        public PrimaryNoNewArray_lf_primaryContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_primaryNoNewArray_lf_primary; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPrimaryNoNewArray_lf_primary(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPrimaryNoNewArray_lf_primary(this);
        }
    }

    [RuleVersion(0)]
    public PrimaryNoNewArray_lf_primaryContext primaryNoNewArray_lf_primary()
    {
        PrimaryNoNewArray_lf_primaryContext _localctx = new PrimaryNoNewArray_lf_primaryContext(Context, State);
        EnterRule(_localctx, 372, RULE_primaryNoNewArray_lf_primary);
        try
        {
            State = 2040;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 209, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2035;
                        classInstanceCreationExpression_lf_primary();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2036;
                        fieldAccess_lf_primary();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 2037;
                        arrayAccess_lf_primary();
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 2038;
                        methodInvocation_lf_primary();
                    }
                    break;
                case 5:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 2039;
                        methodReference_lf_primary();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext : ParserRuleContext
    {
        public PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary(this);
        }
    }

    [RuleVersion(0)]
    public PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary()
    {
        PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext _localctx = new PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext(Context, State);
        EnterRule(_localctx, 374, RULE_primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassInstanceCreationExpression_lf_primaryContext classInstanceCreationExpression_lf_primary()
        {
            return GetRuleContext<ClassInstanceCreationExpression_lf_primaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public FieldAccess_lf_primaryContext fieldAccess_lf_primary()
        {
            return GetRuleContext<FieldAccess_lf_primaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodInvocation_lf_primaryContext methodInvocation_lf_primary()
        {
            return GetRuleContext<MethodInvocation_lf_primaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodReference_lf_primaryContext methodReference_lf_primary()
        {
            return GetRuleContext<MethodReference_lf_primaryContext>(0);
        }
        public PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary(this);
        }
    }

    [RuleVersion(0)]
    public PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary()
    {
        PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext _localctx = new PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext(Context, State);
        EnterRule(_localctx, 376, RULE_primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary);
        try
        {
            State = 2048;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 210, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2044;
                        classInstanceCreationExpression_lf_primary();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2045;
                        fieldAccess_lf_primary();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 2046;
                        methodInvocation_lf_primary();
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 2047;
                        methodReference_lf_primary();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PrimaryNoNewArray_lfno_primaryContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public LiteralContext literal()
        {
            return GetRuleContext<LiteralContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext typeName()
        {
            return GetRuleContext<TypeNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLASS() { return GetToken(Java9Parser.CLASS, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LBRACK() { return GetTokens(Java9Parser.LBRACK); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode LBRACK(int i)
        {
            return GetToken(Java9Parser.LBRACK, i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RBRACK() { return GetTokens(Java9Parser.RBRACK); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode RBRACK(int i)
        {
            return GetToken(Java9Parser.RBRACK, i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannPrimitiveTypeContext unannPrimitiveType()
        {
            return GetRuleContext<UnannPrimitiveTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOID() { return GetToken(Java9Parser.VOID, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THIS() { return GetToken(Java9Parser.THIS, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassInstanceCreationExpression_lfno_primaryContext classInstanceCreationExpression_lfno_primary()
        {
            return GetRuleContext<ClassInstanceCreationExpression_lfno_primaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public FieldAccess_lfno_primaryContext fieldAccess_lfno_primary()
        {
            return GetRuleContext<FieldAccess_lfno_primaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ArrayAccess_lfno_primaryContext arrayAccess_lfno_primary()
        {
            return GetRuleContext<ArrayAccess_lfno_primaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodInvocation_lfno_primaryContext methodInvocation_lfno_primary()
        {
            return GetRuleContext<MethodInvocation_lfno_primaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodReference_lfno_primaryContext methodReference_lfno_primary()
        {
            return GetRuleContext<MethodReference_lfno_primaryContext>(0);
        }
        public PrimaryNoNewArray_lfno_primaryContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_primaryNoNewArray_lfno_primary; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPrimaryNoNewArray_lfno_primary(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPrimaryNoNewArray_lfno_primary(this);
        }
    }

    [RuleVersion(0)]
    public PrimaryNoNewArray_lfno_primaryContext primaryNoNewArray_lfno_primary()
    {
        PrimaryNoNewArray_lfno_primaryContext _localctx = new PrimaryNoNewArray_lfno_primaryContext(Context, State);
        EnterRule(_localctx, 378, RULE_primaryNoNewArray_lfno_primary);
        int _la;
        try
        {
            State = 2090;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 213, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2050;
                        literal();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2051;
                        typeName();
                        State = 2056;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == LBRACK)
                        {
                            {
                                {
                                    State = 2052;
                                    Match(LBRACK);
                                    State = 2053;
                                    Match(RBRACK);
                                }
                            }
                            State = 2058;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 2059;
                        Match(DOT);
                        State = 2060;
                        Match(CLASS);
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 2062;
                        unannPrimitiveType();
                        State = 2067;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == LBRACK)
                        {
                            {
                                {
                                    State = 2063;
                                    Match(LBRACK);
                                    State = 2064;
                                    Match(RBRACK);
                                }
                            }
                            State = 2069;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 2070;
                        Match(DOT);
                        State = 2071;
                        Match(CLASS);
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 2073;
                        Match(VOID);
                        State = 2074;
                        Match(DOT);
                        State = 2075;
                        Match(CLASS);
                    }
                    break;
                case 5:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 2076;
                        Match(THIS);
                    }
                    break;
                case 6:
                    EnterOuterAlt(_localctx, 6);
                    {
                        State = 2077;
                        typeName();
                        State = 2078;
                        Match(DOT);
                        State = 2079;
                        Match(THIS);
                    }
                    break;
                case 7:
                    EnterOuterAlt(_localctx, 7);
                    {
                        State = 2081;
                        Match(LPAREN);
                        State = 2082;
                        expression();
                        State = 2083;
                        Match(RPAREN);
                    }
                    break;
                case 8:
                    EnterOuterAlt(_localctx, 8);
                    {
                        State = 2085;
                        classInstanceCreationExpression_lfno_primary();
                    }
                    break;
                case 9:
                    EnterOuterAlt(_localctx, 9);
                    {
                        State = 2086;
                        fieldAccess_lfno_primary();
                    }
                    break;
                case 10:
                    EnterOuterAlt(_localctx, 10);
                    {
                        State = 2087;
                        arrayAccess_lfno_primary();
                    }
                    break;
                case 11:
                    EnterOuterAlt(_localctx, 11);
                    {
                        State = 2088;
                        methodInvocation_lfno_primary();
                    }
                    break;
                case 12:
                    EnterOuterAlt(_localctx, 12);
                    {
                        State = 2089;
                        methodReference_lfno_primary();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext : ParserRuleContext
    {
        public PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary(this);
        }
    }

    [RuleVersion(0)]
    public PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary()
    {
        PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext _localctx = new PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext(Context, State);
        EnterRule(_localctx, 380, RULE_primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public LiteralContext literal()
        {
            return GetRuleContext<LiteralContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext typeName()
        {
            return GetRuleContext<TypeNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLASS() { return GetToken(Java9Parser.CLASS, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LBRACK() { return GetTokens(Java9Parser.LBRACK); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode LBRACK(int i)
        {
            return GetToken(Java9Parser.LBRACK, i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RBRACK() { return GetTokens(Java9Parser.RBRACK); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode RBRACK(int i)
        {
            return GetToken(Java9Parser.RBRACK, i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnannPrimitiveTypeContext unannPrimitiveType()
        {
            return GetRuleContext<UnannPrimitiveTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOID() { return GetToken(Java9Parser.VOID, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THIS() { return GetToken(Java9Parser.THIS, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassInstanceCreationExpression_lfno_primaryContext classInstanceCreationExpression_lfno_primary()
        {
            return GetRuleContext<ClassInstanceCreationExpression_lfno_primaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public FieldAccess_lfno_primaryContext fieldAccess_lfno_primary()
        {
            return GetRuleContext<FieldAccess_lfno_primaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodInvocation_lfno_primaryContext methodInvocation_lfno_primary()
        {
            return GetRuleContext<MethodInvocation_lfno_primaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodReference_lfno_primaryContext methodReference_lfno_primary()
        {
            return GetRuleContext<MethodReference_lfno_primaryContext>(0);
        }
        public PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary(this);
        }
    }

    [RuleVersion(0)]
    public PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary()
    {
        PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext _localctx = new PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext(Context, State);
        EnterRule(_localctx, 382, RULE_primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary);
        int _la;
        try
        {
            State = 2133;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 216, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2094;
                        literal();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2095;
                        typeName();
                        State = 2100;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == LBRACK)
                        {
                            {
                                {
                                    State = 2096;
                                    Match(LBRACK);
                                    State = 2097;
                                    Match(RBRACK);
                                }
                            }
                            State = 2102;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 2103;
                        Match(DOT);
                        State = 2104;
                        Match(CLASS);
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 2106;
                        unannPrimitiveType();
                        State = 2111;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == LBRACK)
                        {
                            {
                                {
                                    State = 2107;
                                    Match(LBRACK);
                                    State = 2108;
                                    Match(RBRACK);
                                }
                            }
                            State = 2113;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 2114;
                        Match(DOT);
                        State = 2115;
                        Match(CLASS);
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 2117;
                        Match(VOID);
                        State = 2118;
                        Match(DOT);
                        State = 2119;
                        Match(CLASS);
                    }
                    break;
                case 5:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 2120;
                        Match(THIS);
                    }
                    break;
                case 6:
                    EnterOuterAlt(_localctx, 6);
                    {
                        State = 2121;
                        typeName();
                        State = 2122;
                        Match(DOT);
                        State = 2123;
                        Match(THIS);
                    }
                    break;
                case 7:
                    EnterOuterAlt(_localctx, 7);
                    {
                        State = 2125;
                        Match(LPAREN);
                        State = 2126;
                        expression();
                        State = 2127;
                        Match(RPAREN);
                    }
                    break;
                case 8:
                    EnterOuterAlt(_localctx, 8);
                    {
                        State = 2129;
                        classInstanceCreationExpression_lfno_primary();
                    }
                    break;
                case 9:
                    EnterOuterAlt(_localctx, 9);
                    {
                        State = 2130;
                        fieldAccess_lfno_primary();
                    }
                    break;
                case 10:
                    EnterOuterAlt(_localctx, 10);
                    {
                        State = 2131;
                        methodInvocation_lfno_primary();
                    }
                    break;
                case 11:
                    EnterOuterAlt(_localctx, 11);
                    {
                        State = 2132;
                        methodReference_lfno_primary();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ClassLiteralContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLASS() { return GetToken(Java9Parser.CLASS, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext typeName()
        {
            return GetRuleContext<TypeNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public NumericTypeContext numericType()
        {
            return GetRuleContext<NumericTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BOOLEAN() { return GetToken(Java9Parser.BOOLEAN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LBRACK() { return GetTokens(Java9Parser.LBRACK); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode LBRACK(int i)
        {
            return GetToken(Java9Parser.LBRACK, i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RBRACK() { return GetTokens(Java9Parser.RBRACK); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode RBRACK(int i)
        {
            return GetToken(Java9Parser.RBRACK, i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOID() { return GetToken(Java9Parser.VOID, 0); }
        public ClassLiteralContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_classLiteral; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterClassLiteral(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitClassLiteral(this);
        }
    }

    [RuleVersion(0)]
    public ClassLiteralContext classLiteral()
    {
        ClassLiteralContext _localctx = new ClassLiteralContext(Context, State);
        EnterRule(_localctx, 384, RULE_classLiteral);
        int _la;
        try
        {
            State = 2152;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case T__0:
                case T__1:
                case T__2:
                case T__3:
                case T__4:
                case T__5:
                case T__6:
                case T__7:
                case T__8:
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
                        State = 2138;
                        ErrorHandler.Sync(this);
                        switch (TokenStream.LA(1))
                        {
                            case T__0:
                            case T__1:
                            case T__2:
                            case T__3:
                            case T__4:
                            case T__5:
                            case T__6:
                            case T__7:
                            case T__8:
                            case Identifier:
                                {
                                    State = 2135;
                                    typeName();
                                }
                                break;
                            case BYTE:
                            case CHAR:
                            case DOUBLE:
                            case FLOAT:
                            case INT:
                            case LONG:
                            case SHORT:
                                {
                                    State = 2136;
                                    numericType();
                                }
                                break;
                            case BOOLEAN:
                                {
                                    State = 2137;
                                    Match(BOOLEAN);
                                }
                                break;
                            default:
                                throw new NoViableAltException(this);
                        }
                        State = 2144;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == LBRACK)
                        {
                            {
                                {
                                    State = 2140;
                                    Match(LBRACK);
                                    State = 2141;
                                    Match(RBRACK);
                                }
                            }
                            State = 2146;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 2147;
                        Match(DOT);
                        State = 2148;
                        Match(CLASS);
                    }
                    break;
                case VOID:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2149;
                        Match(VOID);
                        State = 2150;
                        Match(DOT);
                        State = 2151;
                        Match(CLASS);
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ClassInstanceCreationExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEW() { return GetToken(Java9Parser.NEW, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext[] identifier()
        {
            return GetRuleContexts<IdentifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier(int i)
        {
            return GetRuleContext<IdentifierContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsContext typeArguments()
        {
            return GetRuleContext<TypeArgumentsContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext[] annotation()
        {
            return GetRuleContexts<AnnotationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation(int i)
        {
            return GetRuleContext<AnnotationContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DOT() { return GetTokens(Java9Parser.DOT); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode DOT(int i)
        {
            return GetToken(Java9Parser.DOT, i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsOrDiamondContext typeArgumentsOrDiamond()
        {
            return GetRuleContext<TypeArgumentsOrDiamondContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ArgumentListContext argumentList()
        {
            return GetRuleContext<ArgumentListContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassBodyContext classBody()
        {
            return GetRuleContext<ClassBodyContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionNameContext expressionName()
        {
            return GetRuleContext<ExpressionNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimaryContext primary()
        {
            return GetRuleContext<PrimaryContext>(0);
        }
        public ClassInstanceCreationExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_classInstanceCreationExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterClassInstanceCreationExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitClassInstanceCreationExpression(this);
        }
    }

    [RuleVersion(0)]
    public ClassInstanceCreationExpressionContext classInstanceCreationExpression()
    {
        ClassInstanceCreationExpressionContext _localctx = new ClassInstanceCreationExpressionContext(Context, State);
        EnterRule(_localctx, 386, RULE_classInstanceCreationExpression);
        int _la;
        try
        {
            State = 2237;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 237, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2154;
                        Match(NEW);
                        State = 2156;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2155;
                                typeArguments();
                            }
                        }

                        State = 2161;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == AT)
                        {
                            {
                                {
                                    State = 2158;
                                    annotation();
                                }
                            }
                            State = 2163;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 2164;
                        identifier();
                        State = 2175;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == DOT)
                        {
                            {
                                {
                                    State = 2165;
                                    Match(DOT);
                                    State = 2169;
                                    ErrorHandler.Sync(this);
                                    _la = TokenStream.LA(1);
                                    while (_la == AT)
                                    {
                                        {
                                            {
                                                State = 2166;
                                                annotation();
                                            }
                                        }
                                        State = 2171;
                                        ErrorHandler.Sync(this);
                                        _la = TokenStream.LA(1);
                                    }
                                    State = 2172;
                                    identifier();
                                }
                            }
                            State = 2177;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 2179;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2178;
                                typeArgumentsOrDiamond();
                            }
                        }

                        State = 2181;
                        Match(LPAREN);
                        State = 2183;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 2182;
                                argumentList();
                            }
                        }

                        State = 2185;
                        Match(RPAREN);
                        State = 2187;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LBRACE)
                        {
                            {
                                State = 2186;
                                classBody();
                            }
                        }

                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2189;
                        expressionName();
                        State = 2190;
                        Match(DOT);
                        State = 2191;
                        Match(NEW);
                        State = 2193;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2192;
                                typeArguments();
                            }
                        }

                        State = 2198;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == AT)
                        {
                            {
                                {
                                    State = 2195;
                                    annotation();
                                }
                            }
                            State = 2200;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 2201;
                        identifier();
                        State = 2203;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2202;
                                typeArgumentsOrDiamond();
                            }
                        }

                        State = 2205;
                        Match(LPAREN);
                        State = 2207;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 2206;
                                argumentList();
                            }
                        }

                        State = 2209;
                        Match(RPAREN);
                        State = 2211;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LBRACE)
                        {
                            {
                                State = 2210;
                                classBody();
                            }
                        }

                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 2213;
                        primary();
                        State = 2214;
                        Match(DOT);
                        State = 2215;
                        Match(NEW);
                        State = 2217;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2216;
                                typeArguments();
                            }
                        }

                        State = 2222;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == AT)
                        {
                            {
                                {
                                    State = 2219;
                                    annotation();
                                }
                            }
                            State = 2224;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 2225;
                        identifier();
                        State = 2227;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2226;
                                typeArgumentsOrDiamond();
                            }
                        }

                        State = 2229;
                        Match(LPAREN);
                        State = 2231;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 2230;
                                argumentList();
                            }
                        }

                        State = 2233;
                        Match(RPAREN);
                        State = 2235;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LBRACE)
                        {
                            {
                                State = 2234;
                                classBody();
                            }
                        }

                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ClassInstanceCreationExpression_lf_primaryContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEW() { return GetToken(Java9Parser.NEW, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsContext typeArguments()
        {
            return GetRuleContext<TypeArgumentsContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext[] annotation()
        {
            return GetRuleContexts<AnnotationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation(int i)
        {
            return GetRuleContext<AnnotationContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsOrDiamondContext typeArgumentsOrDiamond()
        {
            return GetRuleContext<TypeArgumentsOrDiamondContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ArgumentListContext argumentList()
        {
            return GetRuleContext<ArgumentListContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassBodyContext classBody()
        {
            return GetRuleContext<ClassBodyContext>(0);
        }
        public ClassInstanceCreationExpression_lf_primaryContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_classInstanceCreationExpression_lf_primary; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterClassInstanceCreationExpression_lf_primary(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitClassInstanceCreationExpression_lf_primary(this);
        }
    }

    [RuleVersion(0)]
    public ClassInstanceCreationExpression_lf_primaryContext classInstanceCreationExpression_lf_primary()
    {
        ClassInstanceCreationExpression_lf_primaryContext _localctx = new ClassInstanceCreationExpression_lf_primaryContext(Context, State);
        EnterRule(_localctx, 388, RULE_classInstanceCreationExpression_lf_primary);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2239;
                Match(DOT);
                State = 2240;
                Match(NEW);
                State = 2242;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == LT)
                {
                    {
                        State = 2241;
                        typeArguments();
                    }
                }

                State = 2247;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == AT)
                {
                    {
                        {
                            State = 2244;
                            annotation();
                        }
                    }
                    State = 2249;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 2250;
                identifier();
                State = 2252;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == LT)
                {
                    {
                        State = 2251;
                        typeArgumentsOrDiamond();
                    }
                }

                State = 2254;
                Match(LPAREN);
                State = 2256;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                {
                    {
                        State = 2255;
                        argumentList();
                    }
                }

                State = 2258;
                Match(RPAREN);
                State = 2260;
                ErrorHandler.Sync(this);
                switch (Interpreter.AdaptivePredict(TokenStream, 242, Context))
                {
                    case 1:
                        {
                            State = 2259;
                            classBody();
                        }
                        break;
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ClassInstanceCreationExpression_lfno_primaryContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEW() { return GetToken(Java9Parser.NEW, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext[] identifier()
        {
            return GetRuleContexts<IdentifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier(int i)
        {
            return GetRuleContext<IdentifierContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsContext typeArguments()
        {
            return GetRuleContext<TypeArgumentsContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext[] annotation()
        {
            return GetRuleContexts<AnnotationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation(int i)
        {
            return GetRuleContext<AnnotationContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DOT() { return GetTokens(Java9Parser.DOT); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode DOT(int i)
        {
            return GetToken(Java9Parser.DOT, i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsOrDiamondContext typeArgumentsOrDiamond()
        {
            return GetRuleContext<TypeArgumentsOrDiamondContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ArgumentListContext argumentList()
        {
            return GetRuleContext<ArgumentListContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassBodyContext classBody()
        {
            return GetRuleContext<ClassBodyContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionNameContext expressionName()
        {
            return GetRuleContext<ExpressionNameContext>(0);
        }
        public ClassInstanceCreationExpression_lfno_primaryContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_classInstanceCreationExpression_lfno_primary; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterClassInstanceCreationExpression_lfno_primary(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitClassInstanceCreationExpression_lfno_primary(this);
        }
    }

    [RuleVersion(0)]
    public ClassInstanceCreationExpression_lfno_primaryContext classInstanceCreationExpression_lfno_primary()
    {
        ClassInstanceCreationExpression_lfno_primaryContext _localctx = new ClassInstanceCreationExpression_lfno_primaryContext(Context, State);
        EnterRule(_localctx, 390, RULE_classInstanceCreationExpression_lfno_primary);
        int _la;
        try
        {
            State = 2321;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case NEW:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2262;
                        Match(NEW);
                        State = 2264;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2263;
                                typeArguments();
                            }
                        }

                        State = 2269;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == AT)
                        {
                            {
                                {
                                    State = 2266;
                                    annotation();
                                }
                            }
                            State = 2271;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 2272;
                        identifier();
                        State = 2283;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == DOT)
                        {
                            {
                                {
                                    State = 2273;
                                    Match(DOT);
                                    State = 2277;
                                    ErrorHandler.Sync(this);
                                    _la = TokenStream.LA(1);
                                    while (_la == AT)
                                    {
                                        {
                                            {
                                                State = 2274;
                                                annotation();
                                            }
                                        }
                                        State = 2279;
                                        ErrorHandler.Sync(this);
                                        _la = TokenStream.LA(1);
                                    }
                                    State = 2280;
                                    identifier();
                                }
                            }
                            State = 2285;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 2287;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2286;
                                typeArgumentsOrDiamond();
                            }
                        }

                        State = 2289;
                        Match(LPAREN);
                        State = 2291;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 2290;
                                argumentList();
                            }
                        }

                        State = 2293;
                        Match(RPAREN);
                        State = 2295;
                        ErrorHandler.Sync(this);
                        switch (Interpreter.AdaptivePredict(TokenStream, 249, Context))
                        {
                            case 1:
                                {
                                    State = 2294;
                                    classBody();
                                }
                                break;
                        }
                    }
                    break;
                case T__0:
                case T__1:
                case T__2:
                case T__3:
                case T__4:
                case T__5:
                case T__6:
                case T__7:
                case T__8:
                case Identifier:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2297;
                        expressionName();
                        State = 2298;
                        Match(DOT);
                        State = 2299;
                        Match(NEW);
                        State = 2301;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2300;
                                typeArguments();
                            }
                        }

                        State = 2306;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == AT)
                        {
                            {
                                {
                                    State = 2303;
                                    annotation();
                                }
                            }
                            State = 2308;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 2309;
                        identifier();
                        State = 2311;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2310;
                                typeArgumentsOrDiamond();
                            }
                        }

                        State = 2313;
                        Match(LPAREN);
                        State = 2315;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 2314;
                                argumentList();
                            }
                        }

                        State = 2317;
                        Match(RPAREN);
                        State = 2319;
                        ErrorHandler.Sync(this);
                        switch (Interpreter.AdaptivePredict(TokenStream, 254, Context))
                        {
                            case 1:
                                {
                                    State = 2318;
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
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class TypeArgumentsOrDiamondContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsContext typeArguments()
        {
            return GetRuleContext<TypeArgumentsContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LT() { return GetToken(Java9Parser.LT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT() { return GetToken(Java9Parser.GT, 0); }
        public TypeArgumentsOrDiamondContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_typeArgumentsOrDiamond; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterTypeArgumentsOrDiamond(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitTypeArgumentsOrDiamond(this);
        }
    }

    [RuleVersion(0)]
    public TypeArgumentsOrDiamondContext typeArgumentsOrDiamond()
    {
        TypeArgumentsOrDiamondContext _localctx = new TypeArgumentsOrDiamondContext(Context, State);
        EnterRule(_localctx, 392, RULE_typeArgumentsOrDiamond);
        try
        {
            State = 2326;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 256, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2323;
                        typeArguments();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2324;
                        Match(LT);
                        State = 2325;
                        Match(GT);
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class FieldAccessContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimaryContext primary()
        {
            return GetRuleContext<PrimaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DOT() { return GetTokens(Java9Parser.DOT); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode DOT(int i)
        {
            return GetToken(Java9Parser.DOT, i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUPER() { return GetToken(Java9Parser.SUPER, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext typeName()
        {
            return GetRuleContext<TypeNameContext>(0);
        }
        public FieldAccessContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_fieldAccess; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterFieldAccess(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitFieldAccess(this);
        }
    }

    [RuleVersion(0)]
    public FieldAccessContext fieldAccess()
    {
        FieldAccessContext _localctx = new FieldAccessContext(Context, State);
        EnterRule(_localctx, 394, RULE_fieldAccess);
        try
        {
            State = 2341;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 257, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2328;
                        primary();
                        State = 2329;
                        Match(DOT);
                        State = 2330;
                        identifier();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2332;
                        Match(SUPER);
                        State = 2333;
                        Match(DOT);
                        State = 2334;
                        identifier();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 2335;
                        typeName();
                        State = 2336;
                        Match(DOT);
                        State = 2337;
                        Match(SUPER);
                        State = 2338;
                        Match(DOT);
                        State = 2339;
                        identifier();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class FieldAccess_lf_primaryContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        public FieldAccess_lf_primaryContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_fieldAccess_lf_primary; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterFieldAccess_lf_primary(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitFieldAccess_lf_primary(this);
        }
    }

    [RuleVersion(0)]
    public FieldAccess_lf_primaryContext fieldAccess_lf_primary()
    {
        FieldAccess_lf_primaryContext _localctx = new FieldAccess_lf_primaryContext(Context, State);
        EnterRule(_localctx, 396, RULE_fieldAccess_lf_primary);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2343;
                Match(DOT);
                State = 2344;
                identifier();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class FieldAccess_lfno_primaryContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUPER() { return GetToken(Java9Parser.SUPER, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DOT() { return GetTokens(Java9Parser.DOT); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode DOT(int i)
        {
            return GetToken(Java9Parser.DOT, i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext typeName()
        {
            return GetRuleContext<TypeNameContext>(0);
        }
        public FieldAccess_lfno_primaryContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_fieldAccess_lfno_primary; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterFieldAccess_lfno_primary(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitFieldAccess_lfno_primary(this);
        }
    }

    [RuleVersion(0)]
    public FieldAccess_lfno_primaryContext fieldAccess_lfno_primary()
    {
        FieldAccess_lfno_primaryContext _localctx = new FieldAccess_lfno_primaryContext(Context, State);
        EnterRule(_localctx, 398, RULE_fieldAccess_lfno_primary);
        try
        {
            State = 2355;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case SUPER:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2346;
                        Match(SUPER);
                        State = 2347;
                        Match(DOT);
                        State = 2348;
                        identifier();
                    }
                    break;
                case T__0:
                case T__1:
                case T__2:
                case T__3:
                case T__4:
                case T__5:
                case T__6:
                case T__7:
                case T__8:
                case Identifier:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2349;
                        typeName();
                        State = 2350;
                        Match(DOT);
                        State = 2351;
                        Match(SUPER);
                        State = 2352;
                        Match(DOT);
                        State = 2353;
                        identifier();
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ArrayAccessContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionNameContext expressionName()
        {
            return GetRuleContext<ExpressionNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LBRACK() { return GetTokens(Java9Parser.LBRACK); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode LBRACK(int i)
        {
            return GetToken(Java9Parser.LBRACK, i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext[] expression()
        {
            return GetRuleContexts<ExpressionContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression(int i)
        {
            return GetRuleContext<ExpressionContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RBRACK() { return GetTokens(Java9Parser.RBRACK); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode RBRACK(int i)
        {
            return GetToken(Java9Parser.RBRACK, i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimaryNoNewArray_lfno_arrayAccessContext primaryNoNewArray_lfno_arrayAccess()
        {
            return GetRuleContext<PrimaryNoNewArray_lfno_arrayAccessContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimaryNoNewArray_lf_arrayAccessContext[] primaryNoNewArray_lf_arrayAccess()
        {
            return GetRuleContexts<PrimaryNoNewArray_lf_arrayAccessContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimaryNoNewArray_lf_arrayAccessContext primaryNoNewArray_lf_arrayAccess(int i)
        {
            return GetRuleContext<PrimaryNoNewArray_lf_arrayAccessContext>(i);
        }
        public ArrayAccessContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_arrayAccess; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterArrayAccess(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitArrayAccess(this);
        }
    }

    [RuleVersion(0)]
    public ArrayAccessContext arrayAccess()
    {
        ArrayAccessContext _localctx = new ArrayAccessContext(Context, State);
        EnterRule(_localctx, 400, RULE_arrayAccess);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2367;
                ErrorHandler.Sync(this);
                switch (Interpreter.AdaptivePredict(TokenStream, 259, Context))
                {
                    case 1:
                        {
                            State = 2357;
                            expressionName();
                            State = 2358;
                            Match(LBRACK);
                            State = 2359;
                            expression();
                            State = 2360;
                            Match(RBRACK);
                        }
                        break;
                    case 2:
                        {
                            State = 2362;
                            primaryNoNewArray_lfno_arrayAccess();
                            State = 2363;
                            Match(LBRACK);
                            State = 2364;
                            expression();
                            State = 2365;
                            Match(RBRACK);
                        }
                        break;
                }
                State = 2376;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == LBRACK)
                {
                    {
                        {
                            State = 2369;
                            primaryNoNewArray_lf_arrayAccess();
                            State = 2370;
                            Match(LBRACK);
                            State = 2371;
                            expression();
                            State = 2372;
                            Match(RBRACK);
                        }
                    }
                    State = 2378;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ArrayAccess_lf_primaryContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary()
        {
            return GetRuleContext<PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LBRACK() { return GetTokens(Java9Parser.LBRACK); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode LBRACK(int i)
        {
            return GetToken(Java9Parser.LBRACK, i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext[] expression()
        {
            return GetRuleContexts<ExpressionContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression(int i)
        {
            return GetRuleContext<ExpressionContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RBRACK() { return GetTokens(Java9Parser.RBRACK); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode RBRACK(int i)
        {
            return GetToken(Java9Parser.RBRACK, i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext[] primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary()
        {
            return GetRuleContexts<PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary(int i)
        {
            return GetRuleContext<PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext>(i);
        }
        public ArrayAccess_lf_primaryContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_arrayAccess_lf_primary; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterArrayAccess_lf_primary(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitArrayAccess_lf_primary(this);
        }
    }

    [RuleVersion(0)]
    public ArrayAccess_lf_primaryContext arrayAccess_lf_primary()
    {
        ArrayAccess_lf_primaryContext _localctx = new ArrayAccess_lf_primaryContext(Context, State);
        EnterRule(_localctx, 402, RULE_arrayAccess_lf_primary);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                {
                    State = 2379;
                    primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary();
                    State = 2380;
                    Match(LBRACK);
                    State = 2381;
                    expression();
                    State = 2382;
                    Match(RBRACK);
                }
                State = 2391;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 261, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        {
                            {
                                State = 2384;
                                primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary();
                                State = 2385;
                                Match(LBRACK);
                                State = 2386;
                                expression();
                                State = 2387;
                                Match(RBRACK);
                            }
                        }
                    }
                    State = 2393;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 261, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ArrayAccess_lfno_primaryContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionNameContext expressionName()
        {
            return GetRuleContext<ExpressionNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LBRACK() { return GetTokens(Java9Parser.LBRACK); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode LBRACK(int i)
        {
            return GetToken(Java9Parser.LBRACK, i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext[] expression()
        {
            return GetRuleContexts<ExpressionContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression(int i)
        {
            return GetRuleContext<ExpressionContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RBRACK() { return GetTokens(Java9Parser.RBRACK); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode RBRACK(int i)
        {
            return GetToken(Java9Parser.RBRACK, i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary()
        {
            return GetRuleContext<PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext[] primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary()
        {
            return GetRuleContexts<PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary(int i)
        {
            return GetRuleContext<PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext>(i);
        }
        public ArrayAccess_lfno_primaryContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_arrayAccess_lfno_primary; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterArrayAccess_lfno_primary(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitArrayAccess_lfno_primary(this);
        }
    }

    [RuleVersion(0)]
    public ArrayAccess_lfno_primaryContext arrayAccess_lfno_primary()
    {
        ArrayAccess_lfno_primaryContext _localctx = new ArrayAccess_lfno_primaryContext(Context, State);
        EnterRule(_localctx, 404, RULE_arrayAccess_lfno_primary);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                State = 2404;
                ErrorHandler.Sync(this);
                switch (Interpreter.AdaptivePredict(TokenStream, 262, Context))
                {
                    case 1:
                        {
                            State = 2394;
                            expressionName();
                            State = 2395;
                            Match(LBRACK);
                            State = 2396;
                            expression();
                            State = 2397;
                            Match(RBRACK);
                        }
                        break;
                    case 2:
                        {
                            State = 2399;
                            primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary();
                            State = 2400;
                            Match(LBRACK);
                            State = 2401;
                            expression();
                            State = 2402;
                            Match(RBRACK);
                        }
                        break;
                }
                State = 2413;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 263, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        {
                            {
                                State = 2406;
                                primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary();
                                State = 2407;
                                Match(LBRACK);
                                State = 2408;
                                expression();
                                State = 2409;
                                Match(RBRACK);
                            }
                        }
                    }
                    State = 2415;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 263, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class MethodInvocationContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodNameContext methodName()
        {
            return GetRuleContext<MethodNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ArgumentListContext argumentList()
        {
            return GetRuleContext<ArgumentListContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext typeName()
        {
            return GetRuleContext<TypeNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DOT() { return GetTokens(Java9Parser.DOT); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode DOT(int i)
        {
            return GetToken(Java9Parser.DOT, i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsContext typeArguments()
        {
            return GetRuleContext<TypeArgumentsContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionNameContext expressionName()
        {
            return GetRuleContext<ExpressionNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimaryContext primary()
        {
            return GetRuleContext<PrimaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUPER() { return GetToken(Java9Parser.SUPER, 0); }
        public MethodInvocationContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_methodInvocation; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterMethodInvocation(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitMethodInvocation(this);
        }
    }

    [RuleVersion(0)]
    public MethodInvocationContext methodInvocation()
    {
        MethodInvocationContext _localctx = new MethodInvocationContext(Context, State);
        EnterRule(_localctx, 406, RULE_methodInvocation);
        int _la;
        try
        {
            State = 2485;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 275, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2416;
                        methodName();
                        State = 2417;
                        Match(LPAREN);
                        State = 2419;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 2418;
                                argumentList();
                            }
                        }

                        State = 2421;
                        Match(RPAREN);
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2423;
                        typeName();
                        State = 2424;
                        Match(DOT);
                        State = 2426;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2425;
                                typeArguments();
                            }
                        }

                        State = 2428;
                        identifier();
                        State = 2429;
                        Match(LPAREN);
                        State = 2431;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 2430;
                                argumentList();
                            }
                        }

                        State = 2433;
                        Match(RPAREN);
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 2435;
                        expressionName();
                        State = 2436;
                        Match(DOT);
                        State = 2438;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2437;
                                typeArguments();
                            }
                        }

                        State = 2440;
                        identifier();
                        State = 2441;
                        Match(LPAREN);
                        State = 2443;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 2442;
                                argumentList();
                            }
                        }

                        State = 2445;
                        Match(RPAREN);
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 2447;
                        primary();
                        State = 2448;
                        Match(DOT);
                        State = 2450;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2449;
                                typeArguments();
                            }
                        }

                        State = 2452;
                        identifier();
                        State = 2453;
                        Match(LPAREN);
                        State = 2455;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 2454;
                                argumentList();
                            }
                        }

                        State = 2457;
                        Match(RPAREN);
                    }
                    break;
                case 5:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 2459;
                        Match(SUPER);
                        State = 2460;
                        Match(DOT);
                        State = 2462;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2461;
                                typeArguments();
                            }
                        }

                        State = 2464;
                        identifier();
                        State = 2465;
                        Match(LPAREN);
                        State = 2467;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 2466;
                                argumentList();
                            }
                        }

                        State = 2469;
                        Match(RPAREN);
                    }
                    break;
                case 6:
                    EnterOuterAlt(_localctx, 6);
                    {
                        State = 2471;
                        typeName();
                        State = 2472;
                        Match(DOT);
                        State = 2473;
                        Match(SUPER);
                        State = 2474;
                        Match(DOT);
                        State = 2476;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2475;
                                typeArguments();
                            }
                        }

                        State = 2478;
                        identifier();
                        State = 2479;
                        Match(LPAREN);
                        State = 2481;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 2480;
                                argumentList();
                            }
                        }

                        State = 2483;
                        Match(RPAREN);
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class MethodInvocation_lf_primaryContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsContext typeArguments()
        {
            return GetRuleContext<TypeArgumentsContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ArgumentListContext argumentList()
        {
            return GetRuleContext<ArgumentListContext>(0);
        }
        public MethodInvocation_lf_primaryContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_methodInvocation_lf_primary; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterMethodInvocation_lf_primary(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitMethodInvocation_lf_primary(this);
        }
    }

    [RuleVersion(0)]
    public MethodInvocation_lf_primaryContext methodInvocation_lf_primary()
    {
        MethodInvocation_lf_primaryContext _localctx = new MethodInvocation_lf_primaryContext(Context, State);
        EnterRule(_localctx, 408, RULE_methodInvocation_lf_primary);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2487;
                Match(DOT);
                State = 2489;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == LT)
                {
                    {
                        State = 2488;
                        typeArguments();
                    }
                }

                State = 2491;
                identifier();
                State = 2492;
                Match(LPAREN);
                State = 2494;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                {
                    {
                        State = 2493;
                        argumentList();
                    }
                }

                State = 2496;
                Match(RPAREN);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class MethodInvocation_lfno_primaryContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public MethodNameContext methodName()
        {
            return GetRuleContext<MethodNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ArgumentListContext argumentList()
        {
            return GetRuleContext<ArgumentListContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext typeName()
        {
            return GetRuleContext<TypeNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DOT() { return GetTokens(Java9Parser.DOT); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode DOT(int i)
        {
            return GetToken(Java9Parser.DOT, i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsContext typeArguments()
        {
            return GetRuleContext<TypeArgumentsContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionNameContext expressionName()
        {
            return GetRuleContext<ExpressionNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUPER() { return GetToken(Java9Parser.SUPER, 0); }
        public MethodInvocation_lfno_primaryContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_methodInvocation_lfno_primary; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterMethodInvocation_lfno_primary(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitMethodInvocation_lfno_primary(this);
        }
    }

    [RuleVersion(0)]
    public MethodInvocation_lfno_primaryContext methodInvocation_lfno_primary()
    {
        MethodInvocation_lfno_primaryContext _localctx = new MethodInvocation_lfno_primaryContext(Context, State);
        EnterRule(_localctx, 410, RULE_methodInvocation_lfno_primary);
        int _la;
        try
        {
            State = 2555;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 287, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2498;
                        methodName();
                        State = 2499;
                        Match(LPAREN);
                        State = 2501;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 2500;
                                argumentList();
                            }
                        }

                        State = 2503;
                        Match(RPAREN);
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2505;
                        typeName();
                        State = 2506;
                        Match(DOT);
                        State = 2508;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2507;
                                typeArguments();
                            }
                        }

                        State = 2510;
                        identifier();
                        State = 2511;
                        Match(LPAREN);
                        State = 2513;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 2512;
                                argumentList();
                            }
                        }

                        State = 2515;
                        Match(RPAREN);
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 2517;
                        expressionName();
                        State = 2518;
                        Match(DOT);
                        State = 2520;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2519;
                                typeArguments();
                            }
                        }

                        State = 2522;
                        identifier();
                        State = 2523;
                        Match(LPAREN);
                        State = 2525;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 2524;
                                argumentList();
                            }
                        }

                        State = 2527;
                        Match(RPAREN);
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 2529;
                        Match(SUPER);
                        State = 2530;
                        Match(DOT);
                        State = 2532;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2531;
                                typeArguments();
                            }
                        }

                        State = 2534;
                        identifier();
                        State = 2535;
                        Match(LPAREN);
                        State = 2537;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 2536;
                                argumentList();
                            }
                        }

                        State = 2539;
                        Match(RPAREN);
                    }
                    break;
                case 5:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 2541;
                        typeName();
                        State = 2542;
                        Match(DOT);
                        State = 2543;
                        Match(SUPER);
                        State = 2544;
                        Match(DOT);
                        State = 2546;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2545;
                                typeArguments();
                            }
                        }

                        State = 2548;
                        identifier();
                        State = 2549;
                        Match(LPAREN);
                        State = 2551;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << NEW) | (1L << SHORT) | (1L << SUPER) | (1L << THIS) | (1L << VOID) | (1L << IntegerLiteral) | (1L << FloatingPointLiteral))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (BooleanLiteral - 64)) | (1L << (CharacterLiteral - 64)) | (1L << (StringLiteral - 64)) | (1L << (NullLiteral - 64)) | (1L << (LPAREN - 64)) | (1L << (AT - 64)) | (1L << (BANG - 64)) | (1L << (TILDE - 64)) | (1L << (INC - 64)) | (1L << (DEC - 64)) | (1L << (ADD - 64)) | (1L << (SUB - 64)) | (1L << (Identifier - 64)))) != 0))
                        {
                            {
                                State = 2550;
                                argumentList();
                            }
                        }

                        State = 2553;
                        Match(RPAREN);
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ArgumentListContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext[] expression()
        {
            return GetRuleContexts<ExpressionContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression(int i)
        {
            return GetRuleContext<ExpressionContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java9Parser.COMMA); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode COMMA(int i)
        {
            return GetToken(Java9Parser.COMMA, i);
        }
        public ArgumentListContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_argumentList; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterArgumentList(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitArgumentList(this);
        }
    }

    [RuleVersion(0)]
    public ArgumentListContext argumentList()
    {
        ArgumentListContext _localctx = new ArgumentListContext(Context, State);
        EnterRule(_localctx, 412, RULE_argumentList);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2557;
                expression();
                State = 2562;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == COMMA)
                {
                    {
                        {
                            State = 2558;
                            Match(COMMA);
                            State = 2559;
                            expression();
                        }
                    }
                    State = 2564;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class MethodReferenceContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionNameContext expressionName()
        {
            return GetRuleContext<ExpressionNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLONCOLON() { return GetToken(Java9Parser.COLONCOLON, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsContext typeArguments()
        {
            return GetRuleContext<TypeArgumentsContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ReferenceTypeContext referenceType()
        {
            return GetRuleContext<ReferenceTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimaryContext primary()
        {
            return GetRuleContext<PrimaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUPER() { return GetToken(Java9Parser.SUPER, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext typeName()
        {
            return GetRuleContext<TypeNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassTypeContext classType()
        {
            return GetRuleContext<ClassTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEW() { return GetToken(Java9Parser.NEW, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ArrayTypeContext arrayType()
        {
            return GetRuleContext<ArrayTypeContext>(0);
        }
        public MethodReferenceContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_methodReference; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterMethodReference(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitMethodReference(this);
        }
    }

    [RuleVersion(0)]
    public MethodReferenceContext methodReference()
    {
        MethodReferenceContext _localctx = new MethodReferenceContext(Context, State);
        EnterRule(_localctx, 414, RULE_methodReference);
        int _la;
        try
        {
            State = 2612;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 295, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2565;
                        expressionName();
                        State = 2566;
                        Match(COLONCOLON);
                        State = 2568;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2567;
                                typeArguments();
                            }
                        }

                        State = 2570;
                        identifier();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2572;
                        referenceType();
                        State = 2573;
                        Match(COLONCOLON);
                        State = 2575;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2574;
                                typeArguments();
                            }
                        }

                        State = 2577;
                        identifier();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 2579;
                        primary();
                        State = 2580;
                        Match(COLONCOLON);
                        State = 2582;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2581;
                                typeArguments();
                            }
                        }

                        State = 2584;
                        identifier();
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 2586;
                        Match(SUPER);
                        State = 2587;
                        Match(COLONCOLON);
                        State = 2589;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2588;
                                typeArguments();
                            }
                        }

                        State = 2591;
                        identifier();
                    }
                    break;
                case 5:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 2592;
                        typeName();
                        State = 2593;
                        Match(DOT);
                        State = 2594;
                        Match(SUPER);
                        State = 2595;
                        Match(COLONCOLON);
                        State = 2597;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2596;
                                typeArguments();
                            }
                        }

                        State = 2599;
                        identifier();
                    }
                    break;
                case 6:
                    EnterOuterAlt(_localctx, 6);
                    {
                        State = 2601;
                        classType();
                        State = 2602;
                        Match(COLONCOLON);
                        State = 2604;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2603;
                                typeArguments();
                            }
                        }

                        State = 2606;
                        Match(NEW);
                    }
                    break;
                case 7:
                    EnterOuterAlt(_localctx, 7);
                    {
                        State = 2608;
                        arrayType();
                        State = 2609;
                        Match(COLONCOLON);
                        State = 2610;
                        Match(NEW);
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class MethodReference_lf_primaryContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLONCOLON() { return GetToken(Java9Parser.COLONCOLON, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsContext typeArguments()
        {
            return GetRuleContext<TypeArgumentsContext>(0);
        }
        public MethodReference_lf_primaryContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_methodReference_lf_primary; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterMethodReference_lf_primary(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitMethodReference_lf_primary(this);
        }
    }

    [RuleVersion(0)]
    public MethodReference_lf_primaryContext methodReference_lf_primary()
    {
        MethodReference_lf_primaryContext _localctx = new MethodReference_lf_primaryContext(Context, State);
        EnterRule(_localctx, 416, RULE_methodReference_lf_primary);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2614;
                Match(COLONCOLON);
                State = 2616;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                if (_la == LT)
                {
                    {
                        State = 2615;
                        typeArguments();
                    }
                }

                State = 2618;
                identifier();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class MethodReference_lfno_primaryContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionNameContext expressionName()
        {
            return GetRuleContext<ExpressionNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLONCOLON() { return GetToken(Java9Parser.COLONCOLON, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeArgumentsContext typeArguments()
        {
            return GetRuleContext<TypeArgumentsContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ReferenceTypeContext referenceType()
        {
            return GetRuleContext<ReferenceTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUPER() { return GetToken(Java9Parser.SUPER, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public TypeNameContext typeName()
        {
            return GetRuleContext<TypeNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(Java9Parser.DOT, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassTypeContext classType()
        {
            return GetRuleContext<ClassTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEW() { return GetToken(Java9Parser.NEW, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ArrayTypeContext arrayType()
        {
            return GetRuleContext<ArrayTypeContext>(0);
        }
        public MethodReference_lfno_primaryContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_methodReference_lfno_primary; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterMethodReference_lfno_primary(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitMethodReference_lfno_primary(this);
        }
    }

    [RuleVersion(0)]
    public MethodReference_lfno_primaryContext methodReference_lfno_primary()
    {
        MethodReference_lfno_primaryContext _localctx = new MethodReference_lfno_primaryContext(Context, State);
        EnterRule(_localctx, 418, RULE_methodReference_lfno_primary);
        int _la;
        try
        {
            State = 2660;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 302, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2620;
                        expressionName();
                        State = 2621;
                        Match(COLONCOLON);
                        State = 2623;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2622;
                                typeArguments();
                            }
                        }

                        State = 2625;
                        identifier();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2627;
                        referenceType();
                        State = 2628;
                        Match(COLONCOLON);
                        State = 2630;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2629;
                                typeArguments();
                            }
                        }

                        State = 2632;
                        identifier();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 2634;
                        Match(SUPER);
                        State = 2635;
                        Match(COLONCOLON);
                        State = 2637;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2636;
                                typeArguments();
                            }
                        }

                        State = 2639;
                        identifier();
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 2640;
                        typeName();
                        State = 2641;
                        Match(DOT);
                        State = 2642;
                        Match(SUPER);
                        State = 2643;
                        Match(COLONCOLON);
                        State = 2645;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2644;
                                typeArguments();
                            }
                        }

                        State = 2647;
                        identifier();
                    }
                    break;
                case 5:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 2649;
                        classType();
                        State = 2650;
                        Match(COLONCOLON);
                        State = 2652;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if (_la == LT)
                        {
                            {
                                State = 2651;
                                typeArguments();
                            }
                        }

                        State = 2654;
                        Match(NEW);
                    }
                    break;
                case 6:
                    EnterOuterAlt(_localctx, 6);
                    {
                        State = 2656;
                        arrayType();
                        State = 2657;
                        Match(COLONCOLON);
                        State = 2658;
                        Match(NEW);
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ArrayCreationExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEW() { return GetToken(Java9Parser.NEW, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimitiveTypeContext primitiveType()
        {
            return GetRuleContext<PrimitiveTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public DimExprsContext dimExprs()
        {
            return GetRuleContext<DimExprsContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public DimsContext dims()
        {
            return GetRuleContext<DimsContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ClassOrInterfaceTypeContext classOrInterfaceType()
        {
            return GetRuleContext<ClassOrInterfaceTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ArrayInitializerContext arrayInitializer()
        {
            return GetRuleContext<ArrayInitializerContext>(0);
        }
        public ArrayCreationExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_arrayCreationExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterArrayCreationExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitArrayCreationExpression(this);
        }
    }

    [RuleVersion(0)]
    public ArrayCreationExpressionContext arrayCreationExpression()
    {
        ArrayCreationExpressionContext _localctx = new ArrayCreationExpressionContext(Context, State);
        EnterRule(_localctx, 420, RULE_arrayCreationExpression);
        try
        {
            State = 2684;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 305, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2662;
                        Match(NEW);
                        State = 2663;
                        primitiveType();
                        State = 2664;
                        dimExprs();
                        State = 2666;
                        ErrorHandler.Sync(this);
                        switch (Interpreter.AdaptivePredict(TokenStream, 303, Context))
                        {
                            case 1:
                                {
                                    State = 2665;
                                    dims();
                                }
                                break;
                        }
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2668;
                        Match(NEW);
                        State = 2669;
                        classOrInterfaceType();
                        State = 2670;
                        dimExprs();
                        State = 2672;
                        ErrorHandler.Sync(this);
                        switch (Interpreter.AdaptivePredict(TokenStream, 304, Context))
                        {
                            case 1:
                                {
                                    State = 2671;
                                    dims();
                                }
                                break;
                        }
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 2674;
                        Match(NEW);
                        State = 2675;
                        primitiveType();
                        State = 2676;
                        dims();
                        State = 2677;
                        arrayInitializer();
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 2679;
                        Match(NEW);
                        State = 2680;
                        classOrInterfaceType();
                        State = 2681;
                        dims();
                        State = 2682;
                        arrayInitializer();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class DimExprsContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public DimExprContext[] dimExpr()
        {
            return GetRuleContexts<DimExprContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public DimExprContext dimExpr(int i)
        {
            return GetRuleContext<DimExprContext>(i);
        }
        public DimExprsContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_dimExprs; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterDimExprs(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitDimExprs(this);
        }
    }

    [RuleVersion(0)]
    public DimExprsContext dimExprs()
    {
        DimExprsContext _localctx = new DimExprsContext(Context, State);
        EnterRule(_localctx, 422, RULE_dimExprs);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                State = 2687;
                ErrorHandler.Sync(this);
                _alt = 1;
                do
                {
                    switch (_alt)
                    {
                        case 1:
                            {
                                {
                                    State = 2686;
                                    dimExpr();
                                }
                            }
                            break;
                        default:
                            throw new NoViableAltException(this);
                    }
                    State = 2689;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 306, Context);
                } while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class DimExprContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACK() { return GetToken(Java9Parser.LBRACK, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACK() { return GetToken(Java9Parser.RBRACK, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext[] annotation()
        {
            return GetRuleContexts<AnnotationContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AnnotationContext annotation(int i)
        {
            return GetRuleContext<AnnotationContext>(i);
        }
        public DimExprContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_dimExpr; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterDimExpr(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitDimExpr(this);
        }
    }

    [RuleVersion(0)]
    public DimExprContext dimExpr()
    {
        DimExprContext _localctx = new DimExprContext(Context, State);
        EnterRule(_localctx, 424, RULE_dimExpr);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2694;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == AT)
                {
                    {
                        {
                            State = 2691;
                            annotation();
                        }
                    }
                    State = 2696;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
                State = 2697;
                Match(LBRACK);
                State = 2698;
                expression();
                State = 2699;
                Match(RBRACK);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ConstantExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        public ConstantExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_constantExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterConstantExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitConstantExpression(this);
        }
    }

    [RuleVersion(0)]
    public ConstantExpressionContext constantExpression()
    {
        ConstantExpressionContext _localctx = new ConstantExpressionContext(Context, State);
        EnterRule(_localctx, 426, RULE_constantExpression);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2701;
                expression();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public LambdaExpressionContext lambdaExpression()
        {
            return GetRuleContext<LambdaExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AssignmentExpressionContext assignmentExpression()
        {
            return GetRuleContext<AssignmentExpressionContext>(0);
        }
        public ExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_expression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitExpression(this);
        }
    }

    [RuleVersion(0)]
    public ExpressionContext expression()
    {
        ExpressionContext _localctx = new ExpressionContext(Context, State);
        EnterRule(_localctx, 428, RULE_expression);
        try
        {
            State = 2705;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 308, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2703;
                        lambdaExpression();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2704;
                        assignmentExpression();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class LambdaExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public LambdaParametersContext lambdaParameters()
        {
            return GetRuleContext<LambdaParametersContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ARROW() { return GetToken(Java9Parser.ARROW, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public LambdaBodyContext lambdaBody()
        {
            return GetRuleContext<LambdaBodyContext>(0);
        }
        public LambdaExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_lambdaExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterLambdaExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitLambdaExpression(this);
        }
    }

    [RuleVersion(0)]
    public LambdaExpressionContext lambdaExpression()
    {
        LambdaExpressionContext _localctx = new LambdaExpressionContext(Context, State);
        EnterRule(_localctx, 430, RULE_lambdaExpression);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2707;
                lambdaParameters();
                State = 2708;
                Match(ARROW);
                State = 2709;
                lambdaBody();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class LambdaParametersContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier()
        {
            return GetRuleContext<IdentifierContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public FormalParameterListContext formalParameterList()
        {
            return GetRuleContext<FormalParameterListContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InferredFormalParameterListContext inferredFormalParameterList()
        {
            return GetRuleContext<InferredFormalParameterListContext>(0);
        }
        public LambdaParametersContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_lambdaParameters; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterLambdaParameters(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitLambdaParameters(this);
        }
    }

    [RuleVersion(0)]
    public LambdaParametersContext lambdaParameters()
    {
        LambdaParametersContext _localctx = new LambdaParametersContext(Context, State);
        EnterRule(_localctx, 432, RULE_lambdaParameters);
        int _la;
        try
        {
            State = 2721;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 310, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2711;
                        identifier();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2712;
                        Match(LPAREN);
                        State = 2714;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << BOOLEAN) | (1L << BYTE) | (1L << CHAR) | (1L << DOUBLE) | (1L << FINAL) | (1L << FLOAT) | (1L << INT) | (1L << LONG) | (1L << SHORT))) != 0) || _la == AT || _la == Identifier)
                        {
                            {
                                State = 2713;
                                formalParameterList();
                            }
                        }

                        State = 2716;
                        Match(RPAREN);
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 2717;
                        Match(LPAREN);
                        State = 2718;
                        inferredFormalParameterList();
                        State = 2719;
                        Match(RPAREN);
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class InferredFormalParameterListContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext[] identifier()
        {
            return GetRuleContexts<IdentifierContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public IdentifierContext identifier(int i)
        {
            return GetRuleContext<IdentifierContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(Java9Parser.COMMA); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode COMMA(int i)
        {
            return GetToken(Java9Parser.COMMA, i);
        }
        public InferredFormalParameterListContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_inferredFormalParameterList; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterInferredFormalParameterList(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitInferredFormalParameterList(this);
        }
    }

    [RuleVersion(0)]
    public InferredFormalParameterListContext inferredFormalParameterList()
    {
        InferredFormalParameterListContext _localctx = new InferredFormalParameterListContext(Context, State);
        EnterRule(_localctx, 434, RULE_inferredFormalParameterList);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2723;
                identifier();
                State = 2728;
                ErrorHandler.Sync(this);
                _la = TokenStream.LA(1);
                while (_la == COMMA)
                {
                    {
                        {
                            State = 2724;
                            Match(COMMA);
                            State = 2725;
                            identifier();
                        }
                    }
                    State = 2730;
                    ErrorHandler.Sync(this);
                    _la = TokenStream.LA(1);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class LambdaBodyContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public BlockContext block()
        {
            return GetRuleContext<BlockContext>(0);
        }
        public LambdaBodyContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_lambdaBody; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterLambdaBody(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitLambdaBody(this);
        }
    }

    [RuleVersion(0)]
    public LambdaBodyContext lambdaBody()
    {
        LambdaBodyContext _localctx = new LambdaBodyContext(Context, State);
        EnterRule(_localctx, 436, RULE_lambdaBody);
        try
        {
            State = 2733;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case T__0:
                case T__1:
                case T__2:
                case T__3:
                case T__4:
                case T__5:
                case T__6:
                case T__7:
                case T__8:
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
                case AT:
                case BANG:
                case TILDE:
                case INC:
                case DEC:
                case ADD:
                case SUB:
                case Identifier:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2731;
                        expression();
                    }
                    break;
                case LBRACE:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2732;
                        block();
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class AssignmentExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ConditionalExpressionContext conditionalExpression()
        {
            return GetRuleContext<ConditionalExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AssignmentContext assignment()
        {
            return GetRuleContext<AssignmentContext>(0);
        }
        public AssignmentExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_assignmentExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterAssignmentExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitAssignmentExpression(this);
        }
    }

    [RuleVersion(0)]
    public AssignmentExpressionContext assignmentExpression()
    {
        AssignmentExpressionContext _localctx = new AssignmentExpressionContext(Context, State);
        EnterRule(_localctx, 438, RULE_assignmentExpression);
        try
        {
            State = 2737;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 313, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2735;
                        conditionalExpression();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2736;
                        assignment();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class AssignmentContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public LeftHandSideContext leftHandSide()
        {
            return GetRuleContext<LeftHandSideContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AssignmentOperatorContext assignmentOperator()
        {
            return GetRuleContext<AssignmentOperatorContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        public AssignmentContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_assignment; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterAssignment(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitAssignment(this);
        }
    }

    [RuleVersion(0)]
    public AssignmentContext assignment()
    {
        AssignmentContext _localctx = new AssignmentContext(Context, State);
        EnterRule(_localctx, 440, RULE_assignment);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2739;
                leftHandSide();
                State = 2740;
                assignmentOperator();
                State = 2741;
                expression();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class LeftHandSideContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionNameContext expressionName()
        {
            return GetRuleContext<ExpressionNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public FieldAccessContext fieldAccess()
        {
            return GetRuleContext<FieldAccessContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ArrayAccessContext arrayAccess()
        {
            return GetRuleContext<ArrayAccessContext>(0);
        }
        public LeftHandSideContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_leftHandSide; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterLeftHandSide(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitLeftHandSide(this);
        }
    }

    [RuleVersion(0)]
    public LeftHandSideContext leftHandSide()
    {
        LeftHandSideContext _localctx = new LeftHandSideContext(Context, State);
        EnterRule(_localctx, 442, RULE_leftHandSide);
        try
        {
            State = 2746;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 314, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2743;
                        expressionName();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2744;
                        fieldAccess();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 2745;
                        arrayAccess();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class AssignmentOperatorContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGN() { return GetToken(Java9Parser.ASSIGN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MUL_ASSIGN() { return GetToken(Java9Parser.MUL_ASSIGN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIV_ASSIGN() { return GetToken(Java9Parser.DIV_ASSIGN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MOD_ASSIGN() { return GetToken(Java9Parser.MOD_ASSIGN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ADD_ASSIGN() { return GetToken(Java9Parser.ADD_ASSIGN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUB_ASSIGN() { return GetToken(Java9Parser.SUB_ASSIGN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LSHIFT_ASSIGN() { return GetToken(Java9Parser.LSHIFT_ASSIGN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RSHIFT_ASSIGN() { return GetToken(Java9Parser.RSHIFT_ASSIGN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode URSHIFT_ASSIGN() { return GetToken(Java9Parser.URSHIFT_ASSIGN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AND_ASSIGN() { return GetToken(Java9Parser.AND_ASSIGN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode XOR_ASSIGN() { return GetToken(Java9Parser.XOR_ASSIGN, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OR_ASSIGN() { return GetToken(Java9Parser.OR_ASSIGN, 0); }
        public AssignmentOperatorContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_assignmentOperator; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterAssignmentOperator(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitAssignmentOperator(this);
        }
    }

    [RuleVersion(0)]
    public AssignmentOperatorContext assignmentOperator()
    {
        AssignmentOperatorContext _localctx = new AssignmentOperatorContext(Context, State);
        EnterRule(_localctx, 444, RULE_assignmentOperator);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2748;
                _la = TokenStream.LA(1);
                if (!(((((_la - 80)) & ~0x3f) == 0 && ((1L << (_la - 80)) & ((1L << (ASSIGN - 80)) | (1L << (ADD_ASSIGN - 80)) | (1L << (SUB_ASSIGN - 80)) | (1L << (MUL_ASSIGN - 80)) | (1L << (DIV_ASSIGN - 80)) | (1L << (AND_ASSIGN - 80)) | (1L << (OR_ASSIGN - 80)) | (1L << (XOR_ASSIGN - 80)) | (1L << (MOD_ASSIGN - 80)) | (1L << (LSHIFT_ASSIGN - 80)) | (1L << (RSHIFT_ASSIGN - 80)) | (1L << (URSHIFT_ASSIGN - 80)))) != 0)))
                {
                    ErrorHandler.RecoverInline(this);
                }
                else
                {
                    ErrorHandler.ReportMatch(this);
                    Consume();
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ConditionalExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ConditionalOrExpressionContext conditionalOrExpression()
        {
            return GetRuleContext<ConditionalOrExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode QUESTION() { return GetToken(Java9Parser.QUESTION, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionContext expression()
        {
            return GetRuleContext<ExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(Java9Parser.COLON, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ConditionalExpressionContext conditionalExpression()
        {
            return GetRuleContext<ConditionalExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public LambdaExpressionContext lambdaExpression()
        {
            return GetRuleContext<LambdaExpressionContext>(0);
        }
        public ConditionalExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_conditionalExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterConditionalExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitConditionalExpression(this);
        }
    }

    [RuleVersion(0)]
    public ConditionalExpressionContext conditionalExpression()
    {
        ConditionalExpressionContext _localctx = new ConditionalExpressionContext(Context, State);
        EnterRule(_localctx, 446, RULE_conditionalExpression);
        try
        {
            State = 2759;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 316, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2750;
                        conditionalOrExpression(0);
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2751;
                        conditionalOrExpression(0);
                        State = 2752;
                        Match(QUESTION);
                        State = 2753;
                        expression();
                        State = 2754;
                        Match(COLON);
                        State = 2757;
                        ErrorHandler.Sync(this);
                        switch (Interpreter.AdaptivePredict(TokenStream, 315, Context))
                        {
                            case 1:
                                {
                                    State = 2755;
                                    conditionalExpression();
                                }
                                break;
                            case 2:
                                {
                                    State = 2756;
                                    lambdaExpression();
                                }
                                break;
                        }
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class ConditionalOrExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ConditionalAndExpressionContext conditionalAndExpression()
        {
            return GetRuleContext<ConditionalAndExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ConditionalOrExpressionContext conditionalOrExpression()
        {
            return GetRuleContext<ConditionalOrExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OR() { return GetToken(Java9Parser.OR, 0); }
        public ConditionalOrExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_conditionalOrExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterConditionalOrExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitConditionalOrExpression(this);
        }
    }

    [RuleVersion(0)]
    public ConditionalOrExpressionContext conditionalOrExpression()
    {
        return conditionalOrExpression(0);
    }

    private ConditionalOrExpressionContext conditionalOrExpression(int _p)
    {
        ParserRuleContext _parentctx = Context;
        int _parentState = State;
        ConditionalOrExpressionContext _localctx = new ConditionalOrExpressionContext(Context, _parentState);
        ConditionalOrExpressionContext _prevctx = _localctx;
        int _startState = 448;
        EnterRecursionRule(_localctx, 448, RULE_conditionalOrExpression, _p);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                {
                    State = 2762;
                    conditionalAndExpression(0);
                }
                Context.Stop = TokenStream.LT(-1);
                State = 2769;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 317, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        if (ParseListeners != null)
                            TriggerExitRuleEvent();
                        _prevctx = _localctx;
                        {
                            {
                                _localctx = new ConditionalOrExpressionContext(_parentctx, _parentState);
                                PushNewRecursionContext(_localctx, _startState, RULE_conditionalOrExpression);
                                State = 2764;
                                if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
                                State = 2765;
                                Match(OR);
                                State = 2766;
                                conditionalAndExpression(0);
                            }
                        }
                    }
                    State = 2771;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 317, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            UnrollRecursionContexts(_parentctx);
        }
        return _localctx;
    }

    public partial class ConditionalAndExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public InclusiveOrExpressionContext inclusiveOrExpression()
        {
            return GetRuleContext<InclusiveOrExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ConditionalAndExpressionContext conditionalAndExpression()
        {
            return GetRuleContext<ConditionalAndExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AND() { return GetToken(Java9Parser.AND, 0); }
        public ConditionalAndExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_conditionalAndExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterConditionalAndExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitConditionalAndExpression(this);
        }
    }

    [RuleVersion(0)]
    public ConditionalAndExpressionContext conditionalAndExpression()
    {
        return conditionalAndExpression(0);
    }

    private ConditionalAndExpressionContext conditionalAndExpression(int _p)
    {
        ParserRuleContext _parentctx = Context;
        int _parentState = State;
        ConditionalAndExpressionContext _localctx = new ConditionalAndExpressionContext(Context, _parentState);
        ConditionalAndExpressionContext _prevctx = _localctx;
        int _startState = 450;
        EnterRecursionRule(_localctx, 450, RULE_conditionalAndExpression, _p);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                {
                    State = 2773;
                    inclusiveOrExpression(0);
                }
                Context.Stop = TokenStream.LT(-1);
                State = 2780;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 318, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        if (ParseListeners != null)
                            TriggerExitRuleEvent();
                        _prevctx = _localctx;
                        {
                            {
                                _localctx = new ConditionalAndExpressionContext(_parentctx, _parentState);
                                PushNewRecursionContext(_localctx, _startState, RULE_conditionalAndExpression);
                                State = 2775;
                                if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
                                State = 2776;
                                Match(AND);
                                State = 2777;
                                inclusiveOrExpression(0);
                            }
                        }
                    }
                    State = 2782;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 318, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            UnrollRecursionContexts(_parentctx);
        }
        return _localctx;
    }

    public partial class InclusiveOrExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ExclusiveOrExpressionContext exclusiveOrExpression()
        {
            return GetRuleContext<ExclusiveOrExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public InclusiveOrExpressionContext inclusiveOrExpression()
        {
            return GetRuleContext<InclusiveOrExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BITOR() { return GetToken(Java9Parser.BITOR, 0); }
        public InclusiveOrExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_inclusiveOrExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterInclusiveOrExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitInclusiveOrExpression(this);
        }
    }

    [RuleVersion(0)]
    public InclusiveOrExpressionContext inclusiveOrExpression()
    {
        return inclusiveOrExpression(0);
    }

    private InclusiveOrExpressionContext inclusiveOrExpression(int _p)
    {
        ParserRuleContext _parentctx = Context;
        int _parentState = State;
        InclusiveOrExpressionContext _localctx = new InclusiveOrExpressionContext(Context, _parentState);
        InclusiveOrExpressionContext _prevctx = _localctx;
        int _startState = 452;
        EnterRecursionRule(_localctx, 452, RULE_inclusiveOrExpression, _p);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                {
                    State = 2784;
                    exclusiveOrExpression(0);
                }
                Context.Stop = TokenStream.LT(-1);
                State = 2791;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 319, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        if (ParseListeners != null)
                            TriggerExitRuleEvent();
                        _prevctx = _localctx;
                        {
                            {
                                _localctx = new InclusiveOrExpressionContext(_parentctx, _parentState);
                                PushNewRecursionContext(_localctx, _startState, RULE_inclusiveOrExpression);
                                State = 2786;
                                if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
                                State = 2787;
                                Match(BITOR);
                                State = 2788;
                                exclusiveOrExpression(0);
                            }
                        }
                    }
                    State = 2793;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 319, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            UnrollRecursionContexts(_parentctx);
        }
        return _localctx;
    }

    public partial class ExclusiveOrExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public AndExpressionContext andExpression()
        {
            return GetRuleContext<AndExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExclusiveOrExpressionContext exclusiveOrExpression()
        {
            return GetRuleContext<ExclusiveOrExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CARET() { return GetToken(Java9Parser.CARET, 0); }
        public ExclusiveOrExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_exclusiveOrExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterExclusiveOrExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitExclusiveOrExpression(this);
        }
    }

    [RuleVersion(0)]
    public ExclusiveOrExpressionContext exclusiveOrExpression()
    {
        return exclusiveOrExpression(0);
    }

    private ExclusiveOrExpressionContext exclusiveOrExpression(int _p)
    {
        ParserRuleContext _parentctx = Context;
        int _parentState = State;
        ExclusiveOrExpressionContext _localctx = new ExclusiveOrExpressionContext(Context, _parentState);
        ExclusiveOrExpressionContext _prevctx = _localctx;
        int _startState = 454;
        EnterRecursionRule(_localctx, 454, RULE_exclusiveOrExpression, _p);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                {
                    State = 2795;
                    andExpression(0);
                }
                Context.Stop = TokenStream.LT(-1);
                State = 2802;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 320, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        if (ParseListeners != null)
                            TriggerExitRuleEvent();
                        _prevctx = _localctx;
                        {
                            {
                                _localctx = new ExclusiveOrExpressionContext(_parentctx, _parentState);
                                PushNewRecursionContext(_localctx, _startState, RULE_exclusiveOrExpression);
                                State = 2797;
                                if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
                                State = 2798;
                                Match(CARET);
                                State = 2799;
                                andExpression(0);
                            }
                        }
                    }
                    State = 2804;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 320, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            UnrollRecursionContexts(_parentctx);
        }
        return _localctx;
    }

    public partial class AndExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public EqualityExpressionContext equalityExpression()
        {
            return GetRuleContext<EqualityExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AndExpressionContext andExpression()
        {
            return GetRuleContext<AndExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BITAND() { return GetToken(Java9Parser.BITAND, 0); }
        public AndExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_andExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterAndExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitAndExpression(this);
        }
    }

    [RuleVersion(0)]
    public AndExpressionContext andExpression()
    {
        return andExpression(0);
    }

    private AndExpressionContext andExpression(int _p)
    {
        ParserRuleContext _parentctx = Context;
        int _parentState = State;
        AndExpressionContext _localctx = new AndExpressionContext(Context, _parentState);
        AndExpressionContext _prevctx = _localctx;
        int _startState = 456;
        EnterRecursionRule(_localctx, 456, RULE_andExpression, _p);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                {
                    State = 2806;
                    equalityExpression(0);
                }
                Context.Stop = TokenStream.LT(-1);
                State = 2813;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 321, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        if (ParseListeners != null)
                            TriggerExitRuleEvent();
                        _prevctx = _localctx;
                        {
                            {
                                _localctx = new AndExpressionContext(_parentctx, _parentState);
                                PushNewRecursionContext(_localctx, _startState, RULE_andExpression);
                                State = 2808;
                                if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
                                State = 2809;
                                Match(BITAND);
                                State = 2810;
                                equalityExpression(0);
                            }
                        }
                    }
                    State = 2815;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 321, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            UnrollRecursionContexts(_parentctx);
        }
        return _localctx;
    }

    public partial class EqualityExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public RelationalExpressionContext relationalExpression()
        {
            return GetRuleContext<RelationalExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public EqualityExpressionContext equalityExpression()
        {
            return GetRuleContext<EqualityExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EQUAL() { return GetToken(Java9Parser.EQUAL, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOTEQUAL() { return GetToken(Java9Parser.NOTEQUAL, 0); }
        public EqualityExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_equalityExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterEqualityExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitEqualityExpression(this);
        }
    }

    [RuleVersion(0)]
    public EqualityExpressionContext equalityExpression()
    {
        return equalityExpression(0);
    }

    private EqualityExpressionContext equalityExpression(int _p)
    {
        ParserRuleContext _parentctx = Context;
        int _parentState = State;
        EqualityExpressionContext _localctx = new EqualityExpressionContext(Context, _parentState);
        EqualityExpressionContext _prevctx = _localctx;
        int _startState = 458;
        EnterRecursionRule(_localctx, 458, RULE_equalityExpression, _p);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                {
                    State = 2817;
                    relationalExpression(0);
                }
                Context.Stop = TokenStream.LT(-1);
                State = 2827;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 323, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        if (ParseListeners != null)
                            TriggerExitRuleEvent();
                        _prevctx = _localctx;
                        {
                            State = 2825;
                            ErrorHandler.Sync(this);
                            switch (Interpreter.AdaptivePredict(TokenStream, 322, Context))
                            {
                                case 1:
                                    {
                                        _localctx = new EqualityExpressionContext(_parentctx, _parentState);
                                        PushNewRecursionContext(_localctx, _startState, RULE_equalityExpression);
                                        State = 2819;
                                        if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
                                        State = 2820;
                                        Match(EQUAL);
                                        State = 2821;
                                        relationalExpression(0);
                                    }
                                    break;
                                case 2:
                                    {
                                        _localctx = new EqualityExpressionContext(_parentctx, _parentState);
                                        PushNewRecursionContext(_localctx, _startState, RULE_equalityExpression);
                                        State = 2822;
                                        if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
                                        State = 2823;
                                        Match(NOTEQUAL);
                                        State = 2824;
                                        relationalExpression(0);
                                    }
                                    break;
                            }
                        }
                    }
                    State = 2829;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 323, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            UnrollRecursionContexts(_parentctx);
        }
        return _localctx;
    }

    public partial class RelationalExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public ShiftExpressionContext shiftExpression()
        {
            return GetRuleContext<ShiftExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public RelationalExpressionContext relationalExpression()
        {
            return GetRuleContext<RelationalExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LT() { return GetToken(Java9Parser.LT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT() { return GetToken(Java9Parser.GT, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LE() { return GetToken(Java9Parser.LE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GE() { return GetToken(Java9Parser.GE, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INSTANCEOF() { return GetToken(Java9Parser.INSTANCEOF, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ReferenceTypeContext referenceType()
        {
            return GetRuleContext<ReferenceTypeContext>(0);
        }
        public RelationalExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_relationalExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterRelationalExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitRelationalExpression(this);
        }
    }

    [RuleVersion(0)]
    public RelationalExpressionContext relationalExpression()
    {
        return relationalExpression(0);
    }

    private RelationalExpressionContext relationalExpression(int _p)
    {
        ParserRuleContext _parentctx = Context;
        int _parentState = State;
        RelationalExpressionContext _localctx = new RelationalExpressionContext(Context, _parentState);
        RelationalExpressionContext _prevctx = _localctx;
        int _startState = 460;
        EnterRecursionRule(_localctx, 460, RULE_relationalExpression, _p);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                {
                    State = 2831;
                    shiftExpression(0);
                }
                Context.Stop = TokenStream.LT(-1);
                State = 2850;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 325, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        if (ParseListeners != null)
                            TriggerExitRuleEvent();
                        _prevctx = _localctx;
                        {
                            State = 2848;
                            ErrorHandler.Sync(this);
                            switch (Interpreter.AdaptivePredict(TokenStream, 324, Context))
                            {
                                case 1:
                                    {
                                        _localctx = new RelationalExpressionContext(_parentctx, _parentState);
                                        PushNewRecursionContext(_localctx, _startState, RULE_relationalExpression);
                                        State = 2833;
                                        if (!(Precpred(Context, 5))) throw new FailedPredicateException(this, "Precpred(Context, 5)");
                                        State = 2834;
                                        Match(LT);
                                        State = 2835;
                                        shiftExpression(0);
                                    }
                                    break;
                                case 2:
                                    {
                                        _localctx = new RelationalExpressionContext(_parentctx, _parentState);
                                        PushNewRecursionContext(_localctx, _startState, RULE_relationalExpression);
                                        State = 2836;
                                        if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
                                        State = 2837;
                                        Match(GT);
                                        State = 2838;
                                        shiftExpression(0);
                                    }
                                    break;
                                case 3:
                                    {
                                        _localctx = new RelationalExpressionContext(_parentctx, _parentState);
                                        PushNewRecursionContext(_localctx, _startState, RULE_relationalExpression);
                                        State = 2839;
                                        if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
                                        State = 2840;
                                        Match(LE);
                                        State = 2841;
                                        shiftExpression(0);
                                    }
                                    break;
                                case 4:
                                    {
                                        _localctx = new RelationalExpressionContext(_parentctx, _parentState);
                                        PushNewRecursionContext(_localctx, _startState, RULE_relationalExpression);
                                        State = 2842;
                                        if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
                                        State = 2843;
                                        Match(GE);
                                        State = 2844;
                                        shiftExpression(0);
                                    }
                                    break;
                                case 5:
                                    {
                                        _localctx = new RelationalExpressionContext(_parentctx, _parentState);
                                        PushNewRecursionContext(_localctx, _startState, RULE_relationalExpression);
                                        State = 2845;
                                        if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
                                        State = 2846;
                                        Match(INSTANCEOF);
                                        State = 2847;
                                        referenceType();
                                    }
                                    break;
                            }
                        }
                    }
                    State = 2852;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 325, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            UnrollRecursionContexts(_parentctx);
        }
        return _localctx;
    }

    public partial class ShiftExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public AdditiveExpressionContext additiveExpression()
        {
            return GetRuleContext<AdditiveExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ShiftExpressionContext shiftExpression()
        {
            return GetRuleContext<ShiftExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LT() { return GetTokens(Java9Parser.LT); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode LT(int i)
        {
            return GetToken(Java9Parser.LT, i);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] GT() { return GetTokens(Java9Parser.GT); }
        [System.Diagnostics.DebuggerNonUserCode]
        public ITerminalNode GT(int i)
        {
            return GetToken(Java9Parser.GT, i);
        }
        public ShiftExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_shiftExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterShiftExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitShiftExpression(this);
        }
    }

    [RuleVersion(0)]
    public ShiftExpressionContext shiftExpression()
    {
        return shiftExpression(0);
    }

    private ShiftExpressionContext shiftExpression(int _p)
    {
        ParserRuleContext _parentctx = Context;
        int _parentState = State;
        ShiftExpressionContext _localctx = new ShiftExpressionContext(Context, _parentState);
        ShiftExpressionContext _prevctx = _localctx;
        int _startState = 462;
        EnterRecursionRule(_localctx, 462, RULE_shiftExpression, _p);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                {
                    State = 2854;
                    additiveExpression(0);
                }
                Context.Stop = TokenStream.LT(-1);
                State = 2871;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 327, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        if (ParseListeners != null)
                            TriggerExitRuleEvent();
                        _prevctx = _localctx;
                        {
                            State = 2869;
                            ErrorHandler.Sync(this);
                            switch (Interpreter.AdaptivePredict(TokenStream, 326, Context))
                            {
                                case 1:
                                    {
                                        _localctx = new ShiftExpressionContext(_parentctx, _parentState);
                                        PushNewRecursionContext(_localctx, _startState, RULE_shiftExpression);
                                        State = 2856;
                                        if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
                                        State = 2857;
                                        Match(LT);
                                        State = 2858;
                                        Match(LT);
                                        State = 2859;
                                        additiveExpression(0);
                                    }
                                    break;
                                case 2:
                                    {
                                        _localctx = new ShiftExpressionContext(_parentctx, _parentState);
                                        PushNewRecursionContext(_localctx, _startState, RULE_shiftExpression);
                                        State = 2860;
                                        if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
                                        State = 2861;
                                        Match(GT);
                                        State = 2862;
                                        Match(GT);
                                        State = 2863;
                                        additiveExpression(0);
                                    }
                                    break;
                                case 3:
                                    {
                                        _localctx = new ShiftExpressionContext(_parentctx, _parentState);
                                        PushNewRecursionContext(_localctx, _startState, RULE_shiftExpression);
                                        State = 2864;
                                        if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
                                        State = 2865;
                                        Match(GT);
                                        State = 2866;
                                        Match(GT);
                                        State = 2867;
                                        Match(GT);
                                        State = 2868;
                                        additiveExpression(0);
                                    }
                                    break;
                            }
                        }
                    }
                    State = 2873;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 327, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            UnrollRecursionContexts(_parentctx);
        }
        return _localctx;
    }

    public partial class AdditiveExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public MultiplicativeExpressionContext multiplicativeExpression()
        {
            return GetRuleContext<MultiplicativeExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AdditiveExpressionContext additiveExpression()
        {
            return GetRuleContext<AdditiveExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ADD() { return GetToken(Java9Parser.ADD, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUB() { return GetToken(Java9Parser.SUB, 0); }
        public AdditiveExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_additiveExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterAdditiveExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitAdditiveExpression(this);
        }
    }

    [RuleVersion(0)]
    public AdditiveExpressionContext additiveExpression()
    {
        return additiveExpression(0);
    }

    private AdditiveExpressionContext additiveExpression(int _p)
    {
        ParserRuleContext _parentctx = Context;
        int _parentState = State;
        AdditiveExpressionContext _localctx = new AdditiveExpressionContext(Context, _parentState);
        AdditiveExpressionContext _prevctx = _localctx;
        int _startState = 464;
        EnterRecursionRule(_localctx, 464, RULE_additiveExpression, _p);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                {
                    State = 2875;
                    multiplicativeExpression(0);
                }
                Context.Stop = TokenStream.LT(-1);
                State = 2885;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 329, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        if (ParseListeners != null)
                            TriggerExitRuleEvent();
                        _prevctx = _localctx;
                        {
                            State = 2883;
                            ErrorHandler.Sync(this);
                            switch (Interpreter.AdaptivePredict(TokenStream, 328, Context))
                            {
                                case 1:
                                    {
                                        _localctx = new AdditiveExpressionContext(_parentctx, _parentState);
                                        PushNewRecursionContext(_localctx, _startState, RULE_additiveExpression);
                                        State = 2877;
                                        if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
                                        State = 2878;
                                        Match(ADD);
                                        State = 2879;
                                        multiplicativeExpression(0);
                                    }
                                    break;
                                case 2:
                                    {
                                        _localctx = new AdditiveExpressionContext(_parentctx, _parentState);
                                        PushNewRecursionContext(_localctx, _startState, RULE_additiveExpression);
                                        State = 2880;
                                        if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
                                        State = 2881;
                                        Match(SUB);
                                        State = 2882;
                                        multiplicativeExpression(0);
                                    }
                                    break;
                            }
                        }
                    }
                    State = 2887;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 329, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            UnrollRecursionContexts(_parentctx);
        }
        return _localctx;
    }

    public partial class MultiplicativeExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public UnaryExpressionContext unaryExpression()
        {
            return GetRuleContext<UnaryExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public MultiplicativeExpressionContext multiplicativeExpression()
        {
            return GetRuleContext<MultiplicativeExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MUL() { return GetToken(Java9Parser.MUL, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIV() { return GetToken(Java9Parser.DIV, 0); }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MOD() { return GetToken(Java9Parser.MOD, 0); }
        public MultiplicativeExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_multiplicativeExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterMultiplicativeExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitMultiplicativeExpression(this);
        }
    }

    [RuleVersion(0)]
    public MultiplicativeExpressionContext multiplicativeExpression()
    {
        return multiplicativeExpression(0);
    }

    private MultiplicativeExpressionContext multiplicativeExpression(int _p)
    {
        ParserRuleContext _parentctx = Context;
        int _parentState = State;
        MultiplicativeExpressionContext _localctx = new MultiplicativeExpressionContext(Context, _parentState);
        MultiplicativeExpressionContext _prevctx = _localctx;
        int _startState = 466;
        EnterRecursionRule(_localctx, 466, RULE_multiplicativeExpression, _p);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                {
                    State = 2889;
                    unaryExpression();
                }
                Context.Stop = TokenStream.LT(-1);
                State = 2902;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 331, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        if (ParseListeners != null)
                            TriggerExitRuleEvent();
                        _prevctx = _localctx;
                        {
                            State = 2900;
                            ErrorHandler.Sync(this);
                            switch (Interpreter.AdaptivePredict(TokenStream, 330, Context))
                            {
                                case 1:
                                    {
                                        _localctx = new MultiplicativeExpressionContext(_parentctx, _parentState);
                                        PushNewRecursionContext(_localctx, _startState, RULE_multiplicativeExpression);
                                        State = 2891;
                                        if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
                                        State = 2892;
                                        Match(MUL);
                                        State = 2893;
                                        unaryExpression();
                                    }
                                    break;
                                case 2:
                                    {
                                        _localctx = new MultiplicativeExpressionContext(_parentctx, _parentState);
                                        PushNewRecursionContext(_localctx, _startState, RULE_multiplicativeExpression);
                                        State = 2894;
                                        if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
                                        State = 2895;
                                        Match(DIV);
                                        State = 2896;
                                        unaryExpression();
                                    }
                                    break;
                                case 3:
                                    {
                                        _localctx = new MultiplicativeExpressionContext(_parentctx, _parentState);
                                        PushNewRecursionContext(_localctx, _startState, RULE_multiplicativeExpression);
                                        State = 2897;
                                        if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
                                        State = 2898;
                                        Match(MOD);
                                        State = 2899;
                                        unaryExpression();
                                    }
                                    break;
                            }
                        }
                    }
                    State = 2904;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 331, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            UnrollRecursionContexts(_parentctx);
        }
        return _localctx;
    }

    public partial class UnaryExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public PreIncrementExpressionContext preIncrementExpression()
        {
            return GetRuleContext<PreIncrementExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PreDecrementExpressionContext preDecrementExpression()
        {
            return GetRuleContext<PreDecrementExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ADD() { return GetToken(Java9Parser.ADD, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnaryExpressionContext unaryExpression()
        {
            return GetRuleContext<UnaryExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUB() { return GetToken(Java9Parser.SUB, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnaryExpressionNotPlusMinusContext unaryExpressionNotPlusMinus()
        {
            return GetRuleContext<UnaryExpressionNotPlusMinusContext>(0);
        }
        public UnaryExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_unaryExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterUnaryExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitUnaryExpression(this);
        }
    }

    [RuleVersion(0)]
    public UnaryExpressionContext unaryExpression()
    {
        UnaryExpressionContext _localctx = new UnaryExpressionContext(Context, State);
        EnterRule(_localctx, 468, RULE_unaryExpression);
        try
        {
            State = 2912;
            ErrorHandler.Sync(this);
            switch (TokenStream.LA(1))
            {
                case INC:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2905;
                        preIncrementExpression();
                    }
                    break;
                case DEC:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2906;
                        preDecrementExpression();
                    }
                    break;
                case ADD:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 2907;
                        Match(ADD);
                        State = 2908;
                        unaryExpression();
                    }
                    break;
                case SUB:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 2909;
                        Match(SUB);
                        State = 2910;
                        unaryExpression();
                    }
                    break;
                case T__0:
                case T__1:
                case T__2:
                case T__3:
                case T__4:
                case T__5:
                case T__6:
                case T__7:
                case T__8:
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
                case AT:
                case BANG:
                case TILDE:
                case Identifier:
                    EnterOuterAlt(_localctx, 5);
                    {
                        State = 2911;
                        unaryExpressionNotPlusMinus();
                    }
                    break;
                default:
                    throw new NoViableAltException(this);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PreIncrementExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INC() { return GetToken(Java9Parser.INC, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnaryExpressionContext unaryExpression()
        {
            return GetRuleContext<UnaryExpressionContext>(0);
        }
        public PreIncrementExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_preIncrementExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPreIncrementExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPreIncrementExpression(this);
        }
    }

    [RuleVersion(0)]
    public PreIncrementExpressionContext preIncrementExpression()
    {
        PreIncrementExpressionContext _localctx = new PreIncrementExpressionContext(Context, State);
        EnterRule(_localctx, 470, RULE_preIncrementExpression);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2914;
                Match(INC);
                State = 2915;
                unaryExpression();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PreDecrementExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEC() { return GetToken(Java9Parser.DEC, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnaryExpressionContext unaryExpression()
        {
            return GetRuleContext<UnaryExpressionContext>(0);
        }
        public PreDecrementExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_preDecrementExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPreDecrementExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPreDecrementExpression(this);
        }
    }

    [RuleVersion(0)]
    public PreDecrementExpressionContext preDecrementExpression()
    {
        PreDecrementExpressionContext _localctx = new PreDecrementExpressionContext(Context, State);
        EnterRule(_localctx, 472, RULE_preDecrementExpression);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2917;
                Match(DEC);
                State = 2918;
                unaryExpression();
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class UnaryExpressionNotPlusMinusContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public PostfixExpressionContext postfixExpression()
        {
            return GetRuleContext<PostfixExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TILDE() { return GetToken(Java9Parser.TILDE, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnaryExpressionContext unaryExpression()
        {
            return GetRuleContext<UnaryExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BANG() { return GetToken(Java9Parser.BANG, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public CastExpressionContext castExpression()
        {
            return GetRuleContext<CastExpressionContext>(0);
        }
        public UnaryExpressionNotPlusMinusContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_unaryExpressionNotPlusMinus; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterUnaryExpressionNotPlusMinus(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitUnaryExpressionNotPlusMinus(this);
        }
    }

    [RuleVersion(0)]
    public UnaryExpressionNotPlusMinusContext unaryExpressionNotPlusMinus()
    {
        UnaryExpressionNotPlusMinusContext _localctx = new UnaryExpressionNotPlusMinusContext(Context, State);
        EnterRule(_localctx, 474, RULE_unaryExpressionNotPlusMinus);
        try
        {
            State = 2926;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 333, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2920;
                        postfixExpression();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2921;
                        Match(TILDE);
                        State = 2922;
                        unaryExpression();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 2923;
                        Match(BANG);
                        State = 2924;
                        unaryExpression();
                    }
                    break;
                case 4:
                    EnterOuterAlt(_localctx, 4);
                    {
                        State = 2925;
                        castExpression();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PostfixExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimaryContext primary()
        {
            return GetRuleContext<PrimaryContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ExpressionNameContext expressionName()
        {
            return GetRuleContext<ExpressionNameContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PostIncrementExpression_lf_postfixExpressionContext[] postIncrementExpression_lf_postfixExpression()
        {
            return GetRuleContexts<PostIncrementExpression_lf_postfixExpressionContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PostIncrementExpression_lf_postfixExpressionContext postIncrementExpression_lf_postfixExpression(int i)
        {
            return GetRuleContext<PostIncrementExpression_lf_postfixExpressionContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PostDecrementExpression_lf_postfixExpressionContext[] postDecrementExpression_lf_postfixExpression()
        {
            return GetRuleContexts<PostDecrementExpression_lf_postfixExpressionContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public PostDecrementExpression_lf_postfixExpressionContext postDecrementExpression_lf_postfixExpression(int i)
        {
            return GetRuleContext<PostDecrementExpression_lf_postfixExpressionContext>(i);
        }
        public PostfixExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_postfixExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPostfixExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPostfixExpression(this);
        }
    }

    [RuleVersion(0)]
    public PostfixExpressionContext postfixExpression()
    {
        PostfixExpressionContext _localctx = new PostfixExpressionContext(Context, State);
        EnterRule(_localctx, 476, RULE_postfixExpression);
        try
        {
            int _alt;
            EnterOuterAlt(_localctx, 1);
            {
                State = 2930;
                ErrorHandler.Sync(this);
                switch (Interpreter.AdaptivePredict(TokenStream, 334, Context))
                {
                    case 1:
                        {
                            State = 2928;
                            primary();
                        }
                        break;
                    case 2:
                        {
                            State = 2929;
                            expressionName();
                        }
                        break;
                }
                State = 2936;
                ErrorHandler.Sync(this);
                _alt = Interpreter.AdaptivePredict(TokenStream, 336, Context);
                while (_alt != 2 && _alt != global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER)
                {
                    if (_alt == 1)
                    {
                        {
                            State = 2934;
                            ErrorHandler.Sync(this);
                            switch (TokenStream.LA(1))
                            {
                                case INC:
                                    {
                                        State = 2932;
                                        postIncrementExpression_lf_postfixExpression();
                                    }
                                    break;
                                case DEC:
                                    {
                                        State = 2933;
                                        postDecrementExpression_lf_postfixExpression();
                                    }
                                    break;
                                default:
                                    throw new NoViableAltException(this);
                            }
                        }
                    }
                    State = 2938;
                    ErrorHandler.Sync(this);
                    _alt = Interpreter.AdaptivePredict(TokenStream, 336, Context);
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PostIncrementExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public PostfixExpressionContext postfixExpression()
        {
            return GetRuleContext<PostfixExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INC() { return GetToken(Java9Parser.INC, 0); }
        public PostIncrementExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_postIncrementExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPostIncrementExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPostIncrementExpression(this);
        }
    }

    [RuleVersion(0)]
    public PostIncrementExpressionContext postIncrementExpression()
    {
        PostIncrementExpressionContext _localctx = new PostIncrementExpressionContext(Context, State);
        EnterRule(_localctx, 478, RULE_postIncrementExpression);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2939;
                postfixExpression();
                State = 2940;
                Match(INC);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PostIncrementExpression_lf_postfixExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INC() { return GetToken(Java9Parser.INC, 0); }
        public PostIncrementExpression_lf_postfixExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_postIncrementExpression_lf_postfixExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPostIncrementExpression_lf_postfixExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPostIncrementExpression_lf_postfixExpression(this);
        }
    }

    [RuleVersion(0)]
    public PostIncrementExpression_lf_postfixExpressionContext postIncrementExpression_lf_postfixExpression()
    {
        PostIncrementExpression_lf_postfixExpressionContext _localctx = new PostIncrementExpression_lf_postfixExpressionContext(Context, State);
        EnterRule(_localctx, 480, RULE_postIncrementExpression_lf_postfixExpression);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2942;
                Match(INC);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PostDecrementExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode]
        public PostfixExpressionContext postfixExpression()
        {
            return GetRuleContext<PostfixExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEC() { return GetToken(Java9Parser.DEC, 0); }
        public PostDecrementExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_postDecrementExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPostDecrementExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPostDecrementExpression(this);
        }
    }

    [RuleVersion(0)]
    public PostDecrementExpressionContext postDecrementExpression()
    {
        PostDecrementExpressionContext _localctx = new PostDecrementExpressionContext(Context, State);
        EnterRule(_localctx, 482, RULE_postDecrementExpression);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2944;
                postfixExpression();
                State = 2945;
                Match(DEC);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class PostDecrementExpression_lf_postfixExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEC() { return GetToken(Java9Parser.DEC, 0); }
        public PostDecrementExpression_lf_postfixExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_postDecrementExpression_lf_postfixExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterPostDecrementExpression_lf_postfixExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitPostDecrementExpression_lf_postfixExpression(this);
        }
    }

    [RuleVersion(0)]
    public PostDecrementExpression_lf_postfixExpressionContext postDecrementExpression_lf_postfixExpression()
    {
        PostDecrementExpression_lf_postfixExpressionContext _localctx = new PostDecrementExpression_lf_postfixExpressionContext(Context, State);
        EnterRule(_localctx, 484, RULE_postDecrementExpression_lf_postfixExpression);
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2947;
                Match(DEC);
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class CastExpressionContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(Java9Parser.LPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public PrimitiveTypeContext primitiveType()
        {
            return GetRuleContext<PrimitiveTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(Java9Parser.RPAREN, 0); }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnaryExpressionContext unaryExpression()
        {
            return GetRuleContext<UnaryExpressionContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public ReferenceTypeContext referenceType()
        {
            return GetRuleContext<ReferenceTypeContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public UnaryExpressionNotPlusMinusContext unaryExpressionNotPlusMinus()
        {
            return GetRuleContext<UnaryExpressionNotPlusMinusContext>(0);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AdditionalBoundContext[] additionalBound()
        {
            return GetRuleContexts<AdditionalBoundContext>();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public AdditionalBoundContext additionalBound(int i)
        {
            return GetRuleContext<AdditionalBoundContext>(i);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public LambdaExpressionContext lambdaExpression()
        {
            return GetRuleContext<LambdaExpressionContext>(0);
        }
        public CastExpressionContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_castExpression; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterCastExpression(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitCastExpression(this);
        }
    }

    [RuleVersion(0)]
    public CastExpressionContext castExpression()
    {
        CastExpressionContext _localctx = new CastExpressionContext(Context, State);
        EnterRule(_localctx, 486, RULE_castExpression);
        int _la;
        try
        {
            State = 2976;
            ErrorHandler.Sync(this);
            switch (Interpreter.AdaptivePredict(TokenStream, 339, Context))
            {
                case 1:
                    EnterOuterAlt(_localctx, 1);
                    {
                        State = 2949;
                        Match(LPAREN);
                        State = 2950;
                        primitiveType();
                        State = 2951;
                        Match(RPAREN);
                        State = 2952;
                        unaryExpression();
                    }
                    break;
                case 2:
                    EnterOuterAlt(_localctx, 2);
                    {
                        State = 2954;
                        Match(LPAREN);
                        State = 2955;
                        referenceType();
                        State = 2959;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == BITAND)
                        {
                            {
                                {
                                    State = 2956;
                                    additionalBound();
                                }
                            }
                            State = 2961;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 2962;
                        Match(RPAREN);
                        State = 2963;
                        unaryExpressionNotPlusMinus();
                    }
                    break;
                case 3:
                    EnterOuterAlt(_localctx, 3);
                    {
                        State = 2965;
                        Match(LPAREN);
                        State = 2966;
                        referenceType();
                        State = 2970;
                        ErrorHandler.Sync(this);
                        _la = TokenStream.LA(1);
                        while (_la == BITAND)
                        {
                            {
                                {
                                    State = 2967;
                                    additionalBound();
                                }
                            }
                            State = 2972;
                            ErrorHandler.Sync(this);
                            _la = TokenStream.LA(1);
                        }
                        State = 2973;
                        Match(RPAREN);
                        State = 2974;
                        lambdaExpression();
                    }
                    break;
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public partial class IdentifierContext : ParserRuleContext
    {
        [System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Identifier() { return GetToken(Java9Parser.Identifier, 0); }
        public IdentifierContext(ParserRuleContext parent, int invokingState)
            : base(parent, invokingState)
        {
        }
        public override int RuleIndex { get { return RULE_identifier; } }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void EnterRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.EnterIdentifier(this);
        }
        [System.Diagnostics.DebuggerNonUserCode]
        public override void ExitRule(IParseTreeListener listener)
        {
            IJava9Listener typedListener = listener as IJava9Listener;
            if (typedListener != null) typedListener.ExitIdentifier(this);
        }
    }

    [RuleVersion(0)]
    public IdentifierContext identifier()
    {
        IdentifierContext _localctx = new IdentifierContext(Context, State);
        EnterRule(_localctx, 488, RULE_identifier);
        int _la;
        try
        {
            EnterOuterAlt(_localctx, 1);
            {
                State = 2978;
                _la = TokenStream.LA(1);
                if (!((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8))) != 0) || _la == Identifier))
                {
                    ErrorHandler.RecoverInline(this);
                }
                else
                {
                    ErrorHandler.ReportMatch(this);
                    Consume();
                }
            }
        }
        catch (RecognitionException re)
        {
            _localctx.exception = re;
            ErrorHandler.ReportError(this, re);
            ErrorHandler.Recover(this, re);
        }
        finally
        {
            ExitRule();
        }
        return _localctx;
    }

    public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex)
    {
        switch (ruleIndex)
        {
            case 25: return moduleName_sempred((ModuleNameContext)_localctx, predIndex);
            case 26: return packageName_sempred((PackageNameContext)_localctx, predIndex);
            case 28: return packageOrTypeName_sempred((PackageOrTypeNameContext)_localctx, predIndex);
            case 31: return ambiguousName_sempred((AmbiguousNameContext)_localctx, predIndex);
            case 224: return conditionalOrExpression_sempred((ConditionalOrExpressionContext)_localctx, predIndex);
            case 225: return conditionalAndExpression_sempred((ConditionalAndExpressionContext)_localctx, predIndex);
            case 226: return inclusiveOrExpression_sempred((InclusiveOrExpressionContext)_localctx, predIndex);
            case 227: return exclusiveOrExpression_sempred((ExclusiveOrExpressionContext)_localctx, predIndex);
            case 228: return andExpression_sempred((AndExpressionContext)_localctx, predIndex);
            case 229: return equalityExpression_sempred((EqualityExpressionContext)_localctx, predIndex);
            case 230: return relationalExpression_sempred((RelationalExpressionContext)_localctx, predIndex);
            case 231: return shiftExpression_sempred((ShiftExpressionContext)_localctx, predIndex);
            case 232: return additiveExpression_sempred((AdditiveExpressionContext)_localctx, predIndex);
            case 233: return multiplicativeExpression_sempred((MultiplicativeExpressionContext)_localctx, predIndex);
        }
        return true;
    }
    private bool moduleName_sempred(ModuleNameContext _localctx, int predIndex)
    {
        switch (predIndex)
        {
            case 0: return Precpred(Context, 1);
        }
        return true;
    }
    private bool packageName_sempred(PackageNameContext _localctx, int predIndex)
    {
        switch (predIndex)
        {
            case 1: return Precpred(Context, 1);
        }
        return true;
    }
    private bool packageOrTypeName_sempred(PackageOrTypeNameContext _localctx, int predIndex)
    {
        switch (predIndex)
        {
            case 2: return Precpred(Context, 1);
        }
        return true;
    }
    private bool ambiguousName_sempred(AmbiguousNameContext _localctx, int predIndex)
    {
        switch (predIndex)
        {
            case 3: return Precpred(Context, 1);
        }
        return true;
    }
    private bool conditionalOrExpression_sempred(ConditionalOrExpressionContext _localctx, int predIndex)
    {
        switch (predIndex)
        {
            case 4: return Precpred(Context, 1);
        }
        return true;
    }
    private bool conditionalAndExpression_sempred(ConditionalAndExpressionContext _localctx, int predIndex)
    {
        switch (predIndex)
        {
            case 5: return Precpred(Context, 1);
        }
        return true;
    }
    private bool inclusiveOrExpression_sempred(InclusiveOrExpressionContext _localctx, int predIndex)
    {
        switch (predIndex)
        {
            case 6: return Precpred(Context, 1);
        }
        return true;
    }
    private bool exclusiveOrExpression_sempred(ExclusiveOrExpressionContext _localctx, int predIndex)
    {
        switch (predIndex)
        {
            case 7: return Precpred(Context, 1);
        }
        return true;
    }
    private bool andExpression_sempred(AndExpressionContext _localctx, int predIndex)
    {
        switch (predIndex)
        {
            case 8: return Precpred(Context, 1);
        }
        return true;
    }
    private bool equalityExpression_sempred(EqualityExpressionContext _localctx, int predIndex)
    {
        switch (predIndex)
        {
            case 9: return Precpred(Context, 2);
            case 10: return Precpred(Context, 1);
        }
        return true;
    }
    private bool relationalExpression_sempred(RelationalExpressionContext _localctx, int predIndex)
    {
        switch (predIndex)
        {
            case 11: return Precpred(Context, 5);
            case 12: return Precpred(Context, 4);
            case 13: return Precpred(Context, 3);
            case 14: return Precpred(Context, 2);
            case 15: return Precpred(Context, 1);
        }
        return true;
    }
    private bool shiftExpression_sempred(ShiftExpressionContext _localctx, int predIndex)
    {
        switch (predIndex)
        {
            case 16: return Precpred(Context, 3);
            case 17: return Precpred(Context, 2);
            case 18: return Precpred(Context, 1);
        }
        return true;
    }
    private bool additiveExpression_sempred(AdditiveExpressionContext _localctx, int predIndex)
    {
        switch (predIndex)
        {
            case 19: return Precpred(Context, 2);
            case 20: return Precpred(Context, 1);
        }
        return true;
    }
    private bool multiplicativeExpression_sempred(MultiplicativeExpressionContext _localctx, int predIndex)
    {
        switch (predIndex)
        {
            case 21: return Precpred(Context, 3);
            case 22: return Precpred(Context, 2);
            case 23: return Precpred(Context, 1);
        }
        return true;
    }

    private static int[] _serializedATN = {
        4,1,118,2981,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,
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
        2,231,7,231,2,232,7,232,2,233,7,233,2,234,7,234,2,235,7,235,2,236,7,236,
        2,237,7,237,2,238,7,238,2,239,7,239,2,240,7,240,2,241,7,241,2,242,7,242,
        2,243,7,243,2,244,7,244,1,0,1,0,1,1,5,1,494,8,1,10,1,12,1,497,9,1,1,1,
        1,1,5,1,501,8,1,10,1,12,1,504,9,1,1,1,3,1,507,8,1,1,2,1,2,3,2,511,8,2,
        1,3,1,3,1,4,1,4,1,5,1,5,1,5,3,5,520,8,5,1,6,1,6,3,6,524,8,6,1,6,1,6,5,
        6,528,8,6,10,6,12,6,531,9,6,1,7,5,7,534,8,7,10,7,12,7,537,9,7,1,7,1,7,
        3,7,541,8,7,1,7,1,7,1,7,5,7,546,8,7,10,7,12,7,549,9,7,1,7,1,7,3,7,553,
        8,7,3,7,555,8,7,1,8,1,8,5,8,559,8,8,10,8,12,8,562,9,8,1,8,1,8,3,8,566,
        8,8,1,9,5,9,569,8,9,10,9,12,9,572,9,9,1,9,1,9,3,9,576,8,9,1,10,1,10,1,
        11,1,11,1,12,1,12,1,13,5,13,585,8,13,10,13,12,13,588,9,13,1,13,1,13,1,
        14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,3,14,601,8,14,1,15,5,15,604,
        8,15,10,15,12,15,607,9,15,1,15,1,15,1,15,5,15,612,8,15,10,15,12,15,615,
        9,15,1,15,1,15,5,15,619,8,15,10,15,12,15,622,9,15,1,16,5,16,625,8,16,10,
        16,12,16,628,9,16,1,16,1,16,3,16,632,8,16,1,17,1,17,1,18,1,18,1,18,1,18,
        1,18,5,18,641,8,18,10,18,12,18,644,9,18,3,18,646,8,18,1,19,1,19,1,19,1,
        20,1,20,1,20,1,20,1,21,1,21,1,21,5,21,658,8,21,10,21,12,21,661,9,21,1,
        22,1,22,3,22,665,8,22,1,23,5,23,668,8,23,10,23,12,23,671,9,23,1,23,1,23,
        3,23,675,8,23,1,24,1,24,1,24,1,24,3,24,681,8,24,1,25,1,25,1,25,1,25,1,
        25,1,25,5,25,689,8,25,10,25,12,25,692,9,25,1,26,1,26,1,26,1,26,1,26,1,
        26,5,26,700,8,26,10,26,12,26,703,9,26,1,27,1,27,1,27,1,27,1,27,3,27,710,
        8,27,1,28,1,28,1,28,1,28,1,28,1,28,5,28,718,8,28,10,28,12,28,721,9,28,
        1,29,1,29,1,29,1,29,1,29,3,29,728,8,29,1,30,1,30,1,31,1,31,1,31,1,31,1,
        31,1,31,5,31,738,8,31,10,31,12,31,741,9,31,1,32,1,32,3,32,745,8,32,1,33,
        3,33,748,8,33,1,33,5,33,751,8,33,10,33,12,33,754,9,33,1,33,5,33,757,8,
        33,10,33,12,33,760,9,33,1,33,1,33,1,34,5,34,765,8,34,10,34,12,34,768,9,
        34,1,34,1,34,1,35,5,35,773,8,35,10,35,12,35,776,9,35,1,35,1,35,1,35,1,
        35,1,36,1,36,1,37,1,37,1,37,1,37,3,37,788,8,37,1,38,1,38,1,38,1,38,1,39,
        1,39,1,39,1,39,1,39,1,39,1,40,1,40,1,40,1,40,1,40,1,40,1,40,1,41,1,41,
        1,41,1,41,1,41,1,41,1,41,1,42,1,42,1,42,3,42,817,8,42,1,43,5,43,820,8,
        43,10,43,12,43,823,9,43,1,43,3,43,826,8,43,1,43,1,43,1,43,1,43,5,43,832,
        8,43,10,43,12,43,835,9,43,1,43,1,43,1,44,1,44,5,44,841,8,44,10,44,12,44,
        844,9,44,1,44,1,44,1,44,1,44,1,44,1,44,1,44,1,44,1,44,5,44,855,8,44,10,
        44,12,44,858,9,44,3,44,860,8,44,1,44,1,44,1,44,1,44,1,44,1,44,1,44,1,44,
        5,44,870,8,44,10,44,12,44,873,9,44,3,44,875,8,44,1,44,1,44,1,44,1,44,1,
        44,1,44,1,44,1,44,1,44,1,44,1,44,1,44,5,44,889,8,44,10,44,12,44,892,9,
        44,1,44,1,44,3,44,896,8,44,1,45,1,45,1,46,1,46,3,46,902,8,46,1,47,5,47,
        905,8,47,10,47,12,47,908,9,47,1,47,1,47,1,47,3,47,913,8,47,1,47,3,47,916,
        8,47,1,47,3,47,919,8,47,1,47,1,47,1,48,1,48,1,48,1,48,1,48,1,48,1,48,1,
        48,3,48,931,8,48,1,49,1,49,1,49,1,49,1,50,1,50,1,50,5,50,940,8,50,10,50,
        12,50,943,9,50,1,51,1,51,1,51,1,52,1,52,1,52,1,53,1,53,1,53,5,53,954,8,
        53,10,53,12,53,957,9,53,1,54,1,54,5,54,961,8,54,10,54,12,54,964,9,54,1,
        54,1,54,1,55,1,55,1,55,1,55,3,55,972,8,55,1,56,1,56,1,56,1,56,1,56,3,56,
        979,8,56,1,57,5,57,982,8,57,10,57,12,57,985,9,57,1,57,1,57,1,57,1,57,1,
        58,1,58,1,58,1,58,1,58,1,58,1,58,1,58,3,58,999,8,58,1,59,1,59,1,59,5,59,
        1004,8,59,10,59,12,59,1007,9,59,1,60,1,60,1,60,3,60,1012,8,60,1,61,1,61,
        3,61,1016,8,61,1,62,1,62,3,62,1020,8,62,1,63,1,63,3,63,1024,8,63,1,64,
        1,64,3,64,1028,8,64,1,65,1,65,1,65,3,65,1033,8,65,1,66,1,66,3,66,1037,
        8,66,1,66,1,66,5,66,1041,8,66,10,66,12,66,1044,9,66,1,67,1,67,3,67,1048,
        8,67,1,67,1,67,1,67,5,67,1053,8,67,10,67,12,67,1056,9,67,1,67,1,67,3,67,
        1060,8,67,3,67,1062,8,67,1,68,1,68,5,68,1066,8,68,10,68,12,68,1069,9,68,
        1,68,1,68,3,68,1073,8,68,1,69,1,69,3,69,1077,8,69,1,70,1,70,1,71,1,71,
        1,72,1,72,1,73,1,73,1,74,1,74,1,74,1,74,1,74,1,74,1,74,1,74,1,74,3,74,
        1096,8,74,1,75,5,75,1099,8,75,10,75,12,75,1102,9,75,1,75,1,75,1,75,1,76,
        1,76,1,76,1,76,1,76,1,76,1,76,1,76,1,76,1,76,3,76,1117,8,76,1,77,1,77,
        1,77,3,77,1122,8,77,1,77,1,77,5,77,1126,8,77,10,77,12,77,1129,9,77,1,77,
        1,77,1,77,3,77,1134,8,77,3,77,1136,8,77,1,78,1,78,3,78,1140,8,78,1,79,
        1,79,1,79,3,79,1145,8,79,1,79,1,79,3,79,1149,8,79,1,80,1,80,1,80,1,80,
        1,80,1,80,3,80,1157,8,80,1,81,1,81,1,81,5,81,1162,8,81,10,81,12,81,1165,
        9,81,1,81,1,81,1,81,5,81,1170,8,81,10,81,12,81,1173,9,81,3,81,1175,8,81,
        1,82,5,82,1178,8,82,10,82,12,82,1181,9,82,1,82,1,82,1,82,1,83,1,83,3,83,
        1188,8,83,1,84,5,84,1191,8,84,10,84,12,84,1194,9,84,1,84,1,84,5,84,1198,
        8,84,10,84,12,84,1201,9,84,1,84,1,84,1,84,1,84,3,84,1207,8,84,1,85,5,85,
        1210,8,85,10,85,12,85,1213,9,85,1,85,1,85,1,85,1,85,3,85,1219,8,85,1,85,
        1,85,1,86,1,86,1,86,1,87,1,87,1,87,5,87,1229,8,87,10,87,12,87,1232,9,87,
        1,88,1,88,3,88,1236,8,88,1,89,1,89,3,89,1240,8,89,1,90,1,90,1,91,1,91,
        1,91,1,92,5,92,1248,8,92,10,92,12,92,1251,9,92,1,92,1,92,3,92,1255,8,92,
        1,92,1,92,1,93,1,93,1,93,1,93,3,93,1263,8,93,1,94,3,94,1266,8,94,1,94,
        1,94,1,94,3,94,1271,8,94,1,94,1,94,1,95,1,95,1,96,1,96,3,96,1279,8,96,
        1,96,3,96,1282,8,96,1,96,1,96,1,97,3,97,1287,8,97,1,97,1,97,1,97,3,97,
        1292,8,97,1,97,1,97,1,97,3,97,1297,8,97,1,97,1,97,1,97,3,97,1302,8,97,
        1,97,1,97,1,97,1,97,1,97,3,97,1309,8,97,1,97,1,97,1,97,3,97,1314,8,97,
        1,97,1,97,1,97,1,97,1,97,1,97,3,97,1322,8,97,1,97,1,97,1,97,3,97,1327,
        8,97,1,97,1,97,1,97,3,97,1332,8,97,1,98,5,98,1335,8,98,10,98,12,98,1338,
        9,98,1,98,1,98,1,98,3,98,1343,8,98,1,98,1,98,1,99,1,99,3,99,1349,8,99,
        1,99,3,99,1352,8,99,1,99,3,99,1355,8,99,1,99,1,99,1,100,1,100,1,100,5,
        100,1362,8,100,10,100,12,100,1365,9,100,1,101,5,101,1368,8,101,10,101,
        12,101,1371,9,101,1,101,1,101,1,101,3,101,1376,8,101,1,101,3,101,1379,
        8,101,1,101,3,101,1382,8,101,1,102,1,102,1,103,1,103,5,103,1388,8,103,
        10,103,12,103,1391,9,103,1,104,1,104,3,104,1395,8,104,1,105,5,105,1398,
        8,105,10,105,12,105,1401,9,105,1,105,1,105,1,105,3,105,1406,8,105,1,105,
        3,105,1409,8,105,1,105,1,105,1,106,1,106,1,106,1,106,1,106,1,106,1,106,
        3,106,1420,8,106,1,107,1,107,1,107,1,108,1,108,5,108,1427,8,108,10,108,
        12,108,1430,9,108,1,108,1,108,1,109,1,109,1,109,1,109,1,109,3,109,1439,
        8,109,1,110,5,110,1442,8,110,10,110,12,110,1445,9,110,1,110,1,110,1,110,
        1,110,1,111,1,111,1,111,1,111,3,111,1455,8,111,1,112,5,112,1458,8,112,
        10,112,12,112,1461,9,112,1,112,1,112,1,112,1,113,1,113,1,113,1,113,1,113,
        1,113,1,113,3,113,1473,8,113,1,114,5,114,1476,8,114,10,114,12,114,1479,
        9,114,1,114,1,114,1,114,1,114,1,114,1,115,1,115,5,115,1488,8,115,10,115,
        12,115,1491,9,115,1,115,1,115,1,116,1,116,1,116,1,116,1,116,3,116,1500,
        8,116,1,117,5,117,1503,8,117,10,117,12,117,1506,9,117,1,117,1,117,1,117,
        1,117,1,117,3,117,1513,8,117,1,117,3,117,1516,8,117,1,117,1,117,1,118,
        1,118,1,118,3,118,1523,8,118,1,119,1,119,1,119,1,120,1,120,1,120,3,120,
        1531,8,120,1,121,1,121,1,121,1,121,3,121,1537,8,121,1,121,1,121,1,122,
        1,122,1,122,5,122,1544,8,122,10,122,12,122,1547,9,122,1,123,1,123,1,123,
        1,123,1,124,1,124,1,124,3,124,1556,8,124,1,125,1,125,3,125,1560,8,125,
        1,125,3,125,1563,8,125,1,125,1,125,1,126,1,126,1,126,5,126,1570,8,126,
        10,126,12,126,1573,9,126,1,127,1,127,1,127,1,128,1,128,1,128,1,128,1,128,
        1,128,1,129,1,129,3,129,1586,8,129,1,129,3,129,1589,8,129,1,129,1,129,
        1,130,1,130,1,130,5,130,1596,8,130,10,130,12,130,1599,9,130,1,131,1,131,
        3,131,1603,8,131,1,131,1,131,1,132,4,132,1608,8,132,11,132,12,132,1609,
        1,133,1,133,1,133,3,133,1615,8,133,1,134,1,134,1,134,1,135,5,135,1621,
        8,135,10,135,12,135,1624,9,135,1,135,1,135,1,135,1,136,1,136,1,136,1,136,
        1,136,1,136,3,136,1635,8,136,1,137,1,137,1,137,1,137,1,137,3,137,1642,
        8,137,1,138,1,138,1,138,1,138,1,138,1,138,1,138,1,138,1,138,1,138,1,138,
        1,138,3,138,1656,8,138,1,139,1,139,1,140,1,140,1,140,1,140,1,141,1,141,
        1,141,1,141,1,142,1,142,1,142,1,143,1,143,1,143,1,143,1,143,1,143,1,143,
        3,143,1678,8,143,1,144,1,144,1,144,1,144,1,144,1,144,1,145,1,145,1,145,
        1,145,1,145,1,145,1,145,1,145,1,146,1,146,1,146,1,146,1,146,1,146,1,146,
        1,146,1,147,1,147,1,147,1,147,1,147,1,147,1,147,1,147,1,147,1,147,3,147,
        1712,8,147,1,148,1,148,1,148,1,148,1,148,1,148,1,149,1,149,5,149,1722,
        8,149,10,149,12,149,1725,9,149,1,149,5,149,1728,8,149,10,149,12,149,1731,
        9,149,1,149,1,149,1,150,1,150,1,150,1,151,4,151,1739,8,151,11,151,12,151,
        1740,1,152,1,152,1,152,1,152,1,152,1,152,1,152,1,152,1,152,1,152,3,152,
        1753,8,152,1,153,1,153,1,154,1,154,1,154,1,154,1,154,1,154,1,155,1,155,
        1,155,1,155,1,155,1,155,1,156,1,156,1,156,1,156,1,156,1,156,1,156,1,156,
        1,157,1,157,3,157,1779,8,157,1,158,1,158,3,158,1783,8,158,1,159,1,159,
        1,159,3,159,1788,8,159,1,159,1,159,3,159,1792,8,159,1,159,1,159,3,159,
        1796,8,159,1,159,1,159,1,159,1,160,1,160,1,160,3,160,1804,8,160,1,160,
        1,160,3,160,1808,8,160,1,160,1,160,3,160,1812,8,160,1,160,1,160,1,160,
        1,161,1,161,3,161,1819,8,161,1,162,1,162,1,163,1,163,1,163,5,163,1826,
        8,163,10,163,12,163,1829,9,163,1,164,1,164,1,164,5,164,1834,8,164,10,164,
        12,164,1837,9,164,1,164,1,164,1,164,1,164,1,164,1,164,1,164,1,165,1,165,
        1,165,5,165,1849,8,165,10,165,12,165,1852,9,165,1,165,1,165,1,165,1,165,
        1,165,1,165,1,165,1,166,1,166,3,166,1863,8,166,1,166,1,166,1,167,1,167,
        3,167,1869,8,167,1,167,1,167,1,168,1,168,3,168,1875,8,168,1,168,1,168,
        1,169,1,169,1,169,1,169,1,170,1,170,1,170,1,170,1,170,1,170,1,171,1,171,
        1,171,1,171,1,171,1,171,1,171,3,171,1896,8,171,1,171,1,171,1,171,3,171,
        1901,8,171,1,172,4,172,1904,8,172,11,172,12,172,1905,1,173,1,173,1,173,
        1,173,1,173,1,173,1,174,5,174,1915,8,174,10,174,12,174,1918,9,174,1,174,
        1,174,1,174,1,175,1,175,1,175,5,175,1926,8,175,10,175,12,175,1929,9,175,
        1,176,1,176,1,176,1,177,1,177,1,177,1,177,3,177,1938,8,177,1,177,3,177,
        1941,8,177,1,178,1,178,1,178,3,178,1946,8,178,1,178,1,178,1,179,1,179,
        1,179,5,179,1953,8,179,10,179,12,179,1956,9,179,1,180,5,180,1959,8,180,
        10,180,12,180,1962,9,180,1,180,1,180,1,180,1,180,1,180,1,180,3,180,1970,
        8,180,1,181,1,181,3,181,1974,8,181,1,182,1,182,3,182,1978,8,182,1,182,
        5,182,1981,8,182,10,182,12,182,1984,9,182,1,183,1,183,1,183,1,183,1,183,
        1,183,1,183,1,183,1,183,1,183,1,183,1,183,1,183,1,183,1,183,1,183,3,183,
        2002,8,183,1,184,1,184,1,185,1,185,1,185,1,185,5,185,2010,8,185,10,185,
        12,185,2013,9,185,1,185,1,185,1,185,1,185,1,185,1,185,1,185,1,185,1,185,
        1,185,1,185,1,185,1,185,1,185,1,185,1,185,1,185,1,185,1,185,3,185,2034,
        8,185,1,186,1,186,1,186,1,186,1,186,3,186,2041,8,186,1,187,1,187,1,188,
        1,188,1,188,1,188,3,188,2049,8,188,1,189,1,189,1,189,1,189,5,189,2055,
        8,189,10,189,12,189,2058,9,189,1,189,1,189,1,189,1,189,1,189,1,189,5,189,
        2066,8,189,10,189,12,189,2069,9,189,1,189,1,189,1,189,1,189,1,189,1,189,
        1,189,1,189,1,189,1,189,1,189,1,189,1,189,1,189,1,189,1,189,1,189,1,189,
        1,189,1,189,3,189,2091,8,189,1,190,1,190,1,191,1,191,1,191,1,191,5,191,
        2099,8,191,10,191,12,191,2102,9,191,1,191,1,191,1,191,1,191,1,191,1,191,
        5,191,2110,8,191,10,191,12,191,2113,9,191,1,191,1,191,1,191,1,191,1,191,
        1,191,1,191,1,191,1,191,1,191,1,191,1,191,1,191,1,191,1,191,1,191,1,191,
        1,191,1,191,3,191,2134,8,191,1,192,1,192,1,192,3,192,2139,8,192,1,192,
        1,192,5,192,2143,8,192,10,192,12,192,2146,9,192,1,192,1,192,1,192,1,192,
        1,192,3,192,2153,8,192,1,193,1,193,3,193,2157,8,193,1,193,5,193,2160,8,
        193,10,193,12,193,2163,9,193,1,193,1,193,1,193,5,193,2168,8,193,10,193,
        12,193,2171,9,193,1,193,5,193,2174,8,193,10,193,12,193,2177,9,193,1,193,
        3,193,2180,8,193,1,193,1,193,3,193,2184,8,193,1,193,1,193,3,193,2188,8,
        193,1,193,1,193,1,193,1,193,3,193,2194,8,193,1,193,5,193,2197,8,193,10,
        193,12,193,2200,9,193,1,193,1,193,3,193,2204,8,193,1,193,1,193,3,193,2208,
        8,193,1,193,1,193,3,193,2212,8,193,1,193,1,193,1,193,1,193,3,193,2218,
        8,193,1,193,5,193,2221,8,193,10,193,12,193,2224,9,193,1,193,1,193,3,193,
        2228,8,193,1,193,1,193,3,193,2232,8,193,1,193,1,193,3,193,2236,8,193,3,
        193,2238,8,193,1,194,1,194,1,194,3,194,2243,8,194,1,194,5,194,2246,8,194,
        10,194,12,194,2249,9,194,1,194,1,194,3,194,2253,8,194,1,194,1,194,3,194,
        2257,8,194,1,194,1,194,3,194,2261,8,194,1,195,1,195,3,195,2265,8,195,1,
        195,5,195,2268,8,195,10,195,12,195,2271,9,195,1,195,1,195,1,195,5,195,
        2276,8,195,10,195,12,195,2279,9,195,1,195,5,195,2282,8,195,10,195,12,195,
        2285,9,195,1,195,3,195,2288,8,195,1,195,1,195,3,195,2292,8,195,1,195,1,
        195,3,195,2296,8,195,1,195,1,195,1,195,1,195,3,195,2302,8,195,1,195,5,
        195,2305,8,195,10,195,12,195,2308,9,195,1,195,1,195,3,195,2312,8,195,1,
        195,1,195,3,195,2316,8,195,1,195,1,195,3,195,2320,8,195,3,195,2322,8,195,
        1,196,1,196,1,196,3,196,2327,8,196,1,197,1,197,1,197,1,197,1,197,1,197,
        1,197,1,197,1,197,1,197,1,197,1,197,1,197,3,197,2342,8,197,1,198,1,198,
        1,198,1,199,1,199,1,199,1,199,1,199,1,199,1,199,1,199,1,199,3,199,2356,
        8,199,1,200,1,200,1,200,1,200,1,200,1,200,1,200,1,200,1,200,1,200,3,200,
        2368,8,200,1,200,1,200,1,200,1,200,1,200,5,200,2375,8,200,10,200,12,200,
        2378,9,200,1,201,1,201,1,201,1,201,1,201,1,201,1,201,1,201,1,201,1,201,
        5,201,2390,8,201,10,201,12,201,2393,9,201,1,202,1,202,1,202,1,202,1,202,
        1,202,1,202,1,202,1,202,1,202,3,202,2405,8,202,1,202,1,202,1,202,1,202,
        1,202,5,202,2412,8,202,10,202,12,202,2415,9,202,1,203,1,203,1,203,3,203,
        2420,8,203,1,203,1,203,1,203,1,203,1,203,3,203,2427,8,203,1,203,1,203,
        1,203,3,203,2432,8,203,1,203,1,203,1,203,1,203,1,203,3,203,2439,8,203,
        1,203,1,203,1,203,3,203,2444,8,203,1,203,1,203,1,203,1,203,1,203,3,203,
        2451,8,203,1,203,1,203,1,203,3,203,2456,8,203,1,203,1,203,1,203,1,203,
        1,203,3,203,2463,8,203,1,203,1,203,1,203,3,203,2468,8,203,1,203,1,203,
        1,203,1,203,1,203,1,203,1,203,3,203,2477,8,203,1,203,1,203,1,203,3,203,
        2482,8,203,1,203,1,203,3,203,2486,8,203,1,204,1,204,3,204,2490,8,204,1,
        204,1,204,1,204,3,204,2495,8,204,1,204,1,204,1,205,1,205,1,205,3,205,2502,
        8,205,1,205,1,205,1,205,1,205,1,205,3,205,2509,8,205,1,205,1,205,1,205,
        3,205,2514,8,205,1,205,1,205,1,205,1,205,1,205,3,205,2521,8,205,1,205,
        1,205,1,205,3,205,2526,8,205,1,205,1,205,1,205,1,205,1,205,3,205,2533,
        8,205,1,205,1,205,1,205,3,205,2538,8,205,1,205,1,205,1,205,1,205,1,205,
        1,205,1,205,3,205,2547,8,205,1,205,1,205,1,205,3,205,2552,8,205,1,205,
        1,205,3,205,2556,8,205,1,206,1,206,1,206,5,206,2561,8,206,10,206,12,206,
        2564,9,206,1,207,1,207,1,207,3,207,2569,8,207,1,207,1,207,1,207,1,207,
        1,207,3,207,2576,8,207,1,207,1,207,1,207,1,207,1,207,3,207,2583,8,207,
        1,207,1,207,1,207,1,207,1,207,3,207,2590,8,207,1,207,1,207,1,207,1,207,
        1,207,1,207,3,207,2598,8,207,1,207,1,207,1,207,1,207,1,207,3,207,2605,
        8,207,1,207,1,207,1,207,1,207,1,207,1,207,3,207,2613,8,207,1,208,1,208,
        3,208,2617,8,208,1,208,1,208,1,209,1,209,1,209,3,209,2624,8,209,1,209,
        1,209,1,209,1,209,1,209,3,209,2631,8,209,1,209,1,209,1,209,1,209,1,209,
        3,209,2638,8,209,1,209,1,209,1,209,1,209,1,209,1,209,3,209,2646,8,209,
        1,209,1,209,1,209,1,209,1,209,3,209,2653,8,209,1,209,1,209,1,209,1,209,
        1,209,1,209,3,209,2661,8,209,1,210,1,210,1,210,1,210,3,210,2667,8,210,
        1,210,1,210,1,210,1,210,3,210,2673,8,210,1,210,1,210,1,210,1,210,1,210,
        1,210,1,210,1,210,1,210,1,210,3,210,2685,8,210,1,211,4,211,2688,8,211,
        11,211,12,211,2689,1,212,5,212,2693,8,212,10,212,12,212,2696,9,212,1,212,
        1,212,1,212,1,212,1,213,1,213,1,214,1,214,3,214,2706,8,214,1,215,1,215,
        1,215,1,215,1,216,1,216,1,216,3,216,2715,8,216,1,216,1,216,1,216,1,216,
        1,216,3,216,2722,8,216,1,217,1,217,1,217,5,217,2727,8,217,10,217,12,217,
        2730,9,217,1,218,1,218,3,218,2734,8,218,1,219,1,219,3,219,2738,8,219,1,
        220,1,220,1,220,1,220,1,221,1,221,1,221,3,221,2747,8,221,1,222,1,222,1,
        223,1,223,1,223,1,223,1,223,1,223,1,223,3,223,2758,8,223,3,223,2760,8,
        223,1,224,1,224,1,224,1,224,1,224,1,224,5,224,2768,8,224,10,224,12,224,
        2771,9,224,1,225,1,225,1,225,1,225,1,225,1,225,5,225,2779,8,225,10,225,
        12,225,2782,9,225,1,226,1,226,1,226,1,226,1,226,1,226,5,226,2790,8,226,
        10,226,12,226,2793,9,226,1,227,1,227,1,227,1,227,1,227,1,227,5,227,2801,
        8,227,10,227,12,227,2804,9,227,1,228,1,228,1,228,1,228,1,228,1,228,5,228,
        2812,8,228,10,228,12,228,2815,9,228,1,229,1,229,1,229,1,229,1,229,1,229,
        1,229,1,229,1,229,5,229,2826,8,229,10,229,12,229,2829,9,229,1,230,1,230,
        1,230,1,230,1,230,1,230,1,230,1,230,1,230,1,230,1,230,1,230,1,230,1,230,
        1,230,1,230,1,230,1,230,5,230,2849,8,230,10,230,12,230,2852,9,230,1,231,
        1,231,1,231,1,231,1,231,1,231,1,231,1,231,1,231,1,231,1,231,1,231,1,231,
        1,231,1,231,1,231,5,231,2870,8,231,10,231,12,231,2873,9,231,1,232,1,232,
        1,232,1,232,1,232,1,232,1,232,1,232,1,232,5,232,2884,8,232,10,232,12,232,
        2887,9,232,1,233,1,233,1,233,1,233,1,233,1,233,1,233,1,233,1,233,1,233,
        1,233,1,233,5,233,2901,8,233,10,233,12,233,2904,9,233,1,234,1,234,1,234,
        1,234,1,234,1,234,1,234,3,234,2913,8,234,1,235,1,235,1,235,1,236,1,236,
        1,236,1,237,1,237,1,237,1,237,1,237,1,237,3,237,2927,8,237,1,238,1,238,
        3,238,2931,8,238,1,238,1,238,5,238,2935,8,238,10,238,12,238,2938,9,238,
        1,239,1,239,1,239,1,240,1,240,1,241,1,241,1,241,1,242,1,242,1,243,1,243,
        1,243,1,243,1,243,1,243,1,243,1,243,5,243,2958,8,243,10,243,12,243,2961,
        9,243,1,243,1,243,1,243,1,243,1,243,1,243,5,243,2969,8,243,10,243,12,243,
        2972,9,243,1,243,1,243,1,243,3,243,2977,8,243,1,244,1,244,1,244,0,14,50,
        52,56,62,448,450,452,454,456,458,460,462,464,466,245,0,2,4,6,8,10,12,14,
        16,18,20,22,24,26,28,30,32,34,36,38,40,42,44,46,48,50,52,54,56,58,60,62,
        64,66,68,70,72,74,76,78,80,82,84,86,88,90,92,94,96,98,100,102,104,106,
        108,110,112,114,116,118,120,122,124,126,128,130,132,134,136,138,140,142,
        144,146,148,150,152,154,156,158,160,162,164,166,168,170,172,174,176,178,
        180,182,184,186,188,190,192,194,196,198,200,202,204,206,208,210,212,214,
        216,218,220,222,224,226,228,230,232,234,236,238,240,242,244,246,248,250,
        252,254,256,258,260,262,264,266,268,270,272,274,276,278,280,282,284,286,
        288,290,292,294,296,298,300,302,304,306,308,310,312,314,316,318,320,322,
        324,326,328,330,332,334,336,338,340,342,344,346,348,350,352,354,356,358,
        360,362,364,366,368,370,372,374,376,378,380,382,384,386,388,390,392,394,
        396,398,400,402,404,406,408,410,412,414,416,418,420,422,424,426,428,430,
        432,434,436,438,440,442,444,446,448,450,452,454,456,458,460,462,464,466,
        468,470,472,474,476,478,480,482,484,486,488,0,6,1,0,62,67,5,0,15,15,18,
        18,37,37,39,39,47,47,2,0,24,24,30,30,2,0,10,10,48,48,2,0,80,80,104,114,
        2,0,1,9,115,115,3235,0,490,1,0,0,0,2,506,1,0,0,0,4,510,1,0,0,0,6,512,1,
        0,0,0,8,514,1,0,0,0,10,519,1,0,0,0,12,523,1,0,0,0,14,554,1,0,0,0,16,556,
        1,0,0,0,18,570,1,0,0,0,20,577,1,0,0,0,22,579,1,0,0,0,24,581,1,0,0,0,26,
        586,1,0,0,0,28,600,1,0,0,0,30,605,1,0,0,0,32,626,1,0,0,0,34,633,1,0,0,
        0,36,645,1,0,0,0,38,647,1,0,0,0,40,650,1,0,0,0,42,654,1,0,0,0,44,664,1,
        0,0,0,46,669,1,0,0,0,48,680,1,0,0,0,50,682,1,0,0,0,52,693,1,0,0,0,54,709,
        1,0,0,0,56,711,1,0,0,0,58,727,1,0,0,0,60,729,1,0,0,0,62,731,1,0,0,0,64,
        744,1,0,0,0,66,747,1,0,0,0,68,766,1,0,0,0,70,774,1,0,0,0,72,781,1,0,0,
        0,74,787,1,0,0,0,76,789,1,0,0,0,78,793,1,0,0,0,80,799,1,0,0,0,82,806,1,
        0,0,0,84,816,1,0,0,0,86,821,1,0,0,0,88,895,1,0,0,0,90,897,1,0,0,0,92,901,
        1,0,0,0,94,906,1,0,0,0,96,930,1,0,0,0,98,932,1,0,0,0,100,936,1,0,0,0,102,
        944,1,0,0,0,104,947,1,0,0,0,106,950,1,0,0,0,108,958,1,0,0,0,110,971,1,
        0,0,0,112,978,1,0,0,0,114,983,1,0,0,0,116,998,1,0,0,0,118,1000,1,0,0,0,
        120,1008,1,0,0,0,122,1013,1,0,0,0,124,1019,1,0,0,0,126,1023,1,0,0,0,128,
        1027,1,0,0,0,130,1032,1,0,0,0,132,1036,1,0,0,0,134,1061,1,0,0,0,136,1063,
        1,0,0,0,138,1074,1,0,0,0,140,1078,1,0,0,0,142,1080,1,0,0,0,144,1082,1,
        0,0,0,146,1084,1,0,0,0,148,1095,1,0,0,0,150,1100,1,0,0,0,152,1116,1,0,
        0,0,154,1135,1,0,0,0,156,1139,1,0,0,0,158,1141,1,0,0,0,160,1156,1,0,0,
        0,162,1174,1,0,0,0,164,1179,1,0,0,0,166,1187,1,0,0,0,168,1206,1,0,0,0,
        170,1211,1,0,0,0,172,1222,1,0,0,0,174,1225,1,0,0,0,176,1235,1,0,0,0,178,
        1239,1,0,0,0,180,1241,1,0,0,0,182,1243,1,0,0,0,184,1249,1,0,0,0,186,1262,
        1,0,0,0,188,1265,1,0,0,0,190,1274,1,0,0,0,192,1276,1,0,0,0,194,1331,1,
        0,0,0,196,1336,1,0,0,0,198,1346,1,0,0,0,200,1358,1,0,0,0,202,1369,1,0,
        0,0,204,1383,1,0,0,0,206,1385,1,0,0,0,208,1394,1,0,0,0,210,1399,1,0,0,
        0,212,1419,1,0,0,0,214,1421,1,0,0,0,216,1424,1,0,0,0,218,1438,1,0,0,0,
        220,1443,1,0,0,0,222,1454,1,0,0,0,224,1459,1,0,0,0,226,1472,1,0,0,0,228,
        1477,1,0,0,0,230,1485,1,0,0,0,232,1499,1,0,0,0,234,1504,1,0,0,0,236,1522,
        1,0,0,0,238,1524,1,0,0,0,240,1530,1,0,0,0,242,1532,1,0,0,0,244,1540,1,
        0,0,0,246,1548,1,0,0,0,248,1555,1,0,0,0,250,1557,1,0,0,0,252,1566,1,0,
        0,0,254,1574,1,0,0,0,256,1577,1,0,0,0,258,1583,1,0,0,0,260,1592,1,0,0,
        0,262,1600,1,0,0,0,264,1607,1,0,0,0,266,1614,1,0,0,0,268,1616,1,0,0,0,
        270,1622,1,0,0,0,272,1634,1,0,0,0,274,1641,1,0,0,0,276,1655,1,0,0,0,278,
        1657,1,0,0,0,280,1659,1,0,0,0,282,1663,1,0,0,0,284,1667,1,0,0,0,286,1677,
        1,0,0,0,288,1679,1,0,0,0,290,1685,1,0,0,0,292,1693,1,0,0,0,294,1711,1,
        0,0,0,296,1713,1,0,0,0,298,1719,1,0,0,0,300,1734,1,0,0,0,302,1738,1,0,
        0,0,304,1752,1,0,0,0,306,1754,1,0,0,0,308,1756,1,0,0,0,310,1762,1,0,0,
        0,312,1768,1,0,0,0,314,1778,1,0,0,0,316,1782,1,0,0,0,318,1784,1,0,0,0,
        320,1800,1,0,0,0,322,1818,1,0,0,0,324,1820,1,0,0,0,326,1822,1,0,0,0,328,
        1830,1,0,0,0,330,1845,1,0,0,0,332,1860,1,0,0,0,334,1866,1,0,0,0,336,1872,
        1,0,0,0,338,1878,1,0,0,0,340,1882,1,0,0,0,342,1900,1,0,0,0,344,1903,1,
        0,0,0,346,1907,1,0,0,0,348,1916,1,0,0,0,350,1922,1,0,0,0,352,1930,1,0,
        0,0,354,1933,1,0,0,0,356,1942,1,0,0,0,358,1949,1,0,0,0,360,1969,1,0,0,
        0,362,1973,1,0,0,0,364,1977,1,0,0,0,366,2001,1,0,0,0,368,2003,1,0,0,0,
        370,2033,1,0,0,0,372,2040,1,0,0,0,374,2042,1,0,0,0,376,2048,1,0,0,0,378,
        2090,1,0,0,0,380,2092,1,0,0,0,382,2133,1,0,0,0,384,2152,1,0,0,0,386,2237,
        1,0,0,0,388,2239,1,0,0,0,390,2321,1,0,0,0,392,2326,1,0,0,0,394,2341,1,
        0,0,0,396,2343,1,0,0,0,398,2355,1,0,0,0,400,2367,1,0,0,0,402,2379,1,0,
        0,0,404,2404,1,0,0,0,406,2485,1,0,0,0,408,2487,1,0,0,0,410,2555,1,0,0,
        0,412,2557,1,0,0,0,414,2612,1,0,0,0,416,2614,1,0,0,0,418,2660,1,0,0,0,
        420,2684,1,0,0,0,422,2687,1,0,0,0,424,2694,1,0,0,0,426,2701,1,0,0,0,428,
        2705,1,0,0,0,430,2707,1,0,0,0,432,2721,1,0,0,0,434,2723,1,0,0,0,436,2733,
        1,0,0,0,438,2737,1,0,0,0,440,2739,1,0,0,0,442,2746,1,0,0,0,444,2748,1,
        0,0,0,446,2759,1,0,0,0,448,2761,1,0,0,0,450,2772,1,0,0,0,452,2783,1,0,
        0,0,454,2794,1,0,0,0,456,2805,1,0,0,0,458,2816,1,0,0,0,460,2830,1,0,0,
        0,462,2853,1,0,0,0,464,2874,1,0,0,0,466,2888,1,0,0,0,468,2912,1,0,0,0,
        470,2914,1,0,0,0,472,2917,1,0,0,0,474,2926,1,0,0,0,476,2930,1,0,0,0,478,
        2939,1,0,0,0,480,2942,1,0,0,0,482,2944,1,0,0,0,484,2947,1,0,0,0,486,2976,
        1,0,0,0,488,2978,1,0,0,0,490,491,7,0,0,0,491,1,1,0,0,0,492,494,3,240,120,
        0,493,492,1,0,0,0,494,497,1,0,0,0,495,493,1,0,0,0,495,496,1,0,0,0,496,
        498,1,0,0,0,497,495,1,0,0,0,498,507,3,4,2,0,499,501,3,240,120,0,500,499,
        1,0,0,0,501,504,1,0,0,0,502,500,1,0,0,0,502,503,1,0,0,0,503,505,1,0,0,
        0,504,502,1,0,0,0,505,507,5,13,0,0,506,495,1,0,0,0,506,502,1,0,0,0,507,
        3,1,0,0,0,508,511,3,6,3,0,509,511,3,8,4,0,510,508,1,0,0,0,510,509,1,0,
        0,0,511,5,1,0,0,0,512,513,7,1,0,0,513,7,1,0,0,0,514,515,7,2,0,0,515,9,
        1,0,0,0,516,520,3,12,6,0,517,520,3,26,13,0,518,520,3,28,14,0,519,516,1,
        0,0,0,519,517,1,0,0,0,519,518,1,0,0,0,520,11,1,0,0,0,521,524,3,18,9,0,
        522,524,3,24,12,0,523,521,1,0,0,0,523,522,1,0,0,0,524,529,1,0,0,0,525,
        528,3,16,8,0,526,528,3,22,11,0,527,525,1,0,0,0,527,526,1,0,0,0,528,531,
        1,0,0,0,529,527,1,0,0,0,529,530,1,0,0,0,530,13,1,0,0,0,531,529,1,0,0,0,
        532,534,3,240,120,0,533,532,1,0,0,0,534,537,1,0,0,0,535,533,1,0,0,0,535,
        536,1,0,0,0,536,538,1,0,0,0,537,535,1,0,0,0,538,540,3,488,244,0,539,541,
        3,40,20,0,540,539,1,0,0,0,540,541,1,0,0,0,541,555,1,0,0,0,542,543,3,12,
        6,0,543,547,5,76,0,0,544,546,3,240,120,0,545,544,1,0,0,0,546,549,1,0,0,
        0,547,545,1,0,0,0,547,548,1,0,0,0,548,550,1,0,0,0,549,547,1,0,0,0,550,
        552,3,488,244,0,551,553,3,40,20,0,552,551,1,0,0,0,552,553,1,0,0,0,553,
        555,1,0,0,0,554,535,1,0,0,0,554,542,1,0,0,0,555,15,1,0,0,0,556,560,5,76,
        0,0,557,559,3,240,120,0,558,557,1,0,0,0,559,562,1,0,0,0,560,558,1,0,0,
        0,560,561,1,0,0,0,561,563,1,0,0,0,562,560,1,0,0,0,563,565,3,488,244,0,
        564,566,3,40,20,0,565,564,1,0,0,0,565,566,1,0,0,0,566,17,1,0,0,0,567,569,
        3,240,120,0,568,567,1,0,0,0,569,572,1,0,0,0,570,568,1,0,0,0,570,571,1,
        0,0,0,571,573,1,0,0,0,572,570,1,0,0,0,573,575,3,488,244,0,574,576,3,40,
        20,0,575,574,1,0,0,0,575,576,1,0,0,0,576,19,1,0,0,0,577,578,3,14,7,0,578,
        21,1,0,0,0,579,580,3,16,8,0,580,23,1,0,0,0,581,582,3,18,9,0,582,25,1,0,
        0,0,583,585,3,240,120,0,584,583,1,0,0,0,585,588,1,0,0,0,586,584,1,0,0,
        0,586,587,1,0,0,0,587,589,1,0,0,0,588,586,1,0,0,0,589,590,3,488,244,0,
        590,27,1,0,0,0,591,592,3,2,1,0,592,593,3,30,15,0,593,601,1,0,0,0,594,595,
        3,12,6,0,595,596,3,30,15,0,596,601,1,0,0,0,597,598,3,26,13,0,598,599,3,
        30,15,0,599,601,1,0,0,0,600,591,1,0,0,0,600,594,1,0,0,0,600,597,1,0,0,
        0,601,29,1,0,0,0,602,604,3,240,120,0,603,602,1,0,0,0,604,607,1,0,0,0,605,
        603,1,0,0,0,605,606,1,0,0,0,606,608,1,0,0,0,607,605,1,0,0,0,608,609,5,
        72,0,0,609,620,5,73,0,0,610,612,3,240,120,0,611,610,1,0,0,0,612,615,1,
        0,0,0,613,611,1,0,0,0,613,614,1,0,0,0,614,616,1,0,0,0,615,613,1,0,0,0,
        616,617,5,72,0,0,617,619,5,73,0,0,618,613,1,0,0,0,619,622,1,0,0,0,620,
        618,1,0,0,0,620,621,1,0,0,0,621,31,1,0,0,0,622,620,1,0,0,0,623,625,3,34,
        17,0,624,623,1,0,0,0,625,628,1,0,0,0,626,624,1,0,0,0,626,627,1,0,0,0,627,
        629,1,0,0,0,628,626,1,0,0,0,629,631,3,488,244,0,630,632,3,36,18,0,631,
        630,1,0,0,0,631,632,1,0,0,0,632,33,1,0,0,0,633,634,3,240,120,0,634,35,
        1,0,0,0,635,636,5,27,0,0,636,646,3,26,13,0,637,638,5,27,0,0,638,642,3,
        12,6,0,639,641,3,38,19,0,640,639,1,0,0,0,641,644,1,0,0,0,642,640,1,0,0,
        0,642,643,1,0,0,0,643,646,1,0,0,0,644,642,1,0,0,0,645,635,1,0,0,0,645,
        637,1,0,0,0,646,37,1,0,0,0,647,648,5,100,0,0,648,649,3,20,10,0,649,39,
        1,0,0,0,650,651,5,82,0,0,651,652,3,42,21,0,652,653,5,81,0,0,653,41,1,0,
        0,0,654,659,3,44,22,0,655,656,5,75,0,0,656,658,3,44,22,0,657,655,1,0,0,
        0,658,661,1,0,0,0,659,657,1,0,0,0,659,660,1,0,0,0,660,43,1,0,0,0,661,659,
        1,0,0,0,662,665,3,10,5,0,663,665,3,46,23,0,664,662,1,0,0,0,664,663,1,0,
        0,0,665,45,1,0,0,0,666,668,3,240,120,0,667,666,1,0,0,0,668,671,1,0,0,0,
        669,667,1,0,0,0,669,670,1,0,0,0,670,672,1,0,0,0,671,669,1,0,0,0,672,674,
        5,85,0,0,673,675,3,48,24,0,674,673,1,0,0,0,674,675,1,0,0,0,675,47,1,0,
        0,0,676,677,5,27,0,0,677,681,3,10,5,0,678,679,5,50,0,0,679,681,3,10,5,
        0,680,676,1,0,0,0,680,678,1,0,0,0,681,49,1,0,0,0,682,683,6,25,-1,0,683,
        684,3,488,244,0,684,690,1,0,0,0,685,686,10,1,0,0,686,687,5,76,0,0,687,
        689,3,488,244,0,688,685,1,0,0,0,689,692,1,0,0,0,690,688,1,0,0,0,690,691,
        1,0,0,0,691,51,1,0,0,0,692,690,1,0,0,0,693,694,6,26,-1,0,694,695,3,488,
        244,0,695,701,1,0,0,0,696,697,10,1,0,0,697,698,5,76,0,0,698,700,3,488,
        244,0,699,696,1,0,0,0,700,703,1,0,0,0,701,699,1,0,0,0,701,702,1,0,0,0,
        702,53,1,0,0,0,703,701,1,0,0,0,704,710,3,488,244,0,705,706,3,56,28,0,706,
        707,5,76,0,0,707,708,3,488,244,0,708,710,1,0,0,0,709,704,1,0,0,0,709,705,
        1,0,0,0,710,55,1,0,0,0,711,712,6,28,-1,0,712,713,3,488,244,0,713,719,1,
        0,0,0,714,715,10,1,0,0,715,716,5,76,0,0,716,718,3,488,244,0,717,714,1,
        0,0,0,718,721,1,0,0,0,719,717,1,0,0,0,719,720,1,0,0,0,720,57,1,0,0,0,721,
        719,1,0,0,0,722,728,3,488,244,0,723,724,3,62,31,0,724,725,5,76,0,0,725,
        726,3,488,244,0,726,728,1,0,0,0,727,722,1,0,0,0,727,723,1,0,0,0,728,59,
        1,0,0,0,729,730,3,488,244,0,730,61,1,0,0,0,731,732,6,31,-1,0,732,733,3,
        488,244,0,733,739,1,0,0,0,734,735,10,1,0,0,735,736,5,76,0,0,736,738,3,
        488,244,0,737,734,1,0,0,0,738,741,1,0,0,0,739,737,1,0,0,0,739,740,1,0,
        0,0,740,63,1,0,0,0,741,739,1,0,0,0,742,745,3,66,33,0,743,745,3,68,34,0,
        744,742,1,0,0,0,744,743,1,0,0,0,745,65,1,0,0,0,746,748,3,70,35,0,747,746,
        1,0,0,0,747,748,1,0,0,0,748,752,1,0,0,0,749,751,3,74,37,0,750,749,1,0,
        0,0,751,754,1,0,0,0,752,750,1,0,0,0,752,753,1,0,0,0,753,758,1,0,0,0,754,
        752,1,0,0,0,755,757,3,84,42,0,756,755,1,0,0,0,757,760,1,0,0,0,758,756,
        1,0,0,0,758,759,1,0,0,0,759,761,1,0,0,0,760,758,1,0,0,0,761,762,5,0,0,
        1,762,67,1,0,0,0,763,765,3,74,37,0,764,763,1,0,0,0,765,768,1,0,0,0,766,
        764,1,0,0,0,766,767,1,0,0,0,767,769,1,0,0,0,768,766,1,0,0,0,769,770,3,
        86,43,0,770,69,1,0,0,0,771,773,3,72,36,0,772,771,1,0,0,0,773,776,1,0,0,
        0,774,772,1,0,0,0,774,775,1,0,0,0,775,777,1,0,0,0,776,774,1,0,0,0,777,
        778,5,42,0,0,778,779,3,52,26,0,779,780,5,74,0,0,780,71,1,0,0,0,781,782,
        3,240,120,0,782,73,1,0,0,0,783,788,3,76,38,0,784,788,3,78,39,0,785,788,
        3,80,40,0,786,788,3,82,41,0,787,783,1,0,0,0,787,784,1,0,0,0,787,785,1,
        0,0,0,787,786,1,0,0,0,788,75,1,0,0,0,789,790,5,35,0,0,790,791,3,54,27,
        0,791,792,5,74,0,0,792,77,1,0,0,0,793,794,5,35,0,0,794,795,3,56,28,0,795,
        796,5,76,0,0,796,797,5,98,0,0,797,798,5,74,0,0,798,79,1,0,0,0,799,800,
        5,35,0,0,800,801,5,48,0,0,801,802,3,54,27,0,802,803,5,76,0,0,803,804,3,
        488,244,0,804,805,5,74,0,0,805,81,1,0,0,0,806,807,5,35,0,0,807,808,5,48,
        0,0,808,809,3,54,27,0,809,810,5,76,0,0,810,811,5,98,0,0,811,812,5,74,0,
        0,812,83,1,0,0,0,813,817,3,92,46,0,814,817,3,208,104,0,815,817,5,74,0,
        0,816,813,1,0,0,0,816,814,1,0,0,0,816,815,1,0,0,0,817,85,1,0,0,0,818,820,
        3,240,120,0,819,818,1,0,0,0,820,823,1,0,0,0,821,819,1,0,0,0,821,822,1,
        0,0,0,822,825,1,0,0,0,823,821,1,0,0,0,824,826,5,1,0,0,825,824,1,0,0,0,
        825,826,1,0,0,0,826,827,1,0,0,0,827,828,5,2,0,0,828,829,3,50,25,0,829,
        833,5,70,0,0,830,832,3,88,44,0,831,830,1,0,0,0,832,835,1,0,0,0,833,831,
        1,0,0,0,833,834,1,0,0,0,834,836,1,0,0,0,835,833,1,0,0,0,836,837,5,71,0,
        0,837,87,1,0,0,0,838,842,5,3,0,0,839,841,3,90,45,0,840,839,1,0,0,0,841,
        844,1,0,0,0,842,840,1,0,0,0,842,843,1,0,0,0,843,845,1,0,0,0,844,842,1,
        0,0,0,845,846,3,50,25,0,846,847,5,74,0,0,847,896,1,0,0,0,848,849,5,4,0,
        0,849,859,3,52,26,0,850,851,5,5,0,0,851,856,3,50,25,0,852,853,5,75,0,0,
        853,855,3,50,25,0,854,852,1,0,0,0,855,858,1,0,0,0,856,854,1,0,0,0,856,
        857,1,0,0,0,857,860,1,0,0,0,858,856,1,0,0,0,859,850,1,0,0,0,859,860,1,
        0,0,0,860,861,1,0,0,0,861,862,5,74,0,0,862,896,1,0,0,0,863,864,5,6,0,0,
        864,874,3,52,26,0,865,866,5,5,0,0,866,871,3,50,25,0,867,868,5,75,0,0,868,
        870,3,50,25,0,869,867,1,0,0,0,870,873,1,0,0,0,871,869,1,0,0,0,871,872,
        1,0,0,0,872,875,1,0,0,0,873,871,1,0,0,0,874,865,1,0,0,0,874,875,1,0,0,
        0,875,876,1,0,0,0,876,877,5,74,0,0,877,896,1,0,0,0,878,879,5,7,0,0,879,
        880,3,54,27,0,880,881,5,74,0,0,881,896,1,0,0,0,882,883,5,8,0,0,883,884,
        3,54,27,0,884,885,5,9,0,0,885,890,3,54,27,0,886,887,5,75,0,0,887,889,3,
        54,27,0,888,886,1,0,0,0,889,892,1,0,0,0,890,888,1,0,0,0,890,891,1,0,0,
        0,891,893,1,0,0,0,892,890,1,0,0,0,893,894,5,74,0,0,894,896,1,0,0,0,895,
        838,1,0,0,0,895,848,1,0,0,0,895,863,1,0,0,0,895,878,1,0,0,0,895,882,1,
        0,0,0,896,89,1,0,0,0,897,898,7,3,0,0,898,91,1,0,0,0,899,902,3,94,47,0,
        900,902,3,196,98,0,901,899,1,0,0,0,901,900,1,0,0,0,902,93,1,0,0,0,903,
        905,3,96,48,0,904,903,1,0,0,0,905,908,1,0,0,0,906,904,1,0,0,0,906,907,
        1,0,0,0,907,909,1,0,0,0,908,906,1,0,0,0,909,910,5,19,0,0,910,912,3,488,
        244,0,911,913,3,98,49,0,912,911,1,0,0,0,912,913,1,0,0,0,913,915,1,0,0,
        0,914,916,3,102,51,0,915,914,1,0,0,0,915,916,1,0,0,0,916,918,1,0,0,0,917,
        919,3,104,52,0,918,917,1,0,0,0,918,919,1,0,0,0,919,920,1,0,0,0,920,921,
        3,108,54,0,921,95,1,0,0,0,922,931,3,240,120,0,923,931,5,45,0,0,924,931,
        5,44,0,0,925,931,5,43,0,0,926,931,5,11,0,0,927,931,5,48,0,0,928,931,5,
        28,0,0,929,931,5,49,0,0,930,922,1,0,0,0,930,923,1,0,0,0,930,924,1,0,0,
        0,930,925,1,0,0,0,930,926,1,0,0,0,930,927,1,0,0,0,930,928,1,0,0,0,930,
        929,1,0,0,0,931,97,1,0,0,0,932,933,5,82,0,0,933,934,3,100,50,0,934,935,
        5,81,0,0,935,99,1,0,0,0,936,941,3,32,16,0,937,938,5,75,0,0,938,940,3,32,
        16,0,939,937,1,0,0,0,940,943,1,0,0,0,941,939,1,0,0,0,941,942,1,0,0,0,942,
        101,1,0,0,0,943,941,1,0,0,0,944,945,5,27,0,0,945,946,3,14,7,0,946,103,
        1,0,0,0,947,948,5,34,0,0,948,949,3,106,53,0,949,105,1,0,0,0,950,955,3,
        20,10,0,951,952,5,75,0,0,952,954,3,20,10,0,953,951,1,0,0,0,954,957,1,0,
        0,0,955,953,1,0,0,0,955,956,1,0,0,0,956,107,1,0,0,0,957,955,1,0,0,0,958,
        962,5,70,0,0,959,961,3,110,55,0,960,959,1,0,0,0,961,964,1,0,0,0,962,960,
        1,0,0,0,962,963,1,0,0,0,963,965,1,0,0,0,964,962,1,0,0,0,965,966,5,71,0,
        0,966,109,1,0,0,0,967,972,3,112,56,0,968,972,3,180,90,0,969,972,3,182,
        91,0,970,972,3,184,92,0,971,967,1,0,0,0,971,968,1,0,0,0,971,969,1,0,0,
        0,971,970,1,0,0,0,972,111,1,0,0,0,973,979,3,114,57,0,974,979,3,150,75,
        0,975,979,3,92,46,0,976,979,3,208,104,0,977,979,5,74,0,0,978,973,1,0,0,
        0,978,974,1,0,0,0,978,975,1,0,0,0,978,976,1,0,0,0,978,977,1,0,0,0,979,
        113,1,0,0,0,980,982,3,116,58,0,981,980,1,0,0,0,982,985,1,0,0,0,983,981,
        1,0,0,0,983,984,1,0,0,0,984,986,1,0,0,0,985,983,1,0,0,0,986,987,3,126,
        63,0,987,988,3,118,59,0,988,989,5,74,0,0,989,115,1,0,0,0,990,999,3,240,
        120,0,991,999,5,45,0,0,992,999,5,44,0,0,993,999,5,43,0,0,994,999,5,48,
        0,0,995,999,5,28,0,0,996,999,5,56,0,0,997,999,5,59,0,0,998,990,1,0,0,0,
        998,991,1,0,0,0,998,992,1,0,0,0,998,993,1,0,0,0,998,994,1,0,0,0,998,995,
        1,0,0,0,998,996,1,0,0,0,998,997,1,0,0,0,999,117,1,0,0,0,1000,1005,3,120,
        60,0,1001,1002,5,75,0,0,1002,1004,3,120,60,0,1003,1001,1,0,0,0,1004,1007,
        1,0,0,0,1005,1003,1,0,0,0,1005,1006,1,0,0,0,1006,119,1,0,0,0,1007,1005,
        1,0,0,0,1008,1011,3,122,61,0,1009,1010,5,80,0,0,1010,1012,3,124,62,0,1011,
        1009,1,0,0,0,1011,1012,1,0,0,0,1012,121,1,0,0,0,1013,1015,3,488,244,0,
        1014,1016,3,30,15,0,1015,1014,1,0,0,0,1015,1016,1,0,0,0,1016,123,1,0,0,
        0,1017,1020,3,428,214,0,1018,1020,3,258,129,0,1019,1017,1,0,0,0,1019,1018,
        1,0,0,0,1020,125,1,0,0,0,1021,1024,3,128,64,0,1022,1024,3,130,65,0,1023,
        1021,1,0,0,0,1023,1022,1,0,0,0,1024,127,1,0,0,0,1025,1028,3,4,2,0,1026,
        1028,5,13,0,0,1027,1025,1,0,0,0,1027,1026,1,0,0,0,1028,129,1,0,0,0,1029,
        1033,3,132,66,0,1030,1033,3,146,73,0,1031,1033,3,148,74,0,1032,1029,1,
        0,0,0,1032,1030,1,0,0,0,1032,1031,1,0,0,0,1033,131,1,0,0,0,1034,1037,3,
        138,69,0,1035,1037,3,144,72,0,1036,1034,1,0,0,0,1036,1035,1,0,0,0,1037,
        1042,1,0,0,0,1038,1041,3,136,68,0,1039,1041,3,142,71,0,1040,1038,1,0,0,
        0,1040,1039,1,0,0,0,1041,1044,1,0,0,0,1042,1040,1,0,0,0,1042,1043,1,0,
        0,0,1043,133,1,0,0,0,1044,1042,1,0,0,0,1045,1047,3,488,244,0,1046,1048,
        3,40,20,0,1047,1046,1,0,0,0,1047,1048,1,0,0,0,1048,1062,1,0,0,0,1049,1050,
        3,132,66,0,1050,1054,5,76,0,0,1051,1053,3,240,120,0,1052,1051,1,0,0,0,
        1053,1056,1,0,0,0,1054,1052,1,0,0,0,1054,1055,1,0,0,0,1055,1057,1,0,0,
        0,1056,1054,1,0,0,0,1057,1059,3,488,244,0,1058,1060,3,40,20,0,1059,1058,
        1,0,0,0,1059,1060,1,0,0,0,1060,1062,1,0,0,0,1061,1045,1,0,0,0,1061,1049,
        1,0,0,0,1062,135,1,0,0,0,1063,1067,5,76,0,0,1064,1066,3,240,120,0,1065,
        1064,1,0,0,0,1066,1069,1,0,0,0,1067,1065,1,0,0,0,1067,1068,1,0,0,0,1068,
        1070,1,0,0,0,1069,1067,1,0,0,0,1070,1072,3,488,244,0,1071,1073,3,40,20,
        0,1072,1071,1,0,0,0,1072,1073,1,0,0,0,1073,137,1,0,0,0,1074,1076,3,488,
        244,0,1075,1077,3,40,20,0,1076,1075,1,0,0,0,1076,1077,1,0,0,0,1077,139,
        1,0,0,0,1078,1079,3,134,67,0,1079,141,1,0,0,0,1080,1081,3,136,68,0,1081,
        143,1,0,0,0,1082,1083,3,138,69,0,1083,145,1,0,0,0,1084,1085,3,488,244,
        0,1085,147,1,0,0,0,1086,1087,3,128,64,0,1087,1088,3,30,15,0,1088,1096,
        1,0,0,0,1089,1090,3,132,66,0,1090,1091,3,30,15,0,1091,1096,1,0,0,0,1092,
        1093,3,146,73,0,1093,1094,3,30,15,0,1094,1096,1,0,0,0,1095,1086,1,0,0,
        0,1095,1089,1,0,0,0,1095,1092,1,0,0,0,1096,149,1,0,0,0,1097,1099,3,152,
        76,0,1098,1097,1,0,0,0,1099,1102,1,0,0,0,1100,1098,1,0,0,0,1100,1101,1,
        0,0,0,1101,1103,1,0,0,0,1102,1100,1,0,0,0,1103,1104,3,154,77,0,1104,1105,
        3,178,89,0,1105,151,1,0,0,0,1106,1117,3,240,120,0,1107,1117,5,45,0,0,1108,
        1117,5,44,0,0,1109,1117,5,43,0,0,1110,1117,5,11,0,0,1111,1117,5,48,0,0,
        1112,1117,5,28,0,0,1113,1117,5,52,0,0,1114,1117,5,40,0,0,1115,1117,5,49,
        0,0,1116,1106,1,0,0,0,1116,1107,1,0,0,0,1116,1108,1,0,0,0,1116,1109,1,
        0,0,0,1116,1110,1,0,0,0,1116,1111,1,0,0,0,1116,1112,1,0,0,0,1116,1113,
        1,0,0,0,1116,1114,1,0,0,0,1116,1115,1,0,0,0,1117,153,1,0,0,0,1118,1119,
        3,156,78,0,1119,1121,3,158,79,0,1120,1122,3,172,86,0,1121,1120,1,0,0,0,
        1121,1122,1,0,0,0,1122,1136,1,0,0,0,1123,1127,3,98,49,0,1124,1126,3,240,
        120,0,1125,1124,1,0,0,0,1126,1129,1,0,0,0,1127,1125,1,0,0,0,1127,1128,
        1,0,0,0,1128,1130,1,0,0,0,1129,1127,1,0,0,0,1130,1131,3,156,78,0,1131,
        1133,3,158,79,0,1132,1134,3,172,86,0,1133,1132,1,0,0,0,1133,1134,1,0,0,
        0,1134,1136,1,0,0,0,1135,1118,1,0,0,0,1135,1123,1,0,0,0,1136,155,1,0,0,
        0,1137,1140,3,126,63,0,1138,1140,5,58,0,0,1139,1137,1,0,0,0,1139,1138,
        1,0,0,0,1140,157,1,0,0,0,1141,1142,3,488,244,0,1142,1144,5,68,0,0,1143,
        1145,3,160,80,0,1144,1143,1,0,0,0,1144,1145,1,0,0,0,1145,1146,1,0,0,0,
        1146,1148,5,69,0,0,1147,1149,3,30,15,0,1148,1147,1,0,0,0,1148,1149,1,0,
        0,0,1149,159,1,0,0,0,1150,1151,3,162,81,0,1151,1152,5,75,0,0,1152,1153,
        3,168,84,0,1153,1157,1,0,0,0,1154,1157,3,168,84,0,1155,1157,3,170,85,0,
        1156,1150,1,0,0,0,1156,1154,1,0,0,0,1156,1155,1,0,0,0,1157,161,1,0,0,0,
        1158,1163,3,164,82,0,1159,1160,5,75,0,0,1160,1162,3,164,82,0,1161,1159,
        1,0,0,0,1162,1165,1,0,0,0,1163,1161,1,0,0,0,1163,1164,1,0,0,0,1164,1175,
        1,0,0,0,1165,1163,1,0,0,0,1166,1171,3,170,85,0,1167,1168,5,75,0,0,1168,
        1170,3,164,82,0,1169,1167,1,0,0,0,1170,1173,1,0,0,0,1171,1169,1,0,0,0,
        1171,1172,1,0,0,0,1172,1175,1,0,0,0,1173,1171,1,0,0,0,1174,1158,1,0,0,
        0,1174,1166,1,0,0,0,1175,163,1,0,0,0,1176,1178,3,166,83,0,1177,1176,1,
        0,0,0,1178,1181,1,0,0,0,1179,1177,1,0,0,0,1179,1180,1,0,0,0,1180,1182,
        1,0,0,0,1181,1179,1,0,0,0,1182,1183,3,126,63,0,1183,1184,3,122,61,0,1184,
        165,1,0,0,0,1185,1188,3,240,120,0,1186,1188,5,28,0,0,1187,1185,1,0,0,0,
        1187,1186,1,0,0,0,1188,167,1,0,0,0,1189,1191,3,166,83,0,1190,1189,1,0,
        0,0,1191,1194,1,0,0,0,1192,1190,1,0,0,0,1192,1193,1,0,0,0,1193,1195,1,
        0,0,0,1194,1192,1,0,0,0,1195,1199,3,126,63,0,1196,1198,3,240,120,0,1197,
        1196,1,0,0,0,1198,1201,1,0,0,0,1199,1197,1,0,0,0,1199,1200,1,0,0,0,1200,
        1202,1,0,0,0,1201,1199,1,0,0,0,1202,1203,5,77,0,0,1203,1204,3,122,61,0,
        1204,1207,1,0,0,0,1205,1207,3,164,82,0,1206,1192,1,0,0,0,1206,1205,1,0,
        0,0,1207,169,1,0,0,0,1208,1210,3,240,120,0,1209,1208,1,0,0,0,1210,1213,
        1,0,0,0,1211,1209,1,0,0,0,1211,1212,1,0,0,0,1212,1214,1,0,0,0,1213,1211,
        1,0,0,0,1214,1218,3,126,63,0,1215,1216,3,488,244,0,1216,1217,5,76,0,0,
        1217,1219,1,0,0,0,1218,1215,1,0,0,0,1218,1219,1,0,0,0,1219,1220,1,0,0,
        0,1220,1221,5,53,0,0,1221,171,1,0,0,0,1222,1223,5,55,0,0,1223,1224,3,174,
        87,0,1224,173,1,0,0,0,1225,1230,3,176,88,0,1226,1227,5,75,0,0,1227,1229,
        3,176,88,0,1228,1226,1,0,0,0,1229,1232,1,0,0,0,1230,1228,1,0,0,0,1230,
        1231,1,0,0,0,1231,175,1,0,0,0,1232,1230,1,0,0,0,1233,1236,3,14,7,0,1234,
        1236,3,26,13,0,1235,1233,1,0,0,0,1235,1234,1,0,0,0,1236,177,1,0,0,0,1237,
        1240,3,262,131,0,1238,1240,5,74,0,0,1239,1237,1,0,0,0,1239,1238,1,0,0,
        0,1240,179,1,0,0,0,1241,1242,3,262,131,0,1242,181,1,0,0,0,1243,1244,5,
        48,0,0,1244,1245,3,262,131,0,1245,183,1,0,0,0,1246,1248,3,186,93,0,1247,
        1246,1,0,0,0,1248,1251,1,0,0,0,1249,1247,1,0,0,0,1249,1250,1,0,0,0,1250,
        1252,1,0,0,0,1251,1249,1,0,0,0,1252,1254,3,188,94,0,1253,1255,3,172,86,
        0,1254,1253,1,0,0,0,1254,1255,1,0,0,0,1255,1256,1,0,0,0,1256,1257,3,192,
        96,0,1257,185,1,0,0,0,1258,1263,3,240,120,0,1259,1263,5,45,0,0,1260,1263,
        5,44,0,0,1261,1263,5,43,0,0,1262,1258,1,0,0,0,1262,1259,1,0,0,0,1262,1260,
        1,0,0,0,1262,1261,1,0,0,0,1263,187,1,0,0,0,1264,1266,3,98,49,0,1265,1264,
        1,0,0,0,1265,1266,1,0,0,0,1266,1267,1,0,0,0,1267,1268,3,190,95,0,1268,
        1270,5,68,0,0,1269,1271,3,160,80,0,1270,1269,1,0,0,0,1270,1271,1,0,0,0,
        1271,1272,1,0,0,0,1272,1273,5,69,0,0,1273,189,1,0,0,0,1274,1275,3,488,
        244,0,1275,191,1,0,0,0,1276,1278,5,70,0,0,1277,1279,3,194,97,0,1278,1277,
        1,0,0,0,1278,1279,1,0,0,0,1279,1281,1,0,0,0,1280,1282,3,264,132,0,1281,
        1280,1,0,0,0,1281,1282,1,0,0,0,1282,1283,1,0,0,0,1283,1284,5,71,0,0,1284,
        193,1,0,0,0,1285,1287,3,40,20,0,1286,1285,1,0,0,0,1286,1287,1,0,0,0,1287,
        1288,1,0,0,0,1288,1289,5,53,0,0,1289,1291,5,68,0,0,1290,1292,3,412,206,
        0,1291,1290,1,0,0,0,1291,1292,1,0,0,0,1292,1293,1,0,0,0,1293,1294,5,69,
        0,0,1294,1332,5,74,0,0,1295,1297,3,40,20,0,1296,1295,1,0,0,0,1296,1297,
        1,0,0,0,1297,1298,1,0,0,0,1298,1299,5,50,0,0,1299,1301,5,68,0,0,1300,1302,
        3,412,206,0,1301,1300,1,0,0,0,1301,1302,1,0,0,0,1302,1303,1,0,0,0,1303,
        1304,5,69,0,0,1304,1332,5,74,0,0,1305,1306,3,58,29,0,1306,1308,5,76,0,
        0,1307,1309,3,40,20,0,1308,1307,1,0,0,0,1308,1309,1,0,0,0,1309,1310,1,
        0,0,0,1310,1311,5,50,0,0,1311,1313,5,68,0,0,1312,1314,3,412,206,0,1313,
        1312,1,0,0,0,1313,1314,1,0,0,0,1314,1315,1,0,0,0,1315,1316,5,69,0,0,1316,
        1317,5,74,0,0,1317,1332,1,0,0,0,1318,1319,3,364,182,0,1319,1321,5,76,0,
        0,1320,1322,3,40,20,0,1321,1320,1,0,0,0,1321,1322,1,0,0,0,1322,1323,1,
        0,0,0,1323,1324,5,50,0,0,1324,1326,5,68,0,0,1325,1327,3,412,206,0,1326,
        1325,1,0,0,0,1326,1327,1,0,0,0,1327,1328,1,0,0,0,1328,1329,5,69,0,0,1329,
        1330,5,74,0,0,1330,1332,1,0,0,0,1331,1286,1,0,0,0,1331,1296,1,0,0,0,1331,
        1305,1,0,0,0,1331,1318,1,0,0,0,1332,195,1,0,0,0,1333,1335,3,96,48,0,1334,
        1333,1,0,0,0,1335,1338,1,0,0,0,1336,1334,1,0,0,0,1336,1337,1,0,0,0,1337,
        1339,1,0,0,0,1338,1336,1,0,0,0,1339,1340,5,26,0,0,1340,1342,3,488,244,
        0,1341,1343,3,104,52,0,1342,1341,1,0,0,0,1342,1343,1,0,0,0,1343,1344,1,
        0,0,0,1344,1345,3,198,99,0,1345,197,1,0,0,0,1346,1348,5,70,0,0,1347,1349,
        3,200,100,0,1348,1347,1,0,0,0,1348,1349,1,0,0,0,1349,1351,1,0,0,0,1350,
        1352,5,75,0,0,1351,1350,1,0,0,0,1351,1352,1,0,0,0,1352,1354,1,0,0,0,1353,
        1355,3,206,103,0,1354,1353,1,0,0,0,1354,1355,1,0,0,0,1355,1356,1,0,0,0,
        1356,1357,5,71,0,0,1357,199,1,0,0,0,1358,1363,3,202,101,0,1359,1360,5,
        75,0,0,1360,1362,3,202,101,0,1361,1359,1,0,0,0,1362,1365,1,0,0,0,1363,
        1361,1,0,0,0,1363,1364,1,0,0,0,1364,201,1,0,0,0,1365,1363,1,0,0,0,1366,
        1368,3,204,102,0,1367,1366,1,0,0,0,1368,1371,1,0,0,0,1369,1367,1,0,0,0,
        1369,1370,1,0,0,0,1370,1372,1,0,0,0,1371,1369,1,0,0,0,1372,1378,3,488,
        244,0,1373,1375,5,68,0,0,1374,1376,3,412,206,0,1375,1374,1,0,0,0,1375,
        1376,1,0,0,0,1376,1377,1,0,0,0,1377,1379,5,69,0,0,1378,1373,1,0,0,0,1378,
        1379,1,0,0,0,1379,1381,1,0,0,0,1380,1382,3,108,54,0,1381,1380,1,0,0,0,
        1381,1382,1,0,0,0,1382,203,1,0,0,0,1383,1384,3,240,120,0,1384,205,1,0,
        0,0,1385,1389,5,74,0,0,1386,1388,3,110,55,0,1387,1386,1,0,0,0,1388,1391,
        1,0,0,0,1389,1387,1,0,0,0,1389,1390,1,0,0,0,1390,207,1,0,0,0,1391,1389,
        1,0,0,0,1392,1395,3,210,105,0,1393,1395,3,228,114,0,1394,1392,1,0,0,0,
        1394,1393,1,0,0,0,1395,209,1,0,0,0,1396,1398,3,212,106,0,1397,1396,1,0,
        0,0,1398,1401,1,0,0,0,1399,1397,1,0,0,0,1399,1400,1,0,0,0,1400,1402,1,
        0,0,0,1401,1399,1,0,0,0,1402,1403,5,38,0,0,1403,1405,3,488,244,0,1404,
        1406,3,98,49,0,1405,1404,1,0,0,0,1405,1406,1,0,0,0,1406,1408,1,0,0,0,1407,
        1409,3,214,107,0,1408,1407,1,0,0,0,1408,1409,1,0,0,0,1409,1410,1,0,0,0,
        1410,1411,3,216,108,0,1411,211,1,0,0,0,1412,1420,3,240,120,0,1413,1420,
        5,45,0,0,1414,1420,5,44,0,0,1415,1420,5,43,0,0,1416,1420,5,11,0,0,1417,
        1420,5,48,0,0,1418,1420,5,49,0,0,1419,1412,1,0,0,0,1419,1413,1,0,0,0,1419,
        1414,1,0,0,0,1419,1415,1,0,0,0,1419,1416,1,0,0,0,1419,1417,1,0,0,0,1419,
        1418,1,0,0,0,1420,213,1,0,0,0,1421,1422,5,27,0,0,1422,1423,3,106,53,0,
        1423,215,1,0,0,0,1424,1428,5,70,0,0,1425,1427,3,218,109,0,1426,1425,1,
        0,0,0,1427,1430,1,0,0,0,1428,1426,1,0,0,0,1428,1429,1,0,0,0,1429,1431,
        1,0,0,0,1430,1428,1,0,0,0,1431,1432,5,71,0,0,1432,217,1,0,0,0,1433,1439,
        3,220,110,0,1434,1439,3,224,112,0,1435,1439,3,92,46,0,1436,1439,3,208,
        104,0,1437,1439,5,74,0,0,1438,1433,1,0,0,0,1438,1434,1,0,0,0,1438,1435,
        1,0,0,0,1438,1436,1,0,0,0,1438,1437,1,0,0,0,1439,219,1,0,0,0,1440,1442,
        3,222,111,0,1441,1440,1,0,0,0,1442,1445,1,0,0,0,1443,1441,1,0,0,0,1443,
        1444,1,0,0,0,1444,1446,1,0,0,0,1445,1443,1,0,0,0,1446,1447,3,126,63,0,
        1447,1448,3,118,59,0,1448,1449,5,74,0,0,1449,221,1,0,0,0,1450,1455,3,240,
        120,0,1451,1455,5,45,0,0,1452,1455,5,48,0,0,1453,1455,5,28,0,0,1454,1450,
        1,0,0,0,1454,1451,1,0,0,0,1454,1452,1,0,0,0,1454,1453,1,0,0,0,1455,223,
        1,0,0,0,1456,1458,3,226,113,0,1457,1456,1,0,0,0,1458,1461,1,0,0,0,1459,
        1457,1,0,0,0,1459,1460,1,0,0,0,1460,1462,1,0,0,0,1461,1459,1,0,0,0,1462,
        1463,3,154,77,0,1463,1464,3,178,89,0,1464,225,1,0,0,0,1465,1473,3,240,
        120,0,1466,1473,5,45,0,0,1467,1473,5,43,0,0,1468,1473,5,11,0,0,1469,1473,
        5,22,0,0,1470,1473,5,48,0,0,1471,1473,5,49,0,0,1472,1465,1,0,0,0,1472,
        1466,1,0,0,0,1472,1467,1,0,0,0,1472,1468,1,0,0,0,1472,1469,1,0,0,0,1472,
        1470,1,0,0,0,1472,1471,1,0,0,0,1473,227,1,0,0,0,1474,1476,3,212,106,0,
        1475,1474,1,0,0,0,1476,1479,1,0,0,0,1477,1475,1,0,0,0,1477,1478,1,0,0,
        0,1478,1480,1,0,0,0,1479,1477,1,0,0,0,1480,1481,5,78,0,0,1481,1482,5,38,
        0,0,1482,1483,3,488,244,0,1483,1484,3,230,115,0,1484,229,1,0,0,0,1485,
        1489,5,70,0,0,1486,1488,3,232,116,0,1487,1486,1,0,0,0,1488,1491,1,0,0,
        0,1489,1487,1,0,0,0,1489,1490,1,0,0,0,1490,1492,1,0,0,0,1491,1489,1,0,
        0,0,1492,1493,5,71,0,0,1493,231,1,0,0,0,1494,1500,3,234,117,0,1495,1500,
        3,220,110,0,1496,1500,3,92,46,0,1497,1500,3,208,104,0,1498,1500,5,74,0,
        0,1499,1494,1,0,0,0,1499,1495,1,0,0,0,1499,1496,1,0,0,0,1499,1497,1,0,
        0,0,1499,1498,1,0,0,0,1500,233,1,0,0,0,1501,1503,3,236,118,0,1502,1501,
        1,0,0,0,1503,1506,1,0,0,0,1504,1502,1,0,0,0,1504,1505,1,0,0,0,1505,1507,
        1,0,0,0,1506,1504,1,0,0,0,1507,1508,3,126,63,0,1508,1509,3,488,244,0,1509,
        1510,5,68,0,0,1510,1512,5,69,0,0,1511,1513,3,30,15,0,1512,1511,1,0,0,0,
        1512,1513,1,0,0,0,1513,1515,1,0,0,0,1514,1516,3,238,119,0,1515,1514,1,
        0,0,0,1515,1516,1,0,0,0,1516,1517,1,0,0,0,1517,1518,5,74,0,0,1518,235,
        1,0,0,0,1519,1523,3,240,120,0,1520,1523,5,45,0,0,1521,1523,5,11,0,0,1522,
        1519,1,0,0,0,1522,1520,1,0,0,0,1522,1521,1,0,0,0,1523,237,1,0,0,0,1524,
        1525,5,22,0,0,1525,1526,3,248,124,0,1526,239,1,0,0,0,1527,1531,3,242,121,
        0,1528,1531,3,254,127,0,1529,1531,3,256,128,0,1530,1527,1,0,0,0,1530,1528,
        1,0,0,0,1530,1529,1,0,0,0,1531,241,1,0,0,0,1532,1533,5,78,0,0,1533,1534,
        3,54,27,0,1534,1536,5,68,0,0,1535,1537,3,244,122,0,1536,1535,1,0,0,0,1536,
        1537,1,0,0,0,1537,1538,1,0,0,0,1538,1539,5,69,0,0,1539,243,1,0,0,0,1540,
        1545,3,246,123,0,1541,1542,5,75,0,0,1542,1544,3,246,123,0,1543,1541,1,
        0,0,0,1544,1547,1,0,0,0,1545,1543,1,0,0,0,1545,1546,1,0,0,0,1546,245,1,
        0,0,0,1547,1545,1,0,0,0,1548,1549,3,488,244,0,1549,1550,5,80,0,0,1550,
        1551,3,248,124,0,1551,247,1,0,0,0,1552,1556,3,446,223,0,1553,1556,3,250,
        125,0,1554,1556,3,240,120,0,1555,1552,1,0,0,0,1555,1553,1,0,0,0,1555,1554,
        1,0,0,0,1556,249,1,0,0,0,1557,1559,5,70,0,0,1558,1560,3,252,126,0,1559,
        1558,1,0,0,0,1559,1560,1,0,0,0,1560,1562,1,0,0,0,1561,1563,5,75,0,0,1562,
        1561,1,0,0,0,1562,1563,1,0,0,0,1563,1564,1,0,0,0,1564,1565,5,71,0,0,1565,
        251,1,0,0,0,1566,1571,3,248,124,0,1567,1568,5,75,0,0,1568,1570,3,248,124,
        0,1569,1567,1,0,0,0,1570,1573,1,0,0,0,1571,1569,1,0,0,0,1571,1572,1,0,
        0,0,1572,253,1,0,0,0,1573,1571,1,0,0,0,1574,1575,5,78,0,0,1575,1576,3,
        54,27,0,1576,255,1,0,0,0,1577,1578,5,78,0,0,1578,1579,3,54,27,0,1579,1580,
        5,68,0,0,1580,1581,3,248,124,0,1581,1582,5,69,0,0,1582,257,1,0,0,0,1583,
        1585,5,70,0,0,1584,1586,3,260,130,0,1585,1584,1,0,0,0,1585,1586,1,0,0,
        0,1586,1588,1,0,0,0,1587,1589,5,75,0,0,1588,1587,1,0,0,0,1588,1589,1,0,
        0,0,1589,1590,1,0,0,0,1590,1591,5,71,0,0,1591,259,1,0,0,0,1592,1597,3,
        124,62,0,1593,1594,5,75,0,0,1594,1596,3,124,62,0,1595,1593,1,0,0,0,1596,
        1599,1,0,0,0,1597,1595,1,0,0,0,1597,1598,1,0,0,0,1598,261,1,0,0,0,1599,
        1597,1,0,0,0,1600,1602,5,70,0,0,1601,1603,3,264,132,0,1602,1601,1,0,0,
        0,1602,1603,1,0,0,0,1603,1604,1,0,0,0,1604,1605,5,71,0,0,1605,263,1,0,
        0,0,1606,1608,3,266,133,0,1607,1606,1,0,0,0,1608,1609,1,0,0,0,1609,1607,
        1,0,0,0,1609,1610,1,0,0,0,1610,265,1,0,0,0,1611,1615,3,268,134,0,1612,
        1615,3,92,46,0,1613,1615,3,272,136,0,1614,1611,1,0,0,0,1614,1612,1,0,0,
        0,1614,1613,1,0,0,0,1615,267,1,0,0,0,1616,1617,3,270,135,0,1617,1618,5,
        74,0,0,1618,269,1,0,0,0,1619,1621,3,166,83,0,1620,1619,1,0,0,0,1621,1624,
        1,0,0,0,1622,1620,1,0,0,0,1622,1623,1,0,0,0,1623,1625,1,0,0,0,1624,1622,
        1,0,0,0,1625,1626,3,126,63,0,1626,1627,3,118,59,0,1627,271,1,0,0,0,1628,
        1635,3,276,138,0,1629,1635,3,280,140,0,1630,1635,3,288,144,0,1631,1635,
        3,290,145,0,1632,1635,3,308,154,0,1633,1635,3,314,157,0,1634,1628,1,0,
        0,0,1634,1629,1,0,0,0,1634,1630,1,0,0,0,1634,1631,1,0,0,0,1634,1632,1,
        0,0,0,1634,1633,1,0,0,0,1635,273,1,0,0,0,1636,1642,3,276,138,0,1637,1642,
        3,282,141,0,1638,1642,3,292,146,0,1639,1642,3,310,155,0,1640,1642,3,316,
        158,0,1641,1636,1,0,0,0,1641,1637,1,0,0,0,1641,1638,1,0,0,0,1641,1639,
        1,0,0,0,1641,1640,1,0,0,0,1642,275,1,0,0,0,1643,1656,3,262,131,0,1644,
        1656,3,278,139,0,1645,1656,3,284,142,0,1646,1656,3,294,147,0,1647,1656,
        3,296,148,0,1648,1656,3,312,156,0,1649,1656,3,332,166,0,1650,1656,3,334,
        167,0,1651,1656,3,336,168,0,1652,1656,3,340,170,0,1653,1656,3,338,169,
        0,1654,1656,3,342,171,0,1655,1643,1,0,0,0,1655,1644,1,0,0,0,1655,1645,
        1,0,0,0,1655,1646,1,0,0,0,1655,1647,1,0,0,0,1655,1648,1,0,0,0,1655,1649,
        1,0,0,0,1655,1650,1,0,0,0,1655,1651,1,0,0,0,1655,1652,1,0,0,0,1655,1653,
        1,0,0,0,1655,1654,1,0,0,0,1656,277,1,0,0,0,1657,1658,5,74,0,0,1658,279,
        1,0,0,0,1659,1660,3,488,244,0,1660,1661,5,86,0,0,1661,1662,3,272,136,0,
        1662,281,1,0,0,0,1663,1664,3,488,244,0,1664,1665,5,86,0,0,1665,1666,3,
        274,137,0,1666,283,1,0,0,0,1667,1668,3,286,143,0,1668,1669,5,74,0,0,1669,
        285,1,0,0,0,1670,1678,3,440,220,0,1671,1678,3,470,235,0,1672,1678,3,472,
        236,0,1673,1678,3,478,239,0,1674,1678,3,482,241,0,1675,1678,3,406,203,
        0,1676,1678,3,386,193,0,1677,1670,1,0,0,0,1677,1671,1,0,0,0,1677,1672,
        1,0,0,0,1677,1673,1,0,0,0,1677,1674,1,0,0,0,1677,1675,1,0,0,0,1677,1676,
        1,0,0,0,1678,287,1,0,0,0,1679,1680,5,32,0,0,1680,1681,5,68,0,0,1681,1682,
        3,428,214,0,1682,1683,5,69,0,0,1683,1684,3,272,136,0,1684,289,1,0,0,0,
        1685,1686,5,32,0,0,1686,1687,5,68,0,0,1687,1688,3,428,214,0,1688,1689,
        5,69,0,0,1689,1690,3,274,137,0,1690,1691,5,25,0,0,1691,1692,3,272,136,
        0,1692,291,1,0,0,0,1693,1694,5,32,0,0,1694,1695,5,68,0,0,1695,1696,3,428,
        214,0,1696,1697,5,69,0,0,1697,1698,3,274,137,0,1698,1699,5,25,0,0,1699,
        1700,3,274,137,0,1700,293,1,0,0,0,1701,1702,5,12,0,0,1702,1703,3,428,214,
        0,1703,1704,5,74,0,0,1704,1712,1,0,0,0,1705,1706,5,12,0,0,1706,1707,3,
        428,214,0,1707,1708,5,86,0,0,1708,1709,3,428,214,0,1709,1710,5,74,0,0,
        1710,1712,1,0,0,0,1711,1701,1,0,0,0,1711,1705,1,0,0,0,1712,295,1,0,0,0,
        1713,1714,5,51,0,0,1714,1715,5,68,0,0,1715,1716,3,428,214,0,1716,1717,
        5,69,0,0,1717,1718,3,298,149,0,1718,297,1,0,0,0,1719,1723,5,70,0,0,1720,
        1722,3,300,150,0,1721,1720,1,0,0,0,1722,1725,1,0,0,0,1723,1721,1,0,0,0,
        1723,1724,1,0,0,0,1724,1729,1,0,0,0,1725,1723,1,0,0,0,1726,1728,3,304,
        152,0,1727,1726,1,0,0,0,1728,1731,1,0,0,0,1729,1727,1,0,0,0,1729,1730,
        1,0,0,0,1730,1732,1,0,0,0,1731,1729,1,0,0,0,1732,1733,5,71,0,0,1733,299,
        1,0,0,0,1734,1735,3,302,151,0,1735,1736,3,264,132,0,1736,301,1,0,0,0,1737,
        1739,3,304,152,0,1738,1737,1,0,0,0,1739,1740,1,0,0,0,1740,1738,1,0,0,0,
        1740,1741,1,0,0,0,1741,303,1,0,0,0,1742,1743,5,16,0,0,1743,1744,3,426,
        213,0,1744,1745,5,86,0,0,1745,1753,1,0,0,0,1746,1747,5,16,0,0,1747,1748,
        3,306,153,0,1748,1749,5,86,0,0,1749,1753,1,0,0,0,1750,1751,5,22,0,0,1751,
        1753,5,86,0,0,1752,1742,1,0,0,0,1752,1746,1,0,0,0,1752,1750,1,0,0,0,1753,
        305,1,0,0,0,1754,1755,3,488,244,0,1755,307,1,0,0,0,1756,1757,5,60,0,0,
        1757,1758,5,68,0,0,1758,1759,3,428,214,0,1759,1760,5,69,0,0,1760,1761,
        3,272,136,0,1761,309,1,0,0,0,1762,1763,5,60,0,0,1763,1764,5,68,0,0,1764,
        1765,3,428,214,0,1765,1766,5,69,0,0,1766,1767,3,274,137,0,1767,311,1,0,
        0,0,1768,1769,5,23,0,0,1769,1770,3,272,136,0,1770,1771,5,60,0,0,1771,1772,
        5,68,0,0,1772,1773,3,428,214,0,1773,1774,5,69,0,0,1774,1775,5,74,0,0,1775,
        313,1,0,0,0,1776,1779,3,318,159,0,1777,1779,3,328,164,0,1778,1776,1,0,
        0,0,1778,1777,1,0,0,0,1779,315,1,0,0,0,1780,1783,3,320,160,0,1781,1783,
        3,330,165,0,1782,1780,1,0,0,0,1782,1781,1,0,0,0,1783,317,1,0,0,0,1784,
        1785,5,31,0,0,1785,1787,5,68,0,0,1786,1788,3,322,161,0,1787,1786,1,0,0,
        0,1787,1788,1,0,0,0,1788,1789,1,0,0,0,1789,1791,5,74,0,0,1790,1792,3,428,
        214,0,1791,1790,1,0,0,0,1791,1792,1,0,0,0,1792,1793,1,0,0,0,1793,1795,
        5,74,0,0,1794,1796,3,324,162,0,1795,1794,1,0,0,0,1795,1796,1,0,0,0,1796,
        1797,1,0,0,0,1797,1798,5,69,0,0,1798,1799,3,272,136,0,1799,319,1,0,0,0,
        1800,1801,5,31,0,0,1801,1803,5,68,0,0,1802,1804,3,322,161,0,1803,1802,
        1,0,0,0,1803,1804,1,0,0,0,1804,1805,1,0,0,0,1805,1807,5,74,0,0,1806,1808,
        3,428,214,0,1807,1806,1,0,0,0,1807,1808,1,0,0,0,1808,1809,1,0,0,0,1809,
        1811,5,74,0,0,1810,1812,3,324,162,0,1811,1810,1,0,0,0,1811,1812,1,0,0,
        0,1812,1813,1,0,0,0,1813,1814,5,69,0,0,1814,1815,3,274,137,0,1815,321,
        1,0,0,0,1816,1819,3,326,163,0,1817,1819,3,270,135,0,1818,1816,1,0,0,0,
        1818,1817,1,0,0,0,1819,323,1,0,0,0,1820,1821,3,326,163,0,1821,325,1,0,
        0,0,1822,1827,3,286,143,0,1823,1824,5,75,0,0,1824,1826,3,286,143,0,1825,
        1823,1,0,0,0,1826,1829,1,0,0,0,1827,1825,1,0,0,0,1827,1828,1,0,0,0,1828,
        327,1,0,0,0,1829,1827,1,0,0,0,1830,1831,5,31,0,0,1831,1835,5,68,0,0,1832,
        1834,3,166,83,0,1833,1832,1,0,0,0,1834,1837,1,0,0,0,1835,1833,1,0,0,0,
        1835,1836,1,0,0,0,1836,1838,1,0,0,0,1837,1835,1,0,0,0,1838,1839,3,126,
        63,0,1839,1840,3,122,61,0,1840,1841,5,86,0,0,1841,1842,3,428,214,0,1842,
        1843,5,69,0,0,1843,1844,3,272,136,0,1844,329,1,0,0,0,1845,1846,5,31,0,
        0,1846,1850,5,68,0,0,1847,1849,3,166,83,0,1848,1847,1,0,0,0,1849,1852,
        1,0,0,0,1850,1848,1,0,0,0,1850,1851,1,0,0,0,1851,1853,1,0,0,0,1852,1850,
        1,0,0,0,1853,1854,3,126,63,0,1854,1855,3,122,61,0,1855,1856,5,86,0,0,1856,
        1857,3,428,214,0,1857,1858,5,69,0,0,1858,1859,3,274,137,0,1859,331,1,0,
        0,0,1860,1862,5,14,0,0,1861,1863,3,488,244,0,1862,1861,1,0,0,0,1862,1863,
        1,0,0,0,1863,1864,1,0,0,0,1864,1865,5,74,0,0,1865,333,1,0,0,0,1866,1868,
        5,21,0,0,1867,1869,3,488,244,0,1868,1867,1,0,0,0,1868,1869,1,0,0,0,1869,
        1870,1,0,0,0,1870,1871,5,74,0,0,1871,335,1,0,0,0,1872,1874,5,46,0,0,1873,
        1875,3,428,214,0,1874,1873,1,0,0,0,1874,1875,1,0,0,0,1875,1876,1,0,0,0,
        1876,1877,5,74,0,0,1877,337,1,0,0,0,1878,1879,5,54,0,0,1879,1880,3,428,
        214,0,1880,1881,5,74,0,0,1881,339,1,0,0,0,1882,1883,5,52,0,0,1883,1884,
        5,68,0,0,1884,1885,3,428,214,0,1885,1886,5,69,0,0,1886,1887,3,262,131,
        0,1887,341,1,0,0,0,1888,1889,5,57,0,0,1889,1890,3,262,131,0,1890,1891,
        3,344,172,0,1891,1901,1,0,0,0,1892,1893,5,57,0,0,1893,1895,3,262,131,0,
        1894,1896,3,344,172,0,1895,1894,1,0,0,0,1895,1896,1,0,0,0,1896,1897,1,
        0,0,0,1897,1898,3,352,176,0,1898,1901,1,0,0,0,1899,1901,3,354,177,0,1900,
        1888,1,0,0,0,1900,1892,1,0,0,0,1900,1899,1,0,0,0,1901,343,1,0,0,0,1902,
        1904,3,346,173,0,1903,1902,1,0,0,0,1904,1905,1,0,0,0,1905,1903,1,0,0,0,
        1905,1906,1,0,0,0,1906,345,1,0,0,0,1907,1908,5,17,0,0,1908,1909,5,68,0,
        0,1909,1910,3,348,174,0,1910,1911,5,69,0,0,1911,1912,3,262,131,0,1912,
        347,1,0,0,0,1913,1915,3,166,83,0,1914,1913,1,0,0,0,1915,1918,1,0,0,0,1916,
        1914,1,0,0,0,1916,1917,1,0,0,0,1917,1919,1,0,0,0,1918,1916,1,0,0,0,1919,
        1920,3,350,175,0,1920,1921,3,122,61,0,1921,349,1,0,0,0,1922,1927,3,134,
        67,0,1923,1924,5,101,0,0,1924,1926,3,14,7,0,1925,1923,1,0,0,0,1926,1929,
        1,0,0,0,1927,1925,1,0,0,0,1927,1928,1,0,0,0,1928,351,1,0,0,0,1929,1927,
        1,0,0,0,1930,1931,5,29,0,0,1931,1932,3,262,131,0,1932,353,1,0,0,0,1933,
        1934,5,57,0,0,1934,1935,3,356,178,0,1935,1937,3,262,131,0,1936,1938,3,
        344,172,0,1937,1936,1,0,0,0,1937,1938,1,0,0,0,1938,1940,1,0,0,0,1939,1941,
        3,352,176,0,1940,1939,1,0,0,0,1940,1941,1,0,0,0,1941,355,1,0,0,0,1942,
        1943,5,68,0,0,1943,1945,3,358,179,0,1944,1946,5,74,0,0,1945,1944,1,0,0,
        0,1945,1946,1,0,0,0,1946,1947,1,0,0,0,1947,1948,5,69,0,0,1948,357,1,0,
        0,0,1949,1954,3,360,180,0,1950,1951,5,74,0,0,1951,1953,3,360,180,0,1952,
        1950,1,0,0,0,1953,1956,1,0,0,0,1954,1952,1,0,0,0,1954,1955,1,0,0,0,1955,
        359,1,0,0,0,1956,1954,1,0,0,0,1957,1959,3,166,83,0,1958,1957,1,0,0,0,1959,
        1962,1,0,0,0,1960,1958,1,0,0,0,1960,1961,1,0,0,0,1961,1963,1,0,0,0,1962,
        1960,1,0,0,0,1963,1964,3,126,63,0,1964,1965,3,122,61,0,1965,1966,5,80,
        0,0,1966,1967,3,428,214,0,1967,1970,1,0,0,0,1968,1970,3,362,181,0,1969,
        1960,1,0,0,0,1969,1968,1,0,0,0,1970,361,1,0,0,0,1971,1974,3,58,29,0,1972,
        1974,3,394,197,0,1973,1971,1,0,0,0,1973,1972,1,0,0,0,1974,363,1,0,0,0,
        1975,1978,3,378,189,0,1976,1978,3,420,210,0,1977,1975,1,0,0,0,1977,1976,
        1,0,0,0,1978,1982,1,0,0,0,1979,1981,3,372,186,0,1980,1979,1,0,0,0,1981,
        1984,1,0,0,0,1982,1980,1,0,0,0,1982,1983,1,0,0,0,1983,365,1,0,0,0,1984,
        1982,1,0,0,0,1985,2002,3,0,0,0,1986,2002,3,384,192,0,1987,2002,5,53,0,
        0,1988,1989,3,54,27,0,1989,1990,5,76,0,0,1990,1991,5,53,0,0,1991,2002,
        1,0,0,0,1992,1993,5,68,0,0,1993,1994,3,428,214,0,1994,1995,5,69,0,0,1995,
        2002,1,0,0,0,1996,2002,3,386,193,0,1997,2002,3,394,197,0,1998,2002,3,400,
        200,0,1999,2002,3,406,203,0,2000,2002,3,414,207,0,2001,1985,1,0,0,0,2001,
        1986,1,0,0,0,2001,1987,1,0,0,0,2001,1988,1,0,0,0,2001,1992,1,0,0,0,2001,
        1996,1,0,0,0,2001,1997,1,0,0,0,2001,1998,1,0,0,0,2001,1999,1,0,0,0,2001,
        2000,1,0,0,0,2002,367,1,0,0,0,2003,2004,1,0,0,0,2004,369,1,0,0,0,2005,
        2034,3,0,0,0,2006,2011,3,54,27,0,2007,2008,5,72,0,0,2008,2010,5,73,0,0,
        2009,2007,1,0,0,0,2010,2013,1,0,0,0,2011,2009,1,0,0,0,2011,2012,1,0,0,
        0,2012,2014,1,0,0,0,2013,2011,1,0,0,0,2014,2015,5,76,0,0,2015,2016,5,19,
        0,0,2016,2034,1,0,0,0,2017,2018,5,58,0,0,2018,2019,5,76,0,0,2019,2034,
        5,19,0,0,2020,2034,5,53,0,0,2021,2022,3,54,27,0,2022,2023,5,76,0,0,2023,
        2024,5,53,0,0,2024,2034,1,0,0,0,2025,2026,5,68,0,0,2026,2027,3,428,214,
        0,2027,2028,5,69,0,0,2028,2034,1,0,0,0,2029,2034,3,386,193,0,2030,2034,
        3,394,197,0,2031,2034,3,406,203,0,2032,2034,3,414,207,0,2033,2005,1,0,
        0,0,2033,2006,1,0,0,0,2033,2017,1,0,0,0,2033,2020,1,0,0,0,2033,2021,1,
        0,0,0,2033,2025,1,0,0,0,2033,2029,1,0,0,0,2033,2030,1,0,0,0,2033,2031,
        1,0,0,0,2033,2032,1,0,0,0,2034,371,1,0,0,0,2035,2041,3,388,194,0,2036,
        2041,3,396,198,0,2037,2041,3,402,201,0,2038,2041,3,408,204,0,2039,2041,
        3,416,208,0,2040,2035,1,0,0,0,2040,2036,1,0,0,0,2040,2037,1,0,0,0,2040,
        2038,1,0,0,0,2040,2039,1,0,0,0,2041,373,1,0,0,0,2042,2043,1,0,0,0,2043,
        375,1,0,0,0,2044,2049,3,388,194,0,2045,2049,3,396,198,0,2046,2049,3,408,
        204,0,2047,2049,3,416,208,0,2048,2044,1,0,0,0,2048,2045,1,0,0,0,2048,2046,
        1,0,0,0,2048,2047,1,0,0,0,2049,377,1,0,0,0,2050,2091,3,0,0,0,2051,2056,
        3,54,27,0,2052,2053,5,72,0,0,2053,2055,5,73,0,0,2054,2052,1,0,0,0,2055,
        2058,1,0,0,0,2056,2054,1,0,0,0,2056,2057,1,0,0,0,2057,2059,1,0,0,0,2058,
        2056,1,0,0,0,2059,2060,5,76,0,0,2060,2061,5,19,0,0,2061,2091,1,0,0,0,2062,
        2067,3,128,64,0,2063,2064,5,72,0,0,2064,2066,5,73,0,0,2065,2063,1,0,0,
        0,2066,2069,1,0,0,0,2067,2065,1,0,0,0,2067,2068,1,0,0,0,2068,2070,1,0,
        0,0,2069,2067,1,0,0,0,2070,2071,5,76,0,0,2071,2072,5,19,0,0,2072,2091,
        1,0,0,0,2073,2074,5,58,0,0,2074,2075,5,76,0,0,2075,2091,5,19,0,0,2076,
        2091,5,53,0,0,2077,2078,3,54,27,0,2078,2079,5,76,0,0,2079,2080,5,53,0,
        0,2080,2091,1,0,0,0,2081,2082,5,68,0,0,2082,2083,3,428,214,0,2083,2084,
        5,69,0,0,2084,2091,1,0,0,0,2085,2091,3,390,195,0,2086,2091,3,398,199,0,
        2087,2091,3,404,202,0,2088,2091,3,410,205,0,2089,2091,3,418,209,0,2090,
        2050,1,0,0,0,2090,2051,1,0,0,0,2090,2062,1,0,0,0,2090,2073,1,0,0,0,2090,
        2076,1,0,0,0,2090,2077,1,0,0,0,2090,2081,1,0,0,0,2090,2085,1,0,0,0,2090,
        2086,1,0,0,0,2090,2087,1,0,0,0,2090,2088,1,0,0,0,2090,2089,1,0,0,0,2091,
        379,1,0,0,0,2092,2093,1,0,0,0,2093,381,1,0,0,0,2094,2134,3,0,0,0,2095,
        2100,3,54,27,0,2096,2097,5,72,0,0,2097,2099,5,73,0,0,2098,2096,1,0,0,0,
        2099,2102,1,0,0,0,2100,2098,1,0,0,0,2100,2101,1,0,0,0,2101,2103,1,0,0,
        0,2102,2100,1,0,0,0,2103,2104,5,76,0,0,2104,2105,5,19,0,0,2105,2134,1,
        0,0,0,2106,2111,3,128,64,0,2107,2108,5,72,0,0,2108,2110,5,73,0,0,2109,
        2107,1,0,0,0,2110,2113,1,0,0,0,2111,2109,1,0,0,0,2111,2112,1,0,0,0,2112,
        2114,1,0,0,0,2113,2111,1,0,0,0,2114,2115,5,76,0,0,2115,2116,5,19,0,0,2116,
        2134,1,0,0,0,2117,2118,5,58,0,0,2118,2119,5,76,0,0,2119,2134,5,19,0,0,
        2120,2134,5,53,0,0,2121,2122,3,54,27,0,2122,2123,5,76,0,0,2123,2124,5,
        53,0,0,2124,2134,1,0,0,0,2125,2126,5,68,0,0,2126,2127,3,428,214,0,2127,
        2128,5,69,0,0,2128,2134,1,0,0,0,2129,2134,3,390,195,0,2130,2134,3,398,
        199,0,2131,2134,3,410,205,0,2132,2134,3,418,209,0,2133,2094,1,0,0,0,2133,
        2095,1,0,0,0,2133,2106,1,0,0,0,2133,2117,1,0,0,0,2133,2120,1,0,0,0,2133,
        2121,1,0,0,0,2133,2125,1,0,0,0,2133,2129,1,0,0,0,2133,2130,1,0,0,0,2133,
        2131,1,0,0,0,2133,2132,1,0,0,0,2134,383,1,0,0,0,2135,2139,3,54,27,0,2136,
        2139,3,4,2,0,2137,2139,5,13,0,0,2138,2135,1,0,0,0,2138,2136,1,0,0,0,2138,
        2137,1,0,0,0,2139,2144,1,0,0,0,2140,2141,5,72,0,0,2141,2143,5,73,0,0,2142,
        2140,1,0,0,0,2143,2146,1,0,0,0,2144,2142,1,0,0,0,2144,2145,1,0,0,0,2145,
        2147,1,0,0,0,2146,2144,1,0,0,0,2147,2148,5,76,0,0,2148,2153,5,19,0,0,2149,
        2150,5,58,0,0,2150,2151,5,76,0,0,2151,2153,5,19,0,0,2152,2138,1,0,0,0,
        2152,2149,1,0,0,0,2153,385,1,0,0,0,2154,2156,5,41,0,0,2155,2157,3,40,20,
        0,2156,2155,1,0,0,0,2156,2157,1,0,0,0,2157,2161,1,0,0,0,2158,2160,3,240,
        120,0,2159,2158,1,0,0,0,2160,2163,1,0,0,0,2161,2159,1,0,0,0,2161,2162,
        1,0,0,0,2162,2164,1,0,0,0,2163,2161,1,0,0,0,2164,2175,3,488,244,0,2165,
        2169,5,76,0,0,2166,2168,3,240,120,0,2167,2166,1,0,0,0,2168,2171,1,0,0,
        0,2169,2167,1,0,0,0,2169,2170,1,0,0,0,2170,2172,1,0,0,0,2171,2169,1,0,
        0,0,2172,2174,3,488,244,0,2173,2165,1,0,0,0,2174,2177,1,0,0,0,2175,2173,
        1,0,0,0,2175,2176,1,0,0,0,2176,2179,1,0,0,0,2177,2175,1,0,0,0,2178,2180,
        3,392,196,0,2179,2178,1,0,0,0,2179,2180,1,0,0,0,2180,2181,1,0,0,0,2181,
        2183,5,68,0,0,2182,2184,3,412,206,0,2183,2182,1,0,0,0,2183,2184,1,0,0,
        0,2184,2185,1,0,0,0,2185,2187,5,69,0,0,2186,2188,3,108,54,0,2187,2186,
        1,0,0,0,2187,2188,1,0,0,0,2188,2238,1,0,0,0,2189,2190,3,58,29,0,2190,2191,
        5,76,0,0,2191,2193,5,41,0,0,2192,2194,3,40,20,0,2193,2192,1,0,0,0,2193,
        2194,1,0,0,0,2194,2198,1,0,0,0,2195,2197,3,240,120,0,2196,2195,1,0,0,0,
        2197,2200,1,0,0,0,2198,2196,1,0,0,0,2198,2199,1,0,0,0,2199,2201,1,0,0,
        0,2200,2198,1,0,0,0,2201,2203,3,488,244,0,2202,2204,3,392,196,0,2203,2202,
        1,0,0,0,2203,2204,1,0,0,0,2204,2205,1,0,0,0,2205,2207,5,68,0,0,2206,2208,
        3,412,206,0,2207,2206,1,0,0,0,2207,2208,1,0,0,0,2208,2209,1,0,0,0,2209,
        2211,5,69,0,0,2210,2212,3,108,54,0,2211,2210,1,0,0,0,2211,2212,1,0,0,0,
        2212,2238,1,0,0,0,2213,2214,3,364,182,0,2214,2215,5,76,0,0,2215,2217,5,
        41,0,0,2216,2218,3,40,20,0,2217,2216,1,0,0,0,2217,2218,1,0,0,0,2218,2222,
        1,0,0,0,2219,2221,3,240,120,0,2220,2219,1,0,0,0,2221,2224,1,0,0,0,2222,
        2220,1,0,0,0,2222,2223,1,0,0,0,2223,2225,1,0,0,0,2224,2222,1,0,0,0,2225,
        2227,3,488,244,0,2226,2228,3,392,196,0,2227,2226,1,0,0,0,2227,2228,1,0,
        0,0,2228,2229,1,0,0,0,2229,2231,5,68,0,0,2230,2232,3,412,206,0,2231,2230,
        1,0,0,0,2231,2232,1,0,0,0,2232,2233,1,0,0,0,2233,2235,5,69,0,0,2234,2236,
        3,108,54,0,2235,2234,1,0,0,0,2235,2236,1,0,0,0,2236,2238,1,0,0,0,2237,
        2154,1,0,0,0,2237,2189,1,0,0,0,2237,2213,1,0,0,0,2238,387,1,0,0,0,2239,
        2240,5,76,0,0,2240,2242,5,41,0,0,2241,2243,3,40,20,0,2242,2241,1,0,0,0,
        2242,2243,1,0,0,0,2243,2247,1,0,0,0,2244,2246,3,240,120,0,2245,2244,1,
        0,0,0,2246,2249,1,0,0,0,2247,2245,1,0,0,0,2247,2248,1,0,0,0,2248,2250,
        1,0,0,0,2249,2247,1,0,0,0,2250,2252,3,488,244,0,2251,2253,3,392,196,0,
        2252,2251,1,0,0,0,2252,2253,1,0,0,0,2253,2254,1,0,0,0,2254,2256,5,68,0,
        0,2255,2257,3,412,206,0,2256,2255,1,0,0,0,2256,2257,1,0,0,0,2257,2258,
        1,0,0,0,2258,2260,5,69,0,0,2259,2261,3,108,54,0,2260,2259,1,0,0,0,2260,
        2261,1,0,0,0,2261,389,1,0,0,0,2262,2264,5,41,0,0,2263,2265,3,40,20,0,2264,
        2263,1,0,0,0,2264,2265,1,0,0,0,2265,2269,1,0,0,0,2266,2268,3,240,120,0,
        2267,2266,1,0,0,0,2268,2271,1,0,0,0,2269,2267,1,0,0,0,2269,2270,1,0,0,
        0,2270,2272,1,0,0,0,2271,2269,1,0,0,0,2272,2283,3,488,244,0,2273,2277,
        5,76,0,0,2274,2276,3,240,120,0,2275,2274,1,0,0,0,2276,2279,1,0,0,0,2277,
        2275,1,0,0,0,2277,2278,1,0,0,0,2278,2280,1,0,0,0,2279,2277,1,0,0,0,2280,
        2282,3,488,244,0,2281,2273,1,0,0,0,2282,2285,1,0,0,0,2283,2281,1,0,0,0,
        2283,2284,1,0,0,0,2284,2287,1,0,0,0,2285,2283,1,0,0,0,2286,2288,3,392,
        196,0,2287,2286,1,0,0,0,2287,2288,1,0,0,0,2288,2289,1,0,0,0,2289,2291,
        5,68,0,0,2290,2292,3,412,206,0,2291,2290,1,0,0,0,2291,2292,1,0,0,0,2292,
        2293,1,0,0,0,2293,2295,5,69,0,0,2294,2296,3,108,54,0,2295,2294,1,0,0,0,
        2295,2296,1,0,0,0,2296,2322,1,0,0,0,2297,2298,3,58,29,0,2298,2299,5,76,
        0,0,2299,2301,5,41,0,0,2300,2302,3,40,20,0,2301,2300,1,0,0,0,2301,2302,
        1,0,0,0,2302,2306,1,0,0,0,2303,2305,3,240,120,0,2304,2303,1,0,0,0,2305,
        2308,1,0,0,0,2306,2304,1,0,0,0,2306,2307,1,0,0,0,2307,2309,1,0,0,0,2308,
        2306,1,0,0,0,2309,2311,3,488,244,0,2310,2312,3,392,196,0,2311,2310,1,0,
        0,0,2311,2312,1,0,0,0,2312,2313,1,0,0,0,2313,2315,5,68,0,0,2314,2316,3,
        412,206,0,2315,2314,1,0,0,0,2315,2316,1,0,0,0,2316,2317,1,0,0,0,2317,2319,
        5,69,0,0,2318,2320,3,108,54,0,2319,2318,1,0,0,0,2319,2320,1,0,0,0,2320,
        2322,1,0,0,0,2321,2262,1,0,0,0,2321,2297,1,0,0,0,2322,391,1,0,0,0,2323,
        2327,3,40,20,0,2324,2325,5,82,0,0,2325,2327,5,81,0,0,2326,2323,1,0,0,0,
        2326,2324,1,0,0,0,2327,393,1,0,0,0,2328,2329,3,364,182,0,2329,2330,5,76,
        0,0,2330,2331,3,488,244,0,2331,2342,1,0,0,0,2332,2333,5,50,0,0,2333,2334,
        5,76,0,0,2334,2342,3,488,244,0,2335,2336,3,54,27,0,2336,2337,5,76,0,0,
        2337,2338,5,50,0,0,2338,2339,5,76,0,0,2339,2340,3,488,244,0,2340,2342,
        1,0,0,0,2341,2328,1,0,0,0,2341,2332,1,0,0,0,2341,2335,1,0,0,0,2342,395,
        1,0,0,0,2343,2344,5,76,0,0,2344,2345,3,488,244,0,2345,397,1,0,0,0,2346,
        2347,5,50,0,0,2347,2348,5,76,0,0,2348,2356,3,488,244,0,2349,2350,3,54,
        27,0,2350,2351,5,76,0,0,2351,2352,5,50,0,0,2352,2353,5,76,0,0,2353,2354,
        3,488,244,0,2354,2356,1,0,0,0,2355,2346,1,0,0,0,2355,2349,1,0,0,0,2356,
        399,1,0,0,0,2357,2358,3,58,29,0,2358,2359,5,72,0,0,2359,2360,3,428,214,
        0,2360,2361,5,73,0,0,2361,2368,1,0,0,0,2362,2363,3,370,185,0,2363,2364,
        5,72,0,0,2364,2365,3,428,214,0,2365,2366,5,73,0,0,2366,2368,1,0,0,0,2367,
        2357,1,0,0,0,2367,2362,1,0,0,0,2368,2376,1,0,0,0,2369,2370,3,368,184,0,
        2370,2371,5,72,0,0,2371,2372,3,428,214,0,2372,2373,5,73,0,0,2373,2375,
        1,0,0,0,2374,2369,1,0,0,0,2375,2378,1,0,0,0,2376,2374,1,0,0,0,2376,2377,
        1,0,0,0,2377,401,1,0,0,0,2378,2376,1,0,0,0,2379,2380,3,376,188,0,2380,
        2381,5,72,0,0,2381,2382,3,428,214,0,2382,2383,5,73,0,0,2383,2391,1,0,0,
        0,2384,2385,3,374,187,0,2385,2386,5,72,0,0,2386,2387,3,428,214,0,2387,
        2388,5,73,0,0,2388,2390,1,0,0,0,2389,2384,1,0,0,0,2390,2393,1,0,0,0,2391,
        2389,1,0,0,0,2391,2392,1,0,0,0,2392,403,1,0,0,0,2393,2391,1,0,0,0,2394,
        2395,3,58,29,0,2395,2396,5,72,0,0,2396,2397,3,428,214,0,2397,2398,5,73,
        0,0,2398,2405,1,0,0,0,2399,2400,3,382,191,0,2400,2401,5,72,0,0,2401,2402,
        3,428,214,0,2402,2403,5,73,0,0,2403,2405,1,0,0,0,2404,2394,1,0,0,0,2404,
        2399,1,0,0,0,2405,2413,1,0,0,0,2406,2407,3,380,190,0,2407,2408,5,72,0,
        0,2408,2409,3,428,214,0,2409,2410,5,73,0,0,2410,2412,1,0,0,0,2411,2406,
        1,0,0,0,2412,2415,1,0,0,0,2413,2411,1,0,0,0,2413,2414,1,0,0,0,2414,405,
        1,0,0,0,2415,2413,1,0,0,0,2416,2417,3,60,30,0,2417,2419,5,68,0,0,2418,
        2420,3,412,206,0,2419,2418,1,0,0,0,2419,2420,1,0,0,0,2420,2421,1,0,0,0,
        2421,2422,5,69,0,0,2422,2486,1,0,0,0,2423,2424,3,54,27,0,2424,2426,5,76,
        0,0,2425,2427,3,40,20,0,2426,2425,1,0,0,0,2426,2427,1,0,0,0,2427,2428,
        1,0,0,0,2428,2429,3,488,244,0,2429,2431,5,68,0,0,2430,2432,3,412,206,0,
        2431,2430,1,0,0,0,2431,2432,1,0,0,0,2432,2433,1,0,0,0,2433,2434,5,69,0,
        0,2434,2486,1,0,0,0,2435,2436,3,58,29,0,2436,2438,5,76,0,0,2437,2439,3,
        40,20,0,2438,2437,1,0,0,0,2438,2439,1,0,0,0,2439,2440,1,0,0,0,2440,2441,
        3,488,244,0,2441,2443,5,68,0,0,2442,2444,3,412,206,0,2443,2442,1,0,0,0,
        2443,2444,1,0,0,0,2444,2445,1,0,0,0,2445,2446,5,69,0,0,2446,2486,1,0,0,
        0,2447,2448,3,364,182,0,2448,2450,5,76,0,0,2449,2451,3,40,20,0,2450,2449,
        1,0,0,0,2450,2451,1,0,0,0,2451,2452,1,0,0,0,2452,2453,3,488,244,0,2453,
        2455,5,68,0,0,2454,2456,3,412,206,0,2455,2454,1,0,0,0,2455,2456,1,0,0,
        0,2456,2457,1,0,0,0,2457,2458,5,69,0,0,2458,2486,1,0,0,0,2459,2460,5,50,
        0,0,2460,2462,5,76,0,0,2461,2463,3,40,20,0,2462,2461,1,0,0,0,2462,2463,
        1,0,0,0,2463,2464,1,0,0,0,2464,2465,3,488,244,0,2465,2467,5,68,0,0,2466,
        2468,3,412,206,0,2467,2466,1,0,0,0,2467,2468,1,0,0,0,2468,2469,1,0,0,0,
        2469,2470,5,69,0,0,2470,2486,1,0,0,0,2471,2472,3,54,27,0,2472,2473,5,76,
        0,0,2473,2474,5,50,0,0,2474,2476,5,76,0,0,2475,2477,3,40,20,0,2476,2475,
        1,0,0,0,2476,2477,1,0,0,0,2477,2478,1,0,0,0,2478,2479,3,488,244,0,2479,
        2481,5,68,0,0,2480,2482,3,412,206,0,2481,2480,1,0,0,0,2481,2482,1,0,0,
        0,2482,2483,1,0,0,0,2483,2484,5,69,0,0,2484,2486,1,0,0,0,2485,2416,1,0,
        0,0,2485,2423,1,0,0,0,2485,2435,1,0,0,0,2485,2447,1,0,0,0,2485,2459,1,
        0,0,0,2485,2471,1,0,0,0,2486,407,1,0,0,0,2487,2489,5,76,0,0,2488,2490,
        3,40,20,0,2489,2488,1,0,0,0,2489,2490,1,0,0,0,2490,2491,1,0,0,0,2491,2492,
        3,488,244,0,2492,2494,5,68,0,0,2493,2495,3,412,206,0,2494,2493,1,0,0,0,
        2494,2495,1,0,0,0,2495,2496,1,0,0,0,2496,2497,5,69,0,0,2497,409,1,0,0,
        0,2498,2499,3,60,30,0,2499,2501,5,68,0,0,2500,2502,3,412,206,0,2501,2500,
        1,0,0,0,2501,2502,1,0,0,0,2502,2503,1,0,0,0,2503,2504,5,69,0,0,2504,2556,
        1,0,0,0,2505,2506,3,54,27,0,2506,2508,5,76,0,0,2507,2509,3,40,20,0,2508,
        2507,1,0,0,0,2508,2509,1,0,0,0,2509,2510,1,0,0,0,2510,2511,3,488,244,0,
        2511,2513,5,68,0,0,2512,2514,3,412,206,0,2513,2512,1,0,0,0,2513,2514,1,
        0,0,0,2514,2515,1,0,0,0,2515,2516,5,69,0,0,2516,2556,1,0,0,0,2517,2518,
        3,58,29,0,2518,2520,5,76,0,0,2519,2521,3,40,20,0,2520,2519,1,0,0,0,2520,
        2521,1,0,0,0,2521,2522,1,0,0,0,2522,2523,3,488,244,0,2523,2525,5,68,0,
        0,2524,2526,3,412,206,0,2525,2524,1,0,0,0,2525,2526,1,0,0,0,2526,2527,
        1,0,0,0,2527,2528,5,69,0,0,2528,2556,1,0,0,0,2529,2530,5,50,0,0,2530,2532,
        5,76,0,0,2531,2533,3,40,20,0,2532,2531,1,0,0,0,2532,2533,1,0,0,0,2533,
        2534,1,0,0,0,2534,2535,3,488,244,0,2535,2537,5,68,0,0,2536,2538,3,412,
        206,0,2537,2536,1,0,0,0,2537,2538,1,0,0,0,2538,2539,1,0,0,0,2539,2540,
        5,69,0,0,2540,2556,1,0,0,0,2541,2542,3,54,27,0,2542,2543,5,76,0,0,2543,
        2544,5,50,0,0,2544,2546,5,76,0,0,2545,2547,3,40,20,0,2546,2545,1,0,0,0,
        2546,2547,1,0,0,0,2547,2548,1,0,0,0,2548,2549,3,488,244,0,2549,2551,5,
        68,0,0,2550,2552,3,412,206,0,2551,2550,1,0,0,0,2551,2552,1,0,0,0,2552,
        2553,1,0,0,0,2553,2554,5,69,0,0,2554,2556,1,0,0,0,2555,2498,1,0,0,0,2555,
        2505,1,0,0,0,2555,2517,1,0,0,0,2555,2529,1,0,0,0,2555,2541,1,0,0,0,2556,
        411,1,0,0,0,2557,2562,3,428,214,0,2558,2559,5,75,0,0,2559,2561,3,428,214,
        0,2560,2558,1,0,0,0,2561,2564,1,0,0,0,2562,2560,1,0,0,0,2562,2563,1,0,
        0,0,2563,413,1,0,0,0,2564,2562,1,0,0,0,2565,2566,3,58,29,0,2566,2568,5,
        79,0,0,2567,2569,3,40,20,0,2568,2567,1,0,0,0,2568,2569,1,0,0,0,2569,2570,
        1,0,0,0,2570,2571,3,488,244,0,2571,2613,1,0,0,0,2572,2573,3,10,5,0,2573,
        2575,5,79,0,0,2574,2576,3,40,20,0,2575,2574,1,0,0,0,2575,2576,1,0,0,0,
        2576,2577,1,0,0,0,2577,2578,3,488,244,0,2578,2613,1,0,0,0,2579,2580,3,
        364,182,0,2580,2582,5,79,0,0,2581,2583,3,40,20,0,2582,2581,1,0,0,0,2582,
        2583,1,0,0,0,2583,2584,1,0,0,0,2584,2585,3,488,244,0,2585,2613,1,0,0,0,
        2586,2587,5,50,0,0,2587,2589,5,79,0,0,2588,2590,3,40,20,0,2589,2588,1,
        0,0,0,2589,2590,1,0,0,0,2590,2591,1,0,0,0,2591,2613,3,488,244,0,2592,2593,
        3,54,27,0,2593,2594,5,76,0,0,2594,2595,5,50,0,0,2595,2597,5,79,0,0,2596,
        2598,3,40,20,0,2597,2596,1,0,0,0,2597,2598,1,0,0,0,2598,2599,1,0,0,0,2599,
        2600,3,488,244,0,2600,2613,1,0,0,0,2601,2602,3,14,7,0,2602,2604,5,79,0,
        0,2603,2605,3,40,20,0,2604,2603,1,0,0,0,2604,2605,1,0,0,0,2605,2606,1,
        0,0,0,2606,2607,5,41,0,0,2607,2613,1,0,0,0,2608,2609,3,28,14,0,2609,2610,
        5,79,0,0,2610,2611,5,41,0,0,2611,2613,1,0,0,0,2612,2565,1,0,0,0,2612,2572,
        1,0,0,0,2612,2579,1,0,0,0,2612,2586,1,0,0,0,2612,2592,1,0,0,0,2612,2601,
        1,0,0,0,2612,2608,1,0,0,0,2613,415,1,0,0,0,2614,2616,5,79,0,0,2615,2617,
        3,40,20,0,2616,2615,1,0,0,0,2616,2617,1,0,0,0,2617,2618,1,0,0,0,2618,2619,
        3,488,244,0,2619,417,1,0,0,0,2620,2621,3,58,29,0,2621,2623,5,79,0,0,2622,
        2624,3,40,20,0,2623,2622,1,0,0,0,2623,2624,1,0,0,0,2624,2625,1,0,0,0,2625,
        2626,3,488,244,0,2626,2661,1,0,0,0,2627,2628,3,10,5,0,2628,2630,5,79,0,
        0,2629,2631,3,40,20,0,2630,2629,1,0,0,0,2630,2631,1,0,0,0,2631,2632,1,
        0,0,0,2632,2633,3,488,244,0,2633,2661,1,0,0,0,2634,2635,5,50,0,0,2635,
        2637,5,79,0,0,2636,2638,3,40,20,0,2637,2636,1,0,0,0,2637,2638,1,0,0,0,
        2638,2639,1,0,0,0,2639,2661,3,488,244,0,2640,2641,3,54,27,0,2641,2642,
        5,76,0,0,2642,2643,5,50,0,0,2643,2645,5,79,0,0,2644,2646,3,40,20,0,2645,
        2644,1,0,0,0,2645,2646,1,0,0,0,2646,2647,1,0,0,0,2647,2648,3,488,244,0,
        2648,2661,1,0,0,0,2649,2650,3,14,7,0,2650,2652,5,79,0,0,2651,2653,3,40,
        20,0,2652,2651,1,0,0,0,2652,2653,1,0,0,0,2653,2654,1,0,0,0,2654,2655,5,
        41,0,0,2655,2661,1,0,0,0,2656,2657,3,28,14,0,2657,2658,5,79,0,0,2658,2659,
        5,41,0,0,2659,2661,1,0,0,0,2660,2620,1,0,0,0,2660,2627,1,0,0,0,2660,2634,
        1,0,0,0,2660,2640,1,0,0,0,2660,2649,1,0,0,0,2660,2656,1,0,0,0,2661,419,
        1,0,0,0,2662,2663,5,41,0,0,2663,2664,3,2,1,0,2664,2666,3,422,211,0,2665,
        2667,3,30,15,0,2666,2665,1,0,0,0,2666,2667,1,0,0,0,2667,2685,1,0,0,0,2668,
        2669,5,41,0,0,2669,2670,3,12,6,0,2670,2672,3,422,211,0,2671,2673,3,30,
        15,0,2672,2671,1,0,0,0,2672,2673,1,0,0,0,2673,2685,1,0,0,0,2674,2675,5,
        41,0,0,2675,2676,3,2,1,0,2676,2677,3,30,15,0,2677,2678,3,258,129,0,2678,
        2685,1,0,0,0,2679,2680,5,41,0,0,2680,2681,3,12,6,0,2681,2682,3,30,15,0,
        2682,2683,3,258,129,0,2683,2685,1,0,0,0,2684,2662,1,0,0,0,2684,2668,1,
        0,0,0,2684,2674,1,0,0,0,2684,2679,1,0,0,0,2685,421,1,0,0,0,2686,2688,3,
        424,212,0,2687,2686,1,0,0,0,2688,2689,1,0,0,0,2689,2687,1,0,0,0,2689,2690,
        1,0,0,0,2690,423,1,0,0,0,2691,2693,3,240,120,0,2692,2691,1,0,0,0,2693,
        2696,1,0,0,0,2694,2692,1,0,0,0,2694,2695,1,0,0,0,2695,2697,1,0,0,0,2696,
        2694,1,0,0,0,2697,2698,5,72,0,0,2698,2699,3,428,214,0,2699,2700,5,73,0,
        0,2700,425,1,0,0,0,2701,2702,3,428,214,0,2702,427,1,0,0,0,2703,2706,3,
        430,215,0,2704,2706,3,438,219,0,2705,2703,1,0,0,0,2705,2704,1,0,0,0,2706,
        429,1,0,0,0,2707,2708,3,432,216,0,2708,2709,5,87,0,0,2709,2710,3,436,218,
        0,2710,431,1,0,0,0,2711,2722,3,488,244,0,2712,2714,5,68,0,0,2713,2715,
        3,160,80,0,2714,2713,1,0,0,0,2714,2715,1,0,0,0,2715,2716,1,0,0,0,2716,
        2722,5,69,0,0,2717,2718,5,68,0,0,2718,2719,3,434,217,0,2719,2720,5,69,
        0,0,2720,2722,1,0,0,0,2721,2711,1,0,0,0,2721,2712,1,0,0,0,2721,2717,1,
        0,0,0,2722,433,1,0,0,0,2723,2728,3,488,244,0,2724,2725,5,75,0,0,2725,2727,
        3,488,244,0,2726,2724,1,0,0,0,2727,2730,1,0,0,0,2728,2726,1,0,0,0,2728,
        2729,1,0,0,0,2729,435,1,0,0,0,2730,2728,1,0,0,0,2731,2734,3,428,214,0,
        2732,2734,3,262,131,0,2733,2731,1,0,0,0,2733,2732,1,0,0,0,2734,437,1,0,
        0,0,2735,2738,3,446,223,0,2736,2738,3,440,220,0,2737,2735,1,0,0,0,2737,
        2736,1,0,0,0,2738,439,1,0,0,0,2739,2740,3,442,221,0,2740,2741,3,444,222,
        0,2741,2742,3,428,214,0,2742,441,1,0,0,0,2743,2747,3,58,29,0,2744,2747,
        3,394,197,0,2745,2747,3,400,200,0,2746,2743,1,0,0,0,2746,2744,1,0,0,0,
        2746,2745,1,0,0,0,2747,443,1,0,0,0,2748,2749,7,4,0,0,2749,445,1,0,0,0,
        2750,2760,3,448,224,0,2751,2752,3,448,224,0,2752,2753,5,85,0,0,2753,2754,
        3,428,214,0,2754,2757,5,86,0,0,2755,2758,3,446,223,0,2756,2758,3,430,215,
        0,2757,2755,1,0,0,0,2757,2756,1,0,0,0,2758,2760,1,0,0,0,2759,2750,1,0,
        0,0,2759,2751,1,0,0,0,2760,447,1,0,0,0,2761,2762,6,224,-1,0,2762,2763,
        3,450,225,0,2763,2769,1,0,0,0,2764,2765,10,1,0,0,2765,2766,5,93,0,0,2766,
        2768,3,450,225,0,2767,2764,1,0,0,0,2768,2771,1,0,0,0,2769,2767,1,0,0,0,
        2769,2770,1,0,0,0,2770,449,1,0,0,0,2771,2769,1,0,0,0,2772,2773,6,225,-1,
        0,2773,2774,3,452,226,0,2774,2780,1,0,0,0,2775,2776,10,1,0,0,2776,2777,
        5,92,0,0,2777,2779,3,452,226,0,2778,2775,1,0,0,0,2779,2782,1,0,0,0,2780,
        2778,1,0,0,0,2780,2781,1,0,0,0,2781,451,1,0,0,0,2782,2780,1,0,0,0,2783,
        2784,6,226,-1,0,2784,2785,3,454,227,0,2785,2791,1,0,0,0,2786,2787,10,1,
        0,0,2787,2788,5,101,0,0,2788,2790,3,454,227,0,2789,2786,1,0,0,0,2790,2793,
        1,0,0,0,2791,2789,1,0,0,0,2791,2792,1,0,0,0,2792,453,1,0,0,0,2793,2791,
        1,0,0,0,2794,2795,6,227,-1,0,2795,2796,3,456,228,0,2796,2802,1,0,0,0,2797,
        2798,10,1,0,0,2798,2799,5,102,0,0,2799,2801,3,456,228,0,2800,2797,1,0,
        0,0,2801,2804,1,0,0,0,2802,2800,1,0,0,0,2802,2803,1,0,0,0,2803,455,1,0,
        0,0,2804,2802,1,0,0,0,2805,2806,6,228,-1,0,2806,2807,3,458,229,0,2807,
        2813,1,0,0,0,2808,2809,10,1,0,0,2809,2810,5,100,0,0,2810,2812,3,458,229,
        0,2811,2808,1,0,0,0,2812,2815,1,0,0,0,2813,2811,1,0,0,0,2813,2814,1,0,
        0,0,2814,457,1,0,0,0,2815,2813,1,0,0,0,2816,2817,6,229,-1,0,2817,2818,
        3,460,230,0,2818,2827,1,0,0,0,2819,2820,10,2,0,0,2820,2821,5,88,0,0,2821,
        2826,3,460,230,0,2822,2823,10,1,0,0,2823,2824,5,91,0,0,2824,2826,3,460,
        230,0,2825,2819,1,0,0,0,2825,2822,1,0,0,0,2826,2829,1,0,0,0,2827,2825,
        1,0,0,0,2827,2828,1,0,0,0,2828,459,1,0,0,0,2829,2827,1,0,0,0,2830,2831,
        6,230,-1,0,2831,2832,3,462,231,0,2832,2850,1,0,0,0,2833,2834,10,5,0,0,
        2834,2835,5,82,0,0,2835,2849,3,462,231,0,2836,2837,10,4,0,0,2837,2838,
        5,81,0,0,2838,2849,3,462,231,0,2839,2840,10,3,0,0,2840,2841,5,89,0,0,2841,
        2849,3,462,231,0,2842,2843,10,2,0,0,2843,2844,5,90,0,0,2844,2849,3,462,
        231,0,2845,2846,10,1,0,0,2846,2847,5,36,0,0,2847,2849,3,10,5,0,2848,2833,
        1,0,0,0,2848,2836,1,0,0,0,2848,2839,1,0,0,0,2848,2842,1,0,0,0,2848,2845,
        1,0,0,0,2849,2852,1,0,0,0,2850,2848,1,0,0,0,2850,2851,1,0,0,0,2851,461,
        1,0,0,0,2852,2850,1,0,0,0,2853,2854,6,231,-1,0,2854,2855,3,464,232,0,2855,
        2871,1,0,0,0,2856,2857,10,3,0,0,2857,2858,5,82,0,0,2858,2859,5,82,0,0,
        2859,2870,3,464,232,0,2860,2861,10,2,0,0,2861,2862,5,81,0,0,2862,2863,
        5,81,0,0,2863,2870,3,464,232,0,2864,2865,10,1,0,0,2865,2866,5,81,0,0,2866,
        2867,5,81,0,0,2867,2868,5,81,0,0,2868,2870,3,464,232,0,2869,2856,1,0,0,
        0,2869,2860,1,0,0,0,2869,2864,1,0,0,0,2870,2873,1,0,0,0,2871,2869,1,0,
        0,0,2871,2872,1,0,0,0,2872,463,1,0,0,0,2873,2871,1,0,0,0,2874,2875,6,232,
        -1,0,2875,2876,3,466,233,0,2876,2885,1,0,0,0,2877,2878,10,2,0,0,2878,2879,
        5,96,0,0,2879,2884,3,466,233,0,2880,2881,10,1,0,0,2881,2882,5,97,0,0,2882,
        2884,3,466,233,0,2883,2877,1,0,0,0,2883,2880,1,0,0,0,2884,2887,1,0,0,0,
        2885,2883,1,0,0,0,2885,2886,1,0,0,0,2886,465,1,0,0,0,2887,2885,1,0,0,0,
        2888,2889,6,233,-1,0,2889,2890,3,468,234,0,2890,2902,1,0,0,0,2891,2892,
        10,3,0,0,2892,2893,5,98,0,0,2893,2901,3,468,234,0,2894,2895,10,2,0,0,2895,
        2896,5,99,0,0,2896,2901,3,468,234,0,2897,2898,10,1,0,0,2898,2899,5,103,
        0,0,2899,2901,3,468,234,0,2900,2891,1,0,0,0,2900,2894,1,0,0,0,2900,2897,
        1,0,0,0,2901,2904,1,0,0,0,2902,2900,1,0,0,0,2902,2903,1,0,0,0,2903,467,
        1,0,0,0,2904,2902,1,0,0,0,2905,2913,3,470,235,0,2906,2913,3,472,236,0,
        2907,2908,5,96,0,0,2908,2913,3,468,234,0,2909,2910,5,97,0,0,2910,2913,
        3,468,234,0,2911,2913,3,474,237,0,2912,2905,1,0,0,0,2912,2906,1,0,0,0,
        2912,2907,1,0,0,0,2912,2909,1,0,0,0,2912,2911,1,0,0,0,2913,469,1,0,0,0,
        2914,2915,5,94,0,0,2915,2916,3,468,234,0,2916,471,1,0,0,0,2917,2918,5,
        95,0,0,2918,2919,3,468,234,0,2919,473,1,0,0,0,2920,2927,3,476,238,0,2921,
        2922,5,84,0,0,2922,2927,3,468,234,0,2923,2924,5,83,0,0,2924,2927,3,468,
        234,0,2925,2927,3,486,243,0,2926,2920,1,0,0,0,2926,2921,1,0,0,0,2926,2923,
        1,0,0,0,2926,2925,1,0,0,0,2927,475,1,0,0,0,2928,2931,3,364,182,0,2929,
        2931,3,58,29,0,2930,2928,1,0,0,0,2930,2929,1,0,0,0,2931,2936,1,0,0,0,2932,
        2935,3,480,240,0,2933,2935,3,484,242,0,2934,2932,1,0,0,0,2934,2933,1,0,
        0,0,2935,2938,1,0,0,0,2936,2934,1,0,0,0,2936,2937,1,0,0,0,2937,477,1,0,
        0,0,2938,2936,1,0,0,0,2939,2940,3,476,238,0,2940,2941,5,94,0,0,2941,479,
        1,0,0,0,2942,2943,5,94,0,0,2943,481,1,0,0,0,2944,2945,3,476,238,0,2945,
        2946,5,95,0,0,2946,483,1,0,0,0,2947,2948,5,95,0,0,2948,485,1,0,0,0,2949,
        2950,5,68,0,0,2950,2951,3,2,1,0,2951,2952,5,69,0,0,2952,2953,3,468,234,
        0,2953,2977,1,0,0,0,2954,2955,5,68,0,0,2955,2959,3,10,5,0,2956,2958,3,
        38,19,0,2957,2956,1,0,0,0,2958,2961,1,0,0,0,2959,2957,1,0,0,0,2959,2960,
        1,0,0,0,2960,2962,1,0,0,0,2961,2959,1,0,0,0,2962,2963,5,69,0,0,2963,2964,
        3,474,237,0,2964,2977,1,0,0,0,2965,2966,5,68,0,0,2966,2970,3,10,5,0,2967,
        2969,3,38,19,0,2968,2967,1,0,0,0,2969,2972,1,0,0,0,2970,2968,1,0,0,0,2970,
        2971,1,0,0,0,2971,2973,1,0,0,0,2972,2970,1,0,0,0,2973,2974,5,69,0,0,2974,
        2975,3,430,215,0,2975,2977,1,0,0,0,2976,2949,1,0,0,0,2976,2954,1,0,0,0,
        2976,2965,1,0,0,0,2977,487,1,0,0,0,2978,2979,7,5,0,0,2979,489,1,0,0,0,
        340,495,502,506,510,519,523,527,529,535,540,547,552,554,560,565,570,575,
        586,600,605,613,620,626,631,642,645,659,664,669,674,680,690,701,709,719,
        727,739,744,747,752,758,766,774,787,816,821,825,833,842,856,859,871,874,
        890,895,901,906,912,915,918,930,941,955,962,971,978,983,998,1005,1011,
        1015,1019,1023,1027,1032,1036,1040,1042,1047,1054,1059,1061,1067,1072,
        1076,1095,1100,1116,1121,1127,1133,1135,1139,1144,1148,1156,1163,1171,
        1174,1179,1187,1192,1199,1206,1211,1218,1230,1235,1239,1249,1254,1262,
        1265,1270,1278,1281,1286,1291,1296,1301,1308,1313,1321,1326,1331,1336,
        1342,1348,1351,1354,1363,1369,1375,1378,1381,1389,1394,1399,1405,1408,
        1419,1428,1438,1443,1454,1459,1472,1477,1489,1499,1504,1512,1515,1522,
        1530,1536,1545,1555,1559,1562,1571,1585,1588,1597,1602,1609,1614,1622,
        1634,1641,1655,1677,1711,1723,1729,1740,1752,1778,1782,1787,1791,1795,
        1803,1807,1811,1818,1827,1835,1850,1862,1868,1874,1895,1900,1905,1916,
        1927,1937,1940,1945,1954,1960,1969,1973,1977,1982,2001,2011,2033,2040,
        2048,2056,2067,2090,2100,2111,2133,2138,2144,2152,2156,2161,2169,2175,
        2179,2183,2187,2193,2198,2203,2207,2211,2217,2222,2227,2231,2235,2237,
        2242,2247,2252,2256,2260,2264,2269,2277,2283,2287,2291,2295,2301,2306,
        2311,2315,2319,2321,2326,2341,2355,2367,2376,2391,2404,2413,2419,2426,
        2431,2438,2443,2450,2455,2462,2467,2476,2481,2485,2489,2494,2501,2508,
        2513,2520,2525,2532,2537,2546,2551,2555,2562,2568,2575,2582,2589,2597,
        2604,2612,2616,2623,2630,2637,2645,2652,2660,2666,2672,2684,2689,2694,
        2705,2714,2721,2728,2733,2737,2746,2757,2759,2769,2780,2791,2802,2813,
        2825,2827,2848,2850,2869,2871,2883,2885,2900,2902,2912,2926,2930,2934,
        2936,2959,2970,2976
    };

    public static readonly ATN _ATN =
        new ATNDeserializer().Deserialize(_serializedATN);


}
