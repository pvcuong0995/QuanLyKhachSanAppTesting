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
        public bool addQuyen(User_DTO user)
        {
            try
            {


                string[] param = { "@manv", "@id", "@matkhau" };
                object[] values = { user.Manv, user.Id, user.Mk };
                string query = "Insert Into quyennv Values(@manv,@id,@matkhau)";
                return db.ExecuteNonQueryPara(query, param, values);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool editQuyen(User_DTO user)
        {
            string[] param = { "@manv", "@id", "@matkhau" };
            object[] values = { user.Manv, user.Id, user.Mk };
            string query = "Update quyennv Set manv=@manv, id=@id, matkhau=@matkhau where manv=@manv";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool deleteQuyen(User_DTO user)
        {
            string[] param = { "@manv", "@id", "@matkhau" };
            object[] values = { user.Manv, user.Id, user.Mk };
            string query = "Delete quyennv Where manv= @manv";
            return db.ExecuteNonQueryPara(query, param, values);
        }

       
    }
}
