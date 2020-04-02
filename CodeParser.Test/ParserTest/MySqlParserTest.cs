using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.IO;
using static MySqlParser;

namespace CodeParser.Test
{
    public class MySqlParserTest : CodeParserTest
    {
        public override string Language => "MySql";       
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
            if (node is SqlStatementsContext context)
            {              
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
                    this.ParseProcedureStatement(procedure);
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

        private void ParseProcedureStatement(ProcedureSqlStatementContext node)
        {
            foreach(var child in node.children)
            {
                if (child is SqlStatementContext sqlStatement)
                {
                    this.ParseSqlStatement(sqlStatement);
                }
                else if(child is CompoundStatementContext compoundStatement)
                {
                    this.ParseCompoundStatement(compoundStatement);
                }
                else if(child is TerminalNodeImpl terminalNode)
                {
                    this.Write(terminalNode.GetText());
                }                
            }

            this.WriteLine();
        }

        private void ParseSqlStatement(SqlStatementContext node)
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

                    this.Write(text, 1);
                }
                else if (child is PredicateExpressionContext exp)
                {
                    this.ParsePredicateExpression(exp);
                }
                else if(child is TerminalNodeImpl terminalNode)
                {
                    string text = child.GetText();

                    this.Write(text, terminalNode.Symbol.Type == MySqlParser.SET ? this.indent: 0);
                }
            }            
        }

        private void ParsePredicateExpression(PredicateExpressionContext node)
        {
            foreach(var child in node.children)
            {
                if(child is ExpressionAtomPredicateContext atom)
                {
                    this.ParseExpressionAtom(atom);
                }
                else if(child is BinaryComparasionPredicateContext binary)
                {
                    foreach(var binaryChild in binary.children)
                    {
                        if(binaryChild is ExpressionAtomPredicateContext expAtom)
                        {
                            this.ParseExpressionAtom(expAtom);
                        }
                        else if(binaryChild is ComparisonOperatorContext comparison)
                        {
                            foreach(var comparionChild in comparison.children)
                            {
                                if(comparionChild is TerminalNodeImpl terminalNode)
                                {
                                    this.Write(terminalNode.GetText());
                                }
                            }
                        }
                    }
                }                
            }           
        }

        private void ParseMathExpression(MathExpressionAtomContext node)
        {
            foreach(var child in node.children)
            {
                if(child is MysqlVariableExpressionAtomContext variableExp)
                {
                    string text = variableExp.GetText();

                    this.Write(text, 1);
                }
                else if(child is MathOperatorContext @operator)
                {
                    string text = @operator.GetText();

                    this.Write(text);
                }
                else if(child is ConstantExpressionAtomContext constant)
                {
                    this.ParseConstExpression(constant);
                }
            }
        }

        private void ParseConstExpression(ConstantExpressionAtomContext node)
        {
            string text = node.GetText();

            this.Write(text);
        }

        private void ParseExpressionAtom(ExpressionAtomPredicateContext node)
        {
            foreach(var child in node.children)
            {
                if(child is ConstantExpressionAtomContext constantExp)
                {
                    this.ParseConstExpression(constantExp);
                }
                else if(child is MysqlVariableExpressionAtomContext variableExp)
                {
                    string text = variableExp.GetText();

                    this.Write(text, 1);
                }
                else if(child is FullColumnNameExpressionAtomContext columnNameExp)
                {
                    string text = columnNameExp.GetText();

                    this.Write(text, 1);
                }
                else if (child is MathExpressionAtomContext mathExp)
                {
                    this.ParseMathExpression(mathExp);
                }
            }           
        }

        private void ParseCompoundStatement(CompoundStatementContext node)
        {
            foreach (var child in node.children)
            {
                if (child is WhileStatementContext whileStatement)
                {                   
                    foreach(var whileChild in whileStatement.children)
                    {
                        if(whileChild is TerminalNodeImpl terminalNode)
                        {
                            string text = terminalNode.GetText();

                            if(terminalNode.Symbol.Type == MySqlParser.DO)
                            {
                                text += Environment.NewLine;
                            }

                            this.Write(text, indent);
                        }
                        else if(whileChild is ProcedureSqlStatementContext procedure)
                        {
                            this.ParseProcedureStatement(procedure);
                        }
                        else if(whileChild is PredicateExpressionContext exp)
                        {
                            this.ParsePredicateExpression(exp);
                        }
                    }
                }
                else if(child is ReturnStatementContext returnStatement)
                {
                    this.ParseReturnStatement(returnStatement);
                }
                else if(child is TerminalNodeImpl terminalNode)
                {
                    this.WriteLine(terminalNode.GetText());
                }
            }
        }

        private void ParseReturnStatement(ReturnStatementContext node)
        {
            foreach(var child in node.children)
            {
                if(child is PredicateExpressionContext predicate)
                {
                    this.ParsePredicateExpression(predicate);
                }
                else if(child is TerminalNodeImpl terminalNode)
                {
                    string text = terminalNode.GetText();

                    this.Write(text, terminalNode.Symbol.Type == MySqlParser.RETURN ? this.indent: 0);
                }
            }
        }
    }
}
