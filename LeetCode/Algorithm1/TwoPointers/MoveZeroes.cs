using System.Collections.Generic;

namespace LeetCode.Algorithm1.TwoPointers {
    // 283. Move Zeroes https://leetcode.com/problems/move-zeroes/
    public static class MoveZeroes {
        public static int[] Run(int[] nums) {
            var indices = new Queue<int>();
            for (int i = 0; i < nums.Length; i++) {
                indices.Enqueue(i);
                if (nums[i] == 0) {
                    continue;
                }

                nums[indices.Dequeue()] = nums[i];
            }

            while (indices.TryDequeue(out int index)) {
                nums[index] = 0;
            }

            return nums;
        }
    }
}