// -----------------------------------------------------------------------
// <copyright file="CardNumberExpiryMonthYearValidator.cs" company="Jifferson Newsom">
// Copyright (c) Jifferson Newsom. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Finstro.CodingExercise.BusinessRules.Validators
{
    using System;
    using DomainValidation.Interfaces.Specification;
    using Finstro.CodingExercise.DomainEntity;

    /// <summary>
    /// The class that validates the card number expiry month and year is represent a date in the future.
    /// </summary>
    /// <seealso cref="ISpecification"/>
    public class CardNumberExpiryMonthYearValidator : ISpecification<CreditCard>
    {
        /// <summary>
        /// The is satisfied by method.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns><c>true</c> if the validation is successful; otherwise, <c>false</c>.</returns>
        public bool IsSatisfiedBy(CreditCard entity)
        {
            return new DateTime(entity.ExpiryYear, entity.ExpiryMonth, 1) > DateTime.Now;
        }
    }
}
