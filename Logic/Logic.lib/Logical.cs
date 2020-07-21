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

        public static bool AND(string pattern)
        {
            return pattern.All(it => it == '1');
        }

        public static bool OR(string pattern)
        {
            return pattern.Any(it => it == '1');
        }

        public static bool XOR(string pattern)
        {
            return pattern.Count(it => it == '1') == 1;
        }
    }
}
