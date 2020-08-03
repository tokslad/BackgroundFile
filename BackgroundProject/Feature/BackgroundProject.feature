Feature: BackgroundProject
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I navigate to"https://angularjs.realworld.io/#/login"
	When I click on Sign in 
	And I enter email text"janedoe118@gmail.com"
	And I enter password text"Adel0nd0n"
	And I click on sign in

@mytag
	Scenario: Creating New Article
	When I enter click on New Article
	And I write my Article Title"DemoTesting"
	And I write what my article is all about"TestingDemo"
	And I write my Article"Testing"
	And I enter tags"Demo"
	And I click on Publish Article
	Then my article should be created successfully

@mytag
	Scenario: Global Feed
	When I click on Global Feed
	Then I should be able to see all global feed 

