Feature: Verify the presence of offers
@mytest_3
  Scenario: User checks if specific tabs are available
    Given the user is on the website
    When User clicks on the Offer link
    Then the user should see the tabs
     