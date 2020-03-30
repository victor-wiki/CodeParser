using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.IO;
using System.Linq;
using static CodeParser.PythonParser;

namespace CodeParser.Test
{
    public class PythonParserTest : CodeParserTest
    {
        public override string Language => "Python";      

        public override void Parse(FileInfo file)
        {
            Lexer lexer = new PythonLexer(CharStreams.fromPath(file.FullName));

            CommonTokenStream tokens = new CommonTokenStream(lexer);

            PythonParser parser = new PythonParser(tokens);

            ParserRuleContext context = parser.file_input();

            var children = context.children;

            foreach (IParseTree child in children)
            {
                this.ParseNode(child);
            }
        }

        private void ParseNode(IParseTree node)
        {
            if (node is StmtContext stmtContext)
            {               
                Compound_stmtContext compound_Stmt = stmtContext.compound_stmt();

                if (compound_Stmt != null)
                {
                    ClassdefContext[] classdefs = compound_Stmt.GetRuleContexts<ClassdefContext>();

                    foreach (ClassdefContext classdef in classdefs)
                    {
                        string name = classdef.name().GetText();

                        this.WriteLine();
                        this.WriteKeyValue("Class", name);

                        this.WriteBeginBrace();

                        this.ParseClassContext(classdef);

                        this.WriteEndBrace();
                    }
                }
            }
        }

        private void ParseClassContext(ClassdefContext node)
        {
            var suits = node.GetRuleContexts<SuiteContext>();

            foreach (SuiteContext suit in suits)
            {
                var stmts = suit.stmt();

                foreach (StmtContext stmt in stmts)
                {
                    Simple_stmtContext simple_Stmt = stmt.simple_stmt();
                    Compound_stmtContext compound_Stmt = stmt.compound_stmt();

                    if (compound_Stmt != null)
                    {
                        var funcs = compound_Stmt.GetRuleContexts<FuncdefContext>();

                        foreach (FuncdefContext func in funcs)
                        {
                            string name = func.name().GetText();

                            this.WriteKeyValue("Method", name);
                        }
                    }
                    else if (simple_Stmt != null)
                    {
                        var exprs = simple_Stmt.GetRuleContexts<Expr_stmtContext>();

                        foreach (var expr in exprs)
                        {
                            Testlist_star_exprContext[] ss = expr.GetRuleContexts<Testlist_star_exprContext>();

                            string name = ss.FirstOrDefault()?.GetText();

                            if (!string.IsNullOrEmpty(name))
                            {
                                this.WriteKeyValue("Field", name);
                            }
                        }
                    }
                }
            }
        }
    }
}
