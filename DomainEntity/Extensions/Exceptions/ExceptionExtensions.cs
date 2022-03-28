// -----------------------------------------------------------------------
// <copyright file="ExceptionExtensions.cs" company="Jifferson Newsom">
// Copyright (c) Jifferson Newsom. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Finstro.CodingExercise.DomainEntity.Extensions.Exceptions
{
    using System;
    using System.Collections.Generic;
    using Finstro.CodingExercise.DomainEntity.Response;

    /// <summary>
    /// The exception extensions class.
    /// </summary>
    public static class ExceptionExtensions
    {
        /// <summary>
        /// Converts error to a credit card payment response.
        /// </summary>
        /// <param name="ex">The exception.</param>
        /// <returns>The credit card payment response.</returns>
        public static CreditCardPaymentResponse ToCreditCardPaymentErrorResponse(this Exception ex)
        {
            return new CreditCardPaymentResponse()
            {
                UniqueID = string.Empty,
                ErrorResponse = new ErrorResponse()
                {
                    Message = ex.Message,
                },
            };
        }
    }
}
