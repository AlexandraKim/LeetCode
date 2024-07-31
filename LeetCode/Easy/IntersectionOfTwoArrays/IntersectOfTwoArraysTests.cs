using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Easy.IntersectionOfTwoArrays;
// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/674/
[TestFixture]
public class IntersectOfTwoArraysTests
{
  private static IEnumerable<TestCaseData> TestCases { get
  {
    yield return new TestCaseData(new int[]{1, 2, 2, 1}, new int[]{ 2, 2, }, new int[]{ 2, 2, });
  }}
  [TestCaseSource(nameof(TestCases))]
  public void Test(int[] nums1, int[] nums2, int[] expectedResult)
  {
    var sut = new IntersectOfTwoArrays();
        
    var result = sut.Intersect(nums1, nums2);

    result.Should()
      .BeEquivalentTo(expectedResult);
  }
}