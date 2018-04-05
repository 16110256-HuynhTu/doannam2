using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class NguoiThanhToan
    {
        public int MaNguoiThanhToan { get; set; }
        public string TenNguoiThanhToan { get; set; }
        public NguoiThanhToan(int MaNguoiThanhToan, string TenNguoiThanhToan)
        {
            this.MaNguoiThanhToan = MaNguoiThanhToan;
            this.TenNguoiThanhToan = TenNguoiThanhToan ;
        }
        //
        public NguoiThanhToan(NguoiThanhToan NGUOITHANHTOAN)
        {
            if (NGUOITHANHTOAN != null)
            {
                this.MaNguoiThanhToan = NGUOITHANHTOAN.MaNguoiThanhToan;
                this.TenNguoiThanhToan = NGUOITHANHTOAN.TenNguoiThanhToan;
            }
        }
    }
}
