using FluentAssertions;
using LeetCode.Easy;
using NUnit.Framework;

namespace LeetCode.UnitTests.Easy {
    [TestFixture]
    public class LengthOfLastWordTests {
        [TestCase("Hello World", 5)]
        [TestCase("   fly me   to   the moon  ", 4)]
        public void Test(string str, int expectedResult) {
            var sut = new LengthOfLastWord();
            sut.Run(str)
                .Should()
                .Be(expectedResult);
        }
    }
}