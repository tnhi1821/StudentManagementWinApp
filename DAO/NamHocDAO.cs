﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DXApplication9.DAO
{
    public class NamHocDAO
    {
        private static NamHocDAO instance;

        private NamHocDAO() { }

        public static NamHocDAO Instance
        {
            get
            {
                if (instance == null) instance = new NamHocDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachNamHoc()
        {
            string query = "SELECT * FROM NAMHOC";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void CapNhatNamHoc(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "NAMHOC");
        }
    }
}
