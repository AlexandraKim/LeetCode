namespace LeetCode.Medium.ContainerWithMostWater;

public class ContainerWithMostWater
{
  // 11. Container With Most Water https://leetcode.com/problems/container-with-most-water/description/
  public int MaxArea(int[] height)
  {
    int start = 0;
    int end = height.Length - 1;

    int maxArea = 0;

    while (start < end)
    {
      int area = 0;
      if (height[start] <= height[end])
      {
        area = height[start] * (end - start);
        start++;
      } else if (height[start] == height[end])
      {
        area = height[start] * (end - start);
        start++;
        end--;
      } else if (height[start] > height[end])
      {
        area = height[end] * (end - start);
        end--;
      }

      maxArea = maxArea > area ? maxArea : area;

    }

    return maxArea;
  }
}