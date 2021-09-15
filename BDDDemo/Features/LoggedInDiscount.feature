﻿Feature: Logged in users has a discount
    As a user
    I want to have a 5% discount when I am logged in

    @GuestUserFullPrice
Scenario: Guest users should pay full price
    Given a user that is not logged in
    And an empty basket
    When a t-shirt that costs 5 GBP is added to the basket
    Then the basket value is 5 GBP
    
    @LoginUser5%Discount
Scenario: Logged in users should have a 5% discount
    Given a user that is logged in
    And an empty basket
    When a dress that costs 100 GBP is added to the basket
    Then the basket value is 95 GBP