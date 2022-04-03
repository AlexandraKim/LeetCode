namespace LeetCode.Algorithm1.TwoPointers {
    // 167. Two Sum II - Input Array Is Sorted https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
    public static class TwoSumInputArrayIsSorted {
        public static int[] Run(int[] numbers, int target) {
            for (int i = 0; i < numbers.Length; i++) {
                int complement = target - numbers[i];
                int searchResult = BinarySearch(numbers, complement, complement == numbers[i] ? i + 1 : i);
                if (searchResult != -1) {
                    return new int[] { i + 1, searchResult + 1 };
                }
            }
            
            return new int[] { };
        }

        private static int BinarySearch(int[] numbers, int target, int start) {
            int end = numbers.Length - 1;
            int mid = (start + end) / 2;
            
            while (start != mid) {
                if (numbers[mid] > target) {
                    end = mid;
                    mid = end / 2;
                }
                else {
                    start = mid;
                    mid = (start + end) / 2;
                }
            }

            if (numbers[mid] == target) {
                return mid;
            }
            if (numbers[end] == target) {
                return end;
            }
            return -1;
        }
    }
}