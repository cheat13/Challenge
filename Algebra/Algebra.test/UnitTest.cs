using System;
using Algebra.lib;
using Xunit;

namespace Algebra.test
{
    public class UnitTest
    {
        [Theory]
        [InlineData(2, 4, 2)]
        [InlineData(4, 2, 2)]
        [InlineData(54, 24, 6)]
        [InlineData(24, 54, 6)]
        [InlineData(48, 180, 12)]
        [InlineData(180, 48, 12)]
        [InlineData(2, -4, 2)]
        [InlineData(-2, 4, 2)]
        [InlineData(-2, -4, 2)]
        public void TestGCD(int a, int b, int expect)
        {
            var result = Calculate.GCD(a, b);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(2, 4, 4)]
        [InlineData(4, 2, 4)]
        [InlineData(54, 24, 216)]
        [InlineData(24, 54, 216)]
        [InlineData(21, 6, 42)]
        [InlineData(6, 21, 42)]
        [InlineData(2, -4, 4)]
        [InlineData(-2, 4, 4)]
        [InlineData(-2, -4, 4)]
        public void TestLCM(int a, int b, int expect)
        {
            var result = Calculate.LCM(a, b);
            Assert.Equal(expect, result);
        }
    }
}
