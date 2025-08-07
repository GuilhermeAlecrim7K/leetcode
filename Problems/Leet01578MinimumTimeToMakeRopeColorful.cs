namespace SharpLeetCode.Problems;

public class Leet01578MinimumTimeToMakeRopeColorful
{
    public int MinCost(string colors, int[] neededTime)
    {
        var n = colors.Length;
        var minCost = 0;
        for (int i = 0, j = 1; j < n; j++)
        {
            if (colors[i] != colors[j])
            {
                i = j;
                continue;
            }

            minCost += int.Min(neededTime[i], neededTime[j]);
            if (neededTime[i] < neededTime[j])
                i = j;
        }
        return minCost;
    }
}