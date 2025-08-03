namespace SharpLeetCode;

// https://leetcode.com/problems/pascals-triangle
class Leet00118PascalsTriangle
{
    public IList<IList<int>> Generate(int numRows)
    {
        var triangle = new List<IList<int>>
        {
            ([1])
        };
        while (triangle.Count < numRows)
        {
            var previousRow = triangle.Last();
            var currentRow = new List<int>() { 1 };
            for (int i = 1; i < previousRow.Count; i++)
            {
                currentRow.Add(previousRow[i - 1] + previousRow[i]);
            }
            currentRow.Add(1);
            triangle.Add(currentRow);
        }
        return triangle;
    }

}