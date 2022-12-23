using System;

namespace CodeForces.Problems {
    public class WrongSubtraction : IProblem {
        public void Run() {
            string ss = Console.ReadLine();
            var strings = ss.Split(" ");
            int.TryParse(strings[1], out var n);
            int.TryParse(strings[0], out var number);
            for (int i = 0; i < n; i++) {
            	if (number % 10 != 0) {
            		number--;
            	}
            	else {
            		number /= 10;
            	}
            }
            Console.WriteLine(number);
        }
    }
}