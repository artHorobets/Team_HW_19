﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject1.PageObjects
{
   public class Logo : Header
    {

        public Logo(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
