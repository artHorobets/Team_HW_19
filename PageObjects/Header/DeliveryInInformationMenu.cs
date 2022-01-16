using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject1.PageObjects
{
    public class DeliveryInInformationMenu:Header
    {

        public DeliveryInInformationMenu(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}