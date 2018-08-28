Feature: List A Rental
	     In order to List a Rental
	     As a Property Owner
	     I want to have Property which is already displyed under Myproperty 

@ListARental
Scenario: List A Rental
    Given Login using Owners Account Details Page
	And Navigate to OwnersPage and Select My PropertyPage
	When I Select List a Rental 
    And Enter Details in List Rental Property Page by selecting Property to Rent and Save
	Then Property should dispalyed on Properties For Rent Page
