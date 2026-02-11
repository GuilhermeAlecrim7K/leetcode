namespace SharpLeetCode.Problems.Medium;

public class Leet00695MaxAreaOfIsland
{
    public int MaxAreaOfIsland(int[][] grid)
    {
        int maxArea = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 0) continue;
                maxArea = int.Max(maxArea, CalculateMaxArea(grid, i, j));
            }
        }
        return maxArea;
    }

    private int CalculateMaxArea(int[][] grid, int i, int j)
    {
        if (i < 0 || i >= grid.Length) return 0;
        if (j < 0 || j >= grid[i].Length) return 0;
        if (grid[i][j] == 0) return 0;
        grid[i][j] = 0;
        return
            CalculateMaxArea(grid, i+1, j) +
            CalculateMaxArea(grid, i, j+1) +
            CalculateMaxArea(grid, i-1, j) +
            CalculateMaxArea(grid, i, j-1) +
            1;
    }
    public int MaxAreaOfIslandWithoutChangingParameter(int[][] grid)
    {
        bool[][] visited = new bool[grid.Length][];
        for(int i = 0; i < grid.Length; i++)
            visited[i] = new bool[grid[0].Length];

        int maxArea = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 0) continue;
                if (visited[i][j]) continue;
                maxArea = int.Max(maxArea, CalculateMaxArea(grid, visited, i, j));
            }
        }
        return maxArea;
    }

    private int CalculateMaxArea(int[][] grid, bool[][] visited, int i, int j)
    {
        if (i < 0 || i >= grid.Length) return 0;
        if (j < 0 || j >= grid[i].Length) return 0;
        if (grid[i][j] == 0) return 0;
        if (visited[i][j]) return 0;
        visited[i][j] = true;
        return
            CalculateMaxArea(grid, visited, i+1, j) +
            CalculateMaxArea(grid, visited, i, j+1) +
            CalculateMaxArea(grid, visited, i-1, j) +
            CalculateMaxArea(grid, visited, i, j-1) +
            1;
    }
}