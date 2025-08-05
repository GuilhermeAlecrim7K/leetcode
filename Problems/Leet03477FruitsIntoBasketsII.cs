namespace SharpLeetCode.Problems;

// https://leetcode.com/problems/fruits-into-baskets-ii/
public class Leet03477FruitsIntoBasketsII
{
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
    {
        var unplaceFruitTypesCount = 0;
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
                unplaceFruitTypesCount++;
        }
        return unplaceFruitTypesCount;
    }
}