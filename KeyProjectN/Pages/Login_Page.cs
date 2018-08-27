using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KeyProjectN.Pages
{
    public class Login_Page
        {
        private readonly IWebDriver _driver;

        public Login_Page(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = "input#UserName")]
        [CacheLookup]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#Password")]
        [CacheLookup]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.ui.fluid.large.teal.submit.button")]
        [CacheLookup]
        public IWebElement Submit { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a.introjs-button.introjs-skipbutton")]
        [CacheLookup]
        public IWebElement Skipmessage { get; set; }


        public void LoginToApp()
        {
            UserName.SendKeys("Keyowner2018@gmail.com");
            Password.SendKeys("Key@2018");
            Submit.Submit();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            Skipmessage.Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }


    }
    }

