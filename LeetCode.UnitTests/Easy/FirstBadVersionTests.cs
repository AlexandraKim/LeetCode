using FluentAssertions;
using LeetCode.Easy;
using NUnit.Framework;

namespace LeetCode.UnitTests.Easy {
	public class FirstBadVersionTests {
		[TestCase(5, 4)]
		[TestCase(2, 2)]
		[TestCase(4, 4)]
		[TestCase(2126753390, 1702766719)]
		public void Test(int n, int firstBadVersion) {
			FirstBadVersion.Value = firstBadVersion;
			FirstBadVersion.Run(n)
			               .Should()
			               .Be(firstBadVersion);
		}
	}
}