using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.UnitTests.Easy.BinarySearch {
	public class BinarySearchTests {
		[TestCase(new[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
		[TestCase(new[] { 5 }, 5, 0)]
		[TestCase(new[] { 2, 5 }, 5, 1)]
		[TestCase(new[] { 2, 5 }, 2, 0)]
		public void Test(int[] nums, int target, int expectedIndex) {
			LeetCode.Easy.BinarySearch.BinarySearch.Search(nums, target)
			        .Should()
			        .Be(expectedIndex);
		}
	}
}