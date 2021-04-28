using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using VictorianPlumbing.Infrastructure.Repositories;

namespace VictorianPlumbingApp.Configurations
{
    internal static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Registers the repository layer
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="logger"></param>
        /// <returns></returns>
        internal static IServiceCollection ConfigureRepositories(this IServiceCollection services,
           IConfiguration configuration, ILogger logger)
        {
            configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            logger = logger ?? throw new ArgumentNullException(nameof(logger));

            logger.LogDebug("Configuring repositories...");

            var result = services
                .AddTransient<IOrdersRepository>(s => new OrdersRepository("test"));

            logger.LogDebug("...repositories configured");

            return result;
        }
    }
}
