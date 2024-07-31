using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication9.DTO
{
    public class LopDTO
    {
        private string maLop;
        private string tenLop;
        private string maKhoiLop;
        private string maNamHoc;
        private int siSo;

        public LopDTO() { }
        public LopDTO(string maLop, string tenLop, string maKhoiLop, string maNamHoc, int siSo)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.maKhoiLop = maKhoiLop;
            this.maNamHoc = maNamHoc;
            this.siSo = siSo;
        }
        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string MaKhoiLop { get => maKhoiLop; set => maKhoiLop = value; }
        public string MaNamHoc { get => maNamHoc; set => maNamHoc = value; }
        public int SiSo { get => siSo; set => siSo = value; }
    }
    }
