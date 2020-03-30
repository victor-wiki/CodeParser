using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.IO;
using System.Linq;
using static CodeParser.JavaScriptParser;

namespace CodeParser.Test
{
    public class JavaScriptParserTest : CodeParserTest
    {
        public override string Language => "JavaScript";       

        public override void Parse(FileInfo file)
        {
            Lexer lexer = new JavaScriptLexer(CharStreams.fromPath(file.FullName));

            CommonTokenStream tokens = new CommonTokenStream(lexer);

            JavaScriptParser parser = new JavaScriptParser(tokens);

            ParserRuleContext context = parser.program();

            var children = context.children;

            foreach (IParseTree child in children)
            {
                this.ParseNode(child);
            }
        }

        private void ParseNode(IParseTree node)
        {            
            if (node is SourceElementsContext)
            {
                SourceElementsContext elementsContext = node as SourceElementsContext;
                SourceElementContext[] srcElements = elementsContext.sourceElement();
                foreach (SourceElementContext srcElement in srcElements)
                {
                    StatementContext statementContext = srcElement.statement();
                    VariableStatementContext varStatementContext = statementContext.variableStatement();
                    FunctionDeclarationContext functionContext = statementContext.functionDeclaration();
                    ImportStatementContext importContext = statementContext.importStatement();
                    ExportStatementContext exportContext = statementContext.exportStatement();

                    if (varStatementContext != null)
                    {
                        VariableDeclarationListContext variableListContex = varStatementContext.variableDeclarationList();

                        if (variableListContex != null)
                        {
                            var variables = variableListContex.children;

                            foreach (var variable in variables)
                            {
                                if (variable is VariableDeclarationContext)
                                {
                                    VariableDeclarationContext declarationContext = variable as VariableDeclarationContext;
                                    string name = declarationContext.assignable().GetText();

                                    ObjectLiteralExpressionContext[] exps = declarationContext.GetRuleContexts<ObjectLiteralExpressionContext>();

                                    if (exps == null || exps.Length == 0)
                                    {
                                        this.WriteKeyValue("Field", name);
                                    }
                                    else
                                    {
                                        this.WriteKeyValue("Class", name);
                                        this.WriteBeginBrace();

                                        foreach (ObjectLiteralExpressionContext exp in exps)
                                        {
                                            ObjectLiteralContext literalContext = exp.objectLiteral();
                                            PropertyAssignmentContext[] properties = literalContext.propertyAssignment();

                                            foreach (PropertyAssignmentContext property in properties)
                                            {
                                                PropertyNameContext propertyNameContext = property.GetRuleContext<PropertyNameContext>(0);
                                                FunctionExpressionContext funcExpContext = property.GetRuleContext<FunctionExpressionContext>(0);

                                                bool isFunction = funcExpContext != null;

                                                string propertyName = propertyNameContext.identifierName().GetText();

                                                this.WriteKeyValue(isFunction ? "Function" : "Property", propertyName);
                                            }
                                        }

                                        this.WriteEndBrace();
                                    }
                                }
                            }
                        }
                    }
                    else if (functionContext != null)
                    {
                        string name = functionContext.Identifier().GetText();
                        this.WriteKeyValue("Function", name);
                    }
                    else if (importContext != null)
                    {
                        ImportFromBlockContext fromContext = importContext.importFromBlock();
                        ModuleItemsContext[] moduleItems = fromContext.GetRuleContexts<ModuleItemsContext>();
                        foreach (ModuleItemsContext module in moduleItems)
                        {
                            AliasNameContext[] aliasNames = module.aliasName();
                            foreach (AliasNameContext aliasName in aliasNames)
                            {
                                string name = aliasName.identifierName().LastOrDefault().GetText();
                                this.WriteKeyValue("Import", name);
                            }
                        }
                    }
                    else if (exportContext != null)
                    {
                        DeclarationContext[] declarations = exportContext.GetRuleContexts<DeclarationContext>();
                        ExportFromBlockContext[] exportBlocks = exportContext.GetRuleContexts<ExportFromBlockContext>();

                        foreach (DeclarationContext declaration in declarations)
                        {
                            FunctionDeclarationContext funcContext = declaration.functionDeclaration();

                            if (funcContext != null)
                            {
                                string name = funcContext.Identifier().GetText();

                                this.WriteKeyValue("Export", name);
                            }
                        }

                        foreach (ExportFromBlockContext exportBlock in exportBlocks)
                        {
                            ModuleItemsContext[] moduleItems = exportBlock.GetRuleContexts<ModuleItemsContext>();
                            foreach (ModuleItemsContext module in moduleItems)
                            {
                                AliasNameContext[] aliasNames = module.aliasName();
                                foreach (AliasNameContext aliasName in aliasNames)
                                {
                                    IdentifierNameContext[] identifierNames = aliasName.identifierName();
                                    string name = identifierNames.LastOrDefault().Identifier().GetText();
                                    this.WriteKeyValue("Export", name);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
