namespace LeetCode.Easy {
	public static class FirstBadVersion {
		public static int Value { get; set; }

		public static int Run(int n) {
			int start = 0;
			int end = n;
			int mid = GetMid(start, end);
			while (start != mid) {
				if (!IsBadVersion(mid)) {
					if (end + 1 == mid) {
						return mid;
					}
					start = mid;
					mid = GetMid(start, end);
				} else {
					if (start + 1 == mid) {
						return mid;
					}
					end = mid;
					mid = GetMid(start, end);
				}
			}
			if (IsBadVersion(start)) {
				return start;
			}
			if (IsBadVersion(end)) {
				return end;
			}
			return mid;
		}

		private static bool IsBadVersion(int n) {
			return n >= Value;
		}

		private static int GetMid(int start, int end) {
			return (start + end) / 2;
		}
	}
}