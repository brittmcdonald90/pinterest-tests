using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PinterestAutomation
{
    public class DashboardPage
    {
        public static bool IsAt
        {
            get
            {
                string color = "rgb(51, 51, 51)";
                var homeButtonColor = Driver.Instance.FindElement(By.CssSelector(".tBJ.dyH.iFc.SMy.yTZ.pBj.DrD.mWe")).GetCssValue("color");

                return homeButtonColor == color;
            }
        }
        
    }
}
