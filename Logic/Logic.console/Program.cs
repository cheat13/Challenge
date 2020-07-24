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
            Console.Write("Number of variables: ");
            numberOfVariables = int.Parse(Console.ReadLine());

            Console.WriteLine("\nChoose an operator: ");
            Console.WriteLine("1) AND");
            Console.WriteLine("2) OR");
            Console.WriteLine("3) XOR");
            Console.Write("\nSelect an operator: ");

            var key = int.Parse(Console.ReadLine());
            logicalFunc = GetFunction(key);

            CreateTable();
        }

        public static void CreateTable()
        {
            var varList = Enumerable.Range(80, numberOfVariables).Select(it => Convert.ToChar(it));
            var varListText = string.Join(" | ", varList);

            var count = 4 * numberOfVariables + 6;
            var line = new String('-', count);

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

        public static Func<string, bool> GetFunction(int key)
        {
            switch (key)
            {
                case 1:
                    return Logical.AND;
                case 2:
                    return Logical.OR;
                case 3:
                    return Logical.XOR;
                default:
                    throw new FormatException("No have this operator.");
            }
        }
    }
}
