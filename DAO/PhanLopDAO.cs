using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DXApplication9.DTO;

namespace DXApplication9.DAO
{
    public class PhanLopDAO
    {
        private static PhanLopDAO instance;

        private PhanLopDAO() { }

        public static PhanLopDAO Instance
        {
            get
            {
                if (instance == null) instance = new PhanLopDAO();
                return instance;
            }
            private set => instance = value;
        }

        public void LuuHocSinhVaoBangPhanLop(PhanLopDTO phanLop)
        {
            string query = "EXEC LuuHocSinhVaoBangPhanLop @maNamHoc , @maKhoiLop , @maLop , @maHocSinh";
            object[] parameters = new object[] { phanLop.MaNamHoc, phanLop.MaKhoiLop, phanLop.MaLop, phanLop.MaHocSinh };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        public void XoaHocSinhKhoiBangPhanLop(PhanLopDTO phanLop)
        {
            string query = "EXEC XoaHocSinhKhoiBangPhanLop @maNamHoc , @maKhoiLop , @maLop , @maHocSinh";
            object[] parameters = new object[] { phanLop.MaNamHoc, phanLop.MaKhoiLop, phanLop.MaLop, phanLop.MaHocSinh };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
    }
}
