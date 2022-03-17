# Coding Exercise #

## Summary ##

The candidate must code a web-api endpoints that implements the contract provided in the IPaymentService.cs file.

## Description ##

The service requires 2 operations to be implemented:

1. WhatsYourId: 009ab27c-36b1-44e4-91d5-edbd7e7b674b. This operation should return the unique ID provided by us to the candidate

2. MakePayment: should validate the card and amount and return a Guid if successful and friendly error if information is not valid

## Business rule ##

1. IsCardNumberValid: Implement the MOD10 algorithm as explained here: <https://en.wikipedia.org/wiki/Luhn_algorithm>. Include a validation for the number of digits in the card number to ensure 16 digits are passed.

2. IsValidPaymentAmount: Check if the passed number is a valid number between 99 and 99999999.

3. CanMakePaymentWithCard: Evaluate the parameters passed to ensure they represent a valid card that can be

used to make payments:

* cardNumber: is a valid 16 digit number that passes the MOD10 check as explained in 2 above

* expiryMonth: should represent a month number between 1 and 12

* expiryYear: Should represent a year value, 4 characters in lenght and either the current or a future year

* The expiry month + year should represent a date in the future

## Delivery ##

1. Fork the repository and make it private.
Note that in order for the "Fork this repository" option to be visible login to your github account. If you do not have such an account you can sign up for free at <https://github.com/signup>

2. Implement your changes.

3. Give Read Access to the following users in your repository settings.

* Kareem.Mersal@Finstro.com

* Khoa.Tong@Finstro.com

Note:- Please don't create a pull request.

## Evaluation Criteria ##

1. Implement all the operations specified in the contract

2. The solution should follow clean coding practices

     a. SOLID principles

     b. Separation of concerns without over engineering

3. Have good exception handing

4. Have adequate unit test coverage (using any unit-testing framework of the candidate�s choice)

5. Correct use of source control (Pull Requests , Branching)
