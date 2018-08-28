Feature: Create New Property as "Affortable Housing"
	In order Create New Property as "Affortable Housing"
	As a Property Owner
	I want to have Property details and Tenant Details

@Create
Scenario: Create New Property as "Affortable Housing"
	
	   Given Login Using Owners Account details
       And Navigate to Owners tab
       And Select My property page from Owners
       And Click on Add New property
	
	  When I Select New Property as Affordable Housing and give Valid details for other fields and Click next to get Finance Details page
       And Enter Valid Information on Finance Details page and click on next to get Tenant Details page
       And Enter Valid Details on Tenant Details Page and Click Submit
	
	Then User able to Save all information and should get proper Message for Submitting and New Property as Affordable Housing Should get Created 

