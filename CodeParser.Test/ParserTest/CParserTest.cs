using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.IO;
using static CodeParser.CParser;

namespace CodeParser.Test
{
    public class CParserTest : CodeParserTest
    {
        public override string Language => "C";
        public override string FileExtension => ".c";

        public override void Parse(FileInfo file)
        {
            Lexer lexer = new CLexer(CharStreams.fromPath(file.FullName));

            CommonTokenStream tokens = new CommonTokenStream(lexer);

            CParser parser = new CParser(tokens);

            ParserRuleContext context = parser.compilationUnit();

            var children = context.children;

            foreach (IParseTree child in children)
            {
                this.ParseNode(child);
            }
        }

        private void ParseNode(IParseTree node)
        {
            if (node is TranslationUnitContext)
            {
                TranslationUnitContext transUnit = node as TranslationUnitContext;

                this.ParseTranslationUnit(transUnit);
            }
        }

        private void ParseTranslationUnit(TranslationUnitContext node)
        {
            TranslationUnitContext transUnit = node.translationUnit();

            ExternalDeclarationContext externalDeclaration = node.externalDeclaration();

            if (transUnit != null)
            {
                this.ParseTranslationUnit(transUnit);
            }

            if (externalDeclaration != null)
            {
                DeclarationContext[] declarations = externalDeclaration.GetRuleContexts<DeclarationContext>();
                FunctionDefinitionContext[] functions = externalDeclaration.GetRuleContexts<FunctionDefinitionContext>();

                foreach (DeclarationContext declaration in declarations)
                {
                    InitDeclaratorListContext initDeclaratorList = declaration.initDeclaratorList();

                    string name = initDeclaratorList.initDeclarator().declarator().directDeclarator().Identifier().GetText();

                    this.WriteKeyValue("Field", name);
                }

                foreach (FunctionDefinitionContext function in functions)
                {
                    DirectDeclaratorContext[] directDeclarators = function.declarator().GetRuleContexts<DirectDeclaratorContext>();

                    foreach (DirectDeclaratorContext directDeclarator in directDeclarators)
                    {
                        string name = directDeclarator.directDeclarator().Identifier().GetText();

                        this.WriteKeyValue("Function", name);
                    }
                }
            }
        }
    }
}
