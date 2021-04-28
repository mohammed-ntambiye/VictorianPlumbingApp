using System.Threading.Tasks;

namespace VictorianPlumbing.Infrastructure.Repositories.Customer
{
    public interface ICustomerRepository
    {
        Task StoreCustomer(Domain.Customer customer);
    }
}
