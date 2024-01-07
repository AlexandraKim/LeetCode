namespace LeetCode.Hard.MergeKLists;

// 23. Merge k Sorted Lists https://leetcode.com/problems/merge-k-sorted-lists
public class MergeKLists
{
    public ListNode Merge(ListNode[] lists)
    {
        if (lists.Length == 0)
        {
            return null;
        }
        return Select(0, lists.Length, lists);
    }

    private ListNode Select(int leftIndex, int rightIndex, ListNode[] lists)
    {
        if (rightIndex - leftIndex == 1)
        {
            return  lists[leftIndex];
        }

        int mid = FindMidIndex(leftIndex, rightIndex);
        var left = Select(leftIndex, mid, lists);
        var right = Select(mid, rightIndex, lists);

        return MergeNodes(left, right);
    }

    private int FindMidIndex(int left, int right)
    {
        return (left + right) / 2;
    }
    
    public ListNode MergeNodes(ListNode left, ListNode right)
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