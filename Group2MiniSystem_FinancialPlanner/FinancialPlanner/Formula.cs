namespace Group2MiniSystem_FinancialPlanner
{
    internal class Formula
    {
        // Calculates savings after expenses
        public double CalculateSavings(double totalIncome, double totalExpenses)
        {
            double savings = totalIncome - totalExpenses; // S = TI - TE
            return savings;
        }

        // Calculates savings contribution per period
        public double CalculateGoal(double savingsGoal, double periods)
        {
            if (periods <= 0)
                throw new ArgumentException("Timeframe must be greater than zero.");

            double savingsPerPeriod = savingsGoal / periods; // SP = SG / T
            return savingsPerPeriod;
        }

        // Allocates budget based on category percentage
        public static double AllocateBudget(double totalIncome, double categoryPercentage)
        {
            if (categoryPercentage < 0 || categoryPercentage > 100)
                throw new ArgumentException("Category percentage must be between 0 and 100.");

            double allocatedBudget = totalIncome * (categoryPercentage / 100); // AB = TI × CP / 100
            return allocatedBudget;
        }

        // Distributes the budget among categories'Total percentage allocation must equal 100
        public (double Food, double ElectricWater, double Emergency) DistributeBudget(
            double totalIncome,
            double foodPercentage,
            double electricWaterPercentage,
            double emergencyPercentage)
        {
            /*
            // Validate total percentage
            double totalPercentage = foodPercentage + electricWaterPercentage + emergencyPercentage;
            if (totalPercentage != 100)
                throw new ArgumentException("Total percentage allocation must equal 100%.");
            */

            // Calculate allocated budgets
            double foodBudget = AllocateBudget(totalIncome, foodPercentage);
            double electricWaterBudget = AllocateBudget(totalIncome, electricWaterPercentage);
            double emergencyBudget = AllocateBudget(totalIncome, emergencyPercentage);

            return (foodBudget, electricWaterBudget, emergencyBudget);
        }

    }
}
