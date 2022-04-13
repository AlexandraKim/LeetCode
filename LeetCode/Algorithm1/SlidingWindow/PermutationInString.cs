using System.Linq;

namespace LeetCode.Algorithm1.SlidingWindow {
    // 567. Permutation in String https://leetcode.com/problems/permutation-in-string/
    public static class PermutationInString {
        public static bool CheckInclusion(string s1, string s2) {
            if (s1.Length > s2.Length) {
                return false;
            }

            var h = s1.ToCharArray()
                .GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count());
            var window = s2.Substring(0, s1.Length)
                .ToCharArray()
                .GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count());

            for (var i = 0; i < s2.Length; i++) {
                if (h.Keys.All(x => window.Keys.Contains(x)) && h.All(x => window[x.Key] == x.Value)) {
                    return true;
                }

                if (!IsWindowInRange(i)) {
                    return false;
                }

                var start = s2[i];
                var end = s2[i + s1.Length];
                window[start]--;
                if (window.ContainsKey(end)) {
                    window[end]++;
                }
                else {
                    window.Add(end, 1);
                }
            }

            return false;

            bool IsWindowInRange(int startingIndex) {
                return s1.Length + startingIndex < s2.Length;
            }
        }
    }
}