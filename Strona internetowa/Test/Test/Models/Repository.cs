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


        public void addParcel(Parcel p , User u)
        {

            Random rand = new Random();
            int pickupCode = (Math.Abs(rand.Next() * rand.Next() + 1000000) % 10000000);
            p.PickUpCode = pickupCode;
            //string parcelCode = "PAR" + (Math.Abs(rand.Next() * rand.Next() + 1000000) % 10000000);

            //prepare and generate query to insert new package
            string parcelCode = "P" + getValue("Name", "ParcelTypes", "ParcelType_Id", p.Type.ToString());
            parcelCode += DateTime.Now.ToString("dd/MM/yy");
            parcelCode = String.Join("", parcelCode.Split('/'));
            parcelCode += getValue("Name", "ParcelTypes", "ParcelType_Id", p.Destination.ToString());
            parcelCode += "N" + (Int32.Parse(getValueLike("COUNT(Code)", "Parcels", "Code", "'" + parcelCode + "%'")) + 1).ToString();

            String query = "INSERT INTO PARCELS VALUES ( '" +parcelCode +"' ," + p.Type + ", NULL" + ", NULL ," + u.Id +  ",NULL," + p.Destination + ", NULL" + ", NULL, 7, " + p.PickUpCode + ", NULL)";

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

        public void deleteParcel(Parcel p)
        {
            String query = "DELETE FROM PARCELS WHERE CODE = '" + p.Code +"' AND " + "PICKUPCODE = " + p.PickUpCode;
            sqlConnection.Open();
            OracleCommand commandInsertBook = new OracleCommand(query, sqlConnection);

            commandInsertBook.ExecuteNonQuery();

            sqlConnection.Close();
        }

        /// <summary>
        /// returns specified value from database using WHERE statement with one argument
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="whereColumnName"></param>
        /// <param name="whereValue"></param>
        /// <returns></returns>
        public String getValue(string select, string from, string whereColumnName, string whereValue)
        {
            String query = "SELECT " + select + " FROM " + from + " ";
            query += "WHERE " + whereColumnName + " = " + whereValue;

            sqlConnection.Open();
            OracleCommand sqlCommand = new OracleCommand(query, sqlConnection);
            Object returnObject = sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            if (returnObject == null)
                return null;

            else
                return returnObject.ToString();
        }
        /// <summary>
        /// returns specified value from database using WHERE statement with one argument using LIKE
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="whereColumnName"></param>
        /// <param name="whereValue"></param>
        /// <returns></returns>
        public String getValueLike(string select, string from, string whereColumnName, string whereValue)
        {
            String query = "SELECT " + select + " FROM " + from + " ";
            query += "WHERE " + whereColumnName + " LIKE " + whereValue;

            sqlConnection.Open();
            OracleCommand sqlCommand = new OracleCommand(query, sqlConnection);
            Object returnObject = sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            if (returnObject == null)
                return null;

            else
                return returnObject.ToString();
        }

    }
}
