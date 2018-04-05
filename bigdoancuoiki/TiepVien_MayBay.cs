using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class TiepVien_MayBay
    {
        public TiepVienHangKhong TVHK { get; set; }
        public MayBay MAYBAY { get; set; }
        //
        public TiepVien_MayBay(TiepVienHangKhong TVHK, MayBay MAYBAY)
        {
            this.TVHK = TVHK;
            this.MAYBAY = MAYBAY;
        }
        //
        public TiepVien_MayBay(TiepVien_MayBay TV_MB)
        {
            if (TV_MB != null)
            {
                this.TVHK = TV_MB.TVHK;
                this.MAYBAY = TV_MB.MAYBAY;
            }
        }
    }
}
