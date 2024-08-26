using System;

namespace LeetCode.Algorithm1.BfsAndDfs.MinimumDepthBinaryTree;
// 111. Minimum Depth of Binary Tree https://leetcode.com/problems/minimum-depth-of-binary-tree
public class MinimumDepthBinaryTree
{
  public int MinDepth(TreeNode root)
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

    int left = root.left is not null ? IsLeaf(root.left, depth) : int.MaxValue;
    int right = root.right is not null ? IsLeaf(root.right, depth) : int.MaxValue;

    depth = Math.Min(left, right);

    return depth;
  }
}