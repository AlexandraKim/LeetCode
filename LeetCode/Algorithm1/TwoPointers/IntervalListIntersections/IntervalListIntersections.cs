using System;
using System.Collections.Generic;

namespace LeetCode.Algorithm1.TwoPointers.IntervalListIntersections;
// 986. Interval List Intersections https://leetcode.com/problems/interval-list-intersections/description/
public class IntervalListIntersections
{
  public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
  {
    if (firstList.Length == 0 || firstList.Length == 0)
    {
      return new int[][] { };
    }
    int index1 = 0;
    int index2 = 0;
    List<int[]> result = new List<int[]>();
    while (index1 < firstList.Length && index2 < secondList.Length)
    {
      int intervalStart = Math.Max(firstList[index1][0], secondList[index2][0]);
      int intervalEnd = Math.Min(firstList[index1][1], secondList[index2][1]);
      if (intervalStart <= intervalEnd)
      {
        result.Add(new []{intervalStart, intervalEnd});
      }

      if (firstList[index1][1] > secondList[index2][1])
      {
        index2++;
      }
      else
      {
        index1++;
      }
    }

    return result.ToArray();
  }
}