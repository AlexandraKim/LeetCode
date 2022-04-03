using FluentAssertions;
using LeetCode.Algorithm1.TwoPointers;
using NUnit.Framework;

namespace LeetCode.UnitTests.Algorithm1.TwoPointers {
    [TestFixture]
    public class ReverseStringTests {
        [TestCase(new char[] {'h','e','l','l','o'}, new char[]{'o','l','l','e','h'})]
        [TestCase(new char[] {'H','a','n','n','a','h'}, new char[]{'h','a','n','n','a','H'})]
        public void Test(char[] input, char[] expectedResult) {
            ReverseString.Run(input);
            input.Should().BeEquivalentTo(expectedResult);
        }
    }
}