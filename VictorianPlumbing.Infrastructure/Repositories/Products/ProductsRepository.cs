using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using VictorianPlumbing.Infrastructure.Repositories.Product;

namespace VictorianPlumbing.Infrastructure.Repositories.Products
{
    public class ProductsRepository : IProductRepository
    {
        protected IDbConnection Db { get; private set; }

        public ProductsRepository(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString));
            }

            Db = new SqlConnection(connectionString);
        }

        public Task StoreOder(Domain.Product order)
        {
            throw new System.NotImplementedException();
        }
    }
}
