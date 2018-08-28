using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace KeyProjectN.Pages
{
    class Finance_Details_Page
    {
        private readonly IWebDriver _driver;

        private WebDriverWait _Wait;
        

        public Finance_Details_Page(IWebDriver driver)
        {
            _driver = driver;
            _Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[1]/div[1]/div[1]/input")]
        [CacheLookup]
        public IList<IWebElement> PurchaseValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[1]/div[2]/div[1]/input")]
        [CacheLookup]
        public IWebElement Mortgage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[1]/div[3]/div[1]/input")]
        [CacheLookup]
        public IWebElement Homeval { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[8]/button[3]")]
        [CacheLookup]
        public IWebElement ClickNext { get; set; }



        public void EnterFinanceDet()
        {
            _Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='financeSection']/div[1]/div[3]/div[1]/input ")));

            IWebElement PurchasePrice = PurchaseValue[0];
            PurchasePrice.SendKeys("20000");
            Mortgage.SendKeys("10000");
            Homeval.SendKeys("40000");

            System.Threading.Thread.Sleep(1000);

            ClickNext.Click();

        }

    }
}
