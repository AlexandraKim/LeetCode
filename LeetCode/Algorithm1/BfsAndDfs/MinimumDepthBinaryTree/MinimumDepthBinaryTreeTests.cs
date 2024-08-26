using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Algorithm1.BfsAndDfs.MinimumDepthBinaryTree;


public class MinimumDepthBinaryTreeTests
{
  private static IEnumerable<TestCaseData> TestCases
  {
    get
    {
      yield return new ( new TreeNode(3, 
          left: new TreeNode(9), 
          right: new TreeNode(20, left: new TreeNode(15), right: new TreeNode(7))), 
        2);
      yield return new ( new TreeNode(2, 
          right: new TreeNode(3, right: new TreeNode(4, right: new TreeNode(5, right: new TreeNode(6))))), 
        5);
    }
  }

  [TestCaseSource(nameof(TestCases))]
  public void Test(TreeNode root, int expectedResult)
  {
    var sut = new MinimumDepthBinaryTree();

    var result = sut.MinDepth(root);

    result.Should().Be(expectedResult);
  }
}