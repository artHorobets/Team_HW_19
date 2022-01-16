using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using XUnitTestProject1.PageObjects;

namespace TestProject1.Page_Object.Footer
{
   public class AboutUs:Footer
    {
        public AboutUs(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
