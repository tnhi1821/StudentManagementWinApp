﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication9.BUS;
using DXApplication9.Components;

namespace DXApplication9
{
    public partial class Term : Form
    {
        public Term()
        {
            InitializeComponent();
        }

        private void Term_Load(object sender, EventArgs e)
        {
            HocKyBUS.Instance.HienThi(dgvHocKy, bindingNavigatorHocKy);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvHocKy.RowCount == 0) bindingNavigatorDeleteItem.Enabled = true;

            BindingSource bindingSource = bindingNavigatorHocKy.BindingSource;
            DataTable dataTable = (DataTable)bindingSource.DataSource;
            DataRow dataRow = dataTable.NewRow();

            dataRow["MaHocKy"] = "";
            dataRow["TenHocKy"] = "";
            dataRow["HeSo"] = 0;

            dataTable.Rows.Add(dataRow);
            bindingSource.MoveLast();
        }


        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string[] colNames = { "colMaHocKy", "colTenHocKy" };
            if (KiemTraTruocKhiLuu.KiemTraDataGridView(dgvHocKy, colNames) &&
                KiemTraTruocKhiLuu.KiemTraHeSo(dgvHocKy, "colHeSo"))
            {
                bindingNavigatorPositionItem.Focus();
                BindingSource bindingSource = bindingNavigatorHocKy.BindingSource;
                HocKyBUS.Instance.CapNhatHocKy((DataTable)bindingSource.DataSource);

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
            if (dgvHocKy.RowCount == 0) bindingNavigatorDeleteItem.Enabled = false;
            else if (
                MessageBox.Show(
                    "Bạn có chắc chắn xóa dòng này không?",
                    "Xóa học kỳ",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                ) == DialogResult.OK
            ) bindingNavigatorHocKy.BindingSource.RemoveCurrent();
        }

    }
}
