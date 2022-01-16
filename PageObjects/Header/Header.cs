using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TestProject1.Page_Object.Footer;

namespace XUnitTestProject1.PageObjects
{
    public class Header
    {
        protected IWebDriver _driver;
        private By _clicLogo = By.XPath("//div[@id='header_logo']/a/img");
        private By _clicSearch = By.CssSelector("#search_query_top");
        private By _clicShoppingCart = By.XPath("//header[@id='header']/div[3]/div/div/div[3]/div/a");
        private By _clicWomen = By.XPath("//a[contains(text(),'Women')]");
        private By _clicDresses = By.XPath("//div[@id='block_top_menu']/ul/li[2]/a");
        private By _clicTShirts = By.XPath("//div[@id='block_top_menu']/ul/li[3]/a");
        private By _clicSearchB = By.XPath("//button[@name='submit_search']");
        private By _clicContacUS = By.XPath("//a[contains(text(),'Contact us')]");
        private By _clicSignInS = By.XPath("//a[contains(text(),'Sign in')]");
        private By _clicHomePage = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/blockbanner/img/sale70.png')]");
        private By _FindField = By.XPath("//input[@id='search_query_top']");
        private By _clicCasualDresses = By.XPath("//div[@id='block_top_menu']/ul/li[2]/ul/li/a");
        private By _clicEveningDresses = By.XPath("//div[@id='block_top_menu']/ul/li[2]/ul/li[2]/a");
        private By _clicSummerDresses = By.XPath("//div[@id='block_top_menu']/ul/li[2]/ul/li[3]/a");
        private By _clicTops = By.XPath("//a[contains(text(),'Tops')]");
        private By _clickTshirtsInTops = By.XPath("//a[contains(text(),'T-shirts')]");
        private By _clickBlousesInTops = By.XPath("//a[contains(text(),'Blouses')]");
        private By _clickDressesInWomen = By.XPath("//a[contains(text(),'Dresses')]");
        private By _clickCasualDressesInWomenMenu = By.XPath("//a[contains(text(),'Casual Dresses')]");
        private By _clickEveningDressesInWomenMenu = By.XPath("//a[contains(text(),'Evening Dresses')]");
        private By _clickSummerDressesInWomenMenu = By.XPath("//a[contains(text(),'Summer Dresses')]");
        private By _clickReturnHome = By.XPath("//div[@id='columns']/div/a/i");
        private By _clickInformationInTShirts = By.XPath("//a[contains(text(),'Information')]");
        private By _clickLegalNoticeInformationMenu = By.XPath("xpath=//a[contains(text(),'Legal Notice')]");
        private By _clickDeliveryInInformationMenu = By.XPath("//a[contains(text(),'Delivery')]");
        private By _clickTermsAndConditionsOfUseInformationMenu = By.XPath("//a[contains(text(),'Terms and conditions of use')]");
        private By _clickAboutUsInformationMenu = By.XPath("//a[contains(text(),'About us')]");
        private By _clickSecurePaymentInformationMenu = By.XPath("//a[contains(text(),'About us')]");
        private By _clickOurStoresInformationMenu = By.XPath("//a[contains(text(),'About us')]");
        private By _clickSpecialInTSHirt = By.XPath("//a[contains(text(),'Specials')]");
        private By _clickAllSpecialInTSHirt = By.XPath("//a[contains(text(),'Specials')]");
        private By _clickOurStorieslInTSHirt = By.XPath("//a[contains(text(),'Specials')]");

        public Logo clickLogo()
        {
            _driver.FindElement(_clicLogo).Click();
            return new Logo(_driver);
        }
        public Search clickSearchButton()
        {
            _driver.FindElement(_clicSearch).Click();

            return new Search(_driver);
        }
        public Search clickSearchEnter()
        {
            _driver.FindElement(_FindField).SendKeys(Keys.Enter);
            return new Search(_driver);
        }
        public Header ClickOnTheField()
        {
            _driver.FindElement(_FindField).Click();
            return this;
        }
        public Header InputTheText()
        {
            _driver.FindElement(_FindField).SendKeys("Hello");
            return this;
        }
        public ShoppingCart clickShoppingCart()
        {
            _driver.FindElement(_clicShoppingCart).Click();
            return new ShoppingCart(_driver);
        }
        public Women clickWoman()
        {
            _driver.FindElement(_clicWomen).Click();
            return new Women(_driver);
        }
        public Dresses clickDresses()
        {
            _driver.FindElement(_clicDresses).Click();
            return new Dresses(_driver);
        }
        public TShirts clickTShirts()
        {
            _driver.FindElement(_clicTShirts).Click();
            return new TShirts(_driver);
        }
        public ContactUs clickContactUs()
        {
            _driver.FindElement(_clicContacUS).Click();
            return new ContactUs(_driver);
        }
        public SignIn clickSigIn()
        {
            _driver.FindElement(_clicSignInS).Click();
            return new SignIn(_driver);
        }
        public Header clickHomePage()
        {
            _driver.FindElement(_clicHomePage).Click();
            return this;
        }
        public Women hoverWomenDrop()
        {
            Actions action = new Actions(_driver);
            IWebElement elemnt = _driver.FindElement(_clicWomen);
            action.MoveToElement(elemnt).Perform();
            return new Women(_driver);
        }    
        public Dresses hoverDressesDrop()
        {
            Actions action = new Actions(_driver);
            IWebElement elemnt = _driver.FindElement(_clicDresses);
            action.MoveToElement(elemnt).Perform();
            return new Dresses(_driver);
        }
        public CasualDresses clickCasualDresses()
        {
            _driver.FindElement(_clicCasualDresses).Click();
            return new CasualDresses(_driver);
        }
        public EveningDresses clickEveningDresses()
        {
            _driver.FindElement(_clicEveningDresses).Click();
            return new EveningDresses(_driver);
        }
        public SummerDresses clickSummerDresses()
        {
            _driver.FindElement(_clicSummerDresses).Click();
            return new SummerDresses(_driver);
        }

