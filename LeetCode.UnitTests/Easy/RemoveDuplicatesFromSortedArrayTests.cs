using FluentAssertions;
using LeetCode.Easy;
using NUnit.Framework;

namespace LeetCode.UnitTests.Easy {
    [TestFixture]
    public class RemoveDuplicatesFromSortedArrayTests {
        private static readonly int EmptyCell = RemoveDuplicatesFromSortedArray.EmptyCell;

        [TestCase(new int[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4}, 
            new int[] {0,1,2,3,4, -1000, -1000, -1000, -1000,-1000}, 5)]
        [TestCase(new int[] {1,1,2}, 
            new int[] {1,2,-1000}, 2)]
        public void Test(int[] nums, int[] expectedNums, int expectedN) {
            var sut = new RemoveDuplicatesFromSortedArray();
            sut.RemoveDuplicates(nums)
                .Should()
                .Be(expectedN);
            nums.Should().BeEquivalentTo(expectedNums);

        }
        
    }
}