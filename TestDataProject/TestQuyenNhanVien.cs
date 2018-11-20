using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyKhachSan.DTO;
using QuanLyKhachSan.BLL;

namespace TestDataProject
{
    [TestClass]
    public class TestQuyenNhanVien
    {
        User_DTO user1, user2, user3;
        User_BLL userBLL = new User_BLL();
        [TestInitialize]
        public void setUp()
        {
            user1 = new User_DTO("NV012", "A", "123");
            user2 = new User_DTO("NV013", "A", "123");
            user3 = new User_DTO("NV012", "B", "456");
        }
        [TestMethod]
        public void TestAddQuyenNhanVien()
        {
            var test = userBLL.addQuyen(user1);
            Assert.AreEqual(true, test);
        }

        [TestMethod]
        public void TestAddQuyenNhanVienIdNew()
        {
            var test = userBLL.addQuyen(user2);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestUpdateQuyenNhanVien()
        {
            var test = userBLL.editQuyen(user3);
            Assert.AreEqual(true, test);
        }

        [TestMethod]
        public void TestUpdateQuyenNhanVienIdNotFound()
        {
            var test = userBLL.editQuyen(user2);
            Assert.AreEqual(false, test);
        }
        [TestMethod]
        public void TestDeleteQuyenNhanVien()
        {
            var test = userBLL.deleteQuyen(user1);
            Assert.AreEqual(true, test);
        }
    }
}
