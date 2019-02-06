namespace veriTabani
{
    partial class frm_raporla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PersonelVeriTabaniDataSet = new veriTabani.PersonelVeriTabaniDataSet();
            this.tbl_personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_personelTableAdapter = new veriTabani.PersonelVeriTabaniDataSetTableAdapters.tbl_personelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_personelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_personelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "veriTabani.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1280, 667);
            this.reportViewer1.TabIndex = 0;
            // 
            // PersonelVeriTabaniDataSet
            // 
            this.PersonelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.PersonelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_personelBindingSource
            // 
            this.tbl_personelBindingSource.DataMember = "tbl_personel";
            this.tbl_personelBindingSource.DataSource = this.PersonelVeriTabaniDataSet;
            // 
            // tbl_personelTableAdapter
            // 
            this.tbl_personelTableAdapter.ClearBeforeFill = true;
            // 
            // frm_raporla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 667);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_raporla";
            this.Text = "frm_raporla";
            this.Load += new System.EventHandler(this.frm_raporla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonelVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_personelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_personelBindingSource;
        private PersonelVeriTabaniDataSet PersonelVeriTabaniDataSet;
        private PersonelVeriTabaniDataSetTableAdapters.tbl_personelTableAdapter tbl_personelTableAdapter;
    }
}