using System;
using System.Threading.Tasks;
using VictorianPlumbing.Domain;

namespace VictorianPlumbing.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task StoreCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
