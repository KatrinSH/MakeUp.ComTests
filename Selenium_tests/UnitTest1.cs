using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace Selenium_tests
{
    public class Tests : EmptyClass
    {

        IWebDriver chrome;


        [Fact]
        public void testSerchBox()
        {
            // Add Comment/
            chrome = StartDriverWithUrl("https://makeup.com.ua/");
            IWebElement element = chrome.FindElement(By.Id("search-input"));
            element.SendKeys("Eveline");
            element.SendKeys(Keys.Enter);

            IWebElement element1 = chrome.FindElement(By.Id("popularinput-checkbox-2251-28987"));
            element1.Click();

            Actions actions = new Actions(chrome);
            IWebElement element2 = chrome.FindElement(By.CssSelector("a[href= '/product/112671/']"));
            actions.MoveToElement(element2).Perform();
            IWebElement element3 = chrome.FindElement(By.CssSelector("a[href= '/product/112671/']"));
            element3.Click();

            IWebElement element4 = chrome.FindElement(By.CssSelector(".product-item__button > .button"));
            element4.Click();
            Thread.Sleep(1000);

            string actual_url = chrome.Url;
            Assert.Equal("https://makeup.com.ua/product/112671/", actual_url);
        }

        [Fact]
        public void testDelivery()
        {
            chrome = StartDriverWithUrl("https://makeup.com.ua/");
            IWebElement element = chrome.FindElement(By.XPath("(//a[contains(@href, '/delivery/')])[2]"));
            element.Click();

            string actual_url = chrome.Url;
            Assert.Equal("https://makeup.com.ua/delivery/", actual_url);
        }

        [Fact]
        public void testEmailBox()
        {
            chrome = StartDriverWithUrl("https://makeup.com.ua/");
            IWebElement element = chrome.FindElement(By.Name("email"));
            element.SendKeys("Katrin.shugay@gmail.com");
            element.SendKeys(Keys.Enter);

            string actual_url = chrome.Url;
            Assert.Equal("https://makeup.com.ua/", actual_url);
        }

        [Fact]
        public void testTelephone()
        {
            chrome = StartDriverWithUrl("https://makeup.com.ua/");
            IWebElement element = chrome.FindElement(By.ClassName("header-contact-list__link"));
            element.Click();

            string actual_url = chrome.Url;
            Assert.Equal("https://makeup.com.ua/", actual_url);

        }

        [Fact]
        public void testCallback()
        {
            chrome = StartDriverWithUrl("https://makeup.com.ua/");
            IWebElement element = chrome.FindElement(By.XPath("//*[@data-popup-handler='callback']"));
            element.Click();

            string actual_url = chrome.Url;
            Assert.Equal("https://makeup.com.ua/", actual_url);
        }

        [Fact]
        public void testLanguage()
        {
            chrome = StartDriverWithUrl("https://makeup.com.ua/");
            IWebElement element = chrome.FindElement(By.CssSelector("ul.footer-lang > li.footer-lang__item.active > a"));
            element.Click();

            string actual_url = chrome.Url;
            Assert.Equal("https://makeup.com.ua/", actual_url);
        }

        [Fact]
        public void testSocialNetwork()
        {
            chrome = StartDriverWithUrl("https://makeup.com.ua/");
            Actions actions = new Actions(chrome);
            IWebElement element2 = chrome.FindElement(By.CssSelector("a[href= 'https://www.facebook.com/makeup.ua']"));
            actions.MoveToElement(element2).Perform();

            IWebElement element = chrome.FindElement(By.CssSelector("a[href= 'https://www.facebook.com/makeup.ua']"));
            element.Click();

            IWebElement element3 = chrome.FindElement(By.CssSelector("a[href= 'https://www.youtube.com/user/makeupcomua/']"));
            element3.Click();

            IWebElement element5 = chrome.FindElement(By.CssSelector("a[href= 'https://www.instagram.com/makeup.ua/']"));
            element5.Click();

            string actual_url = chrome.Url;
            Assert.Equal("https://makeup.com.ua/", actual_url);
        }

        [Fact]
        public void testAuthorisation()
        {
            chrome = StartDriverWithUrl("https://makeup.com.ua/");
            IWebElement element = chrome.FindElement(By.XPath("//*[@data-popup-handler='auth']"));
            element.Click();

            IWebElement element2 = chrome.FindElement(By.Name("user_login"));
            element2.Click();

            IWebElement element3 = chrome.FindElement(By.Name("user_login"));
            element3.SendKeys("Katrin.Shugay@gmail.com");
            element3.SendKeys(Keys.Enter);

            IWebElement element4 = chrome.FindElement(By.Name("user_pw"));
            element2.Click();

            IWebElement element5 = chrome.FindElement(By.Name("user_pw"));
            element3.SendKeys("0123456789");
            element3.SendKeys(Keys.Enter);

            string actual_url = chrome.Url;
            Assert.Equal("https://makeup.com.ua/", actual_url);
        }

        [Fact]
        public void testRegistation()
        {
            chrome = StartDriverWithUrl("https://makeup.com.ua/");
            IWebElement element = chrome.FindElement(By.XPath("//*[@data-popup-handler='auth']"));
            element.Click();

            IWebElement element2 = chrome.FindElement(By.ClassName("auth-link"));
            element2.Click();

            string actual_url = chrome.Url;
            Assert.Equal("https://makeup.com.ua/", actual_url);
        }

        [Fact]
        public void testOpenProdukt()
        {
            chrome = StartDriverWithUrl("https://makeup.com.ua/");
            IWebElement element = chrome.FindElement(By.XPath("//a[contains(text(),'Giorgio Armani My Way Intense')]"));
            element.Click();

            IWebElement element2 = chrome.FindElement(By.CssSelector(".select span"));
            element2.Click();

            IWebElement element3 = chrome.FindElement(By.CssSelector(".variant:nth-child(2)"));
            element3.Click();

            IWebElement element4 = chrome.FindElement(By.CssSelector(".product-item__button > .button"));
            element4.Click();

            IWebElement element5 = chrome.FindElement(By.CssSelector(".link:nth-child(1)"));
            element5.Click();

            string actual_url = chrome.Url;
            Assert.Equal("https://makeup.com.ua/product/960058/", actual_url);
        }


        [Fact]
        public void testSale()
        {
            chrome = StartDriverWithUrl("https://makeup.com.ua/");

            IWebElement element = chrome.FindElement(By.LinkText("Акции"));
            element.Click();

            IWebElement element2 = chrome.FindElement(By.LinkText("Популярные"));
            element2.Click();

            IWebElement element3 = chrome.FindElement(By.CssSelector(".action-item:nth-child(2) > .action-item__link"));
            element3.Click();

            Actions actions = new Actions(chrome);
            IWebElement element4 = chrome.FindElement(By.CssSelector(".simple-slider-list__item:nth-child(1) > .simple-slider-list__link .simple-slider-list__name"));
            actions.MoveToElement(element4).Perform();

            IWebElement element5 = chrome.FindElement(By.CssSelector(".active .button"));
            element5.Click();

            string actual_url = chrome.Url;
            Assert.Equal("https://makeup.com.ua/news/52053/", actual_url);

        }
        [Fact]
        public void testBeatyClub()
        {
            chrome = StartDriverWithUrl("https://makeup.com.ua/");
            IWebElement element = chrome.FindElement(By.LinkText("Beauty Club"));
            element.Click();

            IWebElement element2 = chrome.FindElement(By.CssSelector("div:nth-child(1) > .loyalty-wrap > div > strong"));
            element2.Click();

            Actions actions = new Actions(chrome);
            IWebElement element3 = chrome.FindElement(By.XPath("//div[@id='popup__window']/div"));
            actions.MoveToElement(element3).Perform();

            IWebElement element4 = chrome.FindElement(By.XPath("//div[@id='popup__window']/div"));
            element4.Click();

            IWebElement element5 = chrome.FindElement(By.CssSelector("div:nth-child(2) > .loyalty-wrap > div > strong"));
            element5.Click();

            IWebElement element6 = chrome.FindElement(By.XPath("//div[@id='popup__window']/div"));
            actions.MoveToElement(element6).Perform();

            IWebElement element7 = chrome.FindElement(By.XPath("//div[@id='popup__window']/div"));
            element7.Click();

            string actual_url = chrome.Url;
            Assert.Equal("https://makeup.com.ua/about/23/", actual_url);
        }

        [Fact]
        public void testArticles()
        {
            chrome = StartDriverWithUrl("https://makeup.com.ua/");
            IWebElement element = chrome.FindElement(By.LinkText("Статьи"));
            element.Click();

            IWebElement element2 = chrome.FindElement(By.CssSelector(".news-list__item:nth-child(1) .news-list__header"));
            element2.Click();

            IWebElement element3 = chrome.FindElement(By.LinkText("Косметика для волос, лица и тела Hawkins & Brimble"));
            element3.Click();           

            Actions actions = new Actions(chrome);
            IWebElement element4 = chrome.FindElement(By.XPath("//a[contains(@href, '/product/691259/')]"));
            actions.MoveToElement(element4).Perform();

            IWebElement element5 = chrome.FindElement(By.XPath("//a[contains(@href, '/product/691259/')]"));
            element5.Click();

            IWebElement element6 = chrome.FindElement(By.CssSelector(".logo"));
            element6.Click();

            string actual_url = chrome.Url;
            Assert.Equal("https://makeup.com.ua/", actual_url);
        }

    }
}