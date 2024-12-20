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

namespace GUI.Khoa
{
    public partial class FR_QuanLyKhoa : Form
    {
        public FR_QuanLyKhoa()
        {
            InitializeComponent();
        }

        private void FR_QuanLy_Khoa_Load(object sender, EventArgs e)
        {
            DataTable dt = Khoa_BLL.load_dsKhoa();
            dgv_Khoa.DataSource = dt;
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;

            txt_MaKhoa.Enabled = false;
            txt_TenKhoa.Enabled = false;
        }
        int d;
        private void dgv_Khoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_MaKhoa.Text = dgv_Khoa.Rows[i].Cells[0].Value.ToString();
            txt_TenKhoa.Text = dgv_Khoa.Rows[i].Cells[1].Value.ToString();
        }



        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            d = 0;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            txt_MaKhoa.Enabled = false;
            btn_Xoa.Enabled = false;
            DataTable dt = Khoa_BLL.tang_MaKhoa();
            string Tang_MaKhoa = dt.Rows[0]["Column1"].ToString();
            int Tang_MaKhoa_Int = int.Parse(Tang_MaKhoa);

            if (Tang_MaKhoa_Int < 10)
            {
                txt_MaKhoa.Text = "MK0" + Tang_MaKhoa_Int;
            }
            else
            {
                txt_MaKhoa.Text = "MK" + Tang_MaKhoa_Int;
            }
            txt_TenKhoa.Enabled = true;
            txt_TenKhoa.Focus();
            txt_TenKhoa.Clear();
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            d = 1;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            txt_MaKhoa.Enabled = false;
            btn_Xoa.Enabled = false;
            txt_TenKhoa.Enabled = true;
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            Khoa_BLL.Update_MK_Bang_GiaoVien(txt_MaKhoa.Text);
            Khoa_BLL.Update_MK_Bang_Lop(txt_MaKhoa.Text);
            Khoa_BLL.xoa_Khoa(txt_MaKhoa.Text);
            dgv_Khoa.DataSource = Khoa_BLL.load_dsKhoa();
            txt_MaKhoa.Clear();
            txt_TenKhoa.Clear();
        }

        private void btn_Luu_Click_1(object sender, EventArgs e)
        {
            if(txt_MaKhoa.Text==""||txt_TenKhoa.Text=="")
            {
                MessageBox.Show("Bạn hãy nhập đủ các trường đi");
            }    
            else
            {
                if (d == 0)
                {
                    DataTable dt = Khoa_BLL.Timkiem_MaKhoa(txt_MaKhoa.Text);
                    if (dt.Rows.Count > 0) MessageBox.Show("Trùng mã khoa kìa bạn hãy nhập mã khoa khác đi");
                    else
                    {
                        Khoa_DTO mk = new Khoa_DTO((txt_MaKhoa.Text), (txt_TenKhoa.Text));
                        Khoa_BLL.them_Khoa(mk);
                        dgv_Khoa.DataSource = Khoa_BLL.load_dsKhoa();
                    }
                }
                else
                {
                    Khoa_DTO mk = new Khoa_DTO((txt_MaKhoa.Text), (txt_TenKhoa.Text));
                    Khoa_BLL.sua_Khoa(mk);
                    dgv_Khoa.DataSource = Khoa_BLL.load_dsKhoa();
                }
                btn_Them.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Luu.Enabled = false;
                btn_Xoa.Enabled = true;
                btn_Huy.Enabled = false;
                txt_TenKhoa.Enabled = false;
            }    
        }

        private void btn_Huy_Click_1(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = false;
            btn_Xoa.Enabled = true;
            txt_MaKhoa.Enabled = true;
            txt_MaKhoa.Clear();
            txt_TenKhoa.Clear();
            btn_Huy.Enabled = false;
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgv_Khoa_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
