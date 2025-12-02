using AutomationFramework.Pages;
using AutomationFramework.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.Contexts
{
    public class FormPageContext
    {
        private FormPage _page;
        public FormPageContext(IWebDriver webDriver)
        {
            _page = new FormPage(webDriver);
        }

        public void ClickSubmitButton()
        {
            BrowserHelper.ScrollToElement(_page.Driver, _page.FormSubmitButton);
            BrowserHelper.WaitUntil(_page.Driver, d => IsSubmitButtonEnabled());
            _page.FormSubmitButton.Click();
        }
        public bool IsSubmitButtonEnabled() => _page.FormSubmitButton.Enabled;
        public bool IsNameErrorMessageVisible() => _page.NameRequiredError.Displayed;
        public bool IsEmailErrorMessageVisible() => _page.EmailRequiredError.Displayed;
        public bool IsContactErrorMessageVisible() => _page.ContactRequiredError.Displayed;
        public bool IsUploadErrorMessageVisible() => _page.UploadRequiredError.Displayed;
        public bool IsColorErrorMessageVisible() => _page.ColorRequiredError.Displayed;
        public bool IsFoodErrorMessageVisible() => _page.FoodRequiredError.Displayed;
        public bool IsCountryErrorMessageVisible() => _page.CountryRequiredError.Displayed;
    }
}
