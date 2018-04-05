using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class TuyenBay
    {
        public int MaTuyenBay { get; set; }
        public string TenTuyenBay { get; set; }
        public SanBay SANBAYDI { get; set; }
        public SanBay SANBAYDEN { get; set; }
        public TuyenBay(int MaTuyenBay, string TenTuyenBay, SanBay SANBAYDI, SanBay SANBAYDEN)
        {
            this.MaTuyenBay = MaTuyenBay;
            this.TenTuyenBay = TenTuyenBay;
            this.SANBAYDI = SANBAYDI;
            this.SANBAYDEN = SANBAYDEN;

        }
        //
        public TuyenBay(TuyenBay TUYENBAY)
        {
            if (TUYENBAY != null)
            {
                this.MaTuyenBay = TUYENBAY.MaTuyenBay;
                this.TenTuyenBay = TUYENBAY.TenTuyenBay;
                this.SANBAYDI = TUYENBAY.SANBAYDI;
                this.SANBAYDEN = TUYENBAY.SANBAYDEN;
            }
            
        }
    }
}
