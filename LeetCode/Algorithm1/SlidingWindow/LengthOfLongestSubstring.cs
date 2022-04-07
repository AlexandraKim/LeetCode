using System.Collections;
using System.Linq;

namespace LeetCode.Algorithm1.SlidingWindow {
    // 3. Longest Substring Without Repeating Characters https://leetcode.com/problems/longest-substring-without-repeating-characters/
    public static class LengthOfLongestSubstring {
        public static int Run(string s) {
            int max = 0;
            string t = string.Empty;
            for (int i = 0; i < s.Length; i++) {
                if (t.Contains(s[i])) {
                    t = t.Substring(t.IndexOf(s[i]) + 1);
                }
                t += s[i];
                max = t.Length > max ? t.Length : max;
            }
            return max;
        }
    }
}