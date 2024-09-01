using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Algorithm1.TwoPointers.IntervalListIntersections;

[TestFixture]
public class IntervalListIntersectionsTests
{
  
  private static IEnumerable<TestCaseData> TestCases
  {
    get
    {
      yield return new ( new int[][]{new int[]{0,2},new int[]{5,10},new int[]{13,23},new int[]{24,25}},
        new int[][] {new int[]{1,5}, new int[]{8,12}, new int[]{15,24}, new int[]{25,26}},
        new int[][] {new int[]{1,2},new int[]{5,5},new int[]{8,10},new int[]{15,23},new int[]{24,24},new int[]{25,25}});
      yield return new ( new int[][]{new int[]{1,3},new int[]{5,9}},
        new int[][] {},
        new int[][] {});
    }
  }

  [TestCaseSource(nameof(TestCases))]
  public void Test(int[][] first, int[][] second, int[][] expectedResult)
  {
    var sut = new IntervalListIntersections();

    var result = sut.IntervalIntersection(first, second);

    result.Should().BeEquivalentTo(expectedResult);
  }
}