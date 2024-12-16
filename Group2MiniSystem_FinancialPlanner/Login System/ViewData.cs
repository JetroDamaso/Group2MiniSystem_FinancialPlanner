using Group2MiniSystem_FinancialPlanner.FinancialPlanner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2MiniSystem_FinancialPlanner
{
    public partial class ViewData : Form
    {
        public ViewData()
        {
            InitializeComponent();
        }
        DatabaseHandler databaseHandler = new DatabaseHandler();

        private void ViewData_Load(object sender, EventArgs e)
        {
            databaseHandler.DisplayList();
            dataGridView1.DataSource = databaseHandler.bindingSource;
        }
    }
}
