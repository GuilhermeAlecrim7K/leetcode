namespace SharpLeetCode.Problems.Easy;

public class Leet00066PlusOne
{
    public int[] PlusOne(int[] digits)
    {
        var carry = true;
        for (int i = digits.Length -1; carry && i >= 0; i--)
        {
            digits[i]++;
             if (digits[i] == 10)
             {
                 carry = true;
                 digits[i] = 0;
             }
             else
                carry = false;
        }
        if (carry)
            digits = [1, ..digits];
        return digits;
    }
}