using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaPaczkomatu
{
    /// <summary>
    /// class with connection to database and fuctions to perform queries
    /// </summary>
    public class DatabaseConnection
    {
        //private readonly SqlConnection sqlConnection = new SqlConnection(Properties.Resources.ConnectionString);
        private readonly OracleConnection sqlConnection = new OracleConnection(Properties.Resources.ConnectionStringOracle);
        /// <summary>
        /// returns all values in selected table
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataTable getTable(string tableName)
        {
            //prepare query
            string query = "SELECT " + tableName + ".* FROM " + tableName + " ";

            //get query from database
            OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            return dataTable;

        }
        /// <summary>
        /// returns distinct values in selected table
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataTable getTableDistinct(string columnName, string tableName)
        {
            //prepare query
            string query = "SELECT DISTINCT " + columnName + " FROM " + tableName + " ";

            //get query from database
            OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            return dataTable;

        }
        /// <summary>
        /// return datatable to specyfic query
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable getTableSpecyficQuery(string query)
        {
            //get query from database
            OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            return dataTable;

        }
        /// <summary>
        /// /// returns specified value from database using WHERE statement with multiple arguments
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="whereColumnName"></param>
        /// <param name="whereValue"></param>
        /// <returns></returns>
        public String getValue(string select, string from, string[] whereColumnName, string[] whereValue)
        {
            String query = "SELECT " + select + " FROM " + from + " ";
            query += "WHERE " + whereColumnName[0] + " = " + whereValue[0];

            for (int q = 1; q < whereColumnName.Length; q++)
            {
                query += " AND " + whereColumnName[q] + " = " + whereValue[q];
            }

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
        /// <summary>
        /// adds element to specified table
        /// </summary>
        /// <param name="insert"></param>
        /// <param name="values"></param>
        public void addElement(string insert, string values)
        {
            String query = "INSERT INTO " + insert + " VALUES " + values;

            sqlConnection.Open();
            OracleCommand sqlInsert = new OracleCommand(query, sqlConnection);
            sqlInsert.ExecuteNonQuery();

            sqlConnection.Close();
        }
        /// <summary>
        /// deletes element
        /// </summary>
        /// <param name="from"></param>
        /// <param name="whereColumn"></param>
        /// <param name="whereValue"></param>
        public void deleteElement(string from, string whereColumn, string whereValue)
        {
            String query = "DELETE FROM " + from + " WHERE " + whereColumn + " = " + whereValue;

            sqlConnection.Open();
            OracleCommand sqlDelete = new OracleCommand(query, sqlConnection);
            sqlDelete.ExecuteNonQuery();

            sqlConnection.Close();
        }
        /// <summary>
        /// updates selected value in selected table
        /// </summary>
        /// <param name="update"></param>
        /// <param name="setColumn"></param>
        /// <param name="setValue"></param>
        /// <param name="whereColumn"></param>
        /// <param name="whereValue"></param>
        public void updateElement(string update, string setColumn, string setValue, string whereColumn, string whereValue)
        {
            String query = "UPDATE " + update + " SET " + setColumn + " = " + setValue + " WHERE " + whereColumn + " = " + whereValue;

            sqlConnection.Open();
            OracleCommand sqlUpdate = new OracleCommand(query, sqlConnection);
            sqlUpdate.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
