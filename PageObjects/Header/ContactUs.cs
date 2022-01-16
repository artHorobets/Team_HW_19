using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject1.PageObjects
{
    public class ContactUs:Header
    {

        public ContactUs(IWebDriver driver)
        {
            _driver = driver;
        }
    }   
}
