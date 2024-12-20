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

namespace GUI
{
    public partial class FR_DoiMatKhau : Form
    {
        private string taikhoan1;
        public FR_DoiMatKhau(string taiKhoan)
        {
            InitializeComponent();
            this.taikhoan1 = taiKhoan;
        }

        private void FR_DoiMatKhau_Load(object sender, EventArgs e)
        {
            
        }
     

        private void btn_DoiMK_Click_1(object sender, EventArgs e)
        {
            string Mk_Cu = txt_MK_Cu.Text.Trim();
            string MK_Moi = txt_MK_Moi.Text.Trim();
            string MK_NhapLai = txt_MK_NhapLai.Text.Trim();
            if (Mk_Cu == "" || MK_Moi == "" || MK_NhapLai == "")
            {
                MessageBox.Show("Bạn hãy nhập đủ các trường đi");
            }
            else if (MK_Moi != MK_NhapLai)
            {
                MessageBox.Show("Mật Khẩu Nhập lại không đúng bạn hãy nhập lại đi");
                txt_MK_NhapLai.Focus();
            }
            else if (MK_Moi == Mk_Cu)
            {
                MessageBox.Show("Mật Khẩu mới không thể giống Mật Khẩu cũ bạn hãy sửa lại đi");
                txt_MK_Moi.Focus();
            }
            else
            {
                DataTable dt = Account_BLL.LayThongTinDangNhap(taikhoan1, Mk_Cu);
                if (dt.Rows.Count == 1)
                {
                    Account_DTO mk = new Account_DTO(taikhoan1, MK_Moi, Mk_Cu);
                    Account_BLL.Doi_Mai_Khau(mk);
                    MessageBox.Show("Mật khẩu bạn đã được đổi thành : " + MK_Moi);
                    txt_MK_Cu.Clear();
                    txt_MK_Cu.Focus();
                    txt_MK_Moi.Clear();
                    txt_MK_NhapLai.Clear();
                }
                else
                {
                    MessageBox.Show("Thông Tin Đăng Nhập sai bạn hay nhập lại đi");
                    txt_MK_Cu.Clear();
                    txt_MK_Cu.Focus();
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Chk_PassHideshow_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_PassHideshow.Checked)
            {
                txt_MK_Cu.UseSystemPasswordChar = true;
                txt_MK_Moi.UseSystemPasswordChar = true;
                txt_MK_NhapLai.UseSystemPasswordChar = true;
            }
            else
            {
                txt_MK_Cu.UseSystemPasswordChar = false;
                txt_MK_Moi.UseSystemPasswordChar = false;
                txt_MK_NhapLai.UseSystemPasswordChar = false;
            }
        }
    }
}
