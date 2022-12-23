using System;
using System.Runtime.CompilerServices;
using CodeForces.Problems;

[assembly: InternalsVisibleTo("CodeForcesTests")]
namespace CodeForces {
    internal static class Program {

        public static IProblem Problem { get; set; }
        public static void Main(string[] args) {
            Problem.Run();
        }
    }
}