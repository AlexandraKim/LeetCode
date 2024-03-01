using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Medium.MultiplyStrings;

[TestFixture]
public class MultiplyStringsTests
{
    [TestCase("654154154151454545415415454", "63516561563156316545145146514654", "41549622603955309777243716069997997007620439937711509062916")]
    [TestCase("2", "3", "6")]
    [TestCase("2", "0", "0")]
    public void Test(string a, string b, string expectedResult)
    {
        var multiplier = new Medium.MultiplyStrings.MultiplyStrings();

        multiplier.Multiply(a, b)
            .Should()
            .Be(expectedResult);
    }
}