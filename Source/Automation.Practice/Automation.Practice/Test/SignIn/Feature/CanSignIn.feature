Feature: Can sign in 
	In order to sign in 
	As a new user
	I want to be able to access the system
	
@smoke
Scenario: New user can sign in 
	Given I am on the landing page
	When I attempt to sign in
	Then I can access the system
