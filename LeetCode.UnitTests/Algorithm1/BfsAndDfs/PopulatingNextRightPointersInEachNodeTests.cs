using FluentAssertions;
using LeetCode.Algorithm1.BfsAndDfs;
using NUnit.Framework;

namespace LeetCode.UnitTests.Algorithm1.BfsAndDfs {
    [TestFixture]
    public class PopulatingNextRightPointersInEachNodeTests {
        [Test]
        public void Test() {
            var node2 = new Node(2, new Node(4), new Node(5), null);
            var node3 = new Node(3, new Node(6), new Node(7), null);
            var node1 = new Node(1, node2, node3, null);

            var expectedNode7 = new Node(7);
            var expectedNode6 = new Node(6, null, null, expectedNode7);
            var expectedNode5 = new Node(5, null, null, expectedNode6);
            var expectedNode4 = new Node(4, null, null, expectedNode5);
            var expectedNode3 = new Node(3, expectedNode6, expectedNode7, null);
            var expectedNode2 = new Node(2, expectedNode4, expectedNode5, expectedNode3);
            var expectedNode1 = new Node(1, expectedNode2, expectedNode3, null);
            
            var sut = new PopulatingNextRightPointersInEachNode();

            sut.Connect(node1).Should().Be(expectedNode1);
        }
        
        [Test]
        public void Test2() {
            var sut = new PopulatingNextRightPointersInEachNode();

            sut.Connect(null).Should().Be(null);
        }
        
    }
}