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
    public partial class frm_ana : Form
    {
        public frm_ana()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-B0GOLQN\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        void temizle()
        {
            txt_ad.Text = "";
            txt_meslek.Text = "";
            txt_soyad.Text = "";
            cmb_sehir.Text = "";
            msk_maas.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txt_ad.Focus();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet.tbl_personel' table. You can move, or remove it, as needed.
            this.tbl_personelTableAdapter.Fill(this.personelVeriTabaniDataSet.tbl_personel);
           // label8.Visible = false;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@p3", cmb_sehir.Text);
            komut.Parameters.AddWithValue("@p4", msk_maas.Text);
            komut.Parameters.AddWithValue("@p5", txt_meslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt eklendi");
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            this.tbl_personelTableAdapter.Fill(this.personelVeriTabaniDataSet.tbl_personel);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (label8.Text == "true")
            {
                radioButton1.Checked = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (label8.Text == "false")
            {
                radioButton2.Checked = true;
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilan = dataGridView1.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView1.Rows[secilan].Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.Rows[secilan].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[secilan].Cells[2].Value.ToString();
            cmb_sehir.Text = dataGridView1.Rows[secilan].Cells[3].Value.ToString();
            msk_maas.Text = dataGridView1.Rows[secilan].Cells[4].Value.ToString();
            txt_meslek.Text = dataGridView1.Rows[secilan].Cells[6].Value.ToString();
            label8.Text = dataGridView1.Rows[secilan].Cells[5].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from tbl_personel where PerId=@k1",baglanti);
            sil.Parameters.AddWithValue("@k1",txt_id.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            txt_id.Text = "";
            MessageBox.Show("Kayıt silindi");
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update tbl_personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 where PerId=@a7",baglanti);
            guncelle.Parameters.AddWithValue("@a1", txt_ad.Text);
            guncelle.Parameters.AddWithValue("@a2", txt_soyad.Text);
            guncelle.Parameters.AddWithValue("@a3", cmb_sehir.Text);
            guncelle.Parameters.AddWithValue("@a4", msk_maas.Text);
            guncelle.Parameters.AddWithValue("@a5", label8.Text);
            guncelle.Parameters.AddWithValue("@a6", txt_meslek.Text);
            guncelle.Parameters.AddWithValue("@a7", txt_id.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt güncellendi");
        }

        private void btn_istatistik_Click(object sender, EventArgs e)
        {
            frm_istatistik fr=new frm_istatistik();
            fr.Show();
        }

        private void btn_grafikler_Click(object sender, EventArgs e)
        {
            frm_grafik frm = new frm_grafik();
            frm.Show();
        }

        private void Raporlar_Click(object sender, EventArgs e)
        {
            frm_raporla frmr = new frm_raporla();
            frmr.Show();
        }
    }
}
;