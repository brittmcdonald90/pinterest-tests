using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PinterestAutomation;

namespace PinterestTests
{
    [TestClass]
    public class CreatePostTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Can_Create_Basic_Post()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("brittmcdonald90@gmail.com").WithPassword("Testpassword1").Login();

            Assert.IsTrue(DashboardPage.IsAt, "Failed to login.");
        }

        //[TestCleanup]
        //public void Cleanup()
        //{
        //    Driver.Close();
        //}
    }
}
