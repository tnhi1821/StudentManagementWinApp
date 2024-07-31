using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication9.DTO;
using DXApplication9.DAO;

namespace DXApplication9.BUS
{
    public class PhanLopBUS
    {
        private static PhanLopBUS instance;

        private PhanLopBUS() { }

        public static PhanLopBUS Instance
        {
            get
            {
                if (instance == null) instance = new PhanLopBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void LuuHocSinhVaoBangPhanLop(string namHoc, string khoiLop, string lop, ListViewEx listViewEx)
        {
            foreach (ListViewItem item in listViewEx.Items)
            {
                PhanLopDTO phanLop = new PhanLopDTO(namHoc, khoiLop, lop, item.SubItems[0].Text.ToString());
                PhanLopDAO.Instance.LuuHocSinhVaoBangPhanLop(phanLop);
            }
        }

        public void XoaHocSinhKhoiBangPhanLop(string namHoc, string khoiLop, string lop, ListViewEx listViewEx)
        {
            foreach (ListViewItem item in listViewEx.Items)
            {
                PhanLopDTO phanLop = new PhanLopDTO(namHoc, khoiLop, lop, item.SubItems[0].Text.ToString());
                PhanLopDAO.Instance.XoaHocSinhKhoiBangPhanLop(phanLop);
            }
        }
    }
}
