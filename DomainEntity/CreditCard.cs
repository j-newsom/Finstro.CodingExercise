// -----------------------------------------------------------------------
// <copyright file="CreditCard.cs" company="Jifferson Newsom">
// Copyright (c) Jifferson Newsom. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Finstro.CodingExercise.DomainEntity
{
    /// <summary>
    /// The credit card domain entity.
    /// </summary>
    public class CreditCard
    {
        /// <summary>
        /// Gets or sets the 16 digit card number.
        /// </summary>
        /// <value>
        /// The 16 digit card number.
        /// </value>
        public string CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// Represents payment amount between 99 cents and 99999999 cents.
        /// </value>
        public long Amount { get; set; }

        /// <summary>
        /// Gets or sets the expirty month.
        /// </summary>
        /// <value>
        /// Credit expiry month 1 or 2 digits.
        /// </value>
        public int ExpiryMonth { get; set; }

        /// <summary>
        /// Gets or sets the expiry year.
        /// </summary>
        /// <value>
        /// Credit expiry year 4 digits.
        /// </value>
        public int ExpiryYear { get; set; }
    }
}