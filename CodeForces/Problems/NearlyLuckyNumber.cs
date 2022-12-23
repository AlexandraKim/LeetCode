using System;

namespace CodeForces.Problems {
    public class NearlyLuckyNumber : IProblem{
        public void Run() {
            string ss = Console.ReadLine();
            var numbers = ss.ToCharArray();
            int countLucky = 0;
            for (int i = 0; i < numbers.Length; i++) {
            	if (numbers[i] == '4' || numbers[i] == '7') {
            		countLucky++;
            	}
            }
            
            if (countLucky == 7 || countLucky == 4) {
            	Console.WriteLine("YES");
            }
            else {
            	Console.WriteLine("NO");
            }
        }
    }
}