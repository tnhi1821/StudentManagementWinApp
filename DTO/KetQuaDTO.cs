using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication9.DTO
{
    public class KetQuaDTO
    {
        private string maKetQua;
        private string tenKetQua;

        public KetQuaDTO() { }
        public string MaKetQua { get => maKetQua; set => maKetQua = value; }
        public string TenKetQua
        {
            get => tenKetQua; set => tenKetQua = value;
        }
    }
}
