using System.Collections.Generic;

namespace LeetCode.Medium;

// 2390. Removing Stars From a String https://leetcode.com/problems/removing-stars-from-a-string/
public class RemovingStarsFromString {
    public string RemoveStars(string s) {
        var stack = new Stack<char>();
        for (var i = 0; i < s.Length; i++) {
            if (s[i] == '*') {
                stack.Pop();
            }
            else {
                stack.Push(s[i]);
            }
        }
    
        if (stack.Count <= 0) {
            return string.Empty;
        }
    
        var result = new char[stack.Count];
        for (var i = stack.Count - 1; i >= 0; i--) {
            result[i] = stack.Pop();
        }
    
        return string.Concat(result);
    }
}