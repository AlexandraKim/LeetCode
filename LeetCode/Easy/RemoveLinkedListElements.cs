namespace LeetCode.Easy {
	// 203. Remove Linked List Elements https://leetcode.com/problems/remove-linked-list-elements/description/
    public class RemoveLinkedListElements {
        public class ListNode {
        	public int val;
        	public ListNode next;
        	public ListNode(int val=0, ListNode next=null) {
        		this.val = val;
        		this.next = next;
        	}
        }

        
        public ListNode RemoveElements(ListNode head, int val) {
	        if (head is null) {
		        return null;
	        }

	        var node = new ListNode {next = head};
	        ListNode cur = node;
            while (cur.next is not null) {
	            if (cur.next.val == val) {
		            cur.next = cur.next.next ?? null;
	            }
	            else {
		            cur = cur.next;
	            }
            } 
        	return node.next;
        }
    }
}