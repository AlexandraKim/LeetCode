namespace LeetCode.Algorithm1.BinarySearch.Search2DMatrix;

// 74. Search a 2D Matrix https://leetcode.com/problems/search-a-2d-matrix/
public class Search2DMatrix
{
  public bool SearchMatrix(int[][] matrix, int target)
  {
    var row = FindRow(matrix, target);
    return row != -1 && FindValue(matrix[row], target);
  }

  private int FindRow(int[][] matrix, int target)
  {
    int start = 0;
    int end = matrix.Length - 1;
    while (start <= end)
    {
      int mid = start + (end - start) / 2;
      var row = matrix[mid];
      if (row[0] <= target && row[row.Length -1] >= target)
      {
        return mid;
      }
      else if (target < row[0])
      {
        end = mid - 1;
      } else if (target > row[row.Length -1])
      {
        start = mid + 1;
      }
    }

    return -1;
  }

  private bool FindValue(int[] row, int target)
  {
    int start = 0;
    int end = row.Length - 1;
    while (start <= end)
    {
      int mid = start + (end - start) / 2;
      if (row[mid] == target)
      {
        return true;
      }
      else if(target < row[mid])
      {
        end = mid - 1;
      } else if (target > row[mid])
      {
        start = mid + 1;
      }
    }

    return false;
  }
}