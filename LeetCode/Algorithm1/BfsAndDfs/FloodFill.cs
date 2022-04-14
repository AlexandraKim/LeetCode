using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithm1.BfsAndDfs {
    public static class FloodFill {
        // 733. Flood Fill https://leetcode.com/problems/flood-fill/
        public static int[][] Run(int[][] image, int sr, int sc, int newColor) {
            Queue<(int r, int c)> queue = new Queue<(int r, int c)>();
            int oldColor = image[sr][sc];
            if (oldColor == newColor) {
                return image;
            }
            queue.Enqueue((sr, sc));
            while (queue.Count > 0) {
                var curr = queue.Dequeue();
                int r = curr.r;
                int c = curr.c;
                image[r][c] = newColor;

                if (ShouldBeColored(r, c + 1)) {
                    queue.Enqueue((r, c + 1));
                }
                
                if (ShouldBeColored(r, c - 1)) {
                    queue.Enqueue((r, c - 1));
                }
                
                if (ShouldBeColored(r + 1, c)) {
                    queue.Enqueue((r + 1, c));
                }
                
                if (ShouldBeColored(r - 1, c)) {
                    queue.Enqueue((r - 1, c));
                }
            }
            return image;

            bool ShouldBeColored(int r, int c) {
                return c >= 0
                       && r >= 0
                       && r < image.Length
                       && c < image[r].Length
                       && image[r][c] == oldColor;
            }
        }
    }
}