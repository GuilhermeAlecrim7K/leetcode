namespace SharpLeetCode.Problems;

// https://leetcode.com/problems/total-distance-traveled/
public class Leet02739TotalDistanceTraveled
{
    public int DistanceTraveledSolvedInConstantTime(int mainTank, int additionalTank)
    {
        const int kmPerLiterMileage = 10;
        const int amountOfLitersThatTriggerAdditionalTank = 5;
        const int amountOfFuelInjectedWhenAdditionalTankTriggered = 1;

        var totalLitersInjectedByAdditionalTank = (mainTank - amountOfFuelInjectedWhenAdditionalTankTriggered) / (amountOfLitersThatTriggerAdditionalTank - amountOfFuelInjectedWhenAdditionalTankTriggered);
        var totalAmountInjectedByAdditionalTank = int.Min(additionalTank, totalLitersInjectedByAdditionalTank);

        return (mainTank + totalAmountInjectedByAdditionalTank) * kmPerLiterMileage;
    }

    public int DistanceTraveledSolvedByIteration(int mainTank, int additionalTank)
    {
        const int kmPerLiterMileage = 10;
        const int amountOfLitersThatTriggerAdditionalTank = 5;
        const int amountOfFuelInjectedWhenAdditionalTankTriggered = 1;

        var distanceTraveled = 0;
        while (mainTank >= amountOfLitersThatTriggerAdditionalTank)
        {
            distanceTraveled += amountOfLitersThatTriggerAdditionalTank * kmPerLiterMileage;
            mainTank -= amountOfLitersThatTriggerAdditionalTank;
            if (additionalTank >= amountOfFuelInjectedWhenAdditionalTankTriggered)
            {
                mainTank += amountOfFuelInjectedWhenAdditionalTankTriggered;
                additionalTank -= amountOfFuelInjectedWhenAdditionalTankTriggered;
            }
            else
                break;
        }
        distanceTraveled += mainTank * kmPerLiterMileage;
        return distanceTraveled;
    }
}