
namespace AplikacjaKlienta.Forms
{
    partial class FormLogIn
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.buttonCheckStatus = new System.Windows.Forms.Button();
            this.textBoxPackageCode = new System.Windows.Forms.TextBox();
            this.labelPackageCode = new System.Windows.Forms.Label();
            this.buttonNewAcoount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUsername.Location = new System.Drawing.Point(13, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(113, 26);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUsername.Location = new System.Drawing.Point(132, 6);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(233, 32);
            this.textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.Location = new System.Drawing.Point(132, 44);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(233, 32);
            this.textBoxPassword.TabIndex = 5;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.Location = new System.Drawing.Point(13, 47);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(108, 26);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogIn.Location = new System.Drawing.Point(184, 82);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(181, 60);
            this.buttonLogIn.TabIndex = 6;
            this.buttonLogIn.Text = "Log in";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // buttonCheckStatus
            // 
            this.buttonCheckStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCheckStatus.Location = new System.Drawing.Point(12, 186);
            this.buttonCheckStatus.Name = "buttonCheckStatus";
            this.buttonCheckStatus.Size = new System.Drawing.Size(353, 60);
            this.buttonCheckStatus.TabIndex = 10;
            this.buttonCheckStatus.Text = "Check status";
            this.buttonCheckStatus.UseVisualStyleBackColor = true;
            this.buttonCheckStatus.Click += new System.EventHandler(this.buttonCheckStatus_Click);
            // 
            // textBoxPackageCode
            // 
            this.textBoxPackageCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPackageCode.Location = new System.Drawing.Point(132, 148);
            this.textBoxPackageCode.Name = "textBoxPackageCode";
            this.textBoxPackageCode.Size = new System.Drawing.Size(233, 32);
            this.textBoxPackageCode.TabIndex = 9;
            // 
            // labelPackageCode
            // 
            this.labelPackageCode.AutoSize = true;
            this.labelPackageCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPackageCode.Location = new System.Drawing.Point(13, 151);
            this.labelPackageCode.Name = "labelPackageCode";
            this.labelPackageCode.Size = new System.Drawing.Size(64, 26);
            this.labelPackageCode.TabIndex = 8;
            this.labelPackageCode.Text = "Code";
            // 
            // buttonNewAcoount
            // 
            this.buttonNewAcoount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNewAcoount.Location = new System.Drawing.Point(12, 82);
            this.buttonNewAcoount.Name = "buttonNewAcoount";
            this.buttonNewAcoount.Size = new System.Drawing.Size(166, 60);
            this.buttonNewAcoount.TabIndex = 12;
            this.buttonNewAcoount.Text = "NewAccount";
            this.buttonNewAcoount.UseVisualStyleBackColor = true;
            this.buttonNewAcoount.Click += new System.EventHandler(this.buttonNewAcoount_Click);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 257);
            this.Controls.Add(this.buttonNewAcoount);
            this.Controls.Add(this.buttonCheckStatus);
            this.Controls.Add(this.textBoxPackageCode);
            this.Controls.Add(this.labelPackageCode);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FormLogIn";
            this.Text = "Szymon Hutnik - homework 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Button buttonCheckStatus;
        private System.Windows.Forms.TextBox textBoxPackageCode;
        private System.Windows.Forms.Label labelPackageCode;
        private System.Windows.Forms.Button buttonNewAcoount;
    }
}

