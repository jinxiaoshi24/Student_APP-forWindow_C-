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
    public partial class FR_TimKiemPhanCong : Form
    {
        public FR_TimKiemPhanCong()
        {
            InitializeComponent();
        }

        private void FR_TimKiemPhanCong_Load(object sender, EventArgs e)
        {
            cmb_MaGV.DataSource = PhanCong_BLL.Load_MaGV();
            cmb_MaGV.ValueMember = "magv";
            cmb_MaMH.DataSource = PhanCong_BLL.Load_MaMH();
            cmb_MaMH.ValueMember = "mamh";
            cmb_MaLop.DataSource = PhanCong_BLL.Load_MaLop();
            cmb_MaLop.ValueMember = "malop";

            rdo_MaGV.Checked = false;
            rdo_MaLop.Checked = false;
            rdo_MaMH.Checked = false;

            cmb_MaGV.Enabled = false;
            cmb_MaMH.Enabled = false;
            cmb_MaLop.Enabled = false;


            cmb_MaGV.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaGV.SelectedIndex = -1;
            cmb_MaMH.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaMH.SelectedIndex = -1;
            cmb_MaLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaLop.SelectedIndex = -1;
        }
        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {
            if (rdo_MaGV.Checked == true)
            {
                DataTable dt = PhanCong_BLL.Timkiem_MaGV(cmb_MaGV.Text.Trim());
                dgv_PhanCong.DataSource = dt;
            }
            else if (rdo_MaMH.Checked)
            {
                DataTable dt = PhanCong_BLL.Timkiem_MaMH(cmb_MaMH.Text.Trim());
                dgv_PhanCong.DataSource = dt;
            }
            else if (rdo_MaLop.Checked)
            {
                DataTable dt = PhanCong_BLL.Timkiem_MaLop(cmb_MaLop.Text.Trim());
                dgv_PhanCong.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Bạn hãy chọn 1 trường đi");
            }
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void rdo_MaGV_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdo_MaGV.Checked)
            {
                cmb_MaGV.Enabled = true;
                cmb_MaLop.Enabled = false;
                cmb_MaMH.Enabled = false;
                cmb_MaGV.Focus();
                cmb_MaMH.SelectedIndex = -1;
                cmb_MaLop.SelectedIndex = -1;
            }
        }

        private void rdo_MaMH_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdo_MaMH.Checked)
            {
                cmb_MaGV.Enabled = false;
                cmb_MaLop.Enabled = false;
                cmb_MaMH.Enabled = true;
                cmb_MaMH.Focus();
                cmb_MaGV.SelectedIndex = -1;
                cmb_MaLop.SelectedIndex = -1;
            }
        }

        private void rdo_MaLop_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdo_MaLop.Checked)
            {
                cmb_MaGV.Enabled = false;
                cmb_MaLop.Enabled = true;
                cmb_MaMH.Enabled = false;
                cmb_MaLop.Focus();
                cmb_MaGV.SelectedIndex = -1;
                cmb_MaMH.SelectedIndex = -1;
            }
        }

        private void dgv_PhanCong_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
