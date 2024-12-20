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


namespace GUI.Lop
{
    public partial class FR_QuanLyLop : Form
    {
        public FR_QuanLyLop()
        {
            InitializeComponent();
        }

        private void FR_QuanLyLop_Load(object sender, EventArgs e)
        {
            DataTable dt = Lop_BLL.load_dsLop();
            dgv_Lop.DataSource = dt;
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;

            cmb_MaKhoa.DataSource = Lop_BLL.load_MaKhoa();
            cmb_MaKhoa.ValueMember = "makhoa";
            cmb_MaGV.DataSource = Lop_BLL.Load_Magv();
            cmb_MaGV.ValueMember = "magv";

            txt_MaLop.Enabled = false;
            txt_TenLop.Enabled = false;
            cmb_MaKhoa.Enabled = false;
            cmb_MaGV.Enabled = false;

            cmb_MaKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaKhoa.SelectedIndex = -1;
            cmb_MaGV.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaGV.SelectedIndex = -1;
        }

        int d;
        private void dgv_Lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_MaLop.Text = dgv_Lop.Rows[i].Cells[0].Value.ToString();
            txt_TenLop.Text = dgv_Lop.Rows[i].Cells[1].Value.ToString();
            cmb_MaKhoa.Text = dgv_Lop.Rows[i].Cells[2].Value.ToString();
            cmb_MaGV.Text = dgv_Lop.Rows[i].Cells[3].Value.ToString();
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            d = 0;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            txt_MaLop.Enabled = false;
            btn_Xoa.Enabled = false;
            DataTable dt = Lop_BLL.tang_MaLop();
            string tang_malop = dt.Rows[0]["column1"].ToString();
            int tang_malop_Int = int.Parse(tang_malop);
            if (tang_malop_Int < 10)
            {
                txt_MaLop.Text = "ML0" + tang_malop_Int;
            }
            else
            {
                txt_MaLop.Text = "ML" + tang_malop_Int;
            }
            txt_TenLop.Focus();
            txt_TenLop.Clear();
            cmb_MaKhoa.Text = "";

            txt_TenLop.Enabled = true;
            cmb_MaKhoa.Enabled = true;
            cmb_MaGV.Enabled = true;
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            d = 1;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            txt_MaLop.Enabled = false;
            btn_Xoa.Enabled = false;
            txt_TenLop.Enabled = true;
            cmb_MaKhoa.Enabled = true;
            cmb_MaGV.Enabled = true;
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            Lop_BLL.Update_ML_Bang_PhanCong(txt_MaLop.Text);
            Lop_BLL.Update_ML_Bang_SinhVien(txt_MaLop.Text);
            Lop_BLL.xoa_Lop(txt_MaLop.Text);
            dgv_Lop.DataSource = Lop_BLL.load_dsLop();
            txt_MaLop.Clear();
            txt_TenLop.Clear();
            cmb_MaKhoa.SelectedIndex = -1;
            cmb_MaGV.SelectedIndex = -1;
        }

        private void btn_Luu_Click_1(object sender, EventArgs e)
        {
            if (d == 0)
            {
                DataTable dt = Lop_BLL.Timkiem_MaLop(txt_MaLop.Text);
                if (dt.Rows.Count > 0) MessageBox.Show("Trùng mã lớp kìa bạn hãy nhập mã lớp khác đi");
                else
                {
                    Lop_DTO ml = new Lop_DTO((txt_MaLop.Text), (txt_TenLop.Text), (cmb_MaKhoa.Text), (cmb_MaGV.Text));
                    Lop_BLL.them_Lop(ml);
                    dgv_Lop.DataSource = Lop_BLL.load_dsLop();
                }
            }
            else
            {
                Lop_DTO ml = new Lop_DTO((txt_MaLop.Text), (txt_TenLop.Text), (cmb_MaKhoa.Text), (cmb_MaGV.Text));
                Lop_BLL.sua_Lop(ml);
                dgv_Lop.DataSource = Lop_BLL.load_dsLop();
            }
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = false;
            btn_Xoa.Enabled = true;
            btn_Huy.Enabled = false;

            txt_TenLop.Enabled = false;
            cmb_MaKhoa.Enabled = false;
            cmb_MaGV.Enabled = false;
        }

        private void btn_Huy_Click_1(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = false;
            btn_Xoa.Enabled = true;
            txt_MaLop.Enabled = true;
            txt_MaLop.Clear();
            txt_TenLop.Clear();
            cmb_MaKhoa.Text = "";
            cmb_MaGV.Text = "";
            btn_Huy.Enabled = false;

            txt_TenLop.Enabled = false;
            cmb_MaKhoa.Enabled = false;
            cmb_MaGV.Enabled = false;
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgv_Lop_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
