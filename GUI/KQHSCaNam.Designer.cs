﻿namespace DXApplication9
{
    partial class KQHSCaNam
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
            this.groupPanelDS = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnXem = new DevComponents.DotNetBar.ButtonX();
            this.cmbLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmbNamHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX0 = new DevComponents.DotNetBar.LabelX();
            this.rpvKQHSCN = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KQHSCaNamDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bsKQHSCN = new System.Windows.Forms.BindingSource(this.components);
            this.groupPanelDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KQHSCaNamDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKQHSCN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanelDS
            // 
            this.groupPanelDS.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelDS.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelDS.Controls.Add(this.btnXem);
            this.groupPanelDS.Controls.Add(this.cmbLop);
            this.groupPanelDS.Controls.Add(this.labelX1);
            this.groupPanelDS.Controls.Add(this.cmbNamHoc);
            this.groupPanelDS.Controls.Add(this.labelX0);
            this.groupPanelDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelDS.Location = new System.Drawing.Point(0, 0);
            this.groupPanelDS.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanelDS.Name = "groupPanelDS";
            this.groupPanelDS.Size = new System.Drawing.Size(800, 71);
            // 
            // 
            // 
            this.groupPanelDS.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelDS.Style.BackColorGradientAngle = 90;
            this.groupPanelDS.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelDS.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDS.Style.BorderBottomWidth = 1;
            this.groupPanelDS.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelDS.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDS.Style.BorderLeftWidth = 1;
            this.groupPanelDS.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDS.Style.BorderRightWidth = 1;
            this.groupPanelDS.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDS.Style.BorderTopWidth = 1;
            this.groupPanelDS.Style.CornerDiameter = 4;
            this.groupPanelDS.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelDS.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelDS.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanelDS.TabIndex = 2;
            // 
            // btnXem
            // 
            this.btnXem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXem.Location = new System.Drawing.Point(471, 20);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 26);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cmbLop
            // 
            this.cmbLop.DisplayMember = "Text";
            this.cmbLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.ItemHeight = 14;
            this.cmbLop.Location = new System.Drawing.Point(297, 20);
            this.cmbLop.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(145, 20);
            this.cmbLop.TabIndex = 2;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(260, 20);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(43, 26);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Lớp:";
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.DisplayMember = "Text";
            this.cmbNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.ItemHeight = 14;
            this.cmbNamHoc.Location = new System.Drawing.Point(87, 20);
            this.cmbNamHoc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(145, 20);
            this.cmbNamHoc.TabIndex = 1;
            this.cmbNamHoc.SelectedIndexChanged += new System.EventHandler(this.cmbNamHoc_SelectedIndexChanged);
            // 
            // labelX0
            // 
            this.labelX0.BackColor = System.Drawing.Color.Transparent;
            this.labelX0.Location = new System.Drawing.Point(16, 20);
            this.labelX0.Margin = new System.Windows.Forms.Padding(4);
            this.labelX0.Name = "labelX0";
            this.labelX0.Size = new System.Drawing.Size(76, 26);
            this.labelX0.TabIndex = 0;
            this.labelX0.Text = "Năm học:";
            // 
            // rpvKQHSCN
            // 
            this.rpvKQHSCN.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "KQHSCaNamDTO";
            reportDataSource1.Value = this.KQHSCaNamDTOBindingSource;
            this.rpvKQHSCN.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvKQHSCN.LocalReport.ReportEmbeddedResource = "DXApplication9.KQHSCaNam.rdlc";
            this.rpvKQHSCN.Location = new System.Drawing.Point(0, 71);
            this.rpvKQHSCN.Margin = new System.Windows.Forms.Padding(4);
            this.rpvKQHSCN.Name = "rpvKQHSCN";
            this.rpvKQHSCN.ServerReport.BearerToken = null;
            this.rpvKQHSCN.Size = new System.Drawing.Size(800, 379);
            this.rpvKQHSCN.TabIndex = 3;
            // 
            // KQHSCaNamDTOBindingSource
            // 
            this.KQHSCaNamDTOBindingSource.DataSource = typeof(DXApplication9.DTO.KQHSCaNamDTO);
            // 
            // bsKQHSCN
            // 
            this.bsKQHSCN.AllowNew = false;
            this.bsKQHSCN.DataSource = typeof(DXApplication9.DTO.KQHSCaNamDTO);
            // 
            // KQHSCaNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvKQHSCN);
            this.Controls.Add(this.groupPanelDS);
            this.Name = "KQHSCaNam";
            this.Text = "Báo cáo cả năm của học sinh";
            this.Load += new System.EventHandler(this.KQHSCaNam_Load);
            this.groupPanelDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KQHSCaNamDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKQHSCN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelDS;
        private DevComponents.DotNetBar.ButtonX btnXem;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLop;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHoc;
        private DevComponents.DotNetBar.LabelX labelX0;
        private Microsoft.Reporting.WinForms.ReportViewer rpvKQHSCN;
        private System.Windows.Forms.BindingSource bsKQHSCN;
        private System.Windows.Forms.BindingSource KQHSCaNamDTOBindingSource;
    }
}