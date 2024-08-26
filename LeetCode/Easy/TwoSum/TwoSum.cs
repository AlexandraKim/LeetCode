using System.Collections.Generic;

namespace LeetCode.Easy.TwoSum;
// 1. Two Sum https://leetcode.com/problems/two-sum/description/
public class TwoSum
{
  public int[] Run(int[] nums, int target) {
    Dictionary<int, int> d = new Dictionary<int, int>();
    for(int i = 0; i < nums.Length; i++) {
      int complement = target - nums[i];
      if(d.ContainsKey(complement)) {
        return new int[]{d[complement], i};
      }

      if (!d.ContainsKey(nums[i])) {
        d.Add(nums[i], i);
      }
    }
             
    return new int[]{};
  }
}