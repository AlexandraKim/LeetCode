using System.Collections.Generic;

namespace LeetCode.Easy {
	public class ValidParentheses {
		public static bool IsValid(string s) {
			if (s.Length == 1) {
				return false;
			}
			var brackets = new Dictionary<char, char> {
				[key: '}'] = '{',
				[key: ')'] = '(',
				[key: ']'] = '['
			};
			var stack = new Stack<char>();
			foreach (char t in s) {
				if (t == '{' || t == '[' || t == '(') {
					stack.Push(t);
				} else if (t == '}' || t == ']' || t == ')') {
					if (!stack.TryPop(out char result) || result != brackets[t]) {
						return false;
					}
				}
			}

			return stack.Count == 0;
		}
	}
}