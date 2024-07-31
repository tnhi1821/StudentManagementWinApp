using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DXApplication9.BUS;
using Microsoft.Reporting.WinForms;



namespace DXApplication9
{
    public partial class DanhSachHocSinh : Form
    {
        public DanhSachHocSinh()
        {
            InitializeComponent();
        }

        private void DanhSachHocSinh_Load(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("NgayLap", DateTime.Now.ToString("dd/MM/yyyy")));

            bsDSHS.DataSource = HocSinhBUS.Instance.Report();
            rpvDSHS.LocalReport.SetParameters(param);
            this.rpvDSHS.RefreshReport();
        }

    }
}
