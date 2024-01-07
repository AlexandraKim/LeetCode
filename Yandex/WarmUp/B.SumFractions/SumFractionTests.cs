using FluentAssertions;
using NUnit.Framework;

namespace Yandex.WarmUp.B.SumFractions;

[TestFixture]
public class SumFractionTests : ConsoleAppTestsBase
{
    [TestCase("1 6 7 15", "19 30")]
    [TestCase("1 2 1 2", "1 1")]
    public void Test(string input, string expectedOutput)
    {
        SetupInput(input);

        var result = RunAndGetOutput(new SumFraction());

        result.Should().BeEquivalentTo(expectedOutput);
    }
}