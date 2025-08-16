namespace SharpLeetCode.Problems;

public class Leet00342PowerOfFour
{
    public bool IsPowerOfFour(int n)
    {
        if (n < 1)
            return false;
        if (n == 1)
            return true;
        // if any of the first two bits are set at any time, it is not a power of four
        if ((n & 0b11) > 0)
            return false;
        return IsPowerOfFour(n >> 2);
    }
}