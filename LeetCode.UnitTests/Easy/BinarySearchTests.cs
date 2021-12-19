using FluentAssertions;
using LeetCode.Easy;
using NUnit.Framework;

namespace LeetCode.UnitTests.Easy {
	public class BinarySearchTests {
		[TestCase(new[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
		[TestCase(new[] { 5 }, 5, 0)]
		[TestCase(new[] { 2, 5 }, 5, 1)]
		[TestCase(new[] { 2, 5 }, 2, 0)]
		public void Test(int[] nums, int target, int expectedIndex) {
			BinarySearch.Search(nums, target)
			            .Should()
			            .Be(expectedIndex);
		}
	}
}