using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyKhachSan.DTO;
using QuanLyKhachSan.BLL;
namespace TestDataProject
{
    [TestClass]
    public class TestChiTietDatPhong
    {
        CTDP_DTO ctdp1, ctdp2;

        ChiTietDatPhong_BLL ctDatPhongBLL = new ChiTietDatPhong_BLL();
        [TestInitialize]
        public void setUp()
        {

            ctdp1 = new CTDP_DTO("DP022", "D105");
            ctdp2 = new CTDP_DTO("DP021", "D105");
          

        }
        [TestMethod]
        public void TestAddChiTietDatPhongIdNotFound()
        {
            var test = ctDatPhongBLL.addChiTietDatPhong(ctdp1);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestAddChiTietDatPhongHasId()
        {
            var test = ctDatPhongBLL.addChiTietDatPhong(ctdp2);
            Assert.AreEqual(true, test);
        }

        [TestMethod]
        public void TestGetDsIdDatPhong()
        {
            var test = ctDatPhongBLL.getDSMaDatPhong(ctdp2.Madp);
            Assert.AreEqual(2, test.Rows.Count);
        }

        [TestMethod]
        public void TestGetDsChiTietDatPhong()
        {
            var test = ctDatPhongBLL.getDSChiTietPhongDat();
            Assert.AreEqual(27, test.Rows.Count);
        }
    }
}
