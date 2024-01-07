namespace LeetCode;

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

    public static ListNode CreateListNodes(params int[] nums)
    {
        return CreateRecursive(nums, 0);
    }

    private static ListNode CreateRecursive(int[] nums, int i)
    {
        if (i == nums.Length - 1)
        {
            return new ListNode(nums[i]);
        }

        return new ListNode(nums[i], CreateRecursive(nums, i + 1));
    }
}