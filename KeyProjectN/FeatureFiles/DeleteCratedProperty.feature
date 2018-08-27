Feature: Delete Newly Created Property 
	In order Delete New Property as "Affortable Housing"
	As a Property Owner
	I want to have Property which is already displyed under Myproperty 

@Delete
Scenario: Delete Newly Created Property as "Affortable Housing"
	Given Login using Owners Account Details
	And Navigate to Owners Page
	And Select Myproperty page from Owners
	And Choose property from myproperty page to delete
	When I choose Option Delete 
	Then Property should get deleted Successfully
