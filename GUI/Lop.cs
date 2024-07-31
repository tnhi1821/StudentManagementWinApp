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
using DXApplication9.BUS;
using DXApplication9.DTO;
using DevComponents.DotNetBar;
using DXApplication9.Components;

namespace DXApplication9
{
    public partial class Lop : DevExpress.XtraEditors.XtraForm
    {
        public Lop()
        {
            InitializeComponent();
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            KhoiLopBUS.Instance.HienThiComboBox(cmbKhoiLop);
            NamHocBUS.Instance.HienThiComboBox(cmbNamHoc);
            KhoiLopBUS.Instance.HienThiDgvCmbCol(colMaKhoiLop);
            NamHocBUS.Instance.HienThiDgvCmbCol(colMaNamHoc);
            bindingNavigatorRefreshItem_Click(sender, e);
        }

        private void btnLuuVaoDS_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMaLop.Text) ||
                string.IsNullOrWhiteSpace(txtTenLop.Text) ||
                cmbKhoiLop.SelectedValue == null ||
                cmbNamHoc.SelectedValue == null ||
                !QuyDinhBUS.Instance.KiemTraSiSo(iniSiSo.Value))
                MessageBox.Show(
                    "Giá trị của các ô không được rỗng và sỉ số phải theo quy định !",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            else
            {
                LopDTO lop = new LopDTO(
                    txtMaLop.Text,
                    txtTenLop.Text,
                    cmbKhoiLop.SelectedValue.ToString(),
                    cmbNamHoc.SelectedValue.ToString(),
                    iniSiSo.Value
                );
                LopBUS.Instance.ThemLop(lop);
                bindingNavigatorRefreshItem_Click(sender, e);
            }
        }

        private void btnThemKhoiLop_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("Khoi_Lop");
            KhoiLopBUS.Instance.HienThiDgvCmbCol(colMaKhoiLop);
        }

        private void btnThemNamHoc_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("Nam_hoc");
            NamHocBUS.Instance.HienThiDgvCmbCol(colMaNamHoc);
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string[] colNames = { "colMaLop", "colTenLop", "colMaKhoiLop", "colMaNamHoc" };
            if (KiemTraTruocKhiLuu.KiemTraDataGridView(dgvLop, colNames) &&
                KiemTraTruocKhiLuu.KiemTraSiSo(dgvLop, "colSiSo"))
            {
                bindingNavigatorPositionItem.Focus();
                BindingSource bindingSource = bindingNavigatorLop.BindingSource;
                LopBUS.Instance.CapNhatLop((DataTable)bindingSource.DataSource);

                MessageBox.Show(
                    "Dữ liệu đã được lưu vào CSDL",
                    "Cập nhật thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvLop.RowCount == 0) bindingNavigatorDeleteItem.Enabled = false;
            else if (
                MessageBox.Show(
                    "Bạn có chắc chắn xóa dòng này không ?",
                    "Xóa lớp học",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                ) == DialogResult.OK
                    ) bindingNavigatorLop.BindingSource.RemoveCurrent();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
                LopBUS.Instance.HienThi(
                bindingNavigatorLop,
                dgvLop,
                txtMaLop,
                txtTenLop,
                cmbKhoiLop,
                cmbNamHoc,
                iniSiSo
            );
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvLop.RowCount == 0) bindingNavigatorDeleteItem.Enabled = true;

            BindingSource bindingSource = bindingNavigatorLop.BindingSource;
            DataTable dataTable = (DataTable)bindingSource.DataSource;
            DataRow dataRow = dataTable.NewRow();

            dataRow["MaLop"] = "";
            dataRow["TenLop"] = "";
            dataRow["MaKhoiLop"] = "";
            dataRow["MaNamHoc"] = "";
            dataRow["SiSo"] = 0;

            dataTable.Rows.Add(dataRow);
            bindingSource.MoveLast();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (chkTimTheoMa.Checked) LopBUS.Instance.TimTheoMa(txtTimKiem.Text);
            else LopBUS.Instance.TimTheoTen(txtTimKiem.Text);
        }
    }
}