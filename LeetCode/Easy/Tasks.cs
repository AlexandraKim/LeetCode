using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy {
	public class Tasks {
		public bool ContainsDuplicate(int[] nums) {
			var dict = new Dictionary<int, int>();
			for(int i = 0; i < nums.Length; i ++) {
				if (dict.ContainsKey(nums[i])) {
					dict[i]++;
				}else{
					dict.Add(dict[i], 0);
				}
			}

			return dict.Values.Any(x => x > 0);
		}
		
		
		public static int[] TwoSum(int[] nums, int target) {
			var hashmap = new Dictionary<int, int>();
			for (var i = 0; i < nums.Length; i++) {
				hashmap.Add(i, nums[i]);
			}

			for (var i = 0; i < nums.Length; i++) {
				int complement = target - nums[i];
				if (hashmap.ContainsValue(complement)) {
					if (hashmap.FirstOrDefault(x => x.Value == complement).Key == i) {
						continue;
					}
					return new[] { hashmap.FirstOrDefault(x => x.Value == complement).Key, i };
				}
			}
			return Array.Empty<int>();
		}

		public static IList<int> FindDisappearedNumbers(int[] nums) {
			var missedOut = new List<int>();
			var i = 0;
			while (i < nums.Length) {
				int realPos = nums[i] - 1;
				if (nums[i] != nums[realPos]) {
					int temp = nums[i];
					nums[i] = nums[realPos];
					nums[realPos] = temp;
				} else {
					i++;
				}
				Console.WriteLine(nums);
			}

			for (var j = 0; j < nums.Length; j++) {
				if (nums[j] != j + 1) {
					missedOut.Add(j + 1);
				}
			}

			return missedOut;
		}

		// public static int Reverse(int x) {
		// 	int power;
		// 	int result;
		// 	// if (x < 0)
		// 	// {
		// 	//     int positive = (x * -1);
		// 	//     power = positive.ToString().Length - 1;
		// 	//     return Reverse(positive % 10 ^ power);
		// 	// }
		//
		// 	power = x.ToString().Length - 1;
		// 	return Reverse((x % 10) ^ power);
		// }
		//
		// private int armstrong(int remainder, int wholePart) {
		// 	int power = remainder.ToString().Length - 1;
		// 	int divider = 10 ^ power;
		// 	return armstrong(remainder % divider, (int)Math.Floor((double)(remainder / divider)));
		// }
		//
		// public static int SingleNumber(int[] nums) {
		// 	var res = 0;
		// 	for (var i = 0; i < nums.Length; i++) {
		// 		res ^= nums[i];
		// 	}
		//
		// 	return res;
		// }
		//
		// public static int ClimbStairs(int n) {
		// 	return n! / 2 * (n - 2)!;
		// }
		
	}
}