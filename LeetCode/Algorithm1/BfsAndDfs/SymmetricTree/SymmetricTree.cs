namespace LeetCode.Algorithm1.BfsAndDfs.SymmetricTree;

// 101. Symmetric Tree https://leetcode.com/problems/symmetric-tree/
public class SymmetricTree
{
  public bool IsSymmetric(TreeNode root)
  {
    return IsSymmetric(root.left, root.right);;
  }

  private bool IsSymmetric(TreeNode p, TreeNode q)
  {
    if (p is null && q is null)
    {
      return true;
    }

    if (p is null || q is null)
    {
      return false;
    }

    bool left = IsSymmetric(p.left, q.right);
    bool right = IsSymmetric(p.right, q.left);

    return p.val == q.val && left && right;
  }
}