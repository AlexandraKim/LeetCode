using FluentAssertions;
using NUnit.Framework;

namespace Yandex.Lesson1.A.Partition
{
    [TestFixture]
    public class PartitionTests : ConsoleAppTestsBase
    {
        [TestCase(@"5
1 9 4 2 3
3", @"2
3")]
        [TestCase(@"0

0", @"0
0")]
        [TestCase(@"1
0
0", @"0
1")]
        public void Test(string input, string expectedOutput)
        {
            SetupInput(input);
        
            var result = RunAndGetOutput(new Partition());
        
            result
                .Should()
                .BeEquivalentTo(expectedOutput.TrimEnd().Split("\r\n"));
        }
    }
}