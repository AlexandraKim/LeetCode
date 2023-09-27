namespace LeetCode.Easy.MergeTwoLists;

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

public class Solution
{
    // 21. Merge Two Sorted Lists https://leetcode.com/problems/merge-two-sorted-lists/description/
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 is null)
        {
            return list2;
        }
        if (list2 is null)
        {
            return list1;
        }
        if (list1.val <= list2.val)
        {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }
    
        list2.next = MergeTwoLists(list1, list2.next);
        return list2;
    }
    
    // public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    // {
    //     var dummy = new ListNode();
    //     var tail = dummy;
    //     while (list1 is not null && list2 is not null)
    //     {
    //         if (list1.val < list2.val)
    //         {
    //             tail.next = list1;
    //             list1 = list1.next;
    //         }
    //         else
    //         {
    //             tail.next = list2;
    //             list2 = list2.next;
    //         }
    //
    //         tail = tail.next;
    //     }
    //
    //     if (list1 is not null)
    //     {
    //         tail.next = list1;
    //     }
    //     else if (list2 is not null)
    //     {
    //         tail.next = list2;
    //     }
    //     return dummy.next;
    // }
}