namespace KOS_BU_IPUNG_PBO
{
    partial class FrmKomunikasiUser
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelChat = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPesanBaru = new System.Windows.Forms.TextBox();
            this.btnKirim = new System.Windows.Forms.Button();
            this.lblJudul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelChat
            // 
            this.panelChat.AutoScroll = true;
            this.panelChat.BackColor = System.Drawing.Color.White;
            this.panelChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelChat.Location = new System.Drawing.Point(12, 45);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(560, 350);
            this.panelChat.TabIndex = 0;
            this.panelChat.WrapContents = false;
            // 
            // txtPesanBaru
            // 
            this.txtPesanBaru.Location = new System.Drawing.Point(12, 404);
            this.txtPesanBaru.Multiline = true;
            this.txtPesanBaru.Name = "txtPesanBaru";
            this.txtPesanBaru.Size = new System.Drawing.Size(465, 50);
            this.txtPesanBaru.TabIndex = 1;
            // 
            // btnKirim
            // 
            this.btnKirim.BackColor = System.Drawing.Color.SeaGreen;
            this.btnKirim.ForeColor = System.Drawing.Color.White;
            this.btnKirim.Location = new System.Drawing.Point(483, 404);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(89, 50);
            this.btnKirim.TabIndex = 2;
            this.btnKirim.Text = "KIRIM";
            this.btnKirim.UseVisualStyleBackColor = false;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(12, 9);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(248, 25);
            this.lblJudul.TabIndex = 3;
            this.lblJudul.Text = "Percakapan dengan Admin";
            // 
            // FrmKomunikasiUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 466);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.txtPesanBaru);
            this.Controls.Add(this.panelChat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmKomunikasiUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pusat Pesan";
            this.Load += new System.EventHandler(this.FrmKomunikasiUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.FlowLayoutPanel panelChat;
        private System.Windows.Forms.TextBox txtPesanBaru;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.Label lblJudul;
    }
}