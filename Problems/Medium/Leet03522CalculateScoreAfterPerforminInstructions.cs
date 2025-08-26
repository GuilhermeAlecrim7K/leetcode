namespace SharpLeetCode.Problems.Medium;

public class Leet03522CalculateScoreAfterPerforminInstructions
{
    public long CalculateScore(string[] instructions, int[] values)
    {
        long result = 0;
        var n = values.Length;
        for (int i = 0; i >= 0 && i < n;)
        {
            var newI = i;
            if (instructions[i][0] == 'a')
            {
                result += values[i];
                newI++;
            }
            else if (instructions[i][0] == 'j')
            {
                newI += values[i];
            }
            else
                break;
            instructions[i] = "e";
            i = newI;
        }
        return result;
    }
}