Feature: Find the HOME Appliance
@mytest2
  Scenario: See what Home Appliance TV HUT offers
    Given Go to the TV HUT webpage
    When I list all available Home Appliance
    Then I select one of them
  