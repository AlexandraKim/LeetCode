using System;
using System.Collections.Generic;

namespace CodeForces.Problems {
    public class Team : IProblem {
        public void Run() {
            Queue<string> lines = new Queue<string>();
            string temp = Console.ReadLine();
            do {
            	lines.Enqueue(temp);
            	temp = Console.ReadLine();
            } while (!string.IsNullOrEmpty(temp));


            int.TryParse(lines.Dequeue(), out int _);
            int countProblems = 0;
            while (lines.TryDequeue(out string line)) {
            	var ss = line.Split(" ");
            	var countOpinions = 0;
            	for (var i = 0; i < 3; i++) {
            		if (int.TryParse(ss[i], out int opinion)) {
            			countOpinions += opinion;
            		}
            	}
            
            	if (countOpinions >= 2) {
            		countProblems++;
            	}
            }
            
            Console.WriteLine(countProblems);
        }
    }
}