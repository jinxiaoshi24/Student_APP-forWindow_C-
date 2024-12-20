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
    public partial class fr_YourInformation : Form
    {
        private string taikhoan1;
        private string type_user1;

        public fr_YourInformation(string taikhoan,string type_user)
        {
            InitializeComponent();
            this.taikhoan1 = taikhoan;
            this.type_user1 = type_user;

        }

        private void FR_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            this .Size = this.ClientSize;
            txt_HoTen.Text = taikhoan1;
            txt_HoTen.Enabled = false;
            dtp_NgaySinh.Enabled = false;
            txt_GioiTinh.Enabled = false;
            txt_DiaChi.Enabled = false;
            txt_SDT.Enabled = false;

            if (type_user1.Trim() == "SV")
            {
                string loaiTK = "SinhVien";
                DataTable dt = Account_BLL.Get_ThongTinCaNhan(loaiTK, taikhoan1);
                txt_HoTen.Text = dt.Rows[0][1].ToString();
                dtp_NgaySinh.Text = dt.Rows[0][2].ToString();
                txt_GioiTinh.Text = dt.Rows[0][3].ToString();
                txt_DiaChi.Text = dt.Rows[0][4].ToString();
                txt_SDT.Text = dt.Rows[0][5].ToString();
            }
            else if (type_user1.Trim() == "GV")
            {
                string loaiTK = "GiaoVien";
                DataTable dt = Account_BLL.Get_ThongTinCaNhan(loaiTK, taikhoan1);
                txt_HoTen.Text = dt.Rows[0][1].ToString();
                dtp_NgaySinh.Text = dt.Rows[0][2].ToString();
                txt_GioiTinh.Text = dt.Rows[0][3].ToString();
                txt_DiaChi.Text = dt.Rows[0][4].ToString();
                txt_SDT.Text = dt.Rows[0][5].ToString();
            }
        }

 

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
