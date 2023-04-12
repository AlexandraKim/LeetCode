using FluentAssertions;
using LeetCode.Medium;
using NUnit.Framework;

namespace LeetCode.UnitTests.Medium; 

[TestFixture]
public class RemovingStarsFromStringTests {
    [TestCase("leet**cod*e", "lecoe")]
    [TestCase("erase*****", "")]
    public void Test(string input, string expectedResult) {
        var sut = new RemovingStarsFromString();
        
        sut.RemoveStars(input)
            .Should()
            .BeEquivalentTo(expectedResult);
    }
}