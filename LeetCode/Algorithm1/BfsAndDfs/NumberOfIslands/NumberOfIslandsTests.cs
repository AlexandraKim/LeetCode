using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Algorithm1.BfsAndDfs.NumberOfIslands;

[TestFixture]
public class NumberOfIslandsTests
{
  private static IEnumerable<TestCaseData> TestCases { get {
    yield return new TestCaseData(new char[][] {
        new char[] {'1','1','1','1','0'},
        new char[] {'1','1','0','1','0'},
        new char[] {'1','1','0','0','0'},
        new char[] {'0','0','0','0','0'},
      },
      1);
    yield return new TestCaseData(new char[][] {
      new[] {'1','1','0','0','0'},
      new[] {'1','1','0','0','0'},
      new[] {'0','0','1','0','0'},
      new[] {'0','0','0','1','1'},
    }, 3);
    
  }}
        
  [TestCaseSource(nameof(TestCases))]
  public void Test(char[][] matrix, int expectedResult)
  {
    var sut = new NumberOfIslands();
    sut.NumIslands(matrix)
      .Should()
      .Be(expectedResult);
  }
}