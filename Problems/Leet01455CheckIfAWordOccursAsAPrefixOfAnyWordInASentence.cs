namespace SharpLeetCode.Problems;

// https://leetcode.com/problems/check-if-a-word-occurs-as-a-prefix-of-any-word-in-a-sentence
public class Leet01455CheckIfAWordOccursAsAPrefixOfAnyWordInASentence
{
    public int IsPrefixOfWord(string sentence, string searchWord)
    {
        var currentIndexOfWord = 1;
        for (int i = 0; i < sentence.Length; i++)
        {
            var foundWord = true;
            for (int j = i, k = 0; k < searchWord.Length; j++, k++)
            {
                if (j >= sentence.Length || sentence[j] != searchWord[k])
                {
                    foundWord = false;
                    i = j;
                    while (i < sentence.Length && !char.IsWhiteSpace(sentence[i]))
                        i++;
                    currentIndexOfWord++;
                    break;
                }
            }
            if (foundWord)
                return currentIndexOfWord;
        }
        return -1;
    }
}