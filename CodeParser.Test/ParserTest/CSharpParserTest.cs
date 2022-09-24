using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.IO;
using System.Linq;
using static CSharpParser;

namespace CodeParser.Test
{
    public class CSharpParserTest : CodeParserTest
    {
        public override string Language => "C#";       

        public override void Parse(FileInfo file)
        {
            Lexer lexer = new CSharpLexer(CharStreams.fromPath(file.FullName));

            CommonTokenStream tokens = new CommonTokenStream(lexer);

            CSharpParser parser = new CSharpParser(tokens);

            ParserRuleContext context = parser.compilation_unit();

            var children = context.children;

            foreach (IParseTree child in children)
            {
                this.ParseNode(child);
            }
        }

        private void ParseNode(IParseTree node)
        {           
            if (node is Using_directivesContext)
            {
                Using_directivesContext usingContext = node as Using_directivesContext;
                UsingNamespaceDirectiveContext[] usingNamespaces = usingContext.GetRuleContexts<UsingNamespaceDirectiveContext>();
                foreach (UsingNamespaceDirectiveContext ns in usingNamespaces)
                {
                    string name = ns.namespace_or_type_name().GetText();
                    this.WriteKeyValue("Using", name);
                }
            }
            else if (node is Namespace_member_declarationsContext)
            {
                Namespace_member_declarationsContext nsMemberContext = node as Namespace_member_declarationsContext;

                Namespace_member_declarationContext[] members = nsMemberContext.namespace_member_declaration();

                foreach (Namespace_member_declarationContext member in members)
                {
                    Type memberType = member.children[0].GetType();

                    Namespace_declarationContext[] nses = member.GetRuleContexts<Namespace_declarationContext>();
                    Type_declarationContext[] types = member.GetRuleContexts<Type_declarationContext>();

                    foreach (Namespace_declarationContext ns in nses)
                    {
                        string name = this.GetNodeName(ns.qualified_identifier().identifier().First());

                        this.WriteKeyValue("Namespace", name);

                        var childMembers = ns.namespace_body().namespace_member_declarations().namespace_member_declaration();

                        foreach (var childMember in childMembers)
                        {
                            var childMemberDeclaration = childMember.children[0];

                            if (childMemberDeclaration is Type_declarationContext)
                            {
                                this.ParseTypeDeclaration(childMemberDeclaration as Type_declarationContext);
                            }
                        }
                    }

                    foreach (Type_declarationContext t in types)
                    {
                        this.ParseTypeDeclaration(t);
                    }
                }
            }
        }

        private void ParseTypeDeclaration(Type_declarationContext node)
        {
            Class_definitionContext classContext = node.class_definition();
            Interface_definitionContext interfaceContext = node.interface_definition();
            Delegate_definitionContext delegateContext = node.delegate_definition();
            Enum_definitionContext enumContext = node.enum_definition();

            bool isClass = classContext != null;
            bool isInterface = interfaceContext != null;
            bool isDelegate = delegateContext != null;
            bool isEnum = enumContext != null;

            string type = "";
            string name = "";
            if (isClass)
            {
                type = "Class";
                name = this.GetNodeName(classContext.identifier());
            }
            else if (isInterface)
            {
                type = "Interface";
                name = this.GetNodeName(interfaceContext.identifier());
            }
            else if (isDelegate)
            {
                type = "Delegate";
                name = this.GetNodeName(delegateContext.identifier());
            }
            else if (isEnum)
            {
                type = "Enum";
                name = this.GetNodeName(enumContext.identifier());
            }

            if (!string.IsNullOrEmpty(name))
            {
                this.WriteLine();
                this.WriteKeyValue(type, name);
            }

            if (isClass)
            {
                this.WriteBeginBrace();
                this.ParseClassDeclaration(classContext);
                this.WriteEndBrace();
            }
            else if (isInterface)
            {
                this.WriteBeginBrace();
                this.ParseInterfaceDeclaration(interfaceContext);
                this.WriteEndBrace();
            }
        }

        private void ParseClassDeclaration(Class_definitionContext node)
        {
            var members = node.class_body().class_member_declarations().class_member_declaration();
            foreach (var member in members)
            {
                Common_member_declarationContext child = member.GetRuleContext<Common_member_declarationContext>(0);

                if (child is Common_member_declarationContext)
                {
                    Common_member_declarationContext commonMemberContext = child as Common_member_declarationContext;

                    Event_declarationContext eventContext = commonMemberContext.event_declaration();
                    Typed_member_declarationContext typeMemberContext = commonMemberContext.typed_member_declaration();
                    Method_declarationContext methodContext = commonMemberContext.method_declaration();

                    string type = "";
                    string name = "";

                    if (eventContext != null)
                    {
                        type = "Event";
                        name = eventContext.variable_declarators().GetText();
                    }

                    if (typeMemberContext != null)
                    {
                        Field_declarationContext field = typeMemberContext.field_declaration();
                        Property_declarationContext property = typeMemberContext.property_declaration();

                        if (field != null)
                        {
                            type = "Field";
                            name = field.variable_declarators().GetText();
                        }
                        else if (property != null)
                        {
                            type = "Property";
                            name = property.member_name().GetText();
                        }
                    }
                    else if (methodContext != null)
                    {
                        type = "Method";
                        name = methodContext.method_member_name().GetText();
                    }

                    if (!string.IsNullOrEmpty(name))
                    {
                        this.WriteKeyValue(type, name);
                    }
                }
            }
        }

        private void ParseInterfaceDeclaration(Interface_definitionContext node)
        {
            var members = node.class_body().class_member_declarations();

            foreach (var member in members.children)
            {
                if (member is Interface_member_declarationContext)
                {
                    Interface_member_declarationContext memberContext = member as Interface_member_declarationContext;
                    Type_Context typeContext = memberContext.type_();

                    bool isProperty = typeContext != null;

                    IdentifierContext identifierContext = memberContext.identifier();

                    if (identifierContext != null)
                    {
                        string name = this.GetNodeName(identifierContext);
                        this.WriteKeyValue((isProperty ? "Property" : "Method"), name);
                    }
                }
            }
        }

        protected string GetNodeName(IdentifierContext node)
        {
            return node.GetText();
        }
    }
}
