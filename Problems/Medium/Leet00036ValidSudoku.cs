namespace SharpLeetCode.Problems.Medium;

public class Leet00036ValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        var n = 9;
        var rows = new int[n];
        var columns = new int[n];
        var blocks = new int[n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (board[i][j] == '.')
                    continue;
                var cellValue = board[i][j] - '1';
                var cellBitValue = 1 << cellValue;
                if ((rows[i] & cellBitValue) == cellBitValue)
                    return false;
                rows[i] |= cellBitValue;
                if ((columns[j] & cellBitValue) == cellBitValue)
                    return false;
                columns[j] |= cellBitValue;
                var blockId = i / 3 * 3 + j / 3;
                if ((blocks[blockId] & cellBitValue) == cellBitValue)
                    return false;
                blocks[blockId] |= cellBitValue;
            }
        }
        return true;
    }

}