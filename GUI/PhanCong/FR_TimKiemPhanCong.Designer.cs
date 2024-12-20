
namespace GUI.PhanCong
{
    partial class FR_TimKiemPhanCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_TimKiemPhanCong));
            this.dgv_PhanCong = new System.Windows.Forms.DataGridView();
            this.magv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.cmb_MaLop = new System.Windows.Forms.ComboBox();
            this.cmb_MaMH = new System.Windows.Forms.ComboBox();
            this.rdo_MaLop = new System.Windows.Forms.RadioButton();
            this.cmb_MaGV = new System.Windows.Forms.ComboBox();
            this.rdo_MaMH = new System.Windows.Forms.RadioButton();
            this.rdo_MaGV = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhanCong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_PhanCong
            // 
            this.dgv_PhanCong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_PhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhanCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magv,
            this.mamh,
            this.malop,
            this.namhoc,
            this.hocky});
            this.dgv_PhanCong.Location = new System.Drawing.Point(127, 291);
            this.dgv_PhanCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_PhanCong.Name = "dgv_PhanCong";
            this.dgv_PhanCong.RowHeadersWidth = 51;
            this.dgv_PhanCong.RowTemplate.Height = 24;
            this.dgv_PhanCong.Size = new System.Drawing.Size(680, 257);
            this.dgv_PhanCong.TabIndex = 5;
            this.dgv_PhanCong.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_PhanCong_CellBeginEdit);
            // 
            // magv
            // 
            this.magv.DataPropertyName = "magv";
            this.magv.HeaderText = "Mã GV";
            this.magv.MinimumWidth = 6;
            this.magv.Name = "magv";
            this.magv.Width = 125;
            // 
            // mamh
            // 
            this.mamh.DataPropertyName = "mamh";
            this.mamh.HeaderText = "Mã MH";
            this.mamh.MinimumWidth = 6;
            this.mamh.Name = "mamh";
            this.mamh.Width = 125;
            // 
            // malop
            // 
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "Mã Lớp";
            this.malop.MinimumWidth = 6;
            this.malop.Name = "malop";
            this.malop.Width = 125;
            // 
            // namhoc
            // 
            this.namhoc.DataPropertyName = "namhoc";
            this.namhoc.HeaderText = "Năm Học";
            this.namhoc.MinimumWidth = 6;
            this.namhoc.Name = "namhoc";
            this.namhoc.Width = 125;
            // 
            // hocky
            // 
            this.hocky.DataPropertyName = "hocky";
            this.hocky.HeaderText = "Học Kỳ";
            this.hocky.MinimumWidth = 6;
            this.hocky.Name = "hocky";
            this.hocky.Width = 125;
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
            this.btn_Thoat.Location = new System.Drawing.Point(415, 170);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_Thoat.Size = new System.Drawing.Size(119, 49);
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
            this.btn_TimKiem.Location = new System.Drawing.Point(415, 62);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_TimKiem.Size = new System.Drawing.Size(119, 49);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click_1);
            // 
            // cmb_MaLop
            // 
            this.cmb_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaLop.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MaLop.FormattingEnabled = true;
            this.cmb_MaLop.Location = new System.Drawing.Point(19, 211);
            this.cmb_MaLop.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_MaLop.Name = "cmb_MaLop";
            this.cmb_MaLop.Size = new System.Drawing.Size(306, 28);
            this.cmb_MaLop.TabIndex = 5;
            // 
            // cmb_MaMH
            // 
            this.cmb_MaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaMH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MaMH.FormattingEnabled = true;
            this.cmb_MaMH.Location = new System.Drawing.Point(19, 129);
            this.cmb_MaMH.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_MaMH.Name = "cmb_MaMH";
            this.cmb_MaMH.Size = new System.Drawing.Size(306, 28);
            this.cmb_MaMH.TabIndex = 3;
            // 
            // rdo_MaLop
            // 
            this.rdo_MaLop.AutoSize = true;
            this.rdo_MaLop.BackColor = System.Drawing.Color.Transparent;
            this.rdo_MaLop.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_MaLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdo_MaLop.Location = new System.Drawing.Point(19, 175);
            this.rdo_MaLop.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_MaLop.Name = "rdo_MaLop";
            this.rdo_MaLop.Size = new System.Drawing.Size(83, 23);
            this.rdo_MaLop.TabIndex = 4;
            this.rdo_MaLop.Text = "Mã Lớp:";
            this.rdo_MaLop.UseVisualStyleBackColor = false;
            this.rdo_MaLop.CheckedChanged += new System.EventHandler(this.rdo_MaLop_CheckedChanged_1);
            // 
            // cmb_MaGV
            // 
            this.cmb_MaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaGV.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MaGV.FormattingEnabled = true;
            this.cmb_MaGV.Location = new System.Drawing.Point(19, 61);
            this.cmb_MaGV.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_MaGV.Name = "cmb_MaGV";
            this.cmb_MaGV.Size = new System.Drawing.Size(306, 28);
            this.cmb_MaGV.TabIndex = 1;
            // 
            // rdo_MaMH
            // 
            this.rdo_MaMH.AutoSize = true;
            this.rdo_MaMH.BackColor = System.Drawing.Color.Transparent;
            this.rdo_MaMH.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_MaMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdo_MaMH.Location = new System.Drawing.Point(19, 97);
            this.rdo_MaMH.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_MaMH.Name = "rdo_MaMH";
            this.rdo_MaMH.Size = new System.Drawing.Size(79, 23);
            this.rdo_MaMH.TabIndex = 2;
            this.rdo_MaMH.Text = "Mã MH:";
            this.rdo_MaMH.UseVisualStyleBackColor = false;
            this.rdo_MaMH.CheckedChanged += new System.EventHandler(this.rdo_MaMH_CheckedChanged_1);
            // 
            // rdo_MaGV
            // 
            this.rdo_MaGV.AutoSize = true;
            this.rdo_MaGV.BackColor = System.Drawing.Color.Transparent;
            this.rdo_MaGV.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_MaGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdo_MaGV.Location = new System.Drawing.Point(19, 29);
            this.rdo_MaGV.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_MaGV.Name = "rdo_MaGV";
            this.rdo_MaGV.Size = new System.Drawing.Size(74, 23);
            this.rdo_MaGV.TabIndex = 0;
            this.rdo_MaGV.Text = "Mã GV:";
            this.rdo_MaGV.UseVisualStyleBackColor = false;
            this.rdo_MaGV.CheckedChanged += new System.EventHandler(this.rdo_MaGV_CheckedChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cmb_MaLop);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.cmb_MaMH);
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.rdo_MaLop);
            this.groupBox1.Controls.Add(this.cmb_MaGV);
            this.groupBox1.Controls.Add(this.rdo_MaMH);
            this.groupBox1.Controls.Add(this.rdo_MaGV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(127, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu Chí";
            // 
            // FR_TimKiemPhanCong
            // 
            this.AcceptButton = this.btn_TimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(931, 581);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_PhanCong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(667, 611);
            this.Name = "FR_TimKiemPhanCong";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm Kiếm Phân Công";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FR_TimKiemPhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhanCong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_PhanCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn magv;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamh;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn namhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocky;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.ComboBox cmb_MaLop;
        private System.Windows.Forms.ComboBox cmb_MaMH;
        private System.Windows.Forms.RadioButton rdo_MaLop;
        private System.Windows.Forms.ComboBox cmb_MaGV;
        private System.Windows.Forms.RadioButton rdo_MaMH;
        private System.Windows.Forms.RadioButton rdo_MaGV;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}