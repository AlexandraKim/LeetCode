namespace LeetCode.Easy {
    // 26. Remove Duplicates from Sorted Array https://leetcode.com/problems/remove-duplicates-from-sorted-array
    public class RemoveDuplicatesFromSortedArray {
        public static int EmptyCell = -1000;
        public int RemoveDuplicates(int[] nums) {
            for (int i = 0; i < nums.Length; i++) {
                int j = i + 1;
                if (j < nums.Length) {
                    while (nums[i] == nums[j]) {
                        Shift(i);
                        if (nums[j] == EmptyCell) {
                            break;
                        }
                    }
                }
            }
            int count = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] > EmptyCell) {
                    count++;
                }
                else {
                    return count;
                }
            }

            return count;

            void Shift(int startIndex) {
                int j = startIndex + 1;
                for (int k = startIndex; k < nums.Length-1; k++) {
                    nums[k] = nums[j];
                    nums[j] = -1000;
                    j++;
                    
                }
            }
        }
    }
}