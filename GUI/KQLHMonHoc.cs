using DXApplication9.BUS;
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
    public partial class KQLHMonHoc : Form
    {
        public KQLHMonHoc()
        {
            InitializeComponent();
        }

        private void KQLHMonHoc_Load(object sender, EventArgs e)
        {
            NamHocBUS.Instance.HienThiComboBox(cmbNamHoc);
            HocKyBUS.Instance.HienThiComboBox(cmbHocKy);

            if (cmbNamHoc.SelectedValue != null)
                SubjectBUS.Instance.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbMonHoc);
        }

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                SubjectBUS.Instance.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbMonHoc);
            cmbMonHoc.DataBindings.Clear();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("NgayLap", DateTime.Now.ToString("dd/MM/yyyy")));
            param.Add(new ReportParameter("NamHoc", cmbNamHoc.Text));
            param.Add(new ReportParameter("HocKy", cmbHocKy.Text));
            param.Add(new ReportParameter("MonHoc", cmbMonHoc.Text));

            bsKQLHMH.DataSource = null;
            if (cmbMonHoc.SelectedValue != null && cmbHocKy.SelectedValue != null && cmbNamHoc.SelectedValue != null)
                bsKQLHMH.DataSource = KQLHMonHocBUS.Instance.Report(
                cmbNamHoc.SelectedValue.ToString(),
                cmbMonHoc.SelectedValue.ToString(),
                cmbHocKy.SelectedValue.ToString()
            );

            rpvKQLHMH.LocalReport.SetParameters(param);
            rpvKQLHMH.RefreshReport();
        }
    }
}
