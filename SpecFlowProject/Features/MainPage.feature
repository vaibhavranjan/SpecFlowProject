Feature: MainPage
  

A short summary of the feature - Testing all possible scenarion from MainPage of bugzilla app.

@tag1
#Scenario: [scenario name]
#	Given [context]
#	When [action]
#	Then [outcome]


Scenario: Verify File a bug link
	Given I am at MainPage
	When I click file a bug link
	Then Login page should display

