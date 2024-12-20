namespace GUI.BaoCao
{
    partial class baocaodiem
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
            this.reportViewer_diem = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer_diem
            // 
            this.reportViewer_diem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer_diem.Location = new System.Drawing.Point(0, 0);
            this.reportViewer_diem.Name = "reportViewer_diem";
            this.reportViewer_diem.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer_diem.ServerReport.BearerToken = null;
            this.reportViewer_diem.Size = new System.Drawing.Size(772, 471);
            this.reportViewer_diem.TabIndex = 0;
            // 
            // baocaodiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 471);
            this.Controls.Add(this.reportViewer_diem);
            this.Name = "baocaodiem";
            this.Text = "BAOCAO";
            this.Load += new System.EventHandler(this.BAOCAO_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_diem;
    }
}