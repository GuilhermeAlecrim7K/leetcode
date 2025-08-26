namespace SharpLeetCode.Problems.Easy;

public class Leet03000MaximumAreaOfLongestDiagonalRectangle
{
    public int AreaOfMaxDiagonal(int[][] dimensions)
    {
        var maxArea = 0;
        var maxDiagonal = 0;
        for (int i = 0; i < dimensions.Length; i++)
        {
            var a = dimensions[i][0];
            var b = dimensions[i][1];
            var curDiagonal = a * a + b * b;
            if (curDiagonal > maxDiagonal)
            {
                maxDiagonal = curDiagonal;
                maxArea = a * b;
            }
            else if (curDiagonal == maxDiagonal)
            {
                maxArea = int.Max(maxArea, a * b);
            }
        }
        return maxArea;
    }
}