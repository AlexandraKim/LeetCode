using System.Collections.Generic;

namespace LeetCode.Algorithm1.BfsAndDfs.NumberOfIslands;

// 200. Number of Islands https://leetcode.com/problems/number-of-islands/description/
public class NumberOfIslands
{
  public int NumIslands(char[][] grid)
  {
    int count = 0;
    var visited = new HashSet<(int row, int column)>();
    for (int i = 0; i < grid.Length; i++)
    {
      for (int j = 0; j < grid[i].Length; j++)
      {
        if (!visited.Add((i, j)))
        {
          continue;
        }

        if (grid[i][j] == '1')
        {
          var neighbours = GetNeighbours(grid, visited, i, j);
          while (neighbours.TryDequeue(out (int row, int column) cell))
          {
            char ch = grid[cell.row][cell.column];
            if (ch == '1')
            {
              foreach ((int row, int column) c in GetNeighbours(grid, visited, cell.row, cell.column))
              {
                neighbours.Enqueue(c);
              }
            }
          }

          count++;
        }
      }
    }
    
    return count;
  }

  private Queue<(int row, int column)> GetNeighbours(
    char[][] grid,
    HashSet<(int row, int column)> visited,
    int row, int column)
  {
    var neighbours = new Queue<(int row, int column)>();
    // top
    AddNeighbour((row - 1, column));
    // right
    AddNeighbour((row, column + 1));
    // bottom
    AddNeighbour((row + 1, column));
    // left
    AddNeighbour((row, column - 1));

    return neighbours;

    void AddNeighbour((int row, int column) cell)
    {
      if (IsValidCell(grid, cell) && !visited.Contains(cell))
      {
        neighbours.Enqueue(cell);
        visited.Add((cell.row, cell.column));
      }
    }
  }

  private bool IsValidCell(char[][] grid, (int row, int column) cell)
  {
    return cell.row >= 0 && cell.row < grid.Length && 
           cell.column >= 0 && cell.column < grid[0].Length;
  }
}