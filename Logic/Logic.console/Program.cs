using System;
using System.Collections.Generic;
using System.Linq;
using Logic.lib;

namespace Logic.console
{
    public class Program
    {
        private static int numberOfVariables;
        private static Func<string, bool> logicalFunc;

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Number of variables: ");
            numberOfVariables = int.Parse(Console.ReadLine());

            Console.Write("Choose logical operator (AND, OR, XOR): ");
            var key = Console.ReadLine().ToUpper();
            logicalFunc = GetFunction(key);

            CreateTable();
        }

        public static void CreateTable()
        {
            var varList = Enumerable.Range(112, numberOfVariables).Select(it => Convert.ToChar(it));
            var varListText = string.Join(" | ", varList);

            var count = 4 * numberOfVariables + 6;
            var line = new String('-', count);

            Console.WriteLine($"Truth table");
            Console.WriteLine($"{varListText} | result");
            Console.WriteLine(line);

            var sampleSpace = Logical.CreateSampleSpace(numberOfVariables);
            foreach (var pattern in sampleSpace)
            {
                var truthList = pattern.ToList().Select(it => it = (it == '1') ? 'T' : 'F');
                var truthListText = string.Join(" | ", truthList);

                var result = logicalFunc(pattern) ? 'T' : 'F';

                Console.WriteLine($"{truthListText} |   {result}");
            }
        }

        public static Func<string, bool> GetFunction(string key)
        {
            switch (key)
            {
                case "AND":
                    return Logical.AND;
                case "OR":
                    return Logical.OR;
                case "XOR":
                    return Logical.XOR;
                default:
                    throw new FormatException("No have this operator.");
            }
        }
    }
}
