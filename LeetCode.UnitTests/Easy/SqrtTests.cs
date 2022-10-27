using FluentAssertions;
using LeetCode.Easy;
using NUnit.Framework;

namespace LeetCode.UnitTests.Easy {
    [TestFixture]
    public class SqrtTests {
        [TestCase(4, 2)]
        [TestCase(8, 2)]
        [TestCase(1, 1)]
        [TestCase(6, 2)]
        [TestCase(2147395599, 46339)]
        public void Test(int n, int expectedResult) {
            var sut = new Sqrt();
            sut.MySqrt(n).Should().Be(expectedResult);
        }
    }
}