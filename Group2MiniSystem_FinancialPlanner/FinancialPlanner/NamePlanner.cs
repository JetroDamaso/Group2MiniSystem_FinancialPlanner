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
    public partial class NamePlanner : Form
    {
        public NamePlanner()
        {
            InitializeComponent();
        }

        private string PlanName;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.PlanName = txtPlanName.Text;
            this.Close();
        }

        public string getPlanName()
        {
            return this.PlanName;
        }
    }
}
