namespace SharpLeetCode.Problems.Easy;

public class Leet01160FindWordsThatCanBeFormedByCharacters
{
    public int CountCharacters(string[] words, string chars)
    {
        var result = 0;
        (int curWord, int available)[] charCount = new (int, int)[26];
        foreach (var c in chars)
            charCount[c - 'a'].available++;
        foreach (var word in words)
        {
            var goodWord = true;
            foreach (var c in word)
            {
                if (++charCount[c - 'a'].curWord > charCount[c - 'a'].available)
                {
                    goodWord = false;
                    break;
                }
            }
            if (goodWord)
                result += word.Length;

            for (int i = 0; i < charCount.Length; i++)
                charCount[i].curWord = 0;
        }
        return result;
    }
}