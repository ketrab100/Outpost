using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplikacjaPaczkomatu;
using Microsoft.VisualBasic;

namespace AplikacjaPaczkomatu.Forms
{
    /// <summary>
    /// window for courier to pick up or deliver packages to/from parcel locker
    /// </summary>
    public partial class FormCourier : Form
    {
        private string userId;
        private string parcelLockerId;
        private DatabaseConnection databaseConnection = new DatabaseConnection();
        /// <summary>
        /// initialization
        /// </summary>
        /// <param name="userId"></param>
        public FormCourier(string userId, string parcelLockerId)
        {
            InitializeComponent();

            this.userId = userId;
            this.parcelLockerId = parcelLockerId;
            //changes display
            textBoxName.Text = databaseConnection.getValue("FirstName", "Users", "User_Id", userId) + " " + databaseConnection.getValue("LastName", "Users", "User_Id", userId);
            dataGridViewSelect.DataSource = databaseConnection.getTableSpecyficQuery("SELECT Parcels.Code, Parcels.DestinationParcelLockerId, Parcels.SentDate, ParcelTypes.Name FROM Parcels JOIN ParcelTypes ON Parcels.TypeId = ParcelTypes.ParcelType_Id WHERE Parcels.ParcelLockerId = " + parcelLockerId);
            dataGridViewSelect.Columns["Code"].Visible = false;
        }
        /// <summary>
        /// gets values and allows to pick up parcels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPickUpPackages_Click(object sender, EventArgs e)
        {
            if (dataGridViewSelect.SelectedRows.Count > 0)
            {
                //for every package selected updates values
                for(int q=0; q<dataGridViewSelect.SelectedRows.Count; q++)
                {
                    databaseConnection.updateElement("Parcels", "LockerNumber", "NULL", "Code", "'" + dataGridViewSelect.SelectedRows[q].Cells["Code"].Value.ToString() + "'");
                    databaseConnection.updateElement("Parcels", "ParcelLockerId", "NULL", "Code", "'" + dataGridViewSelect.SelectedRows[q].Cells["Code"].Value.ToString() + "'");
                    databaseConnection.updateElement("Parcels", "CourierId", userId, "Code", "'" + dataGridViewSelect.SelectedRows[q].Cells["Code"].Value.ToString() + "'");
                    
                    //if destination is in the same city then sets statusId to 2 else 3
                    if(databaseConnection.getValue("City", "Locations", "Location_Id", databaseConnection.getValue("LocationId", "ParcelLockers", "ParcelLocker_Id", parcelLockerId)) ==
                       databaseConnection.getValue("City", "Locations", "Location_Id", databaseConnection.getValue("LocationId", "ParcelLockers", "ParcelLocker_Id", databaseConnection.getValue("DestinationParcelLockerId", "Parcels", "Code", "'" + dataGridViewSelect.SelectedRows[q].Cells["Code"].Value.ToString() + "'"))))
                    {
                        databaseConnection.updateElement("Parcels", "StatusId", "2", "Code", "'" + dataGridViewSelect.SelectedRows[q].Cells["Code"].Value.ToString() + "'");
                    }
                    else
                        databaseConnection.updateElement("Parcels", "StatusId", "3", "Code", "'" + dataGridViewSelect.SelectedRows[q].Cells["Code"].Value.ToString() + "'");
                }
            }
            else
                MessageBox.Show("Select before continuing");
        }
        /// <summary>
        /// allows to deliver package to parcel locker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeliverPackage_Click(object sender, EventArgs e)
        {
            string code = Interaction.InputBox("Parcels code", "Deliver parcel", "");

            string currentCode = databaseConnection.getValue("Code", "Parcels", "Code", "'" + code + "'");
            
            //if package exists
            if (currentCode != null)
            {
                //if this is correct parcel locker
                if (parcelLockerId == databaseConnection.getValue("DestinationParcelLockerId", "ParcelLockers", "ParcelLocker_Id", parcelLockerId))
                {
                    int lockerNumber = findLockerNumber(currentCode);

                    //if there is a free locker of selected type
                    if (lockerNumber != -1)
                    {
                        databaseConnection.updateElement("Parcels", "LockerNumber", lockerNumber.ToString(), "Code", "'" + currentCode + "'");
                        databaseConnection.updateElement("Parcels", "StatusId", "6", "Code", "'" + currentCode + "'");
                        databaseConnection.updateElement("Parcels", "ParcelLockerId", parcelLockerId, "Code", "'" + currentCode + "'");
                        databaseConnection.updateElement("Parcels", "ParcelLockerId", DateTime.Now.ToString("yyyy-MM-dd"), "Code", "'" + currentCode + "'");
                        MessageBox.Show("Confirm that package is in locker", "Confirmation", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("All lockers taken");
                }
                else
                    MessageBox.Show("Wrong parcel locker");
            }
            else
                MessageBox.Show("Wrong code");
        }
        /// <summary>
        /// finds first free locker of current package type
        /// </summary>
        /// <param name="currentCode"></param>
        /// <returns></returns>
        private int findLockerNumber(string currentCode)
        {
            string packageType = databaseConnection.getValue("Name", "ParcelTypes", "ParcelType_Id", databaseConnection.getValue("TypeId", "Parcels", "Code", "'" + currentCode + "'"));

            int lockersQuantity = Int32.Parse(databaseConnection.getValue("Size" + packageType[0] + "Lockers", "ParcelLockerTypes", "ParcelLockerType_Id", databaseConnection.getValue("TypeId", "ParcelLockers", "ParcelLocker_Id", parcelLockerId.ToString())));
            int currentLocker = 1;

            DataTable takenLockers = databaseConnection.getTableSpecyficQuery("SELECT LockerNumber FROM Parcels WHERE ParcelLockerId = " + parcelLockerId.ToString() + " ORDER BY LockerNumber");

            if (takenLockers.Rows.Count == lockersQuantity)
                return -1;

            if (takenLockers.Rows.Count == 0)
                return 1;

            for (int q = 0; q <= takenLockers.Rows.Count; q++)
            {
                if (currentLocker == (int)takenLockers.Rows[q][0])
                    currentLocker++;

                else
                    break;
            }
            return currentLocker;
        }
    }
}
