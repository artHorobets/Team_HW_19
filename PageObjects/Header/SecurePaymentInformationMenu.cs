using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject1.PageObjects
{
    public class SecurePaymentInformationMenu : Header
    {
        public SecurePaymentInformationMenu(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
