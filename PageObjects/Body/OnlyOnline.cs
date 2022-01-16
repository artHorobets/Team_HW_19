using OpenQA.Selenium;
using XUnitTestProject1.PageObjects.Body;



namespace TestProject1.Page_Object.Body
{
    public class OnlyOnline: Body1
    {
        public OnlyOnline(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
