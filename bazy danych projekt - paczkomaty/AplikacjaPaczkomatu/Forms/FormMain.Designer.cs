
namespace AplikacjaPaczkomatu.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelAction = new System.Windows.Forms.Panel();
            this.buttonCourierLogIn = new System.Windows.Forms.Button();
            this.buttonPickUp = new System.Windows.Forms.Button();
            this.buttonGetHelp = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelCode = new System.Windows.Forms.Panel();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonOpenLocker = new System.Windows.Forms.Button();
            this.buttonConfirmCode = new System.Windows.Forms.Button();
            this.labelInputCode = new System.Windows.Forms.Label();
            this.panelOpenLockerSend = new System.Windows.Forms.Panel();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelLockerOpened = new System.Windows.Forms.Label();
            this.panelOpenLockerPickup = new System.Windows.Forms.Panel();
            this.labelInfo4 = new System.Windows.Forms.Label();
            this.labelInfo3 = new System.Windows.Forms.Label();
            this.buttonConfirm2 = new System.Windows.Forms.Button();
            this.labelLockerOpened2 = new System.Windows.Forms.Label();
            this.panelRegards = new System.Windows.Forms.Panel();
            this.buttonAgain = new System.Windows.Forms.Button();
            this.labelRegards = new System.Windows.Forms.Label();
            this.timerReturnToMainWindow = new System.Windows.Forms.Timer(this.components);
            this.panelAction.SuspendLayout();
            this.panelCode.SuspendLayout();
            this.panelOpenLockerSend.SuspendLayout();
            this.panelOpenLockerPickup.SuspendLayout();
            this.panelRegards.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAction
            // 
            this.panelAction.Controls.Add(this.buttonCourierLogIn);
            this.panelAction.Controls.Add(this.buttonPickUp);
            this.panelAction.Controls.Add(this.buttonGetHelp);
            this.panelAction.Controls.Add(this.buttonSend);
            this.panelAction.Controls.Add(this.labelWelcome);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAction.Location = new System.Drawing.Point(0, 0);
            this.panelAction.Margin = new System.Windows.Forms.Padding(2);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(425, 199);
            this.panelAction.TabIndex = 0;
            // 
            // buttonCourierLogIn
            // 
            this.buttonCourierLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCourierLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCourierLogIn.Location = new System.Drawing.Point(247, 155);
            this.buttonCourierLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCourierLogIn.Name = "buttonCourierLogIn";
            this.buttonCourierLogIn.Size = new System.Drawing.Size(169, 33);
            this.buttonCourierLogIn.TabIndex = 4;
            this.buttonCourierLogIn.Text = "Courier log in";
            this.buttonCourierLogIn.UseVisualStyleBackColor = true;
            this.buttonCourierLogIn.Click += new System.EventHandler(this.buttonCourierLogIn_Click);
            // 
            // buttonPickUp
            // 
            this.buttonPickUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPickUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPickUp.Location = new System.Drawing.Point(247, 68);
            this.buttonPickUp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPickUp.Name = "buttonPickUp";
            this.buttonPickUp.Size = new System.Drawing.Size(169, 83);
            this.buttonPickUp.TabIndex = 3;
            this.buttonPickUp.Text = "Pick up package";
            this.buttonPickUp.UseVisualStyleBackColor = true;
            this.buttonPickUp.Click += new System.EventHandler(this.buttonPickUp_Click);
            // 
            // buttonGetHelp
            // 
            this.buttonGetHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGetHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGetHelp.Location = new System.Drawing.Point(8, 155);
            this.buttonGetHelp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetHelp.Name = "buttonGetHelp";
            this.buttonGetHelp.Size = new System.Drawing.Size(169, 33);
            this.buttonGetHelp.TabIndex = 2;
            this.buttonGetHelp.Text = "Get help";
            this.buttonGetHelp.UseVisualStyleBackColor = true;
            this.buttonGetHelp.Click += new System.EventHandler(this.buttonGetHelp_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSend.Location = new System.Drawing.Point(8, 68);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(169, 83);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send package";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWelcome.Location = new System.Drawing.Point(5, 20);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(420, 31);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome to Outpost parcel locker";
            // 
            // panelCode
            // 
            this.panelCode.Controls.Add(this.textBoxStatus);
            this.panelCode.Controls.Add(this.labelStatus);
            this.panelCode.Controls.Add(this.textBoxCode);
            this.panelCode.Controls.Add(this.buttonOpenLocker);
            this.panelCode.Controls.Add(this.buttonConfirmCode);
            this.panelCode.Controls.Add(this.labelInputCode);
            this.panelCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCode.Location = new System.Drawing.Point(0, 0);
            this.panelCode.Margin = new System.Windows.Forms.Padding(2);
            this.panelCode.Name = "panelCode";
            this.panelCode.Size = new System.Drawing.Size(425, 199);
            this.panelCode.TabIndex = 5;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxStatus.Location = new System.Drawing.Point(182, 103);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(234, 85);
            this.textBoxStatus.TabIndex = 6;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatus.Location = new System.Drawing.Point(85, 106);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(92, 31);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCode.Location = new System.Drawing.Point(182, 17);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(231, 38);
            this.textBoxCode.TabIndex = 4;
            // 
            // buttonOpenLocker
            // 
            this.buttonOpenLocker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenLocker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOpenLocker.Location = new System.Drawing.Point(8, 146);
            this.buttonOpenLocker.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenLocker.Name = "buttonOpenLocker";
            this.buttonOpenLocker.Size = new System.Drawing.Size(169, 42);
            this.buttonOpenLocker.TabIndex = 3;
            this.buttonOpenLocker.Text = "Open locker";
            this.buttonOpenLocker.UseVisualStyleBackColor = true;
            this.buttonOpenLocker.Click += new System.EventHandler(this.buttonOpenLocker_Click);
            // 
            // buttonConfirmCode
            // 
            this.buttonConfirmCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonConfirmCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonConfirmCode.Location = new System.Drawing.Point(8, 60);
            this.buttonConfirmCode.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirmCode.Name = "buttonConfirmCode";
            this.buttonConfirmCode.Size = new System.Drawing.Size(169, 40);
            this.buttonConfirmCode.TabIndex = 1;
            this.buttonConfirmCode.Text = "Confirm code";
            this.buttonConfirmCode.UseVisualStyleBackColor = true;
            this.buttonConfirmCode.Click += new System.EventHandler(this.buttonConfirmCode_Click);
            // 
            // labelInputCode
            // 
            this.labelInputCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInputCode.AutoSize = true;
            this.labelInputCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInputCode.Location = new System.Drawing.Point(36, 20);
            this.labelInputCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInputCode.Name = "labelInputCode";
            this.labelInputCode.Size = new System.Drawing.Size(141, 31);
            this.labelInputCode.TabIndex = 0;
            this.labelInputCode.Text = "Input code";
            // 
            // panelOpenLockerSend
            // 
            this.panelOpenLockerSend.Controls.Add(this.labelInfo2);
            this.panelOpenLockerSend.Controls.Add(this.labelInfo1);
            this.panelOpenLockerSend.Controls.Add(this.buttonConfirm);
            this.panelOpenLockerSend.Controls.Add(this.labelLockerOpened);
            this.panelOpenLockerSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpenLockerSend.Location = new System.Drawing.Point(0, 0);
            this.panelOpenLockerSend.Margin = new System.Windows.Forms.Padding(2);
            this.panelOpenLockerSend.Name = "panelOpenLockerSend";
            this.panelOpenLockerSend.Size = new System.Drawing.Size(425, 199);
            this.panelOpenLockerSend.TabIndex = 7;
            // 
            // labelInfo2
            // 
            this.labelInfo2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo2.Location = new System.Drawing.Point(11, 94);
            this.labelInfo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(316, 31);
            this.labelInfo2.TabIndex = 6;
            this.labelInfo2.Text = "press confirm when done";
            // 
            // labelInfo1
            // 
            this.labelInfo1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo1.Location = new System.Drawing.Point(11, 51);
            this.labelInfo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(409, 31);
            this.labelInfo1.TabIndex = 5;
            this.labelInfo1.Text = "Put your package and close door";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonConfirm.Location = new System.Drawing.Point(244, 145);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(169, 42);
            this.buttonConfirm.TabIndex = 3;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelLockerOpened
            // 
            this.labelLockerOpened.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLockerOpened.AutoSize = true;
            this.labelLockerOpened.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLockerOpened.Location = new System.Drawing.Point(11, 9);
            this.labelLockerOpened.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLockerOpened.Name = "labelLockerOpened";
            this.labelLockerOpened.Size = new System.Drawing.Size(193, 31);
            this.labelLockerOpened.TabIndex = 0;
            this.labelLockerOpened.Text = "Locker opened";
            // 
            // panelOpenLockerPickup
            // 
            this.panelOpenLockerPickup.Controls.Add(this.labelInfo4);
            this.panelOpenLockerPickup.Controls.Add(this.labelInfo3);
            this.panelOpenLockerPickup.Controls.Add(this.buttonConfirm2);
            this.panelOpenLockerPickup.Controls.Add(this.labelLockerOpened2);
            this.panelOpenLockerPickup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpenLockerPickup.Location = new System.Drawing.Point(0, 0);
            this.panelOpenLockerPickup.Margin = new System.Windows.Forms.Padding(2);
            this.panelOpenLockerPickup.Name = "panelOpenLockerPickup";
            this.panelOpenLockerPickup.Size = new System.Drawing.Size(425, 199);
            this.panelOpenLockerPickup.TabIndex = 8;
            // 
            // labelInfo4
            // 
            this.labelInfo4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInfo4.AutoSize = true;
            this.labelInfo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo4.Location = new System.Drawing.Point(11, 94);
            this.labelInfo4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo4.Name = "labelInfo4";
            this.labelInfo4.Size = new System.Drawing.Size(385, 31);
            this.labelInfo4.TabIndex = 6;
            this.labelInfo4.Text = "door, press confirm when done";
            // 
            // labelInfo3
            // 
            this.labelInfo3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInfo3.AutoSize = true;
            this.labelInfo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo3.Location = new System.Drawing.Point(11, 51);
            this.labelInfo3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo3.Name = "labelInfo3";
            this.labelInfo3.Size = new System.Drawing.Size(368, 31);
            this.labelInfo3.TabIndex = 5;
            this.labelInfo3.Text = "Take your package and close";
            // 
            // buttonConfirm2
            // 
            this.buttonConfirm2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonConfirm2.Location = new System.Drawing.Point(244, 145);
            this.buttonConfirm2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirm2.Name = "buttonConfirm2";
            this.buttonConfirm2.Size = new System.Drawing.Size(169, 42);
            this.buttonConfirm2.TabIndex = 3;
            this.buttonConfirm2.Text = "Confirm";
            this.buttonConfirm2.UseVisualStyleBackColor = true;
            this.buttonConfirm2.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelLockerOpened2
            // 
            this.labelLockerOpened2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLockerOpened2.AutoSize = true;
            this.labelLockerOpened2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLockerOpened2.Location = new System.Drawing.Point(11, 9);
            this.labelLockerOpened2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLockerOpened2.Name = "labelLockerOpened2";
            this.labelLockerOpened2.Size = new System.Drawing.Size(193, 31);
            this.labelLockerOpened2.TabIndex = 0;
            this.labelLockerOpened2.Text = "Locker opened";
            // 
            // panelRegards
            // 
            this.panelRegards.Controls.Add(this.buttonAgain);
            this.panelRegards.Controls.Add(this.labelRegards);
            this.panelRegards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegards.Location = new System.Drawing.Point(0, 0);
            this.panelRegards.Margin = new System.Windows.Forms.Padding(2);
            this.panelRegards.Name = "panelRegards";
            this.panelRegards.Size = new System.Drawing.Size(425, 199);
            this.panelRegards.TabIndex = 9;
            // 
            // buttonAgain
            // 
            this.buttonAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAgain.Location = new System.Drawing.Point(30, 89);
            this.buttonAgain.Name = "buttonAgain";
            this.buttonAgain.Size = new System.Drawing.Size(366, 48);
            this.buttonAgain.TabIndex = 1;
            this.buttonAgain.Text = "write text";
            this.buttonAgain.UseVisualStyleBackColor = true;
            this.buttonAgain.Click += new System.EventHandler(this.buttonAgain_Click);
            // 
            // labelRegards
            // 
            this.labelRegards.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelRegards.AutoSize = true;
            this.labelRegards.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRegards.Location = new System.Drawing.Point(36, 51);
            this.labelRegards.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegards.Name = "labelRegards";
            this.labelRegards.Size = new System.Drawing.Size(355, 31);
            this.labelRegards.TabIndex = 0;
            this.labelRegards.Text = "Thank you for using Outpost";
            // 
            // timerReturnToMainWindow
            // 
            this.timerReturnToMainWindow.Interval = 120000;
            this.timerReturnToMainWindow.Tick += new System.EventHandler(this.timerReturnToMainWindow_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 199);
            this.Controls.Add(this.panelRegards);
            this.Controls.Add(this.panelOpenLockerPickup);
            this.Controls.Add(this.panelOpenLockerSend);
            this.Controls.Add(this.panelCode);
            this.Controls.Add(this.panelAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Parcellocker WRO1";
            this.panelAction.ResumeLayout(false);
            this.panelAction.PerformLayout();
            this.panelCode.ResumeLayout(false);
            this.panelCode.PerformLayout();
            this.panelOpenLockerSend.ResumeLayout(false);
            this.panelOpenLockerSend.PerformLayout();
            this.panelOpenLockerPickup.ResumeLayout(false);
            this.panelOpenLockerPickup.PerformLayout();
            this.panelRegards.ResumeLayout(false);
            this.panelRegards.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.Button buttonCourierLogIn;
        private System.Windows.Forms.Button buttonPickUp;
        private System.Windows.Forms.Button buttonGetHelp;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelCode;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonOpenLocker;
        private System.Windows.Forms.Button buttonConfirmCode;
        private System.Windows.Forms.Label labelInputCode;
        private System.Windows.Forms.Panel panelOpenLockerSend;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelLockerOpened;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.Panel panelOpenLockerPickup;
        private System.Windows.Forms.Label labelInfo4;
        private System.Windows.Forms.Label labelInfo3;
        private System.Windows.Forms.Button buttonConfirm2;
        private System.Windows.Forms.Label labelLockerOpened2;
        private System.Windows.Forms.Panel panelRegards;
        private System.Windows.Forms.Button buttonAgain;
        private System.Windows.Forms.Label labelRegards;
        private System.Windows.Forms.Timer timerReturnToMainWindow;
    }
}