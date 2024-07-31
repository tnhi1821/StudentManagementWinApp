using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevComponents.DotNetBar;
using DXApplication9.BUS;
using DXApplication9.Components;

namespace DXApplication9
{
    public partial class Hanh_kiem : DevExpress.XtraEditors.XtraForm
    {
        public Hanh_kiem()
        {
            InitializeComponent();
        }


        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string[] colNames = { "colMaHanhKiem", "colTenHanhKiem" };
            if (KiemTraTruocKhiLuu.KiemTraDataGridView(dgvHanhKiem, colNames))
            {
                bindingNavigatorPositionItem.Focus();
                BindingSource bindingSource = bindingNavigatorHanhKiem.BindingSource;
                HanhKiemBUS.Instance.CapNhatHanhKiem((DataTable)bindingSource.DataSource);

                MessageBox.Show(
                    "Dữ liệu đã được lưu vào CSDL",
                    "Cập nhật thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void Hanh_kiem_Load(object sender, EventArgs e)
        {
            HanhKiemBUS.Instance.HienThi(dgvHanhKiem, bindingNavigatorHanhKiem);
        }
    }
}