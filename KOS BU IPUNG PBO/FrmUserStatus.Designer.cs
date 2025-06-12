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
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblHargaValue = new System.Windows.Forms.Label();
            this.lblTglPesanValue = new System.Windows.Forms.Label();
            this.lblNoKamarValue = new System.Windows.Forms.Label();
            this.lblNamaValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNotFound = new System.Windows.Forms.Panel();
            this.labelNotFound = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.pnlDetails.SuspendLayout();
            this.pnlNotFound.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.lblStatusValue);
            this.pnlDetails.Controls.Add(this.lblHargaValue);
            this.pnlDetails.Controls.Add(this.lblTglPesanValue);
            this.pnlDetails.Controls.Add(this.lblNoKamarValue);
            this.pnlDetails.Controls.Add(this.lblNamaValue);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.label4);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Location = new System.Drawing.Point(23, 80);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(400, 250);
            this.pnlDetails.TabIndex = 0;
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.Location = new System.Drawing.Point(180, 180);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(200, 17);
            this.lblStatusValue.TabIndex = 9;
            this.lblStatusValue.Text = "-";
            // 
            // lblHargaValue
            // 
            this.lblHargaValue.Location = new System.Drawing.Point(180, 140);
            this.lblHargaValue.Name = "lblHargaValue";
            this.lblHargaValue.Size = new System.Drawing.Size(200, 17);
            this.lblHargaValue.TabIndex = 8;
            this.lblHargaValue.Text = "-";
            // 
            // lblTglPesanValue
            // 
            this.lblTglPesanValue.Location = new System.Drawing.Point(180, 100);
            this.lblTglPesanValue.Name = "lblTglPesanValue";
            this.lblTglPesanValue.Size = new System.Drawing.Size(200, 17);
            this.lblTglPesanValue.TabIndex = 7;
            this.lblTglPesanValue.Text = "-";
            // 
            // lblNoKamarValue
            // 
            this.lblNoKamarValue.Location = new System.Drawing.Point(180, 60);
            this.lblNoKamarValue.Name = "lblNoKamarValue";
            this.lblNoKamarValue.Size = new System.Drawing.Size(200, 17);
            this.lblNoKamarValue.TabIndex = 6;
            this.lblNoKamarValue.Text = "-";
            // 
            // lblNamaValue
            // 
            this.lblNamaValue.Location = new System.Drawing.Point(180, 20);
            this.lblNamaValue.Name = "lblNamaValue";
            this.lblNamaValue.Size = new System.Drawing.Size(200, 17);
            this.lblNamaValue.TabIndex = 5;
            this.lblNamaValue.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status Pembayaran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga Kamar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Pemesanan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nomor Kamar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Pemesan";
            // 
            // pnlNotFound
            // 
            this.pnlNotFound.Controls.Add(this.labelNotFound);
            this.pnlNotFound.Location = new System.Drawing.Point(23, 83);
            this.pnlNotFound.Name = "pnlNotFound";
            this.pnlNotFound.Size = new System.Drawing.Size(400, 244);
            this.pnlNotFound.TabIndex = 1;
            this.pnlNotFound.Visible = false;
            // 
            // labelNotFound
            // 
            this.labelNotFound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNotFound.Location = new System.Drawing.Point(0, 0);
            this.labelNotFound.Name = "labelNotFound";
            this.labelNotFound.Size = new System.Drawing.Size(400, 244);
            this.labelNotFound.TabIndex = 0;
            this.labelNotFound.Text = "Anda belum memiliki data pemesanan.";
            this.labelNotFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(303, 350);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(120, 40);
            this.btnKembali.TabIndex = 2;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // FrmUserStatus
            // 
            this.ClientSize = new System.Drawing.Size(447, 403);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlNotFound);
            this.Name = "FrmUserStatus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUserStatus_FormClosing);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlNotFound.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNamaValue;
        private System.Windows.Forms.Label lblNoKamarValue;
        private System.Windows.Forms.Label lblTglPesanValue;
        private System.Windows.Forms.Label lblHargaValue;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Panel pnlNotFound;
        private System.Windows.Forms.Label labelNotFound;
        private System.Windows.Forms.Button btnKembali;
    }
}