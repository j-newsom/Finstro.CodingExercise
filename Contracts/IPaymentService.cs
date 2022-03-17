using System;
using Finstro.CodingExercise.DomainEntity;

namespace Finstro.CodingExercise.Contracts
{
    /// <summary>
	/// The contract required to be implemented by a payment service
	/// </summary>
    public interface IPaymentService
    {
        /// <summary>
		/// Returns the unique ID allocated to a candidate
		/// </summary>
		string WhatsYourId();

        /// <summary>
		/// Returns the GUID allocated to payment
		/// </summary>
		Guid? MakePayment(CreditCard creditCard);
    }
}