// -----------------------------------------------------------------------
// <copyright file="CreditCardController.cs" company="Jifferson Newsom">
// Copyright (c) Jifferson Newsom. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Finstro.CodingExercise.Controllers
{
    using System;
    using Finstro.CodingExercise.Contracts.Interfaces;
    using Finstro.CodingExercise.DomainEntity;
    using Finstro.CodingExercise.DomainEntity.Extensions.CreditCard;
    using Finstro.CodingExercise.DomainEntity.Extensions.Exceptions;
    using Finstro.CodingExercise.DomainEntity.Response;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// The controller class for sorting the product.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardController : ControllerBase
    {
        /// <summary>
        /// Reads the payment service.
        /// </summary>
        /// <value>The payment service.</value>
        private readonly IPaymentService paymentService;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCardController"/> class.
        /// </summary>
        /// <param name="paymentService">The payment service.</param>
        public CreditCardController(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }

        /// <summary>
        /// Make payment.
        /// </summary>
        /// <param name="creditCard">The credit card.</param>
        /// <returns>The credit card payment response.</returns>
        // Post api/<CreditCardController>
        [HttpPost]
        public ActionResult<CreditCardPaymentResponse> MakePayment(CreditCard creditCard)
        {
            try
            {
                var uniqueID = this.paymentService.MakePayment(creditCard);
                var result = uniqueID.Value.ToCreditCardPaymentResponse();
                return this.Ok(result);
            }
            catch (Exception ex)
            {
                return ex.ToCreditCardPaymentErrorResponse();
            }
        }

        /// <summary>
        /// Whats Your Id.
        /// </summary>
        /// <returns>The credit card payment response.</returns>
        // Get api/<CreditCardController>
        [HttpGet]
        public ActionResult<CreditCardPaymentResponse> WhatsYourId()
        {
            try
            {
                var uniqueID = this.paymentService.WhatsYourId();
                var result = uniqueID.ToCreditCardPaymentResponse();
                return this.Ok(result);
            }
            catch (Exception ex)
            {
                return ex.ToCreditCardPaymentErrorResponse();
            }
        }
    }
}
