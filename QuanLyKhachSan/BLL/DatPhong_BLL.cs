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
    public class DatPhong_BLL
    {
        DBAccess db = new DBAccess();

        public DataTable dsDatPhong()
        {
            string sql = "Select * From datphong";
            return db.getDS(sql);
        }

        public DataTable dsDatPhongMadp(string madp)
        {
            string sql = "Select * From datphong where madp='" + madp + "'";
            return db.getDS(sql);
        }
        public bool addDatPhong(DatPhong_DTO dp)
        {
            string[] param = { "@madp", "@manv", "@makh", "@tenloaiphong", "@ngaydat", "@ngayden", "@ngaydi", "@tiendatcoc", "@soluong", "@trangthai" };
            object[] values = { dp.Madp, dp.Manv, dp.Makh, dp.Tenlp, dp.Ngaydat, dp.Ngayden, dp.Ngaydi, dp.Tiendatcoc, dp.Soluong, dp.Trangthai };
            string query = "Insert Into datphong Values(@madp,@manv,@makh,@tenloaiphong,convert(date,@ngaydat,105),convert(date,@ngayden,105),convert(date,@ngaydi,105),@tiendatcoc,@soluong,@trangthai)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool editDatPhong(DatPhong_DTO dp)
        {
            string[] param = { "@madp", "@manv", "@makh", "@tenloaiphong", "@ngaydat", "@ngayden", "@ngaydi", "@tiendatcoc", "@soluong", "@trangthai" };
            object[] values = { dp.Madp, dp.Manv, dp.Makh, dp.Tenlp, dp.Ngaydat, dp.Ngayden, dp.Ngaydi, dp.Tiendatcoc, dp.Soluong, dp.Trangthai };
            string query = "Update datphong set madp=@madp,manv=@manv,makh=@makh,tenloaiphong=@tenloaiphong,ngaydat=convert(date,@ngaydat,105),ngayden=convert(date,@ngayden,105),ngaydi=convert(date,@ngaydi,105),tiendatcoc=@tiendatcoc,soluong=@soluong,trangthai=@trangthai where madp=@madp";
            return db.ExecuteNonQueryPara(query, param, values);
        }
        public bool deleteDatPhong(DatPhong_DTO dp)
        {
            string[] param = { "@madp", "@manv", "@makh", "@tenloaiphong", "@ngaydat", "@ngayden", "@ngaydi", "@tiendatcoc", "@soluong", "@trangthai" };
            object[] values = { dp.Madp, dp.Manv, dp.Makh, dp.Tenlp, dp.Ngaydat, dp.Ngayden, dp.Ngaydi, dp.Tiendatcoc, dp.Soluong, dp.Trangthai };
            string query = "Delete datphong Where madp= @madp";
            return db.ExecuteNonQueryPara(query, param, values);
        }
        public bool updateTrangThai(string madp, bool ok)
        {
            string n = "0";
            if(ok)
                n = "1";
            string query = "Update datphong set trangthai='"+ n +"' where madp='"+ madp +"'";
            return db.ExecuteQuery(query);
        }
    }
}
