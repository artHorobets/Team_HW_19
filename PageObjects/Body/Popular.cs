using OpenQA.Selenium;
using XUnitTestProject1.PageObjects.Body;




namespace TestProject1.Page_Object.Body
{
    public class Popular: Body1
    {
        public Popular(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
