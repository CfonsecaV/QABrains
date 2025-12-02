using AutomationFramework.Contexts;
using AutomationFramework.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.Base
{
    public class BaseTest
    {
        protected IWebDriver? _driver;
        protected HomePageContext _homeContext;

        [SetUp]
        public void Setup()
        {
            var browser = TestContext.Parameters.Get("BROWSER") ?? "Chrome";
            BrowserFactory factory = new(Enum.Parse<Browsers>(browser, true));
            _driver = factory.GetInstanceOf();
            _homeContext = new(_driver);
            _homeContext.Open();
        }

        [TearDown]
        public void Teardown()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
                _driver = null;
            }
        }
    }
}
