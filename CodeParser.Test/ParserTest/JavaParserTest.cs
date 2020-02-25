using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.IO;
using System.Linq;
using static CodeParser.JavaParser;

namespace CodeParser.Test
{
    public class JavaParserTest : CodeParserTest
    {
        public override string Language => "Java";
        public override string FileExtension => ".java";

        public override void Parse(FileInfo file)
        {
            Lexer lexer = new JavaLexer(CharStreams.fromPath(file.FullName));

            CommonTokenStream tokens = new CommonTokenStream(lexer);

            JavaParser parser = new JavaParser(tokens);

            ParserRuleContext context = parser.compilationUnit();

            var children = context.children;

            foreach (IParseTree child in children)
            {
                this.ParseNode(child);
            }
        }

        private void ParseNode(IParseTree node)
        {
            if (node is PackageDeclarationContext)
            {
                PackageDeclarationContext packageContext = node as PackageDeclarationContext;
                string name = this.GetNodeName(packageContext);
                this.WriteKeyValue("Package", name);
            }
            else if (node is ImportDeclarationContext)
            {
                ImportDeclarationContext importContext = node as ImportDeclarationContext;
                string name = this.GetNodeName(importContext);
                this.WriteKeyValue("Import", name);
            }
            else if (node is TypeDeclarationContext)
            {
                TypeDeclarationContext typeContext = node as TypeDeclarationContext;
                foreach (var child in typeContext.children)
                {
                    if (child is InterfaceDeclarationContext)
                    {
                        InterfaceDeclarationContext interfaceContext = child as InterfaceDeclarationContext;
                        string name = interfaceContext.IDENTIFIER().GetText();

                        this.WriteLine();
                        this.WriteKeyValue("Interface", name);
                        this.WriteLeftBrace();

                        var members = interfaceContext.interfaceBody().interfaceBodyDeclaration().Select(item => item.interfaceMemberDeclaration());
                        foreach (InterfaceMemberDeclarationContext member in members)
                        {
                            var constContext = member.constDeclaration();
                            if (constContext != null)
                            {
                                string constName = constContext.constantDeclarator(0).IDENTIFIER().GetText();

                                this.Write($"Const field:{constName}");
                            }

                            InterfaceMethodDeclarationContext method = member.interfaceMethodDeclaration();
                            if (method != null)
                            {
                                string methodName = method.IDENTIFIER().GetText();

                                this.WriteKeyValue("Method", methodName);
                            }
                        }
                        this.WriteRightBrace();
                    }
                    else if (child is ClassDeclarationContext)
                    {
                        ClassDeclarationContext classContext = child as ClassDeclarationContext;
                        string name = this.GetNodeName(classContext);

                        this.WriteLine();
                        this.Write($"Class:{name}");
                        this.WriteLeftBrace();

                        var members = classContext.classBody().classBodyDeclaration().Select(item => item.memberDeclaration());
                        foreach (MemberDeclarationContext member in members)
                        {
                            FieldDeclarationContext field = member.fieldDeclaration();
                            if (field != null)
                            {
                                string fieldName = field.variableDeclarators().GetText();

                                this.WriteKeyValue("Field", fieldName);
                            }

                            MethodDeclarationContext method = member.methodDeclaration();
                            if (method != null)
                            {
                                string methodName = method.IDENTIFIER().GetText();

                                this.WriteKeyValue("Method", methodName);
                            }
                        }

                        this.WriteRightBrace();
                    }
                }
            }
        }

        private string GetNodeName(ParserRuleContext node)
        {
            QualifiedNameContext qualifiedName = node.GetRuleContext<QualifiedNameContext>(0);
            return qualifiedName?.GetText();
        }
    }
}
