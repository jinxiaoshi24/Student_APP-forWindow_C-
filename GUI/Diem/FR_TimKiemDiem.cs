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

namespace GUI.Diem
{
    public partial class FR_TimKiemDiem : Form
    {
        public FR_TimKiemDiem()
        {
            InitializeComponent();
        }

        private void FR_TimKiemDiem_Load(object sender, EventArgs e)
        {
            cmb_MaMH.DataSource = Diem_BLL.Load_MaMH();
            cmb_MaMH.ValueMember = "mamh";

            cmb_MaSV.DataSource = Diem_BLL.Load_MaSV();
            cmb_MaSV.ValueMember = "masv";

            rdo_MaMH.Checked = false;
            rdo_MaSV.Checked = false;
            cmb_MaMH.Text = "";
            cmb_MaMH.Enabled = false;
            cmb_MaSV.Text = "";
            cmb_MaSV.Enabled = false;

            cmb_MaSV.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaSV.SelectedIndex = -1;
            cmb_MaMH.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaMH.SelectedIndex = -1;
        }

        private void rdo_MaMH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_MaMH.Checked)
            {
                cmb_MaMH.Enabled = true;
                cmb_MaSV.Enabled = false;
                cmb_MaMH.Focus();
                cmb_MaSV.SelectedIndex = -1;
            }
        }

        private void rdo_MaSV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_MaSV.Checked)
            {
                cmb_MaMH.Enabled = false;
                cmb_MaSV.Enabled = true;
                cmb_MaMH.SelectedIndex = -1;
                cmb_MaSV.Focus();
            }
        }
        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {
            if (rdo_MaMH.Checked == true)
            {
                DataTable dt = Diem_BLL.Timkiem_MaMH(cmb_MaMH.Text.Trim());
                dgv_Diem.DataSource = dt;
            }
            else if (rdo_MaSV.Checked)
            {
                DataTable dt = Diem_BLL.Timkiem_MaSV(cmb_MaSV.Text.Trim());
                dgv_Diem.DataSource = dt;
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

        private void dgv_Diem_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }

    }
}
