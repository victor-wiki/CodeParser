using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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

            Console.ReadLine();
        }       

        static void Parse(string language)
        {
            CodeParserTest codeParserTest = ParserHelper.GetParser(language);
            if (codeParserTest != null)
            {
                codeParserTest.Parse();
            }
            else
            {
                Console.WriteLine($"There's no parser test class for language \"{language}\".");
            }
        }
    }
}
