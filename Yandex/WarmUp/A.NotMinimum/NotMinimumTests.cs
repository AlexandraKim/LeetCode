using FluentAssertions;
using NUnit.Framework;

namespace Yandex.WarmUp.A.NotMinimum;

[TestFixture]
public class NotMinimumTests : ConsoleAppTestsBase
{
    [TestCase(@"10 5
1 1 1 2 2 2 3 3 3 10
0 1
0 3
3 4
7 9
3 7", @"NOT FOUND
2
NOT FOUND
10
3")]
    [TestCase(@"4 2
1 1 1 2
0 2
0 3", @"NOT FOUND
2")]
    public void Test(string input, string expectedResult)
    {
        SetupInput(input);
        var result = RunAndGetOutput(new NotMinimum());
        
        result.Should()
            .BeEquivalentTo(expectedResult.TrimEnd().Split("\r\n"));
    }
}