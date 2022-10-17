using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithm1.BfsAndDfs {
    // 116. Populating Next Right Pointers in Each Node https://leetcode.com/problems/populating-next-right-pointers-in-each-node/
    public class PopulatingNextRightPointersInEachNode {
        public Node Connect(Node root) {
            if (root is null) {
                return null;
            }
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
           
            List<Node> nodes = new List<Node>();
            while (q.Any()) {
                var currNode = q.Dequeue();
                nodes.Add(currNode);
                
                if (currNode.left is not null) {
                    q.Enqueue(currNode.left);
                }

                if (currNode.right is not null) {
                    q.Enqueue(currNode.right);
                }
            }
            int nextPowerOfTwo = 0;
            int count = 1;
            for (int i = 0; i < nodes.Count; i++) {
                if (nextPowerOfTwo == i) {
                    nextPowerOfTwo = i + (int)Math.Pow(2, count);
                    count++;
                    continue;
                }

                if (i + 1 < nodes.Count) {
                    nodes[i].next = nodes[i+1];
                }
            }
            return root;
        }
    }
    
    public class Node {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() {}

        public Node(int _val) {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next) {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}