using System.Collections.Generic;
using System;
using DXApplication9.DTO;
using System.Data;
using DXApplication9.DAO;

namespace DXApplication9.BUS
{
    public class KQLHMonHocBUS
    {
        private static KQLHMonHocBUS instance;

        private KQLHMonHocBUS() { }

        public static KQLHMonHocBUS Instance
        {
            get
            {
                if (instance == null) instance = new KQLHMonHocBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void LuuKetQua(string maLop, string maNamHoc, string maMonHoc, string maHocKy)
        {
            LopDTO lop = new LopDTO();
            lop.MaLop = maLop;
            lop.SiSo = LopDAO.Instance.LaySiSo(maLop);

            SubjectDTO monHoc = new SubjectDTO();
            monHoc.MaMonHoc = maMonHoc;

            HocKyDTO hocKy = new HocKyDTO();
            hocKy.MaHocKy = maHocKy;

            NamHocDTO namHoc = new NamHocDTO();
            namHoc.MaNamHoc = maNamHoc;

            int soLuongDat = ScoreBUS.Instance.LaySoLuongDat(maLop, maNamHoc, maMonHoc, maHocKy);
            KQLHMonHocDAO.Instance.XoaKetQua(maLop, maNamHoc, maMonHoc, maHocKy);
            KQLHMonHocDAO.Instance.LuuKetQua(new KQLHMonHocDTO(
                lop,
                namHoc,
                monHoc,
                hocKy,
                soLuongDat,
                Convert.ToSingle(Math.Round(soLuongDat * 100F / lop.SiSo, 2))
            ));
        }

        public IList<KQLHMonHocDTO> Report(string maNamHoc, string maMonHoc, string maHocKy)
        {
            DataTable dataTable = KQLHMonHocDAO.Instance.Report(maNamHoc, maMonHoc, maHocKy);
            IList<KQLHMonHocDTO> ilist = new List<KQLHMonHocDTO>();

            foreach (DataRow Row in dataTable.Rows)
            {
                LopDTO lop = new LopDTO();
                lop.MaLop = Convert.ToString(Row["MaLop"]);
                lop.TenLop = Convert.ToString(Row["TenLop"]);
                lop.SiSo = Convert.ToInt32(Row["SiSo"]);

                NamHocDTO namHoc = new NamHocDTO();
                namHoc.MaNamHoc = Convert.ToString(Row["MaNamHoc"]);
                namHoc.TenNamHoc = Convert.ToString(Row["TenNamHoc"]);

                SubjectDTO monHoc = new SubjectDTO();
                monHoc.MaMonHoc = Convert.ToString(Row["MaMonHoc"]);
                monHoc.TenMonHoc = Convert.ToString(Row["TenMonHoc"]);

                HocKyDTO hocKy = new HocKyDTO();
                hocKy.MaHocKy = Convert.ToString(Row["MaHocKy"]);
                hocKy.TenHocKy = Convert.ToString(Row["TenHocKy"]);

                ilist.Add(new KQLHMonHocDTO(
                    lop,
                    namHoc,
                    monHoc,
                    hocKy,
                    Convert.ToInt32(Row["SoLuongDat"]),
                    Convert.ToSingle(Row["TiLe"])
                ));
            }
            return ilist;
        }
    }
}
