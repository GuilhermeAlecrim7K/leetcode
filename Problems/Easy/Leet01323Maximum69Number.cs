namespace SharpLeetCode.Problems.Easy;

public class Leet01323Maximum69Number
{
    public int Maximum69Number(int num)
    {
        var digits = num.ToString();
        var positionOfFirst6 = digits.IndexOf('6');
        if (positionOfFirst6 < 0)
            return num;

        var newNumber = new Span<char>(digits.ToCharArray());
        newNumber[positionOfFirst6] = '9';
        return int.Parse(newNumber);
    }
}