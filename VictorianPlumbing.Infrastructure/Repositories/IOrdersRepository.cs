using System.Collections.Generic;
using System.Threading.Tasks;
using VictorianPlumbing.Domain;

namespace VictorianPlumbing.Infrastructure.Repositories
{
    public interface IOrdersRepository
    {
        Task<IReadOnlyCollection<PlumbingOrder>> GetAllOrders();

        Task StoreOder(PlumbingOrder order);
    }
}
