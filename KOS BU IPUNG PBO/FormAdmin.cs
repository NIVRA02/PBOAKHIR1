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
            FormStatistikKos h = new FormStatistikKos();
            h.Show();
            this.Hide();
        }
    }
}
