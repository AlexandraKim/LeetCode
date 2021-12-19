namespace LeetCode.Easy.BinarySearch {
	public class BinarySearch {
		public static int Search(int[] nums, int target) {
			if (nums.Length == 0) {
				return -1;
			}
			int start = 0;
			int end = nums.Length - 1;
			int mid = GetMidIndex(start, end);
			while (start != mid) {
				if (nums[mid] > target) {
					end = mid;
					mid = GetMidIndex(start, end);
				} else {
					start = mid;
					mid = GetMidIndex(start, end);
				}
			}
			if (nums[mid] == target) {
				return mid;
			}
			if (nums[end] == target) {
				return end;
			}
			return -1;
		}

		private static int GetMidIndex(int start, int end) {
			return (start + end) / 2;
		}
	}
}