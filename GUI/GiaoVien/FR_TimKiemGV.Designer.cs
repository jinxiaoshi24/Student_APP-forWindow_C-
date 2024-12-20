
namespace GUI.GiaoVien
{
    partial class FR_TimKiemGV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_TimKiemGV));
            this.dgv_GiaoVien = new System.Windows.Forms.DataGridView();
            this.magv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotengv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_MaGV = new System.Windows.Forms.ComboBox();
            this.txt_HoTenGV = new System.Windows.Forms.TextBox();
            this.rdo_HoTenGV = new System.Windows.Forms.RadioButton();
            this.rdo_MaGV = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_InDanhSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiaoVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_GiaoVien
            // 
            this.dgv_GiaoVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_GiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magv,
            this.hotengv,
            this.ngaysinh,
            this.gioitinh,
            this.diachi,
            this.sdt,
            this.taikhoan,
            this.makhoa});
            this.dgv_GiaoVien.Location = new System.Drawing.Point(69, 204);
            this.dgv_GiaoVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_GiaoVien.Name = "dgv_GiaoVien";
            this.dgv_GiaoVien.RowHeadersWidth = 51;
            this.dgv_GiaoVien.RowTemplate.Height = 24;
            this.dgv_GiaoVien.Size = new System.Drawing.Size(848, 271);
            this.dgv_GiaoVien.TabIndex = 4;
            this.dgv_GiaoVien.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_GiaoVien_CellBeginEdit);
            // 
            // magv
            // 
            this.magv.DataPropertyName = "magv";
            this.magv.HeaderText = "Mã GV";
            this.magv.MinimumWidth = 80;
            this.magv.Name = "magv";
            this.magv.Width = 80;
            // 
            // hotengv
            // 
            this.hotengv.DataPropertyName = "hotengv";
            this.hotengv.HeaderText = "Họ Tên GV";
            this.hotengv.MinimumWidth = 130;
            this.hotengv.Name = "hotengv";
            this.hotengv.Width = 130;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.MinimumWidth = 100;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 101;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.MinimumWidth = 100;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 101;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.MinimumWidth = 100;
            this.diachi.Name = "diachi";
            this.diachi.Width = 101;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "SĐT";
            this.sdt.MinimumWidth = 80;
            this.sdt.Name = "sdt";
            this.sdt.Width = 80;
            // 
            // taikhoan
            // 
            this.taikhoan.DataPropertyName = "taikhoan";
            this.taikhoan.HeaderText = "Tài Khoản";
            this.taikhoan.MinimumWidth = 100;
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Width = 101;
            // 
            // makhoa
            // 
            this.makhoa.DataPropertyName = "makhoa";
            this.makhoa.HeaderText = "Mã Khoa";
            this.makhoa.MinimumWidth = 100;
            this.makhoa.Name = "makhoa";
            this.makhoa.Width = 101;
            // 
            // cmb_MaGV
            // 
            this.cmb_MaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaGV.FormattingEnabled = true;
            this.cmb_MaGV.Location = new System.Drawing.Point(27, 49);
            this.cmb_MaGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_MaGV.Name = "cmb_MaGV";
            this.cmb_MaGV.Size = new System.Drawing.Size(264, 28);
            this.cmb_MaGV.TabIndex = 1;
            // 
            // txt_HoTenGV
            // 
            this.txt_HoTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTenGV.Location = new System.Drawing.Point(27, 128);
            this.txt_HoTenGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_HoTenGV.Name = "txt_HoTenGV";
            this.txt_HoTenGV.Size = new System.Drawing.Size(264, 26);
            this.txt_HoTenGV.TabIndex = 3;
            // 
            // rdo_HoTenGV
            // 
            this.rdo_HoTenGV.AutoSize = true;
            this.rdo_HoTenGV.BackColor = System.Drawing.Color.Transparent;
            this.rdo_HoTenGV.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_HoTenGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdo_HoTenGV.Location = new System.Drawing.Point(27, 99);
            this.rdo_HoTenGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_HoTenGV.Name = "rdo_HoTenGV";
            this.rdo_HoTenGV.Size = new System.Drawing.Size(99, 23);
            this.rdo_HoTenGV.TabIndex = 2;
            this.rdo_HoTenGV.Text = "Họ Tên GV";
            this.rdo_HoTenGV.UseVisualStyleBackColor = false;
            this.rdo_HoTenGV.CheckedChanged += new System.EventHandler(this.rdo_HoTenGV_CheckedChanged_1);
            // 
            // rdo_MaGV
            // 
            this.rdo_MaGV.AutoSize = true;
            this.rdo_MaGV.BackColor = System.Drawing.Color.Transparent;
            this.rdo_MaGV.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_MaGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdo_MaGV.Location = new System.Drawing.Point(27, 20);
            this.rdo_MaGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_MaGV.Name = "rdo_MaGV";
            this.rdo_MaGV.Size = new System.Drawing.Size(71, 23);
            this.rdo_MaGV.TabIndex = 0;
            this.rdo_MaGV.Text = "Mã GV";
            this.rdo_MaGV.UseVisualStyleBackColor = false;
            this.rdo_MaGV.CheckedChanged += new System.EventHandler(this.rdo_MaGV_CheckedChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.cmb_MaGV);
            this.groupBox1.Controls.Add(this.txt_HoTenGV);
            this.groupBox1.Controls.Add(this.rdo_HoTenGV);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.rdo_MaGV);
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(69, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu Chí";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(405, 106);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Thoat.Size = new System.Drawing.Size(108, 48);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(405, 37);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_TimKiem.Size = new System.Drawing.Size(108, 51);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_InDanhSach
            // 
            this.btn_InDanhSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_InDanhSach.BackColor = System.Drawing.Color.White;
            this.btn_InDanhSach.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_InDanhSach.Image = ((System.Drawing.Image)(resources.GetObject("btn_InDanhSach.Image")));
            this.btn_InDanhSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InDanhSach.Location = new System.Drawing.Point(705, 75);
            this.btn_InDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_InDanhSach.Name = "btn_InDanhSach";
            this.btn_InDanhSach.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_InDanhSach.Size = new System.Drawing.Size(161, 59);
            this.btn_InDanhSach.TabIndex = 3;
            this.btn_InDanhSach.Text = "Print This List";
            this.btn_InDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_InDanhSach.UseVisualStyleBackColor = false;
            // 
            // FR_TimKiemGV
            // 
            this.AcceptButton = this.btn_TimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(973, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_GiaoVien);
            this.Controls.Add(this.btn_InDanhSach);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(869, 514);
            this.Name = "FR_TimKiemGV";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm Kiếm Giáo Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FR_TimKiemGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiaoVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_InDanhSach;
        private System.Windows.Forms.DataGridView dgv_GiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn magv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotengv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoa;
        private System.Windows.Forms.ComboBox cmb_MaGV;
        private System.Windows.Forms.TextBox txt_HoTenGV;
        private System.Windows.Forms.RadioButton rdo_HoTenGV;
        private System.Windows.Forms.RadioButton rdo_MaGV;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}