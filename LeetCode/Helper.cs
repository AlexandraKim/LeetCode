namespace LeetCode {
    public static class Helper {
        public static int DumpValue = -1000;
        public static void Shift(int[]nums, int startIndex) {
            int j = startIndex + 1;
            for (int k = startIndex; k < nums.Length-1; k++) {
                nums[k] = nums[j];
                nums[j] = DumpValue;
                j++;
                    
            }
        }
    }
}