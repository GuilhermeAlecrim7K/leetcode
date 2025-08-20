namespace SharpLeetCode.Problems;

public class Leet00868BinaryGap
{
    public int BinaryGap(int n)
    {
        var maxGap = 0;
        int? previousOnBit = null;
        for (int i = 0, curBit = 1 << i; i < 31; i++, curBit = 1 << i)
        {
            if ((n & curBit) == curBit)
            {
                previousOnBit ??= i;
                maxGap = int.Max(i - (previousOnBit ?? i), maxGap);
                previousOnBit = i;
            }
        }
        return maxGap;
    }
}