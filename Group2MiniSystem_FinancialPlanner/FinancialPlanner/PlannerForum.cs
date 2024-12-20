namespace Group2MiniSystem_FinancialPlanner.FinancialPlanner
{
    public partial class PlannerForum : Form
    {

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

        //Class Objects
        NamePlanner namePlanner = new NamePlanner();
        LoginForm loginForm = new LoginForm();
        DatabaseHandler databaseHandler = new DatabaseHandler();
        LoginHandler loginHandler = new LoginHandler();
        PlanOpener planOpener = new PlanOpener();
        Formula formula = new Formula();

        public PlannerForum()
        {
            InitializeComponent();

            //Adds information to Combo Box
            cbTimeOption.Items.Add("Days");
            cbTimeOption.Items.Add("Weeks");
            cbTimeOption.Items.Add("Months");
            cbTimeOption.Items.Add("Years");
        }

        //Fetches lastest Plan ID++
        public int plusID()
        {
            this.ID = databaseHandler.getID();
            ID++;
            return ID;
        }

        //Save to Account Button
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


            }
            catch (Exception)
            {
                MessageBox.Show("Please Complete Inputs.");
            }
        }

        //Open Plans Button
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

        //Run Button
        private void buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                double ti = Convert.ToDouble(txtboxTotalIncome.Text);
                double te = Convert.ToDouble(txtboxTotalExpenses.Text);
                double sg = Convert.ToDouble(txtboxSavingsGoal.Text);
                double t = Convert.ToInt32(txtboxTimeFrame.Text);
                double cpFood = Convert.ToDouble(txtFoodAllocation.Text);
                double cpElectricWater = Convert.ToDouble(txtElectricWaterBill.Text);
                double cpEmergency = Convert.ToDouble(txtEmergencyFund.Text);

 
                var budgetAllocations = formula.DistributeBudget(ti, cpFood, cpElectricWater, cpEmergency);
                
                lblFoodAllocation.Text = Convert.ToString(Math.Round(budgetAllocations.Food,2));
                lblElectricWaterAllocation.Text = Convert.ToString(Math.Round(budgetAllocations.ElectricWater,2));
                lblEmergencyFundAllocation.Text = Convert.ToString(Math.Round(budgetAllocations.Emergency,2));
  
                lblSavings.Text = Convert.ToString(Math.Round(formula.CalculateSavings(ti, te), 2));
                lblSavingsPerPeriod.Text = Convert.ToString(Math.Round(formula.CalculateGoal(sg, t), 2));
    

      }
            catch (Exception)
            {
                MessageBox.Show("Please Complete Inputs.");
            }
        }


        //Reset Button
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtboxSavingsGoal.Clear();
            txtboxTimeFrame.Clear();
            txtboxTotalExpenses.Clear();
            txtboxTotalIncome.Clear();
            txtElectricWaterBill.Clear();
            txtEmergencyFund.Clear();
            txtFoodAllocation.Clear();

            lblElectricWaterAllocation.Text = "";
            lblEmergencyFundAllocation.Text = "";
            lblFoodAllocation.Text = "";
            lblSavings.Text = "";
            lblSavingsPerPeriod.Text = "";
        }

        //Go back to Login Link
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.ShowDialog();

        }
    }
}
