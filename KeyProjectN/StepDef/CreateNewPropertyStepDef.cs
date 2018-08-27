using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using NUnit.Framework;
using KeyProjectN.Pages;
using KeyProjectN.Config;
using OpenQA.Selenium.Support.UI;

namespace KeyProjectN 
{
    [Binding]
    public class CreateNewPropertyStepDef 
    {
        private IWebDriver driver;

        [BeforeScenario("Create")]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://dev.property.community/Account/Login";
        }

        [Given(@"Login Using Owners Account details")]
        public void GivenLoginUsingOwnersAccountDetails()
        {
                   
            Login_Page Login = new Login_Page(driver);
            Login.LoginToApp();
        }
        
        [Given(@"Navigate to Owners tab")]
        public void GivenNavigateToOwnersTab()
        {
            My_Properties_Page Myproperty = new My_Properties_Page(driver);
            Myproperty.NavigateToOWner();
          
        }
        
        [Given(@"Select My property page from Owners")]
        public void GivenSelectMyPropertyPageFromOwners()
        {
           My_Properties_Page Myproperty = new My_Properties_Page(driver);
           Myproperty.NavigateToMyProperty();
        }
        
        [Given(@"Click on Add New property")]
        public void GivenClickOnAddNewProperty()
        {
            My_Properties_Page Myproperty = new My_Properties_Page(driver);
            Myproperty.ClickonAddnewproperty();
        }

        [When(@"I Select New Property as Affordable Housing and give Valid details for other fields and Click next to get Finance Details page")]
        public void WhenISelectNewPropertyAsAffordableHousingAndGiveValidDetailsForOtherFieldsAndClickNextToGetFinanceDetailsPage()
        {
            Property_Details_page Property_dt_Pg = new Property_Details_page(driver);
            Property_dt_Pg.Enterpropertydetails();
        }
                                
        [When(@"Enter Valid Information on Finance Details page and click on next to get Tenant Details page")]
        public void WhenEnterValidInformationOnFinanceDetailsPageAndClickOnNextToGetTenantDetailsPage()
        {
            Finance_Details_Page Finance_pg = new Finance_Details_Page(driver);
            Finance_pg.EnterFinanceDet();
        }
        
        [When(@"Enter Valid Details on Tenant Details Page and Click Submit")]
        public void WhenEnterValidDetailsOnTenantDetailsPageAndClickSubmit()
        {
            Tenant_Details_Page Tenant = new Tenant_Details_Page(driver);
            Tenant.EnterTenantDet();

        }
        
        [Then(@"User able to Save all information and should get proper Message for Submitting and New Property as Affordable Housing Should get Created")]
        public void ThenUserAbleToSaveAllInformationAndShouldGetProperMessageForSubmittingAndNewPropertyAsAffordableHousingShouldGetCreated()
        {
            My_Properties_Page pg = new My_Properties_Page(driver);
            pg.takescreenshot();
        }

        [AfterScenario("Create")]
        public void TearDown()
        {
            driver.Dispose();
        }

    }
}
