using System.Collections.Generic;
using FluentAssertions;
using LeetCode.Algorithm1.BfsAndDfs;
using NUnit.Framework;

namespace LeetCode.UnitTests.Algorithm1.BfsAndDfs {
    [TestFixture]
    public class MergeTwoBinaryTreesTests {
        [Test]
        public void Test() {
            var root1Node3 = new TreeNode(3, new TreeNode(5));
            var root1 = new TreeNode(1, root1Node3, new TreeNode(2));
            
            var root2Node1 = new TreeNode(1, null, new TreeNode(4));
            var root2Node3 = new TreeNode(3, null, new TreeNode(7));
            var root2 = new TreeNode(2, root2Node1, root2Node3);
            
            var expectedResultNode4 = new TreeNode(4, new TreeNode(5), new TreeNode(4));
            var expectedResultNode5 = new TreeNode(5, null, new TreeNode(7));
            var expectedResult = new TreeNode(3, expectedResultNode4, expectedResultNode5);
            
            MergeTwoBinaryTrees.MergeTrees(root1, root2).Should().BeEquivalentTo(expectedResult);
        }
        
        [Test]
        public void Test2() {
            TreeNode root1 = null;
            
            var root2 = new TreeNode(1);
            
            var expectedResult = new TreeNode(1);
            
            MergeTwoBinaryTrees.MergeTrees(root1, root2).Should().Be(expectedResult);
        }
        
        // [Test]
        // public void Test3() {
        //     var root1Node3 = new TreeNode(3, new TreeNode(5));
        //     var root1 = new TreeNode(1, root1Node3, new TreeNode(2));
        //     
        //     var root2Node1 = new TreeNode(1, null, new TreeNode(4));
        //     var root2Node3 = new TreeNode(3, null, new TreeNode(7));
        //     var root2 = new TreeNode(2, root2Node1, root2Node3);
        //     
        //     var expectedResultNode4 = new TreeNode(4, new TreeNode(5), new TreeNode(4));
        //     var expectedResultNode5 = new TreeNode(5, null, new TreeNode(7));
        //     var expectedResult = new TreeNode(3, expectedResultNode4, expectedResultNode5);
        //     
        //     MergeTwoBinaryTrees.MergeTrees(root1, root2).Should().Be(expectedResult);
        // }
    }
}