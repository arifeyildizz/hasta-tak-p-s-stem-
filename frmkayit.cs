using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace Hastatakipsistemi
{
    public partial class frmkayit : Form
    {
        public frmkayit()
        {
            InitializeComponent();
        }
        frmSqlBağlantı bgl = new frmSqlBağlantı();
        private void btnKayıt_Click(object sender, EventArgs e)
        {
            if(txtKulAdi.Text != "" && txtSifre.Text != "")
            {
                SqlCommand kayit = new SqlCommand("kayitOl",bgl.baglan());
                kayit.CommandType = CommandType.StoredProcedure;
                kayit.Parameters.AddWithValue("kulAdi", txtKulAdi.Text);
                kayit.Parameters.AddWithValue("sifre", txtSifre.Text);
                kayit.ExecuteNonQuery();
                MessageBox.Show("kayıt işlemi başarılı", "kayıt başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
