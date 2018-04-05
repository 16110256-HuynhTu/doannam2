using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class LoaiVe
    {
        public int MaLoaiVe { get; set; }
        public string TenLoaiVe { get; set; }
        public LoaiVe(int MaLoaiVe, string TenLoaiVe)
        {
            this.MaLoaiVe = MaLoaiVe;
            this.TenLoaiVe = TenLoaiVe;
        }
        //
        public LoaiVe(LoaiVe LOAIVE)
        {
            if (LOAIVE != null)
            {
                this.MaLoaiVe = LOAIVE.MaLoaiVe;
                this.TenLoaiVe = LOAIVE.TenLoaiVe;
            }
        }
    }
}
