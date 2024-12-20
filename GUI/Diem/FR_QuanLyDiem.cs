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
    public partial class FR_QuanLyDiem : Form
    {
        private string taikhoan1;
        public FR_QuanLyDiem(string taiKhoan)
        {
            InitializeComponent();
            this.taikhoan1 = taiKhoan;

            
        }

        private void tab_DiemTP_Click(object sender, EventArgs e)
        {

        }

        private void FR_QuanLyDiem_Load(object sender, EventArgs e)
        {
            if (taikhoan1 == "admin" || taikhoan1 == "ADMIN")
            {
                LoadDataForAdmin();
            }
            else
            {
                LoadDataForUser();
            }

            cmb_MaSV1.Text = "";
            cmb_MaMH1.Text = "";
            nud_DiemTX.ResetText();
            nud_DiemKT1.ResetText();
            nud_DiemKT2.ResetText();
            nud_DiemKT3.ResetText();
            nud_DiemKT4.ResetText();
            nud_DiemKT5.ResetText();
            btn_Luu1.Enabled = false;
            btn_Luu2.Enabled = false;
            btn_Huy1.Enabled = false;
            btn_Huy2.Enabled = false;
            btn_CapNhat1.Enabled = false;
            btn_CapNhat2.Enabled = false;

            cmb_MaMH1.Enabled = false;
            cmb_MaSV1.Enabled = false;
            nud_DiemTX.Enabled = false;
            nud_DiemKT1.Enabled = false;
            nud_DiemKT2.Enabled = false;
            nud_DiemKT3.Enabled = false;
            nud_DiemKT4.Enabled = false;
            nud_DiemKT5.Enabled = false;

            cmb_MaMH2.Enabled = false;
            cmb_MaSV2.Enabled = false;
            nud_DiemThi.Enabled = false;

            cmb_MaMH1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaMH1.SelectedIndex = -1;
            cmb_MaMH2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaMH2.SelectedIndex = -1;
            cmb_MaSV1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaSV1.SelectedIndex = -1;
            cmb_MaSV2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaSV2.SelectedIndex = -1;
        }
        private void LoadDataForAdmin()
        {
            cmb_MaSV1.DataSource = Diem_BLL.Load_MaSV();
            cmb_MaSV1.ValueMember = "masv";
            cmb_MaMH1.DataSource = Diem_BLL.Load_MaMH();
            cmb_MaMH1.ValueMember = "mamh";
            cmb_MaMH2.DataSource = Diem_BLL.Load_MaMH();
            cmb_MaMH2.ValueMember = "mamh";
            cmb_MaSV2.DataSource = Diem_BLL.Load_MaSV();
            cmb_MaSV2.ValueMember = "masv";

            dgv_Diem1.DataSource = Diem_BLL.load_DsDiem();
            dgv_Diem2.DataSource = Diem_BLL.load_DsDiem();

        }
        private void LoadDataForUser()
        {
            cmb_MaMH1.DataSource = MonHoc_BLL.Load_MH_Theo_GV(taikhoan1.Trim());
            cmb_MaMH1.ValueMember = "mamh";
            cmb_MaSV1.DataSource = SinhVien_BLL.Load_SV_Theo_GV(taikhoan1.Trim());
            cmb_MaSV1.ValueMember = "masv";
            cmb_MaMH2.DataSource = MonHoc_BLL.Load_MH_Theo_GV(taikhoan1.Trim());
            cmb_MaMH2.ValueMember = "mamh";
            cmb_MaSV2.DataSource = SinhVien_BLL.Load_SV_Theo_GV(taikhoan1.Trim());
            cmb_MaSV2.ValueMember = "masv";

            dgv_Diem2.DataSource = Diem_BLL.load_ds_DiemSV_theo_magv(taikhoan1.Trim(), cmb_MaMH1.Text);
            dgv_Diem1.DataSource = Diem_BLL.load_ds_DiemSV_theo_magv(taikhoan1.Trim(), cmb_MaMH1.Text);
        }

        int d;
        private void dgv_Diem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cmb_MaMH1.Text = dgv_Diem1.Rows[i].Cells[0].Value.ToString();
            cmb_MaSV1.Text = dgv_Diem1.Rows[i].Cells[1].Value.ToString();
            string DiemTX = dgv_Diem1.Rows[i].Cells[3].Value.ToString();
            nud_DiemTX.Value = decimal.Parse(DiemTX);
            string DiemKT1 = dgv_Diem1.Rows[i].Cells[4].Value.ToString();
            nud_DiemKT1.Value = decimal.Parse(DiemKT1);
            string DiemKT2 = dgv_Diem1.Rows[i].Cells[5].Value.ToString();
            nud_DiemKT2.Value = decimal.Parse(DiemKT2);
            string DiemKT3 = dgv_Diem1.Rows[i].Cells[6].Value.ToString();
            nud_DiemKT3.Value = decimal.Parse(DiemKT3);
            string DiemKT4 = dgv_Diem1.Rows[i].Cells[7].Value.ToString();
            nud_DiemKT4.Value = decimal.Parse(DiemKT4);
            string DiemKT5 = dgv_Diem1.Rows[i].Cells[8].Value.ToString();
            nud_DiemKT5.Value = decimal.Parse(DiemKT5);

            cmb_MaMH1.Enabled = false;
            cmb_MaSV1.Enabled = false;
            nud_DiemTX.Enabled = false;
            nud_DiemKT1.Enabled = false;
            nud_DiemKT2.Enabled = false;
            nud_DiemKT3.Enabled = false;
            nud_DiemKT4.Enabled = false;
            nud_DiemKT5.Enabled = false;
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            cmb_MaSV1.Text = "";
            cmb_MaMH1.Text = "";
            nud_DiemTX.ResetText();
            nud_DiemKT1.ResetText();
            nud_DiemKT2.ResetText();
            nud_DiemKT3.ResetText();
            nud_DiemKT4.ResetText();
            nud_DiemKT5.ResetText();

            cmb_MaMH2.Text = "";
            cmb_MaSV2.Text = "";
            nud_DiemThi.ResetText();
        }
        private void dgv_Diem2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cmb_MaMH2.Text = dgv_Diem2.Rows[i].Cells[0].Value.ToString();
            cmb_MaSV2.Text = dgv_Diem2.Rows[i].Cells[1].Value.ToString();
            string DiemThi = dgv_Diem2.Rows[i].Cells[9].Value.ToString();
            nud_DiemThi.Value = decimal.Parse(DiemThi);
        }

        private int GetSoDauDiemKT(string monHoc)
        {
            DataTable dtMonHoc = MonHoc_BLL.load_dsMonHoc();
            DataRow[] rows = dtMonHoc.Select($"mamh = '{monHoc}'");
            if (rows.Length > 0)
            {
                int soDauDiemKT = Convert.ToInt32(rows[0]["SoDauDiemKT"]);
                return soDauDiemKT;
            }

            return 0;
        }
        private void cmb_MaMH1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_MaMH1.Text!= "")
            {
                int soDauDiemKT = GetSoDauDiemKT(cmb_MaMH1.SelectedValue.ToString());

                if (soDauDiemKT == 1)
                {
                    nud_DiemKT1.Enabled = true;
                    nud_DiemKT2.Enabled = false;
                    nud_DiemKT3.Enabled = false;
                    nud_DiemKT4.Enabled = false;
                    nud_DiemKT5.Enabled = false;

                }
                else if (soDauDiemKT == 2)
                {
                    nud_DiemKT1.Enabled = true;
                    nud_DiemKT2.Enabled = true;
                    nud_DiemKT3.Enabled = false;
                    nud_DiemKT4.Enabled = false;
                    nud_DiemKT5.Enabled = false;
                }
                else if (soDauDiemKT == 3)
                {
                    nud_DiemKT1.Enabled = true;
                    nud_DiemKT2.Enabled = true;
                    nud_DiemKT3.Enabled = true;
                    nud_DiemKT4.Enabled = false;
                    nud_DiemKT5.Enabled = false;
                }
                else if (soDauDiemKT == 4)
                {
                    nud_DiemKT1.Enabled = true;
                    nud_DiemKT2.Enabled = true;
                    nud_DiemKT3.Enabled = true;
                    nud_DiemKT4.Enabled = true;
                    nud_DiemKT5.Enabled = false;
                }
                else if (soDauDiemKT == 5)
                {
                    nud_DiemKT1.Enabled = true;
                    nud_DiemKT2.Enabled = true;
                    nud_DiemKT3.Enabled = true;
                    nud_DiemKT4.Enabled = true;
                    nud_DiemKT5.Enabled = true;
                }
                else
                {
                    nud_DiemKT1.Enabled = false;
                    nud_DiemKT2.Enabled = false;
                    nud_DiemKT3.Enabled = false;
                    nud_DiemKT4.Enabled = false;
                    nud_DiemKT5.Enabled = false;
                }
            }    
        }
        private void btn_Them1_Click(object sender, EventArgs e)
        {
            d = 0;
            btn_Them1.Enabled = false;
            btn_Sua1.Enabled = false;
            btn_Luu1.Enabled = true;
            btn_Huy1.Enabled = true;
            btn_Xoa1.Enabled = false;

            cmb_MaMH1.Enabled = true;
            cmb_MaSV1.Enabled = true;
            nud_DiemTX.Enabled = true;
            nud_DiemKT1.Enabled = true;
            nud_DiemKT2.Enabled = true;
            nud_DiemKT3.Enabled = true;
            nud_DiemKT4.Enabled = true;
            nud_DiemKT5.Enabled = true;
        }

        private void btn_Sua1_Click(object sender, EventArgs e)
        {
            d = 1;
            btn_Them1.Enabled = false;
            btn_Sua1.Enabled = false;
            btn_Luu1.Enabled = true;
            btn_Huy1.Enabled = true;
            btn_Xoa1.Enabled = false;

            cmb_MaMH1.Enabled = true;
            cmb_MaSV1.Enabled = true;
            nud_DiemTX.Enabled = true;
            nud_DiemKT1.Enabled = true;
            nud_DiemKT2.Enabled = true;
            nud_DiemKT3.Enabled = true;
            nud_DiemKT4.Enabled = true;
            nud_DiemKT5.Enabled = true;
        }

        private void btn_Xoa1_Click(object sender, EventArgs e)
        {
            Diem_BLL.xoa_Diem(cmb_MaMH1.Text, cmb_MaSV1.Text);
            if (taikhoan1 == "admin" || taikhoan1 == "ADMIN")
            {
                dgv_Diem1.DataSource = Diem_BLL.load_DsDiem();
                dgv_Diem2.DataSource = Diem_BLL.load_DsDiem();
            }
            else
            {
                dgv_Diem1.DataSource = Diem_BLL.load_ds_DiemSV_theo_magv(taikhoan1.Trim(), cmb_MaMH1.Text);
                dgv_Diem2.DataSource = Diem_BLL.load_ds_DiemSV_theo_magv(taikhoan1.Trim(), cmb_MaMH1.Text);
            }
            cmb_MaMH1.Text = "";
            cmb_MaSV1.Text = "";

            nud_DiemTX.ResetText();
            nud_DiemKT1.ResetText();
            nud_DiemKT2.ResetText();
            nud_DiemKT3.ResetText();
            nud_DiemKT4.ResetText();
            nud_DiemKT5.ResetText();
        }

        private void btn_CapNhat1_Click(object sender, EventArgs e)
        {
            Diem_BLL.CapNhat_DiemThanhPhan();
            if (taikhoan1 == "admin" || taikhoan1 == "ADMIN")
            {
                dgv_Diem1.DataSource = Diem_BLL.load_DsDiem();
                dgv_Diem2.DataSource = Diem_BLL.load_DsDiem();

            }
            else
            {
                dgv_Diem1.DataSource = Diem_BLL.load_ds_DiemSV_theo_magv(taikhoan1.Trim(), cmb_MaMH1.Text);
                dgv_Diem2.DataSource = Diem_BLL.load_ds_DiemSV_theo_magv(taikhoan1.Trim(), cmb_MaMH1.Text);

            }
            btn_CapNhat1.Enabled = false;
        }

        private void btn_Luu1_Click(object sender, EventArgs e)
        {
            string DiemTX = ((float)nud_DiemTX.Value).ToString();
            string DiemKT1 = ((float)nud_DiemKT1.Value).ToString();
            string DiemKT2 = ((float)nud_DiemKT2.Value).ToString();
            string DiemKT3 = ((float)nud_DiemKT3.Value).ToString();
            string DiemKT4 = ((float)nud_DiemKT4.Value).ToString();
            string DiemKT5 = ((float)nud_DiemKT5.Value).ToString();

            if(cmb_MaMH1.Text==""||cmb_MaSV1.Text=="")
            {
                MessageBox.Show("Bạn hãy nhập 2 trường Mã MH và Mã SV đi");
            }    
            else
            {
                if (d == 0)
                {
                    DiemThanhPhan_DTO Dm = new DiemThanhPhan_DTO((cmb_MaMH1.Text), (cmb_MaSV1.Text), DiemTX, DiemKT1, DiemKT2, DiemKT3, DiemKT4, DiemKT5);
                    Diem_BLL DiemBLL = new Diem_BLL();
                    bool isPhanCongValid = DiemBLL.check_TrungThemDiem(Dm);

                    if (isPhanCongValid)
                    {
                        MessageBox.Show("Sinh Viên này đã được thêm điểm");
                    }
                    else
                    {
                        int fieldValue = 0;
                        if (!string.IsNullOrEmpty(DiemTX)) int.TryParse(DiemTX, out fieldValue);
                        if (!string.IsNullOrEmpty(DiemKT1)) int.TryParse(DiemKT1, out fieldValue);
                        if (!string.IsNullOrEmpty(DiemKT2)) int.TryParse(DiemKT2, out fieldValue);
                        if (!string.IsNullOrEmpty(DiemKT3)) int.TryParse(DiemKT3, out fieldValue);
                        if (!string.IsNullOrEmpty(DiemKT4)) int.TryParse(DiemKT4, out fieldValue);
                        if (!string.IsNullOrEmpty(DiemKT5)) int.TryParse(DiemKT5, out fieldValue);

                        DiemThanhPhan_DTO Dm1 = new DiemThanhPhan_DTO((cmb_MaMH1.Text), (cmb_MaSV1.Text), DiemTX, DiemKT1, DiemKT2, DiemKT3, DiemKT4, DiemKT5);
                        Diem_BLL.them_DiemThanhPhan(Dm1);
                        if (taikhoan1 == "admin" || taikhoan1 == "ADMIN")
                        {
                            dgv_Diem1.DataSource = Diem_BLL.load_DsDiem();
                            dgv_Diem2.DataSource = Diem_BLL.load_DsDiem();
                        }
                        else
                        {
                            dgv_Diem1.DataSource = Diem_BLL.load_ds_DiemSV_theo_magv(taikhoan1.Trim(), cmb_MaMH1.Text);
                            dgv_Diem2.DataSource = Diem_BLL.load_ds_DiemSV_theo_magv(taikhoan1.Trim(), cmb_MaMH1.Text);
                        }
                        //dgv_Diem1.DataSource = Diem_BLL.load_DsDiem();
                        //dgv_Diem2.DataSource = Diem_BLL.load_DsDiem();
                    }
                }
                else if (d == 1)
                {
                    DiemThanhPhan_DTO Dm = new DiemThanhPhan_DTO((cmb_MaMH1.Text), (cmb_MaSV1.Text), DiemTX, DiemKT1, DiemKT2, DiemKT3, DiemKT4, DiemKT5);
                    Diem_BLL.sua_DiemThanhPhan(Dm);
                    if (taikhoan1 == "admin" || taikhoan1 == "ADMIN")
                    {
                        dgv_Diem1.DataSource = Diem_BLL.load_DsDiem();
                        dgv_Diem2.DataSource = Diem_BLL.load_DsDiem();
                    }
                    else
                    {
                        dgv_Diem1.DataSource = Diem_BLL.load_ds_DiemSV_theo_magv(taikhoan1.Trim(), cmb_MaMH1.Text);
                        dgv_Diem2.DataSource = Diem_BLL.load_ds_DiemSV_theo_magv(taikhoan1.Trim(), cmb_MaMH1.Text);
                    }
                }
            }    
            
            btn_Them1.Enabled = true;
            btn_Sua1.Enabled = true;
            btn_Luu1.Enabled = false;
            btn_Huy1.Enabled = false;
            btn_CapNhat1.Enabled = true;
            btn_Xoa1.Enabled = true;

            cmb_MaMH1.Enabled = false;
            cmb_MaSV1.Enabled = false;
            nud_DiemTX.Enabled = false;
            nud_DiemKT1.Enabled = false;
            nud_DiemKT2.Enabled = false;
            nud_DiemKT3.Enabled = false;
            nud_DiemKT4.Enabled = false;
            nud_DiemKT5.Enabled = false;
        }

        private void btn_Huy1_Click(object sender, EventArgs e)
        {
            btn_Them1.Enabled = true;
            btn_Sua1.Enabled = true;
            btn_Xoa1.Enabled = true;
            btn_Luu1.Enabled = false;
            btn_Huy1.Enabled = false;
            cmb_MaMH1.Text = "";
            cmb_MaSV1.Text = "";

            cmb_MaMH1.SelectedIndex = -1;
            cmb_MaSV1.SelectedIndex = -1;
            nud_DiemTX.ResetText();
            nud_DiemKT1.ResetText();
            nud_DiemKT2.ResetText();
            nud_DiemKT3.ResetText();
            nud_DiemKT4.ResetText();
            nud_DiemKT5.ResetText();

            cmb_MaMH1.Enabled = false;
            cmb_MaSV1.Enabled = false;
            nud_DiemTX.Enabled = false;
            nud_DiemKT1.Enabled = false;
            nud_DiemKT2.Enabled = false;
            nud_DiemKT3.Enabled = false;
            nud_DiemKT4.Enabled = false;
            nud_DiemKT5.Enabled = false;
        }

        private void btn_Thoat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them2_Click(object sender, EventArgs e)
        {
            d = 2;
            btn_Them2.Enabled = false;
            btn_Sua2.Enabled = false;
            btn_Luu2.Enabled = true;
            btn_Huy2.Enabled = true;
            btn_Xoa2.Enabled = false;

            cmb_MaMH2.Enabled = true;
            cmb_MaSV2.Enabled = true;
            nud_DiemThi.Enabled = true;
        }

        private void btn_Sua2_Click(object sender, EventArgs e)
        {
            d = 3;
            btn_Them2.Enabled = false;
            btn_Sua2.Enabled = false;
            btn_Luu2.Enabled = true;
            btn_Huy2.Enabled = true;
            btn_Xoa2.Enabled = false;

            nud_DiemTX.ResetText();
            nud_DiemKT1.ResetText();
            nud_DiemKT2.ResetText();
            nud_DiemKT3.ResetText();
            nud_DiemKT4.ResetText();
            nud_DiemKT5.ResetText();

            cmb_MaMH2.Enabled = true;
            cmb_MaSV2.Enabled = true;
            nud_DiemThi.Enabled = true;
        }

        private void btn_Xoa2_Click(object sender, EventArgs e)
        {
            string DiemThi = ((float)nud_DiemThi.Value).ToString();
            DiemThi_DTO Dm = new DiemThi_DTO(cmb_MaMH2.Text, cmb_MaSV2.Text, DiemThi);
            Diem_BLL.Xoa_DiemThi(Dm);
            //dgv_Diem2.DataSource = Diem_BLL.load_DsDiem();
            if (taikhoan1 == "admin" || taikhoan1 == "ADMIN")
            {
                dgv_Diem1.DataSource = Diem_BLL.load_DsDiem();
                dgv_Diem2.DataSource = Diem_BLL.load_DsDiem();
            }
            else
            {
                dgv_Diem1.DataSource = Diem_BLL.load_ds_DiemSV_theo_magv(taikhoan1.Trim(), cmb_MaMH2.Text);
                dgv_Diem2.DataSource = Diem_BLL.load_ds_DiemSV_theo_magv(taikhoan1.Trim(), cmb_MaMH2.Text);
            }
        }

        private void btn_CapNhat2_Click(object sender, EventArgs e)
        {
            Diem_BLL.CapNhat_DiemTongKet();
            if (taikhoan1 == "admin" || taikhoan1 == "ADMIN")
            {
                dgv_Diem1.DataSource = Diem_BLL.load_DsDiem();
                dgv_Diem2.DataSource = Diem_BLL.load_DsDiem();
            }
            else
            {
                dgv_Diem1.DataSource = Diem_BLL.load_ds_DiemSV_theo_magv(taikhoan1.Trim(), cmb_MaMH2.Text);
                dgv_Diem2.DataSource = Diem_BLL.load_ds_DiemSV_theo_magv(taikhoan1.Trim(), cmb_MaMH2.Text);
            }
            //dgv_Diem2.DataSource = Diem_BLL.load_DsDiem();
            btn_CapNhat2.Enabled = false;
        }

        private void btn_Luu2_Click(object sender, EventArgs e)
        {
            string DiemThi = ((float)nud_DiemThi.Value).ToString();
            
            if(cmb_MaMH2.Text=="" || cmb_MaSV2.Text==""|| DiemThi =="")
            {
                MessageBox.Show("Bạn hãy nhập đủ các trường đi");
            }    
            else
            {
                if (d == 2 || d == 3)
                {
                    DataTable dt = Diem_BLL.check_Hoc_Lai(cmb_MaMH2.Text.Trim(), cmb_MaSV2.Text.Trim());
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        string ghichu = dt.Rows[0]["ghichu"].ToString().Trim();
                        if (ghichu == "HL")
                        {
                            MessageBox.Show("Lỗi: Sinh viên" + cmb_MaSV2.Text + " phải học lại môn " + cmb_MaMH2.Text);
                        }
                        else
                        {
                            DiemThi_DTO Dm = new DiemThi_DTO(cmb_MaMH2.Text, cmb_MaSV2.Text, DiemThi);
                            Diem_BLL.them_sua_DiemThi(Dm);
                            if (taikhoan1 == "admin" || taikhoan1 == "ADMIN")
                            {
                                dgv_Diem1.DataSource = Diem_BLL.load_DsDiem();
                                dgv_Diem2.DataSource = Diem_BLL.load_DsDiem();
                            }
                            else
                            {
                                dgv_Diem1.DataSource = Diem_BLL.load_ds_DiemSV_theo_magv(taikhoan1.Trim(), cmb_MaMH2.Text);
                                dgv_Diem2.DataSource = Diem_BLL.load_ds_DiemSV_theo_magv(taikhoan1.Trim(), cmb_MaMH2.Text);
                            }
                            //dgv_Diem2.DataSource = Diem_BLL.load_DsDiem();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sinh Viên " + cmb_MaSV2.Text + " chưa được thêm điểm thành phần của môn " + cmb_MaMH2.Text);
                    }
                }
            }
            btn_Them2.Enabled = true;
            btn_Sua2.Enabled = true;
            btn_Xoa2.Enabled = true;
            btn_CapNhat2.Enabled = true;
            btn_Luu2.Enabled = false;
            btn_Huy2.Enabled = false;

            cmb_MaMH2.Enabled = false;
            cmb_MaSV2.Enabled = false;
            nud_DiemThi.Enabled = false;
        }

        private void btn_Huy2_Click(object sender, EventArgs e)
        {
            btn_Them2.Enabled = true;
            btn_Sua2.Enabled = true;
            btn_Xoa2.Enabled = true;
            btn_Luu2.Enabled = false;
            btn_Huy2.Enabled = false;
            cmb_MaMH2.Text = "";
            cmb_MaSV2.Text = "";
            nud_DiemThi.ResetText();

            cmb_MaMH2.SelectedIndex = -1;
            cmb_MaSV2.SelectedIndex = -1;
            cmb_MaMH2.Enabled = false;
            cmb_MaSV2.Enabled = false;
            nud_DiemThi.Enabled = false;
        }

        private void btn_Thoat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Diem1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tab_DiemKT_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Diem2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cmb_MaMH2.Text = dgv_Diem2.Rows[i].Cells[0].Value.ToString();
            cmb_MaSV2.Text = dgv_Diem2.Rows[i].Cells[1].Value.ToString();
            string DiemThi = dgv_Diem2.Rows[i].Cells[10].Value.ToString();
            nud_DiemThi.Value = decimal.Parse(DiemThi);
        }

        private void dgv_Diem1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgv_Diem2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
