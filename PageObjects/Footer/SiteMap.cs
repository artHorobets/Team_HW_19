using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject1.Page_Object.Footer
{
   public class SiteMap: Footer
    {
        public SiteMap(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
