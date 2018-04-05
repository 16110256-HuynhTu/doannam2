using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class VeMayBay
    {
        public string MaVe { get; set; }
        public long GiaTien { get; set; }
        public LoaiVe LOAIVE { get; set; }
        public HangVe HANGVE { get; set; }
        public HoaDon HOADON { get; set; }
        public Khach KHACH { get; set; }
        
        public KiHieuGheNgoi KIHIEUGHENGOI { get; set; }
        public ChuyenBay CHUYENBAYDI { get; set; }
        public VeMayBay(string MaVe,KiHieuGheNgoi KIHIEUGHENGOI, ChuyenBay CHUYENBAYDI, LoaiVe LOAIVE, HangVe HANGVE, HoaDon HOADON, Khach KHACH,long GiaTien)
        {
            this.MaVe = MaVe;
            this.LOAIVE = LOAIVE;
            this.HANGVE = HANGVE;
            this.HOADON = HOADON;
            this.KHACH = KHACH;
            
            this.GiaTien = GiaTien;
            this.CHUYENBAYDI = CHUYENBAYDI;
            this.KIHIEUGHENGOI = KIHIEUGHENGOI;
        }
        //
        public VeMayBay(VeMayBay VEMAYBAY)
        {
            if (VEMAYBAY != null)
            {
                this.MaVe = VEMAYBAY.MaVe;               
                this.LOAIVE = VEMAYBAY.LOAIVE;
                this.HANGVE = VEMAYBAY.HANGVE;
                this.HOADON = VEMAYBAY.HOADON;
                this.KHACH = VEMAYBAY.KHACH;
                
                this.GiaTien = VEMAYBAY.GiaTien;
                this.CHUYENBAYDI = VEMAYBAY.CHUYENBAYDI;
                this.KIHIEUGHENGOI = VEMAYBAY.KIHIEUGHENGOI;
            }
        }
    }
}
