
namespace GUI.Lop
{
    partial class FR_SrearchClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_SrearchClass));
            this.cmb_MaLop = new System.Windows.Forms.ComboBox();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.rdo_TenLop = new System.Windows.Forms.RadioButton();
            this.rdo_MaLop = new System.Windows.Forms.RadioButton();
            this.dgv_Lop = new System.Windows.Forms.DataGridView();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lop)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_MaLop
            // 
            this.cmb_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaLop.FormattingEnabled = true;
            this.cmb_MaLop.Location = new System.Drawing.Point(25, 50);
            this.cmb_MaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_MaLop.Name = "cmb_MaLop";
            this.cmb_MaLop.Size = new System.Drawing.Size(202, 28);
            this.cmb_MaLop.TabIndex = 1;
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenLop.Location = new System.Drawing.Point(25, 125);
            this.txt_TenLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(202, 26);
            this.txt_TenLop.TabIndex = 3;
            // 
            // rdo_TenLop
            // 
            this.rdo_TenLop.AutoSize = true;
            this.rdo_TenLop.BackColor = System.Drawing.Color.Transparent;
            this.rdo_TenLop.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_TenLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdo_TenLop.Location = new System.Drawing.Point(25, 94);
            this.rdo_TenLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_TenLop.Name = "rdo_TenLop";
            this.rdo_TenLop.Size = new System.Drawing.Size(83, 23);
            this.rdo_TenLop.TabIndex = 2;
            this.rdo_TenLop.Text = "Tên Lớp";
            this.rdo_TenLop.UseVisualStyleBackColor = false;
            this.rdo_TenLop.CheckedChanged += new System.EventHandler(this.rdo_TenLop_CheckedChanged);
            // 
            // rdo_MaLop
            // 
            this.rdo_MaLop.AutoSize = true;
            this.rdo_MaLop.BackColor = System.Drawing.Color.Transparent;
            this.rdo_MaLop.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_MaLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdo_MaLop.Location = new System.Drawing.Point(25, 20);
            this.rdo_MaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_MaLop.Name = "rdo_MaLop";
            this.rdo_MaLop.Size = new System.Drawing.Size(79, 23);
            this.rdo_MaLop.TabIndex = 0;
            this.rdo_MaLop.Text = "Mã Lớp";
            this.rdo_MaLop.UseVisualStyleBackColor = false;
            this.rdo_MaLop.CheckedChanged += new System.EventHandler(this.rdo_MaLop_CheckedChanged);
            // 
            // dgv_Lop
            // 
            this.dgv_Lop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malop,
            this.tenlop,
            this.makhoa,
            this.magv});
            this.dgv_Lop.Location = new System.Drawing.Point(182, 237);
            this.dgv_Lop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Lop.Name = "dgv_Lop";
            this.dgv_Lop.RowHeadersWidth = 51;
            this.dgv_Lop.RowTemplate.Height = 24;
            this.dgv_Lop.Size = new System.Drawing.Size(482, 247);
            this.dgv_Lop.TabIndex = 3;
            this.dgv_Lop.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_Lop_CellBeginEdit);
            // 
            // malop
            // 
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "Mã Lớp";
            this.malop.MinimumWidth = 100;
            this.malop.Name = "malop";
            this.malop.Width = 101;
            // 
            // tenlop
            // 
            this.tenlop.DataPropertyName = "tenlop";
            this.tenlop.HeaderText = "Tên Lớp";
            this.tenlop.MinimumWidth = 125;
            this.tenlop.Name = "tenlop";
            this.tenlop.Width = 125;
            // 
            // makhoa
            // 
            this.makhoa.DataPropertyName = "makhoa";
            this.makhoa.HeaderText = "Mã Khoa";
            this.makhoa.MinimumWidth = 100;
            this.makhoa.Name = "makhoa";
            this.makhoa.Width = 101;
            // 
            // magv
            // 
            this.magv.DataPropertyName = "magv";
            this.magv.HeaderText = "Mã GV";
            this.magv.MinimumWidth = 100;
            this.magv.Name = "magv";
            this.magv.Width = 101;
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
            this.btn_Thoat.Location = new System.Drawing.Point(285, 110);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Thoat.Size = new System.Drawing.Size(122, 41);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click_1);
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
            this.btn_TimKiem.Location = new System.Drawing.Point(285, 50);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_TimKiem.Size = new System.Drawing.Size(122, 38);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cmb_MaLop);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.txt_TenLop);
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.rdo_TenLop);
            this.groupBox1.Controls.Add(this.rdo_MaLop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(182, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu Chí";
            // 
            // FR_SrearchClass
            // 
            this.AcceptButton = this.btn_TimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(856, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Lop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(503, 507);
            this.Name = "FR_SrearchClass";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm Kiếm Lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FR_TimKiemLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lop)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_MaLop;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.RadioButton rdo_TenLop;
        private System.Windows.Forms.RadioButton rdo_MaLop;
        private System.Windows.Forms.DataGridView dgv_Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn magv;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}