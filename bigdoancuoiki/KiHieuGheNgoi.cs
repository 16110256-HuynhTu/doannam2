using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class KiHieuGheNgoi
    {
        public string MaKiHieuGheNgoi { get; set; }
        public string TenKiHieuGheNgoi { get; set; }
        //
        public KiHieuGheNgoi(string MaKiHieuGheNgoi, string TenKiHieuGheNgoi)
        {
            this.MaKiHieuGheNgoi = MaKiHieuGheNgoi;
            this.TenKiHieuGheNgoi = TenKiHieuGheNgoi;

        }
        //
        public KiHieuGheNgoi(KiHieuGheNgoi KIHIEUGHENGOI)
        {
            if(KIHIEUGHENGOI != null)
            {
                this.MaKiHieuGheNgoi = KIHIEUGHENGOI.MaKiHieuGheNgoi;
                this.TenKiHieuGheNgoi = KIHIEUGHENGOI.TenKiHieuGheNgoi;
            }
        }
    }
}
