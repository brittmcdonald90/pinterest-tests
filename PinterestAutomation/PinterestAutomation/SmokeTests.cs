using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace PinterestAutomation
{
    public class SmokeTests
    {
        public void Go()
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.pinterest.com");
        }
    }
}
