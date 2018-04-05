using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class Khach
    {
        public int MaKhach { get; set; }
        public string TenKhach { get; set; }
        public string GioiTinh { get; set; }
        public string SoDT { get; set; }
        public long ID { get; set; }
        public string QuocTich { get; set; }
        public LoaiKhach LOAIKHACH { get; set; }

        public Khach(int MaKhach, string TenKhach, string GioiTinh, string SoDT, long ID, string QuocTich, LoaiKhach LOAIKHACH)
        {
            this.MaKhach = MaKhach;
            this.TenKhach = TenKhach;
            this.GioiTinh = GioiTinh;
            this.SoDT = SoDT;
            this.ID = ID;
            this.QuocTich = QuocTich;
            this.LOAIKHACH = LOAIKHACH;

        }
        //
        public Khach(Khach KHACH)
        {
            if (KHACH != null)
            {
                this.MaKhach = KHACH.MaKhach;
                this.TenKhach = KHACH.TenKhach;
                this.GioiTinh = KHACH.GioiTinh;
                this.SoDT = KHACH.SoDT;
                this.ID = KHACH.ID;
                this.QuocTich = KHACH.QuocTich;
                this.LOAIKHACH = KHACH.LOAIKHACH;

            }

        }
    }
}
