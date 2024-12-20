using Microsoft.Data.SqlClient;
using System.Data;

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
        private static string Username, PlanName, TimeOption;
        private static int ID, UserID, TimeFrame, LatestID, currentUserID, PlanID, SelectedPlanID;
        private static double TotalIncome, TotalExpenses, SavingsGoal, FoodAllocation, ElectricWaterBill, EmergencyFund;
        private static List<String> UsernameBank = new List<string>();
        private static List<String> PasswordBank = new List<string>();
        private static List<String> PlanNameBank = new List<string>();
        string connectionString;

        //Class Objects
        LoginForm loginForm = new LoginForm();
        LoginHandler loginHandler = new LoginHandler();
        ConnectionString connectString = new ConnectionString();

        //Initiates Database Handlers and Connections
        public DatabaseHandler()
        {
            connectionString = connectString.getConnectString();

            sqlConnect = new SqlConnection();
            sqlConnect.ConnectionString = connectionString;
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        //Inserts user inputs to database
        public bool pushData(int ID, int UserID, string Username, string PlanName, double TotalIncome, double TotalExpenses, double SavingsGoal, string TimeOption, int TimeFrame, double FoodAllocation, double ElectricWaterBill, double EmergencyFund)
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

        //Fetches data from database on selected User (current signed in user)
        public void getDatafromDatabase(int PlanID)
        {
            sqlConnect = new SqlConnection(connectionString);
            string sqlQuerry = "SELECT ID, Username, Plan_Name, Total_Income, Total_Expenses, Savings_Goal, " +
                "Time_Option, Time_Frame, FoodAllocation, ElectricWater_Bill, Emergency_Fund FROM FinancialPlans WHERE ID = @PlanID";

            sqlConnect.Open();

            sqlCommand = new SqlCommand(sqlQuerry, sqlConnect);
            sqlCommand.Parameters.Add("@PlanID", SqlDbType.Int).Value = PlanID;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                ID = reader.GetInt32(0);
                Username = reader.GetString(1);
                PlanName = reader.GetString(2);
                TotalIncome = reader.GetInt64(3);
                TotalExpenses = reader.GetInt64(4);
                SavingsGoal = reader.GetInt64(5);
                TimeOption = reader.GetString(6);
                TimeFrame = Convert.ToInt32(reader.GetInt64(7));
                FoodAllocation = reader.GetInt64(8);
                ElectricWaterBill = reader.GetInt64(9);
                EmergencyFund = reader.GetInt64(10);
            }

            sqlConnect.Close();
        }

        //Selects latest ID from the database
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


        //Fetches plan names on current user, stores it in List
        public void setPlanName()
        {
            sqlConnect = new SqlConnection(connectionString);
            string sqlQuerry = "SELECT Plan_Name FROM FinancialPlans WHERE UserID = @UserID";

            sqlConnect.Open();

            sqlCommand = new SqlCommand(sqlQuerry, sqlConnect);
            sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = loginHandler.getcurrentID();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                PlanNameBank.Add(reader.GetString(0));
            }

            sqlConnect.Close();
        }

        //fetches planID based on the Plan Name
        public void setPlanID(string PlanName)
        {
            sqlConnect = new SqlConnection(connectionString);
            string sqlQuerry = "SELECT ID FROM FinancialPlans WHERE Plan_Name = @PlanName";

            sqlConnect.Open();

            sqlCommand = new SqlCommand(sqlQuerry, sqlConnect);
            sqlCommand.Parameters.Add("@PlanName", SqlDbType.VarChar).Value = PlanName;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                PlanID = reader.GetInt32(0);
            }

            sqlConnect.Close();
        }


        //Return blocks
        public int getID()
        {
            setID();
            return LatestID;
        }

        public int getPlanID(string PlanName)
        {
            setPlanID(PlanName);
            return PlanID;
        }

        public List<string> getPlanNames()
        {
            PlanNameBank.Clear();
            setPlanName();
            return PlanNameBank;
        }

        public int getTimeFrame(int planID)
        {
            getDatafromDatabase(planID);
            return TimeFrame;
        }

        public double getTotalIncome(int planID)
        {
            getDatafromDatabase(planID);
            return TotalIncome;
        }

        public double getTotalExpenses(int planID)
        {
            getDatafromDatabase(planID);
            return TotalExpenses;
        }

        public double getSavingsGoal(int planID)
        {
            getDatafromDatabase(planID);
            return SavingsGoal;
        }

        public double getFoodAllocation(int planID)
        {
            getDatafromDatabase(planID);
            return FoodAllocation;
        }

        public double getElectricWaterBill(int planID)
        {
            getDatafromDatabase(planID);
            return ElectricWaterBill;
        }

        public double getEmergencyFund(int planID)
        {
            getDatafromDatabase(planID);
            return EmergencyFund;
        }

        public string getTimeOption(int planID)
        {
            getDatafromDatabase(planID);
            return TimeOption;
        }

    }
}
