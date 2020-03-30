using System;
using System.Linq;
using System.Reflection;

namespace CodeParser.Test
{
    public class ParserHelper
    {       

        public static CodeParserTest GetParserTest(string language)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var typeArray = assembly.ExportedTypes;

            var types = (from type in typeArray
                         where type.IsSubclassOf(typeof(CodeParserTest))
                         select type).ToList();

            foreach (var type in types)
            {
                CodeParserTest codeParserTest = (CodeParserTest)Activator.CreateInstance(type);

                if (codeParserTest.Language == language)
                {
                    return codeParserTest;
                }
            }

            return null;
        }        
    }
}
