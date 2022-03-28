// -----------------------------------------------------------------------
// <copyright file="PaymentAmountValidator.cs" company="Jifferson Newsom">
// Copyright (c) Jifferson Newsom. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Finstro.CodingExercise.BusinessRules.Validators
{
    using DomainValidation.Interfaces.Specification;
    using Finstro.CodingExercise.DomainEntity;

    /// <summary>
    /// The class that validates the payment amount.
    /// </summary>
    /// <seealso cref="ISpecification"/>
    public class PaymentAmountValidator : ISpecification<CreditCard>
    {
        /// <summary>
        /// The is satisfied by method.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns><c>true</c> if the validation is successful; otherwise, <c>false</c>.</returns>
        public bool IsSatisfiedBy(CreditCard entity)
        {
            return entity.Amount >= 99 && entity.Amount <= 99999999;
        }
    }
}
