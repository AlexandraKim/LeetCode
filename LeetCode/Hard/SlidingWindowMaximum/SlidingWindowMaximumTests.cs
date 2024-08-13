using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Hard.SlidingWindowMaximum;

public class SlidingWindowMaximumTests
{
  private static IEnumerable<TestCaseData> TestCases
  {
    get
    {
      yield return new ( new int[]{1,3,-1,-3,5,3,6,7}, 3, new int []{3,3,5,5,6,7});
      yield return new ( new int[]{1,3,-1,-3,-3,3,6,7}, 3, new int []{3,3,-1,3,6,7});
      yield return new ( new int[]{1}, 1, new int []{1});
      yield return new ( new int[]{1,-1}, 1, new int []{1,-1});
      yield return new ( new int[]{7,2,4}, 2, new int []{7,4});
      yield return new ( new int[]{1,3,1,2,0,5}, 3, new int []{3,3,2,5});
    }
  }

  [TestCaseSource(nameof(TestCases))]
  public void Test(int[] nums, int k, int[] expectedResult)
  {
    var sut = new SlidingWindowMaximum();

    var result = sut.MaxSlidingWindow(nums, k);

    result.Should().BeEquivalentTo(expectedResult);
  }
}