﻿//using System;
//using System.Collections.Generic;
//using System.Text;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;

//namespace XUnitTestProject1
//{
//    public class BaseTest: IDisposable
//    {
//        private IWebDriver _driver;

//        public IWebDriver StartDriverOnPage(string url)
//        {
//            _driver = new ChromeDriver();
//            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
//            _driver.Navigate().GoToUrl(url);
//            return _driver;
//        }

//        public void Dispose()
//        {
//            _driver.Quit();
//        }
//    }
//}
