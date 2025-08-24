namespace SharpLeetCode.Problems;

public class Leet01493LongestSubarrayOf1sAfterDeletingOneElement
{
    public int LongestSubarray(int[] nums)
    {
        var n = nums.Length;
        int curSequence = 0, prevSequence = 0;
        var longestSubarrayCount = 0;
        var hasZeroes = false;
        for (int i = 0; i < n;)
        {
            if (nums[i] != 1)
            {
                hasZeroes = true;
                prevSequence = curSequence;
                curSequence = 0;
                i++;
                continue;
            }
            while (i < n && nums[i] == 1)
            {
                curSequence++;
                i++;
            }

            longestSubarrayCount = int.Max(longestSubarrayCount, curSequence + prevSequence);
        }
        return hasZeroes ? longestSubarrayCount : longestSubarrayCount - 1;
    }
}