Feature: User Can sign in 
	In order to sign in
	As a user
	I want to be able to access the system
	
@smoke
Scenario: New User can sign in 
	Given I am on the landing page
	When I attempt to sign in 
	Then I can access the system
