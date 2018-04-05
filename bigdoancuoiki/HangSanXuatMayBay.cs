using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class HangSanXuatMayBay
    {
        public int MaHangSanXuatMayBay { get; set; }
        public string TenHangSanXuat { get; set; }

        public HangSanXuatMayBay(int MaHangSanXuatMayBay, string TenHangSanXuat)
        {
            this.MaHangSanXuatMayBay = MaHangSanXuatMayBay;
            this.TenHangSanXuat = TenHangSanXuat;

        }
        //
        public HangSanXuatMayBay(HangSanXuatMayBay HSXMB)
        {
            if(HSXMB != null)
            {
                this.MaHangSanXuatMayBay = HSXMB.MaHangSanXuatMayBay;
                this.TenHangSanXuat = HSXMB.TenHangSanXuat;
            }

        }
    }
}
