Feature: Product Management

Scenario: Add product
	When I add a product 'TV'
	Then I should see 'TV' in product list
