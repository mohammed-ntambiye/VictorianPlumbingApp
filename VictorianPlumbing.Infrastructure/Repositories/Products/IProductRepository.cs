using System.Threading.Tasks;
using VictorianPlumbing.Domain;

namespace VictorianPlumbing.Infrastructure.Repositories
{
    public interface IProductRepository
    {
        Task StoreOder(Product order);
    }
}
