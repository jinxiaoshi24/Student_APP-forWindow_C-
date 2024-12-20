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

namespace GUI.MonHoc
{
    public partial class FR_TimKiemMonHoc : Form
    {
        public FR_TimKiemMonHoc()
        {
            InitializeComponent();
        }

        private void FR_TimKiemMonHoc_Load(object sender, EventArgs e)
        {
            cmb_MaMH.DataSource = MonHoc_BLL.load_MaMH();
            cmb_MaMH.ValueMember = "mamh";

            rdo_MaMH.Checked = false;
            rdo_TenMH.Checked = false;
            cmb_MaMH.Enabled = false;
            txt_TenMH.Clear();
            txt_TenMH.Enabled = false;
            cmb_MaMH.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaMH.SelectedIndex = -1;
        }

        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {
            if (rdo_MaMH.Checked == true)
            {
                DataTable dt = MonHoc_BLL.Timkiem_MaMH(cmb_MaMH.Text.Trim());
                dgv_MonHoc.DataSource = dt;
            }
            else if (rdo_TenMH.Checked)
            {

                DataTable dt = MonHoc_BLL.Timkiem_TenMH(txt_TenMH.Text.Trim());
                dgv_MonHoc.DataSource = dt;
                //Tìm kiếm theo tên khách hàng
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

        private void rdo_MaMH_CheckedChanged_1(object sender, EventArgs e)
        {

            if (rdo_MaMH.Checked)
            {
                cmb_MaMH.Enabled = true;
                txt_TenMH.Enabled = false;
                cmb_MaMH.Focus();
                txt_TenMH.Clear();
            }
        }

        private void rdo_TenMH_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdo_TenMH.Checked)
            {
                cmb_MaMH.Enabled = false;
                txt_TenMH.Enabled = true;
                cmb_MaMH.Focus();
                txt_TenMH.Text = "";
                cmb_MaMH.SelectedIndex = -1;
            }
        }

        private void dgv_MonHoc_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
