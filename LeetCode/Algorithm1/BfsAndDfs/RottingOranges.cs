using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithm1.BfsAndDfs {
    // 994. Rotting Oranges https://leetcode.com/problems/rotting-oranges/
    public class RottingOranges {
        public int OrangesRotting(int[][] grid) {
            var columnsCount = grid[0].Length;
            var rowsCount = grid.Length;
            HashSet<(int i, int j)> visited = new HashSet<(int i, int j)>();
            int stepsCount = 0;
            int freshOrangesCount = 0;
            Queue<(int i, int j)> rottenOranges = new Queue<(int i, int j)>();
            for (var i = 0; i < rowsCount; i++) {
                for (var j = 0; j < columnsCount; j++) {
                    if (grid[i][j] == 2) {
                        rottenOranges.Enqueue((i, j));
                    } else if (grid[i][j] == 1) {
                        freshOrangesCount++;
                    }
                }
            }

            while (rottenOranges.Any() && freshOrangesCount > 0) {
                stepsCount++;
                for (int i = rottenOranges.Count; i > 0; i--) {
                    (int i, int j) rotten = rottenOranges.Dequeue();
                    foreach ((int i, int j) neighbour in GetNeighbours(rotten)) {
                        grid[neighbour.i][neighbour.j] = 2;
                        rottenOranges.Enqueue(neighbour);
                        freshOrangesCount--;
                    }
                }
            }
            
            return freshOrangesCount == 0 ? stepsCount : -1;

            HashSet<(int i, int j)> GetNeighbours((int i, int j) cell) {
                var neighbours = new HashSet<(int, int)>();
                (int r, int c) upperNeighbor = (cell.i - 1, cell.j);
                if (IsCellValid(upperNeighbor) && grid[upperNeighbor.r][upperNeighbor.c] == 1) {
                    neighbours.Add(upperNeighbor);
                }

                (int r, int c) lowerNeighbor = (cell.i + 1, cell.j);
                if (IsCellValid(lowerNeighbor) && grid[lowerNeighbor.r][lowerNeighbor.c] == 1) {
                    neighbours.Add(lowerNeighbor);
                }

                (int r, int c) leftNeighbor = (cell.i, cell.j - 1);
                if (IsCellValid(leftNeighbor) && grid[leftNeighbor.r][leftNeighbor.c] == 1) {
                    neighbours.Add(leftNeighbor);
                }

                (int r, int c) rightNeighbor = (cell.i, cell.j + 1);
                if (IsCellValid(rightNeighbor) && grid[rightNeighbor.r][rightNeighbor.c] == 1) {
                    neighbours.Add(rightNeighbor);
                }

                return neighbours;
            }

            bool IsCellValid((int r, int c) ccc) {
                return ccc.c >= 0
                       && ccc.c < columnsCount
                       && ccc.r >= 0
                       && ccc.r < rowsCount;
            }
        }
    }
}