using System;
using System.Collections.Generic;

namespace LeetCode.Medium; 

// 71. Simplify Path https://leetcode.com/problems/simplify-path/
public class SimplifyPath {
    public string Run(string path) {
        var stack = new Stack<string>();
        foreach (string dir in path.Split("/", StringSplitOptions.RemoveEmptyEntries)) {
            if (dir != ".." && dir != "." && dir.Length > 0) {
                stack.Push(dir);
            }
            else if (stack.Count > 0 && dir == "..") {
                stack.Pop();
            }
        }
        if (stack.Count <= 0) {
            return "/";
        }

        string[] result = new string[stack.Count];
        for (var i = stack.Count - 1; i >= 0; i--) {
            result[i] = stack.Pop();
        }
    
        return "/" + string.Join("/", result);
    }
}