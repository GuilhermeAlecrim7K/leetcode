namespace SharpLeetCode.Problems.Medium;

public class Leet00937ReorderDataInLogFiles
{

    public string[] ReorderLogFiles(string[] logs)
    {
        var letterQueue = new List<string>();
        var digitQueue = new List<string>();

        for (int i = 0; i < logs.Length; i++)
        {
            var word = logs[i];
            var delimiterIndex = word.IndexOf(' ');
            if (char.IsDigit(word[delimiterIndex + 1]))
                digitQueue.Add(word);
            else
                letterQueue.Add(word);
        }

        letterQueue.Sort((left, right) =>
                {
                    var leftDelimiterIndex = left.IndexOf(' ');
                    var rightDelimiterIndex = right.IndexOf(' ');
                    
                    var leftContent = left.Substring(leftDelimiterIndex + 1);
                    var rightContent = right.Substring(rightDelimiterIndex + 1);
                    var compareContent = string.Compare(leftContent, rightContent, StringComparison.Ordinal);

                    if (compareContent == 0)
                    {
                        var leftId = left.Substring(0, leftDelimiterIndex);
                        var rightId = right.Substring(0, rightDelimiterIndex);
                        return string.Compare(leftId, rightId, StringComparison.Ordinal);
                    }
                    return compareContent;

                });
        letterQueue.AddRange(digitQueue);
        return letterQueue.ToArray();
    }

    public string[] ReorderLogFilesLinqApproach(string[] logs)
    {
        var counter = 1000;
        return
            logs
            .Select(l =>
            {
                var contents = l.Split(" ");
                return new { FullLog = l, Identifier = contents[0], Content = string.Join(" ", contents[1..]), IsLetterLog = char.IsLetter(contents[1][0]) };
            })
            .OrderByDescending(l => l.IsLetterLog)
            .ThenBy(l => l.IsLetterLog ? l.Content : $"{counter++}")
            .ThenBy(l => l.IsLetterLog ? l.Identifier : $"{counter++}")
            .Select(l => l.FullLog)
            .ToArray();
    }

    private record struct LogInfo(int Index, string FullLog, string Identifier, string Content, bool IsLetterLog);

    public string[] ReorderLogFilesSlowAndManual(string[] logs)
    {
        var info = logs
            .Select((l, i) =>
            {
                var contents = l.Split(" ");
                return new LogInfo { Index = i, FullLog = l, Identifier = contents[0], Content = string.Join(" ", contents[1..]), IsLetterLog = char.IsLetter(contents[1][0]) };
            })
            .ToArray();
        Array.Sort(info, Comparer<LogInfo>.Create((left, right) =>
            {
                if (left.IsLetterLog)
                {
                    if (!right.IsLetterLog) return -1;
                    var compareContent = StringComparer.InvariantCulture.Compare(left.Content, right.Content);
                    if (compareContent != 0) return compareContent;
                    return StringComparer.InvariantCulture.Compare(left.Identifier, right.Identifier);
                }
                if (right.IsLetterLog) return 1;
                return left.Index - right.Index;
            }));
        return info.Select(i => i.FullLog).ToArray();
    }

}