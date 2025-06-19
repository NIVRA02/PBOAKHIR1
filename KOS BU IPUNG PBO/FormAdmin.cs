using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FormAdmin: Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminKelola h = new FormAdminKelola();
            h.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdminLihatPenghuni h = new FormAdminLihatPenghuni();
            h.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAdminValidasi h = new FormAdminValidasi();
            h.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormStatistikKos formStatistikKos = new FormStatistikKos();
            formStatistikKos.Show();
            this.Hide();
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Terimakasih telah menggunakan aplikasi kos.", "Sampai Jumpa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Terimakasih telah menggunakan aplikasi kos.", "Sampai Jumpa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLogin lfrmlogin = new frmLogin();
                lfrmlogin.Show();
                this.Hide();
            }
            else
            {
                frmMain frmMain = new frmMain();
                frmMain.Show();
                this.Hide();

            }
        }
    }
}
