namespace SharpLeetCode;

// https://leetcode.com/problems/pascals-triangle
class Leet00118PascalsTriangle
{
    public IList<IList<int>> Generate(int numRows)
    {
        var result = new List<IList<int>>
        {
            ([1])
        };
        while (result.Count < numRows)
        {
            var previous = result.Last();
            result.Add([]);
            result.Last().Add(1);
            for (int j = 0; j < previous.Count; j++)
            {
                result.Last().Add(previous.ElementAtOrDefault(j) + previous.ElementAtOrDefault(j + 1));
            }
        }
        return result;
    }

}