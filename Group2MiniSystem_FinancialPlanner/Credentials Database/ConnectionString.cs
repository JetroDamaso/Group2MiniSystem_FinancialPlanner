using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2MiniSystem_FinancialPlanner.FinancialPlanner
{
    internal class ConnectionString
    {
        private static string ConnectString;


        //Change ConnectionString on current device
        public string getConnectString()
        {
            ConnectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jetro\source\repos\Group2MiniSystem_FinancialPlanner\Group2MiniSystem_FinancialPlanner\Credentials Database\CredentialsDatabase.mdf"";Integrated Security=True";
            return ConnectString;
        }

    }
}
