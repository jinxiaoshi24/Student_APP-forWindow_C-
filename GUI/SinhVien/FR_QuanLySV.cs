using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DTO;
using BLL;

namespace GUI.SinhVien
{
    public partial class FR_QuanLySV : Form
    {
        public FR_QuanLySV()
        {
            InitializeComponent();
        }

        private void FR_QuanLySV_Load(object sender, EventArgs e)
        {
            DataTable dt = SinhVien_BLL.load_DsSV();
            dgv_SinhVien.DataSource = dt;

            cmb_MaLop.DataSource = SinhVien_BLL.load_Malop();
            cmb_MaLop.ValueMember = "malop";
            cmb_TaiKhoan.DataSource = SinhVien_BLL.Load_TaiKhoan();
            cmb_TaiKhoan.ValueMember = "taikhoan";
            cmb_TaiKhoan.Text = "";
            cmb_MaLop.Text = "";

            cmb_GioiTinh.Items.Add("Nam");
            cmb_GioiTinh.Items.Add("Nữ");
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;

            txt_MaSV.Enabled = false;
            txt_HoTenSV.Enabled = false;
            dtp_NgaySinh.Enabled = false;
            cmb_GioiTinh.Enabled = false;
            txt_DiaChi.Enabled = false;
            txt_SDT.Enabled = false;
            cmb_TaiKhoan.Enabled = false;
            cmb_MaLop.Enabled = false;

            cmb_GioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_GioiTinh.SelectedIndex = -1;
            cmb_MaLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaLop.SelectedIndex = -1;
        }
        int d;
        private void btn_Them_Click(object sender, EventArgs e)
        {
            d = 0;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            txt_MaSV.Enabled = false;
            btn_Xoa.Enabled = false;
            DataTable dt = SinhVien_BLL.tang_MaSV();
            string tang_magv = dt.Rows[0]["column1"].ToString();
            int tang_magv_Int = int.Parse(tang_magv);

            if (tang_magv_Int < 10)
            {
                txt_MaSV.Text = "SV0" + tang_magv_Int;
            }
            else
            {
                txt_MaSV.Text = "SV" + tang_magv_Int;
            }
            txt_HoTenSV.Focus();
            cmb_GioiTinh.Text = "";
            txt_DiaChi.Clear();
            txt_SDT.Clear();
            cmb_TaiKhoan.Text = "";
            cmb_MaLop.Text = "";

            txt_HoTenSV.Enabled = true;
            dtp_NgaySinh.Enabled = true;
            cmb_GioiTinh.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_SDT.Enabled = true;
            cmb_TaiKhoan.Enabled = true;
            cmb_MaLop.Enabled = true;
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            d = 1;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            txt_MaSV.Enabled = false;
            btn_Xoa.Enabled = false;

            txt_HoTenSV.Enabled = true;
            dtp_NgaySinh.Enabled = true;
            cmb_GioiTinh.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_SDT.Enabled = true;
            cmb_TaiKhoan.Enabled = true;
            cmb_MaLop.Enabled = true;
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            SinhVien_BLL.xoa_SV_Bang_Diem(txt_MaSV.Text);
            SinhVien_BLL.xoa_SV(txt_MaSV.Text);
            dgv_SinhVien.DataSource = SinhVien_BLL.load_DsSV();
            txt_MaSV.Clear();
            txt_HoTenSV.Clear();
            txt_DiaChi.Clear();
            txt_SDT.Clear();
            cmb_GioiTinh.SelectedIndex = -1;
            cmb_MaLop.SelectedIndex = -1; 
            cmb_TaiKhoan.SelectedIndex = -1;

        }

