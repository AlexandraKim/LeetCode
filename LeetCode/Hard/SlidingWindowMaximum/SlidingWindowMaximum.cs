using System.Collections.Generic;

namespace LeetCode.Hard.SlidingWindowMaximum;

// 239. Sliding Window Maximum https://leetcode.com/problems/sliding-window-maximum
public class SlidingWindowMaximum
{
  public int[] MaxSlidingWindow(int[] nums, int k) {
    if (nums.Length == 1 || k == 1)
    {
      return nums;
    }

    var window = new LinkedList<(int index, int value)>();
    var windowMaximum = new List<int>();
    int start = 0;
    int end = 0;
    while (end < nums.Length)
    {
      while (window.Last?.Value.value < nums[end])
      {
        window.RemoveLast(); 
      }

      window.AddLast((index: end, value: nums[end]));
      if (end - start == k -1)
      {
        windowMaximum.Add(window.First.Value.value);
        if (start >= window.First.Value.index)
        {
          window.RemoveFirst();
        }
        start++;
        end++;
      }
      else 
      {
        end++;
      }
    }

    return windowMaximum.ToArray();
  }
}