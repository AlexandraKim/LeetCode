using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Hard.MergeKLists;

[TestFixture]
public class MergeKListsTests
{
    private static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(new[]
        {
            ListNode.CreateListNodes(1, 4, 5),
            ListNode.CreateListNodes(1, 3, 4),
            ListNode.CreateListNodes(2, 6),
        }, ListNode.CreateListNodes(1, 1, 2, 3, 4, 4, 5, 6));
        yield return new TestCaseData(new ListNode[] { }, null);
    }
    [TestCaseSource(nameof(TestCases))]
    public void Test(ListNode[] lists, ListNode expectedResult)
    {
        var sut = new MergeKLists();
        var result = sut.Merge(lists);

        result.Should().BeEquivalentTo(expectedResult);
    }
}