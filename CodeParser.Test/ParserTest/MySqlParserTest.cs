using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.IO;
using static CodeParser.MySqlParser;

namespace CodeParser.Test
{
    public class MySqlParserTest : CodeParserTest
    {
        public override string Language => "MySql";
        public override string FileExtension => ".sql";
        public override string SubFolder => "MySql";

        public override void Parse(FileInfo file)
        {
            Lexer lexer = new MySqlLexer(CharStreams.fromPath(file.FullName));

            CommonTokenStream tokens = new CommonTokenStream(lexer);

            MySqlParser parser = new MySqlParser(tokens);

            ParserRuleContext context = parser.root();

            var children = context.children;

            foreach (IParseTree child in children)
            {
                this.ParseNode(child);
            }
        }

        public void ParseNode(IParseTree node)
        {
            if (node is SqlStatementsContext)
            {
                SqlStatementsContext context = node as SqlStatementsContext;
                SqlStatementContext[] statements = context.sqlStatement();

                foreach (SqlStatementContext statement in statements)
                {
                    foreach (var child in statement.children)
                    {
                        if (child is DdlStatementContext ddl)
                        {
                            CreateFunctionContext func = ddl.createFunction();

                            if (func != null)
                            {
                                this.ParseFunction(func);
                            }
                        }
                    }
                }
            }
        }

        private void ParseFunction(CreateFunctionContext node)
        {
            FullIdContext id = node.fullId();
            UidContext[] uids = id.uid();

            List<string> names = new List<string>();
            foreach (UidContext uid in uids)
            {
                string name = uid.simpleId().GetText();
                names.Add(name);
            }

            this.WriteKeyValue("Function", string.Join(".", names));

            this.WriteBeginBrace();

            string dataType = node.dataType().GetText();

            this.WriteKeyValue("dataType", dataType);

            FunctionParameterContext[] parameters = node.functionParameter();

            foreach (FunctionParameterContext parameter in parameters)
            {
                string name = parameter.uid().GetText();
                string paraDataType = parameter.dataType().GetText();

                this.WriteKeyValue("parameter", $"{name} {paraDataType}");
            }

            RoutineBodyContext body = node.routineBody();

            this.WriteLine("body");

            this.WriteBeginBrace(2);

            this.indent = 4;

            BlockStatementContext block = body.blockStatement();

            foreach (IParseTree blockChild in block.children)
            {
                if (blockChild is ProcedureSqlStatementContext procedure)
                {
                    SqlStatementContext sqlStatement = procedure.sqlStatement();
                    CompoundStatementContext compoundStatement = procedure.compoundStatement();

                    if (sqlStatement != null)
                    {
                        this.ParserSqlStatement(sqlStatement);
                    }
                    else if (compoundStatement != null)
                    {
                        this.ParseCompoundStatement(compoundStatement);
                    }
                }
                else
                {
                    string text = blockChild.GetText();

                    this.WriteLine(text, indent);
                }
            }

            this.WriteEndBrace(2);

            this.WriteEndBrace();
        }

        private void ParserSqlStatement(SqlStatementContext node)
        {
            foreach (var child in node.children)
            {
                if (child is AdministrationStatementContext admin)
                {
                    foreach (var adminChild in admin.children)
                    {
                        if (adminChild is SetStatementContext setStatement)
                        {
                            this.ParseSetStatement(setStatement);
                        }
                    }
                }
            }
        }

        private void ParseSetStatement(SetStatementContext node)
        {
            foreach (var child in node.children)
            {
                if (child is VariableClauseContext variable)
                {
                    string text = variable.GetText();

                    this.Write(text);
                }
                else if (child is PredicateExpressionContext exp)
                {
                    string text = exp.GetText();

                    ExpressionAtomPredicateContext atom = exp.GetRuleContext<ExpressionAtomPredicateContext>(0);

                    if (atom != null)
                    {
                        ConstantExpressionAtomContext constant = atom.GetRuleContext<ConstantExpressionAtomContext>(0);

                        string value = constant.GetText();

                        this.Write(value);
                    }
                }
                else
                {
                    string text = child.GetText();
                    this.Write(text, indent);
                }
            }

            this.WriteLine();
        }

        private void ParseCompoundStatement(CompoundStatementContext node)
        {
            foreach (var child in node.children)
            {
                if (child is WhileStatementContext whileStatement)
                {

                }
                else
                {
                    this.WriteLine(child.GetText(), indent);
                }
            }
        }
    }
}
