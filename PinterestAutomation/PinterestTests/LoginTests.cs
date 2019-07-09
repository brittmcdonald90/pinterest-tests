using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PinterestAutomation;

namespace PinterestTests
{
    [TestClass]
    public class LoginTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }
         
        [TestMethod]
        public void User_Login()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("brittmcdonald90@gmail.com").WithPassword("Testpassword1").Login();

            //Assert.IsTrue(DashboardPage.IsAt, "Failed to login.");
        }
    }
}
