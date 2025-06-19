namespace KOS_BU_IPUNG_PBO
{
    partial class FormTambahKamar
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
            this.dataGridKamarTambah = new System.Windows.Forms.DataGridView();
            this.labelNomorKamar = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.InputNomorKamar = new System.Windows.Forms.TextBox();
            this.labelHargaKamar = new System.Windows.Forms.Label();
            this.InputHargaKamar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTipeKamar = new System.Windows.Forms.Label();
            this.txtTipeKamar = new System.Windows.Forms.TextBox();
            this.labelFasilitas = new System.Windows.Forms.Label();
            this.txtFasilitas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKamarTambah)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridKamarTambah
            // 
            this.dataGridKamarTambah.AllowUserToAddRows = false;
            this.dataGridKamarTambah.AllowUserToDeleteRows = false;
            this.dataGridKamarTambah.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridKamarTambah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKamarTambah.Location = new System.Drawing.Point(18, 18);
            this.dataGridKamarTambah.Name = "dataGridKamarTambah";
            this.dataGridKamarTambah.ReadOnly = true;
            this.dataGridKamarTambah.RowTemplate.Height = 24;
            this.dataGridKamarTambah.Size = new System.Drawing.Size(764, 238);
            this.dataGridKamarTambah.TabIndex = 10;
            // 
            // labelNomorKamar
            // 
            this.labelNomorKamar.AutoSize = true;
            this.labelNomorKamar.Location = new System.Drawing.Point(15, 270);
            this.labelNomorKamar.Name = "labelNomorKamar";
            this.labelNomorKamar.Size = new System.Drawing.Size(89, 16);
            this.labelNomorKamar.TabIndex = 0;
            this.labelNomorKamar.Text = "Nomor Kamar";
            // 
            // InputNomorKamar
            // 
            this.InputNomorKamar.Location = new System.Drawing.Point(18, 289);
            this.InputNomorKamar.Name = "InputNomorKamar";
            this.InputNomorKamar.Size = new System.Drawing.Size(243, 22);
            this.InputNomorKamar.TabIndex = 1;
            // 
            // labelHargaKamar
            // 
            this.labelHargaKamar.AutoSize = true;
            this.labelHargaKamar.Location = new System.Drawing.Point(297, 270);
            this.labelHargaKamar.Name = "labelHargaKamar";
            this.labelHargaKamar.Size = new System.Drawing.Size(88, 16);
            this.labelHargaKamar.TabIndex = 2;
            this.labelHargaKamar.Text = "Harga Kamar";
            // 
            // InputHargaKamar
            // 
            this.InputHargaKamar.Location = new System.Drawing.Point(300, 289);
            this.InputHargaKamar.Name = "InputHargaKamar";
            this.InputHargaKamar.Size = new System.Drawing.Size(243, 22);
            this.InputHargaKamar.TabIndex = 3;
            // 
            // labelTipeKamar
            // 
            this.labelTipeKamar.AutoSize = true;
            this.labelTipeKamar.Location = new System.Drawing.Point(15, 324);
            this.labelTipeKamar.Name = "labelTipeKamar";
            this.labelTipeKamar.Size = new System.Drawing.Size(77, 16);
            this.labelTipeKamar.TabIndex = 4;
            this.labelTipeKamar.Text = "Tipe Kamar";
            // 
            // txtTipeKamar
            // 
            this.txtTipeKamar.Location = new System.Drawing.Point(18, 343);
            this.txtTipeKamar.Name = "txtTipeKamar";
            this.txtTipeKamar.Size = new System.Drawing.Size(243, 22);
            this.txtTipeKamar.TabIndex = 5;
            // 
            // labelFasilitas
            // 
            this.labelFasilitas.AutoSize = true;
            this.labelFasilitas.Location = new System.Drawing.Point(297, 324);
            this.labelFasilitas.Name = "labelFasilitas";
            this.labelFasilitas.Size = new System.Drawing.Size(58, 16);
            this.labelFasilitas.TabIndex = 6;
            this.labelFasilitas.Text = "Fasilitas";
            // 
            // txtFasilitas
            // 
            this.txtFasilitas.Location = new System.Drawing.Point(300, 343);
            this.txtFasilitas.Name = "txtFasilitas";
            this.txtFasilitas.Size = new System.Drawing.Size(243, 22);
            this.txtFasilitas.TabIndex = 7;
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(18, 388);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(243, 35);
            this.buttonTambah.TabIndex = 8;
            this.buttonTambah.Text = "TAMBAH KAMAR";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTambahKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.txtFasilitas);
            this.Controls.Add(this.labelFasilitas);
            this.Controls.Add(this.txtTipeKamar);
            this.Controls.Add(this.labelTipeKamar);
            this.Controls.Add(this.InputHargaKamar);
            this.Controls.Add(this.labelHargaKamar);
            this.Controls.Add(this.InputNomorKamar);
            this.Controls.Add(this.labelNomorKamar);
            this.Controls.Add(this.dataGridKamarTambah);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTambahKamar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin: Tambah Kamar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKamarTambah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.DataGridView dataGridKamarTambah;
        private System.Windows.Forms.Label labelNomorKamar;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.TextBox InputNomorKamar;
        private System.Windows.Forms.Label labelHargaKamar;
        private System.Windows.Forms.TextBox InputHargaKamar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTipeKamar;
        private System.Windows.Forms.TextBox txtTipeKamar;
        private System.Windows.Forms.Label labelFasilitas;
        private System.Windows.Forms.TextBox txtFasilitas;
    }
}