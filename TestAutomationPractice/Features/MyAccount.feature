Feature: MyAccount
	In order to use all funcionalities
	As a user
	I want to be able to manage my account

@mytag
Scenario: User can log in
	Given user open sign in page
	And enter correct credentials
	When user submits the login form
	Then user will be logged in