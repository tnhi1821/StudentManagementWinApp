﻿using DXApplication9.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace DXApplication9
{
    public partial class HoSoLopHoc : Form
    {
        public HoSoLopHoc()
        {
            InitializeComponent();
        }

        private void HoSoLopHoc_Load(object sender, EventArgs e)
        {
            NamHocBUS.Instance.HienThiComboBox(cmbNamHoc);
            if (cmbNamHoc.SelectedValue != null)
                LopBUS.Instance.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
        }

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                LopBUS.Instance.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            cmbLop.DataBindings.Clear();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("NgayLap", DateTime.Now.ToString("dd/MM/yyyy")));
            param.Add(new ReportParameter("NamHoc", cmbNamHoc.Text));
            param.Add(new ReportParameter("Lop", cmbLop.Text));

            DataTable dataTable = LopBUS.Instance.TimTheoMa(cmbLop);
            param.Add(new ReportParameter("SiSo", dataTable.Rows[0]["SiSo"].ToString()));

            bsHSLH.DataSource = null;
            if (cmbLop.SelectedValue != null && cmbNamHoc.SelectedValue != null)
                bsHSLH.DataSource = HocSinhBUS.Instance.Report(
                    cmbNamHoc.SelectedValue.ToString(),
                    cmbLop.SelectedValue.ToString()
                );

            rpvHSLH.LocalReport.SetParameters(param);
            rpvHSLH.RefreshReport();
        }
    }
}
