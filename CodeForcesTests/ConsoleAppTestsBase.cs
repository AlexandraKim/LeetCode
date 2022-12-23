using System;
using System.IO;
using System.Text;
using CodeForces;
using CodeForces.Problems;
using Moq;
using NUnit.Framework;

namespace CodeForcesTests {
    public class ConsoleAppTestsBase {
        private Mock<TextReader> _consoleInput;
        private StringBuilder _consoleOutput;

        [SetUp]
        public void Setup() {
            _consoleOutput = new StringBuilder();
            var consoleOutputWriter = new StringWriter(_consoleOutput);
            _consoleInput = new Mock<TextReader>();
            Console.SetOut(consoleOutputWriter);
            Console.SetIn(_consoleInput.Object);
        }


        protected string[] RunAndGetOutput(IProblem problem) {
            Program.Problem = problem;
            Program.Main(default);
            return _consoleOutput.ToString().Split("\r\n");
        }

        protected MockSequence SetupInput(string input) {
            var sequence = new MockSequence();
            foreach (var line in input.Split("\r\n")) {
                _consoleInput.InSequence(sequence)
                    .Setup(x => x.ReadLine())
                    .Returns(line);
            }

            return sequence;
        }
    }
}