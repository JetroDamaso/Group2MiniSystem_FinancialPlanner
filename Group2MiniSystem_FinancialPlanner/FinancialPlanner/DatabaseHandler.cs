using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2MiniSystem_FinancialPlanner.FinancialPlanner
{
    internal class DatabaseHandler
    {

        //Database Handlers
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;
        public DataTable dataTable;
        public BindingSource bindingSource;

        //Credentials Handler
        private string Username, PlanName,  TimeOption;
        private int ID, UserID, TimeFrame, LatestID, currentUserID;
        private long TotalIncome, TotalExpenses, SavingsGoal, FoodAllocation, ElectricWaterBill, EmergencyFund;
        private List<String> UsernameBank = new List<string>();
        private List<String> PasswordBank = new List<string>();
        string connectionString;

        LoginForm loginForm = new LoginForm();
        LoginHandler loginHandler = new LoginHandler();

        private string ViewClubMembers = "SELECT ID, UserID, Username, Plan_Name, Total_Income, Total_Expenses, Savings_Goal, Time_Option, Time_Frame," +
            "FoodAllocation, ElectricWater_Bill, Emergency_Fund FROM FinancialPlans";


        public DatabaseHandler()
        {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jetro\source\repos\Group2MiniSystem_FinancialPlanner\Group2MiniSystem_FinancialPlanner\Credentials Database\CredentialsDatabase.mdf"";Integrated Security=True";

            sqlConnect = new SqlConnection();
            sqlConnect.ConnectionString = connectionString;
            dataTable = new DataTable();
            bindingSource = new BindingSource();
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

        public bool pushData(int ID, int UserID, string Username, string PlanName, long TotalIncome, long TotalExpenses, long SavingsGoal, string TimeOption, int TimeFrame, long FoodAllocation, long ElectricWaterBill, long EmergencyFund)
        {
            string sqlQuery = "INSERT INTO FinancialPlans VALUES(@ID, @UserID, @Username, @Plan_Name, @Total_Income," +
                "@Total_Expenses, @Savings_Goal, @Time_Option, @Time_Frame, @FoodAllocation, @ElectricWater_Bill, @Emergency_Fund)";
            sqlCommand = new SqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID++;
            sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
            sqlCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;
            sqlCommand.Parameters.Add("@Plan_Name", SqlDbType.VarChar).Value = PlanName;
            sqlCommand.Parameters.Add("@Total_Income", SqlDbType.BigInt).Value = TotalIncome;
            sqlCommand.Parameters.Add("@Total_Expenses", SqlDbType.BigInt).Value = TotalExpenses;
            sqlCommand.Parameters.Add("@Savings_Goal", SqlDbType.BigInt).Value = SavingsGoal;
            sqlCommand.Parameters.Add("@Time_Option", SqlDbType.VarChar).Value = TimeOption;
            sqlCommand.Parameters.Add("@Time_Frame", SqlDbType.BigInt).Value = TimeFrame;
            sqlCommand.Parameters.Add("@FoodAllocation", SqlDbType.BigInt).Value = FoodAllocation;
            sqlCommand.Parameters.Add("@ElectricWater_Bill", SqlDbType.BigInt).Value = ElectricWaterBill;
            sqlCommand.Parameters.Add("@Emergency_Fund", SqlDbType.BigInt).Value = EmergencyFund;

            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            return true;
        }

        public void getDatafromDatabase()
        {
            sqlConnect = new SqlConnection(connectionString);
            string sqlQuerry = "SELECT ID, Username, Plan_Name, Total_Income, Total_Expenses, Savings_Goal, " +
                "Time_Option, Time_Frame, FoodAllocation, ElectricWater_Bill, Emergency_Fund FROM FinancialPlans WHERE UserID = @UserID";

            sqlConnect.Open();

            sqlCommand = new SqlCommand(sqlQuerry, sqlConnect);
            sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                ID = reader.GetInt32(0);
                UserID = reader.GetInt32(1);
                Username = reader.GetString(2);
                PlanName = reader.GetString(3);
                TotalIncome = reader.GetInt64(4);
                TotalExpenses = reader.GetInt64(5);
                SavingsGoal = reader.GetInt64(6);
                TimeOption = reader.GetString(7);
                TimeFrame = reader.GetInt32(8);
                FoodAllocation = reader.GetInt64(9);
                ElectricWaterBill = reader.GetInt64(10);
                EmergencyFund = reader.GetInt64(11);
            }

            sqlConnect.Close();
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



        //set FINANCIAL PLAN ID++
        public void setID()
        {
            sqlConnect = new SqlConnection(connectionString);
            string sqlQuerryUsername = "SELECT TOP 1 ID FROM FinancialPlans ORDER BY ID DESC";

            sqlConnect.Open();
            sqlCommand = new SqlCommand(sqlQuerryUsername, sqlConnect);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                LatestID = Convert.ToInt32(reader.GetValue(0).ToString());
            }

            sqlConnect.Close();
        }

        //get FINANCIAL PLAN ID
        public int getID()//working
        {
            setID();
            return LatestID;
        }

        //get current Logged in Username
        

        //return logged in Username
        
    }
}
