
namespace GUI.Diem
{
    partial class FR_TimKiemDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_TimKiemDiem));
            this.cmb_MaMH = new System.Windows.Forms.ComboBox();
            this.rdo_MaSV = new System.Windows.Forms.RadioButton();
            this.rdo_MaMH = new System.Windows.Forms.RadioButton();
            this.cmb_MaSV = new System.Windows.Forms.ComboBox();
            this.dgv_Diem = new System.Windows.Forms.DataGridView();
            this.mamh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemthuongxuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemkt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemkt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemkt3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemkt4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemkt5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbdiemthanhphan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemtongket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quamon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Diem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_MaMH
            // 
            this.cmb_MaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaMH.FormattingEnabled = true;
            this.cmb_MaMH.Location = new System.Drawing.Point(28, 52);
            this.cmb_MaMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_MaMH.Name = "cmb_MaMH";
            this.cmb_MaMH.Size = new System.Drawing.Size(281, 28);
            this.cmb_MaMH.TabIndex = 1;
            // 
            // rdo_MaSV
            // 
            this.rdo_MaSV.AutoSize = true;
            this.rdo_MaSV.BackColor = System.Drawing.Color.Transparent;
            this.rdo_MaSV.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_MaSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdo_MaSV.Location = new System.Drawing.Point(28, 93);
            this.rdo_MaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_MaSV.Name = "rdo_MaSV";
            this.rdo_MaSV.Size = new System.Drawing.Size(71, 23);
            this.rdo_MaSV.TabIndex = 2;
            this.rdo_MaSV.Text = "Mã SV";
            this.rdo_MaSV.UseVisualStyleBackColor = false;
            this.rdo_MaSV.CheckedChanged += new System.EventHandler(this.rdo_MaSV_CheckedChanged);
            // 
            // rdo_MaMH
            // 
            this.rdo_MaMH.AutoSize = true;
            this.rdo_MaMH.BackColor = System.Drawing.Color.Transparent;
            this.rdo_MaMH.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_MaMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdo_MaMH.Location = new System.Drawing.Point(28, 21);
            this.rdo_MaMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_MaMH.Name = "rdo_MaMH";
            this.rdo_MaMH.Size = new System.Drawing.Size(75, 23);
            this.rdo_MaMH.TabIndex = 0;
            this.rdo_MaMH.Text = "Mã MH";
            this.rdo_MaMH.UseVisualStyleBackColor = false;
            this.rdo_MaMH.CheckedChanged += new System.EventHandler(this.rdo_MaMH_CheckedChanged);
            // 
            // cmb_MaSV
            // 
            this.cmb_MaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaSV.FormattingEnabled = true;
            this.cmb_MaSV.Location = new System.Drawing.Point(28, 130);
            this.cmb_MaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_MaSV.Name = "cmb_MaSV";
            this.cmb_MaSV.Size = new System.Drawing.Size(281, 28);
            this.cmb_MaSV.TabIndex = 3;
            // 
            // dgv_Diem
            // 
            this.dgv_Diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Diem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamh,
            this.masv,
            this.hotensv,
            this.diemthuongxuyen,
            this.diemkt1,
            this.diemkt2,
            this.diemkt3,
            this.diemkt4,
            this.diemkt5,
            this.tbdiemthanhphan,
            this.diemthi,
            this.diemtongket,
            this.quamon,
            this.ghichu});
            this.dgv_Diem.Location = new System.Drawing.Point(4, 204);
            this.dgv_Diem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Diem.Name = "dgv_Diem";
            this.dgv_Diem.RowHeadersWidth = 51;
            this.dgv_Diem.RowTemplate.Height = 24;
            this.dgv_Diem.Size = new System.Drawing.Size(1058, 292);
            this.dgv_Diem.TabIndex = 3;
            this.dgv_Diem.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_Diem_CellBeginEdit);
            // 
            // mamh
            // 
            this.mamh.DataPropertyName = "mamh";
            this.mamh.HeaderText = "Mã MH";
            this.mamh.MinimumWidth = 80;
            this.mamh.Name = "mamh";
            this.mamh.Width = 80;
            // 
            // masv
            // 
            this.masv.DataPropertyName = "masv";
            this.masv.HeaderText = "Mã SV";
            this.masv.MinimumWidth = 80;
            this.masv.Name = "masv";
            this.masv.Width = 80;
            // 
            // hotensv
            // 
            this.hotensv.DataPropertyName = "hotensv";
            this.hotensv.HeaderText = "Họ Tên SV";
            this.hotensv.MinimumWidth = 125;
            this.hotensv.Name = "hotensv";
            this.hotensv.Width = 125;
            // 
            // diemthuongxuyen
            // 
            this.diemthuongxuyen.DataPropertyName = "diemthuongxuyen";
            this.diemthuongxuyen.HeaderText = "Điểm TX";
            this.diemthuongxuyen.MinimumWidth = 80;
            this.diemthuongxuyen.Name = "diemthuongxuyen";
            this.diemthuongxuyen.Width = 80;
            // 
            // diemkt1
            // 
            this.diemkt1.DataPropertyName = "diemkt1";
            this.diemkt1.HeaderText = "Điểm KT1";
            this.diemkt1.MinimumWidth = 80;
            this.diemkt1.Name = "diemkt1";
            this.diemkt1.Width = 80;
            // 
            // diemkt2
            // 
            this.diemkt2.DataPropertyName = "diemkt2";
            this.diemkt2.HeaderText = "Điểm KT2";
            this.diemkt2.MinimumWidth = 80;
            this.diemkt2.Name = "diemkt2";
            this.diemkt2.Width = 80;
            // 
            // diemkt3
            // 
            this.diemkt3.DataPropertyName = "diemkt3";
            this.diemkt3.HeaderText = "Điểm KT3";
            this.diemkt3.MinimumWidth = 80;
            this.diemkt3.Name = "diemkt3";
            this.diemkt3.Width = 80;
            // 
            // diemkt4
            // 
            this.diemkt4.DataPropertyName = "diemkt4";
            this.diemkt4.HeaderText = "Điểm KT4";
            this.diemkt4.MinimumWidth = 80;
            this.diemkt4.Name = "diemkt4";
            this.diemkt4.Width = 80;
            // 
            // diemkt5
            // 
            this.diemkt5.DataPropertyName = "diemkt5";
            this.diemkt5.HeaderText = "Điểm KT5";
            this.diemkt5.MinimumWidth = 80;
            this.diemkt5.Name = "diemkt5";
            this.diemkt5.Width = 80;
            // 
            // tbdiemthanhphan
            // 
            this.tbdiemthanhphan.DataPropertyName = "tbdiemthanhphan";
            this.tbdiemthanhphan.HeaderText = "TB Điểm TP";
            this.tbdiemthanhphan.MinimumWidth = 80;
            this.tbdiemthanhphan.Name = "tbdiemthanhphan";
            this.tbdiemthanhphan.Width = 80;
            // 
            // diemthi
            // 
            this.diemthi.DataPropertyName = "diemthi";
            this.diemthi.HeaderText = "Điểm Thi";
            this.diemthi.MinimumWidth = 80;
            this.diemthi.Name = "diemthi";
            this.diemthi.Width = 80;
            // 
            // diemtongket
            // 
            this.diemtongket.DataPropertyName = "diemtongket";
            this.diemtongket.HeaderText = "Điểm Tổng Kết";
            this.diemtongket.MinimumWidth = 80;
            this.diemtongket.Name = "diemtongket";
            this.diemtongket.Width = 80;
            // 
            // quamon
            // 
            this.quamon.DataPropertyName = "quamon";
            this.quamon.HeaderText = "Qua Môn";
            this.quamon.MinimumWidth = 80;
            this.quamon.Name = "quamon";
            this.quamon.Width = 80;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi Chú";
            this.ghichu.MinimumWidth = 80;
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 80;
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
            this.btn_Thoat.Location = new System.Drawing.Point(733, 132);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Thoat.Size = new System.Drawing.Size(140, 50);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click_1);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(733, 45);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_TimKiem.Size = new System.Drawing.Size(140, 50);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_MaSV);
            this.groupBox1.Controls.Add(this.cmb_MaMH);
            this.groupBox1.Controls.Add(this.rdo_MaSV);
            this.groupBox1.Controls.Add(this.rdo_MaMH);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu Chí ";
            // 
            // FR_TimKiemDiem
            // 
            this.AcceptButton = this.btn_TimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(1067, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.dgv_Diem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1083, 543);
            this.MinimumSize = new System.Drawing.Size(1083, 543);
            this.Name = "FR_TimKiemDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Điểm";
            this.Load += new System.EventHandler(this.FR_TimKiemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Diem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_MaMH;
        private System.Windows.Forms.RadioButton rdo_MaSV;
        private System.Windows.Forms.RadioButton rdo_MaMH;
        private System.Windows.Forms.ComboBox cmb_MaSV;
        private System.Windows.Forms.DataGridView dgv_Diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamh;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemthuongxuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemkt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemkt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemkt3;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemkt4;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemkt5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbdiemthanhphan;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemtongket;
        private System.Windows.Forms.DataGridViewTextBoxColumn quamon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}