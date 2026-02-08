namespace SharpLeetCode.Problems.Easy;

public class Leet02506CountPairsOfSimilarStrings
{
    public int SimilarPairs(string[] words)
    {
        var similarPairs = 0;
        var wordsBitValues = new Dictionary<int, int>();
        foreach (var word in words)
        {
            var currentWordBitValue = 0;
            foreach (char c in word)
            {
                var letterBitValue = 1 << (c - 'a');
                currentWordBitValue |= letterBitValue;
            }
            wordsBitValues.TryAdd(currentWordBitValue, 0);
            similarPairs += wordsBitValues[currentWordBitValue]++;
        }
        return similarPairs;
    }
}