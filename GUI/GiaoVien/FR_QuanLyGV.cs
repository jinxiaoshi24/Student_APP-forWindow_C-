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

namespace GUI.GiaoVien
{
    public partial class FR_Teacher_Information_Managment : Form
    {
        public FR_Teacher_Information_Managment()
        {
            InitializeComponent();
        }

        private void FR_QuanLyGV_Load(object sender, EventArgs e)
        {
            DataTable dt = GiaoVien_BLL.load_DsGV();
            dgv_GiaoVien.DataSource = dt;

            cmb_MaKhoa.DataSource = GiaoVien_BLL.load_MaKhoa();
            cmb_MaKhoa.ValueMember = "makhoa";

            cmb_TaiKhoan.DataSource = GiaoVien_BLL.Load_TaiKhoan();
            cmb_TaiKhoan.ValueMember = "taikhoan".Trim();

            cmb_TaiKhoan.Text = "";
            cmb_MaKhoa.Text = "";

            cmb_GioiTinh.Items.Add("Nam");
            cmb_GioiTinh.Items.Add("Nữ ");

            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
            cmb_TaiKhoan.Text = "";

            txt_MaGV.Enabled = false;
            txt_HoTenGV.Enabled = false;
            dtp_NgaySinh.Enabled = false;
            cmb_GioiTinh.Enabled = false;
            txt_DiaChi.Enabled = false;
            txt_SDT.Enabled = false;
            cmb_TaiKhoan.Enabled = false;
            cmb_MaKhoa.Enabled = false;

            cmb_GioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_GioiTinh.SelectedIndex = -1;
            cmb_MaKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaKhoa.SelectedIndex = -1;
        }

        int d;
        private void dgv_GiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_MaGV.Text = dgv_GiaoVien.Rows[i].Cells[0].Value.ToString();
            txt_HoTenGV.Text = dgv_GiaoVien.Rows[i].Cells[1].Value.ToString();
            dtp_NgaySinh.Text = dgv_GiaoVien.Rows[i].Cells[2].Value.ToString();
            cmb_GioiTinh.Text = dgv_GiaoVien.Rows[i].Cells[3].Value.ToString();
            txt_DiaChi.Text = dgv_GiaoVien.Rows[i].Cells[4].Value.ToString();
            txt_SDT.Text = dgv_GiaoVien.Rows[i].Cells[5].Value.ToString();
            cmb_TaiKhoan.Text = dgv_GiaoVien.Rows[i].Cells[6].Value.ToString();
            cmb_MaKhoa.Text = dgv_GiaoVien.Rows[i].Cells[7].Value.ToString();

        }
        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            d = 0;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            txt_MaGV.Enabled = false;
            btn_Xoa.Enabled = false;
            DataTable dt = GiaoVien_BLL.tang_MaGV();
            string tang_magv = dt.Rows[0]["column1"].ToString();
            int tang_magv_INT = int.Parse(tang_magv);
            if (tang_magv_INT < 10)
            {
                txt_MaGV.Text = "GV0" + tang_magv_INT;
            }
            else
            {
                txt_MaGV.Text = "GV" + tang_magv_INT;
            }

            txt_HoTenGV.Focus();
            cmb_GioiTinh.Text = "";
            txt_DiaChi.Clear();
            txt_SDT.Clear();
            cmb_TaiKhoan.Text = "";
            cmb_MaKhoa.Text = "";

            txt_HoTenGV.Enabled = true;
            dtp_NgaySinh.Enabled = true;
            cmb_GioiTinh.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_SDT.Enabled = true;
            cmb_TaiKhoan.Enabled = true;
            cmb_MaKhoa.Enabled = true;
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            d = 1;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            txt_MaGV.Enabled = false;
            btn_Xoa.Enabled = false;

