using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

//Bairatskaya Anastasia

namespace TestProject1.Page_Object.Footer
{
   public class MyOrders:Footer
    {

        public MyOrders(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
