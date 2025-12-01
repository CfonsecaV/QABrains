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
            BrowserHelper.WaitCondition(_page.Driver, () => _page.FormSubmitButton.Enabled);
            _page.FormSubmitButton.Click();
        }
    }
}
