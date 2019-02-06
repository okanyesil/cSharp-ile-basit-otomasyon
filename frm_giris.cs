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

namespace veriTabani
{
    public partial class frm_giris : Form
    {
        public frm_giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B0GOLQN\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void frm_giris_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_yönetici where kullaniciAdi=@p1 and sifre=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1", txt_kullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txt_sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frm_ana ana = new frm_ana();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı giriş yaptınız..");
            }
            baglanti.Close();
        }

       
    }
}
