using System;
using System.Linq;

namespace LeetCode.Easy {
    // 58. Length of Last Word https://leetcode.com/problems/length-of-last-word/
    public class LengthOfLastWord {
        public int Run(string s) {
            var words = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return words.Last().Length;
        }
    }
}