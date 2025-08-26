
namespace SharpLeetCode.Problems.Medium;

public class Leet00498DiagonalTraverse
{
    public int[] FindDiagonalOrder(int[][] mat)
    {
        int m = mat.Length;
        int n = mat[0].Length;
        var result = new int[m * n];

        var up = true;
        for (int i = 0, j = 0, k = 0; k < result.Length; k++)
        {
            result[k] = mat[i][j];
            (i, j, up) = GetNext(i, j, m, n, up);
        }
        return result;
    }

    private static (int i, int j, bool up) GetNext(int i, int j, int m, int n, bool up)
    {
        int newI = i + (up ? -1 : 1);
        int newJ = j + (up ? 1 : -1);

        if (newI >= 0 && newI < m && newJ >= 0 && newJ < n)
            return (newI, newJ, up);

        if (up)
        {
            newI = i + (j == n - 1 ? 1 : 0);
            newJ = j + (j < n - 1 ? 1 : 0);
        }
        else
        {
            newI = i + (i < m - 1 ? 1 : 0);
            newJ = j + (i == m - 1 ? 1 : 0);
        }
        return (newI, newJ, !up);
    }
}