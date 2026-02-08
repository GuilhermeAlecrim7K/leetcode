namespace SharpLeetCode.Problems.Medium;

public class Leet01846MaximumElementAfterDecreasingAndRearranging
{
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr)
    {
        int n = arr.Length;
        var counts = new int[n + 1];
        foreach (var num in arr)
            counts[int.Min(num, n)]++;

        var result = 1;
        for (int i = 2; i < n + 1; i++)
            result = int.Min(result + counts[i], i);

        return result;
    }
}