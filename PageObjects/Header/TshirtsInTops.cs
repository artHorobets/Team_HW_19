using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject1.PageObjects
{
    public class TshirtsInTops:Header
    {
        public TshirtsInTops(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}