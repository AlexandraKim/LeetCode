using System.Collections.Generic;
using FluentAssertions;
using LeetCode.Algorithm1.BfsAndDfs;
using NUnit.Framework;

namespace LeetCode.UnitTests.Algorithm1.BfsAndDfs {
    [TestFixture]
    public class MaxAreaOfIslandTests {
        private static IEnumerable<TestCaseData> TestCases { get {
            yield return new TestCaseData(new int[][] {
                    new int[] {0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
                    new int[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                    new int[] {0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                    new int[] {0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0},
                    new int[] {0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0},
                    new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                    new int[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                    new int[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0},
                },
                6);
            yield return new TestCaseData(new int[][] {
                new[] {0, 0, 0, 0, 0, 0, 0, 0}
            }, 0);
            yield return new TestCaseData(new int[][] {
                new int[] {1,1,0,0,0}, 
                new int[] {1,1,0,0,0},
                new int[] {0,0,0,1,1},
                new int[] {0,0,0,1,1}
            }, 4);
        }}
        
        [TestCaseSource(nameof(TestCases))]
        public void Test(int[][] matrix, int expectedResult) {
            MaxAreaOfIsland.Run(matrix).Should().Be(expectedResult);
        }
    }
}