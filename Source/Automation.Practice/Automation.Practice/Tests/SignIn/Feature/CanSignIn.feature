Feature: User can sign in 
	In order to access the system
	As a user
	I want to sign in
	
@smoke
Scenario: Can sign in as a new user
	Given I am on the landing page
	When I attempt to sign in 
	Then I am able to access the system
