using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject1.PageObjects
{
  public class Tops:Header
    {
        public Tops(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}