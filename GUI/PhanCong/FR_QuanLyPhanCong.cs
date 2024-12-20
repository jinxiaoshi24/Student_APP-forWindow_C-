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

namespace GUI.PhanCong
{
    public partial class FR_QuanLyPhanCong : Form
    {
        public FR_QuanLyPhanCong()
        {
            InitializeComponent();
        }

        private void FR_QuanLyPhanCong_Load(object sender, EventArgs e)
        {
            DataTable dt = PhanCong_BLL.load_DsPhanCong();
            dgv_PhanCong.DataSource = dt;

            cmb_MaGV.DataSource = PhanCong_BLL.Load_MaGV();
            cmb_MaGV.ValueMember = "magv";
            cmb_MaMH.DataSource = PhanCong_BLL.Load_MaMH();
            cmb_MaMH.ValueMember = "mamh";
            cmb_Lop.DataSource = PhanCong_BLL.Load_MaLop();
            cmb_Lop.ValueMember = "malop";


            nud_HocKi.ResetText();
            nud_NamHoc.ResetText();
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;

            cmb_MaGV.Enabled = false;
            cmb_MaMH.Enabled = false;
            cmb_Lop.Enabled = false;
            nud_HocKi.Enabled = false;
            nud_NamHoc.Enabled = false;

            cmb_MaGV.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaGV.SelectedIndex = -1;
            cmb_MaMH.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaMH.SelectedIndex = -1;
            cmb_Lop.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Lop.SelectedIndex = -1;
        }


        int d;
        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            d = 0;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            btn_Xoa.Enabled = false;

            cmb_MaGV.Focus();
            cmb_MaGV.Enabled = true;
            cmb_MaMH.Enabled = true;
            cmb_Lop.Enabled = true;
            nud_HocKi.Enabled = true;
            nud_NamHoc.Enabled = true;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            d = 1;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            btn_Xoa.Enabled = false;

            cmb_MaGV.Enabled = true;
            cmb_MaMH.Enabled = true;
            cmb_Lop.Enabled = true;
            nud_HocKi.Enabled = true;
            nud_NamHoc.Enabled = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            PhanCong_BLL.xoa_PhanCong(cmb_MaGV.Text.Trim(), cmb_MaMH.Text.Trim(), cmb_Lop.Text.Trim());
            dgv_PhanCong.DataSource = PhanCong_BLL.load_DsPhanCong();
            nud_HocKi.ResetText();
            nud_NamHoc.ResetText();
            cmb_MaGV.Focus();
            cmb_MaGV.SelectedIndex = -1;
            cmb_MaMH.SelectedIndex = -1;
            cmb_Lop.SelectedIndex = -1;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(cmb_MaGV.Text==""||cmb_Lop.Text==""||cmb_MaMH.Text==""||nud_NamHoc.Text==""||nud_HocKi.Text=="")
            {
                MessageBox.Show("Bạn hãy nhập đủ các trường đi");
            }
            else
            {
                if (d == 0)
                {
                    PhanCong_DTO pc1 = new PhanCong_DTO((cmb_MaGV.Text), (cmb_MaMH.Text), (cmb_Lop.Text), (nud_NamHoc.Text), (nud_HocKi.Text));

                    PhanCong_BLL phanCongBLL = new PhanCong_BLL();
                    bool isPhanCongValid = phanCongBLL.check_PhanCong(pc1);

                    if (isPhanCongValid)
                    {
                        MessageBox.Show("Môn này đã được phân công");
                    }
                    else
                    {
                        PhanCong_DTO pc = new PhanCong_DTO((cmb_MaGV.Text), (cmb_MaMH.Text), (cmb_Lop.Text), (nud_NamHoc.Text), (nud_HocKi.Text));
                        PhanCong_BLL.them_PhanCong(pc);
                        dgv_PhanCong.DataSource = PhanCong_BLL.load_DsPhanCong();
                    }
                }
                else
                {
                    PhanCong_DTO pc = new PhanCong_DTO((cmb_MaGV.Text), (cmb_MaMH.Text), (cmb_Lop.Text), (nud_NamHoc.Text), (nud_HocKi.Text));
                    PhanCong_BLL.sua_PhanCong(pc);
                    dgv_PhanCong.DataSource = PhanCong_BLL.load_DsPhanCong();

                }
                btn_Them.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Luu.Enabled = false;
                btn_Xoa.Enabled = true;
                btn_Huy.Enabled = false;

                cmb_MaGV.Enabled = false;
                cmb_MaMH.Enabled = false;
                cmb_Lop.Enabled = false;
                nud_HocKi.Enabled = false;
                nud_NamHoc.Enabled = false;
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = false;
            btn_Xoa.Enabled = true;
            cmb_MaMH.Text = "";
            cmb_MaGV.Text = "";
            cmb_Lop.Text = "";
            nud_HocKi.ResetText();
            nud_NamHoc.ResetText();
            btn_Huy.Enabled = false;

            cmb_MaGV.Enabled = false;
            cmb_MaMH.Enabled = false;
            cmb_Lop.Enabled = false;
            nud_HocKi.Enabled = false;
            nud_NamHoc.Enabled = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgv_PhanCong_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cmb_MaGV.Text = dgv_PhanCong.Rows[i].Cells[0].Value.ToString();
            cmb_MaMH.Text = dgv_PhanCong.Rows[i].Cells[1].Value.ToString();
            cmb_Lop.Text = dgv_PhanCong.Rows[i].Cells[2].Value.ToString();
            nud_NamHoc.Text = dgv_PhanCong.Rows[i].Cells[3].Value.ToString();
            nud_HocKi.Text = dgv_PhanCong.Rows[i].Cells[4].Value.ToString();
        }

        private void dgv_PhanCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_PhanCong_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
