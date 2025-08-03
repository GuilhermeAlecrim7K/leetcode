namespace SharpLeetCode.Problems;

public class Leet02506CountPairsOfSimilarStrings
{
    public int SimilarPairs(string[] words)
    {
        var wordsBitValues = new Dictionary<int, int>();
        for (int i = 0; i < words.Length; i++)
        {
            var currentWordBitValue = 0;
            for (int j = 0; j < words[i].Length; j++)
            {
                var letterBitValue = 1 << (words[i][j] - 'a');
                currentWordBitValue |= letterBitValue;
            }
            if (!wordsBitValues.TryAdd(currentWordBitValue, 1))
                wordsBitValues[currentWordBitValue]++;
        }
        // binomial coefficient C(n = w.Value, k = 2)
        return wordsBitValues.Sum(w => w.Value * (w.Value - 1) / 2);
    }
}