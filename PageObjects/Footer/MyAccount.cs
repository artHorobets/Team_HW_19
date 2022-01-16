using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using XUnitTestProject1.PageObjects;


namespace TestProject1.Page_Object.Footer
{
    public class MyAccount:Footer
    {
        private By _putEmailAdress = By.XPath("//input[@id='email_create']");
        private By _genderMrs = By.Id("id_gender2");
        private By _genderMr = By.Id("id_gender1");
        private By _customerFirstName = By.Id("customer_firstname");
        private By _customerLastName = By.XPath("//input[@id='customer_lastname']");
        private By _password = By.XPath("//input[@id='passwd']");
        private By _dateOfBirdD = By.Id("days");
        private By _dateOfBirdM = By.Id("months");
        private By _dateOfBirdY = By.Id("years");
        private By _checkBox1 = By.Id("newsletter");
        private By _checkBox2 = By.Id("optin");
        private By _customerFirstName2 = By.XPath("//input[@id='firstname']");
        private By _customerLastName2 = By.XPath("//input[@id='lastname']");
        private By _company = By.Id("company");
        private By _adress = By.Id("address1");
        private By _adress2 = By.Id("address2");
        private By _city = By.Id("city");
        private By _state = By.Id("id_state");
        private By _postcode = By.Id("postcode");
        private By _addInformation = By.Id("other");
        private By _phone = By.Id("phone");
        private By _phoneMob = By.Id("phone_mobile");
        private By _registr = By.XPath("button[@id='submitAccount']/span");


        public MyAccount(IWebDriver driver)
        {
            _driver = driver;

        }
        public MyAccount EnterEmailAdress()
        {
            _driver.FindElement(_putEmailAdress).SendKeys("aboba1212@gmail.com");
            return this;
        }
        public MyAccount GenderMsr()
        {
            _driver.FindElement(_genderMrs).Click();
            return this;
        }
        public MyAccount GenderMr()
        {
            _driver.FindElement(_genderMr).Click();
            return this;
        }
        public MyAccount CustomerFirstName()
        {
            _driver.FindElement(_customerFirstName).SendKeys("Aboba");
            return this;
        }
        public MyAccount CustomerLastName()
        {
            _driver.FindElement(_customerLastName).SendKeys("Abobovich");
            return this;
        }
        public MyAccount Password()
        {
            _driver.FindElement(_password).SendKeys("aboba1212");
            return this;
        }
        public MyAccount DateOfBirdD()
        {
            _driver.FindElement(_dateOfBirdD).SendKeys("14");
            return this;
        }
        public MyAccount DateOfBirdM()
        {
            _driver.FindElement(_dateOfBirdM).SendKeys("Jenuary");
            return this;
        }
        public MyAccount DateOfBirdY()
        {
            _driver.FindElement(_dateOfBirdY).SendKeys("1999");
            return this;
        }
        public MyAccount CheckBox1()
        {
            _driver.FindElement(_checkBox1).Click();
            return this;
        }
        public MyAccount CheckBox2()
        {
            _driver.FindElement(_checkBox2).Click();
            return this;
        }
        public MyAccount CustomerFirstName2()
        {
            _driver.FindElement(_customerFirstName2).SendKeys("Adolf");
            return this;
        }
        public MyAccount CustomerLastName2()
        {
            _driver.FindElement(_customerLastName2).SendKeys("Afganistanski");
            return this;
        }
        public MyAccount Company()
        {
            _driver.FindElement(_company).SendKeys("MirovoePravitelstvo");
            return this;
        }
        public MyAccount Adress()
        {
            _driver.FindElement(_adress).SendKeys("Berlin");
            return this;
        }
        public MyAccount Adress2()
        {
            _driver.FindElement(_adress2).SendKeys("Mexica");
            return this;
        }
        public MyAccount City()
        {
            _driver.FindElement(_city).SendKeys("Alaska");
            return this;
        }
        public MyAccount State()
        {
            _driver.FindElement(_state).SendKeys("Alaska");
            return this;
        }
        public MyAccount Postcode()
        {
            _driver.FindElement(_postcode).SendKeys("49000");
            return this;
        }
        public MyAccount AddInformation()
        {
            _driver.FindElement(_addInformation).SendKeys("Some info");
            return this;
        }
        public MyAccount Phone()
        {
            _driver.FindElement(_phone).SendKeys("2340030303030");
            return this;
        }
        public MyAccount PhoneMob()
        {
            _driver.FindElement(_phoneMob).SendKeys("36109999999");
            return this;
        }
        public Regisration Registr()
        {
            _driver.FindElement(_registr).Click();
            return new Regisration(_driver);
        }





    }
}
