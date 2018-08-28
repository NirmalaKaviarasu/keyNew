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
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace KeyProjectN.Pages
{
    class ListARental_Page
    {

        private readonly IWebDriver _driver;

        private WebDriverWait _Wait;



        public ListARental_Page(IWebDriver driver)
        {
            _driver = driver;
            _Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            PageFactory.InitElements(_driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[2]/select")]
        [CacheLookup]
        public IWebElement SelectProp { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[3]/div[1]/input[1]")]
        [CacheLookup]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[3]/div[2]/textarea")]
        [CacheLookup]
        public IWebElement Description { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[3]/div[1]/input[2]")]
        [CacheLookup]
        public IWebElement MovingCost { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[4]/div[1]/input")]
        [CacheLookup]
        public IWebElement TargetRent { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[5]/div[1]/input")]
        [CacheLookup]
        public IWebElement AvailableDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[6]/div[1]/input")]
        [CacheLookup]
        public IWebElement OccupantsCount { get; set; }

        [FindsBy(How = How.Id, Using = "file-upload")]
        [CacheLookup]
        public IWebElement UploadPhoto { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[8]/div/button[1]")]
        [CacheLookup]
        public IWebElement Save { get; set; }

        public void Enter_Value_ListARentalPage()
        {

           // var SelectElement = new SelectElement(SelectProp);
           // SelectElement.SelectByIndex(1);

            Actions actions = new Actions(_driver);
            actions.MoveToElement(SelectProp);
            actions.Click();
            actions.SendKeys("1222 High Street, Taita, Lower Hutt, 5011");
            actions.Build().Perform();
            System.Threading.Thread.Sleep(50);


            Title.SendKeys("TestTitleNewToRent");
            Description.SendKeys("Description To Test");
            MovingCost.SendKeys("2000");
            TargetRent.SendKeys("200");
            AvailableDate.SendKeys("10/05/2019");
            System.Threading.Thread.Sleep(50);

            OccupantsCount.SendKeys("2");
            UploadPhoto.SendKeys(@"C:\Users\Mallik\Desktop\Test.jpg");
            System.Threading.Thread.Sleep(50);


            Save.Click();

           // IAlert alert = _driver.SwitchTo().Alert();
          //  alert.Accept();

           // System.Threading.Thread.Sleep(50);

        }

        public void takescreenshot()
        {
            _Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='main-content']/div/div[1]/div[2]/div/div[1]/div/div/div[1]")));

            Screenshot ss = ((ITakesScreenshot)_driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\Mallik\source\repos\KeyProjectN\KeyProjectN\Screenshot\RentedProperty.jpg");

        }
    }
}
