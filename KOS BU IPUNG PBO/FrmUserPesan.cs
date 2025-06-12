using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FrmUserPesan : Form
    {
        public FrmUserPesan()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }
    }
}
