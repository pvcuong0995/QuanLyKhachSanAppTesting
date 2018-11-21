using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class CTDP_DTO
    {
        private string madp;

        public string Madp
        {
            get { return madp; }
            set { madp = value; }
        }
        private string maphong;

        public string Maphong
        {
            get { return maphong; }
            set { maphong = value; }
        }

        public CTDP_DTO()
        {

        }
        public CTDP_DTO(string madp, string maphong)
        {
            this.madp = madp;
            this.maphong = maphong;
        }

    }
}
