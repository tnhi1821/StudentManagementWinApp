namespace DXApplication9.DTO
{
    public class KQLHMonHocDTO
    {
        private LopDTO lop;
        private NamHocDTO namHoc;
        private SubjectDTO monHoc;
        private HocKyDTO hocKy;
        private int soLuongDat;
        private float tiLe;

        public KQLHMonHocDTO(
            LopDTO lop,
            NamHocDTO namHoc,
            SubjectDTO monHoc,
            HocKyDTO hocKy,
            int soLuongDat,
            float tiLe)
        {
            this.lop = lop;
            this.namHoc = namHoc;
            this.monHoc = monHoc;
            this.hocKy = hocKy;
            this.soLuongDat = soLuongDat;
            this.tiLe = tiLe;
        }

        public LopDTO Lop { get => lop; set => lop = value; }
        public NamHocDTO NamHoc { get => namHoc; set => namHoc = value; }
        public SubjectDTO MonHoc { get => monHoc; set => monHoc = value; }
        public HocKyDTO HocKy { get => hocKy; set => hocKy = value; }
        public int SoLuongDat { get => soLuongDat; set => soLuongDat = value; }
        public float TiLe { get => tiLe; set => tiLe = value; }

        public string MaLop
        {
            get => Lop.MaLop;
            set => Lop.MaLop = value;
        }

        public string TenLop
        {
            get => Lop.TenLop;
            set => Lop.TenLop = value;
        }

        public int SiSo
        {
            get => Lop.SiSo;
            set => Lop.SiSo = value;
        }
    }
}
