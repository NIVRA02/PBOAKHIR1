namespace KOS_BU_IPUNG_PBO
{
    partial class FrmUserPesan
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
            this.dgvKamar = new System.Windows.Forms.DataGridView();
            this.pnlPemesanan = new System.Windows.Forms.Panel();
            this.lblSelectedKamarValue = new System.Windows.Forms.Label();
            this.lblSelectedKamar = new System.Windows.Forms.Label();
            this.btnPesan = new System.Windows.Forms.Button();
            this.tb_alamat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nohp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDaftarKamarTitle = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).BeginInit();
            this.pnlPemesanan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKamar
            // 
            this.dgvKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKamar.Location = new System.Drawing.Point(30, 110);
            this.dgvKamar.Name = "dgvKamar";
            this.dgvKamar.RowHeadersWidth = 51;
            this.dgvKamar.RowTemplate.Height = 24;
            this.dgvKamar.Size = new System.Drawing.Size(340, 380);
            this.dgvKamar.TabIndex = 0;
            this.dgvKamar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKamar_CellClick);
            // 
            // pnlPemesanan
            // 
            this.pnlPemesanan.Controls.Add(this.lblSelectedKamarValue);
            this.pnlPemesanan.Controls.Add(this.lblSelectedKamar);
            this.pnlPemesanan.Controls.Add(this.btnPesan);
            this.pnlPemesanan.Controls.Add(this.tb_alamat);
            this.pnlPemesanan.Controls.Add(this.label3);
            this.pnlPemesanan.Controls.Add(this.tb_nohp);
            this.pnlPemesanan.Controls.Add(this.label2);
            this.pnlPemesanan.Controls.Add(this.tb_nama);
            this.pnlPemesanan.Controls.Add(this.label1);
            this.pnlPemesanan.Location = new System.Drawing.Point(400, 80);
            this.pnlPemesanan.Name = "pnlPemesanan";
            this.pnlPemesanan.Size = new System.Drawing.Size(350, 410);
            this.pnlPemesanan.TabIndex = 1;
            // 
            // lblSelectedKamarValue
            // 
            this.lblSelectedKamarValue.AutoSize = true;
            this.lblSelectedKamarValue.Location = new System.Drawing.Point(17, 340);
            this.lblSelectedKamarValue.Name = "lblSelectedKamarValue";
            this.lblSelectedKamarValue.Size = new System.Drawing.Size(85, 16);
            this.lblSelectedKamarValue.TabIndex = 8;
            this.lblSelectedKamarValue.Text = "Belum Dipilih";
            // 
            // lblSelectedKamar
            // 
            this.lblSelectedKamar.AutoSize = true;
            this.lblSelectedKamar.Location = new System.Drawing.Point(17, 312);
            this.lblSelectedKamar.Name = "lblSelectedKamar";
            this.lblSelectedKamar.Size = new System.Drawing.Size(89, 16);
            this.lblSelectedKamar.TabIndex = 7;
            this.lblSelectedKamar.Text = "Kamar Dipilih:";
            // 
            // btnPesan
            // 
            this.btnPesan.Location = new System.Drawing.Point(0, 360);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(350, 50);
            this.btnPesan.TabIndex = 6;
            this.btnPesan.Text = "Pesan Sekarang";
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // tb_alamat
            // 
            this.tb_alamat.Location = new System.Drawing.Point(20, 210);
            this.tb_alamat.Multiline = true;
            this.tb_alamat.Name = "tb_alamat";
            this.tb_alamat.Size = new System.Drawing.Size(310, 80);
            this.tb_alamat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alamat Asal";
            // 
            // tb_nohp
            // 
            this.tb_nohp.Location = new System.Drawing.Point(20, 130);
            this.tb_nohp.Name = "tb_nohp";
            this.tb_nohp.Size = new System.Drawing.Size(310, 22);
            this.tb_nohp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nomor Telepon";
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(20, 50);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(310, 22);
            this.tb_nama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Lengkap";
            // 
            // lblDaftarKamarTitle
            // 
            this.lblDaftarKamarTitle.AutoSize = true;
            this.lblDaftarKamarTitle.Location = new System.Drawing.Point(27, 80);
            this.lblDaftarKamarTitle.Name = "lblDaftarKamarTitle";
            this.lblDaftarKamarTitle.Size = new System.Drawing.Size(143, 16);
            this.lblDaftarKamarTitle.TabIndex = 2;
            this.lblDaftarKamarTitle.Text = "Daftar Kamar Tersedia";
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(630, 500);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(120, 40);
            this.btnKembali.TabIndex = 3;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // FrmUserPesan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.lblDaftarKamarTitle);
            this.Controls.Add(this.pnlPemesanan);
            this.Controls.Add(this.dgvKamar);
            this.Name = "FrmUserPesan";
            this.Text = "Pesan Kamar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).EndInit();
            this.pnlPemesanan.ResumeLayout(false);
            this.pnlPemesanan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKamar;
        private System.Windows.Forms.Panel pnlPemesanan;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.TextBox tb_alamat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nohp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDaftarKamarTitle;
        private System.Windows.Forms.Label lblSelectedKamarValue;
        private System.Windows.Forms.Label lblSelectedKamar;
        private System.Windows.Forms.Button btnKembali; // Variabel tombol kembali
    }
}