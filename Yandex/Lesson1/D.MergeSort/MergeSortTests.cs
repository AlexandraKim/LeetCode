using FluentAssertions;
using NUnit.Framework;

namespace Yandex.Lesson1.D.MergeSort;

public class MergeSortTests : ConsoleAppTestsBase
{
    [TestCase(@"6
1 5 3 2 4 3", @"1 2 3 3 4 5")]
    [TestCase(@"0
", @"")]
    [TestCase(@"1
1", @"1")]
    public void Test(string input, string expectedOutput)
    {
        SetupInput(input);
        
        var result = RunAndGetOutput(new MergeSort());
        
        result
            .Should()
            .BeEquivalentTo(expectedOutput.TrimEnd().Split("\r\n"));
    }
}