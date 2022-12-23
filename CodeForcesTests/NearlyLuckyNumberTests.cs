using CodeForces.Problems;
using FluentAssertions;
using NUnit.Framework;

namespace CodeForcesTests {
    public class NearlyLuckyNumberTests : ConsoleAppTestsBase {
        [TestCase(@"40047", "NO")]
        [TestCase(@"1000000000000000000", "NO")]
        [TestCase(@"7747774", "YES")]
        public void Test(string input, string expectedResult) {
            SetupInput(input);

            var result = RunAndGetOutput(new NearlyLuckyNumber());

            result[0].Should().Be(expectedResult);
        }
    }
}