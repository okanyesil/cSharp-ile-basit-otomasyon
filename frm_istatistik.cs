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
    public partial class frm_istatistik : Form
    {
        public frm_istatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B0GOLQN\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void frm_istatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand k1 = new SqlCommand("select count(*)  from tbl_personel",baglanti);
            SqlCommand k2 = new SqlCommand("select count(*) from tbl_personel where PerDurum=1",baglanti);
            SqlDataReader dr1 = k1.ExecuteReader();
            while (dr1.Read())
            {
                //toplam personel sayısı
                lbl_toplamPerSayisi.Text = dr1[0].ToString();

            }
            dr1.Close();
            SqlDataReader dr2 = k2.ExecuteReader();
            while (dr2.Read())
            {
                //evli personel sayısı
                lbl_evliPerSayisi.Text = dr2[0].ToString();
            }
            dr2.Close();
            SqlCommand k3 = new SqlCommand("select count(*) from tbl_personel where PerDurum=0",baglanti);
            SqlDataReader dr3 = k3.ExecuteReader();
            while(dr3.Read()){
                //bekar personel sayısı
                lbl_bekarPerSayisi.Text = dr3[0].ToString();
            }
            dr3.Close();
            SqlCommand k4 = new SqlCommand("select count(distinct(PerSehir)) from tbl_personel",baglanti);
            SqlDataReader dr4 = k4.ExecuteReader();
            while(dr4.Read()){
                //toplam şehir sayısı
                lbl_sehirSayisi.Text = dr4[0].ToString();
            }
            dr4.Close();
            //Personele ödenen toplam ücret
            SqlCommand k5 = new SqlCommand("select sum(PerMaas) from tbl_personel",baglanti);
            SqlDataReader dr5=k5.ExecuteReader();
            while(dr5.Read()){

                lbl_toplamMaas.Text = dr5[0].ToString();
            }
            dr5.Close();
            //personelin ortalama maaşı
            SqlCommand k6 = new SqlCommand("select avg(PerMaas) from tbl_personel",baglanti);
            SqlDataReader dr6 = k6.ExecuteReader();
            while (dr6.Read())
            {
                lbl_ortalamaMaas.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }
    }
}
