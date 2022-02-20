using FluentAssertions;
using LeetCode.Algorithm1.TwoPointers;
using NUnit.Framework;

namespace LeetCode.UnitTests.Algorithm1.TwoPointers {
    [TestFixture]
    public class SortedSquaresTests {
        [TestCase(new[] {-4, -1, 0, 3, 10}, new[] {0, 1, 9, 16, 100})]
        [TestCase(new[] {-7, -3, 2, 3, 11}, new[] {4, 9, 9, 49, 121})]
        [TestCase(new[] {-1}, new[] {1})]
        [TestCase(new[] {-10000, -9999, -7, -5, 0, 0, 10000}, new[] {0, 0, 25, 49, 99980001, 100000000, 100000000})]
        [TestCase(new[] {-5, -3, -2, -1}, new[] {1, 4, 9, 25})]
        public void Test(int[] input, int[] output) {
            SortedSquares.Run(input)
                .Should()
                .BeEquivalentTo(output);
        }
    }
}