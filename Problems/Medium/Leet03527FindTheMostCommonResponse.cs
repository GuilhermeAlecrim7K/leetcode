namespace SharpLeetCode.Problems.Medium;

public class Leet03527FindTheMostCommonResponse
{
    public string FindCommonResponse(IList<IList<string>> responses)
    {
        var uniqueResponsesCount = new Dictionary<string, int>();
        var previousHighest = ("", -1);
        foreach (var response in responses)
        {
            var uniqueResponses = new HashSet<string>();
            foreach (var r in response)
            {
                if (uniqueResponses.Contains(r))
                    continue;

                if (!uniqueResponsesCount.TryAdd(r, 1))
                    uniqueResponsesCount[r]++;
                var c = uniqueResponsesCount[r];
                if (
                        c > previousHighest.Item2 ||
                        (c == previousHighest.Item2 && string.CompareOrdinal(r, previousHighest.Item1) < 0)
                )
                    previousHighest = (r, c);
                uniqueResponses.Add(r);
            }
        }

        return previousHighest.Item1;
    }
}