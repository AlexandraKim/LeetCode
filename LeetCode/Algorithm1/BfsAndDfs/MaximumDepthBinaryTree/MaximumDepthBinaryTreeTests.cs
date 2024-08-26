using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Algorithm1.BfsAndDfs.MaximumDepthBinaryTree;

public class MaximumDepthBinaryTreeTests
{
  private static IEnumerable<TestCaseData> TestCases
  {
    get
    {
      yield return new ( new TreeNode(3, 
          left: new TreeNode(9), 
          right: new TreeNode(20, left: new TreeNode(15), right: new TreeNode(7))), 
        3);
      yield return new ( new TreeNode(1, 
          right: new TreeNode(2)), 
        2);
    }
  }

  [TestCaseSource(nameof(TestCases))]
  public void Test(TreeNode root, int expectedResult)
  {
    var sut = new MaximumDepthBinaryTree();

    var result = sut.MaxDepth(root);

    result.Should().Be(expectedResult);
  }
}