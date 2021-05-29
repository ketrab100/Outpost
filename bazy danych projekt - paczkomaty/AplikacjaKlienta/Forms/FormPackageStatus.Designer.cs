
namespace AplikacjaKlienta.Forms
{
    partial class FormPackageStatus
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
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.textBoxPostCode = new System.Windows.Forms.TextBox();
            this.labelPostCode = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxParcelLockerName = new System.Windows.Forms.TextBox();
            this.labelParcelLockerName = new System.Windows.Forms.Label();
            this.groupBoxDestination = new System.Windows.Forms.GroupBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxSentDate = new System.Windows.Forms.TextBox();
            this.labalSentDate = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.groupBoxDestination.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCode
            // 
            this.textBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCode.Location = new System.Drawing.Point(184, 6);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ReadOnly = true;
            this.textBoxCode.Size = new System.Drawing.Size(308, 32);
            this.textBoxCode.TabIndex = 7;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCode.Location = new System.Drawing.Point(12, 9);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(64, 26);
            this.labelCode.TabIndex = 6;
            this.labelCode.Text = "Code";
            // 
            // textBoxPostCode
            // 
            this.textBoxPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPostCode.Location = new System.Drawing.Point(172, 139);
            this.textBoxPostCode.Name = "textBoxPostCode";
            this.textBoxPostCode.ReadOnly = true;
            this.textBoxPostCode.Size = new System.Drawing.Size(308, 32);
            this.textBoxPostCode.TabIndex = 13;
            // 
            // labelPostCode
            // 
            this.labelPostCode.AutoSize = true;
            this.labelPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPostCode.Location = new System.Drawing.Point(6, 142);
            this.labelPostCode.Name = "labelPostCode";
            this.labelPostCode.Size = new System.Drawing.Size(125, 26);
            this.labelPostCode.TabIndex = 12;
            this.labelPostCode.Text = "  - postcode";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAddress.Location = new System.Drawing.Point(172, 63);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new System.Drawing.Size(308, 32);
            this.textBoxAddress.TabIndex = 15;
            // 
            // textBoxParcelLockerName
            // 
            this.textBoxParcelLockerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxParcelLockerName.Location = new System.Drawing.Point(172, 25);
            this.textBoxParcelLockerName.Name = "textBoxParcelLockerName";
            this.textBoxParcelLockerName.ReadOnly = true;
            this.textBoxParcelLockerName.Size = new System.Drawing.Size(308, 32);
            this.textBoxParcelLockerName.TabIndex = 17;
            // 
            // labelParcelLockerName
            // 
            this.labelParcelLockerName.AutoSize = true;
            this.labelParcelLockerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelParcelLockerName.Location = new System.Drawing.Point(6, 28);
            this.labelParcelLockerName.Name = "labelParcelLockerName";
            this.labelParcelLockerName.Size = new System.Drawing.Size(160, 26);
            this.labelParcelLockerName.TabIndex = 16;
            this.labelParcelLockerName.Text = "  - parcel locker";
            // 
            // groupBoxDestination
            // 
            this.groupBoxDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxDestination.Controls.Add(this.textBoxCity);
            this.groupBoxDestination.Controls.Add(this.labelAddress);
            this.groupBoxDestination.Controls.Add(this.textBoxParcelLockerName);
            this.groupBoxDestination.Controls.Add(this.labelPostCode);
            this.groupBoxDestination.Controls.Add(this.labelParcelLockerName);
            this.groupBoxDestination.Controls.Add(this.textBoxPostCode);
            this.groupBoxDestination.Controls.Add(this.textBoxAddress);
            this.groupBoxDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxDestination.Location = new System.Drawing.Point(12, 162);
            this.groupBoxDestination.Name = "groupBoxDestination";
            this.groupBoxDestination.Size = new System.Drawing.Size(486, 182);
            this.groupBoxDestination.TabIndex = 18;
            this.groupBoxDestination.TabStop = false;
            this.groupBoxDestination.Text = "Destination";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCity.Location = new System.Drawing.Point(172, 101);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.ReadOnly = true;
            this.textBoxCity.Size = new System.Drawing.Size(308, 32);
            this.textBoxCity.TabIndex = 19;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAddress.Location = new System.Drawing.Point(6, 86);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(114, 26);
            this.labelAddress.TabIndex = 18;
            this.labelAddress.Text = "  - address";
            // 
            // textBoxSentDate
            // 
            this.textBoxSentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSentDate.Location = new System.Drawing.Point(184, 44);
            this.textBoxSentDate.Name = "textBoxSentDate";
            this.textBoxSentDate.ReadOnly = true;
            this.textBoxSentDate.Size = new System.Drawing.Size(308, 32);
            this.textBoxSentDate.TabIndex = 20;
            // 
            // labalSentDate
            // 
            this.labalSentDate.AutoSize = true;
            this.labalSentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labalSentDate.Location = new System.Drawing.Point(12, 47);
            this.labalSentDate.Name = "labalSentDate";
            this.labalSentDate.Size = new System.Drawing.Size(109, 26);
            this.labalSentDate.TabIndex = 19;
            this.labalSentDate.Text = "Sent Date";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxStatus.Location = new System.Drawing.Point(184, 120);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(308, 32);
            this.textBoxStatus.TabIndex = 22;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatus.Location = new System.Drawing.Point(12, 123);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(74, 26);
            this.labelStatus.TabIndex = 21;
            this.labelStatus.Text = "Status";
            // 
            // textBoxType
            // 
            this.textBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxType.Location = new System.Drawing.Point(184, 82);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.ReadOnly = true;
            this.textBoxType.Size = new System.Drawing.Size(308, 32);
            this.textBoxType.TabIndex = 24;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelType.Location = new System.Drawing.Point(12, 85);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(59, 26);
            this.labelType.TabIndex = 23;
            this.labelType.Text = "Type";
            // 
            // FormPackageStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 356);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxSentDate);
            this.Controls.Add(this.labalSentDate);
            this.Controls.Add(this.groupBoxDestination);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPackageStatus";
            this.Text = "FormPackageStatus";
            this.groupBoxDestination.ResumeLayout(false);
            this.groupBoxDestination.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBoxPostCode;
        private System.Windows.Forms.Label labelPostCode;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxParcelLockerName;
        private System.Windows.Forms.Label labelParcelLockerName;
        private System.Windows.Forms.GroupBox groupBoxDestination;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxSentDate;
        private System.Windows.Forms.Label labalSentDate;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label labelType;
    }
}