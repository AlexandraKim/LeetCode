using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("CodeForcesTests")]
namespace CodeForces.Problems {
    // https://codeforces.com/gym/411507/problem/D
    public class Dragons : IProblem {
        public void Run() {
            var dragons = new List<(int strength, int bonus)>();
            var temp = Console.ReadLine();
		
            var tss = temp.Split(" ");
            int kStrength = int.Parse(tss[0]);
            int dragonsCount = int.Parse(tss[1]);
            for (int i = 0; i < dragonsCount; i++) {
                temp = Console.ReadLine();
                string[] drag = temp.Split(" ");
                dragons.Add((int.Parse(drag[0]), int.Parse(drag[1])));
            }

            foreach (var dragon in dragons.OrderBy(x => x.strength)) {
                if (dragon.strength >= kStrength) {
                    Console.WriteLine("NO");
                    return;
                }
                kStrength += dragon.bonus;
            }
            Console.WriteLine("YES");
        }
    }
}