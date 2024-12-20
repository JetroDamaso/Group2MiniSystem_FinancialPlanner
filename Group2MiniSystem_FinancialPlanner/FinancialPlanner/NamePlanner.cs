namespace Group2MiniSystem_FinancialPlanner.FinancialPlanner
{
    public partial class NamePlanner : Form
    {
        public NamePlanner()
        {
            InitializeComponent();
        }

        private string PlanName;

        //Saves the plan name.
        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.PlanName = txtPlanName.Text;
            this.Close();
        }

        //Return blocks
        public string getPlanName()
        {
            return this.PlanName;
        }
    }
}
