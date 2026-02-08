namespace SharpLeetCode.Problems.Easy;

public class Leet03206AlternatingGroupsI
{
    public int NumberOfAlternatingGroups(int[] colors)
    {
        var numberOfAlternatingGroups = 0;
        const int alternatingTilesToCountAsAGroup = 3;
        var n = colors.Length;
        for (int i = 1, previousColor = colors[0], alternatingTilesCount = 1; i < n + alternatingTilesToCountAsAGroup - 1; i++)
        {
            if (colors[i % n] != previousColor)
                alternatingTilesCount++;
            else
                alternatingTilesCount = 1;
            if (alternatingTilesCount >= alternatingTilesToCountAsAGroup)
                numberOfAlternatingGroups++;
            previousColor = colors[i % n];
        }
        return numberOfAlternatingGroups;
    }
}