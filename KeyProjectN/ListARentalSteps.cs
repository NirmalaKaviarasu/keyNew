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
    public class ListARentalSteps
    {
        private IWebDriver driver;

        [BeforeScenario("ListARental")]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://dev.property.community/Account/Login";
        }

        [Given(@"Login using Owners Account Details Page")]
        public void GivenLoginUsingOwnersAccountDetailsPage()
        {
            Login_Page lpg = new Login_Page(driver);
            lpg.LoginToApp();

        }

        [Given(@"Navigate to OwnersPage and Select My PropertyPage")]
        public void GivenNavigateToOwnersPageAndSelectMyPropertyPage()
        {
            My_Properties_Page Myproperty = new My_Properties_Page(driver);
            Myproperty.NavigateToOWner();
            Myproperty.NavigateToMyProperty();
        }
        
        [When(@"I Select List a Rental")]
        public void WhenISelectListARental()
        {
            My_Properties_Page Myproperty = new My_Properties_Page(driver);
            Myproperty.ListARental();
        }

        [When(@"Enter Details in List Rental Property Page by selecting Property to Rent and Save")]
        public void WhenEnterDetailsInListRentalPropertyPageBySelectingPropertyToRentAndSave()
        {
            ListARental_Page pg = new ListARental_Page(driver);
            pg.Enter_Value_ListARentalPage();
        }
        
        [Then(@"Property should dispalyed on Properties For Rent Page")]
        public void ThenPropertyShouldDispalyedOnPropertiesForRentPage()
        {
            ListARental_Page pg = new ListARental_Page(driver);
            pg.takescreenshot();
        }

         [AfterScenario("ListARental")]
         public void TearDown()
         {
             driver.Dispose();
         }

     
    }

}
