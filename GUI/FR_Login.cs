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
    public partial class FR_Login : Form
    {
        public FR_Login()
        {
            InitializeComponent();
        }
        private void FR_Login_Load(object sender, EventArgs e)
        {   //tiến hành load dữ liệu tài khoản vừa đăng nhập lên đẻ nhập sẵn
            txt_TaiKhoan.Text = Properties.Settings.Default.TaiKhoan;
            txt_MatKhau.Text = Properties.Settings.Default.MatKhau;
            if (Properties.Settings.Default.TaiKhoan != "")
            {
                chk_LuuThongTinDangNhap.Checked = true;
            }
        }
        private void chk_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Pass.Checked)
            {
                txt_MatKhau.UseSystemPasswordChar = true;
            }
            else
            {
                txt_MatKhau.UseSystemPasswordChar = false;
            }
        }

        private void chk_LuuThongTin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click_1(object sender, EventArgs e)
        {
            string taikhoan = txt_TaiKhoan.Text.Trim();
            string matkhau = txt_MatKhau.Text.Trim();
            if (string.IsNullOrEmpty(taikhoan))
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TaiKhoan.Focus();
                return;
            }

            else if (string.IsNullOrEmpty(matkhau))
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MatKhau.Focus();
                return;
            }
            else
            {
                DataTable dt = Account_BLL.LayThongTinDangNhap(taikhoan, matkhau); // LẤy đc 3 trường bảng accuont User, mk, type
                if (dt.Rows.Count == 1)
                {
                    DataTable dt1 = Account_BLL.Lay_Type_User(taikhoan, matkhau); // LÁy type găn vào bảng dt1
                    // sau khi lấy đủ thông tin khớp trong CSDL_Account thì tiến hành đăng nhập vào trong hệ thống
                    if (dt1 != null && dt.Rows.Count > 0)
                    {
                        string typeUser = dt1.Rows[0]["type_user"].ToString(); // lấy type gắn vào biến TypeUser
                        if (typeUser.Trim() == "SV")
                        {
                            DataTable dt2 = SinhVien_BLL.Show_Name_SV(taikhoan);
                            string HoTen = dt2.Rows[0]["hotensv"].ToString();
                            FR_MDI fr = new FR_MDI(HoTen, taikhoan, typeUser);
                            fr.Show();
                            this.Hide();
                        }
                        else if (typeUser.Trim() == "GV")
                        {
                            DataTable dt3 = GiaoVien_BLL.Show_Name_GV(taikhoan);
                            string HoTen = dt3.Rows[0]["hotengv"].ToString();
                            FR_MDI fr = new FR_MDI(HoTen, taikhoan, typeUser);
                            fr.Show();
                            this.Hide();
                        }
                        else
                        {   
                            string HoTen = "admin";
                            FR_MDI fr = new FR_MDI(HoTen, taikhoan, typeUser);
                            fr.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập!");
                    txt_TaiKhoan.Clear();
                    txt_TaiKhoan.Focus();
                    txt_MatKhau.Clear();
                }
                // Sau khi đăng nhập nếu Có tích Lưu thông tin đăng nhập thì sẽ tiến hành chạy đoạn code này để lưu thoongtin đăng nhập
                // Nếu không tích luu thông tin đăng nhập thì sẽ tiến hành xóa tài khoản đã lưu ở bên trong hệ thống
                if (txt_TaiKhoan.Text != "" && txt_MatKhau.Text != "" && chk_LuuThongTinDangNhap.Checked == true)
                {
                    if (chk_LuuThongTinDangNhap.Checked == true)
                    {
                        string TaiKhoan = txt_TaiKhoan.Text.Trim();
                        string MatKhau = txt_MatKhau.Text.Trim();
                        Properties.Settings.Default.TaiKhoan = txt_TaiKhoan.Text.Trim();
                        Properties.Settings.Default.MatKhau = txt_MatKhau.Text.Trim();
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.Reset();
                    }
                }


            }
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            DialogResult res;

            res = MessageBox.Show("Do you want to exist", "Exist", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
            if (res == DialogResult.Yes )
            {
                Application .Exit();
            }
            else
            {
                this.Show();
            }
        }
        private void Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
