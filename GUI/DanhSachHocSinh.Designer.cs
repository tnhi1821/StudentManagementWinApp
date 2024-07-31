namespace DXApplication9
{
    partial class DanhSachHocSinh
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HocSinhDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvDSHS = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bsDSHS = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.HocSinhDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSHS)).BeginInit();
            this.SuspendLayout();
            // 
            // HocSinhDTOBindingSource
            // 
            this.HocSinhDTOBindingSource.DataSource = typeof(DXApplication9.DTO.HocSinhDTO);
            // 
            // rpvDSHS
            // 
            this.rpvDSHS.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HocSinhDTO";
            reportDataSource1.Value = this.HocSinhDTOBindingSource;
            this.rpvDSHS.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvDSHS.LocalReport.ReportEmbeddedResource = "DXApplication9.DanhSachHocSinh.rdlc";
            this.rpvDSHS.Location = new System.Drawing.Point(0, 0);
            this.rpvDSHS.Name = "rpvDSHS";
            this.rpvDSHS.ServerReport.BearerToken = null;
            this.rpvDSHS.Size = new System.Drawing.Size(1015, 450);
            this.rpvDSHS.TabIndex = 0;
            // 
            // bsDSHS
            // 
            this.bsDSHS.DataSource = typeof(DXApplication9.DTO.HocSinhDTO);
            // 
            // DanhSachHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.Controls.Add(this.rpvDSHS);
            this.Name = "DanhSachHocSinh";
            this.Text = "Danh sách học sinh";
            this.Load += new System.EventHandler(this.DanhSachHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HocSinhDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSHS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDSHS;
        private System.Windows.Forms.BindingSource bsDSHS;
        private System.Windows.Forms.BindingSource HocSinhDTOBindingSource;
    }

}