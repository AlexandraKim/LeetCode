using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithm1.BfsAndDfs {
    // 542. 01 Matrix https://leetcode.com/problems/01-matrix/
    public class IdentityMatrix {
        public int[][] UpdateMatrix(int[][] mat) {
            int columnsCount = mat[0].Length;
            int rowsCount = mat.Length;
            int total = columnsCount + rowsCount;
            for (int row = 0; row < rowsCount; row++) {
                for (int column = 0; column < columnsCount; column++) {
                    if (mat[row][column] == 0) {
                        continue;
                    }

                    int top = total, left = total;
                    if (column-1 >=0) {
                        left = mat[row][column - 1];
                    }
                    if (row-1 >=0) {
                        top = mat[row-1][column];
                    }

                    mat[row][column] = Math.Min(left, top)+1;
                }
            }

            for (int row = rowsCount - 1; row >= 0; row--) {
                for (int column = columnsCount - 1; column >= 0; column--)  {
                    if (mat[row][column] == 0) {
                        continue;
                    }

                    int bottom = total, right = total;
                    if (column+1 < columnsCount) {
                        right = mat[row][column + 1];
                    }
                    if (row+1 < rowsCount) {
                        bottom = mat[row+1][column];
                    }

                    mat[row][column] = Math.Min(Math.Min(right, bottom) + 1, mat[row][column]);
                }
            }

            return mat;
        }
        
        // This solution works but it's not time efficient
        // public int[][] UpdateMatrix(int[][] mat) {
        //     int columnsCount = mat[0].Length;
        //     int rowsCount = mat.Length;
        //     int[][] result = new int[rowsCount][];
        //     for (int i = 0; i < rowsCount; i++) {
        //         result[i] = new int[columnsCount];
        //     }
        //
        //     for (int i = 0; i < rowsCount; i++) {
        //         for (int j = 0; j < columnsCount; j++) {
        //             if (mat[i][j] == 0) {
        //                 result[i][j] = 0;
        //             }
        //             else {
        //                 var neighbours = GetNeighbours((i, j));
        //                 result[i][j] = GetDistanceOfTheNearestZero(0, neighbours);
        //             }
        //         }
        //     }
        //
        //     return result;
        //     
        //     int GetDistanceOfTheNearestZero(int count, HashSet<(int i, int j)> neighbours) {
        //         count++;
        //         if (neighbours.Any(x => mat[x.i][x.j] == 0)) {
        //             return count;
        //         }
        //
        //         var nextNeighbours = neighbours
        //             .SelectMany(x => GetNeighbours((x.i, x.j))
        //                 .Where(y => !neighbours.Contains(y))
        //                 .Select(y => (y.i, y.j)))
        //             .ToHashSet();
        //         return GetDistanceOfTheNearestZero(count, nextNeighbours);
        //     }
        //     
        //     HashSet<(int i, int j)> GetNeighbours((int i, int j) cell) {
        //         var neighbours = new HashSet<(int, int)>();
        //         (int, int) upperNeighbor = (cell.i - 1, cell.j);
        //         if (IsCellValid(upperNeighbor)) {
        //             neighbours.Add(upperNeighbor);
        //         }
        //         (int, int) lowerNeighbor = (cell.i + 1, cell.j);
        //         if (IsCellValid(lowerNeighbor)) {
        //             neighbours.Add(lowerNeighbor);
        //         }
        //         (int, int) leftNeighbor = ((cell.i, cell.j - 1));
        //         if (IsCellValid(leftNeighbor)) {
        //             neighbours.Add(leftNeighbor);
        //         }
        //         (int, int) rightNeighbor = ((cell.i, cell.j + 1));
        //         if (IsCellValid(rightNeighbor)) {
        //             neighbours.Add(rightNeighbor);
        //         }
        //
        //         return neighbours;
        //     }
        //     
        //     bool IsCellValid((int r, int c) ccc) {
        //         return ccc.c >= 0
        //                && ccc.c < columnsCount
        //                && ccc.r >= 0
        //                && ccc.r < rowsCount;
        //     }
        // }
    }
}