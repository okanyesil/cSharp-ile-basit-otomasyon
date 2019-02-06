using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriTabani
{
    public partial class frm_raporla : Form
    {
        public frm_raporla()
        {
            InitializeComponent();
        }

        private void frm_raporla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PersonelVeriTabaniDataSet.tbl_personel' table. You can move, or remove it, as needed.
            this.tbl_personelTableAdapter.Fill(this.PersonelVeriTabaniDataSet.tbl_personel);

            this.reportViewer1.RefreshReport();
        }
    }
}
