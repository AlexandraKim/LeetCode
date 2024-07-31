using FluentAssertions;
using NUnit.Framework;

namespace Yandex.Interview;

[TestFixture]
public class ProblemATests : ConsoleAppTestsBase
{
  [TestCase(@"ab
aabbccd", "4")]
  public void Test(string input, string expectedResult)
  {
    SetupInput(input);
    var result = RunAndGetOutput(new ProblemA());
        
    result.Should()
      .BeEquivalentTo(expectedResult.TrimEnd().Split("\r\n"));
  }
}