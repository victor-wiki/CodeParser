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
public partial class SQLiteParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		SCOL=1, DOT=2, OPEN_PAR=3, CLOSE_PAR=4, COMMA=5, ASSIGN=6, STAR=7, PLUS=8, 
		MINUS=9, TILDE=10, PIPE2=11, DIV=12, MOD=13, LT2=14, GT2=15, AMP=16, PIPE=17, 
		LT=18, LT_EQ=19, GT=20, GT_EQ=21, EQ=22, NOT_EQ1=23, NOT_EQ2=24, ABORT_=25, 
		ACTION_=26, ADD_=27, AFTER_=28, ALL_=29, ALTER_=30, ANALYZE_=31, AND_=32, 
		AS_=33, ASC_=34, ATTACH_=35, AUTOINCREMENT_=36, BEFORE_=37, BEGIN_=38, 
		BETWEEN_=39, BY_=40, CASCADE_=41, CASE_=42, CAST_=43, CHECK_=44, COLLATE_=45, 
		COLUMN_=46, COMMIT_=47, CONFLICT_=48, CONSTRAINT_=49, CREATE_=50, CROSS_=51, 
		CURRENT_DATE_=52, CURRENT_TIME_=53, CURRENT_TIMESTAMP_=54, DATABASE_=55, 
		DEFAULT_=56, DEFERRABLE_=57, DEFERRED_=58, DELETE_=59, DESC_=60, DETACH_=61, 
		DISTINCT_=62, DROP_=63, EACH_=64, ELSE_=65, END_=66, ESCAPE_=67, EXCEPT_=68, 
		EXCLUSIVE_=69, EXISTS_=70, EXPLAIN_=71, FAIL_=72, FOR_=73, FOREIGN_=74, 
		FROM_=75, FULL_=76, GLOB_=77, GROUP_=78, HAVING_=79, IF_=80, IGNORE_=81, 
		IMMEDIATE_=82, IN_=83, INDEX_=84, INDEXED_=85, INITIALLY_=86, INNER_=87, 
		INSERT_=88, INSTEAD_=89, INTERSECT_=90, INTO_=91, IS_=92, ISNULL_=93, 
		JOIN_=94, KEY_=95, LEFT_=96, LIKE_=97, LIMIT_=98, MATCH_=99, NATURAL_=100, 
		NO_=101, NOT_=102, NOTNULL_=103, NULL_=104, OF_=105, OFFSET_=106, ON_=107, 
		OR_=108, ORDER_=109, OUTER_=110, PLAN_=111, PRAGMA_=112, PRIMARY_=113, 
		QUERY_=114, RAISE_=115, RECURSIVE_=116, REFERENCES_=117, REGEXP_=118, 
		REINDEX_=119, RELEASE_=120, RENAME_=121, REPLACE_=122, RESTRICT_=123, 
		RETURNING_=124, RIGHT_=125, ROLLBACK_=126, ROW_=127, ROWS_=128, SAVEPOINT_=129, 
		SELECT_=130, SET_=131, TABLE_=132, TEMP_=133, TEMPORARY_=134, THEN_=135, 
		TO_=136, TRANSACTION_=137, TRIGGER_=138, UNION_=139, UNIQUE_=140, UPDATE_=141, 
		USING_=142, VACUUM_=143, VALUES_=144, VIEW_=145, VIRTUAL_=146, WHEN_=147, 
		WHERE_=148, WITH_=149, WITHOUT_=150, FIRST_VALUE_=151, OVER_=152, PARTITION_=153, 
		RANGE_=154, PRECEDING_=155, UNBOUNDED_=156, CURRENT_=157, FOLLOWING_=158, 
		CUME_DIST_=159, DENSE_RANK_=160, LAG_=161, LAST_VALUE_=162, LEAD_=163, 
		NTH_VALUE_=164, NTILE_=165, PERCENT_RANK_=166, RANK_=167, ROW_NUMBER_=168, 
		GENERATED_=169, ALWAYS_=170, STORED_=171, TRUE_=172, FALSE_=173, WINDOW_=174, 
		NULLS_=175, FIRST_=176, LAST_=177, FILTER_=178, GROUPS_=179, EXCLUDE_=180, 
		TIES_=181, OTHERS_=182, DO_=183, NOTHING_=184, IDENTIFIER=185, NUMERIC_LITERAL=186, 
		BIND_PARAMETER=187, STRING_LITERAL=188, BLOB_LITERAL=189, SINGLE_LINE_COMMENT=190, 
		MULTILINE_COMMENT=191, SPACES=192, UNEXPECTED_CHAR=193;
	public const int
		RULE_parse = 0, RULE_sql_stmt_list = 1, RULE_sql_stmt = 2, RULE_alter_table_stmt = 3, 
		RULE_analyze_stmt = 4, RULE_attach_stmt = 5, RULE_begin_stmt = 6, RULE_commit_stmt = 7, 
		RULE_rollback_stmt = 8, RULE_savepoint_stmt = 9, RULE_release_stmt = 10, 
		RULE_create_index_stmt = 11, RULE_indexed_column = 12, RULE_create_table_stmt = 13, 
		RULE_column_def = 14, RULE_type_name = 15, RULE_column_constraint = 16, 
		RULE_signed_number = 17, RULE_table_constraint = 18, RULE_foreign_key_clause = 19, 
		RULE_conflict_clause = 20, RULE_create_trigger_stmt = 21, RULE_create_view_stmt = 22, 
		RULE_create_virtual_table_stmt = 23, RULE_with_clause = 24, RULE_cte_table_name = 25, 
		RULE_recursive_cte = 26, RULE_common_table_expression = 27, RULE_delete_stmt = 28, 
		RULE_delete_stmt_limited = 29, RULE_detach_stmt = 30, RULE_drop_stmt = 31, 
		RULE_expr = 32, RULE_raise_function = 33, RULE_literal_value = 34, RULE_insert_stmt = 35, 
		RULE_returning_clause = 36, RULE_upsert_clause = 37, RULE_pragma_stmt = 38, 
		RULE_pragma_value = 39, RULE_reindex_stmt = 40, RULE_select_stmt = 41, 
		RULE_join_clause = 42, RULE_select_core = 43, RULE_factored_select_stmt = 44, 
		RULE_simple_select_stmt = 45, RULE_compound_select_stmt = 46, RULE_table_or_subquery = 47, 
		RULE_result_column = 48, RULE_join_operator = 49, RULE_join_constraint = 50, 
		RULE_compound_operator = 51, RULE_update_stmt = 52, RULE_column_name_list = 53, 
		RULE_update_stmt_limited = 54, RULE_qualified_table_name = 55, RULE_vacuum_stmt = 56, 
		RULE_filter_clause = 57, RULE_window_defn = 58, RULE_over_clause = 59, 
		RULE_frame_spec = 60, RULE_frame_clause = 61, RULE_simple_function_invocation = 62, 
		RULE_aggregate_function_invocation = 63, RULE_window_function_invocation = 64, 
		RULE_common_table_stmt = 65, RULE_order_by_stmt = 66, RULE_limit_stmt = 67, 
		RULE_ordering_term = 68, RULE_asc_desc = 69, RULE_frame_left = 70, RULE_frame_right = 71, 
		RULE_frame_single = 72, RULE_window_function = 73, RULE_offset = 74, RULE_default_value = 75, 
		RULE_partition_by = 76, RULE_order_by_expr = 77, RULE_order_by_expr_asc_desc = 78, 
		RULE_expr_asc_desc = 79, RULE_initial_select = 80, RULE_recursive_select = 81, 
		RULE_unary_operator = 82, RULE_error_message = 83, RULE_module_argument = 84, 
		RULE_column_alias = 85, RULE_keyword = 86, RULE_name = 87, RULE_function_name = 88, 
		RULE_schema_name = 89, RULE_table_name = 90, RULE_table_or_index_name = 91, 
		RULE_column_name = 92, RULE_collation_name = 93, RULE_foreign_table = 94, 
		RULE_index_name = 95, RULE_trigger_name = 96, RULE_view_name = 97, RULE_module_name = 98, 
		RULE_pragma_name = 99, RULE_savepoint_name = 100, RULE_table_alias = 101, 
		RULE_transaction_name = 102, RULE_window_name = 103, RULE_alias = 104, 
		RULE_filename = 105, RULE_base_window_name = 106, RULE_simple_func = 107, 
		RULE_aggregate_func = 108, RULE_table_function_name = 109, RULE_any_name = 110;
	public static readonly string[] ruleNames = {
		"parse", "sql_stmt_list", "sql_stmt", "alter_table_stmt", "analyze_stmt", 
		"attach_stmt", "begin_stmt", "commit_stmt", "rollback_stmt", "savepoint_stmt", 
		"release_stmt", "create_index_stmt", "indexed_column", "create_table_stmt", 
		"column_def", "type_name", "column_constraint", "signed_number", "table_constraint", 
		"foreign_key_clause", "conflict_clause", "create_trigger_stmt", "create_view_stmt", 
		"create_virtual_table_stmt", "with_clause", "cte_table_name", "recursive_cte", 
		"common_table_expression", "delete_stmt", "delete_stmt_limited", "detach_stmt", 
		"drop_stmt", "expr", "raise_function", "literal_value", "insert_stmt", 
		"returning_clause", "upsert_clause", "pragma_stmt", "pragma_value", "reindex_stmt", 
		"select_stmt", "join_clause", "select_core", "factored_select_stmt", "simple_select_stmt", 
		"compound_select_stmt", "table_or_subquery", "result_column", "join_operator", 
		"join_constraint", "compound_operator", "update_stmt", "column_name_list", 
		"update_stmt_limited", "qualified_table_name", "vacuum_stmt", "filter_clause", 
		"window_defn", "over_clause", "frame_spec", "frame_clause", "simple_function_invocation", 
		"aggregate_function_invocation", "window_function_invocation", "common_table_stmt", 
		"order_by_stmt", "limit_stmt", "ordering_term", "asc_desc", "frame_left", 
		"frame_right", "frame_single", "window_function", "offset", "default_value", 
		"partition_by", "order_by_expr", "order_by_expr_asc_desc", "expr_asc_desc", 
		"initial_select", "recursive_select", "unary_operator", "error_message", 
		"module_argument", "column_alias", "keyword", "name", "function_name", 
		"schema_name", "table_name", "table_or_index_name", "column_name", "collation_name", 
		"foreign_table", "index_name", "trigger_name", "view_name", "module_name", 
		"pragma_name", "savepoint_name", "table_alias", "transaction_name", "window_name", 
		"alias", "filename", "base_window_name", "simple_func", "aggregate_func", 
		"table_function_name", "any_name"
	};

	private static readonly string[] _LiteralNames = {
		null, "';'", "'.'", "'('", "')'", "','", "'='", "'*'", "'+'", "'-'", "'~'", 
		"'||'", "'/'", "'%'", "'<<'", "'>>'", "'&'", "'|'", "'<'", "'<='", "'>'", 
		"'>='", "'=='", "'!='", "'<>'", "'ABORT'", "'ACTION'", "'ADD'", "'AFTER'", 
		"'ALL'", "'ALTER'", "'ANALYZE'", "'AND'", "'AS'", "'ASC'", "'ATTACH'", 
		"'AUTOINCREMENT'", "'BEFORE'", "'BEGIN'", "'BETWEEN'", "'BY'", "'CASCADE'", 
		"'CASE'", "'CAST'", "'CHECK'", "'COLLATE'", "'COLUMN'", "'COMMIT'", "'CONFLICT'", 
		"'CONSTRAINT'", "'CREATE'", "'CROSS'", "'CURRENT_DATE'", "'CURRENT_TIME'", 
		"'CURRENT_TIMESTAMP'", "'DATABASE'", "'DEFAULT'", "'DEFERRABLE'", "'DEFERRED'", 
		"'DELETE'", "'DESC'", "'DETACH'", "'DISTINCT'", "'DROP'", "'EACH'", "'ELSE'", 
		"'END'", "'ESCAPE'", "'EXCEPT'", "'EXCLUSIVE'", "'EXISTS'", "'EXPLAIN'", 
		"'FAIL'", "'FOR'", "'FOREIGN'", "'FROM'", "'FULL'", "'GLOB'", "'GROUP'", 
		"'HAVING'", "'IF'", "'IGNORE'", "'IMMEDIATE'", "'IN'", "'INDEX'", "'INDEXED'", 
		"'INITIALLY'", "'INNER'", "'INSERT'", "'INSTEAD'", "'INTERSECT'", "'INTO'", 
		"'IS'", "'ISNULL'", "'JOIN'", "'KEY'", "'LEFT'", "'LIKE'", "'LIMIT'", 
		"'MATCH'", "'NATURAL'", "'NO'", "'NOT'", "'NOTNULL'", "'NULL'", "'OF'", 
		"'OFFSET'", "'ON'", "'OR'", "'ORDER'", "'OUTER'", "'PLAN'", "'PRAGMA'", 
		"'PRIMARY'", "'QUERY'", "'RAISE'", "'RECURSIVE'", "'REFERENCES'", "'REGEXP'", 
		"'REINDEX'", "'RELEASE'", "'RENAME'", "'REPLACE'", "'RESTRICT'", "'RETURNING'", 
		"'RIGHT'", "'ROLLBACK'", "'ROW'", "'ROWS'", "'SAVEPOINT'", "'SELECT'", 
		"'SET'", "'TABLE'", "'TEMP'", "'TEMPORARY'", "'THEN'", "'TO'", "'TRANSACTION'", 
		"'TRIGGER'", "'UNION'", "'UNIQUE'", "'UPDATE'", "'USING'", "'VACUUM'", 
		"'VALUES'", "'VIEW'", "'VIRTUAL'", "'WHEN'", "'WHERE'", "'WITH'", "'WITHOUT'", 
		"'FIRST_VALUE'", "'OVER'", "'PARTITION'", "'RANGE'", "'PRECEDING'", "'UNBOUNDED'", 
		"'CURRENT'", "'FOLLOWING'", "'CUME_DIST'", "'DENSE_RANK'", "'LAG'", "'LAST_VALUE'", 
		"'LEAD'", "'NTH_VALUE'", "'NTILE'", "'PERCENT_RANK'", "'RANK'", "'ROW_NUMBER'", 
		"'GENERATED'", "'ALWAYS'", "'STORED'", "'TRUE'", "'FALSE'", "'WINDOW'", 
		"'NULLS'", "'FIRST'", "'LAST'", "'FILTER'", "'GROUPS'", "'EXCLUDE'", "'TIES'", 
		"'OTHERS'", "'DO'", "'NOTHING'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "SCOL", "DOT", "OPEN_PAR", "CLOSE_PAR", "COMMA", "ASSIGN", "STAR", 
		"PLUS", "MINUS", "TILDE", "PIPE2", "DIV", "MOD", "LT2", "GT2", "AMP", 
		"PIPE", "LT", "LT_EQ", "GT", "GT_EQ", "EQ", "NOT_EQ1", "NOT_EQ2", "ABORT_", 
		"ACTION_", "ADD_", "AFTER_", "ALL_", "ALTER_", "ANALYZE_", "AND_", "AS_", 
		"ASC_", "ATTACH_", "AUTOINCREMENT_", "BEFORE_", "BEGIN_", "BETWEEN_", 
		"BY_", "CASCADE_", "CASE_", "CAST_", "CHECK_", "COLLATE_", "COLUMN_", 
		"COMMIT_", "CONFLICT_", "CONSTRAINT_", "CREATE_", "CROSS_", "CURRENT_DATE_", 
		"CURRENT_TIME_", "CURRENT_TIMESTAMP_", "DATABASE_", "DEFAULT_", "DEFERRABLE_", 
		"DEFERRED_", "DELETE_", "DESC_", "DETACH_", "DISTINCT_", "DROP_", "EACH_", 
		"ELSE_", "END_", "ESCAPE_", "EXCEPT_", "EXCLUSIVE_", "EXISTS_", "EXPLAIN_", 
		"FAIL_", "FOR_", "FOREIGN_", "FROM_", "FULL_", "GLOB_", "GROUP_", "HAVING_", 
		"IF_", "IGNORE_", "IMMEDIATE_", "IN_", "INDEX_", "INDEXED_", "INITIALLY_", 
		"INNER_", "INSERT_", "INSTEAD_", "INTERSECT_", "INTO_", "IS_", "ISNULL_", 
		"JOIN_", "KEY_", "LEFT_", "LIKE_", "LIMIT_", "MATCH_", "NATURAL_", "NO_", 
		"NOT_", "NOTNULL_", "NULL_", "OF_", "OFFSET_", "ON_", "OR_", "ORDER_", 
		"OUTER_", "PLAN_", "PRAGMA_", "PRIMARY_", "QUERY_", "RAISE_", "RECURSIVE_", 
		"REFERENCES_", "REGEXP_", "REINDEX_", "RELEASE_", "RENAME_", "REPLACE_", 
		"RESTRICT_", "RETURNING_", "RIGHT_", "ROLLBACK_", "ROW_", "ROWS_", "SAVEPOINT_", 
		"SELECT_", "SET_", "TABLE_", "TEMP_", "TEMPORARY_", "THEN_", "TO_", "TRANSACTION_", 
		"TRIGGER_", "UNION_", "UNIQUE_", "UPDATE_", "USING_", "VACUUM_", "VALUES_", 
		"VIEW_", "VIRTUAL_", "WHEN_", "WHERE_", "WITH_", "WITHOUT_", "FIRST_VALUE_", 
		"OVER_", "PARTITION_", "RANGE_", "PRECEDING_", "UNBOUNDED_", "CURRENT_", 
		"FOLLOWING_", "CUME_DIST_", "DENSE_RANK_", "LAG_", "LAST_VALUE_", "LEAD_", 
		"NTH_VALUE_", "NTILE_", "PERCENT_RANK_", "RANK_", "ROW_NUMBER_", "GENERATED_", 
		"ALWAYS_", "STORED_", "TRUE_", "FALSE_", "WINDOW_", "NULLS_", "FIRST_", 
		"LAST_", "FILTER_", "GROUPS_", "EXCLUDE_", "TIES_", "OTHERS_", "DO_", 
		"NOTHING_", "IDENTIFIER", "NUMERIC_LITERAL", "BIND_PARAMETER", "STRING_LITERAL", 
		"BLOB_LITERAL", "SINGLE_LINE_COMMENT", "MULTILINE_COMMENT", "SPACES", 
		"UNEXPECTED_CHAR"
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

	public override string GrammarFileName { get { return "SQLiteParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static SQLiteParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public SQLiteParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public SQLiteParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ParseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(SQLiteParser.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Sql_stmt_listContext[] sql_stmt_list() {
			return GetRuleContexts<Sql_stmt_listContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Sql_stmt_listContext sql_stmt_list(int i) {
			return GetRuleContext<Sql_stmt_listContext>(i);
		}
		public ParseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parse; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterParse(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitParse(this);
		}
	}

	[RuleVersion(0)]
	public ParseContext parse() {
		ParseContext _localctx = new ParseContext(Context, State);
		EnterRule(_localctx, 0, RULE_parse);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 225;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << SCOL) | (1L << ALTER_) | (1L << ANALYZE_) | (1L << ATTACH_) | (1L << BEGIN_) | (1L << COMMIT_) | (1L << CREATE_) | (1L << DELETE_) | (1L << DETACH_) | (1L << DROP_))) != 0) || ((((_la - 66)) & ~0x3f) == 0 && ((1L << (_la - 66)) & ((1L << (END_ - 66)) | (1L << (EXPLAIN_ - 66)) | (1L << (INSERT_ - 66)) | (1L << (PRAGMA_ - 66)) | (1L << (REINDEX_ - 66)) | (1L << (RELEASE_ - 66)) | (1L << (REPLACE_ - 66)) | (1L << (ROLLBACK_ - 66)) | (1L << (SAVEPOINT_ - 66)))) != 0) || ((((_la - 130)) & ~0x3f) == 0 && ((1L << (_la - 130)) & ((1L << (SELECT_ - 130)) | (1L << (UPDATE_ - 130)) | (1L << (VACUUM_ - 130)) | (1L << (VALUES_ - 130)) | (1L << (WITH_ - 130)))) != 0)) {
				{
				{
				State = 222;
				sql_stmt_list();
				}
				}
				State = 227;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 228;
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

	public partial class Sql_stmt_listContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Sql_stmtContext[] sql_stmt() {
			return GetRuleContexts<Sql_stmtContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Sql_stmtContext sql_stmt(int i) {
			return GetRuleContext<Sql_stmtContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SCOL() { return GetTokens(SQLiteParser.SCOL); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SCOL(int i) {
			return GetToken(SQLiteParser.SCOL, i);
		}
		public Sql_stmt_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_sql_stmt_list; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterSql_stmt_list(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitSql_stmt_list(this);
		}
	}

	[RuleVersion(0)]
	public Sql_stmt_listContext sql_stmt_list() {
		Sql_stmt_listContext _localctx = new Sql_stmt_listContext(Context, State);
		EnterRule(_localctx, 2, RULE_sql_stmt_list);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 233;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==SCOL) {
				{
				{
				State = 230;
				Match(SCOL);
				}
				}
				State = 235;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 236;
			sql_stmt();
			State = 245;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,3,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 238;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					do {
						{
						{
						State = 237;
						Match(SCOL);
						}
						}
						State = 240;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					} while ( _la==SCOL );
					State = 242;
					sql_stmt();
					}
					} 
				}
				State = 247;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,3,Context);
			}
			State = 251;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 248;
					Match(SCOL);
					}
					} 
				}
				State = 253;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
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

	public partial class Sql_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Alter_table_stmtContext alter_table_stmt() {
			return GetRuleContext<Alter_table_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Analyze_stmtContext analyze_stmt() {
			return GetRuleContext<Analyze_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Attach_stmtContext attach_stmt() {
			return GetRuleContext<Attach_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Begin_stmtContext begin_stmt() {
			return GetRuleContext<Begin_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Commit_stmtContext commit_stmt() {
			return GetRuleContext<Commit_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Create_index_stmtContext create_index_stmt() {
			return GetRuleContext<Create_index_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Create_table_stmtContext create_table_stmt() {
			return GetRuleContext<Create_table_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Create_trigger_stmtContext create_trigger_stmt() {
			return GetRuleContext<Create_trigger_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Create_view_stmtContext create_view_stmt() {
			return GetRuleContext<Create_view_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Create_virtual_table_stmtContext create_virtual_table_stmt() {
			return GetRuleContext<Create_virtual_table_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Delete_stmtContext delete_stmt() {
			return GetRuleContext<Delete_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Delete_stmt_limitedContext delete_stmt_limited() {
			return GetRuleContext<Delete_stmt_limitedContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Detach_stmtContext detach_stmt() {
			return GetRuleContext<Detach_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Drop_stmtContext drop_stmt() {
			return GetRuleContext<Drop_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Insert_stmtContext insert_stmt() {
			return GetRuleContext<Insert_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Pragma_stmtContext pragma_stmt() {
			return GetRuleContext<Pragma_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Reindex_stmtContext reindex_stmt() {
			return GetRuleContext<Reindex_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Release_stmtContext release_stmt() {
			return GetRuleContext<Release_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Rollback_stmtContext rollback_stmt() {
			return GetRuleContext<Rollback_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Savepoint_stmtContext savepoint_stmt() {
			return GetRuleContext<Savepoint_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Select_stmtContext select_stmt() {
			return GetRuleContext<Select_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Update_stmtContext update_stmt() {
			return GetRuleContext<Update_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Update_stmt_limitedContext update_stmt_limited() {
			return GetRuleContext<Update_stmt_limitedContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Vacuum_stmtContext vacuum_stmt() {
			return GetRuleContext<Vacuum_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXPLAIN_() { return GetToken(SQLiteParser.EXPLAIN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode QUERY_() { return GetToken(SQLiteParser.QUERY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PLAN_() { return GetToken(SQLiteParser.PLAN_, 0); }
		public Sql_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_sql_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterSql_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitSql_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Sql_stmtContext sql_stmt() {
		Sql_stmtContext _localctx = new Sql_stmtContext(Context, State);
		EnterRule(_localctx, 4, RULE_sql_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 259;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==EXPLAIN_) {
				{
				State = 254;
				Match(EXPLAIN_);
				State = 257;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==QUERY_) {
					{
					State = 255;
					Match(QUERY_);
					State = 256;
					Match(PLAN_);
					}
				}

				}
			}

			State = 285;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,7,Context) ) {
			case 1:
				{
				State = 261;
				alter_table_stmt();
				}
				break;
			case 2:
				{
				State = 262;
				analyze_stmt();
				}
				break;
			case 3:
				{
				State = 263;
				attach_stmt();
				}
				break;
			case 4:
				{
				State = 264;
				begin_stmt();
				}
				break;
			case 5:
				{
				State = 265;
				commit_stmt();
				}
				break;
			case 6:
				{
				State = 266;
				create_index_stmt();
				}
				break;
			case 7:
				{
				State = 267;
				create_table_stmt();
				}
				break;
			case 8:
				{
				State = 268;
				create_trigger_stmt();
				}
				break;
			case 9:
				{
				State = 269;
				create_view_stmt();
				}
				break;
			case 10:
				{
				State = 270;
				create_virtual_table_stmt();
				}
				break;
			case 11:
				{
				State = 271;
				delete_stmt();
				}
				break;
			case 12:
				{
				State = 272;
				delete_stmt_limited();
				}
				break;
			case 13:
				{
				State = 273;
				detach_stmt();
				}
				break;
			case 14:
				{
				State = 274;
				drop_stmt();
				}
				break;
			case 15:
				{
				State = 275;
				insert_stmt();
				}
				break;
			case 16:
				{
				State = 276;
				pragma_stmt();
				}
				break;
			case 17:
				{
				State = 277;
				reindex_stmt();
				}
				break;
			case 18:
				{
				State = 278;
				release_stmt();
				}
				break;
			case 19:
				{
				State = 279;
				rollback_stmt();
				}
				break;
			case 20:
				{
				State = 280;
				savepoint_stmt();
				}
				break;
			case 21:
				{
				State = 281;
				select_stmt();
				}
				break;
			case 22:
				{
				State = 282;
				update_stmt();
				}
				break;
			case 23:
				{
				State = 283;
				update_stmt_limited();
				}
				break;
			case 24:
				{
				State = 284;
				vacuum_stmt();
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

	public partial class Alter_table_stmtContext : ParserRuleContext {
		public Table_nameContext new_table_name;
		public Column_nameContext old_column_name;
		public Column_nameContext new_column_name;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ALTER_() { return GetToken(SQLiteParser.ALTER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TABLE_() { return GetToken(SQLiteParser.TABLE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Table_nameContext[] table_name() {
			return GetRuleContexts<Table_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Table_nameContext table_name(int i) {
			return GetRuleContext<Table_nameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RENAME_() { return GetToken(SQLiteParser.RENAME_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ADD_() { return GetToken(SQLiteParser.ADD_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Column_defContext column_def() {
			return GetRuleContext<Column_defContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DROP_() { return GetToken(SQLiteParser.DROP_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext[] column_name() {
			return GetRuleContexts<Column_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext column_name(int i) {
			return GetRuleContext<Column_nameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Schema_nameContext schema_name() {
			return GetRuleContext<Schema_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(SQLiteParser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TO_() { return GetToken(SQLiteParser.TO_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLUMN_() { return GetToken(SQLiteParser.COLUMN_, 0); }
		public Alter_table_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_alter_table_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterAlter_table_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitAlter_table_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Alter_table_stmtContext alter_table_stmt() {
		Alter_table_stmtContext _localctx = new Alter_table_stmtContext(Context, State);
		EnterRule(_localctx, 6, RULE_alter_table_stmt);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 287;
			Match(ALTER_);
			State = 288;
			Match(TABLE_);
			State = 292;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,8,Context) ) {
			case 1:
				{
				State = 289;
				schema_name();
				State = 290;
				Match(DOT);
				}
				break;
			}
			State = 294;
			table_name();
			State = 317;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case RENAME_:
				{
				State = 295;
				Match(RENAME_);
				State = 305;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,10,Context) ) {
				case 1:
					{
					State = 296;
					Match(TO_);
					State = 297;
					_localctx.new_table_name = table_name();
					}
					break;
				case 2:
					{
					State = 299;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,9,Context) ) {
					case 1:
						{
						State = 298;
						Match(COLUMN_);
						}
						break;
					}
					State = 301;
					_localctx.old_column_name = column_name();
					State = 302;
					Match(TO_);
					State = 303;
					_localctx.new_column_name = column_name();
					}
					break;
				}
				}
				break;
			case ADD_:
				{
				State = 307;
				Match(ADD_);
				State = 309;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,11,Context) ) {
				case 1:
					{
					State = 308;
					Match(COLUMN_);
					}
					break;
				}
				State = 311;
				column_def();
				}
				break;
			case DROP_:
				{
				State = 312;
				Match(DROP_);
				State = 314;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,12,Context) ) {
				case 1:
					{
					State = 313;
					Match(COLUMN_);
					}
					break;
				}
				State = 316;
				column_name();
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

	public partial class Analyze_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ANALYZE_() { return GetToken(SQLiteParser.ANALYZE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Schema_nameContext schema_name() {
			return GetRuleContext<Schema_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Table_or_index_nameContext table_or_index_name() {
			return GetRuleContext<Table_or_index_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(SQLiteParser.DOT, 0); }
		public Analyze_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_analyze_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterAnalyze_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitAnalyze_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Analyze_stmtContext analyze_stmt() {
		Analyze_stmtContext _localctx = new Analyze_stmtContext(Context, State);
		EnterRule(_localctx, 8, RULE_analyze_stmt);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 319;
			Match(ANALYZE_);
			State = 327;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,15,Context) ) {
			case 1:
				{
				State = 320;
				schema_name();
				}
				break;
			case 2:
				{
				State = 324;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,14,Context) ) {
				case 1:
					{
					State = 321;
					schema_name();
					State = 322;
					Match(DOT);
					}
					break;
				}
				State = 326;
				table_or_index_name();
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

	public partial class Attach_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ATTACH_() { return GetToken(SQLiteParser.ATTACH_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AS_() { return GetToken(SQLiteParser.AS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Schema_nameContext schema_name() {
			return GetRuleContext<Schema_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DATABASE_() { return GetToken(SQLiteParser.DATABASE_, 0); }
		public Attach_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attach_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterAttach_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitAttach_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Attach_stmtContext attach_stmt() {
		Attach_stmtContext _localctx = new Attach_stmtContext(Context, State);
		EnterRule(_localctx, 10, RULE_attach_stmt);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 329;
			Match(ATTACH_);
			State = 331;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,16,Context) ) {
			case 1:
				{
				State = 330;
				Match(DATABASE_);
				}
				break;
			}
			State = 333;
			expr(0);
			State = 334;
			Match(AS_);
			State = 335;
			schema_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Begin_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BEGIN_() { return GetToken(SQLiteParser.BEGIN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRANSACTION_() { return GetToken(SQLiteParser.TRANSACTION_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFERRED_() { return GetToken(SQLiteParser.DEFERRED_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IMMEDIATE_() { return GetToken(SQLiteParser.IMMEDIATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXCLUSIVE_() { return GetToken(SQLiteParser.EXCLUSIVE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Transaction_nameContext transaction_name() {
			return GetRuleContext<Transaction_nameContext>(0);
		}
		public Begin_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_begin_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterBegin_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitBegin_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Begin_stmtContext begin_stmt() {
		Begin_stmtContext _localctx = new Begin_stmtContext(Context, State);
		EnterRule(_localctx, 12, RULE_begin_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 337;
			Match(BEGIN_);
			State = 339;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 58)) & ~0x3f) == 0 && ((1L << (_la - 58)) & ((1L << (DEFERRED_ - 58)) | (1L << (EXCLUSIVE_ - 58)) | (1L << (IMMEDIATE_ - 58)))) != 0)) {
				{
				State = 338;
				_la = TokenStream.LA(1);
				if ( !(((((_la - 58)) & ~0x3f) == 0 && ((1L << (_la - 58)) & ((1L << (DEFERRED_ - 58)) | (1L << (EXCLUSIVE_ - 58)) | (1L << (IMMEDIATE_ - 58)))) != 0)) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
			}

			State = 345;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==TRANSACTION_) {
				{
				State = 341;
				Match(TRANSACTION_);
				State = 343;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,18,Context) ) {
				case 1:
					{
					State = 342;
					transaction_name();
					}
					break;
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

	public partial class Commit_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMIT_() { return GetToken(SQLiteParser.COMMIT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode END_() { return GetToken(SQLiteParser.END_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRANSACTION_() { return GetToken(SQLiteParser.TRANSACTION_, 0); }
		public Commit_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_commit_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterCommit_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitCommit_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Commit_stmtContext commit_stmt() {
		Commit_stmtContext _localctx = new Commit_stmtContext(Context, State);
		EnterRule(_localctx, 14, RULE_commit_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 347;
			_la = TokenStream.LA(1);
			if ( !(_la==COMMIT_ || _la==END_) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			State = 349;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==TRANSACTION_) {
				{
				State = 348;
				Match(TRANSACTION_);
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

	public partial class Rollback_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ROLLBACK_() { return GetToken(SQLiteParser.ROLLBACK_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRANSACTION_() { return GetToken(SQLiteParser.TRANSACTION_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TO_() { return GetToken(SQLiteParser.TO_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Savepoint_nameContext savepoint_name() {
			return GetRuleContext<Savepoint_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SAVEPOINT_() { return GetToken(SQLiteParser.SAVEPOINT_, 0); }
		public Rollback_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_rollback_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterRollback_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitRollback_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Rollback_stmtContext rollback_stmt() {
		Rollback_stmtContext _localctx = new Rollback_stmtContext(Context, State);
		EnterRule(_localctx, 16, RULE_rollback_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 351;
			Match(ROLLBACK_);
			State = 353;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==TRANSACTION_) {
				{
				State = 352;
				Match(TRANSACTION_);
				}
			}

			State = 360;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==TO_) {
				{
				State = 355;
				Match(TO_);
				State = 357;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,22,Context) ) {
				case 1:
					{
					State = 356;
					Match(SAVEPOINT_);
					}
					break;
				}
				State = 359;
				savepoint_name();
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

	public partial class Savepoint_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SAVEPOINT_() { return GetToken(SQLiteParser.SAVEPOINT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Savepoint_nameContext savepoint_name() {
			return GetRuleContext<Savepoint_nameContext>(0);
		}
		public Savepoint_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_savepoint_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterSavepoint_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitSavepoint_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Savepoint_stmtContext savepoint_stmt() {
		Savepoint_stmtContext _localctx = new Savepoint_stmtContext(Context, State);
		EnterRule(_localctx, 18, RULE_savepoint_stmt);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 362;
			Match(SAVEPOINT_);
			State = 363;
			savepoint_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Release_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RELEASE_() { return GetToken(SQLiteParser.RELEASE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Savepoint_nameContext savepoint_name() {
			return GetRuleContext<Savepoint_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SAVEPOINT_() { return GetToken(SQLiteParser.SAVEPOINT_, 0); }
		public Release_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_release_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterRelease_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitRelease_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Release_stmtContext release_stmt() {
		Release_stmtContext _localctx = new Release_stmtContext(Context, State);
		EnterRule(_localctx, 20, RULE_release_stmt);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 365;
			Match(RELEASE_);
			State = 367;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,24,Context) ) {
			case 1:
				{
				State = 366;
				Match(SAVEPOINT_);
				}
				break;
			}
			State = 369;
			savepoint_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Create_index_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CREATE_() { return GetToken(SQLiteParser.CREATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INDEX_() { return GetToken(SQLiteParser.INDEX_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Index_nameContext index_name() {
			return GetRuleContext<Index_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ON_() { return GetToken(SQLiteParser.ON_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Table_nameContext table_name() {
			return GetRuleContext<Table_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Indexed_columnContext[] indexed_column() {
			return GetRuleContexts<Indexed_columnContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Indexed_columnContext indexed_column(int i) {
			return GetRuleContext<Indexed_columnContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNIQUE_() { return GetToken(SQLiteParser.UNIQUE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IF_() { return GetToken(SQLiteParser.IF_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOT_() { return GetToken(SQLiteParser.NOT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXISTS_() { return GetToken(SQLiteParser.EXISTS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Schema_nameContext schema_name() {
			return GetRuleContext<Schema_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(SQLiteParser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHERE_() { return GetToken(SQLiteParser.WHERE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public Create_index_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_create_index_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterCreate_index_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitCreate_index_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Create_index_stmtContext create_index_stmt() {
		Create_index_stmtContext _localctx = new Create_index_stmtContext(Context, State);
		EnterRule(_localctx, 22, RULE_create_index_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 371;
			Match(CREATE_);
			State = 373;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==UNIQUE_) {
				{
				State = 372;
				Match(UNIQUE_);
				}
			}

			State = 375;
			Match(INDEX_);
			State = 379;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,26,Context) ) {
			case 1:
				{
				State = 376;
				Match(IF_);
				State = 377;
				Match(NOT_);
				State = 378;
				Match(EXISTS_);
				}
				break;
			}
			State = 384;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,27,Context) ) {
			case 1:
				{
				State = 381;
				schema_name();
				State = 382;
				Match(DOT);
				}
				break;
			}
			State = 386;
			index_name();
			State = 387;
			Match(ON_);
			State = 388;
			table_name();
			State = 389;
			Match(OPEN_PAR);
			State = 390;
			indexed_column();
			State = 395;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 391;
				Match(COMMA);
				State = 392;
				indexed_column();
				}
				}
				State = 397;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 398;
			Match(CLOSE_PAR);
			State = 401;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WHERE_) {
				{
				State = 399;
				Match(WHERE_);
				State = 400;
				expr(0);
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

	public partial class Indexed_columnContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext column_name() {
			return GetRuleContext<Column_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLLATE_() { return GetToken(SQLiteParser.COLLATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Collation_nameContext collation_name() {
			return GetRuleContext<Collation_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Asc_descContext asc_desc() {
			return GetRuleContext<Asc_descContext>(0);
		}
		public Indexed_columnContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_indexed_column; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterIndexed_column(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitIndexed_column(this);
		}
	}

	[RuleVersion(0)]
	public Indexed_columnContext indexed_column() {
		Indexed_columnContext _localctx = new Indexed_columnContext(Context, State);
		EnterRule(_localctx, 24, RULE_indexed_column);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 405;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,30,Context) ) {
			case 1:
				{
				State = 403;
				column_name();
				}
				break;
			case 2:
				{
				State = 404;
				expr(0);
				}
				break;
			}
			State = 409;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==COLLATE_) {
				{
				State = 407;
				Match(COLLATE_);
				State = 408;
				collation_name();
				}
			}

			State = 412;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==ASC_ || _la==DESC_) {
				{
				State = 411;
				asc_desc();
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

	public partial class Create_table_stmtContext : ParserRuleContext {
		public IToken row_ROW_ID;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CREATE_() { return GetToken(SQLiteParser.CREATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TABLE_() { return GetToken(SQLiteParser.TABLE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Table_nameContext table_name() {
			return GetRuleContext<Table_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Column_defContext[] column_def() {
			return GetRuleContexts<Column_defContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_defContext column_def(int i) {
			return GetRuleContext<Column_defContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AS_() { return GetToken(SQLiteParser.AS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Select_stmtContext select_stmt() {
			return GetRuleContext<Select_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IF_() { return GetToken(SQLiteParser.IF_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOT_() { return GetToken(SQLiteParser.NOT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXISTS_() { return GetToken(SQLiteParser.EXISTS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Schema_nameContext schema_name() {
			return GetRuleContext<Schema_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(SQLiteParser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEMP_() { return GetToken(SQLiteParser.TEMP_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEMPORARY_() { return GetToken(SQLiteParser.TEMPORARY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Table_constraintContext[] table_constraint() {
			return GetRuleContexts<Table_constraintContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Table_constraintContext table_constraint(int i) {
			return GetRuleContext<Table_constraintContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WITHOUT_() { return GetToken(SQLiteParser.WITHOUT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(SQLiteParser.IDENTIFIER, 0); }
		public Create_table_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_create_table_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterCreate_table_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitCreate_table_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Create_table_stmtContext create_table_stmt() {
		Create_table_stmtContext _localctx = new Create_table_stmtContext(Context, State);
		EnterRule(_localctx, 26, RULE_create_table_stmt);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 414;
			Match(CREATE_);
			State = 416;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==TEMP_ || _la==TEMPORARY_) {
				{
				State = 415;
				_la = TokenStream.LA(1);
				if ( !(_la==TEMP_ || _la==TEMPORARY_) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
			}

			State = 418;
			Match(TABLE_);
			State = 422;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,34,Context) ) {
			case 1:
				{
				State = 419;
				Match(IF_);
				State = 420;
				Match(NOT_);
				State = 421;
				Match(EXISTS_);
				}
				break;
			}
			State = 427;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,35,Context) ) {
			case 1:
				{
				State = 424;
				schema_name();
				State = 425;
				Match(DOT);
				}
				break;
			}
			State = 429;
			table_name();
			State = 453;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case OPEN_PAR:
				{
				State = 430;
				Match(OPEN_PAR);
				State = 431;
				column_def();
				State = 436;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,36,Context);
				while ( _alt!=1 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1+1 ) {
						{
						{
						State = 432;
						Match(COMMA);
						State = 433;
						column_def();
						}
						} 
					}
					State = 438;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,36,Context);
				}
				State = 443;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 439;
					Match(COMMA);
					State = 440;
					table_constraint();
					}
					}
					State = 445;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 446;
				Match(CLOSE_PAR);
				State = 449;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==WITHOUT_) {
					{
					State = 447;
					Match(WITHOUT_);
					State = 448;
					_localctx.row_ROW_ID = Match(IDENTIFIER);
					}
				}

				}
				break;
			case AS_:
				{
				State = 451;
				Match(AS_);
				State = 452;
				select_stmt();
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

	public partial class Column_defContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext column_name() {
			return GetRuleContext<Column_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Type_nameContext type_name() {
			return GetRuleContext<Type_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_constraintContext[] column_constraint() {
			return GetRuleContexts<Column_constraintContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_constraintContext column_constraint(int i) {
			return GetRuleContext<Column_constraintContext>(i);
		}
		public Column_defContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_column_def; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterColumn_def(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitColumn_def(this);
		}
	}

	[RuleVersion(0)]
	public Column_defContext column_def() {
		Column_defContext _localctx = new Column_defContext(Context, State);
		EnterRule(_localctx, 28, RULE_column_def);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 455;
			column_name();
			State = 457;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,40,Context) ) {
			case 1:
				{
				State = 456;
				type_name();
				}
				break;
			}
			State = 462;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << AS_) | (1L << CHECK_) | (1L << COLLATE_) | (1L << CONSTRAINT_) | (1L << DEFAULT_))) != 0) || ((((_la - 102)) & ~0x3f) == 0 && ((1L << (_la - 102)) & ((1L << (NOT_ - 102)) | (1L << (PRIMARY_ - 102)) | (1L << (REFERENCES_ - 102)) | (1L << (UNIQUE_ - 102)))) != 0) || _la==GENERATED_) {
				{
				{
				State = 459;
				column_constraint();
				}
				}
				State = 464;
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

	public partial class Type_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public NameContext[] name() {
			return GetRuleContexts<NameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public NameContext name(int i) {
			return GetRuleContext<NameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Signed_numberContext[] signed_number() {
			return GetRuleContexts<Signed_numberContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Signed_numberContext signed_number(int i) {
			return GetRuleContext<Signed_numberContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(SQLiteParser.COMMA, 0); }
		public Type_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_type_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterType_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitType_name(this);
		}
	}

	[RuleVersion(0)]
	public Type_nameContext type_name() {
		Type_nameContext _localctx = new Type_nameContext(Context, State);
		EnterRule(_localctx, 30, RULE_type_name);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 466;
			ErrorHandler.Sync(this);
			_alt = 1+1;
			do {
				switch (_alt) {
				case 1+1:
					{
					{
					State = 465;
					name();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 468;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,42,Context);
			} while ( _alt!=1 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
			State = 480;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,43,Context) ) {
			case 1:
				{
				State = 470;
				Match(OPEN_PAR);
				State = 471;
				signed_number();
				State = 472;
				Match(CLOSE_PAR);
				}
				break;
			case 2:
				{
				State = 474;
				Match(OPEN_PAR);
				State = 475;
				signed_number();
				State = 476;
				Match(COMMA);
				State = 477;
				signed_number();
				State = 478;
				Match(CLOSE_PAR);
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

	public partial class Column_constraintContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CHECK_() { return GetToken(SQLiteParser.CHECK_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFAULT_() { return GetToken(SQLiteParser.DEFAULT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLLATE_() { return GetToken(SQLiteParser.COLLATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Collation_nameContext collation_name() {
			return GetRuleContext<Collation_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Foreign_key_clauseContext foreign_key_clause() {
			return GetRuleContext<Foreign_key_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AS_() { return GetToken(SQLiteParser.AS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CONSTRAINT_() { return GetToken(SQLiteParser.CONSTRAINT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NameContext name() {
			return GetRuleContext<NameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRIMARY_() { return GetToken(SQLiteParser.PRIMARY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode KEY_() { return GetToken(SQLiteParser.KEY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOT_() { return GetToken(SQLiteParser.NOT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NULL_() { return GetToken(SQLiteParser.NULL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNIQUE_() { return GetToken(SQLiteParser.UNIQUE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Signed_numberContext signed_number() {
			return GetRuleContext<Signed_numberContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Literal_valueContext literal_value() {
			return GetRuleContext<Literal_valueContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Conflict_clauseContext conflict_clause() {
			return GetRuleContext<Conflict_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GENERATED_() { return GetToken(SQLiteParser.GENERATED_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ALWAYS_() { return GetToken(SQLiteParser.ALWAYS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STORED_() { return GetToken(SQLiteParser.STORED_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VIRTUAL_() { return GetToken(SQLiteParser.VIRTUAL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Asc_descContext asc_desc() {
			return GetRuleContext<Asc_descContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AUTOINCREMENT_() { return GetToken(SQLiteParser.AUTOINCREMENT_, 0); }
		public Column_constraintContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_column_constraint; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterColumn_constraint(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitColumn_constraint(this);
		}
	}

	[RuleVersion(0)]
	public Column_constraintContext column_constraint() {
		Column_constraintContext _localctx = new Column_constraintContext(Context, State);
		EnterRule(_localctx, 32, RULE_column_constraint);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 484;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==CONSTRAINT_) {
				{
				State = 482;
				Match(CONSTRAINT_);
				State = 483;
				name();
				}
			}

			State = 533;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case PRIMARY_:
				{
				{
				State = 486;
				Match(PRIMARY_);
				State = 487;
				Match(KEY_);
				State = 489;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==ASC_ || _la==DESC_) {
					{
					State = 488;
					asc_desc();
					}
				}

				State = 492;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==ON_) {
					{
					State = 491;
					conflict_clause();
					}
				}

				State = 495;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==AUTOINCREMENT_) {
					{
					State = 494;
					Match(AUTOINCREMENT_);
					}
				}

				}
				}
				break;
			case NOT_:
			case UNIQUE_:
				{
				State = 500;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case NOT_:
					{
					State = 497;
					Match(NOT_);
					State = 498;
					Match(NULL_);
					}
					break;
				case UNIQUE_:
					{
					State = 499;
					Match(UNIQUE_);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 503;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==ON_) {
					{
					State = 502;
					conflict_clause();
					}
				}

				}
				break;
			case CHECK_:
				{
				State = 505;
				Match(CHECK_);
				State = 506;
				Match(OPEN_PAR);
				State = 507;
				expr(0);
				State = 508;
				Match(CLOSE_PAR);
				}
				break;
			case DEFAULT_:
				{
				State = 510;
				Match(DEFAULT_);
				State = 517;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,50,Context) ) {
				case 1:
					{
					State = 511;
					signed_number();
					}
					break;
				case 2:
					{
					State = 512;
					literal_value();
					}
					break;
				case 3:
					{
					State = 513;
					Match(OPEN_PAR);
					State = 514;
					expr(0);
					State = 515;
					Match(CLOSE_PAR);
					}
					break;
				}
				}
				break;
			case COLLATE_:
				{
				State = 519;
				Match(COLLATE_);
				State = 520;
				collation_name();
				}
				break;
			case REFERENCES_:
				{
				State = 521;
				foreign_key_clause();
				}
				break;
			case AS_:
			case GENERATED_:
				{
				State = 524;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==GENERATED_) {
					{
					State = 522;
					Match(GENERATED_);
					State = 523;
					Match(ALWAYS_);
					}
				}

				State = 526;
				Match(AS_);
				State = 527;
				Match(OPEN_PAR);
				State = 528;
				expr(0);
				State = 529;
				Match(CLOSE_PAR);
				State = 531;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==VIRTUAL_ || _la==STORED_) {
					{
					State = 530;
					_la = TokenStream.LA(1);
					if ( !(_la==VIRTUAL_ || _la==STORED_) ) {
					ErrorHandler.RecoverInline(this);
					}
					else {
						ErrorHandler.ReportMatch(this);
					    Consume();
					}
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

	public partial class Signed_numberContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUMERIC_LITERAL() { return GetToken(SQLiteParser.NUMERIC_LITERAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PLUS() { return GetToken(SQLiteParser.PLUS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MINUS() { return GetToken(SQLiteParser.MINUS, 0); }
		public Signed_numberContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_signed_number; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterSigned_number(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitSigned_number(this);
		}
	}

	[RuleVersion(0)]
	public Signed_numberContext signed_number() {
		Signed_numberContext _localctx = new Signed_numberContext(Context, State);
		EnterRule(_localctx, 34, RULE_signed_number);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 536;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==PLUS || _la==MINUS) {
				{
				State = 535;
				_la = TokenStream.LA(1);
				if ( !(_la==PLUS || _la==MINUS) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
			}

			State = 538;
			Match(NUMERIC_LITERAL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Table_constraintContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Indexed_columnContext[] indexed_column() {
			return GetRuleContexts<Indexed_columnContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Indexed_columnContext indexed_column(int i) {
			return GetRuleContext<Indexed_columnContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CHECK_() { return GetToken(SQLiteParser.CHECK_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOREIGN_() { return GetToken(SQLiteParser.FOREIGN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode KEY_() { return GetToken(SQLiteParser.KEY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext[] column_name() {
			return GetRuleContexts<Column_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext column_name(int i) {
			return GetRuleContext<Column_nameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Foreign_key_clauseContext foreign_key_clause() {
			return GetRuleContext<Foreign_key_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CONSTRAINT_() { return GetToken(SQLiteParser.CONSTRAINT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NameContext name() {
			return GetRuleContext<NameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRIMARY_() { return GetToken(SQLiteParser.PRIMARY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNIQUE_() { return GetToken(SQLiteParser.UNIQUE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Conflict_clauseContext conflict_clause() {
			return GetRuleContext<Conflict_clauseContext>(0);
		}
		public Table_constraintContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_table_constraint; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterTable_constraint(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitTable_constraint(this);
		}
	}

	[RuleVersion(0)]
	public Table_constraintContext table_constraint() {
		Table_constraintContext _localctx = new Table_constraintContext(Context, State);
		EnterRule(_localctx, 36, RULE_table_constraint);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 542;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==CONSTRAINT_) {
				{
				State = 540;
				Match(CONSTRAINT_);
				State = 541;
				name();
				}
			}

			State = 581;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case PRIMARY_:
			case UNIQUE_:
				{
				State = 547;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case PRIMARY_:
					{
					State = 544;
					Match(PRIMARY_);
					State = 545;
					Match(KEY_);
					}
					break;
				case UNIQUE_:
					{
					State = 546;
					Match(UNIQUE_);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 549;
				Match(OPEN_PAR);
				State = 550;
				indexed_column();
				State = 555;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 551;
					Match(COMMA);
					State = 552;
					indexed_column();
					}
					}
					State = 557;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 558;
				Match(CLOSE_PAR);
				State = 560;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==ON_) {
					{
					State = 559;
					conflict_clause();
					}
				}

				}
				break;
			case CHECK_:
				{
				State = 562;
				Match(CHECK_);
				State = 563;
				Match(OPEN_PAR);
				State = 564;
				expr(0);
				State = 565;
				Match(CLOSE_PAR);
				}
				break;
			case FOREIGN_:
				{
				State = 567;
				Match(FOREIGN_);
				State = 568;
				Match(KEY_);
				State = 569;
				Match(OPEN_PAR);
				State = 570;
				column_name();
				State = 575;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 571;
					Match(COMMA);
					State = 572;
					column_name();
					}
					}
					State = 577;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 578;
				Match(CLOSE_PAR);
				State = 579;
				foreign_key_clause();
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

	public partial class Foreign_key_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REFERENCES_() { return GetToken(SQLiteParser.REFERENCES_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Foreign_tableContext foreign_table() {
			return GetRuleContext<Foreign_tableContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext[] column_name() {
			return GetRuleContexts<Column_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext column_name(int i) {
			return GetRuleContext<Column_nameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ON_() { return GetTokens(SQLiteParser.ON_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ON_(int i) {
			return GetToken(SQLiteParser.ON_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] MATCH_() { return GetTokens(SQLiteParser.MATCH_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MATCH_(int i) {
			return GetToken(SQLiteParser.MATCH_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NameContext[] name() {
			return GetRuleContexts<NameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public NameContext name(int i) {
			return GetRuleContext<NameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFERRABLE_() { return GetToken(SQLiteParser.DEFERRABLE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DELETE_() { return GetTokens(SQLiteParser.DELETE_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DELETE_(int i) {
			return GetToken(SQLiteParser.DELETE_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] UPDATE_() { return GetTokens(SQLiteParser.UPDATE_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UPDATE_(int i) {
			return GetToken(SQLiteParser.UPDATE_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SET_() { return GetTokens(SQLiteParser.SET_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SET_(int i) {
			return GetToken(SQLiteParser.SET_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] CASCADE_() { return GetTokens(SQLiteParser.CASCADE_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CASCADE_(int i) {
			return GetToken(SQLiteParser.CASCADE_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] RESTRICT_() { return GetTokens(SQLiteParser.RESTRICT_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RESTRICT_(int i) {
			return GetToken(SQLiteParser.RESTRICT_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] NO_() { return GetTokens(SQLiteParser.NO_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NO_(int i) {
			return GetToken(SQLiteParser.NO_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ACTION_() { return GetTokens(SQLiteParser.ACTION_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ACTION_(int i) {
			return GetToken(SQLiteParser.ACTION_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] NULL_() { return GetTokens(SQLiteParser.NULL_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NULL_(int i) {
			return GetToken(SQLiteParser.NULL_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DEFAULT_() { return GetTokens(SQLiteParser.DEFAULT_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFAULT_(int i) {
			return GetToken(SQLiteParser.DEFAULT_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOT_() { return GetToken(SQLiteParser.NOT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INITIALLY_() { return GetToken(SQLiteParser.INITIALLY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFERRED_() { return GetToken(SQLiteParser.DEFERRED_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IMMEDIATE_() { return GetToken(SQLiteParser.IMMEDIATE_, 0); }
		public Foreign_key_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_foreign_key_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterForeign_key_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitForeign_key_clause(this);
		}
	}

	[RuleVersion(0)]
	public Foreign_key_clauseContext foreign_key_clause() {
		Foreign_key_clauseContext _localctx = new Foreign_key_clauseContext(Context, State);
		EnterRule(_localctx, 38, RULE_foreign_key_clause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 583;
			Match(REFERENCES_);
			State = 584;
			foreign_table();
			State = 596;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_PAR) {
				{
				State = 585;
				Match(OPEN_PAR);
				State = 586;
				column_name();
				State = 591;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 587;
					Match(COMMA);
					State = 588;
					column_name();
					}
					}
					State = 593;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 594;
				Match(CLOSE_PAR);
				}
			}

			State = 612;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==MATCH_ || _la==ON_) {
				{
				State = 610;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case ON_:
					{
					State = 598;
					Match(ON_);
					State = 599;
					_la = TokenStream.LA(1);
					if ( !(_la==DELETE_ || _la==UPDATE_) ) {
					ErrorHandler.RecoverInline(this);
					}
					else {
						ErrorHandler.ReportMatch(this);
					    Consume();
					}
					State = 606;
					ErrorHandler.Sync(this);
					switch (TokenStream.LA(1)) {
					case SET_:
						{
						State = 600;
						Match(SET_);
						State = 601;
						_la = TokenStream.LA(1);
						if ( !(_la==DEFAULT_ || _la==NULL_) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						}
						break;
					case CASCADE_:
						{
						State = 602;
						Match(CASCADE_);
						}
						break;
					case RESTRICT_:
						{
						State = 603;
						Match(RESTRICT_);
						}
						break;
					case NO_:
						{
						State = 604;
						Match(NO_);
						State = 605;
						Match(ACTION_);
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					}
					break;
				case MATCH_:
					{
					State = 608;
					Match(MATCH_);
					State = 609;
					name();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 614;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 623;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,68,Context) ) {
			case 1:
				{
				State = 616;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==NOT_) {
					{
					State = 615;
					Match(NOT_);
					}
				}

				State = 618;
				Match(DEFERRABLE_);
				State = 621;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==INITIALLY_) {
					{
					State = 619;
					Match(INITIALLY_);
					State = 620;
					_la = TokenStream.LA(1);
					if ( !(_la==DEFERRED_ || _la==IMMEDIATE_) ) {
					ErrorHandler.RecoverInline(this);
					}
					else {
						ErrorHandler.ReportMatch(this);
					    Consume();
					}
					}
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

	public partial class Conflict_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ON_() { return GetToken(SQLiteParser.ON_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CONFLICT_() { return GetToken(SQLiteParser.CONFLICT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ROLLBACK_() { return GetToken(SQLiteParser.ROLLBACK_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ABORT_() { return GetToken(SQLiteParser.ABORT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FAIL_() { return GetToken(SQLiteParser.FAIL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IGNORE_() { return GetToken(SQLiteParser.IGNORE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REPLACE_() { return GetToken(SQLiteParser.REPLACE_, 0); }
		public Conflict_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_conflict_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterConflict_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitConflict_clause(this);
		}
	}

	[RuleVersion(0)]
	public Conflict_clauseContext conflict_clause() {
		Conflict_clauseContext _localctx = new Conflict_clauseContext(Context, State);
		EnterRule(_localctx, 40, RULE_conflict_clause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 625;
			Match(ON_);
			State = 626;
			Match(CONFLICT_);
			State = 627;
			_la = TokenStream.LA(1);
			if ( !(_la==ABORT_ || ((((_la - 72)) & ~0x3f) == 0 && ((1L << (_la - 72)) & ((1L << (FAIL_ - 72)) | (1L << (IGNORE_ - 72)) | (1L << (REPLACE_ - 72)) | (1L << (ROLLBACK_ - 72)))) != 0)) ) {
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

	public partial class Create_trigger_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CREATE_() { return GetToken(SQLiteParser.CREATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRIGGER_() { return GetToken(SQLiteParser.TRIGGER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Trigger_nameContext trigger_name() {
			return GetRuleContext<Trigger_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ON_() { return GetToken(SQLiteParser.ON_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Table_nameContext table_name() {
			return GetRuleContext<Table_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BEGIN_() { return GetToken(SQLiteParser.BEGIN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode END_() { return GetToken(SQLiteParser.END_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DELETE_() { return GetToken(SQLiteParser.DELETE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INSERT_() { return GetToken(SQLiteParser.INSERT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UPDATE_() { return GetToken(SQLiteParser.UPDATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IF_() { return GetToken(SQLiteParser.IF_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOT_() { return GetToken(SQLiteParser.NOT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXISTS_() { return GetToken(SQLiteParser.EXISTS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Schema_nameContext schema_name() {
			return GetRuleContext<Schema_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(SQLiteParser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BEFORE_() { return GetToken(SQLiteParser.BEFORE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AFTER_() { return GetToken(SQLiteParser.AFTER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INSTEAD_() { return GetToken(SQLiteParser.INSTEAD_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OF_() { return GetTokens(SQLiteParser.OF_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OF_(int i) {
			return GetToken(SQLiteParser.OF_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOR_() { return GetToken(SQLiteParser.FOR_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EACH_() { return GetToken(SQLiteParser.EACH_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ROW_() { return GetToken(SQLiteParser.ROW_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHEN_() { return GetToken(SQLiteParser.WHEN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SCOL() { return GetTokens(SQLiteParser.SCOL); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SCOL(int i) {
			return GetToken(SQLiteParser.SCOL, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEMP_() { return GetToken(SQLiteParser.TEMP_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEMPORARY_() { return GetToken(SQLiteParser.TEMPORARY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext[] column_name() {
			return GetRuleContexts<Column_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext column_name(int i) {
			return GetRuleContext<Column_nameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Update_stmtContext[] update_stmt() {
			return GetRuleContexts<Update_stmtContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Update_stmtContext update_stmt(int i) {
			return GetRuleContext<Update_stmtContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Insert_stmtContext[] insert_stmt() {
			return GetRuleContexts<Insert_stmtContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Insert_stmtContext insert_stmt(int i) {
			return GetRuleContext<Insert_stmtContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Delete_stmtContext[] delete_stmt() {
			return GetRuleContexts<Delete_stmtContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Delete_stmtContext delete_stmt(int i) {
			return GetRuleContext<Delete_stmtContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Select_stmtContext[] select_stmt() {
			return GetRuleContexts<Select_stmtContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Select_stmtContext select_stmt(int i) {
			return GetRuleContext<Select_stmtContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		public Create_trigger_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_create_trigger_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterCreate_trigger_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitCreate_trigger_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Create_trigger_stmtContext create_trigger_stmt() {
		Create_trigger_stmtContext _localctx = new Create_trigger_stmtContext(Context, State);
		EnterRule(_localctx, 42, RULE_create_trigger_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 629;
			Match(CREATE_);
			State = 631;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==TEMP_ || _la==TEMPORARY_) {
				{
				State = 630;
				_la = TokenStream.LA(1);
				if ( !(_la==TEMP_ || _la==TEMPORARY_) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
			}

			State = 633;
			Match(TRIGGER_);
			State = 637;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,70,Context) ) {
			case 1:
				{
				State = 634;
				Match(IF_);
				State = 635;
				Match(NOT_);
				State = 636;
				Match(EXISTS_);
				}
				break;
			}
			State = 642;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,71,Context) ) {
			case 1:
				{
				State = 639;
				schema_name();
				State = 640;
				Match(DOT);
				}
				break;
			}
			State = 644;
			trigger_name();
			State = 649;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case BEFORE_:
				{
				State = 645;
				Match(BEFORE_);
				}
				break;
			case AFTER_:
				{
				State = 646;
				Match(AFTER_);
				}
				break;
			case INSTEAD_:
				{
				State = 647;
				Match(INSTEAD_);
				State = 648;
				Match(OF_);
				}
				break;
			case DELETE_:
			case INSERT_:
			case UPDATE_:
				break;
			default:
				break;
			}
			State = 665;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case DELETE_:
				{
				State = 651;
				Match(DELETE_);
				}
				break;
			case INSERT_:
				{
				State = 652;
				Match(INSERT_);
				}
				break;
			case UPDATE_:
				{
				State = 653;
				Match(UPDATE_);
				State = 663;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==OF_) {
					{
					State = 654;
					Match(OF_);
					State = 655;
					column_name();
					State = 660;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==COMMA) {
						{
						{
						State = 656;
						Match(COMMA);
						State = 657;
						column_name();
						}
						}
						State = 662;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					}
				}

				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 667;
			Match(ON_);
			State = 668;
			table_name();
			State = 672;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==FOR_) {
				{
				State = 669;
				Match(FOR_);
				State = 670;
				Match(EACH_);
				State = 671;
				Match(ROW_);
				}
			}

			State = 676;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WHEN_) {
				{
				State = 674;
				Match(WHEN_);
				State = 675;
				expr(0);
				}
			}

			State = 678;
			Match(BEGIN_);
			State = 687;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 683;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,78,Context) ) {
				case 1:
					{
					State = 679;
					update_stmt();
					}
					break;
				case 2:
					{
					State = 680;
					insert_stmt();
					}
					break;
				case 3:
					{
					State = 681;
					delete_stmt();
					}
					break;
				case 4:
					{
					State = 682;
					select_stmt();
					}
					break;
				}
				State = 685;
				Match(SCOL);
				}
				}
				State = 689;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==DELETE_ || ((((_la - 88)) & ~0x3f) == 0 && ((1L << (_la - 88)) & ((1L << (INSERT_ - 88)) | (1L << (REPLACE_ - 88)) | (1L << (SELECT_ - 88)) | (1L << (UPDATE_ - 88)) | (1L << (VALUES_ - 88)) | (1L << (WITH_ - 88)))) != 0) );
			State = 691;
			Match(END_);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Create_view_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CREATE_() { return GetToken(SQLiteParser.CREATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VIEW_() { return GetToken(SQLiteParser.VIEW_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public View_nameContext view_name() {
			return GetRuleContext<View_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AS_() { return GetToken(SQLiteParser.AS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Select_stmtContext select_stmt() {
			return GetRuleContext<Select_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IF_() { return GetToken(SQLiteParser.IF_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOT_() { return GetToken(SQLiteParser.NOT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXISTS_() { return GetToken(SQLiteParser.EXISTS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Schema_nameContext schema_name() {
			return GetRuleContext<Schema_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(SQLiteParser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext[] column_name() {
			return GetRuleContexts<Column_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext column_name(int i) {
			return GetRuleContext<Column_nameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEMP_() { return GetToken(SQLiteParser.TEMP_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEMPORARY_() { return GetToken(SQLiteParser.TEMPORARY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		public Create_view_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_create_view_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterCreate_view_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitCreate_view_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Create_view_stmtContext create_view_stmt() {
		Create_view_stmtContext _localctx = new Create_view_stmtContext(Context, State);
		EnterRule(_localctx, 44, RULE_create_view_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 693;
			Match(CREATE_);
			State = 695;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==TEMP_ || _la==TEMPORARY_) {
				{
				State = 694;
				_la = TokenStream.LA(1);
				if ( !(_la==TEMP_ || _la==TEMPORARY_) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
			}

			State = 697;
			Match(VIEW_);
			State = 701;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,81,Context) ) {
			case 1:
				{
				State = 698;
				Match(IF_);
				State = 699;
				Match(NOT_);
				State = 700;
				Match(EXISTS_);
				}
				break;
			}
			State = 706;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,82,Context) ) {
			case 1:
				{
				State = 703;
				schema_name();
				State = 704;
				Match(DOT);
				}
				break;
			}
			State = 708;
			view_name();
			State = 720;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_PAR) {
				{
				State = 709;
				Match(OPEN_PAR);
				State = 710;
				column_name();
				State = 715;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 711;
					Match(COMMA);
					State = 712;
					column_name();
					}
					}
					State = 717;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 718;
				Match(CLOSE_PAR);
				}
			}

			State = 722;
			Match(AS_);
			State = 723;
			select_stmt();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Create_virtual_table_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CREATE_() { return GetToken(SQLiteParser.CREATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VIRTUAL_() { return GetToken(SQLiteParser.VIRTUAL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TABLE_() { return GetToken(SQLiteParser.TABLE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Table_nameContext table_name() {
			return GetRuleContext<Table_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode USING_() { return GetToken(SQLiteParser.USING_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Module_nameContext module_name() {
			return GetRuleContext<Module_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IF_() { return GetToken(SQLiteParser.IF_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOT_() { return GetToken(SQLiteParser.NOT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXISTS_() { return GetToken(SQLiteParser.EXISTS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Schema_nameContext schema_name() {
			return GetRuleContext<Schema_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(SQLiteParser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Module_argumentContext[] module_argument() {
			return GetRuleContexts<Module_argumentContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Module_argumentContext module_argument(int i) {
			return GetRuleContext<Module_argumentContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		public Create_virtual_table_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_create_virtual_table_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterCreate_virtual_table_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitCreate_virtual_table_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Create_virtual_table_stmtContext create_virtual_table_stmt() {
		Create_virtual_table_stmtContext _localctx = new Create_virtual_table_stmtContext(Context, State);
		EnterRule(_localctx, 46, RULE_create_virtual_table_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 725;
			Match(CREATE_);
			State = 726;
			Match(VIRTUAL_);
			State = 727;
			Match(TABLE_);
			State = 731;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,85,Context) ) {
			case 1:
				{
				State = 728;
				Match(IF_);
				State = 729;
				Match(NOT_);
				State = 730;
				Match(EXISTS_);
				}
				break;
			}
			State = 736;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,86,Context) ) {
			case 1:
				{
				State = 733;
				schema_name();
				State = 734;
				Match(DOT);
				}
				break;
			}
			State = 738;
			table_name();
			State = 739;
			Match(USING_);
			State = 740;
			module_name();
			State = 752;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_PAR) {
				{
				State = 741;
				Match(OPEN_PAR);
				State = 742;
				module_argument();
				State = 747;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 743;
					Match(COMMA);
					State = 744;
					module_argument();
					}
					}
					State = 749;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 750;
				Match(CLOSE_PAR);
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

	public partial class With_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WITH_() { return GetToken(SQLiteParser.WITH_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Cte_table_nameContext[] cte_table_name() {
			return GetRuleContexts<Cte_table_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Cte_table_nameContext cte_table_name(int i) {
			return GetRuleContext<Cte_table_nameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] AS_() { return GetTokens(SQLiteParser.AS_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AS_(int i) {
			return GetToken(SQLiteParser.AS_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OPEN_PAR() { return GetTokens(SQLiteParser.OPEN_PAR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR(int i) {
			return GetToken(SQLiteParser.OPEN_PAR, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Select_stmtContext[] select_stmt() {
			return GetRuleContexts<Select_stmtContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Select_stmtContext select_stmt(int i) {
			return GetRuleContext<Select_stmtContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] CLOSE_PAR() { return GetTokens(SQLiteParser.CLOSE_PAR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR(int i) {
			return GetToken(SQLiteParser.CLOSE_PAR, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RECURSIVE_() { return GetToken(SQLiteParser.RECURSIVE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		public With_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_with_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterWith_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitWith_clause(this);
		}
	}

	[RuleVersion(0)]
	public With_clauseContext with_clause() {
		With_clauseContext _localctx = new With_clauseContext(Context, State);
		EnterRule(_localctx, 48, RULE_with_clause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 754;
			Match(WITH_);
			State = 756;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,89,Context) ) {
			case 1:
				{
				State = 755;
				Match(RECURSIVE_);
				}
				break;
			}
			State = 758;
			cte_table_name();
			State = 759;
			Match(AS_);
			State = 760;
			Match(OPEN_PAR);
			State = 761;
			select_stmt();
			State = 762;
			Match(CLOSE_PAR);
			State = 772;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 763;
				Match(COMMA);
				State = 764;
				cte_table_name();
				State = 765;
				Match(AS_);
				State = 766;
				Match(OPEN_PAR);
				State = 767;
				select_stmt();
				State = 768;
				Match(CLOSE_PAR);
				}
				}
				State = 774;
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

	public partial class Cte_table_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Table_nameContext table_name() {
			return GetRuleContext<Table_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext[] column_name() {
			return GetRuleContexts<Column_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext column_name(int i) {
			return GetRuleContext<Column_nameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		public Cte_table_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_cte_table_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterCte_table_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitCte_table_name(this);
		}
	}

	[RuleVersion(0)]
	public Cte_table_nameContext cte_table_name() {
		Cte_table_nameContext _localctx = new Cte_table_nameContext(Context, State);
		EnterRule(_localctx, 50, RULE_cte_table_name);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 775;
			table_name();
			State = 787;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_PAR) {
				{
				State = 776;
				Match(OPEN_PAR);
				State = 777;
				column_name();
				State = 782;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 778;
					Match(COMMA);
					State = 779;
					column_name();
					}
					}
					State = 784;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 785;
				Match(CLOSE_PAR);
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

	public partial class Recursive_cteContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Cte_table_nameContext cte_table_name() {
			return GetRuleContext<Cte_table_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AS_() { return GetToken(SQLiteParser.AS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Initial_selectContext initial_select() {
			return GetRuleContext<Initial_selectContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNION_() { return GetToken(SQLiteParser.UNION_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Recursive_selectContext recursive_select() {
			return GetRuleContext<Recursive_selectContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ALL_() { return GetToken(SQLiteParser.ALL_, 0); }
		public Recursive_cteContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_recursive_cte; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterRecursive_cte(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitRecursive_cte(this);
		}
	}

	[RuleVersion(0)]
	public Recursive_cteContext recursive_cte() {
		Recursive_cteContext _localctx = new Recursive_cteContext(Context, State);
		EnterRule(_localctx, 52, RULE_recursive_cte);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 789;
			cte_table_name();
			State = 790;
			Match(AS_);
			State = 791;
			Match(OPEN_PAR);
			State = 792;
			initial_select();
			State = 793;
			Match(UNION_);
			State = 795;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==ALL_) {
				{
				State = 794;
				Match(ALL_);
				}
			}

			State = 797;
			recursive_select();
			State = 798;
			Match(CLOSE_PAR);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Common_table_expressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Table_nameContext table_name() {
			return GetRuleContext<Table_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AS_() { return GetToken(SQLiteParser.AS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OPEN_PAR() { return GetTokens(SQLiteParser.OPEN_PAR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR(int i) {
			return GetToken(SQLiteParser.OPEN_PAR, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Select_stmtContext select_stmt() {
			return GetRuleContext<Select_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] CLOSE_PAR() { return GetTokens(SQLiteParser.CLOSE_PAR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR(int i) {
			return GetToken(SQLiteParser.CLOSE_PAR, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext[] column_name() {
			return GetRuleContexts<Column_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext column_name(int i) {
			return GetRuleContext<Column_nameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		public Common_table_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_common_table_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterCommon_table_expression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitCommon_table_expression(this);
		}
	}

	[RuleVersion(0)]
	public Common_table_expressionContext common_table_expression() {
		Common_table_expressionContext _localctx = new Common_table_expressionContext(Context, State);
		EnterRule(_localctx, 54, RULE_common_table_expression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 800;
			table_name();
			State = 812;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_PAR) {
				{
				State = 801;
				Match(OPEN_PAR);
				State = 802;
				column_name();
				State = 807;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 803;
					Match(COMMA);
					State = 804;
					column_name();
					}
					}
					State = 809;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 810;
				Match(CLOSE_PAR);
				}
			}

			State = 814;
			Match(AS_);
			State = 815;
			Match(OPEN_PAR);
			State = 816;
			select_stmt();
			State = 817;
			Match(CLOSE_PAR);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Delete_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DELETE_() { return GetToken(SQLiteParser.DELETE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FROM_() { return GetToken(SQLiteParser.FROM_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Qualified_table_nameContext qualified_table_name() {
			return GetRuleContext<Qualified_table_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public With_clauseContext with_clause() {
			return GetRuleContext<With_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHERE_() { return GetToken(SQLiteParser.WHERE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Returning_clauseContext returning_clause() {
			return GetRuleContext<Returning_clauseContext>(0);
		}
		public Delete_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_delete_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterDelete_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitDelete_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Delete_stmtContext delete_stmt() {
		Delete_stmtContext _localctx = new Delete_stmtContext(Context, State);
		EnterRule(_localctx, 56, RULE_delete_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 820;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WITH_) {
				{
				State = 819;
				with_clause();
				}
			}

			State = 822;
			Match(DELETE_);
			State = 823;
			Match(FROM_);
			State = 824;
			qualified_table_name();
			State = 827;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WHERE_) {
				{
				State = 825;
				Match(WHERE_);
				State = 826;
				expr(0);
				}
			}

			State = 830;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==RETURNING_) {
				{
				State = 829;
				returning_clause();
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

	public partial class Delete_stmt_limitedContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DELETE_() { return GetToken(SQLiteParser.DELETE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FROM_() { return GetToken(SQLiteParser.FROM_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Qualified_table_nameContext qualified_table_name() {
			return GetRuleContext<Qualified_table_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public With_clauseContext with_clause() {
			return GetRuleContext<With_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHERE_() { return GetToken(SQLiteParser.WHERE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Returning_clauseContext returning_clause() {
			return GetRuleContext<Returning_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Limit_stmtContext limit_stmt() {
			return GetRuleContext<Limit_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Order_by_stmtContext order_by_stmt() {
			return GetRuleContext<Order_by_stmtContext>(0);
		}
		public Delete_stmt_limitedContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_delete_stmt_limited; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterDelete_stmt_limited(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitDelete_stmt_limited(this);
		}
	}

	[RuleVersion(0)]
	public Delete_stmt_limitedContext delete_stmt_limited() {
		Delete_stmt_limitedContext _localctx = new Delete_stmt_limitedContext(Context, State);
		EnterRule(_localctx, 58, RULE_delete_stmt_limited);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 833;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WITH_) {
				{
				State = 832;
				with_clause();
				}
			}

			State = 835;
			Match(DELETE_);
			State = 836;
			Match(FROM_);
			State = 837;
			qualified_table_name();
			State = 840;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WHERE_) {
				{
				State = 838;
				Match(WHERE_);
				State = 839;
				expr(0);
				}
			}

			State = 843;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==RETURNING_) {
				{
				State = 842;
				returning_clause();
				}
			}

			State = 849;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LIMIT_ || _la==ORDER_) {
				{
				State = 846;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==ORDER_) {
					{
					State = 845;
					order_by_stmt();
					}
				}

				State = 848;
				limit_stmt();
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

	public partial class Detach_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DETACH_() { return GetToken(SQLiteParser.DETACH_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Schema_nameContext schema_name() {
			return GetRuleContext<Schema_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DATABASE_() { return GetToken(SQLiteParser.DATABASE_, 0); }
		public Detach_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_detach_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterDetach_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitDetach_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Detach_stmtContext detach_stmt() {
		Detach_stmtContext _localctx = new Detach_stmtContext(Context, State);
		EnterRule(_localctx, 60, RULE_detach_stmt);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 851;
			Match(DETACH_);
			State = 853;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,104,Context) ) {
			case 1:
				{
				State = 852;
				Match(DATABASE_);
				}
				break;
			}
			State = 855;
			schema_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Drop_stmtContext : ParserRuleContext {
		public IToken @object;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DROP_() { return GetToken(SQLiteParser.DROP_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INDEX_() { return GetToken(SQLiteParser.INDEX_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TABLE_() { return GetToken(SQLiteParser.TABLE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRIGGER_() { return GetToken(SQLiteParser.TRIGGER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VIEW_() { return GetToken(SQLiteParser.VIEW_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IF_() { return GetToken(SQLiteParser.IF_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXISTS_() { return GetToken(SQLiteParser.EXISTS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Schema_nameContext schema_name() {
			return GetRuleContext<Schema_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(SQLiteParser.DOT, 0); }
		public Drop_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_drop_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterDrop_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitDrop_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Drop_stmtContext drop_stmt() {
		Drop_stmtContext _localctx = new Drop_stmtContext(Context, State);
		EnterRule(_localctx, 62, RULE_drop_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 857;
			Match(DROP_);
			State = 858;
			_localctx.@object = TokenStream.LT(1);
			_la = TokenStream.LA(1);
			if ( !(((((_la - 84)) & ~0x3f) == 0 && ((1L << (_la - 84)) & ((1L << (INDEX_ - 84)) | (1L << (TABLE_ - 84)) | (1L << (TRIGGER_ - 84)) | (1L << (VIEW_ - 84)))) != 0)) ) {
				_localctx.@object = ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			State = 861;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,105,Context) ) {
			case 1:
				{
				State = 859;
				Match(IF_);
				State = 860;
				Match(EXISTS_);
				}
				break;
			}
			State = 866;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,106,Context) ) {
			case 1:
				{
				State = 863;
				schema_name();
				State = 864;
				Match(DOT);
				}
				break;
			}
			State = 868;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Literal_valueContext literal_value() {
			return GetRuleContext<Literal_valueContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BIND_PARAMETER() { return GetToken(SQLiteParser.BIND_PARAMETER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext column_name() {
			return GetRuleContext<Column_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Table_nameContext table_name() {
			return GetRuleContext<Table_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] DOT() { return GetTokens(SQLiteParser.DOT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT(int i) {
			return GetToken(SQLiteParser.DOT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Schema_nameContext schema_name() {
			return GetRuleContext<Schema_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Unary_operatorContext unary_operator() {
			return GetRuleContext<Unary_operatorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Function_nameContext function_name() {
			return GetRuleContext<Function_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STAR() { return GetToken(SQLiteParser.STAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Filter_clauseContext filter_clause() {
			return GetRuleContext<Filter_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Over_clauseContext over_clause() {
			return GetRuleContext<Over_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DISTINCT_() { return GetToken(SQLiteParser.DISTINCT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CAST_() { return GetToken(SQLiteParser.CAST_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AS_() { return GetToken(SQLiteParser.AS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Type_nameContext type_name() {
			return GetRuleContext<Type_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Select_stmtContext select_stmt() {
			return GetRuleContext<Select_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXISTS_() { return GetToken(SQLiteParser.EXISTS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOT_() { return GetToken(SQLiteParser.NOT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CASE_() { return GetToken(SQLiteParser.CASE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode END_() { return GetToken(SQLiteParser.END_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] WHEN_() { return GetTokens(SQLiteParser.WHEN_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHEN_(int i) {
			return GetToken(SQLiteParser.WHEN_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] THEN_() { return GetTokens(SQLiteParser.THEN_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THEN_(int i) {
			return GetToken(SQLiteParser.THEN_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ELSE_() { return GetToken(SQLiteParser.ELSE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Raise_functionContext raise_function() {
			return GetRuleContext<Raise_functionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PIPE2() { return GetToken(SQLiteParser.PIPE2, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIV() { return GetToken(SQLiteParser.DIV, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MOD() { return GetToken(SQLiteParser.MOD, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PLUS() { return GetToken(SQLiteParser.PLUS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MINUS() { return GetToken(SQLiteParser.MINUS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LT2() { return GetToken(SQLiteParser.LT2, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT2() { return GetToken(SQLiteParser.GT2, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AMP() { return GetToken(SQLiteParser.AMP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PIPE() { return GetToken(SQLiteParser.PIPE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LT() { return GetToken(SQLiteParser.LT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LT_EQ() { return GetToken(SQLiteParser.LT_EQ, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT() { return GetToken(SQLiteParser.GT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GT_EQ() { return GetToken(SQLiteParser.GT_EQ, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGN() { return GetToken(SQLiteParser.ASSIGN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EQ() { return GetToken(SQLiteParser.EQ, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOT_EQ1() { return GetToken(SQLiteParser.NOT_EQ1, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOT_EQ2() { return GetToken(SQLiteParser.NOT_EQ2, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IS_() { return GetToken(SQLiteParser.IS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IN_() { return GetToken(SQLiteParser.IN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LIKE_() { return GetToken(SQLiteParser.LIKE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GLOB_() { return GetToken(SQLiteParser.GLOB_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MATCH_() { return GetToken(SQLiteParser.MATCH_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REGEXP_() { return GetToken(SQLiteParser.REGEXP_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AND_() { return GetToken(SQLiteParser.AND_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OR_() { return GetToken(SQLiteParser.OR_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BETWEEN_() { return GetToken(SQLiteParser.BETWEEN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLLATE_() { return GetToken(SQLiteParser.COLLATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Collation_nameContext collation_name() {
			return GetRuleContext<Collation_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ESCAPE_() { return GetToken(SQLiteParser.ESCAPE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ISNULL_() { return GetToken(SQLiteParser.ISNULL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOTNULL_() { return GetToken(SQLiteParser.NOTNULL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NULL_() { return GetToken(SQLiteParser.NULL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Table_function_nameContext table_function_name() {
			return GetRuleContext<Table_function_nameContext>(0);
		}
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterExpr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitExpr(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		return expr(0);
	}

	private ExprContext expr(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExprContext _localctx = new ExprContext(Context, _parentState);
		ExprContext _prevctx = _localctx;
		int _startState = 64;
		EnterRecursionRule(_localctx, 64, RULE_expr, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 958;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,120,Context) ) {
			case 1:
				{
				State = 871;
				literal_value();
				}
				break;
			case 2:
				{
				State = 872;
				Match(BIND_PARAMETER);
				}
				break;
			case 3:
				{
				State = 881;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,108,Context) ) {
				case 1:
					{
					State = 876;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,107,Context) ) {
					case 1:
						{
						State = 873;
						schema_name();
						State = 874;
						Match(DOT);
						}
						break;
					}
					State = 878;
					table_name();
					State = 879;
					Match(DOT);
					}
					break;
				}
				State = 883;
				column_name();
				}
				break;
			case 4:
				{
				State = 884;
				unary_operator();
				State = 885;
				expr(21);
				}
				break;
			case 5:
				{
				State = 887;
				function_name();
				State = 888;
				Match(OPEN_PAR);
				State = 901;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case OPEN_PAR:
				case PLUS:
				case MINUS:
				case TILDE:
				case ABORT_:
				case ACTION_:
				case ADD_:
				case AFTER_:
				case ALL_:
				case ALTER_:
				case ANALYZE_:
				case AND_:
				case AS_:
				case ASC_:
				case ATTACH_:
				case AUTOINCREMENT_:
				case BEFORE_:
				case BEGIN_:
				case BETWEEN_:
				case BY_:
				case CASCADE_:
				case CASE_:
				case CAST_:
				case CHECK_:
				case COLLATE_:
				case COLUMN_:
				case COMMIT_:
				case CONFLICT_:
				case CONSTRAINT_:
				case CREATE_:
				case CROSS_:
				case CURRENT_DATE_:
				case CURRENT_TIME_:
				case CURRENT_TIMESTAMP_:
				case DATABASE_:
				case DEFAULT_:
				case DEFERRABLE_:
				case DEFERRED_:
				case DELETE_:
				case DESC_:
				case DETACH_:
				case DISTINCT_:
				case DROP_:
				case EACH_:
				case ELSE_:
				case END_:
				case ESCAPE_:
				case EXCEPT_:
				case EXCLUSIVE_:
				case EXISTS_:
				case EXPLAIN_:
				case FAIL_:
				case FOR_:
				case FOREIGN_:
				case FROM_:
				case FULL_:
				case GLOB_:
				case GROUP_:
				case HAVING_:
				case IF_:
				case IGNORE_:
				case IMMEDIATE_:
				case IN_:
				case INDEX_:
				case INDEXED_:
				case INITIALLY_:
				case INNER_:
				case INSERT_:
				case INSTEAD_:
				case INTERSECT_:
				case INTO_:
				case IS_:
				case ISNULL_:
				case JOIN_:
				case KEY_:
				case LEFT_:
				case LIKE_:
				case LIMIT_:
				case MATCH_:
				case NATURAL_:
				case NO_:
				case NOT_:
				case NOTNULL_:
				case NULL_:
				case OF_:
				case OFFSET_:
				case ON_:
				case OR_:
				case ORDER_:
				case OUTER_:
				case PLAN_:
				case PRAGMA_:
				case PRIMARY_:
				case QUERY_:
				case RAISE_:
				case RECURSIVE_:
				case REFERENCES_:
				case REGEXP_:
				case REINDEX_:
				case RELEASE_:
				case RENAME_:
				case REPLACE_:
				case RESTRICT_:
				case RIGHT_:
				case ROLLBACK_:
				case ROW_:
				case ROWS_:
				case SAVEPOINT_:
				case SELECT_:
				case SET_:
				case TABLE_:
				case TEMP_:
				case TEMPORARY_:
				case THEN_:
				case TO_:
				case TRANSACTION_:
				case TRIGGER_:
				case UNION_:
				case UNIQUE_:
				case UPDATE_:
				case USING_:
				case VACUUM_:
				case VALUES_:
				case VIEW_:
				case VIRTUAL_:
				case WHEN_:
				case WHERE_:
				case WITH_:
				case WITHOUT_:
				case FIRST_VALUE_:
				case OVER_:
				case PARTITION_:
				case RANGE_:
				case PRECEDING_:
				case UNBOUNDED_:
				case CURRENT_:
				case FOLLOWING_:
				case CUME_DIST_:
				case DENSE_RANK_:
				case LAG_:
				case LAST_VALUE_:
				case LEAD_:
				case NTH_VALUE_:
				case NTILE_:
				case PERCENT_RANK_:
				case RANK_:
				case ROW_NUMBER_:
				case GENERATED_:
				case ALWAYS_:
				case STORED_:
				case TRUE_:
				case FALSE_:
				case WINDOW_:
				case NULLS_:
				case FIRST_:
				case LAST_:
				case FILTER_:
				case GROUPS_:
				case EXCLUDE_:
				case IDENTIFIER:
				case NUMERIC_LITERAL:
				case BIND_PARAMETER:
				case STRING_LITERAL:
				case BLOB_LITERAL:
					{
					{
					State = 890;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,109,Context) ) {
					case 1:
						{
						State = 889;
						Match(DISTINCT_);
						}
						break;
					}
					State = 892;
					expr(0);
					State = 897;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==COMMA) {
						{
						{
						State = 893;
						Match(COMMA);
						State = 894;
						expr(0);
						}
						}
						State = 899;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					}
					}
					break;
				case STAR:
					{
					State = 900;
					Match(STAR);
					}
					break;
				case CLOSE_PAR:
					break;
				default:
					break;
				}
				State = 903;
				Match(CLOSE_PAR);
				State = 905;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,112,Context) ) {
				case 1:
					{
					State = 904;
					filter_clause();
					}
					break;
				}
				State = 908;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,113,Context) ) {
				case 1:
					{
					State = 907;
					over_clause();
					}
					break;
				}
				}
				break;
			case 6:
				{
				State = 910;
				Match(OPEN_PAR);
				State = 911;
				expr(0);
				State = 916;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 912;
					Match(COMMA);
					State = 913;
					expr(0);
					}
					}
					State = 918;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 919;
				Match(CLOSE_PAR);
				}
				break;
			case 7:
				{
				State = 921;
				Match(CAST_);
				State = 922;
				Match(OPEN_PAR);
				State = 923;
				expr(0);
				State = 924;
				Match(AS_);
				State = 925;
				type_name();
				State = 926;
				Match(CLOSE_PAR);
				}
				break;
			case 8:
				{
				State = 932;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==EXISTS_ || _la==NOT_) {
					{
					State = 929;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==NOT_) {
						{
						State = 928;
						Match(NOT_);
						}
					}

					State = 931;
					Match(EXISTS_);
					}
				}

				State = 934;
				Match(OPEN_PAR);
				State = 935;
				select_stmt();
				State = 936;
				Match(CLOSE_PAR);
				}
				break;
			case 9:
				{
				State = 938;
				Match(CASE_);
				State = 940;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,117,Context) ) {
				case 1:
					{
					State = 939;
					expr(0);
					}
					break;
				}
				State = 947;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				do {
					{
					{
					State = 942;
					Match(WHEN_);
					State = 943;
					expr(0);
					State = 944;
					Match(THEN_);
					State = 945;
					expr(0);
					}
					}
					State = 949;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				} while ( _la==WHEN_ );
				State = 953;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==ELSE_) {
					{
					State = 951;
					Match(ELSE_);
					State = 952;
					expr(0);
					}
				}

				State = 955;
				Match(END_);
				}
				break;
			case 10:
				{
				State = 957;
				raise_function();
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 1079;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,136,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 1077;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,135,Context) ) {
					case 1:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 960;
						if (!(Precpred(Context, 20))) throw new FailedPredicateException(this, "Precpred(Context, 20)");
						State = 961;
						Match(PIPE2);
						State = 962;
						expr(21);
						}
						break;
					case 2:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 963;
						if (!(Precpred(Context, 19))) throw new FailedPredicateException(this, "Precpred(Context, 19)");
						State = 964;
						_la = TokenStream.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << STAR) | (1L << DIV) | (1L << MOD))) != 0)) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 965;
						expr(20);
						}
						break;
					case 3:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 966;
						if (!(Precpred(Context, 18))) throw new FailedPredicateException(this, "Precpred(Context, 18)");
						State = 967;
						_la = TokenStream.LA(1);
						if ( !(_la==PLUS || _la==MINUS) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 968;
						expr(19);
						}
						break;
					case 4:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 969;
						if (!(Precpred(Context, 17))) throw new FailedPredicateException(this, "Precpred(Context, 17)");
						State = 970;
						_la = TokenStream.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << LT2) | (1L << GT2) | (1L << AMP) | (1L << PIPE))) != 0)) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 971;
						expr(18);
						}
						break;
					case 5:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 972;
						if (!(Precpred(Context, 16))) throw new FailedPredicateException(this, "Precpred(Context, 16)");
						State = 973;
						_la = TokenStream.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << LT) | (1L << LT_EQ) | (1L << GT) | (1L << GT_EQ))) != 0)) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 974;
						expr(17);
						}
						break;
					case 6:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 975;
						if (!(Precpred(Context, 15))) throw new FailedPredicateException(this, "Precpred(Context, 15)");
						State = 988;
						ErrorHandler.Sync(this);
						switch ( Interpreter.AdaptivePredict(TokenStream,121,Context) ) {
						case 1:
							{
							State = 976;
							Match(ASSIGN);
							}
							break;
						case 2:
							{
							State = 977;
							Match(EQ);
							}
							break;
						case 3:
							{
							State = 978;
							Match(NOT_EQ1);
							}
							break;
						case 4:
							{
							State = 979;
							Match(NOT_EQ2);
							}
							break;
						case 5:
							{
							State = 980;
							Match(IS_);
							}
							break;
						case 6:
							{
							State = 981;
							Match(IS_);
							State = 982;
							Match(NOT_);
							}
							break;
						case 7:
							{
							State = 983;
							Match(IN_);
							}
							break;
						case 8:
							{
							State = 984;
							Match(LIKE_);
							}
							break;
						case 9:
							{
							State = 985;
							Match(GLOB_);
							}
							break;
						case 10:
							{
							State = 986;
							Match(MATCH_);
							}
							break;
						case 11:
							{
							State = 987;
							Match(REGEXP_);
							}
							break;
						}
						State = 990;
						expr(16);
						}
						break;
					case 7:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 991;
						if (!(Precpred(Context, 14))) throw new FailedPredicateException(this, "Precpred(Context, 14)");
						State = 992;
						Match(AND_);
						State = 993;
						expr(15);
						}
						break;
					case 8:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 994;
						if (!(Precpred(Context, 13))) throw new FailedPredicateException(this, "Precpred(Context, 13)");
						State = 995;
						Match(OR_);
						State = 996;
						expr(14);
						}
						break;
					case 9:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 997;
						if (!(Precpred(Context, 6))) throw new FailedPredicateException(this, "Precpred(Context, 6)");
						State = 998;
						Match(IS_);
						State = 1000;
						ErrorHandler.Sync(this);
						switch ( Interpreter.AdaptivePredict(TokenStream,122,Context) ) {
						case 1:
							{
							State = 999;
							Match(NOT_);
							}
							break;
						}
						State = 1002;
						expr(7);
						}
						break;
					case 10:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 1003;
						if (!(Precpred(Context, 5))) throw new FailedPredicateException(this, "Precpred(Context, 5)");
						State = 1005;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if (_la==NOT_) {
							{
							State = 1004;
							Match(NOT_);
							}
						}

						State = 1007;
						Match(BETWEEN_);
						State = 1008;
						expr(0);
						State = 1009;
						Match(AND_);
						State = 1010;
						expr(6);
						}
						break;
					case 11:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 1012;
						if (!(Precpred(Context, 9))) throw new FailedPredicateException(this, "Precpred(Context, 9)");
						State = 1013;
						Match(COLLATE_);
						State = 1014;
						collation_name();
						}
						break;
					case 12:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 1015;
						if (!(Precpred(Context, 8))) throw new FailedPredicateException(this, "Precpred(Context, 8)");
						State = 1017;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if (_la==NOT_) {
							{
							State = 1016;
							Match(NOT_);
							}
						}

						State = 1019;
						_la = TokenStream.LA(1);
						if ( !(((((_la - 77)) & ~0x3f) == 0 && ((1L << (_la - 77)) & ((1L << (GLOB_ - 77)) | (1L << (LIKE_ - 77)) | (1L << (MATCH_ - 77)) | (1L << (REGEXP_ - 77)))) != 0)) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 1020;
						expr(0);
						State = 1023;
						ErrorHandler.Sync(this);
						switch ( Interpreter.AdaptivePredict(TokenStream,125,Context) ) {
						case 1:
							{
							State = 1021;
							Match(ESCAPE_);
							State = 1022;
							expr(0);
							}
							break;
						}
						}
						break;
					case 13:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 1025;
						if (!(Precpred(Context, 7))) throw new FailedPredicateException(this, "Precpred(Context, 7)");
						State = 1030;
						ErrorHandler.Sync(this);
						switch (TokenStream.LA(1)) {
						case ISNULL_:
							{
							State = 1026;
							Match(ISNULL_);
							}
							break;
						case NOTNULL_:
							{
							State = 1027;
							Match(NOTNULL_);
							}
							break;
						case NOT_:
							{
							State = 1028;
							Match(NOT_);
							State = 1029;
							Match(NULL_);
							}
							break;
						default:
							throw new NoViableAltException(this);
						}
						}
						break;
					case 14:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 1032;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 1034;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						if (_la==NOT_) {
							{
							State = 1033;
							Match(NOT_);
							}
						}

						State = 1036;
						Match(IN_);
						State = 1075;
						ErrorHandler.Sync(this);
						switch ( Interpreter.AdaptivePredict(TokenStream,134,Context) ) {
						case 1:
							{
							State = 1037;
							Match(OPEN_PAR);
							State = 1047;
							ErrorHandler.Sync(this);
							switch ( Interpreter.AdaptivePredict(TokenStream,129,Context) ) {
							case 1:
								{
								State = 1038;
								select_stmt();
								}
								break;
							case 2:
								{
								State = 1039;
								expr(0);
								State = 1044;
								ErrorHandler.Sync(this);
								_la = TokenStream.LA(1);
								while (_la==COMMA) {
									{
									{
									State = 1040;
									Match(COMMA);
									State = 1041;
									expr(0);
									}
									}
									State = 1046;
									ErrorHandler.Sync(this);
									_la = TokenStream.LA(1);
								}
								}
								break;
							}
							State = 1049;
							Match(CLOSE_PAR);
							}
							break;
						case 2:
							{
							State = 1053;
							ErrorHandler.Sync(this);
							switch ( Interpreter.AdaptivePredict(TokenStream,130,Context) ) {
							case 1:
								{
								State = 1050;
								schema_name();
								State = 1051;
								Match(DOT);
								}
								break;
							}
							State = 1055;
							table_name();
							}
							break;
						case 3:
							{
							State = 1059;
							ErrorHandler.Sync(this);
							switch ( Interpreter.AdaptivePredict(TokenStream,131,Context) ) {
							case 1:
								{
								State = 1056;
								schema_name();
								State = 1057;
								Match(DOT);
								}
								break;
							}
							State = 1061;
							table_function_name();
							State = 1062;
							Match(OPEN_PAR);
							State = 1071;
							ErrorHandler.Sync(this);
							_la = TokenStream.LA(1);
							if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << OPEN_PAR) | (1L << PLUS) | (1L << MINUS) | (1L << TILDE) | (1L << ABORT_) | (1L << ACTION_) | (1L << ADD_) | (1L << AFTER_) | (1L << ALL_) | (1L << ALTER_) | (1L << ANALYZE_) | (1L << AND_) | (1L << AS_) | (1L << ASC_) | (1L << ATTACH_) | (1L << AUTOINCREMENT_) | (1L << BEFORE_) | (1L << BEGIN_) | (1L << BETWEEN_) | (1L << BY_) | (1L << CASCADE_) | (1L << CASE_) | (1L << CAST_) | (1L << CHECK_) | (1L << COLLATE_) | (1L << COLUMN_) | (1L << COMMIT_) | (1L << CONFLICT_) | (1L << CONSTRAINT_) | (1L << CREATE_) | (1L << CROSS_) | (1L << CURRENT_DATE_) | (1L << CURRENT_TIME_) | (1L << CURRENT_TIMESTAMP_) | (1L << DATABASE_) | (1L << DEFAULT_) | (1L << DEFERRABLE_) | (1L << DEFERRED_) | (1L << DELETE_) | (1L << DESC_) | (1L << DETACH_) | (1L << DISTINCT_) | (1L << DROP_))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (EACH_ - 64)) | (1L << (ELSE_ - 64)) | (1L << (END_ - 64)) | (1L << (ESCAPE_ - 64)) | (1L << (EXCEPT_ - 64)) | (1L << (EXCLUSIVE_ - 64)) | (1L << (EXISTS_ - 64)) | (1L << (EXPLAIN_ - 64)) | (1L << (FAIL_ - 64)) | (1L << (FOR_ - 64)) | (1L << (FOREIGN_ - 64)) | (1L << (FROM_ - 64)) | (1L << (FULL_ - 64)) | (1L << (GLOB_ - 64)) | (1L << (GROUP_ - 64)) | (1L << (HAVING_ - 64)) | (1L << (IF_ - 64)) | (1L << (IGNORE_ - 64)) | (1L << (IMMEDIATE_ - 64)) | (1L << (IN_ - 64)) | (1L << (INDEX_ - 64)) | (1L << (INDEXED_ - 64)) | (1L << (INITIALLY_ - 64)) | (1L << (INNER_ - 64)) | (1L << (INSERT_ - 64)) | (1L << (INSTEAD_ - 64)) | (1L << (INTERSECT_ - 64)) | (1L << (INTO_ - 64)) | (1L << (IS_ - 64)) | (1L << (ISNULL_ - 64)) | (1L << (JOIN_ - 64)) | (1L << (KEY_ - 64)) | (1L << (LEFT_ - 64)) | (1L << (LIKE_ - 64)) | (1L << (LIMIT_ - 64)) | (1L << (MATCH_ - 64)) | (1L << (NATURAL_ - 64)) | (1L << (NO_ - 64)) | (1L << (NOT_ - 64)) | (1L << (NOTNULL_ - 64)) | (1L << (NULL_ - 64)) | (1L << (OF_ - 64)) | (1L << (OFFSET_ - 64)) | (1L << (ON_ - 64)) | (1L << (OR_ - 64)) | (1L << (ORDER_ - 64)) | (1L << (OUTER_ - 64)) | (1L << (PLAN_ - 64)) | (1L << (PRAGMA_ - 64)) | (1L << (PRIMARY_ - 64)) | (1L << (QUERY_ - 64)) | (1L << (RAISE_ - 64)) | (1L << (RECURSIVE_ - 64)) | (1L << (REFERENCES_ - 64)) | (1L << (REGEXP_ - 64)) | (1L << (REINDEX_ - 64)) | (1L << (RELEASE_ - 64)) | (1L << (RENAME_ - 64)) | (1L << (REPLACE_ - 64)) | (1L << (RESTRICT_ - 64)) | (1L << (RIGHT_ - 64)) | (1L << (ROLLBACK_ - 64)) | (1L << (ROW_ - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (ROWS_ - 128)) | (1L << (SAVEPOINT_ - 128)) | (1L << (SELECT_ - 128)) | (1L << (SET_ - 128)) | (1L << (TABLE_ - 128)) | (1L << (TEMP_ - 128)) | (1L << (TEMPORARY_ - 128)) | (1L << (THEN_ - 128)) | (1L << (TO_ - 128)) | (1L << (TRANSACTION_ - 128)) | (1L << (TRIGGER_ - 128)) | (1L << (UNION_ - 128)) | (1L << (UNIQUE_ - 128)) | (1L << (UPDATE_ - 128)) | (1L << (USING_ - 128)) | (1L << (VACUUM_ - 128)) | (1L << (VALUES_ - 128)) | (1L << (VIEW_ - 128)) | (1L << (VIRTUAL_ - 128)) | (1L << (WHEN_ - 128)) | (1L << (WHERE_ - 128)) | (1L << (WITH_ - 128)) | (1L << (WITHOUT_ - 128)) | (1L << (FIRST_VALUE_ - 128)) | (1L << (OVER_ - 128)) | (1L << (PARTITION_ - 128)) | (1L << (RANGE_ - 128)) | (1L << (PRECEDING_ - 128)) | (1L << (UNBOUNDED_ - 128)) | (1L << (CURRENT_ - 128)) | (1L << (FOLLOWING_ - 128)) | (1L << (CUME_DIST_ - 128)) | (1L << (DENSE_RANK_ - 128)) | (1L << (LAG_ - 128)) | (1L << (LAST_VALUE_ - 128)) | (1L << (LEAD_ - 128)) | (1L << (NTH_VALUE_ - 128)) | (1L << (NTILE_ - 128)) | (1L << (PERCENT_RANK_ - 128)) | (1L << (RANK_ - 128)) | (1L << (ROW_NUMBER_ - 128)) | (1L << (GENERATED_ - 128)) | (1L << (ALWAYS_ - 128)) | (1L << (STORED_ - 128)) | (1L << (TRUE_ - 128)) | (1L << (FALSE_ - 128)) | (1L << (WINDOW_ - 128)) | (1L << (NULLS_ - 128)) | (1L << (FIRST_ - 128)) | (1L << (LAST_ - 128)) | (1L << (FILTER_ - 128)) | (1L << (GROUPS_ - 128)) | (1L << (EXCLUDE_ - 128)) | (1L << (IDENTIFIER - 128)) | (1L << (NUMERIC_LITERAL - 128)) | (1L << (BIND_PARAMETER - 128)) | (1L << (STRING_LITERAL - 128)) | (1L << (BLOB_LITERAL - 128)))) != 0)) {
								{
								State = 1063;
								expr(0);
								State = 1068;
								ErrorHandler.Sync(this);
								_la = TokenStream.LA(1);
								while (_la==COMMA) {
									{
									{
									State = 1064;
									Match(COMMA);
									State = 1065;
									expr(0);
									}
									}
									State = 1070;
									ErrorHandler.Sync(this);
									_la = TokenStream.LA(1);
								}
								}
							}

							State = 1073;
							Match(CLOSE_PAR);
							}
							break;
						}
						}
						break;
					}
					} 
				}
				State = 1081;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,136,Context);
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

	public partial class Raise_functionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RAISE_() { return GetToken(SQLiteParser.RAISE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IGNORE_() { return GetToken(SQLiteParser.IGNORE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(SQLiteParser.COMMA, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Error_messageContext error_message() {
			return GetRuleContext<Error_messageContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ROLLBACK_() { return GetToken(SQLiteParser.ROLLBACK_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ABORT_() { return GetToken(SQLiteParser.ABORT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FAIL_() { return GetToken(SQLiteParser.FAIL_, 0); }
		public Raise_functionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_raise_function; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterRaise_function(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitRaise_function(this);
		}
	}

	[RuleVersion(0)]
	public Raise_functionContext raise_function() {
		Raise_functionContext _localctx = new Raise_functionContext(Context, State);
		EnterRule(_localctx, 66, RULE_raise_function);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1082;
			Match(RAISE_);
			State = 1083;
			Match(OPEN_PAR);
			State = 1088;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case IGNORE_:
				{
				State = 1084;
				Match(IGNORE_);
				}
				break;
			case ABORT_:
			case FAIL_:
			case ROLLBACK_:
				{
				State = 1085;
				_la = TokenStream.LA(1);
				if ( !(_la==ABORT_ || _la==FAIL_ || _la==ROLLBACK_) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 1086;
				Match(COMMA);
				State = 1087;
				error_message();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 1090;
			Match(CLOSE_PAR);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Literal_valueContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUMERIC_LITERAL() { return GetToken(SQLiteParser.NUMERIC_LITERAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRING_LITERAL() { return GetToken(SQLiteParser.STRING_LITERAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BLOB_LITERAL() { return GetToken(SQLiteParser.BLOB_LITERAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NULL_() { return GetToken(SQLiteParser.NULL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRUE_() { return GetToken(SQLiteParser.TRUE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FALSE_() { return GetToken(SQLiteParser.FALSE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CURRENT_TIME_() { return GetToken(SQLiteParser.CURRENT_TIME_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CURRENT_DATE_() { return GetToken(SQLiteParser.CURRENT_DATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CURRENT_TIMESTAMP_() { return GetToken(SQLiteParser.CURRENT_TIMESTAMP_, 0); }
		public Literal_valueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_literal_value; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterLiteral_value(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitLiteral_value(this);
		}
	}

	[RuleVersion(0)]
	public Literal_valueContext literal_value() {
		Literal_valueContext _localctx = new Literal_valueContext(Context, State);
		EnterRule(_localctx, 68, RULE_literal_value);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1092;
			_la = TokenStream.LA(1);
			if ( !(((((_la - 52)) & ~0x3f) == 0 && ((1L << (_la - 52)) & ((1L << (CURRENT_DATE_ - 52)) | (1L << (CURRENT_TIME_ - 52)) | (1L << (CURRENT_TIMESTAMP_ - 52)) | (1L << (NULL_ - 52)))) != 0) || ((((_la - 172)) & ~0x3f) == 0 && ((1L << (_la - 172)) & ((1L << (TRUE_ - 172)) | (1L << (FALSE_ - 172)) | (1L << (NUMERIC_LITERAL - 172)) | (1L << (STRING_LITERAL - 172)) | (1L << (BLOB_LITERAL - 172)))) != 0)) ) {
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

	public partial class Insert_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTO_() { return GetToken(SQLiteParser.INTO_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Table_nameContext table_name() {
			return GetRuleContext<Table_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INSERT_() { return GetToken(SQLiteParser.INSERT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REPLACE_() { return GetToken(SQLiteParser.REPLACE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OR_() { return GetToken(SQLiteParser.OR_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFAULT_() { return GetToken(SQLiteParser.DEFAULT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VALUES_() { return GetToken(SQLiteParser.VALUES_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public With_clauseContext with_clause() {
			return GetRuleContext<With_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ROLLBACK_() { return GetToken(SQLiteParser.ROLLBACK_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ABORT_() { return GetToken(SQLiteParser.ABORT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FAIL_() { return GetToken(SQLiteParser.FAIL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IGNORE_() { return GetToken(SQLiteParser.IGNORE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Schema_nameContext schema_name() {
			return GetRuleContext<Schema_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(SQLiteParser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AS_() { return GetToken(SQLiteParser.AS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Table_aliasContext table_alias() {
			return GetRuleContext<Table_aliasContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OPEN_PAR() { return GetTokens(SQLiteParser.OPEN_PAR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR(int i) {
			return GetToken(SQLiteParser.OPEN_PAR, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext[] column_name() {
			return GetRuleContexts<Column_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext column_name(int i) {
			return GetRuleContext<Column_nameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] CLOSE_PAR() { return GetTokens(SQLiteParser.CLOSE_PAR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR(int i) {
			return GetToken(SQLiteParser.CLOSE_PAR, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Returning_clauseContext returning_clause() {
			return GetRuleContext<Returning_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Select_stmtContext select_stmt() {
			return GetRuleContext<Select_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Upsert_clauseContext upsert_clause() {
			return GetRuleContext<Upsert_clauseContext>(0);
		}
		public Insert_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_insert_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterInsert_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitInsert_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Insert_stmtContext insert_stmt() {
		Insert_stmtContext _localctx = new Insert_stmtContext(Context, State);
		EnterRule(_localctx, 70, RULE_insert_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1095;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WITH_) {
				{
				State = 1094;
				with_clause();
				}
			}

			State = 1102;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,139,Context) ) {
			case 1:
				{
				State = 1097;
				Match(INSERT_);
				}
				break;
			case 2:
				{
				State = 1098;
				Match(REPLACE_);
				}
				break;
			case 3:
				{
				State = 1099;
				Match(INSERT_);
				State = 1100;
				Match(OR_);
				State = 1101;
				_la = TokenStream.LA(1);
				if ( !(_la==ABORT_ || ((((_la - 72)) & ~0x3f) == 0 && ((1L << (_la - 72)) & ((1L << (FAIL_ - 72)) | (1L << (IGNORE_ - 72)) | (1L << (REPLACE_ - 72)) | (1L << (ROLLBACK_ - 72)))) != 0)) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
				break;
			}
			State = 1104;
			Match(INTO_);
			State = 1108;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,140,Context) ) {
			case 1:
				{
				State = 1105;
				schema_name();
				State = 1106;
				Match(DOT);
				}
				break;
			}
			State = 1110;
			table_name();
			State = 1113;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==AS_) {
				{
				State = 1111;
				Match(AS_);
				State = 1112;
				table_alias();
				}
			}

			State = 1126;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_PAR) {
				{
				State = 1115;
				Match(OPEN_PAR);
				State = 1116;
				column_name();
				State = 1121;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 1117;
					Match(COMMA);
					State = 1118;
					column_name();
					}
					}
					State = 1123;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 1124;
				Match(CLOSE_PAR);
				}
			}

			State = 1164;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case SELECT_:
			case VALUES_:
			case WITH_:
				{
				{
				State = 1157;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,147,Context) ) {
				case 1:
					{
					State = 1128;
					Match(VALUES_);
					State = 1129;
					Match(OPEN_PAR);
					State = 1130;
					expr(0);
					State = 1135;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==COMMA) {
						{
						{
						State = 1131;
						Match(COMMA);
						State = 1132;
						expr(0);
						}
						}
						State = 1137;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					State = 1138;
					Match(CLOSE_PAR);
					State = 1153;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==COMMA) {
						{
						{
						State = 1139;
						Match(COMMA);
						State = 1140;
						Match(OPEN_PAR);
						State = 1141;
						expr(0);
						State = 1146;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						while (_la==COMMA) {
							{
							{
							State = 1142;
							Match(COMMA);
							State = 1143;
							expr(0);
							}
							}
							State = 1148;
							ErrorHandler.Sync(this);
							_la = TokenStream.LA(1);
						}
						State = 1149;
						Match(CLOSE_PAR);
						}
						}
						State = 1155;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					}
					break;
				case 2:
					{
					State = 1156;
					select_stmt();
					}
					break;
				}
				State = 1160;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==ON_) {
					{
					State = 1159;
					upsert_clause();
					}
				}

				}
				}
				break;
			case DEFAULT_:
				{
				State = 1162;
				Match(DEFAULT_);
				State = 1163;
				Match(VALUES_);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 1167;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==RETURNING_) {
				{
				State = 1166;
				returning_clause();
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

	public partial class Returning_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RETURNING_() { return GetToken(SQLiteParser.RETURNING_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Result_columnContext[] result_column() {
			return GetRuleContexts<Result_columnContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Result_columnContext result_column(int i) {
			return GetRuleContext<Result_columnContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		public Returning_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_returning_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterReturning_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitReturning_clause(this);
		}
	}

	[RuleVersion(0)]
	public Returning_clauseContext returning_clause() {
		Returning_clauseContext _localctx = new Returning_clauseContext(Context, State);
		EnterRule(_localctx, 72, RULE_returning_clause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1169;
			Match(RETURNING_);
			State = 1170;
			result_column();
			State = 1175;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1171;
				Match(COMMA);
				State = 1172;
				result_column();
				}
				}
				State = 1177;
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

	public partial class Upsert_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ON_() { return GetToken(SQLiteParser.ON_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CONFLICT_() { return GetToken(SQLiteParser.CONFLICT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DO_() { return GetToken(SQLiteParser.DO_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOTHING_() { return GetToken(SQLiteParser.NOTHING_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UPDATE_() { return GetToken(SQLiteParser.UPDATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SET_() { return GetToken(SQLiteParser.SET_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Indexed_columnContext[] indexed_column() {
			return GetRuleContexts<Indexed_columnContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Indexed_columnContext indexed_column(int i) {
			return GetRuleContext<Indexed_columnContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ASSIGN() { return GetTokens(SQLiteParser.ASSIGN); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGN(int i) {
			return GetToken(SQLiteParser.ASSIGN, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] WHERE_() { return GetTokens(SQLiteParser.WHERE_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHERE_(int i) {
			return GetToken(SQLiteParser.WHERE_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext[] column_name() {
			return GetRuleContexts<Column_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext column_name(int i) {
			return GetRuleContext<Column_nameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_name_listContext[] column_name_list() {
			return GetRuleContexts<Column_name_listContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_name_listContext column_name_list(int i) {
			return GetRuleContext<Column_name_listContext>(i);
		}
		public Upsert_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_upsert_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterUpsert_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitUpsert_clause(this);
		}
	}

	[RuleVersion(0)]
	public Upsert_clauseContext upsert_clause() {
		Upsert_clauseContext _localctx = new Upsert_clauseContext(Context, State);
		EnterRule(_localctx, 74, RULE_upsert_clause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1178;
			Match(ON_);
			State = 1179;
			Match(CONFLICT_);
			State = 1194;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==OPEN_PAR) {
				{
				State = 1180;
				Match(OPEN_PAR);
				State = 1181;
				indexed_column();
				State = 1186;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 1182;
					Match(COMMA);
					State = 1183;
					indexed_column();
					}
					}
					State = 1188;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 1189;
				Match(CLOSE_PAR);
				State = 1192;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==WHERE_) {
					{
					State = 1190;
					Match(WHERE_);
					State = 1191;
					expr(0);
					}
				}

				}
			}

			State = 1196;
			Match(DO_);
			State = 1223;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case NOTHING_:
				{
				State = 1197;
				Match(NOTHING_);
				}
				break;
			case UPDATE_:
				{
				State = 1198;
				Match(UPDATE_);
				State = 1199;
				Match(SET_);
				{
				State = 1202;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,155,Context) ) {
				case 1:
					{
					State = 1200;
					column_name();
					}
					break;
				case 2:
					{
					State = 1201;
					column_name_list();
					}
					break;
				}
				State = 1204;
				Match(ASSIGN);
				State = 1205;
				expr(0);
				State = 1216;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 1206;
					Match(COMMA);
					State = 1209;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,156,Context) ) {
					case 1:
						{
						State = 1207;
						column_name();
						}
						break;
					case 2:
						{
						State = 1208;
						column_name_list();
						}
						break;
					}
					State = 1211;
					Match(ASSIGN);
					State = 1212;
					expr(0);
					}
					}
					State = 1218;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 1221;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==WHERE_) {
					{
					State = 1219;
					Match(WHERE_);
					State = 1220;
					expr(0);
					}
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

	public partial class Pragma_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRAGMA_() { return GetToken(SQLiteParser.PRAGMA_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Pragma_nameContext pragma_name() {
			return GetRuleContext<Pragma_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Schema_nameContext schema_name() {
			return GetRuleContext<Schema_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(SQLiteParser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGN() { return GetToken(SQLiteParser.ASSIGN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Pragma_valueContext pragma_value() {
			return GetRuleContext<Pragma_valueContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		public Pragma_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_pragma_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterPragma_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitPragma_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Pragma_stmtContext pragma_stmt() {
		Pragma_stmtContext _localctx = new Pragma_stmtContext(Context, State);
		EnterRule(_localctx, 76, RULE_pragma_stmt);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1225;
			Match(PRAGMA_);
			State = 1229;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,160,Context) ) {
			case 1:
				{
				State = 1226;
				schema_name();
				State = 1227;
				Match(DOT);
				}
				break;
			}
			State = 1231;
			pragma_name();
			State = 1238;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ASSIGN:
				{
				State = 1232;
				Match(ASSIGN);
				State = 1233;
				pragma_value();
				}
				break;
			case OPEN_PAR:
				{
				State = 1234;
				Match(OPEN_PAR);
				State = 1235;
				pragma_value();
				State = 1236;
				Match(CLOSE_PAR);
				}
				break;
			case Eof:
			case SCOL:
			case ALTER_:
			case ANALYZE_:
			case ATTACH_:
			case BEGIN_:
			case COMMIT_:
			case CREATE_:
			case DELETE_:
			case DETACH_:
			case DROP_:
			case END_:
			case EXPLAIN_:
			case INSERT_:
			case PRAGMA_:
			case REINDEX_:
			case RELEASE_:
			case REPLACE_:
			case ROLLBACK_:
			case SAVEPOINT_:
			case SELECT_:
			case UPDATE_:
			case VACUUM_:
			case VALUES_:
			case WITH_:
				break;
			default:
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

	public partial class Pragma_valueContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Signed_numberContext signed_number() {
			return GetRuleContext<Signed_numberContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public NameContext name() {
			return GetRuleContext<NameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRING_LITERAL() { return GetToken(SQLiteParser.STRING_LITERAL, 0); }
		public Pragma_valueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_pragma_value; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterPragma_value(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitPragma_value(this);
		}
	}

	[RuleVersion(0)]
	public Pragma_valueContext pragma_value() {
		Pragma_valueContext _localctx = new Pragma_valueContext(Context, State);
		EnterRule(_localctx, 78, RULE_pragma_value);
		try {
			State = 1243;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,162,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1240;
				signed_number();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1241;
				name();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1242;
				Match(STRING_LITERAL);
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

	public partial class Reindex_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REINDEX_() { return GetToken(SQLiteParser.REINDEX_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Collation_nameContext collation_name() {
			return GetRuleContext<Collation_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Table_nameContext table_name() {
			return GetRuleContext<Table_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Index_nameContext index_name() {
			return GetRuleContext<Index_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Schema_nameContext schema_name() {
			return GetRuleContext<Schema_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(SQLiteParser.DOT, 0); }
		public Reindex_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_reindex_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterReindex_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitReindex_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Reindex_stmtContext reindex_stmt() {
		Reindex_stmtContext _localctx = new Reindex_stmtContext(Context, State);
		EnterRule(_localctx, 80, RULE_reindex_stmt);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1245;
			Match(REINDEX_);
			State = 1256;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,165,Context) ) {
			case 1:
				{
				State = 1246;
				collation_name();
				}
				break;
			case 2:
				{
				State = 1250;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,163,Context) ) {
				case 1:
					{
					State = 1247;
					schema_name();
					State = 1248;
					Match(DOT);
					}
					break;
				}
				State = 1254;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,164,Context) ) {
				case 1:
					{
					State = 1252;
					table_name();
					}
					break;
				case 2:
					{
					State = 1253;
					index_name();
					}
					break;
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

	public partial class Select_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Select_coreContext[] select_core() {
			return GetRuleContexts<Select_coreContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Select_coreContext select_core(int i) {
			return GetRuleContext<Select_coreContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Common_table_stmtContext common_table_stmt() {
			return GetRuleContext<Common_table_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Compound_operatorContext[] compound_operator() {
			return GetRuleContexts<Compound_operatorContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Compound_operatorContext compound_operator(int i) {
			return GetRuleContext<Compound_operatorContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Order_by_stmtContext order_by_stmt() {
			return GetRuleContext<Order_by_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Limit_stmtContext limit_stmt() {
			return GetRuleContext<Limit_stmtContext>(0);
		}
		public Select_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_select_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterSelect_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitSelect_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Select_stmtContext select_stmt() {
		Select_stmtContext _localctx = new Select_stmtContext(Context, State);
		EnterRule(_localctx, 82, RULE_select_stmt);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1259;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WITH_) {
				{
				State = 1258;
				common_table_stmt();
				}
			}

			State = 1261;
			select_core();
			State = 1267;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,167,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 1262;
					compound_operator();
					State = 1263;
					select_core();
					}
					} 
				}
				State = 1269;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,167,Context);
			}
			State = 1271;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==ORDER_) {
				{
				State = 1270;
				order_by_stmt();
				}
			}

			State = 1274;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LIMIT_) {
				{
				State = 1273;
				limit_stmt();
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

	public partial class Join_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Table_or_subqueryContext[] table_or_subquery() {
			return GetRuleContexts<Table_or_subqueryContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Table_or_subqueryContext table_or_subquery(int i) {
			return GetRuleContext<Table_or_subqueryContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Join_operatorContext[] join_operator() {
			return GetRuleContexts<Join_operatorContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Join_operatorContext join_operator(int i) {
			return GetRuleContext<Join_operatorContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Join_constraintContext[] join_constraint() {
			return GetRuleContexts<Join_constraintContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Join_constraintContext join_constraint(int i) {
			return GetRuleContext<Join_constraintContext>(i);
		}
		public Join_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_join_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterJoin_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitJoin_clause(this);
		}
	}

	[RuleVersion(0)]
	public Join_clauseContext join_clause() {
		Join_clauseContext _localctx = new Join_clauseContext(Context, State);
		EnterRule(_localctx, 84, RULE_join_clause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1276;
			table_or_subquery();
			State = 1284;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA || _la==CROSS_ || ((((_la - 87)) & ~0x3f) == 0 && ((1L << (_la - 87)) & ((1L << (INNER_ - 87)) | (1L << (JOIN_ - 87)) | (1L << (LEFT_ - 87)) | (1L << (NATURAL_ - 87)))) != 0)) {
				{
				{
				State = 1277;
				join_operator();
				State = 1278;
				table_or_subquery();
				State = 1280;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,170,Context) ) {
				case 1:
					{
					State = 1279;
					join_constraint();
					}
					break;
				}
				}
				}
				State = 1286;
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

	public partial class Select_coreContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SELECT_() { return GetToken(SQLiteParser.SELECT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Result_columnContext[] result_column() {
			return GetRuleContexts<Result_columnContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Result_columnContext result_column(int i) {
			return GetRuleContext<Result_columnContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FROM_() { return GetToken(SQLiteParser.FROM_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHERE_() { return GetToken(SQLiteParser.WHERE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GROUP_() { return GetToken(SQLiteParser.GROUP_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BY_() { return GetToken(SQLiteParser.BY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WINDOW_() { return GetToken(SQLiteParser.WINDOW_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Window_nameContext[] window_name() {
			return GetRuleContexts<Window_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Window_nameContext window_name(int i) {
			return GetRuleContext<Window_nameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] AS_() { return GetTokens(SQLiteParser.AS_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AS_(int i) {
			return GetToken(SQLiteParser.AS_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Window_defnContext[] window_defn() {
			return GetRuleContexts<Window_defnContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Window_defnContext window_defn(int i) {
			return GetRuleContext<Window_defnContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DISTINCT_() { return GetToken(SQLiteParser.DISTINCT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ALL_() { return GetToken(SQLiteParser.ALL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Table_or_subqueryContext[] table_or_subquery() {
			return GetRuleContexts<Table_or_subqueryContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Table_or_subqueryContext table_or_subquery(int i) {
			return GetRuleContext<Table_or_subqueryContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Join_clauseContext join_clause() {
			return GetRuleContext<Join_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HAVING_() { return GetToken(SQLiteParser.HAVING_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VALUES_() { return GetToken(SQLiteParser.VALUES_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OPEN_PAR() { return GetTokens(SQLiteParser.OPEN_PAR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR(int i) {
			return GetToken(SQLiteParser.OPEN_PAR, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] CLOSE_PAR() { return GetTokens(SQLiteParser.CLOSE_PAR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR(int i) {
			return GetToken(SQLiteParser.CLOSE_PAR, i);
		}
		public Select_coreContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_select_core; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterSelect_core(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitSelect_core(this);
		}
	}

	[RuleVersion(0)]
	public Select_coreContext select_core() {
		Select_coreContext _localctx = new Select_coreContext(Context, State);
		EnterRule(_localctx, 86, RULE_select_core);
		int _la;
		try {
			State = 1377;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case SELECT_:
				EnterOuterAlt(_localctx, 1);
				{
				{
				State = 1287;
				Match(SELECT_);
				State = 1289;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,172,Context) ) {
				case 1:
					{
					State = 1288;
					_la = TokenStream.LA(1);
					if ( !(_la==ALL_ || _la==DISTINCT_) ) {
					ErrorHandler.RecoverInline(this);
					}
					else {
						ErrorHandler.ReportMatch(this);
					    Consume();
					}
					}
					break;
				}
				State = 1291;
				result_column();
				State = 1296;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 1292;
					Match(COMMA);
					State = 1293;
					result_column();
					}
					}
					State = 1298;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 1311;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==FROM_) {
					{
					State = 1299;
					Match(FROM_);
					State = 1309;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,175,Context) ) {
					case 1:
						{
						State = 1300;
						table_or_subquery();
						State = 1305;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
						while (_la==COMMA) {
							{
							{
							State = 1301;
							Match(COMMA);
							State = 1302;
							table_or_subquery();
							}
							}
							State = 1307;
							ErrorHandler.Sync(this);
							_la = TokenStream.LA(1);
						}
						}
						break;
					case 2:
						{
						State = 1308;
						join_clause();
						}
						break;
					}
					}
				}

				State = 1315;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==WHERE_) {
					{
					State = 1313;
					Match(WHERE_);
					State = 1314;
					expr(0);
					}
				}

				State = 1331;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==GROUP_) {
					{
					State = 1317;
					Match(GROUP_);
					State = 1318;
					Match(BY_);
					State = 1319;
					expr(0);
					State = 1324;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==COMMA) {
						{
						{
						State = 1320;
						Match(COMMA);
						State = 1321;
						expr(0);
						}
						}
						State = 1326;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					State = 1329;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==HAVING_) {
						{
						State = 1327;
						Match(HAVING_);
						State = 1328;
						expr(0);
						}
					}

					}
				}

				State = 1347;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==WINDOW_) {
					{
					State = 1333;
					Match(WINDOW_);
					State = 1334;
					window_name();
					State = 1335;
					Match(AS_);
					State = 1336;
					window_defn();
					State = 1344;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==COMMA) {
						{
						{
						State = 1337;
						Match(COMMA);
						State = 1338;
						window_name();
						State = 1339;
						Match(AS_);
						State = 1340;
						window_defn();
						}
						}
						State = 1346;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					}
				}

				}
				}
				break;
			case VALUES_:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1349;
				Match(VALUES_);
				State = 1350;
				Match(OPEN_PAR);
				State = 1351;
				expr(0);
				State = 1356;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 1352;
					Match(COMMA);
					State = 1353;
					expr(0);
					}
					}
					State = 1358;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 1359;
				Match(CLOSE_PAR);
				State = 1374;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 1360;
					Match(COMMA);
					State = 1361;
					Match(OPEN_PAR);
					State = 1362;
					expr(0);
					State = 1367;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==COMMA) {
						{
						{
						State = 1363;
						Match(COMMA);
						State = 1364;
						expr(0);
						}
						}
						State = 1369;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					State = 1370;
					Match(CLOSE_PAR);
					}
					}
					State = 1376;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
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

	public partial class Factored_select_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Select_stmtContext select_stmt() {
			return GetRuleContext<Select_stmtContext>(0);
		}
		public Factored_select_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_factored_select_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterFactored_select_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitFactored_select_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Factored_select_stmtContext factored_select_stmt() {
		Factored_select_stmtContext _localctx = new Factored_select_stmtContext(Context, State);
		EnterRule(_localctx, 88, RULE_factored_select_stmt);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1379;
			select_stmt();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Simple_select_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Select_coreContext select_core() {
			return GetRuleContext<Select_coreContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Common_table_stmtContext common_table_stmt() {
			return GetRuleContext<Common_table_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Order_by_stmtContext order_by_stmt() {
			return GetRuleContext<Order_by_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Limit_stmtContext limit_stmt() {
			return GetRuleContext<Limit_stmtContext>(0);
		}
		public Simple_select_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_simple_select_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterSimple_select_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitSimple_select_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Simple_select_stmtContext simple_select_stmt() {
		Simple_select_stmtContext _localctx = new Simple_select_stmtContext(Context, State);
		EnterRule(_localctx, 90, RULE_simple_select_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1382;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WITH_) {
				{
				State = 1381;
				common_table_stmt();
				}
			}

			State = 1384;
			select_core();
			State = 1386;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==ORDER_) {
				{
				State = 1385;
				order_by_stmt();
				}
			}

			State = 1389;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LIMIT_) {
				{
				State = 1388;
				limit_stmt();
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

	public partial class Compound_select_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Select_coreContext[] select_core() {
			return GetRuleContexts<Select_coreContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Select_coreContext select_core(int i) {
			return GetRuleContext<Select_coreContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Common_table_stmtContext common_table_stmt() {
			return GetRuleContext<Common_table_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Order_by_stmtContext order_by_stmt() {
			return GetRuleContext<Order_by_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Limit_stmtContext limit_stmt() {
			return GetRuleContext<Limit_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] UNION_() { return GetTokens(SQLiteParser.UNION_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNION_(int i) {
			return GetToken(SQLiteParser.UNION_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] INTERSECT_() { return GetTokens(SQLiteParser.INTERSECT_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERSECT_(int i) {
			return GetToken(SQLiteParser.INTERSECT_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] EXCEPT_() { return GetTokens(SQLiteParser.EXCEPT_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXCEPT_(int i) {
			return GetToken(SQLiteParser.EXCEPT_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ALL_() { return GetTokens(SQLiteParser.ALL_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ALL_(int i) {
			return GetToken(SQLiteParser.ALL_, i);
		}
		public Compound_select_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compound_select_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterCompound_select_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitCompound_select_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Compound_select_stmtContext compound_select_stmt() {
		Compound_select_stmtContext _localctx = new Compound_select_stmtContext(Context, State);
		EnterRule(_localctx, 92, RULE_compound_select_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1392;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WITH_) {
				{
				State = 1391;
				common_table_stmt();
				}
			}

			State = 1394;
			select_core();
			State = 1404;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 1401;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case UNION_:
					{
					State = 1395;
					Match(UNION_);
					State = 1397;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==ALL_) {
						{
						State = 1396;
						Match(ALL_);
						}
					}

					}
					break;
				case INTERSECT_:
					{
					State = 1399;
					Match(INTERSECT_);
					}
					break;
				case EXCEPT_:
					{
					State = 1400;
					Match(EXCEPT_);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 1403;
				select_core();
				}
				}
				State = 1406;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==EXCEPT_ || _la==INTERSECT_ || _la==UNION_ );
			State = 1409;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==ORDER_) {
				{
				State = 1408;
				order_by_stmt();
				}
			}

			State = 1412;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LIMIT_) {
				{
				State = 1411;
				limit_stmt();
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

	public partial class Table_or_subqueryContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Table_nameContext table_name() {
			return GetRuleContext<Table_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Schema_nameContext schema_name() {
			return GetRuleContext<Schema_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(SQLiteParser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Table_aliasContext table_alias() {
			return GetRuleContext<Table_aliasContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INDEXED_() { return GetToken(SQLiteParser.INDEXED_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BY_() { return GetToken(SQLiteParser.BY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Index_nameContext index_name() {
			return GetRuleContext<Index_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOT_() { return GetToken(SQLiteParser.NOT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AS_() { return GetToken(SQLiteParser.AS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Table_function_nameContext table_function_name() {
			return GetRuleContext<Table_function_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Table_or_subqueryContext[] table_or_subquery() {
			return GetRuleContexts<Table_or_subqueryContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Table_or_subqueryContext table_or_subquery(int i) {
			return GetRuleContext<Table_or_subqueryContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Join_clauseContext join_clause() {
			return GetRuleContext<Join_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Select_stmtContext select_stmt() {
			return GetRuleContext<Select_stmtContext>(0);
		}
		public Table_or_subqueryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_table_or_subquery; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterTable_or_subquery(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitTable_or_subquery(this);
		}
	}

	[RuleVersion(0)]
	public Table_or_subqueryContext table_or_subquery() {
		Table_or_subqueryContext _localctx = new Table_or_subqueryContext(Context, State);
		EnterRule(_localctx, 94, RULE_table_or_subquery);
		int _la;
		try {
			State = 1478;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,208,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				{
				State = 1417;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,196,Context) ) {
				case 1:
					{
					State = 1414;
					schema_name();
					State = 1415;
					Match(DOT);
					}
					break;
				}
				State = 1419;
				table_name();
				State = 1424;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,198,Context) ) {
				case 1:
					{
					State = 1421;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,197,Context) ) {
					case 1:
						{
						State = 1420;
						Match(AS_);
						}
						break;
					}
					State = 1423;
					table_alias();
					}
					break;
				}
				State = 1431;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case INDEXED_:
					{
					State = 1426;
					Match(INDEXED_);
					State = 1427;
					Match(BY_);
					State = 1428;
					index_name();
					}
					break;
				case NOT_:
					{
					State = 1429;
					Match(NOT_);
					State = 1430;
					Match(INDEXED_);
					}
					break;
				case Eof:
				case SCOL:
				case CLOSE_PAR:
				case COMMA:
				case ALTER_:
				case ANALYZE_:
				case ATTACH_:
				case BEGIN_:
				case COMMIT_:
				case CREATE_:
				case CROSS_:
				case DELETE_:
				case DETACH_:
				case DROP_:
				case END_:
				case EXCEPT_:
				case EXPLAIN_:
				case GROUP_:
				case INNER_:
				case INSERT_:
				case INTERSECT_:
				case JOIN_:
				case LEFT_:
				case LIMIT_:
				case NATURAL_:
				case ON_:
				case ORDER_:
				case PRAGMA_:
				case REINDEX_:
				case RELEASE_:
				case REPLACE_:
				case RETURNING_:
				case ROLLBACK_:
				case SAVEPOINT_:
				case SELECT_:
				case UNION_:
				case UPDATE_:
				case USING_:
				case VACUUM_:
				case VALUES_:
				case WHERE_:
				case WITH_:
				case WINDOW_:
					break;
				default:
					break;
				}
				}
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1436;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,200,Context) ) {
				case 1:
					{
					State = 1433;
					schema_name();
					State = 1434;
					Match(DOT);
					}
					break;
				}
				State = 1438;
				table_function_name();
				State = 1439;
				Match(OPEN_PAR);
				State = 1440;
				expr(0);
				State = 1445;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 1441;
					Match(COMMA);
					State = 1442;
					expr(0);
					}
					}
					State = 1447;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 1448;
				Match(CLOSE_PAR);
				State = 1453;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,203,Context) ) {
				case 1:
					{
					State = 1450;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,202,Context) ) {
					case 1:
						{
						State = 1449;
						Match(AS_);
						}
						break;
					}
					State = 1452;
					table_alias();
					}
					break;
				}
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1455;
				Match(OPEN_PAR);
				State = 1465;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,205,Context) ) {
				case 1:
					{
					State = 1456;
					table_or_subquery();
					State = 1461;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==COMMA) {
						{
						{
						State = 1457;
						Match(COMMA);
						State = 1458;
						table_or_subquery();
						}
						}
						State = 1463;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					}
					break;
				case 2:
					{
					State = 1464;
					join_clause();
					}
					break;
				}
				State = 1467;
				Match(CLOSE_PAR);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1469;
				Match(OPEN_PAR);
				State = 1470;
				select_stmt();
				State = 1471;
				Match(CLOSE_PAR);
				State = 1476;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,207,Context) ) {
				case 1:
					{
					State = 1473;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,206,Context) ) {
					case 1:
						{
						State = 1472;
						Match(AS_);
						}
						break;
					}
					State = 1475;
					table_alias();
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

	public partial class Result_columnContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STAR() { return GetToken(SQLiteParser.STAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Table_nameContext table_name() {
			return GetRuleContext<Table_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(SQLiteParser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_aliasContext column_alias() {
			return GetRuleContext<Column_aliasContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AS_() { return GetToken(SQLiteParser.AS_, 0); }
		public Result_columnContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_result_column; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterResult_column(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitResult_column(this);
		}
	}

	[RuleVersion(0)]
	public Result_columnContext result_column() {
		Result_columnContext _localctx = new Result_columnContext(Context, State);
		EnterRule(_localctx, 96, RULE_result_column);
		int _la;
		try {
			State = 1492;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,211,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1480;
				Match(STAR);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1481;
				table_name();
				State = 1482;
				Match(DOT);
				State = 1483;
				Match(STAR);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1485;
				expr(0);
				State = 1490;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==AS_ || _la==IDENTIFIER || _la==STRING_LITERAL) {
					{
					State = 1487;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==AS_) {
						{
						State = 1486;
						Match(AS_);
						}
					}

					State = 1489;
					column_alias();
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

	public partial class Join_operatorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(SQLiteParser.COMMA, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode JOIN_() { return GetToken(SQLiteParser.JOIN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NATURAL_() { return GetToken(SQLiteParser.NATURAL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LEFT_() { return GetToken(SQLiteParser.LEFT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INNER_() { return GetToken(SQLiteParser.INNER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CROSS_() { return GetToken(SQLiteParser.CROSS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OUTER_() { return GetToken(SQLiteParser.OUTER_, 0); }
		public Join_operatorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_join_operator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterJoin_operator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitJoin_operator(this);
		}
	}

	[RuleVersion(0)]
	public Join_operatorContext join_operator() {
		Join_operatorContext _localctx = new Join_operatorContext(Context, State);
		EnterRule(_localctx, 98, RULE_join_operator);
		int _la;
		try {
			State = 1507;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case COMMA:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1494;
				Match(COMMA);
				}
				break;
			case CROSS_:
			case INNER_:
			case JOIN_:
			case LEFT_:
			case NATURAL_:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1496;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==NATURAL_) {
					{
					State = 1495;
					Match(NATURAL_);
					}
				}

				State = 1504;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case LEFT_:
					{
					State = 1498;
					Match(LEFT_);
					State = 1500;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==OUTER_) {
						{
						State = 1499;
						Match(OUTER_);
						}
					}

					}
					break;
				case INNER_:
					{
					State = 1502;
					Match(INNER_);
					}
					break;
				case CROSS_:
					{
					State = 1503;
					Match(CROSS_);
					}
					break;
				case JOIN_:
					break;
				default:
					break;
				}
				State = 1506;
				Match(JOIN_);
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

	public partial class Join_constraintContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ON_() { return GetToken(SQLiteParser.ON_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode USING_() { return GetToken(SQLiteParser.USING_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext[] column_name() {
			return GetRuleContexts<Column_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext column_name(int i) {
			return GetRuleContext<Column_nameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		public Join_constraintContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_join_constraint; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterJoin_constraint(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitJoin_constraint(this);
		}
	}

	[RuleVersion(0)]
	public Join_constraintContext join_constraint() {
		Join_constraintContext _localctx = new Join_constraintContext(Context, State);
		EnterRule(_localctx, 100, RULE_join_constraint);
		int _la;
		try {
			State = 1523;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ON_:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1509;
				Match(ON_);
				State = 1510;
				expr(0);
				}
				break;
			case USING_:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1511;
				Match(USING_);
				State = 1512;
				Match(OPEN_PAR);
				State = 1513;
				column_name();
				State = 1518;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 1514;
					Match(COMMA);
					State = 1515;
					column_name();
					}
					}
					State = 1520;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 1521;
				Match(CLOSE_PAR);
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

	public partial class Compound_operatorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNION_() { return GetToken(SQLiteParser.UNION_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ALL_() { return GetToken(SQLiteParser.ALL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERSECT_() { return GetToken(SQLiteParser.INTERSECT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXCEPT_() { return GetToken(SQLiteParser.EXCEPT_, 0); }
		public Compound_operatorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compound_operator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterCompound_operator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitCompound_operator(this);
		}
	}

	[RuleVersion(0)]
	public Compound_operatorContext compound_operator() {
		Compound_operatorContext _localctx = new Compound_operatorContext(Context, State);
		EnterRule(_localctx, 102, RULE_compound_operator);
		int _la;
		try {
			State = 1531;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case UNION_:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1525;
				Match(UNION_);
				State = 1527;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==ALL_) {
					{
					State = 1526;
					Match(ALL_);
					}
				}

				}
				break;
			case INTERSECT_:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1529;
				Match(INTERSECT_);
				}
				break;
			case EXCEPT_:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1530;
				Match(EXCEPT_);
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

	public partial class Update_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UPDATE_() { return GetToken(SQLiteParser.UPDATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Qualified_table_nameContext qualified_table_name() {
			return GetRuleContext<Qualified_table_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SET_() { return GetToken(SQLiteParser.SET_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ASSIGN() { return GetTokens(SQLiteParser.ASSIGN); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGN(int i) {
			return GetToken(SQLiteParser.ASSIGN, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext[] column_name() {
			return GetRuleContexts<Column_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext column_name(int i) {
			return GetRuleContext<Column_nameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_name_listContext[] column_name_list() {
			return GetRuleContexts<Column_name_listContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_name_listContext column_name_list(int i) {
			return GetRuleContext<Column_name_listContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public With_clauseContext with_clause() {
			return GetRuleContext<With_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OR_() { return GetToken(SQLiteParser.OR_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FROM_() { return GetToken(SQLiteParser.FROM_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHERE_() { return GetToken(SQLiteParser.WHERE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Returning_clauseContext returning_clause() {
			return GetRuleContext<Returning_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ROLLBACK_() { return GetToken(SQLiteParser.ROLLBACK_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ABORT_() { return GetToken(SQLiteParser.ABORT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REPLACE_() { return GetToken(SQLiteParser.REPLACE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FAIL_() { return GetToken(SQLiteParser.FAIL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IGNORE_() { return GetToken(SQLiteParser.IGNORE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Table_or_subqueryContext[] table_or_subquery() {
			return GetRuleContexts<Table_or_subqueryContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Table_or_subqueryContext table_or_subquery(int i) {
			return GetRuleContext<Table_or_subqueryContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Join_clauseContext join_clause() {
			return GetRuleContext<Join_clauseContext>(0);
		}
		public Update_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_update_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterUpdate_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitUpdate_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Update_stmtContext update_stmt() {
		Update_stmtContext _localctx = new Update_stmtContext(Context, State);
		EnterRule(_localctx, 104, RULE_update_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1534;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WITH_) {
				{
				State = 1533;
				with_clause();
				}
			}

			State = 1536;
			Match(UPDATE_);
			State = 1539;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,221,Context) ) {
			case 1:
				{
				State = 1537;
				Match(OR_);
				State = 1538;
				_la = TokenStream.LA(1);
				if ( !(_la==ABORT_ || ((((_la - 72)) & ~0x3f) == 0 && ((1L << (_la - 72)) & ((1L << (FAIL_ - 72)) | (1L << (IGNORE_ - 72)) | (1L << (REPLACE_ - 72)) | (1L << (ROLLBACK_ - 72)))) != 0)) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
				break;
			}
			State = 1541;
			qualified_table_name();
			State = 1542;
			Match(SET_);
			State = 1545;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,222,Context) ) {
			case 1:
				{
				State = 1543;
				column_name();
				}
				break;
			case 2:
				{
				State = 1544;
				column_name_list();
				}
				break;
			}
			State = 1547;
			Match(ASSIGN);
			State = 1548;
			expr(0);
			State = 1559;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1549;
				Match(COMMA);
				State = 1552;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,223,Context) ) {
				case 1:
					{
					State = 1550;
					column_name();
					}
					break;
				case 2:
					{
					State = 1551;
					column_name_list();
					}
					break;
				}
				State = 1554;
				Match(ASSIGN);
				State = 1555;
				expr(0);
				}
				}
				State = 1561;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1574;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==FROM_) {
				{
				State = 1562;
				Match(FROM_);
				State = 1572;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,226,Context) ) {
				case 1:
					{
					State = 1563;
					table_or_subquery();
					State = 1568;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==COMMA) {
						{
						{
						State = 1564;
						Match(COMMA);
						State = 1565;
						table_or_subquery();
						}
						}
						State = 1570;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					}
					break;
				case 2:
					{
					State = 1571;
					join_clause();
					}
					break;
				}
				}
			}

			State = 1578;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WHERE_) {
				{
				State = 1576;
				Match(WHERE_);
				State = 1577;
				expr(0);
				}
			}

			State = 1581;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==RETURNING_) {
				{
				State = 1580;
				returning_clause();
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

	public partial class Column_name_listContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext[] column_name() {
			return GetRuleContexts<Column_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext column_name(int i) {
			return GetRuleContext<Column_nameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		public Column_name_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_column_name_list; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterColumn_name_list(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitColumn_name_list(this);
		}
	}

	[RuleVersion(0)]
	public Column_name_listContext column_name_list() {
		Column_name_listContext _localctx = new Column_name_listContext(Context, State);
		EnterRule(_localctx, 106, RULE_column_name_list);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1583;
			Match(OPEN_PAR);
			State = 1584;
			column_name();
			State = 1589;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1585;
				Match(COMMA);
				State = 1586;
				column_name();
				}
				}
				State = 1591;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1592;
			Match(CLOSE_PAR);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Update_stmt_limitedContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UPDATE_() { return GetToken(SQLiteParser.UPDATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Qualified_table_nameContext qualified_table_name() {
			return GetRuleContext<Qualified_table_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SET_() { return GetToken(SQLiteParser.SET_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ASSIGN() { return GetTokens(SQLiteParser.ASSIGN); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASSIGN(int i) {
			return GetToken(SQLiteParser.ASSIGN, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext[] column_name() {
			return GetRuleContexts<Column_nameContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_nameContext column_name(int i) {
			return GetRuleContext<Column_nameContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_name_listContext[] column_name_list() {
			return GetRuleContexts<Column_name_listContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_name_listContext column_name_list(int i) {
			return GetRuleContext<Column_name_listContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public With_clauseContext with_clause() {
			return GetRuleContext<With_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OR_() { return GetToken(SQLiteParser.OR_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHERE_() { return GetToken(SQLiteParser.WHERE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Returning_clauseContext returning_clause() {
			return GetRuleContext<Returning_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Limit_stmtContext limit_stmt() {
			return GetRuleContext<Limit_stmtContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ROLLBACK_() { return GetToken(SQLiteParser.ROLLBACK_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ABORT_() { return GetToken(SQLiteParser.ABORT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REPLACE_() { return GetToken(SQLiteParser.REPLACE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FAIL_() { return GetToken(SQLiteParser.FAIL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IGNORE_() { return GetToken(SQLiteParser.IGNORE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Order_by_stmtContext order_by_stmt() {
			return GetRuleContext<Order_by_stmtContext>(0);
		}
		public Update_stmt_limitedContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_update_stmt_limited; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterUpdate_stmt_limited(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitUpdate_stmt_limited(this);
		}
	}

	[RuleVersion(0)]
	public Update_stmt_limitedContext update_stmt_limited() {
		Update_stmt_limitedContext _localctx = new Update_stmt_limitedContext(Context, State);
		EnterRule(_localctx, 108, RULE_update_stmt_limited);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1595;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WITH_) {
				{
				State = 1594;
				with_clause();
				}
			}

			State = 1597;
			Match(UPDATE_);
			State = 1600;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,232,Context) ) {
			case 1:
				{
				State = 1598;
				Match(OR_);
				State = 1599;
				_la = TokenStream.LA(1);
				if ( !(_la==ABORT_ || ((((_la - 72)) & ~0x3f) == 0 && ((1L << (_la - 72)) & ((1L << (FAIL_ - 72)) | (1L << (IGNORE_ - 72)) | (1L << (REPLACE_ - 72)) | (1L << (ROLLBACK_ - 72)))) != 0)) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
				break;
			}
			State = 1602;
			qualified_table_name();
			State = 1603;
			Match(SET_);
			State = 1606;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,233,Context) ) {
			case 1:
				{
				State = 1604;
				column_name();
				}
				break;
			case 2:
				{
				State = 1605;
				column_name_list();
				}
				break;
			}
			State = 1608;
			Match(ASSIGN);
			State = 1609;
			expr(0);
			State = 1620;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1610;
				Match(COMMA);
				State = 1613;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,234,Context) ) {
				case 1:
					{
					State = 1611;
					column_name();
					}
					break;
				case 2:
					{
					State = 1612;
					column_name_list();
					}
					break;
				}
				State = 1615;
				Match(ASSIGN);
				State = 1616;
				expr(0);
				}
				}
				State = 1622;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 1625;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==WHERE_) {
				{
				State = 1623;
				Match(WHERE_);
				State = 1624;
				expr(0);
				}
			}

			State = 1628;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==RETURNING_) {
				{
				State = 1627;
				returning_clause();
				}
			}

			State = 1634;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LIMIT_ || _la==ORDER_) {
				{
				State = 1631;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==ORDER_) {
					{
					State = 1630;
					order_by_stmt();
					}
				}

				State = 1633;
				limit_stmt();
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

	public partial class Qualified_table_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Table_nameContext table_name() {
			return GetRuleContext<Table_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Schema_nameContext schema_name() {
			return GetRuleContext<Schema_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOT() { return GetToken(SQLiteParser.DOT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AS_() { return GetToken(SQLiteParser.AS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public AliasContext alias() {
			return GetRuleContext<AliasContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INDEXED_() { return GetToken(SQLiteParser.INDEXED_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BY_() { return GetToken(SQLiteParser.BY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Index_nameContext index_name() {
			return GetRuleContext<Index_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOT_() { return GetToken(SQLiteParser.NOT_, 0); }
		public Qualified_table_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_qualified_table_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterQualified_table_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitQualified_table_name(this);
		}
	}

	[RuleVersion(0)]
	public Qualified_table_nameContext qualified_table_name() {
		Qualified_table_nameContext _localctx = new Qualified_table_nameContext(Context, State);
		EnterRule(_localctx, 110, RULE_qualified_table_name);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1639;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,240,Context) ) {
			case 1:
				{
				State = 1636;
				schema_name();
				State = 1637;
				Match(DOT);
				}
				break;
			}
			State = 1641;
			table_name();
			State = 1644;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==AS_) {
				{
				State = 1642;
				Match(AS_);
				State = 1643;
				alias();
				}
			}

			State = 1651;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case INDEXED_:
				{
				State = 1646;
				Match(INDEXED_);
				State = 1647;
				Match(BY_);
				State = 1648;
				index_name();
				}
				break;
			case NOT_:
				{
				State = 1649;
				Match(NOT_);
				State = 1650;
				Match(INDEXED_);
				}
				break;
			case Eof:
			case SCOL:
			case ALTER_:
			case ANALYZE_:
			case ATTACH_:
			case BEGIN_:
			case COMMIT_:
			case CREATE_:
			case DELETE_:
			case DETACH_:
			case DROP_:
			case END_:
			case EXPLAIN_:
			case INSERT_:
			case LIMIT_:
			case ORDER_:
			case PRAGMA_:
			case REINDEX_:
			case RELEASE_:
			case REPLACE_:
			case RETURNING_:
			case ROLLBACK_:
			case SAVEPOINT_:
			case SELECT_:
			case SET_:
			case UPDATE_:
			case VACUUM_:
			case VALUES_:
			case WHERE_:
			case WITH_:
				break;
			default:
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

	public partial class Vacuum_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VACUUM_() { return GetToken(SQLiteParser.VACUUM_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Schema_nameContext schema_name() {
			return GetRuleContext<Schema_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTO_() { return GetToken(SQLiteParser.INTO_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public FilenameContext filename() {
			return GetRuleContext<FilenameContext>(0);
		}
		public Vacuum_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_vacuum_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterVacuum_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitVacuum_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Vacuum_stmtContext vacuum_stmt() {
		Vacuum_stmtContext _localctx = new Vacuum_stmtContext(Context, State);
		EnterRule(_localctx, 112, RULE_vacuum_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1653;
			Match(VACUUM_);
			State = 1655;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,243,Context) ) {
			case 1:
				{
				State = 1654;
				schema_name();
				}
				break;
			}
			State = 1659;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==INTO_) {
				{
				State = 1657;
				Match(INTO_);
				State = 1658;
				filename();
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

	public partial class Filter_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FILTER_() { return GetToken(SQLiteParser.FILTER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHERE_() { return GetToken(SQLiteParser.WHERE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		public Filter_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_filter_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterFilter_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitFilter_clause(this);
		}
	}

	[RuleVersion(0)]
	public Filter_clauseContext filter_clause() {
		Filter_clauseContext _localctx = new Filter_clauseContext(Context, State);
		EnterRule(_localctx, 114, RULE_filter_clause);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1661;
			Match(FILTER_);
			State = 1662;
			Match(OPEN_PAR);
			State = 1663;
			Match(WHERE_);
			State = 1664;
			expr(0);
			State = 1665;
			Match(CLOSE_PAR);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Window_defnContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ORDER_() { return GetToken(SQLiteParser.ORDER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] BY_() { return GetTokens(SQLiteParser.BY_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BY_(int i) {
			return GetToken(SQLiteParser.BY_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Ordering_termContext[] ordering_term() {
			return GetRuleContexts<Ordering_termContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Ordering_termContext ordering_term(int i) {
			return GetRuleContext<Ordering_termContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Base_window_nameContext base_window_name() {
			return GetRuleContext<Base_window_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PARTITION_() { return GetToken(SQLiteParser.PARTITION_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Frame_specContext frame_spec() {
			return GetRuleContext<Frame_specContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		public Window_defnContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_window_defn; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterWindow_defn(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitWindow_defn(this);
		}
	}

	[RuleVersion(0)]
	public Window_defnContext window_defn() {
		Window_defnContext _localctx = new Window_defnContext(Context, State);
		EnterRule(_localctx, 116, RULE_window_defn);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1667;
			Match(OPEN_PAR);
			State = 1669;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,245,Context) ) {
			case 1:
				{
				State = 1668;
				base_window_name();
				}
				break;
			}
			State = 1681;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==PARTITION_) {
				{
				State = 1671;
				Match(PARTITION_);
				State = 1672;
				Match(BY_);
				State = 1673;
				expr(0);
				State = 1678;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 1674;
					Match(COMMA);
					State = 1675;
					expr(0);
					}
					}
					State = 1680;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
			}

			{
			State = 1683;
			Match(ORDER_);
			State = 1684;
			Match(BY_);
			State = 1685;
			ordering_term();
			State = 1690;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1686;
				Match(COMMA);
				State = 1687;
				ordering_term();
				}
				}
				State = 1692;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
			State = 1694;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (ROWS_ - 128)) | (1L << (RANGE_ - 128)) | (1L << (GROUPS_ - 128)))) != 0)) {
				{
				State = 1693;
				frame_spec();
				}
			}

			State = 1696;
			Match(CLOSE_PAR);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Over_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OVER_() { return GetToken(SQLiteParser.OVER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Window_nameContext window_name() {
			return GetRuleContext<Window_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Base_window_nameContext base_window_name() {
			return GetRuleContext<Base_window_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PARTITION_() { return GetToken(SQLiteParser.PARTITION_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] BY_() { return GetTokens(SQLiteParser.BY_); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BY_(int i) {
			return GetToken(SQLiteParser.BY_, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ORDER_() { return GetToken(SQLiteParser.ORDER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Ordering_termContext[] ordering_term() {
			return GetRuleContexts<Ordering_termContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Ordering_termContext ordering_term(int i) {
			return GetRuleContext<Ordering_termContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Frame_specContext frame_spec() {
			return GetRuleContext<Frame_specContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		public Over_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_over_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterOver_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitOver_clause(this);
		}
	}

	[RuleVersion(0)]
	public Over_clauseContext over_clause() {
		Over_clauseContext _localctx = new Over_clauseContext(Context, State);
		EnterRule(_localctx, 118, RULE_over_clause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1698;
			Match(OVER_);
			State = 1732;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,256,Context) ) {
			case 1:
				{
				State = 1699;
				window_name();
				}
				break;
			case 2:
				{
				State = 1700;
				Match(OPEN_PAR);
				State = 1702;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,250,Context) ) {
				case 1:
					{
					State = 1701;
					base_window_name();
					}
					break;
				}
				State = 1714;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==PARTITION_) {
					{
					State = 1704;
					Match(PARTITION_);
					State = 1705;
					Match(BY_);
					State = 1706;
					expr(0);
					State = 1711;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==COMMA) {
						{
						{
						State = 1707;
						Match(COMMA);
						State = 1708;
						expr(0);
						}
						}
						State = 1713;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					}
				}

				State = 1726;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==ORDER_) {
					{
					State = 1716;
					Match(ORDER_);
					State = 1717;
					Match(BY_);
					State = 1718;
					ordering_term();
					State = 1723;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==COMMA) {
						{
						{
						State = 1719;
						Match(COMMA);
						State = 1720;
						ordering_term();
						}
						}
						State = 1725;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					}
				}

				State = 1729;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (ROWS_ - 128)) | (1L << (RANGE_ - 128)) | (1L << (GROUPS_ - 128)))) != 0)) {
					{
					State = 1728;
					frame_spec();
					}
				}

				State = 1731;
				Match(CLOSE_PAR);
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

	public partial class Frame_specContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Frame_clauseContext frame_clause() {
			return GetRuleContext<Frame_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXCLUDE_() { return GetToken(SQLiteParser.EXCLUDE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CURRENT_() { return GetToken(SQLiteParser.CURRENT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ROW_() { return GetToken(SQLiteParser.ROW_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GROUP_() { return GetToken(SQLiteParser.GROUP_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TIES_() { return GetToken(SQLiteParser.TIES_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NO_() { return GetToken(SQLiteParser.NO_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OTHERS_() { return GetToken(SQLiteParser.OTHERS_, 0); }
		public Frame_specContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_frame_spec; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterFrame_spec(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitFrame_spec(this);
		}
	}

	[RuleVersion(0)]
	public Frame_specContext frame_spec() {
		Frame_specContext _localctx = new Frame_specContext(Context, State);
		EnterRule(_localctx, 120, RULE_frame_spec);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1734;
			frame_clause();
			State = 1742;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case EXCLUDE_:
				{
				State = 1735;
				Match(EXCLUDE_);
				{
				State = 1736;
				Match(NO_);
				State = 1737;
				Match(OTHERS_);
				}
				}
				break;
			case CURRENT_:
				{
				State = 1738;
				Match(CURRENT_);
				State = 1739;
				Match(ROW_);
				}
				break;
			case GROUP_:
				{
				State = 1740;
				Match(GROUP_);
				}
				break;
			case TIES_:
				{
				State = 1741;
				Match(TIES_);
				}
				break;
			case CLOSE_PAR:
				break;
			default:
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

	public partial class Frame_clauseContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RANGE_() { return GetToken(SQLiteParser.RANGE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ROWS_() { return GetToken(SQLiteParser.ROWS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GROUPS_() { return GetToken(SQLiteParser.GROUPS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Frame_singleContext frame_single() {
			return GetRuleContext<Frame_singleContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BETWEEN_() { return GetToken(SQLiteParser.BETWEEN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Frame_leftContext frame_left() {
			return GetRuleContext<Frame_leftContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AND_() { return GetToken(SQLiteParser.AND_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Frame_rightContext frame_right() {
			return GetRuleContext<Frame_rightContext>(0);
		}
		public Frame_clauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_frame_clause; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterFrame_clause(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitFrame_clause(this);
		}
	}

	[RuleVersion(0)]
	public Frame_clauseContext frame_clause() {
		Frame_clauseContext _localctx = new Frame_clauseContext(Context, State);
		EnterRule(_localctx, 122, RULE_frame_clause);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1744;
			_la = TokenStream.LA(1);
			if ( !(((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (ROWS_ - 128)) | (1L << (RANGE_ - 128)) | (1L << (GROUPS_ - 128)))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			State = 1751;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,258,Context) ) {
			case 1:
				{
				State = 1745;
				frame_single();
				}
				break;
			case 2:
				{
				State = 1746;
				Match(BETWEEN_);
				State = 1747;
				frame_left();
				State = 1748;
				Match(AND_);
				State = 1749;
				frame_right();
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

	public partial class Simple_function_invocationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Simple_funcContext simple_func() {
			return GetRuleContext<Simple_funcContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STAR() { return GetToken(SQLiteParser.STAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		public Simple_function_invocationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_simple_function_invocation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterSimple_function_invocation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitSimple_function_invocation(this);
		}
	}

	[RuleVersion(0)]
	public Simple_function_invocationContext simple_function_invocation() {
		Simple_function_invocationContext _localctx = new Simple_function_invocationContext(Context, State);
		EnterRule(_localctx, 124, RULE_simple_function_invocation);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1753;
			simple_func();
			State = 1754;
			Match(OPEN_PAR);
			State = 1764;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case OPEN_PAR:
			case PLUS:
			case MINUS:
			case TILDE:
			case ABORT_:
			case ACTION_:
			case ADD_:
			case AFTER_:
			case ALL_:
			case ALTER_:
			case ANALYZE_:
			case AND_:
			case AS_:
			case ASC_:
			case ATTACH_:
			case AUTOINCREMENT_:
			case BEFORE_:
			case BEGIN_:
			case BETWEEN_:
			case BY_:
			case CASCADE_:
			case CASE_:
			case CAST_:
			case CHECK_:
			case COLLATE_:
			case COLUMN_:
			case COMMIT_:
			case CONFLICT_:
			case CONSTRAINT_:
			case CREATE_:
			case CROSS_:
			case CURRENT_DATE_:
			case CURRENT_TIME_:
			case CURRENT_TIMESTAMP_:
			case DATABASE_:
			case DEFAULT_:
			case DEFERRABLE_:
			case DEFERRED_:
			case DELETE_:
			case DESC_:
			case DETACH_:
			case DISTINCT_:
			case DROP_:
			case EACH_:
			case ELSE_:
			case END_:
			case ESCAPE_:
			case EXCEPT_:
			case EXCLUSIVE_:
			case EXISTS_:
			case EXPLAIN_:
			case FAIL_:
			case FOR_:
			case FOREIGN_:
			case FROM_:
			case FULL_:
			case GLOB_:
			case GROUP_:
			case HAVING_:
			case IF_:
			case IGNORE_:
			case IMMEDIATE_:
			case IN_:
			case INDEX_:
			case INDEXED_:
			case INITIALLY_:
			case INNER_:
			case INSERT_:
			case INSTEAD_:
			case INTERSECT_:
			case INTO_:
			case IS_:
			case ISNULL_:
			case JOIN_:
			case KEY_:
			case LEFT_:
			case LIKE_:
			case LIMIT_:
			case MATCH_:
			case NATURAL_:
			case NO_:
			case NOT_:
			case NOTNULL_:
			case NULL_:
			case OF_:
			case OFFSET_:
			case ON_:
			case OR_:
			case ORDER_:
			case OUTER_:
			case PLAN_:
			case PRAGMA_:
			case PRIMARY_:
			case QUERY_:
			case RAISE_:
			case RECURSIVE_:
			case REFERENCES_:
			case REGEXP_:
			case REINDEX_:
			case RELEASE_:
			case RENAME_:
			case REPLACE_:
			case RESTRICT_:
			case RIGHT_:
			case ROLLBACK_:
			case ROW_:
			case ROWS_:
			case SAVEPOINT_:
			case SELECT_:
			case SET_:
			case TABLE_:
			case TEMP_:
			case TEMPORARY_:
			case THEN_:
			case TO_:
			case TRANSACTION_:
			case TRIGGER_:
			case UNION_:
			case UNIQUE_:
			case UPDATE_:
			case USING_:
			case VACUUM_:
			case VALUES_:
			case VIEW_:
			case VIRTUAL_:
			case WHEN_:
			case WHERE_:
			case WITH_:
			case WITHOUT_:
			case FIRST_VALUE_:
			case OVER_:
			case PARTITION_:
			case RANGE_:
			case PRECEDING_:
			case UNBOUNDED_:
			case CURRENT_:
			case FOLLOWING_:
			case CUME_DIST_:
			case DENSE_RANK_:
			case LAG_:
			case LAST_VALUE_:
			case LEAD_:
			case NTH_VALUE_:
			case NTILE_:
			case PERCENT_RANK_:
			case RANK_:
			case ROW_NUMBER_:
			case GENERATED_:
			case ALWAYS_:
			case STORED_:
			case TRUE_:
			case FALSE_:
			case WINDOW_:
			case NULLS_:
			case FIRST_:
			case LAST_:
			case FILTER_:
			case GROUPS_:
			case EXCLUDE_:
			case IDENTIFIER:
			case NUMERIC_LITERAL:
			case BIND_PARAMETER:
			case STRING_LITERAL:
			case BLOB_LITERAL:
				{
				State = 1755;
				expr(0);
				State = 1760;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 1756;
					Match(COMMA);
					State = 1757;
					expr(0);
					}
					}
					State = 1762;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
				break;
			case STAR:
				{
				State = 1763;
				Match(STAR);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 1766;
			Match(CLOSE_PAR);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Aggregate_function_invocationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Aggregate_funcContext aggregate_func() {
			return GetRuleContext<Aggregate_funcContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STAR() { return GetToken(SQLiteParser.STAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Filter_clauseContext filter_clause() {
			return GetRuleContext<Filter_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DISTINCT_() { return GetToken(SQLiteParser.DISTINCT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		public Aggregate_function_invocationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_aggregate_function_invocation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterAggregate_function_invocation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitAggregate_function_invocation(this);
		}
	}

	[RuleVersion(0)]
	public Aggregate_function_invocationContext aggregate_function_invocation() {
		Aggregate_function_invocationContext _localctx = new Aggregate_function_invocationContext(Context, State);
		EnterRule(_localctx, 126, RULE_aggregate_function_invocation);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1768;
			aggregate_func();
			State = 1769;
			Match(OPEN_PAR);
			State = 1782;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case OPEN_PAR:
			case PLUS:
			case MINUS:
			case TILDE:
			case ABORT_:
			case ACTION_:
			case ADD_:
			case AFTER_:
			case ALL_:
			case ALTER_:
			case ANALYZE_:
			case AND_:
			case AS_:
			case ASC_:
			case ATTACH_:
			case AUTOINCREMENT_:
			case BEFORE_:
			case BEGIN_:
			case BETWEEN_:
			case BY_:
			case CASCADE_:
			case CASE_:
			case CAST_:
			case CHECK_:
			case COLLATE_:
			case COLUMN_:
			case COMMIT_:
			case CONFLICT_:
			case CONSTRAINT_:
			case CREATE_:
			case CROSS_:
			case CURRENT_DATE_:
			case CURRENT_TIME_:
			case CURRENT_TIMESTAMP_:
			case DATABASE_:
			case DEFAULT_:
			case DEFERRABLE_:
			case DEFERRED_:
			case DELETE_:
			case DESC_:
			case DETACH_:
			case DISTINCT_:
			case DROP_:
			case EACH_:
			case ELSE_:
			case END_:
			case ESCAPE_:
			case EXCEPT_:
			case EXCLUSIVE_:
			case EXISTS_:
			case EXPLAIN_:
			case FAIL_:
			case FOR_:
			case FOREIGN_:
			case FROM_:
			case FULL_:
			case GLOB_:
			case GROUP_:
			case HAVING_:
			case IF_:
			case IGNORE_:
			case IMMEDIATE_:
			case IN_:
			case INDEX_:
			case INDEXED_:
			case INITIALLY_:
			case INNER_:
			case INSERT_:
			case INSTEAD_:
			case INTERSECT_:
			case INTO_:
			case IS_:
			case ISNULL_:
			case JOIN_:
			case KEY_:
			case LEFT_:
			case LIKE_:
			case LIMIT_:
			case MATCH_:
			case NATURAL_:
			case NO_:
			case NOT_:
			case NOTNULL_:
			case NULL_:
			case OF_:
			case OFFSET_:
			case ON_:
			case OR_:
			case ORDER_:
			case OUTER_:
			case PLAN_:
			case PRAGMA_:
			case PRIMARY_:
			case QUERY_:
			case RAISE_:
			case RECURSIVE_:
			case REFERENCES_:
			case REGEXP_:
			case REINDEX_:
			case RELEASE_:
			case RENAME_:
			case REPLACE_:
			case RESTRICT_:
			case RIGHT_:
			case ROLLBACK_:
			case ROW_:
			case ROWS_:
			case SAVEPOINT_:
			case SELECT_:
			case SET_:
			case TABLE_:
			case TEMP_:
			case TEMPORARY_:
			case THEN_:
			case TO_:
			case TRANSACTION_:
			case TRIGGER_:
			case UNION_:
			case UNIQUE_:
			case UPDATE_:
			case USING_:
			case VACUUM_:
			case VALUES_:
			case VIEW_:
			case VIRTUAL_:
			case WHEN_:
			case WHERE_:
			case WITH_:
			case WITHOUT_:
			case FIRST_VALUE_:
			case OVER_:
			case PARTITION_:
			case RANGE_:
			case PRECEDING_:
			case UNBOUNDED_:
			case CURRENT_:
			case FOLLOWING_:
			case CUME_DIST_:
			case DENSE_RANK_:
			case LAG_:
			case LAST_VALUE_:
			case LEAD_:
			case NTH_VALUE_:
			case NTILE_:
			case PERCENT_RANK_:
			case RANK_:
			case ROW_NUMBER_:
			case GENERATED_:
			case ALWAYS_:
			case STORED_:
			case TRUE_:
			case FALSE_:
			case WINDOW_:
			case NULLS_:
			case FIRST_:
			case LAST_:
			case FILTER_:
			case GROUPS_:
			case EXCLUDE_:
			case IDENTIFIER:
			case NUMERIC_LITERAL:
			case BIND_PARAMETER:
			case STRING_LITERAL:
			case BLOB_LITERAL:
				{
				State = 1771;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,261,Context) ) {
				case 1:
					{
					State = 1770;
					Match(DISTINCT_);
					}
					break;
				}
				State = 1773;
				expr(0);
				State = 1778;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 1774;
					Match(COMMA);
					State = 1775;
					expr(0);
					}
					}
					State = 1780;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
				break;
			case STAR:
				{
				State = 1781;
				Match(STAR);
				}
				break;
			case CLOSE_PAR:
				break;
			default:
				break;
			}
			State = 1784;
			Match(CLOSE_PAR);
			State = 1786;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==FILTER_) {
				{
				State = 1785;
				filter_clause();
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

	public partial class Window_function_invocationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Window_functionContext window_function() {
			return GetRuleContext<Window_functionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OVER_() { return GetToken(SQLiteParser.OVER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Window_defnContext window_defn() {
			return GetRuleContext<Window_defnContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Window_nameContext window_name() {
			return GetRuleContext<Window_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STAR() { return GetToken(SQLiteParser.STAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Filter_clauseContext filter_clause() {
			return GetRuleContext<Filter_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		public Window_function_invocationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_window_function_invocation; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterWindow_function_invocation(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitWindow_function_invocation(this);
		}
	}

	[RuleVersion(0)]
	public Window_function_invocationContext window_function_invocation() {
		Window_function_invocationContext _localctx = new Window_function_invocationContext(Context, State);
		EnterRule(_localctx, 128, RULE_window_function_invocation);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1788;
			window_function();
			State = 1789;
			Match(OPEN_PAR);
			State = 1799;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case OPEN_PAR:
			case PLUS:
			case MINUS:
			case TILDE:
			case ABORT_:
			case ACTION_:
			case ADD_:
			case AFTER_:
			case ALL_:
			case ALTER_:
			case ANALYZE_:
			case AND_:
			case AS_:
			case ASC_:
			case ATTACH_:
			case AUTOINCREMENT_:
			case BEFORE_:
			case BEGIN_:
			case BETWEEN_:
			case BY_:
			case CASCADE_:
			case CASE_:
			case CAST_:
			case CHECK_:
			case COLLATE_:
			case COLUMN_:
			case COMMIT_:
			case CONFLICT_:
			case CONSTRAINT_:
			case CREATE_:
			case CROSS_:
			case CURRENT_DATE_:
			case CURRENT_TIME_:
			case CURRENT_TIMESTAMP_:
			case DATABASE_:
			case DEFAULT_:
			case DEFERRABLE_:
			case DEFERRED_:
			case DELETE_:
			case DESC_:
			case DETACH_:
			case DISTINCT_:
			case DROP_:
			case EACH_:
			case ELSE_:
			case END_:
			case ESCAPE_:
			case EXCEPT_:
			case EXCLUSIVE_:
			case EXISTS_:
			case EXPLAIN_:
			case FAIL_:
			case FOR_:
			case FOREIGN_:
			case FROM_:
			case FULL_:
			case GLOB_:
			case GROUP_:
			case HAVING_:
			case IF_:
			case IGNORE_:
			case IMMEDIATE_:
			case IN_:
			case INDEX_:
			case INDEXED_:
			case INITIALLY_:
			case INNER_:
			case INSERT_:
			case INSTEAD_:
			case INTERSECT_:
			case INTO_:
			case IS_:
			case ISNULL_:
			case JOIN_:
			case KEY_:
			case LEFT_:
			case LIKE_:
			case LIMIT_:
			case MATCH_:
			case NATURAL_:
			case NO_:
			case NOT_:
			case NOTNULL_:
			case NULL_:
			case OF_:
			case OFFSET_:
			case ON_:
			case OR_:
			case ORDER_:
			case OUTER_:
			case PLAN_:
			case PRAGMA_:
			case PRIMARY_:
			case QUERY_:
			case RAISE_:
			case RECURSIVE_:
			case REFERENCES_:
			case REGEXP_:
			case REINDEX_:
			case RELEASE_:
			case RENAME_:
			case REPLACE_:
			case RESTRICT_:
			case RIGHT_:
			case ROLLBACK_:
			case ROW_:
			case ROWS_:
			case SAVEPOINT_:
			case SELECT_:
			case SET_:
			case TABLE_:
			case TEMP_:
			case TEMPORARY_:
			case THEN_:
			case TO_:
			case TRANSACTION_:
			case TRIGGER_:
			case UNION_:
			case UNIQUE_:
			case UPDATE_:
			case USING_:
			case VACUUM_:
			case VALUES_:
			case VIEW_:
			case VIRTUAL_:
			case WHEN_:
			case WHERE_:
			case WITH_:
			case WITHOUT_:
			case FIRST_VALUE_:
			case OVER_:
			case PARTITION_:
			case RANGE_:
			case PRECEDING_:
			case UNBOUNDED_:
			case CURRENT_:
			case FOLLOWING_:
			case CUME_DIST_:
			case DENSE_RANK_:
			case LAG_:
			case LAST_VALUE_:
			case LEAD_:
			case NTH_VALUE_:
			case NTILE_:
			case PERCENT_RANK_:
			case RANK_:
			case ROW_NUMBER_:
			case GENERATED_:
			case ALWAYS_:
			case STORED_:
			case TRUE_:
			case FALSE_:
			case WINDOW_:
			case NULLS_:
			case FIRST_:
			case LAST_:
			case FILTER_:
			case GROUPS_:
			case EXCLUDE_:
			case IDENTIFIER:
			case NUMERIC_LITERAL:
			case BIND_PARAMETER:
			case STRING_LITERAL:
			case BLOB_LITERAL:
				{
				State = 1790;
				expr(0);
				State = 1795;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 1791;
					Match(COMMA);
					State = 1792;
					expr(0);
					}
					}
					State = 1797;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
				break;
			case STAR:
				{
				State = 1798;
				Match(STAR);
				}
				break;
			case CLOSE_PAR:
				break;
			default:
				break;
			}
			State = 1801;
			Match(CLOSE_PAR);
			State = 1803;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==FILTER_) {
				{
				State = 1802;
				filter_clause();
				}
			}

			State = 1805;
			Match(OVER_);
			State = 1808;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,268,Context) ) {
			case 1:
				{
				State = 1806;
				window_defn();
				}
				break;
			case 2:
				{
				State = 1807;
				window_name();
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

	public partial class Common_table_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WITH_() { return GetToken(SQLiteParser.WITH_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Common_table_expressionContext[] common_table_expression() {
			return GetRuleContexts<Common_table_expressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Common_table_expressionContext common_table_expression(int i) {
			return GetRuleContext<Common_table_expressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RECURSIVE_() { return GetToken(SQLiteParser.RECURSIVE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		public Common_table_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_common_table_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterCommon_table_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitCommon_table_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Common_table_stmtContext common_table_stmt() {
		Common_table_stmtContext _localctx = new Common_table_stmtContext(Context, State);
		EnterRule(_localctx, 130, RULE_common_table_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1810;
			Match(WITH_);
			State = 1812;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,269,Context) ) {
			case 1:
				{
				State = 1811;
				Match(RECURSIVE_);
				}
				break;
			}
			State = 1814;
			common_table_expression();
			State = 1819;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1815;
				Match(COMMA);
				State = 1816;
				common_table_expression();
				}
				}
				State = 1821;
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

	public partial class Order_by_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ORDER_() { return GetToken(SQLiteParser.ORDER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BY_() { return GetToken(SQLiteParser.BY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Ordering_termContext[] ordering_term() {
			return GetRuleContexts<Ordering_termContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Ordering_termContext ordering_term(int i) {
			return GetRuleContext<Ordering_termContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		public Order_by_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_order_by_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterOrder_by_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitOrder_by_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Order_by_stmtContext order_by_stmt() {
		Order_by_stmtContext _localctx = new Order_by_stmtContext(Context, State);
		EnterRule(_localctx, 132, RULE_order_by_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1822;
			Match(ORDER_);
			State = 1823;
			Match(BY_);
			State = 1824;
			ordering_term();
			State = 1829;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 1825;
				Match(COMMA);
				State = 1826;
				ordering_term();
				}
				}
				State = 1831;
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

	public partial class Limit_stmtContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LIMIT_() { return GetToken(SQLiteParser.LIMIT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OFFSET_() { return GetToken(SQLiteParser.OFFSET_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(SQLiteParser.COMMA, 0); }
		public Limit_stmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_limit_stmt; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterLimit_stmt(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitLimit_stmt(this);
		}
	}

	[RuleVersion(0)]
	public Limit_stmtContext limit_stmt() {
		Limit_stmtContext _localctx = new Limit_stmtContext(Context, State);
		EnterRule(_localctx, 134, RULE_limit_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1832;
			Match(LIMIT_);
			State = 1833;
			expr(0);
			State = 1836;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==COMMA || _la==OFFSET_) {
				{
				State = 1834;
				_la = TokenStream.LA(1);
				if ( !(_la==COMMA || _la==OFFSET_) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 1835;
				expr(0);
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

	public partial class Ordering_termContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLLATE_() { return GetToken(SQLiteParser.COLLATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Collation_nameContext collation_name() {
			return GetRuleContext<Collation_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Asc_descContext asc_desc() {
			return GetRuleContext<Asc_descContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NULLS_() { return GetToken(SQLiteParser.NULLS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FIRST_() { return GetToken(SQLiteParser.FIRST_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LAST_() { return GetToken(SQLiteParser.LAST_, 0); }
		public Ordering_termContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ordering_term; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterOrdering_term(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitOrdering_term(this);
		}
	}

	[RuleVersion(0)]
	public Ordering_termContext ordering_term() {
		Ordering_termContext _localctx = new Ordering_termContext(Context, State);
		EnterRule(_localctx, 136, RULE_ordering_term);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1838;
			expr(0);
			State = 1841;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==COLLATE_) {
				{
				State = 1839;
				Match(COLLATE_);
				State = 1840;
				collation_name();
				}
			}

			State = 1844;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==ASC_ || _la==DESC_) {
				{
				State = 1843;
				asc_desc();
				}
			}

			State = 1848;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==NULLS_) {
				{
				State = 1846;
				Match(NULLS_);
				State = 1847;
				_la = TokenStream.LA(1);
				if ( !(_la==FIRST_ || _la==LAST_) ) {
				ErrorHandler.RecoverInline(this);
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

	public partial class Asc_descContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASC_() { return GetToken(SQLiteParser.ASC_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DESC_() { return GetToken(SQLiteParser.DESC_, 0); }
		public Asc_descContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_asc_desc; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterAsc_desc(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitAsc_desc(this);
		}
	}

	[RuleVersion(0)]
	public Asc_descContext asc_desc() {
		Asc_descContext _localctx = new Asc_descContext(Context, State);
		EnterRule(_localctx, 138, RULE_asc_desc);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1850;
			_la = TokenStream.LA(1);
			if ( !(_la==ASC_ || _la==DESC_) ) {
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

	public partial class Frame_leftContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRECEDING_() { return GetToken(SQLiteParser.PRECEDING_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOLLOWING_() { return GetToken(SQLiteParser.FOLLOWING_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CURRENT_() { return GetToken(SQLiteParser.CURRENT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ROW_() { return GetToken(SQLiteParser.ROW_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNBOUNDED_() { return GetToken(SQLiteParser.UNBOUNDED_, 0); }
		public Frame_leftContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_frame_left; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterFrame_left(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitFrame_left(this);
		}
	}

	[RuleVersion(0)]
	public Frame_leftContext frame_left() {
		Frame_leftContext _localctx = new Frame_leftContext(Context, State);
		EnterRule(_localctx, 140, RULE_frame_left);
		try {
			State = 1862;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,276,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1852;
				expr(0);
				State = 1853;
				Match(PRECEDING_);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1855;
				expr(0);
				State = 1856;
				Match(FOLLOWING_);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1858;
				Match(CURRENT_);
				State = 1859;
				Match(ROW_);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1860;
				Match(UNBOUNDED_);
				State = 1861;
				Match(PRECEDING_);
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

	public partial class Frame_rightContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRECEDING_() { return GetToken(SQLiteParser.PRECEDING_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOLLOWING_() { return GetToken(SQLiteParser.FOLLOWING_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CURRENT_() { return GetToken(SQLiteParser.CURRENT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ROW_() { return GetToken(SQLiteParser.ROW_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNBOUNDED_() { return GetToken(SQLiteParser.UNBOUNDED_, 0); }
		public Frame_rightContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_frame_right; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterFrame_right(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitFrame_right(this);
		}
	}

	[RuleVersion(0)]
	public Frame_rightContext frame_right() {
		Frame_rightContext _localctx = new Frame_rightContext(Context, State);
		EnterRule(_localctx, 142, RULE_frame_right);
		try {
			State = 1874;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,277,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1864;
				expr(0);
				State = 1865;
				Match(PRECEDING_);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1867;
				expr(0);
				State = 1868;
				Match(FOLLOWING_);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1870;
				Match(CURRENT_);
				State = 1871;
				Match(ROW_);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1872;
				Match(UNBOUNDED_);
				State = 1873;
				Match(FOLLOWING_);
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

	public partial class Frame_singleContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRECEDING_() { return GetToken(SQLiteParser.PRECEDING_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNBOUNDED_() { return GetToken(SQLiteParser.UNBOUNDED_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CURRENT_() { return GetToken(SQLiteParser.CURRENT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ROW_() { return GetToken(SQLiteParser.ROW_, 0); }
		public Frame_singleContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_frame_single; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterFrame_single(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitFrame_single(this);
		}
	}

	[RuleVersion(0)]
	public Frame_singleContext frame_single() {
		Frame_singleContext _localctx = new Frame_singleContext(Context, State);
		EnterRule(_localctx, 144, RULE_frame_single);
		try {
			State = 1883;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,278,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1876;
				expr(0);
				State = 1877;
				Match(PRECEDING_);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1879;
				Match(UNBOUNDED_);
				State = 1880;
				Match(PRECEDING_);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1881;
				Match(CURRENT_);
				State = 1882;
				Match(ROW_);
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

	public partial class Window_functionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] OPEN_PAR() { return GetTokens(SQLiteParser.OPEN_PAR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR(int i) {
			return GetToken(SQLiteParser.OPEN_PAR, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] CLOSE_PAR() { return GetTokens(SQLiteParser.CLOSE_PAR); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR(int i) {
			return GetToken(SQLiteParser.CLOSE_PAR, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OVER_() { return GetToken(SQLiteParser.OVER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Order_by_expr_asc_descContext order_by_expr_asc_desc() {
			return GetRuleContext<Order_by_expr_asc_descContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FIRST_VALUE_() { return GetToken(SQLiteParser.FIRST_VALUE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LAST_VALUE_() { return GetToken(SQLiteParser.LAST_VALUE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Partition_byContext partition_by() {
			return GetRuleContext<Partition_byContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Frame_clauseContext frame_clause() {
			return GetRuleContext<Frame_clauseContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CUME_DIST_() { return GetToken(SQLiteParser.CUME_DIST_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PERCENT_RANK_() { return GetToken(SQLiteParser.PERCENT_RANK_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Order_by_exprContext order_by_expr() {
			return GetRuleContext<Order_by_exprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DENSE_RANK_() { return GetToken(SQLiteParser.DENSE_RANK_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RANK_() { return GetToken(SQLiteParser.RANK_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ROW_NUMBER_() { return GetToken(SQLiteParser.ROW_NUMBER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LAG_() { return GetToken(SQLiteParser.LAG_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LEAD_() { return GetToken(SQLiteParser.LEAD_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public OffsetContext offset() {
			return GetRuleContext<OffsetContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Default_valueContext default_value() {
			return GetRuleContext<Default_valueContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NTH_VALUE_() { return GetToken(SQLiteParser.NTH_VALUE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(SQLiteParser.COMMA, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Signed_numberContext signed_number() {
			return GetRuleContext<Signed_numberContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NTILE_() { return GetToken(SQLiteParser.NTILE_, 0); }
		public Window_functionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_window_function; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterWindow_function(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitWindow_function(this);
		}
	}

	[RuleVersion(0)]
	public Window_functionContext window_function() {
		Window_functionContext _localctx = new Window_functionContext(Context, State);
		EnterRule(_localctx, 146, RULE_window_function);
		int _la;
		try {
			State = 1970;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case FIRST_VALUE_:
			case LAST_VALUE_:
				EnterOuterAlt(_localctx, 1);
				{
				State = 1885;
				_la = TokenStream.LA(1);
				if ( !(_la==FIRST_VALUE_ || _la==LAST_VALUE_) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 1886;
				Match(OPEN_PAR);
				State = 1887;
				expr(0);
				State = 1888;
				Match(CLOSE_PAR);
				State = 1889;
				Match(OVER_);
				State = 1890;
				Match(OPEN_PAR);
				State = 1892;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==PARTITION_) {
					{
					State = 1891;
					partition_by();
					}
				}

				State = 1894;
				order_by_expr_asc_desc();
				State = 1896;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (ROWS_ - 128)) | (1L << (RANGE_ - 128)) | (1L << (GROUPS_ - 128)))) != 0)) {
					{
					State = 1895;
					frame_clause();
					}
				}

				State = 1898;
				Match(CLOSE_PAR);
				}
				break;
			case CUME_DIST_:
			case PERCENT_RANK_:
				EnterOuterAlt(_localctx, 2);
				{
				State = 1900;
				_la = TokenStream.LA(1);
				if ( !(_la==CUME_DIST_ || _la==PERCENT_RANK_) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 1901;
				Match(OPEN_PAR);
				State = 1902;
				Match(CLOSE_PAR);
				State = 1903;
				Match(OVER_);
				State = 1904;
				Match(OPEN_PAR);
				State = 1906;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==PARTITION_) {
					{
					State = 1905;
					partition_by();
					}
				}

				State = 1909;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==ORDER_) {
					{
					State = 1908;
					order_by_expr();
					}
				}

				State = 1911;
				Match(CLOSE_PAR);
				}
				break;
			case DENSE_RANK_:
			case RANK_:
			case ROW_NUMBER_:
				EnterOuterAlt(_localctx, 3);
				{
				State = 1912;
				_la = TokenStream.LA(1);
				if ( !(((((_la - 160)) & ~0x3f) == 0 && ((1L << (_la - 160)) & ((1L << (DENSE_RANK_ - 160)) | (1L << (RANK_ - 160)) | (1L << (ROW_NUMBER_ - 160)))) != 0)) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 1913;
				Match(OPEN_PAR);
				State = 1914;
				Match(CLOSE_PAR);
				State = 1915;
				Match(OVER_);
				State = 1916;
				Match(OPEN_PAR);
				State = 1918;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==PARTITION_) {
					{
					State = 1917;
					partition_by();
					}
				}

				State = 1920;
				order_by_expr_asc_desc();
				State = 1921;
				Match(CLOSE_PAR);
				}
				break;
			case LAG_:
			case LEAD_:
				EnterOuterAlt(_localctx, 4);
				{
				State = 1923;
				_la = TokenStream.LA(1);
				if ( !(_la==LAG_ || _la==LEAD_) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 1924;
				Match(OPEN_PAR);
				State = 1925;
				expr(0);
				State = 1927;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,284,Context) ) {
				case 1:
					{
					State = 1926;
					offset();
					}
					break;
				}
				State = 1930;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==COMMA) {
					{
					State = 1929;
					default_value();
					}
				}

				State = 1932;
				Match(CLOSE_PAR);
				State = 1933;
				Match(OVER_);
				State = 1934;
				Match(OPEN_PAR);
				State = 1936;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==PARTITION_) {
					{
					State = 1935;
					partition_by();
					}
				}

				State = 1938;
				order_by_expr_asc_desc();
				State = 1939;
				Match(CLOSE_PAR);
				}
				break;
			case NTH_VALUE_:
				EnterOuterAlt(_localctx, 5);
				{
				State = 1941;
				Match(NTH_VALUE_);
				State = 1942;
				Match(OPEN_PAR);
				State = 1943;
				expr(0);
				State = 1944;
				Match(COMMA);
				State = 1945;
				signed_number();
				State = 1946;
				Match(CLOSE_PAR);
				State = 1947;
				Match(OVER_);
				State = 1948;
				Match(OPEN_PAR);
				State = 1950;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==PARTITION_) {
					{
					State = 1949;
					partition_by();
					}
				}

				State = 1952;
				order_by_expr_asc_desc();
				State = 1954;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (ROWS_ - 128)) | (1L << (RANGE_ - 128)) | (1L << (GROUPS_ - 128)))) != 0)) {
					{
					State = 1953;
					frame_clause();
					}
				}

				State = 1956;
				Match(CLOSE_PAR);
				}
				break;
			case NTILE_:
				EnterOuterAlt(_localctx, 6);
				{
				State = 1958;
				Match(NTILE_);
				State = 1959;
				Match(OPEN_PAR);
				State = 1960;
				expr(0);
				State = 1961;
				Match(CLOSE_PAR);
				State = 1962;
				Match(OVER_);
				State = 1963;
				Match(OPEN_PAR);
				State = 1965;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==PARTITION_) {
					{
					State = 1964;
					partition_by();
					}
				}

				State = 1967;
				order_by_expr_asc_desc();
				State = 1968;
				Match(CLOSE_PAR);
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

	public partial class OffsetContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(SQLiteParser.COMMA, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Signed_numberContext signed_number() {
			return GetRuleContext<Signed_numberContext>(0);
		}
		public OffsetContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_offset; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterOffset(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitOffset(this);
		}
	}

	[RuleVersion(0)]
	public OffsetContext offset() {
		OffsetContext _localctx = new OffsetContext(Context, State);
		EnterRule(_localctx, 148, RULE_offset);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1972;
			Match(COMMA);
			State = 1973;
			signed_number();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Default_valueContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA() { return GetToken(SQLiteParser.COMMA, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Signed_numberContext signed_number() {
			return GetRuleContext<Signed_numberContext>(0);
		}
		public Default_valueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_default_value; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterDefault_value(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitDefault_value(this);
		}
	}

	[RuleVersion(0)]
	public Default_valueContext default_value() {
		Default_valueContext _localctx = new Default_valueContext(Context, State);
		EnterRule(_localctx, 150, RULE_default_value);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1975;
			Match(COMMA);
			State = 1976;
			signed_number();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Partition_byContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PARTITION_() { return GetToken(SQLiteParser.PARTITION_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BY_() { return GetToken(SQLiteParser.BY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public Partition_byContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_partition_by; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterPartition_by(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitPartition_by(this);
		}
	}

	[RuleVersion(0)]
	public Partition_byContext partition_by() {
		Partition_byContext _localctx = new Partition_byContext(Context, State);
		EnterRule(_localctx, 152, RULE_partition_by);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 1978;
			Match(PARTITION_);
			State = 1979;
			Match(BY_);
			State = 1981;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 1980;
					expr(0);
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 1983;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,291,Context);
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

	public partial class Order_by_exprContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ORDER_() { return GetToken(SQLiteParser.ORDER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BY_() { return GetToken(SQLiteParser.BY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public Order_by_exprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_order_by_expr; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterOrder_by_expr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitOrder_by_expr(this);
		}
	}

	[RuleVersion(0)]
	public Order_by_exprContext order_by_expr() {
		Order_by_exprContext _localctx = new Order_by_exprContext(Context, State);
		EnterRule(_localctx, 154, RULE_order_by_expr);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1985;
			Match(ORDER_);
			State = 1986;
			Match(BY_);
			State = 1988;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 1987;
				expr(0);
				}
				}
				State = 1990;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << OPEN_PAR) | (1L << PLUS) | (1L << MINUS) | (1L << TILDE) | (1L << ABORT_) | (1L << ACTION_) | (1L << ADD_) | (1L << AFTER_) | (1L << ALL_) | (1L << ALTER_) | (1L << ANALYZE_) | (1L << AND_) | (1L << AS_) | (1L << ASC_) | (1L << ATTACH_) | (1L << AUTOINCREMENT_) | (1L << BEFORE_) | (1L << BEGIN_) | (1L << BETWEEN_) | (1L << BY_) | (1L << CASCADE_) | (1L << CASE_) | (1L << CAST_) | (1L << CHECK_) | (1L << COLLATE_) | (1L << COLUMN_) | (1L << COMMIT_) | (1L << CONFLICT_) | (1L << CONSTRAINT_) | (1L << CREATE_) | (1L << CROSS_) | (1L << CURRENT_DATE_) | (1L << CURRENT_TIME_) | (1L << CURRENT_TIMESTAMP_) | (1L << DATABASE_) | (1L << DEFAULT_) | (1L << DEFERRABLE_) | (1L << DEFERRED_) | (1L << DELETE_) | (1L << DESC_) | (1L << DETACH_) | (1L << DISTINCT_) | (1L << DROP_))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (EACH_ - 64)) | (1L << (ELSE_ - 64)) | (1L << (END_ - 64)) | (1L << (ESCAPE_ - 64)) | (1L << (EXCEPT_ - 64)) | (1L << (EXCLUSIVE_ - 64)) | (1L << (EXISTS_ - 64)) | (1L << (EXPLAIN_ - 64)) | (1L << (FAIL_ - 64)) | (1L << (FOR_ - 64)) | (1L << (FOREIGN_ - 64)) | (1L << (FROM_ - 64)) | (1L << (FULL_ - 64)) | (1L << (GLOB_ - 64)) | (1L << (GROUP_ - 64)) | (1L << (HAVING_ - 64)) | (1L << (IF_ - 64)) | (1L << (IGNORE_ - 64)) | (1L << (IMMEDIATE_ - 64)) | (1L << (IN_ - 64)) | (1L << (INDEX_ - 64)) | (1L << (INDEXED_ - 64)) | (1L << (INITIALLY_ - 64)) | (1L << (INNER_ - 64)) | (1L << (INSERT_ - 64)) | (1L << (INSTEAD_ - 64)) | (1L << (INTERSECT_ - 64)) | (1L << (INTO_ - 64)) | (1L << (IS_ - 64)) | (1L << (ISNULL_ - 64)) | (1L << (JOIN_ - 64)) | (1L << (KEY_ - 64)) | (1L << (LEFT_ - 64)) | (1L << (LIKE_ - 64)) | (1L << (LIMIT_ - 64)) | (1L << (MATCH_ - 64)) | (1L << (NATURAL_ - 64)) | (1L << (NO_ - 64)) | (1L << (NOT_ - 64)) | (1L << (NOTNULL_ - 64)) | (1L << (NULL_ - 64)) | (1L << (OF_ - 64)) | (1L << (OFFSET_ - 64)) | (1L << (ON_ - 64)) | (1L << (OR_ - 64)) | (1L << (ORDER_ - 64)) | (1L << (OUTER_ - 64)) | (1L << (PLAN_ - 64)) | (1L << (PRAGMA_ - 64)) | (1L << (PRIMARY_ - 64)) | (1L << (QUERY_ - 64)) | (1L << (RAISE_ - 64)) | (1L << (RECURSIVE_ - 64)) | (1L << (REFERENCES_ - 64)) | (1L << (REGEXP_ - 64)) | (1L << (REINDEX_ - 64)) | (1L << (RELEASE_ - 64)) | (1L << (RENAME_ - 64)) | (1L << (REPLACE_ - 64)) | (1L << (RESTRICT_ - 64)) | (1L << (RIGHT_ - 64)) | (1L << (ROLLBACK_ - 64)) | (1L << (ROW_ - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (ROWS_ - 128)) | (1L << (SAVEPOINT_ - 128)) | (1L << (SELECT_ - 128)) | (1L << (SET_ - 128)) | (1L << (TABLE_ - 128)) | (1L << (TEMP_ - 128)) | (1L << (TEMPORARY_ - 128)) | (1L << (THEN_ - 128)) | (1L << (TO_ - 128)) | (1L << (TRANSACTION_ - 128)) | (1L << (TRIGGER_ - 128)) | (1L << (UNION_ - 128)) | (1L << (UNIQUE_ - 128)) | (1L << (UPDATE_ - 128)) | (1L << (USING_ - 128)) | (1L << (VACUUM_ - 128)) | (1L << (VALUES_ - 128)) | (1L << (VIEW_ - 128)) | (1L << (VIRTUAL_ - 128)) | (1L << (WHEN_ - 128)) | (1L << (WHERE_ - 128)) | (1L << (WITH_ - 128)) | (1L << (WITHOUT_ - 128)) | (1L << (FIRST_VALUE_ - 128)) | (1L << (OVER_ - 128)) | (1L << (PARTITION_ - 128)) | (1L << (RANGE_ - 128)) | (1L << (PRECEDING_ - 128)) | (1L << (UNBOUNDED_ - 128)) | (1L << (CURRENT_ - 128)) | (1L << (FOLLOWING_ - 128)) | (1L << (CUME_DIST_ - 128)) | (1L << (DENSE_RANK_ - 128)) | (1L << (LAG_ - 128)) | (1L << (LAST_VALUE_ - 128)) | (1L << (LEAD_ - 128)) | (1L << (NTH_VALUE_ - 128)) | (1L << (NTILE_ - 128)) | (1L << (PERCENT_RANK_ - 128)) | (1L << (RANK_ - 128)) | (1L << (ROW_NUMBER_ - 128)) | (1L << (GENERATED_ - 128)) | (1L << (ALWAYS_ - 128)) | (1L << (STORED_ - 128)) | (1L << (TRUE_ - 128)) | (1L << (FALSE_ - 128)) | (1L << (WINDOW_ - 128)) | (1L << (NULLS_ - 128)) | (1L << (FIRST_ - 128)) | (1L << (LAST_ - 128)) | (1L << (FILTER_ - 128)) | (1L << (GROUPS_ - 128)) | (1L << (EXCLUDE_ - 128)) | (1L << (IDENTIFIER - 128)) | (1L << (NUMERIC_LITERAL - 128)) | (1L << (BIND_PARAMETER - 128)) | (1L << (STRING_LITERAL - 128)) | (1L << (BLOB_LITERAL - 128)))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Order_by_expr_asc_descContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ORDER_() { return GetToken(SQLiteParser.ORDER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BY_() { return GetToken(SQLiteParser.BY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Expr_asc_descContext expr_asc_desc() {
			return GetRuleContext<Expr_asc_descContext>(0);
		}
		public Order_by_expr_asc_descContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_order_by_expr_asc_desc; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterOrder_by_expr_asc_desc(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitOrder_by_expr_asc_desc(this);
		}
	}

	[RuleVersion(0)]
	public Order_by_expr_asc_descContext order_by_expr_asc_desc() {
		Order_by_expr_asc_descContext _localctx = new Order_by_expr_asc_descContext(Context, State);
		EnterRule(_localctx, 156, RULE_order_by_expr_asc_desc);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1992;
			Match(ORDER_);
			State = 1993;
			Match(BY_);
			State = 1994;
			expr_asc_desc();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Expr_asc_descContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Asc_descContext[] asc_desc() {
			return GetRuleContexts<Asc_descContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Asc_descContext asc_desc(int i) {
			return GetRuleContext<Asc_descContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(SQLiteParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(SQLiteParser.COMMA, i);
		}
		public Expr_asc_descContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr_asc_desc; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterExpr_asc_desc(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitExpr_asc_desc(this);
		}
	}

	[RuleVersion(0)]
	public Expr_asc_descContext expr_asc_desc() {
		Expr_asc_descContext _localctx = new Expr_asc_descContext(Context, State);
		EnterRule(_localctx, 158, RULE_expr_asc_desc);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 1996;
			expr(0);
			State = 1998;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==ASC_ || _la==DESC_) {
				{
				State = 1997;
				asc_desc();
				}
			}

			State = 2007;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 2000;
				Match(COMMA);
				State = 2001;
				expr(0);
				State = 2003;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==ASC_ || _la==DESC_) {
					{
					State = 2002;
					asc_desc();
					}
				}

				}
				}
				State = 2009;
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

	public partial class Initial_selectContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Select_stmtContext select_stmt() {
			return GetRuleContext<Select_stmtContext>(0);
		}
		public Initial_selectContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_initial_select; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterInitial_select(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitInitial_select(this);
		}
	}

	[RuleVersion(0)]
	public Initial_selectContext initial_select() {
		Initial_selectContext _localctx = new Initial_selectContext(Context, State);
		EnterRule(_localctx, 160, RULE_initial_select);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2010;
			select_stmt();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Recursive_selectContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Select_stmtContext select_stmt() {
			return GetRuleContext<Select_stmtContext>(0);
		}
		public Recursive_selectContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_recursive_select; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterRecursive_select(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitRecursive_select(this);
		}
	}

	[RuleVersion(0)]
	public Recursive_selectContext recursive_select() {
		Recursive_selectContext _localctx = new Recursive_selectContext(Context, State);
		EnterRule(_localctx, 162, RULE_recursive_select);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2012;
			select_stmt();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Unary_operatorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MINUS() { return GetToken(SQLiteParser.MINUS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PLUS() { return GetToken(SQLiteParser.PLUS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TILDE() { return GetToken(SQLiteParser.TILDE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOT_() { return GetToken(SQLiteParser.NOT_, 0); }
		public Unary_operatorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unary_operator; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterUnary_operator(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitUnary_operator(this);
		}
	}

	[RuleVersion(0)]
	public Unary_operatorContext unary_operator() {
		Unary_operatorContext _localctx = new Unary_operatorContext(Context, State);
		EnterRule(_localctx, 164, RULE_unary_operator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2014;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PLUS) | (1L << MINUS) | (1L << TILDE))) != 0) || _la==NOT_) ) {
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

	public partial class Error_messageContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRING_LITERAL() { return GetToken(SQLiteParser.STRING_LITERAL, 0); }
		public Error_messageContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_error_message; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterError_message(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitError_message(this);
		}
	}

	[RuleVersion(0)]
	public Error_messageContext error_message() {
		Error_messageContext _localctx = new Error_messageContext(Context, State);
		EnterRule(_localctx, 166, RULE_error_message);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2016;
			Match(STRING_LITERAL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Module_argumentContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Column_defContext column_def() {
			return GetRuleContext<Column_defContext>(0);
		}
		public Module_argumentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_module_argument; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterModule_argument(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitModule_argument(this);
		}
	}

	[RuleVersion(0)]
	public Module_argumentContext module_argument() {
		Module_argumentContext _localctx = new Module_argumentContext(Context, State);
		EnterRule(_localctx, 168, RULE_module_argument);
		try {
			State = 2020;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,296,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2018;
				expr(0);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2019;
				column_def();
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

	public partial class Column_aliasContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(SQLiteParser.IDENTIFIER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRING_LITERAL() { return GetToken(SQLiteParser.STRING_LITERAL, 0); }
		public Column_aliasContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_column_alias; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterColumn_alias(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitColumn_alias(this);
		}
	}

	[RuleVersion(0)]
	public Column_aliasContext column_alias() {
		Column_aliasContext _localctx = new Column_aliasContext(Context, State);
		EnterRule(_localctx, 170, RULE_column_alias);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2022;
			_la = TokenStream.LA(1);
			if ( !(_la==IDENTIFIER || _la==STRING_LITERAL) ) {
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

	public partial class KeywordContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ABORT_() { return GetToken(SQLiteParser.ABORT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ACTION_() { return GetToken(SQLiteParser.ACTION_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ADD_() { return GetToken(SQLiteParser.ADD_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AFTER_() { return GetToken(SQLiteParser.AFTER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ALL_() { return GetToken(SQLiteParser.ALL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ALTER_() { return GetToken(SQLiteParser.ALTER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ANALYZE_() { return GetToken(SQLiteParser.ANALYZE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AND_() { return GetToken(SQLiteParser.AND_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AS_() { return GetToken(SQLiteParser.AS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ASC_() { return GetToken(SQLiteParser.ASC_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ATTACH_() { return GetToken(SQLiteParser.ATTACH_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AUTOINCREMENT_() { return GetToken(SQLiteParser.AUTOINCREMENT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BEFORE_() { return GetToken(SQLiteParser.BEFORE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BEGIN_() { return GetToken(SQLiteParser.BEGIN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BETWEEN_() { return GetToken(SQLiteParser.BETWEEN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BY_() { return GetToken(SQLiteParser.BY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CASCADE_() { return GetToken(SQLiteParser.CASCADE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CASE_() { return GetToken(SQLiteParser.CASE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CAST_() { return GetToken(SQLiteParser.CAST_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CHECK_() { return GetToken(SQLiteParser.CHECK_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLLATE_() { return GetToken(SQLiteParser.COLLATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLUMN_() { return GetToken(SQLiteParser.COLUMN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMIT_() { return GetToken(SQLiteParser.COMMIT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CONFLICT_() { return GetToken(SQLiteParser.CONFLICT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CONSTRAINT_() { return GetToken(SQLiteParser.CONSTRAINT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CREATE_() { return GetToken(SQLiteParser.CREATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CROSS_() { return GetToken(SQLiteParser.CROSS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CURRENT_DATE_() { return GetToken(SQLiteParser.CURRENT_DATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CURRENT_TIME_() { return GetToken(SQLiteParser.CURRENT_TIME_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CURRENT_TIMESTAMP_() { return GetToken(SQLiteParser.CURRENT_TIMESTAMP_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DATABASE_() { return GetToken(SQLiteParser.DATABASE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFAULT_() { return GetToken(SQLiteParser.DEFAULT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFERRABLE_() { return GetToken(SQLiteParser.DEFERRABLE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFERRED_() { return GetToken(SQLiteParser.DEFERRED_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DELETE_() { return GetToken(SQLiteParser.DELETE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DESC_() { return GetToken(SQLiteParser.DESC_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DETACH_() { return GetToken(SQLiteParser.DETACH_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DISTINCT_() { return GetToken(SQLiteParser.DISTINCT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DROP_() { return GetToken(SQLiteParser.DROP_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EACH_() { return GetToken(SQLiteParser.EACH_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ELSE_() { return GetToken(SQLiteParser.ELSE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode END_() { return GetToken(SQLiteParser.END_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ESCAPE_() { return GetToken(SQLiteParser.ESCAPE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXCEPT_() { return GetToken(SQLiteParser.EXCEPT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXCLUSIVE_() { return GetToken(SQLiteParser.EXCLUSIVE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXISTS_() { return GetToken(SQLiteParser.EXISTS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXPLAIN_() { return GetToken(SQLiteParser.EXPLAIN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FAIL_() { return GetToken(SQLiteParser.FAIL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOR_() { return GetToken(SQLiteParser.FOR_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOREIGN_() { return GetToken(SQLiteParser.FOREIGN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FROM_() { return GetToken(SQLiteParser.FROM_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FULL_() { return GetToken(SQLiteParser.FULL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GLOB_() { return GetToken(SQLiteParser.GLOB_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GROUP_() { return GetToken(SQLiteParser.GROUP_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode HAVING_() { return GetToken(SQLiteParser.HAVING_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IF_() { return GetToken(SQLiteParser.IF_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IGNORE_() { return GetToken(SQLiteParser.IGNORE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IMMEDIATE_() { return GetToken(SQLiteParser.IMMEDIATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IN_() { return GetToken(SQLiteParser.IN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INDEX_() { return GetToken(SQLiteParser.INDEX_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INDEXED_() { return GetToken(SQLiteParser.INDEXED_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INITIALLY_() { return GetToken(SQLiteParser.INITIALLY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INNER_() { return GetToken(SQLiteParser.INNER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INSERT_() { return GetToken(SQLiteParser.INSERT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INSTEAD_() { return GetToken(SQLiteParser.INSTEAD_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTERSECT_() { return GetToken(SQLiteParser.INTERSECT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTO_() { return GetToken(SQLiteParser.INTO_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IS_() { return GetToken(SQLiteParser.IS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ISNULL_() { return GetToken(SQLiteParser.ISNULL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode JOIN_() { return GetToken(SQLiteParser.JOIN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode KEY_() { return GetToken(SQLiteParser.KEY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LEFT_() { return GetToken(SQLiteParser.LEFT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LIKE_() { return GetToken(SQLiteParser.LIKE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LIMIT_() { return GetToken(SQLiteParser.LIMIT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MATCH_() { return GetToken(SQLiteParser.MATCH_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NATURAL_() { return GetToken(SQLiteParser.NATURAL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NO_() { return GetToken(SQLiteParser.NO_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOT_() { return GetToken(SQLiteParser.NOT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NOTNULL_() { return GetToken(SQLiteParser.NOTNULL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NULL_() { return GetToken(SQLiteParser.NULL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OF_() { return GetToken(SQLiteParser.OF_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OFFSET_() { return GetToken(SQLiteParser.OFFSET_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ON_() { return GetToken(SQLiteParser.ON_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OR_() { return GetToken(SQLiteParser.OR_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ORDER_() { return GetToken(SQLiteParser.ORDER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OUTER_() { return GetToken(SQLiteParser.OUTER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PLAN_() { return GetToken(SQLiteParser.PLAN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRAGMA_() { return GetToken(SQLiteParser.PRAGMA_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRIMARY_() { return GetToken(SQLiteParser.PRIMARY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode QUERY_() { return GetToken(SQLiteParser.QUERY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RAISE_() { return GetToken(SQLiteParser.RAISE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RECURSIVE_() { return GetToken(SQLiteParser.RECURSIVE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REFERENCES_() { return GetToken(SQLiteParser.REFERENCES_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REGEXP_() { return GetToken(SQLiteParser.REGEXP_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REINDEX_() { return GetToken(SQLiteParser.REINDEX_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RELEASE_() { return GetToken(SQLiteParser.RELEASE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RENAME_() { return GetToken(SQLiteParser.RENAME_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode REPLACE_() { return GetToken(SQLiteParser.REPLACE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RESTRICT_() { return GetToken(SQLiteParser.RESTRICT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RIGHT_() { return GetToken(SQLiteParser.RIGHT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ROLLBACK_() { return GetToken(SQLiteParser.ROLLBACK_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ROW_() { return GetToken(SQLiteParser.ROW_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ROWS_() { return GetToken(SQLiteParser.ROWS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SAVEPOINT_() { return GetToken(SQLiteParser.SAVEPOINT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SELECT_() { return GetToken(SQLiteParser.SELECT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SET_() { return GetToken(SQLiteParser.SET_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TABLE_() { return GetToken(SQLiteParser.TABLE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEMP_() { return GetToken(SQLiteParser.TEMP_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEMPORARY_() { return GetToken(SQLiteParser.TEMPORARY_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THEN_() { return GetToken(SQLiteParser.THEN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TO_() { return GetToken(SQLiteParser.TO_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRANSACTION_() { return GetToken(SQLiteParser.TRANSACTION_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRIGGER_() { return GetToken(SQLiteParser.TRIGGER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNION_() { return GetToken(SQLiteParser.UNION_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNIQUE_() { return GetToken(SQLiteParser.UNIQUE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UPDATE_() { return GetToken(SQLiteParser.UPDATE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode USING_() { return GetToken(SQLiteParser.USING_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VACUUM_() { return GetToken(SQLiteParser.VACUUM_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VALUES_() { return GetToken(SQLiteParser.VALUES_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VIEW_() { return GetToken(SQLiteParser.VIEW_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode VIRTUAL_() { return GetToken(SQLiteParser.VIRTUAL_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHEN_() { return GetToken(SQLiteParser.WHEN_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHERE_() { return GetToken(SQLiteParser.WHERE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WITH_() { return GetToken(SQLiteParser.WITH_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WITHOUT_() { return GetToken(SQLiteParser.WITHOUT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FIRST_VALUE_() { return GetToken(SQLiteParser.FIRST_VALUE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OVER_() { return GetToken(SQLiteParser.OVER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PARTITION_() { return GetToken(SQLiteParser.PARTITION_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RANGE_() { return GetToken(SQLiteParser.RANGE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PRECEDING_() { return GetToken(SQLiteParser.PRECEDING_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNBOUNDED_() { return GetToken(SQLiteParser.UNBOUNDED_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CURRENT_() { return GetToken(SQLiteParser.CURRENT_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FOLLOWING_() { return GetToken(SQLiteParser.FOLLOWING_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CUME_DIST_() { return GetToken(SQLiteParser.CUME_DIST_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DENSE_RANK_() { return GetToken(SQLiteParser.DENSE_RANK_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LAG_() { return GetToken(SQLiteParser.LAG_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LAST_VALUE_() { return GetToken(SQLiteParser.LAST_VALUE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LEAD_() { return GetToken(SQLiteParser.LEAD_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NTH_VALUE_() { return GetToken(SQLiteParser.NTH_VALUE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NTILE_() { return GetToken(SQLiteParser.NTILE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PERCENT_RANK_() { return GetToken(SQLiteParser.PERCENT_RANK_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RANK_() { return GetToken(SQLiteParser.RANK_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ROW_NUMBER_() { return GetToken(SQLiteParser.ROW_NUMBER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GENERATED_() { return GetToken(SQLiteParser.GENERATED_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ALWAYS_() { return GetToken(SQLiteParser.ALWAYS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STORED_() { return GetToken(SQLiteParser.STORED_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TRUE_() { return GetToken(SQLiteParser.TRUE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FALSE_() { return GetToken(SQLiteParser.FALSE_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WINDOW_() { return GetToken(SQLiteParser.WINDOW_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NULLS_() { return GetToken(SQLiteParser.NULLS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FIRST_() { return GetToken(SQLiteParser.FIRST_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LAST_() { return GetToken(SQLiteParser.LAST_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode FILTER_() { return GetToken(SQLiteParser.FILTER_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GROUPS_() { return GetToken(SQLiteParser.GROUPS_, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXCLUDE_() { return GetToken(SQLiteParser.EXCLUDE_, 0); }
		public KeywordContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_keyword; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterKeyword(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitKeyword(this);
		}
	}

	[RuleVersion(0)]
	public KeywordContext keyword() {
		KeywordContext _localctx = new KeywordContext(Context, State);
		EnterRule(_localctx, 172, RULE_keyword);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2024;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ABORT_) | (1L << ACTION_) | (1L << ADD_) | (1L << AFTER_) | (1L << ALL_) | (1L << ALTER_) | (1L << ANALYZE_) | (1L << AND_) | (1L << AS_) | (1L << ASC_) | (1L << ATTACH_) | (1L << AUTOINCREMENT_) | (1L << BEFORE_) | (1L << BEGIN_) | (1L << BETWEEN_) | (1L << BY_) | (1L << CASCADE_) | (1L << CASE_) | (1L << CAST_) | (1L << CHECK_) | (1L << COLLATE_) | (1L << COLUMN_) | (1L << COMMIT_) | (1L << CONFLICT_) | (1L << CONSTRAINT_) | (1L << CREATE_) | (1L << CROSS_) | (1L << CURRENT_DATE_) | (1L << CURRENT_TIME_) | (1L << CURRENT_TIMESTAMP_) | (1L << DATABASE_) | (1L << DEFAULT_) | (1L << DEFERRABLE_) | (1L << DEFERRED_) | (1L << DELETE_) | (1L << DESC_) | (1L << DETACH_) | (1L << DISTINCT_) | (1L << DROP_))) != 0) || ((((_la - 64)) & ~0x3f) == 0 && ((1L << (_la - 64)) & ((1L << (EACH_ - 64)) | (1L << (ELSE_ - 64)) | (1L << (END_ - 64)) | (1L << (ESCAPE_ - 64)) | (1L << (EXCEPT_ - 64)) | (1L << (EXCLUSIVE_ - 64)) | (1L << (EXISTS_ - 64)) | (1L << (EXPLAIN_ - 64)) | (1L << (FAIL_ - 64)) | (1L << (FOR_ - 64)) | (1L << (FOREIGN_ - 64)) | (1L << (FROM_ - 64)) | (1L << (FULL_ - 64)) | (1L << (GLOB_ - 64)) | (1L << (GROUP_ - 64)) | (1L << (HAVING_ - 64)) | (1L << (IF_ - 64)) | (1L << (IGNORE_ - 64)) | (1L << (IMMEDIATE_ - 64)) | (1L << (IN_ - 64)) | (1L << (INDEX_ - 64)) | (1L << (INDEXED_ - 64)) | (1L << (INITIALLY_ - 64)) | (1L << (INNER_ - 64)) | (1L << (INSERT_ - 64)) | (1L << (INSTEAD_ - 64)) | (1L << (INTERSECT_ - 64)) | (1L << (INTO_ - 64)) | (1L << (IS_ - 64)) | (1L << (ISNULL_ - 64)) | (1L << (JOIN_ - 64)) | (1L << (KEY_ - 64)) | (1L << (LEFT_ - 64)) | (1L << (LIKE_ - 64)) | (1L << (LIMIT_ - 64)) | (1L << (MATCH_ - 64)) | (1L << (NATURAL_ - 64)) | (1L << (NO_ - 64)) | (1L << (NOT_ - 64)) | (1L << (NOTNULL_ - 64)) | (1L << (NULL_ - 64)) | (1L << (OF_ - 64)) | (1L << (OFFSET_ - 64)) | (1L << (ON_ - 64)) | (1L << (OR_ - 64)) | (1L << (ORDER_ - 64)) | (1L << (OUTER_ - 64)) | (1L << (PLAN_ - 64)) | (1L << (PRAGMA_ - 64)) | (1L << (PRIMARY_ - 64)) | (1L << (QUERY_ - 64)) | (1L << (RAISE_ - 64)) | (1L << (RECURSIVE_ - 64)) | (1L << (REFERENCES_ - 64)) | (1L << (REGEXP_ - 64)) | (1L << (REINDEX_ - 64)) | (1L << (RELEASE_ - 64)) | (1L << (RENAME_ - 64)) | (1L << (REPLACE_ - 64)) | (1L << (RESTRICT_ - 64)) | (1L << (RIGHT_ - 64)) | (1L << (ROLLBACK_ - 64)) | (1L << (ROW_ - 64)))) != 0) || ((((_la - 128)) & ~0x3f) == 0 && ((1L << (_la - 128)) & ((1L << (ROWS_ - 128)) | (1L << (SAVEPOINT_ - 128)) | (1L << (SELECT_ - 128)) | (1L << (SET_ - 128)) | (1L << (TABLE_ - 128)) | (1L << (TEMP_ - 128)) | (1L << (TEMPORARY_ - 128)) | (1L << (THEN_ - 128)) | (1L << (TO_ - 128)) | (1L << (TRANSACTION_ - 128)) | (1L << (TRIGGER_ - 128)) | (1L << (UNION_ - 128)) | (1L << (UNIQUE_ - 128)) | (1L << (UPDATE_ - 128)) | (1L << (USING_ - 128)) | (1L << (VACUUM_ - 128)) | (1L << (VALUES_ - 128)) | (1L << (VIEW_ - 128)) | (1L << (VIRTUAL_ - 128)) | (1L << (WHEN_ - 128)) | (1L << (WHERE_ - 128)) | (1L << (WITH_ - 128)) | (1L << (WITHOUT_ - 128)) | (1L << (FIRST_VALUE_ - 128)) | (1L << (OVER_ - 128)) | (1L << (PARTITION_ - 128)) | (1L << (RANGE_ - 128)) | (1L << (PRECEDING_ - 128)) | (1L << (UNBOUNDED_ - 128)) | (1L << (CURRENT_ - 128)) | (1L << (FOLLOWING_ - 128)) | (1L << (CUME_DIST_ - 128)) | (1L << (DENSE_RANK_ - 128)) | (1L << (LAG_ - 128)) | (1L << (LAST_VALUE_ - 128)) | (1L << (LEAD_ - 128)) | (1L << (NTH_VALUE_ - 128)) | (1L << (NTILE_ - 128)) | (1L << (PERCENT_RANK_ - 128)) | (1L << (RANK_ - 128)) | (1L << (ROW_NUMBER_ - 128)) | (1L << (GENERATED_ - 128)) | (1L << (ALWAYS_ - 128)) | (1L << (STORED_ - 128)) | (1L << (TRUE_ - 128)) | (1L << (FALSE_ - 128)) | (1L << (WINDOW_ - 128)) | (1L << (NULLS_ - 128)) | (1L << (FIRST_ - 128)) | (1L << (LAST_ - 128)) | (1L << (FILTER_ - 128)) | (1L << (GROUPS_ - 128)) | (1L << (EXCLUDE_ - 128)))) != 0)) ) {
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

	public partial class NameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public NameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterName(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitName(this);
		}
	}

	[RuleVersion(0)]
	public NameContext name() {
		NameContext _localctx = new NameContext(Context, State);
		EnterRule(_localctx, 174, RULE_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2026;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Function_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Function_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_function_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterFunction_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitFunction_name(this);
		}
	}

	[RuleVersion(0)]
	public Function_nameContext function_name() {
		Function_nameContext _localctx = new Function_nameContext(Context, State);
		EnterRule(_localctx, 176, RULE_function_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2028;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Schema_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Schema_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_schema_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterSchema_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitSchema_name(this);
		}
	}

	[RuleVersion(0)]
	public Schema_nameContext schema_name() {
		Schema_nameContext _localctx = new Schema_nameContext(Context, State);
		EnterRule(_localctx, 178, RULE_schema_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2030;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Table_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Table_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_table_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterTable_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitTable_name(this);
		}
	}

	[RuleVersion(0)]
	public Table_nameContext table_name() {
		Table_nameContext _localctx = new Table_nameContext(Context, State);
		EnterRule(_localctx, 180, RULE_table_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2032;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Table_or_index_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Table_or_index_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_table_or_index_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterTable_or_index_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitTable_or_index_name(this);
		}
	}

	[RuleVersion(0)]
	public Table_or_index_nameContext table_or_index_name() {
		Table_or_index_nameContext _localctx = new Table_or_index_nameContext(Context, State);
		EnterRule(_localctx, 182, RULE_table_or_index_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2034;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Column_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Column_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_column_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterColumn_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitColumn_name(this);
		}
	}

	[RuleVersion(0)]
	public Column_nameContext column_name() {
		Column_nameContext _localctx = new Column_nameContext(Context, State);
		EnterRule(_localctx, 184, RULE_column_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2036;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Collation_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Collation_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_collation_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterCollation_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitCollation_name(this);
		}
	}

	[RuleVersion(0)]
	public Collation_nameContext collation_name() {
		Collation_nameContext _localctx = new Collation_nameContext(Context, State);
		EnterRule(_localctx, 186, RULE_collation_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2038;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Foreign_tableContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Foreign_tableContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_foreign_table; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterForeign_table(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitForeign_table(this);
		}
	}

	[RuleVersion(0)]
	public Foreign_tableContext foreign_table() {
		Foreign_tableContext _localctx = new Foreign_tableContext(Context, State);
		EnterRule(_localctx, 188, RULE_foreign_table);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2040;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Index_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Index_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_index_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterIndex_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitIndex_name(this);
		}
	}

	[RuleVersion(0)]
	public Index_nameContext index_name() {
		Index_nameContext _localctx = new Index_nameContext(Context, State);
		EnterRule(_localctx, 190, RULE_index_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2042;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Trigger_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Trigger_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_trigger_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterTrigger_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitTrigger_name(this);
		}
	}

	[RuleVersion(0)]
	public Trigger_nameContext trigger_name() {
		Trigger_nameContext _localctx = new Trigger_nameContext(Context, State);
		EnterRule(_localctx, 192, RULE_trigger_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2044;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class View_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public View_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_view_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterView_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitView_name(this);
		}
	}

	[RuleVersion(0)]
	public View_nameContext view_name() {
		View_nameContext _localctx = new View_nameContext(Context, State);
		EnterRule(_localctx, 194, RULE_view_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2046;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Module_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Module_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_module_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterModule_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitModule_name(this);
		}
	}

	[RuleVersion(0)]
	public Module_nameContext module_name() {
		Module_nameContext _localctx = new Module_nameContext(Context, State);
		EnterRule(_localctx, 196, RULE_module_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2048;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Pragma_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Pragma_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_pragma_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterPragma_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitPragma_name(this);
		}
	}

	[RuleVersion(0)]
	public Pragma_nameContext pragma_name() {
		Pragma_nameContext _localctx = new Pragma_nameContext(Context, State);
		EnterRule(_localctx, 198, RULE_pragma_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2050;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Savepoint_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Savepoint_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_savepoint_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterSavepoint_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitSavepoint_name(this);
		}
	}

	[RuleVersion(0)]
	public Savepoint_nameContext savepoint_name() {
		Savepoint_nameContext _localctx = new Savepoint_nameContext(Context, State);
		EnterRule(_localctx, 200, RULE_savepoint_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2052;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Table_aliasContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Table_aliasContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_table_alias; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterTable_alias(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitTable_alias(this);
		}
	}

	[RuleVersion(0)]
	public Table_aliasContext table_alias() {
		Table_aliasContext _localctx = new Table_aliasContext(Context, State);
		EnterRule(_localctx, 202, RULE_table_alias);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2054;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Transaction_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Transaction_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_transaction_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterTransaction_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitTransaction_name(this);
		}
	}

	[RuleVersion(0)]
	public Transaction_nameContext transaction_name() {
		Transaction_nameContext _localctx = new Transaction_nameContext(Context, State);
		EnterRule(_localctx, 204, RULE_transaction_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2056;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Window_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Window_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_window_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterWindow_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitWindow_name(this);
		}
	}

	[RuleVersion(0)]
	public Window_nameContext window_name() {
		Window_nameContext _localctx = new Window_nameContext(Context, State);
		EnterRule(_localctx, 206, RULE_window_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2058;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AliasContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public AliasContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_alias; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterAlias(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitAlias(this);
		}
	}

	[RuleVersion(0)]
	public AliasContext alias() {
		AliasContext _localctx = new AliasContext(Context, State);
		EnterRule(_localctx, 208, RULE_alias);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2060;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FilenameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public FilenameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_filename; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterFilename(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitFilename(this);
		}
	}

	[RuleVersion(0)]
	public FilenameContext filename() {
		FilenameContext _localctx = new FilenameContext(Context, State);
		EnterRule(_localctx, 210, RULE_filename);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2062;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Base_window_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Base_window_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_base_window_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterBase_window_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitBase_window_name(this);
		}
	}

	[RuleVersion(0)]
	public Base_window_nameContext base_window_name() {
		Base_window_nameContext _localctx = new Base_window_nameContext(Context, State);
		EnterRule(_localctx, 212, RULE_base_window_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2064;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Simple_funcContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Simple_funcContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_simple_func; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterSimple_func(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitSimple_func(this);
		}
	}

	[RuleVersion(0)]
	public Simple_funcContext simple_func() {
		Simple_funcContext _localctx = new Simple_funcContext(Context, State);
		EnterRule(_localctx, 214, RULE_simple_func);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2066;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Aggregate_funcContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Aggregate_funcContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_aggregate_func; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterAggregate_func(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitAggregate_func(this);
		}
	}

	[RuleVersion(0)]
	public Aggregate_funcContext aggregate_func() {
		Aggregate_funcContext _localctx = new Aggregate_funcContext(Context, State);
		EnterRule(_localctx, 216, RULE_aggregate_func);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2068;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Table_function_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		public Table_function_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_table_function_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterTable_function_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitTable_function_name(this);
		}
	}

	[RuleVersion(0)]
	public Table_function_nameContext table_function_name() {
		Table_function_nameContext _localctx = new Table_function_nameContext(Context, State);
		EnterRule(_localctx, 218, RULE_table_function_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 2070;
			any_name();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Any_nameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(SQLiteParser.IDENTIFIER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public KeywordContext keyword() {
			return GetRuleContext<KeywordContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRING_LITERAL() { return GetToken(SQLiteParser.STRING_LITERAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPEN_PAR() { return GetToken(SQLiteParser.OPEN_PAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Any_nameContext any_name() {
			return GetRuleContext<Any_nameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CLOSE_PAR() { return GetToken(SQLiteParser.CLOSE_PAR, 0); }
		public Any_nameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_any_name; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.EnterAny_name(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ISQLiteParserListener typedListener = listener as ISQLiteParserListener;
			if (typedListener != null) typedListener.ExitAny_name(this);
		}
	}

	[RuleVersion(0)]
	public Any_nameContext any_name() {
		Any_nameContext _localctx = new Any_nameContext(Context, State);
		EnterRule(_localctx, 220, RULE_any_name);
		try {
			State = 2079;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case IDENTIFIER:
				EnterOuterAlt(_localctx, 1);
				{
				State = 2072;
				Match(IDENTIFIER);
				}
				break;
			case ABORT_:
			case ACTION_:
			case ADD_:
			case AFTER_:
			case ALL_:
			case ALTER_:
			case ANALYZE_:
			case AND_:
			case AS_:
			case ASC_:
			case ATTACH_:
			case AUTOINCREMENT_:
			case BEFORE_:
			case BEGIN_:
			case BETWEEN_:
			case BY_:
			case CASCADE_:
			case CASE_:
			case CAST_:
			case CHECK_:
			case COLLATE_:
			case COLUMN_:
			case COMMIT_:
			case CONFLICT_:
			case CONSTRAINT_:
			case CREATE_:
			case CROSS_:
			case CURRENT_DATE_:
			case CURRENT_TIME_:
			case CURRENT_TIMESTAMP_:
			case DATABASE_:
			case DEFAULT_:
			case DEFERRABLE_:
			case DEFERRED_:
			case DELETE_:
			case DESC_:
			case DETACH_:
			case DISTINCT_:
			case DROP_:
			case EACH_:
			case ELSE_:
			case END_:
			case ESCAPE_:
			case EXCEPT_:
			case EXCLUSIVE_:
			case EXISTS_:
			case EXPLAIN_:
			case FAIL_:
			case FOR_:
			case FOREIGN_:
			case FROM_:
			case FULL_:
			case GLOB_:
			case GROUP_:
			case HAVING_:
			case IF_:
			case IGNORE_:
			case IMMEDIATE_:
			case IN_:
			case INDEX_:
			case INDEXED_:
			case INITIALLY_:
			case INNER_:
			case INSERT_:
			case INSTEAD_:
			case INTERSECT_:
			case INTO_:
			case IS_:
			case ISNULL_:
			case JOIN_:
			case KEY_:
			case LEFT_:
			case LIKE_:
			case LIMIT_:
			case MATCH_:
			case NATURAL_:
			case NO_:
			case NOT_:
			case NOTNULL_:
			case NULL_:
			case OF_:
			case OFFSET_:
			case ON_:
			case OR_:
			case ORDER_:
			case OUTER_:
			case PLAN_:
			case PRAGMA_:
			case PRIMARY_:
			case QUERY_:
			case RAISE_:
			case RECURSIVE_:
			case REFERENCES_:
			case REGEXP_:
			case REINDEX_:
			case RELEASE_:
			case RENAME_:
			case REPLACE_:
			case RESTRICT_:
			case RIGHT_:
			case ROLLBACK_:
			case ROW_:
			case ROWS_:
			case SAVEPOINT_:
			case SELECT_:
			case SET_:
			case TABLE_:
			case TEMP_:
			case TEMPORARY_:
			case THEN_:
			case TO_:
			case TRANSACTION_:
			case TRIGGER_:
			case UNION_:
			case UNIQUE_:
			case UPDATE_:
			case USING_:
			case VACUUM_:
			case VALUES_:
			case VIEW_:
			case VIRTUAL_:
			case WHEN_:
			case WHERE_:
			case WITH_:
			case WITHOUT_:
			case FIRST_VALUE_:
			case OVER_:
			case PARTITION_:
			case RANGE_:
			case PRECEDING_:
			case UNBOUNDED_:
			case CURRENT_:
			case FOLLOWING_:
			case CUME_DIST_:
			case DENSE_RANK_:
			case LAG_:
			case LAST_VALUE_:
			case LEAD_:
			case NTH_VALUE_:
			case NTILE_:
			case PERCENT_RANK_:
			case RANK_:
			case ROW_NUMBER_:
			case GENERATED_:
			case ALWAYS_:
			case STORED_:
			case TRUE_:
			case FALSE_:
			case WINDOW_:
			case NULLS_:
			case FIRST_:
			case LAST_:
			case FILTER_:
			case GROUPS_:
			case EXCLUDE_:
				EnterOuterAlt(_localctx, 2);
				{
				State = 2073;
				keyword();
				}
				break;
			case STRING_LITERAL:
				EnterOuterAlt(_localctx, 3);
				{
				State = 2074;
				Match(STRING_LITERAL);
				}
				break;
			case OPEN_PAR:
				EnterOuterAlt(_localctx, 4);
				{
				State = 2075;
				Match(OPEN_PAR);
				State = 2076;
				any_name();
				State = 2077;
				Match(CLOSE_PAR);
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

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 32: return expr_sempred((ExprContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expr_sempred(ExprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 20);
		case 1: return Precpred(Context, 19);
		case 2: return Precpred(Context, 18);
		case 3: return Precpred(Context, 17);
		case 4: return Precpred(Context, 16);
		case 5: return Precpred(Context, 15);
		case 6: return Precpred(Context, 14);
		case 7: return Precpred(Context, 13);
		case 8: return Precpred(Context, 6);
		case 9: return Precpred(Context, 5);
		case 10: return Precpred(Context, 9);
		case 11: return Precpred(Context, 8);
		case 12: return Precpred(Context, 7);
		case 13: return Precpred(Context, 4);
		}
		return true;
	}

	private static int[] _serializedATN = {
		4,1,193,2082,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,
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
		1,0,5,0,224,8,0,10,0,12,0,227,9,0,1,0,1,0,1,1,5,1,232,8,1,10,1,12,1,235,
		9,1,1,1,1,1,4,1,239,8,1,11,1,12,1,240,1,1,5,1,244,8,1,10,1,12,1,247,9,
		1,1,1,5,1,250,8,1,10,1,12,1,253,9,1,1,2,1,2,1,2,3,2,258,8,2,3,2,260,8,
		2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,
		1,2,1,2,1,2,1,2,1,2,1,2,1,2,3,2,286,8,2,1,3,1,3,1,3,1,3,1,3,3,3,293,8,
		3,1,3,1,3,1,3,1,3,1,3,3,3,300,8,3,1,3,1,3,1,3,1,3,3,3,306,8,3,1,3,1,3,
		3,3,310,8,3,1,3,1,3,1,3,3,3,315,8,3,1,3,3,3,318,8,3,1,4,1,4,1,4,1,4,1,
		4,3,4,325,8,4,1,4,3,4,328,8,4,1,5,1,5,3,5,332,8,5,1,5,1,5,1,5,1,5,1,6,
		1,6,3,6,340,8,6,1,6,1,6,3,6,344,8,6,3,6,346,8,6,1,7,1,7,3,7,350,8,7,1,
		8,1,8,3,8,354,8,8,1,8,1,8,3,8,358,8,8,1,8,3,8,361,8,8,1,9,1,9,1,9,1,10,
		1,10,3,10,368,8,10,1,10,1,10,1,11,1,11,3,11,374,8,11,1,11,1,11,1,11,1,
		11,3,11,380,8,11,1,11,1,11,1,11,3,11,385,8,11,1,11,1,11,1,11,1,11,1,11,
		1,11,1,11,5,11,394,8,11,10,11,12,11,397,9,11,1,11,1,11,1,11,3,11,402,8,
		11,1,12,1,12,3,12,406,8,12,1,12,1,12,3,12,410,8,12,1,12,3,12,413,8,12,
		1,13,1,13,3,13,417,8,13,1,13,1,13,1,13,1,13,3,13,423,8,13,1,13,1,13,1,
		13,3,13,428,8,13,1,13,1,13,1,13,1,13,1,13,5,13,435,8,13,10,13,12,13,438,
		9,13,1,13,1,13,5,13,442,8,13,10,13,12,13,445,9,13,1,13,1,13,1,13,3,13,
		450,8,13,1,13,1,13,3,13,454,8,13,1,14,1,14,3,14,458,8,14,1,14,5,14,461,
		8,14,10,14,12,14,464,9,14,1,15,4,15,467,8,15,11,15,12,15,468,1,15,1,15,
		1,15,1,15,1,15,1,15,1,15,1,15,1,15,1,15,3,15,481,8,15,1,16,1,16,3,16,485,
		8,16,1,16,1,16,1,16,3,16,490,8,16,1,16,3,16,493,8,16,1,16,3,16,496,8,16,
		1,16,1,16,1,16,3,16,501,8,16,1,16,3,16,504,8,16,1,16,1,16,1,16,1,16,1,
		16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,3,16,518,8,16,1,16,1,16,1,16,1,16,
		1,16,3,16,525,8,16,1,16,1,16,1,16,1,16,1,16,3,16,532,8,16,3,16,534,8,16,
		1,17,3,17,537,8,17,1,17,1,17,1,18,1,18,3,18,543,8,18,1,18,1,18,1,18,3,
		18,548,8,18,1,18,1,18,1,18,1,18,5,18,554,8,18,10,18,12,18,557,9,18,1,18,
		1,18,3,18,561,8,18,1,18,1,18,1,18,1,18,1,18,1,18,1,18,1,18,1,18,1,18,1,
		18,5,18,574,8,18,10,18,12,18,577,9,18,1,18,1,18,1,18,3,18,582,8,18,1,19,
		1,19,1,19,1,19,1,19,1,19,5,19,590,8,19,10,19,12,19,593,9,19,1,19,1,19,
		3,19,597,8,19,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,19,3,19,607,8,19,1,
		19,1,19,5,19,611,8,19,10,19,12,19,614,9,19,1,19,3,19,617,8,19,1,19,1,19,
		1,19,3,19,622,8,19,3,19,624,8,19,1,20,1,20,1,20,1,20,1,21,1,21,3,21,632,
		8,21,1,21,1,21,1,21,1,21,3,21,638,8,21,1,21,1,21,1,21,3,21,643,8,21,1,
		21,1,21,1,21,1,21,1,21,3,21,650,8,21,1,21,1,21,1,21,1,21,1,21,1,21,1,21,
		5,21,659,8,21,10,21,12,21,662,9,21,3,21,664,8,21,3,21,666,8,21,1,21,1,
		21,1,21,1,21,1,21,3,21,673,8,21,1,21,1,21,3,21,677,8,21,1,21,1,21,1,21,
		1,21,1,21,3,21,684,8,21,1,21,1,21,4,21,688,8,21,11,21,12,21,689,1,21,1,
		21,1,22,1,22,3,22,696,8,22,1,22,1,22,1,22,1,22,3,22,702,8,22,1,22,1,22,
		1,22,3,22,707,8,22,1,22,1,22,1,22,1,22,1,22,5,22,714,8,22,10,22,12,22,
		717,9,22,1,22,1,22,3,22,721,8,22,1,22,1,22,1,22,1,23,1,23,1,23,1,23,1,
		23,1,23,3,23,732,8,23,1,23,1,23,1,23,3,23,737,8,23,1,23,1,23,1,23,1,23,
		1,23,1,23,1,23,5,23,746,8,23,10,23,12,23,749,9,23,1,23,1,23,3,23,753,8,
		23,1,24,1,24,3,24,757,8,24,1,24,1,24,1,24,1,24,1,24,1,24,1,24,1,24,1,24,
		1,24,1,24,1,24,5,24,771,8,24,10,24,12,24,774,9,24,1,25,1,25,1,25,1,25,
		1,25,5,25,781,8,25,10,25,12,25,784,9,25,1,25,1,25,3,25,788,8,25,1,26,1,
		26,1,26,1,26,1,26,1,26,3,26,796,8,26,1,26,1,26,1,26,1,27,1,27,1,27,1,27,
		1,27,5,27,806,8,27,10,27,12,27,809,9,27,1,27,1,27,3,27,813,8,27,1,27,1,
		27,1,27,1,27,1,27,1,28,3,28,821,8,28,1,28,1,28,1,28,1,28,1,28,3,28,828,
		8,28,1,28,3,28,831,8,28,1,29,3,29,834,8,29,1,29,1,29,1,29,1,29,1,29,3,
		29,841,8,29,1,29,3,29,844,8,29,1,29,3,29,847,8,29,1,29,3,29,850,8,29,1,
		30,1,30,3,30,854,8,30,1,30,1,30,1,31,1,31,1,31,1,31,3,31,862,8,31,1,31,
		1,31,1,31,3,31,867,8,31,1,31,1,31,1,32,1,32,1,32,1,32,1,32,1,32,3,32,877,
		8,32,1,32,1,32,1,32,3,32,882,8,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,3,
		32,891,8,32,1,32,1,32,1,32,5,32,896,8,32,10,32,12,32,899,9,32,1,32,3,32,
		902,8,32,1,32,1,32,3,32,906,8,32,1,32,3,32,909,8,32,1,32,1,32,1,32,1,32,
		5,32,915,8,32,10,32,12,32,918,9,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,
		1,32,1,32,1,32,3,32,930,8,32,1,32,3,32,933,8,32,1,32,1,32,1,32,1,32,1,
		32,1,32,3,32,941,8,32,1,32,1,32,1,32,1,32,1,32,4,32,948,8,32,11,32,12,
		32,949,1,32,1,32,3,32,954,8,32,1,32,1,32,1,32,3,32,959,8,32,1,32,1,32,
		1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,
		1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,3,32,989,8,
		32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,3,32,1001,8,32,1,
		32,1,32,1,32,3,32,1006,8,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,32,1,
		32,1,32,3,32,1018,8,32,1,32,1,32,1,32,1,32,3,32,1024,8,32,1,32,1,32,1,
		32,1,32,1,32,3,32,1031,8,32,1,32,1,32,3,32,1035,8,32,1,32,1,32,1,32,1,
		32,1,32,1,32,5,32,1043,8,32,10,32,12,32,1046,9,32,3,32,1048,8,32,1,32,
		1,32,1,32,1,32,3,32,1054,8,32,1,32,1,32,1,32,1,32,3,32,1060,8,32,1,32,
		1,32,1,32,1,32,1,32,5,32,1067,8,32,10,32,12,32,1070,9,32,3,32,1072,8,32,
		1,32,1,32,3,32,1076,8,32,5,32,1078,8,32,10,32,12,32,1081,9,32,1,33,1,33,
		1,33,1,33,1,33,1,33,3,33,1089,8,33,1,33,1,33,1,34,1,34,1,35,3,35,1096,
		8,35,1,35,1,35,1,35,1,35,1,35,3,35,1103,8,35,1,35,1,35,1,35,1,35,3,35,
		1109,8,35,1,35,1,35,1,35,3,35,1114,8,35,1,35,1,35,1,35,1,35,5,35,1120,
		8,35,10,35,12,35,1123,9,35,1,35,1,35,3,35,1127,8,35,1,35,1,35,1,35,1,35,
		1,35,5,35,1134,8,35,10,35,12,35,1137,9,35,1,35,1,35,1,35,1,35,1,35,1,35,
		5,35,1145,8,35,10,35,12,35,1148,9,35,1,35,1,35,5,35,1152,8,35,10,35,12,
		35,1155,9,35,1,35,3,35,1158,8,35,1,35,3,35,1161,8,35,1,35,1,35,3,35,1165,
		8,35,1,35,3,35,1168,8,35,1,36,1,36,1,36,1,36,5,36,1174,8,36,10,36,12,36,
		1177,9,36,1,37,1,37,1,37,1,37,1,37,1,37,5,37,1185,8,37,10,37,12,37,1188,
		9,37,1,37,1,37,1,37,3,37,1193,8,37,3,37,1195,8,37,1,37,1,37,1,37,1,37,
		1,37,1,37,3,37,1203,8,37,1,37,1,37,1,37,1,37,1,37,3,37,1210,8,37,1,37,
		1,37,1,37,5,37,1215,8,37,10,37,12,37,1218,9,37,1,37,1,37,3,37,1222,8,37,
		3,37,1224,8,37,1,38,1,38,1,38,1,38,3,38,1230,8,38,1,38,1,38,1,38,1,38,
		1,38,1,38,1,38,3,38,1239,8,38,1,39,1,39,1,39,3,39,1244,8,39,1,40,1,40,
		1,40,1,40,1,40,3,40,1251,8,40,1,40,1,40,3,40,1255,8,40,3,40,1257,8,40,
		1,41,3,41,1260,8,41,1,41,1,41,1,41,1,41,5,41,1266,8,41,10,41,12,41,1269,
		9,41,1,41,3,41,1272,8,41,1,41,3,41,1275,8,41,1,42,1,42,1,42,1,42,3,42,
		1281,8,42,5,42,1283,8,42,10,42,12,42,1286,9,42,1,43,1,43,3,43,1290,8,43,
		1,43,1,43,1,43,5,43,1295,8,43,10,43,12,43,1298,9,43,1,43,1,43,1,43,1,43,
		5,43,1304,8,43,10,43,12,43,1307,9,43,1,43,3,43,1310,8,43,3,43,1312,8,43,
		1,43,1,43,3,43,1316,8,43,1,43,1,43,1,43,1,43,1,43,5,43,1323,8,43,10,43,
		12,43,1326,9,43,1,43,1,43,3,43,1330,8,43,3,43,1332,8,43,1,43,1,43,1,43,
		1,43,1,43,1,43,1,43,1,43,1,43,5,43,1343,8,43,10,43,12,43,1346,9,43,3,43,
		1348,8,43,1,43,1,43,1,43,1,43,1,43,5,43,1355,8,43,10,43,12,43,1358,9,43,
		1,43,1,43,1,43,1,43,1,43,1,43,5,43,1366,8,43,10,43,12,43,1369,9,43,1,43,
		1,43,5,43,1373,8,43,10,43,12,43,1376,9,43,3,43,1378,8,43,1,44,1,44,1,45,
		3,45,1383,8,45,1,45,1,45,3,45,1387,8,45,1,45,3,45,1390,8,45,1,46,3,46,
		1393,8,46,1,46,1,46,1,46,3,46,1398,8,46,1,46,1,46,3,46,1402,8,46,1,46,
		4,46,1405,8,46,11,46,12,46,1406,1,46,3,46,1410,8,46,1,46,3,46,1413,8,46,
		1,47,1,47,1,47,3,47,1418,8,47,1,47,1,47,3,47,1422,8,47,1,47,3,47,1425,
		8,47,1,47,1,47,1,47,1,47,1,47,3,47,1432,8,47,1,47,1,47,1,47,3,47,1437,
		8,47,1,47,1,47,1,47,1,47,1,47,5,47,1444,8,47,10,47,12,47,1447,9,47,1,47,
		1,47,3,47,1451,8,47,1,47,3,47,1454,8,47,1,47,1,47,1,47,1,47,5,47,1460,
		8,47,10,47,12,47,1463,9,47,1,47,3,47,1466,8,47,1,47,1,47,1,47,1,47,1,47,
		1,47,3,47,1474,8,47,1,47,3,47,1477,8,47,3,47,1479,8,47,1,48,1,48,1,48,
		1,48,1,48,1,48,1,48,3,48,1488,8,48,1,48,3,48,1491,8,48,3,48,1493,8,48,
		1,49,1,49,3,49,1497,8,49,1,49,1,49,3,49,1501,8,49,1,49,1,49,3,49,1505,
		8,49,1,49,3,49,1508,8,49,1,50,1,50,1,50,1,50,1,50,1,50,1,50,5,50,1517,
		8,50,10,50,12,50,1520,9,50,1,50,1,50,3,50,1524,8,50,1,51,1,51,3,51,1528,
		8,51,1,51,1,51,3,51,1532,8,51,1,52,3,52,1535,8,52,1,52,1,52,1,52,3,52,
		1540,8,52,1,52,1,52,1,52,1,52,3,52,1546,8,52,1,52,1,52,1,52,1,52,1,52,
		3,52,1553,8,52,1,52,1,52,1,52,5,52,1558,8,52,10,52,12,52,1561,9,52,1,52,
		1,52,1,52,1,52,5,52,1567,8,52,10,52,12,52,1570,9,52,1,52,3,52,1573,8,52,
		3,52,1575,8,52,1,52,1,52,3,52,1579,8,52,1,52,3,52,1582,8,52,1,53,1,53,
		1,53,1,53,5,53,1588,8,53,10,53,12,53,1591,9,53,1,53,1,53,1,54,3,54,1596,
		8,54,1,54,1,54,1,54,3,54,1601,8,54,1,54,1,54,1,54,1,54,3,54,1607,8,54,
		1,54,1,54,1,54,1,54,1,54,3,54,1614,8,54,1,54,1,54,1,54,5,54,1619,8,54,
		10,54,12,54,1622,9,54,1,54,1,54,3,54,1626,8,54,1,54,3,54,1629,8,54,1,54,
		3,54,1632,8,54,1,54,3,54,1635,8,54,1,55,1,55,1,55,3,55,1640,8,55,1,55,
		1,55,1,55,3,55,1645,8,55,1,55,1,55,1,55,1,55,1,55,3,55,1652,8,55,1,56,
		1,56,3,56,1656,8,56,1,56,1,56,3,56,1660,8,56,1,57,1,57,1,57,1,57,1,57,
		1,57,1,58,1,58,3,58,1670,8,58,1,58,1,58,1,58,1,58,1,58,5,58,1677,8,58,
		10,58,12,58,1680,9,58,3,58,1682,8,58,1,58,1,58,1,58,1,58,1,58,5,58,1689,
		8,58,10,58,12,58,1692,9,58,1,58,3,58,1695,8,58,1,58,1,58,1,59,1,59,1,59,
		1,59,3,59,1703,8,59,1,59,1,59,1,59,1,59,1,59,5,59,1710,8,59,10,59,12,59,
		1713,9,59,3,59,1715,8,59,1,59,1,59,1,59,1,59,1,59,5,59,1722,8,59,10,59,
		12,59,1725,9,59,3,59,1727,8,59,1,59,3,59,1730,8,59,1,59,3,59,1733,8,59,
		1,60,1,60,1,60,1,60,1,60,1,60,1,60,1,60,3,60,1743,8,60,1,61,1,61,1,61,
		1,61,1,61,1,61,1,61,3,61,1752,8,61,1,62,1,62,1,62,1,62,1,62,5,62,1759,
		8,62,10,62,12,62,1762,9,62,1,62,3,62,1765,8,62,1,62,1,62,1,63,1,63,1,63,
		3,63,1772,8,63,1,63,1,63,1,63,5,63,1777,8,63,10,63,12,63,1780,9,63,1,63,
		3,63,1783,8,63,1,63,1,63,3,63,1787,8,63,1,64,1,64,1,64,1,64,1,64,5,64,
		1794,8,64,10,64,12,64,1797,9,64,1,64,3,64,1800,8,64,1,64,1,64,3,64,1804,
		8,64,1,64,1,64,1,64,3,64,1809,8,64,1,65,1,65,3,65,1813,8,65,1,65,1,65,
		1,65,5,65,1818,8,65,10,65,12,65,1821,9,65,1,66,1,66,1,66,1,66,1,66,5,66,
		1828,8,66,10,66,12,66,1831,9,66,1,67,1,67,1,67,1,67,3,67,1837,8,67,1,68,
		1,68,1,68,3,68,1842,8,68,1,68,3,68,1845,8,68,1,68,1,68,3,68,1849,8,68,
		1,69,1,69,1,70,1,70,1,70,1,70,1,70,1,70,1,70,1,70,1,70,1,70,3,70,1863,
		8,70,1,71,1,71,1,71,1,71,1,71,1,71,1,71,1,71,1,71,1,71,3,71,1875,8,71,
		1,72,1,72,1,72,1,72,1,72,1,72,1,72,3,72,1884,8,72,1,73,1,73,1,73,1,73,
		1,73,1,73,1,73,3,73,1893,8,73,1,73,1,73,3,73,1897,8,73,1,73,1,73,1,73,
		1,73,1,73,1,73,1,73,1,73,3,73,1907,8,73,1,73,3,73,1910,8,73,1,73,1,73,
		1,73,1,73,1,73,1,73,1,73,3,73,1919,8,73,1,73,1,73,1,73,1,73,1,73,1,73,
		1,73,3,73,1928,8,73,1,73,3,73,1931,8,73,1,73,1,73,1,73,1,73,3,73,1937,
		8,73,1,73,1,73,1,73,1,73,1,73,1,73,1,73,1,73,1,73,1,73,1,73,1,73,3,73,
		1951,8,73,1,73,1,73,3,73,1955,8,73,1,73,1,73,1,73,1,73,1,73,1,73,1,73,
		1,73,1,73,3,73,1966,8,73,1,73,1,73,1,73,3,73,1971,8,73,1,74,1,74,1,74,
		1,75,1,75,1,75,1,76,1,76,1,76,4,76,1982,8,76,11,76,12,76,1983,1,77,1,77,
		1,77,4,77,1989,8,77,11,77,12,77,1990,1,78,1,78,1,78,1,78,1,79,1,79,3,79,
		1999,8,79,1,79,1,79,1,79,3,79,2004,8,79,5,79,2006,8,79,10,79,12,79,2009,
		9,79,1,80,1,80,1,81,1,81,1,82,1,82,1,83,1,83,1,84,1,84,3,84,2021,8,84,
		1,85,1,85,1,86,1,86,1,87,1,87,1,88,1,88,1,89,1,89,1,90,1,90,1,91,1,91,
		1,92,1,92,1,93,1,93,1,94,1,94,1,95,1,95,1,96,1,96,1,97,1,97,1,98,1,98,
		1,99,1,99,1,100,1,100,1,101,1,101,1,102,1,102,1,103,1,103,1,104,1,104,
		1,105,1,105,1,106,1,106,1,107,1,107,1,108,1,108,1,109,1,109,1,110,1,110,
		1,110,1,110,1,110,1,110,1,110,3,110,2080,8,110,1,110,2,436,468,1,64,111,
		0,2,4,6,8,10,12,14,16,18,20,22,24,26,28,30,32,34,36,38,40,42,44,46,48,
		50,52,54,56,58,60,62,64,66,68,70,72,74,76,78,80,82,84,86,88,90,92,94,96,
		98,100,102,104,106,108,110,112,114,116,118,120,122,124,126,128,130,132,
		134,136,138,140,142,144,146,148,150,152,154,156,158,160,162,164,166,168,
		170,172,174,176,178,180,182,184,186,188,190,192,194,196,198,200,202,204,
		206,208,210,212,214,216,218,220,0,28,3,0,58,58,69,69,82,82,2,0,47,47,66,
		66,1,0,133,134,2,0,146,146,171,171,1,0,8,9,2,0,59,59,141,141,2,0,56,56,
		104,104,2,0,58,58,82,82,5,0,25,25,72,72,81,81,122,122,126,126,4,0,84,84,
		132,132,138,138,145,145,2,0,7,7,12,13,1,0,14,17,1,0,18,21,4,0,77,77,97,
		97,99,99,118,118,3,0,25,25,72,72,126,126,5,0,52,54,104,104,172,173,186,
		186,188,189,2,0,29,29,62,62,3,0,128,128,154,154,179,179,2,0,5,5,106,106,
		1,0,176,177,2,0,34,34,60,60,2,0,151,151,162,162,2,0,159,159,166,166,2,
		0,160,160,167,168,2,0,161,161,163,163,2,0,8,10,102,102,2,0,185,185,188,
		188,2,0,25,123,125,180,2369,0,225,1,0,0,0,2,233,1,0,0,0,4,259,1,0,0,0,
		6,287,1,0,0,0,8,319,1,0,0,0,10,329,1,0,0,0,12,337,1,0,0,0,14,347,1,0,0,
		0,16,351,1,0,0,0,18,362,1,0,0,0,20,365,1,0,0,0,22,371,1,0,0,0,24,405,1,
		0,0,0,26,414,1,0,0,0,28,455,1,0,0,0,30,466,1,0,0,0,32,484,1,0,0,0,34,536,
		1,0,0,0,36,542,1,0,0,0,38,583,1,0,0,0,40,625,1,0,0,0,42,629,1,0,0,0,44,
		693,1,0,0,0,46,725,1,0,0,0,48,754,1,0,0,0,50,775,1,0,0,0,52,789,1,0,0,
		0,54,800,1,0,0,0,56,820,1,0,0,0,58,833,1,0,0,0,60,851,1,0,0,0,62,857,1,
		0,0,0,64,958,1,0,0,0,66,1082,1,0,0,0,68,1092,1,0,0,0,70,1095,1,0,0,0,72,
		1169,1,0,0,0,74,1178,1,0,0,0,76,1225,1,0,0,0,78,1243,1,0,0,0,80,1245,1,
		0,0,0,82,1259,1,0,0,0,84,1276,1,0,0,0,86,1377,1,0,0,0,88,1379,1,0,0,0,
		90,1382,1,0,0,0,92,1392,1,0,0,0,94,1478,1,0,0,0,96,1492,1,0,0,0,98,1507,
		1,0,0,0,100,1523,1,0,0,0,102,1531,1,0,0,0,104,1534,1,0,0,0,106,1583,1,
		0,0,0,108,1595,1,0,0,0,110,1639,1,0,0,0,112,1653,1,0,0,0,114,1661,1,0,
		0,0,116,1667,1,0,0,0,118,1698,1,0,0,0,120,1734,1,0,0,0,122,1744,1,0,0,
		0,124,1753,1,0,0,0,126,1768,1,0,0,0,128,1788,1,0,0,0,130,1810,1,0,0,0,
		132,1822,1,0,0,0,134,1832,1,0,0,0,136,1838,1,0,0,0,138,1850,1,0,0,0,140,
		1862,1,0,0,0,142,1874,1,0,0,0,144,1883,1,0,0,0,146,1970,1,0,0,0,148,1972,
		1,0,0,0,150,1975,1,0,0,0,152,1978,1,0,0,0,154,1985,1,0,0,0,156,1992,1,
		0,0,0,158,1996,1,0,0,0,160,2010,1,0,0,0,162,2012,1,0,0,0,164,2014,1,0,
		0,0,166,2016,1,0,0,0,168,2020,1,0,0,0,170,2022,1,0,0,0,172,2024,1,0,0,
		0,174,2026,1,0,0,0,176,2028,1,0,0,0,178,2030,1,0,0,0,180,2032,1,0,0,0,
		182,2034,1,0,0,0,184,2036,1,0,0,0,186,2038,1,0,0,0,188,2040,1,0,0,0,190,
		2042,1,0,0,0,192,2044,1,0,0,0,194,2046,1,0,0,0,196,2048,1,0,0,0,198,2050,
		1,0,0,0,200,2052,1,0,0,0,202,2054,1,0,0,0,204,2056,1,0,0,0,206,2058,1,
		0,0,0,208,2060,1,0,0,0,210,2062,1,0,0,0,212,2064,1,0,0,0,214,2066,1,0,
		0,0,216,2068,1,0,0,0,218,2070,1,0,0,0,220,2079,1,0,0,0,222,224,3,2,1,0,
		223,222,1,0,0,0,224,227,1,0,0,0,225,223,1,0,0,0,225,226,1,0,0,0,226,228,
		1,0,0,0,227,225,1,0,0,0,228,229,5,0,0,1,229,1,1,0,0,0,230,232,5,1,0,0,
		231,230,1,0,0,0,232,235,1,0,0,0,233,231,1,0,0,0,233,234,1,0,0,0,234,236,
		1,0,0,0,235,233,1,0,0,0,236,245,3,4,2,0,237,239,5,1,0,0,238,237,1,0,0,
		0,239,240,1,0,0,0,240,238,1,0,0,0,240,241,1,0,0,0,241,242,1,0,0,0,242,
		244,3,4,2,0,243,238,1,0,0,0,244,247,1,0,0,0,245,243,1,0,0,0,245,246,1,
		0,0,0,246,251,1,0,0,0,247,245,1,0,0,0,248,250,5,1,0,0,249,248,1,0,0,0,
		250,253,1,0,0,0,251,249,1,0,0,0,251,252,1,0,0,0,252,3,1,0,0,0,253,251,
		1,0,0,0,254,257,5,71,0,0,255,256,5,114,0,0,256,258,5,111,0,0,257,255,1,
		0,0,0,257,258,1,0,0,0,258,260,1,0,0,0,259,254,1,0,0,0,259,260,1,0,0,0,
		260,285,1,0,0,0,261,286,3,6,3,0,262,286,3,8,4,0,263,286,3,10,5,0,264,286,
		3,12,6,0,265,286,3,14,7,0,266,286,3,22,11,0,267,286,3,26,13,0,268,286,
		3,42,21,0,269,286,3,44,22,0,270,286,3,46,23,0,271,286,3,56,28,0,272,286,
		3,58,29,0,273,286,3,60,30,0,274,286,3,62,31,0,275,286,3,70,35,0,276,286,
		3,76,38,0,277,286,3,80,40,0,278,286,3,20,10,0,279,286,3,16,8,0,280,286,
		3,18,9,0,281,286,3,82,41,0,282,286,3,104,52,0,283,286,3,108,54,0,284,286,
		3,112,56,0,285,261,1,0,0,0,285,262,1,0,0,0,285,263,1,0,0,0,285,264,1,0,
		0,0,285,265,1,0,0,0,285,266,1,0,0,0,285,267,1,0,0,0,285,268,1,0,0,0,285,
		269,1,0,0,0,285,270,1,0,0,0,285,271,1,0,0,0,285,272,1,0,0,0,285,273,1,
		0,0,0,285,274,1,0,0,0,285,275,1,0,0,0,285,276,1,0,0,0,285,277,1,0,0,0,
		285,278,1,0,0,0,285,279,1,0,0,0,285,280,1,0,0,0,285,281,1,0,0,0,285,282,
		1,0,0,0,285,283,1,0,0,0,285,284,1,0,0,0,286,5,1,0,0,0,287,288,5,30,0,0,
		288,292,5,132,0,0,289,290,3,178,89,0,290,291,5,2,0,0,291,293,1,0,0,0,292,
		289,1,0,0,0,292,293,1,0,0,0,293,294,1,0,0,0,294,317,3,180,90,0,295,305,
		5,121,0,0,296,297,5,136,0,0,297,306,3,180,90,0,298,300,5,46,0,0,299,298,
		1,0,0,0,299,300,1,0,0,0,300,301,1,0,0,0,301,302,3,184,92,0,302,303,5,136,
		0,0,303,304,3,184,92,0,304,306,1,0,0,0,305,296,1,0,0,0,305,299,1,0,0,0,
		306,318,1,0,0,0,307,309,5,27,0,0,308,310,5,46,0,0,309,308,1,0,0,0,309,
		310,1,0,0,0,310,311,1,0,0,0,311,318,3,28,14,0,312,314,5,63,0,0,313,315,
		5,46,0,0,314,313,1,0,0,0,314,315,1,0,0,0,315,316,1,0,0,0,316,318,3,184,
		92,0,317,295,1,0,0,0,317,307,1,0,0,0,317,312,1,0,0,0,318,7,1,0,0,0,319,
		327,5,31,0,0,320,328,3,178,89,0,321,322,3,178,89,0,322,323,5,2,0,0,323,
		325,1,0,0,0,324,321,1,0,0,0,324,325,1,0,0,0,325,326,1,0,0,0,326,328,3,
		182,91,0,327,320,1,0,0,0,327,324,1,0,0,0,327,328,1,0,0,0,328,9,1,0,0,0,
		329,331,5,35,0,0,330,332,5,55,0,0,331,330,1,0,0,0,331,332,1,0,0,0,332,
		333,1,0,0,0,333,334,3,64,32,0,334,335,5,33,0,0,335,336,3,178,89,0,336,
		11,1,0,0,0,337,339,5,38,0,0,338,340,7,0,0,0,339,338,1,0,0,0,339,340,1,
		0,0,0,340,345,1,0,0,0,341,343,5,137,0,0,342,344,3,204,102,0,343,342,1,
		0,0,0,343,344,1,0,0,0,344,346,1,0,0,0,345,341,1,0,0,0,345,346,1,0,0,0,
		346,13,1,0,0,0,347,349,7,1,0,0,348,350,5,137,0,0,349,348,1,0,0,0,349,350,
		1,0,0,0,350,15,1,0,0,0,351,353,5,126,0,0,352,354,5,137,0,0,353,352,1,0,
		0,0,353,354,1,0,0,0,354,360,1,0,0,0,355,357,5,136,0,0,356,358,5,129,0,
		0,357,356,1,0,0,0,357,358,1,0,0,0,358,359,1,0,0,0,359,361,3,200,100,0,
		360,355,1,0,0,0,360,361,1,0,0,0,361,17,1,0,0,0,362,363,5,129,0,0,363,364,
		3,200,100,0,364,19,1,0,0,0,365,367,5,120,0,0,366,368,5,129,0,0,367,366,
		1,0,0,0,367,368,1,0,0,0,368,369,1,0,0,0,369,370,3,200,100,0,370,21,1,0,
		0,0,371,373,5,50,0,0,372,374,5,140,0,0,373,372,1,0,0,0,373,374,1,0,0,0,
		374,375,1,0,0,0,375,379,5,84,0,0,376,377,5,80,0,0,377,378,5,102,0,0,378,
		380,5,70,0,0,379,376,1,0,0,0,379,380,1,0,0,0,380,384,1,0,0,0,381,382,3,
		178,89,0,382,383,5,2,0,0,383,385,1,0,0,0,384,381,1,0,0,0,384,385,1,0,0,
		0,385,386,1,0,0,0,386,387,3,190,95,0,387,388,5,107,0,0,388,389,3,180,90,
		0,389,390,5,3,0,0,390,395,3,24,12,0,391,392,5,5,0,0,392,394,3,24,12,0,
		393,391,1,0,0,0,394,397,1,0,0,0,395,393,1,0,0,0,395,396,1,0,0,0,396,398,
		1,0,0,0,397,395,1,0,0,0,398,401,5,4,0,0,399,400,5,148,0,0,400,402,3,64,
		32,0,401,399,1,0,0,0,401,402,1,0,0,0,402,23,1,0,0,0,403,406,3,184,92,0,
		404,406,3,64,32,0,405,403,1,0,0,0,405,404,1,0,0,0,406,409,1,0,0,0,407,
		408,5,45,0,0,408,410,3,186,93,0,409,407,1,0,0,0,409,410,1,0,0,0,410,412,
		1,0,0,0,411,413,3,138,69,0,412,411,1,0,0,0,412,413,1,0,0,0,413,25,1,0,
		0,0,414,416,5,50,0,0,415,417,7,2,0,0,416,415,1,0,0,0,416,417,1,0,0,0,417,
		418,1,0,0,0,418,422,5,132,0,0,419,420,5,80,0,0,420,421,5,102,0,0,421,423,
		5,70,0,0,422,419,1,0,0,0,422,423,1,0,0,0,423,427,1,0,0,0,424,425,3,178,
		89,0,425,426,5,2,0,0,426,428,1,0,0,0,427,424,1,0,0,0,427,428,1,0,0,0,428,
		429,1,0,0,0,429,453,3,180,90,0,430,431,5,3,0,0,431,436,3,28,14,0,432,433,
		5,5,0,0,433,435,3,28,14,0,434,432,1,0,0,0,435,438,1,0,0,0,436,437,1,0,
		0,0,436,434,1,0,0,0,437,443,1,0,0,0,438,436,1,0,0,0,439,440,5,5,0,0,440,
		442,3,36,18,0,441,439,1,0,0,0,442,445,1,0,0,0,443,441,1,0,0,0,443,444,
		1,0,0,0,444,446,1,0,0,0,445,443,1,0,0,0,446,449,5,4,0,0,447,448,5,150,
		0,0,448,450,5,185,0,0,449,447,1,0,0,0,449,450,1,0,0,0,450,454,1,0,0,0,
		451,452,5,33,0,0,452,454,3,82,41,0,453,430,1,0,0,0,453,451,1,0,0,0,454,
		27,1,0,0,0,455,457,3,184,92,0,456,458,3,30,15,0,457,456,1,0,0,0,457,458,
		1,0,0,0,458,462,1,0,0,0,459,461,3,32,16,0,460,459,1,0,0,0,461,464,1,0,
		0,0,462,460,1,0,0,0,462,463,1,0,0,0,463,29,1,0,0,0,464,462,1,0,0,0,465,
		467,3,174,87,0,466,465,1,0,0,0,467,468,1,0,0,0,468,469,1,0,0,0,468,466,
		1,0,0,0,469,480,1,0,0,0,470,471,5,3,0,0,471,472,3,34,17,0,472,473,5,4,
		0,0,473,481,1,0,0,0,474,475,5,3,0,0,475,476,3,34,17,0,476,477,5,5,0,0,
		477,478,3,34,17,0,478,479,5,4,0,0,479,481,1,0,0,0,480,470,1,0,0,0,480,
		474,1,0,0,0,480,481,1,0,0,0,481,31,1,0,0,0,482,483,5,49,0,0,483,485,3,
		174,87,0,484,482,1,0,0,0,484,485,1,0,0,0,485,533,1,0,0,0,486,487,5,113,
		0,0,487,489,5,95,0,0,488,490,3,138,69,0,489,488,1,0,0,0,489,490,1,0,0,
		0,490,492,1,0,0,0,491,493,3,40,20,0,492,491,1,0,0,0,492,493,1,0,0,0,493,
		495,1,0,0,0,494,496,5,36,0,0,495,494,1,0,0,0,495,496,1,0,0,0,496,534,1,
		0,0,0,497,498,5,102,0,0,498,501,5,104,0,0,499,501,5,140,0,0,500,497,1,
		0,0,0,500,499,1,0,0,0,501,503,1,0,0,0,502,504,3,40,20,0,503,502,1,0,0,
		0,503,504,1,0,0,0,504,534,1,0,0,0,505,506,5,44,0,0,506,507,5,3,0,0,507,
		508,3,64,32,0,508,509,5,4,0,0,509,534,1,0,0,0,510,517,5,56,0,0,511,518,
		3,34,17,0,512,518,3,68,34,0,513,514,5,3,0,0,514,515,3,64,32,0,515,516,
		5,4,0,0,516,518,1,0,0,0,517,511,1,0,0,0,517,512,1,0,0,0,517,513,1,0,0,
		0,518,534,1,0,0,0,519,520,5,45,0,0,520,534,3,186,93,0,521,534,3,38,19,
		0,522,523,5,169,0,0,523,525,5,170,0,0,524,522,1,0,0,0,524,525,1,0,0,0,
		525,526,1,0,0,0,526,527,5,33,0,0,527,528,5,3,0,0,528,529,3,64,32,0,529,
		531,5,4,0,0,530,532,7,3,0,0,531,530,1,0,0,0,531,532,1,0,0,0,532,534,1,
		0,0,0,533,486,1,0,0,0,533,500,1,0,0,0,533,505,1,0,0,0,533,510,1,0,0,0,
		533,519,1,0,0,0,533,521,1,0,0,0,533,524,1,0,0,0,534,33,1,0,0,0,535,537,
		7,4,0,0,536,535,1,0,0,0,536,537,1,0,0,0,537,538,1,0,0,0,538,539,5,186,
		0,0,539,35,1,0,0,0,540,541,5,49,0,0,541,543,3,174,87,0,542,540,1,0,0,0,
		542,543,1,0,0,0,543,581,1,0,0,0,544,545,5,113,0,0,545,548,5,95,0,0,546,
		548,5,140,0,0,547,544,1,0,0,0,547,546,1,0,0,0,548,549,1,0,0,0,549,550,
		5,3,0,0,550,555,3,24,12,0,551,552,5,5,0,0,552,554,3,24,12,0,553,551,1,
		0,0,0,554,557,1,0,0,0,555,553,1,0,0,0,555,556,1,0,0,0,556,558,1,0,0,0,
		557,555,1,0,0,0,558,560,5,4,0,0,559,561,3,40,20,0,560,559,1,0,0,0,560,
		561,1,0,0,0,561,582,1,0,0,0,562,563,5,44,0,0,563,564,5,3,0,0,564,565,3,
		64,32,0,565,566,5,4,0,0,566,582,1,0,0,0,567,568,5,74,0,0,568,569,5,95,
		0,0,569,570,5,3,0,0,570,575,3,184,92,0,571,572,5,5,0,0,572,574,3,184,92,
		0,573,571,1,0,0,0,574,577,1,0,0,0,575,573,1,0,0,0,575,576,1,0,0,0,576,
		578,1,0,0,0,577,575,1,0,0,0,578,579,5,4,0,0,579,580,3,38,19,0,580,582,
		1,0,0,0,581,547,1,0,0,0,581,562,1,0,0,0,581,567,1,0,0,0,582,37,1,0,0,0,
		583,584,5,117,0,0,584,596,3,188,94,0,585,586,5,3,0,0,586,591,3,184,92,
		0,587,588,5,5,0,0,588,590,3,184,92,0,589,587,1,0,0,0,590,593,1,0,0,0,591,
		589,1,0,0,0,591,592,1,0,0,0,592,594,1,0,0,0,593,591,1,0,0,0,594,595,5,
		4,0,0,595,597,1,0,0,0,596,585,1,0,0,0,596,597,1,0,0,0,597,612,1,0,0,0,
		598,599,5,107,0,0,599,606,7,5,0,0,600,601,5,131,0,0,601,607,7,6,0,0,602,
		607,5,41,0,0,603,607,5,123,0,0,604,605,5,101,0,0,605,607,5,26,0,0,606,
		600,1,0,0,0,606,602,1,0,0,0,606,603,1,0,0,0,606,604,1,0,0,0,607,611,1,
		0,0,0,608,609,5,99,0,0,609,611,3,174,87,0,610,598,1,0,0,0,610,608,1,0,
		0,0,611,614,1,0,0,0,612,610,1,0,0,0,612,613,1,0,0,0,613,623,1,0,0,0,614,
		612,1,0,0,0,615,617,5,102,0,0,616,615,1,0,0,0,616,617,1,0,0,0,617,618,
		1,0,0,0,618,621,5,57,0,0,619,620,5,86,0,0,620,622,7,7,0,0,621,619,1,0,
		0,0,621,622,1,0,0,0,622,624,1,0,0,0,623,616,1,0,0,0,623,624,1,0,0,0,624,
		39,1,0,0,0,625,626,5,107,0,0,626,627,5,48,0,0,627,628,7,8,0,0,628,41,1,
		0,0,0,629,631,5,50,0,0,630,632,7,2,0,0,631,630,1,0,0,0,631,632,1,0,0,0,
		632,633,1,0,0,0,633,637,5,138,0,0,634,635,5,80,0,0,635,636,5,102,0,0,636,
		638,5,70,0,0,637,634,1,0,0,0,637,638,1,0,0,0,638,642,1,0,0,0,639,640,3,
		178,89,0,640,641,5,2,0,0,641,643,1,0,0,0,642,639,1,0,0,0,642,643,1,0,0,
		0,643,644,1,0,0,0,644,649,3,192,96,0,645,650,5,37,0,0,646,650,5,28,0,0,
		647,648,5,89,0,0,648,650,5,105,0,0,649,645,1,0,0,0,649,646,1,0,0,0,649,
		647,1,0,0,0,649,650,1,0,0,0,650,665,1,0,0,0,651,666,5,59,0,0,652,666,5,
		88,0,0,653,663,5,141,0,0,654,655,5,105,0,0,655,660,3,184,92,0,656,657,
		5,5,0,0,657,659,3,184,92,0,658,656,1,0,0,0,659,662,1,0,0,0,660,658,1,0,
		0,0,660,661,1,0,0,0,661,664,1,0,0,0,662,660,1,0,0,0,663,654,1,0,0,0,663,
		664,1,0,0,0,664,666,1,0,0,0,665,651,1,0,0,0,665,652,1,0,0,0,665,653,1,
		0,0,0,666,667,1,0,0,0,667,668,5,107,0,0,668,672,3,180,90,0,669,670,5,73,
		0,0,670,671,5,64,0,0,671,673,5,127,0,0,672,669,1,0,0,0,672,673,1,0,0,0,
		673,676,1,0,0,0,674,675,5,147,0,0,675,677,3,64,32,0,676,674,1,0,0,0,676,
		677,1,0,0,0,677,678,1,0,0,0,678,687,5,38,0,0,679,684,3,104,52,0,680,684,
		3,70,35,0,681,684,3,56,28,0,682,684,3,82,41,0,683,679,1,0,0,0,683,680,
		1,0,0,0,683,681,1,0,0,0,683,682,1,0,0,0,684,685,1,0,0,0,685,686,5,1,0,
		0,686,688,1,0,0,0,687,683,1,0,0,0,688,689,1,0,0,0,689,687,1,0,0,0,689,
		690,1,0,0,0,690,691,1,0,0,0,691,692,5,66,0,0,692,43,1,0,0,0,693,695,5,
		50,0,0,694,696,7,2,0,0,695,694,1,0,0,0,695,696,1,0,0,0,696,697,1,0,0,0,
		697,701,5,145,0,0,698,699,5,80,0,0,699,700,5,102,0,0,700,702,5,70,0,0,
		701,698,1,0,0,0,701,702,1,0,0,0,702,706,1,0,0,0,703,704,3,178,89,0,704,
		705,5,2,0,0,705,707,1,0,0,0,706,703,1,0,0,0,706,707,1,0,0,0,707,708,1,
		0,0,0,708,720,3,194,97,0,709,710,5,3,0,0,710,715,3,184,92,0,711,712,5,
		5,0,0,712,714,3,184,92,0,713,711,1,0,0,0,714,717,1,0,0,0,715,713,1,0,0,
		0,715,716,1,0,0,0,716,718,1,0,0,0,717,715,1,0,0,0,718,719,5,4,0,0,719,
		721,1,0,0,0,720,709,1,0,0,0,720,721,1,0,0,0,721,722,1,0,0,0,722,723,5,
		33,0,0,723,724,3,82,41,0,724,45,1,0,0,0,725,726,5,50,0,0,726,727,5,146,
		0,0,727,731,5,132,0,0,728,729,5,80,0,0,729,730,5,102,0,0,730,732,5,70,
		0,0,731,728,1,0,0,0,731,732,1,0,0,0,732,736,1,0,0,0,733,734,3,178,89,0,
		734,735,5,2,0,0,735,737,1,0,0,0,736,733,1,0,0,0,736,737,1,0,0,0,737,738,
		1,0,0,0,738,739,3,180,90,0,739,740,5,142,0,0,740,752,3,196,98,0,741,742,
		5,3,0,0,742,747,3,168,84,0,743,744,5,5,0,0,744,746,3,168,84,0,745,743,
		1,0,0,0,746,749,1,0,0,0,747,745,1,0,0,0,747,748,1,0,0,0,748,750,1,0,0,
		0,749,747,1,0,0,0,750,751,5,4,0,0,751,753,1,0,0,0,752,741,1,0,0,0,752,
		753,1,0,0,0,753,47,1,0,0,0,754,756,5,149,0,0,755,757,5,116,0,0,756,755,
		1,0,0,0,756,757,1,0,0,0,757,758,1,0,0,0,758,759,3,50,25,0,759,760,5,33,
		0,0,760,761,5,3,0,0,761,762,3,82,41,0,762,772,5,4,0,0,763,764,5,5,0,0,
		764,765,3,50,25,0,765,766,5,33,0,0,766,767,5,3,0,0,767,768,3,82,41,0,768,
		769,5,4,0,0,769,771,1,0,0,0,770,763,1,0,0,0,771,774,1,0,0,0,772,770,1,
		0,0,0,772,773,1,0,0,0,773,49,1,0,0,0,774,772,1,0,0,0,775,787,3,180,90,
		0,776,777,5,3,0,0,777,782,3,184,92,0,778,779,5,5,0,0,779,781,3,184,92,
		0,780,778,1,0,0,0,781,784,1,0,0,0,782,780,1,0,0,0,782,783,1,0,0,0,783,
		785,1,0,0,0,784,782,1,0,0,0,785,786,5,4,0,0,786,788,1,0,0,0,787,776,1,
		0,0,0,787,788,1,0,0,0,788,51,1,0,0,0,789,790,3,50,25,0,790,791,5,33,0,
		0,791,792,5,3,0,0,792,793,3,160,80,0,793,795,5,139,0,0,794,796,5,29,0,
		0,795,794,1,0,0,0,795,796,1,0,0,0,796,797,1,0,0,0,797,798,3,162,81,0,798,
		799,5,4,0,0,799,53,1,0,0,0,800,812,3,180,90,0,801,802,5,3,0,0,802,807,
		3,184,92,0,803,804,5,5,0,0,804,806,3,184,92,0,805,803,1,0,0,0,806,809,
		1,0,0,0,807,805,1,0,0,0,807,808,1,0,0,0,808,810,1,0,0,0,809,807,1,0,0,
		0,810,811,5,4,0,0,811,813,1,0,0,0,812,801,1,0,0,0,812,813,1,0,0,0,813,
		814,1,0,0,0,814,815,5,33,0,0,815,816,5,3,0,0,816,817,3,82,41,0,817,818,
		5,4,0,0,818,55,1,0,0,0,819,821,3,48,24,0,820,819,1,0,0,0,820,821,1,0,0,
		0,821,822,1,0,0,0,822,823,5,59,0,0,823,824,5,75,0,0,824,827,3,110,55,0,
		825,826,5,148,0,0,826,828,3,64,32,0,827,825,1,0,0,0,827,828,1,0,0,0,828,
		830,1,0,0,0,829,831,3,72,36,0,830,829,1,0,0,0,830,831,1,0,0,0,831,57,1,
		0,0,0,832,834,3,48,24,0,833,832,1,0,0,0,833,834,1,0,0,0,834,835,1,0,0,
		0,835,836,5,59,0,0,836,837,5,75,0,0,837,840,3,110,55,0,838,839,5,148,0,
		0,839,841,3,64,32,0,840,838,1,0,0,0,840,841,1,0,0,0,841,843,1,0,0,0,842,
		844,3,72,36,0,843,842,1,0,0,0,843,844,1,0,0,0,844,849,1,0,0,0,845,847,
		3,132,66,0,846,845,1,0,0,0,846,847,1,0,0,0,847,848,1,0,0,0,848,850,3,134,
		67,0,849,846,1,0,0,0,849,850,1,0,0,0,850,59,1,0,0,0,851,853,5,61,0,0,852,
		854,5,55,0,0,853,852,1,0,0,0,853,854,1,0,0,0,854,855,1,0,0,0,855,856,3,
		178,89,0,856,61,1,0,0,0,857,858,5,63,0,0,858,861,7,9,0,0,859,860,5,80,
		0,0,860,862,5,70,0,0,861,859,1,0,0,0,861,862,1,0,0,0,862,866,1,0,0,0,863,
		864,3,178,89,0,864,865,5,2,0,0,865,867,1,0,0,0,866,863,1,0,0,0,866,867,
		1,0,0,0,867,868,1,0,0,0,868,869,3,220,110,0,869,63,1,0,0,0,870,871,6,32,
		-1,0,871,959,3,68,34,0,872,959,5,187,0,0,873,874,3,178,89,0,874,875,5,
		2,0,0,875,877,1,0,0,0,876,873,1,0,0,0,876,877,1,0,0,0,877,878,1,0,0,0,
		878,879,3,180,90,0,879,880,5,2,0,0,880,882,1,0,0,0,881,876,1,0,0,0,881,
		882,1,0,0,0,882,883,1,0,0,0,883,959,3,184,92,0,884,885,3,164,82,0,885,
		886,3,64,32,21,886,959,1,0,0,0,887,888,3,176,88,0,888,901,5,3,0,0,889,
		891,5,62,0,0,890,889,1,0,0,0,890,891,1,0,0,0,891,892,1,0,0,0,892,897,3,
		64,32,0,893,894,5,5,0,0,894,896,3,64,32,0,895,893,1,0,0,0,896,899,1,0,
		0,0,897,895,1,0,0,0,897,898,1,0,0,0,898,902,1,0,0,0,899,897,1,0,0,0,900,
		902,5,7,0,0,901,890,1,0,0,0,901,900,1,0,0,0,901,902,1,0,0,0,902,903,1,
		0,0,0,903,905,5,4,0,0,904,906,3,114,57,0,905,904,1,0,0,0,905,906,1,0,0,
		0,906,908,1,0,0,0,907,909,3,118,59,0,908,907,1,0,0,0,908,909,1,0,0,0,909,
		959,1,0,0,0,910,911,5,3,0,0,911,916,3,64,32,0,912,913,5,5,0,0,913,915,
		3,64,32,0,914,912,1,0,0,0,915,918,1,0,0,0,916,914,1,0,0,0,916,917,1,0,
		0,0,917,919,1,0,0,0,918,916,1,0,0,0,919,920,5,4,0,0,920,959,1,0,0,0,921,
		922,5,43,0,0,922,923,5,3,0,0,923,924,3,64,32,0,924,925,5,33,0,0,925,926,
		3,30,15,0,926,927,5,4,0,0,927,959,1,0,0,0,928,930,5,102,0,0,929,928,1,
		0,0,0,929,930,1,0,0,0,930,931,1,0,0,0,931,933,5,70,0,0,932,929,1,0,0,0,
		932,933,1,0,0,0,933,934,1,0,0,0,934,935,5,3,0,0,935,936,3,82,41,0,936,
		937,5,4,0,0,937,959,1,0,0,0,938,940,5,42,0,0,939,941,3,64,32,0,940,939,
		1,0,0,0,940,941,1,0,0,0,941,947,1,0,0,0,942,943,5,147,0,0,943,944,3,64,
		32,0,944,945,5,135,0,0,945,946,3,64,32,0,946,948,1,0,0,0,947,942,1,0,0,
		0,948,949,1,0,0,0,949,947,1,0,0,0,949,950,1,0,0,0,950,953,1,0,0,0,951,
		952,5,65,0,0,952,954,3,64,32,0,953,951,1,0,0,0,953,954,1,0,0,0,954,955,
		1,0,0,0,955,956,5,66,0,0,956,959,1,0,0,0,957,959,3,66,33,0,958,870,1,0,
		0,0,958,872,1,0,0,0,958,881,1,0,0,0,958,884,1,0,0,0,958,887,1,0,0,0,958,
		910,1,0,0,0,958,921,1,0,0,0,958,932,1,0,0,0,958,938,1,0,0,0,958,957,1,
		0,0,0,959,1079,1,0,0,0,960,961,10,20,0,0,961,962,5,11,0,0,962,1078,3,64,
		32,21,963,964,10,19,0,0,964,965,7,10,0,0,965,1078,3,64,32,20,966,967,10,
		18,0,0,967,968,7,4,0,0,968,1078,3,64,32,19,969,970,10,17,0,0,970,971,7,
		11,0,0,971,1078,3,64,32,18,972,973,10,16,0,0,973,974,7,12,0,0,974,1078,
		3,64,32,17,975,988,10,15,0,0,976,989,5,6,0,0,977,989,5,22,0,0,978,989,
		5,23,0,0,979,989,5,24,0,0,980,989,5,92,0,0,981,982,5,92,0,0,982,989,5,
		102,0,0,983,989,5,83,0,0,984,989,5,97,0,0,985,989,5,77,0,0,986,989,5,99,
		0,0,987,989,5,118,0,0,988,976,1,0,0,0,988,977,1,0,0,0,988,978,1,0,0,0,
		988,979,1,0,0,0,988,980,1,0,0,0,988,981,1,0,0,0,988,983,1,0,0,0,988,984,
		1,0,0,0,988,985,1,0,0,0,988,986,1,0,0,0,988,987,1,0,0,0,989,990,1,0,0,
		0,990,1078,3,64,32,16,991,992,10,14,0,0,992,993,5,32,0,0,993,1078,3,64,
		32,15,994,995,10,13,0,0,995,996,5,108,0,0,996,1078,3,64,32,14,997,998,
		10,6,0,0,998,1000,5,92,0,0,999,1001,5,102,0,0,1000,999,1,0,0,0,1000,1001,
		1,0,0,0,1001,1002,1,0,0,0,1002,1078,3,64,32,7,1003,1005,10,5,0,0,1004,
		1006,5,102,0,0,1005,1004,1,0,0,0,1005,1006,1,0,0,0,1006,1007,1,0,0,0,1007,
		1008,5,39,0,0,1008,1009,3,64,32,0,1009,1010,5,32,0,0,1010,1011,3,64,32,
		6,1011,1078,1,0,0,0,1012,1013,10,9,0,0,1013,1014,5,45,0,0,1014,1078,3,
		186,93,0,1015,1017,10,8,0,0,1016,1018,5,102,0,0,1017,1016,1,0,0,0,1017,
		1018,1,0,0,0,1018,1019,1,0,0,0,1019,1020,7,13,0,0,1020,1023,3,64,32,0,
		1021,1022,5,67,0,0,1022,1024,3,64,32,0,1023,1021,1,0,0,0,1023,1024,1,0,
		0,0,1024,1078,1,0,0,0,1025,1030,10,7,0,0,1026,1031,5,93,0,0,1027,1031,
		5,103,0,0,1028,1029,5,102,0,0,1029,1031,5,104,0,0,1030,1026,1,0,0,0,1030,
		1027,1,0,0,0,1030,1028,1,0,0,0,1031,1078,1,0,0,0,1032,1034,10,4,0,0,1033,
		1035,5,102,0,0,1034,1033,1,0,0,0,1034,1035,1,0,0,0,1035,1036,1,0,0,0,1036,
		1075,5,83,0,0,1037,1047,5,3,0,0,1038,1048,3,82,41,0,1039,1044,3,64,32,
		0,1040,1041,5,5,0,0,1041,1043,3,64,32,0,1042,1040,1,0,0,0,1043,1046,1,
		0,0,0,1044,1042,1,0,0,0,1044,1045,1,0,0,0,1045,1048,1,0,0,0,1046,1044,
		1,0,0,0,1047,1038,1,0,0,0,1047,1039,1,0,0,0,1047,1048,1,0,0,0,1048,1049,
		1,0,0,0,1049,1076,5,4,0,0,1050,1051,3,178,89,0,1051,1052,5,2,0,0,1052,
		1054,1,0,0,0,1053,1050,1,0,0,0,1053,1054,1,0,0,0,1054,1055,1,0,0,0,1055,
		1076,3,180,90,0,1056,1057,3,178,89,0,1057,1058,5,2,0,0,1058,1060,1,0,0,
		0,1059,1056,1,0,0,0,1059,1060,1,0,0,0,1060,1061,1,0,0,0,1061,1062,3,218,
		109,0,1062,1071,5,3,0,0,1063,1068,3,64,32,0,1064,1065,5,5,0,0,1065,1067,
		3,64,32,0,1066,1064,1,0,0,0,1067,1070,1,0,0,0,1068,1066,1,0,0,0,1068,1069,
		1,0,0,0,1069,1072,1,0,0,0,1070,1068,1,0,0,0,1071,1063,1,0,0,0,1071,1072,
		1,0,0,0,1072,1073,1,0,0,0,1073,1074,5,4,0,0,1074,1076,1,0,0,0,1075,1037,
		1,0,0,0,1075,1053,1,0,0,0,1075,1059,1,0,0,0,1076,1078,1,0,0,0,1077,960,
		1,0,0,0,1077,963,1,0,0,0,1077,966,1,0,0,0,1077,969,1,0,0,0,1077,972,1,
		0,0,0,1077,975,1,0,0,0,1077,991,1,0,0,0,1077,994,1,0,0,0,1077,997,1,0,
		0,0,1077,1003,1,0,0,0,1077,1012,1,0,0,0,1077,1015,1,0,0,0,1077,1025,1,
		0,0,0,1077,1032,1,0,0,0,1078,1081,1,0,0,0,1079,1077,1,0,0,0,1079,1080,
		1,0,0,0,1080,65,1,0,0,0,1081,1079,1,0,0,0,1082,1083,5,115,0,0,1083,1088,
		5,3,0,0,1084,1089,5,81,0,0,1085,1086,7,14,0,0,1086,1087,5,5,0,0,1087,1089,
		3,166,83,0,1088,1084,1,0,0,0,1088,1085,1,0,0,0,1089,1090,1,0,0,0,1090,
		1091,5,4,0,0,1091,67,1,0,0,0,1092,1093,7,15,0,0,1093,69,1,0,0,0,1094,1096,
		3,48,24,0,1095,1094,1,0,0,0,1095,1096,1,0,0,0,1096,1102,1,0,0,0,1097,1103,
		5,88,0,0,1098,1103,5,122,0,0,1099,1100,5,88,0,0,1100,1101,5,108,0,0,1101,
		1103,7,8,0,0,1102,1097,1,0,0,0,1102,1098,1,0,0,0,1102,1099,1,0,0,0,1103,
		1104,1,0,0,0,1104,1108,5,91,0,0,1105,1106,3,178,89,0,1106,1107,5,2,0,0,
		1107,1109,1,0,0,0,1108,1105,1,0,0,0,1108,1109,1,0,0,0,1109,1110,1,0,0,
		0,1110,1113,3,180,90,0,1111,1112,5,33,0,0,1112,1114,3,202,101,0,1113,1111,
		1,0,0,0,1113,1114,1,0,0,0,1114,1126,1,0,0,0,1115,1116,5,3,0,0,1116,1121,
		3,184,92,0,1117,1118,5,5,0,0,1118,1120,3,184,92,0,1119,1117,1,0,0,0,1120,
		1123,1,0,0,0,1121,1119,1,0,0,0,1121,1122,1,0,0,0,1122,1124,1,0,0,0,1123,
		1121,1,0,0,0,1124,1125,5,4,0,0,1125,1127,1,0,0,0,1126,1115,1,0,0,0,1126,
		1127,1,0,0,0,1127,1164,1,0,0,0,1128,1129,5,144,0,0,1129,1130,5,3,0,0,1130,
		1135,3,64,32,0,1131,1132,5,5,0,0,1132,1134,3,64,32,0,1133,1131,1,0,0,0,
		1134,1137,1,0,0,0,1135,1133,1,0,0,0,1135,1136,1,0,0,0,1136,1138,1,0,0,
		0,1137,1135,1,0,0,0,1138,1153,5,4,0,0,1139,1140,5,5,0,0,1140,1141,5,3,
		0,0,1141,1146,3,64,32,0,1142,1143,5,5,0,0,1143,1145,3,64,32,0,1144,1142,
		1,0,0,0,1145,1148,1,0,0,0,1146,1144,1,0,0,0,1146,1147,1,0,0,0,1147,1149,
		1,0,0,0,1148,1146,1,0,0,0,1149,1150,5,4,0,0,1150,1152,1,0,0,0,1151,1139,
		1,0,0,0,1152,1155,1,0,0,0,1153,1151,1,0,0,0,1153,1154,1,0,0,0,1154,1158,
		1,0,0,0,1155,1153,1,0,0,0,1156,1158,3,82,41,0,1157,1128,1,0,0,0,1157,1156,
		1,0,0,0,1158,1160,1,0,0,0,1159,1161,3,74,37,0,1160,1159,1,0,0,0,1160,1161,
		1,0,0,0,1161,1165,1,0,0,0,1162,1163,5,56,0,0,1163,1165,5,144,0,0,1164,
		1157,1,0,0,0,1164,1162,1,0,0,0,1165,1167,1,0,0,0,1166,1168,3,72,36,0,1167,
		1166,1,0,0,0,1167,1168,1,0,0,0,1168,71,1,0,0,0,1169,1170,5,124,0,0,1170,
		1175,3,96,48,0,1171,1172,5,5,0,0,1172,1174,3,96,48,0,1173,1171,1,0,0,0,
		1174,1177,1,0,0,0,1175,1173,1,0,0,0,1175,1176,1,0,0,0,1176,73,1,0,0,0,
		1177,1175,1,0,0,0,1178,1179,5,107,0,0,1179,1194,5,48,0,0,1180,1181,5,3,
		0,0,1181,1186,3,24,12,0,1182,1183,5,5,0,0,1183,1185,3,24,12,0,1184,1182,
		1,0,0,0,1185,1188,1,0,0,0,1186,1184,1,0,0,0,1186,1187,1,0,0,0,1187,1189,
		1,0,0,0,1188,1186,1,0,0,0,1189,1192,5,4,0,0,1190,1191,5,148,0,0,1191,1193,
		3,64,32,0,1192,1190,1,0,0,0,1192,1193,1,0,0,0,1193,1195,1,0,0,0,1194,1180,
		1,0,0,0,1194,1195,1,0,0,0,1195,1196,1,0,0,0,1196,1223,5,183,0,0,1197,1224,
		5,184,0,0,1198,1199,5,141,0,0,1199,1202,5,131,0,0,1200,1203,3,184,92,0,
		1201,1203,3,106,53,0,1202,1200,1,0,0,0,1202,1201,1,0,0,0,1203,1204,1,0,
		0,0,1204,1205,5,6,0,0,1205,1216,3,64,32,0,1206,1209,5,5,0,0,1207,1210,
		3,184,92,0,1208,1210,3,106,53,0,1209,1207,1,0,0,0,1209,1208,1,0,0,0,1210,
		1211,1,0,0,0,1211,1212,5,6,0,0,1212,1213,3,64,32,0,1213,1215,1,0,0,0,1214,
		1206,1,0,0,0,1215,1218,1,0,0,0,1216,1214,1,0,0,0,1216,1217,1,0,0,0,1217,
		1221,1,0,0,0,1218,1216,1,0,0,0,1219,1220,5,148,0,0,1220,1222,3,64,32,0,
		1221,1219,1,0,0,0,1221,1222,1,0,0,0,1222,1224,1,0,0,0,1223,1197,1,0,0,
		0,1223,1198,1,0,0,0,1224,75,1,0,0,0,1225,1229,5,112,0,0,1226,1227,3,178,
		89,0,1227,1228,5,2,0,0,1228,1230,1,0,0,0,1229,1226,1,0,0,0,1229,1230,1,
		0,0,0,1230,1231,1,0,0,0,1231,1238,3,198,99,0,1232,1233,5,6,0,0,1233,1239,
		3,78,39,0,1234,1235,5,3,0,0,1235,1236,3,78,39,0,1236,1237,5,4,0,0,1237,
		1239,1,0,0,0,1238,1232,1,0,0,0,1238,1234,1,0,0,0,1238,1239,1,0,0,0,1239,
		77,1,0,0,0,1240,1244,3,34,17,0,1241,1244,3,174,87,0,1242,1244,5,188,0,
		0,1243,1240,1,0,0,0,1243,1241,1,0,0,0,1243,1242,1,0,0,0,1244,79,1,0,0,
		0,1245,1256,5,119,0,0,1246,1257,3,186,93,0,1247,1248,3,178,89,0,1248,1249,
		5,2,0,0,1249,1251,1,0,0,0,1250,1247,1,0,0,0,1250,1251,1,0,0,0,1251,1254,
		1,0,0,0,1252,1255,3,180,90,0,1253,1255,3,190,95,0,1254,1252,1,0,0,0,1254,
		1253,1,0,0,0,1255,1257,1,0,0,0,1256,1246,1,0,0,0,1256,1250,1,0,0,0,1256,
		1257,1,0,0,0,1257,81,1,0,0,0,1258,1260,3,130,65,0,1259,1258,1,0,0,0,1259,
		1260,1,0,0,0,1260,1261,1,0,0,0,1261,1267,3,86,43,0,1262,1263,3,102,51,
		0,1263,1264,3,86,43,0,1264,1266,1,0,0,0,1265,1262,1,0,0,0,1266,1269,1,
		0,0,0,1267,1265,1,0,0,0,1267,1268,1,0,0,0,1268,1271,1,0,0,0,1269,1267,
		1,0,0,0,1270,1272,3,132,66,0,1271,1270,1,0,0,0,1271,1272,1,0,0,0,1272,
		1274,1,0,0,0,1273,1275,3,134,67,0,1274,1273,1,0,0,0,1274,1275,1,0,0,0,
		1275,83,1,0,0,0,1276,1284,3,94,47,0,1277,1278,3,98,49,0,1278,1280,3,94,
		47,0,1279,1281,3,100,50,0,1280,1279,1,0,0,0,1280,1281,1,0,0,0,1281,1283,
		1,0,0,0,1282,1277,1,0,0,0,1283,1286,1,0,0,0,1284,1282,1,0,0,0,1284,1285,
		1,0,0,0,1285,85,1,0,0,0,1286,1284,1,0,0,0,1287,1289,5,130,0,0,1288,1290,
		7,16,0,0,1289,1288,1,0,0,0,1289,1290,1,0,0,0,1290,1291,1,0,0,0,1291,1296,
		3,96,48,0,1292,1293,5,5,0,0,1293,1295,3,96,48,0,1294,1292,1,0,0,0,1295,
		1298,1,0,0,0,1296,1294,1,0,0,0,1296,1297,1,0,0,0,1297,1311,1,0,0,0,1298,
		1296,1,0,0,0,1299,1309,5,75,0,0,1300,1305,3,94,47,0,1301,1302,5,5,0,0,
		1302,1304,3,94,47,0,1303,1301,1,0,0,0,1304,1307,1,0,0,0,1305,1303,1,0,
		0,0,1305,1306,1,0,0,0,1306,1310,1,0,0,0,1307,1305,1,0,0,0,1308,1310,3,
		84,42,0,1309,1300,1,0,0,0,1309,1308,1,0,0,0,1310,1312,1,0,0,0,1311,1299,
		1,0,0,0,1311,1312,1,0,0,0,1312,1315,1,0,0,0,1313,1314,5,148,0,0,1314,1316,
		3,64,32,0,1315,1313,1,0,0,0,1315,1316,1,0,0,0,1316,1331,1,0,0,0,1317,1318,
		5,78,0,0,1318,1319,5,40,0,0,1319,1324,3,64,32,0,1320,1321,5,5,0,0,1321,
		1323,3,64,32,0,1322,1320,1,0,0,0,1323,1326,1,0,0,0,1324,1322,1,0,0,0,1324,
		1325,1,0,0,0,1325,1329,1,0,0,0,1326,1324,1,0,0,0,1327,1328,5,79,0,0,1328,
		1330,3,64,32,0,1329,1327,1,0,0,0,1329,1330,1,0,0,0,1330,1332,1,0,0,0,1331,
		1317,1,0,0,0,1331,1332,1,0,0,0,1332,1347,1,0,0,0,1333,1334,5,174,0,0,1334,
		1335,3,206,103,0,1335,1336,5,33,0,0,1336,1344,3,116,58,0,1337,1338,5,5,
		0,0,1338,1339,3,206,103,0,1339,1340,5,33,0,0,1340,1341,3,116,58,0,1341,
		1343,1,0,0,0,1342,1337,1,0,0,0,1343,1346,1,0,0,0,1344,1342,1,0,0,0,1344,
		1345,1,0,0,0,1345,1348,1,0,0,0,1346,1344,1,0,0,0,1347,1333,1,0,0,0,1347,
		1348,1,0,0,0,1348,1378,1,0,0,0,1349,1350,5,144,0,0,1350,1351,5,3,0,0,1351,
		1356,3,64,32,0,1352,1353,5,5,0,0,1353,1355,3,64,32,0,1354,1352,1,0,0,0,
		1355,1358,1,0,0,0,1356,1354,1,0,0,0,1356,1357,1,0,0,0,1357,1359,1,0,0,
		0,1358,1356,1,0,0,0,1359,1374,5,4,0,0,1360,1361,5,5,0,0,1361,1362,5,3,
		0,0,1362,1367,3,64,32,0,1363,1364,5,5,0,0,1364,1366,3,64,32,0,1365,1363,
		1,0,0,0,1366,1369,1,0,0,0,1367,1365,1,0,0,0,1367,1368,1,0,0,0,1368,1370,
		1,0,0,0,1369,1367,1,0,0,0,1370,1371,5,4,0,0,1371,1373,1,0,0,0,1372,1360,
		1,0,0,0,1373,1376,1,0,0,0,1374,1372,1,0,0,0,1374,1375,1,0,0,0,1375,1378,
		1,0,0,0,1376,1374,1,0,0,0,1377,1287,1,0,0,0,1377,1349,1,0,0,0,1378,87,
		1,0,0,0,1379,1380,3,82,41,0,1380,89,1,0,0,0,1381,1383,3,130,65,0,1382,
		1381,1,0,0,0,1382,1383,1,0,0,0,1383,1384,1,0,0,0,1384,1386,3,86,43,0,1385,
		1387,3,132,66,0,1386,1385,1,0,0,0,1386,1387,1,0,0,0,1387,1389,1,0,0,0,
		1388,1390,3,134,67,0,1389,1388,1,0,0,0,1389,1390,1,0,0,0,1390,91,1,0,0,
		0,1391,1393,3,130,65,0,1392,1391,1,0,0,0,1392,1393,1,0,0,0,1393,1394,1,
		0,0,0,1394,1404,3,86,43,0,1395,1397,5,139,0,0,1396,1398,5,29,0,0,1397,
		1396,1,0,0,0,1397,1398,1,0,0,0,1398,1402,1,0,0,0,1399,1402,5,90,0,0,1400,
		1402,5,68,0,0,1401,1395,1,0,0,0,1401,1399,1,0,0,0,1401,1400,1,0,0,0,1402,
		1403,1,0,0,0,1403,1405,3,86,43,0,1404,1401,1,0,0,0,1405,1406,1,0,0,0,1406,
		1404,1,0,0,0,1406,1407,1,0,0,0,1407,1409,1,0,0,0,1408,1410,3,132,66,0,
		1409,1408,1,0,0,0,1409,1410,1,0,0,0,1410,1412,1,0,0,0,1411,1413,3,134,
		67,0,1412,1411,1,0,0,0,1412,1413,1,0,0,0,1413,93,1,0,0,0,1414,1415,3,178,
		89,0,1415,1416,5,2,0,0,1416,1418,1,0,0,0,1417,1414,1,0,0,0,1417,1418,1,
		0,0,0,1418,1419,1,0,0,0,1419,1424,3,180,90,0,1420,1422,5,33,0,0,1421,1420,
		1,0,0,0,1421,1422,1,0,0,0,1422,1423,1,0,0,0,1423,1425,3,202,101,0,1424,
		1421,1,0,0,0,1424,1425,1,0,0,0,1425,1431,1,0,0,0,1426,1427,5,85,0,0,1427,
		1428,5,40,0,0,1428,1432,3,190,95,0,1429,1430,5,102,0,0,1430,1432,5,85,
		0,0,1431,1426,1,0,0,0,1431,1429,1,0,0,0,1431,1432,1,0,0,0,1432,1479,1,
		0,0,0,1433,1434,3,178,89,0,1434,1435,5,2,0,0,1435,1437,1,0,0,0,1436,1433,
		1,0,0,0,1436,1437,1,0,0,0,1437,1438,1,0,0,0,1438,1439,3,218,109,0,1439,
		1440,5,3,0,0,1440,1445,3,64,32,0,1441,1442,5,5,0,0,1442,1444,3,64,32,0,
		1443,1441,1,0,0,0,1444,1447,1,0,0,0,1445,1443,1,0,0,0,1445,1446,1,0,0,
		0,1446,1448,1,0,0,0,1447,1445,1,0,0,0,1448,1453,5,4,0,0,1449,1451,5,33,
		0,0,1450,1449,1,0,0,0,1450,1451,1,0,0,0,1451,1452,1,0,0,0,1452,1454,3,
		202,101,0,1453,1450,1,0,0,0,1453,1454,1,0,0,0,1454,1479,1,0,0,0,1455,1465,
		5,3,0,0,1456,1461,3,94,47,0,1457,1458,5,5,0,0,1458,1460,3,94,47,0,1459,
		1457,1,0,0,0,1460,1463,1,0,0,0,1461,1459,1,0,0,0,1461,1462,1,0,0,0,1462,
		1466,1,0,0,0,1463,1461,1,0,0,0,1464,1466,3,84,42,0,1465,1456,1,0,0,0,1465,
		1464,1,0,0,0,1466,1467,1,0,0,0,1467,1468,5,4,0,0,1468,1479,1,0,0,0,1469,
		1470,5,3,0,0,1470,1471,3,82,41,0,1471,1476,5,4,0,0,1472,1474,5,33,0,0,
		1473,1472,1,0,0,0,1473,1474,1,0,0,0,1474,1475,1,0,0,0,1475,1477,3,202,
		101,0,1476,1473,1,0,0,0,1476,1477,1,0,0,0,1477,1479,1,0,0,0,1478,1417,
		1,0,0,0,1478,1436,1,0,0,0,1478,1455,1,0,0,0,1478,1469,1,0,0,0,1479,95,
		1,0,0,0,1480,1493,5,7,0,0,1481,1482,3,180,90,0,1482,1483,5,2,0,0,1483,
		1484,5,7,0,0,1484,1493,1,0,0,0,1485,1490,3,64,32,0,1486,1488,5,33,0,0,
		1487,1486,1,0,0,0,1487,1488,1,0,0,0,1488,1489,1,0,0,0,1489,1491,3,170,
		85,0,1490,1487,1,0,0,0,1490,1491,1,0,0,0,1491,1493,1,0,0,0,1492,1480,1,
		0,0,0,1492,1481,1,0,0,0,1492,1485,1,0,0,0,1493,97,1,0,0,0,1494,1508,5,
		5,0,0,1495,1497,5,100,0,0,1496,1495,1,0,0,0,1496,1497,1,0,0,0,1497,1504,
		1,0,0,0,1498,1500,5,96,0,0,1499,1501,5,110,0,0,1500,1499,1,0,0,0,1500,
		1501,1,0,0,0,1501,1505,1,0,0,0,1502,1505,5,87,0,0,1503,1505,5,51,0,0,1504,
		1498,1,0,0,0,1504,1502,1,0,0,0,1504,1503,1,0,0,0,1504,1505,1,0,0,0,1505,
		1506,1,0,0,0,1506,1508,5,94,0,0,1507,1494,1,0,0,0,1507,1496,1,0,0,0,1508,
		99,1,0,0,0,1509,1510,5,107,0,0,1510,1524,3,64,32,0,1511,1512,5,142,0,0,
		1512,1513,5,3,0,0,1513,1518,3,184,92,0,1514,1515,5,5,0,0,1515,1517,3,184,
		92,0,1516,1514,1,0,0,0,1517,1520,1,0,0,0,1518,1516,1,0,0,0,1518,1519,1,
		0,0,0,1519,1521,1,0,0,0,1520,1518,1,0,0,0,1521,1522,5,4,0,0,1522,1524,
		1,0,0,0,1523,1509,1,0,0,0,1523,1511,1,0,0,0,1524,101,1,0,0,0,1525,1527,
		5,139,0,0,1526,1528,5,29,0,0,1527,1526,1,0,0,0,1527,1528,1,0,0,0,1528,
		1532,1,0,0,0,1529,1532,5,90,0,0,1530,1532,5,68,0,0,1531,1525,1,0,0,0,1531,
		1529,1,0,0,0,1531,1530,1,0,0,0,1532,103,1,0,0,0,1533,1535,3,48,24,0,1534,
		1533,1,0,0,0,1534,1535,1,0,0,0,1535,1536,1,0,0,0,1536,1539,5,141,0,0,1537,
		1538,5,108,0,0,1538,1540,7,8,0,0,1539,1537,1,0,0,0,1539,1540,1,0,0,0,1540,
		1541,1,0,0,0,1541,1542,3,110,55,0,1542,1545,5,131,0,0,1543,1546,3,184,
		92,0,1544,1546,3,106,53,0,1545,1543,1,0,0,0,1545,1544,1,0,0,0,1546,1547,
		1,0,0,0,1547,1548,5,6,0,0,1548,1559,3,64,32,0,1549,1552,5,5,0,0,1550,1553,
		3,184,92,0,1551,1553,3,106,53,0,1552,1550,1,0,0,0,1552,1551,1,0,0,0,1553,
		1554,1,0,0,0,1554,1555,5,6,0,0,1555,1556,3,64,32,0,1556,1558,1,0,0,0,1557,
		1549,1,0,0,0,1558,1561,1,0,0,0,1559,1557,1,0,0,0,1559,1560,1,0,0,0,1560,
		1574,1,0,0,0,1561,1559,1,0,0,0,1562,1572,5,75,0,0,1563,1568,3,94,47,0,
		1564,1565,5,5,0,0,1565,1567,3,94,47,0,1566,1564,1,0,0,0,1567,1570,1,0,
		0,0,1568,1566,1,0,0,0,1568,1569,1,0,0,0,1569,1573,1,0,0,0,1570,1568,1,
		0,0,0,1571,1573,3,84,42,0,1572,1563,1,0,0,0,1572,1571,1,0,0,0,1573,1575,
		1,0,0,0,1574,1562,1,0,0,0,1574,1575,1,0,0,0,1575,1578,1,0,0,0,1576,1577,
		5,148,0,0,1577,1579,3,64,32,0,1578,1576,1,0,0,0,1578,1579,1,0,0,0,1579,
		1581,1,0,0,0,1580,1582,3,72,36,0,1581,1580,1,0,0,0,1581,1582,1,0,0,0,1582,
		105,1,0,0,0,1583,1584,5,3,0,0,1584,1589,3,184,92,0,1585,1586,5,5,0,0,1586,
		1588,3,184,92,0,1587,1585,1,0,0,0,1588,1591,1,0,0,0,1589,1587,1,0,0,0,
		1589,1590,1,0,0,0,1590,1592,1,0,0,0,1591,1589,1,0,0,0,1592,1593,5,4,0,
		0,1593,107,1,0,0,0,1594,1596,3,48,24,0,1595,1594,1,0,0,0,1595,1596,1,0,
		0,0,1596,1597,1,0,0,0,1597,1600,5,141,0,0,1598,1599,5,108,0,0,1599,1601,
		7,8,0,0,1600,1598,1,0,0,0,1600,1601,1,0,0,0,1601,1602,1,0,0,0,1602,1603,
		3,110,55,0,1603,1606,5,131,0,0,1604,1607,3,184,92,0,1605,1607,3,106,53,
		0,1606,1604,1,0,0,0,1606,1605,1,0,0,0,1607,1608,1,0,0,0,1608,1609,5,6,
		0,0,1609,1620,3,64,32,0,1610,1613,5,5,0,0,1611,1614,3,184,92,0,1612,1614,
		3,106,53,0,1613,1611,1,0,0,0,1613,1612,1,0,0,0,1614,1615,1,0,0,0,1615,
		1616,5,6,0,0,1616,1617,3,64,32,0,1617,1619,1,0,0,0,1618,1610,1,0,0,0,1619,
		1622,1,0,0,0,1620,1618,1,0,0,0,1620,1621,1,0,0,0,1621,1625,1,0,0,0,1622,
		1620,1,0,0,0,1623,1624,5,148,0,0,1624,1626,3,64,32,0,1625,1623,1,0,0,0,
		1625,1626,1,0,0,0,1626,1628,1,0,0,0,1627,1629,3,72,36,0,1628,1627,1,0,
		0,0,1628,1629,1,0,0,0,1629,1634,1,0,0,0,1630,1632,3,132,66,0,1631,1630,
		1,0,0,0,1631,1632,1,0,0,0,1632,1633,1,0,0,0,1633,1635,3,134,67,0,1634,
		1631,1,0,0,0,1634,1635,1,0,0,0,1635,109,1,0,0,0,1636,1637,3,178,89,0,1637,
		1638,5,2,0,0,1638,1640,1,0,0,0,1639,1636,1,0,0,0,1639,1640,1,0,0,0,1640,
		1641,1,0,0,0,1641,1644,3,180,90,0,1642,1643,5,33,0,0,1643,1645,3,208,104,
		0,1644,1642,1,0,0,0,1644,1645,1,0,0,0,1645,1651,1,0,0,0,1646,1647,5,85,
		0,0,1647,1648,5,40,0,0,1648,1652,3,190,95,0,1649,1650,5,102,0,0,1650,1652,
		5,85,0,0,1651,1646,1,0,0,0,1651,1649,1,0,0,0,1651,1652,1,0,0,0,1652,111,
		1,0,0,0,1653,1655,5,143,0,0,1654,1656,3,178,89,0,1655,1654,1,0,0,0,1655,
		1656,1,0,0,0,1656,1659,1,0,0,0,1657,1658,5,91,0,0,1658,1660,3,210,105,
		0,1659,1657,1,0,0,0,1659,1660,1,0,0,0,1660,113,1,0,0,0,1661,1662,5,178,
		0,0,1662,1663,5,3,0,0,1663,1664,5,148,0,0,1664,1665,3,64,32,0,1665,1666,
		5,4,0,0,1666,115,1,0,0,0,1667,1669,5,3,0,0,1668,1670,3,212,106,0,1669,
		1668,1,0,0,0,1669,1670,1,0,0,0,1670,1681,1,0,0,0,1671,1672,5,153,0,0,1672,
		1673,5,40,0,0,1673,1678,3,64,32,0,1674,1675,5,5,0,0,1675,1677,3,64,32,
		0,1676,1674,1,0,0,0,1677,1680,1,0,0,0,1678,1676,1,0,0,0,1678,1679,1,0,
		0,0,1679,1682,1,0,0,0,1680,1678,1,0,0,0,1681,1671,1,0,0,0,1681,1682,1,
		0,0,0,1682,1683,1,0,0,0,1683,1684,5,109,0,0,1684,1685,5,40,0,0,1685,1690,
		3,136,68,0,1686,1687,5,5,0,0,1687,1689,3,136,68,0,1688,1686,1,0,0,0,1689,
		1692,1,0,0,0,1690,1688,1,0,0,0,1690,1691,1,0,0,0,1691,1694,1,0,0,0,1692,
		1690,1,0,0,0,1693,1695,3,120,60,0,1694,1693,1,0,0,0,1694,1695,1,0,0,0,
		1695,1696,1,0,0,0,1696,1697,5,4,0,0,1697,117,1,0,0,0,1698,1732,5,152,0,
		0,1699,1733,3,206,103,0,1700,1702,5,3,0,0,1701,1703,3,212,106,0,1702,1701,
		1,0,0,0,1702,1703,1,0,0,0,1703,1714,1,0,0,0,1704,1705,5,153,0,0,1705,1706,
		5,40,0,0,1706,1711,3,64,32,0,1707,1708,5,5,0,0,1708,1710,3,64,32,0,1709,
		1707,1,0,0,0,1710,1713,1,0,0,0,1711,1709,1,0,0,0,1711,1712,1,0,0,0,1712,
		1715,1,0,0,0,1713,1711,1,0,0,0,1714,1704,1,0,0,0,1714,1715,1,0,0,0,1715,
		1726,1,0,0,0,1716,1717,5,109,0,0,1717,1718,5,40,0,0,1718,1723,3,136,68,
		0,1719,1720,5,5,0,0,1720,1722,3,136,68,0,1721,1719,1,0,0,0,1722,1725,1,
		0,0,0,1723,1721,1,0,0,0,1723,1724,1,0,0,0,1724,1727,1,0,0,0,1725,1723,
		1,0,0,0,1726,1716,1,0,0,0,1726,1727,1,0,0,0,1727,1729,1,0,0,0,1728,1730,
		3,120,60,0,1729,1728,1,0,0,0,1729,1730,1,0,0,0,1730,1731,1,0,0,0,1731,
		1733,5,4,0,0,1732,1699,1,0,0,0,1732,1700,1,0,0,0,1733,119,1,0,0,0,1734,
		1742,3,122,61,0,1735,1736,5,180,0,0,1736,1737,5,101,0,0,1737,1743,5,182,
		0,0,1738,1739,5,157,0,0,1739,1743,5,127,0,0,1740,1743,5,78,0,0,1741,1743,
		5,181,0,0,1742,1735,1,0,0,0,1742,1738,1,0,0,0,1742,1740,1,0,0,0,1742,1741,
		1,0,0,0,1742,1743,1,0,0,0,1743,121,1,0,0,0,1744,1751,7,17,0,0,1745,1752,
		3,144,72,0,1746,1747,5,39,0,0,1747,1748,3,140,70,0,1748,1749,5,32,0,0,
		1749,1750,3,142,71,0,1750,1752,1,0,0,0,1751,1745,1,0,0,0,1751,1746,1,0,
		0,0,1752,123,1,0,0,0,1753,1754,3,214,107,0,1754,1764,5,3,0,0,1755,1760,
		3,64,32,0,1756,1757,5,5,0,0,1757,1759,3,64,32,0,1758,1756,1,0,0,0,1759,
		1762,1,0,0,0,1760,1758,1,0,0,0,1760,1761,1,0,0,0,1761,1765,1,0,0,0,1762,
		1760,1,0,0,0,1763,1765,5,7,0,0,1764,1755,1,0,0,0,1764,1763,1,0,0,0,1765,
		1766,1,0,0,0,1766,1767,5,4,0,0,1767,125,1,0,0,0,1768,1769,3,216,108,0,
		1769,1782,5,3,0,0,1770,1772,5,62,0,0,1771,1770,1,0,0,0,1771,1772,1,0,0,
		0,1772,1773,1,0,0,0,1773,1778,3,64,32,0,1774,1775,5,5,0,0,1775,1777,3,
		64,32,0,1776,1774,1,0,0,0,1777,1780,1,0,0,0,1778,1776,1,0,0,0,1778,1779,
		1,0,0,0,1779,1783,1,0,0,0,1780,1778,1,0,0,0,1781,1783,5,7,0,0,1782,1771,
		1,0,0,0,1782,1781,1,0,0,0,1782,1783,1,0,0,0,1783,1784,1,0,0,0,1784,1786,
		5,4,0,0,1785,1787,3,114,57,0,1786,1785,1,0,0,0,1786,1787,1,0,0,0,1787,
		127,1,0,0,0,1788,1789,3,146,73,0,1789,1799,5,3,0,0,1790,1795,3,64,32,0,
		1791,1792,5,5,0,0,1792,1794,3,64,32,0,1793,1791,1,0,0,0,1794,1797,1,0,
		0,0,1795,1793,1,0,0,0,1795,1796,1,0,0,0,1796,1800,1,0,0,0,1797,1795,1,
		0,0,0,1798,1800,5,7,0,0,1799,1790,1,0,0,0,1799,1798,1,0,0,0,1799,1800,
		1,0,0,0,1800,1801,1,0,0,0,1801,1803,5,4,0,0,1802,1804,3,114,57,0,1803,
		1802,1,0,0,0,1803,1804,1,0,0,0,1804,1805,1,0,0,0,1805,1808,5,152,0,0,1806,
		1809,3,116,58,0,1807,1809,3,206,103,0,1808,1806,1,0,0,0,1808,1807,1,0,
		0,0,1809,129,1,0,0,0,1810,1812,5,149,0,0,1811,1813,5,116,0,0,1812,1811,
		1,0,0,0,1812,1813,1,0,0,0,1813,1814,1,0,0,0,1814,1819,3,54,27,0,1815,1816,
		5,5,0,0,1816,1818,3,54,27,0,1817,1815,1,0,0,0,1818,1821,1,0,0,0,1819,1817,
		1,0,0,0,1819,1820,1,0,0,0,1820,131,1,0,0,0,1821,1819,1,0,0,0,1822,1823,
		5,109,0,0,1823,1824,5,40,0,0,1824,1829,3,136,68,0,1825,1826,5,5,0,0,1826,
		1828,3,136,68,0,1827,1825,1,0,0,0,1828,1831,1,0,0,0,1829,1827,1,0,0,0,
		1829,1830,1,0,0,0,1830,133,1,0,0,0,1831,1829,1,0,0,0,1832,1833,5,98,0,
		0,1833,1836,3,64,32,0,1834,1835,7,18,0,0,1835,1837,3,64,32,0,1836,1834,
		1,0,0,0,1836,1837,1,0,0,0,1837,135,1,0,0,0,1838,1841,3,64,32,0,1839,1840,
		5,45,0,0,1840,1842,3,186,93,0,1841,1839,1,0,0,0,1841,1842,1,0,0,0,1842,
		1844,1,0,0,0,1843,1845,3,138,69,0,1844,1843,1,0,0,0,1844,1845,1,0,0,0,
		1845,1848,1,0,0,0,1846,1847,5,175,0,0,1847,1849,7,19,0,0,1848,1846,1,0,
		0,0,1848,1849,1,0,0,0,1849,137,1,0,0,0,1850,1851,7,20,0,0,1851,139,1,0,
		0,0,1852,1853,3,64,32,0,1853,1854,5,155,0,0,1854,1863,1,0,0,0,1855,1856,
		3,64,32,0,1856,1857,5,158,0,0,1857,1863,1,0,0,0,1858,1859,5,157,0,0,1859,
		1863,5,127,0,0,1860,1861,5,156,0,0,1861,1863,5,155,0,0,1862,1852,1,0,0,
		0,1862,1855,1,0,0,0,1862,1858,1,0,0,0,1862,1860,1,0,0,0,1863,141,1,0,0,
		0,1864,1865,3,64,32,0,1865,1866,5,155,0,0,1866,1875,1,0,0,0,1867,1868,
		3,64,32,0,1868,1869,5,158,0,0,1869,1875,1,0,0,0,1870,1871,5,157,0,0,1871,
		1875,5,127,0,0,1872,1873,5,156,0,0,1873,1875,5,158,0,0,1874,1864,1,0,0,
		0,1874,1867,1,0,0,0,1874,1870,1,0,0,0,1874,1872,1,0,0,0,1875,143,1,0,0,
		0,1876,1877,3,64,32,0,1877,1878,5,155,0,0,1878,1884,1,0,0,0,1879,1880,
		5,156,0,0,1880,1884,5,155,0,0,1881,1882,5,157,0,0,1882,1884,5,127,0,0,
		1883,1876,1,0,0,0,1883,1879,1,0,0,0,1883,1881,1,0,0,0,1884,145,1,0,0,0,
		1885,1886,7,21,0,0,1886,1887,5,3,0,0,1887,1888,3,64,32,0,1888,1889,5,4,
		0,0,1889,1890,5,152,0,0,1890,1892,5,3,0,0,1891,1893,3,152,76,0,1892,1891,
		1,0,0,0,1892,1893,1,0,0,0,1893,1894,1,0,0,0,1894,1896,3,156,78,0,1895,
		1897,3,122,61,0,1896,1895,1,0,0,0,1896,1897,1,0,0,0,1897,1898,1,0,0,0,
		1898,1899,5,4,0,0,1899,1971,1,0,0,0,1900,1901,7,22,0,0,1901,1902,5,3,0,
		0,1902,1903,5,4,0,0,1903,1904,5,152,0,0,1904,1906,5,3,0,0,1905,1907,3,
		152,76,0,1906,1905,1,0,0,0,1906,1907,1,0,0,0,1907,1909,1,0,0,0,1908,1910,
		3,154,77,0,1909,1908,1,0,0,0,1909,1910,1,0,0,0,1910,1911,1,0,0,0,1911,
		1971,5,4,0,0,1912,1913,7,23,0,0,1913,1914,5,3,0,0,1914,1915,5,4,0,0,1915,
		1916,5,152,0,0,1916,1918,5,3,0,0,1917,1919,3,152,76,0,1918,1917,1,0,0,
		0,1918,1919,1,0,0,0,1919,1920,1,0,0,0,1920,1921,3,156,78,0,1921,1922,5,
		4,0,0,1922,1971,1,0,0,0,1923,1924,7,24,0,0,1924,1925,5,3,0,0,1925,1927,
		3,64,32,0,1926,1928,3,148,74,0,1927,1926,1,0,0,0,1927,1928,1,0,0,0,1928,
		1930,1,0,0,0,1929,1931,3,150,75,0,1930,1929,1,0,0,0,1930,1931,1,0,0,0,
		1931,1932,1,0,0,0,1932,1933,5,4,0,0,1933,1934,5,152,0,0,1934,1936,5,3,
		0,0,1935,1937,3,152,76,0,1936,1935,1,0,0,0,1936,1937,1,0,0,0,1937,1938,
		1,0,0,0,1938,1939,3,156,78,0,1939,1940,5,4,0,0,1940,1971,1,0,0,0,1941,
		1942,5,164,0,0,1942,1943,5,3,0,0,1943,1944,3,64,32,0,1944,1945,5,5,0,0,
		1945,1946,3,34,17,0,1946,1947,5,4,0,0,1947,1948,5,152,0,0,1948,1950,5,
		3,0,0,1949,1951,3,152,76,0,1950,1949,1,0,0,0,1950,1951,1,0,0,0,1951,1952,
		1,0,0,0,1952,1954,3,156,78,0,1953,1955,3,122,61,0,1954,1953,1,0,0,0,1954,
		1955,1,0,0,0,1955,1956,1,0,0,0,1956,1957,5,4,0,0,1957,1971,1,0,0,0,1958,
		1959,5,165,0,0,1959,1960,5,3,0,0,1960,1961,3,64,32,0,1961,1962,5,4,0,0,
		1962,1963,5,152,0,0,1963,1965,5,3,0,0,1964,1966,3,152,76,0,1965,1964,1,
		0,0,0,1965,1966,1,0,0,0,1966,1967,1,0,0,0,1967,1968,3,156,78,0,1968,1969,
		5,4,0,0,1969,1971,1,0,0,0,1970,1885,1,0,0,0,1970,1900,1,0,0,0,1970,1912,
		1,0,0,0,1970,1923,1,0,0,0,1970,1941,1,0,0,0,1970,1958,1,0,0,0,1971,147,
		1,0,0,0,1972,1973,5,5,0,0,1973,1974,3,34,17,0,1974,149,1,0,0,0,1975,1976,
		5,5,0,0,1976,1977,3,34,17,0,1977,151,1,0,0,0,1978,1979,5,153,0,0,1979,
		1981,5,40,0,0,1980,1982,3,64,32,0,1981,1980,1,0,0,0,1982,1983,1,0,0,0,
		1983,1981,1,0,0,0,1983,1984,1,0,0,0,1984,153,1,0,0,0,1985,1986,5,109,0,
		0,1986,1988,5,40,0,0,1987,1989,3,64,32,0,1988,1987,1,0,0,0,1989,1990,1,
		0,0,0,1990,1988,1,0,0,0,1990,1991,1,0,0,0,1991,155,1,0,0,0,1992,1993,5,
		109,0,0,1993,1994,5,40,0,0,1994,1995,3,158,79,0,1995,157,1,0,0,0,1996,
		1998,3,64,32,0,1997,1999,3,138,69,0,1998,1997,1,0,0,0,1998,1999,1,0,0,
		0,1999,2007,1,0,0,0,2000,2001,5,5,0,0,2001,2003,3,64,32,0,2002,2004,3,
		138,69,0,2003,2002,1,0,0,0,2003,2004,1,0,0,0,2004,2006,1,0,0,0,2005,2000,
		1,0,0,0,2006,2009,1,0,0,0,2007,2005,1,0,0,0,2007,2008,1,0,0,0,2008,159,
		1,0,0,0,2009,2007,1,0,0,0,2010,2011,3,82,41,0,2011,161,1,0,0,0,2012,2013,
		3,82,41,0,2013,163,1,0,0,0,2014,2015,7,25,0,0,2015,165,1,0,0,0,2016,2017,
		5,188,0,0,2017,167,1,0,0,0,2018,2021,3,64,32,0,2019,2021,3,28,14,0,2020,
		2018,1,0,0,0,2020,2019,1,0,0,0,2021,169,1,0,0,0,2022,2023,7,26,0,0,2023,
		171,1,0,0,0,2024,2025,7,27,0,0,2025,173,1,0,0,0,2026,2027,3,220,110,0,
		2027,175,1,0,0,0,2028,2029,3,220,110,0,2029,177,1,0,0,0,2030,2031,3,220,
		110,0,2031,179,1,0,0,0,2032,2033,3,220,110,0,2033,181,1,0,0,0,2034,2035,
		3,220,110,0,2035,183,1,0,0,0,2036,2037,3,220,110,0,2037,185,1,0,0,0,2038,
		2039,3,220,110,0,2039,187,1,0,0,0,2040,2041,3,220,110,0,2041,189,1,0,0,
		0,2042,2043,3,220,110,0,2043,191,1,0,0,0,2044,2045,3,220,110,0,2045,193,
		1,0,0,0,2046,2047,3,220,110,0,2047,195,1,0,0,0,2048,2049,3,220,110,0,2049,
		197,1,0,0,0,2050,2051,3,220,110,0,2051,199,1,0,0,0,2052,2053,3,220,110,
		0,2053,201,1,0,0,0,2054,2055,3,220,110,0,2055,203,1,0,0,0,2056,2057,3,
		220,110,0,2057,205,1,0,0,0,2058,2059,3,220,110,0,2059,207,1,0,0,0,2060,
		2061,3,220,110,0,2061,209,1,0,0,0,2062,2063,3,220,110,0,2063,211,1,0,0,
		0,2064,2065,3,220,110,0,2065,213,1,0,0,0,2066,2067,3,220,110,0,2067,215,
		1,0,0,0,2068,2069,3,220,110,0,2069,217,1,0,0,0,2070,2071,3,220,110,0,2071,
		219,1,0,0,0,2072,2080,5,185,0,0,2073,2080,3,172,86,0,2074,2080,5,188,0,
		0,2075,2076,5,3,0,0,2076,2077,3,220,110,0,2077,2078,5,4,0,0,2078,2080,
		1,0,0,0,2079,2072,1,0,0,0,2079,2073,1,0,0,0,2079,2074,1,0,0,0,2079,2075,
		1,0,0,0,2080,221,1,0,0,0,298,225,233,240,245,251,257,259,285,292,299,305,
		309,314,317,324,327,331,339,343,345,349,353,357,360,367,373,379,384,395,
		401,405,409,412,416,422,427,436,443,449,453,457,462,468,480,484,489,492,
		495,500,503,517,524,531,533,536,542,547,555,560,575,581,591,596,606,610,
		612,616,621,623,631,637,642,649,660,663,665,672,676,683,689,695,701,706,
		715,720,731,736,747,752,756,772,782,787,795,807,812,820,827,830,833,840,
		843,846,849,853,861,866,876,881,890,897,901,905,908,916,929,932,940,949,
		953,958,988,1000,1005,1017,1023,1030,1034,1044,1047,1053,1059,1068,1071,
		1075,1077,1079,1088,1095,1102,1108,1113,1121,1126,1135,1146,1153,1157,
		1160,1164,1167,1175,1186,1192,1194,1202,1209,1216,1221,1223,1229,1238,
		1243,1250,1254,1256,1259,1267,1271,1274,1280,1284,1289,1296,1305,1309,
		1311,1315,1324,1329,1331,1344,1347,1356,1367,1374,1377,1382,1386,1389,
		1392,1397,1401,1406,1409,1412,1417,1421,1424,1431,1436,1445,1450,1453,
		1461,1465,1473,1476,1478,1487,1490,1492,1496,1500,1504,1507,1518,1523,
		1527,1531,1534,1539,1545,1552,1559,1568,1572,1574,1578,1581,1589,1595,
		1600,1606,1613,1620,1625,1628,1631,1634,1639,1644,1651,1655,1659,1669,
		1678,1681,1690,1694,1702,1711,1714,1723,1726,1729,1732,1742,1751,1760,
		1764,1771,1778,1782,1786,1795,1799,1803,1808,1812,1819,1829,1836,1841,
		1844,1848,1862,1874,1883,1892,1896,1906,1909,1918,1927,1930,1936,1950,
		1954,1965,1970,1983,1990,1998,2003,2007,2020,2079
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
