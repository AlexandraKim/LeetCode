using System.Collections;

namespace LeetCode.Algorithm1.TwoPointers {
    // 876. Middle of the Linked List https://leetcode.com/problems/middle-of-the-linked-list/
    public static class MiddleOfLinkedList {
        public static ListNode Run(ListNode head) {
            int count = 1;
            var arrayList = new ArrayList{ head };
            ListNode next = head;
            while (next.next != null) {
                count++;
                next = next.next;
                arrayList.Add(next);
            }

            return arrayList[count / 2] as ListNode;
        }
    }

    // Definition for singly-linked list.
    public class ListNode {
        public ListNode next;
        public int val;

        public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }
    }
}