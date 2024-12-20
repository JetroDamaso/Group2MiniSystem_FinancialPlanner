using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2MiniSystem_FinancialPlanner.FinancialPlanner
{
    public partial class PlannerForum : Form
    {
        //pushed
        int ID;
        int UserID;
        string Username;
        string PlanName;
        double TotalIncome;
        double TotalExpenses;
        double SavingsGoal;
        string TimeOption;
        int TimeFrame;
        double FoodAllocation;
        double ElectricWaterBill;
        double EmergencyFund;

        NamePlanner namePlanner = new NamePlanner();
        LoginForm loginForm = new LoginForm();
        DatabaseHandler databaseHandler = new DatabaseHandler();
        LoginHandler loginHandler = new LoginHandler();
        PlanOpener planOpener = new PlanOpener();
        Formula formula = new Formula();

        public PlannerForum()
        {
            InitializeComponent();


            cbTimeOption.Items.Add("Days");
            cbTimeOption.Items.Add("Weeks");
            cbTimeOption.Items.Add("Months");
            cbTimeOption.Items.Add("Years");


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public int plusID()
        {
            this.ID = databaseHandler.getID();
            ID++;
            return ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                TotalIncome = Convert.ToDouble(txtboxTotalIncome.Text);
                TotalExpenses = Convert.ToDouble(txtboxTotalExpenses.Text);
                SavingsGoal = Convert.ToDouble(txtboxSavingsGoal.Text);
                TimeFrame = Convert.ToInt32(txtboxTimeFrame.Text);
                TimeOption = cbTimeOption.Text;
                FoodAllocation = Convert.ToDouble(txtFoodAllocation.Text);
                ElectricWaterBill = Convert.ToDouble(txtElectricWaterBill.Text);
                EmergencyFund = Convert.ToDouble(txtEmergencyFund.Text);

                string Username = loginHandler.getUsername();

                namePlanner.ShowDialog();

                PlanName = namePlanner.getPlanName();
                UserID = loginHandler.getcurrentID();

                //push userinputs to databse
                databaseHandler.pushData(plusID(), UserID, Username, PlanName, TotalIncome,
                    TotalExpenses, SavingsGoal, TimeOption, TimeFrame, FoodAllocation, ElectricWaterBill, EmergencyFund);

                ViewData viewData = new ViewData();
                viewData.Show();

            }
            catch (Exception E)
            {
                MessageBox.Show("Please Complete Inputs.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlanOpener planOpener = new PlanOpener();
            planOpener.ShowDialog();

            txtboxTotalIncome.Clear();
            txtboxTotalExpenses.Clear();
            txtboxSavingsGoal.Clear();
            txtboxTimeFrame.Clear();
            txtFoodAllocation.Clear();
            txtElectricWaterBill.Clear();
            txtEmergencyFund.Clear();



            txtboxTotalIncome.Text = Convert.ToString(databaseHandler.getTotalIncome(planOpener.getSelectedPlanID()));
            txtboxTotalExpenses.Text = Convert.ToString(databaseHandler.getTotalExpenses(planOpener.getSelectedPlanID()));
            txtboxSavingsGoal.Text = Convert.ToString(databaseHandler.getSavingsGoal(planOpener.getSelectedPlanID()));
            txtboxTimeFrame.Text = Convert.ToString(databaseHandler.getTimeFrame(planOpener.getSelectedPlanID()));
            cbTimeOption.Text = Convert.ToString(databaseHandler.getTimeOption(planOpener.getSelectedPlanID()));
            txtFoodAllocation.Text = Convert.ToString(databaseHandler.getFoodAllocation(planOpener.getSelectedPlanID()));
            txtElectricWaterBill.Text = Convert.ToString(databaseHandler.getElectricWaterBill(planOpener.getSelectedPlanID()));
            txtEmergencyFund.Text = Convert.ToString(databaseHandler.getEmergencyFund(planOpener.getSelectedPlanID()));

        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                double ti = Convert.ToDouble(txtboxTotalIncome.Text);
                double te = Convert.ToDouble(txtboxTotalExpenses.Text);
                double sg = Convert.ToDouble(txtboxSavingsGoal.Text);
                double t;
                double cpFood = Convert.ToDouble(txtFoodAllocation.Text);
                double cpElectricWater = Convert.ToDouble(txtElectricWaterBill.Text);
                double cpEmergency = Convert.ToDouble(txtEmergencyFund.Text);

                if (cbTimeOption.Text.Equals("Weeks"))
                {
                    t = Convert.ToInt32(txtboxTimeFrame.Text) * 7;
                }
                if (cbTimeOption.Text.Equals("Months"))
                {
                    t = Convert.ToInt32(txtboxTimeFrame.Text) * 30;
                }
                if (cbTimeOption.Text.Equals("Years"))
                {
                    t = Convert.ToInt32(txtboxTimeFrame.Text) * 365;
                }
                else
                {
                    t = Convert.ToInt32(txtboxTimeFrame.Text);
                }

                lblSavings.Text = Convert.ToString(formula.calculateSavings(ti, te));
                lblSavingsPerPeriod.Text = Convert.ToString(formula.calculateGoal(sg, t));

                lblFoodAllocation.Text = Convert.ToString(formula.allocateBudgetFood(sg, cpFood));
                lblElectricWaterAllocation.Text = Convert.ToString(formula.allocateBudgetElectricWater(sg, cpElectricWater));
                lblEmergencyFundAllocation.Text = Convert.ToString(formula.allocateBudgetEmergency(sg, cpEmergency));
            }
            catch (Exception E)
            {
                MessageBox.Show("Please Complete Inputs.");
            }

        }
    }
}
