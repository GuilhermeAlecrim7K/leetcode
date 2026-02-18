namespace SharpLeetCode.Problems.Medium;

public class Leet03039ApplyOperationsToMakeStringEmpty
{
    private static readonly int alsz = 26;

    public string LastNonEmptyString(string s)
    {
        var alphabet = new (int count, int lastIndex, char c)[alsz];
        var highest = int.MinValue;
        for (int i = 0; i < s.Length; i++)
        {
            var idxOfChar = s[i] - 'a';
            alphabet[idxOfChar].c = s[i];
            highest = int.Max(highest, ++alphabet[idxOfChar].count);
            alphabet[idxOfChar].lastIndex = i;
        }

        return new string(alphabet.Where(x => x.count == highest).OrderBy(x => x.lastIndex).Select(x => x.c).ToArray());
    }

    public string LastNonEmptyStringBrokeTimeLimit(string s)
    {
        // AlphabetSize
        var alphabet = new bool[alsz];
        var prevChars = new char[alsz];
        var sb = new System.Text.StringBuilder(s);

        int indexOfLastChar = 0;
        while(sb.Length > 0)
        {
            indexOfLastChar = 0;
            Array.Clear(alphabet);
            for (int i = 0; i < sb.Length; i++)
            {
                var idxOfChar = sb[i] - 'a';
                if (alphabet[idxOfChar])
                    continue;

                alphabet[idxOfChar] = true;
                prevChars[indexOfLastChar++]= sb[i];
                sb.Remove(i--, 1);
                if (indexOfLastChar >= alsz)
                    break;
            }
        }

        return new string(prevChars, 0, indexOfLastChar);
    }
}