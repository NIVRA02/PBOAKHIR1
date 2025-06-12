namespace KOS_BU_IPUNG_PBO
{
    partial class FrmUserPesan
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
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboNomorKamar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datePickerMulaiSewa = new System.Windows.Forms.DateTimePicker();
            this.btnPesan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.backButton.Location = new System.Drawing.Point(274, 376);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(218, 44);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pilih Kamar Tersedia:";
            // 
            // comboNomorKamar
            // 
            this.comboNomorKamar.FormattingEnabled = true;
            this.comboNomorKamar.Location = new System.Drawing.Point(58, 96);
            this.comboNomorKamar.Name = "comboNomorKamar";
            this.comboNomorKamar.Size = new System.Drawing.Size(121, 28);
            this.comboNomorKamar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tanggal Mulai Sewa :";
            // 
            // datePickerMulaiSewa
            // 
            this.datePickerMulaiSewa.Location = new System.Drawing.Point(274, 98);
            this.datePickerMulaiSewa.Name = "datePickerMulaiSewa";
            this.datePickerMulaiSewa.Size = new System.Drawing.Size(296, 26);
            this.datePickerMulaiSewa.TabIndex = 5;
            // 
            // btnPesan
            // 
            this.btnPesan.Location = new System.Drawing.Point(146, 214);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(199, 43);
            this.btnPesan.TabIndex = 6;
            this.btnPesan.Text = "Pesan Sekarang";
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // FrmUserPesan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesan);
            this.Controls.Add(this.datePickerMulaiSewa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboNomorKamar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUserPesan";
            this.Text = "Menu User : Pesan Kamar";
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
    }
}