using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic.lib
{
    public static class Logical
    {
        public static IEnumerable<string> CreateSampleSpace(int numberOfVariables)
        {
            var count = (int)Math.Pow(2, numberOfVariables);
            var sampleSpace = Enumerable.Range(0, count)
                .OrderByDescending(it => it)
                .Select(it => Convert.ToString(it, 2)
                .PadLeft(numberOfVariables, '0'));
            return sampleSpace;
        }

        public static bool AND(string pattern) => pattern.All(it => it == '1');

        public static bool OR(string pattern) => pattern.Any(it => it == '1');

        public static bool XOR(string pattern) => pattern.Count(it => it == '1') == 1;

        public static IEnumerable<string> CreateSampleSpaceWithCartesianProduct(int numberOfVariables)
        {
            var sets = Enumerable.Repeat(new List<string> { "0", "1" }, numberOfVariables);
            return sets.Aggregate((A, B) => A.SelectMany(a => B.Select(b => $"{a}{b}")).ToList());
        }
    }
}
