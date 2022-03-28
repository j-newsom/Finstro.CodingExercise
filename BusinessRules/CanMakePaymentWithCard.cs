// -----------------------------------------------------------------------
// <copyright file="CanMakePaymentWithCard.cs" company="Jifferson Newsom">
// Copyright (c) Jifferson Newsom. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Finstro.CodingExercise.BusinessRules
{
    using DomainValidation.Validation;
    using Finstro.CodingExercise.BusinessRules.Validators;
    using Finstro.CodingExercise.DomainEntity;

    /// <summary>
    /// The class that validates the card details.
    /// </summary>
    /// <seealso cref="Validator"/>
    public class CanMakePaymentWithCard : Validator<CreditCard>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CanMakePaymentWithCard"/> class.
        /// Validates the card number, expiry month and year to ensure the details can be used to make a payment.
        /// </summary>
        /// if the details represent a valid card:
        /// with a 16 digit card number
        /// with month part of the expiry date
        /// with year part of the expiry date
        /// <remarks>
        /// Validations:
        /// cardNumber: Ensure the passed string is 16 in length and passes the MOD10/LUHN check
        /// expiryMonth: should represent a month number between 1 and 12
        /// expiryYear: Should represent a year value, 4 characters in length and either the current or a future year
        /// The expiry month + year should represent a date in the future.
        /// </remarks>
        public CanMakePaymentWithCard()
        {
            this.Add("CardNumberIs16LengthValidator", new Rule<CreditCard>(new CardNumberIs16LengthValidator(), "The card number is less or more than 16 digits."));
            this.Add("CardNumberMOD10Validator", new Rule<CreditCard>(new CardNumberMOD10Validator(), "The card number is invalid."));
            this.Add("CardNumberExpiryMonthValidator", new Rule<CreditCard>(new CardNumberExpiryMonthValidator(), "The card number expiry month is invalid."));
            this.Add("CardNumberExpiryYearValidator", new Rule<CreditCard>(new CardNumberExpiryYearValidator(), "The card number expiry year is invalid."));
            this.Add("CardNumberExpiryMonthYearValidator", new Rule<CreditCard>(new CardNumberExpiryMonthYearValidator(), "The credit card is already expired."));
        }
    }
}