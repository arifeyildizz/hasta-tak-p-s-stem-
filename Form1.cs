using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastatakipsistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        frmSqlBağlantı bgl = new frmSqlBağlantı();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            frmkayit fr = new frmkayit();
            fr.Show();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKulAdi.Text != "" && txtSifre.Text != "")
            {
                SqlCommand giris = new SqlCommand("girisYap",bgl.baglan());
                giris.CommandType = CommandType.StoredProcedure;
                giris.Parameters.AddWithValue("kulAdi", txtKulAdi.Text);
                giris.Parameters.AddWithValue("sifre", txtSifre.Text);
                SqlDataReader dr = giris.ExecuteReader();
                if(dr.Read())
                {
                    MessageBox.Show("giriş işlemi başarılı", "giriş işlemi başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmAnaSayfa fr = new frmAnaSayfa();
                    this.Hide();
                    fr.Show();
                   

                }
                else
                {
                    MessageBox.Show("giriş işlemi başarısız", "giriş işlemi başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {

            
                    MessageBox.Show("Lütfen tüm alanları doldurunuz", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            
        }
    }
}
