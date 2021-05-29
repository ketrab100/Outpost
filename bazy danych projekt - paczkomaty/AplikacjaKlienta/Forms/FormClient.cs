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
    /// user can select parcel type and destination of a parcel and send it
    /// </summary>
    public partial class FormClient : Form
    {
        private string selectedTypeId = "";
        private string selectedCity = "";
        private string userId;
        /// <summary>
        /// initialization
        /// </summary>
        /// <param name="userId"></param>
        public FormClient(string userId)
        {
            InitializeComponent();

            this.userId = userId;

            //changes display
            textBoxName.Text = FormLogIn.databaseConnection.getValue("FirstName", "Users", "User_Id", userId) + " " + FormLogIn.databaseConnection.getValue("LastName", "Users", "User_Id", userId);
            dataGridViewSelect.DataSource = FormLogIn.databaseConnection.getTable("ParcelTypes");
            dataGridViewSelect.Columns["ParcelType_Id"].Visible = false;
        }
        /// <summary>
        /// gets values and allows to buy parcel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSendPackage_Click(object sender, EventArgs e)
        {
            if (dataGridViewSelect.SelectedRows.Count == 1)
            {
                if (selectedTypeId == "")
                {
                    //gets package type id
                    selectedTypeId = dataGridViewSelect.SelectedRows[0].Cells["ParcelType_Id"].Value.ToString();

                    //changes display
                    labelAction.Text = "Select destination city";
                    dataGridViewSelect.DataSource = FormLogIn.databaseConnection.getTableDistinct("City", "Locations");

                }
                else if (selectedCity == "")
                {
                    //gets city
                    selectedCity = dataGridViewSelect.SelectedRows[0].Cells["City"].Value.ToString();

                    //changes display
                    labelAction.Text = "Select final parcel locker in " + selectedCity;
                    dataGridViewSelect.DataSource = FormLogIn.databaseConnection.getTableSpecyficQuery("SELECT ParcelLockers.Name, Locations.Street, Locations.NearestBuildingNumber, Locations.PostCode FROM Locations FULL OUTER JOIN ParcelLockers ON ParcelLockers.LocationId = Location_Id WHERE Locations.City = '" + selectedCity + "'");
                }
                else
                {
                    //prepare and generate query to insert new package
                    string code = "P" + FormLogIn.databaseConnection.getValue("Name", "ParcelTypes", "ParcelType_Id", selectedTypeId);
                    code += DateTime.Now.ToString("dd/MM/yy");
                    code = String.Join("", code.Split('/'));
                    code += dataGridViewSelect.SelectedRows[0].Cells["Name"].Value.ToString();
                    code += "N" + (Int32.Parse(FormLogIn.databaseConnection.getValueLike("COUNT(Code)", "Parcels", "Code", "'" + code + "%'")) + 1).ToString();
                    Random rand = new Random();
                    int pickupCode = (Math.Abs(rand.Next() * rand.Next() + 1000000) % 10000000);
                    FormLogIn.databaseConnection.addElement("Parcels", "( '" + code + "', " + selectedTypeId + ", NULL, NULL, " + userId + ", NULL, " + FormLogIn.databaseConnection.getValue("ParcelLocker_Id", "ParcelLockers", "Name", "'" + dataGridViewSelect.SelectedRows[0].Cells["Name"].Value.ToString() + "'") + ", NULL, NULL, 7, " + pickupCode + ", NULL)");

                    //payment and SMS
                    MessageBox.Show("Teraz będzie płatność i jakaś wiadomość numer telefonu z kodem paczki: " + code + " oraz kodem odbioru: " + pickupCode +", wtedy paczka zmienia status i można ją zanieść do paczkomatu, dla uproszczenia status zmieni się po tej wiadomości");

                    //changes display
                    labelAction.Text = "Select package size and priority";
                    selectedCity = "";
                    selectedTypeId = "";
                    textBoxName.Text = FormLogIn.databaseConnection.getValue("FirstName", "Users", "User_Id", userId) + " " + FormLogIn.databaseConnection.getValue("LastName", "Users", "User_Id", userId);
                    dataGridViewSelect.DataSource = FormLogIn.databaseConnection.getTable("ParcelTypes");
                    dataGridViewSelect.Columns["ParcelType_Id"].Visible = false;

                    //update status
                    FormLogIn.databaseConnection.updateElement("Parcels", "StatusId", "8", "Code", "'" + code + "'");
                }
            }
            else
                MessageBox.Show("Select before continuing");
        }
    }
}
