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
            FrmAdmin1 frmAdmin1 = new FrmAdmin1();
            frmAdmin1.Show();
            this.Hide();
        }
    }
}
