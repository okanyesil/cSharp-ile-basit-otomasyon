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
    public partial class frm_grafik : Form
    {
        public frm_grafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B0GOLQN\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void frm_grafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 =new  SqlCommand("select PerSehir,count(*) from tbl_personel group by PerSehir",baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read()){
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            dr1.Close();
            SqlCommand komut2 = new SqlCommand("select PerMeslek,avg(PerMaas) from tbl_personel group by PerMeslek",baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read()){
                chart2.Series["meslek-maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();
        }
    }
}
