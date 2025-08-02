namespace SharpLeetCode;

// https://leetcode.com/problems/most-frequent-even-element/
class Leet02404MostFrequentEvenElement
{
    public int MostFrequentEvenElement(int[] nums)
    {
        var evenElements = new Dictionary<int, int>();
        foreach (var n in nums)
        {
            if ((n & 1) == 1)
                continue;
            evenElements[n] = evenElements.GetValueOrDefault(n) + 1;
        }
        return evenElements.OrderByDescending(e => e.Value).ThenBy(e => e.Key).Select(e => e.Key).FirstOrDefault(-1);
    }
}