using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public string NgayThanhToan { get; set; }
        
        public HoaDon(int MaHoaDon, string NgayThanhToan)
        {
            this.MaHoaDon = MaHoaDon;
            this.NgayThanhToan = NgayThanhToan;
            
        }
        public HoaDon(HoaDon HOADON)
        {
            if (HOADON != null)
            {
                this.MaHoaDon = HOADON.MaHoaDon;
                this.NgayThanhToan = HOADON.NgayThanhToan;
               
            }
        }
    }
}
