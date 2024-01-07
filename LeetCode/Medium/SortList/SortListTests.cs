using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Medium.SortList;

[TestFixture]
public class SortListTests
{
    private static IEnumerable<TestCaseData> TestCasesForFindingMid()
    {
        yield return new TestCaseData(CreateListNodes(1, 3, 5, 8), CreateListNodes(3, 5, 8))
            .SetName("1, 3, 5, 8 -> 3, 5, 8");
        yield return new TestCaseData(CreateListNodes(1, 3, 5, 8, 9), CreateListNodes(5, 8, 9))
            .SetName("1, 3, 5, 8, 9 -> 5, 8, 9");
    }

    [TestCaseSource(nameof(TestCasesForFindingMid))]
    public void TestFindMid(ListNode node, ListNode expectedNode)
    {
        var sut = new SortList();

        sut.FindMid(node)
            .Should()
            .BeEquivalentTo(expectedNode);
    }
    
    private static IEnumerable<TestCaseData> TestCasesForSplittingIntoTwo()
    {
        yield return new TestCaseData(CreateListNodes(3, 5, 8), CreateListNodes(3), CreateListNodes(5, 8))
            .SetName("1, 3, 5, 8 -> 5, 8");
        yield return new TestCaseData(CreateListNodes(5, 8, 9), CreateListNodes(5), CreateListNodes(8, 9))
            .SetName("1, 3, 5, 8, 9 -> 8, 9");
    }
    [TestCaseSource(nameof(TestCasesForSplittingIntoTwo))]
    public void TestSplitIntoTwoHalves(ListNode node, ListNode expectedLeftNode, ListNode expectedRightNode)
    {
        var sut = new SortList();

        var right = sut.SplitIntoTwoHalves(node);
            
        right.Should()
            .BeEquivalentTo(expectedRightNode);

        node.Should()
            .BeEquivalentTo(expectedLeftNode);
    }
    
    private static IEnumerable<TestCaseData> TestCasesForMerge()
    {
        yield return new TestCaseData(CreateListNodes(1, 3, 5, 8, 9, 10, 12), CreateListNodes(2, 4, 6, 7), CreateListNodes(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12))
            .SetName("1, 3, 5, 8 + 2, 4, 6, 7");
        yield return new TestCaseData(CreateListNodes(1, 3, 5, 8), CreateListNodes(2, 4, 6, 7), CreateListNodes(1, 2, 3, 4, 5, 6, 7, 8))
            .SetName("1, 3, 5, 8 + 2, 4, 6, 7");
    }

    [TestCaseSource(nameof(TestCasesForMerge))]
    public void TestMerge(ListNode left, ListNode right, ListNode expectedResult)
    {
        var sut = new SortList();

        sut.Merge(left, right)
            .Should()
            .BeEquivalentTo(expectedResult);
    }
    
    private static IEnumerable<TestCaseData> TestCasesForSort()
    {
        yield return new TestCaseData(CreateListNodes(2, 7, 1, 4, 3, 5, 8, 6), CreateListNodes(1, 2, 3, 4, 5, 6, 7, 8))
            .SetName("2, 7, 1, 4, 3, 5, 8, 6 -> 1, 2, 3, 4, 5, 6, 7, 8");
        yield return new TestCaseData(CreateListNodes(4,2,1,3), CreateListNodes(1, 2, 3, 4))
            .SetName("2, 7, 1, 4, 3, 5, 8, 6 -> 1, 2, 3, 4, 5, 6, 7, 8");
    }

    [TestCaseSource(nameof(TestCasesForSort))]
    public void TestSort(ListNode head, ListNode expectedResult)
    {
        var sut = new SortList();

        sut.Sort(head)
            .Should()
            .BeEquivalentTo(expectedResult);
    }

    private static ListNode CreateListNodes(params int[] nums)
    {
        return CreateRecursive(nums, 0);
    }

    private static ListNode CreateRecursive(int[] nums, int i)
    {
        if (i == nums.Length - 1)
        {
            return new ListNode(nums[i]);
        }

        return new ListNode(nums[i], CreateRecursive(nums, i + 1));
    }
}