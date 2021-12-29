using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Selenium_tests
{
    public class EmptyClass : IDisposable
    {

        private IWebDriver _chrome ;
   
        public void Dispose()
        {
            _chrome.Quit();
        }
        public IWebDriver StartDriverWithUrl(string url)
        {
            _chrome = new ChromeDriver();
            _chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            _chrome.Navigate().GoToUrl(url);
            return _chrome;
        }
    }
}