Feature: User can buy item
	In order to buy item
	As a user
	I want to sucessfully checkout 


Scenario: New user can buy item
	Given I have selected and item
	When I attempt to buy it
	Then I should be able to checkout

Scenario: New user can change item color
	Given I have selected and item
    And changed the color
	When I attempt to buy it
	Then I should be able to checkout

Scenario: New user change item size
	Given I have selected and item
    And changed size
	When I attempt to buy it
	Then I should be able to checkout

Scenario: New user can change item quantity
	Given I have selected and item
    And changed quantity
	When I attempt to buy it
	Then I should be able to checkout 


