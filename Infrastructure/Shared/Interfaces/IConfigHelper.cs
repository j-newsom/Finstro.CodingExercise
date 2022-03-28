// -----------------------------------------------------------------------
// <copyright file="IConfigHelper.cs" company="Jifferson Newsom">
// Copyright (c) Jifferson Newsom. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Finstro.CodingExercise.Infrastructure.Shared.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface that implements the <see cref="ConfigHelper"/> class.
    /// </summary>
    public interface IConfigHelper
    {
        /// <summary>
        /// Gets the unique identifier.
        /// </summary>
        /// <value>The unique identifier.</value>
        string UniqueID { get; }
    }
}
