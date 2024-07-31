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
    public partial class Hoc_luc : DevExpress.XtraEditors.XtraForm
    {
        public Hoc_luc()
        {
            InitializeComponent();
        }

        private void Hoc_luc_Load(object sender, EventArgs e)
        {
            HocLucBUS.Instance.HienThi(dgvHocLuc, bindingNavigatorHocLuc);
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string[] colDgvNames = { "colMaHocLuc", "colTenHocLuc" };
            string[] colDiemNames = { "colDiemCanTren", "colDiemCanDuoi", "colDiemKhongChe" };

            if (KiemTraTruocKhiLuu.KiemTraDataGridView(dgvHocLuc, colDgvNames) &&
                KiemTraTruocKhiLuu.KiemTraDiem(dgvHocLuc, colDiemNames))
            {
                bindingNavigatorPositionItem.Focus();
                BindingSource bindingSource = bindingNavigatorHocLuc.BindingSource;
                HocLucBUS.Instance.CapNhatHocLuc((DataTable)bindingSource.DataSource);

                MessageBox.Show(
                    "Dữ liệu đã được lưu vào CSDL",
                    "Cập nhật thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}