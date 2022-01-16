using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnitTestProject1.PageObjects;
using OpenQA.Selenium;

//Bairatskaya Anastasia

namespace TestProject1.Page_Object.Footer
{
   public class BestSellers: Footer
    {
        public BestSellers(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
