using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy {
	public static class RomanToInt {
		public static int Run(string s) {
			var intByRoman = new Dictionary<char, int> {
				[key: 'I'] = 1,
				[key: 'V'] = 5,
				[key: 'X'] = 10,
				[key: 'L'] = 50,
				[key: 'C'] = 100,
				[key: 'D'] = 500,
				[key: 'M'] = 1000
			};

			var intsByPrefixes = new Dictionary<char, char[]> {
				[key: 'I'] = new[] { 'V', 'X' },
				[key: 'X'] = new[] { 'L', 'C' },
				[key: 'C'] = new[] { 'D', 'M' }
			};

			var res = 0;
			for (var i = 0; i < s.Length; i++) {
				char curr = s[i];
				if (intsByPrefixes.ContainsKey(curr) && IsLastButOneChar(i, s)) {
					char nextNum = s[i + 1];
					if (intsByPrefixes[curr].Any(x => x == nextNum)) {
						res += intByRoman[nextNum] - intByRoman[curr];
						i++;
					} else {
						res += intByRoman[curr];
					}
				} else {
					res += intByRoman[curr];
				}
			}
			return res;
		}

		private static bool IsLastButOneChar(int i, string s) {
			return i <= s.Length - 2;
		}
	}
}