namespace SharpLeetCode.Problems.Easy;

public class Leet00492ConstructTheRectangle
{
    public int[] OptimizedConstructRectangle(int area)
    {
        int w = (int)Math.Sqrt(area);
        while(area % w != 0)
            w--;
        return new int[2] { area / w, w};
    }

    public int[] SlowConstructRectangle(int area)
    {
        int n = (int)Math.Sqrt(area);
        var ans = new int[2] { area, 1 };
        for (int l = area - 1; l >= n; l--)
        {
            if (area % l != 0)
                continue;
            int w = area / l;
            if (w > l)
                break;
            ans[0] = l;
            ans[1] = w;
        }
        return ans;
    }
}