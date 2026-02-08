namespace SharpLeetCode.Problems.Medium;

public class Leet01277CountSquareSubmatricesWithAllOnes
{
    private int _m;
    private int _n;
    private int Solve(int i, int j, int[][] matrix, int[][] memoizedTable)
    {
        if (i >= _m || j >= _n)
            return 0;
        if (matrix[i][j] == 0)
            return 0;

        if (memoizedTable[i][j] != -1)
            return memoizedTable[i][j];

        var right = Solve(i, j + 1, matrix, memoizedTable);
        var diagonal = Solve(i + 1, j + 1, matrix, memoizedTable);
        var down = Solve(i + 1, j, matrix, memoizedTable);
        memoizedTable[i][j] = 1 + int.Min(right, int.Min(down, diagonal));
        return memoizedTable[i][j];
    }
    public int CountSquares(int[][] matrix)
    {
        _m = matrix.Length;
        _n = matrix[0].Length;
        var memoizedTable = new int[_m][];
        for (int i = 0; i < _m; i++)
        {
            memoizedTable[i] = new int[_n];
            for (int j = 0; j < _n; j++)
                memoizedTable[i][j] = -1;
        }

        var squareCount = 0;
        for (int i = 0; i < _m; i++)
        {
            for (int j = 0; j < _n; j++)
                squareCount += Solve(i, j, matrix, memoizedTable);
        }
        return squareCount;
    }
}