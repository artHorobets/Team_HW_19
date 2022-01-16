using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TestProject1.Page_Object.Body;


namespace XUnitTestProject1.PageObjects.Body
{
    public class Body1: Header
    {
        private By _bannerMens = By.XPath("//div[@id='htmlcontent_home']/ul/li[2]/a/img");
        private By _bannerSavvyTrends = By.XPath("//div[@id='htmlcontent_home']/ul/li[5]/a/img");
        private By _bannerSunglasses = By.XPath("//div[@id='htmlcontent_home']/ul/li[4]/a/img");
        private By _bannerTopTrends = By.XPath("//img[@alt='PrestaShop'])[3]");
        private By _bannerWomens = By.XPath("//div[2]/div/ul/li[3]/a/img");
        private By _bestSellers = By.XPath("//a[contains(text(),'Best Sellers')]");
        private By _buttonSeleniumFramework = By.XPath("//a[contains(.,'Selenium Framework')]");
        private By _onlyOnline = By.XPath("//div[@id='htmlcontent_top']/ul/li[2]/a/img");
        private By _popular = By.XPath("//a[contains(text(),'Popular')]");
        private By _saleDays = By.XPath("div[@id='htmlcontent_top']/ul/li/a/img");
        private By _shopNow = By.XPath("//ul[@id='homeslider']/li[2]/div/p[2]/button");


        private By _buttonQuickView1 = By.XPath("//ul[@id='homefeatured']/li/div/div/div/a/img");
        private By _buttonQuickView2 = By.XPath("//ul[@id='homefeatured']/li[2]/div/div/div/a/img");
        private By _buttonQuickView3 = By.XPath("//li[3]/div/div/div/a/img");
        private By _buttonQuickView4 = By.XPath("//li[4]/div/div/div/a/img");
        private By _buttonQuickView5 = By.XPath("//li[5]/div/div/div/a/img");
        private By _buttonQuickView6 = By.XPath("//li[6]/div/div/div/a/img");
        private By _buttonQuickView7 = By.XPath("//li[7]/div/div/div/a/img");


        private By _buttonQuickViewAddCart1 = By.XPath("//span[contains(.,'Add to cart')]");
        private By _buttonQuickViewAddCart2 = By.XPath("//ul[@id='homefeatured']/li[2]/div/div[2]/div[2]/a/span");
        private By _buttonQuickViewAddCart3 = By.XPath("//div[@id='layer_cart']/div/div/span");
        private By _buttonQuickViewAddCart4 = By.XPath("////ul[@id='homefeatured']/li[4]/div/div[2]/div[2]/a/span");
        private By _buttonQuickViewAddCart5 = By.XPath("//ul[@id='homefeatured']/li[5]/div/div[2]/div[2]/a/span");
        private By _buttonQuickViewAddCart6 = By.XPath("//ul[@id='homefeatured']/li[6]/div/div[2]/div[2]/a/span");
        private By _buttonQuickViewAddCart7 = By.XPath("//ul[@id='homefeatured']/li[7]/div/div[2]/div[2]/a/span");


        private By _buttonQuickViewMore1 = By.XPath("//span[contains(.,'More')]");
        private By _buttonQuickViewMore2 = By.XPath("//li[2]/div/div[2]/div[2]/a[2]/span");
        private By _buttonQuickViewMore3 = By.XPath("//li[3]/div/div[2]/div[2]/a[2]/span");
        private By _buttonQuickViewMore4 = By.XPath("//li[4]/div/div[2]/div[2]/a[2]/span");
        private By _buttonQuickViewMore5 = By.XPath("//li[5]/div/div[2]/div[2]/a[2]/span");
        private By _buttonQuickViewMore6 = By.XPath("//li[6]/div/div[2]/div[2]/a[2]/span");
        private By _buttonQuickViewMore7 = By.XPath("//li[7]/div/div[2]/div[2]/a[2]/span");

        public BannerMens bannerMensClick()
        {
            _driver.FindElement(_bannerMens).Click();
            return new BannerMens(_driver);
        }

        public BannerSavvyTrends bannerSavvyTrendsClick()
        {
            _driver.FindElement(_bannerSavvyTrends).Click();
            return new BannerSavvyTrends(_driver);
        }

        public BannerSunglasses bannerSunglassesClic()
        {
            _driver.FindElement(_bannerSunglasses).Click();
            return new BannerSunglasses(_driver);
        }

        public BannerTopTrends bannerTopTrendsClick()
        {
            _driver.FindElement(_bannerTopTrends).Click();
            return new BannerTopTrends(_driver);
        }

        public BannerWomens bannerWomensClick()
        {
            _driver.FindElement(_bannerWomens).Click();
            return new BannerWomens(_driver);
        }

        public BestSellers bestSellersClick()
        {
            _driver.FindElement(_bestSellers).Click();
            return new BestSellers(_driver);
        }

