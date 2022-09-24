﻿using System;

namespace CodeParser.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Parse("Python3");
            Parse("C#");             
            Parse("JavaScript");
            Parse("C++");           

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
