using System;
using Xunit;
using Logic.lib;
using FluentAssertions;
using System.Collections.Generic;

namespace Logic.test
{
    public class UnitTest
    {
        [Theory]
        [MemberData(nameof(GetSampleSpace))]
        public void TestCreateSampleSpace(int numberOfVariables, IEnumerable<string> expected)
        {
            var result = Logical.CreateSampleSpace(numberOfVariables);
            result.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [MemberData(nameof(GetPossibleAND))]
        public void TestAND(string pattern, bool expected)
        {
            var result = Logical.AND(pattern);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(GetPossibleOR))]
        public void TestOR(string pattern, bool expected)
        {
            var result = Logical.OR(pattern);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(GetPossibleXOR))]
        public void TestXOR(string pattern, bool expected)
        {
            var result = Logical.XOR(pattern);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetSampleSpace = new List<object[]>
        {
            new object[] {
                1,
                new List<string> { "0", "1" }
            },
            new object[] {
                2,
                new List<string> { "00", "01", "10", "11" }
            },
            new object[] {
                3,
                new List<string> { "000", "001", "010", "011", "100", "101", "110", "111" }
            },
            new object[] {
                4,
                new List<string> { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" }
            },
        };

        public static IEnumerable<object[]> GetPossibleAND = new List<object[]>
        {
            new object[] { "0", false },
            new object[] { "1", true },
            new object[] { "00", false },
            new object[] { "01", false },
            new object[] { "10", false },
            new object[] { "11", true },
            new object[] { "000", false },
            new object[] { "001", false },
            new object[] { "010", false },
            new object[] { "011", false },
            new object[] { "100", false },
            new object[] { "101", false },
            new object[] { "110", false },
            new object[] { "111", true },
        };

        public static IEnumerable<object[]> GetPossibleOR = new List<object[]>
        {
            new object[] { "0", false },
            new object[] { "1", true },
            new object[] { "00", false },
            new object[] { "01", true },
            new object[] { "10", true },
            new object[] { "11", true },
            new object[] { "000", false },
            new object[] { "001", true },
            new object[] { "010", true },
            new object[] { "011", true },
            new object[] { "100", true },
            new object[] { "101", true },
            new object[] { "110", true },
            new object[] { "111", true },
        };

        public static IEnumerable<object[]> GetPossibleXOR = new List<object[]>
        {
            new object[] { "0", false },
            new object[] { "1", true },
            new object[] { "00", false },
            new object[] { "01", true },
            new object[] { "10", true },
            new object[] { "11", false },
            new object[] { "000", false },
            new object[] { "001", true },
            new object[] { "010", true },
            new object[] { "011", false },
            new object[] { "100", true },
            new object[] { "101", false },
            new object[] { "110", false },
            new object[] { "111", false },
        };
    }
}
