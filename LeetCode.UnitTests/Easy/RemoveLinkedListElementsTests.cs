using FluentAssertions;
using LeetCode.Easy;
using NUnit.Framework;

namespace LeetCode.UnitTests.Easy {
    [TestFixture]
    public class RemoveLinkedListElementsTests {
        [Test]
        public void Test() {
            var node7 = new RemoveLinkedListElements.ListNode(6);
            var node6 = new RemoveLinkedListElements.ListNode(5, node7);
            var node5 = new RemoveLinkedListElements.ListNode(4, node6);
            var node4 = new RemoveLinkedListElements.ListNode(3, node5);
            var node3 = new RemoveLinkedListElements.ListNode(6, node4);
            var node2 = new RemoveLinkedListElements.ListNode(2, node3);
            var node1 = new RemoveLinkedListElements.ListNode(1, node2);
            
            var expectedNode6 = new RemoveLinkedListElements.ListNode(5);
            var expectedNode5 = new RemoveLinkedListElements.ListNode(4, expectedNode6);
            var expectedNode4 = new RemoveLinkedListElements.ListNode(3, expectedNode5);
            var expectedNode2 = new RemoveLinkedListElements.ListNode(2, expectedNode4);
            var expectedNode1 = new RemoveLinkedListElements.ListNode(1, expectedNode2);
            
            var sut = new RemoveLinkedListElements();

            sut.RemoveElements(node1, 6)
                .Should().BeEquivalentTo(expectedNode1);
        }
        
        [Test]
        public void Test2() {
           
            var sut = new RemoveLinkedListElements();

            sut.RemoveElements(null, 1)
                .Should().BeNull(null);
        }
        
        [Test]
        public void Test3() {
            var node4 = new RemoveLinkedListElements.ListNode(7);
            var node3 = new RemoveLinkedListElements.ListNode(7, node4);
            var node2 = new RemoveLinkedListElements.ListNode(7, node3);
            var node1 = new RemoveLinkedListElements.ListNode(7, node2);
           
            var sut = new RemoveLinkedListElements();

            sut.RemoveElements(node1, 7)
                .Should().BeNull();
        }
    }
}