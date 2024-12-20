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

namespace GUI.GiaoVien
{
    public partial class FR_TimKiemGV : Form
    {
        public FR_TimKiemGV()
        {
            InitializeComponent();
        }

        private void FR_TimKiemGV_Load(object sender, EventArgs e)
        {
            cmb_MaGV.DataSource = GiaoVien_BLL.Load_MaGV();
            cmb_MaGV.ValueMember = "magv";

            rdo_MaGV.Checked = false;
            rdo_HoTenGV.Checked = false;
            cmb_MaGV.Text = "";
            cmb_MaGV.Enabled = false;
            txt_HoTenGV.Clear();
            txt_HoTenGV.Enabled = false;
            cmb_MaGV.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaGV.SelectedIndex = -1;
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (rdo_MaGV.Checked == true)
            {
                DataTable dt = GiaoVien_BLL.Timkiem_MaGV(cmb_MaGV.Text.Trim());
                dgv_GiaoVien.DataSource = dt;
            }
            else if (rdo_HoTenGV.Checked)
            {

                DataTable dt = GiaoVien_BLL.Timkiem_HoTenGV(txt_HoTenGV.Text.Trim());
                dgv_GiaoVien.DataSource = dt;
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

       /* private void btn_InDanhSach_Click(object sender, EventArgs e)
        {
            GiaoVien.FR_BaoCaoGiaoVien fr = new GiaoVien.FR_BaoCaoGiaoVien();
            fr.Show();
        }*/

        private void rdo_MaGV_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdo_MaGV.Checked)
            {
                cmb_MaGV.Enabled = true;
                txt_HoTenGV.Enabled = false;
                cmb_MaGV.Focus();
                txt_HoTenGV.Clear();
            }
        }

        private void rdo_HoTenGV_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdo_HoTenGV.Checked)
            {
                cmb_MaGV.Enabled = false;
                txt_HoTenGV.Enabled = true;
                cmb_MaGV.SelectedIndex = -1;
                txt_HoTenGV.Focus();
            }
        }

        private void dgv_GiaoVien_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
