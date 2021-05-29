
namespace AplikacjaKlienta.Forms
{
    partial class FormClient
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
            this.buttonSendPackage = new System.Windows.Forms.Button();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.labelAction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLoggedAs
            // 
            this.labelLoggedAs.AutoSize = true;
            this.labelLoggedAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoggedAs.Location = new System.Drawing.Point(12, 9);
            this.labelLoggedAs.Name = "labelLoggedAs";
            this.labelLoggedAs.Size = new System.Drawing.Size(113, 26);
            this.labelLoggedAs.TabIndex = 2;
            this.labelLoggedAs.Text = "Logged as";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(131, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(383, 32);
            this.textBoxName.TabIndex = 8;
            // 
            // buttonSendPackage
            // 
            this.buttonSendPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSendPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSendPackage.Location = new System.Drawing.Point(12, 366);
            this.buttonSendPackage.Name = "buttonSendPackage";
            this.buttonSendPackage.Size = new System.Drawing.Size(502, 48);
            this.buttonSendPackage.TabIndex = 9;
            this.buttonSendPackage.Text = "Send package";
            this.buttonSendPackage.UseVisualStyleBackColor = true;
            this.buttonSendPackage.Click += new System.EventHandler(this.buttonSendPackage_Click);
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
            this.dataGridViewSelect.Location = new System.Drawing.Point(12, 74);
            this.dataGridViewSelect.MultiSelect = false;
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.ReadOnly = true;
            this.dataGridViewSelect.RowHeadersVisible = false;
            this.dataGridViewSelect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSelect.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSelect.Size = new System.Drawing.Size(502, 286);
            this.dataGridViewSelect.TabIndex = 10;
            // 
            // labelAction
            // 
            this.labelAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAction.AutoSize = true;
            this.labelAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAction.Location = new System.Drawing.Point(104, 45);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(319, 26);
            this.labelAction.TabIndex = 11;
            this.labelAction.Text = "Select package size and priority";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 426);
            this.Controls.Add(this.labelAction);
            this.Controls.Add(this.dataGridViewSelect);
            this.Controls.Add(this.buttonSendPackage);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelLoggedAs);
            this.Name = "FormMain";
            this.Text = "FormClient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoggedAs;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSendPackage;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.Label labelAction;
    }
}