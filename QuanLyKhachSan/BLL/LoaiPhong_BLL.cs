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
    public class LoaiPhong_BLL
    {
        DBAccess db = new DBAccess();

        public DataTable getDSLoaiPhong()
        {
            string sql = "Select tenloaiphong From loaiphong";
            return db.getDS(sql);
        }

        public int getTienDatCoc(string tenlp, int sl)
        {
            string sql = "Select giaphong from loaiphong where tenloaiphong = '" + tenlp + "'";
            DataTable dtb = db.getDS(sql);
            DataRow r = dtb.Rows[0];
            int gia = int.Parse(r[0].ToString());
            return (int)(gia*sl*10/100);
        }

        public int getGiaPhong(string tenlp)
        {
            string sql = "select giaphong from loaiphong where tenloaiphong = '" + tenlp + "'";
            DataTable dtb = db.getDS(sql);
            DataRow r = dtb.Rows[0];
            return (int)r[0];
        }

        public bool giamSoLuongPhong(string tenlp)
        {
            string sql = "Update loaiphong set soluong=soluong-1 where tenloaiphong = '" + tenlp + "'";
            return db.ExecuteQuery(sql);
        }

        public bool tangSoLuongPhong(string tenlp)
        {
            string sql = "Update loaiphong set soluong=soluong+1 where tenloaiphong = '" + tenlp + "'";
            return db.ExecuteQuery(sql);
        }

        public string soLuongPhong(string tenlp)
        {
            string sql = "Select soluong from loaiphong where tenloaiphong = '" + tenlp + "'";
            DataTable dtb = new DataTable();
            dtb=db.getDS(sql);
            DataRow r = dtb.Rows[0];
            return r[0].ToString();
        }
    }
}
