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
    public partial class frmMain: Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmUserKamar().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmUserPesan().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmUserPesan().ShowDialog();
        }
    }
}
