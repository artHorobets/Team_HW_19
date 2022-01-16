using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

//Artem Horobets

namespace XUnitTestProject1.PageObjects
{
    public class SignIn : Header
    {

        public SignIn(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}