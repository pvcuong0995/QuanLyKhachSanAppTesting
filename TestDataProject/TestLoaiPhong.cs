using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyKhachSan.DTO;
using QuanLyKhachSan.BLL;

namespace TestDataProject
{
    [TestClass]
    public class TestLoaiPhong
    {
        LoaiPhong_DTO loai1, loai2, loai3;
        LoaiPhong_BLL loaiBLL = new LoaiPhong_BLL();
        [TestInitialize]
        public void setUp()
        {
            loai1 = new LoaiPhong_DTO("Deluxe", 1, 300000);
            loai2 = new LoaiPhong_DTO("Pro", 5, 400000);
            loai3 = new LoaiPhong_DTO("Vip", 5, 500000);
        }
        [TestMethod]
        public void TestGetDsLoaiPhong()
        {
            var test = loaiBLL.getDSLoaiPhong();
            Assert.AreEqual(4, test.Rows.Count);
        }

        [TestMethod]
        public void TestGetTienDatCoc()
        {
            var test = loaiBLL.getTienDatCoc(loai1.Tenlp, loai1.Soluong);
            Assert.AreEqual(30000, test);
        }

        [TestMethod]
        public void TestGetGiaPhong()
        {
            var test = loaiBLL.getGiaPhong(loai1.Tenlp);
            Assert.AreEqual(300000, test);
        }

        [TestMethod]
        public void TestGiamSoLuongPhong()
        {
            var test = loaiBLL.giamSoLuongPhong(loai1.Tenlp);
            Assert.AreEqual(true, test);
        }

        [TestMethod]
        public void TestGiamSoLuongPhongIdNotFound()
        {
            var test = loaiBLL.giamSoLuongPhong(loai2.Tenlp);
            Assert.AreEqual(false, test);
        }
        [TestMethod]
        public void TestTangSoLuongPhong()
        {
            var test = loaiBLL.tangSoLuongPhong(loai1.Tenlp);
            Assert.AreEqual(true, test);
        }

        [TestMethod]
        public void TestTangSoLuongPhongIdNotFound()
        {
            var test = loaiBLL.tangSoLuongPhong(loai2.Tenlp);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestSoLuongPhong()
        {
            var test = loaiBLL.soLuongPhong(loai1.Tenlp);
            Assert.AreEqual("8", test);
        }
    }
}
