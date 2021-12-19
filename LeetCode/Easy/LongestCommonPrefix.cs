namespace LeetCode.Easy {
	public class LongestCommonPrefix {
		public static string Run(string[] strs) {
			if (strs.Length == 1) {
				return strs[0];
			}
			for (var i = 0; i < strs[0].Length; i++) {
				for (var j = 1; j < strs.Length; j++) {
					if (strs[j].Length <= i || strs[0][i] != strs[j][i]) {
						return strs[0].Substring(startIndex: 0, i);
					}
				}
			}

			return strs[0];
		}
	}
}