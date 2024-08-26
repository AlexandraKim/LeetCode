using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Easy.SameTree;

[TestFixture]
public class SameTreeTests
{
  
  private static IEnumerable<TestCaseData> TestCases
  {
    get
    {
      yield return new ( new TreeNode(1, left: new TreeNode(2), right: new TreeNode(3)),
        new TreeNode(1, left: new TreeNode(2), right: new TreeNode(3)), true);
      yield return new ( new TreeNode(1, left: new TreeNode(2)),
        new TreeNode(1, right: new TreeNode(2)), false);
      yield return new ( new TreeNode(1, left: new TreeNode(2), right: new TreeNode(1)),
        new TreeNode(1, left: new TreeNode(1), right: new TreeNode(2)), false);
    }
  }

  [TestCaseSource(nameof(TestCases))]
  public void Test(TreeNode p, TreeNode q, bool expectedResult)
  {
    var sut = new SameTree();

    var result = sut.IsSameTree(p, q);

    result.Should().Be(expectedResult);
  }
}