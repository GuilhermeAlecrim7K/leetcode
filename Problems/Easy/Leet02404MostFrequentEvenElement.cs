namespace SharpLeetCode.Problems.Easy;

// https://leetcode.com/problems/most-frequent-even-element/
public class Leet02404MostFrequentEvenElement
{
    private bool IsEven(int num)
    {
        return (num & 1) == 0;
    }
    public int MostFrequentEvenElement(int[] nums)
    {
        var evenElements = new Dictionary<int, int>();
        foreach (var n in nums)
        {
            if (IsEven(n))
                continue;
            evenElements[n] = evenElements.GetValueOrDefault(n) + 1;
        }
        return evenElements.OrderByDescending(e => e.Value).ThenBy(e => e.Key).Select(e => e.Key).FirstOrDefault(-1);
    }

    public int MostFrequentEvenElementFullyWithLinq(int[] nums)
    {
        return nums
        .Where(IsEven)
        .GroupBy(n => n)
        .OrderByDescending(g => g.Count())
        .ThenBy(g => g.Key)
        .Select(g => g.Key)
        .FirstOrDefault(-1);
    }

    public int MostFrequentEvenElementBestPerformance(int[] nums)
    {
        var evenElements = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (IsEven(num) && !evenElements.TryAdd(num, 1))
                evenElements[num]++;
        }

        if (evenElements.Count == 0)
            return -1;

        var lowestEvenElement = int.MaxValue;
        var maxCount = -1;

        foreach (var pair in evenElements)
        {
            if (pair.Value > maxCount)
                (lowestEvenElement, maxCount) = pair;
            else if (pair.Value == maxCount)
                lowestEvenElement = int.Min(pair.Key, lowestEvenElement);
        }

        return lowestEvenElement;
    }
}