        public ButtonSeleniumFramework buttonSeleniumFramework()
        {
            _driver.FindElement(_buttonSeleniumFramework).Click();
            return new ButtonSeleniumFramework(_driver);
        }

        public OnlyOnline onlyOnline()
        {
            _driver.FindElement(_onlyOnline).Click();
            return new OnlyOnline(_driver);
        }

        public Body1 popular()
        {
            _driver.FindElement(_popular).Click();
            return this;
        }

        public SaleDays saleDays()
        {
            _driver.FindElement(_saleDays).Click();
            return new SaleDays(_driver);
        }

        public ShopNow shopNow()
        {
            _driver.FindElement(_shopNow).Click();
            return new ShopNow(_driver);
        }

        public ButtonQuickView1 buttonQuickView1()
        {
            _driver.FindElement(_buttonQuickView1).Click();
            return new ButtonQuickView1(_driver);
        }

        public ButtonQuickView2 buttonQuickView2()
        {
            _driver.FindElement(_buttonQuickView2).Click();
            return new ButtonQuickView2(_driver);
        }

        public ButtonQuickView3 buttonQuickView3()
        {
            _driver.FindElement(_buttonQuickView3).Click();
            return new ButtonQuickView3(_driver);
        }

        public ButtonQuickView4 buttonQuickView4()
        {
            _driver.FindElement(_buttonQuickView4).Click();
            return new ButtonQuickView4(_driver);
        }

        public ButtonQuickView5 buttonQuickView5()
        {
            _driver.FindElement(_buttonQuickView5).Click();
            return new ButtonQuickView5(_driver);
        }

        public ButtonQuickView6 buttonQuickView6()
        {
            _driver.FindElement(_buttonQuickView6).Click();
            return new ButtonQuickView6(_driver);
        }

        public ButtonQuickView7 buttonQuickView7()
        {
            _driver.FindElement(_buttonQuickView7).Click();
            return new ButtonQuickView7(_driver);
        }

        public ButtonQuickViewAddCart1 buttonQuickViewAddCart1()
        {
            _driver.FindElement(_buttonQuickViewAddCart1).Click();
            return new ButtonQuickViewAddCart1(_driver);
        }

        public ButtonQuickViewAddCart2 buttonQuickViewAddCart2()
        {
            _driver.FindElement(_buttonQuickViewAddCart2).Click();
            return new ButtonQuickViewAddCart2(_driver);
        }

        public ButtonQuickViewAddCart3 buttonQuickViewAddCart3()
        {
            _driver.FindElement(_buttonQuickViewAddCart3).Click();
            return new ButtonQuickViewAddCart3(_driver);
        }

        public ButtonQuickViewAddCart4 buttonQuickViewAddCart4()
        {
            _driver.FindElement(_buttonQuickViewAddCart4).Click();
            return new ButtonQuickViewAddCart4(_driver);
        }

        public ButtonQuickViewAddCart5 buttonQuickViewAddCart5()
        {
            _driver.FindElement(_buttonQuickViewAddCart5).Click();
            return new ButtonQuickViewAddCart5(_driver);
        }

        public ButtonQuickViewAddCart6 buttonQuickViewAddCart6()
        {
            _driver.FindElement(_buttonQuickViewAddCart6).Click();
            return new ButtonQuickViewAddCart6(_driver);
        }

        public ButtonQuickViewAddCart7 buttonQuickViewAddCart7()
        {
            _driver.FindElement(_buttonQuickViewAddCart7).Click();
            return new ButtonQuickViewAddCart7(_driver);
        }

        public ButtonQuickViewMore1 buttonQuickViewMore1()
        {
            _driver.FindElement(_buttonQuickViewMore1).Click();
            return new ButtonQuickViewMore1(_driver);
        }

        public ButtonQuickViewMore2 buttonQuickViewMore2()
        {
            _driver.FindElement(_buttonQuickViewMore2).Click();
            return new ButtonQuickViewMore2(_driver);
        }

        public ButtonQuickViewMore3 buttonQuickViewMore3()
        {
            _driver.FindElement(_buttonQuickViewMore3).Click();
            return new ButtonQuickViewMore3(_driver);
        }

        public ButtonQuickViewMore4 buttonQuickViewMore4()
        {
            _driver.FindElement(_buttonQuickViewMore4).Click();
            return new ButtonQuickViewMore4(_driver);
        }

        public ButtonQuickViewMore5 buttonQuickViewMore5()
        {
            _driver.FindElement(_buttonQuickViewMore5).Click();
            return new ButtonQuickViewMore5(_driver);
        }

        public ButtonQuickViewMore6 buttonQuickViewMore6()
        {
            _driver.FindElement(_buttonQuickViewMore6).Click();
            return new ButtonQuickViewMore6(_driver);
        }

        public ButtonQuickViewMore7 buttonQuickViewMore7()
        {
            _driver.FindElement(_buttonQuickViewMore7).Click();
            return new ButtonQuickViewMore7(_driver);
        }
    }
}
