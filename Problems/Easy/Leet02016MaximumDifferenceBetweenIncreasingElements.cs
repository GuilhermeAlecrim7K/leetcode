namespace SharpLeetCode.Problems.Easy;

public class Leet02016MaximumDifferenceBetweenIncreasingElements
{
    public int MaximumDifference(int[] nums)
    {
        var maximumDifference = -1;
        var n = nums.Length;
        var minimumValueToTheLeft = nums[0];
        for (int i = 1; i < n; i++)
        {
            if (nums[i] > minimumValueToTheLeft)
                maximumDifference = int.Max(nums[i] - minimumValueToTheLeft, maximumDifference);
            else
                minimumValueToTheLeft = nums[i];
        }
        return maximumDifference;
    }
}