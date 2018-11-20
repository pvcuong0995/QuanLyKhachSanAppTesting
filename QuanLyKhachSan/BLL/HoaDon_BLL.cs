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
    public class HoaDon_BLL
    {
        DBAccess db = new DBAccess();

        public bool lapHoaDon(HoaDon_DTO hd)
        {
            string[] param = { "@mahd", "@madp", "@ngaylap", "@tongtien" };
            object[] values = { hd.Mahd, hd.Madp, hd.Ngaylap, hd.Tongtien };
            string query = "Insert Into hoadon Values(@mahd,@madp,convert(date,@ngaylap,105),@tongtien)";
            return db.ExecuteNonQueryPara(query, param, values);
        }
        public bool updateHoaDon(HoaDon_DTO hd)
        {
            string[] param = { "@mahd", "@madp", "@ngaylap", "@tongtien" };
            object[] values = { hd.Mahd, hd.Madp, hd.Ngaylap, hd.Tongtien };
            string query = "Update hoadon Set mahd=@mahd, madp=@madp, ngaylap=convert(date,@ngaylap,105), tongtien=@tongtien where mahd=@mahd";
            return db.ExecuteNonQueryPara(query, param, values);
        }
       
    }
}
