using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class VeMayBayLuotVe
    {
        public string MaVeVe { get; set; }        
        public KiHieuGheNgoi KIHIEUGHENGOI { get; set; }
        public ChuyenBay CHUYENBAYVE { get; set; }
        public VeMayBay VEMAYMAY { get; set; }
        public VeMayBayLuotVe(string MaVeVe, KiHieuGheNgoi KIHIEUGHENGOI, ChuyenBay CHUYENBAY,VeMayBay VEMAYBAY)
        {
            this.MaVeVe = MaVeVe;
            this.KIHIEUGHENGOI = KIHIEUGHENGOI;
            this.CHUYENBAYVE = CHUYENBAYVE;
            this.VEMAYMAY = VEMAYMAY;

        }
        public VeMayBayLuotVe(VeMayBayLuotVe VEMAYBAYLUOTVE)
        {
            if (VEMAYBAYLUOTVE != null)
            {
                this.MaVeVe = VEMAYBAYLUOTVE.MaVeVe;
                this.KIHIEUGHENGOI = VEMAYBAYLUOTVE.KIHIEUGHENGOI;
                this.CHUYENBAYVE = VEMAYBAYLUOTVE.CHUYENBAYVE;
                this.VEMAYMAY = VEMAYBAYLUOTVE.VEMAYMAY;
            }
        }
    }
}
