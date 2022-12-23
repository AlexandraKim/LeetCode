using CodeForces.Problems;
using FluentAssertions;
using NUnit.Framework;

namespace CodeForcesTests {
    public class TeamTests : ConsoleAppTestsBase {
        [TestCase(@"3
1 1 0
1 1 1
1 0 0", "2")]
        [TestCase(@"2
1 0 0
0 1 1", "1")]
        public void Test(string input, string expectedResult) {
            SetupInput(input);

            var result = RunAndGetOutput(new Team());

            result[0].Should().Be(expectedResult);
        }
    }
}