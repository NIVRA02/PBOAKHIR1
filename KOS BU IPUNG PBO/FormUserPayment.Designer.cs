namespace KOS_BU_IPUNG_PBO
{
    partial class FrmUserPayment
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMetodePembayaran = new System.Windows.Forms.ComboBox();
            this.btnBayar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTotalPembayaran = new System.Windows.Forms.Label();
            this.txtJumlahBayar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPemesananPending = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPemesananPending)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(50, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metode Pembayaran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Metode Pembayaran:";
            // 
            // cmbMetodePembayaran
            // 
            this.cmbMetodePembayaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodePembayaran.FormattingEnabled = true;
            this.cmbMetodePembayaran.Items.AddRange(new object[] {
            "Transfer Bank",
            "Tunai",
            "E-Wallet"});
            this.cmbMetodePembayaran.Location = new System.Drawing.Point(57, 323);
            this.cmbMetodePembayaran.Name = "cmbMetodePembayaran";
            this.cmbMetodePembayaran.Size = new System.Drawing.Size(200, 28);
            this.cmbMetodePembayaran.TabIndex = 2;
            // 
            // btnBayar
            // 
            this.btnBayar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBayar.ForeColor = System.Drawing.Color.White;
            this.btnBayar.Location = new System.Drawing.Point(57, 430);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(200, 40);
            this.btnBayar.TabIndex = 3;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = false;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(57, 480);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Kembali";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTotalPembayaran
            // 
            this.lblTotalPembayaran.AutoSize = true;
            this.lblTotalPembayaran.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPembayaran.Location = new System.Drawing.Point(53, 370);
            this.lblTotalPembayaran.Name = "lblTotalPembayaran";
            this.lblTotalPembayaran.Size = new System.Drawing.Size(180, 24);
            this.lblTotalPembayaran.TabIndex = 5;
            this.lblTotalPembayaran.Text = "Total Pembayaran: Rp 0";
            // 
            // txtJumlahBayar
            // 
            this.txtJumlahBayar.Location = new System.Drawing.Point(300, 323);
            this.txtJumlahBayar.Name = "txtJumlahBayar";
            this.txtJumlahBayar.Size = new System.Drawing.Size(200, 26);
            this.txtJumlahBayar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Jumlah Bayar:";
            // 
            // dgvPemesananPending
            // 
            this.dgvPemesananPending.AllowUserToAddRows = false;
            this.dgvPemesananPending.AllowUserToDeleteRows = false;
            this.dgvPemesananPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPemesananPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPemesananPending.Location = new System.Drawing.Point(57, 75);
            this.dgvPemesananPending.Name = "dgvPemesananPending";
            this.dgvPemesananPending.ReadOnly = true;
            this.dgvPemesananPending.RowHeadersWidth = 62;
            this.dgvPemesananPending.RowTemplate.Height = 28;
            this.dgvPemesananPending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPemesananPending.Size = new System.Drawing.Size(680, 200);
            this.dgvPemesananPending.TabIndex = 8;
            this.dgvPemesananPending.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPemesananPending_CellClick);
            // 
            // FrmUserPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.dgvPemesananPending);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJumlahBayar);
            this.Controls.Add(this.lblTotalPembayaran);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.cmbMetodePembayaran);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUserPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metode Pembayaran";
            this.Load += new System.EventHandler(this.FrmUserPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPemesananPending)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMetodePembayaran;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTotalPembayaran;
        private System.Windows.Forms.TextBox txtJumlahBayar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPemesananPending;
    }
}