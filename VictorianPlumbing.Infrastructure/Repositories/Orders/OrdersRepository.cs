using System;
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

        public Task StoreOder(PlumbingOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
