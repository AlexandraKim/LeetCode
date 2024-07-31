using System;

namespace LeetCode.Easy.IntersectionOfTwoArrays;

public class IntersectOfTwoArrays
{
  public int[] Intersect(int[] nums1, int[] nums2) {
    Array.Sort(nums1);
    Array.Sort(nums2);
        
    int i = 0;
    int j = 0;
    int k = 0;
    while (nums1.Length > i && nums2.Length > j){
      if(nums1[i] < nums2[j]){
        i++;
      } else if(nums1[i] > nums2[j]) {
        j++;
      } else if(nums1[i] == nums2[j]) {
        nums1[k] = nums2[j];
        j++;
        i++;
        k++;
      }
    }
        
    Array.Resize(ref nums1, k);
        
    return nums1;
  }
}