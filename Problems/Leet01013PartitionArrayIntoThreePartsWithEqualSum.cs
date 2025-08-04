namespace SharpLeetCode.Problems;

// https://leetcode.com/problems/partition-array-into-three-parts-with-equal-sum/
public class Leet01013PartitionArrayIntoThreePartsWithEqualSum
{
    private int FetchIndexOfNextPart(int[] arr, int start, int expectedSum)
    {
        var currentSum = arr[start];
        int i;
        for (i = start + 1; i < arr.Length && currentSum != expectedSum; i++)
        {
            currentSum += arr[i];
        }
        return i;
    }

    public bool CanThreePartsEqualSum(int[] arr)
    {
        var totalSum = arr.Sum();
        if (totalSum % 3 != 0)
            return false;

        var expectedSumOfParts = totalSum / 3;

        var indexOfNextPart = FetchIndexOfNextPart(arr, 0, expectedSumOfParts);
        if (indexOfNextPart == arr.Length)
            return false;
        indexOfNextPart = FetchIndexOfNextPart(arr, indexOfNextPart, expectedSumOfParts);
        if (indexOfNextPart == arr.Length)
            return false;

        var sumOfLastPart = 0;
        for (int i = indexOfNextPart; i < arr.Length; i++)
            sumOfLastPart += arr[i];

        return sumOfLastPart == expectedSumOfParts;
    }
}