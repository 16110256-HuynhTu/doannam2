using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class MayBay
    {
        public int MaMB { get; set; }
        public string TenMayBay { get; set; }
        public string XuatXu { get; set; }
        public HangVeMayBay HVMB { get; set; }
        public HangSanXuatMayBay HSXMB { get; set; }
        
        //
        public MayBay(int MaMB, string TenMayBay, string XuatXu, HangVeMayBay HVMB, HangSanXuatMayBay HSXMB)
        {
            this.MaMB = MaMB;
            this.TenMayBay = TenMayBay;
            this.XuatXu = XuatXu;
            this.HVMB = HVMB;
            this.HSXMB = HSXMB;
            
        }
        //
        public MayBay(MayBay MAYBAY)
        {
            if (MAYBAY != null)
            {
                this.MaMB = MAYBAY.MaMB;
                this.TenMayBay = MAYBAY.TenMayBay;
                this.XuatXu = MAYBAY.XuatXu;
                this.HVMB = MAYBAY.HVMB;
                this.HSXMB = MAYBAY.HSXMB;
                
            }
        }
    }
}
