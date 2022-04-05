using System.Linq;

namespace LeetCode.Algorithm1.TwoPointers {
    // 557. Reverse Words in a String III https://leetcode.com/problems/reverse-words-in-a-string-iii/
    public static class ReverseWords {
        public static string Run(string s) {
            string[] words = s.Split(' ');
            string result = string.Empty;
            for (int i = 0; i < words.Length; i++) {
                result += Reverse(words[i].ToCharArray());
                result += " ";
            }

            return result.TrimEnd();
        }

        private static string Reverse(char[] word) {
            int end = word.Length - 1;
            for (int j = 0; j < word.Length/2; j++) {
                (word[j], word[end]) = (word[end], word[j]);
                end--;
            }

            return new string(word);
        }
    }
}