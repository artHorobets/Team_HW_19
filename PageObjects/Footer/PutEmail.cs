﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject1.Page_Object.Footer
{
   public class PutEmail:Footer
    {
        public PutEmail(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
