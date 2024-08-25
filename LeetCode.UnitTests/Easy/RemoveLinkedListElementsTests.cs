using FluentAssertions;
using LeetCode.Easy;
using NUnit.Framework;

namespace LeetCode.UnitTests.Easy {
    [TestFixture]
    public class RemoveLinkedListElementsTests {
        [Test]
        public void Test() {
            var node = ListNode.CreateListNodes(1, 2, 6, 3, 4, 5, 6);
            var expectedNode = ListNode.CreateListNodes(1, 2, 3, 4, 5);
            
            var sut = new RemoveLinkedListElements();

            sut.RemoveElements(node, 6)
                .Should().BeEquivalentTo(expectedNode);
        }
        
        [Test]
        public void Test2() {
            var sut = new RemoveLinkedListElements();

            sut.RemoveElements(null, 1)
                .Should().BeNull(null);
        }
        
        [Test]
        public void Test3() {
            var sut = new RemoveLinkedListElements();

            sut.RemoveElements(ListNode.CreateListNodes(7, 7, 7, 7), 7)
                .Should().BeNull();
        }
    }
}