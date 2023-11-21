using System.Text;
using Moq;
using NUnit.Framework;

namespace Yandex {
    public class ConsoleAppTestsBase {
        private Mock<TextReader> _consoleInput;
        protected StringBuilder _consoleOutput;

        [SetUp]
        public void Setup() {
            _consoleOutput = new StringBuilder();
            var consoleOutputWriter = new StringWriter(_consoleOutput);
            _consoleInput = new Mock<TextReader>();
            Console.SetOut(consoleOutputWriter);
            Console.SetIn(_consoleInput.Object);
        }


        protected string[] RunAndGetOutput(IProblem problem) {
            problem.Run();
            return _consoleOutput.ToString().TrimEnd().Split("\r\n");
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
        
        protected MockSequence SetupInputFromFile(string input) {
            var sequence = new MockSequence();
            foreach (var line in input.Split("\n")) {
                _consoleInput.InSequence(sequence)
                    .Setup(x => x.ReadLine())
                    .Returns(line);
            }

            return sequence;
        }
    }
}