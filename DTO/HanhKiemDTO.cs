using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication9.DTO
{
    public class HanhKiemDTO
    {
        private string maHanhKiem;
        private string tenHanhKiem;

        public HanhKiemDTO() { }
        public string MaHanhKiem { get => maHanhKiem; set => maHanhKiem = value; }
        public string TenHanhKiem { get => tenHanhKiem; set => tenHanhKiem = value; }
    }
}
