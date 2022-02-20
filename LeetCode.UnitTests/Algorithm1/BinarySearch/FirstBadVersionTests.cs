using FluentAssertions;
using LeetCode.Algorithm1.BinarySearch;
using NUnit.Framework;

namespace LeetCode.UnitTests.Algorithm1.BinarySearch {
	public class FirstBadVersionTests {
		[TestCase(5, 4)]
		[TestCase(2, 2)]
		[TestCase(4, 4)]
		[TestCase(4, 1)]
		[TestCase(3, 1)]
		[TestCase(10, 7)]
		[TestCase(20, 14)]
		[TestCase(2126753390, 1702766719)]
		public void Test(int n, int firstBadVersion) {
			FirstBadVersion.Value = firstBadVersion;
			FirstBadVersion.Run(n)
			               .Should()
			               .Be(firstBadVersion);
		}
	}
}