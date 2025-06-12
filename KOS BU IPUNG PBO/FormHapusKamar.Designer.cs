namespace KOS_BU_IPUNG_PBO
{
    partial class FormHapusKamar
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
            this.InputNomorHapus = new System.Windows.Forms.TextBox();
            this.buttonHapusKamar = new System.Windows.Forms.Button();
            this.dataGridHapusKamar = new System.Windows.Forms.DataGridView();
            this.labelNomor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHapusKamar)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(26, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 35);
            this.button1.TabIndex = 29;
            this.button1.Text = "BACK\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputNomorHapus
            // 
            this.InputNomorHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.InputNomorHapus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputNomorHapus.Location = new System.Drawing.Point(22, 240);
            this.InputNomorHapus.Multiline = true;
            this.InputNomorHapus.Name = "InputNomorHapus";
            this.InputNomorHapus.Size = new System.Drawing.Size(216, 28);
            this.InputNomorHapus.TabIndex = 28;
            this.InputNomorHapus.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // buttonHapusKamar
            // 
            this.buttonHapusKamar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonHapusKamar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHapusKamar.FlatAppearance.BorderSize = 0;
            this.buttonHapusKamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHapusKamar.ForeColor = System.Drawing.Color.White;
            this.buttonHapusKamar.Location = new System.Drawing.Point(26, 303);
            this.buttonHapusKamar.Name = "buttonHapusKamar";
            this.buttonHapusKamar.Size = new System.Drawing.Size(216, 35);
            this.buttonHapusKamar.TabIndex = 27;
            this.buttonHapusKamar.Text = "HAPUS KAMAR";
            this.buttonHapusKamar.UseVisualStyleBackColor = false;
            this.buttonHapusKamar.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridHapusKamar
            // 
            this.dataGridHapusKamar.AllowUserToDeleteRows = false;
            this.dataGridHapusKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHapusKamar.Location = new System.Drawing.Point(26, 11);
            this.dataGridHapusKamar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridHapusKamar.Name = "dataGridHapusKamar";
            this.dataGridHapusKamar.RowHeadersWidth = 62;
            this.dataGridHapusKamar.RowTemplate.Height = 28;
            this.dataGridHapusKamar.Size = new System.Drawing.Size(581, 190);
            this.dataGridHapusKamar.TabIndex = 26;
            this.dataGridHapusKamar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelNomor
            // 
            this.labelNomor.AutoSize = true;
            this.labelNomor.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomor.Location = new System.Drawing.Point(22, 217);
            this.labelNomor.Name = "labelNomor";
            this.labelNomor.Size = new System.Drawing.Size(135, 20);
            this.labelNomor.TabIndex = 25;
            this.labelNomor.Text = "Nomor Kamar";
            this.labelNomor.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormHapusKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputNomorHapus);
            this.Controls.Add(this.buttonHapusKamar);
            this.Controls.Add(this.dataGridHapusKamar);
            this.Controls.Add(this.labelNomor);
            this.Name = "FormHapusKamar";
            this.Text = "FormHapusKamar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHapusKamar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox InputNomorHapus;
        private System.Windows.Forms.Button buttonHapusKamar;
        private System.Windows.Forms.DataGridView dataGridHapusKamar;
        private System.Windows.Forms.Label labelNomor;
    }
}