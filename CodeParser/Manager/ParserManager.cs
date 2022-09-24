using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeParser
{
    public class ParserManager
    {
        public static List<ParserInfo> ParserInfos
        {
            get
            {
                return new List<ParserInfo>()
                {
                    new ParserInfo() { ParserName = nameof(CParser), Language= "C", FileExtension = ".c", EntryRuleName =nameof(CParser.compilationUnit) },
                    new ParserInfo() { ParserName = nameof(CPP14Parser), Language= "C++", FileExtension = ".cpp", EntryRuleName =nameof(CPP14Parser.translationunit) },
                    new ParserInfo() { ParserName = nameof(CSharpParser), Language= "C#", FileExtension = ".cs", EntryRuleName =nameof(CSharpParser.compilation_unit) },
                    new ParserInfo() { ParserName = nameof(Java8Parser), Language= "Java8", FileExtension = ".java", EntryRuleName =nameof(Java8Parser.compilationUnit) },
                    new ParserInfo() { ParserName = nameof(Java9Parser), Language= "Java9", FileExtension = ".java", EntryRuleName =nameof(Java9Parser.compilationUnit) },
                    new ParserInfo() { ParserName = nameof(JavaScriptParser), Language= "JavaScript", FileExtension = ".js", EntryRuleName =nameof(JavaScriptParser.program) },
                    new ParserInfo() { ParserName = nameof(Python3Parser), Language= "Python3", FileExtension = ".py", EntryRuleName =nameof(Python3Parser.file_input)},
                    new ParserInfo() { ParserName = nameof(PhpParser), Language= "Php", FileExtension = ".php", EntryRuleName =nameof(PhpParser.htmlDocument) },
                    new ParserInfo() { ParserName = nameof(TSqlParser), Language= "TSql", FileExtension = ".sql", EntryRuleName =nameof(TSqlParser.tsql_file) },
                    new ParserInfo() { ParserName = nameof(MySqlParser), Language= "MySql", FileExtension = ".sql", EntryRuleName =nameof(MySqlParser.query) },
                    new ParserInfo() { ParserName = nameof(PlSqlParser), Language= "PlSql", FileExtension = ".sql", EntryRuleName =nameof(PlSqlParser.sql_script) },
                    new ParserInfo() { ParserName = nameof(PostgreSqlParser), Language= "PostgreSql", FileExtension = ".sql", EntryRuleName =nameof(PostgreSqlParser.root) },
                    new ParserInfo() { ParserName = nameof(SQLiteParser), Language= "SQLite", FileExtension = ".sql", EntryRuleName =nameof(SQLiteParser.parse) }
                };
            }
        }

        public static ParserInfo GetParserInfoByName(string name)
        {
            return ParserInfos.FirstOrDefault(item => item.ParserName == name);
        }

        public static ParserInfo GetParserInfoByLanguage(string language)
        {
            return ParserInfos.FirstOrDefault(item => item.Language == language);
        }
    }
}
