using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.IO;
using static CodeParser.CPP14Parser;

namespace CodeParser.Test
{
    public class CppParserTest : CodeParserTest
    {
        public override string Language => "C++";
        public override string FileExtension => ".cpp";

        public override void Parse(FileInfo file)
        {
            Lexer lexer = new CPP14Lexer(CharStreams.fromPath(file.FullName));

            CommonTokenStream tokens = new CommonTokenStream(lexer);

            CPP14Parser parser = new CPP14Parser(tokens);

            ParserRuleContext context = parser.translationunit();

            var children = context.children;

            foreach (IParseTree child in children)
            {
                this.ParseNode(child);
            }
        }

        private void ParseNode(IParseTree node)
        {
            if (node is DeclarationseqContext)
            {
                DeclarationseqContext declarationseqContext = node as DeclarationseqContext;
                this.ParseDeclarationseq(declarationseqContext);
            }
        }

        private void ParseDeclarationseq(DeclarationseqContext node)
        {
            DeclarationseqContext declareSq = node.declarationseq();
            DeclarationContext declare = node.declaration();

            if (declareSq != null)
            {
                this.ParseDeclarationseq(declareSq);
            }

            if (declare != null)
            {
                AttributedeclarationContext attribute = declare.attributedeclaration();
                FunctiondefinitionContext function = declare.functiondefinition();
                BlockdeclarationContext block = declare.blockdeclaration();

                if (block != null)
                {
                    UsingdirectiveContext usingDirective = block.usingdirective();
                    SimpledeclarationContext simpleDeclaration = block.simpledeclaration();

                    if (usingDirective != null)
                    {
                        string name = usingDirective.namespacename().GetText();

                        this.WriteKeyValue("Using", name);
                    }
                    else if (simpleDeclaration != null)
                    {
                        DeclspecifierseqContext[] decls = simpleDeclaration.GetRuleContexts<DeclspecifierseqContext>();
                        foreach (DeclspecifierseqContext decl in decls)
                        {
                            DeclspecifierContext declSpec = decl.declspecifier();
                            TypespecifierContext typeSpec = declSpec.typespecifier();

                            if (typeSpec != null)
                            {
                                ClassspecifierContext classSpec = typeSpec.classspecifier();
                                EnumspecifierContext enumSpec = typeSpec.enumspecifier();

                                if (classSpec != null)
                                {
                                    string className = classSpec.classhead().classheadname().GetText();

                                    this.WriteLine();
                                    this.WriteKeyValue("Class", className);
                                    this.WriteLeftBrace();

                                    MemberspecificationContext[] members = classSpec.GetRuleContexts<MemberspecificationContext>();

                                    foreach (MemberspecificationContext member in members)
                                    {
                                        MemberspecificationContext[] memberSpecs = member.GetRuleContexts<MemberspecificationContext>();
                                        foreach (MemberspecificationContext memberSpec in memberSpecs)
                                        {
                                            MemberdeclarationContext memberDeclaration = memberSpec.memberdeclaration();
                                            MemberspecificationContext memberSpecDeclaration = memberSpec.memberspecification();

                                            this.ParseMemberDeclaration(memberDeclaration);
                                            this.ParseMemberSpecification(memberSpecDeclaration);
                                        }
                                    }

                                    this.WriteRightBrace();
                                }
                            }
                        }
                    }
                }
                else if (function != null)
                {
                    this.ParseFunction(function);
                }
            }
        }

        private void ParseFunction(FunctiondefinitionContext node)
        {
            PtrdeclaratorContext[] ptrs = node.declarator().GetRuleContexts<PtrdeclaratorContext>();
            foreach (PtrdeclaratorContext ptr in ptrs)
            {
                NoptrdeclaratorContext noptr = ptr.noptrdeclarator();
                string name = noptr.noptrdeclarator().GetText();

                this.WriteKeyValue("Function", name);
            }
        }

        private void ParseMemberDeclaration(MemberdeclarationContext node)
        {
            if (node != null)
            {
                MemberspecificationContext[] memberSpecs = node.GetRuleContexts<MemberspecificationContext>();

                MemberdeclaratorlistContext[] fields = node.GetRuleContexts<MemberdeclaratorlistContext>();
                FunctiondefinitionContext[] funcs = node.GetRuleContexts<FunctiondefinitionContext>();

                if (fields != null)
                {
                    foreach (MemberdeclaratorlistContext field in fields)
                    {
                        foreach (string name in field.GetText().Split(','))
                        {
                            this.WriteKeyValue("Field", name);
                        }
                    }
                }

                if (funcs != null)
                {
                    foreach (FunctiondefinitionContext func in funcs)
                    {
                        this.ParseFunction(func);
                    }
                }
            }
        }

        private void ParseMemberSpecification(MemberspecificationContext node)
        {
            if (node != null)
            {
                MemberdeclarationContext[] members = node.GetRuleContexts<MemberdeclarationContext>();
                MemberspecificationContext[] memberSpecs = node.GetRuleContexts<MemberspecificationContext>();

                foreach (MemberdeclarationContext member in members)
                {
                    this.ParseMemberDeclaration(member);
                }

                foreach (MemberspecificationContext memberSpec in memberSpecs)
                {
                    this.ParseMemberSpecification(memberSpec);
                }
            }
        }
    }
}
