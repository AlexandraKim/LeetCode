namespace LeetCode.Medium.SortList;

// 148. Sort List https://leetcode.com/problems/sort-list/description/
public class SortList
{
    public ListNode Sort(ListNode head)
    {
        if (head?.next is null)
        {
            return head;
        }
        
        ListNode mid = FindMid(head);
        mid = SplitIntoTwoHalves(mid);
        
        
        var left = Sort(head);
        var right = Sort(mid);
        
        return Merge(left, right);
    }
    public ListNode SplitIntoTwoHalves(ListNode mid)
    {
        var temp = mid.next;
        mid.next = null;
        mid = temp;
        return mid;
    }
    
    public ListNode FindMid(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;
        while (slow.next is not null && fast.next is not null && fast.next.next is not null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }

    public ListNode Merge(ListNode left, ListNode right)
    {
        ListNode dummy = new ListNode();
        ListNode tail = dummy;
     
        while (left is not null && right  is not null)
        {
            if (left.val < right.val)
            {
                tail.next = left;
                left = left.next;
            }
            else
            {
                tail.next = right;
                right = right.next;
            }

            tail = tail.next;
        }
        
        if (left is not null)
        {
            tail.next = left;
        }

        if (right is not null)
        {
            tail.next = right;
        }
        return dummy.next;
    }
}

// Definition for singly-linked list.
public class ListNode
{
    public ListNode next;
    public int val;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}