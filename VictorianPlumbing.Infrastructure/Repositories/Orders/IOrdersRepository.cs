using System.Threading.Tasks;
using VictorianPlumbing.Domain;

namespace VictorianPlumbing.Infrastructure.Repositories
{
    public interface IOrdersRepository
    {
        Task StoreOder(PlumbingOrder order);
    }
}
