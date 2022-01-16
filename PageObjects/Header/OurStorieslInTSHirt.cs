using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject1.PageObjects
{
   public class OurStorieslInTSHirt: Header
    {
        public OurStorieslInTSHirt(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}