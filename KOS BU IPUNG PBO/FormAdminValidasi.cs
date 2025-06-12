using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FormAdminValidasi: Form
    {
        public FormAdminValidasi()
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
