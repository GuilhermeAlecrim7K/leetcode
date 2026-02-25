namespace SharpLeetCode.Problems.Easy;

public class Leet01365HowManyNumbersAreSmallerThanTheCurrentNumber
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int[] counts = new int[101];

        foreach(var n in nums)
            counts[n]++;

        for (int i = 1; i < 101; i++)
            counts[i] += counts[i-1];

        for (int i = 0; i < nums.Length; i++)
            nums[i] = nums[i] == 0 ? 0 : counts[nums[i] - 1];

        return nums;
    }

    public int[] SmallerNumbersThanCurrent_Slow(int[] nums)
    {
        var n = nums.Length;
        var ordNums = nums.Select((x, i) => (value: x, index: i)).OrderBy(n => (int)n.value).ToArray();
        var ans = new int[n];
        ans[ordNums[0].index] = 0;
        for (int i = 1; i < n; i++)
            ans[ordNums[i].index] = ordNums[i].value != ordNums[i - 1].value ? i : ans[ordNums[i - 1].index];
        return ans;
    }
}