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
}