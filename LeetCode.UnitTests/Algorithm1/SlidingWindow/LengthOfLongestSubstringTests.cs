using FluentAssertions;
using LeetCode.Algorithm1.SlidingWindow;
using NUnit.Framework;

namespace LeetCode.UnitTests.Algorithm1.SlidingWindow {
    [TestFixture]
    public class LengthOfLongestSubstringTests {
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase(" ", 1)]
        [TestCase("", 0)]
        [TestCase("au", 2)]
        [TestCase("dvdf", 3)]
        public void Test(string input, int expectedResult) {
            LengthOfLongestSubstring.Run(input).Should().Be(expectedResult);
        }
    }
}