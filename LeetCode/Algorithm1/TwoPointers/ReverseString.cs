namespace LeetCode.Algorithm1.TwoPointers {
    // 344. Reverse String https://leetcode.com/problems/reverse-string/
    public static class ReverseString {
        public static void Run(char[] s) {
            int end = s.Length - 1;
            for (int i = 0; i < s.Length/2; i++) {
                (s[i], s[end]) = (s[end], s[i]);
                end--;
            }
            // Swap(s,  0, s.Length - 1);
        }

        private static void Swap(char[] s, int start, int end) {
            while (true) {
                (s[start], s[end]) = (s[end], s[start]);
                start++;
                end--;
                if (start < end) {
                    continue;
                }

                break;
            }
        }
    }
}