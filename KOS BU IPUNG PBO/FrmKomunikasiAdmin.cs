using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FrmKomunikasiAdmin : Form
    {
        private int selectedPemesananId = 0;

        public FrmKomunikasiAdmin()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Generic_FormClosing);
        }

        private void FrmKomunikasiAdmin_Load(object sender, EventArgs e)
        {
            LoadConversationList();
        }

        private void LoadConversationList()
        {
            string query = @"
                SELECT DISTINCT 
                    p.id_pemesanan, 
                    p.username, 
                    k.nomor_kamar
                FROM komunikasi c
                JOIN pemesanan p ON c.id_pemesanan = p.id_pemesanan
                JOIN kamar k ON p.id_kamar = k.id_kamar
                ORDER BY p.username, k.nomor_kamar";

            DataTable dt = DatabaseHelper.ExecuteQuery(query, null);

            dt.Columns.Add("DisplayText", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                row["DisplayText"] = $"{row["username"]} - Kamar {row["nomor_kamar"]}";
            }

            listConversations.DataSource = dt;
            listConversations.DisplayMember = "DisplayText"; 
            listConversations.ValueMember = "id_pemesanan";
            listConversations.ClearSelected();
            panelChat.Controls.Clear();
            lblDetailPercakapan.Text = "Pilih percakapan di samping";
            btnKirim.Enabled = false;
        }

        private void listConversations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listConversations.SelectedValue != null && listConversations.SelectedValue is int)
            {
                selectedPemesananId = (int)listConversations.SelectedValue;
                lblDetailPercakapan.Text = $"Percakapan: {listConversations.Text}";
                btnKirim.Enabled = true;
                LoadMessagesForConversation(selectedPemesananId);
            }
        }

        private void LoadMessagesForConversation(int idPemesanan)
        {
            panelChat.Controls.Clear();

            string query = "SELECT nama_pengirim, isi_pesan, waktu_kirim FROM komunikasi WHERE id_pemesanan = @idPemesanan ORDER BY waktu_kirim ASC";
            SqlParameter[] parameters = { new SqlParameter("@idPemesanan", idPemesanan) };
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

            if (pengirim.ToLower() == "admin")
            {
                lblMessage.BackColor = Color.LightGreen;
            }
            else
            {
                lblMessage.BackColor = Color.White;
            }

            panelChat.Controls.Add(lblMessage);
            panelChat.SetFlowBreak(lblMessage, true);
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            string isiPesan = txtPesanBaru.Text.Trim();
            if (string.IsNullOrEmpty(isiPesan) || selectedPemesananId == 0) return;

            string query = "INSERT INTO komunikasi (id_pemesanan, id_pengirim, nama_pengirim, isi_pesan, waktu_kirim, sudah_dibaca) VALUES (@idPemesanan, @idPengirim, @namaPengirim, @isiPesan, GETDATE(), 0)";
            SqlParameter[] parameters = {
                new SqlParameter("@idPemesanan", this.selectedPemesananId),
                new SqlParameter("@idPengirim", 1),
                new SqlParameter("@namaPengirim", "admin"),
                new SqlParameter("@isiPesan", isiPesan)
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                txtPesanBaru.Clear();
                LoadMessagesForConversation(selectedPemesananId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengirim pesan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
        }

        private void Generic_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (Modal) return;

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}