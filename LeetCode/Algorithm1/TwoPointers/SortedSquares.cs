using System;
using System.Collections.Generic;

namespace LeetCode.Algorithm1.TwoPointers {
    public static class SortedSquares {
        public static int[] Run(int[] nums) {
            var squares = new int[nums.Length];
            var (squaredNegatives, squaredPositives) = GetSquaredNegativesAndPositives(nums);
            int? squaredNegative = null;
            int? squaredPositive = null;
            for (var i = 0; i < nums.Length; i++) {
                GetSquares(ref squaredNegative, ref squaredPositive, nums, squaredNegatives, squaredPositives);
                
                if (IsLeftLessThanRight(squaredNegative,  squaredPositive)) {
                    squares[i] = squaredNegative.Value;
                    squaredNegative = null;
                }
                else if (IsLeftLessThanRight(squaredPositive, squaredNegative)) {
                    squares[i] = squaredPositive.Value;
                    squaredPositive = null;
                }
                else if (squaredPositive == squaredNegative && squaredNegative.HasValue) {
                    squares[i] = squaredPositive.Value;
                    squares[i + 1] = squaredNegative.Value;
                    squaredNegative = null;
                    squaredPositive = null;
                    i++;
                }

            }

            if (squaredPositive.HasValue) {
                squares[nums.Length - 1] = squaredPositive.Value;
            }
            else if (squaredNegative.HasValue) {
                squares[nums.Length - 1] = squaredNegative.Value;
            }

            return squares;
        }

        private static bool IsLeftLessThanRight(int? left, int? right) {
            return left < right || left.HasValue && !right.HasValue;
        }

        private static void GetSquares(ref int? squaredNegative, ref int? squaredPositive, int[] nums, Stack<int> squaredNegatives, Queue<int> squaredPositives) {
            if (!squaredNegative.HasValue && squaredNegatives.Count > 0 ) {
                squaredNegative = squaredNegatives.Pop();    
            }
            if (!squaredPositive.HasValue && squaredPositives.Count > 0) {
                squaredPositive = squaredPositives.Dequeue();    
            }
        }

        private static (Stack<int>, Queue<int>) GetSquaredNegativesAndPositives(int[] nums) {
            var squaredNegatives = new Stack<int>();
            var squaredPositives = new Queue<int>();
            foreach (var t in nums) {
                if (t < 0) {
                    squaredNegatives.Push(Square(t));
                }
                else {
                    squaredPositives.Enqueue(Square(t));
                }
            }

            return (squaredNegatives, squaredPositives);
        }
        
        private static int Square(int n) {
            return (int) Math.Pow(n, 2);
        }
    }
}