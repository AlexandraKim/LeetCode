using FluentAssertions;
using LeetCode.Algorithm1.TwoPointers;
using NUnit.Framework;

namespace LeetCode.UnitTests.Algorithm1.TwoPointers {
    [TestFixture]
    public class MiddleOfLinkedListTests {
        [Test]
        public void TestOddNumberOfNodes() {
            var node5 = new ListNode(5);
            var node4 = new ListNode(4, node5);
            var node3 = new ListNode(3, node4);
            var node2 = new ListNode(2, node3);
            var node1 = new ListNode(1, node2);

            MiddleOfLinkedList.Run(node1).Should().BeEquivalentTo(node3);
        }

        [Test]
        public void TestEvenNumberOfNodes() {
            var node6 = new ListNode(5);
            var node5 = new ListNode(5, node6);
            var node4 = new ListNode(4, node5);
            var node3 = new ListNode(3, node4);
            var node2 = new ListNode(2, node3);
            var node1 = new ListNode(1, node2);

            MiddleOfLinkedList.Run(node1).Should().BeEquivalentTo(node4);
        }

        [Test]
        public void TestOneNode() {
            var node1 = new ListNode(1);

            MiddleOfLinkedList.Run(node1).Should().BeEquivalentTo(node1);
        }
    }
}