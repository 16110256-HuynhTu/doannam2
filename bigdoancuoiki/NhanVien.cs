using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class NhanVien
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string ViTri { get; set; }
        public long ID { get; set; }
        public SanBay SANBAY { get; set; }
        //
        public NhanVien(int MaNV, string TenNV, string ViTri, long ID, SanBay SANBAY)
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.ViTri = ViTri;
            this.ID = ID;
            this.SANBAY = SANBAY;
        }
        //
        public NhanVien(NhanVien NHANVIEN)
        {
            if (NHANVIEN != null)
            {
                this.MaNV = NHANVIEN.MaNV;
                this.TenNV = NHANVIEN.TenNV;
                this.ViTri = NHANVIEN.ViTri;
                this.ID = NHANVIEN.ID;
                this.SANBAY = NHANVIEN.SANBAY;
            }
        }
    }
}
