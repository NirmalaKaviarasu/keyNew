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
    class Tenant_Details_Page
    {
        private readonly IWebDriver _driver;

        private WebDriverWait _Wait;


        public Tenant_Details_Page(IWebDriver driver)
        {
            _driver = driver;
            _Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            PageFactory.InitElements(_driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//*[@id='email']")]
        [CacheLookup]
        public IWebElement TenantEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='fname']")]
        [CacheLookup]
        public IWebElement TenantFullname { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='lname']")]
        [CacheLookup]
        public IWebElement TenantLastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ramount']")]
        [CacheLookup]
        public IWebElement RentAmt { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='psdate']")]
        [CacheLookup]
        public IWebElement PaymentStartDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='sdate']")]
        [CacheLookup]
        public IWebElement StartDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edate']")]
        [CacheLookup]
        public IWebElement EndDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='tenantSection']/div[4]/a")]
        [CacheLookup]
        public IWebElement Liabilities { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LiabilityDetail']/div/div[1]/div[2]/div[1]/input")]
        [CacheLookup]
        public IWebElement ValLiabilities { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='saveProperty']")]
        [CacheLookup]
        public IWebElement ClickSave { get; set; }


        public void EnterTenantDet()
        {
            _Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='lname']")));
            TenantEmail.SendKeys("tenantnew@gmail.com");
            TenantFullname.SendKeys("Tenant");
            TenantLastName.SendKeys("TenantLast");
            RentAmt.SendKeys("200");

            /*   IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
               js.ExecuteScript(StartDate.startD);

               String startD = "24/09/2018";
           */

            StartDate.SendKeys("24/09/2018");
            StartDate.Click();
            System.Threading.Thread.Sleep(1000);

            EndDate.SendKeys("24/08/2028");
            EndDate.Click();
            System.Threading.Thread.Sleep(1000);

            PaymentStartDate.SendKeys("24/09/2018");
            PaymentStartDate.Click();
            System.Threading.Thread.Sleep(1000);


            Liabilities.Click();
            _Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='LiabilityDetail']/div/div[1]/div[2]/div[1]/input")));

            ValLiabilities.SendKeys("1000");
            ClickSave.Click();


        }
    }
}
