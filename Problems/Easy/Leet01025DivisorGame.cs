namespace SharpLeetCode.Problems.Easy;

public class Leet01025DivisorGame
{
    public bool DivisorGame(int n)
    {
        return (n & 1) == 0;
    }
}