namespace LeetCode.Easy {
    public class RemoveElement {
        public int Run(int[] nums, int val) {
            int count = 0;
            for (int i = 0; i < nums.Length; i++) {
                while (nums[i] == val) {
                    if (i == nums.Length-1) {
                        nums[i] = -1000;
                    }
                    else {
                        Shift(nums, i);
                    }
                    
                    count++;
                }
            }

            return nums.Length - count;
            
            void Shift(int[]nums, int startIndex) {
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