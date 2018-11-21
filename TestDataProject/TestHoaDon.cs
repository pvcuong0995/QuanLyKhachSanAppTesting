using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyKhachSan.DTO;
using QuanLyKhachSan.BLL;

namespace TestDataProject
{
    /// <summary>
    /// Summary description for TestHoaDon
    /// </summary>
    [TestClass]
    public class TestHoaDon
    {
        HoaDon_DTO hd1, hd2, hd3, hd4;
        HoaDon_BLL hoaDonBLL = new HoaDon_BLL();
        [TestInitialize]
        public void setUp()
        {
            DateTime ngaylap = Convert.ToDateTime("11/19/2018");
           //public HoaDon_DTO(string mahd, string mdp, DateTime ngaylap, int tongtien)
            hd1 = new HoaDon_DTO("HD021", "DP021",ngaylap, 300000);
            hd2 = new HoaDon_DTO("HD021", "DP021", ngaylap, 300000);
            hd3 = new HoaDon_DTO("HD021", "DP020", ngaylap, 900000);
            hd4 = new HoaDon_DTO("HD022", "DP020", ngaylap, 900000);
            
        }
        [TestMethod]
        public void TestLapHoaDon()
        {
            var test = hoaDonBLL.lapHoaDon(hd1);
            Assert.AreEqual(false, test);
        }
        [TestMethod]
        public void TestLapHoaDonWithIdDuplicate()
        {
            var test = hoaDonBLL.lapHoaDon(hd2);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestUpdateHoaDon()
        {
            var test = hoaDonBLL.updateHoaDon(hd3);
            Assert.AreEqual(true, test);
        }
        [TestMethod]
        public void TestUpdateHoaDonWithIdNotFound()
        {
            var test = hoaDonBLL.updateHoaDon(hd4);
            Assert.AreEqual(false, test);
        }
    }
}
