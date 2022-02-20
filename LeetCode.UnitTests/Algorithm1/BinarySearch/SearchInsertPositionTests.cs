using FluentAssertions;
using LeetCode.Algorithm1.BinarySearch;
using NUnit.Framework;

namespace LeetCode.UnitTests.Algorithm1.BinarySearch
{
    public class SearchInsertPositionTests
    {
        [TestCase(new[] {1, 3, 5, 6}, 5, 2)]
        [TestCase(new[] {1, 3, 5, 6}, 2, 1)]
        [TestCase(new[] {1, 3, 5, 6}, 7, 4)]
        [TestCase(new[] {1}, 2, 1)]
        [TestCase(new[] {1, 3, 5}, 1, 0)]
        [TestCase(new[] {2, 3, 4, 7, 8, 9}, 11, 6)]
        [TestCase(new[] {1, 3, 5, 6 }, 0, 0)]
        public void Test(int[] nums, int target, int expectedResult)
        {
            SearchInsertPosition.SearchInsert(nums, target)
                .Should()
                .Be(expectedResult);
        }
    }
}