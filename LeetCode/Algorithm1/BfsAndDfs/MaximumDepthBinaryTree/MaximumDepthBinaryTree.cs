using System;

namespace LeetCode.Algorithm1.BfsAndDfs.MaximumDepthBinaryTree;
// 104. Maximum Depth of Binary Tree https://leetcode.com/problems/maximum-depth-of-binary-tree
public class MaximumDepthBinaryTree
{
  public int MaxDepth(TreeNode root)
  {
    return root is null ? 0 : IsLeaf(root, 0);
  }

  private int IsLeaf(TreeNode root, int depth)
  {
    depth++;
    if (root.left is null && root.right is null)
    {
      return depth;
    }

    int left = root.left is not null ? IsLeaf(root.left, depth) : int.MinValue;
    int right = root.right is not null ? IsLeaf(root.right, depth) : int.MinValue;

    depth = Math.Max(left, right);

    return depth;
  }
}