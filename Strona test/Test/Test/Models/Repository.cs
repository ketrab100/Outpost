using AngleSharp.Html.Dom;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;



namespace Test.Models
{
    public class Repository
    {
        private static string ConnectionStringOracle = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=156.17.43.90)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=xe))); User Id=pwr_20_21_L_019252736; Password=jakby;";
        private readonly OracleConnection sqlConnection = new OracleConnection(ConnectionStringOracle);

        public DataTable test(string tableName)
        {
            string query = "SELECT " + tableName + ".* FROM " + tableName + " ";

            OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }


        public void addParcel(Parcel p)
        {

            Random rand = new Random();
            int pickupCode = (Math.Abs(rand.Next() * rand.Next() + 1000000) % 10000000);

            String query = "INSERT INTO PARCELS VALUES ( 'PC210521WAR1N1' " + "," +p.Type + ", NULL" + ", NULL" + ",2" + ",2" + ",3" + ", NULL" + ", NULL, 7, " + 3 + ", NULL)";

            sqlConnection.Open();
            OracleCommand commandInsertBook = new OracleCommand(query, sqlConnection);

            commandInsertBook.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public string getUserId(User u)
        {
            String query = "SELECT USER_ID FROM USERS WHERE LOGIN = '" + u.Login + "' AND PASSWORD ='" + u.Password + "'";
            OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable.Rows[0][0].ToString();
        }

    }
}
