using FluentAssertions;
using LeetCode.Algorithm1.TwoPointers;
using NUnit.Framework;

namespace LeetCode.UnitTests.Algorithm1.TwoPointers {
    [TestFixture]
    public class RotateArrayTests {
        [TestCase(new [] {1,2,3,4,5,6,7}, 3, new [] {5,6,7,1,2,3,4})]
        public void Test(int[] input, int steps, int[] expectedResult) {
            RotateArray.Run(input, steps).Should().BeEquivalentTo(expectedResult);
        }
    }
}