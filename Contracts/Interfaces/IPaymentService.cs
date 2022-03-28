// -----------------------------------------------------------------------
// <copyright file="IPaymentService.cs" company="Jifferson Newsom">
// Copyright (c) Jifferson Newsom. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Finstro.CodingExercise.Contracts.Interfaces
{
    using System;
    using Finstro.CodingExercise.DomainEntity;

    /// <summary>
    /// The contract required to be implemented by a <see cref="ProductService"/> service.
    /// </summary>
    public interface IPaymentService
    {
        /// <summary>
        /// Returns the unique ID allocated to a candidate.
        /// </summary>
        /// <returns>
        /// The unique ID allocated to a candidate.
        /// </returns>
        string WhatsYourId();

        /// <summary>
        /// Returns the GUID allocated to payment.
        /// </summary>
        /// <param name="creditCard">The credit card.</param>
        /// <returns>
        /// The GUID allocated to payment.
        /// </returns>
        Guid? MakePayment(CreditCard creditCard);
    }
}