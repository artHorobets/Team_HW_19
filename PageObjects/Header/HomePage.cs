using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject1.PageObjects
{
   public class HomePage:Header
    {
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}
