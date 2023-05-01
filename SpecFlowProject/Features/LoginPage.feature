Feature: LoginPage
Login related scenarios are covered here
A short summary of the feature


#Scenario: [scenario name]
#	Given [context]
#	When [action]
#	Then [outcome]
Background: Pre-condition
	Given I am on HP
	When I click file bug
	Then I am at LP
	When I enter username, pass and click on login
	Then login should be successful

Scenario: Login and Navigate to HomePage	
	When I click Home page link
	Then I should be navigated to HP
	When I Click logout
	Then Logout happens


Scenario: Login and Create a bug
	When I enter summary and click submit button
	Then Bug should be created
	When I Click logout
	Then Logout happens