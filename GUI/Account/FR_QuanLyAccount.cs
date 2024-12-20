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
    public partial class FR_ManagmentAccount : Form
    {
        public FR_ManagmentAccount()
        {
            InitializeComponent();
        }

        private void FR_QuanLyAccount_Load(object sender, EventArgs e)
        {
            //Đổ dư liệu
            DataTable dt = Account_BLL.GetListAccount();
            dgv_Account.DataSource = dt;

            //anh xa dụ lieu len TypeUser
            cmb_TypeUser.DataSource = Account_BLL.GetAllTypeUser();
            cmb_TypeUser.ValueMember = "type_user";

            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
            txt_TaiKhoan.Enabled = false;
            txt_TaiKhoan.Clear();

            txt_TaiKhoan.Enabled = false;
            txt_Pass.Enabled = false;
            cmb_TypeUser.Enabled = false;
            cmb_TypeUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_TypeUser.SelectedIndex = -1;
            //cmb_TypeUser.Text = "";
        }

        private void cmb_TypeUser_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (d==0)
            {
                if (cmb_TypeUser.Text.Trim() == "admin")
                {
                    DataTable dt1 = Account_BLL.tang_TaiKhoanAdmin();
                    string Type_Admin = dt1.Rows[0][0].ToString();
                    int Type_Admin_Int = int.Parse(Type_Admin);
                    if (Type_Admin_Int < 10)
                    {
                        txt_TaiKhoan.Text = "admin0" + Type_Admin;
                    }
                    else
                    {
                        txt_TaiKhoan.Text = "admin" + Type_Admin;
                    }
                }
                else if (cmb_TypeUser.Text.Trim() == "SV")
                {
                    DataTable dt2 = Account_BLL.tang_TaiKhoanSV();
                    string Type_SV = dt2.Rows[0][0].ToString();
                    int Type_SV_Int = int.Parse(Type_SV);
                    if (Type_SV_Int < 10)
                    {
                        txt_TaiKhoan.Text = "SV0" + Type_SV_Int;
                    }
                    else
                    {
                        txt_TaiKhoan.Text = "SV" + Type_SV_Int;
                    }
                }
                else if (cmb_TypeUser.Text.Trim() == "GV")
                {
                    DataTable dt3 = Account_BLL.GetTaiKhoanGV();
                    string Type_GV = dt3.Rows[0][0].ToString();
                    int Type_GV_Int = int.Parse(Type_GV);
                    if (Type_GV_Int < 10)
                    {
                        txt_TaiKhoan.Text = "GV0" + Type_GV_Int;
                    }
                    else
                    {
                        txt_TaiKhoan.Text = "GV" + Type_GV_Int;
                    }
                }
                else
                {
                    txt_TaiKhoan.Clear();
                }
            }
        }
        int d;
        private void dgv_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_TaiKhoan.Text = dgv_Account.Rows[i].Cells[0].Value.ToString();
            txt_Pass.Text = dgv_Account.Rows[i].Cells[1].Value.ToString();
            cmb_TypeUser.Text = dgv_Account.Rows[i].Cells[2].Value.ToString();
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            d = 0;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            btn_Xoa.Enabled = false;
            txt_Pass.Focus();

            txt_Pass.Enabled = true;
            cmb_TypeUser.Enabled = true;
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            d = 1;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            btn_Xoa.Enabled = false;

            txt_Pass.Enabled = true;
            cmb_TypeUser.Enabled = true;
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            Account_BLL.Update_TaiKhoan_Bang_GV(txt_TaiKhoan.Text);
            Account_BLL.Update_TaiKhoan_Bang_SV(txt_TaiKhoan.Text);
            Account_BLL.xoa_Account(txt_TaiKhoan.Text);
            dgv_Account.DataSource = Account_BLL.GetListAccount();
            txt_TaiKhoan.Clear();
            txt_Pass.Clear();
            cmb_TypeUser.Text = "";
        }

        private void btn_Luu_Click_1(object sender, EventArgs e)
        {
            if (txt_TaiKhoan.Text == "" || cmb_TypeUser.Text == "")
            {
                MessageBox.Show("Bạn hãy nhập đủ thông tin ở trường Tài Khoản và Type User đi");
            }
            else
            {
                if (d == 0)
                {
                    DataTable dt = Account_BLL.Timkiem_TaiKhoan(txt_TaiKhoan.Text);
                    if (dt.Rows.Count > 0) MessageBox.Show("Tài khoản này đã được thêm hãy nhập Tài Khoản khác đi");
                    else
                    {
                        if (txt_Pass.Text == "")
                        {
                            txt_Pass.Text = "123";
                            Account_DTO tk = new Account_DTO((txt_TaiKhoan.Text), (txt_Pass.Text), (cmb_TypeUser.Text));
                            Account_BLL.them_Account(tk);
                            dgv_Account.DataSource = Account_BLL.GetListAccount();

                            btn_Them.Enabled = true;
                            btn_Sua.Enabled = true;
                            btn_Luu.Enabled = false;
                            btn_Xoa.Enabled = true;
                            btn_Huy.Enabled = false;
                        }
                        else
                        {
                            Account_DTO tk = new Account_DTO((txt_TaiKhoan.Text), (txt_Pass.Text), (cmb_TypeUser.Text));
                            Account_BLL.them_Account(tk);
                            dgv_Account.DataSource = Account_BLL.GetListAccount();

                            btn_Them.Enabled = true;
                            btn_Sua.Enabled = true;
                            btn_Luu.Enabled = false;
                            btn_Xoa.Enabled = true;
                            btn_Huy.Enabled = false;
                        }
                    }
                }
                else
                {
                    Account_DTO tk = new Account_DTO((txt_TaiKhoan.Text), (txt_Pass.Text), (cmb_TypeUser.Text));
                    Account_BLL.sua_Account(tk);
                    dgv_Account.DataSource = Account_BLL.GetListAccount();
                    btn_Them.Enabled = true;
                    btn_Sua.Enabled = true;
                    btn_Luu.Enabled = false;
                    btn_Xoa.Enabled = true;
                    btn_Huy.Enabled = false;

                }
            }
            txt_Pass.Enabled = false;
            cmb_TypeUser.Enabled = false;
        }

        private void btn_Huy_Click_1(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = false;
            btn_Xoa.Enabled = true;
            txt_TaiKhoan.Clear();
            txt_Pass.Clear();
            cmb_TypeUser.Text = "";
            btn_Huy.Enabled = false;

            txt_Pass.Enabled = false;
            cmb_TypeUser.Enabled = false;
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
