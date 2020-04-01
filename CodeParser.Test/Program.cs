using System;

namespace CodeParser.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Parse("Java");
            Parse("C#");
            Parse("Python");
            Parse("PHP");
            Parse("JavaScript");
            Parse("C++");
            Parse("C");
            Parse("MySql");

            Console.ReadLine();
        }       

        static void Parse(string language)
        {
            CodeParserTest codeParserTest = ParserHelper.GetParserTest(language);
            if (codeParserTest != null)
            {
                ParserInfo info = ParserManager.GetParserInfoByLanguage(language);

                if(info!=null)
                {
                    codeParserTest.Parse(info);
                }
                else
                {
                    Console.WriteLine($"Can't get ParserInfo for language \"{language}\".");
                }
            }
            else
            {
                Console.WriteLine($"There's no parser test class for language \"{language}\".");
            }
        }
    }
}
