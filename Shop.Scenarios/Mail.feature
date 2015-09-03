Feature: Mail

Scenario: Send mail to multiple recipients
	When I want to send mail to 'zbcjackson@gmail.com', 'zbcjackson@odd-e.com'
		| title | content      |
		| Hello | How are you! |
	Then 'zbcjackson@gmail.com' received mail
	And 'zbcjackson@odd-e.com' received mail
