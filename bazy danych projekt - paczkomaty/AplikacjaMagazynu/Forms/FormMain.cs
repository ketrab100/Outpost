using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AplikacjaMagazynu.Forms
{
    /// <summary>
    /// window for courier to pick up or deliver packages to/from parcel locker
    /// </summary>
    public partial class FormMain : Form
    {
        private string userId;
        private string warehouseId;
        private DatabaseConnection databaseConnection = new DatabaseConnection();
        /// <summary>
        /// initialization
        /// </summary>
        /// <param name="userId"></param>
        public FormMain(string userId, string warehouseId)
        {
            InitializeComponent();

            this.userId = userId;
            this.warehouseId = warehouseId;
            //changes display
            textBoxName.Text = databaseConnection.getValue("FirstName", "Users", "User_Id", userId) + " " + databaseConnection.getValue("LastName", "Users", "User_Id", userId);

            if(databaseConnection.getValue("UserType", "Users", "User_Id", userId)=="Courier")
                dataGridViewSelect.DataSource = databaseConnection.getTableSpecyficQuery("SELECT Parcels.Code, Parcels.DestinationParcelLockerId, Parcels.SentDate, ParcelTypes.Name FROM Parcels JOIN ParcelTypes ON Parcels.TypeId = ParcelTypes.ParcelType_Id WHERE Parcels.WarehouseId = " + this.warehouseId + " AND Parcels.StatusId = 9");
            
            else
                dataGridViewSelect.DataSource = databaseConnection.getTableSpecyficQuery("SELECT Parcels.Code, Parcels.DestinationParcelLockerId, Parcels.SentDate, ParcelTypes.Name FROM Parcels JOIN ParcelTypes ON Parcels.TypeId = ParcelTypes.ParcelType_Id WHERE Parcels.WarehouseId = " + this.warehouseId + " AND Parcels.StatusId = 4");

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
                    databaseConnection.updateElement("Parcels", "WarehouseId", "NULL", "Code", "'" + dataGridViewSelect.SelectedRows[q].Cells["Code"].Value.ToString() + "'");

                    if (databaseConnection.getValue("UserType", "Users", "User_Id", userId) == "Courier")
                    {
                        databaseConnection.updateElement("Parcels", "CourierId", userId, "Code", "'" + dataGridViewSelect.SelectedRows[q].Cells["Code"].Value.ToString() + "'");
                        databaseConnection.updateElement("Parcels", "StatusId", "2", "Code", "'" + dataGridViewSelect.SelectedRows[q].Cells["Code"].Value.ToString() + "'");
                    }
                    else
                    {
                        databaseConnection.updateElement("Parcels", "LorryDriverId", userId, "Code", "'" + dataGridViewSelect.SelectedRows[q].Cells["Code"].Value.ToString() + "'");
                        databaseConnection.updateElement("Parcels", "StatusId", "5", "Code", "'" + dataGridViewSelect.SelectedRows[q].Cells["Code"].Value.ToString() + "'");
                    }
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
            string code = Interaction.InputBox("Package code", "Deliver parcel", "");

            string currentCode = databaseConnection.getValue("Code", "Parcels", "Code", "'" + code + "'");
            
            //if package exists
            if (currentCode != null)
            {
                //if there is a free locker of selected type
                if (databaseConnection.getValue("UserType", "Users", "User_Id", userId) == "Courier")
                {
                    databaseConnection.updateElement("Parcels", "StatusId", "4", "Code", "'" + currentCode + "'");
                    databaseConnection.updateElement("Parcels", "CourierId", "NULL", "Code", "'" + currentCode + "'");
                    databaseConnection.updateElement("Parcels", "warehouseId", warehouseId, "Code", "'" + currentCode + "'");
                    MessageBox.Show("Confirm that parcel is in warehouse", "Confirmation", MessageBoxButtons.OK);
                }
                else
                {
                    databaseConnection.updateElement("Parcels", "StatusId", "9", "Code", "'" + currentCode + "'");
                    databaseConnection.updateElement("Parcels", "LorryDriverId", "NULL", "Code", "'" + currentCode + "'");
                    databaseConnection.updateElement("Parcels", "warehouseId", warehouseId, "Code", "'" + currentCode + "'");
                    MessageBox.Show("Confirm that parcel is in warehouse", "Confirmation", MessageBoxButtons.OK);
                }                
            }
            else
                MessageBox.Show("Wrong code");
        }
    }
}
