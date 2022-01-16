using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject1.PageObjects
{
    public class BlousesInTops:Header
    {
        public BlousesInTops(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}