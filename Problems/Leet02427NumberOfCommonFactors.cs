namespace SharpLeetCode.Problems;

public class Leet02427NumberOfCommonFactors
{
    public int CommonFactors(int a, int b)
    {
        var n = int.Max(a, b) / 2;
        // Count 1
        var commonFactorsCount = 1;
        for (int i = 2; i <= n; i++)
        {
            if (a % i == 0 && b % i == 0)
                commonFactorsCount++;
        }
        if (a == b && a > 1)
            commonFactorsCount++;
        return commonFactorsCount;
    }
}