using System;

namespace LeetCode.Algorithm1.BinarySearch.GuessNumber;
// 374. Guess Number Higher or Lower https://leetcode.com/problems/guess-number-higher-or-lower
public class GuessNumberSolution
{
  public int GuessNumber(int n)
  {
    var start = 0;
    var end = n;
    while (start <= end)
    {
      int mid = start + (end - start) / 2;
      int t = guess(mid);
      if (t == -1)
      {
        end = mid;
      }
      else if (t == 1)
      {
        start = mid + 1;
      }
      else
      {
        return mid;
      }
    }

    return 0;
  }

  private int guess(int n)
  {
    return 2;
  }
}