namespace SharpLeetCode.Problems;

public class Leet02864MaximumOddBinaryNumber
{
    public string MaximumOddBinaryNumberSecondAttempt(string s)
    {
        var n = s.Length;
        var c = s.ToCharArray();
        var lastOnBit = 0;
        for (int i = 0, j = 1; j < n; j++)
        {
            if (c[i] == '1')
            {
                lastOnBit = i;
                i++;
                continue;
            }
            // c[i] == 0
            if (c[j] == '1')
            {
                lastOnBit = i;
                (c[i], c[j]) = (c[j], c[i]);
                i++;
            }
        }
        if (lastOnBit != n - 1)
            (c[lastOnBit], c[n - 1]) = (c[n - 1], c[lastOnBit]);

        return new string(c);
    }

    public string MaximumOddBinaryNumberVeryInneficient(string s)
    {
        var n = s.Length;
        var sb = new System.Text.StringBuilder(capacity: n);
        var ones = s.Count(c => c == '1');
        sb.AppendJoin("", Enumerable.Repeat('1', ones - 1));
        sb.AppendJoin("", Enumerable.Repeat('0', n - ones));
        sb.Append('1');
        return sb.ToString();
    }
}