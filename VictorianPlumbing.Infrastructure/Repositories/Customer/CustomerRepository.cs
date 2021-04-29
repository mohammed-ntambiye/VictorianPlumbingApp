using System;
using System.Data;
using System.Threading.Tasks;
using VictorianPlumbing.Domain;

namespace VictorianPlumbing.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        protected IDbConnection Db { get; private set; }

        public CustomerRepository(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                //throw new ArgumentNullException(nameof(connectionString));
            }

            // Db = new SqlConnection(connectionString);
        }

        public Task StoreCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
