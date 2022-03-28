// -----------------------------------------------------------------------
// <copyright file="Program.cs" company="Jifferson Newsom">
// Copyright (c) Jifferson Newsom. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Finstro.CodingExercise
{
    using System.Diagnostics.CodeAnalysis;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;

    /// <summary>
    /// The main program for the web API.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The parameters args.</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// The create host builder.
        /// </summary>
        /// <param name="args">The parameters args.</param>
        /// <returns>The interface host builder.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
