using FluentAssertions;
using LeetCode.Easy;
using NUnit.Framework;

namespace LeetCode.UnitTests.Easy {
    [TestFixture]
    public class PowerOfTwoTests {
        [TestCase(0, false)]
        [TestCase(16, true)]
        [TestCase(12, false)]
        public void Test(int n, bool expectedResult) {
            var sut = new PowerOfTwo();
            sut.IsPowerOfTwo(n).Should().Be(expectedResult);
        }
    }
}