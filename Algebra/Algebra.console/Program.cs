using System;
using Algebra.lib;

namespace Algebra.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("a: ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            var b = int.Parse(Console.ReadLine());

            var gcd = Calculate.GCD(a, b);
            var lcm = Calculate.LCM(a, b);

            Console.WriteLine($"GCD({a},{b}) = {gcd}");
            Console.WriteLine($"LCM({a},{b}) = {lcm}");
        }
    }
}
