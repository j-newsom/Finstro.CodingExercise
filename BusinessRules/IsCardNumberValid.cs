// -----------------------------------------------------------------------
// <copyright file="IsCardNumberValid.cs" company="Jifferson Newsom">
// Copyright (c) Jifferson Newsom. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Finstro.CodingExercise.BusinessRules
{
    using DomainValidation.Validation;
    using Finstro.CodingExercise.BusinessRules.Validators;
    using Finstro.CodingExercise.DomainEntity;

    /// <summary>
    /// The class that validates the card number.
    /// </summary>
    /// <seealso cref="IBusinessRule"/>
    public class IsCardNumberValid : Validator<CreditCard> // IBusinessRule<CreditCard>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsCardNumberValid"/> class.
        /// Performs a Mod-10/LUHN check on the passed number and returns true if the check passed.
        /// </summary>
        /// <remarks>
        /// Refer here for MOD10 algorithm: https://en.wikipedia.org/wiki/Luhn_algorithm.
        /// </remarks>
        public IsCardNumberValid()
        {
            this.Add("CardNumberMOD10Validator", new Rule<CreditCard>(new CardNumberMOD10Validator(), "The card number is invalid."));
        }
    }
}