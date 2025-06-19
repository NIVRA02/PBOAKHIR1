namespace KOS_BU_IPUNG_PBO
{
    partial class FormUserProfil
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox(); // Changed from lblUsernameValue
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox(); // Changed from lblEmailValue
            this.labelOldPassword = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmNewPassword = new System.Windows.Forms.Label();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profil Pengguna";
            //
            // labelUsername
            //
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(34, 90);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(89, 20);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username:";
            //
            // txtUsername
            //
            this.txtUsername.Location = new System.Drawing.Point(38, 113);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 26);
            this.txtUsername.TabIndex = 2;
            //
            // labelEmail
            //
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(34, 150);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(56, 20);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email:";
            //
            // txtEmail
            //
            this.txtEmail.Location = new System.Drawing.Point(38, 173);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 26);
            this.txtEmail.TabIndex = 4;
            //
            // labelOldPassword
            //
            this.labelOldPassword.AutoSize = true;
            this.labelOldPassword.Location = new System.Drawing.Point(34, 210);
            this.labelOldPassword.Name = "labelOldPassword";
            this.labelOldPassword.Size = new System.Drawing.Size(117, 20);
            this.labelOldPassword.TabIndex = 5;
            this.labelOldPassword.Text = "Password Lama:";
            //
            // txtOldPassword
            //
            this.txtOldPassword.Location = new System.Drawing.Point(38, 233);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(250, 26);
            this.txtOldPassword.TabIndex = 6;
            //
            // labelNewPassword
            //
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(34, 270);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(115, 20);
            this.labelNewPassword.TabIndex = 7;
            this.labelNewPassword.Text = "Password Baru:";
            //
            // txtNewPassword
            //
            this.txtNewPassword.Location = new System.Drawing.Point(38, 293);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(250, 26);
            this.txtNewPassword.TabIndex = 8;
            //
            // labelConfirmNewPassword
            //
            this.labelConfirmNewPassword.AutoSize = true;
            this.labelConfirmNewPassword.Location = new System.Drawing.Point(34, 330);
            this.labelConfirmNewPassword.Name = "labelConfirmNewPassword";
            this.labelConfirmNewPassword.Size = new System.Drawing.Size(182, 20);
            this.labelConfirmNewPassword.TabIndex = 9;
            this.labelConfirmNewPassword.Text = "Konfirmasi Password Baru:";
            //
            // txtConfirmNewPassword
            //
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(38, 353);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.PasswordChar = '*';
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(250, 26);
            this.txtConfirmNewPassword.TabIndex = 10;
            //
            // btnSaveChanges
            //
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(38, 420); // Adjusted position
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(250, 40);
            this.btnSaveChanges.TabIndex = 11;
            this.btnSaveChanges.Text = "Simpan Perubahan";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            //
            // btnBack
            //
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(38, 470); // Adjusted position
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(250, 40);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Kembali";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            //
            // chkShowPassword
            //
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(38, 385); // Adjusted position
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(150, 24);
            this.chkShowPassword.TabIndex = 13;
            this.chkShowPassword.Text = "Tampilkan Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            //
            // FormUserProfil
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 530); // Adjusted client size
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtConfirmNewPassword);
            this.Controls.Add(this.labelConfirmNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.labelOldPassword);
            this.Controls.Add(this.txtEmail); // Changed from lblEmailValue
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtUsername); // Changed from lblUsernameValue
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormUserProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil Pengguna";
            this.Load += new System.EventHandler(this.FormUserProfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox txtUsername; // Changed from lblUsernameValue
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtEmail; // Changed from lblEmailValue
        private System.Windows.Forms.Label labelOldPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label labelConfirmNewPassword;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox chkShowPassword;
    }
}