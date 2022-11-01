using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using LeetCode.Algorithm1.BfsAndDfs;
using NUnit.Framework;

namespace LeetCode.UnitTests.Algorithm1.BfsAndDfs {
    [TestFixture]
    public class RottingOrangesTests {
        private static IEnumerable<TestCaseData> TestCases { get {
            yield return new TestCaseData(new int[][] {
                new int[] {2,1,1},
                new int[] {1,1,0},
                new int[] {0,1,1}
            }, 4);
            yield return new TestCaseData(new int[][] {
                new int[] {2,1,1},
                new int[] {0,1,1},
                new int[] {1,0,1}
            }, -1);
            yield return new TestCaseData(new int[][] {
                new int[] {2,1,1},
                new int[] {1,1,1},
                new int[] {0,1,2}
            }, 2);
            yield return new TestCaseData(new int[][] {
                new int[] {0}
            }, 0);

        }}
        
        [TestCaseSource(nameof(TestCases))]
        public void Test(int[][] input, int expectedResult) {
            var sut = new RottingOranges();
            sut.OrangesRotting(input).Should().Be(expectedResult);
        }
    }
}