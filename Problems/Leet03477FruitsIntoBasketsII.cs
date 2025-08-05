namespace SharpLeetCode.Problems;

// https://leetcode.com/problems/fruits-into-baskets-ii/
public class Leet03477FruitsIntoBasketsII
{
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
    {
        var unplacedFruitTypesCount = 0;
        var basketsTaken = new bool[baskets.Length];
        foreach (var fruitCount in fruits)
        {
            var foundBasketForFruit = false;
            for (int i = 0; i < baskets.Length; i++)
            {
                if (basketsTaken[i])
                    continue;
                if (baskets[i] >= fruitCount)
                {
                    basketsTaken[i] = true;
                    foundBasketForFruit = true;
                    break;
                }
            }
            if (!foundBasketForFruit)
                unplacedFruitTypesCount++;
        }
        return unplacedFruitTypesCount;
    }

    public int NumOfUnplacedFruitsBestPerformance(int[] fruits, int[] baskets)
    {
        var unplacedFruitTypesCount = 0;
        // Apparently, calling `Length` in a loop makes a small difference in very large datasets.
        int n = baskets.Length;
        foreach (var fruitCount in fruits)
        {
            var unplaced = 1;
            for (int i = 0; i < n; i++)
            {
                if (baskets[i] >= fruitCount)
                {
                    baskets[i] = 0;
                    unplaced = 0;
                    break;
                }
            }
            unplacedFruitTypesCount += unplaced;
        }
        return unplacedFruitTypesCount;
    }
}