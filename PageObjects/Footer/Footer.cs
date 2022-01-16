using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TestProject1.Page_Object;
using XUnitTestProject1.PageObjects;


namespace TestProject1.Page_Object.Footer
{
   public class Footer : Header
    {
        private By _myAccount = By.XPath("//a[contains(text(),'My account')]");
        private By _putEmail = By.Id("newsletter-input");

        private By _facebook = By.XPath("//a[contains(@href, 'https://www.facebook.com/groups/525066904174158/')]");
        private By _twitter = By.XPath("//a[contains(@href, 'https://twitter.com/seleniumfrmwrk')]");
        private By _youtube = By.XPath("//a[contains(@href, 'https://www.youtube.com/channel/UCHl59sI3SRjQ-qPcTrgt0tA')]");
        private By _googlePlus = By.XPath("//a[contains(@href, 'https://plus.google.com/111979135243110831526/posts')]");

        private By _myCreditSleeps = By.XPath("//a[contains(text(),'My credit slips')]");
        private By _myOrders = By.XPath("//a[contains(text(),'My orders')]");
        private By _myAdress = By.XPath("//a[contains(text(),'My addresses')]");
        private By _myPersonalInfo = By.XPath("//a[contains(text(),'My personal info')]");

        private By _supportEmail = By.XPath("//a[contains(text(),'support@seleniumframework.com')]");

        private By _specials = By.XPath("(//a[contains(text(),'Specials')])[2]");
        private By _newProducts = By.XPath("//a[contains(text(),'New products')]");
        private By _bestSellers = By.XPath("//a[contains(text(),'Best sellers')]");
        private By _ourStores = By.XPath("(//a[contains(text(),'Our stores')])[3]");
        private By _contactUs = By.XPath("(//a[contains(text(),'Contact us')])[2]");
        private By _TermsAndConditions = By.XPath("//a[contains(text(),'Terms and conditions of use')]");
        private By _AboutUs = By.XPath("//a[contains(text(),'About us')]");
        private By _SiteMap = By.XPath("//a[contains(text(),'Sitemap')]");

        private By _woman = By.XPath("(//a[contains(text(),'Women')])[2]");


        public MyAccount MyAccountClick()
        {
            _driver.FindElement(_myAccount).Click();
            return new MyAccount(_driver);
        }
        public Footer PutEmailAdress()
        {
            _driver.FindElement(_putEmail).SendKeys("aboba1212@gmail.com");
            return this;
        }
        public Facebook FacebookClick()
        {
            _driver.FindElement(_facebook).Click();
            return new Facebook(_driver);
        }
        public Twitter TwitterClick()
        {
            _driver.FindElement(_twitter).Click();
            return new Twitter(_driver);
        }
        public Youtube YouTubeClick()
        {
            _driver.FindElement(_youtube).Click();
            return new Youtube(_driver);
        }
        public GooglePlus GooglePlusClick()
        {
            _driver.FindElement(_googlePlus).Click();
            return new GooglePlus(_driver);
        }
        public MyOrders MyOrdersClick()
        {
            _driver.FindElement(_myCreditSleeps).Click();
            return new MyOrders(_driver);
        }
        public MyCreditSleep MyCreditSleepClick()
        {
            _driver.FindElement(_myOrders).Click();
            return new MyCreditSleep(_driver);
        }
        public MyAdress MyAdressClick()
        {
            _driver.FindElement(_myAdress).Click();
            return new MyAdress(_driver);
        }
        public MyPersonalInfo MyPersonalInfoClick()
        {
            _driver.FindElement(_myPersonalInfo).Click();
            return new MyPersonalInfo(_driver);
        }
        public SupportEmail SupportEmailClick()
        {
            _driver.FindElement(_supportEmail).Click();
            return new SupportEmail(_driver);
        }
        public Specialis SpecialisClick()
        {
            _driver.FindElement(_specials).Click();
            return new Specialis(_driver);
        }
        public NewProducts NewProductsClick()
        {
            _driver.FindElement(_newProducts).Click();
            return new NewProducts(_driver);
        }
        public BestSellers BestSellersClick()
        {
            _driver.FindElement(_bestSellers).Click();
            return new BestSellers(_driver);
        }
        public OurStores OurStoresClick()
        {
            _driver.FindElement(_ourStores).Click();
            return new OurStores(_driver);
        }
        public ContactUs ContactUsClick()
        {
            _driver.FindElement(_contactUs).Click();
            return new ContactUs(_driver);
        }
        public TermsAndCondition TermsAndConditionClick()
        {
            _driver.FindElement(_TermsAndConditions).Click();
            return new TermsAndCondition(_driver);
        }
        public GooglePlus AboutUsClick()
        {
            _driver.FindElement(_AboutUs).Click();
            return new GooglePlus(_driver);
        }
        public SiteMap Sitemap()
        {
            _driver.FindElement(_SiteMap).Click();
            return new SiteMap(_driver);
        }
        public Women Woman()
        {
            _driver.FindElement(_woman).Click();
            return new Women(_driver);
        }
    



    }
}
