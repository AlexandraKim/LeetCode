using System;
using System.Collections.Generic;

namespace LeetCode.Easy.MaximumStrongPairXORI;
// 2932. Maximum Strong Pair XOR I https://leetcode.com/problems/maximum-strong-pair-xor-i/description/
public class MaximumStrongPairXORI
{
  public int MaximumStrongPairXor(int[] nums)
  {
    Array.Sort(nums);
    int max = 0;
    foreach (var x in nums)
    {
      foreach (var y in nums)
      {
        if (IsStrongPair(x, y))
        {
          max = Math.Max(max, x ^ y);
        }
      }
    }
    
    return max;
  }

  private bool IsStrongPair(int x, int y)
  {
    return Math.Abs(x - y) <= Math.Min(x, y);
  }
}