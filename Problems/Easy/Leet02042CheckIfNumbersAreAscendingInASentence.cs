namespace SharpLeetCode.Problems.Easy;

public class Leet02042CheckIfNumbersAreAscendingInASentence
{
    public bool AreNumbersAscending(string s)
    {
        var n = s.Length;
        var previousNumber = int.MaxValue;
        for (int i = n - 1; i >= 0; i--)
        {
            int? curNumber = null;
            int j = 1;
            while (i >= 0 && char.IsDigit(s[i]))
            {
                curNumber ??= 0;
                curNumber += (s[i--] - '0') * j;
                j *= 10;
            }
            if (curNumber is null)
                continue;
            if (curNumber >= previousNumber)
                return false;
            previousNumber = curNumber ?? 0;
        }

        return true;
    }
}