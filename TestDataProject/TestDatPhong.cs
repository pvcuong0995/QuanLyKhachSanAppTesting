using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyKhachSan.DTO;
using QuanLyKhachSan.BLL;

namespace TestDataProject
{
    [TestClass]
    public class TestDatPhong
    {
        DatPhong_DTO dp1, dp2, dp3, dp4, dp5, dp6;
       
        DatPhong_BLL datPhongBLL = new DatPhong_BLL();
        [TestInitialize]
        public void setUp()
        {
            //        public DatPhong_DTO(string madp, string manv, string makh, string tenlp, DateTime ngaydat, DateTime ngayden, DateTime ngaydi, int tiencoc, int soluong, bool trangthai)
            DateTime ngaydat = Convert.ToDateTime("11/19/2018");
            DateTime ngayden = Convert.ToDateTime("11/19/2018");
            DateTime ngaydi = Convert.ToDateTime("11/23/2018");
            dp1 = new DatPhong_DTO("DP022", "NV002", "KH002", "Deluxe",ngaydat, ngayden, ngaydi, 20000, 1, true);
            dp2 = new DatPhong_DTO("DP022", "NV001", "KH001", "Suite", ngaydat, ngayden, ngaydi, 40000, 1, true);
            dp3 = new DatPhong_DTO(null, "NV002", "KH002", "Deluxe", ngaydat, ngayden, ngaydi, 20000, 1, true);
            dp4 = new DatPhong_DTO("DP022", "NV002", "KH002", "Deluxe", ngaydat, ngayden, ngaydi, 20000, 1, false);
            dp5 = new DatPhong_DTO("DP022", "NV002", "KH002", "Deluxe", ngaydat, ngayden, ngaydi, 20000, 1, true);
            dp6 = new DatPhong_DTO("DP022", "NV002", "KH002", "Deluxe", ngaydat, ngayden, ngaydi, 20000, 1, true);
            

        }
        [TestMethod]
        public void TestAddDatPhong()
        {
            var test = datPhongBLL.addDatPhong(dp1);
            Assert.AreEqual(true, test);
        }
        [TestMethod]
        public void TestAddDatPhongWithIdDuplicate()
        {
            var test = datPhongBLL.addDatPhong(dp2);
            Assert.AreEqual(false, test);
        }

      
        [TestMethod]
        public void TestAddDatPhongWithIdNull()
        {
            var test = datPhongBLL.addDatPhong(dp3);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestUpdateDatPhong()
        {
            var test = datPhongBLL.editDatPhong(dp4);
            Assert.AreEqual(true, test);
        }
        [TestMethod]
        public void TestDeleteDatPhongIdDP022()
        {
            var test = datPhongBLL.deleteDatPhong(dp1);
            Assert.AreEqual(true, test);
        }
       
        [TestMethod]
        public void TestDeleteDatPhongIdNull()
        {
            var test = datPhongBLL.deleteDatPhong(dp3);
            Assert.AreEqual(false, test);
        }

       
    }
}
