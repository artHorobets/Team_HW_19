using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject1.PageObjects
{
   public class CasualDresses:Header
    {
        public CasualDresses(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}