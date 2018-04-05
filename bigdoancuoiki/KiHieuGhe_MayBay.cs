using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class KiHieuGhe_MayBay
    {
        public KiHieuGheNgoi KIHIEUGHENGOI { get; set; }
        public MayBay MAYBAY { get; set; }
        public KiHieuGhe_MayBay(KiHieuGheNgoi KIHIEUGHENGOI, MayBay MAYBAY)
        {
            this.KIHIEUGHENGOI = KIHIEUGHENGOI;
            this.MAYBAY = MAYBAY;
        }
        //
        public KiHieuGhe_MayBay(KiHieuGhe_MayBay KIHIEUGHE_MAYBAY)
        {
            if(KIHIEUGHE_MAYBAY != null)
            {
                this.KIHIEUGHENGOI = KIHIEUGHE_MAYBAY.KIHIEUGHENGOI;
                this.MAYBAY = KIHIEUGHE_MAYBAY.MAYBAY;
            }
        }
    }
}
