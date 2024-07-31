using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Easy.SingleNumber;

[TestFixture]
public class SingleNumberTests
{
  private static IEnumerable<TestCaseData> TestCases { get
  {
    yield return new TestCaseData(new int[]{4,1,2,1,2}, 4);
    yield return new TestCaseData(new int[]{2,2,1}, 1);
  }}
  [TestCaseSource(nameof(TestCases))]
  public void Test(int[] nums, int expectedResult)
  {
    var sut = new SingleNumber();
       
    var result = sut.Run(nums);

    result.Should()
      .Be(expectedResult);
  }
}