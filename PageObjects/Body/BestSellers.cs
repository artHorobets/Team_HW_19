using OpenQA.Selenium;
using XUnitTestProject1.PageObjects.Body;

//Levchenko Elena


namespace TestProject1.Page_Object.Body
{
    public class BestSellers: Body1
    {
        public BestSellers(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
