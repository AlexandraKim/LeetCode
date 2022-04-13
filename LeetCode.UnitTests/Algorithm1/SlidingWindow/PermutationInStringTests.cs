using FluentAssertions;
using LeetCode.Algorithm1.SlidingWindow;
using NUnit.Framework;

namespace LeetCode.UnitTests.Algorithm1.SlidingWindow {
    [TestFixture]
    public class PermutationInStringTests {
        [TestCase("ab", "eidbaooo", true)]
        [TestCase("ab", "eidboaoo", false)]
        [TestCase("a", "ab", true)]
        [TestCase("adc", "dcda", true)]
        [TestCase("ab", "ab", true)]
        [TestCase("ab", "ba", true)]
        [TestCase("abc", "bbbca", true)]
        [TestCase("hello", "ooolleoooleh", false)]
        [TestCase("ab", "a", false)]
        public void Test(string s1, string s2, bool expectedResult) {
            PermutationInString.CheckInclusion(s1, s2).Should().Be(expectedResult);
        }
    }
}