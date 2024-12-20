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


namespace GUI
{
    public partial class FR_XemDiemLopChuNhiem : Form
    {
        private string Taikhoan;
        public FR_XemDiemLopChuNhiem(string taikhoan)
        {
            InitializeComponent();
            this.Taikhoan = taikhoan;
        }

        private void FR_XemDiemSV_Load(object sender, EventArgs e)
        {
            cmb_MaMH.DataSource = Diem_BLL.Load_MaMH();
            cmb_MaMH.ValueMember = "mamh";
            cmb_MaMH.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaMH.SelectedIndex = -1;

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = Diem_BLL.load_ds_DiemSV_theo_magv_ChuNhiem(Taikhoan, cmb_MaMH.Text);
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.BaoCao.DiemSV.rdlc";

            if (dt.Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "Diem";
                rds.Value = dt;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.SetParameters(new ReportParameter("MaMH", cmb_MaMH.Text));
                reportViewer1.RefreshReport();
            }
            this.reportViewer1.RefreshReport();
        }

        private void btn_Load_DSSV_HL_GVCN_Click(object sender, EventArgs e)
        {
            DataTable dt = Diem_BLL.load_ds_DiemSV_theo_magv_ChuNhiem_HL(Taikhoan);
            this.reportViewer2.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer2.LocalReport.ReportEmbeddedResource = "GUI.BaoCao.DSSV_HL_GVCN.rdlc";

            if (dt.Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "Diem";
                rds.Value = dt;

                reportViewer2.LocalReport.DataSources.Clear();
                reportViewer2.LocalReport.DataSources.Add(rds);
                //reportViewer2.LocalReport.SetParameters(new ReportParameter("MaMH", cmb_MaMH.Text));
                reportViewer2.RefreshReport();
            }
            this.reportViewer2.RefreshReport();
        }

        private void btn_Load_DSSV_TL_GVCN_Click(object sender, EventArgs e)
        {
            DataTable dt = Diem_BLL.load_ds_DiemSV_theo_magv_ChuNhiem_TL(Taikhoan);
            this.reportViewer3.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer3.LocalReport.ReportEmbeddedResource = "GUI.BaoCao.DSSV_TL_GVCN.rdlc";

            if (dt.Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "Diem";
                rds.Value = dt;

                reportViewer3.LocalReport.DataSources.Clear();
                reportViewer3.LocalReport.DataSources.Add(rds);
                //reportViewer2.LocalReport.SetParameters(new ReportParameter("MaMH", cmb_MaMH.Text));
                reportViewer3.RefreshReport();
            }
            this.reportViewer3.RefreshReport();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
