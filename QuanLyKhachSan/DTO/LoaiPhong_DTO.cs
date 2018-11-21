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

        public LoaiPhong_DTO()
        {

        }
        public LoaiPhong_DTO(string tenloaiphong, int soluong, int giaphong)
        {
            this.tenloaiphong = tenloaiphong;
            this.soluong = soluong;
            this.giaphong = giaphong;
        }

    }
}
