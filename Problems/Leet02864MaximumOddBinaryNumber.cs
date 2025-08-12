namespace SharpLeetCode.Problems;

public class Leet02864MaximumOddBinaryNumber
{
    public string MaximumOddBinaryNumber(string s)
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