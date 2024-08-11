using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Medium.PartitionLabels;

public class PartitionLabelsTests
{
  
  [TestFixture]
  public class ContainerWithMostWaterTest
  {
    private static IEnumerable<TestCaseData> TestCases
    {
      get
      {
        yield return new ( "ababcbacadefegdehijhklij", new int[]{9,7,8});
        yield return new ( "eccbbbbdec", new int[]{10});
        yield return new ( "qiejxqfnqceocmy", new int[]{13,1,1});
      }
    }

    [TestCaseSource(nameof(TestCases))]
    public void Test(string str, int[] expectedResult)
    {
      var sut = new PartitionLabels();

      var result = sut.Run(str);

      result.Should().BeEquivalentTo(expectedResult);
    }
  }
}