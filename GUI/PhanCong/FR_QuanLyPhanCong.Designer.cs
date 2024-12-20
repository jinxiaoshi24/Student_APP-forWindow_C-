
namespace GUI.PhanCong
{
    partial class FR_QuanLyPhanCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_QuanLyPhanCong));
            this.dgv_PhanCong = new System.Windows.Forms.DataGridView();
            this.magv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Lop = new System.Windows.Forms.ComboBox();
            this.cmb_MaGV = new System.Windows.Forms.ComboBox();
            this.cmb_MaMH = new System.Windows.Forms.ComboBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.nud_HocKi = new System.Windows.Forms.NumericUpDown();
            this.nud_NamHoc = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhanCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HocKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_NamHoc)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.dgv_PhanCong.Location = new System.Drawing.Point(167, 283);
            this.dgv_PhanCong.Name = "dgv_PhanCong";
            this.dgv_PhanCong.RowHeadersWidth = 51;
            this.dgv_PhanCong.RowTemplate.Height = 24;
            this.dgv_PhanCong.Size = new System.Drawing.Size(704, 236);
            this.dgv_PhanCong.TabIndex = 11;
            this.dgv_PhanCong.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_PhanCong_CellBeginEdit);
            this.dgv_PhanCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhanCong_CellClick_1);
            this.dgv_PhanCong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhanCong_CellContentClick);
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(452, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 82;
            this.label3.Text = "Học Kì:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(451, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 83;
            this.label5.Text = "Năm Học:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(77, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 79;
            this.label4.Text = "Mã Lớp:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(77, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 80;
            this.label2.Text = "Mã Giáo Viên:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(77, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 81;
            this.label1.Text = "Mã Môn Học:";
            // 
            // cmb_Lop
            // 
            this.cmb_Lop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Lop.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Lop.FormattingEnabled = true;
            this.cmb_Lop.Location = new System.Drawing.Point(212, 145);
            this.cmb_Lop.Name = "cmb_Lop";
            this.cmb_Lop.Size = new System.Drawing.Size(172, 28);
            this.cmb_Lop.TabIndex = 2;
            // 
            // cmb_MaGV
            // 
            this.cmb_MaGV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_MaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaGV.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MaGV.FormattingEnabled = true;
            this.cmb_MaGV.Location = new System.Drawing.Point(212, 26);
            this.cmb_MaGV.Name = "cmb_MaGV";
            this.cmb_MaGV.Size = new System.Drawing.Size(172, 28);
            this.cmb_MaGV.TabIndex = 0;
            // 
            // cmb_MaMH
            // 
            this.cmb_MaMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_MaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaMH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MaMH.FormattingEnabled = true;
            this.cmb_MaMH.Location = new System.Drawing.Point(212, 87);
            this.cmb_MaMH.Name = "cmb_MaMH";
            this.cmb_MaMH.Size = new System.Drawing.Size(172, 28);
            this.cmb_MaMH.TabIndex = 1;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Luu.BackColor = System.Drawing.Color.White;
            this.btn_Luu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Luu.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(397, 193);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Luu.Size = new System.Drawing.Size(81, 56);
            this.btn_Luu.TabIndex = 8;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Huy.BackColor = System.Drawing.Color.White;
            this.btn_Huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Huy.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_Huy.Image")));
            this.btn_Huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Huy.Location = new System.Drawing.Point(510, 193);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Huy.Size = new System.Drawing.Size(84, 56);
            this.btn_Huy.TabIndex = 9;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(621, 193);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Thoat.Size = new System.Drawing.Size(84, 56);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.BackColor = System.Drawing.Color.White;
            this.btn_Xoa.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(295, 193);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(78, 56);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Sua.BackColor = System.Drawing.Color.White;
            this.btn_Sua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Sua.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(188, 193);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Sua.Size = new System.Drawing.Size(78, 56);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Them.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(70, 193);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Them.Size = new System.Drawing.Size(89, 56);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click_1);
            // 
            // nud_HocKi
            // 
            this.nud_HocKi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nud_HocKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_HocKi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nud_HocKi.Location = new System.Drawing.Point(533, 94);
            this.nud_HocKi.Margin = new System.Windows.Forms.Padding(4);
            this.nud_HocKi.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_HocKi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_HocKi.Name = "nud_HocKi";
            this.nud_HocKi.Size = new System.Drawing.Size(172, 26);
            this.nud_HocKi.TabIndex = 84;
            this.nud_HocKi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_NamHoc
            // 
            this.nud_NamHoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nud_NamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_NamHoc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nud_NamHoc.Location = new System.Drawing.Point(533, 25);
            this.nud_NamHoc.Margin = new System.Windows.Forms.Padding(4);
            this.nud_NamHoc.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nud_NamHoc.Minimum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.nud_NamHoc.Name = "nud_NamHoc";
            this.nud_NamHoc.Size = new System.Drawing.Size(172, 26);
            this.nud_NamHoc.TabIndex = 85;
            this.nud_NamHoc.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Location = new System.Drawing.Point(144, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 295);
            this.panel1.TabIndex = 86;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btn_Sua);
            this.panel2.Controls.Add(this.btn_Them);
            this.panel2.Controls.Add(this.nud_NamHoc);
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Controls.Add(this.nud_HocKi);
            this.panel2.Controls.Add(this.btn_Luu);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_Huy);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_Thoat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmb_MaMH);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmb_MaGV);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmb_Lop);
            this.panel2.Location = new System.Drawing.Point(127, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 250);
            this.panel2.TabIndex = 87;
            // 
            // FR_QuanLyPhanCong
            // 
            this.AcceptButton = this.btn_Luu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.btn_Huy;
            this.ClientSize = new System.Drawing.Size(1006, 584);
            this.Controls.Add(this.dgv_PhanCong);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(701, 601);
            this.Name = "FR_QuanLyPhanCong";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Phân Công";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FR_QuanLyPhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhanCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HocKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_NamHoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Lop;
        private System.Windows.Forms.ComboBox cmb_MaGV;
        private System.Windows.Forms.ComboBox cmb_MaMH;
        private System.Windows.Forms.NumericUpDown nud_HocKi;
        private System.Windows.Forms.NumericUpDown nud_NamHoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}