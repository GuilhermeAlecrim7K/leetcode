namespace SharpLeetCode.Problems.Easy;

public class Leet01460MakeTwoArraysEqualByReversingSubArrays
{
    public bool CanBeEqual(int[] target, int[] arr)
    {
        var numbers = new Dictionary<int, int>();
        foreach (var n in target)
            if (!numbers.TryAdd(n, 1))
                numbers[n]++;
        foreach (var n in arr)
        {
            if (!numbers.TryGetValue(n, out var m) || m < 1)
                return false;
            numbers[n]--;
        }
        return true;
    }
}