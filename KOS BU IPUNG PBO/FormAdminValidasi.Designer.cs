namespace KOS_BU_IPUNG_PBO
{
    partial class FormAdminValidasi
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewValidasi = new System.Windows.Forms.DataGridView();
            this.groupBoxDetail = new System.Windows.Forms.GroupBox();
            this.txtTanggalPesan = new System.Windows.Forms.TextBox();
            this.txtNomorKamar = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtIdPemesanan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValidasi = new System.Windows.Forms.Button();
            this.btnTolak = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValidasi)).BeginInit();
            this.groupBoxDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Validasi Pembayaran";
            // 
            // dataGridViewValidasi
            // 
            this.dataGridViewValidasi.AllowUserToAddRows = false;
            this.dataGridViewValidasi.AllowUserToDeleteRows = false;
            this.dataGridViewValidasi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewValidasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValidasi.Location = new System.Drawing.Point(17, 50);
            this.dataGridViewValidasi.MultiSelect = false;
            this.dataGridViewValidasi.Name = "dataGridViewValidasi";
            this.dataGridViewValidasi.ReadOnly = true;
            this.dataGridViewValidasi.RowHeadersWidth = 51;
            this.dataGridViewValidasi.RowTemplate.Height = 24;
            this.dataGridViewValidasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewValidasi.Size = new System.Drawing.Size(755, 200);
            this.dataGridViewValidasi.TabIndex = 1;
            this.dataGridViewValidasi.SelectionChanged += new System.EventHandler(this.dataGridViewValidasi_SelectionChanged);
            // 
            // groupBoxDetail
            // 
            this.groupBoxDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDetail.Controls.Add(this.txtTanggalPesan);
            this.groupBoxDetail.Controls.Add(this.txtNomorKamar);
            this.groupBoxDetail.Controls.Add(this.txtUsername);
            this.groupBoxDetail.Controls.Add(this.txtIdPemesanan);
            this.groupBoxDetail.Controls.Add(this.label5);
            this.groupBoxDetail.Controls.Add(this.label4);
            this.groupBoxDetail.Controls.Add(this.label3);
            this.groupBoxDetail.Controls.Add(this.label2);
            this.groupBoxDetail.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDetail.Location = new System.Drawing.Point(17, 265);
            this.groupBoxDetail.Name = "groupBoxDetail";
            this.groupBoxDetail.Size = new System.Drawing.Size(550, 173);
            this.groupBoxDetail.TabIndex = 2;
            this.groupBoxDetail.TabStop = false;
            this.groupBoxDetail.Text = "Detail Pemesanan";
            // 
            // txtTanggalPesan
            // 
            this.txtTanggalPesan.BackColor = System.Drawing.Color.White;
            this.txtTanggalPesan.Location = new System.Drawing.Point(170, 130);
            this.txtTanggalPesan.Name = "txtTanggalPesan";
            this.txtTanggalPesan.ReadOnly = true;
            this.txtTanggalPesan.Size = new System.Drawing.Size(350, 27);
            this.txtTanggalPesan.TabIndex = 7;
            // 
            // txtNomorKamar
            // 
            this.txtNomorKamar.BackColor = System.Drawing.Color.White;
            this.txtNomorKamar.Location = new System.Drawing.Point(170, 97);
            this.txtNomorKamar.Name = "txtNomorKamar";
            this.txtNomorKamar.ReadOnly = true;
            this.txtNomorKamar.Size = new System.Drawing.Size(350, 27);
            this.txtNomorKamar.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(170, 64);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(350, 27);
            this.txtUsername.TabIndex = 5;
            // 
            // txtIdPemesanan
            // 
            this.txtIdPemesanan.BackColor = System.Drawing.Color.White;
            this.txtIdPemesanan.Location = new System.Drawing.Point(170, 31);
            this.txtIdPemesanan.Name = "txtIdPemesanan";
            this.txtIdPemesanan.ReadOnly = true;
            this.txtIdPemesanan.Size = new System.Drawing.Size(350, 27);
            this.txtIdPemesanan.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tanggal Pesan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nomor Kamar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username Pemesan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Pemesanan:";
            // 
            // btnValidasi
            // 
            this.btnValidasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidasi.BackColor = System.Drawing.Color.ForestGreen;
            this.btnValidasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidasi.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidasi.ForeColor = System.Drawing.Color.White;
            this.btnValidasi.Location = new System.Drawing.Point(590, 274);
            this.btnValidasi.Name = "btnValidasi";
            this.btnValidasi.Size = new System.Drawing.Size(182, 45);
            this.btnValidasi.TabIndex = 3;
            this.btnValidasi.Text = "Validasi Pembayaran";
            this.btnValidasi.UseVisualStyleBackColor = false;
            this.btnValidasi.Click += new System.EventHandler(this.btnValidasi_Click);
            // 
            // btnTolak
            // 
            this.btnTolak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTolak.BackColor = System.Drawing.Color.Crimson;
            this.btnTolak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTolak.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTolak.ForeColor = System.Drawing.Color.White;
            this.btnTolak.Location = new System.Drawing.Point(590, 329);
            this.btnTolak.Name = "btnTolak";
            this.btnTolak.Size = new System.Drawing.Size(182, 45);
            this.btnTolak.TabIndex = 4;
            this.btnTolak.Text = "Tolak Pembayaran";
            this.btnTolak.UseVisualStyleBackColor = false;
            this.btnTolak.Click += new System.EventHandler(this.btnTolak_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(590, 388);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(182, 45);
            this.btnKembali.TabIndex = 5;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // FormAdminValidasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnTolak);
            this.Controls.Add(this.btnValidasi);
            this.Controls.Add(this.groupBoxDetail);
            this.Controls.Add(this.dataGridViewValidasi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdminValidasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin: Validasi Pembayaran";
            this.Load += new System.EventHandler(this.FormAdminValidasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValidasi)).EndInit();
            this.groupBoxDetail.ResumeLayout(false);
            this.groupBoxDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewValidasi;
        private System.Windows.Forms.GroupBox groupBoxDetail;
        private System.Windows.Forms.Button btnValidasi;
        private System.Windows.Forms.Button btnTolak;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTanggalPesan;
        private System.Windows.Forms.TextBox txtNomorKamar;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtIdPemesanan;
    }
}
