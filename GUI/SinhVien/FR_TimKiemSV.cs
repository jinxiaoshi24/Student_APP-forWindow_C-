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

namespace GUI.SinhVien
{
    public partial class FR_TimKiemSV : Form
    {
        public FR_TimKiemSV()
        {
            InitializeComponent();
        }

        private void FR_TimKiemSV_Load(object sender, EventArgs e)
        {
            cmb_MaSV.DataSource = SinhVien_BLL.Load_MaSV();
            cmb_MaSV.ValueMember = "masv";

            rdo_MaSV.Checked = false;
            rdo_HoTenSV.Checked = false;
            cmb_MaSV.Enabled = false;
            txt_HoTenSV.Clear();
            txt_HoTenSV.Enabled = false;
            cmb_MaSV.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaSV.SelectedIndex = -1;
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (rdo_MaSV.Checked == true)
            {
                DataTable dt = SinhVien_BLL.Timkiem_MaSV(cmb_MaSV.Text.Trim());
                dgv_SinhVien.DataSource = dt;
            }
            else if (rdo_HoTenSV.Checked)
            {
                DataTable dt = SinhVien_BLL.Timkiem_HoTenSV(txt_HoTenSV.Text.Trim());
                dgv_SinhVien.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Bạn hãy chọn 1 trường đi");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdo_MaSV_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdo_MaSV.Checked)
            {
                cmb_MaSV.Enabled = true;
                txt_HoTenSV.Enabled = false;
                cmb_MaSV.Focus();
                txt_HoTenSV.Clear();
            }
        }

        private void rdo_HoTenSV_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdo_HoTenSV.Checked)
            {
                cmb_MaSV.Enabled = false;
                txt_HoTenSV.Enabled = true;
                cmb_MaSV.SelectedIndex = -1;
                txt_HoTenSV.Focus();
            }
        }

        private void dgv_SinhVien_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
