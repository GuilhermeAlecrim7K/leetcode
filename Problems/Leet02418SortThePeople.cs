namespace SharpLeetCode.Problems;

public class Leet02418SortThePeople
{
    public string[] SortPeople(string[] names, int[] heights)
    {
        var people = new List<(string name, int height)>();
        for (int i = 0; i < names.Length; i++)
            people.Add((names[i], heights[i]));
        return people
            .OrderByDescending(p => p.height)
            .Select(p => p.name)
            .ToArray();
    }
}