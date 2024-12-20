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
    public partial class FR_DS_SV_LopChuNhiem : Form
    {
        private string taikhoan1;
        public FR_DS_SV_LopChuNhiem(string taiKhoan)
        {
            InitializeComponent();
            this.taikhoan1 = taiKhoan;
        }

        private void FR_ThongTinLopChuNhiem_Load(object sender, EventArgs e)
        {
            cmb_MaLop.DataSource = Lop_BLL.Timkiem_LopChuNhiem(taikhoan1);
            cmb_MaLop.ValueMember = "malop";
            this.reportViewer1.RefreshReport();
            cmb_MaLop.SelectedIndex = -1;
        }
        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {
            DataTable dt = SinhVien_BLL.Load_DS_SV_Theo_GV(cmb_MaLop.Text.Trim());
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.BaoCao.SinhVien.rdlc";

            if (dt.Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "SinhVien";
                rds.Value = dt;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.SetParameters(new ReportParameter("MaLop", cmb_MaLop.Text.Trim()));
                reportViewer1.RefreshReport();
            }
            this.reportViewer1.RefreshReport();
        }

    }
}
