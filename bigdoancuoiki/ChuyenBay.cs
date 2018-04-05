using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class ChuyenBay
    {
        public int MaCB { get; set; }
        public string ThoiGianbay { get; set; }
        public string ThoiGianXuatPhat { get; set; }
        public PhiCong PCT { get; set; }
        public PhiCong PCP { get; set; }
        public MayBay MAYBAY { get; set; }
        public TuyenBay TB { get; set; }


        //
        public ChuyenBay(int MaCB, string ThoiGianbay, string ThoiGianXuatPhat, PhiCong PCT, PhiCong PCP,
            MayBay MAYBAY,  TuyenBay TB)
        {
            this.MaCB = MaCB;
            this.ThoiGianbay = ThoiGianbay;
            this.ThoiGianXuatPhat = ThoiGianXuatPhat;
            this.PCT = PCT;
            this.PCP = PCP;
            this.MAYBAY = MAYBAY;            
            this.TB = TB;
        }
        //
        public ChuyenBay(ChuyenBay CHUYENBAY)
        {
            if(CHUYENBAY!= null)
            {
                this.MaCB = CHUYENBAY.MaCB;
                this.ThoiGianbay = CHUYENBAY.ThoiGianbay;
                this.ThoiGianXuatPhat = CHUYENBAY.ThoiGianXuatPhat;
                this.PCT = CHUYENBAY.PCT;
                this.PCP = CHUYENBAY.PCP;
                this.MAYBAY = CHUYENBAY.MAYBAY;                
                this.TB = CHUYENBAY.TB;
            }                       
        }
    }
}
