using System;
using System.Threading.Tasks;

namespace VictorianPlumbing.Infrastructure.Repositories.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task StoreCustomer(Domain.Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
