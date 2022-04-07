using System.Collections;

namespace LeetCode.Algorithm1.TwoPointers {
    // 19. Remove Nth Node From End of List https://leetcode.com/problems/remove-nth-node-from-end-of-list/
    public static class RemoveNthFromEnd {
        public static ListNode Run(ListNode head, int n) {
            int count = 1;
            var arrayList = new ArrayList{ head };
            ListNode next = head;
            while (next.next != null) {
                count++;
                next = next.next;
                arrayList.Add(next);
            }
            
            if (n == 1) {
                if (arrayList.Count == 1) {
                    return null;
                }
                (arrayList[count - n - 1] as ListNode).next = null;
            }
            else {
                if (arrayList.Count == n) {
                    return arrayList[1] as ListNode;
                }

                (arrayList[count - n - 1] as ListNode).next = (arrayList[count - n + 1] as ListNode);
            }
            
            return head;
        }
    }
}