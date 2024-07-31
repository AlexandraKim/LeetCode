using FluentAssertions;
using NUnit.Framework;

namespace Yandex.Interview;

[TestFixture]
public class BracketsSequenceTests : ConsoleAppTestsBase
{
  [TestCase(@"0", "")]
  [TestCase(@"1", "((()))\n(()())\n(())()\n()(())\n()()()")]
  [TestCase(@"2", "((()))\n(()())\n(())()\n()(())\n()()()")]
  [TestCase(@"3", "((()))\n(()())\n(())()\n()(())\n()()()")]
  [TestCase(@"5", "((()))\n(()())\n(())()\n()(())\n()()()")]
  [TestCase(@"7", "((()))\n(()())\n(())()\n()(())\n()()()")]
  [TestCase(@"8", "((()))\n(()())\n(())()\n()(())\n()()()")]
  [TestCase(@"9", "((()))\n(()())\n(())()\n()(())\n()()()")]
  [TestCase(@"11", "((()))\n(()())\n(())()\n()(())\n()()()")]
  public void Test(string input, string expectedResult)
  {
    SetupInput(input);
    var result = RunAndGetOutput(new BracketsSequence());

    result.Should()
      // .NotBeNullOrEmpty();
    .BeEquivalentTo(expectedResult.TrimEnd().Split("\r\n"));
  }
}