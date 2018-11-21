using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class KhachHang_DTO
    {
        private string makh;

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        private string hoten;

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        private string cmnd;

        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        private string sdt;

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public KhachHang_DTO()
        {

        }
        public KhachHang_DTO(string makh, string hoten, string cmnd, string sdt, string email, string diaChi)
        {
            this.makh = makh;
            this.hoten = hoten;
            this.cmnd = cmnd;
            this.sdt = sdt;
            this.email = email;
            this.diachi = diaChi;
        }

       
    }

    

}
