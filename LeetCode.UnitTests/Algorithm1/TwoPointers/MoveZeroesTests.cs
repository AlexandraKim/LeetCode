using FluentAssertions;
using LeetCode.Algorithm1.TwoPointers;
using NUnit.Framework;

namespace LeetCode.UnitTests.Algorithm1.TwoPointers {
    [TestFixture]
    public class MoveZeroesTests {
        [TestCase(new int[] {0,1,0,3,12}, new int[] {1,3,12,0,0})]
        [TestCase(new int[] {0}, new int[] {0})]
        [TestCase(new int[] {2, 1}, new int[] {2, 1})]
        public void Test(int[] nums, int[] expectedResult) {
            MoveZeroes.Run(nums).Should().BeEquivalentTo(expectedResult);
        }
    }
}