using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Medium.LongestRepeatingCharacterReplacement;

[TestFixture]
public class LongestRepeatingCharacterReplacementTests
{
  [TestCase("ABAB", 2, 4)]
  [TestCase("AABABBA", 1, 4)]
  [TestCase("AAAA", 2, 4)]
  public void Test(string str, int k, int expectedResult)
  {
    var sut = new LongestRepeatingCharacterReplacement();

    var result = sut.CharacterReplacement(str, k);

    result.Should().Be(expectedResult);
  }
}