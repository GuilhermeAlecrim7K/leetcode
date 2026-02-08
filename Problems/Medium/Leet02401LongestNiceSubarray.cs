namespace SharpLeetCode.Problems.Medium;

// https://leetcode.com/problems/longest-nice-subarray/
public class Leet02401LongestNiceSubarray
{
    public int LongestNiceSubArray(int[] nums)
    {
        int n = nums.Length;
        var longestNiceSubArray = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            var currentNiceSubArray = 1;
            int subArrayBitwiseORValue = nums[i];
            for (int j = i + 1; j < nums.Length && (nums[j] & subArrayBitwiseORValue) == 0; j++)
            {
                currentNiceSubArray++;
                subArrayBitwiseORValue |= nums[j];
            }
            longestNiceSubArray = int.Max(longestNiceSubArray, currentNiceSubArray);
        }
        return longestNiceSubArray;
    }
}