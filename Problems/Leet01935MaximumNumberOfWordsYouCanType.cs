namespace SharpLeetCode.Problems;

public class Leet01935MaximumNumberOfWordsYouCanType
{
    public int CanBeTypedWords(string text, string brokenLetters)
    {
        var broken = new bool[26];
        foreach (var c in brokenLetters)
            broken[c - 'a'] = true;

        var canBeTypedWordsCount = 0;
        var currentWordContainsABrokenLetter = false;
        foreach (var c in text)
        {
            if (c == ' ')
            {
                if (!currentWordContainsABrokenLetter)
                    canBeTypedWordsCount++;
                currentWordContainsABrokenLetter = false;
                continue;
            }
            if (broken[c - 'a'])
                currentWordContainsABrokenLetter = true;
        }
        if (!currentWordContainsABrokenLetter)
            canBeTypedWordsCount++;
        return canBeTypedWordsCount;
    }
}