using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject1.PageObjects
{
   public class SummerDresses: Header
    {
        public SummerDresses(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}