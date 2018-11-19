using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DAL;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.BLL
{
    public class User_BLL
    {
        DBAccess db = new DBAccess();

        public DataTable checkLogin(string manv, string mk)
        {
            string strGetAd = "Select * From quyennv Where manv = '" + manv + "' and matkhau = '" + mk + "'";
                DBAccess d = new DBAccess();
                DataTable dtb = d.getDS(strGetAd);
                return dtb;
        }

       
    }
}
