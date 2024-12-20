
namespace GUI
{
    partial class FR_DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_DoiMatKhau));
            this.Chk_PassHideshow = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MK_NhapLai = new System.Windows.Forms.TextBox();
            this.txt_MK_Moi = new System.Windows.Forms.TextBox();
            this.txt_MK_Cu = new System.Windows.Forms.TextBox();
            this.btn_DoiMK = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Chk_PassHideshow
            // 
            this.Chk_PassHideshow.AutoSize = true;
            this.Chk_PassHideshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_PassHideshow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Chk_PassHideshow.Location = new System.Drawing.Point(542, 388);
            this.Chk_PassHideshow.Margin = new System.Windows.Forms.Padding(2);
            this.Chk_PassHideshow.Name = "Chk_PassHideshow";
            this.Chk_PassHideshow.Size = new System.Drawing.Size(178, 24);
            this.Chk_PassHideshow.TabIndex = 3;
            this.Chk_PassHideshow.Text = "Hide/Show Password";
            this.Chk_PassHideshow.UseVisualStyleBackColor = true;
            this.Chk_PassHideshow.CheckedChanged += new System.EventHandler(this.Chk_PassHideshow_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(534, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 42);
            this.label3.TabIndex = 39;
            this.label3.Text = "Change password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(538, 306);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "New Password again";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(538, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(538, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Old Password";
            // 
            // txt_MK_NhapLai
            // 
            this.txt_MK_NhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txt_MK_NhapLai.Location = new System.Drawing.Point(541, 344);
            this.txt_MK_NhapLai.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MK_NhapLai.Multiline = true;
            this.txt_MK_NhapLai.Name = "txt_MK_NhapLai";
            this.txt_MK_NhapLai.PasswordChar = '*';
            this.txt_MK_NhapLai.Size = new System.Drawing.Size(354, 32);
            this.txt_MK_NhapLai.TabIndex = 2;
            // 
            // txt_MK_Moi
            // 
            this.txt_MK_Moi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txt_MK_Moi.Location = new System.Drawing.Point(541, 236);
            this.txt_MK_Moi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MK_Moi.Multiline = true;
            this.txt_MK_Moi.Name = "txt_MK_Moi";
            this.txt_MK_Moi.PasswordChar = '*';
            this.txt_MK_Moi.Size = new System.Drawing.Size(354, 32);
            this.txt_MK_Moi.TabIndex = 1;
            // 
            // txt_MK_Cu
            // 
            this.txt_MK_Cu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txt_MK_Cu.Location = new System.Drawing.Point(541, 125);
            this.txt_MK_Cu.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MK_Cu.Multiline = true;
            this.txt_MK_Cu.Name = "txt_MK_Cu";
            this.txt_MK_Cu.PasswordChar = '*';
            this.txt_MK_Cu.Size = new System.Drawing.Size(354, 32);
            this.txt_MK_Cu.TabIndex = 0;
            // 
            // btn_DoiMK
            // 
            this.btn_DoiMK.BackColor = System.Drawing.Color.White;
            this.btn_DoiMK.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DoiMK.Image = ((System.Drawing.Image)(resources.GetObject("btn_DoiMK.Image")));
            this.btn_DoiMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DoiMK.Location = new System.Drawing.Point(541, 452);
            this.btn_DoiMK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DoiMK.Name = "btn_DoiMK";
            this.btn_DoiMK.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_DoiMK.Size = new System.Drawing.Size(154, 43);
            this.btn_DoiMK.TabIndex = 4;
            this.btn_DoiMK.Text = "Accept change";
            this.btn_DoiMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DoiMK.UseVisualStyleBackColor = false;
            this.btn_DoiMK.Click += new System.EventHandler(this.btn_DoiMK_Click_1);
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
            this.btn_Thoat.Location = new System.Drawing.Point(772, 454);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Thoat.Size = new System.Drawing.Size(100, 41);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Exist";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(70, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 439);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // FR_DoiMatKhau
            // 
            this.AcceptButton = this.btn_DoiMK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(975, 549);
            this.Controls.Add(this.Chk_PassHideshow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DoiMK);
            this.Controls.Add(this.txt_MK_NhapLai);
            this.Controls.Add(this.txt_MK_Moi);
            this.Controls.Add(this.txt_MK_Cu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FR_DoiMatKhau";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi Mật Khẩu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FR_DoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Chk_PassHideshow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_DoiMK;
        private System.Windows.Forms.TextBox txt_MK_NhapLai;
        private System.Windows.Forms.TextBox txt_MK_Moi;
        private System.Windows.Forms.TextBox txt_MK_Cu;
    }
}