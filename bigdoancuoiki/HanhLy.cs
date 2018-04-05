using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class HanhLy
    {
        public int MaHanhLy { get; set; }
        public double KhoiLuong { get; set; }
        public Khach KHACH { get; set; }
        
        //
        public HanhLy(int MaHanhLy, double KhoiLuong, Khach KHACH)
        {
            this.MaHanhLy = MaHanhLy;
            this.KhoiLuong = KhoiLuong;
            this.KHACH = KHACH;
            
        }
        //
        public HanhLy(HanhLy HANHLY)
        {
            if(HANHLY != null)
            {
                this.MaHanhLy = HANHLY.MaHanhLy;
                this.KhoiLuong = HANHLY.KhoiLuong;
                this.KHACH = HANHLY.KHACH;
                
            }
        }
    }
}
