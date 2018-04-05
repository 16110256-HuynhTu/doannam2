using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class HangVe
    {
        public int MaHangVe { get; set; }
        public string TenHangVe { get; set; }
        public HangVe(int MaHangVe, string TenHangVe)
        {
            this.MaHangVe = MaHangVe;
            this.TenHangVe = TenHangVe;

        }
        //
        public HangVe(HangVe HANGVE)
        {
            if(HANGVE != null)
            {
                this.MaHangVe = HANGVE.MaHangVe;
                this.TenHangVe = HANGVE.TenHangVe;
            }
        }
    }
}
