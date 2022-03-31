using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithm1.TwoPointers {
    public class RotateArray {
        public static int[] Run(int[] nums, int k) {
            var linkedList = new LinkedList<int>(nums);
            LinkedListNode<int>? t;
            for (int i = 0; i < k; i++) {
                t = linkedList.Last;
                linkedList.RemoveLast();
                linkedList.AddFirst(t);
            }

            t = linkedList.First;
            for (int i = 0; i < nums.Length - 1; i++) {
                nums[i] = t.Value;
                t = t.Next;
            }

            nums[nums.Length - 1] = t.Value;
            
            return linkedList.ToArray();
        }
    }
}