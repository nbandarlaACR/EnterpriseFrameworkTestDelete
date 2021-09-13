using LFL.Automation.Framework.Actions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LFL.Automation.Framework.PageHelper
{
    public static class WebPageHelper
    {
        private static readonly By acceptCookies = By.XPath("//div[@id='cookieConsent']/descendant::button");

        public static void ClickAcceptCookiesIfPresent(IWebDriver driver)
        {
            bool cookies = WebActions.WaitForItem(driver, acceptCookies, 5);
            if (cookies)
            {
                IWebElement element = driver.FindElement(acceptCookies);
                element.Click();
            }
        }
    }
}
