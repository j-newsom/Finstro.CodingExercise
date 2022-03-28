// -----------------------------------------------------------------------
// <copyright file="CreditCardPaymentResponse.cs" company="Jifferson Newsom">
// Copyright (c) Jifferson Newsom. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Finstro.CodingExercise.DomainEntity.Response
{
    /// <summary>
    /// The response model for credit card payment response.
    /// </summary>
    public class CreditCardPaymentResponse
    {
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>The unique identifier.</value>
        public string UniqueID { get; set; }

        /// <summary>
        /// Gets or sets the error response.
        /// </summary>
        /// <value>The error response.</value>
        public ErrorResponse ErrorResponse { get; set; }
    }
}
