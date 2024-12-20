using Group2MiniSystem_FinancialPlanner.FinancialPlanner;

namespace Group2MiniSystem_FinancialPlanner
{
    public partial class LoginForm : Form
    {
        private string Username;
        private string Password;
        LoginHandler loginHandler = new LoginHandler();

        public LoginForm()
        {
            InitializeComponent();
        }

        //Login Button. If credentials are wrong, send error message.
        private void button1_Click(object sender, EventArgs e)
        {
            Username = textBox1.Text;
            Password = textBox2.Text;

            loginHandler.getCredentials();
            bool loginBool = loginHandler.Login(Username, Password);

            if (loginBool == true)
            {
                PlannerForum plannerForum = new PlannerForum();
                this.Hide();
                plannerForum.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials.");
            }
        }

        //Register link.
        private void label5_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();

            this.Hide();
            registerForm.ShowDialog();
        }

    }
}
