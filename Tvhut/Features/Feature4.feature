Feature: User Registration
@mytest_4
  Scenario: Register a new user account
    Given User is on the registration page
    When User fills in the registration form with valid information
    And User agrees to the Privacy Policy
    Then User submits the registration form
  
