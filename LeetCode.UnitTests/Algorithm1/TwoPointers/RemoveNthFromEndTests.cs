using FluentAssertions;
using LeetCode.Algorithm1.TwoPointers;
using NUnit.Framework;

namespace LeetCode.UnitTests.Algorithm1.TwoPointers {
    [TestFixture]
    public class RemoveNthFromEndTests {
        [Test]
        public void Test() {
            var node5 = new ListNode(5);
            var node4 = new ListNode(4, node5);
            var node3 = new ListNode(3, node4);
            var node2 = new ListNode(2, node3);
            var node1 = new ListNode(1, node2);
            
            var expectedNode5 = new ListNode(5);
            var expectedNode3 = new ListNode(3, expectedNode5);
            var expectedNode2 = new ListNode(2, expectedNode3);
            var expectedNode1 = new ListNode(1, expectedNode2);

            RemoveNthFromEnd.Run(node1, 2).Should().BeEquivalentTo(expectedNode1);
        }

        [Test]
        public void TestEdgeCase() {
            var node2 = new ListNode(2);
            var node1 = new ListNode(1, node2);

            RemoveNthFromEnd.Run(node1, 2).Should().BeEquivalentTo(node2);
        }

        [Test]
        public void TestOneNode() {
            var node1 = new ListNode(1);

            RemoveNthFromEnd.Run(node1, 1).Should().BeNull();
        }
    }
}