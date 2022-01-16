using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject1.Page_Object.Footer
{
    public class GooglePlus:Footer
    {
        private IWebDriver _driver;
        public GooglePlus(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}
