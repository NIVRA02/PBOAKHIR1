namespace KOS_BU_IPUNG_PBO
{
    partial class FormTambahKamar
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
            this.dataGridKamarTambah = new System.Windows.Forms.DataGridView();
            this.labelNomorKamar = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.InputNomorKamar = new System.Windows.Forms.TextBox();
            this.labelHargaKamar = new System.Windows.Forms.Label();
            this.InputHargaKamar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKamarTambah)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridKamarTambah
            // 
            this.dataGridKamarTambah.AllowUserToDeleteRows = false;
            this.dataGridKamarTambah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKamarTambah.Location = new System.Drawing.Point(16, 41);
            this.dataGridKamarTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridKamarTambah.Name = "dataGridKamarTambah";
            this.dataGridKamarTambah.RowHeadersWidth = 62;
            this.dataGridKamarTambah.RowTemplate.Height = 28;
            this.dataGridKamarTambah.Size = new System.Drawing.Size(581, 190);
            this.dataGridKamarTambah.TabIndex = 4;
            this.dataGridKamarTambah.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelNomorKamar
            // 
            this.labelNomorKamar.AutoSize = true;
            this.labelNomorKamar.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomorKamar.Location = new System.Drawing.Point(12, 247);
            this.labelNomorKamar.Name = "labelNomorKamar";
            this.labelNomorKamar.Size = new System.Drawing.Size(135, 20);
            this.labelNomorKamar.TabIndex = 3;
            this.labelNomorKamar.Text = "Nomor Kamar";
            this.labelNomorKamar.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTambah.FlatAppearance.BorderSize = 0;
            this.buttonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(16, 333);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(216, 35);
            this.buttonTambah.TabIndex = 22;
            this.buttonTambah.Text = "TAMBAH KAMAR";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // InputNomorKamar
            // 
            this.InputNomorKamar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.InputNomorKamar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputNomorKamar.Location = new System.Drawing.Point(12, 270);
            this.InputNomorKamar.Multiline = true;
            this.InputNomorKamar.Name = "InputNomorKamar";
            this.InputNomorKamar.Size = new System.Drawing.Size(216, 28);
            this.InputNomorKamar.TabIndex = 23;
            this.InputNomorKamar.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // labelHargaKamar
            // 
            this.labelHargaKamar.AutoSize = true;
            this.labelHargaKamar.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaKamar.Location = new System.Drawing.Point(263, 247);
            this.labelHargaKamar.Name = "labelHargaKamar";
            this.labelHargaKamar.Size = new System.Drawing.Size(129, 20);
            this.labelHargaKamar.TabIndex = 3;
            this.labelHargaKamar.Text = "Harga Kamar";
            // 
            // InputHargaKamar
            // 
            this.InputHargaKamar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.InputHargaKamar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputHargaKamar.Location = new System.Drawing.Point(267, 270);
            this.InputHargaKamar.Multiline = true;
            this.InputHargaKamar.Name = "InputHargaKamar";
            this.InputHargaKamar.Size = new System.Drawing.Size(216, 28);
            this.InputHargaKamar.TabIndex = 23;
            this.InputHargaKamar.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "BACK\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTambahKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputHargaKamar);
            this.Controls.Add(this.InputNomorKamar);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridKamarTambah);
            this.Controls.Add(this.labelHargaKamar);
            this.Controls.Add(this.labelNomorKamar);
            this.Name = "FormTambahKamar";
            this.Text = "FormTambahKamar";
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
    }
}