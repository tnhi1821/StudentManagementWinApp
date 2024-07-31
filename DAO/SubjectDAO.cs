using System.Data;

namespace DXApplication9.DAO
{
    public class SubjectDAO
    {
        private static SubjectDAO instance;

        private SubjectDAO() { }

        public static SubjectDAO Instance
        {
            get
            {
                if (instance == null) instance = new SubjectDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachMonHoc()
        {
            string query = "SELECT * FROM MONHOC";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LayDanhSachMonHoc(string namHoc)
        {
            string query = "EXEC LayDanhSachMonHocTheoNam @maNamHoc";
            object[] parameters = new object[] { namHoc };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public DataTable LayDanhSachMonHoc(string namHoc, string lop)
        {
            string query = "EXEC LayDanhSachMonHocTheoLop @maNamHoc , @maLop";
            object[] parameters = new object[] { namHoc, lop };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public void CapNhatMonHoc(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "MONHOC");
        }
    }
}
