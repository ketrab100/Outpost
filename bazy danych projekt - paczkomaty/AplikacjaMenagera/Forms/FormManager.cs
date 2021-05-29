using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaMenagera.Forms
{
    /// <summary>
    /// user can select parcel type and destination of a parcel and send it
    /// </summary>
    public partial class FormManager : Form
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();
        private string userId;
        /// <summary>
        /// initialization
        /// </summary>
        /// <param name="userId"></param>
        public FormManager(string userId)
        {
            InitializeComponent();

            this.userId = userId;

            //changes display
            textBoxName.Text = databaseConnection.getValue("FirstName", "Users", "User_Id", userId) + " " + databaseConnection.getValue("LastName", "Users", "User_Id", userId);
            dataGridViewSelect.DataSource = databaseConnection.getTable("Users");
            dataGridViewSelect.Columns["User_Id"].Visible = false;
        }
        /// <summary>
        /// gets values and allows to buy parcel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirmChanges_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridViewSelect.Rows)
            {
                databaseConnection.updateElement("Users", "FirstName", "'" + row.Cells["FirstName"].Value.ToString() + "'", "User_Id", row.Cells["User_Id"].Value.ToString());
                databaseConnection.updateElement("Users", "LastName", "'" + row.Cells["LastName"].Value.ToString() + "'", "User_Id", row.Cells["User_Id"].Value.ToString());
                databaseConnection.updateElement("Users", "Login", "'" + row.Cells["Login"].Value.ToString() + "'", "User_Id", row.Cells["User_Id"].Value.ToString());
                databaseConnection.updateElement("Users", "Password", "'" + row.Cells["Password"].Value.ToString() + "'", "User_Id", row.Cells["User_Id"].Value.ToString());
                databaseConnection.updateElement("Users", "UserType", "'" + row.Cells["UserType"].Value.ToString() + "'", "User_Id", row.Cells["User_Id"].Value.ToString());
                databaseConnection.updateElement("Users", "PhoneNumber", row.Cells["PhoneNumber"].Value.ToString(), "User_Id", row.Cells["User_Id"].Value.ToString());
            }
        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            FormNewUser formNewUser = new FormNewUser();
            formNewUser.ShowDialog();

            dataGridViewSelect.DataSource = databaseConnection.getTable("Users");
            dataGridViewSelect.Columns["User_Id"].Visible = false;
        }
    }
}
