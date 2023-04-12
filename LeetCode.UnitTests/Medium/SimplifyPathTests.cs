using FluentAssertions;
using LeetCode.Medium;
using NUnit.Framework;

namespace LeetCode.UnitTests.Medium; 

[TestFixture]
public class SimplifyPathTests {
    [TestCase("/home/", "/home")]
    [TestCase("/../", "/")]
    [TestCase("/home//foo/", "/home/foo")]
    [TestCase("/a/./b/../../c/", "/c")]
    [TestCase("/a//b////c/d//././/..", "/a/b/c")]
    [TestCase("/...", "/...")]
    public void Test(string input, string expectedResult) {
        var sut = new SimplifyPath();
        sut.Run(input)
            .Should()
            .BeEquivalentTo(expectedResult);
    }
}