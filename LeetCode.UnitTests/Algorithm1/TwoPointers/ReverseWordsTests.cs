using FluentAssertions;
using LeetCode.Algorithm1.TwoPointers;
using NUnit.Framework;

namespace LeetCode.UnitTests.Algorithm1.TwoPointers {
    [TestFixture]
    public class ReverseWordsTests {
        [TestCase("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
        [TestCase("God Ding", "doG gniD")]
        public void Test(string input, string expectedOutput) {
            ReverseWords.Run(input).Should().BeEquivalentTo(expectedOutput);
        }
    }
}