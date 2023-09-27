using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Easy.MergeTwoLists;

[TestFixture]
public class MergeTwoListsTests
{
    [Test]
    public void Test()
    {
        var sut = new Solution();
        var input1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var input2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        
        var result = sut.MergeTwoLists(input1, input2);

        result.Should()
            .BeEquivalentTo(new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4)))))));
    }
}