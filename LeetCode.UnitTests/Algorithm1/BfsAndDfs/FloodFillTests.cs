using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using LeetCode.Algorithm1.BfsAndDfs;
using NUnit.Framework;

namespace LeetCode.UnitTests.Algorithm1.BfsAndDfs {
    [TestFixture]
    public class FloodFillTests {
        private static IEnumerable<TestCaseData> TestCases { get
        {
            yield return new TestCaseData(new int[][]  {new int[] { 1, 1, 1 }, new int[] { 1, 1, 0 }, new int[] {1, 0, 1}}, 
                    1, 1, 2, 
                    new int[] [] {new int[] { 2,2,2 }, new int[] { 2,2,0 }, new int[] {2,0,1}})
                .SetName("3 by 3");
            yield return new TestCaseData(new int[][]  {new int[] { 0,0,0 }, new int[] { 0,0,0 }}, 
                    0, 0, 2, 
                    new int[][] {new int[] { 2,2,2 }, new int[] { 2,2,2 }})
                .SetName("2 by 3");
            yield return new TestCaseData(new int[][]  {new int[] { 0,0,0 }, new int[] { 0,1,1 }}, 
                    1, 1, 1, 
                    new int[][] {new int[] { 0,0,0 }, new int[] { 0,1,1 }})
                .SetName("The same colors");
            
        }}
        
        [TestCaseSource(nameof(TestCases))]
        public void Test(int [][] image, int sr, int sc, int newColor, int[][] expectedResult) {
            FloodFill.Run(image, sr, sc, newColor).Should().BeEquivalentTo(expectedResult);
        }
    }
}