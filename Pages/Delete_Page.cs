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
    class Delete_Page
    {
        private readonly IWebDriver _driver;

        private WebDriverWait _Wait;


        public Delete_Page(IWebDriver driver)
        {
            _driver = driver;
            _Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            PageFactory.InitElements(_driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/div[4]/div/div[2]/div[7]/button[1]")]
        [CacheLookup]
        public IWebElement ClickDelete { get; set; }

        public void DeleteProperty()
        {
            _Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='main-content']/div/div[4]/div/div[2]/div[7]/button[1]")));
            ClickDelete.Click();

        }

        public void Deletedtakescreenshot()
        {
            _Wait.Until(ExpectedConditions.ElementExists(By.Id("SearchBox")));

            Screenshot ss = ((ITakesScreenshot)_driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\Mallik\source\repos\KeyProjectN\KeyProjectN\Screenshot\DeletedProperty.jpg");

        }
    }
}
