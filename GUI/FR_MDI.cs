using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using static GUI.Function;

namespace GUI
{
    public partial class FR_MDI : Form
    {
        private string taiKhoan;
        private string type_user1;

        public FR_MDI(string HoTen,string taiKhoan,string type_user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual; // Cho phép đặt vị trí và kích thước thủ công
            this.Location = Screen.PrimaryScreen.WorkingArea.Location; // Đặt vị trí góc trên cùng
            this.Size = Screen.PrimaryScreen.WorkingArea.Size; // Đặt kích thước bằng vùng làm việc            
            this.StartPosition = FormStartPosition.CenterScreen; // Căn giữa màn hình
            this.Size = new Size(1920, 1080); // Kích thước cố định

            label_Name.Text = HoTen;
            this.taiKhoan = taiKhoan;
            this.type_user1 = type_user;



        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Name  == "FR_ThongTinCaNhan")
                {
                    mdiChild.Activate();
                    return;
                }
            }

            fr_YourInformation fr = new fr_YourInformation(taiKhoan , type_user1 );
            fr.MdiParent = this;
            fr.Size = this.ClientSize;
            // Function .Close_taskBar(fr.MdiParent);
            fr.Show();


            // Deactivate other MDI child forms
            foreach (Form otherMdiChild in this.MdiChildren)
            {

                if (otherMdiChild != fr)
                {
                    otherMdiChild.Close();
                }
            }             
        }

        private void FR_MDI_Load(object sender, EventArgs e)
        {
            if(type_user1.Trim() == "admin")
            {
                Teaching_Management.Visible = true;
                xemToolStripMenuItem.Visible = true;
                My_class_managment.Visible = true;
            }
            else if(type_user1.Trim() == "GV")
            {                
                Managment.Visible = true;
                Acount_MenuStrip_M_item.Visible = false;
                Score_MenuStrip_M_item.Visible = true;
                Teacher_MenuStrip_M_item.Visible = false;
                Faculty_MenuStrip_M_item.Visible = false;
                Class_MenuStrip_M_item.Visible = false;
                Subject_MenuStrip_M_item.Visible = false;
                Assigment_MenuStrip_M_item.Visible = false;
                Student_MenuStrip_M_item.Visible = false;
                My_class_managment.Visible = true;
                Search_function.Visible = false;
                xemToolStripMenuItem.Visible = true;
            }
            else if (type_user1.Trim() == "SV")
            {
                Managment.Visible = false;
                Acount_MenuStrip_M_item.Visible = false;
                Score_MenuStrip_M_item.Visible = false;
                Teacher_MenuStrip_M_item.Visible = false;
                Faculty_MenuStrip_M_item.Visible = false;
                Class_MenuStrip_M_item.Visible = false;
                Subject_MenuStrip_M_item.Visible = false;
                Assigment_MenuStrip_M_item.Visible = false;
                Student_MenuStrip_M_item.Visible = false;
                My_class_managment.Visible = false;
                xemToolStripMenuItem.Visible = true;
                Search_function.Visible = false;
                Teaching_Management.Visible = false;
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "FR_DoiMatKhau")
                {
                    frm.Activate();
                    break;
                }
                FR_DoiMatKhau fr = new FR_DoiMatKhau(taiKhoan);
                fr.MdiParent = this;
                fr.Show();
                foreach (Form otherMdiChild in this.MdiChildren)
                {

                    if (otherMdiChild != fr)
                    {
                        otherMdiChild.Close();
                    }
                }
            }
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "FR_QuanLyDiem")
                {
                    frm.Activate();
                    
                    break;
                }
            }
           
            Diem.FR_QuanLyDiem fr = new Diem.FR_QuanLyDiem(taiKhoan);
            fr.MdiParent = this;
            fr.Show();
            foreach (Form otherMdiChild in this.MdiChildren)
            {

                if (otherMdiChild != fr)
                {
                    otherMdiChild.Close();
                }
            }
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.OpenOrSwitchForm<Account.FR_ManagmentAccount>(this);
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            FormManager.OpenOrSwitchForm<GiaoVien.FR_Teacher_Information_Managment>(this);

        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.OpenOrSwitchForm<Khoa.FR_QuanLyKhoa>(this);
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.OpenOrSwitchForm<Lop.FR_QuanLyLop >(this);
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.OpenOrSwitchForm<MonHoc.FR_Project_Managment >(this);

        }

        private void phânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.OpenOrSwitchForm < PhanCong.FR_QuanLyPhanCong> (this);            
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.OpenOrSwitchForm<SinhVien.FR_QuanLySV>(this);           
        }

        private void accountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           FormManager.OpenOrSwitchForm<Account.FR_TimKiemAccount>(this);            
        }

        private void điểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormManager.OpenOrSwitchForm<Diem.FR_TimKiemDiem>(this);
        }

        private void giáoViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormManager.OpenOrSwitchForm<GiaoVien.FR_TimKiemGV>(this);           
        }

        private void khoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormManager.OpenOrSwitchForm<Khoa.FR_TimKiemKhoa>(this);
        }

        private void lớpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormManager.OpenOrSwitchForm<Lop.FR_SrearchClass>(this);
        }

        private void mônHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormManager.OpenOrSwitchForm<MonHoc.FR_TimKiemMonHoc>(this);
        }

        private void quảnLýLớpChủNhiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = Lop_BLL.Timkiem_LopChuNhiem(taiKhoan);
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Bạn không chủ nhiệm lớp nào");
                StudentListNameToolStripMenuItem.Enabled = false;
                StudentListScoreToolStripMenuItem.Enabled = false;
            }    
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_Login fr = new FR_Login();
            fr.Show();
            this.Hide();
        }

        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool kt = true;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "FR_XemDiemLopChuNhiem")
                {
                    frm.Activate();
                    kt = false;
                    break;
                }
            }
            if (kt == true)
            {
                MessageBox.Show("edff");
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void thờiKhóaBiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            global::System.Diagnostics.Process.Start("https://hnivc.edu.vn/thoi-khoa-bieu.html");
        }

        private void tinTứcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            global::System.Diagnostics.Process.Start("https://hnivc.edu.vn/tin-tuc-su-kien.html");
        }

        private void sinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormManager.OpenOrSwitchForm<SinhVien.FR_TimKiemSV>(this);
        }

        private void phânCôngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormManager.OpenOrSwitchForm<PhanCong.FR_TimKiemPhanCong>(this);           
        }

        private void phânCôngGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  FormManager.OpenOrSwitchForm<FR_DanhSachPhanCong>(this);
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            FR_Login fr = new FR_Login();
            fr.Show();
            this.Hide();
        }
    }
}
