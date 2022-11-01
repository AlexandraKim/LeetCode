namespace LeetCode.Easy {
    // 191. Number of 1 Bits https://leetcode.com/problems/number-of-1-bits
    public class NumberOf1Bits {
        public int HammingWeight(uint n) {
            int count = 0;
            while (n > 0) {
                if ((n&1) > (uint)1) {
                    count++;
                }

                n >>= 1;
            }

            return count;
        }
    }
}
