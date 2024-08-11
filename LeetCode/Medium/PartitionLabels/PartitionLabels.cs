using System.Collections.Generic;

namespace LeetCode.Medium.PartitionLabels;

// 763. Partition Labels https://leetcode.com/problems/partition-labels/description/
public class PartitionLabels
{
  public IList<int> Run(string s)
  {
    var dict = GetLastIndexOfChars(s);
    var partitions = new List<int>();

    int i = 0;
    while (i < s.Length)
    {
      int partition = GetPartition(s, i, dict);
      partitions.Add(partition);
      i += partition;
    }

    return partitions;
  }

  private int GetPartition(string s, int start, Dictionary<char, int> dict)
  {
    var end = dict[s[start]];
    var partition = end;
    for (int i = start; i < partition; i++)
    {
      var ch = s[i];
      partition = dict[ch] > partition ? dict[ch] : partition;
    }

    return partition - start + 1;
  }

  private Dictionary<char, int> GetLastIndexOfChars(string str)
  {
    var dict = new Dictionary<char, int>();
    for (int i = 0; i < str.Length; i++)
    {
      if (!dict.ContainsKey(str[i]))
      {
        dict.Add(str[i], str.LastIndexOf(str[i]));
      }
    }

    return dict;
  }
}