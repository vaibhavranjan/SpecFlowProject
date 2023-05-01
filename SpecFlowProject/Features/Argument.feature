Feature: Argument
To demonstrate passing of argument value from feature to step definition
A short summary of the feature

@tag1
Scenario: Verify Link
	Given I am on main page of google with "http://localhost:500/"
	When I click on file a bug
	Then I should be navigated to login page

Scenario: Login Scenario
	When User click on "File a Bug" link
	Then User should be navigated to login page
	When user supply "vaibhav@bugzilla.com" , "dob@2891" and click on login
	Then user should be logged in

Scenario: Enter a bug
	When User click on "File a Bug" link
	Then User should be navigated to login page
	When user supply "vaibhav@bugzilla.com" , "dob@2891" and click on login
	Then user should be logged in
	When user Provide severity, hardware,  summary and description
		| Severity | Hardware  | Summary   | Description |
		| critical | Macintosh | summary 1 | Desc 1      |
	And User click submit
	Then Bug should be created

@tag2
Scenario Outline: usage of scenario outline
	When you click "<flink>"
	Then User should be navigated to login page
	When you enter "<username>", "<password>" and click login
	Then you should be on enter a bug page
	When you enter details "<Severity>", "<Hardware>", "<Summary>", "<Description>"
	And Click on submit bug
	Then Bug should be created
	When I Click logout
	Then Logout happens
Examples:
	| flink      | username             | password | Severity | Hardware  | Summary   | Description |
	| File a Bug | vaibhav@bugzilla.com | dob@2891 | critical | Macintosh | summary 1 | Desc 1      |
	| File a Bug | vaibhav@bugzilla.com | dob@2891 | blocker  | Other     | summary 2 | Desc 2      |


	

	


