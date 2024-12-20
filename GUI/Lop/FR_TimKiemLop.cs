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
    public partial class FR_SrearchClass : Form
    {
        public FR_SrearchClass()
        {
            InitializeComponent();
        }

        private void FR_TimKiemLop_Load(object sender, EventArgs e)
        {
            cmb_MaLop.DataSource = Lop_BLL.load_MaLop();
            cmb_MaLop.ValueMember = "malop";

            rdo_MaLop.Checked = false;
            rdo_TenLop.Checked = false;
            cmb_MaLop.Enabled = false;
            txt_TenLop.Clear();
            txt_TenLop.Enabled = false;
            cmb_MaLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaLop.SelectedIndex = -1;
        }

        private void rdo_MaLop_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_MaLop.Checked)
            {
                cmb_MaLop.Enabled = true;
                txt_TenLop.Enabled = false;
                cmb_MaLop.Focus();
                txt_TenLop.Clear();
            }
        }

        private void rdo_TenLop_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_TenLop.Checked)
            {
                cmb_MaLop.Enabled = false;
                txt_TenLop.Enabled = true;
                txt_TenLop.Focus();
                cmb_MaLop.SelectedIndex = -1;
            }
        }


        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {
            if (rdo_MaLop.Checked == true)
            {
                DataTable dt = Lop_BLL.Timkiem_MaLop(cmb_MaLop.Text.Trim());
                dgv_Lop.DataSource = dt;
            }
            else if (rdo_TenLop.Checked)
            {

                DataTable dt = Lop_BLL.Timkiem_TenKhoa(txt_TenLop.Text.Trim());
                dgv_Lop.DataSource = dt;
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

        private void dgv_Lop_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
