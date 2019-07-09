using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PinterestAutomation;

namespace PinterestTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SmokeTests c = new SmokeTests();
            c.Go();
        }
    }
}
