namespace SharpLeetCode.Problems;

public class Leet02798NumberOfEmployeesWhoMetTheTarget
{
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
    {
        return hours.Count(h => h >= target);
    }
}