        private void btn_Luu_Click_1(object sender, EventArgs e)
        {
            if(txt_MaSV.Text==""||txt_HoTenSV.Text==""||cmb_GioiTinh.Text==""||txt_DiaChi.Text==""||txt_SDT.Text==""||cmb_TaiKhoan.Text==""||cmb_MaLop.Text=="")
            {
                MessageBox.Show("Bạn hãy nhập đủ các trường đi");
            }    
            else
            {
                string phoneNumber = txt_SDT.Text;
                string digitsOnly = Regex.Replace(phoneNumber, @"[^\d]", "");
                bool isValid = Regex.IsMatch(digitsOnly, @"^0[0-9]{9}$");
                if (isValid)
                {
                    if (d == 0)
                    {
                        DataTable dt = SinhVien_BLL.Timkiem_MaSV(txt_MaSV.Text);
                        if (dt.Rows.Count > 0) MessageBox.Show("Trùng mã môn kìa bạn hãy nhập mã môn khác đi");
                        else
                        {
                            SinhVien_DTO sv = new SinhVien_DTO((txt_MaSV.Text), (txt_HoTenSV.Text), (dtp_NgaySinh.Value.ToString("MM-dd-yyyy")), (cmb_GioiTinh.Text), (txt_DiaChi.Text), (txt_SDT.Text), (cmb_TaiKhoan.Text), (cmb_MaLop.Text));
                            SinhVien_BLL.them_SV(sv);
                            dgv_SinhVien.DataSource = SinhVien_BLL.load_DsSV();
                        }
                    }
                    else
                    {
                        SinhVien_DTO sv = new SinhVien_DTO((txt_MaSV.Text), (txt_HoTenSV.Text), (dtp_NgaySinh.Value.ToString("MM-dd-yyyy")), (cmb_GioiTinh.Text), (txt_DiaChi.Text), (txt_SDT.Text), (cmb_TaiKhoan.Text), (cmb_MaLop.Text));
                        SinhVien_BLL.sua_SV(sv);
                        dgv_SinhVien.DataSource = SinhVien_BLL.load_DsSV();
                    }
                    btn_Them.Enabled = true;
                    btn_Sua.Enabled = true;
                    btn_Luu.Enabled = false;
                    btn_Xoa.Enabled = true;
                    btn_Huy.Enabled = false;
                    txt_HoTenSV.Enabled = false;
                    dtp_NgaySinh.Enabled = false;
                    cmb_GioiTinh.Enabled = false;
                    txt_DiaChi.Enabled = false;
                    txt_SDT.Enabled = false;
                    cmb_TaiKhoan.Enabled = false;
                    cmb_MaLop.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ");
                    txt_SDT.Focus();
                }
            }    
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = false;
            btn_Xoa.Enabled = true;
            txt_MaSV.Clear();
            txt_HoTenSV.Clear();
            txt_DiaChi.Clear();
            txt_SDT.Clear();
            btn_Huy.Enabled = false;
            txt_HoTenSV.Enabled = false;
            dtp_NgaySinh.Enabled = false;
            cmb_GioiTinh.Enabled = false;
            txt_DiaChi.Enabled = false;
            txt_SDT.Enabled = false;
            cmb_TaiKhoan.Enabled = false;
            cmb_MaLop.Enabled = false;

            cmb_GioiTinh.SelectedIndex = -1;
            cmb_MaLop.SelectedIndex = -1;
            cmb_TaiKhoan.SelectedIndex = -1;

        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgv_SinhVien_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgv_SinhVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_MaSV.Text = dgv_SinhVien.Rows[i].Cells[0].Value.ToString();
            txt_HoTenSV.Text = dgv_SinhVien.Rows[i].Cells[1].Value.ToString();
            dtp_NgaySinh.Text = dgv_SinhVien.Rows[i].Cells[2].Value.ToString();
            cmb_GioiTinh.Text = dgv_SinhVien.Rows[i].Cells[3].Value.ToString();
            txt_DiaChi.Text = dgv_SinhVien.Rows[i].Cells[4].Value.ToString();
            txt_SDT.Text = dgv_SinhVien.Rows[i].Cells[5].Value.ToString();
            cmb_TaiKhoan.Text = dgv_SinhVien.Rows[i].Cells[6].Value.ToString();
            cmb_MaLop.Text = dgv_SinhVien.Rows[i].Cells[7].Value.ToString();
        }
    }
}
