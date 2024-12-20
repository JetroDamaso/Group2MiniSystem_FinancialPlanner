using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2MiniSystem_FinancialPlanner
{
    internal class Formula
    {
        public double calculateSavings(double ti, double te)
        {
            double res = ti -= te;
            return res;
        }

        public double calculateGoal(double sg, double t)
        {
            double res = sg /= t;
            return res;
        }

        public double allocateBudgetFood(double ti, double cp)
        {
            double res = ti *= (cp / 0.20);
            return res;
        }
        public double allocateBudgetElectricWater(double ti, double cp)
        {
            double res = ti *= (cp / 0.0667);
            return res;
        }
        public double allocateBudgetEmergency(double ti, double cp)
        {
            double res = ti *= (cp / 0.10);
            return res;
        }
    }
}
