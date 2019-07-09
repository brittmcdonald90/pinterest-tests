using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace PinterestAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; internal set; }
        public static void Initialize()
        {
            Instance = new FirefoxDriver();
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
    }
    
}