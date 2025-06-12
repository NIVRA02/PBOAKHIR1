namespace KOS_BU_IPUNG_PBO
{
    partial class FormEditKamar
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
            this.button1 = new System.Windows.Forms.Button();
            this.InputNomorLama = new System.Windows.Forms.TextBox();
            this.buttonEditKamar = new System.Windows.Forms.Button();
            this.dataGridEditKamar = new System.Windows.Forms.DataGridView();
            this.labelNomorLama = new System.Windows.Forms.Label();
            this.labelHargaLama = new System.Windows.Forms.Label();
            this.InputHargaLama = new System.Windows.Forms.TextBox();
            this.labelNomorBaru = new System.Windows.Forms.Label();
            this.InputNomorBaru = new System.Windows.Forms.TextBox();
            this.labelHargaBaru = new System.Windows.Forms.Label();
            this.InputHargaBaru = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEditKamar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(14, 504);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 44);
            this.button1.TabIndex = 34;
            this.button1.Text = "BACK\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputNomorLama
            // 
            this.InputNomorLama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.InputNomorLama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputNomorLama.Location = new System.Drawing.Point(9, 300);
            this.InputNomorLama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputNomorLama.Multiline = true;
            this.InputNomorLama.Name = "InputNomorLama";
            this.InputNomorLama.Size = new System.Drawing.Size(243, 35);
            this.InputNomorLama.TabIndex = 33;
            this.InputNomorLama.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // buttonEditKamar
            // 
            this.buttonEditKamar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonEditKamar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditKamar.FlatAppearance.BorderSize = 0;
            this.buttonEditKamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditKamar.ForeColor = System.Drawing.Color.White;
            this.buttonEditKamar.Location = new System.Drawing.Point(14, 438);
            this.buttonEditKamar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditKamar.Name = "buttonEditKamar";
            this.buttonEditKamar.Size = new System.Drawing.Size(243, 44);
            this.buttonEditKamar.TabIndex = 32;
            this.buttonEditKamar.Text = "EDIT KAMAR";
            this.buttonEditKamar.UseVisualStyleBackColor = false;
            this.buttonEditKamar.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridEditKamar
            // 
            this.dataGridEditKamar.AllowUserToDeleteRows = false;
            this.dataGridEditKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEditKamar.Location = new System.Drawing.Point(14, 14);
            this.dataGridEditKamar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridEditKamar.Name = "dataGridEditKamar";
            this.dataGridEditKamar.RowHeadersWidth = 62;
            this.dataGridEditKamar.RowTemplate.Height = 28;
            this.dataGridEditKamar.Size = new System.Drawing.Size(654, 238);
            this.dataGridEditKamar.TabIndex = 31;
            this.dataGridEditKamar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelNomorLama
            // 
            this.labelNomorLama.AutoSize = true;
            this.labelNomorLama.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomorLama.Location = new System.Drawing.Point(9, 271);
            this.labelNomorLama.Name = "labelNomorLama";
            this.labelNomorLama.Size = new System.Drawing.Size(155, 24);
            this.labelNomorLama.TabIndex = 30;
            this.labelNomorLama.Text = "Nomor Kamar";
            this.labelNomorLama.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelHargaLama
            // 
            this.labelHargaLama.AutoSize = true;
            this.labelHargaLama.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaLama.Location = new System.Drawing.Point(9, 352);
            this.labelHargaLama.Name = "labelHargaLama";
            this.labelHargaLama.Size = new System.Drawing.Size(146, 24);
            this.labelHargaLama.TabIndex = 30;
            this.labelHargaLama.Text = "Harga Kamar";
            // 
            // InputHargaLama
            // 
            this.InputHargaLama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.InputHargaLama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputHargaLama.Location = new System.Drawing.Point(9, 381);
            this.InputHargaLama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputHargaLama.Multiline = true;
            this.InputHargaLama.Name = "InputHargaLama";
            this.InputHargaLama.Size = new System.Drawing.Size(243, 35);
            this.InputHargaLama.TabIndex = 33;
            this.InputHargaLama.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // labelNomorBaru
            // 
            this.labelNomorBaru.AutoSize = true;
            this.labelNomorBaru.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomorBaru.Location = new System.Drawing.Point(334, 271);
            this.labelNomorBaru.Name = "labelNomorBaru";
            this.labelNomorBaru.Size = new System.Drawing.Size(213, 24);
            this.labelNomorBaru.TabIndex = 30;
            this.labelNomorBaru.Text = "Nomor Kamar Baru";
            this.labelNomorBaru.Click += new System.EventHandler(this.label1_Click);
            // 
            // InputNomorBaru
            // 
            this.InputNomorBaru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.InputNomorBaru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputNomorBaru.Location = new System.Drawing.Point(339, 300);
            this.InputNomorBaru.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputNomorBaru.Multiline = true;
            this.InputNomorBaru.Name = "InputNomorBaru";
            this.InputNomorBaru.Size = new System.Drawing.Size(243, 35);
            this.InputNomorBaru.TabIndex = 33;
            this.InputNomorBaru.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // labelHargaBaru
            // 
            this.labelHargaBaru.AutoSize = true;
            this.labelHargaBaru.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaBaru.Location = new System.Drawing.Point(339, 352);
            this.labelHargaBaru.Name = "labelHargaBaru";
            this.labelHargaBaru.Size = new System.Drawing.Size(204, 24);
            this.labelHargaBaru.TabIndex = 30;
            this.labelHargaBaru.Text = "Harga Kamar Baru";
            // 
            // InputHargaBaru
            // 
            this.InputHargaBaru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.InputHargaBaru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputHargaBaru.Location = new System.Drawing.Point(339, 381);
            this.InputHargaBaru.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputHargaBaru.Multiline = true;
            this.InputHargaBaru.Name = "InputHargaBaru";
            this.InputHargaBaru.Size = new System.Drawing.Size(243, 35);
            this.InputHargaBaru.TabIndex = 33;
            this.InputHargaBaru.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // FormEditKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputHargaBaru);
            this.Controls.Add(this.InputHargaLama);
            this.Controls.Add(this.InputNomorBaru);
            this.Controls.Add(this.InputNomorLama);
            this.Controls.Add(this.buttonEditKamar);
            this.Controls.Add(this.labelHargaBaru);
            this.Controls.Add(this.dataGridEditKamar);
            this.Controls.Add(this.labelHargaLama);
            this.Controls.Add(this.labelNomorBaru);
            this.Controls.Add(this.labelNomorLama);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEditKamar";
            this.Text = "FormEditKamar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEditKamar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox InputNomorLama;
        private System.Windows.Forms.Button buttonEditKamar;
        private System.Windows.Forms.DataGridView dataGridEditKamar;
        private System.Windows.Forms.Label labelNomorLama;
        private System.Windows.Forms.Label labelHargaLama;
        private System.Windows.Forms.TextBox InputHargaLama;
        private System.Windows.Forms.Label labelNomorBaru;
        private System.Windows.Forms.TextBox InputNomorBaru;
        private System.Windows.Forms.Label labelHargaBaru;
        private System.Windows.Forms.TextBox InputHargaBaru;
    }
}