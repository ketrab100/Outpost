using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Windows.Forms;

namespace AplikacjaPaczkomatu.Forms
{
    /// <summary>
    /// main parcel lockeer interface
    /// </summary>
    public partial class FormMain : Form
    {
        //help data
        Boolean send = false;
        Boolean wrongStatus = false;
        private int parcelLockerId = 1;
        string currentPackageCode = null;
        DatabaseConnection databaseConnection = new DatabaseConnection();

        public FormMain()
        {
            InitializeComponent();

            setMainScreen();
        }
        /// <summary>
        /// allows courier to log in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCourierLogIn_Click(object sender, EventArgs e)
        {
            //courier log in form
            FormLogIn formLogIn = new FormLogIn(parcelLockerId);
            formLogIn.ShowDialog();
        }
        /// <summary>
        /// selects pick up option and moves to next panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPickUp_Click(object sender, EventArgs e)
        {
            send = false;
            panelAction.Hide();
            panelCode.Show();
            startTimer();
        }
        /// <summary>
        /// displays help window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Call our help line from 10AM to 8PM from Monday to Friday at number 768 372 452", "Help info");
        }
        /// <summary>
        /// selects send option and moves to next panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSend_Click(object sender, EventArgs e)
        {
            send = true;
            panelAction.Hide();
            panelCode.Show();
            startTimer();
        }
        /// <summary>
        /// gets package code and display parcel status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirmCode_Click(object sender, EventArgs e)
        {
            //gets wanted value from data base
            currentPackageCode = databaseConnection.getValue("Code", "Parcels", "Code", "'" + textBoxCode.Text + "'");

            //if code is wrong displays window where you can choose to enter it again
            if (currentPackageCode == null)
            {
                DialogResult dialogResult = MessageBox.Show("Package does not exist, would you like to try again?", "Wrong code", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                    setMainScreen();

                else
                    textBoxCode.Text = "";
            }
            //else displays status and sets buttonOpenLocker to display right command
            else
            {
                int statusId = Int32.Parse(databaseConnection.getValue("StatusId", "Parcels", "Code", "'" + currentPackageCode + "'"));
                textBoxStatus.Text = databaseConnection.getValue("Name", "Statuses", "Status_Id", "'" + statusId.ToString() + "'");

                //package can be sent
                if (statusId == 8 && send)
                    buttonOpenLocker.Enabled = true;

                //package can be picked up
                else if (statusId == 6 && !send)
                {
                    int packageParcelLockerId = Int32.Parse(databaseConnection.getValue("ParcelLockerId", "Parcels", "Code", "'" + currentPackageCode + "'"));

                    //checks if package is in this parcel locker
                    if (parcelLockerId != packageParcelLockerId)
                    {
                        wrongStatus = true;
                        buttonOpenLocker.Text = "Wrong parcel locker";
                        buttonOpenLocker.Enabled = true;
                    }
                    else
                        buttonOpenLocker.Enabled = true;
                }
                else
                {
                    wrongStatus = true;
                    buttonOpenLocker.Text = "Go back";
                    buttonOpenLocker.Enabled = true;
                }
            }
        }
        /// <summary>
        /// depending on information given by action from buttonConfirmCode_Click displays one of the panels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenLocker_Click(object sender, EventArgs e)
        {
            if (!wrongStatus)
            {
                if (send)
                {
                    //checks if there is free locker
                    int lockerNumber = findLockerNumber();

                    //if not displays message and goes to main screen
                    if (lockerNumber == -1)
                    {
                        MessageBox.Show("All lockers of that type are taken, please try in a few hours or try in other parcel locker", "No free locker");
                        setMainScreen();
                    }
                    //else displays correct panel
                    else
                    {
                        panelCode.Hide();
                        panelOpenLockerSend.Show();
                    }
                }
                else
                {
                    string pickUpCode = Interaction.InputBox("Input pick up code: ", "Pick up code", "");

                    //asks for pick up code before opening displaying correct panel
                    if (pickUpCode == databaseConnection.getValue("PickupCode", "Parcels", "Code", "'" + currentPackageCode + "'"))
                    {
                        panelCode.Hide();
                        panelOpenLockerPickup.Show();
                    }
                    //if code is wrong then client can try again
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Wrong pick up code, would you like to try again?", "Wrong pick up code", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                            wrongStatus = true;

                        else
                            buttonOpenLocker_Click(sender, e);

                    }
                }
                startTimer();
            }

            if (wrongStatus)
                setMainScreen();
        }
        /// <summary>
        /// performs correct update in data base after client picks up or sends his parcel and changes display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            panelOpenLockerPickup.Hide();
            panelOpenLockerSend.Hide();
            panelRegards.Show();

            //updates package in database
            if (send)
            {
                int lockerNumber = findLockerNumber();
                databaseConnection.updateElement("Parcels", "SentDate", "(SELECT TO_DATE (SYSDATE, 'YYYY-MM-DD') FROM DUAL)", "Code", "'" + currentPackageCode + "'");
                databaseConnection.updateElement("Parcels", "LockerNumber", lockerNumber.ToString(), "Code", "'" + currentPackageCode + "'");
                databaseConnection.updateElement("Parcels", "StatusId", "1", "Code", "'" + currentPackageCode + "'");
                databaseConnection.updateElement("Parcels", "ParcelLockerId", parcelLockerId.ToString(), "Code", "'" + currentPackageCode + "'");
                buttonAgain.Text = "Send next package";
            }
            //deletes package from database
            else
            {
                databaseConnection.deleteElement("Parcels", "Code", "'" + currentPackageCode + "'");
                buttonAgain.Text = "Pick up next package";
            }
            startTimer();
        }
        /// <summary>
        /// allows user to perform next operation of same type (send or pick up)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgain_Click(object sender, EventArgs e)
        {
            setMainScreen();
            panelAction.Hide();
            panelCode.Show();
            startTimer();
        }
        /// <summary>
        /// resets saved data and hides all panels and shows the first one
        /// </summary>
        private void setMainScreen()
        {
            foreach (Panel panel in this.Controls)
            {
                panel.Hide();
            }
            panelAction.Show();

            wrongStatus = false;
            buttonOpenLocker.Text = "Open locker";
            buttonOpenLocker.Enabled = false;
            textBoxCode.Text = "";
            currentPackageCode = null;
        }
        /// <summary>
        /// if timer runs out then goes back to main screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerReturnToMainWindow_Tick(object sender, EventArgs e)
        {
            timerReturnToMainWindow.Stop();
            setMainScreen();
        }
        /// <summary>
        /// starts 2 minute timer
        /// </summary>
        private void startTimer()
        {
            timerReturnToMainWindow.Interval = 120000;
            timerReturnToMainWindow.Start();
        }
        /// <summary>
        /// finds first free locker of current package type
        /// </summary>
        /// <returns></returns>
        private int findLockerNumber()
        {
            string packageType = databaseConnection.getValue("Name", "ParcelTypes", "ParcelType_Id", databaseConnection.getValue("TypeId", "Parcels", "Code", "'" + currentPackageCode + "'"));

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
