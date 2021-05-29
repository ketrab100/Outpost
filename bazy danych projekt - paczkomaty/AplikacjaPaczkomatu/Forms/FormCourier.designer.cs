
namespace AplikacjaPaczkomatu.Forms
{
    partial class FormCourier
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
            this.labelLoggedAs = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonPickUpPackages = new System.Windows.Forms.Button();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.labelSelectPackagesToPickUp = new System.Windows.Forms.Label();
            this.buttonDeliverPackage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLoggedAs
            // 
            this.labelLoggedAs.AutoSize = true;
            this.labelLoggedAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoggedAs.Location = new System.Drawing.Point(18, 14);
            this.labelLoggedAs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoggedAs.Name = "labelLoggedAs";
            this.labelLoggedAs.Size = new System.Drawing.Size(167, 37);
            this.labelLoggedAs.TabIndex = 2;
            this.labelLoggedAs.Text = "Logged as";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(196, 9);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(572, 44);
            this.textBoxName.TabIndex = 8;
            // 
            // buttonPickUpPackages
            // 
            this.buttonPickUpPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPickUpPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPickUpPackages.Location = new System.Drawing.Point(18, 563);
            this.buttonPickUpPackages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPickUpPackages.Name = "buttonPickUpPackages";
            this.buttonPickUpPackages.Size = new System.Drawing.Size(372, 74);
            this.buttonPickUpPackages.TabIndex = 9;
            this.buttonPickUpPackages.Text = "Pick up packages";
            this.buttonPickUpPackages.UseVisualStyleBackColor = true;
            this.buttonPickUpPackages.Click += new System.EventHandler(this.buttonPickUpPackages_Click);
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.AllowUserToAddRows = false;
            this.dataGridViewSelect.AllowUserToDeleteRows = false;
            this.dataGridViewSelect.AllowUserToResizeColumns = false;
            this.dataGridViewSelect.AllowUserToResizeRows = false;
            this.dataGridViewSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Location = new System.Drawing.Point(18, 114);
            this.dataGridViewSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.ReadOnly = true;
            this.dataGridViewSelect.RowHeadersVisible = false;
            this.dataGridViewSelect.RowHeadersWidth = 62;
            this.dataGridViewSelect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSelect.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSelect.Size = new System.Drawing.Size(753, 440);
            this.dataGridViewSelect.TabIndex = 10;
            // 
            // labelSelectPackagesToPickUp
            // 
            this.labelSelectPackagesToPickUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSelectPackagesToPickUp.AutoSize = true;
            this.labelSelectPackagesToPickUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSelectPackagesToPickUp.Location = new System.Drawing.Point(192, 69);
            this.labelSelectPackagesToPickUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectPackagesToPickUp.Name = "labelSelectPackagesToPickUp";
            this.labelSelectPackagesToPickUp.Size = new System.Drawing.Size(397, 37);
            this.labelSelectPackagesToPickUp.TabIndex = 11;
            this.labelSelectPackagesToPickUp.Text = "Select packages to pick up";
            // 
            // buttonDeliverPackage
            // 
            this.buttonDeliverPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeliverPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeliverPackage.Location = new System.Drawing.Point(399, 563);
            this.buttonDeliverPackage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeliverPackage.Name = "buttonDeliverPackage";
            this.buttonDeliverPackage.Size = new System.Drawing.Size(372, 74);
            this.buttonDeliverPackage.TabIndex = 12;
            this.buttonDeliverPackage.Text = "Deliver package";
            this.buttonDeliverPackage.UseVisualStyleBackColor = true;
            this.buttonDeliverPackage.Click += new System.EventHandler(this.buttonDeliverPackage_Click);
            // 
            // FormCourier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 655);
            this.Controls.Add(this.buttonDeliverPackage);
            this.Controls.Add(this.labelSelectPackagesToPickUp);
            this.Controls.Add(this.dataGridViewSelect);
            this.Controls.Add(this.buttonPickUpPackages);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelLoggedAs);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCourier";
            this.Text = "FormCourier";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoggedAs;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonPickUpPackages;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.Label labelSelectPackagesToPickUp;
        private System.Windows.Forms.Button buttonDeliverPackage;
    }
}