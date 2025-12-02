using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.Utils
{
    public class BrowserHelper
    {
        public static void WaitUntil(IWebDriver webDriver, Func<IWebDriver, bool> condition, int timeoutSeconds = 10)
        {
            WebDriverWait wait = new(webDriver, TimeSpan.FromSeconds(timeoutSeconds));
            wait.IgnoreExceptionTypes(
                typeof(ElementClickInterceptedException),
                typeof(NoSuchElementException),
                typeof(StaleElementReferenceException),
                typeof(ElementNotInteractableException));
            wait.Until(condition);
        }
        public static Actions GetAction(IWebDriver webDriver)
        {
            Actions action = new(webDriver);
            return action;
        }

        public static string GetPageSource(IWebDriver webDriver)
        {
            string pageSource = webDriver.PageSource;
            return pageSource;
        }

        public static void ScrollToElement(IWebDriver driver, IWebElement element)
        {
            GetAction(driver).MoveToElement(element);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public static void JsClick(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)(driver);
            js.ExecuteScript("arguments[0].click();", element);
        }
    }
}
