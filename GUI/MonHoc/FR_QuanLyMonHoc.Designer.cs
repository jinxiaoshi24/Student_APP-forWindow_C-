
namespace GUI.MonHoc
{
    partial class FR_Project_Managment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_Project_Managment));
            this.dgv_MonHoc = new System.Windows.Forms.DataGridView();
            this.mamh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodaudiemkt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotinchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.nud_SoTinChi = new System.Windows.Forms.NumericUpDown();
            this.nud_SoDauDiemKT = new System.Windows.Forms.NumericUpDown();
            this.nud_SoTiet = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenMH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoTinChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoDauDiemKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_MonHoc
            // 
            this.dgv_MonHoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_MonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamh,
            this.tenmh,
            this.sotiet,
            this.sodaudiemkt,
            this.sotinchi});
            this.dgv_MonHoc.Location = new System.Drawing.Point(148, 230);
            this.dgv_MonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_MonHoc.Name = "dgv_MonHoc";
            this.dgv_MonHoc.RowHeadersWidth = 51;
            this.dgv_MonHoc.RowTemplate.Height = 24;
            this.dgv_MonHoc.Size = new System.Drawing.Size(696, 292);
            this.dgv_MonHoc.TabIndex = 11;
            this.dgv_MonHoc.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_MonHoc_CellBeginEdit);
            this.dgv_MonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MonHoc_CellClick);
            this.dgv_MonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MonHoc_CellContentClick);
            // 
            // mamh
            // 
            this.mamh.DataPropertyName = "mamh";
            this.mamh.HeaderText = "Mã MH";
            this.mamh.MinimumWidth = 6;
            this.mamh.Name = "mamh";
            this.mamh.Width = 125;
            // 
            // tenmh
            // 
            this.tenmh.DataPropertyName = "tenmh";
            this.tenmh.HeaderText = "Tên MH";
            this.tenmh.MinimumWidth = 6;
            this.tenmh.Name = "tenmh";
            this.tenmh.Width = 125;
            // 
            // sotiet
            // 
            this.sotiet.DataPropertyName = "sotiet";
            this.sotiet.HeaderText = "Số Tiết";
            this.sotiet.MinimumWidth = 6;
            this.sotiet.Name = "sotiet";
            this.sotiet.Width = 125;
            // 
            // sodaudiemkt
            // 
            this.sodaudiemkt.DataPropertyName = "sodaudiemkt";
            this.sodaudiemkt.HeaderText = "Số Đầu Điểm KT";
            this.sodaudiemkt.MinimumWidth = 6;
            this.sodaudiemkt.Name = "sodaudiemkt";
            this.sodaudiemkt.Width = 140;
            // 
            // sotinchi
            // 
            this.sotinchi.DataPropertyName = "sotinchi";
            this.sotinchi.HeaderText = "Số Tín Chỉ";
            this.sotinchi.MinimumWidth = 6;
            this.sotinchi.Name = "sotinchi";
            this.sotinchi.Width = 125;
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
            this.btn_Thoat.Location = new System.Drawing.Point(703, 180);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Thoat.Size = new System.Drawing.Size(87, 43);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click_1);
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
            this.btn_Huy.Location = new System.Drawing.Point(597, 180);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Huy.Size = new System.Drawing.Size(81, 43);
            this.btn_Huy.TabIndex = 9;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click_1);
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
            this.btn_Luu.Location = new System.Drawing.Point(497, 180);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Luu.Size = new System.Drawing.Size(78, 43);
            this.btn_Luu.TabIndex = 8;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click_1);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.BackColor = System.Drawing.Color.White;
            this.btn_Xoa.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(391, 180);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(81, 43);
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
            this.btn_Sua.Location = new System.Drawing.Point(290, 180);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Sua.Size = new System.Drawing.Size(81, 43);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click_1);
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
            this.btn_Them.Location = new System.Drawing.Point(187, 180);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Them.Size = new System.Drawing.Size(88, 43);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click_1);
            // 
            // nud_SoTinChi
            // 
            this.nud_SoTinChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nud_SoTinChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_SoTinChi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nud_SoTinChi.Location = new System.Drawing.Point(594, 139);
            this.nud_SoTinChi.Margin = new System.Windows.Forms.Padding(4);
            this.nud_SoTinChi.Name = "nud_SoTinChi";
            this.nud_SoTinChi.Size = new System.Drawing.Size(141, 26);
            this.nud_SoTinChi.TabIndex = 4;
            // 
            // nud_SoDauDiemKT
            // 
            this.nud_SoDauDiemKT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nud_SoDauDiemKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_SoDauDiemKT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nud_SoDauDiemKT.Location = new System.Drawing.Point(594, 92);
            this.nud_SoDauDiemKT.Margin = new System.Windows.Forms.Padding(4);
            this.nud_SoDauDiemKT.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_SoDauDiemKT.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_SoDauDiemKT.Name = "nud_SoDauDiemKT";
            this.nud_SoDauDiemKT.Size = new System.Drawing.Size(141, 26);
            this.nud_SoDauDiemKT.TabIndex = 3;
            this.nud_SoDauDiemKT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_SoTiet
            // 
            this.nud_SoTiet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nud_SoTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_SoTiet.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nud_SoTiet.Location = new System.Drawing.Point(594, 46);
            this.nud_SoTiet.Margin = new System.Windows.Forms.Padding(4);
            this.nud_SoTiet.Name = "nud_SoTiet";
            this.nud_SoTiet.Size = new System.Drawing.Size(141, 26);
            this.nud_SoTiet.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(457, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "Số Tín Chỉ:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(457, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Số Tiết:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(457, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 54;
            this.label4.Text = "Số Đầu Điểm KT:";
            // 
            // txt_TenMH
            // 
            this.txt_TenMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenMH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_TenMH.Location = new System.Drawing.Point(273, 139);
            this.txt_TenMH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenMH.Name = "txt_TenMH";
            this.txt_TenMH.Size = new System.Drawing.Size(149, 26);
            this.txt_TenMH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(162, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Mã Môn Học:";
            // 
            // txt_MaMH
            // 
            this.txt_MaMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaMH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_MaMH.Location = new System.Drawing.Point(273, 46);
            this.txt_MaMH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaMH.Name = "txt_MaMH";
            this.txt_MaMH.Size = new System.Drawing.Size(149, 26);
            this.txt_MaMH.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(160, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tên Môn Học:";
            // 
            // FR_Project_Managment
            // 
            this.AcceptButton = this.btn_Luu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.btn_Huy;
            this.ClientSize = new System.Drawing.Size(984, 560);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.nud_SoTinChi);
            this.Controls.Add(this.nud_SoDauDiemKT);
            this.Controls.Add(this.nud_SoTiet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_TenMH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MaMH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_MonHoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(721, 565);
            this.Name = "FR_Project_Managment";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Môn Học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FR_QuanLyMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoTinChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoDauDiemKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_MonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodaudiemkt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotinchi;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.NumericUpDown nud_SoTinChi;
        private System.Windows.Forms.NumericUpDown nud_SoDauDiemKT;
        private System.Windows.Forms.NumericUpDown nud_SoTiet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaMH;
        private System.Windows.Forms.Label label2;
    }
}