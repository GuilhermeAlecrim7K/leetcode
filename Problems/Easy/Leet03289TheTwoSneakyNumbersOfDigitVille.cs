namespace SharpLeetCode.Problems.Easy;

public class Leet03289TheTwoSneakyNumbersOfDigitVille
{
    public int[] GetSneakyNumbers(int[] nums)
    {
        var sneakyNumbers = new int[2];
        var lastSneaky = 0;
        Array.Sort(nums);
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                sneakyNumbers[lastSneaky++] = nums[i];
            }
            if (lastSneaky == 2)
                break;
        }
        return sneakyNumbers;
    }
}