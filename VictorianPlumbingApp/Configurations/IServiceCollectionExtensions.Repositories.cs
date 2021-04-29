using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
           IConfiguration configuration)
        {
            configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));

            var result = services
                .AddTransient<IOrdersRepository>(s => new OrdersRepository(""))
                .AddTransient<ICustomerRepository>(s => new CustomerRepository(""))
            .AddTransient<IProductsRepository>(s => new ProductsRepository(""));

            return result;
        }
    }
}
