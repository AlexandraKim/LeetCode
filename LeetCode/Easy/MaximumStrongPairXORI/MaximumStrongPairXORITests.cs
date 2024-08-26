using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Easy.MaximumStrongPairXORI;

[TestFixture]
public class MaximumStrongPairXORITests
{
  private static IEnumerable<TestCaseData> TestCases
  {
    get
    {
      yield return new ( new int[] {1,2,3,4,5}, 7);
      yield return new ( new int[] {10,100}, 0);
      yield return new ( new int[] {5,6,25,30}, 7);
      yield return new ( new int[] {1,1,10,3,9}, 3);
      yield return new ( new int[] {1,3,9,6,5}, 15);
      yield return new ( new int[] {4,8,9,7,5}, 15);
    }
  }

  [TestCaseSource(nameof(TestCases))]
  public void Test(int[] nums, int expectedResult)
  {
    var sut = new MaximumStrongPairXORI();

    var result = sut.MaximumStrongPairXor(nums);

    result.Should().Be(expectedResult);
  }
}