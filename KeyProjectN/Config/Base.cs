using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using NUnit.Framework;
using KeyProjectN.Pages;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace KeyProjectN.Config
{
    public class Base
    {
        private IWebDriver _driver;

        public Base(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }


        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }
        
    }
}
