using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

//Artem Horobets

namespace XUnitTestProject1.PageObjects
{
  public  class AboutUsInformationMenu : Header
    {
        public AboutUsInformationMenu(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}