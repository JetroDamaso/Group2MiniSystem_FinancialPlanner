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
    public partial class RegisterForm : Form
    {
        LoginHandler loginHandler = new LoginHandler();
        private String Username, Password;
        private int ID;

        public RegisterForm()
        {
            InitializeComponent();
        }

        public int plusID()
        {
            this.ID = loginHandler.getID();
            ID++;
            return ID;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Username = textBoxUsername.Text;
            Password = textBoxPassword.Text;

            loginHandler.pushCredentials(plusID(), Username, Password);
            loginHandler.getCredentials();

            MessageBox.Show("Register Success!");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            
        }
    }
}
