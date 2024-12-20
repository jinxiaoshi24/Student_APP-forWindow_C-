
namespace GUI.SinhVien
{
    partial class FR_TimKiemSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_TimKiemSV));
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_HoTenSV = new System.Windows.Forms.TextBox();
            this.cmb_MaSV = new System.Windows.Forms.ComboBox();
            this.rdo_HoTenSV = new System.Windows.Forms.RadioButton();
            this.rdo_MaSV = new System.Windows.Forms.RadioButton();
            this.dgv_SinhVien = new System.Windows.Forms.DataGridView();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(715, 86);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Thoat.Size = new System.Drawing.Size(144, 50);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(715, 15);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_TimKiem.Size = new System.Drawing.Size(144, 50);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_HoTenSV
            // 
            this.txt_HoTenSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_HoTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTenSV.Location = new System.Drawing.Point(394, 86);
            this.txt_HoTenSV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_HoTenSV.Multiline = true;
            this.txt_HoTenSV.Name = "txt_HoTenSV";
            this.txt_HoTenSV.Size = new System.Drawing.Size(278, 27);
            this.txt_HoTenSV.TabIndex = 3;
            // 
            // cmb_MaSV
            // 
            this.cmb_MaSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_MaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaSV.FormattingEnabled = true;
            this.cmb_MaSV.Location = new System.Drawing.Point(394, 28);
            this.cmb_MaSV.Name = "cmb_MaSV";
            this.cmb_MaSV.Size = new System.Drawing.Size(278, 28);
            this.cmb_MaSV.TabIndex = 1;
            // 
            // rdo_HoTenSV
            // 
            this.rdo_HoTenSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdo_HoTenSV.AutoSize = true;
            this.rdo_HoTenSV.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_HoTenSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdo_HoTenSV.Location = new System.Drawing.Point(202, 90);
            this.rdo_HoTenSV.Name = "rdo_HoTenSV";
            this.rdo_HoTenSV.Size = new System.Drawing.Size(147, 23);
            this.rdo_HoTenSV.TabIndex = 2;
            this.rdo_HoTenSV.Text = "Họ Tên Sinh Viên";
            this.rdo_HoTenSV.UseVisualStyleBackColor = true;
            this.rdo_HoTenSV.CheckedChanged += new System.EventHandler(this.rdo_HoTenSV_CheckedChanged_1);
            // 
            // rdo_MaSV
            // 
            this.rdo_MaSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdo_MaSV.AutoSize = true;
            this.rdo_MaSV.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_MaSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdo_MaSV.Location = new System.Drawing.Point(202, 29);
            this.rdo_MaSV.Name = "rdo_MaSV";
            this.rdo_MaSV.Size = new System.Drawing.Size(119, 23);
            this.rdo_MaSV.TabIndex = 0;
            this.rdo_MaSV.Text = "Mã Sinh Viên";
            this.rdo_MaSV.UseVisualStyleBackColor = true;
            this.rdo_MaSV.CheckedChanged += new System.EventHandler(this.rdo_MaSV_CheckedChanged_1);
            // 
            // dgv_SinhVien
            // 
            this.dgv_SinhVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masv,
            this.hotensv,
            this.ngaysinh,
            this.gioitinh,
            this.diachi,
            this.sdt,
            this.taikhoan,
            this.malop});
            this.dgv_SinhVien.Location = new System.Drawing.Point(115, 187);
            this.dgv_SinhVien.Name = "dgv_SinhVien";
            this.dgv_SinhVien.RowHeadersWidth = 51;
            this.dgv_SinhVien.RowTemplate.Height = 24;
            this.dgv_SinhVien.Size = new System.Drawing.Size(932, 292);
            this.dgv_SinhVien.TabIndex = 3;
            this.dgv_SinhVien.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_SinhVien_CellBeginEdit);
            // 
            // masv
            // 
            this.masv.DataPropertyName = "masv";
            this.masv.HeaderText = "Mã SV";
            this.masv.MinimumWidth = 100;
            this.masv.Name = "masv";
            this.masv.Width = 125;
            // 
            // hotensv
            // 
            this.hotensv.DataPropertyName = "hotensv";
            this.hotensv.HeaderText = "Họ Tên SV";
            this.hotensv.MinimumWidth = 125;
            this.hotensv.Name = "hotensv";
            this.hotensv.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.MinimumWidth = 115;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 115;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.MinimumWidth = 110;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 110;
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
            this.taikhoan.MinimumWidth = 120;
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Width = 120;
            // 
            // malop
            // 
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "Mã Lớp";
            this.malop.MinimumWidth = 100;
            this.malop.Name = "malop";
            this.malop.Width = 101;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.txt_HoTenSV);
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.rdo_HoTenSV);
            this.panel1.Controls.Add(this.rdo_MaSV);
            this.panel1.Controls.Add(this.cmb_MaSV);
            this.panel1.Location = new System.Drawing.Point(124, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 158);
            this.panel1.TabIndex = 4;
            // 
            // FR_TimKiemSV
            // 
            this.AcceptButton = this.btn_TimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(1158, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_SinhVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FR_TimKiemSV";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm Kiếm Sinh Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FR_TimKiemSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_HoTenSV;
        private System.Windows.Forms.ComboBox cmb_MaSV;
        private System.Windows.Forms.RadioButton rdo_HoTenSV;
        private System.Windows.Forms.RadioButton rdo_MaSV;
        private System.Windows.Forms.DataGridView dgv_SinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.Panel panel1;
    }
}