Feature: Login to Account

@mytest_1
Scenario: User logs in to the account
    Given User is on the website
    When User clicks on the Account link
    And User enters the email 
    And User enters the password
    And User clicks the LOGIN button
   
