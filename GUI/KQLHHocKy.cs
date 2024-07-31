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
    public partial class KQLHHocKy : Form
    {
        public KQLHHocKy()
        {
            InitializeComponent();
        }

        private void KQLHHocKy_Load(object sender, EventArgs e)
        {
            NamHocBUS.Instance.HienThiComboBox(cmbNamHoc);
            HocKyBUS.Instance.HienThiComboBox(cmbHocKy);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("NgayLap", DateTime.Now.ToString("dd/MM/yyyy")));
            param.Add(new ReportParameter("NamHoc", cmbNamHoc.Text));
            param.Add(new ReportParameter("HocKy", cmbHocKy.Text));

            bsKQLHHK.DataSource = null;
            if (cmbHocKy.SelectedValue != null && cmbNamHoc.SelectedValue != null)
                bsKQLHHK.DataSource = KQLHHocKyBUS.Instance.Report(
                cmbNamHoc.SelectedValue.ToString(),
                cmbHocKy.SelectedValue.ToString()
            );

            rpvKQLHHK.LocalReport.SetParameters(param);
            rpvKQLHHK.RefreshReport();
        }
    }
}
