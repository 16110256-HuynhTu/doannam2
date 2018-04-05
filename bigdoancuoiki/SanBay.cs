using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class SanBay
    {
        public int MaSB { get; set; }
        public string TenSanBay { get; set; }
        public string DienTich { get; set; }
        public string ChatLuong { get; set; }


        //
        public SanBay(int MaSB, string TenSanBay, string DienTich, string ChatLuong)
        {
            this.MaSB = MaSB;
            this.TenSanBay = TenSanBay;
            this.DienTich = DienTich;
            this.ChatLuong = ChatLuong;
        }
        //
        public SanBay(SanBay SANBAY)
        {

            if (SANBAY != null)
            {
                this.MaSB = SANBAY.MaSB;
                this.TenSanBay = SANBAY.TenSanBay;
                this.DienTich = SANBAY.DienTich;
                this.ChatLuong = SANBAY.ChatLuong;
            }
        }
    }
}
