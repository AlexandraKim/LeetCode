using FluentAssertions;
using NUnit.Framework;

namespace Yandex.Lesson1.E.RadixSort;

public class RadixSortTests : ConsoleAppTestsBase
{
    [TestCase(@"9
12
32
45
67
98
29
61
35
09", @"Initial array:
12, 32, 45, 67, 98, 29, 61, 35, 09
**********
Phase 1
Bucket 0: empty
Bucket 1: 61
Bucket 2: 12, 32
Bucket 3: empty
Bucket 4: empty
Bucket 5: 45, 35
Bucket 6: empty
Bucket 7: 67
Bucket 8: 98
Bucket 9: 29, 09
**********
Phase 2
Bucket 0: 09
Bucket 1: 12
Bucket 2: 29
Bucket 3: 32, 35
Bucket 4: 45
Bucket 5: empty
Bucket 6: 61, 67
Bucket 7: empty
Bucket 8: empty
Bucket 9: 98
**********
Sorted array:
09, 12, 29, 32, 35, 45, 61, 67, 98
")]
    public void Test(string input, string expectedOutput)
    {
        SetupInput(input);
        
        var result = RunAndGetOutput(new RadixSort());
        
        string[] expectedOutputArr = expectedOutput.TrimEnd().Split("\r\n");
        result
            .Should()
            .BeEquivalentTo(expectedOutputArr);
    }
    
    [Test]
    public void TestFromFile()
    {
        string input = File.ReadAllText("C:\\Projects\\LeetCode\\Yandex\\Lesson1\\E.RadixSort\\02");
        SetupInputFromFile(input);
        
        var result = RunAndGetOutput(new RadixSort());
        
        string[] expectedOutputArr = "".TrimEnd().Split("\r\n");
        result
            .Should()
            .BeEquivalentTo(expectedOutputArr);
    }

    [TestCase(1234567890, 1, 0)]
    [TestCase(1234567890, 2, 9)]
    [TestCase(1234567890, 3, 8)]
    [TestCase(1234567890, 4, 7)]
    [TestCase(1234567890, 5, 6)]
    [TestCase(1234567890, 6, 5)]
    [TestCase(1234567890, 7, 4)]
    public void GetsDigit(int n, int place, int expectedResult)
    {
        var uut = new RadixSort();
        
        var result = uut.GetDigit(n, place);

        result.Should().Be(expectedResult);
    }
}