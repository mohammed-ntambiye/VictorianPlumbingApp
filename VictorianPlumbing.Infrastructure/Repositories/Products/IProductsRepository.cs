using System.Collections.Generic;
using System.Threading.Tasks;
using VictorianPlumbing.Domain;

namespace VictorianPlumbing.Infrastructure.Repositories
{
    public interface IProductsRepository
    {
        Task StoreProducts(List<Product> products);
    }
}
