namespace KOS_BU_IPUNG_PBO
{
    partial class FrmUserStatus
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridStatus = new System.Windows.Forms.DataGridView();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnHubungiAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(668, 363);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 35);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "KEMBALI";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dataGridStatus
            // 
            this.dataGridStatus.AllowUserToAddRows = false;
            this.dataGridStatus.AllowUserToDeleteRows = false;
            this.dataGridStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStatus.Location = new System.Drawing.Point(12, 12);
            this.dataGridStatus.Name = "dataGridStatus";
            this.dataGridStatus.ReadOnly = true;
            this.dataGridStatus.RowHeadersWidth = 51;
            this.dataGridStatus.RowTemplate.Height = 24;
            this.dataGridStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStatus.Size = new System.Drawing.Size(776, 337);
            this.dataGridStatus.TabIndex = 0;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.IndianRed;
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(12, 363);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(160, 35);
            this.btnBatal.TabIndex = 1;
            this.btnBatal.Text = "Batalkan Pesanan";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnHubungiAdmin
            // 
            this.btnHubungiAdmin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHubungiAdmin.ForeColor = System.Drawing.Color.White;
            this.btnHubungiAdmin.Location = new System.Drawing.Point(178, 363);
            this.btnHubungiAdmin.Name = "btnHubungiAdmin";
            this.btnHubungiAdmin.Size = new System.Drawing.Size(160, 35);
            this.btnHubungiAdmin.TabIndex = 2;
            this.btnHubungiAdmin.Text = "Hubungi Admin";
            this.btnHubungiAdmin.UseVisualStyleBackColor = false;
            this.btnHubungiAdmin.Click += new System.EventHandler(this.btnHubungiAdmin_Click);
            // 
            // FrmUserStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.btnHubungiAdmin);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.dataGridStatus);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUserStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu User : Status Pemesanan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatus)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridStatus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnHubungiAdmin;
    }
}