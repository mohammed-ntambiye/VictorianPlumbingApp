using System.Threading.Tasks;
using VictorianPlumbing.Domain;

namespace VictorianPlumbing.Infrastructure.Repositories
{
    public interface ICustomerRepository
    {
        Task StoreCustomer(Customer customer);
    }
}
