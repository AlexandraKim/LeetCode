using FluentAssertions;
using LeetCode.Easy;
using NUnit.Framework;

namespace LeetCode.UnitTests.Easy {
    [TestFixture]
    public class NumberOf1BitsTests {
        [Test]
        public void Test() {
            var sut = new NumberOf1Bits();
            sut.HammingWeight(00000000000000000000000000001011)
                .Should().Be(3);
        }
    }
}
