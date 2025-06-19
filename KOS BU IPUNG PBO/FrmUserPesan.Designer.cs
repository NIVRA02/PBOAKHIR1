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
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboNomorKamar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datePickerMulaiSewa = new System.Windows.Forms.DateTimePicker();
            this.btnPesan = new System.Windows.Forms.Button();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.lblDetailFasilitas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDetailTipe = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDetailHarga = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(344, 460);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 35);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "KEMBALI";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pilih Kamar Tersedia:";
            // 
            // comboNomorKamar
            // 
            this.comboNomorKamar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNomorKamar.FormattingEnabled = true;
            this.comboNomorKamar.Location = new System.Drawing.Point(57, 57);
            this.comboNomorKamar.Name = "comboNomorKamar";
            this.comboNomorKamar.Size = new System.Drawing.Size(142, 24);
            this.comboNomorKamar.TabIndex = 0;
            this.comboNomorKamar.SelectedIndexChanged += new System.EventHandler(this.comboNomorKamar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tanggal Mulai Sewa:";
            // 
            // datePickerMulaiSewa
            // 
            this.datePickerMulaiSewa.Location = new System.Drawing.Point(270, 58);
            this.datePickerMulaiSewa.Name = "datePickerMulaiSewa";
            this.datePickerMulaiSewa.Size = new System.Drawing.Size(248, 22);
            this.datePickerMulaiSewa.TabIndex = 1;
            // 
            // btnPesan
            // 
            this.btnPesan.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesan.ForeColor = System.Drawing.Color.White;
            this.btnPesan.Location = new System.Drawing.Point(308, 388);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(199, 43);
            this.btnPesan.TabIndex = 3;
            this.btnPesan.Text = "Pesan Sekarang";
            this.btnPesan.UseVisualStyleBackColor = false;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetail.Controls.Add(this.lblDetailFasilitas);
            this.panelDetail.Controls.Add(this.label7);
            this.panelDetail.Controls.Add(this.lblDetailTipe);
            this.panelDetail.Controls.Add(this.label5);
            this.panelDetail.Controls.Add(this.lblDetailHarga);
            this.panelDetail.Controls.Add(this.label4);
            this.panelDetail.Controls.Add(this.label3);
            this.panelDetail.Location = new System.Drawing.Point(57, 111);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(700, 250);
            this.panelDetail.TabIndex = 7;
            // 
            // lblDetailFasilitas
            // 
            this.lblDetailFasilitas.AutoSize = true;
            this.lblDetailFasilitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailFasilitas.Location = new System.Drawing.Point(19, 175);
            this.lblDetailFasilitas.Name = "lblDetailFasilitas";
            this.lblDetailFasilitas.Size = new System.Drawing.Size(13, 18);
            this.lblDetailFasilitas.TabIndex = 6;
            this.lblDetailFasilitas.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fasilitas";
            // 
            // lblDetailTipe
            // 
            this.lblDetailTipe.AutoSize = true;
            this.lblDetailTipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailTipe.Location = new System.Drawing.Point(19, 119);
            this.lblDetailTipe.Name = "lblDetailTipe";
            this.lblDetailTipe.Size = new System.Drawing.Size(13, 18);
            this.lblDetailTipe.TabIndex = 4;
            this.lblDetailTipe.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tipe Kamar";
            // 
            // lblDetailHarga
            // 
            this.lblDetailHarga.AutoSize = true;
            this.lblDetailHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailHarga.Location = new System.Drawing.Point(19, 64);
            this.lblDetailHarga.Name = "lblDetailHarga";
            this.lblDetailHarga.Size = new System.Drawing.Size(13, 18);
            this.lblDetailHarga.TabIndex = 2;
            this.lblDetailHarga.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Harga per Bulan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Detail Kamar";
            // 
            // FrmUserPesan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.btnPesan);
            this.Controls.Add(this.datePickerMulaiSewa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboNomorKamar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUserPesan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu User : Pesan Kamar";
            this.Load += new System.EventHandler(this.FrmUserPesan_Load);
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboNomorKamar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePickerMulaiSewa;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDetailHarga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDetailTipe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDetailFasilitas;
    }
}