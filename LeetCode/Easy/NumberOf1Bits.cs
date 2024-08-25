namespace LeetCode.Easy {
    // 191. Number of 1 Bits https://leetcode.com/problems/number-of-1-bits
    public class NumberOf1Bits {
        public int HammingWeight(uint n) {
            int ans = 0;
            while(n > 0)
            {
                if(n%2==1)ans++;
                n /= 2;
            }
            return ans;
        }
    }
}
