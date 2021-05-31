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
    /// user can create new account
    /// </summary>
    public partial class FormNewUser : Form
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();
        public FormNewUser()
        {
            InitializeComponent();

            /*
            DataTable userTypes = databaseConnection.getTableDistinct("Name", "UserTypes");
            foreach(DataRow row in userTypes.Rows)
            {
                comboBoxUserType.Items.Add(row["Name"].ToString());
            }
            comboBoxUserType.SelectedIndex = 0;
            */

            comboBoxUserType.Items.Add("Client");
            comboBoxUserType.Items.Add("Courier");
            comboBoxUserType.Items.Add("Manager");
            comboBoxUserType.Items.Add("LorryDriver");
            comboBoxUserType.SelectedIndex = 0;
        }
        /// <summary>
        /// creates an account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            Boolean goodLenght = true;

            //checks if textboxes have good lenght
            foreach(TextBox textBox in this.Controls.OfType<TextBox>())
            {
                if (textBox.Text.Length < 3 || textBox.Text.Length > 40)
                    goodLenght = false;
            }   
            //checks if phonenumber has 9 digits
            if (textBoxPhoneNumber.Text.Length != 9)
                goodLenght = false;

            //throws errors if is already in database
            if (goodLenght)
            {
                if (databaseConnection.getValue("Login", "Users", "Login", "'" + textBoxLogin.Text + "'") == null)
                {
                    if (databaseConnection.getValue("PhoneNumber", "Users", "PhoneNumber", "'" + textBoxPhoneNumber.Text + "'") == null)
                    {
                        //adds user (client)
                        databaseConnection.addElement("Users", "((SELECT MAX(User_Id)+1 FROM Users), '" + textBoxFirstName.Text + "','" + textBoxLastName.Text + "','" + textBoxLogin.Text + "','" + textBoxPassword.Text + "', " + textBoxPhoneNumber.Text + ", '" + comboBoxUserType.SelectedItem.ToString() + "')");
                        MessageBox.Show("tu jakieś potwierdzenie na sms i do potwierdzenia i dopiero wtedy można się zalogować, ale uprościmy do tego tekstu");
                    }
                    else
                        MessageBox.Show("Phone number taken");
                }
                else
                    MessageBox.Show("Login taken");
            }
            else
                MessageBox.Show("Proper length is between 5-40 and phone number should be 9", "Invalide lenght");
        }
    }
}
