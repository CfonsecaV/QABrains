using AutomationFramework.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _webDriver;
        private readonly string _baseUrl;

        private readonly By formSubmissionLocator = By.Id("form-submission");

        public HomePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            _baseUrl = BrowserFactory.LoadApplication();
        }

        public string BaseUrl => _baseUrl;
        public IWebDriver Driver => _webDriver;
        public IWebElement FormSubmission => _webDriver.FindElement(formSubmissionLocator);
    }
}
