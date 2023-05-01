Feature: FileUpload

A short summary of the feature

@tag1
#Scenario: [scenario name]
#	Given [context]
#	When [action]
#	Then [outcome]


Scenario: Test File Upload
	Given I am on HP
	When I click file bug
	Then I am at LP
	When I enter username, pass and click on login
	Then login should be successful
	When user Provide severity, hardware,  summary and description
		| Severity | Hardware  | Summary   | Description |
		| critical | Macintosh | summary 1 | Desc 1      |
	And clicked on Add attachment
	And upload a file
	And User click submit