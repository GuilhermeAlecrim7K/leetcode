namespace SharpLeetCode.Problems.Medium;

public class Leet00036ValidSudoku
{
    private bool ValidateSlice(IEnumerable<char> slice)
    {
        var numbers = new int[10];
        foreach (var c in slice)
        {
            if (c == '.')
                continue;
            if (numbers[c - '0']++ > 0)
                return false;
        }
        return true;
    }

    public bool IsValidSudoku(char[][] board)
    {
        foreach (var slice in board.EnumerateSudokuSlices())
            if (!ValidateSlice(slice))
                return false;
        return true;
    }

}
public static class SudokuHelper
{
    public static IEnumerable<char[]> EnumerateSudokuSlices(this char[][] board)
    {
        foreach (var row in board)
            yield return row;

        for (int i = 0, k = 0; i < 9; i++, k = 0)
        {
            var column = new char[9];
            for (int j = 0; j < 9; j++)
                column[k++] = board[j][i];
            yield return column;
        }
        var blocks = new (int i, int j)[9] {
            (0, 0), (0, 3), (0, 6),
            (3, 0), (3, 3), (3, 6),
            (6, 0), (6, 3), (6, 6),
        };
        foreach (var block in blocks)
        {
            var k = 0;
            var blockSlice = new char[9];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    blockSlice[k++] = board[block.i + i][block.j + j];
            }
            yield return blockSlice;
        }
    }
}