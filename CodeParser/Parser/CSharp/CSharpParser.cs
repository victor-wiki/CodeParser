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
public partial class CSharpParser : CSharpParserBase {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		BYTE_ORDER_MARK=1, SINGLE_LINE_DOC_COMMENT=2, EMPTY_DELIMITED_DOC_COMMENT=3, 
		DELIMITED_DOC_COMMENT=4, SINGLE_LINE_COMMENT=5, DELIMITED_COMMENT=6, WHITESPACES=7, 
		SHARP=8, ABSTRACT=9, ADD=10, ALIAS=11, ARGLIST=12, AS=13, ASCENDING=14, 
		ASYNC=15, AWAIT=16, BASE=17, BOOL=18, BREAK=19, BY=20, BYTE=21, CASE=22, 
		CATCH=23, CHAR=24, CHECKED=25, CLASS=26, CONST=27, CONTINUE=28, DECIMAL=29, 
		DEFAULT=30, DELEGATE=31, DESCENDING=32, DO=33, DOUBLE=34, DYNAMIC=35, 
		ELSE=36, ENUM=37, EQUALS=38, EVENT=39, EXPLICIT=40, EXTERN=41, FALSE=42, 
		FINALLY=43, FIXED=44, FLOAT=45, FOR=46, FOREACH=47, FROM=48, GET=49, GOTO=50, 
		GROUP=51, IF=52, IMPLICIT=53, IN=54, INT=55, INTERFACE=56, INTERNAL=57, 
		INTO=58, IS=59, JOIN=60, LET=61, LOCK=62, LONG=63, NAMEOF=64, NAMESPACE=65, 
		NEW=66, NULL_=67, OBJECT=68, ON=69, OPERATOR=70, ORDERBY=71, OUT=72, OVERRIDE=73, 
		PARAMS=74, PARTIAL=75, PRIVATE=76, PROTECTED=77, PUBLIC=78, READONLY=79, 
		REF=80, REMOVE=81, RETURN=82, SBYTE=83, SEALED=84, SELECT=85, SET=86, 
		SHORT=87, SIZEOF=88, STACKALLOC=89, STATIC=90, STRING=91, STRUCT=92, SWITCH=93, 
		THIS=94, THROW=95, TRUE=96, TRY=97, TYPEOF=98, UINT=99, ULONG=100, UNCHECKED=101, 
		UNMANAGED=102, UNSAFE=103, USHORT=104, USING=105, VAR=106, VIRTUAL=107, 
		VOID=108, VOLATILE=109, WHEN=110, WHERE=111, WHILE=112, YIELD=113, IDENTIFIER=114, 
		LITERAL_ACCESS=115, INTEGER_LITERAL=116, HEX_INTEGER_LITERAL=117, BIN_INTEGER_LITERAL=118, 
		REAL_LITERAL=119, CHARACTER_LITERAL=120, REGULAR_STRING=121, VERBATIUM_STRING=122, 
		INTERPOLATED_REGULAR_STRING_START=123, INTERPOLATED_VERBATIUM_STRING_START=124, 
		OPEN_BRACE=125, CLOSE_BRACE=126, OPEN_BRACKET=127, CLOSE_BRACKET=128, 
		OPEN_PARENS=129, CLOSE_PARENS=130, DOT=131, COMMA=132, COLON=133, SEMICOLON=134, 
		PLUS=135, MINUS=136, STAR=137, DIV=138, PERCENT=139, AMP=140, BITWISE_OR=141, 
		CARET=142, BANG=143, TILDE=144, ASSIGNMENT=145, LT=146, GT=147, INTERR=148, 
		DOUBLE_COLON=149, OP_COALESCING=150, OP_INC=151, OP_DEC=152, OP_AND=153, 
		OP_OR=154, OP_PTR=155, OP_EQ=156, OP_NE=157, OP_LE=158, OP_GE=159, OP_ADD_ASSIGNMENT=160, 
		OP_SUB_ASSIGNMENT=161, OP_MULT_ASSIGNMENT=162, OP_DIV_ASSIGNMENT=163, 
		OP_MOD_ASSIGNMENT=164, OP_AND_ASSIGNMENT=165, OP_OR_ASSIGNMENT=166, OP_XOR_ASSIGNMENT=167, 
		OP_LEFT_SHIFT=168, OP_LEFT_SHIFT_ASSIGNMENT=169, OP_COALESCING_ASSIGNMENT=170, 
		OP_RANGE=171, DOUBLE_CURLY_INSIDE=172, OPEN_BRACE_INSIDE=173, REGULAR_CHAR_INSIDE=174, 
		VERBATIUM_DOUBLE_QUOTE_INSIDE=175, DOUBLE_QUOTE_INSIDE=176, REGULAR_STRING_INSIDE=177, 
		VERBATIUM_INSIDE_STRING=178, CLOSE_BRACE_INSIDE=179, FORMAT_STRING=180, 
		DIRECTIVE_WHITESPACES=181, DIGITS=182, DEFINE=183, UNDEF=184, ELIF=185, 
		ENDIF=186, LINE=187, ERROR=188, WARNING=189, REGION=190, ENDREGION=191, 
		PRAGMA=192, NULLABLE=193, DIRECTIVE_HIDDEN=194, CONDITIONAL_SYMBOL=195, 
		DIRECTIVE_NEW_LINE=196, TEXT=197, DOUBLE_CURLY_CLOSE_INSIDE=198;
	public const int
		RULE_compilation_unit = 0, RULE_namespace_or_type_name = 1, RULE_type_ = 2, 
		RULE_base_type = 3, RULE_tuple_type = 4, RULE_tuple_element = 5, RULE_simple_type = 6, 
		RULE_numeric_type = 7, RULE_integral_type = 8, RULE_floating_point_type = 9, 
		RULE_class_type = 10, RULE_type_argument_list = 11, RULE_argument_list = 12, 
		RULE_argument = 13, RULE_expression = 14, RULE_non_assignment_expression = 15, 
		RULE_assignment = 16, RULE_assignment_operator = 17, RULE_conditional_expression = 18, 
		RULE_null_coalescing_expression = 19, RULE_conditional_or_expression = 20, 
		RULE_conditional_and_expression = 21, RULE_inclusive_or_expression = 22, 
		RULE_exclusive_or_expression = 23, RULE_and_expression = 24, RULE_equality_expression = 25, 
		RULE_relational_expression = 26, RULE_shift_expression = 27, RULE_additive_expression = 28, 
		RULE_multiplicative_expression = 29, RULE_switch_expression = 30, RULE_switch_expression_arms = 31, 
		RULE_switch_expression_arm = 32, RULE_range_expression = 33, RULE_unary_expression = 34, 
		RULE_primary_expression = 35, RULE_primary_expression_start = 36, RULE_throwable_expression = 37, 
		RULE_throw_expression = 38, RULE_member_access = 39, RULE_bracket_expression = 40, 
		RULE_indexer_argument = 41, RULE_predefined_type = 42, RULE_expression_list = 43, 
		RULE_object_or_collection_initializer = 44, RULE_object_initializer = 45, 
		RULE_member_initializer_list = 46, RULE_member_initializer = 47, RULE_initializer_value = 48, 
		RULE_collection_initializer = 49, RULE_element_initializer = 50, RULE_anonymous_object_initializer = 51, 
		RULE_member_declarator_list = 52, RULE_member_declarator = 53, RULE_unbound_type_name = 54, 
		RULE_generic_dimension_specifier = 55, RULE_isType = 56, RULE_isTypePatternArms = 57, 
		RULE_isTypePatternArm = 58, RULE_lambda_expression = 59, RULE_anonymous_function_signature = 60, 
		RULE_explicit_anonymous_function_parameter_list = 61, RULE_explicit_anonymous_function_parameter = 62, 
		RULE_implicit_anonymous_function_parameter_list = 63, RULE_anonymous_function_body = 64, 
		RULE_query_expression = 65, RULE_from_clause = 66, RULE_query_body = 67, 
		RULE_query_body_clause = 68, RULE_let_clause = 69, RULE_where_clause = 70, 
		RULE_combined_join_clause = 71, RULE_orderby_clause = 72, RULE_ordering = 73, 
		RULE_select_or_group_clause = 74, RULE_query_continuation = 75, RULE_statement = 76, 
		RULE_declarationStatement = 77, RULE_local_function_declaration = 78, 
		RULE_local_function_header = 79, RULE_local_function_modifiers = 80, RULE_local_function_body = 81, 
		RULE_labeled_Statement = 82, RULE_embedded_statement = 83, RULE_simple_embedded_statement = 84, 
		RULE_block = 85, RULE_local_variable_declaration = 86, RULE_local_variable_type = 87, 
		RULE_local_variable_declarator = 88, RULE_local_variable_initializer = 89, 
		RULE_local_constant_declaration = 90, RULE_if_body = 91, RULE_switch_section = 92, 
		RULE_switch_label = 93, RULE_case_guard = 94, RULE_statement_list = 95, 
		RULE_for_initializer = 96, RULE_for_iterator = 97, RULE_catch_clauses = 98, 
		RULE_specific_catch_clause = 99, RULE_general_catch_clause = 100, RULE_exception_filter = 101, 
		RULE_finally_clause = 102, RULE_resource_acquisition = 103, RULE_namespace_declaration = 104, 
		RULE_qualified_identifier = 105, RULE_namespace_body = 106, RULE_extern_alias_directives = 107, 
		RULE_extern_alias_directive = 108, RULE_using_directives = 109, RULE_using_directive = 110, 
		RULE_namespace_member_declarations = 111, RULE_namespace_member_declaration = 112, 
		RULE_type_declaration = 113, RULE_qualified_alias_member = 114, RULE_type_parameter_list = 115, 
		RULE_type_parameter = 116, RULE_class_base = 117, RULE_interface_type_list = 118, 
		RULE_type_parameter_constraints_clauses = 119, RULE_type_parameter_constraints_clause = 120, 
		RULE_type_parameter_constraints = 121, RULE_primary_constraint = 122, 
		RULE_secondary_constraints = 123, RULE_constructor_constraint = 124, RULE_class_body = 125, 
		RULE_class_member_declarations = 126, RULE_class_member_declaration = 127, 
		RULE_all_member_modifiers = 128, RULE_all_member_modifier = 129, RULE_common_member_declaration = 130, 
		RULE_typed_member_declaration = 131, RULE_constant_declarators = 132, 
		RULE_constant_declarator = 133, RULE_variable_declarators = 134, RULE_variable_declarator = 135, 
		RULE_variable_initializer = 136, RULE_return_type = 137, RULE_member_name = 138, 
		RULE_method_body = 139, RULE_formal_parameter_list = 140, RULE_fixed_parameters = 141, 
		RULE_fixed_parameter = 142, RULE_parameter_modifier = 143, RULE_parameter_array = 144, 
		RULE_accessor_declarations = 145, RULE_get_accessor_declaration = 146, 
		RULE_set_accessor_declaration = 147, RULE_accessor_modifier = 148, RULE_accessor_body = 149, 
		RULE_event_accessor_declarations = 150, RULE_add_accessor_declaration = 151, 
		RULE_remove_accessor_declaration = 152, RULE_overloadable_operator = 153, 
		RULE_conversion_operator_declarator = 154, RULE_constructor_initializer = 155, 
		RULE_body = 156, RULE_struct_interfaces = 157, RULE_struct_body = 158, 
		RULE_struct_member_declaration = 159, RULE_array_type = 160, RULE_rank_specifier = 161, 
		RULE_array_initializer = 162, RULE_variant_type_parameter_list = 163, 
		RULE_variant_type_parameter = 164, RULE_variance_annotation = 165, RULE_interface_base = 166, 
		RULE_interface_body = 167, RULE_interface_member_declaration = 168, RULE_interface_accessors = 169, 
		RULE_enum_base = 170, RULE_enum_body = 171, RULE_enum_member_declaration = 172, 
		RULE_global_attribute_section = 173, RULE_global_attribute_target = 174, 
		RULE_attributes = 175, RULE_attribute_section = 176, RULE_attribute_target = 177, 
		RULE_attribute_list = 178, RULE_attribute = 179, RULE_attribute_argument = 180, 
		RULE_pointer_type = 181, RULE_fixed_pointer_declarators = 182, RULE_fixed_pointer_declarator = 183, 
		RULE_fixed_pointer_initializer = 184, RULE_fixed_size_buffer_declarator = 185, 
		RULE_stackalloc_initializer = 186, RULE_right_arrow = 187, RULE_right_shift = 188, 
		RULE_right_shift_assignment = 189, RULE_literal = 190, RULE_boolean_literal = 191, 
		RULE_string_literal = 192, RULE_interpolated_regular_string = 193, RULE_interpolated_verbatium_string = 194, 
		RULE_interpolated_regular_string_part = 195, RULE_interpolated_verbatium_string_part = 196, 
		RULE_interpolated_string_expression = 197, RULE_keyword = 198, RULE_class_definition = 199, 
		RULE_struct_definition = 200, RULE_interface_definition = 201, RULE_enum_definition = 202, 
		RULE_delegate_definition = 203, RULE_event_declaration = 204, RULE_field_declaration = 205, 
		RULE_property_declaration = 206, RULE_constant_declaration = 207, RULE_indexer_declaration = 208, 
		RULE_destructor_definition = 209, RULE_constructor_declaration = 210, 
		RULE_method_declaration = 211, RULE_method_member_name = 212, RULE_operator_declaration = 213, 
		RULE_arg_declaration = 214, RULE_method_invocation = 215, RULE_object_creation_expression = 216, 
		RULE_identifier = 217;
	public static readonly string[] ruleNames = {
		"compilation_unit", "namespace_or_type_name", "type_", "base_type", "tuple_type", 
		"tuple_element", "simple_type", "numeric_type", "integral_type", "floating_point_type", 
		"class_type", "type_argument_list", "argument_list", "argument", "expression", 
		"non_assignment_expression", "assignment", "assignment_operator", "conditional_expression", 
		"null_coalescing_expression", "conditional_or_expression", "conditional_and_expression", 
		"inclusive_or_expression", "exclusive_or_expression", "and_expression", 
		"equality_expression", "relational_expression", "shift_expression", "additive_expression", 
		"multiplicative_expression", "switch_expression", "switch_expression_arms", 
		"switch_expression_arm", "range_expression", "unary_expression", "primary_expression", 
		"primary_expression_start", "throwable_expression", "throw_expression", 
		"member_access", "bracket_expression", "indexer_argument", "predefined_type", 
		"expression_list", "object_or_collection_initializer", "object_initializer", 
		"member_initializer_list", "member_initializer", "initializer_value", 
		"collection_initializer", "element_initializer", "anonymous_object_initializer", 
		"member_declarator_list", "member_declarator", "unbound_type_name", "generic_dimension_specifier", 
		"isType", "isTypePatternArms", "isTypePatternArm", "lambda_expression", 
		"anonymous_function_signature", "explicit_anonymous_function_parameter_list", 
		"explicit_anonymous_function_parameter", "implicit_anonymous_function_parameter_list", 
		"anonymous_function_body", "query_expression", "from_clause", "query_body", 
		"query_body_clause", "let_clause", "where_clause", "combined_join_clause", 
		"orderby_clause", "ordering", "select_or_group_clause", "query_continuation", 
		"statement", "declarationStatement", "local_function_declaration", "local_function_header", 
		"local_function_modifiers", "local_function_body", "labeled_Statement", 
		"embedded_statement", "simple_embedded_statement", "block", "local_variable_declaration", 
		"local_variable_type", "local_variable_declarator", "local_variable_initializer", 
		"local_constant_declaration", "if_body", "switch_section", "switch_label", 
		"case_guard", "statement_list", "for_initializer", "for_iterator", "catch_clauses", 
		"specific_catch_clause", "general_catch_clause", "exception_filter", "finally_clause", 
		"resource_acquisition", "namespace_declaration", "qualified_identifier", 
		"namespace_body", "extern_alias_directives", "extern_alias_directive", 
		"using_directives", "using_directive", "namespace_member_declarations", 
		"namespace_member_declaration", "type_declaration", "qualified_alias_member", 
		"type_parameter_list", "type_parameter", "class_base", "interface_type_list", 
		"type_parameter_constraints_clauses", "type_parameter_constraints_clause", 
		"type_parameter_constraints", "primary_constraint", "secondary_constraints", 
		"constructor_constraint", "class_body", "class_member_declarations", "class_member_declaration", 
		"all_member_modifiers", "all_member_modifier", "common_member_declaration", 
		"typed_member_declaration", "constant_declarators", "constant_declarator", 
		"variable_declarators", "variable_declarator", "variable_initializer", 
		"return_type", "member_name", "method_body", "formal_parameter_list", 
		"fixed_parameters", "fixed_parameter", "parameter_modifier", "parameter_array", 
		"accessor_declarations", "get_accessor_declaration", "set_accessor_declaration", 
		"accessor_modifier", "accessor_body", "event_accessor_declarations", "add_accessor_declaration", 
		"remove_accessor_declaration", "overloadable_operator", "conversion_operator_declarator", 
		"constructor_initializer", "body", "struct_interfaces", "struct_body", 
		"struct_member_declaration", "array_type", "rank_specifier", "array_initializer", 
		"variant_type_parameter_list", "variant_type_parameter", "variance_annotation", 
		"interface_base", "interface_body", "interface_member_declaration", "interface_accessors", 
		"enum_base", "enum_body", "enum_member_declaration", "global_attribute_section", 
		"global_attribute_target", "attributes", "attribute_section", "attribute_target", 
		"attribute_list", "attribute", "attribute_argument", "pointer_type", "fixed_pointer_declarators", 
		"fixed_pointer_declarator", "fixed_pointer_initializer", "fixed_size_buffer_declarator", 
		"stackalloc_initializer", "right_arrow", "right_shift", "right_shift_assignment", 
		"literal", "boolean_literal", "string_literal", "interpolated_regular_string", 
		"interpolated_verbatium_string", "interpolated_regular_string_part", "interpolated_verbatium_string_part", 
		"interpolated_string_expression", "keyword", "class_definition", "struct_definition", 
		"interface_definition", "enum_definition", "delegate_definition", "event_declaration", 
		"field_declaration", "property_declaration", "constant_declaration", "indexer_declaration", 
		"destructor_definition", "constructor_declaration", "method_declaration", 
		"method_member_name", "operator_declaration", "arg_declaration", "method_invocation", 
		"object_creation_expression", "identifier"
	};

	private static readonly string[] _LiteralNames = {
		null, "'\\u00EF\\u00BB\\u00BF'", null, "'/***/'", null, null, null, null, 
		"'#'", "'abstract'", "'add'", "'alias'", "'__arglist'", "'as'", "'ascending'", 
		"'async'", "'await'", "'base'", "'bool'", "'break'", "'by'", "'byte'", 
		"'case'", "'catch'", "'char'", "'checked'", "'class'", "'const'", "'continue'", 
		"'decimal'", "'default'", "'delegate'", "'descending'", "'do'", "'double'", 
		"'dynamic'", "'else'", "'enum'", "'equals'", "'event'", "'explicit'", 
		"'extern'", "'false'", "'finally'", "'fixed'", "'float'", "'for'", "'foreach'", 
		"'from'", "'get'", "'goto'", "'group'", "'if'", "'implicit'", "'in'", 
		"'int'", "'interface'", "'internal'", "'into'", "'is'", "'join'", "'let'", 
		"'lock'", "'long'", "'nameof'", "'namespace'", "'new'", "'null'", "'object'", 
		"'on'", "'operator'", "'orderby'", "'out'", "'override'", "'params'", 
		"'partial'", "'private'", "'protected'", "'public'", "'readonly'", "'ref'", 
		"'remove'", "'return'", "'sbyte'", "'sealed'", "'select'", "'set'", "'short'", 
		"'sizeof'", "'stackalloc'", "'static'", "'string'", "'struct'", "'switch'", 
		"'this'", "'throw'", "'true'", "'try'", "'typeof'", "'uint'", "'ulong'", 
		"'unchecked'", "'unmanaged'", "'unsafe'", "'ushort'", "'using'", "'var'", 
		"'virtual'", "'void'", "'volatile'", "'when'", "'where'", "'while'", "'yield'", 
		null, null, null, null, null, null, null, null, null, null, null, "'{'", 
		"'}'", "'['", "']'", "'('", "')'", "'.'", "','", "':'", "';'", "'+'", 
		"'-'", "'*'", "'/'", "'%'", "'&'", "'|'", "'^'", "'!'", "'~'", "'='", 
		"'<'", "'>'", "'?'", "'::'", "'??'", "'++'", "'--'", "'&&'", "'||'", "'->'", 
		"'=='", "'!='", "'<='", "'>='", "'+='", "'-='", "'*='", "'/='", "'%='", 
		"'&='", "'|='", "'^='", "'<<'", "'<<='", "'??='", "'..'", "'{{'", null, 
		null, null, null, null, null, null, null, null, null, "'define'", "'undef'", 
		"'elif'", "'endif'", "'line'", null, null, null, null, null, null, "'hidden'", 
		null, null, null, "'}}'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "BYTE_ORDER_MARK", "SINGLE_LINE_DOC_COMMENT", "EMPTY_DELIMITED_DOC_COMMENT", 
		"DELIMITED_DOC_COMMENT", "SINGLE_LINE_COMMENT", "DELIMITED_COMMENT", "WHITESPACES", 
		"SHARP", "ABSTRACT", "ADD", "ALIAS", "ARGLIST", "AS", "ASCENDING", "ASYNC", 
		"AWAIT", "BASE", "BOOL", "BREAK", "BY", "BYTE", "CASE", "CATCH", "CHAR", 
		"CHECKED", "CLASS", "CONST", "CONTINUE", "DECIMAL", "DEFAULT", "DELEGATE", 
		"DESCENDING", "DO", "DOUBLE", "DYNAMIC", "ELSE", "ENUM", "EQUALS", "EVENT", 
		"EXPLICIT", "EXTERN", "FALSE", "FINALLY", "FIXED", "FLOAT", "FOR", "FOREACH", 
		"FROM", "GET", "GOTO", "GROUP", "IF", "IMPLICIT", "IN", "INT", "INTERFACE", 
		"INTERNAL", "INTO", "IS", "JOIN", "LET", "LOCK", "LONG", "NAMEOF", "NAMESPACE", 
		"NEW", "NULL_", "OBJECT", "ON", "OPERATOR", "ORDERBY", "OUT", "OVERRIDE", 
		"PARAMS", "PARTIAL", "PRIVATE", "PROTECTED", "PUBLIC", "READONLY", "REF", 
		"REMOVE", "RETURN", "SBYTE", "SEALED", "SELECT", "SET", "SHORT", "SIZEOF", 
		"STACKALLOC", "STATIC", "STRING", "STRUCT", "SWITCH", "THIS", "THROW", 
		"TRUE", "TRY", "TYPEOF", "UINT", "ULONG", "UNCHECKED", "UNMANAGED", "UNSAFE", 
		"USHORT", "USING", "VAR", "VIRTUAL", "VOID", "VOLATILE", "WHEN", "WHERE", 
		"WHILE", "YIELD", "IDENTIFIER", "LITERAL_ACCESS", "INTEGER_LITERAL", "HEX_INTEGER_LITERAL", 
		"BIN_INTEGER_LITERAL", "REAL_LITERAL", "CHARACTER_LITERAL", "REGULAR_STRING", 
		"VERBATIUM_STRING", "INTERPOLATED_REGULAR_STRING_START", "INTERPOLATED_VERBATIUM_STRING_START", 
		"OPEN_BRACE", "CLOSE_BRACE", "OPEN_BRACKET", "CLOSE_BRACKET", "OPEN_PARENS", 
		"CLOSE_PARENS", "DOT", "COMMA", "COLON", "SEMICOLON", "PLUS", "MINUS", 
		"STAR", "DIV", "PERCENT", "AMP", "BITWISE_OR", "CARET", "BANG", "TILDE", 
		"ASSIGNMENT", "LT", "GT", "INTERR", "DOUBLE_COLON", "OP_COALESCING", "OP_INC", 
		"OP_DEC", "OP_AND", "OP_OR", "OP_PTR", "OP_EQ", "OP_NE", "OP_LE", "OP_GE", 
		"OP_ADD_ASSIGNMENT", "OP_SUB_ASSIGNMENT", "OP_MULT_ASSIGNMENT", "OP_DIV_ASSIGNMENT", 
		"OP_MOD_ASSIGNMENT", "OP_AND_ASSIGNMENT", "OP_OR_ASSIGNMENT", "OP_XOR_ASSIGNMENT", 
		"OP_LEFT_SHIFT", "OP_LEFT_SHIFT_ASSIGNMENT", "OP_COALESCING_ASSIGNMENT", 
		"OP_RANGE", "DOUBLE_CURLY_INSIDE", "OPEN_BRACE_INSIDE", "REGULAR_CHAR_INSIDE", 
		"VERBATIUM_DOUBLE_QUOTE_INSIDE", "DOUBLE_QUOTE_INSIDE", "REGULAR_STRING_INSIDE", 
		"VERBATIUM_INSIDE_STRING", "CLOSE_BRACE_INSIDE", "FORMAT_STRING", "DIRECTIVE_WHITESPACES", 
		"DIGITS", "DEFINE", "UNDEF", "ELIF", "ENDIF", "LINE", "ERROR", "WARNING", 
		"REGION", "ENDREGION", "PRAGMA", "NULLABLE", "DIRECTIVE_HIDDEN", "CONDITIONAL_SYMBOL", 
		"DIRECTIVE_NEW_LINE", "TEXT", "DOUBLE_CURLY_CLOSE_INSIDE"
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

	public override string GrammarFileName { get { return "CSharpParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static CSharpParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public CSharpParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public CSharpParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class Compilation_unitContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(CSharpParser.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BYTE_ORDER_MARK() { return GetToken(CSharpParser.BYTE_ORDER_MARK, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Extern_alias_directivesContext extern_alias_directives() {
			return GetRuleContext<Extern_alias_directivesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Using_directivesContext using_directives() {
			return GetRuleContext<Using_directivesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Global_attribute_sectionContext[] global_attribute_section() {
			return GetRuleContexts<Global_attribute_sectionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Global_attribute_sectionContext global_attribute_section(int i) {
			return GetRuleContext<Global_attribute_sectionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_member_declarationsContext namespace_member_declarations() {
			return GetRuleContext<Namespace_member_declarationsContext>(0);
		}
		public Compilation_unitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compilation_unit; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterCompilation_unit(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitCompilation_unit(this);
		}
	}

	[RuleVersion(0)]
	public Compilation_unitContext compilation_unit() {
		Compilation_unitContext _localctx = new Compilation_unitContext(Context, State);
		EnterRule(_localctx, 0, RULE_compilation_unit);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 437;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==BYTE_ORDER_MARK) {
				{
				State = 436;
				Match(BYTE_ORDER_MARK);
				}
			}

			State = 440;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				{
				State = 439;
				extern_alias_directives();
				}
				break;
			}
			State = 443;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==USING) {
				{
				State = 442;
				using_directives();
				}
			}

			State = 448;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,3,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 445;
					global_attribute_section();
					}
					} 
				}
				State = 450;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,3,Context);
			}
			State = 452;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << ASYNC) | (1L << CLASS) | (1L << DELEGATE) | (1L << ENUM) | (1L << EXTERN) | (1L << INTERFACE) | (1L << INTERNAL))) != 0) || ((((_la - 65)) & ~0x3f) == 0 && ((1L << (_la - 65)) & ((1L << (NAMESPACE - 65)) | (1L << (NEW - 65)) | (1L << (OVERRIDE - 65)) | (1L << (PARTIAL - 65)) | (1L << (PRIVATE - 65)) | (1L << (PROTECTED - 65)) | (1L << (PUBLIC - 65)) | (1L << (READONLY - 65)) | (1L << (REF - 65)) | (1L << (SEALED - 65)) | (1L << (STATIC - 65)) | (1L << (STRUCT - 65)) | (1L << (UNSAFE - 65)) | (1L << (VIRTUAL - 65)) | (1L << (VOLATILE - 65)) | (1L << (OPEN_BRACKET - 65)))) != 0)) {
				{
				State = 451;
				namespace_member_declarations();
				}
			}

			State = 454;
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

	public partial class Namespace_or_type_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Qualified_alias_memberContext qualified_alias_member() {
			return GetRuleContext<Qualified_alias_memberContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DOT() { return GetTokens(CSharpParser.DOT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT(int i) {
			return GetToken(CSharpParser.DOT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_argument_listContext[] type_argument_list() {
			return GetRuleContexts<Type_argument_listContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_argument_listContext type_argument_list(int i) {
			return GetRuleContext<Type_argument_listContext>(i);
		}
		public Namespace_or_type_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namespace_or_type_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterNamespace_or_type_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitNamespace_or_type_name(this);
		}
	}

	[RuleVersion(0)]
	public Namespace_or_type_nameContext namespace_or_type_name() {
		Namespace_or_type_nameContext _localctx = new Namespace_or_type_nameContext(Context, State);
		EnterRule(_localctx, 2, RULE_namespace_or_type_name);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 461;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,6,Context) ) {
			case 1:
				{
				State = 456;
				identifier();
				State = 458;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,5,Context) ) {
				case 1:
					{
					State = 457;
					type_argument_list();
					}
					break;
				}
				}
				break;
			case 2:
				{
				State = 460;
				qualified_alias_member();
				}
				break;
			}
			State = 470;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,8,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 463;
					Match(DOT);
					State = 464;
					identifier();
					State = 466;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,7,Context) ) {
					case 1:
						{
						State = 465;
						type_argument_list();
						}
						break;
					}
					}
					} 
				}
				State = 472;
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
			ExitRule();
		}
		return _localctx;
	}

	public partial class Type_Context : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Base_typeContext base_type() {
			return GetRuleContext<Base_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] INTERR() { return GetTokens(CSharpParser.INTERR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERR(int i) {
			return GetToken(CSharpParser.INTERR, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Rank_specifierContext[] rank_specifier() {
			return GetRuleContexts<Rank_specifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Rank_specifierContext rank_specifier(int i) {
			return GetRuleContext<Rank_specifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] STAR() { return GetTokens(CSharpParser.STAR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STAR(int i) {
			return GetToken(CSharpParser.STAR, i);
		}
		public Type_Context(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_type_; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterType_(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitType_(this);
		}
	}

	[RuleVersion(0)]
	public Type_Context type_() {
		Type_Context _localctx = new Type_Context(Context, State);
		EnterRule(_localctx, 4, RULE_type_);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 473;
			base_type();
			State = 479;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,10,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					State = 477;
					ErrorHandler.Sync(this);
					switch (TokenStream.LA(1)) {
					case INTERR:
						{
						State = 474;
						Match(INTERR);
						}
						break;
					case OPEN_BRACKET:
						{
						State = 475;
						rank_specifier();
						}
						break;
					case STAR:
						{
						State = 476;
						Match(STAR);
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					} 
				}
				State = 481;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,10,Context);
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

	public partial class Base_typeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Simple_typeContext simple_type() {
			return GetRuleContext<Simple_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Class_typeContext class_type() {
			return GetRuleContext<Class_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOID() { return GetToken(CSharpParser.VOID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STAR() { return GetToken(CSharpParser.STAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Tuple_typeContext tuple_type() {
			return GetRuleContext<Tuple_typeContext>(0);
		}
		public Base_typeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_base_type; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterBase_type(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitBase_type(this);
		}
	}

	[RuleVersion(0)]
	public Base_typeContext base_type() {
		Base_typeContext _localctx = new Base_typeContext(Context, State);
		EnterRule(_localctx, 6, RULE_base_type);
		try {
			State = 487;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case BOOL:
			case BYTE:
			case CHAR:
			case DECIMAL:
			case DOUBLE:
			case FLOAT:
			case INT:
			case LONG:
			case SBYTE:
			case SHORT:
			case UINT:
			case ULONG:
			case USHORT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 482;
				simple_type();
				}
				break;
			case ADD:
			case ALIAS:
			case ARGLIST:
			case ASCENDING:
			case ASYNC:
			case AWAIT:
			case BY:
			case DESCENDING:
			case DYNAMIC:
			case EQUALS:
			case FROM:
			case GET:
			case GROUP:
			case INTO:
			case JOIN:
			case LET:
			case NAMEOF:
			case OBJECT:
			case ON:
			case ORDERBY:
			case PARTIAL:
			case REMOVE:
			case SELECT:
			case SET:
			case STRING:
			case UNMANAGED:
			case VAR:
			case WHEN:
			case WHERE:
			case YIELD:
			case IDENTIFIER:
				EnterOuterAlt(_localctx, 2);
				{
				State = 483;
				class_type();
				}
				break;
			case VOID:
				EnterOuterAlt(_localctx, 3);
				{
				State = 484;
				Match(VOID);
				State = 485;
				Match(STAR);
				}
				break;
			case OPEN_PARENS:
				EnterOuterAlt(_localctx, 4);
				{
				State = 486;
				tuple_type();
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

	public partial class Tuple_typeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Tuple_elementContext[] tuple_element() {
			return GetRuleContexts<Tuple_elementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Tuple_elementContext tuple_element(int i) {
			return GetRuleContext<Tuple_elementContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Tuple_typeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tuple_type; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterTuple_type(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitTuple_type(this);
		}
	}

	[RuleVersion(0)]
	public Tuple_typeContext tuple_type() {
		Tuple_typeContext _localctx = new Tuple_typeContext(Context, State);
		EnterRule(_localctx, 8, RULE_tuple_type);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 489;
			Match(OPEN_PARENS);
			State = 490;
			tuple_element();
			State = 493;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 491;
				Match(COMMA);
				State = 492;
				tuple_element();
				}
				}
				State = 495;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==COMMA );
			State = 497;
			Match(CLOSE_PARENS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Tuple_elementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public Tuple_elementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tuple_element; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterTuple_element(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitTuple_element(this);
		}
	}

	[RuleVersion(0)]
	public Tuple_elementContext tuple_element() {
		Tuple_elementContext _localctx = new Tuple_elementContext(Context, State);
		EnterRule(_localctx, 10, RULE_tuple_element);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 499;
			type_();
			State = 501;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BY) | (1L << DESCENDING) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << INTO) | (1L << JOIN) | (1L << LET))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REMOVE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (UNMANAGED - 64)) | (1L << (VAR - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)))) != 0)) {
				{
				State = 500;
				identifier();
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

	public partial class Simple_typeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Numeric_typeContext numeric_type() {
			return GetRuleContext<Numeric_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BOOL() { return GetToken(CSharpParser.BOOL, 0); }
		public Simple_typeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_simple_type; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterSimple_type(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitSimple_type(this);
		}
	}

	[RuleVersion(0)]
	public Simple_typeContext simple_type() {
		Simple_typeContext _localctx = new Simple_typeContext(Context, State);
		EnterRule(_localctx, 12, RULE_simple_type);
		try {
			State = 505;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case BYTE:
			case CHAR:
			case DECIMAL:
			case DOUBLE:
			case FLOAT:
			case INT:
			case LONG:
			case SBYTE:
			case SHORT:
			case UINT:
			case ULONG:
			case USHORT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 503;
				numeric_type();
				}
				break;
			case BOOL:
				EnterOuterAlt(_localctx, 2);
				{
				State = 504;
				Match(BOOL);
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

	public partial class Numeric_typeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Integral_typeContext integral_type() {
			return GetRuleContext<Integral_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Floating_point_typeContext floating_point_type() {
			return GetRuleContext<Floating_point_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DECIMAL() { return GetToken(CSharpParser.DECIMAL, 0); }
		public Numeric_typeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_numeric_type; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterNumeric_type(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitNumeric_type(this);
		}
	}

	[RuleVersion(0)]
	public Numeric_typeContext numeric_type() {
		Numeric_typeContext _localctx = new Numeric_typeContext(Context, State);
		EnterRule(_localctx, 14, RULE_numeric_type);
		try {
			State = 510;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case BYTE:
			case CHAR:
			case INT:
			case LONG:
			case SBYTE:
			case SHORT:
			case UINT:
			case ULONG:
			case USHORT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 507;
				integral_type();
				}
				break;
			case DOUBLE:
			case FLOAT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 508;
				floating_point_type();
				}
				break;
			case DECIMAL:
				EnterOuterAlt(_localctx, 3);
				{
				State = 509;
				Match(DECIMAL);
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

	public partial class Integral_typeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SBYTE() { return GetToken(CSharpParser.SBYTE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BYTE() { return GetToken(CSharpParser.BYTE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SHORT() { return GetToken(CSharpParser.SHORT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode USHORT() { return GetToken(CSharpParser.USHORT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT() { return GetToken(CSharpParser.INT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UINT() { return GetToken(CSharpParser.UINT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LONG() { return GetToken(CSharpParser.LONG, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ULONG() { return GetToken(CSharpParser.ULONG, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CHAR() { return GetToken(CSharpParser.CHAR, 0); }
		public Integral_typeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_integral_type; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterIntegral_type(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitIntegral_type(this);
		}
	}

	[RuleVersion(0)]
	public Integral_typeContext integral_type() {
		Integral_typeContext _localctx = new Integral_typeContext(Context, State);
		EnterRule(_localctx, 16, RULE_integral_type);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 512;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BYTE) | (1L << CHAR) | (1L << INT) | (1L << LONG))) != 0) || ((((_la - 83)) & ~0x3f) == 0 && ((1L << (_la - 83)) & ((1L << (SBYTE - 83)) | (1L << (SHORT - 83)) | (1L << (UINT - 83)) | (1L << (ULONG - 83)) | (1L << (USHORT - 83)))) != 0)) ) {
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

	public partial class Floating_point_typeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FLOAT() { return GetToken(CSharpParser.FLOAT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOUBLE() { return GetToken(CSharpParser.DOUBLE, 0); }
		public Floating_point_typeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_floating_point_type; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterFloating_point_type(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitFloating_point_type(this);
		}
	}

	[RuleVersion(0)]
	public Floating_point_typeContext floating_point_type() {
		Floating_point_typeContext _localctx = new Floating_point_typeContext(Context, State);
		EnterRule(_localctx, 18, RULE_floating_point_type);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 514;
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

	public partial class Class_typeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_or_type_nameContext namespace_or_type_name() {
			return GetRuleContext<Namespace_or_type_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OBJECT() { return GetToken(CSharpParser.OBJECT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DYNAMIC() { return GetToken(CSharpParser.DYNAMIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRING() { return GetToken(CSharpParser.STRING, 0); }
		public Class_typeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_class_type; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterClass_type(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitClass_type(this);
		}
	}

	[RuleVersion(0)]
	public Class_typeContext class_type() {
		Class_typeContext _localctx = new Class_typeContext(Context, State);
		EnterRule(_localctx, 20, RULE_class_type);
		try {
			State = 520;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,16,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 516;
				namespace_or_type_name();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 517;
				Match(OBJECT);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 518;
				Match(DYNAMIC);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 519;
				Match(STRING);
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

	public partial class Type_argument_listContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LT() { return GetToken(CSharpParser.LT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context[] type_() {
			return GetRuleContexts<Type_Context>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_(int i) {
			return GetRuleContext<Type_Context>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT() { return GetToken(CSharpParser.GT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Type_argument_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_type_argument_list; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterType_argument_list(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitType_argument_list(this);
		}
	}

	[RuleVersion(0)]
	public Type_argument_listContext type_argument_list() {
		Type_argument_listContext _localctx = new Type_argument_listContext(Context, State);
		EnterRule(_localctx, 22, RULE_type_argument_list);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 522;
			Match(LT);
			State = 523;
			type_();
			State = 528;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 524;
				Match(COMMA);
				State = 525;
				type_();
				}
				}
				State = 530;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 531;
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

	public partial class Argument_listContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentContext[] argument() {
			return GetRuleContexts<ArgumentContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentContext argument(int i) {
			return GetRuleContext<ArgumentContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Argument_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_argument_list; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterArgument_list(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitArgument_list(this);
		}
	}

	[RuleVersion(0)]
	public Argument_listContext argument_list() {
		Argument_listContext _localctx = new Argument_listContext(Context, State);
		EnterRule(_localctx, 24, RULE_argument_list);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 533;
			argument();
			State = 538;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 534;
				Match(COMMA);
				State = 535;
				argument();
				}
				}
				State = 540;
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

	public partial class ArgumentContext : ParserRuleContext {
		public IToken refout;
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(CSharpParser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VAR() { return GetToken(CSharpParser.VAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REF() { return GetToken(CSharpParser.REF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OUT() { return GetToken(CSharpParser.OUT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IN() { return GetToken(CSharpParser.IN, 0); }
		public ArgumentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_argument; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterArgument(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitArgument(this);
		}
	}

	[RuleVersion(0)]
	public ArgumentContext argument() {
		ArgumentContext _localctx = new ArgumentContext(Context, State);
		EnterRule(_localctx, 26, RULE_argument);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 544;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,19,Context) ) {
			case 1:
				{
				State = 541;
				identifier();
				State = 542;
				Match(COLON);
				}
				break;
			}
			State = 547;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,20,Context) ) {
			case 1:
				{
				State = 546;
				_localctx.refout = TokenStream.LT(1);
				_la = TokenStream.LA(1);
				if ( !(((((_la - 54)) & ~0x3f) == 0 && ((1L << (_la - 54)) & ((1L << (IN - 54)) | (1L << (OUT - 54)) | (1L << (REF - 54)))) != 0)) ) {
					_localctx.refout = ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
				break;
			}
			State = 551;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,21,Context) ) {
			case 1:
				{
				State = 549;
				Match(VAR);
				}
				break;
			case 2:
				{
				State = 550;
				type_();
				}
				break;
			}
			State = 553;
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
		[System.Diagnostics.DebuggerNonUserCode] public AssignmentContext assignment() {
			return GetRuleContext<AssignmentContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Non_assignment_expressionContext non_assignment_expression() {
			return GetRuleContext<Non_assignment_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REF() { return GetToken(CSharpParser.REF, 0); }
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitExpression(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		ExpressionContext _localctx = new ExpressionContext(Context, State);
		EnterRule(_localctx, 28, RULE_expression);
		try {
			State = 559;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,22,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 555;
				assignment();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 556;
				non_assignment_expression();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 557;
				Match(REF);
				State = 558;
				non_assignment_expression();
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

	public partial class Non_assignment_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Lambda_expressionContext lambda_expression() {
			return GetRuleContext<Lambda_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Query_expressionContext query_expression() {
			return GetRuleContext<Query_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Conditional_expressionContext conditional_expression() {
			return GetRuleContext<Conditional_expressionContext>(0);
		}
		public Non_assignment_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_non_assignment_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterNon_assignment_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitNon_assignment_expression(this);
		}
	}

	[RuleVersion(0)]
	public Non_assignment_expressionContext non_assignment_expression() {
		Non_assignment_expressionContext _localctx = new Non_assignment_expressionContext(Context, State);
		EnterRule(_localctx, 30, RULE_non_assignment_expression);
		try {
			State = 564;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,23,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 561;
				lambda_expression();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 562;
				query_expression();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 563;
				conditional_expression();
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
		[System.Diagnostics.DebuggerNonUserCode] public Unary_expressionContext unary_expression() {
			return GetRuleContext<Unary_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Assignment_operatorContext assignment_operator() {
			return GetRuleContext<Assignment_operatorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_COALESCING_ASSIGNMENT() { return GetToken(CSharpParser.OP_COALESCING_ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Throwable_expressionContext throwable_expression() {
			return GetRuleContext<Throwable_expressionContext>(0);
		}
		public AssignmentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignment; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAssignment(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAssignment(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentContext assignment() {
		AssignmentContext _localctx = new AssignmentContext(Context, State);
		EnterRule(_localctx, 32, RULE_assignment);
		try {
			State = 574;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,24,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 566;
				unary_expression();
				State = 567;
				assignment_operator();
				State = 568;
				expression();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 570;
				unary_expression();
				State = 571;
				Match(OP_COALESCING_ASSIGNMENT);
				State = 572;
				throwable_expression();
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

	public partial class Assignment_operatorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGNMENT() { return GetToken(CSharpParser.ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_ADD_ASSIGNMENT() { return GetToken(CSharpParser.OP_ADD_ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_SUB_ASSIGNMENT() { return GetToken(CSharpParser.OP_SUB_ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_MULT_ASSIGNMENT() { return GetToken(CSharpParser.OP_MULT_ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_DIV_ASSIGNMENT() { return GetToken(CSharpParser.OP_DIV_ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_MOD_ASSIGNMENT() { return GetToken(CSharpParser.OP_MOD_ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_AND_ASSIGNMENT() { return GetToken(CSharpParser.OP_AND_ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_OR_ASSIGNMENT() { return GetToken(CSharpParser.OP_OR_ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_XOR_ASSIGNMENT() { return GetToken(CSharpParser.OP_XOR_ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_LEFT_SHIFT_ASSIGNMENT() { return GetToken(CSharpParser.OP_LEFT_SHIFT_ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Right_shift_assignmentContext right_shift_assignment() {
			return GetRuleContext<Right_shift_assignmentContext>(0);
		}
		public Assignment_operatorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignment_operator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAssignment_operator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAssignment_operator(this);
		}
	}

	[RuleVersion(0)]
	public Assignment_operatorContext assignment_operator() {
		Assignment_operatorContext _localctx = new Assignment_operatorContext(Context, State);
		EnterRule(_localctx, 34, RULE_assignment_operator);
		try {
			State = 587;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ASSIGNMENT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 576;
				Match(ASSIGNMENT);
				}
				break;
			case OP_ADD_ASSIGNMENT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 577;
				Match(OP_ADD_ASSIGNMENT);
				}
				break;
			case OP_SUB_ASSIGNMENT:
				EnterOuterAlt(_localctx, 3);
				{
				State = 578;
				Match(OP_SUB_ASSIGNMENT);
				}
				break;
			case OP_MULT_ASSIGNMENT:
				EnterOuterAlt(_localctx, 4);
				{
				State = 579;
				Match(OP_MULT_ASSIGNMENT);
				}
				break;
			case OP_DIV_ASSIGNMENT:
				EnterOuterAlt(_localctx, 5);
				{
				State = 580;
				Match(OP_DIV_ASSIGNMENT);
				}
				break;
			case OP_MOD_ASSIGNMENT:
				EnterOuterAlt(_localctx, 6);
				{
				State = 581;
				Match(OP_MOD_ASSIGNMENT);
				}
				break;
			case OP_AND_ASSIGNMENT:
				EnterOuterAlt(_localctx, 7);
				{
				State = 582;
				Match(OP_AND_ASSIGNMENT);
				}
				break;
			case OP_OR_ASSIGNMENT:
				EnterOuterAlt(_localctx, 8);
				{
				State = 583;
				Match(OP_OR_ASSIGNMENT);
				}
				break;
			case OP_XOR_ASSIGNMENT:
				EnterOuterAlt(_localctx, 9);
				{
				State = 584;
				Match(OP_XOR_ASSIGNMENT);
				}
				break;
			case OP_LEFT_SHIFT_ASSIGNMENT:
				EnterOuterAlt(_localctx, 10);
				{
				State = 585;
				Match(OP_LEFT_SHIFT_ASSIGNMENT);
				}
				break;
			case GT:
				EnterOuterAlt(_localctx, 11);
				{
				State = 586;
				right_shift_assignment();
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

	public partial class Conditional_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Null_coalescing_expressionContext null_coalescing_expression() {
			return GetRuleContext<Null_coalescing_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERR() { return GetToken(CSharpParser.INTERR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Throwable_expressionContext[] throwable_expression() {
			return GetRuleContexts<Throwable_expressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Throwable_expressionContext throwable_expression(int i) {
			return GetRuleContext<Throwable_expressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(CSharpParser.COLON, 0); }
		public Conditional_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_conditional_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterConditional_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitConditional_expression(this);
		}
	}

	[RuleVersion(0)]
	public Conditional_expressionContext conditional_expression() {
		Conditional_expressionContext _localctx = new Conditional_expressionContext(Context, State);
		EnterRule(_localctx, 36, RULE_conditional_expression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 589;
			null_coalescing_expression();
			State = 595;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,26,Context) ) {
			case 1:
				{
				State = 590;
				Match(INTERR);
				State = 591;
				throwable_expression();
				State = 592;
				Match(COLON);
				State = 593;
				throwable_expression();
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

	public partial class Null_coalescing_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Conditional_or_expressionContext conditional_or_expression() {
			return GetRuleContext<Conditional_or_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_COALESCING() { return GetToken(CSharpParser.OP_COALESCING, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Null_coalescing_expressionContext null_coalescing_expression() {
			return GetRuleContext<Null_coalescing_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Throw_expressionContext throw_expression() {
			return GetRuleContext<Throw_expressionContext>(0);
		}
		public Null_coalescing_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_null_coalescing_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterNull_coalescing_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitNull_coalescing_expression(this);
		}
	}

	[RuleVersion(0)]
	public Null_coalescing_expressionContext null_coalescing_expression() {
		Null_coalescing_expressionContext _localctx = new Null_coalescing_expressionContext(Context, State);
		EnterRule(_localctx, 38, RULE_null_coalescing_expression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 597;
			conditional_or_expression();
			State = 603;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,28,Context) ) {
			case 1:
				{
				State = 598;
				Match(OP_COALESCING);
				State = 601;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case ADD:
				case ALIAS:
				case ARGLIST:
				case ASCENDING:
				case ASYNC:
				case AWAIT:
				case BASE:
				case BOOL:
				case BY:
				case BYTE:
				case CHAR:
				case CHECKED:
				case DECIMAL:
				case DEFAULT:
				case DELEGATE:
				case DESCENDING:
				case DOUBLE:
				case DYNAMIC:
				case EQUALS:
				case FALSE:
				case FLOAT:
				case FROM:
				case GET:
				case GROUP:
				case INT:
				case INTO:
				case JOIN:
				case LET:
				case LONG:
				case NAMEOF:
				case NEW:
				case NULL_:
				case OBJECT:
				case ON:
				case ORDERBY:
				case PARTIAL:
				case REMOVE:
				case SBYTE:
				case SELECT:
				case SET:
				case SHORT:
				case SIZEOF:
				case STRING:
				case THIS:
				case TRUE:
				case TYPEOF:
				case UINT:
				case ULONG:
				case UNCHECKED:
				case UNMANAGED:
				case USHORT:
				case VAR:
				case WHEN:
				case WHERE:
				case YIELD:
				case IDENTIFIER:
				case LITERAL_ACCESS:
				case INTEGER_LITERAL:
				case HEX_INTEGER_LITERAL:
				case BIN_INTEGER_LITERAL:
				case REAL_LITERAL:
				case CHARACTER_LITERAL:
				case REGULAR_STRING:
				case VERBATIUM_STRING:
				case INTERPOLATED_REGULAR_STRING_START:
				case INTERPOLATED_VERBATIUM_STRING_START:
				case OPEN_PARENS:
				case PLUS:
				case MINUS:
				case STAR:
				case AMP:
				case CARET:
				case BANG:
				case TILDE:
				case OP_INC:
				case OP_DEC:
				case OP_RANGE:
					{
					State = 599;
					null_coalescing_expression();
					}
					break;
				case THROW:
					{
					State = 600;
					throw_expression();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
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

	public partial class Conditional_or_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Conditional_and_expressionContext[] conditional_and_expression() {
			return GetRuleContexts<Conditional_and_expressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Conditional_and_expressionContext conditional_and_expression(int i) {
			return GetRuleContext<Conditional_and_expressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OP_OR() { return GetTokens(CSharpParser.OP_OR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_OR(int i) {
			return GetToken(CSharpParser.OP_OR, i);
		}
		public Conditional_or_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_conditional_or_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterConditional_or_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitConditional_or_expression(this);
		}
	}

	[RuleVersion(0)]
	public Conditional_or_expressionContext conditional_or_expression() {
		Conditional_or_expressionContext _localctx = new Conditional_or_expressionContext(Context, State);
		EnterRule(_localctx, 40, RULE_conditional_or_expression);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 605;
			conditional_and_expression();
			State = 610;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,29,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 606;
					Match(OP_OR);
					State = 607;
					conditional_and_expression();
					}
					} 
				}
				State = 612;
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
			ExitRule();
		}
		return _localctx;
	}

	public partial class Conditional_and_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Inclusive_or_expressionContext[] inclusive_or_expression() {
			return GetRuleContexts<Inclusive_or_expressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Inclusive_or_expressionContext inclusive_or_expression(int i) {
			return GetRuleContext<Inclusive_or_expressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OP_AND() { return GetTokens(CSharpParser.OP_AND); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_AND(int i) {
			return GetToken(CSharpParser.OP_AND, i);
		}
		public Conditional_and_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_conditional_and_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterConditional_and_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitConditional_and_expression(this);
		}
	}

	[RuleVersion(0)]
	public Conditional_and_expressionContext conditional_and_expression() {
		Conditional_and_expressionContext _localctx = new Conditional_and_expressionContext(Context, State);
		EnterRule(_localctx, 42, RULE_conditional_and_expression);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 613;
			inclusive_or_expression();
			State = 618;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,30,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 614;
					Match(OP_AND);
					State = 615;
					inclusive_or_expression();
					}
					} 
				}
				State = 620;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,30,Context);
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

	public partial class Inclusive_or_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Exclusive_or_expressionContext[] exclusive_or_expression() {
			return GetRuleContexts<Exclusive_or_expressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Exclusive_or_expressionContext exclusive_or_expression(int i) {
			return GetRuleContext<Exclusive_or_expressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] BITWISE_OR() { return GetTokens(CSharpParser.BITWISE_OR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BITWISE_OR(int i) {
			return GetToken(CSharpParser.BITWISE_OR, i);
		}
		public Inclusive_or_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_inclusive_or_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterInclusive_or_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitInclusive_or_expression(this);
		}
	}

	[RuleVersion(0)]
	public Inclusive_or_expressionContext inclusive_or_expression() {
		Inclusive_or_expressionContext _localctx = new Inclusive_or_expressionContext(Context, State);
		EnterRule(_localctx, 44, RULE_inclusive_or_expression);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 621;
			exclusive_or_expression();
			State = 626;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,31,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 622;
					Match(BITWISE_OR);
					State = 623;
					exclusive_or_expression();
					}
					} 
				}
				State = 628;
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
			ExitRule();
		}
		return _localctx;
	}

	public partial class Exclusive_or_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public And_expressionContext[] and_expression() {
			return GetRuleContexts<And_expressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public And_expressionContext and_expression(int i) {
			return GetRuleContext<And_expressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] CARET() { return GetTokens(CSharpParser.CARET); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CARET(int i) {
			return GetToken(CSharpParser.CARET, i);
		}
		public Exclusive_or_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exclusive_or_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterExclusive_or_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitExclusive_or_expression(this);
		}
	}

	[RuleVersion(0)]
	public Exclusive_or_expressionContext exclusive_or_expression() {
		Exclusive_or_expressionContext _localctx = new Exclusive_or_expressionContext(Context, State);
		EnterRule(_localctx, 46, RULE_exclusive_or_expression);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 629;
			and_expression();
			State = 634;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,32,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 630;
					Match(CARET);
					State = 631;
					and_expression();
					}
					} 
				}
				State = 636;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,32,Context);
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

	public partial class And_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Equality_expressionContext[] equality_expression() {
			return GetRuleContexts<Equality_expressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Equality_expressionContext equality_expression(int i) {
			return GetRuleContext<Equality_expressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] AMP() { return GetTokens(CSharpParser.AMP); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AMP(int i) {
			return GetToken(CSharpParser.AMP, i);
		}
		public And_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_and_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAnd_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAnd_expression(this);
		}
	}

	[RuleVersion(0)]
	public And_expressionContext and_expression() {
		And_expressionContext _localctx = new And_expressionContext(Context, State);
		EnterRule(_localctx, 48, RULE_and_expression);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 637;
			equality_expression();
			State = 642;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,33,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 638;
					Match(AMP);
					State = 639;
					equality_expression();
					}
					} 
				}
				State = 644;
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
			ExitRule();
		}
		return _localctx;
	}

	public partial class Equality_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Relational_expressionContext[] relational_expression() {
			return GetRuleContexts<Relational_expressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Relational_expressionContext relational_expression(int i) {
			return GetRuleContext<Relational_expressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OP_EQ() { return GetTokens(CSharpParser.OP_EQ); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_EQ(int i) {
			return GetToken(CSharpParser.OP_EQ, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OP_NE() { return GetTokens(CSharpParser.OP_NE); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_NE(int i) {
			return GetToken(CSharpParser.OP_NE, i);
		}
		public Equality_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_equality_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterEquality_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitEquality_expression(this);
		}
	}

	[RuleVersion(0)]
	public Equality_expressionContext equality_expression() {
		Equality_expressionContext _localctx = new Equality_expressionContext(Context, State);
		EnterRule(_localctx, 50, RULE_equality_expression);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 645;
			relational_expression();
			State = 650;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,34,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 646;
					_la = TokenStream.LA(1);
					if ( !(_la==OP_EQ || _la==OP_NE) ) {
					ErrorHandler.RecoverInline(this);
					}
					else {
						ErrorHandler.ReportMatch(this);
					    Consume();
					}
					State = 647;
					relational_expression();
					}
					} 
				}
				State = 652;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,34,Context);
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

	public partial class Relational_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Shift_expressionContext[] shift_expression() {
			return GetRuleContexts<Shift_expressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Shift_expressionContext shift_expression(int i) {
			return GetRuleContext<Shift_expressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] IS() { return GetTokens(CSharpParser.IS); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IS(int i) {
			return GetToken(CSharpParser.IS, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IsTypeContext[] isType() {
			return GetRuleContexts<IsTypeContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public IsTypeContext isType(int i) {
			return GetRuleContext<IsTypeContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] AS() { return GetTokens(CSharpParser.AS); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AS(int i) {
			return GetToken(CSharpParser.AS, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context[] type_() {
			return GetRuleContexts<Type_Context>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_(int i) {
			return GetRuleContext<Type_Context>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] LT() { return GetTokens(CSharpParser.LT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LT(int i) {
			return GetToken(CSharpParser.LT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] GT() { return GetTokens(CSharpParser.GT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT(int i) {
			return GetToken(CSharpParser.GT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OP_LE() { return GetTokens(CSharpParser.OP_LE); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_LE(int i) {
			return GetToken(CSharpParser.OP_LE, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OP_GE() { return GetTokens(CSharpParser.OP_GE); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_GE(int i) {
			return GetToken(CSharpParser.OP_GE, i);
		}
		public Relational_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_relational_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterRelational_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitRelational_expression(this);
		}
	}

	[RuleVersion(0)]
	public Relational_expressionContext relational_expression() {
		Relational_expressionContext _localctx = new Relational_expressionContext(Context, State);
		EnterRule(_localctx, 52, RULE_relational_expression);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 653;
			shift_expression();
			State = 662;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,36,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					State = 660;
					ErrorHandler.Sync(this);
					switch (TokenStream.LA(1)) {
					case LT:
					case GT:
					case OP_LE:
					case OP_GE:
						{
						State = 654;
						_la = TokenStream.LA(1);
						if ( !(((((_la - 146)) & ~0x3f) == 0 && ((1L << (_la - 146)) & ((1L << (LT - 146)) | (1L << (GT - 146)) | (1L << (OP_LE - 146)) | (1L << (OP_GE - 146)))) != 0)) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 655;
						shift_expression();
						}
						break;
					case IS:
						{
						State = 656;
						Match(IS);
						State = 657;
						isType();
						}
						break;
					case AS:
						{
						State = 658;
						Match(AS);
						State = 659;
						type_();
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					} 
				}
				State = 664;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,36,Context);
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

	public partial class Shift_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Additive_expressionContext[] additive_expression() {
			return GetRuleContexts<Additive_expressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Additive_expressionContext additive_expression(int i) {
			return GetRuleContext<Additive_expressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OP_LEFT_SHIFT() { return GetTokens(CSharpParser.OP_LEFT_SHIFT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_LEFT_SHIFT(int i) {
			return GetToken(CSharpParser.OP_LEFT_SHIFT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Right_shiftContext[] right_shift() {
			return GetRuleContexts<Right_shiftContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Right_shiftContext right_shift(int i) {
			return GetRuleContext<Right_shiftContext>(i);
		}
		public Shift_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_shift_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterShift_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitShift_expression(this);
		}
	}

	[RuleVersion(0)]
	public Shift_expressionContext shift_expression() {
		Shift_expressionContext _localctx = new Shift_expressionContext(Context, State);
		EnterRule(_localctx, 54, RULE_shift_expression);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 665;
			additive_expression();
			State = 673;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,38,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 668;
					ErrorHandler.Sync(this);
					switch (TokenStream.LA(1)) {
					case OP_LEFT_SHIFT:
						{
						State = 666;
						Match(OP_LEFT_SHIFT);
						}
						break;
					case GT:
						{
						State = 667;
						right_shift();
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					State = 670;
					additive_expression();
					}
					} 
				}
				State = 675;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,38,Context);
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

	public partial class Additive_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Multiplicative_expressionContext[] multiplicative_expression() {
			return GetRuleContexts<Multiplicative_expressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Multiplicative_expressionContext multiplicative_expression(int i) {
			return GetRuleContext<Multiplicative_expressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] PLUS() { return GetTokens(CSharpParser.PLUS); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PLUS(int i) {
			return GetToken(CSharpParser.PLUS, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] MINUS() { return GetTokens(CSharpParser.MINUS); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MINUS(int i) {
			return GetToken(CSharpParser.MINUS, i);
		}
		public Additive_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_additive_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAdditive_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAdditive_expression(this);
		}
	}

	[RuleVersion(0)]
	public Additive_expressionContext additive_expression() {
		Additive_expressionContext _localctx = new Additive_expressionContext(Context, State);
		EnterRule(_localctx, 56, RULE_additive_expression);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 676;
			multiplicative_expression();
			State = 681;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,39,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 677;
					_la = TokenStream.LA(1);
					if ( !(_la==PLUS || _la==MINUS) ) {
					ErrorHandler.RecoverInline(this);
					}
					else {
						ErrorHandler.ReportMatch(this);
					    Consume();
					}
					State = 678;
					multiplicative_expression();
					}
					} 
				}
				State = 683;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,39,Context);
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

	public partial class Multiplicative_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Switch_expressionContext[] switch_expression() {
			return GetRuleContexts<Switch_expressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Switch_expressionContext switch_expression(int i) {
			return GetRuleContext<Switch_expressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] STAR() { return GetTokens(CSharpParser.STAR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STAR(int i) {
			return GetToken(CSharpParser.STAR, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DIV() { return GetTokens(CSharpParser.DIV); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIV(int i) {
			return GetToken(CSharpParser.DIV, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] PERCENT() { return GetTokens(CSharpParser.PERCENT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PERCENT(int i) {
			return GetToken(CSharpParser.PERCENT, i);
		}
		public Multiplicative_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_multiplicative_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterMultiplicative_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitMultiplicative_expression(this);
		}
	}

	[RuleVersion(0)]
	public Multiplicative_expressionContext multiplicative_expression() {
		Multiplicative_expressionContext _localctx = new Multiplicative_expressionContext(Context, State);
		EnterRule(_localctx, 58, RULE_multiplicative_expression);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 684;
			switch_expression();
			State = 689;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,40,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 685;
					_la = TokenStream.LA(1);
					if ( !(((((_la - 137)) & ~0x3f) == 0 && ((1L << (_la - 137)) & ((1L << (STAR - 137)) | (1L << (DIV - 137)) | (1L << (PERCENT - 137)))) != 0)) ) {
					ErrorHandler.RecoverInline(this);
					}
					else {
						ErrorHandler.ReportMatch(this);
					    Consume();
					}
					State = 686;
					switch_expression();
					}
					} 
				}
				State = 691;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,40,Context);
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

	public partial class Switch_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Range_expressionContext range_expression() {
			return GetRuleContext<Range_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SWITCH() { return GetToken(CSharpParser.SWITCH, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Switch_expression_armsContext switch_expression_arms() {
			return GetRuleContext<Switch_expression_armsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(CSharpParser.COMMA, 0); }
		public Switch_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_switch_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterSwitch_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitSwitch_expression(this);
		}
	}

	[RuleVersion(0)]
	public Switch_expressionContext switch_expression() {
		Switch_expressionContext _localctx = new Switch_expressionContext(Context, State);
		EnterRule(_localctx, 60, RULE_switch_expression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 692;
			range_expression();
			State = 702;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,43,Context) ) {
			case 1:
				{
				State = 693;
				Match(SWITCH);
				State = 694;
				Match(OPEN_BRACE);
				State = 699;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BASE) | (1L << BOOL) | (1L << BY) | (1L << BYTE) | (1L << CHAR) | (1L << CHECKED) | (1L << DECIMAL) | (1L << DEFAULT) | (1L << DELEGATE) | (1L << DESCENDING) | (1L << DOUBLE) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FALSE) | (1L << FLOAT) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << INT) | (1L << INTO) | (1L << JOIN) | (1L << LET) | (1L << LONG))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (NEW - 64)) | (1L << (NULL_ - 64)) | (1L << (OBJECT - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REF - 64)) | (1L << (REMOVE - 64)) | (1L << (SBYTE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (SHORT - 64)) | (1L << (SIZEOF - 64)) | (1L << (STRING - 64)) | (1L << (THIS - 64)) | (1L << (TRUE - 64)) | (1L << (TYPEOF - 64)) | (1L << (UINT - 64)) | (1L << (ULONG - 64)) | (1L << (UNCHECKED - 64)) | (1L << (UNMANAGED - 64)) | (1L << (USHORT - 64)) | (1L << (VAR - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (LITERAL_ACCESS - 64)) | (1L << (INTEGER_LITERAL - 64)) | (1L << (HEX_INTEGER_LITERAL - 64)) | (1L << (BIN_INTEGER_LITERAL - 64)) | (1L << (REAL_LITERAL - 64)) | (1L << (CHARACTER_LITERAL - 64)) | (1L << (REGULAR_STRING - 64)) | (1L << (VERBATIUM_STRING - 64)) | (1L << (INTERPOLATED_REGULAR_STRING_START - 64)) | (1L << (INTERPOLATED_VERBATIUM_STRING_START - 64)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (OPEN_PARENS - 129)) | (1L << (PLUS - 129)) | (1L << (MINUS - 129)) | (1L << (STAR - 129)) | (1L << (AMP - 129)) | (1L << (CARET - 129)) | (1L << (BANG - 129)) | (1L << (TILDE - 129)) | (1L << (OP_INC - 129)) | (1L << (OP_DEC - 129)) | (1L << (OP_RANGE - 129)))) != 0)) {
					{
					State = 695;
					switch_expression_arms();
					State = 697;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==COMMA) {
						{
						State = 696;
						Match(COMMA);
						}
					}

					}
				}

				State = 701;
				Match(CLOSE_BRACE);
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

	public partial class Switch_expression_armsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Switch_expression_armContext[] switch_expression_arm() {
			return GetRuleContexts<Switch_expression_armContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Switch_expression_armContext switch_expression_arm(int i) {
			return GetRuleContext<Switch_expression_armContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Switch_expression_armsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_switch_expression_arms; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterSwitch_expression_arms(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitSwitch_expression_arms(this);
		}
	}

	[RuleVersion(0)]
	public Switch_expression_armsContext switch_expression_arms() {
		Switch_expression_armsContext _localctx = new Switch_expression_armsContext(Context, State);
		EnterRule(_localctx, 62, RULE_switch_expression_arms);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 704;
			switch_expression_arm();
			State = 709;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,44,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 705;
					Match(COMMA);
					State = 706;
					switch_expression_arm();
					}
					} 
				}
				State = 711;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,44,Context);
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

	public partial class Switch_expression_armContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Right_arrowContext right_arrow() {
			return GetRuleContext<Right_arrowContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Throwable_expressionContext throwable_expression() {
			return GetRuleContext<Throwable_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Case_guardContext case_guard() {
			return GetRuleContext<Case_guardContext>(0);
		}
		public Switch_expression_armContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_switch_expression_arm; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterSwitch_expression_arm(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitSwitch_expression_arm(this);
		}
	}

	[RuleVersion(0)]
	public Switch_expression_armContext switch_expression_arm() {
		Switch_expression_armContext _localctx = new Switch_expression_armContext(Context, State);
		EnterRule(_localctx, 64, RULE_switch_expression_arm);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 712;
			expression();
			State = 714;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WHEN) {
				{
				State = 713;
				case_guard();
				}
			}

			State = 716;
			right_arrow();
			State = 717;
			throwable_expression();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Range_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Unary_expressionContext[] unary_expression() {
			return GetRuleContexts<Unary_expressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Unary_expressionContext unary_expression(int i) {
			return GetRuleContext<Unary_expressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_RANGE() { return GetToken(CSharpParser.OP_RANGE, 0); }
		public Range_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_range_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterRange_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitRange_expression(this);
		}
	}

	[RuleVersion(0)]
	public Range_expressionContext range_expression() {
		Range_expressionContext _localctx = new Range_expressionContext(Context, State);
		EnterRule(_localctx, 66, RULE_range_expression);
		int _la;
		try {
			State = 727;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,48,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 719;
				unary_expression();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 721;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BASE) | (1L << BOOL) | (1L << BY) | (1L << BYTE) | (1L << CHAR) | (1L << CHECKED) | (1L << DECIMAL) | (1L << DEFAULT) | (1L << DELEGATE) | (1L << DESCENDING) | (1L << DOUBLE) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FALSE) | (1L << FLOAT) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << INT) | (1L << INTO) | (1L << JOIN) | (1L << LET) | (1L << LONG))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (NEW - 64)) | (1L << (NULL_ - 64)) | (1L << (OBJECT - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REMOVE - 64)) | (1L << (SBYTE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (SHORT - 64)) | (1L << (SIZEOF - 64)) | (1L << (STRING - 64)) | (1L << (THIS - 64)) | (1L << (TRUE - 64)) | (1L << (TYPEOF - 64)) | (1L << (UINT - 64)) | (1L << (ULONG - 64)) | (1L << (UNCHECKED - 64)) | (1L << (UNMANAGED - 64)) | (1L << (USHORT - 64)) | (1L << (VAR - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (LITERAL_ACCESS - 64)) | (1L << (INTEGER_LITERAL - 64)) | (1L << (HEX_INTEGER_LITERAL - 64)) | (1L << (BIN_INTEGER_LITERAL - 64)) | (1L << (REAL_LITERAL - 64)) | (1L << (CHARACTER_LITERAL - 64)) | (1L << (REGULAR_STRING - 64)) | (1L << (VERBATIUM_STRING - 64)) | (1L << (INTERPOLATED_REGULAR_STRING_START - 64)) | (1L << (INTERPOLATED_VERBATIUM_STRING_START - 64)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (OPEN_PARENS - 129)) | (1L << (PLUS - 129)) | (1L << (MINUS - 129)) | (1L << (STAR - 129)) | (1L << (AMP - 129)) | (1L << (CARET - 129)) | (1L << (BANG - 129)) | (1L << (TILDE - 129)) | (1L << (OP_INC - 129)) | (1L << (OP_DEC - 129)))) != 0)) {
					{
					State = 720;
					unary_expression();
					}
				}

				State = 723;
				Match(OP_RANGE);
				State = 725;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,47,Context) ) {
				case 1:
					{
					State = 724;
					unary_expression();
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

	public partial class Unary_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Primary_expressionContext primary_expression() {
			return GetRuleContext<Primary_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PLUS() { return GetToken(CSharpParser.PLUS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Unary_expressionContext unary_expression() {
			return GetRuleContext<Unary_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MINUS() { return GetToken(CSharpParser.MINUS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BANG() { return GetToken(CSharpParser.BANG, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TILDE() { return GetToken(CSharpParser.TILDE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_INC() { return GetToken(CSharpParser.OP_INC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_DEC() { return GetToken(CSharpParser.OP_DEC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AWAIT() { return GetToken(CSharpParser.AWAIT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AMP() { return GetToken(CSharpParser.AMP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STAR() { return GetToken(CSharpParser.STAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CARET() { return GetToken(CSharpParser.CARET, 0); }
		public Unary_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unary_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterUnary_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitUnary_expression(this);
		}
	}

	[RuleVersion(0)]
	public Unary_expressionContext unary_expression() {
		Unary_expressionContext _localctx = new Unary_expressionContext(Context, State);
		EnterRule(_localctx, 68, RULE_unary_expression);
		try {
			State = 755;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,49,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 729;
				primary_expression();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 730;
				Match(PLUS);
				State = 731;
				unary_expression();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 732;
				Match(MINUS);
				State = 733;
				unary_expression();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 734;
				Match(BANG);
				State = 735;
				unary_expression();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 736;
				Match(TILDE);
				State = 737;
				unary_expression();
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 738;
				Match(OP_INC);
				State = 739;
				unary_expression();
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 740;
				Match(OP_DEC);
				State = 741;
				unary_expression();
				}
				break;
			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 742;
				Match(OPEN_PARENS);
				State = 743;
				type_();
				State = 744;
				Match(CLOSE_PARENS);
				State = 745;
				unary_expression();
				}
				break;
			case 9:
				EnterOuterAlt(_localctx, 9);
				{
				State = 747;
				Match(AWAIT);
				State = 748;
				unary_expression();
				}
				break;
			case 10:
				EnterOuterAlt(_localctx, 10);
				{
				State = 749;
				Match(AMP);
				State = 750;
				unary_expression();
				}
				break;
			case 11:
				EnterOuterAlt(_localctx, 11);
				{
				State = 751;
				Match(STAR);
				State = 752;
				unary_expression();
				}
				break;
			case 12:
				EnterOuterAlt(_localctx, 12);
				{
				State = 753;
				Match(CARET);
				State = 754;
				unary_expression();
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

	public partial class Primary_expressionContext : ParserRuleContext {
		public Primary_expression_startContext pe;
		[System.Diagnostics.DebuggerNonUserCode] public Primary_expression_startContext primary_expression_start() {
			return GetRuleContext<Primary_expression_startContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] BANG() { return GetTokens(CSharpParser.BANG); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BANG(int i) {
			return GetToken(CSharpParser.BANG, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Bracket_expressionContext[] bracket_expression() {
			return GetRuleContexts<Bracket_expressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Bracket_expressionContext bracket_expression(int i) {
			return GetRuleContext<Bracket_expressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Member_accessContext[] member_access() {
			return GetRuleContexts<Member_accessContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Member_accessContext member_access(int i) {
			return GetRuleContext<Member_accessContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Method_invocationContext[] method_invocation() {
			return GetRuleContexts<Method_invocationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Method_invocationContext method_invocation(int i) {
			return GetRuleContext<Method_invocationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OP_INC() { return GetTokens(CSharpParser.OP_INC); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_INC(int i) {
			return GetToken(CSharpParser.OP_INC, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OP_DEC() { return GetTokens(CSharpParser.OP_DEC); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_DEC(int i) {
			return GetToken(CSharpParser.OP_DEC, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OP_PTR() { return GetTokens(CSharpParser.OP_PTR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_PTR(int i) {
			return GetToken(CSharpParser.OP_PTR, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		public Primary_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primary_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterPrimary_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitPrimary_expression(this);
		}
	}

	[RuleVersion(0)]
	public Primary_expressionContext primary_expression() {
		Primary_expressionContext _localctx = new Primary_expressionContext(Context, State);
		EnterRule(_localctx, 70, RULE_primary_expression);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 757;
			_localctx.pe = primary_expression_start();
			State = 759;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,50,Context) ) {
			case 1:
				{
				State = 758;
				Match(BANG);
				}
				break;
			}
			State = 764;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,51,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 761;
					bracket_expression();
					}
					} 
				}
				State = 766;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,51,Context);
			}
			State = 768;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,52,Context) ) {
			case 1:
				{
				State = 767;
				Match(BANG);
				}
				break;
			}
			State = 792;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,57,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					{
					State = 776;
					ErrorHandler.Sync(this);
					switch (TokenStream.LA(1)) {
					case DOT:
					case INTERR:
						{
						State = 770;
						member_access();
						}
						break;
					case OPEN_PARENS:
						{
						State = 771;
						method_invocation();
						}
						break;
					case OP_INC:
						{
						State = 772;
						Match(OP_INC);
						}
						break;
					case OP_DEC:
						{
						State = 773;
						Match(OP_DEC);
						}
						break;
					case OP_PTR:
						{
						State = 774;
						Match(OP_PTR);
						State = 775;
						identifier();
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					State = 779;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,54,Context) ) {
					case 1:
						{
						State = 778;
						Match(BANG);
						}
						break;
					}
					}
					State = 784;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,55,Context);
					while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
						if ( _alt==1 ) {
							{
							{
							State = 781;
							bracket_expression();
							}
							} 
						}
						State = 786;
						ErrorHandler.Sync(this);
						_alt = Interpreter.AdaptivePredict(TokenStream,55,Context);
					}
					State = 788;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,56,Context) ) {
					case 1:
						{
						State = 787;
						Match(BANG);
						}
						break;
					}
					}
					} 
				}
				State = 794;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,57,Context);
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

	public partial class Primary_expression_startContext : ParserRuleContext {
		public Primary_expression_startContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primary_expression_start; } }
	 
		public Primary_expression_startContext() { }
		public virtual void CopyFrom(Primary_expression_startContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class LiteralAccessExpressionContext : Primary_expression_startContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LITERAL_ACCESS() { return GetToken(CSharpParser.LITERAL_ACCESS, 0); }
		public LiteralAccessExpressionContext(Primary_expression_startContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterLiteralAccessExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitLiteralAccessExpression(this);
		}
	}
	public partial class DefaultValueExpressionContext : Primary_expression_startContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFAULT() { return GetToken(CSharpParser.DEFAULT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		public DefaultValueExpressionContext(Primary_expression_startContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterDefaultValueExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitDefaultValueExpression(this);
		}
	}
	public partial class BaseAccessExpressionContext : Primary_expression_startContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BASE() { return GetToken(CSharpParser.BASE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(CSharpParser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACKET() { return GetToken(CSharpParser.OPEN_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Expression_listContext expression_list() {
			return GetRuleContext<Expression_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACKET() { return GetToken(CSharpParser.CLOSE_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_argument_listContext type_argument_list() {
			return GetRuleContext<Type_argument_listContext>(0);
		}
		public BaseAccessExpressionContext(Primary_expression_startContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterBaseAccessExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitBaseAccessExpression(this);
		}
	}
	public partial class SizeofExpressionContext : Primary_expression_startContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SIZEOF() { return GetToken(CSharpParser.SIZEOF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		public SizeofExpressionContext(Primary_expression_startContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterSizeofExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitSizeofExpression(this);
		}
	}
	public partial class ParenthesisExpressionsContext : Primary_expression_startContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		public ParenthesisExpressionsContext(Primary_expression_startContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterParenthesisExpressions(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitParenthesisExpressions(this);
		}
	}
	public partial class ThisReferenceExpressionContext : Primary_expression_startContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THIS() { return GetToken(CSharpParser.THIS, 0); }
		public ThisReferenceExpressionContext(Primary_expression_startContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterThisReferenceExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitThisReferenceExpression(this);
		}
	}
	public partial class ObjectCreationExpressionContext : Primary_expression_startContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEW() { return GetToken(CSharpParser.NEW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Anonymous_object_initializerContext anonymous_object_initializer() {
			return GetRuleContext<Anonymous_object_initializerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Rank_specifierContext[] rank_specifier() {
			return GetRuleContexts<Rank_specifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Rank_specifierContext rank_specifier(int i) {
			return GetRuleContext<Rank_specifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Array_initializerContext array_initializer() {
			return GetRuleContext<Array_initializerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Object_creation_expressionContext object_creation_expression() {
			return GetRuleContext<Object_creation_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Object_or_collection_initializerContext object_or_collection_initializer() {
			return GetRuleContext<Object_or_collection_initializerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACKET() { return GetToken(CSharpParser.OPEN_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Expression_listContext expression_list() {
			return GetRuleContext<Expression_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACKET() { return GetToken(CSharpParser.CLOSE_BRACKET, 0); }
		public ObjectCreationExpressionContext(Primary_expression_startContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterObjectCreationExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitObjectCreationExpression(this);
		}
	}
	public partial class AnonymousMethodExpressionContext : Primary_expression_startContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DELEGATE() { return GetToken(CSharpParser.DELEGATE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASYNC() { return GetToken(CSharpParser.ASYNC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Explicit_anonymous_function_parameter_listContext explicit_anonymous_function_parameter_list() {
			return GetRuleContext<Explicit_anonymous_function_parameter_listContext>(0);
		}
		public AnonymousMethodExpressionContext(Primary_expression_startContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAnonymousMethodExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAnonymousMethodExpression(this);
		}
	}
	public partial class TypeofExpressionContext : Primary_expression_startContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TYPEOF() { return GetToken(CSharpParser.TYPEOF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Unbound_type_nameContext unbound_type_name() {
			return GetRuleContext<Unbound_type_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOID() { return GetToken(CSharpParser.VOID, 0); }
		public TypeofExpressionContext(Primary_expression_startContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterTypeofExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitTypeofExpression(this);
		}
	}
	public partial class TupleExpressionContext : Primary_expression_startContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentContext[] argument() {
			return GetRuleContexts<ArgumentContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ArgumentContext argument(int i) {
			return GetRuleContext<ArgumentContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public TupleExpressionContext(Primary_expression_startContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterTupleExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitTupleExpression(this);
		}
	}
	public partial class UncheckedExpressionContext : Primary_expression_startContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNCHECKED() { return GetToken(CSharpParser.UNCHECKED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		public UncheckedExpressionContext(Primary_expression_startContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterUncheckedExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitUncheckedExpression(this);
		}
	}
	public partial class SimpleNameExpressionContext : Primary_expression_startContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_argument_listContext type_argument_list() {
			return GetRuleContext<Type_argument_listContext>(0);
		}
		public SimpleNameExpressionContext(Primary_expression_startContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterSimpleNameExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitSimpleNameExpression(this);
		}
	}
	public partial class MemberAccessExpressionContext : Primary_expression_startContext {
		[System.Diagnostics.DebuggerNonUserCode] public Predefined_typeContext predefined_type() {
			return GetRuleContext<Predefined_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Qualified_alias_memberContext qualified_alias_member() {
			return GetRuleContext<Qualified_alias_memberContext>(0);
		}
		public MemberAccessExpressionContext(Primary_expression_startContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterMemberAccessExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitMemberAccessExpression(this);
		}
	}
	public partial class CheckedExpressionContext : Primary_expression_startContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CHECKED() { return GetToken(CSharpParser.CHECKED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		public CheckedExpressionContext(Primary_expression_startContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterCheckedExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitCheckedExpression(this);
		}
	}
	public partial class LiteralExpressionContext : Primary_expression_startContext {
		[System.Diagnostics.DebuggerNonUserCode] public LiteralContext literal() {
			return GetRuleContext<LiteralContext>(0);
		}
		public LiteralExpressionContext(Primary_expression_startContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterLiteralExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitLiteralExpression(this);
		}
	}
	public partial class NameofExpressionContext : Primary_expression_startContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NAMEOF() { return GetToken(CSharpParser.NAMEOF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DOT() { return GetTokens(CSharpParser.DOT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT(int i) {
			return GetToken(CSharpParser.DOT, i);
		}
		public NameofExpressionContext(Primary_expression_startContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterNameofExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitNameofExpression(this);
		}
	}

	[RuleVersion(0)]
	public Primary_expression_startContext primary_expression_start() {
		Primary_expression_startContext _localctx = new Primary_expression_startContext(Context, State);
		EnterRule(_localctx, 72, RULE_primary_expression_start);
		int _la;
		try {
			int _alt;
			State = 916;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,73,Context) ) {
			case 1:
				_localctx = new LiteralExpressionContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 795;
				literal();
				}
				break;
			case 2:
				_localctx = new SimpleNameExpressionContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 796;
				identifier();
				State = 798;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,58,Context) ) {
				case 1:
					{
					State = 797;
					type_argument_list();
					}
					break;
				}
				}
				break;
			case 3:
				_localctx = new ParenthesisExpressionsContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 800;
				Match(OPEN_PARENS);
				State = 801;
				expression();
				State = 802;
				Match(CLOSE_PARENS);
				}
				break;
			case 4:
				_localctx = new MemberAccessExpressionContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 804;
				predefined_type();
				}
				break;
			case 5:
				_localctx = new MemberAccessExpressionContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 805;
				qualified_alias_member();
				}
				break;
			case 6:
				_localctx = new LiteralAccessExpressionContext(_localctx);
				EnterOuterAlt(_localctx, 6);
				{
				State = 806;
				Match(LITERAL_ACCESS);
				}
				break;
			case 7:
				_localctx = new ThisReferenceExpressionContext(_localctx);
				EnterOuterAlt(_localctx, 7);
				{
				State = 807;
				Match(THIS);
				}
				break;
			case 8:
				_localctx = new BaseAccessExpressionContext(_localctx);
				EnterOuterAlt(_localctx, 8);
				{
				State = 808;
				Match(BASE);
				State = 818;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case DOT:
					{
					State = 809;
					Match(DOT);
					State = 810;
					identifier();
					State = 812;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,59,Context) ) {
					case 1:
						{
						State = 811;
						type_argument_list();
						}
						break;
					}
					}
					break;
				case OPEN_BRACKET:
					{
					State = 814;
					Match(OPEN_BRACKET);
					State = 815;
					expression_list();
					State = 816;
					Match(CLOSE_BRACKET);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				break;
			case 9:
				_localctx = new ObjectCreationExpressionContext(_localctx);
				EnterOuterAlt(_localctx, 9);
				{
				State = 820;
				Match(NEW);
				State = 849;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case ADD:
				case ALIAS:
				case ARGLIST:
				case ASCENDING:
				case ASYNC:
				case AWAIT:
				case BOOL:
				case BY:
				case BYTE:
				case CHAR:
				case DECIMAL:
				case DESCENDING:
				case DOUBLE:
				case DYNAMIC:
				case EQUALS:
				case FLOAT:
				case FROM:
				case GET:
				case GROUP:
				case INT:
				case INTO:
				case JOIN:
				case LET:
				case LONG:
				case NAMEOF:
				case OBJECT:
				case ON:
				case ORDERBY:
				case PARTIAL:
				case REMOVE:
				case SBYTE:
				case SELECT:
				case SET:
				case SHORT:
				case STRING:
				case UINT:
				case ULONG:
				case UNMANAGED:
				case USHORT:
				case VAR:
				case VOID:
				case WHEN:
				case WHERE:
				case YIELD:
				case IDENTIFIER:
				case OPEN_PARENS:
					{
					State = 821;
					type_();
					State = 843;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,64,Context) ) {
					case 1:
						{
						State = 822;
						object_creation_expression();
						}
						break;
					case 2:
						{
						State = 823;
						object_or_collection_initializer();
						}
						break;
					case 3:
						{
						State = 824;
						Match(OPEN_BRACKET);
						State = 825;
						expression_list();
						State = 826;
						Match(CLOSE_BRACKET);
						State = 830;
						ErrorHandler.Sync(this);
						_alt = Interpreter.AdaptivePredict(TokenStream,61,Context);
						while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
							if ( _alt==1 ) {
								{
								{
								State = 827;
								rank_specifier();
								}
								} 
							}
							State = 832;
							ErrorHandler.Sync(this);
							_alt = Interpreter.AdaptivePredict(TokenStream,61,Context);
						}
						State = 834;
						ErrorHandler.Sync(this);
						switch ( Interpreter.AdaptivePredict(TokenStream,62,Context) ) {
						case 1:
							{
							State = 833;
							array_initializer();
							}
							break;
						}
						}
						break;
					case 4:
						{
						State = 837;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						do {
							{
							{
							State = 836;
							rank_specifier();
							}
							}
							State = 839;
							ErrorHandler.Sync(this);
							_la = TokenStream.LA(1);
						} while ( _la==OPEN_BRACKET );
						State = 841;
						array_initializer();
						}
						break;
					}
					}
					break;
				case OPEN_BRACE:
					{
					State = 845;
					anonymous_object_initializer();
					}
					break;
				case OPEN_BRACKET:
					{
					State = 846;
					rank_specifier();
					State = 847;
					array_initializer();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				break;
			case 10:
				_localctx = new TupleExpressionContext(_localctx);
				EnterOuterAlt(_localctx, 10);
				{
				State = 851;
				Match(OPEN_PARENS);
				State = 852;
				argument();
				State = 855;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				do {
					{
					{
					State = 853;
					Match(COMMA);
					State = 854;
					argument();
					}
					}
					State = 857;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				} while ( _la==COMMA );
				State = 859;
				Match(CLOSE_PARENS);
				}
				break;
			case 11:
				_localctx = new TypeofExpressionContext(_localctx);
				EnterOuterAlt(_localctx, 11);
				{
				State = 861;
				Match(TYPEOF);
				State = 862;
				Match(OPEN_PARENS);
				State = 866;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,67,Context) ) {
				case 1:
					{
					State = 863;
					unbound_type_name();
					}
					break;
				case 2:
					{
					State = 864;
					type_();
					}
					break;
				case 3:
					{
					State = 865;
					Match(VOID);
					}
					break;
				}
				State = 868;
				Match(CLOSE_PARENS);
				}
				break;
			case 12:
				_localctx = new CheckedExpressionContext(_localctx);
				EnterOuterAlt(_localctx, 12);
				{
				State = 869;
				Match(CHECKED);
				State = 870;
				Match(OPEN_PARENS);
				State = 871;
				expression();
				State = 872;
				Match(CLOSE_PARENS);
				}
				break;
			case 13:
				_localctx = new UncheckedExpressionContext(_localctx);
				EnterOuterAlt(_localctx, 13);
				{
				State = 874;
				Match(UNCHECKED);
				State = 875;
				Match(OPEN_PARENS);
				State = 876;
				expression();
				State = 877;
				Match(CLOSE_PARENS);
				}
				break;
			case 14:
				_localctx = new DefaultValueExpressionContext(_localctx);
				EnterOuterAlt(_localctx, 14);
				{
				State = 879;
				Match(DEFAULT);
				State = 884;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,68,Context) ) {
				case 1:
					{
					State = 880;
					Match(OPEN_PARENS);
					State = 881;
					type_();
					State = 882;
					Match(CLOSE_PARENS);
					}
					break;
				}
				}
				break;
			case 15:
				_localctx = new AnonymousMethodExpressionContext(_localctx);
				EnterOuterAlt(_localctx, 15);
				{
				State = 887;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==ASYNC) {
					{
					State = 886;
					Match(ASYNC);
					}
				}

				State = 889;
				Match(DELEGATE);
				State = 895;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==OPEN_PARENS) {
					{
					State = 890;
					Match(OPEN_PARENS);
					State = 892;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (((((_la - 10)) & ~0x3f) == 0 && ((1L << (_la - 10)) & ((1L << (ADD - 10)) | (1L << (ALIAS - 10)) | (1L << (ARGLIST - 10)) | (1L << (ASCENDING - 10)) | (1L << (ASYNC - 10)) | (1L << (AWAIT - 10)) | (1L << (BOOL - 10)) | (1L << (BY - 10)) | (1L << (BYTE - 10)) | (1L << (CHAR - 10)) | (1L << (DECIMAL - 10)) | (1L << (DESCENDING - 10)) | (1L << (DOUBLE - 10)) | (1L << (DYNAMIC - 10)) | (1L << (EQUALS - 10)) | (1L << (FLOAT - 10)) | (1L << (FROM - 10)) | (1L << (GET - 10)) | (1L << (GROUP - 10)) | (1L << (IN - 10)) | (1L << (INT - 10)) | (1L << (INTO - 10)) | (1L << (JOIN - 10)) | (1L << (LET - 10)) | (1L << (LONG - 10)) | (1L << (NAMEOF - 10)) | (1L << (OBJECT - 10)) | (1L << (ON - 10)) | (1L << (ORDERBY - 10)) | (1L << (OUT - 10)))) != 0) || ((((_la - 75)) & ~0x3f) == 0 && ((1L << (_la - 75)) & ((1L << (PARTIAL - 75)) | (1L << (REF - 75)) | (1L << (REMOVE - 75)) | (1L << (SBYTE - 75)) | (1L << (SELECT - 75)) | (1L << (SET - 75)) | (1L << (SHORT - 75)) | (1L << (STRING - 75)) | (1L << (UINT - 75)) | (1L << (ULONG - 75)) | (1L << (UNMANAGED - 75)) | (1L << (USHORT - 75)) | (1L << (VAR - 75)) | (1L << (VOID - 75)) | (1L << (WHEN - 75)) | (1L << (WHERE - 75)) | (1L << (YIELD - 75)) | (1L << (IDENTIFIER - 75)) | (1L << (OPEN_PARENS - 75)))) != 0)) {
						{
						State = 891;
						explicit_anonymous_function_parameter_list();
						}
					}

					State = 894;
					Match(CLOSE_PARENS);
					}
				}

				State = 897;
				block();
				}
				break;
			case 16:
				_localctx = new SizeofExpressionContext(_localctx);
				EnterOuterAlt(_localctx, 16);
				{
				State = 898;
				Match(SIZEOF);
				State = 899;
				Match(OPEN_PARENS);
				State = 900;
				type_();
				State = 901;
				Match(CLOSE_PARENS);
				}
				break;
			case 17:
				_localctx = new NameofExpressionContext(_localctx);
				EnterOuterAlt(_localctx, 17);
				{
				State = 903;
				Match(NAMEOF);
				State = 904;
				Match(OPEN_PARENS);
				State = 910;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,72,Context);
				while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						State = 905;
						identifier();
						State = 906;
						Match(DOT);
						}
						} 
					}
					State = 912;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,72,Context);
				}
				State = 913;
				identifier();
				State = 914;
				Match(CLOSE_PARENS);
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

	public partial class Throwable_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Throw_expressionContext throw_expression() {
			return GetRuleContext<Throw_expressionContext>(0);
		}
		public Throwable_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_throwable_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterThrowable_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitThrowable_expression(this);
		}
	}

	[RuleVersion(0)]
	public Throwable_expressionContext throwable_expression() {
		Throwable_expressionContext _localctx = new Throwable_expressionContext(Context, State);
		EnterRule(_localctx, 74, RULE_throwable_expression);
		try {
			State = 920;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ADD:
			case ALIAS:
			case ARGLIST:
			case ASCENDING:
			case ASYNC:
			case AWAIT:
			case BASE:
			case BOOL:
			case BY:
			case BYTE:
			case CHAR:
			case CHECKED:
			case DECIMAL:
			case DEFAULT:
			case DELEGATE:
			case DESCENDING:
			case DOUBLE:
			case DYNAMIC:
			case EQUALS:
			case FALSE:
			case FLOAT:
			case FROM:
			case GET:
			case GROUP:
			case INT:
			case INTO:
			case JOIN:
			case LET:
			case LONG:
			case NAMEOF:
			case NEW:
			case NULL_:
			case OBJECT:
			case ON:
			case ORDERBY:
			case PARTIAL:
			case REF:
			case REMOVE:
			case SBYTE:
			case SELECT:
			case SET:
			case SHORT:
			case SIZEOF:
			case STRING:
			case THIS:
			case TRUE:
			case TYPEOF:
			case UINT:
			case ULONG:
			case UNCHECKED:
			case UNMANAGED:
			case USHORT:
			case VAR:
			case WHEN:
			case WHERE:
			case YIELD:
			case IDENTIFIER:
			case LITERAL_ACCESS:
			case INTEGER_LITERAL:
			case HEX_INTEGER_LITERAL:
			case BIN_INTEGER_LITERAL:
			case REAL_LITERAL:
			case CHARACTER_LITERAL:
			case REGULAR_STRING:
			case VERBATIUM_STRING:
			case INTERPOLATED_REGULAR_STRING_START:
			case INTERPOLATED_VERBATIUM_STRING_START:
			case OPEN_PARENS:
			case PLUS:
			case MINUS:
			case STAR:
			case AMP:
			case CARET:
			case BANG:
			case TILDE:
			case OP_INC:
			case OP_DEC:
			case OP_RANGE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 918;
				expression();
				}
				break;
			case THROW:
				EnterOuterAlt(_localctx, 2);
				{
				State = 919;
				throw_expression();
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

	public partial class Throw_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THROW() { return GetToken(CSharpParser.THROW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public Throw_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_throw_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterThrow_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitThrow_expression(this);
		}
	}

	[RuleVersion(0)]
	public Throw_expressionContext throw_expression() {
		Throw_expressionContext _localctx = new Throw_expressionContext(Context, State);
		EnterRule(_localctx, 76, RULE_throw_expression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 922;
			Match(THROW);
			State = 923;
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

	public partial class Member_accessContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(CSharpParser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERR() { return GetToken(CSharpParser.INTERR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_argument_listContext type_argument_list() {
			return GetRuleContext<Type_argument_listContext>(0);
		}
		public Member_accessContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_member_access; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterMember_access(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitMember_access(this);
		}
	}

	[RuleVersion(0)]
	public Member_accessContext member_access() {
		Member_accessContext _localctx = new Member_accessContext(Context, State);
		EnterRule(_localctx, 78, RULE_member_access);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 926;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==INTERR) {
				{
				State = 925;
				Match(INTERR);
				}
			}

			State = 928;
			Match(DOT);
			State = 929;
			identifier();
			State = 931;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,76,Context) ) {
			case 1:
				{
				State = 930;
				type_argument_list();
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

	public partial class Bracket_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACKET() { return GetToken(CSharpParser.OPEN_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Indexer_argumentContext[] indexer_argument() {
			return GetRuleContexts<Indexer_argumentContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Indexer_argumentContext indexer_argument(int i) {
			return GetRuleContext<Indexer_argumentContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACKET() { return GetToken(CSharpParser.CLOSE_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERR() { return GetToken(CSharpParser.INTERR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Bracket_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_bracket_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterBracket_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitBracket_expression(this);
		}
	}

	[RuleVersion(0)]
	public Bracket_expressionContext bracket_expression() {
		Bracket_expressionContext _localctx = new Bracket_expressionContext(Context, State);
		EnterRule(_localctx, 80, RULE_bracket_expression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 934;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==INTERR) {
				{
				State = 933;
				Match(INTERR);
				}
			}

			State = 936;
			Match(OPEN_BRACKET);
			State = 937;
			indexer_argument();
			State = 942;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 938;
				Match(COMMA);
				State = 939;
				indexer_argument();
				}
				}
				State = 944;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 945;
			Match(CLOSE_BRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Indexer_argumentContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(CSharpParser.COLON, 0); }
		public Indexer_argumentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_indexer_argument; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterIndexer_argument(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitIndexer_argument(this);
		}
	}

	[RuleVersion(0)]
	public Indexer_argumentContext indexer_argument() {
		Indexer_argumentContext _localctx = new Indexer_argumentContext(Context, State);
		EnterRule(_localctx, 82, RULE_indexer_argument);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 950;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,79,Context) ) {
			case 1:
				{
				State = 947;
				identifier();
				State = 948;
				Match(COLON);
				}
				break;
			}
			State = 952;
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

	public partial class Predefined_typeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BOOL() { return GetToken(CSharpParser.BOOL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BYTE() { return GetToken(CSharpParser.BYTE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CHAR() { return GetToken(CSharpParser.CHAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DECIMAL() { return GetToken(CSharpParser.DECIMAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOUBLE() { return GetToken(CSharpParser.DOUBLE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FLOAT() { return GetToken(CSharpParser.FLOAT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT() { return GetToken(CSharpParser.INT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LONG() { return GetToken(CSharpParser.LONG, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OBJECT() { return GetToken(CSharpParser.OBJECT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SBYTE() { return GetToken(CSharpParser.SBYTE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SHORT() { return GetToken(CSharpParser.SHORT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRING() { return GetToken(CSharpParser.STRING, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UINT() { return GetToken(CSharpParser.UINT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ULONG() { return GetToken(CSharpParser.ULONG, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode USHORT() { return GetToken(CSharpParser.USHORT, 0); }
		public Predefined_typeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_predefined_type; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterPredefined_type(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitPredefined_type(this);
		}
	}

	[RuleVersion(0)]
	public Predefined_typeContext predefined_type() {
		Predefined_typeContext _localctx = new Predefined_typeContext(Context, State);
		EnterRule(_localctx, 84, RULE_predefined_type);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 954;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BOOL) | (1L << BYTE) | (1L << CHAR) | (1L << DECIMAL) | (1L << DOUBLE) | (1L << FLOAT) | (1L << INT) | (1L << LONG))) != 0) || ((((_la - 68)) & ~0x3f) == 0 && ((1L << (_la - 68)) & ((1L << (OBJECT - 68)) | (1L << (SBYTE - 68)) | (1L << (SHORT - 68)) | (1L << (STRING - 68)) | (1L << (UINT - 68)) | (1L << (ULONG - 68)) | (1L << (USHORT - 68)))) != 0)) ) {
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

	public partial class Expression_listContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Expression_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression_list; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterExpression_list(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitExpression_list(this);
		}
	}

	[RuleVersion(0)]
	public Expression_listContext expression_list() {
		Expression_listContext _localctx = new Expression_listContext(Context, State);
		EnterRule(_localctx, 86, RULE_expression_list);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 956;
			expression();
			State = 961;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 957;
				Match(COMMA);
				State = 958;
				expression();
				}
				}
				State = 963;
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

	public partial class Object_or_collection_initializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Object_initializerContext object_initializer() {
			return GetRuleContext<Object_initializerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Collection_initializerContext collection_initializer() {
			return GetRuleContext<Collection_initializerContext>(0);
		}
		public Object_or_collection_initializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_object_or_collection_initializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterObject_or_collection_initializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitObject_or_collection_initializer(this);
		}
	}

	[RuleVersion(0)]
	public Object_or_collection_initializerContext object_or_collection_initializer() {
		Object_or_collection_initializerContext _localctx = new Object_or_collection_initializerContext(Context, State);
		EnterRule(_localctx, 88, RULE_object_or_collection_initializer);
		try {
			State = 966;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,81,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 964;
				object_initializer();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 965;
				collection_initializer();
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

	public partial class Object_initializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Member_initializer_listContext member_initializer_list() {
			return GetRuleContext<Member_initializer_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(CSharpParser.COMMA, 0); }
		public Object_initializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_object_initializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterObject_initializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitObject_initializer(this);
		}
	}

	[RuleVersion(0)]
	public Object_initializerContext object_initializer() {
		Object_initializerContext _localctx = new Object_initializerContext(Context, State);
		EnterRule(_localctx, 90, RULE_object_initializer);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 968;
			Match(OPEN_BRACE);
			State = 973;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BY) | (1L << DESCENDING) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << INTO) | (1L << JOIN) | (1L << LET))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REMOVE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (UNMANAGED - 64)) | (1L << (VAR - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (OPEN_BRACKET - 64)))) != 0)) {
				{
				State = 969;
				member_initializer_list();
				State = 971;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==COMMA) {
					{
					State = 970;
					Match(COMMA);
					}
				}

				}
			}

			State = 975;
			Match(CLOSE_BRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Member_initializer_listContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Member_initializerContext[] member_initializer() {
			return GetRuleContexts<Member_initializerContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Member_initializerContext member_initializer(int i) {
			return GetRuleContext<Member_initializerContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Member_initializer_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_member_initializer_list; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterMember_initializer_list(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitMember_initializer_list(this);
		}
	}

	[RuleVersion(0)]
	public Member_initializer_listContext member_initializer_list() {
		Member_initializer_listContext _localctx = new Member_initializer_listContext(Context, State);
		EnterRule(_localctx, 92, RULE_member_initializer_list);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 977;
			member_initializer();
			State = 982;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,84,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 978;
					Match(COMMA);
					State = 979;
					member_initializer();
					}
					} 
				}
				State = 984;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,84,Context);
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

	public partial class Member_initializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGNMENT() { return GetToken(CSharpParser.ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Initializer_valueContext initializer_value() {
			return GetRuleContext<Initializer_valueContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACKET() { return GetToken(CSharpParser.OPEN_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACKET() { return GetToken(CSharpParser.CLOSE_BRACKET, 0); }
		public Member_initializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_member_initializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterMember_initializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitMember_initializer(this);
		}
	}

	[RuleVersion(0)]
	public Member_initializerContext member_initializer() {
		Member_initializerContext _localctx = new Member_initializerContext(Context, State);
		EnterRule(_localctx, 94, RULE_member_initializer);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 990;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ADD:
			case ALIAS:
			case ARGLIST:
			case ASCENDING:
			case ASYNC:
			case AWAIT:
			case BY:
			case DESCENDING:
			case DYNAMIC:
			case EQUALS:
			case FROM:
			case GET:
			case GROUP:
			case INTO:
			case JOIN:
			case LET:
			case NAMEOF:
			case ON:
			case ORDERBY:
			case PARTIAL:
			case REMOVE:
			case SELECT:
			case SET:
			case UNMANAGED:
			case VAR:
			case WHEN:
			case WHERE:
			case YIELD:
			case IDENTIFIER:
				{
				State = 985;
				identifier();
				}
				break;
			case OPEN_BRACKET:
				{
				State = 986;
				Match(OPEN_BRACKET);
				State = 987;
				expression();
				State = 988;
				Match(CLOSE_BRACKET);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 992;
			Match(ASSIGNMENT);
			State = 993;
			initializer_value();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Initializer_valueContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Object_or_collection_initializerContext object_or_collection_initializer() {
			return GetRuleContext<Object_or_collection_initializerContext>(0);
		}
		public Initializer_valueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_initializer_value; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterInitializer_value(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitInitializer_value(this);
		}
	}

	[RuleVersion(0)]
	public Initializer_valueContext initializer_value() {
		Initializer_valueContext _localctx = new Initializer_valueContext(Context, State);
		EnterRule(_localctx, 96, RULE_initializer_value);
		try {
			State = 997;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ADD:
			case ALIAS:
			case ARGLIST:
			case ASCENDING:
			case ASYNC:
			case AWAIT:
			case BASE:
			case BOOL:
			case BY:
			case BYTE:
			case CHAR:
			case CHECKED:
			case DECIMAL:
			case DEFAULT:
			case DELEGATE:
			case DESCENDING:
			case DOUBLE:
			case DYNAMIC:
			case EQUALS:
			case FALSE:
			case FLOAT:
			case FROM:
			case GET:
			case GROUP:
			case INT:
			case INTO:
			case JOIN:
			case LET:
			case LONG:
			case NAMEOF:
			case NEW:
			case NULL_:
			case OBJECT:
			case ON:
			case ORDERBY:
			case PARTIAL:
			case REF:
			case REMOVE:
			case SBYTE:
			case SELECT:
			case SET:
			case SHORT:
			case SIZEOF:
			case STRING:
			case THIS:
			case TRUE:
			case TYPEOF:
			case UINT:
			case ULONG:
			case UNCHECKED:
			case UNMANAGED:
			case USHORT:
			case VAR:
			case WHEN:
			case WHERE:
			case YIELD:
			case IDENTIFIER:
			case LITERAL_ACCESS:
			case INTEGER_LITERAL:
			case HEX_INTEGER_LITERAL:
			case BIN_INTEGER_LITERAL:
			case REAL_LITERAL:
			case CHARACTER_LITERAL:
			case REGULAR_STRING:
			case VERBATIUM_STRING:
			case INTERPOLATED_REGULAR_STRING_START:
			case INTERPOLATED_VERBATIUM_STRING_START:
			case OPEN_PARENS:
			case PLUS:
			case MINUS:
			case STAR:
			case AMP:
			case CARET:
			case BANG:
			case TILDE:
			case OP_INC:
			case OP_DEC:
			case OP_RANGE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 995;
				expression();
				}
				break;
			case OPEN_BRACE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 996;
				object_or_collection_initializer();
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

	public partial class Collection_initializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Element_initializerContext[] element_initializer() {
			return GetRuleContexts<Element_initializerContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Element_initializerContext element_initializer(int i) {
			return GetRuleContext<Element_initializerContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Collection_initializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_collection_initializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterCollection_initializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitCollection_initializer(this);
		}
	}

	[RuleVersion(0)]
	public Collection_initializerContext collection_initializer() {
		Collection_initializerContext _localctx = new Collection_initializerContext(Context, State);
		EnterRule(_localctx, 98, RULE_collection_initializer);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 999;
			Match(OPEN_BRACE);
			State = 1000;
			element_initializer();
			State = 1005;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,87,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1001;
					Match(COMMA);
					State = 1002;
					element_initializer();
					}
					} 
				}
				State = 1007;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,87,Context);
			}
			State = 1009;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==COMMA) {
				{
				State = 1008;
				Match(COMMA);
				}
			}

			State = 1011;
			Match(CLOSE_BRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Element_initializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Non_assignment_expressionContext non_assignment_expression() {
			return GetRuleContext<Non_assignment_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Expression_listContext expression_list() {
			return GetRuleContext<Expression_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		public Element_initializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_element_initializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterElement_initializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitElement_initializer(this);
		}
	}

	[RuleVersion(0)]
	public Element_initializerContext element_initializer() {
		Element_initializerContext _localctx = new Element_initializerContext(Context, State);
		EnterRule(_localctx, 100, RULE_element_initializer);
		try {
			State = 1018;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ADD:
			case ALIAS:
			case ARGLIST:
			case ASCENDING:
			case ASYNC:
			case AWAIT:
			case BASE:
			case BOOL:
			case BY:
			case BYTE:
			case CHAR:
			case CHECKED:
			case DECIMAL:
			case DEFAULT:
			case DELEGATE:
			case DESCENDING:
			case DOUBLE:
			case DYNAMIC:
			case EQUALS:
			case FALSE:
			case FLOAT:
			case FROM:
			case GET:
			case GROUP:
			case INT:
			case INTO:
			case JOIN:
			case LET:
			case LONG:
			case NAMEOF:
			case NEW:
			case NULL_:
			case OBJECT:
			case ON:
			case ORDERBY:
			case PARTIAL:
			case REMOVE:
			case SBYTE:
			case SELECT:
			case SET:
			case SHORT:
			case SIZEOF:
			case STRING:
			case THIS:
			case TRUE:
			case TYPEOF:
			case UINT:
			case ULONG:
			case UNCHECKED:
			case UNMANAGED:
			case USHORT:
			case VAR:
			case WHEN:
			case WHERE:
			case YIELD:
			case IDENTIFIER:
			case LITERAL_ACCESS:
			case INTEGER_LITERAL:
			case HEX_INTEGER_LITERAL:
			case BIN_INTEGER_LITERAL:
			case REAL_LITERAL:
			case CHARACTER_LITERAL:
			case REGULAR_STRING:
			case VERBATIUM_STRING:
			case INTERPOLATED_REGULAR_STRING_START:
			case INTERPOLATED_VERBATIUM_STRING_START:
			case OPEN_PARENS:
			case PLUS:
			case MINUS:
			case STAR:
			case AMP:
			case CARET:
			case BANG:
			case TILDE:
			case OP_INC:
			case OP_DEC:
			case OP_RANGE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1013;
				non_assignment_expression();
				}
				break;
			case OPEN_BRACE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1014;
				Match(OPEN_BRACE);
				State = 1015;
				expression_list();
				State = 1016;
				Match(CLOSE_BRACE);
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

	public partial class Anonymous_object_initializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Member_declarator_listContext member_declarator_list() {
			return GetRuleContext<Member_declarator_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(CSharpParser.COMMA, 0); }
		public Anonymous_object_initializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_anonymous_object_initializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAnonymous_object_initializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAnonymous_object_initializer(this);
		}
	}

	[RuleVersion(0)]
	public Anonymous_object_initializerContext anonymous_object_initializer() {
		Anonymous_object_initializerContext _localctx = new Anonymous_object_initializerContext(Context, State);
		EnterRule(_localctx, 102, RULE_anonymous_object_initializer);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1020;
			Match(OPEN_BRACE);
			State = 1025;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 10)) & ~0x3f) == 0 && ((1L << (_la - 10)) & ((1L << (ADD - 10)) | (1L << (ALIAS - 10)) | (1L << (ARGLIST - 10)) | (1L << (ASCENDING - 10)) | (1L << (ASYNC - 10)) | (1L << (AWAIT - 10)) | (1L << (BASE - 10)) | (1L << (BOOL - 10)) | (1L << (BY - 10)) | (1L << (BYTE - 10)) | (1L << (CHAR - 10)) | (1L << (CHECKED - 10)) | (1L << (DECIMAL - 10)) | (1L << (DEFAULT - 10)) | (1L << (DELEGATE - 10)) | (1L << (DESCENDING - 10)) | (1L << (DOUBLE - 10)) | (1L << (DYNAMIC - 10)) | (1L << (EQUALS - 10)) | (1L << (FALSE - 10)) | (1L << (FLOAT - 10)) | (1L << (FROM - 10)) | (1L << (GET - 10)) | (1L << (GROUP - 10)) | (1L << (INT - 10)) | (1L << (INTO - 10)) | (1L << (JOIN - 10)) | (1L << (LET - 10)) | (1L << (LONG - 10)) | (1L << (NAMEOF - 10)) | (1L << (NEW - 10)) | (1L << (NULL_ - 10)) | (1L << (OBJECT - 10)) | (1L << (ON - 10)) | (1L << (ORDERBY - 10)))) != 0) || ((((_la - 75)) & ~0x3f) == 0 && ((1L << (_la - 75)) & ((1L << (PARTIAL - 75)) | (1L << (REMOVE - 75)) | (1L << (SBYTE - 75)) | (1L << (SELECT - 75)) | (1L << (SET - 75)) | (1L << (SHORT - 75)) | (1L << (SIZEOF - 75)) | (1L << (STRING - 75)) | (1L << (THIS - 75)) | (1L << (TRUE - 75)) | (1L << (TYPEOF - 75)) | (1L << (UINT - 75)) | (1L << (ULONG - 75)) | (1L << (UNCHECKED - 75)) | (1L << (UNMANAGED - 75)) | (1L << (USHORT - 75)) | (1L << (VAR - 75)) | (1L << (WHEN - 75)) | (1L << (WHERE - 75)) | (1L << (YIELD - 75)) | (1L << (IDENTIFIER - 75)) | (1L << (LITERAL_ACCESS - 75)) | (1L << (INTEGER_LITERAL - 75)) | (1L << (HEX_INTEGER_LITERAL - 75)) | (1L << (BIN_INTEGER_LITERAL - 75)) | (1L << (REAL_LITERAL - 75)) | (1L << (CHARACTER_LITERAL - 75)) | (1L << (REGULAR_STRING - 75)) | (1L << (VERBATIUM_STRING - 75)) | (1L << (INTERPOLATED_REGULAR_STRING_START - 75)) | (1L << (INTERPOLATED_VERBATIUM_STRING_START - 75)) | (1L << (OPEN_PARENS - 75)))) != 0)) {
				{
				State = 1021;
				member_declarator_list();
				State = 1023;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==COMMA) {
					{
					State = 1022;
					Match(COMMA);
					}
				}

				}
			}

			State = 1027;
			Match(CLOSE_BRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Member_declarator_listContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Member_declaratorContext[] member_declarator() {
			return GetRuleContexts<Member_declaratorContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Member_declaratorContext member_declarator(int i) {
			return GetRuleContext<Member_declaratorContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Member_declarator_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_member_declarator_list; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterMember_declarator_list(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitMember_declarator_list(this);
		}
	}

	[RuleVersion(0)]
	public Member_declarator_listContext member_declarator_list() {
		Member_declarator_listContext _localctx = new Member_declarator_listContext(Context, State);
		EnterRule(_localctx, 104, RULE_member_declarator_list);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1029;
			member_declarator();
			State = 1034;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,92,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1030;
					Match(COMMA);
					State = 1031;
					member_declarator();
					}
					} 
				}
				State = 1036;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,92,Context);
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

	public partial class Member_declaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Primary_expressionContext primary_expression() {
			return GetRuleContext<Primary_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGNMENT() { return GetToken(CSharpParser.ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public Member_declaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_member_declarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterMember_declarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitMember_declarator(this);
		}
	}

	[RuleVersion(0)]
	public Member_declaratorContext member_declarator() {
		Member_declaratorContext _localctx = new Member_declaratorContext(Context, State);
		EnterRule(_localctx, 106, RULE_member_declarator);
		try {
			State = 1042;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,93,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1037;
				primary_expression();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1038;
				identifier();
				State = 1039;
				Match(ASSIGNMENT);
				State = 1040;
				expression();
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

	public partial class Unbound_type_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOUBLE_COLON() { return GetToken(CSharpParser.DOUBLE_COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DOT() { return GetTokens(CSharpParser.DOT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT(int i) {
			return GetToken(CSharpParser.DOT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Generic_dimension_specifierContext[] generic_dimension_specifier() {
			return GetRuleContexts<Generic_dimension_specifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Generic_dimension_specifierContext generic_dimension_specifier(int i) {
			return GetRuleContext<Generic_dimension_specifierContext>(i);
		}
		public Unbound_type_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unbound_type_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterUnbound_type_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitUnbound_type_name(this);
		}
	}

	[RuleVersion(0)]
	public Unbound_type_nameContext unbound_type_name() {
		Unbound_type_nameContext _localctx = new Unbound_type_nameContext(Context, State);
		EnterRule(_localctx, 108, RULE_unbound_type_name);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1044;
			identifier();
			State = 1053;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case CLOSE_PARENS:
			case DOT:
			case LT:
				{
				State = 1046;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 1045;
					generic_dimension_specifier();
					}
				}

				}
				break;
			case DOUBLE_COLON:
				{
				State = 1048;
				Match(DOUBLE_COLON);
				State = 1049;
				identifier();
				State = 1051;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 1050;
					generic_dimension_specifier();
					}
				}

				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 1062;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==DOT) {
				{
				{
				State = 1055;
				Match(DOT);
				State = 1056;
				identifier();
				State = 1058;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 1057;
					generic_dimension_specifier();
					}
				}

				}
				}
				State = 1064;
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

	public partial class Generic_dimension_specifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LT() { return GetToken(CSharpParser.LT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT() { return GetToken(CSharpParser.GT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Generic_dimension_specifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_generic_dimension_specifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterGeneric_dimension_specifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitGeneric_dimension_specifier(this);
		}
	}

	[RuleVersion(0)]
	public Generic_dimension_specifierContext generic_dimension_specifier() {
		Generic_dimension_specifierContext _localctx = new Generic_dimension_specifierContext(Context, State);
		EnterRule(_localctx, 110, RULE_generic_dimension_specifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1065;
			Match(LT);
			State = 1069;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1066;
				Match(COMMA);
				}
				}
				State = 1071;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1072;
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

	public partial class IsTypeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Base_typeContext base_type() {
			return GetRuleContext<Base_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Rank_specifierContext[] rank_specifier() {
			return GetRuleContexts<Rank_specifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Rank_specifierContext rank_specifier(int i) {
			return GetRuleContext<Rank_specifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] STAR() { return GetTokens(CSharpParser.STAR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STAR(int i) {
			return GetToken(CSharpParser.STAR, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERR() { return GetToken(CSharpParser.INTERR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IsTypePatternArmsContext isTypePatternArms() {
			return GetRuleContext<IsTypePatternArmsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public IsTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_isType; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterIsType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitIsType(this);
		}
	}

	[RuleVersion(0)]
	public IsTypeContext isType() {
		IsTypeContext _localctx = new IsTypeContext(Context, State);
		EnterRule(_localctx, 112, RULE_isType);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1074;
			base_type();
			State = 1079;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,101,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					State = 1077;
					ErrorHandler.Sync(this);
					switch (TokenStream.LA(1)) {
					case OPEN_BRACKET:
						{
						State = 1075;
						rank_specifier();
						}
						break;
					case STAR:
						{
						State = 1076;
						Match(STAR);
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					} 
				}
				State = 1081;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,101,Context);
			}
			State = 1083;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,102,Context) ) {
			case 1:
				{
				State = 1082;
				Match(INTERR);
				}
				break;
			}
			State = 1086;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,103,Context) ) {
			case 1:
				{
				State = 1085;
				isTypePatternArms();
				}
				break;
			}
			State = 1089;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,104,Context) ) {
			case 1:
				{
				State = 1088;
				identifier();
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

	public partial class IsTypePatternArmsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IsTypePatternArmContext[] isTypePatternArm() {
			return GetRuleContexts<IsTypePatternArmContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public IsTypePatternArmContext isTypePatternArm(int i) {
			return GetRuleContext<IsTypePatternArmContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public IsTypePatternArmsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_isTypePatternArms; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterIsTypePatternArms(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitIsTypePatternArms(this);
		}
	}

	[RuleVersion(0)]
	public IsTypePatternArmsContext isTypePatternArms() {
		IsTypePatternArmsContext _localctx = new IsTypePatternArmsContext(Context, State);
		EnterRule(_localctx, 114, RULE_isTypePatternArms);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1091;
			Match(OPEN_BRACE);
			State = 1092;
			isTypePatternArm();
			State = 1097;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1093;
				Match(COMMA);
				State = 1094;
				isTypePatternArm();
				}
				}
				State = 1099;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1100;
			Match(CLOSE_BRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IsTypePatternArmContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(CSharpParser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public IsTypePatternArmContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_isTypePatternArm; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterIsTypePatternArm(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitIsTypePatternArm(this);
		}
	}

	[RuleVersion(0)]
	public IsTypePatternArmContext isTypePatternArm() {
		IsTypePatternArmContext _localctx = new IsTypePatternArmContext(Context, State);
		EnterRule(_localctx, 116, RULE_isTypePatternArm);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1102;
			identifier();
			State = 1103;
			Match(COLON);
			State = 1104;
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

	public partial class Lambda_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Anonymous_function_signatureContext anonymous_function_signature() {
			return GetRuleContext<Anonymous_function_signatureContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Right_arrowContext right_arrow() {
			return GetRuleContext<Right_arrowContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Anonymous_function_bodyContext anonymous_function_body() {
			return GetRuleContext<Anonymous_function_bodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASYNC() { return GetToken(CSharpParser.ASYNC, 0); }
		public Lambda_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lambda_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterLambda_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitLambda_expression(this);
		}
	}

	[RuleVersion(0)]
	public Lambda_expressionContext lambda_expression() {
		Lambda_expressionContext _localctx = new Lambda_expressionContext(Context, State);
		EnterRule(_localctx, 118, RULE_lambda_expression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1107;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,106,Context) ) {
			case 1:
				{
				State = 1106;
				Match(ASYNC);
				}
				break;
			}
			State = 1109;
			anonymous_function_signature();
			State = 1110;
			right_arrow();
			State = 1111;
			anonymous_function_body();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Anonymous_function_signatureContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Explicit_anonymous_function_parameter_listContext explicit_anonymous_function_parameter_list() {
			return GetRuleContext<Explicit_anonymous_function_parameter_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Implicit_anonymous_function_parameter_listContext implicit_anonymous_function_parameter_list() {
			return GetRuleContext<Implicit_anonymous_function_parameter_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public Anonymous_function_signatureContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_anonymous_function_signature; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAnonymous_function_signature(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAnonymous_function_signature(this);
		}
	}

	[RuleVersion(0)]
	public Anonymous_function_signatureContext anonymous_function_signature() {
		Anonymous_function_signatureContext _localctx = new Anonymous_function_signatureContext(Context, State);
		EnterRule(_localctx, 120, RULE_anonymous_function_signature);
		try {
			State = 1124;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,107,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1113;
				Match(OPEN_PARENS);
				State = 1114;
				Match(CLOSE_PARENS);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1115;
				Match(OPEN_PARENS);
				State = 1116;
				explicit_anonymous_function_parameter_list();
				State = 1117;
				Match(CLOSE_PARENS);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1119;
				Match(OPEN_PARENS);
				State = 1120;
				implicit_anonymous_function_parameter_list();
				State = 1121;
				Match(CLOSE_PARENS);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1123;
				identifier();
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

	public partial class Explicit_anonymous_function_parameter_listContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Explicit_anonymous_function_parameterContext[] explicit_anonymous_function_parameter() {
			return GetRuleContexts<Explicit_anonymous_function_parameterContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Explicit_anonymous_function_parameterContext explicit_anonymous_function_parameter(int i) {
			return GetRuleContext<Explicit_anonymous_function_parameterContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Explicit_anonymous_function_parameter_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_explicit_anonymous_function_parameter_list; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterExplicit_anonymous_function_parameter_list(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitExplicit_anonymous_function_parameter_list(this);
		}
	}

	[RuleVersion(0)]
	public Explicit_anonymous_function_parameter_listContext explicit_anonymous_function_parameter_list() {
		Explicit_anonymous_function_parameter_listContext _localctx = new Explicit_anonymous_function_parameter_listContext(Context, State);
		EnterRule(_localctx, 122, RULE_explicit_anonymous_function_parameter_list);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1126;
			explicit_anonymous_function_parameter();
			State = 1131;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1127;
				Match(COMMA);
				State = 1128;
				explicit_anonymous_function_parameter();
				}
				}
				State = 1133;
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

	public partial class Explicit_anonymous_function_parameterContext : ParserRuleContext {
		public IToken refout;
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REF() { return GetToken(CSharpParser.REF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OUT() { return GetToken(CSharpParser.OUT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IN() { return GetToken(CSharpParser.IN, 0); }
		public Explicit_anonymous_function_parameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_explicit_anonymous_function_parameter; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterExplicit_anonymous_function_parameter(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitExplicit_anonymous_function_parameter(this);
		}
	}

	[RuleVersion(0)]
	public Explicit_anonymous_function_parameterContext explicit_anonymous_function_parameter() {
		Explicit_anonymous_function_parameterContext _localctx = new Explicit_anonymous_function_parameterContext(Context, State);
		EnterRule(_localctx, 124, RULE_explicit_anonymous_function_parameter);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1135;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 54)) & ~0x3f) == 0 && ((1L << (_la - 54)) & ((1L << (IN - 54)) | (1L << (OUT - 54)) | (1L << (REF - 54)))) != 0)) {
				{
				State = 1134;
				_localctx.refout = TokenStream.LT(1);
				_la = TokenStream.LA(1);
				if ( !(((((_la - 54)) & ~0x3f) == 0 && ((1L << (_la - 54)) & ((1L << (IN - 54)) | (1L << (OUT - 54)) | (1L << (REF - 54)))) != 0)) ) {
					_localctx.refout = ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
			}

			State = 1137;
			type_();
			State = 1138;
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

	public partial class Implicit_anonymous_function_parameter_listContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Implicit_anonymous_function_parameter_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_implicit_anonymous_function_parameter_list; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterImplicit_anonymous_function_parameter_list(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitImplicit_anonymous_function_parameter_list(this);
		}
	}

	[RuleVersion(0)]
	public Implicit_anonymous_function_parameter_listContext implicit_anonymous_function_parameter_list() {
		Implicit_anonymous_function_parameter_listContext _localctx = new Implicit_anonymous_function_parameter_listContext(Context, State);
		EnterRule(_localctx, 126, RULE_implicit_anonymous_function_parameter_list);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1140;
			identifier();
			State = 1145;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1141;
				Match(COMMA);
				State = 1142;
				identifier();
				}
				}
				State = 1147;
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

	public partial class Anonymous_function_bodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Throwable_expressionContext throwable_expression() {
			return GetRuleContext<Throwable_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public Anonymous_function_bodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_anonymous_function_body; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAnonymous_function_body(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAnonymous_function_body(this);
		}
	}

	[RuleVersion(0)]
	public Anonymous_function_bodyContext anonymous_function_body() {
		Anonymous_function_bodyContext _localctx = new Anonymous_function_bodyContext(Context, State);
		EnterRule(_localctx, 128, RULE_anonymous_function_body);
		try {
			State = 1150;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ADD:
			case ALIAS:
			case ARGLIST:
			case ASCENDING:
			case ASYNC:
			case AWAIT:
			case BASE:
			case BOOL:
			case BY:
			case BYTE:
			case CHAR:
			case CHECKED:
			case DECIMAL:
			case DEFAULT:
			case DELEGATE:
			case DESCENDING:
			case DOUBLE:
			case DYNAMIC:
			case EQUALS:
			case FALSE:
			case FLOAT:
			case FROM:
			case GET:
			case GROUP:
			case INT:
			case INTO:
			case JOIN:
			case LET:
			case LONG:
			case NAMEOF:
			case NEW:
			case NULL_:
			case OBJECT:
			case ON:
			case ORDERBY:
			case PARTIAL:
			case REF:
			case REMOVE:
			case SBYTE:
			case SELECT:
			case SET:
			case SHORT:
			case SIZEOF:
			case STRING:
			case THIS:
			case THROW:
			case TRUE:
			case TYPEOF:
			case UINT:
			case ULONG:
			case UNCHECKED:
			case UNMANAGED:
			case USHORT:
			case VAR:
			case WHEN:
			case WHERE:
			case YIELD:
			case IDENTIFIER:
			case LITERAL_ACCESS:
			case INTEGER_LITERAL:
			case HEX_INTEGER_LITERAL:
			case BIN_INTEGER_LITERAL:
			case REAL_LITERAL:
			case CHARACTER_LITERAL:
			case REGULAR_STRING:
			case VERBATIUM_STRING:
			case INTERPOLATED_REGULAR_STRING_START:
			case INTERPOLATED_VERBATIUM_STRING_START:
			case OPEN_PARENS:
			case PLUS:
			case MINUS:
			case STAR:
			case AMP:
			case CARET:
			case BANG:
			case TILDE:
			case OP_INC:
			case OP_DEC:
			case OP_RANGE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1148;
				throwable_expression();
				}
				break;
			case OPEN_BRACE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1149;
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

	public partial class Query_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public From_clauseContext from_clause() {
			return GetRuleContext<From_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Query_bodyContext query_body() {
			return GetRuleContext<Query_bodyContext>(0);
		}
		public Query_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_query_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterQuery_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitQuery_expression(this);
		}
	}

	[RuleVersion(0)]
	public Query_expressionContext query_expression() {
		Query_expressionContext _localctx = new Query_expressionContext(Context, State);
		EnterRule(_localctx, 130, RULE_query_expression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1152;
			from_clause();
			State = 1153;
			query_body();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class From_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FROM() { return GetToken(CSharpParser.FROM, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IN() { return GetToken(CSharpParser.IN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		public From_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_from_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterFrom_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitFrom_clause(this);
		}
	}

	[RuleVersion(0)]
	public From_clauseContext from_clause() {
		From_clauseContext _localctx = new From_clauseContext(Context, State);
		EnterRule(_localctx, 132, RULE_from_clause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1155;
			Match(FROM);
			State = 1157;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,112,Context) ) {
			case 1:
				{
				State = 1156;
				type_();
				}
				break;
			}
			State = 1159;
			identifier();
			State = 1160;
			Match(IN);
			State = 1161;
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

	public partial class Query_bodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Select_or_group_clauseContext select_or_group_clause() {
			return GetRuleContext<Select_or_group_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Query_body_clauseContext[] query_body_clause() {
			return GetRuleContexts<Query_body_clauseContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Query_body_clauseContext query_body_clause(int i) {
			return GetRuleContext<Query_body_clauseContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Query_continuationContext query_continuation() {
			return GetRuleContext<Query_continuationContext>(0);
		}
		public Query_bodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_query_body; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterQuery_body(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitQuery_body(this);
		}
	}

	[RuleVersion(0)]
	public Query_bodyContext query_body() {
		Query_bodyContext _localctx = new Query_bodyContext(Context, State);
		EnterRule(_localctx, 134, RULE_query_body);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1166;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (((((_la - 48)) & ~0x3f) == 0 && ((1L << (_la - 48)) & ((1L << (FROM - 48)) | (1L << (JOIN - 48)) | (1L << (LET - 48)) | (1L << (ORDERBY - 48)) | (1L << (WHERE - 48)))) != 0)) {
				{
				{
				State = 1163;
				query_body_clause();
				}
				}
				State = 1168;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1169;
			select_or_group_clause();
			State = 1171;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,114,Context) ) {
			case 1:
				{
				State = 1170;
				query_continuation();
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

	public partial class Query_body_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public From_clauseContext from_clause() {
			return GetRuleContext<From_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Let_clauseContext let_clause() {
			return GetRuleContext<Let_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Where_clauseContext where_clause() {
			return GetRuleContext<Where_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Combined_join_clauseContext combined_join_clause() {
			return GetRuleContext<Combined_join_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Orderby_clauseContext orderby_clause() {
			return GetRuleContext<Orderby_clauseContext>(0);
		}
		public Query_body_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_query_body_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterQuery_body_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitQuery_body_clause(this);
		}
	}

	[RuleVersion(0)]
	public Query_body_clauseContext query_body_clause() {
		Query_body_clauseContext _localctx = new Query_body_clauseContext(Context, State);
		EnterRule(_localctx, 136, RULE_query_body_clause);
		try {
			State = 1178;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case FROM:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1173;
				from_clause();
				}
				break;
			case LET:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1174;
				let_clause();
				}
				break;
			case WHERE:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1175;
				where_clause();
				}
				break;
			case JOIN:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1176;
				combined_join_clause();
				}
				break;
			case ORDERBY:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1177;
				orderby_clause();
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

	public partial class Let_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LET() { return GetToken(CSharpParser.LET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGNMENT() { return GetToken(CSharpParser.ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public Let_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_let_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterLet_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitLet_clause(this);
		}
	}

	[RuleVersion(0)]
	public Let_clauseContext let_clause() {
		Let_clauseContext _localctx = new Let_clauseContext(Context, State);
		EnterRule(_localctx, 138, RULE_let_clause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1180;
			Match(LET);
			State = 1181;
			identifier();
			State = 1182;
			Match(ASSIGNMENT);
			State = 1183;
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

	public partial class Where_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHERE() { return GetToken(CSharpParser.WHERE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public Where_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_where_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterWhere_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitWhere_clause(this);
		}
	}

	[RuleVersion(0)]
	public Where_clauseContext where_clause() {
		Where_clauseContext _localctx = new Where_clauseContext(Context, State);
		EnterRule(_localctx, 140, RULE_where_clause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1185;
			Match(WHERE);
			State = 1186;
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

	public partial class Combined_join_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode JOIN() { return GetToken(CSharpParser.JOIN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IN() { return GetToken(CSharpParser.IN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ON() { return GetToken(CSharpParser.ON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EQUALS() { return GetToken(CSharpParser.EQUALS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTO() { return GetToken(CSharpParser.INTO, 0); }
		public Combined_join_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_combined_join_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterCombined_join_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitCombined_join_clause(this);
		}
	}

	[RuleVersion(0)]
	public Combined_join_clauseContext combined_join_clause() {
		Combined_join_clauseContext _localctx = new Combined_join_clauseContext(Context, State);
		EnterRule(_localctx, 142, RULE_combined_join_clause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1188;
			Match(JOIN);
			State = 1190;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,116,Context) ) {
			case 1:
				{
				State = 1189;
				type_();
				}
				break;
			}
			State = 1192;
			identifier();
			State = 1193;
			Match(IN);
			State = 1194;
			expression();
			State = 1195;
			Match(ON);
			State = 1196;
			expression();
			State = 1197;
			Match(EQUALS);
			State = 1198;
			expression();
			State = 1201;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==INTO) {
				{
				State = 1199;
				Match(INTO);
				State = 1200;
				identifier();
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

	public partial class Orderby_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ORDERBY() { return GetToken(CSharpParser.ORDERBY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public OrderingContext[] ordering() {
			return GetRuleContexts<OrderingContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public OrderingContext ordering(int i) {
			return GetRuleContext<OrderingContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Orderby_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_orderby_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterOrderby_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitOrderby_clause(this);
		}
	}

	[RuleVersion(0)]
	public Orderby_clauseContext orderby_clause() {
		Orderby_clauseContext _localctx = new Orderby_clauseContext(Context, State);
		EnterRule(_localctx, 144, RULE_orderby_clause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1203;
			Match(ORDERBY);
			State = 1204;
			ordering();
			State = 1209;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1205;
				Match(COMMA);
				State = 1206;
				ordering();
				}
				}
				State = 1211;
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

	public partial class OrderingContext : ParserRuleContext {
		public IToken dir;
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASCENDING() { return GetToken(CSharpParser.ASCENDING, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DESCENDING() { return GetToken(CSharpParser.DESCENDING, 0); }
		public OrderingContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ordering; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterOrdering(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitOrdering(this);
		}
	}

	[RuleVersion(0)]
	public OrderingContext ordering() {
		OrderingContext _localctx = new OrderingContext(Context, State);
		EnterRule(_localctx, 146, RULE_ordering);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1212;
			expression();
			State = 1214;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==ASCENDING || _la==DESCENDING) {
				{
				State = 1213;
				_localctx.dir = TokenStream.LT(1);
				_la = TokenStream.LA(1);
				if ( !(_la==ASCENDING || _la==DESCENDING) ) {
					_localctx.dir = ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
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

	public partial class Select_or_group_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SELECT() { return GetToken(CSharpParser.SELECT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GROUP() { return GetToken(CSharpParser.GROUP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BY() { return GetToken(CSharpParser.BY, 0); }
		public Select_or_group_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_select_or_group_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterSelect_or_group_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitSelect_or_group_clause(this);
		}
	}

	[RuleVersion(0)]
	public Select_or_group_clauseContext select_or_group_clause() {
		Select_or_group_clauseContext _localctx = new Select_or_group_clauseContext(Context, State);
		EnterRule(_localctx, 148, RULE_select_or_group_clause);
		try {
			State = 1223;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case SELECT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1216;
				Match(SELECT);
				State = 1217;
				expression();
				}
				break;
			case GROUP:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1218;
				Match(GROUP);
				State = 1219;
				expression();
				State = 1220;
				Match(BY);
				State = 1221;
				expression();
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

	public partial class Query_continuationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTO() { return GetToken(CSharpParser.INTO, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Query_bodyContext query_body() {
			return GetRuleContext<Query_bodyContext>(0);
		}
		public Query_continuationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_query_continuation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterQuery_continuation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitQuery_continuation(this);
		}
	}

	[RuleVersion(0)]
	public Query_continuationContext query_continuation() {
		Query_continuationContext _localctx = new Query_continuationContext(Context, State);
		EnterRule(_localctx, 150, RULE_query_continuation);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1225;
			Match(INTO);
			State = 1226;
			identifier();
			State = 1227;
			query_body();
			}
		}
		catch (RecognitionException re) {
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
		[System.Diagnostics.DebuggerNonUserCode] public Labeled_StatementContext labeled_Statement() {
			return GetRuleContext<Labeled_StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclarationStatementContext declarationStatement() {
			return GetRuleContext<DeclarationStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Embedded_statementContext embedded_statement() {
			return GetRuleContext<Embedded_statementContext>(0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 152, RULE_statement);
		try {
			State = 1232;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,121,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1229;
				labeled_Statement();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1230;
				declarationStatement();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1231;
				embedded_statement();
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

	public partial class DeclarationStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Local_variable_declarationContext local_variable_declaration() {
			return GetRuleContext<Local_variable_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Local_constant_declarationContext local_constant_declaration() {
			return GetRuleContext<Local_constant_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Local_function_declarationContext local_function_declaration() {
			return GetRuleContext<Local_function_declarationContext>(0);
		}
		public DeclarationStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declarationStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterDeclarationStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitDeclarationStatement(this);
		}
	}

	[RuleVersion(0)]
	public DeclarationStatementContext declarationStatement() {
		DeclarationStatementContext _localctx = new DeclarationStatementContext(Context, State);
		EnterRule(_localctx, 154, RULE_declarationStatement);
		try {
			State = 1241;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,122,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1234;
				local_variable_declaration();
				State = 1235;
				Match(SEMICOLON);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1237;
				local_constant_declaration();
				State = 1238;
				Match(SEMICOLON);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1240;
				local_function_declaration();
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

	public partial class Local_function_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Local_function_headerContext local_function_header() {
			return GetRuleContext<Local_function_headerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Local_function_bodyContext local_function_body() {
			return GetRuleContext<Local_function_bodyContext>(0);
		}
		public Local_function_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_local_function_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterLocal_function_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitLocal_function_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Local_function_declarationContext local_function_declaration() {
		Local_function_declarationContext _localctx = new Local_function_declarationContext(Context, State);
		EnterRule(_localctx, 156, RULE_local_function_declaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1243;
			local_function_header();
			State = 1244;
			local_function_body();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Local_function_headerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Return_typeContext return_type() {
			return GetRuleContext<Return_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Local_function_modifiersContext local_function_modifiers() {
			return GetRuleContext<Local_function_modifiersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_parameter_listContext type_parameter_list() {
			return GetRuleContext<Type_parameter_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Formal_parameter_listContext formal_parameter_list() {
			return GetRuleContext<Formal_parameter_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_parameter_constraints_clausesContext type_parameter_constraints_clauses() {
			return GetRuleContext<Type_parameter_constraints_clausesContext>(0);
		}
		public Local_function_headerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_local_function_header; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterLocal_function_header(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitLocal_function_header(this);
		}
	}

	[RuleVersion(0)]
	public Local_function_headerContext local_function_header() {
		Local_function_headerContext _localctx = new Local_function_headerContext(Context, State);
		EnterRule(_localctx, 158, RULE_local_function_header);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1247;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,123,Context) ) {
			case 1:
				{
				State = 1246;
				local_function_modifiers();
				}
				break;
			}
			State = 1249;
			return_type();
			State = 1250;
			identifier();
			State = 1252;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LT) {
				{
				State = 1251;
				type_parameter_list();
				}
			}

			State = 1254;
			Match(OPEN_PARENS);
			State = 1256;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 10)) & ~0x3f) == 0 && ((1L << (_la - 10)) & ((1L << (ADD - 10)) | (1L << (ALIAS - 10)) | (1L << (ARGLIST - 10)) | (1L << (ASCENDING - 10)) | (1L << (ASYNC - 10)) | (1L << (AWAIT - 10)) | (1L << (BOOL - 10)) | (1L << (BY - 10)) | (1L << (BYTE - 10)) | (1L << (CHAR - 10)) | (1L << (DECIMAL - 10)) | (1L << (DESCENDING - 10)) | (1L << (DOUBLE - 10)) | (1L << (DYNAMIC - 10)) | (1L << (EQUALS - 10)) | (1L << (FLOAT - 10)) | (1L << (FROM - 10)) | (1L << (GET - 10)) | (1L << (GROUP - 10)) | (1L << (IN - 10)) | (1L << (INT - 10)) | (1L << (INTO - 10)) | (1L << (JOIN - 10)) | (1L << (LET - 10)) | (1L << (LONG - 10)) | (1L << (NAMEOF - 10)) | (1L << (OBJECT - 10)) | (1L << (ON - 10)) | (1L << (ORDERBY - 10)) | (1L << (OUT - 10)))) != 0) || ((((_la - 74)) & ~0x3f) == 0 && ((1L << (_la - 74)) & ((1L << (PARAMS - 74)) | (1L << (PARTIAL - 74)) | (1L << (REF - 74)) | (1L << (REMOVE - 74)) | (1L << (SBYTE - 74)) | (1L << (SELECT - 74)) | (1L << (SET - 74)) | (1L << (SHORT - 74)) | (1L << (STRING - 74)) | (1L << (THIS - 74)) | (1L << (UINT - 74)) | (1L << (ULONG - 74)) | (1L << (UNMANAGED - 74)) | (1L << (USHORT - 74)) | (1L << (VAR - 74)) | (1L << (VOID - 74)) | (1L << (WHEN - 74)) | (1L << (WHERE - 74)) | (1L << (YIELD - 74)) | (1L << (IDENTIFIER - 74)) | (1L << (OPEN_BRACKET - 74)) | (1L << (OPEN_PARENS - 74)))) != 0)) {
				{
				State = 1255;
				formal_parameter_list();
				}
			}

			State = 1258;
			Match(CLOSE_PARENS);
			State = 1260;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WHERE) {
				{
				State = 1259;
				type_parameter_constraints_clauses();
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

	public partial class Local_function_modifiersContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASYNC() { return GetToken(CSharpParser.ASYNC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNSAFE() { return GetToken(CSharpParser.UNSAFE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(CSharpParser.STATIC, 0); }
		public Local_function_modifiersContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_local_function_modifiers; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterLocal_function_modifiers(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitLocal_function_modifiers(this);
		}
	}

	[RuleVersion(0)]
	public Local_function_modifiersContext local_function_modifiers() {
		Local_function_modifiersContext _localctx = new Local_function_modifiersContext(Context, State);
		EnterRule(_localctx, 160, RULE_local_function_modifiers);
		int _la;
		try {
			State = 1268;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ASYNC:
			case UNSAFE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1262;
				_la = TokenStream.LA(1);
				if ( !(_la==ASYNC || _la==UNSAFE) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 1264;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==STATIC) {
					{
					State = 1263;
					Match(STATIC);
					}
				}

				}
				break;
			case STATIC:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1266;
				Match(STATIC);
				State = 1267;
				_la = TokenStream.LA(1);
				if ( !(_la==ASYNC || _la==UNSAFE) ) {
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
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Local_function_bodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Right_arrowContext right_arrow() {
			return GetRuleContext<Right_arrowContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Throwable_expressionContext throwable_expression() {
			return GetRuleContext<Throwable_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public Local_function_bodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_local_function_body; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterLocal_function_body(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitLocal_function_body(this);
		}
	}

	[RuleVersion(0)]
	public Local_function_bodyContext local_function_body() {
		Local_function_bodyContext _localctx = new Local_function_bodyContext(Context, State);
		EnterRule(_localctx, 162, RULE_local_function_body);
		try {
			State = 1275;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case OPEN_BRACE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1270;
				block();
				}
				break;
			case ASSIGNMENT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1271;
				right_arrow();
				State = 1272;
				throwable_expression();
				State = 1273;
				Match(SEMICOLON);
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

	public partial class Labeled_StatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(CSharpParser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		public Labeled_StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_labeled_Statement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterLabeled_Statement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitLabeled_Statement(this);
		}
	}

	[RuleVersion(0)]
	public Labeled_StatementContext labeled_Statement() {
		Labeled_StatementContext _localctx = new Labeled_StatementContext(Context, State);
		EnterRule(_localctx, 164, RULE_labeled_Statement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1277;
			identifier();
			State = 1278;
			Match(COLON);
			State = 1279;
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

	public partial class Embedded_statementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Simple_embedded_statementContext simple_embedded_statement() {
			return GetRuleContext<Simple_embedded_statementContext>(0);
		}
		public Embedded_statementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_embedded_statement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterEmbedded_statement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitEmbedded_statement(this);
		}
	}

	[RuleVersion(0)]
	public Embedded_statementContext embedded_statement() {
		Embedded_statementContext _localctx = new Embedded_statementContext(Context, State);
		EnterRule(_localctx, 166, RULE_embedded_statement);
		try {
			State = 1283;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case OPEN_BRACE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1281;
				block();
				}
				break;
			case ADD:
			case ALIAS:
			case ARGLIST:
			case ASCENDING:
			case ASYNC:
			case AWAIT:
			case BASE:
			case BOOL:
			case BREAK:
			case BY:
			case BYTE:
			case CHAR:
			case CHECKED:
			case CONTINUE:
			case DECIMAL:
			case DEFAULT:
			case DELEGATE:
			case DESCENDING:
			case DO:
			case DOUBLE:
			case DYNAMIC:
			case EQUALS:
			case FALSE:
			case FIXED:
			case FLOAT:
			case FOR:
			case FOREACH:
			case FROM:
			case GET:
			case GOTO:
			case GROUP:
			case IF:
			case INT:
			case INTO:
			case JOIN:
			case LET:
			case LOCK:
			case LONG:
			case NAMEOF:
			case NEW:
			case NULL_:
			case OBJECT:
			case ON:
			case ORDERBY:
			case PARTIAL:
			case REF:
			case REMOVE:
			case RETURN:
			case SBYTE:
			case SELECT:
			case SET:
			case SHORT:
			case SIZEOF:
			case STRING:
			case SWITCH:
			case THIS:
			case THROW:
			case TRUE:
			case TRY:
			case TYPEOF:
			case UINT:
			case ULONG:
			case UNCHECKED:
			case UNMANAGED:
			case UNSAFE:
			case USHORT:
			case USING:
			case VAR:
			case WHEN:
			case WHERE:
			case WHILE:
			case YIELD:
			case IDENTIFIER:
			case LITERAL_ACCESS:
			case INTEGER_LITERAL:
			case HEX_INTEGER_LITERAL:
			case BIN_INTEGER_LITERAL:
			case REAL_LITERAL:
			case CHARACTER_LITERAL:
			case REGULAR_STRING:
			case VERBATIUM_STRING:
			case INTERPOLATED_REGULAR_STRING_START:
			case INTERPOLATED_VERBATIUM_STRING_START:
			case OPEN_PARENS:
			case SEMICOLON:
			case PLUS:
			case MINUS:
			case STAR:
			case AMP:
			case CARET:
			case BANG:
			case TILDE:
			case OP_INC:
			case OP_DEC:
			case OP_RANGE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1282;
				simple_embedded_statement();
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

	public partial class Simple_embedded_statementContext : ParserRuleContext {
		public Simple_embedded_statementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_simple_embedded_statement; } }
	 
		public Simple_embedded_statementContext() { }
		public virtual void CopyFrom(Simple_embedded_statementContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class TryStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRY() { return GetToken(CSharpParser.TRY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Catch_clausesContext catch_clauses() {
			return GetRuleContext<Catch_clausesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Finally_clauseContext finally_clause() {
			return GetRuleContext<Finally_clauseContext>(0);
		}
		public TryStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterTryStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitTryStatement(this);
		}
	}
	public partial class CheckedStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CHECKED() { return GetToken(CSharpParser.CHECKED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public CheckedStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterCheckedStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitCheckedStatement(this);
		}
	}
	public partial class ThrowStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THROW() { return GetToken(CSharpParser.THROW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ThrowStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterThrowStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitThrowStatement(this);
		}
	}
	public partial class TheEmptyStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public TheEmptyStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterTheEmptyStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitTheEmptyStatement(this);
		}
	}
	public partial class UnsafeStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNSAFE() { return GetToken(CSharpParser.UNSAFE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public UnsafeStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterUnsafeStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitUnsafeStatement(this);
		}
	}
	public partial class ForStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOR() { return GetToken(CSharpParser.FOR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SEMICOLON() { return GetTokens(CSharpParser.SEMICOLON); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON(int i) {
			return GetToken(CSharpParser.SEMICOLON, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Embedded_statementContext embedded_statement() {
			return GetRuleContext<Embedded_statementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public For_initializerContext for_initializer() {
			return GetRuleContext<For_initializerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public For_iteratorContext for_iterator() {
			return GetRuleContext<For_iteratorContext>(0);
		}
		public ForStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterForStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitForStatement(this);
		}
	}
	public partial class BreakStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BREAK() { return GetToken(CSharpParser.BREAK, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public BreakStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterBreakStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitBreakStatement(this);
		}
	}
	public partial class IfStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IF() { return GetToken(CSharpParser.IF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public If_bodyContext[] if_body() {
			return GetRuleContexts<If_bodyContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public If_bodyContext if_body(int i) {
			return GetRuleContext<If_bodyContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ELSE() { return GetToken(CSharpParser.ELSE, 0); }
		public IfStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterIfStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitIfStatement(this);
		}
	}
	public partial class ReturnStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RETURN() { return GetToken(CSharpParser.RETURN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ReturnStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterReturnStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitReturnStatement(this);
		}
	}
	public partial class GotoStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GOTO() { return GetToken(CSharpParser.GOTO, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CASE() { return GetToken(CSharpParser.CASE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFAULT() { return GetToken(CSharpParser.DEFAULT, 0); }
		public GotoStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterGotoStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitGotoStatement(this);
		}
	}
	public partial class SwitchStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SWITCH() { return GetToken(CSharpParser.SWITCH, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Switch_sectionContext[] switch_section() {
			return GetRuleContexts<Switch_sectionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Switch_sectionContext switch_section(int i) {
			return GetRuleContext<Switch_sectionContext>(i);
		}
		public SwitchStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterSwitchStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitSwitchStatement(this);
		}
	}
	public partial class FixedStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FIXED() { return GetToken(CSharpParser.FIXED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Pointer_typeContext pointer_type() {
			return GetRuleContext<Pointer_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Fixed_pointer_declaratorsContext fixed_pointer_declarators() {
			return GetRuleContext<Fixed_pointer_declaratorsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Embedded_statementContext embedded_statement() {
			return GetRuleContext<Embedded_statementContext>(0);
		}
		public FixedStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterFixedStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitFixedStatement(this);
		}
	}
	public partial class WhileStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHILE() { return GetToken(CSharpParser.WHILE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Embedded_statementContext embedded_statement() {
			return GetRuleContext<Embedded_statementContext>(0);
		}
		public WhileStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterWhileStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitWhileStatement(this);
		}
	}
	public partial class DoStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DO() { return GetToken(CSharpParser.DO, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Embedded_statementContext embedded_statement() {
			return GetRuleContext<Embedded_statementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHILE() { return GetToken(CSharpParser.WHILE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public DoStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterDoStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitDoStatement(this);
		}
	}
	public partial class ForeachStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOREACH() { return GetToken(CSharpParser.FOREACH, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Local_variable_typeContext local_variable_type() {
			return GetRuleContext<Local_variable_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IN() { return GetToken(CSharpParser.IN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Embedded_statementContext embedded_statement() {
			return GetRuleContext<Embedded_statementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AWAIT() { return GetToken(CSharpParser.AWAIT, 0); }
		public ForeachStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterForeachStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitForeachStatement(this);
		}
	}
	public partial class UncheckedStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNCHECKED() { return GetToken(CSharpParser.UNCHECKED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public UncheckedStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterUncheckedStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitUncheckedStatement(this);
		}
	}
	public partial class ExpressionStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public ExpressionStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterExpressionStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitExpressionStatement(this);
		}
	}
	public partial class ContinueStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CONTINUE() { return GetToken(CSharpParser.CONTINUE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public ContinueStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterContinueStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitContinueStatement(this);
		}
	}
	public partial class UsingStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode USING() { return GetToken(CSharpParser.USING, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Resource_acquisitionContext resource_acquisition() {
			return GetRuleContext<Resource_acquisitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Embedded_statementContext embedded_statement() {
			return GetRuleContext<Embedded_statementContext>(0);
		}
		public UsingStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterUsingStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitUsingStatement(this);
		}
	}
	public partial class LockStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LOCK() { return GetToken(CSharpParser.LOCK, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Embedded_statementContext embedded_statement() {
			return GetRuleContext<Embedded_statementContext>(0);
		}
		public LockStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterLockStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitLockStatement(this);
		}
	}
	public partial class YieldStatementContext : Simple_embedded_statementContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode YIELD() { return GetToken(CSharpParser.YIELD, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RETURN() { return GetToken(CSharpParser.RETURN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BREAK() { return GetToken(CSharpParser.BREAK, 0); }
		public YieldStatementContext(Simple_embedded_statementContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterYieldStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitYieldStatement(this);
		}
	}

	[RuleVersion(0)]
	public Simple_embedded_statementContext simple_embedded_statement() {
		Simple_embedded_statementContext _localctx = new Simple_embedded_statementContext(Context, State);
		EnterRule(_localctx, 168, RULE_simple_embedded_statement);
		int _la;
		try {
			State = 1415;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,143,Context) ) {
			case 1:
				_localctx = new TheEmptyStatementContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 1285;
				Match(SEMICOLON);
				}
				break;
			case 2:
				_localctx = new ExpressionStatementContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 1286;
				expression();
				State = 1287;
				Match(SEMICOLON);
				}
				break;
			case 3:
				_localctx = new IfStatementContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 1289;
				Match(IF);
				State = 1290;
				Match(OPEN_PARENS);
				State = 1291;
				expression();
				State = 1292;
				Match(CLOSE_PARENS);
				State = 1293;
				if_body();
				State = 1296;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,131,Context) ) {
				case 1:
					{
					State = 1294;
					Match(ELSE);
					State = 1295;
					if_body();
					}
					break;
				}
				}
				break;
			case 4:
				_localctx = new SwitchStatementContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 1298;
				Match(SWITCH);
				State = 1299;
				Match(OPEN_PARENS);
				State = 1300;
				expression();
				State = 1301;
				Match(CLOSE_PARENS);
				State = 1302;
				Match(OPEN_BRACE);
				State = 1306;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==CASE || _la==DEFAULT) {
					{
					{
					State = 1303;
					switch_section();
					}
					}
					State = 1308;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 1309;
				Match(CLOSE_BRACE);
				}
				break;
			case 5:
				_localctx = new WhileStatementContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 1311;
				Match(WHILE);
				State = 1312;
				Match(OPEN_PARENS);
				State = 1313;
				expression();
				State = 1314;
				Match(CLOSE_PARENS);
				State = 1315;
				embedded_statement();
				}
				break;
			case 6:
				_localctx = new DoStatementContext(_localctx);
				EnterOuterAlt(_localctx, 6);
				{
				State = 1317;
				Match(DO);
				State = 1318;
				embedded_statement();
				State = 1319;
				Match(WHILE);
				State = 1320;
				Match(OPEN_PARENS);
				State = 1321;
				expression();
				State = 1322;
				Match(CLOSE_PARENS);
				State = 1323;
				Match(SEMICOLON);
				}
				break;
			case 7:
				_localctx = new ForStatementContext(_localctx);
				EnterOuterAlt(_localctx, 7);
				{
				State = 1325;
				Match(FOR);
				State = 1326;
				Match(OPEN_PARENS);
				State = 1328;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BASE) | (1L << BOOL) | (1L << BY) | (1L << BYTE) | (1L << CHAR) | (1L << CHECKED) | (1L << DECIMAL) | (1L << DEFAULT) | (1L << DELEGATE) | (1L << DESCENDING) | (1L << DOUBLE) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FALSE) | (1L << FIXED) | (1L << FLOAT) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << INT) | (1L << INTO) | (1L << JOIN) | (1L << LET) | (1L << LONG))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (NEW - 64)) | (1L << (NULL_ - 64)) | (1L << (OBJECT - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REF - 64)) | (1L << (REMOVE - 64)) | (1L << (SBYTE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (SHORT - 64)) | (1L << (SIZEOF - 64)) | (1L << (STRING - 64)) | (1L << (THIS - 64)) | (1L << (TRUE - 64)) | (1L << (TYPEOF - 64)) | (1L << (UINT - 64)) | (1L << (ULONG - 64)) | (1L << (UNCHECKED - 64)) | (1L << (UNMANAGED - 64)) | (1L << (USHORT - 64)) | (1L << (USING - 64)) | (1L << (VAR - 64)) | (1L << (VOID - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (LITERAL_ACCESS - 64)) | (1L << (INTEGER_LITERAL - 64)) | (1L << (HEX_INTEGER_LITERAL - 64)) | (1L << (BIN_INTEGER_LITERAL - 64)) | (1L << (REAL_LITERAL - 64)) | (1L << (CHARACTER_LITERAL - 64)) | (1L << (REGULAR_STRING - 64)) | (1L << (VERBATIUM_STRING - 64)) | (1L << (INTERPOLATED_REGULAR_STRING_START - 64)) | (1L << (INTERPOLATED_VERBATIUM_STRING_START - 64)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (OPEN_PARENS - 129)) | (1L << (PLUS - 129)) | (1L << (MINUS - 129)) | (1L << (STAR - 129)) | (1L << (AMP - 129)) | (1L << (CARET - 129)) | (1L << (BANG - 129)) | (1L << (TILDE - 129)) | (1L << (OP_INC - 129)) | (1L << (OP_DEC - 129)) | (1L << (OP_RANGE - 129)))) != 0)) {
					{
					State = 1327;
					for_initializer();
					}
				}

				State = 1330;
				Match(SEMICOLON);
				State = 1332;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BASE) | (1L << BOOL) | (1L << BY) | (1L << BYTE) | (1L << CHAR) | (1L << CHECKED) | (1L << DECIMAL) | (1L << DEFAULT) | (1L << DELEGATE) | (1L << DESCENDING) | (1L << DOUBLE) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FALSE) | (1L << FLOAT) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << INT) | (1L << INTO) | (1L << JOIN) | (1L << LET) | (1L << LONG))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (NEW - 64)) | (1L << (NULL_ - 64)) | (1L << (OBJECT - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REF - 64)) | (1L << (REMOVE - 64)) | (1L << (SBYTE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (SHORT - 64)) | (1L << (SIZEOF - 64)) | (1L << (STRING - 64)) | (1L << (THIS - 64)) | (1L << (TRUE - 64)) | (1L << (TYPEOF - 64)) | (1L << (UINT - 64)) | (1L << (ULONG - 64)) | (1L << (UNCHECKED - 64)) | (1L << (UNMANAGED - 64)) | (1L << (USHORT - 64)) | (1L << (VAR - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (LITERAL_ACCESS - 64)) | (1L << (INTEGER_LITERAL - 64)) | (1L << (HEX_INTEGER_LITERAL - 64)) | (1L << (BIN_INTEGER_LITERAL - 64)) | (1L << (REAL_LITERAL - 64)) | (1L << (CHARACTER_LITERAL - 64)) | (1L << (REGULAR_STRING - 64)) | (1L << (VERBATIUM_STRING - 64)) | (1L << (INTERPOLATED_REGULAR_STRING_START - 64)) | (1L << (INTERPOLATED_VERBATIUM_STRING_START - 64)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (OPEN_PARENS - 129)) | (1L << (PLUS - 129)) | (1L << (MINUS - 129)) | (1L << (STAR - 129)) | (1L << (AMP - 129)) | (1L << (CARET - 129)) | (1L << (BANG - 129)) | (1L << (TILDE - 129)) | (1L << (OP_INC - 129)) | (1L << (OP_DEC - 129)) | (1L << (OP_RANGE - 129)))) != 0)) {
					{
					State = 1331;
					expression();
					}
				}

				State = 1334;
				Match(SEMICOLON);
				State = 1336;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BASE) | (1L << BOOL) | (1L << BY) | (1L << BYTE) | (1L << CHAR) | (1L << CHECKED) | (1L << DECIMAL) | (1L << DEFAULT) | (1L << DELEGATE) | (1L << DESCENDING) | (1L << DOUBLE) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FALSE) | (1L << FLOAT) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << INT) | (1L << INTO) | (1L << JOIN) | (1L << LET) | (1L << LONG))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (NEW - 64)) | (1L << (NULL_ - 64)) | (1L << (OBJECT - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REF - 64)) | (1L << (REMOVE - 64)) | (1L << (SBYTE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (SHORT - 64)) | (1L << (SIZEOF - 64)) | (1L << (STRING - 64)) | (1L << (THIS - 64)) | (1L << (TRUE - 64)) | (1L << (TYPEOF - 64)) | (1L << (UINT - 64)) | (1L << (ULONG - 64)) | (1L << (UNCHECKED - 64)) | (1L << (UNMANAGED - 64)) | (1L << (USHORT - 64)) | (1L << (VAR - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (LITERAL_ACCESS - 64)) | (1L << (INTEGER_LITERAL - 64)) | (1L << (HEX_INTEGER_LITERAL - 64)) | (1L << (BIN_INTEGER_LITERAL - 64)) | (1L << (REAL_LITERAL - 64)) | (1L << (CHARACTER_LITERAL - 64)) | (1L << (REGULAR_STRING - 64)) | (1L << (VERBATIUM_STRING - 64)) | (1L << (INTERPOLATED_REGULAR_STRING_START - 64)) | (1L << (INTERPOLATED_VERBATIUM_STRING_START - 64)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (OPEN_PARENS - 129)) | (1L << (PLUS - 129)) | (1L << (MINUS - 129)) | (1L << (STAR - 129)) | (1L << (AMP - 129)) | (1L << (CARET - 129)) | (1L << (BANG - 129)) | (1L << (TILDE - 129)) | (1L << (OP_INC - 129)) | (1L << (OP_DEC - 129)) | (1L << (OP_RANGE - 129)))) != 0)) {
					{
					State = 1335;
					for_iterator();
					}
				}

				State = 1338;
				Match(CLOSE_PARENS);
				State = 1339;
				embedded_statement();
				}
				break;
			case 8:
				_localctx = new ForeachStatementContext(_localctx);
				EnterOuterAlt(_localctx, 8);
				{
				State = 1341;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==AWAIT) {
					{
					State = 1340;
					Match(AWAIT);
					}
				}

				State = 1343;
				Match(FOREACH);
				State = 1344;
				Match(OPEN_PARENS);
				State = 1345;
				local_variable_type();
				State = 1346;
				identifier();
				State = 1347;
				Match(IN);
				State = 1348;
				expression();
				State = 1349;
				Match(CLOSE_PARENS);
				State = 1350;
				embedded_statement();
				}
				break;
			case 9:
				_localctx = new BreakStatementContext(_localctx);
				EnterOuterAlt(_localctx, 9);
				{
				State = 1352;
				Match(BREAK);
				State = 1353;
				Match(SEMICOLON);
				}
				break;
			case 10:
				_localctx = new ContinueStatementContext(_localctx);
				EnterOuterAlt(_localctx, 10);
				{
				State = 1354;
				Match(CONTINUE);
				State = 1355;
				Match(SEMICOLON);
				}
				break;
			case 11:
				_localctx = new GotoStatementContext(_localctx);
				EnterOuterAlt(_localctx, 11);
				{
				State = 1356;
				Match(GOTO);
				State = 1361;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case ADD:
				case ALIAS:
				case ARGLIST:
				case ASCENDING:
				case ASYNC:
				case AWAIT:
				case BY:
				case DESCENDING:
				case DYNAMIC:
				case EQUALS:
				case FROM:
				case GET:
				case GROUP:
				case INTO:
				case JOIN:
				case LET:
				case NAMEOF:
				case ON:
				case ORDERBY:
				case PARTIAL:
				case REMOVE:
				case SELECT:
				case SET:
				case UNMANAGED:
				case VAR:
				case WHEN:
				case WHERE:
				case YIELD:
				case IDENTIFIER:
					{
					State = 1357;
					identifier();
					}
					break;
				case CASE:
					{
					State = 1358;
					Match(CASE);
					State = 1359;
					expression();
					}
					break;
				case DEFAULT:
					{
					State = 1360;
					Match(DEFAULT);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 1363;
				Match(SEMICOLON);
				}
				break;
			case 12:
				_localctx = new ReturnStatementContext(_localctx);
				EnterOuterAlt(_localctx, 12);
				{
				State = 1364;
				Match(RETURN);
				State = 1366;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BASE) | (1L << BOOL) | (1L << BY) | (1L << BYTE) | (1L << CHAR) | (1L << CHECKED) | (1L << DECIMAL) | (1L << DEFAULT) | (1L << DELEGATE) | (1L << DESCENDING) | (1L << DOUBLE) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FALSE) | (1L << FLOAT) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << INT) | (1L << INTO) | (1L << JOIN) | (1L << LET) | (1L << LONG))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (NEW - 64)) | (1L << (NULL_ - 64)) | (1L << (OBJECT - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REF - 64)) | (1L << (REMOVE - 64)) | (1L << (SBYTE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (SHORT - 64)) | (1L << (SIZEOF - 64)) | (1L << (STRING - 64)) | (1L << (THIS - 64)) | (1L << (TRUE - 64)) | (1L << (TYPEOF - 64)) | (1L << (UINT - 64)) | (1L << (ULONG - 64)) | (1L << (UNCHECKED - 64)) | (1L << (UNMANAGED - 64)) | (1L << (USHORT - 64)) | (1L << (VAR - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (LITERAL_ACCESS - 64)) | (1L << (INTEGER_LITERAL - 64)) | (1L << (HEX_INTEGER_LITERAL - 64)) | (1L << (BIN_INTEGER_LITERAL - 64)) | (1L << (REAL_LITERAL - 64)) | (1L << (CHARACTER_LITERAL - 64)) | (1L << (REGULAR_STRING - 64)) | (1L << (VERBATIUM_STRING - 64)) | (1L << (INTERPOLATED_REGULAR_STRING_START - 64)) | (1L << (INTERPOLATED_VERBATIUM_STRING_START - 64)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (OPEN_PARENS - 129)) | (1L << (PLUS - 129)) | (1L << (MINUS - 129)) | (1L << (STAR - 129)) | (1L << (AMP - 129)) | (1L << (CARET - 129)) | (1L << (BANG - 129)) | (1L << (TILDE - 129)) | (1L << (OP_INC - 129)) | (1L << (OP_DEC - 129)) | (1L << (OP_RANGE - 129)))) != 0)) {
					{
					State = 1365;
					expression();
					}
				}

				State = 1368;
				Match(SEMICOLON);
				}
				break;
			case 13:
				_localctx = new ThrowStatementContext(_localctx);
				EnterOuterAlt(_localctx, 13);
				{
				State = 1369;
				Match(THROW);
				State = 1371;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BASE) | (1L << BOOL) | (1L << BY) | (1L << BYTE) | (1L << CHAR) | (1L << CHECKED) | (1L << DECIMAL) | (1L << DEFAULT) | (1L << DELEGATE) | (1L << DESCENDING) | (1L << DOUBLE) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FALSE) | (1L << FLOAT) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << INT) | (1L << INTO) | (1L << JOIN) | (1L << LET) | (1L << LONG))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (NEW - 64)) | (1L << (NULL_ - 64)) | (1L << (OBJECT - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REF - 64)) | (1L << (REMOVE - 64)) | (1L << (SBYTE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (SHORT - 64)) | (1L << (SIZEOF - 64)) | (1L << (STRING - 64)) | (1L << (THIS - 64)) | (1L << (TRUE - 64)) | (1L << (TYPEOF - 64)) | (1L << (UINT - 64)) | (1L << (ULONG - 64)) | (1L << (UNCHECKED - 64)) | (1L << (UNMANAGED - 64)) | (1L << (USHORT - 64)) | (1L << (VAR - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (LITERAL_ACCESS - 64)) | (1L << (INTEGER_LITERAL - 64)) | (1L << (HEX_INTEGER_LITERAL - 64)) | (1L << (BIN_INTEGER_LITERAL - 64)) | (1L << (REAL_LITERAL - 64)) | (1L << (CHARACTER_LITERAL - 64)) | (1L << (REGULAR_STRING - 64)) | (1L << (VERBATIUM_STRING - 64)) | (1L << (INTERPOLATED_REGULAR_STRING_START - 64)) | (1L << (INTERPOLATED_VERBATIUM_STRING_START - 64)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (OPEN_PARENS - 129)) | (1L << (PLUS - 129)) | (1L << (MINUS - 129)) | (1L << (STAR - 129)) | (1L << (AMP - 129)) | (1L << (CARET - 129)) | (1L << (BANG - 129)) | (1L << (TILDE - 129)) | (1L << (OP_INC - 129)) | (1L << (OP_DEC - 129)) | (1L << (OP_RANGE - 129)))) != 0)) {
					{
					State = 1370;
					expression();
					}
				}

				State = 1373;
				Match(SEMICOLON);
				}
				break;
			case 14:
				_localctx = new TryStatementContext(_localctx);
				EnterOuterAlt(_localctx, 14);
				{
				State = 1374;
				Match(TRY);
				State = 1375;
				block();
				State = 1381;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case CATCH:
					{
					State = 1376;
					catch_clauses();
					State = 1378;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==FINALLY) {
						{
						State = 1377;
						finally_clause();
						}
					}

					}
					break;
				case FINALLY:
					{
					State = 1380;
					finally_clause();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				break;
			case 15:
				_localctx = new CheckedStatementContext(_localctx);
				EnterOuterAlt(_localctx, 15);
				{
				State = 1383;
				Match(CHECKED);
				State = 1384;
				block();
				}
				break;
			case 16:
				_localctx = new UncheckedStatementContext(_localctx);
				EnterOuterAlt(_localctx, 16);
				{
				State = 1385;
				Match(UNCHECKED);
				State = 1386;
				block();
				}
				break;
			case 17:
				_localctx = new LockStatementContext(_localctx);
				EnterOuterAlt(_localctx, 17);
				{
				State = 1387;
				Match(LOCK);
				State = 1388;
				Match(OPEN_PARENS);
				State = 1389;
				expression();
				State = 1390;
				Match(CLOSE_PARENS);
				State = 1391;
				embedded_statement();
				}
				break;
			case 18:
				_localctx = new UsingStatementContext(_localctx);
				EnterOuterAlt(_localctx, 18);
				{
				State = 1393;
				Match(USING);
				State = 1394;
				Match(OPEN_PARENS);
				State = 1395;
				resource_acquisition();
				State = 1396;
				Match(CLOSE_PARENS);
				State = 1397;
				embedded_statement();
				}
				break;
			case 19:
				_localctx = new YieldStatementContext(_localctx);
				EnterOuterAlt(_localctx, 19);
				{
				State = 1399;
				Match(YIELD);
				State = 1403;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case RETURN:
					{
					State = 1400;
					Match(RETURN);
					State = 1401;
					expression();
					}
					break;
				case BREAK:
					{
					State = 1402;
					Match(BREAK);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 1405;
				Match(SEMICOLON);
				}
				break;
			case 20:
				_localctx = new UnsafeStatementContext(_localctx);
				EnterOuterAlt(_localctx, 20);
				{
				State = 1406;
				Match(UNSAFE);
				State = 1407;
				block();
				}
				break;
			case 21:
				_localctx = new FixedStatementContext(_localctx);
				EnterOuterAlt(_localctx, 21);
				{
				State = 1408;
				Match(FIXED);
				State = 1409;
				Match(OPEN_PARENS);
				State = 1410;
				pointer_type();
				State = 1411;
				fixed_pointer_declarators();
				State = 1412;
				Match(CLOSE_PARENS);
				State = 1413;
				embedded_statement();
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

	public partial class BlockContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Statement_listContext statement_list() {
			return GetRuleContext<Statement_listContext>(0);
		}
		public BlockContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_block; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterBlock(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitBlock(this);
		}
	}

	[RuleVersion(0)]
	public BlockContext block() {
		BlockContext _localctx = new BlockContext(Context, State);
		EnterRule(_localctx, 170, RULE_block);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1417;
			Match(OPEN_BRACE);
			State = 1419;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BASE) | (1L << BOOL) | (1L << BREAK) | (1L << BY) | (1L << BYTE) | (1L << CHAR) | (1L << CHECKED) | (1L << CONST) | (1L << CONTINUE) | (1L << DECIMAL) | (1L << DEFAULT) | (1L << DELEGATE) | (1L << DESCENDING) | (1L << DO) | (1L << DOUBLE) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FALSE) | (1L << FIXED) | (1L << FLOAT) | (1L << FOR) | (1L << FOREACH) | (1L << FROM) | (1L << GET) | (1L << GOTO) | (1L << GROUP) | (1L << IF) | (1L << INT) | (1L << INTO) | (1L << JOIN) | (1L << LET) | (1L << LOCK) | (1L << LONG))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (NEW - 64)) | (1L << (NULL_ - 64)) | (1L << (OBJECT - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REF - 64)) | (1L << (REMOVE - 64)) | (1L << (RETURN - 64)) | (1L << (SBYTE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (SHORT - 64)) | (1L << (SIZEOF - 64)) | (1L << (STATIC - 64)) | (1L << (STRING - 64)) | (1L << (SWITCH - 64)) | (1L << (THIS - 64)) | (1L << (THROW - 64)) | (1L << (TRUE - 64)) | (1L << (TRY - 64)) | (1L << (TYPEOF - 64)) | (1L << (UINT - 64)) | (1L << (ULONG - 64)) | (1L << (UNCHECKED - 64)) | (1L << (UNMANAGED - 64)) | (1L << (UNSAFE - 64)) | (1L << (USHORT - 64)) | (1L << (USING - 64)) | (1L << (VAR - 64)) | (1L << (VOID - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (WHILE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (LITERAL_ACCESS - 64)) | (1L << (INTEGER_LITERAL - 64)) | (1L << (HEX_INTEGER_LITERAL - 64)) | (1L << (BIN_INTEGER_LITERAL - 64)) | (1L << (REAL_LITERAL - 64)) | (1L << (CHARACTER_LITERAL - 64)) | (1L << (REGULAR_STRING - 64)) | (1L << (VERBATIUM_STRING - 64)) | (1L << (INTERPOLATED_REGULAR_STRING_START - 64)) | (1L << (INTERPOLATED_VERBATIUM_STRING_START - 64)) | (1L << (OPEN_BRACE - 64)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (OPEN_PARENS - 129)) | (1L << (SEMICOLON - 129)) | (1L << (PLUS - 129)) | (1L << (MINUS - 129)) | (1L << (STAR - 129)) | (1L << (AMP - 129)) | (1L << (CARET - 129)) | (1L << (BANG - 129)) | (1L << (TILDE - 129)) | (1L << (OP_INC - 129)) | (1L << (OP_DEC - 129)) | (1L << (OP_RANGE - 129)))) != 0)) {
				{
				State = 1418;
				statement_list();
				}
			}

			State = 1421;
			Match(CLOSE_BRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Local_variable_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Local_variable_typeContext local_variable_type() {
			return GetRuleContext<Local_variable_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Local_variable_declaratorContext[] local_variable_declarator() {
			return GetRuleContexts<Local_variable_declaratorContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Local_variable_declaratorContext local_variable_declarator(int i) {
			return GetRuleContext<Local_variable_declaratorContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode USING() { return GetToken(CSharpParser.USING, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REF() { return GetToken(CSharpParser.REF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode READONLY() { return GetToken(CSharpParser.READONLY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FIXED() { return GetToken(CSharpParser.FIXED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Pointer_typeContext pointer_type() {
			return GetRuleContext<Pointer_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Fixed_pointer_declaratorsContext fixed_pointer_declarators() {
			return GetRuleContext<Fixed_pointer_declaratorsContext>(0);
		}
		public Local_variable_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_local_variable_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterLocal_variable_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitLocal_variable_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Local_variable_declarationContext local_variable_declaration() {
		Local_variable_declarationContext _localctx = new Local_variable_declarationContext(Context, State);
		EnterRule(_localctx, 172, RULE_local_variable_declaration);
		int _la;
		try {
			State = 1444;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ADD:
			case ALIAS:
			case ARGLIST:
			case ASCENDING:
			case ASYNC:
			case AWAIT:
			case BOOL:
			case BY:
			case BYTE:
			case CHAR:
			case DECIMAL:
			case DESCENDING:
			case DOUBLE:
			case DYNAMIC:
			case EQUALS:
			case FLOAT:
			case FROM:
			case GET:
			case GROUP:
			case INT:
			case INTO:
			case JOIN:
			case LET:
			case LONG:
			case NAMEOF:
			case OBJECT:
			case ON:
			case ORDERBY:
			case PARTIAL:
			case REF:
			case REMOVE:
			case SBYTE:
			case SELECT:
			case SET:
			case SHORT:
			case STRING:
			case UINT:
			case ULONG:
			case UNMANAGED:
			case USHORT:
			case USING:
			case VAR:
			case VOID:
			case WHEN:
			case WHERE:
			case YIELD:
			case IDENTIFIER:
			case OPEN_PARENS:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1427;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,145,Context) ) {
				case 1:
					{
					State = 1423;
					Match(USING);
					}
					break;
				case 2:
					{
					State = 1424;
					Match(REF);
					}
					break;
				case 3:
					{
					State = 1425;
					Match(REF);
					State = 1426;
					Match(READONLY);
					}
					break;
				}
				State = 1429;
				local_variable_type();
				State = 1430;
				local_variable_declarator();
				State = 1437;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 1431;
					Match(COMMA);
					State = 1432;
					local_variable_declarator();
					State = 1433;
					if (!( this.IsLocalVariableDeclaration() )) throw new FailedPredicateException(this, " this.IsLocalVariableDeclaration() ");
					}
					}
					State = 1439;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
				break;
			case FIXED:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1440;
				Match(FIXED);
				State = 1441;
				pointer_type();
				State = 1442;
				fixed_pointer_declarators();
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

	public partial class Local_variable_typeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VAR() { return GetToken(CSharpParser.VAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		public Local_variable_typeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_local_variable_type; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterLocal_variable_type(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitLocal_variable_type(this);
		}
	}

	[RuleVersion(0)]
	public Local_variable_typeContext local_variable_type() {
		Local_variable_typeContext _localctx = new Local_variable_typeContext(Context, State);
		EnterRule(_localctx, 174, RULE_local_variable_type);
		try {
			State = 1448;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,148,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1446;
				Match(VAR);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1447;
				type_();
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

	public partial class Local_variable_declaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGNMENT() { return GetToken(CSharpParser.ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Local_variable_initializerContext local_variable_initializer() {
			return GetRuleContext<Local_variable_initializerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REF() { return GetToken(CSharpParser.REF, 0); }
		public Local_variable_declaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_local_variable_declarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterLocal_variable_declarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitLocal_variable_declarator(this);
		}
	}

	[RuleVersion(0)]
	public Local_variable_declaratorContext local_variable_declarator() {
		Local_variable_declaratorContext _localctx = new Local_variable_declaratorContext(Context, State);
		EnterRule(_localctx, 176, RULE_local_variable_declarator);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1450;
			identifier();
			State = 1456;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,150,Context) ) {
			case 1:
				{
				State = 1451;
				Match(ASSIGNMENT);
				State = 1453;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,149,Context) ) {
				case 1:
					{
					State = 1452;
					Match(REF);
					}
					break;
				}
				State = 1455;
				local_variable_initializer();
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

	public partial class Local_variable_initializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Array_initializerContext array_initializer() {
			return GetRuleContext<Array_initializerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Stackalloc_initializerContext stackalloc_initializer() {
			return GetRuleContext<Stackalloc_initializerContext>(0);
		}
		public Local_variable_initializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_local_variable_initializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterLocal_variable_initializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitLocal_variable_initializer(this);
		}
	}

	[RuleVersion(0)]
	public Local_variable_initializerContext local_variable_initializer() {
		Local_variable_initializerContext _localctx = new Local_variable_initializerContext(Context, State);
		EnterRule(_localctx, 178, RULE_local_variable_initializer);
		try {
			State = 1461;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ADD:
			case ALIAS:
			case ARGLIST:
			case ASCENDING:
			case ASYNC:
			case AWAIT:
			case BASE:
			case BOOL:
			case BY:
			case BYTE:
			case CHAR:
			case CHECKED:
			case DECIMAL:
			case DEFAULT:
			case DELEGATE:
			case DESCENDING:
			case DOUBLE:
			case DYNAMIC:
			case EQUALS:
			case FALSE:
			case FLOAT:
			case FROM:
			case GET:
			case GROUP:
			case INT:
			case INTO:
			case JOIN:
			case LET:
			case LONG:
			case NAMEOF:
			case NEW:
			case NULL_:
			case OBJECT:
			case ON:
			case ORDERBY:
			case PARTIAL:
			case REF:
			case REMOVE:
			case SBYTE:
			case SELECT:
			case SET:
			case SHORT:
			case SIZEOF:
			case STRING:
			case THIS:
			case TRUE:
			case TYPEOF:
			case UINT:
			case ULONG:
			case UNCHECKED:
			case UNMANAGED:
			case USHORT:
			case VAR:
			case WHEN:
			case WHERE:
			case YIELD:
			case IDENTIFIER:
			case LITERAL_ACCESS:
			case INTEGER_LITERAL:
			case HEX_INTEGER_LITERAL:
			case BIN_INTEGER_LITERAL:
			case REAL_LITERAL:
			case CHARACTER_LITERAL:
			case REGULAR_STRING:
			case VERBATIUM_STRING:
			case INTERPOLATED_REGULAR_STRING_START:
			case INTERPOLATED_VERBATIUM_STRING_START:
			case OPEN_PARENS:
			case PLUS:
			case MINUS:
			case STAR:
			case AMP:
			case CARET:
			case BANG:
			case TILDE:
			case OP_INC:
			case OP_DEC:
			case OP_RANGE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1458;
				expression();
				}
				break;
			case OPEN_BRACE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1459;
				array_initializer();
				}
				break;
			case STACKALLOC:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1460;
				stackalloc_initializer();
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

	public partial class Local_constant_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CONST() { return GetToken(CSharpParser.CONST, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Constant_declaratorsContext constant_declarators() {
			return GetRuleContext<Constant_declaratorsContext>(0);
		}
		public Local_constant_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_local_constant_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterLocal_constant_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitLocal_constant_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Local_constant_declarationContext local_constant_declaration() {
		Local_constant_declarationContext _localctx = new Local_constant_declarationContext(Context, State);
		EnterRule(_localctx, 180, RULE_local_constant_declaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1463;
			Match(CONST);
			State = 1464;
			type_();
			State = 1465;
			constant_declarators();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class If_bodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Simple_embedded_statementContext simple_embedded_statement() {
			return GetRuleContext<Simple_embedded_statementContext>(0);
		}
		public If_bodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_if_body; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterIf_body(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitIf_body(this);
		}
	}

	[RuleVersion(0)]
	public If_bodyContext if_body() {
		If_bodyContext _localctx = new If_bodyContext(Context, State);
		EnterRule(_localctx, 182, RULE_if_body);
		try {
			State = 1469;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case OPEN_BRACE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1467;
				block();
				}
				break;
			case ADD:
			case ALIAS:
			case ARGLIST:
			case ASCENDING:
			case ASYNC:
			case AWAIT:
			case BASE:
			case BOOL:
			case BREAK:
			case BY:
			case BYTE:
			case CHAR:
			case CHECKED:
			case CONTINUE:
			case DECIMAL:
			case DEFAULT:
			case DELEGATE:
			case DESCENDING:
			case DO:
			case DOUBLE:
			case DYNAMIC:
			case EQUALS:
			case FALSE:
			case FIXED:
			case FLOAT:
			case FOR:
			case FOREACH:
			case FROM:
			case GET:
			case GOTO:
			case GROUP:
			case IF:
			case INT:
			case INTO:
			case JOIN:
			case LET:
			case LOCK:
			case LONG:
			case NAMEOF:
			case NEW:
			case NULL_:
			case OBJECT:
			case ON:
			case ORDERBY:
			case PARTIAL:
			case REF:
			case REMOVE:
			case RETURN:
			case SBYTE:
			case SELECT:
			case SET:
			case SHORT:
			case SIZEOF:
			case STRING:
			case SWITCH:
			case THIS:
			case THROW:
			case TRUE:
			case TRY:
			case TYPEOF:
			case UINT:
			case ULONG:
			case UNCHECKED:
			case UNMANAGED:
			case UNSAFE:
			case USHORT:
			case USING:
			case VAR:
			case WHEN:
			case WHERE:
			case WHILE:
			case YIELD:
			case IDENTIFIER:
			case LITERAL_ACCESS:
			case INTEGER_LITERAL:
			case HEX_INTEGER_LITERAL:
			case BIN_INTEGER_LITERAL:
			case REAL_LITERAL:
			case CHARACTER_LITERAL:
			case REGULAR_STRING:
			case VERBATIUM_STRING:
			case INTERPOLATED_REGULAR_STRING_START:
			case INTERPOLATED_VERBATIUM_STRING_START:
			case OPEN_PARENS:
			case SEMICOLON:
			case PLUS:
			case MINUS:
			case STAR:
			case AMP:
			case CARET:
			case BANG:
			case TILDE:
			case OP_INC:
			case OP_DEC:
			case OP_RANGE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1468;
				simple_embedded_statement();
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

	public partial class Switch_sectionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Statement_listContext statement_list() {
			return GetRuleContext<Statement_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Switch_labelContext[] switch_label() {
			return GetRuleContexts<Switch_labelContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Switch_labelContext switch_label(int i) {
			return GetRuleContext<Switch_labelContext>(i);
		}
		public Switch_sectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_switch_section; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterSwitch_section(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitSwitch_section(this);
		}
	}

	[RuleVersion(0)]
	public Switch_sectionContext switch_section() {
		Switch_sectionContext _localctx = new Switch_sectionContext(Context, State);
		EnterRule(_localctx, 184, RULE_switch_section);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1472;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 1471;
					switch_label();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 1474;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,153,Context);
			} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
			State = 1476;
			statement_list();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Switch_labelContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CASE() { return GetToken(CSharpParser.CASE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(CSharpParser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Case_guardContext case_guard() {
			return GetRuleContext<Case_guardContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFAULT() { return GetToken(CSharpParser.DEFAULT, 0); }
		public Switch_labelContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_switch_label; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterSwitch_label(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitSwitch_label(this);
		}
	}

	[RuleVersion(0)]
	public Switch_labelContext switch_label() {
		Switch_labelContext _localctx = new Switch_labelContext(Context, State);
		EnterRule(_localctx, 186, RULE_switch_label);
		int _la;
		try {
			State = 1487;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case CASE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1478;
				Match(CASE);
				State = 1479;
				expression();
				State = 1481;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==WHEN) {
					{
					State = 1480;
					case_guard();
					}
				}

				State = 1483;
				Match(COLON);
				}
				break;
			case DEFAULT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1485;
				Match(DEFAULT);
				State = 1486;
				Match(COLON);
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

	public partial class Case_guardContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHEN() { return GetToken(CSharpParser.WHEN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public Case_guardContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_case_guard; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterCase_guard(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitCase_guard(this);
		}
	}

	[RuleVersion(0)]
	public Case_guardContext case_guard() {
		Case_guardContext _localctx = new Case_guardContext(Context, State);
		EnterRule(_localctx, 188, RULE_case_guard);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1489;
			Match(WHEN);
			State = 1490;
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

	public partial class Statement_listContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public Statement_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement_list; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterStatement_list(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitStatement_list(this);
		}
	}

	[RuleVersion(0)]
	public Statement_listContext statement_list() {
		Statement_listContext _localctx = new Statement_listContext(Context, State);
		EnterRule(_localctx, 190, RULE_statement_list);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1493;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 1492;
					statement();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 1495;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,156,Context);
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

	public partial class For_initializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Local_variable_declarationContext local_variable_declaration() {
			return GetRuleContext<Local_variable_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public For_initializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_for_initializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterFor_initializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitFor_initializer(this);
		}
	}

	[RuleVersion(0)]
	public For_initializerContext for_initializer() {
		For_initializerContext _localctx = new For_initializerContext(Context, State);
		EnterRule(_localctx, 192, RULE_for_initializer);
		int _la;
		try {
			State = 1506;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,158,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1497;
				local_variable_declaration();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1498;
				expression();
				State = 1503;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 1499;
					Match(COMMA);
					State = 1500;
					expression();
					}
					}
					State = 1505;
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

	public partial class For_iteratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public For_iteratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_for_iterator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterFor_iterator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitFor_iterator(this);
		}
	}

	[RuleVersion(0)]
	public For_iteratorContext for_iterator() {
		For_iteratorContext _localctx = new For_iteratorContext(Context, State);
		EnterRule(_localctx, 194, RULE_for_iterator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1508;
			expression();
			State = 1513;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1509;
				Match(COMMA);
				State = 1510;
				expression();
				}
				}
				State = 1515;
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

	public partial class Catch_clausesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Specific_catch_clauseContext[] specific_catch_clause() {
			return GetRuleContexts<Specific_catch_clauseContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Specific_catch_clauseContext specific_catch_clause(int i) {
			return GetRuleContext<Specific_catch_clauseContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public General_catch_clauseContext general_catch_clause() {
			return GetRuleContext<General_catch_clauseContext>(0);
		}
		public Catch_clausesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_catch_clauses; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterCatch_clauses(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitCatch_clauses(this);
		}
	}

	[RuleVersion(0)]
	public Catch_clausesContext catch_clauses() {
		Catch_clausesContext _localctx = new Catch_clausesContext(Context, State);
		EnterRule(_localctx, 196, RULE_catch_clauses);
		int _la;
		try {
			int _alt;
			State = 1527;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,162,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1516;
				specific_catch_clause();
				State = 1520;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,160,Context);
				while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						State = 1517;
						specific_catch_clause();
						}
						} 
					}
					State = 1522;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,160,Context);
				}
				State = 1524;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==CATCH) {
					{
					State = 1523;
					general_catch_clause();
					}
				}

				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1526;
				general_catch_clause();
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

	public partial class Specific_catch_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CATCH() { return GetToken(CSharpParser.CATCH, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Class_typeContext class_type() {
			return GetRuleContext<Class_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Exception_filterContext exception_filter() {
			return GetRuleContext<Exception_filterContext>(0);
		}
		public Specific_catch_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_specific_catch_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterSpecific_catch_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitSpecific_catch_clause(this);
		}
	}

	[RuleVersion(0)]
	public Specific_catch_clauseContext specific_catch_clause() {
		Specific_catch_clauseContext _localctx = new Specific_catch_clauseContext(Context, State);
		EnterRule(_localctx, 198, RULE_specific_catch_clause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1529;
			Match(CATCH);
			State = 1530;
			Match(OPEN_PARENS);
			State = 1531;
			class_type();
			State = 1533;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BY) | (1L << DESCENDING) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << INTO) | (1L << JOIN) | (1L << LET))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REMOVE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (UNMANAGED - 64)) | (1L << (VAR - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)))) != 0)) {
				{
				State = 1532;
				identifier();
				}
			}

			State = 1535;
			Match(CLOSE_PARENS);
			State = 1537;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WHEN) {
				{
				State = 1536;
				exception_filter();
				}
			}

			State = 1539;
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

	public partial class General_catch_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CATCH() { return GetToken(CSharpParser.CATCH, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Exception_filterContext exception_filter() {
			return GetRuleContext<Exception_filterContext>(0);
		}
		public General_catch_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_general_catch_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterGeneral_catch_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitGeneral_catch_clause(this);
		}
	}

	[RuleVersion(0)]
	public General_catch_clauseContext general_catch_clause() {
		General_catch_clauseContext _localctx = new General_catch_clauseContext(Context, State);
		EnterRule(_localctx, 200, RULE_general_catch_clause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1541;
			Match(CATCH);
			State = 1543;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WHEN) {
				{
				State = 1542;
				exception_filter();
				}
			}

			State = 1545;
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

	public partial class Exception_filterContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHEN() { return GetToken(CSharpParser.WHEN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		public Exception_filterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exception_filter; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterException_filter(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitException_filter(this);
		}
	}

	[RuleVersion(0)]
	public Exception_filterContext exception_filter() {
		Exception_filterContext _localctx = new Exception_filterContext(Context, State);
		EnterRule(_localctx, 202, RULE_exception_filter);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1547;
			Match(WHEN);
			State = 1548;
			Match(OPEN_PARENS);
			State = 1549;
			expression();
			State = 1550;
			Match(CLOSE_PARENS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Finally_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FINALLY() { return GetToken(CSharpParser.FINALLY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public Finally_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_finally_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterFinally_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitFinally_clause(this);
		}
	}

	[RuleVersion(0)]
	public Finally_clauseContext finally_clause() {
		Finally_clauseContext _localctx = new Finally_clauseContext(Context, State);
		EnterRule(_localctx, 204, RULE_finally_clause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1552;
			Match(FINALLY);
			State = 1553;
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

	public partial class Resource_acquisitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Local_variable_declarationContext local_variable_declaration() {
			return GetRuleContext<Local_variable_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public Resource_acquisitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_resource_acquisition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterResource_acquisition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitResource_acquisition(this);
		}
	}

	[RuleVersion(0)]
	public Resource_acquisitionContext resource_acquisition() {
		Resource_acquisitionContext _localctx = new Resource_acquisitionContext(Context, State);
		EnterRule(_localctx, 206, RULE_resource_acquisition);
		try {
			State = 1557;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,166,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1555;
				local_variable_declaration();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1556;
				expression();
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

	public partial class Namespace_declarationContext : ParserRuleContext {
		public Qualified_identifierContext qi;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NAMESPACE() { return GetToken(CSharpParser.NAMESPACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_bodyContext namespace_body() {
			return GetRuleContext<Namespace_bodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Qualified_identifierContext qualified_identifier() {
			return GetRuleContext<Qualified_identifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public Namespace_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namespace_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterNamespace_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitNamespace_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Namespace_declarationContext namespace_declaration() {
		Namespace_declarationContext _localctx = new Namespace_declarationContext(Context, State);
		EnterRule(_localctx, 208, RULE_namespace_declaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1559;
			Match(NAMESPACE);
			State = 1560;
			_localctx.qi = qualified_identifier();
			State = 1561;
			namespace_body();
			State = 1563;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SEMICOLON) {
				{
				State = 1562;
				Match(SEMICOLON);
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

	public partial class Qualified_identifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DOT() { return GetTokens(CSharpParser.DOT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT(int i) {
			return GetToken(CSharpParser.DOT, i);
		}
		public Qualified_identifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_qualified_identifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterQualified_identifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitQualified_identifier(this);
		}
	}

	[RuleVersion(0)]
	public Qualified_identifierContext qualified_identifier() {
		Qualified_identifierContext _localctx = new Qualified_identifierContext(Context, State);
		EnterRule(_localctx, 210, RULE_qualified_identifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1565;
			identifier();
			State = 1570;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==DOT) {
				{
				{
				State = 1566;
				Match(DOT);
				State = 1567;
				identifier();
				}
				}
				State = 1572;
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

	public partial class Namespace_bodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Extern_alias_directivesContext extern_alias_directives() {
			return GetRuleContext<Extern_alias_directivesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Using_directivesContext using_directives() {
			return GetRuleContext<Using_directivesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_member_declarationsContext namespace_member_declarations() {
			return GetRuleContext<Namespace_member_declarationsContext>(0);
		}
		public Namespace_bodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namespace_body; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterNamespace_body(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitNamespace_body(this);
		}
	}

	[RuleVersion(0)]
	public Namespace_bodyContext namespace_body() {
		Namespace_bodyContext _localctx = new Namespace_bodyContext(Context, State);
		EnterRule(_localctx, 212, RULE_namespace_body);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1573;
			Match(OPEN_BRACE);
			State = 1575;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,169,Context) ) {
			case 1:
				{
				State = 1574;
				extern_alias_directives();
				}
				break;
			}
			State = 1578;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==USING) {
				{
				State = 1577;
				using_directives();
				}
			}

			State = 1581;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << ASYNC) | (1L << CLASS) | (1L << DELEGATE) | (1L << ENUM) | (1L << EXTERN) | (1L << INTERFACE) | (1L << INTERNAL))) != 0) || ((((_la - 65)) & ~0x3f) == 0 && ((1L << (_la - 65)) & ((1L << (NAMESPACE - 65)) | (1L << (NEW - 65)) | (1L << (OVERRIDE - 65)) | (1L << (PARTIAL - 65)) | (1L << (PRIVATE - 65)) | (1L << (PROTECTED - 65)) | (1L << (PUBLIC - 65)) | (1L << (READONLY - 65)) | (1L << (REF - 65)) | (1L << (SEALED - 65)) | (1L << (STATIC - 65)) | (1L << (STRUCT - 65)) | (1L << (UNSAFE - 65)) | (1L << (VIRTUAL - 65)) | (1L << (VOLATILE - 65)) | (1L << (OPEN_BRACKET - 65)))) != 0)) {
				{
				State = 1580;
				namespace_member_declarations();
				}
			}

			State = 1583;
			Match(CLOSE_BRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Extern_alias_directivesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Extern_alias_directiveContext[] extern_alias_directive() {
			return GetRuleContexts<Extern_alias_directiveContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Extern_alias_directiveContext extern_alias_directive(int i) {
			return GetRuleContext<Extern_alias_directiveContext>(i);
		}
		public Extern_alias_directivesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_extern_alias_directives; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterExtern_alias_directives(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitExtern_alias_directives(this);
		}
	}

	[RuleVersion(0)]
	public Extern_alias_directivesContext extern_alias_directives() {
		Extern_alias_directivesContext _localctx = new Extern_alias_directivesContext(Context, State);
		EnterRule(_localctx, 214, RULE_extern_alias_directives);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1586;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 1585;
					extern_alias_directive();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 1588;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,172,Context);
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

	public partial class Extern_alias_directiveContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXTERN() { return GetToken(CSharpParser.EXTERN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ALIAS() { return GetToken(CSharpParser.ALIAS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public Extern_alias_directiveContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_extern_alias_directive; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterExtern_alias_directive(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitExtern_alias_directive(this);
		}
	}

	[RuleVersion(0)]
	public Extern_alias_directiveContext extern_alias_directive() {
		Extern_alias_directiveContext _localctx = new Extern_alias_directiveContext(Context, State);
		EnterRule(_localctx, 216, RULE_extern_alias_directive);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1590;
			Match(EXTERN);
			State = 1591;
			Match(ALIAS);
			State = 1592;
			identifier();
			State = 1593;
			Match(SEMICOLON);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Using_directivesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Using_directiveContext[] using_directive() {
			return GetRuleContexts<Using_directiveContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Using_directiveContext using_directive(int i) {
			return GetRuleContext<Using_directiveContext>(i);
		}
		public Using_directivesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_using_directives; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterUsing_directives(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitUsing_directives(this);
		}
	}

	[RuleVersion(0)]
	public Using_directivesContext using_directives() {
		Using_directivesContext _localctx = new Using_directivesContext(Context, State);
		EnterRule(_localctx, 218, RULE_using_directives);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1596;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 1595;
				using_directive();
				}
				}
				State = 1598;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==USING );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Using_directiveContext : ParserRuleContext {
		public Using_directiveContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_using_directive; } }
	 
		public Using_directiveContext() { }
		public virtual void CopyFrom(Using_directiveContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class UsingAliasDirectiveContext : Using_directiveContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode USING() { return GetToken(CSharpParser.USING, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGNMENT() { return GetToken(CSharpParser.ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_or_type_nameContext namespace_or_type_name() {
			return GetRuleContext<Namespace_or_type_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public UsingAliasDirectiveContext(Using_directiveContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterUsingAliasDirective(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitUsingAliasDirective(this);
		}
	}
	public partial class UsingNamespaceDirectiveContext : Using_directiveContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode USING() { return GetToken(CSharpParser.USING, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_or_type_nameContext namespace_or_type_name() {
			return GetRuleContext<Namespace_or_type_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public UsingNamespaceDirectiveContext(Using_directiveContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterUsingNamespaceDirective(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitUsingNamespaceDirective(this);
		}
	}
	public partial class UsingStaticDirectiveContext : Using_directiveContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode USING() { return GetToken(CSharpParser.USING, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(CSharpParser.STATIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_or_type_nameContext namespace_or_type_name() {
			return GetRuleContext<Namespace_or_type_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public UsingStaticDirectiveContext(Using_directiveContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterUsingStaticDirective(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitUsingStaticDirective(this);
		}
	}

	[RuleVersion(0)]
	public Using_directiveContext using_directive() {
		Using_directiveContext _localctx = new Using_directiveContext(Context, State);
		EnterRule(_localctx, 220, RULE_using_directive);
		try {
			State = 1615;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,174,Context) ) {
			case 1:
				_localctx = new UsingAliasDirectiveContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 1600;
				Match(USING);
				State = 1601;
				identifier();
				State = 1602;
				Match(ASSIGNMENT);
				State = 1603;
				namespace_or_type_name();
				State = 1604;
				Match(SEMICOLON);
				}
				break;
			case 2:
				_localctx = new UsingNamespaceDirectiveContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 1606;
				Match(USING);
				State = 1607;
				namespace_or_type_name();
				State = 1608;
				Match(SEMICOLON);
				}
				break;
			case 3:
				_localctx = new UsingStaticDirectiveContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 1610;
				Match(USING);
				State = 1611;
				Match(STATIC);
				State = 1612;
				namespace_or_type_name();
				State = 1613;
				Match(SEMICOLON);
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

	public partial class Namespace_member_declarationsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_member_declarationContext[] namespace_member_declaration() {
			return GetRuleContexts<Namespace_member_declarationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_member_declarationContext namespace_member_declaration(int i) {
			return GetRuleContext<Namespace_member_declarationContext>(i);
		}
		public Namespace_member_declarationsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namespace_member_declarations; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterNamespace_member_declarations(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitNamespace_member_declarations(this);
		}
	}

	[RuleVersion(0)]
	public Namespace_member_declarationsContext namespace_member_declarations() {
		Namespace_member_declarationsContext _localctx = new Namespace_member_declarationsContext(Context, State);
		EnterRule(_localctx, 222, RULE_namespace_member_declarations);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1618;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 1617;
				namespace_member_declaration();
				}
				}
				State = 1620;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << ASYNC) | (1L << CLASS) | (1L << DELEGATE) | (1L << ENUM) | (1L << EXTERN) | (1L << INTERFACE) | (1L << INTERNAL))) != 0) || ((((_la - 65)) & ~0x3f) == 0 && ((1L << (_la - 65)) & ((1L << (NAMESPACE - 65)) | (1L << (NEW - 65)) | (1L << (OVERRIDE - 65)) | (1L << (PARTIAL - 65)) | (1L << (PRIVATE - 65)) | (1L << (PROTECTED - 65)) | (1L << (PUBLIC - 65)) | (1L << (READONLY - 65)) | (1L << (REF - 65)) | (1L << (SEALED - 65)) | (1L << (STATIC - 65)) | (1L << (STRUCT - 65)) | (1L << (UNSAFE - 65)) | (1L << (VIRTUAL - 65)) | (1L << (VOLATILE - 65)) | (1L << (OPEN_BRACKET - 65)))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Namespace_member_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_declarationContext namespace_declaration() {
			return GetRuleContext<Namespace_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_declarationContext type_declaration() {
			return GetRuleContext<Type_declarationContext>(0);
		}
		public Namespace_member_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_namespace_member_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterNamespace_member_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitNamespace_member_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Namespace_member_declarationContext namespace_member_declaration() {
		Namespace_member_declarationContext _localctx = new Namespace_member_declarationContext(Context, State);
		EnterRule(_localctx, 224, RULE_namespace_member_declaration);
		try {
			State = 1624;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case NAMESPACE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1622;
				namespace_declaration();
				}
				break;
			case ABSTRACT:
			case ASYNC:
			case CLASS:
			case DELEGATE:
			case ENUM:
			case EXTERN:
			case INTERFACE:
			case INTERNAL:
			case NEW:
			case OVERRIDE:
			case PARTIAL:
			case PRIVATE:
			case PROTECTED:
			case PUBLIC:
			case READONLY:
			case REF:
			case SEALED:
			case STATIC:
			case STRUCT:
			case UNSAFE:
			case VIRTUAL:
			case VOLATILE:
			case OPEN_BRACKET:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1623;
				type_declaration();
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

	public partial class Type_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Class_definitionContext class_definition() {
			return GetRuleContext<Class_definitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Struct_definitionContext struct_definition() {
			return GetRuleContext<Struct_definitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Interface_definitionContext interface_definition() {
			return GetRuleContext<Interface_definitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Enum_definitionContext enum_definition() {
			return GetRuleContext<Enum_definitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Delegate_definitionContext delegate_definition() {
			return GetRuleContext<Delegate_definitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public All_member_modifiersContext all_member_modifiers() {
			return GetRuleContext<All_member_modifiersContext>(0);
		}
		public Type_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_type_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterType_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitType_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Type_declarationContext type_declaration() {
		Type_declarationContext _localctx = new Type_declarationContext(Context, State);
		EnterRule(_localctx, 226, RULE_type_declaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1627;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_BRACKET) {
				{
				State = 1626;
				attributes();
				}
			}

			State = 1630;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,178,Context) ) {
			case 1:
				{
				State = 1629;
				all_member_modifiers();
				}
				break;
			}
			State = 1637;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case CLASS:
				{
				State = 1632;
				class_definition();
				}
				break;
			case READONLY:
			case REF:
			case STRUCT:
				{
				State = 1633;
				struct_definition();
				}
				break;
			case INTERFACE:
				{
				State = 1634;
				interface_definition();
				}
				break;
			case ENUM:
				{
				State = 1635;
				enum_definition();
				}
				break;
			case DELEGATE:
				{
				State = 1636;
				delegate_definition();
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

	public partial class Qualified_alias_memberContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOUBLE_COLON() { return GetToken(CSharpParser.DOUBLE_COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_argument_listContext type_argument_list() {
			return GetRuleContext<Type_argument_listContext>(0);
		}
		public Qualified_alias_memberContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_qualified_alias_member; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterQualified_alias_member(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitQualified_alias_member(this);
		}
	}

	[RuleVersion(0)]
	public Qualified_alias_memberContext qualified_alias_member() {
		Qualified_alias_memberContext _localctx = new Qualified_alias_memberContext(Context, State);
		EnterRule(_localctx, 228, RULE_qualified_alias_member);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1639;
			identifier();
			State = 1640;
			Match(DOUBLE_COLON);
			State = 1641;
			identifier();
			State = 1643;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,180,Context) ) {
			case 1:
				{
				State = 1642;
				type_argument_list();
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

	public partial class Type_parameter_listContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LT() { return GetToken(CSharpParser.LT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_parameterContext[] type_parameter() {
			return GetRuleContexts<Type_parameterContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_parameterContext type_parameter(int i) {
			return GetRuleContext<Type_parameterContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT() { return GetToken(CSharpParser.GT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Type_parameter_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_type_parameter_list; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterType_parameter_list(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitType_parameter_list(this);
		}
	}

	[RuleVersion(0)]
	public Type_parameter_listContext type_parameter_list() {
		Type_parameter_listContext _localctx = new Type_parameter_listContext(Context, State);
		EnterRule(_localctx, 230, RULE_type_parameter_list);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1645;
			Match(LT);
			State = 1646;
			type_parameter();
			State = 1651;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1647;
				Match(COMMA);
				State = 1648;
				type_parameter();
				}
				}
				State = 1653;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1654;
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

	public partial class Type_parameterContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		public Type_parameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_type_parameter; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterType_parameter(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitType_parameter(this);
		}
	}

	[RuleVersion(0)]
	public Type_parameterContext type_parameter() {
		Type_parameterContext _localctx = new Type_parameterContext(Context, State);
		EnterRule(_localctx, 232, RULE_type_parameter);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1657;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_BRACKET) {
				{
				State = 1656;
				attributes();
				}
			}

			State = 1659;
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

	public partial class Class_baseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(CSharpParser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Class_typeContext class_type() {
			return GetRuleContext<Class_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_or_type_nameContext[] namespace_or_type_name() {
			return GetRuleContexts<Namespace_or_type_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_or_type_nameContext namespace_or_type_name(int i) {
			return GetRuleContext<Namespace_or_type_nameContext>(i);
		}
		public Class_baseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_class_base; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterClass_base(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitClass_base(this);
		}
	}

	[RuleVersion(0)]
	public Class_baseContext class_base() {
		Class_baseContext _localctx = new Class_baseContext(Context, State);
		EnterRule(_localctx, 234, RULE_class_base);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1661;
			Match(COLON);
			State = 1662;
			class_type();
			State = 1667;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1663;
				Match(COMMA);
				State = 1664;
				namespace_or_type_name();
				}
				}
				State = 1669;
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

	public partial class Interface_type_listContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_or_type_nameContext[] namespace_or_type_name() {
			return GetRuleContexts<Namespace_or_type_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_or_type_nameContext namespace_or_type_name(int i) {
			return GetRuleContext<Namespace_or_type_nameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Interface_type_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interface_type_list; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterInterface_type_list(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitInterface_type_list(this);
		}
	}

	[RuleVersion(0)]
	public Interface_type_listContext interface_type_list() {
		Interface_type_listContext _localctx = new Interface_type_listContext(Context, State);
		EnterRule(_localctx, 236, RULE_interface_type_list);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1670;
			namespace_or_type_name();
			State = 1675;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1671;
				Match(COMMA);
				State = 1672;
				namespace_or_type_name();
				}
				}
				State = 1677;
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

	public partial class Type_parameter_constraints_clausesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Type_parameter_constraints_clauseContext[] type_parameter_constraints_clause() {
			return GetRuleContexts<Type_parameter_constraints_clauseContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_parameter_constraints_clauseContext type_parameter_constraints_clause(int i) {
			return GetRuleContext<Type_parameter_constraints_clauseContext>(i);
		}
		public Type_parameter_constraints_clausesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_type_parameter_constraints_clauses; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterType_parameter_constraints_clauses(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitType_parameter_constraints_clauses(this);
		}
	}

	[RuleVersion(0)]
	public Type_parameter_constraints_clausesContext type_parameter_constraints_clauses() {
		Type_parameter_constraints_clausesContext _localctx = new Type_parameter_constraints_clausesContext(Context, State);
		EnterRule(_localctx, 238, RULE_type_parameter_constraints_clauses);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1679;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 1678;
				type_parameter_constraints_clause();
				}
				}
				State = 1681;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==WHERE );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Type_parameter_constraints_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHERE() { return GetToken(CSharpParser.WHERE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(CSharpParser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_parameter_constraintsContext type_parameter_constraints() {
			return GetRuleContext<Type_parameter_constraintsContext>(0);
		}
		public Type_parameter_constraints_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_type_parameter_constraints_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterType_parameter_constraints_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitType_parameter_constraints_clause(this);
		}
	}

	[RuleVersion(0)]
	public Type_parameter_constraints_clauseContext type_parameter_constraints_clause() {
		Type_parameter_constraints_clauseContext _localctx = new Type_parameter_constraints_clauseContext(Context, State);
		EnterRule(_localctx, 240, RULE_type_parameter_constraints_clause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1683;
			Match(WHERE);
			State = 1684;
			identifier();
			State = 1685;
			Match(COLON);
			State = 1686;
			type_parameter_constraints();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Type_parameter_constraintsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Constructor_constraintContext constructor_constraint() {
			return GetRuleContext<Constructor_constraintContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Primary_constraintContext primary_constraint() {
			return GetRuleContext<Primary_constraintContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Secondary_constraintsContext secondary_constraints() {
			return GetRuleContext<Secondary_constraintsContext>(0);
		}
		public Type_parameter_constraintsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_type_parameter_constraints; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterType_parameter_constraints(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitType_parameter_constraints(this);
		}
	}

	[RuleVersion(0)]
	public Type_parameter_constraintsContext type_parameter_constraints() {
		Type_parameter_constraintsContext _localctx = new Type_parameter_constraintsContext(Context, State);
		EnterRule(_localctx, 242, RULE_type_parameter_constraints);
		int _la;
		try {
			State = 1698;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case NEW:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1688;
				constructor_constraint();
				}
				break;
			case ADD:
			case ALIAS:
			case ARGLIST:
			case ASCENDING:
			case ASYNC:
			case AWAIT:
			case BY:
			case CLASS:
			case DESCENDING:
			case DYNAMIC:
			case EQUALS:
			case FROM:
			case GET:
			case GROUP:
			case INTO:
			case JOIN:
			case LET:
			case NAMEOF:
			case OBJECT:
			case ON:
			case ORDERBY:
			case PARTIAL:
			case REMOVE:
			case SELECT:
			case SET:
			case STRING:
			case STRUCT:
			case UNMANAGED:
			case VAR:
			case WHEN:
			case WHERE:
			case YIELD:
			case IDENTIFIER:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1689;
				primary_constraint();
				State = 1692;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,186,Context) ) {
				case 1:
					{
					State = 1690;
					Match(COMMA);
					State = 1691;
					secondary_constraints();
					}
					break;
				}
				State = 1696;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==COMMA) {
					{
					State = 1694;
					Match(COMMA);
					State = 1695;
					constructor_constraint();
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

	public partial class Primary_constraintContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Class_typeContext class_type() {
			return GetRuleContext<Class_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLASS() { return GetToken(CSharpParser.CLASS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERR() { return GetToken(CSharpParser.INTERR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRUCT() { return GetToken(CSharpParser.STRUCT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNMANAGED() { return GetToken(CSharpParser.UNMANAGED, 0); }
		public Primary_constraintContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_primary_constraint; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterPrimary_constraint(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitPrimary_constraint(this);
		}
	}

	[RuleVersion(0)]
	public Primary_constraintContext primary_constraint() {
		Primary_constraintContext _localctx = new Primary_constraintContext(Context, State);
		EnterRule(_localctx, 244, RULE_primary_constraint);
		int _la;
		try {
			State = 1707;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,190,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1700;
				class_type();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1701;
				Match(CLASS);
				State = 1703;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==INTERR) {
					{
					State = 1702;
					Match(INTERR);
					}
				}

				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1705;
				Match(STRUCT);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1706;
				Match(UNMANAGED);
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

	public partial class Secondary_constraintsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_or_type_nameContext[] namespace_or_type_name() {
			return GetRuleContexts<Namespace_or_type_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_or_type_nameContext namespace_or_type_name(int i) {
			return GetRuleContext<Namespace_or_type_nameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Secondary_constraintsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_secondary_constraints; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterSecondary_constraints(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitSecondary_constraints(this);
		}
	}

	[RuleVersion(0)]
	public Secondary_constraintsContext secondary_constraints() {
		Secondary_constraintsContext _localctx = new Secondary_constraintsContext(Context, State);
		EnterRule(_localctx, 246, RULE_secondary_constraints);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1709;
			namespace_or_type_name();
			State = 1714;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,191,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1710;
					Match(COMMA);
					State = 1711;
					namespace_or_type_name();
					}
					} 
				}
				State = 1716;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,191,Context);
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

	public partial class Constructor_constraintContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEW() { return GetToken(CSharpParser.NEW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		public Constructor_constraintContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constructor_constraint; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterConstructor_constraint(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitConstructor_constraint(this);
		}
	}

	[RuleVersion(0)]
	public Constructor_constraintContext constructor_constraint() {
		Constructor_constraintContext _localctx = new Constructor_constraintContext(Context, State);
		EnterRule(_localctx, 248, RULE_constructor_constraint);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1717;
			Match(NEW);
			State = 1718;
			Match(OPEN_PARENS);
			State = 1719;
			Match(CLOSE_PARENS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Class_bodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Class_member_declarationsContext class_member_declarations() {
			return GetRuleContext<Class_member_declarationsContext>(0);
		}
		public Class_bodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_class_body; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterClass_body(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitClass_body(this);
		}
	}

	[RuleVersion(0)]
	public Class_bodyContext class_body() {
		Class_bodyContext _localctx = new Class_bodyContext(Context, State);
		EnterRule(_localctx, 250, RULE_class_body);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1721;
			Match(OPEN_BRACE);
			State = 1723;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BOOL) | (1L << BY) | (1L << BYTE) | (1L << CHAR) | (1L << CLASS) | (1L << CONST) | (1L << DECIMAL) | (1L << DELEGATE) | (1L << DESCENDING) | (1L << DOUBLE) | (1L << DYNAMIC) | (1L << ENUM) | (1L << EQUALS) | (1L << EVENT) | (1L << EXPLICIT) | (1L << EXTERN) | (1L << FLOAT) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << IMPLICIT) | (1L << INT) | (1L << INTERFACE) | (1L << INTERNAL) | (1L << INTO) | (1L << JOIN) | (1L << LET) | (1L << LONG))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (NEW - 64)) | (1L << (OBJECT - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (OVERRIDE - 64)) | (1L << (PARTIAL - 64)) | (1L << (PRIVATE - 64)) | (1L << (PROTECTED - 64)) | (1L << (PUBLIC - 64)) | (1L << (READONLY - 64)) | (1L << (REF - 64)) | (1L << (REMOVE - 64)) | (1L << (SBYTE - 64)) | (1L << (SEALED - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (SHORT - 64)) | (1L << (STATIC - 64)) | (1L << (STRING - 64)) | (1L << (STRUCT - 64)) | (1L << (UINT - 64)) | (1L << (ULONG - 64)) | (1L << (UNMANAGED - 64)) | (1L << (UNSAFE - 64)) | (1L << (USHORT - 64)) | (1L << (VAR - 64)) | (1L << (VIRTUAL - 64)) | (1L << (VOID - 64)) | (1L << (VOLATILE - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (OPEN_BRACKET - 64)))) != 0) || _la==OPEN_PARENS || _la==TILDE) {
				{
				State = 1722;
				class_member_declarations();
				}
			}

			State = 1725;
			Match(CLOSE_BRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Class_member_declarationsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Class_member_declarationContext[] class_member_declaration() {
			return GetRuleContexts<Class_member_declarationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Class_member_declarationContext class_member_declaration(int i) {
			return GetRuleContext<Class_member_declarationContext>(i);
		}
		public Class_member_declarationsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_class_member_declarations; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterClass_member_declarations(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitClass_member_declarations(this);
		}
	}

	[RuleVersion(0)]
	public Class_member_declarationsContext class_member_declarations() {
		Class_member_declarationsContext _localctx = new Class_member_declarationsContext(Context, State);
		EnterRule(_localctx, 252, RULE_class_member_declarations);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1728;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 1727;
				class_member_declaration();
				}
				}
				State = 1730;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BOOL) | (1L << BY) | (1L << BYTE) | (1L << CHAR) | (1L << CLASS) | (1L << CONST) | (1L << DECIMAL) | (1L << DELEGATE) | (1L << DESCENDING) | (1L << DOUBLE) | (1L << DYNAMIC) | (1L << ENUM) | (1L << EQUALS) | (1L << EVENT) | (1L << EXPLICIT) | (1L << EXTERN) | (1L << FLOAT) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << IMPLICIT) | (1L << INT) | (1L << INTERFACE) | (1L << INTERNAL) | (1L << INTO) | (1L << JOIN) | (1L << LET) | (1L << LONG))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (NEW - 64)) | (1L << (OBJECT - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (OVERRIDE - 64)) | (1L << (PARTIAL - 64)) | (1L << (PRIVATE - 64)) | (1L << (PROTECTED - 64)) | (1L << (PUBLIC - 64)) | (1L << (READONLY - 64)) | (1L << (REF - 64)) | (1L << (REMOVE - 64)) | (1L << (SBYTE - 64)) | (1L << (SEALED - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (SHORT - 64)) | (1L << (STATIC - 64)) | (1L << (STRING - 64)) | (1L << (STRUCT - 64)) | (1L << (UINT - 64)) | (1L << (ULONG - 64)) | (1L << (UNMANAGED - 64)) | (1L << (UNSAFE - 64)) | (1L << (USHORT - 64)) | (1L << (VAR - 64)) | (1L << (VIRTUAL - 64)) | (1L << (VOID - 64)) | (1L << (VOLATILE - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (OPEN_BRACKET - 64)))) != 0) || _la==OPEN_PARENS || _la==TILDE );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Class_member_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Common_member_declarationContext common_member_declaration() {
			return GetRuleContext<Common_member_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Destructor_definitionContext destructor_definition() {
			return GetRuleContext<Destructor_definitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public All_member_modifiersContext all_member_modifiers() {
			return GetRuleContext<All_member_modifiersContext>(0);
		}
		public Class_member_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_class_member_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterClass_member_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitClass_member_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Class_member_declarationContext class_member_declaration() {
		Class_member_declarationContext _localctx = new Class_member_declarationContext(Context, State);
		EnterRule(_localctx, 254, RULE_class_member_declaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1733;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_BRACKET) {
				{
				State = 1732;
				attributes();
				}
			}

			State = 1736;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,195,Context) ) {
			case 1:
				{
				State = 1735;
				all_member_modifiers();
				}
				break;
			}
			State = 1740;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ADD:
			case ALIAS:
			case ARGLIST:
			case ASCENDING:
			case ASYNC:
			case AWAIT:
			case BOOL:
			case BY:
			case BYTE:
			case CHAR:
			case CLASS:
			case CONST:
			case DECIMAL:
			case DELEGATE:
			case DESCENDING:
			case DOUBLE:
			case DYNAMIC:
			case ENUM:
			case EQUALS:
			case EVENT:
			case EXPLICIT:
			case FLOAT:
			case FROM:
			case GET:
			case GROUP:
			case IMPLICIT:
			case INT:
			case INTERFACE:
			case INTO:
			case JOIN:
			case LET:
			case LONG:
			case NAMEOF:
			case OBJECT:
			case ON:
			case ORDERBY:
			case PARTIAL:
			case READONLY:
			case REF:
			case REMOVE:
			case SBYTE:
			case SELECT:
			case SET:
			case SHORT:
			case STRING:
			case STRUCT:
			case UINT:
			case ULONG:
			case UNMANAGED:
			case USHORT:
			case VAR:
			case VOID:
			case WHEN:
			case WHERE:
			case YIELD:
			case IDENTIFIER:
			case OPEN_PARENS:
				{
				State = 1738;
				common_member_declaration();
				}
				break;
			case TILDE:
				{
				State = 1739;
				destructor_definition();
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

	public partial class All_member_modifiersContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public All_member_modifierContext[] all_member_modifier() {
			return GetRuleContexts<All_member_modifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public All_member_modifierContext all_member_modifier(int i) {
			return GetRuleContext<All_member_modifierContext>(i);
		}
		public All_member_modifiersContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_all_member_modifiers; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAll_member_modifiers(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAll_member_modifiers(this);
		}
	}

	[RuleVersion(0)]
	public All_member_modifiersContext all_member_modifiers() {
		All_member_modifiersContext _localctx = new All_member_modifiersContext(Context, State);
		EnterRule(_localctx, 256, RULE_all_member_modifiers);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1743;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 1742;
					all_member_modifier();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 1745;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,197,Context);
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

	public partial class All_member_modifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEW() { return GetToken(CSharpParser.NEW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLIC() { return GetToken(CSharpParser.PUBLIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PROTECTED() { return GetToken(CSharpParser.PROTECTED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERNAL() { return GetToken(CSharpParser.INTERNAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRIVATE() { return GetToken(CSharpParser.PRIVATE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode READONLY() { return GetToken(CSharpParser.READONLY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOLATILE() { return GetToken(CSharpParser.VOLATILE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VIRTUAL() { return GetToken(CSharpParser.VIRTUAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEALED() { return GetToken(CSharpParser.SEALED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OVERRIDE() { return GetToken(CSharpParser.OVERRIDE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ABSTRACT() { return GetToken(CSharpParser.ABSTRACT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(CSharpParser.STATIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNSAFE() { return GetToken(CSharpParser.UNSAFE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXTERN() { return GetToken(CSharpParser.EXTERN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PARTIAL() { return GetToken(CSharpParser.PARTIAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASYNC() { return GetToken(CSharpParser.ASYNC, 0); }
		public All_member_modifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_all_member_modifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAll_member_modifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAll_member_modifier(this);
		}
	}

	[RuleVersion(0)]
	public All_member_modifierContext all_member_modifier() {
		All_member_modifierContext _localctx = new All_member_modifierContext(Context, State);
		EnterRule(_localctx, 258, RULE_all_member_modifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1747;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << ASYNC) | (1L << EXTERN) | (1L << INTERNAL))) != 0) || ((((_la - 66)) & ~0x3f) == 0 && ((1L << (_la - 66)) & ((1L << (NEW - 66)) | (1L << (OVERRIDE - 66)) | (1L << (PARTIAL - 66)) | (1L << (PRIVATE - 66)) | (1L << (PROTECTED - 66)) | (1L << (PUBLIC - 66)) | (1L << (READONLY - 66)) | (1L << (SEALED - 66)) | (1L << (STATIC - 66)) | (1L << (UNSAFE - 66)) | (1L << (VIRTUAL - 66)) | (1L << (VOLATILE - 66)))) != 0)) ) {
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

	public partial class Common_member_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Constant_declarationContext constant_declaration() {
			return GetRuleContext<Constant_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Typed_member_declarationContext typed_member_declaration() {
			return GetRuleContext<Typed_member_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Event_declarationContext event_declaration() {
			return GetRuleContext<Event_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Conversion_operator_declaratorContext conversion_operator_declarator() {
			return GetRuleContext<Conversion_operator_declaratorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public BodyContext body() {
			return GetRuleContext<BodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Right_arrowContext right_arrow() {
			return GetRuleContext<Right_arrowContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Throwable_expressionContext throwable_expression() {
			return GetRuleContext<Throwable_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Constructor_declarationContext constructor_declaration() {
			return GetRuleContext<Constructor_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOID() { return GetToken(CSharpParser.VOID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Method_declarationContext method_declaration() {
			return GetRuleContext<Method_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Class_definitionContext class_definition() {
			return GetRuleContext<Class_definitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Struct_definitionContext struct_definition() {
			return GetRuleContext<Struct_definitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Interface_definitionContext interface_definition() {
			return GetRuleContext<Interface_definitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Enum_definitionContext enum_definition() {
			return GetRuleContext<Enum_definitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Delegate_definitionContext delegate_definition() {
			return GetRuleContext<Delegate_definitionContext>(0);
		}
		public Common_member_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_common_member_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterCommon_member_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitCommon_member_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Common_member_declarationContext common_member_declaration() {
		Common_member_declarationContext _localctx = new Common_member_declarationContext(Context, State);
		EnterRule(_localctx, 260, RULE_common_member_declaration);
		try {
			State = 1768;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,199,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1749;
				constant_declaration();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1750;
				typed_member_declaration();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1751;
				event_declaration();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1752;
				conversion_operator_declarator();
				State = 1758;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case OPEN_BRACE:
				case SEMICOLON:
					{
					State = 1753;
					body();
					}
					break;
				case ASSIGNMENT:
					{
					State = 1754;
					right_arrow();
					State = 1755;
					throwable_expression();
					State = 1756;
					Match(SEMICOLON);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1760;
				constructor_declaration();
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 1761;
				Match(VOID);
				State = 1762;
				method_declaration();
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 1763;
				class_definition();
				}
				break;
			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 1764;
				struct_definition();
				}
				break;
			case 9:
				EnterOuterAlt(_localctx, 9);
				{
				State = 1765;
				interface_definition();
				}
				break;
			case 10:
				EnterOuterAlt(_localctx, 10);
				{
				State = 1766;
				enum_definition();
				}
				break;
			case 11:
				EnterOuterAlt(_localctx, 11);
				{
				State = 1767;
				delegate_definition();
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

	public partial class Typed_member_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_or_type_nameContext namespace_or_type_name() {
			return GetRuleContext<Namespace_or_type_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(CSharpParser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Indexer_declarationContext indexer_declaration() {
			return GetRuleContext<Indexer_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Method_declarationContext method_declaration() {
			return GetRuleContext<Method_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Property_declarationContext property_declaration() {
			return GetRuleContext<Property_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Operator_declarationContext operator_declaration() {
			return GetRuleContext<Operator_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Field_declarationContext field_declaration() {
			return GetRuleContext<Field_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REF() { return GetToken(CSharpParser.REF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode READONLY() { return GetToken(CSharpParser.READONLY, 0); }
		public Typed_member_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typed_member_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterTyped_member_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitTyped_member_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Typed_member_declarationContext typed_member_declaration() {
		Typed_member_declarationContext _localctx = new Typed_member_declarationContext(Context, State);
		EnterRule(_localctx, 262, RULE_typed_member_declaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1775;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,200,Context) ) {
			case 1:
				{
				State = 1770;
				Match(REF);
				}
				break;
			case 2:
				{
				State = 1771;
				Match(READONLY);
				State = 1772;
				Match(REF);
				}
				break;
			case 3:
				{
				State = 1773;
				Match(REF);
				State = 1774;
				Match(READONLY);
				}
				break;
			}
			State = 1777;
			type_();
			State = 1787;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,201,Context) ) {
			case 1:
				{
				State = 1778;
				namespace_or_type_name();
				State = 1779;
				Match(DOT);
				State = 1780;
				indexer_declaration();
				}
				break;
			case 2:
				{
				State = 1782;
				method_declaration();
				}
				break;
			case 3:
				{
				State = 1783;
				property_declaration();
				}
				break;
			case 4:
				{
				State = 1784;
				indexer_declaration();
				}
				break;
			case 5:
				{
				State = 1785;
				operator_declaration();
				}
				break;
			case 6:
				{
				State = 1786;
				field_declaration();
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

	public partial class Constant_declaratorsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Constant_declaratorContext[] constant_declarator() {
			return GetRuleContexts<Constant_declaratorContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Constant_declaratorContext constant_declarator(int i) {
			return GetRuleContext<Constant_declaratorContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Constant_declaratorsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constant_declarators; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterConstant_declarators(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitConstant_declarators(this);
		}
	}

	[RuleVersion(0)]
	public Constant_declaratorsContext constant_declarators() {
		Constant_declaratorsContext _localctx = new Constant_declaratorsContext(Context, State);
		EnterRule(_localctx, 264, RULE_constant_declarators);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1789;
			constant_declarator();
			State = 1794;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1790;
				Match(COMMA);
				State = 1791;
				constant_declarator();
				}
				}
				State = 1796;
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

	public partial class Constant_declaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGNMENT() { return GetToken(CSharpParser.ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public Constant_declaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constant_declarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterConstant_declarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitConstant_declarator(this);
		}
	}

	[RuleVersion(0)]
	public Constant_declaratorContext constant_declarator() {
		Constant_declaratorContext _localctx = new Constant_declaratorContext(Context, State);
		EnterRule(_localctx, 266, RULE_constant_declarator);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1797;
			identifier();
			State = 1798;
			Match(ASSIGNMENT);
			State = 1799;
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

	public partial class Variable_declaratorsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Variable_declaratorContext[] variable_declarator() {
			return GetRuleContexts<Variable_declaratorContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Variable_declaratorContext variable_declarator(int i) {
			return GetRuleContext<Variable_declaratorContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Variable_declaratorsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variable_declarators; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterVariable_declarators(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitVariable_declarators(this);
		}
	}

	[RuleVersion(0)]
	public Variable_declaratorsContext variable_declarators() {
		Variable_declaratorsContext _localctx = new Variable_declaratorsContext(Context, State);
		EnterRule(_localctx, 268, RULE_variable_declarators);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1801;
			variable_declarator();
			State = 1806;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1802;
				Match(COMMA);
				State = 1803;
				variable_declarator();
				}
				}
				State = 1808;
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

	public partial class Variable_declaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGNMENT() { return GetToken(CSharpParser.ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Variable_initializerContext variable_initializer() {
			return GetRuleContext<Variable_initializerContext>(0);
		}
		public Variable_declaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variable_declarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterVariable_declarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitVariable_declarator(this);
		}
	}

	[RuleVersion(0)]
	public Variable_declaratorContext variable_declarator() {
		Variable_declaratorContext _localctx = new Variable_declaratorContext(Context, State);
		EnterRule(_localctx, 270, RULE_variable_declarator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1809;
			identifier();
			State = 1812;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==ASSIGNMENT) {
				{
				State = 1810;
				Match(ASSIGNMENT);
				State = 1811;
				variable_initializer();
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

	public partial class Variable_initializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Array_initializerContext array_initializer() {
			return GetRuleContext<Array_initializerContext>(0);
		}
		public Variable_initializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variable_initializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterVariable_initializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitVariable_initializer(this);
		}
	}

	[RuleVersion(0)]
	public Variable_initializerContext variable_initializer() {
		Variable_initializerContext _localctx = new Variable_initializerContext(Context, State);
		EnterRule(_localctx, 272, RULE_variable_initializer);
		try {
			State = 1816;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ADD:
			case ALIAS:
			case ARGLIST:
			case ASCENDING:
			case ASYNC:
			case AWAIT:
			case BASE:
			case BOOL:
			case BY:
			case BYTE:
			case CHAR:
			case CHECKED:
			case DECIMAL:
			case DEFAULT:
			case DELEGATE:
			case DESCENDING:
			case DOUBLE:
			case DYNAMIC:
			case EQUALS:
			case FALSE:
			case FLOAT:
			case FROM:
			case GET:
			case GROUP:
			case INT:
			case INTO:
			case JOIN:
			case LET:
			case LONG:
			case NAMEOF:
			case NEW:
			case NULL_:
			case OBJECT:
			case ON:
			case ORDERBY:
			case PARTIAL:
			case REF:
			case REMOVE:
			case SBYTE:
			case SELECT:
			case SET:
			case SHORT:
			case SIZEOF:
			case STRING:
			case THIS:
			case TRUE:
			case TYPEOF:
			case UINT:
			case ULONG:
			case UNCHECKED:
			case UNMANAGED:
			case USHORT:
			case VAR:
			case WHEN:
			case WHERE:
			case YIELD:
			case IDENTIFIER:
			case LITERAL_ACCESS:
			case INTEGER_LITERAL:
			case HEX_INTEGER_LITERAL:
			case BIN_INTEGER_LITERAL:
			case REAL_LITERAL:
			case CHARACTER_LITERAL:
			case REGULAR_STRING:
			case VERBATIUM_STRING:
			case INTERPOLATED_REGULAR_STRING_START:
			case INTERPOLATED_VERBATIUM_STRING_START:
			case OPEN_PARENS:
			case PLUS:
			case MINUS:
			case STAR:
			case AMP:
			case CARET:
			case BANG:
			case TILDE:
			case OP_INC:
			case OP_DEC:
			case OP_RANGE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1814;
				expression();
				}
				break;
			case OPEN_BRACE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1815;
				array_initializer();
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

	public partial class Return_typeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOID() { return GetToken(CSharpParser.VOID, 0); }
		public Return_typeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_return_type; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterReturn_type(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitReturn_type(this);
		}
	}

	[RuleVersion(0)]
	public Return_typeContext return_type() {
		Return_typeContext _localctx = new Return_typeContext(Context, State);
		EnterRule(_localctx, 274, RULE_return_type);
		try {
			State = 1820;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,206,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1818;
				type_();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1819;
				Match(VOID);
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

	public partial class Member_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_or_type_nameContext namespace_or_type_name() {
			return GetRuleContext<Namespace_or_type_nameContext>(0);
		}
		public Member_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_member_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterMember_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitMember_name(this);
		}
	}

	[RuleVersion(0)]
	public Member_nameContext member_name() {
		Member_nameContext _localctx = new Member_nameContext(Context, State);
		EnterRule(_localctx, 276, RULE_member_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1822;
			namespace_or_type_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Method_bodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public Method_bodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_method_body; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterMethod_body(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitMethod_body(this);
		}
	}

	[RuleVersion(0)]
	public Method_bodyContext method_body() {
		Method_bodyContext _localctx = new Method_bodyContext(Context, State);
		EnterRule(_localctx, 278, RULE_method_body);
		try {
			State = 1826;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case OPEN_BRACE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1824;
				block();
				}
				break;
			case SEMICOLON:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1825;
				Match(SEMICOLON);
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

	public partial class Formal_parameter_listContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Parameter_arrayContext parameter_array() {
			return GetRuleContext<Parameter_arrayContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Fixed_parametersContext fixed_parameters() {
			return GetRuleContext<Fixed_parametersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(CSharpParser.COMMA, 0); }
		public Formal_parameter_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_formal_parameter_list; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterFormal_parameter_list(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitFormal_parameter_list(this);
		}
	}

	[RuleVersion(0)]
	public Formal_parameter_listContext formal_parameter_list() {
		Formal_parameter_listContext _localctx = new Formal_parameter_listContext(Context, State);
		EnterRule(_localctx, 280, RULE_formal_parameter_list);
		int _la;
		try {
			State = 1834;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,209,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1828;
				parameter_array();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1829;
				fixed_parameters();
				State = 1832;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==COMMA) {
					{
					State = 1830;
					Match(COMMA);
					State = 1831;
					parameter_array();
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

	public partial class Fixed_parametersContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Fixed_parameterContext[] fixed_parameter() {
			return GetRuleContexts<Fixed_parameterContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Fixed_parameterContext fixed_parameter(int i) {
			return GetRuleContext<Fixed_parameterContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Fixed_parametersContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fixed_parameters; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterFixed_parameters(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitFixed_parameters(this);
		}
	}

	[RuleVersion(0)]
	public Fixed_parametersContext fixed_parameters() {
		Fixed_parametersContext _localctx = new Fixed_parametersContext(Context, State);
		EnterRule(_localctx, 282, RULE_fixed_parameters);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1836;
			fixed_parameter();
			State = 1841;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,210,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1837;
					Match(COMMA);
					State = 1838;
					fixed_parameter();
					}
					} 
				}
				State = 1843;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,210,Context);
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

	public partial class Fixed_parameterContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Arg_declarationContext arg_declaration() {
			return GetRuleContext<Arg_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Parameter_modifierContext parameter_modifier() {
			return GetRuleContext<Parameter_modifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ARGLIST() { return GetToken(CSharpParser.ARGLIST, 0); }
		public Fixed_parameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fixed_parameter; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterFixed_parameter(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitFixed_parameter(this);
		}
	}

	[RuleVersion(0)]
	public Fixed_parameterContext fixed_parameter() {
		Fixed_parameterContext _localctx = new Fixed_parameterContext(Context, State);
		EnterRule(_localctx, 284, RULE_fixed_parameter);
		int _la;
		try {
			State = 1852;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,213,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1845;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==OPEN_BRACKET) {
					{
					State = 1844;
					attributes();
					}
				}

				State = 1848;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (((((_la - 54)) & ~0x3f) == 0 && ((1L << (_la - 54)) & ((1L << (IN - 54)) | (1L << (OUT - 54)) | (1L << (REF - 54)) | (1L << (THIS - 54)))) != 0)) {
					{
					State = 1847;
					parameter_modifier();
					}
				}

				State = 1850;
				arg_declaration();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1851;
				Match(ARGLIST);
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

	public partial class Parameter_modifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REF() { return GetToken(CSharpParser.REF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OUT() { return GetToken(CSharpParser.OUT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IN() { return GetToken(CSharpParser.IN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THIS() { return GetToken(CSharpParser.THIS, 0); }
		public Parameter_modifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parameter_modifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterParameter_modifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitParameter_modifier(this);
		}
	}

	[RuleVersion(0)]
	public Parameter_modifierContext parameter_modifier() {
		Parameter_modifierContext _localctx = new Parameter_modifierContext(Context, State);
		EnterRule(_localctx, 286, RULE_parameter_modifier);
		try {
			State = 1862;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,214,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1854;
				Match(REF);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1855;
				Match(OUT);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1856;
				Match(IN);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1857;
				Match(REF);
				State = 1858;
				Match(THIS);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1859;
				Match(IN);
				State = 1860;
				Match(THIS);
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 1861;
				Match(THIS);
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

	public partial class Parameter_arrayContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PARAMS() { return GetToken(CSharpParser.PARAMS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Array_typeContext array_type() {
			return GetRuleContext<Array_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		public Parameter_arrayContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parameter_array; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterParameter_array(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitParameter_array(this);
		}
	}

	[RuleVersion(0)]
	public Parameter_arrayContext parameter_array() {
		Parameter_arrayContext _localctx = new Parameter_arrayContext(Context, State);
		EnterRule(_localctx, 288, RULE_parameter_array);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1865;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_BRACKET) {
				{
				State = 1864;
				attributes();
				}
			}

			State = 1867;
			Match(PARAMS);
			State = 1868;
			array_type();
			State = 1869;
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

	public partial class Accessor_declarationsContext : ParserRuleContext {
		public AttributesContext attrs;
		public Accessor_modifierContext mods;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GET() { return GetToken(CSharpParser.GET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Accessor_bodyContext accessor_body() {
			return GetRuleContext<Accessor_bodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SET() { return GetToken(CSharpParser.SET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Accessor_modifierContext accessor_modifier() {
			return GetRuleContext<Accessor_modifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Set_accessor_declarationContext set_accessor_declaration() {
			return GetRuleContext<Set_accessor_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Get_accessor_declarationContext get_accessor_declaration() {
			return GetRuleContext<Get_accessor_declarationContext>(0);
		}
		public Accessor_declarationsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_accessor_declarations; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAccessor_declarations(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAccessor_declarations(this);
		}
	}

	[RuleVersion(0)]
	public Accessor_declarationsContext accessor_declarations() {
		Accessor_declarationsContext _localctx = new Accessor_declarationsContext(Context, State);
		EnterRule(_localctx, 290, RULE_accessor_declarations);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1872;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_BRACKET) {
				{
				State = 1871;
				_localctx.attrs = attributes();
				}
			}

			State = 1875;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 57)) & ~0x3f) == 0 && ((1L << (_la - 57)) & ((1L << (INTERNAL - 57)) | (1L << (PRIVATE - 57)) | (1L << (PROTECTED - 57)))) != 0)) {
				{
				State = 1874;
				_localctx.mods = accessor_modifier();
				}
			}

			State = 1887;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case GET:
				{
				State = 1877;
				Match(GET);
				State = 1878;
				accessor_body();
				State = 1880;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==INTERNAL || ((((_la - 76)) & ~0x3f) == 0 && ((1L << (_la - 76)) & ((1L << (PRIVATE - 76)) | (1L << (PROTECTED - 76)) | (1L << (SET - 76)) | (1L << (OPEN_BRACKET - 76)))) != 0)) {
					{
					State = 1879;
					set_accessor_declaration();
					}
				}

				}
				break;
			case SET:
				{
				State = 1882;
				Match(SET);
				State = 1883;
				accessor_body();
				State = 1885;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==GET || _la==INTERNAL || ((((_la - 76)) & ~0x3f) == 0 && ((1L << (_la - 76)) & ((1L << (PRIVATE - 76)) | (1L << (PROTECTED - 76)) | (1L << (OPEN_BRACKET - 76)))) != 0)) {
					{
					State = 1884;
					get_accessor_declaration();
					}
				}

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

	public partial class Get_accessor_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GET() { return GetToken(CSharpParser.GET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Accessor_bodyContext accessor_body() {
			return GetRuleContext<Accessor_bodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Accessor_modifierContext accessor_modifier() {
			return GetRuleContext<Accessor_modifierContext>(0);
		}
		public Get_accessor_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_get_accessor_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterGet_accessor_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitGet_accessor_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Get_accessor_declarationContext get_accessor_declaration() {
		Get_accessor_declarationContext _localctx = new Get_accessor_declarationContext(Context, State);
		EnterRule(_localctx, 292, RULE_get_accessor_declaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1890;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_BRACKET) {
				{
				State = 1889;
				attributes();
				}
			}

			State = 1893;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 57)) & ~0x3f) == 0 && ((1L << (_la - 57)) & ((1L << (INTERNAL - 57)) | (1L << (PRIVATE - 57)) | (1L << (PROTECTED - 57)))) != 0)) {
				{
				State = 1892;
				accessor_modifier();
				}
			}

			State = 1895;
			Match(GET);
			State = 1896;
			accessor_body();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Set_accessor_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SET() { return GetToken(CSharpParser.SET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Accessor_bodyContext accessor_body() {
			return GetRuleContext<Accessor_bodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Accessor_modifierContext accessor_modifier() {
			return GetRuleContext<Accessor_modifierContext>(0);
		}
		public Set_accessor_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_set_accessor_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterSet_accessor_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitSet_accessor_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Set_accessor_declarationContext set_accessor_declaration() {
		Set_accessor_declarationContext _localctx = new Set_accessor_declarationContext(Context, State);
		EnterRule(_localctx, 294, RULE_set_accessor_declaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1899;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_BRACKET) {
				{
				State = 1898;
				attributes();
				}
			}

			State = 1902;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 57)) & ~0x3f) == 0 && ((1L << (_la - 57)) & ((1L << (INTERNAL - 57)) | (1L << (PRIVATE - 57)) | (1L << (PROTECTED - 57)))) != 0)) {
				{
				State = 1901;
				accessor_modifier();
				}
			}

			State = 1904;
			Match(SET);
			State = 1905;
			accessor_body();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Accessor_modifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PROTECTED() { return GetToken(CSharpParser.PROTECTED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERNAL() { return GetToken(CSharpParser.INTERNAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRIVATE() { return GetToken(CSharpParser.PRIVATE, 0); }
		public Accessor_modifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_accessor_modifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAccessor_modifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAccessor_modifier(this);
		}
	}

	[RuleVersion(0)]
	public Accessor_modifierContext accessor_modifier() {
		Accessor_modifierContext _localctx = new Accessor_modifierContext(Context, State);
		EnterRule(_localctx, 296, RULE_accessor_modifier);
		try {
			State = 1914;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,225,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1907;
				Match(PROTECTED);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1908;
				Match(INTERNAL);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1909;
				Match(PRIVATE);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1910;
				Match(PROTECTED);
				State = 1911;
				Match(INTERNAL);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1912;
				Match(INTERNAL);
				State = 1913;
				Match(PROTECTED);
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

	public partial class Accessor_bodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public Accessor_bodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_accessor_body; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAccessor_body(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAccessor_body(this);
		}
	}

	[RuleVersion(0)]
	public Accessor_bodyContext accessor_body() {
		Accessor_bodyContext _localctx = new Accessor_bodyContext(Context, State);
		EnterRule(_localctx, 298, RULE_accessor_body);
		try {
			State = 1918;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case OPEN_BRACE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1916;
				block();
				}
				break;
			case SEMICOLON:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1917;
				Match(SEMICOLON);
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

	public partial class Event_accessor_declarationsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ADD() { return GetToken(CSharpParser.ADD, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Remove_accessor_declarationContext remove_accessor_declaration() {
			return GetRuleContext<Remove_accessor_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REMOVE() { return GetToken(CSharpParser.REMOVE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Add_accessor_declarationContext add_accessor_declaration() {
			return GetRuleContext<Add_accessor_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		public Event_accessor_declarationsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_event_accessor_declarations; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterEvent_accessor_declarations(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitEvent_accessor_declarations(this);
		}
	}

	[RuleVersion(0)]
	public Event_accessor_declarationsContext event_accessor_declarations() {
		Event_accessor_declarationsContext _localctx = new Event_accessor_declarationsContext(Context, State);
		EnterRule(_localctx, 300, RULE_event_accessor_declarations);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1921;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_BRACKET) {
				{
				State = 1920;
				attributes();
				}
			}

			State = 1931;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ADD:
				{
				State = 1923;
				Match(ADD);
				State = 1924;
				block();
				State = 1925;
				remove_accessor_declaration();
				}
				break;
			case REMOVE:
				{
				State = 1927;
				Match(REMOVE);
				State = 1928;
				block();
				State = 1929;
				add_accessor_declaration();
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

	public partial class Add_accessor_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ADD() { return GetToken(CSharpParser.ADD, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		public Add_accessor_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_add_accessor_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAdd_accessor_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAdd_accessor_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Add_accessor_declarationContext add_accessor_declaration() {
		Add_accessor_declarationContext _localctx = new Add_accessor_declarationContext(Context, State);
		EnterRule(_localctx, 302, RULE_add_accessor_declaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1934;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_BRACKET) {
				{
				State = 1933;
				attributes();
				}
			}

			State = 1936;
			Match(ADD);
			State = 1937;
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

	public partial class Remove_accessor_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REMOVE() { return GetToken(CSharpParser.REMOVE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		public Remove_accessor_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_remove_accessor_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterRemove_accessor_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitRemove_accessor_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Remove_accessor_declarationContext remove_accessor_declaration() {
		Remove_accessor_declarationContext _localctx = new Remove_accessor_declarationContext(Context, State);
		EnterRule(_localctx, 304, RULE_remove_accessor_declaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1940;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_BRACKET) {
				{
				State = 1939;
				attributes();
				}
			}

			State = 1942;
			Match(REMOVE);
			State = 1943;
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

	public partial class Overloadable_operatorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PLUS() { return GetToken(CSharpParser.PLUS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MINUS() { return GetToken(CSharpParser.MINUS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BANG() { return GetToken(CSharpParser.BANG, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TILDE() { return GetToken(CSharpParser.TILDE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_INC() { return GetToken(CSharpParser.OP_INC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_DEC() { return GetToken(CSharpParser.OP_DEC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRUE() { return GetToken(CSharpParser.TRUE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FALSE() { return GetToken(CSharpParser.FALSE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STAR() { return GetToken(CSharpParser.STAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIV() { return GetToken(CSharpParser.DIV, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PERCENT() { return GetToken(CSharpParser.PERCENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AMP() { return GetToken(CSharpParser.AMP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BITWISE_OR() { return GetToken(CSharpParser.BITWISE_OR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CARET() { return GetToken(CSharpParser.CARET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_LEFT_SHIFT() { return GetToken(CSharpParser.OP_LEFT_SHIFT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Right_shiftContext right_shift() {
			return GetRuleContext<Right_shiftContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_EQ() { return GetToken(CSharpParser.OP_EQ, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_NE() { return GetToken(CSharpParser.OP_NE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT() { return GetToken(CSharpParser.GT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LT() { return GetToken(CSharpParser.LT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_GE() { return GetToken(CSharpParser.OP_GE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_LE() { return GetToken(CSharpParser.OP_LE, 0); }
		public Overloadable_operatorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_overloadable_operator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterOverloadable_operator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitOverloadable_operator(this);
		}
	}

	[RuleVersion(0)]
	public Overloadable_operatorContext overloadable_operator() {
		Overloadable_operatorContext _localctx = new Overloadable_operatorContext(Context, State);
		EnterRule(_localctx, 306, RULE_overloadable_operator);
		try {
			State = 1967;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,231,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1945;
				Match(PLUS);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1946;
				Match(MINUS);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1947;
				Match(BANG);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1948;
				Match(TILDE);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1949;
				Match(OP_INC);
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 1950;
				Match(OP_DEC);
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 1951;
				Match(TRUE);
				}
				break;
			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 1952;
				Match(FALSE);
				}
				break;
			case 9:
				EnterOuterAlt(_localctx, 9);
				{
				State = 1953;
				Match(STAR);
				}
				break;
			case 10:
				EnterOuterAlt(_localctx, 10);
				{
				State = 1954;
				Match(DIV);
				}
				break;
			case 11:
				EnterOuterAlt(_localctx, 11);
				{
				State = 1955;
				Match(PERCENT);
				}
				break;
			case 12:
				EnterOuterAlt(_localctx, 12);
				{
				State = 1956;
				Match(AMP);
				}
				break;
			case 13:
				EnterOuterAlt(_localctx, 13);
				{
				State = 1957;
				Match(BITWISE_OR);
				}
				break;
			case 14:
				EnterOuterAlt(_localctx, 14);
				{
				State = 1958;
				Match(CARET);
				}
				break;
			case 15:
				EnterOuterAlt(_localctx, 15);
				{
				State = 1959;
				Match(OP_LEFT_SHIFT);
				}
				break;
			case 16:
				EnterOuterAlt(_localctx, 16);
				{
				State = 1960;
				right_shift();
				}
				break;
			case 17:
				EnterOuterAlt(_localctx, 17);
				{
				State = 1961;
				Match(OP_EQ);
				}
				break;
			case 18:
				EnterOuterAlt(_localctx, 18);
				{
				State = 1962;
				Match(OP_NE);
				}
				break;
			case 19:
				EnterOuterAlt(_localctx, 19);
				{
				State = 1963;
				Match(GT);
				}
				break;
			case 20:
				EnterOuterAlt(_localctx, 20);
				{
				State = 1964;
				Match(LT);
				}
				break;
			case 21:
				EnterOuterAlt(_localctx, 21);
				{
				State = 1965;
				Match(OP_GE);
				}
				break;
			case 22:
				EnterOuterAlt(_localctx, 22);
				{
				State = 1966;
				Match(OP_LE);
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

	public partial class Conversion_operator_declaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPERATOR() { return GetToken(CSharpParser.OPERATOR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Arg_declarationContext arg_declaration() {
			return GetRuleContext<Arg_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IMPLICIT() { return GetToken(CSharpParser.IMPLICIT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXPLICIT() { return GetToken(CSharpParser.EXPLICIT, 0); }
		public Conversion_operator_declaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_conversion_operator_declarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterConversion_operator_declarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitConversion_operator_declarator(this);
		}
	}

	[RuleVersion(0)]
	public Conversion_operator_declaratorContext conversion_operator_declarator() {
		Conversion_operator_declaratorContext _localctx = new Conversion_operator_declaratorContext(Context, State);
		EnterRule(_localctx, 308, RULE_conversion_operator_declarator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1969;
			_la = TokenStream.LA(1);
			if ( !(_la==EXPLICIT || _la==IMPLICIT) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			State = 1970;
			Match(OPERATOR);
			State = 1971;
			type_();
			State = 1972;
			Match(OPEN_PARENS);
			State = 1973;
			arg_declaration();
			State = 1974;
			Match(CLOSE_PARENS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Constructor_initializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(CSharpParser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BASE() { return GetToken(CSharpParser.BASE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THIS() { return GetToken(CSharpParser.THIS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Argument_listContext argument_list() {
			return GetRuleContext<Argument_listContext>(0);
		}
		public Constructor_initializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constructor_initializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterConstructor_initializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitConstructor_initializer(this);
		}
	}

	[RuleVersion(0)]
	public Constructor_initializerContext constructor_initializer() {
		Constructor_initializerContext _localctx = new Constructor_initializerContext(Context, State);
		EnterRule(_localctx, 310, RULE_constructor_initializer);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1976;
			Match(COLON);
			State = 1977;
			_la = TokenStream.LA(1);
			if ( !(_la==BASE || _la==THIS) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			State = 1978;
			Match(OPEN_PARENS);
			State = 1980;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BASE) | (1L << BOOL) | (1L << BY) | (1L << BYTE) | (1L << CHAR) | (1L << CHECKED) | (1L << DECIMAL) | (1L << DEFAULT) | (1L << DELEGATE) | (1L << DESCENDING) | (1L << DOUBLE) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FALSE) | (1L << FLOAT) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << IN) | (1L << INT) | (1L << INTO) | (1L << JOIN) | (1L << LET) | (1L << LONG))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (NEW - 64)) | (1L << (NULL_ - 64)) | (1L << (OBJECT - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (OUT - 64)) | (1L << (PARTIAL - 64)) | (1L << (REF - 64)) | (1L << (REMOVE - 64)) | (1L << (SBYTE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (SHORT - 64)) | (1L << (SIZEOF - 64)) | (1L << (STRING - 64)) | (1L << (THIS - 64)) | (1L << (TRUE - 64)) | (1L << (TYPEOF - 64)) | (1L << (UINT - 64)) | (1L << (ULONG - 64)) | (1L << (UNCHECKED - 64)) | (1L << (UNMANAGED - 64)) | (1L << (USHORT - 64)) | (1L << (VAR - 64)) | (1L << (VOID - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (LITERAL_ACCESS - 64)) | (1L << (INTEGER_LITERAL - 64)) | (1L << (HEX_INTEGER_LITERAL - 64)) | (1L << (BIN_INTEGER_LITERAL - 64)) | (1L << (REAL_LITERAL - 64)) | (1L << (CHARACTER_LITERAL - 64)) | (1L << (REGULAR_STRING - 64)) | (1L << (VERBATIUM_STRING - 64)) | (1L << (INTERPOLATED_REGULAR_STRING_START - 64)) | (1L << (INTERPOLATED_VERBATIUM_STRING_START - 64)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (OPEN_PARENS - 129)) | (1L << (PLUS - 129)) | (1L << (MINUS - 129)) | (1L << (STAR - 129)) | (1L << (AMP - 129)) | (1L << (CARET - 129)) | (1L << (BANG - 129)) | (1L << (TILDE - 129)) | (1L << (OP_INC - 129)) | (1L << (OP_DEC - 129)) | (1L << (OP_RANGE - 129)))) != 0)) {
				{
				State = 1979;
				argument_list();
				}
			}

			State = 1982;
			Match(CLOSE_PARENS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public BodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_body; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterBody(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitBody(this);
		}
	}

	[RuleVersion(0)]
	public BodyContext body() {
		BodyContext _localctx = new BodyContext(Context, State);
		EnterRule(_localctx, 312, RULE_body);
		try {
			State = 1986;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case OPEN_BRACE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1984;
				block();
				}
				break;
			case SEMICOLON:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1985;
				Match(SEMICOLON);
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

	public partial class Struct_interfacesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(CSharpParser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Interface_type_listContext interface_type_list() {
			return GetRuleContext<Interface_type_listContext>(0);
		}
		public Struct_interfacesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_struct_interfaces; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterStruct_interfaces(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitStruct_interfaces(this);
		}
	}

	[RuleVersion(0)]
	public Struct_interfacesContext struct_interfaces() {
		Struct_interfacesContext _localctx = new Struct_interfacesContext(Context, State);
		EnterRule(_localctx, 314, RULE_struct_interfaces);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1988;
			Match(COLON);
			State = 1989;
			interface_type_list();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Struct_bodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Struct_member_declarationContext[] struct_member_declaration() {
			return GetRuleContexts<Struct_member_declarationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Struct_member_declarationContext struct_member_declaration(int i) {
			return GetRuleContext<Struct_member_declarationContext>(i);
		}
		public Struct_bodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_struct_body; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterStruct_body(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitStruct_body(this);
		}
	}

	[RuleVersion(0)]
	public Struct_bodyContext struct_body() {
		Struct_bodyContext _localctx = new Struct_bodyContext(Context, State);
		EnterRule(_localctx, 316, RULE_struct_body);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1991;
			Match(OPEN_BRACE);
			State = 1995;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (((((_la - 9)) & ~0x3f) == 0 && ((1L << (_la - 9)) & ((1L << (ABSTRACT - 9)) | (1L << (ADD - 9)) | (1L << (ALIAS - 9)) | (1L << (ARGLIST - 9)) | (1L << (ASCENDING - 9)) | (1L << (ASYNC - 9)) | (1L << (AWAIT - 9)) | (1L << (BOOL - 9)) | (1L << (BY - 9)) | (1L << (BYTE - 9)) | (1L << (CHAR - 9)) | (1L << (CLASS - 9)) | (1L << (CONST - 9)) | (1L << (DECIMAL - 9)) | (1L << (DELEGATE - 9)) | (1L << (DESCENDING - 9)) | (1L << (DOUBLE - 9)) | (1L << (DYNAMIC - 9)) | (1L << (ENUM - 9)) | (1L << (EQUALS - 9)) | (1L << (EVENT - 9)) | (1L << (EXPLICIT - 9)) | (1L << (EXTERN - 9)) | (1L << (FIXED - 9)) | (1L << (FLOAT - 9)) | (1L << (FROM - 9)) | (1L << (GET - 9)) | (1L << (GROUP - 9)) | (1L << (IMPLICIT - 9)) | (1L << (INT - 9)) | (1L << (INTERFACE - 9)) | (1L << (INTERNAL - 9)) | (1L << (INTO - 9)) | (1L << (JOIN - 9)) | (1L << (LET - 9)) | (1L << (LONG - 9)) | (1L << (NAMEOF - 9)) | (1L << (NEW - 9)) | (1L << (OBJECT - 9)) | (1L << (ON - 9)) | (1L << (ORDERBY - 9)))) != 0) || ((((_la - 73)) & ~0x3f) == 0 && ((1L << (_la - 73)) & ((1L << (OVERRIDE - 73)) | (1L << (PARTIAL - 73)) | (1L << (PRIVATE - 73)) | (1L << (PROTECTED - 73)) | (1L << (PUBLIC - 73)) | (1L << (READONLY - 73)) | (1L << (REF - 73)) | (1L << (REMOVE - 73)) | (1L << (SBYTE - 73)) | (1L << (SEALED - 73)) | (1L << (SELECT - 73)) | (1L << (SET - 73)) | (1L << (SHORT - 73)) | (1L << (STATIC - 73)) | (1L << (STRING - 73)) | (1L << (STRUCT - 73)) | (1L << (UINT - 73)) | (1L << (ULONG - 73)) | (1L << (UNMANAGED - 73)) | (1L << (UNSAFE - 73)) | (1L << (USHORT - 73)) | (1L << (VAR - 73)) | (1L << (VIRTUAL - 73)) | (1L << (VOID - 73)) | (1L << (VOLATILE - 73)) | (1L << (WHEN - 73)) | (1L << (WHERE - 73)) | (1L << (YIELD - 73)) | (1L << (IDENTIFIER - 73)) | (1L << (OPEN_BRACKET - 73)) | (1L << (OPEN_PARENS - 73)))) != 0)) {
				{
				{
				State = 1992;
				struct_member_declaration();
				}
				}
				State = 1997;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1998;
			Match(CLOSE_BRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Struct_member_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Common_member_declarationContext common_member_declaration() {
			return GetRuleContext<Common_member_declarationContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FIXED() { return GetToken(CSharpParser.FIXED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public All_member_modifiersContext all_member_modifiers() {
			return GetRuleContext<All_member_modifiersContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Fixed_size_buffer_declaratorContext[] fixed_size_buffer_declarator() {
			return GetRuleContexts<Fixed_size_buffer_declaratorContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Fixed_size_buffer_declaratorContext fixed_size_buffer_declarator(int i) {
			return GetRuleContext<Fixed_size_buffer_declaratorContext>(i);
		}
		public Struct_member_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_struct_member_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterStruct_member_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitStruct_member_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Struct_member_declarationContext struct_member_declaration() {
		Struct_member_declarationContext _localctx = new Struct_member_declarationContext(Context, State);
		EnterRule(_localctx, 318, RULE_struct_member_declaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2001;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_BRACKET) {
				{
				State = 2000;
				attributes();
				}
			}

			State = 2004;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,236,Context) ) {
			case 1:
				{
				State = 2003;
				all_member_modifiers();
				}
				break;
			}
			State = 2016;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ADD:
			case ALIAS:
			case ARGLIST:
			case ASCENDING:
			case ASYNC:
			case AWAIT:
			case BOOL:
			case BY:
			case BYTE:
			case CHAR:
			case CLASS:
			case CONST:
			case DECIMAL:
			case DELEGATE:
			case DESCENDING:
			case DOUBLE:
			case DYNAMIC:
			case ENUM:
			case EQUALS:
			case EVENT:
			case EXPLICIT:
			case FLOAT:
			case FROM:
			case GET:
			case GROUP:
			case IMPLICIT:
			case INT:
			case INTERFACE:
			case INTO:
			case JOIN:
			case LET:
			case LONG:
			case NAMEOF:
			case OBJECT:
			case ON:
			case ORDERBY:
			case PARTIAL:
			case READONLY:
			case REF:
			case REMOVE:
			case SBYTE:
			case SELECT:
			case SET:
			case SHORT:
			case STRING:
			case STRUCT:
			case UINT:
			case ULONG:
			case UNMANAGED:
			case USHORT:
			case VAR:
			case VOID:
			case WHEN:
			case WHERE:
			case YIELD:
			case IDENTIFIER:
			case OPEN_PARENS:
				{
				State = 2006;
				common_member_declaration();
				}
				break;
			case FIXED:
				{
				State = 2007;
				Match(FIXED);
				State = 2008;
				type_();
				State = 2010;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				do {
					{
					{
					State = 2009;
					fixed_size_buffer_declarator();
					}
					}
					State = 2012;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BY) | (1L << DESCENDING) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << INTO) | (1L << JOIN) | (1L << LET))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REMOVE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (UNMANAGED - 64)) | (1L << (VAR - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)))) != 0) );
				State = 2014;
				Match(SEMICOLON);
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

	public partial class Array_typeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Base_typeContext base_type() {
			return GetRuleContext<Base_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Rank_specifierContext[] rank_specifier() {
			return GetRuleContexts<Rank_specifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Rank_specifierContext rank_specifier(int i) {
			return GetRuleContext<Rank_specifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] STAR() { return GetTokens(CSharpParser.STAR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STAR(int i) {
			return GetToken(CSharpParser.STAR, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] INTERR() { return GetTokens(CSharpParser.INTERR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERR(int i) {
			return GetToken(CSharpParser.INTERR, i);
		}
		public Array_typeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_array_type; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterArray_type(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitArray_type(this);
		}
	}

	[RuleVersion(0)]
	public Array_typeContext array_type() {
		Array_typeContext _localctx = new Array_typeContext(Context, State);
		EnterRule(_localctx, 320, RULE_array_type);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2018;
			base_type();
			State = 2026;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 2022;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==STAR || _la==INTERR) {
					{
					{
					State = 2019;
					_la = TokenStream.LA(1);
					if ( !(_la==STAR || _la==INTERR) ) {
					ErrorHandler.RecoverInline(this);
					}
					else {
						ErrorHandler.ReportMatch(this);
					    Consume();
					}
					}
					}
					State = 2024;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 2025;
				rank_specifier();
				}
				}
				State = 2028;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( ((((_la - 127)) & ~0x3f) == 0 && ((1L << (_la - 127)) & ((1L << (OPEN_BRACKET - 127)) | (1L << (STAR - 127)) | (1L << (INTERR - 127)))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Rank_specifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACKET() { return GetToken(CSharpParser.OPEN_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACKET() { return GetToken(CSharpParser.CLOSE_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Rank_specifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_rank_specifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterRank_specifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitRank_specifier(this);
		}
	}

	[RuleVersion(0)]
	public Rank_specifierContext rank_specifier() {
		Rank_specifierContext _localctx = new Rank_specifierContext(Context, State);
		EnterRule(_localctx, 322, RULE_rank_specifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2030;
			Match(OPEN_BRACKET);
			State = 2034;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 2031;
				Match(COMMA);
				}
				}
				State = 2036;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 2037;
			Match(CLOSE_BRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Array_initializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Variable_initializerContext[] variable_initializer() {
			return GetRuleContexts<Variable_initializerContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Variable_initializerContext variable_initializer(int i) {
			return GetRuleContext<Variable_initializerContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Array_initializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_array_initializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterArray_initializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitArray_initializer(this);
		}
	}

	[RuleVersion(0)]
	public Array_initializerContext array_initializer() {
		Array_initializerContext _localctx = new Array_initializerContext(Context, State);
		EnterRule(_localctx, 324, RULE_array_initializer);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 2039;
			Match(OPEN_BRACE);
			State = 2051;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BASE) | (1L << BOOL) | (1L << BY) | (1L << BYTE) | (1L << CHAR) | (1L << CHECKED) | (1L << DECIMAL) | (1L << DEFAULT) | (1L << DELEGATE) | (1L << DESCENDING) | (1L << DOUBLE) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FALSE) | (1L << FLOAT) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << INT) | (1L << INTO) | (1L << JOIN) | (1L << LET) | (1L << LONG))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (NEW - 64)) | (1L << (NULL_ - 64)) | (1L << (OBJECT - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REF - 64)) | (1L << (REMOVE - 64)) | (1L << (SBYTE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (SHORT - 64)) | (1L << (SIZEOF - 64)) | (1L << (STRING - 64)) | (1L << (THIS - 64)) | (1L << (TRUE - 64)) | (1L << (TYPEOF - 64)) | (1L << (UINT - 64)) | (1L << (ULONG - 64)) | (1L << (UNCHECKED - 64)) | (1L << (UNMANAGED - 64)) | (1L << (USHORT - 64)) | (1L << (VAR - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (LITERAL_ACCESS - 64)) | (1L << (INTEGER_LITERAL - 64)) | (1L << (HEX_INTEGER_LITERAL - 64)) | (1L << (BIN_INTEGER_LITERAL - 64)) | (1L << (REAL_LITERAL - 64)) | (1L << (CHARACTER_LITERAL - 64)) | (1L << (REGULAR_STRING - 64)) | (1L << (VERBATIUM_STRING - 64)) | (1L << (INTERPOLATED_REGULAR_STRING_START - 64)) | (1L << (INTERPOLATED_VERBATIUM_STRING_START - 64)) | (1L << (OPEN_BRACE - 64)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (OPEN_PARENS - 129)) | (1L << (PLUS - 129)) | (1L << (MINUS - 129)) | (1L << (STAR - 129)) | (1L << (AMP - 129)) | (1L << (CARET - 129)) | (1L << (BANG - 129)) | (1L << (TILDE - 129)) | (1L << (OP_INC - 129)) | (1L << (OP_DEC - 129)) | (1L << (OP_RANGE - 129)))) != 0)) {
				{
				State = 2040;
				variable_initializer();
				State = 2045;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,242,Context);
				while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						State = 2041;
						Match(COMMA);
						State = 2042;
						variable_initializer();
						}
						} 
					}
					State = 2047;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,242,Context);
				}
				State = 2049;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==COMMA) {
					{
					State = 2048;
					Match(COMMA);
					}
				}

				}
			}

			State = 2053;
			Match(CLOSE_BRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Variant_type_parameter_listContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LT() { return GetToken(CSharpParser.LT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Variant_type_parameterContext[] variant_type_parameter() {
			return GetRuleContexts<Variant_type_parameterContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Variant_type_parameterContext variant_type_parameter(int i) {
			return GetRuleContext<Variant_type_parameterContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT() { return GetToken(CSharpParser.GT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Variant_type_parameter_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variant_type_parameter_list; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterVariant_type_parameter_list(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitVariant_type_parameter_list(this);
		}
	}

	[RuleVersion(0)]
	public Variant_type_parameter_listContext variant_type_parameter_list() {
		Variant_type_parameter_listContext _localctx = new Variant_type_parameter_listContext(Context, State);
		EnterRule(_localctx, 326, RULE_variant_type_parameter_list);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2055;
			Match(LT);
			State = 2056;
			variant_type_parameter();
			State = 2061;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 2057;
				Match(COMMA);
				State = 2058;
				variant_type_parameter();
				}
				}
				State = 2063;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 2064;
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

	public partial class Variant_type_parameterContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Variance_annotationContext variance_annotation() {
			return GetRuleContext<Variance_annotationContext>(0);
		}
		public Variant_type_parameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variant_type_parameter; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterVariant_type_parameter(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitVariant_type_parameter(this);
		}
	}

	[RuleVersion(0)]
	public Variant_type_parameterContext variant_type_parameter() {
		Variant_type_parameterContext _localctx = new Variant_type_parameterContext(Context, State);
		EnterRule(_localctx, 328, RULE_variant_type_parameter);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2067;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_BRACKET) {
				{
				State = 2066;
				attributes();
				}
			}

			State = 2070;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==IN || _la==OUT) {
				{
				State = 2069;
				variance_annotation();
				}
			}

			State = 2072;
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

	public partial class Variance_annotationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IN() { return GetToken(CSharpParser.IN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OUT() { return GetToken(CSharpParser.OUT, 0); }
		public Variance_annotationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variance_annotation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterVariance_annotation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitVariance_annotation(this);
		}
	}

	[RuleVersion(0)]
	public Variance_annotationContext variance_annotation() {
		Variance_annotationContext _localctx = new Variance_annotationContext(Context, State);
		EnterRule(_localctx, 330, RULE_variance_annotation);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2074;
			_la = TokenStream.LA(1);
			if ( !(_la==IN || _la==OUT) ) {
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

	public partial class Interface_baseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(CSharpParser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Interface_type_listContext interface_type_list() {
			return GetRuleContext<Interface_type_listContext>(0);
		}
		public Interface_baseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interface_base; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterInterface_base(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitInterface_base(this);
		}
	}

	[RuleVersion(0)]
	public Interface_baseContext interface_base() {
		Interface_baseContext _localctx = new Interface_baseContext(Context, State);
		EnterRule(_localctx, 332, RULE_interface_base);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2076;
			Match(COLON);
			State = 2077;
			interface_type_list();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Interface_bodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Interface_member_declarationContext[] interface_member_declaration() {
			return GetRuleContexts<Interface_member_declarationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Interface_member_declarationContext interface_member_declaration(int i) {
			return GetRuleContext<Interface_member_declarationContext>(i);
		}
		public Interface_bodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interface_body; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterInterface_body(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitInterface_body(this);
		}
	}

	[RuleVersion(0)]
	public Interface_bodyContext interface_body() {
		Interface_bodyContext _localctx = new Interface_bodyContext(Context, State);
		EnterRule(_localctx, 334, RULE_interface_body);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2079;
			Match(OPEN_BRACE);
			State = 2083;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (((((_la - 10)) & ~0x3f) == 0 && ((1L << (_la - 10)) & ((1L << (ADD - 10)) | (1L << (ALIAS - 10)) | (1L << (ARGLIST - 10)) | (1L << (ASCENDING - 10)) | (1L << (ASYNC - 10)) | (1L << (AWAIT - 10)) | (1L << (BOOL - 10)) | (1L << (BY - 10)) | (1L << (BYTE - 10)) | (1L << (CHAR - 10)) | (1L << (DECIMAL - 10)) | (1L << (DESCENDING - 10)) | (1L << (DOUBLE - 10)) | (1L << (DYNAMIC - 10)) | (1L << (EQUALS - 10)) | (1L << (EVENT - 10)) | (1L << (FLOAT - 10)) | (1L << (FROM - 10)) | (1L << (GET - 10)) | (1L << (GROUP - 10)) | (1L << (INT - 10)) | (1L << (INTO - 10)) | (1L << (JOIN - 10)) | (1L << (LET - 10)) | (1L << (LONG - 10)) | (1L << (NAMEOF - 10)) | (1L << (NEW - 10)) | (1L << (OBJECT - 10)) | (1L << (ON - 10)) | (1L << (ORDERBY - 10)))) != 0) || ((((_la - 75)) & ~0x3f) == 0 && ((1L << (_la - 75)) & ((1L << (PARTIAL - 75)) | (1L << (READONLY - 75)) | (1L << (REF - 75)) | (1L << (REMOVE - 75)) | (1L << (SBYTE - 75)) | (1L << (SELECT - 75)) | (1L << (SET - 75)) | (1L << (SHORT - 75)) | (1L << (STRING - 75)) | (1L << (UINT - 75)) | (1L << (ULONG - 75)) | (1L << (UNMANAGED - 75)) | (1L << (UNSAFE - 75)) | (1L << (USHORT - 75)) | (1L << (VAR - 75)) | (1L << (VOID - 75)) | (1L << (WHEN - 75)) | (1L << (WHERE - 75)) | (1L << (YIELD - 75)) | (1L << (IDENTIFIER - 75)) | (1L << (OPEN_BRACKET - 75)) | (1L << (OPEN_PARENS - 75)))) != 0)) {
				{
				{
				State = 2080;
				interface_member_declaration();
				}
				}
				State = 2085;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 2086;
			Match(CLOSE_BRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Interface_member_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOID() { return GetToken(CSharpParser.VOID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EVENT() { return GetToken(CSharpParser.EVENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEW() { return GetToken(CSharpParser.NEW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Interface_accessorsContext interface_accessors() {
			return GetRuleContext<Interface_accessorsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THIS() { return GetToken(CSharpParser.THIS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACKET() { return GetToken(CSharpParser.OPEN_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Formal_parameter_listContext formal_parameter_list() {
			return GetRuleContext<Formal_parameter_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACKET() { return GetToken(CSharpParser.CLOSE_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNSAFE() { return GetToken(CSharpParser.UNSAFE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REF() { return GetToken(CSharpParser.REF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode READONLY() { return GetToken(CSharpParser.READONLY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_parameter_listContext type_parameter_list() {
			return GetRuleContext<Type_parameter_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_parameter_constraints_clausesContext type_parameter_constraints_clauses() {
			return GetRuleContext<Type_parameter_constraints_clausesContext>(0);
		}
		public Interface_member_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interface_member_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterInterface_member_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitInterface_member_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Interface_member_declarationContext interface_member_declaration() {
		Interface_member_declarationContext _localctx = new Interface_member_declarationContext(Context, State);
		EnterRule(_localctx, 336, RULE_interface_member_declaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2089;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_BRACKET) {
				{
				State = 2088;
				attributes();
				}
			}

			State = 2092;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==NEW) {
				{
				State = 2091;
				Match(NEW);
				}
			}

			State = 2157;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,261,Context) ) {
			case 1:
				{
				State = 2095;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==UNSAFE) {
					{
					State = 2094;
					Match(UNSAFE);
					}
				}

				State = 2102;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,252,Context) ) {
				case 1:
					{
					State = 2097;
					Match(REF);
					}
					break;
				case 2:
					{
					State = 2098;
					Match(REF);
					State = 2099;
					Match(READONLY);
					}
					break;
				case 3:
					{
					State = 2100;
					Match(READONLY);
					State = 2101;
					Match(REF);
					}
					break;
				}
				State = 2104;
				type_();
				State = 2132;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,256,Context) ) {
				case 1:
					{
					State = 2105;
					identifier();
					State = 2107;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==LT) {
						{
						State = 2106;
						type_parameter_list();
						}
					}

					State = 2109;
					Match(OPEN_PARENS);
					State = 2111;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (((((_la - 10)) & ~0x3f) == 0 && ((1L << (_la - 10)) & ((1L << (ADD - 10)) | (1L << (ALIAS - 10)) | (1L << (ARGLIST - 10)) | (1L << (ASCENDING - 10)) | (1L << (ASYNC - 10)) | (1L << (AWAIT - 10)) | (1L << (BOOL - 10)) | (1L << (BY - 10)) | (1L << (BYTE - 10)) | (1L << (CHAR - 10)) | (1L << (DECIMAL - 10)) | (1L << (DESCENDING - 10)) | (1L << (DOUBLE - 10)) | (1L << (DYNAMIC - 10)) | (1L << (EQUALS - 10)) | (1L << (FLOAT - 10)) | (1L << (FROM - 10)) | (1L << (GET - 10)) | (1L << (GROUP - 10)) | (1L << (IN - 10)) | (1L << (INT - 10)) | (1L << (INTO - 10)) | (1L << (JOIN - 10)) | (1L << (LET - 10)) | (1L << (LONG - 10)) | (1L << (NAMEOF - 10)) | (1L << (OBJECT - 10)) | (1L << (ON - 10)) | (1L << (ORDERBY - 10)) | (1L << (OUT - 10)))) != 0) || ((((_la - 74)) & ~0x3f) == 0 && ((1L << (_la - 74)) & ((1L << (PARAMS - 74)) | (1L << (PARTIAL - 74)) | (1L << (REF - 74)) | (1L << (REMOVE - 74)) | (1L << (SBYTE - 74)) | (1L << (SELECT - 74)) | (1L << (SET - 74)) | (1L << (SHORT - 74)) | (1L << (STRING - 74)) | (1L << (THIS - 74)) | (1L << (UINT - 74)) | (1L << (ULONG - 74)) | (1L << (UNMANAGED - 74)) | (1L << (USHORT - 74)) | (1L << (VAR - 74)) | (1L << (VOID - 74)) | (1L << (WHEN - 74)) | (1L << (WHERE - 74)) | (1L << (YIELD - 74)) | (1L << (IDENTIFIER - 74)) | (1L << (OPEN_BRACKET - 74)) | (1L << (OPEN_PARENS - 74)))) != 0)) {
						{
						State = 2110;
						formal_parameter_list();
						}
					}

					State = 2113;
					Match(CLOSE_PARENS);
					State = 2115;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==WHERE) {
						{
						State = 2114;
						type_parameter_constraints_clauses();
						}
					}

					State = 2117;
					Match(SEMICOLON);
					}
					break;
				case 2:
					{
					State = 2119;
					identifier();
					State = 2120;
					Match(OPEN_BRACE);
					State = 2121;
					interface_accessors();
					State = 2122;
					Match(CLOSE_BRACE);
					}
					break;
				case 3:
					{
					State = 2124;
					Match(THIS);
					State = 2125;
					Match(OPEN_BRACKET);
					State = 2126;
					formal_parameter_list();
					State = 2127;
					Match(CLOSE_BRACKET);
					State = 2128;
					Match(OPEN_BRACE);
					State = 2129;
					interface_accessors();
					State = 2130;
					Match(CLOSE_BRACE);
					}
					break;
				}
				}
				break;
			case 2:
				{
				State = 2135;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==UNSAFE) {
					{
					State = 2134;
					Match(UNSAFE);
					}
				}

				State = 2137;
				Match(VOID);
				State = 2138;
				identifier();
				State = 2140;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==LT) {
					{
					State = 2139;
					type_parameter_list();
					}
				}

				State = 2142;
				Match(OPEN_PARENS);
				State = 2144;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (((((_la - 10)) & ~0x3f) == 0 && ((1L << (_la - 10)) & ((1L << (ADD - 10)) | (1L << (ALIAS - 10)) | (1L << (ARGLIST - 10)) | (1L << (ASCENDING - 10)) | (1L << (ASYNC - 10)) | (1L << (AWAIT - 10)) | (1L << (BOOL - 10)) | (1L << (BY - 10)) | (1L << (BYTE - 10)) | (1L << (CHAR - 10)) | (1L << (DECIMAL - 10)) | (1L << (DESCENDING - 10)) | (1L << (DOUBLE - 10)) | (1L << (DYNAMIC - 10)) | (1L << (EQUALS - 10)) | (1L << (FLOAT - 10)) | (1L << (FROM - 10)) | (1L << (GET - 10)) | (1L << (GROUP - 10)) | (1L << (IN - 10)) | (1L << (INT - 10)) | (1L << (INTO - 10)) | (1L << (JOIN - 10)) | (1L << (LET - 10)) | (1L << (LONG - 10)) | (1L << (NAMEOF - 10)) | (1L << (OBJECT - 10)) | (1L << (ON - 10)) | (1L << (ORDERBY - 10)) | (1L << (OUT - 10)))) != 0) || ((((_la - 74)) & ~0x3f) == 0 && ((1L << (_la - 74)) & ((1L << (PARAMS - 74)) | (1L << (PARTIAL - 74)) | (1L << (REF - 74)) | (1L << (REMOVE - 74)) | (1L << (SBYTE - 74)) | (1L << (SELECT - 74)) | (1L << (SET - 74)) | (1L << (SHORT - 74)) | (1L << (STRING - 74)) | (1L << (THIS - 74)) | (1L << (UINT - 74)) | (1L << (ULONG - 74)) | (1L << (UNMANAGED - 74)) | (1L << (USHORT - 74)) | (1L << (VAR - 74)) | (1L << (VOID - 74)) | (1L << (WHEN - 74)) | (1L << (WHERE - 74)) | (1L << (YIELD - 74)) | (1L << (IDENTIFIER - 74)) | (1L << (OPEN_BRACKET - 74)) | (1L << (OPEN_PARENS - 74)))) != 0)) {
					{
					State = 2143;
					formal_parameter_list();
					}
				}

				State = 2146;
				Match(CLOSE_PARENS);
				State = 2148;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==WHERE) {
					{
					State = 2147;
					type_parameter_constraints_clauses();
					}
				}

				State = 2150;
				Match(SEMICOLON);
				}
				break;
			case 3:
				{
				State = 2152;
				Match(EVENT);
				State = 2153;
				type_();
				State = 2154;
				identifier();
				State = 2155;
				Match(SEMICOLON);
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

	public partial class Interface_accessorsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GET() { return GetToken(CSharpParser.GET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SEMICOLON() { return GetTokens(CSharpParser.SEMICOLON); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON(int i) {
			return GetToken(CSharpParser.SEMICOLON, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SET() { return GetToken(CSharpParser.SET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext[] attributes() {
			return GetRuleContexts<AttributesContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes(int i) {
			return GetRuleContext<AttributesContext>(i);
		}
		public Interface_accessorsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interface_accessors; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterInterface_accessors(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitInterface_accessors(this);
		}
	}

	[RuleVersion(0)]
	public Interface_accessorsContext interface_accessors() {
		Interface_accessorsContext _localctx = new Interface_accessorsContext(Context, State);
		EnterRule(_localctx, 338, RULE_interface_accessors);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2160;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_BRACKET) {
				{
				State = 2159;
				attributes();
				}
			}

			State = 2180;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case GET:
				{
				State = 2162;
				Match(GET);
				State = 2163;
				Match(SEMICOLON);
				State = 2169;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==SET || _la==OPEN_BRACKET) {
					{
					State = 2165;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==OPEN_BRACKET) {
						{
						State = 2164;
						attributes();
						}
					}

					State = 2167;
					Match(SET);
					State = 2168;
					Match(SEMICOLON);
					}
				}

				}
				break;
			case SET:
				{
				State = 2171;
				Match(SET);
				State = 2172;
				Match(SEMICOLON);
				State = 2178;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==GET || _la==OPEN_BRACKET) {
					{
					State = 2174;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==OPEN_BRACKET) {
						{
						State = 2173;
						attributes();
						}
					}

					State = 2176;
					Match(GET);
					State = 2177;
					Match(SEMICOLON);
					}
				}

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

	public partial class Enum_baseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(CSharpParser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		public Enum_baseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enum_base; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterEnum_base(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitEnum_base(this);
		}
	}

	[RuleVersion(0)]
	public Enum_baseContext enum_base() {
		Enum_baseContext _localctx = new Enum_baseContext(Context, State);
		EnterRule(_localctx, 340, RULE_enum_base);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2182;
			Match(COLON);
			State = 2183;
			type_();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Enum_bodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Enum_member_declarationContext[] enum_member_declaration() {
			return GetRuleContexts<Enum_member_declarationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Enum_member_declarationContext enum_member_declaration(int i) {
			return GetRuleContext<Enum_member_declarationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Enum_bodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enum_body; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterEnum_body(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitEnum_body(this);
		}
	}

	[RuleVersion(0)]
	public Enum_bodyContext enum_body() {
		Enum_bodyContext _localctx = new Enum_bodyContext(Context, State);
		EnterRule(_localctx, 342, RULE_enum_body);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 2185;
			Match(OPEN_BRACE);
			State = 2197;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BY) | (1L << DESCENDING) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << INTO) | (1L << JOIN) | (1L << LET))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REMOVE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (UNMANAGED - 64)) | (1L << (VAR - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (OPEN_BRACKET - 64)))) != 0)) {
				{
				State = 2186;
				enum_member_declaration();
				State = 2191;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,268,Context);
				while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						State = 2187;
						Match(COMMA);
						State = 2188;
						enum_member_declaration();
						}
						} 
					}
					State = 2193;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,268,Context);
				}
				State = 2195;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==COMMA) {
					{
					State = 2194;
					Match(COMMA);
					}
				}

				}
			}

			State = 2199;
			Match(CLOSE_BRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Enum_member_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributesContext attributes() {
			return GetRuleContext<AttributesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGNMENT() { return GetToken(CSharpParser.ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public Enum_member_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enum_member_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterEnum_member_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitEnum_member_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Enum_member_declarationContext enum_member_declaration() {
		Enum_member_declarationContext _localctx = new Enum_member_declarationContext(Context, State);
		EnterRule(_localctx, 344, RULE_enum_member_declaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2202;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_BRACKET) {
				{
				State = 2201;
				attributes();
				}
			}

			State = 2204;
			identifier();
			State = 2207;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==ASSIGNMENT) {
				{
				State = 2205;
				Match(ASSIGNMENT);
				State = 2206;
				expression();
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

	public partial class Global_attribute_sectionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACKET() { return GetToken(CSharpParser.OPEN_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Global_attribute_targetContext global_attribute_target() {
			return GetRuleContext<Global_attribute_targetContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(CSharpParser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Attribute_listContext attribute_list() {
			return GetRuleContext<Attribute_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACKET() { return GetToken(CSharpParser.CLOSE_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(CSharpParser.COMMA, 0); }
		public Global_attribute_sectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_global_attribute_section; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterGlobal_attribute_section(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitGlobal_attribute_section(this);
		}
	}

	[RuleVersion(0)]
	public Global_attribute_sectionContext global_attribute_section() {
		Global_attribute_sectionContext _localctx = new Global_attribute_sectionContext(Context, State);
		EnterRule(_localctx, 346, RULE_global_attribute_section);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2209;
			Match(OPEN_BRACKET);
			State = 2210;
			global_attribute_target();
			State = 2211;
			Match(COLON);
			State = 2212;
			attribute_list();
			State = 2214;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==COMMA) {
				{
				State = 2213;
				Match(COMMA);
				}
			}

			State = 2216;
			Match(CLOSE_BRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Global_attribute_targetContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public KeywordContext keyword() {
			return GetRuleContext<KeywordContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public Global_attribute_targetContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_global_attribute_target; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterGlobal_attribute_target(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitGlobal_attribute_target(this);
		}
	}

	[RuleVersion(0)]
	public Global_attribute_targetContext global_attribute_target() {
		Global_attribute_targetContext _localctx = new Global_attribute_targetContext(Context, State);
		EnterRule(_localctx, 348, RULE_global_attribute_target);
		try {
			State = 2220;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,274,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2218;
				keyword();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2219;
				identifier();
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

	public partial class AttributesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Attribute_sectionContext[] attribute_section() {
			return GetRuleContexts<Attribute_sectionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Attribute_sectionContext attribute_section(int i) {
			return GetRuleContext<Attribute_sectionContext>(i);
		}
		public AttributesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attributes; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAttributes(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAttributes(this);
		}
	}

	[RuleVersion(0)]
	public AttributesContext attributes() {
		AttributesContext _localctx = new AttributesContext(Context, State);
		EnterRule(_localctx, 350, RULE_attributes);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2223;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 2222;
				attribute_section();
				}
				}
				State = 2225;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==OPEN_BRACKET );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Attribute_sectionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACKET() { return GetToken(CSharpParser.OPEN_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Attribute_listContext attribute_list() {
			return GetRuleContext<Attribute_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACKET() { return GetToken(CSharpParser.CLOSE_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Attribute_targetContext attribute_target() {
			return GetRuleContext<Attribute_targetContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(CSharpParser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(CSharpParser.COMMA, 0); }
		public Attribute_sectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attribute_section; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAttribute_section(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAttribute_section(this);
		}
	}

	[RuleVersion(0)]
	public Attribute_sectionContext attribute_section() {
		Attribute_sectionContext _localctx = new Attribute_sectionContext(Context, State);
		EnterRule(_localctx, 352, RULE_attribute_section);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2227;
			Match(OPEN_BRACKET);
			State = 2231;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,276,Context) ) {
			case 1:
				{
				State = 2228;
				attribute_target();
				State = 2229;
				Match(COLON);
				}
				break;
			}
			State = 2233;
			attribute_list();
			State = 2235;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==COMMA) {
				{
				State = 2234;
				Match(COMMA);
				}
			}

			State = 2237;
			Match(CLOSE_BRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Attribute_targetContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public KeywordContext keyword() {
			return GetRuleContext<KeywordContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public Attribute_targetContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attribute_target; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAttribute_target(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAttribute_target(this);
		}
	}

	[RuleVersion(0)]
	public Attribute_targetContext attribute_target() {
		Attribute_targetContext _localctx = new Attribute_targetContext(Context, State);
		EnterRule(_localctx, 354, RULE_attribute_target);
		try {
			State = 2241;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,278,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2239;
				keyword();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2240;
				identifier();
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

	public partial class Attribute_listContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public AttributeContext[] attribute() {
			return GetRuleContexts<AttributeContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public AttributeContext attribute(int i) {
			return GetRuleContext<AttributeContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Attribute_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attribute_list; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAttribute_list(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAttribute_list(this);
		}
	}

	[RuleVersion(0)]
	public Attribute_listContext attribute_list() {
		Attribute_listContext _localctx = new Attribute_listContext(Context, State);
		EnterRule(_localctx, 356, RULE_attribute_list);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 2243;
			attribute();
			State = 2248;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,279,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 2244;
					Match(COMMA);
					State = 2245;
					attribute();
					}
					} 
				}
				State = 2250;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,279,Context);
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

	public partial class AttributeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Namespace_or_type_nameContext namespace_or_type_name() {
			return GetRuleContext<Namespace_or_type_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Attribute_argumentContext[] attribute_argument() {
			return GetRuleContexts<Attribute_argumentContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Attribute_argumentContext attribute_argument(int i) {
			return GetRuleContext<Attribute_argumentContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public AttributeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attribute; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAttribute(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAttribute(this);
		}
	}

	[RuleVersion(0)]
	public AttributeContext attribute() {
		AttributeContext _localctx = new AttributeContext(Context, State);
		EnterRule(_localctx, 358, RULE_attribute);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2251;
			namespace_or_type_name();
			State = 2264;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_PARENS) {
				{
				State = 2252;
				Match(OPEN_PARENS);
				State = 2261;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BASE) | (1L << BOOL) | (1L << BY) | (1L << BYTE) | (1L << CHAR) | (1L << CHECKED) | (1L << DECIMAL) | (1L << DEFAULT) | (1L << DELEGATE) | (1L << DESCENDING) | (1L << DOUBLE) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FALSE) | (1L << FLOAT) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << INT) | (1L << INTO) | (1L << JOIN) | (1L << LET) | (1L << LONG))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (NEW - 64)) | (1L << (NULL_ - 64)) | (1L << (OBJECT - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REF - 64)) | (1L << (REMOVE - 64)) | (1L << (SBYTE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (SHORT - 64)) | (1L << (SIZEOF - 64)) | (1L << (STRING - 64)) | (1L << (THIS - 64)) | (1L << (TRUE - 64)) | (1L << (TYPEOF - 64)) | (1L << (UINT - 64)) | (1L << (ULONG - 64)) | (1L << (UNCHECKED - 64)) | (1L << (UNMANAGED - 64)) | (1L << (USHORT - 64)) | (1L << (VAR - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (LITERAL_ACCESS - 64)) | (1L << (INTEGER_LITERAL - 64)) | (1L << (HEX_INTEGER_LITERAL - 64)) | (1L << (BIN_INTEGER_LITERAL - 64)) | (1L << (REAL_LITERAL - 64)) | (1L << (CHARACTER_LITERAL - 64)) | (1L << (REGULAR_STRING - 64)) | (1L << (VERBATIUM_STRING - 64)) | (1L << (INTERPOLATED_REGULAR_STRING_START - 64)) | (1L << (INTERPOLATED_VERBATIUM_STRING_START - 64)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (OPEN_PARENS - 129)) | (1L << (PLUS - 129)) | (1L << (MINUS - 129)) | (1L << (STAR - 129)) | (1L << (AMP - 129)) | (1L << (CARET - 129)) | (1L << (BANG - 129)) | (1L << (TILDE - 129)) | (1L << (OP_INC - 129)) | (1L << (OP_DEC - 129)) | (1L << (OP_RANGE - 129)))) != 0)) {
					{
					State = 2253;
					attribute_argument();
					State = 2258;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==COMMA) {
						{
						{
						State = 2254;
						Match(COMMA);
						State = 2255;
						attribute_argument();
						}
						}
						State = 2260;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					}
				}

				State = 2263;
				Match(CLOSE_PARENS);
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

	public partial class Attribute_argumentContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(CSharpParser.COLON, 0); }
		public Attribute_argumentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attribute_argument; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterAttribute_argument(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitAttribute_argument(this);
		}
	}

	[RuleVersion(0)]
	public Attribute_argumentContext attribute_argument() {
		Attribute_argumentContext _localctx = new Attribute_argumentContext(Context, State);
		EnterRule(_localctx, 360, RULE_attribute_argument);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2269;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,283,Context) ) {
			case 1:
				{
				State = 2266;
				identifier();
				State = 2267;
				Match(COLON);
				}
				break;
			}
			State = 2271;
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

	public partial class Pointer_typeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STAR() { return GetToken(CSharpParser.STAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Simple_typeContext simple_type() {
			return GetRuleContext<Simple_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Class_typeContext class_type() {
			return GetRuleContext<Class_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Rank_specifierContext[] rank_specifier() {
			return GetRuleContexts<Rank_specifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Rank_specifierContext rank_specifier(int i) {
			return GetRuleContext<Rank_specifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] INTERR() { return GetTokens(CSharpParser.INTERR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERR(int i) {
			return GetToken(CSharpParser.INTERR, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOID() { return GetToken(CSharpParser.VOID, 0); }
		public Pointer_typeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_pointer_type; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterPointer_type(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitPointer_type(this);
		}
	}

	[RuleVersion(0)]
	public Pointer_typeContext pointer_type() {
		Pointer_typeContext _localctx = new Pointer_typeContext(Context, State);
		EnterRule(_localctx, 362, RULE_pointer_type);
		int _la;
		try {
			State = 2288;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ADD:
			case ALIAS:
			case ARGLIST:
			case ASCENDING:
			case ASYNC:
			case AWAIT:
			case BOOL:
			case BY:
			case BYTE:
			case CHAR:
			case DECIMAL:
			case DESCENDING:
			case DOUBLE:
			case DYNAMIC:
			case EQUALS:
			case FLOAT:
			case FROM:
			case GET:
			case GROUP:
			case INT:
			case INTO:
			case JOIN:
			case LET:
			case LONG:
			case NAMEOF:
			case OBJECT:
			case ON:
			case ORDERBY:
			case PARTIAL:
			case REMOVE:
			case SBYTE:
			case SELECT:
			case SET:
			case SHORT:
			case STRING:
			case UINT:
			case ULONG:
			case UNMANAGED:
			case USHORT:
			case VAR:
			case WHEN:
			case WHERE:
			case YIELD:
			case IDENTIFIER:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2275;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case BOOL:
				case BYTE:
				case CHAR:
				case DECIMAL:
				case DOUBLE:
				case FLOAT:
				case INT:
				case LONG:
				case SBYTE:
				case SHORT:
				case UINT:
				case ULONG:
				case USHORT:
					{
					State = 2273;
					simple_type();
					}
					break;
				case ADD:
				case ALIAS:
				case ARGLIST:
				case ASCENDING:
				case ASYNC:
				case AWAIT:
				case BY:
				case DESCENDING:
				case DYNAMIC:
				case EQUALS:
				case FROM:
				case GET:
				case GROUP:
				case INTO:
				case JOIN:
				case LET:
				case NAMEOF:
				case OBJECT:
				case ON:
				case ORDERBY:
				case PARTIAL:
				case REMOVE:
				case SELECT:
				case SET:
				case STRING:
				case UNMANAGED:
				case VAR:
				case WHEN:
				case WHERE:
				case YIELD:
				case IDENTIFIER:
					{
					State = 2274;
					class_type();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 2281;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==OPEN_BRACKET || _la==INTERR) {
					{
					State = 2279;
					ErrorHandler.Sync(this);
					switch (TokenStream.LA(1)) {
					case OPEN_BRACKET:
						{
						State = 2277;
						rank_specifier();
						}
						break;
					case INTERR:
						{
						State = 2278;
						Match(INTERR);
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					}
					State = 2283;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 2284;
				Match(STAR);
				}
				break;
			case VOID:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2286;
				Match(VOID);
				State = 2287;
				Match(STAR);
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

	public partial class Fixed_pointer_declaratorsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Fixed_pointer_declaratorContext[] fixed_pointer_declarator() {
			return GetRuleContexts<Fixed_pointer_declaratorContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Fixed_pointer_declaratorContext fixed_pointer_declarator(int i) {
			return GetRuleContext<Fixed_pointer_declaratorContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Fixed_pointer_declaratorsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fixed_pointer_declarators; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterFixed_pointer_declarators(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitFixed_pointer_declarators(this);
		}
	}

	[RuleVersion(0)]
	public Fixed_pointer_declaratorsContext fixed_pointer_declarators() {
		Fixed_pointer_declaratorsContext _localctx = new Fixed_pointer_declaratorsContext(Context, State);
		EnterRule(_localctx, 364, RULE_fixed_pointer_declarators);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2290;
			fixed_pointer_declarator();
			State = 2295;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 2291;
				Match(COMMA);
				State = 2292;
				fixed_pointer_declarator();
				}
				}
				State = 2297;
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

	public partial class Fixed_pointer_declaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGNMENT() { return GetToken(CSharpParser.ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Fixed_pointer_initializerContext fixed_pointer_initializer() {
			return GetRuleContext<Fixed_pointer_initializerContext>(0);
		}
		public Fixed_pointer_declaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fixed_pointer_declarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterFixed_pointer_declarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitFixed_pointer_declarator(this);
		}
	}

	[RuleVersion(0)]
	public Fixed_pointer_declaratorContext fixed_pointer_declarator() {
		Fixed_pointer_declaratorContext _localctx = new Fixed_pointer_declaratorContext(Context, State);
		EnterRule(_localctx, 366, RULE_fixed_pointer_declarator);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2298;
			identifier();
			State = 2299;
			Match(ASSIGNMENT);
			State = 2300;
			fixed_pointer_initializer();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Fixed_pointer_initializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AMP() { return GetToken(CSharpParser.AMP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Stackalloc_initializerContext stackalloc_initializer() {
			return GetRuleContext<Stackalloc_initializerContext>(0);
		}
		public Fixed_pointer_initializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fixed_pointer_initializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterFixed_pointer_initializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitFixed_pointer_initializer(this);
		}
	}

	[RuleVersion(0)]
	public Fixed_pointer_initializerContext fixed_pointer_initializer() {
		Fixed_pointer_initializerContext _localctx = new Fixed_pointer_initializerContext(Context, State);
		EnterRule(_localctx, 368, RULE_fixed_pointer_initializer);
		try {
			State = 2307;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ADD:
			case ALIAS:
			case ARGLIST:
			case ASCENDING:
			case ASYNC:
			case AWAIT:
			case BASE:
			case BOOL:
			case BY:
			case BYTE:
			case CHAR:
			case CHECKED:
			case DECIMAL:
			case DEFAULT:
			case DELEGATE:
			case DESCENDING:
			case DOUBLE:
			case DYNAMIC:
			case EQUALS:
			case FALSE:
			case FLOAT:
			case FROM:
			case GET:
			case GROUP:
			case INT:
			case INTO:
			case JOIN:
			case LET:
			case LONG:
			case NAMEOF:
			case NEW:
			case NULL_:
			case OBJECT:
			case ON:
			case ORDERBY:
			case PARTIAL:
			case REF:
			case REMOVE:
			case SBYTE:
			case SELECT:
			case SET:
			case SHORT:
			case SIZEOF:
			case STRING:
			case THIS:
			case TRUE:
			case TYPEOF:
			case UINT:
			case ULONG:
			case UNCHECKED:
			case UNMANAGED:
			case USHORT:
			case VAR:
			case WHEN:
			case WHERE:
			case YIELD:
			case IDENTIFIER:
			case LITERAL_ACCESS:
			case INTEGER_LITERAL:
			case HEX_INTEGER_LITERAL:
			case BIN_INTEGER_LITERAL:
			case REAL_LITERAL:
			case CHARACTER_LITERAL:
			case REGULAR_STRING:
			case VERBATIUM_STRING:
			case INTERPOLATED_REGULAR_STRING_START:
			case INTERPOLATED_VERBATIUM_STRING_START:
			case OPEN_PARENS:
			case PLUS:
			case MINUS:
			case STAR:
			case AMP:
			case CARET:
			case BANG:
			case TILDE:
			case OP_INC:
			case OP_DEC:
			case OP_RANGE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2303;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,289,Context) ) {
				case 1:
					{
					State = 2302;
					Match(AMP);
					}
					break;
				}
				State = 2305;
				expression();
				}
				break;
			case STACKALLOC:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2306;
				stackalloc_initializer();
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

	public partial class Fixed_size_buffer_declaratorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACKET() { return GetToken(CSharpParser.OPEN_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACKET() { return GetToken(CSharpParser.CLOSE_BRACKET, 0); }
		public Fixed_size_buffer_declaratorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fixed_size_buffer_declarator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterFixed_size_buffer_declarator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitFixed_size_buffer_declarator(this);
		}
	}

	[RuleVersion(0)]
	public Fixed_size_buffer_declaratorContext fixed_size_buffer_declarator() {
		Fixed_size_buffer_declaratorContext _localctx = new Fixed_size_buffer_declaratorContext(Context, State);
		EnterRule(_localctx, 370, RULE_fixed_size_buffer_declarator);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2309;
			identifier();
			State = 2310;
			Match(OPEN_BRACKET);
			State = 2311;
			expression();
			State = 2312;
			Match(CLOSE_BRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Stackalloc_initializerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STACKALLOC() { return GetToken(CSharpParser.STACKALLOC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACKET() { return GetToken(CSharpParser.OPEN_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACKET() { return GetToken(CSharpParser.CLOSE_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		public Stackalloc_initializerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_stackalloc_initializer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterStackalloc_initializer(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitStackalloc_initializer(this);
		}
	}

	[RuleVersion(0)]
	public Stackalloc_initializerContext stackalloc_initializer() {
		Stackalloc_initializerContext _localctx = new Stackalloc_initializerContext(Context, State);
		EnterRule(_localctx, 372, RULE_stackalloc_initializer);
		int _la;
		try {
			int _alt;
			State = 2343;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,295,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2314;
				Match(STACKALLOC);
				State = 2315;
				type_();
				State = 2316;
				Match(OPEN_BRACKET);
				State = 2317;
				expression();
				State = 2318;
				Match(CLOSE_BRACKET);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2320;
				Match(STACKALLOC);
				State = 2322;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (((((_la - 10)) & ~0x3f) == 0 && ((1L << (_la - 10)) & ((1L << (ADD - 10)) | (1L << (ALIAS - 10)) | (1L << (ARGLIST - 10)) | (1L << (ASCENDING - 10)) | (1L << (ASYNC - 10)) | (1L << (AWAIT - 10)) | (1L << (BOOL - 10)) | (1L << (BY - 10)) | (1L << (BYTE - 10)) | (1L << (CHAR - 10)) | (1L << (DECIMAL - 10)) | (1L << (DESCENDING - 10)) | (1L << (DOUBLE - 10)) | (1L << (DYNAMIC - 10)) | (1L << (EQUALS - 10)) | (1L << (FLOAT - 10)) | (1L << (FROM - 10)) | (1L << (GET - 10)) | (1L << (GROUP - 10)) | (1L << (INT - 10)) | (1L << (INTO - 10)) | (1L << (JOIN - 10)) | (1L << (LET - 10)) | (1L << (LONG - 10)) | (1L << (NAMEOF - 10)) | (1L << (OBJECT - 10)) | (1L << (ON - 10)) | (1L << (ORDERBY - 10)))) != 0) || ((((_la - 75)) & ~0x3f) == 0 && ((1L << (_la - 75)) & ((1L << (PARTIAL - 75)) | (1L << (REMOVE - 75)) | (1L << (SBYTE - 75)) | (1L << (SELECT - 75)) | (1L << (SET - 75)) | (1L << (SHORT - 75)) | (1L << (STRING - 75)) | (1L << (UINT - 75)) | (1L << (ULONG - 75)) | (1L << (UNMANAGED - 75)) | (1L << (USHORT - 75)) | (1L << (VAR - 75)) | (1L << (VOID - 75)) | (1L << (WHEN - 75)) | (1L << (WHERE - 75)) | (1L << (YIELD - 75)) | (1L << (IDENTIFIER - 75)) | (1L << (OPEN_PARENS - 75)))) != 0)) {
					{
					State = 2321;
					type_();
					}
				}

				State = 2324;
				Match(OPEN_BRACKET);
				State = 2326;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BASE) | (1L << BOOL) | (1L << BY) | (1L << BYTE) | (1L << CHAR) | (1L << CHECKED) | (1L << DECIMAL) | (1L << DEFAULT) | (1L << DELEGATE) | (1L << DESCENDING) | (1L << DOUBLE) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FALSE) | (1L << FLOAT) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << INT) | (1L << INTO) | (1L << JOIN) | (1L << LET) | (1L << LONG))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (NEW - 64)) | (1L << (NULL_ - 64)) | (1L << (OBJECT - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REF - 64)) | (1L << (REMOVE - 64)) | (1L << (SBYTE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (SHORT - 64)) | (1L << (SIZEOF - 64)) | (1L << (STRING - 64)) | (1L << (THIS - 64)) | (1L << (TRUE - 64)) | (1L << (TYPEOF - 64)) | (1L << (UINT - 64)) | (1L << (ULONG - 64)) | (1L << (UNCHECKED - 64)) | (1L << (UNMANAGED - 64)) | (1L << (USHORT - 64)) | (1L << (VAR - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (LITERAL_ACCESS - 64)) | (1L << (INTEGER_LITERAL - 64)) | (1L << (HEX_INTEGER_LITERAL - 64)) | (1L << (BIN_INTEGER_LITERAL - 64)) | (1L << (REAL_LITERAL - 64)) | (1L << (CHARACTER_LITERAL - 64)) | (1L << (REGULAR_STRING - 64)) | (1L << (VERBATIUM_STRING - 64)) | (1L << (INTERPOLATED_REGULAR_STRING_START - 64)) | (1L << (INTERPOLATED_VERBATIUM_STRING_START - 64)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (OPEN_PARENS - 129)) | (1L << (PLUS - 129)) | (1L << (MINUS - 129)) | (1L << (STAR - 129)) | (1L << (AMP - 129)) | (1L << (CARET - 129)) | (1L << (BANG - 129)) | (1L << (TILDE - 129)) | (1L << (OP_INC - 129)) | (1L << (OP_DEC - 129)) | (1L << (OP_RANGE - 129)))) != 0)) {
					{
					State = 2325;
					expression();
					}
				}

				State = 2328;
				Match(CLOSE_BRACKET);
				State = 2329;
				Match(OPEN_BRACE);
				State = 2330;
				expression();
				State = 2335;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,293,Context);
				while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						State = 2331;
						Match(COMMA);
						State = 2332;
						expression();
						}
						} 
					}
					State = 2337;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,293,Context);
				}
				State = 2339;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==COMMA) {
					{
					State = 2338;
					Match(COMMA);
					}
				}

				State = 2341;
				Match(CLOSE_BRACE);
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

	public partial class Right_arrowContext : ParserRuleContext {
		public IToken first;
		public IToken second;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGNMENT() { return GetToken(CSharpParser.ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT() { return GetToken(CSharpParser.GT, 0); }
		public Right_arrowContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_right_arrow; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterRight_arrow(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitRight_arrow(this);
		}
	}

	[RuleVersion(0)]
	public Right_arrowContext right_arrow() {
		Right_arrowContext _localctx = new Right_arrowContext(Context, State);
		EnterRule(_localctx, 374, RULE_right_arrow);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2345;
			_localctx.first = Match(ASSIGNMENT);
			State = 2346;
			_localctx.second = Match(GT);
			State = 2347;
			if (!((_localctx.first!=null?_localctx.first.TokenIndex:0) + 1 == (_localctx.second!=null?_localctx.second.TokenIndex:0))) throw new FailedPredicateException(this, "$first.index + 1 == $second.index");
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Right_shiftContext : ParserRuleContext {
		public IToken first;
		public IToken second;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] GT() { return GetTokens(CSharpParser.GT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT(int i) {
			return GetToken(CSharpParser.GT, i);
		}
		public Right_shiftContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_right_shift; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterRight_shift(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitRight_shift(this);
		}
	}

	[RuleVersion(0)]
	public Right_shiftContext right_shift() {
		Right_shiftContext _localctx = new Right_shiftContext(Context, State);
		EnterRule(_localctx, 376, RULE_right_shift);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2349;
			_localctx.first = Match(GT);
			State = 2350;
			_localctx.second = Match(GT);
			State = 2351;
			if (!((_localctx.first!=null?_localctx.first.TokenIndex:0) + 1 == (_localctx.second!=null?_localctx.second.TokenIndex:0))) throw new FailedPredicateException(this, "$first.index + 1 == $second.index");
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Right_shift_assignmentContext : ParserRuleContext {
		public IToken first;
		public IToken second;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT() { return GetToken(CSharpParser.GT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OP_GE() { return GetToken(CSharpParser.OP_GE, 0); }
		public Right_shift_assignmentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_right_shift_assignment; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterRight_shift_assignment(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitRight_shift_assignment(this);
		}
	}

	[RuleVersion(0)]
	public Right_shift_assignmentContext right_shift_assignment() {
		Right_shift_assignmentContext _localctx = new Right_shift_assignmentContext(Context, State);
		EnterRule(_localctx, 378, RULE_right_shift_assignment);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2353;
			_localctx.first = Match(GT);
			State = 2354;
			_localctx.second = Match(OP_GE);
			State = 2355;
			if (!((_localctx.first!=null?_localctx.first.TokenIndex:0) + 1 == (_localctx.second!=null?_localctx.second.TokenIndex:0))) throw new FailedPredicateException(this, "$first.index + 1 == $second.index");
			}
		}
		catch (RecognitionException re) {
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
		[System.Diagnostics.DebuggerNonUserCode] public Boolean_literalContext boolean_literal() {
			return GetRuleContext<Boolean_literalContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public String_literalContext string_literal() {
			return GetRuleContext<String_literalContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTEGER_LITERAL() { return GetToken(CSharpParser.INTEGER_LITERAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HEX_INTEGER_LITERAL() { return GetToken(CSharpParser.HEX_INTEGER_LITERAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BIN_INTEGER_LITERAL() { return GetToken(CSharpParser.BIN_INTEGER_LITERAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REAL_LITERAL() { return GetToken(CSharpParser.REAL_LITERAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CHARACTER_LITERAL() { return GetToken(CSharpParser.CHARACTER_LITERAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NULL_() { return GetToken(CSharpParser.NULL_, 0); }
		public LiteralContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_literal; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterLiteral(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitLiteral(this);
		}
	}

	[RuleVersion(0)]
	public LiteralContext literal() {
		LiteralContext _localctx = new LiteralContext(Context, State);
		EnterRule(_localctx, 380, RULE_literal);
		try {
			State = 2365;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case FALSE:
			case TRUE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2357;
				boolean_literal();
				}
				break;
			case REGULAR_STRING:
			case VERBATIUM_STRING:
			case INTERPOLATED_REGULAR_STRING_START:
			case INTERPOLATED_VERBATIUM_STRING_START:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2358;
				string_literal();
				}
				break;
			case INTEGER_LITERAL:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2359;
				Match(INTEGER_LITERAL);
				}
				break;
			case HEX_INTEGER_LITERAL:
				EnterOuterAlt(_localctx, 4);
				{
				State = 2360;
				Match(HEX_INTEGER_LITERAL);
				}
				break;
			case BIN_INTEGER_LITERAL:
				EnterOuterAlt(_localctx, 5);
				{
				State = 2361;
				Match(BIN_INTEGER_LITERAL);
				}
				break;
			case REAL_LITERAL:
				EnterOuterAlt(_localctx, 6);
				{
				State = 2362;
				Match(REAL_LITERAL);
				}
				break;
			case CHARACTER_LITERAL:
				EnterOuterAlt(_localctx, 7);
				{
				State = 2363;
				Match(CHARACTER_LITERAL);
				}
				break;
			case NULL_:
				EnterOuterAlt(_localctx, 8);
				{
				State = 2364;
				Match(NULL_);
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

	public partial class Boolean_literalContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRUE() { return GetToken(CSharpParser.TRUE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FALSE() { return GetToken(CSharpParser.FALSE, 0); }
		public Boolean_literalContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_boolean_literal; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterBoolean_literal(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitBoolean_literal(this);
		}
	}

	[RuleVersion(0)]
	public Boolean_literalContext boolean_literal() {
		Boolean_literalContext _localctx = new Boolean_literalContext(Context, State);
		EnterRule(_localctx, 382, RULE_boolean_literal);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2367;
			_la = TokenStream.LA(1);
			if ( !(_la==FALSE || _la==TRUE) ) {
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

	public partial class String_literalContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Interpolated_regular_stringContext interpolated_regular_string() {
			return GetRuleContext<Interpolated_regular_stringContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Interpolated_verbatium_stringContext interpolated_verbatium_string() {
			return GetRuleContext<Interpolated_verbatium_stringContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REGULAR_STRING() { return GetToken(CSharpParser.REGULAR_STRING, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VERBATIUM_STRING() { return GetToken(CSharpParser.VERBATIUM_STRING, 0); }
		public String_literalContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_string_literal; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterString_literal(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitString_literal(this);
		}
	}

	[RuleVersion(0)]
	public String_literalContext string_literal() {
		String_literalContext _localctx = new String_literalContext(Context, State);
		EnterRule(_localctx, 384, RULE_string_literal);
		try {
			State = 2373;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case INTERPOLATED_REGULAR_STRING_START:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2369;
				interpolated_regular_string();
				}
				break;
			case INTERPOLATED_VERBATIUM_STRING_START:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2370;
				interpolated_verbatium_string();
				}
				break;
			case REGULAR_STRING:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2371;
				Match(REGULAR_STRING);
				}
				break;
			case VERBATIUM_STRING:
				EnterOuterAlt(_localctx, 4);
				{
				State = 2372;
				Match(VERBATIUM_STRING);
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

	public partial class Interpolated_regular_stringContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERPOLATED_REGULAR_STRING_START() { return GetToken(CSharpParser.INTERPOLATED_REGULAR_STRING_START, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOUBLE_QUOTE_INSIDE() { return GetToken(CSharpParser.DOUBLE_QUOTE_INSIDE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Interpolated_regular_string_partContext[] interpolated_regular_string_part() {
			return GetRuleContexts<Interpolated_regular_string_partContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Interpolated_regular_string_partContext interpolated_regular_string_part(int i) {
			return GetRuleContext<Interpolated_regular_string_partContext>(i);
		}
		public Interpolated_regular_stringContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interpolated_regular_string; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterInterpolated_regular_string(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitInterpolated_regular_string(this);
		}
	}

	[RuleVersion(0)]
	public Interpolated_regular_stringContext interpolated_regular_string() {
		Interpolated_regular_stringContext _localctx = new Interpolated_regular_stringContext(Context, State);
		EnterRule(_localctx, 386, RULE_interpolated_regular_string);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2375;
			Match(INTERPOLATED_REGULAR_STRING_START);
			State = 2379;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BASE) | (1L << BOOL) | (1L << BY) | (1L << BYTE) | (1L << CHAR) | (1L << CHECKED) | (1L << DECIMAL) | (1L << DEFAULT) | (1L << DELEGATE) | (1L << DESCENDING) | (1L << DOUBLE) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FALSE) | (1L << FLOAT) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << INT) | (1L << INTO) | (1L << JOIN) | (1L << LET) | (1L << LONG))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (NEW - 64)) | (1L << (NULL_ - 64)) | (1L << (OBJECT - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REF - 64)) | (1L << (REMOVE - 64)) | (1L << (SBYTE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (SHORT - 64)) | (1L << (SIZEOF - 64)) | (1L << (STRING - 64)) | (1L << (THIS - 64)) | (1L << (TRUE - 64)) | (1L << (TYPEOF - 64)) | (1L << (UINT - 64)) | (1L << (ULONG - 64)) | (1L << (UNCHECKED - 64)) | (1L << (UNMANAGED - 64)) | (1L << (USHORT - 64)) | (1L << (VAR - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (LITERAL_ACCESS - 64)) | (1L << (INTEGER_LITERAL - 64)) | (1L << (HEX_INTEGER_LITERAL - 64)) | (1L << (BIN_INTEGER_LITERAL - 64)) | (1L << (REAL_LITERAL - 64)) | (1L << (CHARACTER_LITERAL - 64)) | (1L << (REGULAR_STRING - 64)) | (1L << (VERBATIUM_STRING - 64)) | (1L << (INTERPOLATED_REGULAR_STRING_START - 64)) | (1L << (INTERPOLATED_VERBATIUM_STRING_START - 64)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (OPEN_PARENS - 129)) | (1L << (PLUS - 129)) | (1L << (MINUS - 129)) | (1L << (STAR - 129)) | (1L << (AMP - 129)) | (1L << (CARET - 129)) | (1L << (BANG - 129)) | (1L << (TILDE - 129)) | (1L << (OP_INC - 129)) | (1L << (OP_DEC - 129)) | (1L << (OP_RANGE - 129)) | (1L << (DOUBLE_CURLY_INSIDE - 129)) | (1L << (REGULAR_CHAR_INSIDE - 129)) | (1L << (REGULAR_STRING_INSIDE - 129)))) != 0)) {
				{
				{
				State = 2376;
				interpolated_regular_string_part();
				}
				}
				State = 2381;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 2382;
			Match(DOUBLE_QUOTE_INSIDE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Interpolated_verbatium_stringContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERPOLATED_VERBATIUM_STRING_START() { return GetToken(CSharpParser.INTERPOLATED_VERBATIUM_STRING_START, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOUBLE_QUOTE_INSIDE() { return GetToken(CSharpParser.DOUBLE_QUOTE_INSIDE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Interpolated_verbatium_string_partContext[] interpolated_verbatium_string_part() {
			return GetRuleContexts<Interpolated_verbatium_string_partContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Interpolated_verbatium_string_partContext interpolated_verbatium_string_part(int i) {
			return GetRuleContext<Interpolated_verbatium_string_partContext>(i);
		}
		public Interpolated_verbatium_stringContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interpolated_verbatium_string; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterInterpolated_verbatium_string(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitInterpolated_verbatium_string(this);
		}
	}

	[RuleVersion(0)]
	public Interpolated_verbatium_stringContext interpolated_verbatium_string() {
		Interpolated_verbatium_stringContext _localctx = new Interpolated_verbatium_stringContext(Context, State);
		EnterRule(_localctx, 388, RULE_interpolated_verbatium_string);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2384;
			Match(INTERPOLATED_VERBATIUM_STRING_START);
			State = 2388;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BASE) | (1L << BOOL) | (1L << BY) | (1L << BYTE) | (1L << CHAR) | (1L << CHECKED) | (1L << DECIMAL) | (1L << DEFAULT) | (1L << DELEGATE) | (1L << DESCENDING) | (1L << DOUBLE) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FALSE) | (1L << FLOAT) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << INT) | (1L << INTO) | (1L << JOIN) | (1L << LET) | (1L << LONG))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (NEW - 64)) | (1L << (NULL_ - 64)) | (1L << (OBJECT - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REF - 64)) | (1L << (REMOVE - 64)) | (1L << (SBYTE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (SHORT - 64)) | (1L << (SIZEOF - 64)) | (1L << (STRING - 64)) | (1L << (THIS - 64)) | (1L << (TRUE - 64)) | (1L << (TYPEOF - 64)) | (1L << (UINT - 64)) | (1L << (ULONG - 64)) | (1L << (UNCHECKED - 64)) | (1L << (UNMANAGED - 64)) | (1L << (USHORT - 64)) | (1L << (VAR - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (LITERAL_ACCESS - 64)) | (1L << (INTEGER_LITERAL - 64)) | (1L << (HEX_INTEGER_LITERAL - 64)) | (1L << (BIN_INTEGER_LITERAL - 64)) | (1L << (REAL_LITERAL - 64)) | (1L << (CHARACTER_LITERAL - 64)) | (1L << (REGULAR_STRING - 64)) | (1L << (VERBATIUM_STRING - 64)) | (1L << (INTERPOLATED_REGULAR_STRING_START - 64)) | (1L << (INTERPOLATED_VERBATIUM_STRING_START - 64)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (OPEN_PARENS - 129)) | (1L << (PLUS - 129)) | (1L << (MINUS - 129)) | (1L << (STAR - 129)) | (1L << (AMP - 129)) | (1L << (CARET - 129)) | (1L << (BANG - 129)) | (1L << (TILDE - 129)) | (1L << (OP_INC - 129)) | (1L << (OP_DEC - 129)) | (1L << (OP_RANGE - 129)) | (1L << (DOUBLE_CURLY_INSIDE - 129)) | (1L << (VERBATIUM_DOUBLE_QUOTE_INSIDE - 129)) | (1L << (VERBATIUM_INSIDE_STRING - 129)))) != 0)) {
				{
				{
				State = 2385;
				interpolated_verbatium_string_part();
				}
				}
				State = 2390;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 2391;
			Match(DOUBLE_QUOTE_INSIDE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Interpolated_regular_string_partContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Interpolated_string_expressionContext interpolated_string_expression() {
			return GetRuleContext<Interpolated_string_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOUBLE_CURLY_INSIDE() { return GetToken(CSharpParser.DOUBLE_CURLY_INSIDE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REGULAR_CHAR_INSIDE() { return GetToken(CSharpParser.REGULAR_CHAR_INSIDE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REGULAR_STRING_INSIDE() { return GetToken(CSharpParser.REGULAR_STRING_INSIDE, 0); }
		public Interpolated_regular_string_partContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interpolated_regular_string_part; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterInterpolated_regular_string_part(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitInterpolated_regular_string_part(this);
		}
	}

	[RuleVersion(0)]
	public Interpolated_regular_string_partContext interpolated_regular_string_part() {
		Interpolated_regular_string_partContext _localctx = new Interpolated_regular_string_partContext(Context, State);
		EnterRule(_localctx, 390, RULE_interpolated_regular_string_part);
		try {
			State = 2397;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ADD:
			case ALIAS:
			case ARGLIST:
			case ASCENDING:
			case ASYNC:
			case AWAIT:
			case BASE:
			case BOOL:
			case BY:
			case BYTE:
			case CHAR:
			case CHECKED:
			case DECIMAL:
			case DEFAULT:
			case DELEGATE:
			case DESCENDING:
			case DOUBLE:
			case DYNAMIC:
			case EQUALS:
			case FALSE:
			case FLOAT:
			case FROM:
			case GET:
			case GROUP:
			case INT:
			case INTO:
			case JOIN:
			case LET:
			case LONG:
			case NAMEOF:
			case NEW:
			case NULL_:
			case OBJECT:
			case ON:
			case ORDERBY:
			case PARTIAL:
			case REF:
			case REMOVE:
			case SBYTE:
			case SELECT:
			case SET:
			case SHORT:
			case SIZEOF:
			case STRING:
			case THIS:
			case TRUE:
			case TYPEOF:
			case UINT:
			case ULONG:
			case UNCHECKED:
			case UNMANAGED:
			case USHORT:
			case VAR:
			case WHEN:
			case WHERE:
			case YIELD:
			case IDENTIFIER:
			case LITERAL_ACCESS:
			case INTEGER_LITERAL:
			case HEX_INTEGER_LITERAL:
			case BIN_INTEGER_LITERAL:
			case REAL_LITERAL:
			case CHARACTER_LITERAL:
			case REGULAR_STRING:
			case VERBATIUM_STRING:
			case INTERPOLATED_REGULAR_STRING_START:
			case INTERPOLATED_VERBATIUM_STRING_START:
			case OPEN_PARENS:
			case PLUS:
			case MINUS:
			case STAR:
			case AMP:
			case CARET:
			case BANG:
			case TILDE:
			case OP_INC:
			case OP_DEC:
			case OP_RANGE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2393;
				interpolated_string_expression();
				}
				break;
			case DOUBLE_CURLY_INSIDE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2394;
				Match(DOUBLE_CURLY_INSIDE);
				}
				break;
			case REGULAR_CHAR_INSIDE:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2395;
				Match(REGULAR_CHAR_INSIDE);
				}
				break;
			case REGULAR_STRING_INSIDE:
				EnterOuterAlt(_localctx, 4);
				{
				State = 2396;
				Match(REGULAR_STRING_INSIDE);
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

	public partial class Interpolated_verbatium_string_partContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Interpolated_string_expressionContext interpolated_string_expression() {
			return GetRuleContext<Interpolated_string_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOUBLE_CURLY_INSIDE() { return GetToken(CSharpParser.DOUBLE_CURLY_INSIDE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VERBATIUM_DOUBLE_QUOTE_INSIDE() { return GetToken(CSharpParser.VERBATIUM_DOUBLE_QUOTE_INSIDE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VERBATIUM_INSIDE_STRING() { return GetToken(CSharpParser.VERBATIUM_INSIDE_STRING, 0); }
		public Interpolated_verbatium_string_partContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interpolated_verbatium_string_part; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterInterpolated_verbatium_string_part(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitInterpolated_verbatium_string_part(this);
		}
	}

	[RuleVersion(0)]
	public Interpolated_verbatium_string_partContext interpolated_verbatium_string_part() {
		Interpolated_verbatium_string_partContext _localctx = new Interpolated_verbatium_string_partContext(Context, State);
		EnterRule(_localctx, 392, RULE_interpolated_verbatium_string_part);
		try {
			State = 2403;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ADD:
			case ALIAS:
			case ARGLIST:
			case ASCENDING:
			case ASYNC:
			case AWAIT:
			case BASE:
			case BOOL:
			case BY:
			case BYTE:
			case CHAR:
			case CHECKED:
			case DECIMAL:
			case DEFAULT:
			case DELEGATE:
			case DESCENDING:
			case DOUBLE:
			case DYNAMIC:
			case EQUALS:
			case FALSE:
			case FLOAT:
			case FROM:
			case GET:
			case GROUP:
			case INT:
			case INTO:
			case JOIN:
			case LET:
			case LONG:
			case NAMEOF:
			case NEW:
			case NULL_:
			case OBJECT:
			case ON:
			case ORDERBY:
			case PARTIAL:
			case REF:
			case REMOVE:
			case SBYTE:
			case SELECT:
			case SET:
			case SHORT:
			case SIZEOF:
			case STRING:
			case THIS:
			case TRUE:
			case TYPEOF:
			case UINT:
			case ULONG:
			case UNCHECKED:
			case UNMANAGED:
			case USHORT:
			case VAR:
			case WHEN:
			case WHERE:
			case YIELD:
			case IDENTIFIER:
			case LITERAL_ACCESS:
			case INTEGER_LITERAL:
			case HEX_INTEGER_LITERAL:
			case BIN_INTEGER_LITERAL:
			case REAL_LITERAL:
			case CHARACTER_LITERAL:
			case REGULAR_STRING:
			case VERBATIUM_STRING:
			case INTERPOLATED_REGULAR_STRING_START:
			case INTERPOLATED_VERBATIUM_STRING_START:
			case OPEN_PARENS:
			case PLUS:
			case MINUS:
			case STAR:
			case AMP:
			case CARET:
			case BANG:
			case TILDE:
			case OP_INC:
			case OP_DEC:
			case OP_RANGE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2399;
				interpolated_string_expression();
				}
				break;
			case DOUBLE_CURLY_INSIDE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2400;
				Match(DOUBLE_CURLY_INSIDE);
				}
				break;
			case VERBATIUM_DOUBLE_QUOTE_INSIDE:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2401;
				Match(VERBATIUM_DOUBLE_QUOTE_INSIDE);
				}
				break;
			case VERBATIUM_INSIDE_STRING:
				EnterOuterAlt(_localctx, 4);
				{
				State = 2402;
				Match(VERBATIUM_INSIDE_STRING);
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

	public partial class Interpolated_string_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(CSharpParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(CSharpParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(CSharpParser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] FORMAT_STRING() { return GetTokens(CSharpParser.FORMAT_STRING); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FORMAT_STRING(int i) {
			return GetToken(CSharpParser.FORMAT_STRING, i);
		}
		public Interpolated_string_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interpolated_string_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterInterpolated_string_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitInterpolated_string_expression(this);
		}
	}

	[RuleVersion(0)]
	public Interpolated_string_expressionContext interpolated_string_expression() {
		Interpolated_string_expressionContext _localctx = new Interpolated_string_expressionContext(Context, State);
		EnterRule(_localctx, 394, RULE_interpolated_string_expression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2405;
			expression();
			State = 2410;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 2406;
				Match(COMMA);
				State = 2407;
				expression();
				}
				}
				State = 2412;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 2419;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==COLON) {
				{
				State = 2413;
				Match(COLON);
				State = 2415;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				do {
					{
					{
					State = 2414;
					Match(FORMAT_STRING);
					}
					}
					State = 2417;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				} while ( _la==FORMAT_STRING );
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

	public partial class KeywordContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ABSTRACT() { return GetToken(CSharpParser.ABSTRACT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AS() { return GetToken(CSharpParser.AS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BASE() { return GetToken(CSharpParser.BASE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BOOL() { return GetToken(CSharpParser.BOOL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BREAK() { return GetToken(CSharpParser.BREAK, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BYTE() { return GetToken(CSharpParser.BYTE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CASE() { return GetToken(CSharpParser.CASE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CATCH() { return GetToken(CSharpParser.CATCH, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CHAR() { return GetToken(CSharpParser.CHAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CHECKED() { return GetToken(CSharpParser.CHECKED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLASS() { return GetToken(CSharpParser.CLASS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CONST() { return GetToken(CSharpParser.CONST, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CONTINUE() { return GetToken(CSharpParser.CONTINUE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DECIMAL() { return GetToken(CSharpParser.DECIMAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFAULT() { return GetToken(CSharpParser.DEFAULT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DELEGATE() { return GetToken(CSharpParser.DELEGATE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DO() { return GetToken(CSharpParser.DO, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOUBLE() { return GetToken(CSharpParser.DOUBLE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ELSE() { return GetToken(CSharpParser.ELSE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ENUM() { return GetToken(CSharpParser.ENUM, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EVENT() { return GetToken(CSharpParser.EVENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXPLICIT() { return GetToken(CSharpParser.EXPLICIT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXTERN() { return GetToken(CSharpParser.EXTERN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FALSE() { return GetToken(CSharpParser.FALSE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FINALLY() { return GetToken(CSharpParser.FINALLY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FIXED() { return GetToken(CSharpParser.FIXED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FLOAT() { return GetToken(CSharpParser.FLOAT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOR() { return GetToken(CSharpParser.FOR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOREACH() { return GetToken(CSharpParser.FOREACH, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GOTO() { return GetToken(CSharpParser.GOTO, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IF() { return GetToken(CSharpParser.IF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IMPLICIT() { return GetToken(CSharpParser.IMPLICIT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IN() { return GetToken(CSharpParser.IN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT() { return GetToken(CSharpParser.INT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERFACE() { return GetToken(CSharpParser.INTERFACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERNAL() { return GetToken(CSharpParser.INTERNAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IS() { return GetToken(CSharpParser.IS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LOCK() { return GetToken(CSharpParser.LOCK, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LONG() { return GetToken(CSharpParser.LONG, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NAMESPACE() { return GetToken(CSharpParser.NAMESPACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEW() { return GetToken(CSharpParser.NEW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NULL_() { return GetToken(CSharpParser.NULL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OBJECT() { return GetToken(CSharpParser.OBJECT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPERATOR() { return GetToken(CSharpParser.OPERATOR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OUT() { return GetToken(CSharpParser.OUT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OVERRIDE() { return GetToken(CSharpParser.OVERRIDE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PARAMS() { return GetToken(CSharpParser.PARAMS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRIVATE() { return GetToken(CSharpParser.PRIVATE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PROTECTED() { return GetToken(CSharpParser.PROTECTED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLIC() { return GetToken(CSharpParser.PUBLIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode READONLY() { return GetToken(CSharpParser.READONLY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REF() { return GetToken(CSharpParser.REF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RETURN() { return GetToken(CSharpParser.RETURN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SBYTE() { return GetToken(CSharpParser.SBYTE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEALED() { return GetToken(CSharpParser.SEALED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SHORT() { return GetToken(CSharpParser.SHORT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SIZEOF() { return GetToken(CSharpParser.SIZEOF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STACKALLOC() { return GetToken(CSharpParser.STACKALLOC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STATIC() { return GetToken(CSharpParser.STATIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRING() { return GetToken(CSharpParser.STRING, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRUCT() { return GetToken(CSharpParser.STRUCT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SWITCH() { return GetToken(CSharpParser.SWITCH, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THIS() { return GetToken(CSharpParser.THIS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THROW() { return GetToken(CSharpParser.THROW, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRUE() { return GetToken(CSharpParser.TRUE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRY() { return GetToken(CSharpParser.TRY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TYPEOF() { return GetToken(CSharpParser.TYPEOF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UINT() { return GetToken(CSharpParser.UINT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ULONG() { return GetToken(CSharpParser.ULONG, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNCHECKED() { return GetToken(CSharpParser.UNCHECKED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNMANAGED() { return GetToken(CSharpParser.UNMANAGED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNSAFE() { return GetToken(CSharpParser.UNSAFE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode USHORT() { return GetToken(CSharpParser.USHORT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode USING() { return GetToken(CSharpParser.USING, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VIRTUAL() { return GetToken(CSharpParser.VIRTUAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOID() { return GetToken(CSharpParser.VOID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VOLATILE() { return GetToken(CSharpParser.VOLATILE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHILE() { return GetToken(CSharpParser.WHILE, 0); }
		public KeywordContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_keyword; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterKeyword(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitKeyword(this);
		}
	}

	[RuleVersion(0)]
	public KeywordContext keyword() {
		KeywordContext _localctx = new KeywordContext(Context, State);
		EnterRule(_localctx, 396, RULE_keyword);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2421;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABSTRACT) | (1L << AS) | (1L << BASE) | (1L << BOOL) | (1L << BREAK) | (1L << BYTE) | (1L << CASE) | (1L << CATCH) | (1L << CHAR) | (1L << CHECKED) | (1L << CLASS) | (1L << CONST) | (1L << CONTINUE) | (1L << DECIMAL) | (1L << DEFAULT) | (1L << DELEGATE) | (1L << DO) | (1L << DOUBLE) | (1L << ELSE) | (1L << ENUM) | (1L << EVENT) | (1L << EXPLICIT) | (1L << EXTERN) | (1L << FALSE) | (1L << FINALLY) | (1L << FIXED) | (1L << FLOAT) | (1L << FOR) | (1L << FOREACH) | (1L << GOTO) | (1L << IF) | (1L << IMPLICIT) | (1L << IN) | (1L << INT) | (1L << INTERFACE) | (1L << INTERNAL) | (1L << IS) | (1L << LOCK) | (1L << LONG))) != 0) || ((((_la - 65)) & ~0x3f) == 0 && ((1L << (_la - 65)) & ((1L << (NAMESPACE - 65)) | (1L << (NEW - 65)) | (1L << (NULL_ - 65)) | (1L << (OBJECT - 65)) | (1L << (OPERATOR - 65)) | (1L << (OUT - 65)) | (1L << (OVERRIDE - 65)) | (1L << (PARAMS - 65)) | (1L << (PRIVATE - 65)) | (1L << (PROTECTED - 65)) | (1L << (PUBLIC - 65)) | (1L << (READONLY - 65)) | (1L << (REF - 65)) | (1L << (RETURN - 65)) | (1L << (SBYTE - 65)) | (1L << (SEALED - 65)) | (1L << (SHORT - 65)) | (1L << (SIZEOF - 65)) | (1L << (STACKALLOC - 65)) | (1L << (STATIC - 65)) | (1L << (STRING - 65)) | (1L << (STRUCT - 65)) | (1L << (SWITCH - 65)) | (1L << (THIS - 65)) | (1L << (THROW - 65)) | (1L << (TRUE - 65)) | (1L << (TRY - 65)) | (1L << (TYPEOF - 65)) | (1L << (UINT - 65)) | (1L << (ULONG - 65)) | (1L << (UNCHECKED - 65)) | (1L << (UNMANAGED - 65)) | (1L << (UNSAFE - 65)) | (1L << (USHORT - 65)) | (1L << (USING - 65)) | (1L << (VIRTUAL - 65)) | (1L << (VOID - 65)) | (1L << (VOLATILE - 65)) | (1L << (WHILE - 65)))) != 0)) ) {
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

	public partial class Class_definitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLASS() { return GetToken(CSharpParser.CLASS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Class_bodyContext class_body() {
			return GetRuleContext<Class_bodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_parameter_listContext type_parameter_list() {
			return GetRuleContext<Type_parameter_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Class_baseContext class_base() {
			return GetRuleContext<Class_baseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_parameter_constraints_clausesContext type_parameter_constraints_clauses() {
			return GetRuleContext<Type_parameter_constraints_clausesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public Class_definitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_class_definition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterClass_definition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitClass_definition(this);
		}
	}

	[RuleVersion(0)]
	public Class_definitionContext class_definition() {
		Class_definitionContext _localctx = new Class_definitionContext(Context, State);
		EnterRule(_localctx, 398, RULE_class_definition);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2423;
			Match(CLASS);
			State = 2424;
			identifier();
			State = 2426;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LT) {
				{
				State = 2425;
				type_parameter_list();
				}
			}

			State = 2429;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==COLON) {
				{
				State = 2428;
				class_base();
				}
			}

			State = 2432;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WHERE) {
				{
				State = 2431;
				type_parameter_constraints_clauses();
				}
			}

			State = 2434;
			class_body();
			State = 2436;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SEMICOLON) {
				{
				State = 2435;
				Match(SEMICOLON);
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

	public partial class Struct_definitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRUCT() { return GetToken(CSharpParser.STRUCT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Struct_bodyContext struct_body() {
			return GetRuleContext<Struct_bodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_parameter_listContext type_parameter_list() {
			return GetRuleContext<Type_parameter_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Struct_interfacesContext struct_interfaces() {
			return GetRuleContext<Struct_interfacesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_parameter_constraints_clausesContext type_parameter_constraints_clauses() {
			return GetRuleContext<Type_parameter_constraints_clausesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode READONLY() { return GetToken(CSharpParser.READONLY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REF() { return GetToken(CSharpParser.REF, 0); }
		public Struct_definitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_struct_definition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterStruct_definition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitStruct_definition(this);
		}
	}

	[RuleVersion(0)]
	public Struct_definitionContext struct_definition() {
		Struct_definitionContext _localctx = new Struct_definitionContext(Context, State);
		EnterRule(_localctx, 400, RULE_struct_definition);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2439;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==READONLY || _la==REF) {
				{
				State = 2438;
				_la = TokenStream.LA(1);
				if ( !(_la==READONLY || _la==REF) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
			}

			State = 2441;
			Match(STRUCT);
			State = 2442;
			identifier();
			State = 2444;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LT) {
				{
				State = 2443;
				type_parameter_list();
				}
			}

			State = 2447;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==COLON) {
				{
				State = 2446;
				struct_interfaces();
				}
			}

			State = 2450;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WHERE) {
				{
				State = 2449;
				type_parameter_constraints_clauses();
				}
			}

			State = 2452;
			struct_body();
			State = 2454;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SEMICOLON) {
				{
				State = 2453;
				Match(SEMICOLON);
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

	public partial class Interface_definitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERFACE() { return GetToken(CSharpParser.INTERFACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Class_bodyContext class_body() {
			return GetRuleContext<Class_bodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Variant_type_parameter_listContext variant_type_parameter_list() {
			return GetRuleContext<Variant_type_parameter_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Interface_baseContext interface_base() {
			return GetRuleContext<Interface_baseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_parameter_constraints_clausesContext type_parameter_constraints_clauses() {
			return GetRuleContext<Type_parameter_constraints_clausesContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public Interface_definitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_interface_definition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterInterface_definition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitInterface_definition(this);
		}
	}

	[RuleVersion(0)]
	public Interface_definitionContext interface_definition() {
		Interface_definitionContext _localctx = new Interface_definitionContext(Context, State);
		EnterRule(_localctx, 402, RULE_interface_definition);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2456;
			Match(INTERFACE);
			State = 2457;
			identifier();
			State = 2459;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LT) {
				{
				State = 2458;
				variant_type_parameter_list();
				}
			}

			State = 2462;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==COLON) {
				{
				State = 2461;
				interface_base();
				}
			}

			State = 2465;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WHERE) {
				{
				State = 2464;
				type_parameter_constraints_clauses();
				}
			}

			State = 2467;
			class_body();
			State = 2469;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SEMICOLON) {
				{
				State = 2468;
				Match(SEMICOLON);
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

	public partial class Enum_definitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ENUM() { return GetToken(CSharpParser.ENUM, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Enum_bodyContext enum_body() {
			return GetRuleContext<Enum_bodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Enum_baseContext enum_base() {
			return GetRuleContext<Enum_baseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public Enum_definitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_enum_definition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterEnum_definition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitEnum_definition(this);
		}
	}

	[RuleVersion(0)]
	public Enum_definitionContext enum_definition() {
		Enum_definitionContext _localctx = new Enum_definitionContext(Context, State);
		EnterRule(_localctx, 404, RULE_enum_definition);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2471;
			Match(ENUM);
			State = 2472;
			identifier();
			State = 2474;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==COLON) {
				{
				State = 2473;
				enum_base();
				}
			}

			State = 2476;
			enum_body();
			State = 2478;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SEMICOLON) {
				{
				State = 2477;
				Match(SEMICOLON);
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

	public partial class Delegate_definitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DELEGATE() { return GetToken(CSharpParser.DELEGATE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Return_typeContext return_type() {
			return GetRuleContext<Return_typeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Variant_type_parameter_listContext variant_type_parameter_list() {
			return GetRuleContext<Variant_type_parameter_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Formal_parameter_listContext formal_parameter_list() {
			return GetRuleContext<Formal_parameter_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_parameter_constraints_clausesContext type_parameter_constraints_clauses() {
			return GetRuleContext<Type_parameter_constraints_clausesContext>(0);
		}
		public Delegate_definitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_delegate_definition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterDelegate_definition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitDelegate_definition(this);
		}
	}

	[RuleVersion(0)]
	public Delegate_definitionContext delegate_definition() {
		Delegate_definitionContext _localctx = new Delegate_definitionContext(Context, State);
		EnterRule(_localctx, 406, RULE_delegate_definition);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2480;
			Match(DELEGATE);
			State = 2481;
			return_type();
			State = 2482;
			identifier();
			State = 2484;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LT) {
				{
				State = 2483;
				variant_type_parameter_list();
				}
			}

			State = 2486;
			Match(OPEN_PARENS);
			State = 2488;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 10)) & ~0x3f) == 0 && ((1L << (_la - 10)) & ((1L << (ADD - 10)) | (1L << (ALIAS - 10)) | (1L << (ARGLIST - 10)) | (1L << (ASCENDING - 10)) | (1L << (ASYNC - 10)) | (1L << (AWAIT - 10)) | (1L << (BOOL - 10)) | (1L << (BY - 10)) | (1L << (BYTE - 10)) | (1L << (CHAR - 10)) | (1L << (DECIMAL - 10)) | (1L << (DESCENDING - 10)) | (1L << (DOUBLE - 10)) | (1L << (DYNAMIC - 10)) | (1L << (EQUALS - 10)) | (1L << (FLOAT - 10)) | (1L << (FROM - 10)) | (1L << (GET - 10)) | (1L << (GROUP - 10)) | (1L << (IN - 10)) | (1L << (INT - 10)) | (1L << (INTO - 10)) | (1L << (JOIN - 10)) | (1L << (LET - 10)) | (1L << (LONG - 10)) | (1L << (NAMEOF - 10)) | (1L << (OBJECT - 10)) | (1L << (ON - 10)) | (1L << (ORDERBY - 10)) | (1L << (OUT - 10)))) != 0) || ((((_la - 74)) & ~0x3f) == 0 && ((1L << (_la - 74)) & ((1L << (PARAMS - 74)) | (1L << (PARTIAL - 74)) | (1L << (REF - 74)) | (1L << (REMOVE - 74)) | (1L << (SBYTE - 74)) | (1L << (SELECT - 74)) | (1L << (SET - 74)) | (1L << (SHORT - 74)) | (1L << (STRING - 74)) | (1L << (THIS - 74)) | (1L << (UINT - 74)) | (1L << (ULONG - 74)) | (1L << (UNMANAGED - 74)) | (1L << (USHORT - 74)) | (1L << (VAR - 74)) | (1L << (VOID - 74)) | (1L << (WHEN - 74)) | (1L << (WHERE - 74)) | (1L << (YIELD - 74)) | (1L << (IDENTIFIER - 74)) | (1L << (OPEN_BRACKET - 74)) | (1L << (OPEN_PARENS - 74)))) != 0)) {
				{
				State = 2487;
				formal_parameter_list();
				}
			}

			State = 2490;
			Match(CLOSE_PARENS);
			State = 2492;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WHERE) {
				{
				State = 2491;
				type_parameter_constraints_clauses();
				}
			}

			State = 2494;
			Match(SEMICOLON);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Event_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EVENT() { return GetToken(CSharpParser.EVENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Variable_declaratorsContext variable_declarators() {
			return GetRuleContext<Variable_declaratorsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Member_nameContext member_name() {
			return GetRuleContext<Member_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Event_accessor_declarationsContext event_accessor_declarations() {
			return GetRuleContext<Event_accessor_declarationsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		public Event_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_event_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterEvent_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitEvent_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Event_declarationContext event_declaration() {
		Event_declarationContext _localctx = new Event_declarationContext(Context, State);
		EnterRule(_localctx, 408, RULE_event_declaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2496;
			Match(EVENT);
			State = 2497;
			type_();
			State = 2506;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,323,Context) ) {
			case 1:
				{
				State = 2498;
				variable_declarators();
				State = 2499;
				Match(SEMICOLON);
				}
				break;
			case 2:
				{
				State = 2501;
				member_name();
				State = 2502;
				Match(OPEN_BRACE);
				State = 2503;
				event_accessor_declarations();
				State = 2504;
				Match(CLOSE_BRACE);
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

	public partial class Field_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Variable_declaratorsContext variable_declarators() {
			return GetRuleContext<Variable_declaratorsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public Field_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_field_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterField_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitField_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Field_declarationContext field_declaration() {
		Field_declarationContext _localctx = new Field_declarationContext(Context, State);
		EnterRule(_localctx, 410, RULE_field_declaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2508;
			variable_declarators();
			State = 2509;
			Match(SEMICOLON);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Property_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Member_nameContext member_name() {
			return GetRuleContext<Member_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Accessor_declarationsContext accessor_declarations() {
			return GetRuleContext<Accessor_declarationsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Right_arrowContext right_arrow() {
			return GetRuleContext<Right_arrowContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Throwable_expressionContext throwable_expression() {
			return GetRuleContext<Throwable_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGNMENT() { return GetToken(CSharpParser.ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Variable_initializerContext variable_initializer() {
			return GetRuleContext<Variable_initializerContext>(0);
		}
		public Property_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_property_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterProperty_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitProperty_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Property_declarationContext property_declaration() {
		Property_declarationContext _localctx = new Property_declarationContext(Context, State);
		EnterRule(_localctx, 412, RULE_property_declaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2511;
			member_name();
			State = 2525;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case OPEN_BRACE:
				{
				State = 2512;
				Match(OPEN_BRACE);
				State = 2513;
				accessor_declarations();
				State = 2514;
				Match(CLOSE_BRACE);
				State = 2519;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==ASSIGNMENT) {
					{
					State = 2515;
					Match(ASSIGNMENT);
					State = 2516;
					variable_initializer();
					State = 2517;
					Match(SEMICOLON);
					}
				}

				}
				break;
			case ASSIGNMENT:
				{
				State = 2521;
				right_arrow();
				State = 2522;
				throwable_expression();
				State = 2523;
				Match(SEMICOLON);
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

	public partial class Constant_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CONST() { return GetToken(CSharpParser.CONST, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Constant_declaratorsContext constant_declarators() {
			return GetRuleContext<Constant_declaratorsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public Constant_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constant_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterConstant_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitConstant_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Constant_declarationContext constant_declaration() {
		Constant_declarationContext _localctx = new Constant_declarationContext(Context, State);
		EnterRule(_localctx, 414, RULE_constant_declaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2527;
			Match(CONST);
			State = 2528;
			type_();
			State = 2529;
			constant_declarators();
			State = 2530;
			Match(SEMICOLON);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Indexer_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THIS() { return GetToken(CSharpParser.THIS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACKET() { return GetToken(CSharpParser.OPEN_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Formal_parameter_listContext formal_parameter_list() {
			return GetRuleContext<Formal_parameter_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACKET() { return GetToken(CSharpParser.CLOSE_BRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_BRACE() { return GetToken(CSharpParser.OPEN_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Accessor_declarationsContext accessor_declarations() {
			return GetRuleContext<Accessor_declarationsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_BRACE() { return GetToken(CSharpParser.CLOSE_BRACE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Right_arrowContext right_arrow() {
			return GetRuleContext<Right_arrowContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Throwable_expressionContext throwable_expression() {
			return GetRuleContext<Throwable_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		public Indexer_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_indexer_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterIndexer_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitIndexer_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Indexer_declarationContext indexer_declaration() {
		Indexer_declarationContext _localctx = new Indexer_declarationContext(Context, State);
		EnterRule(_localctx, 416, RULE_indexer_declaration);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2532;
			Match(THIS);
			State = 2533;
			Match(OPEN_BRACKET);
			State = 2534;
			formal_parameter_list();
			State = 2535;
			Match(CLOSE_BRACKET);
			State = 2544;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case OPEN_BRACE:
				{
				State = 2536;
				Match(OPEN_BRACE);
				State = 2537;
				accessor_declarations();
				State = 2538;
				Match(CLOSE_BRACE);
				}
				break;
			case ASSIGNMENT:
				{
				State = 2540;
				right_arrow();
				State = 2541;
				throwable_expression();
				State = 2542;
				Match(SEMICOLON);
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

	public partial class Destructor_definitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TILDE() { return GetToken(CSharpParser.TILDE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BodyContext body() {
			return GetRuleContext<BodyContext>(0);
		}
		public Destructor_definitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_destructor_definition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterDestructor_definition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitDestructor_definition(this);
		}
	}

	[RuleVersion(0)]
	public Destructor_definitionContext destructor_definition() {
		Destructor_definitionContext _localctx = new Destructor_definitionContext(Context, State);
		EnterRule(_localctx, 418, RULE_destructor_definition);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2546;
			Match(TILDE);
			State = 2547;
			identifier();
			State = 2548;
			Match(OPEN_PARENS);
			State = 2549;
			Match(CLOSE_PARENS);
			State = 2550;
			body();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Constructor_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BodyContext body() {
			return GetRuleContext<BodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Formal_parameter_listContext formal_parameter_list() {
			return GetRuleContext<Formal_parameter_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Constructor_initializerContext constructor_initializer() {
			return GetRuleContext<Constructor_initializerContext>(0);
		}
		public Constructor_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constructor_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterConstructor_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitConstructor_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Constructor_declarationContext constructor_declaration() {
		Constructor_declarationContext _localctx = new Constructor_declarationContext(Context, State);
		EnterRule(_localctx, 420, RULE_constructor_declaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2552;
			identifier();
			State = 2553;
			Match(OPEN_PARENS);
			State = 2555;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 10)) & ~0x3f) == 0 && ((1L << (_la - 10)) & ((1L << (ADD - 10)) | (1L << (ALIAS - 10)) | (1L << (ARGLIST - 10)) | (1L << (ASCENDING - 10)) | (1L << (ASYNC - 10)) | (1L << (AWAIT - 10)) | (1L << (BOOL - 10)) | (1L << (BY - 10)) | (1L << (BYTE - 10)) | (1L << (CHAR - 10)) | (1L << (DECIMAL - 10)) | (1L << (DESCENDING - 10)) | (1L << (DOUBLE - 10)) | (1L << (DYNAMIC - 10)) | (1L << (EQUALS - 10)) | (1L << (FLOAT - 10)) | (1L << (FROM - 10)) | (1L << (GET - 10)) | (1L << (GROUP - 10)) | (1L << (IN - 10)) | (1L << (INT - 10)) | (1L << (INTO - 10)) | (1L << (JOIN - 10)) | (1L << (LET - 10)) | (1L << (LONG - 10)) | (1L << (NAMEOF - 10)) | (1L << (OBJECT - 10)) | (1L << (ON - 10)) | (1L << (ORDERBY - 10)) | (1L << (OUT - 10)))) != 0) || ((((_la - 74)) & ~0x3f) == 0 && ((1L << (_la - 74)) & ((1L << (PARAMS - 74)) | (1L << (PARTIAL - 74)) | (1L << (REF - 74)) | (1L << (REMOVE - 74)) | (1L << (SBYTE - 74)) | (1L << (SELECT - 74)) | (1L << (SET - 74)) | (1L << (SHORT - 74)) | (1L << (STRING - 74)) | (1L << (THIS - 74)) | (1L << (UINT - 74)) | (1L << (ULONG - 74)) | (1L << (UNMANAGED - 74)) | (1L << (USHORT - 74)) | (1L << (VAR - 74)) | (1L << (VOID - 74)) | (1L << (WHEN - 74)) | (1L << (WHERE - 74)) | (1L << (YIELD - 74)) | (1L << (IDENTIFIER - 74)) | (1L << (OPEN_BRACKET - 74)) | (1L << (OPEN_PARENS - 74)))) != 0)) {
				{
				State = 2554;
				formal_parameter_list();
				}
			}

			State = 2557;
			Match(CLOSE_PARENS);
			State = 2559;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==COLON) {
				{
				State = 2558;
				constructor_initializer();
				}
			}

			State = 2561;
			body();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Method_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Method_member_nameContext method_member_name() {
			return GetRuleContext<Method_member_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Method_bodyContext method_body() {
			return GetRuleContext<Method_bodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Right_arrowContext right_arrow() {
			return GetRuleContext<Right_arrowContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Throwable_expressionContext throwable_expression() {
			return GetRuleContext<Throwable_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_parameter_listContext type_parameter_list() {
			return GetRuleContext<Type_parameter_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Formal_parameter_listContext formal_parameter_list() {
			return GetRuleContext<Formal_parameter_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_parameter_constraints_clausesContext type_parameter_constraints_clauses() {
			return GetRuleContext<Type_parameter_constraints_clausesContext>(0);
		}
		public Method_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_method_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterMethod_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitMethod_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Method_declarationContext method_declaration() {
		Method_declarationContext _localctx = new Method_declarationContext(Context, State);
		EnterRule(_localctx, 422, RULE_method_declaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2563;
			method_member_name();
			State = 2565;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LT) {
				{
				State = 2564;
				type_parameter_list();
				}
			}

			State = 2567;
			Match(OPEN_PARENS);
			State = 2569;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 10)) & ~0x3f) == 0 && ((1L << (_la - 10)) & ((1L << (ADD - 10)) | (1L << (ALIAS - 10)) | (1L << (ARGLIST - 10)) | (1L << (ASCENDING - 10)) | (1L << (ASYNC - 10)) | (1L << (AWAIT - 10)) | (1L << (BOOL - 10)) | (1L << (BY - 10)) | (1L << (BYTE - 10)) | (1L << (CHAR - 10)) | (1L << (DECIMAL - 10)) | (1L << (DESCENDING - 10)) | (1L << (DOUBLE - 10)) | (1L << (DYNAMIC - 10)) | (1L << (EQUALS - 10)) | (1L << (FLOAT - 10)) | (1L << (FROM - 10)) | (1L << (GET - 10)) | (1L << (GROUP - 10)) | (1L << (IN - 10)) | (1L << (INT - 10)) | (1L << (INTO - 10)) | (1L << (JOIN - 10)) | (1L << (LET - 10)) | (1L << (LONG - 10)) | (1L << (NAMEOF - 10)) | (1L << (OBJECT - 10)) | (1L << (ON - 10)) | (1L << (ORDERBY - 10)) | (1L << (OUT - 10)))) != 0) || ((((_la - 74)) & ~0x3f) == 0 && ((1L << (_la - 74)) & ((1L << (PARAMS - 74)) | (1L << (PARTIAL - 74)) | (1L << (REF - 74)) | (1L << (REMOVE - 74)) | (1L << (SBYTE - 74)) | (1L << (SELECT - 74)) | (1L << (SET - 74)) | (1L << (SHORT - 74)) | (1L << (STRING - 74)) | (1L << (THIS - 74)) | (1L << (UINT - 74)) | (1L << (ULONG - 74)) | (1L << (UNMANAGED - 74)) | (1L << (USHORT - 74)) | (1L << (VAR - 74)) | (1L << (VOID - 74)) | (1L << (WHEN - 74)) | (1L << (WHERE - 74)) | (1L << (YIELD - 74)) | (1L << (IDENTIFIER - 74)) | (1L << (OPEN_BRACKET - 74)) | (1L << (OPEN_PARENS - 74)))) != 0)) {
				{
				State = 2568;
				formal_parameter_list();
				}
			}

			State = 2571;
			Match(CLOSE_PARENS);
			State = 2573;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WHERE) {
				{
				State = 2572;
				type_parameter_constraints_clauses();
				}
			}

			State = 2580;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case OPEN_BRACE:
			case SEMICOLON:
				{
				State = 2575;
				method_body();
				}
				break;
			case ASSIGNMENT:
				{
				State = 2576;
				right_arrow();
				State = 2577;
				throwable_expression();
				State = 2578;
				Match(SEMICOLON);
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

	public partial class Method_member_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOUBLE_COLON() { return GetToken(CSharpParser.DOUBLE_COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DOT() { return GetTokens(CSharpParser.DOT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT(int i) {
			return GetToken(CSharpParser.DOT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_argument_listContext[] type_argument_list() {
			return GetRuleContexts<Type_argument_listContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_argument_listContext type_argument_list(int i) {
			return GetRuleContext<Type_argument_listContext>(i);
		}
		public Method_member_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_method_member_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterMethod_member_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitMethod_member_name(this);
		}
	}

	[RuleVersion(0)]
	public Method_member_nameContext method_member_name() {
		Method_member_nameContext _localctx = new Method_member_nameContext(Context, State);
		EnterRule(_localctx, 424, RULE_method_member_name);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 2587;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,333,Context) ) {
			case 1:
				{
				State = 2582;
				identifier();
				}
				break;
			case 2:
				{
				State = 2583;
				identifier();
				State = 2584;
				Match(DOUBLE_COLON);
				State = 2585;
				identifier();
				}
				break;
			}
			State = 2596;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,335,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 2590;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==LT) {
						{
						State = 2589;
						type_argument_list();
						}
					}

					State = 2592;
					Match(DOT);
					State = 2593;
					identifier();
					}
					} 
				}
				State = 2598;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,335,Context);
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

	public partial class Operator_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPERATOR() { return GetToken(CSharpParser.OPERATOR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Overloadable_operatorContext overloadable_operator() {
			return GetRuleContext<Overloadable_operatorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Arg_declarationContext[] arg_declaration() {
			return GetRuleContexts<Arg_declarationContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Arg_declarationContext arg_declaration(int i) {
			return GetRuleContext<Arg_declarationContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public BodyContext body() {
			return GetRuleContext<BodyContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Right_arrowContext right_arrow() {
			return GetRuleContext<Right_arrowContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Throwable_expressionContext throwable_expression() {
			return GetRuleContext<Throwable_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEMICOLON() { return GetToken(CSharpParser.SEMICOLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] IN() { return GetTokens(CSharpParser.IN); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IN(int i) {
			return GetToken(CSharpParser.IN, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(CSharpParser.COMMA, 0); }
		public Operator_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_operator_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterOperator_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitOperator_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Operator_declarationContext operator_declaration() {
		Operator_declarationContext _localctx = new Operator_declarationContext(Context, State);
		EnterRule(_localctx, 426, RULE_operator_declaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2599;
			Match(OPERATOR);
			State = 2600;
			overloadable_operator();
			State = 2601;
			Match(OPEN_PARENS);
			State = 2603;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==IN) {
				{
				State = 2602;
				Match(IN);
				}
			}

			State = 2605;
			arg_declaration();
			State = 2611;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==COMMA) {
				{
				State = 2606;
				Match(COMMA);
				State = 2608;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==IN) {
					{
					State = 2607;
					Match(IN);
					}
				}

				State = 2610;
				arg_declaration();
				}
			}

			State = 2613;
			Match(CLOSE_PARENS);
			State = 2619;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case OPEN_BRACE:
			case SEMICOLON:
				{
				State = 2614;
				body();
				}
				break;
			case ASSIGNMENT:
				{
				State = 2615;
				right_arrow();
				State = 2616;
				throwable_expression();
				State = 2617;
				Match(SEMICOLON);
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

	public partial class Arg_declarationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Type_Context type_() {
			return GetRuleContext<Type_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGNMENT() { return GetToken(CSharpParser.ASSIGNMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public Arg_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_arg_declaration; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterArg_declaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitArg_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Arg_declarationContext arg_declaration() {
		Arg_declarationContext _localctx = new Arg_declarationContext(Context, State);
		EnterRule(_localctx, 428, RULE_arg_declaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2621;
			type_();
			State = 2622;
			identifier();
			State = 2625;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==ASSIGNMENT) {
				{
				State = 2623;
				Match(ASSIGNMENT);
				State = 2624;
				expression();
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

	public partial class Method_invocationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Argument_listContext argument_list() {
			return GetRuleContext<Argument_listContext>(0);
		}
		public Method_invocationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_method_invocation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterMethod_invocation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitMethod_invocation(this);
		}
	}

	[RuleVersion(0)]
	public Method_invocationContext method_invocation() {
		Method_invocationContext _localctx = new Method_invocationContext(Context, State);
		EnterRule(_localctx, 430, RULE_method_invocation);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2627;
			Match(OPEN_PARENS);
			State = 2629;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BASE) | (1L << BOOL) | (1L << BY) | (1L << BYTE) | (1L << CHAR) | (1L << CHECKED) | (1L << DECIMAL) | (1L << DEFAULT) | (1L << DELEGATE) | (1L << DESCENDING) | (1L << DOUBLE) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FALSE) | (1L << FLOAT) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << IN) | (1L << INT) | (1L << INTO) | (1L << JOIN) | (1L << LET) | (1L << LONG))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (NEW - 64)) | (1L << (NULL_ - 64)) | (1L << (OBJECT - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (OUT - 64)) | (1L << (PARTIAL - 64)) | (1L << (REF - 64)) | (1L << (REMOVE - 64)) | (1L << (SBYTE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (SHORT - 64)) | (1L << (SIZEOF - 64)) | (1L << (STRING - 64)) | (1L << (THIS - 64)) | (1L << (TRUE - 64)) | (1L << (TYPEOF - 64)) | (1L << (UINT - 64)) | (1L << (ULONG - 64)) | (1L << (UNCHECKED - 64)) | (1L << (UNMANAGED - 64)) | (1L << (USHORT - 64)) | (1L << (VAR - 64)) | (1L << (VOID - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (LITERAL_ACCESS - 64)) | (1L << (INTEGER_LITERAL - 64)) | (1L << (HEX_INTEGER_LITERAL - 64)) | (1L << (BIN_INTEGER_LITERAL - 64)) | (1L << (REAL_LITERAL - 64)) | (1L << (CHARACTER_LITERAL - 64)) | (1L << (REGULAR_STRING - 64)) | (1L << (VERBATIUM_STRING - 64)) | (1L << (INTERPOLATED_REGULAR_STRING_START - 64)) | (1L << (INTERPOLATED_VERBATIUM_STRING_START - 64)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (OPEN_PARENS - 129)) | (1L << (PLUS - 129)) | (1L << (MINUS - 129)) | (1L << (STAR - 129)) | (1L << (AMP - 129)) | (1L << (CARET - 129)) | (1L << (BANG - 129)) | (1L << (TILDE - 129)) | (1L << (OP_INC - 129)) | (1L << (OP_DEC - 129)) | (1L << (OP_RANGE - 129)))) != 0)) {
				{
				State = 2628;
				argument_list();
				}
			}

			State = 2631;
			Match(CLOSE_PARENS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Object_creation_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PARENS() { return GetToken(CSharpParser.OPEN_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PARENS() { return GetToken(CSharpParser.CLOSE_PARENS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Argument_listContext argument_list() {
			return GetRuleContext<Argument_listContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Object_or_collection_initializerContext object_or_collection_initializer() {
			return GetRuleContext<Object_or_collection_initializerContext>(0);
		}
		public Object_creation_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_object_creation_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterObject_creation_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitObject_creation_expression(this);
		}
	}

	[RuleVersion(0)]
	public Object_creation_expressionContext object_creation_expression() {
		Object_creation_expressionContext _localctx = new Object_creation_expressionContext(Context, State);
		EnterRule(_localctx, 432, RULE_object_creation_expression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2633;
			Match(OPEN_PARENS);
			State = 2635;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BASE) | (1L << BOOL) | (1L << BY) | (1L << BYTE) | (1L << CHAR) | (1L << CHECKED) | (1L << DECIMAL) | (1L << DEFAULT) | (1L << DELEGATE) | (1L << DESCENDING) | (1L << DOUBLE) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FALSE) | (1L << FLOAT) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << IN) | (1L << INT) | (1L << INTO) | (1L << JOIN) | (1L << LET) | (1L << LONG))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (NEW - 64)) | (1L << (NULL_ - 64)) | (1L << (OBJECT - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (OUT - 64)) | (1L << (PARTIAL - 64)) | (1L << (REF - 64)) | (1L << (REMOVE - 64)) | (1L << (SBYTE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (SHORT - 64)) | (1L << (SIZEOF - 64)) | (1L << (STRING - 64)) | (1L << (THIS - 64)) | (1L << (TRUE - 64)) | (1L << (TYPEOF - 64)) | (1L << (UINT - 64)) | (1L << (ULONG - 64)) | (1L << (UNCHECKED - 64)) | (1L << (UNMANAGED - 64)) | (1L << (USHORT - 64)) | (1L << (VAR - 64)) | (1L << (VOID - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)) | (1L << (LITERAL_ACCESS - 64)) | (1L << (INTEGER_LITERAL - 64)) | (1L << (HEX_INTEGER_LITERAL - 64)) | (1L << (BIN_INTEGER_LITERAL - 64)) | (1L << (REAL_LITERAL - 64)) | (1L << (CHARACTER_LITERAL - 64)) | (1L << (REGULAR_STRING - 64)) | (1L << (VERBATIUM_STRING - 64)) | (1L << (INTERPOLATED_REGULAR_STRING_START - 64)) | (1L << (INTERPOLATED_VERBATIUM_STRING_START - 64)))) != 0) || ((((_la - 129)) & ~0x3f) == 0 && ((1L << (_la - 129)) & ((1L << (OPEN_PARENS - 129)) | (1L << (PLUS - 129)) | (1L << (MINUS - 129)) | (1L << (STAR - 129)) | (1L << (AMP - 129)) | (1L << (CARET - 129)) | (1L << (BANG - 129)) | (1L << (TILDE - 129)) | (1L << (OP_INC - 129)) | (1L << (OP_DEC - 129)) | (1L << (OP_RANGE - 129)))) != 0)) {
				{
				State = 2634;
				argument_list();
				}
			}

			State = 2637;
			Match(CLOSE_PARENS);
			State = 2639;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,343,Context) ) {
			case 1:
				{
				State = 2638;
				object_or_collection_initializer();
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

	public partial class IdentifierContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(CSharpParser.IDENTIFIER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ADD() { return GetToken(CSharpParser.ADD, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ALIAS() { return GetToken(CSharpParser.ALIAS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ARGLIST() { return GetToken(CSharpParser.ARGLIST, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASCENDING() { return GetToken(CSharpParser.ASCENDING, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASYNC() { return GetToken(CSharpParser.ASYNC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AWAIT() { return GetToken(CSharpParser.AWAIT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BY() { return GetToken(CSharpParser.BY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DESCENDING() { return GetToken(CSharpParser.DESCENDING, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DYNAMIC() { return GetToken(CSharpParser.DYNAMIC, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EQUALS() { return GetToken(CSharpParser.EQUALS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FROM() { return GetToken(CSharpParser.FROM, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GET() { return GetToken(CSharpParser.GET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GROUP() { return GetToken(CSharpParser.GROUP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTO() { return GetToken(CSharpParser.INTO, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode JOIN() { return GetToken(CSharpParser.JOIN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LET() { return GetToken(CSharpParser.LET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NAMEOF() { return GetToken(CSharpParser.NAMEOF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ON() { return GetToken(CSharpParser.ON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ORDERBY() { return GetToken(CSharpParser.ORDERBY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PARTIAL() { return GetToken(CSharpParser.PARTIAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REMOVE() { return GetToken(CSharpParser.REMOVE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SELECT() { return GetToken(CSharpParser.SELECT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SET() { return GetToken(CSharpParser.SET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNMANAGED() { return GetToken(CSharpParser.UNMANAGED, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VAR() { return GetToken(CSharpParser.VAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHEN() { return GetToken(CSharpParser.WHEN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHERE() { return GetToken(CSharpParser.WHERE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode YIELD() { return GetToken(CSharpParser.YIELD, 0); }
		public IdentifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_identifier; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.EnterIdentifier(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ICSharpParserListener typedListener = listener as ICSharpParserListener;
			if (typedListener != null) typedListener.ExitIdentifier(this);
		}
	}

	[RuleVersion(0)]
	public IdentifierContext identifier() {
		IdentifierContext _localctx = new IdentifierContext(Context, State);
		EnterRule(_localctx, 434, RULE_identifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2641;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << ALIAS) | (1L << ARGLIST) | (1L << ASCENDING) | (1L << ASYNC) | (1L << AWAIT) | (1L << BY) | (1L << DESCENDING) | (1L << DYNAMIC) | (1L << EQUALS) | (1L << FROM) | (1L << GET) | (1L << GROUP) | (1L << INTO) | (1L << JOIN) | (1L << LET))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (NAMEOF - 64)) | (1L << (ON - 64)) | (1L << (ORDERBY - 64)) | (1L << (PARTIAL - 64)) | (1L << (REMOVE - 64)) | (1L << (SELECT - 64)) | (1L << (SET - 64)) | (1L << (UNMANAGED - 64)) | (1L << (VAR - 64)) | (1L << (WHEN - 64)) | (1L << (WHERE - 64)) | (1L << (YIELD - 64)) | (1L << (IDENTIFIER - 64)))) != 0)) ) {
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
		case 86: return local_variable_declaration_sempred((Local_variable_declarationContext)_localctx, predIndex);
		case 187: return right_arrow_sempred((Right_arrowContext)_localctx, predIndex);
		case 188: return right_shift_sempred((Right_shiftContext)_localctx, predIndex);
		case 189: return right_shift_assignment_sempred((Right_shift_assignmentContext)_localctx, predIndex);
		}
		return true;
	}
	private bool local_variable_declaration_sempred(Local_variable_declarationContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return  this.IsLocalVariableDeclaration() ;
		}
		return true;
	}
	private bool right_arrow_sempred(Right_arrowContext _localctx, int predIndex) {
		switch (predIndex) {
		case 1: return (_localctx.first!=null?_localctx.first.TokenIndex:0) + 1 == (_localctx.second!=null?_localctx.second.TokenIndex:0);
		}
		return true;
	}
	private bool right_shift_sempred(Right_shiftContext _localctx, int predIndex) {
		switch (predIndex) {
		case 2: return (_localctx.first!=null?_localctx.first.TokenIndex:0) + 1 == (_localctx.second!=null?_localctx.second.TokenIndex:0);
		}
		return true;
	}
	private bool right_shift_assignment_sempred(Right_shift_assignmentContext _localctx, int predIndex) {
		switch (predIndex) {
		case 3: return (_localctx.first!=null?_localctx.first.TokenIndex:0) + 1 == (_localctx.second!=null?_localctx.second.TokenIndex:0);
		}
		return true;
	}

	private static int[] _serializedATN = {
		4,1,198,2644,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,
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
		2,213,7,213,2,214,7,214,2,215,7,215,2,216,7,216,2,217,7,217,1,0,3,0,438,
		8,0,1,0,3,0,441,8,0,1,0,3,0,444,8,0,1,0,5,0,447,8,0,10,0,12,0,450,9,0,
		1,0,3,0,453,8,0,1,0,1,0,1,1,1,1,3,1,459,8,1,1,1,3,1,462,8,1,1,1,1,1,1,
		1,3,1,467,8,1,5,1,469,8,1,10,1,12,1,472,9,1,1,2,1,2,1,2,1,2,5,2,478,8,
		2,10,2,12,2,481,9,2,1,3,1,3,1,3,1,3,1,3,3,3,488,8,3,1,4,1,4,1,4,1,4,4,
		4,494,8,4,11,4,12,4,495,1,4,1,4,1,5,1,5,3,5,502,8,5,1,6,1,6,3,6,506,8,
		6,1,7,1,7,1,7,3,7,511,8,7,1,8,1,8,1,9,1,9,1,10,1,10,1,10,1,10,3,10,521,
		8,10,1,11,1,11,1,11,1,11,5,11,527,8,11,10,11,12,11,530,9,11,1,11,1,11,
		1,12,1,12,1,12,5,12,537,8,12,10,12,12,12,540,9,12,1,13,1,13,1,13,3,13,
		545,8,13,1,13,3,13,548,8,13,1,13,1,13,3,13,552,8,13,1,13,1,13,1,14,1,14,
		1,14,1,14,3,14,560,8,14,1,15,1,15,1,15,3,15,565,8,15,1,16,1,16,1,16,1,
		16,1,16,1,16,1,16,1,16,3,16,575,8,16,1,17,1,17,1,17,1,17,1,17,1,17,1,17,
		1,17,1,17,1,17,1,17,3,17,588,8,17,1,18,1,18,1,18,1,18,1,18,1,18,3,18,596,
		8,18,1,19,1,19,1,19,1,19,3,19,602,8,19,3,19,604,8,19,1,20,1,20,1,20,5,
		20,609,8,20,10,20,12,20,612,9,20,1,21,1,21,1,21,5,21,617,8,21,10,21,12,
		21,620,9,21,1,22,1,22,1,22,5,22,625,8,22,10,22,12,22,628,9,22,1,23,1,23,
		1,23,5,23,633,8,23,10,23,12,23,636,9,23,1,24,1,24,1,24,5,24,641,8,24,10,
		24,12,24,644,9,24,1,25,1,25,1,25,5,25,649,8,25,10,25,12,25,652,9,25,1,
		26,1,26,1,26,1,26,1,26,1,26,1,26,5,26,661,8,26,10,26,12,26,664,9,26,1,
		27,1,27,1,27,3,27,669,8,27,1,27,5,27,672,8,27,10,27,12,27,675,9,27,1,28,
		1,28,1,28,5,28,680,8,28,10,28,12,28,683,9,28,1,29,1,29,1,29,5,29,688,8,
		29,10,29,12,29,691,9,29,1,30,1,30,1,30,1,30,1,30,3,30,698,8,30,3,30,700,
		8,30,1,30,3,30,703,8,30,1,31,1,31,1,31,5,31,708,8,31,10,31,12,31,711,9,
		31,1,32,1,32,3,32,715,8,32,1,32,1,32,1,32,1,33,1,33,3,33,722,8,33,1,33,
		1,33,3,33,726,8,33,3,33,728,8,33,1,34,1,34,1,34,1,34,1,34,1,34,1,34,1,
		34,1,34,1,34,1,34,1,34,1,34,1,34,1,34,1,34,1,34,1,34,1,34,1,34,1,34,1,
		34,1,34,1,34,1,34,1,34,3,34,756,8,34,1,35,1,35,3,35,760,8,35,1,35,5,35,
		763,8,35,10,35,12,35,766,9,35,1,35,3,35,769,8,35,1,35,1,35,1,35,1,35,1,
		35,1,35,3,35,777,8,35,1,35,3,35,780,8,35,1,35,5,35,783,8,35,10,35,12,35,
		786,9,35,1,35,3,35,789,8,35,5,35,791,8,35,10,35,12,35,794,9,35,1,36,1,
		36,1,36,3,36,799,8,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,
		1,36,1,36,3,36,813,8,36,1,36,1,36,1,36,1,36,3,36,819,8,36,1,36,1,36,1,
		36,1,36,1,36,1,36,1,36,1,36,5,36,829,8,36,10,36,12,36,832,9,36,1,36,3,
		36,835,8,36,1,36,4,36,838,8,36,11,36,12,36,839,1,36,1,36,3,36,844,8,36,
		1,36,1,36,1,36,1,36,3,36,850,8,36,1,36,1,36,1,36,1,36,4,36,856,8,36,11,
		36,12,36,857,1,36,1,36,1,36,1,36,1,36,1,36,1,36,3,36,867,8,36,1,36,1,36,
		1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,
		3,36,885,8,36,1,36,3,36,888,8,36,1,36,1,36,1,36,3,36,893,8,36,1,36,3,36,
		896,8,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,5,36,909,
		8,36,10,36,12,36,912,9,36,1,36,1,36,1,36,3,36,917,8,36,1,37,1,37,3,37,
		921,8,37,1,38,1,38,1,38,1,39,3,39,927,8,39,1,39,1,39,1,39,3,39,932,8,39,
		1,40,3,40,935,8,40,1,40,1,40,1,40,1,40,5,40,941,8,40,10,40,12,40,944,9,
		40,1,40,1,40,1,41,1,41,1,41,3,41,951,8,41,1,41,1,41,1,42,1,42,1,43,1,43,
		1,43,5,43,960,8,43,10,43,12,43,963,9,43,1,44,1,44,3,44,967,8,44,1,45,1,
		45,1,45,3,45,972,8,45,3,45,974,8,45,1,45,1,45,1,46,1,46,1,46,5,46,981,
		8,46,10,46,12,46,984,9,46,1,47,1,47,1,47,1,47,1,47,3,47,991,8,47,1,47,
		1,47,1,47,1,48,1,48,3,48,998,8,48,1,49,1,49,1,49,1,49,5,49,1004,8,49,10,
		49,12,49,1007,9,49,1,49,3,49,1010,8,49,1,49,1,49,1,50,1,50,1,50,1,50,1,
		50,3,50,1019,8,50,1,51,1,51,1,51,3,51,1024,8,51,3,51,1026,8,51,1,51,1,
		51,1,52,1,52,1,52,5,52,1033,8,52,10,52,12,52,1036,9,52,1,53,1,53,1,53,
		1,53,1,53,3,53,1043,8,53,1,54,1,54,3,54,1047,8,54,1,54,1,54,1,54,3,54,
		1052,8,54,3,54,1054,8,54,1,54,1,54,1,54,3,54,1059,8,54,5,54,1061,8,54,
		10,54,12,54,1064,9,54,1,55,1,55,5,55,1068,8,55,10,55,12,55,1071,9,55,1,
		55,1,55,1,56,1,56,1,56,5,56,1078,8,56,10,56,12,56,1081,9,56,1,56,3,56,
		1084,8,56,1,56,3,56,1087,8,56,1,56,3,56,1090,8,56,1,57,1,57,1,57,1,57,
		5,57,1096,8,57,10,57,12,57,1099,9,57,1,57,1,57,1,58,1,58,1,58,1,58,1,59,
		3,59,1108,8,59,1,59,1,59,1,59,1,59,1,60,1,60,1,60,1,60,1,60,1,60,1,60,
		1,60,1,60,1,60,1,60,3,60,1125,8,60,1,61,1,61,1,61,5,61,1130,8,61,10,61,
		12,61,1133,9,61,1,62,3,62,1136,8,62,1,62,1,62,1,62,1,63,1,63,1,63,5,63,
		1144,8,63,10,63,12,63,1147,9,63,1,64,1,64,3,64,1151,8,64,1,65,1,65,1,65,
		1,66,1,66,3,66,1158,8,66,1,66,1,66,1,66,1,66,1,67,5,67,1165,8,67,10,67,
		12,67,1168,9,67,1,67,1,67,3,67,1172,8,67,1,68,1,68,1,68,1,68,1,68,3,68,
		1179,8,68,1,69,1,69,1,69,1,69,1,69,1,70,1,70,1,70,1,71,1,71,3,71,1191,
		8,71,1,71,1,71,1,71,1,71,1,71,1,71,1,71,1,71,1,71,3,71,1202,8,71,1,72,
		1,72,1,72,1,72,5,72,1208,8,72,10,72,12,72,1211,9,72,1,73,1,73,3,73,1215,
		8,73,1,74,1,74,1,74,1,74,1,74,1,74,1,74,3,74,1224,8,74,1,75,1,75,1,75,
		1,75,1,76,1,76,1,76,3,76,1233,8,76,1,77,1,77,1,77,1,77,1,77,1,77,1,77,
		3,77,1242,8,77,1,78,1,78,1,78,1,79,3,79,1248,8,79,1,79,1,79,1,79,3,79,
		1253,8,79,1,79,1,79,3,79,1257,8,79,1,79,1,79,3,79,1261,8,79,1,80,1,80,
		3,80,1265,8,80,1,80,1,80,3,80,1269,8,80,1,81,1,81,1,81,1,81,1,81,3,81,
		1276,8,81,1,82,1,82,1,82,1,82,1,83,1,83,3,83,1284,8,83,1,84,1,84,1,84,
		1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,3,84,1297,8,84,1,84,1,84,1,84,
		1,84,1,84,1,84,5,84,1305,8,84,10,84,12,84,1308,9,84,1,84,1,84,1,84,1,84,
		1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,
		1,84,3,84,1329,8,84,1,84,1,84,3,84,1333,8,84,1,84,1,84,3,84,1337,8,84,
		1,84,1,84,1,84,3,84,1342,8,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,
		1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,3,84,1362,8,84,1,84,
		1,84,1,84,3,84,1367,8,84,1,84,1,84,1,84,3,84,1372,8,84,1,84,1,84,1,84,
		1,84,1,84,3,84,1379,8,84,1,84,3,84,1382,8,84,1,84,1,84,1,84,1,84,1,84,
		1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,
		1,84,3,84,1404,8,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,1,84,
		3,84,1416,8,84,1,85,1,85,3,85,1420,8,85,1,85,1,85,1,86,1,86,1,86,1,86,
		3,86,1428,8,86,1,86,1,86,1,86,1,86,1,86,1,86,5,86,1436,8,86,10,86,12,86,
		1439,9,86,1,86,1,86,1,86,1,86,3,86,1445,8,86,1,87,1,87,3,87,1449,8,87,
		1,88,1,88,1,88,3,88,1454,8,88,1,88,3,88,1457,8,88,1,89,1,89,1,89,3,89,
		1462,8,89,1,90,1,90,1,90,1,90,1,91,1,91,3,91,1470,8,91,1,92,4,92,1473,
		8,92,11,92,12,92,1474,1,92,1,92,1,93,1,93,1,93,3,93,1482,8,93,1,93,1,93,
		1,93,1,93,3,93,1488,8,93,1,94,1,94,1,94,1,95,4,95,1494,8,95,11,95,12,95,
		1495,1,96,1,96,1,96,1,96,5,96,1502,8,96,10,96,12,96,1505,9,96,3,96,1507,
		8,96,1,97,1,97,1,97,5,97,1512,8,97,10,97,12,97,1515,9,97,1,98,1,98,5,98,
		1519,8,98,10,98,12,98,1522,9,98,1,98,3,98,1525,8,98,1,98,3,98,1528,8,98,
		1,99,1,99,1,99,1,99,3,99,1534,8,99,1,99,1,99,3,99,1538,8,99,1,99,1,99,
		1,100,1,100,3,100,1544,8,100,1,100,1,100,1,101,1,101,1,101,1,101,1,101,
		1,102,1,102,1,102,1,103,1,103,3,103,1558,8,103,1,104,1,104,1,104,1,104,
		3,104,1564,8,104,1,105,1,105,1,105,5,105,1569,8,105,10,105,12,105,1572,
		9,105,1,106,1,106,3,106,1576,8,106,1,106,3,106,1579,8,106,1,106,3,106,
		1582,8,106,1,106,1,106,1,107,4,107,1587,8,107,11,107,12,107,1588,1,108,
		1,108,1,108,1,108,1,108,1,109,4,109,1597,8,109,11,109,12,109,1598,1,110,
		1,110,1,110,1,110,1,110,1,110,1,110,1,110,1,110,1,110,1,110,1,110,1,110,
		1,110,1,110,3,110,1616,8,110,1,111,4,111,1619,8,111,11,111,12,111,1620,
		1,112,1,112,3,112,1625,8,112,1,113,3,113,1628,8,113,1,113,3,113,1631,8,
		113,1,113,1,113,1,113,1,113,1,113,3,113,1638,8,113,1,114,1,114,1,114,1,
		114,3,114,1644,8,114,1,115,1,115,1,115,1,115,5,115,1650,8,115,10,115,12,
		115,1653,9,115,1,115,1,115,1,116,3,116,1658,8,116,1,116,1,116,1,117,1,
		117,1,117,1,117,5,117,1666,8,117,10,117,12,117,1669,9,117,1,118,1,118,
		1,118,5,118,1674,8,118,10,118,12,118,1677,9,118,1,119,4,119,1680,8,119,
		11,119,12,119,1681,1,120,1,120,1,120,1,120,1,120,1,121,1,121,1,121,1,121,
		3,121,1693,8,121,1,121,1,121,3,121,1697,8,121,3,121,1699,8,121,1,122,1,
		122,1,122,3,122,1704,8,122,1,122,1,122,3,122,1708,8,122,1,123,1,123,1,
		123,5,123,1713,8,123,10,123,12,123,1716,9,123,1,124,1,124,1,124,1,124,
		1,125,1,125,3,125,1724,8,125,1,125,1,125,1,126,4,126,1729,8,126,11,126,
		12,126,1730,1,127,3,127,1734,8,127,1,127,3,127,1737,8,127,1,127,1,127,
		3,127,1741,8,127,1,128,4,128,1744,8,128,11,128,12,128,1745,1,129,1,129,
		1,130,1,130,1,130,1,130,1,130,1,130,1,130,1,130,1,130,3,130,1759,8,130,
		1,130,1,130,1,130,1,130,1,130,1,130,1,130,1,130,3,130,1769,8,130,1,131,
		1,131,1,131,1,131,1,131,3,131,1776,8,131,1,131,1,131,1,131,1,131,1,131,
		1,131,1,131,1,131,1,131,1,131,3,131,1788,8,131,1,132,1,132,1,132,5,132,
		1793,8,132,10,132,12,132,1796,9,132,1,133,1,133,1,133,1,133,1,134,1,134,
		1,134,5,134,1805,8,134,10,134,12,134,1808,9,134,1,135,1,135,1,135,3,135,
		1813,8,135,1,136,1,136,3,136,1817,8,136,1,137,1,137,3,137,1821,8,137,1,
		138,1,138,1,139,1,139,3,139,1827,8,139,1,140,1,140,1,140,1,140,3,140,1833,
		8,140,3,140,1835,8,140,1,141,1,141,1,141,5,141,1840,8,141,10,141,12,141,
		1843,9,141,1,142,3,142,1846,8,142,1,142,3,142,1849,8,142,1,142,1,142,3,
		142,1853,8,142,1,143,1,143,1,143,1,143,1,143,1,143,1,143,1,143,3,143,1863,
		8,143,1,144,3,144,1866,8,144,1,144,1,144,1,144,1,144,1,145,3,145,1873,
		8,145,1,145,3,145,1876,8,145,1,145,1,145,1,145,3,145,1881,8,145,1,145,
		1,145,1,145,3,145,1886,8,145,3,145,1888,8,145,1,146,3,146,1891,8,146,1,
		146,3,146,1894,8,146,1,146,1,146,1,146,1,147,3,147,1900,8,147,1,147,3,
		147,1903,8,147,1,147,1,147,1,147,1,148,1,148,1,148,1,148,1,148,1,148,1,
		148,3,148,1915,8,148,1,149,1,149,3,149,1919,8,149,1,150,3,150,1922,8,150,
		1,150,1,150,1,150,1,150,1,150,1,150,1,150,1,150,3,150,1932,8,150,1,151,
		3,151,1935,8,151,1,151,1,151,1,151,1,152,3,152,1941,8,152,1,152,1,152,
		1,152,1,153,1,153,1,153,1,153,1,153,1,153,1,153,1,153,1,153,1,153,1,153,
		1,153,1,153,1,153,1,153,1,153,1,153,1,153,1,153,1,153,1,153,1,153,3,153,
		1968,8,153,1,154,1,154,1,154,1,154,1,154,1,154,1,154,1,155,1,155,1,155,
		1,155,3,155,1981,8,155,1,155,1,155,1,156,1,156,3,156,1987,8,156,1,157,
		1,157,1,157,1,158,1,158,5,158,1994,8,158,10,158,12,158,1997,9,158,1,158,
		1,158,1,159,3,159,2002,8,159,1,159,3,159,2005,8,159,1,159,1,159,1,159,
		1,159,4,159,2011,8,159,11,159,12,159,2012,1,159,1,159,3,159,2017,8,159,
		1,160,1,160,5,160,2021,8,160,10,160,12,160,2024,9,160,1,160,4,160,2027,
		8,160,11,160,12,160,2028,1,161,1,161,5,161,2033,8,161,10,161,12,161,2036,
		9,161,1,161,1,161,1,162,1,162,1,162,1,162,5,162,2044,8,162,10,162,12,162,
		2047,9,162,1,162,3,162,2050,8,162,3,162,2052,8,162,1,162,1,162,1,163,1,
		163,1,163,1,163,5,163,2060,8,163,10,163,12,163,2063,9,163,1,163,1,163,
		1,164,3,164,2068,8,164,1,164,3,164,2071,8,164,1,164,1,164,1,165,1,165,
		1,166,1,166,1,166,1,167,1,167,5,167,2082,8,167,10,167,12,167,2085,9,167,
		1,167,1,167,1,168,3,168,2090,8,168,1,168,3,168,2093,8,168,1,168,3,168,
		2096,8,168,1,168,1,168,1,168,1,168,1,168,3,168,2103,8,168,1,168,1,168,
		1,168,3,168,2108,8,168,1,168,1,168,3,168,2112,8,168,1,168,1,168,3,168,
		2116,8,168,1,168,1,168,1,168,1,168,1,168,1,168,1,168,1,168,1,168,1,168,
		1,168,1,168,1,168,1,168,1,168,3,168,2133,8,168,1,168,3,168,2136,8,168,
		1,168,1,168,1,168,3,168,2141,8,168,1,168,1,168,3,168,2145,8,168,1,168,
		1,168,3,168,2149,8,168,1,168,1,168,1,168,1,168,1,168,1,168,1,168,3,168,
		2158,8,168,1,169,3,169,2161,8,169,1,169,1,169,1,169,3,169,2166,8,169,1,
		169,1,169,3,169,2170,8,169,1,169,1,169,1,169,3,169,2175,8,169,1,169,1,
		169,3,169,2179,8,169,3,169,2181,8,169,1,170,1,170,1,170,1,171,1,171,1,
		171,1,171,5,171,2190,8,171,10,171,12,171,2193,9,171,1,171,3,171,2196,8,
		171,3,171,2198,8,171,1,171,1,171,1,172,3,172,2203,8,172,1,172,1,172,1,
		172,3,172,2208,8,172,1,173,1,173,1,173,1,173,1,173,3,173,2215,8,173,1,
		173,1,173,1,174,1,174,3,174,2221,8,174,1,175,4,175,2224,8,175,11,175,12,
		175,2225,1,176,1,176,1,176,1,176,3,176,2232,8,176,1,176,1,176,3,176,2236,
		8,176,1,176,1,176,1,177,1,177,3,177,2242,8,177,1,178,1,178,1,178,5,178,
		2247,8,178,10,178,12,178,2250,9,178,1,179,1,179,1,179,1,179,1,179,5,179,
		2257,8,179,10,179,12,179,2260,9,179,3,179,2262,8,179,1,179,3,179,2265,
		8,179,1,180,1,180,1,180,3,180,2270,8,180,1,180,1,180,1,181,1,181,3,181,
		2276,8,181,1,181,1,181,5,181,2280,8,181,10,181,12,181,2283,9,181,1,181,
		1,181,1,181,1,181,3,181,2289,8,181,1,182,1,182,1,182,5,182,2294,8,182,
		10,182,12,182,2297,9,182,1,183,1,183,1,183,1,183,1,184,3,184,2304,8,184,
		1,184,1,184,3,184,2308,8,184,1,185,1,185,1,185,1,185,1,185,1,186,1,186,
		1,186,1,186,1,186,1,186,1,186,1,186,3,186,2323,8,186,1,186,1,186,3,186,
		2327,8,186,1,186,1,186,1,186,1,186,1,186,5,186,2334,8,186,10,186,12,186,
		2337,9,186,1,186,3,186,2340,8,186,1,186,1,186,3,186,2344,8,186,1,187,1,
		187,1,187,1,187,1,188,1,188,1,188,1,188,1,189,1,189,1,189,1,189,1,190,
		1,190,1,190,1,190,1,190,1,190,1,190,1,190,3,190,2366,8,190,1,191,1,191,
		1,192,1,192,1,192,1,192,3,192,2374,8,192,1,193,1,193,5,193,2378,8,193,
		10,193,12,193,2381,9,193,1,193,1,193,1,194,1,194,5,194,2387,8,194,10,194,
		12,194,2390,9,194,1,194,1,194,1,195,1,195,1,195,1,195,3,195,2398,8,195,
		1,196,1,196,1,196,1,196,3,196,2404,8,196,1,197,1,197,1,197,5,197,2409,
		8,197,10,197,12,197,2412,9,197,1,197,1,197,4,197,2416,8,197,11,197,12,
		197,2417,3,197,2420,8,197,1,198,1,198,1,199,1,199,1,199,3,199,2427,8,199,
		1,199,3,199,2430,8,199,1,199,3,199,2433,8,199,1,199,1,199,3,199,2437,8,
		199,1,200,3,200,2440,8,200,1,200,1,200,1,200,3,200,2445,8,200,1,200,3,
		200,2448,8,200,1,200,3,200,2451,8,200,1,200,1,200,3,200,2455,8,200,1,201,
		1,201,1,201,3,201,2460,8,201,1,201,3,201,2463,8,201,1,201,3,201,2466,8,
		201,1,201,1,201,3,201,2470,8,201,1,202,1,202,1,202,3,202,2475,8,202,1,
		202,1,202,3,202,2479,8,202,1,203,1,203,1,203,1,203,3,203,2485,8,203,1,
		203,1,203,3,203,2489,8,203,1,203,1,203,3,203,2493,8,203,1,203,1,203,1,
		204,1,204,1,204,1,204,1,204,1,204,1,204,1,204,1,204,1,204,3,204,2507,8,
		204,1,205,1,205,1,205,1,206,1,206,1,206,1,206,1,206,1,206,1,206,1,206,
		3,206,2520,8,206,1,206,1,206,1,206,1,206,3,206,2526,8,206,1,207,1,207,
		1,207,1,207,1,207,1,208,1,208,1,208,1,208,1,208,1,208,1,208,1,208,1,208,
		1,208,1,208,1,208,3,208,2545,8,208,1,209,1,209,1,209,1,209,1,209,1,209,
		1,210,1,210,1,210,3,210,2556,8,210,1,210,1,210,3,210,2560,8,210,1,210,
		1,210,1,211,1,211,3,211,2566,8,211,1,211,1,211,3,211,2570,8,211,1,211,
		1,211,3,211,2574,8,211,1,211,1,211,1,211,1,211,1,211,3,211,2581,8,211,
		1,212,1,212,1,212,1,212,1,212,3,212,2588,8,212,1,212,3,212,2591,8,212,
		1,212,1,212,5,212,2595,8,212,10,212,12,212,2598,9,212,1,213,1,213,1,213,
		1,213,3,213,2604,8,213,1,213,1,213,1,213,3,213,2609,8,213,1,213,3,213,
		2612,8,213,1,213,1,213,1,213,1,213,1,213,1,213,3,213,2620,8,213,1,214,
		1,214,1,214,1,214,3,214,2626,8,214,1,215,1,215,3,215,2630,8,215,1,215,
		1,215,1,216,1,216,3,216,2636,8,216,1,216,1,216,3,216,2640,8,216,1,217,
		1,217,1,217,0,0,218,0,2,4,6,8,10,12,14,16,18,20,22,24,26,28,30,32,34,36,
		38,40,42,44,46,48,50,52,54,56,58,60,62,64,66,68,70,72,74,76,78,80,82,84,
		86,88,90,92,94,96,98,100,102,104,106,108,110,112,114,116,118,120,122,124,
		126,128,130,132,134,136,138,140,142,144,146,148,150,152,154,156,158,160,
		162,164,166,168,170,172,174,176,178,180,182,184,186,188,190,192,194,196,
		198,200,202,204,206,208,210,212,214,216,218,220,222,224,226,228,230,232,
		234,236,238,240,242,244,246,248,250,252,254,256,258,260,262,264,266,268,
		270,272,274,276,278,280,282,284,286,288,290,292,294,296,298,300,302,304,
		306,308,310,312,314,316,318,320,322,324,326,328,330,332,334,336,338,340,
		342,344,346,348,350,352,354,356,358,360,362,364,366,368,370,372,374,376,
		378,380,382,384,386,388,390,392,394,396,398,400,402,404,406,408,410,412,
		414,416,418,420,422,424,426,428,430,432,434,0,19,8,0,21,21,24,24,55,55,
		63,63,83,83,87,87,99,100,104,104,2,0,34,34,45,45,3,0,54,54,72,72,80,80,
		1,0,156,157,2,0,146,147,158,159,1,0,135,136,1,0,137,139,14,0,18,18,21,
		21,24,24,29,29,34,34,45,45,55,55,63,63,68,68,83,83,87,87,91,91,99,100,
		104,104,2,0,14,14,32,32,2,0,15,15,103,103,12,0,9,9,15,15,41,41,57,57,66,
		66,73,73,75,79,84,84,90,90,103,103,107,107,109,109,2,0,40,40,53,53,2,0,
		17,17,94,94,2,0,137,137,148,148,2,0,54,54,72,72,2,0,42,42,96,96,19,0,9,
		9,13,13,17,19,21,31,33,34,36,37,39,47,50,50,52,57,59,59,62,63,65,68,70,
		70,72,74,76,80,82,84,87,105,107,109,112,112,1,0,79,80,20,0,10,12,14,16,
		20,20,32,32,35,35,38,38,48,49,51,51,58,58,60,61,64,64,69,69,71,71,75,75,
		81,81,85,86,102,102,106,106,110,111,113,114,2914,0,437,1,0,0,0,2,461,1,
		0,0,0,4,473,1,0,0,0,6,487,1,0,0,0,8,489,1,0,0,0,10,499,1,0,0,0,12,505,
		1,0,0,0,14,510,1,0,0,0,16,512,1,0,0,0,18,514,1,0,0,0,20,520,1,0,0,0,22,
		522,1,0,0,0,24,533,1,0,0,0,26,544,1,0,0,0,28,559,1,0,0,0,30,564,1,0,0,
		0,32,574,1,0,0,0,34,587,1,0,0,0,36,589,1,0,0,0,38,597,1,0,0,0,40,605,1,
		0,0,0,42,613,1,0,0,0,44,621,1,0,0,0,46,629,1,0,0,0,48,637,1,0,0,0,50,645,
		1,0,0,0,52,653,1,0,0,0,54,665,1,0,0,0,56,676,1,0,0,0,58,684,1,0,0,0,60,
		692,1,0,0,0,62,704,1,0,0,0,64,712,1,0,0,0,66,727,1,0,0,0,68,755,1,0,0,
		0,70,757,1,0,0,0,72,916,1,0,0,0,74,920,1,0,0,0,76,922,1,0,0,0,78,926,1,
		0,0,0,80,934,1,0,0,0,82,950,1,0,0,0,84,954,1,0,0,0,86,956,1,0,0,0,88,966,
		1,0,0,0,90,968,1,0,0,0,92,977,1,0,0,0,94,990,1,0,0,0,96,997,1,0,0,0,98,
		999,1,0,0,0,100,1018,1,0,0,0,102,1020,1,0,0,0,104,1029,1,0,0,0,106,1042,
		1,0,0,0,108,1044,1,0,0,0,110,1065,1,0,0,0,112,1074,1,0,0,0,114,1091,1,
		0,0,0,116,1102,1,0,0,0,118,1107,1,0,0,0,120,1124,1,0,0,0,122,1126,1,0,
		0,0,124,1135,1,0,0,0,126,1140,1,0,0,0,128,1150,1,0,0,0,130,1152,1,0,0,
		0,132,1155,1,0,0,0,134,1166,1,0,0,0,136,1178,1,0,0,0,138,1180,1,0,0,0,
		140,1185,1,0,0,0,142,1188,1,0,0,0,144,1203,1,0,0,0,146,1212,1,0,0,0,148,
		1223,1,0,0,0,150,1225,1,0,0,0,152,1232,1,0,0,0,154,1241,1,0,0,0,156,1243,
		1,0,0,0,158,1247,1,0,0,0,160,1268,1,0,0,0,162,1275,1,0,0,0,164,1277,1,
		0,0,0,166,1283,1,0,0,0,168,1415,1,0,0,0,170,1417,1,0,0,0,172,1444,1,0,
		0,0,174,1448,1,0,0,0,176,1450,1,0,0,0,178,1461,1,0,0,0,180,1463,1,0,0,
		0,182,1469,1,0,0,0,184,1472,1,0,0,0,186,1487,1,0,0,0,188,1489,1,0,0,0,
		190,1493,1,0,0,0,192,1506,1,0,0,0,194,1508,1,0,0,0,196,1527,1,0,0,0,198,
		1529,1,0,0,0,200,1541,1,0,0,0,202,1547,1,0,0,0,204,1552,1,0,0,0,206,1557,
		1,0,0,0,208,1559,1,0,0,0,210,1565,1,0,0,0,212,1573,1,0,0,0,214,1586,1,
		0,0,0,216,1590,1,0,0,0,218,1596,1,0,0,0,220,1615,1,0,0,0,222,1618,1,0,
		0,0,224,1624,1,0,0,0,226,1627,1,0,0,0,228,1639,1,0,0,0,230,1645,1,0,0,
		0,232,1657,1,0,0,0,234,1661,1,0,0,0,236,1670,1,0,0,0,238,1679,1,0,0,0,
		240,1683,1,0,0,0,242,1698,1,0,0,0,244,1707,1,0,0,0,246,1709,1,0,0,0,248,
		1717,1,0,0,0,250,1721,1,0,0,0,252,1728,1,0,0,0,254,1733,1,0,0,0,256,1743,
		1,0,0,0,258,1747,1,0,0,0,260,1768,1,0,0,0,262,1775,1,0,0,0,264,1789,1,
		0,0,0,266,1797,1,0,0,0,268,1801,1,0,0,0,270,1809,1,0,0,0,272,1816,1,0,
		0,0,274,1820,1,0,0,0,276,1822,1,0,0,0,278,1826,1,0,0,0,280,1834,1,0,0,
		0,282,1836,1,0,0,0,284,1852,1,0,0,0,286,1862,1,0,0,0,288,1865,1,0,0,0,
		290,1872,1,0,0,0,292,1890,1,0,0,0,294,1899,1,0,0,0,296,1914,1,0,0,0,298,
		1918,1,0,0,0,300,1921,1,0,0,0,302,1934,1,0,0,0,304,1940,1,0,0,0,306,1967,
		1,0,0,0,308,1969,1,0,0,0,310,1976,1,0,0,0,312,1986,1,0,0,0,314,1988,1,
		0,0,0,316,1991,1,0,0,0,318,2001,1,0,0,0,320,2018,1,0,0,0,322,2030,1,0,
		0,0,324,2039,1,0,0,0,326,2055,1,0,0,0,328,2067,1,0,0,0,330,2074,1,0,0,
		0,332,2076,1,0,0,0,334,2079,1,0,0,0,336,2089,1,0,0,0,338,2160,1,0,0,0,
		340,2182,1,0,0,0,342,2185,1,0,0,0,344,2202,1,0,0,0,346,2209,1,0,0,0,348,
		2220,1,0,0,0,350,2223,1,0,0,0,352,2227,1,0,0,0,354,2241,1,0,0,0,356,2243,
		1,0,0,0,358,2251,1,0,0,0,360,2269,1,0,0,0,362,2288,1,0,0,0,364,2290,1,
		0,0,0,366,2298,1,0,0,0,368,2307,1,0,0,0,370,2309,1,0,0,0,372,2343,1,0,
		0,0,374,2345,1,0,0,0,376,2349,1,0,0,0,378,2353,1,0,0,0,380,2365,1,0,0,
		0,382,2367,1,0,0,0,384,2373,1,0,0,0,386,2375,1,0,0,0,388,2384,1,0,0,0,
		390,2397,1,0,0,0,392,2403,1,0,0,0,394,2405,1,0,0,0,396,2421,1,0,0,0,398,
		2423,1,0,0,0,400,2439,1,0,0,0,402,2456,1,0,0,0,404,2471,1,0,0,0,406,2480,
		1,0,0,0,408,2496,1,0,0,0,410,2508,1,0,0,0,412,2511,1,0,0,0,414,2527,1,
		0,0,0,416,2532,1,0,0,0,418,2546,1,0,0,0,420,2552,1,0,0,0,422,2563,1,0,
		0,0,424,2587,1,0,0,0,426,2599,1,0,0,0,428,2621,1,0,0,0,430,2627,1,0,0,
		0,432,2633,1,0,0,0,434,2641,1,0,0,0,436,438,5,1,0,0,437,436,1,0,0,0,437,
		438,1,0,0,0,438,440,1,0,0,0,439,441,3,214,107,0,440,439,1,0,0,0,440,441,
		1,0,0,0,441,443,1,0,0,0,442,444,3,218,109,0,443,442,1,0,0,0,443,444,1,
		0,0,0,444,448,1,0,0,0,445,447,3,346,173,0,446,445,1,0,0,0,447,450,1,0,
		0,0,448,446,1,0,0,0,448,449,1,0,0,0,449,452,1,0,0,0,450,448,1,0,0,0,451,
		453,3,222,111,0,452,451,1,0,0,0,452,453,1,0,0,0,453,454,1,0,0,0,454,455,
		5,0,0,1,455,1,1,0,0,0,456,458,3,434,217,0,457,459,3,22,11,0,458,457,1,
		0,0,0,458,459,1,0,0,0,459,462,1,0,0,0,460,462,3,228,114,0,461,456,1,0,
		0,0,461,460,1,0,0,0,462,470,1,0,0,0,463,464,5,131,0,0,464,466,3,434,217,
		0,465,467,3,22,11,0,466,465,1,0,0,0,466,467,1,0,0,0,467,469,1,0,0,0,468,
		463,1,0,0,0,469,472,1,0,0,0,470,468,1,0,0,0,470,471,1,0,0,0,471,3,1,0,
		0,0,472,470,1,0,0,0,473,479,3,6,3,0,474,478,5,148,0,0,475,478,3,322,161,
		0,476,478,5,137,0,0,477,474,1,0,0,0,477,475,1,0,0,0,477,476,1,0,0,0,478,
		481,1,0,0,0,479,477,1,0,0,0,479,480,1,0,0,0,480,5,1,0,0,0,481,479,1,0,
		0,0,482,488,3,12,6,0,483,488,3,20,10,0,484,485,5,108,0,0,485,488,5,137,
		0,0,486,488,3,8,4,0,487,482,1,0,0,0,487,483,1,0,0,0,487,484,1,0,0,0,487,
		486,1,0,0,0,488,7,1,0,0,0,489,490,5,129,0,0,490,493,3,10,5,0,491,492,5,
		132,0,0,492,494,3,10,5,0,493,491,1,0,0,0,494,495,1,0,0,0,495,493,1,0,0,
		0,495,496,1,0,0,0,496,497,1,0,0,0,497,498,5,130,0,0,498,9,1,0,0,0,499,
		501,3,4,2,0,500,502,3,434,217,0,501,500,1,0,0,0,501,502,1,0,0,0,502,11,
		1,0,0,0,503,506,3,14,7,0,504,506,5,18,0,0,505,503,1,0,0,0,505,504,1,0,
		0,0,506,13,1,0,0,0,507,511,3,16,8,0,508,511,3,18,9,0,509,511,5,29,0,0,
		510,507,1,0,0,0,510,508,1,0,0,0,510,509,1,0,0,0,511,15,1,0,0,0,512,513,
		7,0,0,0,513,17,1,0,0,0,514,515,7,1,0,0,515,19,1,0,0,0,516,521,3,2,1,0,
		517,521,5,68,0,0,518,521,5,35,0,0,519,521,5,91,0,0,520,516,1,0,0,0,520,
		517,1,0,0,0,520,518,1,0,0,0,520,519,1,0,0,0,521,21,1,0,0,0,522,523,5,146,
		0,0,523,528,3,4,2,0,524,525,5,132,0,0,525,527,3,4,2,0,526,524,1,0,0,0,
		527,530,1,0,0,0,528,526,1,0,0,0,528,529,1,0,0,0,529,531,1,0,0,0,530,528,
		1,0,0,0,531,532,5,147,0,0,532,23,1,0,0,0,533,538,3,26,13,0,534,535,5,132,
		0,0,535,537,3,26,13,0,536,534,1,0,0,0,537,540,1,0,0,0,538,536,1,0,0,0,
		538,539,1,0,0,0,539,25,1,0,0,0,540,538,1,0,0,0,541,542,3,434,217,0,542,
		543,5,133,0,0,543,545,1,0,0,0,544,541,1,0,0,0,544,545,1,0,0,0,545,547,
		1,0,0,0,546,548,7,2,0,0,547,546,1,0,0,0,547,548,1,0,0,0,548,551,1,0,0,
		0,549,552,5,106,0,0,550,552,3,4,2,0,551,549,1,0,0,0,551,550,1,0,0,0,551,
		552,1,0,0,0,552,553,1,0,0,0,553,554,3,28,14,0,554,27,1,0,0,0,555,560,3,
		32,16,0,556,560,3,30,15,0,557,558,5,80,0,0,558,560,3,30,15,0,559,555,1,
		0,0,0,559,556,1,0,0,0,559,557,1,0,0,0,560,29,1,0,0,0,561,565,3,118,59,
		0,562,565,3,130,65,0,563,565,3,36,18,0,564,561,1,0,0,0,564,562,1,0,0,0,
		564,563,1,0,0,0,565,31,1,0,0,0,566,567,3,68,34,0,567,568,3,34,17,0,568,
		569,3,28,14,0,569,575,1,0,0,0,570,571,3,68,34,0,571,572,5,170,0,0,572,
		573,3,74,37,0,573,575,1,0,0,0,574,566,1,0,0,0,574,570,1,0,0,0,575,33,1,
		0,0,0,576,588,5,145,0,0,577,588,5,160,0,0,578,588,5,161,0,0,579,588,5,
		162,0,0,580,588,5,163,0,0,581,588,5,164,0,0,582,588,5,165,0,0,583,588,
		5,166,0,0,584,588,5,167,0,0,585,588,5,169,0,0,586,588,3,378,189,0,587,
		576,1,0,0,0,587,577,1,0,0,0,587,578,1,0,0,0,587,579,1,0,0,0,587,580,1,
		0,0,0,587,581,1,0,0,0,587,582,1,0,0,0,587,583,1,0,0,0,587,584,1,0,0,0,
		587,585,1,0,0,0,587,586,1,0,0,0,588,35,1,0,0,0,589,595,3,38,19,0,590,591,
		5,148,0,0,591,592,3,74,37,0,592,593,5,133,0,0,593,594,3,74,37,0,594,596,
		1,0,0,0,595,590,1,0,0,0,595,596,1,0,0,0,596,37,1,0,0,0,597,603,3,40,20,
		0,598,601,5,150,0,0,599,602,3,38,19,0,600,602,3,76,38,0,601,599,1,0,0,
		0,601,600,1,0,0,0,602,604,1,0,0,0,603,598,1,0,0,0,603,604,1,0,0,0,604,
		39,1,0,0,0,605,610,3,42,21,0,606,607,5,154,0,0,607,609,3,42,21,0,608,606,
		1,0,0,0,609,612,1,0,0,0,610,608,1,0,0,0,610,611,1,0,0,0,611,41,1,0,0,0,
		612,610,1,0,0,0,613,618,3,44,22,0,614,615,5,153,0,0,615,617,3,44,22,0,
		616,614,1,0,0,0,617,620,1,0,0,0,618,616,1,0,0,0,618,619,1,0,0,0,619,43,
		1,0,0,0,620,618,1,0,0,0,621,626,3,46,23,0,622,623,5,141,0,0,623,625,3,
		46,23,0,624,622,1,0,0,0,625,628,1,0,0,0,626,624,1,0,0,0,626,627,1,0,0,
		0,627,45,1,0,0,0,628,626,1,0,0,0,629,634,3,48,24,0,630,631,5,142,0,0,631,
		633,3,48,24,0,632,630,1,0,0,0,633,636,1,0,0,0,634,632,1,0,0,0,634,635,
		1,0,0,0,635,47,1,0,0,0,636,634,1,0,0,0,637,642,3,50,25,0,638,639,5,140,
		0,0,639,641,3,50,25,0,640,638,1,0,0,0,641,644,1,0,0,0,642,640,1,0,0,0,
		642,643,1,0,0,0,643,49,1,0,0,0,644,642,1,0,0,0,645,650,3,52,26,0,646,647,
		7,3,0,0,647,649,3,52,26,0,648,646,1,0,0,0,649,652,1,0,0,0,650,648,1,0,
		0,0,650,651,1,0,0,0,651,51,1,0,0,0,652,650,1,0,0,0,653,662,3,54,27,0,654,
		655,7,4,0,0,655,661,3,54,27,0,656,657,5,59,0,0,657,661,3,112,56,0,658,
		659,5,13,0,0,659,661,3,4,2,0,660,654,1,0,0,0,660,656,1,0,0,0,660,658,1,
		0,0,0,661,664,1,0,0,0,662,660,1,0,0,0,662,663,1,0,0,0,663,53,1,0,0,0,664,
		662,1,0,0,0,665,673,3,56,28,0,666,669,5,168,0,0,667,669,3,376,188,0,668,
		666,1,0,0,0,668,667,1,0,0,0,669,670,1,0,0,0,670,672,3,56,28,0,671,668,
		1,0,0,0,672,675,1,0,0,0,673,671,1,0,0,0,673,674,1,0,0,0,674,55,1,0,0,0,
		675,673,1,0,0,0,676,681,3,58,29,0,677,678,7,5,0,0,678,680,3,58,29,0,679,
		677,1,0,0,0,680,683,1,0,0,0,681,679,1,0,0,0,681,682,1,0,0,0,682,57,1,0,
		0,0,683,681,1,0,0,0,684,689,3,60,30,0,685,686,7,6,0,0,686,688,3,60,30,
		0,687,685,1,0,0,0,688,691,1,0,0,0,689,687,1,0,0,0,689,690,1,0,0,0,690,
		59,1,0,0,0,691,689,1,0,0,0,692,702,3,66,33,0,693,694,5,93,0,0,694,699,
		5,125,0,0,695,697,3,62,31,0,696,698,5,132,0,0,697,696,1,0,0,0,697,698,
		1,0,0,0,698,700,1,0,0,0,699,695,1,0,0,0,699,700,1,0,0,0,700,701,1,0,0,
		0,701,703,5,126,0,0,702,693,1,0,0,0,702,703,1,0,0,0,703,61,1,0,0,0,704,
		709,3,64,32,0,705,706,5,132,0,0,706,708,3,64,32,0,707,705,1,0,0,0,708,
		711,1,0,0,0,709,707,1,0,0,0,709,710,1,0,0,0,710,63,1,0,0,0,711,709,1,0,
		0,0,712,714,3,28,14,0,713,715,3,188,94,0,714,713,1,0,0,0,714,715,1,0,0,
		0,715,716,1,0,0,0,716,717,3,374,187,0,717,718,3,74,37,0,718,65,1,0,0,0,
		719,728,3,68,34,0,720,722,3,68,34,0,721,720,1,0,0,0,721,722,1,0,0,0,722,
		723,1,0,0,0,723,725,5,171,0,0,724,726,3,68,34,0,725,724,1,0,0,0,725,726,
		1,0,0,0,726,728,1,0,0,0,727,719,1,0,0,0,727,721,1,0,0,0,728,67,1,0,0,0,
		729,756,3,70,35,0,730,731,5,135,0,0,731,756,3,68,34,0,732,733,5,136,0,
		0,733,756,3,68,34,0,734,735,5,143,0,0,735,756,3,68,34,0,736,737,5,144,
		0,0,737,756,3,68,34,0,738,739,5,151,0,0,739,756,3,68,34,0,740,741,5,152,
		0,0,741,756,3,68,34,0,742,743,5,129,0,0,743,744,3,4,2,0,744,745,5,130,
		0,0,745,746,3,68,34,0,746,756,1,0,0,0,747,748,5,16,0,0,748,756,3,68,34,
		0,749,750,5,140,0,0,750,756,3,68,34,0,751,752,5,137,0,0,752,756,3,68,34,
		0,753,754,5,142,0,0,754,756,3,68,34,0,755,729,1,0,0,0,755,730,1,0,0,0,
		755,732,1,0,0,0,755,734,1,0,0,0,755,736,1,0,0,0,755,738,1,0,0,0,755,740,
		1,0,0,0,755,742,1,0,0,0,755,747,1,0,0,0,755,749,1,0,0,0,755,751,1,0,0,
		0,755,753,1,0,0,0,756,69,1,0,0,0,757,759,3,72,36,0,758,760,5,143,0,0,759,
		758,1,0,0,0,759,760,1,0,0,0,760,764,1,0,0,0,761,763,3,80,40,0,762,761,
		1,0,0,0,763,766,1,0,0,0,764,762,1,0,0,0,764,765,1,0,0,0,765,768,1,0,0,
		0,766,764,1,0,0,0,767,769,5,143,0,0,768,767,1,0,0,0,768,769,1,0,0,0,769,
		792,1,0,0,0,770,777,3,78,39,0,771,777,3,430,215,0,772,777,5,151,0,0,773,
		777,5,152,0,0,774,775,5,155,0,0,775,777,3,434,217,0,776,770,1,0,0,0,776,
		771,1,0,0,0,776,772,1,0,0,0,776,773,1,0,0,0,776,774,1,0,0,0,777,779,1,
		0,0,0,778,780,5,143,0,0,779,778,1,0,0,0,779,780,1,0,0,0,780,784,1,0,0,
		0,781,783,3,80,40,0,782,781,1,0,0,0,783,786,1,0,0,0,784,782,1,0,0,0,784,
		785,1,0,0,0,785,788,1,0,0,0,786,784,1,0,0,0,787,789,5,143,0,0,788,787,
		1,0,0,0,788,789,1,0,0,0,789,791,1,0,0,0,790,776,1,0,0,0,791,794,1,0,0,
		0,792,790,1,0,0,0,792,793,1,0,0,0,793,71,1,0,0,0,794,792,1,0,0,0,795,917,
		3,380,190,0,796,798,3,434,217,0,797,799,3,22,11,0,798,797,1,0,0,0,798,
		799,1,0,0,0,799,917,1,0,0,0,800,801,5,129,0,0,801,802,3,28,14,0,802,803,
		5,130,0,0,803,917,1,0,0,0,804,917,3,84,42,0,805,917,3,228,114,0,806,917,
		5,115,0,0,807,917,5,94,0,0,808,818,5,17,0,0,809,810,5,131,0,0,810,812,
		3,434,217,0,811,813,3,22,11,0,812,811,1,0,0,0,812,813,1,0,0,0,813,819,
		1,0,0,0,814,815,5,127,0,0,815,816,3,86,43,0,816,817,5,128,0,0,817,819,
		1,0,0,0,818,809,1,0,0,0,818,814,1,0,0,0,819,917,1,0,0,0,820,849,5,66,0,
		0,821,843,3,4,2,0,822,844,3,432,216,0,823,844,3,88,44,0,824,825,5,127,
		0,0,825,826,3,86,43,0,826,830,5,128,0,0,827,829,3,322,161,0,828,827,1,
		0,0,0,829,832,1,0,0,0,830,828,1,0,0,0,830,831,1,0,0,0,831,834,1,0,0,0,
		832,830,1,0,0,0,833,835,3,324,162,0,834,833,1,0,0,0,834,835,1,0,0,0,835,
		844,1,0,0,0,836,838,3,322,161,0,837,836,1,0,0,0,838,839,1,0,0,0,839,837,
		1,0,0,0,839,840,1,0,0,0,840,841,1,0,0,0,841,842,3,324,162,0,842,844,1,
		0,0,0,843,822,1,0,0,0,843,823,1,0,0,0,843,824,1,0,0,0,843,837,1,0,0,0,
		844,850,1,0,0,0,845,850,3,102,51,0,846,847,3,322,161,0,847,848,3,324,162,
		0,848,850,1,0,0,0,849,821,1,0,0,0,849,845,1,0,0,0,849,846,1,0,0,0,850,
		917,1,0,0,0,851,852,5,129,0,0,852,855,3,26,13,0,853,854,5,132,0,0,854,
		856,3,26,13,0,855,853,1,0,0,0,856,857,1,0,0,0,857,855,1,0,0,0,857,858,
		1,0,0,0,858,859,1,0,0,0,859,860,5,130,0,0,860,917,1,0,0,0,861,862,5,98,
		0,0,862,866,5,129,0,0,863,867,3,108,54,0,864,867,3,4,2,0,865,867,5,108,
		0,0,866,863,1,0,0,0,866,864,1,0,0,0,866,865,1,0,0,0,867,868,1,0,0,0,868,
		917,5,130,0,0,869,870,5,25,0,0,870,871,5,129,0,0,871,872,3,28,14,0,872,
		873,5,130,0,0,873,917,1,0,0,0,874,875,5,101,0,0,875,876,5,129,0,0,876,
		877,3,28,14,0,877,878,5,130,0,0,878,917,1,0,0,0,879,884,5,30,0,0,880,881,
		5,129,0,0,881,882,3,4,2,0,882,883,5,130,0,0,883,885,1,0,0,0,884,880,1,
		0,0,0,884,885,1,0,0,0,885,917,1,0,0,0,886,888,5,15,0,0,887,886,1,0,0,0,
		887,888,1,0,0,0,888,889,1,0,0,0,889,895,5,31,0,0,890,892,5,129,0,0,891,
		893,3,122,61,0,892,891,1,0,0,0,892,893,1,0,0,0,893,894,1,0,0,0,894,896,
		5,130,0,0,895,890,1,0,0,0,895,896,1,0,0,0,896,897,1,0,0,0,897,917,3,170,
		85,0,898,899,5,88,0,0,899,900,5,129,0,0,900,901,3,4,2,0,901,902,5,130,
		0,0,902,917,1,0,0,0,903,904,5,64,0,0,904,910,5,129,0,0,905,906,3,434,217,
		0,906,907,5,131,0,0,907,909,1,0,0,0,908,905,1,0,0,0,909,912,1,0,0,0,910,
		908,1,0,0,0,910,911,1,0,0,0,911,913,1,0,0,0,912,910,1,0,0,0,913,914,3,
		434,217,0,914,915,5,130,0,0,915,917,1,0,0,0,916,795,1,0,0,0,916,796,1,
		0,0,0,916,800,1,0,0,0,916,804,1,0,0,0,916,805,1,0,0,0,916,806,1,0,0,0,
		916,807,1,0,0,0,916,808,1,0,0,0,916,820,1,0,0,0,916,851,1,0,0,0,916,861,
		1,0,0,0,916,869,1,0,0,0,916,874,1,0,0,0,916,879,1,0,0,0,916,887,1,0,0,
		0,916,898,1,0,0,0,916,903,1,0,0,0,917,73,1,0,0,0,918,921,3,28,14,0,919,
		921,3,76,38,0,920,918,1,0,0,0,920,919,1,0,0,0,921,75,1,0,0,0,922,923,5,
		95,0,0,923,924,3,28,14,0,924,77,1,0,0,0,925,927,5,148,0,0,926,925,1,0,
		0,0,926,927,1,0,0,0,927,928,1,0,0,0,928,929,5,131,0,0,929,931,3,434,217,
		0,930,932,3,22,11,0,931,930,1,0,0,0,931,932,1,0,0,0,932,79,1,0,0,0,933,
		935,5,148,0,0,934,933,1,0,0,0,934,935,1,0,0,0,935,936,1,0,0,0,936,937,
		5,127,0,0,937,942,3,82,41,0,938,939,5,132,0,0,939,941,3,82,41,0,940,938,
		1,0,0,0,941,944,1,0,0,0,942,940,1,0,0,0,942,943,1,0,0,0,943,945,1,0,0,
		0,944,942,1,0,0,0,945,946,5,128,0,0,946,81,1,0,0,0,947,948,3,434,217,0,
		948,949,5,133,0,0,949,951,1,0,0,0,950,947,1,0,0,0,950,951,1,0,0,0,951,
		952,1,0,0,0,952,953,3,28,14,0,953,83,1,0,0,0,954,955,7,7,0,0,955,85,1,
		0,0,0,956,961,3,28,14,0,957,958,5,132,0,0,958,960,3,28,14,0,959,957,1,
		0,0,0,960,963,1,0,0,0,961,959,1,0,0,0,961,962,1,0,0,0,962,87,1,0,0,0,963,
		961,1,0,0,0,964,967,3,90,45,0,965,967,3,98,49,0,966,964,1,0,0,0,966,965,
		1,0,0,0,967,89,1,0,0,0,968,973,5,125,0,0,969,971,3,92,46,0,970,972,5,132,
		0,0,971,970,1,0,0,0,971,972,1,0,0,0,972,974,1,0,0,0,973,969,1,0,0,0,973,
		974,1,0,0,0,974,975,1,0,0,0,975,976,5,126,0,0,976,91,1,0,0,0,977,982,3,
		94,47,0,978,979,5,132,0,0,979,981,3,94,47,0,980,978,1,0,0,0,981,984,1,
		0,0,0,982,980,1,0,0,0,982,983,1,0,0,0,983,93,1,0,0,0,984,982,1,0,0,0,985,
		991,3,434,217,0,986,987,5,127,0,0,987,988,3,28,14,0,988,989,5,128,0,0,
		989,991,1,0,0,0,990,985,1,0,0,0,990,986,1,0,0,0,991,992,1,0,0,0,992,993,
		5,145,0,0,993,994,3,96,48,0,994,95,1,0,0,0,995,998,3,28,14,0,996,998,3,
		88,44,0,997,995,1,0,0,0,997,996,1,0,0,0,998,97,1,0,0,0,999,1000,5,125,
		0,0,1000,1005,3,100,50,0,1001,1002,5,132,0,0,1002,1004,3,100,50,0,1003,
		1001,1,0,0,0,1004,1007,1,0,0,0,1005,1003,1,0,0,0,1005,1006,1,0,0,0,1006,
		1009,1,0,0,0,1007,1005,1,0,0,0,1008,1010,5,132,0,0,1009,1008,1,0,0,0,1009,
		1010,1,0,0,0,1010,1011,1,0,0,0,1011,1012,5,126,0,0,1012,99,1,0,0,0,1013,
		1019,3,30,15,0,1014,1015,5,125,0,0,1015,1016,3,86,43,0,1016,1017,5,126,
		0,0,1017,1019,1,0,0,0,1018,1013,1,0,0,0,1018,1014,1,0,0,0,1019,101,1,0,
		0,0,1020,1025,5,125,0,0,1021,1023,3,104,52,0,1022,1024,5,132,0,0,1023,
		1022,1,0,0,0,1023,1024,1,0,0,0,1024,1026,1,0,0,0,1025,1021,1,0,0,0,1025,
		1026,1,0,0,0,1026,1027,1,0,0,0,1027,1028,5,126,0,0,1028,103,1,0,0,0,1029,
		1034,3,106,53,0,1030,1031,5,132,0,0,1031,1033,3,106,53,0,1032,1030,1,0,
		0,0,1033,1036,1,0,0,0,1034,1032,1,0,0,0,1034,1035,1,0,0,0,1035,105,1,0,
		0,0,1036,1034,1,0,0,0,1037,1043,3,70,35,0,1038,1039,3,434,217,0,1039,1040,
		5,145,0,0,1040,1041,3,28,14,0,1041,1043,1,0,0,0,1042,1037,1,0,0,0,1042,
		1038,1,0,0,0,1043,107,1,0,0,0,1044,1053,3,434,217,0,1045,1047,3,110,55,
		0,1046,1045,1,0,0,0,1046,1047,1,0,0,0,1047,1054,1,0,0,0,1048,1049,5,149,
		0,0,1049,1051,3,434,217,0,1050,1052,3,110,55,0,1051,1050,1,0,0,0,1051,
		1052,1,0,0,0,1052,1054,1,0,0,0,1053,1046,1,0,0,0,1053,1048,1,0,0,0,1054,
		1062,1,0,0,0,1055,1056,5,131,0,0,1056,1058,3,434,217,0,1057,1059,3,110,
		55,0,1058,1057,1,0,0,0,1058,1059,1,0,0,0,1059,1061,1,0,0,0,1060,1055,1,
		0,0,0,1061,1064,1,0,0,0,1062,1060,1,0,0,0,1062,1063,1,0,0,0,1063,109,1,
		0,0,0,1064,1062,1,0,0,0,1065,1069,5,146,0,0,1066,1068,5,132,0,0,1067,1066,
		1,0,0,0,1068,1071,1,0,0,0,1069,1067,1,0,0,0,1069,1070,1,0,0,0,1070,1072,
		1,0,0,0,1071,1069,1,0,0,0,1072,1073,5,147,0,0,1073,111,1,0,0,0,1074,1079,
		3,6,3,0,1075,1078,3,322,161,0,1076,1078,5,137,0,0,1077,1075,1,0,0,0,1077,
		1076,1,0,0,0,1078,1081,1,0,0,0,1079,1077,1,0,0,0,1079,1080,1,0,0,0,1080,
		1083,1,0,0,0,1081,1079,1,0,0,0,1082,1084,5,148,0,0,1083,1082,1,0,0,0,1083,
		1084,1,0,0,0,1084,1086,1,0,0,0,1085,1087,3,114,57,0,1086,1085,1,0,0,0,
		1086,1087,1,0,0,0,1087,1089,1,0,0,0,1088,1090,3,434,217,0,1089,1088,1,
		0,0,0,1089,1090,1,0,0,0,1090,113,1,0,0,0,1091,1092,5,125,0,0,1092,1097,
		3,116,58,0,1093,1094,5,132,0,0,1094,1096,3,116,58,0,1095,1093,1,0,0,0,
		1096,1099,1,0,0,0,1097,1095,1,0,0,0,1097,1098,1,0,0,0,1098,1100,1,0,0,
		0,1099,1097,1,0,0,0,1100,1101,5,126,0,0,1101,115,1,0,0,0,1102,1103,3,434,
		217,0,1103,1104,5,133,0,0,1104,1105,3,28,14,0,1105,117,1,0,0,0,1106,1108,
		5,15,0,0,1107,1106,1,0,0,0,1107,1108,1,0,0,0,1108,1109,1,0,0,0,1109,1110,
		3,120,60,0,1110,1111,3,374,187,0,1111,1112,3,128,64,0,1112,119,1,0,0,0,
		1113,1114,5,129,0,0,1114,1125,5,130,0,0,1115,1116,5,129,0,0,1116,1117,
		3,122,61,0,1117,1118,5,130,0,0,1118,1125,1,0,0,0,1119,1120,5,129,0,0,1120,
		1121,3,126,63,0,1121,1122,5,130,0,0,1122,1125,1,0,0,0,1123,1125,3,434,
		217,0,1124,1113,1,0,0,0,1124,1115,1,0,0,0,1124,1119,1,0,0,0,1124,1123,
		1,0,0,0,1125,121,1,0,0,0,1126,1131,3,124,62,0,1127,1128,5,132,0,0,1128,
		1130,3,124,62,0,1129,1127,1,0,0,0,1130,1133,1,0,0,0,1131,1129,1,0,0,0,
		1131,1132,1,0,0,0,1132,123,1,0,0,0,1133,1131,1,0,0,0,1134,1136,7,2,0,0,
		1135,1134,1,0,0,0,1135,1136,1,0,0,0,1136,1137,1,0,0,0,1137,1138,3,4,2,
		0,1138,1139,3,434,217,0,1139,125,1,0,0,0,1140,1145,3,434,217,0,1141,1142,
		5,132,0,0,1142,1144,3,434,217,0,1143,1141,1,0,0,0,1144,1147,1,0,0,0,1145,
		1143,1,0,0,0,1145,1146,1,0,0,0,1146,127,1,0,0,0,1147,1145,1,0,0,0,1148,
		1151,3,74,37,0,1149,1151,3,170,85,0,1150,1148,1,0,0,0,1150,1149,1,0,0,
		0,1151,129,1,0,0,0,1152,1153,3,132,66,0,1153,1154,3,134,67,0,1154,131,
		1,0,0,0,1155,1157,5,48,0,0,1156,1158,3,4,2,0,1157,1156,1,0,0,0,1157,1158,
		1,0,0,0,1158,1159,1,0,0,0,1159,1160,3,434,217,0,1160,1161,5,54,0,0,1161,
		1162,3,28,14,0,1162,133,1,0,0,0,1163,1165,3,136,68,0,1164,1163,1,0,0,0,
		1165,1168,1,0,0,0,1166,1164,1,0,0,0,1166,1167,1,0,0,0,1167,1169,1,0,0,
		0,1168,1166,1,0,0,0,1169,1171,3,148,74,0,1170,1172,3,150,75,0,1171,1170,
		1,0,0,0,1171,1172,1,0,0,0,1172,135,1,0,0,0,1173,1179,3,132,66,0,1174,1179,
		3,138,69,0,1175,1179,3,140,70,0,1176,1179,3,142,71,0,1177,1179,3,144,72,
		0,1178,1173,1,0,0,0,1178,1174,1,0,0,0,1178,1175,1,0,0,0,1178,1176,1,0,
		0,0,1178,1177,1,0,0,0,1179,137,1,0,0,0,1180,1181,5,61,0,0,1181,1182,3,
		434,217,0,1182,1183,5,145,0,0,1183,1184,3,28,14,0,1184,139,1,0,0,0,1185,
		1186,5,111,0,0,1186,1187,3,28,14,0,1187,141,1,0,0,0,1188,1190,5,60,0,0,
		1189,1191,3,4,2,0,1190,1189,1,0,0,0,1190,1191,1,0,0,0,1191,1192,1,0,0,
		0,1192,1193,3,434,217,0,1193,1194,5,54,0,0,1194,1195,3,28,14,0,1195,1196,
		5,69,0,0,1196,1197,3,28,14,0,1197,1198,5,38,0,0,1198,1201,3,28,14,0,1199,
		1200,5,58,0,0,1200,1202,3,434,217,0,1201,1199,1,0,0,0,1201,1202,1,0,0,
		0,1202,143,1,0,0,0,1203,1204,5,71,0,0,1204,1209,3,146,73,0,1205,1206,5,
		132,0,0,1206,1208,3,146,73,0,1207,1205,1,0,0,0,1208,1211,1,0,0,0,1209,
		1207,1,0,0,0,1209,1210,1,0,0,0,1210,145,1,0,0,0,1211,1209,1,0,0,0,1212,
		1214,3,28,14,0,1213,1215,7,8,0,0,1214,1213,1,0,0,0,1214,1215,1,0,0,0,1215,
		147,1,0,0,0,1216,1217,5,85,0,0,1217,1224,3,28,14,0,1218,1219,5,51,0,0,
		1219,1220,3,28,14,0,1220,1221,5,20,0,0,1221,1222,3,28,14,0,1222,1224,1,
		0,0,0,1223,1216,1,0,0,0,1223,1218,1,0,0,0,1224,149,1,0,0,0,1225,1226,5,
		58,0,0,1226,1227,3,434,217,0,1227,1228,3,134,67,0,1228,151,1,0,0,0,1229,
		1233,3,164,82,0,1230,1233,3,154,77,0,1231,1233,3,166,83,0,1232,1229,1,
		0,0,0,1232,1230,1,0,0,0,1232,1231,1,0,0,0,1233,153,1,0,0,0,1234,1235,3,
		172,86,0,1235,1236,5,134,0,0,1236,1242,1,0,0,0,1237,1238,3,180,90,0,1238,
		1239,5,134,0,0,1239,1242,1,0,0,0,1240,1242,3,156,78,0,1241,1234,1,0,0,
		0,1241,1237,1,0,0,0,1241,1240,1,0,0,0,1242,155,1,0,0,0,1243,1244,3,158,
		79,0,1244,1245,3,162,81,0,1245,157,1,0,0,0,1246,1248,3,160,80,0,1247,1246,
		1,0,0,0,1247,1248,1,0,0,0,1248,1249,1,0,0,0,1249,1250,3,274,137,0,1250,
		1252,3,434,217,0,1251,1253,3,230,115,0,1252,1251,1,0,0,0,1252,1253,1,0,
		0,0,1253,1254,1,0,0,0,1254,1256,5,129,0,0,1255,1257,3,280,140,0,1256,1255,
		1,0,0,0,1256,1257,1,0,0,0,1257,1258,1,0,0,0,1258,1260,5,130,0,0,1259,1261,
		3,238,119,0,1260,1259,1,0,0,0,1260,1261,1,0,0,0,1261,159,1,0,0,0,1262,
		1264,7,9,0,0,1263,1265,5,90,0,0,1264,1263,1,0,0,0,1264,1265,1,0,0,0,1265,
		1269,1,0,0,0,1266,1267,5,90,0,0,1267,1269,7,9,0,0,1268,1262,1,0,0,0,1268,
		1266,1,0,0,0,1269,161,1,0,0,0,1270,1276,3,170,85,0,1271,1272,3,374,187,
		0,1272,1273,3,74,37,0,1273,1274,5,134,0,0,1274,1276,1,0,0,0,1275,1270,
		1,0,0,0,1275,1271,1,0,0,0,1276,163,1,0,0,0,1277,1278,3,434,217,0,1278,
		1279,5,133,0,0,1279,1280,3,152,76,0,1280,165,1,0,0,0,1281,1284,3,170,85,
		0,1282,1284,3,168,84,0,1283,1281,1,0,0,0,1283,1282,1,0,0,0,1284,167,1,
		0,0,0,1285,1416,5,134,0,0,1286,1287,3,28,14,0,1287,1288,5,134,0,0,1288,
		1416,1,0,0,0,1289,1290,5,52,0,0,1290,1291,5,129,0,0,1291,1292,3,28,14,
		0,1292,1293,5,130,0,0,1293,1296,3,182,91,0,1294,1295,5,36,0,0,1295,1297,
		3,182,91,0,1296,1294,1,0,0,0,1296,1297,1,0,0,0,1297,1416,1,0,0,0,1298,
		1299,5,93,0,0,1299,1300,5,129,0,0,1300,1301,3,28,14,0,1301,1302,5,130,
		0,0,1302,1306,5,125,0,0,1303,1305,3,184,92,0,1304,1303,1,0,0,0,1305,1308,
		1,0,0,0,1306,1304,1,0,0,0,1306,1307,1,0,0,0,1307,1309,1,0,0,0,1308,1306,
		1,0,0,0,1309,1310,5,126,0,0,1310,1416,1,0,0,0,1311,1312,5,112,0,0,1312,
		1313,5,129,0,0,1313,1314,3,28,14,0,1314,1315,5,130,0,0,1315,1316,3,166,
		83,0,1316,1416,1,0,0,0,1317,1318,5,33,0,0,1318,1319,3,166,83,0,1319,1320,
		5,112,0,0,1320,1321,5,129,0,0,1321,1322,3,28,14,0,1322,1323,5,130,0,0,
		1323,1324,5,134,0,0,1324,1416,1,0,0,0,1325,1326,5,46,0,0,1326,1328,5,129,
		0,0,1327,1329,3,192,96,0,1328,1327,1,0,0,0,1328,1329,1,0,0,0,1329,1330,
		1,0,0,0,1330,1332,5,134,0,0,1331,1333,3,28,14,0,1332,1331,1,0,0,0,1332,
		1333,1,0,0,0,1333,1334,1,0,0,0,1334,1336,5,134,0,0,1335,1337,3,194,97,
		0,1336,1335,1,0,0,0,1336,1337,1,0,0,0,1337,1338,1,0,0,0,1338,1339,5,130,
		0,0,1339,1416,3,166,83,0,1340,1342,5,16,0,0,1341,1340,1,0,0,0,1341,1342,
		1,0,0,0,1342,1343,1,0,0,0,1343,1344,5,47,0,0,1344,1345,5,129,0,0,1345,
		1346,3,174,87,0,1346,1347,3,434,217,0,1347,1348,5,54,0,0,1348,1349,3,28,
		14,0,1349,1350,5,130,0,0,1350,1351,3,166,83,0,1351,1416,1,0,0,0,1352,1353,
		5,19,0,0,1353,1416,5,134,0,0,1354,1355,5,28,0,0,1355,1416,5,134,0,0,1356,
		1361,5,50,0,0,1357,1362,3,434,217,0,1358,1359,5,22,0,0,1359,1362,3,28,
		14,0,1360,1362,5,30,0,0,1361,1357,1,0,0,0,1361,1358,1,0,0,0,1361,1360,
		1,0,0,0,1362,1363,1,0,0,0,1363,1416,5,134,0,0,1364,1366,5,82,0,0,1365,
		1367,3,28,14,0,1366,1365,1,0,0,0,1366,1367,1,0,0,0,1367,1368,1,0,0,0,1368,
		1416,5,134,0,0,1369,1371,5,95,0,0,1370,1372,3,28,14,0,1371,1370,1,0,0,
		0,1371,1372,1,0,0,0,1372,1373,1,0,0,0,1373,1416,5,134,0,0,1374,1375,5,
		97,0,0,1375,1381,3,170,85,0,1376,1378,3,196,98,0,1377,1379,3,204,102,0,
		1378,1377,1,0,0,0,1378,1379,1,0,0,0,1379,1382,1,0,0,0,1380,1382,3,204,
		102,0,1381,1376,1,0,0,0,1381,1380,1,0,0,0,1382,1416,1,0,0,0,1383,1384,
		5,25,0,0,1384,1416,3,170,85,0,1385,1386,5,101,0,0,1386,1416,3,170,85,0,
		1387,1388,5,62,0,0,1388,1389,5,129,0,0,1389,1390,3,28,14,0,1390,1391,5,
		130,0,0,1391,1392,3,166,83,0,1392,1416,1,0,0,0,1393,1394,5,105,0,0,1394,
		1395,5,129,0,0,1395,1396,3,206,103,0,1396,1397,5,130,0,0,1397,1398,3,166,
		83,0,1398,1416,1,0,0,0,1399,1403,5,113,0,0,1400,1401,5,82,0,0,1401,1404,
		3,28,14,0,1402,1404,5,19,0,0,1403,1400,1,0,0,0,1403,1402,1,0,0,0,1404,
		1405,1,0,0,0,1405,1416,5,134,0,0,1406,1407,5,103,0,0,1407,1416,3,170,85,
		0,1408,1409,5,44,0,0,1409,1410,5,129,0,0,1410,1411,3,362,181,0,1411,1412,
		3,364,182,0,1412,1413,5,130,0,0,1413,1414,3,166,83,0,1414,1416,1,0,0,0,
		1415,1285,1,0,0,0,1415,1286,1,0,0,0,1415,1289,1,0,0,0,1415,1298,1,0,0,
		0,1415,1311,1,0,0,0,1415,1317,1,0,0,0,1415,1325,1,0,0,0,1415,1341,1,0,
		0,0,1415,1352,1,0,0,0,1415,1354,1,0,0,0,1415,1356,1,0,0,0,1415,1364,1,
		0,0,0,1415,1369,1,0,0,0,1415,1374,1,0,0,0,1415,1383,1,0,0,0,1415,1385,
		1,0,0,0,1415,1387,1,0,0,0,1415,1393,1,0,0,0,1415,1399,1,0,0,0,1415,1406,
		1,0,0,0,1415,1408,1,0,0,0,1416,169,1,0,0,0,1417,1419,5,125,0,0,1418,1420,
		3,190,95,0,1419,1418,1,0,0,0,1419,1420,1,0,0,0,1420,1421,1,0,0,0,1421,
		1422,5,126,0,0,1422,171,1,0,0,0,1423,1428,5,105,0,0,1424,1428,5,80,0,0,
		1425,1426,5,80,0,0,1426,1428,5,79,0,0,1427,1423,1,0,0,0,1427,1424,1,0,
		0,0,1427,1425,1,0,0,0,1427,1428,1,0,0,0,1428,1429,1,0,0,0,1429,1430,3,
		174,87,0,1430,1437,3,176,88,0,1431,1432,5,132,0,0,1432,1433,3,176,88,0,
		1433,1434,4,86,0,0,1434,1436,1,0,0,0,1435,1431,1,0,0,0,1436,1439,1,0,0,
		0,1437,1435,1,0,0,0,1437,1438,1,0,0,0,1438,1445,1,0,0,0,1439,1437,1,0,
		0,0,1440,1441,5,44,0,0,1441,1442,3,362,181,0,1442,1443,3,364,182,0,1443,
		1445,1,0,0,0,1444,1427,1,0,0,0,1444,1440,1,0,0,0,1445,173,1,0,0,0,1446,
		1449,5,106,0,0,1447,1449,3,4,2,0,1448,1446,1,0,0,0,1448,1447,1,0,0,0,1449,
		175,1,0,0,0,1450,1456,3,434,217,0,1451,1453,5,145,0,0,1452,1454,5,80,0,
		0,1453,1452,1,0,0,0,1453,1454,1,0,0,0,1454,1455,1,0,0,0,1455,1457,3,178,
		89,0,1456,1451,1,0,0,0,1456,1457,1,0,0,0,1457,177,1,0,0,0,1458,1462,3,
		28,14,0,1459,1462,3,324,162,0,1460,1462,3,372,186,0,1461,1458,1,0,0,0,
		1461,1459,1,0,0,0,1461,1460,1,0,0,0,1462,179,1,0,0,0,1463,1464,5,27,0,
		0,1464,1465,3,4,2,0,1465,1466,3,264,132,0,1466,181,1,0,0,0,1467,1470,3,
		170,85,0,1468,1470,3,168,84,0,1469,1467,1,0,0,0,1469,1468,1,0,0,0,1470,
		183,1,0,0,0,1471,1473,3,186,93,0,1472,1471,1,0,0,0,1473,1474,1,0,0,0,1474,
		1472,1,0,0,0,1474,1475,1,0,0,0,1475,1476,1,0,0,0,1476,1477,3,190,95,0,
		1477,185,1,0,0,0,1478,1479,5,22,0,0,1479,1481,3,28,14,0,1480,1482,3,188,
		94,0,1481,1480,1,0,0,0,1481,1482,1,0,0,0,1482,1483,1,0,0,0,1483,1484,5,
		133,0,0,1484,1488,1,0,0,0,1485,1486,5,30,0,0,1486,1488,5,133,0,0,1487,
		1478,1,0,0,0,1487,1485,1,0,0,0,1488,187,1,0,0,0,1489,1490,5,110,0,0,1490,
		1491,3,28,14,0,1491,189,1,0,0,0,1492,1494,3,152,76,0,1493,1492,1,0,0,0,
		1494,1495,1,0,0,0,1495,1493,1,0,0,0,1495,1496,1,0,0,0,1496,191,1,0,0,0,
		1497,1507,3,172,86,0,1498,1503,3,28,14,0,1499,1500,5,132,0,0,1500,1502,
		3,28,14,0,1501,1499,1,0,0,0,1502,1505,1,0,0,0,1503,1501,1,0,0,0,1503,1504,
		1,0,0,0,1504,1507,1,0,0,0,1505,1503,1,0,0,0,1506,1497,1,0,0,0,1506,1498,
		1,0,0,0,1507,193,1,0,0,0,1508,1513,3,28,14,0,1509,1510,5,132,0,0,1510,
		1512,3,28,14,0,1511,1509,1,0,0,0,1512,1515,1,0,0,0,1513,1511,1,0,0,0,1513,
		1514,1,0,0,0,1514,195,1,0,0,0,1515,1513,1,0,0,0,1516,1520,3,198,99,0,1517,
		1519,3,198,99,0,1518,1517,1,0,0,0,1519,1522,1,0,0,0,1520,1518,1,0,0,0,
		1520,1521,1,0,0,0,1521,1524,1,0,0,0,1522,1520,1,0,0,0,1523,1525,3,200,
		100,0,1524,1523,1,0,0,0,1524,1525,1,0,0,0,1525,1528,1,0,0,0,1526,1528,
		3,200,100,0,1527,1516,1,0,0,0,1527,1526,1,0,0,0,1528,197,1,0,0,0,1529,
		1530,5,23,0,0,1530,1531,5,129,0,0,1531,1533,3,20,10,0,1532,1534,3,434,
		217,0,1533,1532,1,0,0,0,1533,1534,1,0,0,0,1534,1535,1,0,0,0,1535,1537,
		5,130,0,0,1536,1538,3,202,101,0,1537,1536,1,0,0,0,1537,1538,1,0,0,0,1538,
		1539,1,0,0,0,1539,1540,3,170,85,0,1540,199,1,0,0,0,1541,1543,5,23,0,0,
		1542,1544,3,202,101,0,1543,1542,1,0,0,0,1543,1544,1,0,0,0,1544,1545,1,
		0,0,0,1545,1546,3,170,85,0,1546,201,1,0,0,0,1547,1548,5,110,0,0,1548,1549,
		5,129,0,0,1549,1550,3,28,14,0,1550,1551,5,130,0,0,1551,203,1,0,0,0,1552,
		1553,5,43,0,0,1553,1554,3,170,85,0,1554,205,1,0,0,0,1555,1558,3,172,86,
		0,1556,1558,3,28,14,0,1557,1555,1,0,0,0,1557,1556,1,0,0,0,1558,207,1,0,
		0,0,1559,1560,5,65,0,0,1560,1561,3,210,105,0,1561,1563,3,212,106,0,1562,
		1564,5,134,0,0,1563,1562,1,0,0,0,1563,1564,1,0,0,0,1564,209,1,0,0,0,1565,
		1570,3,434,217,0,1566,1567,5,131,0,0,1567,1569,3,434,217,0,1568,1566,1,
		0,0,0,1569,1572,1,0,0,0,1570,1568,1,0,0,0,1570,1571,1,0,0,0,1571,211,1,
		0,0,0,1572,1570,1,0,0,0,1573,1575,5,125,0,0,1574,1576,3,214,107,0,1575,
		1574,1,0,0,0,1575,1576,1,0,0,0,1576,1578,1,0,0,0,1577,1579,3,218,109,0,
		1578,1577,1,0,0,0,1578,1579,1,0,0,0,1579,1581,1,0,0,0,1580,1582,3,222,
		111,0,1581,1580,1,0,0,0,1581,1582,1,0,0,0,1582,1583,1,0,0,0,1583,1584,
		5,126,0,0,1584,213,1,0,0,0,1585,1587,3,216,108,0,1586,1585,1,0,0,0,1587,
		1588,1,0,0,0,1588,1586,1,0,0,0,1588,1589,1,0,0,0,1589,215,1,0,0,0,1590,
		1591,5,41,0,0,1591,1592,5,11,0,0,1592,1593,3,434,217,0,1593,1594,5,134,
		0,0,1594,217,1,0,0,0,1595,1597,3,220,110,0,1596,1595,1,0,0,0,1597,1598,
		1,0,0,0,1598,1596,1,0,0,0,1598,1599,1,0,0,0,1599,219,1,0,0,0,1600,1601,
		5,105,0,0,1601,1602,3,434,217,0,1602,1603,5,145,0,0,1603,1604,3,2,1,0,
		1604,1605,5,134,0,0,1605,1616,1,0,0,0,1606,1607,5,105,0,0,1607,1608,3,
		2,1,0,1608,1609,5,134,0,0,1609,1616,1,0,0,0,1610,1611,5,105,0,0,1611,1612,
		5,90,0,0,1612,1613,3,2,1,0,1613,1614,5,134,0,0,1614,1616,1,0,0,0,1615,
		1600,1,0,0,0,1615,1606,1,0,0,0,1615,1610,1,0,0,0,1616,221,1,0,0,0,1617,
		1619,3,224,112,0,1618,1617,1,0,0,0,1619,1620,1,0,0,0,1620,1618,1,0,0,0,
		1620,1621,1,0,0,0,1621,223,1,0,0,0,1622,1625,3,208,104,0,1623,1625,3,226,
		113,0,1624,1622,1,0,0,0,1624,1623,1,0,0,0,1625,225,1,0,0,0,1626,1628,3,
		350,175,0,1627,1626,1,0,0,0,1627,1628,1,0,0,0,1628,1630,1,0,0,0,1629,1631,
		3,256,128,0,1630,1629,1,0,0,0,1630,1631,1,0,0,0,1631,1637,1,0,0,0,1632,
		1638,3,398,199,0,1633,1638,3,400,200,0,1634,1638,3,402,201,0,1635,1638,
		3,404,202,0,1636,1638,3,406,203,0,1637,1632,1,0,0,0,1637,1633,1,0,0,0,
		1637,1634,1,0,0,0,1637,1635,1,0,0,0,1637,1636,1,0,0,0,1638,227,1,0,0,0,
		1639,1640,3,434,217,0,1640,1641,5,149,0,0,1641,1643,3,434,217,0,1642,1644,
		3,22,11,0,1643,1642,1,0,0,0,1643,1644,1,0,0,0,1644,229,1,0,0,0,1645,1646,
		5,146,0,0,1646,1651,3,232,116,0,1647,1648,5,132,0,0,1648,1650,3,232,116,
		0,1649,1647,1,0,0,0,1650,1653,1,0,0,0,1651,1649,1,0,0,0,1651,1652,1,0,
		0,0,1652,1654,1,0,0,0,1653,1651,1,0,0,0,1654,1655,5,147,0,0,1655,231,1,
		0,0,0,1656,1658,3,350,175,0,1657,1656,1,0,0,0,1657,1658,1,0,0,0,1658,1659,
		1,0,0,0,1659,1660,3,434,217,0,1660,233,1,0,0,0,1661,1662,5,133,0,0,1662,
		1667,3,20,10,0,1663,1664,5,132,0,0,1664,1666,3,2,1,0,1665,1663,1,0,0,0,
		1666,1669,1,0,0,0,1667,1665,1,0,0,0,1667,1668,1,0,0,0,1668,235,1,0,0,0,
		1669,1667,1,0,0,0,1670,1675,3,2,1,0,1671,1672,5,132,0,0,1672,1674,3,2,
		1,0,1673,1671,1,0,0,0,1674,1677,1,0,0,0,1675,1673,1,0,0,0,1675,1676,1,
		0,0,0,1676,237,1,0,0,0,1677,1675,1,0,0,0,1678,1680,3,240,120,0,1679,1678,
		1,0,0,0,1680,1681,1,0,0,0,1681,1679,1,0,0,0,1681,1682,1,0,0,0,1682,239,
		1,0,0,0,1683,1684,5,111,0,0,1684,1685,3,434,217,0,1685,1686,5,133,0,0,
		1686,1687,3,242,121,0,1687,241,1,0,0,0,1688,1699,3,248,124,0,1689,1692,
		3,244,122,0,1690,1691,5,132,0,0,1691,1693,3,246,123,0,1692,1690,1,0,0,
		0,1692,1693,1,0,0,0,1693,1696,1,0,0,0,1694,1695,5,132,0,0,1695,1697,3,
		248,124,0,1696,1694,1,0,0,0,1696,1697,1,0,0,0,1697,1699,1,0,0,0,1698,1688,
		1,0,0,0,1698,1689,1,0,0,0,1699,243,1,0,0,0,1700,1708,3,20,10,0,1701,1703,
		5,26,0,0,1702,1704,5,148,0,0,1703,1702,1,0,0,0,1703,1704,1,0,0,0,1704,
		1708,1,0,0,0,1705,1708,5,92,0,0,1706,1708,5,102,0,0,1707,1700,1,0,0,0,
		1707,1701,1,0,0,0,1707,1705,1,0,0,0,1707,1706,1,0,0,0,1708,245,1,0,0,0,
		1709,1714,3,2,1,0,1710,1711,5,132,0,0,1711,1713,3,2,1,0,1712,1710,1,0,
		0,0,1713,1716,1,0,0,0,1714,1712,1,0,0,0,1714,1715,1,0,0,0,1715,247,1,0,
		0,0,1716,1714,1,0,0,0,1717,1718,5,66,0,0,1718,1719,5,129,0,0,1719,1720,
		5,130,0,0,1720,249,1,0,0,0,1721,1723,5,125,0,0,1722,1724,3,252,126,0,1723,
		1722,1,0,0,0,1723,1724,1,0,0,0,1724,1725,1,0,0,0,1725,1726,5,126,0,0,1726,
		251,1,0,0,0,1727,1729,3,254,127,0,1728,1727,1,0,0,0,1729,1730,1,0,0,0,
		1730,1728,1,0,0,0,1730,1731,1,0,0,0,1731,253,1,0,0,0,1732,1734,3,350,175,
		0,1733,1732,1,0,0,0,1733,1734,1,0,0,0,1734,1736,1,0,0,0,1735,1737,3,256,
		128,0,1736,1735,1,0,0,0,1736,1737,1,0,0,0,1737,1740,1,0,0,0,1738,1741,
		3,260,130,0,1739,1741,3,418,209,0,1740,1738,1,0,0,0,1740,1739,1,0,0,0,
		1741,255,1,0,0,0,1742,1744,3,258,129,0,1743,1742,1,0,0,0,1744,1745,1,0,
		0,0,1745,1743,1,0,0,0,1745,1746,1,0,0,0,1746,257,1,0,0,0,1747,1748,7,10,
		0,0,1748,259,1,0,0,0,1749,1769,3,414,207,0,1750,1769,3,262,131,0,1751,
		1769,3,408,204,0,1752,1758,3,308,154,0,1753,1759,3,312,156,0,1754,1755,
		3,374,187,0,1755,1756,3,74,37,0,1756,1757,5,134,0,0,1757,1759,1,0,0,0,
		1758,1753,1,0,0,0,1758,1754,1,0,0,0,1759,1769,1,0,0,0,1760,1769,3,420,
		210,0,1761,1762,5,108,0,0,1762,1769,3,422,211,0,1763,1769,3,398,199,0,
		1764,1769,3,400,200,0,1765,1769,3,402,201,0,1766,1769,3,404,202,0,1767,
		1769,3,406,203,0,1768,1749,1,0,0,0,1768,1750,1,0,0,0,1768,1751,1,0,0,0,
		1768,1752,1,0,0,0,1768,1760,1,0,0,0,1768,1761,1,0,0,0,1768,1763,1,0,0,
		0,1768,1764,1,0,0,0,1768,1765,1,0,0,0,1768,1766,1,0,0,0,1768,1767,1,0,
		0,0,1769,261,1,0,0,0,1770,1776,5,80,0,0,1771,1772,5,79,0,0,1772,1776,5,
		80,0,0,1773,1774,5,80,0,0,1774,1776,5,79,0,0,1775,1770,1,0,0,0,1775,1771,
		1,0,0,0,1775,1773,1,0,0,0,1775,1776,1,0,0,0,1776,1777,1,0,0,0,1777,1787,
		3,4,2,0,1778,1779,3,2,1,0,1779,1780,5,131,0,0,1780,1781,3,416,208,0,1781,
		1788,1,0,0,0,1782,1788,3,422,211,0,1783,1788,3,412,206,0,1784,1788,3,416,
		208,0,1785,1788,3,426,213,0,1786,1788,3,410,205,0,1787,1778,1,0,0,0,1787,
		1782,1,0,0,0,1787,1783,1,0,0,0,1787,1784,1,0,0,0,1787,1785,1,0,0,0,1787,
		1786,1,0,0,0,1788,263,1,0,0,0,1789,1794,3,266,133,0,1790,1791,5,132,0,
		0,1791,1793,3,266,133,0,1792,1790,1,0,0,0,1793,1796,1,0,0,0,1794,1792,
		1,0,0,0,1794,1795,1,0,0,0,1795,265,1,0,0,0,1796,1794,1,0,0,0,1797,1798,
		3,434,217,0,1798,1799,5,145,0,0,1799,1800,3,28,14,0,1800,267,1,0,0,0,1801,
		1806,3,270,135,0,1802,1803,5,132,0,0,1803,1805,3,270,135,0,1804,1802,1,
		0,0,0,1805,1808,1,0,0,0,1806,1804,1,0,0,0,1806,1807,1,0,0,0,1807,269,1,
		0,0,0,1808,1806,1,0,0,0,1809,1812,3,434,217,0,1810,1811,5,145,0,0,1811,
		1813,3,272,136,0,1812,1810,1,0,0,0,1812,1813,1,0,0,0,1813,271,1,0,0,0,
		1814,1817,3,28,14,0,1815,1817,3,324,162,0,1816,1814,1,0,0,0,1816,1815,
		1,0,0,0,1817,273,1,0,0,0,1818,1821,3,4,2,0,1819,1821,5,108,0,0,1820,1818,
		1,0,0,0,1820,1819,1,0,0,0,1821,275,1,0,0,0,1822,1823,3,2,1,0,1823,277,
		1,0,0,0,1824,1827,3,170,85,0,1825,1827,5,134,0,0,1826,1824,1,0,0,0,1826,
		1825,1,0,0,0,1827,279,1,0,0,0,1828,1835,3,288,144,0,1829,1832,3,282,141,
		0,1830,1831,5,132,0,0,1831,1833,3,288,144,0,1832,1830,1,0,0,0,1832,1833,
		1,0,0,0,1833,1835,1,0,0,0,1834,1828,1,0,0,0,1834,1829,1,0,0,0,1835,281,
		1,0,0,0,1836,1841,3,284,142,0,1837,1838,5,132,0,0,1838,1840,3,284,142,
		0,1839,1837,1,0,0,0,1840,1843,1,0,0,0,1841,1839,1,0,0,0,1841,1842,1,0,
		0,0,1842,283,1,0,0,0,1843,1841,1,0,0,0,1844,1846,3,350,175,0,1845,1844,
		1,0,0,0,1845,1846,1,0,0,0,1846,1848,1,0,0,0,1847,1849,3,286,143,0,1848,
		1847,1,0,0,0,1848,1849,1,0,0,0,1849,1850,1,0,0,0,1850,1853,3,428,214,0,
		1851,1853,5,12,0,0,1852,1845,1,0,0,0,1852,1851,1,0,0,0,1853,285,1,0,0,
		0,1854,1863,5,80,0,0,1855,1863,5,72,0,0,1856,1863,5,54,0,0,1857,1858,5,
		80,0,0,1858,1863,5,94,0,0,1859,1860,5,54,0,0,1860,1863,5,94,0,0,1861,1863,
		5,94,0,0,1862,1854,1,0,0,0,1862,1855,1,0,0,0,1862,1856,1,0,0,0,1862,1857,
		1,0,0,0,1862,1859,1,0,0,0,1862,1861,1,0,0,0,1863,287,1,0,0,0,1864,1866,
		3,350,175,0,1865,1864,1,0,0,0,1865,1866,1,0,0,0,1866,1867,1,0,0,0,1867,
		1868,5,74,0,0,1868,1869,3,320,160,0,1869,1870,3,434,217,0,1870,289,1,0,
		0,0,1871,1873,3,350,175,0,1872,1871,1,0,0,0,1872,1873,1,0,0,0,1873,1875,
		1,0,0,0,1874,1876,3,296,148,0,1875,1874,1,0,0,0,1875,1876,1,0,0,0,1876,
		1887,1,0,0,0,1877,1878,5,49,0,0,1878,1880,3,298,149,0,1879,1881,3,294,
		147,0,1880,1879,1,0,0,0,1880,1881,1,0,0,0,1881,1888,1,0,0,0,1882,1883,
		5,86,0,0,1883,1885,3,298,149,0,1884,1886,3,292,146,0,1885,1884,1,0,0,0,
		1885,1886,1,0,0,0,1886,1888,1,0,0,0,1887,1877,1,0,0,0,1887,1882,1,0,0,
		0,1888,291,1,0,0,0,1889,1891,3,350,175,0,1890,1889,1,0,0,0,1890,1891,1,
		0,0,0,1891,1893,1,0,0,0,1892,1894,3,296,148,0,1893,1892,1,0,0,0,1893,1894,
		1,0,0,0,1894,1895,1,0,0,0,1895,1896,5,49,0,0,1896,1897,3,298,149,0,1897,
		293,1,0,0,0,1898,1900,3,350,175,0,1899,1898,1,0,0,0,1899,1900,1,0,0,0,
		1900,1902,1,0,0,0,1901,1903,3,296,148,0,1902,1901,1,0,0,0,1902,1903,1,
		0,0,0,1903,1904,1,0,0,0,1904,1905,5,86,0,0,1905,1906,3,298,149,0,1906,
		295,1,0,0,0,1907,1915,5,77,0,0,1908,1915,5,57,0,0,1909,1915,5,76,0,0,1910,
		1911,5,77,0,0,1911,1915,5,57,0,0,1912,1913,5,57,0,0,1913,1915,5,77,0,0,
		1914,1907,1,0,0,0,1914,1908,1,0,0,0,1914,1909,1,0,0,0,1914,1910,1,0,0,
		0,1914,1912,1,0,0,0,1915,297,1,0,0,0,1916,1919,3,170,85,0,1917,1919,5,
		134,0,0,1918,1916,1,0,0,0,1918,1917,1,0,0,0,1919,299,1,0,0,0,1920,1922,
		3,350,175,0,1921,1920,1,0,0,0,1921,1922,1,0,0,0,1922,1931,1,0,0,0,1923,
		1924,5,10,0,0,1924,1925,3,170,85,0,1925,1926,3,304,152,0,1926,1932,1,0,
		0,0,1927,1928,5,81,0,0,1928,1929,3,170,85,0,1929,1930,3,302,151,0,1930,
		1932,1,0,0,0,1931,1923,1,0,0,0,1931,1927,1,0,0,0,1932,301,1,0,0,0,1933,
		1935,3,350,175,0,1934,1933,1,0,0,0,1934,1935,1,0,0,0,1935,1936,1,0,0,0,
		1936,1937,5,10,0,0,1937,1938,3,170,85,0,1938,303,1,0,0,0,1939,1941,3,350,
		175,0,1940,1939,1,0,0,0,1940,1941,1,0,0,0,1941,1942,1,0,0,0,1942,1943,
		5,81,0,0,1943,1944,3,170,85,0,1944,305,1,0,0,0,1945,1968,5,135,0,0,1946,
		1968,5,136,0,0,1947,1968,5,143,0,0,1948,1968,5,144,0,0,1949,1968,5,151,
		0,0,1950,1968,5,152,0,0,1951,1968,5,96,0,0,1952,1968,5,42,0,0,1953,1968,
		5,137,0,0,1954,1968,5,138,0,0,1955,1968,5,139,0,0,1956,1968,5,140,0,0,
		1957,1968,5,141,0,0,1958,1968,5,142,0,0,1959,1968,5,168,0,0,1960,1968,
		3,376,188,0,1961,1968,5,156,0,0,1962,1968,5,157,0,0,1963,1968,5,147,0,
		0,1964,1968,5,146,0,0,1965,1968,5,159,0,0,1966,1968,5,158,0,0,1967,1945,
		1,0,0,0,1967,1946,1,0,0,0,1967,1947,1,0,0,0,1967,1948,1,0,0,0,1967,1949,
		1,0,0,0,1967,1950,1,0,0,0,1967,1951,1,0,0,0,1967,1952,1,0,0,0,1967,1953,
		1,0,0,0,1967,1954,1,0,0,0,1967,1955,1,0,0,0,1967,1956,1,0,0,0,1967,1957,
		1,0,0,0,1967,1958,1,0,0,0,1967,1959,1,0,0,0,1967,1960,1,0,0,0,1967,1961,
		1,0,0,0,1967,1962,1,0,0,0,1967,1963,1,0,0,0,1967,1964,1,0,0,0,1967,1965,
		1,0,0,0,1967,1966,1,0,0,0,1968,307,1,0,0,0,1969,1970,7,11,0,0,1970,1971,
		5,70,0,0,1971,1972,3,4,2,0,1972,1973,5,129,0,0,1973,1974,3,428,214,0,1974,
		1975,5,130,0,0,1975,309,1,0,0,0,1976,1977,5,133,0,0,1977,1978,7,12,0,0,
		1978,1980,5,129,0,0,1979,1981,3,24,12,0,1980,1979,1,0,0,0,1980,1981,1,
		0,0,0,1981,1982,1,0,0,0,1982,1983,5,130,0,0,1983,311,1,0,0,0,1984,1987,
		3,170,85,0,1985,1987,5,134,0,0,1986,1984,1,0,0,0,1986,1985,1,0,0,0,1987,
		313,1,0,0,0,1988,1989,5,133,0,0,1989,1990,3,236,118,0,1990,315,1,0,0,0,
		1991,1995,5,125,0,0,1992,1994,3,318,159,0,1993,1992,1,0,0,0,1994,1997,
		1,0,0,0,1995,1993,1,0,0,0,1995,1996,1,0,0,0,1996,1998,1,0,0,0,1997,1995,
		1,0,0,0,1998,1999,5,126,0,0,1999,317,1,0,0,0,2000,2002,3,350,175,0,2001,
		2000,1,0,0,0,2001,2002,1,0,0,0,2002,2004,1,0,0,0,2003,2005,3,256,128,0,
		2004,2003,1,0,0,0,2004,2005,1,0,0,0,2005,2016,1,0,0,0,2006,2017,3,260,
		130,0,2007,2008,5,44,0,0,2008,2010,3,4,2,0,2009,2011,3,370,185,0,2010,
		2009,1,0,0,0,2011,2012,1,0,0,0,2012,2010,1,0,0,0,2012,2013,1,0,0,0,2013,
		2014,1,0,0,0,2014,2015,5,134,0,0,2015,2017,1,0,0,0,2016,2006,1,0,0,0,2016,
		2007,1,0,0,0,2017,319,1,0,0,0,2018,2026,3,6,3,0,2019,2021,7,13,0,0,2020,
		2019,1,0,0,0,2021,2024,1,0,0,0,2022,2020,1,0,0,0,2022,2023,1,0,0,0,2023,
		2025,1,0,0,0,2024,2022,1,0,0,0,2025,2027,3,322,161,0,2026,2022,1,0,0,0,
		2027,2028,1,0,0,0,2028,2026,1,0,0,0,2028,2029,1,0,0,0,2029,321,1,0,0,0,
		2030,2034,5,127,0,0,2031,2033,5,132,0,0,2032,2031,1,0,0,0,2033,2036,1,
		0,0,0,2034,2032,1,0,0,0,2034,2035,1,0,0,0,2035,2037,1,0,0,0,2036,2034,
		1,0,0,0,2037,2038,5,128,0,0,2038,323,1,0,0,0,2039,2051,5,125,0,0,2040,
		2045,3,272,136,0,2041,2042,5,132,0,0,2042,2044,3,272,136,0,2043,2041,1,
		0,0,0,2044,2047,1,0,0,0,2045,2043,1,0,0,0,2045,2046,1,0,0,0,2046,2049,
		1,0,0,0,2047,2045,1,0,0,0,2048,2050,5,132,0,0,2049,2048,1,0,0,0,2049,2050,
		1,0,0,0,2050,2052,1,0,0,0,2051,2040,1,0,0,0,2051,2052,1,0,0,0,2052,2053,
		1,0,0,0,2053,2054,5,126,0,0,2054,325,1,0,0,0,2055,2056,5,146,0,0,2056,
		2061,3,328,164,0,2057,2058,5,132,0,0,2058,2060,3,328,164,0,2059,2057,1,
		0,0,0,2060,2063,1,0,0,0,2061,2059,1,0,0,0,2061,2062,1,0,0,0,2062,2064,
		1,0,0,0,2063,2061,1,0,0,0,2064,2065,5,147,0,0,2065,327,1,0,0,0,2066,2068,
		3,350,175,0,2067,2066,1,0,0,0,2067,2068,1,0,0,0,2068,2070,1,0,0,0,2069,
		2071,3,330,165,0,2070,2069,1,0,0,0,2070,2071,1,0,0,0,2071,2072,1,0,0,0,
		2072,2073,3,434,217,0,2073,329,1,0,0,0,2074,2075,7,14,0,0,2075,331,1,0,
		0,0,2076,2077,5,133,0,0,2077,2078,3,236,118,0,2078,333,1,0,0,0,2079,2083,
		5,125,0,0,2080,2082,3,336,168,0,2081,2080,1,0,0,0,2082,2085,1,0,0,0,2083,
		2081,1,0,0,0,2083,2084,1,0,0,0,2084,2086,1,0,0,0,2085,2083,1,0,0,0,2086,
		2087,5,126,0,0,2087,335,1,0,0,0,2088,2090,3,350,175,0,2089,2088,1,0,0,
		0,2089,2090,1,0,0,0,2090,2092,1,0,0,0,2091,2093,5,66,0,0,2092,2091,1,0,
		0,0,2092,2093,1,0,0,0,2093,2157,1,0,0,0,2094,2096,5,103,0,0,2095,2094,
		1,0,0,0,2095,2096,1,0,0,0,2096,2102,1,0,0,0,2097,2103,5,80,0,0,2098,2099,
		5,80,0,0,2099,2103,5,79,0,0,2100,2101,5,79,0,0,2101,2103,5,80,0,0,2102,
		2097,1,0,0,0,2102,2098,1,0,0,0,2102,2100,1,0,0,0,2102,2103,1,0,0,0,2103,
		2104,1,0,0,0,2104,2132,3,4,2,0,2105,2107,3,434,217,0,2106,2108,3,230,115,
		0,2107,2106,1,0,0,0,2107,2108,1,0,0,0,2108,2109,1,0,0,0,2109,2111,5,129,
		0,0,2110,2112,3,280,140,0,2111,2110,1,0,0,0,2111,2112,1,0,0,0,2112,2113,
		1,0,0,0,2113,2115,5,130,0,0,2114,2116,3,238,119,0,2115,2114,1,0,0,0,2115,
		2116,1,0,0,0,2116,2117,1,0,0,0,2117,2118,5,134,0,0,2118,2133,1,0,0,0,2119,
		2120,3,434,217,0,2120,2121,5,125,0,0,2121,2122,3,338,169,0,2122,2123,5,
		126,0,0,2123,2133,1,0,0,0,2124,2125,5,94,0,0,2125,2126,5,127,0,0,2126,
		2127,3,280,140,0,2127,2128,5,128,0,0,2128,2129,5,125,0,0,2129,2130,3,338,
		169,0,2130,2131,5,126,0,0,2131,2133,1,0,0,0,2132,2105,1,0,0,0,2132,2119,
		1,0,0,0,2132,2124,1,0,0,0,2133,2158,1,0,0,0,2134,2136,5,103,0,0,2135,2134,
		1,0,0,0,2135,2136,1,0,0,0,2136,2137,1,0,0,0,2137,2138,5,108,0,0,2138,2140,
		3,434,217,0,2139,2141,3,230,115,0,2140,2139,1,0,0,0,2140,2141,1,0,0,0,
		2141,2142,1,0,0,0,2142,2144,5,129,0,0,2143,2145,3,280,140,0,2144,2143,
		1,0,0,0,2144,2145,1,0,0,0,2145,2146,1,0,0,0,2146,2148,5,130,0,0,2147,2149,
		3,238,119,0,2148,2147,1,0,0,0,2148,2149,1,0,0,0,2149,2150,1,0,0,0,2150,
		2151,5,134,0,0,2151,2158,1,0,0,0,2152,2153,5,39,0,0,2153,2154,3,4,2,0,
		2154,2155,3,434,217,0,2155,2156,5,134,0,0,2156,2158,1,0,0,0,2157,2095,
		1,0,0,0,2157,2135,1,0,0,0,2157,2152,1,0,0,0,2158,337,1,0,0,0,2159,2161,
		3,350,175,0,2160,2159,1,0,0,0,2160,2161,1,0,0,0,2161,2180,1,0,0,0,2162,
		2163,5,49,0,0,2163,2169,5,134,0,0,2164,2166,3,350,175,0,2165,2164,1,0,
		0,0,2165,2166,1,0,0,0,2166,2167,1,0,0,0,2167,2168,5,86,0,0,2168,2170,5,
		134,0,0,2169,2165,1,0,0,0,2169,2170,1,0,0,0,2170,2181,1,0,0,0,2171,2172,
		5,86,0,0,2172,2178,5,134,0,0,2173,2175,3,350,175,0,2174,2173,1,0,0,0,2174,
		2175,1,0,0,0,2175,2176,1,0,0,0,2176,2177,5,49,0,0,2177,2179,5,134,0,0,
		2178,2174,1,0,0,0,2178,2179,1,0,0,0,2179,2181,1,0,0,0,2180,2162,1,0,0,
		0,2180,2171,1,0,0,0,2181,339,1,0,0,0,2182,2183,5,133,0,0,2183,2184,3,4,
		2,0,2184,341,1,0,0,0,2185,2197,5,125,0,0,2186,2191,3,344,172,0,2187,2188,
		5,132,0,0,2188,2190,3,344,172,0,2189,2187,1,0,0,0,2190,2193,1,0,0,0,2191,
		2189,1,0,0,0,2191,2192,1,0,0,0,2192,2195,1,0,0,0,2193,2191,1,0,0,0,2194,
		2196,5,132,0,0,2195,2194,1,0,0,0,2195,2196,1,0,0,0,2196,2198,1,0,0,0,2197,
		2186,1,0,0,0,2197,2198,1,0,0,0,2198,2199,1,0,0,0,2199,2200,5,126,0,0,2200,
		343,1,0,0,0,2201,2203,3,350,175,0,2202,2201,1,0,0,0,2202,2203,1,0,0,0,
		2203,2204,1,0,0,0,2204,2207,3,434,217,0,2205,2206,5,145,0,0,2206,2208,
		3,28,14,0,2207,2205,1,0,0,0,2207,2208,1,0,0,0,2208,345,1,0,0,0,2209,2210,
		5,127,0,0,2210,2211,3,348,174,0,2211,2212,5,133,0,0,2212,2214,3,356,178,
		0,2213,2215,5,132,0,0,2214,2213,1,0,0,0,2214,2215,1,0,0,0,2215,2216,1,
		0,0,0,2216,2217,5,128,0,0,2217,347,1,0,0,0,2218,2221,3,396,198,0,2219,
		2221,3,434,217,0,2220,2218,1,0,0,0,2220,2219,1,0,0,0,2221,349,1,0,0,0,
		2222,2224,3,352,176,0,2223,2222,1,0,0,0,2224,2225,1,0,0,0,2225,2223,1,
		0,0,0,2225,2226,1,0,0,0,2226,351,1,0,0,0,2227,2231,5,127,0,0,2228,2229,
		3,354,177,0,2229,2230,5,133,0,0,2230,2232,1,0,0,0,2231,2228,1,0,0,0,2231,
		2232,1,0,0,0,2232,2233,1,0,0,0,2233,2235,3,356,178,0,2234,2236,5,132,0,
		0,2235,2234,1,0,0,0,2235,2236,1,0,0,0,2236,2237,1,0,0,0,2237,2238,5,128,
		0,0,2238,353,1,0,0,0,2239,2242,3,396,198,0,2240,2242,3,434,217,0,2241,
		2239,1,0,0,0,2241,2240,1,0,0,0,2242,355,1,0,0,0,2243,2248,3,358,179,0,
		2244,2245,5,132,0,0,2245,2247,3,358,179,0,2246,2244,1,0,0,0,2247,2250,
		1,0,0,0,2248,2246,1,0,0,0,2248,2249,1,0,0,0,2249,357,1,0,0,0,2250,2248,
		1,0,0,0,2251,2264,3,2,1,0,2252,2261,5,129,0,0,2253,2258,3,360,180,0,2254,
		2255,5,132,0,0,2255,2257,3,360,180,0,2256,2254,1,0,0,0,2257,2260,1,0,0,
		0,2258,2256,1,0,0,0,2258,2259,1,0,0,0,2259,2262,1,0,0,0,2260,2258,1,0,
		0,0,2261,2253,1,0,0,0,2261,2262,1,0,0,0,2262,2263,1,0,0,0,2263,2265,5,
		130,0,0,2264,2252,1,0,0,0,2264,2265,1,0,0,0,2265,359,1,0,0,0,2266,2267,
		3,434,217,0,2267,2268,5,133,0,0,2268,2270,1,0,0,0,2269,2266,1,0,0,0,2269,
		2270,1,0,0,0,2270,2271,1,0,0,0,2271,2272,3,28,14,0,2272,361,1,0,0,0,2273,
		2276,3,12,6,0,2274,2276,3,20,10,0,2275,2273,1,0,0,0,2275,2274,1,0,0,0,
		2276,2281,1,0,0,0,2277,2280,3,322,161,0,2278,2280,5,148,0,0,2279,2277,
		1,0,0,0,2279,2278,1,0,0,0,2280,2283,1,0,0,0,2281,2279,1,0,0,0,2281,2282,
		1,0,0,0,2282,2284,1,0,0,0,2283,2281,1,0,0,0,2284,2285,5,137,0,0,2285,2289,
		1,0,0,0,2286,2287,5,108,0,0,2287,2289,5,137,0,0,2288,2275,1,0,0,0,2288,
		2286,1,0,0,0,2289,363,1,0,0,0,2290,2295,3,366,183,0,2291,2292,5,132,0,
		0,2292,2294,3,366,183,0,2293,2291,1,0,0,0,2294,2297,1,0,0,0,2295,2293,
		1,0,0,0,2295,2296,1,0,0,0,2296,365,1,0,0,0,2297,2295,1,0,0,0,2298,2299,
		3,434,217,0,2299,2300,5,145,0,0,2300,2301,3,368,184,0,2301,367,1,0,0,0,
		2302,2304,5,140,0,0,2303,2302,1,0,0,0,2303,2304,1,0,0,0,2304,2305,1,0,
		0,0,2305,2308,3,28,14,0,2306,2308,3,372,186,0,2307,2303,1,0,0,0,2307,2306,
		1,0,0,0,2308,369,1,0,0,0,2309,2310,3,434,217,0,2310,2311,5,127,0,0,2311,
		2312,3,28,14,0,2312,2313,5,128,0,0,2313,371,1,0,0,0,2314,2315,5,89,0,0,
		2315,2316,3,4,2,0,2316,2317,5,127,0,0,2317,2318,3,28,14,0,2318,2319,5,
		128,0,0,2319,2344,1,0,0,0,2320,2322,5,89,0,0,2321,2323,3,4,2,0,2322,2321,
		1,0,0,0,2322,2323,1,0,0,0,2323,2324,1,0,0,0,2324,2326,5,127,0,0,2325,2327,
		3,28,14,0,2326,2325,1,0,0,0,2326,2327,1,0,0,0,2327,2328,1,0,0,0,2328,2329,
		5,128,0,0,2329,2330,5,125,0,0,2330,2335,3,28,14,0,2331,2332,5,132,0,0,
		2332,2334,3,28,14,0,2333,2331,1,0,0,0,2334,2337,1,0,0,0,2335,2333,1,0,
		0,0,2335,2336,1,0,0,0,2336,2339,1,0,0,0,2337,2335,1,0,0,0,2338,2340,5,
		132,0,0,2339,2338,1,0,0,0,2339,2340,1,0,0,0,2340,2341,1,0,0,0,2341,2342,
		5,126,0,0,2342,2344,1,0,0,0,2343,2314,1,0,0,0,2343,2320,1,0,0,0,2344,373,
		1,0,0,0,2345,2346,5,145,0,0,2346,2347,5,147,0,0,2347,2348,4,187,1,1,2348,
		375,1,0,0,0,2349,2350,5,147,0,0,2350,2351,5,147,0,0,2351,2352,4,188,2,
		1,2352,377,1,0,0,0,2353,2354,5,147,0,0,2354,2355,5,159,0,0,2355,2356,4,
		189,3,1,2356,379,1,0,0,0,2357,2366,3,382,191,0,2358,2366,3,384,192,0,2359,
		2366,5,116,0,0,2360,2366,5,117,0,0,2361,2366,5,118,0,0,2362,2366,5,119,
		0,0,2363,2366,5,120,0,0,2364,2366,5,67,0,0,2365,2357,1,0,0,0,2365,2358,
		1,0,0,0,2365,2359,1,0,0,0,2365,2360,1,0,0,0,2365,2361,1,0,0,0,2365,2362,
		1,0,0,0,2365,2363,1,0,0,0,2365,2364,1,0,0,0,2366,381,1,0,0,0,2367,2368,
		7,15,0,0,2368,383,1,0,0,0,2369,2374,3,386,193,0,2370,2374,3,388,194,0,
		2371,2374,5,121,0,0,2372,2374,5,122,0,0,2373,2369,1,0,0,0,2373,2370,1,
		0,0,0,2373,2371,1,0,0,0,2373,2372,1,0,0,0,2374,385,1,0,0,0,2375,2379,5,
		123,0,0,2376,2378,3,390,195,0,2377,2376,1,0,0,0,2378,2381,1,0,0,0,2379,
		2377,1,0,0,0,2379,2380,1,0,0,0,2380,2382,1,0,0,0,2381,2379,1,0,0,0,2382,
		2383,5,176,0,0,2383,387,1,0,0,0,2384,2388,5,124,0,0,2385,2387,3,392,196,
		0,2386,2385,1,0,0,0,2387,2390,1,0,0,0,2388,2386,1,0,0,0,2388,2389,1,0,
		0,0,2389,2391,1,0,0,0,2390,2388,1,0,0,0,2391,2392,5,176,0,0,2392,389,1,
		0,0,0,2393,2398,3,394,197,0,2394,2398,5,172,0,0,2395,2398,5,174,0,0,2396,
		2398,5,177,0,0,2397,2393,1,0,0,0,2397,2394,1,0,0,0,2397,2395,1,0,0,0,2397,
		2396,1,0,0,0,2398,391,1,0,0,0,2399,2404,3,394,197,0,2400,2404,5,172,0,
		0,2401,2404,5,175,0,0,2402,2404,5,178,0,0,2403,2399,1,0,0,0,2403,2400,
		1,0,0,0,2403,2401,1,0,0,0,2403,2402,1,0,0,0,2404,393,1,0,0,0,2405,2410,
		3,28,14,0,2406,2407,5,132,0,0,2407,2409,3,28,14,0,2408,2406,1,0,0,0,2409,
		2412,1,0,0,0,2410,2408,1,0,0,0,2410,2411,1,0,0,0,2411,2419,1,0,0,0,2412,
		2410,1,0,0,0,2413,2415,5,133,0,0,2414,2416,5,180,0,0,2415,2414,1,0,0,0,
		2416,2417,1,0,0,0,2417,2415,1,0,0,0,2417,2418,1,0,0,0,2418,2420,1,0,0,
		0,2419,2413,1,0,0,0,2419,2420,1,0,0,0,2420,395,1,0,0,0,2421,2422,7,16,
		0,0,2422,397,1,0,0,0,2423,2424,5,26,0,0,2424,2426,3,434,217,0,2425,2427,
		3,230,115,0,2426,2425,1,0,0,0,2426,2427,1,0,0,0,2427,2429,1,0,0,0,2428,
		2430,3,234,117,0,2429,2428,1,0,0,0,2429,2430,1,0,0,0,2430,2432,1,0,0,0,
		2431,2433,3,238,119,0,2432,2431,1,0,0,0,2432,2433,1,0,0,0,2433,2434,1,
		0,0,0,2434,2436,3,250,125,0,2435,2437,5,134,0,0,2436,2435,1,0,0,0,2436,
		2437,1,0,0,0,2437,399,1,0,0,0,2438,2440,7,17,0,0,2439,2438,1,0,0,0,2439,
		2440,1,0,0,0,2440,2441,1,0,0,0,2441,2442,5,92,0,0,2442,2444,3,434,217,
		0,2443,2445,3,230,115,0,2444,2443,1,0,0,0,2444,2445,1,0,0,0,2445,2447,
		1,0,0,0,2446,2448,3,314,157,0,2447,2446,1,0,0,0,2447,2448,1,0,0,0,2448,
		2450,1,0,0,0,2449,2451,3,238,119,0,2450,2449,1,0,0,0,2450,2451,1,0,0,0,
		2451,2452,1,0,0,0,2452,2454,3,316,158,0,2453,2455,5,134,0,0,2454,2453,
		1,0,0,0,2454,2455,1,0,0,0,2455,401,1,0,0,0,2456,2457,5,56,0,0,2457,2459,
		3,434,217,0,2458,2460,3,326,163,0,2459,2458,1,0,0,0,2459,2460,1,0,0,0,
		2460,2462,1,0,0,0,2461,2463,3,332,166,0,2462,2461,1,0,0,0,2462,2463,1,
		0,0,0,2463,2465,1,0,0,0,2464,2466,3,238,119,0,2465,2464,1,0,0,0,2465,2466,
		1,0,0,0,2466,2467,1,0,0,0,2467,2469,3,250,125,0,2468,2470,5,134,0,0,2469,
		2468,1,0,0,0,2469,2470,1,0,0,0,2470,403,1,0,0,0,2471,2472,5,37,0,0,2472,
		2474,3,434,217,0,2473,2475,3,340,170,0,2474,2473,1,0,0,0,2474,2475,1,0,
		0,0,2475,2476,1,0,0,0,2476,2478,3,342,171,0,2477,2479,5,134,0,0,2478,2477,
		1,0,0,0,2478,2479,1,0,0,0,2479,405,1,0,0,0,2480,2481,5,31,0,0,2481,2482,
		3,274,137,0,2482,2484,3,434,217,0,2483,2485,3,326,163,0,2484,2483,1,0,
		0,0,2484,2485,1,0,0,0,2485,2486,1,0,0,0,2486,2488,5,129,0,0,2487,2489,
		3,280,140,0,2488,2487,1,0,0,0,2488,2489,1,0,0,0,2489,2490,1,0,0,0,2490,
		2492,5,130,0,0,2491,2493,3,238,119,0,2492,2491,1,0,0,0,2492,2493,1,0,0,
		0,2493,2494,1,0,0,0,2494,2495,5,134,0,0,2495,407,1,0,0,0,2496,2497,5,39,
		0,0,2497,2506,3,4,2,0,2498,2499,3,268,134,0,2499,2500,5,134,0,0,2500,2507,
		1,0,0,0,2501,2502,3,276,138,0,2502,2503,5,125,0,0,2503,2504,3,300,150,
		0,2504,2505,5,126,0,0,2505,2507,1,0,0,0,2506,2498,1,0,0,0,2506,2501,1,
		0,0,0,2507,409,1,0,0,0,2508,2509,3,268,134,0,2509,2510,5,134,0,0,2510,
		411,1,0,0,0,2511,2525,3,276,138,0,2512,2513,5,125,0,0,2513,2514,3,290,
		145,0,2514,2519,5,126,0,0,2515,2516,5,145,0,0,2516,2517,3,272,136,0,2517,
		2518,5,134,0,0,2518,2520,1,0,0,0,2519,2515,1,0,0,0,2519,2520,1,0,0,0,2520,
		2526,1,0,0,0,2521,2522,3,374,187,0,2522,2523,3,74,37,0,2523,2524,5,134,
		0,0,2524,2526,1,0,0,0,2525,2512,1,0,0,0,2525,2521,1,0,0,0,2526,413,1,0,
		0,0,2527,2528,5,27,0,0,2528,2529,3,4,2,0,2529,2530,3,264,132,0,2530,2531,
		5,134,0,0,2531,415,1,0,0,0,2532,2533,5,94,0,0,2533,2534,5,127,0,0,2534,
		2535,3,280,140,0,2535,2544,5,128,0,0,2536,2537,5,125,0,0,2537,2538,3,290,
		145,0,2538,2539,5,126,0,0,2539,2545,1,0,0,0,2540,2541,3,374,187,0,2541,
		2542,3,74,37,0,2542,2543,5,134,0,0,2543,2545,1,0,0,0,2544,2536,1,0,0,0,
		2544,2540,1,0,0,0,2545,417,1,0,0,0,2546,2547,5,144,0,0,2547,2548,3,434,
		217,0,2548,2549,5,129,0,0,2549,2550,5,130,0,0,2550,2551,3,312,156,0,2551,
		419,1,0,0,0,2552,2553,3,434,217,0,2553,2555,5,129,0,0,2554,2556,3,280,
		140,0,2555,2554,1,0,0,0,2555,2556,1,0,0,0,2556,2557,1,0,0,0,2557,2559,
		5,130,0,0,2558,2560,3,310,155,0,2559,2558,1,0,0,0,2559,2560,1,0,0,0,2560,
		2561,1,0,0,0,2561,2562,3,312,156,0,2562,421,1,0,0,0,2563,2565,3,424,212,
		0,2564,2566,3,230,115,0,2565,2564,1,0,0,0,2565,2566,1,0,0,0,2566,2567,
		1,0,0,0,2567,2569,5,129,0,0,2568,2570,3,280,140,0,2569,2568,1,0,0,0,2569,
		2570,1,0,0,0,2570,2571,1,0,0,0,2571,2573,5,130,0,0,2572,2574,3,238,119,
		0,2573,2572,1,0,0,0,2573,2574,1,0,0,0,2574,2580,1,0,0,0,2575,2581,3,278,
		139,0,2576,2577,3,374,187,0,2577,2578,3,74,37,0,2578,2579,5,134,0,0,2579,
		2581,1,0,0,0,2580,2575,1,0,0,0,2580,2576,1,0,0,0,2581,423,1,0,0,0,2582,
		2588,3,434,217,0,2583,2584,3,434,217,0,2584,2585,5,149,0,0,2585,2586,3,
		434,217,0,2586,2588,1,0,0,0,2587,2582,1,0,0,0,2587,2583,1,0,0,0,2588,2596,
		1,0,0,0,2589,2591,3,22,11,0,2590,2589,1,0,0,0,2590,2591,1,0,0,0,2591,2592,
		1,0,0,0,2592,2593,5,131,0,0,2593,2595,3,434,217,0,2594,2590,1,0,0,0,2595,
		2598,1,0,0,0,2596,2594,1,0,0,0,2596,2597,1,0,0,0,2597,425,1,0,0,0,2598,
		2596,1,0,0,0,2599,2600,5,70,0,0,2600,2601,3,306,153,0,2601,2603,5,129,
		0,0,2602,2604,5,54,0,0,2603,2602,1,0,0,0,2603,2604,1,0,0,0,2604,2605,1,
		0,0,0,2605,2611,3,428,214,0,2606,2608,5,132,0,0,2607,2609,5,54,0,0,2608,
		2607,1,0,0,0,2608,2609,1,0,0,0,2609,2610,1,0,0,0,2610,2612,3,428,214,0,
		2611,2606,1,0,0,0,2611,2612,1,0,0,0,2612,2613,1,0,0,0,2613,2619,5,130,
		0,0,2614,2620,3,312,156,0,2615,2616,3,374,187,0,2616,2617,3,74,37,0,2617,
		2618,5,134,0,0,2618,2620,1,0,0,0,2619,2614,1,0,0,0,2619,2615,1,0,0,0,2620,
		427,1,0,0,0,2621,2622,3,4,2,0,2622,2625,3,434,217,0,2623,2624,5,145,0,
		0,2624,2626,3,28,14,0,2625,2623,1,0,0,0,2625,2626,1,0,0,0,2626,429,1,0,
		0,0,2627,2629,5,129,0,0,2628,2630,3,24,12,0,2629,2628,1,0,0,0,2629,2630,
		1,0,0,0,2630,2631,1,0,0,0,2631,2632,5,130,0,0,2632,431,1,0,0,0,2633,2635,
		5,129,0,0,2634,2636,3,24,12,0,2635,2634,1,0,0,0,2635,2636,1,0,0,0,2636,
		2637,1,0,0,0,2637,2639,5,130,0,0,2638,2640,3,88,44,0,2639,2638,1,0,0,0,
		2639,2640,1,0,0,0,2640,433,1,0,0,0,2641,2642,7,18,0,0,2642,435,1,0,0,0,
		344,437,440,443,448,452,458,461,466,470,477,479,487,495,501,505,510,520,
		528,538,544,547,551,559,564,574,587,595,601,603,610,618,626,634,642,650,
		660,662,668,673,681,689,697,699,702,709,714,721,725,727,755,759,764,768,
		776,779,784,788,792,798,812,818,830,834,839,843,849,857,866,884,887,892,
		895,910,916,920,926,931,934,942,950,961,966,971,973,982,990,997,1005,1009,
		1018,1023,1025,1034,1042,1046,1051,1053,1058,1062,1069,1077,1079,1083,
		1086,1089,1097,1107,1124,1131,1135,1145,1150,1157,1166,1171,1178,1190,
		1201,1209,1214,1223,1232,1241,1247,1252,1256,1260,1264,1268,1275,1283,
		1296,1306,1328,1332,1336,1341,1361,1366,1371,1378,1381,1403,1415,1419,
		1427,1437,1444,1448,1453,1456,1461,1469,1474,1481,1487,1495,1503,1506,
		1513,1520,1524,1527,1533,1537,1543,1557,1563,1570,1575,1578,1581,1588,
		1598,1615,1620,1624,1627,1630,1637,1643,1651,1657,1667,1675,1681,1692,
		1696,1698,1703,1707,1714,1723,1730,1733,1736,1740,1745,1758,1768,1775,
		1787,1794,1806,1812,1816,1820,1826,1832,1834,1841,1845,1848,1852,1862,
		1865,1872,1875,1880,1885,1887,1890,1893,1899,1902,1914,1918,1921,1931,
		1934,1940,1967,1980,1986,1995,2001,2004,2012,2016,2022,2028,2034,2045,
		2049,2051,2061,2067,2070,2083,2089,2092,2095,2102,2107,2111,2115,2132,
		2135,2140,2144,2148,2157,2160,2165,2169,2174,2178,2180,2191,2195,2197,
		2202,2207,2214,2220,2225,2231,2235,2241,2248,2258,2261,2264,2269,2275,
		2279,2281,2288,2295,2303,2307,2322,2326,2335,2339,2343,2365,2373,2379,
		2388,2397,2403,2410,2417,2419,2426,2429,2432,2436,2439,2444,2447,2450,
		2454,2459,2462,2465,2469,2474,2478,2484,2488,2492,2506,2519,2525,2544,
		2555,2559,2565,2569,2573,2580,2587,2590,2596,2603,2608,2611,2619,2625,
		2629,2635,2639
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
