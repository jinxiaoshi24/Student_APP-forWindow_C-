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

namespace GUI.Khoa
{
    public partial class FR_TimKiemKhoa : Form
    {
        public FR_TimKiemKhoa()
        {
            InitializeComponent();
        }

        private void FR_TimKiem_Khoa_Load(object sender, EventArgs e)
        {
            cmb_MaKhoa.DataSource = Khoa_BLL.load_MaKhoa();
            cmb_MaKhoa.ValueMember = "makhoa";

            rdo_MaKhoa.Checked = false;
            rdo_TenKhoa.Checked = false;
            cmb_MaKhoa.Enabled = false;
            txt_TenKhoa.Clear();
            txt_TenKhoa.Enabled = false;
            cmb_MaKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaKhoa.SelectedIndex = -1;
        }
        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {
            if (rdo_MaKhoa.Checked == true)
            {
                DataTable dt = Khoa_BLL.Timkiem_MaKhoa(cmb_MaKhoa.Text.Trim());
                dgv_Khoa.DataSource = dt;
            }
            else if (rdo_TenKhoa.Checked)
            {
                DataTable dt = Khoa_BLL.Timkiem_TenKhoa(txt_TenKhoa.Text.Trim());
                dgv_Khoa.DataSource = dt;
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

        private void rdo_MaKhoa_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdo_MaKhoa.Checked)
            {
                cmb_MaKhoa.Enabled = true;
                txt_TenKhoa.Enabled = false;
                cmb_MaKhoa.Focus();
                txt_TenKhoa.Clear();
            }
        }

        private void rdo_TenKhoa_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdo_TenKhoa.Checked)
            {
                cmb_MaKhoa.Enabled = false;
                txt_TenKhoa.Enabled = true;
                txt_TenKhoa.Focus();
                cmb_MaKhoa.SelectedIndex = -1;
            }
        }

        private void dgv_Khoa_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
