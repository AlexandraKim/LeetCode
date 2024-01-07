using FluentAssertions;
using NUnit.Framework;

namespace Yandex.Lesson1.B.QuickSort;

public class QuickSortTests : ConsoleAppTestsBase
{
    [TestCase(@"5
1 5 2 4 3", @"1 2 3 4 5")]
    [TestCase(@"5
1 2 3 4 5", @"1 2 3 4 5")]
    [TestCase(@"5
1 5 2 5 3", @"1 2 3 5 5")]
    [TestCase(@"5
5 4 3 2 1
", @"1 2 3 4 5")]
    [TestCase(@"4
5 2 3 1
", @"1 2 3 5")]
    [TestCase(@"6
5 1 1 2 0 0
", @"0 0 1 1 2 5")]
    
    public void Test(string input, string expectedOutput)
    {
        SetupInput(input);
        
        var result = RunAndGetOutput(new QuickSort());
        
        result
            .Should()
            .BeEquivalentTo(expectedOutput.TrimEnd().Split("\r\n"));
    }
}