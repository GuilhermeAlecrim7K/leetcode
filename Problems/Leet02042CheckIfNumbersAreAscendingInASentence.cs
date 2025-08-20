namespace SharpLeetCode.Problems;

public class Leet02042CheckIfNumbersAreAscendingInASentence
{
    public bool AreNumbersAscending(string s)
    {
        return s.Split(" ").Aggregate(-1, (n, s) =>
        {
            if (!int.TryParse(s, out var n2))
                return n;
            if (n2 > n)
                return n2;
            else
                return int.MaxValue;
        }) != int.MaxValue;
    }
}