using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithm1.BfsAndDfs {
    // 695. Max Area of Island https://leetcode.com/problems/max-area-of-island
    public static class MaxAreaOfIsland {
        public static int Run(int[][] grid) {
            List<(int, int)> visited = new List<(int, int)>();
            int maxIslandSize = 0;
            int rowsCount = grid.Length;
            int columnsCount = grid[0].Length;
            
            for (int i = 0; i < rowsCount; i++) {
                for (int j = 0; j < columnsCount; j++) {
                    if (visited.Contains((i, j))) {
                        continue;
                    }
                    visited.Add((i, j));
                    if (grid[i][j] == 1) {
                        var q = new Queue<(int r, int c)>();
                        q.Enqueue((i, j));
                        int inslandSize = 1;
                        
                        while (q.Any()) {
                            var v = q.Dequeue();
                            foreach ((int r, int c) neighbour in GetNeighbours(v)) {
                                if (!visited.Contains(neighbour)) {
                                    visited.Add(neighbour);
                                    if (grid[neighbour.r][neighbour.c] == 1) {
                                        q.Enqueue(neighbour);
                                        inslandSize++;
                                    }
                                }
                            }
                        }
                        maxIslandSize = inslandSize > maxIslandSize 
                            ? inslandSize 
                            : maxIslandSize;
                    }
                }
            }
            return maxIslandSize;

            Queue<(int, int)> GetNeighbours((int i, int j) cell) {
                var neighbours = new Queue<(int, int)>();
                (int, int) upperNeighbor = (cell.i - 1, cell.j);
                if (!visited.Contains(upperNeighbor) && IsCellValid(upperNeighbor)) {
                    neighbours.Enqueue(upperNeighbor);
                }
                (int, int) lowerNeighbor = (cell.i + 1, cell.j);
                if (!visited.Contains(lowerNeighbor) && IsCellValid(lowerNeighbor)) {
                    neighbours.Enqueue(lowerNeighbor);
                }
                (int, int) leftNeighbor = ((cell.i, cell.j - 1));
                if (!visited.Contains(leftNeighbor) && IsCellValid(leftNeighbor)) {
                    neighbours.Enqueue(leftNeighbor);
                }
                (int, int) rightNeighbor = ((cell.i, cell.j + 1));
                if (!visited.Contains(rightNeighbor) && IsCellValid(rightNeighbor)) {
                    neighbours.Enqueue(rightNeighbor);
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