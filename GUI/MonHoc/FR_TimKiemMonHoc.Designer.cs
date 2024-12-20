
namespace GUI.MonHoc
{
    partial class FR_TimKiemMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_TimKiemMonHoc));
            this.dgv_MonHoc = new System.Windows.Forms.DataGridView();
            this.mamh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodaudiemkt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotinchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_MaMH = new System.Windows.Forms.ComboBox();
            this.txt_TenMH = new System.Windows.Forms.TextBox();
            this.rdo_TenMH = new System.Windows.Forms.RadioButton();
            this.rdo_MaMH = new System.Windows.Forms.RadioButton();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.dgv_MonHoc.Location = new System.Drawing.Point(202, 204);
            this.dgv_MonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_MonHoc.Name = "dgv_MonHoc";
            this.dgv_MonHoc.RowHeadersWidth = 51;
            this.dgv_MonHoc.RowTemplate.Height = 24;
            this.dgv_MonHoc.Size = new System.Drawing.Size(609, 292);
            this.dgv_MonHoc.TabIndex = 3;
            this.dgv_MonHoc.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_MonHoc_CellBeginEdit);
            // 
            // mamh
            // 
            this.mamh.DataPropertyName = "mamh";
            this.mamh.HeaderText = "Mã MH";
            this.mamh.MinimumWidth = 80;
            this.mamh.Name = "mamh";
            this.mamh.Width = 80;
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
            this.sotiet.Width = 80;
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
            // cmb_MaMH
            // 
            this.cmb_MaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaMH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_MaMH.FormattingEnabled = true;
            this.cmb_MaMH.Location = new System.Drawing.Point(15, 49);
            this.cmb_MaMH.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_MaMH.Name = "cmb_MaMH";
            this.cmb_MaMH.Size = new System.Drawing.Size(241, 28);
            this.cmb_MaMH.TabIndex = 1;
            // 
            // txt_TenMH
            // 
            this.txt_TenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenMH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_TenMH.Location = new System.Drawing.Point(15, 132);
            this.txt_TenMH.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenMH.Multiline = true;
            this.txt_TenMH.Name = "txt_TenMH";
            this.txt_TenMH.Size = new System.Drawing.Size(241, 28);
            this.txt_TenMH.TabIndex = 3;
            // 
            // rdo_TenMH
            // 
            this.rdo_TenMH.AutoSize = true;
            this.rdo_TenMH.BackColor = System.Drawing.Color.Transparent;
            this.rdo_TenMH.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_TenMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdo_TenMH.Location = new System.Drawing.Point(15, 101);
            this.rdo_TenMH.Margin = new System.Windows.Forms.Padding(2);
            this.rdo_TenMH.Name = "rdo_TenMH";
            this.rdo_TenMH.Size = new System.Drawing.Size(122, 23);
            this.rdo_TenMH.TabIndex = 2;
            this.rdo_TenMH.Text = "Tên Môn Học:";
            this.rdo_TenMH.UseVisualStyleBackColor = false;
            this.rdo_TenMH.CheckedChanged += new System.EventHandler(this.rdo_TenMH_CheckedChanged_1);
            // 
            // rdo_MaMH
            // 
            this.rdo_MaMH.AutoSize = true;
            this.rdo_MaMH.BackColor = System.Drawing.Color.Transparent;
            this.rdo_MaMH.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_MaMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdo_MaMH.Location = new System.Drawing.Point(15, 20);
            this.rdo_MaMH.Margin = new System.Windows.Forms.Padding(2);
            this.rdo_MaMH.Name = "rdo_MaMH";
            this.rdo_MaMH.Size = new System.Drawing.Size(118, 23);
            this.rdo_MaMH.TabIndex = 0;
            this.rdo_MaMH.Text = "Mã Môn Học:";
            this.rdo_MaMH.UseVisualStyleBackColor = false;
            this.rdo_MaMH.CheckedChanged += new System.EventHandler(this.rdo_MaMH_CheckedChanged_1);
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
            this.btn_Thoat.Location = new System.Drawing.Point(351, 124);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Thoat.Size = new System.Drawing.Size(109, 40);
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
            this.btn_TimKiem.Location = new System.Drawing.Point(351, 41);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_TimKiem.Size = new System.Drawing.Size(109, 40);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cmb_MaMH);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.txt_TenMH);
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.rdo_TenMH);
            this.groupBox1.Controls.Add(this.rdo_MaMH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(255, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu Chí";
            // 
            // FR_TimKiemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(982, 520);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_MonHoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(631, 538);
            this.Name = "FR_TimKiemMonHoc";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm Kiếm Môn Học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FR_TimKiemMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_MonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodaudiemkt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotinchi;
        private System.Windows.Forms.ComboBox cmb_MaMH;
        private System.Windows.Forms.TextBox txt_TenMH;
        private System.Windows.Forms.RadioButton rdo_TenMH;
        private System.Windows.Forms.RadioButton rdo_MaMH;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}