using FluentAssertions;
using NUnit.Framework;

namespace Yandex.Lesson1.C.Merge;

public class MergeTests : ConsoleAppTestsBase
{
    [TestCase(@"5
1 3 5 5 9
3
2 5 6", @"1 2 3 5 5 5 6 9")]
    [TestCase(@"1
0
0
", @"0")]
    [TestCase(@"0

1
0", @"0")]
    public void Test(string input, string expectedOutput)
    {
        SetupInput(input);
        
        var result = RunAndGetOutput(new C.Merge.Merge());
        
        result
            .Should()
            .BeEquivalentTo(expectedOutput.TrimEnd().Split("\r\n"));
    }
}