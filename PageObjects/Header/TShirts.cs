﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject1.PageObjects
{
    public class TShirts : Header
    {

        public TShirts(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}