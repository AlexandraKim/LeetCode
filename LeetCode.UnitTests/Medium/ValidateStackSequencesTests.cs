using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using LeetCode.Medium;
using NUnit.Framework;

namespace LeetCode.UnitTests.Medium; 

[TestFixture]
public class ValidateStackSequencesTests {
    private static IEnumerable<TestCaseData> TestCases() {
        yield return new TestCaseData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 2, 1 }, true);
        yield return new TestCaseData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 3, 5, 1, 2 }, false);
        yield return new TestCaseData(new int[] { 2, 1, 0 }, new int[] { 1, 2, 0 }, true);
    }
    [TestCaseSource(nameof(TestCases))]
    public void Test(int[] pushed, int[] popped, bool expectedResult) {
        var sut = new ValidateStackSequences();

        sut.Run(pushed, popped)
            .Should()
            .Be(expectedResult);

    }
}