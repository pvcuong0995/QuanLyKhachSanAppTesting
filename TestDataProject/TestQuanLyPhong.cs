using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyKhachSan.DTO;
using QuanLyKhachSan.BLL;
namespace TestDataProject
{
    [TestClass]
    public class TestQuanLyPhong
    {
        Phong_DTO phong1, phong2, phong3, phong4;
        Phong_BLL phongBLL = new Phong_BLL();
        [TestInitialize]
        public void setUp()
        {
            phong1 = new Phong_DTO("V005", "Superio", false);
            phong2 = new Phong_DTO("V006", "Superio", false);
            phong3 = new Phong_DTO("V004", "Superio", false);
            
        }
        [TestMethod]
        public void TestGetGsPhong()
        {
            var test = phongBLL.dsph();
            Assert.AreEqual(30, test.Rows.Count);
        }

        [TestMethod]
        public void TestGetGsLoaiPhong()
        {
            var test = phongBLL.dsph(phong1.Tenlp);
            Assert.AreEqual(5, test.Rows.Count);
        }

        [TestMethod]
        public void TestUpdateTinhTrangPhongKhiDaDatPhong()
        {
            var test = phongBLL.capnhatphong(phong1.Maphong);
            Assert.AreEqual(true, test);
        }

       

        [TestMethod]
        public void TestUpdateTinhTrangPhongIDNotFound()
        {
            var test = phongBLL.capnhatphong(phong2.Maphong);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestUpdateTinhTrangPhongKhiTraPhong()
        {
            var test = phongBLL.traphong(phong1.Maphong);
            Assert.AreEqual(true, test);
        }
        [TestMethod]
        public void TestUpdateTinhTrangTraPhongIDNotFound()
        {
            var test = phongBLL.traphong(phong2.Maphong);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestCheckTinhTrangPhongHienTai()
        {
            var test = phongBLL.checkTinhTrang(phong1.Maphong);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestCheckTinhTrangPhongHienTaiPhongIDNotFound()
        {
            var test = phongBLL.traphong(phong2.Maphong);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestGetThongTinPhong()
        {
            var test = phongBLL.thongtinphong(phong1.Maphong);
            Assert.AreEqual(0, test.Rows.Count);
        }

        [TestMethod]
        public void TestGetThongTinPhongV004()
        {
            var test = phongBLL.thongtinphong(phong3.Maphong);
            Assert.AreEqual(0, test.Rows.Count);
        }
    }
}
