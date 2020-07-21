using System;

namespace Algebra.lib
{
    public static class Calculate
    {
        public static int GCD(int a, int b)
        {
            var c = Math.Abs(a) % Math.Abs(b);
            return (c == 0) ? b : GCD(b, c);
        }

        public static int LCM(int a, int b)
        {
            return Math.Abs(a * b) / GCD(a, b);
        }
    }
}
