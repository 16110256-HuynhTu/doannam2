using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class PhiCong_MayBay
    {
        public PhiCong PHICONG { get; set; }
        public MayBay MAYBAY { get; set; }
        public PhiCong_MayBay(PhiCong PHICONG, MayBay MAYBAY)
        {
            this.PHICONG = PHICONG;
            this.MAYBAY = MAYBAY;
        }
        //
        public PhiCong_MayBay(PhiCong_MayBay PC_MB)
        {
            if(PC_MB != null)
            {
                this.PHICONG = PC_MB.PHICONG;
                this.MAYBAY = PC_MB.MAYBAY;
            }
        }
    }
}
