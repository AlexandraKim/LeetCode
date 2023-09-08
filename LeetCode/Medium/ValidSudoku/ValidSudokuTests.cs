using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Medium.ValidSudoku;

[TestFixture]
public class ValidSudokuTests {
    private static TestCaseData[] _testCaseData = new[] {
        new TestCaseData(new char[][] {
            new[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        }, true).SetName("Valid"),
        new TestCaseData(new char[][] {
            new[] { '8', '3', '.', '.', '7', '.', '.', '.', '.' },
            new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        }, false).SetName("Invalid vertically, column 0"),
        new TestCaseData(new char [][] {
            new [] {'.','4','.','.','.','.','.','.','.'},
            new [] {'.','.','4','.','.','.','.','.','.'},
            new [] {'.','.','.','1','.','.','7','.','.'},
            new [] {'.','.','.','.','.','.','.','.','.'},
            new [] {'.','.','.','3','.','.','.','6','.'},
            new [] {'.','.','.','.','.','6','.','9','.'},
            new [] {'.','.','.','.','1','.','.','.','.'},
            new [] {'.','.','.','.','.','.','2','.','.'},
            new [] {'.','.','.','8','.','.','.','.','.'}
        }, false).SetName("Invalid in a cell, 0-0")
    };

    [TestCaseSource(nameof(_testCaseData))]
    public void Tests(char[][] board, bool expectedResult) {
        var sut = new ValidSudoku();

        sut.IsValidSudoku(board)
            .Should()
            .Be(expectedResult);
    }
}