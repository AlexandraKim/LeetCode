using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium.ValidSudoku; 

// 36. Valid Sudoku https://leetcode.com/problems/valid-sudoku/description/
public class ValidSudoku {
    public bool IsValidSudoku(char[][] board) {
        var seen = new HashSet<string>();
        for (int i=0; i<9; ++i) {
            for (int j=0; j<9; ++j) {
                char number = board[i][j];
                if (number != '.')
                    if (!seen.Add(number + " in row " + i) ||
                        !seen.Add(number + " in column " + j) ||
                        !seen.Add(number + " in block " + i/3 + "-" + j/3))
                        return false;
            }
        }
        return true;
    }
}

public class MyValidSudoku {
    private readonly Dictionary<(int, int), HashSet<char>> _squares = new Dictionary<(int, int), HashSet<char>>();
    private readonly HashSet<(int, int)> _visited = new HashSet<(int, int)>();

    public bool IsValidSudoku(char[][] board) {
        var size = board.Length;
        var columnValues = new HashSet<char>();
        for (int i = 0; i < size; i++) {
            var rowValues = new HashSet<char>();
            for (int j = 0; j < size; j++)
            {
                if (!IsCellValid(rowValues, board[i][j], i, j))
                {
                    return false;
                }

                if (!IsCellValid(columnValues, board[j][i], j, i))
                {
                    return false;
                }
                    
                if (j == size - 1) {
                    rowValues.Clear();
                    columnValues.Clear();
                }
            }
        }
            
        return true;
    }

    private bool IsCellValid(HashSet<char> values, char value, int x, int y)
    {
        if (value == '.') return true;
        
        if (!values.Contains(value)) {
            values.Add(value);
        }
        else {
            return false;
        }
        return IsValidSquare(x, y, value);
    }

    private bool IsValidSquare(int x, int y, char value)
    {
        if (_visited.Contains((x, y))) 
        {
            return true;
        }
        var squareIndex = (x/3, y/3);
        if (!_squares.ContainsKey(squareIndex))
        {
            _visited.Add((x, y));
            _squares.Add(squareIndex, new HashSet<char>{value});
        }
        else
        {
            if (!_squares[squareIndex].Contains(value))
            {
                _visited.Add((x, y));
                _squares[squareIndex].Add(value);
            }
            else
            {
                return _visited.Contains((x,y));
            }
        }

        return true;
    }
}