        public Tops clickTops()
        {
            _driver.FindElement(_clicTops).Click();
            return new Tops(_driver);
        }

        public TShirts clickTshirtsInTops()
        {
            _driver.FindElement(_clickTshirtsInTops).Click();
            return new TShirts(_driver);
        }
        public BlousesInTops clickBlousesInTops()
        {
            _driver.FindElement(_clickBlousesInTops).Click();
            return new BlousesInTops(_driver);
        }

        public Dresses clickDressesInWomen()
        {
            _driver.FindElement(_clickDressesInWomen).Click();
            return new Dresses(_driver);
        }
        public CasualDresses clickCasualDressesInWomenMenu()
        {
            _driver.FindElement(_clickCasualDressesInWomenMenu).Click();
            return new CasualDresses(_driver);
        }
        public EveningDresses clickEveningDressesInWomenMenu()
        {
            _driver.FindElement(_clickEveningDressesInWomenMenu).Click();
            return new EveningDresses(_driver);
        }
        public SummerDresses clickSummerDressesInWomenMenu()
        {
            _driver.FindElement(_clickSummerDressesInWomenMenu).Click();
            return new SummerDresses(_driver);
        }

        public ReturnHomePage clickReturnHome()
        {
            _driver.FindElement(_clickReturnHome).Click();
            return new ReturnHomePage(_driver);
        }

        public InformationInTShirts clickInformationInTShirts()
        {
            _driver.FindElement(_clickInformationInTShirts).Click();
            return new InformationInTShirts(_driver);
        }
        public DeliveryInInformationMenu clickDeliveryInInformationMenu()
        {
            _driver.FindElement(_clickDeliveryInInformationMenu).Click();
            return new DeliveryInInformationMenu(_driver);
        }
        public LegalNoticeInformationMenu clickLegalNoticeInformationMenu()
        {
            _driver.FindElement(_clickLegalNoticeInformationMenu).Click();
            return new LegalNoticeInformationMenu(_driver);
        }
        public TermsAndConditionsOfUseInformationMenu clickTermsAndConditionsOfUseInformationMenu()
        {
            _driver.FindElement(_clickTermsAndConditionsOfUseInformationMenu).Click();
            return new TermsAndConditionsOfUseInformationMenu(_driver);
        }

        public AboutUsInformationMenu clickAboutUsInformationMenu()
        {
            _driver.FindElement(_clickAboutUsInformationMenu).Click();
            return new AboutUsInformationMenu(_driver);
        }

        public SecurePaymentInformationMenu clickSecurePaymentInformationMenu()
        {
            _driver.FindElement(_clickSecurePaymentInformationMenu).Click();
            return new SecurePaymentInformationMenu(_driver);
        }
        public OurStoresInformationMenu clickOurStoresInformationMenu()
        {
            _driver.FindElement(_clickOurStoresInformationMenu).Click();
            return new OurStoresInformationMenu(_driver);
        }

        public SpecialInTSHirt clickSpecialInTSHirt()
        {
            _driver.FindElement(_clickSpecialInTSHirt).Click();
            return new SpecialInTSHirt(_driver);
        }
        public AllSpecialInTSHirt clickAllSpecialInTSHirt()
        {
            _driver.FindElement(_clickAllSpecialInTSHirt).Click();
            return new AllSpecialInTSHirt(_driver);
        }
        public OurStorieslInTSHirt clickOurStorieslInTSHirt()
        {
            _driver.FindElement(_clickOurStorieslInTSHirt).Click();
            return new OurStorieslInTSHirt(_driver);
        }


    }
}
