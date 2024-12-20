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

namespace GUI.MonHoc
{
    public partial class FR_Project_Managment : Form
    {
        public FR_Project_Managment()
        {
            InitializeComponent();
        }

        private void FR_QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            DataTable dt = MonHoc_BLL.load_dsMonHoc();
            dgv_MonHoc.DataSource = dt;
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
            nud_SoTiet.ResetText();
            nud_SoDauDiemKT.ResetText();
            nud_SoTinChi.ResetText();

            txt_MaMH.Enabled = false;
            txt_TenMH.Enabled = false;
            nud_SoDauDiemKT.Enabled = false;
            nud_SoTiet.Enabled = false;
            nud_SoTinChi.Enabled = false;
        }

        private void dgv_MonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_MaMH.Text        = dgv_MonHoc.Rows[i].Cells[0].Value.ToString();
            txt_TenMH.Text       = dgv_MonHoc.Rows[i].Cells[1].Value.ToString();
            nud_SoTiet.Text = dgv_MonHoc.Rows[i].Cells[2].Value.ToString();
            nud_SoDauDiemKT.Text = dgv_MonHoc.Rows[i].Cells[3].Value.ToString();
            nud_SoTinChi.Text = dgv_MonHoc.Rows[i].Cells[4].Value.ToString();
        }
        int d;


        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            d = 0;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            txt_MaMH.Enabled = false;
            btn_Xoa.Enabled = false;
            DataTable dt = MonHoc_BLL.tang_MaMonHoc();
            string tang_mamh = dt.Rows[0]["column1"].ToString();
            int tang_mamh_Int = int.Parse(tang_mamh);
            if (tang_mamh_Int < 10)
            {
                txt_MaMH.Text = "MH0" + tang_mamh_Int;
            }
            else
            {
                txt_MaMH.Text = "MH" + tang_mamh_Int;
            }
            txt_TenMH.Focus();
            txt_TenMH.Clear();
            nud_SoTiet.ResetText();
            nud_SoDauDiemKT.ResetText();
            nud_SoTinChi.ResetText();

            txt_TenMH.Enabled = true;
            nud_SoDauDiemKT.Enabled = true;
            nud_SoTiet.Enabled = true;
            nud_SoTinChi.Enabled = true;
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            d = 1;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            txt_MaMH.Enabled = false;
            btn_Xoa.Enabled = false;
            nud_SoTiet.ResetText();
            nud_SoDauDiemKT.ResetText();
            nud_SoTinChi.ResetText();

            txt_TenMH.Enabled = true;
            nud_SoDauDiemKT.Enabled = true;
            nud_SoTiet.Enabled = true;
            nud_SoTinChi.Enabled = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MonHoc_BLL.Update_MH_Bang_Diem(txt_MaMH.Text);
            MonHoc_BLL.Update_MH_Bang_PhanCong(txt_MaMH.Text);
            MonHoc_BLL.xoa_MonHoc(txt_MaMH.Text);
            dgv_MonHoc.DataSource = MonHoc_BLL.load_dsMonHoc();
            txt_MaMH.Clear();
            txt_TenMH.Clear();
            nud_SoTiet.ResetText();
            nud_SoDauDiemKT.ResetText();
            nud_SoTinChi.ResetText();

            txt_MaMH.Focus();
        }

        private void btn_Luu_Click_1(object sender, EventArgs e)
        {
            if(txt_MaMH.Text==""||txt_TenMH.Text==""|| nud_SoTiet.Text=="" ||nud_SoDauDiemKT.Text==""||nud_SoTinChi.Text=="")
            {
                MessageBox.Show("Bạn hãy nhập đủ các trường đi");
            }   
            else
            {
                if (d == 0)
                {
                    DataTable dt = MonHoc_BLL.Timkiem_MaMH(txt_MaMH.Text);
                    if (dt.Rows.Count > 0) MessageBox.Show("Trùng mã môn kìa bạn hãy nhập mã môn khác đi");
                    else
                    {
                        MonHoc_DTO mh = new MonHoc_DTO((txt_MaMH.Text), (txt_TenMH.Text), (nud_SoTiet.Text), (nud_SoDauDiemKT.Text), (nud_SoTinChi.Text));
                        MonHoc_BLL.them_MonHoc(mh);
                        dgv_MonHoc.DataSource = MonHoc_BLL.load_dsMonHoc();
                    }
                }
                else
                {
                    MonHoc_DTO mh = new MonHoc_DTO((txt_MaMH.Text), (txt_TenMH.Text), (nud_SoTiet.Text), (nud_SoDauDiemKT.Text), (nud_SoTinChi.Text));
                    MonHoc_BLL.sua_MonHoc(mh);
                    dgv_MonHoc.DataSource = MonHoc_BLL.load_dsMonHoc();
                }
                btn_Them.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Luu.Enabled = false;
                btn_Xoa.Enabled = true;
                btn_Huy.Enabled = false;

                txt_TenMH.Enabled = false;
                nud_SoDauDiemKT.Enabled = false;
                nud_SoTiet.Enabled = false;
                nud_SoTinChi.Enabled = false;
            }    
        }

        private void btn_Huy_Click_1(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = false;
            btn_Xoa.Enabled = true;
            txt_MaMH.Clear();
            txt_TenMH.Clear();
            btn_Huy.Enabled = false;
            txt_MaMH.Focus();

            nud_SoTiet.ResetText();
            nud_SoDauDiemKT.ResetText();
            nud_SoTinChi.ResetText();
            txt_TenMH.Enabled = false;
            nud_SoDauDiemKT.Enabled = false;
            nud_SoTiet.Enabled = false;
            nud_SoTinChi.Enabled = false;
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgv_MonHoc_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgv_MonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
