using System;

namespace LeetCode.Easy {
    // 231. Power of Two https://leetcode.com/problems/power-of-two/description/
    public class PowerOfTwo {
        public bool IsPowerOfTwo(int n) {
            if (n == 0) {
                return false;
            }
            return Math.Floor(Math.Log2(n)) == Math.Ceiling(Math.Log2(n));
        }
        // public bool IsPowerOfTwo(int n) {
        //     if (n == 0) {
        //         return false;
        //     }
        //     if (n == 1) {
        //         return true;
        //     }
        //     return n % 2 == 0 && IsPowerOfTwo(n / 2);
        // }
    }
}