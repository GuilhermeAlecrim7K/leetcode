namespace SharpLeetCode.Problems.Easy;

public class Leet00645SetMismatch
{
    public int[] FindErrorNumsOptimized(int[] nums)
    {
        var freq = new int[nums.Length];
        var ans = new int[2] { 0, 0 };
        for (int i = 0; i < nums.Length; i++)
        {
            freq[nums[i] - 1]++;
            if (freq[nums[i] - 1] > 1)
                ans[0] = nums[i];
        }

        for (int i = 0; i < freq.Length; i++)
        {
            if (freq[i] == 0)
            {
                ans[1] = i + 1;
                return ans;
            }
        }

        throw new Exception("Expected to find result.");
    }

    public int[] FirstFindErrorNums(int[] nums)
    {
        Array.Sort(nums);
        var ans = new int?[2] { null, null };
        var prev = 0;
        var expectedInc = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == prev)
            {
                ans[0] ??= prev;
                expectedInc--;
                continue;
            }
            if (nums[i] != i + expectedInc)
                ans[1] ??= i + expectedInc;
            prev = nums[i];
            if (ans[0] is not null && ans[1] is not null)
                break;
        }
        return new int[2] { ans[0] ?? -1, ans[1] ?? nums.Length };
    }
}