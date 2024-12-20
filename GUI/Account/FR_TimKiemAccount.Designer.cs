
namespace GUI.Account
{
    partial class FR_TimKiemAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_TimKiemAccount));
            this.cmb_TaiKhoan = new System.Windows.Forms.ComboBox();
            this.rdo_TaiKhoan = new System.Windows.Forms.RadioButton();
            this.rdo_TypeUser = new System.Windows.Forms.RadioButton();
            this.cmb_TypeUser = new System.Windows.Forms.ComboBox();
            this.dgv_Account = new System.Windows.Forms.DataGridView();
            this.taikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_TaiKhoan
            // 
            this.cmb_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TaiKhoan.FormattingEnabled = true;
            this.cmb_TaiKhoan.Location = new System.Drawing.Point(26, 63);
            this.cmb_TaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_TaiKhoan.Name = "cmb_TaiKhoan";
            this.cmb_TaiKhoan.Size = new System.Drawing.Size(166, 28);
            this.cmb_TaiKhoan.TabIndex = 1;
            // 
            // rdo_TaiKhoan
            // 
            this.rdo_TaiKhoan.AutoSize = true;
            this.rdo_TaiKhoan.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_TaiKhoan.Location = new System.Drawing.Point(26, 33);
            this.rdo_TaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_TaiKhoan.Name = "rdo_TaiKhoan";
            this.rdo_TaiKhoan.Size = new System.Drawing.Size(79, 23);
            this.rdo_TaiKhoan.TabIndex = 0;
            this.rdo_TaiKhoan.Text = "Tài Khoản";
            this.rdo_TaiKhoan.UseVisualStyleBackColor = true;
            this.rdo_TaiKhoan.CheckedChanged += new System.EventHandler(this.rdo_TaiKhoan_CheckedChanged);
            // 
            // rdo_TypeUser
            // 
            this.rdo_TypeUser.AutoSize = true;
            this.rdo_TypeUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_TypeUser.Location = new System.Drawing.Point(26, 115);
            this.rdo_TypeUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_TypeUser.Name = "rdo_TypeUser";
            this.rdo_TypeUser.Size = new System.Drawing.Size(77, 23);
            this.rdo_TypeUser.TabIndex = 2;
            this.rdo_TypeUser.Text = "Type User";
            this.rdo_TypeUser.UseVisualStyleBackColor = true;
            this.rdo_TypeUser.CheckedChanged += new System.EventHandler(this.rdo_TypeUser_CheckedChanged);
            // 
            // cmb_TypeUser
            // 
            this.cmb_TypeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TypeUser.FormattingEnabled = true;
            this.cmb_TypeUser.Location = new System.Drawing.Point(25, 145);
            this.cmb_TypeUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_TypeUser.Name = "cmb_TypeUser";
            this.cmb_TypeUser.Size = new System.Drawing.Size(167, 28);
            this.cmb_TypeUser.TabIndex = 3;
            // 
            // dgv_Account
            // 
            this.dgv_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Account.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taikhoan,
            this.pass,
            this.type_user});
            this.dgv_Account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Account.Location = new System.Drawing.Point(0, 0);
            this.dgv_Account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Account.Name = "dgv_Account";
            this.dgv_Account.RowHeadersWidth = 51;
            this.dgv_Account.RowTemplate.Height = 24;
            this.dgv_Account.Size = new System.Drawing.Size(681, 271);
            this.dgv_Account.TabIndex = 23;
            this.dgv_Account.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_Account_CellBeginEdit);
            // 
            // taikhoan
            // 
            this.taikhoan.DataPropertyName = "taikhoan";
            this.taikhoan.HeaderText = "Tài Khoản";
            this.taikhoan.MinimumWidth = 6;
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Width = 125;
            // 
            // pass
            // 
            this.pass.DataPropertyName = "pass";
            this.pass.HeaderText = "Mật khẩu";
            this.pass.MinimumWidth = 6;
            this.pass.Name = "pass";
            this.pass.Width = 125;
            // 
            // type_user
            // 
            this.type_user.DataPropertyName = "type_user";
            this.type_user.HeaderText = "Type User";
            this.type_user.MinimumWidth = 6;
            this.type_user.Name = "type_user";
            this.type_user.Width = 125;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(259, 128);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Thoat.Size = new System.Drawing.Size(110, 45);
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
            this.btn_TimKiem.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(259, 63);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_TimKiem.Size = new System.Drawing.Size(110, 45);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cmb_TypeUser);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.rdo_TypeUser);
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.cmb_TaiKhoan);
            this.groupBox1.Controls.Add(this.rdo_TaiKhoan);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(171, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu Chí";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.dgv_Account);
            this.panel1.Location = new System.Drawing.Point(57, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 271);
            this.panel1.TabIndex = 24;
            // 
            // FR_TimKiemAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(792, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(450, 559);
            this.Name = "FR_TimKiemAccount";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FR_TimKiemAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_TaiKhoan;
        private System.Windows.Forms.RadioButton rdo_TaiKhoan;
        private System.Windows.Forms.RadioButton rdo_TypeUser;
        private System.Windows.Forms.ComboBox cmb_TypeUser;
        private System.Windows.Forms.DataGridView dgv_Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_user;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}