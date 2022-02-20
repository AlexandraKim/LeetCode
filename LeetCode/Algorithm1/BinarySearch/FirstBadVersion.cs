namespace LeetCode.Algorithm1.BinarySearch {
	public static class FirstBadVersion {
		public static int Value { get; set; }

		public static int Run(int n) {
			int start = 1;
			int end = n;
			while (start < end) {
				int mid = start + (end - start) / 2;
				if (!IsBadVersion(mid)) {
					start = mid + 1;
				} else {
					end = mid;
				}
			}
			return start;
		}

		private static bool IsBadVersion(int n) {
			return n >= Value;
		}
	}
}