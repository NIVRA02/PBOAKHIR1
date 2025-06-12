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
    public partial class FormAdminKelola: Form
    {
        public FormAdminKelola()
        {
            InitializeComponent();
        }

        private void FormAdminKelola_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdmin frmAdmin = new FormAdmin();
            frmAdmin.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTambahKamar frmTambahKamar = new FormTambahKamar();
            frmTambahKamar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEditKamar frmEditKamar = new FormEditKamar();
            frmEditKamar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormHapusKamar frmHapusKamar = new FormHapusKamar();
            frmHapusKamar.Show();
            this.Hide();
        }

        private void FormAdminKelola_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }
    }
}
