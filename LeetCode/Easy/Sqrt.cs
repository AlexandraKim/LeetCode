namespace LeetCode.Easy {
    public class Sqrt {
        public int MySqrt(int x) {
            if (x == 1) {
                return x;
            }
            long start = 0;
            long mid = x / 2;
            long pow = mid * mid;

            // while (start * start < pow && pow < x) {
            //     if (pow > x) {
            //         mid = (start + mid) / 2;
            //         pow = mid * mid;
            //     }
            //     else if (pow < x) {
            //         start = mid;
            //         mid = start + (start / 2);
            //         pow = start * start;
            //     }
            // }
            
            while (pow > x) {
                mid /= 2;
                pow = mid * mid;
            }
        
            while (pow < x) {
                mid += mid/2;
                pow = mid * mid;
                if (pow > x) {
                    mid--;
                }
            }
            
            
            
            // while (pow < x) {
            //     mid++;
            //     pow = mid * mid;
            //     if (pow > x) {
            //         mid--;
            //     }
            // }
          
            return (int)mid;
        }
    }
}