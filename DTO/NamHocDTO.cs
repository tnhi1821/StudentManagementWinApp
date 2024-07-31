using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication9.DTO
{
    public class NamHocDTO
    {
        private string maNamHoc;
        private string tenNamHoc;

        public NamHocDTO() { }
        public string MaNamHoc { get => maNamHoc; set => maNamHoc = value; }
        public string TenNamHoc { get => tenNamHoc; set => tenNamHoc = value; }
    }
}


