using DXApplication9.DTO;
using System;
using System.Data;

namespace DXApplication9.DAO
{
    public class ScoreDAO
    {
        private static ScoreDAO instance;

        private ScoreDAO() { }

        public static ScoreDAO Instance
        {
            get
            {
                if (instance == null) instance = new ScoreDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachDiem(string maHocSinh, string maMonHoc, string maHocKy, string maNamHoc, string maLop)
        {
            string query = "EXEC LayDanhSachDiem @maHocSinh , @maMonHoc , @maHocKy , @maNamHoc , @maLop";
            object[] parameters = new object[] { maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public DataTable LayDanhSachDiemHocSinh(string maHocSinh, string maMonHoc, string maHocKy, string maNamHoc, string maLop)
        {
            string query = "EXEC LayDanhSachDiemHocSinh @maHocSinh , @maMonHoc , @maHocKy , @maNamHoc , @maLop";
            object[] parameters = new object[] { maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public void ThemDiem(ScoreDTO diem)
        {
            string query = "EXEC ThemDiem @maHocSinh , @maMonHoc , @maHocKy , @maNamHoc , @maLop , @maLoaiDiem , @diemSo";
            object[] parameters = new object[] {
                diem.MaHocSinh, diem.MaMonHoc, diem.MaHocKy, diem.MaNamHoc, diem.MaLop, diem.MaLoaiDiem, diem.DiemSo
            };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        public void XoaDiem(int stt)
        {
            string query = "EXEC XoaDiem @STT";
            object[] parameters = new object[] { stt };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
    }
}
