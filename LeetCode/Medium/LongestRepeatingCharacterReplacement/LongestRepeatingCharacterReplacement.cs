using System.Collections.Generic;

namespace LeetCode.Medium.LongestRepeatingCharacterReplacement;

// 424. Longest Repeating Character Replacement https://leetcode.com/problems/longest-repeating-character-replacement
public class LongestRepeatingCharacterReplacement
{
  public int CharacterReplacement(string s, int k)
  {
    var dict = new Dictionary<char, int>();
    int start = 0;
    int end = 0;
    int maxFreq = 0;
    int maxWindow = 0;
    while (start < s.Length && end < s.Length)
    {
      if (!dict.TryAdd(s[end], 1))
      {
        dict[s[end]]++;
      }
      if (dict.ContainsKey(s[end]))
      {
        maxFreq = dict[s[end]] > maxFreq ? dict[s[end]] : maxFreq;
      }
      
      if (end - start - maxFreq < k)
      {
        end++;
      } 
      else if (end - start - maxFreq >= k)
      {
        dict[s[start]]--;
        start++;
        end++;
      }

      maxWindow = end - start;
    }
    
    return maxWindow;
  }
}