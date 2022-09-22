using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Bob");
            names.Add("Terry");
            names.Add("Gary");

            names.ForEach(name => Console.Write(name + " "));

            string aString = "a";
            List<string> stuff = new List<string> { "a", "b", "c", "d" };
            Console.WriteLine($"This is a sentence: {aString}");

            char aSingleCharacter = 'a';
            Console.WriteLine($"This is a single character: {aSingleCharacter}");

            int x = 5;
            int y = 7;

            int result = Adder(x, y); // 12
            int result2 = Adder(10, 46); // 56

            Console.WriteLine($"{x} + {y} = {result}");
        }

        static int Adder(int a, int b)
        {
            return a + b;
        }
    }
}