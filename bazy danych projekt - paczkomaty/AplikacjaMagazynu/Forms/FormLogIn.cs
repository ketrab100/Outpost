﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaMagazynu.Forms
{
    /// <summary>
    /// log in window for couriers
    /// </summary>
    public partial class FormLogIn : Form
    {
        private string warehouseId;
        DatabaseConnection databaseConnection = new DatabaseConnection();
        public FormLogIn(int warehouseId)
        {
            InitializeComponent();
            this.warehouseId = warehouseId.ToString();
        }
        /// <summary>
        /// tries to log user, if succesful open correct window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            //gets wanted value from data base
            string currentUserType = null;
            string[] columnName = { "Login", "Password" };
            string[] columnValue = { "'" + textBoxUsername.Text + "'", "'" + textBoxPassword.Text + "'" };
            currentUserType = databaseConnection.getValue("UserType", "Users", columnName, columnValue);

            //if values doesn't match throws messages
            if (currentUserType != null)
            {
                if (currentUserType == "Courier" || currentUserType == "LorryDriver")
                {
                    //hides log in window and opens window for customers
                    this.Hide();
                    FormMain formMain = new FormMain(databaseConnection.getValue("User_Id", "Users", columnName, columnValue), warehouseId);
                    formMain.Closed += (s, args) => this.Close();
                    formMain.Show();
                }
                else
                {
                    MessageBox.Show("Login failed", "Login failed");
                }
            }
            else
            {
                MessageBox.Show("Login failed", "Login failed");
            }
        }
    }
}
