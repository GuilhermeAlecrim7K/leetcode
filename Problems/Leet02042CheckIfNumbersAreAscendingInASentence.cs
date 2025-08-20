namespace SharpLeetCode.Problems;

public class Leet02042CheckIfNumbersAreAscendingInASentence
{
    public bool AreNumbersAscending(string s)
    {
        var n = s.Length;
        var previousNumber = -1;
        var foo = new Span<char>(new char[3]);
        for (int i = 0; i < n; i++)
        {
            foo[0] = '\0';
            foo[1] = '\0';
            foo[2] = '\0';
            int j = 0;
            while (i < n && char.IsDigit(s[i]))
                foo[j++] = s[i++];
            if (foo[0] == '\0')
                continue;
            var curNumber = int.Parse(foo, System.Globalization.NumberStyles.Number);
            if (curNumber <= previousNumber)
                return false;
            previousNumber = curNumber;
        }

        return true;
    }
}