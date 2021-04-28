using System.Threading.Tasks;

namespace VictorianPlumbing.Infrastructure.Repositories.Product
{
    public interface IProductRepository
    {
        Task StoreOder(VictorianPlumbing.Domain.Product order);
    }
}
