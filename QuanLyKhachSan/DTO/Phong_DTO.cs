using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Phong_DTO
    {
        private string maphong;

        public string Maphong
        {
            get { return maphong; }
            set { maphong = value; }
        }
        private string tenloaiphong;

        public string Tenlp
        {
            get { return tenloaiphong; }
            set { tenloaiphong = value; }
        }
        private bool tinhtrang;

        public bool Tinhtrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }

        public Phong_DTO() { }
        public Phong_DTO(string maphong, string tenphong, bool tinhtrang)
        {
            this.maphong = maphong;
            this.tenloaiphong = tenphong;
            this.tinhtrang = tinhtrang;
        }

    }
}
