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
    public partial class FormStatistikKos: Form
    {
        public FormStatistikKos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdmin frmAdmin1 = new FormAdmin();
            frmAdmin1.Show();
            this.Hide();
        }
    }
}
