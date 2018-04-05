using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class ChiTietGheNgoi
    {
        public VeMayBay VEMAYBAY { get; set; }
        public MayBay MAYBAY { get; set; }
        public ChuyenBay CHUYENBAY { get; set; }
        public KiHieuGheNgoi KIHIEUGHENGOI { get; set; }
        public ChiTietGheNgoi(VeMayBay VEMAYBAY, MayBay MAYBAY, ChuyenBay CHUYENBAY, KiHieuGheNgoi KIHIEUGHENGOI)
        {
            this.VEMAYBAY = VEMAYBAY;
            this.MAYBAY = MAYBAY;
            this.CHUYENBAY = CHUYENBAY;
            this.KIHIEUGHENGOI = KIHIEUGHENGOI;
        }
        //
        public ChiTietGheNgoi(ChiTietGheNgoi CHITIETGHENGOI)
        {
            if(CHITIETGHENGOI != null)
            {
                this.VEMAYBAY = CHITIETGHENGOI.VEMAYBAY ;
                this.MAYBAY = CHITIETGHENGOI.MAYBAY;
                this.CHUYENBAY = CHITIETGHENGOI.CHUYENBAY;
                this.KIHIEUGHENGOI = CHITIETGHENGOI.KIHIEUGHENGOI;
            }
        }
    }
}
