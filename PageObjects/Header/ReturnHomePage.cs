using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject1.PageObjects
{
   public class ReturnHomePage:Header
    {

        public ReturnHomePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}