using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FrmKomunikasiUser : Form
    {
        private int idPemesanan;

        public FrmKomunikasiUser(int idPemesanan)
        {
            InitializeComponent();
            this.idPemesanan = idPemesanan;
            this.FormClosing += new FormClosingEventHandler(Generic_FormClosing);
        }

        private void FrmKomunikasiUser_Load(object sender, EventArgs e)
        {
            LoadMessages();
        }

        private void LoadMessages()
        {
            panelChat.Controls.Clear();

            string query = "SELECT nama_pengirim, isi_pesan, waktu_kirim FROM komunikasi WHERE id_pemesanan = @idPemesanan ORDER BY waktu_kirim ASC";
            SqlParameter[] parameters = { new SqlParameter("@idPemesanan", this.idPemesanan) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                AddMessageToPanel(row["nama_pengirim"].ToString(), row["isi_pesan"].ToString(), (DateTime)row["waktu_kirim"]);
            }

            if (panelChat.Controls.Count > 0)
            {
                panelChat.ScrollControlIntoView(panelChat.Controls[panelChat.Controls.Count - 1]);
            }
        }

        private void AddMessageToPanel(string pengirim, string pesan, DateTime waktu)
        {
            Label lblMessage = new Label
            {
                Text = $"{pengirim} ({waktu:g}):\n{pesan}",
                AutoSize = true,
                MaximumSize = new Size(panelChat.Width - 40, 0),
                Padding = new Padding(10),
                Margin = new Padding(5, 5, 5, 10),
                Font = new Font("Microsoft Sans Serif", 9F)
            };

            if (pengirim == UserSession.Username)
            {
                lblMessage.BackColor = Color.CornflowerBlue;
                lblMessage.ForeColor = Color.White;
            }
            else
            {
                lblMessage.BackColor = Color.LightGray;
                lblMessage.ForeColor = Color.Black;
            }

            panelChat.Controls.Add(lblMessage);
            if (pengirim == UserSession.Username)
            {
                panelChat.SetFlowBreak(lblMessage, true); 
            }
            else
            {
                panelChat.SetFlowBreak(lblMessage, true);
            }
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            string isiPesan = txtPesanBaru.Text.Trim();
            if (string.IsNullOrEmpty(isiPesan)) return;

            string query = "INSERT INTO komunikasi (id_pemesanan, id_pengirim, nama_pengirim, isi_pesan, waktu_kirim, sudah_dibaca) VALUES (@idPemesanan, @idPengirim, @namaPengirim, @isiPesan, GETDATE(), 0)";
            SqlParameter[] parameters = {
                new SqlParameter("@idPemesanan", this.idPemesanan),
                new SqlParameter("@idPengirim", UserSession.Id),
                new SqlParameter("@namaPengirim", UserSession.Username),
                new SqlParameter("@isiPesan", isiPesan)
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                txtPesanBaru.Clear();
                LoadMessages();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengirim pesan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Generic_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && Modal)
            {
                e.Cancel = false;
            }
        }
    }
}