            txt_HoTenGV.Enabled = true;
            dtp_NgaySinh.Enabled = true;
            cmb_GioiTinh.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_SDT.Enabled = true;
            cmb_TaiKhoan.Enabled = true;
            cmb_MaKhoa.Enabled = true;
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            GiaoVien_BLL.Update_magv_Bang_Lop(txt_MaGV.Text);
            GiaoVien_BLL.Update_magv_Bang_PhanCong(txt_MaGV.Text);
            GiaoVien_BLL.xoa_GV(txt_MaGV.Text);
            dgv_GiaoVien.DataSource = GiaoVien_BLL.load_DsGV();
            txt_MaGV.Clear();
            txt_HoTenGV.Clear();
            txt_DiaChi.Clear();
            txt_SDT.Clear();
            cmb_TaiKhoan.Text = "";
            cmb_GioiTinh.SelectedIndex = -1;
            cmb_MaKhoa.SelectedIndex = -1;

        }

        private void btn_Luu_Click_1(object sender, EventArgs e)
        {
            if(txt_MaGV.Text==""|| txt_HoTenGV.Text==""|| cmb_GioiTinh.Text==""|| txt_DiaChi.Text==""|| txt_SDT.Text==""|| cmb_TaiKhoan.Text==""|| cmb_MaKhoa.Text=="")
            {
                MessageBox.Show("Bạn hãy nhập đủ các trường đi");
            }
            else
            {
                if (d == 0)
                {
                    DataTable dt = GiaoVien_BLL.Timkiem_MaGV(txt_MaGV.Text);
                    if (dt.Rows.Count > 0) 
                    {
                        MessageBox.Show("Mã Giáo Viên này đã được thêm");
                        
                    }

                    else
                    {
                        string phoneNumber = txt_SDT.Text;
                        string digitsOnly = Regex.Replace(phoneNumber, @"[^\d]", "");
                        bool isValid = Regex.IsMatch(digitsOnly, @"^0[0-9]{9}$");
                        if (isValid)
                        {
                            GiaoVien_DTO gv = new GiaoVien_DTO((txt_MaGV.Text), (txt_HoTenGV.Text), (dtp_NgaySinh.Value.ToString("MM-dd-yyyy")), (cmb_GioiTinh.Text), (txt_DiaChi.Text), (txt_SDT.Text), (cmb_TaiKhoan.Text), (cmb_MaKhoa.Text));
                            GiaoVien_BLL.them_GV(gv);
                            dgv_GiaoVien.DataSource = GiaoVien_BLL.load_DsGV();
                        }
                        else
                        {
                            MessageBox.Show("Số điện thoại không hợp lệ");
                            txt_SDT.Focus();
                        }
                    }
                }
                else
                {
                    string phoneNumber = txt_SDT.Text;
                    string digitsOnly = Regex.Replace(phoneNumber, @"[^\d]", "");
                    bool isValid = Regex.IsMatch(digitsOnly, @"^0[0-9]{9}$");
                    if (isValid)
                    {
                        GiaoVien_DTO gv = new GiaoVien_DTO((txt_MaGV.Text), (txt_HoTenGV.Text), (dtp_NgaySinh.Value.ToString("MM-dd-yyyy")), (cmb_GioiTinh.Text), (txt_DiaChi.Text), (txt_SDT.Text), (cmb_TaiKhoan.Text), (cmb_MaKhoa.Text));
                        GiaoVien_BLL.sua_GV(gv);
                        dgv_GiaoVien.DataSource = GiaoVien_BLL.load_DsGV();
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ");
                        txt_SDT.Focus();
                    }
                }
                btn_Them.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Luu.Enabled = false;
                btn_Xoa.Enabled = true;
                btn_Huy.Enabled = false;

                txt_MaGV.Enabled = false;
                txt_HoTenGV.Enabled = false;
                dtp_NgaySinh.Enabled = false;
                cmb_GioiTinh.Enabled = false;
                txt_DiaChi.Enabled = false;
                txt_SDT.Enabled = false;
                cmb_TaiKhoan.Enabled = false;
                cmb_MaKhoa.Enabled = false;
            }    
        }

        private void btn_Huy_Click_1(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = false;
            btn_Xoa.Enabled = true;
            txt_MaGV.Enabled = true;
            txt_MaGV.Clear();
            txt_HoTenGV.Clear();
            txt_DiaChi.Clear();
            txt_SDT.Clear();

            btn_Huy.Enabled = false;
            txt_MaGV.Focus();

            txt_MaGV.Enabled = false;
            txt_HoTenGV.Enabled = false;
            dtp_NgaySinh.Enabled = false;
            cmb_GioiTinh.Enabled = false;
            txt_DiaChi.Enabled = false;
            txt_SDT.Enabled = false;
            cmb_TaiKhoan.Enabled = false;
            cmb_MaKhoa.Enabled = false;

            cmb_GioiTinh.SelectedIndex = -1;
            cmb_MaKhoa.SelectedIndex = -1;
            cmb_TaiKhoan.SelectedIndex = -1;
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgv_GiaoVien_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}