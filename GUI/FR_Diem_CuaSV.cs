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
    public partial class Xuat_Diem_SinhVien : Form
    {
        private string TaiKhoan1;
        public Xuat_Diem_SinhVien(string taiKhoan)
        {
            InitializeComponent();
            this.TaiKhoan1 = taiKhoan;
        }

        private void FR_Diem_CuaSV_Load(object sender, EventArgs e)
        {
            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Xuat_Diem_SinhVien
            // 
            this.ClientSize = new System.Drawing.Size(924, 494);
            this.Name = "Xuat_Diem_SinhVien";
            this.ResumeLayout(false);

        }
    }
}
