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
    public partial class FormPackageStatus : Form
    {
        /// <summary>
        /// displayes all "important" package values
        /// </summary>
        /// <param name="currentCode"></param>
        public FormPackageStatus(string currentCode)
        {
            InitializeComponent();

            textBoxCode.Text = currentCode;
            currentCode = "'" + currentCode + "'";
            textBoxType.Text = FormLogIn.databaseConnection.getValue("Name", "ParcelTypes", "ParcelType_Id", FormLogIn.databaseConnection.getValue("TypeId", "Parcels", "Code", currentCode));
            textBoxParcelLockerName.Text = FormLogIn.databaseConnection.getValue("Name", "ParcelLockers", "ParcelLocker_Id", FormLogIn.databaseConnection.getValue("DestinationParcelLockerId", "Parcels", "Code", currentCode));
            string locationId = FormLogIn.databaseConnection.getValue("LocationId", "ParcelLockers", "ParcelLocker_Id", FormLogIn.databaseConnection.getValue("DestinationParcelLockerId", "Parcels", "Code", currentCode));
            textBoxAddress.Text = FormLogIn.databaseConnection.getValue("Street", "Locations", "Location_Id", locationId);
            textBoxAddress.Text += " " +FormLogIn.databaseConnection.getValue("NearestBuildingNumber", "Locations", "Location_Id", locationId);
            textBoxPostCode.Text = FormLogIn.databaseConnection.getValue("PostCode", "Locations", "Location_Id", locationId);
            textBoxCity.Text = FormLogIn.databaseConnection.getValue("City", "Locations", "Location_Id", locationId);
            textBoxStatus.Text = FormLogIn.databaseConnection.getValue("Name", "Statuses", "Status_Id", FormLogIn.databaseConnection.getValue("StatusId", "Parcels", "Code", currentCode));
            if (FormLogIn.databaseConnection.getValue("SentDate", "Parcels", "Code", currentCode) != null)
            {
                MessageBox.Show(FormLogIn.databaseConnection.getValue("SentDate", "Parcels", "Code", currentCode));
                textBoxSentDate.Text = DateTime.Parse(FormLogIn.databaseConnection.getValue("SentDate", "Parcels", "Code", currentCode)).Date.ToString("dd.MM.yy");
            
            }
            else
                textBoxSentDate.Text = "Not sent yet";
        }
    }
}
