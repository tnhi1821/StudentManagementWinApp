using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DXApplication9.DAO;
using DevComponents.DotNetBar.Controls;

namespace DXApplication9.BUS
{
    public class KetQuaBUS
    {
        private static KetQuaBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private KetQuaBUS() { }

        public static KetQuaBUS Instance
        {
            get
            {
                if (instance == null) instance = new KetQuaBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridViewX dataGridViewX, BindingNavigator bindingNavigator)
        {

            bindingSource.DataSource = KetQuaDAO.Instance.LayDanhSachKetQua();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void CapNhatKetQua(DataTable dataTable)
        {
            KetQuaDAO.Instance.CapNhatKetQua(dataTable);
        }
    }
}
