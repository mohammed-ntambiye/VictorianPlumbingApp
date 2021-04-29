using Microsoft.Extensions.DependencyInjection;
using VictorianPlumbing.Domain.Services;

namespace VictorianPlumbingApp.Configurations
{
    internal static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Registers the repository layer
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        internal static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            return services
                 .AddTransient<IPlumbingOrderService, PlumbingOrderService>();
        }
    }
}
