
namespace GUI.Khoa
{
    partial class FR_TimKiemKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_TimKiemKhoa));
            this.dgv_Khoa = new System.Windows.Forms.DataGridView();
            this.makhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.cmb_MaKhoa = new System.Windows.Forms.ComboBox();
            this.txt_TenKhoa = new System.Windows.Forms.TextBox();
            this.rdo_TenKhoa = new System.Windows.Forms.RadioButton();
            this.rdo_MaKhoa = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Khoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Khoa
            // 
            this.dgv_Khoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Khoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhoa,
            this.tenkhoa});
            this.dgv_Khoa.Location = new System.Drawing.Point(0, 0);
            this.dgv_Khoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Khoa.Name = "dgv_Khoa";
            this.dgv_Khoa.RowHeadersWidth = 51;
            this.dgv_Khoa.RowTemplate.Height = 24;
            this.dgv_Khoa.Size = new System.Drawing.Size(696, 301);
            this.dgv_Khoa.TabIndex = 3;
            this.dgv_Khoa.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_Khoa_CellBeginEdit);
            // 
            // makhoa
            // 
            this.makhoa.DataPropertyName = "makhoa";
            this.makhoa.HeaderText = "Mã Khoa";
            this.makhoa.MinimumWidth = 6;
            this.makhoa.Name = "makhoa";
            this.makhoa.Width = 125;
            // 
            // tenkhoa
            // 
            this.tenkhoa.DataPropertyName = "tenkhoa";
            this.tenkhoa.HeaderText = "Tên Khoa";
            this.tenkhoa.MinimumWidth = 6;
            this.tenkhoa.Name = "tenkhoa";
            this.tenkhoa.Width = 125;
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
            this.btn_Thoat.Location = new System.Drawing.Point(511, 120);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Thoat.Size = new System.Drawing.Size(110, 38);
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
            this.btn_TimKiem.Location = new System.Drawing.Point(511, 45);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_TimKiem.Size = new System.Drawing.Size(110, 37);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click_1);
            // 
            // cmb_MaKhoa
            // 
            this.cmb_MaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaKhoa.FormattingEnabled = true;
            this.cmb_MaKhoa.Location = new System.Drawing.Point(47, 54);
            this.cmb_MaKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_MaKhoa.Name = "cmb_MaKhoa";
            this.cmb_MaKhoa.Size = new System.Drawing.Size(137, 28);
            this.cmb_MaKhoa.TabIndex = 1;
            // 
            // txt_TenKhoa
            // 
            this.txt_TenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKhoa.Location = new System.Drawing.Point(47, 132);
            this.txt_TenKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenKhoa.Name = "txt_TenKhoa";
            this.txt_TenKhoa.Size = new System.Drawing.Size(137, 26);
            this.txt_TenKhoa.TabIndex = 3;
            // 
            // rdo_TenKhoa
            // 
            this.rdo_TenKhoa.AutoSize = true;
            this.rdo_TenKhoa.BackColor = System.Drawing.Color.White;
            this.rdo_TenKhoa.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_TenKhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdo_TenKhoa.Location = new System.Drawing.Point(47, 100);
            this.rdo_TenKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_TenKhoa.Name = "rdo_TenKhoa";
            this.rdo_TenKhoa.Size = new System.Drawing.Size(93, 23);
            this.rdo_TenKhoa.TabIndex = 2;
            this.rdo_TenKhoa.Text = "Tên Khoa";
            this.rdo_TenKhoa.UseVisualStyleBackColor = false;
            this.rdo_TenKhoa.CheckedChanged += new System.EventHandler(this.rdo_TenKhoa_CheckedChanged_1);
            // 
            // rdo_MaKhoa
            // 
            this.rdo_MaKhoa.AutoSize = true;
            this.rdo_MaKhoa.BackColor = System.Drawing.Color.White;
            this.rdo_MaKhoa.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_MaKhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdo_MaKhoa.Location = new System.Drawing.Point(47, 22);
            this.rdo_MaKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_MaKhoa.Name = "rdo_MaKhoa";
            this.rdo_MaKhoa.Size = new System.Drawing.Size(89, 23);
            this.rdo_MaKhoa.TabIndex = 0;
            this.rdo_MaKhoa.Text = "Mã Khoa";
            this.rdo_MaKhoa.UseVisualStyleBackColor = false;
            this.rdo_MaKhoa.CheckedChanged += new System.EventHandler(this.rdo_MaKhoa_CheckedChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cmb_MaKhoa);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.txt_TenKhoa);
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.rdo_TenKhoa);
            this.groupBox1.Controls.Add(this.rdo_MaKhoa);
            this.groupBox1.Location = new System.Drawing.Point(31, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu Chí";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.dgv_Khoa);
            this.panel1.Location = new System.Drawing.Point(31, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 301);
            this.panel1.TabIndex = 4;
            // 
            // FR_TimKiemKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(765, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(372, 534);
            this.Name = "FR_TimKiemKhoa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Khoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FR_TimKiem_Khoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Khoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.ComboBox cmb_MaKhoa;
        private System.Windows.Forms.TextBox txt_TenKhoa;
        private System.Windows.Forms.RadioButton rdo_TenKhoa;
        private System.Windows.Forms.RadioButton rdo_MaKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}