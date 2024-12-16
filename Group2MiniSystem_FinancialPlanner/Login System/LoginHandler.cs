using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Group2MiniSystem_FinancialPlanner
{
    internal class LoginHandler
    {
        //Database Handlers
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader; 
        public DataTable dataTable;
        public BindingSource bindingSource;

        //Credentials Handler
        private string Username;
        private string Password;
        private int UserID, currentUserID;
        private List<String> UsernameBank = new List<string>();
        private List<String> PasswordBank = new List<string>();
        string connectionString;
        private string ViewClubMembers = "SELECT ID, Username, Password FROM Credentials";

        

        //Please update ConnectionString when opening from different computer.
        


        public LoginHandler()
        {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jetro\source\repos\Group2MiniSystem_FinancialPlanner\Group2MiniSystem_FinancialPlanner\Credentials Database\CredentialsDatabase.mdf"";Integrated Security=True";

            sqlConnect = new SqlConnection();
            sqlConnect.ConnectionString = connectionString;

            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }


        //REGISTER
        public bool pushCredentials(int ID, string username, string password)
        {

            string sqlQuery = "INSERT INTO Credentials VALUES(@Id, @Username, @Password)";
            sqlCommand = new SqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            sqlCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
            sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;

            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            return true;
        }

        //REGISTER & LOGIN
        public void getCredentials()
        {
            sqlConnect = new SqlConnection(connectionString);
            string sqlQuerryUsername = "SELECT Username, Password FROM Credentials";

            sqlConnect.Open();
            //Get Usernames
            sqlCommand = new SqlCommand(sqlQuerryUsername, sqlConnect);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read()) 
            {
                UsernameBank.Add(reader.GetValue(0).ToString());
                PasswordBank.Add(reader.GetValue(1).ToString());
            }

            sqlConnect.Close();
        }

        //LOGIN
        public bool Login(string username, string password) 
        {

            this.Username = username;
            this.Password = password;

            if (UsernameBank.Contains(username) && PasswordBank.Contains(password))
            {
                return true;
            }

            else { return false; }
        }

        public bool DisplayList()
        {
            dataTable = new DataTable();

            sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect);

            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
            return true;
        }


        public void setID()
        {
            sqlConnect = new SqlConnection(connectionString);
            string sqlQuerryUsername = "SELECT TOP 1 ID FROM Credentials ORDER BY ID DESC";

            sqlConnect.Open();
            sqlCommand = new SqlCommand(sqlQuerryUsername, sqlConnect);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                UserID = Convert.ToInt32(reader.GetValue(0).ToString());
            }
    
            sqlConnect.Close();
        }

        public int getID()
        {
            setID();
            return UserID;
        }



        public void getCurrentID()
        {
            LoginForm loginForm = new LoginForm();
            sqlConnect = new SqlConnection(connectionString);
            string sqlQuerry = "SELECT ID FROM Credentials WHERE Username = @Username AND Password = @Password";

            sqlConnect.Open();
            sqlCommand = new SqlCommand(sqlQuerry, sqlConnect);
            sqlCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = "admin";
            sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = "admin";


            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
               currentUserID = Convert.ToInt32(reader.GetValue(0).ToString());
            }

            sqlConnect.Close();
        }

   

        public int getcurrentID()
        {
            getCurrentID();
            return currentUserID;
        }

        public String getUsername()
        {
            return this.Username;
        }

        public String getPassword()
        {
            return this.Password;
        }

    }
}
