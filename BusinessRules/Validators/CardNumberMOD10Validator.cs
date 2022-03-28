// <copyright file="CardNumberMOD10Validator.cs" company="Jifferson Newsom">
// Copyright (c) Jifferson Newsom. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Finstro.CodingExercise.BusinessRules.Validators
{
    using System.Linq;
    using DomainValidation.Interfaces.Specification;
    using Finstro.CodingExercise.DomainEntity;

    /// <summary>
    /// The class that validates the card number if passes the MOD10/LUHN check.
    /// </summary>
    /// <seealso cref="ISpecification"/>
    public class CardNumberMOD10Validator : ISpecification<CreditCard>
    {
        /// <summary>
        /// The is satisfied by method.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns><c>true</c> if the validation is successful; otherwise, <c>false</c>.</returns>
        public bool IsSatisfiedBy(CreditCard entity)
        {
            var numbers = entity.CardNumber.ToCharArray();
            int sumOfDigits = numbers.Where((e) => e >= '0' && e <= '9')
                    .Reverse()
                    .Select((e, i) => ((int)e - 48) * (i % 2 == 0 ? 1 : 2))
                    .Sum((e) => (e / 10) + (e % 10));

            return sumOfDigits % 10 == 0;
        }
    }
}
