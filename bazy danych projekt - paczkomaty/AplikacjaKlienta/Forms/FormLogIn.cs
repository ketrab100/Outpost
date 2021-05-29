using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaKlienta.Forms
{
    /// <summary>
    /// allows user with client status to log in to the app or create new account or check parcel status
    /// </summary>
    public partial class FormLogIn : Form
    {
        public static DatabaseConnection databaseConnection = new DatabaseConnection();
        public FormLogIn()
        {
            InitializeComponent();
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
            if (currentUserType!=null)
            {
                if(currentUserType == "Client")
                {
                    //hides log in window and opens window for customers
                    this.Hide();
                    FormClient formMain = new FormClient(databaseConnection.getValue("User_Id", "Users", columnName, columnValue));
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
        /// <summary>
        /// returns package status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCheckStatus_Click(object sender, EventArgs e)
        {
            //gets wanted value from data base
            string currentPackageCode = null;
            currentPackageCode = databaseConnection.getValue( "Code", "Parcels", "Code", "'" + textBoxPackageCode.Text + "'");

            if(currentPackageCode != null)
            {
                //opens form with status display
                FormPackageStatus formPackageStatus = new FormPackageStatus(currentPackageCode);
                formPackageStatus.ShowDialog();
            }
            //if package doesn't exist in database throws messagebox
            else
            {
                MessageBox.Show("Package with this code doesn't exist", "Wrong code");
            }
        }

        private void buttonNewAcoount_Click(object sender, EventArgs e)
        {
            FormNewUser formNewClient = new FormNewUser();
            formNewClient.ShowDialog();
        }
    }
}
