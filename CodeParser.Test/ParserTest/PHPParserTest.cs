using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.IO;
using static CodeParser.PhpParser;

namespace CodeParser.Test
{
    public class PhpParserTest : CodeParserTest
    {
        public override string Language => "PHP";
        public override string FileExtension => ".php";

        public override void Parse(FileInfo file)
        {
            Lexer lexer = new PhpLexer(CharStreams.fromPath(file.FullName));

            CommonTokenStream tokens = new CommonTokenStream(lexer);

            PhpParser parser = new PhpParser(tokens);

            ParserRuleContext context = parser.htmlDocument();

            var children = context.children;

            foreach (IParseTree child in children)
            {
                this.ParseNode(child);
            }
        }

        private void ParseNode(IParseTree node)
        {
            if (node is HtmlElementOrPhpBlockContext)
            {
                HtmlElementOrPhpBlockContext block = node as HtmlElementOrPhpBlockContext;

                PhpBlockContext phpBlock = block.phpBlock();

                foreach (TopStatementContext topStatement in phpBlock.topStatement())
                {
                    StatementContext statement = topStatement.statement();
                    ClassDeclarationContext classDeclaration = topStatement.classDeclaration();
                    FunctionDeclarationContext function = topStatement.functionDeclaration();

                    if (statement != null)
                    {
                        ExpressionStatementContext expression = statement.expressionStatement();

                        if (expression != null)
                        {
                            AssignmentExpressionContext[] assignments = expression.GetRuleContexts<AssignmentExpressionContext>();
                            ScalarExpressionContext[] scalarExpressions = expression.GetRuleContexts<ScalarExpressionContext>();

                            foreach (AssignmentExpressionContext assignment in assignments)
                            {
                                string name = assignment.assignable().GetText();
                                this.WriteKeyValue("Field", name);
                            }

                            foreach (ScalarExpressionContext scalarExpression in scalarExpressions)
                            {
                                string nsName = scalarExpression?.constant()?.qualifiedNamespaceName()?.namespaceNameList()?.GetText();

                                if (!string.IsNullOrEmpty(nsName))
                                {
                                    this.WriteKeyValue("Namespace", nsName);
                                }
                            }
                        }
                    }
                    else if (classDeclaration != null)
                    {
                        string className = classDeclaration.identifier().GetText();

                        this.WriteKeyValue("Class", className);
                        this.WriteLeftBrace();

                        ClassStatementContext[] classStatements = classDeclaration.GetRuleContexts<ClassStatementContext>();

                        foreach (ClassStatementContext classStatement in classStatements)
                        {
                            VariableInitializerContext[] variables = classStatement.variableInitializer();
                            bool isField = variables.Length > 0;

                            foreach (VariableInitializerContext variable in variables)
                            {
                                string name = variable.GetText();
                                this.WriteKeyValue("Field", name);
                            }

                            if (!isField)
                            {
                                IdentifierContext[] identifiers = classStatement.GetRuleContexts<IdentifierContext>();
                             
                                foreach (IdentifierContext identifier in identifiers)
                                {
                                    string name = identifier.GetText();
                                    this.WriteKeyValue("Method", name);
                                }
                            }
                        }

                        this.WriteRightBrace();
                    }
                    else if (function != null)
                    {
                        string name = function.identifier().GetText();

                        this.WriteKeyValue("Function", name);
                    }
                }
            }
        }
    }
}
