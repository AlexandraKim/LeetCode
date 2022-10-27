using FluentAssertions;
using LeetCode.Easy;
using NUnit.Framework;

namespace LeetCode.UnitTests.Easy {
    [TestFixture]
    public class RemoveElementTests {
        [TestCase(new int[] {3,2,2,3}, 3, new int[] {2,2, -1000, -1000}, 2)]
        [TestCase(new int[] {0,1,2,2,3,0,4,2}, 2, new int[] {0,1,3,0,4, -1000, -1000, -1000}, 5)]
        [TestCase(new int[] {1}, 1, new int[] {-1000}, 0)]
        [TestCase(new int[] {4,5}, 5, new int[] {4, -1000}, 1)]
        public void Test(int[] nums, int val, int[] expectedNums, int expectedResult) {
            var sut = new RemoveElement();
            sut.Run(nums, val).Should().Be(expectedResult);
            nums.Should().BeEquivalentTo(expectedNums);
        }
    }
}