namespace LeetCode.Easy.SameTree;

public class SameTree
{
  // 100. Same Tree https://leetcode.com/problems/same-tree/description/
  public bool IsSameTree(TreeNode p, TreeNode q)
  {
    if (p is null || q is null)
    {
      return p is null && q is null;
    }

    if (p.val != q.val)
    {
      return false;
    }
    bool left = IsSameTree(p?.left, q?.left);
    bool right = IsSameTree(p?.right, q?.right);

    return left && right;
  }
}