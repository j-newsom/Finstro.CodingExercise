// -----------------------------------------------------------------------
// <copyright file="IsValidPaymentAmount.cs" company="Jifferson Newsom">
// Copyright (c) Jifferson Newsom. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Finstro.CodingExercise.BusinessRules
{
    using DomainValidation.Validation;
    using Finstro.CodingExercise.BusinessRules.Validators;
    using Finstro.CodingExercise.DomainEntity;

    /// <summary>
    /// The class that validates the payment amount.
    /// </summary>
    /// <seealso cref="IBusinessRule"/>
    public class IsValidPaymentAmount : Validator<CreditCard> // IBusinessRule<CreditCard>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsValidPaymentAmount"/> class.
        /// Checks if the amount represents a valid payment amount.
        /// </summary>
        /// <remarks>
        /// Validation:
        /// The amount must be between 99 cents and 99999999 cents.
        /// </remarks>
        public IsValidPaymentAmount() // long amount
        {
            this.Add("PaymentAmountValidator", new Rule<CreditCard>(new PaymentAmountValidator(), "The payment amount is invalid."));
        }
    }
}