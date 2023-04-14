using System.Collections.Generic;

namespace LeetCode.Medium; 
// 946. Validate Stack Sequences https://leetcode.com/problems/validate-stack-sequences/
public class ValidateStackSequences {
    public bool Run(int[] pushed, int[] popped) {
        var stack = new Stack<int>();
        var indexOfPopped = 0;
        for (int i = 0; i < pushed.Length; i++) {
            stack.Push(pushed[i]);
            
            while (stack.TryPeek(out int top) && top == popped[indexOfPopped]) {
               stack.Pop();
                indexOfPopped++;
            }
            
        }

        return stack.Count == 0;

    }
}