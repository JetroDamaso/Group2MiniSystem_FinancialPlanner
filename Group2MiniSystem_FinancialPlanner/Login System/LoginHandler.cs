using Group2MiniSystem_FinancialPlanner.FinancialPlanner;
using Microsoft.Data.SqlClient;
using System.Data;

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
        private static string Username, Password;
        private static int UserID, currentUserID;
        private List<String> UsernameBank = new List<string>();
        private List<String> PasswordBank = new List<string>();
        string connectionString;
        private string ViewClubMembers = "SELECT ID, Username, Password FROM Credentials";


        //Please update ConnectionString when opening from different computer.
        ConnectionString connectString = new ConnectionString();

        //Initiates Database Handlers and Connections
        public LoginHandler()
        {
            connectionString = connectString.getConnectString();

            sqlConnect = new SqlConnection();
            sqlConnect.ConnectionString = connectionString;

            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }


        //Registers parameters to Database
        public void pushCredentials(int ID, string username, string password)
        {
            try
            {
                ID = ID;
                Username = username;
                Password = password;

                string sqlQuery = "INSERT INTO Credentials VALUES(@Id, @Username, @Password)";
                sqlCommand = new SqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                sqlCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
                sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;

                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Complete Inputs.");
            }
        }

        //Fetches data from the Database
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

        //Login condition. If Username doesn't exist, and match password, return false
        public bool Login(string username, string password)
        {
            sqlConnect = new SqlConnection(connectionString);
            string sqlQuerryUsername = "SELECT Username, Password FROM Credentials WHERE Username = @UsernameInput";

            sqlConnect.Open();
            //Get Usernames
            sqlCommand = new SqlCommand(sqlQuerryUsername, sqlConnect);
            sqlCommand.Parameters.Add("@UsernameInput", SqlDbType.VarChar).Value = username;
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Username = reader.GetValue(0).ToString();
                Password = reader.GetValue(1).ToString();
            }

            sqlConnect.Close();

            if (UsernameBank.Contains(username) && PasswordBank.Contains(password) && Username.Equals(username) && Password.Equals(password))
            {
                return true;
            }

            else { return false; }
        }

        //Select the latest ID from database.
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

        //Select the id of the current signed in user
        public void getCurrentID()
        {
            LoginForm loginForm = new LoginForm();
            sqlConnect = new SqlConnection(connectionString);
            string sqlQuerry = "SELECT ID FROM Credentials WHERE Username = @Username AND Password = @Password";

            sqlConnect.Open();
            sqlCommand = new SqlCommand(sqlQuerry, sqlConnect);
            sqlCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;
            sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;

            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                currentUserID = Convert.ToInt32(reader.GetValue(0).ToString());
            }

            sqlConnect.Close();
        }

        //Return Blocks
        public int getcurrentID()
        {
            getCurrentID();
            return currentUserID;
        }

        public String getUsername()
        {
            return Username;
        }

        public int getID()
        {
            setID();
            return UserID;
        }

    }
}
