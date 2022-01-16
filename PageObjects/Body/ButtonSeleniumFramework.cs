using OpenQA.Selenium;
using XUnitTestProject1.PageObjects.Body;

//Levchenko Elena

namespace TestProject1.Page_Object.Body
{
    public class ButtonSeleniumFramework: Body1
    {
        public ButtonSeleniumFramework(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
