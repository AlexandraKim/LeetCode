using System.Collections.Generic;
using FluentAssertions;
using LeetCode.Easy.SameTree;
using NUnit.Framework;

namespace LeetCode.Algorithm1.BinarySearch.GuessNumber;

[TestFixture]
public class GuessNumberTests
{
  private static IEnumerable<TestCaseData> TestCases
  {
    get
    {
      yield return new (2, 2);
    }
  }

  [TestCaseSource(nameof(TestCases))]
  public void Test(int n, int expectedResult)
  {
    var sut = new GuessNumberSolution();

    var result = sut.GuessNumber(n);

    result.Should().Be(expectedResult);
  }
}