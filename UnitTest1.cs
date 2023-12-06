using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;
using System.Threading;

namespace SeleniumTests
{
    public class Tests
    {

        IWebDriver driver;
        String test_url = "https://timokaalma22.thkit.ee/";
        private readonly Random _random = new Random();

        [SetUp]
        public void start_browser()
        {
            driver = new ChromeDriver(); //("C:\Users\timok\SeleniumTests\Drivers\\");
            driver.Manage().Window.Maximize();
        }
        // testib home linki (Testing home link)
        [Test]
        public void test_page1()
        {
            driver.Url = test_url;
            Thread.Sleep(3500);
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"menu-item-13\"]/a"));
            element.Click();
            Thread.Sleep(4000);
        }
        // testib blogi linki (Testing blog link)
        [Test]
        public void test_page2()
        {
            driver.Url = test_url;
            Thread.Sleep(3000);
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"menu-item-587\"]/a"));
            element.Click();
            Thread.Sleep(5000);
        }

        // testib let's meet linki (Testing let's meet link)
        [Test]
        public void test_page3()
        {
            driver.Url = test_url;
            Thread.Sleep(3500);
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"post-540\"]/div/div/section[3]/div[2]/div/div/div[4]/div/div/a/span"));
            element.Click();
            Thread.Sleep(3500);
        }
        // testib home linki (vasakul yleval)/ Testing home link (up-left)
        [Test]
        public void test_page4()
        {
            driver.Url = test_url;
            Thread.Sleep(2500);
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"ast-desktop-header\"]/div[1]/div/div/div/div[1]/div/div/span/a/img"));
            element.Click();
            Thread.Sleep(2500);
        }


        // testib about linki (Testing about link)
        [Test]
        public void test_page5()
        {
            driver.Url = test_url;
            Thread.Sleep(2500);
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"menu-item-12\"]/a"));
            element.Click();
            Thread.Sleep(2500);
        }

        // testib contact linki (Testing contact link)
        [Test]
        public void test_page6()
        {
            driver.Url = test_url;
            Thread.Sleep(2500);
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"menu-item-150\"]/a"));
            element.Click();
            Thread.Sleep(2500);
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Close();
        }
    }
}