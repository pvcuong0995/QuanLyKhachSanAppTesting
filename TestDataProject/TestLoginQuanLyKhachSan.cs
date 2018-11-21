using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyKhachSan;
using QuanLyKhachSan.BLL;
using QuanLyKhachSan.DTO;

namespace TestDataProject
{
    [TestClass]
    public class TestLoginQuanLyKhachSan
    {

        User_DTO user11, user12, user21, user22, user31, user32;
        User_BLL userBll = new User_BLL();
        [TestInitialize]
        public void setUp()
        {
            user11 = new User_DTO("NV001", "123");
            user12 = new User_DTO("NV001", "1234");
            user21 = new User_DTO("NV002", "123");
            user22 = new User_DTO("NV002", "1234");
            user31 = new User_DTO("KH001", "5678");
            user32 = new User_DTO("", "");
            
        }
      
        [TestMethod]
        public void TestLoginWithUserOnePassTrue()
        {

            var test = userBll.checkLogin(user11.Manv, user11.Mk);
            Assert.AreEqual(1, test.Rows.Count);
        }
        [TestMethod]
        public void TestLoginWithUserOnePassFalse()
        {
            var test = userBll.checkLogin(user12.Manv, user12.Mk);
            Assert.AreEqual(0, test.Rows.Count);
        }
        [TestMethod]
        public void TestLoginWithUserTwoPassTrue()
        {
            var test = userBll.checkLogin(user21.Manv, user21.Mk);
            Assert.AreEqual(1, test.Rows.Count);
        }
        [TestMethod]
        public void TestLoginWithUserTwoPassFalse()
        {
            var test = userBll.checkLogin(user22.Manv, user22.Mk);
            Assert.AreEqual(0, test.Rows.Count);
        }

        [TestMethod]
        public void TestLoginWithUserFalsePassFalse()
        {
            var test = userBll.checkLogin(user31.Manv, user31.Mk);
            Assert.AreEqual(0, test.Rows.Count);
        }

        [TestMethod]
        public void TestLoginWithUserEmptyPassEmpty()
        {
            var test = userBll.checkLogin(user32.Manv, user32.Mk);
            Assert.AreEqual(0, test.Rows.Count);
        }
    }
}
