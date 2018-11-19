using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class LoaiPhong_DTO
    {
        private string tenloaiphong;

        public string Tenlp
        {
            get { return tenloaiphong; }
            set { tenloaiphong = value; }
        }
        private int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        private int giaphong;

        public int Giaphong
        {
            get { return giaphong; }
            set { giaphong = value; }
        }
    }
}
