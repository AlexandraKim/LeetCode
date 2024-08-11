using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Medium.ContainerWithMostWater;

[TestFixture]
public class ContainerWithMostWaterTest
{
  private static IEnumerable<TestCaseData> TestCases
  {
    get
    {
      yield return new ( new int[] {1,8,6,2,5,4,8,3,7}, 49);
      yield return new ( new int[] {1,1}, 1);
      yield return new ( new int[] {1,2,1}, 2);
    }
  }

  [TestCaseSource(nameof(TestCases))]
  public void Test(int[] height, int expectedResult)
  {
    var sut = new ContainerWithMostWater();

    var result = sut.MaxArea(height);

    result.Should().Be(expectedResult);
  }
}