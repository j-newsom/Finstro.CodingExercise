// -----------------------------------------------------------------------
// <copyright file="ConfigHelper.cs" company="Jifferson Newsom">
// Copyright (c) Jifferson Newsom. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Finstro.CodingExercise.Infrastructure.Shared
{
    using Finstro.CodingExercise.Infrastructure.Shared.Interfaces;
    using Microsoft.Extensions.Configuration;

    /// <summary>
    /// Helper class for configuration related data.
    /// </summary>
    /// <seealso cref="IConfigHelper"/>
    public class ConfigHelper : IConfigHelper
    {
        /// <summary>
        /// Reads the configuration.
        /// </summary>
        /// <value>The configuration.</value>
        private readonly IConfiguration config;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigHelper"/> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public ConfigHelper(IConfiguration config)
        {
            this.config = config;
        }

        /// <summary>
        /// Gets the unique identifier.
        /// </summary>
        /// <value>The unique identifier.</value>
        public string UniqueID
        {
            get
            {
                return this.config["UniqueID"];
            }
        }
    }
}
