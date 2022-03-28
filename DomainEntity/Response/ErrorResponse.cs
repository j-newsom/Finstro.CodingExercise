// -----------------------------------------------------------------------
// <copyright file="ErrorResponse.cs" company="Jifferson Newsom">
// Copyright (c) Jifferson Newsom. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Finstro.CodingExercise.DomainEntity.Response
{
    using Newtonsoft.Json;

    /// <summary>
    /// The response model for error response.
    /// </summary>
    public class ErrorResponse
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets a value indicating whether the response instace is successful.
        /// </summary>
        /// <value><c>true</c> if the response instance is successful; otherwise, <c>false</c>.</value>
        [JsonProperty("isSuccessful")]
        public bool IsSuccessful
        {
            get { return this.Message == string.Empty; }
        }
    }
}
