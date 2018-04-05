using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class LoaiKhach
    {
        public int MaLoaiKhach { get; set; }
        public string TenLoaiKhach { get; set; }
        public string HinhThucUuDai { get; set; }
        //
        public LoaiKhach(int MaLoaiKhach, string TenLoaiKhach, string HinhThucUuDai)
        {
            this.MaLoaiKhach = MaLoaiKhach;
            this.TenLoaiKhach = TenLoaiKhach;
            this.HinhThucUuDai = HinhThucUuDai;
        }
        //
        public LoaiKhach(LoaiKhach LOAIKHACH)
        {
            if (LOAIKHACH != null)
            {
                this.MaLoaiKhach = LOAIKHACH.MaLoaiKhach;
                this.TenLoaiKhach = LOAIKHACH.TenLoaiKhach;
                this.HinhThucUuDai = LOAIKHACH.HinhThucUuDai;
            }
        }
    }
}
