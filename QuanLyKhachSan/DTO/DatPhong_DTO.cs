using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class DatPhong_DTO
    {
        private string madp;

        public string Madp
        {
            get { return madp; }
            set { madp = value; }
        }
        private string manv;

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        private string makh;

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        private string tenloaiphong;

        public string Tenlp
        {
            get { return tenloaiphong; }
            set { tenloaiphong = value; }
        }
        private DateTime ngaydat;

        public DateTime Ngaydat
        {
            get { return ngaydat; }
            set { ngaydat = value; }
        }
        private DateTime ngayden;

        public DateTime Ngayden
        {
            get { return ngayden; }
            set { ngayden = value; }
        }
        private DateTime ngaydi;

        public DateTime Ngaydi
        {
            get { return ngaydi; }
            set { ngaydi = value; }
        }
        private int tiendatcoc;

        public int Tiendatcoc
        {
            get { return tiendatcoc; }
            set { tiendatcoc = value; }
        }
        private int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        private bool trangthai;

        public bool Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
        

        public DatPhong_DTO()
        {

        }
        public DatPhong_DTO(string madp, string manv, string makh, string tenlp, DateTime ngaydat, DateTime ngayden, DateTime ngaydi, int tiencoc, int soluong, bool trangthai)
        {
            this.madp = madp;
            this.manv = manv;
            this.makh = makh;
            this.tenloaiphong  = tenlp;
            this.ngaydat = ngaydat;
            this.ngayden = ngayden;
            this.ngaydi = ngaydi;
            this.tiendatcoc = tiencoc;
            this.soluong = soluong;
            this.trangthai = trangthai;
        }
    }
}
