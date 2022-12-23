using CodeForces.Problems;
using FluentAssertions;
using NUnit.Framework;

namespace CodeForcesTests {
    public class WrongSubtractionTests : ConsoleAppTestsBase {
        [TestCase(@"512 4", "50")]
        [TestCase(@"1000000000 9", "1")]
        public void Test(string input, string expectedResult) {
            SetupInput(input);

            var result = RunAndGetOutput(new WrongSubtraction());

            result[0].Should().Be(expectedResult);
        }
    }
}