// -----------------------------------------------------------------------
// <copyright file="PaymentService.cs" company="Jifferson Newsom">
// Copyright (c) Jifferson Newsom. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Finstro.CodingExercise.Contracts
{
    using System;
    using System.Linq;
    using Finstro.CodingExercise.BusinessRules;
    using Finstro.CodingExercise.Contracts.Interfaces;
    using Finstro.CodingExercise.DomainEntity;
    using Finstro.CodingExercise.Infrastructure.Shared.Interfaces;

    /// <summary>
    /// The service for payment processes.
    /// </summary>
    /// <seealso cref="IPaymentService"/>
    public class PaymentService : IPaymentService
    {
        /// <summary>
        /// Reads the config helper.
        /// </summary>
        /// <value>The config helper.</value>
        private readonly IConfigHelper configHelper;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentService"/> class.
        /// </summary>
        /// <param name="configHelper">The config helper.</param>
        public PaymentService(IConfigHelper configHelper)
        {
            this.configHelper = configHelper;
        }

        /// <summary>
        /// Returns the unique ID allocated to a candidate.
        /// </summary>
        /// <returns>
        /// The unique ID allocated to a candidate.
        /// </returns>
        public string WhatsYourId()
        {
            return this.configHelper.UniqueID;
        }

        /// <summary>
        /// Returns the GUID allocated to payment.
        /// </summary>
        /// <param name="creditCard">The credit card.</param>
        /// <returns>
        /// The GUID allocated to payment.
        /// </returns>
        public Guid? MakePayment(CreditCard creditCard)
        {
            var validation = new IsCardNumberValid().Validate(creditCard);

            if (!validation.IsValid)
            {
                throw new Exception(validation.Erros.ToList().FirstOrDefault().Message);
            }

            validation = new IsValidPaymentAmount().Validate(creditCard);

            if (!validation.IsValid)
            {
                throw new Exception(validation.Erros.ToList().FirstOrDefault().Message);
            }

            validation = new CanMakePaymentWithCard().Validate(creditCard);

            if (!validation.IsValid)
            {
                throw new Exception(validation.Erros.ToList().FirstOrDefault().Message);
            }

            return new Guid(this.configHelper.UniqueID);
        }
    }
}
