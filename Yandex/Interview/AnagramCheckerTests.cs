using FluentAssertions;
using NUnit.Framework;

namespace Yandex.Interview;

public class AnagramCheckerTests : ConsoleAppTestsBase
{
  [TestCase(@"qiu
iuq", "1")]
  [TestCase(@"zprl
zprc", "0")]
  public void Test(string input, string expectedResult)
  {
    SetupInput(input);
    var result = RunAndGetOutput(new AnagramChecker());

    result.Should()
      // .NotBeNullOrEmpty();
      .BeEquivalentTo(expectedResult.TrimEnd().Split("\r\n"));
  }
}