Feature: ContactUs
	In order to contact customer service
	As a user
	I want to be able to use contact us form

@mytag
Scenario: User can contact customer servise
	Given User opens contact us page 
	When User fill in required fields field with "Webmaster" reading "QA Kus" message
	And user submits the form
	Then message "Your message has been successfully sent to our team." is presented to the user