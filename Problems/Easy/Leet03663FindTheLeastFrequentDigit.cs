namespace SharpLeetCode.Problems.Easy;

public class Leet03663FindTheLeastFrequentDigit
{
    public int GetLeastFrequentDigit(int n)
    {
        var s = n.ToString();
        var digits = new int[10];
        foreach (var digit in s)
            digits[digit - '0']++;

        var ans = int.MaxValue;
        var min = int.MaxValue;
        for (int i = 9; i >= 0; i--)
        {
            if (digits[i] == 0)
                continue;
            if (digits[i] <= min)
            {
                ans = i;
                min = digits[i];
            }
        }
        return ans;
    }
}