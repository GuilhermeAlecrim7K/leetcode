namespace SharpLeetCode.Problems;

public class Leet01846MaximumElementAfterDecreasingAndRearranging
{
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr)
    {
        int n = arr.Length;
        Array.Sort(arr);
        for (int i = 1; i < n; i++)
        {
            if (int.Abs(arr[i] - arr[i - 1]) > 1)
                arr[i] = arr[i - 1] + 1;
        }
        return arr[n - 1];
    }
}