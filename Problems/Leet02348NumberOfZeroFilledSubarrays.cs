namespace SharpLeetCode.Problems;

public class Leet02348NumberOfZeroFilledSubarrays
{
    public long ZeroFilledSubarray(int[] nums)
    {
        long result = 0;
        int curZerosCount = 0;
        foreach (var n in nums)
        {
            if (n != 0)
                curZerosCount = 0;
            else
                result += ++curZerosCount;
        }
        return result;
    }
}