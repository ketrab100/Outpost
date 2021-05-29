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
    /// user can create new account
    /// </summary>
    public partial class FormNewUser : Form
    {
        public FormNewUser()
        {
            InitializeComponent();
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
                if (FormLogIn.databaseConnection.getValue("Login", "Users", "Login", "'" + textBoxLogin.Text + "'") == null)
                {
                    if (FormLogIn.databaseConnection.getValue("PhoneNumber", "Users", "PhoneNumber", "'" + textBoxPhoneNumber.Text + "'") == null)
                    {
                        //adds user (client)
                        FormLogIn.databaseConnection.addElement("Users", "('" + textBoxFirstName.Text + "','" + textBoxLastName.Text + "','" + textBoxLogin.Text + "','" + textBoxPassword.Text + "','" + textBoxPhoneNumber.Text + "', 1)");
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
