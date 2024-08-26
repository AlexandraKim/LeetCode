using System.Collections.Generic;
using FluentAssertions;
using LeetCode.Easy.IntersectionOfTwoArrays;
using NUnit.Framework;

namespace LeetCode.Easy.TwoSum;

public class TwoSumTests
{
  private static IEnumerable<TestCaseData> TestCases { get
  {
    yield return new TestCaseData(new int[]{2,7,11,15}, 9, new int[]{ 0,1 });
    yield return new TestCaseData(new int[]{3,2,4}, 6, new int[]{ 1,2 });
    yield return new TestCaseData(new int[]{3,3}, 6, new int[]{ 0,1 });
    yield return new TestCaseData(new int[]{1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1}, 11, new int[]{ 5,11 });
  }}
  [TestCaseSource(nameof(TestCases))]
  public void Test(int[] nums1, int target, int[] expectedResult)
  {
    var sut = new TwoSum();
           
    var result = sut.Run(nums1, target);
   
    result.Should()
      .BeEquivalentTo(expectedResult);
  }
}