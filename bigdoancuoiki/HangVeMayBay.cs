using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class HangVeMayBay
    {
        public int MaHangVeMayBay { get; set; }
        public string TenHang { get; set; }
        public string MucDoTinCay { get; set; }
        public string DanhGiaGiaThanh { get; set; }
        public HangVeMayBay(int MaHangVeMayBay, string TenHang, string MucDoTinCay, string DanhGiaGiaThanh)
        {
            this.MaHangVeMayBay = MaHangVeMayBay;
            this.TenHang = TenHang;
            this.MucDoTinCay = MucDoTinCay;
            this.DanhGiaGiaThanh = DanhGiaGiaThanh;
        }
        //
        public HangVeMayBay(HangVeMayBay HANGVEMAYBAY)
        {
            if (HANGVEMAYBAY != null)
            {
                this.MucDoTinCay = HANGVEMAYBAY.MucDoTinCay;
                this.TenHang = HANGVEMAYBAY.TenHang;
                this.MucDoTinCay = HANGVEMAYBAY.MucDoTinCay;
                this.DanhGiaGiaThanh = HANGVEMAYBAY.DanhGiaGiaThanh;
            }
        }

    }
}
