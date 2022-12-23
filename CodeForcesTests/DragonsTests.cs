using CodeForces.Problems;
using FluentAssertions;
using NUnit.Framework;

namespace CodeForcesTests {
    public class DragonsTests : ConsoleAppTestsBase {
        [TestCase(@"2 2
1 99
100 0", "YES")]
        [TestCase(@"10 1
100 100", "NO")]
        public void Test(string input, string expectedResult) {
            SetupInput(input);

            var result = RunAndGetOutput(new Dragons());

            result[0].Should().Be(expectedResult);
        }
    }
}