using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BLL;
using DTO;


namespace GUI.GiaoVien
{
    public partial class FR_BaoCaoGiaoVien : Form
    {
        public FR_BaoCaoGiaoVien()
        {
            InitializeComponent();
        }

        private void FR_BaoCaoGiaoVien_Load(object sender, EventArgs e)
        {
            DataTable dt = GiaoVien_BLL.load_DsGV();
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.BaoCao.GiaoVien.rdlc";

            if (dt.Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "GiaoVien";
                rds.Value = dt;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                //reportViewer1.LocalReport.SetParameters(new ReportParameter("MaMH", cmb_MaMH.Text));
                reportViewer1.RefreshReport();
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
