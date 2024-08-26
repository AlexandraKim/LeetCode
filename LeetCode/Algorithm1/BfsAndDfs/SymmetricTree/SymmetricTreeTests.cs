using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Algorithm1.BfsAndDfs.SymmetricTree;

[TestFixture]
public class SymmetricTreeTests
{
  
  private static IEnumerable<TestCaseData> TestCases
  {
    get
    {
      yield return new ( new TreeNode(1, 
          left: new TreeNode(2, left: new TreeNode(3), right: new TreeNode(4)), 
          right: new TreeNode(2, left: new TreeNode(4), right: new TreeNode(3))), 
        true);
      yield return new ( new TreeNode(1, 
          left: new TreeNode(2, right: new TreeNode(3)), 
          right: new TreeNode(2, right: new TreeNode(3))), 
        false);
      }
  }

  [TestCaseSource(nameof(TestCases))]
  public void Test(TreeNode root, bool expectedResult)
  {
    var sut = new SymmetricTree();

    var result = sut.IsSymmetric(root);

    result.Should().Be(expectedResult);
  }
}