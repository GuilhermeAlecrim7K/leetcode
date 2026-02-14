namespace SharpLeetCode.Problems.Easy;

public class Leet00027RemoveElement
{
    public int RemoveElement(int[] nums, int val)
    {
        if (val > 50) return nums.Length;
        int newLength = nums.Length;
        for (int i = 0, j = newLength - 1; i < newLength; i++)
        {
            if (nums[i] != val)
                continue;

            newLength--;
            while (j > i && nums[j] == val)
            {
                j--;
                newLength--;
            }
            if (i >= j)
                break;

            (nums[i], nums[j]) = (nums[j], nums[i]);
            j--;
        }
        return newLength;
    }
}