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

        //Select latest User ID++
        public int plusID()
        {
            this.ID = loginHandler.getID();
            ID++;
            return ID;
        }

        //Register Button
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Username = textBoxUsername.Text;
            Password = textBoxPassword.Text;

            loginHandler.pushCredentials(plusID(), Username, Password);
            loginHandler.getCredentials();

            MessageBox.Show("Register Success!");
        }

        //Go back to login
        private void label5_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }
    }
}
