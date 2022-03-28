// -----------------------------------------------------------------------
// <copyright file="CreditCardExtensions.cs" company="Jifferson Newsom">
// Copyright (c) Jifferson Newsom. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Finstro.CodingExercise.DomainEntity.Extensions.CreditCard
{
    using System;
    using Finstro.CodingExercise.DomainEntity.Response;

    /// <summary>
    /// The credit card entity extensions class.
    /// </summary>
    public static class CreditCardExtensions
    {
        /// <summary>
        /// Converts the unique identifier to credit card payment response.
        /// </summary>
        /// <param name="uniqueID">The unique identifier.</param>
        /// <returns>The credit card payment response.</returns>
        public static CreditCardPaymentResponse ToCreditCardPaymentResponse(this Guid uniqueID)
        {
            return new CreditCardPaymentResponse()
            {
                UniqueID = uniqueID.ToString(),
            };
        }

        /// <summary>
        /// Converts the unique identifier to credit card payment response.
        /// </summary>
        /// <param name="uniqueID">The unique identifier.</param>
        /// <returns>The credit card payment response.</returns>
        public static CreditCardPaymentResponse ToCreditCardPaymentResponse(this string uniqueID)
        {
            return new CreditCardPaymentResponse()
            {
                UniqueID = uniqueID.ToString(),
            };
        }
    }
}
