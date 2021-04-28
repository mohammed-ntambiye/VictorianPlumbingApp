using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using VictorianPlumbing.Domain;

namespace VictorianPlumbing.Infrastructure.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        protected IDbConnection Db { get; private set; }

        public OrdersRepository(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString));
            }

            Db = new SqlConnection(connectionString);
        }

        public Task<IReadOnlyCollection<PlumbingOrder>> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public async Task StoreOder(PlumbingOrder order)
        {
            throw new NotImplementedException();
        }

        private async Task storeCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        private async Task storeBasket(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
