using FluentAssertions;
using LeetCode.Easy;
using NUnit.Framework;

namespace LeetCode.UnitTests.Easy {
	public class ValidParenthesesTests {
		[TestCase("()[]{}", true)]
		[TestCase("(]", false)]
		[TestCase("([)]", false)]
		[TestCase("{[]}", true)]
		[TestCase("((", false)]
		public void Test(string s, bool expectedResult) {
			ValidParentheses.IsValid(s)
			                .Should()
			                .Be(expectedResult);
		}
	}
}