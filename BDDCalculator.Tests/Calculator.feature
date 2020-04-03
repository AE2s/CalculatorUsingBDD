Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Substract two numbers
	Given I have entered 100 into the calculator
	And I have also entered 60 into the calculator
	When I press substract
	Then the result should be 40 on the screen

Scenario: Multiply two numbers
	Given I have entered 10 into the calculator
	And I have also entered 10 into the calculator
	When I press multiply
	Then the result should be 100 on the screen

Scenario Outline: Add multiple numbers
    Given I have entered <firstNumber> into the calculator
    And I have also entered <secondNumber> into the calculator
    When I press add
    Then the result should be <result> on the screen
    Examples:
    | firstNumber            | secondNumber		| result    |
    | 10                     | 20               | 30        | 
    | 20                     | 45               | 65        |
    | 15					 | 10				| 25		|
    | 50                     | 30               | 80        |
