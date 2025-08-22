namespace SharpLeetCode.Problems;

public class Leet03195FindTheMinimumAreaToCoverAllOnesI
{
    public int MinimumArea(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int top = m + 1, right = -1, down = -1, left = n + 1;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] != 1)
                    continue;
                top = int.Min(i, top);
                right = int.Max(j, right);
                down = int.Max(i, down);
                left = int.Min(j, left);
            }
        }
        return (right - left + 1) * (down - top + 1);
    }
}