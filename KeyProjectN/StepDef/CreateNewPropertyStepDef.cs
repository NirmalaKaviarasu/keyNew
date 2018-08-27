using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using NUnit.Framework;
using KeyReport.Pages;
using OpenQA.Selenium.Support.UI;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;

namespace KeyReport
{
    [Binding]
    public class CreateNewPropertyStepDef 
    {
        private IWebDriver driver;
        private static ExtentTest featurename;
        private static ExtentTest scenario;
        private static ExtentReports Extent1 = new ExtentReports();

        [BeforeTestRun]
        public static void init()
        {
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Mallik\Desktop\KeyProjectN\ExtendReport.html");
            htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
             Extent1.AttachReporter(htmlReporter);
         
        }


        [BeforeScenario("Create")]
        public void SetUp()
        {
            //Crate Test
                      
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://dev.property.community/Account/Login";
            scenario = Extent1.CreateTest<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [BeforeFeature("Create")]
        public static void BeforeFet()
        {
            featurename = Extent1.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            
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

        [AfterStep("Create")]
        public static void afterTest()
        {
            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
        }

        [AfterTestRun]
        public static void TearDownReprt()
        {
            Extent1.Flush();
        }
    }
}
