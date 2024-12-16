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
        long TotalIncome;
        long TotalExpenses;
        long SavingsGoal;
        string TimeOption;
        int TimeFrame;
        long FoodAllocation;
        long ElectricWaterBill;
        long EmergencyFund;

        NamePlanner namePlanner = new NamePlanner();
        LoginForm loginForm = new LoginForm();
        DatabaseHandler databaseHandler =  new DatabaseHandler();
        LoginHandler loginHandler = new LoginHandler();
        public PlannerForum()
        {
            InitializeComponent();
            

            cbTimeOption.Items.Add("Days");
            cbTimeOption.Items.Add("Weeks");
            cbTimeOption.Items.Add("Months");
            cbTimeOption.Items.Add("Years");

            labelINSERT.Text = loginForm.getUsername();
           


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
            TotalIncome = Convert.ToInt64(txtboxTotalIncome.Text);
            TotalExpenses = Convert.ToInt64(txtboxTotalExpenses.Text);
            SavingsGoal = Convert.ToInt64(txtboxSavingsGoal.Text);
            TimeFrame = Convert.ToInt32(txtboxTimeFrame.Text);
            TimeOption = cbTimeOption.Text;
            FoodAllocation = Convert.ToInt64(txtFoodAllocation.Text);
            ElectricWaterBill = Convert.ToInt64(txtElectricWaterBill.Text);
            EmergencyFund = Convert.ToInt64(txtEmergencyFund.Text);


            databaseHandler.getCurrentUsername();

            Username = loginForm.getUsername().ToString();


            namePlanner.ShowDialog();

            PlanName = namePlanner.getPlanName();
            UserID = loginHandler.getcurrentID();

            databaseHandler.pushData(plusID(), UserID, Username, PlanName, TotalIncome, TotalExpenses, SavingsGoal, TimeOption, TimeFrame, FoodAllocation, ElectricWaterBill, EmergencyFund);

            ViewData viewData = new ViewData();
            viewData.Show();
        }
    }
}
