using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using Microsoft.Reporting.WinForms;
using CrystalDecisions.CrystalReports.Engine;

namespace GUI
{
    public partial class FR_DanhSachPhanCong : Form
    {
        public FR_DanhSachPhanCong()
        {
            InitializeComponent();
        }

        private void FR_DanhSachPhanCong_Load(object sender, EventArgs e)
        {
            DataTable dt = PhanCong_BLL.load_DsPhanCong();
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.BaoCao.DS_PhanCong.rdlc";

            if (dt.Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "PhanCong";
                rds.Value = dt;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                //reportViewer1.LocalReport.SetParameters(new ReportParameter("MaLop", cmb_MaLop.Text.Trim()));
                reportViewer1.RefreshReport();
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
