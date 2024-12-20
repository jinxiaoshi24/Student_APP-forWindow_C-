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

namespace GUI.Account
{
    public partial class FR_TimKiemAccount : Form
    {
        public FR_TimKiemAccount()
        {
            InitializeComponent();
        }

        private void FR_TimKiemAccount_Load(object sender, EventArgs e)
        {
            cmb_TaiKhoan.DataSource = Account_BLL.Get_MaTK();
            cmb_TaiKhoan.ValueMember = "taikhoan";

            cmb_TypeUser.DataSource = Account_BLL.GetAllTypeUser();
            cmb_TypeUser.ValueMember = "type_user";

            rdo_TaiKhoan.Checked = false;
            rdo_TypeUser.Checked = false;
            cmb_TaiKhoan.Text = "";
            cmb_TypeUser.Text = "";
            cmb_TaiKhoan.Enabled = false;
            cmb_TypeUser.Enabled = false;

            cmb_TaiKhoan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_TaiKhoan.SelectedIndex = -1;

            cmb_TypeUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_TypeUser.SelectedIndex = -1;
        }


        private void rdo_TaiKhoan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_TaiKhoan.Checked)
            {
                cmb_TaiKhoan.Enabled = true;
                cmb_TypeUser.Enabled = false;
                cmb_TypeUser.SelectedIndex = -1;
                cmb_TaiKhoan.Focus();
            }
        }

        private void rdo_TypeUser_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_TypeUser.Checked)
            {
                cmb_TaiKhoan.Enabled = false;
                cmb_TypeUser.Enabled = true;
                cmb_TaiKhoan.SelectedIndex = -1;
                cmb_TypeUser.Focus();
            }
        }
        private void btn_TimKiem_Click_2(object sender, EventArgs e)
        {
    
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (rdo_TaiKhoan.Checked == true)
            {
                //DataTable dt = Account_BLL.Timkiem_MaTK(cmb_MaTK.Text.Trim());
                //dgv_Account.DataSource = dt;
                dgv_Account.DataSource = Account_BLL.Timkiem_TaiKhoan(cmb_TaiKhoan.Text.Trim());
            }
            else if (rdo_TaiKhoan.Checked)
            {
                //DataTable dt = Account_BLL.Timkiem_TaiKhoan(txt_TaiKhoan.Text.Trim());
                //dgv_Account.DataSource = dt;
                dgv_Account.DataSource = Account_BLL.Timkiem_TaiKhoan(cmb_TaiKhoan.Text.Trim());
            }
            else if (rdo_TypeUser.Checked)
            {

                //DataTable dt = Account_BLL.Timkiem_TypeUser(cmb_TypeUser.Text.Trim());
                //dgv_Account.DataSource = dt;
                dgv_Account.DataSource = Account_BLL.Timkiem_TypeUser(cmb_TypeUser.Text.Trim());
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

        private void dgv_Account_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }


    }
}
