Feature: simpleSearch
	


Scenario: Aa a user I wwant to search for a brand on studentbeans.com so that i can see if i can get a discount on that brand
	Given I am on the studentbeans homepage "https://studentbeans.com"
	And I open the search bar
	When I enter "Samsung"
	Then I should be shown a search listing for samsung