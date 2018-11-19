using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class User_DTO
    {
        private string manv;

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string mk;

        public string Mk
        {
            get { return mk; }
            set { mk = value; }
        }
        public User_DTO ()
        {

        }
        public User_DTO(string manv, string mk)
        {
            this.manv = manv;
            this.mk = mk;
        }
    }
}
