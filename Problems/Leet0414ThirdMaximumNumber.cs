namespace SharpLeetCode.Problems;

public class Leet0414ThirdMaximumNumber
{
    public int ThirdMax(int[] nums)
    {
        var firstMax = nums[0];
        int? secondMax = null;
        int? thirdMax = null;
        foreach (var num in nums)
        {
            if (num == firstMax || num == secondMax || num == thirdMax)
                continue;
            if (num > firstMax)
                (thirdMax, secondMax, firstMax) = (secondMax, firstMax, num);
            else if (num > (secondMax ?? int.MinValue))
                (thirdMax, secondMax) = (secondMax, num);
            else if (num > (thirdMax ?? int.MinValue))
                thirdMax = num;
        }

        return thirdMax ?? firstMax;
    }
}