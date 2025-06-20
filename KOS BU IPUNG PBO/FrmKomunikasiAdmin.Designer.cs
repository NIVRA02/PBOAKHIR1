namespace KOS_BU_IPUNG_PBO
{
    partial class FrmKomunikasiAdmin
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
            this.listConversations = new System.Windows.Forms.ListBox();
            this.panelChat = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPesanBaru = new System.Windows.Forms.TextBox();
            this.btnKirim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetailPercakapan = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listConversations
            // 
            this.listConversations.FormattingEnabled = true;
            this.listConversations.ItemHeight = 16;
            this.listConversations.Location = new System.Drawing.Point(12, 40);
            this.listConversations.Name = "listConversations";
            this.listConversations.Size = new System.Drawing.Size(220, 420);
            this.listConversations.TabIndex = 0;
            this.listConversations.SelectedIndexChanged += new System.EventHandler(this.listConversations_SelectedIndexChanged);
            // 
            // panelChat
            // 
            this.panelChat.AutoScroll = true;
            this.panelChat.BackColor = System.Drawing.Color.White;
            this.panelChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelChat.Location = new System.Drawing.Point(248, 40);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(540, 355);
            this.panelChat.TabIndex = 1;
            this.panelChat.WrapContents = false;
            // 
            // txtPesanBaru
            // 
            this.txtPesanBaru.Location = new System.Drawing.Point(248, 408);
            this.txtPesanBaru.Multiline = true;
            this.txtPesanBaru.Name = "txtPesanBaru";
            this.txtPesanBaru.Size = new System.Drawing.Size(445, 52);
            this.txtPesanBaru.TabIndex = 2;
            // 
            // btnKirim
            // 
            this.btnKirim.BackColor = System.Drawing.Color.SeaGreen;
            this.btnKirim.Enabled = false;
            this.btnKirim.ForeColor = System.Drawing.Color.White;
            this.btnKirim.Location = new System.Drawing.Point(699, 408);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(89, 52);
            this.btnKirim.TabIndex = 3;
            this.btnKirim.Text = "KIRIM";
            this.btnKirim.UseVisualStyleBackColor = false;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Daftar Percakapan";
            // 
            // lblDetailPercakapan
            // 
            this.lblDetailPercakapan.AutoSize = true;
            this.lblDetailPercakapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailPercakapan.Location = new System.Drawing.Point(244, 13);
            this.lblDetailPercakapan.Name = "lblDetailPercakapan";
            this.lblDetailPercakapan.Size = new System.Drawing.Size(186, 20);
            this.lblDetailPercakapan.TabIndex = 5;
            this.lblDetailPercakapan.Text = "Detail Percakapan...";
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(12, 470);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(100, 30);
            this.btnKembali.TabIndex = 6;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // FrmKomunikasiAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.lblDetailPercakapan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.txtPesanBaru);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.listConversations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmKomunikasiAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin: Pusat Pesan";
            this.Load += new System.EventHandler(this.FrmKomunikasiAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.ListBox listConversations;
        private System.Windows.Forms.FlowLayoutPanel panelChat;
        private System.Windows.Forms.TextBox txtPesanBaru;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDetailPercakapan;
        private System.Windows.Forms.Button btnKembali;
    }
}