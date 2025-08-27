namespace SharpLeetCode.Problems.Easy;

public class Leet03151SpecialArrayI
{
    public bool IsArraySpecial(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            if (((nums[i] ^ nums[i - 1]) & 1) == 0)
                return false;
        }
        return true;
    }
}