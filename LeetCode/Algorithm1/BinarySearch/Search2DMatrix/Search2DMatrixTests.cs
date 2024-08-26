using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Algorithm1.BinarySearch.Search2DMatrix;

[TestFixture]
public class Search2DMatrixTests
{
  private static IEnumerable<TestCaseData> TestCases
  {
    get
    {
      yield return new (new int[][]
      {
        new []{1,3,5,7},
        new []{10,11,16,20},
        new []{23,30,34,60},
      }, 3, true);
    }
  }

  [TestCaseSource(nameof(TestCases))]
  public void Test(int[][] matrix, int target, bool expectedResult)
  {
    var sut = new Search2DMatrix();

    var result = sut.SearchMatrix(matrix, target);

    result.Should().Be(expectedResult);
  }
}