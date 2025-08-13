namespace SharpLeetCode.Problems;

public class Leet007171BitAnd2BitCharacters
{
    public bool IsOneBitCharacter(int[] bits)
    {
        var n = bits.Length;
        var lastCharacterIsOneBit = true;
        for (int i = 0; i < n; i++)
        {
            if (bits[i] == 1)
            {
                lastCharacterIsOneBit = false;
                i++;
            }
            else
                lastCharacterIsOneBit = true;
        }
        return lastCharacterIsOneBit;
    }
}