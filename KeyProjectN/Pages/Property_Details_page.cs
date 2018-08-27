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
using System.Windows.Forms;

namespace KeyProjectN.Pages
{
    class Property_Details_page
    {
        private readonly IWebDriver _driver;

        private WebDriverWait _Wait;
        //IAlert alert;

        public Property_Details_page(IWebDriver driver)
        {
            _driver = driver;
            _Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "input[name=propertyName]")]
        [CacheLookup]
        public IWebElement Propertyname { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='property - details']/div[2]/div[2]/div")]
        [CacheLookup]
        public IWebElement PropertyType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='property - details']/div[2]/div[2]/div/div[2]/div[3]")]
        [CacheLookup]
        public IWebElement PropertyTypeSenior { get; set; }
        
        

        [FindsBy(How = How.CssSelector, Using = "input[name=searchAddress]")]
        [CacheLookup]
        public IWebElement ProprtyAddress { get; set; }


        [FindsBy(How = How.Id, Using = "street_number")]
        [CacheLookup]
        public IWebElement StreetNo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='route']")]
        [CacheLookup]
        public IList<IWebElement> AddressElement1 { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='street_number']")]
        [CacheLookup]
        public IList<IWebElement> AddressElement2 { get; set; }

        [FindsBy(How = How.ClassName, Using = "add-prop-desc")]
        [CacheLookup]
        public IWebElement PropDes { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='region']")]
        [CacheLookup]
        public IWebElement Region { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='property - details']/div[4]/div/div[2]/div/select")]
        [CacheLookup]
        public IWebElement RentType { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "#property-details > div:nth-child(5) > div > div:nth-child(1) > div.ui.input.full.width > input[type='text']")]
        [CacheLookup]
        public IWebElement TargetRent { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#property-details > div:nth-child(7) > div:nth-child(1) > div.ui.input.full.width > input[type='text']")]
        [CacheLookup]
        public IWebElement Bedrooms { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#property-details > div:nth-child(7) > div:nth-child(2) > div.ui.input.full.width > input[type='text']")]
        [CacheLookup]
        public IWebElement Bathrooms { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[7]/div[1]/div[1]/input")]
        [CacheLookup]
        public IWebElement CarPark { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[7]/div[2]/div[1]/input")]
        [CacheLookup]
        public IWebElement YearBuilt { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='file-upload']")]
        [CacheLookup]
        public IWebElement Fileupload { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[10]/div/button[1]")]
        [CacheLookup]
        public IWebElement ClickNext { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='property-details]")]
        [CacheLookup]
        public IWebElement Outerlay { get; set; }

        
        public void Enterpropertydetails()
        {
            
                _Wait.Until(ExpectedConditions.ElementExists(By.ClassName("title")));
                string propdetpag = _driver.Title;

                Assert.AreEqual(propdetpag, "Properties | Add New Property");
                Propertyname.SendKeys("NewProperty");
                /* Actions actions = new Actions(_driver);
                 actions.MoveToElement(PropertyType);
                 actions.Click();
                 actions.SendKeys("Section and Property");
                 actions.Build().Perform();*/

            StreetNo.SendKeys("1222");
            
            IWebElement streetname = AddressElement1[0];
            streetname.SendKeys("High Street");

            IWebElement Suburb = AddressElement1[1];
            Suburb.SendKeys("Taita");

            IWebElement City = AddressElement2[1];
            IWebElement Postcode = AddressElement2[2];
            City.SendKeys("Lower Hutt");


            Postcode.SendKeys("5011");

            PropDes.SendKeys("Property Description");

            Region.SendKeys("Wellington");

            System.Threading.Thread.Sleep(4000);

            TargetRent.SendKeys("200");
            Bedrooms.SendKeys("2");
            YearBuilt.SendKeys("1999");
            Bathrooms.SendKeys("2");

            Fileupload.SendKeys(@"C:\Users\Mallik\Desktop\Test.jpg");
            CarPark.SendKeys("2");

            System.Threading.Thread.Sleep(1000);

            //File IUpload
            /*  System.Threading.Thread.Sleep(2000);

              SendKeys.SendWait(@"C:\Users\Mallik\Desktop\Test.jpg");
              System.Threading.Thread.Sleep(2000);

              SendKeys.SendWait(@"{Enter}");
                 */

            YearBuilt.Click();
            System.Threading.Thread.Sleep(1000);
            ClickNext.Click();
                        
        }

       
    }
    }


    


