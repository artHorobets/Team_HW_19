﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject1.PageObjects
{
    public class Women : Header
    {

        public Women(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}