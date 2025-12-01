using System;
using System.Collections.Generic;
using System.Text;
using AutomationFramework.Pages;
using AutomationFramework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V140.Browser;

namespace AutomationFramework.Contexts
{
    public class HomePageContext
    {
        private HomePage _page;

        public HomePageContext(IWebDriver webDriver)
        {
            _page = new HomePage(webDriver);
        }
        public void Open() => _page.Driver.Navigate().GoToUrl(_page.BaseUrl);
        public FormPageContext ClickSubmissionFormButton()
        {
            BrowserHelper.WaitCondition(_page.Driver, () => _page.FormSubmission.Enabled);
            _page.FormSubmission.Click();
            return new FormPageContext(_page.Driver);
        }
    }
}
