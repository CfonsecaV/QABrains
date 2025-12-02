using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V140.Emulation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.Pages
{
    public class FormPage
    {
        private readonly IWebDriver _webDriver;

        private readonly By formSubmitButtonLocator = By.CssSelector("[type='submit']");
        private readonly By nameRequiredErrorLocator = By.XPath("//p[text()='Name is a required field']");
        private readonly By emailRequiredErrorLocator = By.XPath("//p[text()='Email is a required field']");
        private readonly By contactRequiredErrorLocator = By.XPath("//p[text()='Contact is a required field']");
        private readonly By uploadRequiredErrorLocator = By.XPath("//p[text()='Upload File is a required field']");
        private readonly By colorRequiredErrorLocator = By.XPath("//p[text()='Color is a required field']");
        private readonly By foodRequiredErrorLocator = By.XPath("//p[text()='Food is a required field']");
        private readonly By countryRequiredErrorLocator = By.XPath("//p[text()='Country is a required field']");

        public FormPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public IWebDriver Driver => _webDriver;
        public IWebElement FormSubmitButton => _webDriver.FindElement(formSubmitButtonLocator);
        public IWebElement NameRequiredError => _webDriver.FindElement(nameRequiredErrorLocator);
        public IWebElement EmailRequiredError => _webDriver.FindElement(emailRequiredErrorLocator);
        public IWebElement ContactRequiredError => _webDriver.FindElement(contactRequiredErrorLocator);
        public IWebElement UploadRequiredError => _webDriver.FindElement(uploadRequiredErrorLocator);
        public IWebElement ColorRequiredError => _webDriver.FindElement(colorRequiredErrorLocator);
        public IWebElement FoodRequiredError => _webDriver.FindElement(foodRequiredErrorLocator);
        public IWebElement CountryRequiredError => _webDriver.FindElement(countryRequiredErrorLocator);
    }
}
