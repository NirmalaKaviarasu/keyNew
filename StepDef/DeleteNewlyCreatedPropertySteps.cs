using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using NUnit.Framework;
using KeyProjectN.Pages;
using OpenQA.Selenium.Support.UI;

namespace KeyProjectN
{
    [Binding]
    public class DeleteNewlyCreatedPropertySteps
    {
        private IWebDriver driver;

        [BeforeScenario("Delete")]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://dev.property.community/Account/Login";
        }


        [Given(@"Login using Owners Account Details")]
        public void GivenLoginUsingOwnersAccountDetails()
        {
            Login_Page lpg = new Login_Page(driver);
            lpg.LoginToApp();
       
        }
        
        [Given(@"Navigate to Owners Page")]
        public void GivenNavigateToOwnersPage()
        {
            My_Properties_Page Myproperty = new My_Properties_Page(driver);
            Myproperty.NavigateToOWner();
        }
        
        [Given(@"Select Myproperty page from Owners")]
        public void GivenSelectMypropertyPageFromOwners()
        {
            My_Properties_Page Myproperty = new My_Properties_Page(driver);
            Myproperty.NavigateToMyProperty();
        }
        
        [Given(@"Choose property from myproperty page to delete")]
        public void GivenChoosePropertyFromMypropertyPageToDelete()
        {
            My_Properties_Page pg = new My_Properties_Page(driver);
            pg.Select_Prop_To_Delete();

        }
        
               
        [When(@"I choose Option Delete")]
        public void WhenIChooseOptionDelete()
        {
            Delete_Page pg = new Delete_Page(driver);
            pg.DeleteProperty();

        }
        
        [Then(@"Property should get deleted Successfully")]
        public void ThenPropertyShouldGetDeletedSuccessfully()
        {
            Delete_Page pg = new Delete_Page(driver);
            pg.Deletedtakescreenshot();
        }

        [AfterScenario("Delete")]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}
