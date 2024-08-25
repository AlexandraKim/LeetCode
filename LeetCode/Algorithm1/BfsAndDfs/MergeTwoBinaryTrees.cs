using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithm1.BfsAndDfs {
    // 617. Merge Two Binary Trees https://leetcode.com/problems/merge-two-binary-trees/
    public class MergeTwoBinaryTrees {
        public static TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
            if (root1 is null && root2 is null) {
                return null;
            }
            TreeNode result = new TreeNode();
            Queue<(TreeNode treeNode1, TreeNode treeNode2, TreeNode resultTreeNode)> q = 
                new Queue<(TreeNode treeNode1, TreeNode treeNode2, TreeNode resultTreeNode)>();
            result.val += root1?.val ?? 0;
            result.val += root2?.val ?? 0;
            q.Enqueue((root1, root2, result));
        
            while (q.Any()) {
                (TreeNode treeNode1, TreeNode treeNode2, TreeNode resultTreeNode) = q.Dequeue();
                if (treeNode1?.left != null || treeNode2?.left != null) {
                    resultTreeNode.left = new TreeNode();
                    if (treeNode1 is {left: { }}) {
                        resultTreeNode.left.val += treeNode1.left.val;
                    }
                    if (treeNode2 is {left: { }}) {
                        resultTreeNode.left.val += treeNode2.left.val;
                    }
                    q.Enqueue((treeNode1?.left, treeNode2?.left, resultTreeNode.left));
                }
            
                if (treeNode1?.right != null || treeNode2?.right != null) {
                    resultTreeNode.right = new TreeNode();
                    if (treeNode1 is {right: { }}) {
                        resultTreeNode.right.val += treeNode1.right.val;
                    }

                    if (treeNode2 is {right: { }}) {
                        resultTreeNode.right.val += treeNode2.right.val;
                    }

                    q.Enqueue((treeNode1?.right, treeNode2?.right, resultTreeNode.right));
                }
            }
        
            return result;
        }
    }
}