using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigdoancuoiki
{
    public class PhiCong
    {
        public int MaPC { get; set; }
        public string TenPC { get; set; }
        public long ID { get; set; }
        public string QuocTich { get; set; }
        //
        public PhiCong(int MaPC, string TenPC, long ID, string QuocTich)
        {
            this.MaPC = MaPC;
            this.TenPC = TenPC;
            this.ID = ID;
            this.QuocTich = QuocTich;
        }
        public PhiCong(PhiCong PHICONG)
        {
            if (PHICONG != null)
            {
                this.MaPC = PHICONG.MaPC;
                this.TenPC = PHICONG.TenPC;
                this.ID = PHICONG.ID;
                this.QuocTich = PHICONG.QuocTich;
            }
        }
    }
}
